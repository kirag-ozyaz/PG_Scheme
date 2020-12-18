using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using Constants;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using DailyReportN.DataSet;
using DataSql;
//using Documents.Properties;
using FormLbr;
using FormLbr.Classes;
using RequestForRepairN;
using RequestsClient.Forms.JournalRequestForRepair;
//using SchemeModel;
//using SchemeModel.Calculations;

using SchemeModelN;
using SchemeModelN.Calculations;
using StatementsForME;
/// <summary>
/// Аварийное отключение 0,4 кВ (N2)
/// </summary>
namespace DailyReportN.JournalDamage
{
    internal partial class FormDamageLVAddEdit : FormBase
    {

        internal int IdDocument = -1;
        private string captionDocParent = "";
        /// <summary>
        /// флаг изменения данных в реквизитах (контролах на форме)
        /// </summary>
        private bool isChangedData;
        /// <summary>
        /// флан чтения или редактирования  документа
        /// </summary>
        private bool flagViewDoc;

        private DataTable dtSchmCable = new DataTable("SchmCable");
        private DateTime DateFactEnd = DateTimePicker.MaximumDateTime;

        private eTypeDocuments TypeDocument = (eTypeDocuments.DamageLV);

        public int KladrObjId { get; private set; }
        private delegate TreeDataGridViewNode TreeParametr(TreeDataGridViewNodeCollection nodes, params object[] values);
        /// <summary>
        /// список подстанций
        /// </summary>
        private List<int> listElectricBus;
        private object isSendSiteMe;

        internal int GetIdDocument()
        {
            return this.IdDocument;
        }
        /// <summary>
        ///  вернуть режим просомтра документа
        /// </summary>
        /// <returns></returns>
        internal bool GetFormViewMode()
        {
            return this.flagViewDoc;
        }
        /// <summary>
        /// установить режим просмотра документа, при открытии из других документов и журналов 
        /// </summary>
        internal void SetFormViewMode(bool flag)
        {
            this.flagViewDoc = flag;
            this.ControlBlockingOtherDocuments();
        }
        /// <summary>
        /// блокировка контролов из других документов
        /// </summary>
        private void ControlBlockingOtherDocuments()
        {
            if (this.GetFormViewMode())
            {
                this.Text = "Просмотр документа аварийное отключение 0,4 кВ" + " (N2)";
            }

            this.txtNumRequest.ReadOnly = this.GetFormViewMode();
            this.dtpDateDoc.Enabled = !this.GetFormViewMode();
            this.cmbCompiler.ReadOnly = this.GetFormViewMode();
            this.cmbDivision.ReadOnly = this.GetFormViewMode();
            this.txtDeclarer.ReadOnly = this.GetFormViewMode();
            this.txtDeclarerTel.ReadOnly = this.GetFormViewMode();
            this.txtDeclarerAddress.ReadOnly = this.GetFormViewMode();
            this.btnChoiceSchmObj.Enabled = !this.GetFormViewMode();
            this.txtLocation.ReadOnly = this.GetFormViewMode();
            this.cmbObl.ReadOnly = (this.cmbRaionObl.ReadOnly = (this.cmbCity.ReadOnly = (this.cmbStreet.ReadOnly = this.GetFormViewMode())));
            this.txtHouse.ReadOnly = (this.txtHousePrefix.ReadOnly = this.GetFormViewMode());
            this.cmbReason.ReadOnly = this.GetFormViewMode();
            this.dgvCharacterDamage.ReadOnly = this.GetFormViewMode();
            this.cmbCompletedWork.ReadOnly = this.GetFormViewMode();
            this.txtCompletedWork.ReadOnly = this.GetFormViewMode();
            this.checkBoxApply.Enabled = !this.GetFormViewMode();
            this.cmbWorkerApply.ReadOnly = this.GetFormViewMode();
            this.dtpDataApply.Enabled = !this.GetFormViewMode();
            this.chbDefect.Enabled = !this.GetFormViewMode();
            this.cmbDivisionApply.ReadOnly = this.GetFormViewMode();
            this.checkBoxLaboratory.Enabled = !this.GetFormViewMode();
            this.txtLaboratoryInstruction.ReadOnly = (this.txtDivisionInstruction.ReadOnly = (!this.chbDefect.Checked && this.GetFormViewMode()));
            this.cmbReasonPTS.ReadOnly = this.GetFormViewMode();
            this.ColumnBtn.Visible = !this.GetFormViewMode();
#if !DEBUG
            this.toolBtnRefreshAbn.Enabled = !this.GetFormViewMode();
#endif
            this.toolBtnDelAbn.Enabled = !this.GetFormViewMode();
            this.toolBtnRefreshTrans.Enabled = !this.GetFormViewMode();

            this.buttonSave.Visible = !this.GetFormViewMode();
            this.toolBtn81.Enabled = !this.GetFormViewMode();
            this.toolBtnRefreshCountAbn.Enabled = !this.GetFormViewMode();
            this.numCountPointCat1.ReadOnly = (this.numCountPointCat1Full.ReadOnly = (this.numCountPointCat2.ReadOnly = (this.numCountPointCat2Full.ReadOnly = (this.numCountPointCat3.ReadOnly = (this.numCountPointEE.ReadOnly = (this.numCountPointSource.ReadOnly = this.GetFormViewMode()))))));
            this.numCountAbnObjCat1.ReadOnly = (this.numCountAbnObjCat1Full.ReadOnly = (this.numCountAbnObjCat2.ReadOnly = (this.numCountAbnObjCat2Full.ReadOnly = (this.numCountAbnObjCat3.ReadOnly = (this.numCountAbnObjEE.ReadOnly = (this.numCountAbnObjSource.ReadOnly = this.GetFormViewMode()))))));
            this.numCountAbnObj150.ReadOnly = (this.numCountAbnObj150670.ReadOnly = (this.numCountAbnObj670.ReadOnly = this.GetFormViewMode()));
        }

        internal FormDamageLVAddEdit(int idDocument = -1, eTypeDocuments typeDoc = (eTypeDocuments.DamageLV))
        {
            this.InitializeComponent();
            this.dtpDateDoc.Value = DateTime.Now;
            this.dtpDataApply.Value = DateTime.Now.Date;
            this.IdDocument = idDocument;
            this.TypeDocument = typeDoc;
            if (typeDoc == (eTypeDocuments.DamageLV))
            {
                this.Text = ((idDocument == -1) ? "Добавить аварийное отключение 0,4 кВ" : (this.GetFormViewMode() ? "Просмотр документа аварийное отключение 0,4 кВ" : "Редактировать аварийное отключение 0,4 кВ")) + " (N2)";

            }
            else
                this.Text = ((idDocument == -1) ? "Добавить повреждение УО" : (this.GetFormViewMode() ? "Просмотр повреждение УО" : "Редактировать повреждение УО")) + " (N2)";
            //
            //this.dtSchmCable = new DataTable("SchmCable");
        }

        private void FormDamageLVAddEdit_Load(object sender, EventArgs e)
        {

            this.GetVisibleChkSendSiteME();
            this.LoadDocumentDamage();
            this.FillComboBoxDivision();
            this.FillComboBoxCompiler();
            this.FillComboBoxObl();
            this.FillComboBoxReason();
            this.FillComboBoxCompletedWork();
            this.FillComboBoxWorkerApply();
            this.FillComboBoxDivisionApply();
            this.FillComboBoxWindDirect();
            this.FillComboBoxReasonPTS();
            this.FillDataSourceTypeAbn();
            this.FillDataSourceColumnTypeObj();
            base.LoadFormConfig(null);
            //ReferenceTables.CreateReferenceTables.getTextSendSiteME(this.SqlSettings);
            if (this.IdDocument == -1)
            {
                DataRow dataRow = this.dataSetDamage.tJ_Damage.NewRow();
                dataRow["TypeDoc"] = this.TypeDocument;
                dataRow["DateOwner"] = DateTime.Now;
                this.dataSetDamage.tJ_Damage.Rows.Add(dataRow);
                this.CreateDocumentCharacteristics();
            }
            else
            {
                DailyReportN.DataSet.dsDamage.tJ_DamageDataTable tableDamageL = new DailyReportN.DataSet.dsDamage.tJ_DamageDataTable();

                base.SelectSqlData(tableDamageL, true, "where id = " + this.IdDocument.ToString(), null, false, 0);
                if (tableDamageL.Rows.Count > 0 && tableDamageL.Rows[0]["dateDoc"] != DBNull.Value)
                {
                    this.dtpDateDoc.Value = Convert.ToDateTime(tableDamageL.Rows[0]["dateDoc"]);
                }
                base.SelectSqlData(this.dataSetDamage.tJ_Damage, true, "where id = " + this.IdDocument.ToString(), null, false, 0);
                if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
                {
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["numDoc"] != DBNull.Value)
                    {
                        // this.Text = this.Text + " №" + this.dataSetDamage.tJ_Damage.Rows[0]["numDoc"].ToString();
                        this.Text = this.Text
                            + "  №" + this.dataSetDamage.tJ_Damage.Rows[0]["numDoc"].ToString()
                            + " (заявка №" + this.dataSetDamage.tJ_Damage.Rows[0]["NumRequest"].ToString() + ")"
                            + " от " + Convert.ToDateTime(this.dataSetDamage.tJ_Damage.Rows[0]["DateDoc"]).ToShortDateString();
                    }
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"] != DBNull.Value)
                    {
                        this.txtSchmObj.Text = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                        {
                        this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"].ToString()
                        }).ToString();
                    }
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["idDivisionApply"] != DBNull.Value || (this.dataSetDamage.tJ_Damage.Rows[0]["isLaboratory"] != DBNull.Value && Convert.ToBoolean(this.dataSetDamage.tJ_Damage.Rows[0]["isLaboratory"])))
                    {
                        this.chbDefect.Checked = true;
                    }
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["is81"] != DBNull.Value && !Convert.ToBoolean(this.dataSetDamage.tJ_Damage.Rows[0]["is81"]))
                    {
                        this.toolBtn81.Checked = true;
                    }
                    else
                    {
                        this.toolBtn81.Checked = false;
                    }
                }
                this.FillDgvCharacterDamage();
                this.LoadDamageLocation();
                this.CheckForDefects();
                this.CreateToolTipTitleBtnRarentDocument();
                base.SelectSqlData(this.dataSetDamage.tJ_DamageLV, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
                if (this.dataSetDamage.tJ_DamageLV.Rows.Count == 0)
                {
                    this.CreateDocumentCharacteristics();
                }
                this.LoadTableTransOff();
                //ReferenceTables.CreateReferenceTables.LoadTableDamageAbnFull2(this.dataSetDamage.tJ_Damage, this.tableSchmAbnFull, this.SqlSettings);
                this.LoadTableAbnOff();
                this.LoadTotalCountPoint();
                this.LoadTotalCountAbnObj();
                //this.labelCountAbn.Text = "Количество абонентов: " + this.tableSchmAbnFull.DefaultView.ToTable(true, new string[]
                //{
                //"idAbn"
                //}).Rows.Count.ToString();
                this.labelCountAbn.Text = "Количество абонентов: " + tableSchmAbnFull.AsEnumerable().GroupBy(r => (int)r["idAbn"]).Count().ToString();
            }
            this.LoadDocumenSL();
            this.FillOwnerDocument();
            this.ControlBloking();
            this.isChangedData = false;
            //*****************
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
            {
                isSendSiteMe = this.dataSetDamage.tJ_Damage.Rows[0]["isSendSiteMe"];
                if (DBNull.Value.GetType() == isSendSiteMe.GetType())
                    isSendSiteMe = 0;
                else
                    isSendSiteMe = Convert.ToInt32(isSendSiteMe);
                if (IdDocument == -1)
                    chkSendSiteME.CheckState = CheckState.Checked;
                else if ((int)isSendSiteMe == 3 || (int)isSendSiteMe == 6 || (int)isSendSiteMe == 11 || (int)isSendSiteMe == 12 || (int)isSendSiteMe == 13)
                {
                    chkSendSiteME.CheckState = CheckState.Checked;
                    chkSendSiteME.Enabled = false;
                }
                else if ((int)isSendSiteMe == 21)
                {
                    chkSendSiteME.Checked = true;
                    chkSendSiteME_CheckedChanged(chkSendSiteME, null);
                }
                else
                {
                    chkSendSiteME.Checked = false;
                    chkSendSiteME_CheckedChanged(chkSendSiteME, null);
                }
            }
        }

        private void chkSendSiteME_CheckedChanged(object sender, EventArgs e)
        {
            if (IdDocument == -1)
            {
                isSendSiteMe = this.chkSendSiteME.Checked ? 1 : 2;
            }
            else
            {
                if ((int)isSendSiteMe == 1)
                    isSendSiteMe = this.chkSendSiteME.Checked ? 1 : 2;
                else if ((int)isSendSiteMe == 21)
                    isSendSiteMe = this.chkSendSiteME.Checked ? 1 : (int)isSendSiteMe;
                else if ((int)isSendSiteMe == 3 || (int)isSendSiteMe == 6 || (int)isSendSiteMe == 5 || (int)isSendSiteMe == 4 || (int)isSendSiteMe == 11 || (int)isSendSiteMe == 12 || (int)isSendSiteMe == 13)
                { }
                else
                    isSendSiteMe = this.chkSendSiteME.Checked ? 1 : 0;
            }
            this.chkSendSiteME.Text = Reference.Tables.getTextSendSiteME(isSendSiteMe);

            this.dataSetDamage.tJ_Damage.Rows[0]["isSendSiteMe"] = isSendSiteMe;
        }
        private void FormDamageLVAddEdit_Shown(object sender, EventArgs e)
        {
            this.isChangedData = false;
        }

        private void FormDamageLVAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult != DialogResult.OK)
            {
                if (!this.isChangedData || this.GetFormViewMode() || MessageBox.Show("Сохранить внесенные изменения", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    base.DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            if (!this.CheckRequiredField() || !this.CheckNumberRequest())
            {
                base.DialogResult = DialogResult.None;
                e.Cancel = true;
                return;
            }

            this.AddingAndCheckFillingTemperature();

            if (this.SaveDocument())
            {
                base.SaveFormConfig(null);

                CreateActDetection act = new CreateActDetection
                {
                    Owner = this
                };
                if (!act.CreateDocument())
                {
                    base.DialogResult = DialogResult.None;
                    e.Cancel = true;
                    return;
                }

                base.DialogResult = DialogResult.OK;
#if DEBUG
                //ControlServices controlServices = new ControlServices();
                ////ServiceStatus status  = controlServices.Status();
                //controlServices.Stop();
                //StatementsForME.SendRequestToME sendMe = new StatementsForME.SendRequestToME();
                //sendMe.Send(IdDocument, SqlSettings);
                //controlServices.Start();
#endif

                return;
            }
            base.DialogResult = DialogResult.None;
            e.Cancel = true;
        }

        /// <summary>
        /// проверка наличия дефектов
        /// </summary>
        private void CheckForDefects()
        {
            if (this.IdDocument > 0)
            {
                dsDamage.tJ_DamageDataTable table = new dsDamage.tJ_DamageDataTable();
                base.SelectSqlData(table, true, string.Format("where idParent = {0} and TypeDoc = {1} and idDivisionApply is not null and isApply = 1 ", this.IdDocument, (int)eTypeDocuments.DefectLV), null, false, 0);
                if (table.Rows.Count > 0)
                {
                    this.chbDefect.Enabled = false;
                    this.cmbDivisionApply.ReadOnly = true;
                    this.txtDivisionInstruction.ReadOnly = true;
                }
                base.SelectSqlData(table, true, string.Format("where idParent = {0} and TypeDoc = {1} and isLaboratory is not null and isApply = 1 ", this.IdDocument, (int)eTypeDocuments.DefectLV), null, false, 0);
                if (table.Rows.Count > 0)
                {
                    this.chbDefect.Enabled = false;
                    this.checkBoxLaboratory.Enabled = false;
                    this.txtLaboratoryInstruction.ReadOnly = true;
                }
            }
        }
        /// <summary>
        /// прогрузка таблиц документа для уличного освещеения
        /// </summary>
        private void LoadDocumenSL()
        {
            if (this.TypeDocument == (eTypeDocuments.DamageSL))
            {
                this.txtNumRequest.Enabled = false;
                if (this.GetIdDocument() == -1)
                {
                    int parentKey = 2146;
                    this.dgvCharacterDamage.Rows.Clear();
                    this.dgvCharacterDamage.Rows.Add();
                    this.dgvCharacterDamage.CurrentCell = this.dgvCharacterDamage.Rows[0].Cells[this.ColumnTypeObj.Name];
                    this.dgvCharacterDamage.Rows[0].Cells[this.ColumnTypeObj.Name].Value = 2146;
                    DataTable dataTable = Reference.Tables.TableClassifier();
                    if (this.tableDamageCharacter != null)
                    {
                        DataRow[] array = this.tableDamageCharacter.Select("id = " + parentKey.ToString());
                        if (array.Length != 0 && array[0]["col2"] != DBNull.Value)
                        {
                            base.SelectSqlData(dataTable, true, string.Format(" where (parentId = {0} and isGroup = 1 and Deleted = 0) or (id = {1}) order by parentKey", parentKey, array[0]["col2"]), null, false, 0);
                        }
                        else
                        {
                            base.SelectSqlData(dataTable, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", parentKey), null, false, 0);
                        }
                    }
                    else
                    {
                        base.SelectSqlData(dataTable, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", parentKey), null, false, 0);
                    }
                    DataGridViewComboBoxCell dataGridViewComboBoxCell = this.dgvCharacterDamage[1, 0] as DataGridViewComboBoxCell;
                    dataGridViewComboBoxCell.DataSource = dataTable;
                    dataGridViewComboBoxCell.DisplayMember = "name";
                    dataGridViewComboBoxCell.ValueMember = "id";
                }
            }
        }
        /// <summary>
        /// прогрузка таблиц документа (основной и подчиненный с характерами повреждений)
        /// </summary>
        private void LoadDocumentDamage()
        {
            if (this.IdDocument > 0)
            {
                this.tableDamage = new DailyReportN.DataSet.dsDamage.tJ_DamageDataTable();
                base.SelectSqlData(this.tableDamage, true, "where id = " + this.IdDocument.ToString(), null, false, 0);
                this.tableDamageCharacter = new DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable();// Class171.Class184();
                base.SelectSqlData(this.tableDamageCharacter, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
            }
        }
        /// <summary>
        /// Создать строку дополнительных характеристик документа
        /// </summary>
        private void CreateDocumentCharacteristics()
        {
            DataRow dataRow = this.dataSetDamage.tJ_DamageLV.NewRow();
            dataRow["idDamage"] = this.IdDocument;
            this.dataSetDamage.tJ_DamageLV.Rows.Add(dataRow);
        }

        //private DataTable method_8()
        //{
        //    return new DataTable("tR_Classifier")
        //    {
        //        Columns =
        //        {
        //            {
        //                "id",
        //                typeof(int)
        //            },
        //            {
        //                "name",
        //                typeof(string)
        //            }
        //        }
        //    };
        //}

#region заполним списки
        private void FillComboBoxDivision()
        {
            DataTable dataTable = Reference.Tables.TableClassifier();
            if (this.tableDamage != null && this.tableDamage.Rows.Count > 0 && this.tableDamage.Rows[0]["idDivision"] != DBNull.Value)
            {
                base.SelectSqlData(dataTable, true, string.Format(" where (ParentKey = ';GroupWorker;DailyREport;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0})", this.tableDamage.Rows[0]["idDivision"]), null, false, 0);
            }
            else
            {
                base.SelectSqlData(dataTable, true, " where ParentKey = ';GroupWorker;DailyREport;' and isgroup = 0 and deleted = 0", null, false, 0);
            }
            this.cmbDivision.DisplayMember = "name";
            this.cmbDivision.ValueMember = "id";
            this.cmbDivision.DataSource = dataTable;
            this.cmbDivision.SelectedIndex = -1;
        }

        private void FillComboBoxCompiler()
        {
            DataTable dataTable = new DataTable("vWorkerGroup");
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("FIO", typeof(string));
            dataTable.Columns.Add("idGroup", typeof(int));
            base.SelectSqlData(dataTable, true, "where ParentKey like ';GroupWorker;DailyReport;' and dateEnd is null order by fio ", null, false, 0);
            this.cmbCompiler.DisplayMember = "FIO";
            this.cmbCompiler.ValueMember = "id";
            this.cmbCompiler.DataSource = dataTable;
            this.cmbCompiler.SelectedIndex = -1;
        }
        /// <summary>
        /// заполнить автора документа
        /// </summary>
        private void FillOwnerDocument()
        {
            if (this.IdDocument == -1)
            {
                DataTable dataTable = new DataTable("tUser");
                dataTable.Columns.Add("name", typeof(string));
                dataTable.Columns.Add("idWorker", typeof(string));
                base.SelectSqlData(dataTable, true, "where [login] = SYSTEM_USER", null, false, 0);
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows[0]["name"] != DBNull.Value)
                    {
                        this.txtOwner.Text = dataTable.Rows[0]["name"].ToString();
                    }
                    if (dataTable.Rows[0]["idWorker"] != DBNull.Value)
                    {
                        DataRow[] array = ((DataTable)this.cmbCompiler.DataSource).Select("id = " + dataTable.Rows[0]["idWorker"]);
                        if (array.Count<DataRow>() > 0 && this.IdDocument == -1 && this.dataSetDamage.tJ_Damage.Rows.Count > 0)
                        {
                            this.dataSetDamage.tJ_Damage.Rows[0]["idCompiler"] = array[0]["id"];
                            return;
                        }
                    }
                }
            }
            else if (this.dataSetDamage.tJ_Damage.Rows.Count > 0 && this.dataSetDamage.tJ_Damage.Rows[0]["idOwner"] != DBNull.Value)
            {
                DataTable dataTable2 = new DataTable("tUser");
                dataTable2.Columns.Add("name", typeof(string));
                base.SelectSqlData(dataTable2, true, "where [idUser] = " + this.dataSetDamage.tJ_Damage.Rows[0]["idOwner"].ToString(), null, false, 0);
                if (dataTable2.Rows.Count > 0 && dataTable2.Rows[0]["name"] != DBNull.Value)
                {
                    this.txtOwner.Text = dataTable2.Rows[0]["name"].ToString();
                }
            }
        }

        private void FillComboBoxReason()
        {
            DataTable dataTable = Reference.Tables.TableClassifier();
            if (this.tableDamage != null && this.tableDamage.Rows.Count > 0 && this.tableDamage.Rows[0]["idReason"] != DBNull.Value)
            {
                base.SelectSqlData(dataTable, true, string.Format(" where (ParentKey = ';ReportDaily;DamageReason;LV;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0}) order by name", this.tableDamage.Rows[0]["idReason"]), null, false, 0);
            }
            else
            {
                base.SelectSqlData(dataTable, true, " where ParentKey = ';ReportDaily;DamageReason;LV;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
            }
            this.cmbReason.DisplayMember = "name";
            this.cmbReason.ValueMember = "id";
            this.cmbReason.DataSource = dataTable;
            this.cmbReason.SelectedIndex = -1;
        }

        private void FillComboBoxCompletedWork()
        {
            DataTable dataTable = Reference.Tables.TableClassifier();
            if (this.tableDamage != null && this.tableDamage.Rows.Count > 0 && this.tableDamage.Rows[0]["idCompletedWork"] != DBNull.Value)
            {
                base.SelectSqlData(dataTable, true, string.Format(" where (ParentKey = ';ReportDaily;CompletedWork;LV;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0}) order by name", this.tableDamage.Rows[0]["idCompletedWork"]), null, false, 0);
            }
            else
            {
                base.SelectSqlData(dataTable, true, " where ParentKey = ';ReportDaily;CompletedWork;LV;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
            }
            this.cmbCompletedWork.DisplayMember = "name";
            this.cmbCompletedWork.ValueMember = "id";
            this.cmbCompletedWork.DataSource = dataTable;
            this.cmbCompletedWork.SelectedIndex = -1;
        }

        private void FillComboBoxWorkerApply()
        {
            DataTable dataTable = new DataTable("vWorkerGroup");
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("FIO", typeof(string));
            dataTable.Columns.Add("idGroup", typeof(int));
            base.SelectSqlData(dataTable, true, " where ParentKey in (';GroupWorker;Workers;')  and dateend is null group by id, fio, idGRoup order by fio ", null, false, 0);
            this.cmbWorkerApply.DisplayMember = "FIO";
            this.cmbWorkerApply.ValueMember = "id";
            this.cmbWorkerApply.DataSource = dataTable;
            this.cmbWorkerApply.SelectedIndex = -1;
        }

        private void FillComboBoxDivisionApply()
        {
            DataTable dataTable = Reference.Tables.TableClassifier();
            base.SelectSqlData(dataTable, true, " where ParentKey = ';ReportDaily;DivisionApply;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
            this.cmbDivisionApply.DisplayMember = "name";
            this.cmbDivisionApply.ValueMember = "id";
            this.cmbDivisionApply.DataSource = dataTable;
            this.cmbDivisionApply.SelectedIndex = -1;
        }

        private void FillComboBoxWindDirect()
        {
            DataTable dataTable = new DataTable("tR_Classifier");
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("name", typeof(string));
            base.SelectSqlData(dataTable, true, "where ParentKey = ';ReportDaily;WindDirect;' and isGroup = 0 and deleted = 0 order by name", null, false, 0);
            this.cmbWindDirect.DisplayMember = "name";
            this.cmbWindDirect.ValueMember = "id";
            this.cmbWindDirect.DataSource = dataTable;
            this.cmbWindDirect.SelectedIndex = -1;
        }

        private void FillComboBoxReasonPTS()
        {
            DataTable dataTable = Reference.Tables.TableClassifier();
            dataTable.Columns.Add("value", typeof(decimal));
            dataTable.Columns.Add("nameFull", typeof(string), "name + ' (' + convert(convert(value, 'System.Single'), 'System.String') + ')'");
            base.SelectSqlData(dataTable, true, " where ParentKey like ';ReportDaily;PTS;ReasonDamage;LV;%' and isGRoup =0 and deleted = 0 order by value", null, false, 0);
            this.cmbReasonPTS.DisplayMember = "nameFull";
            this.cmbReasonPTS.ValueMember = "id";
            this.cmbReasonPTS.DataSource = dataTable;
        }

        private void FillDataSourceTypeAbn()
        {
            DataTable dataTable = Reference.Tables.TableClassifier();
            base.SelectSqlData(dataTable, true, " where  parentKey = ';SKUEE;TypeAbn;' and isGRoup = 0 and deleted  = 0", null, false, 0);
            this.typeAbnDgvColumn.DisplayMember = "name";
            this.typeAbnDgvColumn.ValueMember = "id";
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            this.typeAbnDgvColumn.DataSource = bindingSource;
        }
#endregion

        private void cmbCompiler_SelectedValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
            {
                if (this.cmbCompiler.SelectedValue == null)
                {
                    this.cmbDivision.SelectedValue = null;
                    return;
                }
                this.labelCompiler.ForeColor = Color.Black;
                DataRow[] array = ((DataTable)this.cmbCompiler.DataSource).Select("id = " + this.cmbCompiler.SelectedValue.ToString());
                if (array.Count<DataRow>() > 0)
                {
                    this.cmbDivision.SelectedValue = array[0]["idGRoup"];
                }
            }
        }

        private void txtDeclarerTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != '-' && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != ' ' && e.KeyChar != ';')
            {
                e.Handled = true;
            }
        }

        private void dtpDateDoc_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.dtpDateDoc.Value != null)
            {
                if (this.dtpDateDoc.Value != DBNull.Value)
                {
                    this.labelDateDoc.ForeColor = Color.Black;
                    this.dtpDataApply.MinDate = Convert.ToDateTime(this.dtpDateDoc.Value).Date;
                    // если заполнена дата заявки
                    // проверим заполнение отключенного объекта - txtSchmObj
                    if (!string.IsNullOrEmpty(this.txtSchmObj.Text))
                        RefreshTable();
                    return;
                }
            }
            this.dtpDataApply.MinDate = DateTimePicker.MinimumDateTime;
        }


        private void txtCompletedWork_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
        }

        private void txtNumRequest_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNumRequest.Text))
            {
                this.labelNumRequest.ForeColor = Color.Black;
            }
            this.isChangedData = true;
        }

        private void txtSchmObj_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtSchmObj.Text))
            {
                this.labelSchmObj.ForeColor = Color.Black;
            }
            this.isChangedData = true;
        }

        private void cmbReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbReason.SelectedIndex >= 0)
            {
                this.labelReason.ForeColor = Color.Black;
            }
            this.isChangedData = true;
        }

        private void btnChoiceSchmObj_Click(object sender, EventArgs e)
        {
            int? flagVisibleSubstantion = null;
            if (this.cmbStreet.SelectedIndex >= 0)
            {
                flagVisibleSubstantion = new int?(Convert.ToInt32(this.cmbStreet.SelectedValue));
            }
            //
            CreateReferenceTables.GetSelectSchmObj(this.SqlSettings, this.dataSetDamage.tJ_Damage.Rows[0], this.txtSchmObj, ref this.isChangedData, flagVisibleSubstantion);
            // this.FillTextBoxTxtV();
            this.RefreshTable();
        }

        //   /// <summary>
        //   /// Выбор объекта схемы
        //   /// </summary>
        //private void GetSelectSchmObj(object sender, FormClosedEventArgs e)
        //{
        //	FormSelectSchmObj form = (FormSelectSchmObj)sender;
        //	if (form.DialogResult == DialogResult.OK)
        //	{
        //		this.isChangedData = true;
        //		if (form.GetDictionaryKey().Count > 0)
        //		{
        //			this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"] = form.GetDictionaryKey().First<KeyValuePair<int, string>>().Key;
        //			this.txtSchmObj.Text = form.GetDictionaryKey().First<KeyValuePair<int, string>>().Value;
        //			return;
        //		}
        //		this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"] = DBNull.Value;
        //		this.txtSchmObj.Text = string.Empty;
        //	}
        //}

        private void buttonClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        /// <summary>
        /// проверка заполнения обязательных полей
        /// </summary>
        private bool CheckRequiredField()
        {
            bool flag = true;
            if (this.dtpDateDoc.Value == null || this.dtpDateDoc.Value == DBNull.Value)
            {
                this.labelDateDoc.ForeColor = Color.Red;
                flag = false;
            }
            if (this.TypeDocument == (eTypeDocuments.DamageLV) && string.IsNullOrEmpty(this.txtNumRequest.Text))
            {
                this.labelNumRequest.ForeColor = Color.Red;
                flag = false;
            }
            if (this.cmbCompiler.SelectedIndex < 0)
            {
                this.labelCompiler.ForeColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrEmpty(this.txtSchmObj.Text))
            {
                this.labelSchmObj.ForeColor = Color.Red;
                flag = false;
            }
            if (this.dtpDateDoc.Value != null && this.dtpDateDoc.Value != DBNull.Value && this.dtpDataApply.Value != null && this.dtpDataApply.Value != DBNull.Value && Convert.ToDateTime(this.dtpDataApply.Value) < Convert.ToDateTime(this.dtpDateDoc.Value))
            {
                this.labelDateAplly.ForeColor = Color.Red;
                flag = false;
            }
            if (this.cmbReason.SelectedIndex < 0)
            {
                this.labelReason.ForeColor = Color.Red;
                flag = false;
            }
            if (this.dgvCharacterDamage.Rows.Count <= 1)
            {
                this.label1ChatacterDamage.ForeColor = Color.Red;
                flag = false;
            }
            if (this.checkBoxApply.Checked)
            {
                if (this.TypeDocument == (eTypeDocuments.DamageLV) && this.cmbCompletedWork.SelectedIndex < 0)
                {
                    this.labelCompletedWork.ForeColor = Color.Red;
                    flag = false;
                }
                if (this.cmbWorkerApply.SelectedIndex < 0)
                {
                    this.checkBoxApply.ForeColor = Color.Red;
                    flag = false;
                }
                if (this.dtpDataApply.Value == null || this.dtpDataApply.Value == DBNull.Value)
                {
                    this.labelDateAplly.ForeColor = Color.Red;
                    flag = false;
                }
            }
            if (!flag)
            {
                MessageBox.Show("Не заполнены обязательный поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return flag;
        }
        /// <summary>
        /// проверка номера заявки на дублирование
        /// </summary>
        /// <returns></returns>
        private bool CheckNumberRequest()
        {
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
            {
                DataTable dataTable = new DataTable("tJ_Damage");
                dataTable.Columns.Add("id", typeof(int));
                dataTable.Columns.Add("numREquest", typeof(string));
                dataTable.Columns.Add("dateDoc", typeof(DateTime));
                base.SelectSqlData(dataTable, true, string.Format("where numRequest = '{0}' and year(dateDoc) = {1} and typeDoc = {2} and id <> {3} and idDivision = {4}", new object[]
                {
                this.dataSetDamage.tJ_Damage.Rows[0]["numRequest"].ToString(),
                Convert.ToDateTime(this.dataSetDamage.tJ_Damage.Rows[0]["dateDoc"]).Year,
                (int)this.TypeDocument,
                this.dataSetDamage.tJ_Damage.Rows[0]["id"].ToString(),
                Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idDivision"])
                }), null, false, 0);
                return dataTable.Rows.Count <= 0 || MessageBox.Show(string.Format("Заявка с номером {0} в текущем году уже была. Хотите все равно сохранить?", this.dataSetDamage.tJ_Damage.Rows[0]["numRequest"].ToString()), "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            }
            return true;
        }
        /// <summary>
        /// сохранение документа
        /// </summary>
        private bool SaveDocument()
        {
            if (!this.chbDefect.Checked)
            {
                this.cmbDivisionApply.SelectedIndex = -1;
                this.checkBoxLaboratory.Checked = false;
            }
            int? idMap = this.SaveDamageLocation();
            if (idMap == null)
            {
                this.dataSetDamage.tJ_Damage.Rows[0]["idMap"] = DBNull.Value;
            }
            else
            {
                this.dataSetDamage.tJ_Damage.Rows[0]["idMap"] = idMap;
            }
            this.dataSetDamage.tJ_Damage.Rows[0]["is81"] = !this.toolBtn81.Checked;

            this.AppendChildCommentXml();
            this.AppendChildTransOff();

            this.dataSetDamage.tJ_Damage.Rows[0].EndEdit();
            if (this.IdDocument == -1)
            {
                this.IdDocument = base.InsertSqlDataOneRow(this.dataSetDamage, this.dataSetDamage.tJ_Damage);
                if (this.IdDocument == -1)
                {
                    return false;
                }
            }
            else if (!base.UpdateSqlData(this.dataSetDamage.tJ_Damage))
            {
                return false;
            }
            base.SelectSqlData(this.dataSetDamage.tJ_Damage, true, "where id = " + this.IdDocument.ToString(), null, false, 0);
            return this.SaveTableDamageAddCharacter() && this.SaveTableDamageCharacter() && this.SaveTableDefectDamage();
        }
        /// <summary>
        /// сохраним xml-данные - CommentXml-отключенные абоненты
        /// </summary>
        private void AppendChildCommentXml()
        {
            XmlDocument xmlDocument = new XmlDocument();
            if (this.dataSetDamage.tJ_Damage.Rows[0]["CommentXml"] != DBNull.Value)
            {
                try
                {
                    xmlDocument.LoadXml(this.dataSetDamage.tJ_Damage.Rows[0]["CommentXml"].ToString());
                }
                catch
                {
                }
            }
            XmlNode xmlNodeDoc = xmlDocument.SelectSingleNode("Doc");
            if (xmlNodeDoc == null)
            {
                xmlNodeDoc = xmlDocument.CreateElement("Doc");
                xmlDocument.AppendChild(xmlNodeDoc);
            }
            XmlNode xmlNodeAbnOff = xmlNodeDoc.SelectSingleNode("AbnOff");
            if (xmlNodeAbnOff != null)
            {
                xmlNodeAbnOff.RemoveAll();
            }
            else
            {
                xmlNodeAbnOff = xmlDocument.CreateElement("AbnOff");
                xmlNodeDoc.AppendChild(xmlNodeAbnOff);
            }
            foreach (DataGridViewRow dgwRow in this.dgvAbn.Rows)
            {
                XmlNode xmlNodeRow = xmlDocument.CreateElement("Row");
                xmlNodeAbnOff.AppendChild(xmlNodeRow);
                foreach (DataGridViewColumn dataGridViewColumn in this.dgvAbn.Columns)
                {
                    XmlAttribute xmlAttribute = xmlNodeDoc.OwnerDocument.CreateAttribute(dataGridViewColumn.DataPropertyName);
                    xmlAttribute.Value = dgwRow.Cells[dataGridViewColumn.Index].Value.ToString();
                    xmlNodeRow.Attributes.Append(xmlAttribute);
                }
            }

            this.AppendChildCountPoint(xmlNodeAbnOff);
            this.AppendChildCountAbnObj(xmlNodeAbnOff);
            this.dataSetDamage.tJ_Damage.Rows[0]["CommentXml"] = xmlDocument.InnerXml;
        }
        /// <summary>
        ///  сохранение характеристик повреждений
        /// </summary>
        /// <returns></returns>
        private bool SaveTableDamageCharacter()
        {
            base.SelectSqlData(this.dataSetDamage.tJ_DamageCharacter, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
            for (int i = this.dgvCharacterDamage.Rows.Count - 1; i < this.dataSetDamage.tJ_DamageCharacter.Rows.Count; i++)
            {
                this.dataSetDamage.tJ_DamageCharacter.Rows[i].Delete();
            }
            for (int j = 0; j < this.dgvCharacterDamage.Rows.Count - 1; j++)
            {
                if (j < this.dataSetDamage.tJ_DamageCharacter.Rows.Count)
                {
                    this.dataSetDamage.tJ_DamageCharacter.Rows[j]["idDamage"] = this.IdDocument;
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.ColumnTypeObj.Name].Value != null)
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col1"] = this.dgvCharacterDamage.Rows[j].Cells[this.ColumnTypeObj.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col1"] = DBNull.Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.Column2.Name].Value != null)
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col2"] = this.dgvCharacterDamage.Rows[j].Cells[this.Column2.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col2"] = DBNull.Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.Column3.Name].Value != null)
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col3"] = this.dgvCharacterDamage.Rows[j].Cells[this.Column3.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col3"] = DBNull.Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.columnIdSchmObj.Name].Value != null)
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["idSchmObj"] = this.dgvCharacterDamage.Rows[j].Cells[this.columnIdSchmObj.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["idSchmObj"] = DBNull.Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.ColumnCabSection.Name].Value != null)
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["idLineSection"] = this.dgvCharacterDamage.Rows[j].Cells[this.ColumnCabSection.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["idLineSection"] = DBNull.Value;
                    }
                    this.dataSetDamage.tJ_DamageCharacter.Rows[j].EndEdit();
                }
                else
                {
                    DataRow dataRow = this.dataSetDamage.tJ_DamageCharacter.NewRow();
                    dataRow["idDamage"] = this.IdDocument;
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.ColumnTypeObj.Name].Value != null)
                    {
                        dataRow["col1"] = this.dgvCharacterDamage.Rows[j].Cells[this.ColumnTypeObj.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.Column2.Name].Value != null)
                    {
                        dataRow["col2"] = this.dgvCharacterDamage.Rows[j].Cells[this.Column2.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.Column3.Name].Value != null)
                    {
                        dataRow["col3"] = this.dgvCharacterDamage.Rows[j].Cells[this.Column3.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.columnIdSchmObj.Name].Value != null)
                    {
                        dataRow["idSchmObj"] = this.dgvCharacterDamage.Rows[j].Cells[this.columnIdSchmObj.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.ColumnCabSection.Name].Value != null)
                    {
                        dataRow["idLineSection"] = this.dgvCharacterDamage.Rows[j].Cells[this.ColumnCabSection.Name].Value;
                    }
                    this.dataSetDamage.tJ_DamageCharacter.Rows.Add(dataRow);
                }
            }
            if (!base.DeleteSqlData(this.dataSetDamage.tJ_DamageCharacter))
            {
                return false;
            }
            if (!base.UpdateSqlData(this.dataSetDamage.tJ_DamageCharacter))
            {
                return false;
            }
            if (!base.InsertSqlData(this.dataSetDamage.tJ_DamageCharacter))
            {
                return false;
            }
            base.SelectSqlData(this.dataSetDamage.tJ_DamageCharacter, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
            return true;
        }
        /// <summary>
        /// сохранение дополнительных характеристик
        /// </summary>
        /// <returns></returns>
        private bool SaveTableDamageAddCharacter()
        {
            if (this.dataSetDamage.tJ_DamageLV.Rows.Count > 0)
            {
                this.dataSetDamage.tJ_DamageLV.Rows[0]["idDamage"] = this.IdDocument;
                this.dataSetDamage.tJ_DamageLV.Rows[0].EndEdit();
                if (!base.InsertSqlData(this.dataSetDamage.tJ_DamageLV))
                {
                    return false;
                }
                if (!UpdateSqlDataOnlyChange(this.dataSetDamage.tJ_DamageLV))
                {
                    return false;
                }
                base.SelectSqlData(this.dataSetDamage.tJ_DamageLV, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
            }
            return true;
        }

        /// <summary>
        /// сохранение документа дефекта
        /// </summary>
        private bool SaveTableDefectDamage()
        {
            dsDamage.tJ_DamageDataTable table = new dsDamage.tJ_DamageDataTable();
            base.SelectSqlData(table, true, string.Format("where idParent = {0} and TypeDoc = {1} and idDivisionApply is not null", this.IdDocument, (int)eTypeDocuments.DefectLV), null, false, 0);
            if (this.cmbDivisionApply.SelectedIndex >= 0)
            {
                for (int i = 1; i < table.Rows.Count; i++)
                {
                    table.Rows[i].Delete();
                }
                int idDocument;
                if (table.Rows.Count > 0)
                {
                    CreateReferenceTables.SetTableDamage(table.Rows[0], this.dataSetDamage, this.IdDocument, (int)eTypeDocuments.DefectLV, true, false);
                    table.Rows[0].EndEdit();
                    if (!base.UpdateSqlData(table))
                    {
                        return false;
                    }
                    if (!this.InsertUpdateTableDamageCharacter(Convert.ToInt32(table.Rows[0]["id"])))
                    {
                        return false;
                    }
                    idDocument = Convert.ToInt32(table.Rows[0]["id"]);
                }
                else
                {
                    DataRow dataRow = table.NewRow();
                    CreateReferenceTables.SetTableDamage(dataRow, this.dataSetDamage, this.IdDocument, (int)eTypeDocuments.DefectLV, true, false);
                    table.Rows.Add(dataRow);
                    idDocument = base.InsertSqlDataOneRow(dataRow);
                    if (idDocument <= 0)
                    {
                        return false;
                    }
                    if (!this.InsertUpdateTableDamageCharacter(idDocument))
                    {
                        return false;
                    }
                }
                _MailRequest.SendRequest(idDocument, this.SqlSettings);
            }
            else
            {
                foreach (DataRow row in table.Rows)
                {
                    row.Delete();
                }
                if (!base.DeleteSqlData(table))
                {
                    return false;
                }
            }
            // дефект для лаборатории
            base.SelectSqlData(table, true, string.Format("where idParent = {0} and TypeDoc = {1} and isLaboratory is not null", this.IdDocument, (int)eTypeDocuments.DefectLV), null, false, 0);
            if (this.checkBoxLaboratory.Checked)
            {
                for (int j = 1; j < table.Rows.Count; j++)
                {
                    table.Rows[j].Delete();
                }
                int num2;
                if (table.Rows.Count > 0)
                {
                    CreateReferenceTables.SetTableDamage(table.Rows[0], this.dataSetDamage, this.IdDocument, (int)eTypeDocuments.DefectLV, false, true);
                    table.Rows[0].EndEdit();
                    if (!base.UpdateSqlData(table))
                    {
                        return false;
                    }
                    if (!this.InsertUpdateTableDamageCharacter(Convert.ToInt32(table.Rows[0]["id"])))
                    {
                        return false;
                    }
                    num2 = Convert.ToInt32(table.Rows[0]["id"]);
                }
                else
                {
                    DataRow dataRow2 = table.NewRow();
                    CreateReferenceTables.SetTableDamage(dataRow2, this.dataSetDamage, this.IdDocument, (int)eTypeDocuments.DefectLV, false, true);
                    table.Rows.Add(dataRow2);
                    num2 = base.InsertSqlDataOneRow(dataRow2);
                    if (num2 <= 0)
                    {
                        return false;
                    }
                    if (!this.InsertUpdateTableDamageCharacter(num2))
                    {
                        return false;
                    }
                }
                _MailRequest.SendRequest(num2, this.SqlSettings);
            }
            else
            {
                foreach (DataRow row in table.Rows)
                {
                    row.Delete();
                }
                if (!base.DeleteSqlData(table))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// обновление таблицы характеристик повреждений
        /// </summary>
        private bool InsertUpdateTableDamageCharacter(int idDamage)
        {

            dsDamage.tJ_DamageCharacterDataTable table = new dsDamage.tJ_DamageCharacterDataTable();
            base.SelectSqlData(table, true, "where idDamage = " + idDamage.ToString(), null, false, 0);
            for (int i = this.dataSetDamage.tJ_DamageCharacter.Rows.Count; i < table.Rows.Count; i++)
            {
                table.Rows[i].Delete();
            }
            for (int j = 0; j < this.dataSetDamage.tJ_DamageCharacter.Rows.Count; j++)
            {
                if (j < table.Rows.Count)
                {
                    table.Rows[j]["idDamage"] = idDamage;
                    table.Rows[j]["col1"] = this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col1"];
                    table.Rows[j]["col2"] = this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col2"];
                    table.Rows[j]["col3"] = this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col3"];
                    table.Rows[j].EndEdit();
                }
                else
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["idDamage"] = idDamage;
                    dataRow["col1"] = this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col1"];
                    dataRow["col2"] = this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col2"];
                    dataRow["col3"] = this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col3"];
                    table.Rows.Add(dataRow);
                }
            }
            return base.DeleteSqlData(table) && base.UpdateSqlData(table) && base.InsertSqlData(table);
        }
        /// <summary>
        /// Сохранение локации повреждения в таблице tMapObj и возврат идентификатора карты
        /// </summary>
        /// <returns></returns>
        private int? SaveDamageLocation()
        {
            if (this.cmbStreet.SelectedValue == null || this.cmbStreet.SelectedValue == DBNull.Value || string.IsNullOrEmpty(this.txtHouse.Text))
            {
                return null;
            }
            string text = string.IsNullOrEmpty(this.txtHousePrefix.Text) ? " and HousePrefix is null " : (" and HousePrefix = '" + this.txtHousePrefix.Text + "'");
            base.SelectSqlData(this.dataSetDamage.tMapObj, true, string.Concat(new string[]
            {
            "where Street = ",
            this.cmbStreet.SelectedValue.ToString(),
            " and House = ",
            this.txtHouse.Text,
            text,
            " and IsHouse = 1 and Name is null"
            }), null, false, 0);
            if (this.dataSetDamage.tMapObj.Rows.Count > 0)
            {
                return new int?(Convert.ToInt32(this.dataSetDamage.tMapObj.Rows[0]["idMap"]));
            }
            DataRow dataRow = this.dataSetDamage.tMapObj.NewRow();
            dataRow["Street"] = this.cmbStreet.SelectedValue;
            dataRow["House"] = this.txtHouse.Text;
            if (!string.IsNullOrEmpty(this.txtHousePrefix.Text))
            {
                dataRow["HousePrefix"] = this.txtHousePrefix.Text;
            }
            dataRow["IsHouse"] = true;
            dataRow["Deleted"] = 0;
            this.dataSetDamage.tMapObj.Rows.Add(dataRow);
            this.dataSetDamage.tMapObj.Rows[0].EndEdit();
            int idMap = base.InsertSqlDataOneRow(this.dataSetDamage, this.dataSetDamage.tMapObj);
            if (idMap == -1)
            {
                return null;
            }
            return new int?(idMap);
        }

        private void FillComboBoxObl()
        {
            DataTable dataTable = CreateReferenceTables.CreateTableKladObj();
            base.SelectSqlData(dataTable, true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr", null, false, 0);
            this.cmbObl.DisplayMember = "fullname";
            this.cmbObl.ValueMember = "id";
            this.cmbObl.DataSource = dataTable;
        }

        private void cmbObl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbObl.SelectedIndex < 0)
            {
                this.cmbRaionObl.DataSource = null;
                return;
            }
            this.labelObl.ForeColor = Color.Black;
            DataTable dataTable = CreateReferenceTables.CreateTableKladObj();
            base.SelectSqlData(dataTable, true, " where ParentId = " + this.cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
            this.cmbRaionObl.DisplayMember = "fullname";
            this.cmbRaionObl.ValueMember = "id";
            this.cmbRaionObl.DataSource = dataTable;
            this.cmbRaionObl.SelectedIndex = -1;
        }

        private void cmbRaionObl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbRaionObl.SelectedIndex < 0)
            {
                this.cmbCity.DataSource = null;
                this.cmbStreet.DataSource = null;
                return;
            }
            this.labelRaionObl.ForeColor = Color.Black;
            DataTable dataTable = CreateReferenceTables.CreateTableKladObj();
            base.SelectSqlData(dataTable, true, " where ParentId = " + this.cmbRaionObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
            this.cmbCity.DisplayMember = "fullname";
            this.cmbCity.ValueMember = "id";
            this.cmbCity.DataSource = dataTable;
            this.cmbCity.SelectedIndex = -1;
            DataTable dataTable2 = CreateReferenceTables.CreateTableKladrStreet();
            base.SelectSqlData(dataTable2, true, " where KladrObjId = " + this.cmbRaionObl.SelectedValue + " and deleted = 0 order by name, socr ", null, false, 0);
            this.cmbStreet.DisplayMember = "fullname";
            this.cmbStreet.ValueMember = "id";
            this.cmbStreet.DataSource = dataTable2;
            this.cmbStreet.SelectedIndex = -1;
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCity.SelectedIndex >= 0)
            {
                DataTable dataTable = CreateReferenceTables.CreateTableKladrStreet();
                base.SelectSqlData(dataTable, true, " where KladrObjId = " + this.cmbCity.SelectedValue + " and deleted = 0 order by name, socr ", null, false, 0);
                this.cmbStreet.DisplayMember = "fullname";
                this.cmbStreet.ValueMember = "id";
                this.cmbStreet.DataSource = dataTable;
                this.cmbStreet.SelectedIndex = -1;
            }
        }

        private void cmbStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.cmbStreet.SelectedIndex >= 0)
            {
                this.labelStreet.ForeColor = Color.Black;
            }
        }

        private void txtHouse_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (!string.IsNullOrEmpty(this.txtHouse.Text))
            {
                this.labelHouse.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// загрузка локации аварии (адреса)
        /// </summary>
        private void LoadDamageLocation()
        {
            if (this.dataSetDamage.tJ_Damage.Rows[0]["idmap"] == DBNull.Value && this.dataSetDamage.tJ_Damage.Rows[0]["idStreet"] == DBNull.Value)
            {
                return;
            }
            if (this.dataSetDamage.tJ_Damage.Rows[0]["idmap"] != DBNull.Value)
            {
                base.SelectSqlData(this.dataSetDamage.tMapObj, true, " where idMap = " + this.dataSetDamage.tJ_Damage.Rows[0]["idmap"].ToString(), null, false, 0);
                this.txtHouse.Text = this.dataSetDamage.tMapObj.Rows[0]["House"].ToString();
                this.txtHousePrefix.Text = this.dataSetDamage.tMapObj.Rows[0]["HousePrefix"].ToString();
            }
            DataTable dtStreet = CreateReferenceTables.CreateTableKladrStreet();
            if (this.dataSetDamage.tMapObj.Rows.Count > 0)
            {
                base.SelectSqlData(dtStreet, true, " where id = " + this.dataSetDamage.tMapObj.Rows[0]["Street"].ToString(), null, false, 0);
            }
            else if (this.dataSetDamage.tJ_Damage.Rows[0]["idStreet"] != DBNull.Value)
            {
                base.SelectSqlData(dtStreet, true, " where id = " + this.dataSetDamage.tJ_Damage.Rows[0]["idStreet"].ToString(), null, false, 0);
            }
            int KladrObjId_ = 24; // Ульяновск
            if (dtStreet.Rows.Count > 0)
            {
                KladrObjId_ = Convert.ToInt32(dtStreet.Rows[0]["KladrObjId"]);
            }
            // структура адреса
            List<DataRow> treeAddress = new List<DataRow>();
            this.FillTreeAddress(KladrObjId_, treeAddress);
            this.LoadDamageBeginAddress(treeAddress);
            if (this.dataSetDamage.tMapObj.Rows.Count > 0 && this.dataSetDamage.tMapObj.Rows[0]["Street"] != DBNull.Value)
            {
                this.cmbStreet.SelectedValue = this.dataSetDamage.tMapObj.Rows[0]["Street"];
                return;
            }
            if (this.dataSetDamage.tJ_Damage.Rows[0]["idStreet"] != DBNull.Value)
            {
                this.cmbStreet.SelectedValue = this.dataSetDamage.tJ_Damage.Rows[0]["idStreet"];
            }
        }
        /// <summary>
        ///  собираем структуру (дерево) адреса
        ///  по правилу "девяти запятых"
        /// </summary>
        /// <param name="KladrObjId"></param>
        /// <param name="treeAddress"> структура адреса </param>
        private void FillTreeAddress(int KladrObjId, List<DataRow> treeAddress)
        {
            DataTable dataTable = CreateReferenceTables.CreateTableKladObj();
            base.SelectSqlData(dataTable, true, " where id = " + KladrObjId.ToString(), null, false, 0);
            if (dataTable.Rows.Count != 0 && (dataTable.Rows[0]["PrimaryKey"] == DBNull.Value || !(dataTable.Rows[0]["PrimaryKey"].ToString() == "Country")))
            {
                if (dataTable.Rows[0]["ParentId"] != DBNull.Value)
                {
                    treeAddress.Add(dataTable.Rows[0]);
                    this.FillTreeAddress(Convert.ToInt32(dataTable.Rows[0]["ParentId"]), treeAddress);
                    return;
                }
            }
        }
        /// <summary>
        /// грузим область, район/город, нас. пункт
        /// собираем начало(голову) адресса
        /// </summary>
        private void LoadDamageBeginAddress(List<DataRow> treeAddress)
        {
            DataTable dataTable = CreateReferenceTables.CreateTableKladObj();
            switch (treeAddress.Count)
            {
                case 0:
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.DisplayMember = "namefull";
                    this.cmbObl.ValueMember = "id";
                    this.cmbObl.DataSource = dataTable;
                    base.SelectSqlData(dataTable, true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr", null, false, 0);
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.SelectedIndex = 0;
                    return;
                case 1:
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.DisplayMember = "namefull";
                    this.cmbObl.ValueMember = "id";
                    this.cmbObl.DataSource = dataTable;
                    base.SelectSqlData(dataTable, true, " where ParentId = " + treeAddress[0]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.SelectedValue = Convert.ToInt32(treeAddress[0]["Id"]);
                    return;
                case 2:
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.DisplayMember = "namefull";
                    this.cmbObl.ValueMember = "id";
                    this.cmbObl.DataSource = dataTable;
                    base.SelectSqlData(dataTable, true, " where ParentId = " + treeAddress[1]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.SelectedValue = Convert.ToInt32(treeAddress[1]["Id"]);
                    this.cmbRaionObl.SelectedValue = Convert.ToInt32(treeAddress[0]["Id"]);
                    return;
            }
            this.cmbObl.SelectedIndex = -1;
            this.cmbObl.DisplayMember = "namefull";
            this.cmbObl.ValueMember = "id";
            this.cmbObl.DataSource = dataTable;
            base.SelectSqlData(dataTable, true, " where ParentId = " + treeAddress[2]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
            this.cmbObl.SelectedIndex = -1;
            this.cmbObl.SelectedValue = Convert.ToInt32(treeAddress[2]["Id"]);
            this.cmbRaionObl.SelectedValue = Convert.ToInt32(treeAddress[1]["Id"]);
            this.cmbCity.SelectedValue = Convert.ToInt32(treeAddress[0]["Id"]);
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDocument.AppendChild(newChild);
            XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
            xmlDocument.AppendChild(xmlNode);
            if (this.cmbObl.SelectedValue != null)
            {
                XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("idObl");
                xmlAttribute.Value = this.cmbObl.SelectedValue.ToString();
                xmlNode.Attributes.Append(xmlAttribute);
            }
            if (this.cmbRaionObl.SelectedValue != null)
            {
                XmlAttribute xmlAttribute2 = xmlDocument.CreateAttribute("idRaionObl");
                xmlAttribute2.Value = this.cmbRaionObl.SelectedValue.ToString();
                xmlNode.Attributes.Append(xmlAttribute2);
            }
            return xmlDocument;
        }

        protected override void ApplyConfig(XmlDocument xml)
        {
            XmlNode xmlNode = xml.SelectSingleNode(base.Name);
            if (xmlNode != null)
            {
                XmlAttribute xmlAttribute = xmlNode.Attributes["idObl"];
                if (xmlAttribute != null)
                {
                    this.cmbObl.SelectedValue = Convert.ToInt32(xmlAttribute.Value);
                }
                xmlAttribute = xmlNode.Attributes["idRaionObl"];
                if (xmlAttribute != null)
                {
                    this.cmbRaionObl.SelectedValue = Convert.ToInt32(xmlAttribute.Value);
                }
            }
        }
        /// <summary>
        /// Загрузка таблицы характеристик повреждений
        /// </summary>
        private void FillDgvCharacterDamage()
        {
            this.dgvCharacterDamage.Rows.Clear();
            base.SelectSqlData(this.dataSetDamage.tJ_DamageCharacter, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
            int num = 0;
            foreach (DataRow dataRow in this.dataSetDamage.tJ_DamageCharacter)
            {
                this.dgvCharacterDamage.Rows.Add();
                if (dataRow["col1"] != DBNull.Value)
                {
                    this.dgvCharacterDamage.CurrentCell = this.dgvCharacterDamage.Rows[num].Cells[this.ColumnTypeObj.Name];
                    this.dgvCharacterDamage.Rows[num].Cells[this.ColumnTypeObj.Name].Value = dataRow["col1"];
                    DataTable dataTableClf = Reference.Tables.TableClassifier();
                    if (this.tableDamageCharacter != null)
                    {
                        DataRow[] array = this.tableDamageCharacter.Select("id = " + dataRow["id"].ToString());
                        if (array.Length != 0 && array[0]["col2"] != DBNull.Value)
                        {
                            base.SelectSqlData(dataTableClf, true, string.Format(" where (parentId = {0} and isGroup = 1 and Deleted = 0) or (id = {1}) order by parentKey", dataRow["col1"], array[0]["col2"]), null, false, 0);
                        }
                        else
                        {
                            base.SelectSqlData(dataTableClf, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", dataRow["col1"]), null, false, 0);
                        }
                    }
                    else
                    {
                        base.SelectSqlData(dataTableClf, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", dataRow["col1"]), null, false, 0);
                    }
                    //DataGridViewComboBoxCell dataGridViewComboBoxCell = this.dgvCharacterDamage[1, num] as DataGridViewComboBoxCell;
                    DataGridViewComboBoxCell dataGridViewComboBoxCell = this.dgvCharacterDamage[this.Column2.Index, num] as DataGridViewComboBoxCell;
                    dataGridViewComboBoxCell.DataSource = dataTableClf;
                    dataGridViewComboBoxCell.DisplayMember = "name";
                    dataGridViewComboBoxCell.ValueMember = "id";
                }
                if (dataRow["col2"] != DBNull.Value)
                {
                    this.dgvCharacterDamage.CurrentCell = this.dgvCharacterDamage.Rows[num].Cells[this.ColumnTypeObj.Name];
                    this.dgvCharacterDamage.Rows[num].Cells[this.Column2.Name].Value = dataRow["col2"];
                    DataTable dataTable2 = Reference.Tables.TableClassifier();
                    if (this.tableDamageCharacter != null)
                    {
                        DataRow[] array2 = this.tableDamageCharacter.Select("id = " + dataRow["id"].ToString());
                        if (array2.Length != 0 && array2[0]["col3"] != DBNull.Value)
                        {
                            base.SelectSqlData(dataTable2, true, string.Format(" where (parentId = {0} and isGroup = 1 and Deleted = 0) or (id = {1}) order by parentKey", dataRow["col2"], array2[0]["col3"]), null, false, 0);
                        }
                        else
                        {
                            base.SelectSqlData(dataTable2, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", dataRow["col2"]), null, false, 0);
                        }
                    }
                    else
                    {
                        base.SelectSqlData(dataTable2, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", dataRow["col2"]), null, false, 0);
                    }
                    //DataGridViewComboBoxCell dataGridViewComboBoxCell2 = this.dgvCharacterDamage[2, num] as DataGridViewComboBoxCell;
                    DataGridViewComboBoxCell dataGridViewComboBoxCell2 = this.dgvCharacterDamage[this.Column3.Index, num] as DataGridViewComboBoxCell;
                    dataGridViewComboBoxCell2.DataSource = dataTable2;
                    dataGridViewComboBoxCell2.DisplayMember = "name";
                    dataGridViewComboBoxCell2.ValueMember = "id";
                }
                if (dataRow["col3"] != DBNull.Value)
                {
                    this.dgvCharacterDamage.Rows[num].Cells[this.Column3.Name].Value = dataRow["col3"];
                }
                if (dataRow["idSchmObj"] != DBNull.Value)
                {
                    this.dgvCharacterDamage[this.columnIdSchmObj.Index, num].Value = dataRow["idSchmObj"];
                    object obj = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                    {
                    dataRow["idSchmObj"].ToString()
                    });
                    if (obj != null && obj != DBNull.Value)
                    {
                        this.dgvCharacterDamage[this.ColumnSchmObj.Index, num].Value = obj.ToString();
                    }
                    DataGridViewComboBoxCell dataGridViewComboBoxCell3 = this.dgvCharacterDamage[this.ColumnCabSection.Index, num] as DataGridViewComboBoxCell;
                    DataTable dataTable3 = new DataTable("tP_CabSection");
                    dataTable3.Columns.Add("id", typeof(int));
                    dataTable3.Columns.Add("number", typeof(int));
                    base.SelectSqlData(dataTable3, true, "where idObjList = " + dataRow["idSchmObj"].ToString() + " order by number", null, false, 0);
                    dataGridViewComboBoxCell3.DataSource = dataTable3;
                    dataGridViewComboBoxCell3.ValueMember = "id";
                    dataGridViewComboBoxCell3.DisplayMember = "number";
                    dataGridViewComboBoxCell3.ReadOnly = false;
                    if (dataRow["idLineSection"] != DBNull.Value)
                    {
                        dataGridViewComboBoxCell3.Value = dataRow["idLineSection"];
                    }
                    else
                    {
                        dataGridViewComboBoxCell3.Value = null;
                    }
                }
                num++;
            }
        }
        /// <summary>
        ///  привязка колонки ColumnTypeObj характера повреждения к данным
        ///  FillDataSourceColumnTypeObj
        /// </summary>
        private void FillDataSourceColumnTypeObj()
        {
            DataTable dataTable = Reference.Tables.TableClassifier();
            string text = "";
            if (this.tableDamageCharacter != null && this.tableDamageCharacter.Rows.Count > 0)
            {
                foreach (object obj in this.tableDamageCharacter.Rows)
                {
                    DataRow dataRow = (DataRow)obj;
                    if (string.IsNullOrEmpty(text))
                    {
                        text = dataRow["col1"].ToString();
                    }
                    else
                    {
                        text = text + "," + dataRow["col1"].ToString();
                    }
                }
            }
            if (string.IsNullOrEmpty(text))
            {
                base.SelectSqlData(dataTable, true, "where ParentId in (select id from \r\n                                        tr_classifier where ParentKey = ';ReportDaily;NatureDamage;LV;') \r\n                                        and isGroup = 1 and deleted = 0 order by ParentKey", null, false, 0);
            }
            else
            {
                base.SelectSqlData(dataTable, true, string.Format("where (ParentId in (select id from \r\n                                        tr_classifier where ParentKey = ';ReportDaily;NatureDamage;LV;') \r\n                                        and isGroup = 1 and deleted = 0) or \r\n                                        (id in ({0})) order by ParentKey", text), null, false, 0);
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            bindingSource.Position = -1;
            this.ColumnTypeObj.DisplayMember = "name";
            this.ColumnTypeObj.ValueMember = "id";
            this.ColumnTypeObj.DataSource = bindingSource;
        }

        private void dgvCharacterDamage_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (this.dgvCharacterDamage.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                e.Cancel = true;
            }
        }

        private void dgvCharacterDamage_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvCharacterDamage.IsCurrentCellDirty)
            {
                this.dgvCharacterDamage.CommitEdit(DataGridViewDataErrorContexts.Commit);
                this.isChangedData = true;
                this.label1ChatacterDamage.ForeColor = Color.Black;
                if ((this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.ColumnTypeObj.Index/*0*/ || this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.Column2.Index/*1*/) && this.dgvCharacterDamage.CurrentCell.Value != null)
                {
                    if (this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.ColumnTypeObj.Index)
                    {
                        DataGridViewComboBoxCell dataGridViewComboBoxCell = this.dgvCharacterDamage[this.ColumnCabSection.Index, this.dgvCharacterDamage.CurrentRow.Index] as DataGridViewComboBoxCell;
                        dataGridViewComboBoxCell.DataSource = null;
                        dataGridViewComboBoxCell.Value = null;
                        this.dgvCharacterDamage[this.ColumnSchmObj.Index, this.dgvCharacterDamage.CurrentRow.Index].Value = null;
                        this.dgvCharacterDamage[this.columnIdSchmObj.Index, this.dgvCharacterDamage.CurrentRow.Index].Value = null;
                    }
                    DataTable dataTable = Reference.Tables.TableClassifier();
                    base.SelectSqlData(dataTable, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", this.dgvCharacterDamage.CurrentCell.Value), null, false, 0);
                    int columnIndex = (this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.ColumnTypeObj.Index) ? this.Column2.Index : ((this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.Column2.Index) ? this.Column3.Index : -1);
                    //DataGridViewComboBoxCell dataGridViewComboBoxCell2 = this.dgvCharacterDamage[this.dgvCharacterDamage.CurrentCell.ColumnIndex + 1, this.dgvCharacterDamage.CurrentRow.Index] as DataGridViewComboBoxCell;
                    DataGridViewComboBoxCell dataGridViewComboBoxCell2 = this.dgvCharacterDamage[columnIndex, this.dgvCharacterDamage.CurrentRow.Index] as DataGridViewComboBoxCell;
                    dataGridViewComboBoxCell2.DataSource = dataTable;
                    dataGridViewComboBoxCell2.DisplayMember = "name";
                    dataGridViewComboBoxCell2.ValueMember = "id";
                    if (dataGridViewComboBoxCell2.Value != null && dataTable.Select("id = " + dataGridViewComboBoxCell2.Value.ToString()).Length == 0)
                    {
                        dataGridViewComboBoxCell2.Value = null;
                    }
                    if (dataGridViewComboBoxCell2.Value == null && dataGridViewComboBoxCell2.ColumnIndex == this.Column2.Index/*1*/)
                    {
                        //DataGridViewComboBoxCell dataGridViewComboBoxCell3 = this.dgvCharacterDamage[dataGridViewComboBoxCell2.ColumnIndex + 1, this.dgvCharacterDamage.CurrentRow.Index] as DataGridViewComboBoxCell;
                        DataGridViewComboBoxCell dataGridViewComboBoxCell3 = this.dgvCharacterDamage[this.Column3.Index, this.dgvCharacterDamage.CurrentRow.Index] as DataGridViewComboBoxCell;
                        dataGridViewComboBoxCell3.DataSource = null;
                        dataGridViewComboBoxCell3.Value = null;
                    }
                }
            }
        }
        private void dgvCharacterDamage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.ColumnBtn.Index && e.RowIndex >= 0)
            {
                if (this.dgvCharacterDamage[this.ColumnTypeObj.Index, e.RowIndex].Value == null)
                {
                    MessageBox.Show("Не выбран тип объекта");
                    return;
                }
                DataTable dataTable = Reference.Tables.TableClassifier();
                dataTable.Columns.Add("ParentKey", typeof(string));
                base.SelectSqlData(dataTable, true, " where id = " + this.dgvCharacterDamage[this.ColumnTypeObj.Index, e.RowIndex].Value.ToString(), null, false, 0);
                if (dataTable.Rows.Count == 0)
                {
                    return;
                }
                List<int> listTypeObj = new List<int>();
                string a = dataTable.Rows[0]["ParentKey"].ToString();
                switch (a)
                {
                    case ";ReportDaily;NatureDamage;LV;Code1;": // AirLine = ВЛ
                        listTypeObj.Add(547);//547
                        listTypeObj.Add(983);//983
                        listTypeObj.Add(548);//548
                        break;

                    case ";ReportDaily;NatureDamage;LV;Code4;":  // CableLine = КЛ
                        listTypeObj.Add(546);//546
                        listTypeObj.Add(548);//548
                        break;

                    case ";ReportDaily;NatureDamage;LV;Code2;": // Subs = ПС
                        listTypeObj.Add((int)SchmTypeSubstation.CP);//536
                        listTypeObj.Add((int)SchmTypeSubstation.PP);//535
                        listTypeObj.Add((int)SchmTypeSubstation.PP);//537
                        listTypeObj.Add((int)SchmTypeSubstation.SP);//1034
                        listTypeObj.Add((int)SchmTypeSubstation.TP);//538
                        listTypeObj.Add((int)SchmTypeSubstation.PPNO);//1275
                        break;
                }


                DataGridViewComboBoxCell dataGridViewComboBoxCell = this.dgvCharacterDamage[this.ColumnCabSection.Index, e.RowIndex] as DataGridViewComboBoxCell;
                if (!(dataTable.Rows[0]["ParentKey"].ToString() == ";ReportDaily;NatureDamage;LV;Code1;") && !(dataTable.Rows[0]["ParentKey"].ToString() == ";ReportDaily;NatureDamage;LV;Code4;"))
                {
                    if (dataTable.Rows[0]["ParentKey"].ToString() == ";ReportDaily;NatureDamage;LV;Code2;")
                    {
                        FormSelectSchmObj form = new FormSelectSchmObj();
                        form.SqlSettings = this.SqlSettings;
                        form.SetCheckBoxes(false);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            if (form.GetDictionaryKey().Count > 0)
                            {
                                this.dgvCharacterDamage[this.columnIdSchmObj.Name, e.RowIndex].Value = form.GetDictionaryKey().First<KeyValuePair<int, string>>().Key;
                                this.dgvCharacterDamage[this.ColumnSchmObj.Name, e.RowIndex].Value = form.GetDictionaryKey().First<KeyValuePair<int, string>>().Value;
                            }
                            else
                            {
                                this.dgvCharacterDamage[this.columnIdSchmObj.Name, e.RowIndex].Value = DBNull.Value;
                                this.dgvCharacterDamage[this.ColumnSchmObj.Name, e.RowIndex].Value = DBNull.Value;
                            }
                            this.isChangedData = true;
                        }
                        dataGridViewComboBoxCell.DataSource = null;
                        dataGridViewComboBoxCell.Value = null;
                        dataGridViewComboBoxCell.ReadOnly = true;
                        return;
                    }
                    FormSelectTrans form2 = new FormSelectTrans();
                    form2.SqlSettings = this.SqlSettings;
                    form2.SetCheckBoxes(false);
                    if (form2.ShowDialog() == DialogResult.OK)
                    {
                        if (form2.GetDictionaryKey().Count > 0)
                        {
                            this.dgvCharacterDamage[this.columnIdSchmObj.Name, e.RowIndex].Value = form2.GetDictionaryKey().First<KeyValuePair<int, string>>().Key;
                            this.dgvCharacterDamage[this.ColumnSchmObj.Name, e.RowIndex].Value = form2.GetDictionaryKey().First<KeyValuePair<int, string>>().Value;
                        }
                        else
                        {
                            this.dgvCharacterDamage[this.columnIdSchmObj.Name, e.RowIndex].Value = DBNull.Value;
                            this.dgvCharacterDamage[this.ColumnSchmObj.Name, e.RowIndex].Value = DBNull.Value;
                        }
                        this.isChangedData = true;
                    }
                    dataGridViewComboBoxCell.DataSource = null;
                    dataGridViewComboBoxCell.Value = null;
                    dataGridViewComboBoxCell.ReadOnly = true;
                }
                else
                {
                    FormSelectLine form3 = new FormSelectLine(listTypeObj);
                    form3.SetVisiblePanel(false);
                    form3.SqlSettings = this.SqlSettings;
                    if (form3.ShowDialog() == DialogResult.OK)
                    {
                        this.dgvCharacterDamage[this.ColumnSchmObj.Name, e.RowIndex].Value = form3.GetObjectLine().Name;
                        this.dgvCharacterDamage[this.columnIdSchmObj.Name, e.RowIndex].Value = form3.GetObjectLine().Id;
                        DataTable dataTable2 = new DataTable("tP_CabSection");
                        dataTable2.Columns.Add("id", typeof(int));
                        dataTable2.Columns.Add("number", typeof(int));
                        base.SelectSqlData(dataTable2, true, "where idObjList = " + form3.GetObjectLine().Id.ToString() + " order by number", null, false, 0);
                        dataGridViewComboBoxCell.DataSource = dataTable2;
                        dataGridViewComboBoxCell.ValueMember = "id";
                        dataGridViewComboBoxCell.DisplayMember = "number";
                        dataGridViewComboBoxCell.Value = null;
                        dataGridViewComboBoxCell.ReadOnly = false;
                        this.isChangedData = true;
                        return;
                    }
                }
            }
        }
        private void dgvCharacterDamage_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dgvCharacterDamage.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.RowHeader)
            {
                this.dgvCharacterDamage.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                this.dgvCharacterDamage.EndEdit();
                return;
            }
            this.dgvCharacterDamage.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        /// <summary>
        /// блокировка контролов
        /// </summary>
        private void ControlBloking()
        {
            if (!this.GetFormViewMode() && this.checkBoxApply.Checked)
            {
                this.txtNumRequest.ReadOnly = true;
                this.dtpDateDoc.Enabled = false;
                this.cmbCompiler.ReadOnly = true;
                this.cmbDivision.ReadOnly = true;

                this.txtDeclarerTel.ReadOnly = true;
                this.txtDeclarerAddress.ReadOnly = true;
                this.txtDeclarer.ReadOnly = true;
                this.btnChoiceSchmObj.Enabled = false;

                this.cmbStreet.ReadOnly = true;
                this.cmbCity.ReadOnly = true;
                this.cmbRaionObl.ReadOnly = true;
                this.cmbObl.ReadOnly = true;

                this.txtHousePrefix.ReadOnly = true;
                this.txtHouse.ReadOnly = true;
                this.txtLocation.ReadOnly = true;
                this.cmbReason.ReadOnly = true;
                this.dgvCharacterDamage.ReadOnly = true;
                this.cmbCompletedWork.ReadOnly = true;
                this.txtCompletedWork.ReadOnly = true;
                this.checkBoxApply.Enabled = false;
                this.cmbWorkerApply.ReadOnly = true;
                this.dtpDataApply.Enabled = false;

                this.toolBtnDelAbn.Enabled = false;
                this.toolBtnRefreshTrans.Enabled = false;
#if !DEBUG
                this.toolBtnRefreshAbn.Enabled = false;
#endif
                this.toolBtn81.Enabled = false;
                this.toolBtnRefreshCountAbn.Enabled = false;

                this.numCountPointSource.ReadOnly = true;
                this.numCountPointEE.ReadOnly = true;
                this.numCountPointCat3.ReadOnly = true;
                this.numCountPointCat2Full.ReadOnly = true;
                this.numCountPointCat2.ReadOnly = true;
                this.numCountPointCat1Full.ReadOnly = true;
                this.numCountPointCat1.ReadOnly = true;

                this.numCountAbnObjSource.ReadOnly = true;
                this.numCountAbnObjEE.ReadOnly = true;
                this.numCountAbnObjCat3.ReadOnly = true;
                this.numCountAbnObjCat2Full.ReadOnly = true;
                this.numCountAbnObjCat2.ReadOnly = true;
                this.numCountAbnObjCat1Full.ReadOnly = true;
                this.numCountAbnObjCat1.ReadOnly = true;

                this.numCountAbnObj670.ReadOnly = true;
                this.numCountAbnObj150670.ReadOnly = true;
                this.numCountAbnObj150.ReadOnly = true;
            }
        }

        private void cmbCompletedWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.cmbCompletedWork.SelectedIndex >= 0)
            {
                this.labelCompletedWork.ForeColor = Color.Black;
            }
        }

        private void cmbWorkerApply_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.cmbWorkerApply.SelectedIndex >= 0)
            {
                this.checkBoxApply.ForeColor = Color.Black;
            }
        }

        private void dtpDataApply_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.dtpDataApply.Value != null)
            {
                this.labelDateAplly.ForeColor = Color.Black;
            }
        }

        private void checkBoxApply_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxApply.Checked && this.cmbWorkerApply.SelectedIndex < 0)
            {
                DataTable dataTable = new DataTable("tUser");
                dataTable.Columns.Add("name", typeof(string));
                dataTable.Columns.Add("idWorker", typeof(string));
                base.SelectSqlData(dataTable, true, "where [login] = SYSTEM_USER", null, false, 0);
                if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["idWorker"] != DBNull.Value)
                {
                    DataRow[] array = ((DataTable)this.cmbWorkerApply.DataSource).Select("id = " + dataTable.Rows[0]["idWorker"]);
                    if (array.Count<DataRow>() > 0 && this.dataSetDamage.tJ_Damage.Rows.Count > 0)
                    {
                        this.cmbWorkerApply.SelectedValue = Convert.ToInt32(array[0]["id"]);
                    }
                }
            }
        }

        private void chbDefect_CheckedChanged(object sender, EventArgs e)
        {
            this.labelDivisionApply.Visible = this.chbDefect.Checked;
            this.cmbDivisionApply.Visible = this.chbDefect.Checked;
            this.checkBoxLaboratory.Visible = this.chbDefect.Checked;
            this.labelDivisionInstruction.Visible = (this.txtDivisionInstruction.Visible = (this.chbDefect.Checked && this.cmbDivisionApply.SelectedIndex >= 0));
            this.labelLaboratoryInstruction.Visible = (this.txtLaboratoryInstruction.Visible = (this.chbDefect.Checked && this.checkBoxLaboratory.Checked));
            this.isChangedData = true;
        }

        private void checkBoxLaboratory_CheckedChanged(object sender, EventArgs e)
        {
            this.labelLaboratoryInstruction.Visible = (this.txtLaboratoryInstruction.Visible = (this.chbDefect.Checked && this.checkBoxLaboratory.Checked));
            this.isChangedData = true;
        }

        private void cmbDivisionApply_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelDivisionInstruction.Visible = (this.txtDivisionInstruction.Visible = (this.chbDefect.Checked && this.cmbDivisionApply.SelectedIndex >= 0));
            this.isChangedData = true;
        }

        /// <summary>
        /// заполнить и проверить наличие температуру на день заявки
        /// </summary>
        /// <returns></returns>
        private bool AddingAndCheckFillingTemperature()
        {
            base.SelectSqlData(this.dsDamageN.tJ_Temperature, true, string.Format("where datetemp = '{0}'", Convert.ToDateTime(this.dtpDateDoc.Value).ToString("yyyyMMdd")), null, false, 0);
            if (this.dsDamageN.tJ_Temperature.Rows.Count > 0)
            {
                return true;
            }
            if (MessageBox.Show("На день заявки не введены данные о погоде. Ввести данные?", "Погода", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return false;
            }
            if (new FormTemperatureAddEdit(Convert.ToDateTime(this.dtpDateDoc.Value).Date)
            {
                SqlSettings = this.SqlSettings
            }.ShowDialog() != DialogResult.OK)
            {
                return false;
            }
            base.SelectSqlData(this.dsDamageN.tJ_Temperature, true, string.Format("where datetemp = '{0}'", Convert.ToDateTime(this.dtpDateDoc.Value).ToString("yyyyMMdd")), null, false, 0);
            if (this.dsDamageN.tJ_Temperature.Rows.Count > 0)
            {
                return true;
            }
            MessageBox.Show("Что то пошло не так.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((this.dtpDateDoc.Value == null || this.dtpDateDoc.Value == DBNull.Value) && this.tabControl1.SelectedTab == this.tabPageWeather)
            {
                this.tabControl1.SelectedTab = this.tabPageGeneral;
                this.labelDateDoc.ForeColor = Color.Red;
                MessageBox.Show("Не введена дата заявки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (this.tabControl1.SelectedTab == this.tabPageWeather)
            {
                base.SelectSqlData(this.dsDamageN.tJ_Temperature, true, string.Format("where datetemp = '{0}'", Convert.ToDateTime(this.dtpDateDoc.Value).ToString("yyyyMMdd")), null, false, 0);
            }
        }

        private void cmbReasonPTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbReasonPTS.SelectedIndex >= 0 && this.cmbReasonPTS.SelectedValue != null)
            {
                DataRow row = ((DataRowView)this.cmbReasonPTS.SelectedItem).Row;
                if (row["value"] != DBNull.Value)
                {
                    this.txtReasonPTS.Text = Convert.ToDecimal(row["value"]).ToString("0.##");
                }
                else
                {
                    this.txtReasonPTS.Text = "";
                }
            }
            else
            {
                this.txtReasonPTS.Text = "";
            }
            this.isChangedData = true;
        }

        private void cmbDivisionApply_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                this.cmbDivisionApply.SelectedIndex = -1;
                this.isChangedData = true;
            }
        }

        private void toolBtnRefreshAbn_Click(object sender, EventArgs e)
        {
            this.RefreshTable();
        }

        private void RefreshTable()
        {
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0 && this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"] != DBNull.Value)
            {

                this.progressBar.Visible = true;
                this.labelProgress.Visible = true;
                this.toolBtnRefreshTrans.Enabled = false;
#if !DEBUG
                this.toolBtnRefreshAbn.Enabled = false;
#endif
                this.toolBtnDelAbn.Enabled = false;
                this.btnChoiceSchmObj.Enabled = false;

                this.dtpDateDoc.Enabled = false;
                this.dgvTrans.Enabled = false;
                this.dgvTrans.DataSource = null;
                this.dgvTreeSub.Enabled = false;

                this.dgvAbn.Enabled = false;
                this.dgvAbn.DataSource = null;

                this.buttonSave.Enabled = false;
                this.buttonClose.Enabled = false;
                this.backgroundWorker.RunWorkerAsync(this.dtpDateDoc.Value);
            }
            else
            {
                this.tableTransOff.Clear();
                this.tableSchmAbnFull.Clear();
                this.dtSchmCable.Clear();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.dgvTreeNodesClear();
            this.tableSchmAbnFull.Clear();
            this.tableTransOff.Clear();

            if (e.Argument != null)
            {
                DateTime dateTime = Convert.ToDateTime(e.Argument);
                ElectricModel electricModel = new ElectricModel();
                electricModel.SqlSettings = this.SqlSettings;
                electricModel.LoadSchema(dateTime);

                TreeNodeObj treeNodeObj_ = electricModel.PoweringReportForDrawObject(Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"]), true);

                // таблица кабелей
                References.SchemeTables.GetTableSchmCable(dtSchmCable, SqlSettings);
                // трансформаторы - отключенные
                List<int> listTrans = new List<int>();
                this.FillTreeNodeTrans(treeNodeObj_, listTrans);
                this.FillTableTransOff(listTrans);
                // подстанции - отключенные
                // this.dgvTreeNodesClear();
                this.listElectricBus = new List<int>();
                this.FillTableSubOff(null, treeNodeObj_);
                // абоненты
                // var source = electricModel.Objects.Where(new Func<ElectricObject, bool>(this.getIdSchmObj));
                // this.tableSchmAbnFull.Clear();
                var source = electricModel.Objects.Where(r => r.Id == Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"]));
                List<ElectricObject> listElectricObj = electricModel.PoweringReportForDrawObject(source.First<ElectricObject>(), true, true);
                //
                // ReferenceTables.CreateReferenceTables.LoadTableSChmAbnFull(this.tableSchmAbnFull, this.SqlSettings, listElectricObj, dateTime);
                Reference.Tables.LoadTableSChmAbnFull_2019(this.tableSchmAbnFull, this.SqlSettings, listElectricObj, dateTime);
                //    this.labelCountAbn.Text = "Количество абонентов: " + this.tableSchmAbnFull.DefaultView.ToTable(true, new string[]
                //    {
                //"idAbn"
                //    }).Rows.Count.ToString();
                this.labelCountAbn.Text = "Количество абонентов: " + tableSchmAbnFull.AsEnumerable().GroupBy(r => (int)r["idAbn"]).Count().ToString();

            }
            else
                MessageBox.Show("Не заполнена дата заявки! Расчеты остановлены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            this.progressBar.Visible = false;
            this.labelProgress.Visible = false;
            this.toolBtnRefreshAbn.Enabled = true;
            this.toolBtnDelAbn.Enabled = true;
            this.toolBtnRefreshTrans.Enabled = true;

            this.dgvTrans.Enabled = true;
            this.dgvTrans.DataSource = this.bsTransON;
            this.dgvTreeSub.Enabled = true;

            this.dgvAbn.Enabled = true;
            this.dgvAbn.DataSource = this.bsSchmAbnFull;

            this.buttonSave.Enabled = true;
            this.buttonClose.Enabled = true;
            this.btnChoiceSchmObj.Enabled = true;
            this.dtpDateDoc.Enabled = true;

            this.FillCountTrans();

            this.CalculationCountPoints();
            this.CalculationCountConsumersAndMaximumPower();
        }

        private void toolBrnDelAbn_Click(object sender, EventArgs e)
        {
            if (this.dgvAbn.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить выбранные строки?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                foreach (object obj in this.dgvAbn.SelectedRows)
                {
                    DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;

                    DataRow row = ((DataRowView)dataGridViewRow.DataBoundItem).Row;
                    tableSchmAbnFull.Rows.Remove(row);
                }


                this.CalculationCountPoints();
                this.CalculationCountConsumersAndMaximumPower();
            }
        }
        /// <summary>
        /// создание всплывающей подсказки на кнопке родительский документ
        /// </summary>
        private void CreateToolTipTitleBtnRarentDocument()
        {
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
            {
                if (this.dataSetDamage.tJ_Damage.Rows[0]["idReqForRepair"] != DBNull.Value)
                {
                    DataTable dataTable = base.SelectSqlData("tj_requestForRepair", true, "where id = " + this.dataSetDamage.tJ_Damage.Rows[0]["idReqForRepair"].ToString());
                    if (dataTable.Rows.Count > 0)
                    {
                        this.txtDocParent.Text = "Аварийная заявка №" + dataTable.Rows[0]["num"].ToString() + " от " + Convert.ToDateTime(dataTable.Rows[0]["dateCreate"]).ToString("dd.MM.yyyy");
                        if (dataTable.Rows[0]["dateFactEnd"] != DBNull.Value)
                        {
                            this.DateFactEnd = Convert.ToDateTime(dataTable.Rows[0]["dateFactEnd"]);
                        }

                        this.captionDocParent = "";
                        if (dataTable.Rows[0]["schmObj"] != DBNull.Value)
                        {
                            this.captionDocParent = "Объект: " + dataTable.Rows[0]["schmObj"].ToString();
                        }
                        if (dataTable.Rows[0]["Purpose"] != DBNull.Value)
                        {
                            if (string.IsNullOrEmpty(this.captionDocParent))
                            {
                                this.captionDocParent = "Цель: " + dataTable.Rows[0]["Purpose"].ToString();
                            }
                            else
                            {
                                this.captionDocParent = this.captionDocParent + "\r\nЦель: " + dataTable.Rows[0]["Purpose"].ToString();
                            }
                        }
                        if (dataTable.Rows[0]["AgreeWith"] != DBNull.Value)
                        {
                            if (string.IsNullOrEmpty(this.captionDocParent))
                            {
                                this.captionDocParent = "Согласовать с: " + dataTable.Rows[0]["AgreeWith"].ToString();
                            }
                            else
                            {
                                this.captionDocParent = this.captionDocParent + "\r\nСогласовать с: " + dataTable.Rows[0]["AgreeWith"].ToString();
                            }
                        }
                        if (dataTable.Rows[0]["Comment"] != DBNull.Value)
                        {
                            if (string.IsNullOrEmpty(this.captionDocParent))
                            {
                                this.captionDocParent = "Комментарий: " + dataTable.Rows[0]["Comment"].ToString();
                            }
                            else
                            {
                                this.captionDocParent = this.captionDocParent + "\r\nКомментарий: " + dataTable.Rows[0]["Comment"].ToString();
                            }
                        }
                        this.toolTipDocParent.ToolTipTitle = this.txtDocParent.Text;
                        this.toolTipDocParent.SetToolTip(this.txtDocParent, this.captionDocParent);
                        this.toolTipDocParent.SetToolTip(this.btnRequestForRepair, "Открыть документ");
                    }
                    this.btnChoiceSchmObj.Enabled = false;
                    return;
                }
                this.btnRequestForRepair.Enabled = false;
            }
        }

        private void btnRequestForRepair_Click(object sender, EventArgs e)
        {
            if (this.dataSetDamage.tJ_Damage.Rows[0]["idReqForRepair"] != DBNull.Value)
            {
                FormJournalRequestForRepairAddEditAlarm formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEditAlarm(Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idReqForRepair"]), -1, eActionRequestRepair.Read, false);
                formJournalRequestForRepairAddEdit.GoToSchema += this.f_GoToSchema;
                formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
                formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
                formJournalRequestForRepairAddEdit.Show();
            }
        }

        private void f_GoToSchema(object sender, GoToSchemaEventArgs e)
        {
            this.OnGoToSchema(e);
        }

        private void toolBtn81_CheckedChanged(object sender, EventArgs e)
        {
            if (this.toolBtn81.Checked)
            {
                this.toolBtn81.ToolTipText = "Не использовать в бюллетене 8.1";
                this.toolBtn81.Image = global::DailyReportN.Properties.Resources.not81; ;
            }
            else
            {
                this.toolBtn81.ToolTipText = "Использовать в бюллетене 8.1";
                this.toolBtn81.Image = global::DailyReportN.Properties.Resources.in81;
            }
            this.isChangedData = true;
        }

        private void toolBtnRefreshCountAbn_Click(object sender, EventArgs e)
        {
            this.CalculationCountPoints();
            this.CalculationCountConsumersAndMaximumPower();
        }
        /// <summary>
        /// Расчет количества точек поставки по категориям потребителей
        /// </summary>
        private void CalculationCountPoints()
        {
            NumericUpDown numericUpDown = this.numCountPointCat1Full;
            NumericUpDown numericUpDown2 = this.numCountPointCat2Full;
            decimal value = 0m;
            numericUpDown2.Value = value;
            numericUpDown.Value = value;
            this.numCountPointSource.Value = 0m;
            if (this.tableSchmAbnFull.Rows.Count == 0)
            {
                NumericUpDown numericUpDown3 = this.numCountPointCat1;
                NumericUpDown numericUpDown4 = this.numCountPointCat2;
                NumericUpDown numericUpDown5 = this.numCountPointCat3;
                NumericUpDown numericUpDown6 = this.numCountPointEE;
                NumericUpDown numericUpDown7 = this.numCountPointSource;
                decimal value2 = 0m;
                numericUpDown7.Value = value2;
                numericUpDown3.Value = (numericUpDown4.Value = (numericUpDown5.Value = (numericUpDown6.Value = value2)));
                return;
            }

            this.numCountPointCat1.Value = 0;
            this.numCountPointCat2.Value = 0;
            this.numCountPointCat3.Value = 0;
            this.numCountPointEE.Value = 0;

            if (this.dtpDateDoc.Value != null)
            {
                if (this.dtpDateDoc.Value != DBNull.Value)
                {
                    // собственные точки учета
                    // нулевые тарифы отсекли уже
                    // отсекаем тип абонента сетевая организация (typeAbn)
                    // оставляем только органгизации принадлежащие ульгэсу (idAbnNet)
                    // убираем нулевые значения счетчиков (CountPoint)
                    var tableCategory = tableSchmAbnFull.AsEnumerable()
                        .Where(w => (int)w["CountPoint"] > 0 && (int)w["typeAbn"] != 231 && ((int)w["idAbnNet"] == 220859 || (int)w["idAbnNet"] == 434002))
                        .GroupBy(r => (string)r["CategoryName"])
                        .Select(g => new { idCategory = g.Key, SumPoint = g.Sum(p => (int)p["CountPoint"]), Count = g.Count() });

                    var numCountPointCat1 = tableCategory.Where(r => r.idCategory == "I" || r.idCategory == "I особая");
                    this.numCountPointCat1.Value = numCountPointCat1.Count() > 0 ? numCountPointCat1.Sum(r => r.SumPoint) : 0;

                    var numCountPointCat2 = tableCategory.Where(r => r.idCategory == "II");
                    this.numCountPointCat2.Value = numCountPointCat2.Count() > 0 ? numCountPointCat2.First().SumPoint : 0;

                    var numCountPointCat3 = tableCategory.Where(r => r.idCategory == "III");
                    this.numCountPointCat3.Value = numCountPointCat3.Count() > 0 ? numCountPointCat3.First().SumPoint : 0;

                    // сетевые точки учета
                    var tableCategoryNet = tableSchmAbnFull.AsEnumerable()
                        .Where(w => (int)w["CountPoint"] != 0 && !((int)w["typeAbn"] != 231 && ((int)w["idAbnNet"] == 220859 || (int)w["idAbnNet"] == 434002)))
                        .Sum(s => (int)s["CountPoint"]);
                    this.numCountPointEE.Value = tableCategoryNet;

                    return;
                }
            }
        }
        /// <summary>
        /// Сохранение в документе узла CountPoint (количество точек поставки)
        /// </summary>
        private void AppendChildCountPoint(XmlNode xml)
        {
            try
            {
                if (xml != null && xml.OwnerDocument != null)
                {
                    XmlDocument ownerDocument = xml.OwnerDocument;
                    XmlNode xmlNode = ownerDocument.CreateElement("CountPoint");
                    xml.AppendChild(xmlNode);
                    XmlAttribute xmlAttribute = ownerDocument.CreateAttribute("countPointCat1");
                    xmlAttribute.Value = this.numCountPointCat1.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countPointCat1Full");
                    xmlAttribute.Value = this.numCountPointCat1Full.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countPointCat2");
                    xmlAttribute.Value = this.numCountPointCat2.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countPointCat2Full");
                    xmlAttribute.Value = this.numCountPointCat2Full.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countPointCat3");
                    xmlAttribute.Value = this.numCountPointCat3.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countPointEE");
                    xmlAttribute.Value = this.numCountPointEE.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countPointSource");
                    xmlAttribute.Value = this.numCountPointSource.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    //  рассчитаем количество точек по вольтажу
                    var tableCategory = tableSchmAbnFull.AsEnumerable()
                        .Where(w => (int)w["CountPoint"] > 0 && (int)w["typeAbn"] != 231 && ((int)w["idAbnNet"] == 220859 || (int)w["idAbnNet"] == 434002))
                        .GroupBy(r => r["Voltage"].ToString())
                        .Select(g => new { idVoltage = g.Key, SumPoint = g.Sum(p => (int)p["CountPoint"]), Count = g.Count() });

                    var numCountPointVN = tableCategory.Where(r => r.idVoltage == "ВН").Sum(r => r.SumPoint);
                    var numCountPointSN1 = tableCategory.Where(r => r.idVoltage == "СН-1").Sum(r => r.SumPoint);
                    var numCountPointSN2 = tableCategory.Where(r => r.idVoltage == "СН-2").Sum(r => r.SumPoint);
                    var numCountPointNN = tableCategory.Where(r => r.idVoltage == "НН").Sum(r => r.SumPoint);

                    XmlNode xmlNodeV = ownerDocument.CreateElement("CountPointVoltage");
                    xml.AppendChild(xmlNodeV);
                    XmlAttribute xmlAttributeV = ownerDocument.CreateAttribute("CountPointVoltageVN");
                    xmlAttributeV.Value = numCountPointVN.ToString();
                    xmlNodeV.Attributes.Append(xmlAttributeV);
                    xmlAttributeV = ownerDocument.CreateAttribute("CountPointVoltageSN1");
                    xmlAttributeV.Value = numCountPointSN1.ToString();
                    xmlNodeV.Attributes.Append(xmlAttributeV);
                    xmlAttributeV = ownerDocument.CreateAttribute("CountPointVoltageSN2");
                    xmlAttributeV.Value = numCountPointSN2.ToString();
                    xmlNodeV.Attributes.Append(xmlAttributeV);
                    xmlAttributeV = ownerDocument.CreateAttribute("CountPointVoltageNN");
                    xmlAttributeV.Value = numCountPointNN.ToString();
                    xmlNodeV.Attributes.Append(xmlAttributeV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Обновление итогов количества точек поставки 
        /// </summary>
        private void LoadTotalCountPoint()
        {
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0 && this.dataSetDamage.tJ_Damage.Rows[0]["CommentXml"] != DBNull.Value)
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(this.dataSetDamage.tJ_Damage.Rows[0]["CommentXml"].ToString());
                    XmlNode xmlNode = xmlDocument.SelectSingleNode("Doc");
                    if (xmlNode != null)
                    {
                        XmlNode xmlNode2 = xmlNode.SelectSingleNode("AbnOff");
                        if (xmlNode2 != null)
                        {
                            XmlNode xmlNode3 = xmlNode2.SelectSingleNode("CountPoint");
                            if (xmlNode3 != null)
                            {
                                XmlAttribute xmlAttribute = xmlNode3.Attributes["countPointCat1"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountPointCat1.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countPointCat1Full"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountPointCat1Full.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countPointCat2"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountPointCat2.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countPointCat2Full"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountPointCat2Full.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countPointCat3"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountPointCat3.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countPointEE"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountPointEE.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countPointSource"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountPointSource.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
        }

        private void numCountPointCat2_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.labelCountPoint.Text = "Количество точек поставки: " + (this.numCountPointCat1.Value + this.numCountPointCat1Full.Value + this.numCountPointCat2.Value + this.numCountPointCat2Full.Value + this.numCountPointCat3.Value + this.numCountPointEE.Value + this.numCountPointSource.Value).ToString();
        }
        /// <summary>
        /// Расчет количества потребителей услуг
        /// </summary>
        private void CalculationCountConsumersAndMaximumPower()
        {
            NumericUpDown numericUpDown = this.numCountAbnObjCat1Full;
            NumericUpDown numericUpDown2 = this.numCountAbnObjCat2Full;
            decimal value = 0m;
            numericUpDown2.Value = value;
            numericUpDown.Value = value;
            this.numCountAbnObjSource.Value = 0m;
            if (this.tableSchmAbnFull.Rows.Count == 0)
            {
                NumericUpDown numericUpDown3 = this.numCountAbnObjCat1;
                NumericUpDown numericUpDown4 = this.numCountAbnObjCat2;
                NumericUpDown numericUpDown5 = this.numCountAbnObjCat3;
                NumericUpDown numericUpDown6 = this.numCountAbnObjEE;
                NumericUpDown numericUpDown7 = this.numCountAbnObjSource;
                decimal value2 = 0m;
                numericUpDown7.Value = value2;
                numericUpDown3.Value = (numericUpDown4.Value = (numericUpDown5.Value = (numericUpDown6.Value = value2)));
                NumericUpDown numericUpDown8 = this.numCountAbnObj150;
                NumericUpDown numericUpDown9 = this.numCountAbnObj150670;
                NumericUpDown numericUpDown10 = this.numCountAbnObj670;
                decimal value3 = 0m;
                numericUpDown10.Value = value3;
                numericUpDown8.Value = (numericUpDown9.Value = value3);
                return;
            }
            //string text = "";
            //foreach (object obj in this.tableSchmAbnFull.Rows)
            //{
            //    DataRow dataRow = (DataRow)obj;
            //    if (dataRow.RowState != DataRowState.Deleted)
            //    {
            //        if (string.IsNullOrEmpty(text))
            //        {
            //            text = dataRow["idAbnObj"].ToString();
            //        }
            //        else
            //        {
            //            text = text + "," + dataRow["idAbnObj"].ToString();
            //        }
            //    }
            //}
            //SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
            //DataTable dataTable = sqlDataCommand.SelectSqlData("select ao.id,\r\n                                        case when a.TypeAbn = 231 then -1 -- сетевая организация\r\n                                        else case when a.typeAbn = 206 and r.category is null then 493 -- если у физика нет категории - ставим ему третью\r\n                                        else case when category is null then 493 else r.category end end end as category\r\n                                     from tAbnObj ao \r\n\t                                    left join tAbn a on a.id = ao.idAbn\r\n\t                                    left join tAbnObjReg r on r.id = (select top 1 id from tAbnObjREg \r\n\t\t\t\t\t\t\t                where idAbnObj = ao.id\r\n\t\t\t\t\t\t\t                order by datechange desc)\r\n                                     where ao.id in (" + text + ")");
            //this.numCountAbnObjCat1.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category in (491,494)"));
            //this.numCountAbnObjCat2.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = 492"));
            //this.numCountAbnObjCat3.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = 493"));
            //this.numCountAbnObjEE.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = -1"));
            //dataTable = sqlDataCommand.SelectSqlData("select ao.id,\r\n                                         case when a.TypeAbn = 206 or r.PowerSEt is null then 15\r\n                                        \telse r.PowerSEt end PowerSEt\r\n                                     from tAbnObj ao \r\n\t                                    left join tAbn a on a.id = ao.idAbn\r\n\t                                    left join tAbnObjReg r on r.id = (select top 1 id from tAbnObjREg \r\n\t\t\t\t\t\t\t                where idAbnObj = ao.id\r\n\t\t\t\t\t\t\t                order by datechange desc)\r\n                                     where ao.id in (" + text + ")");
            //this.numCountAbnObj150.Value = Convert.ToInt32(dataTable.Compute("count(id)", "PowerSet <= 150"));
            //this.numCountAbnObj150670.Value = Convert.ToInt32(dataTable.Compute("count(id)", "PowerSet > 150 and PowerSet <= 670"));
            //this.numCountAbnObj670.Value = Convert.ToInt32(dataTable.Compute("count(id)", "PowerSet > 670"));
            //// Расчет количества потребителей (объектов) услуг
            var tableCategory = tableSchmAbnFull.AsEnumerable()
                .Where(w => (int)w["CountPoint"] > 0 && (int)w["typeAbn"] != 231 && ((int)w["idAbnNet"] == 220859 || (int)w["idAbnNet"] == 434002))
                .GroupBy(r => new { idCategory = (string)r["CategoryName"], idAbnObj = r["idAbnObj"] })
                .Select(g => new { Key1 = g.Key });

            var numCountAbnObjCat1 = tableCategory.Where(r => r.Key1.idCategory == "I" || r.Key1.idCategory == "I особая");
            this.numCountAbnObjCat1.Value = numCountAbnObjCat1.Count() > 0 ? numCountAbnObjCat1.Count() : 0;

            var numCountAbnObjCat2 = tableCategory.Where(r => r.Key1.idCategory == "II");
            this.numCountAbnObjCat2.Value = numCountAbnObjCat2.Count() > 0 ? numCountAbnObjCat2.Count() : 0;

            var numCountAbnObjCat3 = tableCategory.Where(r => r.Key1.idCategory == "III");
            this.numCountAbnObjCat3.Value = numCountAbnObjCat3.Count() > 0 ? numCountAbnObjCat3.Count() : 0;

            var tableCategoryNet = tableSchmAbnFull.AsEnumerable()
                .Where(w => (int)w["CountPoint"] != 0 && !((int)w["typeAbn"] != 231 && ((int)w["idAbnNet"] == 220859 || (int)w["idAbnNet"] == 434002)))
                .GroupBy(r => r["idAbnObj"])
                .Count();
            this.numCountAbnObjEE.Value = tableCategoryNet;

            //// расчет максимальной мощности
            this.numCountAbnObj150.Value = Convert.ToInt32(tableSchmAbnFull.Compute("count(CategoryName)", "PowerSet <= 150 and CountPoint > 0"));
            this.numCountAbnObj150670.Value = Convert.ToInt32(tableSchmAbnFull.Compute("count(CategoryName)", "PowerSet > 150 and PowerSet <= 670 and CountPoint > 0"));
            this.numCountAbnObj670.Value = Convert.ToInt32(tableSchmAbnFull.Compute("count(CategoryName)", "PowerSet > 670 and CountPoint > 0"));
        }
        /// <summary>
        /// Загрузка в документе узла CountAbnObj (количество объектов абонентов)
        /// </summary>
        private void AppendChildCountAbnObj(XmlNode xml)
        {
            try
            {
                if (xml != null && xml.OwnerDocument != null)
                {
                    XmlDocument ownerDocument = xml.OwnerDocument;
                    XmlNode xmlNode = ownerDocument.CreateElement("CountAbnObj");
                    xml.AppendChild(xmlNode);
                    XmlAttribute xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat1");
                    xmlAttribute.Value = this.numCountAbnObjCat1.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat1Full");
                    xmlAttribute.Value = this.numCountAbnObjCat1Full.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat2");
                    xmlAttribute.Value = this.numCountAbnObjCat2.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat2Full");
                    xmlAttribute.Value = this.numCountAbnObjCat2Full.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countAbnObjCat3");
                    xmlAttribute.Value = this.numCountAbnObjCat3.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countAbnObjEE");
                    xmlAttribute.Value = this.numCountAbnObjEE.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countAbnObjSource");
                    xmlAttribute.Value = this.numCountAbnObjSource.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countAbnObj150");
                    xmlAttribute.Value = this.numCountAbnObj150.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countAbnObj150670");
                    xmlAttribute.Value = this.numCountAbnObj150670.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                    xmlAttribute = ownerDocument.CreateAttribute("countAbnObj670");
                    xmlAttribute.Value = this.numCountAbnObj670.Value.ToString();
                    xmlNode.Attributes.Append(xmlAttribute);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Загрузка итогов количества абонентов по категориям
        /// </summary>
        private void LoadTotalCountAbnObj()
        {
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0 && this.dataSetDamage.tJ_Damage.Rows[0]["CommentXml"] != DBNull.Value)
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(this.dataSetDamage.tJ_Damage.Rows[0]["CommentXml"].ToString());
                    XmlNode xmlNode = xmlDocument.SelectSingleNode("Doc");
                    if (xmlNode != null)
                    {
                        XmlNode xmlNode2 = xmlNode.SelectSingleNode("AbnOff");
                        if (xmlNode2 != null)
                        {
                            XmlNode xmlNode3 = xmlNode2.SelectSingleNode("CountAbnObj");
                            if (xmlNode3 != null)
                            {
                                XmlAttribute xmlAttribute = xmlNode3.Attributes["countAbnObjCat1"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountAbnObjCat1.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countAbnObjCat1Full"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountAbnObjCat1Full.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countAbnObjCat2"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountAbnObjCat2.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countAbnObjCat2Full"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountAbnObjCat2Full.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countAbnObjCat3"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountAbnObjCat3.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countAbnObjEE"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountAbnObjEE.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countAbnObjSource"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountAbnObjSource.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countAbnObj150"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountAbnObj150.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countAbnObj150670"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountAbnObj150670.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNode3.Attributes["countAbnObj670"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    this.numCountAbnObj670.Value = Convert.ToInt32(xmlAttribute.Value);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
        }

        private void numCountAbnObjCat2Full_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.labelCountAbnObj.Text = "Количество объектов: " + (this.numCountAbnObjCat1.Value + this.numCountAbnObjCat1Full.Value + this.numCountAbnObjCat2.Value + this.numCountAbnObjCat2Full.Value + this.numCountAbnObjCat3.Value + this.numCountAbnObjEE.Value + this.numCountAbnObjSource.Value).ToString();
        }


        //[CompilerGenerated]
        //private bool getIdSchmObj(ElectricObject obj)
        //{
        //	return obj.Id == Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"]);
        //}

        private void dgvTree_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (this.dgvTreeSub[this.trNameColumn.Index, e.RowIndex].Value != null && !string.IsNullOrEmpty(this.dgvTreeSub[this.trNameColumn.Index, e.RowIndex].Value.ToString()))
                {
                    e.CellStyle.BackColor = Color.LightGray;
                }
                if (this.dgvTreeSub[this.dateOnColumn.Index, e.RowIndex].Value != null && !string.IsNullOrEmpty(this.dgvTreeSub[this.dateOnColumn.Index, e.RowIndex].Value.ToString()))
                {
                    e.CellStyle.ForeColor = Color.Blue;
                }
            }
        }

        private void dgvTree_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right && !this.GetFormViewMode() && !this.checkBoxApply.Checked)
            {
                this.contextMenuDgvTree.Show(Cursor.Position);
            }
        }
        private void dgvTrans_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void dgvTrans_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }

        private void dgvTrans_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void toolBtnRefreshTrans_Click(object sender, EventArgs e)
        {
            this.RefreshTable();
        }


        /// <summary>
        /// Сохранение xml-данных трнасформатора
        /// </summary>
        private void AppendChildTransOff()
        {
            XmlDocument xmlDocument = new XmlDocument();
            if (this.dataSetDamage.tJ_Damage.Rows[0]["CommentXml"] != DBNull.Value)
            {
                try
                {
                    xmlDocument.LoadXml(this.dataSetDamage.tJ_Damage.Rows[0]["CommentXml"].ToString());
                }
                catch
                {
                }
            }
            XmlNode xmlNodeDoc = xmlDocument.SelectSingleNode("Doc");
            if (xmlNodeDoc == null)
            {
                xmlNodeDoc = xmlDocument.CreateElement("Doc");
                xmlDocument.AppendChild(xmlNodeDoc);
            }
            XmlNode xmlNodeTransOff = xmlNodeDoc.SelectSingleNode("TransOff");
            if (xmlNodeTransOff != null)
            {
                xmlNodeTransOff.RemoveAll();
            }
            else
            {
                xmlNodeTransOff = xmlDocument.CreateElement("TransOff");
                xmlNodeDoc.AppendChild(xmlNodeTransOff);
            }
            foreach (DataRow dataRow in this.tableTransOff.Rows)
            {
                XmlNode xmlNodeRow = xmlDocument.CreateElement("Row");
                xmlNodeTransOff.AppendChild(xmlNodeRow);
                XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("idSub");
                xmlAttribute.Value = dataRow["idSub"].ToString();
                xmlNodeRow.Attributes.Append(xmlAttribute);
                xmlAttribute = xmlDocument.CreateAttribute("idTr");
                xmlAttribute.Value = dataRow["idTr"].ToString();
                xmlNodeRow.Attributes.Append(xmlAttribute);
                xmlAttribute = xmlDocument.CreateAttribute("Power");
                xmlAttribute.Value = dataRow["Power"].ToString();
                xmlNodeRow.Attributes.Append(xmlAttribute);
                xmlAttribute = xmlDocument.CreateAttribute("Load");
                xmlAttribute.Value = dataRow["Load"].ToString();
                xmlNodeRow.Attributes.Append(xmlAttribute);
            }
            this.AppendChildTransTree(xmlNodeTransOff);
            this.dataSetDamage.tJ_Damage.Rows[0]["CommentXml"] = xmlDocument.InnerXml;
        }

        /// <summary>
        /// загрузка таблицы отключенных трансформатров
        /// + создание структуры - если таблицы не было
        /// </summary>
        private void LoadTableTransOff()
        {
            this.tableTransOff.Clear();
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0 && this.dataSetDamage.tJ_Damage.Rows[0]["CommentXml"] != DBNull.Value)
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(this.dataSetDamage.tJ_Damage.Rows[0]["CommentXml"].ToString());
                    XmlNode xmlNode = xmlDocument.SelectSingleNode("Doc");
                    if (xmlNode != null)
                    {
                        XmlNode xmlNode2 = xmlNode.SelectSingleNode("TransOff");
                        if (xmlNode2 != null)
                        {
                            List<string> list = new List<string>();
                            List<string> list2 = new List<string>();
                            foreach (XmlNode xmlNodeRow in xmlNode2.SelectNodes("Row"))
                            {
                                DataRow dataRow = this.tableTransOff.NewRow();
                                XmlAttribute xmlAttribute = xmlNodeRow.Attributes["idSub"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    dataRow["idSub"] = xmlAttribute.Value;
                                    list.Add(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNodeRow.Attributes["idTr"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    dataRow["idTr"] = xmlAttribute.Value;
                                    list2.Add(xmlAttribute.Value);
                                }
                                xmlAttribute = xmlNodeRow.Attributes["Power"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    dataRow["Power"] = xmlAttribute.Value;
                                }
                                xmlAttribute = xmlNodeRow.Attributes["Load"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    dataRow["Load"] = xmlAttribute.Value;
                                }
                                this.tableTransOff.Rows.Add(dataRow);
                            }

                            DataTable dataTable = new DataTable("vSchm_ObjList");
                            dataTable.Columns.Add("id", typeof(int));
                            dataTable.Columns.Add("name", typeof(string));
                            dataTable.Columns.Add("typeCodeSocr", typeof(string));
                            dataTable.Columns.Add("fullname", typeof(string), "typeCodeSocr + '-'+name");
                            if (list.Count > 0)
                            {
                                base.SelectSqlData(dataTable, true, " where id in (" + string.Join(",", list.ToArray()) + ")", null, false, 0);
                            }
                            DataTable dataTable2 = new DataTable("tSchm_ObjList");
                            dataTable2.Columns.Add("id", typeof(int));
                            dataTable2.Columns.Add("name", typeof(string));
                            if (list2.Count > 0)
                            {
                                base.SelectSqlData(dataTable2, true, " where id in (" + string.Join(",", list2.ToArray()) + ")", null, false, 0);
                            }
                            if (dataTable.Rows.Count > 0 || dataTable2.Rows.Count > 0)
                            {
                                foreach (DataRow dataRow2 in this.tableTransOff.Rows)
                                {
                                    if (dataRow2["idSub"] != DBNull.Value)
                                    {
                                        DataRow[] array = dataTable.Select("id = " + dataRow2["idSub"].ToString());
                                        if (array.Length != 0)
                                        {
                                            dataRow2["Sub"] = array[0]["FullName"];
                                        }
                                    }
                                    if (dataRow2["idTr"] != DBNull.Value)
                                    {
                                        DataRow[] array2 = dataTable2.Select("id = " + dataRow2["idTr"].ToString());
                                        if (array2.Length != 0)
                                        {
                                            dataRow2["TrName"] = array2[0]["Name"];
                                        }
                                    }
                                }
                            }
                            this.labelCountTr.Text = "Кол-во трансформаторов: " + this.tableTransOff.Rows.Count.ToString();
                            this.labelSumPower.Text = "Суммарная мощность: " + this.tableTransOff.Compute("Sum(Power)", "").ToString();
                            this.labelSumLoad.Text = "Суммарная нагрузка: " + this.tableTransOff.Compute("Sum(Load)", "").ToString();
                            this.FillDGVTree(xmlDocument);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
        }
        /// <summary>
        /// заполним datagridview dgvTree
        /// </summary>
        private void FillDGVTree(XmlDocument xml)
        {
            XmlNode xmlNode = xml.SelectSingleNode("Doc");
            if (xmlNode == null)
            {
                return;
            }
            XmlNode xmlNode2 = xmlNode.SelectSingleNode("TransOff");
            if (xmlNode2 == null)
            {
                return;
            }
            XmlNode xmlNode3 = xmlNode2.SelectSingleNode("TransTree");
            if (xmlNode3 == null)
            {
                return;
            }
            foreach (XmlNode xmlNode_ in xmlNode3.SelectNodes("NodeDgv"))
            {
                this.CreateTreeStructureDGVTree(xmlNode_, this.dgvTreeSub.Nodes);
            }
        }
        /// <summary>
        /// Создадим структуру дерева в таблице dgvTree
        /// при открытии
        /// </summary>
        private void CreateTreeStructureDGVTree(XmlNode xmlNode, TreeDataGridViewNodeCollection treeDataGridViewNodeCollection)
        {
            TreeDataGridViewNode treeDataGridViewNode = treeDataGridViewNodeCollection.Add(new object[0]);
            foreach (DataGridViewColumn dataGridViewColumn in this.dgvTreeSub.Columns)
            {
                if (!string.IsNullOrEmpty(dataGridViewColumn.DataPropertyName))
                {
                    XmlAttribute xmlAttribute = xmlNode.Attributes[dataGridViewColumn.DataPropertyName];
                    if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                    {
                        treeDataGridViewNode.Cells[dataGridViewColumn.Index].Value = xmlAttribute.Value;
                    }
                }
            }
            foreach (XmlNode xmlNode_ in xmlNode.SelectNodes("NodeDgv"))
            {
                this.CreateTreeStructureDGVTree(xmlNode_, treeDataGridViewNode.Nodes);
            }
        }

        /// <summary>
        /// Заполнить дерево трансформаторами попавшими под отключение
        /// </summary>
        private void FillTreeNodeTrans(TreeNodeObj treeNodeObj, List<int> listTrans)
        {
            if (treeNodeObj.Tag != null && treeNodeObj.Tag is ElectricLine)
            {
                foreach (ElectricRelation electricRelation in ((ElectricLine)treeNodeObj.Tag).Relations)
                {
                    foreach (ElectricObject electricObject in electricRelation.ChildObjects)
                    {
                        if (electricObject is ElectricSwitch && ((ElectricSwitch)electricObject).TypeSwitch == TypeSwitch.TransformerTool && !listTrans.Contains(electricObject.Id))
                        {
                            listTrans.Add(electricObject.Id);
                        }
                    }
                }
            }
            foreach (TreeNodeObj Obj in treeNodeObj.Nodes)
            {
                this.FillTreeNodeTrans(Obj, listTrans);
            }
        }

        /// <summary>
        /// Заполнить таблицу отключенных трансформаторов
        /// </summary>
        private void FillTableTransOff(List<int> listTrans)
        {
            this.tableTransOff.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.GetTransformerSchmObj.sql"), sqlConnection))
                {
                    sqlCommand.CommandTimeout = 0;
                    DataTable dataTable = new DataTable();
                    new SqlDataAdapter(sqlCommand).Fill(dataTable);
                    int num = 0;
                    foreach (int num2 in listTrans)
                    {
                        DataRow[] array = dataTable.Select("id = " + num2.ToString());
                        if (array.Length != 0)
                        {
                            DataRow dataRow = this.tableTransOff.NewRow();
                            dataRow["idTR"] = array[0]["id"];
                            dataRow["TrNAme"] = array[0]["Наименование"];
                            dataRow["idSub"] = array[0]["idSub"];
                            dataRow["Sub"] = array[0]["Расположение"];
                            if (array[0]["Мощность"] != DBNull.Value && !string.IsNullOrEmpty(array[0]["Мощность"].ToString()))
                            {
                                dataRow["Power"] = array[0]["Мощность"];
                            }
                            if (array[0]["Мощность"] != DBNull.Value && !string.IsNullOrEmpty(array[0]["Мощность"].ToString()))
                            {
                                num += Convert.ToInt32(array[0]["Мощность"]);
                            }
                            this.tableTransOff.Rows.Add(dataRow);
                        }
                    }
                }
                using (SqlCommand sqlCommand2 = new SqlCommand("SELECT mat.idbus, mat.[IdObjList],\r\n                        \t(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) \r\n                        \t then max([Ia]) \telse case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) \r\n                        \t\t\t\t\t                                else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) \r\n                        \t\t\t\t\t                                then max([Ic]) end end end) as I\r\n                         FROM [tJ_MeasAmperageTransf] as mat\r\n                               inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n                          where  mat.deleted = 0 and m.[TypeDoc] = 1192\r\n                        \tand ((year(m.[DateD]) = \r\n                        \t\t\t(select case when month(max(dateD)) = 12 then year(max(dateD)) + 1\r\n                        \t\t\t\t\telse year(max(dateD)) end from tj_measurement mes \r\n                        \t\t\tleft join [tJ_MeasAmperageTransf] mt on mt.[idMeasurement] = mes.id\r\n                        \t\t\t where mt.idBus = mat.idBus and mt.deleted = 0 and m.typeDoc = 1192\t\r\n                        \t\t\t and  mt.[Ia] is not null and  mt.[Ib] is not null and  mt.[Ic] is not null)\r\n                                      and month(m.[DateD]) between 1 and 11)\t\r\n                           or (year(m.[DateD]) =(select case when month(max(dateD)) = 12 then year(max(dateD)) + 1\r\n                        \telse year(max(dateD)) end\r\n                        \tfrom tj_measurement mes \r\n                        \tleft join [tJ_MeasAmperageTransf] mt on mt.[idMeasurement] = mes.id\r\n                        \twhere mt.idBus = mat.idBus and mt.deleted = 0 and m.typeDoc = 1192\r\n                        \t and  mt.[Ia] is not null and  mt.[Ib] is not null and  mt.[Ic] is not null)-1 and month(m.[DateD])=12)) \r\n                            and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n                          group by mat.idBus,  mat.[idObjList]", sqlConnection))
                {
                    sqlCommand2.CommandTimeout = 0;
                    DataTable dataTable2 = new DataTable();
                    new SqlDataAdapter(sqlCommand2).Fill(dataTable2);
                    foreach (DataRow dataRow2 in this.tableTransOff.Rows)
                    {
                        DataRow[] array2 = dataTable2.Select("idObjList = " + dataRow2["idTr"].ToString());
                        if (array2.Length != 0)
                        {
                            dataRow2["Load"] = array2[0]["I"];
                        }
                    }
                }
            }

        }
        /// <summary>
        /// Очистка таблицы отключенных подстанций
        /// </summary>
        private void dgvTreeNodesClear()
        {
            if (this.dgvTreeSub.InvokeRequired)
            {
                this.dgvTreeSub.Invoke(new MethodInvoker(this.dgvTreeNodesClear));
                return;
            }
            this.dgvTreeSub.Nodes.Clear();
        }
        /// <summary>
        /// Добавление параметров в дерево отключенных подстанций 
        /// </summary>
        private TreeDataGridViewNode AddTreeParametrSub(TreeDataGridViewNodeCollection treeDataGridViewNodeCollection, params object[] values)
        {
            if (this.dgvTreeSub.InvokeRequired)
            {
                return (TreeDataGridViewNode)this.dgvTreeSub.Invoke(new TreeParametr(this.AddTreeParametrSub), new object[]
                {
                treeDataGridViewNodeCollection,
                values
                });
            }
            return treeDataGridViewNodeCollection.Add(values);
        }

        /// <summary>
        /// Заполнить дерево (dgvTree) подстанциями попавшими под отключение
        /// </summary>
        private void FillTableSubOff(TreeDataGridViewNode SubNodeTree, TreeNodeObj RootNodeObj, string VoltageLine = "", List<string> ListSub = null)
        {
            if (RootNodeObj.Tag != null)
            {
                //// если SubNodeTree пустое, то это начало ветки
                if (SubNodeTree == null)
                {
                    if (RootNodeObj.Tag is ElectricBus) // шина
                    {
                        string electricBusName = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[] { ((ElectricBus)RootNodeObj.Tag).Id.ToString() }).ToString();
                        var electricSub = (ElectricSubstation)((ElectricObject)RootNodeObj.Tag).Parent;

                        string electricTypeSub = Reference.Tables.GetTypeSubstation(electricSub.TypeSubstation);

                        var qBeg = electricSub.ChildObjects.Where(r => r is ElectricBus);
                        var q1 = from r in qBeg
                                 select new
                                 {
                                     VoltageLineME = Reference.Tables.GetVoltageObject(((ElectricBus)r).TypeBus),
                                     VoltageLine = Convert.ToDouble(Reference.Tables.GetVoltageObject(((ElectricBus)r).TypeBus, false).Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                                 };
                        VoltageLine = (from r in q1
                                       orderby r.VoltageLine descending
                                       select r).First().VoltageLineME;

                        electricBusName = electricTypeSub + " " + VoltageLine + " кВ " + electricBusName;

                        SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                         {
                            electricBusName,
                            ((ElectricBus)RootNodeObj.Tag).Id
                         });
                    }
                    else if (RootNodeObj.Tag is ElectricLine)
                    {
                        string electricBusName = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[] { ((ElectricLine)RootNodeObj.Tag).Id.ToString() }).ToString();
                        var electricSub = (ElectricSubstation)((ElectricObject)RootNodeObj.Tag).Parent;

                        string electricTypeSub = Reference.Tables.GetTypeSubstation(electricSub.TypeSubstation);

                        var qBeg = electricSub.ChildObjects.Where(r => r is ElectricBus);
                        var q1 = from r in qBeg
                                 select new
                                 {
                                     VoltageLineME = Reference.Tables.GetVoltageObject(((ElectricBus)r).TypeBus),
                                     VoltageLine = Convert.ToDouble(Reference.Tables.GetVoltageObject(((ElectricBus)r).TypeBus, false).Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                                 };
                        VoltageLine = (from r in q1
                                       orderby r.VoltageLine descending
                                       select r).First().VoltageLineME;

                        electricBusName = electricTypeSub + " " + VoltageLine + " кВ " + electricBusName;

                        SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                        {
                            electricBusName,
                            ((ElectricLine)RootNodeObj.Tag).Id
                        });
                    }
                    else if (RootNodeObj.Tag is ElectricSubstation)
                    {
                        string electricBusName = ((ElectricSubstation)RootNodeObj.Tag).ToString();

                        var electricSub = (ElectricSubstation)((ElectricObject)RootNodeObj.Tag);
                        string electricTypeSub = Reference.Tables.GetTypeSubstation(electricSub.TypeSubstation);

                        var qBeg = electricSub.ChildObjects.Where(r => r is ElectricBus);
                        var q1 = from r in qBeg
                                 select new
                                 {
                                     VoltageLineME = Reference.Tables.GetVoltageObject(((ElectricBus)r).TypeBus),
                                     VoltageLine = Convert.ToDouble(Reference.Tables.GetVoltageObject(((ElectricBus)r).TypeBus, false).Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                                 };
                        VoltageLine = (from r in q1
                                       orderby r.VoltageLine descending
                                       select r).First().VoltageLineME;

                        electricBusName = electricTypeSub + " " + VoltageLine + " кВ " + electricBusName;

                        SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                        {
                         electricBusName,
                         ((ElectricSubstation)RootNodeObj.Tag).Id
                        });
                    }
                }
                if (RootNodeObj.Tag is ElectricBus)
                {
                    if (this.listElectricBus.Contains(((ElectricBus)RootNodeObj.Tag).Id))
                    {
                        return;
                    }
                    this.listElectricBus.Add(((ElectricBus)RootNodeObj.Tag).Id);

                }
                if (RootNodeObj.Tag is ElectricLine)
                {
                    ElectricLine electricLine = (ElectricLine)RootNodeObj.Tag;
                    if (electricLine.IsCell()) // если ячейка
                    {
                        ElectricBus electricBus = null;
                        foreach (ElectricPoint electricPoint in electricLine.Ends)
                        {
                            if (electricPoint.Parent is ElectricBus)
                            {
                                electricBus = (ElectricBus)electricPoint.Parent;
                                if (electricBus.TypeBus == eTypeShinaTool.Shina_10 || electricBus.TypeBus == eTypeShinaTool.Shina_110 || electricBus.TypeBus == eTypeShinaTool.Shina_35)
                                {
                                    break;
                                }
                                if (electricBus.TypeBus == eTypeShinaTool.Shina_6)
                                {
                                    break;
                                }
                                if (electricBus.TypeBus == eTypeShinaTool.Shina_04 || electricBus.TypeBus == eTypeShinaTool.Shina_023)
                                {
                                    break;
                                }
                                electricBus = null;
                            }
                        }
                        if (electricBus != null)
                        {

                            VoltageLine = Reference.Tables.GetVoltageObject(electricBus.TypeBus);
                            //string electricBusName = ReferenceTables.CreateReferenceTables.GetTypeSubstation(((ElectricSubstation)((ElectricObject)RootNodeObj.Tag).Parent).TypeSubstation) + " " + VoltageLine + " кВ " + electricBus.Parent.ToString();
                            string electricBusName = Reference.Tables.GetTypeSubstation(((ElectricSubstation)electricBus.Parent).TypeSubstation) + " " + VoltageLine + " кВ " + electricBus.Parent.ToString();

                            if (electricBus.TypeBus != eTypeShinaTool.Shina_04 && electricBus.TypeBus != eTypeShinaTool.Shina_023)
                            {
                                if (SubNodeTree == null)
                                {
                                    SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                                    {
                                //electricBus.Parent.ToString(),
                                electricBusName,
                                electricBus.Parent.Id,
                                electricBus.ToString(),
                                electricBus.Id,
                                electricLine.ToString(),
                                electricLine.Id
                                    });
                                }
                                else
                                {
                                    SubNodeTree = this.AddTreeParametrSub(SubNodeTree.Nodes, new object[]
                                    {
                                //electricBus.Parent.ToString(), // подстанция
                                electricBusName,
                                electricBus.Parent.Id,
                                electricBus.ToString(), // шина
                                electricBus.Id,
                                electricLine.ToString(), // ячейка
                                electricLine.Id
                                    });
                                }
                            }
                            else
                            {
                                //if (ListSub != null || ListSub.Count > 0 ) ListSub.Clear();
                                ListSub = new List<string>();
                                ListSub.Add(electricBus.Parent.ToString());
                                ListSub.Add(electricBus.Parent.Id.ToString());
                                ListSub.Add(electricBus.ToString());
                                ListSub.Add(electricBus.Id.ToString());
                                ListSub.Add(electricLine.ToString());
                                ListSub.Add(electricLine.Id.ToString());
                            }
                        }
                    }
                    else // если не ячейка а кабель
                         // сформируем имя линии, для этого
                         // надо найти тип линии и напряжение линии
                         // можно через шину, но это двигаться вверх долго   
                    {
                        DataRow[] row = dtSchmCable.Select("id = " + electricLine.Id);
                        string electricLineName = "";
                        if (row.Count() > 0)
                            //electricLineName = row.First()["TypeCable"] + " " + VoltageLine.Replace(".", ",") + " кВ ";
                            electricLineName = row.First()["TypeCable"] + " " + VoltageLine + " кВ ";
                        else
                            electricLineName = "КЛ 0.38 кВ ";
                        // если в названии линии нет имени подстанции, то надо ее добавить
                        if (ListSub != null && electricLine.ToString().IndexOf(ListSub[0]) < 0)
                            electricLineName = electricLineName + ListSub[0] + @"\";
                        electricLineName = electricLineName + electricLine.ToString();

                        if (SubNodeTree == null)
                        {
                            if (ListSub != null)
                                SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                                {
                            electricLineName, electricLine.Id, ListSub[2], ListSub[3], ListSub[4], ListSub[5]
                                });
                            else
                                SubNodeTree = this.AddTreeParametrSub(this.dgvTreeSub.Nodes, new object[]
                                {
                            electricLineName, electricLine.Id
                                });
                        }
                        else
                        {
                            if (ListSub != null)
                                SubNodeTree = this.AddTreeParametrSub(SubNodeTree.Nodes, new object[]
                            {
                            electricLineName, electricLine.Id, ListSub[2], ListSub[3], ListSub[4], ListSub[5]
                           });
                            else
                                SubNodeTree = this.AddTreeParametrSub(SubNodeTree.Nodes, new object[]
                                {
                            electricLineName, electricLine.Id
                                });
                        }
                    }
                    // заполним используемые трансформаторы в таблице (грид) отключенных подстанций
                    foreach (ElectricRelation electricRelation in ((ElectricLine)RootNodeObj.Tag).Relations)
                    {
                        foreach (ElectricObject electricObject in electricRelation.ChildObjects)
                        {
                            if (electricObject is ElectricSwitch && ((ElectricSwitch)electricObject).TypeSwitch == TypeSwitch.TransformerTool && SubNodeTree != null)
                            {
                                if (SubNodeTree.Cells[this.idTrColumn.Index].Value != null && !string.IsNullOrEmpty(SubNodeTree.Cells[this.idTrColumn.Index].Value.ToString()))
                                {
                                    SubNodeTree = SubNodeTree.Parent.Nodes.Add(new object[]
                                    {
                                    SubNodeTree.Cells[this.subNameColumn.Index].Value,
                                    SubNodeTree.Cells[this.idSubColumn.Index].Value,
                                    SubNodeTree.Cells[this.busNameColumn.Index].Value,
                                    SubNodeTree.Cells[this.idBusColumn.Index].Value,
                                    SubNodeTree.Cells[this.cellNameColumn.Index].Value,
                                    SubNodeTree.Cells[this.idCellColumn.Index].Value
                                    });
                                }
                                DataRow[] array = this.tableTransOff.Select("idTr = " + electricObject.Id.ToString());
                                int? power = null;
                                int? load = null;
                                if (array.Length != 0)
                                {
                                    if (array[0]["power"] != DBNull.Value)
                                    {
                                        power = new int?(Convert.ToInt32(array[0]["power"]));
                                    }
                                    if (array[0]["load"] != DBNull.Value)
                                    {
                                        load = new int?(Convert.ToInt32(array[0]["load"]));
                                    }
                                }
                                if (power != null)
                                {
                                    if (SubNodeTree.Cells[8].Value != null && !string.IsNullOrEmpty(SubNodeTree.Cells[8].Value.ToString()))
                                    {
                                        SubNodeTree.Cells[8].Value = Convert.ToInt32(SubNodeTree.Cells[8].Value) + power;
                                    }
                                    else
                                    {
                                        SubNodeTree.Cells[8].Value = power;
                                    }
                                }
                                if (load != null)
                                {
                                    if (SubNodeTree.Cells[9].Value != null && !string.IsNullOrEmpty(SubNodeTree.Cells[9].Value.ToString()))
                                    {
                                        SubNodeTree.Cells[9].Value = Convert.ToInt32(SubNodeTree.Cells[9].Value) + load;
                                    }
                                    else
                                    {
                                        SubNodeTree.Cells[9].Value = load;
                                    }
                                }
                                if (SubNodeTree.Cells[6].Value != null && !string.IsNullOrEmpty(SubNodeTree.Cells[6].Value.ToString()))
                                {
                                    DataGridViewCell dataGridViewCell = SubNodeTree.Cells[6];
                                    dataGridViewCell.Value = dataGridViewCell.Value + ";" + electricObject.ToString();
                                    DataGridViewCell dataGridViewCell2 = SubNodeTree.Cells[7];
                                    dataGridViewCell2.Value = dataGridViewCell2.Value + ";" + electricObject.Id;
                                }
                                else
                                {
                                    SubNodeTree.Cells[6].Value = electricObject.ToString();
                                    SubNodeTree.Cells[7].Value = electricObject.Id;
                                }
                            }
                        }
                    }
                }
                else if (RootNodeObj.Tag is ElectricBus)
                {
                    VoltageLine = Reference.Tables.GetVoltageObject(((ElectricBus)RootNodeObj.Tag).TypeBus);
                }
            }
            foreach (TreeNodeObj node in RootNodeObj.Nodes)
            {
                this.FillTableSubOff(SubNodeTree, node, VoltageLine, ListSub);
            }
        }
        /// <summary>
        /// сохраняем подстанции
        /// </summary>
        private void AppendChildTransTree(XmlNode xml)
        {
            if (xml != null && xml.OwnerDocument != null)
            {
                XmlDocument ownerDocument = xml.OwnerDocument;
                if (xml != null)
                {
                    XmlNode xmlNode = ownerDocument.CreateElement("TransTree");
                    xml.AppendChild(xmlNode);
                    foreach (TreeDataGridViewNode treeDataGridViewNode_ in this.dgvTreeSub.Nodes)
                    {
                        this.AppendChildNodeTransTree(treeDataGridViewNode_, xmlNode);
                    }
                }
                return;
            }
        }
        /// <summary>
        /// сохранение элементов NOde (отдельного узла) таблицы отключенных подстанций
        /// </summary>
        private void AppendChildNodeTransTree(TreeDataGridViewNode treeDataGridViewNode, XmlNode xmlNode)
        {
            XmlNode xmlNodeDgv = xmlNode.OwnerDocument.CreateElement("NodeDgv");
            xmlNode.AppendChild(xmlNodeDgv);
            foreach (DataGridViewColumn dataGridViewColumn in this.dgvTreeSub.Columns)
            {
                if (!string.IsNullOrEmpty(dataGridViewColumn.DataPropertyName) && treeDataGridViewNode.Cells[dataGridViewColumn.Index].Value != null)
                {
                    XmlAttribute xmlAttribute = xmlNode.OwnerDocument.CreateAttribute(dataGridViewColumn.DataPropertyName);
                    xmlAttribute.Value = treeDataGridViewNode.Cells[dataGridViewColumn.Index].Value.ToString();
                    xmlNodeDgv.Attributes.Append(xmlAttribute);
                }
            }
            foreach (TreeDataGridViewNode treeDataGridViewNode_ in treeDataGridViewNode.Nodes)
            {
                this.AppendChildNodeTransTree(treeDataGridViewNode_, xmlNodeDgv);
            }
        }
        /// <summary>
        /// заполнить количесиво электроустановок
        /// </summary>
        private void FillCountTrans()
        {
            this.labelCountTr.Text = "Кол-во трансформаторов: " + this.tableTransOff.Rows.Count.ToString();
            this.labelSumPower.Text = "Суммарная мощность: " + this.tableTransOff.Compute("Sum(Power)", "").ToString();
            this.labelSumLoad.Text = "Суммарная нагрузка: " + this.tableTransOff.Compute("Sum(Load)", "").ToString();

        }

        /// <summary>
        /// загрузка абонентов
        /// </summary>
        private void LoadTableAbnOff()
        {
            this.tableSchmAbnFull.Clear();
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0 && this.dataSetDamage.tJ_Damage.Rows[0]["CommentXml"] != DBNull.Value)
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(this.dataSetDamage.tJ_Damage.Rows[0]["CommentXml"].ToString());
                    XmlNode xmlNodeDoc = xmlDocument.SelectSingleNode("Doc");
                    if (xmlNodeDoc != null)
                    {
                        XmlNode xmlNodeAbnOff = xmlNodeDoc.SelectSingleNode("AbnOff");
                        if (xmlNodeAbnOff != null)
                        {
                            foreach (XmlNode xmlNodeRow in xmlNodeAbnOff.SelectNodes("Row"))
                            {
                                DataRow dataRow = this.tableSchmAbnFull.NewRow();
                                foreach (XmlAttribute attr in xmlNodeRow.Attributes)
                                {
                                    if (tableSchmAbnFull.Columns.Contains(attr.Name))
                                        if (attr != null && !string.IsNullOrEmpty(attr.Value))
                                        {

                                            if (attr.Name == "PowerSet")
                                            {
                                                if (Decimal.TryParse(attr.Value, out decimal PowerSetD) == false)
                                                {
                                                    if (attr.Value.IndexOf(".") > 0)
                                                        PowerSetD = Convert.ToDecimal(attr.Value.Replace(".", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                                                    else if (attr.Value.IndexOf(",") > 0)
                                                        PowerSetD = Convert.ToDecimal(attr.Value.Replace(",", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                                                    else
                                                        PowerSetD = 0;
                                                }
                                                dataRow[attr.Name] = PowerSetD;
                                            }
                                            else
                                                dataRow[attr.Name] = attr.Value;
                                        }
                                }

                                if (dataRow[0] != System.DBNull.Value)
                                {
                                    this.tableSchmAbnFull.Rows.Add(dataRow);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
        }
        private void dgvAbn_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.CalculationCountPoints();
            this.CalculationCountConsumersAndMaximumPower();

        }
        private void GetVisibleChkSendSiteME()
        {
            DataTable dataTable = new DataTable("tUser");
            dataTable.Columns.Add("idUser", typeof(int));
            base.SelectSqlData(dataTable, true, " left join vworkergroup w on w.id = tuser.idWorker\r\n                                where w.ParentKey = ';GroupWorker;DailyReport;Admin;' and tuser.login = SYSTEM_USER", null, false, 0);
            if (dataTable.Rows.Count > 0)
                this.chkSendSiteME.Visible = true;
            else
                this.chkSendSiteME.Visible = false;
        }

    }
}