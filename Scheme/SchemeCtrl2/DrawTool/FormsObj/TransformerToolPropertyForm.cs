using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;

namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class TransformerToolPropertyForm : Form
	{
		public TransformerToolPropertyForm()
		{
			
			
			this.InitializeComponent();
			this.newTransRadioButton.Checked = true;
			this.oldTransRadioButton.Enabled = false;
		}

		public TransformerToolPropertyForm(ObjectOnLine objectInLine, SQLSettings sqlSett)
		{
			
			
			this.sqlsettings_0 = sqlSett;
			this.InitializeComponent();
			new SqlDataCommand(this.sqlsettings_0);
			this.newTransRadioButton.Checked = true;
			this.oldTransRadioButton.Enabled = false;
			this.oldTransComboBox.Enabled = false;
			this.objectOnLine_0 = objectInLine;
			this.method_0();
		}

		public TransformerToolPropertyForm(int idRect, ObjectOnLine objectInLine, SQLSettings sqlSett)
		{
			
			
			this.sqlsettings_0 = sqlSett;
			this.InitializeComponent();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			this.newTransRadioButton.Checked = true;
			this.oldTransComboBox.Enabled = false;
			this.objectOnLine_0 = objectInLine;
			this.method_0();
			sqlDataCommand.SelectSqlData(this.class22_0.tSchm_ObjList, true, "where [IdParent]=" + idRect.ToString() + " AND TypeCodeId=556 AND Deleted=0", null, false, 0);
			if (this.bindingSource_0.Count == 0)
			{
				this.oldTransRadioButton.Enabled = false;
				return;
			}
			this.oldTransRadioButton.Checked = true;
		}

		private void method_0()
		{
			if (this.objectOnLine_0.TextProperty.Visible)
			{
				switch (this.objectOnLine_0.TextProperty.Position)
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
					this.aCgDyblRoR.Checked = true;
					break;
				}
			}
			else
			{
				this.radioButtonNotVisible.Checked = true;
			}
			if (this.objectOnLine_0.PositionDamage != ePositionText.None)
			{
				this.checkBoxDamage.Checked = true;
				switch (this.objectOnLine_0.PositionDamage)
				{
				case ePositionText.LT:
					this.radioButtonDamageLT.Checked = true;
					break;
				case ePositionText.T:
					this.radioButtonDamageT.Checked = true;
					break;
				case ePositionText.RT:
					this.radioButtonDamageRT.Checked = true;
					break;
				case ePositionText.R:
					this.radioButtonDamageR.Checked = true;
					break;
				case ePositionText.RB:
					this.radioButtonDamageRB.Checked = true;
					break;
				case ePositionText.B:
					this.radioButtonDamageB.Checked = true;
					break;
				case ePositionText.LB:
					this.radioButtonDamageLB.Checked = true;
					break;
				case ePositionText.L:
					this.radioButtonDamageL.Checked = true;
					break;
				}
			}
			else
			{
				this.checkBoxDamage.Checked = false;
			}
			if (this.objectOnLine_0.PositionKey == ePositionText.None)
			{
				this.checkBoxKey.Checked = false;
				return;
			}
			this.checkBoxKey.Checked = true;
			switch (this.objectOnLine_0.PositionKey)
			{
			case ePositionText.LT:
				this.radioButtonKeyLT.Checked = true;
				return;
			case ePositionText.T:
				this.radioButtonKeyT.Checked = true;
				return;
			case ePositionText.RT:
				this.radioButtonKeyRT.Checked = true;
				return;
			case ePositionText.R:
				this.radioButtonKeyR.Checked = true;
				return;
			case ePositionText.RB:
				this.radioButtonKeyRB.Checked = true;
				return;
			case ePositionText.B:
				this.radioButtonKeyB.Checked = true;
				return;
			case ePositionText.LB:
				this.radioButtonKeyLB.Checked = true;
				return;
			case ePositionText.L:
				this.radioButtonKeyL.Checked = true;
				return;
			default:
				return;
			}
		}

		private void checkBoxDamage_CheckedChanged(object sender, EventArgs e)
		{
			this.groupBoxDamage.Enabled = this.checkBoxDamage.Checked;
		}

		private void checkBoxKey_CheckedChanged(object sender, EventArgs e)
		{
			this.groupBoxKey.Enabled = this.checkBoxKey.Checked;
		}

		private void newTransRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.newTransNameTextBox.Enabled = this.newTransRadioButton.Checked;
		}

		private void mdMyceIfu3(object sender, EventArgs e)
		{
			this.oldTransComboBox.Enabled = this.oldTransRadioButton.Checked;
		}

		private void TransformerToolPropertyForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				ObjectOnLine objectOnLine = (ObjectOnLine)this.objectOnLine_0.Clone(false);
				if (this.newTransRadioButton.Checked)
				{
					if (string.IsNullOrEmpty(this.newTransNameTextBox.Text))
					{
						MessageBox.Show("Введите имя объекта");
						e.Cancel = true;
						return;
					}
					this.objectOnLine_0.Text = this.newTransNameTextBox.Text;
				}
				if (this.oldTransRadioButton.Checked)
				{
					if (this.oldTransComboBox.SelectedIndex < 0)
					{
						MessageBox.Show("Объект не выбран");
						e.Cancel = true;
						return;
					}
					this.objectOnLine_0.Text = this.oldTransComboBox.Text;
					this.objectOnLine_0.IdBase = (int)this.oldTransComboBox.SelectedValue;
				}
				if (this.radioButtonNotVisible.Checked)
				{
					this.objectOnLine_0.TextProperty.Visible = false;
				}
				else
				{
					this.objectOnLine_0.TextProperty.Visible = true;
				}
				if (this.aCgDyblRoR.Checked)
				{
					this.objectOnLine_0.TextProperty.Position = ePositionText.L;
				}
				if (this.radioButtonLT.Checked)
				{
					this.objectOnLine_0.TextProperty.Position = ePositionText.LT;
				}
				if (this.radioButtonT.Checked)
				{
					this.objectOnLine_0.TextProperty.Position = ePositionText.T;
				}
				if (this.radioButtonRT.Checked)
				{
					this.objectOnLine_0.TextProperty.Position = ePositionText.RT;
				}
				if (this.radioButtonR.Checked)
				{
					this.objectOnLine_0.TextProperty.Position = ePositionText.R;
				}
				if (this.radioButtonRB.Checked)
				{
					this.objectOnLine_0.TextProperty.Position = ePositionText.RB;
				}
				if (this.radioButtonB.Checked)
				{
					this.objectOnLine_0.TextProperty.Position = ePositionText.B;
				}
				if (this.radioButtonLB.Checked)
				{
					this.objectOnLine_0.TextProperty.Position = ePositionText.LB;
				}
				if (!this.checkBoxDamage.Checked)
				{
					this.objectOnLine_0.PositionDamage = ePositionText.None;
				}
				else
				{
					if (this.radioButtonDamageL.Checked)
					{
						this.objectOnLine_0.PositionDamage = ePositionText.L;
					}
					if (this.radioButtonDamageLT.Checked)
					{
						this.objectOnLine_0.PositionDamage = ePositionText.LT;
					}
					if (this.radioButtonDamageT.Checked)
					{
						this.objectOnLine_0.PositionDamage = ePositionText.T;
					}
					if (this.radioButtonDamageRT.Checked)
					{
						this.objectOnLine_0.PositionDamage = ePositionText.RT;
					}
					if (this.radioButtonDamageR.Checked)
					{
						this.objectOnLine_0.PositionDamage = ePositionText.R;
					}
					if (this.radioButtonDamageRB.Checked)
					{
						this.objectOnLine_0.PositionDamage = ePositionText.RB;
					}
					if (this.radioButtonDamageB.Checked)
					{
						this.objectOnLine_0.PositionDamage = ePositionText.B;
					}
					if (this.radioButtonDamageLB.Checked)
					{
						this.objectOnLine_0.PositionDamage = ePositionText.LB;
					}
				}
				if (!this.checkBoxKey.Checked)
				{
					this.objectOnLine_0.PositionKey = ePositionText.None;
				}
				else
				{
					if (this.radioButtonKeyL.Checked)
					{
						this.objectOnLine_0.PositionKey = ePositionText.L;
					}
					if (this.radioButtonKeyLT.Checked)
					{
						this.objectOnLine_0.PositionKey = ePositionText.LT;
					}
					if (this.radioButtonKeyT.Checked)
					{
						this.objectOnLine_0.PositionKey = ePositionText.T;
					}
					if (this.radioButtonKeyRT.Checked)
					{
						this.objectOnLine_0.PositionKey = ePositionText.RT;
					}
					if (this.radioButtonKeyR.Checked)
					{
						this.objectOnLine_0.PositionKey = ePositionText.R;
					}
					if (this.radioButtonKeyRB.Checked)
					{
						this.objectOnLine_0.PositionKey = ePositionText.RB;
					}
					if (this.radioButtonKeyB.Checked)
					{
						this.objectOnLine_0.PositionKey = ePositionText.B;
					}
					if (this.radioButtonKeyLB.Checked)
					{
						this.objectOnLine_0.PositionKey = ePositionText.LB;
					}
				}
				if (!this.objectOnLine_0.Layer.Parent.ValidateToUnique(this.objectOnLine_0))
				{
					MessageBox.Show("Такой объект уже есть на данной схеме");
					e.Cancel = true;
					return;
				}
				if (this.objectOnLine_0.Layer.Parent.UseObjectFromDB)
				{
					if (this.objectOnLine_0.MappingState)
					{
						if (this.objectOnLine_0.Parent != null && this.objectOnLine_0.Parent.Parent != null)
						{
							this.objectOnLine_0.Parent.Parent.SaveToSql(false, false);
							return;
						}
					}
					else if (!this.objectOnLine_0.SaveToSql(false, true))
					{
						this.objectOnLine_0.Text = objectOnLine.Text;
						this.objectOnLine_0.TextProperty.Visible = objectOnLine.TextProperty.Visible;
						this.objectOnLine_0.TextProperty.Position = objectOnLine.TextProperty.Position;
						this.objectOnLine_0.UseSettingColor = objectOnLine.UseSettingColor;
						this.objectOnLine_0.Color = objectOnLine.Color;
						this.objectOnLine_0.TextProperty.FontVirtical = objectOnLine.TextProperty.FontVirtical;
						e.Cancel = true;
						return;
					}
				}
			}
		}

		private SQLSettings sqlsettings_0;

		private ObjectOnLine objectOnLine_0;
	}
}
