using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using DataSql;
using DXFLibrary;
using netDxf;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.Layers;
using SchemeCtrl2.SnapPoint;

namespace SchemeCtrl2.DrawTool
{
	[Serializable]
	public abstract class DrawObjectBase : IDisposable
	{
		public DrawObjectBase()
		{
			
			this.color_1 = Color.Red;
			this.color_2 = Color.Empty;
			this.list_0 = new List<DrawObjectBase>();
			this.string_0 = "<Object>";
			this.int_0 = 12;
			this.bool_2 = true;
			this.bool_4 = true;
			this.xmlCoords = new XmlDocument();
			this.telemetryValues_0 = TelemetryValues.Empty;
			
			this.method_0();
		}

		public DrawObjectBase(DataRow r)
		{
			
			this.color_1 = Color.Red;
			this.color_2 = Color.Empty;
			this.list_0 = new List<DrawObjectBase>();
			this.string_0 = "<Object>";
			this.int_0 = 12;
			this.bool_2 = true;
			this.bool_4 = true;
			this.xmlCoords = new XmlDocument();
			this.telemetryValues_0 = TelemetryValues.Empty;
			
			this.method_0();
			this.IdBase = Convert.ToInt32(r["Id"]);
			this.Text = r["Name"].ToString();
		}

		public event DrawObjectBaseEventHandler EndDrawEvent
		{
			[CompilerGenerated]
			add
			{
				DrawObjectBaseEventHandler drawObjectBaseEventHandler = this.drawObjectBaseEventHandler_0;
				DrawObjectBaseEventHandler drawObjectBaseEventHandler2;
				do
				{
					drawObjectBaseEventHandler2 = drawObjectBaseEventHandler;
					DrawObjectBaseEventHandler value2 = (DrawObjectBaseEventHandler)Delegate.Combine(drawObjectBaseEventHandler2, value);
					drawObjectBaseEventHandler = Interlocked.CompareExchange<DrawObjectBaseEventHandler>(ref this.drawObjectBaseEventHandler_0, value2, drawObjectBaseEventHandler2);
				}
				while (drawObjectBaseEventHandler != drawObjectBaseEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectBaseEventHandler drawObjectBaseEventHandler = this.drawObjectBaseEventHandler_0;
				DrawObjectBaseEventHandler drawObjectBaseEventHandler2;
				do
				{
					drawObjectBaseEventHandler2 = drawObjectBaseEventHandler;
					DrawObjectBaseEventHandler value2 = (DrawObjectBaseEventHandler)Delegate.Remove(drawObjectBaseEventHandler2, value);
					drawObjectBaseEventHandler = Interlocked.CompareExchange<DrawObjectBaseEventHandler>(ref this.drawObjectBaseEventHandler_0, value2, drawObjectBaseEventHandler2);
				}
				while (drawObjectBaseEventHandler != drawObjectBaseEventHandler2);
			}
		}

		public event DrawNewObjectEventHandler DrawNewObjectEvent
		{
			[CompilerGenerated]
			add
			{
				DrawNewObjectEventHandler drawNewObjectEventHandler = this.drawNewObjectEventHandler_0;
				DrawNewObjectEventHandler drawNewObjectEventHandler2;
				do
				{
					drawNewObjectEventHandler2 = drawNewObjectEventHandler;
					DrawNewObjectEventHandler value2 = (DrawNewObjectEventHandler)Delegate.Combine(drawNewObjectEventHandler2, value);
					drawNewObjectEventHandler = Interlocked.CompareExchange<DrawNewObjectEventHandler>(ref this.drawNewObjectEventHandler_0, value2, drawNewObjectEventHandler2);
				}
				while (drawNewObjectEventHandler != drawNewObjectEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawNewObjectEventHandler drawNewObjectEventHandler = this.drawNewObjectEventHandler_0;
				DrawNewObjectEventHandler drawNewObjectEventHandler2;
				do
				{
					drawNewObjectEventHandler2 = drawNewObjectEventHandler;
					DrawNewObjectEventHandler value2 = (DrawNewObjectEventHandler)Delegate.Remove(drawNewObjectEventHandler2, value);
					drawNewObjectEventHandler = Interlocked.CompareExchange<DrawNewObjectEventHandler>(ref this.drawNewObjectEventHandler_0, value2, drawNewObjectEventHandler2);
				}
				while (drawNewObjectEventHandler != drawNewObjectEventHandler2);
			}
		}

		public event DrawObjectBaseEventHandler ErrorEvent
		{
			[CompilerGenerated]
			add
			{
				DrawObjectBaseEventHandler drawObjectBaseEventHandler = this.drawObjectBaseEventHandler_1;
				DrawObjectBaseEventHandler drawObjectBaseEventHandler2;
				do
				{
					drawObjectBaseEventHandler2 = drawObjectBaseEventHandler;
					DrawObjectBaseEventHandler value2 = (DrawObjectBaseEventHandler)Delegate.Combine(drawObjectBaseEventHandler2, value);
					drawObjectBaseEventHandler = Interlocked.CompareExchange<DrawObjectBaseEventHandler>(ref this.drawObjectBaseEventHandler_1, value2, drawObjectBaseEventHandler2);
				}
				while (drawObjectBaseEventHandler != drawObjectBaseEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectBaseEventHandler drawObjectBaseEventHandler = this.drawObjectBaseEventHandler_1;
				DrawObjectBaseEventHandler drawObjectBaseEventHandler2;
				do
				{
					drawObjectBaseEventHandler2 = drawObjectBaseEventHandler;
					DrawObjectBaseEventHandler value2 = (DrawObjectBaseEventHandler)Delegate.Remove(drawObjectBaseEventHandler2, value);
					drawObjectBaseEventHandler = Interlocked.CompareExchange<DrawObjectBaseEventHandler>(ref this.drawObjectBaseEventHandler_1, value2, drawObjectBaseEventHandler2);
				}
				while (drawObjectBaseEventHandler != drawObjectBaseEventHandler2);
			}
		}

		public event DrawObjectBaseEventHandler ObjectRemoved
		{
			[CompilerGenerated]
			add
			{
				DrawObjectBaseEventHandler drawObjectBaseEventHandler = this.drawObjectBaseEventHandler_2;
				DrawObjectBaseEventHandler drawObjectBaseEventHandler2;
				do
				{
					drawObjectBaseEventHandler2 = drawObjectBaseEventHandler;
					DrawObjectBaseEventHandler value2 = (DrawObjectBaseEventHandler)Delegate.Combine(drawObjectBaseEventHandler2, value);
					drawObjectBaseEventHandler = Interlocked.CompareExchange<DrawObjectBaseEventHandler>(ref this.drawObjectBaseEventHandler_2, value2, drawObjectBaseEventHandler2);
				}
				while (drawObjectBaseEventHandler != drawObjectBaseEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectBaseEventHandler drawObjectBaseEventHandler = this.drawObjectBaseEventHandler_2;
				DrawObjectBaseEventHandler drawObjectBaseEventHandler2;
				do
				{
					drawObjectBaseEventHandler2 = drawObjectBaseEventHandler;
					DrawObjectBaseEventHandler value2 = (DrawObjectBaseEventHandler)Delegate.Remove(drawObjectBaseEventHandler2, value);
					drawObjectBaseEventHandler = Interlocked.CompareExchange<DrawObjectBaseEventHandler>(ref this.drawObjectBaseEventHandler_2, value2, drawObjectBaseEventHandler2);
				}
				while (drawObjectBaseEventHandler != drawObjectBaseEventHandler2);
			}
		}

		public event DrawObjectBaseEventHandler SelectedChanged
		{
			[CompilerGenerated]
			add
			{
				DrawObjectBaseEventHandler drawObjectBaseEventHandler = this.drawObjectBaseEventHandler_3;
				DrawObjectBaseEventHandler drawObjectBaseEventHandler2;
				do
				{
					drawObjectBaseEventHandler2 = drawObjectBaseEventHandler;
					DrawObjectBaseEventHandler value2 = (DrawObjectBaseEventHandler)Delegate.Combine(drawObjectBaseEventHandler2, value);
					drawObjectBaseEventHandler = Interlocked.CompareExchange<DrawObjectBaseEventHandler>(ref this.drawObjectBaseEventHandler_3, value2, drawObjectBaseEventHandler2);
				}
				while (drawObjectBaseEventHandler != drawObjectBaseEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				DrawObjectBaseEventHandler drawObjectBaseEventHandler = this.drawObjectBaseEventHandler_3;
				DrawObjectBaseEventHandler drawObjectBaseEventHandler2;
				do
				{
					drawObjectBaseEventHandler2 = drawObjectBaseEventHandler;
					DrawObjectBaseEventHandler value2 = (DrawObjectBaseEventHandler)Delegate.Remove(drawObjectBaseEventHandler2, value);
					drawObjectBaseEventHandler = Interlocked.CompareExchange<DrawObjectBaseEventHandler>(ref this.drawObjectBaseEventHandler_3, value2, drawObjectBaseEventHandler2);
				}
				while (drawObjectBaseEventHandler != drawObjectBaseEventHandler2);
			}
		}

		private void DrawObjectBase_DrawNewObjectEvent(DrawObjectBase drawObjectBase_2, DrawObjectBase drawObjectBase_3)
		{
		}

		private void DrawObjectBase_EndDrawEvent(DrawObjectBase drawObjectBase_2)
		{
			this.EndDraw();
		}

		public object Tag { get; set; }

		public GroupDrawObjectBase Group { get; set; }

		public virtual bool LimitedEditing { get; set; }

		public virtual DrawObjectBase Master
		{
			get
			{
				return this.drawObjectBase_1;
			}
			set
			{
				if (value != null && base.GetType() != value.GetType())
				{
					return;
				}
				this.drawObjectBase_1 = value;
			}
		}

		public virtual int IdBase { get; set; }

		public virtual bool Deleted
		{
			get
			{
				return this.bool_5;
			}
			set
			{
				this.bool_5 = value;
			}
		}

		public virtual string IdOldBase { get; set; }

		public float Width
		{
			get
			{
				if (this.Layer != null && this.UseLayerWidth)
				{
					return this.Layer.Width;
				}
				return this.float_0;
			}
			set
			{
				this.float_0 = value;
			}
		}

		public virtual Color Color
		{
			get
			{
				if (this.Layer != null && this.Layer.Parent != null && this.UseSettingColor)
				{
					return this.Layer.Color;
				}
				return this.color_0;
			}
			set
			{
				this.color_0 = value;
			}
		}

		public virtual Color SelectedColor
		{
			get
			{
				if (this.Layer != null && this.Layer.Parent != null)
				{
					return this.Layer.Parent.Settings.SelectedObjColor;
				}
				return this.color_1;
			}
			set
			{
				this.color_1 = value;
			}
		}

		public Color Fill
		{
			get
			{
				return this.color_2;
			}
			set
			{
				this.color_2 = value;
			}
		}

		public virtual bool Selected
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				if (this.bool_0 != value)
				{
					if (this.Group != null)
					{
						this.Group.Selected = value;
					}
					if (!value)
					{
						this.RemoveContextMenus();
					}
					this.bool_0 = value;
					if (this.drawObjectBaseEventHandler_3 != null)
					{
						this.drawObjectBaseEventHandler_3(this);
					}
				}
			}
		}

		public virtual bool Highlighted
		{
			get
			{
				return this.bool_3;
			}
			set
			{
				this.bool_3 = value;
			}
		}

		public virtual bool Flashing
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
			}
		}

		public virtual DrawingLayer Layer
		{
			get
			{
				return this.drawingLayer_0;
			}
			set
			{
				this.drawingLayer_0 = value;
			}
		}

		public virtual int NodeCount
		{
			get
			{
				return 0;
			}
		}

		public virtual string Text
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		public virtual TextFont TextProperty
		{
			get
			{
				return this.textFont_0;
			}
			set
			{
				this.textFont_0 = value;
			}
		}

		public virtual DrawObjectBase Parent
		{
			get
			{
				return this.drawObjectBase_0;
			}
			set
			{
				if (value == null)
				{
					if (this.drawObjectBase_0 != null)
					{
						this.drawObjectBase_0.RemoveChildObject(this);
						this.drawObjectBase_0 = null;
						return;
					}
				}
				else
				{
					if (this.drawObjectBase_0 == null)
					{
						this.drawObjectBase_0 = value;
						this.drawObjectBase_0.AddChildObject(this);
						return;
					}
					if (this.drawObjectBase_0 != value)
					{
						if (this.drawObjectBase_0.list_0.Contains(this))
						{
							this.drawObjectBase_0.RemoveChildObject(this);
						}
						this.drawObjectBase_0 = value;
						this.drawObjectBase_0.AddChildObject(this);
					}
				}
			}
		}

		public virtual IEnumerable<DrawObjectBase> ChildObjects
		{
			get
			{
				return this.list_0;
			}
		}

		public bool UseLayerWidth
		{
			get
			{
				return this.method_1((DrawObjectBase.Enum2)4);
			}
			set
			{
				this.method_2((DrawObjectBase.Enum2)4, value);
			}
		}

		public bool UseSettingColor
		{
			get
			{
				return this.method_1((DrawObjectBase.Enum2)8);
			}
			set
			{
				this.method_2((DrawObjectBase.Enum2)8, value);
			}
		}

		public bool UseSettingsText
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				this.bool_2 = value;
			}
		}

		public virtual bool Visible
		{
			get
			{
				return this.bool_4;
			}
			set
			{
				this.bool_4 = value;
			}
		}

		public virtual DrawObjectBaseError Error
		{
			get
			{
				return this.drawObjectBaseError_0;
			}
			set
			{
				if (this.drawObjectBaseError_0 != null)
				{
					this.drawObjectBaseEventHandler_1(this);
				}
				else
				{
					this.drawObjectBaseError_0.Fix();
				}
				this.drawObjectBaseError_0 = value;
			}
		}

		public List<DrawObjectBase> Bookmark
		{
			get
			{
				return this.list_1;
			}
			set
			{
				this.list_1 = value;
			}
		}

		public virtual TelemetryValues TelemetryValues
		{
			get
			{
				return this.telemetryValues_0;
			}
			set
			{
				this.telemetryValues_0 = value;
			}
		}

		public NeedToPreserveEnum NeedToPreserve
		{
			get
			{
				return this.needToPreserveEnum_0;
			}
			set
			{
				this.needToPreserveEnum_0 = value;
			}
		}

		public virtual string StripText
		{
			get
			{
				return this.ToString();
			}
		}

		private void method_0()
		{
			this.EndDrawEvent += this.DrawObjectBase_EndDrawEvent;
			this.DrawNewObjectEvent += this.DrawObjectBase_DrawNewObjectEvent;
			this.textFont_0 = new TextFont("Arial", 15f, false, false, false, ePositionText.T, false, false, Color.White);
		}

		private bool method_1(DrawObjectBase.Enum2 enum2_0)
		{
			return (this.int_0 & (int)enum2_0) > 0;
		}

		private void method_2(DrawObjectBase.Enum2 enum2_0, bool bool_7)
		{
			if (bool_7)
			{
				this.int_0 |= (int)enum2_0;
				return;
			}
			this.int_0 &= (int)(~(int)enum2_0);
		}

		public virtual string GetFullName()
		{
			return this.ToString();
		}

		public virtual void InitializeFromModel(UnitPoint point, DrawingLayer layer, ISnapPoint snap)
		{
		}

		public virtual void vmethod_0(XmlNode xmlNode, List<PointTool> pointList)
		{
		}

		public virtual void AddChildObject(DrawObjectBase item)
		{
			this.list_0.Add(item);
		}

		public virtual bool RemoveChildObject(DrawObjectBase item)
		{
			return this.list_0.Remove(item);
		}

		public virtual void Copy(DrawObjectBase acopy)
		{
			this.UseSettingColor = acopy.UseSettingColor;
			this.UseLayerWidth = acopy.UseLayerWidth;
			this.Width = acopy.Width;
			this.Color = acopy.Color;
			this.Fill = acopy.Fill;
			this.Layer = acopy.Layer;
			this.Text = acopy.Text;
			this.TextProperty = new TextFont(acopy.TextProperty.FontName, acopy.TextProperty.FontSize, acopy.TextProperty.FontBold, acopy.TextProperty.FontItalic, acopy.TextProperty.FontUnderline, acopy.TextProperty.Position, acopy.TextProperty.FontVirtical, acopy.TextProperty.Visible, acopy.TextProperty.Color);
			this.IdBase = acopy.IdBase;
		}

		public virtual DrawObjectBase Clone(bool SaveParentRelation)
		{
			return null;
		}

		public virtual void Remove(bool delSql, bool bool_7)
		{
			if (delSql)
			{
				this.DeleteSql();
			}
			if (this.Layer != null)
			{
				this.Layer.RemoveObject(this);
			}
			if (this.Parent != null && !this.Parent.Deleted)
			{
				this.Parent.list_0.Remove(this);
			}
			for (int i = this.list_0.ToArray().Length - 1; i >= 0; i--)
			{
				if (this.list_0[i].GetType() != typeof(PointTool))
				{
					this.list_0[i].Remove(delSql, true);
				}
			}
			if (this.drawObjectBaseEventHandler_2 != null)
			{
				this.drawObjectBaseEventHandler_2(this);
			}
		}

		public virtual bool PointInObject(UnitPoint point)
		{
			return false;
		}

		public virtual bool ObjectInRectangle(CanvasControl canvas, RectangleF rect, bool anyPoint)
		{
			return false;
		}

		public virtual void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawmode = eDrawMode.Color)
		{
			throw new NotImplementedException();
		}

		public virtual void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
		}

		public virtual RectangleF GetBoundingRect(CanvasControl canvas, bool inflate)
		{
			return RectangleF.Empty;
		}

		public virtual ISnapPoint SnapPoint(CanvasControl canvas, UnitPoint point, List<DrawObjectBase> otherobj, Type[] runningsnaptypes, Type usersnaptype)
		{
			return null;
		}

		public virtual void Move(UnitPoint offset, bool selectedMove)
		{
		}

		public virtual void MoveHandleTo(UnitPoint point, int handleNumber)
		{
		}

		public virtual void Normalize()
		{
		}

		public virtual void EndDraw()
		{
		}

		public virtual bool HaveContact(DrawObjectBase obj)
		{
			return false;
		}

		public virtual bool Undo()
		{
			return false;
		}

		public virtual bool Redo()
		{
			return false;
		}

		public void CreateUniqueCopyName()
		{
			if (this.Layer == null)
			{
				return;
			}
			if (this.Layer.Parent == null)
			{
				return;
			}
			if (!this.Layer.Parent.ValidateToUnique(this))
			{
				int num = this.Text.IndexOf("_");
				if (num >= 0)
				{
					string s = this.Text.Substring(num + 1);
					int num2 = -1;
					if (int.TryParse(s, out num2))
					{
						this.Text = this.Text.Remove(num + 1);
						this.Text += (num2 + 1).ToString();
					}
					else
					{
						this.Text += "_1";
					}
				}
				else
				{
					this.Text += "_1";
				}
				if (!this.Layer.Parent.ValidateToUnique(this))
				{
					this.CreateUniqueCopyName();
				}
			}
		}

		public virtual void Align()
		{
		}

		public override string ToString()
		{
			return this.Text;
		}

		public virtual List<DrawObjectBase> GetPowerSource()
		{
			return new List<DrawObjectBase>();
		}

		public virtual List<DrawObjectBase> GetRecipientsPower()
		{
			return new List<DrawObjectBase>();
		}

		public virtual DrawObjectBase CreateImage()
		{
			return null;
		}

		protected float ThresholdWidth(CanvasControl canvas, float objectwidth)
		{
			return this.method_3(canvas, objectwidth, 6f);
		}

		private float method_3(CanvasControl canvasControl_0, float float_1, float float_2)
		{
			double val = ConvertCanvas.ConvertToUnit(canvasControl_0, float_2);
			return (float)Math.Max((double)(float_1 / 2f), val);
		}

		protected virtual UnitPoint GetNode(int nodeNumber)
		{
			return new UnitPoint(0.0, 0.0);
		}

		protected RectangleF GetNodeRectangle(CanvasControl canvas, int nodeNumber)
		{
			PointF pointF = ConvertCanvas.ConvertToScreen(canvas, this.GetNode(nodeNumber));
			if (canvas.Zoom < 1f)
			{
				return new RectangleF(pointF.X - 3f * canvas.Zoom, pointF.Y - 3f * canvas.Zoom, 7f * canvas.Zoom, 7f * canvas.Zoom);
			}
			return new RectangleF(pointF.X - 3f, pointF.Y - 3f, 7f, 7f);
		}

		protected void DrawTracker(CanvasControl canvas)
		{
			if (this.Selected && this.Visible)
			{
				SolidBrush solidBrush = new SolidBrush(Color.White);
				for (int i = 1; i <= this.NodeCount; i++)
				{
					canvas.Graphics.FillRectangle(solidBrush, this.GetNodeRectangle(canvas, i));
				}
				solidBrush.Dispose();
				return;
			}
		}

		public virtual int HitTest(CanvasControl canvas, PointF point)
		{
			return -1;
		}

		public virtual Cursor GetHandleCursor(int handleNumber)
		{
			return Cursors.Default;
		}

		protected virtual RectangleF GetRectangleText(CanvasControl canvas)
		{
			return RectangleF.Empty;
		}

		protected virtual void DrawText(CanvasControl canvas, eDrawMode drawMode = eDrawMode.Color)
		{
			if (this.Visible && this.TextProperty.Visible)
			{
				if (this.UseSettingsText && this.TextProperty.FontSize * canvas.Zoom <= canvas.Settings.FontSizeNoVisible && (drawMode & eDrawMode.Print) != eDrawMode.Print)
				{
					return;
				}
				using (Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style))
				{
					RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(canvas, this.GetRectangleText(canvas));
					GraphicsState gstate = canvas.Graphics.Save();
					if (this.textFont_0.FontVirtical)
					{
						Matrix transform = canvas.Graphics.Transform;
						rectangleF.Y += rectangleF.Height;
						transform.RotateAt(-90f, rectangleF.Location, MatrixOrder.Append);
						canvas.Graphics.Transform = transform;
					}
					if (rectangleF.Size.Width > 0f && rectangleF.Size.Height > 0f)
					{
						using (SolidBrush solidBrush = new SolidBrush(this.TextProperty.Color))
						{
							if ((drawMode & eDrawMode.Print) == eDrawMode.Print)
							{
								if ((drawMode & eDrawMode.Color) != eDrawMode.Color)
								{
									solidBrush.Color = Color.Black;
								}
								else if (canvas.Settings.BackgroundColor.ToArgb() == solidBrush.Color.ToArgb() && solidBrush.Color.ToArgb() == Color.White.ToArgb())
								{
									solidBrush.Color = Color.Black;
								}
							}
							else if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
							{
								if (this.Selected)
								{
									solidBrush.Color = this.SelectedColor;
								}
							}
							else if (this.Selected)
							{
								solidBrush.Color = Color.Gray;
							}
							canvas.Graphics.DrawString(this.Text, font, solidBrush, rectangleF.Location);
						}
					}
					canvas.Graphics.Restore(gstate);
				}
			}
		}

		public virtual void OnMouseMove(CanvasControl canvas, UnitPoint point, MouseButtons button)
		{
			if (button == MouseButtons.Left)
			{
				eCommandType eCommandType_ = canvas.eCommandType_0;
				if (eCommandType_ == eCommandType.draw)
				{
					RectangleF unitrect = ConvertCanvas.ConvertToScreenNormalized(canvas, this.GetBoundingRect(canvas, true));
					unitrect.Inflate(3f, 3f);
					canvas.method_21(new Rectangle((int)unitrect.X, (int)unitrect.Y, (int)unitrect.Width, (int)unitrect.Height));
					this.Draw(canvas, unitrect, eDrawMode.Color);
				}
			}
		}

		public virtual void OnMouseUp(CanvasControl canvas, UnitPoint point, ISnapPoint snappoint, MouseButtons button)
		{
			if (button == MouseButtons.Left)
			{
				switch (canvas.eCommandType_0)
				{
				case eCommandType.move:
				case eCommandType.resizeObj:
					break;
				case eCommandType.draw:
					this.Normalize();
					if (base.GetType() != typeof(LineTool) && base.GetType() != typeof(LineCellTool) && base.GetType() != typeof(Class14))
					{
						this.drawObjectBaseEventHandler_0(this);
					}
					break;
				default:
					return;
				}
			}
		}

		public virtual void OnMouseDown(CanvasControl canvas, UnitPoint point, ISnapPoint snappoint, MouseButtons button)
		{
		}

		public virtual void OnMouseDoubleClick(CanvasControl canvas, UnitPoint point, MouseButtons button)
		{
			if (button == MouseButtons.Left)
			{
				switch (canvas.eCommandType_0)
				{
				case eCommandType.select:
				case eCommandType.netSelect:
				case eCommandType.move:
				case eCommandType.resizeObj:
				{
					PointF pointF = ConvertCanvas.ConvertToScreen(canvas, point);
					this.ShowPropertyForm(new Point((int)pointF.X, (int)pointF.Y));
					break;
				}
				case eCommandType.pan:
				case eCommandType.draw:
					break;
				default:
					return;
				}
			}
		}

		public virtual void OnKeyDown(CanvasControl canvas, KeyEventArgs e)
		{
		}

		public virtual bool ShowPropertyForm(Point location)
		{
			return false;
		}

		protected void OnEndDrawEvent(DrawObjectBase sender)
		{
			if (this.drawObjectBaseEventHandler_0 != null)
			{
				this.drawObjectBaseEventHandler_0(sender);
			}
		}

		protected virtual void CallEndDrawEvent(DrawObjectBase sender)
		{
			this.SaveToSql(false, true);
			this.OnEndDrawEvent(sender);
		}

		protected void CallDrawNewObjectEvent(DrawObjectBase sender, DrawObjectBase newObject)
		{
			this.drawNewObjectEventHandler_0(sender, newObject);
		}

		protected virtual void RemoveContextMenus()
		{
		}

		internal virtual void vmethod_1()
		{
		}

		public virtual int GetTypeObject()
		{
			return -1;
		}

		protected Form GetForm(Control ctrl)
		{
			if (ctrl.Parent == null)
			{
				return null;
			}
			if (ctrl.Parent is Form)
			{
				return (Form)ctrl.Parent;
			}
			return this.GetForm(ctrl.Parent);
		}

		protected Form GetMdiForm(Control ctrl)
		{
			if (ctrl.Parent == null)
			{
				return null;
			}
			if (ctrl.Parent is Form && ((Form)ctrl.Parent).IsMdiContainer)
			{
				return (Form)ctrl.Parent;
			}
			return this.GetMdiForm(ctrl.Parent);
		}

		internal bool method_4(bool bool_7, bool bool_8)
		{
			if (this.Layer == null)
			{
				return false;
			}
			if (this.Layer.Parent == null)
			{
				return false;
			}
			if (this.Layer.Parent.Connected)
			{
				this.Layer.Parent.method_54(this, bool_8);
				return true;
			}
			return this.SaveToSql(bool_7, bool_8);
		}

		public virtual bool SaveToSql(bool isbackground, bool children)
		{
			if (this.Layer == null)
			{
				return false;
			}
			if (this.Layer.Parent == null)
			{
				return false;
			}
			if (this.Layer.Parent.SqlSettings == null)
			{
				return false;
			}
			if (!this.Layer.Parent.UseObjectFromDB)
			{
				return false;
			}
			if (isbackground)
			{
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += this.method_5;
				backgroundWorker.RunWorkerCompleted += this.method_6;
				CanvasControl parent = this.Layer.Parent;
				int workerCounter = parent.WorkerCounter;
				parent.WorkerCounter = workerCounter + 1;
				backgroundWorker.RunWorkerAsync(children);
			}
			else
			{
				if (!this.SaveToSql())
				{
					return false;
				}
				if (children)
				{
					foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
					{
						drawObjectBase.SaveToSql(isbackground, children);
					}
				}
			}
			return true;
		}

		public virtual string GetUpdateScriptXML(bool children, List<int> id)
		{
			if (this.IdBase > 0)
			{
				this.vmethod_4();
				string text = " update tSChm_Xml set [SchemaXml] = ' " + this.xmlCoords.InnerXml + "'";
				RectangleTool rectangleTool = null;
				if (this.Layer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond)
				{
					foreach (DrawObjectBase drawObjectBase in this.Layer.Objects)
					{
						if (drawObjectBase is RectangleTool)
						{
							rectangleTool = (RectangleTool)drawObjectBase;
							break;
						}
					}
				}
				if (rectangleTool != null)
				{
					text = text + ", [Tag] = " + rectangleTool.IdBase.ToString();
				}
				text = string.Concat(new string[]
				{
					text,
					" where Objid = ",
					this.IdBase.ToString(),
					" AND TypeSchema = ",
					((int)this.Layer.Parent.TypeCanvas).ToString()
				});
				if (rectangleTool != null)
				{
					text = text + " AND (Tag = " + rectangleTool.IdBase.ToString() + " OR Tag is NULL)";
				}
				if (id.Contains(this.IdBase))
				{
					text = "";
				}
				else
				{
					id.Add(this.IdBase);
				}
				StringBuilder stringBuilder = new StringBuilder();
				if (children)
				{
					foreach (DrawObjectBase drawObjectBase2 in this.list_0)
					{
						if (drawObjectBase2.GetType() != typeof(SplitterShinaTool))
						{
							stringBuilder.Append(drawObjectBase2.GetUpdateScriptXML(children, id));
						}
					}
				}
				return text + stringBuilder.ToString();
			}
			if (base.GetType() == typeof(SplitterShinaTool))
			{
				return ((SplitterShinaTool)this).parentShina.GetUpdateScriptXML(children, id);
			}
			return "";
		}

		protected virtual bool SaveToSql()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.Layer.Parent.SqlSettings);
			DataSetScheme @class = new DataSetScheme();
			if (this.IdBase > 0)
			{
				sqlDataCommand.SelectSqlData(@class.tSchm_ObjList, true, " where id = " + this.IdBase.ToString(), null, false, 0);
				if (@class.tSchm_ObjList.Rows.Count == 0)
				{
					DataRow dataRow = @class.DataTableCollection_0["tSchm_ObjList"].NewRow();
					dataRow["Name"] = this.Text;
					dataRow["TypeCodeId"] = this.GetTypeObject();
					if (this.Parent != null)
					{
						if (this is ObjectOnLine)
						{
							dataRow["idParent"] = ((Branch)this.Parent).CouplingRelation.Id;
						}
						else
						{
							dataRow["idParent"] = this.Parent.IdBase;
						}
					}
					if (base.GetType() == typeof(LineTool))
					{
						DrawObjectBase drawObjectBase = ((LineTool)this).ParRectangle();
						if (drawObjectBase != null)
						{
							dataRow["idParentAddl"] = drawObjectBase.IdBase;
						}
						else
						{
							dataRow["idParentAddl"] = DBNull.Value;
						}
					}
					if (this is ObjectOnLine)
					{
						dataRow["OnOff"] = ((ObjectOnLine)this).On;
					}
					else
					{
						dataRow["OnOff"] = DBNull.Value;
					}
					@class.DataTableCollection_0["tSchm_ObjList"].Rows.Add(dataRow);
					this.IdBase = sqlDataCommand.InsertSqlDataOneRow(@class.DataTableCollection_0["tSchm_ObjList"]);
					if (this.IdBase <= 0)
					{
						return false;
					}
					this.SaveXmlToSql();
				}
				else
				{
					if (@class.tSchm_ObjList.Rows[0]["Name"].ToString() != this.Text)
					{
						@class.tSchm_ObjList.Rows[0]["Name"] = this.Text;
					}
					if ((int)@class.tSchm_ObjList.Rows[0]["TypeCodeId"] != this.GetTypeObject())
					{
						@class.tSchm_ObjList.Rows[0]["TypeCodeId"] = this.GetTypeObject();
					}
					if (this.Parent != null)
					{
						if (this is ObjectOnLine)
						{
							if ((int)@class.tSchm_ObjList.Rows[0]["idParent"] != ((Branch)this.Parent).CouplingRelation.Id)
							{
								@class.tSchm_ObjList.Rows[0]["idParent"] = ((Branch)this.Parent).CouplingRelation.Id;
							}
						}
						else if (@class.tSchm_ObjList.Rows[0].IsNull("idParent") || (int)@class.tSchm_ObjList.Rows[0]["idParent"] != this.Parent.IdBase)
						{
							@class.tSchm_ObjList.Rows[0]["idParent"] = this.Parent.IdBase;
						}
					}
					else
					{
						@class.tSchm_ObjList.Rows[0]["idParent"] = DBNull.Value;
					}
					if (base.GetType() == typeof(LineTool))
					{
						DrawObjectBase drawObjectBase2 = ((LineTool)this).ParRectangle();
						if (drawObjectBase2 != null)
						{
							if (@class.tSchm_ObjList.Rows[0].IsNull("idParentAddl") || (int)@class.tSchm_ObjList.Rows[0]["idParentAddl"] != drawObjectBase2.IdBase)
							{
								@class.tSchm_ObjList.Rows[0]["idParentAddl"] = drawObjectBase2.IdBase;
							}
						}
						else if (@class.tSchm_ObjList.Rows[0]["idParentAddl"] != DBNull.Value)
						{
							@class.tSchm_ObjList.Rows[0]["idParentAddl"] = DBNull.Value;
						}
					}
					if (this is ObjectOnLine)
					{
						if (@class.tSchm_ObjList.Rows[0].IsNull("OnOff") || (bool)@class.tSchm_ObjList.Rows[0]["OnOff"] != ((ObjectOnLine)this).On)
						{
							@class.tSchm_ObjList.Rows[0]["OnOff"] = ((ObjectOnLine)this).On;
						}
					}
					else
					{
						@class.tSchm_ObjList.Rows[0]["OnOff"] = DBNull.Value;
					}
					@class.tSchm_ObjList.Rows[0].EndEdit();
					if (!sqlDataCommand.UpdateSqlData(@class, @class.tSchm_ObjList))
					{
						return false;
					}
					this.SaveXmlToSql();
				}
			}
			else
			{
				DataRow dataRow2 = @class.DataTableCollection_0["tSchm_ObjList"].NewRow();
				dataRow2["Name"] = this.Text;
				dataRow2["TypeCodeId"] = this.GetTypeObject();
				if (this.Parent != null)
				{
					if (this is ObjectOnLine)
					{
						dataRow2["idParent"] = ((Branch)this.Parent).CouplingRelation.Id;
					}
					else
					{
						dataRow2["idParent"] = this.Parent.IdBase;
					}
				}
				if (base.GetType() == typeof(LineTool))
				{
					DrawObjectBase drawObjectBase3 = ((LineTool)this).ParRectangle();
					if (drawObjectBase3 != null)
					{
						dataRow2["idParentAddl"] = drawObjectBase3.IdBase;
					}
					else
					{
						dataRow2["idParentAddl"] = DBNull.Value;
					}
				}
				if (this is ObjectOnLine)
				{
					dataRow2["OnOff"] = ((ObjectOnLine)this).On;
				}
				else
				{
					dataRow2["OnOff"] = DBNull.Value;
				}
				@class.DataTableCollection_0["tSchm_ObjList"].Rows.Add(dataRow2);
				this.IdBase = sqlDataCommand.InsertSqlDataOneRow(@class.DataTableCollection_0["tSchm_ObjList"]);
				if (this.IdBase <= 0)
				{
					return false;
				}
				this.SaveXmlToSql();
			}
			return true;
		}

		public virtual void SaveXmlToSql()
		{
			if (this.Layer == null)
			{
				return;
			}
			SqlConnection sqlConnection = new SqlConnection(SqlDataConnect.GetConnectionString(this.Layer.Parent.SqlSettings));
			string text = string.Concat(new object[]
			{
				"select top 1 * from tSChm_Xml where ObjId = ",
				this.IdBase,
				" and TypeSchema = ",
				(int)this.drawingLayer_0.Parent.TypeCanvas
			});
			RectangleTool rectangleTool = null;
			if (this.drawingLayer_0.Parent.TypeCanvas == eTypeCanvas.SchemeSecond)
			{
				foreach (DrawObjectBase drawObjectBase in this.Layer.Objects)
				{
					if (drawObjectBase is RectangleTool)
					{
						rectangleTool = (RectangleTool)drawObjectBase;
						break;
					}
				}
			}
			if (rectangleTool != null)
			{
				text = text + " and (Tag = " + rectangleTool.IdBase.ToString() + " or Tag is null)";
			}
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand(text, sqlConnection);
			this.vmethod_4();
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			if (!sqlDataReader.Read())
			{
				sqlDataReader.Close();
				string str = "insert into tSChm_Xml (ObjId, TypeSchema, SChemaXml";
				string text2 = string.Concat(new string[]
				{
					") values (",
					this.IdBase.ToString(),
					", ",
					((int)this.drawingLayer_0.Parent.TypeCanvas).ToString(),
					", '",
					this.xmlCoords.InnerXml,
					"'"
				});
				if (rectangleTool != null)
				{
					str += ", Tag";
					text2 = text2 + ", " + rectangleTool.IdBase.ToString();
				}
				text = str + text2 + ")";
				new SqlCommand(text, sqlConnection).ExecuteScalar();
				return;
			}
			if (sqlDataReader["SchemaXml"].ToString() != this.xmlCoords.InnerXml.ToString())
			{
				text = "update tSchm_Xml set SchemaXml = '" + this.xmlCoords.InnerXml + "'";
				if (rectangleTool != null)
				{
					text = text + ", Tag = " + rectangleTool.IdBase.ToString();
				}
				DbCommand dbCommand = new SqlCommand(text + " where id = " + sqlDataReader["id"].ToString(), sqlConnection);
				sqlDataReader.Close();
				dbCommand.ExecuteScalar();
				return;
			}
			sqlDataReader.Close();
		}

		public virtual bool DeleteSql()
		{
			if (this.Layer == null)
			{
				return false;
			}
			if (this.Layer.Parent == null)
			{
				return false;
			}
			if (this.Layer.Parent.SqlSettings == null)
			{
				return false;
			}
			if (!this.Layer.Parent.UseObjectFromDB)
			{
				return false;
			}
			if (this.IdBase == 0)
			{
				return false;
			}
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.Layer.Parent.SqlSettings);
			if (!this.LimitedEditing)
			{
				this.Deleted = sqlDataCommand.UpdateSqlData(this.drawingLayer_0.Parent.dsScheme.tSchm_ObjList, " set [DELETED] = 1 ", " WHERE [ID] = " + this.IdBase.ToString());
			}
			else
			{
				RectangleTool rectangleTool = null;
				if (this.drawingLayer_0.Parent.TypeCanvas == eTypeCanvas.SchemeSecond)
				{
					foreach (DrawObjectBase drawObjectBase in this.Layer.Objects)
					{
						if (drawObjectBase is RectangleTool)
						{
							rectangleTool = (RectangleTool)drawObjectBase;
							break;
						}
					}
				}
				if (rectangleTool != null)
				{
					this.Deleted = sqlDataCommand.DeleteSqlData(this.drawingLayer_0.Parent.dsScheme.tSchm_Xml, string.Concat(new string[]
					{
						" where ObjId = ",
						this.IdBase.ToString(),
						" and TypeSchema = ",
						((int)this.drawingLayer_0.Parent.TypeCanvas).ToString(),
						"and Tag = ",
						rectangleTool.IdBase.ToString()
					}));
				}
				else
				{
					this.Deleted = sqlDataCommand.DeleteSqlData(this.drawingLayer_0.Parent.dsScheme.tSchm_Xml, " where ObjId = " + this.IdBase.ToString() + " and TypeSchema = " + ((int)this.drawingLayer_0.Parent.TypeCanvas).ToString());
				}
			}
			return this.Deleted;
		}

		public virtual void vmethod_2(CanvasControl canvas, Document document)
		{
		}

		public virtual void vmethod_3(CanvasControl canvas, DxfDocument document)
		{
		}

		private void method_5(object sender, DoWorkEventArgs e)
		{
			this.SaveToSql();
			if ((bool)e.Argument)
			{
				foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
				{
					if (base.GetType() != typeof(LineCellTool) || drawObjectBase.GetType() != typeof(PointTool))
					{
						drawObjectBase.SaveToSql(false, true);
					}
				}
			}
		}

		private void method_6(object sender, RunWorkerCompletedEventArgs e)
		{
			CanvasControl parent = this.Layer.Parent;
			int workerCounter = parent.WorkerCounter;
			parent.WorkerCounter = workerCounter - 1;
		}

		protected virtual void vmethod_4()
		{
			this.xmlCoords = new XmlDocument();
			this.xmlCoords.LoadXml("<Obj></Obj>");
			XmlNode xmlNode = this.xmlCoords.SelectSingleNode("Obj");
			this.currentXmlScheme = xmlNode;
		}

		public void Dispose()
		{
			this.Dispose(true);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					this.drawingLayer_0 = null;
					this.drawObjectBase_1 = null;
					this.drawObjectBase_0 = null;
					this.list_0.Clear();
				}
				this.disposed = true;
			}
		}

		~DrawObjectBase()
		{
			this.Dispose(false);
		}

		public static PointTool GetLinkPoint(DrawObjectBase dob1, DrawObjectBase dob2)
		{
			PointTool result = null;
			if (dob1 is LineTool && dob2 is LineTool)
			{
				IEnumerable<PointTool> ends = ((LineTool)dob1).Ends;
				Func<PointTool, bool> <>9__0;
				Func<PointTool, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((PointTool p) => ((LineTool)dob2).Ends.Contains(p)));
				}
				using (IEnumerator<PointTool> enumerator = ends.Where(predicate).GetEnumerator())
				{
					if (!enumerator.MoveNext())
					{
						return result;
					}
					return enumerator.Current;
				}
			}
			ShinaTool shinaTool = null;
			LineTool line = null;
			if (dob1 is LineTool && dob2.GetType() == typeof(ShinaTool))
			{
				shinaTool = (ShinaTool)dob2;
				line = (LineTool)dob1;
			}
			else if (dob2 is LineTool && dob1.GetType() == typeof(ShinaTool))
			{
				shinaTool = (ShinaTool)dob1;
				line = (LineTool)dob2;
			}
			if (shinaTool != null && line != null)
			{
				IEnumerable<DrawObjectBase> childObjects = shinaTool.ChildObjects;
				Func<DrawObjectBase, bool> <>9__1;
				Func<DrawObjectBase, bool> predicate2;
				if ((predicate2 = <>9__1) == null)
				{
					predicate2 = (<>9__1 = ((DrawObjectBase p) => p is PointTool && line.Ends.Contains((PointTool)p)));
				}
				using (IEnumerator<DrawObjectBase> enumerator2 = childObjects.Where(predicate2).GetEnumerator())
				{
					if (enumerator2.MoveNext())
					{
						result = (PointTool)enumerator2.Current;
					}
				}
			}
			return result;
		}

		protected const string OBJ_XML = "/Obj";

		private float float_0;

		private Color color_0;

		private Color color_1;

		private Color color_2;

		[NonSerialized]
		private DrawingLayer drawingLayer_0;

		[NonSerialized]
		private DrawObjectBase drawObjectBase_0;

		[NonSerialized]
		private List<DrawObjectBase> list_0;

		private bool bool_0;

		private bool bool_1;

		private string string_0;

		[NonSerialized]
		private TextFont textFont_0;

		private int int_0;

		private bool bool_2;

		private bool bool_3;

		private bool bool_4;

		protected XmlDocument xmlCoords;

		protected XmlNode currentXmlScheme;

		private DrawObjectBaseError drawObjectBaseError_0;

		private List<DrawObjectBase> list_1;

		private DrawObjectBase drawObjectBase_1;

		private bool bool_5;

		private TelemetryValues telemetryValues_0;

		private NeedToPreserveEnum needToPreserveEnum_0;

		[CompilerGenerated]
		private DrawObjectBaseEventHandler drawObjectBaseEventHandler_0;

		[CompilerGenerated]
		private DrawNewObjectEventHandler drawNewObjectEventHandler_0;

		[CompilerGenerated]
		private DrawObjectBaseEventHandler drawObjectBaseEventHandler_1;

		[CompilerGenerated]
		private DrawObjectBaseEventHandler drawObjectBaseEventHandler_2;

		[CompilerGenerated]
		private DrawObjectBaseEventHandler drawObjectBaseEventHandler_3;

		[CompilerGenerated]
		private object object_0;

		[CompilerGenerated]
		private GroupDrawObjectBase groupDrawObjectBase_0;

		[CompilerGenerated]
		private bool bool_6;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private string string_1;

		protected bool disposed;

		private enum Enum2
		{

		}
	}
}
