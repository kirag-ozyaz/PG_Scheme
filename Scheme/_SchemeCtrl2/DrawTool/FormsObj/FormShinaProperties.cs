using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.Data;
using SchemeCtrl2.Layers;

namespace SchemeCtrl2.DrawTool.FormsObj
{
	public partial class FormShinaProperties : Form
	{
		public ShinaTool ShinaObj
		{
			get
			{
				return this.shinaTool_0;
			}
		}

		public FormShinaProperties()
		{
			this.InitializeComponent();
		}

		public FormShinaProperties(ShinaTool shinaTool_1, SQLSettings sqlSett)
		{
			this.InitializeComponent();
			this.sqlsettings_0 = sqlSett;
			this.shinaTool_0 = shinaTool_1;
			if (this.shinaTool_0.Layer != null && this.shinaTool_0.Layer.Parent != null)
			{
				PointF pointF = ConvertCanvas.ConvertToScreen(this.shinaTool_0.Layer.Parent, this.shinaTool_0.P2);
				base.Location = this.shinaTool_0.Layer.Parent.PointToScreen(new Point((int)pointF.X, (int)pointF.Y));
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
				this.buttonOK.Enabled = (this.shinaTool_0.Layer.Parent.Mode == eCanvasEditingMode.Edit);
				this.comboBoxVolt.Enabled = (this.groupBox2.Enabled = (this.groupBox3.Enabled = !this.shinaTool_0.LimitedEditing));
			}
			this.comboBoxTP.Items.Clear();
			this.comboBoxVolt.Items.Clear();
			if (this.shinaTool_0.Parent != null && ((RectangleTool)this.shinaTool_0.Parent).TypeRectnagleTool == eTypeRectangleTool.CP)
			{
				this.groupBoxAmp.Visible = true;
				if (this.shinaTool_0.Amperage == null)
				{
					this.radioButtonOff.Checked = true;
				}
				else
				{
					this.radioButtonOn.Checked = true;
				}
			}
			Class91 @class = null;
			this.shinaTool_0.Layer.Parent.Graphics = Graphics.FromHwnd(this.shinaTool_0.Layer.Parent.Handle);
			foreach (ICanvasLayer canvasLayer in this.shinaTool_0.Layer.Parent.Layers)
			{
				DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
				foreach (DrawObjectBase drawObjectBase in drawingLayer.Objects)
				{
					if (drawObjectBase.GetType() == typeof(RectangleTool))
					{
						Class91 class2 = new Class91((RectangleTool)drawObjectBase);
						this.comboBoxTP.Items.Add(class2);
						if (this.shinaTool_0.Parent == drawObjectBase)
						{
							@class = class2;
						}
						if (this.shinaTool_0.ObjectInRectangle(this.shinaTool_0.Layer.Parent, ((RectangleTool)drawObjectBase).Rectangle, false) && (@class == null || this.shinaTool_0.Layer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond))
						{
							@class = class2;
						}
					}
				}
			}
			if (this.shinaTool_0.Parent == null)
			{
				this.comboBoxTP.SelectedIndex = -1;
			}
			else
			{
				this.comboBoxTP.Text = this.shinaTool_0.Parent.Text;
			}
			if (@class != null)
			{
				this.comboBoxTP.SelectedItem = @class;
			}
			if (this.shinaTool_0.TextProperty.Visible)
			{
				switch (this.shinaTool_0.TextProperty.Position)
				{
				case ePositionText.T:
					this.radioButtonT.Checked = true;
					break;
				case ePositionText.R:
					this.radioButtonRight.Checked = true;
					break;
				case ePositionText.B:
					this.radioButtonB.Checked = true;
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
			this.panelColor.BackColor = this.shinaTool_0.Color;
			this.comboBoxVolt.Items.Add(new Class92(Convert.ToInt32(eTypeShinaTool.Shina_110), "110 кВ"));
			this.comboBoxVolt.Items.Add(new Class92(Convert.ToInt32(eTypeShinaTool.Shina_35), "35 кВ"));
			this.comboBoxVolt.Items.Add(new Class92(Convert.ToInt32(eTypeShinaTool.Shina_10), "10 кВ"));
			this.comboBoxVolt.Items.Add(new Class92(Convert.ToInt32(eTypeShinaTool.Shina_6), "6 кВ"));
			this.comboBoxVolt.Items.Add(new Class92(Convert.ToInt32(eTypeShinaTool.Shina_04), "0.4 кВ"));
			this.comboBoxVolt.Items.Add(new Class92(Convert.ToInt32(eTypeShinaTool.Shina_023), "0.23 кВ"));
			eTypeShinaTool typeShinaTool = this.shinaTool_0.TypeShinaTool;
			switch (typeShinaTool)
			{
			case eTypeShinaTool.Shina_04:
				this.comboBoxVolt.SelectedIndex = 4;
				break;
			case eTypeShinaTool.Shina_6:
				this.comboBoxVolt.SelectedIndex = 3;
				break;
			default:
				switch (typeShinaTool)
				{
				case eTypeShinaTool.Shina_023:
					this.comboBoxVolt.SelectedIndex = 5;
					break;
				case eTypeShinaTool.Shina_10:
					this.comboBoxVolt.SelectedIndex = 2;
					break;
				default:
					switch (typeShinaTool)
					{
					case eTypeShinaTool.Shina_35:
						this.comboBoxVolt.SelectedIndex = 1;
						break;
					case eTypeShinaTool.Shina_110:
						this.comboBoxVolt.SelectedIndex = 0;
						break;
					default:
						this.comboBoxVolt.SelectedIndex = 0;
						break;
					}
					break;
				}
				break;
			}
			if (this.shinaTool_0.TextVoltProperty.Visible)
			{
				ePositionText position = this.shinaTool_0.TextVoltProperty.Position;
				if (position != ePositionText.R)
				{
					if (position == ePositionText.L)
					{
						this.radioButtonVoltL.Checked = true;
					}
				}
				else
				{
					this.radioButtonVoltR.Checked = true;
				}
			}
			else
			{
				this.radioButtonNoVolt.Checked = true;
			}
			this.cmbTextBase.Text = this.shinaTool_0.Text;
			int num = 1;
			if (int.TryParse(this.shinaTool_0.Text, out num))
			{
				this.numericUpDownTextNew.Value = Convert.ToInt32(this.ShinaObj.Text);
				return;
			}
			this.numericUpDownTextNew.Value = 1m;
		}

		private void FormShinaProperties_Load(object sender, EventArgs e)
		{
			this.method_1();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			DataSetScheme dataSetScheme = new DataSetScheme();
			sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_ObjList, true, " where id = " + this.shinaTool_0.IdBase.ToString());
			if (dataSetScheme.tSchm_ObjList.Rows.Count > 0 && dataSetScheme.tSchm_ObjList.Rows[0]["Tag"] != DBNull.Value)
			{
				this.int_0 = Convert.ToInt32(dataSetScheme.tSchm_ObjList.Rows[0]["Tag"]);
				this.cmbParentBus.SelectedValue = this.int_0;
			}
		}

		private void FormShinaProperties_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				ShinaTool acopy = (ShinaTool)this.shinaTool_0.Clone(false);
				if (this.radioBtnTextBase.Checked)
				{
					this.shinaTool_0.IdBase = Convert.ToInt32(this.cmbTextBase.SelectedValue);
					this.shinaTool_0.Text = this.cmbTextBase.Text;
				}
				else
				{
					this.shinaTool_0.Text = this.numericUpDownTextNew.Value.ToString();
				}
				if (this.radioButtonNotVisible.Checked)
				{
					this.shinaTool_0.TextProperty.Visible = false;
				}
				else
				{
					this.shinaTool_0.TextProperty.Visible = true;
					if (this.radioButtonLeft.Checked)
					{
						this.shinaTool_0.TextProperty.Position = ePositionText.L;
					}
					if (this.radioButtonT.Checked)
					{
						this.shinaTool_0.TextProperty.Position = ePositionText.T;
					}
					if (this.radioButtonRight.Checked)
					{
						this.shinaTool_0.TextProperty.Position = ePositionText.R;
					}
					if (this.radioButtonB.Checked)
					{
						this.shinaTool_0.TextProperty.Position = ePositionText.B;
					}
				}
				if (this.shinaTool_0.Color != this.panelColor.BackColor)
				{
					this.shinaTool_0.UseSettingColor = false;
					this.shinaTool_0.Color = this.panelColor.BackColor;
				}
				if (this.comboBoxTP.SelectedItem == null)
				{
					MessageBox.Show("Не выбрана подстанция для шины");
					this.shinaTool_0.Copy(acopy);
					e.Cancel = true;
					return;
				}
				this.shinaTool_0.Parent = ((Class91)this.comboBoxTP.SelectedItem).method_0();
				if (this.comboBoxVolt.SelectedItem == null)
				{
					this.shinaTool_0.TypeShinaTool = eTypeShinaTool.Shina_10;
				}
				else
				{
					this.shinaTool_0.TypeShinaTool = (eTypeShinaTool)((Class92)this.comboBoxVolt.SelectedItem).Id;
				}
				if (this.radioButtonNoVolt.Checked)
				{
					this.shinaTool_0.TextVoltProperty.Visible = false;
				}
				else
				{
					this.shinaTool_0.TextVoltProperty.Visible = true;
					if (this.radioButtonVoltL.Checked)
					{
						this.shinaTool_0.TextVoltProperty.Position = ePositionText.L;
					}
					if (this.radioButtonVoltR.Checked)
					{
						this.shinaTool_0.TextVoltProperty.Position = ePositionText.R;
					}
				}
				if (!this.shinaTool_0.Layer.Parent.ValidateToUnique(this.shinaTool_0))
				{
					MessageBox.Show("Такой объект уже есть на данной схеме");
					this.shinaTool_0.Copy(acopy);
					e.Cancel = true;
					return;
				}
				if (this.shinaTool_0.Layer.Parent.UseObjectFromDB)
				{
					if (!this.shinaTool_0.SaveToSql(false, true))
					{
						this.shinaTool_0.Copy(acopy);
						e.Cancel = true;
						return;
					}
					SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
					DataSetScheme dataSetScheme = new DataSetScheme();
					sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_ObjList, true, " where id = " + this.shinaTool_0.IdBase.ToString());
					if (dataSetScheme.tSchm_ObjList.Rows.Count > 0)
					{
						if (this.int_0 == -1)
						{
							dataSetScheme.tSchm_ObjList.Rows[0]["Tag"] = DBNull.Value;
						}
						else
						{
							dataSetScheme.tSchm_ObjList.Rows[0]["Tag"] = this.int_0;
						}
						dataSetScheme.tSchm_ObjList.Rows[0].EndEdit();
						sqlDataCommand.UpdateSqlData(dataSetScheme, dataSetScheme.tSchm_ObjList);
					}
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

		private void radioBtnTextBase_CheckedChanged(object sender, EventArgs e)
		{
			this.cmbTextBase.Enabled = this.radioBtnTextBase.Checked;
			this.numericUpDownTextNew.Enabled = !this.radioBtnTextBase.Checked;
		}

		private void comboBoxTP_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_0();
			this.method_1();
		}

		private void comboBoxVolt_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_0();
			this.method_1();
		}

		private void method_0()
		{
			if (this.comboBoxVolt.SelectedItem == null)
			{
				this.dataSet_1.Clear();
				this.radioBtnTextNew.Checked = true;
				this.radioBtnTextBase.Enabled = false;
				return;
			}
			if (this.comboBoxTP.SelectedIndex >= 0 && this.comboBoxTP.SelectedItem != null)
			{
				SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
				if (((Class91)this.comboBoxTP.SelectedItem).method_0().IdBase <= 0)
				{
					this.dataSet_1.Clear();
					this.radioBtnTextNew.Checked = true;
					this.radioBtnTextBase.Enabled = false;
					return;
				}
				sqlDataCommand.SelectSqlData(this.dataSet_1, "tSchm_ObjList", true, " where idParent = " + ((Class91)this.comboBoxTP.SelectedItem).method_0().IdBase.ToString() + " and TypeCodeId = " + Convert.ToInt32((eTypeShinaTool)((Class92)this.comboBoxVolt.SelectedItem).Id).ToString());
				if (this.dataSet_1.Tables["tSchm_ObjList"].Rows.Count == 0)
				{
					this.radioBtnTextNew.Checked = true;
					this.radioBtnTextBase.Enabled = false;
					return;
				}
				this.radioBtnTextBase.Enabled = true;
			}
		}

		private void method_1()
		{
			if (this.comboBoxTP.SelectedItem != null)
			{
				RectangleTool rectangleTool = ((Class91)this.comboBoxTP.SelectedItem).method_0();
				if (this.comboBoxVolt.SelectedItem != null)
				{
					eTypeShinaTool id = (eTypeShinaTool)((Class92)this.comboBoxVolt.SelectedItem).Id;
					SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
					DataSetScheme dataSetScheme = new DataSetScheme();
					SqlDataCommand sqlDataCommand2 = sqlDataCommand;
					DataSet ds = dataSetScheme;
					DataTable tSchm_ObjList = dataSetScheme.tSchm_ObjList;
					bool withGetSqlPermission = true;
					string[] array = new string[7];
					array[0] = " where idParent = ";
					array[1] = rectangleTool.IdBase.ToString();
					array[2] = " and typeCodeId = ";
					string[] array2 = array;
					int num = 3;
					int num2 = (int)id;
					array2[num] = num2.ToString();
					array[4] = " and Tag = ";
					array[5] = this.shinaTool_0.IdBase.ToString();
					array[6] = " and deleted = 0 order by name";
					sqlDataCommand2.SelectSqlData(ds, tSchm_ObjList, withGetSqlPermission, string.Concat(array));
					if (dataSetScheme.tSchm_ObjList.Rows.Count > 0)
					{
						this.cmbParentBus.Enabled = false;
						return;
					}
					SqlDataCommand sqlDataCommand3 = sqlDataCommand;
					DataSet ds2 = dataSetScheme;
					DataTable tSchm_ObjList2 = dataSetScheme.tSchm_ObjList;
					bool withGetSqlPermission2 = true;
					string[] array3 = new string[7];
					array3[0] = " where idParent = ";
					array3[1] = rectangleTool.IdBase.ToString();
					array3[2] = " and typeCodeId = ";
					string[] array4 = array3;
					int num3 = 3;
					int num4 = (int)id;
					array4[num3] = num4.ToString();
					array3[4] = " and id <> ";
					array3[5] = this.shinaTool_0.IdBase.ToString();
					array3[6] = " and Tag is null and deleted = 0 order by name";
					sqlDataCommand3.SelectSqlData(ds2, tSchm_ObjList2, withGetSqlPermission2, string.Concat(array3));
					this.cmbParentBus.SelectedValueChanged -= this.cmbParentBus_SelectedValueChanged;
					this.cmbParentBus.DataSource = dataSetScheme.tSchm_ObjList;
					this.cmbParentBus.DisplayMember = "name";
					this.cmbParentBus.ValueMember = "id";
					this.cmbParentBus.SelectedValueChanged += this.cmbParentBus_SelectedValueChanged;
					this.cmbParentBus.SelectedValue = this.int_0;
				}
			}
		}

		private void cmbParentBus_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.cmbParentBus.SelectedValue != null)
			{
				this.int_0 = Convert.ToInt32(this.cmbParentBus.SelectedValue);
				return;
			}
			this.int_0 = -1;
		}

		private void cmbParentBus_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				this.cmbParentBus.SelectedIndex = -1;
			}
		}

		private ShinaTool shinaTool_0;

		private SQLSettings sqlsettings_0;

		private int int_0 = -1;
	}
}
