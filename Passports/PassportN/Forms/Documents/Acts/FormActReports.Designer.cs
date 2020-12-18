using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using Microsoft.Reporting.WinForms;

namespace Passport.Forms.Documents.Acts
{
	public class FormActReports : FormDocBase
	{
		public FormActReports(SQLSettings sqlSettings, int idObjList, int idDocList, DocumentType docType)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_29();
			this.SqlSettings = sqlSettings;
			base.IdObjList = idObjList;
			base.method_11(idDocList);
			this.documentType_0 = docType;
		}

		private void FormActReports_Load(object sender, EventArgs e)
		{
			string reportEmbeddedResource = this.method_22(this.documentType_0);
			this.reportViewer_0.LocalReport.ReportEmbeddedResource = reportEmbeddedResource;
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("vP_ActRepairTransf", this.method_21()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("vP_Transf_ActRepairTransf", this.method_20()));
			this.reportViewer_0.LocalReport.SetParameters(this.method_19());
			this.reportViewer_0.RefreshReport();
		}

		private List<ReportParameter> method_19()
		{
			List<ReportParameter> list = new List<ReportParameter>();
			list.AddRange(this.method_23());
			list.AddRange(this.method_24());
			list.AddRange(this.method_25());
			list.AddRange(this.method_26());
			list.AddRange(this.method_27());
			return list;
		}

		private DataTable method_20()
		{
			base.SelectSqlData(this.class14_0.vP_Transf_ActRepairTransf, true, "WHERE idObjList = " + base.IdObjList.ToString(), null, false, 1);
			return this.class14_0.vP_Transf_ActRepairTransf;
		}

		private DataTable method_21()
		{
			base.SelectSqlData(this.class14_0.vP_ActRepairTransf, true, "WHERE idPasspDocList = " + base.method_10().ToString(), null, false, 1);
			return this.class14_0.vP_ActRepairTransf;
		}

		private string method_22(DocumentType documentType_1)
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

		private List<ReportParameter> method_23()
		{
			return this.method_28("WorkList", 390, 600);
		}

		private List<ReportParameter> method_24()
		{
			return this.method_28("NoWorkList", 540, 600);
		}

		private List<ReportParameter> method_25()
		{
			List<ReportParameter> list = new List<ReportParameter>();
			string text = "";
			base.SelectSqlDataTableOther(this.class14_0, this.class14_0.tP_Protocols, "tP_DocList", true, "WHERE ParentId = " + this.class14_0.vP_ActRepairTransf.Rows[0]["idPasspDocList"].ToString() + " AND Deleted = ((0))");
			foreach (object obj in this.class14_0.tP_Protocols.Rows)
			{
				Class14.Class66 @class = (Class14.Class66)obj;
				text = string.Concat(new string[]
				{
					text,
					" № ",
					@class.NumberDoc,
					" от ",
					@class.DateDoc.ToShortDateString(),
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

		private List<ReportParameter> method_26()
		{
			return this.method_28("ConditionTransf", 310, 600);
		}

		private List<ReportParameter> method_27()
		{
			return this.method_28("Admission", 100, 600);
		}

		private List<ReportParameter> method_28(string string_0, int int_2, int int_3)
		{
			List<ReportParameter> list = new List<ReportParameter>();
			List<string> combinationWordsList = base.GetCombinationWordsList(this.class14_0.vP_ActRepairTransf.Rows[0][string_0].ToString(), int_2, int_3);
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

		private void method_29()
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
