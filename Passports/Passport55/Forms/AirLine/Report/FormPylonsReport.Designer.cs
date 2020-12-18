using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;
using Microsoft.Reporting.WinForms;
using Passport.Classes;

namespace Passport.Forms.AirLine.Report
{
	public class FormPylonsReport : FormBase
	{
		public FormPylonsReport(int IdAirLine)
		{
			this.method_5();
			this.int_0 = IdAirLine;
		}

		private void FormPylonsReport_Load(object sender, EventArgs e)
		{
			this.int_1 = this.method_1();
			this.method_0();
		}

		private void method_0()
		{
			this.reportViewer_0.Reset();
			this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.AirLine.Report.ReportPylons.rdlc";
			this.reportViewer_0.LocalReport.DataSources.Clear();
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsPylons", this.method_2()));
			this.reportViewer_0.LocalReport.SetParameters(new ReportParameter("company", this.method_3()));
			this.reportViewer_0.RefreshReport();
		}

		private int method_1()
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Name", typeof(string));
			dataTable.Columns.Add("Value", typeof(decimal));
			base.SelectSqlData(dataTable, true, "where ParentKey = ';SCM;Pole;' and Value = '1' and deleted = '0' and isGroup = '0'", false);
			if (dataTable.Rows.Count > 0)
			{
				return Convert.ToInt32(dataTable.Rows[0]["id"]);
			}
			return -1;
		}

		private DataTable method_2()
		{
			string where = string.Format("LEFT JOIN tP_CabSection as cs on ol.id = cs.idClutchSecond\r\nleft join tR_Cable as cab on cab.id = cs.idEquipment\r\nwhere (ol.idParent = '{0}' and ol.deleted = '0'\r\nand ol.typeCodeId in (select id From tR_Classifier where ParentKey = ';SCM;Pole;'\r\nand deleted = '0' and isGroup = '0'))\r\nor (ol.deleted = '0' and ol.id in (select idClutchFirst as idPylon\r\nfrom tP_CabSection where idObjList = '{0}' and deleted = '0' union\r\nselect idClutchSecond as idPylon from tP_CabSection\r\nwhere idObjList = '{0}' and deleted = '0'))", this.int_0);
			DataTable dataTable = new DataTable();
			dataTable = PassportData.GetEquipmentData(this.SqlSettings, this.int_1, ", typeName, SpanLength, CableMakeUp, EquipmentList", ", c_ol.Name as typeName, cs.[Length] as SpanLength,cast(cab.CableMakeup as nvarchar(max)) + ' ' + \r\ncast(cab.Wires as nvarchar(max)) + 'X' + \r\ncast(cab.CrossSection as nvarchar(max)) as CableMakeUp,STUFF((select ', ' + Name from tSchm_ObjList as equip\r\n" + string.Format("where equip.idParentAddl = ol.id and equip.IdParent = '{0}'\r\n", this.int_0) + "for xml path('')),1,2,'') as EquipmentList", where, "order by Name", false);
			if (dataTable == null || dataTable.Rows.Count == 0)
			{
				dataTable.Columns.Add("idd", typeof(int));
				DataRow dataRow = dataTable.NewRow();
				dataRow["idd"] = -1;
				dataRow.EndEdit();
				dataTable.Rows.Add(dataRow);
			}
			return dataTable;
		}

		private string method_3()
		{
			DataTable dataTable = new DataTable("vAbnType");
			base.SelectSqlData(dataTable, true, string.Format(" where typeKontragent = {0} ", 1115), false);
			if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["Name"] != DBNull.Value)
			{
				return dataTable.Rows[0]["Name"].ToString();
			}
			return "";
		}

		private void method_4(DataTable dataTable_0)
		{
			foreach (object obj in dataTable_0.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj;
				dataColumn.ColumnName = dataColumn.ColumnName.Replace(" ", string.Empty);
				dataColumn.ColumnName = dataColumn.ColumnName.Replace("-", string.Empty);
				dataColumn.ColumnName = dataColumn.ColumnName.Replace("(", string.Empty);
				dataColumn.ColumnName = dataColumn.ColumnName.Replace(")", string.Empty);
				dataColumn.ColumnName = dataColumn.ColumnName.Replace(",", string.Empty);
				dataColumn.ColumnName = dataColumn.ColumnName.Replace(".", string.Empty);
				dataColumn.ColumnName = dataColumn.ColumnName.Replace("_", string.Empty);
				dataColumn.ColumnName = dataColumn.ColumnName.Replace("Ё", "Е");
				dataColumn.ColumnName = dataColumn.ColumnName.Replace("ё", "е");
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_5()
		{
			this.reportViewer_0 = new ReportViewer();
			base.SuspendLayout();
			this.reportViewer_0.Dock = DockStyle.Fill;
			this.reportViewer_0.Location = new Point(0, 0);
			this.reportViewer_0.Name = "rViewer";
			this.reportViewer_0.Size = new Size(769, 514);
			this.reportViewer_0.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(769, 514);
			base.Controls.Add(this.reportViewer_0);
			base.Name = "FormPylonsReport";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Поопорная ведомость";
			base.Load += this.FormPylonsReport_Load;
			base.ResumeLayout(false);
		}

		private int int_0 = -1;

		private int int_1 = -1;

		private IContainer icontainer_0;

		private ReportViewer reportViewer_0;
	}
}
