using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Legal.Forms
{
    public partial class FormAbnCalcPrint : FormLbr.FormBase
    {
        private int ID; // id документа

        // 21.01.2019
        private decimal Tax20;
        private DateTime TaxDate;


        public FormAbnCalcPrint()
        {
            InitializeComponent();
            // 21.01.2019
            Tax20 = (decimal)(Constants.Constants.TaxRate20 / 100.0);
            TaxDate = new DateTime(2019, 1, 1);
        }
        
        public FormAbnCalcPrint(int id)
        {
            InitializeComponent();
            ID = id;
            // 21.01.2019
            Tax20 = (decimal)(Constants.Constants.TaxRate20 / 100.0);
            TaxDate = new DateTime(2019, 1, 1);
        }

        private void FormAbnCalcPrint_Load(object sender, EventArgs e)
        {
            // загрузим документ
            SelectSqlData(dsCntVal1, dsCntVal1.tG_Doc, true, " where id = " + ID);
            int idDog = (int)dsCntVal1.tG_Doc[0]["idDogovor"];
            SelectSqlData(dsCntVal1, dsCntVal1.tAbnDoc_List, true, " where id = " + idDog);
            int idList = (int)dsCntVal1.tAbnDoc_List[0]["id"];
            // загрузим договор
            SelectSqlData(dsCntVal1, dsCntVal1.tAbnDoc_Dogovor, true, " where idList = " + idList);

            if (dsCntVal1.tG_Doc[0]["SumRealiz"] == System.DBNull.Value)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
            }

            // загрузим счет 
            if (SelectSqlData(dsCntVal1, dsCntVal1.tG_Schet, true, " where idDocum = " + ID + " order by id desc"))
            {
                if (dsCntVal1.tG_Schet.Rows.Count > 0)
                {
                    int idSchet = Convert.ToInt32(dsCntVal1.tG_Schet[0]["id"]);
                    SelectSqlData(dsCntVal1, dsCntVal1.tG_SchetValue, true, " where idSchet = " + idSchet);
                    tb_NumSchet.Text = dsCntVal1.tG_Schet[0]["NumberSchet"].ToString();
                    dt_Schet.Value = Convert.ToDateTime(dsCntVal1.tG_Schet[0]["DateSchet"].ToString());
                    btn_AddSchet.Enabled = false;
                    btn_OpenSchet.Enabled = true;
                    btn_DelSchet.Enabled = true;
                }
                else
                {
                    dt_Schet.Value = Convert.ToDateTime(dsCntVal1.tG_Doc[0]["dtPay"].ToString());
                    tb_NumSchet.Text = dsCntVal1.tAbnDoc_Dogovor[0]["DogNumber"].ToString();

                    btn_AddSchet.Enabled = true;
                    btn_OpenSchet.Enabled = false;
                    btn_DelSchet.Enabled = false;
                }
            }

            // загрузим счет-фактуру 
            if (SelectSqlData(dsCntVal1.tG_SchetFact, true, " where idDocum = " + ID + " order by id desc", null, false, 1))
            {
                if (dsCntVal1.tG_SchetFact.Rows.Count > 0)
                {
                    int idSchetFact = Convert.ToInt32(dsCntVal1.tG_SchetFact[0]["id"]);
                    SelectSqlData(dsCntVal1, dsCntVal1.tG_SchetFactValue, true, " where idSchetFact = " + idSchetFact);
                    
                    tb_NumFact.Text = dsCntVal1.tG_SchetFact[0]["NumberSchetFact"].ToString();
                    dt_Fact.Value = Convert.ToDateTime(dsCntVal1.tG_SchetFact[0]["DateSchetFact"].ToString());

                    tb_NumAct.Text = dsCntVal1.tG_SchetFact[0]["NumberSchetFact"].ToString();
                    dt_Act.Value = Convert.ToDateTime(dsCntVal1.tG_SchetFact[0]["DateSchetFact"].ToString());

                    tb_NumInv.Text = dsCntVal1.tG_SchetFact[0]["NumberSchetFact"].ToString();
                    dt_Inv.Value = Convert.ToDateTime(dsCntVal1.tG_SchetFact[0]["DateSchetFact"].ToString());

                    dt_Schet.Value = Convert.ToDateTime(dsCntVal1.tG_SchetFact[0]["DateSchetFact"].ToString());

                    btn_AddFact.Enabled = false;
                    btn_OpenFact.Enabled = true;
                    btn_DelFact.Enabled = true;
                    btn_OpenAct.Enabled = true;
                    btn_OpenInv.Enabled = true;
                }
                else
                {
                    if (dsCntVal1.tG_Doc[0]["NumberSchetFact"] != System.DBNull.Value)
                    {
                        tb_NumFact.Text = dsCntVal1.tG_Doc[0]["NumberSchetFact"].ToString();
                        dt_Fact.Value = Convert.ToDateTime(dsCntVal1.tG_Doc[0]["dtSchetFact"].ToString());

                        tb_NumAct.Text = dsCntVal1.tG_Doc[0]["NumberSchetFact"].ToString();
                        dt_Act.Value = Convert.ToDateTime(dsCntVal1.tG_Doc[0]["dtSchetFact"].ToString());

                        tb_NumInv.Text = dsCntVal1.tG_Doc[0]["NumberSchetFact"].ToString();
                        dt_Inv.Value = Convert.ToDateTime(dsCntVal1.tG_Doc[0]["dtSchetFact"].ToString());

                        dt_Schet.Value = Convert.ToDateTime(dsCntVal1.tG_Doc[0]["dtSchetFact"].ToString());
                    }

                    btn_AddFact.Enabled = true;
                    btn_OpenFact.Enabled = false;
                    btn_DelFact.Enabled = false;
                    btn_OpenAct.Enabled = false;
                    btn_OpenInv.Enabled = false;
                }
            }

            // загрузим платежку 
            if (SelectSqlData(dsCntVal1, dsCntVal1.tG_BankReq, true, " where idDocum = " + ID + " order by id desc"))
            {
                if (dsCntVal1.tG_BankReq.Rows.Count > 0)
                {
                    tb_NumReq.Text = dsCntVal1.tG_BankReq[0]["NumberReq"].ToString();
                    dt_Req.Value = Convert.ToDateTime(dsCntVal1.tG_BankReq[0]["DateReq"].ToString());
                    btn_AddReq.Enabled = false;
                    btn_OpenReq.Enabled = true;
                    btn_DelReq.Enabled = true;
                }
                else
                {
                    if (dsCntVal1.tG_Doc[0]["dtBank"] != DBNull.Value)
                    {
                        dt_Req.Value = Convert.ToDateTime(dsCntVal1.tG_Doc[0]["dtBank"].ToString());
                    }
                    else
                    {
                        dt_Req.Value = Convert.ToDateTime(dsCntVal1.tG_Doc[0]["dtPay"].ToString());
                    }
                    tb_NumReq.Text = dsCntVal1.tAbnDoc_Dogovor[0]["DogNumber"].ToString();

                    btn_AddReq.Enabled = true;
                    btn_OpenReq.Enabled = false;
                    btn_DelReq.Enabled = false;
                }
            }

            // загрузим корректировочную счет-фактуру 
            if (SelectSqlData(dsCntVal1.tG_SchetFact_Correct, true, " where idDocum = " + ID + " order by id desc", null, false, 1))
            {
                if (dsCntVal1.tG_SchetFact_Correct.Rows.Count > 0)
                {
                    int idSchetFact = Convert.ToInt32(dsCntVal1.tG_SchetFact_Correct[0]["id"]);
                    SelectSqlData(dsCntVal1, dsCntVal1.tG_SchetFactValue_Correct, true, " where idSchetFact = " + idSchetFact);

                    tb_NumFact_Correct.Text = dsCntVal1.tG_SchetFact_Correct[0]["NumberSchetFact"].ToString();
                    dt_Fact_Correct.Value = Convert.ToDateTime(dsCntVal1.tG_SchetFact_Correct[0]["DateSchetFact"].ToString());

                    btn_AddFact_Correct.Enabled = false;
                    btn_OpenFact_Correct.Enabled = true;
                    btn_DelFact_Correct.Enabled = true;
                }
                else
                {
                    if (dsCntVal1.tG_Doc[0]["NumberSchetFact"] != System.DBNull.Value)
                    {
                        tb_NumFact_Correct.Text = dsCntVal1.tG_Doc[0]["NumberSchetFact"].ToString();
                        dt_Fact_Correct.Value = Convert.ToDateTime(dsCntVal1.tG_Doc[0]["dtSchetFact"].ToString());
                    }

                    btn_AddFact_Correct.Enabled = true;
                    btn_OpenFact_Correct.Enabled = false;
                    btn_DelFact_Correct.Enabled = false;
                }
            }



        }

        // счет
        private void btn_AddSchet_Click(object sender, EventArgs e)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "LegSchetNew2";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                // параметры

                SqlParameter p1 = new SqlParameter("@idDocum", ID);
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@NumberSchet", tb_NumSchet.Text);
                sqlCmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@DateSchet", Convert.ToDateTime(dt_Schet.Value.Date));
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
            // загрузим счет 
            if (SelectSqlData(dsCntVal1, dsCntVal1.tG_Schet, true, " where idDocum = " + ID + " order by id desc"))
            {
                if (dsCntVal1.tG_Schet.Rows.Count > 0)
                {
                    int idSchet = Convert.ToInt32(dsCntVal1.tG_Schet[0]["id"]);
                    SelectSqlData(dsCntVal1, dsCntVal1.tG_SchetValue, true, " where idSchet = " + idSchet);
                    btn_AddSchet.Enabled = false;
                    btn_OpenSchet.Enabled = true;
                    btn_DelSchet.Enabled = true;
                }
            }
        }
        private void btn_OpenSchet_Click(object sender, EventArgs e)
        {
            int idSchet = Convert.ToInt32(dsCntVal1.tG_Schet[0]["id"]);
            if (dsCntVal1.tG_Doc[0]["NumberStorno"] != System.DBNull.Value)
            {
                DateTime DateStorno = Convert.ToDateTime(dsCntVal1.tG_Doc[0]["DateStorno"]);
                bool Flag = true;
                FormSchetPrint frm = new FormSchetPrint(idSchet, DateStorno, Flag);
                frm.SqlSettings = this.SqlSettings;
                frm.Show();
            }
            else
            {
                FormSchetPrint frm = new FormSchetPrint(idSchet);
                frm.SqlSettings = this.SqlSettings;
                frm.Show();
            }
        }
        private void btn_DelSchet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dsCntVal1.tG_SchetValue.Rows.Count; i++)
                dsCntVal1.tG_SchetValue.Rows[i].Delete();
            for (int i = 0; i < dsCntVal1.tG_Schet.Rows.Count; i++)
                dsCntVal1.tG_Schet.Rows[i].Delete();

            if (DeleteSqlData(dsCntVal1, dsCntVal1.tG_SchetValue))
            {
                if (DeleteSqlData(dsCntVal1, dsCntVal1.tG_Schet))
                {
                    btn_AddSchet.Enabled = true;
                    btn_OpenSchet.Enabled = false;
                    btn_DelSchet.Enabled = false;
                    dt_Schet.Value = Convert.ToDateTime(dsCntVal1.tG_Doc[0]["dtPay"].ToString());
                    tb_NumSchet.Text = dsCntVal1.tAbnDoc_Dogovor[0]["DogNumber"].ToString();
                }
                else
                    MessageBox.Show("Не удалось удалить счет ..");
            }
            else
                MessageBox.Show("Не удалось удалить табличную часть счета ..");

        }

        // счет-фактура
        private void btn_AddFact_Click(object sender, EventArgs e)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "LegSchetFactNew";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                // параметры

                SqlParameter p1 = new SqlParameter("@idDocum", ID);
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@NumberFact", tb_NumFact.Text);
                sqlCmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@DateFact", Convert.ToDateTime(dt_Fact.Value.Date));
                sqlCmd.Parameters.Add(p3);

                SqlParameter p4;
                if (Convert.ToDateTime(dt_Fact.Value) >= TaxDate)
                    p4 = new SqlParameter("@TaxRate", Constants.Constants.TaxRate20);
                else
                    p4 = new SqlParameter("@TaxRate", Constants.Constants.TaxRate18);

                sqlCmd.Parameters.Add(p4);

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
            // загрузим счет-фактуру 
            if (SelectSqlData(dsCntVal1, dsCntVal1.tG_SchetFact, true, " where idDocum = " + ID + " order by id desc"))
            {
                if (dsCntVal1.tG_SchetFact.Rows.Count > 0)
                {
                    int idSchetFact = Convert.ToInt32(dsCntVal1.tG_SchetFact[0]["id"]);
                    SelectSqlData(dsCntVal1, dsCntVal1.tG_SchetFactValue, true, " where idSchetFact = " + idSchetFact);
                    tb_NumFact.Text = dsCntVal1.tG_SchetFact[0]["NumberSchetFact"].ToString();
                    dt_Fact.Value = Convert.ToDateTime(dsCntVal1.tG_SchetFact[0]["DateSchetFact"].ToString());
                    tb_NumAct.Text = dsCntVal1.tG_SchetFact[0]["NumberSchetFact"].ToString();
                    dt_Act.Value = Convert.ToDateTime(dsCntVal1.tG_SchetFact[0]["DateSchetFact"].ToString());
                    tb_NumInv.Text = dsCntVal1.tG_SchetFact[0]["NumberSchetFact"].ToString();
                    dt_Inv.Value = Convert.ToDateTime(dsCntVal1.tG_SchetFact[0]["DateSchetFact"].ToString());
                    btn_AddFact.Enabled = false;
                    btn_OpenFact.Enabled = true;
                    btn_DelFact.Enabled = true;
                    btn_OpenAct.Enabled = true;
                    btn_OpenInv.Enabled = true;
                }
            }

        }
        private void btn_OpenFact_Click(object sender, EventArgs e)
        {
            
            int idSchet = Convert.ToInt32(dsCntVal1.tG_SchetFact[0]["id"]);
            DateTime dtFact = Convert.ToDateTime(dt_Fact.Value.Date);
            Legal.Forms.FormRep.FormFactPrint frm = new Legal.Forms.FormRep.FormFactPrint(idSchet, dtFact);
            frm.SqlSettings = this.SqlSettings;
            frm.Show();
        }
        private void btn_DelFact_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dsCntVal1.tG_SchetFactValue.Rows.Count; i++)
                dsCntVal1.tG_SchetFactValue.Rows[i].Delete();
            for (int i = 0; i < dsCntVal1.tG_SchetFact.Rows.Count; i++)
                dsCntVal1.tG_SchetFact.Rows[i].Delete();

            if (DeleteSqlData(dsCntVal1, dsCntVal1.tG_SchetFactValue))
            {
                if (DeleteSqlData(dsCntVal1, dsCntVal1.tG_SchetFact))
                {
                    btn_AddFact.Enabled = true;
                    btn_OpenFact.Enabled = false;
                    btn_DelFact.Enabled = false;
                    btn_OpenAct.Enabled = false;
                    btn_OpenInv.Enabled = false;

                }
                else
                    MessageBox.Show("Не удалось удалить счет-фактуру ..");
            }
            else
                MessageBox.Show("Не удалось удалить табличную часть счет-фактуры ..");
        }

        // акт оказания услуг
        private void btn_OpenAct_Click(object sender, EventArgs e)
        {
            if (dsCntVal1.tG_Doc[0]["NumberStorno"] != System.DBNull.Value)
            {
                int NumberStorno = Convert.ToInt32(dsCntVal1.tG_Doc[0]["NumberStorno"]);
                DateTime DateStorno = Convert.ToDateTime(dsCntVal1.tG_Doc[0]["DateStorno"]);
                bool Flag = true;
                int idAct = Convert.ToInt32(dsCntVal1.tG_SchetFact[0]["id"]);
                decimal pSumNalog = Convert.ToDecimal(dsCntVal1.tG_Doc[0]["SumNalog"]);
                decimal pSumTotal = Convert.ToDecimal(dsCntVal1.tG_Doc[0]["SumTotal"]);
                Legal.Forms.FormRep.FormActPrint frm = new Legal.Forms.FormRep.FormActPrint(idAct, NumberStorno, DateStorno, Flag);
                frm.SqlSettings = this.SqlSettings;
                frm.Show();
            }
            else
            {
                int idAct = Convert.ToInt32(dsCntVal1.tG_SchetFact[0]["id"]);
                decimal pSumNalog = Convert.ToDecimal(dsCntVal1.tG_Doc[0]["SumNalog"]);
                decimal pSumTotal = Convert.ToDecimal(dsCntVal1.tG_Doc[0]["SumTotal"]);
                Legal.Forms.FormRep.FormActPrint frm = new Legal.Forms.FormRep.FormActPrint(idAct);
                frm.SqlSettings = this.SqlSettings;
                frm.Show();
            }
        }

        // накладная
        private void btn_OpenInv_Click(object sender, EventArgs e)
        {
            if (dsCntVal1.tG_Doc[0]["NumberStorno"] != System.DBNull.Value)
            {
                int NumberStorno = Convert.ToInt32(dsCntVal1.tG_Doc[0]["NumberStorno"]);
                DateTime DateStorno = Convert.ToDateTime(dsCntVal1.tG_Doc[0]["DateStorno"]);
                bool Flag = true;
                int idInv = Convert.ToInt32(dsCntVal1.tG_SchetFact[0]["id"]);
                decimal pSumNalog = Convert.ToDecimal(dsCntVal1.tG_Doc[0]["SumNalog"]);
                decimal pSumTotal = Convert.ToDecimal(dsCntVal1.tG_Doc[0]["SumTotal"]);
                Legal.Forms.FormRep.FormInvPrint frm = new Legal.Forms.FormRep.FormInvPrint(idInv, NumberStorno, DateStorno, Flag);
                frm.SqlSettings = this.SqlSettings;
                frm.Show();
            }
            else
            {
                int idInv = Convert.ToInt32(dsCntVal1.tG_SchetFact[0]["id"]);
                decimal pSumNalog = Convert.ToDecimal(dsCntVal1.tG_Doc[0]["SumNalog"]);
                decimal pSumTotal = Convert.ToDecimal(dsCntVal1.tG_Doc[0]["SumTotal"]);
                Legal.Forms.FormRep.FormInvPrint frm = new Legal.Forms.FormRep.FormInvPrint(idInv);
                frm.SqlSettings = this.SqlSettings;
                frm.Show();
            }
        }

        // платежка
        private void btn_AddReq_Click(object sender, EventArgs e)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "LegBankReqNew";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                // параметры

                SqlParameter p1 = new SqlParameter("@idDocum", ID);
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@NumberReq", tb_NumReq.Text);
                sqlCmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@DateReq", Convert.ToDateTime(dt_Req.Value.Date));
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
            // загрузим платежку
            if (SelectSqlData(dsCntVal1, dsCntVal1.tG_BankReq, true, " where idDocum = " + ID + " order by id desc"))
            {
                if (dsCntVal1.tG_BankReq.Rows.Count > 0)
                {
                    btn_AddReq.Enabled = false;
                    btn_OpenReq.Enabled = true;
                    btn_DelReq.Enabled = true;
                }
            }

        }
        private void btn_OpenReq_Click(object sender, EventArgs e)
        {
            int idReq = Convert.ToInt32(dsCntVal1.tG_BankReq[0]["id"]);
            Legal.Forms.FormRep.FormBankReqPrint frm = new Legal.Forms.FormRep.FormBankReqPrint(idReq);
            frm.SqlSettings = this.SqlSettings;
            frm.Show();
        }
        private void btn_DelReq_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dsCntVal1.tG_BankReq.Rows.Count; i++)
                dsCntVal1.tG_BankReq.Rows[i].Delete();

            if (DeleteSqlData(dsCntVal1, dsCntVal1.tG_BankReq))
            {
                btn_AddReq.Enabled = true;
                btn_OpenReq.Enabled = false;
                btn_DelReq.Enabled = false;

                dt_Req.Value = Convert.ToDateTime(dsCntVal1.tG_Doc[0]["dtPay"].ToString());
                tb_NumReq.Text = dsCntVal1.tAbnDoc_Dogovor[0]["DogNumber"].ToString();
            }
            else
                MessageBox.Show("Не удалось удалить платежку ..");
        }

        // счет-фактура корректировочный
        private void btn_AddFact_Correct_Click(object sender, EventArgs e)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "LegSchetFactNew_Correct";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                // параметры

                SqlParameter p1 = new SqlParameter("@idDocum", ID);
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@NumberFact", tb_NumFact.Text);
                sqlCmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@DateFact", Convert.ToDateTime(dt_Fact.Value.Date));
                sqlCmd.Parameters.Add(p3);


                SqlParameter p4;
                //if (Convert.ToDateTime(dt_Fact_Correct.Value) >= TaxDate)
                    p4 = new SqlParameter("@TaxRate", Constants.Constants.TaxRate20);
                //else
                  //  p4 = new SqlParameter("@TaxRate", Constants.Constants.TaxRate18);

                // если дата сторнируемой фактуры до 2019г в хранимой процедуре TaxRate 
                // устанавливается 18%

                sqlCmd.Parameters.Add(p4);

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
            // загрузим счет-фактуру 
            if (SelectSqlData(dsCntVal1, dsCntVal1.tG_SchetFact_Correct, true, " where idDocum = " + ID))
            {
                if (dsCntVal1.tG_SchetFact_Correct.Rows.Count > 0)
                {
                    int idSchetFact = Convert.ToInt32(dsCntVal1.tG_SchetFact_Correct[0]["id"]);
                    SelectSqlData(dsCntVal1, dsCntVal1.tG_SchetFactValue_Correct, true, " where idSchetFact = " + idSchetFact);
                    tb_NumFact.Text = dsCntVal1.tG_SchetFact_Correct[0]["NumberSchetFact"].ToString();
                    dt_Fact.Value = Convert.ToDateTime(dsCntVal1.tG_SchetFact_Correct[0]["DateSchetFact"].ToString());
                    btn_AddFact_Correct.Enabled = false;
                    btn_OpenFact_Correct.Enabled = true;
                    btn_DelFact_Correct.Enabled = true;
                }
            }
        }
        private void btn_OpenFact_Correct_Click(object sender, EventArgs e)
        {
            int idSchet = Convert.ToInt32(dsCntVal1.tG_SchetFact_Correct[0]["id"]);
            DateTime dtFact = Convert.ToDateTime(dt_Fact_Correct.Value.Date);
            Legal.Forms.FormRep.FormFactPrint_Correct frm = new Legal.Forms.FormRep.FormFactPrint_Correct(idSchet, dtFact);
            frm.SqlSettings = this.SqlSettings;
            frm.Show();
        }
        private void btn_DelFact_Correct_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dsCntVal1.tG_SchetFactValue_Correct.Rows.Count; i++)
                dsCntVal1.tG_SchetFactValue_Correct.Rows[i].Delete();
            for (int i = 0; i < dsCntVal1.tG_SchetFact_Correct.Rows.Count; i++)
                dsCntVal1.tG_SchetFact_Correct.Rows[i].Delete();

            if (DeleteSqlData(dsCntVal1, dsCntVal1.tG_SchetFactValue_Correct))
            {
                if (DeleteSqlData(dsCntVal1, dsCntVal1.tG_SchetFact_Correct))
                {
                    btn_AddFact_Correct.Enabled = true;
                    btn_OpenFact_Correct.Enabled = false;
                    btn_DelFact_Correct.Enabled = false;

                }
                else
                    MessageBox.Show("Не удалось удалить счет-фактуру ..");
            }
            else
                MessageBox.Show("Не удалось удалить табличную часть счет-фактуры ..");
        }

  

    }
}
