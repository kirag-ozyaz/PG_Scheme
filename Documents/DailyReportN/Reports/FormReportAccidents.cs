using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using ControlsLbr.ReportViewerRus;
using DataSql;
using FormLbr;
using Microsoft.Reporting.WinForms;
/// <summary>
/// Перечень аварий
/// </summary>
namespace DailyReportN.Reports
{
	public partial class FormReportAccidents : FormBase
	{
		public FormReportAccidents()
		{
			this.InitializeComponent();
			this.rptViewer = new ReportViewerRus();
			this.rptViewer.Dock = DockStyle.Fill;
			this.rptViewer.Size = new Size(625, 571);
			this.splitContainerMain.Panel2.Controls.Add(this.rptViewer);
		}

		private void FormReportAccidents_Load(object sender, EventArgs e)
		{
			this.LoadComboBoxFilterYear();
			this.FillReport();
		}
        /// <summary>
        /// начальная инициализация дат отчета
        /// </summary>
		private void LoadComboBoxFilterYear()
		{
			this.dtpFilterBeg.Value = new DateTime(DateTime.Now.Year, 1, 1);
			this.dtpFilterEnd.Value = new DateTime(DateTime.Now.Year, 12, 31);
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData("select year(dateDoc) as year\r\n                                                from tj_damage\r\n                                                where (typedoc = 1874 or (typeDoc = 1844 and idParent is null))\r\n                                                group by year(dateDoc)\r\n                                                order by year(dateDoc) desc");
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    this.cmbFilterYear.Items.Add(dataRow["year"]);
                }
            }
            else
                this.cmbFilterYear.Items.Add(DateTime.Now.Year);

            this.cmbFilterYear.SelectedIndex = 0;
			foreach (object item in this.cmbFilterYear.Items)
			{
				if (Convert.ToInt32(item) == DateTime.Now.Year)
				{
					this.cmbFilterYear.SelectedItem = item;
					break;
				}
			}
		}

		private void rbFilterPeriod_CheckedChanged(object sender, EventArgs e)
		{
			this.cmbFilterYear.Enabled = this.rbFilterYear.Checked;
			this.dtpFilterBeg.Enabled = (this.dtpFilterEnd.Enabled = this.rbFilterPeriod.Checked);
		}

		private void toolBtnFilterApply_Click(object sender, EventArgs e)
		{
			this.FillReport();
		}

		private void toolBtnFilterDelete_Click(object sender, EventArgs e)
		{
			this.LoadComboBoxFilterYear();
			this.FillReport();
		}

		private void FillReport()
		{
			this.toolStripFilter.Enabled = false;
			this.groupBoxDate.Enabled = false;
			this.groupBoxTypeDoc.Enabled = false;
			this.groupBoxFormatPaper.Enabled = false;
			this.rptViewer.Enabled = false;
			this.rptViewer.LocalReport.DataSources.Clear();
			this.progressBar.Visible = true;
			FormReportAccidents.StructureFilter filter = new FormReportAccidents.StructureFilter();
			if (this.rbFilterYear.Checked)
			{
				if (this.cmbFilterYear.SelectedIndex >= 0)
				{
					filter.dateTimeBegin = new DateTime(Convert.ToInt32(this.cmbFilterYear.SelectedItem), 1, 1);
					filter.dateTimeEnd = new DateTime(Convert.ToInt32(this.cmbFilterYear.SelectedItem), 12, 31);
				}
			}
			else
			{
				filter.dateTimeBegin = this.dtpFilterBeg.Value;
				filter.dateTimeEnd = this.dtpFilterEnd.Value;
			}
			filter.chkFilterActDetection = this.chkFilterActDetection.Checked;
			filter.chkFilterDefectHV = this.chkFilterDefectHV.Checked;
			this.backgroundWorker.RunWorkerAsync(filter);
		}

		private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			DailyReportN.DataSet.dsDamage.ReportAccidentsDataTable table = new DailyReportN.DataSet.dsDamage.ReportAccidentsDataTable();
			if (e.Argument == null || !(e.Argument is FormReportAccidents.StructureFilter))
			{
				return;
			}
			FormReportAccidents.StructureFilter filter = (FormReportAccidents.StructureFilter)e.Argument;
			if (!filter.chkFilterActDetection && !filter.chkFilterDefectHV)
			{
				return;
			}
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					string text = Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.ReportAccidents.sql");
					text += string.Format(" where (isnull(dHV.dateDoc, d.dateDoc) >= '{0}' and \r\n                                        isnull(dOn.dateOn, d.dateApply) < '{1}') ", filter.dateTimeBegin.Date.ToString("yyyyMMdd"), filter.dateTimeEnd.Date.AddDays(1.0).ToString("yyyyMMdd"));
					if (filter.chkFilterActDetection)
					{
						if (filter.chkFilterDefectHV)
						{
							text += " and (d.typedoc = 1874 or (d.typeDoc = 1844 and d.idParent is null)) ";
						}
						else
						{
							text += " and (d.typedoc = 1874) ";
						}
					}
					else if (filter.chkFilterDefectHV)
					{
						text += " and (d.typeDoc = 1844 and d.idParent is null) ";
					}
					text += "\r\n order by isnull(dHV.dateDoc, d.dateDoc), ad.numCrash";
					using (SqlCommand sqlCommand = new SqlCommand(text, sqlConnection))
					{
						sqlCommand.CommandTimeout = 0;
						sqlCommand.CommandType = CommandType.Text;
						new SqlDataAdapter(sqlCommand).Fill(table);
						string b = "190000";
						int num = 1;
						foreach (DataRow dataRow in table.Rows)
						{
							if (Convert.ToDateTime(dataRow["datedoc"]).ToString("yyyyMM") != b)
							{
								b = Convert.ToDateTime(dataRow["datedoc"]).ToString("yyyyMM");
								num = 1;
							}
							if (Convert.ToBoolean(dataRow["isCrash"]))
							{
								dataRow["numCrashMonth"] = num;
								num++;
							}
							if (dataRow["dateEnd"] != DBNull.Value && dataRow["dateDoc"] != DBNull.Value)
							{
								TimeSpan t = Convert.ToDateTime(dataRow["dateEnd"]).AddSeconds((double)(-(double)Convert.ToDateTime(dataRow["dateEnd"]).Second)) - Convert.ToDateTime(dataRow["dateDoc"]).AddSeconds((double)(-(double)Convert.ToDateTime(dataRow["dateDoc"]).Second));
								int num2 = (int)(t - TimeSpan.FromHours((double)((int)t.TotalHours))).TotalMinutes;
								string str;
								if (num2 < 10)
								{
									str = "0" + num2.ToString();
								}
								else
								{
									str = num2.ToString();
								}
								dataRow["timeCrash"] = ((int)t.TotalHours).ToString() + ":" + str;
							}
						}
						table.AcceptChanges();
						e.Result = table;
						return;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
					sqlConnection.Close();
					table = new DailyReportN.DataSet.dsDamage.ReportAccidentsDataTable();
				}
			}
			e.Result = table;
		}

		private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			PrinterSettings printerSettings = new PrinterSettings();
			var source = printerSettings.PaperSizes.Cast<PaperSize>().AsQueryable<PaperSize>();

			if (this.rbA3.Checked)
			{
				this.rptViewer.LocalReport.ReportEmbeddedResource = "DailyReportN.Reports.ReportAccidentsA3.rdlc";
				//PaperSize paperSize2 = (from paperSize in source
				//                    where (int)paperSize.Kind == 8
				//                    select paperSize).FirstOrDefault<PaperSize>();

                PaperSize paperSize2 = source.Where(r => (int)r.Kind == 8).FirstOrDefault<PaperSize>();

                printerSettings.DefaultPageSettings.PaperSize = paperSize2;
			}
			else
			{
				this.rptViewer.LocalReport.ReportEmbeddedResource = "DailyReportN.Reports.ReportAccidents.rdlc";
				//PaperSize paperSize;
				//PaperSize paperSize2 = (from paperSize in source
				//                        where (int)paperSize.Kind == 9
				//                        select paperSize).FirstOrDefault<PaperSize>();

                PaperSize paperSize2 = source.Where(r => (int)r.Kind == 9).FirstOrDefault<PaperSize>();
                printerSettings.DefaultPageSettings.PaperSize = paperSize2;
			}
			this.rptViewer.PrinterSettings = printerSettings;
			this.rptViewer.LocalReport.DataSources.Clear();

            DailyReportN.DataSet.dsDamage.ReportAccidentsDataTable dataSourceValue = new DailyReportN.DataSet.dsDamage.ReportAccidentsDataTable();
			if (e.Result != null)
			{
				dataSourceValue = (DailyReportN.DataSet.dsDamage.ReportAccidentsDataTable)e.Result;
			}
			List<ReportParameter> list = new List<ReportParameter>();
			string text = "";
			if (this.rbFilterYear.Checked)
			{
				text = this.cmbFilterYear.SelectedItem.ToString() + " год";
			}
			else
			{
				text = text + this.dtpFilterBeg.Value.Date.ToString("dd.MM.yyyy") + " - " + this.dtpFilterEnd.Value.Date.ToString("dd.MM.yyyy");
			}
			list.Add(new ReportParameter("Period", text));
			this.rptViewer.LocalReport.SetParameters(list);

            Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.ReportAccidents.sql");

            //this.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet", dataSourceValue));
            this.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet", dataSourceValue.CopyToDataTable()));
            //this.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet", dataSourceValue.Clone()));

            this.toolStripFilter.Enabled = true;
			this.groupBoxDate.Enabled = true;
			this.groupBoxTypeDoc.Enabled = true;
			this.groupBoxFormatPaper.Enabled = true;
			this.rptViewer.Enabled = true;
			this.progressBar.Visible = false;
			this.rptViewer.RefreshReport();
		}

		private class StructureFilter
		{
			public StructureFilter()
			{
				this.dateTimeBegin = DateTime.Now;
				this.dateTimeEnd = DateTime.Now;
				this.chkFilterActDetection = true;
				this.chkFilterDefectHV = true;
				
			}
			internal DateTime dateTimeBegin;
			internal DateTime dateTimeEnd;
			internal bool chkFilterActDetection;
			internal bool chkFilterDefectHV;
		}
    }
}
