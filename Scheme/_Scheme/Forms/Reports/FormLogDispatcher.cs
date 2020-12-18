using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.ReportViewerRus;
using FormLbr;
using Microsoft.Reporting.WinForms;

namespace Scheme.Forms.Reports
{
	public partial class FormLogDispatcher : FormBase
	{
		public FormLogDispatcher()
		{
			
			
			this.method_2();
		}

		private void FormLogDispatcher_Load(object sender, EventArgs e)
		{
			this.method_0(DateTime.Now);
			this.method_1();
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			string text = string.Concat(new string[]
			{
				" where dateLog >= '",
				this.dateTimePicker_1.Value.Date.ToString("yyyyMMdd"),
				" ",
				this.dateTimePicker_1.Value.TimeOfDay.ToString(),
				"' and  dateLog < '",
				this.dateTimePicker_0.Value.Date.ToString("yyyyMMdd"),
				" ",
				this.dateTimePicker_0.Value.TimeOfDay.ToString(),
				"'"
			});
			if (this.checkedListBox_0.CheckedItems.Count < this.checkedListBox_0.Items.Count)
			{
				string text2 = "";
				foreach (object obj in this.checkedListBox_0.CheckedItems)
				{
					text2 = text2 + ((FormLogDispatcher.Struct0)obj).int_0.ToString() + ",";
				}
				if (text2.Length > 0)
				{
					text = text + " and idWorker in (" + text2.Remove(text2.Length - 1) + ")";
				}
			}
			if (this.checkBox_0.Checked && !this.checkBox_1.Checked)
			{
				text += " and TypeSchema = 1 ";
			}
			if (!this.checkBox_0.Checked && this.checkBox_1.Checked)
			{
				text += " and TypeSchema = 2 ";
			}
			base.SelectSqlData(this.vnFroiJcao, this.vnFroiJcao.vSchm_LogDispatcher, true, text);
			if (this.checkBox_0.Checked == this.checkBox_1.Checked)
			{
				for (int i = 0; i < this.vnFroiJcao.vSchm_LogDispatcher.Rows.Count; i++)
				{
					if (this.vnFroiJcao.vSchm_LogDispatcher.Rows[i].RowState != DataRowState.Deleted)
					{
						int num = Convert.ToInt32(this.vnFroiJcao.vSchm_LogDispatcher.Rows[i]["id"]);
						foreach (DataRow dataRow in this.vnFroiJcao.vSchm_LogDispatcher.Select(" id = " + num.ToString()))
						{
							if (dataRow != this.vnFroiJcao.vSchm_LogDispatcher.Rows[i])
							{
								dataRow.Delete();
							}
						}
					}
				}
			}
			ReportParameter reportParameter = new ReportParameter("dBeg", this.dateTimePicker_1.Value.ToString());
			this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
			reportParameter = new ReportParameter("dEnd", this.dateTimePicker_0.Value.ToString());
			this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
			this.reportViewerRus_0.RefreshReport();
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			this.method_0(DateTime.Now);
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			this.method_0(DateTime.Now.AddHours(-12.0));
		}

		private void method_0(DateTime dateTime_0)
		{
			if (dateTime_0.TimeOfDay.Hours >= 8 && dateTime_0.TimeOfDay.Hours < 20)
			{
				this.dateTimePicker_1.Value = new DateTime(dateTime_0.Year, dateTime_0.Month, dateTime_0.Day, 8, 0, 0);
				this.dateTimePicker_0.Value = new DateTime(dateTime_0.Year, dateTime_0.Month, dateTime_0.Day, 20, 0, 0);
			}
			if (dateTime_0.TimeOfDay.Hours < 8)
			{
				this.dateTimePicker_0.Value = new DateTime(dateTime_0.Year, dateTime_0.Month, dateTime_0.Day, 8, 0, 0);
				dateTime_0 = dateTime_0.AddDays(-1.0);
				this.dateTimePicker_1.Value = new DateTime(dateTime_0.Year, dateTime_0.Month, dateTime_0.Day, 20, 0, 0);
			}
			if (dateTime_0.TimeOfDay.Hours >= 20)
			{
				this.dateTimePicker_1.Value = new DateTime(dateTime_0.Year, dateTime_0.Month, dateTime_0.Day, 20, 0, 0);
				dateTime_0 = dateTime_0.AddDays(1.0);
				this.dateTimePicker_0.Value = new DateTime(dateTime_0.Year, dateTime_0.Month, dateTime_0.Day, 8, 0, 0);
			}
		}

		private void method_1()
		{
			base.SelectSqlData(this.vnFroiJcao, this.vnFroiJcao.vWorkerGroup, true, " where Parentkey = ';GroupWorker;Dispatchers;' order by fio");
			foreach (object obj in this.vnFroiJcao.vWorkerGroup.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				if (!string.IsNullOrEmpty(dataRow["fio"].ToString()))
				{
					FormLogDispatcher.Struct0 @struct;
					@struct.string_0 = dataRow["fio"].ToString();
					@struct.int_0 = Convert.ToInt32(dataRow["id"]);
					this.checkedListBox_0.Items.Add(@struct, true);
				}
			}
		}

		private void method_2()
		{
			this.veArhpSudu = new Container();
			ReportDataSource reportDataSource = new ReportDataSource();
			this.bindingSource_0 = new BindingSource(this.veArhpSudu);
			this.vnFroiJcao = new Class19();
			this.reportViewerRus_0 = new ReportViewerRus();
			this.button_0 = new Button();
			this.groupBox_0 = new GroupBox();
			this.button_1 = new Button();
			this.button_2 = new Button();
			this.dateTimePicker_0 = new DateTimePicker();
			this.label_0 = new Label();
			this.dateTimePicker_1 = new DateTimePicker();
			this.label_1 = new Label();
			this.checkedListBox_0 = new CheckedListBox();
			this.label_2 = new Label();
			this.checkBox_0 = new CheckBox();
			this.checkBox_1 = new CheckBox();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.vnFroiJcao).BeginInit();
			this.groupBox_0.SuspendLayout();
			base.SuspendLayout();
			this.bindingSource_0.DataMember = "vSchm_LogDispatcher";
			this.bindingSource_0.DataSource = this.vnFroiJcao;
			this.vnFroiJcao.DataSetName = "DataSetScheme";
			this.vnFroiJcao.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.reportViewerRus_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			reportDataSource.Name = "DataSetScheme";
			reportDataSource.Value = this.bindingSource_0;
			this.reportViewerRus_0.LocalReport.DataSources.Add(reportDataSource);
			this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Scheme.FileReports.ReportLogDispatcher.rdlc";
			this.reportViewerRus_0.Location = new Point(165, 3);
			this.reportViewerRus_0.Name = "reportViewerRus1";
			this.reportViewerRus_0.Size = new Size(669, 402);
			this.reportViewerRus_0.TabIndex = 0;
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.button_0.Location = new Point(8, 369);
			this.button_0.Name = "buttonLoadLog";
			this.button_0.Size = new Size(138, 23);
			this.button_0.TabIndex = 1;
			this.button_0.Text = "Сформировать";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.groupBox_0.Controls.Add(this.button_1);
			this.groupBox_0.Controls.Add(this.button_2);
			this.groupBox_0.Controls.Add(this.dateTimePicker_0);
			this.groupBox_0.Controls.Add(this.label_0);
			this.groupBox_0.Controls.Add(this.dateTimePicker_1);
			this.groupBox_0.Controls.Add(this.label_1);
			this.groupBox_0.Location = new Point(2, 3);
			this.groupBox_0.Name = "groupBoxDate";
			this.groupBox_0.Size = new Size(157, 166);
			this.groupBox_0.TabIndex = 2;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Дата";
			this.button_1.Location = new Point(6, 129);
			this.button_1.Name = "buttonPrevChange";
			this.button_1.Size = new Size(138, 23);
			this.button_1.TabIndex = 5;
			this.button_1.Text = "Предыдущая смена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.button_2.Location = new Point(6, 100);
			this.button_2.Name = "buttonCurrentChange";
			this.button_2.Size = new Size(138, 23);
			this.button_2.TabIndex = 4;
			this.button_2.Text = "Текущая смена";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.dateTimePicker_0.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
			this.dateTimePicker_0.Location = new Point(6, 74);
			this.dateTimePicker_0.Name = "dateTimePickerEnd";
			this.dateTimePicker_0.Size = new Size(138, 20);
			this.dateTimePicker_0.TabIndex = 3;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(10, 58);
			this.label_0.Name = "label2";
			this.label_0.Size = new Size(62, 13);
			this.label_0.TabIndex = 2;
			this.label_0.Text = "Окончания";
			this.dateTimePicker_1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dateTimePicker_1.Format = DateTimePickerFormat.Custom;
			this.dateTimePicker_1.Location = new Point(6, 32);
			this.dateTimePicker_1.Name = "dateTimePickerBegin";
			this.dateTimePicker_1.Size = new Size(138, 20);
			this.dateTimePicker_1.TabIndex = 1;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(10, 16);
			this.label_1.Name = "label1";
			this.label_1.Size = new Size(44, 13);
			this.label_1.TabIndex = 0;
			this.label_1.Text = "Начала";
			this.checkedListBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.checkedListBox_0.CheckOnClick = true;
			this.checkedListBox_0.FormattingEnabled = true;
			this.checkedListBox_0.Location = new Point(2, 237);
			this.checkedListBox_0.Name = "checkedListBoxDispatchers";
			this.checkedListBox_0.Size = new Size(157, 124);
			this.checkedListBox_0.TabIndex = 3;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(5, 218);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(68, 13);
			this.label_2.TabIndex = 4;
			this.label_2.Text = "Диспетчера";
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Checked = true;
			this.checkBox_0.CheckState = CheckState.Checked;
			this.checkBox_0.Location = new Point(12, 175);
			this.checkBox_0.Name = "checkBoxSchemaMain";
			this.checkBox_0.Size = new Size(110, 17);
			this.checkBox_0.TabIndex = 5;
			this.checkBox_0.Text = "Первый уровень";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Location = new Point(12, 198);
			this.checkBox_1.Name = "checkBoxSChemaSecond";
			this.checkBox_1.Size = new Size(106, 17);
			this.checkBox_1.TabIndex = 6;
			this.checkBox_1.Text = "Второй уровень";
			this.checkBox_1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(833, 404);
			base.Controls.Add(this.checkBox_1);
			base.Controls.Add(this.checkBox_0);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.checkedListBox_0);
			base.Controls.Add(this.groupBox_0);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.reportViewerRus_0);
			base.Name = "FormLogDispatcher";
			this.Text = "Отчет диспетчера";
			base.Load += this.FormLogDispatcher_Load;
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.vnFroiJcao).EndInit();
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private Class19 vnFroiJcao;

		private ReportViewerRus reportViewerRus_0;

		private BindingSource bindingSource_0;

		private Button button_0;

		private GroupBox groupBox_0;

		private Button button_1;

		private Button button_2;

		private DateTimePicker dateTimePicker_0;

		private Label label_0;

		private DateTimePicker dateTimePicker_1;

		private Label label_1;

		private CheckedListBox checkedListBox_0;

		private Label label_2;

		private CheckBox checkBox_0;

		private CheckBox checkBox_1;

		private struct Struct0
		{
			public override string ToString()
			{
				return this.string_0;
			}

			public int int_0;

			public string string_0;
		}
	}
}
