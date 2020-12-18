using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EIS.Forms
{
    partial class FormMain
    {
        // Окна каскадом
        private void toolStripMenuItemCascade_Click(object sender, EventArgs e)
        {
            ((Form)this).LayoutMdi(MdiLayout.Cascade);
        }
        // окна по горизонтали
        private void toolStripMenuItemTileHorizontal_Click(object sender, EventArgs e)
        {
            ((Form)this).LayoutMdi(MdiLayout.TileHorizontal);
        }
        // окна по вертикали
        private void toolStripMenuItemTileVertical_Click(object sender, EventArgs e)
        {
            ((Form)this).LayoutMdi(MdiLayout.TileVertical);
        }
        // закрыть все окна
        private void toolStripMenuItemWindowCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in ((Form)this).MdiChildren)
            {
                for (int index = 0; index < this.toolStripMain.Items.Count; ++index)
                {
                    if (this.toolStripMain.Items[index].Tag == mdiChild)
                    {
                        this.toolStripMain.Items.RemoveAt(index);
                        break;
                    }
                }
                mdiChild.Close();
            }
        }
        // Открытие меню окна
        private void toolStripMenuItemWindows_DropDownOpening(object sender, EventArgs e)
        {
            int num = 0;
            foreach (Form mdiChild in ((Form)this).MdiChildren)
            {
                ++num;
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                toolStripMenuItem.Text = num.ToString() + " " + mdiChild.Text;
                toolStripMenuItem.Click += new EventHandler(item_Click);
                toolStripMenuItem.Tag = (object)mdiChild;
                if (((Form)this).ActiveMdiChild == mdiChild)
                {
                    toolStripMenuItem.Checked = true;
                    toolStripMenuItem.CheckOnClick = true;
                    toolStripMenuItem.CheckState = CheckState.Checked;
                }
                if (num == 1) // первое окно
                    this.toolStripMenuItemWindows.DropDownItems.Add((ToolStripItem)new ToolStripSeparator());
                this.toolStripMenuItemWindows.DropDownItems.Add((ToolStripItem)toolStripMenuItem);
            }
            if (num > 0)
            {
                this.toolStripMenuItemWindowCloseAll.Enabled = true;
                this.toolStripMenuItemCascade.Enabled = true;
                this.toolStripMenuItemTileHorizontal.Enabled = true;
                this.toolStripMenuItemTileVertical.Enabled = true;
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                toolStripMenuItem.Text = "Список окон...";
                toolStripMenuItem.Click += new EventHandler(this.formsList_Click);
                toolStripMenuItem.Tag = (object)1;
                this.toolStripMenuItemWindows.DropDownItems.Add((ToolStripItem)toolStripMenuItem);
            }
            else
            {
                this.toolStripMenuItemWindowCloseAll.Enabled = false;
                this.toolStripMenuItemCascade.Enabled = false;
                this.toolStripMenuItemTileHorizontal.Enabled = false;
                this.toolStripMenuItemTileVertical.Enabled = false;
            }
        }
        // Закрытие меню окна
        private void toolStripMenuItemWindows_DropDownClosed(object sender, EventArgs e)
        {
            bool flag = false;
            for (int index = 0; index < this.toolStripMenuItemWindows.DropDownItems.Count; ++index)
            {
                if (this.toolStripMenuItemWindows.DropDownItems[index].GetType() == typeof(ToolStripSeparator))
                    flag = true;
                if (flag)
                {
                    this.toolStripMenuItemWindows.DropDownItems.RemoveAt(index);
                    --index;
                }
            }
        }
        // Восстановить свернутое окно
        private void toolStripMenuItemWindowsRestore_Click(object obj, EventArgs e)
        {
            Form tag = (Form)((ToolStripItem)obj).GetCurrentParent().Tag;
            tag.Activate();
            tag.WindowState = FormWindowState.Normal;
            tag.Visible = true;
        }
        // Свернуть окно
        private void toolStripMenuItemWindowsMinimize_Click(object obj, EventArgs e)
        {
            ((Form)((ToolStripItem)obj).GetCurrentParent().Tag).WindowState = FormWindowState.Minimized;
        }
        // Развернуть окно
        private void toolStripMenuItemWindowMaximaze_Click(object obj, EventArgs e)
        {
            Form tag = (Form)((ToolStripItem)obj).GetCurrentParent().Tag;
            tag.Activate();
            tag.WindowState = FormWindowState.Normal;
            tag.Visible = true;
            tag.WindowState = FormWindowState.Maximized;
        }
        // закрыть окно
        private void toolStripMenuItemWindowsClose_Click(object obj, EventArgs e)
        {
            Form tag = (Form)((ToolStripItem)obj).GetCurrentParent().Tag;
            for (int index = 0; index < this.toolStripMain.Items.Count; ++index)
            {
                if (this.toolStripMain.Items[index].Tag == tag)
                {
                    this.toolStripMain.Items.RemoveAt(index);
                    break;
                }
            }
            tag.Close();
        }
        // активация дочерних окон
        private void FormMain_MdiChildActivate(object sender, EventArgs e)
        {
            Form activeMdiChild = ((Form)this).ActiveMdiChild;
            if (activeMdiChild == null)
                return;
            ToolStripButton toolStripButton = new ToolStripButton();
            toolStripButton.Name = activeMdiChild.Name;
            int length = activeMdiChild.Text.Length >= 25 ? 25 : activeMdiChild.Text.Length;
            toolStripButton.Text = activeMdiChild.Text.Substring(0, length);
            toolStripButton.ToolTipText = activeMdiChild.Text;
            toolStripButton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            toolStripButton.Tag = (object)activeMdiChild;
            try
            {
                toolStripButton.Image = (Image)activeMdiChild.Icon.ToBitmap();
            }
            catch
            {
            }
            toolStripButton.Checked = true;
            toolStripButton.Click += new EventHandler(this.item_Click);
            toolStripButton.MouseDown += new MouseEventHandler(this.item_MouseDown);
            activeMdiChild.FormClosed -= new FormClosedEventHandler(this.mdiForm_FormClosed);
            activeMdiChild.FormClosed += new FormClosedEventHandler(this.mdiForm_FormClosed);
            activeMdiChild.Resize -= new EventHandler(this.mdiForm_Resize);
            activeMdiChild.Resize += new EventHandler(this.mdiForm_Resize);
            activeMdiChild.TextChanged -= new EventHandler(this.mdiFrom_TextChanged);
            activeMdiChild.TextChanged += new EventHandler(this.mdiFrom_TextChanged);
            bool flag = false;
            for (int index = 0; index < this.toolStripMain.Items.Count; ++index)
            {
                if (typeof(ToolStripButton) == this.toolStripMain.Items[index].GetType())
                {
                    if (this.toolStripMain.Items[index].Tag == activeMdiChild)
                        ((ToolStripButton)this.toolStripMain.Items[index]).Checked = true;
                    else
                        ((ToolStripButton)this.toolStripMain.Items[index]).Checked = false;
                }
                if (this.toolStripMain.Items[index].Tag == activeMdiChild)
                    flag = true;
            }
            if (flag)
                return;
            this.toolStripMain.Items.Add((ToolStripItem)toolStripButton);
            this.toolStripMain.Items[this.toolStripMain.Items.Count - 1].Width = 100;
        }
        private void mdiFrom_TextChanged(object obj, EventArgs e)
        {
            for (int index = 0; index < this.toolStripMain.Items.Count; ++index)
            {
                if (typeof(ToolStripButton) == this.toolStripMain.Items[index].GetType() && this.toolStripMain.Items[index].Tag == obj)
                    this.toolStripMain.Items[index].Text = ((Control)obj).Text;
            }
        }
        // Закрытие дочернего окна
        private void mdiForm_FormClosed(object obj, FormClosedEventArgs e)
        {
            for (int index = 0; index < this.toolStripMain.Items.Count; ++index)
            {
                if (this.toolStripMain.Items[index].Tag == obj)
                {
                    this.toolStripMain.Items.RemoveAt(index);
                    break;
                }
            }
        }
        // Изменение разщмера дочернего окна
        private void mdiForm_Resize(object sender, EventArgs e)
        {
            if (!(((Form)sender).WindowState == FormWindowState.Minimized & ((Control)sender).Visible))
                return;
            ((Control)sender).Hide();
        }
        // кликаем по кнопочки тулбара
        private void item_Click(object obj, EventArgs e)
        {
            Form form = obj.GetType() != typeof(ToolStripButton) ? (Form)((ToolStripItem)obj).Tag : (Form)((ToolStripItem)obj).Tag;
            if (((Form)this).ActiveMdiChild == form)
            {
                form.WindowState = FormWindowState.Minimized;
            }
            else
            {
                FormWindowState formWindowState = ((Form)this).ActiveMdiChild == null || ((Form)this).ActiveMdiChild.WindowState == FormWindowState.Minimized ? FormWindowState.Normal : ((Form)this).ActiveMdiChild.WindowState;
                form.Activate();
                form.WindowState = formWindowState;//FormWindowState.Normal;
                form.Visible = true;
            }
        }
        // нажатие мышки на кнопочки тулбара
        private void item_MouseDown(object obj, MouseEventArgs mouseEventArgs)
        {
            if (mouseEventArgs.Button != MouseButtons.Right)
                return;
            this.contextMenuWindow.Tag = ((ToolStripItem)obj).Tag;
            if (((Form)this).ActiveMdiChild == (Form)((ToolStripItem)obj).Tag)// если активно
                this.toolStripMenuItemWindowsRestore.Enabled = false;
            else
                this.toolStripMenuItemWindowsRestore.Enabled = true;
            if (((Form)((ToolStripItem)obj).Tag).WindowState == FormWindowState.Maximized)
                this.toolStripMenuItemWindowMaximaze.Enabled = false;
            else
                this.toolStripMenuItemWindowMaximaze.Enabled = true;
            if (((Form)((ToolStripItem)obj).Tag).WindowState == FormWindowState.Minimized)
                this.toolStripMenuItemWindowsMinimize.Enabled = false;
            else
                this.toolStripMenuItemWindowsMinimize.Enabled = true;
            this.contextMenuWindow.Show(Cursor.Position);
        }
        // Список окон
        private void formsList_Click(object sender, EventArgs e)
        {
            List<Form> formsList = new List<Form>();
            foreach (Form mdiChild in ((Form)this).MdiChildren)
                formsList.Add(mdiChild);
            Form activeMdiChild = ((Form)this).ActiveMdiChild;
            FormWindowsList formWindowsList = new FormWindowsList(formsList, activeMdiChild);
            formWindowsList.MdiParent = (Form)this;
            formWindowsList.MaximizeBox = false;
            formWindowsList.FormClosed += new FormClosedEventHandler(this.frm_FormClosed);
            formWindowsList.Show();
            this.DisableControls((Form)formWindowsList);
        }
        // закрыть окно
        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= new FormClosedEventHandler(this.frm_FormClosed);
            this.ForceReleaseOfControls();
            ((FormWindowsList)sender).ActivateForm.Activate();
        }
        // деактивировать все окна и контролы
        private void DisableControls(Form f)
        {
            for (int index = 0; index < ((Control)this).Controls.Count; ++index)
            {
                if (((Control)this).Controls[index].GetType() != typeof(MdiClient))
                    ((Control)this).Controls[index].Enabled = false;
            }
            foreach (Form mdiChild in ((Form)this).MdiChildren)
            {
                if (mdiChild != f)
                    mdiChild.Enabled = false;
            }
        }
        public void ForceReleaseOfControls()
        {
            for (int index = 0; index < ((Control)this).Controls.Count; ++index)
                ((Control)this).Controls[index].Enabled = true;
            foreach (Control mdiChild in ((Form)this).MdiChildren)
                mdiChild.Enabled = true;
        }
    }
}
