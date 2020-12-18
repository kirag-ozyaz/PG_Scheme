using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using FormLbr;
using Logger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASCAPC
{
    public partial class DlgStructFiderReestr : FormBase
    {
        //LibraryTSQL.SqlDataCommand tSQL;
        public DlgStructFiderReestr()
        {
            InitializeComponent();
            Text = "Реестр точек измерения в базе данных TOK-5";


        }

        private void toolBtnExportExcel_Click(object sender, EventArgs e)
        {
            this.dgvResultat.ExportToExcel();
        }

        private void toolBtnRefresh_Click(object sender, EventArgs e)
        {
            LoadReestr();
        }

        private void LoadReestr()
        {
            dgvResultat.Columns.Clear();
            DataTable dataTable = new DataTable();

            this.SqlSettings = new SQLSettings(new SQLSettingsTok5());

            SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
            try
            {
                sqlConnection.Open();
                new SqlDataAdapter(string.Concat(new string[]
                {"SELECT  [NODES].[OBJECT_CODE],[OBJECTS].[OBJECT_NAME],[NODES].[NODE_CODE],[NODES].[NODE_NAME],[NODES].[PER_CENT_GS],[NODES].[VISIBLE],[NODES].[CALC_FACTOR] Множитель,[NODES].[XML80020_NODECODE] " +
                " FROM [NODES]" +
                "  left join [OBJECTS] on [NODES].[OBJECT_CODE] = [OBJECTS].[OBJECT_CODE]" +
                "  where[NODES].[Deleted] = 0 and [OBJECTS].[Deleted] = 0"}), sqlConnection).Fill(dataTable);

                foreach (DataColumn col in dataTable.Columns)
                {
                    DataGridViewFilterTextBoxColumn columnDgv = new DataGridViewFilterTextBoxColumn();
                    columnDgv.Name = col.ColumnName;
                    columnDgv.HeaderText = col.ColumnName;
                    columnDgv.DataPropertyName = col.ColumnName;

                    dgvResultat.Columns.Add(columnDgv);

                }
                BindingSource bsResult = new BindingSource();
                bsResult.DataSource = dataTable;
                dgvResultat.DataSource = bsResult;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private void DlgStructFiderReestr_Load(object sender, EventArgs e)
        {
            LoadReestr();
        }
    }
}
