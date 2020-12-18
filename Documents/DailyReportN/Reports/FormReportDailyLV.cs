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
/// Суточный рапорт в сетях 0,4 кВ (ОДС)
/// </summary>
internal partial class FormReportDailyLV : FormBase
{
    private DateTimePicker DateReport;

    private CheckBox chkGroupNetRegion;

    internal FormReportDailyLV()
	{
		this.InitializeComponent();
		this.DateReport = new DateTimePicker();
		this.DateReport.Value = DateTime.Now.Date;

        this.toolStrip.Items.Insert(1, new ToolStripControlHost(this.DateReport));

        this.chkGroupNetRegion = new CheckBox();
		this.chkGroupNetRegion.Text = "Разбить по районам";

        this.toolStrip.Items.Insert(2, new ToolStripControlHost(this.chkGroupNetRegion));
	}

	private void FillReport()
	{
		this.dsDamage.ReportDailyLV.Clear();
		this.dsDamage.vJ_Temperature.Clear();
		this.rptViewer.LocalReport.ReportEmbeddedResource = "DailyReportN.Reports.ReportDailyLV.rdlc";
		this.rptViewer.LocalReport.SetParameters(new ReportParameter("dateReport", this.DateReport.Value.ToString()));
		this.rptViewer.LocalReport.SetParameters(new ReportParameter("GroupNetRegion", (!this.chkGroupNetRegion.Checked).ToString()));
		using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
		{
			sqlConnection.Open();
			using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
			{
				try
				{
					using (SqlCommand sqlCommand = new SqlCommand("SELECT t.[id],t.[DateTemp],t.[NightDown],t.[NightUp],t.[DayDown],t.[DayUp],t.[TempAverage],t.[Wind]\r\n                                            ,c.name as windname,t.[SpeedDown],t.[SpeedUp],t.[Comment],t.[DateOwner],t.[idOwner],t.[Owner]\r\n                                    FROM [tJ_Temperature] t\r\n                                             LEFT JOIN tr_Classifier c on c.id = t.wind\r\n                                    WHERE t.dateTEmp = @date", sqlConnection))
					{
						sqlCommand.CommandTimeout = 0;
						sqlCommand.Transaction = sqlTransaction;
						sqlCommand.Parameters.Add("date", SqlDbType.DateTime).Value = this.DateReport.Value.Date;
						new SqlDataAdapter(sqlCommand).Fill(this.dsDamage.vJ_Temperature);
					}
                    if (this.dsDamage.vJ_Temperature.Rows.Count > 0)
                    {
                        using (SqlCommand sqlCommand2 = new SqlCommand(Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.ReportDailyLV.sql"), sqlConnection))
                        {
                            sqlCommand2.CommandTimeout = 0;
                            sqlCommand2.Transaction = sqlTransaction;
                            sqlCommand2.Parameters.Add("date", SqlDbType.DateTime).Value = this.DateReport.Value.Date;
                            new SqlDataAdapter(sqlCommand2).Fill(this.dsDamage.ReportDailyLV);
                        }
                        using (SqlCommand sqlCommand3 = new SqlCommand("select isnull(w.fio, u.name) as name from tuser u\r\n\t                                left join vr_worker w on u.idWorker = w.id\r\n                                    where login = SYSTEM_USER", sqlConnection))
                        {
                            sqlCommand3.CommandTimeout = 0;
                            sqlCommand3.Transaction = sqlTransaction;
                            DbDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCommand3);
                            DataTable dataTable = new DataTable();
                            dbDataAdapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["name"] != DBNull.Value)
                            {
                                this.rptViewer.LocalReport.SetParameters(new ReportParameter("reportUser", dataTable.Rows[0]["name"].ToString()));
                            }
                            //goto IL_27E;
                        }
                    }
                    else
                    {
                        this.rptViewer.LocalReport.ReportEmbeddedResource = null;
                        MessageBox.Show("На данную дату не введены показания температуры");
                    }
					//IL_27E:
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

	private void FormReportDailyLV_Load(object sender, EventArgs e)
	{
		this.FillReport();
	}

	private void toolBtnLoad_Click(object sender, EventArgs e)
	{
		this.FillReport();
	}

	
}
