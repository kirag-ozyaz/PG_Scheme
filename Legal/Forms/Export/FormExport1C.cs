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
using System.Xml.Linq;


namespace Legal.Forms.Export
{
    public partial class FormExport1C : FormLbr.FormBase
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)] string path,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath,
            int shortPathLength);

        public FormExport1C()
        {
            InitializeComponent();
        }

        private void FormExport1C_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsCalc1, dsCalc1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);

            textBoxFile.Text = "\\\\Ulges-sql\\Ulges\\ExtForms\\Gossektor\\Abn.dbf";
            textBoxFile2.Text = "\\\\Ulges-sql\\Ulges\\ExtForms\\Gossektor\\SE" + DateTime.Today.ToString("yyMMdd") + ".dbf";
            textBoxFile3.Text = "\\\\Ulges-sql\\Ulges\\ExtForms\\Gossektor\\Schet" + DateTime.Today.ToString("yyMMdd") + ".xml";
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

        private void buttonFile2_Click(object sender, EventArgs e)
        {
            saveFileDialogExport.FileName = textBoxFile2.Text;
            if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                textBoxFile2.Text = saveFileDialogExport.FileName;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            export(1);
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
                txtWhere = " (dtPay >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                " (dtPay <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
                SelectSqlData(dsCalc1, dsCalc1.vG_Abn1C, true, " where " + txtWhere + " order by AbnCode");
            }
            else
            {
                if (System.IO.File.Exists(textBoxFile2.Text))
                {
                    System.IO.File.Delete(textBoxFile2.Text); // удаляем файл
                }
                txtWhere = " (DATD >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                " (DATD <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";

                if (par == 2)
                    SelectSqlData(dsCalc1, dsCalc1.vG_Volum1C, true, " where " + txtWhere + " order by AbnCode");
                else
                {
                    DataSql.SqlDataConnect con2 = new DataSql.SqlDataConnect();
                    try
                    {
                        con2.OpenConnection(SqlSettings);
                        string strCmd = "";
                        strCmd = "select * from fn_LegVolum1C(@DateBegin, @DateEnd) order by AbnCode";

                        SqlCommand sqlCmd = new SqlCommand(strCmd, con2.Connection);

                        DateTime DateBegin = dtBegin.Value;
                        SqlParameter p1 = new SqlParameter("@DateBegin", DateBegin.ToString("yyyyMMdd"));
                        sqlCmd.Parameters.Add(p1);

                        DateTime DateEnd = dtEnd.Value;
                        SqlParameter p2 = new SqlParameter("@DateEnd", DateEnd.ToString("yyyyMMdd"));
                        sqlCmd.Parameters.Add(p2);

                        sqlCmd.CommandTimeout = 0;

                        SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                        dAdapt.Fill(dsCalc1, "vG_Volum1C_New");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                    finally
                    {
                        con2.CloseConnection();
                    }

                }

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
                strCom = "";
                if (par == 1)
                {
                    strCom = "CREATE TABLE `" + fileName + "` (AbnID int, " +
                    "AbnCode int, " +
                    "FullNam varchar(254), " +
                    "NumDog varchar(20), " +
                    "ShortName varchar(254), " +
                    "INN varchar(50), " +
                    "TypeOrg varchar(70), " +
                    "Budg varchar(30), " +
                    "Rsch varchar(50), " +
                    "BankNam varchar(254), " +
                    "Ksch varchar(30), " +
                    "BIK varchar(20), " +
                    "City varchar(128), " +
                    "Contrcod int, " +
                    "ContrNan varchar(40), " +
                    "OTR varchar(50), " +
                    "AltName varchar(1), " +
                    "Street varchar(254), " +
                    "DogDate datetime, " +
                    "Post varchar(254), " +
                    "AbnOwner int, " +
                    "Email varchar(100))"
                    ;
                }
                if (par == 2)
                {
                    strCom = "CREATE TABLE `" + fileName + "` (AbnID int, " +
                    "AbnCode int, " +
                    "NumDog varchar(20), " +
                    "NOMSF int, " +
                    "DATSF datetime, " +
                    "DATD datetime, " +
                    "SUMMF decimal(18,2), " +
                    "SUMMS decimal(18,2), " +
                    "SUMMNDS decimal(18,2), " +
                    "SUMPENI decimal(18,2), " +
                    "TEXTSF varchar(254), " + 
                    "AVANS int, " +
                    "STOR int, " +
                    "FSUM decimal(18,2), " +
                    "FNDS decimal(18,2), " +
                    "FVSEGO decimal(18,2), " +
                    "TypeZag int, " +
                    "STORNO datetime, " +
                    "NOMSTORNO int, " +
                    "VIDRASH varchar(6))"
                    ;
                }
                if (par == 3)
                {
                    strCom = "CREATE TABLE `" + fileName + "` (AbnID int, " +
                    "AbnCode int, " +
                    "NumDog varchar(20), " +
                    "NOMSF int, " +
                    "DATSF datetime, " +
                    "DATD datetime, " +
                    "SUMMF decimal(18,2), " +
                    "SUMMS decimal(18,2), " +
                    "SUMMNDS decimal(18,2), " +
                    "SUMPENI decimal(18,2), " +
                    "TEXTSF varchar(254), " +
                    "AVANS int, " +
                    "STOR int, " +
                    "FSUM decimal(18,2), " +
                    "FNDS decimal(18,2), " +
                    "FVSEGO decimal(18,2), " +
                    "TypeZag int, " +
                    "STORNO datetime, " +
                    "NOMSTORNO int, " +
                    "VIDRASH varchar(6), " +

                    "Unit1 int, " +
                    "Quantity1 int, " +
                    "Tariff1 decimal(18,6), " +
                    "Sum1 decimal(18,2), " +
                    "SumNalog1 decimal(18,2), " +
                    "SumTotal1 decimal(18,2), " +

                    "Unit2 int, " +
                    "Quantity2 int, " +
                    "Tariff2 decimal(18,6), " +
                    "Sum2 decimal(18,2), " +
                    "SumNalog2 decimal(18,2), " +
                    "SumTotal2 decimal(18,2), " +

                    "Unit3 int, " +
                    "Quantity3 int, " +
                    "Tariff3 decimal(18,6), " +
                    "Sum3 decimal(18,2), " +
                    "SumNalog3 decimal(18,2), " +
                    "SumTotal3 decimal(18,2), " +

                    "Unit4 int, " +
                    "Quantity4 int, " +
                    "Tariff4 decimal(18,6), " +
                    "Sum4 decimal(18,2), " +
                    "SumNalog4 decimal(18,2), " +
                    "SumTotal4 decimal(18,2), " +

                    "Unit5 int, " +
                    "Quantity5 int, " +
                    "Tariff5 decimal(18,6), " +
                    "Sum5 decimal(18,2), " +
                    "SumNalog5 decimal(18,2), " +
                    "SumTotal5 decimal(18,2), " +

                    "Unit6 int, " +
                    "Quantity6 int, " +
                    "Tariff6 decimal(18,6), " +
                    "Sum6 decimal(18,2), " +
                    "SumNalog6 decimal(18,2), " +
                    "SumTotal6 decimal(18,2), " +

                    "Unit7 int, " +
                    "Quantity7 int, " +
                    "Tariff7 decimal(18,6), " +
                    "Sum7 decimal(18,2), " +
                    "SumNalog7 decimal(18,2), " +
                    "SumTotal7 decimal(18,2), " +

                    "Unit8 int, " +
                    "Quantity8 int, " +
                    "Tariff8 decimal(18,6), " +
                    "Sum8 decimal(18,2), " +
                    "SumNalog8 decimal(18,2), " +
                    "SumTotal8 decimal(18,2))" 
                    ;
                }


                OleDbCommand cmd = new OleDbCommand(strCom, con);
                cmd.ExecuteNonQuery();

                // Занесем данные
                int rs = 0;
                if (par == 1)
                    for (int i = 0; i < dsCalc1.Tables["vG_Abn1C"].Rows.Count; i++)
                    {
                        DataRow r = dsCalc1.Tables["vG_Abn1C"].Rows[i];

                        strCom = "insert into `" + fileName +
                       "` VALUEs(@AbnID, @AbnCode, @FullNam, @NumDog, @ShortName, @INN, @TypeOrg, @Budg, @Rsch, @BankNam, @Ksch, @BIK, @City, @Contrcod, @ContrNan, @OTR, @AltName, @Street, @DogDate, @Post, @AbnOwner, @Email)";

                        cmd = new OleDbCommand(strCom, con);
                        // Параметры функции 
                        OleDbParameter p = new OleDbParameter("@AbnID", r["AbnID"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@AbnCode", r["AbnCode"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@FullNam", r["FullNam"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@NumDog", r["NumDog"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@ShortName", r["ShortName"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@INN", r["INN"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@TypeOrg", r["TypeOrg"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Budg", r["Budg"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Rsch", r["Rsch"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@BankNam", r["BankNam"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Ksch", r["Ksch"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@BIK", r["BIK"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@City", r["City"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Contrcod", r["Contrcod"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@ContrNan", r["ContrNan"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@OTR", r["OTR"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@AltName", r["AltName"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Street", r["Street"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@DogDate", r["DogDate"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Post", r["Post"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@AbnOwner", r["AbnOwner"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@Email", r["Email"]);
                        cmd.Parameters.Add(p);

                        cmd.ExecuteNonQuery();

                    }
                else
                    rs = dsCalc1.Tables["vG_Volum1C"].Rows.Count; 

                    if (par == 3)
                        rs = dsCalc1.Tables["vG_Volum1C_New"].Rows.Count; 

                    for (int i = 0; i < rs; i++)
                    {
                        DataRow r;
                        if (par == 3)
                            r = dsCalc1.Tables["vG_Volum1C_New"].Rows[i];
                        else
                            r = dsCalc1.Tables["vG_Volum1C"].Rows[i];


                        strCom = "insert into `" + fileName +
                       "` VALUEs(AbnID, AbnCode, NumDog, NOMSF, DATSF, DATD, SUMMF, SUMMS, SUMMNDS, SUMPENI, TEXTSF, AVANS, STOR, FSUM, FNDS, FVSEGO, TypeZag, STORNO, NOMSTORNO, VIDRASH)";
                        if (par == 3)
                            strCom = "insert into `" + fileName +
                           "` VALUEs(AbnID, AbnCode, NumDog, NOMSF, DATSF, DATD, SUMMF, SUMMS, SUMMNDS, SUMPENI, TEXTSF, AVANS, STOR, FSUM, FNDS, FVSEGO, TypeZag, STORNO, NOMSTORNO, VIDRASH, " +
                                "Unit1, Quantity1, Tariff1, Sum1, SumNalog1, SumTotal1, " +
                                "Unit2, Quantity2, Tariff2, Sum2, SumNalog2, SumTotal2, " +
                                "Unit3, Quantity3, Tariff3, Sum3, SumNalog3, SumTotal3, " +
                                "Unit4, Quantity4, Tariff4, Sum4, SumNalog4, SumTotal4, " +
                                "Unit5, Quantity5, Tariff5, Sum5, SumNalog5, SumTotal5, " +
                                "Unit6, Quantity6, Tariff6, Sum6, SumNalog6, SumTotal6, " +
                                "Unit7, Quantity7, Tariff7, Sum7, SumNalog7, SumTotal7, " +
                                "Unit8, Quantity8, Tariff8, Sum8, SumNalog8, SumTotal8)";


                        cmd = new OleDbCommand(strCom, con);
                        // Параметры функции 
                        OleDbParameter p = new OleDbParameter("@AbnID", r["AbnID"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@AbnCode", r["AbnCode"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@NumDog", r["NumDog"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@NOMSF", r["NOMSF"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@DATSF", r["DATSF"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@DATD", r["DATD"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@SUMMF", r["SUMMF"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@SUMMS", r["SUMMS"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@SUMMNDS", r["SUMMNDS"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@SUMPENI", r["SUMPENI"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("TEXTSF@", r["TEXTSF"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@AVANS", r["AVANS"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@STOR", r["STOR"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@FSUM", r["FSUM"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@FNDS", r["FNDS"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@FVSEGO", r["FVSEGO"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@TypeZag", r["TypeZag"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@STORNO", r["STORNO"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@NOMSTORNO", r["NOMSTORNO"]);
                        cmd.Parameters.Add(p);
                        p = new OleDbParameter("@VIDRASH", r["VIDRASH"]);
                        cmd.Parameters.Add(p);

                        if (par == 3)
                        {
                            p = new OleDbParameter("@Unit1", r["Unit1"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Quantity1", r["Quantity1"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Tariff1", r["Tariff1"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Sum1", r["Sum1"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumNalog1", r["SumNalog1"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumTotal1", r["SumTotal1"]);
                            cmd.Parameters.Add(p);

                            p = new OleDbParameter("@Unit2", r["Unit2"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Quantity2", r["Quantity2"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Tariff2", r["Tariff2"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Sum2", r["Sum2"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumNalog2", r["SumNalog2"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumTotal2", r["SumTotal2"]);
                            cmd.Parameters.Add(p);

                            p = new OleDbParameter("@Unit3", r["Unit3"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Quantity3", r["Quantity3"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Tariff3", r["Tariff3"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Sum3", r["Sum3"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumNalog3", r["SumNalog3"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumTotal3", r["SumTotal3"]);
                            cmd.Parameters.Add(p);

                            p = new OleDbParameter("@Unit4", r["Unit4"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Quantity4", r["Quantity4"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Tariff4", r["Tariff4"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Sum4", r["Sum4"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumNalog4", r["SumNalog4"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumTotal4", r["SumTotal4"]);
                            cmd.Parameters.Add(p);

                            p = new OleDbParameter("@Unit5", r["Unit5"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Quantity5", r["Quantity5"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Tariff5", r["Tariff5"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Sum5", r["Sum5"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumNalog5", r["SumNalog5"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumTotal5", r["SumTotal5"]);
                            cmd.Parameters.Add(p);

                            p = new OleDbParameter("@Unit6", r["Unit6"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Quantity6", r["Quantity6"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Tariff6", r["Tariff6"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Sum6", r["Sum6"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumNalog6", r["SumNalog6"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumTotal6", r["SumTotal6"]);
                            cmd.Parameters.Add(p);

                            p = new OleDbParameter("@Unit7", r["Unit7"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Quantity7", r["Quantity7"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Tariff7", r["Tariff7"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Sum7", r["Sum7"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumNalog7", r["SumNalog7"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumTotal7", r["SumTotal7"]);
                            cmd.Parameters.Add(p);

                            p = new OleDbParameter("@Unit8", r["Unit8"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Quantity8", r["Quantity8"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Tariff8", r["Tariff8"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@Sum8", r["Sum8"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumNalog8", r["SumNalog8"]);
                            cmd.Parameters.Add(p);
                            p = new OleDbParameter("@SumTotal8", r["SumTotal8"]);
                            cmd.Parameters.Add(p);
                        
                        }

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

        private void btnOK3_Click(object sender, EventArgs e)
        {
            export(3);
        }

        private void btnOK4_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string txtWhere;
            txtWhere = " (dtBank >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
            " (dtBank <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') and NumberObj < 9999";

            SelectSqlData(dsCalc1, dsCalc1.vG_SchetPrint, true, " where " + txtWhere + " order by NumberSchet, NumberObj");

            string Number = "";
            decimal SumRound = 0;

            XDocument doc = new XDocument();
            XElement List = new XElement("List");
            doc.Add(List);
             
            for (int i = 0; i < dsCalc1.vG_SchetPrint.Rows.Count; i++)
            {

                XElement NumberSchet = new XElement("НомерСчета");
                NumberSchet.Value = dsCalc1.vG_SchetPrint.Rows[i]["NumberSchet"].ToString();

                XElement DateSchet = new XElement("ДатаСчета");
                DateSchet.Value = Convert.ToDateTime(dsCalc1.vG_SchetPrint.Rows[i]["DateSchet"].ToString()).Date.ToString();

                XElement PayerName = new XElement("Контрагент");
                PayerName.Value = dsCalc1.vG_SchetPrint.Rows[i]["PayerName"].ToString();

                XElement PayerCode = new XElement("Договор");
                PayerCode.Value = dsCalc1.vG_SchetPrint.Rows[i]["NumberSchet"].ToString();

                XElement SumRealiz = new XElement("Итого");
                SumRealiz.Value = dsCalc1.vG_SchetPrint.Rows[i]["SumRealiz"].ToString();

                XElement SumNalog = new XElement("ИтогоНДС");
                SumNalog.Value = dsCalc1.vG_SchetPrint.Rows[i]["SumNalog"].ToString();

                XElement SumTotal = new XElement("ИтогоКОплатеПоСчету");
                SumTotal.Value = dsCalc1.vG_SchetPrint.Rows[i]["SumTotal"].ToString();

                XElement Object = new XElement("Объект");

                XElement NumberObj = new XElement("НомерОбъекта");
                NumberObj.Value = dsCalc1.vG_SchetPrint.Rows[i]["NumberObj"].ToString() + "/" + dsCalc1.vG_SchetPrint.Rows[i]["NumberSubObj"].ToString();
                Object.Add(NumberObj);

                XElement ObjectName = new XElement("НаименованиеОбъекта");
                ObjectName.Value = dsCalc1.vG_SchetPrint.Rows[i]["ObjectName"].ToString();
                Object.Add(ObjectName);

                XElement TypeOfEnergy = new XElement("ВидНачисления");
                TypeOfEnergy.Value = dsCalc1.vG_SchetPrint.Rows[i]["TypeOfEnergy"].ToString();
                Object.Add(TypeOfEnergy);

                XElement dtCalc = new XElement("ДатаНачисления");
                dtCalc.Value = Convert.ToDateTime(dsCalc1.vG_SchetPrint.Rows[i]["dtCalc"].ToString()).Date.ToString();
                Object.Add(dtCalc);

                XElement ReservedPower = new XElement("РезервМощностикВт");
                ReservedPower.Value = dsCalc1.vG_SchetPrint.Rows[i]["ReservedPower"].ToString();
                Object.Add(ReservedPower);

                XElement Quantity = new XElement("Количество");
                Quantity.Value = dsCalc1.vG_SchetPrint.Rows[i]["Quantity"].ToString();
                Object.Add(Quantity);

                XElement Tariff = new XElement("Тариф");
                Tariff.Value = dsCalc1.vG_SchetPrint.Rows[i]["Tariff"].ToString();
                Object.Add(Tariff);

                XElement Summa = new XElement("Сумма");
                SumRound = Math.Round(Convert.ToDecimal(dsCalc1.vG_SchetPrint.Rows[i]["Summa"].ToString()),2, MidpointRounding.AwayFromZero);
                Summa.Value = SumRound.ToString();
                Object.Add(Summa);

                if (Number != dsCalc1.vG_SchetPrint.Rows[i]["NumberSchet"].ToString())
                {
                    XElement Schet = new XElement("Счет");

                    Schet.Add(NumberSchet);
                    Schet.Add(DateSchet);
                    Schet.Add(PayerName);
                    Schet.Add(PayerCode);
                    Schet.Add(SumRealiz);
                    Schet.Add(SumNalog);
                    Schet.Add(SumTotal);

                    Schet.Add(Object);
                    List.Add(Schet);
                }
                else
                {
                    
                    var nodes = doc.Descendants("Счет").Where(x => x.Element("НомерСчета").Value.Equals(Number));
                    foreach (XElement node in nodes)
                    {
                        node.Add(Object);
                    }
                }
                Number = dsCalc1.vG_SchetPrint.Rows[i]["NumberSchet"].ToString();
            }

            doc.Save(textBoxFile3.Text);
            this.Cursor = Cursors.Default;
            MessageBox.Show("Выгрузка успешно завершена ..");


        }

        private void buttonFile3_Click(object sender, EventArgs e)
        {
            saveFileDialogExport.FileName = textBoxFile3.Text;
            if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                textBoxFile3.Text = saveFileDialogExport.FileName;
            }
        }


    }
}
