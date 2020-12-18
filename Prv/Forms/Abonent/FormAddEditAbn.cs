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
    public partial class FormAddEditAbn : FormLbr.FormBase
    {
        /// <summary>
        /// Действия над абонентом
        /// </summary>
        internal enum ActionAbn
        {
            /// <summary>
            /// Добавить абонента
            /// </summary>
            Add,
            /// <summary>
            /// Редактировать
            /// </summary>
            Edit,
            /// <summary>
            /// Деактивировать
            /// </summary>
            Deactive
        }
        private int idAbn = -1;   // id абонента

        private ActionAbn actAbn;


        #region Property
        public int CodeAbonent
        {
            get
            {
                return Convert.ToInt32(txtCodeAbonent.Text);
            }
        }
        public int TypeAbn
        {
            get 
            {
                return Convert.ToInt32(cmbTypeAbn.SelectedValue);
            }
        }
        #endregion

        public FormAddEditAbn()
        {
            InitializeComponent();
        }
        internal FormAddEditAbn(int idAbn, ActionAbn actAbn)
        {
            InitializeComponent();
            this.idAbn = idAbn;
            this.actAbn = actAbn;

            switch (actAbn)
            {
                case ActionAbn.Add:
                    this.Text = "Новый абонент";
                    break;
                case ActionAbn.Deactive:
                    this.Text = "Деактивировать абонента";
                    break;
                case ActionAbn.Edit:
                    this.Text = "Редактирование абонента";
                    break;
                default: break;
            }
        }

        private void FormAddEditAbn_Load(object sender, EventArgs e)
        {
            LoadDirectory();

            InitAbn();
        }

        private void LoadDirectory()
        {
            this.SelectSqlData(dsAbn, dsAbn.tR_Classifier, true, "where IsGroup = 0 and deleted = 0 and " +
                " ((ParentKey = ';SKUEE;TypeAbn;' and id in (" + Constants.Constants.TypeAbnPrivate.ToString() + "," +
                Constants.Constants.TypeAbnPrivateNoDog.ToString() + ")) or (ParentKey = ';SKUEE;ReasonStatus;ReasonAbnFL;'))");

            this.SelectSqlData(dsAbn, dsAbn.Tables["vWorkerGroup"], true, " where idGroup = " + Constants.Constants.WorkerGroupControlerBS.ToString() +
               " and dateEnd is null order by FIO");
        }
        private void InitAbn()
        {
            switch (actAbn)
            {
                case ActionAbn.Add:
                    DataRow dr = dsAbn.tAbn.NewRow();
                    dr["Deleted"] = false;
                    dr["idWorker"] = -1;
                    dr["TypeAbn"] = Constants.Constants.TypeAbnPrivate;
                    dr["CodeAbonent"] = GetFreeCodeAbonent(Constants.Constants.TypeAbnPrivate);
                    dsAbn.tAbn.Rows.Add(dr);
                    dr = dsAbn.tAbnContact.NewRow();
                    dr["idAbn"] = -1;
                    dsAbn.tAbnContact.Rows.Add(dr);
                    dr = dsAbn.tAbnStatus.NewRow();
                    dr["idAbn"] = -1;
                    dr["isActive"] = true;
                    dr["DateChange"] = DateTime.Now.Date;
                    dsAbn.tAbnStatus.Rows.Add(dr);
                    dtpNotLive.Visible = false;
                    dateTimePickerEnd.Value = null;
                    dateTimePickerEnd.Enabled = false;
                    cmbReason.SelectedIndex = -1;
                    cmbReason.Enabled = false;
                    break;
                case ActionAbn.Edit:
                    // абонент
                    this.SelectSqlData(dsAbn, dsAbn.tAbn, true, " where id = " + idAbn.ToString());
                    // контакт инфо
                    this.SelectSqlData(dsAbn.tAbnContact, true, "where idAbn = " + idAbn.ToString() +
                        " order by DateChange desc ", null, false, 1);
                    // статус абонента
                    this.SelectSqlData(dsAbn, dsAbn.tAbnStatus, true, "where isActive = 1 and idabn = " + idAbn.ToString() +
                        " order by DateChange desc");
                    if (dsAbn.tAbnStatus.Rows.Count == 0)
                    {
                        DataRow dr1 = dsAbn.tAbnStatus.NewRow();
                        dr1["idAbn"] = -1;
                        dr1["isActive"] = true;
                        dr1["DateChange"] = DateTime.Now.Date;
                        dsAbn.tAbnStatus.Rows.Add(dr1);
                    }
                    txtFamily.ReadOnly = true;
                    txtName.ReadOnly = true;
                    txtOtchestvo.ReadOnly = true;

                    dtpNotLive.Visible = false;

                    if(dsAbn.tAbnStatus.Rows[0]["idReason"] != DBNull.Value && (int)dsAbn.tAbnStatus.Rows[0]["idReason"] == 740)
                    {
                        cbNotLive.Checked = true;
                        dtpNotLive.Visible = true;
                        dtpNotLive.Value = Convert.ToDateTime( dsAbn.tAbnStatus.Rows[0]["DateChange"]);
                    }

                    if (dsAbn.tAbnStatus.Rows.Count <= 1 || dsAbn.tAbnStatus.Rows[0]["idReason"] == DBNull.Value || (int)dsAbn.tAbnStatus.Rows[0]["idReason"] == 740) // если закрыт
                    {
                        dateTimePickerEnd.Enabled = false;
                        cmbReason.Enabled = false;
                    }


                    break;
                case ActionAbn.Deactive:
                    // абонент
                    this.SelectSqlData(dsAbn, dsAbn.tAbn, true, " where id = " + idAbn.ToString());
                    // контакт инфо
                    this.SelectSqlData(dsAbn.tAbnContact, true, "where idAbn = " + idAbn.ToString() +
                        " order by DateChange desc ", null, false, 1);
                    // статус абонента
                    this.SelectSqlData(dsAbn, dsAbn.tAbnStatus, true, "where idabn = " + idAbn.ToString() +
                        " order by DateChange asc");
                    if (dsAbn.tAbnStatus.Rows.Count == 0)
                    {
                        DataRow dr1 = dsAbn.tAbnStatus.NewRow();
                        dr1["idAbn"] = -1;
                        dr1["isActive"] = true;
                        dr1["DateChange"] = DateTime.Now.Date;
                        dsAbn.tAbnStatus.Rows.Add(dr1);
                    }
                    txtFamily.ReadOnly = true;
                    txtName.ReadOnly = true;
                    txtOtchestvo.ReadOnly = true;
                    txtCodeAbonent.ReadOnly = true;
                    cmbTypeAbn.Enabled = false;
                    dateTimePickerBegin.Enabled = false;

                    cbNotLive.Visible = false;
                    dtpNotLive.Visible = false;


                    if (dsAbn.tAbnStatus.Rows.Count <= 1 || dsAbn.tAbnStatus.Rows[0]["idReason"] == DBNull.Value || (int)dsAbn.tAbnStatus.Rows[0]["idReason"] == 740)
                    {
                     //   DataRow drStatus = dsAbn.tAbnStatus.NewRow();
                     //   drStatus["idAbn"] = idAbn;
                     //   drStatus["isActive"] = false;
                     ////   drStatus["idReason"] = cmbReason.SelectedValue;
                     //   drStatus["DateChange"] = DateTime.Now.Date;
                     //   dsAbn.tAbnStatus.Rows.Add(drStatus);
                    }
                    break;
                default: break;
            }
        }

        private int GetFreeCodeAbonent(int typeAbn)
        {
            DataSets.DataSetPrv ds = new Prv.DataSets.DataSetPrv();
            this.SelectSqlData(ds.tAbn, true, "where TypeAbn = " + typeAbn.ToString() + "order by codeabonent desc", null, false, 1);
            if (typeAbn == Constants.Constants.TypeAbnPrivate)
            {
                if (ds.tAbn.Rows.Count <= 0)
                    return 10000;
                else
                    return Convert.ToInt32(ds.tAbn.Rows[0]["CodeAbonent"]) + 1;
            }
            else //бездоговрные
            {
                if (ds.tAbn.Rows.Count <= 0)
                    return 1000000001;
                else
                    return Convert.ToInt32(ds.tAbn.Rows[0]["CodeAbonent"]) + 1;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (cmbControler.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран контролер");
                return;
            }

            switch (actAbn )
            {
                case ActionAbn.Add:
                    if ((String.IsNullOrEmpty(txtFamily.Text)) || (string.IsNullOrEmpty(txtName.Text)))
                    {
                        MessageBox.Show("Введите ФИО");
                        return;
                    }
                    dsAbn.tAbn.Rows[0]["Name"] = txtFamily.Text + " " + txtName.Text + " " + txtOtchestvo.Text;
                    dsAbn.tAbn.Rows[0].EndEdit();
                    idAbn = this.InsertSqlDataOneRow(dsAbn, dsAbn.tAbn);
                    if (idAbn > 0)
                    {
                        if (cbNotLive.CheckState == CheckState.Checked && dateTimePickerEnd.Value == null)
                        { 
                          dsAbn.tAbnStatus.Rows[0]["isActive"] = 1;
                          dsAbn.tAbnStatus.Rows[0]["idReason"] = 740;
                          dsAbn.tAbnStatus.Rows[0]["DateChange"] = dtpNotLive.Value;
                        }

                        dsAbn.tAbnStatus.Rows[0]["idabn"] = idAbn;
                        dsAbn.tAbnStatus.Rows[0].EndEdit();
                        this.InsertSqlData(dsAbn, dsAbn.tAbnStatus);

                        dsAbn.tAbnContact.Rows[0]["idabn"] = idAbn;
                        dsAbn.tAbnContact.Rows[0]["DateChange"] = dateTimePickerBegin.Value;
                        dsAbn.tAbnContact.Rows[0].EndEdit();
                        this.InsertSqlData(dsAbn, dsAbn.tAbnContact);

                        DialogResult = DialogResult.OK;

                    }
                    break;
                case ActionAbn.Edit:
                    if (dsAbn.tAbnStatus.Rows.Count > 1 && (int)dsAbn.tAbnStatus.Rows[0]["idReason"] != 740 && cbNotLive.CheckState == CheckState.Unchecked)
                    {
                        if (dateTimePickerEnd.Value == null)
                        {
                            MessageBox.Show("Введите дату окончания");
                            return;
                        }
                        if (cmbReason.SelectedIndex < 0)
                        {
                            MessageBox.Show("Введите причину окончания");
                            return;
                        }
                    }

                    dsAbn.tAbn.Rows[0].EndEdit();
                    if (this.UpdateSqlData(dsAbn, dsAbn.tAbn))
                    {
                        if (dateTimePickerEnd.Value == null)
                                if (cbNotLive.CheckState == CheckState.Checked)
                                {
                                    dsAbn.tAbnStatus.Rows[0]["isActive"] = 1;
                                    dsAbn.tAbnStatus.Rows[0]["idReason"] = 740;
                                    dsAbn.tAbnStatus.Rows[0]["DateChange"] = dtpNotLive.Value;
                                }
                                else
                                {
                                    dsAbn.tAbnStatus.Rows[0]["isActive"] = 1;
                                    dsAbn.tAbnStatus.Rows[0]["idReason"] = DBNull.Value;
                                    dsAbn.tAbnStatus.Rows[0]["DateChange"] = dtpNotLive.Value;
                                }
                        dsAbn.tAbnStatus.Rows[0].EndEdit();
                        if (dsAbn.tAbnStatus.Rows.Count > 1) dsAbn.tAbnStatus.Rows[1].EndEdit();
                        if (this.InsertSqlData(dsAbn, dsAbn.tAbnStatus))
                            if (this.UpdateSqlData(dsAbn, dsAbn.tAbnStatus))
                                DialogResult = DialogResult.OK;
                    }
                    break;
                case ActionAbn.Deactive:
                    if (dateTimePickerEnd.Value == null)
                    {
                        MessageBox.Show("Введите дату окончания");
                        return;
                    }
                    if (cmbReason.SelectedIndex < 0)
                    {
                        MessageBox.Show("Введите причину окончания");
                        return;
                    }

                       DataRow drStatus = dsAbn.tAbnStatus.NewRow();
                       drStatus["idAbn"] = idAbn;
                       drStatus["isActive"] = false;
                       drStatus["idReason"] = cmbReason.SelectedValue;
                       drStatus["DateChange"] = dateTimePickerEnd.Value; // DateTime.Now.Date;
                       dsAbn.tAbnStatus.Rows.Add(drStatus);

                    dsAbn.tAbn.Rows[0].EndEdit();
                    if (this.UpdateSqlData(dsAbn, dsAbn.tAbn))
                    {
                        dsAbn.tAbnStatus.Rows[0].EndEdit();
                        if (dsAbn.tAbnStatus.Rows.Count > 1) dsAbn.tAbnStatus.Rows[1].EndEdit();
                        if ((this.InsertSqlData(dsAbn, dsAbn.tAbnStatus)) && (this.UpdateSqlData(dsAbn, dsAbn.tAbnStatus)))
                            DialogResult = DialogResult.OK;
                    }
                    break;
                default: break;
            }
        }

        private void cbNotLive_CheckedChanged(object sender, EventArgs e)
        {
            switch (cbNotLive.CheckState)
            {
                case CheckState.Checked:
                    dtpNotLive.Visible = true;
                    break;
                default:
                    dtpNotLive.Visible = false;
                    break;
            }
        }



    }
}
