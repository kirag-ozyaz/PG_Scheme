using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FormLbr;
using Microsoft.Reporting.WinForms;
using Passport.Classes;

namespace Passport.Forms.Reports
{
	public class FormReports : FormBase
	{
		public FormReports(DataTable table)
		{
			this.method_6();
			this.dataTable_0 = table;
			this.method_3();
		}

		private List<Class120> method_0(DataTable dataTable_1)
		{
			List<Class120> list = new List<Class120>();
			for (int i = 0; i < dataTable_1.Columns.Count; i++)
			{
				if (dataTable_1.Columns[i].ColumnName != "IdObj")
				{
					list.Add(new Class120(dataTable_1.Columns[i].Caption, dataTable_1.Columns[i].ColumnName));
				}
			}
			return list;
		}

		private MemoryStream method_1(List<Class120> list_0, List<Class120> list_1)
		{
			MemoryStream memoryStream = new MemoryStream();
			Class118 @class = new Class118();
			@class.method_1(list_0);
			@class.method_3(list_1);
			@class.method_16(memoryStream);
			memoryStream.Position = 0L;
			return memoryStream;
		}

		private void method_2()
		{
			this.reportViewer_0.Reset();
			this.reportViewer_0.LocalReport.LoadReportDefinition(this.memoryStream_0);
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("MyData", this.dataTable_0));
			this.reportViewer_0.RefreshReport();
		}

		private void method_3()
		{
			try
			{
				new List<Class117>();
				foreach (object obj in this.dataTable_0.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					dataColumn.Caption = dataColumn.ColumnName;
					dataColumn.ColumnName = this.method_5(dataColumn.ColumnName);
				}
				List<Class120> list = this.method_0(this.dataTable_0);
				ReportOptionsDialog reportOptionsDialog = new ReportOptionsDialog(list);
				reportOptionsDialog.ShowDialog();
				List<Class120> list_ = reportOptionsDialog.method_0();
				if (this.memoryStream_0 != null)
				{
					this.memoryStream_0.Dispose();
				}
				this.memoryStream_0 = this.method_1(list, list_);
				this.method_4(this.memoryStream_0);
				this.method_2();
			}
			catch (Exception)
			{
			}
		}

		private void method_4(MemoryStream memoryStream_1)
		{
		}

		private string method_5(string string_0)
		{
			string_0 = Regex.Replace(string_0, "[-.?!)(,:]", "");
			string_0 = Transliteration.Front(string_0);
			string[] array = string_0.Split(new char[]
			{
				' '
			}, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				if (!char.IsDigit(Convert.ToChar(text.Substring(0, 1))))
				{
					array[i] = text.Substring(0, 1).ToUpper() + text.Substring(1, text.Length - 1);
				}
			}
			return string.Join("", array.Select(new Func<string, string>(FormReports.<>c.<>9.method_0)).ToArray<string>());
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_6()
		{
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.reportViewer_0 = new ReportViewer();
			this.tableLayoutPanel_1 = new TableLayoutPanel();
			this.button_0 = new Button();
			this.tableLayoutPanel_0.SuspendLayout();
			this.tableLayoutPanel_1.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 1;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.Controls.Add(this.reportViewer_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.tableLayoutPanel_1, 0, 1);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 2;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 36f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_0.Size = new Size(784, 562);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.reportViewer_0.Dock = DockStyle.Fill;
			this.reportViewer_0.Location = new Point(3, 3);
			this.reportViewer_0.Name = "rwReportData";
			this.reportViewer_0.Size = new Size(778, 520);
			this.reportViewer_0.TabIndex = 0;
			this.tableLayoutPanel_1.ColumnCount = 2;
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98f));
			this.tableLayoutPanel_1.Controls.Add(this.button_0, 1, 0);
			this.tableLayoutPanel_1.Dock = DockStyle.Fill;
			this.tableLayoutPanel_1.Location = new Point(3, 529);
			this.tableLayoutPanel_1.Name = "tableLayoutPanel2";
			this.tableLayoutPanel_1.RowCount = 1;
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.Size = new Size(778, 30);
			this.tableLayoutPanel_1.TabIndex = 2;
			this.button_0.Location = new Point(683, 3);
			this.button_0.Name = "button1";
			this.button_0.Size = new Size(74, 23);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(784, 562);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormReports";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Отчет";
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private MemoryStream memoryStream_0;

		private DataTable dataTable_0 = new DataTable();

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private ReportViewer reportViewer_0;

		private TableLayoutPanel tableLayoutPanel_1;

		private Button button_0;
	}
}
