using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;

namespace Passport.Forms
{
	public class FormAddEditBuildRepair : FormBase
	{
		public int Id
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public int IdObjList
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		public StateFormCreate StateCreate
		{
			get
			{
				return this.stateFormCreate_0;
			}
			set
			{
				this.stateFormCreate_0 = value;
			}
		}

		public FormAddEditBuildRepair()
		{
			Class330.Mus9JxKz1CNxy();
			this.int_0 = -1;
			this.int_1 = -1;
			base..ctor();
			this.method_5();
		}

		public FormAddEditBuildRepair(SQLSettings settings, int id, StateFormCreate state)
		{
			Class330.Mus9JxKz1CNxy();
			this.int_0 = -1;
			this.int_1 = -1;
			base..ctor();
			this.method_5();
			this.SqlSettings = settings;
			this.stateFormCreate_0 = state;
			base.DialogResult = DialogResult.OK;
			this.method_0();
			if (state == null)
			{
				this.int_1 = id;
				this.Text = "Добавление";
				return;
			}
			if (state != 1)
			{
				return;
			}
			this.int_0 = id;
			this.Text = "Редактирование";
			base.SelectSqlData(this.class107_0, this.class107_0.tP_BuildSubsRepair, true, "WHERE id = " + id.ToString());
			this.bindingSource_0.Position = this.bindingSource_0.Find("Id", id);
			this.gxesGotFqF.SelectedItem = Convert.ToInt32(this.class107_0.tP_BuildSubsRepair.Rows[0]["DateFactRepair"]);
			this.uScsmkyOv2.Text = this.class107_0.tP_BuildSubsRepair.Rows[0]["DateFactRepairComm"].ToString();
			this.comboBox_2.SelectedItem = Convert.ToInt32(this.class107_0.tP_BuildSubsRepair.Rows[0]["DateHousetopRepair"].ToString());
			this.textBox_1.Text = this.class107_0.tP_BuildSubsRepair.Rows[0]["DateHousetopRepairComm"].ToString();
			this.comboBox_3.SelectedItem = Convert.ToInt32(this.class107_0.tP_BuildSubsRepair.Rows[0]["DatePlanRepair"].ToString());
			this.textBox_0.Text = this.class107_0.tP_BuildSubsRepair.Rows[0]["DatePlanRepairComm"].ToString();
			this.comboBox_0.SelectedValue = (int)this.class107_0.tP_BuildSubsRepair.Rows[0]["DoorType"];
			this.textBox_2.Text = this.class107_0.tP_BuildSubsRepair.Rows[0]["DoorRepair"].ToString();
			this.textBox_3.Text = this.class107_0.tP_BuildSubsRepair.Rows[0]["OtmostRepair"].ToString();
			this.comboBox_1.SelectedValue = (int)this.class107_0.tP_BuildSubsRepair.Rows[0]["Company"];
			this.textBox_4.Text = this.class107_0.tP_BuildSubsRepair.Rows[0]["Comment"].ToString();
		}

		private void method_0()
		{
			base.SelectSqlData(this.class107_0.tAbn, true, "WHERE TypeAbn IN (207, 230, 231, 614, 683) AND Deleted = ((0))", null, true, 0);
			Class107.Class211 @class = this.class107_0.tAbn.method_5();
			@class.id = -1;
			@class.CodeAbonent = 0;
			@class.TypeAbn = 0;
			@class.idWorker = 0;
			@class.Deleted = false;
			this.class107_0.tAbn.method_0(@class);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = this.class107_0.tAbn;
			bindingSource.Sort = "Name";
			this.comboBox_1.DataSource = bindingSource;
			this.comboBox_1.DisplayMember = "Name";
			this.comboBox_1.ValueMember = "Id";
			base.SelectSqlDataTableOther(this.class107_0, this.class107_0.tP_ValueList, "tP_ValueLists", true, "WHERE ParentKey = ';Param;BuildRepair;DoorsMaterial;' AND isGroup = ((0)) AND Deleted = ((0))");
			BindingSource bindingSource2 = new BindingSource();
			Class107.Class229 class2 = this.class107_0.tP_ValueList.method_5();
			class2.id = -1;
			class2.Name = " ";
			this.class107_0.tP_ValueList.method_0(class2);
			bindingSource2.DataSource = this.class107_0.tP_ValueList;
			bindingSource2.Sort = "Name";
			this.comboBox_0.DataSource = bindingSource2;
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "Id";
			for (int i = DateTime.Now.Year; i > 1950; i--)
			{
				this.gxesGotFqF.Items.Add(i);
				this.comboBox_2.Items.Add(i);
				this.comboBox_3.Items.Add(i);
			}
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			StateFormCreate stateFormCreate = this.stateFormCreate_0;
			if (stateFormCreate == null)
			{
				this.method_1();
				base.DialogResult = DialogResult.OK;
				base.Close();
				return;
			}
			if (stateFormCreate != 1)
			{
				return;
			}
			this.method_2();
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		private void method_1()
		{
			Class107.Class248 @class = this.class107_0.tP_DocList.method_5();
			@class.idObjList = this.int_1;
			@class.DateDoc = DateTime.Now;
			@class.NumberDoc = "";
			this.class107_0.tP_DocList.method_0(@class);
			int idDocList = base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_DocList);
			Class107.Class254 class2 = this.class107_0.tP_BuildSubsRepair.method_5();
			class2.idDocList = idDocList;
			class2.DateFactRepair = this.gxesGotFqF.Text;
			class2.DateFactRepairComm = this.uScsmkyOv2.Text;
			class2.DateHousetopRepair = this.comboBox_2.Text;
			class2.DateHousetopRepairComm = this.textBox_1.Text;
			class2.DatePlanRepair = this.comboBox_3.Text;
			class2.DatePlanRepairComm = this.textBox_0.Text;
			class2.DoorType = ((this.comboBox_0.SelectedValue == null) ? -1 : ((int)this.comboBox_0.SelectedValue));
			class2.DoorRepair = this.textBox_2.Text;
			class2.OtmostRepair = this.textBox_3.Text;
			class2.Company = ((this.comboBox_1.SelectedValue == null) ? -1 : ((int)this.comboBox_1.SelectedValue));
			class2.Comment = this.textBox_4.Text;
			class2.Deleted = false;
			this.class107_0.tP_BuildSubsRepair.method_0(class2);
			this.int_0 = base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_BuildSubsRepair);
		}

		private void method_2()
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_BuildSubsRepair, true, "WHERE id = " + this.int_0.ToString());
			this.bindingSource_0.Position = this.bindingSource_0.Find("Id", this.int_0);
			DataRow dataRow = this.class107_0.tP_BuildSubsRepair.Rows[0];
			dataRow["DateFactRepair"] = this.gxesGotFqF.Text;
			dataRow["DateFactRepairComm"] = this.uScsmkyOv2.Text;
			dataRow["DateHousetopRepair"] = this.comboBox_2.Text;
			dataRow["DateHousetopRepairComm"] = this.textBox_1.Text;
			dataRow["DatePlanRepair"] = this.comboBox_3.Text;
			dataRow["DatePlanRepairComm"] = this.textBox_0.Text;
			dataRow["DoorType"] = ((this.comboBox_0.SelectedValue == null) ? -1 : ((int)this.comboBox_0.SelectedValue));
			dataRow["DoorRepair"] = this.textBox_2.Text;
			dataRow["OtmostRepair"] = this.textBox_3.Text;
			dataRow["Company"] = ((this.comboBox_1.SelectedValue == null) ? -1 : ((int)this.comboBox_1.SelectedValue));
			dataRow["Comment"] = this.textBox_4.Text;
			base.UpdateSqlData(this.class107_0, this.class107_0.tP_BuildSubsRepair);
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		private void method_3(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
			{
				e.Handled = true;
			}
		}

		private bool method_4(TextBox textBox_5)
		{
			if (textBox_5.TextLength != 4 && textBox_5.TextLength != 0)
			{
				MessageBox.Show("Некорректный ввод.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				textBox_5.Focus();
				return false;
			}
			return true;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_5()
		{
			this.icontainer_0 = new Container();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.class107_0 = new Class107();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.label_2 = new Label();
			this.uScsmkyOv2 = new TextBox();
			this.textBox_0 = new TextBox();
			this.textBox_1 = new TextBox();
			this.label_3 = new Label();
			this.label_4 = new Label();
			this.label_5 = new Label();
			this.textBox_2 = new TextBox();
			this.label_6 = new Label();
			this.textBox_3 = new TextBox();
			this.label_7 = new Label();
			this.comboBox_0 = new ComboBox();
			this.label_8 = new Label();
			this.label_9 = new Label();
			this.comboBox_1 = new ComboBox();
			this.textBox_4 = new TextBox();
			this.label_10 = new Label();
			this.gxesGotFqF = new ComboBox();
			this.comboBox_2 = new ComboBox();
			this.comboBox_3 = new ComboBox();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.class107_0).BeginInit();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(13, 41);
			this.label_0.Name = "label2";
			this.label_0.Size = new Size(82, 13);
			this.label_0.TabIndex = 6;
			this.label_0.Text = "Ремонт крыши";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(13, 67);
			this.label_1.Name = "label3";
			this.label_1.Size = new Size(81, 13);
			this.label_1.TabIndex = 7;
			this.label_1.Text = "Ремонт (план.)";
			this.bindingSource_0.DataMember = "tP_BuildSubsRepair";
			this.bindingSource_0.DataSource = this.class107_0;
			this.class107_0.DataSetName = "dsPassport1";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.button_0.Location = new Point(272, 256);
			this.button_0.Name = "btnSave";
			this.button_0.Size = new Size(84, 23);
			this.button_0.TabIndex = 3;
			this.button_0.Text = "Применить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Location = new Point(376, 256);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 4;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(13, 15);
			this.label_2.Name = "label1";
			this.label_2.Size = new Size(82, 13);
			this.label_2.TabIndex = 5;
			this.label_2.Text = "Ремонт (факт.)";
			this.uScsmkyOv2.Location = new Point(245, 12);
			this.uScsmkyOv2.Name = "tbFactRepairComm";
			this.uScsmkyOv2.Size = new Size(221, 20);
			this.uScsmkyOv2.TabIndex = 8;
			this.textBox_0.Location = new Point(245, 64);
			this.textBox_0.Name = "tbPlanRepairComm";
			this.textBox_0.Size = new Size(221, 20);
			this.textBox_0.TabIndex = 10;
			this.textBox_1.Location = new Point(245, 38);
			this.textBox_1.Name = "tbHousetopRepairComm";
			this.textBox_1.Size = new Size(221, 20);
			this.textBox_1.TabIndex = 9;
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(162, 67);
			this.label_3.Name = "label4";
			this.label_3.Size = new Size(77, 13);
			this.label_3.TabIndex = 13;
			this.label_3.Text = "Комментарий";
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(162, 41);
			this.label_4.Name = "label5";
			this.label_4.Size = new Size(77, 13);
			this.label_4.TabIndex = 12;
			this.label_4.Text = "Комментарий";
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(162, 15);
			this.label_5.Name = "label6";
			this.label_5.Size = new Size(77, 13);
			this.label_5.TabIndex = 11;
			this.label_5.Text = "Комментарий";
			this.textBox_2.Location = new Point(104, 117);
			this.textBox_2.Name = "tbDoorRepair";
			this.textBox_2.Size = new Size(362, 20);
			this.textBox_2.TabIndex = 14;
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(13, 120);
			this.label_6.Name = "label7";
			this.label_6.Size = new Size(84, 13);
			this.label_6.TabIndex = 15;
			this.label_6.Text = "Ремонт дверей";
			this.textBox_3.Location = new Point(110, 143);
			this.textBox_3.Name = "tbOtmostRepair";
			this.textBox_3.Size = new Size(356, 20);
			this.textBox_3.TabIndex = 16;
			this.label_7.AutoSize = true;
			this.label_7.Location = new Point(13, 146);
			this.label_7.Name = "label8";
			this.label_7.Size = new Size(90, 13);
			this.label_7.TabIndex = 17;
			this.label_7.Text = "Ремонт отмоста";
			this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(101, 90);
			this.comboBox_0.Name = "cbDoorType";
			this.comboBox_0.Size = new Size(155, 21);
			this.comboBox_0.TabIndex = 18;
			this.label_8.AutoSize = true;
			this.label_8.Location = new Point(13, 93);
			this.label_8.Name = "label9";
			this.label_8.Size = new Size(59, 13);
			this.label_8.TabIndex = 19;
			this.label_8.Text = "Тип двери";
			this.label_9.AutoSize = true;
			this.label_9.Location = new Point(13, 172);
			this.label_9.Name = "label10";
			this.label_9.Size = new Size(130, 13);
			this.label_9.TabIndex = 21;
			this.label_9.Text = "Организация-подрядчик";
			this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(149, 169);
			this.comboBox_1.Name = "cbCompany";
			this.comboBox_1.Size = new Size(317, 21);
			this.comboBox_1.TabIndex = 20;
			this.textBox_4.Location = new Point(96, 196);
			this.textBox_4.Multiline = true;
			this.textBox_4.Name = "tbComment";
			this.textBox_4.Size = new Size(368, 44);
			this.textBox_4.TabIndex = 22;
			this.label_10.AutoSize = true;
			this.label_10.Location = new Point(13, 199);
			this.label_10.Name = "label11";
			this.label_10.Size = new Size(77, 13);
			this.label_10.TabIndex = 23;
			this.label_10.Text = "Комментарий";
			this.gxesGotFqF.AutoCompleteMode = AutoCompleteMode.Append;
			this.gxesGotFqF.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.gxesGotFqF.FormattingEnabled = true;
			this.gxesGotFqF.Location = new Point(101, 12);
			this.gxesGotFqF.Name = "cbFactRepair";
			this.gxesGotFqF.Size = new Size(55, 21);
			this.gxesGotFqF.TabIndex = 24;
			this.comboBox_2.AutoCompleteMode = AutoCompleteMode.Append;
			this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_2.FormattingEnabled = true;
			this.comboBox_2.Location = new Point(101, 38);
			this.comboBox_2.Name = "cbHousetopRepair";
			this.comboBox_2.Size = new Size(55, 21);
			this.comboBox_2.TabIndex = 24;
			this.comboBox_3.AutoCompleteMode = AutoCompleteMode.Append;
			this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_3.FormattingEnabled = true;
			this.comboBox_3.Location = new Point(101, 64);
			this.comboBox_3.Name = "cbPlanRepair";
			this.comboBox_3.Size = new Size(55, 21);
			this.comboBox_3.TabIndex = 24;
			base.AcceptButton = this.button_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(479, 288);
			base.Controls.Add(this.comboBox_3);
			base.Controls.Add(this.comboBox_2);
			base.Controls.Add(this.gxesGotFqF);
			base.Controls.Add(this.textBox_4);
			base.Controls.Add(this.label_10);
			base.Controls.Add(this.label_9);
			base.Controls.Add(this.comboBox_1);
			base.Controls.Add(this.label_8);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.textBox_3);
			base.Controls.Add(this.label_7);
			base.Controls.Add(this.textBox_2);
			base.Controls.Add(this.label_6);
			base.Controls.Add(this.uScsmkyOv2);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.textBox_1);
			base.Controls.Add(this.label_3);
			base.Controls.Add(this.label_4);
			base.Controls.Add(this.label_5);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.label_2);
			base.MaximizeBox = false;
			this.MaximumSize = new Size(800, 600);
			this.MinimumSize = new Size(100, 100);
			base.Name = "FormAddEditBuildRepair";
			base.StartPosition = FormStartPosition.CenterScreen;
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.class107_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private StateFormCreate stateFormCreate_0;

		private int int_0;

		private int int_1;

		private IContainer icontainer_0;

		private Label label_0;

		private Label label_1;

		private Button button_0;

		private Button button_1;

		private BindingSource bindingSource_0;

		private Class107 class107_0;

		private Label label_2;

		private TextBox uScsmkyOv2;

		private TextBox textBox_0;

		private TextBox textBox_1;

		private Label label_3;

		private Label label_4;

		private Label label_5;

		private TextBox textBox_2;

		private Label label_6;

		private TextBox textBox_3;

		private Label label_7;

		private ComboBox comboBox_0;

		private Label label_8;

		private Label label_9;

		private ComboBox comboBox_1;

		private TextBox textBox_4;

		private Label label_10;

		private ComboBox gxesGotFqF;

		private ComboBox comboBox_2;

		private ComboBox comboBox_3;
	}
}
