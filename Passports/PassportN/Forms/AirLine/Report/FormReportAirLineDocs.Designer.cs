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
using DataSql;
using FormLbr;
using Microsoft.Reporting.WinForms;

namespace Passport.Forms.AirLine.Report
{
	public class FormReportAirLineDocs : FormBase
	{
		public int IdTypeDoc
		{
			get
			{
				return this.int_2;
			}
			set
			{
				this.int_2 = value;
				this.nullable_0 = this.method_15(this.int_2);
			}
		}

		public FormReportAirLineDocs()
		{
			Class330.Mus9JxKz1CNxy();
			this.int_0 = -1;
			this.int_1 = -1;
			base..ctor();
			this.method_16();
		}

		public FormReportAirLineDocs(int IdObjList, int IdDoc)
		{
			Class330.Mus9JxKz1CNxy();
			this.int_0 = -1;
			this.int_1 = -1;
			base..ctor();
			this.method_16();
			this.int_0 = IdObjList;
			this.int_1 = IdDoc;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.method_0();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			int? num = this.nullable_0;
			if (num != null)
			{
				switch (num.GetValueOrDefault())
				{
				}
			}
		}

		private void method_0()
		{
			int? num = this.nullable_0;
			if (num != null)
			{
				switch (num.GetValueOrDefault())
				{
				case 1:
				case 2:
					this.method_10();
					this.method_1();
					return;
				case 3:
					break;
				case 4:
				{
					Control mhXmiNrfhs = this.MhXmiNrfhs3;
					this.MhXmiNrfhs3.Visible = false;
					mhXmiNrfhs.Enabled = false;
					this.method_9();
					return;
				}
				case 5:
				{
					Control mhXmiNrfhs2 = this.MhXmiNrfhs3;
					this.MhXmiNrfhs3.Visible = false;
					mhXmiNrfhs2.Enabled = false;
					this.method_5();
					break;
				}
				default:
					return;
				}
			}
		}

		private void method_1()
		{
			this.reportViewer_0.Reset();
			this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.AirLine.Report.ReportAirLineRepair.rdlc";
			this.reportViewer_0.LocalReport.DataSources.Clear();
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsMain", this.method_2()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsWork", this.method_3()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsAddress", this.method_4()));
			List<ReportParameter> list = new List<ReportParameter>();
			list.Add(new ReportParameter("company", this.method_13()));
			list.Add(new ReportParameter("post", this.textBox_1.Text));
			list.Add(new ReportParameter("worker", this.textBox_0.Text));
			list.Add(new ReportParameter("dateReport", this.dateTimePicker_0.Value.ToString("dd MMMM yyyy г.")));
			list.Add(new ReportParameter("objList", this.method_14(this.int_0)));
			this.reportViewer_0.LocalReport.SetParameters(list);
			this.reportViewer_0.RefreshReport();
		}

		private DataTable method_2()
		{
			string cmdText = string.Format("select distinct d.*, hr.[Description] as postHeadRegion, hr.FIO as nameHeadRegion,\r\nen.[Description] as postEngineerPTS, en.FIO as nameEngineerPTS\r\nfrom (select doc.id, doc.ParentId, doc.NumberDoc, doc.Comment,\r\n        doc.dateDoc,\r\n        col.value('(./cmbHeadNetRegion)[1]', 'int') as idHeadNetRegion,\r\n        col.value('(./cmbEngineerPTS)[1]', 'int') as idEngineerPTS,\r\n        col.value('(./txtLength)[1]', 'nvarchar(max)') as [Length],\r\n        col.value('(./txtFrom)[1]', 'nvarchar(max)') as [From],\r\n        col.value('(./txtTo)[1]', 'nvarchar(max)') as [To],\r\n        col.value('(./txtCount)[1]', 'nvarchar(max)') as treeCount\r\n        from tP_DocList as doc\r\n        cross apply DataXml.nodes('/AddlData') x(col)\r\n        where id = '{0}') as d\r\nleft join vWorkerGroup as hr on hr.id = d.idHeadNetRegion\r\nleft join vWorkerGroup as en on en.id = d.idEngineerPTS", this.int_1);
			this.dataTable_0 = new DataSetReportAirLinePassport.dtReportAirLineRepairMainDataTable();
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					sqlDataAdapter.Fill(this.dataTable_0);
					sqlCommand.Dispose();
					sqlDataAdapter.Dispose();
					sqlConnection.Close();
				}
				catch
				{
					sqlConnection.Close();
				}
			}
			return this.dataTable_0;
		}

		private DataTable method_3()
		{
			string cmdText = string.Format("select distinct d.*, pylon.Name as Pylon\r\nfrom (select doc.id as idDoc, \r\n        col.value('(./Name)[1]', 'nvarchar(max)') as Name,\r\n        col.value('(./Unit)[1]', 'nvarchar(max)') as [Unit],\r\n        col.value('(./Count)[1]', 'nvarchar(max)') as [Count],\r\n        col.value('(./idPylon)[1]', 'int') as [idPylon]\r\n        from tP_DocList as doc\r\n        cross apply DataXml.nodes('/AddlData/DataSetWork/tWork') x(col)\r\n        where id = '{0}') as d\r\nleft join tSchm_ObjList as pylon on pylon.id = d.idPylon", this.int_1);
			this.dataTable_1 = new DataSetReportAirLinePassport.dtReportAirLineRepairWorkDataTable();
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					sqlDataAdapter.Fill(this.dataTable_1);
					sqlCommand.Dispose();
					sqlDataAdapter.Dispose();
					sqlConnection.Close();
				}
				catch
				{
					sqlConnection.Close();
				}
			}
			if (this.dataTable_1.Rows.Count == 0)
			{
				this.dataTable_1.Rows.Add(new object[]
				{
					-1
				});
			}
			return this.dataTable_1;
		}

		private DataTable method_4()
		{
			string cmdText = string.Format("select doc.id as idDoc, doc.ParentId, doc.idObjList, \r\ncol.value('(./Name)[1]', 'nvarchar(max)') as Name\r\nfrom tP_DocList as doc\r\ncross apply DataXml.nodes('/AddlData/DataSetWork/tAddress') x(col)\r\nwhere id = '{0}'", this.int_1);
			DataTable dataTable = new DataSetReportAirLinePassport.dtReportAirLineRepairAddressDataTable();
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					sqlDataAdapter.Fill(dataTable);
					sqlCommand.Dispose();
					sqlDataAdapter.Dispose();
					sqlConnection.Close();
				}
				catch
				{
					sqlConnection.Close();
				}
			}
			if (dataTable.Rows.Count == 0)
			{
				dataTable.Rows.Add(new object[]
				{
					-1
				});
			}
			return dataTable;
		}

		private void method_5()
		{
			this.reportViewer_0.Reset();
			this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.AirLine.Report.ReportAirLineInspect.rdlc";
			this.reportViewer_0.LocalReport.DataSources.Clear();
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsDefect", this.method_6()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsWorker", this.method_8()));
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("dsOther", this.method_7()));
			List<ReportParameter> list = new List<ReportParameter>();
			list.Add(new ReportParameter("company", this.method_13()));
			list.Add(new ReportParameter("netRegion", "qwe123"));
			this.reportViewer_0.LocalReport.SetParameters(list);
			this.reportViewer_0.RefreshReport();
		}

		private DataTable method_6()
		{
			string text = string.Format("select d.idDoc, d.Defect, d.idPylon, ol.Name as Pylon\r\nfrom (select doc.id as idDoc, \r\n            col.value('(./Name)[1]', 'nvarchar(max)') as Defect,\r\n            col.value('(./idPylon)[1]', 'int') as idPylon\r\nfrom tP_DocList as doc\r\ncross apply doc.DataXml.nodes('/AddlData/DataSetAirLineInspect/tDefect') x(col)\r\nwhere doc.id = '{0}') as d\r\nleft join tSchm_ObjList as ol on ol.id = d.idPylon", this.int_1);
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			if (dataTable.Rows.Count == 0)
			{
				dataTable.Rows.Add(dataTable.NewRow());
			}
			return dataTable;
		}

		private DataTable method_7()
		{
			string text = string.Format("select d.idTypeInspect, cl.Name as TypeInspect\r\nfrom (select doc.id as idDoc, \r\n            col.value('(./idInspect)[1]', 'int') as idTypeInspect\r\nfrom tP_DocList as doc\r\ncross apply doc.DataXml.nodes('/AddlData/DataSetAirLineInspect/tOther') x(col)\r\nwhere doc.id = '{0}') as d\r\nleft join tR_Classifier as cl on cl.id = d.idTypeInspect", this.int_1);
			return new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
		}

		private DataTable method_8()
		{
			string text = string.Format("select d.id, w.FIO as Name\r\nfrom (select doc.id as idDoc, \r\n            col.value('(./Name)[1]', 'nvarchar(max)') as Name,\r\n            col.value('(./id)[1]', 'int') as id\r\nfrom tP_DocList as doc\r\ncross apply doc.DataXml.nodes('/AddlData/DataSetAirLineInspect/tWorker') x(col)\r\nwhere doc.id = '{0}') as d\r\nleft join vP_Worker as w on w.id = d.id", this.int_1);
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			if (dataTable.Rows.Count == 0)
			{
				dataTable.Rows.Add(dataTable.NewRow());
			}
			return dataTable;
		}

		private void method_9()
		{
			this.reportViewer_0.Reset();
			this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.AirLine.Report.ReportPylonEquipExpl.rdlc";
			this.reportViewer_0.LocalReport.DataSources.Clear();
			this.reportViewer_0.LocalReport.DataSources.Add(new ReportDataSource("ds", new DataTable()));
			this.reportViewer_0.RefreshReport();
		}

		private void method_10()
		{
			base.SelectSqlData(this.dataSetReportAirLinePassport_0.tSettings, true, "where module = 'ReportAirLineRepair'", null, false, 0);
			if (this.dataSetReportAirLinePassport_0.tSettings.Rows.Count > 0)
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(Class13));
				StringReader textReader = new StringReader(this.dataSetReportAirLinePassport_0.tSettings.Rows[0]["Settings"].ToString());
				this.class13_0 = (Class13)xmlSerializer.Deserialize(textReader);
			}
			else
			{
				this.class13_0 = new Class13();
			}
			this.method_11();
		}

		private void method_11()
		{
			this.textBox_0.Text = this.class13_0.Name;
			this.textBox_1.Text = this.class13_0.method_0();
		}

		private void method_12()
		{
			this.class13_0.Name = this.textBox_0.Text.Trim();
			this.class13_0.method_1(this.textBox_1.Text.Trim());
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Class13));
			new XDocument();
			StringWriter stringWriter = new StringWriter();
			xmlSerializer.Serialize(stringWriter, this.class13_0);
			base.SelectSqlData(this.dataSetReportAirLinePassport_0.tSettings, true, "where module = 'ReportAirLineRepair'", null, false, 0);
			if (this.dataSetReportAirLinePassport_0.tSettings.Rows.Count == 0)
			{
				DataRow dataRow = this.dataSetReportAirLinePassport_0.tSettings.NewRow();
				dataRow["Settings"] = stringWriter.ToString();
				dataRow["Module"] = "ReportAirLineRepair";
				dataRow.EndEdit();
				this.dataSetReportAirLinePassport_0.tSettings.Rows.Add(dataRow);
				base.InsertSqlData(this.dataSetReportAirLinePassport_0.tSettings);
				return;
			}
			this.dataSetReportAirLinePassport_0.tSettings.Rows[0]["Settings"] = stringWriter.ToString();
			this.dataSetReportAirLinePassport_0.tSettings.Rows[0].EndEdit();
			base.UpdateSqlDataOnlyChange(this.dataSetReportAirLinePassport_0.tSettings);
		}

		private string method_13()
		{
			DataTable dataTable = new DataTable("vAbnType");
			base.SelectSqlData(dataTable, true, string.Format(" where typeKontragent = {0} ", 1115), null, false, 0);
			if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["Name"] != DBNull.Value)
			{
				return dataTable.Rows[0]["Name"].ToString();
			}
			return "";
		}

		private string method_14(int int_3)
		{
			string text = string.Format("select ISNULL(c_ol.SocrName + ' - ', '') + ol.Name as FullName\r\nfrom tSchm_ObjList as ol\r\nleft join tR_Classifier as c_ol on c_ol.Id = ol.TypeCodeId\r\nwhere ol.Deleted = '0' and ol.id = '{0}'", int_3);
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			if (dataTable != null && dataTable.Rows.Count > 0)
			{
				return Convert.ToString(dataTable.Rows[0]["FullName"]);
			}
			return string.Empty;
		}

		private int? method_15(int int_3)
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Name", typeof(string));
			dataTable.Columns.Add("Value", typeof(decimal));
			string text = string.Format("where id = '{0}'", int_3);
			base.SelectSqlData(dataTable, true, text, null, false, 0);
			if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["Value"] is decimal)
			{
				return new int?(Convert.ToInt32(dataTable.Rows[0]["Value"]));
			}
			return null;
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			this.method_0();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			FormReportAirLineDocs.m4Rrh893TIlbXGGq5774(this, disposing);
		}

		private void method_16()
		{
			this.MhXmiNrfhs3 = new Panel();
			this.button_0 = new Button();
			this.textBox_0 = new TextBox();
			this.bgJmilAqQo9 = new Label();
			this.textBox_1 = new TextBox();
			this.label_0 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.label_1 = new Label();
			this.splitter_0 = new Splitter();
			this.reportViewer_0 = new ReportViewer();
			this.dataSetReportAirLinePassport_0 = new DataSetReportAirLinePassport();
			this.MhXmiNrfhs3.SuspendLayout();
			((ISupportInitialize)this.dataSetReportAirLinePassport_0).BeginInit();
			base.SuspendLayout();
			this.MhXmiNrfhs3.Controls.Add(this.button_0);
			this.MhXmiNrfhs3.Controls.Add(this.textBox_0);
			this.MhXmiNrfhs3.Controls.Add(this.bgJmilAqQo9);
			this.MhXmiNrfhs3.Controls.Add(this.textBox_1);
			this.MhXmiNrfhs3.Controls.Add(this.label_0);
			this.MhXmiNrfhs3.Controls.Add(this.dateTimePicker_0);
			this.MhXmiNrfhs3.Controls.Add(this.label_1);
			this.MhXmiNrfhs3.Dock = DockStyle.Left;
			this.MhXmiNrfhs3.Location = new Point(0, 0);
			this.MhXmiNrfhs3.Name = "panel1";
			this.MhXmiNrfhs3.Size = new Size(155, 521);
			this.MhXmiNrfhs3.TabIndex = 0;
			this.button_0.Location = new Point(68, 138);
			this.button_0.Name = "btnReload";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 6;
			this.button_0.Text = "Обновить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.textBox_0.Location = new Point(12, 112);
			this.textBox_0.Name = "txtName";
			this.textBox_0.Size = new Size(131, 20);
			this.textBox_0.TabIndex = 5;
			this.bgJmilAqQo9.AutoSize = true;
			this.bgJmilAqQo9.Location = new Point(12, 96);
			this.bgJmilAqQo9.Margin = new Padding(3, 3, 3, 0);
			this.bgJmilAqQo9.Name = "label3";
			this.bgJmilAqQo9.Size = new Size(34, 13);
			this.bgJmilAqQo9.TabIndex = 4;
			this.bgJmilAqQo9.Text = "ФИО";
			this.textBox_1.Location = new Point(12, 70);
			this.textBox_1.Name = "txtPost";
			this.textBox_1.Size = new Size(131, 20);
			this.textBox_1.TabIndex = 3;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 54);
			this.label_0.Margin = new Padding(3, 3, 3, 0);
			this.label_0.Name = "label2";
			this.label_0.Size = new Size(65, 13);
			this.label_0.TabIndex = 2;
			this.label_0.Text = "Должность";
			this.dateTimePicker_0.Location = new Point(12, 28);
			this.dateTimePicker_0.Name = "dtpDateReport";
			this.dateTimePicker_0.Size = new Size(131, 20);
			this.dateTimePicker_0.TabIndex = 1;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(12, 12);
			this.label_1.Margin = new Padding(3, 3, 3, 0);
			this.label_1.Name = "label1";
			this.label_1.Size = new Size(69, 13);
			this.label_1.TabIndex = 0;
			this.label_1.Text = "Дата отчета";
			this.splitter_0.Location = new Point(155, 0);
			this.splitter_0.Name = "splitter1";
			this.splitter_0.Size = new Size(3, 521);
			this.splitter_0.TabIndex = 1;
			this.splitter_0.TabStop = false;
			this.reportViewer_0.Dock = DockStyle.Fill;
			this.reportViewer_0.Location = new Point(158, 0);
			this.reportViewer_0.Name = "rViewMain";
			this.reportViewer_0.Size = new Size(515, 521);
			this.reportViewer_0.TabIndex = 2;
			this.dataSetReportAirLinePassport_0.DataSetName = "DataSetReportAirLinePassport";
			this.dataSetReportAirLinePassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(673, 521);
			base.Controls.Add(this.reportViewer_0);
			base.Controls.Add(this.splitter_0);
			base.Controls.Add(this.MhXmiNrfhs3);
			base.Name = "FormReportAirLineRepair";
			this.Text = "FormReportRepair";
			this.MhXmiNrfhs3.ResumeLayout(false);
			this.MhXmiNrfhs3.PerformLayout();
			((ISupportInitialize)this.dataSetReportAirLinePassport_0).EndInit();
			base.ResumeLayout(false);
		}

		internal static void m4Rrh893TIlbXGGq5774(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private Class13 class13_0;

		private int int_0;

		private int int_1;

		private int? nullable_0;

		private int int_2;

		private DataTable dataTable_0;

		private DataTable dataTable_1;

		private IContainer icontainer_0;

		private Panel MhXmiNrfhs3;

		private Splitter splitter_0;

		private ReportViewer reportViewer_0;

		private TextBox textBox_0;

		private Label bgJmilAqQo9;

		private TextBox textBox_1;

		private Label label_0;

		private DateTimePicker dateTimePicker_0;

		private Label label_1;

		private Button button_0;

		private DataSetReportAirLinePassport dataSetReportAirLinePassport_0;
	}
}
