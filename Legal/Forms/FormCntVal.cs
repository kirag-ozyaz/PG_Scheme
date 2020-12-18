using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace Legal.Forms
{
    public partial class FormCntVal : FormLbr.FormBase
    {
        private int ABNID = -1;
        public int valQuantity;
        private int CurQuantity;
        private int MinQuantity;
        private int MaxQuantity;
        private int PrevQuantity;
        private int FlagMeterValEdit;
        public int ABNSELECT;
        public int PercentMinus;
        public int PercentPlus;
        public int CountMonth;
        private string CODE = "";
        private DialogResult result;
        private DateTime CalcDate;
        private string Dogovor_Type;
        public int IDTARIFF;
        public decimal TARIFFVALUE;
        private decimal Tax;

        // 21.01.2019
        private decimal Tax20;
        private DateTime TaxDate;

        public int OBJSELECT;

        public FormCntVal()
        {
            InitializeComponent();
            this.KeyPreview = true;
            Tax = (decimal)(Constants.Constants.TaxRate18 / 100.0);
            // 21.01.2019
            Tax20 = (decimal)(Constants.Constants.TaxRate20 / 100.0);
            TaxDate = new DateTime(2019,1,1);
        }

        public FormCntVal(int idAbn)
        {
            InitializeComponent();
            ABNID = idAbn;
            this.KeyPreview = true;
            PercentMinus = 50;
            PercentPlus = 100;
            CountMonth = 12;
            Tax = (decimal)(Constants.Constants.TaxRate18 / 100.0);
            // 21.01.2019
            Tax20 = (decimal)(Constants.Constants.TaxRate20 / 100.0);
        }

        // загрузка начальных данных
        private void FormCntVal_Load(object sender, EventArgs e)
        {
            // начальные установки
            cbCode.SelectedIndex = 0;
            SelectSqlData(dsCntVal1, dsCntVal1.tG_PeriodCalc, true);
            cbMonth.SelectedIndex = (Int32)dsCntVal1.tG_PeriodCalc[0]["MonthCalc"] - 1;
            сbYear.Text = dsCntVal1.tG_PeriodCalc[0]["YearCalc"].ToString();
            if (cbMonth.SelectedIndex < 9)
                CalcDate = Convert.ToDateTime("01." + "0" + (cbMonth.SelectedIndex + 1) + "." + сbYear.Text);
            else
                CalcDate = Convert.ToDateTime("01." + (cbMonth.SelectedIndex + 1) + "." + сbYear.Text);
            // дата документа для текущего расчета - последний день периода
            CalcDate = CalcDate.AddMonths(1).AddDays(-1);

            SelectSqlData(dsCntVal1.tAbn, true, " where TypeAbn in (" + Constants.Constants.TypeAbnLegal + "," + 
                Constants.Constants.TypeAbnNet + "," + Constants.Constants.TypeAbnSale + ") and deleted = 0 and CodeAbonent > 0 order by CodeAbonent");
            ABNID = Convert.ToInt32(dsCntVal1.tAbn[0]["id"]);
            tbCode.Text = dsCntVal1.tAbn[0]["CodeAbonent"].ToString();
            tbName.Text = dsCntVal1.tAbn[0]["Name"].ToString();

            cbDogovor_Load();
            cbTypeEnergy_Load();
            cbObj.ComboBox.SelectedIndex = 0;
            cbCheckVisual.ComboBox.SelectedIndex = 1;

            dgvAbnLoad();
            this.ActiveControl = tbCode.Control;
        }

        // загружаем все документы по выбранному абоненту и договору
        private void dgvAbnLoad()
        {
            int idDog = -1;
            idDog = Convert.ToInt32(cbDogovor.ComboBox.SelectedValue);
            SelectSqlData(dsCntVal1.tG_Doc, true, " where idAbn = " + ABNID + " and idDogovor = " + idDog + " order by dtPay desc", null, true);
            SelectSqlData(dsCntVal1.tAbnDoc_Dogovor, true, " where idList = " + idDog);

            if (dsCntVal1.tAbnDoc_Dogovor.Rows.Count > 0)
                txtDogComment.Text = dsCntVal1.tAbnDoc_Dogovor.Rows[0]["Comment"].ToString();
            dgvObjLoad();
        }

        // загружаем объекты с начислениями по выбранному документу
        private void dgvObjLoad()
        {
            if (dgvAbn.Rows.Count > 0)
            {

                if (dgvObj.Rows.Count > 0)
                    dsCntVal1.tG_DocSchetTemp.Clear();

                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);

                    string strCmd = "";
                    strCmd = "select * from fn_LegGetObj2(@idDogovor, @ObjActive, @idDocum) ";
                    strCmd += " order by NumberObj, NumberSubObj ";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                    int DogID = Convert.ToInt32(cbDogovor.ComboBox.SelectedValue);
                    SqlParameter p1 = new SqlParameter("@idDogovor", DogID);
                    sqlCmd.Parameters.Add(p1);

                    int ObjActive = Convert.ToInt32(cbObj.SelectedIndex);
                    SqlParameter p2 = new SqlParameter("@ObjActive", ObjActive);
                    sqlCmd.Parameters.Add(p2);

                    int idDocum = Convert.ToInt32(dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value);
                    SqlParameter p3 = new SqlParameter("@idDocum", idDocum);
                    sqlCmd.Parameters.Add(p3);

                    sqlCmd.CommandTimeout = 0;

                    SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                    dAdapt.Fill(dsCntVal1, "tG_DocSchetTemp");
                    dgvObjLoadAll();

                    txtObjCount.Text = dsCntVal1.tG_DocSchetTemp.Rows.Count.ToString();

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

        // меняем абонента
        private void tbCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
            {
                string filterStr = "";
                if (cbCode.SelectedIndex == 0)
                {
                    filterStr = "CodeAbonent = " + tbCode.Text;
                }
                else
                {
                    filterStr = "CodeAbnStr = '" + tbCode.Text + "'";
                }
                DataRow[] makes = dsCntVal1.tAbn.Select(filterStr);

                if (makes.Length == 0)
                    MessageBox.Show("Абонент не найден...", "Selection error!");
                else
                {
                    DataRow temp = makes[0];
                    tbName.Text = temp["Name"].ToString();
                    ABNID = Convert.ToInt32(temp["id"]);
                    cbDogovor_Load();
                    dgvAbnLoad();
                    TotalQuantity();
                    SelectSqlData(dsCntVal1, dsCntVal1.tR_Worker, true, " where id = " + Convert.ToInt32(temp["idWorker"]));
                    if (dsCntVal1.tR_Worker.Count > 0)
                        this.Text = "Ввод начислений - специалист расчетного отдела " + dsCntVal1.tR_Worker[0]["F"].ToString() + " " + dsCntVal1.tR_Worker[0]["I"].ToString() + " " + dsCntVal1.tR_Worker[0]["O"].ToString();
                    else
                        this.Text = "Ввод начислений";  // Шумилов А.И. 06.03.2013

                    // проверим есть ли документ за текущий период
                    // если нет, то введем его
                    if (dsCntVal1.tG_Doc.Rows.Count > 0)
                    {
                        if (dsCntVal1.tG_Doc[0]["dtPay"].ToString() != CalcDate.ToString())
                        {
                            NewDoc();
                            dgvAbnLoad();
                        }
                    }
                    else
                    {
                        NewDoc();
                        dgvAbnLoad();
                    }
                } 
            }

        }

        // хранимая процедура - запишем новое значение Quantity
        private void quantitySet()
        {
            if (dgvObj.Rows.Count > 0)
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

                    int idAbnObj = -1;
                    if (dgvObj.CurrentRow.Cells["idObj_dgvObj"].Value == DBNull.Value)
                        idAbnObj = 0;
                    else
                        idAbnObj = Convert.ToInt32(dgvObj.CurrentRow.Cells["idObj_dgvObj"].Value);
                    SqlParameter p1 = new SqlParameter("@idAbnObj", idAbnObj);
                    sqlCmd.Parameters.Add(p1);

                    int idAbn = -1;
                    if (dgvObj.CurrentRow.Cells["abnID_dgvObj"].Value == DBNull.Value)
                        idAbn = 0;
                    else
                        idAbn = Convert.ToInt32(dgvObj.CurrentRow.Cells["abnID_dgvObj"].Value);
                    SqlParameter p2 = new SqlParameter("@idAbn", idAbn);
                    sqlCmd.Parameters.Add(p2);

                    int idDog = -1;
                    if (cbDogovor.ComboBox.SelectedValue == DBNull.Value)
                        idDog = 0;
                    else
                        idDog = Convert.ToInt32(cbDogovor.ComboBox.SelectedValue);
                    SqlParameter p3 = new SqlParameter("@idDogovor", idDog);
                    sqlCmd.Parameters.Add(p3);

                    DateTime Date;
                    if (((DateTime)dsCntVal1.tG_Doc[dgvAbn.CurrentRow.Index]["dtPay"]).Month < 10)
                        Date = Convert.ToDateTime("01." + "0" + ((DateTime)dsCntVal1.tG_Doc[dgvAbn.CurrentRow.Index]["dtPay"]).Month + "." + ((DateTime)dsCntVal1.tG_Doc[dgvAbn.CurrentRow.Index]["dtPay"]).Year);
                    else
                        Date = Convert.ToDateTime("01." + ((DateTime)dsCntVal1.tG_Doc[dgvAbn.CurrentRow.Index]["dtPay"]).Month + "." + ((DateTime)dsCntVal1.tG_Doc[dgvAbn.CurrentRow.Index]["dtPay"]).Year);
                    SqlParameter p4 = new SqlParameter("@Date", Date.ToString("yyyyMMdd"));
                    sqlCmd.Parameters.Add(p4);
                                        
                    int ModeCalc = -1;
                    if (dgvObj.CurrentRow.Cells["modeCalc_dgvObj"].Value == DBNull.Value)
                        ModeCalc = 0;
                    else
                    {

                        ModeCalc = Convert.ToInt32(dgvObj.CurrentRow.Cells["modeCalc_dgvObj"].Value);
                        // если объект перетоки
                        if (dgvObj.CurrentRow.Cells["idStatus"].Value != DBNull.Value)
                        {
                            if (Convert.ToInt32(dgvObj.CurrentRow.Cells["idStatus"].Value) == Constants.Constants.TypeObjStatus_CrossFlow)
                                switch (ModeCalc)
                                {
                                    case Constants.Constants.TypeEnter:
                                        ModeCalc = Constants.Constants.TypeEnterСrossFlow;
                                        break;
                                    case Constants.Constants.TypeMeter:
                                        ModeCalc = Constants.Constants.TypeMeterCrossFlow;
                                        break;
                                }
                            // если объект непосредственное управление
                            else if (Convert.ToInt32(dgvObj.CurrentRow.Cells["idStatus"].Value) == Constants.Constants.TypeObjStatus_DirectControl)
                                switch (ModeCalc)
                                {
                                    case Constants.Constants.TypeEnter:
                                        ModeCalc = Constants.Constants.TypeEnter_DirectControl;
                                        break;
                                    case Constants.Constants.TypeMeter:
                                        ModeCalc = Constants.Constants.TypeMeter_DirectControl;
                                        break;
                                }
                        }
                    }
                    SqlParameter p5 = new SqlParameter("@ModeCalc", ModeCalc);
                    sqlCmd.Parameters.Add(p5);

                    int QuantityCalc = -1;
                    if (dgvObj.CurrentRow.Cells["quantityCalc_dgvObj"].Value == DBNull.Value)
                        QuantityCalc = 0;
                    else
                        QuantityCalc = Convert.ToInt32(dgvObj.CurrentRow.Cells["quantityCalc_dgvObj"].Value);
                    SqlParameter p6 = new SqlParameter("@QuantityCalc", QuantityCalc);
                    sqlCmd.Parameters.Add(p6);

                    int Quantity = -1;
                    if (dgvObj.CurrentRow.Cells["quantity_dgvObj"].Value == DBNull.Value)
                        Quantity = 0;
                    else
                        Quantity = Convert.ToInt32(dgvObj.CurrentRow.Cells["quantity_dgvObj"].Value);
                    SqlParameter p7 = new SqlParameter("@Quantity", Quantity);
                    sqlCmd.Parameters.Add(p7);

                    decimal Summa = -1;
                    if (dgvObj.CurrentRow.Cells["summa_dgvObj"].Value == DBNull.Value)
                        Summa = 0;
                    else
                        Summa = Convert.ToDecimal(dgvObj.CurrentRow.Cells["summa_dgvObj"].Value);
                    SqlParameter p8 = new SqlParameter("@Summa", Summa);
                    sqlCmd.Parameters.Add(p8);

                    int idTariff = -1;
                    if (dgvObj.CurrentRow.Cells["idTariff_dgvObj"].Value == DBNull.Value)
                        idTariff = 0;
                    else
                        idTariff = Convert.ToInt32(dgvObj.CurrentRow.Cells["idTariff_dgvObj"].Value);
                    SqlParameter p9 = new SqlParameter("@idTariff", idTariff);
                    sqlCmd.Parameters.Add(p9);

                    decimal Tariff = -1;
                    if (dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value == DBNull.Value)
                        Tariff = 0;
                    else
                        Tariff = Convert.ToDecimal(dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value);
                    SqlParameter p10 = new SqlParameter("@Tariff", Tariff);
                    sqlCmd.Parameters.Add(p10);

                    int idDocum = -1;
                    if (dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value == DBNull.Value)
                        idDocum = 0;
                    else
                        idDocum = Convert.ToInt32(dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value);
                    SqlParameter p11 = new SqlParameter("@idDocum", idDocum);
                    sqlCmd.Parameters.Add(p11);

                    int TypeOfEnergy;
                    TypeOfEnergy = Convert.ToInt32(cbTypeEnergy.ComboBox.SelectedValue);
                    SqlParameter p12 = new SqlParameter("@TypeOfEnergy", TypeOfEnergy);
                    sqlCmd.Parameters.Add(p12);

                    sqlCmd.CommandTimeout = 0;

                    sqlCmd.ExecuteNonQuery();
                    dgvObjLoadAll();

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

        // обработка нажатий клавиш
        private void dgvObj_KeyDown(object sender, KeyEventArgs e)
        {
            if (CODE.Length > 3)
                CODE = "";
            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.F3: // ручной ввод
                        if (tbEnter.Visible)
                        {
                            tbEnter.PerformClick();
                            TotalQuantity();
                        }
                        break;
                    case Keys.Enter: // ручной ввод
                        if (tbEnter.Visible)
                        {
                            tbEnter.PerformClick();
                            TotalQuantity();
                        }
                        break;

                    case Keys.F4: // ввод по последнему
                        if (tbLast.Visible)
                        {
                            tbLast.PerformClick();
                            TotalQuantity();
                        }
                        break;

                    case Keys.F8: // ввод по мощности
                        if (tbPower.Visible)
                        {
                            tbPower.PerformClick();
                            TotalQuantity();
                        }
                        break;
                    case Keys.F6: // ввод по счетчикам
                        if (tbMeter.Visible)
                        {
                            tbMeter.PerformClick();
                            TotalQuantity();
                        }
                        break;
                    case Keys.F12: // безучетное
                        if (tbEnter.Enabled)
                        {
                            UnMetered();
                        }
                        break;
                    case Keys.F11: // перетоки
                        if (tbEnter.Enabled)
                        {
                            CrossFlow();
                        }
                        break;
                    case Keys.D0:
                        CODE += '0';
                        break;
                    case Keys.D1:
                        CODE += '1';
                        break;
                    case Keys.D2:
                        CODE += '2';
                        break;
                    case Keys.D3:
                        CODE += '3';
                        break;
                    case Keys.D4:
                        CODE += '4';
                        break;
                    case Keys.D5:
                        CODE += '5';
                        break;
                    case Keys.D6:
                        CODE += '6';
                        break;
                    case Keys.D7:
                        CODE += '7';
                        break;
                    case Keys.D8:
                        CODE += '8';
                        break;
                    case Keys.D9:
                        CODE += '9';
                        break;
                    case Keys.NumPad0:
                        CODE += '0';
                        break;
                    case Keys.NumPad1:
                        CODE += '1';
                        break;
                    case Keys.NumPad2:
                        CODE += '2';
                        break;
                    case Keys.NumPad3:
                        CODE += '3';
                        break;
                    case Keys.NumPad4:
                        CODE += '4';
                        break;
                    case Keys.NumPad5:
                        CODE += '5';
                        break;
                    case Keys.NumPad6:
                        CODE += '6';
                        break;
                    case Keys.NumPad7:
                        CODE += '7';
                        break;
                    case Keys.NumPad8:
                        CODE += '8';
                        break;
                    case Keys.NumPad9:
                        CODE += '9';
                        break;

                    default:
                        CODE = "";
                        break;
                }
                if (CODE != "")
                    ObjFind();

            }
            else
            {
                if (e.KeyValue == 13 && e.Control)
                {
                    tbMeter.PerformClick();
                    TotalQuantity();
                }

                if (e.KeyCode == Keys.F8 && e.Control)
                {
                    if (cbObj.SelectedIndex > 0)
                    {
                        MessageBox.Show("Ввод начислений возможен только в режиме <активные объекты>");
                        return;
                    }

                    result = MessageBox.Show("Начислить по мощности по всем объектам?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgvObj.Rows.Count; i++)
                        {
                            if ((dgvObj.Rows[i].Cells["quantityCalc_dgvObj"].Value == DBNull.Value) || (Convert.ToInt32(dgvObj.Rows[i].Cells["quantityCalc_dgvObj"].Value) == 0))
                            {
                                if ((dgvObj.Rows[i].Cells["powerSet_dgvObj"].Value != DBNull.Value) && (Convert.ToDecimal(dgvObj.Rows[i].Cells["powerSet_dgvObj"].Value) != 0))
                                {
                                    dgvObj.CurrentCell = dgvObj.Rows[i].Cells["QuantityCalc_dgvObj"];
                                    decimal pow = 0;
                                    int reg = 0;
                                    int en = 0;
                                    pow = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.Rows[i].Index]["PowerSet"]);
                                    reg = Convert.ToInt32(dsCntVal1.tG_DocSchetTemp[dgvObj.Rows[i].Index]["Regime"]);
                                    en = Convert.ToInt32(Math.Round(pow * reg));

                                    dsCntVal1.tG_DocSchetTemp[dgvObj.Rows[i].Index]["QuantityCalc"] = en;
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.Rows[i].Index]["ModeCalc"] = Constants.Constants.TypeEnter;
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.Rows[i].Index]["Quantity"] = en;
                                    if (dgvObj.Rows[i].Cells["tariff_dgvObj"].Value != DBNull.Value)
                                        dsCntVal1.tG_DocSchetTemp[dgvObj.Rows[i].Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.Rows[i].Index]["Tariff"].ToString()) * en;
                                    else
                                        dsCntVal1.tG_DocSchetTemp[dgvObj.Rows[i].Index]["Summa"] = 0;
                                    quantitySet();

                                }
                            }

                        }
                    }
                }
 


            }
        }

        // ввод начислений вручную
        private void tbEnter_Click(object sender, EventArgs e)
        {
            if (cbObj.SelectedIndex > 0)
            {
                MessageBox.Show("Ввод начислений возможен только в режиме <активные объекты>");
                return;
            }
            if (dgvObj.Rows.Count > 0)
            {
                int prm = -1;
                if ((dgvObj.CurrentRow.Cells["quantityCalc_dgvObj"].Value == DBNull.Value) || 
                    ((int)dgvObj.CurrentRow.Cells["quantityCalc_dgvObj"].Value == 0))
                {
                    prm = 0;
                    // если для этого субобъекта уже есть начисление в другом абоненте
                    if ((dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idObjParent"] != DBNull.Value) && 
                        ((decimal)dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value == 0))
                    {
                        // проверяем есть ли этот же объект, который рассчитывается по ненулевому тарифу
                        int id = Convert.ToInt32(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idObj"]);
                        SelectSqlData(dsCntVal1.tAbnObjReg, true, "where idAbnObjSame = " + id + " order by DateChange desc",null,false,1);

                        if (dsCntVal1.tAbnObjReg.Rows.Count > 0)
                        {
                            int idFind = Convert.ToInt32(dsCntVal1.tAbnObjReg.Rows[0]["idAbnObj"]);
                            // ищем начисление для найденного объекта за текущий период
                            DateTime DateCalc = Convert.ToDateTime(dsCntVal1.tG_Doc[dgvAbn.CurrentRow.Index]["dtPay"]);
                            DateCalc = new DateTime(DateCalc.Year, DateCalc.Month, 1);
                            SelectSqlData(dsCntVal1, dsCntVal1.tG_DocSchet, true, "where idAbnObj = " + idFind + " and dtCalc = '" + DateCalc.Date.ToString("yyyyMMdd") + "'");

                            if (dsCntVal1.tG_DocSchet.Rows.Count > 0) 

                                if (dsCntVal1.tG_DocSchet[0]["QuantityCalc"] != DBNull.Value)  
                                    prm = Convert.ToInt32(dsCntVal1.tG_DocSchet[0]["QuantityCalc"]);
                        }
                    }

                }
                else
                // существующее значение Quantity
                    prm = Convert.ToInt32(dgvObj.CurrentRow.Cells["quantityCalc_dgvObj"].Value);

                FormCntValEnter f = new FormCntValEnter(prm);
                f.Owner = this;
                f.SqlSettings = this.SqlSettings;
                // ввод нового значения
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // запомним текущую строку в гриде
                    int idRowCur = Convert.ToInt32(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idObj"].ToString());
                    
                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["QuantityCalc"] = valQuantity;
                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["ModeCalc"] = Constants.Constants.TypeEnter;
                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = valQuantity;
                    if (dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value)
                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * valQuantity;
                    else
                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                    // запись на сервер
                    quantitySet();

                    // суммируем все введенные кВт*ч по всем субчикам данного объекта
                    int QuantityTotal = 0;
                    int Parent;
                    if (dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value == DBNull.Value || Convert.ToInt32(dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value) == 0)
                    {
                        // объект
                        Parent = (int)dgvObj.CurrentRow.Cells["idObj_dgvObj"].Value;
                        for (int i = 0; i < dgvObj.Rows.Count; i++)
                            // ищем субчиков к этому объекту
                            if ((dgvObj.Rows[i].Cells["idObjParent_dgvObj"].Value != DBNull.Value) && ((int)dgvObj.Rows[i].Cells["idObjParent_dgvObj"].Value == Parent))   
                            {
                                // если субчик рассчитывается как доля от родителя
                                if ((dgvObj.Rows[i].Cells["CommonPercent"].Value != DBNull.Value) || (dgvObj.Rows[i].Cells["CommonValue"].Value != DBNull.Value))
                                {   
                                    // делаем субчика текущим 
                                    dgvObj.CurrentCell = dgvObj.Rows[i].Cells["QuantityCalc_dgvObj"];
                                    int tmpVal = 0;
                                    if (dgvObj.Rows[i].Cells["CommonPercent"].Value != DBNull.Value)
                                        tmpVal = (valQuantity * Convert.ToInt32(dgvObj.Rows[i].Cells["CommonPercent"].Value)) / 100;
                                    if (dgvObj.Rows[i].Cells["CommonValue"].Value != DBNull.Value)
                                        tmpVal = (int)dgvObj.Rows[i].Cells["CommonValue"].Value;
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["QuantityCalc"] = tmpVal;
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["ModeCalc"] = Constants.Constants.TypeEnter;
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = tmpVal;
                                    if (dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value)
                                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * tmpVal;
                                    else
                                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                                    // запись на сервер
                                    quantitySet();
                                }
                            }
                        // возврат к родителю
                        for (int i = 0; i < dgvObj.Rows.Count; i++)
                        {
                            if ((int)dgvObj.Rows[i].Cells["idObj_dgvObj"].Value == idRowCur)
                            {
                                dgvObj.CurrentCell = dgvObj.Rows[i].Cells["QuantityCalc_dgvObj"];
                            }
                        }
                    }

                    else
                        Parent = (int)dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value;

                    string filterStr = "idObjParent = " + Parent.ToString();
                    DataRow[] makes = dsCntVal1.tG_DocSchetTemp.Select(filterStr);
                    for (int i = 0; i < makes.Length; i++)
                    {
                        DataRow tmp = makes[i];
                        if (tmp["QuantityCalc"] != DBNull.Value)
                            QuantityTotal += (int)tmp["QuantityCalc"];
                    }

                    // объект
                    if (dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value == DBNull.Value || Convert.ToInt32(dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value) == 0)
                    {
                        if ((dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idTariff"] != DBNull.Value) && (Convert.ToInt32(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idTariff"]) != 0))
                        {
                            if (QuantityTotal != 0)
                            {
                                // уменьшаем начисление объекта на сумму начислений субчиков
                                dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = valQuantity - QuantityTotal;
                                if ((dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value) && (Convert.ToDecimal(dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value) != 0))
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * (valQuantity - QuantityTotal);
                                else
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                            }
                        }
                    }
                    // субобъект
                    else
                    {
                        // делаем строку с родительским объектом текущей
                        for (int i = 0; i < dgvObj.Rows.Count; i++)
                        {
                            if ((int)dgvObj.Rows[i].Cells["idObj_dgvObj"].Value == Parent)
                            {
                                dgvObj.CurrentCell = dgvObj.Rows[i].Cells["QuantityCalc_dgvObj"];
                            }
                        }
                        if ((dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idTariff"] != DBNull.Value)  && (Convert.ToInt32(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idTariff"]) != 0))
                        {
                            // изменяем расход и сумму у родительского объекта
                            if (dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["QuantityCalc"] != DBNull.Value)
                                valQuantity = (int)dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["QuantityCalc"];
                            else
                                valQuantity = 0;
                            dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = valQuantity - QuantityTotal;
                            if (dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value)
                                dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * (valQuantity - QuantityTotal);
                            else
                                dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                        }
                    }
                    // запись на сервер
                    quantitySet();
                    // обновляем грид
 //                   dgvObjLoad();
                    // возвращаемся на прежнюю запись
                    //for (int i = 0; i < dgvObj.Rows.Count; i++)
                    //{
                    //    if ((int)dgvObj.Rows[i].Cells["idObj_dgvObj"].Value == idRowCur)
                    //    {
                    //        dgvObj.CurrentCell = dgvObj.Rows[i].Cells["QuantityCalc_dgvObj"];
                    //    }
                    //}
                }
            }
        }

        // ввод начислений по мощности
        private void tbPower_Click(object sender, EventArgs e)
        {
            if (cbObj.SelectedIndex > 0)
            {
                MessageBox.Show("Ввод начислений возможен только в режиме <активные объекты>");
                return;
            }
            if (dgvObj.Rows.Count > 0)
            {
                int prm = -1;
                if (dgvObj.CurrentRow.Cells["quantityCalc_dgvObj"].Value == DBNull.Value)
                    prm = 0;
                else
                    // существующее значение Quantity
                    prm = Convert.ToInt32(dgvObj.CurrentRow.Cells["quantityCalc_dgvObj"].Value);

                decimal pow = 0;
                int reg = 0;
                int en = 0;
                pow = (decimal)dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["PowerSet"];
                reg = (int)dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Regime"];
                en = (int)(pow * reg);

                Legal.Forms.Calculat.FormPowerEnter f = new Legal.Forms.Calculat.FormPowerEnter(prm, pow, reg, en);
                f.Owner = this;
                f.SqlSettings = this.SqlSettings;
                // ввод нового значения
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // запомним текущую строку в гриде
                    int idRowCur = Convert.ToInt32(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idObj"].ToString());

                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["QuantityCalc"] = valQuantity;
                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["ModeCalc"] = Constants.Constants.TypeEnter;
                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = valQuantity;
                    if (dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value)
                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * valQuantity;
                    else
                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                    // запись на сервер
                    quantitySet();

                    // суммируем все введенные кВт*ч по всем субобъектам данного объекта
                    int QuantityTotal = 0;
                    int Parent;
                    if (dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value == DBNull.Value)
                        Parent = (int)dgvObj.CurrentRow.Cells["idObj_dgvObj"].Value;
                    else
                        Parent = (int)dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value;

                    string filterStr = "idObjParent = " + Parent.ToString();
                    DataRow[] makes = dsCntVal1.tG_DocSchetTemp.Select(filterStr);
                    for (int i = 0; i < makes.Length; i++)
                    {
                        DataRow tmp = makes[i];
                        if (tmp["QuantityCalc"] != DBNull.Value)
                            QuantityTotal += (int)tmp["QuantityCalc"];
                    }

                    // объект
                    if (dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value == DBNull.Value)
                    {
                        if (QuantityTotal != 0)
                        {
                            dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = valQuantity - QuantityTotal;
                            if (dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value)
                                dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * (valQuantity - QuantityTotal);
                            else
                                dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                        }
                    }
                    // субобъект
                    else
                    {
                        // делаем строку с родительским объектом текущей
                        for (int i = 0; i < dgvObj.Rows.Count; i++)
                        {
                            if ((int)dgvObj.Rows[i].Cells["idObj_dgvObj"].Value == Parent)
                            {
                                dgvObj.CurrentCell = dgvObj.Rows[i].Cells["QuantityCalc_dgvObj"];
                            }
                        }
                        // изменяем расход и сумму у родительского объекта
                        valQuantity = (int)dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["QuantityCalc"];
                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = valQuantity - QuantityTotal;
                        if (dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value)
                            dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * (valQuantity - QuantityTotal);
                        else
                            dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                    }
                    // запись на сервер
                    quantitySet();
                    // обновляем грид
                    //dgvObjLoad();
                    //// возвращаемся на прежнюю запись
                    //for (int i = 0; i < dgvObj.Rows.Count; i++)
                    //{
                    //    if ((int)dgvObj.Rows[i].Cells["idObj_dgvObj"].Value == idRowCur)
                    //    {
                    //        dgvObj.CurrentCell = dgvObj.Rows[i].Cells["QuantityCalc_dgvObj"];
                    //    }
                    //}
                }
            }
        }

        // ввод начислений по счетчикам
        private void tbMeter_Click(object sender, EventArgs e)
        {
            if (dgvObj.Rows.Count > 0)
            {
                // id объекта
                int id = Convert.ToInt32(dgvObj.CurrentRow.Cells["idObj_dgvObj"].Value);

                // дата начисления
                DateTime Date;
                if (((DateTime)dsCntVal1.tG_Doc[dgvAbn.CurrentRow.Index]["dtPay"]).Month < 10)
                    Date = Convert.ToDateTime("01." + "0" + ((DateTime)dsCntVal1.tG_Doc[dgvAbn.CurrentRow.Index]["dtPay"]).Month + "." + ((DateTime)dsCntVal1.tG_Doc[dgvAbn.CurrentRow.Index]["dtPay"]).Year);
                else
                    Date = Convert.ToDateTime("01." + ((DateTime)dsCntVal1.tG_Doc[dgvAbn.CurrentRow.Index]["dtPay"]).Month + "." + ((DateTime)dsCntVal1.tG_Doc[dgvAbn.CurrentRow.Index]["dtPay"]).Year);

                // если это субчик по нулевому тарифу проверим имеется ли связь с этим же объектом который рассчитывается у потребителя владельца по ненулевому тарифу
                int idFind = 0;
                if ((dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idObjParent"] != DBNull.Value) && ((decimal)dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value == 0))
                {
                    int id1 = Convert.ToInt32(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idObj"]);
                    SelectSqlData(dsCntVal1.tAbnObjReg, true, "where idAbnObjSame = " + id1 + " order by DateChange desc",null,false,1);
                    if (dsCntVal1.tAbnObjReg.Rows.Count > 0)
                    {
                        idFind = Convert.ToInt32(dsCntVal1.tAbnObjReg.Rows[0]["idAbnObj"]);
                    }
                }

                // FlagMeterValEdit флаг = 1  разрешающий ввод и редактирование показаний
                // в режиме <все объекты> ввод и редактирование запрещено
                if (cbObj.SelectedIndex > 0)
                {
                    FlagMeterValEdit = 0;
                }
                FormCntValMeter f = new FormCntValMeter(id, Date, FlagMeterValEdit, idFind);
                f.Owner = this;
                f.SqlSettings = this.SqlSettings;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    if (dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] != DBNull.Value && (int)dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] != 0)
                    {
                        if (dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["ModeCalc"] != DBNull.Value && (int)dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["ModeCalc"] == 512)
                        {
                            result = MessageBox.Show("Расход уже введен вручную. Оставить его?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                                return;
                        }
                    }

                    // если есть потери увеличим начисление
                    float KLOSS = -1;
                    if (dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Kloss"] == DBNull.Value)
                        KLOSS = 0;
                    else
                        KLOSS = Convert.ToSingle(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Kloss"]);
                    
                    // Shumilov A/I/  Складывать надо каждый счетчик
                    //if (KLOSS != 0)
                    //    valQuantity = valQuantity + Convert.ToInt32(valQuantity * KLOSS / 100);
                    if (KLOSS != 0)
                    {
                        if (f.CurrSize.Count > 0)
                        {
                            valQuantity = 0;
                            foreach (int valQ in f.CurrSize)
                                valQuantity += valQ + Convert.ToInt32(valQ * KLOSS / 100);
                        }
                        else
                            valQuantity = valQuantity + Convert.ToInt32(valQuantity * KLOSS / 100);
                    }


                    int valUnmetered = 0;
                    if (f.UnmeteredSize.Count > 0)
                    {
                        if (KLOSS != 0)
                        {
                            foreach (int valQ in f.UnmeteredSize)
                                valUnmetered += valQ + Convert.ToInt32(valQ * KLOSS / 100);
                        }
                        else
                        {
                            foreach (int valQ in f.UnmeteredSize)
                                valUnmetered += valQ;
                        }
                    }


                    // если есть дополнительные потери добавим их
                    if ((byte)dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["CalcLoss"] != 0)
                    {
                        SelectSqlData(dsCntVal1, dsCntVal1.tG_AbnObjKLossTrans, true, "where idAbnObj = " + id + " and Year = " + Date.Year + " and Deleted = 0 and LevelData = 0" );
                        if (dsCntVal1.tG_AbnObjKLossTrans.Rows.Count > 0)
                        {
                            int LossMonth = (int)dsCntVal1.tG_AbnObjKLossTrans.Rows[0]["M" + Date.Month.ToString()];
                            valQuantity = valQuantity + LossMonth;
                        }
                    }

                    // добавим ОДН
                    if (dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["ODN"] != DBNull.Value)
                    {
                        valQuantity = valQuantity + Convert.ToInt32(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["ODN"]);
                    }

                    // запомним текущую строку в гриде
                    int idRowCur = Convert.ToInt32(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idObj"].ToString());

                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["QuantityCalc"] = valQuantity;
                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["ModeCalc"] = Constants.Constants.TypeMeter;
                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = valQuantity;
                    if (dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value)
                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * valQuantity;
                    else
                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                    // запись на сервер
                    quantitySet();


                    // суммируем все введенные кВт*ч по всем субобъектам данного объекта
                    int QuantityTotal = 0;
                    int Parent;
                    if ((dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value == DBNull.Value) || ((int)dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value == 0))  
                    {
                        Parent = (int)dgvObj.CurrentRow.Cells["idObj_dgvObj"].Value;
                        for (int i = 0; i < dgvObj.Rows.Count; i++)
                            // ищем субчиков к этому объекту
                            if ((dgvObj.Rows[i].Cells["idObjParent_dgvObj"].Value != DBNull.Value) && ((int)dgvObj.Rows[i].Cells["idObjParent_dgvObj"].Value == Parent))
                            {
                                // если субчик рассчитывается как доля от родителя
                                if ((dgvObj.Rows[i].Cells["CommonPercent"].Value != DBNull.Value) || (dgvObj.Rows[i].Cells["CommonValue"].Value != DBNull.Value))
                                {
                                    // делаем субчика текущим 
                                    dgvObj.CurrentCell = dgvObj.Rows[i].Cells["QuantityCalc_dgvObj"];
                                    int tmpVal = 0;
                                    if (dgvObj.Rows[i].Cells["CommonPercent"].Value != DBNull.Value)
                                        tmpVal = (valQuantity * Convert.ToInt32(dgvObj.Rows[i].Cells["CommonPercent"].Value)) / 100;
                                    if (dgvObj.Rows[i].Cells["CommonValue"].Value != DBNull.Value)
                                        tmpVal = (int)dgvObj.Rows[i].Cells["CommonValue"].Value;
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["QuantityCalc"] = tmpVal;
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["ModeCalc"] = Constants.Constants.TypeEnter;
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = tmpVal;
                                    if (dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value)
                                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * tmpVal;
                                    else
                                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                                    // запись на сервер
                                    quantitySet();
                                }
                            }
                        // возврат к родителю
                        for (int i = 0; i < dgvObj.Rows.Count; i++)
                        {
                            if ((int)dgvObj.Rows[i].Cells["idObj_dgvObj"].Value == idRowCur)
                            {
                                dgvObj.CurrentCell = dgvObj.Rows[i].Cells["QuantityCalc_dgvObj"];
                            }
                        }
                    }
                    else
                        Parent = (int)dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value;

                    string filterStr = "idObjParent = " + Parent.ToString();
                    DataRow[] makes = dsCntVal1.tG_DocSchetTemp.Select(filterStr);
                    for (int i = 0; i < makes.Length; i++)
                    {
                        DataRow tmp = makes[i];
                        if (tmp["QuantityCalc"] != DBNull.Value)
                            QuantityTotal += (int)tmp["QuantityCalc"];
                    }

                    // объект
                    if (dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value == DBNull.Value)
                    {
                        if (dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idTariff"] != DBNull.Value)
                        {
                            if (QuantityTotal != 0)
                            {
                                dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = valQuantity - QuantityTotal;
                                if ((dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value) && (Convert.ToDecimal(dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value) != 0))
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * (valQuantity - QuantityTotal);
                                else
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                            }
                        }
                    }
                    // субобъект
                    else
                    {
                        // делаем строку с родительским объектом текущей
                        for (int i = 0; i < dgvObj.Rows.Count; i++)
                        {
                            if ((int)dgvObj.Rows[i].Cells["idObj_dgvObj"].Value == Parent)
                            {
                                dgvObj.CurrentCell = dgvObj.Rows[i].Cells["QuantityCalc_dgvObj"];
                            }
                        }
                        if (dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idTariff"] != DBNull.Value) 
                            if ((int)dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idTariff"] != 0)
                                {
                                    // изменяем расход и сумму у родительского объекта
                                    valQuantity = (int)dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["QuantityCalc"];
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = valQuantity - QuantityTotal;
                                    if (dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value)
                                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * (valQuantity - QuantityTotal);
                                    else
                                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                                }
                    }
                    // запись на сервер
                    quantitySet();
                    // если по счетчикам есть б/п
                    if ((f.UnmeteredSize.Count > 0) && (valUnmetered > 0))
                        UnMetered1(valUnmetered);
  
                    for (int i = 0; i < dgvObj.Rows.Count; i++)
                    {
                        if ((int)dgvObj.Rows[i].Cells["idObj_dgvObj"].Value == idRowCur)
                        {
                            dgvObj.CurrentCell = dgvObj.Rows[i].Cells["QuantityCalc_dgvObj"];
                        }
                    }
                }
            }
        }

        // загружаем начисления за весь период
        private void dgvObjLoadAll()
        {
            //if (dgvObjAll.Rows.Count > 0)
            //    dsCntVal1.tG_SchetAll.Clear();

            if (dsCntVal1.tG_SchetAll.Rows.Count > 0)
                dsCntVal1.tG_SchetAll.Clear();

            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "select * from fn_LegGetObjAll(@DogID) ";
                strCmd += " order by DateCalc Desc ";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                int DogID = Convert.ToInt32(cbDogovor.ComboBox.SelectedValue);
                SqlParameter p1 = new SqlParameter("@DogID", DogID);
                sqlCmd.Parameters.Add(p1);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCntVal1, "tG_SchetAll");

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

        // загружаем договора для абонента
        private void cbDogovor_Load()
        {

            SelectSqlData(dsCntVal1, dsCntVal1.tAbnDoc_List, true, 
                " where idAbn = " + ABNID + " AND (idDocType = " + (int)Constants.DocType.Dogovor + 
                " OR idDocType = " + (int)Constants.DocType.DogovorEnergo + ") AND deleted = 0 AND DocDate <= '" + CalcDate.Date.ToString("yyyyMMdd") + 
                "' order by IsActive Desc, DocDate Desc");
            if (dsCntVal1.tAbnDoc_List.Rows.Count > 0)
            {
                cbDogovor.ComboBox.DisplayMember = "DocNumber";
                cbDogovor.ComboBox.ValueMember = "id";
                cbDogovor.ComboBox.DataSource = dsCntVal1.tAbnDoc_List;
                if ((int)dsCntVal1.tAbnDoc_List[0]["idDocType"] == (int)Constants.DocType.Dogovor)
                {
                    tslDogType.Text = "Дог. пер.";
                    Dogovor_Type = "транспортировка";
                }
                else
                {
                    tslDogType.Text = "Дог. эн.";
                    Dogovor_Type = "энергоснабжение";
                }
            }
            else
            {
                MessageBox.Show("Печалька - на данный расчетный период у потребителя нет ни одного действующего договора(перед вводом начислений проверьте наличие договора и дату договора которая д.б. меньше или равна даты конца расчетного периода)");
            }
        }

        // загружаем объекты для другого договора
        private void cbDogovor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAbnLoad();
            TotalQuantity();
            if (dsCntVal1.tAbnDoc_List.Rows.Count > 0)
            {
                int id = cbDogovor.SelectedIndex;
                if ((int)dsCntVal1.tAbnDoc_List[id]["idDocType"] == (int)Constants.DocType.Dogovor)
                {
                    tslDogType.Text = "Дог. пер.";
                    Dogovor_Type = "транспортировка";
                }
                else
                {
                    tslDogType.Text = "Дог. эн.";
                    Dogovor_Type = "энергоснабжение";
                }
            }

            if (dgvAbn.Rows.Count > 0)
            {
                //dgvObjLoad();
                dgvObj.Focus();
            }

            // Фарит 26.03.2016
            if (dsCntVal1.tG_Doc.Rows.Count > 0)
            {
                if (dsCntVal1.tG_Doc[0]["dtPay"].ToString() != CalcDate.ToString())
                {
                    NewDoc();
                    dgvAbnLoad();
                }
            }
            else
            {
                NewDoc();
                dgvAbnLoad();
            }
        }

        // загружаем все объекты или только активные
        private void cbObj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvAbn.Rows.Count > 0)
            {
                dgvObjLoad();
                TotalQuantity();
                dgvObj.Focus();
            }
        }

        // загружаем виды начислений
        private void cbTypeEnergy_Load()
        {
            int idType = 542; 
            SelectSqlData(dsCntVal1, dsCntVal1.tR_Classifier, true, " where ParentID = " + idType.ToString());
            cbTypeEnergy.ComboBox.DataSource = dsCntVal1.tR_Classifier;
            cbTypeEnergy.ComboBox.DisplayMember = "Name";
            cbTypeEnergy.ComboBox.ValueMember = "id";
            cbTypeEnergy.ComboBox.SelectedValue = Constants.Constants.TypeTransmission;
        }

        // добавить новое начисление по абоненту
        private void tbAddCalc_Click(object sender, EventArgs e)
        {
            NewDoc();
            dgvAbnLoad();
        }

        // удалить открытое начисление по абоненту
        private void tbDelCalc_Click(object sender, EventArgs e)
        {
            // если начисление открыто
            bool block = false;
            if (dgvAbn.CurrentRow.Cells["Block_dgvAbn"].Value != DBNull.Value)
                block = Convert.ToBoolean(dgvAbn.CurrentRow.Cells["Block_dgvAbn"].Value);
            if (!block)
            {
                if (dgvObj.Rows.Count > 0)
                {
                    for (int curRow = 0; curRow < dsCntVal1.tG_DocSchetTemp.Rows.Count; curRow++)
                    {
                        if (dgvObj.CurrentRow.Cells["idDocSchet_dgvObj"].Value != DBNull.Value)
                        {
                            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                            try
                            {
                                int idDocSchet = Convert.ToInt32(dgvObj.CurrentRow.Cells["idDocSchet_dgvObj"].Value);
                                con.OpenConnection(SqlSettings);

                                string strCmd = "";
                                strCmd = "LegObjDel";
                                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                                sqlCmd.CommandType = CommandType.StoredProcedure;

                                SqlParameter p1 = new SqlParameter("@idDocSchet", idDocSchet);
                                sqlCmd.Parameters.Add(p1);

                                sqlCmd.CommandTimeout = 0;
                                sqlCmd.ExecuteNonQuery();
                                dgvObjLoad();
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
                int idDocum = Convert.ToInt32(dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value);
                if (DeleteSqlDataById(dsCntVal1.tG_Doc, idDocum))
                {
                    dgvAbnLoad();
                    dgvObjLoad();
                    MessageBox.Show("Начисления удалено ..");
                }
            }
            else
                MessageBox.Show("Нельзя удалить закрытое начисление ..");
        }

        // редактировать начисление по абоненту
        private void tbOpenCalc_Click(object sender, EventArgs e)
        {
            if (dgvObj.Rows.Count > 0)
            {
                decimal SumTotal = 0;
                decimal SumNalog = 0;
                decimal SumObj = 0;
                int QuantityTotal = 0;
                var cars = from car in dsCntVal1.tG_DocSchetTemp.AsEnumerable()
                           group car by car.Tariff;
                // суммируем по документу
                foreach(var item in cars)
                {
                    // суммируем по тарифу
                   foreach(DataRow r in item)
                   {
                       if (r["Summa"] != DBNull.Value)
                           SumObj += r.Field<decimal>("Summa");
                       if ((r["Quantity"] != DBNull.Value) && (r["Summa"] != DBNull.Value) && (r.Field<decimal>("Summa") != 0))

                           QuantityTotal += r.Field<int>("Quantity");
                   }
                   if (SumObj.ToString() != "")
                   {
                       SumTotal += Math.Round(SumObj, 2);

                       // 21.01.2019
                       if (Convert.ToDateTime(dgvAbn.CurrentRow.Cells["dtPayDataGridViewTextBoxColumn"].Value) >= TaxDate)
                           SumNalog += Math.Round(Math.Round(SumObj, 2) * Tax20,2);
                       else
                           SumNalog += Math.Round(Math.Round(SumObj, 2) * Tax,2);
                   }
                   SumObj = 0; 
                }
                int idDocum = Convert.ToInt32(dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value);
                FormAbnCalc frm = new FormAbnCalc(idDocum,SumTotal,QuantityTotal,SumNalog);
                frm.Owner = this;
                frm.SqlSettings = this.SqlSettings;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dgvAbnLoad();
                }
            }
        }

        // печать платежных документов
        private void tbPrint_Click(object sender, EventArgs e)
        {
            if (dgvObj.Rows.Count > 0)
            {
                //bool block = false;
                //if (dgvAbn.CurrentRow.Cells["Block_dgvAbn"].Value != DBNull.Value)
                //    block = Convert.ToBoolean(dgvAbn.CurrentRow.Cells["Block_dgvAbn"].Value);
                //if (block)
                //{
                    int idDocum = Convert.ToInt32(dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value);
                    FormAbnCalcPrint frm = new FormAbnCalcPrint(idDocum);
                    frm.SqlSettings = this.SqlSettings;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                    }
                //}
                //else
                //    MessageBox.Show("Начисления не закрыто ..");
            }
        }

        // открыть-закрыть документ
        private void tbLock_Click(object sender, EventArgs e)
        {
            // перед закрытием выполнить проверку на соответствие данных документа и счета
            if (dgvObj.Rows.Count > 0)
            {
                // найдем общий итог по всем объектам в руб. и кВт*ч
                decimal SumTotal = 0;
                decimal SumObj = 0;
                int QuantityTotal = 0;
                var cars = from car in dsCntVal1.tG_DocSchetTemp.AsEnumerable()
                           group car by car.Tariff;
                foreach (var item in cars)
                {
                    foreach (DataRow r in item)
                    {
                        if (r["Summa"] != DBNull.Value)
                            SumObj += r.Field<decimal>("Summa");
                        if ((r["Quantity"] != DBNull.Value) && (r["Summa"] != DBNull.Value) && (r.Field<decimal>("Summa") != 0))

                            QuantityTotal += r.Field<int>("Quantity");
                    }
                    if (SumObj.ToString() != "")
                        SumTotal += Math.Round(SumObj, 2);
                    SumObj = 0;
                }

                int Quantity_Doc = 0;
                if (dgvAbn.CurrentRow.Cells["quantityTotal_dgvAbn"].Value != System.DBNull.Value) 
                    Quantity_Doc = Convert.ToInt32(dgvAbn.CurrentRow.Cells["quantityTotal_dgvAbn"].Value);
                if (QuantityTotal != Quantity_Doc)
                {
                    MessageBox.Show("Количество по счету " + QuantityTotal + " не совпадает с количеством по документу " + Quantity_Doc + ". Зайдите в редактирование документа и сохраните его.");
  //                  return;
                }

                decimal Summa_Doc = 0;
                if (dgvAbn.CurrentRow.Cells["sumRealiz_dgvAbn"].Value != System.DBNull.Value)
                    Summa_Doc = Convert.ToDecimal(dgvAbn.CurrentRow.Cells["sumRealiz_dgvAbn"].Value);
                if (SumTotal != Summa_Doc)
                {
                    MessageBox.Show("Сумма по счету не совпадает с суммой по документу. Зайдите в редактирование документа и сохраните его.");
  //                  return;
                }
            }

            SelectSqlData(dsCntVal1, dsCntVal1.tPassword, true, " where code = 1");
            string Password = dsCntVal1.tPassword[0]["Password"].ToString();
            Legal.Forms.Calculat.FormPassword frm = new Legal.Forms.Calculat.FormPassword(Password);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.PasswordTrue == true)
                {
                    if (dgvAbn.Rows.Count > 0)
                    {
                        DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                        try
                        {
                            con.OpenConnection(SqlSettings);

                            string strCmd = "";
                            strCmd = "LegAbnCalcLockSet";
                            SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                            sqlCmd.CommandType = CommandType.StoredProcedure;

                            int idDocum = -1;
                            if (dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value == DBNull.Value)
                                idDocum = 0;
                            else
                                idDocum = Convert.ToInt32(dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value);
                            SqlParameter p = new SqlParameter("@idDocum", idDocum);
                            sqlCmd.Parameters.Add(p);

                            sqlCmd.CommandTimeout = 0;

                            sqlCmd.ExecuteNonQuery();
                            dgvAbnLoad();

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


        }

        // проверить превышение мощности
        private void tbTest_Click(object sender, EventArgs e)
        {
            if (dgvObj.Rows.Count > 0)
            {
                int idDog = Convert.ToInt32(cbDogovor.ComboBox.SelectedValue);
                DateTime dtPay = CalcDate; 
                DateTime god = (DateTime)dgvAbn.CurrentRow.Cells["dtPayDataGridViewTextBoxColumn"].Value;

                Legal.Forms.Calculat.FormOverPower frm = new Legal.Forms.Calculat.FormOverPower(dsCntVal1.tG_DocSchetTemp, god,ABNID,idDog,dtPay);
                frm.SqlSettings = this.SqlSettings;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                }
            }

        }

        // визуальный контроль начислений
        private void dgvObj_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (cbCheckVisual.ComboBox.SelectedIndex == 0)
            {
                if (e.RowIndex > -1 && e.RowIndex < dgvObj.RowCount)
                {
                    if ((dgvObj.Rows[e.RowIndex].Cells["quantity_dgvObj"].Value.ToString() == "0") | (dgvObj.Rows[e.RowIndex].Cells["quantity_dgvObj"].Value.ToString() == ""))
                        ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    else
                    {
                        // проверка на недопустимое отклонение
                        CurQuantity = (int)dgvObj.Rows[e.RowIndex].Cells["quantity_dgvObj"].Value;
                        DateTime MaxDate = (DateTime)dgvObj.Rows[e.RowIndex].Cells["dtCalc"].Value;
                        DateTime MinDate = ((DateTime)dgvObj.Rows[e.RowIndex].Cells["dtCalc"].Value).AddMonths(-CountMonth);
                        string FilterStr = string.Format("idObj = {0} AND (DateCalc < #{1}# AND DateCalc > #{2}#)", dgvObj.Rows[e.RowIndex].Cells["idObj_dgvObj"].Value.ToString(), MaxDate, MinDate);
                        DataRow[] makes = dsCntVal1.tG_SchetAll.Select(FilterStr, "DateCalc DESC");
                        if (makes.Length != 0)
                        {
                            DataRow tmp = makes[0];
                            if ((tmp["Quantity"].ToString() != "0") & (tmp["Quantity"].ToString() != ""))
                            {
                                PrevQuantity = (int)tmp["Quantity"];
                                MinQuantity = PrevQuantity - ((PrevQuantity * PercentMinus) / 100);
                                MaxQuantity = PrevQuantity + ((PrevQuantity * PercentPlus) / 100);
                                if ((CurQuantity < MinQuantity) | (CurQuantity > MaxQuantity))
                                {
                                    ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                                }
                            }
                        }

                        // проверка на соответствие заявленным объемам
                        //int ObjID = (int)dgvObj.Rows[e.RowIndex].Cells["idObj_dgvObj"].Value;
                        //int YEAR = ((DateTime)dgvObj.Rows[e.RowIndex].Cells["dtCalc"].Value).Year;
                        //SelectSqlData(dsCntVal1, dsCntVal1.tG_ObjMax, true, "where ObjID = " + ObjID + " AND Year = " + YEAR);
                        //if (dsCntVal1.tG_ObjMax.Rows.Count > 0)
                        //{
                        //    int MONTH = ((DateTime)dgvObj.Rows[e.RowIndex].Cells["dtCalc"].Value).Month + 6;
                        //    if ((int)dgvObj.Rows[e.RowIndex].Cells["quantity_dgvObj"].Value > dsCntVal1.tG_ObjMax.Rows[0].Field<int>(MONTH))
                        //        ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        //}
                    }


                }
            }
            else
                if (e.RowIndex > -1 && e.RowIndex < dgvObj.RowCount)
                {
                    // если субобъект
                    if ((dgvObj.Rows[e.RowIndex].Cells["numberSubObj_dgvObj"].Value.ToString() != "0") && (dgvObj.Rows[e.RowIndex].Cells["numberSubObj_dgvObj"].Value.ToString() != ""))
                        ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Cornsilk;
                    else
                    {
                        // если есть потери
                        if (dgvObj.Rows[e.RowIndex].Cells["CalcLoss"].Value.ToString() != "0")
                            ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCyan;
                        else
                            // если перетоки
                            if (dgvObj.Rows[e.RowIndex].Cells["idStatus"].Value != System.DBNull.Value)
                                if (Convert.ToInt32(dgvObj.Rows[e.RowIndex].Cells["idStatus"].Value) == Constants.Constants.TypeObjStatus_CrossFlow)
                                    ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
                    }

                }

        }

        // поиск абонента по F2
        private void tbFind_Click(object sender, EventArgs e)
        {
                FormAbnFindShort f = new FormAbnFindShort(ABNID);
                f.Owner = this;
                f.SqlSettings = this.SqlSettings;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    tbCode.Text = ABNSELECT.ToString();
                    string filterStr = "CodeAbonent = " + tbCode.Text;
                    DataRow[] makes = dsCntVal1.tAbn.Select(filterStr);
                    if (makes.Length == 0)
                        MessageBox.Show("Абонент не найден...", "Selection error!"); // ничего не найдено 
                    else
                    {
                        DataRow temp = makes[0];
                        tbName.Text = temp["Name"].ToString();
                        ABNID = Convert.ToInt32(temp["id"]);
                        cbDogovor_Load();
                        dgvAbnLoad();
                        TotalQuantity();
                        SelectSqlData(dsCntVal1, dsCntVal1.tR_Worker, true, " where id = " + Convert.ToInt32(temp["idWorker"]));
                        if (dsCntVal1.tR_Worker.Count > 0)
                            this.Text = "Ввод начислений - специалист расчетного отдела " + dsCntVal1.tR_Worker[0]["F"].ToString() + " " + dsCntVal1.tR_Worker[0]["I"].ToString() + " " + dsCntVal1.tR_Worker[0]["O"].ToString();
                        else
                            this.Text = "Ввод начислений";  // Шумилов А.И. 06.03.2013    нахрена 3 раза один и тот же код????

                        // проверим есть ли документ за текущий период
                        // если нет, то введем его
                        if (dsCntVal1.tG_Doc.Rows.Count > 0)
                        {
                            if (dsCntVal1.tG_Doc[0]["dtPay"].ToString() != CalcDate.ToString())
                            {
                                NewDoc();
                                dgvAbnLoad();
                            }
                        }
                        else
                        {
                            NewDoc();
                            dgvAbnLoad();
                        }
                    }
                }
        }

        // показ счета выбранного документа
        private void dgvAbn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(dgvAbn["Block_dgvAbn", e.RowIndex].Value))
            {
                tbEnter.Enabled = false;
                tbPower.Enabled = false;
                FlagMeterValEdit = 0;
                btnTariffNull.Enabled = false;
            }
            else
            {
                tbEnter.Enabled = true;
                tbPower.Enabled = true;
                FlagMeterValEdit = 1;
                btnTariffNull.Enabled = true;
            }
        }

        // рисуем замочки
        private void dgvAbn_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (dgvAbn.RowCount > 0)
            {
                if (e.ColumnIndex == dgvAbn.Columns["ImageColumn"].Index) // столбец картинки
                {
                    if (Convert.ToBoolean(dgvAbn["Block_dgvAbn", e.RowIndex].Value))
                    {
                        e.Value = imageList.Images["Lock_Closed.png"];
                    }
                    else
                    {
                        e.Value = imageList.Images[""];        // 
                    }
                }
            }
        }

        private void dgvAbn_MouseClick(object sender, MouseEventArgs e)
        {
            dgvObjLoad();
            TotalQuantity();
        }

        private void dgvAbn_KeyDown(object sender, KeyEventArgs e)
        {
//            dgvObjLoad();
        }

        private void dgvAbn_KeyUp(object sender, KeyEventArgs e)
        {
            dgvObjLoad();
            TotalQuantity();
        }

        private void tbParam_Click(object sender, EventArgs e)
        {
            Legal.Forms.Calculat.FormVisualParam frm = new Legal.Forms.Calculat.FormVisualParam(PercentMinus, PercentPlus, CountMonth);
            frm.Owner = this;
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void tbReport_Click(object sender, EventArgs e)
        {
            Legal.Forms.FormRep.FormObjectData frm = new Legal.Forms.FormRep.FormObjectData(ABNID, Dogovor_Type);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }

        }

        private void FormCntVal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.F2: // поиск абонента
                        tbFind.PerformClick();
                        break;
                    case Keys.F7: // поиск абонента расширенный
                        tbFindExtended.PerformClick();
                        break;
                    case Keys.F9: // сводка
                        tbReport.PerformClick();
                        break;
                    default: break;
                }
            }
        }

        private void TotalQuantity()
        {
            if (dgvObj.Rows.Count > 0)
            {
                int QuantityTotal = 0;
                int QuantityTotalNullSum = 0;
                var cars = from car in dsCntVal1.tG_DocSchetTemp.AsEnumerable()
                           group car by car.Tariff;
                foreach (var item in cars)
                {
                    foreach (DataRow r in item)
                    {
                        if ((r["Quantity"] != DBNull.Value) && (r["Summa"] != DBNull.Value) && (r.Field<decimal>("Summa") != 0))
                            QuantityTotal += r.Field<int>("Quantity");
                        if ((r["Quantity"] != DBNull.Value) && (r.Field<decimal>("Summa") == 0))
                            QuantityTotalNullSum += r.Field<int>("Quantity");
                    }
                }
                txtTotalQuantity.Text = QuantityTotal.ToString("# ### ### ###");
                txtTotalQuantityNullSum.Text = QuantityTotalNullSum.ToString("# ### ### ###");
            }
        }

        // найти объект
        private void ObjFind()
        {
            for (int i = 0; i < dgvObj.RowCount; i++)
                if (dgvObj[5, i].FormattedValue.ToString().Contains(CODE))
                {
                    dgvObj.CurrentCell = dgvObj[5, i];
                    return;
                }
        }

        // редактировать примечание к объекту
        private void bEditObjComment_Click(object sender, EventArgs e)
        {
            int dgvObjIndex = dgvObj.CurrentRow.Index;

            Legal.Forms.Object.FormObjEditComment fAdd = new Legal.Forms.Object.FormObjEditComment(Convert.ToInt32(dgvObj.CurrentRow.Cells["idObj_dgvObj"].Value),dgvObj.CurrentRow.Cells["nameObj_dgvObj"].Value.ToString());
            fAdd.SqlSettings = new DataSql.SQLSettings(this.SqlSettings);
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                dgvObjLoad();
                dgvObj.CurrentCell = dgvObj["nameObj_dgvObj", dgvObjIndex];
            }
        }

        private void NewDoc()
        {
            int idDog = -1;
            idDog = Convert.ToInt32(cbDogovor.ComboBox.SelectedValue);
            DataRow r = dsCntVal1.tG_Doc.NewRow();
            r["id"] = -1;
            r["idAbn"] = ABNID;
            r["idDogovor"] = idDog;
            r["Blocking"] = false;
            r["dtPay"] = CalcDate;
            r["dtBank"] = CalcDate.AddMonths(1);
            dsCntVal1.tG_Doc.Rows.Add(r);
            int id;
            id = this.InsertSqlDataOneRow(dsCntVal1, dsCntVal1.tG_Doc);
            if (id < 0)
                MessageBox.Show("Не удалось добавить документ");
        }
        
        // расширенный поиск
        private void tbFindExtended_Click(object sender, EventArgs e)
        {
            FormAbnObjFind f = new FormAbnObjFind(ABNID);
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                tbCode.Text = ABNSELECT.ToString();
                string filterStr = "CodeAbonent = " + tbCode.Text;
                DataRow[] makes = dsCntVal1.tAbn.Select(filterStr);
                if (makes.Length == 0)
                    MessageBox.Show("Абонент не найден...", "Selection error!"); // ничего не найдено 
                else
                {
                    DataRow temp = makes[0];
                    tbName.Text = temp["Name"].ToString();
                    ABNID = Convert.ToInt32(temp["id"]);
                    cbDogovor_Load();
                    dgvAbnLoad();
                    TotalQuantity();
                    SelectSqlData(dsCntVal1, dsCntVal1.tR_Worker, true, " where id = " + Convert.ToInt32(temp["idWorker"]));
                    if (dsCntVal1.tR_Worker.Count > 0)
                        this.Text = "Ввод начислений - специалист расчетного отдела " + dsCntVal1.tR_Worker[0]["F"].ToString() + " " + dsCntVal1.tR_Worker[0]["I"].ToString() + " " + dsCntVal1.tR_Worker[0]["O"].ToString();
                    else
                        this.Text = "Ввод начислений";  // Шумилов А.И. 06.03.2013

                    // проверим есть ли документ за текущий период
                    // если нет, то введем его
                    if (dsCntVal1.tG_Doc.Rows.Count > 0)
                    {
                        if (dsCntVal1.tG_Doc[0]["dtPay"].ToString() != CalcDate.ToString())
                        {
                            NewDoc();
                            dgvAbnLoad();
                        }
                    }
                    else
                    {
                        NewDoc();
                        dgvAbnLoad();
                    }
                }
            }


        }

        private void btnDocCopy_Click(object sender, EventArgs e)
        {
            if (dgvObj.Rows.Count > 0)
            {
                int idDocum = Convert.ToInt32(dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value);
                Calculat.FormDocCopy frm = new Calculat.FormDocCopy(idDocum);
                frm.SqlSettings = this.SqlSettings;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dgvAbnLoad();
                }
            }
        }

        private void btnTariffNull_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите заменить тариф.\nЗаменить тариф?", "",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else
            {
                if (dgvObj.Rows.Count > 0)
                {
                    if ((dgvObj.CurrentRow.Cells["idDocSchet_dgvObj"].Value != DBNull.Value) && ((int)dgvObj.CurrentRow.Cells["idDocSchet_dgvObj"].Value != 0))
                    {
                        int id = Convert.ToInt32(dgvObj.CurrentRow.Cells["idDocSchet_dgvObj"].Value);

                        DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                        try
                        {
                            con.OpenConnection(SqlSettings);

                            string strCmd = "";
                            strCmd = "LegTariffIsNull";
                            SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                            sqlCmd.CommandType = CommandType.StoredProcedure;

                            // параметры
                            SqlParameter p1 = new SqlParameter("@id", id);
                            sqlCmd.Parameters.Add(p1);

                            IDTARIFF = 0;
                            SqlParameter p2 = new SqlParameter("@idTariff", IDTARIFF);
                            sqlCmd.Parameters.Add(p2);

                            TARIFFVALUE = 0;
                            SqlParameter p3 = new SqlParameter("@Tariff", TARIFFVALUE);
                            sqlCmd.Parameters.Add(p3);

                            sqlCmd.CommandTimeout = 0;

                            sqlCmd.ExecuteNonQuery();
                            dgvObjLoad();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.Source);
                        }
                        finally
                        {
                            con.CloseConnection();
                        }
                        dgvObjLoad();
                        MessageBox.Show("Тариф изменен. Пересчитайте пожалуйста сумму ..");

                    }
                }
            }

        }

        private void tbExcel_Schet_Click(object sender, EventArgs e)
        {
            if (dgvObj.Rows.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                // добавляем книгу и лист
                xlApp = new Excel.ApplicationClass();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                int ColCount = dgvObj.Columns.Count;

                // шрифт для всего листа
                xlWorkSheet.get_Range("A:E").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A:E").Font.Size = 10;

                // заголовок таблицы
                xlWorkSheet.get_Range("A4", misValue).Value2 = "Об";
                xlWorkSheet.get_Range("B4", misValue).Value2 = "Суб";
                xlWorkSheet.get_Range("C4", misValue).Value2 = "Объект";
                xlWorkSheet.get_Range("D4", misValue).Value2 = "Тариф";
                xlWorkSheet.get_Range("E4", misValue).Value2 = "Ввод";
                xlWorkSheet.get_Range("F4", misValue).Value2 = "Факт";
                xlWorkSheet.get_Range("G4", misValue).Value2 = "Сумма";

                // установим ширину столбцов
                xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 5;
                xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 5;
                xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 35;
                xlWorkSheet.get_Range("D:D", misValue).ColumnWidth = 12;
                xlWorkSheet.get_Range("E:E", misValue).ColumnWidth = 9;
                xlWorkSheet.get_Range("F:F", misValue).ColumnWidth = 9;
                xlWorkSheet.get_Range("G:G", misValue).ColumnWidth = 12;

                // шрифт для наименования отчета
                xlWorkSheet.get_Range("A1", "G3").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A1", "G3").Font.Bold = true;
                xlWorkSheet.get_Range("A1", "G3").Font.Size = 12;
                xlWorkSheet.get_Range("A4", "G3").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                // наименование отчета
                xlWorkSheet.get_Range("A1", "G1").Merge(misValue);
                xlWorkSheet.get_Range("A1", "G1").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "G1").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "G1").Value2 = "Счет";

                //xlWorkSheet.get_Range("A2", "G2").Merge(misValue);
                //xlWorkSheet.get_Range("A2", "G2").VerticalAlignment = Excel.Constants.xlCenter;
                //xlWorkSheet.get_Range("A2", "G2").HorizontalAlignment = Excel.Constants.xlCenter;
                //xlWorkSheet.get_Range("A2", "G2").Value2 = "за период с " + dtBegin.Value.Date + " по " + dtEnd.Value.Date;

                xlWorkSheet.get_Range("A4", "G4").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A4", "G4").HorizontalAlignment = Excel.Constants.xlCenter;

                // вывод данных в ячейки
                int i = 0;
                int j = 0;
                for (i = 0; i <= dgvObj.RowCount - 1; i++)
                {
                    int k = 0;
                    for (j = 0; j <= dgvObj.ColumnCount - 1; j++)
                    {
                        if (dgvObj.Columns[j].Visible == true)
                        {
                            DataGridViewCell cell = dgvObj[j, i];
                            xlWorkSheet.Cells[i + 5, k + 1] = cell.Value;
                            k = k + 1;
                        }
                    }
                }

                // форматирование данных
                xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "Общий";
                xlWorkSheet.get_Range("D:D", misValue).NumberFormat = "### ##0,000000";
                xlWorkSheet.get_Range("E:E", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("F:F", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("G:G", misValue).NumberFormat = "### ##0,00";
                xlWorkSheet.get_Range("H:H", misValue).NumberFormat = "### ##0,00";

                //
                xlWorkSheet.get_Range(xlWorkSheet.Cells[i + 5, 4], xlWorkSheet.Cells[i + 5, 5]).HorizontalAlignment = Excel.Constants.xlRight;

                //
                xlWorkSheet.get_Range(xlWorkSheet.Cells[4, 1], xlWorkSheet.Cells[i + 5, ColCount]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[4, 1], xlWorkSheet.Cells[i + 5, ColCount]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                //
                //xlWorkSheet.get_Range(xlWorkSheet.Cells[i + 7, 1], xlWorkSheet.Cells[i + 7, ColCount]).Merge(misValue);
                //xlWorkSheet.get_Range(xlWorkSheet.Cells[i + 7, 1], xlWorkSheet.Cells[i + 7, ColCount]).VerticalAlignment = Excel.Constants.xlCenter;
                //xlWorkSheet.get_Range(xlWorkSheet.Cells[i + 7, 1], xlWorkSheet.Cells[i + 7, ColCount]).HorizontalAlignment = Excel.Constants.xlCenter;
                //xlWorkSheet.get_Range(xlWorkSheet.Cells[i + 7, 1], xlWorkSheet.Cells[i + 7, ColCount]).Value2 = "Начальник службы контроля и учета электроэнергии                  Н.В.Исаева";

                //
                xlWorkSheet.PageSetup.LeftMargin = 35;
                xlWorkSheet.PageSetup.RightMargin = 25;
                xlWorkSheet.PageSetup.BottomMargin = 25;
                xlWorkSheet.PageSetup.TopMargin = 25;

                this.Cursor = Cursors.Default;
                xlApp.Visible = true;
            }
            else
                MessageBox.Show("Нет данных для отчета ..");

        }

        private void btnTariffSelect_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выбрать из списка другой тариф?", "",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else
            {
                if (dgvObj.Rows.Count > 0)
                {
                    if ((dgvObj.CurrentRow.Cells["idDocSchet_dgvObj"].Value != DBNull.Value) && ((int)dgvObj.CurrentRow.Cells["idDocSchet_dgvObj"].Value != 0))
                    {

                        int dgvObjIndex = dgvObj.CurrentRow.Index;
                        int id = Convert.ToInt32(dgvObj.CurrentRow.Cells["idDocSchet_dgvObj"].Value);

                        Legal.Forms.Calculat.FormEnterTariff fSel = new Legal.Forms.Calculat.FormEnterTariff();
                        fSel.Owner = this;
                        fSel.SqlSettings = new DataSql.SQLSettings(this.SqlSettings);
                        if (fSel.ShowDialog() == DialogResult.OK)
                        {
                            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                            try
                            {
                                con.OpenConnection(SqlSettings);

                                string strCmd = "";
                                strCmd = "LegTariffIsNull";
                                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                                sqlCmd.CommandType = CommandType.StoredProcedure;

                                // параметры
                                SqlParameter p1 = new SqlParameter("@id", id);
                                sqlCmd.Parameters.Add(p1);

                                SqlParameter p2 = new SqlParameter("@idTariff", IDTARIFF);
                                sqlCmd.Parameters.Add(p2);

                                SqlParameter p3 = new SqlParameter("@Tariff", TARIFFVALUE);
                                sqlCmd.Parameters.Add(p3);

                                sqlCmd.CommandTimeout = 0;

                                sqlCmd.ExecuteNonQuery();
                                // обновим грид с объектами
                                dgvObjLoad();
                                // вернемся на текущую строку
                                dgvObj.CurrentCell = dgvObj["nameObj_dgvObj", dgvObjIndex];

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, ex.Source);
                            }
                            finally
                            {
                                con.CloseConnection();
                            }
 //                           dgvObjLoad();
                            MessageBox.Show("Тариф изменен. Пересчитайте пожалуйста сумму ..");

                        }

                    }
                }
            }
        }

        private void tbLog_Click(object sender, EventArgs e)
        {
            if (dgvObjAll.CurrentRow != null)
            {
                Legal.Forms.Calculat.FormCntVal_Log frm = new Legal.Forms.Calculat.FormCntVal_Log((int)dgvObjAll.CurrentRow.Cells["idObj"].Value, (DateTime)dgvObjAll.CurrentRow.Cells["DateCalc"].Value);
                frm.SqlSettings = this.SqlSettings;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void dgvAbn_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvAbn.Rows[e.RowIndex].Cells["NumberStorno"].Value.ToString() != "")
                ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow ;
        }

        private void UnMetered()
        {
            if ((dgvObj.Rows.Count > 0) && (dgvObj.CurrentRow.Cells["quantity_dgvObj"].Value != DBNull.Value))
            {
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);

                    string strCmd = "";
                    strCmd = "sp_UnMeteredSet";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    // параметры

                    int idAbnObj = -1;
                    if (dgvObj.CurrentRow.Cells["idObj_dgvObj"].Value == DBNull.Value)
                        idAbnObj = 0;
                    else
                        idAbnObj = Convert.ToInt32(dgvObj.CurrentRow.Cells["idObj_dgvObj"].Value);
                    SqlParameter p1 = new SqlParameter("@idAbnObj", idAbnObj);
                    sqlCmd.Parameters.Add(p1);

                    int ModeCalc = Constants.Constants.TypeEnterOff;
                    SqlParameter p2 = new SqlParameter("@ModeCalc", ModeCalc);
                    sqlCmd.Parameters.Add(p2);

                    int idDocum = -1;
                    if (dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value == DBNull.Value)
                        idDocum = 0;
                    else
                        idDocum = Convert.ToInt32(dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value);
                    SqlParameter p3 = new SqlParameter("@idDocum", idDocum);
                    sqlCmd.Parameters.Add(p3);

                    sqlCmd.CommandTimeout = 0;

                    sqlCmd.ExecuteNonQuery();
                    dgvObjLoadAll();

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

        private void UnMetered1(int QuantityUnmetered)
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "sp_UnMeteredSet_1";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                // параметры

                int idAbnObj = -1;
                if (dgvObj.CurrentRow.Cells["idObj_dgvObj"].Value == DBNull.Value)
                    idAbnObj = 0;
                else
                    idAbnObj = Convert.ToInt32(dgvObj.CurrentRow.Cells["idObj_dgvObj"].Value);
                SqlParameter p1 = new SqlParameter("@idAbnObj", idAbnObj);
                sqlCmd.Parameters.Add(p1);

                int ModeCalc = Constants.Constants.TypeMeterOff;
                SqlParameter p2 = new SqlParameter("@ModeCalc", ModeCalc);
                sqlCmd.Parameters.Add(p2);

                int idDocum = -1;
                if (dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value == DBNull.Value)
                    idDocum = 0;
                else
                    idDocum = Convert.ToInt32(dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value);
                SqlParameter p3 = new SqlParameter("@idDocum", idDocum);
                sqlCmd.Parameters.Add(p3);

                SqlParameter p4 = new SqlParameter("@QuantityUnmetered", QuantityUnmetered);
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

        private void CrossFlow()
        {
            if ((dgvObj.Rows.Count > 0) && (dgvObj.CurrentRow.Cells["quantity_dgvObj"].Value != DBNull.Value))
            {
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);

                    string strCmd = "";
                    strCmd = "sp_UnMeteredSet";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    // параметры

                    int idAbnObj = -1;
                    if (dgvObj.CurrentRow.Cells["idObj_dgvObj"].Value == DBNull.Value)
                        idAbnObj = 0;
                    else
                        idAbnObj = Convert.ToInt32(dgvObj.CurrentRow.Cells["idObj_dgvObj"].Value);
                    SqlParameter p1 = new SqlParameter("@idAbnObj", idAbnObj);
                    sqlCmd.Parameters.Add(p1);

                    int ModeCalc = -1;
                    if (dgvObj.CurrentRow.Cells["modeCalc_dgvObj"].Value == DBNull.Value)
                        ModeCalc = 0;
                    else
                        ModeCalc = Convert.ToInt32(dgvObj.CurrentRow.Cells["modeCalc_dgvObj"].Value);
                    switch (ModeCalc)
                    {
                        case Constants.Constants.TypeEnter:
                            ModeCalc = Constants.Constants.TypeEnterСrossFlow;
                            break;
                        case Constants.Constants.TypeEnterСrossFlow:
                            ModeCalc = Constants.Constants.TypeEnter;
                            break;
                        case Constants.Constants.TypeMeter:
                            ModeCalc = Constants.Constants.TypeMeterCrossFlow;
                            break;
                        case Constants.Constants.TypeMeterCrossFlow:
                            ModeCalc = Constants.Constants.TypeMeter;
                            break;
                    }

                    SqlParameter p2 = new SqlParameter("@ModeCalc", ModeCalc);
                    sqlCmd.Parameters.Add(p2);

                    int idDocum = -1;
                    if (dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value == DBNull.Value)
                        idDocum = 0;
                    else
                        idDocum = Convert.ToInt32(dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value);
                    SqlParameter p3 = new SqlParameter("@idDocum", idDocum);
                    sqlCmd.Parameters.Add(p3);

                    sqlCmd.CommandTimeout = 0;

                    sqlCmd.ExecuteNonQuery();
                    dgvObjLoad();
                    dgvObjLoadAll();

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

        // поиск объекта
        private void tbFindObject_Click(object sender, EventArgs e)
        {
            int DogID = Convert.ToInt32(cbDogovor.ComboBox.SelectedValue);
            int ObjActive = Convert.ToInt32(cbObj.SelectedIndex);
            int idDocum = Convert.ToInt32(dgvAbn.CurrentRow.Cells["id_dgvAbn"].Value);

            FormFindObject f = new FormFindObject(DogID, ObjActive, idDocum);
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dgvObj.RowCount; i++)
                    if (Convert.ToInt32(dgvObj.Rows[i].Cells["idObj_dgvObj"].Value) == OBJSELECT)
                    {
                        dgvObj.CurrentCell = dgvObj[5, i];
                    }

            }
        }

        private void cbTypeEnergy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeEnergy.SelectedIndex > 0)
            {
                result = MessageBox.Show("Вы действительно хотитие изменить тип начисления?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    cbTypeEnergy.SelectedIndex = 0;

                }
                else
                {
                    cbTypeEnergy.ForeColor = Color.Red;
                }
            }
            else
            {
                cbTypeEnergy.ForeColor = System.Drawing.SystemColors.WindowText; 
            }


        }

        private void tbLast_Click(object sender, EventArgs e)
        {
            if (cbObj.SelectedIndex > 0)
            {
                MessageBox.Show("Ввод начислений возможен только в режиме <активные объекты>");
                return;
            }
            if (dgvObj.Rows.Count > 0)
            {
                int prm = -1;
                if (dsCntVal1.tG_SchetAll.Rows.Count > 0)
                    if (dsCntVal1.tG_SchetAll[0]["Quantity"] != DBNull.Value)
                        prm = Convert.ToInt32(dgvObjAll.CurrentRow.Cells["Quantity"].Value);
                    else
                        prm = 0;
                else
                    prm = 0;

                //if ((dgvObj.CurrentRow.Cells["quantityCalc_dgvObj"].Value == DBNull.Value) ||
                //    ((int)dgvObj.CurrentRow.Cells["quantityCalc_dgvObj"].Value == 0))
                //{
                //    prm = 0;
                //    // если для этого субобъекта уже есть начисление в другом абоненте
                //    if ((dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idObjParent"] != DBNull.Value) &&
                //        ((decimal)dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value == 0))
                //    {
                //        // проверяем есть ли этот же объект, который рассчитывается по ненулевому тарифу
                //        int id = Convert.ToInt32(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idObj"]);
                //        SelectSqlData(dsCntVal1.tAbnObjReg, true, "where idAbnObjSame = " + id + " order by DateChange desc", null, false, 1);

                //        if (dsCntVal1.tAbnObjReg.Rows.Count > 0)
                //        {
                //            int idFind = Convert.ToInt32(dsCntVal1.tAbnObjReg.Rows[0]["idAbnObj"]);
                //            // ищем начисление для найденного объекта за текущий период
                //            DateTime DateCalc = Convert.ToDateTime(dsCntVal1.tG_Doc[dgvAbn.CurrentRow.Index]["dtPay"]);
                //            DateCalc = new DateTime(DateCalc.Year, DateCalc.Month, 1);
                //            SelectSqlData(dsCntVal1, dsCntVal1.tG_DocSchet, true, "where idAbnObj = " + idFind + " and dtCalc = '" + DateCalc.Date.ToString("yyyyMMdd") + "'");

                //            if (dsCntVal1.tG_DocSchet.Rows.Count > 0)

                //                if (dsCntVal1.tG_DocSchet[0]["QuantityCalc"] != DBNull.Value)
                //                    prm = Convert.ToInt32(dsCntVal1.tG_DocSchet[0]["QuantityCalc"]);
                //        }
                //    }

                //}
                //else
                //    // существующее значение Quantity
                //    prm = Convert.ToInt32(dgvObj.CurrentRow.Cells["quantityCalc_dgvObj"].Value);

                FormCntValEnter f = new FormCntValEnter(prm);
                f.Owner = this;
                f.SqlSettings = this.SqlSettings;
                // ввод нового значения
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // запомним текущую строку в гриде
                    int idRowCur = Convert.ToInt32(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idObj"].ToString());

                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["QuantityCalc"] = valQuantity;
                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["ModeCalc"] = Constants.Constants.TypeEnter;
                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = valQuantity;
                    if (dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value)
                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * valQuantity;
                    else
                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                    // запись на сервер
                    quantitySet();

                    // суммируем все введенные кВт*ч по всем субчикам данного объекта
                    int QuantityTotal = 0;
                    int Parent;
                    if (dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value == DBNull.Value || Convert.ToInt32(dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value) == 0)
                    {
                        // объект
                        Parent = (int)dgvObj.CurrentRow.Cells["idObj_dgvObj"].Value;
                        for (int i = 0; i < dgvObj.Rows.Count; i++)
                            // ищем субчиков к этому объекту
                            if ((dgvObj.Rows[i].Cells["idObjParent_dgvObj"].Value != DBNull.Value) && ((int)dgvObj.Rows[i].Cells["idObjParent_dgvObj"].Value == Parent))
                            {
                                // если субчик рассчитывается как доля от родителя
                                if ((dgvObj.Rows[i].Cells["CommonPercent"].Value != DBNull.Value) || (dgvObj.Rows[i].Cells["CommonValue"].Value != DBNull.Value))
                                {
                                    // делаем субчика текущим 
                                    dgvObj.CurrentCell = dgvObj.Rows[i].Cells["QuantityCalc_dgvObj"];
                                    int tmpVal = 0;
                                    if (dgvObj.Rows[i].Cells["CommonPercent"].Value != DBNull.Value)
                                        tmpVal = (valQuantity * Convert.ToInt32(dgvObj.Rows[i].Cells["CommonPercent"].Value)) / 100;
                                    if (dgvObj.Rows[i].Cells["CommonValue"].Value != DBNull.Value)
                                        tmpVal = (int)dgvObj.Rows[i].Cells["CommonValue"].Value;
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["QuantityCalc"] = tmpVal;
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["ModeCalc"] = Constants.Constants.TypeEnter;
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = tmpVal;
                                    if (dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value)
                                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * tmpVal;
                                    else
                                        dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                                    // запись на сервер
                                    quantitySet();
                                }
                            }
                        // возврат к родителю
                        for (int i = 0; i < dgvObj.Rows.Count; i++)
                        {
                            if ((int)dgvObj.Rows[i].Cells["idObj_dgvObj"].Value == idRowCur)
                            {
                                dgvObj.CurrentCell = dgvObj.Rows[i].Cells["QuantityCalc_dgvObj"];
                            }
                        }
                    }

                    else
                        Parent = (int)dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value;

                    string filterStr = "idObjParent = " + Parent.ToString();
                    DataRow[] makes = dsCntVal1.tG_DocSchetTemp.Select(filterStr);
                    for (int i = 0; i < makes.Length; i++)
                    {
                        DataRow tmp = makes[i];
                        if (tmp["QuantityCalc"] != DBNull.Value)
                            QuantityTotal += (int)tmp["QuantityCalc"];
                    }

                    // объект
                    if (dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value == DBNull.Value || Convert.ToInt32(dgvObj.CurrentRow.Cells["idObjParent_dgvObj"].Value) == 0)
                    {
                        if ((dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idTariff"] != DBNull.Value) && (Convert.ToInt32(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idTariff"]) != 0))
                        {
                            if (QuantityTotal != 0)
                            {
                                // уменьшаем начисление объекта на сумму начислений субчиков
                                dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = valQuantity - QuantityTotal;
                                if ((dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value) && (Convert.ToDecimal(dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value) != 0))
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * (valQuantity - QuantityTotal);
                                else
                                    dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                            }
                        }
                    }
                    // субобъект
                    else
                    {
                        // делаем строку с родительским объектом текущей
                        for (int i = 0; i < dgvObj.Rows.Count; i++)
                        {
                            if ((int)dgvObj.Rows[i].Cells["idObj_dgvObj"].Value == Parent)
                            {
                                dgvObj.CurrentCell = dgvObj.Rows[i].Cells["QuantityCalc_dgvObj"];
                            }
                        }
                        if ((dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idTariff"] != DBNull.Value) && (Convert.ToInt32(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["idTariff"]) != 0))
                        {
                            // изменяем расход и сумму у родительского объекта
                            if (dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["QuantityCalc"] != DBNull.Value)
                                valQuantity = (int)dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["QuantityCalc"];
                            else
                                valQuantity = 0;
                            dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Quantity"] = valQuantity - QuantityTotal;
                            if (dgvObj.CurrentRow.Cells["tariff_dgvObj"].Value != DBNull.Value)
                                dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = Convert.ToDecimal(dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Tariff"].ToString()) * (valQuantity - QuantityTotal);
                            else
                                dsCntVal1.tG_DocSchetTemp[dgvObj.CurrentRow.Index]["Summa"] = 0;
                        }
                    }
                    // запись на сервер
                    quantitySet();
                }
            }

        }



   


    }
}
