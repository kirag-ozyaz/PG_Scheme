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
    public partial class FormObjPower : FormLbr.FormBase
    {
        private int ID = -1;
        private int IDOBJ = -1;
        private bool isUpdate = false;
        private Single PowerSet;
        private int VolumSet;
        private int Regime;

        public FormObjPower()
        {
            InitializeComponent();
        }

        public FormObjPower(int idObj)
        {
            InitializeComponent();
            IDOBJ = idObj;
        }
        
        public FormObjPower(int id, int idObj, bool update)
        {
            InitializeComponent();
            ID = id;
            IDOBJ = idObj;
            isUpdate = update;
        }

        private void FormObjPower_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsObj1, dsObj1.tAbnObjReg, true, " where idAbnObj = " + IDOBJ.ToString() + " order by DateChange desc");
            if (dsObj1.tAbnObjReg.Count > 0)
            {
                // часы
                if (dsObj1.tAbnObjReg[0]["Regime"] != System.DBNull.Value)
                {
                    txtMode.Text = dsObj1.tAbnObjReg[0]["Regime"].ToString();
                    Regime = (int)dsObj1.tAbnObjReg[0]["Regime"];
                }
                else
                    Regime = 0;

                // мощность
                if (dsObj1.tAbnObjReg[0]["PowerSet"] != System.DBNull.Value)
                {
                    txtPower.Text = dsObj1.tAbnObjReg[0]["PowerSet"].ToString();
                    PowerSet = Convert.ToSingle(dsObj1.tAbnObjReg[0]["PowerSet"]);
                }
                else
                    PowerSet = 0;

                VolumSet = (int)(PowerSet * Regime);

            }
            if (isUpdate == false)
            {
                DataRow r = dsObj1.tG_ObjMax.NewRow();
                r["Year"] = System.DateTime.Today.Year.ToString();
                r["ObjID"] = IDOBJ;
                r["Month01"] = 0;
                r["Month02"] = 0;
                r["Month03"] = 0;
                r["Month04"] = 0;
                r["Month05"] = 0;
                r["Month06"] = 0;
                r["Month07"] = 0;
                r["Month08"] = 0;
                r["Month09"] = 0;
                r["Month10"] = 0;
                r["Month11"] = 0;
                r["Month12"] = 0;
                r["Volume01"] = 0;
                r["Volume02"] = 0;
                r["Volume03"] = 0;
                r["Volume04"] = 0;
                r["Volume05"] = 0;
                r["Volume06"] = 0;
                r["Volume07"] = 0;
                r["Volume08"] = 0;
                r["Volume09"] = 0;
                r["Volume10"] = 0;
                r["Volume11"] = 0;
                r["Volume12"] = 0;
                dsObj1.tG_ObjMax.Rows.Add(r);
            }
            else
                this.SelectSqlData(dsObj1, dsObj1.tG_ObjMax, true, " where ObjMaxID = " + ID.ToString());

            ChangeVolume();
            ChangePower();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (PowerValueCheck())
            {
                bool isOk = false;
                dsObj1.tG_ObjMax.Rows[0].EndEdit();
                if (isUpdate == false)
                {
                    ID = this.InsertSqlDataOneRow(dsObj1, dsObj1.tG_ObjMax);
                    if (ID < 0)
                        MessageBox.Show("Не удалось сохранить заявку");
                }
                else
                    isOk = this.UpdateSqlData(dsObj1, dsObj1.tG_ObjMax);
                if (isOk) this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Заявленное значение мощности(объема) не должно превышать " + PowerSet.ToString() + "(" + VolumSet.ToString() + ")" );
            }
        }

        private void ChangeVolume()
        {
            int v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12;
            v1 = 0; v2 = 0; v3 = 0; v4 = 0; v5 = 0; v6 = 0; v7 = 0; v8 = 0; v9 = 0; v10 = 0; v11 = 0; v12 = 0;
            if (dsObj1.tG_ObjMax[0]["Volume01"] != System.DBNull.Value) { v1 = (int)dsObj1.tG_ObjMax[0]["Volume01"]; }
            if (dsObj1.tG_ObjMax[0]["Volume02"] != System.DBNull.Value) { v2 = (int)dsObj1.tG_ObjMax[0]["Volume02"]; }
            if (dsObj1.tG_ObjMax[0]["Volume03"] != System.DBNull.Value) { v3 = (int)dsObj1.tG_ObjMax[0]["Volume03"]; }
            if (dsObj1.tG_ObjMax[0]["Volume04"] != System.DBNull.Value) { v4 = (int)dsObj1.tG_ObjMax[0]["Volume04"]; }
            if (dsObj1.tG_ObjMax[0]["Volume05"] != System.DBNull.Value) { v5 = (int)dsObj1.tG_ObjMax[0]["Volume05"]; }
            if (dsObj1.tG_ObjMax[0]["Volume06"] != System.DBNull.Value) { v6 = (int)dsObj1.tG_ObjMax[0]["Volume06"]; }
            if (dsObj1.tG_ObjMax[0]["Volume07"] != System.DBNull.Value) { v7 = (int)dsObj1.tG_ObjMax[0]["Volume07"]; }
            if (dsObj1.tG_ObjMax[0]["Volume08"] != System.DBNull.Value) { v8 = (int)dsObj1.tG_ObjMax[0]["Volume08"]; }
            if (dsObj1.tG_ObjMax[0]["Volume09"] != System.DBNull.Value) { v9 = (int)dsObj1.tG_ObjMax[0]["Volume09"]; }
            if (dsObj1.tG_ObjMax[0]["Volume10"] != System.DBNull.Value) { v10 = (int)dsObj1.tG_ObjMax[0]["Volume10"]; }
            if (dsObj1.tG_ObjMax[0]["Volume11"] != System.DBNull.Value) { v11 = (int)dsObj1.tG_ObjMax[0]["Volume11"]; }
            if (dsObj1.tG_ObjMax[0]["Volume12"] != System.DBNull.Value) { v12 = (int)dsObj1.tG_ObjMax[0]["Volume12"]; }

            txtVolumYear.Text = (v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8 + v9 + v10 + v11 + v12).ToString();
        }

        private void ChangePower()
        {
            decimal v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12;
            v1 = 0; v2 = 0; v3 = 0; v4 = 0; v5 = 0; v6 = 0; v7 = 0; v8 = 0; v9 = 0; v10 = 0; v11 = 0; v12 = 0;
            if (dsObj1.tG_ObjMax[0]["Month01"] != System.DBNull.Value) { v1 = (decimal)dsObj1.tG_ObjMax[0]["Month01"]; }
            if (dsObj1.tG_ObjMax[0]["Month02"] != System.DBNull.Value) { v2 = (decimal)dsObj1.tG_ObjMax[0]["Month02"]; }
            if (dsObj1.tG_ObjMax[0]["Month03"] != System.DBNull.Value) { v3 = (decimal)dsObj1.tG_ObjMax[0]["Month03"]; }
            if (dsObj1.tG_ObjMax[0]["Month04"] != System.DBNull.Value) { v4 = (decimal)dsObj1.tG_ObjMax[0]["Month04"]; }
            if (dsObj1.tG_ObjMax[0]["Month05"] != System.DBNull.Value) { v5 = (decimal)dsObj1.tG_ObjMax[0]["Month05"]; }
            if (dsObj1.tG_ObjMax[0]["Month06"] != System.DBNull.Value) { v6 = (decimal)dsObj1.tG_ObjMax[0]["Month06"]; }
            if (dsObj1.tG_ObjMax[0]["Month07"] != System.DBNull.Value) { v7 = (decimal)dsObj1.tG_ObjMax[0]["Month07"]; }
            if (dsObj1.tG_ObjMax[0]["Month08"] != System.DBNull.Value) { v8 = (decimal)dsObj1.tG_ObjMax[0]["Month08"]; }
            if (dsObj1.tG_ObjMax[0]["Month09"] != System.DBNull.Value) { v9 = (decimal)dsObj1.tG_ObjMax[0]["Month09"]; }
            if (dsObj1.tG_ObjMax[0]["Month10"] != System.DBNull.Value) { v10 = (decimal)dsObj1.tG_ObjMax[0]["Month10"]; }
            if (dsObj1.tG_ObjMax[0]["Month11"] != System.DBNull.Value) { v11 = (decimal)dsObj1.tG_ObjMax[0]["Month11"]; }
            if (dsObj1.tG_ObjMax[0]["Month12"] != System.DBNull.Value) { v12 = (decimal)dsObj1.tG_ObjMax[0]["Month12"]; }

            txtPowerAverage.Text = ((v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8 + v9 + v10 + v11 + v12) / 12).ToString("0.00");
        }

        private void textBox1Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46) 
               e.Handled = true; // Удаление символа 
        }

        private void textBox2Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true; // Удаление символа 
        }

        private void textBox3Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true; // Удаление символа 
        }

        private void textBox4Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true; // Удаление символа 
        }

        private void textBox5Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true; // Удаление символа 
        }

        private void textBox6Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true; // Удаление символа 
        }

        private void textBox7Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true; // Удаление символа 
        }

        private void textBox8Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true; // Удаление символа 
        }

        private void textBox9Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true; // Удаление символа 
        }

        private void textBox10Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true; // Удаление символа 
        }

        private void textBox11Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true; // Удаление символа 
        }

        private void textBox12Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true; // Удаление символа 
        }

        private void textBox1Volum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // Удаление символа 
        }

        private void textBox2Volum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // Удаление символа 
        }

        private void textBox3Volum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // Удаление символа 
        }

        private void textBox4Volum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // Удаление символа 
        }

        private void textBox5Volum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // Удаление символа 
        }

        private void textBox6Volum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // Удаление символа 
        }

        private void textBox7Volum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // Удаление символа 
        }

        private void textBox8Volum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // Удаление символа 
        }

        private void textBox9Volum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // Удаление символа 
        }

        private void textBox10Volum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // Удаление символа 
        }

        private void textBox11Volum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // Удаление символа 
        }

        private void textBox12Volum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // Удаление символа 
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            dsObj1.tG_ObjMax[0]["Volume01"] = (decimal)dsObj1.tG_ObjMax[0]["Month01"] * (int)dsObj1.tAbnObjReg[0]["Regime"];
            textBox1Volum.Text = dsObj1.tG_ObjMax[0]["Volume01"].ToString();

            dsObj1.tG_ObjMax[0]["Volume02"] = (decimal)dsObj1.tG_ObjMax[0]["Month02"] * (int)dsObj1.tAbnObjReg[0]["Regime"];
            textBox2Volum.Text = dsObj1.tG_ObjMax[0]["Volume02"].ToString();

            dsObj1.tG_ObjMax[0]["Volume03"] = (decimal)dsObj1.tG_ObjMax[0]["Month03"] * (int)dsObj1.tAbnObjReg[0]["Regime"];
            textBox3Volum.Text = dsObj1.tG_ObjMax[0]["Volume03"].ToString();

            dsObj1.tG_ObjMax[0]["Volume04"] = (decimal)dsObj1.tG_ObjMax[0]["Month04"] * (int)dsObj1.tAbnObjReg[0]["Regime"];
            textBox4Volum.Text = dsObj1.tG_ObjMax[0]["Volume04"].ToString();

            dsObj1.tG_ObjMax[0]["Volume05"] = (decimal)dsObj1.tG_ObjMax[0]["Month05"] * (int)dsObj1.tAbnObjReg[0]["Regime"];
            textBox5Volum.Text = dsObj1.tG_ObjMax[0]["Volume05"].ToString();

            dsObj1.tG_ObjMax[0]["Volume06"] = (decimal)dsObj1.tG_ObjMax[0]["Month06"] * (int)dsObj1.tAbnObjReg[0]["Regime"];
            textBox6Volum.Text = dsObj1.tG_ObjMax[0]["Volume06"].ToString();

            dsObj1.tG_ObjMax[0]["Volume07"] = (decimal)dsObj1.tG_ObjMax[0]["Month07"] * (int)dsObj1.tAbnObjReg[0]["Regime"];
            textBox7Volum.Text = dsObj1.tG_ObjMax[0]["Volume07"].ToString();

            dsObj1.tG_ObjMax[0]["Volume08"] = (decimal)dsObj1.tG_ObjMax[0]["Month08"] * (int)dsObj1.tAbnObjReg[0]["Regime"];
            textBox8Volum.Text = dsObj1.tG_ObjMax[0]["Volume08"].ToString();

            dsObj1.tG_ObjMax[0]["Volume09"] = (decimal)dsObj1.tG_ObjMax[0]["Month09"] * (int)dsObj1.tAbnObjReg[0]["Regime"];
            textBox9Volum.Text = dsObj1.tG_ObjMax[0]["Volume09"].ToString();

            dsObj1.tG_ObjMax[0]["Volume10"] = (decimal)dsObj1.tG_ObjMax[0]["Month10"] * (int)dsObj1.tAbnObjReg[0]["Regime"];
            textBox10Volum.Text = dsObj1.tG_ObjMax[0]["Volume10"].ToString();

            dsObj1.tG_ObjMax[0]["Volume11"] = (decimal)dsObj1.tG_ObjMax[0]["Month11"] * (int)dsObj1.tAbnObjReg[0]["Regime"];
            textBox11Volum.Text = dsObj1.tG_ObjMax[0]["Volume11"].ToString();

            dsObj1.tG_ObjMax[0]["Volume12"] = (decimal)dsObj1.tG_ObjMax[0]["Month12"] * (int)dsObj1.tAbnObjReg[0]["Regime"];
            textBox12Volum.Text = dsObj1.tG_ObjMax[0]["Volume12"].ToString();

        }

        private void btnCopyBack_Click(object sender, EventArgs e)
        {
            dsObj1.tG_ObjMax[0]["Month01"] = Math.Round(((int)dsObj1.tG_ObjMax[0]["Volume01"]) * 1.0 / ((int)dsObj1.tAbnObjReg[0]["Regime"]), 2);
            textBox1Power.Text = dsObj1.tG_ObjMax[0]["Month01"].ToString();

            dsObj1.tG_ObjMax[0]["Month02"] = Math.Round(((int)dsObj1.tG_ObjMax[0]["Volume02"]) * 1.0 / ((int)dsObj1.tAbnObjReg[0]["Regime"]), 2); 
            textBox2Power.Text = dsObj1.tG_ObjMax[0]["Month02"].ToString();

            dsObj1.tG_ObjMax[0]["Month03"] = Math.Round(((int)dsObj1.tG_ObjMax[0]["Volume03"]) * 1.0 / ((int)dsObj1.tAbnObjReg[0]["Regime"]), 2);
            textBox3Power.Text = dsObj1.tG_ObjMax[0]["Month03"].ToString();

            dsObj1.tG_ObjMax[0]["Month04"] = Math.Round(((int)dsObj1.tG_ObjMax[0]["Volume04"]) * 1.0 / ((int)dsObj1.tAbnObjReg[0]["Regime"]), 2);
            textBox4Power.Text = dsObj1.tG_ObjMax[0]["Month04"].ToString();

            dsObj1.tG_ObjMax[0]["Month05"] = Math.Round(((int)dsObj1.tG_ObjMax[0]["Volume05"]) * 1.0 / ((int)dsObj1.tAbnObjReg[0]["Regime"]), 2);
            textBox5Power.Text = dsObj1.tG_ObjMax[0]["Month05"].ToString();

            dsObj1.tG_ObjMax[0]["Month06"] = Math.Round(((int)dsObj1.tG_ObjMax[0]["Volume06"]) * 1.0 / ((int)dsObj1.tAbnObjReg[0]["Regime"]), 2);
            textBox6Power.Text = dsObj1.tG_ObjMax[0]["Month06"].ToString();

            dsObj1.tG_ObjMax[0]["Month07"] = Math.Round(((int)dsObj1.tG_ObjMax[0]["Volume07"]) * 1.0 / ((int)dsObj1.tAbnObjReg[0]["Regime"]), 2);
            textBox7Power.Text = dsObj1.tG_ObjMax[0]["Month07"].ToString();

            dsObj1.tG_ObjMax[0]["Month08"] = Math.Round(((int)dsObj1.tG_ObjMax[0]["Volume08"]) * 1.0 / ((int)dsObj1.tAbnObjReg[0]["Regime"]), 2);
            textBox8Power.Text = dsObj1.tG_ObjMax[0]["Month08"].ToString();

            dsObj1.tG_ObjMax[0]["Month09"] = Math.Round(((int)dsObj1.tG_ObjMax[0]["Volume09"]) * 1.0 / ((int)dsObj1.tAbnObjReg[0]["Regime"]), 2);
            textBox9Power.Text = dsObj1.tG_ObjMax[0]["Month09"].ToString();

            dsObj1.tG_ObjMax[0]["Month10"] = Math.Round(((int)dsObj1.tG_ObjMax[0]["Volume10"]) * 1.0 / ((int)dsObj1.tAbnObjReg[0]["Regime"]), 2);
            textBox10Power.Text = dsObj1.tG_ObjMax[0]["Month10"].ToString();

            dsObj1.tG_ObjMax[0]["Month11"] = Math.Round(((int)dsObj1.tG_ObjMax[0]["Volume11"]) * 1.0 / ((int)dsObj1.tAbnObjReg[0]["Regime"]), 2);
            textBox11Power.Text = dsObj1.tG_ObjMax[0]["Month11"].ToString();

            dsObj1.tG_ObjMax[0]["Month12"] = Math.Round(((int)dsObj1.tG_ObjMax[0]["Volume12"]) * 1.0 / ((int)dsObj1.tAbnObjReg[0]["Regime"]), 2);
            textBox12Power.Text = dsObj1.tG_ObjMax[0]["Month12"].ToString();
        }

        private bool PowerValueCheck()
        {
            if (Convert.ToSingle(dsObj1.tG_ObjMax[0]["Month01"]) > PowerSet)
                return false;
            if (Convert.ToSingle(dsObj1.tG_ObjMax[0]["Month02"]) > PowerSet)
                return false;
            if (Convert.ToSingle(dsObj1.tG_ObjMax[0]["Month03"]) > PowerSet)
                return false;
            if (Convert.ToSingle(dsObj1.tG_ObjMax[0]["Month04"]) > PowerSet)
                return false;
            if (Convert.ToSingle(dsObj1.tG_ObjMax[0]["Month05"]) > PowerSet)
                return false;
            if (Convert.ToSingle(dsObj1.tG_ObjMax[0]["Month06"]) > PowerSet)
                return false;
            if (Convert.ToSingle(dsObj1.tG_ObjMax[0]["Month07"]) > PowerSet)
                return false;
            if (Convert.ToSingle(dsObj1.tG_ObjMax[0]["Month08"]) > PowerSet)
                return false;
            if (Convert.ToSingle(dsObj1.tG_ObjMax[0]["Month09"]) > PowerSet)
                return false;
            if (Convert.ToSingle(dsObj1.tG_ObjMax[0]["Month10"]) > PowerSet)
                return false;
            if (Convert.ToSingle(dsObj1.tG_ObjMax[0]["Month11"]) > PowerSet)
                return false;
            if (Convert.ToSingle(dsObj1.tG_ObjMax[0]["Month12"]) > PowerSet)
                return false;
            if ((int)dsObj1.tG_ObjMax[0]["Volume01"] > VolumSet)
                return false;
            if ((int)dsObj1.tG_ObjMax[0]["Volume02"] > VolumSet)
                return false;
            if ((int)dsObj1.tG_ObjMax[0]["Volume03"] > VolumSet)
                return false;
            if ((int)dsObj1.tG_ObjMax[0]["Volume04"] > VolumSet)
                return false;
            if ((int)dsObj1.tG_ObjMax[0]["Volume05"] > VolumSet)
                return false;
            if ((int)dsObj1.tG_ObjMax[0]["Volume06"] > VolumSet)
                return false;
            if ((int)dsObj1.tG_ObjMax[0]["Volume07"] > VolumSet)
                return false;
            if ((int)dsObj1.tG_ObjMax[0]["Volume08"] > VolumSet)
                return false;
            if ((int)dsObj1.tG_ObjMax[0]["Volume09"] > VolumSet)
                return false;
            if ((int)dsObj1.tG_ObjMax[0]["Volume10"] > VolumSet)
                return false;
            if ((int)dsObj1.tG_ObjMax[0]["Volume11"] > VolumSet)
                return false;
            if ((int)dsObj1.tG_ObjMax[0]["Volume12"] > VolumSet)
                return false;

            return true;
        }

    }
}
