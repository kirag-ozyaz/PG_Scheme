using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prv.Forms.Abonent
{
    /// <summary>
    /// Форма для добавления/редактирования платежей (tDocOpl)
    /// </summary>
    public partial class FormAddEditDocOpl : FormLbr.FormBase
    {
        /// <summary>
        /// Действия над платежом
        /// </summary>
        public enum ActionDocOpl
        {
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
        private int idDocOpl = -1;  // id документа

        private ActionDocOpl actDocOpl;

        #region Construcors
        public FormAddEditDocOpl()
        {
            InitializeComponent();
        }
         /// <summary>
        /// Конструтор формы
        /// </summary>
        /// <param name="idPoint">id точки учета</param>
        /// <param name="idDocOpl">id платежа</param>
        /// <param name="actDocOpl">действия над платежом</param>
        public FormAddEditDocOpl(int codeAbonent, int idPoint, int idDocOpl, ActionDocOpl actDocOpl)
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
            this.idDocOpl = idDocOpl;
            this.actDocOpl = actDocOpl;
            txtCodeAbonent.Text = codeAbonent.ToString();

            switch (actDocOpl)
            {
                case ActionDocOpl.Add:
                    this.Text = "Добавление платежа";
                    break;
                case ActionDocOpl.Edit:
                    this.Text = "Редактирование плаьежа";
                    break;
                case ActionDocOpl.Read:
                    this.Text = "Просмотр платежа";
                    break;
                default: break;
            }
        }
        #endregion

        #region FormAddEditDocOpl evetns
        private void FormAddEditDocOpl_Load(object sender, EventArgs e)
        {
            dateTimePickerDateAct.Value = DateTime.Now.Date;
            LoadDirectory();

            InitDocOpl();
        }
        #endregion

        #region LoadData
        private void LoadDirectory()
        {
            this.SelectSqlData(dsDocOpl, dsDocOpl.tR_Classifier, true, " where ParentKey in (';TypeDoc;tDocOpl;') and isGroup = 0 and deleted = 0");
            cmbTypeDoc.SelectedIndex = -1;

            this.SelectSqlData(dsReference, dsReference.Tables["vr_zone"], true);
            DataRow dr = dsReference.Tables["vr_zone"].NewRow();
            dr["IdSubZoneName"] = DBNull.Value;
            dr["SubZoneName"] = "";
            dsReference.Tables["vr_zone"].Rows.InsertAt(dr, 0);
            cmbZone.SelectedIndex = 0;
        }
        #endregion
        private void InitDocOpl()
        {
            switch (actDocOpl)
            {
                case ActionDocOpl.Add:
                    DataRow dr = dsDocOpl.tDocOpl.NewRow();
                    dr["IdPoint"] = idPoint;
                    dr["idDocType"] = -1;
                    dr["dateIn"] = DateTime.Now.Date;
                    dr["DateOpl"] = dateTimePickerDateAct.Value.Date;
                    dsDocOpl.tDocOpl.Rows.Add(dr);
                    break;
                case ActionDocOpl.Edit:
                    this.SelectSqlData(dsDocOpl.tDocOpl, true, "where id = " + idDocOpl.ToString(), null, false, 1);
                    break;
                case ActionDocOpl.Read:
                    this.SelectSqlData(dsDocOpl.tDocOpl, true, "where id = " + idDocOpl.ToString(), null, false, 1);
                    dateTimePickerDateAct.Enabled = false;
                    txtIndicator.ReadOnly = true;
                    cmbTypeDoc.Enabled = false;
                    cmbZone.Enabled = false;
                    txtSize.ReadOnly = true;
                    txtMoney.ReadOnly = true;
                    richTextBoxComment.ReadOnly = true;
                    break;
                default: break;
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                switch (actDocOpl)
                {
                    case ActionDocOpl.Add:
                        dsDocOpl.tDocOpl.Rows[0].EndEdit();
                        int idDoc = this.InsertSqlDataOneRow(dsDocOpl, dsDocOpl.tDocOpl);
                        if (idDoc > 0)
                            DialogResult = DialogResult.OK;
                        break;
                    case ActionDocOpl.Edit:
                        dsDocOpl.tDocOpl.Rows[0].EndEdit();
                        if (this.UpdateSqlData(dsDocOpl, dsDocOpl.tDocOpl))
                            DialogResult = DialogResult.OK;
                        break;
                    case ActionDocOpl.Read:
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
                }
                catch
                {
                    MessageBox.Show("Показания счетчика не могут содержать буквы");
                    return false;
                }
            #endregion

            #region контролеры
            if (cmbTypeDoc.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран тип платежа");
                return false;
            }
            #endregion

            return true;
        }
    }
}
