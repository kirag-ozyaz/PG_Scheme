using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
//using Documents.Properties;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Documents.Measurement
{
    internal partial class FormMeasurementExistYearForm : FormBase
    {


        internal FormMeasurementExistYearForm(SQLSettings sqlsettings, int int_0)
        {
            this.InitializeComponent();
            this.SqlSettings = (sqlsettings);
            base.SelectSqlData(this.dt_tJ_Measurement, true, "where deleted = 0 and [year] is not null group by [Year] order by [Year]", null, false, 0);
            foreach (DataRow row in this.dt_tJ_Measurement.Rows)
            {
                this.toolStripComboBoxFromYear.Items.Add(row[0]);
                this.toolStripComboBoxToYear.Items.Add(row[0]);
                if (((int)row[0]) == int_0)
                {
                    this.toolStripComboBoxFromYear.SelectedIndex = this.toolStripComboBoxFromYear.Items.Count - 1;
                    this.toolStripComboBoxToYear.SelectedIndex = this.toolStripComboBoxToYear.Items.Count - 1;
                }
            }
            if (this.toolStripComboBoxFromYear.SelectedIndex == -1)
            {
                this.toolStripComboBoxFromYear.SelectedIndex = this.toolStripComboBoxFromYear.Items.Count - 1;
                this.toolStripComboBoxToYear.SelectedIndex = this.toolStripComboBoxToYear.Items.Count - 1;
            }
        }

        private void dataGridViewExcelFilterMeasExist_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.RowIndex != -1) && (e.ColumnIndex != -1))
            {
                DataGridViewColumn column = this.dataGridViewExcelFilterMeasExist.Columns[e.ColumnIndex];
                if ((column.Tag != null) || (column.ValueType == typeof(int)))
                {
                    if (((int)this.dataGridViewExcelFilterMeasExist[e.ColumnIndex, e.RowIndex].Value) == 0)
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                    }
                }
            }
        }



        private void FormMeasurementExistYearForm_Load(object sender, EventArgs e)
        {
            this.GetData();
        }

        private void GetData()
        {
            this.Cursor = Cursors.WaitCursor;
            int selectedItem = (int)this.toolStripComboBoxFromYear.SelectedItem;
            int num2 = (int)this.toolStripComboBoxToYear.SelectedItem;
            if (selectedItem > num2)
            {
                this.Cursor = Cursors.Default;
            }
            else
            {
                DataGridViewCell cellTemplate = this.dataGridViewExcelFilterMeasExist.Columns[0].CellTemplate;
                this.MeasExistTable.Filter = string.Empty;
                if (this.dtMeasExistTable.Rows.Count > 0)
                {
                    this.dtMeasExistTable.Rows.Clear();
                }
                if (this.dtMeasExistTable.Columns.Count > 0)
                {
                    this.dtMeasExistTable.Columns.Clear();
                }
                if (this.dataGridViewExcelFilterMeasExist.Rows.Count > 0)
                {
                    this.dataGridViewExcelFilterMeasExist.Rows.Clear();
                }
                if (this.dataGridViewExcelFilterMeasExist.Columns.Count > 0)
                {
                    this.dataGridViewExcelFilterMeasExist.Columns.Clear();
                }
                int num1 = 5 + (num2 - selectedItem);
                DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[num1];
                DataColumn[] columns = new DataColumn[num1 + 2];
                columns[0] = new DataColumn();
                columns[0].ColumnName = "tpname";
                columns[1] = new DataColumn();
                columns[1].ColumnName = "CharValue";
                columns[2] = new DataColumn();
                columns[2].ColumnName = "transname";
                columns[3] = new DataColumn();
                columns[3].ColumnName = "typeCaption";
                dataGridViewColumns[0] = new DataGridViewFilterTextBoxColumn();
                dataGridViewColumns[0].HeaderText = "Объект";
                dataGridViewColumns[0].DataPropertyName = "tpname";
                dataGridViewColumns[0].Name = "tpname";
                dataGridViewColumns[0].ReadOnly = true;
                dataGridViewColumns[0].ValueType = typeof(string);
                dataGridViewColumns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewColumns[0].MinimumWidth = 100;
                dataGridViewColumns[1] = new DataGridViewFilterTextBoxColumn();
                dataGridViewColumns[1].HeaderText = "Принадлежность";
                dataGridViewColumns[1].DataPropertyName = "CharValue";
                dataGridViewColumns[1].Name = "CharValue";
                dataGridViewColumns[1].ReadOnly = true;
                dataGridViewColumns[1].ValueType = typeof(string);
                dataGridViewColumns[2] = new DataGridViewFilterTextBoxColumn();
                dataGridViewColumns[2].HeaderText = "Трансформатор";
                dataGridViewColumns[2].DataPropertyName = "transname";
                dataGridViewColumns[2].Name = "transname";
                dataGridViewColumns[2].ReadOnly = true;
                dataGridViewColumns[2].ValueType = typeof(string);
                dataGridViewColumns[3] = new DataGridViewFilterTextBoxColumn();
                dataGridViewColumns[3].HeaderText = "Тип";
                dataGridViewColumns[3].DataPropertyName = "typeCaption";
                dataGridViewColumns[3].Name = "typeCaption";
                dataGridViewColumns[3].ReadOnly = true;
                dataGridViewColumns[3].ValueType = typeof(string);
                int index = 4;
                for (int i = selectedItem; i <= num2; i++)
                {
                    columns[index] = new DataColumn();
                    columns[index].ColumnName = i.ToString();
                    columns[index].DataType = typeof(int);
                    columns[index].DefaultValue = 0;
                    dataGridViewColumns[index] = new DataGridViewFilterTextBoxColumn();
                    dataGridViewColumns[index].HeaderText = i.ToString();
                    dataGridViewColumns[index].Name = i.ToString() + "v";
                    dataGridViewColumns[index].DataPropertyName = i.ToString();
                    dataGridViewColumns[index].ReadOnly = true;
                    dataGridViewColumns[index].ValueType = typeof(int);
                    dataGridViewColumns[index].Tag = i;
                    index++;
                }
                columns[columns.Length - 2] = new DataColumn();
                columns[columns.Length - 2].ColumnName = "type";
                columns[columns.Length - 2].DataType = typeof(int);
                columns[columns.Length - 1] = new DataColumn();
                columns[columns.Length - 1].ColumnName = "transid";
                columns[columns.Length - 1].DataType = typeof(int);
                this.dtMeasExistTable.Columns.AddRange(columns);
                this.dataGridViewExcelFilterMeasExist.Columns.AddRange(dataGridViewColumns);
                SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString());
                SqlCommand command = new SqlCommand(string.Format("with Meas ([id], [year], [TypeDoc], [valueid], [transid])\r\n                                            as\r\n                                            (\r\n                                            select m.id, m.[Year],m.[TypeDoc], (case m.[TypeDoc] when 1191 then mc.id else case m.[TypeDoc] when 1192 then mt.id end end) valueid \r\n                                            ,(case m.[TypeDoc] when 1191 then mc.idObjList else case m.[TypeDoc] when 1192 then mt.idObjList end end) transid   -- mt.id,mt.idObjList,mc.id, mc.idObjList \r\n                                            from [tJ_Measurement] m\r\n                                            left join [tJ_MeasAmperageTransf] as mt on mt.idMeasurement = m.id and mt.deleted=0\r\n                                            left join tJ_MeasVoltageTransf as mc on mc.idMeasurement = m.id and mc.deleted=0\r\n                                            where m.deleted = 0\r\n                                            )\r\n\r\n                                            SELECT \r\n                                            c.Name+'-'+p.[Name]as tpname\r\n                                                  ,pa.[CharValue]\r\n                                                  ,t.[Id] as transid\r\n                                                  ,t.[Name] as transname\r\n                                                  ,Meas.[TypeDoc] as [type]\r\n                                                  ,Meas.[year]   \r\n                                              FROM [tSchm_ObjList] as t  \r\n                                              inner join [tSchm_ObjList] p on p.id = t.idParentAddl\r\n                                              inner join tr_Classifier as c on c.id = p.[TypeCodeId]\r\n                                              left join vP_PassportDataReports as pa on  pa.[IdObj] =p.id and pa.typecodeid in (538,535,537,536) and pa.[CharName] like 'Принадлежность'\r\n                                              left join Meas on Meas.[transid] = t.[Id]\r\n                                              where t.[TypeCodeId] = 556 and t.deleted = 0 and ((Meas.[year]>={0} and Meas.[year]<={1}) or Meas.[year] is null)\r\n                                              order by p.[TypeCodeId], p.[Name],Meas.[year]", selectedItem, num2), connection);
                SqlDataReader reader = null;
                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                }
                catch
                {
                }
                while (reader.Read())
                {
                    bool flag;
                    DataRow[] rowArray;
                    if (flag = reader.IsDBNull(4))
                    {
                        rowArray = new DataRow[0];
                    }
                    else
                    {
                        rowArray = this.dtMeasExistTable.Select(string.Format("transid = {0} and type = {1}", reader["transid"], reader["type"]));
                    }
                    DataRow row = null;
                    if (rowArray.Length == 0)
                    {
                        //1191
                        DataRow row2 = this.dtMeasExistTable.NewRow();
                        row2["tpname"] = reader["tpname"];
                        row2["CharValue"] = reader["CharValue"];
                        row2["transname"] = reader["transname"];
                        row2["transid"] = reader["transid"];
                        row2["typeCaption"] = "0,4 кВ";
                        row2["type"] = 1191;
                        this.dtMeasExistTable.Rows.Add(row2);
                        if (!flag && (((int)reader["type"]) == 1191))
                        {
                            row = row2;
                        }
                        //1192
                        row2 = this.dtMeasExistTable.NewRow();
                        row2["tpname"] = reader["tpname"];
                        row2["CharValue"] = reader["CharValue"];
                        row2["transname"] = reader["transname"];
                        row2["transid"] = reader["transid"];
                        row2["typeCaption"] = "6-10 кВ";
                        row2["type"] = 1192;
                        this.dtMeasExistTable.Rows.Add(row2);
                        if (!flag && (((int)reader["type"]) == 1192))
                        {
                            row = row2;
                        }
                    }
                    else
                    {
                        row = rowArray[0];
                    }
                    int num5 = reader.IsDBNull(5) ? -1 : ((int)reader["year"]);
                    foreach (DataColumn column in this.dtMeasExistTable.Columns)
                    {
                        if (column.ColumnName == num5.ToString())
                        {
                            int num6 = (int)row[column];
                            row[column] = num6 + 1;
                        }
                    }
                }
                reader.Close();
                connection.Close();
                this.Cursor = Cursors.Default;
            }
        }

             private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            this.GetData();
        }

        private void toolStripButtonToExcel_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilterMeasExist.ExportToExcel();
        }

        private void toolStripComboBoxFromYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.toolStripComboBoxFromYear.SelectedIndex > this.toolStripComboBoxToYear.SelectedIndex)
            {
                this.toolStripComboBoxToYear.SelectedIndex = this.toolStripComboBoxFromYear.SelectedIndex;
            }
        }

        private void toolStripComboBoxToYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.toolStripComboBoxFromYear.SelectedIndex > this.toolStripComboBoxToYear.SelectedIndex)
            {
                this.toolStripComboBoxFromYear.SelectedIndex = this.toolStripComboBoxToYear.SelectedIndex;
            }
        }
    }

}