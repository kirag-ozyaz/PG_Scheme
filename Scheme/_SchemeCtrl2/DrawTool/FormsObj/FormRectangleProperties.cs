using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class FormRectangleProperties : Form
	{
		public RectangleTool RectObj
		{
			get
			{
				return this.rectangleTool_0;
			}
		}

		public FormRectangleProperties()
		{
			this.InitializeComponent();
		}

		public FormRectangleProperties(RectangleTool rect, SQLSettings sqlSett)
		{
			this.InitializeComponent();
			this.rectangleTool_0 = rect;
			if (this.rectangleTool_0.Layer != null && this.rectangleTool_0.Layer.Parent != null)
			{
				RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(this.rectangleTool_0.Layer.Parent, this.rectangleTool_0.Rectangle);
				base.Location = this.rectangleTool_0.Layer.Parent.PointToScreen(new Point((int)(rectangleF.Location.X + rectangleF.Width), (int)rectangleF.Location.Y));
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
				if (this.rectangleTool_0.Layer.Parent.Mode != eCanvasEditingMode.Edit)
				{
					this.buttonOK.Enabled = false;
				}
			}
			this.method_0();
			this.sqlsettings_0 = sqlSett;
		}

		private void method_0()
		{
			this.textBoxTextObj.Text = this.rectangleTool_0.Text;
			this.font_0 = this.rectangleTool_0.TextProperty.Font;
			this.color_0 = this.rectangleTool_0.TextProperty.Color;
			if (this.rectangleTool_0.TextProperty.Visible)
			{
				switch (this.rectangleTool_0.TextProperty.Position)
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
					this.radioButtonR.Checked = true;
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
					this.radioButtonL.Checked = true;
					break;
				}
			}
			else
			{
				this.radioButtonNotVisible.Checked = true;
			}
			if (this.rectangleTool_0.UseSettingColor)
			{
				this.checkBoxSettingDB.Checked = true;
			}
			if (this.rectangleTool_0.TextProperty.FontVirtical)
			{
				this.radioButtonVertical.Checked = true;
			}
			this.checkBoxSubscriber.Checked = this.rectangleTool_0.IsSubscriber;
			this.panelColor.BackColor = this.rectangleTool_0.Color;
		}

		private void FormRectangleProperties_Load(object sender, EventArgs e)
		{
			this.method_1();
		}

		private void FormRectangleProperties_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				RectangleTool acopy = (RectangleTool)this.rectangleTool_0.Clone(false);
				if (this.cmbType.SelectedIndex < 0)
				{
					MessageBox.Show("Не выбран тип подстанции");
					e.Cancel = true;
					return;
				}
				this.rectangleTool_0.TypeRectnagleTool = (eTypeRectangleTool)this.cmbType.SelectedValue;
				if (this.radioButtonExistTP.Checked)
				{
					if (this.comboBoxExistTP.SelectedValue == null)
					{
						MessageBox.Show("Не выбрано имя подстанции");
						this.rectangleTool_0.Copy(acopy);
						e.Cancel = true;
						return;
					}
					this.rectangleTool_0.Text = this.comboBoxExistTP.Text.ToString();
					this.rectangleTool_0.IdBase = Convert.ToInt32(this.comboBoxExistTP.SelectedValue);
				}
				else
				{
					if (string.IsNullOrEmpty(this.textBoxTextObj.Text))
					{
						MessageBox.Show("Не введено имя подстанции");
						this.rectangleTool_0.Copy(acopy);
						e.Cancel = true;
						return;
					}
					this.rectangleTool_0.Text = this.textBoxTextObj.Text;
				}
				if (this.radioButtonNotVisible.Checked)
				{
					this.rectangleTool_0.TextProperty.Visible = false;
				}
				else
				{
					this.rectangleTool_0.TextProperty.Visible = true;
					if (this.radioButtonL.Checked)
					{
						this.rectangleTool_0.TextProperty.Position = ePositionText.L;
					}
					if (this.radioButtonLT.Checked)
					{
						this.rectangleTool_0.TextProperty.Position = ePositionText.LT;
					}
					if (this.radioButtonT.Checked)
					{
						this.rectangleTool_0.TextProperty.Position = ePositionText.T;
					}
					if (this.radioButtonRT.Checked)
					{
						this.rectangleTool_0.TextProperty.Position = ePositionText.RT;
					}
					if (this.radioButtonR.Checked)
					{
						this.rectangleTool_0.TextProperty.Position = ePositionText.R;
					}
					if (this.radioButtonRB.Checked)
					{
						this.rectangleTool_0.TextProperty.Position = ePositionText.RB;
					}
					if (this.radioButtonB.Checked)
					{
						this.rectangleTool_0.TextProperty.Position = ePositionText.B;
					}
					if (this.radioButtonLB.Checked)
					{
						this.rectangleTool_0.TextProperty.Position = ePositionText.LB;
					}
				}
				if (this.checkBoxSettingDB.Checked)
				{
					this.rectangleTool_0.UseSettingColor = true;
					this.rectangleTool_0.UseSettingsText = true;
				}
				else
				{
					this.rectangleTool_0.UseSettingColor = false;
					this.rectangleTool_0.Color = this.panelColor.BackColor;
					this.rectangleTool_0.UseSettingsText = false;
					this.rectangleTool_0.TextProperty.Font = this.font_0;
					this.rectangleTool_0.TextProperty.Color = this.color_0;
				}
				this.rectangleTool_0.TextProperty.FontVirtical = !this.radioButtonGorizontal.Checked;
				this.rectangleTool_0.IsSubscriber = this.checkBoxSubscriber.Checked;
				if (!this.rectangleTool_0.Layer.Parent.ValidateToUnique(this.rectangleTool_0))
				{
					MessageBox.Show("Такой объект уже есть на данной схеме");
					this.rectangleTool_0.Copy(acopy);
					e.Cancel = true;
					return;
				}
				if (this.rectangleTool_0.Layer.Parent.UseObjectFromDB && !this.rectangleTool_0.SaveToSql(false, false))
				{
					this.rectangleTool_0.Copy(acopy);
					e.Cancel = true;
				}
			}
		}

		private void method_1()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			sqlDataCommand.SelectSqlData(this.dataSet_0, "tr_classifier", true, " where parentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0");
			this.cmbType.SelectedValue = (int)this.rectangleTool_0.TypeRectnagleTool;
			this.method_2();
		}

		private void method_2()
		{
			if (this.cmbType.SelectedIndex >= 0)
			{
				SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
				if (this.rectangleTool_0.Layer == null || this.rectangleTool_0.Layer.Parent == null || !this.rectangleTool_0.Layer.Parent.UseObjectFromDB)
				{
					this.dataSet_0.Tables["tSchm_ObjList"].Clear();
					this.radioButtonExistTP.Enabled = false;
					this.radioButtonNewStation.Checked = true;
					return;
				}
				sqlDataCommand.SelectSqlData(this.dataSet_0, "tSChm_ObjList", true, " where typeCodeId = " + ((int)this.cmbType.SelectedValue).ToString() + " order by name ");
				if (this.dataSet_0.Tables["tSchm_ObjList"].Rows.Count == 0)
				{
					this.radioButtonExistTP.Enabled = false;
					this.radioButtonNewStation.Checked = true;
					return;
				}
				this.radioButtonExistTP.Enabled = true;
				if (this.rectangleTool_0.IdBase > 0)
				{
					this.comboBoxExistTP.SelectedValue = this.rectangleTool_0.IdBase;
					this.radioButtonExistTP.Checked = true;
					return;
				}
			}
			else
			{
				this.dataSet_0.Tables["tSchm_ObjList"].Clear();
				this.radioButtonExistTP.Enabled = false;
				this.radioButtonNewStation.Checked = true;
			}
		}

		private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_2();
		}

		private void radioButtonExistTP_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButtonExistTP.Checked)
			{
				this.comboBoxExistTP.Enabled = true;
				this.textBoxTextObj.Enabled = false;
				return;
			}
			this.comboBoxExistTP.Enabled = false;
			this.textBoxTextObj.Enabled = true;
		}

		private void panelColor_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.colorDialog_0.Color = this.panelColor.BackColor;
			if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.panelColor.BackColor = this.colorDialog_0.Color;
			}
		}

		private void buttonFont_Click(object sender, EventArgs e)
		{
			this.fontDialog_0.Font = this.rectangleTool_0.TextProperty.Font;
			this.fontDialog_0.Color = this.rectangleTool_0.TextProperty.Color;
			if (this.fontDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.font_0 = this.fontDialog_0.Font;
				this.color_0 = this.fontDialog_0.Color;
			}
		}

		private void checkBoxSettingDB_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBoxSettingDB.Checked)
			{
				this.panelColor.Enabled = false;
				this.buttonFont.Enabled = false;
				return;
			}
			this.panelColor.Enabled = true;
			this.buttonFont.Enabled = true;
		}

		private RectangleTool rectangleTool_0;

		private SQLSettings sqlsettings_0;

		private Font font_0;

		private Color color_0;
	}
}
