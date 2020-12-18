using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;



namespace Legal.Forms.Object
{
    public partial class FormLObj : FormLbr.FormBase
    {
        public FormLObj()
        {
            InitializeComponent();
        }

        private void FormLObj_Load(object sender, EventArgs e)
        {
            cbStatus.ComboBox.SelectedIndex = 0;
            this.SelectSqlDataTableOther(dsObj1, dsObj1.vG_AbnObj, "vG_AbnObj_New", true, " order By ObjName");

            SelectSqlData(dsObj1, dsObj1.vWorkerGroup, true, " where idGroup = " + Constants.Constants.WorkerGroupMasterUL);
            cmbMaster.ComboBox.DataSource = dsObj1.vWorkerGroup;
            cmbMaster.ComboBox.DisplayMember = "FIO";
            cmbMaster.ComboBox.ValueMember = "id";

            SelectSqlData(dsObj1, dsObj1.vG_TariffPopulation, true);
            cmbTariff.ComboBox.DataSource = dsObj1.vG_TariffPopulation;
            cmbTariff.ComboBox.DisplayMember = "SocrName";
            cmbTariff.ComboBox.ValueMember = "id";
        }

        // считаем количество объектов
        private void AllTotal()
        {
            int ObjTotal;
            ObjTotal = 0;
            for (int i = 0; i < dataGridViewObj.RowCount; i++)
            {
                ObjTotal = ObjTotal + 1;
            }
            this.tBoxObj.Text = ObjTotal.ToString();
        }

        // пересчитываем количество объектов при смене режимов отображения
        private void dataGridViewObj_Paint(object sender, PaintEventArgs e)
        {
            AllTotal();
        }

        // показываем все объекты или только активные
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.ComboBox.SelectedIndex == 0)
                this.SelectSqlDataTableOther(dsObj1, dsObj1.vG_AbnObj, "vG_AbnObj_New", true, " order By ObjName");
            else
                this.SelectSqlDataTableOther(dsObj1, dsObj1.vG_AbnObj, "vG_AbnObj_New_All", true, " order By ObjName");
        }

        // экспорт в Excel выбранных записей
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dataGridViewObj.Rows.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                // добавляем книгу и лист
                xlApp = new Excel.ApplicationClass();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                int ColCount = dataGridViewObj.Columns.Count;

                // шрифт для всего листа
                xlWorkSheet.get_Range("A:P").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A:P").Font.Size = 10;

                // шрифт для наименования отчета
                xlWorkSheet.get_Range("A1", "P2").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A1", "P2").Font.Bold = true;
                xlWorkSheet.get_Range("A1", "P2").Font.Size = 12;

                // наименование отчета
                xlWorkSheet.get_Range("A1", "P1").Merge(misValue);
                xlWorkSheet.get_Range("A1", "P1").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "P1").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "P1").Value2 = "Список объектов";

                xlWorkSheet.get_Range("A2", "P2").Merge(misValue);
                xlWorkSheet.get_Range("A2", "P2").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "P2").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "P2").Value2 = "на " + System.DateTime.Today.ToShortDateString();

                int i = 0;
                int j = 0;
                int k = 4;

                k = k + 2;
                // заголовок таблицы
                xlWorkSheet.get_Range("A" + k, misValue).Value2 = "Объект";
                xlWorkSheet.get_Range("B" + k, misValue).Value2 = "Короткое имя";
                xlWorkSheet.get_Range("C" + k, misValue).Value2 = "Тариф";
                xlWorkSheet.get_Range("D" + k, misValue).Value2 = "Код";
                xlWorkSheet.get_Range("E" + k, misValue).Value2 = "Потребитель";
                xlWorkSheet.get_Range("F" + k, misValue).Value2 = "Специалист";
                xlWorkSheet.get_Range("G" + k, misValue).Value2 = "В договоре";
                xlWorkSheet.get_Range("H" + k, misValue).Value2 = "Родитель";
                xlWorkSheet.get_Range("I" + k, misValue).Value2 = "Мастер";
                xlWorkSheet.get_Range("J" + k, misValue).Value2 = "Адрес";
                xlWorkSheet.get_Range("K" + k, misValue).Value2 = "Район";
                xlWorkSheet.get_Range("L" + k, misValue).Value2 = "Подстанция";
                xlWorkSheet.get_Range("M" + k, misValue).Value2 = "Уст.мощность";
                xlWorkSheet.get_Range("N" + k, misValue).Value2 = "Факт.мощность";
                xlWorkSheet.get_Range("O" + k, misValue).Value2 = "Потери";
                xlWorkSheet.get_Range("P" + k, misValue).Value2 = "Режим";
                xlWorkSheet.get_Range("Q" + k, misValue).Value2 = "Категория";
                xlWorkSheet.get_Range("R" + k, misValue).Value2 = "Сетевая";
                xlWorkSheet.get_Range("S" + k, misValue).Value2 = "Сбытовая";
                xlWorkSheet.get_Range("T" + k, misValue).Value2 = "Минус";

                // установим ширину столбцов
                xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 30;
                xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 30;
                xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 20;
                xlWorkSheet.get_Range("D:D", misValue).ColumnWidth = 10;
                xlWorkSheet.get_Range("E:E", misValue).ColumnWidth = 30;
                xlWorkSheet.get_Range("F:F", misValue).ColumnWidth = 20;
                xlWorkSheet.get_Range("G:G", misValue).ColumnWidth = 10;
                xlWorkSheet.get_Range("H:H", misValue).ColumnWidth = 20;
                xlWorkSheet.get_Range("I:I", misValue).ColumnWidth = 20;
                xlWorkSheet.get_Range("J:J", misValue).ColumnWidth = 20;
                xlWorkSheet.get_Range("K:K", misValue).ColumnWidth = 10;
                xlWorkSheet.get_Range("L:L", misValue).ColumnWidth = 10;
                xlWorkSheet.get_Range("M:M", misValue).ColumnWidth = 10;
                xlWorkSheet.get_Range("N:N", misValue).ColumnWidth = 10;
                xlWorkSheet.get_Range("O:O", misValue).ColumnWidth = 20;
                xlWorkSheet.get_Range("P:P", misValue).ColumnWidth = 20;
                xlWorkSheet.get_Range("Q:Q", misValue).ColumnWidth = 20;
                xlWorkSheet.get_Range("R:R", misValue).ColumnWidth = 20;
                xlWorkSheet.get_Range("S:S", misValue).ColumnWidth = 20;
                xlWorkSheet.get_Range("T:T", misValue).ColumnWidth = 20;

                xlWorkSheet.get_Range("A" + k, "N" + k).VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A" + k, "N" + k).HorizontalAlignment = Excel.Constants.xlCenter;

                // форматирование данных
                xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("D:D", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("E:E", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("F:F", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("G:G", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("H:H", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("I:I", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("J:J", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("K:K", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("L:L", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("M:M", misValue).NumberFormat = "### ##0,00";
                xlWorkSheet.get_Range("N:N", misValue).NumberFormat = "### ##0,00";
                xlWorkSheet.get_Range("O:O", misValue).NumberFormat = "### ##0,00";
                xlWorkSheet.get_Range("P:P", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("Q:Q", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("R:R", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("S:S", misValue).NumberFormat = "@";
                xlWorkSheet.get_Range("T:T", misValue).NumberFormat = "@";
                
                k = k + 1;
                // вывод данных в ячейки
                int m = dataGridViewObj.RowCount;
                int n = 0;

                for (i = 0; i <= m - 1; i++)
                {
                    if (dataGridViewObj.Rows[i].Cells["SelectCell"].Value != null)
                    {
                        for (j = 1; j <= dataGridViewObj.ColumnCount - 3; j++)
                        {
                            DataGridViewCell cell = dataGridViewObj[j, i];
                            xlWorkSheet.Cells[n + k, j] = cell.Value;
                        }
                        n = n + 1;
                    }
               //     txtCountRows.Text = (i + 1).ToString() + " из " + tBoxObj.Text;
                }

                xlWorkSheet.get_Range(xlWorkSheet.Cells[k - 1, 1], xlWorkSheet.Cells[k - 1 + m, ColCount-3]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k - 1, 1], xlWorkSheet.Cells[k - 1 + m, ColCount-3]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                k = k + m + 2;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount-3]).Merge(misValue);
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount-3]).VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount-3]).HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount-3]).Value2 = "Начальник службы контроля и учета электроэнергии                  И.А.Гулько";

                xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

                xlWorkSheet.PageSetup.LeftMargin = 80;
                xlWorkSheet.PageSetup.RightMargin = 25;
                xlWorkSheet.PageSetup.BottomMargin = 25;
                xlWorkSheet.PageSetup.TopMargin = 25;

                this.Cursor = Cursors.Default;
                xlApp.Visible = true;
            }
            else
                MessageBox.Show("Нет данных для отчета ..");
        }

        // подтверждение выбора
        private void dataGridViewObj_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dataGridViewObj.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        // выбираем все строки
        private void btnCheck_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < dataGridViewObj.RowCount; i++)
            {
                dataGridViewObj.Rows[i].Cells["SelectCell"].Value = true;
            }
            Cursor.Current = Cursors.Default;
        }

        // отменяем выбор 
        private void btnUncheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewObj.RowCount; i++)
            {
                dataGridViewObj.Rows[i].Cells["SelectCell"].Value = false;
            }
        }

        // меняем привязку мастера
        private void btnChangeBinding_Click(object sender, EventArgs e)
        {
            int idWorker = Convert.ToInt32(cmbMaster.ComboBox.SelectedValue);
            for (int i = 0; i < dataGridViewObj.RowCount; i++)
            {
                if (dataGridViewObj.Rows[i].Cells["SelectCell"].Value != null)
                {
                    if ((bool)dataGridViewObj.Rows[i].Cells["SelectCell"].Value == true)
                    {
                        DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                        try
                        {
                            con.OpenConnection(SqlSettings);

                            string strCmd = "";
                            strCmd = "sp_LegChangeBindingMaster";
                            SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                            sqlCmd.CommandType = CommandType.StoredProcedure;

                            // параметры

                            int idObj = Convert.ToInt32(dataGridViewObj.Rows[i].Cells["id"].Value);
                            SqlParameter p1 = new SqlParameter("@id", idObj);
                            sqlCmd.Parameters.Add(p1);

                            SqlParameter p2 = new SqlParameter("@idWorker", idWorker);
                            sqlCmd.Parameters.Add(p2);

                            sqlCmd.CommandTimeout = 0;

                            sqlCmd.ExecuteNonQuery();

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
                }
            }
            this.SelectSqlDataTableOther(dsObj1, dsObj1.vG_AbnObj, "vG_AbnObj_New", true, " order By ObjName");

        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            tbName.Text = "";
            if ((tbCode.Text.Length > 0) && (tbCode.Text.Length < 5))
            {
                SelectSqlData(dsObj1, dsObj1.tAbn, true, " where CodeAbonent = " + tbCode.Text);
                if (dsObj1.tAbn.Rows.Count > 0)
                    tbName.Text = dsObj1.tAbn.Rows[0]["Name"].ToString();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0)
            {
                int idAbn = 0;
                int idObj = 0;
                for (int i = 0; i < dataGridViewObj.RowCount; i++)
                {
                    if (dataGridViewObj.Rows[i].Cells["SelectCell"].Value != null)
                    {
                        if ((bool)dataGridViewObj.Rows[i].Cells["SelectCell"].Value == true)
                        {
                            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                            try
                            {
                                con.OpenConnection(SqlSettings);

                                string strCmd = "";
                                strCmd = "Leg_ObjCopy";
                                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                                sqlCmd.CommandType = CommandType.StoredProcedure;

                                // параметры

                                idAbn = Convert.ToInt32(dsObj1.tAbn.Rows[0]["id"]);
                                SqlParameter p1 = new SqlParameter("@idAbn", idAbn);
                                sqlCmd.Parameters.Add(p1);

                                idObj = Convert.ToInt32(dataGridViewObj.Rows[i].Cells["id"].Value);
                                SqlParameter p2 = new SqlParameter("@idAbnObj", idObj);
                                sqlCmd.Parameters.Add(p2);

                                bool Minus = false;
                                SqlParameter p3 = new SqlParameter("@Minus", Minus);
                                sqlCmd.Parameters.Add(p3);

                                sqlCmd.CommandTimeout = 0;

                                sqlCmd.ExecuteNonQuery();

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
                    }
                }
            }
        }

        private void btnChangeTariff_Click(object sender, EventArgs e)
        {
            int idTariff = Convert.ToInt32(cmbTariff.ComboBox.SelectedValue);
            for (int i = 0; i < dataGridViewObj.RowCount; i++)
            {
                if (dataGridViewObj.Rows[i].Cells["SelectCell"].Value != null)
                {
                    if ((bool)dataGridViewObj.Rows[i].Cells["SelectCell"].Value == true)
                    {
                        DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                        try
                        {
                            con.OpenConnection(SqlSettings);

                            string strCmd = "";
                            strCmd = "sp_LegChangeTariff";
                            SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                            sqlCmd.CommandType = CommandType.StoredProcedure;

                            // параметры

                            int idObj = Convert.ToInt32(dataGridViewObj.Rows[i].Cells["id"].Value);
                            SqlParameter p1 = new SqlParameter("@idObj", idObj);
                            sqlCmd.Parameters.Add(p1);

                            SqlParameter p2 = new SqlParameter("@idTariff", idTariff);
                            sqlCmd.Parameters.Add(p2);

                            sqlCmd.CommandTimeout = 0;

                            sqlCmd.ExecuteNonQuery();

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
                }
            }
            this.SelectSqlDataTableOther(dsObj1, dsObj1.vG_AbnObj, "vG_AbnObj_New", true, " order By ObjName");

        }

        private void btnReportPower_Click(object sender, EventArgs e)
        {
            Legal.Forms.Object.FormReportPower frm = new Legal.Forms.Object.FormReportPower();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.dataGridViewObj.ExportToExcel();
        }
    }

}

