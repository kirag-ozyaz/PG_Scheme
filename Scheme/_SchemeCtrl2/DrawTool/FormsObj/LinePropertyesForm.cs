using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class LinePropertyesForm : Form
	{
		public LinePropertyesForm(LineTool lineTool)
		{
			this.InitializeComponent();
			this.lineTool_0 = lineTool;
			if (lineTool.Layer != null && lineTool.Layer.Parent != null)
			{
				this.OKButton.Enabled = (lineTool.Layer.Parent.Mode == eCanvasEditingMode.Edit);
				this.textBoxNameLine.Enabled = (this.groupBox2.Enabled = !lineTool.LimitedEditing);
				PointF pointF = ConvertCanvas.ConvertToScreen(lineTool.Layer.Parent, lineTool.Ends.Last<PointTool>().Point);
				base.Location = lineTool.Layer.Parent.PointToScreen(new Point((int)pointF.X, (int)pointF.Y));
				Rectangle workingArea = Screen.GetWorkingArea(base.Location);
				if (base.Left + base.Width > workingArea.Left + workingArea.Width)
				{
					base.Left = base.Left - base.Width - 1;
				}
				if (base.Left < workingArea.Left)
				{
					base.Left = workingArea.Left;
				}
				if (base.Top + base.Height > workingArea.Top + workingArea.Height)
				{
					base.Top = base.Top - base.Height - 1;
				}
				if (base.Top < workingArea.Top)
				{
					base.Top = workingArea.Top;
				}
			}
			if (lineTool.IdBase <= 0)
			{
				this.textBoxNameLine.Text = lineTool.ToString();
			}
			else
			{
				this.textBoxNameLine.Text = lineTool.Text;
			}
			if (this.lineTool_0.Type == LineToolType.CabelLine)
			{
				this.cabelLineRadioButton.Checked = true;
			}
			else if (this.lineTool_0.Type == LineToolType.AirLine)
			{
				this.airLineRadioButton.Checked = true;
			}
			else if (this.lineTool_0.Type == LineToolType.AirLineProtected)
			{
				this.radioBtnAirLineProtected.Checked = true;
			}
			List<string> destinations = this.lineTool_0.GetDestinations();
			foreach (string item in destinations)
			{
				this.destinationListBox.Items.Add(item);
			}
			DrawObjectBase[] array = lineTool.GetPowerSource().ToArray();
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].GetType() == typeof(BranchCollection))
				{
					LineTool lineTool2 = (LineTool)((BranchCollection)array[i]).Parent;
					if (!list.Contains(lineTool2) && lineTool2 != null && lineTool2.GetType() == typeof(LineCellTool) && array[i + 1].GetType() == typeof(ShinaTool) && (((RectangleTool)lineTool2.Parent).TypeRectnagleTool == eTypeRectangleTool.RP || ((RectangleTool)lineTool2.Parent).TypeRectnagleTool == eTypeRectangleTool.CP))
					{
						string item2 = string.Concat(new string[]
						{
							lineTool2.Parent.ToString(),
							"  /  ",
							array[i + 1].ToString(),
							"  /  ",
							lineTool2.ToString()
						});
						this.listBoxOfSupplyCells.Items.Add(item2);
						list.Add(lineTool2);
					}
				}
			}
		}

		private void LinePropertyesForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				LineTool lineTool = (LineTool)this.lineTool_0.Clone(false);
				if (this.cabelLineRadioButton.Checked)
				{
					this.lineTool_0.Type = LineToolType.CabelLine;
				}
				else if (this.airLineRadioButton.Checked)
				{
					this.lineTool_0.Type = LineToolType.AirLine;
				}
				else if (this.radioBtnAirLineProtected.Checked)
				{
					this.lineTool_0.Type = LineToolType.AirLineProtected;
				}
				this.lineTool_0.Text = this.textBoxNameLine.Text;
				if (!this.lineTool_0.Layer.Parent.ValidateToUnique(this.lineTool_0))
				{
					MessageBox.Show("Такой объект уже есть на данной схеме");
					this.lineTool_0.Type = lineTool.Type;
					this.lineTool_0.Text = lineTool.Text;
					e.Cancel = true;
					return;
				}
				if (this.lineTool_0.Layer.Parent.UseObjectFromDB && !this.lineTool_0.SaveToSql(false, true))
				{
					this.lineTool_0.Type = lineTool.Type;
					this.lineTool_0.Text = lineTool.Text;
					e.Cancel = true;
				}
			}
		}

		private void LinePropertyesForm_Load(object sender, EventArgs e)
		{
		}

		private LineTool lineTool_0;
	}
}
