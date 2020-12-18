using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EIS.Forms
{
    public partial class FormWindowsList : Form
    {
        private Form activateForm = null;
        //private IContainer components;
       

        // свойство - активное окно
        public Form ActivateForm
        {
            get
            {
                return this.activateForm;
            }
        }

        public FormWindowsList(List<Form> formsList, Form activeForm)
        {
            this.InitializeComponent();
            this.activateForm = activeForm;
            this.listViewWindows.Columns[0].Width = this.listViewWindows.ClientRectangle.Width;
            this.PaintListView(formsList, activeForm);
        }

        // Добавление итемов в listview
        private void PaintListView(List<Form> list, Form f)
        {
            try
            {
                if (list.Count == 0)
                    return;
                this.listViewWindows.Items.Clear();
                this.listViewWindows.BeginUpdate();
                int index = 0;
                foreach (Form form in list)
                {
                    this.FiimageListWindowseld2.Images.Add(form.Icon);
                    this.FiimageListWindowseld2.TransparentColor = Color.Transparent;
                    this.listViewWindows.Items.Add(new ListViewItem()
                    {
                        Text = form.Text,
                        ImageIndex = index,
                        Tag = (object)form
                    });
                    if (form == f)
                    {
                        this.listViewWindows.Items[index].Selected = true;
                        this.listViewWindows.Select();
                    }
                    ++index;
                }
                this.listViewWindows.EndUpdate();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Изменение размера Listview
        private void listViewWindows_Resize(object sender, EventArgs e)
        {
            this.listViewWindows.Columns[0].Width = this.listViewWindows.ClientRectangle.Width;
        }
        // Активировать выбранное окно
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.listViewWindows.SelectedItems.Count > 0)
                this.activateForm = (Form)this.listViewWindows.SelectedItems[0].Tag;
            this.Close();
        }
        // Закрыть выборанные окна
        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < this.listViewWindows.SelectedItems.Count; index++)
            {
                ((Form)this.listViewWindows.SelectedItems[index].Tag).Close();
                this.listViewWindows.SelectedItems[index].Remove();
                index--;
            }
            if (this.listViewWindows.Items.Count > 0)
            {
                this.listViewWindows.Items[0].Selected = true;
                this.listViewWindows.Select();
            }
        }
        // Двойное нажатие по listview
        private void listViewWindows_MouseDoubleClick(object obj, MouseEventArgs e)
        {
            this.activateForm = (Form)this.listViewWindows.GetItemAt(e.X, e.Y).Tag;
            this.Close();
        }

  
    }
}
