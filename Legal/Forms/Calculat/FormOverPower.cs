using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;

namespace Legal.Forms.Calculat
{
    public partial class FormOverPower : FormLbr.FormBase
    {
        private DataTable dtObjList;
        private DateTime GOD;
        private SolidBrush brRed = new SolidBrush(Color.Red);
        private int IDABN;
        private int IDDOG;
        private DateTime DTPAY;

        public FormOverPower()
        {
            InitializeComponent();
        }

        public FormOverPower(DataTable dtObj, DateTime god, int idAbn, int idDog, DateTime dtPay)
        {
            InitializeComponent();
            dtObjList = dtObj;
            GOD = god;
            IDABN = idAbn;
            IDDOG = idDog;
            DTPAY = dtPay;
        }


        private void FormOverPower_Load(object sender, EventArgs e)
        {
            for (int cnt = 0; cnt < dtObjList.Rows.Count; cnt++)
            {
                if (dtObjList.Rows[cnt]["Quantity"] != DBNull.Value)
                {

                    Load_dgvPowerTable((int)dtObjList.Rows[cnt]["idObj"]);
                    if ((int)dsCntVal.tPower.Rows[2]["CountOver"] > 1)
                    {
                        DataRow rw = dsCntVal.tObjListSelect.Rows.Add();
                        rw["idObj"] = (int)dtObjList.Rows[cnt]["idObj"];
                        rw["NameObj"] = (string)dtObjList.Rows[cnt]["NameObj"];
                        rw["idTariff"] = (int)dtObjList.Rows[cnt]["idTariff"];
                        rw["Tariff"] = (decimal)dtObjList.Rows[cnt]["Tariff"];
                        rw["dtCalc"] = dtObjList.Rows[cnt]["dtCalc"];
                        rw["Quantity"] = (int)dtObjList.Rows[cnt]["Quantity"];
                    }
                }
            }

            // загружаем объекты 
            if (dsCntVal.tObjListSelect.Rows.Count > 0)
            {
                clbObj.ValueMember = "idObj";
                clbObj.DisplayMember = "NameObj";
                clbObj.DataSource = dsCntVal.tObjListSelect;

                Load_dgvPowerTable((int)clbObj.SelectedValue);
                Load_chart1();
            }

        }

        // загружаем данные в грид
        private void Load_dgvPowerTable(int idObj)
        {
            dsCntVal.tPower.Clear();
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "select * from fn_LegGetObjPower(@idObj, @god) ";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                SqlParameter p1 = new SqlParameter("@idObj", idObj);
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@god", GOD);
                sqlCmd.Parameters.Add(p2);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCntVal, "tPower");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }

            if (dgvPowerTable.Rows.Count > 3)
            {
                for (int i = 1; i < 13; i++)
                {
                    if ((int)dgvPowerTable.Rows[3].Cells[i].Value > 10)
                    {
                        //Меняем цвет ячейки
                        dgvPowerTable.Rows[3].Cells[i].Style.BackColor = Color.Red;
                        dgvPowerTable.Rows[3].Cells[i].Style.ForeColor = Color.Black;
                    }
                }
            }


        }

        // загружаем данные в графики
        private void Load_chart1()
        {

            chart1.Series.Clear();
            foreach (DataRow row in dsCntVal.tPower.Rows)
            {
                // For each Row add a new series
                string seriesName = row["PowerType"].ToString();
                chart1.Series.Add(seriesName);
                chart1.Series[seriesName].ChartType = SeriesChartType.Column;
                chart1.Series[seriesName].BorderWidth = 2;

                for (int colIndex = 1; colIndex < dsCntVal.tPower.Columns.Count-2; colIndex++)
                {
                    // For each column (column 1 and onward) add the value as a point
                    string columnName = dsCntVal.tPower.Columns[colIndex].ColumnName;
                    int YVal = Convert.ToInt32(row[columnName]);
                    columnName = columnName.Substring(3);
                    chart1.Series[seriesName].Points.AddXY(columnName, YVal);
                }
            }
        }


        private void clbObj_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (clbObj.SelectedValue != null)
                Load_dgvPowerTable((int)clbObj.SelectedValue);
            Load_chart1();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal STotal = 0;
            int QTotal = 0;
            // отбираем все выбранные объекты    cnt индекс объекта
            for (int cnt = 0; cnt < clbObj.SelectedIndices.Count; cnt++)
            {
                // id выбранного объекта 
                int idx = (int)dsCntVal.tObjListSelect.Rows[clbObj.SelectedIndices[cnt]]["idObj"];
                // текущий месяц
                int MONTH = ((DateTime)dsCntVal.tObjListSelect.Rows[clbObj.SelectedIndices[cnt]]["dtCalc"]).Month;
                decimal TARIFF = (decimal)dsCntVal.tObjListSelect.Rows[clbObj.SelectedIndices[cnt]]["Tariff"];
                // находим отклонения от заявленного объема
                Load_dgvPowerTable(idx);
                int QUANTITY = dsCntVal.tPower.Rows[2].Field<int>(MONTH);
                decimal SUMMA = Math.Round(QUANTITY * TARIFF,2);
                STotal = STotal + SUMMA;
                QTotal = QTotal + QUANTITY;
                tbSumma.Text = STotal.ToString();
                tbQuantity.Text = QTotal.ToString();
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            // сначала формируем документ
            DataRow r = dsCntVal.tG_Doc.NewRow();
            r["id"] = -1;
            r["idAbn"] = IDABN;
            r["idDogovor"] = IDDOG;
            r["Blocking"] = false;
            r["dtPay"] = DTPAY;
            r["dtBank"] = DTPAY.AddMonths(1);
            dsCntVal.tG_Doc.Rows.Add(r);
            int id = this.InsertSqlDataOneRow(dsCntVal, dsCntVal.tG_Doc);
            if (id < 0)
                MessageBox.Show("Не удалось добавить договор");
            else
            {
                // теперь добавим начисления по объектам
                decimal STotal = 0;
                decimal QTotal = 0;
                // отбираем все выбранные объекты    cnt индекс объекта
                for (int cnt = 0; cnt < clbObj.SelectedIndices.Count; cnt++)
                {
                    // id выбранного объекта 
                    int idx = (int)dsCntVal.tObjListSelect.Rows[clbObj.SelectedIndices[cnt]]["idObj"];
                    // текущий месяц
                    int MONTH = ((DateTime)dsCntVal.tObjListSelect.Rows[clbObj.SelectedIndices[cnt]]["dtCalc"]).Month;
                    decimal TARIFF = (decimal)dsCntVal.tObjListSelect.Rows[clbObj.SelectedIndices[cnt]]["Tariff"];
                    int IDTARIFF = (int)dsCntVal.tObjListSelect.Rows[clbObj.SelectedIndices[cnt]]["idTariff"];
                    // находим отклонения от заявленного объема
                    Load_dgvPowerTable(idx);
                    int QUANTITY = dsCntVal.tPower.Rows[2].Field<int>(MONTH);
                    decimal SUMMA = Math.Round(QUANTITY * TARIFF, 2);
                    STotal = STotal + SUMMA;
                    QTotal = QTotal + QUANTITY;
                    tbSumma.Text = STotal.ToString();
                    tbQuantity.Text = QTotal.ToString();
                    quantitySet(id, idx, QUANTITY, SUMMA, TARIFF, IDTARIFF);
                }
            }

        }


        private void quantitySet(int id, int idx, int Quantity, decimal Summa, decimal Tariff, int idTariff)
        {
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);

                    string strCmd = "";
                    strCmd = "sp_LegObjSet";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    // параметры

                    SqlParameter p1 = new SqlParameter("@idAbnObj", idx);
                    sqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter("@idAbn", IDABN);
                    sqlCmd.Parameters.Add(p2);

                    SqlParameter p3 = new SqlParameter("@idDogovor", IDDOG);
                    sqlCmd.Parameters.Add(p3);

                    SqlParameter p4 = new SqlParameter("@Date", DTPAY);
                    sqlCmd.Parameters.Add(p4);

                    SqlParameter p5 = new SqlParameter("@ModeCalc", Constants.Constants.TypeOverPower);
                    sqlCmd.Parameters.Add(p5);

                    SqlParameter p6 = new SqlParameter("@QuantityCalc", Quantity);
                    sqlCmd.Parameters.Add(p6);

                    SqlParameter p7 = new SqlParameter("@Quantity", Quantity);
                    sqlCmd.Parameters.Add(p7);

                    SqlParameter p8 = new SqlParameter("@Summa", Summa);
                    sqlCmd.Parameters.Add(p8);

                    SqlParameter p9 = new SqlParameter("@idTariff", idTariff);
                    sqlCmd.Parameters.Add(p9);

                    SqlParameter p10 = new SqlParameter("@Tariff", Tariff);
                    sqlCmd.Parameters.Add(p10);

                    SqlParameter p11 = new SqlParameter("@idDocum", id);
                    sqlCmd.Parameters.Add(p11);

                    SqlParameter p12 = new SqlParameter("@TypeOfEnergy", Constants.Constants.TypeTransmission);
                    sqlCmd.Parameters.Add(p12);

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
