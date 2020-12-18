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
using Legal.DataSet;

namespace Legal.Forms.ActCheck
{
    public partial class FormDocAct_DemUst : FormActBase
    {
        int idAbnObj;
        //int idPointMeterInst, idPointMeterDis;
        int /*idPointTransCurrentInst,*/ idPointTransCurrentDis;
        int /*idPointTransVoltageInst,*/ idPointTransVoltageDis;
        int idZone;
        DocType docType;
        bool FormShown = false;
        List<int> idDevice = new List<int>();
        int idDeviceMeterInst = -1, idDeviceTransCurrentInst = -1, idDeviceTransVoltageInst = -1;
        int idDeviceMeterDis = -1/*, idDeviceTransCurrentDis = -1, idDeviceTransVoltageDis = -1*/;
        BindingSource bdsMeterInst, bdsMeterDis;
        BindingSource bdsJobTitle = new BindingSource();
        BindingSource bdsWorker = new BindingSource();
        string ids = "";

        #region Designer

        public FormDocAct_DemUst()
        {
            InitializeComponent();
        }

        public FormDocAct_DemUst(SQLSettings settings, int idAbnObj, DocType docType)
        {
            InitializeComponent();
            this.SqlSettings = settings;
            this.idAbnObj = idAbnObj;
            this.docType = docType;
            switch (docType)
            {
                case DocType.ActMeterInstallation:
                    tpDismantling.Dispose();
                    this.Text = "Акт технической установки средств учета электрической энергии";
                    break;
                case DocType.ActMeterDismantling:
                    tbInstalation.Dispose();
                    this.Text = "Акт технического демонтажа средств учета электрической энергии";
                    break;
                case DocType.ActMeterkReplacement:
                    this.Text = "Акт технической замены средств учета электрической энергии";
                     break;
            }
            FillMeterDataComboBoxControl(idAbnObj, docType, true);
            FillRepresentDataComboBoxControl();
            FillTransDataComboBoxControl(idAbnObj, docType, true);
            FormShown = true;
        }
        #endregion



        /// <summary> Заполнение ComboBox-ов данными по должностям и фамилиям мастеров
        /// </summary>
        private void FillRepresentDataComboBoxControl()
        {
            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tR_JobTitle, true, "where id like 3 or id like 2 or id like 272");
            SelectSqlData(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckWorker, true);
            bdsJobTitle.DataSource = dsAbnObjAkt1;
            bdsJobTitle.DataMember = dsAbnObjAkt1.tR_JobTitle.TableName;
            bdsWorker.DataSource = dsAbnObjAkt1;
            bdsWorker.DataMember = dsAbnObjAkt1.vPointCheckWorker.TableName;
            cbWorkerJobTitle.DataSource = bdsJobTitle;
            cbWorkerJobTitle.DisplayMember = "Description";
            cbWorkerJobTitle.ValueMember = "id";
            cbWorkerJobTitle.SelectedIndex = -1;
        }

        /// <summary> Заполнение ComboBox-ов данными по счетчикам
        /// </summary>
        /// <param name="idAbnObj">Идентификатор объекта абонента</param>
        /// <param name="docType">Тип документа</param>
        /// <param name="NullSelected"></param>
        private void FillMeterDataComboBoxControl(int idAbnObj, DocType docType, bool NullSelected)
        {
            if (docType == DocType.ActMeterInstallation || docType == DocType.ActMeterkReplacement)
            {
                SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckMeterFillInst, "vPointCheckMeterFill", true, String.Format("where idAbnObj = {0} and Type = {1}  and PointRegDateEnd is null and PointDateEnd is null", idAbnObj, (int)DevicePointType.Meter));
                bdsMeterInst = new BindingSource();
                bdsMeterInst.DataSource = dsAbnObjAkt1.vPointCheckMeterFillInst;
                cbNumMeterInst.DataSource = bdsMeterInst;
                cbNumMeterInst.DisplayMember = "Number";
                cbNumMeterInst.ValueMember = "idPointReg";
                if (NullSelected) cbNumMeterInst.SelectedIndex = -1;
                cbTypeMeterInst.DataSource = bdsMeterInst;
                cbTypeMeterInst.DisplayMember = "Name";
                cbTypeMeterInst.ValueMember = "idPointReg";
                if (NullSelected) cbTypeMeterInst.SelectedIndex = -1;
            }
            if (docType == DocType.ActMeterDismantling || docType == DocType.ActMeterkReplacement)
            {
                SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckMeterFillDis, "vPointCheckMeterFill", true, String.Format("where idAbnObj = {0} and Type = {1} and PointRegDateEnd is not null and PointDateEnd is not null", idAbnObj, (int)DevicePointType.Meter));
                bdsMeterDis = new BindingSource();
                bdsMeterDis.DataSource = dsAbnObjAkt1.vPointCheckMeterFillDis;
                cbNumMeterDis.DataSource = bdsMeterDis;
                cbNumMeterDis.DisplayMember = "Number";
                cbNumMeterDis.ValueMember = "idPointReg";
                if (NullSelected) cbNumMeterDis.SelectedIndex = -1;
                cbTypeMeterDis.DataSource = dsAbnObjAkt1.vPointCheckMeterFillDis;
                cbTypeMeterDis.DisplayMember = "Name";
                cbTypeMeterDis.ValueMember = "idPointReg";
                if (NullSelected) cbTypeMeterDis.SelectedIndex = -1;
            }
        }

        /// <summary> Заполнение ComboBox-ов данными по трансформаторам
        /// </summary>
        /// <param name="idAbnObj">Идентификатор объекта абонента</param>
        /// <param name="docType">Тип документа</param>
        private void FillTransDataComboBoxControl(int idAbnObj, DocType docType, bool NullSelected)
        {
            if (docType == DocType.ActMeterInstallation || docType == DocType.ActMeterkReplacement)
            {
                SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckTransFillInst, 
                    "vPointCheckTransFill", true, 
                    String.Format("where idAbnObj = {0} and Type = {1} and PointRegDateEnd is null and PointDateEnd is null", 
                    idAbnObj, (short)DevicePointType.TransAmperage));
                var tTransI = dsAbnObjAkt1.vPointCheckTransFillInst.Select(String.Format("TypeTrans = {0}",(short)TransPointType.TransCurrent));
                var tTransU = dsAbnObjAkt1.vPointCheckTransFillInst.Select(String.Format("TypeTrans = {0}", (short)TransPointType.TransVoltage));
                if (tTransI.Length > 0)
                {
                    cbTypeTransIInst.DataSource = tTransI.CopyToDataTable<DataRow>();
                    cbTypeTransIInst.DisplayMember = "Name";
                    cbTypeTransIInst.ValueMember = "idPointReg";
                    if (NullSelected) cbTypeTransIInst.SelectedIndex = -1;
                }
                else
                    cbTypeTransIInst.DataSource = null;
                if (tTransU.Length > 0)
                {
                    cbTypeTransUInst.DataSource = tTransU.CopyToDataTable<DataRow>();
                    cbTypeTransUInst.DisplayMember = "Name";
                    cbTypeTransUInst.ValueMember = "idPointReg";
                    if (NullSelected) cbTypeTransUInst.SelectedIndex = -1;
                }
                else
                    cbTypeTransUInst.DataSource = null;
            }
            if (docType == DocType.ActMeterDismantling || docType == DocType.ActMeterkReplacement)
            {
                SelectSqlDataTableOther(dsAbnObjAkt1, dsAbnObjAkt1.vPointCheckTransFillDis, "vPointCheckTransFill", true, String.Format("where idAbnObj = {0} and Type = {1} and PointRegDateEnd is not null and PointDateEnd is not null", idAbnObj, (short)DevicePointType.TransAmperage));
                var tTransI = dsAbnObjAkt1.vPointCheckTransFillDis.Select(String.Format("TypeTrans = {0}", (short)TransPointType.TransCurrent));
                var tTransU = dsAbnObjAkt1.vPointCheckTransFillDis.Select(String.Format("TypeTrans = {0}", (short)TransPointType.TransVoltage));
                if (tTransI.Length > 0)
                {
                    cbTypeTransIDis.DataSource = tTransI.CopyToDataTable<DataRow>();
                    cbTypeTransIDis.DisplayMember = "Name";
                    cbTypeTransIDis.ValueMember = "idPointReg";
                    if (NullSelected) cbTypeTransIDis.SelectedIndex = -1;
                    idPointTransCurrentDis = (int)tTransI[0]["idPoint"];
                }
                else
                    cbTypeTransIDis.DataSource = null;
                if (tTransU.Length > 0)
                {
                    cbTypeTransUDis.DataSource = tTransU.CopyToDataTable<DataRow>();
                    cbTypeTransUDis.DisplayMember = "Name";
                    cbTypeTransUDis.ValueMember = "idPointReg";
                    if (NullSelected) cbTypeTransUDis.SelectedIndex = -1;
                    idPointTransVoltageDis = (int)tTransI[0]["idPoint"];
                }
                else
                    cbTypeTransUDis.DataSource = null;
            }
        }

        #region Заполнение/очистка компонентов отображения информации по счетчикам

        /// <summary> Заполнение компонентов отображения информации по счетчикам акта установки
        /// </summary>
        private void FillDataMeterInstControls(int idAbnObj, string ColumnName, string ColumnValue)
        {
            DataRow[] dr = dsAbnObjAkt1.vPointCheckMeterFillInst.Select(ColumnName + " like '" + ColumnValue + "'");
            DateTime DateCheck;
            if (dr.Length > 0)
            {
                switch (ColumnName)
                {
                    case "Number":
                        cbTypeMeterInst.Text = dr[0]["Name"].ToString();
                        break;
                    case "Name":
                        cbNumMeterInst.Text = dr[0]["Number"].ToString();
                        break;
                    default:
                        break;
                }
                tbCapasityMeterInst.Text = dr[0]["Phaze"].ToString();
                if (DateTime.TryParse(dr[0]["DateCheck"].ToString(), out DateCheck)) qybCalibrationMeterInst.Date = DateCheck; else qybCalibrationMeterInst.Clear();
                if (!int.TryParse(dr[0]["idZone"].ToString(), out idZone)) idZone = (int)OnePartTariffType.TwentyFourHours;
            }
            else
            {
                ClearDataMeterInstControls(ComboBoxName.cbTypeMeter);
                cbTypeTransIInst.DataSource = null;
                cbTypeTransUInst.DataSource = null;
            }
        }

        /// <summary> Очистка компонентов отображения информации по счетчикам акта установки
        /// </summary>
        private void ClearDataMeterInstControls(ComboBoxName value)
        {
            switch (value)
            {
                case ComboBoxName.cbNumMeterInst: cbTypeMeterInst.SelectedIndex = -1; break;
                case ComboBoxName.cbTypeMeterInst: cbNumMeterInst.SelectedIndex = -1; break;
                case ComboBoxName.cbAllMeterInst: cbTypeMeterInst.SelectedIndex = -1; cbNumMeterInst.SelectedIndex = -1; break;
                default: break;
            }
            tbCapasityMeterInst.Clear();
            tbCurrentValueMeterInst.Clear();
            qybCalibrationMeterInst.Clear();
        }

        /// <summary> Заполнение компонентов отображения информации по счетчикам акта демонтажа
        /// </summary>
        private void FillDataMeterDisControls(int idAbnObj, string ColumnName, string ColumnValue)
        {
            DataRow[] dr = dsAbnObjAkt1.vPointCheckMeterFillDis.Select(ColumnName + " like '" + ColumnValue + "'");
            DateTime DateCheck;
            if (dr.Length > 0)
            {
                switch (ColumnName)
                {
                    case "Number":
                        cbTypeMeterDis.Text = dr[0]["Name"].ToString();
                        break;
                    case "Name":
                        cbNumMeterDis.Text = dr[0]["Number"].ToString();
                        break;
                    default:
                        break;
                }
                tbCapasityMeterDis.Text = dr[0]["Phaze"].ToString();
                if (DateTime.TryParse(dr[0]["DateCheck"].ToString(), out DateCheck)) qybCalibrationMeterDis.Date = DateCheck; else qybCalibrationMeterDis.Clear();
                if (!int.TryParse(dr[0]["idZone"].ToString(), out idZone)) idZone = (int)OnePartTariffType.TwentyFourHours;
            }
            else
            {
                ClearDataMeterDisControls(ComboBoxName.cbTypeMeter);
                cbTypeTransIDis.DataSource = null;
                cbTypeTransUDis.DataSource = null;
            }
        }

        /// <summary> Очистка компонентов отображения информации по счетчикам акта демонтажа
        /// </summary>
        private void ClearDataMeterDisControls(ComboBoxName value)
        {
            switch (value)
            {
                case ComboBoxName.cbNumMeterDis: cbTypeMeterDis.SelectedIndex = -1; break;
                case ComboBoxName.cbTypeMeterDis: cbNumMeterDis.SelectedIndex = -1; break;
                case ComboBoxName.cbAllMeterDis: cbTypeMeterDis.SelectedIndex = -1; cbNumMeterDis.SelectedIndex = -1; break;
                default: break;
            }
            tbCapasityMeterDis.Clear();
            tbCurrentValueMeterDis.Clear();
            qybCalibrationMeterDis.Clear();
        }

        #endregion

        #region Заполнение/очистка компонентов отображения информации по трансформаторам
        
        /// <summary> Заполнение компонентов отображения информации по трансформаторам
        /// </summary>
        private void FillDataTransControls(ComboBoxName TransComboBoxName, string Name)
        {
            switch (TransComboBoxName)
            {
                case ComboBoxName.cbTypeTransIInst:
                    DataRow[] drI = dsAbnObjAkt1.vPointCheckTransFill.Select("Name like '" + Name + "'");
                    if (drI.Length > 0)
                    {
                        tbNumTransIInst.SelectedText = drI[0]["Number"].ToString();
                        tbNumTransIInst.Text = drI[0]["Number"].ToString();
                        tbNomTransIBegInst.Text = drI[0]["Primary"].ToString();
                        tbNomTransIEndInst.Text = drI[0]["Secondary"].ToString();
                        qybCalibrationTransIInst.Date = DateTime.Parse(drI[0]["DateCheck"].ToString());
                        tbRatioTransIInst.Text = int.Parse((int.Parse(tbNomTransIBeg.Text) / int.Parse(tbNomTransIEndInst.Text)).ToString()).ToString();
                    }
                    else
                    {
                        tbNomTransIBegInst.Clear();
                        tbNomTransIBegInst.Clear();
                        tbRatioTransIInst.Clear();
                    }
                    break;
                case ComboBoxName.cbTypeTransUInst:
                    DataRow[] drU = dsAbnObjAkt1.vPointCheckTransFill.Select("Name like '" + Name + "%'");
                    if (drU.Length > 0)
                    {
                        tbNumTransUInst.SelectedText = drU[0]["Number"].ToString();
                        tbNumTransUInst.Text = drU[0]["Number"].ToString();
                        tbNomTransUBegInst.Text = drU[0]["Primary"].ToString();
                        tbNomTransUEndInst.Text = drU[0]["Secondary"].ToString();
                        qybCalibrationTransUInst.Date = DateTime.Parse(drU[0]["DateCheck"].ToString());
                        tbRatioTransUInst.Text = int.Parse((int.Parse(tbNomTransUBegInst.Text) / int.Parse(tbNomTransUEndInst.Text)).ToString()).ToString();
                    }
                    else
                    {
                        
                    }
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Установка новой точки учета

        #endregion

        #region Добавление и монтаж пломб
        private void tsbSealMeterInstAdd_Click(object sender, EventArgs e)
        {
            FormDocAct_SealInstDis frm = null;
            if (cbTypeMeterInst.SelectedValue != null)
            {
                frm = new FormDocAct_SealInstDis(this.SqlSettings, docType, idDeviceMeterInst, Convert.ToInt32(cbTypeMeterInst.SelectedValue), ActPlomb.Installation, Device.Meter, ids);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите счетчик электроэнергии", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsbSealTransIInstAdd_Click(object sender, EventArgs e)
        {
            FormDocAct_SealInstDis frm = null;
            if (cbTypeTransIInst.SelectedValue != null)
            {
                frm = new FormDocAct_SealInstDis(this.SqlSettings, DocType.ActCheck, idDeviceTransCurrentInst, Convert.ToInt32(cbTypeTransIInst.SelectedValue), ActPlomb.Installation, Device.TransCurrent, ids);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите трансформатор тока", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsbSealTransUInstAdd_Click(object sender, EventArgs e)
        {
            FormDocAct_SealInstDis frm = null;
            if (cbTypeTransUInst.SelectedValue != null)
            {
                frm = new FormDocAct_SealInstDis(this.SqlSettings, DocType.ActCheck, idDeviceTransVoltageInst, Convert.ToInt32(cbTypeTransUInst.SelectedValue), ActPlomb.Installation, Device.TransVoltage, ids);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите трансформатор напряжения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Демонтаж пломб
        private void tsbSealMeterDelete_Click(object sender, EventArgs e)
        {
            FormDocAct_SealInstDis frm = null;
            if (cbNumMeterDis.SelectedValue != null)
            {
                frm = new FormDocAct_SealInstDis(this.SqlSettings, DocType.ActCheck, idDeviceMeterDis, Convert.ToInt32(cbTypeMeterDis.SelectedValue), ActPlomb.Dismantling, Device.Meter, ids);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите счетчик электроэнергии", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsbSealTransIDelete_Click(object sender, EventArgs e)
        {
            FormDocAct_SealInstDis frm = null;
            if (cbTypeTransIDis.SelectedValue != null)
            {
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите трансформатор тока", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsbSealTransUDelete_Click(object sender, EventArgs e)
        {
            FormDocAct_SealInstDis frm = null;
            if (cbTypeTransUDis.SelectedValue != null)
            {
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Выберите трансформатор напряжения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (docType)
            {
                case DocType.ActMeterInstallation:
                    SaveActInstallation();
                    break;
                case DocType.ActMeterDismantling:
                    break;
                case DocType.ActMeterkReplacement:
                    break;
            }
        }

        private void cbWorkerJobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWorkerJobTitle.Visible)
            {
                bdsWorker.Filter = String.Format("JobTitle = {0}", cbWorkerJobTitle.SelectedValue);
                cbWorkerFIO.DataSource = bdsWorker;
                cbWorkerFIO.DisplayMember = "FIO";
                cbWorkerFIO.ValueMember = "idWorker";
            }
        }

        #region Заполнение DataTable'ов информацией об установке пломб
        public void SealRowsAdd(int idSeal, string Number, int idWorker, string Location, string Comment, Device device)
        {
            switch (device)
            {
                case Device.Meter:
                    dsAbnObjAkt1.SealMeterInst.AddSealMeterInstRow(idSeal.ToString(), Number, "Установка", Location, Comment, idWorker.ToString());
                    dgvSealMeterInst.DataSource = dsAbnObjAkt1.SealMeterInst;
                    break;
                case Device.TransCurrent:
                    dsAbnObjAkt1.SealTransCurrentInst.AddSealTransCurrentInstRow(idSeal.ToString(), Number, "Установка", Location, Comment, idWorker.ToString());
                    dgvSealTransIInst.DataSource = dsAbnObjAkt1.SealTransCurrentInst;
                    break;
                case Device.TransVoltage:
                    dsAbnObjAkt1.SealTransVoltageInst.AddSealTransVoltageInstRow(idSeal.ToString(), Number, "Установка", Location, Comment, idWorker.ToString());
                    dgvSealTransUInst.DataSource = dsAbnObjAkt1.SealTransVoltageInst;
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void cbTypeMeterInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormShown) FillMeterInstComponentData(((ComboBox)sender).SelectedIndex);
        }

        private void cbNumMeterDis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormShown) FillMeterInstComponentData(((ComboBox)sender).SelectedIndex); 
        }

        /// <summary> Запполнение компонентов отображения информации по счетчикам для установке
        /// </summary>
        /// <param name="index">Индекс выделенного элемента в выпадаюжем списке</param>
        private void FillMeterInstComponentData(int index)
        {
            DateTime date = new DateTime();
            cbTypeMeterInst.SelectedIndex = index;
            cbNumMeterInst.SelectedIndex = index;
            var data = (DataRowView)bdsMeterInst.Current;
            tbCapasityMeterInst.Text = data.Row["Phaze"].ToString();
            if (DateTime.TryParse(data.Row["DateCheck"].ToString(), out date)) qybCalibrationMeterInst.Date = date;            
        }

        /// <summary> Запполнение компонентов отображения информации по счетчикам для демонтажа
        /// </summary>
        /// <param name="index">Индекс выделенного элемента в выпадаюжем списке</param>
        private void FillMeterDisComponentData(int index)
        {
            DateTime date = new DateTime();
            cbTypeMeterDis.SelectedIndex = index;
            cbNumMeterDis.SelectedIndex = index;
            var data = (DataRowView)bdsMeterDis.Current;
            tbCapasityMeterDis.Text = data.Row["Phaze"].ToString();
            if (DateTime.TryParse(data.Row["DateCheck"].ToString(), out date)) qybCalibrationMeterDis.Date = date;
        }

        private void SaveActInstallation()
        {
            if (cbTypeMeterInst.SelectedIndex == -1)
            {
                Meter.FormMeterAddEdit fAdd = new Meter.FormMeterAddEdit(idAbnObj, -1, false);
                fAdd.SqlSettings = this.SqlSettings;
                fAdd.ShowDialog();

            }
        }

        

    }
}
