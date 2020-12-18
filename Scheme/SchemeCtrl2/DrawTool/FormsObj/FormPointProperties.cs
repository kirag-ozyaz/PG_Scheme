using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataSql;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class FormPointProperties : Form
	{
		public FormPointProperties()
		{
			
			
			this.InitializeComponent();
		}

		public FormPointProperties(PointTool point, SQLSettings sqlSett)
		{
			
			
			this.InitializeComponent();
			this.pointTool_0 = point;
			this.sqlsettings_0 = sqlSett;
			this.textBox1.Text = this.pointTool_0.Text;
			if (this.pointTool_0.TextProperty.Visible)
			{
				switch (this.pointTool_0.TextProperty.Position)
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
			this.checkBoxUseSettingsText.Checked = this.pointTool_0.UseSettingsText;
			this.panelColor.BackColor = this.pointTool_0.TextProperty.Color;
			this.font_0 = this.pointTool_0.TextProperty.Font;
			if (this.pointTool_0.Layer != null)
			{
				if (this.pointTool_0.Layer.Parent.Mode != eCanvasEditingMode.Edit || this.pointTool_0.LimitedEditing)
				{
					this.buttonOK.Enabled = false;
				}
				if (this.pointTool_0.Branches.Count<Branch>() == 0 && this.pointTool_0.Layer.Parent.Mode == eCanvasEditingMode.Dispatcher && !this.pointTool_0.LimitedEditing)
				{
					this.buttonOK.Enabled = true;
				}
			}
		}

		private void panelColor_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.colorDialog_0.Color = this.panelColor.BackColor;
			if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.panelColor.BackColor = this.colorDialog_0.Color;
			}
		}

		private void FormPointProperties_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				PointTool pointTool = (PointTool)this.pointTool_0.Clone(false);
				this.pointTool_0.Text = this.textBox1.Text;
				if (this.radioButtonNotVisible.Checked)
				{
					this.pointTool_0.TextProperty.Visible = false;
				}
				else
				{
					this.pointTool_0.TextProperty.Visible = true;
					if (this.radioButtonLeft.Checked)
					{
						this.pointTool_0.TextProperty.Position = ePositionText.L;
					}
					if (this.radioButtonLT.Checked)
					{
						this.pointTool_0.TextProperty.Position = ePositionText.LT;
					}
					if (this.radioButtonLB.Checked)
					{
						this.pointTool_0.TextProperty.Position = ePositionText.LB;
					}
					if (this.radioButtonRT.Checked)
					{
						this.pointTool_0.TextProperty.Position = ePositionText.RT;
					}
					if (this.radioButtonRB.Checked)
					{
						this.pointTool_0.TextProperty.Position = ePositionText.RB;
					}
					if (this.radioButtonT.Checked)
					{
						this.pointTool_0.TextProperty.Position = ePositionText.T;
					}
					if (this.radioButtonRight.Checked)
					{
						this.pointTool_0.TextProperty.Position = ePositionText.R;
					}
					if (this.radioButtonB.Checked)
					{
						this.pointTool_0.TextProperty.Position = ePositionText.B;
					}
				}
				if (this.pointTool_0.TextProperty.Color != this.panelColor.BackColor)
				{
					this.pointTool_0.UseSettingsText = false;
					this.pointTool_0.TextProperty.Color = this.panelColor.BackColor;
				}
				if (this.pointTool_0.Branches.Count<Branch>() == 0 && this.pointTool_0.Parent != null && this.pointTool_0.Parent is ShinaTool && this.pointTool_0.Color != this.panelColor.BackColor)
				{
					this.pointTool_0.UseSettingColor = false;
					this.pointTool_0.Color = this.panelColor.BackColor;
				}
				this.pointTool_0.UseSettingsText = this.checkBoxUseSettingsText.Checked;
				this.pointTool_0.TextProperty.Font = this.font_0;
				if (this.pointTool_0.Layer.Parent.UseObjectFromDB)
				{
					if (this.pointTool_0.IdBase > 0)
					{
						if (!this.pointTool_0.SaveToSql(false, true))
						{
							this.pointTool_0.Text = pointTool.Text;
							this.pointTool_0.TextProperty.Visible = pointTool.TextProperty.Visible;
							this.pointTool_0.TextProperty.Position = pointTool.TextProperty.Position;
							this.pointTool_0.TextProperty.Color = pointTool.TextProperty.Color;
							this.pointTool_0.UseSettingColor = pointTool.UseSettingColor;
							this.pointTool_0.Color = pointTool.Color;
							e.Cancel = true;
							return;
						}
					}
					else
					{
						if (this.pointTool_0.Branches.Count<Branch>() > 0)
						{
							this.pointTool_0.Branches.First<Branch>().Parent.SaveXmlToSql();
							return;
						}
						if (this.pointTool_0.Parent != null && this.pointTool_0.Parent is ShinaTool)
						{
							this.pointTool_0.Parent.SaveXmlToSql();
						}
					}
				}
			}
		}

		private void checkBoxUseSettingsText_CheckedChanged(object sender, EventArgs e)
		{
			this.panelColor.Enabled = !this.checkBoxUseSettingsText.Checked;
			this.buttonFont.Enabled = !this.checkBoxUseSettingsText.Checked;
		}

		private void buttonFont_Click(object sender, EventArgs e)
		{
			this.fontDialog_0.Font = this.font_0;
			if (this.fontDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.font_0 = this.fontDialog_0.Font;
			}
		}

		private PointTool pointTool_0;

		private SQLSettings sqlsettings_0;

		private Font font_0;
	}
}
