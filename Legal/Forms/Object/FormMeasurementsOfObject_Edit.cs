using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Legal.Forms.Object
{
    public partial class FormMeasurementsOfObject_Edit : FormLbr.FormBase
    {
        private int ID = -1;
        private int IDOBJ = -1;
        private bool isUpdate = false;
        // количество плановых часов
        private int HourCount = 0;

        public FormMeasurementsOfObject_Edit()
        {
            InitializeComponent();
        }

        // специальный конструктор
        public FormMeasurementsOfObject_Edit(int par, bool update)
        {
            InitializeComponent();
            if (update == false)
            {
                IDOBJ = par;
            }
            else
            {
                ID = par;
            }
            isUpdate = update;
        }

        // загрузка
        private void FormMeasurementsOfObject_Edit_Load(object sender, EventArgs e)
        {

            if (isUpdate == false)
            {

                DataRow r = dsObj1.tG_MeasurementsOfObject.NewRow();

                // берем последний режимный день
                this.SelectSqlData(dsObj1, dsObj1.tG_MeasurementsHour, true, "order by YearValue, MonthValue desc");
                int yy = (int)dsObj1.tG_MeasurementsHour[0]["YearValue"];
                int mm = (int)dsObj1.tG_MeasurementsHour[0]["MonthValue"];
                int dd = (int)dsObj1.tG_MeasurementsHour[0]["MeasurementsDay"];

                r["idObj"] = IDOBJ;
                r["DateOfIntroduction"] = new DateTime(yy, mm, dd);
                r["t1"] = 0; r["t2"] = 0; r["t3"] = 0; r["t4"] = 0; r["t5"] = 0; r["t6"] = 0; r["t7"] = 0; r["t8"] = 0;
                r["t9"] = 0; r["t10"] = 0; r["t11"] = 0; r["t12"] = 0; r["t13"] = 0; r["t14"] = 0; r["t15"] = 0; r["t16"] = 0;
                r["t17"] = 0; r["t18"] = 0; r["t19"] = 0; r["t20"] = 0; r["t21"] = 0; r["t22"] = 0; r["t23"] = 0; r["t24"] = 0;
                dsObj1.tG_MeasurementsOfObject.Rows.Add(r);
                this.Text = "Новые замеры";
            }
            else
            {
                // находим часы исходя из известного режимного дня

                this.SelectSqlData(dsObj1, dsObj1.tG_MeasurementsOfObject, true, " where id = " + ID.ToString());

                int yy = ((DateTime)dsObj1.tG_MeasurementsOfObject[0]["DateOfIntroduction"]).Year;
                int mm = ((DateTime)dsObj1.tG_MeasurementsOfObject[0]["DateOfIntroduction"]).Month;
                int dd = ((DateTime)dsObj1.tG_MeasurementsOfObject[0]["DateOfIntroduction"]).Day;

                this.SelectSqlData(dsObj1, dsObj1.tG_MeasurementsHour, true, "where YearValue = " + yy + " and MonthValue = " + mm + " and MeasurementsDay = " + dd);

                this.Text = "Редактирование замеров";
            }

            MeasurementsHour();
        }

        // сохраняем данные
        private void btnOK_Click(object sender, EventArgs e)
        {
            AverageValue();
            bool isOk = false;
            dsObj1.tG_MeasurementsOfObject.Rows[0].EndEdit();
            if (isUpdate == false)
            {
                ID = this.InsertSqlDataOneRow(dsObj1, dsObj1.tG_MeasurementsOfObject);
                if (ID < 0)
                    MessageBox.Show("Не удалось сохранить замеры");
            }
            else
                isOk = this.UpdateSqlData(dsObj1, dsObj1.tG_MeasurementsOfObject);
            if (isOk) this.DialogResult = DialogResult.OK;
            Close();
        }

        // находим среднее значение
        private void AverageValue()
        {
            decimal v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24;
            v1 = 0; v2 = 0; v3 = 0; v4 = 0; v5 = 0; v6 = 0; v7 = 0; v8 = 0; v9 = 0; v10 = 0; v11 = 0; v12 = 0;
            v13 = 0; v14 = 0; v15 = 0; v16 = 0; v17 = 0; v18 = 0; v19 = 0; v20 = 0; v21 = 0; v22 = 0; v23 = 0; v24 = 0;

            if (dsObj1.tG_MeasurementsOfObject[0]["t1"] != System.DBNull.Value && txt1.BackColor == Color.Gold) { v1 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t1"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t2"] != System.DBNull.Value && txt2.BackColor == Color.Gold) { v2 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t2"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t3"] != System.DBNull.Value && txt3.BackColor == Color.Gold) { v3 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t3"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t4"] != System.DBNull.Value && txt4.BackColor == Color.Gold) { v4 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t4"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t5"] != System.DBNull.Value && txt5.BackColor == Color.Gold) { v5 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t5"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t6"] != System.DBNull.Value && txt6.BackColor == Color.Gold) { v6 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t6"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t7"] != System.DBNull.Value && txt7.BackColor == Color.Gold) { v7 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t7"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t8"] != System.DBNull.Value && txt8.BackColor == Color.Gold) { v8 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t8"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t9"] != System.DBNull.Value && txt9.BackColor == Color.Gold) { v9 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t9"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t10"] != System.DBNull.Value && txt10.BackColor == Color.Gold) { v10 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t10"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t11"] != System.DBNull.Value && txt11.BackColor == Color.Gold) { v11 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t11"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t12"] != System.DBNull.Value && txt12.BackColor == Color.Gold) { v12 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t12"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t13"] != System.DBNull.Value && txt13.BackColor == Color.Gold) { v13 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t13"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t14"] != System.DBNull.Value && txt14.BackColor == Color.Gold) { v14 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t14"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t15"] != System.DBNull.Value && txt15.BackColor == Color.Gold) { v15 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t15"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t16"] != System.DBNull.Value && txt16.BackColor == Color.Gold) { v16 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t16"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t17"] != System.DBNull.Value && txt17.BackColor == Color.Gold) { v17 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t17"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t18"] != System.DBNull.Value && txt18.BackColor == Color.Gold) { v18 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t18"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t19"] != System.DBNull.Value && txt19.BackColor == Color.Gold) { v19 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t19"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t20"] != System.DBNull.Value && txt20.BackColor == Color.Gold) { v20 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t20"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t21"] != System.DBNull.Value && txt21.BackColor == Color.Gold) { v21 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t21"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t22"] != System.DBNull.Value && txt22.BackColor == Color.Gold) { v22 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t22"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t23"] != System.DBNull.Value && txt23.BackColor == Color.Gold) { v23 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t23"]; }
            if (dsObj1.tG_MeasurementsOfObject[0]["t24"] != System.DBNull.Value && txt24.BackColor == Color.Gold) { v24 = (decimal)dsObj1.tG_MeasurementsOfObject[0]["t24"]; }

            txtAverage.Text = ((v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8 + v9 + v10 + v11 + v12 + v13 + v14 + v15 + v16 + v17 + v18 + v19 + v20 + v21 + v22 + v23 + v24) / HourCount).ToString("0.0000");
            dsObj1.tG_MeasurementsOfObject[0]["AverageValue"] = txtAverage.Text;
        }

        // пересчет
        private void button1_Click(object sender, EventArgs e)
        {
            AverageValue();
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true; // Удаление символа 
                TextBox textBox = sender as TextBox;
                this.SelectNextControl(textBox, true, true, true, true);
            }
        }

        // поменяем цвет фона у тех полей значения которых учитываются при расчете среднего значения
        private void MeasurementsHour()
        {
            if (dsObj1.tG_MeasurementsHour.Rows.Count > 0)
            {
                HourCount = (int)dsObj1.tG_MeasurementsHour.Rows[0]["HourCount"];
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h1"] == true)
                    txt1.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h2"] == true)
                    txt2.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h3"] == true)
                    txt3.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h4"] == true)
                    txt4.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h5"] == true)
                    txt5.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h6"] == true)
                    txt6.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h7"] == true)
                    txt7.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h8"] == true)
                    txt8.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h9"] == true)
                    txt9.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h10"] == true)
                    txt10.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h11"] == true)
                    txt11.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h12"] == true)
                    txt12.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h13"] == true)
                    txt13.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h14"] == true)
                    txt14.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h15"] == true)
                    txt15.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h16"] == true)
                    txt16.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h17"] == true)
                    txt17.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h18"] == true)
                    txt18.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h19"] == true)
                    txt19.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h20"] == true)
                    txt20.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h21"] == true)
                    txt21.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h22"] == true)
                    txt22.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h23"] == true)
                    txt23.BackColor = System.Drawing.Color.Gold;
                if ((bool)dsObj1.tG_MeasurementsHour.Rows[0]["h24"] == true)
                    txt24.BackColor = System.Drawing.Color.Gold;
            }
            else
            {
                HourCount = 0;
                txt1.BackColor = System.Drawing.Color.White;
                txt2.BackColor = System.Drawing.Color.White;
                txt3.BackColor = System.Drawing.Color.White;
                txt4.BackColor = System.Drawing.Color.White;
                txt5.BackColor = System.Drawing.Color.White;
                txt6.BackColor = System.Drawing.Color.White;
                txt7.BackColor = System.Drawing.Color.White;
                txt8.BackColor = System.Drawing.Color.White;
                txt9.BackColor = System.Drawing.Color.White;
                txt10.BackColor = System.Drawing.Color.White;
                txt11.BackColor = System.Drawing.Color.White;
                txt12.BackColor = System.Drawing.Color.White;
                txt13.BackColor = System.Drawing.Color.White;
                txt14.BackColor = System.Drawing.Color.White;
                txt15.BackColor = System.Drawing.Color.White;
                txt16.BackColor = System.Drawing.Color.White;
                txt17.BackColor = System.Drawing.Color.White;
                txt18.BackColor = System.Drawing.Color.White;
                txt19.BackColor = System.Drawing.Color.White;
                txt20.BackColor = System.Drawing.Color.White;
                txt21.BackColor = System.Drawing.Color.White;
                txt22.BackColor = System.Drawing.Color.White;
                txt23.BackColor = System.Drawing.Color.White;
                txt24.BackColor = System.Drawing.Color.White;
            }
        }

        // плановые часы пиковой нагрузки для новой даты
        private void dtMeasur_ValueChanged(object sender, EventArgs e)
        {
            MeasurementsHour();
        }


    }
}
