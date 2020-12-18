using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using DataSql;
using Passport.DataSets;

namespace Passport.Forms.Documents.Acts
{
	public class FormAddActRepairTransfProtocol : FormDocBase
	{
		internal dsDocuments.tP_ProtocolsDataTable ProtocolsDataTable
		{
			get
			{
				return this.tP_ProtocolsDataTable_0;
			}
			set
			{
				this.tP_ProtocolsDataTable_0 = value;
			}
		}

		internal dsDocuments.Class159 ProtocolsRow
		{
			get
			{
				return this.class159_0;
			}
			set
			{
				this.class159_0 = value;
			}
		}

		public FormAddActRepairTransfProtocol()
		{
			this.method_18();
		}

		public FormAddActRepairTransfProtocol(SQLSettings sqlSettings, int idDocList)
		{
			this.method_18();
			this.SqlSettings = sqlSettings;
			base.IdObjList = idDocList;
			base.FormCreate = 0;
		}

		public FormAddActRepairTransfProtocol(SQLSettings sqlSettings, int idObjList, int idDocList)
		{
			this.method_18();
			this.SqlSettings = sqlSettings;
			base.IdObjList = idObjList;
			base.IdDocList = idDocList;
			base.FormCreate = 1;
			this.method_15();
		}

		private void FormAddActRepairTransfProtocol_Load(object sender, EventArgs e)
		{
			this.method_14();
			StateFormCreate formCreate = base.FormCreate;
			if (formCreate == null)
			{
				this.Text = "Добавление";
				return;
			}
			if (formCreate != 1)
			{
				return;
			}
			this.Text = "Редактирование";
			this.method_15();
		}

		private void method_14()
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tR_Classifier, true, "WHERE ParentKey LIKE ';TypeDoc;tPassport;Transf;Protocol;'");
			this.comboBox_0.DataSource = this.dsDocuments_0.tR_Classifier;
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "Id";
		}

		private void method_15()
		{
			this.dateTimePicker_0.Value = this.class159_0.method_4();
			this.textBox_0.Text = this.class159_0.method_6();
			this.comboBox_0.SelectedValue = this.class159_0.method_8();
		}

		private void method_16()
		{
			this.class159_0 = this.tP_ProtocolsDataTable_0.method_5();
			this.class159_0.method_5(this.dateTimePicker_0.Value);
			this.class159_0.method_7(this.textBox_0.Text);
			this.class159_0.method_3(base.IdObjList);
			this.class159_0.method_1(-1);
			this.class159_0.method_9((int)this.comboBox_0.SelectedValue);
			this.class159_0.method_11(true);
			this.class159_0.method_13(false);
			this.tP_ProtocolsDataTable_0.method_0(this.class159_0);
		}

		private void method_17()
		{
			this.class159_0.method_5(this.dateTimePicker_0.Value);
			this.class159_0.method_7(this.textBox_0.Text);
			this.class159_0.method_9((int)this.comboBox_0.SelectedValue);
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			StateFormCreate formCreate = base.FormCreate;
			if (formCreate != null)
			{
				if (formCreate == 1)
				{
					this.method_17();
				}
			}
			else
			{
				this.method_16();
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_1 != null)
			{
				this.icontainer_1.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_18()
		{
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.textBox_0 = new TextBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dateTimePicker_0 = new DateTimePicker();
			this.comboBox_0 = new ComboBox();
			this.label_2 = new Label();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 22);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(89, 13);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "Дата протокола";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(12, 48);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(97, 13);
			this.label_1.TabIndex = 1;
			this.label_1.Text = "Номер протокола";
			this.textBox_0.Location = new Point(115, 45);
			this.textBox_0.Name = "tbNumberProtocol";
			this.textBox_0.Size = new Size(234, 20);
			this.textBox_0.TabIndex = 3;
			this.button_0.Location = new Point(164, 110);
			this.button_0.Name = "btnSave";
			this.button_0.Size = new Size(104, 23);
			this.button_0.TabIndex = 4;
			this.button_0.Text = "Сохранить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Location = new Point(274, 110);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 5;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.dateTimePicker_0.Location = new Point(115, 19);
			this.dateTimePicker_0.Name = "dtpDataProtocol";
			this.dateTimePicker_0.Size = new Size(234, 20);
			this.dateTimePicker_0.TabIndex = 6;
			this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(115, 71);
			this.comboBox_0.Name = "cbTypeProtocol";
			this.comboBox_0.Size = new Size(234, 21);
			this.comboBox_0.TabIndex = 7;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(12, 74);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(82, 13);
			this.label_2.TabIndex = 8;
			this.label_2.Text = "Тип протокола";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(361, 142);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.comboBox_0);
			base.Controls.Add(this.dateTimePicker_0);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.MaximizeBox = false;
			base.Name = "FormAddActRepairTransfProtocol";
			base.StartPosition = FormStartPosition.CenterScreen;
			base.Load += this.FormAddActRepairTransfProtocol_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private dsDocuments.tP_ProtocolsDataTable tP_ProtocolsDataTable_0;

		private dsDocuments.Class159 class159_0;

		private IContainer icontainer_1;

		private Label label_0;

		private Label label_1;

		private TextBox textBox_0;

		private Button button_0;

		private Button button_1;

		private DateTimePicker dateTimePicker_0;

		private ComboBox comboBox_0;

		private Label label_2;
	}
}
