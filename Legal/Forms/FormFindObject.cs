using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;


namespace Legal.Forms
{
    public partial class FormFindObject : FormLbr.FormBase
    {
        private int DOGID = -1;
        private int OBJACTIVE = -1;
        private int IDDOCUM = -1;

        public FormFindObject(int DogID, int ObjActive, int idDocum)
        {
            InitializeComponent();
            DOGID = DogID;
            OBJACTIVE = ObjActive;
            IDDOCUM = idDocum;
        }



        private void FormAbnFind_Load(object sender, EventArgs e)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "select * from fn_LegGetObj3(@idDogovor, @ObjActive, @idDocum) ";
                strCmd += " order by NumberObj, NumberSubObj ";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                SqlParameter p1 = new SqlParameter("@idDogovor", DOGID);
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@ObjActive", OBJACTIVE);
                sqlCmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@idDocum", IDDOCUM);
                sqlCmd.Parameters.Add(p3);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsFind1, "vG_LegGetObj3");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }

        }

        private void dgvAbn_KeyDown(object sender, KeyEventArgs e)
        {
        }


        private void dgvAbn_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormCntVal frm = (FormCntVal)this.Owner;
            frm.OBJSELECT = Convert.ToInt32(dgvAbn.CurrentRow.Cells["idObj"].Value);
            this.DialogResult = DialogResult.OK;
            frm = null;
            this.Close();
            this.Dispose();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = dsFind1.vG_LegGetObj3; 

            Excel.Application excelapp = new Excel.Application();

            excelapp.SheetsInNewWorkbook = 1;
            excelapp.Workbooks.Add(Type.Missing);

            Excel.Workbooks excelappworkbooks = excelapp.Workbooks;
            Excel.Workbook excelappworkbook = excelappworkbooks[1];

            Excel.Sheets excelsheets = excelappworkbook.Worksheets;
            Excel.Worksheet excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);

            Excel.Range excelcells;

            // Заголовок
            excelcells = (Excel.Range)excelworksheet.Cells[1, 1];
            excelcells.Value2 = "";
            // Шапка
            for (int i = 1; i <= dt.Columns.Count; i++)
            {
                excelcells = (Excel.Range)excelworksheet.Cells[2, i];
                excelcells.Value2 = dt.Columns[i - 1].ColumnName;
            }
            // Данные
            int c = 1;
            foreach (DataRow row in dt.Rows)
            {
                c++;
                foreach (DataColumn column in dt.Columns)
                {
                    excelcells = (Excel.Range)excelworksheet.Cells[c + 1, column.Ordinal + 1];
                    if (column.DataType == Type.GetType("System.String"))
                        excelcells.NumberFormat = "@";
                    if (column.DataType == Type.GetType("System.DateTime"))
                        excelcells.NumberFormat = @"ДД.ММ.ГГГГ";
                    if (column.DataType == Type.GetType("System.Boolean"))
                        excelcells.NumberFormat = "@";

                    excelcells.Value2 = row[column];
                }
            }
            this.Cursor = Cursors.Default;
            excelapp.Visible = true;
            return;
        }

    }
}
