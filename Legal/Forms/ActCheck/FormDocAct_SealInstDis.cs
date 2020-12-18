using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataSql;
using Constants;

namespace Legal.Forms.ActCheck
{
    public partial class FormDocAct_SealInstDis : FormLbr.FormBase
    {
        int idPointReg, SelectedValue;
        DocType docType;
        private ActPlomb actPlomb;
        bool cbWState = true, cbTState = true, cbNState = true;
        Device device;
        string ids = "";
        FormDocAct_CheckAdd frmCheck;
        FormDocAct_DemUst frmDemUst;

        public int idDevice { get; set; }

        #region Constructor

        public FormDocAct_SealInstDis()
        {
            InitializeComponent();
        }

        public FormDocAct_SealInstDis(SQLSettings settings, DocType docType, int idDevice, int idPointReg, ActPlomb actPlomb, Device device, string ids)
        {
            InitializeComponent();
            this.Text = "";
            this.SqlSettings = settings;
            this.docType = docType;
            this.idPointReg = idPointReg;
            this.actPlomb = actPlomb;
            this.ids = ids;
            FillControls(ids);
            this.idDevice = idDevice;
            this.device = device;
            if (actPlomb == ActPlomb.Installation)
                this.Text = "Добавление пломбы";
            if (actPlomb == ActPlomb.Dismantling)
                this.Text = "Демонтаж пломбы";
        }

        #endregion

        #region Procedures

        /// <summary> Заполнение выпадающих списков соответствующими данными
        /// </summary>
        private void FillControls(string ids)
        {
            SelectSqlData(dsAbnObjAkt1.vWorkerGroup, true, " where idGroup = 306 and dateEnd is null order by fio", null, true);
            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tR_Classifier, true, " where ParentKey = ';SKUEE;Plomb;TypePlomb;' and isGroup = 0 and deleted = 0");
            cbWorker.DataSource = dsAbnObjAkt1.vWorkerGroup;
            cbWorker.DisplayMember = "FIO";
            cbWorker.ValueMember = "id";
            cbWorker.SelectedIndex = -1;
            cbSealType.DataSource = dsAbnObjAkt1.tR_Classifier;
            cbSealType.DisplayMember = "Name";
            cbSealType.ValueMember = "id";
            cbSealType.SelectedIndex = -1;
            if (ids.Length > 0) SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idPointReg = {0} and idUst is not null and id not in ({1})", idPointReg, ids));
            else SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idPointReg = {0} and idUst is not null", idPointReg));
            if (actPlomb == ActPlomb.Installation) dsAbnObjAkt1.vPointCheckPlombAdd.AddvPointCheckPlombAddRow(0, -1, -1, -1, -1, "Установить новую", DateTime.Now, -1);
            cbSealNumber.DataSource = dsAbnObjAkt1.vPointCheckPlombAdd;
            cbSealNumber.DisplayMember = "SeriaNumber";
            cbSealNumber.ValueMember = "id";
            cbSealNumber.SelectedIndex = -1;
            if (actPlomb == ActPlomb.Dismantling)
                FillControlsSealDis();
        }

        /// <summary> Заполняет ComboBox при открытии формы на установку/добавление пломбы
        /// </summary>
        private void FillControlsSealInst(string ids)
        {
            int idWorker, TypePlomb;
            switch ((int)cbSealNumber.SelectedValue)
            {
                /// Заполняет выпадающий список номерами пломб, закрепленных за данным прибором учета
                case -1:
                    if (ids.Length > 0) SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idPointReg = {0} and idUst is not null and id not in ({1})", idPointReg, ids));
                    else SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idPointReg = {0} and idUst is not null", idPointReg));
                    dsAbnObjAkt1.vPointCheckPlombAdd.AddvPointCheckPlombAddRow(0, -1, -1, -1, -1, "Установить новую", DateTime.Now, -1);
                    cbSealNumber.DataSource = dsAbnObjAkt1.vPointCheckPlombAdd;
                    cbSealNumber.DisplayMember = "SeriaNumber";
                    cbSealNumber.ValueMember = "id";
                    cbSealNumber.DroppedDown = true;
                    break;
                /// Заполняет выпадающий список номерами свободных пломб
                case 0:
                    if (cbWorker.SelectedValue != null && cbSealType.SelectedValue != null && int.TryParse(cbWorker.SelectedValue.ToString(), out idWorker) && int.TryParse(cbSealType.SelectedValue.ToString(), out TypePlomb))
                    {
                        if (ids.Length > 0) SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idWorker = {0}  and typePlomb = {1} and idUst is null and id not in ({2})", idWorker, TypePlomb, ids));
                        else SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idWorker = {0}  and typePlomb = {1} and idUst is null", idWorker, TypePlomb));
                        dsAbnObjAkt1.vPointCheckPlombAdd.AddvPointCheckPlombAddRow(-1, -1, -1, -1, -1, "Выбрать существующую", DateTime.Now, -1);
                        cbSealNumber.DataSource = dsAbnObjAkt1.vPointCheckPlombAdd;
                        cbSealNumber.DisplayMember = "SeriaNumber";
                        cbSealNumber.ValueMember = "id";
                        cbSealNumber.DroppedDown = true;
                    }
                    else
                    {
                        if (cbWorker.SelectedValue != null && int.TryParse(cbWorker.SelectedValue.ToString(), out idWorker))
                        {
                            if (ids.Length > 0) SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idWorker = {0} and idUst is null and id not in ({1})", idWorker, ids));
                            else SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idWorker = {0} and idUst is null", idWorker));
                            dsAbnObjAkt1.vPointCheckPlombAdd.AddvPointCheckPlombAddRow(-1, -1, -1, -1, -1, "Выбрать существующую", DateTime.Now, -1);
                            cbSealNumber.DataSource = dsAbnObjAkt1.vPointCheckPlombAdd;
                            cbSealNumber.DisplayMember = "SeriaNumber";
                            cbSealNumber.ValueMember = "id";
                            cbSealNumber.DroppedDown = true;
                        }
                        else
                        {
                            if (cbSealType.SelectedValue != null && int.TryParse(cbSealType.SelectedValue.ToString(), out TypePlomb))
                            {
                                if (ids.Length > 0) SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where typePlomb = {0} and idUst is null id not in ({1})", TypePlomb, ids));
                                else SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where typePlomb = {0} and idUst is null", TypePlomb));
                                dsAbnObjAkt1.vPointCheckPlombAdd.AddvPointCheckPlombAddRow(-1, -1, -1, -1, -1, "Выбрать существующую", DateTime.Now, -1);
                                cbSealNumber.DataSource = dsAbnObjAkt1.vPointCheckPlombAdd;
                                cbSealNumber.DisplayMember = "SeriaNumber";
                                cbSealNumber.ValueMember = "id";
                                cbSealNumber.DroppedDown = true;
                            }
                            else
                            {
                                if (ids.Length > 0) SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idUst is null and id not in ({0})", ids));
                                else SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idUst is null"));
                                dsAbnObjAkt1.vPointCheckPlombAdd.AddvPointCheckPlombAddRow(-1, -1, -1, -1, -1, "Выбрать существующую", DateTime.Now, -1);
                                cbSealNumber.DataSource = dsAbnObjAkt1.vPointCheckPlombAdd;
                                cbSealNumber.DisplayMember = "SeriaNumber";
                                cbSealNumber.ValueMember = "id";
                                cbSealNumber.DroppedDown = true;
                            }
                        }
                    }
                    break;
                /// Заполняет выпадающие списки "Мастер" и "Тип пломбы" соответствующими значениями, при выборе закрепленной за данным прибором учета пломбы
                default:
                    if (dsAbnObjAkt1.vPointCheckPlombAdd.Rows.Count > 1)
                    {
                        var row = dsAbnObjAkt1.vPointCheckPlombAdd.Select("id = " + cbSealNumber.SelectedValue.ToString());
                        cbWState = false;
                        cbTState = false;
                        cbWorker.SelectedValue = row[0]["idWorker"];
                        cbSealType.SelectedValue = row[0]["typePlomb"];
                        cbWState = true;
                        cbTState = true;
                    }
                    break;
            }
        }

        /// <summary> Заполняет ComboBox при открытии формы на демонтаж пломбы
        /// </summary>
        private void FillControlsSealDis()
        {
            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idPointReg = {0} and idUst is not null", idPointReg));
            
            cbSealNumber.DataSource = dsAbnObjAkt1.vPointCheckPlombAdd;
            cbSealNumber.DisplayMember = "SeriaNumber";
            cbSealNumber.ValueMember = "id";
            cbSealNumber.SelectedIndex = -1;
            
            cbWorker.SelectedIndex = -1;
            
            cbSealType.SelectedIndex = -1;
            
            cbSealNumber.DroppedDown = true;
        }
        #endregion

        #region Events ComboBox
        /// <summary> Обработка события при выборе значения выпадающего списка "Тип пломбы"
        /// </summary>
        /// <remarks> Заполняет выпадающий список номерами пломб, закрепленных за данным прибором учета
        /// </remarks>
        private void cbSealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSealType.SelectedValue != null && int.TryParse(cbSealType.SelectedValue.ToString(), out SelectedValue) && cbTState)
                if (cbWorker.SelectedValue != null && int.TryParse(cbWorker.SelectedValue.ToString(), out SelectedValue))
                {
                    if (ids.Length > 0) SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idPointReg = {0} and idUst is not null and typePlomb = {1} and idWorker = {2} and id not in (" + ids + ")", idPointReg, (int)cbSealType.SelectedValue, (int)cbWorker.SelectedValue));
                    else SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idPointReg = {0} and idUst is not null and typePlomb = {1} and idWorker = {2}", idPointReg, (int)cbSealType.SelectedValue, (int)cbWorker.SelectedValue));
                    if (actPlomb == ActPlomb.Installation) dsAbnObjAkt1.vPointCheckPlombAdd.AddvPointCheckPlombAddRow(0, -1, -1, -1, -1, "Установить новую", DateTime.Now, -1);
                    cbSealNumber.DataSource = dsAbnObjAkt1.vPointCheckPlombAdd;
                    cbSealNumber.DisplayMember = "SeriaNumber";
                    cbSealNumber.ValueMember = "id";
                    cbSealNumber.SelectedIndex = -1;
                }
                else
                {
                    if (ids.Length > 0) SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idPointReg = {0} and idUst is not null and typePlomb = {1} and id not in (" + ids + ")", idPointReg, (int)cbSealType.SelectedValue));
                    else SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idPointReg = {0} and idUst is not null and typePlomb = {1}", idPointReg, (int)cbSealType.SelectedValue));
                    if (actPlomb == ActPlomb.Installation) dsAbnObjAkt1.vPointCheckPlombAdd.AddvPointCheckPlombAddRow(0, -1, -1, -1, -1, "Установить новую", DateTime.Now, -1);
                    cbSealNumber.DataSource = dsAbnObjAkt1.vPointCheckPlombAdd;
                    cbSealNumber.DisplayMember = "SeriaNumber";
                    cbSealNumber.ValueMember = "id";
                    cbSealNumber.SelectedIndex = -1;
                }
        }

        private void cbWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWorker.SelectedValue != null && int.TryParse(cbWorker.SelectedValue.ToString(), out SelectedValue) && cbWState)
                if (cbSealType.SelectedValue != null && int.TryParse(cbSealType.SelectedValue.ToString(), out SelectedValue))
                {
                    if (ids.Length > 0) SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idPointReg = {0} and idUst is not null and typePlomb = {1} and idWorker = {2} and id not in (" + ids + ")", idPointReg, (int)cbSealType.SelectedValue, (int)cbWorker.SelectedValue));
                    else SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idPointReg = {0} and idUst is not null and typePlomb = {1} and idWorker = {2}", idPointReg, (int)cbSealType.SelectedValue, (int)cbWorker.SelectedValue));
                    if (actPlomb == ActPlomb.Installation) dsAbnObjAkt1.vPointCheckPlombAdd.AddvPointCheckPlombAddRow(0, -1, -1, -1, -1, "Установить новую", DateTime.Now, -1);
                    cbSealNumber.DataSource = dsAbnObjAkt1.vPointCheckPlombAdd;
                    cbSealNumber.DisplayMember = "SeriaNumber";
                    cbSealNumber.ValueMember = "id";
                    cbSealNumber.SelectedIndex = -1;
                }
                else
                {
                    if (ids.Length > 0) SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idPointReg = {0} and idUst is not null and idWorker = {1} and id not in (" + ids + ")", idPointReg, (int)cbWorker.SelectedValue));
                    else SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckPlombAdd, true, String.Format("where idPointReg = {0} and idUst is not null and idWorker = {1}", idPointReg, (int)cbWorker.SelectedValue));
                    if (actPlomb == ActPlomb.Installation) dsAbnObjAkt1.vPointCheckPlombAdd.AddvPointCheckPlombAddRow(0, -1, -1, -1, -1, "Установить новую", DateTime.Now, -1);
                    cbSealNumber.DataSource = dsAbnObjAkt1.vPointCheckPlombAdd;
                    cbSealNumber.DisplayMember = "SeriaNumber";
                    cbSealNumber.ValueMember = "id";
                    cbSealNumber.SelectedIndex = -1;
                }
        }

        /// <summary> Обработка события при выборе значения выпадающего списка "Номер пломбы"
        /// </summary>
        private void cbSealNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSealNumber.SelectedValue != null && int.TryParse(cbSealNumber.SelectedValue.ToString(), out SelectedValue) && cbNState)
            {

                switch (actPlomb)
                {
                    case ActPlomb.Installation:
                        FillControlsSealInst(ids);
                        break;
                    case ActPlomb.Dismantling:
                        if (dsAbnObjAkt1.vPointCheckPlombAdd.Rows.Count > 0)
                        {
                            var row = dsAbnObjAkt1.vPointCheckPlombAdd.Select("id = " + cbSealNumber.SelectedValue.ToString());
                            cbWState = false;
                            cbTState = false;
                            cbWorker.SelectedValue = row[0]["idWorker"];
                            cbSealType.SelectedValue = row[0]["typePlomb"];
                        }
                        break;
                }
            }
            cbWState = true;
            cbTState = true;
        }
        #endregion

        #region Events button

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmCheck = (FormDocAct_CheckAdd)Application.OpenForms["FormDocAct_CheckAdd"];
            switch (actPlomb)
            {

                case ActPlomb.Installation:
                    /// Установка свободной пломбы и добавление ее в акт
                    if ((int)dsAbnObjAkt1.vPointCheckPlombAdd.Rows[dsAbnObjAkt1.vPointCheckPlombAdd.Rows.Count - 1]["id"] == -1)
                    {
                        //frmCheck = (FormDocAct_CheckAdd)Application.OpenForms["FormDocAct_CheckAdd"];
                        if (docType == DocType.ActCheck) frmCheck.SealRowsAdd((int)cbSealNumber.SelectedValue, cbSealNumber.Text, (int)cbWorker.SelectedValue, tbSealLocation.Text, tbSealComment.Text, Seal.New, device);
                        if (docType == DocType.ActMeterDismantling || docType == DocType.ActMeterInstallation || docType == DocType.ActMeterkReplacement)
                        {
                            frmDemUst = (FormDocAct_DemUst)Application.OpenForms["FormDocAct_DemUst"];
                            frmDemUst.SealRowsAdd((int)cbSealNumber.SelectedValue, cbSealNumber.Text, (int)cbWorker.SelectedValue, tbSealLocation.Text, tbSealComment.Text, device);
                        }
                    }
                    /// Добавление существующей пломбы в акт
                    else
                        if (docType == DocType.ActCheck) frmCheck.SealRowsAdd((int)cbSealNumber.SelectedValue, cbSealNumber.Text, tbSealLocation.Text, tbSealComment.Text, Seal.Old, device);
                    break;
                case ActPlomb.Dismantling:
                    if (docType == DocType.ActCheck) frmCheck.SealRowsAdd((int)cbSealNumber.SelectedValue, cbSealNumber.Text, (int)cbWorker.SelectedValue, tbSealLocation.Text, tbSealComment.Text, Seal.Dis, device);
                    break;
            }
        }

        #endregion



    }
}
