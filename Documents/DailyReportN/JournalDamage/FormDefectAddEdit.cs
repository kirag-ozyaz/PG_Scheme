using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using Constants;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
//using Documents.Properties;
using FormLbr;
using SchemeModel;
/// <summary>
/// Дефект
/// </summary>
namespace DailyReportN.JournalDamage
{
    internal partial class FormDefectAddEdit : FormBase
    {
        private int IdDocument = -1;
        private bool isChangedData;
        private bool flagViewDoc;
        private int? TypeDocumentParent;
        private int TypeDocument = (int)eTypeDocuments.DefectLV;
        /// <summary>
        /// список подстанций
        /// </summary>
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
                this.Text = "Просмотр дефекта";
            }
            this.txtNumRequest.ReadOnly = this.GetFormViewMode();
            this.dtpDateDoc.Enabled = !this.GetFormViewMode();
            this.cmbCompiler.ReadOnly = this.GetFormViewMode();
            this.cmbDivision.ReadOnly = this.GetFormViewMode();
            this.btnChoiceSchmObj.Enabled = !this.GetFormViewMode();
            this.txtLocation.ReadOnly = this.GetFormViewMode();
            this.cmbObl.ReadOnly = (this.cmbRaionObl.ReadOnly = (this.cmbCity.ReadOnly = (this.cmbStreet.ReadOnly = this.GetFormViewMode())));
            this.txtHouse.ReadOnly = (this.txtHousePrefix.ReadOnly = this.GetFormViewMode());
            this.cmbReason.ReadOnly = this.GetFormViewMode();
            this.dgvCharacterDamage.ReadOnly = this.GetFormViewMode();
            this.cmbCompletedWork.Enabled = !this.GetFormViewMode();
            this.txtCompletedWork.ReadOnly = this.GetFormViewMode();
            this.checkBoxApply.Enabled = !this.GetFormViewMode();
            this.cmbWorkerApply.Enabled = (this.dtpDataApply.Enabled = (this.dtpDatePlanApply.Enabled = !this.GetFormViewMode()));
            this.toolBtnRefreshAbn.Enabled = (this.toolBrnDelAbn.Enabled = !this.GetFormViewMode());
            this.buttonSave.Visible = !this.GetFormViewMode();
            this.toolBtn81.Enabled = !this.GetFormViewMode();
            this.toolBtnRefreshCountAbn.Enabled = !this.GetFormViewMode();
            this.numCountPointCat1.ReadOnly = (this.numCountPointCat1Full.ReadOnly = (this.numCountPointCat2.ReadOnly = (this.numCountPointCat2Full.ReadOnly = (this.numCountPointCat3.ReadOnly = (this.numCountPointEE.ReadOnly = (this.numCountPointSource.ReadOnly = this.GetFormViewMode()))))));
            this.numCountAbnObjCat1.ReadOnly = (this.numCountAbnObjCat1Full.ReadOnly = (this.numCountAbnObjCat2.ReadOnly = (this.numCountAbnObjCat2Full.ReadOnly = (this.numCountAbnObjCat3.ReadOnly = (this.numCountAbnObjEE.ReadOnly = (this.numCountAbnObjSource.ReadOnly = this.GetFormViewMode()))))));
            this.numCountAbnObj150.ReadOnly = (this.numCountAbnObj150670.ReadOnly = (this.numCountAbnObj670.ReadOnly = this.GetFormViewMode()));
        }

        internal FormDefectAddEdit(int idDocument = -1, int typeDoc = (int)eTypeDocuments.DefectLV)
        {

            this.InitializeComponent();
            this.dtpDateDoc.Value = DateTime.Now;
            this.dtpDataApply.Value = DateTime.Now;
            this.IdDocument = idDocument;
            this.TypeDocument = typeDoc;
            string str = (typeDoc == (int)eTypeDocuments.DefectLV) ? " НН" : " ВН";
            this.Text = ((idDocument == -1) ? ("Добавить дефект" + str) : (this.GetFormViewMode() ? "Просмотр дефекта" : "Редактировать дефект") + " (N2)");
        }

        private void FormDefectAddEdit_Load(object sender, EventArgs e)
        {
            this.LoadDocumentDamage();
            this.FillFieldsDataParentDocument();
            this.FillComboBoxDivision();
            this.FillComboBoxCompiler();
            this.FillComboBoxObl();
            this.FillComboBoxReason();
            this.FillComboBoxCompletedWork(this.cmbCompletedWork);
            this.FillComboBoxCompletedWork(this.cmbComplWorkODS);
            this.FillComboBoxWorkerApply();
            this.FillComboBoxDivisionApply();
            this.FillDataSourceTypeAbn();
            this.FillDataSourceColumnTypeObj();
            base.LoadFormConfig(null);
            if (this.IdDocument == -1)
            {
                DataRow dataRow = this.dataSetDamage.tJ_Damage.NewRow();
                dataRow["TypeDoc"] = this.TypeDocument;
                dataRow["dateOwner"] = DateTime.Now;
                this.dataSetDamage.tJ_Damage.Rows.Add(dataRow);

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
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["typeDoc"] != DBNull.Value)
                    {
                        this.TypeDocument = Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["typeDoc"]);
                        if (this.TypeDocument == (int)eTypeDocuments.DefectLV)
                        {
                            this.Text += " НН";
                        }
                        else
                        {
                            this.Text += " ВН";
                        }
                    }
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["numDoc"] != DBNull.Value)
                    {
                        //this.Text = this.Text + " №" + this.dataSetDamage.tJ_Damage.Rows[0]["numDoc"].ToString();

                        this.Text = this.Text + " (N2) №" + tableDamageL.Rows[0]["numDoc"].ToString()
                            + " (заявка №" + tableDamageL.Rows[0]["NumRequest"].ToString() + ")"
                            + " от " + Convert.ToDateTime(tableDamageL.Rows[0]["DateDoc"]).ToShortDateString();
                    }
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"] != DBNull.Value)
                    {
                        this.txtSchmObj.Text = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                        {
                        this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"].ToString()
                        }).ToString();
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
                if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
                {
                    DataTable dataTable = this.dataSetDamage.tJ_Damage;
                    if (dataTable.Rows[0]["idParent"] != DBNull.Value)
                    {
                        //Class171.Class172 tableDamageH = new Class171.Class172();
                        DailyReportN.DataSet.dsDamage.tJ_DamageDataTable tableDamageH = new DailyReportN.DataSet.dsDamage.tJ_DamageDataTable();
                        base.SelectSqlData(tableDamageH, true, "where id = " + dataTable.Rows[0]["idParent"].ToString(), null, false, 0);
                        if (tableDamageH.Rows.Count > 0)
                        {
                            dataTable = tableDamageH;
                        }
                    }
                    Reference.Tables.LoadTableDamageAbnFull2(dataTable, this.dtSchmAbnFull, this.SqlSettings);
                    this.LoadTotalCountPoint(dataTable);
                    this.LoadTotalCountAbnObj(dataTable);
                    this.labelCountAbn.Text = "Количество абонентов: " + this.dtSchmAbnFull.DefaultView.ToTable(true, new string[]
                    {
                    "idAbn"
                    }).Rows.Count.ToString();
                }
            }
            if (this.TypeDocument == (int)eTypeDocuments.DefectHV)
            {
                this.cmbCompletedWork.Visible = false;
            }
            this.FillOwnerDocument();
            this.ControlBloking();
            this.isChangedData = false;
        }
        /// <summary>
        /// заполняем поля по данным документа родителя
        /// </summary>
        private void FillFieldsDataParentDocument()
        {
            if (this.GetIdDocument() >= 0)
            {
                DataTable dataTable = new DataTable("tJ_Damage");
                dataTable.Columns.Add("idParent", typeof(int));
                base.SelectSqlData(dataTable, true, "where id = " + this.IdDocument.ToString(), null, false, 0);
                if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["idParent"] != DBNull.Value)
                {
                    this.cmbDivisionApply.ReadOnly = true;
                    this.checkBoxLaboratory.Enabled = false;
                    TextBoxBase textBoxBase = this.txtInstruction;
                    ComboBoxReadOnly comboBoxReadOnly = this.cmbComplWorkODS;
                    this.txtComplWorkODS.ReadOnly = true;
                    comboBoxReadOnly.ReadOnly = true;
                    textBoxBase.ReadOnly = true;
                    this.btnShowDocParent.Enabled = true;

                    DataTable dataTable2 = new DataTable("vJ_Damage");
                    dataTable2.Columns.Add("numDoc", typeof(int));
                    dataTable2.Columns.Add("dateDoc", typeof(DateTime));
                    dataTable2.Columns.Add("typeDocName", typeof(string));
                    dataTable2.Columns.Add("TypeDoc", typeof(int));
                    dataTable2.Columns.Add("nameDoc", typeof(string), "typedocname + isnull(' №' + convert(numDoc, System.String), ' №б/н') + isnull(' от ' + convert(dateDoc, System.String), '')");
                    base.SelectSqlData(dataTable2, true, "where id = " + dataTable.Rows[0]["idParent"].ToString(), null, false, 0);
                    if (dataTable2.Rows.Count > 0)
                    {
                        this.txtDocParent.Text = dataTable2.Rows[0]["nameDoc"].ToString();
                        this.TypeDocumentParent = new int?((int)Convert.ToInt16(dataTable2.Rows[0]["TypeDoc"]));
                    }
                    this.toolBtn81.Enabled = false;
                }
            }
        }

        private void FormDefectAddEdit_Shown(object sender, EventArgs e)
        {
            this.isChangedData = false;
        }

        private void FormDefectAddEdit_FormClosing(object sender, FormClosingEventArgs e)
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
            if (this.SaveDocument())
            {
                base.SaveFormConfig(null);
                base.DialogResult = DialogResult.OK;
                return;
            }
            base.DialogResult = DialogResult.None;
            e.Cancel = true;
        }
        /// <summary>
        /// прогрузка таблиц документа (основной и подчиненный с характерами повреждений)
        /// </summary>
        private void LoadDocumentDamage()
        {
            if (this.IdDocument > 0)
            {
                //this.tableDamage = new Class171.Class172();
                this.tableDamage = new DailyReportN.DataSet.dsDamage.tJ_DamageDataTable();
                base.SelectSqlData(this.tableDamage, true, "where id = " + this.IdDocument.ToString(), null, false, 0);
                this.tableDamageCharacter = new DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable(); // new Class171.Class184();
                base.SelectSqlData(this.tableDamageCharacter, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
            }
        }

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
            if (this.TypeDocumentParent == (int)eTypeDocuments.DamageHV)
            {
                if (this.tableDamage != null && this.tableDamage.Rows.Count > 0 && this.tableDamage.Rows[0]["idReason"] != DBNull.Value)
                {
                    base.SelectSqlData(dataTable, true, string.Format(" where (ParentKey = ';ReportDaily;DamageReason;HV;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0}) order by name", this.tableDamage.Rows[0]["idReason"]), null, false, 0);
                }
                else
                {
                    base.SelectSqlData(dataTable, true, " where ParentKey = ';ReportDaily;DamageReason;HV;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
                }
            }
            else if (this.tableDamage != null && this.tableDamage.Rows.Count > 0 && this.tableDamage.Rows[0]["idReason"] != DBNull.Value)
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

        private void FillComboBoxCompletedWork(ComboBox cmb)
        {
            DataTable dataTable = Reference.Tables.TableClassifier();
            if (this.TypeDocumentParent == (int)eTypeDocuments.DamageHV)
            {
                if (this.tableDamage != null && this.tableDamage.Rows.Count > 0 && this.tableDamage.Rows[0]["idCompletedWork"] != DBNull.Value)
                {
                    base.SelectSqlData(dataTable, true, string.Format(" where (ParentKey = ';ReportDaily;CompletedWork;HV;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0}) order by name", this.tableDamage.Rows[0]["idCompletedWork"]), null, false, 0);
                }
                else
                {
                    base.SelectSqlData(dataTable, true, " where ParentKey = ';ReportDaily;CompletedWork;HV;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
                }
            }
            else if (this.tableDamage != null && this.tableDamage.Rows.Count > 0 && this.tableDamage.Rows[0]["idCompletedWork"] != DBNull.Value)
            {
                base.SelectSqlData(dataTable, true, string.Format(" where (ParentKey = ';ReportDaily;CompletedWork;LV;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0}) order by name", this.tableDamage.Rows[0]["idCompletedWork"]), null, false, 0);
            }
            else
            {
                base.SelectSqlData(dataTable, true, " where ParentKey = ';ReportDaily;CompletedWork;LV;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
            }
            cmb.DisplayMember = "name";
            cmb.ValueMember = "id";
            cmb.DataSource = dataTable;
            cmb.SelectedIndex = -1;
        }

        private void FillComboBoxWorkerApply()
        {
            DataTable dataTable = new DataTable("vWorkerGroup");
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("FIO", typeof(string));
            base.SelectSqlData(dataTable, true, "where ParentKey in (';GroupWorker;PersonApplDiscon;Performer;NA1;',\r\n\t\t\t\t\t\t';GroupWorker;PersonApplDiscon;Performer;NA2;',\r\n\t\t\t\t\t\t';GroupWorker;PersonApplDiscon;Performer;NA3;',\r\n\t\t\t\t\t\t';GroupWorker;PersonApplDiscon;Performer;NA4;',\r\n\t\t\t\t\t\t';GroupWorker;PersonApplDiscon;Performer;PL;',\r\n\t\t\t\t\t\t';GroupWorker;PersonApplDiscon;Performer;SKUEE;',\r\n\t\t\t\t\t\t';GroupWorker;PersonApplDiscon;Performer;SESNO;') and dateEnd is null order by fio ", null, true, 0);
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
        /// <summary>
        /// привязка колонки к типам абонентов
        /// </summary>
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

        private void txtHousePrefix_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
        }

        private void dtpDatePlanApply_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
        }

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

        private void dtpDateDoc_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.dtpDateDoc.Value != null)
            {
                if (this.dtpDateDoc.Value != DBNull.Value)
                {
                    if (Convert.ToDateTime(this.dtpDateDoc.Value).Year >= 2016)
                    {
                        this.txtNumRequest.ReadOnly = true;
                        this.txtNumRequest.Text = null;
                    }
                    else
                    {
                        this.txtNumRequest.ReadOnly = false;
                    }
                    this.labelDateDoc.ForeColor = Color.Black;
                    this.dtpDataApply.MinDate = (this.dtpDatePlanApply.MinDate = Convert.ToDateTime(this.dtpDateDoc.Value));
                    return;
                }
            }
            this.dtpDataApply.MinDate = (this.dtpDatePlanApply.MinDate = DateTimePicker.MinimumDateTime);
            this.txtNumRequest.Text = null;
            /****************************/
            this.txtNumRequest.ReadOnly = true;
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
            CreateReferenceTables.GetSelectSchmObj(this.SqlSettings, this.dataSetDamage.tJ_Damage.Rows[0], this.txtSchmObj, ref this.isChangedData, null);
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
        /// <returns></returns>
        private bool CheckRequiredField()
        {
            bool flag = true;
            if (this.dtpDateDoc.Value == null || this.dtpDateDoc.Value == DBNull.Value)
            {
                this.labelDateDoc.ForeColor = Color.Red;
                flag = false;
            }
            if (Convert.ToDateTime(this.dtpDateDoc.Value).Year < 2016 && string.IsNullOrEmpty(this.txtNumRequest.Text))
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
                if (this.TypeDocument == (int)eTypeDocuments.DefectHV)
                {
                    if (string.IsNullOrEmpty(this.txtCompletedWork.Text))
                    {
                        this.labelCompletedWork.ForeColor = Color.Red;
                        flag = false;
                    }
                }
                else if (this.cmbCompletedWork.SelectedIndex < 0)
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
            if (this.cmbDivisionApply.SelectedIndex < 0 && !this.checkBoxLaboratory.Checked)
            {
                this.labelDivisionApply.ForeColor = Color.Red;
                this.checkBoxLaboratory.ForeColor = Color.Red;
                flag = false;
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
                    this.TypeDocument,
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
            if (this.TypeDocumentParent != (int)eTypeDocuments.DamageHV)
            {
                if (this.cmbStreet.SelectedIndex >= 0 && !string.IsNullOrEmpty(this.txtHouse.Text))
                {
                    int idMap = this.SaveDamageLocation();
                    if (idMap == -1)
                    {
                        MessageBox.Show("Не удается создать объект - дом");
                        return false;
                    }
                    this.dataSetDamage.tJ_Damage.Rows[0]["idMap"] = idMap;
                }
                else
                {
                    this.dataSetDamage.tJ_Damage.Rows[0]["idMap"] = DBNull.Value;
                }
            }
            this.dataSetDamage.tJ_Damage.Rows[0]["is81"] = !this.toolBtn81.Checked;
            this.AppendChildCommentXml();
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
            return this.SaveTableDamageAddCharacter() && this.SaveTableDamageCharacter();
        }
        /// <summary>
        /// сохраним xml-данные - CommentXml
        /// </summary>
        private void AppendChildCommentXml()
        {
            if (this.dataSetDamage.tJ_Damage.Rows[0]["idParent"] != DBNull.Value)
            {
                return;
            }
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
            XmlNode xmlNode = xmlDocument.SelectSingleNode("Doc");
            if (xmlNode == null)
            {
                xmlNode = xmlDocument.CreateElement("Doc");
                xmlDocument.AppendChild(xmlNode);
            }
            XmlNode xmlNode2 = xmlNode.SelectSingleNode("AbnOff");
            if (xmlNode2 != null)
            {
                xmlNode2.RemoveAll();
            }
            else
            {
                xmlNode2 = xmlDocument.CreateElement("AbnOff");
                xmlNode.AppendChild(xmlNode2);
            }
            foreach (object obj in this.dtSchmAbnFull.Rows)
            {
                DataRow dataRow = (DataRow)obj;
                if (dataRow.RowState != DataRowState.Deleted)
                {
                    XmlNode xmlNode3 = xmlDocument.CreateElement("Row");
                    xmlNode2.AppendChild(xmlNode3);
                    XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("idAbnObj");
                    xmlAttribute.Value = dataRow["idAbnObj"].ToString();
                    xmlNode3.Attributes.Append(xmlAttribute);
                }
            }
            this.AppendChildCountPoint(xmlNode2);
            this.AppendChildCountAbnObj(xmlNode2);
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
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.ColumnDamage.Name].Value != null)
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col2"] = this.dgvCharacterDamage.Rows[j].Cells[this.ColumnDamage.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col2"] = DBNull.Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.ColumnDamageExtended.Name].Value != null)
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col3"] = this.dgvCharacterDamage.Rows[j].Cells[this.ColumnDamageExtended.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col3"] = DBNull.Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.ColumnIdSchmObj.Name].Value != null)
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["idSchmObj"] = this.dgvCharacterDamage.Rows[j].Cells[this.ColumnIdSchmObj.Name].Value;
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
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.ColumnDamage.Name].Value != null)
                    {
                        dataRow["col2"] = this.dgvCharacterDamage.Rows[j].Cells[this.ColumnDamage.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.ColumnDamageExtended.Name].Value != null)
                    {
                        dataRow["col3"] = this.dgvCharacterDamage.Rows[j].Cells[this.ColumnDamageExtended.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.ColumnIdSchmObj.Name].Value != null)
                    {
                        dataRow["idSchmObj"] = this.dgvCharacterDamage.Rows[j].Cells[this.ColumnIdSchmObj.Name].Value;
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
                if (!base.UpdateSqlData(this.dataSetDamage.tJ_DamageLV))
                {
                    return false;
                }
                base.SelectSqlData(this.dataSetDamage.tJ_DamageLV, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
            }
            return true;
        }

        private int SaveDamageLocation()
        {
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
                return Convert.ToInt32(this.dataSetDamage.tMapObj.Rows[0]["idMap"]);
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
            return base.InsertSqlDataOneRow(this.dataSetDamage, this.dataSetDamage.tMapObj);
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
            DataTable dataTable = CreateReferenceTables.CreateTableKladrStreet();
            if (this.dataSetDamage.tMapObj.Rows.Count > 0)
            {
                base.SelectSqlData(dataTable, true, " where id = " + this.dataSetDamage.tMapObj.Rows[0]["Street"].ToString(), null, false, 0);
            }
            else if (this.dataSetDamage.tJ_Damage.Rows[0]["idStreet"] != DBNull.Value)
            {
                base.SelectSqlData(dataTable, true, " where id = " + this.dataSetDamage.tJ_Damage.Rows[0]["idStreet"].ToString(), null, false, 0);
            }
            int KladrObjId_ = 24;
            if (dataTable.Rows.Count > 0)
            {
                KladrObjId_ = Convert.ToInt32(dataTable.Rows[0]["KladrObjId"]);
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

        protected override void ApplyConfig(XmlDocument xmlDocument_0)
        {
            XmlNode xmlNode = xmlDocument_0.SelectSingleNode(base.Name);
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
                    DataTable dataTable = Reference.Tables.TableClassifier();
                    if (this.tableDamageCharacter != null)
                    {
                        DataRow[] array = this.tableDamageCharacter.Select("id = " + dataRow["id"].ToString());
                        if (array.Length != 0 && array[0]["col2"] != DBNull.Value)
                        {
                            base.SelectSqlData(dataTable, true, string.Format(" where (parentId = {0} and isGroup = 1 and Deleted = 0) or (id = {1}) order by parentKey", dataRow["col1"], array[0]["col2"]), null, false, 0);
                        }
                        else
                        {
                            base.SelectSqlData(dataTable, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", dataRow["col1"]), null, false, 0);
                        }
                    }
                    else
                    {
                        base.SelectSqlData(dataTable, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", dataRow["col1"]), null, false, 0);
                    }
                    DataGridViewComboBoxCell dataGridViewComboBoxCell = this.dgvCharacterDamage[this.ColumnDamage.Index, num] as DataGridViewComboBoxCell;
                    dataGridViewComboBoxCell.DataSource = dataTable;
                    dataGridViewComboBoxCell.DisplayMember = "name";
                    dataGridViewComboBoxCell.ValueMember = "id";
                }
                if (dataRow["col2"] != DBNull.Value)
                {
                    this.dgvCharacterDamage.CurrentCell = this.dgvCharacterDamage.Rows[num].Cells[this.ColumnTypeObj.Name];
                    this.dgvCharacterDamage.Rows[num].Cells[this.ColumnDamage.Name].Value = dataRow["col2"];
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
                    DataGridViewComboBoxCell dataGridViewComboBoxCell2 = this.dgvCharacterDamage[this.ColumnDamageExtended.Index, num] as DataGridViewComboBoxCell;
                    dataGridViewComboBoxCell2.DataSource = dataTable2;
                    dataGridViewComboBoxCell2.DisplayMember = "name";
                    dataGridViewComboBoxCell2.ValueMember = "id";
                }
                if (dataRow["col3"] != DBNull.Value)
                {
                    this.dgvCharacterDamage.Rows[num].Cells[this.ColumnDamageExtended.Name].Value = dataRow["col3"];
                }
                if (dataRow["idSchmObj"] != DBNull.Value)
                {
                    this.dgvCharacterDamage[this.ColumnIdSchmObj.Index, num].Value = dataRow["idSchmObj"];
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
            int typeDocument = this.TypeDocument;
            if (this.TypeDocumentParent != null)
            {
                typeDocument = this.TypeDocumentParent.Value;
            }
            this.ColumnSchmObj.Visible = (this.ColumnCabSection.Visible = (typeDocument == (int)eTypeDocuments.DamageHV || typeDocument == (int)eTypeDocuments.DefectHV));
            this.ColumnBtn.Visible = (typeDocument == (int)eTypeDocuments.DefectHV);
            DataGridViewBand dataGridViewBand = this.ColumnDamage;
            this.ColumnDamageExtended.Visible = true;
            dataGridViewBand.Visible = true;
            DataTable dataTable = Reference.Tables.TableClassifier();
            string text = "";
            if (this.tableDamageCharacter != null && this.tableDamageCharacter.Rows.Count > 0)
            {
                foreach (DataRow dataRow in this.tableDamageCharacter.Rows)
                {
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
            switch (typeDocument)
            {
                case (int)eTypeDocuments.DamageLV:
                case (int)eTypeDocuments.DefectLV:
                    if (string.IsNullOrEmpty(text))
                    {
                        base.SelectSqlData(dataTable, true, "where ParentId in (select id from \r\n  " +
                            "                       tr_classifier where ParentKey = ';ReportDaily;NatureDamage;LV;') \r\n " +
                            "                       and isGroup = 1 and deleted = 0 order by ParentKey", null, false, 0);

                    }
                    else
                        base.SelectSqlData(dataTable, true, string.Format("where (ParentId in (select id from  " +
                            "                            tr_classifier where ParentKey = ';ReportDaily;NatureDamage;LV;') " +
                            "                     and isGroup = 1 and deleted = 0) or " +
                            "                     (id in ({0})) order by ParentKey", text), null, false, 0);
                    break;
                case (int)eTypeDocuments.DefectHV:
                case (int)eTypeDocuments.DamageHV:
                    if (string.IsNullOrEmpty(text))
                    {
                        base.SelectSqlData(dataTable, true, "where ParentId in (select id from   " +
                            "                                       tr_classifier where ParentKey = ';ReportDaily;NatureDamage;HV;')  " +
                            "                                       and isGroup = 1 and deleted = 0 order by ParentKey", null, false, 0);
                    }
                    else
                    {
                        base.SelectSqlData(dataTable, true, string.Format("where (ParentId in (select id from  " +
                            "                                     tr_classifier where ParentKey = ';ReportDaily;NatureDamage;HV;') " +
                            "                                        and isGroup = 1 and deleted = 0) or " +
                            "                                        (id in ({0})) order by ParentKey", text), null, false, 0);
                    }
                    break;
                default:
                    if (typeDocument != (int)eTypeDocuments.DefectHV)
                    {
                        break; 
                    }
                    break;
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
                if ((this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.ColumnTypeObj.Index || this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.ColumnDamage.Index) && this.dgvCharacterDamage.CurrentCell.Value != null)
                {
                    DataTable dataTable = Reference.Tables.TableClassifier();
                    base.SelectSqlData(dataTable, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", this.dgvCharacterDamage.CurrentCell.Value), null, false, 0);
                    int columnIndex = (this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.ColumnTypeObj.Index) ? this.ColumnDamage.Index : ((this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.ColumnDamage.Index) ? this.ColumnDamageExtended.Index : -1);
                    DataGridViewComboBoxCell dataGridViewComboBoxCell = this.dgvCharacterDamage[columnIndex, this.dgvCharacterDamage.CurrentRow.Index] as DataGridViewComboBoxCell;
                    dataGridViewComboBoxCell.DataSource = dataTable;
                    dataGridViewComboBoxCell.DisplayMember = "name";
                    dataGridViewComboBoxCell.ValueMember = "id";
                    if (dataGridViewComboBoxCell.Value != null && dataTable.Select("id = " + dataGridViewComboBoxCell.Value.ToString()).Length == 0)
                    {
                        dataGridViewComboBoxCell.Value = null;
                    }
                    if (dataGridViewComboBoxCell.Value == null && dataGridViewComboBoxCell.ColumnIndex == this.ColumnDamage.Index)
                    {
                        DataGridViewComboBoxCell dataGridViewComboBoxCell2 = this.dgvCharacterDamage[this.ColumnDamageExtended.Index, this.dgvCharacterDamage.CurrentRow.Index] as DataGridViewComboBoxCell;
                        dataGridViewComboBoxCell2.DataSource = null;
                        dataGridViewComboBoxCell2.Value = null;
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
                    case ";ReportDaily;NatureDamage;HV;AirLine;":
                        listTypeObj.Add(547);//547
                        listTypeObj.Add(983);//983
                        listTypeObj.Add(548);//548
                        break;

                    case ";ReportDaily;NatureDamage;HV;CableLine;":
                        listTypeObj.Add(546);//546
                        listTypeObj.Add(548);//548
                        break;

                    case ";ReportDaily;NatureDamage;HV;Subs;":

                        listTypeObj.Add((int)SchmTypeSubstation.CP);//536
                        listTypeObj.Add((int)SchmTypeSubstation.PP);//535
                        listTypeObj.Add((int)SchmTypeSubstation.PP);//537
                        listTypeObj.Add((int)SchmTypeSubstation.SP);//1034
                        listTypeObj.Add((int)SchmTypeSubstation.TP);//538
                        listTypeObj.Add((int)SchmTypeSubstation.PPNO);//1275
                        break;
                }

                DataGridViewComboBoxCell dataGridViewComboBoxCell = this.dgvCharacterDamage[this.ColumnCabSection.Index, e.RowIndex] as DataGridViewComboBoxCell;
                if (!(dataTable.Rows[0]["ParentKey"].ToString() == ";ReportDaily;NatureDamage;HV;AirLine;") && !(dataTable.Rows[0]["ParentKey"].ToString() == ";ReportDaily;NatureDamage;HV;CableLine;"))
                {
                    FormSelectSchmObj form = new FormSelectSchmObj();
                    form.SqlSettings = this.SqlSettings;
                    form.SetCheckBoxes(false);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.GetDictionaryKey().Count > 0)
                        {
                            this.dgvCharacterDamage[this.ColumnIdSchmObj.Name, e.RowIndex].Value = form.GetDictionaryKey().First<KeyValuePair<int, string>>().Key;
                            this.dgvCharacterDamage[this.ColumnSchmObj.Name, e.RowIndex].Value = form.GetDictionaryKey().First<KeyValuePair<int, string>>().Value;
                        }
                        else
                        {
                            this.dgvCharacterDamage[this.ColumnIdSchmObj.Name, e.RowIndex].Value = DBNull.Value;
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
                    FormSelectLine form2 = new FormSelectLine(listTypeObj);
                    form2.SetVisiblePanel(false);
                    form2.SqlSettings = this.SqlSettings;
                    if (form2.ShowDialog() == DialogResult.OK)
                    {
                        this.dgvCharacterDamage[this.ColumnSchmObj.Name, e.RowIndex].Value = form2.GetObjectLine().Name;
                        this.dgvCharacterDamage[this.ColumnIdSchmObj.Name, e.RowIndex].Value = form2.GetObjectLine().Id;
                        DataTable dataTable2 = new DataTable("tP_CabSection");
                        dataTable2.Columns.Add("id", typeof(int));
                        dataTable2.Columns.Add("number", typeof(int));
                        base.SelectSqlData(dataTable2, true, "where idObjList = " + form2.GetObjectLine().Id.ToString() + " order by number", null, false, 0);
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
        /// <summary>
        /// блокировка контролов
        /// </summary>
        private void ControlBloking()
        {
            if (!this.GetFormViewMode() && (this.checkBoxApply.Checked || this.dataSetDamage.tJ_Damage.Rows[0]["idParent"] != DBNull.Value))
            {
                this.txtNumRequest.ReadOnly = true;
                this.dtpDateDoc.Enabled = false;
                this.cmbCompiler.ReadOnly = true;
                this.cmbDivision.ReadOnly = true;
                this.btnChoiceSchmObj.Enabled = false;
                ComboBoxReadOnly comboBoxReadOnly = this.cmbObl;
                ComboBoxReadOnly comboBoxReadOnly2 = this.cmbRaionObl;
                ComboBoxReadOnly comboBoxReadOnly3 = this.cmbCity;
                this.cmbStreet.ReadOnly = true;
                comboBoxReadOnly3.ReadOnly = true;
                comboBoxReadOnly2.ReadOnly = true;
                comboBoxReadOnly.ReadOnly = true;
                TextBoxBase textBoxBase = this.txtHouse;
                this.txtHousePrefix.ReadOnly = true;
                textBoxBase.ReadOnly = true;
                this.txtLocation.ReadOnly = true;
                this.cmbReason.ReadOnly = true;
                this.dgvCharacterDamage.ReadOnly = true;
                if (this.checkBoxApply.Checked)
                {
                    this.groupBoxResult.Enabled = false;
                }
                ToolStripItem toolStripItem = this.toolBtnRefreshAbn;
                this.toolBrnDelAbn.Enabled = false;
                toolStripItem.Enabled = false;
                this.toolBtn81.Enabled = false;
                this.toolBtnRefreshCountAbn.Enabled = false;
                UpDownBase upDownBase = this.numCountPointCat1;
                UpDownBase upDownBase2 = this.numCountPointCat1Full;
                UpDownBase upDownBase3 = this.numCountPointCat2;
                UpDownBase upDownBase4 = this.numCountPointCat2Full;
                UpDownBase upDownBase5 = this.numCountPointCat3;
                UpDownBase upDownBase6 = this.numCountPointEE;
                this.numCountPointSource.ReadOnly = true;
                upDownBase6.ReadOnly = true;
                upDownBase5.ReadOnly = true;
                upDownBase4.ReadOnly = true;
                upDownBase3.ReadOnly = true;
                upDownBase2.ReadOnly = true;
                upDownBase.ReadOnly = true;
                UpDownBase upDownBase7 = this.numCountAbnObjCat1;
                UpDownBase upDownBase8 = this.numCountAbnObjCat1Full;
                UpDownBase upDownBase9 = this.numCountAbnObjCat2;
                UpDownBase upDownBase10 = this.numCountAbnObjCat2Full;
                UpDownBase upDownBase11 = this.numCountAbnObjCat3;
                UpDownBase upDownBase12 = this.numCountAbnObjEE;
                this.numCountAbnObjSource.ReadOnly = true;
                upDownBase12.ReadOnly = true;
                upDownBase11.ReadOnly = true;
                upDownBase10.ReadOnly = true;
                upDownBase9.ReadOnly = true;
                upDownBase8.ReadOnly = true;
                upDownBase7.ReadOnly = true;
                UpDownBase upDownBase13 = this.numCountAbnObj150;
                UpDownBase upDownBase14 = this.numCountAbnObj150670;
                this.numCountAbnObj670.ReadOnly = true;
                upDownBase14.ReadOnly = true;
                upDownBase13.ReadOnly = true;
            }
        }

        private void cmbCompletedWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.TypeDocument == (int)eTypeDocuments.DefectLV && this.cmbCompletedWork.SelectedIndex >= 0)
            {
                this.labelCompletedWork.ForeColor = Color.Black;
            }
        }

        private void txtCompletedWork_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.TypeDocument == (int)eTypeDocuments.DefectHV && !string.IsNullOrEmpty(this.txtCompletedWork.Text))
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
                this.labelCompletedWork.ForeColor = Color.Black;
            }
        }

        private void btnShowDocParent_Click(object sender, EventArgs e)
        {
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0 && this.dataSetDamage.tJ_Damage.Rows[0]["idParent"] != DBNull.Value)
            {
                DataTable dataTable = new DataTable("tJ_Damage");
                dataTable.Columns.Add("TypeDoc", typeof(int));
                base.SelectSqlData(dataTable, true, "where id = " + this.dataSetDamage.tJ_Damage.Rows[0]["idParent"].ToString(), null, false, 0);
                if (dataTable.Rows.Count > 0)
                {
                    int TYpeDoc = Convert.ToInt32(dataTable.Rows[0]["TYpeDoc"]);
                    if (TYpeDoc == (int)eTypeDocuments.DamageLV)
                    {
                        DailyReportN.JournalDamage.FormDamageLVAddEdit form = new DailyReportN.JournalDamage.FormDamageLVAddEdit(Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idParent"]), eTypeDocuments.DamageLV);
                        form.SqlSettings = this.SqlSettings;
                        form.MdiParent = base.MdiParent;
                        form.SetFormViewMode(true);
                        form.Show();
                        return;
                    }
                    if (TYpeDoc != (int)eTypeDocuments.DamageHV)
                    {
                        return;
                    }
                    DailyReportN.JournalDamage.FormDamageHVAddEdit form2 = new DailyReportN.JournalDamage.FormDamageHVAddEdit(Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idParent"]));
                    form2.SqlSettings = this.SqlSettings;
                    form2.MdiParent = base.MdiParent;
                    form2.SetFormViewMode(true);
                    form2.Show();
                }
            }
        }

        private void cmbDivisionApply_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbDivisionApply.SelectedIndex >= 0)
            {
                this.labelDivisionApply.ForeColor = Color.Black;
                this.checkBoxLaboratory.ForeColor = Color.Black;
            }
            this.isChangedData = true;
        }

        private void checkBoxLaboratory_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxLaboratory.Checked)
            {
                this.labelDivisionApply.ForeColor = Color.Black;
                this.checkBoxLaboratory.ForeColor = Color.Black;
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

        private void toolBtn81_CheckedChanged(object sender, EventArgs e)
        {
            if (this.toolBtn81.Checked)
            {
                this.toolBtn81.ToolTipText = "Не использовать в бюллетене 8.1";
                this.toolBtn81.Image = global::DailyReportN.Properties.Resources.not81;
            }
            else
            {
                this.toolBtn81.ToolTipText = "Использовать в бюллетене 8.1";
                this.toolBtn81.Image = global::DailyReportN.Properties.Resources.in81;
            }
            this.isChangedData = true;
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
                labelProgress.Visible = true;
                this.toolBtnRefreshAbn.Enabled = false;
                this.btnChoiceSchmObj.Enabled = false;
                this.dgvAbn.Enabled = false;
                this.dgvAbn.DataSource = null;

                this.buttonSave.Enabled = false;
                buttonClose.Enabled = false;
                this.backgroundWorker1.RunWorkerAsync(this.dtpDateDoc.Value);
                return;
            }
            this.Table1.Clear();
            this.dtSchmAbnFull.Clear();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ElectricModel electricModel = new ElectricModel();
            electricModel.SqlSettings = this.SqlSettings;
            electricModel.LoadSchema(Convert.ToDateTime(e.Argument));
            electricModel.PoweringReportForDrawObject(Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"]), true);
            IEnumerable<ElectricObject> source = electricModel.Objects.Where(new Func<ElectricObject, bool>(this.getIdSchmObj));
            List<ElectricObject> listElectricObj = electricModel.PoweringReportForDrawObject(source.First<ElectricObject>(), true, true);
            DateTime dateDoc_ = DateTime.Now;
            if (this.dtpDateDoc.Value != null && this.dtpDateDoc.Value != DBNull.Value)
            {
                dateDoc_ = Convert.ToDateTime(this.dtpDateDoc.Value);
            }
            Reference.Tables.LoadTableSChmAbnFull(this.dtSchmAbnFull, this.SqlSettings, listElectricObj, dateDoc_);
            this.labelCountAbn.Text = "Количество абонентов: " + this.dtSchmAbnFull.DefaultView.ToTable(true, new string[]
            {
            "idAbn"
            }).Rows.Count.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            this.progressBar.Visible = false;
            labelProgress.Visible = false;
            this.toolBtnRefreshAbn.Enabled = true;
            this.dgvAbn.Enabled = true;
            this.dgvAbn.DataSource = this.bsSchmAbnFull;

            this.buttonSave.Enabled = true;
            buttonClose.Enabled = true;
            this.btnChoiceSchmObj.Enabled = true;
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
                    this.dgvAbn.Rows.Remove(dataGridViewRow);
                }
                this.CalculationCountPoints();
                this.CalculationCountConsumersAndMaximumPower();
            }
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
            if (this.dtSchmAbnFull.Rows.Count == 0)
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
            if (this.dtpDateDoc.Value != null)
            {
                if (this.dtpDateDoc.Value != DBNull.Value)
                {
                    string text = "";
                    foreach (DataRow dataRow in this.dtSchmAbnFull.Rows)
                    {
                        if (dataRow.RowState != DataRowState.Deleted)
                        {
                            if (string.IsNullOrEmpty(text))
                            {
                                text = dataRow["idAbnObj"].ToString();
                            }
                            else
                            {
                                text = text + "," + dataRow["idAbnObj"].ToString();
                            }
                        }
                    }
                    DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("select ao.id,\r\n                                        case when a.TypeAbn = 231 then -1 -- сетевая организация\r\n                                        else case when a.typeAbn = 206 and r.category is null then 493 -- если у физика нет категории - ставим ему третью\r\n                                        else case when category is null then 493 else r.category end end end as category\r\n                                     from tAbnObj ao \r\n\t                                    left join tAbn a on a.id = ao.idAbn\r\n\t                                    left join tAbnObjReg r on r.id = (select top 1 id from tAbnObjREg \r\n\t\t\t\t\t\t\t                where idAbnObj = ao.id\r\n\t\t\t\t\t\t\t                order by datechange desc)\r\n                                        left join tPoint p on p.idAbnObj = ao.id and p.dateBegin <= '{0}' and \r\n                                                                (p.dateEnd  >= '{0}' or p.dateEnd is null)\r\n\t                                    /*left join tPointReg pReg on pReg.id = (select top 1 id from tPointReg\r\n\t\t\t\t\t\t\t\t\t\t                                      where idPoint = p.id \r\n\t\t\t\t\t\t\t\t\t\t\t                        and dateBegin <= '{0}' and \r\n                                                                    (dateEnd  >= '{0}' or dateEnd is null)\r\n\t\t\t\t\t\t\t\t\t                                order by dateBegin desc)*/\r\n                                     where ao.id in ({1}) \r\n                                        and p.id is not null --and pREg.id is not null", Convert.ToDateTime(this.dtpDateDoc.Value).ToString("yyyyMMdd"), text));
                    this.numCountPointCat1.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category in (491,494)"));
                    this.numCountPointCat2.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = 492"));
                    this.numCountPointCat3.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = 493"));
                    this.numCountPointEE.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = -1"));
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
        private void LoadTotalCountPoint(DataTable dataTableDamage)
        {
            if (dataTableDamage.Rows.Count > 0 && dataTableDamage.Rows[0]["CommentXml"] != DBNull.Value)
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(dataTableDamage.Rows[0]["CommentXml"].ToString());
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

        private void numCountPointSource_ValueChanged(object sender, EventArgs e)
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
            if (this.dtSchmAbnFull.Rows.Count == 0)
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
            string text = "";
            foreach (DataRow dataRow in this.dtSchmAbnFull.Rows)
            {
                if (dataRow.RowState != DataRowState.Deleted)
                {
                    if (string.IsNullOrEmpty(text))
                    {
                        text = dataRow["idAbnObj"].ToString();
                    }
                    else
                    {
                        text = text + "," + dataRow["idAbnObj"].ToString();
                    }
                }
            }
            SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
            DataTable dataTable = sqlDataCommand.SelectSqlData("select ao.id,\r\n                                        case when a.TypeAbn = 231 then -1 -- сетевая организация\r\n                                        else case when a.typeAbn = 206 and r.category is null then 493 -- если у физика нет категории - ставим ему третью\r\n                                        else case when category is null then 493 else r.category end end end as category\r\n                                     from tAbnObj ao \r\n\t                                    left join tAbn a on a.id = ao.idAbn\r\n\t                                    left join tAbnObjReg r on r.id = (select top 1 id from tAbnObjREg \r\n\t\t\t\t\t\t\t                where idAbnObj = ao.id\r\n\t\t\t\t\t\t\t                order by datechange desc)\r\n                                     where ao.id in (" + text + ")");
            this.numCountAbnObjCat1.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category in (491,494)"));
            this.numCountAbnObjCat2.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = 492"));
            this.numCountAbnObjCat3.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = 493"));
            this.numCountAbnObjEE.Value = Convert.ToInt32(dataTable.Compute("count(id)", "category = -1"));
            dataTable = sqlDataCommand.SelectSqlData("select ao.id,\r\n                                         case when a.TypeAbn = 206 or r.PowerSEt is null then 15\r\n                                        \telse r.PowerSEt end PowerSEt\r\n                                     from tAbnObj ao \r\n\t                                    left join tAbn a on a.id = ao.idAbn\r\n\t                                    left join tAbnObjReg r on r.id = (select top 1 id from tAbnObjREg \r\n\t\t\t\t\t\t\t                where idAbnObj = ao.id\r\n\t\t\t\t\t\t\t                order by datechange desc)\r\n                                     where ao.id in (" + text + ")");
            this.numCountAbnObj150.Value = Convert.ToInt32(dataTable.Compute("count(id)", "PowerSet <= 150"));
            this.numCountAbnObj150670.Value = Convert.ToInt32(dataTable.Compute("count(id)", "PowerSet > 150 and PowerSet <= 670"));
            this.numCountAbnObj670.Value = Convert.ToInt32(dataTable.Compute("count(id)", "PowerSet > 670"));
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
        private void LoadTotalCountAbnObj(DataTable dataTableDamage)
        {
            if (dataTableDamage.Rows.Count > 0 && dataTableDamage.Rows[0]["CommentXml"] != DBNull.Value)
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(dataTableDamage.Rows[0]["CommentXml"].ToString());
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

        private void numCountAbnObjSource_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.labelCountAbnObj.Text = "Количество объектов: " + (this.numCountAbnObjCat1.Value + this.numCountAbnObjCat1Full.Value + this.numCountAbnObjCat2.Value + this.numCountAbnObjCat2Full.Value + this.numCountAbnObjCat3.Value + this.numCountAbnObjEE.Value + this.numCountAbnObjSource.Value).ToString();
        }
        [CompilerGenerated]
        private bool getIdSchmObj(ElectricObject obj)
        {
            return obj.Id == Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"]);
        }

    }
}