using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using FormLbr;

namespace Passport.Forms.PassportChars
{
	public class FormAddGroupElementList : FormBase
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

		public int IdParent
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

		public TableNameEnum TableName
		{
			get
			{
				return this.tableNameEnum_0;
			}
			set
			{
				this.tableNameEnum_0 = value;
			}
		}

		public StateFormCreate stateFormCreate
		{
			get
			{
				return this.OsizWvrsrd;
			}
			set
			{
				this.OsizWvrsrd = value;
			}
		}

		public FormAddGroupElementList()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_7();
		}

		private int method_0(string string_0)
		{
			Class107.Class211 @class = this.class107_0.tAbn.method_5();
			@class.CodeAbonent = 0;
			@class.Name = string_0;
			@class.TypeAbn = 683;
			@class.idWorker = 0;
			@class.Deleted = false;
			this.class107_0.tAbn.method_0(@class);
			return base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tAbn);
		}

		private void method_1(int int_2, string string_0)
		{
			this.class211_0.Name = string_0;
			base.UpdateSqlData(this.class107_0, this.class107_0.tAbn);
		}

		private int method_2(int int_2, string string_0, string string_1)
		{
			Class107.Class272 @class = this.class107_0.tP_ValueLists.method_5();
			@class.ParentId = int_2;
			@class.ParentKey = string_1;
			@class.Name = string_0;
			@class.isGroup = false;
			@class.Deleted = false;
			this.class107_0.tP_ValueLists.method_0(@class);
			return base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_ValueLists);
		}

		private void method_3(string string_0, string string_1)
		{
			this.dataRow_0["Name"] = string_0;
			this.dataRow_0["ParentKey"] = string_1;
			base.UpdateSqlData(this.class107_0, this.class107_0.tP_ValueLists);
		}

		private int method_4(string string_0, string string_1)
		{
			Class107.Class272 @class = this.class107_0.tP_ValueLists.method_5();
			@class.Name = string_0;
			@class.ParentKey = string_1;
			@class.isGroup = true;
			@class.Deleted = false;
			this.class107_0.tP_ValueLists.method_0(@class);
			return base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_ValueLists);
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			switch (this.stateFormCreate)
			{
			case 3:
				if (this.tableNameEnum_0 == TableNameEnum.tP_ValueLists)
				{
					this.int_1 = this.method_4(this.textBox_0.Text, this.textBox_1.Text);
				}
				break;
			case 4:
				if (this.tableNameEnum_0 == TableNameEnum.tP_ValueLists)
				{
					this.int_0 = this.method_2(this.int_1, this.textBox_0.Text, this.textBox_1.Text);
				}
				if (this.tableNameEnum_0 == TableNameEnum.tAbn)
				{
					this.int_0 = this.method_0(this.textBox_0.Text);
				}
				break;
			case 5:
			case 6:
				if (this.tableNameEnum_0 == TableNameEnum.tP_ValueLists)
				{
					this.method_3(this.textBox_0.Text, this.textBox_1.Text);
				}
				if (this.tableNameEnum_0 == TableNameEnum.tAbn)
				{
					this.method_1(this.int_0, this.textBox_0.Text);
				}
				break;
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		private void FormAddGroupElementList_Load(object sender, EventArgs e)
		{
			switch (this.OsizWvrsrd)
			{
			case 3:
				this.Text = "Добавить группу";
				return;
			case 4:
				this.Text = "Добавить элемент";
				this.textBox_1.Enabled = false;
				this.GetParentKey();
				return;
			case 5:
				this.Text = "Редактировать группу";
				if (this.tableNameEnum_0 == TableNameEnum.tP_ValueLists)
				{
					this.method_5();
					return;
				}
				break;
			case 6:
				this.Text = "Редактировать элемент";
				this.textBox_1.Enabled = false;
				if (this.tableNameEnum_0 == TableNameEnum.tAbn)
				{
					this.method_6();
				}
				if (this.tableNameEnum_0 == TableNameEnum.tP_ValueLists)
				{
					this.method_5();
				}
				break;
			default:
				return;
			}
		}

		private void method_5()
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_ValueLists, true, "WHERE Id = " + this.int_0.ToString());
			if (this.class107_0.tP_ValueLists.Rows.Count <= 0)
			{
				return;
			}
			this.dataRow_0 = this.class107_0.tP_ValueLists.Rows[0];
			this.textBox_0.Text = ((this.dataRow_0["Name"] == DBNull.Value) ? "" : this.dataRow_0["Name"].ToString());
			this.textBox_1.Text = ((this.dataRow_0["ParentKey"] == DBNull.Value) ? "" : this.dataRow_0["ParentKey"].ToString());
		}

		public void GetParentKey()
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_ValueLists, true, "WHERE Id = " + this.int_1.ToString());
			if (this.class107_0.tP_ValueLists.Rows.Count <= 0)
			{
				return;
			}
			this.dataRow_0 = (Class107.Class272)this.class107_0.tP_ValueLists.Rows[0];
			this.textBox_1.Text = ((this.dataRow_0["ParentKey"] == DBNull.Value) ? "" : this.dataRow_0["ParentKey"].ToString());
		}

		private void method_6()
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tAbn, true, "WHERE Id = " + this.int_0.ToString());
			if (this.class107_0.tAbn.Rows.Count <= 0)
			{
				return;
			}
			this.class211_0 = (Class107.Class211)this.class107_0.tAbn.Rows[0];
			this.textBox_0.Text = this.class211_0.Name;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			FormAddGroupElementList.HixyVoS3Zt08fkI2tgN(this, disposing);
		}

		private void method_7()
		{
			this.textBox_0 = new TextBox();
			this.label_0 = new Label();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.class107_0 = new Class107();
			this.wCezFijsTc = new Label();
			this.textBox_1 = new TextBox();
			((ISupportInitialize)this.class107_0).BeginInit();
			base.SuspendLayout();
			this.textBox_0.Location = new Point(101, 12);
			this.textBox_0.Name = "tbName";
			this.textBox_0.Size = new Size(216, 20);
			this.textBox_0.TabIndex = 0;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 15);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(83, 13);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Наименование";
			this.button_0.Location = new Point(146, 74);
			this.button_0.Name = "btnSave";
			this.button_0.Size = new Size(90, 23);
			this.button_0.TabIndex = 2;
			this.button_0.Text = "Сохранить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Location = new Point(242, 74);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 3;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.wCezFijsTc.AutoSize = true;
			this.wCezFijsTc.Location = new Point(12, 41);
			this.wCezFijsTc.Name = "label2";
			this.wCezFijsTc.Size = new Size(33, 13);
			this.wCezFijsTc.TabIndex = 5;
			this.wCezFijsTc.Text = "Ключ";
			this.textBox_1.Location = new Point(101, 38);
			this.textBox_1.Name = "tbParentKey";
			this.textBox_1.Size = new Size(216, 20);
			this.textBox_1.TabIndex = 4;
			base.AcceptButton = this.button_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(335, 111);
			base.Controls.Add(this.wCezFijsTc);
			base.Controls.Add(this.textBox_1);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.textBox_0);
			base.Name = "FormAddGroupElementList";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "FormAddGroupElenentList";
			base.Load += this.FormAddGroupElementList_Load;
			((ISupportInitialize)this.class107_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		internal static void HixyVoS3Zt08fkI2tgN(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private int int_0;

		private int int_1;

		private TableNameEnum tableNameEnum_0;

		private StateFormCreate OsizWvrsrd;

		private DataRow dataRow_0;

		private Class107.Class211 class211_0;

		private IContainer icontainer_0;

		private TextBox textBox_0;

		private Label label_0;

		private Button button_0;

		private Button button_1;

		private Class107 class107_0;

		private Label wCezFijsTc;

		private TextBox textBox_1;
	}
}
