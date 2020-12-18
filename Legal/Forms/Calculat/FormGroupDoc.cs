using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Xml;
using System.ComponentModel;
using System.Collections.Generic;


namespace Legal.Forms.Calculat
{

    public partial class FormGroupDoc : FormLbr.FormBase
    {

        private decimal Tax;

        // 21.01.2019
        private decimal Tax20;
        private DateTime TaxDate;
        
        private int RowsCheck;

        public FormGroupDoc()
        {
            InitializeComponent();
            Tax = (decimal)(Constants.Constants.TaxRate18 / 100.0);
            // 21.01.2019
            Tax20 = (decimal)(Constants.Constants.TaxRate20 / 100.0);
            TaxDate = new DateTime(2019, 1, 1);
        }

        private void FormGroupDoc_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsCntVal1, dsCntVal1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsCntVal1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCntVal1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsCntVal1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCntVal1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);
            f_Bank.Checked = true;
            dtSchetFact.Value = new DateTime((int)dsCntVal1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCntVal1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);
            dtBank.Value = new DateTime((int)dsCntVal1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCntVal1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);

            // виды платежа
            f_PaymentSelect_Load();
            f_Payment.Text = f_PaymentSelect.Text + ", за " + dtEnd.Value.ToString("MMMM") + " " + dtEnd.Value.Date.Year + "г.";
            // документы по тарифам
            f_TariffLegal_Load();
            // загрузка контролеров
            this.SelectSqlData(dsCntVal1, dsCntVal1.Tables["vWorkerGroup"], true,
                " where idgroup = " + Constants.Constants.WorkerGroupControlerUL + " order by fio ");
            for (int i = 0; i < dsCntVal1.vWorkerGroup.Rows.Count; i++)
            {
                clbSpecialist.Items.Add(new myList(dsCntVal1.vWorkerGroup[i]["id"].ToString(),dsCntVal1.vWorkerGroup[i]["FIO"].ToString()));
            }
            // загрузка банковских дней
            InitCmbDays();
            // виды энергии
            f_TypeOfEnergy_Load();

            cmbList.SelectedIndex = 0;

        }

        // показ счетов
        private void btnOK_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "Счета";
            dgvLoad(1);
        }

        // просмотр документов
        private void btnShow_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "Документы";
            dgvLoad(2);
        }

        // окончательное формирование документов с их закрытием для редактирования
        private void btnFormDoc_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "Счета")
            {
                DateTime DateBank = (DateTime)dtBank.Value.Date;
                DateTime DateFact = (DateTime)dtSchetFact.Value.Date;
                string Payment = f_Payment.Text;
                int Base = (int)f_TariffLegal.SelectedValue;

                for (int i = 0; i < dgvDocList.RowCount; i++)
                {
                    if (dgvDocList.Rows[i].Cells["SelectCell"].Value != null)
                    {
                        if ((bool)dgvDocList.Rows[i].Cells["SelectCell"].Value == true & (Convert.ToDecimal(dgvDocList.Rows[i].Cells["sumRealiz"].Value) != 0) )
                            //& (dgvDocList.Rows[i].Cells["NumberStorno"].Value == DBNull.Value))
                        {
                            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                            try
                            {
                                con.OpenConnection(SqlSettings);

                                string strCmd = "";
                                strCmd = "sp_LegDocSave";
                                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                                sqlCmd.CommandType = CommandType.StoredProcedure;

                                // параметры

                                int idDoc = Convert.ToInt32(dgvDocList.Rows[i].Cells["idDoc"].Value);
                                SqlParameter p1 = new SqlParameter("@idDoc", idDoc);
                                sqlCmd.Parameters.Add(p1);

                                int Quantity = Convert.ToInt32(dgvDocList.Rows[i].Cells["quantity"].Value);
                                SqlParameter p3 = new SqlParameter("@Quantity", Quantity);
                                sqlCmd.Parameters.Add(p3);

                                decimal SumRealiz = Convert.ToDecimal(dgvDocList.Rows[i].Cells["sumRealiz"].Value);
                                SqlParameter p4 = new SqlParameter("@SumRealiz", SumRealiz);
                                sqlCmd.Parameters.Add(p4);

                                decimal SumNalog = Convert.ToDecimal(dgvDocList.Rows[i].Cells["sumNalog"].Value);
                                SqlParameter p5 = new SqlParameter("@SumNalog", SumNalog);
                                sqlCmd.Parameters.Add(p5);

                                decimal SumTotal = Convert.ToDecimal(dgvDocList.Rows[i].Cells["sumTotal"].Value);
                                SqlParameter p6 = new SqlParameter("@SumTotal", SumTotal);
                                sqlCmd.Parameters.Add(p6);

                                SqlParameter p7 = new SqlParameter("@Payment", Payment);
                                sqlCmd.Parameters.Add(p7);

                                SqlParameter p8 = new SqlParameter("@Base", Base);
                                sqlCmd.Parameters.Add(p8);

                                // если договор по передаче нужна дата счет-фактуры и номер
                                SqlParameter p9;
                                if (Convert.ToInt32(dgvDocList.Rows[i].Cells["idDocType"].Value) == 501)
                                {
                                    // если нужно печатать документы в банк
                                    SqlParameter p2;
                                    if (f_Bank.Checked == true)
                                        p2 = new SqlParameter("@DateBank", DateBank.ToString("yyyyMMdd"));
                                    else
                                        p2 = new SqlParameter("@DateBank", DBNull.Value);
                                    sqlCmd.Parameters.Add(p2);

                                    p9 = new SqlParameter("@DateFact", DateFact.ToString("yyyyMMdd"));
                                    sqlCmd.Parameters.Add(p9);

                                    SqlParameter p10;
                                    SqlParameter p11;

                                    int NumberSchetFact = 0;
                                    int SchetFactType = 572;

                                    // если номер счет-фактуры уже введен
                                    if (dgvDocList.Rows[i].Cells["NumberSchetFact"].Value != DBNull.Value)
                                    {
                                        NumberSchetFact = Convert.ToInt32(dgvDocList.Rows[i].Cells["NumberSchetFact"].Value);
                                        p10 = new SqlParameter("@NumberSchetFact", NumberSchetFact);
                                        sqlCmd.Parameters.Add(p10);
                                        p11 = new SqlParameter("@SchetFactType", SchetFactType);
                                        sqlCmd.Parameters.Add(p11);
                                    }
                                    else
                                    {
                                        NumberSchetFact = GetFactNumber(572, DateFact.Year, DateFact.Month);
                                        if (NumberSchetFact != -1)
                                        {
                                            p10 = new SqlParameter("@NumberSchetFact", NumberSchetFact);
                                            sqlCmd.Parameters.Add(p10);
                                            p11 = new SqlParameter("@SchetFactType", SchetFactType);
                                            sqlCmd.Parameters.Add(p11);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Не удается получить номер счет- фактуры");
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    p9 = new SqlParameter("@DateFact", DBNull.Value);
                                    sqlCmd.Parameters.Add(p9);
                                    SqlParameter p10 = new SqlParameter("@NumberSchetFact", DBNull.Value);
                                    sqlCmd.Parameters.Add(p10);
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
                    }
                }
            }
            dgvLoad(1);
            // загрузка банковских дней
            InitCmbDays();
        }

        private void InitCmbDays()
        {
            DataTable dt = new DataTable("tG_Doc");
            dt.Columns.Add("dtBank", typeof(DateTime));

            cbxDays.DataSource = dt;
            cbxDays.DisplayMember = "dtBank";
            cbxDays.ValueMember = "dtBank";

            this.SelectSqlData(dt, true, " order by dtBank desc", null, true);
        }

        // убрать блокировку документа
        private void btnDocClear_Click(object sender, EventArgs e)

        {
            if (txtTitle.Text == "Документы")
            {
                for (int i = 0; i < dgvDocList.RowCount; i++)
                {
                    if (dgvDocList.Rows[i].Cells["SelectCell"].Value != null)
                    {
                        if (((bool)dgvDocList.Rows[i].Cells["SelectCell"].Value == true) & ((bool)dgvDocList.Rows[i].Cells["Blocking"].Value == true) & (dgvDocList.Rows[i].Cells["NumberStorno"].Value == DBNull.Value))
                        {
                            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                            try
                            {
                                con.OpenConnection(SqlSettings);

                                string strCmd = "";
                                strCmd = "sp_LegDocClear";
                                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                                sqlCmd.CommandType = CommandType.StoredProcedure;

                                // параметры

                                int idDoc = Convert.ToInt32(dgvDocList.Rows[i].Cells["idDoc"].Value);
                                SqlParameter p1 = new SqlParameter("@idDoc", idDoc);
                                sqlCmd.Parameters.Add(p1);

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
            }
            dgvLoad(2);
        }

        // загрузка грида документами 
        private void dgvLoad(int prm)
        {
            // prm = 1 показ счетов
            // prm = 2 показ документов
            // prm = 3 печать

            dsCntVal1.vG_Doc.Rows.Clear();
            // условия
            # region
            string txtWhere = "";
            // условие для контролеров
            string txtWhereWorker = BuildWhereContrl();
            txtWhere += txtWhereWorker;

            // условие для даты
            string txtWhereDate = "";
            if (prm == 3)
            {
                DateTime BANKDAY = (DateTime)cbxDays.SelectedValue;
                txtWhereDate = "dtBank = '" + ((DateTime)cbxDays.SelectedValue).Date.ToString("yyyyMMdd") + "'";
                if (txtWhere != "")
                    txtWhere += " and " + txtWhereDate;
                else
                    txtWhere += txtWhereDate;
            }
            else
                txtWhereDate = BuildWhereDate();
                if (txtWhere != "")
                    txtWhere += " and " + txtWhereDate;
                else
                    txtWhere += txtWhereDate;

            // документы или печать
            if (prm != 1)
                txtWhere += " and (Blocking != 0)";

            // условие для выбора вида начисления
            string txtWhereEnergy = "";
            // счета
            if (prm == 1)
                txtWhereEnergy = f_TypeOfEnergy.SelectedValue.ToString();

            // печать в банк только для потребителей имеющих расчетный счет в банке
            if (prm == 3)
                txtWhere += " and (BankID IS NOT NULL and BankAcnt IS NOT NULL)";

            # endregion

            if (prm != 1)
                    // документы и печать
                    SelectSqlData(dsCntVal1, dsCntVal1.vG_Doc, true, "where " + txtWhere + " order by codeabonent");
            else
            {
                // счета
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);

                    string strCmd = "";
                    strCmd = "select * from fn_LegDocSum1(@txtWhereEnergy, @Tax) where " + txtWhere + " order by codeabonent";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                    SqlParameter p1 = new SqlParameter("@txtWhereEnergy", txtWhereEnergy);
                    sqlCmd.Parameters.Add(p1);

                    SqlParameter p2;
                    if (Convert.ToDateTime(dtEnd.Value) >= TaxDate)
                        p2 = new SqlParameter("@Tax", Tax20);
                    else
                        p2 = new SqlParameter("@Tax", Tax);

                    sqlCmd.Parameters.Add(p2);

                    sqlCmd.CommandTimeout = 0;

                    SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                    dAdapt.Fill(dsCntVal1, "vG_Doc");

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

            // ставим замочки
            #region
            for (int i = 0; i < dgvDocList.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvDocList.Rows[i].Cells["Blocking"].Value))
                {
                    dgvDocList.Rows[i].Cells["ImageColumn"].Value = imageList1.Images["1306739721_lock.png"];
                }
                else
                {
                    dgvDocList.Rows[i].Cells["ImageColumn"].Value = imageList1.Images["1306739729_lock_open.png"];
                }
            }
            #endregion

            dgvDocList.Refresh();
            txtRowsCount.Text = dgvDocList.RowCount.ToString();
        }

        // условие для контролеров
        private string BuildWhereContrl()
        {
            string whereContrl = "";
            if ((clbSpecialist.CheckedItems.Count <= 0) || (clbSpecialist.CheckedItems.Count == clbSpecialist.Items.Count))
                return whereContrl;
            else
            {
                for (int i = 0; i <= (clbSpecialist.CheckedItems.Count) - 1; i++)
                {
                    myList mylist = (myList)clbSpecialist.CheckedItems[i];
                    whereContrl += mylist.Id + ",";
                }
                whereContrl = "(idWorker in (" + whereContrl.Remove(whereContrl.Length - 1) + "))";
                return whereContrl;
            }
        }

        // условие для даты
        private string BuildWhereDate()
        {
            string txtWhereDate = "";
            if (txtWhereDate != "")
                txtWhereDate += " and (dtPay >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                    " (dtPay <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
            else
                txtWhereDate += " (dtPay >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                    " (dtPay <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
            return txtWhereDate;
        }

        public class myList
        {
            private string id, name;
            public string Id
            {
                get { return id; }
            }
            public myList(string id, string name)
            {
                this.id = id;
                this.name = name;
            }
            public override string ToString()
            {
                return name;
            }
        }

        // выбрать все документы
        private void btnCheck_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i < dgvDocList.RowCount; i++)
            {
                //if (dgvDocList.Rows[i].Cells["idDocType"].Value.ToString() == "533")
                //{
                    dgvDocList.Rows[i].Cells["SelectCell"].Value = true;
                    txtRowsCheck.Text = dgvDocList.RowCount.ToString();
                    RowsCheck = (int)dgvDocList.RowCount;
                //}
            }
            Cursor.Current = Cursors.Default;
        }

        // отменить выбор
        private void btnUncheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDocList.RowCount; i++)
            {
                dgvDocList.Rows[i].Cells["SelectCell"].Value = false;
                txtRowsCheck.Text = "";
                RowsCheck = 0;
            }
        }
        
        // загрузка оснований
        private void f_TariffLegal_Load()
        {
            int idType = 565;
            SelectSqlDataTableOther(dsCntVal1, dsCntVal1.tR_Classifier1, "tR_Classifier", true, " where ParentID = " + idType.ToString() + "order by id desc");
        }

        // загрузка видов платежа
        private void f_PaymentSelect_Load()
        {
            int idType = 560;
            SelectSqlData(dsCntVal1, dsCntVal1.tR_Classifier, true, " where ParentID = " + idType.ToString());
            f_PaymentSelect.SelectedValue = 561;
        }

        // формирование вида платежа
        private void f_PaymentSelect_TextChanged_1(object sender, EventArgs e)
        {
            f_Payment.Text = f_PaymentSelect.Text + ", за " + dtEnd.Value.ToString("MMMM") + " " + dtEnd.Value.Date.Year + "г.";
        }
        private void f_PaymentSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            f_Payment.Text = f_PaymentSelect.Text + ", за " + dtEnd.Value.ToString("MMMM") + " " + dtEnd.Value.Date.Year + "г.";
        }

        // формирование видов начислений
        private void f_TypeOfEnergy_Load()
        {
            int idType = 542;
            SelectSqlDataTableOther(dsCntVal1, dsCntVal1.tR_Classifier2, "tR_Classifier", true, " where ParentID = " + idType.ToString());
            f_TypeOfEnergy.SelectedValue = 543;
        }

        // хрен его знает для чего
        private void dgvDocList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex == -1)
            {
                e.PaintBackground(e.ClipBounds, false);
                Point pt = e.CellBounds.Location;  // where you want the bitmap in the cell 
                int offset = (e.CellBounds.Width - this.imageList1.ImageSize.Width) / 2;
                pt.X += offset;
                pt.Y += 1;
                this.imageList1.Draw(e.Graphics, pt, 0);
                e.Handled = true;
            }
        }

        // считаем количество выбранных документов
        private void dgvDocList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                if ((bool)dgvDocList.Rows[e.RowIndex].Cells[0].Value == true)
                    RowsCheck = RowsCheck + 1;
                else
                    RowsCheck = RowsCheck - 1;
            }
            txtRowsCheck.Text = RowsCheck.ToString();

        }

        // показать счет документа
        private void btnSchetShow_Click(object sender, EventArgs e)
        {
            //if (txtTitle.Text != "Счета")
            //{
                if (dgvDocList.RowCount > 0)
                {
                    int idDocum = Convert.ToInt32(dgvDocList.CurrentRow.Cells["idDoc"].Value);
                    FormGroupDocSchet frm = new FormGroupDocSchet(idDocum);
                    frm.SqlSettings = this.SqlSettings;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                    }
                }
            //}
        }

        // показать все документы за выбранный банковский день
        private void btnBankDaysShow_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "Печать";
            dgvLoad(3);
        }

        // просмотр реестров
        private void btnPrintRegister_Click(object sender, EventArgs e)
        {
            DateTime BANKDAY = (DateTime)cbxDays.SelectedValue;
            Legal.Forms.FormRep.FormRegisterPrint frm = new Legal.Forms.FormRep.FormRegisterPrint(BANKDAY);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        // принудительно завершить редактирование ячейки(галочки)
        private void dgvDocList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgvDocList.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        // просмотр требований
        private void btnPrintBankReq_Click(object sender, EventArgs e)
        {
            DateTime BANKDAY = (DateTime)cbxDays.SelectedValue;
            Legal.Forms.FormRep.FormBankReqPrint frm = new Legal.Forms.FormRep.FormBankReqPrint(BANKDAY);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        // просмотр счетов
        private void btnPrintSchet_Click(object sender, EventArgs e)
        {
            DateTime BANKDAY = (DateTime)cbxDays.SelectedValue;
            Legal.Forms.FormSchetPrint frm = new Legal.Forms.FormSchetPrint(BANKDAY);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        // просмотр счетов-фактур
        private void btnPrintSchetFact_Click(object sender, EventArgs e)
        {
            DateTime BANKDAY = (DateTime)cbxDays.SelectedValue;
            Legal.Forms.FormRep.FormFactPrint frm = new Legal.Forms.FormRep.FormFactPrint(BANKDAY);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        // просмотр актов
        private void btnPrintAct_Click(object sender, EventArgs e)
        {
            DateTime BANKDAY = (DateTime)cbxDays.SelectedValue;
            //DateTime BANKDAY = new DateTime(2012, 1, 1);

            Legal.Forms.FormRep.FormActPrint frm = new Legal.Forms.FormRep.FormActPrint(BANKDAY);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        // просмотр накладных
        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            DateTime BANKDAY = (DateTime)cbxDays.SelectedValue;
            Legal.Forms.FormRep.FormInvPrint frm = new Legal.Forms.FormRep.FormInvPrint(BANKDAY);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        // формирование печатных форм
        private void brnDocPrint_Click_1(object sender, EventArgs e)
        {
            if (txtTitle.Text == "Печать")
            {
                Cursor.Current = Cursors.WaitCursor;

                // удалим все печатные формы за выбранный банковский день
                DelDocPrint();

                // формируем список документов для печати
                string xmlRoles = "";
                int cnt = 0;
                for (int i = 0; i < dgvDocList.RowCount; i++)
                {
                    if (dgvDocList.Rows[i].Cells["SelectCell"].Value != null)
                    {
                        // отмеченный документ
                        if ((bool)dgvDocList.Rows[i].Cells["SelectCell"].Value == true)
                        {
                            int idDocum = (int)dgvDocList.Rows[i].Cells["idDoc"].Value;
                            xmlRoles = xmlRoles + idDocum.ToString() + " ";
                            cnt++;
                        }
                    }
                }

                if (cnt > 0)
                {
                    DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                    try
                    {
                        con.OpenConnection(SqlSettings);

                        string strCmd = "";
                        strCmd = "LegDocPrint";
                        SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        sqlCmd.Parameters.Add(new SqlParameter("@ListID", SqlDbType.Text));
                        sqlCmd.Parameters["@ListID"].Value = xmlRoles;

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

                Cursor.Current = Cursors.Default;
            }
        }

        // сдвинуть период вперед
        private void btnPlus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(1).AddDays(-1);
        }

        // сдвинуть период назад
        private void btnMinus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(-1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(-1).AddDays(-1);
        }

        // не используется
        private void dgvDocList_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (dgvDocList.RowCount > 0)
            {
                if (e.ColumnIndex == dgvDocList.Columns["ImageColumn"].Index) // столбец картинки
                {
                    if (Convert.ToBoolean(dgvDocList["Blocking", e.RowIndex].Value))
                    {
                        e.Value = imageList1.Images["1306739721_lock.png"];
                    }
                    else
                    {
                        e.Value = imageList1.Images["1306739729_lock_open.png"];
                    }
                }
            }
        }

        // удалить все печатные формы за выбранный банковский день
        private void btnDelBankDay_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DelDocPrint();
            Cursor.Current = Cursors.Default;
        }

        private void DelDocPrint()
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "LegDocPrintDelete";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                DateTime DateBank = (DateTime)cbxDays.SelectedValue;
                SqlParameter p = new SqlParameter("@DateBank", DateBank.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p);

                sqlCmd.CommandTimeout = 0;

                Cursor.Current = Cursors.WaitCursor;

                sqlCmd.ExecuteNonQuery();

                Cursor.Current = Cursors.Default;

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

        // изменить банковский день у выбранных документов
        private void btnBankDateChange_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (txtTitle.Text == "Документы")
            {
                for (int i = 0; i < dgvDocList.RowCount; i++)
                {
                    if (dgvDocList.Rows[i].Cells["SelectCell"].Value != null)
                    {
                        if (((bool)dgvDocList.Rows[i].Cells["SelectCell"].Value == true) & ((bool)dgvDocList.Rows[i].Cells["Blocking"].Value == true))
                        {
                            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                            try
                            {
                                con.OpenConnection(SqlSettings);

                                string strCmd = "";
                                strCmd = "sp_LegBankDateChange";
                                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                                sqlCmd.CommandType = CommandType.StoredProcedure;

                                DateTime DateBank = (DateTime)dtBank.Value.Date;
                                int idDoc = Convert.ToInt32(dgvDocList.Rows[i].Cells["idDoc"].Value);

                                SqlParameter p1 = new SqlParameter("@idDoc", idDoc);
                                sqlCmd.Parameters.Add(p1);

                                SqlParameter p2 = new SqlParameter("@DateBank", DateBank.ToString("yyyyMMdd"));
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
                    }
                }
            }
            dgvLoad(2);
            Cursor.Current = Cursors.WaitCursor;
        }

        // показать документ
        private void btnDocShow_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "Счета")
            {
                if (dgvDocList.RowCount > 0)
                {
                    int idDocum = Convert.ToInt32(dgvDocList.CurrentRow.Cells["idDoc"].Value);
                    FormAbnCalc frm = new FormAbnCalc(idDocum);
                    frm.SqlSettings = this.SqlSettings;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                    }
                }
            }
        }

        // экспорт счетов для Ульяновскэнерго
        private void btnExportUlenergo_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "Документы")
            {
                Cursor.Current = Cursors.WaitCursor;

                // удалим все счета
                DelDocPrint1();

                // формируем список документов для печати
                string xmlRoles = "";
                int cnt = 0;
                for (int i = 0; i < dgvDocList.RowCount; i++)
                {
                    int idDocum = (int)dgvDocList.Rows[i].Cells["idDoc"].Value;
                    xmlRoles = xmlRoles + idDocum.ToString() + " ";
                    cnt++;
                }

                if (cnt > 0)
                {
                    DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                    try
                    {
                        con.OpenConnection(SqlSettings);

                        string strCmd = "";
                        strCmd = "LegDocPrint1";
                        SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        sqlCmd.Parameters.Add(new SqlParameter("@ListID", SqlDbType.Text));
                        sqlCmd.Parameters["@ListID"].Value = xmlRoles;

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

                Cursor.Current = Cursors.Default;
            }
        }

        // удаление счетов для Ульяновскэнерго
        private void DelDocPrint1()
        {
            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "LegDocPrintDelete1";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                DateTime DateBank = new DateTime(2012, 1, 1);
                SqlParameter p = new SqlParameter("@DateBank", DateBank.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p);

                sqlCmd.CommandTimeout = 0;

                Cursor.Current = Cursors.WaitCursor;

                sqlCmd.ExecuteNonQuery();

                Cursor.Current = Cursors.Default;

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
        
        // печать счетов для Ульяновскэнерго
        private void btnPrintUlenergo_Click(object sender, EventArgs e)
        {
            DateTime BANKDAY = new DateTime(2012, 1, 1);
            Legal.Forms.FormSchetPrint frm = new Legal.Forms.FormSchetPrint(1,BANKDAY);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void dgvDocList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (txtTitle.Text != "Печать")
            {
                if (dgvDocList.Rows[e.RowIndex].Cells["idDocType"].Value.ToString() != "533")
                {
                    ((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
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

        private void btnFactPrintPeriod_Click(object sender, EventArgs e)
        {
                Cursor.Current = Cursors.WaitCursor;

                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);

                    string strCmd = "";
                    strCmd = "LegFactPeriod";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    // параметры
                    DateTime BeginPeriod = dtBegin.Value.Date;
                    SqlParameter p1 = new SqlParameter("@BeginPeriod", BeginPeriod);
                    sqlCmd.Parameters.Add(p1);

                    DateTime EndPeriod = dtEnd.Value.Date;
                    SqlParameter p2 = new SqlParameter("@EndPeriod", EndPeriod);
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

                Cursor.Current = Cursors.Default;

                DateTime BANKDAY = new DateTime(2012,1,1);
                Legal.Forms.FormRep.FormFactPrint frm = new Legal.Forms.FormRep.FormFactPrint(BANKDAY, dtBegin.Value.Date);
                frm.SqlSettings = this.SqlSettings;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                }

        }

        private void btnExport1C_Click(object sender, EventArgs e)
        {
            Legal.Forms.Export.FormExport1C frm = new Legal.Forms.Export.FormExport1C();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        // 
        private void btnImportODN_Click(object sender, EventArgs e)
        {
            Legal.Forms.Export.FormImportODN frm = new Legal.Forms.Export.FormImportODN();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnPrintSchetFact_Correct_Click(object sender, EventArgs e)
        {
            DateTime BANKDAY = (DateTime)cbxDays.SelectedValue;
            Legal.Forms.FormRep.FormFactPrint_Correct frm = new Legal.Forms.FormRep.FormFactPrint_Correct(BANKDAY);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnPrintAct_Correct_Click(object sender, EventArgs e)
        {
            DateTime BANKDAY = (DateTime)cbxDays.SelectedValue;
            Legal.Forms.FormRep.FormActPrint_Correct frm = new Legal.Forms.FormRep.FormActPrint_Correct(BANKDAY);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        // отметить потребителей которые есть в списке
        private void btnGroupCheck_Click(object sender, EventArgs e)
        {
             
            SelectSqlData(dsCntVal1, dsCntVal1.tG_AbnGroup, true, "where Deleted = 0 and NumberGroup = " + cmbList.SelectedItem);
            if (dsCntVal1.tG_AbnGroup.Rows.Count > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                for (int k = 0; k < dsCntVal1.tG_AbnGroup.Rows.Count; k++)
                {
                    for (int i = 0; i < dgvDocList.RowCount; i++)
                    {
                        if (Convert.ToInt32(dsCntVal1.tG_AbnGroup.Rows[k]["CodeAbn"]) == Convert.ToInt32(dgvDocList.Rows[i].Cells["codeAbonentDataGridViewTextBoxColumn"].Value))
                        {
                            dgvDocList.Rows[i].Cells["SelectCell"].Value = true;
                            break;
                        }
                    }
                }
                Cursor.Current = Cursors.Default;
            }

        }

        // обновить список
        private void btnGroupSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить список потребителей?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            Cursor.Current = Cursors.WaitCursor;
            DataSql.SqlDataConnect con1 = new DataSql.SqlDataConnect();
            try
            {
                con1.OpenConnection(SqlSettings);

                string strCmd = "";
                strCmd = "sp_LegAbnGroupDel";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con1.Connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                int NumberGroup = Convert.ToInt32(cmbList.SelectedItem);

                SqlParameter p1 = new SqlParameter("@NumberGroup", NumberGroup);
                sqlCmd.Parameters.Add(p1);


                sqlCmd.CommandTimeout = 0;

                sqlCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con1.CloseConnection();
            }


            for (int i = 0; i < dgvDocList.RowCount; i++)
            {
                if (dgvDocList.Rows[i].Cells["SelectCell"].Value != null)
                {
                    if (((bool)dgvDocList.Rows[i].Cells["SelectCell"].Value == true) )
                    {
                        DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                        try
                        {
                            con.OpenConnection(SqlSettings);

                            string strCmd = "";
                            strCmd = "sp_LegAbnGroupSave";
                            SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);
                            sqlCmd.CommandType = CommandType.StoredProcedure;

                            int Code = Convert.ToInt32(dgvDocList.Rows[i].Cells["codeAbonentDataGridViewTextBoxColumn"].Value);

                            SqlParameter p1 = new SqlParameter("@Code", Code);
                            sqlCmd.Parameters.Add(p1);

                            int NumberGroup = Convert.ToInt32(cmbList.SelectedItem);
                            SqlParameter p2 = new SqlParameter("@NumberGroup", NumberGroup);
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
                }
            }
            Cursor.Current = Cursors.Default;

        }


    }
}
















