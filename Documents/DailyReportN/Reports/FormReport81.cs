using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
//using Documents.Properties;
using FormLbr;
using Microsoft.Office.Interop.Excel;

///
/// Бюллетень 8.1
///
internal partial class FormReport81 : FormBase
{
    private string strSort = "";

    internal FormReport81()
	{
		this.InitializeComponent();
	}

	private void FormReport81_Load(object sender, EventArgs e)
	{
		this.LoadComboBoxFilterYear();
		//this.FillReport(null);
	}

	private void LoadComboBoxFilterYear()
	{
		this.dtpFilterBeg.Value = new DateTime(DateTime.Now.Year, 1, 1);
		this.dtpFilterEnd.Value = new DateTime(DateTime.Now.Year, 12, 31);
        System.Data.DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData("select year(dateDoc) as year\r\n                                                from tj_damage\r\n                                                group by year(dateDoc)\r\n                                                order by year(dateDoc) desc");
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
		foreach (object obj2 in this.cmbFilterYear.Items)
		{
			if (Convert.ToInt32(obj2) == DateTime.Now.Year)
			{
				this.cmbFilterYear.SelectedItem = obj2;
				break;
			}
		}
		this.rbFilterIs81.Checked = true;
	}

	private void rbFilterPeriod_CheckedChanged(object sender, EventArgs e)
	{
		this.cmbFilterYear.Enabled = this.rbFilterYear.Checked;
		this.dtpFilterBeg.Enabled = (this.dtpFilterEnd.Enabled = this.rbFilterPeriod.Checked);
	}

	private void toolBtnFilterApply_Click(object sender, EventArgs e)
	{
		//this.FillReport(null);
	}

	private void toolBtnFilterDelete_Click(object sender, EventArgs e)
	{
		this.LoadComboBoxFilterYear();
		//this.FillReport(null);
	}

	private void FillReport(int? Index = null)
	{
		if (Index == null && this.dgvReport.CurrentRow != null)
		{
			Index = new int?(Convert.ToInt32(this.dgvReport.CurrentRow.Cells[this.idDamageDgvColumn.Name].Value));
		}
		this.toolStripMain.Enabled = false;
		this.progressBar.Visible = true;
		this.splitContainerMain.Enabled = false;
		this.strSort = this.bsReport81.Sort;
		this.bsReport81.Sort = string.Empty;
		this.bsReport81.DataMember = null;
		FormReport81.StructureFilter filter = new FormReport81.StructureFilter();
		filter.Index = Index;
		if (this.rbFilterYear.Checked)
		{
			if (this.cmbFilterYear.SelectedIndex >= 0)
			{
				filter.dateTimeBeg = new DateTime(Convert.ToInt32(this.cmbFilterYear.SelectedItem), 1, 1);
				filter.dateTimeEnd = new DateTime(Convert.ToInt32(this.cmbFilterYear.SelectedItem), 12, 31);
			}
		}
		else
		{
			filter.dateTimeBeg = this.dtpFilterBeg.Value;
			filter.dateTimeEnd = this.dtpFilterEnd.Value;
		}
		filter.Checked = this.rbFilterIs81.Checked;
		this.backgroundWorker.RunWorkerAsync(filter);
	}

	private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		try
		{
			this.dsDamage.Report81.Clear();
			if (e.Argument != null && e.Argument is FormReport81.StructureFilter)
			{
				FormReport81.StructureFilter filter = (FormReport81.StructureFilter)e.Argument;
				using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
				{
					sqlConnection.Open();
					using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
					{
						try
						{
							string text = Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.Report81Total.sql");
							if (filter.Checked)
							{
								text += " and (d.is81 = 1 or d.is81 is null) ";
							}
							text += " order by d.datedoc desc";
							using (SqlCommand sqlCommand = new SqlCommand(text, sqlConnection))
							{
								sqlCommand.CommandTimeout = 0;
								sqlCommand.Transaction = sqlTransaction;
								sqlCommand.Parameters.Add("dateBeg", SqlDbType.DateTime).Value = filter.dateTimeBeg.Date;
								sqlCommand.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = filter.dateTimeEnd.Date.AddDays(1.0);
								new SqlDataAdapter(sqlCommand).Fill(this.dsDamage.Report81);
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
				e.Result = filter.Index;
			}
		}
		catch (Exception ex2)
		{
			MessageBox.Show(ex2.Message, ex2.Source);
		}
	}

	private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		this.toolStripMain.Enabled = true;
		this.progressBar.Visible = false;
		this.splitContainerMain.Enabled = true;
		this.bsReport81.DataMember = this.dsDamage.Report81.TableName;
		this.bsReport81.Sort = this.strSort;
		if (e.Result != null && Convert.ToInt32(e.Result) > 0)
		{
			this.dgvReport.SearchGrid(this.idDamageDgvColumn.Name, e.Result.ToString(), true);
		}
	}

	private void toolBtnExcel_Click(object sender, EventArgs e)
	{
		this.dgvReport.ExportToExcel();
	}

	private void toolBtnReport_Click(object sender, EventArgs e)
	{
		try
		{
			Microsoft.Office.Interop.Excel.Application application = new ApplicationClass();
			try
			{
				application.SheetsInNewWorkbook = 1;
				CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
				Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
				Workbook workbook = application.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
				workbook.Title = "Title";
				Worksheet worksheet = (Worksheet)workbook.Worksheets[1];
				worksheet.Name = "SheetName";
				Thread.CurrentThread.CurrentCulture = currentCulture;
				worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[999999, 35]).Font.Size = 8;
				worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, 35]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, 35]).Font.Size = 12;
				worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, 35]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				string text = "Журнал учета данных первичной информации по всем прекращениям передачи электрической энергии произошедших на объектах электросетевых организаций за ";
				if (this.rbFilterYear.Checked)
				{
					text = text + this.cmbFilterYear.SelectedItem.ToString() + " год";
				}
				else
				{
					text = text + this.dtpFilterBeg.Value.Date.ToString("dd.MM.yyyy") + " - " + this.dtpFilterEnd.Value.Date.ToString("dd.MM.yyyy");
				}
				worksheet.Cells[1, 1] = text;
				worksheet.get_Range(worksheet.Cells[2, 1], worksheet.Cells[2, 35]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[2, 1], worksheet.Cells[2, 35]).Font.Size = 12;
				worksheet.get_Range(worksheet.Cells[2, 1], worksheet.Cells[2, 35]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				text = "ООО \"Компания\"";
				System.Data.DataTable dataTable = new System.Data.DataTable("vAbnType");
				dataTable.Columns.Add("Name", typeof(string));
				base.SelectSqlData(dataTable, true, "where typeKontragent = " + 1115.ToString(), null, false, 0);
				if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["Name"] != DBNull.Value)
				{
					text = dataTable.Rows[0]["Name"].ToString();
				}
				worksheet.Cells[2, 1] = text;
				worksheet.get_Range(worksheet.Cells[4, 1], worksheet.Cells[4, 1]).Rows.RowHeight = 67.5;
				worksheet.get_Range(worksheet.Cells[5, 1], worksheet.Cells[5, 1]).Rows.RowHeight = 38;
				worksheet.get_Range(worksheet.Cells[6, 1], worksheet.Cells[6, 1]).Rows.RowHeight = 36;
				worksheet.get_Range(worksheet.Cells[7, 1], worksheet.Cells[7, 1]).Rows.RowHeight = 193;
				worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, 1]).Columns.ColumnWidth = 2.86;
				worksheet.get_Range(worksheet.Cells[4, 1], worksheet.Cells[7, 1]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 1], worksheet.Cells[7, 1]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 1], worksheet.Cells[7, 1]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 1] = "№ п/п";
				worksheet.get_Range(worksheet.Cells[1, 2], worksheet.Cells[1, 2]).Columns.ColumnWidth = 4.43;
				worksheet.get_Range(worksheet.Cells[4, 2], worksheet.Cells[7, 2]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 2], worksheet.Cells[7, 2]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 2], worksheet.Cells[7, 2]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 2] = "Наименование структурной единицы электросетевой сетевой организации";
				worksheet.get_Range(worksheet.Cells[1, 3], worksheet.Cells[1, 3]).Columns.ColumnWidth = 7;
				worksheet.get_Range(worksheet.Cells[4, 3], worksheet.Cells[7, 3]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 3], worksheet.Cells[7, 3]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 3], worksheet.Cells[7, 3]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 3], worksheet.Cells[7, 3]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 3] = "Диспетчерское наименование ПС или ЛЭП, в результате отключения которой произошло прекращение передачи электроэнергии потребителям услуг";
				worksheet.get_Range(worksheet.Cells[1, 4], worksheet.Cells[1, 4]).Columns.ColumnWidth = 3.29;
				worksheet.get_Range(worksheet.Cells[4, 4], worksheet.Cells[7, 4]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 4], worksheet.Cells[7, 4]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 4], worksheet.Cells[7, 4]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 4], worksheet.Cells[7, 4]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 4] = "Вид объекта (ПС, ЛЭП)";
				worksheet.get_Range(worksheet.Cells[1, 5], worksheet.Cells[1, 5]).Columns.ColumnWidth = 3.29;
				worksheet.get_Range(worksheet.Cells[4, 5], worksheet.Cells[7, 5]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 5], worksheet.Cells[7, 5]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 5], worksheet.Cells[7, 5]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 5], worksheet.Cells[7, 5]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 5] = "Высший класс напряжения обесточенного оборудования, кВ";
				worksheet.get_Range(worksheet.Cells[1, 6], worksheet.Cells[1, 6]).Columns.ColumnWidth = 7;
				worksheet.get_Range(worksheet.Cells[4, 6], worksheet.Cells[7, 6]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 6], worksheet.Cells[7, 6]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 6], worksheet.Cells[7, 6]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 6], worksheet.Cells[7, 6]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 6] = "Причина прекращения передачи электрической энергии (1/0)";
				worksheet.get_Range(worksheet.Cells[1, 7], worksheet.Cells[1, 7]).Columns.ColumnWidth = 3.29;
				worksheet.get_Range(worksheet.Cells[4, 7], worksheet.Cells[7, 7]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 7], worksheet.Cells[7, 7]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 7], worksheet.Cells[7, 7]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 7], worksheet.Cells[7, 7]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 7] = "Признак АПВ (1/0)";
				worksheet.get_Range(worksheet.Cells[1, 8], worksheet.Cells[1, 8]).Columns.ColumnWidth = 3.29;
				worksheet.get_Range(worksheet.Cells[4, 8], worksheet.Cells[7, 8]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 8], worksheet.Cells[7, 8]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 8], worksheet.Cells[7, 8]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 8], worksheet.Cells[7, 8]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 8] = "Признак АВР (1/0)";
				worksheet.get_Range(worksheet.Cells[4, 9], worksheet.Cells[4, 16]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 9], worksheet.Cells[4, 16]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 9], worksheet.Cells[4, 16]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.get_Range(worksheet.Cells[4, 9], worksheet.Cells[4, 16]).VerticalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 9] = "Количество точек поставки, по которым произошло прекращение передачи электрической энергии. шт";
				worksheet.get_Range(worksheet.Cells[5, 9], worksheet.Cells[5, 13]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[5, 9], worksheet.Cells[5, 13]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[5, 9], worksheet.Cells[5, 13]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.get_Range(worksheet.Cells[5, 9], worksheet.Cells[5, 13]).VerticalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[5, 9] = "Потребители электрической энергии";
				worksheet.get_Range(worksheet.Cells[6, 9], worksheet.Cells[6, 10]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[6, 9], worksheet.Cells[6, 10]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[6, 9], worksheet.Cells[6, 10]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.get_Range(worksheet.Cells[6, 9], worksheet.Cells[6, 10]).VerticalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[6, 9] = "1 категории надежности";
				worksheet.get_Range(worksheet.Cells[6, 11], worksheet.Cells[6, 12]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[6, 11], worksheet.Cells[6, 12]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[6, 11], worksheet.Cells[6, 12]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.get_Range(worksheet.Cells[6, 11], worksheet.Cells[6, 12]).VerticalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[6, 11] = "2 категории надежности";
				worksheet.get_Range(worksheet.Cells[1, 9], worksheet.Cells[1, 9]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[7, 9], worksheet.Cells[7, 9]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[7, 9], worksheet.Cells[7, 9]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[7, 9], worksheet.Cells[7, 9]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[7, 9] = "Полное";
				worksheet.get_Range(worksheet.Cells[1, 10], worksheet.Cells[1, 10]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[7, 10], worksheet.Cells[7, 10]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[7, 10], worksheet.Cells[7, 10]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[7, 10], worksheet.Cells[7, 10]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[7, 10] = "Частичное";
				worksheet.get_Range(worksheet.Cells[1, 11], worksheet.Cells[1, 11]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[7, 11], worksheet.Cells[7, 11]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[7, 11], worksheet.Cells[7, 11]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[7, 11], worksheet.Cells[7, 11]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[7, 11] = "Полное";
				worksheet.get_Range(worksheet.Cells[1, 12], worksheet.Cells[1, 12]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[7, 12], worksheet.Cells[7, 12]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[7, 12], worksheet.Cells[7, 12]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[7, 12], worksheet.Cells[7, 12]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[7, 12] = "Частичное";
				worksheet.get_Range(worksheet.Cells[1, 13], worksheet.Cells[1, 13]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[6, 13], worksheet.Cells[7, 13]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[6, 13], worksheet.Cells[7, 13]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[6, 13], worksheet.Cells[7, 13]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[6, 13], worksheet.Cells[7, 13]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[6, 13] = "3 категории надежности";
				worksheet.get_Range(worksheet.Cells[1, 14], worksheet.Cells[1, 14]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[7, 14]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[7, 14]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[7, 14]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[5, 14], worksheet.Cells[7, 14]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[5, 14] = "Электросетевые организации";
				worksheet.get_Range(worksheet.Cells[1, 15], worksheet.Cells[1, 15]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[5, 15], worksheet.Cells[7, 15]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[5, 15], worksheet.Cells[7, 15]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[5, 15], worksheet.Cells[7, 15]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[5, 15], worksheet.Cells[7, 15]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[5, 15] = "Производители электрической энергии";
				worksheet.get_Range(worksheet.Cells[1, 16], worksheet.Cells[1, 16]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[5, 16], worksheet.Cells[7, 16]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[5, 16], worksheet.Cells[7, 16]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[5, 16], worksheet.Cells[7, 16]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[5, 16], worksheet.Cells[7, 16]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[5, 16] = "Всего (сумма граф 9-15)";
				worksheet.get_Range(worksheet.Cells[4, 17], worksheet.Cells[4, 28]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 17], worksheet.Cells[4, 28]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 17], worksheet.Cells[4, 28]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.get_Range(worksheet.Cells[4, 17], worksheet.Cells[4, 28]).VerticalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 17] = "Количество потребителей услуг (производители электрической энергии) в отношении которых произошло прекращение передачи электрической энергии, шт.";
				worksheet.get_Range(worksheet.Cells[5, 17], worksheet.Cells[5, 25]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[5, 17], worksheet.Cells[5, 25]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[5, 17], worksheet.Cells[5, 25]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.get_Range(worksheet.Cells[5, 17], worksheet.Cells[5, 25]).VerticalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[5, 17] = "Потребители электрической энергии";
				worksheet.get_Range(worksheet.Cells[6, 17], worksheet.Cells[6, 18]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[6, 17], worksheet.Cells[6, 18]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[6, 17], worksheet.Cells[6, 18]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.get_Range(worksheet.Cells[6, 17], worksheet.Cells[6, 18]).VerticalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[6, 17] = "1 категории надежности";
				worksheet.get_Range(worksheet.Cells[6, 19], worksheet.Cells[6, 20]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[6, 19], worksheet.Cells[6, 20]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[6, 19], worksheet.Cells[6, 20]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.get_Range(worksheet.Cells[6, 19], worksheet.Cells[6, 20]).VerticalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[6, 19] = "2 категории надежности";
				worksheet.get_Range(worksheet.Cells[1, 17], worksheet.Cells[1, 17]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[7, 17], worksheet.Cells[7, 17]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[7, 17], worksheet.Cells[7, 17]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[7, 17], worksheet.Cells[7, 17]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[7, 17] = "Полное";
				worksheet.get_Range(worksheet.Cells[1, 18], worksheet.Cells[1, 18]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[7, 18], worksheet.Cells[7, 18]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[7, 18], worksheet.Cells[7, 18]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[7, 18], worksheet.Cells[7, 18]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[7, 18] = "Частичное";
				worksheet.get_Range(worksheet.Cells[1, 19], worksheet.Cells[1, 19]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[7, 19], worksheet.Cells[7, 19]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[7, 19], worksheet.Cells[7, 19]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[7, 19], worksheet.Cells[7, 19]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[7, 19] = "Полное";
				worksheet.get_Range(worksheet.Cells[1, 20], worksheet.Cells[1, 20]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[7, 20], worksheet.Cells[7, 20]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[7, 20], worksheet.Cells[7, 20]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[7, 20], worksheet.Cells[7, 20]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[7, 20] = "Частичное";
				worksheet.get_Range(worksheet.Cells[1, 21], worksheet.Cells[1, 21]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[6, 21], worksheet.Cells[7, 21]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[6, 21], worksheet.Cells[7, 21]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[6, 21], worksheet.Cells[7, 21]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[6, 21], worksheet.Cells[7, 21]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[6, 21] = "3 категории надежности";
				worksheet.get_Range(worksheet.Cells[1, 22], worksheet.Cells[1, 22]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[6, 22], worksheet.Cells[7, 22]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[6, 22], worksheet.Cells[7, 22]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[6, 22], worksheet.Cells[7, 22]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[6, 22], worksheet.Cells[7, 22]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[6, 22] = "С максимальной мощностью до 150 кВт";
				worksheet.get_Range(worksheet.Cells[1, 23], worksheet.Cells[1, 23]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[6, 23], worksheet.Cells[7, 23]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[6, 23], worksheet.Cells[7, 23]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[6, 23], worksheet.Cells[7, 23]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[6, 23], worksheet.Cells[7, 23]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[6, 23] = "С максимальной мощностью от 150 до 670 кВт";
				worksheet.get_Range(worksheet.Cells[1, 24], worksheet.Cells[1, 24]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[6, 24], worksheet.Cells[7, 24]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[6, 24], worksheet.Cells[7, 24]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[6, 24], worksheet.Cells[7, 24]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[6, 24], worksheet.Cells[7, 24]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[6, 24] = "С максимальной мощностью свыше 670 кВт";
				worksheet.get_Range(worksheet.Cells[1, 25], worksheet.Cells[1, 25]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[6, 25], worksheet.Cells[7, 25]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[6, 25], worksheet.Cells[7, 25]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[6, 25], worksheet.Cells[7, 25]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[6, 25], worksheet.Cells[7, 25]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[6, 25] = "Всего (сумма граф 17-21)";
				worksheet.get_Range(worksheet.Cells[1, 26], worksheet.Cells[1, 26]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[5, 26], worksheet.Cells[7, 26]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[5, 26], worksheet.Cells[7, 26]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[5, 26], worksheet.Cells[7, 26]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[5, 26], worksheet.Cells[7, 26]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[5, 26] = "Электросетевые организации";
				worksheet.get_Range(worksheet.Cells[1, 27], worksheet.Cells[1, 27]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[5, 27], worksheet.Cells[7, 27]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[5, 27], worksheet.Cells[7, 27]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[5, 27], worksheet.Cells[7, 27]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[5, 27], worksheet.Cells[7, 27]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[5, 27] = "Производители электрической энергии";
				worksheet.get_Range(worksheet.Cells[1, 28], worksheet.Cells[1, 28]).Columns.ColumnWidth = 5.57;
				worksheet.get_Range(worksheet.Cells[5, 28], worksheet.Cells[7, 28]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[5, 28], worksheet.Cells[7, 28]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[5, 28], worksheet.Cells[7, 28]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[5, 28], worksheet.Cells[7, 28]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[5, 28] = "Всего (сумма граф 25-27)";
				worksheet.get_Range(worksheet.Cells[1, 29], worksheet.Cells[1, 29]).Columns.ColumnWidth = 6.43;
				worksheet.get_Range(worksheet.Cells[4, 29], worksheet.Cells[7, 29]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 29], worksheet.Cells[7, 29]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 29], worksheet.Cells[7, 29]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 29], worksheet.Cells[7, 29]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 29] = "Время и дата прекращения передачи электрической энергии (часы, минуты, ГГГГ.ММ.ДД)";
				worksheet.get_Range(worksheet.Cells[1, 30], worksheet.Cells[1, 30]).Columns.ColumnWidth = 6.43;
				worksheet.get_Range(worksheet.Cells[4, 30], worksheet.Cells[7, 30]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 30], worksheet.Cells[7, 30]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 30], worksheet.Cells[7, 30]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 30], worksheet.Cells[7, 30]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 30] = "Время и дата устранения технологического нарушения на объектах данной сетевой организации (часы, минуты, ГГГГ.ММ.ДД)";
				worksheet.get_Range(worksheet.Cells[1, 31], worksheet.Cells[1, 31]).Columns.ColumnWidth = 6.43;
				worksheet.get_Range(worksheet.Cells[4, 31], worksheet.Cells[7, 31]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 31], worksheet.Cells[7, 31]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 31], worksheet.Cells[7, 31]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 31], worksheet.Cells[7, 31]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 31] = "Время и дата восстановления режима потребления электрической энергии потребителей услуг (часы, минуты, ГГГГ.ММ.ДД)";
				worksheet.get_Range(worksheet.Cells[1, 32], worksheet.Cells[1, 32]).Columns.ColumnWidth = 4.71;
				worksheet.get_Range(worksheet.Cells[4, 32], worksheet.Cells[7, 32]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 32], worksheet.Cells[7, 32]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 32], worksheet.Cells[7, 32]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 32], worksheet.Cells[7, 32]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 32] = "Продолжительность прекращения передачи электрической энергии, час";
				worksheet.get_Range(worksheet.Cells[1, 33], worksheet.Cells[1, 33]).Columns.ColumnWidth = 6.71;
				worksheet.get_Range(worksheet.Cells[4, 33], worksheet.Cells[7, 33]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 33], worksheet.Cells[7, 33]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 33], worksheet.Cells[7, 33]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 33], worksheet.Cells[7, 33]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 33] = "Суммарный объем фактической нагрузки (мощности) на присоединениях потребителей услуг по которым в результате технологического нарушения произошло прекращение передачи электрической энергии на момент возникновения такого события, МВТ";
				worksheet.get_Range(worksheet.Cells[1, 34], worksheet.Cells[1, 34]).Columns.ColumnWidth = 6.29;
				worksheet.get_Range(worksheet.Cells[4, 34], worksheet.Cells[7, 34]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 34], worksheet.Cells[7, 34]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 34], worksheet.Cells[7, 34]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 34], worksheet.Cells[7, 34]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 34] = "Наименование документа первичной информации (акт расследования, журнал отключений и т.п.)";
				worksheet.get_Range(worksheet.Cells[1, 35], worksheet.Cells[1, 35]).Columns.ColumnWidth = 6.29;
				worksheet.get_Range(worksheet.Cells[4, 35], worksheet.Cells[7, 35]).Merge(Type.Missing);
				worksheet.get_Range(worksheet.Cells[4, 35], worksheet.Cells[7, 35]).Orientation = 90;
				worksheet.get_Range(worksheet.Cells[4, 35], worksheet.Cells[7, 35]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 35], worksheet.Cells[7, 35]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
				worksheet.Cells[4, 35] = "Реквизиты документа первичной информации (акты расследования технологического нарушения (аварии) или иног документа (номер и дата записи в журнале отключений)";
				for (int i = 1; i <= 35; i++)
				{
					worksheet.get_Range(worksheet.Cells[8, i], worksheet.Cells[8, i]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
					worksheet.Cells[8, i] = i.ToString();
				}
				this.dsDamage.Report81.DefaultView.RowFilter = this.bsReport81.Filter;
				System.Data.DataTable dataTable2 = this.dsDamage.Report81.DefaultView.ToTable();
				int num = 9;
				foreach (object obj in dataTable2.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					worksheet.Cells[num, 1] = (num - 8).ToString();
					worksheet.Cells[num, 2] = dataRow["netRegionValue"].ToString();
					worksheet.Cells[num, 3] = dataRow["subName"].ToString();
					worksheet.Cells[num, 4] = dataRow["TypeSchmObj"].ToString();
					worksheet.Cells[num, 5] = dataRow["PowerV"].ToString();
					worksheet.Cells[num, 6] = 1;
					int num2 = 7;
					if (dataRow["APV"] != DBNull.Value && Convert.ToBoolean(dataRow["APV"]))
					{
						worksheet.Cells[num, num2] = 1;
					}
					else
					{
						worksheet.Cells[num, num2] = 0;
					}
					num2++;
					if (dataRow["AVR"] != DBNull.Value && Convert.ToBoolean(dataRow["AVR"]))
					{
						worksheet.Cells[num, num2] = 1;
					}
					else
					{
						worksheet.Cells[num, num2] = 0;
					}
					num2++;
					worksheet.Cells[num, num2] = dataRow["countPointCat1Full"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["countPointCat1"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["countPointCat2Full"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["countPointCat2"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["countPointCat3"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["countPointEE"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["countPointSource"].ToString();
					int num3 = 0;
					if (dataRow["countPointCat1Full"] != DBNull.Value)
					{
						num3 += (int)dataRow["countPointCat1Full"];
					}
					if (dataRow["countPointCat1"] != DBNull.Value)
					{
						num3 += (int)dataRow["countPointCat1"];
					}
					if (dataRow["countPointCat2Full"] != DBNull.Value)
					{
						num3 += (int)dataRow["countPointCat2Full"];
					}
					if (dataRow["countPointCat2"] != DBNull.Value)
					{
						num3 += (int)dataRow["countPointCat2"];
					}
					if (dataRow["countPointCat3"] != DBNull.Value)
					{
						num3 += (int)dataRow["countPointCat3"];
					}
					if (dataRow["countPointee"] != DBNull.Value)
					{
						num3 += (int)dataRow["countPointee"];
					}
					if (dataRow["countPointsource"] != DBNull.Value)
					{
						num3 += (int)dataRow["countPointsource"];
					}
					num2++;
					worksheet.Cells[num, num2] = num3;
					num2++;
					worksheet.Cells[num, num2] = dataRow["countAbnObjCat1Full"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["countAbnObjCat1"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["countAbnObjCat2Full"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["countAbnObjCat2"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["countAbnObjCat3"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["countAbnObj150"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["countAbnObj150670"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["countAbnObj670"].ToString();
					num3 = 0;
					if (dataRow["countAbnObjCat1Full"] != DBNull.Value)
					{
						num3 += (int)dataRow["countAbnObjCat1Full"];
					}
					if (dataRow["countAbnObjCat1"] != DBNull.Value)
					{
						num3 += (int)dataRow["countAbnObjCat1"];
					}
					if (dataRow["countAbnObjCat2Full"] != DBNull.Value)
					{
						num3 += (int)dataRow["countAbnObjCat2Full"];
					}
					if (dataRow["countAbnObjCat2"] != DBNull.Value)
					{
						num3 += (int)dataRow["countAbnObjCat2"];
					}
					if (dataRow["countAbnObjCat3"] != DBNull.Value)
					{
						num3 += (int)dataRow["countAbnObjCat3"];
					}
					num2++;
					worksheet.Cells[num, num2] = num3;
					num2++;
					worksheet.Cells[num, num2] = dataRow["countAbnObjEE"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["countAbnObjSource"].ToString();
					if (dataRow["countAbnObjee"] != DBNull.Value)
					{
						num3 += (int)dataRow["countAbnObjee"];
					}
					if (dataRow["countAbnObjsource"] != DBNull.Value)
					{
						num3 += (int)dataRow["countAbnObjsource"];
					}
					num2++;
					worksheet.Cells[num, num2] = num3;
					num2++;
					worksheet.get_Range(worksheet.Cells[num, num2], worksheet.Cells[num, num2]).NumberFormat = "@";
					if (dataRow["dateBegin"] != DBNull.Value)
					{
						worksheet.Cells[num, num2] = Convert.ToDateTime(dataRow["dateBegin"]).ToString("HH:mm dd.MM.yy");
					}
					num2++;
					worksheet.get_Range(worksheet.Cells[num, num2], worksheet.Cells[num, num2]).NumberFormat = "@";
					if (dataRow["dateApply"] != DBNull.Value)
					{
						worksheet.Cells[num, num2] = Convert.ToDateTime(dataRow["dateApply"]).ToString("HH:mm dd.MM.yy");
					}
					num2++;
					worksheet.get_Range(worksheet.Cells[num, num2], worksheet.Cells[num, num2]).NumberFormat = "@";
					if (dataRow["dateApplyMax"] != DBNull.Value)
					{
						worksheet.Cells[num, num2] = Convert.ToDateTime(dataRow["dateApplyMax"]).ToString("HH:mm dd.MM.yy");
					}
					num2++;
					worksheet.get_Range(worksheet.Cells[num, num2], worksheet.Cells[num, num2]).NumberFormat = "@";
					if (dataRow["dateApplyMax"] != DBNull.Value && dataRow["dateBegin"] != DBNull.Value)
					{
						TimeSpan t = Convert.ToDateTime(dataRow["dateApplyMax"]).AddSeconds((double)(-(double)Convert.ToDateTime(dataRow["dateApplyMax"]).Second)) - Convert.ToDateTime(dataRow["datebegin"]).AddSeconds((double)(-(double)Convert.ToDateTime(dataRow["datebegin"]).Second));
						text = ((int)t.TotalHours).ToString() + ":" + ((int)(t - TimeSpan.FromHours((double)((int)t.TotalHours))).TotalMinutes).ToString();
						worksheet.Cells[num, num2] = text;
					}
					num2++;
					num2++;
					worksheet.Cells[num, num2] = dataRow["TypeDoc"].ToString();
					num2++;
					worksheet.Cells[num, num2] = dataRow["numDateDoc"].ToString();
					num++;
				}
				worksheet.get_Range(worksheet.Cells[8, 1], worksheet.Cells[num - 1, 35]).Font.Size = 10;
				worksheet.get_Range(worksheet.Cells[8, 1], worksheet.Cells[num - 1, 35]).WrapText = true;
				worksheet.get_Range(worksheet.Cells[4, 1], worksheet.Cells[num - 1, 35]).Borders.LineStyle = XlLineStyle.xlContinuous;
				application.Visible = true;
			}
			catch (Exception ex)
			{
				application.Quit();
				throw ex;
			}
		}
		catch (Exception ex2)
		{
			MessageBox.Show(ex2.Message, ex2.Source);
		}
	}

	private class StructureFilter
	{
		public StructureFilter()
		{
			this.dateTimeBeg = DateTime.Now;
			this.dateTimeEnd = DateTime.Now;
			this.Checked = true;
			
		}

		internal int? Index;

		internal DateTime dateTimeBeg;

		internal DateTime dateTimeEnd;

		internal bool Checked;
	}

    private void btnReport_Click(object sender, EventArgs e)
    {
        this.FillReport(null);
    }
}
