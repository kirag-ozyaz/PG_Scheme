using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using DailyReportN.Reports;
//using Documents.Properties;
using FormLbr;
using Microsoft.Reporting.WinForms;
/// <summary>
/// Бюллетень аварийных отключений
/// </summary>
internal partial class FormReportDetectionCrash : FormBase
{
    private DateTime dateTimeBegin;
    private DateTime dateTimeEnd;
    private bool isCrash;
    private Approver approver;

    internal FormReportDetectionCrash()
	{
		this.InitializeComponent();
	}

	private void FormReportDetectionCrash_Load(object sender, EventArgs e)
	{
        this.chkHV.Checked = true;
		this.FillComboBoxYear();
		this.FillDataTableSettings();
		this.FillReport();
	}

	private void FillComboBoxYear()
	{
		this.dtpDateEnd.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddSeconds(-1.0);
		this.dtpDateBegin.Value = new DateTime(DateTime.Now.Year, 1, 1);
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add("year", typeof(int));
		for (int i = 1879; i <= DateTime.Now.Year; i++)
		{
			DataRow dataRow = dataTable.NewRow();
			dataRow["year"] = i;
			dataRow.EndEdit();
			dataTable.Rows.Add(dataRow);
		}
		this.cmbYear.DisplayMember = "year";
		this.cmbYear.ValueMember = "year";
		this.cmbYear.DataSource = dataTable;
		this.cmbYear.SelectedValue = DateTime.Now.Year;
	}

	private void dtpDateBegin_ValueChanged(object sender, EventArgs e)
	{
		if (this.dtpDateBegin.Value > this.dtpDateEnd.Value)
		{
			this.dtpDateEnd.Value = this.dtpDateBegin.Value;
		}
	}

	private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
	{
		if (this.dtpDateEnd.Value < this.dtpDateBegin.Value)
		{
			this.dtpDateBegin.Value = this.dtpDateEnd.Value;
		}
	}

	private void rBtnYear_CheckedChanged(object sender, EventArgs e)
	{
		this.cmbYear.Enabled = this.rBtnYear.Checked;
		this.dtpDateBegin.Enabled = (this.dtpDateEnd.Enabled = !this.rBtnYear.Checked);
	}

	private void FillDataTableSettings()
	{
		DataTable dataTable = new DataTable("tSettings");
		base.SelectSqlData(dataTable, true, "where module = 'ReportDetectApprover'", null, false, 0);
		if (dataTable.Rows.Count > 0)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Approver));
			StringReader textReader = new StringReader(dataTable.Rows[0]["Settings"].ToString());
			this.approver = (Approver)xmlSerializer.Deserialize(textReader);
		}
		else
		{
			this.approver = new Approver();
		}
		this.SetApprover();
	}

	private void SetApprover()
	{
		this.txtName.Text = this.approver.Name;
		this.txtPost.Text = this.approver.Post;
	}

	private void UpdateDataTableSettings()
	{
		this.approver.Name = this.txtName.Text.Trim();
		this.approver.Post = this.txtPost.Text.Trim();

		XmlSerializer xmlSerializer = new XmlSerializer(typeof(Approver));
		new XDocument();
		StringWriter stringWriter = new StringWriter();
		xmlSerializer.Serialize(stringWriter, this.approver);
		DataTable dataTable = new DailyReportN.DataSet.dsDamage.tSettingsDataTable();
		base.SelectSqlData(dataTable, true, "where module = 'ReportDetectApprover'", null, false, 0);
		if (dataTable.Rows.Count == 0)
		{
			DataRow dataRow = dataTable.NewRow();
			dataRow["Settings"] = stringWriter.ToString();
			dataRow["Module"] = "ReportDetectApprover";
			dataRow.EndEdit();
			dataTable.Rows.Add(dataRow);
			base.InsertSqlData(dataTable);
			return;
		}
		dataTable.Rows[0]["Settings"] = stringWriter.ToString();
		dataTable.Rows[0].EndEdit();
		base.UpdateSqlDataOnlyChange(dataTable);
	}

	private void tsBtnAddFilter_Click(object sender, EventArgs e)
	{
		this.FillReport();
	}

	private void tsBtnDelFilter_Click(object sender, EventArgs e)
	{
		this.rBtnYear.Checked = true;
		this.rBtnAllAct.Checked = true;
		this.FillComboBoxYear();
	}

	private void FillReport()
	{
        string rdlc = "";
        if (chkInfoExtended.Checked)
            rdlc = "DailyReportN.Reports.ReportEmergencyShutdownN.rdlc";
        else
            rdlc = "DailyReportN.Reports.ReportEmergencyShutdown.rdlc";
            this.rptView.LocalReport.ReportEmbeddedResource = rdlc;

        this.rptView.LocalReport.DataSources.Clear();
		List<ReportParameter> list = new List<ReportParameter>();
		list.Add(new ReportParameter("post", this.txtPost.Text.Trim()));
		list.Add(new ReportParameter("worker", this.txtName.Text.Trim()));
		this.isCrash = this.rBtnCrashAct.Checked;
		if (this.rBtnYear.Checked)
		{
			if (this.cmbYear.SelectedValue == null)
			{
				new ToolTip().Show("!", this.cmbYear, 10, 5, 3000);
				return;
			}
			this.dateTimeBegin = new DateTime(Convert.ToInt32(this.cmbYear.SelectedValue), 1, 1);
			this.dateTimeEnd = new DateTime(Convert.ToInt32(this.cmbYear.SelectedValue) + 1, 1, 1).AddSeconds(-1.0);
			list.Add(new ReportParameter("year", this.cmbYear.SelectedValue.ToString()));
		}
		else
		{
			this.dateTimeBegin = this.dtpDateBegin.Value.Date;
			this.dateTimeEnd = this.dtpDateEnd.Value.Date;
			list.Add(new ReportParameter("year", ""));
			list.Add(new ReportParameter("dateBegin", this.dateTimeBegin.ToString("dd.MM.yyyy")));
			list.Add(new ReportParameter("dateEnd", this.dateTimeEnd.ToString("dd.MM.yyyy")));
		}
		this.rptView.LocalReport.SetParameters(list);
		string SqlScriptsCrashByMonth        = Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.ReportDetectionCrashByMonth.sql");
		string SqlScriptsCrashByNetRegion    = Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.ReportDetectionCrashByNetRegion.sql");
		string SqlScriptsReasonCrashEquip    = Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.ReportDetectionReasonCrashEquip.sql");
		string SqlScriptsReasonCrash         = Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.ReportDetectionReasonCrash.sql");
		string SqlScriptsNoAdmissKWTByNetReg = Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.ReportDetectionNoAdmissKWTByNetReg.sql");

		this.rptView.LocalReport.DataSources.Add(new ReportDataSource("dsCrash",             this.CreateMissingRowsInMonth(this.FillTableOnScript(SqlScriptsCrashByMonth))));
		this.rptView.LocalReport.DataSources.Add(new ReportDataSource("dsNetRegion",         this.CreateMissingRowsNetworkAreas(this.FillTableOnScript(SqlScriptsCrashByNetRegion))));
		this.rptView.LocalReport.DataSources.Add(new ReportDataSource("dsReasonCrashEquip",                 this.FillTableOnScript(SqlScriptsReasonCrashEquip)));
		this.rptView.LocalReport.DataSources.Add(new ReportDataSource("dsReasonCrash",                      this.FillTableOnScript(SqlScriptsReasonCrash)));
		this.rptView.LocalReport.DataSources.Add(new ReportDataSource("dsNoAdmissKWT",                      this.FillTableOnScript(SqlScriptsNoAdmissKWTByNetReg)));
		this.rptView.RefreshReport();
	}
    /// <summary>
    /// заполнить таблицу на основании скрипта
    /// </summary>
	private DataTable FillTableOnScript(string SqlScripts)
	{
		DataTable result;
		using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
		{
			try
			{
				sqlConnection.Open();
				if (this.isCrash)
				{
					SqlScripts += "\r\n where isCrash = '1'";
				}
				using (SqlCommand sqlCommand = new SqlCommand(SqlScripts, sqlConnection))
				{
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Parameters.Add("dateBegin", SqlDbType.DateTime).Value = this.dateTimeBegin;
                    sqlCommand.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = this.dateTimeEnd;
                    if (this.chkLV.Checked)
                        sqlCommand.Parameters.Add("docNN", SqlDbType.Int).Value = (int)eTypeDocuments.DamageLV;
                    else
                        sqlCommand.Parameters.Add("docNN", SqlDbType.Int).Value = DBNull.Value;
                    if (this.chkHV.Checked)
                        sqlCommand.Parameters.Add("docVN", SqlDbType.Int).Value = (int)eTypeDocuments.DamageHV;
                    else
                        sqlCommand.Parameters.Add("docVN", SqlDbType.Int).Value = DBNull.Value;
                    DataTable dataTable = new DataTable();
                    new SqlDataAdapter(sqlCommand).Fill(dataTable);
					this.AddPrefixToIntegerColumns(dataTable);
					result = dataTable;
				}
			}
			catch
			{
				sqlConnection.Close();
				result = new DataTable();
			}
		}
		return result;
	}
    #region старые отчеты -- не нужны
    private DataTable FillTableReport_WithCrashByMonth()
	{
		DataTable result;
		using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
		{
			try
			{
				sqlConnection.Open();
				using (SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.ReportDetectionCrashByMonth.sql"), sqlConnection))
				{
					sqlCommand.CommandType = CommandType.Text;
					sqlCommand.Parameters.Add("dateBegin", SqlDbType.DateTime).Value = this.dateTimeBegin;
					sqlCommand.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = this.dateTimeEnd;
					DataTable dataTable = new DataTable();
					new SqlDataAdapter(sqlCommand).Fill(dataTable);
					this.AddPrefixToIntegerColumns(dataTable);
					result = dataTable;
				}
			}
			catch
			{
				sqlConnection.Close();
				result = new DailyReportN.DataSet.dsDamage.tReportDetectionReasonCrashDataTable();
            }
        }
		return result;
	}
	private DataTable FillTableReport_WithReasonCrashEquip()
	{
		DataTable result;
		using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
		{
			try
			{
				sqlConnection.Open();
				using (SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.ReportDetectionReasonCrashEquip.sql"), sqlConnection))
				{
					sqlCommand.CommandType = CommandType.Text;
					sqlCommand.Parameters.Add("dateBegin", SqlDbType.DateTime).Value = this.dateTimeBegin;
					sqlCommand.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = this.dateTimeEnd;
					DataTable dataTable = new DataTable();
					new SqlDataAdapter(sqlCommand).Fill(dataTable);
					this.AddPrefixToIntegerColumns(dataTable);
					result = dataTable;
				}
			}
			catch
			{
				sqlConnection.Close();
				result = new DailyReportN.DataSet.dsDamage.tReportDetectionReasonCrashDataTable();
			}
		}
		return result;
	}
	private DataTable FillTableReport_WithReasonCrash()
	{
		DataTable result;
		using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
		{
			try
			{
				sqlConnection.Open();
				using (SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.ReportDetectionReasonCrash.sql"), sqlConnection))
				{
					sqlCommand.CommandType = CommandType.Text;
					sqlCommand.Parameters.Add("dateBegin", SqlDbType.DateTime).Value = this.dateTimeBegin;
					sqlCommand.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = this.dateTimeEnd;
					DataTable dataTable = new DataTable();
					new SqlDataAdapter(sqlCommand).Fill(dataTable);
					this.AddPrefixToIntegerColumns(dataTable);
					result = dataTable;
				}
			}
			catch
			{
				sqlConnection.Close();
				result = new DailyReportN.DataSet.dsDamage.tReportDetectionReasonCrashDataTable();
			}
		}
		return result;
	}
    
    #endregion
    /// <summary>
    /// добавить в числовые колонки префикс "id"
    /// </summary>
	private void AddPrefixToIntegerColumns(DataTable table)
	{
		foreach (DataColumn dataColumn in table.Columns)
		{
			int num;
			if (int.TryParse(dataColumn.ColumnName, out num))
			{
				dataColumn.ColumnName = "id" + dataColumn.ColumnName;
			}
		}
	}
    

    /// <summary>
    /// сформируем недостающие строки месяцев
    /// </summary>
    private DataTable CreateMissingRowsInMonth(DataTable table)
	{
		for (int i = 1; i <= 12; i++)
		{
			if (new DataView(table)
			{
				RowFilter = string.Format("[month] = '{0}'", i)
			}.Count == 0)
			{
				DataRow dataRow = table.NewRow();
				dataRow["month"] = i;
				dataRow.EndEdit();
				table.Rows.Add(dataRow);
			}
		}
		return table;
	}
    /// <summary>
    /// сформировать недостающие строки подразделений
    /// </summary>
	private DataTable CreateMissingRowsNetworkAreas(DataTable table)
	{
		DataTable tableClassifier = new DataTable("tR_Classifier");
		base.SelectSqlData(tableClassifier, true, "Where ParentKey = ';NetworkAreas;' and deleted = '0' and isGroup = '0'", null, false, 0);
		foreach (DataRow dataRow in tableClassifier.Rows)
		{
			if (new DataView(table)
			{
				RowFilter = string.Format("typeNetReg = '{0}'", dataRow["id"])
			}.Count == 0)
			{
				DataRow dataRow2 = table.NewRow();
				dataRow2["typeNetReg"] = dataRow["id"];
				dataRow2.EndEdit();
				table.Rows.Add(dataRow2);
			}
		}
		return table;
	}

	private void FormReportDetectionCrash_FormClosing(object sender, FormClosingEventArgs e)
	{
		this.UpdateDataTableSettings();
	}

	
}
