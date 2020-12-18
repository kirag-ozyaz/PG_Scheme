using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;


namespace Legal.Forms.Object
{
    public partial class FormReportPower : FormLbr.FormBase
    {
        private Word.Application wordapp;
        private Word.Document worddocument;

        public FormReportPower()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReportPower_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            
            // определим квартал
            int numQuater = DateTime.Now.Date.Month / 4;
            // найдем границы квартала
            DateTime dtBeginQuater = new DateTime(DateTime.Now.Date.Year, numQuater * 3 + 1, 1);
            dtBeginQuater = dtBeginQuater.AddMonths(-3);
            DateTime dtEndQuater = dtBeginQuater.AddMonths(3).AddDays(-1); 

            dtBegin.Value = dtBeginQuater;
            dtEnd.Value = dtEndQuater;

            SelectSqlData(dsCalc1, dsCalc1.tAbn, true, " where TypeAbn in (207, 230, 231)");

            minPower.Value = 670;
            maxPower.Value = 10000;

        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(-3);
            dtEnd.Value = dtEnd.Value.AddMonths(-3);
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(3);
            dtEnd.Value = dtEnd.Value.AddMonths(3);
        }

        private void btnReportPower_Click(object sender, EventArgs e)
        {
            string txtWhere = "";
            txtWhere += " (Period >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                " (Period <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";

            dsCalc1.tG_ReportPower_Total.Rows.Clear();

            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";

                strCmd = "select * from fn_LegReportPower_Total (@DateBegin, @DateEnd, @minPower, @maxPower) order by Voltage";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                DateTime DateBegin = (DateTime)dtBegin.Value.Date;
                DateTime DateEnd = (DateTime)dtEnd.Value.Date;

                SqlParameter p1 = new SqlParameter("@DateBegin", DateBegin.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@DateEnd", DateEnd.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@minPower", Convert.ToDouble(minPower.Value));
                sqlCmd.Parameters.Add(p3);

                SqlParameter p4 = new SqlParameter("@maxPower", Convert.ToDouble(maxPower.Value));
                sqlCmd.Parameters.Add(p4);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCalc1, "tG_ReportPower_Total");
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


        private void btnPlus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(3);
            dtEnd.Value = dtBegin.Value.AddMonths(3).AddDays(-1);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(-3);
            dtEnd.Value = dtBegin.Value.AddMonths(3).AddDays(-1);
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            // создадим документ Word
            try
            {
                wordapp = new Word.Application();
                wordapp.Visible = true;
            }
            catch (Exception ex)
            {
                Text = ex.Message;
            }

            // определим полное имя файла с шаблоном
            object template = "\\\\ulges-fs\\software\\ulges\\eis\\DogDots\\Резерв мощность.dot";
            object newTemplate = false;
            object documentType = Word.WdNewDocumentType.wdNewBlankDocument;
            object visible = true;
            worddocument = wordapp.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);
            worddocument.Activate();

            int numQuater = (dtBegin.Value.Month / 3) + 1;
            string kv = numQuater.ToString() + " квартал ";
            kv += dtBegin.Value.Year.ToString() + " года";


            // заменим все поля в документе данными
            for (int i = 0; i < dsCalc1.tG_ReportPower_Total.Rows.Count; i++)
            {
                if (dsCalc1.tG_ReportPower_Total.Rows[i]["Voltage"].ToString() == "ВН")
                {
                    SearchAndReplace("[ВНP]", dsCalc1.tG_ReportPower_Total.Rows[i]["PowerSet"].ToString());
                    SearchAndReplace("[ВНQ]", dsCalc1.tG_ReportPower_Total.Rows[i]["Quantity"].ToString());
                    SearchAndReplace("[ВНR]", dsCalc1.tG_ReportPower_Total.Rows[i]["ReservedPower"].ToString());
                }
                if (dsCalc1.tG_ReportPower_Total.Rows[i]["Voltage"].ToString() == "НН")
                {
                    SearchAndReplace("[ННP]", dsCalc1.tG_ReportPower_Total.Rows[i]["PowerSet"].ToString());
                    SearchAndReplace("[ННQ]", dsCalc1.tG_ReportPower_Total.Rows[i]["Quantity"].ToString());
                    SearchAndReplace("[ННR]", dsCalc1.tG_ReportPower_Total.Rows[i]["ReservedPower"].ToString());
                }
                if (dsCalc1.tG_ReportPower_Total.Rows[i]["Voltage"].ToString() == "СН1")
                {
                    SearchAndReplace("[СН1P]", dsCalc1.tG_ReportPower_Total.Rows[i]["PowerSet"].ToString());
                    SearchAndReplace("[СН1Q]", dsCalc1.tG_ReportPower_Total.Rows[i]["Quantity"].ToString());
                    SearchAndReplace("[СН1R]", dsCalc1.tG_ReportPower_Total.Rows[i]["ReservedPower"].ToString());
                }
                if (dsCalc1.tG_ReportPower_Total.Rows[i]["Voltage"].ToString() == "СН2")
                {
                    SearchAndReplace("[СН2P]", dsCalc1.tG_ReportPower_Total.Rows[i]["PowerSet"].ToString());
                    SearchAndReplace("[СН2Q]", dsCalc1.tG_ReportPower_Total.Rows[i]["Quantity"].ToString());
                    SearchAndReplace("[СН2R]", dsCalc1.tG_ReportPower_Total.Rows[i]["ReservedPower"].ToString());
                }
            }

            SearchAndReplace("[квартал]", kv);

        }

        // поиск и замена текста в документе
        public void SearchAndReplace(string fndText, string fndReplText)
        {
            // Смещаем выделение к началу документа
            object unit = Word.WdUnits.wdStory;
            object extend = Word.WdMovementType.wdMove;
            wordapp.Selection.HomeKey(ref unit, ref extend);

            Word.Find fnd = wordapp.Selection.Find;
            fnd.ClearFormatting();
            fnd.Text = fndText;
            fnd.Replacement.ClearFormatting();
            fnd.Replacement.Text = fndReplText;
            ExecuteReplaceAll(fnd);
        }

        private Boolean ExecuteReplaceAll(Word.Find find)
        {
            return ExecuteReplace(find, Word.WdReplace.wdReplaceAll);
        }

        private Boolean ExecuteReplace(Word.Find find, object replaceOption)
        {
            object findText = Type.Missing;
            object matchCase = Type.Missing;
            object matchWholeWord = Type.Missing;
            object matchWildcards = Type.Missing;
            object matchSoundsLike = Type.Missing;
            object matchAllWordForms = Type.Missing;
            object forward = Type.Missing;
            object wrap = Type.Missing;
            object format = Type.Missing;
            object replaceWith = Type.Missing;
            object replace = replaceOption;
            object matchKashida = Type.Missing;
            object matchDiacritics = Type.Missing;
            object matchAlefHamza = Type.Missing;
            object matchControl = Type.Missing;

            return find.Execute(ref findText, ref matchCase,
            ref matchWholeWord, ref matchWildcards, ref matchSoundsLike,
            ref matchAllWordForms, ref forward, ref wrap, ref format,
            ref replaceWith, ref replace, ref matchKashida,
            ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }

    }
}
