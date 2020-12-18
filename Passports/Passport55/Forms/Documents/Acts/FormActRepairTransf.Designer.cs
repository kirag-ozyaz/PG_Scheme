using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using DataSql;
using Passport.DataSets;

namespace Passport.Forms.Documents.Acts
{
	public class FormActRepairTransf : FormDocBase
	{
		public FormActRepairTransf(SQLSettings sqlSettings, int idObjList)
		{
			this.method_22();
			this.SqlSettings = sqlSettings;
			base.IdObjList = idObjList;
			this.stateFormCreate_1 = 0;
			this.method_20();
		}

		public FormActRepairTransf(SQLSettings sqlSettings, int idObjList, int idDocList, StateFormCreate value)
		{
			this.method_22();
			this.SqlSettings = sqlSettings;
			base.IdDocList = idDocList;
			base.IdObjList = idObjList;
			this.stateFormCreate_1 = value;
			this.method_20();
			if (value == 1)
			{
				this.method_17();
			}
		}

		private void FormActRepairTransf_Load(object sender, EventArgs e)
		{
			this.method_14();
		}

		private void method_14()
		{
			this.comboBox_0.DataSource = base.method_0();
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "Id";
			this.comboBox_3.DataSource = base.method_3();
			this.comboBox_3.DisplayMember = "FIO";
			this.comboBox_3.ValueMember = "Id";
			this.comboBox_2.DataSource = base.method_4();
			this.comboBox_2.DisplayMember = "FIO";
			this.comboBox_2.ValueMember = "Id";
			this.comboBox_1.DataSource = base.method_5();
			this.comboBox_1.DisplayMember = "FIO";
			this.comboBox_1.ValueMember = "Id";
		}

		private void method_15()
		{
			base.SelectSqlDataTableOther(this.dsDocuments_0, this.dsDocuments_0.tP_Protocols, "tP_DocList", true, string.Format("WHERE Id = {0} AND Deleted = ((0))", base.IdDocList));
			this.dataGridView_0.DataSource = this.dsDocuments_0.tP_Protocols;
		}

		private dsDocuments.Class159 method_16(DateTime dateTime_0, string string_0)
		{
			foreach (dsDocuments.Class159 @class in this.dsDocuments_0.tP_Protocols)
			{
				if (@class.method_6() == string_0 && @class.method_4() == dateTime_0)
				{
					return @class;
				}
			}
			return null;
		}

		private void method_17()
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_DocList, true, "WHERE Id = " + base.IdDocList.ToString());
			if (this.dsDocuments_0.tP_DocList.Rows.Count <= 0)
			{
				return;
			}
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_Act_RepairTransf, true, "WHERE IdPasspDocList = " + base.IdDocList.ToString());
			if (this.dsDocuments_0.tP_Act_RepairTransf.Rows.Count <= 0)
			{
				return;
			}
			dsDocuments.Class158 @class = (dsDocuments.Class158)this.dsDocuments_0.tP_DocList.Rows[0];
			dsDocuments.Class165 class2 = (dsDocuments.Class165)this.dsDocuments_0.tP_Act_RepairTransf.Rows[0];
			base.SelectSqlDataTableOther(this.dsDocuments_0, this.dsDocuments_0.tP_Protocols, "tP_DocList", true, "WHERE ParentId = " + @class.Int32_0.ToString() + " AND Deleted = ((0))");
			this.dataGridView_0.DataSource = this.dsDocuments_0.tP_Protocols;
			this.dateTimePicker_1.Value = @class.method_4();
			this.comboBox_0.SelectedValue = class2.method_2();
			this.dateTimePicker_1.Value = @class.method_4();
			this.dateTimePicker_0.Value = class2.method_4();
			this.textBox_17.Text = ((class2.method_6().ToString() != "-1") ? class2.method_6().ToString() : "");
			this.textBox_16.Text = ((class2.method_8().ToString() != "-1") ? class2.method_8().ToString() : "");
			this.dateTimePicker_2.Value = class2.method_10();
			this.dateTimePicker_3.Value = class2.method_12();
			this.textBox_15.Text = class2.method_14();
			this.textBox_14.Text = class2.method_16();
			this.textBox_13.Text = class2.method_18();
			this.textBox_12.Text = ((class2.method_20().ToString() != "-1") ? class2.method_20().ToString() : "");
			this.textBox_11.Text = ((class2.method_22().ToString() != "-1") ? class2.method_22().ToString() : "");
			this.textBox_10.Text = ((class2.method_24().ToString() != "-1") ? class2.method_24().ToString() : "");
			this.textBox_9.Text = ((class2.method_26().ToString() != "-1") ? class2.method_26().ToString() : "");
			this.textBox_8.Text = ((class2.method_28().ToString() != "-1") ? class2.method_28().ToString() : "");
			this.textBox_7.Text = ((class2.method_30().ToString() != "-1") ? class2.method_30().ToString() : "");
			this.textBox_6.Text = class2.method_32();
			this.textBox_20.Text = class2.method_34();
			this.textBox_22.Text = ((class2.method_36().ToString() != "-1") ? class2.method_36().ToString() : "");
			this.textBox_23.Text = ((class2.method_38().ToString() != "-1") ? class2.method_38().ToString() : "");
			this.textBox_18.Text = class2.method_40();
			this.textBox_21.Text = class2.method_44();
			this.textBox_19.Text = class2.method_42();
			this.comboBox_3.SelectedValue = class2.method_46();
			this.comboBox_2.SelectedValue = class2.method_48();
			this.comboBox_1.SelectedValue = class2.method_50();
		}

		private void method_18()
		{
			dsDocuments.Class158 @class = this.dsDocuments_0.tP_DocList.method_5();
			@class.method_1(0);
			@class.method_3(base.IdObjList);
			@class.method_5(this.dateTimePicker_1.Value);
			@class.method_7("");
			@class.method_9(base.method_6("Акт приемки из капитального ремонта трансформатора", ";TypeDoc;tPassport;Transf;Act;Repair;"));
			@class.method_11(true);
			@class.method_13(false);
			this.dsDocuments_0.tP_DocList.method_0(@class);
			base.IdDocList = base.InsertSqlDataOneRow(this.dsDocuments_0, this.dsDocuments_0.tP_DocList);
			dsDocuments.Class165 class2 = this.dsDocuments_0.tP_Act_RepairTransf.method_5();
			class2.method_1(base.IdDocList);
			class2.method_3((int)this.comboBox_0.SelectedValue);
			class2.method_5(this.dateTimePicker_0.Value);
			int num;
			class2.method_7(int.TryParse(this.textBox_17.Text, out num) ? num : -1);
			class2.method_9(int.TryParse(this.textBox_16.Text, out num) ? num : -1);
			class2.method_11(this.dateTimePicker_2.Value);
			class2.method_13(this.dateTimePicker_3.Value);
			class2.method_15(this.textBox_15.Text);
			class2.method_17(this.textBox_14.Text);
			class2.method_19(this.textBox_13.Text);
			class2.method_21(int.TryParse(this.textBox_12.Text, out num) ? num : -1);
			class2.method_23(int.TryParse(this.textBox_11.Text, out num) ? num : -1);
			class2.method_25(int.TryParse(this.textBox_10.Text, out num) ? num : -1);
			class2.method_27(int.TryParse(this.textBox_9.Text, out num) ? num : -1);
			class2.method_29(int.TryParse(this.textBox_8.Text, out num) ? num : -1);
			class2.method_31(int.TryParse(this.textBox_7.Text, out num) ? num : -1);
			class2.method_33(this.textBox_6.Text);
			class2.method_35(this.textBox_20.Text);
			class2.method_37(int.TryParse(this.textBox_22.Text, out num) ? num : -1);
			class2.method_39(int.TryParse(this.textBox_23.Text, out num) ? num : -1);
			class2.method_41(this.textBox_18.Text);
			class2.method_45(this.textBox_21.Text);
			class2.method_43(this.textBox_19.Text);
			class2.method_47((int)this.comboBox_3.SelectedValue);
			class2.method_49((int)this.comboBox_2.SelectedValue);
			class2.method_51((int)this.comboBox_1.SelectedValue);
			this.dsDocuments_0.tP_Act_RepairTransf.method_0(class2);
			base.InsertSqlDataOneRow(this.dsDocuments_0, this.dsDocuments_0.tP_Act_RepairTransf);
		}

		private void method_19()
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_DocList, true, "WHERE Id = " + base.IdDocList.ToString());
			if (this.dsDocuments_0.tP_DocList.Rows.Count <= 0)
			{
				return;
			}
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_Act_RepairTransf, true, "WHERE IdPasspDocList = " + base.IdDocList.ToString());
			if (this.dsDocuments_0.tP_Act_RepairTransf.Rows.Count <= 0)
			{
				return;
			}
			dsDocuments.Class158 @class = (dsDocuments.Class158)this.dsDocuments_0.tP_DocList.Rows[0];
			base.IdObjList = @class.method_2();
			base.IdDocList = @class.Int32_0;
			@class.method_5(this.dateTimePicker_1.Value);
			@class.method_7("");
			@class.method_9(base.method_6("Акт приемки из капитального ремонта трансформатора", ";TypeDoc;tPassport;Transf;Act;Repair;"));
			base.UpdateSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_DocList);
			dsDocuments.Class165 class2 = (dsDocuments.Class165)this.dsDocuments_0.tP_Act_RepairTransf.Rows[0];
			class2.method_3((int)this.comboBox_0.SelectedValue);
			class2.method_5(this.dateTimePicker_0.Value);
			int num;
			class2.method_7(int.TryParse(this.textBox_17.Text, out num) ? num : -1);
			class2.method_9(int.TryParse(this.textBox_16.Text, out num) ? num : -1);
			class2.method_11(this.dateTimePicker_2.Value);
			class2.method_13(this.dateTimePicker_3.Value);
			class2.method_15(this.textBox_15.Text);
			class2.method_17(this.textBox_14.Text);
			class2.method_19(this.textBox_13.Text);
			class2.method_21(int.TryParse(this.textBox_12.Text, out num) ? num : -1);
			class2.method_23(int.TryParse(this.textBox_11.Text, out num) ? num : -1);
			class2.method_25(int.TryParse(this.textBox_10.Text, out num) ? num : -1);
			class2.method_27(int.TryParse(this.textBox_9.Text, out num) ? num : -1);
			class2.method_29(int.TryParse(this.textBox_8.Text, out num) ? num : -1);
			class2.method_31(int.TryParse(this.textBox_7.Text, out num) ? num : -1);
			class2.method_33(this.textBox_6.Text);
			class2.method_35(this.textBox_20.Text);
			class2.method_37(int.TryParse(this.textBox_22.Text, out num) ? num : -1);
			class2.method_39(int.TryParse(this.textBox_23.Text, out num) ? num : -1);
			class2.method_41(this.textBox_18.Text);
			class2.method_45(this.textBox_21.Text);
			class2.method_43(this.textBox_19.Text);
			class2.method_47((int)this.comboBox_3.SelectedValue);
			class2.method_49((int)this.comboBox_2.SelectedValue);
			class2.method_51((int)this.comboBox_1.SelectedValue);
			base.UpdateSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_Act_RepairTransf);
		}

		private void method_20()
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vP_Transf_ActRepairTransf, true, "WHERE idObjList = " + base.IdObjList.ToString());
			if (this.dsDocuments_0.vP_Transf_ActRepairTransf.Rows.Count > 0)
			{
				dsDocuments.Class163 @class = (dsDocuments.Class163)this.dsDocuments_0.vP_Transf_ActRepairTransf.Rows[0];
				this.textBox_5.Text = @class.method_2();
				this.textBox_4.Text = @class.method_4();
				this.textBox_3.Text = @class.Voltage;
				this.textBox_2.Text = @class.method_6();
				this.textBox_1.Text = @class.method_8();
				this.textBox_0.Text = @class.method_10();
			}
		}

		private void method_21(int int_2)
		{
			foreach (dsDocuments.Class159 @class in this.dsDocuments_0.tP_Protocols)
			{
				if (@class.method_0() == -1)
				{
					@class.method_1(int_2);
				}
			}
			base.InsertSqlDataTableOther(this.dsDocuments_0, this.dsDocuments_0.tP_Protocols, "tP_DocList");
			base.UpdateSqlDataTableOther(this.dsDocuments_0, this.dsDocuments_0.tP_Protocols, "tP_DocList");
		}

		private void textBox_22_KeyPress(object sender, KeyPressEventArgs e)
		{
			base.method_7(sender, e);
		}

		private void button_4_Click(object sender, EventArgs e)
		{
			new FormAddActRepairTransfProtocol
			{
				SqlSettings = this.SqlSettings,
				IdObjList = base.IdObjList,
				ProtocolsDataTable = this.dsDocuments_0.tP_Protocols,
				FormCreate = 0
			}.ShowDialog();
			this.dataGridView_0.DataSource = this.dsDocuments_0.tP_Protocols;
		}

		private void button_3_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0)
			{
				dsDocuments.Class159 @class = this.method_16((DateTime)this.dataGridView_0.SelectedRows[0].Cells["dateDocDataGridViewTextBoxColumn"].Value, this.dataGridView_0.SelectedRows[0].Cells["numberDocDataGridViewTextBoxColumn"].Value.ToString());
				if (@class == null)
				{
					return;
				}
				new FormAddActRepairTransfProtocol
				{
					SqlSettings = this.SqlSettings,
					IdObjList = base.IdObjList,
					ProtocolsRow = @class,
					FormCreate = 1
				}.ShowDialog();
				this.dataGridView_0.DataSource = this.dsDocuments_0.tP_Protocols;
			}
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				int num;
				if (int.TryParse(this.dataGridView_0.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value.ToString(), out num))
				{
					base.SelectSqlDataTableOther(this.dsDocuments_0, this.dsDocuments_0.tP_ProtocolsDelete, "tP_DocList", true, string.Format("WHERE Id = {0}", num));
					if (this.dsDocuments_0.tP_ProtocolsDelete.Rows.Count > 0)
					{
						this.dsDocuments_0.tP_ProtocolsDelete[0].method_13(true);
						base.UpdateSqlDataTableOther(this.dsDocuments_0, this.dsDocuments_0.tP_ProtocolsDelete, "tP_DocList");
					}
				}
				dsDocuments.Class159 @class = this.method_16((DateTime)this.dataGridView_0.SelectedRows[0].Cells["dateDocDataGridViewTextBoxColumn"].Value, this.dataGridView_0.SelectedRows[0].Cells["numberDocDataGridViewTextBoxColumn"].Value.ToString());
				if (@class != null)
				{
					@class.Delete();
				}
				this.dataGridView_0.DataSource = this.dsDocuments_0.tP_Protocols;
			}
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			StateFormCreate stateFormCreate = this.stateFormCreate_1;
			if (stateFormCreate != null)
			{
				if (stateFormCreate != 1)
				{
					if (stateFormCreate == 7)
					{
						this.method_17();
					}
				}
				else
				{
					this.method_19();
					this.method_21(base.IdDocList);
				}
			}
			else
			{
				this.method_18();
				this.method_21(base.IdDocList);
			}
			base.Close();
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void textBox_14_KeyPress(object sender, KeyPressEventArgs e)
		{
			base.method_8(sender, e, 42);
		}

		private void textBox_6_KeyPress(object sender, KeyPressEventArgs e)
		{
			base.method_8(sender, e, 395);
		}

		private void textBox_20_KeyPress(object sender, KeyPressEventArgs e)
		{
			base.method_8(sender, e, 195);
		}

		private void textBox_18_KeyPress(object sender, KeyPressEventArgs e)
		{
			base.method_8(sender, e, 60);
		}

		private void textBox_19_KeyPress(object sender, KeyPressEventArgs e)
		{
			base.method_8(sender, e, 395);
		}

		private void textBox_21_KeyPress(object sender, KeyPressEventArgs e)
		{
			base.method_8(sender, e, 395);
		}

		private void textBox_15_KeyPress(object sender, KeyPressEventArgs e)
		{
			base.method_8(sender, e, 75);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_1 != null)
			{
				this.icontainer_1.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_22()
		{
			this.icontainer_1 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.tabControl_0 = new TabControl();
			this.tabPage_0 = new TabPage();
			this.textBox_6 = new TextBox();
			this.label_10 = new Label();
			this.label_11 = new Label();
			this.label_12 = new Label();
			this.textBox_7 = new TextBox();
			this.label_13 = new Label();
			this.textBox_8 = new TextBox();
			this.label_14 = new Label();
			this.label_15 = new Label();
			this.textBox_9 = new TextBox();
			this.label_16 = new Label();
			this.textBox_10 = new TextBox();
			this.label_17 = new Label();
			this.label_18 = new Label();
			this.textBox_11 = new TextBox();
			this.label_19 = new Label();
			this.textBox_12 = new TextBox();
			this.label_20 = new Label();
			this.textBox_13 = new TextBox();
			this.label_21 = new Label();
			this.label_22 = new Label();
			this.textBox_14 = new TextBox();
			this.label_23 = new Label();
			this.textBox_15 = new TextBox();
			this.label_24 = new Label();
			this.label_25 = new Label();
			this.dateTimePicker_2 = new DateTimePicker();
			this.dateTimePicker_3 = new DateTimePicker();
			this.label_26 = new Label();
			this.label_27 = new Label();
			this.textBox_16 = new TextBox();
			this.label_28 = new Label();
			this.textBox_17 = new TextBox();
			this.label_29 = new Label();
			this.label_3 = new Label();
			this.label_4 = new Label();
			this.textBox_0 = new TextBox();
			this.label_5 = new Label();
			this.textBox_1 = new TextBox();
			this.textBox_2 = new TextBox();
			this.label_6 = new Label();
			this.textBox_3 = new TextBox();
			this.label_7 = new Label();
			this.textBox_4 = new TextBox();
			this.label_8 = new Label();
			this.label_9 = new Label();
			this.textBox_5 = new TextBox();
			this.dateTimePicker_0 = new DateTimePicker();
			this.label_0 = new Label();
			this.dateTimePicker_1 = new DateTimePicker();
			this.label_1 = new Label();
			this.comboBox_0 = new ComboBox();
			this.label_2 = new Label();
			this.tabPage_1 = new TabPage();
			this.label_42 = new Label();
			this.label_43 = new Label();
			this.textBox_23 = new TextBox();
			this.label_39 = new Label();
			this.label_40 = new Label();
			this.textBox_22 = new TextBox();
			this.label_41 = new Label();
			this.comboBox_1 = new ComboBox();
			this.comboBox_2 = new ComboBox();
			this.comboBox_3 = new ComboBox();
			this.button_2 = new Button();
			this.button_3 = new Button();
			this.button_4 = new Button();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.bindingSource_0 = new BindingSource(this.icontainer_1);
			this.dsDocuments_1 = new dsDocuments();
			this.label_35 = new Label();
			this.label_36 = new Label();
			this.textBox_21 = new TextBox();
			this.label_37 = new Label();
			this.label_38 = new Label();
			this.textBox_18 = new TextBox();
			this.textBox_19 = new TextBox();
			this.label_30 = new Label();
			this.label_31 = new Label();
			this.label_32 = new Label();
			this.textBox_20 = new TextBox();
			this.label_33 = new Label();
			this.label_34 = new Label();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.tableLayoutPanel_0.SuspendLayout();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.tabPage_1.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dsDocuments_1).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121f));
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.button_1, 1, 1);
			this.tableLayoutPanel_0.Controls.Add(this.tabControl_0, 0, 0);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tlpGeneral";
			this.tableLayoutPanel_0.RowCount = 2;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 42f));
			this.tableLayoutPanel_0.Size = new Size(673, 562);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.button_0.Dock = DockStyle.Right;
			this.button_0.Location = new Point(454, 527);
			this.button_0.Margin = new Padding(3, 7, 7, 10);
			this.button_0.Name = "btnSave";
			this.button_0.Size = new Size(91, 25);
			this.button_0.TabIndex = 30;
			this.button_0.Text = "Сохранить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Dock = DockStyle.Left;
			this.button_1.Location = new Point(557, 527);
			this.button_1.Margin = new Padding(5, 7, 3, 10);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 25);
			this.button_1.TabIndex = 31;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.tableLayoutPanel_0.SetColumnSpan(this.tabControl_0, 2);
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Dock = DockStyle.Fill;
			this.tabControl_0.Location = new Point(3, 3);
			this.tabControl_0.Name = "tcGeneral";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(667, 514);
			this.tabControl_0.TabIndex = 2;
			this.tabPage_0.Controls.Add(this.textBox_6);
			this.tabPage_0.Controls.Add(this.label_10);
			this.tabPage_0.Controls.Add(this.label_11);
			this.tabPage_0.Controls.Add(this.label_12);
			this.tabPage_0.Controls.Add(this.textBox_7);
			this.tabPage_0.Controls.Add(this.label_13);
			this.tabPage_0.Controls.Add(this.textBox_8);
			this.tabPage_0.Controls.Add(this.label_14);
			this.tabPage_0.Controls.Add(this.label_15);
			this.tabPage_0.Controls.Add(this.textBox_9);
			this.tabPage_0.Controls.Add(this.label_16);
			this.tabPage_0.Controls.Add(this.textBox_10);
			this.tabPage_0.Controls.Add(this.label_17);
			this.tabPage_0.Controls.Add(this.label_18);
			this.tabPage_0.Controls.Add(this.textBox_11);
			this.tabPage_0.Controls.Add(this.label_19);
			this.tabPage_0.Controls.Add(this.textBox_12);
			this.tabPage_0.Controls.Add(this.label_20);
			this.tabPage_0.Controls.Add(this.textBox_13);
			this.tabPage_0.Controls.Add(this.label_21);
			this.tabPage_0.Controls.Add(this.label_22);
			this.tabPage_0.Controls.Add(this.textBox_14);
			this.tabPage_0.Controls.Add(this.label_23);
			this.tabPage_0.Controls.Add(this.textBox_15);
			this.tabPage_0.Controls.Add(this.label_24);
			this.tabPage_0.Controls.Add(this.label_25);
			this.tabPage_0.Controls.Add(this.dateTimePicker_2);
			this.tabPage_0.Controls.Add(this.dateTimePicker_3);
			this.tabPage_0.Controls.Add(this.label_26);
			this.tabPage_0.Controls.Add(this.label_27);
			this.tabPage_0.Controls.Add(this.textBox_16);
			this.tabPage_0.Controls.Add(this.label_28);
			this.tabPage_0.Controls.Add(this.textBox_17);
			this.tabPage_0.Controls.Add(this.label_29);
			this.tabPage_0.Controls.Add(this.label_3);
			this.tabPage_0.Controls.Add(this.label_4);
			this.tabPage_0.Controls.Add(this.textBox_0);
			this.tabPage_0.Controls.Add(this.label_5);
			this.tabPage_0.Controls.Add(this.textBox_1);
			this.tabPage_0.Controls.Add(this.textBox_2);
			this.tabPage_0.Controls.Add(this.label_6);
			this.tabPage_0.Controls.Add(this.textBox_3);
			this.tabPage_0.Controls.Add(this.label_7);
			this.tabPage_0.Controls.Add(this.textBox_4);
			this.tabPage_0.Controls.Add(this.label_8);
			this.tabPage_0.Controls.Add(this.label_9);
			this.tabPage_0.Controls.Add(this.textBox_5);
			this.tabPage_0.Controls.Add(this.dateTimePicker_0);
			this.tabPage_0.Controls.Add(this.label_0);
			this.tabPage_0.Controls.Add(this.dateTimePicker_1);
			this.tabPage_0.Controls.Add(this.label_1);
			this.tabPage_0.Controls.Add(this.comboBox_0);
			this.tabPage_0.Controls.Add(this.label_2);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tabPage1";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(659, 488);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Страница 1";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.textBox_6.Location = new Point(18, 386);
			this.textBox_6.Multiline = true;
			this.textBox_6.Name = "tbWorkList";
			this.textBox_6.Size = new Size(625, 58);
			this.textBox_6.TabIndex = 17;
			this.textBox_6.KeyPress += this.textBox_6_KeyPress;
			this.label_10.AutoSize = true;
			this.label_10.Location = new Point(19, 361);
			this.label_10.Name = "label29";
			this.label_10.Size = new Size(77, 13);
			this.label_10.TabIndex = 51;
			this.label_10.Text = "при ремонте):";
			this.label_11.AutoSize = true;
			this.label_11.Location = new Point(19, 337);
			this.label_11.Name = "label28";
			this.label_11.Size = new Size(604, 13);
			this.label_11.TabIndex = 50;
			this.label_11.Text = "При ремонте трансформатора были проведены следующие работы (дается перечень основных работ, выполненных ";
			this.label_12.AutoSize = true;
			this.label_12.Location = new Point(605, 312);
			this.label_12.Name = "label25";
			this.label_12.Size = new Size(38, 13);
			this.label_12.TabIndex = 49;
			this.label_12.Text = "чел.-ч.";
			this.textBox_7.Location = new Point(446, 309);
			this.textBox_7.Name = "tbPlanMenHour";
			this.textBox_7.Size = new Size(153, 20);
			this.textBox_7.TabIndex = 16;
			this.textBox_7.KeyPress += this.textBox_22_KeyPress;
			this.label_13.AutoSize = true;
			this.label_13.Location = new Point(331, 311);
			this.label_13.Name = "label26";
			this.label_13.Size = new Size(109, 13);
			this.label_13.TabIndex = 47;
			this.label_13.Text = "чел.-ч. против плана";
			this.textBox_8.Location = new Point(170, 309);
			this.textBox_8.Name = "tbMenHour";
			this.textBox_8.Size = new Size(155, 20);
			this.textBox_8.TabIndex = 15;
			this.textBox_8.KeyPress += this.textBox_22_KeyPress;
			this.label_14.AutoSize = true;
			this.label_14.Location = new Point(19, 311);
			this.label_14.Name = "label27";
			this.label_14.Size = new Size(145, 13);
			this.label_14.TabIndex = 45;
			this.label_14.Text = "На ремонт было затрачено";
			this.label_15.AutoSize = true;
			this.label_15.Location = new Point(540, 286);
			this.label_15.Name = "label24";
			this.label_15.Size = new Size(106, 13);
			this.label_15.TabIndex = 44;
			this.label_15.Text = "календарных часов";
			this.textBox_9.Location = new Point(434, 283);
			this.textBox_9.Name = "tbPlanHour";
			this.textBox_9.Size = new Size(100, 20);
			this.textBox_9.TabIndex = 14;
			this.textBox_9.KeyPress += this.textBox_22_KeyPress;
			this.label_16.AutoSize = true;
			this.label_16.Location = new Point(247, 286);
			this.label_16.Name = "label23";
			this.label_16.Size = new Size(177, 13);
			this.label_16.TabIndex = 42;
			this.label_16.Text = "календарных часов против плана";
			this.textBox_10.Location = new Point(141, 283);
			this.textBox_10.Name = "tbFactHour";
			this.textBox_10.Size = new Size(100, 20);
			this.textBox_10.TabIndex = 13;
			this.textBox_10.KeyPress += this.textBox_22_KeyPress;
			this.label_17.AutoSize = true;
			this.label_17.Location = new Point(19, 286);
			this.label_17.Name = "label22";
			this.label_17.Size = new Size(116, 13);
			this.label_17.TabIndex = 40;
			this.label_17.Text = "Ремонт выполнен за ";
			this.label_18.AutoSize = true;
			this.label_18.Location = new Point(615, 260);
			this.label_18.Name = "label21";
			this.label_18.Size = new Size(18, 13);
			this.label_18.TabIndex = 39;
			this.label_18.Text = "ч. ";
			this.textBox_11.Location = new Point(552, 257);
			this.textBox_11.Name = "tbInnerOil";
			this.textBox_11.Size = new Size(57, 20);
			this.textBox_11.TabIndex = 12;
			this.label_19.AutoSize = true;
			this.label_19.Location = new Point(487, 260);
			this.label_19.Name = "label20";
			this.label_19.Size = new Size(59, 13);
			this.label_19.TabIndex = 37;
			this.label_19.Text = "ч. в масле";
			this.textBox_12.Location = new Point(424, 257);
			this.textBox_12.Name = "tbInnerAir";
			this.textBox_12.Size = new Size(57, 20);
			this.textBox_12.TabIndex = 11;
			this.textBox_12.KeyPress += this.textBox_22_KeyPress;
			this.label_20.AutoSize = true;
			this.label_20.Location = new Point(19, 260);
			this.label_20.Name = "label19";
			this.label_20.Size = new Size(402, 13);
			this.label_20.TabIndex = 35;
			this.label_20.Text = "За время ремонта внутренняя часть трансформатора находилась на воздухе";
			this.textBox_13.Location = new Point(193, 231);
			this.textBox_13.Name = "tbWeather";
			this.textBox_13.Size = new Size(450, 20);
			this.textBox_13.TabIndex = 10;
			this.label_21.AutoSize = true;
			this.label_21.Location = new Point(19, 234);
			this.label_21.Name = "label18";
			this.label_21.Size = new Size(168, 13);
			this.label_21.TabIndex = 33;
			this.label_21.Text = "За время ремонта была погода";
			this.label_22.AutoSize = true;
			this.label_22.Location = new Point(309, 130);
			this.label_22.Name = "label17";
			this.label_22.Size = new Size(24, 13);
			this.label_22.TabIndex = 32;
			this.label_22.Text = "лет";
			this.textBox_14.Location = new Point(291, 205);
			this.textBox_14.Name = "tbRequirementWH";
			this.textBox_14.Size = new Size(352, 20);
			this.textBox_14.TabIndex = 9;
			this.textBox_14.KeyPress += this.textBox_14_KeyPress;
			this.label_23.AutoSize = true;
			this.label_23.Location = new Point(16, 206);
			this.label_23.Name = "label16";
			this.label_23.Size = new Size(276, 13);
			this.label_23.TabIndex = 30;
			this.label_23.Text = "вполне удовлетворяющем слудующим требованиям:";
			this.textBox_15.Location = new Point(199, 179);
			this.textBox_15.Name = "tbWarehouse";
			this.textBox_15.Size = new Size(444, 20);
			this.textBox_15.TabIndex = 8;
			this.textBox_15.KeyPress += this.textBox_15_KeyPress;
			this.label_24.AutoSize = true;
			this.label_24.Location = new Point(16, 182);
			this.label_24.Name = "label15";
			this.label_24.Size = new Size(179, 13);
			this.label_24.TabIndex = 28;
			this.label_24.Text = "Ремонт проводился в помещении";
			this.label_25.AutoSize = true;
			this.label_25.Location = new Point(396, 156);
			this.label_25.Name = "label14";
			this.label_25.Size = new Size(19, 13);
			this.label_25.TabIndex = 27;
			this.label_25.Text = "по";
			this.dateTimePicker_2.Location = new Point(184, 153);
			this.dateTimePicker_2.Name = "dtpDateBegRepair";
			this.dateTimePicker_2.Size = new Size(206, 20);
			this.dateTimePicker_2.TabIndex = 6;
			this.dateTimePicker_3.Location = new Point(421, 153);
			this.dateTimePicker_3.Name = "dtpDateEndRepair";
			this.dateTimePicker_3.Size = new Size(222, 20);
			this.dateTimePicker_3.TabIndex = 7;
			this.label_26.AutoSize = true;
			this.label_26.Location = new Point(16, 156);
			this.label_26.Name = "label13";
			this.label_26.Size = new Size(157, 13);
			this.label_26.TabIndex = 24;
			this.label_26.Text = "Ремонт выполнен за время с";
			this.label_27.AutoSize = true;
			this.label_27.Location = new Point(486, 104);
			this.label_27.Name = "label12";
			this.label_27.Size = new Size(30, 13);
			this.label_27.TabIndex = 23;
			this.label_27.Text = "лет, ";
			this.textBox_16.Location = new Point(243, 127);
			this.textBox_16.Name = "tbWorkFromRepair";
			this.textBox_16.Size = new Size(60, 20);
			this.textBox_16.TabIndex = 5;
			this.textBox_16.KeyPress += this.textBox_22_KeyPress;
			this.label_28.AutoSize = true;
			this.label_28.Location = new Point(16, 130);
			this.label_28.Name = "label11";
			this.label_28.Size = new Size(225, 13);
			this.label_28.TabIndex = 21;
			this.label_28.Text = "с момента окончания последнего ремонта";
			this.textBox_17.Location = new Point(418, 101);
			this.textBox_17.Name = "tbWorkFromExpl";
			this.textBox_17.Size = new Size(60, 20);
			this.textBox_17.TabIndex = 4;
			this.textBox_17.KeyPress += this.textBox_22_KeyPress;
			this.label_29.AutoSize = true;
			this.label_29.Location = new Point(16, 104);
			this.label_29.Name = "label10";
			this.label_29.Size = new Size(396, 13);
			this.label_29.TabIndex = 19;
			this.label_29.Text = "Трансформатор проработал с начала эксплуатации до настоящего ремонта";
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(620, 49);
			this.label_3.Name = "label9";
			this.label_3.Size = new Size(20, 13);
			this.label_3.TabIndex = 18;
			this.label_3.Text = "кВ";
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(458, 75);
			this.label_4.Name = "label8";
			this.label_4.Size = new Size(76, 13);
			this.label_4.TabIndex = 17;
			this.label_4.Text = "Заводской №";
			this.textBox_0.Location = new Point(540, 72);
			this.textBox_0.Name = "tbSerNumber";
			this.textBox_0.Size = new Size(103, 20);
			this.textBox_0.TabIndex = 16;
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(172, 75);
			this.label_5.Name = "label7";
			this.label_5.Size = new Size(110, 13);
			this.label_5.TabIndex = 15;
			this.label_5.Text = "Завод-изготовитель";
			this.textBox_1.Location = new Point(288, 72);
			this.textBox_1.Name = "tbBuilder";
			this.textBox_1.Size = new Size(159, 20);
			this.textBox_1.TabIndex = 14;
			this.textBox_2.Location = new Point(48, 72);
			this.textBox_2.Name = "tbTypeTrans";
			this.textBox_2.Size = new Size(118, 20);
			this.textBox_2.TabIndex = 13;
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(16, 75);
			this.label_6.Name = "label6";
			this.label_6.Size = new Size(26, 13);
			this.label_6.TabIndex = 12;
			this.label_6.Text = "Тип";
			this.textBox_3.Location = new Point(540, 46);
			this.textBox_3.Name = "tbVoltage";
			this.textBox_3.Size = new Size(74, 20);
			this.textBox_3.TabIndex = 11;
			this.label_7.AutoSize = true;
			this.label_7.Location = new Point(463, 49);
			this.label_7.Name = "label5";
			this.label_7.Size = new Size(71, 13);
			this.label_7.TabIndex = 10;
			this.label_7.Text = "Напряжение";
			this.textBox_4.Location = new Point(309, 46);
			this.textBox_4.Name = "tbInvNumber";
			this.textBox_4.Size = new Size(138, 20);
			this.textBox_4.TabIndex = 9;
			this.label_8.AutoSize = true;
			this.label_8.Location = new Point(172, 49);
			this.label_8.Name = "label4";
			this.label_8.Size = new Size(131, 13);
			this.label_8.TabIndex = 8;
			this.label_8.Text = "кВА       Инвентарный №";
			this.label_9.AutoSize = true;
			this.label_9.Location = new Point(16, 49);
			this.label_9.Name = "label3";
			this.label_9.Size = new Size(60, 13);
			this.label_9.TabIndex = 7;
			this.label_9.Text = "Мощность";
			this.textBox_5.Location = new Point(82, 46);
			this.textBox_5.Name = "tbPower";
			this.textBox_5.Size = new Size(84, 20);
			this.textBox_5.TabIndex = 6;
			this.dateTimePicker_0.Location = new Point(522, 11);
			this.dateTimePicker_0.Name = "dtpDateApproval";
			this.dateTimePicker_0.Size = new Size(121, 20);
			this.dateTimePicker_0.TabIndex = 3;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(446, 14);
			this.label_0.Name = "label2";
			this.label_0.Size = new Size(64, 13);
			this.label_0.TabIndex = 4;
			this.label_0.Text = "Утвержден";
			this.dateTimePicker_1.Location = new Point(301, 11);
			this.dateTimePicker_1.Name = "dtpDateMade";
			this.dateTimePicker_1.Size = new Size(121, 20);
			this.dateTimePicker_1.TabIndex = 2;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(231, 14);
			this.label_1.Name = "label1";
			this.label_1.Size = new Size(61, 13);
			this.label_1.TabIndex = 2;
			this.label_1.Text = "Составлен";
			this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(96, 10);
			this.comboBox_0.Name = "cbCompany";
			this.comboBox_0.Size = new Size(121, 21);
			this.comboBox_0.TabIndex = 1;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(16, 13);
			this.label_2.Name = "lbCompany";
			this.label_2.Size = new Size(74, 13);
			this.label_2.TabIndex = 0;
			this.label_2.Text = "Предприятие";
			this.tabPage_1.Controls.Add(this.label_42);
			this.tabPage_1.Controls.Add(this.label_43);
			this.tabPage_1.Controls.Add(this.textBox_23);
			this.tabPage_1.Controls.Add(this.label_39);
			this.tabPage_1.Controls.Add(this.label_40);
			this.tabPage_1.Controls.Add(this.textBox_22);
			this.tabPage_1.Controls.Add(this.label_41);
			this.tabPage_1.Controls.Add(this.comboBox_1);
			this.tabPage_1.Controls.Add(this.comboBox_2);
			this.tabPage_1.Controls.Add(this.comboBox_3);
			this.tabPage_1.Controls.Add(this.button_2);
			this.tabPage_1.Controls.Add(this.button_3);
			this.tabPage_1.Controls.Add(this.button_4);
			this.tabPage_1.Controls.Add(this.dataGridView_0);
			this.tabPage_1.Controls.Add(this.label_35);
			this.tabPage_1.Controls.Add(this.label_36);
			this.tabPage_1.Controls.Add(this.textBox_21);
			this.tabPage_1.Controls.Add(this.label_37);
			this.tabPage_1.Controls.Add(this.label_38);
			this.tabPage_1.Controls.Add(this.textBox_18);
			this.tabPage_1.Controls.Add(this.textBox_19);
			this.tabPage_1.Controls.Add(this.label_30);
			this.tabPage_1.Controls.Add(this.label_31);
			this.tabPage_1.Controls.Add(this.label_32);
			this.tabPage_1.Controls.Add(this.textBox_20);
			this.tabPage_1.Controls.Add(this.label_33);
			this.tabPage_1.Controls.Add(this.label_34);
			this.tabPage_1.Location = new Point(4, 22);
			this.tabPage_1.Name = "tabPage2";
			this.tabPage_1.Padding = new Padding(3);
			this.tabPage_1.Size = new Size(659, 488);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "Страница 2";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.label_42.AutoSize = true;
			this.label_42.Location = new Point(176, 207);
			this.label_42.Name = "label42";
			this.label_42.Size = new Size(97, 13);
			this.label_42.TabIndex = 82;
			this.label_42.Text = "кВА установлено:";
			this.label_43.AutoSize = true;
			this.label_43.Location = new Point(17, 207);
			this.label_43.Name = "label43";
			this.label_43.Size = new Size(83, 13);
			this.label_43.TabIndex = 81;
			this.label_43.Text = "и при нагрузке";
			this.textBox_23.Location = new Point(103, 204);
			this.textBox_23.Name = "tbWorkLoadHour";
			this.textBox_23.Size = new Size(67, 20);
			this.textBox_23.TabIndex = 3;
			this.textBox_23.KeyPress += this.textBox_22_KeyPress;
			this.label_39.AutoSize = true;
			this.label_39.Location = new Point(155, 181);
			this.label_39.Name = "label41";
			this.label_39.Size = new Size(15, 13);
			this.label_39.TabIndex = 79;
			this.label_39.Text = "ч.";
			this.label_40.AutoSize = true;
			this.label_40.Location = new Point(17, 181);
			this.label_40.Name = "label40";
			this.label_40.Size = new Size(59, 13);
			this.label_40.TabIndex = 78;
			this.label_40.Text = " в течение";
			this.textBox_22.Location = new Point(82, 178);
			this.textBox_22.Name = "tbWorkHour";
			this.textBox_22.Size = new Size(67, 20);
			this.textBox_22.TabIndex = 22;
			this.textBox_22.KeyPress += this.textBox_22_KeyPress;
			this.label_41.AutoSize = true;
			this.label_41.Location = new Point(17, 160);
			this.label_41.Name = "label39";
			this.label_41.Size = new Size(327, 13);
			this.label_41.TabIndex = 76;
			this.label_41.Text = "После ремонта трансформатора и наблюдения за его работой";
			this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(341, 460);
			this.comboBox_1.Name = "cbManagerRepair";
			this.comboBox_1.Size = new Size(302, 21);
			this.comboBox_1.TabIndex = 29;
			this.comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_2.FormattingEnabled = true;
			this.comboBox_2.Location = new Point(341, 434);
			this.comboBox_2.Name = "cbHeadRepairShop";
			this.comboBox_2.Size = new Size(302, 21);
			this.comboBox_2.TabIndex = 28;
			this.comboBox_3.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_3.FormattingEnabled = true;
			this.comboBox_3.Location = new Point(341, 407);
			this.comboBox_3.Name = "cbHeadPTS";
			this.comboBox_3.Size = new Size(302, 21);
			this.comboBox_3.TabIndex = 27;
			this.button_2.Location = new Point(569, 204);
			this.button_2.Name = "btnDeleteProtocol";
			this.button_2.Size = new Size(74, 23);
			this.button_2.TabIndex = 21;
			this.button_2.Text = "Удалить";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.button_3.Location = new Point(460, 204);
			this.button_3.Name = "btnEditProtocol";
			this.button_3.Size = new Size(102, 23);
			this.button_3.TabIndex = 20;
			this.button_3.Text = "Изменить";
			this.button_3.UseVisualStyleBackColor = true;
			this.button_3.Click += this.button_3_Click;
			this.button_4.Location = new Point(351, 204);
			this.button_4.Name = "btnAddProtocol";
			this.button_4.Size = new Size(102, 23);
			this.button_4.TabIndex = 19;
			this.button_4.Text = "Добавить";
			this.button_4.UseVisualStyleBackColor = true;
			this.button_4.Click += this.button_4_Click;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.AllowUserToOrderColumns = true;
			this.dataGridView_0.AllowUserToResizeRows = false;
			this.dataGridView_0.AutoGenerateColumns = false;
			this.dataGridView_0.BackgroundColor = Color.White;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_0,
				this.dataGridViewCheckBoxColumn_1,
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5
			});
			this.dataGridView_0.DataSource = this.bindingSource_0;
			this.dataGridView_0.Location = new Point(351, 104);
			this.dataGridView_0.MultiSelect = false;
			this.dataGridView_0.Name = "dgvProtocols";
			this.dataGridView_0.ReadOnly = true;
			this.dataGridView_0.RowHeadersVisible = false;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(292, 94);
			this.dataGridView_0.TabIndex = 69;
			this.dataGridViewCheckBoxColumn_0.DataPropertyName = "isActive";
			this.dataGridViewCheckBoxColumn_0.HeaderText = "isActive";
			this.dataGridViewCheckBoxColumn_0.Name = "isActiveDataGridViewCheckBoxColumn";
			this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.Visible = false;
			this.dataGridViewCheckBoxColumn_1.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_1.HeaderText = "Deleted";
			this.dataGridViewCheckBoxColumn_1.Name = "deletedDataGridViewCheckBoxColumn";
			this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "id";
			this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_1.HeaderText = "ParentId";
			this.dataGridViewTextBoxColumn_1.Name = "parentIdDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_2.HeaderText = "idObjList";
			this.dataGridViewTextBoxColumn_2.Name = "idObjListDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "DateDoc";
			this.dataGridViewTextBoxColumn_3.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_3.Name = "dateDocDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "NumberDoc";
			this.dataGridViewTextBoxColumn_4.HeaderText = "Номер";
			this.dataGridViewTextBoxColumn_4.Name = "numberDocDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "TypeDoc";
			this.dataGridViewTextBoxColumn_5.HeaderText = "TypeDoc";
			this.dataGridViewTextBoxColumn_5.Name = "typeDocDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.bindingSource_0.DataMember = "tP_Protocols";
			this.bindingSource_0.DataSource = this.dsDocuments_1;
			this.dsDocuments_1.DataSetName = "dsDocuments";
			this.dsDocuments_1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.label_35.AutoSize = true;
			this.label_35.Location = new Point(15, 463);
			this.label_35.Name = "label38";
			this.label_35.Size = new Size(124, 13);
			this.label_35.TabIndex = 68;
			this.label_35.Text = "Руководитель ремонта";
			this.label_36.AutoSize = true;
			this.label_36.Location = new Point(17, 437);
			this.label_36.Name = "label37";
			this.label_36.Size = new Size(291, 13);
			this.label_36.TabIndex = 67;
			this.label_36.Text = "Начальник ремцеха (подстанции, участка, электросети)";
			this.textBox_21.Location = new Point(18, 352);
			this.textBox_21.Multiline = true;
			this.textBox_21.Name = "tbAdmission";
			this.textBox_21.Size = new Size(625, 46);
			this.textBox_21.TabIndex = 26;
			this.textBox_21.KeyPress += this.textBox_21_KeyPress;
			this.label_37.AutoSize = true;
			this.label_37.Location = new Point(17, 411);
			this.label_37.Name = "label36";
			this.label_37.Size = new Size(87, 13);
			this.label_37.TabIndex = 62;
			this.label_37.Text = "Начальник ПТС";
			this.label_38.AutoSize = true;
			this.label_38.Location = new Point(17, 336);
			this.label_38.Name = "label35";
			this.label_38.Size = new Size(438, 13);
			this.label_38.TabIndex = 61;
			this.label_38.Text = "Трансформатор допускается для нормальной эксплуатации (или с ограничением) с:";
			this.textBox_18.Location = new Point(250, 238);
			this.textBox_18.Name = "tbEvaluetion";
			this.textBox_18.Size = new Size(393, 20);
			this.textBox_18.TabIndex = 24;
			this.textBox_18.KeyPress += this.textBox_18_KeyPress;
			this.textBox_19.Location = new Point(18, 283);
			this.textBox_19.Multiline = true;
			this.textBox_19.Name = "tbConditionTransf";
			this.textBox_19.Size = new Size(625, 50);
			this.textBox_19.TabIndex = 25;
			this.textBox_19.KeyPress += this.textBox_19_KeyPress;
			this.label_30.AutoSize = true;
			this.label_30.Location = new Point(17, 267);
			this.label_30.Name = "label34";
			this.label_30.Size = new Size(229, 13);
			this.label_30.TabIndex = 58;
			this.label_30.Text = "Состояние трансформатора после ремонта";
			this.label_31.AutoSize = true;
			this.label_31.Location = new Point(17, 241);
			this.label_31.Name = "label33";
			this.label_31.Size = new Size(227, 13);
			this.label_31.TabIndex = 57;
			this.label_31.Text = "Произведенный ремонт выполнен (оценка)";
			this.label_32.AutoSize = true;
			this.label_32.Location = new Point(17, 132);
			this.label_32.Name = "label32";
			this.label_32.Size = new Size(276, 13);
			this.label_32.TabIndex = 56;
			this.label_32.Text = "(номера и даты протоколов испытания и измерений)";
			this.textBox_20.Location = new Point(18, 30);
			this.textBox_20.Multiline = true;
			this.textBox_20.Name = "tbNoWorkList";
			this.textBox_20.Size = new Size(625, 68);
			this.textBox_20.TabIndex = 18;
			this.textBox_20.KeyPress += this.textBox_20_KeyPress;
			this.label_33.AutoSize = true;
			this.label_33.Location = new Point(17, 106);
			this.label_33.Name = "label30";
			this.label_33.Size = new Size(328, 13);
			this.label_33.TabIndex = 54;
			this.label_33.Text = "Трансформатор прошел необходимые испытания и измерения";
			this.label_34.AutoSize = true;
			this.label_34.Location = new Point(17, 13);
			this.label_34.Name = "label31";
			this.label_34.Size = new Size(553, 13);
			this.label_34.TabIndex = 53;
			this.label_34.Text = "Не выполнены следующие работы, предусмотренные ведомостью объема работ (причины невыполнения):";
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_6.HeaderText = "id";
			this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_7.HeaderText = "ParentId";
			this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_8.HeaderText = "idObjList";
			this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "DateDoc";
			this.dataGridViewTextBoxColumn_9.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "NumberDoc";
			this.dataGridViewTextBoxColumn_10.HeaderText = "Номер";
			this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "TypeDoc";
			this.dataGridViewTextBoxColumn_11.HeaderText = "TypeDoc";
			this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(673, 562);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormActRepairTransf";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Акт приемки из капитального ремонта трансформатора";
			base.Load += this.FormActRepairTransf_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.tabPage_0.PerformLayout();
			this.tabPage_1.ResumeLayout(false);
			this.tabPage_1.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dsDocuments_1).EndInit();
			base.ResumeLayout(false);
		}

		private StateFormCreate stateFormCreate_1;

		private IContainer icontainer_1;

		private TableLayoutPanel tableLayoutPanel_0;

		private Button button_0;

		private Button button_1;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private DateTimePicker dateTimePicker_0;

		private Label label_0;

		private DateTimePicker dateTimePicker_1;

		private Label label_1;

		private ComboBox comboBox_0;

		private Label label_2;

		private TabPage tabPage_1;

		private Label label_3;

		private Label label_4;

		private TextBox textBox_0;

		private Label label_5;

		private TextBox textBox_1;

		private TextBox textBox_2;

		private Label label_6;

		private TextBox textBox_3;

		private Label label_7;

		private TextBox textBox_4;

		private Label label_8;

		private Label label_9;

		private TextBox textBox_5;

		private TextBox textBox_6;

		private Label label_10;

		private Label label_11;

		private Label label_12;

		private TextBox textBox_7;

		private Label label_13;

		private TextBox textBox_8;

		private Label label_14;

		private Label label_15;

		private TextBox textBox_9;

		private Label label_16;

		private TextBox textBox_10;

		private Label label_17;

		private Label label_18;

		private TextBox textBox_11;

		private Label label_19;

		private TextBox textBox_12;

		private Label label_20;

		private TextBox textBox_13;

		private Label label_21;

		private Label label_22;

		private TextBox textBox_14;

		private Label label_23;

		private TextBox textBox_15;

		private Label label_24;

		private Label label_25;

		private DateTimePicker dateTimePicker_2;

		private DateTimePicker dateTimePicker_3;

		private Label label_26;

		private Label label_27;

		private TextBox textBox_16;

		private Label label_28;

		private TextBox textBox_17;

		private Label label_29;

		private TextBox textBox_18;

		private TextBox textBox_19;

		private Label label_30;

		private Label label_31;

		private Label label_32;

		private TextBox textBox_20;

		private Label label_33;

		private Label label_34;

		private Button button_2;

		private Button button_3;

		private Button button_4;

		private DataGridView dataGridView_0;

		private Label label_35;

		private Label label_36;

		private TextBox textBox_21;

		private Label label_37;

		private Label label_38;

		private ComboBox comboBox_1;

		private ComboBox comboBox_2;

		private ComboBox comboBox_3;

		private Label label_39;

		private Label label_40;

		private TextBox textBox_22;

		private Label label_41;

		private Label label_42;

		private Label label_43;

		private TextBox textBox_23;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		private BindingSource bindingSource_0;

		private dsDocuments dsDocuments_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
	}
}
