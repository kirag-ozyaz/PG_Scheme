using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class FormTextBranchProperties : Form
	{
		public FormTextBranchProperties()
		{
			this.InitializeComponent();
		}

		public FormTextBranchProperties(TextBranchTool text)
		{
			this.InitializeComponent();
			this.textBranchTool_0 = text;
			if (this.textBranchTool_0.Layer != null && this.textBranchTool_0.Layer.Parent != null && this.textBranchTool_0.Layer.Parent.Mode != eCanvasEditingMode.Edit)
			{
				this.buttonOK.Enabled = false;
				this.textBox.Enabled = false;
				this.radioButtonPassport.Enabled = false;
				this.radioButtonText.Enabled = false;
			}
			this.textBox.Text = this.textBranchTool_0.Text;
			this.string_0 = this.textBranchTool_0.Text;
			this.bool_0 = this.textBranchTool_0.Passport;
			this.checkBoxDirect.Checked = this.textBranchTool_0.Direct;
			if (this.textBranchTool_0.TextProperty.Position == ePositionText.T)
			{
				this.radioButtonT.Checked = true;
			}
			else
			{
				this.radioButtonB.Checked = true;
			}
			this.radioButtonPassport.Checked = this.textBranchTool_0.Passport;
			this.radioButtonText.Checked = !this.textBranchTool_0.Passport;
			this.font_0 = text.TextProperty.Font;
			this.color_0 = text.TextProperty.Color;
			this.checkBoxSettingDB.Checked = text.UseSettingColor;
			this.panelColor.BackColor = text.Color;
		}

		private void FormTextBranchProperties_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK && this.textBranchTool_0 != null && this.textBranchTool_0.Parent != null && this.textBranchTool_0.Parent.Parent != null)
			{
				if (this.textBranchTool_0.Text == string.Empty && !this.textBranchTool_0.Passport)
				{
					MessageBox.Show("Объект не содержит значений", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					e.Cancel = true;
					return;
				}
				this.textBranchTool_0.Direct = this.checkBoxDirect.Checked;
				if (this.radioButtonT.Checked)
				{
					this.textBranchTool_0.TextProperty.Position = ePositionText.T;
				}
				if (this.radioButtonB.Checked)
				{
					this.textBranchTool_0.TextProperty.Position = ePositionText.B;
				}
				if (this.checkBoxSettingDB.Checked)
				{
					this.textBranchTool_0.UseSettingColor = true;
					this.textBranchTool_0.UseSettingsText = true;
				}
				else
				{
					this.textBranchTool_0.UseSettingColor = false;
					this.textBranchTool_0.Color = this.panelColor.BackColor;
					this.textBranchTool_0.UseSettingsText = false;
					this.textBranchTool_0.TextProperty.Font = this.font_0;
					this.textBranchTool_0.TextProperty.Color = this.color_0;
				}
				this.textBranchTool_0.Parent.Parent.SaveXmlToSql();
			}
			if (base.DialogResult == DialogResult.Cancel)
			{
				this.textBranchTool_0.Text = this.string_0;
				this.textBranchTool_0.Passport = this.bool_0;
			}
		}

		private void textBox_Enter(object sender, EventArgs e)
		{
			base.AcceptButton = null;
		}

		private void textBox_Leave(object sender, EventArgs e)
		{
			base.AcceptButton = this.buttonOK;
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			if (!this.textBranchTool_0.Passport)
			{
				this.textBranchTool_0.Text = this.textBox.Text;
			}
		}

		private void radioButtonText_CheckedChanged(object sender, EventArgs e)
		{
			this.textBranchTool_0.Passport = !this.radioButtonText.Checked;
			if (!this.textBranchTool_0.Passport)
			{
				this.textBox.Text = this.textBranchTool_0.Text;
				this.textBox.Enabled = true;
			}
		}

		private void radioButtonPassport_CheckedChanged(object sender, EventArgs e)
		{
			this.textBranchTool_0.Passport = this.radioButtonPassport.Checked;
			if (this.textBranchTool_0.Passport)
			{
				if (this.textBranchTool_0.Text == "")
				{
					this.textBranchTool_0.UpdateSQLFields();
				}
				if (this.textBranchTool_0.Text == "")
				{
					MessageBox.Show("Данные из паспорта не найдены.\r\nОбъект будет переведён в режим отображения текста");
					this.radioButtonText.Checked = true;
					return;
				}
				this.textBox.Text = this.textBranchTool_0.Text;
				this.textBox.Enabled = false;
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

		private void panelColor_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			using (ColorDialog colorDialog = new ColorDialog())
			{
				colorDialog.Color = this.panelColor.BackColor;
				if (colorDialog.ShowDialog() == DialogResult.OK)
				{
					this.panelColor.BackColor = colorDialog.Color;
				}
			}
		}

		private void buttonFont_Click(object sender, EventArgs e)
		{
			using (FontDialog fontDialog = new FontDialog())
			{
				fontDialog.Font = this.font_0;
				fontDialog.Color = this.color_0;
				if (fontDialog.ShowDialog() == DialogResult.OK)
				{
					this.font_0 = fontDialog.Font;
					this.color_0 = fontDialog.Color;
				}
			}
		}

		private TextBranchTool textBranchTool_0;

		private string string_0 = string.Empty;

		private bool bool_0;

		private Font font_0;

		private Color color_0;
	}
}
