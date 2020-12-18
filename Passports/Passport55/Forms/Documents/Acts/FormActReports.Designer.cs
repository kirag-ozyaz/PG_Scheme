using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using Microsoft.Reporting.WinForms;
using Passport.DataSets;

namespace Passport.Forms.Documents.Acts
{
	public class FormActReports : FormDocBase
	{
		public FormActReports(SQLSettings sqlSettings, int idObjList, int idDocList, DocumentType docType)
		{
			this.method_24();
			this.SqlSettings = sqlSettings;
			base.IdObjList = idObjList;
			base.IdDocList = idDocList;
			this.documentType_0 = docType;
		}

		private void FormActReports_Load(object sender, EventArgs e)
		{
			string reportEmbeddedResource = this.method_17(this.documentType_0);
			this.reportViewer_0.LocalReport.ReportEmbeddedResource = reportEmbeddedResource;
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("vP_ActRepairTransf", this.method_16()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("vP_Transf_ActRepairTransf", this.method_15()));
			this.reportViewer_0.LocalReport.SetParameters(this.method_14());
			this.reportViewer_0.RefreshReport();
		}

		private List<ReportParameter> method_14()
		{
			List<ReportParameter> list = new List<ReportParameter>();
			list.AddRange(this.method_18());
			list.AddRange(this.method_19());
			list.AddRange(this.method_20());
			list.AddRange(this.method_21());
			list.AddRange(this.method_22());
			return list;
		}

		private DataTable method_15()
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vP_Transf_ActRepairTransf, true, "WHERE idObjList = " + base.IdObjList.ToString(), 1);
			return this.dsDocuments_0.vP_Transf_ActRepairTransf;
		}

		private DataTable method_16()
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vP_ActRepairTransf, true, "WHERE idPasspDocList = " + base.IdDocList.ToString(), 1);
			return this.dsDocuments_0.vP_ActRepairTransf;
		}

		private string method_17(DocumentType documentType_1)
		{
			switch (documentType_1)
			{
			case DocumentType.ActRepairTransformator:
				return "Passport.Forms.Documents.Acts.ReportActRepairTransf.rdlc";
			case DocumentType.ActRoutineMaintenanceSubstation:
				return "";
			case DocumentType.ActRoutineMaintenanceTransformator:
				return "";
			default:
				return "";
			}
		}

		private List<ReportParameter> method_18()
		{
			return this.method_23("WorkList", 390, 600);
		}

		private List<ReportParameter> method_19()
		{
			return this.method_23("NoWorkList", 540, 600);
		}

		private List<ReportParameter> method_20()
		{
			List<ReportParameter> list = new List<ReportParameter>();
			string text = "";
			base.SelectSqlDataTableOther(this.dsDocuments_0, this.dsDocuments_0.tP_Protocols, "tP_DocList", true, "WHERE ParentId = " + this.dsDocuments_0.vP_ActRepairTransf.Rows[0]["idPasspDocList"].ToString() + " AND Deleted = ((0))");
			foreach (object obj in this.dsDocuments_0.tP_Protocols.Rows)
			{
				dsDocuments.Class159 @class = (dsDocuments.Class159)obj;
				text = string.Concat(new string[]
				{
					text,
					" № ",
					@class.method_6(),
					" от ",
					@class.method_4().ToShortDateString(),
					" г.,"
				});
			}
			text = text.Remove(text.LastIndexOf(','));
			List<string> combinationWordsList = base.GetCombinationWordsList(text, 530, 600);
			for (int i = 0; i < combinationWordsList.Count; i++)
			{
				list.Add(new ReportParameter("Test_" + (i + 1).ToString(), combinationWordsList[i]));
			}
			return list;
		}

		private List<ReportParameter> method_21()
		{
			return this.method_23("ConditionTransf", 310, 600);
		}

		private List<ReportParameter> method_22()
		{
			return this.method_23("Admission", 100, 600);
		}

		private List<ReportParameter> method_23(string string_0, int int_2, int int_3)
		{
			List<ReportParameter> list = new List<ReportParameter>();
			List<string> combinationWordsList = base.GetCombinationWordsList(this.dsDocuments_0.vP_ActRepairTransf.Rows[0][string_0].ToString(), int_2, int_3);
			for (int i = 0; i < combinationWordsList.Count; i++)
			{
				list.Add(new ReportParameter(string_0 + "_" + (i + 1).ToString(), combinationWordsList[i]));
			}
			return list;
		}

		private void button_0_Click(object sender, EventArgs e)
		{
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

		private void method_24()
		{
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.tableLayoutPanel_1 = new TableLayoutPanel();
			this.button_0 = new Button();
			this.reportViewer_0 = new ReportViewer();
			this.tableLayoutPanel_0.SuspendLayout();
			this.tableLayoutPanel_1.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 1;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_0.Controls.Add(this.tableLayoutPanel_1, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.reportViewer_0, 0, 0);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 2;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 39f));
			this.tableLayoutPanel_0.Size = new Size(797, 706);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.tableLayoutPanel_1.ColumnCount = 2;
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98f));
			this.tableLayoutPanel_1.Controls.Add(this.button_0, 1, 0);
			this.tableLayoutPanel_1.Dock = DockStyle.Fill;
			this.tableLayoutPanel_1.Location = new Point(3, 670);
			this.tableLayoutPanel_1.Name = "tableLayoutPanel2";
			this.tableLayoutPanel_1.RowCount = 1;
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.Size = new Size(791, 33);
			this.tableLayoutPanel_1.TabIndex = 3;
			this.button_0.Location = new Point(696, 3);
			this.button_0.Name = "button1";
			this.button_0.Size = new Size(85, 23);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.reportViewer_0.Dock = DockStyle.Fill;
			this.reportViewer_0.Location = new Point(3, 3);
			this.reportViewer_0.Name = "reportViewer1";
			this.reportViewer_0.Size = new Size(791, 661);
			this.reportViewer_0.TabIndex = 4;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(797, 706);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormActReports";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "FormActReports";
			base.Load += this.FormActReports_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private DocumentType documentType_0;

		private IContainer icontainer_1;

		private TableLayoutPanel tableLayoutPanel_0;

		private TableLayoutPanel tableLayoutPanel_1;

		private Button button_0;

		private ReportViewer reportViewer_0;
	}
}
