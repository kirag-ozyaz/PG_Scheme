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
    public partial class FormCntValMeter : FormLbr.FormBase
    {
        public decimal valMetering;
        public int valSize;
        private int IDOBJ = -1;
        private DateTime DATE;
        private int FLAGEDIT;
        private int IDFIND = -1;

        public FormCntValMeter()
        {
            InitializeComponent();
        }

        public FormCntValMeter(int id, DateTime dt, int FlagEdit, int idFind)
        {
            InitializeComponent();
            IDOBJ = id;
            DATE = dt;
            FLAGEDIT = FlagEdit;
            IDFIND = idFind;
            if (FlagEdit == 1)
            {
                tsbQuit.Enabled = true;
                tsbEnter.Enabled = true;
            }
            else
            {
                tsbQuit.Enabled = false;
                tsbEnter.Enabled = false;
            }
        }

        private void FormCntValMeter_Load(object sender, EventArgs e)
        {
            SelectSqlData(dsCntVal1, dsCntVal1.tAbnObj, true, "where id = " + IDOBJ.ToString());
            this.Text = "Ввод показаний приборов учета по объекту  '" + dsCntVal1.tAbnObj[0]["Name"] + "'";
            cbMeter.ComboBox.SelectedIndex = 0;
            dgvCnt_Load();
            dgvMeterVal_Load();
        }

        // загрузка всех показаний по счетчику в правый грид
        private void dgvMeterVal_Load()
        {
            dsCntVal1.tMeterValAll.Clear();
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "select * from fn_LegGetCntAll(@idAbnObj) ";
                strCmd += " order by MeterID, DateAct desc ";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                int idAbnObj = IDOBJ;
                SqlParameter p1 = new SqlParameter("@idAbnObj", idAbnObj);
                sqlCmd.Parameters.Add(p1);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCntVal1, "tMeterValAll");

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

        // загрузка всех счетчиков с текущими показаниями в левый грид
        private void dgvCnt_Load()
        {
            dsCntVal1.tMeterVal.Clear();
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "select * from fn_LegGetCnt2(@idAbnObj, @Date, @CntActive) ";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                int idAbnObj = IDOBJ;
                SqlParameter p1 = new SqlParameter("@idAbnObj", idAbnObj);
                sqlCmd.Parameters.Add(p1);

                DateTime Date = DATE;
                SqlParameter p2 = new SqlParameter("@Date", Date.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p2);

                int CntActive = Convert.ToInt32(cbMeter.SelectedIndex);
                SqlParameter p3 = new SqlParameter("@CntActive", CntActive);
                sqlCmd.Parameters.Add(p3);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCntVal1, "tMeterVal");

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

        // ввод показаний счетчика
        private void tsbEnter_Click(object sender, EventArgs e)
        {
            if (cbMeter.SelectedIndex > 0)
            {
                MessageBox.Show("Ввод начислений возможен только в режиме <действующие счетчики>");
                return;
            }


            if (dgvCnt.Rows.Count > 0)
            {
                // существующее показание
                decimal id = -1;
                if (dgvCnt.CurrentRow.Cells["currValue_dgv"].Value == DBNull.Value)
                {
                    id = 0;
                    // проверим не введено ли показание у связанного счетчика
                    if (IDFIND > 0)
                    {
                        id = LegCntGet_Same();
                    }
                }
                else
                    id = Convert.ToDecimal(dgvCnt.CurrentRow.Cells["currValue_dgv"].Value);



                FormMeterEnter f = new FormMeterEnter(id);
                f.Owner = this;
                f.SqlSettings = this.SqlSettings;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // показание счетчика не введено
                    if (valMetering == -1)
                    {
                        dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrValue"] = System.DBNull.Value;
                        if (valSize == -1)
                            dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrSize"] = System.DBNull.Value;
                        else
                            // расход введен вручную
                            dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrSize"] = valSize;
                    }
                    // показание счетчика введено
                    else
                    {
                        // если расход не введен, найдем его сами по разности показаний
                        if (valSize == -1) 
                        {
                            decimal PrevValue = -1;
                            if (dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["PrevValue"] == DBNull.Value)
                                PrevValue = 0;
                            else
                                PrevValue = Convert.ToDecimal(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["PrevValue"].ToString());

                            decimal CurrValue = -1;
                            if (dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrValue"] == DBNull.Value)
                                CurrValue = 0;
                            else
                                CurrValue = Convert.ToDecimal(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrValue"].ToString());

                            int Digit = -1;
                            if (dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["Digit"] == DBNull.Value)
                                Digit = 0;
                            else
                                Digit = Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["Digit"].ToString()); 

                            int TrK = -1;
                            if (dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["Tr_K"] == DBNull.Value)
                                TrK = 0;
                            else
                                TrK = Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["Tr_K"].ToString());

                            if (Convert.ToInt32(valMetering).ToString().Length > Digit)
                                MessageBox.Show("Разрядность счетчика меньше введеного значения.Измените тип счетчика или проверьте показания.");
                            if (valMetering != CurrValue)
                            {
                                // разность показаний
                                decimal delta = valMetering - PrevValue;
                                // проверяем не начал ли счетчик новый отсчет
                                if (delta < 0)
                                {
                                    if (Digit != 0)
                                    {
                                        int multipler = 1;
                                        for (int x = 1; x <= Digit; x++)
                                            multipler = multipler * 10;
                                        delta = (multipler - PrevValue) + valMetering;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Введите разрядность счетчика");
                                        return;
                                    }
                                }
                                dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrValue"] = valMetering; // текущее показание
                                // умножаем на коэффициент трансформации
                                if (TrK != 0)
                                    delta = delta * TrK;
                                dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrSize"] = Convert.ToInt32(Math.Round(delta,0,MidpointRounding.AwayFromZero)); // текущий расход

                                // если есть потери увеличим начисление
                                float KLOSS;
                                KLOSS = Convert.ToSingle(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["Kloss"]);
                                if (KLOSS != 0)
                                    {
                                        int loss = Convert.ToInt32((Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrSize"]) * KLOSS / 100));  
                                        dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrSize"] = Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrSize"]) + loss;
                                    }

                                // если есть дополнительные потери добавим их
                                if ((int)dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["KLossMonth"] != 0)
                                {
                                    dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrSize"] = Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrSize"]) + Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["KLossMonth"]);
                                }

                            }
                        }
                        // расход и показания введены
                        else
                        {
                            dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrValue"] = valMetering;
                            dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrSize"] = valSize;
                        }
                    }
                    // записываем данные на сервер
                    LegCntSet();
                    dgvMeterVal_Load();
                }
            }
        }

        // обработка нажатий клавиш
        private void dgvCnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter: // ввод показаний
                        if (tsbEnter.Visible)
                            tsbEnter.PerformClick();
                        break;
                    case Keys.Escape : // выход без записи
                        if (tsbQuit.Visible)
                            SaveQuit();
                        break;
                    case Keys.F12: // // безучетное
                        if (tsbEnter.Visible && (dgvCnt.Rows.Count > 0))
                        {   
                            UnMetered();
                            dgvMeterVal_Load();
                        }
                        break;
                    default: break;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter && (e.Modifiers & Keys.Control) == Keys.Control)
                {
                    if (tsbQuit.Visible)
                        SaveQuit();
                }
            }
        }

        // запись рассчитанных значений на сервер
        private void LegCntSet()
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "sp_LegCntSet1";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                int PointID = Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["PointID"].ToString());
                SqlParameter p1 = new SqlParameter("@idPoint", PointID);
                sqlCmd.Parameters.Add(p1);

                int MeterID = Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["MeterID"].ToString());
                SqlParameter p2 = new SqlParameter("@idPointReg", MeterID);
                sqlCmd.Parameters.Add(p2);

                int idZone = Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["idZone"].ToString());
                SqlParameter p3 = new SqlParameter("@idZone", idZone);
                sqlCmd.Parameters.Add(p3);

                DateTime Date = DATE;
                SqlParameter p4 = new SqlParameter("@DateAct", Date.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p4);

                if (dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrValue"] != System.DBNull.Value)
                {
                    decimal CurrValue = Convert.ToDecimal(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrValue"].ToString());
                    SqlParameter p5 = new SqlParameter("@Value", CurrValue);
                    sqlCmd.Parameters.Add(p5);
                }

                if (dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrSize"] != System.DBNull.Value)
                {
                    int CurrSize = Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["CurrSize"].ToString());
                    SqlParameter p6 = new SqlParameter("@Size", CurrSize);
                    sqlCmd.Parameters.Add(p6);
                }

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

        // возврат к объектам
        private void tsbQuit_Click(object sender, EventArgs e)
        {
            SaveQuit();
        }

        private void cbMeter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvCnt.Rows.Count > 0)
            {
                dgvCnt_Load();
                dgvCnt.Focus();
            }
        }

        private void tsbPrintMeterData_Click(object sender, EventArgs e)
        {
            int MeterID = Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["MeterID"].ToString());
            Legal.Forms.FormRep.FormMeterData frm = new Legal.Forms.FormRep.FormMeterData(MeterID);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private List<int> currSize = new List<int>();
        public List<int> CurrSize
        {
            get { return currSize; }
        }

        private List<int> unmeteredSize = new List<int>();
        public List<int> UnmeteredSize
        {
            get { return unmeteredSize; }
        }

        private void SaveQuit()
        {
//            FLAGEDIT = 1;
            if (FLAGEDIT == 1)
            {
                if (dgvCnt.Rows.Count > 0)
                {
                    // суммируем Size по всем счетчикам
                    int SumSize = 0;
                    currSize.Clear();
                    for (int curRow = 0; curRow < dsCntVal1.tMeterVal.Rows.Count; curRow++)
                    {
                        int Size = -1;
                        if (dsCntVal1.tMeterVal[curRow]["CurrSize"] == DBNull.Value)
                            Size = 0;
                        else
                            Size = Convert.ToInt32(dsCntVal1.tMeterVal[curRow]["CurrSize"].ToString());
                        currSize.Add(Size);
                        SumSize += Size;

                        int vMeterID = Convert.ToInt32(dsCntVal1.tMeterVal[curRow]["MeterID"]);
                        int vidZone = Convert.ToInt32(dsCntVal1.tMeterVal[curRow]["idZone"]);
                        DataRow[] sortData = dsCntVal1.tMeterValAll.Select("MeterID = " + vMeterID + " and idZone = " + vidZone, "DateAct desc");
                        if (sortData.Length > 0)
                        {
                            if (sortData[0]["DocType"].ToString() == "Безучетное потребление")
                                unmeteredSize.Add(Size);
                        }
                    }
                    FormCntVal frm = (FormCntVal)this.Owner;
                    frm.valQuantity = SumSize;
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
                this.DialogResult = DialogResult.No;
            this.Close();
        }

        private int LegCntGet_Same()
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "LegGetCnt_Same";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@idAbnObj", IDFIND);
                sqlCmd.Parameters.Add(p1);

                string cnt_number = dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["Number"].ToString();
                SqlParameter p2 = new SqlParameter("@Number", cnt_number);
                sqlCmd.Parameters.Add(p2);

                DateTime DateAct = DATE;
                SqlParameter p3 = new SqlParameter("@DateAct", DateAct.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p3);

                int outvar = 0;
                SqlParameter p4 = new SqlParameter("@outvar", outvar);
                p4.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(p4);

                sqlCmd.UpdatedRowSource = UpdateRowSource.OutputParameters;
                sqlCmd.CommandTimeout = 0;
                sqlCmd.ExecuteNonQuery();
                outvar = (int)sqlCmd.Parameters["@outvar"].Value;
                return outvar;
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

        private int LegCntGet_LastYear()
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "LegGetCnt_LastYear";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter("@idAbnObj", IDFIND);
                sqlCmd.Parameters.Add(p1);

                string cnt_number = dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["Number"].ToString();
                SqlParameter p2 = new SqlParameter("@Number", cnt_number);
                sqlCmd.Parameters.Add(p2);

                DateTime DateAct = DATE;
                SqlParameter p3 = new SqlParameter("@DateAct", DateAct.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p3);

                int outvar = 0;
                SqlParameter p4 = new SqlParameter("@outvar", outvar);
                p4.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(p4);

                sqlCmd.UpdatedRowSource = UpdateRowSource.OutputParameters;
                sqlCmd.CommandTimeout = 0;
                sqlCmd.ExecuteNonQuery();
                outvar = (int)sqlCmd.Parameters["@outvar"].Value;
                return outvar;
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

        private void dgvCnt_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgvCnt.RowCount)
            {
                if ((dgvCnt.Rows[e.RowIndex].Cells["KLoss"].Value.ToString() != "0") | (dgvCnt.Rows[e.RowIndex].Cells["KLossMonth"].Value.ToString() != "0"))
                    ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                if (dgvCnt.Rows[e.RowIndex].Cells["ActComment"].Value.ToString().IndexOf("~") == 0)
                    txtComment.BackColor = Color.LightYellow;
            }
        }

        // отметим что это безучетное потребление
        private void UnMetered()
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "sp_UnMeteredSet_2";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                int PointID = Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["PointID"].ToString());
                SqlParameter p1 = new SqlParameter("@idPoint", PointID);
                sqlCmd.Parameters.Add(p1);

                int MeterID = Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["MeterID"].ToString());
                SqlParameter p2 = new SqlParameter("@idPointReg", MeterID);
                sqlCmd.Parameters.Add(p2);

                int idZone = Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["idZone"].ToString());
                SqlParameter p3 = new SqlParameter("@idZone", idZone);
                sqlCmd.Parameters.Add(p3);

                DateTime Date = DATE;
                SqlParameter p4 = new SqlParameter("@DateAct", Date.ToString("yyyyMMdd"));
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

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            int PointID = Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["PointID"].ToString());
            int MeterID = Convert.ToInt32(dsCntVal1.tMeterVal[dgvCnt.CurrentRow.Index]["MeterID"].ToString());

            Legal.Forms.Meter.FormMeter_Log frm = new Legal.Forms.Meter.FormMeter_Log(PointID, MeterID, DATE);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

    }   
}
