using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class FormLabelToolProperties : Form
	{
		public FormLabelToolProperties(LabelTool label, SQLSettings sqlSett)
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.InitializeComponent();
			this.labelTool_0 = label;
			this.sqlsettings_0 = sqlSett;
			if (this.labelTool_0.Layer != null && this.labelTool_0.Layer.Parent != null)
			{
				if (this.labelTool_0.GetType() == typeof(NodeTool))
				{
					if (this.labelTool_0.Layer.Parent.Mode == eCanvasEditingMode.ReadOnly || this.labelTool_0.LimitedEditing)
					{
						this.buttonOK.Enabled = false;
					}
				}
				else if (this.labelTool_0.Layer.Parent.Mode != eCanvasEditingMode.Edit && !this.labelTool_0.LimitedEditing)
				{
					this.buttonOK.Enabled = false;
				}
			}
			this.textBoxTextLabel.Text = label.Text;
			this.checkBoxUseSettingsCanvas.Checked = label.UseSettingsText;
			this.font_0 = label.TextProperty.Font;
			this.color_0 = label.TextProperty.Color;
			this.panelColor.BackColor = this.color_0;
			this.radioButtonVertical.Checked = label.TextProperty.FontVirtical;
			if (label.GetType() == typeof(NodeTool))
			{
				this.textBoxTextLabel.Multiline = true;
				this.textBoxTextLabel.Height = 44;
				this.textBoxTextLabel.AcceptsReturn = true;
				this.buttonFont.Visible = false;
				this.panelColor.BackColor = label.Color;
			}
		}

		private void FormLabelToolProperties_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				LabelTool acopy = (LabelTool)this.labelTool_0.Clone(false);
				if (string.IsNullOrEmpty(this.textBoxTextLabel.Text))
				{
					MessageBox.Show("Не введено имя");
					this.labelTool_0.Copy(acopy);
					e.Cancel = true;
					return;
				}
				this.labelTool_0.Text = this.textBoxTextLabel.Text;
				if (!this.labelTool_0.Layer.Parent.ValidateToUnique(this.labelTool_0))
				{
					MessageBox.Show("Такой объект уже есть на данной схеме");
					this.labelTool_0.Copy(acopy);
					e.Cancel = true;
					return;
				}
				if (this.checkBoxUseSettingsCanvas.Checked)
				{
					this.labelTool_0.UseSettingColor = true;
					this.labelTool_0.UseSettingsText = true;
				}
				else
				{
					this.labelTool_0.UseSettingColor = false;
					this.labelTool_0.UseSettingsText = false;
					this.labelTool_0.TextProperty.Font = this.font_0;
					this.labelTool_0.TextProperty.Color = this.color_0;
					this.labelTool_0.Color = this.panelColor.BackColor;
				}
				this.labelTool_0.TextProperty.FontVirtical = this.radioButtonVertical.Checked;
				if (this.labelTool_0.Layer.Parent.UseObjectFromDB && !this.labelTool_0.SaveToSql(false, false))
				{
					this.labelTool_0.Copy(acopy);
					e.Cancel = true;
					return;
				}
			}
		}

		private void checkBoxUseSettingsCanvas_CheckedChanged(object sender, EventArgs e)
		{
			this.buttonFont.Enabled = !this.checkBoxUseSettingsCanvas.Checked;
			this.panelColor.Enabled = !this.checkBoxUseSettingsCanvas.Checked;
		}

		private void buttonFont_Click(object sender, EventArgs e)
		{
			this.fontDialog_0.Font = this.labelTool_0.TextProperty.Font;
			if (this.fontDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.font_0 = this.fontDialog_0.Font;
			}
		}

		private void panelColor_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.colorDialog_0.Color = this.color_0;
			if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.color_0 = this.colorDialog_0.Color;
				this.panelColor.BackColor = this.color_0;
			}
		}

		private LabelTool labelTool_0;

		private SQLSettings sqlsettings_0;

		private Font font_0;

		private Color color_0;
	}
}
