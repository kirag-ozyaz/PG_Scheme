using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Legal.Forms.Meter
{
    public partial class FormMeasurementsOfCounters : FormLbr.FormBase
    {
        private int ID = -1;
        private int IDPOINTREG = -1;
        private int IDOBJ = -1;
        private bool isUpdate = false;
        // количество плановых часов
        private int HourCount = 0;

        public FormMeasurementsOfCounters()
        {
            InitializeComponent();
        }

        // специальный конструктор
        public FormMeasurementsOfCounters(int par, bool update, int idObj)
        {
            InitializeComponent();
            if (update == false)
            {
                IDPOINTREG = par;
            }
            else
            {
                ID = par;
            }
            isUpdate = update;
            IDOBJ = idObj;
        }

        // загрузка
        private void FormMeasurementsOfCounters_Load(object sender, EventArgs e)
        {

            if (isUpdate == false)
            {
                DataRow r = dsAbnObjAct1.tG_MeasurementsOfCounters.NewRow();

                // берем последний режимный день
                this.SelectSqlData(dsAbnObjAct1, dsAbnObjAct1.tG_MeasurementsHour, true, "order by YearValue, MonthValue desc");
                int yy = (int)dsAbnObjAct1.tG_MeasurementsHour[0]["YearValue"];
                int mm = (int)dsAbnObjAct1.tG_MeasurementsHour[0]["MonthValue"];
                int dd = (int)dsAbnObjAct1.tG_MeasurementsHour[0]["MeasurementsDay"];
                
                r["DateOfIntroduction"] = new DateTime(yy, mm, dd);
                r["idPointReg"] = IDPOINTREG;
                r["t1"] = 0; r["t2"] = 0; r["t3"] = 0; r["t4"] = 0; r["t5"] = 0; r["t6"] = 0; r["t7"] = 0; r["t8"] = 0;
                r["t9"] = 0; r["t10"] = 0; r["t11"] = 0; r["t12"] = 0; r["t13"] = 0; r["t14"] = 0; r["t15"] = 0; r["t16"] = 0;
                r["t17"] = 0; r["t18"] = 0; r["t19"] = 0; r["t20"] = 0; r["t21"] = 0; r["t22"] = 0; r["t23"] = 0; r["t24"] = 0;
                r["idZone"] = 263;
                dsAbnObjAct1.tG_MeasurementsOfCounters.Rows.Add(r);
                this.Text = "Новые замеры";
            }
            else
            {
                // находим часы исходя из известного режимного дня
                this.SelectSqlData(dsAbnObjAct1, dsAbnObjAct1.tG_MeasurementsOfCounters, true, " where id = " + ID.ToString());

                int yy = ((DateTime)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["DateOfIntroduction"]).Year;
                int mm = ((DateTime)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["DateOfIntroduction"]).Month;
                int dd = ((DateTime)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["DateOfIntroduction"]).Day;

                this.SelectSqlData(dsAbnObjAct1, dsAbnObjAct1.tG_MeasurementsHour, true, "where YearValue = " + yy + " and MonthValue = " + mm + " and MeasurementsDay = " + dd);

                this.Text = "Редактирование замеров";
            }
            MeasurementsHour();

        }

        // сохраняем данные
        private void btnOK_Click(object sender, EventArgs e)
        {
            AverageValue();
            bool isOk = false;
            dsAbnObjAct1.tG_MeasurementsOfCounters.Rows[0].EndEdit();
            if (isUpdate == false)
            {
                ID = this.InsertSqlDataOneRow(dsAbnObjAct1, dsAbnObjAct1.tG_MeasurementsOfCounters);
                if (ID > 0)
                {
                    MeasurementsOfCountersToMeasurementsOfObject();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Не удалось добавить замеры");
            }
            else
            {
                isOk = this.UpdateSqlData(dsAbnObjAct1, dsAbnObjAct1.tG_MeasurementsOfCounters);
                if (isOk)
                {
                    MeasurementsOfCountersToMeasurementsOfObject();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Не удалось изменить замеры");
            }
            Close();
        }

        // находим среднее значение
        private void AverageValue()
        {
            decimal v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24;  
            v1 = 0; v2 = 0; v3 = 0; v4 = 0; v5 = 0; v6 = 0; v7 = 0; v8 = 0; v9 = 0; v10 = 0; v11 = 0; v12 = 0;
            v13 = 0; v14 = 0; v15 = 0; v16 = 0; v17 = 0; v18 = 0; v19 = 0; v20 = 0; v21 = 0; v22 = 0; v23 = 0; v24 = 0;

            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t1"] != System.DBNull.Value && numericUpDown1.BackColor == Color.Gold) { v1 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t1"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t2"] != System.DBNull.Value && numericUpDown2.BackColor == Color.Gold) { v2 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t2"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t3"] != System.DBNull.Value && numericUpDown3.BackColor == Color.Gold) { v3 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t3"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t4"] != System.DBNull.Value && numericUpDown4.BackColor == Color.Gold) { v4 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t4"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t5"] != System.DBNull.Value && numericUpDown5.BackColor == Color.Gold) { v5 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t5"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t6"] != System.DBNull.Value && numericUpDown6.BackColor == Color.Gold) { v6 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t6"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t7"] != System.DBNull.Value && numericUpDown7.BackColor == Color.Gold) { v7 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t7"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t8"] != System.DBNull.Value && numericUpDown8.BackColor == Color.Gold) { v8 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t8"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t9"] != System.DBNull.Value && numericUpDown9.BackColor == Color.Gold) { v9 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t9"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t10"] != System.DBNull.Value && numericUpDown10.BackColor == Color.Gold) { v10 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t10"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t11"] != System.DBNull.Value && numericUpDown11.BackColor == Color.Gold) { v11 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t11"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t12"] != System.DBNull.Value && numericUpDown12.BackColor == Color.Gold) { v12 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t12"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t13"] != System.DBNull.Value && numericUpDown13.BackColor == Color.Gold) { v13 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t13"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t14"] != System.DBNull.Value && numericUpDown14.BackColor == Color.Gold) { v14 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t14"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t15"] != System.DBNull.Value && numericUpDown15.BackColor == Color.Gold) { v15 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t15"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t16"] != System.DBNull.Value && numericUpDown16.BackColor == Color.Gold) { v16 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t16"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t17"] != System.DBNull.Value && numericUpDown17.BackColor == Color.Gold) { v17 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t17"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t18"] != System.DBNull.Value && numericUpDown18.BackColor == Color.Gold) { v18 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t18"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t19"] != System.DBNull.Value && numericUpDown19.BackColor == Color.Gold) { v19 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t19"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t20"] != System.DBNull.Value && numericUpDown20.BackColor == Color.Gold) { v20 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t20"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t21"] != System.DBNull.Value && numericUpDown21.BackColor == Color.Gold) { v21 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t21"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t22"] != System.DBNull.Value && numericUpDown22.BackColor == Color.Gold) { v22 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t22"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t23"] != System.DBNull.Value && numericUpDown23.BackColor == Color.Gold) { v23 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t23"]; }
            if (dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t24"] != System.DBNull.Value && numericUpDown24.BackColor == Color.Gold) { v24 = (decimal)dsAbnObjAct1.tG_MeasurementsOfCounters[0]["t24"]; }

            txtAverage.Text = ((v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8 + v9 + v10 + v11 + v12 + v13 + v14 + v15 + v16 + v17 + v18 + v19 + v20 + v21 + v22 + v23 + v24) / HourCount).ToString("0.0000");
            dsAbnObjAct1.tG_MeasurementsOfCounters[0]["AverageValue"] = txtAverage.Text;
        }

        // пересчет
        private void button1_Click(object sender, EventArgs e)
        {
            AverageValue();
        }

        // обновляем данные для объекта
        private void MeasurementsOfCountersToMeasurementsOfObject()
        {
            // добавить замеры к объекту которому принадлежит счетчик
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "MeasurementsOfCountersToMeasurementsOfObject";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@idObj", IDOBJ);
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@InputDate", dtMeasur.Value);
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

        // поменяем цвет фона у тех полей значения которых учитываются при расчете среднего значения
        private void MeasurementsHour()
        {
            if (dsAbnObjAct1.tG_MeasurementsHour.Rows.Count > 0)
            {
                HourCount = (int)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["HourCount"];
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h1"] == true)
                    numericUpDown1.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h2"] == true)
                    numericUpDown2.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h3"] == true)
                    numericUpDown3.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h4"] == true)
                    numericUpDown4.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h5"] == true)
                    numericUpDown5.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h6"] == true)
                    numericUpDown6.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h7"] == true)
                    numericUpDown7.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h8"] == true)
                    numericUpDown8.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h9"] == true)
                    numericUpDown9.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h10"] == true)
                    numericUpDown10.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h11"] == true)
                    numericUpDown11.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h12"] == true)
                    numericUpDown12.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h13"] == true)
                    numericUpDown13.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h14"] == true)
                    numericUpDown14.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h15"] == true)
                    numericUpDown15.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h16"] == true)
                    numericUpDown16.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h17"] == true)
                    numericUpDown17.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h18"] == true)
                    numericUpDown18.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h19"] == true)
                    numericUpDown19.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h20"] == true)
                    numericUpDown20.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h21"] == true)
                    numericUpDown21.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h22"] == true)
                    numericUpDown22.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h23"] == true)
                    numericUpDown23.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsAbnObjAct1.tG_MeasurementsHour.Rows[0]["h24"] == true)
                    numericUpDown24.BackColor = System.Drawing.Color.Gold;
            }
            else
            {
                HourCount = 0;
                numericUpDown1.BackColor = System.Drawing.Color.White;
                numericUpDown2.BackColor = System.Drawing.Color.White;
                numericUpDown3.BackColor = System.Drawing.Color.White;
                numericUpDown4.BackColor = System.Drawing.Color.White;
                numericUpDown5.BackColor = System.Drawing.Color.White;
                numericUpDown6.BackColor = System.Drawing.Color.White;
                numericUpDown7.BackColor = System.Drawing.Color.White;
                numericUpDown8.BackColor = System.Drawing.Color.White;
                numericUpDown9.BackColor = System.Drawing.Color.White;
                numericUpDown10.BackColor = System.Drawing.Color.White;
                numericUpDown11.BackColor = System.Drawing.Color.White;
                numericUpDown12.BackColor = System.Drawing.Color.White;
                numericUpDown13.BackColor = System.Drawing.Color.White;
                numericUpDown14.BackColor = System.Drawing.Color.White;
                numericUpDown15.BackColor = System.Drawing.Color.White;
                numericUpDown16.BackColor = System.Drawing.Color.White;
                numericUpDown17.BackColor = System.Drawing.Color.White;
                numericUpDown18.BackColor = System.Drawing.Color.White;
                numericUpDown19.BackColor = System.Drawing.Color.White;
                numericUpDown20.BackColor = System.Drawing.Color.White;
                numericUpDown21.BackColor = System.Drawing.Color.White;
                numericUpDown22.BackColor = System.Drawing.Color.White;
                numericUpDown23.BackColor = System.Drawing.Color.White;
                numericUpDown24.BackColor = System.Drawing.Color.White;
            }
        }

        // плановые часы пиковой нагрузки для новой даты
        private void dtMeasur_ValueChanged(object sender, EventArgs e)
        {
            MeasurementsHour();
        }

        private void FormMeasurementsOfCounters_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                System.Windows.Forms.SendKeys.Send("{TAB}");
            } 
        }
    }
}
