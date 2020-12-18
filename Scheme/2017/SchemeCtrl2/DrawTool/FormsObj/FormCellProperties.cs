using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataSql;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class FormCellProperties : Form
	{
		public FormCellProperties()
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.InitializeComponent();
		}

		public FormCellProperties(LineCellTool cell, SQLSettings sqlSett)
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.InitializeComponent();
			this.lineCellTool_0 = cell;
			if (this.lineCellTool_0.Layer != null && this.lineCellTool_0.Layer.Parent != null)
			{
				PointF pointF = ConvertCanvas.ConvertToScreen(this.lineCellTool_0.Layer.Parent, this.lineCellTool_0.Ends.Last<PointTool>().Point);
				base.Location = this.lineCellTool_0.Layer.Parent.PointToScreen(new Point((int)pointF.X, (int)pointF.Y));
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
				this.textBox1.Enabled = !this.lineCellTool_0.LimitedEditing;
				this.buttonOK.Enabled = (this.lineCellTool_0.Layer.Parent.Mode == eCanvasEditingMode.Edit);
			}
			this.sqlsettings_0 = sqlSett;
			this.textBox1.Text = this.lineCellTool_0.Text;
			if (this.lineCellTool_0.TextProperty.Visible)
			{
				switch (this.lineCellTool_0.TextProperty.Position)
				{
				case ePositionText.LT:
					this.radioButtonLT.Checked = true;
					break;
				case ePositionText.T:
					this.radioButtonT.Checked = true;
					break;
				case ePositionText.RT:
					this.radioButtonRT.Checked = true;
					break;
				case ePositionText.R:
					this.radioButtonRight.Checked = true;
					break;
				case ePositionText.RB:
					this.radioButtonRB.Checked = true;
					break;
				case ePositionText.B:
					this.radioButtonB.Checked = true;
					break;
				case ePositionText.LB:
					this.radioButtonLB.Checked = true;
					break;
				case ePositionText.L:
					this.radioButtonLeft.Checked = true;
					break;
				}
			}
			else
			{
				this.radioButtonNotVisible.Checked = true;
			}
			this.panelColor.BackColor = cell.Color;
		}

		private void panelColor_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.colorDialog_0.Color = this.panelColor.BackColor;
			if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.panelColor.BackColor = this.colorDialog_0.Color;
			}
		}

		private void FormCellProperties_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				LineCellTool lineCellTool = (LineCellTool)this.lineCellTool_0.Clone(false);
				this.lineCellTool_0.Text = this.textBox1.Text;
				if (this.radioButtonNotVisible.Checked)
				{
					this.lineCellTool_0.TextProperty.Visible = false;
				}
				else
				{
					this.lineCellTool_0.TextProperty.Visible = true;
					if (this.radioButtonLeft.Checked)
					{
						this.lineCellTool_0.TextProperty.Position = ePositionText.L;
					}
					if (this.radioButtonLT.Checked)
					{
						this.lineCellTool_0.TextProperty.Position = ePositionText.LT;
					}
					if (this.radioButtonLB.Checked)
					{
						this.lineCellTool_0.TextProperty.Position = ePositionText.LB;
					}
					if (this.radioButtonRT.Checked)
					{
						this.lineCellTool_0.TextProperty.Position = ePositionText.RT;
					}
					if (this.radioButtonRB.Checked)
					{
						this.lineCellTool_0.TextProperty.Position = ePositionText.RB;
					}
					if (this.radioButtonT.Checked)
					{
						this.lineCellTool_0.TextProperty.Position = ePositionText.T;
					}
					if (this.radioButtonRight.Checked)
					{
						this.lineCellTool_0.TextProperty.Position = ePositionText.R;
					}
					if (this.radioButtonB.Checked)
					{
						this.lineCellTool_0.TextProperty.Position = ePositionText.B;
					}
				}
				if (this.lineCellTool_0.Color != this.panelColor.BackColor)
				{
					this.lineCellTool_0.UseSettingColor = false;
					this.lineCellTool_0.Color = this.panelColor.BackColor;
				}
				if (this.lineCellTool_0.TextProperty.Visible)
				{
					if (lineCellTool.TextProperty.Visible)
					{
						List<PointTool> pointsList = this.lineCellTool_0.GetPointsList();
						bool flag = false;
						foreach (PointTool pointTool in pointsList)
						{
							if (pointTool.TextProperty.Visible)
							{
								flag = true;
								pointTool.Text = this.lineCellTool_0.Text;
								pointTool.TextProperty.Position = this.lineCellTool_0.TextProperty.Position;
							}
						}
						if (!flag && this.lineCellTool_0.Ends.Count<PointTool>() > 0)
						{
							this.lineCellTool_0.Ends.First<PointTool>().Text = this.lineCellTool_0.Text;
							this.lineCellTool_0.Ends.First<PointTool>().TextProperty.Visible = this.lineCellTool_0.TextProperty.Visible;
							this.lineCellTool_0.Ends.First<PointTool>().TextProperty.Position = this.lineCellTool_0.TextProperty.Position;
						}
					}
					else if (this.lineCellTool_0.Ends.Count<PointTool>() > 0)
					{
						this.lineCellTool_0.Ends.First<PointTool>().Text = this.lineCellTool_0.Text;
						this.lineCellTool_0.Ends.First<PointTool>().TextProperty.Visible = this.lineCellTool_0.TextProperty.Visible;
						this.lineCellTool_0.Ends.First<PointTool>().TextProperty.Position = this.lineCellTool_0.TextProperty.Position;
					}
				}
				else
				{
					foreach (PointTool pointTool2 in this.lineCellTool_0.GetPointsList())
					{
						pointTool2.TextProperty.Visible = false;
					}
				}
				if (!this.lineCellTool_0.Layer.Parent.ValidateToUnique(this.lineCellTool_0))
				{
					MessageBox.Show("Такой объект уже есть на данной схеме");
					this.lineCellTool_0.Text = lineCellTool.Text;
					this.lineCellTool_0.TextProperty.Visible = lineCellTool.TextProperty.Visible;
					this.lineCellTool_0.TextProperty.Position = lineCellTool.TextProperty.Position;
					this.lineCellTool_0.UseSettingColor = lineCellTool.UseSettingColor;
					this.lineCellTool_0.Color = lineCellTool.Color;
					e.Cancel = true;
					return;
				}
				if (this.lineCellTool_0.Layer.Parent.UseObjectFromDB && !this.lineCellTool_0.SaveToSql(false, true))
				{
					this.lineCellTool_0.Type = lineCellTool.Type;
					this.lineCellTool_0.Text = lineCellTool.Text;
					this.lineCellTool_0.TextProperty.Visible = lineCellTool.TextProperty.Visible;
					this.lineCellTool_0.TextProperty.Position = lineCellTool.TextProperty.Position;
					this.lineCellTool_0.UseSettingColor = lineCellTool.UseSettingColor;
					this.lineCellTool_0.Color = lineCellTool.Color;
					e.Cancel = true;
					return;
				}
			}
		}

		private LineCellTool lineCellTool_0;

		private SQLSettings sqlsettings_0;
	}
}
