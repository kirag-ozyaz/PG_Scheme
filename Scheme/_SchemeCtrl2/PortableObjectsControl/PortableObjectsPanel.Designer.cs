using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Properties;

namespace SchemeCtrl2.PortableObjectsControl
{
	public class PortableObjectsPanel : UserControl
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.MaximumSize = new Size(300, 30);
			this.MinimumSize = new Size(30, 30);
			base.Name = "PortableObjectsPanel";
			base.Size = new Size(30, 30);
			base.ResumeLayout(false);
		}

		public PortableObjectsPanel()
		{
			this.InitializeComponent();
		}

		public void AddObject(DrawObjectBase drawObjectBase_0)
		{
			this.list_0.Add(drawObjectBase_0);
			PictureBox pictureBox = new PictureBox();
			pictureBox.Height = 26;
			pictureBox.Width = 26;
			pictureBox.Location = new Point(2 + 26 * pictureBox.Controls.Count, 2);
			base.Controls.Add(pictureBox);
			pictureBox.MouseDown += this.method_4;
			pictureBox.MouseUp += this.method_3;
			pictureBox.MouseMove += this.method_2;
			pictureBox.Tag = drawObjectBase_0;
			if (drawObjectBase_0.GetType() == typeof(GroundingTool))
			{
				pictureBox.Image = Resources.PortableGroundingTool;
				((GroundingTool)drawObjectBase_0).PortEvent += this.method_1;
				((GroundingTool)drawObjectBase_0).RemovePortEvent += this.method_0;
			}
		}

		private void method_0(GroundingTool groundingTool_0)
		{
			foreach (object obj in base.Controls)
			{
				Control control = (Control)obj;
				if (control.Tag == groundingTool_0)
				{
					control.Visible = true;
				}
			}
		}

		private void method_1(GroundingTool groundingTool_0)
		{
			foreach (object obj in base.Controls)
			{
				Control control = (Control)obj;
				if (control.Tag == groundingTool_0)
				{
					control.Visible = false;
				}
			}
		}

		private void method_2(object sender, MouseEventArgs e)
		{
			if (this.bool_0 && (Math.Abs(this.point_0.X - e.Location.X) > 5 || Math.Abs(this.point_0.Y - e.Location.Y) > 5))
			{
				this.bool_0 = false;
				object tag = ((PictureBox)sender).Tag;
				base.DoDragDrop(tag, DragDropEffects.Move);
			}
		}

		private void method_3(object sender, MouseEventArgs e)
		{
			this.bool_0 = false;
		}

		private void method_4(object sender, MouseEventArgs e)
		{
			this.bool_0 = true;
			this.point_0 = e.Location;
		}

		private IContainer icontainer_0;

		private List<DrawObjectBase> list_0 = new List<DrawObjectBase>();

		private bool bool_0;

		private Point point_0;
	}
}
