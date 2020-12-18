using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Constants;

namespace Prv.Forms.Abonent
{
    /// <summary>
    /// Форма для добавления/редактирования документов (tDocAct)
    /// </summary>
    public partial class FormAddEditDocAct : FormLbr.FormBase
    {
        /// <summary>
        /// Действия на документом
        /// </summary>
        public enum ActionDocAct {
            /// <summary>
            /// Добавить новый
            /// </summary>
            Add,
            /// <summary>
            /// Редактировать
            /// </summary>
            Edit,
            /// <summary>
            /// Просмотр
            /// </summary>
            Read
        }

        private int idPoint = -1;   // id точки учета
        private int idDocAct = -1;  // id документа
        private int topIndicator = -1;

        private ActionDocAct actDocAct;

        private DateTime dateAct;
        private int idControler = -1;

        #region Properties
        public DateTime DateAct
        {
            get { return dateAct; }
            set
            {
                dateAct = value;
                dateTimePickerDateAct.Value = value;
            }
        }
        public int IdControler
        {
            get { return idControler; }
            set 
            { 
                idControler = value;
                cmbControler.SelectedValue = value; 
            }
        }
        #endregion

        #region Construcotrs
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormAddEditDocAct()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Конструтор формы
        /// </summary>
        /// <param name="idPoint">id точки учета</param>
        /// <param name="idDocAct">id документа</param>
        /// <param name="actDocAct">действия над документом</param>
        public FormAddEditDocAct(int codeAbonent, int idPoint, int idDocAct, ActionDocAct actDocAct)
        {
            InitializeComponent();
            txtIndicator.DataBindings[0].NullValue = "";
            txtIndicator.DataBindings[0].DataSourceNullValue = DBNull.Value;
            txtSize.DataBindings[0].NullValue = "";
            txtSize.DataBindings[0].DataSourceNullValue = DBNull.Value;
            txtMoney.DataBindings[0].NullValue = "";
            txtMoney.DataBindings[0].DataSourceNullValue = DBNull.Value;
            richTextBoxComment.DataBindings[0].NullValue = "";
            richTextBoxComment.DataBindings[0].DataSourceNullValue = DBNull.Value;

            this.idPoint = idPoint;
            this.idDocAct = idDocAct;
            this.actDocAct = actDocAct;
            txtCodeAbonent.Text = codeAbonent.ToString();

            switch (actDocAct)
            {
                case ActionDocAct.Add:
                    this.Text = "Добавление документа";
                    break;
                case ActionDocAct.Edit:
                    this.Text = "Редактирование документа";
                    break;
                case ActionDocAct.Read:
                    this.Text = "Просмотр документа";
                    break;
                default: break;
            }
        }
        #endregion

        #region FormAddEditDocAct Events
        private void FormAddEditDocAct_Load(object sender, EventArgs e)
        {
            dateAct = System.DateTime.Now.Date;
            dateTimePickerDateAct.Value = dateAct;
            GetMinMaxDateAct();
            LoadDirectory();

            InitDocAct();

            //if (actDocAct == ActionDocAct.Add && FormAbonent.idCont > 0)
            //{
            //    cmbControler.SelectedValue = FormAbonent.idCont;
            //    cmbZone.SelectedValue = FormAbonent.idZ;
            //    dateTimePickerDateAct.Value = FormAbonent.actDate;
            //}
        }
        #endregion

        #region LoadData
        private void LoadDirectory()
        {
            this.SelectSqlData(dsDocAct, dsDocAct.tR_Classifier, true, " where ParentKey in (';TypeDoc;tDocAct;') and isGroup = 0 and deleted = 0" );
            cmbTypeDoc.SelectedValue = (int)DocType.ActKO;

            // справочник мастеров (уст. счечтичков)
            this.SelectSqlData(dsDocAct, dsDocAct.Tables["vWorkerGroup"], true, 
               " where idGRoup in( " + Constants.Constants.WorkerGroupControlerBS.ToString() + 
               " , " + Constants.Constants.WorkerGroupMasterBS.ToString() +
               " , " + Constants.Constants.WorkerGroupMasterUL.ToString() +
               ") and dateEnd is null order by FIO");
            cmbControler.SelectedValue = idControler;
            

            // справочник временных зон
            this.SelectSqlData(dsTopIndicator, dsTopIndicator.Tables["vr_zone"], true);
            DataRow dr = dsTopIndicator.Tables["vr_zone"].NewRow();
            dr["IdSubZoneName"] = DBNull.Value;
            dr["SubZoneName"] = "";
            dsTopIndicator.Tables["vr_zone"].Rows.InsertAt(dr, 0);
            cmbZone.SelectedIndex = 0;
        }
        // минимальная и максимальная дата документа
        private void GetMinMaxDateAct()
        {
            this.SelectSqlData(dsDocAct, dsDocAct.tPoint, true, " where id = " + idPoint.ToString());
            dateTimePickerDateAct.MinDate = Convert.ToDateTime(dsDocAct.tPoint.Rows[0]["DateBegin"]);
            dateTimePickerDateAct.MaxDate = DateTime.Now.Date.AddMonths(6);
        }
        // получить максимальное значение счетчика
        private void GetTopIndicatorAndCurrentZone(DateTime date)
        {
            this.SelectSqlData(dsTopIndicator.Tables["tPointReg"], true, "where idPoint = " + idPoint.ToString() + 
                " and DateBegin < '" + date.ToString("yyyyMMdd") + "' and [type] <> " +
                ((int)Constants.DevicePointType.TransAmperage).ToString() + " order by DateBegin desc", null, false, 1);

            if (dsTopIndicator.Tables["tPointReg"].Rows.Count <= 0)
            {
                topIndicator = -1;
                dsTopIndicator.Tables["vR_zone"].Clear();
            }
            else
            {
                if (dsTopIndicator.Tables["tPointReg"].Rows[0]["idMark"] == DBNull.Value)
                    topIndicator = -1;
                else
                {
                    this.SelectSqlData(dsTopIndicator, dsTopIndicator.Tables["tR_MarkMeter"], true, "where id = " +
                        dsTopIndicator.Tables["tPointReg"].Rows[0]["idMark"].ToString());
                    if (dsTopIndicator.Tables["tR_MarkMeter"].Rows.Count <= 0)
                        topIndicator = -1;
                    else
                        if (dsTopIndicator.Tables["tR_MarkMeter"].Rows[0]["Digit"] == DBNull.Value)
                            topIndicator = -1;
                        else
                        {
                            //Например : нужно а возвести в степень b (c=a^b)
                            //с = System.Math.Exp(b*System.Math.Log(a));
                            int digit = Convert.ToInt32(dsTopIndicator.Tables["tR_MarkMeter"].Rows[0]["Digit"]);
                            topIndicator = Convert.ToInt32(System.Math.Exp(digit * System.Math.Log(10))) - 1;
                        }
                }
                /*if (dsTopIndicator.Tables["tPointReg"].Rows[0]["idZone"] == DBNull.Value)
                    dsTopIndicator.Tables["vr_zone"].Clear();
                else
                {
                    this.SelectSqlData(dsTopIndicator, dsTopIndicator.Tables["vr_zone"], true, " where idZoneName = " +
                       dsTopIndicator.Tables["tPointReg"].Rows[0]["idZone"].ToString());
                }*/
            }
            /*DataRow dr = dsTopIndicator.Tables["vr_zone"].NewRow();
            dr["IdSubZoneName"] = DBNull.Value;
            dr["SubZoneName"] = "";
            dsTopIndicator.Tables["vr_zone"].Rows.InsertAt(dr, 0);*/

            

        }
        #endregion

        private void InitDocAct()
        {
            switch (actDocAct)
            {
                case ActionDocAct.Add:
                    DataRow dr = dsDocAct.tDocAct.NewRow();
                    dr["IdPoint"] = idPoint;
                    dr["dateIn"] = DateTime.Now.Date;
                    dr["DateAct"] = dateTimePickerDateAct.Value.Date;
                    dr["idDocType"] = (int)DocType.ActKO;

                    dr["IdZone"] = 263; //заплатка, всегда сутки по умолчанию

                    if (FormAbonent.idCont > 0)
                    {
                        dr["idWorker"] = FormAbonent.idCont;
                        dr["IdZone"] = 263; // FormAbonent.idZ; //заплатка, всегда сутки по умолчанию
                        dr["DateAct"] = FormAbonent.actDate;
                    }
                    dr["isActive"] = true;
                    dr["Deleted"] = false;
                    dsDocAct.tDocAct.Rows.Add(dr);
                    break;
                case ActionDocAct.Edit:
                    this.SelectSqlData(dsDocAct.tDocAct, true, "where id = " + idDocAct.ToString(), null, false, 1);
                    break;
                case ActionDocAct.Read:
                    this.SelectSqlData(dsDocAct.tDocAct, true, "where id = " + idDocAct.ToString(), null, false, 1);
                    dateTimePickerDateAct.Enabled = false;
                    txtIndicator.ReadOnly = true;
                    cmbTypeDoc.Enabled = false;
                    cmbZone.Enabled = false;
                    cmbControler.Enabled = false;
                    txtSize.ReadOnly = true;
                    txtMoney.ReadOnly = true;
                    richTextBoxComment.ReadOnly = true;
                    break;
                default: break;
            }
        }


        #region Controls Events
        private void dateTimePickerDateAct_ValueChanged(object sender, EventArgs e)
        {
            dateAct = dateTimePickerDateAct.Value;
            GetTopIndicatorAndCurrentZone(dateTimePickerDateAct.Value);
        }
        #endregion

        // OK
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                switch (actDocAct)
                {
                    case ActionDocAct.Add:
                        FormAbonent.idCont = (int)cmbControler.SelectedValue;
                        FormAbonent.idZ = cmbZone.SelectedValue == null ? -1 : (int)cmbZone.SelectedValue;
                        FormAbonent.actDate = dateTimePickerDateAct.Value ;
                        dsDocAct.tDocAct.Rows[0].EndEdit();
                        int idDoc = this.InsertSqlDataOneRow(dsDocAct, dsDocAct.tDocAct);
                        if (idDoc > 0)
                            DialogResult = DialogResult.OK;
                        break;
                    case ActionDocAct.Edit:
                        dsDocAct.tDocAct.Rows[0].EndEdit();
                        if (this.UpdateSqlData(dsDocAct, dsDocAct.tDocAct))
                            DialogResult = DialogResult.OK;
                        break;
                    case ActionDocAct.Read:
                        DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    default: break;
                }
            }
        }
      

        private bool Check()
        {
            #region показания
            if (!String.IsNullOrEmpty(txtIndicator.Text))
                try
                {
                    int.Parse(txtIndicator.Text);
                    if (topIndicator > 0)
                    {
                        if ((Convert.ToInt32(txtIndicator.Text) < 0) ||
                        (Convert.ToInt32(txtIndicator.Text) > topIndicator))
                        {
                            MessageBox.Show("Допустимый диапазон показаний от 0 до " + topIndicator.ToString());
                            return false;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Показания счетчика не могут содержать буквы");
                    return false;
                }
            #endregion

            #region временная зона
            // тип документа и временная зона
            int typeDoc = Convert.ToInt32(cmbTypeDoc.SelectedValue);
            if (((typeDoc == (int)Constants.DocType.ActKO) ||
                (typeDoc == (int)Constants.DocType.ActUst) ||
                (typeDoc == (int)Constants.DocType.ActDem)) && 
                (cmbZone.SelectedIndex < 1))
            {
                MessageBox.Show("Не выбрана временная зона");
                return false;
            }
            #endregion

            #region контролеры
            if (cmbControler.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран контролер");
                return false;
            }
            #endregion

            return true;
        }

        #region сохранение по Enter
        private void txtIndicator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter: // внесение
                        buttonOk.PerformClick();
                        break;

                }
            }
        }

        private void dateTimePickerDateAct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter: // внесение
                        buttonOk.PerformClick();
                        break;

                }
            }
        }

        private void cmbTypeDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter: // внесение
                        buttonOk.PerformClick();
                        break;

                }
            }
        }

        private void cmbZone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter: // внесение
                        buttonOk.PerformClick();
                        break;

                }
            }
        }

        private void cmbControler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter: // внесение
                        buttonOk.PerformClick();
                        break;

                }
            }
        }

        private void txtSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter: // внесение
                        buttonOk.PerformClick();
                        break;

                }
            }
        }

        private void txtMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter: // внесение
                        buttonOk.PerformClick();
                        break;

                }
            }
        }
        #endregion
    }
}
