using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;

namespace Passport.Forms.Cable
{
	public class FormAddEditCableOperation : FormBase
	{
		internal int Id
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

		public FormAddEditCableOperation()
		{
			Class330.Mus9JxKz1CNxy();
			this.int_0 = -1;
			base..ctor();
			this.method_5();
		}

		public FormAddEditCableOperation(SQLSettings settings, StateFormCreate State, int idObjList = -1)
		{
			Class330.Mus9JxKz1CNxy();
			this.int_0 = -1;
			base..ctor();
			this.method_5();
			this.SqlSettings = settings;
			this.stateFormCreate_0 = State;
			this.int_1 = idObjList;
		}

		private void FormAddEditCableOperation_Load(object sender, EventArgs e)
		{
			this.method_0();
			StateFormCreate stateFormCreate = this.stateFormCreate_0;
			if (stateFormCreate == null)
			{
				this.Text = "Добавить";
				this.dateTimePicker_0.Enabled = true;
				this.comboBox_0.SelectedValue = -1;
				this.comboBox_0.Enabled = true;
				this.dateTimePicker_1.Enabled = false;
				return;
			}
			if (stateFormCreate != 1)
			{
				return;
			}
			this.Text = "Редактировать";
			this.dateTimePicker_0.Enabled = false;
			this.comboBox_0.Enabled = false;
			this.dateTimePicker_1.Enabled = true;
			base.SelectSqlData(this.class107_0.tP_CabOperation, true, string.Format(" where  idObjList = {0} and deleted = 0  order by Convert(datetime, dateDecommissioning, 104) desc", this.int_1), null, false, 0);
			this.dateTimePicker_1.MinDate = this.dateTimePicker_0.Value;
		}

		private void method_0()
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_ValueLists, true, "WHERE ParentKey = ';Cable;Addl;OperReason;' AND Deleted = ((0)) and isgroup = 0 order by Name");
			this.comboBox_0.DataSource = this.class107_0.tP_ValueLists;
			this.comboBox_0.ValueMember = "Id";
			this.comboBox_0.DisplayMember = "Name";
		}

		private bool method_1()
		{
			if (!this.method_4())
			{
				return false;
			}
			StateFormCreate stateFormCreate = this.stateFormCreate_0;
			if (stateFormCreate != null)
			{
				if (stateFormCreate == 1)
				{
					if (!this.method_3())
					{
						return false;
					}
				}
			}
			else if (!this.method_2())
			{
				return false;
			}
			return true;
		}

		private bool method_2()
		{
			DataRow dataRow = this.class107_0.tP_CabOperation.NewRow();
			dataRow["idObjList"] = this.int_1;
			dataRow["dateDecommissioning"] = this.dateTimePicker_0.Value;
			dataRow["Reason"] = (int)this.comboBox_0.SelectedValue;
			dataRow["deleted"] = 0;
			this.class107_0.tP_CabOperation.Rows.Add(dataRow);
			this.class107_0.tP_CabOperation.Rows[0].EndEdit();
			this.int_0 = base.InsertSqlDataOneRow(this.class107_0.tP_CabOperation.Rows[0]);
			return this.int_0 >= 1;
		}

		private bool method_3()
		{
			this.class107_0.tP_CabOperation.Rows[0]["dateCommissioning"] = this.dateTimePicker_1.Value;
			this.class107_0.tP_CabOperation.Rows[0].EndEdit();
			return base.UpdateSqlDataOnlyChange(this.class107_0.tP_CabOperation);
		}

		private bool method_4()
		{
			if (this.comboBox_0.SelectedIndex < 0)
			{
				MessageBox.Show("Не выбрана причина");
				return false;
			}
			return true;
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			if (this.method_1())
			{
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			FormAddEditCableOperation.MMyVIG9kGNNff2ax7poQ(this, disposing);
		}

		private void method_5()
		{
			this.dateTimePicker_0 = new DateTimePicker();
			this.class107_0 = new Class107();
			this.dateTimePicker_1 = new DateTimePicker();
			this.comboBox_0 = new ComboBox();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.label_2 = new Label();
			this.button_0 = new Button();
			this.button_1 = new Button();
			((ISupportInitialize)this.class107_0).BeginInit();
			base.SuspendLayout();
			this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.class107_0, "tP_CabOperation.DateDecommissioning", true));
			this.dateTimePicker_0.Location = new Point(92, 12);
			this.dateTimePicker_0.Name = "dtpOut";
			this.dateTimePicker_0.Size = new Size(184, 20);
			this.dateTimePicker_0.TabIndex = 0;
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.dateTimePicker_1.DataBindings.Add(new Binding("Value", this.class107_0, "tP_CabOperation.DateCommissioning", true));
			this.dateTimePicker_1.Location = new Point(92, 65);
			this.dateTimePicker_1.Name = "dtpIn";
			this.dateTimePicker_1.Size = new Size(184, 20);
			this.dateTimePicker_1.TabIndex = 1;
			this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.class107_0, "tP_CabOperation.Reason", true));
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(92, 38);
			this.comboBox_0.Name = "cmbReason";
			this.comboBox_0.Size = new Size(184, 21);
			this.comboBox_0.TabIndex = 2;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 18);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(74, 13);
			this.label_0.TabIndex = 3;
			this.label_0.Text = "Дата вывода";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(12, 44);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(50, 13);
			this.label_1.TabIndex = 4;
			this.label_1.Text = "Причина";
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(12, 71);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(66, 13);
			this.label_2.TabIndex = 5;
			this.label_2.Text = "Дата ввода";
			this.button_0.Location = new Point(123, 104);
			this.button_0.Name = "btnApply";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 6;
			this.button_0.Text = "Применить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Location = new Point(204, 104);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 7;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(291, 136);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.dateTimePicker_1);
			base.Controls.Add(this.dateTimePicker_0);
			base.Name = "FormAddEditCableOperation";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "FormAddEditCableOperation";
			base.Load += this.FormAddEditCableOperation_Load;
			((ISupportInitialize)this.class107_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		internal static void MMyVIG9kGNNff2ax7poQ(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private int int_0;

		private int int_1;

		private StateFormCreate stateFormCreate_0;

		private IContainer icontainer_0;

		private DateTimePicker dateTimePicker_0;

		private DateTimePicker dateTimePicker_1;

		private ComboBox comboBox_0;

		private Label label_0;

		private Label label_1;

		private Label label_2;

		private Button button_0;

		private Button button_1;

		private Class107 class107_0;
	}
}
