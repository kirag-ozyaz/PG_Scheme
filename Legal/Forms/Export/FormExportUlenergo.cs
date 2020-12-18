using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.InteropServices;


namespace Legal.Forms.Export
{
    public partial class FormExportUlenergo : FormLbr.FormBase
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)] string path,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath,
            int shortPathLength);

        public FormExportUlenergo()
        {
            InitializeComponent();
        }

        private void FormExportUlenergo_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsCalc1, dsCalc1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);

            textBoxFile.Text  = "\\\\Term-ulges-ener\\C$\\Редиски\\Cnt" + dtBegin.Value.Year.ToString() + dtBegin.Value.Month.ToString() + ".dbf";
            textBoxFile2.Text = "\\\\Term-ulges-ener\\C$\\Редиски\\Obj" + dtBegin.Value.Year.ToString() + dtBegin.Value.Month.ToString() + ".dbf";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(1).AddDays(-1);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(-1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(-1).AddDays(-1);
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            export(1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            saveFileDialogExport.FileName = textBoxFile.Text;
            if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = saveFileDialogExport.FileName;
            }
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            export(2);
        }

        private void export(int par)
        {
            string strCom;
            string txtWhere;

            this.Cursor = Cursors.WaitCursor;

            if (par == 1)
            {
                if (System.IO.File.Exists(textBoxFile.Text))
                {
                    System.IO.File.Delete(textBoxFile.Text); // удаляем файл
                }
                txtWhere = " (dateact >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                " (dateact <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
                SelectSqlData(dsCalc1, dsCalc1.vG_CntUlenergo, true, " where " + txtWhere + " order by Code");
            }
            else
            {
                if (System.IO.File.Exists(textBoxFile2.Text))
                {
                    System.IO.File.Delete(textBoxFile2.Text); // удаляем файл
                }
                txtWhere = " (dtPay >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                " (dtPay <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
                SelectSqlData(dsCalc1, dsCalc1.vG_ObjUlenergo, true, " where " + txtWhere + " order by Code");
            }

            StringBuilder fileTemp = new StringBuilder(1024);
            // Получим коротокое имя временного файла
            GetShortPathName(System.IO.Path.GetTempFileName(), fileTemp, fileTemp.Capacity);
            // Папка временного файла
            string dir = System.IO.Path.GetDirectoryName(fileTemp.ToString());
            string fileName = "tmp";
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir +
                ";Mode = Share Deny None;Persist Security Info=False;Extended Properties=dBASE IV";
            try
            {
                con.Open();
                // Имя файла без расширения
                fileName = System.IO.Path.GetFileNameWithoutExtension(fileTemp.ToString());
                System.IO.File.Delete(dir + "\\" + fileName + ".dbf");  // на всякий случай удаляем
                // Создадим таблицу с именем временного файла
                if (par == 1)
                {
                         strCom = "CREATE TABLE `" + fileName + "` (AbnID int, " +
                        "[Code] int, " +
                        "NameShort varchar(100), " +
                        "AbnObjID int, " +
                        "CodeObj int, " +
                        "CodeSub int, " +
                        "[Title] varchar(254), " +
                        "[Kloss] float, " +
                        "AbnObjCntID int, " +
                        "[Number] varchar(50), " +
                        "[Value] int, " +
                        "[Size] int )"
                         ;
                }
                else
                {
                    strCom = "CREATE TABLE `" + fileName + "` (AbnID int, " +
                        "[Code] int, " +
                        "NameShort varchar(100), " +
                        "AbnObjID int, " +
                        "Title varchar(254), " + 
                        "Priznak varchar(100), " +  
                        "Tension varchar(100), " +  
                        "Volum int )"
                        ;
                }


                OleDbCommand cmd = new OleDbCommand(strCom, con);
                cmd.ExecuteNonQuery();

                // Занесем данные
                if (par == 1)
                    for (int i = 0; i < dsCalc1.Tables["vG_CntUlenergo"].Rows.Count; i++)
                    {
                        DataRow r = dsCalc1.Tables["vG_CntUlenergo"].Rows[i];

                        strCom = "insert into `" + fileName +
                       "` VALUEs(@AbnID, @Code, @NameShort, @AbnObjID, @CodeObj, @CodeSub, @Title, @Kloss, @AbnObjCntID, @Number, @Value, @Size)";

                        cmd = new OleDbCommand(strCom, con);
                        // Параметры функции 
                        OleDbParameter p = new OleDbParameter("@AbnID", r["AbnID"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Code", r["Code"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@NameShort", r["NameShort"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@AbnObjID", r["AbnObjID"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@CodeObj", r["CodeObj"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@CodeSub", r["CodeSub"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Title", r["Title"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Kloss", r["Kloss"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@AbnObjCntID", r["AbnObjCntID"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Number", r["Number"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Value", r["Value"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Size", r["Size"]);
                        cmd.Parameters.Add(p);

                        cmd.ExecuteNonQuery();
                    
                    }
                else
                    for (int i = 0; i < dsCalc1.Tables["vG_ObjUlenergo"].Rows.Count; i++)
                    {
                        DataRow r = dsCalc1.Tables["vG_ObjUlenergo"].Rows[i];

                        strCom = "insert into `" + fileName +
                       "` VALUEs(@AbnID, @Code, @NameShort, @AbnObjID, @Title, @Priznak, @Tension, @Volum)";

                        cmd = new OleDbCommand(strCom, con);
                        // Параметры функции 
                        OleDbParameter p = new OleDbParameter("@AbnID", r["AbnID"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Code", r["Code"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@NameShort", r["NameShort"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@AbnObjID", r["AbnObjID"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Title", r["Title"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Priznak", r["Priznak"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Tension", r["Tension"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Volum", r["Volum"]);
                        cmd.Parameters.Add(p);

                        cmd.ExecuteNonQuery();

                    }

            }
            catch (Exception ex) // ошибка соединения
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            
            if (par == 1)
                System.IO.File.Move(dir + "\\" + fileName + ".dbf", textBoxFile.Text);
            else
                System.IO.File.Move(dir + "\\" + fileName + ".dbf", textBoxFile2.Text);
            this.Cursor = Cursors.Default;
            MessageBox.Show("Выгрузка успешно завершена ..");

        }

        private void buttonFile2_Click(object sender, EventArgs e)
        {
            saveFileDialogExport.FileName = textBoxFile2.Text;
            if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                textBoxFile2.Text = saveFileDialogExport.FileName;
            }
        }

    }
}
