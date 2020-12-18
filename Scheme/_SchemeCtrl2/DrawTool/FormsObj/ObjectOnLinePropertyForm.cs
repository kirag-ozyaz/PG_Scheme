using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class ObjectOnLinePropertyForm : Form
	{
		public ObjectOnLinePropertyForm()
		{
			this.InitializeComponent();
		}

		public ObjectOnLinePropertyForm(ObjectOnLine objectOnLine, SQLSettings sqlSett)
		{
			this.InitializeComponent();
			this.objectOnLine_0 = objectOnLine;
			this.font_0 = objectOnLine.TextProperty.Font;
			this.color_0 = objectOnLine.TextProperty.Color;
			this.sqlsettings_0 = sqlSett;
			if (objectOnLine.Layer != null && objectOnLine.Layer.Parent != null)
			{
				if (objectOnLine.Layer.Parent.Mode != eCanvasEditingMode.Edit)
				{
					this.buttonOK.Enabled = false;
				}
				if (objectOnLine.Layer.Parent.Mode == eCanvasEditingMode.Dispatcher && objectOnLine.MappingState)
				{
					this.buttonOK.Enabled = true;
				}
				this.panelNormalSection.Enabled = (this.panel2.Enabled = (this.panel3.Enabled = (this.checkBoxSetComplexSwitchgear.Enabled = (this.textBoxName.Enabled = (this.panelOnOff.Enabled = !objectOnLine.LimitedEditing)))));
			}
			this.textBoxName.Text = this.objectOnLine_0.Text;
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
					this.radioButtonL.Checked = true;
					break;
				}
			}
			else
			{
				this.radioButtonNotVisible.Checked = true;
			}
			switch (this.objectOnLine_0.TextPropertyNormalSection.Position)
			{
			case ePositionText.T:
				this.radioButtonNormalTop.Checked = true;
				break;
			case ePositionText.R:
				this.radioButtonNormalRight.Checked = true;
				break;
			case ePositionText.B:
				this.radioButtonNormalBottom.Checked = true;
				break;
			case ePositionText.L:
				this.radioButtonNormalLeft.Checked = true;
				break;
			}
			if (this.objectOnLine_0.IsNormalSection)
			{
				this.checkBoxNormal.Checked = true;
			}
			else
			{
				this.checkBoxNormal.Checked = false;
			}
			if (this.objectOnLine_0.On)
			{
				this.onRadioButton.Checked = true;
			}
			else
			{
				this.offRadioButton.Checked = true;
			}
			if (objectOnLine.MappingState || !objectOnLine.GetType().GetProperty("On").CanWrite)
			{
				this.panelNormalSection.Visible = false;
				this.panelOnOff.Visible = false;
			}
			this.gorMirrorCheckBox.Checked = objectOnLine.GorMirror;
			this.vertMirrorCheckBox.Checked = objectOnLine.VertMirror;
			if (objectOnLine.PositionDamage != ePositionText.None)
			{
				this.checkBoxDamage.Checked = true;
				switch (objectOnLine.PositionDamage)
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
			if (objectOnLine.PositionKey != ePositionText.None)
			{
				this.checkBoxKey.Checked = true;
				switch (objectOnLine.PositionKey)
				{
				case ePositionText.LT:
					this.radioButtonKeyLT.Checked = true;
					break;
				case ePositionText.T:
					this.radioButtonKeyT.Checked = true;
					break;
				case ePositionText.RT:
					this.radioButtonKeyRT.Checked = true;
					break;
				case ePositionText.R:
					this.radioButtonKeyR.Checked = true;
					break;
				case ePositionText.RB:
					this.radioButtonKeyRB.Checked = true;
					break;
				case ePositionText.B:
					this.radioButtonKeyB.Checked = true;
					break;
				case ePositionText.LB:
					this.radioButtonKeyLB.Checked = true;
					break;
				case ePositionText.L:
					this.radioButtonKeyL.Checked = true;
					break;
				}
			}
			else
			{
				this.checkBoxKey.Checked = false;
			}
			this.checkBoxSetComplexSwitchgear.Checked = (objectOnLine.ComplexSwitchgear != null);
			this.checkBoxUseSettingsCanvas.Checked = (this.objectOnLine_0.UseSettingColor && this.objectOnLine_0.UseSettingsText);
			this.panelColorObj.BackColor = this.objectOnLine_0.Color;
			TypeSwitch typeSwitch = this.objectOnLine_0.TypeSwitch;
			if (typeSwitch <= TypeSwitch.EndTrimTool)
			{
				if (typeSwitch == TypeSwitch.SeparatorTool)
				{
					this.Text = "Свойства отделителя";
					return;
				}
				switch (typeSwitch)
				{
				case TypeSwitch.LubricantSwitchTool:
					this.Text = "Свойства маслянного выключателя";
					return;
				case TypeSwitch.LinearDisconnectorTool:
					this.Text = "Свойства линейного разъединителя";
					return;
				case TypeSwitch.LoadSwitchTool:
					this.Text = "Свойства выключателя нагрузки";
					return;
				case TypeSwitch.GroundingTool:
					this.Text = "Свойства заземления";
					return;
				case TypeSwitch.TransformerTool:
					this.Text = "Свойства трансформатора";
					this.panelOnOff.Visible = false;
					return;
				case TypeSwitch.DamageTool:
					this.Text = "Свойства повреждения кабеля";
					return;
				case TypeSwitch.VacuumSwitchTool:
					this.Text = "Свойства вакуумного выключателя";
					return;
				case TypeSwitch.OutsideLineDisconnectorTool:
					this.Text = "Свойства наружного линейного разъединителя";
					return;
				default:
					if (typeSwitch != TypeSwitch.EndTrimTool)
					{
						return;
					}
					this.Text = "Свойства концевой разделки";
					return;
				}
			}
			else if (typeSwitch <= TypeSwitch.AmperageTransformer)
			{
				switch (typeSwitch)
				{
				case TypeSwitch.FuseTool:
					this.Text = "Свойства предохранителя";
					return;
				case TypeSwitch.DischargerTool:
					this.Text = "Свойства разрядника";
					return;
				case TypeSwitch.VoltageLimiterTool:
					this.Text = "Свойства ограничителя перенапряжения";
					return;
				case TypeSwitch.VoltageTransformerTool:
					this.Text = "Свойство трансформатора напряжения";
					this.panelOnOff.Visible = false;
					return;
				default:
					switch (typeSwitch)
					{
					case TypeSwitch.RPSTool:
						this.Text = "Свойства РПС";
						return;
					case TypeSwitch.AmperageTransformer:
						this.Text = "Свойство трансформатора тока";
						this.panelOnOff.Visible = false;
						return;
					default:
						return;
					}
					break;
				}
			}
			else
			{
				switch (typeSwitch)
				{
				case TypeSwitch.OffTool:
					this.Text = "Свойства отключения кабеля";
					return;
				case TypeSwitch.NotPhasedTool:
					this.Text = "Свойства несфазирования";
					return;
				default:
					if (typeSwitch != TypeSwitch.MagneticStarterTool)
					{
						return;
					}
					this.Text = "Свойства магнитного пускателя";
					this.panelMagneticStarter.Visible = true;
					this.checkBoxAPhase.Checked = ((MagneticStarterTool)this.objectOnLine_0).APhaseFlag;
					this.checkBoxBPhase.Checked = ((MagneticStarterTool)this.objectOnLine_0).BPhaseFlag;
					this.checkBoxCPhase.Checked = ((MagneticStarterTool)this.objectOnLine_0).CPhaseFlag;
					return;
				}
			}
		}

		private void ObjectOnLinePropertyForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				ObjectOnLine objectOnLine = (ObjectOnLine)this.objectOnLine_0.Clone(false);
				if (string.IsNullOrEmpty(this.textBoxName.Text))
				{
					MessageBox.Show("Введите имя объекта");
					e.Cancel = true;
					return;
				}
				this.objectOnLine_0.Text = this.textBoxName.Text;
				if (this.radioButtonNotVisible.Checked)
				{
					this.objectOnLine_0.TextProperty.Visible = false;
				}
				else
				{
					this.objectOnLine_0.TextProperty.Visible = true;
				}
				if (this.radioButtonL.Checked)
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
				if (!this.checkBoxNormal.Checked)
				{
					this.objectOnLine_0.IsNormalSection = false;
				}
				else
				{
					this.objectOnLine_0.IsNormalSection = true;
				}
				if (this.radioButtonNormalLeft.Checked)
				{
					this.objectOnLine_0.TextPropertyNormalSection.Position = ePositionText.L;
				}
				if (this.radioButtonNormalTop.Checked)
				{
					this.objectOnLine_0.TextPropertyNormalSection.Position = ePositionText.T;
				}
				if (this.radioButtonNormalRight.Checked)
				{
					this.objectOnLine_0.TextPropertyNormalSection.Position = ePositionText.R;
				}
				if (this.radioButtonNormalBottom.Checked)
				{
					this.objectOnLine_0.TextPropertyNormalSection.Position = ePositionText.B;
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
				if (this.objectOnLine_0.On != this.onRadioButton.Checked)
				{
					try
					{
						this.objectOnLine_0.On = this.onRadioButton.Checked;
					}
					catch (AmperageException ex)
					{
						List<DrawObjectBase> list = new List<DrawObjectBase>();
						DrawObjectBase sourceException = ex.SourceException;
						list.Add(sourceException);
						sourceException.Layer.Parent.ClearSelectedObjects();
						sourceException.Layer.Parent.SelectObject(sourceException);
						sourceException.Layer.Parent.SetObjectsInCenterScreen(list, false, CanvasControl.SetObjectsInCenterScreenOptions.none);
						sourceException.Layer.Parent.undoRedoManager.Undo();
						MessageBox.Show(ex.Message + "\r\nПоследнее действие отменено");
					}
				}
				if (this.panelMagneticStarter.Visible)
				{
					((MagneticStarterTool)this.objectOnLine_0).APhaseFlag = this.checkBoxAPhase.Checked;
					((MagneticStarterTool)this.objectOnLine_0).BPhaseFlag = this.checkBoxBPhase.Checked;
					((MagneticStarterTool)this.objectOnLine_0).CPhaseFlag = this.checkBoxCPhase.Checked;
				}
				if (this.checkBoxUseSettingsCanvas.Checked)
				{
					this.objectOnLine_0.UseSettingColor = true;
					this.objectOnLine_0.UseSettingsText = true;
				}
				else if (this.objectOnLine_0.MappingState)
				{
					this.objectOnLine_0.UseSettingColor = false;
					this.objectOnLine_0.Color = this.panelColorObj.BackColor;
				}
				else
				{
					this.objectOnLine_0.UseSettingsText = false;
					this.objectOnLine_0.TextProperty.Font = this.font_0;
					this.objectOnLine_0.TextProperty.Color = this.color_0;
				}
				this.objectOnLine_0.GorMirror = this.gorMirrorCheckBox.Checked;
				this.objectOnLine_0.VertMirror = this.vertMirrorCheckBox.Checked;
				if (this.checkBoxSetComplexSwitchgear.Checked && this.objectOnLine_0.ComplexSwitchgear == null)
				{
					this.objectOnLine_0.SetComplexSwitchgear();
				}
				else if (!this.checkBoxSetComplexSwitchgear.Checked && this.objectOnLine_0.ComplexSwitchgear != null)
				{
					this.objectOnLine_0.RemoveComplexSwitchgear();
				}
				if (!this.objectOnLine_0.Layer.Parent.ValidateToUnique(this.objectOnLine_0))
				{
					MessageBox.Show("Такой объект уже есть на данной схеме");
					e.Cancel = true;
					return;
				}
				if (this.objectOnLine_0.Layer.Parent.UseObjectFromDB)
				{
					if (this.objectOnLine_0 is ArrowTool)
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
					}
				}
			}
		}

		private void checkBoxNormal_CheckedChanged(object sender, EventArgs e)
		{
			this.groupBoxNormal.Enabled = this.checkBoxNormal.Checked;
		}

		private void checkBoxDamage_CheckedChanged(object sender, EventArgs e)
		{
			this.groupBoxDamage.Enabled = this.checkBoxDamage.Checked;
		}

		private void checkBoxKey_CheckedChanged(object sender, EventArgs e)
		{
			this.groupBoxKey.Enabled = this.checkBoxKey.Checked;
		}

		private void checkBoxUseSettingsCanvas_CheckedChanged(object sender, EventArgs e)
		{
			this.panelColorObj.Enabled = !this.checkBoxUseSettingsCanvas.Checked;
			this.buttonFontObj.Enabled = !this.checkBoxUseSettingsCanvas.Checked;
			if (this.objectOnLine_0.MappingState)
			{
				this.buttonFontObj.Enabled = false;
				return;
			}
			this.panelColorObj.Enabled = false;
		}

		private void panelColorObj_DoubleClick(object sender, EventArgs e)
		{
			using (ColorDialog colorDialog = new ColorDialog())
			{
				colorDialog.Color = this.panelColorObj.BackColor;
				if (colorDialog.ShowDialog() == DialogResult.OK)
				{
					this.panelColorObj.BackColor = colorDialog.Color;
				}
			}
		}

		private void buttonFontObj_Click(object sender, EventArgs e)
		{
			using (FontDialog fontDialog = new FontDialog())
			{
				fontDialog.AllowVectorFonts = true;
				fontDialog.AllowVerticalFonts = true;
				fontDialog.ShowColor = true;
				fontDialog.Font = this.font_0;
				fontDialog.Color = this.color_0;
				if (fontDialog.ShowDialog() == DialogResult.OK)
				{
					this.font_0 = fontDialog.Font;
					this.color_0 = fontDialog.Color;
				}
			}
		}

		private ObjectOnLine objectOnLine_0;

		private SQLSettings sqlsettings_0;

		private Font font_0;

		private Color color_0;
	}
}
