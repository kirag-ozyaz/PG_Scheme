using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;
using Passport.Classes;
using Passport.Controls;

internal class Form9 : FormBase
{
	[CompilerGenerated]
	internal StateFormCreate method_0()
	{
		return this.stateFormCreate_0;
	}

	[CompilerGenerated]
	internal void method_1(StateFormCreate stateFormCreate_1)
	{
		this.stateFormCreate_0 = stateFormCreate_1;
	}

	internal int method_2()
	{
		return this.int_1;
	}

	internal Form9(int int_3, int int_4, int int_5)
	{
		Class330.Mus9JxKz1CNxy();
		this.int_0 = -1;
		this.int_1 = -1;
		this.int_2 = -1;
		this.string_0 = string.Empty;
		base..ctor();
		this.method_15();
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
		this.dataGridViewPassport_0.DataError -= this.dataGridViewPassport_0_DataError;
		this.dataGridViewPassport_0.DataError += this.dataGridViewPassport_0_DataError;
	}

	private void method_3()
	{
		if (this.comboBox_1.SelectedIndex == -1)
		{
			this.method_4(1);
			return;
		}
		if (!this.checkBox_0.Checked)
		{
			this.method_4(2);
			return;
		}
		this.method_4(0);
	}

	private void method_4(int int_3)
	{
		if (this.method_0() == 1)
		{
			this.comboBox_3.Enabled = false;
			this.comboBox_1.Enabled = false;
			this.checkBox_0.Enabled = false;
			this.checkBox_0.Checked = true;
			Control control = this.comboBox_2;
			this.comboBox_2.Enabled = false;
			control.Visible = false;
			Control control2 = this.textBox_0;
			this.textBox_0.Enabled = true;
			control2.Visible = true;
			this.dateTimePicker_0.Enabled = false;
			return;
		}
		bool enabled = int_3 == 0 || int_3 == 2;
		this.checkBox_0.Enabled = enabled;
		this.comboBox_2.Enabled = enabled;
		this.textBox_0.Visible = (this.textBox_0.Enabled = (int_3 == 0 && int_3 != 2));
		this.dataGridViewPassport_0.Enabled = enabled;
	}

	private void method_5()
	{
		this.comboBox_2.Enabled = (this.comboBox_2.Visible = this.bool_0);
		this.textBox_0.Enabled = (this.textBox_0.Visible = !this.bool_0);
	}

	protected override void OnLoad(EventArgs eventArgs_0)
	{
		base.OnLoad(eventArgs_0);
		this.dateTimePicker_0.MaxDate = DateTime.Now.Date;
		this.method_6();
		this.Text = ((this.method_0() == null) ? "Добавление оборудования на опору" : "Редактирование паспорта оборудования");
		this.method_4(-1);
		this.method_7();
	}

	private void method_6()
	{
		DataTable dataTable = new DataTable("tSchm_ObjList");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("name", typeof(string));
		this.comboBox_3.DataSource = dataTable;
		this.comboBox_3.DisplayMember = "name";
		this.comboBox_3.ValueMember = "id";
		base.SelectSqlData(dataTable, true, string.Format("where id in (select idClutchFirst as idPole from tP_CabSection where idObjList = '{0}' and Deleted = '0'\r\nunion select idClutchSecond as idPole from tP_CabSection where idObjList = '{0}' and Deleted = '0')\r\nor (idParent = '{0}' and typeCodeId in (select id from tR_Classifier where deleted = '0' and isGroup = '0'\r\nand ParentKey = ';SCM;Pole;') and deleted = '0') order by Name", this.int_0), null, false, 0);
		this.comboBox_3.SelectedIndex = -1;
		DataTable dataTable2 = new DataTable("tR_classifier");
		dataTable2.Columns.Add("id", typeof(int));
		dataTable2.Columns.Add("name", typeof(string));
		base.SelectSqlData(dataTable2, true, "WHERE (ParentKey = ';SCM;INLINE_OBJ;OTHER_OBJ;' and isGroup != '1' AND Value in (1,2)) OR  (ParentKey = ';SCM;INLINE_OBJ;SWITCH;' and value in (8, 14)) AND  isGroup = ((0)) AND Deleted = ((0)) order by value ", null, false, 0);
		this.comboBox_1.DataSource = dataTable2;
		this.comboBox_1.DisplayMember = "Name";
		this.comboBox_1.ValueMember = "id";
		this.comboBox_1.SelectedIndex = -1;
	}

	private void method_7()
	{
		if (this.int_1 == -1)
		{
			this.class244_0 = this.class107_0.tSchm_ObjList.method_5();
			this.class244_0.Deleted = false;
			this.class244_0.IdParent = this.method_8();
			if (this.int_2 != -1)
			{
				this.class244_0.idParentAddl = this.int_2;
			}
			this.class244_0.EndEdit();
			this.class107_0.tSchm_ObjList.method_0(this.class244_0);
			this.bool_0 = true;
			return;
		}
		base.SelectSqlData(this.class107_0, this.class107_0.tSchm_ObjList, true, string.Format("WHERE id = {0}", this.int_1));
		if (this.method_0() == null && this.int_2 != -1)
		{
			this.class107_0.tSchm_ObjList[0]["idParentAddl"] = this.int_2;
		}
		this.bool_0 = false;
	}

	private int method_8()
	{
		int result = -1;
		DataTable dataTable = new DataTable("tSchm_Relation");
		base.SelectSqlData(dataTable, true, "where edge = " + this.int_0.ToString(), null, false, 0);
		if (dataTable.Rows.Count > 0)
		{
			result = Convert.ToInt32(dataTable.Rows[0]["id"]);
		}
		return result;
	}

	private void method_9()
	{
		if (this.comboBox_1.SelectedValue == null)
		{
			return;
		}
		int num = (int)this.comboBox_1.SelectedValue;
		StringBuilder stringBuilder = new StringBuilder(100);
		int num2 = Convert.ToInt32(this.comboBox_1.SelectedValue);
		if (num2 == 1212)
		{
			stringBuilder.AppendFormat("{0}, 601", 1212);
		}
		else
		{
			stringBuilder.Append(Convert.ToInt32(this.comboBox_1.SelectedValue));
		}
		base.SelectSqlData(this.class107_1.tSchm_ObjList, true, string.Format("join tSchm_Relation as rel on tSchm_ObjList.IdParent = rel.id\r\nand rel.Edge = '{0}'\r\nwhere (tSchm_ObjList.idParentAddl is null or tSchm_ObjList.idParentAddl = rel.Edge) and tSchm_ObjList.Deleted = 0\r\nand tSchm_ObjList.TypeCodeId in ({1})", this.int_0, stringBuilder), null, true, 0);
		this.bindingSource_1.ResetBindings(false);
	}

	private void method_10()
	{
		if (this.method_0() != null)
		{
			if (this.method_0() == 1)
			{
				int activePassport = PassportData.GetActivePassport(this.SqlSettings, this.int_1);
				this.dataGridViewPassport_0.AddRowEditingParameter(this.SqlSettings, activePassport, DataGridViewPassport.CreateState.EditValue);
			}
			return;
		}
		if (this.comboBox_1.SelectedValue == null)
		{
			return;
		}
		int typeCodeId = (int)this.comboBox_1.SelectedValue;
		if (this.checkBox_0.Checked)
		{
			this.dataGridViewPassport_0.AddRowAddingParemeter(typeCodeId, this.SqlSettings);
			return;
		}
		if (this.comboBox_2.SelectedValue == null)
		{
			this.dataGridViewPassport_0.Rows.Clear();
			return;
		}
		int activePassport2 = PassportData.GetActivePassport(this.SqlSettings, Convert.ToInt32(this.comboBox_2.SelectedValue));
		if (activePassport2 == -1)
		{
			this.dataGridViewPassport_0.AddRowAddingParemeter(typeCodeId, this.SqlSettings);
			return;
		}
		this.dataGridViewPassport_0.AddRowEditingParameter(this.SqlSettings, activePassport2, DataGridViewPassport.CreateState.EditValue);
	}

	private void comboBox_3_SelectedValueChanged(object sender, EventArgs e)
	{
		if (this.comboBox_3.SelectedValue == null)
		{
			return;
		}
		this.int_2 = Convert.ToInt32(this.comboBox_3.SelectedValue);
	}

	private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.method_9();
		this.method_10();
		this.method_3();
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		this.bool_0 = !this.checkBox_0.Checked;
		if (this.method_0() == null)
		{
			if (!this.checkBox_0.Checked)
			{
				this.textBox_0.Text = string.Empty;
				if (this.comboBox_2.SelectedValue != null)
				{
					this.int_1 = Convert.ToInt32(this.comboBox_2.SelectedValue);
				}
			}
			else
			{
				this.int_1 = -1;
			}
		}
		this.method_5();
		this.method_10();
	}

	private void comboBox_2_SelectedValueChanged(object sender, EventArgs e)
	{
		if (this.comboBox_2.SelectedValue != null)
		{
			this.int_1 = Convert.ToInt32(this.comboBox_2.SelectedValue);
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private bool method_11()
	{
		if (!this.checkBox_0.Checked)
		{
			this.class107_0.tSchm_ObjList[0]["Name"] = this.comboBox_2.Text;
			return false;
		}
		this.class107_0.tSchm_ObjList[0]["Name"] = this.textBox_0.Text;
		return true;
	}

	protected override void OnClosing(CancelEventArgs cancelEventArgs_0)
	{
		base.OnClosing(cancelEventArgs_0);
		if (base.DialogResult == DialogResult.OK && !this.method_14())
		{
			base.DialogResult = DialogResult.None;
			cancelEventArgs_0.Cancel = true;
			if (this.string_0 != string.Empty)
			{
				MessageBox.Show(this.string_0);
			}
		}
	}

	private bool method_12()
	{
		bool result = true;
		if (this.comboBox_3.SelectedValue == null)
		{
			new ToolTip().Show("!", this.comboBox_3, 10, 5, 3000);
			result = false;
		}
		if (this.comboBox_1.SelectedValue == null)
		{
			new ToolTip().Show("!", this.comboBox_1, 10, 5, 3000);
			result = false;
		}
		return result;
	}

	private bool method_13()
	{
		string text = string.Empty;
		if (this.checkBox_0.Checked)
		{
			text = this.textBox_0.Text;
		}
		else
		{
			text = this.comboBox_2.Text;
		}
		if (text.Trim() == string.Empty)
		{
			new ToolTip().Show("!", this.tableLayoutPanel_0, 10, 5, 3000);
			return false;
		}
		string text2 = string.Format("WHERE name = '{0}' AND TypeCodeId = {1} AND idParentAddl = {2} AND Deleted = 0", text, this.comboBox_1.SelectedValue, this.comboBox_3.SelectedValue);
		if (this.int_1 != -1)
		{
			text2 += string.Format(" AND id <> {0}", this.int_1);
		}
		if (base.SelectSqlData("tSchm_ObjList", true, text2).Rows.Count > 0)
		{
			this.string_0 = "Наименование объекта не является уникальным";
			return false;
		}
		return true;
	}

	private bool method_14()
	{
		if (!this.method_12())
		{
			return false;
		}
		if (!this.method_13())
		{
			return false;
		}
		DateTime datePassport = DateTime.TryParse(this.dateTimePicker_0.Value.ToString(), out datePassport) ? this.dateTimePicker_0.Value : DateTime.Now;
		this.method_11();
		if (this.int_1 == -1)
		{
			this.bindingSource_0.EndEdit();
			this.int_1 = base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tSchm_ObjList);
			if (this.int_1 == -1)
			{
				return false;
			}
			this.dataGridViewPassport_0.SaveInsertedData(this.int_1, datePassport, 0);
			return true;
		}
		else
		{
			int activePassport;
			if (this.method_0() != null)
			{
				this.bindingSource_0.EndEdit();
				base.UpdateSqlData(this.class107_0, this.class107_0.tSchm_ObjList);
				activePassport = PassportData.GetActivePassport(this.SqlSettings, this.int_1);
				this.dataGridViewPassport_0.SaveUpdatedData(datePassport, activePassport);
				return true;
			}
			if (!new SqlDataCommand(this.SqlSettings).UpdateSqlData(new DataTable("tSchm_ObjList"), string.Format("set idParentAddl = '{0}'", this.int_2), string.Format("where id = '{0}'", this.int_1)))
			{
				return false;
			}
			activePassport = PassportData.GetActivePassport(this.SqlSettings, Convert.ToInt32(this.comboBox_2.SelectedValue));
			if (activePassport == -1)
			{
				this.dataGridViewPassport_0.SaveInsertedData(this.int_1, datePassport, 0);
			}
			else
			{
				this.dataGridViewPassport_0.SaveUpdatedData(datePassport, activePassport);
			}
			return true;
		}
	}

	private void dataGridViewPassport_0_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		e.CellStyle.BackColor = Color.White;
		if (e.Control is ComboBox && this.dataGridViewPassport_0.CurrentRow.Index == 1)
		{
			this.comboBox_0 = (ComboBox)e.Control;
			this.comboBox_0.SelectedIndexChanged -= this.oRemyVkfun0;
			this.comboBox_0.SelectedIndexChanged += this.oRemyVkfun0;
		}
	}

	private void oRemyVkfun0(object sender, EventArgs e)
	{
		if (this.dataGridViewPassport_0.CurrentRow.Index == 1 && this.checkBox_0.Checked)
		{
			this.textBox_0.Text = this.comboBox_0.GetItemText(this.comboBox_0.SelectedItem);
		}
	}

	private void dataGridViewPassport_0_DataError(object sender, DataGridViewDataErrorEventArgs e)
	{
	}

	protected override void Dispose(bool bool_1)
	{
		if (bool_1 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(bool_1);
	}

	private void method_15()
	{
		this.icontainer_0 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.textBox_0 = new TextBox();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.class107_0 = new Class107();
		this.class107_1 = new Class107();
		this.comboBox_1 = new ComboBox();
		this.dateTimePicker_0 = new DateTimePicker();
		this.label_0 = new Label();
		this.label_1 = new Label();
		this.label_2 = new Label();
		this.label_3 = new Label();
		this.comboBox_2 = new ComboBox();
		this.bindingSource_1 = new BindingSource(this.icontainer_0);
		this.comboBox_3 = new ComboBox();
		this.label_4 = new Label();
		this.tableLayoutPanel_0 = new TableLayoutPanel();
		this.checkBox_0 = new CheckBox();
		this.dataGridViewCheckBoxColumn_45 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_44 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_43 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_42 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_41 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_40 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_39 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_38 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_37 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_36 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_35 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_34 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_33 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_32 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_31 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_30 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_29 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_28 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_27 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_26 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_25 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_24 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_23 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_22 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_21 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_20 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_19 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_18 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_17 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_16 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_15 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_14 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_13 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_12 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_11 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_10 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_9 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_8 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_7 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_6 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_5 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_4 = new DataGridViewCheckBoxColumn();
		this.SyomIyEncdm = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_3 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_48 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_47 = new DataGridViewCheckBoxColumn();
		this.dataGridViewCheckBoxColumn_46 = new DataGridViewCheckBoxColumn();
		this.dataGridViewPassport_0 = new DataGridViewPassport();
		this.dataGridViewTextBoxColumn_262 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_263 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_264 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_52 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_265 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_266 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_257 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_258 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_259 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_51 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_260 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_261 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_252 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_253 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_254 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_50 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_255 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_256 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
		this.dataGridViewCheckBoxColumn_49 = new DataGridViewCheckBoxColumn();
		this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_247 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_248 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_249 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_250 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_251 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_242 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_243 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_244 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_245 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_246 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_237 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_238 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_239 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_240 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_241 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_232 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_233 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_234 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_235 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_236 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_227 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_228 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_229 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_230 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_231 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_222 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_223 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_224 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_225 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_226 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_217 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_218 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_219 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_220 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_221 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_212 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_213 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_214 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_215 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_216 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_207 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_208 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_209 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_210 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_211 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_202 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_203 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_204 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_205 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_206 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_197 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_198 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_199 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_200 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_201 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_192 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_193 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_194 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_195 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_196 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_187 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_188 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_189 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_190 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_191 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_182 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_183 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_184 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_185 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_186 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_177 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_178 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_179 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_180 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_181 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_172 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_173 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_174 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_175 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_176 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_167 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_168 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_169 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_170 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_171 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_162 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_163 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_164 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_165 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_166 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_157 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_158 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_159 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_160 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_161 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_153 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_154 = new DataGridViewTextBoxColumn();
		this.lwVmQasfwy9 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_155 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_156 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_148 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_149 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_150 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_151 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_152 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_143 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_144 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_145 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_146 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_147 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_138 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_139 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_140 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_141 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_142 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_133 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_134 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_135 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_136 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_137 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_128 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_129 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_130 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_131 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_132 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_123 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_124 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_125 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_126 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_127 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_118 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_119 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_120 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_121 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_122 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_113 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_114 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_115 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_116 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_117 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_108 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_109 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_110 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_111 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_112 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_103 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_104 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_105 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_106 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_107 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_98 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_99 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_100 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_101 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_102 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_93 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_94 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_95 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_96 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_97 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_88 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_89 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_90 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_91 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_92 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_83 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_84 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_85 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_86 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_87 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_78 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_79 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_80 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_81 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_82 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_73 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_74 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_75 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_76 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_77 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_68 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_69 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_70 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_71 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_72 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_63 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_64 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_65 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_66 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_67 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_58 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_59 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_60 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_61 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_62 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_53 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_54 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_55 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_56 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_57 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
		this.ehbmCnEqepn = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
		this.kxomIdiCwdi = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		((ISupportInitialize)this.class107_0).BeginInit();
		((ISupportInitialize)this.class107_1).BeginInit();
		((ISupportInitialize)this.bindingSource_1).BeginInit();
		this.tableLayoutPanel_0.SuspendLayout();
		((ISupportInitialize)this.dataGridViewPassport_0).BeginInit();
		base.SuspendLayout();
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_0.DialogResult = DialogResult.Cancel;
		this.button_0.Location = new Point(236, 401);
		this.button_0.Name = "bCancel";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 9;
		this.button_0.Text = "Отмена";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.button_1_Click;
		this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_1.DialogResult = DialogResult.OK;
		this.button_1.Location = new Point(155, 401);
		this.button_1.Name = "bOK";
		this.button_1.Size = new Size(75, 23);
		this.button_1.TabIndex = 9;
		this.button_1.Text = "OK";
		this.button_1.UseVisualStyleBackColor = true;
		this.button_1.Click += this.button_1_Click;
		this.textBox_0.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Name", true));
		this.textBox_0.Dock = DockStyle.Fill;
		this.textBox_0.Location = new Point(0, 0);
		this.textBox_0.Margin = new Padding(0);
		this.textBox_0.Name = "tbNameEquipment";
		this.textBox_0.Size = new Size(250, 20);
		this.textBox_0.TabIndex = 10;
		this.bindingSource_0.DataMember = "tSchm_ObjList";
		this.bindingSource_0.DataSource = this.class107_0;
		this.class107_0.DataSetName = "dsPassport";
		this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.class107_1.DataSetName = "dsPassport";
		this.class107_1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.comboBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "TypeCodeId", true));
		this.comboBox_1.DisplayMember = "Id";
		this.comboBox_1.FormattingEnabled = true;
		this.comboBox_1.Location = new Point(77, 39);
		this.comboBox_1.Name = "cbTypeEquipment";
		this.comboBox_1.Size = new Size(234, 21);
		this.comboBox_1.TabIndex = 11;
		this.comboBox_1.ValueMember = "Id";
		this.comboBox_1.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
		this.dateTimePicker_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.dateTimePicker_0.Location = new Point(61, 116);
		this.dateTimePicker_0.Name = "dtpDatePassport";
		this.dateTimePicker_0.Size = new Size(250, 20);
		this.dateTimePicker_0.TabIndex = 12;
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(9, 42);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(62, 13);
		this.label_0.TabIndex = 13;
		this.label_0.Text = "Тип обор-я";
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(9, 96);
		this.label_1.Name = "label2";
		this.label_1.Size = new Size(29, 13);
		this.label_1.TabIndex = 13;
		this.label_1.Text = "Имя";
		this.label_2.AutoSize = true;
		this.label_2.Location = new Point(9, 122);
		this.label_2.Name = "label3";
		this.label_2.Size = new Size(33, 13);
		this.label_2.TabIndex = 13;
		this.label_2.Text = "Дата";
		this.label_3.AutoSize = true;
		this.label_3.Location = new Point(12, 139);
		this.label_3.Name = "label4";
		this.label_3.Size = new Size(111, 13);
		this.label_3.TabIndex = 13;
		this.label_3.Text = "Паспортные данные";
		this.comboBox_2.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "Id", true));
		this.comboBox_2.DataSource = this.bindingSource_1;
		this.comboBox_2.DisplayMember = "Name";
		this.comboBox_2.Dock = DockStyle.Fill;
		this.comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
		this.comboBox_2.FormattingEnabled = true;
		this.comboBox_2.Location = new Point(0, 20);
		this.comboBox_2.Margin = new Padding(0);
		this.comboBox_2.Name = "cbNameEquipment";
		this.comboBox_2.Size = new Size(250, 21);
		this.comboBox_2.TabIndex = 14;
		this.comboBox_2.ValueMember = "Id";
		this.comboBox_2.SelectedValueChanged += this.comboBox_2_SelectedValueChanged;
		this.bindingSource_1.DataMember = "tSchm_ObjList";
		this.bindingSource_1.DataSource = this.class107_1;
		this.comboBox_3.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_3.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "idParentAddl", true));
		this.comboBox_3.FormattingEnabled = true;
		this.comboBox_3.Location = new Point(77, 12);
		this.comboBox_3.Name = "cbPylons";
		this.comboBox_3.Size = new Size(234, 21);
		this.comboBox_3.TabIndex = 11;
		this.comboBox_3.SelectedValueChanged += this.comboBox_3_SelectedValueChanged;
		this.label_4.AutoSize = true;
		this.label_4.Location = new Point(9, 15);
		this.label_4.Name = "label5";
		this.label_4.Size = new Size(39, 13);
		this.label_4.TabIndex = 13;
		this.label_4.Text = "Опора";
		this.tableLayoutPanel_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.tableLayoutPanel_0.ColumnCount = 1;
		this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		this.tableLayoutPanel_0.Controls.Add(this.textBox_0, 0, 0);
		this.tableLayoutPanel_0.Controls.Add(this.comboBox_2, 0, 1);
		this.tableLayoutPanel_0.Location = new Point(61, 89);
		this.tableLayoutPanel_0.Margin = new Padding(0);
		this.tableLayoutPanel_0.Name = "tlpNewObject";
		this.tableLayoutPanel_0.RowCount = 2;
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle());
		this.tableLayoutPanel_0.Size = new Size(250, 21);
		this.tableLayoutPanel_0.TabIndex = 16;
		this.checkBox_0.AutoSize = true;
		this.checkBox_0.Enabled = false;
		this.checkBox_0.Location = new Point(61, 69);
		this.checkBox_0.Name = "chbAddName";
		this.checkBox_0.Size = new Size(99, 17);
		this.checkBox_0.TabIndex = 17;
		this.checkBox_0.Text = "Добавить имя";
		this.checkBox_0.UseVisualStyleBackColor = true;
		this.checkBox_0.CheckedChanged += this.checkBox_0_CheckedChanged;
		this.dataGridViewCheckBoxColumn_45.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_45.Name = "dataGridViewCheckBoxColumn46";
		this.dataGridViewCheckBoxColumn_45.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_45.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_45.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_45.Visible = false;
		this.dataGridViewCheckBoxColumn_44.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_44.Name = "dataGridViewCheckBoxColumn45";
		this.dataGridViewCheckBoxColumn_44.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_44.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_44.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_44.Visible = false;
		this.dataGridViewCheckBoxColumn_43.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_43.Name = "dataGridViewCheckBoxColumn44";
		this.dataGridViewCheckBoxColumn_43.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_43.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_43.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_43.Visible = false;
		this.dataGridViewCheckBoxColumn_42.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_42.Name = "dataGridViewCheckBoxColumn43";
		this.dataGridViewCheckBoxColumn_42.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_42.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_42.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_42.Visible = false;
		this.dataGridViewCheckBoxColumn_41.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_41.Name = "dataGridViewCheckBoxColumn42";
		this.dataGridViewCheckBoxColumn_41.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_41.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_41.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_41.Visible = false;
		this.dataGridViewCheckBoxColumn_40.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_40.Name = "dataGridViewCheckBoxColumn41";
		this.dataGridViewCheckBoxColumn_40.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_40.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_40.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_40.Visible = false;
		this.dataGridViewCheckBoxColumn_39.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_39.Name = "dataGridViewCheckBoxColumn40";
		this.dataGridViewCheckBoxColumn_39.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_39.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_39.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_39.Visible = false;
		this.dataGridViewCheckBoxColumn_38.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_38.Name = "dataGridViewCheckBoxColumn39";
		this.dataGridViewCheckBoxColumn_38.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_38.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_38.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_38.Visible = false;
		this.dataGridViewCheckBoxColumn_37.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_37.Name = "dataGridViewCheckBoxColumn38";
		this.dataGridViewCheckBoxColumn_37.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_37.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_37.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_37.Visible = false;
		this.dataGridViewCheckBoxColumn_36.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_36.Name = "dataGridViewCheckBoxColumn37";
		this.dataGridViewCheckBoxColumn_36.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_36.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_36.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_36.Visible = false;
		this.dataGridViewCheckBoxColumn_35.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_35.Name = "dataGridViewCheckBoxColumn36";
		this.dataGridViewCheckBoxColumn_35.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_35.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_35.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_35.Visible = false;
		this.dataGridViewCheckBoxColumn_34.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_34.Name = "dataGridViewCheckBoxColumn35";
		this.dataGridViewCheckBoxColumn_34.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_34.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_34.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_34.Visible = false;
		this.dataGridViewCheckBoxColumn_33.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_33.Name = "dataGridViewCheckBoxColumn34";
		this.dataGridViewCheckBoxColumn_33.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_33.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_33.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_33.Visible = false;
		this.dataGridViewCheckBoxColumn_32.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_32.Name = "dataGridViewCheckBoxColumn33";
		this.dataGridViewCheckBoxColumn_32.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_32.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_32.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_32.Visible = false;
		this.dataGridViewCheckBoxColumn_31.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_31.Name = "dataGridViewCheckBoxColumn32";
		this.dataGridViewCheckBoxColumn_31.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_31.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_31.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_31.Visible = false;
		this.dataGridViewCheckBoxColumn_30.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_30.Name = "dataGridViewCheckBoxColumn31";
		this.dataGridViewCheckBoxColumn_30.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_30.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_30.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_30.Visible = false;
		this.dataGridViewCheckBoxColumn_29.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_29.Name = "dataGridViewCheckBoxColumn30";
		this.dataGridViewCheckBoxColumn_29.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_29.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_29.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_29.Visible = false;
		this.dataGridViewCheckBoxColumn_28.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_28.Name = "dataGridViewCheckBoxColumn29";
		this.dataGridViewCheckBoxColumn_28.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_28.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_28.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_28.Visible = false;
		this.dataGridViewCheckBoxColumn_27.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_27.Name = "dataGridViewCheckBoxColumn28";
		this.dataGridViewCheckBoxColumn_27.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_27.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_27.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_27.Visible = false;
		this.dataGridViewCheckBoxColumn_26.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_26.Name = "dataGridViewCheckBoxColumn27";
		this.dataGridViewCheckBoxColumn_26.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_26.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_26.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_26.Visible = false;
		this.dataGridViewCheckBoxColumn_25.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_25.Name = "dataGridViewCheckBoxColumn26";
		this.dataGridViewCheckBoxColumn_25.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_25.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_25.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_25.Visible = false;
		this.dataGridViewCheckBoxColumn_24.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_24.Name = "dataGridViewCheckBoxColumn25";
		this.dataGridViewCheckBoxColumn_24.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_24.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_24.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_24.Visible = false;
		this.dataGridViewCheckBoxColumn_23.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_23.Name = "dataGridViewCheckBoxColumn24";
		this.dataGridViewCheckBoxColumn_23.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_23.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_23.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_23.Visible = false;
		this.dataGridViewCheckBoxColumn_22.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_22.Name = "dataGridViewCheckBoxColumn23";
		this.dataGridViewCheckBoxColumn_22.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_22.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_22.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_22.Visible = false;
		this.dataGridViewCheckBoxColumn_21.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_21.Name = "dataGridViewCheckBoxColumn22";
		this.dataGridViewCheckBoxColumn_21.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_21.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_21.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_21.Visible = false;
		this.dataGridViewCheckBoxColumn_20.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_20.Name = "dataGridViewCheckBoxColumn21";
		this.dataGridViewCheckBoxColumn_20.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_20.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_20.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_20.Visible = false;
		this.dataGridViewCheckBoxColumn_19.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_19.Name = "dataGridViewCheckBoxColumn20";
		this.dataGridViewCheckBoxColumn_19.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_19.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_19.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_19.Visible = false;
		this.dataGridViewCheckBoxColumn_18.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_18.Name = "dataGridViewCheckBoxColumn19";
		this.dataGridViewCheckBoxColumn_18.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_18.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_18.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_18.Visible = false;
		this.dataGridViewCheckBoxColumn_17.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_17.Name = "dataGridViewCheckBoxColumn18";
		this.dataGridViewCheckBoxColumn_17.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_17.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_17.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_17.Visible = false;
		this.dataGridViewCheckBoxColumn_16.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_16.Name = "dataGridViewCheckBoxColumn17";
		this.dataGridViewCheckBoxColumn_16.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_16.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_16.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_16.Visible = false;
		this.dataGridViewCheckBoxColumn_15.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_15.Name = "dataGridViewCheckBoxColumn16";
		this.dataGridViewCheckBoxColumn_15.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_15.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_15.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_15.Visible = false;
		this.dataGridViewCheckBoxColumn_14.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_14.Name = "dataGridViewCheckBoxColumn15";
		this.dataGridViewCheckBoxColumn_14.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_14.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_14.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_14.Visible = false;
		this.dataGridViewCheckBoxColumn_13.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_13.Name = "dataGridViewCheckBoxColumn14";
		this.dataGridViewCheckBoxColumn_13.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_13.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_13.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_13.Visible = false;
		this.dataGridViewCheckBoxColumn_12.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_12.Name = "dataGridViewCheckBoxColumn13";
		this.dataGridViewCheckBoxColumn_12.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_12.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_12.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_12.Visible = false;
		this.dataGridViewCheckBoxColumn_11.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_11.Name = "dataGridViewCheckBoxColumn12";
		this.dataGridViewCheckBoxColumn_11.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_11.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_11.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_11.Visible = false;
		this.dataGridViewCheckBoxColumn_10.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_10.Name = "dataGridViewCheckBoxColumn11";
		this.dataGridViewCheckBoxColumn_10.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_10.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_10.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_10.Visible = false;
		this.dataGridViewCheckBoxColumn_9.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_9.Name = "dataGridViewCheckBoxColumn10";
		this.dataGridViewCheckBoxColumn_9.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_9.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_9.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_9.Visible = false;
		this.dataGridViewCheckBoxColumn_8.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_8.Name = "dataGridViewCheckBoxColumn9";
		this.dataGridViewCheckBoxColumn_8.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_8.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_8.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_8.Visible = false;
		this.dataGridViewCheckBoxColumn_7.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_7.Name = "dataGridViewCheckBoxColumn8";
		this.dataGridViewCheckBoxColumn_7.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_7.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_7.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_7.Visible = false;
		this.dataGridViewCheckBoxColumn_6.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_6.Name = "dataGridViewCheckBoxColumn7";
		this.dataGridViewCheckBoxColumn_6.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_6.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_6.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_6.Visible = false;
		this.dataGridViewCheckBoxColumn_5.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_5.Name = "dataGridViewCheckBoxColumn6";
		this.dataGridViewCheckBoxColumn_5.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_5.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_5.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_5.Visible = false;
		this.dataGridViewCheckBoxColumn_4.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_4.Name = "dataGridViewCheckBoxColumn5";
		this.dataGridViewCheckBoxColumn_4.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_4.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_4.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_4.Visible = false;
		this.SyomIyEncdm.HeaderText = "isGroupChar";
		this.SyomIyEncdm.Name = "dataGridViewCheckBoxColumn4";
		this.SyomIyEncdm.ReadOnly = true;
		this.SyomIyEncdm.Resizable = DataGridViewTriState.True;
		this.SyomIyEncdm.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.SyomIyEncdm.Visible = false;
		this.dataGridViewCheckBoxColumn_3.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_3.Name = "dataGridViewCheckBoxColumn3";
		this.dataGridViewCheckBoxColumn_3.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_3.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_3.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_3.Visible = false;
		this.dataGridViewCheckBoxColumn_2.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_2.Name = "dataGridViewCheckBoxColumn2";
		this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_2.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_2.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_2.Visible = false;
		this.dataGridViewCheckBoxColumn_1.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_1.Name = "dataGridViewCheckBoxColumn1";
		this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_1.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_1.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_1.Visible = false;
		this.dataGridViewCheckBoxColumn_0.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_0.Name = "dataGridViewCheckBoxColumn122";
		this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_0.Visible = false;
		this.dataGridViewCheckBoxColumn_48.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_48.Name = "dataGridViewCheckBoxColumn49";
		this.dataGridViewCheckBoxColumn_48.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_48.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_48.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_48.Visible = false;
		this.dataGridViewCheckBoxColumn_47.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_47.Name = "dataGridViewCheckBoxColumn48";
		this.dataGridViewCheckBoxColumn_47.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_47.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_47.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_47.Visible = false;
		this.dataGridViewCheckBoxColumn_46.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_46.Name = "dataGridViewCheckBoxColumn47";
		this.dataGridViewCheckBoxColumn_46.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_46.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_46.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_46.Visible = false;
		this.dataGridViewPassport_0.AllowUserToAddRows = false;
		this.dataGridViewPassport_0.AllowUserToDeleteRows = false;
		this.dataGridViewPassport_0.AllowUserToResizeColumns = false;
		this.dataGridViewPassport_0.AllowUserToResizeRows = false;
		this.dataGridViewPassport_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.dataGridViewPassport_0.BackgroundColor = Color.White;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		this.dataGridViewPassport_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dataGridViewPassport_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = Color.White;
		dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = Color.White;
		dataGridViewCellStyle2.SelectionForeColor = Color.Blue;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
		this.dataGridViewPassport_0.DefaultCellStyle = dataGridViewCellStyle2;
		this.dataGridViewPassport_0.DragDropComplite = false;
		this.dataGridViewPassport_0.EditMode = DataGridViewEditMode.EditOnEnter;
		this.dataGridViewPassport_0.Location = new Point(12, 155);
		this.dataGridViewPassport_0.MultiSelect = false;
		this.dataGridViewPassport_0.Name = "DataGridViewPassport1";
		this.dataGridViewPassport_0.RowHeadersVisible = false;
		this.dataGridViewPassport_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewPassport_0.Size = new Size(299, 233);
		this.dataGridViewPassport_0.TabIndex = 8;
		this.dataGridViewPassport_0.EditingControlShowing += this.dataGridViewPassport_0_EditingControlShowing;
		this.dataGridViewTextBoxColumn_262.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_262.Name = "dataGridViewTextBoxColumn261";
		this.dataGridViewTextBoxColumn_262.ReadOnly = true;
		this.dataGridViewTextBoxColumn_262.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_262.Visible = false;
		this.dataGridViewTextBoxColumn_263.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_263.Name = "dataGridViewTextBoxColumn262";
		this.dataGridViewTextBoxColumn_263.ReadOnly = true;
		this.dataGridViewTextBoxColumn_263.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_263.Visible = false;
		this.dataGridViewTextBoxColumn_264.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_264.Name = "dataGridViewTextBoxColumn263";
		this.dataGridViewTextBoxColumn_264.ReadOnly = true;
		this.dataGridViewTextBoxColumn_264.Visible = false;
		this.dataGridViewCheckBoxColumn_52.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_52.Name = "dataGridViewCheckBoxColumn53";
		this.dataGridViewCheckBoxColumn_52.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_52.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_52.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_52.Visible = false;
		this.dataGridViewTextBoxColumn_265.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_265.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_265.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_265.Name = "dataGridViewTextBoxColumn264";
		this.dataGridViewTextBoxColumn_265.ReadOnly = true;
		this.dataGridViewTextBoxColumn_265.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_265.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_265.Width = 5;
		this.dataGridViewTextBoxColumn_266.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_266.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_266.Name = "dataGridViewTextBoxColumn265";
		this.dataGridViewTextBoxColumn_266.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_266.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_257.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_257.Name = "dataGridViewTextBoxColumn256";
		this.dataGridViewTextBoxColumn_257.ReadOnly = true;
		this.dataGridViewTextBoxColumn_257.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_257.Visible = false;
		this.dataGridViewTextBoxColumn_258.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_258.Name = "dataGridViewTextBoxColumn257";
		this.dataGridViewTextBoxColumn_258.ReadOnly = true;
		this.dataGridViewTextBoxColumn_258.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_258.Visible = false;
		this.dataGridViewTextBoxColumn_259.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_259.Name = "dataGridViewTextBoxColumn258";
		this.dataGridViewTextBoxColumn_259.ReadOnly = true;
		this.dataGridViewTextBoxColumn_259.Visible = false;
		this.dataGridViewCheckBoxColumn_51.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_51.Name = "dataGridViewCheckBoxColumn52";
		this.dataGridViewCheckBoxColumn_51.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_51.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_51.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_51.Visible = false;
		this.dataGridViewTextBoxColumn_260.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_260.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_260.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_260.Name = "dataGridViewTextBoxColumn259";
		this.dataGridViewTextBoxColumn_260.ReadOnly = true;
		this.dataGridViewTextBoxColumn_260.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_260.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_261.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_261.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_261.Name = "dataGridViewTextBoxColumn260";
		this.dataGridViewTextBoxColumn_261.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_261.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_252.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_252.Name = "dataGridViewTextBoxColumn251";
		this.dataGridViewTextBoxColumn_252.ReadOnly = true;
		this.dataGridViewTextBoxColumn_252.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_252.Visible = false;
		this.dataGridViewTextBoxColumn_253.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_253.Name = "dataGridViewTextBoxColumn252";
		this.dataGridViewTextBoxColumn_253.ReadOnly = true;
		this.dataGridViewTextBoxColumn_253.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_253.Visible = false;
		this.dataGridViewTextBoxColumn_254.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_254.Name = "dataGridViewTextBoxColumn253";
		this.dataGridViewTextBoxColumn_254.ReadOnly = true;
		this.dataGridViewTextBoxColumn_254.Visible = false;
		this.dataGridViewCheckBoxColumn_50.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_50.Name = "dataGridViewCheckBoxColumn51";
		this.dataGridViewCheckBoxColumn_50.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_50.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_50.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_50.Visible = false;
		this.dataGridViewTextBoxColumn_255.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_255.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_255.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_255.Name = "dataGridViewTextBoxColumn254";
		this.dataGridViewTextBoxColumn_255.ReadOnly = true;
		this.dataGridViewTextBoxColumn_255.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_255.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_256.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_256.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_256.Name = "dataGridViewTextBoxColumn255";
		this.dataGridViewTextBoxColumn_256.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_256.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_5.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_5.ReadOnly = true;
		this.dataGridViewTextBoxColumn_5.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_5.Visible = false;
		this.dataGridViewTextBoxColumn_6.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn2";
		this.dataGridViewTextBoxColumn_6.ReadOnly = true;
		this.dataGridViewTextBoxColumn_6.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_6.Visible = false;
		this.dataGridViewTextBoxColumn_7.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn3";
		this.dataGridViewTextBoxColumn_7.ReadOnly = true;
		this.dataGridViewTextBoxColumn_7.Visible = false;
		this.dataGridViewCheckBoxColumn_49.HeaderText = "isGroupChar";
		this.dataGridViewCheckBoxColumn_49.Name = "dataGridViewCheckBoxColumn50";
		this.dataGridViewCheckBoxColumn_49.ReadOnly = true;
		this.dataGridViewCheckBoxColumn_49.Resizable = DataGridViewTriState.True;
		this.dataGridViewCheckBoxColumn_49.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewCheckBoxColumn_49.Visible = false;
		this.dataGridViewTextBoxColumn_8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_8.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_8.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn4";
		this.dataGridViewTextBoxColumn_8.ReadOnly = true;
		this.dataGridViewTextBoxColumn_8.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_8.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_9.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn5";
		this.dataGridViewTextBoxColumn_9.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_9.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_247.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_247.Name = "dataGridViewTextBoxColumn246";
		this.dataGridViewTextBoxColumn_247.ReadOnly = true;
		this.dataGridViewTextBoxColumn_247.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_247.Visible = false;
		this.dataGridViewTextBoxColumn_248.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_248.Name = "dataGridViewTextBoxColumn247";
		this.dataGridViewTextBoxColumn_248.ReadOnly = true;
		this.dataGridViewTextBoxColumn_248.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_248.Visible = false;
		this.dataGridViewTextBoxColumn_249.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_249.Name = "dataGridViewTextBoxColumn248";
		this.dataGridViewTextBoxColumn_249.ReadOnly = true;
		this.dataGridViewTextBoxColumn_249.Visible = false;
		this.dataGridViewTextBoxColumn_250.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_250.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_250.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_250.Name = "dataGridViewTextBoxColumn249";
		this.dataGridViewTextBoxColumn_250.ReadOnly = true;
		this.dataGridViewTextBoxColumn_250.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_250.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_251.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_251.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_251.Name = "dataGridViewTextBoxColumn250";
		this.dataGridViewTextBoxColumn_251.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_251.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_242.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_242.Name = "dataGridViewTextBoxColumn241";
		this.dataGridViewTextBoxColumn_242.ReadOnly = true;
		this.dataGridViewTextBoxColumn_242.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_242.Visible = false;
		this.dataGridViewTextBoxColumn_243.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_243.Name = "dataGridViewTextBoxColumn242";
		this.dataGridViewTextBoxColumn_243.ReadOnly = true;
		this.dataGridViewTextBoxColumn_243.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_243.Visible = false;
		this.dataGridViewTextBoxColumn_244.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_244.Name = "dataGridViewTextBoxColumn243";
		this.dataGridViewTextBoxColumn_244.ReadOnly = true;
		this.dataGridViewTextBoxColumn_244.Visible = false;
		this.dataGridViewTextBoxColumn_245.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_245.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_245.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_245.Name = "dataGridViewTextBoxColumn244";
		this.dataGridViewTextBoxColumn_245.ReadOnly = true;
		this.dataGridViewTextBoxColumn_245.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_245.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_246.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_246.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_246.Name = "dataGridViewTextBoxColumn245";
		this.dataGridViewTextBoxColumn_246.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_246.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_237.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_237.Name = "dataGridViewTextBoxColumn236";
		this.dataGridViewTextBoxColumn_237.ReadOnly = true;
		this.dataGridViewTextBoxColumn_237.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_237.Visible = false;
		this.dataGridViewTextBoxColumn_238.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_238.Name = "dataGridViewTextBoxColumn237";
		this.dataGridViewTextBoxColumn_238.ReadOnly = true;
		this.dataGridViewTextBoxColumn_238.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_238.Visible = false;
		this.dataGridViewTextBoxColumn_239.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_239.Name = "dataGridViewTextBoxColumn238";
		this.dataGridViewTextBoxColumn_239.ReadOnly = true;
		this.dataGridViewTextBoxColumn_239.Visible = false;
		this.dataGridViewTextBoxColumn_240.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_240.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_240.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_240.Name = "dataGridViewTextBoxColumn239";
		this.dataGridViewTextBoxColumn_240.ReadOnly = true;
		this.dataGridViewTextBoxColumn_240.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_240.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_241.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_241.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_241.Name = "dataGridViewTextBoxColumn240";
		this.dataGridViewTextBoxColumn_241.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_241.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_232.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_232.Name = "dataGridViewTextBoxColumn231";
		this.dataGridViewTextBoxColumn_232.ReadOnly = true;
		this.dataGridViewTextBoxColumn_232.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_232.Visible = false;
		this.dataGridViewTextBoxColumn_233.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_233.Name = "dataGridViewTextBoxColumn232";
		this.dataGridViewTextBoxColumn_233.ReadOnly = true;
		this.dataGridViewTextBoxColumn_233.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_233.Visible = false;
		this.dataGridViewTextBoxColumn_234.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_234.Name = "dataGridViewTextBoxColumn233";
		this.dataGridViewTextBoxColumn_234.ReadOnly = true;
		this.dataGridViewTextBoxColumn_234.Visible = false;
		this.dataGridViewTextBoxColumn_235.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_235.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_235.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_235.Name = "dataGridViewTextBoxColumn234";
		this.dataGridViewTextBoxColumn_235.ReadOnly = true;
		this.dataGridViewTextBoxColumn_235.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_235.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_236.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_236.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_236.Name = "dataGridViewTextBoxColumn235";
		this.dataGridViewTextBoxColumn_236.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_236.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_227.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_227.Name = "dataGridViewTextBoxColumn226";
		this.dataGridViewTextBoxColumn_227.ReadOnly = true;
		this.dataGridViewTextBoxColumn_227.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_227.Visible = false;
		this.dataGridViewTextBoxColumn_228.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_228.Name = "dataGridViewTextBoxColumn227";
		this.dataGridViewTextBoxColumn_228.ReadOnly = true;
		this.dataGridViewTextBoxColumn_228.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_228.Visible = false;
		this.dataGridViewTextBoxColumn_229.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_229.Name = "dataGridViewTextBoxColumn228";
		this.dataGridViewTextBoxColumn_229.ReadOnly = true;
		this.dataGridViewTextBoxColumn_229.Visible = false;
		this.dataGridViewTextBoxColumn_230.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_230.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_230.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_230.Name = "dataGridViewTextBoxColumn229";
		this.dataGridViewTextBoxColumn_230.ReadOnly = true;
		this.dataGridViewTextBoxColumn_230.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_230.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_231.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_231.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_231.Name = "dataGridViewTextBoxColumn230";
		this.dataGridViewTextBoxColumn_231.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_231.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_222.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_222.Name = "dataGridViewTextBoxColumn221";
		this.dataGridViewTextBoxColumn_222.ReadOnly = true;
		this.dataGridViewTextBoxColumn_222.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_222.Visible = false;
		this.dataGridViewTextBoxColumn_223.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_223.Name = "dataGridViewTextBoxColumn222";
		this.dataGridViewTextBoxColumn_223.ReadOnly = true;
		this.dataGridViewTextBoxColumn_223.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_223.Visible = false;
		this.dataGridViewTextBoxColumn_224.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_224.Name = "dataGridViewTextBoxColumn223";
		this.dataGridViewTextBoxColumn_224.ReadOnly = true;
		this.dataGridViewTextBoxColumn_224.Visible = false;
		this.dataGridViewTextBoxColumn_225.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_225.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_225.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_225.Name = "dataGridViewTextBoxColumn224";
		this.dataGridViewTextBoxColumn_225.ReadOnly = true;
		this.dataGridViewTextBoxColumn_225.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_225.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_226.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_226.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_226.Name = "dataGridViewTextBoxColumn225";
		this.dataGridViewTextBoxColumn_226.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_226.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_217.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_217.Name = "dataGridViewTextBoxColumn216";
		this.dataGridViewTextBoxColumn_217.ReadOnly = true;
		this.dataGridViewTextBoxColumn_217.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_217.Visible = false;
		this.dataGridViewTextBoxColumn_218.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_218.Name = "dataGridViewTextBoxColumn217";
		this.dataGridViewTextBoxColumn_218.ReadOnly = true;
		this.dataGridViewTextBoxColumn_218.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_218.Visible = false;
		this.dataGridViewTextBoxColumn_219.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_219.Name = "dataGridViewTextBoxColumn218";
		this.dataGridViewTextBoxColumn_219.ReadOnly = true;
		this.dataGridViewTextBoxColumn_219.Visible = false;
		this.dataGridViewTextBoxColumn_220.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_220.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_220.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_220.Name = "dataGridViewTextBoxColumn219";
		this.dataGridViewTextBoxColumn_220.ReadOnly = true;
		this.dataGridViewTextBoxColumn_220.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_220.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_221.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_221.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_221.Name = "dataGridViewTextBoxColumn220";
		this.dataGridViewTextBoxColumn_221.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_221.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_212.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_212.Name = "dataGridViewTextBoxColumn211";
		this.dataGridViewTextBoxColumn_212.ReadOnly = true;
		this.dataGridViewTextBoxColumn_212.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_212.Visible = false;
		this.dataGridViewTextBoxColumn_213.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_213.Name = "dataGridViewTextBoxColumn212";
		this.dataGridViewTextBoxColumn_213.ReadOnly = true;
		this.dataGridViewTextBoxColumn_213.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_213.Visible = false;
		this.dataGridViewTextBoxColumn_214.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_214.Name = "dataGridViewTextBoxColumn213";
		this.dataGridViewTextBoxColumn_214.ReadOnly = true;
		this.dataGridViewTextBoxColumn_214.Visible = false;
		this.dataGridViewTextBoxColumn_215.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_215.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_215.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_215.Name = "dataGridViewTextBoxColumn214";
		this.dataGridViewTextBoxColumn_215.ReadOnly = true;
		this.dataGridViewTextBoxColumn_215.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_215.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_216.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_216.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_216.Name = "dataGridViewTextBoxColumn215";
		this.dataGridViewTextBoxColumn_216.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_216.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_207.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_207.Name = "dataGridViewTextBoxColumn206";
		this.dataGridViewTextBoxColumn_207.ReadOnly = true;
		this.dataGridViewTextBoxColumn_207.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_207.Visible = false;
		this.dataGridViewTextBoxColumn_208.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_208.Name = "dataGridViewTextBoxColumn207";
		this.dataGridViewTextBoxColumn_208.ReadOnly = true;
		this.dataGridViewTextBoxColumn_208.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_208.Visible = false;
		this.dataGridViewTextBoxColumn_209.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_209.Name = "dataGridViewTextBoxColumn208";
		this.dataGridViewTextBoxColumn_209.ReadOnly = true;
		this.dataGridViewTextBoxColumn_209.Visible = false;
		this.dataGridViewTextBoxColumn_210.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_210.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_210.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_210.Name = "dataGridViewTextBoxColumn209";
		this.dataGridViewTextBoxColumn_210.ReadOnly = true;
		this.dataGridViewTextBoxColumn_210.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_210.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_211.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_211.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_211.Name = "dataGridViewTextBoxColumn210";
		this.dataGridViewTextBoxColumn_211.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_211.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_202.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_202.Name = "dataGridViewTextBoxColumn201";
		this.dataGridViewTextBoxColumn_202.ReadOnly = true;
		this.dataGridViewTextBoxColumn_202.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_202.Visible = false;
		this.dataGridViewTextBoxColumn_203.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_203.Name = "dataGridViewTextBoxColumn202";
		this.dataGridViewTextBoxColumn_203.ReadOnly = true;
		this.dataGridViewTextBoxColumn_203.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_203.Visible = false;
		this.dataGridViewTextBoxColumn_204.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_204.Name = "dataGridViewTextBoxColumn203";
		this.dataGridViewTextBoxColumn_204.ReadOnly = true;
		this.dataGridViewTextBoxColumn_204.Visible = false;
		this.dataGridViewTextBoxColumn_205.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_205.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_205.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_205.Name = "dataGridViewTextBoxColumn204";
		this.dataGridViewTextBoxColumn_205.ReadOnly = true;
		this.dataGridViewTextBoxColumn_205.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_205.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_206.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_206.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_206.Name = "dataGridViewTextBoxColumn205";
		this.dataGridViewTextBoxColumn_206.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_206.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_197.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_197.Name = "dataGridViewTextBoxColumn196";
		this.dataGridViewTextBoxColumn_197.ReadOnly = true;
		this.dataGridViewTextBoxColumn_197.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_197.Visible = false;
		this.dataGridViewTextBoxColumn_198.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_198.Name = "dataGridViewTextBoxColumn197";
		this.dataGridViewTextBoxColumn_198.ReadOnly = true;
		this.dataGridViewTextBoxColumn_198.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_198.Visible = false;
		this.dataGridViewTextBoxColumn_199.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_199.Name = "dataGridViewTextBoxColumn198";
		this.dataGridViewTextBoxColumn_199.ReadOnly = true;
		this.dataGridViewTextBoxColumn_199.Visible = false;
		this.dataGridViewTextBoxColumn_200.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_200.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_200.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_200.Name = "dataGridViewTextBoxColumn199";
		this.dataGridViewTextBoxColumn_200.ReadOnly = true;
		this.dataGridViewTextBoxColumn_200.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_200.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_201.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_201.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_201.Name = "dataGridViewTextBoxColumn200";
		this.dataGridViewTextBoxColumn_201.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_201.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_192.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_192.Name = "dataGridViewTextBoxColumn191";
		this.dataGridViewTextBoxColumn_192.ReadOnly = true;
		this.dataGridViewTextBoxColumn_192.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_192.Visible = false;
		this.dataGridViewTextBoxColumn_193.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_193.Name = "dataGridViewTextBoxColumn192";
		this.dataGridViewTextBoxColumn_193.ReadOnly = true;
		this.dataGridViewTextBoxColumn_193.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_193.Visible = false;
		this.dataGridViewTextBoxColumn_194.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_194.Name = "dataGridViewTextBoxColumn193";
		this.dataGridViewTextBoxColumn_194.ReadOnly = true;
		this.dataGridViewTextBoxColumn_194.Visible = false;
		this.dataGridViewTextBoxColumn_195.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_195.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_195.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_195.Name = "dataGridViewTextBoxColumn194";
		this.dataGridViewTextBoxColumn_195.ReadOnly = true;
		this.dataGridViewTextBoxColumn_195.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_195.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_196.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_196.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_196.Name = "dataGridViewTextBoxColumn195";
		this.dataGridViewTextBoxColumn_196.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_196.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_187.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_187.Name = "dataGridViewTextBoxColumn186";
		this.dataGridViewTextBoxColumn_187.ReadOnly = true;
		this.dataGridViewTextBoxColumn_187.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_187.Visible = false;
		this.dataGridViewTextBoxColumn_188.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_188.Name = "dataGridViewTextBoxColumn187";
		this.dataGridViewTextBoxColumn_188.ReadOnly = true;
		this.dataGridViewTextBoxColumn_188.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_188.Visible = false;
		this.dataGridViewTextBoxColumn_189.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_189.Name = "dataGridViewTextBoxColumn188";
		this.dataGridViewTextBoxColumn_189.ReadOnly = true;
		this.dataGridViewTextBoxColumn_189.Visible = false;
		this.dataGridViewTextBoxColumn_190.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_190.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_190.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_190.Name = "dataGridViewTextBoxColumn189";
		this.dataGridViewTextBoxColumn_190.ReadOnly = true;
		this.dataGridViewTextBoxColumn_190.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_190.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_191.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_191.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_191.Name = "dataGridViewTextBoxColumn190";
		this.dataGridViewTextBoxColumn_191.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_191.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_182.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_182.Name = "dataGridViewTextBoxColumn181";
		this.dataGridViewTextBoxColumn_182.ReadOnly = true;
		this.dataGridViewTextBoxColumn_182.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_182.Visible = false;
		this.dataGridViewTextBoxColumn_183.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_183.Name = "dataGridViewTextBoxColumn182";
		this.dataGridViewTextBoxColumn_183.ReadOnly = true;
		this.dataGridViewTextBoxColumn_183.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_183.Visible = false;
		this.dataGridViewTextBoxColumn_184.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_184.Name = "dataGridViewTextBoxColumn183";
		this.dataGridViewTextBoxColumn_184.ReadOnly = true;
		this.dataGridViewTextBoxColumn_184.Visible = false;
		this.dataGridViewTextBoxColumn_185.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_185.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_185.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_185.Name = "dataGridViewTextBoxColumn184";
		this.dataGridViewTextBoxColumn_185.ReadOnly = true;
		this.dataGridViewTextBoxColumn_185.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_185.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_186.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_186.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_186.Name = "dataGridViewTextBoxColumn185";
		this.dataGridViewTextBoxColumn_186.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_186.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_177.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_177.Name = "dataGridViewTextBoxColumn176";
		this.dataGridViewTextBoxColumn_177.ReadOnly = true;
		this.dataGridViewTextBoxColumn_177.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_177.Visible = false;
		this.dataGridViewTextBoxColumn_178.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_178.Name = "dataGridViewTextBoxColumn177";
		this.dataGridViewTextBoxColumn_178.ReadOnly = true;
		this.dataGridViewTextBoxColumn_178.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_178.Visible = false;
		this.dataGridViewTextBoxColumn_179.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_179.Name = "dataGridViewTextBoxColumn178";
		this.dataGridViewTextBoxColumn_179.ReadOnly = true;
		this.dataGridViewTextBoxColumn_179.Visible = false;
		this.dataGridViewTextBoxColumn_180.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_180.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_180.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_180.Name = "dataGridViewTextBoxColumn179";
		this.dataGridViewTextBoxColumn_180.ReadOnly = true;
		this.dataGridViewTextBoxColumn_180.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_180.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_181.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_181.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_181.Name = "dataGridViewTextBoxColumn180";
		this.dataGridViewTextBoxColumn_181.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_181.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_172.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_172.Name = "dataGridViewTextBoxColumn171";
		this.dataGridViewTextBoxColumn_172.ReadOnly = true;
		this.dataGridViewTextBoxColumn_172.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_172.Visible = false;
		this.dataGridViewTextBoxColumn_173.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_173.Name = "dataGridViewTextBoxColumn172";
		this.dataGridViewTextBoxColumn_173.ReadOnly = true;
		this.dataGridViewTextBoxColumn_173.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_173.Visible = false;
		this.dataGridViewTextBoxColumn_174.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_174.Name = "dataGridViewTextBoxColumn173";
		this.dataGridViewTextBoxColumn_174.ReadOnly = true;
		this.dataGridViewTextBoxColumn_174.Visible = false;
		this.dataGridViewTextBoxColumn_175.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_175.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_175.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_175.Name = "dataGridViewTextBoxColumn174";
		this.dataGridViewTextBoxColumn_175.ReadOnly = true;
		this.dataGridViewTextBoxColumn_175.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_175.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_176.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_176.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_176.Name = "dataGridViewTextBoxColumn175";
		this.dataGridViewTextBoxColumn_176.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_176.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_167.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_167.Name = "dataGridViewTextBoxColumn166";
		this.dataGridViewTextBoxColumn_167.ReadOnly = true;
		this.dataGridViewTextBoxColumn_167.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_167.Visible = false;
		this.dataGridViewTextBoxColumn_168.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_168.Name = "dataGridViewTextBoxColumn167";
		this.dataGridViewTextBoxColumn_168.ReadOnly = true;
		this.dataGridViewTextBoxColumn_168.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_168.Visible = false;
		this.dataGridViewTextBoxColumn_169.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_169.Name = "dataGridViewTextBoxColumn168";
		this.dataGridViewTextBoxColumn_169.ReadOnly = true;
		this.dataGridViewTextBoxColumn_169.Visible = false;
		this.dataGridViewTextBoxColumn_170.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_170.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_170.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_170.Name = "dataGridViewTextBoxColumn169";
		this.dataGridViewTextBoxColumn_170.ReadOnly = true;
		this.dataGridViewTextBoxColumn_170.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_170.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_171.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_171.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_171.Name = "dataGridViewTextBoxColumn170";
		this.dataGridViewTextBoxColumn_171.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_171.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_162.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_162.Name = "dataGridViewTextBoxColumn161";
		this.dataGridViewTextBoxColumn_162.ReadOnly = true;
		this.dataGridViewTextBoxColumn_162.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_162.Visible = false;
		this.dataGridViewTextBoxColumn_163.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_163.Name = "dataGridViewTextBoxColumn162";
		this.dataGridViewTextBoxColumn_163.ReadOnly = true;
		this.dataGridViewTextBoxColumn_163.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_163.Visible = false;
		this.dataGridViewTextBoxColumn_164.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_164.Name = "dataGridViewTextBoxColumn163";
		this.dataGridViewTextBoxColumn_164.ReadOnly = true;
		this.dataGridViewTextBoxColumn_164.Visible = false;
		this.dataGridViewTextBoxColumn_165.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_165.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_165.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_165.Name = "dataGridViewTextBoxColumn164";
		this.dataGridViewTextBoxColumn_165.ReadOnly = true;
		this.dataGridViewTextBoxColumn_165.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_165.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_166.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_166.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_166.Name = "dataGridViewTextBoxColumn165";
		this.dataGridViewTextBoxColumn_166.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_166.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_157.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_157.Name = "dataGridViewTextBoxColumn156";
		this.dataGridViewTextBoxColumn_157.ReadOnly = true;
		this.dataGridViewTextBoxColumn_157.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_157.Visible = false;
		this.dataGridViewTextBoxColumn_158.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_158.Name = "dataGridViewTextBoxColumn157";
		this.dataGridViewTextBoxColumn_158.ReadOnly = true;
		this.dataGridViewTextBoxColumn_158.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_158.Visible = false;
		this.dataGridViewTextBoxColumn_159.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_159.Name = "dataGridViewTextBoxColumn158";
		this.dataGridViewTextBoxColumn_159.ReadOnly = true;
		this.dataGridViewTextBoxColumn_159.Visible = false;
		this.dataGridViewTextBoxColumn_160.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_160.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_160.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_160.Name = "dataGridViewTextBoxColumn159";
		this.dataGridViewTextBoxColumn_160.ReadOnly = true;
		this.dataGridViewTextBoxColumn_160.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_160.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_161.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_161.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_161.Name = "dataGridViewTextBoxColumn160";
		this.dataGridViewTextBoxColumn_161.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_161.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_153.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_153.Name = "dataGridViewTextBoxColumn151";
		this.dataGridViewTextBoxColumn_153.ReadOnly = true;
		this.dataGridViewTextBoxColumn_153.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_153.Visible = false;
		this.dataGridViewTextBoxColumn_154.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_154.Name = "dataGridViewTextBoxColumn152";
		this.dataGridViewTextBoxColumn_154.ReadOnly = true;
		this.dataGridViewTextBoxColumn_154.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_154.Visible = false;
		this.lwVmQasfwy9.HeaderText = "TabIndexChar";
		this.lwVmQasfwy9.Name = "dataGridViewTextBoxColumn153";
		this.lwVmQasfwy9.ReadOnly = true;
		this.lwVmQasfwy9.Visible = false;
		this.dataGridViewTextBoxColumn_155.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_155.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_155.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_155.Name = "dataGridViewTextBoxColumn154";
		this.dataGridViewTextBoxColumn_155.ReadOnly = true;
		this.dataGridViewTextBoxColumn_155.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_155.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_156.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_156.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_156.Name = "dataGridViewTextBoxColumn155";
		this.dataGridViewTextBoxColumn_156.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_156.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_148.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_148.Name = "dataGridViewTextBoxColumn146";
		this.dataGridViewTextBoxColumn_148.ReadOnly = true;
		this.dataGridViewTextBoxColumn_148.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_148.Visible = false;
		this.dataGridViewTextBoxColumn_149.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_149.Name = "dataGridViewTextBoxColumn147";
		this.dataGridViewTextBoxColumn_149.ReadOnly = true;
		this.dataGridViewTextBoxColumn_149.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_149.Visible = false;
		this.dataGridViewTextBoxColumn_150.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_150.Name = "dataGridViewTextBoxColumn148";
		this.dataGridViewTextBoxColumn_150.ReadOnly = true;
		this.dataGridViewTextBoxColumn_150.Visible = false;
		this.dataGridViewTextBoxColumn_151.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_151.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_151.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_151.Name = "dataGridViewTextBoxColumn149";
		this.dataGridViewTextBoxColumn_151.ReadOnly = true;
		this.dataGridViewTextBoxColumn_151.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_151.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_152.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_152.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_152.Name = "dataGridViewTextBoxColumn150";
		this.dataGridViewTextBoxColumn_152.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_152.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_143.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_143.Name = "dataGridViewTextBoxColumn141";
		this.dataGridViewTextBoxColumn_143.ReadOnly = true;
		this.dataGridViewTextBoxColumn_143.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_143.Visible = false;
		this.dataGridViewTextBoxColumn_144.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_144.Name = "dataGridViewTextBoxColumn142";
		this.dataGridViewTextBoxColumn_144.ReadOnly = true;
		this.dataGridViewTextBoxColumn_144.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_144.Visible = false;
		this.dataGridViewTextBoxColumn_145.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_145.Name = "dataGridViewTextBoxColumn143";
		this.dataGridViewTextBoxColumn_145.ReadOnly = true;
		this.dataGridViewTextBoxColumn_145.Visible = false;
		this.dataGridViewTextBoxColumn_146.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_146.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_146.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_146.Name = "dataGridViewTextBoxColumn144";
		this.dataGridViewTextBoxColumn_146.ReadOnly = true;
		this.dataGridViewTextBoxColumn_146.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_146.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_147.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_147.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_147.Name = "dataGridViewTextBoxColumn145";
		this.dataGridViewTextBoxColumn_147.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_147.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_138.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_138.Name = "dataGridViewTextBoxColumn136";
		this.dataGridViewTextBoxColumn_138.ReadOnly = true;
		this.dataGridViewTextBoxColumn_138.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_138.Visible = false;
		this.dataGridViewTextBoxColumn_139.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_139.Name = "dataGridViewTextBoxColumn137";
		this.dataGridViewTextBoxColumn_139.ReadOnly = true;
		this.dataGridViewTextBoxColumn_139.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_139.Visible = false;
		this.dataGridViewTextBoxColumn_140.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_140.Name = "dataGridViewTextBoxColumn138";
		this.dataGridViewTextBoxColumn_140.ReadOnly = true;
		this.dataGridViewTextBoxColumn_140.Visible = false;
		this.dataGridViewTextBoxColumn_141.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_141.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_141.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_141.Name = "dataGridViewTextBoxColumn139";
		this.dataGridViewTextBoxColumn_141.ReadOnly = true;
		this.dataGridViewTextBoxColumn_141.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_141.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_142.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_142.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_142.Name = "dataGridViewTextBoxColumn140";
		this.dataGridViewTextBoxColumn_142.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_142.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_133.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_133.Name = "dataGridViewTextBoxColumn131";
		this.dataGridViewTextBoxColumn_133.ReadOnly = true;
		this.dataGridViewTextBoxColumn_133.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_133.Visible = false;
		this.dataGridViewTextBoxColumn_134.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_134.Name = "dataGridViewTextBoxColumn132";
		this.dataGridViewTextBoxColumn_134.ReadOnly = true;
		this.dataGridViewTextBoxColumn_134.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_134.Visible = false;
		this.dataGridViewTextBoxColumn_135.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_135.Name = "dataGridViewTextBoxColumn133";
		this.dataGridViewTextBoxColumn_135.ReadOnly = true;
		this.dataGridViewTextBoxColumn_135.Visible = false;
		this.dataGridViewTextBoxColumn_136.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_136.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_136.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_136.Name = "dataGridViewTextBoxColumn134";
		this.dataGridViewTextBoxColumn_136.ReadOnly = true;
		this.dataGridViewTextBoxColumn_136.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_136.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_137.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_137.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_137.Name = "dataGridViewTextBoxColumn135";
		this.dataGridViewTextBoxColumn_137.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_137.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_128.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_128.Name = "dataGridViewTextBoxColumn126";
		this.dataGridViewTextBoxColumn_128.ReadOnly = true;
		this.dataGridViewTextBoxColumn_128.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_128.Visible = false;
		this.dataGridViewTextBoxColumn_129.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_129.Name = "dataGridViewTextBoxColumn127";
		this.dataGridViewTextBoxColumn_129.ReadOnly = true;
		this.dataGridViewTextBoxColumn_129.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_129.Visible = false;
		this.dataGridViewTextBoxColumn_130.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_130.Name = "dataGridViewTextBoxColumn128";
		this.dataGridViewTextBoxColumn_130.ReadOnly = true;
		this.dataGridViewTextBoxColumn_130.Visible = false;
		this.dataGridViewTextBoxColumn_131.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_131.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_131.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_131.Name = "dataGridViewTextBoxColumn129";
		this.dataGridViewTextBoxColumn_131.ReadOnly = true;
		this.dataGridViewTextBoxColumn_131.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_131.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_132.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_132.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_132.Name = "dataGridViewTextBoxColumn130";
		this.dataGridViewTextBoxColumn_132.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_132.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_123.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_123.Name = "dataGridViewTextBoxColumn121";
		this.dataGridViewTextBoxColumn_123.ReadOnly = true;
		this.dataGridViewTextBoxColumn_123.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_123.Visible = false;
		this.dataGridViewTextBoxColumn_124.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_124.Name = "dataGridViewTextBoxColumn122";
		this.dataGridViewTextBoxColumn_124.ReadOnly = true;
		this.dataGridViewTextBoxColumn_124.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_124.Visible = false;
		this.dataGridViewTextBoxColumn_125.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_125.Name = "dataGridViewTextBoxColumn123";
		this.dataGridViewTextBoxColumn_125.ReadOnly = true;
		this.dataGridViewTextBoxColumn_125.Visible = false;
		this.dataGridViewTextBoxColumn_126.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_126.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_126.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_126.Name = "dataGridViewTextBoxColumn124";
		this.dataGridViewTextBoxColumn_126.ReadOnly = true;
		this.dataGridViewTextBoxColumn_126.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_126.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_127.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_127.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_127.Name = "dataGridViewTextBoxColumn125";
		this.dataGridViewTextBoxColumn_127.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_127.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_118.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_118.Name = "dataGridViewTextBoxColumn116";
		this.dataGridViewTextBoxColumn_118.ReadOnly = true;
		this.dataGridViewTextBoxColumn_118.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_118.Visible = false;
		this.dataGridViewTextBoxColumn_119.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_119.Name = "dataGridViewTextBoxColumn117";
		this.dataGridViewTextBoxColumn_119.ReadOnly = true;
		this.dataGridViewTextBoxColumn_119.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_119.Visible = false;
		this.dataGridViewTextBoxColumn_120.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_120.Name = "dataGridViewTextBoxColumn118";
		this.dataGridViewTextBoxColumn_120.ReadOnly = true;
		this.dataGridViewTextBoxColumn_120.Visible = false;
		this.dataGridViewTextBoxColumn_121.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_121.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_121.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_121.Name = "dataGridViewTextBoxColumn119";
		this.dataGridViewTextBoxColumn_121.ReadOnly = true;
		this.dataGridViewTextBoxColumn_121.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_121.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_122.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_122.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_122.Name = "dataGridViewTextBoxColumn120";
		this.dataGridViewTextBoxColumn_122.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_122.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_113.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_113.Name = "dataGridViewTextBoxColumn111";
		this.dataGridViewTextBoxColumn_113.ReadOnly = true;
		this.dataGridViewTextBoxColumn_113.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_113.Visible = false;
		this.dataGridViewTextBoxColumn_114.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_114.Name = "dataGridViewTextBoxColumn112";
		this.dataGridViewTextBoxColumn_114.ReadOnly = true;
		this.dataGridViewTextBoxColumn_114.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_114.Visible = false;
		this.dataGridViewTextBoxColumn_115.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_115.Name = "dataGridViewTextBoxColumn113";
		this.dataGridViewTextBoxColumn_115.ReadOnly = true;
		this.dataGridViewTextBoxColumn_115.Visible = false;
		this.dataGridViewTextBoxColumn_116.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_116.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_116.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_116.Name = "dataGridViewTextBoxColumn114";
		this.dataGridViewTextBoxColumn_116.ReadOnly = true;
		this.dataGridViewTextBoxColumn_116.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_116.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_117.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_117.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_117.Name = "dataGridViewTextBoxColumn115";
		this.dataGridViewTextBoxColumn_117.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_117.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_108.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_108.Name = "dataGridViewTextBoxColumn106";
		this.dataGridViewTextBoxColumn_108.ReadOnly = true;
		this.dataGridViewTextBoxColumn_108.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_108.Visible = false;
		this.dataGridViewTextBoxColumn_109.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_109.Name = "dataGridViewTextBoxColumn107";
		this.dataGridViewTextBoxColumn_109.ReadOnly = true;
		this.dataGridViewTextBoxColumn_109.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_109.Visible = false;
		this.dataGridViewTextBoxColumn_110.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_110.Name = "dataGridViewTextBoxColumn108";
		this.dataGridViewTextBoxColumn_110.ReadOnly = true;
		this.dataGridViewTextBoxColumn_110.Visible = false;
		this.dataGridViewTextBoxColumn_111.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_111.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_111.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_111.Name = "dataGridViewTextBoxColumn109";
		this.dataGridViewTextBoxColumn_111.ReadOnly = true;
		this.dataGridViewTextBoxColumn_111.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_111.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_112.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_112.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_112.Name = "dataGridViewTextBoxColumn110";
		this.dataGridViewTextBoxColumn_112.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_112.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_103.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_103.Name = "dataGridViewTextBoxColumn101";
		this.dataGridViewTextBoxColumn_103.ReadOnly = true;
		this.dataGridViewTextBoxColumn_103.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_103.Visible = false;
		this.dataGridViewTextBoxColumn_104.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_104.Name = "dataGridViewTextBoxColumn102";
		this.dataGridViewTextBoxColumn_104.ReadOnly = true;
		this.dataGridViewTextBoxColumn_104.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_104.Visible = false;
		this.dataGridViewTextBoxColumn_105.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_105.Name = "dataGridViewTextBoxColumn103";
		this.dataGridViewTextBoxColumn_105.ReadOnly = true;
		this.dataGridViewTextBoxColumn_105.Visible = false;
		this.dataGridViewTextBoxColumn_106.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_106.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_106.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_106.Name = "dataGridViewTextBoxColumn104";
		this.dataGridViewTextBoxColumn_106.ReadOnly = true;
		this.dataGridViewTextBoxColumn_106.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_106.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_107.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_107.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_107.Name = "dataGridViewTextBoxColumn105";
		this.dataGridViewTextBoxColumn_107.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_107.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_98.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_98.Name = "dataGridViewTextBoxColumn96";
		this.dataGridViewTextBoxColumn_98.ReadOnly = true;
		this.dataGridViewTextBoxColumn_98.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_98.Visible = false;
		this.dataGridViewTextBoxColumn_99.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_99.Name = "dataGridViewTextBoxColumn97";
		this.dataGridViewTextBoxColumn_99.ReadOnly = true;
		this.dataGridViewTextBoxColumn_99.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_99.Visible = false;
		this.dataGridViewTextBoxColumn_100.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_100.Name = "dataGridViewTextBoxColumn98";
		this.dataGridViewTextBoxColumn_100.ReadOnly = true;
		this.dataGridViewTextBoxColumn_100.Visible = false;
		this.dataGridViewTextBoxColumn_101.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_101.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_101.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_101.Name = "dataGridViewTextBoxColumn99";
		this.dataGridViewTextBoxColumn_101.ReadOnly = true;
		this.dataGridViewTextBoxColumn_101.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_101.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_102.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_102.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_102.Name = "dataGridViewTextBoxColumn100";
		this.dataGridViewTextBoxColumn_102.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_102.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_93.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_93.Name = "dataGridViewTextBoxColumn91";
		this.dataGridViewTextBoxColumn_93.ReadOnly = true;
		this.dataGridViewTextBoxColumn_93.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_93.Visible = false;
		this.dataGridViewTextBoxColumn_94.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_94.Name = "dataGridViewTextBoxColumn92";
		this.dataGridViewTextBoxColumn_94.ReadOnly = true;
		this.dataGridViewTextBoxColumn_94.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_94.Visible = false;
		this.dataGridViewTextBoxColumn_95.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_95.Name = "dataGridViewTextBoxColumn93";
		this.dataGridViewTextBoxColumn_95.ReadOnly = true;
		this.dataGridViewTextBoxColumn_95.Visible = false;
		this.dataGridViewTextBoxColumn_96.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_96.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_96.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_96.Name = "dataGridViewTextBoxColumn94";
		this.dataGridViewTextBoxColumn_96.ReadOnly = true;
		this.dataGridViewTextBoxColumn_96.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_96.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_97.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_97.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_97.Name = "dataGridViewTextBoxColumn95";
		this.dataGridViewTextBoxColumn_97.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_97.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_88.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_88.Name = "dataGridViewTextBoxColumn86";
		this.dataGridViewTextBoxColumn_88.ReadOnly = true;
		this.dataGridViewTextBoxColumn_88.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_88.Visible = false;
		this.dataGridViewTextBoxColumn_89.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_89.Name = "dataGridViewTextBoxColumn87";
		this.dataGridViewTextBoxColumn_89.ReadOnly = true;
		this.dataGridViewTextBoxColumn_89.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_89.Visible = false;
		this.dataGridViewTextBoxColumn_90.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_90.Name = "dataGridViewTextBoxColumn88";
		this.dataGridViewTextBoxColumn_90.ReadOnly = true;
		this.dataGridViewTextBoxColumn_90.Visible = false;
		this.dataGridViewTextBoxColumn_91.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_91.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_91.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_91.Name = "dataGridViewTextBoxColumn89";
		this.dataGridViewTextBoxColumn_91.ReadOnly = true;
		this.dataGridViewTextBoxColumn_91.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_91.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_92.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_92.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_92.Name = "dataGridViewTextBoxColumn90";
		this.dataGridViewTextBoxColumn_92.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_92.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_83.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_83.Name = "dataGridViewTextBoxColumn81";
		this.dataGridViewTextBoxColumn_83.ReadOnly = true;
		this.dataGridViewTextBoxColumn_83.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_83.Visible = false;
		this.dataGridViewTextBoxColumn_84.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_84.Name = "dataGridViewTextBoxColumn82";
		this.dataGridViewTextBoxColumn_84.ReadOnly = true;
		this.dataGridViewTextBoxColumn_84.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_84.Visible = false;
		this.dataGridViewTextBoxColumn_85.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_85.Name = "dataGridViewTextBoxColumn83";
		this.dataGridViewTextBoxColumn_85.ReadOnly = true;
		this.dataGridViewTextBoxColumn_85.Visible = false;
		this.dataGridViewTextBoxColumn_86.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_86.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_86.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_86.Name = "dataGridViewTextBoxColumn84";
		this.dataGridViewTextBoxColumn_86.ReadOnly = true;
		this.dataGridViewTextBoxColumn_86.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_86.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_87.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_87.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_87.Name = "dataGridViewTextBoxColumn85";
		this.dataGridViewTextBoxColumn_87.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_87.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_78.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_78.Name = "dataGridViewTextBoxColumn76";
		this.dataGridViewTextBoxColumn_78.ReadOnly = true;
		this.dataGridViewTextBoxColumn_78.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_78.Visible = false;
		this.dataGridViewTextBoxColumn_79.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_79.Name = "dataGridViewTextBoxColumn77";
		this.dataGridViewTextBoxColumn_79.ReadOnly = true;
		this.dataGridViewTextBoxColumn_79.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_79.Visible = false;
		this.dataGridViewTextBoxColumn_80.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_80.Name = "dataGridViewTextBoxColumn78";
		this.dataGridViewTextBoxColumn_80.ReadOnly = true;
		this.dataGridViewTextBoxColumn_80.Visible = false;
		this.dataGridViewTextBoxColumn_81.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_81.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_81.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_81.Name = "dataGridViewTextBoxColumn79";
		this.dataGridViewTextBoxColumn_81.ReadOnly = true;
		this.dataGridViewTextBoxColumn_81.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_81.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_82.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_82.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_82.Name = "dataGridViewTextBoxColumn80";
		this.dataGridViewTextBoxColumn_82.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_82.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_73.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_73.Name = "dataGridViewTextBoxColumn71";
		this.dataGridViewTextBoxColumn_73.ReadOnly = true;
		this.dataGridViewTextBoxColumn_73.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_73.Visible = false;
		this.dataGridViewTextBoxColumn_74.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_74.Name = "dataGridViewTextBoxColumn72";
		this.dataGridViewTextBoxColumn_74.ReadOnly = true;
		this.dataGridViewTextBoxColumn_74.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_74.Visible = false;
		this.dataGridViewTextBoxColumn_75.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_75.Name = "dataGridViewTextBoxColumn73";
		this.dataGridViewTextBoxColumn_75.ReadOnly = true;
		this.dataGridViewTextBoxColumn_75.Visible = false;
		this.dataGridViewTextBoxColumn_76.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_76.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_76.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_76.Name = "dataGridViewTextBoxColumn74";
		this.dataGridViewTextBoxColumn_76.ReadOnly = true;
		this.dataGridViewTextBoxColumn_76.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_76.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_77.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_77.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_77.Name = "dataGridViewTextBoxColumn75";
		this.dataGridViewTextBoxColumn_77.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_77.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_68.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_68.Name = "dataGridViewTextBoxColumn66";
		this.dataGridViewTextBoxColumn_68.ReadOnly = true;
		this.dataGridViewTextBoxColumn_68.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_68.Visible = false;
		this.dataGridViewTextBoxColumn_69.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_69.Name = "dataGridViewTextBoxColumn67";
		this.dataGridViewTextBoxColumn_69.ReadOnly = true;
		this.dataGridViewTextBoxColumn_69.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_69.Visible = false;
		this.dataGridViewTextBoxColumn_70.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_70.Name = "dataGridViewTextBoxColumn68";
		this.dataGridViewTextBoxColumn_70.ReadOnly = true;
		this.dataGridViewTextBoxColumn_70.Visible = false;
		this.dataGridViewTextBoxColumn_71.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_71.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_71.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_71.Name = "dataGridViewTextBoxColumn69";
		this.dataGridViewTextBoxColumn_71.ReadOnly = true;
		this.dataGridViewTextBoxColumn_71.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_71.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_72.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_72.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_72.Name = "dataGridViewTextBoxColumn70";
		this.dataGridViewTextBoxColumn_72.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_72.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_63.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_63.Name = "dataGridViewTextBoxColumn61";
		this.dataGridViewTextBoxColumn_63.ReadOnly = true;
		this.dataGridViewTextBoxColumn_63.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_63.Visible = false;
		this.dataGridViewTextBoxColumn_64.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_64.Name = "dataGridViewTextBoxColumn62";
		this.dataGridViewTextBoxColumn_64.ReadOnly = true;
		this.dataGridViewTextBoxColumn_64.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_64.Visible = false;
		this.dataGridViewTextBoxColumn_65.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_65.Name = "dataGridViewTextBoxColumn63";
		this.dataGridViewTextBoxColumn_65.ReadOnly = true;
		this.dataGridViewTextBoxColumn_65.Visible = false;
		this.dataGridViewTextBoxColumn_66.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_66.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_66.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_66.Name = "dataGridViewTextBoxColumn64";
		this.dataGridViewTextBoxColumn_66.ReadOnly = true;
		this.dataGridViewTextBoxColumn_66.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_66.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_67.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_67.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_67.Name = "dataGridViewTextBoxColumn65";
		this.dataGridViewTextBoxColumn_67.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_67.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_58.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_58.Name = "dataGridViewTextBoxColumn56";
		this.dataGridViewTextBoxColumn_58.ReadOnly = true;
		this.dataGridViewTextBoxColumn_58.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_58.Visible = false;
		this.dataGridViewTextBoxColumn_59.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_59.Name = "dataGridViewTextBoxColumn57";
		this.dataGridViewTextBoxColumn_59.ReadOnly = true;
		this.dataGridViewTextBoxColumn_59.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_59.Visible = false;
		this.dataGridViewTextBoxColumn_60.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_60.Name = "dataGridViewTextBoxColumn58";
		this.dataGridViewTextBoxColumn_60.ReadOnly = true;
		this.dataGridViewTextBoxColumn_60.Visible = false;
		this.dataGridViewTextBoxColumn_61.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_61.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_61.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_61.Name = "dataGridViewTextBoxColumn59";
		this.dataGridViewTextBoxColumn_61.ReadOnly = true;
		this.dataGridViewTextBoxColumn_61.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_61.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_62.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_62.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_62.Name = "dataGridViewTextBoxColumn60";
		this.dataGridViewTextBoxColumn_62.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_62.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_53.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_53.Name = "dataGridViewTextBoxColumn51";
		this.dataGridViewTextBoxColumn_53.ReadOnly = true;
		this.dataGridViewTextBoxColumn_53.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_53.Visible = false;
		this.dataGridViewTextBoxColumn_54.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_54.Name = "dataGridViewTextBoxColumn52";
		this.dataGridViewTextBoxColumn_54.ReadOnly = true;
		this.dataGridViewTextBoxColumn_54.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_54.Visible = false;
		this.dataGridViewTextBoxColumn_55.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_55.Name = "dataGridViewTextBoxColumn53";
		this.dataGridViewTextBoxColumn_55.ReadOnly = true;
		this.dataGridViewTextBoxColumn_55.Visible = false;
		this.dataGridViewTextBoxColumn_56.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_56.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_56.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_56.Name = "dataGridViewTextBoxColumn54";
		this.dataGridViewTextBoxColumn_56.ReadOnly = true;
		this.dataGridViewTextBoxColumn_56.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_56.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_57.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_57.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_57.Name = "dataGridViewTextBoxColumn55";
		this.dataGridViewTextBoxColumn_57.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_57.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_49.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_49.Name = "dataGridViewTextBoxColumn46";
		this.dataGridViewTextBoxColumn_49.ReadOnly = true;
		this.dataGridViewTextBoxColumn_49.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_49.Visible = false;
		this.dataGridViewTextBoxColumn_50.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_50.Name = "dataGridViewTextBoxColumn47";
		this.dataGridViewTextBoxColumn_50.ReadOnly = true;
		this.dataGridViewTextBoxColumn_50.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_50.Visible = false;
		this.ehbmCnEqepn.HeaderText = "TabIndexChar";
		this.ehbmCnEqepn.Name = "dataGridViewTextBoxColumn48";
		this.ehbmCnEqepn.ReadOnly = true;
		this.ehbmCnEqepn.Visible = false;
		this.dataGridViewTextBoxColumn_51.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_51.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_51.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_51.Name = "dataGridViewTextBoxColumn49";
		this.dataGridViewTextBoxColumn_51.ReadOnly = true;
		this.dataGridViewTextBoxColumn_51.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_51.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_52.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_52.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_52.Name = "dataGridViewTextBoxColumn50";
		this.dataGridViewTextBoxColumn_52.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_52.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_44.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_44.Name = "dataGridViewTextBoxColumn41";
		this.dataGridViewTextBoxColumn_44.ReadOnly = true;
		this.dataGridViewTextBoxColumn_44.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_44.Visible = false;
		this.dataGridViewTextBoxColumn_45.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_45.Name = "dataGridViewTextBoxColumn42";
		this.dataGridViewTextBoxColumn_45.ReadOnly = true;
		this.dataGridViewTextBoxColumn_45.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_45.Visible = false;
		this.dataGridViewTextBoxColumn_46.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_46.Name = "dataGridViewTextBoxColumn43";
		this.dataGridViewTextBoxColumn_46.ReadOnly = true;
		this.dataGridViewTextBoxColumn_46.Visible = false;
		this.dataGridViewTextBoxColumn_47.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_47.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_47.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_47.Name = "dataGridViewTextBoxColumn44";
		this.dataGridViewTextBoxColumn_47.ReadOnly = true;
		this.dataGridViewTextBoxColumn_47.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_47.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_48.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_48.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_48.Name = "dataGridViewTextBoxColumn45";
		this.dataGridViewTextBoxColumn_48.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_48.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_39.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_39.Name = "dataGridViewTextBoxColumn36";
		this.dataGridViewTextBoxColumn_39.ReadOnly = true;
		this.dataGridViewTextBoxColumn_39.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_39.Visible = false;
		this.dataGridViewTextBoxColumn_40.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_40.Name = "dataGridViewTextBoxColumn37";
		this.dataGridViewTextBoxColumn_40.ReadOnly = true;
		this.dataGridViewTextBoxColumn_40.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_40.Visible = false;
		this.dataGridViewTextBoxColumn_41.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_41.Name = "dataGridViewTextBoxColumn38";
		this.dataGridViewTextBoxColumn_41.ReadOnly = true;
		this.dataGridViewTextBoxColumn_41.Visible = false;
		this.dataGridViewTextBoxColumn_42.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_42.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_42.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_42.Name = "dataGridViewTextBoxColumn39";
		this.dataGridViewTextBoxColumn_42.ReadOnly = true;
		this.dataGridViewTextBoxColumn_42.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_42.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_43.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_43.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_43.Name = "dataGridViewTextBoxColumn40";
		this.dataGridViewTextBoxColumn_43.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_43.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_35.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_35.Name = "dataGridViewTextBoxColumn31";
		this.dataGridViewTextBoxColumn_35.ReadOnly = true;
		this.dataGridViewTextBoxColumn_35.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_35.Visible = false;
		this.dataGridViewTextBoxColumn_36.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_36.Name = "dataGridViewTextBoxColumn32";
		this.dataGridViewTextBoxColumn_36.ReadOnly = true;
		this.dataGridViewTextBoxColumn_36.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_36.Visible = false;
		this.dataGridViewTextBoxColumn_37.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_37.Name = "dataGridViewTextBoxColumn33";
		this.dataGridViewTextBoxColumn_37.ReadOnly = true;
		this.dataGridViewTextBoxColumn_37.Visible = false;
		this.dataGridViewTextBoxColumn_38.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_38.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_38.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_38.Name = "dataGridViewTextBoxColumn34";
		this.dataGridViewTextBoxColumn_38.ReadOnly = true;
		this.dataGridViewTextBoxColumn_38.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_38.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.kxomIdiCwdi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.kxomIdiCwdi.HeaderText = "Значение";
		this.kxomIdiCwdi.Name = "dataGridViewTextBoxColumn35";
		this.kxomIdiCwdi.Resizable = DataGridViewTriState.True;
		this.kxomIdiCwdi.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_30.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_30.Name = "dataGridViewTextBoxColumn26";
		this.dataGridViewTextBoxColumn_30.ReadOnly = true;
		this.dataGridViewTextBoxColumn_30.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_30.Visible = false;
		this.dataGridViewTextBoxColumn_31.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_31.Name = "dataGridViewTextBoxColumn27";
		this.dataGridViewTextBoxColumn_31.ReadOnly = true;
		this.dataGridViewTextBoxColumn_31.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_31.Visible = false;
		this.dataGridViewTextBoxColumn_32.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_32.Name = "dataGridViewTextBoxColumn28";
		this.dataGridViewTextBoxColumn_32.ReadOnly = true;
		this.dataGridViewTextBoxColumn_32.Visible = false;
		this.dataGridViewTextBoxColumn_33.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_33.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_33.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_33.Name = "dataGridViewTextBoxColumn29";
		this.dataGridViewTextBoxColumn_33.ReadOnly = true;
		this.dataGridViewTextBoxColumn_33.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_33.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_34.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_34.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_34.Name = "dataGridViewTextBoxColumn30";
		this.dataGridViewTextBoxColumn_34.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_34.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_25.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_25.Name = "dataGridViewTextBoxColumn21";
		this.dataGridViewTextBoxColumn_25.ReadOnly = true;
		this.dataGridViewTextBoxColumn_25.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_25.Visible = false;
		this.dataGridViewTextBoxColumn_26.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_26.Name = "dataGridViewTextBoxColumn22";
		this.dataGridViewTextBoxColumn_26.ReadOnly = true;
		this.dataGridViewTextBoxColumn_26.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_26.Visible = false;
		this.dataGridViewTextBoxColumn_27.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_27.Name = "dataGridViewTextBoxColumn23";
		this.dataGridViewTextBoxColumn_27.ReadOnly = true;
		this.dataGridViewTextBoxColumn_27.Visible = false;
		this.dataGridViewTextBoxColumn_28.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_28.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_28.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_28.Name = "dataGridViewTextBoxColumn24";
		this.dataGridViewTextBoxColumn_28.ReadOnly = true;
		this.dataGridViewTextBoxColumn_28.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_28.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_29.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_29.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_29.Name = "dataGridViewTextBoxColumn25";
		this.dataGridViewTextBoxColumn_29.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_29.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_20.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_20.Name = "dataGridViewTextBoxColumn16";
		this.dataGridViewTextBoxColumn_20.ReadOnly = true;
		this.dataGridViewTextBoxColumn_20.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_20.Visible = false;
		this.dataGridViewTextBoxColumn_21.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_21.Name = "dataGridViewTextBoxColumn17";
		this.dataGridViewTextBoxColumn_21.ReadOnly = true;
		this.dataGridViewTextBoxColumn_21.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_21.Visible = false;
		this.dataGridViewTextBoxColumn_22.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_22.Name = "dataGridViewTextBoxColumn18";
		this.dataGridViewTextBoxColumn_22.ReadOnly = true;
		this.dataGridViewTextBoxColumn_22.Visible = false;
		this.dataGridViewTextBoxColumn_23.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_23.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_23.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_23.Name = "dataGridViewTextBoxColumn19";
		this.dataGridViewTextBoxColumn_23.ReadOnly = true;
		this.dataGridViewTextBoxColumn_23.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_23.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_24.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_24.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_24.Name = "dataGridViewTextBoxColumn20";
		this.dataGridViewTextBoxColumn_24.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_24.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_15.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn11";
		this.dataGridViewTextBoxColumn_15.ReadOnly = true;
		this.dataGridViewTextBoxColumn_15.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_15.Visible = false;
		this.dataGridViewTextBoxColumn_16.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn12";
		this.dataGridViewTextBoxColumn_16.ReadOnly = true;
		this.dataGridViewTextBoxColumn_16.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_16.Visible = false;
		this.dataGridViewTextBoxColumn_17.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn13";
		this.dataGridViewTextBoxColumn_17.ReadOnly = true;
		this.dataGridViewTextBoxColumn_17.Visible = false;
		this.dataGridViewTextBoxColumn_18.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_18.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_18.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn14";
		this.dataGridViewTextBoxColumn_18.ReadOnly = true;
		this.dataGridViewTextBoxColumn_18.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_18.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_19.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_19.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn15";
		this.dataGridViewTextBoxColumn_19.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_19.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_10.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn6";
		this.dataGridViewTextBoxColumn_10.ReadOnly = true;
		this.dataGridViewTextBoxColumn_10.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_10.Visible = false;
		this.dataGridViewTextBoxColumn_11.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn7";
		this.dataGridViewTextBoxColumn_11.ReadOnly = true;
		this.dataGridViewTextBoxColumn_11.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_11.Visible = false;
		this.dataGridViewTextBoxColumn_12.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn8";
		this.dataGridViewTextBoxColumn_12.ReadOnly = true;
		this.dataGridViewTextBoxColumn_12.Visible = false;
		this.dataGridViewTextBoxColumn_13.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_13.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_13.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn9";
		this.dataGridViewTextBoxColumn_13.ReadOnly = true;
		this.dataGridViewTextBoxColumn_13.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_13.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_14.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_14.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn10";
		this.dataGridViewTextBoxColumn_14.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_14.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_0.HeaderText = "idChar";
		this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn606";
		this.dataGridViewTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewTextBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_0.Visible = false;
		this.dataGridViewTextBoxColumn_1.HeaderText = "ParentIdChar";
		this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn607";
		this.dataGridViewTextBoxColumn_1.ReadOnly = true;
		this.dataGridViewTextBoxColumn_1.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_1.Visible = false;
		this.dataGridViewTextBoxColumn_2.HeaderText = "TabIndexChar";
		this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn608";
		this.dataGridViewTextBoxColumn_2.ReadOnly = true;
		this.dataGridViewTextBoxColumn_2.Visible = false;
		this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		this.dataGridViewTextBoxColumn_3.FillWeight = 150f;
		this.dataGridViewTextBoxColumn_3.HeaderText = "Характеристика";
		this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn609";
		this.dataGridViewTextBoxColumn_3.ReadOnly = true;
		this.dataGridViewTextBoxColumn_3.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_3.SortMode = DataGridViewColumnSortMode.Programmatic;
		this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_4.HeaderText = "Значение";
		this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn610";
		this.dataGridViewTextBoxColumn_4.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_4.SortMode = DataGridViewColumnSortMode.Programmatic;
		base.AcceptButton = this.button_1;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = this.button_0;
		base.ClientSize = new Size(323, 436);
		base.Controls.Add(this.checkBox_0);
		base.Controls.Add(this.tableLayoutPanel_0);
		base.Controls.Add(this.label_3);
		base.Controls.Add(this.label_2);
		base.Controls.Add(this.label_1);
		base.Controls.Add(this.label_4);
		base.Controls.Add(this.label_0);
		base.Controls.Add(this.dateTimePicker_0);
		base.Controls.Add(this.comboBox_3);
		base.Controls.Add(this.comboBox_1);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.button_0);
		base.Controls.Add(this.dataGridViewPassport_0);
		this.MinimumSize = new Size(339, 429);
		base.Name = "FormAddPylonEquipment";
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "Оборудование";
		((ISupportInitialize)this.bindingSource_0).EndInit();
		((ISupportInitialize)this.class107_0).EndInit();
		((ISupportInitialize)this.class107_1).EndInit();
		((ISupportInitialize)this.bindingSource_1).EndInit();
		this.tableLayoutPanel_0.ResumeLayout(false);
		this.tableLayoutPanel_0.PerformLayout();
		((ISupportInitialize)this.dataGridViewPassport_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private int int_0;

	private int int_1;

	private int int_2;

	private string string_0;

	private Class107.Class244 class244_0;

	private bool bool_0;

	[CompilerGenerated]
	private StateFormCreate stateFormCreate_0;

	private ComboBox comboBox_0;

	private IContainer icontainer_0;

	private DataGridViewPassport dataGridViewPassport_0;

	private Button button_0;

	private Button button_1;

	private TextBox textBox_0;

	private ComboBox comboBox_1;

	private DateTimePicker dateTimePicker_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private ComboBox comboBox_2;

	private Class107 class107_0;

	private BindingSource bindingSource_0;

	private Class107 class107_1;

	private BindingSource bindingSource_1;

	private ComboBox comboBox_3;

	private Label label_4;

	private TableLayoutPanel tableLayoutPanel_0;

	private CheckBox checkBox_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

	private DataGridViewCheckBoxColumn SyomIyEncdm;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;

	private DataGridViewTextBoxColumn kxomIdiCwdi;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_8;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;

	private DataGridViewTextBoxColumn ehbmCnEqepn;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_10;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_11;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_64;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_65;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_12;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_66;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_67;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_68;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_69;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_70;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_13;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_71;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_72;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_73;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_74;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_75;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_14;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_76;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_77;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_78;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_79;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_80;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_15;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_81;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_82;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_83;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_84;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_85;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_16;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_86;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_87;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_88;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_89;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_90;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_17;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_91;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_92;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_93;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_94;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_95;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_18;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_96;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_97;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_98;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_99;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_100;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_19;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_101;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_102;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_103;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_104;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_105;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_20;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_106;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_107;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_108;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_109;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_110;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_21;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_111;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_112;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_113;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_114;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_115;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_22;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_116;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_117;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_118;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_119;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_120;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_23;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_121;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_122;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_123;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_124;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_125;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_24;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_126;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_127;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_128;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_129;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_130;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_25;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_131;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_132;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_133;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_134;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_135;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_26;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_136;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_137;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_138;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_139;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_140;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_27;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_141;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_142;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_143;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_144;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_145;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_28;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_146;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_147;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_148;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_149;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_150;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_29;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_151;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_152;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_153;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_154;

	private DataGridViewTextBoxColumn lwVmQasfwy9;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_30;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_155;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_156;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_157;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_158;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_159;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_31;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_160;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_161;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_162;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_163;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_164;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_32;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_165;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_166;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_167;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_168;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_169;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_33;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_170;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_171;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_172;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_173;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_174;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_34;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_175;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_176;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_177;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_178;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_179;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_35;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_180;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_181;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_182;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_183;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_184;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_36;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_185;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_186;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_187;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_188;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_189;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_37;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_190;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_191;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_192;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_193;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_194;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_38;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_195;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_196;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_197;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_198;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_199;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_39;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_200;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_201;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_202;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_203;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_204;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_40;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_205;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_206;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_207;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_208;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_209;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_41;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_210;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_211;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_212;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_213;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_214;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_42;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_215;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_216;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_217;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_218;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_219;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_43;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_220;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_221;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_222;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_223;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_224;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_44;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_225;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_226;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_227;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_228;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_229;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_45;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_230;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_231;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_232;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_233;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_234;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_46;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_235;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_236;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_237;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_238;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_239;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_47;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_240;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_241;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_242;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_243;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_244;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_48;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_245;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_246;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_247;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_248;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_249;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_49;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_250;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_251;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_252;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_253;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_254;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_50;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_255;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_256;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_257;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_258;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_259;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_51;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_260;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_261;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_262;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_263;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_264;

	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_52;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_265;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_266;
}
