using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Constants;

namespace Prv.Forms.Plombs
{
    public partial class FormPlombUstDemEdit : FormLbr.FormBase 
    {
        public enum ActionPlomb { Installation, Edit, Deinstallation };
        private ActionPlomb actPlomb;
        private int idPlombUst = -1;
        private int idPointReg = -1;

        public FormPlombUstDemEdit()
        {
            InitializeComponent();
        }

        public FormPlombUstDemEdit(ActionPlomb actPlomb, int idPlombUst, int idPointReg)
        {
            InitializeComponent();

            this.actPlomb = actPlomb;
            this.idPlombUst = idPlombUst;
            this.idPointReg = idPointReg;

            dateTimePickerDem.Value = null;
        }

        private void FormPlombUstDemEdit_Load(object sender, EventArgs e)
        {
            this.SelectSqlData(dsForm.Tables["vWorkerGroup"], true, " where ParentKey = ';GroupWorker;MasterPlomber;' " +
                "and dateEnd is null order by fio", null, true);
            this.SelectSqlData(dsForm.Tables["tR_Classifier"], true, " where ParentKey = ';SKUEE;Plomb;TypePlomb;' " +
                "and isGroup = 0 and deleted = 0");
            cmbTypePlomb.SelectedIndex = -1;

            InitPlomb();
        }

        private void InitPlomb()
        {
            switch (actPlomb)
            {
                case ActionPlomb.Installation:  // установка
                    this.Text = "Установка пломбы";
                    DataRow drAdd = dsPlombUst.tPlomb.NewRow();
                    drAdd["idPointReg"] = idPointReg;
                    drAdd["typePlomb"] = -1;
                    drAdd["idActPlomb"] = (int)ActPlomb.Installation;
                    drAdd["Date"] = DateTime.Now.Date;
                    drAdd["DateInst"] = DateTime.Now.Date;
                    dsPlombUst.tPlomb.Rows.Add(drAdd);

                    cmbControlerDem.SelectedIndex = -1;
                    groupBoxDem.Enabled = false;
                    break;
                case ActionPlomb.Deinstallation: //демонтаж
                    this.Text = "Демонтаж пломбы";
                    this.SelectSqlData(dsPlombUst, dsPlombUst.tPlomb, true, " where id = " + idPlombUst.ToString());
                    string number = "0000000000";
                    int lenght = (dsPlombUst.tPlomb.Rows[0]["DigitNumber"] == DBNull.Value) ? 10 : Convert.ToInt32(dsPlombUst.tPlomb.Rows[0]["DigitNumber"]);
                    number = number.Substring(0, lenght - dsPlombUst.tPlomb.Rows[0]["Number"].ToString().Length) + dsPlombUst.tPlomb.Rows[0]["Number"];
                    cmbSEriaNumber.Text = number;
                    groupBoxUst.Enabled = false;
                    groupBoxPlomb.Enabled = false;

                    DataRow drDem = dsPlombDem.tPlomb.NewRow();
                    drDem["idPointReg"] = idPointReg;
                    drDem["typePlomb"] = dsPlombUst.tPlomb.Rows[0]["typePlomb"];
                    drDem["idActPlomb"] = (int)ActPlomb.Dismantling;
                    drDem["SEria"] = dsPlombUst.tPlomb.Rows[0]["seria"];
                    drDem["Number"] = dsPlombUst.tPlomb.Rows[0]["number"];
                    drDem["DigitNumber"] = dsPlombUst.tPlomb.Rows[0]["digitNumber"];
                    drDem["Date"] = DateTime.Now.Date;
                    dsPlombDem.tPlomb.Rows.Add(drDem);

                    break;
                case ActionPlomb.Edit: //редактирование
                    this.Text = "Редактирование пломбы";
                    this.SelectSqlData(dsPlombUst, dsPlombUst.tPlomb, true, " where id = " + idPlombUst.ToString());
                    number = "0000000000";
                    lenght = (dsPlombUst.tPlomb.Rows[0]["DigitNumber"] == DBNull.Value) ? 10 : Convert.ToInt32(dsPlombUst.tPlomb.Rows[0]["DigitNumber"]);
                    number = number.Substring(0, lenght - dsPlombUst.tPlomb.Rows[0]["Number"].ToString().Length) + dsPlombUst.tPlomb.Rows[0]["Number"];
                    cmbSEriaNumber.Text = number;
                    cmbControlerUst.Enabled = false;
                    groupBoxPlomb.Enabled = false;

                    string seria = (dsPlombUst.tPlomb.Rows[0]["Seria"] == DBNull.Value) ? " and seria is null " : " and seria = '" + dsPlombUst.tPlomb.Rows[0]["Seria"].ToString() + "'";
                    string digit = (dsPlombUst.tPlomb.Rows[0]["DigitNumber"] == DBNull.Value) ? " and DigitNumber is null " : " and DigitNumber = " + dsPlombUst.tPlomb.Rows[0]["DigitNumber"].ToString();
                    this.SelectSqlData(dsPlombDem, dsPlombDem.tPlomb, true, " where idActPlomb = " + ((int)ActPlomb.Dismantling).ToString() +
                        " and typePlomb = " + dsPlombUst.tPlomb.Rows[0]["typePlomb"].ToString() + 
                        seria + " and number = " + dsPlombUst.tPlomb.Rows[0]["Number"] + digit);
                    if (dsPlombDem.tPlomb.Rows.Count == 0)
                        groupBoxDem.Enabled = false;
                    break;
            }
        }

        #region Controls Events
        // смена контролера при установке
        private void cmbControlerUst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbControlerUst.SelectedIndex >= 0)
            {
                if (cmbTypePlomb.SelectedIndex >= 0)
                {
                    this.SelectSqlData(dsForm, dsForm.Tables["vPlombStatus"], true, " where idWorker = " +
                        cmbControlerUst.SelectedValue.ToString() + " and StatusPlomb = 'Свободна' " + 
                        " and typePlomb = " +cmbTypePlomb.SelectedValue.ToString() + " order by seria, numberstring ");
                    cmbSEriaNumber.SelectedIndex = -1;
                }
                else
                    dsForm.Tables["vPlombStatus"].Clear();
            }
            else
                dsForm.Tables["vPlombStatus"].Clear();

        }
        // смена даты установки
        private void dateTimePickerUst_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerDem.MinDate = dateTimePickerUst.Value;
        }
        // ОК
        private void buttonOk_Click(object sender, EventArgs e)
        {
            switch (actPlomb)
            {
                case ActionPlomb.Installation:
                    if (InstallationPlomb()) DialogResult = DialogResult.OK;
                    break;
                case ActionPlomb.Deinstallation:
                    if (DeinstallationPlomb()) DialogResult = DialogResult.OK;
                    break;
                case ActionPlomb.Edit:
                    if (EditPlomb()) DialogResult = DialogResult.OK;
                    break;
            }
        }
        #endregion

        private bool InstallationPlomb()
        {
            if (cmbControlerUst.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран контролер");
                return false;
            }
            if (cmbTypePlomb.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран тип пломбы");
                return false;
            }
            if (cmbSEriaNumber.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбрана пломбы");
                return false;
            }

            DataRow [] dr = dsForm.Tables["vPlombStatus"].Select("id = " + cmbSEriaNumber.SelectedValue.ToString());
            dsPlombUst.tPlomb.Rows[0]["Seria"] = dr[0]["Seria"];
            dsPlombUst.tPlomb.Rows[0]["Number"] = dr[0]["NumberString"];
            dsPlombUst.tPlomb.Rows[0]["DigitNumber"] = dr[0]["DigitNumber"];
            dsPlombUst.tPlomb.Rows[0].EndEdit();

            if (this.InsertSqlData(dsPlombUst, dsPlombUst.tPlomb))
                return true;
            else
                return false;
        }

        private bool DeinstallationPlomb()
        {
            if (cmbControlerDem.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран контролер");
                return false;
            }
            if (dateTimePickerDem.Value == null)
            {
                MessageBox.Show("Не выбрана дата демонтажа");
                return false;
            }

            dsPlombDem.tPlomb.Rows[0].EndEdit();

            if (this.InsertSqlData(dsPlombDem, dsPlombDem.tPlomb))
                return true;
            else
                return false;
        }

        private bool EditPlomb()
        {
            if (dsPlombDem.tPlomb.Rows.Count > 0)
            {

                if (cmbControlerDem.SelectedIndex < 0)
                {
                    MessageBox.Show("Не выбран контролер");
                    return false;
                }
                if (dateTimePickerDem.Value == null)
                {
                    MessageBox.Show("Не выбрана дата демонтажа");
                    return false;
                }

                dsPlombDem.tPlomb.Rows[0].EndEdit();
                if (!this.UpdateSqlData(dsPlombDem, dsPlombDem.tPlomb))
                    return false;

            }

            dsPlombUst.tPlomb.Rows[0].EndEdit();
            if (this.UpdateSqlData(dsPlombUst, dsPlombUst.tPlomb))
                return true;
            else
                return false;
        }

    }
}
