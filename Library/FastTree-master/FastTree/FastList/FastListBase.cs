﻿//
//  THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
//  PURPOSE.
//
//  License: GNU Lesser General Public License (LGPLv3)
//
//  Email: pavel_torgashov@ukr.net.
//
//  Copyright (C) Pavel Torgashov, 2014-2015. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

namespace FastTreeNS
{
    [ToolboxItem(false)]
    public class FastListBase : UserControl
    {
        private readonly List<int> yOfItems = new List<int>();
        private ToolTip tt;
        private int itemCount;
        protected int currentHotTrackingIndex;
        private bool showScrollBar;
        private Size localAutoScrollMinSize;

        [Browsable(false)]
        public HashSet<int> SelectedItemIndexes { get; private set; }
        [Browsable(false)]
        public int SelectedItemIndex { get { return SelectedItemIndexes.Count == 0 ? -1 : SelectedItemIndexes.First(); } }
        [Browsable(false)]
        public HashSet<int> CheckedItemIndex { get; private set; }

        [DefaultValue(true)]
        public bool ShowToolTips { get; set; }
        [DefaultValue(17)]
        public virtual int ItemHeightDefault { get; set; }
        [DefaultValue(StringAlignment.Near)]
        public virtual StringAlignment ItemLineAlignmentDefault { get; set; }
        [DefaultValue(10)]
        public virtual int ItemIndentDefault { get; set; }
        [DefaultValue(typeof(Size), "16, 16")]
        public Size IconSize { get; set; }
        [Browsable(false)]
        public bool IsEditMode { get; set; }
        [Browsable(true), DefaultValue(false)]
        public bool Readonly { get; set; }
        [DefaultValue(false)]
        public bool ShowIcons { get; set; }
        [DefaultValue(false)]
        public bool ShowCheckBoxes { get; set; }
        [DefaultValue(false)]
        public bool ShowExpandBoxes { get; set; }
        [DefaultValue(true)]
        public bool ShowEmptyExpandBoxes { get; set; }
        public virtual Image ImageCheckBoxOn { get; set; }
        public virtual Image ImageCheckBoxOff { get; set; }
        public virtual Image ImageCollapse { get; set; }
        public virtual Image ImageExpand { get; set; }
        public virtual Image ImageEmptyExpand { get; set; }
        public virtual Image ImageDefaultIcon { get; set; }

        [DefaultValue(typeof(Color), "33, 53, 80")]
        public Color SelectionColor { get; set; }
        [DefaultValue(100)]
        public int SelectionColorOpaque { get; set; }
        [DefaultValue(false)]
        public bool MultiSelect { get; set; }
        [DefaultValue(2)]
        public int ItemInterval { get; set; }
        [DefaultValue(false)]
        public bool FullItemSelect { get; set; }
        [DefaultValue(false)]
        public bool AllowDragItems { get; set; }
        [DefaultValue(true)]
        public bool AllowSelectItems { get; set; }
        [DefaultValue(false)]
        public bool HotTracking { get; set; }
        [DefaultValue(typeof(Color), "255, 192, 128")]
        public Color HotTrackingColor { get; set; }

        [Browsable(true)]
        [DefaultValue(true)]
        [Description("Scollbar visibility.")]
        public bool ShowScrollBar
        {
            get { return showScrollBar; }
            set
            {
                if (value == showScrollBar) return;
                showScrollBar = value;
                buildNeeded = true;
                Invalidate();
            }
        }

        [Browsable(false)]
        public override bool AutoScroll { get { return true; } }

        public FastListBase()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable, true);

            tt = new ToolTip() { UseAnimation = false };

            SelectedItemIndexes = new HashSet<int>();
            CheckedItemIndex = new HashSet<int>();
            InitDefaultProperties();
        }

        protected virtual void InitDefaultProperties()
        {
            IconSize = new Size(16, 16);
            ItemHeightDefault = 17;
            VerticalScroll.SmallChange = ItemHeightDefault;

            ImageCheckBoxOn = Resources.checkbox_yes;
            ImageCheckBoxOff = Resources.checkbox_no;
            ImageCollapse = Resources.collapse;
            ImageExpand = Resources.expand;
            ImageEmptyExpand = Resources.empty;
            ImageDefaultIcon = Resources.default_icon;
            SelectionColor = Color.FromArgb(33, 53, 80);
            SelectionColorOpaque = 100;
            ItemInterval = 2;
            BackColor = SystemColors.Window;
            ItemIndentDefault = 10;
            ShowToolTips = true;
            AllowSelectItems = true;
            ShowEmptyExpandBoxes = true;
            HotTrackingColor = Color.FromArgb(255, 192, 128);
            showScrollBar = true;
        }

        public virtual int ItemCount
        {
            get { return itemCount; }
            set
            {
                itemCount = value;
                if (IsHandleCreated)
                    Build();
                else
                    BuildNeeded();
            }
        }

        #region Drag&Drop

        private DragOverItemEventArgs lastDragAndDropEffect;

        protected override void OnDragOver(DragEventArgs e)
        {
            var p = new Point(e.X, e.Y);
            p = PointToClient(p);

            var itemIndex = YToIndexAround(p.Y + VerticalScroll.Value);
            var rect = CalcItemRect(itemIndex);

            var textRect = rect;
            if (visibleItemInfos.ContainsKey(itemIndex))
            {
                var info = visibleItemInfos[itemIndex];
                textRect = new Rectangle(info.X_Text, rect.Y, info.X_EndText - info.X_Text + 1, rect.Height);
            }

            var ea = new DragOverItemEventArgs(e.Data, e.KeyState, p.X, p.Y, e.AllowedEffect, e.Effect, rect, textRect) { ItemIndex = itemIndex };

            OnDragOverItem(ea);

            if (ea.Effect != DragDropEffects.None)
                lastDragAndDropEffect = ea;
            else
                lastDragAndDropEffect = null;

            e.Effect = ea.Effect;

            //scroll
            if (ea.ItemIndex >= 0 && ea.ItemIndex < ItemCount && itemIndex != ea.ItemIndex)
            {
                rect = CalcItemRect(ea.ItemIndex);
                rect.Inflate(0, 2);
                rect.Offset(HorizontalScroll.Value, VerticalScroll.Value);
                ScrollToRectangle(rect);
            }
            else
            {
                if (p.Y <= Padding.Top + ItemHeightDefault / 2)
                    ScrollUp();
                else if (p.Y >= ClientSize.Height - Padding.Bottom - +ItemHeightDefault / 2)
                    ScrollDown();
            }

            Invalidate();

            //base.OnDragOver(e);
        }

        protected virtual void OnDragOverItem(DragOverItemEventArgs e)
        {
            if (e.Y < e.ItemRect.Y + e.ItemRect.Height / 2)
                e.InsertEffect = InsertEffect.InsertBefore;
            else
                e.InsertEffect = InsertEffect.InsertAfter;
        }

        protected override void OnDragDrop(DragEventArgs e)
        {
            base.OnDragDrop(e);

            if (lastDragAndDropEffect != null)
                OnDropOverItem(lastDragAndDropEffect);

            lastDragAndDropEffect = null;
            Invalidate();
        }

        protected virtual void OnDropOverItem(DragOverItemEventArgs e)
        {
        }

        protected override void OnDragLeave(EventArgs e)
        {
            base.OnDragLeave(e);
            lastDragAndDropEffect = null;
            Invalidate();
        }

        public Rectangle CalcItemRect(int index)
        {
            Rectangle res;

            var i = index;
            if (i >= ItemCount)
                i = ItemCount - 1;

            if (i < 0)
                res = Rectangle.FromLTRB(ClientRectangle.Left + Padding.Left, ClientRectangle.Top + Padding.Top - 2, ClientRectangle.Right - Padding.Right, ClientRectangle.Top + Padding.Top - 1);
            else
            {
                var y = GetItemY(i);
                var h = GetItemY(i + 1) - y;

                res = Rectangle.FromLTRB(ClientRectangle.Left + Padding.Left, y, ClientRectangle.Right - Padding.Right,
                                         y + h);

                if (index >= itemCount)
                    res.Offset(0, (index - itemCount + 1) * ItemHeightDefault);
            }

            res.Offset(-HorizontalScroll.Value, -VerticalScroll.Value);

            return res;
        }

        #endregion Drop

        #region Keyboard

        protected override bool IsInputKey(Keys keyData)
        {
            if (!IsEditMode)
            {
                switch (keyData)
                {
                    case Keys.Home:
                    case Keys.End:
                    case Keys.PageDown:
                    case Keys.PageUp:
                    case Keys.Down:
                    case Keys.Up:
                    case Keys.Left:
                    case Keys.Right:
                    case Keys.Enter:
                    case Keys.Space:
                    case Keys.A | Keys.Control:
                        return true;

                    default:
                        return false;
                }
            }
            else
                return base.IsInputKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.Handled) return;

            CancelDelayedAction();

            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (e.Control)
                        ScrollUp();
                    else
                        SelectPrev();
                    break;

                case Keys.Down:
                    if (e.Control)
                        ScrollDown();
                    else
                        SelectNext();
                    break;

                case Keys.PageUp:
                    if (e.Control)
                        ScrollPageUp();
                    else
                    if (SelectedItemIndexes.Count > 0)
                    {
                        var i = SelectedItemIndexes.First();
                        var y = GetItemY(i) - ClientRectMinusPaddings.Height;
                        i = YToIndex(y) + 1;
                        SelectItem(Math.Max(0, Math.Min(ItemCount - 1, i)));
                    }
                    break;

                case Keys.PageDown:
                    if (e.Control)
                        ScrollPageDown();
                    else
                    if (SelectedItemIndexes.Count > 0)
                    {
                        var i = SelectedItemIndexes.First();
                        var y = GetItemY(i) + ClientRectMinusPaddings.Height;
                        i = YToIndex(y);
                        SelectItem(i < 0 ? ItemCount - 1 : i);
                    }
                    break;

                case Keys.Home:
                    if (e.Control)
                        ScrollToItem(0);
                    else
                        SelectItem(0);
                    break;

                case Keys.End:
                    if (e.Control)
                        ScrollToItem(ItemCount - 1);
                    else
                        SelectItem(ItemCount - 1);
                    break;

                case Keys.Enter:
                case Keys.Space:
                    if (ShowCheckBoxes)
                    {
                        if (SelectedItemIndexes.Count > 0)
                        {
                            var val = GetItemChecked(SelectedItemIndexes.First());
                            if (val)
                                UncheckSelected();
                            else
                                CheckSelected();
                        }
                    }
                    else
                    if (ShowExpandBoxes)
                    {
                        if (SelectedItemIndexes.Count > 0)
                        {
                            var itemIndex = SelectedItemIndexes.First();
                            if (GetItemExpanded(itemIndex))
                                CollapseItem(itemIndex);
                            else
                                ExpandItem(itemIndex);
                        }
                    }
                    break;

                case Keys.A:
                    if (e.Control)
                    {
                        SelectAll();
                    }
                    break;
            }
        }

        #endregion

        #region Dealyed Actions

        private System.Threading.Timer delayedActionTimer;

        protected void CreateDelayedAction(Action action, int delayInterval)
        {
            CancelDelayedAction();
            delayedActionTimer = new System.Threading.Timer((o) => this.Invoke(action), null, delayInterval, Timeout.Infinite);
        }

        protected void CancelDelayedAction()
        {
            if (delayedActionTimer != null)
            {
                delayedActionTimer.Change(Timeout.Infinite, Timeout.Infinite);
                delayedActionTimer.Dispose();
            }
            delayedActionTimer = null;
        }

        #endregion

        #region Mouse

        private int startDiapasonSelectedItemIndex;
        private bool mouseCanSelectArea;
        private Point startMouseSelectArea;
        private Rectangle mouseSelectArea;
        private Point lastMouseClick;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            Focus();
            mouseCanSelectArea = false;
            mouseSelectArea = Rectangle.Empty;
            lastMouseClick = e.Location;
            CancelDelayedAction();

            var item = PointToItemInfo(e.Location);

            if (item == null)
                return;

            if (e.Button == MouseButtons.Left && item.X_Text <= e.Location.X)
                if (SelectedItemIndexes.Count == 1 && SelectedItemIndexes.Contains(item.ItemIndex))
                    if (!Readonly && CanEditItem(item.ItemIndex))
                    {
                        CreateDelayedAction(() => OnStartEdit(item.ItemIndex), 500);
                    }

            if (AllowSelectItems)
                if (e.Button == MouseButtons.Left && item.X_Icon <= e.Location.X)
                {
                    //Select
                    if (MultiSelect)
                    {
                        startMouseSelectArea = e.Location;
                        startMouseSelectArea.Offset(HorizontalScroll.Value, VerticalScroll.Value);
                        mouseCanSelectArea = item.X_EndText < e.Location.X || !AllowDragItems;
                    }

                    if (!AllowDragItems || !MultiSelect)
                        OnMouseSelectItem(e, item);
                }

            if (ShowCheckBoxes && e.Button == MouseButtons.Left)
            {
                if ((item.X_CheckBox <= e.Location.X && item.X_Icon > e.Location.X) || (!AllowSelectItems))
                {
                    //Checkbox
                    OnCheckboxClick(item);
                    Invalidate();
                }
            }

            if (ShowExpandBoxes)
                if (e.Button == MouseButtons.Left && item.X_ExpandBox <= e.Location.X && item.X_CheckBox > e.Location.X)
                {
                    //Expand
                    OnExpandBoxClick(item);
                    Invalidate();
                }
        }

        protected virtual void OnMouseSelectItem(MouseEventArgs e, VisibleItemInfo item)
        {
            if (MultiSelect)
            {
                startMouseSelectArea = e.Location;
                startMouseSelectArea.Offset(HorizontalScroll.Value, VerticalScroll.Value);
                mouseCanSelectArea = item.X_EndText < e.Location.X || !AllowDragItems;

                if (Control.ModifierKeys == Keys.Control)
                {
                    if (SelectedItemIndexes.Contains(item.ItemIndex) && SelectedItemIndexes.Count > 1)
                        UnselectItem(item.ItemIndex);
                    else
                        SelectItem(item.ItemIndex, false);

                    startDiapasonSelectedItemIndex = -1;
                }
                else if (Control.ModifierKeys == Keys.Shift)
                {
                    if (SelectedItemIndexes.Count == 1)
                        startDiapasonSelectedItemIndex = SelectedItemIndexes.First();

                    if (startDiapasonSelectedItemIndex >= 0)
                        SelectItems(Math.Min(startDiapasonSelectedItemIndex, item.ItemIndex),
                                    Math.Max(startDiapasonSelectedItemIndex, item.ItemIndex));
                }
            }

            if (!MultiSelect || Control.ModifierKeys == Keys.None)
                if (!SelectedItemIndexes.Contains(item.ItemIndex) || SelectedItemIndexes.Count > 1)
                    SelectItem(item.ItemIndex, true);

            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button != MouseButtons.None)
                CancelDelayedAction();

            if (e.Button == MouseButtons.Left && mouseCanSelectArea)
            {
                if (Math.Abs(e.Location.X - startMouseSelectArea.X) > 0)
                {
                    var pos = e.Location;
                    pos.Offset(HorizontalScroll.Value, VerticalScroll.Value);
                    mouseSelectArea = new Rectangle(Math.Min(startMouseSelectArea.X, pos.X), Math.Min(startMouseSelectArea.Y, pos.Y), Math.Abs(startMouseSelectArea.X - pos.X), Math.Abs(startMouseSelectArea.Y - pos.Y));

                    var i1 = YToIndex(startMouseSelectArea.Y);
                    var i2 = YToIndex(pos.Y);
                    if (i1 >= 0 && i2 >= 0)
                    {
                        SelectItems(Math.Min(i1, i2), Math.Max(i1, i2));
                    }

                    if (e.Location.Y <= Padding.Top + ItemHeightDefault / 2)
                        ScrollUp();
                    else
                    if (e.Location.Y >= ClientSize.Height - Padding.Bottom - +ItemHeightDefault / 2)
                        ScrollDown();

                    Invalidate();
                }
                else
                    mouseSelectArea = Rectangle.Empty;
            }
            else
            if (e.Button == System.Windows.Forms.MouseButtons.Left && AllowDragItems && (Math.Abs(lastMouseClick.X - e.Location.X) > 2 || Math.Abs(lastMouseClick.Y - e.Location.Y) > 2))
            {
                var p = PointToClient(MousePosition);
                var info = PointToItemInfo(p);
                if (info != null)
                {
                    if (!SelectedItemIndexes.Contains(info.ItemIndex))
                        SelectItem(info.ItemIndex);
                    OnItemDrag(new HashSet<int>(SelectedItemIndexes));
                }
            }
            else
            if (e.Button == System.Windows.Forms.MouseButtons.None)
            {
                var p = PointToClient(MousePosition);
                var info = PointToItemInfo(p);

                if (HotTracking)
                {
                    var i = -1;
                    if (info != null)
                        i = info.ItemIndex;

                    if (currentHotTrackingIndex != i)
                    {
                        currentHotTrackingIndex = i;
                        Invalidate();
                    }
                }

                if (info != null && info.X_EndText == info.X_End)
                {
                    if (tt.Tag != info.Text && ShowToolTips)
                        tt.Show(info.Text, this, info.X_Text - 3, info.Y - 2, 2000);
                    tt.Tag = info.Text;
                }
                else
                {
                    tt.Tag = null;
                    tt.Hide(this);
                }
            }
        }

        protected virtual void OnItemDrag(HashSet<int> itemIndex)
        {
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            var item = PointToItemInfo(e.Location);

            if (item != null)
                if (AllowSelectItems)
                    if (e.Button == MouseButtons.Left && item.X_Icon <= e.Location.X)
                    {
                        if (AllowDragItems && MultiSelect && mouseSelectArea == Rectangle.Empty)
                            OnMouseSelectItem(e, item);
                    }

            mouseCanSelectArea = false;

            Invalidate();
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);

            CancelDelayedAction();

            var item = PointToItemInfo(e.Location);

            if (item != null)
                if (e.Button == MouseButtons.Left && item.X_Icon <= e.Location.X)
                {
                    if (GetItemExpanded(item.ItemIndex))
                        CollapseItem(item.ItemIndex);
                    else
                        ExpandItem(item.ItemIndex);
                }
        }

        #endregion mouse

        #region Check, Expand

        protected virtual void OnExpandBoxClick(VisibleItemInfo info)
        {
            if (info.Expanded)
                CollapseItem(info.ItemIndex);
            else
                ExpandItem(info.ItemIndex);
        }

        public virtual bool CollapseItem(int itemIndex)
        {
            Invalidate();

            if (CanCollapseItem(itemIndex))
            {
                OnItemCollapsed(itemIndex);
                return true;
            }

            return false;
        }

        public virtual bool ExpandItem(int itemIndex)
        {
            Invalidate();

            if (CanExpandItem(itemIndex))
            {
                OnItemExpanded(itemIndex);
                return true;
            }

            return false;
        }

        protected virtual void OnItemCollapsed(int itemIndex)
        {
        }

        protected virtual void OnItemExpanded(int itemIndex)
        {
        }


        protected virtual void OnCheckboxClick(VisibleItemInfo info)
        {
            if (GetItemChecked(info.ItemIndex))
                UncheckItem(info.ItemIndex);
            else
                CheckItem(info.ItemIndex);
        }

        public virtual bool CheckItem(int itemIndex)
        {
            if (GetItemChecked(itemIndex))
                return true;

            Invalidate();

            if (CanCheckItem(itemIndex))
            {
                CheckedItemIndex.Add(itemIndex);
                OnItemChecked(itemIndex);
                return true;
            }

            return false;
        }

        public virtual bool CheckAll()
        {
            var res = true;
            for (int i = 0; i < ItemCount; i++)
                res &= CheckItem(i);

            return res;
        }

        public virtual bool UncheckItem(int itemIndex)
        {
            if (!GetItemChecked(itemIndex))
                return true;

            Invalidate();

            if (CanUncheckItem(itemIndex))
            {
                CheckedItemIndex.Remove(itemIndex);
                OnItemUnchecked(itemIndex);
                return true;
            }

            return false;
        }

        public virtual bool UncheckAll()
        {
            foreach (var i in CheckedItemIndex)
                if (!CanUncheckItem(i))
                    return false;

            var list = new List<int>(CheckedItemIndex);

            CheckedItemIndex.Clear();

            foreach (var i in list)
                OnItemUnchecked(i);

            Invalidate();

            return true;
        }

        protected virtual void OnItemChecked(int itemIndex)
        {
        }

        protected virtual void OnItemUnchecked(int itemIndex)
        {
        }

        protected virtual void CheckSelected()
        {
            foreach (var i in SelectedItemIndexes)
                CheckItem(i);
        }

        protected virtual void UncheckSelected()
        {
            foreach (var i in SelectedItemIndexes)
                UncheckItem(i);
        }

        #endregion Check, Expand

        #region Selection

        public virtual bool UnselectItem(int itemIndex)
        {
            if (itemIndex < 0 || itemIndex >= ItemCount)
                return false;

            if (!SelectedItemIndexes.Contains(itemIndex))
                return true;

            if (!CanUnselectItem(itemIndex))
                return false;

            SelectedItemIndexes.Remove(itemIndex);
            OnItemUnselected(itemIndex);

            return true;
        }

        public virtual bool UnselectAll()
        {
            foreach (var i in SelectedItemIndexes)
                if (!CanUnselectItem(i))
                    return false;

            var list = new List<int>(SelectedItemIndexes);

            SelectedItemIndexes.Clear();

            foreach (var i in list)
                OnItemUnselected(i);

            Invalidate();

            return true;
        }

        public virtual bool SelectItem(int itemIndex, bool unselectOtherItems = true)
        {
            if (itemIndex < 0 || itemIndex >= ItemCount)
                return false;

            if (!CanSelectItem(itemIndex))
                return false;

            var contains = SelectedItemIndexes.Contains(itemIndex);

            if (unselectOtherItems)
            {
                foreach (var i in SelectedItemIndexes)
                    if (i != itemIndex)
                        if (!CanUnselectItem(i))
                            return false;

                var list = new List<int>(SelectedItemIndexes);

                //SelectedItemIndexes.Clear();

                foreach (var i in list)
                    if (i != itemIndex)
                    {
                        SelectedItemIndexes.Remove(i);
                        OnItemUnselected(i);
                    }
            }

            SelectedItemIndexes.Add(itemIndex);

            if (!contains)
                OnItemSelected(itemIndex);

            ScrollToItem(itemIndex);

            return true;
        }

        public virtual bool SelectItems(int from, int to)
        {
            foreach (var i in SelectedItemIndexes)
                if (i < from || i > to)
                    if (!CanUnselectItem(i))
                        return false;

            var list = new List<int>(SelectedItemIndexes);

            //SelectedItemIndexes.RemoveWhere(i=> i < from | i > to);

            foreach (var i in list)
                if (i < from || i > to)
                {
                    SelectedItemIndexes.Remove(i);
                    OnItemUnselected(i);
                }

            for (int i = from; i <= to; i++)
                if (!SelectedItemIndexes.Contains(i))
                    if (CanSelectItem(i))
                    {
                        SelectedItemIndexes.Add(i);
                        OnItemSelected(i);
                    }

            Invalidate();

            return SelectedItemIndexes.Count > 0;
        }

        public virtual bool SelectAll()
        {
            return SelectItems(0, ItemCount - 1);
        }

        public bool SelectNext(bool unselectOtherItems = true)
        {
            if (SelectedItemIndexes.Count == 0)
                return false;

            var index = SelectedItemIndexes.Max() + 1;
            if (index >= ItemCount)
                return false;

            var res = SelectItem(index, unselectOtherItems);
            if (res)
                ScrollToItem(index);

            return res;
        }

        public bool SelectPrev(bool unselectOtherItems = true)
        {
            if (SelectedItemIndexes.Count == 0)
                return false;

            var index = SelectedItemIndexes.Min() - 1;
            if (index < 0)
                return false;

            var res = SelectItem(index, unselectOtherItems);
            if (res)
                ScrollToItem(index);

            return res;
        }

        protected virtual void OnItemSelected(int itemIndex)
        {
        }

        protected virtual void OnItemUnselected(int itemIndex)
        {
        }

        #endregion

        #region Paint

        protected override void OnPaint(PaintEventArgs e)
        {
            //was build request
            if (buildNeeded)
            {
                Build();
                buildNeeded = false;
            }
            //
            e.Graphics.SetClip(ClientRectMinusPaddings);
            DrawItems(e.Graphics);

            if (lastDragAndDropEffect == null)
                DrawMouseSelectedArea(e.Graphics);
            else
                DrawDragOverInsertEffect(e.Graphics, lastDragAndDropEffect);

            base.OnPaint(e);

            if (!Enabled)
            {
                e.Graphics.SetClip(ClientRectangle);
                var color = Color.FromArgb(50, (BackColor.R + 127) >> 1, (BackColor.G + 127) >> 1, (BackColor.B + 127) >> 1);
                using (var brush = new SolidBrush(color))
                    e.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }

        protected virtual void DrawDragOverInsertEffect(Graphics gr, DragOverItemEventArgs e)
        {
            var c1 = Color.FromArgb(SelectionColor.A == 255 ? SelectionColorOpaque : SelectionColor.A, SelectionColor);
            var c2 = Color.Transparent;

            if (!visibleItemInfos.ContainsKey(e.ItemIndex))
                return;
            var info = visibleItemInfos[e.ItemIndex];
            var rect = new Rectangle(info.X_ExpandBox, info.Y, 1000, info.Height);

            switch (e.InsertEffect)
            {
                case InsertEffect.Replace:
                    using (var brush = new SolidBrush(c1))
                        gr.FillRectangle(brush, rect);
                    break;

                case InsertEffect.InsertBefore:
                    if (e.ItemIndex <= 0)
                        rect.Offset(0, 2);
                    using (var pen = new Pen(c1, 2) { DashStyle = DashStyle.Dash })
                        gr.DrawLine(pen, rect.Left, rect.Top, rect.Right, rect.Top);
                    break;

                case InsertEffect.InsertAfter:
                    if (e.ItemIndex < 0)
                        rect.Offset(0, 2);
                    using (var pen = new Pen(c1, 2) { DashStyle = DashStyle.Dash })
                        gr.DrawLine(pen, rect.Left, rect.Bottom, rect.Right, rect.Bottom);
                    break;

                case InsertEffect.AddAsChild:
                    if (e.ItemIndex >= 0 && e.ItemIndex < ItemCount)
                    {
                        var dx = GetItemIndent(e.ItemIndex) + 80;
                        rect.Offset(dx, 0);
                        using (var pen = new Pen(c1, 2) { DashStyle = DashStyle.Dash })
                            gr.DrawLine(pen, rect.Left, rect.Bottom, rect.Right, rect.Bottom);
                    }
                    break;
            }
        }

        private void DrawMouseSelectedArea(Graphics gr)
        {
            if (mouseCanSelectArea && mouseSelectArea != Rectangle.Empty)
            {
                var c = Color.FromArgb(SelectionColor.A == 255 ? SelectionColorOpaque : SelectionColor.A, SelectionColor);
                var rect = new Rectangle(mouseSelectArea.Left - HorizontalScroll.Value, mouseSelectArea.Top - VerticalScroll.Value, mouseSelectArea.Width, mouseSelectArea.Height);
                using (var pen = new Pen(c))
                    gr.DrawRectangle(pen, rect);
            }

        }

        protected virtual void DrawItems(Graphics gr)
        {
            var i = Math.Max(0, PointToIndex(new Point(Padding.Left, Padding.Top)) - 1);

            visibleItemInfos.Clear();

            for (; i < ItemCount; i++)
            {
                var info = visibleItemInfos[i] = CalcVisibleItemInfo(gr, i);
                if (info.Y > ClientSize.Height)
                    break;

                DrawItem(gr, info);
            }
        }

        protected readonly Dictionary<int, VisibleItemInfo> visibleItemInfos = new Dictionary<int, VisibleItemInfo>();

        protected virtual void DrawItem(Graphics gr, VisibleItemInfo info)
        {
            DrawItemWhole(gr, info);
        }

        public void DrawItemWhole(Graphics gr, VisibleItemInfo info)
        {
            DrawItemBackgound(gr, info);

            if (lastDragAndDropEffect == null) //do not draw selection when drag&drop over the control
                if (!IsEditMode)//do not draw selection when edit mode
                    if (SelectedItemIndexes.Contains(info.ItemIndex))
                        DrawSelection(gr, info);

            if (HotTracking && info.ItemIndex == currentHotTrackingIndex)
                DrawItemHotTracking(gr, info);


            DrawItemIcons(gr, info);
            DrawItemContent(gr, info);
        }

        protected virtual void DrawItemHotTracking(Graphics gr, VisibleItemInfo info)
        {
            var c1 = HotTrackingColor;
            var rect = info.TextAndIconRect;

            if (FullItemSelect)
            {
                var cr = ClientRectMinusPaddings;
                rect = new Rectangle(cr.Left, rect.Top, cr.Width - 1, rect.Height);
            }

            if (rect.Width > 0 && rect.Height > 0)
                using (var pen = new Pen(c1))
                    gr.DrawRectangle(pen, rect);
        }

        [Browsable(false)]
        public Rectangle ClientRectMinusPaddings
        {
            get
            {
                var rect = ClientRectangle;
                return new Rectangle(rect.Left + Padding.Left, rect.Top + Padding.Top,
                                     rect.Width - Padding.Left - Padding.Right,
                                     rect.Height - Padding.Top - Padding.Bottom);
            }
        }

        public virtual void DrawSelection(Graphics gr, VisibleItemInfo info)
        {
            var c1 = Color.FromArgb(SelectionColor.A == 255 ? SelectionColorOpaque : SelectionColor.A, SelectionColor);
            var c2 = Color.FromArgb(c1.A / 2, SelectionColor);
            var rect = info.TextAndIconRect;

            if (FullItemSelect)
            {
                var cr = ClientRectMinusPaddings;
                rect = new Rectangle(cr.Left, rect.Top, cr.Width - 1, rect.Height);
            }

            if (rect.Width > 0 && rect.Height > 0)
                using (var brush = new LinearGradientBrush(rect, c2, c1, LinearGradientMode.Vertical))
                using (var pen = new Pen(c1))
                {
                    gr.FillRectangle(brush, Rectangle.FromLTRB(rect.Left, rect.Top, rect.Right + 1, rect.Bottom + 1));
                    gr.DrawRectangle(pen, rect);
                }
        }

        /// <summary>
        /// Draws Expand box, Check box and Icon of the Item
        /// </summary>
        public virtual void DrawItemIcons(Graphics gr, VisibleItemInfo info)
        {
            if (info.ExpandBoxType > 0)
            {
                var img = (Bitmap)(info.ExpandBoxType == 2 ? ImageEmptyExpand : (info.Expanded ? ImageCollapse : ImageExpand));
                if (img != null)
                {
                    img.SetResolution(gr.DpiX, gr.DpiY);
                    gr.DrawImage(img, info.X_ExpandBox, info.Y + 1);
                }
            }

            if (info.CheckBoxVisible)
            {
                var img = (Bitmap)(GetItemChecked(info.ItemIndex) ? ImageCheckBoxOn : ImageCheckBoxOff);
                if (img != null)
                {
                    img.SetResolution(gr.DpiX, gr.DpiY);
                    gr.DrawImage(img, info.X_CheckBox, info.Y + 1);
                }
            }

            if (ShowIcons && info.Icon != null)
            {
                var img = (Bitmap)info.Icon;
                if (img != null)
                {
                    img.SetResolution(gr.DpiX, gr.DpiY);
                    gr.DrawImage(img, info.X_Icon, info.Y + 1);
                }
            }
        }

        public virtual void DrawItemContent(Graphics gr, VisibleItemInfo info)
        {
            using(var sf  = new StringFormat() { LineAlignment = info.LineAlignment })
            using (var brush = new SolidBrush(info.ForeColor))
            {
                var rect = new Rectangle(info.X_Text, info.Y + 1, info.X_EndText - info.X_Text + 1, info.Height - 1);
                //gr.DrawString(info.Text, Font, brush, info.X_Text, info.Y + 1, sf);
                gr.DrawString(info.Text, Font, brush, rect, sf);
            }
        }

        public virtual void DrawItemBackgound(Graphics gr, VisibleItemInfo info)
        {
            var backColor = info.BackColor;

            if (backColor != Color.Empty)
                using (var brush = new SolidBrush(backColor))
                    gr.FillRectangle(brush, info.TextAndIconRect);
        }

        protected virtual VisibleItemInfo CalcVisibleItemInfo(Graphics gr, int itemIndex)
        {
            var result = new VisibleItemInfo();
            result.Calc(this, itemIndex, gr);
            return result;
        }

        #endregion

        #region Coordinates

        protected virtual bool IsItemHeightFixed
        {
            get { return true; }
        }

        /// <summary>
        /// Absolute Y coordinate of the control to item index
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public int YToIndex(int y)
        {
            if (y < Padding.Top)
                return -1;

            if (ItemCount <= 0)
                return -1;

            int i = 0;

            if (IsItemHeightFixed)
            {
                i = (y - Padding.Top) / (ItemHeightDefault + ItemInterval);
            }
            else
            {
                i = yOfItems.BinarySearch(y + 1);
                if (i < 0)
                {
                    i = ~i;
                    i -= 1;
                }
            }

            if (i >= ItemCount)
                return -1;

            return i;
        }

        protected virtual int GetItemY(int index)
        {
            if (IsItemHeightFixed)
                return Padding.Top + index * (ItemHeightDefault + ItemInterval);
            else
                return yOfItems[index];
        }

        protected int YToIndexAround(int y)
        {
            if (ItemCount <= 0)
                return -1;

            var i = 0;

            if (IsItemHeightFixed)
            {
                i = (y - Padding.Top) / (ItemHeightDefault + ItemInterval);
            }
            else
            {
                i = yOfItems.BinarySearch(y + 1);
                if (i < 0)
                {
                    i = ~i;
                    i -= 1;
                }
            }

            if (i < 0)
                i = 0;

            if (i >= ItemCount)
                i = ItemCount - 1;

            return i;
        }

        /// <summary>
        /// Control visible rect coordinates to item index
        /// </summary>
        public int PointToIndex(Point p)
        {
            if (p.X < Padding.Left || p.X > ClientRectangle.Right - Padding.Right)
                return -1;

            var y = p.Y + VerticalScroll.Value;

            return YToIndex(y);
        }

        /// <summary>
        /// Control visible rect coordinates to item info
        /// </summary>
        public virtual VisibleItemInfo PointToItemInfo(Point p)
        {
            var index = PointToIndex(p);
            VisibleItemInfo info = null;
            visibleItemInfos.TryGetValue(index, out info);

            return info;
        }

        /// <summary>
        ///   x0  x1  x2  x3      x4     x5
        ///   |   |   |   |       |      |
        ///   □   □   □   ItemText       
        /// </summary>
        public class VisibleItemInfo
        {
            public int ItemIndex;
            public int Y;
            public int Height;
            public string Text;
            public int X;
            public int X_ExpandBox;
            public int X_CheckBox;
            public int X_Icon;
            public int X_Text;
            public int X_EndText;
            public int X_End;
            public bool CheckBoxVisible;
            public int ExpandBoxType;
            public Image Icon;
            public bool Expanded;
            public Color ForeColor;
            public Color BackColor;
            public StringAlignment LineAlignment = StringAlignment.Near;

            public Rectangle FullRect
            {
                get { return new Rectangle(X, Y, X_End - X + 1, Height); }
            }

            public Rectangle Rect
            {
                get { return new Rectangle(X_ExpandBox, Y, X_EndText - X + 1, Height); }
            }

            public Rectangle TextAndIconRect
            {
                get { return new Rectangle(X_Icon, Y, X_EndText - X_Icon + 1, Height); }
            }

            public Rectangle TextRect
            {
                get { return new Rectangle(X_Text, Y, X_EndText - X_Text + 1, Height); }
            }

            public virtual void Calc(FastListBase list, int itemIndex, Graphics gr)
            {
                //var vertScroll = list.VerticalScroll.Visible ? list.VerticalScroll.Value : 0;
                var vertScroll = list.VerticalScroll.Value;//!!!!!!!!!!!!

                ItemIndex = itemIndex;
                CheckBoxVisible = list.ShowCheckBoxes && list.GetItemCheckBoxVisible(itemIndex);
                Icon = list.GetItemIcon(itemIndex);
                LineAlignment = list.GetItemLineAlignment(itemIndex);
                var y = list.GetItemY(itemIndex);
                Y = y - vertScroll;
                Height = list.GetItemY(itemIndex + 1) - y - list.ItemInterval;
                Text = list.GetItemText(itemIndex) ?? "";
                Expanded = list.GetItemExpanded(itemIndex);
                var temp = list.ShowEmptyExpandBoxes ? 2 : 0;
                ExpandBoxType = list.ShowExpandBoxes ? (Expanded ? (list.CanCollapseItem(itemIndex) ? 1 : temp) : (list.CanExpandItem(itemIndex) ? 1 : temp)) : 0;
                BackColor = list.GetItemBackColor(itemIndex);
                ForeColor = list.GetItemForeColor(itemIndex);

                X = list.Padding.Left;
                var x = list.GetItemIndent(itemIndex) + list.Padding.Left;
                X_ExpandBox = x;
                if (list.ShowExpandBoxes) x += list.ImageExpand.Width + 2;
                X_CheckBox = x;
                if (list.ShowCheckBoxes) x += list.ImageCheckBoxOn.Width + 2;
                X_Icon = x;
                if (list.ShowIcons) x += list.IconSize.Width + 2;
                X_Text = x;
                x += (int)gr.MeasureString(Text, list.Font).Width + 1;
                X_End = list.ClientSize.Width - list.Padding.Right - 2;
                X_EndText = Math.Min(x, X_End);
            }
        }

        #endregion

        #region Build

        protected virtual void Build()
        {
            yOfItems.Clear();

            int y = Padding.Top;

            if (!IsItemHeightFixed)
            {
                for (int i = 0; i < itemCount; i++)
                {
                    yOfItems.Add(y);
                    y += GetItemHeight(i) + ItemInterval;
                }

                yOfItems.Add(y);
            }
            else
            {
                y += itemCount * (ItemHeightDefault + ItemInterval);
            }


            SelectedItemIndexes.RemoveWhere(i => i >= itemCount);
            CheckedItemIndex.RemoveWhere(i => i >= itemCount);

            AutoScrollMinSize = new Size(AutoScrollMinSize.Width, y + Padding.Bottom + 2);
            Invalidate();
        }

        bool buildNeeded;

        public virtual void BuildNeeded()
        {
            buildNeeded = true;
        }

        #endregion

        #region Get item info methods

        protected virtual int GetItemHeight(int itemIndex)
        {
            return ItemHeightDefault;
        }

        public virtual int GetItemIndent(int itemIndex)
        {
            return ItemIndentDefault;
        }

        protected virtual string GetItemText(int itemIndex)
        {
            return string.Empty;
        }

        protected virtual void OnItemTextPushed(int itemIndex, string text)
        {
            Invalidate();
        }

        protected virtual bool GetItemCheckBoxVisible(int itemIndex)
        {
            return ShowCheckBoxes;
        }

        protected virtual bool GetItemChecked(int itemIndex)
        {
            return CheckedItemIndex.Contains(itemIndex);
        }

        protected virtual Image GetItemIcon(int itemIndex)
        {
            return null;
        }

        protected virtual StringAlignment GetItemLineAlignment(int itemIndex)
        {
            return StringAlignment.Near;
        }

        protected virtual Color GetItemBackColor(int itemIndex)
        {
            return Color.Empty;
        }

        protected virtual Color GetItemForeColor(int itemIndex)
        {
            return ForeColor;
        }

        protected virtual bool GetItemExpanded(int itemIndex)
        {
            return false;
        }

        protected virtual bool CanUnselectItem(int itemIndex)
        {
            return true;
        }

        protected virtual bool CanSelectItem(int itemIndex)
        {
            return AllowSelectItems;
        }

        protected virtual bool CanUncheckItem(int itemIndex)
        {
            return true;
        }

        protected virtual bool CanCheckItem(int itemIndex)
        {
            return true;
        }

        protected virtual bool CanExpandItem(int itemIndex)
        {
            return true;
        }

        protected virtual bool CanCollapseItem(int itemIndex)
        {
            return true;
        }

        protected virtual bool CanEditItem(int itemIndex)
        {
            return true;
        }

        #endregion

        #region Scroll

        protected virtual void ScrollUp()
        {
            OnScrollVertical(VerticalScroll.Value - VerticalScroll.SmallChange);
        }

        protected virtual void ScrollDown()
        {
            OnScrollVertical(VerticalScroll.Value + VerticalScroll.SmallChange);
        }

        protected virtual void ScrollPageUp()
        {
            OnScrollVertical(VerticalScroll.Value - VerticalScroll.LargeChange);
        }

        protected virtual void ScrollPageDown()
        {
            OnScrollVertical(VerticalScroll.Value + VerticalScroll.LargeChange);
        }

        public new Size AutoScrollMinSize
        {
            set
            {
                if (showScrollBar)
                {
                    if (!base.AutoScroll)
                        base.AutoScroll = true;
                    Size newSize = value;
                    base.AutoScrollMinSize = newSize;
                }
                else
                {
                    if (base.AutoScroll)
                        base.AutoScroll = false;
                    base.AutoScrollMinSize = new Size(0, 0);
                    VerticalScroll.Visible = false;
                    HorizontalScroll.Visible = false;
                    VerticalScroll.Maximum = Math.Max(0, value.Height - ClientSize.Height);
                    HorizontalScroll.Maximum = Math.Max(0, value.Width - ClientSize.Width);
                    localAutoScrollMinSize = value;
                }
            }

            get
            {
                if (showScrollBar)
                    return base.AutoScrollMinSize;
                else
                    return localAutoScrollMinSize;
            }
        }

        /// <summary>
        /// Updates scrollbar position after Value changed
        /// </summary>
        public void UpdateScrollbars()
        {
            if (ShowScrollBar)
            {
                //some magic for update scrolls
                base.AutoScrollMinSize -= new Size(1, 0);
                base.AutoScrollMinSize += new Size(1, 0);
            }
            else
                AutoScrollMinSize = AutoScrollMinSize;

            if (IsHandleCreated)
                BeginInvoke((MethodInvoker)OnScrollbarsUpdated);
        }

        protected virtual void OnScrollbarsUpdated()
        {
        }

        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;
        private const int SB_ENDSCROLL = 0x8;
        private const int WM_MOUSEWHEEL = 0x20A;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HSCROLL || m.Msg == WM_VSCROLL)
                if (m.WParam.ToInt32() != SB_ENDSCROLL)
                {
                    Focus();
                    Invalidate();
                }
            if (m.Msg == WM_MOUSEWHEEL)
            {
                //var step = 3 * ItemHeightDefault * Math.Sign(-m.WParam.ToInt64());
                var step = -3 * ItemHeightDefault * Math.Sign((short) (m.WParam.ToInt64() >> 16));
                if(VerticalScroll.Visible)
                    OnScroll(new ScrollEventArgs(ScrollEventType.ThumbPosition, VerticalScroll.Value + step, ScrollOrientation.VerticalScroll));
                Focus();
                return;
            }

            base.WndProc(ref m);
        }

        public void ScrollToRectangle(Rectangle rect)
        {
            rect = new Rectangle(rect.X - HorizontalScroll.Value, rect.Y - VerticalScroll.Value, rect.Width, rect.Height);

            int v = VerticalScroll.Value;
            int h = HorizontalScroll.Value;

            if (rect.Bottom > ClientRectangle.Height)
                v += rect.Bottom - ClientRectangle.Height;
            else if (rect.Top < Padding.Top)
                v += rect.Top - Padding.Top;

            if (rect.Right > ClientRectangle.Width)
                h += rect.Right - ClientRectangle.Width;
            else if (rect.Left < Padding.Left)
                h += rect.Left - Padding.Left;
            //
            v = Math.Max(VerticalScroll.Minimum, v);
            h = Math.Max(HorizontalScroll.Minimum, h);
            //
            try
            {
                OnScrollVertical(v);
            }
            catch (ArgumentOutOfRangeException)
            {
                ;
            }
        }

        public void ScrollToItem(int itemIndex)
        {
            if (itemIndex < 0 || itemIndex >= ItemCount)
                return;

            var y = GetItemY(itemIndex);
            var height = GetItemHeight(itemIndex);
            ScrollToRectangle(new Rectangle(0, y, ClientRectangle.Width, height));
        }

        public void OnScrollVertical(int newVerticalScrollBarValue)
        {
            OnScroll(new ScrollEventArgs(ScrollEventType.ThumbPosition, newVerticalScrollBarValue, ScrollOrientation.VerticalScroll));
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            if (se.ScrollOrientation == ScrollOrientation.VerticalScroll)
                VerticalScroll.Value = Math.Max(VerticalScroll.Minimum, Math.Min(VerticalScroll.Maximum, se.NewValue));

            UpdateScrollbars();
            Invalidate();
            //
            base.OnScroll(se);
        }

        #endregion

        #region Edit

        protected int EditItemIndex;
        protected Control EditControl;
        protected int editUpdating = 0;

        public virtual void OnStartEdit(int itemIndex, string startValue = null)
        {
            if (!visibleItemInfos.ContainsKey(itemIndex))
                return;

            var info = visibleItemInfos[itemIndex];

            EditItemIndex = itemIndex;
            IsEditMode = true;
            var ctrl = new TextBox() { Text = GetItemText(itemIndex), AcceptsTab = true, Multiline = false, WordWrap = false };
            ctrl.Bounds = new Rectangle(info.X_Text, info.Y, info.X_End - info.X_Text, info.Height);
            ctrl.Parent = this;
            ctrl.Focus();
            if (startValue != null)
            {
                ctrl.Text = startValue;
                (ctrl as TextBox).SelectionStart = startValue.Length;
            }
            ctrl.LostFocus += (o, a) => OnEndEdit();
            ctrl.PreviewKeyDown += (o, a) => a.IsInputKey = true;
            ctrl.KeyDown += (o, a) =>
            {
                switch (a.KeyCode)
                {
                    case Keys.Escape: OnEndEdit(null); a.Handled = true; a.SuppressKeyPress = true; break;
                    case Keys.Enter: OnEndEdit(); a.Handled = true; a.SuppressKeyPress = true; break;
                }
            };
            EditControl = ctrl;
            Invalidate();
        }

        public virtual void OnEndEdit()
        {
            string val = null;

            if (EditControl != null)
                val = EditControl.Text;

            OnEndEdit(val);
        }

        public virtual void OnEndEdit(string newValue)
        {
            if (editUpdating > 0)
                return;

            try
            {
                editUpdating++;

                if (newValue != null)
                    OnItemTextPushed(EditItemIndex, newValue);

                if (EditControl != null)
                    EditControl.Parent = null;

                EditControl = null;
                IsEditMode = false;
                //mouseCanSelect = false;
                Invalidate();
            }
            finally
            {
                editUpdating--;
            }
        }

        #endregion

        #region Routines

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            Invalidate();
        }

        #endregion

        #region ISupportInitialize

        protected bool IsInitializing;

        public void BeginInit()
        {
            IsInitializing = true;
        }

        public void EndInit()
        {
            IsInitializing = false;
            ItemCount = ItemCount;
        }

        #endregion ISupportInitialize
    }

    public class DragOverItemEventArgs : DragEventArgs
    {
        public int ItemIndex { get; set; }
        public InsertEffect InsertEffect { get; set; }
        public Rectangle ItemRect { get; private set; }
        public Rectangle TextRect { get; private set; }
        public object Tag { get; set; }

        public DragOverItemEventArgs(IDataObject data, int keyState, int x, int y, DragDropEffects allowedEffects, DragDropEffects effect, Rectangle itemRect, Rectangle textRect)
            : base(data, keyState, x, y, allowedEffects, effect)
        {
            this.ItemRect = itemRect;
            this.TextRect = textRect;
        }
    }

    public enum InsertEffect
    {
        None,
        InsertBefore,
        InsertAfter,
        Replace,
        AddAsChild
    }
}
