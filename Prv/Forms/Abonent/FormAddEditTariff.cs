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
    public partial class FormAddEditTariff : FormLbr.FormBase
    {
        /// <summary>
        /// Действия над тарифом
        /// </summary>
        public enum ActionTariff
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
        private int idTariff = -1;  
        private ActionTariff actTariff;

        public FormAddEditTariff()
        {
            InitializeComponent();
        }
        public FormAddEditTariff(int codeAbonent, int idPoint, int idTariff, ActionTariff actTariff)
        {
            InitializeComponent();

            this.idPoint = idPoint;
            this.idTariff = idTariff;
            this.actTariff = actTariff;
            txtCodeAbonent.Text = codeAbonent.ToString();
            dateTimePickerDateTariff.Value = DateTime.Now.Date;

            switch (actTariff)
            {
                case ActionTariff.Add:
                    this.Text = "Новый тариф";
                    break;
                case ActionTariff.Edit:
                    this.Text = "Редактировать тариф";
                    break;
                case ActionTariff.Read:
                    this.Text = "Просмотр";
                    break;
                default: break;
            }
        }

        private void FormAddEditTariff_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsTariff, dsTariff.tR_Classifier, true, " where ParentKey in (';SKUEE;Tariff;TariffFL;') and isGroup = 0 and deleted = 0");
            InitTariff();
        }

        private void InitTariff()
        {
            switch (actTariff)
            {
                case ActionTariff.Add:
                    DataRow dr = dsTariff.tTariffReg.NewRow();
                    dr["IdPoint"] = idPoint;
                    dr["SetDate"] = DateTime.Now.Date;
                    dr["idTariff"] = -1;
                    dsTariff.tTariffReg.Rows.Add(dr);
                    break;
                case ActionTariff.Edit:
                    this.SelectSqlData(dsTariff.tTariffReg, true, "where id = " + idTariff.ToString(), null, false, 1);
                    dateTimePickerDateTariff.Enabled = false;
                    break;
                case ActionTariff.Read:
                    this.SelectSqlData(dsTariff.tTariffReg, true, "where id = " + idTariff.ToString(), null, false, 1);
                    dateTimePickerDateTariff.Enabled = false;
                    cmbTariff.Enabled = false;
                    break;
                default: break;
            }

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            switch (actTariff)
            {
                case ActionTariff.Add:
                    if (cmbTariff.SelectedIndex < 0)
                    {
                        MessageBox.Show("Не выбран тариф");
                        return;
                    }
                    dsTariff.tTariffReg.Rows[0].EndEdit();
                    int id = this.InsertSqlDataOneRow(dsTariff, dsTariff.tTariffReg);
                    if (id > 0)
                        DialogResult = DialogResult.OK;
                    break;
                case ActionTariff.Edit:
                    if (cmbTariff.SelectedIndex < 0)
                    {
                        MessageBox.Show("Не выбран тариф");
                        return;
                    }
                    dsTariff.tTariffReg.Rows[0].EndEdit();
                    if (this.UpdateSqlData(dsTariff, dsTariff.tTariffReg))
                        DialogResult = DialogResult.OK;
                    break;
                case ActionTariff.Read:
                    DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                default: break;
            }
            
        }
    }
}
