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
    public partial class FormAbnCalc : FormLbr.FormBase
    {
        public int ID;
        private decimal STOT;
        private int QTOT;
        private decimal NTOT;
        //private decimal Tax;

        public FormAbnCalc()
        {
            InitializeComponent();
        }

        public FormAbnCalc(int idDocum)
        {
            InitializeComponent();
            ID = idDocum;
        }
        
        public FormAbnCalc(int idDocum, decimal SumTotal, int QuantityTotal, decimal SumNalog)
        {
            InitializeComponent();
            ID = idDocum;
            STOT = SumTotal;
            QTOT = QuantityTotal;
            NTOT = SumNalog;
            //Tax = (decimal)(Constants.Constants.TaxRate18 / 100.0);
        }

        private void FormAbnCalc_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsCntVal1, dsCntVal1.tG_Doc, true, " where id = " + ID);

            // виды платежа
            f_PaymentSelect_Load();
            // документы по тарифам
            f_TariffLegal_Load();
            // типы счет-фактуры
            f_TypeFact_Load();
            f_SelectFactNumberLoad((int)f_TypeFact.SelectedValue, f_DateFact.Value.Year, f_DateFact.Value.Month);
            f_Select_FactNumber.Enabled = true; 

            
            bool block = false;
            if (dsCntVal1.tG_Doc.Rows[0]["Blocking"] != DBNull.Value)
                block = Convert.ToBoolean(dsCntVal1.tG_Doc.Rows[0]["Blocking"]);

            if (block)
            {
                this.btnCalc.Enabled = false;
                blockingCheckBox.CheckState = CheckState.Checked;
            }
            else
            {
//                dsCntVal1.tG_Doc.Rows[0]["SumRealiz"] = Convert.ToString(Math.Round(STOT, 2));
//                dsCntVal1.tG_Doc.Rows[0]["SumNalog"] = Convert.ToString(Math.Round(STOT * Tax, 2));
//                dsCntVal1.tG_Doc.Rows[0]["SumTotal"] = Convert.ToString(Math.Round(STOT, 2) + Math.Round(STOT * Tax, 2));

                dsCntVal1.tG_Doc.Rows[0]["SumRealiz"] = Convert.ToString(STOT);
                dsCntVal1.tG_Doc.Rows[0]["SumNalog"] = Convert.ToString(NTOT);
                dsCntVal1.tG_Doc.Rows[0]["SumTotal"] = Convert.ToString(STOT + NTOT);

                dsCntVal1.tG_Doc.Rows[0]["Quantity"] = Convert.ToString(QTOT);
                if (dsCntVal1.tG_Doc.Rows[0]["Payment"] == DBNull.Value)
                    dsCntVal1.tG_Doc.Rows[0]["Payment"] = f_PaymentSelect.Text + ", за " + f_dtPay.Value.ToString("MMMM") + " " + f_dtPay.Value.Date.Year + "г.";
                blockingCheckBox.CheckState = CheckState.Unchecked;
            }

            // проверим тип договора
            int idDog = (int)dsCntVal1.tG_Doc[0]["idDogovor"];
            //SelectSqlData(dsCntVal1, dsCntVal1.tAbnDoc_Dogovor, true, " where id = " + idDog);
            //int idList = (int)dsCntVal1.tAbnDoc_Dogovor[0]["idList"];
            SelectSqlData(dsCntVal1, dsCntVal1.tAbnDoc_List, true, " where id = " + idDog);
            int TypeDog = (int)dsCntVal1.tAbnDoc_List[0]["idDocType"];
            // если непрямой договор, то счет-фактура не нужен
            if (TypeDog != (int)Constants.DocType.Dogovor)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
                // если тип счет-факт не определен устанавливаем обычный
                if (dsCntVal1.tG_Doc.Rows[0]["SchetFactType"] == System.DBNull.Value)
                {
                    f_TypeFact.SelectedIndex = 0;
                }
            }
            f_Select_FactNumber.Enabled = true; 

        }

        // сохранить изменения
        private void btnCalc_Click(object sender, EventArgs e)
        {
            dsCntVal1.tG_Doc.Rows[0]["dtPay"] = f_dtPay.Value.Date;
            dsCntVal1.tG_Doc.Rows[0]["dtBank"] = f_dtBank.Value.Date;
            dsCntVal1.tG_Doc.Rows[0]["Base"] = f_TariffLegal.SelectedValue;

            // если прямой договор 
            if (groupBox1.Enabled == true)
            {
                if (f_NumberFact.Text != "")
                {
                    dsCntVal1.tG_Doc.Rows[0]["NumberSchetFact"] = Convert.ToInt32(f_NumberFact.Text);
                    dsCntVal1.tG_Doc.Rows[0]["dtSchetFact"] = f_DateFact.Value.Date;
                }
                if (f_NumberFactCorrect.Value != 0)
                {
                    dsCntVal1.tG_Doc.Rows[0]["NumberFactCorrection"] = f_NumberFactCorrect.Value;
                    dsCntVal1.tG_Doc.Rows[0]["dtFactCorrection"] = f_DateFactCorrect.Value.Date;
                }
                if (f_NumberStorno.Text != "")
                {
                    dsCntVal1.tG_Doc.Rows[0]["NumberStorno"] = Convert.ToInt32(f_NumberStorno.Text);
                    dsCntVal1.tG_Doc.Rows[0]["DateStorno"] = f_DateStorno.Value.Date;
                }
                if (dsCntVal1.tG_Doc.Rows[0]["SchetFactType"] == System.DBNull.Value)
                    f_TypeFact.SelectedIndex = 0;

                dsCntVal1.tG_Doc.Rows[0]["SchetFactType"] = (int)f_TypeFact.SelectedValue;
            }

            dsCntVal1.tG_Doc.Rows[0].EndEdit(); 
            if (!UpdateSqlData(dsCntVal1, dsCntVal1.tG_Doc))
                MessageBox.Show("Не удалось сохранить внесенные изменения ..");
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void f_PaymentSelect_Load()
        {
            int idType = 560;
            SelectSqlData(dsCntVal1, dsCntVal1.tR_Classifier, true, " where ParentID = " + idType.ToString());
            f_PaymentSelect.SelectedValue = 561;
        }

        private void f_PaymentSelect_TextChanged(object sender, EventArgs e)
        {
            dsCntVal1.tG_Doc.Rows[0]["Payment"] = f_PaymentSelect.Text + ", за " + f_dtPay.Value.ToString("MMMM") + " " + f_dtPay.Value.Date.Year + "г.";
        }

        // загрузка типов счет-фактур
        private void f_TypeFact_Load()
        {
            int idType = 570;
            SelectSqlDataTableOther(dsCntVal1, dsCntVal1.tR_Classifier2, "tR_Classifier", true, " where ParentID = " + idType.ToString() +  " and Value = 1 order by id");
        }

        private void f_TariffLegal_Load()
        {
            int idType = 565;
            SelectSqlDataTableOther(dsCntVal1, dsCntVal1.tR_Classifier1, "tR_Classifier", true, " where ParentID = " + idType.ToString() + "order by id desc");
        }

        // получить номер счет-фактуры
        private void btnGetNumberFact_Click(object sender, EventArgs e)
        {
            if (f_NumberFact.Text == "")
            {
                int NumberSchetFact = GetFactNumber((int)f_TypeFact.SelectedValue, f_DateFact.Value.Year, f_DateFact.Value.Month);
                if (NumberSchetFact != -1)
                {
                    f_NumberFact.Text = NumberSchetFact.ToString();
                }
                else
                {
                    MessageBox.Show("Превышено максимальное значение номера счет-фактуры на данный период!");
                }
            }
        }

        private int GetFactNumber(int FactType, int FactYear, int FactMonth)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "LegGetNumFact";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@FactType", FactType);
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@FactYear", FactYear);
                sqlCmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@FactMonth", FactMonth);
                sqlCmd.Parameters.Add(p3);

                int FactNumber = 0;
                SqlParameter p4 = new SqlParameter("@FactNumber", FactNumber);
                p4.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(p4);

                sqlCmd.UpdatedRowSource = UpdateRowSource.OutputParameters;

                sqlCmd.CommandTimeout = 0;

                sqlCmd.ExecuteNonQuery();

                int newFactNumber = (int)sqlCmd.Parameters["@FactNumber"].Value;

                return newFactNumber;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                return -1;
            }
            finally
            {
                con.CloseConnection();
            }
        }

        // меняем тип счет-фактуры
        private void f_TypeFact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f_TypeFact.SelectedIndex == 0)
            {
                f_NumberFactCorrect.Enabled = true;
                f_DateFactCorrect.Enabled = true;
                f_NumberStorno.Enabled = false;
                f_DateStorno.Enabled = false;
            }
            if (f_TypeFact.SelectedIndex == 1)
            {
                f_NumberFactCorrect.Enabled = true;
                f_DateFactCorrect.Enabled = true;
                f_NumberStorno.Enabled = true;
                f_DateStorno.Enabled = true;
            }
            if (f_TypeFact.SelectedIndex == 2)
            {
                f_NumberFactCorrect.Enabled = true;
                f_DateFactCorrect.Enabled = true;
                f_NumberStorno.Enabled = false;
                f_DateStorno.Enabled = false;
            }
            f_Select_FactNumber.Enabled = true; 

        }

        // загружаем свободные номера счетов-фактур
        private void f_SelectFactNumberLoad(int FactType, int FactYear, int FactMonth)
        {
            dsCalc1.dtNumberSelect.Clear();
            DataSql.SqlDataConnect con1 = new DataSql.SqlDataConnect();
            try
            {
                con1.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "select * from fn_LegFactNumber_Select(@FactType, @FactYear, @FactMonth) ";
                strCmd += " order by FactNumber";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con1.Connection);

                SqlParameter p1 = new SqlParameter("@FactType", FactType);
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@FactYear", FactYear);
                sqlCmd.Parameters.Add(p2);

                SqlParameter p3 = new SqlParameter("@FactMonth", FactMonth);
                sqlCmd.Parameters.Add(p3);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCalc1, "dtNumberSelect");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con1.CloseConnection();
            }

        }

        private void f_DateFact_ValueChanged(object sender, EventArgs e)
        {
            // свободные номера счетов-фактур
            f_SelectFactNumberLoad((int)f_TypeFact.SelectedValue, f_DateFact.Value.Year, f_DateFact.Value.Month);
            f_Select_FactNumber.Enabled = true; 

        }

        private void f_Select_FactNumber_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
//            f_NumberFact.Text = f_Select_FactNumber.Text;
        }

        private void f_Select_FactNumber_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            f_NumberFact.Text = f_Select_FactNumber.Text;
        }

  


    }

}
