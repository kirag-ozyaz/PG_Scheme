using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using ControlsLbr;
using FormLbr;
using Passport.DataSets;

namespace Passport.Forms.Substation
{
	public class FormSubstTestAddEdit : FormBase
	{
		public int IdObjList { get; set; }

		public StateFormCreate CreateState { get; set; }

		public FormSubstTestAddEdit()
		{
			this.method_5();
		}

		public FormSubstTestAddEdit(int IdDoc)
		{
			this.method_5();
			this.int_0 = IdDoc;
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void FormSubstTestAddEdit_Load(object sender, EventArgs e)
		{
			if (this.CreateState == null)
			{
				this.Text = "Добавить испытание подстанции";
				dsDocuments.Class158 @class = this.dsDocuments_0.tP_DocList.method_5();
				@class.method_3(this.IdObjList);
				@class.method_1(-1);
				@class.method_5(this.dateTimePicker_0.Value);
				@class.method_9(this.method_0());
				@class.method_13(false);
				@class.method_11(true);
				@class.EndEdit();
				this.dsDocuments_0.tP_DocList.method_0(@class);
				dsDocuments.Class192 class2 = this.dsDocuments_0.tP_SubstationTest.method_5();
				class2.method_1(this.int_0);
				class2.method_25(false);
				class2.EndEdit();
				this.dsDocuments_0.tP_SubstationTest.method_0(class2);
				return;
			}
			if (this.CreateState == 1)
			{
				this.Text = "Редактировать испытание подстанции";
				base.SelectSqlData(this.dsDocuments_0.tP_DocList, true, "where id = " + this.int_0.ToString(), false);
				base.SelectSqlData(this.dsDocuments_0.tP_SubstationTest, true, "where deleted = '0' and idDocList = " + this.int_0.ToString(), false);
			}
		}

		private int method_0()
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			base.SelectSqlData(dataTable, true, "where ParentKey = ';TypeDoc;tPassport;PS;' and Value = '6' and deleted = '0'", false);
			if (dataTable.Rows.Count > 0)
			{
				return Convert.ToInt32(dataTable.Rows[0]["id"]);
			}
			return -1;
		}

		private void FormSubstTestAddEdit_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK && !this.method_2())
			{
				e.Cancel = true;
				base.DialogResult = DialogResult.None;
			}
		}

		private bool method_1()
		{
			bool result = true;
			if (string.IsNullOrEmpty(Convert.ToString(this.dsDocuments_0.tP_SubstationTest[0]["worker"])))
			{
				new ToolTip
				{
					BackColor = Color.Yellow,
					ForeColor = Color.Yellow
				}.Show("!", this.textBox_8, 10, 10, 3000);
				result = false;
			}
			return result;
		}

		private bool method_2()
		{
			if (!this.method_1())
			{
				return false;
			}
			if (!this.method_3())
			{
				MessageBox.Show("Не удалось внести изменения в таблицу испытаний.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			if (!this.method_4())
			{
				MessageBox.Show("Не удалось внести изменения в таблицу характеристик испытания.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			return true;
		}

		private bool method_3()
		{
			this.dsDocuments_0.tP_DocList[0].EndEdit();
			if (this.CreateState == null)
			{
				this.int_0 = base.InsertSqlDataOneRow(this.dsDocuments_0.tP_DocList[0]);
				if (this.int_0 == -1)
				{
					return false;
				}
			}
			else if (this.CreateState == 1 && !base.UpdateSqlDataOnlyChange(this.dsDocuments_0.tP_DocList))
			{
				return false;
			}
			return true;
		}

		private bool method_4()
		{
			if (this.CreateState == null)
			{
				this.dsDocuments_0.tP_SubstationTest[0].method_1(this.int_0);
				this.dsDocuments_0.tP_SubstationTest[0].EndEdit();
				if (!base.InsertSqlData(this.dsDocuments_0.tP_SubstationTest))
				{
					return false;
				}
			}
			else if (this.CreateState == 1)
			{
				this.dsDocuments_0.tP_SubstationTest[0].EndEdit();
				if (!base.UpdateSqlDataOnlyChange(this.dsDocuments_0.tP_SubstationTest))
				{
					return false;
				}
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
			this.textBox_0 = new TextBox();
			this.dsDocuments_0 = new dsDocuments();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.richTextBox_0 = new RichTextBox();
			this.label_2 = new Label();
			this.groupBox_0 = new GroupBox();
			this.textBox_8 = new TextBox();
			this.label_3 = new Label();
			this.textBox_1 = new TextBox();
			this.label_4 = new Label();
			this.textBox_2 = new TextBox();
			this.label_5 = new Label();
			this.textBox_3 = new TextBox();
			this.nullableDateTimePicker_0 = new NullableDateTimePicker();
			this.label_8 = new Label();
			this.label_6 = new Label();
			this.label_7 = new Label();
			this.textBox_4 = new TextBox();
			this.groupBox_1 = new GroupBox();
			this.textBox_5 = new TextBox();
			this.textBox_6 = new TextBox();
			this.label_9 = new Label();
			this.label_10 = new Label();
			this.nullableDateTimePicker_1 = new NullableDateTimePicker();
			this.label_11 = new Label();
			this.groupBox_2 = new GroupBox();
			this.textBox_7 = new TextBox();
			this.nullableDateTimePicker_2 = new NullableDateTimePicker();
			this.label_12 = new Label();
			this.label_13 = new Label();
			this.button_0 = new Button();
			this.button_1 = new Button();
			((ISupportInitialize)this.dsDocuments_0).BeginInit();
			this.groupBox_0.SuspendLayout();
			this.groupBox_1.SuspendLayout();
			this.groupBox_2.SuspendLayout();
			base.SuspendLayout();
			this.textBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBox_0.DataBindings.Add(new Binding("Text", this.dsDocuments_0, "tP_DocList.NumberDoc", true));
			this.textBox_0.Location = new Point(116, 16);
			this.textBox_0.Name = "txtNumDoc";
			this.textBox_0.Size = new Size(148, 20);
			this.textBox_0.TabIndex = 0;
			this.dsDocuments_0.DataSetName = "dsDocuments";
			this.dsDocuments_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 19);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(98, 13);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Номер документа";
			this.label_1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(298, 19);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(33, 13);
			this.label_1.TabIndex = 2;
			this.label_1.Text = "Дата";
			this.dateTimePicker_0.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dsDocuments_0, "tP_DocList.DateDoc", true));
			this.dateTimePicker_0.Enabled = false;
			this.dateTimePicker_0.Location = new Point(337, 16);
			this.dateTimePicker_0.Name = "dtpDateDoc";
			this.dateTimePicker_0.Size = new Size(153, 20);
			this.dateTimePicker_0.TabIndex = 3;
			this.richTextBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dsDocuments_0, "tP_DocList.Comment", true));
			this.richTextBox_0.Location = new Point(15, 400);
			this.richTextBox_0.Name = "rtxtComment";
			this.richTextBox_0.Size = new Size(479, 96);
			this.richTextBox_0.TabIndex = 4;
			this.richTextBox_0.Text = "";
			this.label_2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(12, 384);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(57, 13);
			this.label_2.TabIndex = 5;
			this.label_2.Text = "Описание";
			this.groupBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox_0.Controls.Add(this.textBox_8);
			this.groupBox_0.Controls.Add(this.label_3);
			this.groupBox_0.Controls.Add(this.textBox_1);
			this.groupBox_0.Controls.Add(this.label_4);
			this.groupBox_0.Controls.Add(this.textBox_2);
			this.groupBox_0.Controls.Add(this.label_5);
			this.groupBox_0.Controls.Add(this.textBox_3);
			this.groupBox_0.Controls.Add(this.nullableDateTimePicker_0);
			this.groupBox_0.Controls.Add(this.label_8);
			this.groupBox_0.Controls.Add(this.label_6);
			this.groupBox_0.Controls.Add(this.label_7);
			this.groupBox_0.Controls.Add(this.textBox_4);
			this.groupBox_0.Location = new Point(15, 42);
			this.groupBox_0.Name = "grbGeneral";
			this.groupBox_0.Size = new Size(479, 159);
			this.groupBox_0.TabIndex = 6;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Общие";
			this.textBox_8.DataBindings.Add(new Binding("Text", this.dsDocuments_0, "tP_SubstationTest.worker", true));
			this.textBox_8.Location = new Point(262, 129);
			this.textBox_8.Name = "txtWorker";
			this.textBox_8.Size = new Size(211, 20);
			this.textBox_8.TabIndex = 12;
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(264, 113);
			this.label_3.Name = "label9";
			this.label_3.Size = new Size(80, 13);
			this.label_3.TabIndex = 11;
			this.label_3.Text = "Проверяющий";
			this.textBox_1.DataBindings.Add(new Binding("Text", this.dsDocuments_0, "tP_SubstationTest.faseResist", true));
			this.textBox_1.Location = new Point(6, 129);
			this.textBox_1.Name = "tstFaseResist";
			this.textBox_1.Size = new Size(209, 20);
			this.textBox_1.TabIndex = 9;
			this.label_4.Location = new Point(6, 100);
			this.label_4.Name = "label8";
			this.label_4.Size = new Size(209, 26);
			this.label_4.TabIndex = 8;
			this.label_4.Text = "Сопротивление обмоток между фазами А-а";
			this.textBox_2.DataBindings.Add(new Binding("Text", this.dsDocuments_0, "tP_SubstationTest.resist", true));
			this.textBox_2.Location = new Point(6, 77);
			this.textBox_2.Name = "txtResist";
			this.textBox_2.Size = new Size(209, 20);
			this.textBox_2.TabIndex = 7;
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(6, 61);
			this.label_5.Name = "label7";
			this.label_5.Size = new Size(85, 13);
			this.label_5.TabIndex = 6;
			this.label_5.Text = "Сопротивление";
			this.textBox_3.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBox_3.DataBindings.Add(new Binding("Text", this.dsDocuments_0, "tP_SubstationTest.typeDevice", true));
			this.textBox_3.Location = new Point(262, 77);
			this.textBox_3.Name = "txtTypeDevice";
			this.textBox_3.Size = new Size(211, 20);
			this.textBox_3.TabIndex = 5;
			this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.dsDocuments_0, "tP_SubstationTest.date", true));
			this.nullableDateTimePicker_0.Location = new Point(6, 38);
			this.nullableDateTimePicker_0.Name = "ndtpDate";
			this.nullableDateTimePicker_0.Size = new Size(144, 20);
			this.nullableDateTimePicker_0.TabIndex = 1;
			this.nullableDateTimePicker_0.Value = new DateTime(2016, 6, 30, 10, 10, 48, 809);
			this.label_8.AutoSize = true;
			this.label_8.Location = new Point(6, 22);
			this.label_8.Name = "label4";
			this.label_8.Size = new Size(158, 13);
			this.label_8.TabIndex = 0;
			this.label_8.Text = "Дата замера контур. заземл.";
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(264, 61);
			this.label_6.Name = "label6";
			this.label_6.Size = new Size(97, 13);
			this.label_6.TabIndex = 4;
			this.label_6.Text = "Тип изм. прибора";
			this.label_7.AutoSize = true;
			this.label_7.Location = new Point(264, 22);
			this.label_7.Name = "label5";
			this.label_7.Size = new Size(101, 13);
			this.label_7.TabIndex = 2;
			this.label_7.Text = "Состояние погоды";
			this.textBox_4.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBox_4.DataBindings.Add(new Binding("Text", this.dsDocuments_0, "tP_SubstationTest.weather", true));
			this.textBox_4.Location = new Point(262, 38);
			this.textBox_4.Name = "txtWeather";
			this.textBox_4.Size = new Size(211, 20);
			this.textBox_4.TabIndex = 3;
			this.groupBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox_1.Controls.Add(this.textBox_5);
			this.groupBox_1.Controls.Add(this.textBox_6);
			this.groupBox_1.Controls.Add(this.label_9);
			this.groupBox_1.Controls.Add(this.label_10);
			this.groupBox_1.Controls.Add(this.nullableDateTimePicker_1);
			this.groupBox_1.Controls.Add(this.label_11);
			this.groupBox_1.Location = new Point(15, 207);
			this.groupBox_1.Name = "grbIsol";
			this.groupBox_1.Size = new Size(479, 100);
			this.groupBox_1.TabIndex = 7;
			this.groupBox_1.TabStop = false;
			this.groupBox_1.Text = "Измерение изоляции";
			this.textBox_5.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBox_5.DataBindings.Add(new Binding("Text", this.dsDocuments_0, "tP_SubstationTest.gndIsol", true));
			this.textBox_5.Location = new Point(4, 74);
			this.textBox_5.Name = "txtGndIsol";
			this.textBox_5.Size = new Size(209, 20);
			this.textBox_5.TabIndex = 5;
			this.textBox_6.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBox_6.DataBindings.Add(new Binding("Text", this.dsDocuments_0, "tP_SubstationTest.faseIsol", true));
			this.textBox_6.Location = new Point(4, 35);
			this.textBox_6.Name = "txtFaseIsol";
			this.textBox_6.Size = new Size(209, 20);
			this.textBox_6.TabIndex = 4;
			this.label_9.AutoSize = true;
			this.label_9.Location = new Point(6, 58);
			this.label_9.Name = "label12";
			this.label_9.Size = new Size(58, 13);
			this.label_9.TabIndex = 3;
			this.label_9.Text = "Земля а-3";
			this.label_10.AutoSize = true;
			this.label_10.Location = new Point(6, 19);
			this.label_10.Name = "label11";
			this.label_10.Size = new Size(23, 13);
			this.label_10.TabIndex = 2;
			this.label_10.Text = "А-3";
			this.nullableDateTimePicker_1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.nullableDateTimePicker_1.DataBindings.Add(new Binding("Value", this.dsDocuments_0, "tP_SubstationTest.dateIsol", true));
			this.nullableDateTimePicker_1.Location = new Point(264, 35);
			this.nullableDateTimePicker_1.Name = "ndtpDateIsol";
			this.nullableDateTimePicker_1.Size = new Size(144, 20);
			this.nullableDateTimePicker_1.TabIndex = 1;
			this.nullableDateTimePicker_1.Value = new DateTime(2016, 6, 30, 10, 22, 31, 744);
			this.label_11.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.label_11.AutoSize = true;
			this.label_11.Location = new Point(264, 19);
			this.label_11.Name = "label10";
			this.label_11.Size = new Size(33, 13);
			this.label_11.TabIndex = 0;
			this.label_11.Text = "Дата";
			this.groupBox_2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox_2.Controls.Add(this.textBox_7);
			this.groupBox_2.Controls.Add(this.nullableDateTimePicker_2);
			this.groupBox_2.Controls.Add(this.label_12);
			this.groupBox_2.Controls.Add(this.label_13);
			this.groupBox_2.Location = new Point(15, 313);
			this.groupBox_2.Name = "grbTestTrLubric";
			this.groupBox_2.Size = new Size(479, 60);
			this.groupBox_2.TabIndex = 8;
			this.groupBox_2.TabStop = false;
			this.groupBox_2.Text = "Испытание трансф. масла";
			this.textBox_7.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBox_7.DataBindings.Add(new Binding("Text", this.dsDocuments_0, "tP_SubstationTest.voltTrans", true));
			this.textBox_7.Location = new Point(4, 35);
			this.textBox_7.Name = "txtVoltTrans";
			this.textBox_7.Size = new Size(209, 20);
			this.textBox_7.TabIndex = 3;
			this.nullableDateTimePicker_2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.nullableDateTimePicker_2.DataBindings.Add(new Binding("Value", this.dsDocuments_0, "tP_SubstationTest.dateTrans", true));
			this.nullableDateTimePicker_2.Location = new Point(264, 35);
			this.nullableDateTimePicker_2.Name = "ndtpDateTrans";
			this.nullableDateTimePicker_2.Size = new Size(144, 20);
			this.nullableDateTimePicker_2.TabIndex = 2;
			this.nullableDateTimePicker_2.Value = new DateTime(2016, 6, 30, 10, 30, 10, 242);
			this.label_12.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.label_12.AutoSize = true;
			this.label_12.Location = new Point(264, 19);
			this.label_12.Name = "label14";
			this.label_12.Size = new Size(33, 13);
			this.label_12.TabIndex = 1;
			this.label_12.Text = "Дата";
			this.label_13.AutoSize = true;
			this.label_13.Location = new Point(6, 19);
			this.label_13.Name = "label13";
			this.label_13.Size = new Size(128, 13);
			this.label_13.TabIndex = 0;
			this.label_13.Text = "Пробивное напряжение";
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Location = new Point(338, 516);
			this.button_0.Name = "btnOK";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 9;
			this.button_0.Text = "ОК";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_1_Click;
			this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Location = new Point(419, 516);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 10;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(503, 554);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.groupBox_2);
			base.Controls.Add(this.groupBox_1);
			base.Controls.Add(this.groupBox_0);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.richTextBox_0);
			base.Controls.Add(this.dateTimePicker_0);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.textBox_0);
			base.Name = "FormSubstTestAddEdit";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Испытание подстанции";
			base.FormClosing += this.FormSubstTestAddEdit_FormClosing;
			base.Load += this.FormSubstTestAddEdit_Load;
			((ISupportInitialize)this.dsDocuments_0).EndInit();
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			this.groupBox_1.ResumeLayout(false);
			this.groupBox_1.PerformLayout();
			this.groupBox_2.ResumeLayout(false);
			this.groupBox_2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private int int_0 = -1;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private StateFormCreate stateFormCreate_0;

		private IContainer icontainer_0;

		private TextBox textBox_0;

		private Label label_0;

		private Label label_1;

		private DateTimePicker dateTimePicker_0;

		private RichTextBox richTextBox_0;

		private Label label_2;

		private GroupBox groupBox_0;

		private Label label_3;

		private TextBox textBox_1;

		private Label label_4;

		private TextBox textBox_2;

		private Label label_5;

		private TextBox textBox_3;

		private Label label_6;

		private TextBox textBox_4;

		private Label label_7;

		private NullableDateTimePicker nullableDateTimePicker_0;

		private Label label_8;

		private GroupBox groupBox_1;

		private TextBox textBox_5;

		private TextBox textBox_6;

		private Label label_9;

		private Label label_10;

		private NullableDateTimePicker nullableDateTimePicker_1;

		private Label label_11;

		private GroupBox groupBox_2;

		private TextBox textBox_7;

		private NullableDateTimePicker nullableDateTimePicker_2;

		private Label label_12;

		private Label label_13;

		private Button button_0;

		private Button button_1;

		private dsDocuments dsDocuments_0;

		private TextBox textBox_8;
	}
}
