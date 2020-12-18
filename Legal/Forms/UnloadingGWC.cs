using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.Common;
using System.Threading;
using FormLbr;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;

//
// выгрузка в группу по работе с потребителями
//
namespace Legal
{
    public partial class UnloadingGWC : FormBase
    {
        //string ConnectionString = "";
        struct SetParamsCommand
        {
            public string Params;
            public object TypeParams;
            public object ValueParams;

            public SetParamsCommand(string p1, object p2, object p3)
            {
                Params = p1;
                TypeParams = p2;
                ValueParams = p3;
            }
        }
        public UnloadingGWC()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            btnInfo.Click +=new EventHandler(btnClick);
            btnOut.Click +=new EventHandler(btnClick);
            btnOut1.Click += new EventHandler(btnClick);
            btnVolume.Click += new EventHandler(btnClick);
        }

        private void btnClick(object sender, EventArgs e)
        {
            //using (SqlConnection conn = new SqlConnection(ConnectionString))
            //{
                ((Button)sender).Enabled = false;
                bool T1 = true;
                bool T2 = true;
                bool T3 = true;
                bool T5 = true;
                bool T6 = true;
                bool T7 = true;
                // Анализы
                bool T8 = true;
                bool T9 = true;
                //conn.Open();
                #region Информация
                #region 1
                if (checkBox1.Checked)
                {
                    T1 = false;
                    Thread t1 = new Thread(delegate()
                        {
                            T1 = CreateExcelFile(1, checkBox1.Text, "Select * FROM fun_Abn_X1()", progressBar1);
                            ButtonEnable(btnInfo, T1, T7);
                        });
                    t1.Start();
                }
                #endregion
                #region 7
                if (checkBox7.Checked)
                {
                    T7 = false;
                    Object[] arr = { new SetParamsCommand("@Date", SqlDbType.SmallDateTime, dtOutAbnObj.Value.Date) };
                    Thread t7 = new Thread(delegate()
                        {
                            T7 = CreateExcelFile(2, checkBox7.Text, "Select * FROM fun_AbnObj_X7(@Date)", progressBar7, arr);
                            ButtonEnable(btnInfo, T1, T7);
                        });
                    t7.Start();
                }
                #endregion
                #endregion
                #region Потребление
                #region 5 (по объекта потребителя)
                if (checkBox5.Checked)
                {
                    T5 = false;
                    Object[] arr = { 
                                       new SetParamsCommand("@Date", SqlDbType.SmallDateTime, dtOUT.Value.Date)
                                   };
                    Thread t5 = new Thread(delegate()
                        {
                            T5 = CreateExcelFile(5, checkBox5.Text, "Select * FROM fun_AbnObj_Month_Value_X5(@Date)", progressBar5, arr);
                            ButtonEnable(btnOut1, T5);
                        });
                    t5.Start();
                }
                #endregion
                #region 3
                if (checkBox3.Checked)
                {
                    T3 = false;
                    Object[] arr = { 
                                       new SetParamsCommand("@DateBegin", SqlDbType.SmallDateTime, dtBegin.Value.Date)
                                       ,new SetParamsCommand("@DateEnd", SqlDbType.SmallDateTime, dtEnd.Value.Date)
                                   };
                    Thread t3 = new Thread(delegate()
                        {
                            T3 = CreateExcelFile(3, checkBox3.Text, "Select * FROM fun_Abn_Value_X4(@DateBegin , @DateEnd)", progressBar3, arr);
                            ButtonEnable(btnOut,  T3);
                        });
                    t3.Start();
                }
                #endregion  
                #endregion
                #region Плановые объемы
                #region 2
                if (checkBox2.Checked)
                {
                    T2 = false;
                    Object[] arr = { 
                                       new SetParamsCommand("@Year", SqlDbType.SmallDateTime, dtOUT.Value.Year)
                                   };
                    Thread t2 = new Thread(delegate()
                        {
                            T2 = CreateExcelFile(2, checkBox2.Text, "Select * FROM fun_Abn_X2(@Year)", progressBar2, arr);
                            ButtonEnable(btnVolume, T2, T6);
                        });
                    t2.Start();
                }
                #endregion
                #region 6
                if (checkBox6.Checked)
                {
                    T6 = false;
                    Object[] arr = { 
                                       new SetParamsCommand("@Year", SqlDbType.SmallDateTime, dtOUT.Value.Year)
                                   };
                    Thread t6 = new Thread(delegate()
                    {
                        T6 = CreateExcelFile(6, checkBox6.Text, "Select * FROM fun_AbnObj_X2(@Year)", progressBar6, arr);
                        ButtonEnable(btnVolume, T2, T6);
                    });
                    t6.Start();
                }
                #endregion                
                #endregion
                #region Анализ расчетов объемов
                #region Потребители
                if (checkBox8.Checked)
                {
                    //T8 = false;
                    //Thread t8 = new Thread(delegate()
                    //{
                    Object[] arr = { 
                                       new SetParamsCommand("@DateBegin", SqlDbType.SmallDateTime, new DateTime(dtCurrentAnaliz.Value.Year, dtCurrentAnaliz.Value.Month, 1).ToString())
                                       ,new SetParamsCommand("@DateEnd", SqlDbType.SmallDateTime, new DateTime(dtCurrentAnaliz.Value.Year, dtCurrentAnaliz.Value.Month, DateTime.DaysInMonth(dtCurrentAnaliz.Value.Year, dtCurrentAnaliz.Value.Month)).ToString())
                                       ,new SetParamsCommand("@DateLast", SqlDbType.SmallDateTime, dtLastAnaliz.Value.Date)
                                   };
                    T8 = CreateFormRezult();
                    //    ButtonEnable(btnAnalizAbn, T8);
                    //});
                    //t8.Start();
                }
                #endregion
                #region Объекты потребителей
                if (checkBox9.Checked)
                {
                    T9 = false;
                    Thread t9 = new Thread(delegate()
                    {
                        //T1 = CreateExcelFile(1, checkBox1.Text, "Select * FROM fun_Abn_X1()", progressBar1);
                        ButtonEnable(btnAnalizAbnObj, T9);
                    });
                    t9.Start();
                }
                #endregion

                ButtonEnable(btnAnalizAbn, T8);
                ButtonEnable(btnAnalizAbnObj, T9);

                #endregion                
                
                ButtonEnable(btnInfo, T1, T7);
                ButtonEnable(btnOut1, T5);
                ButtonEnable(btnOut, T3);
                ButtonEnable(btnVolume, T2, T6);
                ButtonEnable(btnAnalizAbn, T8);
                ButtonEnable(btnAnalizAbnObj, T9);

                GC.Collect();
                GC.GetTotalMemory(true);
            //}
        }
        private bool CreateFormRezult(params bool[] ListThread)
        {
            try
            {
                //frmRezultAbn frm = new frmRezultAbn();
                //frm.Show();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неудачная выгрузка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }        
        private void ButtonEnable(Button button, params bool[] ListThread)
        {
            foreach (bool bools in ListThread)
            {
                if (!bools)
                {
                    button.Enabled = false;
                    return;
                }
            }
            button.Enabled = true;
        }
        private bool CreateExcelFile(int NumberFile, string NameBook, string CommandText, ProgressBar progressBar)
        {
            return CreateExcelFile(NumberFile, NameBook, CommandText, progressBar, null);
        }
        private bool CreateExcelFile(int NumberFile, string NameBook, string CommandText, ProgressBar progressBar, Object[] obj)
        {
            if (progressBar.Tag != null) return false;
            DataTable dt = new DataTable();
            Excel.Application excelapp = new Excel.Application();
            
            excelapp.SheetsInNewWorkbook = 1;
            excelapp.Workbooks.Add(Type.Missing);

            Excel.Workbooks excelappworkbooks = excelapp.Workbooks;
            Excel.Workbook excelappworkbook = excelappworkbooks[1];
            //excelappworkbook.Title = NumberFile.ToString();

            Excel.Sheets excelsheets = excelappworkbook.Worksheets ;
            Excel.Worksheet excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
            
            Excel.Range excelcells;

            

            SQLSettings sqlSett = new DataSql.SQLSettings(this.SqlSettings);
            sqlSett.ServerDB = @"192.168.8.252";
            sqlSett.DBName = @"GES";

            SqlDataConnect sqlDataConnect = new SqlDataConnect();
            sqlDataConnect.OpenConnection(sqlSett);
            //using (SqlConnection conn = new SqlConnection(ConnectionString))
            //{
                progressBar.Tag = 1;
                
                {
                    try
                    {
                        SqlCommand sqlCommand = new SqlCommand(CommandText, sqlDataConnect.Connection);
                        sqlCommand.CommandTimeout = 0;

                        if (obj != null)
                        {
                            foreach (Object obji in obj)
                            {
                                //sqlCommand.Parameters.Add(
                                //    ((SetParamsCommand)obji).Params,
                                //    ((SetParamsCommand)obji).TypeParams);
                                //sqlCommand.Parameters[((SetParamsCommand)obji).Params].Value =
                                //    ((SetParamsCommand)obji).ValueParams;
                                sqlCommand.Parameters.AddWithValue(
                                    ((SetParamsCommand)obji).Params,
                                    ((SetParamsCommand)obji).ValueParams);
                            }
                        }
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = sqlCommand;
                        da.Fill(dt);
                        // Заголовок
                        excelcells = (Excel.Range)excelworksheet.Cells[1, 1];
                        excelcells.Value2 = NameBook;
                        // Шапка
                        for (int i = 1; i <= dt.Columns.Count; i++)
                        {
                            excelcells = (Excel.Range)excelworksheet.Cells[2, i];
                            excelcells.Value2 = dt.Columns[i - 1].ColumnName;
                        }
                        progressBar.Maximum = dt.Rows.Count;
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
                            progressBar.Value = c - 1;
                        }
                        excelapp.Visible = true;
                        progressBar.Tag = null;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неудачная выгрузка №" + NumberFile.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        excelapp = null;
                        progressBar.Tag = null;
                        return false;
                    }
                    finally
                    {
                        sqlDataConnect.CloseConnection();
                    }
                }
            //}
                
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }   
}
