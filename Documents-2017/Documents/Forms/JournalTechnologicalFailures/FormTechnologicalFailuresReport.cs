namespace Documents.Forms.JournalTechnologicalFailures
{
    using ControlsLbr.ReportViewerRus;
    using FormLbr;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormTechnologicalFailuresReport : FormBase
    {
        private BindingSource bindingSource_0;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private ComboBox comboBox_2;
        private DataSetFailure dataSetFailure_0;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private IContainer icontainer_0;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private RadioButton radioButton_0;
        private RadioButton radioButton_1;
        private RadioButton radioButton_2;
        private RadioButton radioButton_3;
        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus_0;
        private SplitContainer splitContainer_0;

        public FormTechnologicalFailuresReport()
        {
            this.method_1();
            this.dateTimePicker_1.Value = this.dateTimePicker_0.Value = DateTime.Now.Date;
            for (int i = 0x7c6; i < (DateTime.Now.Year + 20); i++)
            {
                this.comboBox_1.Items.Add(i);
                this.comboBox_0.Items.Add(i);
            }
            this.comboBox_2.SelectedIndex = DateTime.Now.Month - 1;
            this.comboBox_1.SelectedItem = DateTime.Now.Year;
            this.comboBox_0.SelectedItem = DateTime.Now.Year;
        }

        private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void dateTimePicker_0_ValueChanged(object sender, EventArgs e)
        {
            this.method_0();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormTechnologicalFailuresReport_Load(object sender, EventArgs e)
        {
            this.comboBox_2.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.comboBox_1.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.dateTimePicker_1.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
            this.dateTimePicker_0.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
            this.method_0();
            this.reportViewerRus_0.RefreshReport();
        }

        private void method_0()
        {
            string str = "";
            string str2 = null;
            if (this.radioButton_2.Checked)
            {
                DateTime time = new DateTime(Convert.ToInt32(this.comboBox_1.SelectedItem), this.comboBox_2.SelectedIndex + 1, 1);
                string[] textArray1 = new string[] { " where dateOff >= '", time.ToString("yyyyMMdd"), "' and dateOff < '", time.AddMonths(1).ToString("yyyyMMdd"), "'" };
                str = string.Concat(textArray1);
                ReportParameter parameter = new ReportParameter("month", this.comboBox_2.SelectedItem.ToString());
                ReportParameter[] parameters = new ReportParameter[] { parameter };
                this.reportViewerRus_0.LocalReport.SetParameters(parameters);
                ReportParameter parameter2 = new ReportParameter("year", this.comboBox_1.SelectedItem.ToString());
                ReportParameter[] parameterArray2 = new ReportParameter[] { parameter2 };
                this.reportViewerRus_0.LocalReport.SetParameters(parameterArray2);
                ReportParameter parameter3 = new ReportParameter("dBeg", str2);
                ReportParameter[] parameterArray3 = new ReportParameter[] { parameter3 };
                this.reportViewerRus_0.LocalReport.SetParameters(parameterArray3);
            }
            else if (this.radioButton_1.Checked)
            {
                DateTime time3 = new DateTime(Convert.ToInt32(this.comboBox_0.SelectedItem), 1, 1);
                string[] textArray2 = new string[] { " where dateOff >= '", time3.ToString("yyyyMMdd"), "' and dateOff < '", time3.AddYears(1).ToString("yyyyMMdd"), "'" };
                str = string.Concat(textArray2);
                ReportParameter parameter4 = new ReportParameter("month", new string[1]);
                ReportParameter[] parameterArray4 = new ReportParameter[] { parameter4 };
                this.reportViewerRus_0.LocalReport.SetParameters(parameterArray4);
                ReportParameter parameter5 = new ReportParameter("year", this.comboBox_0.SelectedItem.ToString());
                ReportParameter[] parameterArray5 = new ReportParameter[] { parameter5 };
                this.reportViewerRus_0.LocalReport.SetParameters(parameterArray5);
                ReportParameter parameter6 = new ReportParameter("dBeg", new string[1]);
                ReportParameter[] parameterArray6 = new ReportParameter[] { parameter6 };
                this.reportViewerRus_0.LocalReport.SetParameters(parameterArray6);
            }
            else if (this.radioButton_0.Checked)
            {
                string[] textArray3 = new string[] { " where dateOff >= '", this.dateTimePicker_1.Value.ToString("yyyyMMdd"), "' and dateOff < '", this.dateTimePicker_0.Value.AddDays(1.0).ToString("yyyyMMdd"), "'" };
                str = string.Concat(textArray3);
                ReportParameter parameter7 = new ReportParameter("dBeg", this.dateTimePicker_1.Value.ToString());
                ReportParameter[] parameterArray7 = new ReportParameter[] { parameter7 };
                this.reportViewerRus_0.LocalReport.SetParameters(parameterArray7);
                ReportParameter parameter8 = new ReportParameter("dEnd", this.dateTimePicker_0.Value.ToString());
                ReportParameter[] parameterArray8 = new ReportParameter[] { parameter8 };
                this.reportViewerRus_0.LocalReport.SetParameters(parameterArray8);
            }
            else
            {
                ReportParameter parameter9 = new ReportParameter("month", new string[1]);
                ReportParameter[] parameterArray9 = new ReportParameter[] { parameter9 };
                this.reportViewerRus_0.LocalReport.SetParameters(parameterArray9);
                ReportParameter parameter10 = new ReportParameter("year", new string[1]);
                ReportParameter[] parameterArray10 = new ReportParameter[] { parameter10 };
                this.reportViewerRus_0.LocalReport.SetParameters(parameterArray10);
                ReportParameter parameter11 = new ReportParameter("dBeg", new string[1]);
                ReportParameter[] parameterArray11 = new ReportParameter[] { parameter11 };
                this.reportViewerRus_0.LocalReport.SetParameters(parameterArray11);
            }
            base.SelectSqlData(this.dataSetFailure_0.tJ_TechnologicalFailures, true, str, false);
            this.reportViewerRus_0.RefreshReport();
        }

        private void method_1()
        {
            this.icontainer_0 = new Container();
            ReportDataSource item = new ReportDataSource();
            this.splitContainer_0 = new SplitContainer();
            this.label_0 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_1 = new Label();
            this.dateTimePicker_1 = new DateTimePicker();
            this.radioButton_0 = new RadioButton();
            this.comboBox_0 = new ComboBox();
            this.radioButton_1 = new RadioButton();
            this.comboBox_1 = new ComboBox();
            this.comboBox_2 = new ComboBox();
            this.radioButton_2 = new RadioButton();
            this.label_2 = new Label();
            this.reportViewerRus_0 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.dataSetFailure_0 = new DataSetFailure();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.radioButton_3 = new RadioButton();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.dataSetFailure_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            base.SuspendLayout();
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.Location = new Point(0, 0);
            this.splitContainer_0.Name = "splitContainer1";
            this.splitContainer_0.Panel1.Controls.Add(this.radioButton_3);
            this.splitContainer_0.Panel1.Controls.Add(this.label_0);
            this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_0);
            this.splitContainer_0.Panel1.Controls.Add(this.label_1);
            this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_1);
            this.splitContainer_0.Panel1.Controls.Add(this.radioButton_0);
            this.splitContainer_0.Panel1.Controls.Add(this.comboBox_0);
            this.splitContainer_0.Panel1.Controls.Add(this.radioButton_1);
            this.splitContainer_0.Panel1.Controls.Add(this.comboBox_1);
            this.splitContainer_0.Panel1.Controls.Add(this.comboBox_2);
            this.splitContainer_0.Panel1.Controls.Add(this.radioButton_2);
            this.splitContainer_0.Panel1.Controls.Add(this.label_2);
            this.splitContainer_0.Panel2.Controls.Add(this.reportViewerRus_0);
            this.splitContainer_0.Size = new Size(0x375, 0x189);
            this.splitContainer_0.SplitterDistance = 0xc7;
            this.splitContainer_0.TabIndex = 1;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 0xb0);
            this.label_0.Name = "label3";
            this.label_0.Size = new Size(0x13, 13);
            this.label_0.TabIndex = 10;
            this.label_0.Text = "до";
            this.dateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_0.Enabled = false;
            this.dateTimePicker_0.Location = new Point(0x23, 0xae);
            this.dateTimePicker_0.Name = "dateTimePickerEnd";
            this.dateTimePicker_0.Size = new Size(0x9c, 20);
            this.dateTimePicker_0.TabIndex = 9;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(12, 0x98);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(0x12, 13);
            this.label_1.TabIndex = 8;
            this.label_1.Text = "от";
            this.dateTimePicker_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_1.Enabled = false;
            this.dateTimePicker_1.Location = new Point(0x23, 0x94);
            this.dateTimePicker_1.Name = "dateTimePickerBeg";
            this.dateTimePicker_1.Size = new Size(0x9c, 20);
            this.dateTimePicker_1.TabIndex = 7;
            this.radioButton_0.AutoSize = true;
            this.radioButton_0.Location = new Point(12, 0x7d);
            this.radioButton_0.Name = "radioButtonPeriod";
            this.radioButton_0.Size = new Size(0x3f, 0x11);
            this.radioButton_0.TabIndex = 6;
            this.radioButton_0.Text = "Период";
            this.radioButton_0.UseVisualStyleBackColor = true;
            this.radioButton_0.CheckedChanged += new EventHandler(this.radioButton_0_CheckedChanged);
            this.comboBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_0.Enabled = false;
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(12, 0x62);
            this.comboBox_0.Name = "cmbYear";
            this.comboBox_0.Size = new Size(0xb3, 0x15);
            this.comboBox_0.TabIndex = 5;
            this.radioButton_1.AutoSize = true;
            this.radioButton_1.Location = new Point(12, 0x4b);
            this.radioButton_1.Name = "radioButtonYear";
            this.radioButton_1.Size = new Size(0x2b, 0x11);
            this.radioButton_1.TabIndex = 4;
            this.radioButton_1.Text = "Год";
            this.radioButton_1.UseVisualStyleBackColor = true;
            this.radioButton_1.CheckedChanged += new EventHandler(this.radioButton_1_CheckedChanged);
            this.comboBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(0x7d, 0x30);
            this.comboBox_1.Name = "cmbMonthYear";
            this.comboBox_1.Size = new Size(0x42, 0x15);
            this.comboBox_1.TabIndex = 3;
            this.comboBox_2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_2.FormattingEnabled = true;
            object[] items = new object[] { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
            this.comboBox_2.Items.AddRange(items);
            this.comboBox_2.Location = new Point(12, 0x30);
            this.comboBox_2.Name = "cmbMonth";
            this.comboBox_2.Size = new Size(0x70, 0x15);
            this.comboBox_2.TabIndex = 2;
            this.radioButton_2.AutoSize = true;
            this.radioButton_2.Checked = true;
            this.radioButton_2.Location = new Point(12, 0x19);
            this.radioButton_2.Name = "radioButtonMonth";
            this.radioButton_2.Size = new Size(0x3a, 0x11);
            this.radioButton_2.TabIndex = 1;
            this.radioButton_2.TabStop = true;
            this.radioButton_2.Text = "Месяц";
            this.radioButton_2.UseVisualStyleBackColor = true;
            this.radioButton_2.CheckedChanged += new EventHandler(this.radioButton_2_CheckedChanged);
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(12, 9);
            this.label_2.Name = "label1";
            this.label_2.Size = new Size(0x2f, 13);
            this.label_2.TabIndex = 0;
            this.label_2.Text = "Фильтр";
            this.reportViewerRus_0.Dock = DockStyle.Fill;
            item.Name = "DataSetFailure";
            item.Value = this.bindingSource_0;
            this.reportViewerRus_0.LocalReport.DataSources.Add(item);
            this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalTechnologicalFailures.ReportTechnologicalFailures.rdlc";
            this.reportViewerRus_0.Location = new Point(0, 0);
            this.reportViewerRus_0.Name = "reportViewerRus1";
            this.reportViewerRus_0.Size = new Size(0x2aa, 0x189);
            this.reportViewerRus_0.TabIndex = 0;
            this.dataSetFailure_0.DataSetName = "DataSetFailure";
            this.dataSetFailure_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.bindingSource_0.DataMember = "tJ_TechnologicalFailures";
            this.bindingSource_0.DataSource = this.dataSetFailure_0;
            this.radioButton_3.AutoSize = true;
            this.radioButton_3.Location = new Point(12, 200);
            this.radioButton_3.Name = "radioButtonAll";
            this.radioButton_3.Size = new Size(0x2c, 0x11);
            this.radioButton_3.TabIndex = 11;
            this.radioButton_3.TabStop = true;
            this.radioButton_3.Text = "Все";
            this.radioButton_3.UseVisualStyleBackColor = true;
            this.radioButton_3.CheckedChanged += new EventHandler(this.radioButton_3_CheckedChanged);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x375, 0x189);
            base.Controls.Add(this.splitContainer_0);
            base.Name = "FormTechnologicalFailuresReport";
            this.Text = "Журнал технологических нарушений";
            base.Load += new EventHandler(this.FormTechnologicalFailuresReport_Load);
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.ResumeLayout(false);
            this.dataSetFailure_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            base.ResumeLayout(false);
        }

        private void radioButton_0_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_0.Checked)
            {
                this.comboBox_2.Enabled = false;
                this.comboBox_1.Enabled = false;
                this.comboBox_0.Enabled = false;
                this.dateTimePicker_1.Enabled = true;
                this.dateTimePicker_0.Enabled = true;
                this.method_0();
            }
        }

        private void radioButton_1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_1.Checked)
            {
                this.comboBox_2.Enabled = false;
                this.comboBox_1.Enabled = false;
                this.comboBox_0.Enabled = true;
                this.dateTimePicker_1.Enabled = false;
                this.dateTimePicker_0.Enabled = false;
                this.method_0();
            }
        }

        private void radioButton_2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_2.Checked)
            {
                this.comboBox_2.Enabled = true;
                this.comboBox_1.Enabled = true;
                this.comboBox_0.Enabled = false;
                this.dateTimePicker_1.Enabled = false;
                this.dateTimePicker_0.Enabled = false;
                this.method_0();
            }
        }

        private void radioButton_3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_3.Checked)
            {
                this.comboBox_2.Enabled = false;
                this.comboBox_1.Enabled = false;
                this.comboBox_0.Enabled = false;
                this.dateTimePicker_1.Enabled = false;
                this.dateTimePicker_0.Enabled = false;
                this.method_0();
            }
        }
    }
}

