using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using ControlsLbr.ReportViewerRus;
using FormLbr;
using Microsoft.Reporting.WinForms;
using Passport.Classes;

namespace Passport.Forms.Cable.Report
{
	public class FormReportOffKL : FormBase
	{
		public FormReportOffKL()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_2();
		}

		private void FormReportOffKL_Load(object sender, EventArgs e)
		{
			this.dataTableReportOffKL = PassportData.GetCableOperationReportData(this.SqlSettings);
			this.method_1();
		}

		private void method_0(object sender, EventArgs e)
		{
			this.reportViewerRus_0.RefreshReport();
		}

		private void method_1()
		{
			if (this.radioButton_4.Checked)
			{
				this.bindingSource_0.Filter = string.Format(" DateDeCommissioning <= Convert('{0}','System.DateTime') and DateCommissioning is null ", DateTime.Now);
				ReportParameter reportParameter = new ReportParameter("dBegin", null);
				this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
				{
					reportParameter
				});
				reportParameter = new ReportParameter("dEnd", DateTime.Now.Date.ToString());
				this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
				{
					reportParameter
				});
				reportParameter = new ReportParameter("Off", true.ToString());
				this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
				{
					reportParameter
				});
			}
			if (this.radioButton_3.Checked)
			{
				this.bindingSource_0.Filter = string.Format(" DateDeCommissioning <= Convert('{0}','System.DateTime') and (DateCommissioning is null or DateCommissioning >= Convert('{0}','System.DateTime'))", this.dateTimePicker_0.Value.Date);
				ReportParameter reportParameter2 = new ReportParameter("dBegin", null);
				this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
				{
					reportParameter2
				});
				reportParameter2 = new ReportParameter("dEnd", this.dateTimePicker_0.Value.Date.ToString());
				this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
				{
					reportParameter2
				});
				reportParameter2 = new ReportParameter("Off", true.ToString());
				this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
				{
					reportParameter2
				});
			}
			if (this.radioButton_2.Checked)
			{
				ReportParameter reportParameter3 = new ReportParameter("dBegin", this.dateTimePicker_1.Value.Date.ToString());
				this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
				{
					reportParameter3
				});
				reportParameter3 = new ReportParameter("dEnd", this.dateTimePicker_0.Value.Date.ToString());
				this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
				{
					reportParameter3
				});
				if (this.radioButton_1.Checked)
				{
					this.bindingSource_0.Filter = string.Format(" DateDeCommissioning >= Convert('{0}','System.DateTime') and DateDeCommissioning <= Convert('{1}','System.DateTime')", this.dateTimePicker_1.Value.Date, this.dateTimePicker_0.Value.Date);
					reportParameter3 = new ReportParameter("Off", true.ToString());
					this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
					{
						reportParameter3
					});
				}
				else
				{
					this.bindingSource_0.Filter = string.Format(" DateCommissioning >= Convert('{0}','System.DateTime') and DateCommissioning <= Convert('{1}','System.DateTime')", this.dateTimePicker_1.Value.Date, this.dateTimePicker_0.Value.Date);
					reportParameter3 = new ReportParameter("Off", false.ToString());
					this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
					{
						reportParameter3
					});
				}
			}
			this.bindingSource_0.DataMember = null;
			this.bindingSource_0.DataSource = this.dataTableReportOffKL;
			this.reportViewerRus_0.RefreshReport();
		}

		private void bindingSource_0_ListChanged(object sender, ListChangedEventArgs e)
		{
			this.reportViewerRus_0.RefreshReport();
		}

		private void radioButton_4_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButton_4.Checked)
			{
				this.dateTimePicker_1.Enabled = false;
				this.dateTimePicker_0.Enabled = false;
				this.method_1();
			}
		}

		private void radioButton_3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButton_3.Checked)
			{
				this.dateTimePicker_1.Enabled = false;
				this.dateTimePicker_0.Enabled = true;
				this.method_1();
			}
		}

		private void radioButton_2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButton_2.Checked)
			{
				this.dateTimePicker_1.Enabled = true;
				this.dateTimePicker_0.Enabled = true;
				this.method_1();
			}
		}

		private void radioButton_1_CheckedChanged(object sender, EventArgs e)
		{
			this.method_1();
		}

		private void dateTimePicker_0_ValueChanged(object sender, EventArgs e)
		{
			this.method_1();
		}

		private void dateTimePicker_1_ValueChanged(object sender, EventArgs e)
		{
			this.method_1();
		}

		private void radioButton_6_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButton_6.Checked)
			{
				this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.Cable.Report.ReportOffKL.rdlc";
			}
			else
			{
				this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.Cable.Report.ReportOffKLGroupSR.rdlc";
			}
			this.reportViewerRus_0.RefreshReport();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_2()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			ReportDataSource reportDataSource = new ReportDataSource();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.ds = new DataSet();
			this.dataTableReportOffKL = new DataTable();
			this.dataColumn_0 = new DataColumn();
			this.dataColumn_1 = new DataColumn();
			this.dataColumn_2 = new DataColumn();
			this.dataColumn_3 = new DataColumn();
			this.dataColumn_4 = new DataColumn();
			this.dataColumn_5 = new DataColumn();
			this.dataColumn_6 = new DataColumn();
			this.dataColumn_7 = new DataColumn();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.reportViewerRus_0 = new ReportViewerRus();
			this.splitContainer_0 = new SplitContainer();
			this.splitContainer_1 = new SplitContainer();
			this.radioButton_5 = new RadioButton();
			this.radioButton_6 = new RadioButton();
			this.groupBox_0 = new GroupBox();
			this.groupBox_1 = new GroupBox();
			this.radioButton_0 = new RadioButton();
			this.radioButton_1 = new RadioButton();
			this.radioButton_2 = new RadioButton();
			this.radioButton_3 = new RadioButton();
			this.radioButton_4 = new RadioButton();
			this.dateTimePicker_0 = new DateTimePicker();
			this.TubmjOgygPT = new Label();
			this.dateTimePicker_1 = new DateTimePicker();
			this.label_0 = new Label();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.ds).BeginInit();
			((ISupportInitialize)this.dataTableReportOffKL).BeginInit();
			this.dataGridViewExcelFilter_0.BeginInit();
			this.splitContainer_0.Panel1.SuspendLayout();
			this.splitContainer_0.Panel2.SuspendLayout();
			this.splitContainer_0.SuspendLayout();
			this.splitContainer_1.Panel1.SuspendLayout();
			this.splitContainer_1.Panel2.SuspendLayout();
			this.splitContainer_1.SuspendLayout();
			this.groupBox_0.SuspendLayout();
			this.groupBox_1.SuspendLayout();
			base.SuspendLayout();
			this.bindingSource_0.DataMember = "tReportOffKL";
			this.bindingSource_0.DataSource = this.ds;
			this.bindingSource_0.ListChanged += this.bindingSource_0_ListChanged;
			this.ds.DataSetName = "NewDataSet";
			this.ds.Tables.AddRange(new DataTable[]
			{
				this.dataTableReportOffKL
			});
			this.dataTableReportOffKL.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1,
				this.dataColumn_2,
				this.dataColumn_3,
				this.dataColumn_4,
				this.dataColumn_5,
				this.dataColumn_6,
				this.dataColumn_7
			});
			this.dataTableReportOffKL.TableName = "tReportOffKL";
			this.dataColumn_0.ColumnName = "Id";
			this.dataColumn_0.DataType = typeof(int);
			this.dataColumn_1.ColumnName = "Район";
			this.dataColumn_2.ColumnName = "Наименование";
			this.dataColumn_3.Caption = "DateDecommissioning";
			this.dataColumn_3.ColumnName = "DateDecommissioning";
			this.dataColumn_4.ColumnName = "DateCommissioning";
			this.dataColumn_4.ReadOnly = true;
			this.dataColumn_5.ColumnName = "Reason";
			this.dataColumn_6.ColumnName = "Принадлежность";
			this.dataColumn_7.ColumnName = "Days";
			this.dataColumn_7.DataType = typeof(int);
			this.dataColumn_7.ReadOnly = true;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewFilterTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_8
			});
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_0.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_0.Name = "dgv";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewExcelFilter_0.Size = new Size(896, 254);
			this.dataGridViewExcelFilter_0.TabIndex = 1;
			this.reportViewerRus_0.Dock = DockStyle.Fill;
			reportDataSource.Name = "DataSet";
			reportDataSource.Value = this.bindingSource_0;
			this.reportViewerRus_0.LocalReport.DataSources.Add(reportDataSource);
			this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.Cable.Report.ReportOffKL.rdlc";
			this.reportViewerRus_0.Location = new Point(0, 0);
			this.reportViewerRus_0.Name = "reportViewerRus1";
			this.reportViewerRus_0.Size = new Size(617, 251);
			this.reportViewerRus_0.TabIndex = 0;
			this.splitContainer_0.Dock = DockStyle.Fill;
			this.splitContainer_0.FixedPanel = FixedPanel.Panel1;
			this.splitContainer_0.Location = new Point(0, 0);
			this.splitContainer_0.Name = "splitContainer1";
			this.splitContainer_0.Orientation = Orientation.Horizontal;
			this.splitContainer_0.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
			this.splitContainer_0.Panel2.Controls.Add(this.splitContainer_1);
			this.splitContainer_0.Size = new Size(896, 509);
			this.splitContainer_0.SplitterDistance = 254;
			this.splitContainer_0.TabIndex = 2;
			this.splitContainer_1.Dock = DockStyle.Fill;
			this.splitContainer_1.FixedPanel = FixedPanel.Panel1;
			this.splitContainer_1.Location = new Point(0, 0);
			this.splitContainer_1.Name = "splitContainer2";
			this.splitContainer_1.Panel1.Controls.Add(this.radioButton_5);
			this.splitContainer_1.Panel1.Controls.Add(this.radioButton_6);
			this.splitContainer_1.Panel1.Controls.Add(this.groupBox_0);
			this.splitContainer_1.Panel1.Controls.Add(this.dateTimePicker_0);
			this.splitContainer_1.Panel1.Controls.Add(this.TubmjOgygPT);
			this.splitContainer_1.Panel1.Controls.Add(this.dateTimePicker_1);
			this.splitContainer_1.Panel1.Controls.Add(this.label_0);
			this.splitContainer_1.Panel1MinSize = 270;
			this.splitContainer_1.Panel2.Controls.Add(this.reportViewerRus_0);
			this.splitContainer_1.Size = new Size(896, 251);
			this.splitContainer_1.SplitterDistance = 275;
			this.splitContainer_1.TabIndex = 0;
			this.radioButton_5.AutoSize = true;
			this.radioButton_5.Location = new Point(16, 222);
			this.radioButton_5.Name = "radioButtonGroupBySR";
			this.radioButton_5.Size = new Size(134, 17);
			this.radioButton_5.TabIndex = 6;
			this.radioButton_5.Text = "По сетевым районам";
			this.radioButton_5.UseVisualStyleBackColor = true;
			this.radioButton_6.AutoSize = true;
			this.radioButton_6.Checked = true;
			this.radioButton_6.Location = new Point(16, 202);
			this.radioButton_6.Name = "radioButtonGeneral";
			this.radioButton_6.Size = new Size(60, 17);
			this.radioButton_6.TabIndex = 5;
			this.radioButton_6.TabStop = true;
			this.radioButton_6.Text = "Общий";
			this.radioButton_6.UseVisualStyleBackColor = true;
			this.radioButton_6.CheckedChanged += this.radioButton_6_CheckedChanged;
			this.groupBox_0.Controls.Add(this.groupBox_1);
			this.groupBox_0.Controls.Add(this.radioButton_2);
			this.groupBox_0.Controls.Add(this.radioButton_3);
			this.groupBox_0.Controls.Add(this.radioButton_4);
			this.groupBox_0.Location = new Point(12, 68);
			this.groupBox_0.Name = "groupBox1";
			this.groupBox_0.Size = new Size(248, 128);
			this.groupBox_0.TabIndex = 4;
			this.groupBox_0.TabStop = false;
			this.groupBox_1.Controls.Add(this.radioButton_0);
			this.groupBox_1.Controls.Add(this.radioButton_1);
			this.groupBox_1.Location = new Point(95, 62);
			this.groupBox_1.Name = "groupBox2";
			this.groupBox_1.Size = new Size(153, 66);
			this.groupBox_1.TabIndex = 3;
			this.groupBox_1.TabStop = false;
			this.radioButton_0.AutoSize = true;
			this.radioButton_0.Location = new Point(6, 42);
			this.radioButton_0.Name = "radioButtonOnKL";
			this.radioButton_0.Size = new Size(82, 17);
			this.radioButton_0.TabIndex = 1;
			this.radioButton_0.Text = "Введенные";
			this.radioButton_0.UseVisualStyleBackColor = true;
			this.radioButton_1.AutoSize = true;
			this.radioButton_1.Checked = true;
			this.radioButton_1.Location = new Point(6, 19);
			this.radioButton_1.Name = "radioButtonOffKL";
			this.radioButton_1.Size = new Size(90, 17);
			this.radioButton_1.TabIndex = 0;
			this.radioButton_1.TabStop = true;
			this.radioButton_1.Text = "Выведенные";
			this.radioButton_1.UseVisualStyleBackColor = true;
			this.radioButton_1.CheckedChanged += this.radioButton_1_CheckedChanged;
			this.radioButton_2.AutoSize = true;
			this.radioButton_2.Location = new Point(3, 62);
			this.radioButton_2.Name = "radioButtonPeriod";
			this.radioButton_2.Size = new Size(77, 17);
			this.radioButton_2.TabIndex = 2;
			this.radioButton_2.Text = "За период";
			this.radioButton_2.UseVisualStyleBackColor = true;
			this.radioButton_2.CheckedChanged += this.radioButton_2_CheckedChanged;
			this.radioButton_3.AutoSize = true;
			this.radioButton_3.Location = new Point(3, 39);
			this.radioButton_3.Name = "radioButtonSpecifiedDate";
			this.radioButton_3.Size = new Size(121, 17);
			this.radioButton_3.TabIndex = 1;
			this.radioButton_3.Text = "На указанную дату";
			this.radioButton_3.UseVisualStyleBackColor = true;
			this.radioButton_3.CheckedChanged += this.radioButton_3_CheckedChanged;
			this.radioButton_4.AutoSize = true;
			this.radioButton_4.Checked = true;
			this.radioButton_4.Location = new Point(3, 16);
			this.radioButton_4.Name = "radioButtonCurrentDate";
			this.radioButton_4.Size = new Size(122, 17);
			this.radioButton_4.TabIndex = 0;
			this.radioButton_4.TabStop = true;
			this.radioButton_4.Text = "На данный момент";
			this.radioButton_4.UseVisualStyleBackColor = true;
			this.radioButton_4.CheckedChanged += this.radioButton_4_CheckedChanged;
			this.dateTimePicker_0.Enabled = false;
			this.dateTimePicker_0.Location = new Point(107, 42);
			this.dateTimePicker_0.Name = "dtpEnd";
			this.dateTimePicker_0.Size = new Size(153, 20);
			this.dateTimePicker_0.TabIndex = 3;
			this.dateTimePicker_0.ValueChanged += this.dateTimePicker_0_ValueChanged;
			this.TubmjOgygPT.AutoSize = true;
			this.TubmjOgygPT.Location = new Point(12, 48);
			this.TubmjOgygPT.Name = "label2";
			this.TubmjOgygPT.Size = new Size(83, 13);
			this.TubmjOgygPT.TabIndex = 2;
			this.TubmjOgygPT.Text = "Конец периода";
			this.dateTimePicker_1.Enabled = false;
			this.dateTimePicker_1.Location = new Point(107, 14);
			this.dateTimePicker_1.Name = "dtpBegin";
			this.dateTimePicker_1.Size = new Size(153, 20);
			this.dateTimePicker_1.TabIndex = 1;
			this.dateTimePicker_1.ValueChanged += this.dateTimePicker_1_ValueChanged;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 20);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(89, 13);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "Начало периода";
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "Id";
			this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "Район";
			this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Район";
			this.dataGridViewFilterTextBoxColumn_0.Name = "dataGridViewFilterTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "Район";
			this.dataGridViewTextBoxColumn_1.HeaderText = "Район";
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "Принадлежность";
			this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Прин-сть";
			this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewFilterTextBoxColumn2";
			this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "Наименование";
			this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Наименование";
			this.dataGridViewFilterTextBoxColumn_2.Name = "dataGridViewFilterTextBoxColumn3";
			this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "Наименование";
			this.dataGridViewTextBoxColumn_2.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "Reason";
			this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Причина";
			this.dataGridViewFilterTextBoxColumn_3.Name = "dataGridViewFilterTextBoxColumn4";
			this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "Reason";
			this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Причина";
			this.dataGridViewFilterTextBoxColumn_4.Name = "dataGridViewFilterTextBoxColumn5";
			this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "DateDecommisioning";
			this.dataGridViewTextBoxColumn_3.HeaderText = "DateDecommisioning";
			this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "DateCommissioning";
			this.dataGridViewTextBoxColumn_4.HeaderText = "DateCommissioning";
			this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "Reason";
			this.dataGridViewTextBoxColumn_5.HeaderText = "Reason";
			this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "Принадлежность";
			this.dataGridViewTextBoxColumn_6.HeaderText = "Принадлежность";
			this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "DateDecommissioning";
			this.dataGridViewTextBoxColumn_7.HeaderText = "Дата вывода";
			this.dataGridViewTextBoxColumn_7.Name = "DateDecommissioningDgvColumn";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "Days";
			this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Дни";
			this.dataGridViewFilterTextBoxColumn_5.Name = "DaysDgvColumns";
			this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn_8.HeaderText = "Id";
			this.dataGridViewTextBoxColumn_8.Name = "idDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(896, 509);
			base.Controls.Add(this.splitContainer_0);
			base.Name = "FormReportOffKL";
			this.Text = "Отключение кабельных линий";
			base.Load += this.FormReportOffKL_Load;
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.ds).EndInit();
			((ISupportInitialize)this.dataTableReportOffKL).EndInit();
			this.dataGridViewExcelFilter_0.EndInit();
			this.splitContainer_0.Panel1.ResumeLayout(false);
			this.splitContainer_0.Panel2.ResumeLayout(false);
			this.splitContainer_0.ResumeLayout(false);
			this.splitContainer_1.Panel1.ResumeLayout(false);
			this.splitContainer_1.Panel1.PerformLayout();
			this.splitContainer_1.Panel2.ResumeLayout(false);
			this.splitContainer_1.ResumeLayout(false);
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			this.groupBox_1.ResumeLayout(false);
			this.groupBox_1.PerformLayout();
			base.ResumeLayout(false);
		}

		private IContainer icontainer_0;

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private DataColumn dataColumn_5;

		private DataColumn dataColumn_6;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private BindingSource bindingSource_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;

		public DataSet ds;

		public DataTable dataTableReportOffKL;

		private DataColumn dataColumn_7;

		private ReportViewerRus reportViewerRus_0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;

		private SplitContainer splitContainer_0;

		private SplitContainer splitContainer_1;

		private Label label_0;

		private GroupBox groupBox_0;

		private GroupBox groupBox_1;

		private RadioButton radioButton_0;

		private RadioButton radioButton_1;

		private RadioButton radioButton_2;

		private RadioButton radioButton_3;

		private RadioButton radioButton_4;

		private DateTimePicker dateTimePicker_0;

		private Label TubmjOgygPT;

		private DateTimePicker dateTimePicker_1;

		private RadioButton radioButton_5;

		private RadioButton radioButton_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
	}
}
