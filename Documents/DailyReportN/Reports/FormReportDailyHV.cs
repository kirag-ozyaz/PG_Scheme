using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.ReportViewerRus;
using FormLbr;
using Microsoft.Reporting.WinForms;

/// <summary>
/// Суточный рапорт в сетях 10/6 кВ
/// </summary>
internal partial class FormReportDailyHV : FormBase
{
    private DateTimePicker dateTimePickerBegin;
    private DateTimePicker dateTimePickerEnd;
    private CheckBox chkShowDispatcher;

    internal FormReportDailyHV()
	{
		this.InitializeComponent();

        this.dateTimePickerBegin = new DateTimePicker();
		this.dateTimePickerBegin.Value = DateTime.Now.Date;

        this.toolStrip.Items.Insert(1, new ToolStripControlHost(this.dateTimePickerBegin));

        this.dateTimePickerEnd = new DateTimePicker();
		this.dateTimePickerEnd.Value = DateTime.Now.Date;

        this.toolStrip.Items.Insert(3, new ToolStripControlHost(this.dateTimePickerEnd));

        this.chkShowDispatcher = new CheckBox();
		this.chkShowDispatcher.Text = "Показать состав дежурных";
		this.chkShowDispatcher.Checked = false;

        this.toolStrip.Items.Insert(4, new ToolStripControlHost(this.chkShowDispatcher));
	}

	private void FillReport()
	{
		this.dsDamage.ReportDailyHV.Clear();
		this.rptViewer.LocalReport.ReportEmbeddedResource = "DailyReportN.Reports.ReportDailyHV.rdlc";
		string dateReport = this.dateTimePickerBegin.Value.ToString("dd.MM.yyyy");
		if (this.dateTimePickerBegin.Value != this.dateTimePickerEnd.Value)
		{
			dateReport = this.dateTimePickerBegin.Value.ToString("dd.MM.yyyy") + " - " + this.dateTimePickerEnd.Value.ToString("dd.MM.yyyy");
		}
		this.rptViewer.LocalReport.SetParameters(new ReportParameter("dateReport", dateReport));
		this.rptViewer.LocalReport.SetParameters(new ReportParameter("ShowDispatcher", this.chkShowDispatcher.Checked.ToString()));
		using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
		{
			sqlConnection.Open();
			using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
			{
				try
				{
					using (SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.ReportDailyHV.sql"), sqlConnection))
					{
						sqlCommand.CommandTimeout = 0;
						sqlCommand.Transaction = sqlTransaction;
						sqlCommand.Parameters.Add("dateBeg", SqlDbType.DateTime).Value = this.dateTimePickerBegin.Value.Date;
						sqlCommand.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = this.dateTimePickerEnd.Value.Date.AddDays(1.0).AddMilliseconds(-1.0);
						new SqlDataAdapter(sqlCommand).Fill(this.dsDamage.ReportDailyHV);
					}
					using (SqlCommand sqlCommand2 = new SqlCommand("select isnull(w.fio, u.name) as name from tuser u\r\n\t                                left join vr_worker w on u.idWorker = w.id\r\n                                    where login = SYSTEM_USER", sqlConnection))
					{
						sqlCommand2.CommandTimeout = 0;
						sqlCommand2.Transaction = sqlTransaction;
						DbDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCommand2);
						DataTable dataTable = new DataTable();
						dbDataAdapter.Fill(dataTable);
						if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["name"] != DBNull.Value)
						{
							this.rptViewer.LocalReport.SetParameters(new ReportParameter("reportUser", dataTable.Rows[0]["name"].ToString()));
						}
					}
					sqlTransaction.Commit();
				}
				catch (Exception ex)
				{
					sqlTransaction.Rollback();
					MessageBox.Show(ex.Message, ex.Source);
				}
			}
		}
		this.rptViewer.RefreshReport();
	}

	private void FormReportDailyHV_Load(object sender, EventArgs e)
	{
		this.FillReport();
	}

	private void toolBtnLoad_Click(object sender, EventArgs e)
	{
		this.FillReport();
	}


}
