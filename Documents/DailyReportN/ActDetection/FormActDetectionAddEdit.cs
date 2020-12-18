using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using ControlsLbr.ReportViewerRus;
using DataSql;
//using Documents.Properties;
using FormLbr;
using Microsoft.Reporting.WinForms;
using Reference.Forms;
using SchemeModelN;
/// <summary>
/// Акт расследования
/// </summary>
namespace DailyReportN.JournalActDetection
{
    internal partial class FormActDetectionAddEdit : FormBase
    {
        /// <summary>
        /// Режим пропуска кода
        /// </summary>
        private bool isSkipFragment = true;
        private int? IdDocument;
        private int? IdParentDocument;
        private List<int> ListDamage;
        private bool isChangedData;
        private bool flagViewDoc;
        /// <summary>
        /// тип аварийного документа
        /// null - значит документа основания нет
        /// </summary>
        private int? TypeDocDamage = null;


        /// <summary>
        ///  вернуть режим просмотра документа
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
        internal int? GetIdDocument()
        {
            return this.IdDocument;
        }

        internal FormActDetectionAddEdit()
        {

            this.InitializeComponent();
            this.FillDateInitValues();
        }

        internal FormActDetectionAddEdit(int? id = null)
        {
            this.InitializeComponent();
            this.IdDocument = id;
            this.FillDateInitValues();
        }

        internal FormActDetectionAddEdit(int? idParent = null, List<int> listDamage = null)
        {
            this.InitializeComponent();
            this.FillDateInitValues();
            this.IdParentDocument = idParent;
            this.ListDamage = listDamage;
        }

        /// <summary>
        /// заполнение дат начальными значениями
        /// </summary>
        private void FillDateInitValues()
        {
            this.dtpDateDoc.Value = DateTime.Now;
            this.dtpApply.Value = DateTime.Now;
            this.dtpLastDateTest.Value = DateTime.Now;
            this.dtpTimeRecovery.Value = DateTime.Now;
            this.dtpLastDateTest.MaxDate = (DateTime)this.dtpTimeRecovery.Value;
        }

        private void FormActDetectionAddEdit_Load(object sender, EventArgs e)
        {
            //Library.Controls.ControlSelectionLengthComboBox(Controls); 

            this.InitTextBoxs();
            this.GetLinksCharacteristicsActDetection();
            //this.FillComboBoxWorker();
            this.FillComboBoxDivision();
            this.FillComboBoxKontragents();
            this.FillComboBoxSignCrash();
            this.FillComboBoxTypeEquipment();
            this.FillComboBoxReasonCrashEquipment();
            this.FillComboBoxReasonCrash();
            this.FillComboBoxStatusBeforeCrash();
            this.FillComboBoxStatusCurrentCrash();
            this.FillComboBoxIdNoCrashMeasure();
            this.FillComboBoxIdDefection();
            this.FillComboBoxIdNPA();
            this.FillComboBoxReasonBeginCrash();
            this.FillComboBoxClassifierDamage();
            this.FillComboBoxFault();
            this.InitComboBoxs();
            this.FillComboBoxVoltageLevels();
            if (this.IdDocument == null)
            {
                DataRow dataRow = this.dataSetDamage.tJ_Damage.NewRow();
                dataRow["TypeDoc"] = (int)eTypeDocuments.ActDetection;
                if (this.IdParentDocument != null)
                {
                    dataRow["idParent"] = this.IdParentDocument.Value;
                    this.GetSubstationByNetRegion(this.IdParentDocument.Value, dataRow);
                }
                this.dataSetDamage.tJ_Damage.Rows.Add(dataRow);
                this.InitNewDocumentActDetection();
                this.FillWithTableDamageCharacter(this.ListDamage);
                this.InitTableNoCrashMeasure();
                this.InitTableDefection();
            }
            else
            {
                base.SelectSqlData(this.dataSetDamage.tJ_Damage, true, " where id = " + this.IdDocument.Value.ToString(), null, false, 0);
                if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
                {
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["idParent"] != DBNull.Value)
                    {
                        this.IdParentDocument = new int?(Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idParent"]));
                    }
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["isApply"] != DBNull.Value && Convert.ToBoolean(this.dataSetDamage.tJ_Damage.Rows[0]["isApply"]))
                    {
                        this.cmbWorkerApply.ReadOnly = true;
                        this.dtpApply.Enabled = false;
                    }

                }
                base.SelectSqlData(this.dataSetDamage.tJ_DamageActDetection, true, " where idDamage = " + this.IdDocument.Value.ToString(), null, false, 0);
                if (this.dataSetDamage.tJ_DamageActDetection.Rows.Count == 0)
                {
                    this.InitNewDocumentActDetection();
                }
                else
                {
                    if (this.dataSetDamage.tJ_DamageActDetection.Rows[0]["NoCrashMeasure"] != DBNull.Value)
                    {
                        string NoCrashMeasure = this.dataSetDamage.tJ_DamageActDetection.Rows[0]["NoCrashMeasure"].ToString();
                        if (!string.IsNullOrEmpty(NoCrashMeasure))
                        {
                            this.dataTableNoCrashMeasure.ReadXml(new StringReader(NoCrashMeasure));
                        }
                    }
                    if (this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Defection"] != DBNull.Value)
                    {
                        string Defection = this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Defection"].ToString();
                        if (!string.IsNullOrEmpty(Defection))
                        {
                            this.dataTableDefection.ReadXml(new StringReader(Defection));
                        }
                    }
                }
                this.LoadTableDamageCharacter();
                this.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_DamageDoc, true, " where idDamage = " + this.IdDocument.ToString());
            }
            this.FillComboBoxWorker();

            tabControl1.Controls.Remove(tabPageSpecialOpinion);
            this.FillComboBoxsLastMemberComission();

            FillDateTableAdd("DataSet");

            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
            {
                if (this.dataSetDamage.tJ_Damage.Rows[0]["idParent"] != DBNull.Value)
                {
                    this.FillDateEndCrashLocal(Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idParent"]));
                }
                if (this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"] != DBNull.Value)
                {
                    this.txtSchmObj.Text = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                    {
                        this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"].ToString()
                    }).ToString();
                }
                //
                //TypeDocDamage = (int)this.dataSetDamage.tJ_Damage.Rows[0]["TypeDoc"];
            }
            if (string.IsNullOrEmpty(this.txtLengthOverload.Text))
            {
                this.txtLengthOverload.Text = "0";
            }
            this.FillOwnerDocument();
            //this.ControlSelectionLengthComboBox(base.Controls);
            Library.Controls.ControlSelectionLengthComboBox(Controls);
            this.isChangedData = false;
            // делаем заголовок документа
            if (this.IdDocument == null || this.IdDocument == -1)
                this.Text = "Новый:" + this.Text;
            else
                this.Text = this.Text + " №" + this.txtNumRequest.Text + " (авария №" + this.txtNumCrash.Text + ")" + " от " + this.dtpDateOwner.Value.ToShortDateString();
            //
            //tabControl1.Controls.IndexOf(tabPageSpecialOpinion);
            //tabControl1.Controls.Remove(tabPageSpecialOpinion);
        }

        private void FormActDetectionAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult != DialogResult.OK)
            {
                if (!this.isChangedData || this.GetFormViewMode() || MessageBox.Show("Сохранить внесенные изменения", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    base.DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            if (!this.CheckRequiredField())
            {
                MessageBox.Show("Введите обязательные поля для заполнения");
                base.DialogResult = DialogResult.None;
                e.Cancel = true;
                return;
            }
            if (this.SaveDocument())
            {
                base.DialogResult = DialogResult.OK;
                this.UpdateRepairDoc();
                return;
            }
            base.DialogResult = DialogResult.None;
            e.Cancel = true;
        }

        private void InitTextBoxs()
        {
            this.txtNumCrash.DataBindings.Clear();
            this.txtNumCrash.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.numCrash", true, DataSourceUpdateMode.OnPropertyChanged, ""));

            this.txtTotalComission.DataBindings.Clear();
            this.txtTotalComission.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.TotalComission", true, DataSourceUpdateMode.OnValidation, ""));
            this.dtpEndCrashLocal.Value = DateTime.Now;
            this.txtCountDefectEquipment.Enabled = true;

            this.txtPostChairman.Enabled = true;
            txtPostMemeber3.Enabled = true;

            this.txtPostMemeber2.Enabled = true;

            this.txtPostMemeber1.Enabled = true;

            this.txtOrder.Enabled = true;

            this.txtLengthOverload.DataBindings[0].NullValue = "0";
            foreach (object obj in this.tabControl1.TabPages)
            {
                ((TabPage)obj).Show();
            }
        }
        /// <summary>
        /// создание нового документа с начальными значениями
        /// </summary>
        private void InitNewDocumentActDetection()
        {
            DataRow dataRow = this.dataSetDamage.tJ_DamageActDetection.NewRow();
            dataRow["idDamage"] = -1;
            DataTable dataTable = this.CreateTableAbnType();
            base.SelectSqlData(dataTable, true, string.Format("where typeKontragent = {0} and deleted = 0 order by name", 1115), null, false, 0);
            if (dataTable.Rows.Count > 0)
            {
                dataRow["idOrg"] = dataTable.Rows[0]["idAbn"];
            }
            if (this.cmbSignCrash.DataSource != null && this.cmbSignCrash.DataSource is BindingSource && ((BindingSource)this.cmbSignCrash.DataSource).DataSource is DataTable)
            {
                DataRow[] array = ((DataTable)((BindingSource)this.cmbSignCrash.DataSource).DataSource).Select("Value = 2.3");
                if (array.Length != 0)
                {
                    dataRow["idSignCrash"] = array[0]["id"];
                }
            }
            if (this.cmbTypeEquipment.DataSource != null && this.cmbTypeEquipment.DataSource is BindingSource && ((BindingSource)this.cmbTypeEquipment.DataSource).DataSource is DataTable)
            {
                DataRow[] array2 = ((DataTable)((BindingSource)this.cmbTypeEquipment.DataSource).DataSource).Select("Value = 3.311");
                if (array2.Length != 0)
                {
                    dataRow["idTypeEquipment"] = array2[0]["id"];
                }
            }
            if (this.cmbReasonCrashEquipment.DataSource != null && this.cmbReasonCrashEquipment.DataSource is BindingSource && ((BindingSource)this.cmbReasonCrashEquipment.DataSource).DataSource is DataTable)
            {
                DataRow[] array3 = ((DataTable)((BindingSource)this.cmbReasonCrashEquipment.DataSource).DataSource).Select("Value = 4.12 and ParentKey = ';ReportDaily;ActDetection;ReasonCrashEquipment;'");
                if (array3.Length != 0)
                {
                    dataRow["idReasonCrashEquipment"] = array3[0]["id"];
                }
            }
            if (this.cmbReasonBeginCrash.DataSource != null && this.cmbReasonBeginCrash.DataSource is BindingSource && ((BindingSource)this.cmbReasonBeginCrash.DataSource).DataSource is DataTable)
            {
                DataRow[] array4 = ((DataTable)((BindingSource)this.cmbReasonBeginCrash.DataSource).DataSource).Select("Value = 4.12 and ParentKey = ';ReportDaily;ActDetection;ReasonBeginCrash;'");
                if (array4.Length != 0)
                {
                    dataRow["idReasonBeginCrash"] = array4[0]["id"];
                }
            }
            if (this.cmbStatusBeforeCrash.DataSource != null && this.cmbStatusBeforeCrash.DataSource is BindingSource && ((BindingSource)this.cmbStatusBeforeCrash.DataSource).DataSource is DataTable)
            {
                DataRow[] array5 = ((DataTable)((BindingSource)this.cmbStatusBeforeCrash.DataSource).DataSource).Select("Value = 2.01");
                if (array5.Length != 0)
                {
                    dataRow["idStatusBeforeCrash"] = array5[0]["id"];
                }
            }
            if (this.cmbStatusCurrentCrash.DataSource != null && this.cmbStatusCurrentCrash.DataSource is BindingSource && ((BindingSource)this.cmbStatusCurrentCrash.DataSource).DataSource is DataTable)
            {
                DataRow[] array6 = ((DataTable)((BindingSource)this.cmbStatusCurrentCrash.DataSource).DataSource).Select("Value = 2.201");
                if (array6.Length != 0)
                {
                    dataRow["idStatusCurrentCrash"] = array6[0]["id"];
                }
            }
            dataRow["idClassifierDamage"] = 2010;
            dataRow["idFault"] = 2020;
            this.dataSetDamage.tJ_DamageActDetection.Rows.Add(dataRow);
        }
        /// <summary>
        /// таблица противоаварийных мероприятий
        /// </summary>
        private void InitTableNoCrashMeasure()
        {
            DataRow dataRow = this.dataTableNoCrashMeasure.NewRow();
            dataRow["idNoCrashMeasure"] = 1963;
            DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("select idabn from vAbnType where typeKontragent = {0}", 1115));
            if (dataTable.Rows.Count > 0)
            {
                dataRow["idOrg"] = dataTable.Rows[0]["idabn"];
            }
            this.dataTableNoCrashMeasure.Rows.Add(dataRow);
        }
        /// <summary>
        /// таблица выявленных в ходе расследования нарушений требований
        /// </summary>
        private void InitTableDefection()
        {
            DataRow dataRow = this.dataTableDefection.NewRow();
            dataRow["idDefection"] = 1976;
            this.dataTableDefection.Rows.Add(dataRow);
        }
        /// <summary>
        /// Заполнить дату окончания (ликвидации) аварии, найти тип документа
        /// </summary>
        private void FillDateEndCrashLocal(int idParentDoc)
        {
            DataTable dataTable = new DataTable("vJ_Damage");
            dataTable.Columns.Add("numDoc", typeof(int));
            dataTable.Columns.Add("dateDoc", typeof(DateTime));
            dataTable.Columns.Add("typeDocName", typeof(string));
            dataTable.Columns.Add("nameDoc", typeof(string), "typedocname + isnull(' №' + convert(numDoc, System.String), ' №б/н') + isnull(' от ' + convert(dateDoc, System.String), '')");
            dataTable.Columns.Add("TypeDoc", typeof(int));
            dataTable.Columns.Add("dateApply", typeof(DateTime));
            base.SelectSqlData(dataTable, true, "where id = " + idParentDoc.ToString(), null, false, 0);
            if (dataTable.Rows.Count > 0)
            {
                this.txtParentDamage.Text = dataTable.Rows[0]["nameDoc"].ToString();
                this.TypeDocDamage = Convert.ToInt32(dataTable.Rows[0]["TypeDoc"]);
                //this.dtpDateDoc.Value = Convert.ToDateTime(dataTable.Rows[0]["DateDoc"].ToString());
                //this.dataSetDamage.tJ_Damage.Rows[0]["DateDoc"] = dataTable.Rows[0]["DateDoc"];
            }
            if (this.dataSetDamage.tJ_DamageActDetection.Rows.Count > 0)
            {
                //dtpDateDoc_ValueChanged(null, null);
                if (this.TypeDocDamage == (int)eTypeDocuments.DamageHV)
                {
                    DataTable dataTable2 = new DataTable("tj_DamageOn");
                    dataTable2.Columns.Add("DateOn", typeof(DateTime));
                    base.SelectSqlData(dataTable2, true, "where idDamage = " + idParentDoc.ToString() + " order by DateOn desc", null, false, 0);
                    if (dataTable2.Rows.Count > 0)
                    {
                        this.dataSetDamage.tJ_DamageActDetection.Rows[0]["dateEndCrashLocal"] = dataTable2.Rows[0]["dateOn"];
                        return;
                    }
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["dateEndCrashLocal"] = DBNull.Value;
                }
                else if (this.TypeDocDamage == (int)eTypeDocuments.DamageLV)
                {
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["dateEndCrashLocal"] = dataTable.Rows[0]["dateApply"];
                }
            }
        }
        /// <summary>
        /// заполнить автора документа
        /// </summary>
        private void FillOwnerDocument()
        {
            if (this.IdDocument == null)
            {
                DataTable dataTable = new DataTable("tUser");
                dataTable.Columns.Add("name", typeof(string));
                dataTable.Columns.Add("idWorker", typeof(string));
                base.SelectSqlData(dataTable, true, "where [login] = SYSTEM_USER", null, false, 0);
                if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["name"] != DBNull.Value)
                {
                    this.txtOwner.Text = dataTable.Rows[0]["name"].ToString();
                    return;
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
        /// <summary>
        /// получить принадлежность объекта схемы сетевому району
        /// (подразделение, точку схемы, дату документа)
        /// </summary>
        private void GetSubstationByNetRegion(int IdParentDoc, DataRow row)
        {
            DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData("select pSub.idNetRegion, d.dateDoc, d.idSchmObj  from vj_damage d\r\n                                        left join vP_SubstationByNetRegion pSub on pSub.id = d.idSub\r\n                                        where d.id = " + IdParentDoc.ToString());
            if (dataTable.Rows.Count > 0)
            {
                row["idDivision"] = dataTable.Rows[0]["idNetRegion"];
                row["dateDoc"] = dataTable.Rows[0]["dateDoc"];
                row["idSchmObj"] = dataTable.Rows[0]["idSChmObj"];
            }
        }

        private DataTable CreateTableWorkerGroup()
        {
            Type type = Type.GetType("System.Int32");
            DataTable dataTable = new DataTable("vWorkerGroup");
            DataColumn dataColumn = new DataColumn("id", type);
            dataTable.Columns.Add(dataColumn);
            DataColumn column = new DataColumn("fio", Type.GetType("System.String"));
            dataTable.Columns.Add(column);
            DataColumn column2 = new DataColumn("GroupElectrical", type);
            dataTable.Columns.Add(column2);
            dataTable.PrimaryKey = new DataColumn[]
            {
            dataColumn
            };
            DataColumn dataColumn2 = new DataColumn("GroupRoman", Type.GetType("System.String"));
            dataColumn2.Expression = "IIF(groupElectrical = 1, 'I', IIF(groupElectrical = 2, 'II', IIF(groupelectrical=3, 'III', IIF(groupelectrical = 4, 'IV', iif(groupelectrical = 5, 'V', '')))))";
            dataTable.Columns.Add(dataColumn2);
            DataColumn dataColumn3 = new DataColumn("fioGroup", Type.GetType("System.String"));
            dataColumn3.Expression = "fio + ' (' + GroupRoman + ')'";
            dataTable.Columns.Add(dataColumn3);
            return dataTable;
        }

        private DataTable CreateTableAbnType()
        {
            return new DataTable("vAbnType")
            {
                Columns =
            {
                {
                    "idAbn",
                    typeof(int)
                },
                {
                    "Name",
                    typeof(string)
                }
            }
            };
        }

        private void GetLinksCharacteristicsActDetection()
        {
            this.tblClassifier = Reference.Tables.TableClassifier(null);
            base.SelectSqlData(this.tblClassifier, true, string.Format(" where (ParentKey in ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}',  \r\n                                        '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{15}', \r\n                                         '{16}', '{17}', '{18}', '{19}', '{20}') or ParentKey like '{14}%')\r\n                and isgroup = 0 and deleted = 0", new object[]
            {
            ";NetworkAreas;",
            ";ReportDaily;ActDetection;SignCrash;",
            ";ReportDaily;ActDetection;TypeEquipment;",
            ";ReportDaily;ActDetection;ReasonCrashEquipment;",
            ";ReportDaily;ActDetection;ReasonCrash;",
            ";ReportDaily;ActDetection;StatusBeforeCrash;",
            ";ReportDaily;ActDetection;StatusCurrentCrash;",
            ";ReportDaily;ActDetection;Defection;",
            ";ReportDaily;ActDetection;NPA;",
            ";ReportDaily;ActDetection;ReasonBeginCrash;",
            ";ReportDaily;ActDetection;Damage;",
            ";ReportDaily;ActDetection;Fault;",
            ";ReportDaily;ActDetection;NoCrashMeasure;",
            ";ReportDaily;ActDetection;Equipment;Params;",
            ";VoltageLevels;",
            ";ReportDaily;ActDetection;Equipment;NodeDetail;",
            ";ReportDaily;ActDetection;Equipment;NeutralState;",
            ";ReportDaily;ActDetection;Equipment;Material;",
            ";ReportDaily;ActDetection;Equipment;ClauseWork;",
            ";ReportDaily;ActDetection;Equipment;ChrDamage;",
            ";ReportDaily;ActDetection;Equipment;ReasonDamage;"
            }), null, false, 0);
        }
        /// <summary>
        /// загрузка всех сотрудников, участвующие в расследовании
        /// </summary>
        private void FillComboBoxWorker(bool byChangeDate = false)
        {
            DataTable dataTable = this.CreateTableWorkerGroup();
            base.SelectSqlData(dataTable, true, string.Format("where ParentKey like ';GroupWorker;DailyReport;MemberActDetection;' and (dateEnd is null or dateEnd >= '{0}') order by fio ", dtpDateOwner.Value.ToString("yyyy-MM-dd")), null, false, 0);
            // исполнитель
            this.cmbCompiler.DisplayMember = "FIO";
            this.cmbCompiler.ValueMember = "id";
            this.cmbCompiler.DataSource = dataTable;
            this.cmbCompiler.SelectedIndex = -1;
            // утвердитель
            this.cmbWorkerApply.DisplayMember = "FIO";
            this.cmbWorkerApply.ValueMember = "id";
            this.cmbWorkerApply.DataSource = dataTable.Copy();
            this.cmbWorkerApply.SelectedIndex = -1;
            ////////////// председатель 
            this.cmbChairman.DisplayMember = "FIO";
            this.cmbChairman.ValueMember = "id";
            this.cmbChairman.DataSource = dataTable.Copy();
            this.cmbChairman.SelectedIndex = -1;
            //////////// комиссия
            this.cmbMemberComission1.DisplayMember = (this.cmbMemberComission2.DisplayMember = (this.cmbMemberComission3.DisplayMember = (this.cmbMemberComission4.DisplayMember = (this.cmbMemberComission5.DisplayMember = "FIO"))));
            this.cmbMemberComission1.ValueMember = (this.cmbMemberComission2.ValueMember = (this.cmbMemberComission3.ValueMember = (this.cmbMemberComission4.ValueMember = (this.cmbMemberComission5.ValueMember = "id"))));

            DataTable dataTable2 = dataTable.Copy();
            dataTable2.Columns["id"].AutoIncrement = true;
            dataTable2.Columns["id"].AutoIncrementSeed = -1L;
            dataTable2.Columns["id"].AutoIncrementStep = -1L;
            DataRow dataRow = dataTable2.NewRow();
            dataRow["FIO"] = "";
            dataRow.EndEdit();
            dataTable2.Rows.Add(dataRow);
            DataView defaultView = dataTable2.DefaultView;
            defaultView.Sort = "FIO asc";

            DataTable dataTable3 = defaultView.ToTable();

            this.cmbMemberComission1.DataSource = dataTable3.Copy();
            this.cmbMemberComission2.DataSource = dataTable3.Copy();
            this.cmbMemberComission3.DataSource = dataTable3.Copy();
            this.cmbMemberComission4.DataSource = dataTable3.Copy();
            this.cmbMemberComission5.DataSource = dataTable3.Copy();

            ListControl listControl = this.cmbMemberComission1;
            ListControl listControl2 = this.cmbMemberComission2;
            ListControl listControl3 = this.cmbMemberComission3;
            ListControl listControl4 = this.cmbMemberComission4;

            this.cmbMemberComission5.SelectedIndex = -1;
            listControl4.SelectedIndex = -1;
            listControl3.SelectedIndex = -1;
            listControl2.SelectedIndex = -1;
            listControl.SelectedIndex = -1;
        }

        private void FillComboBoxDivision()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';NetworkAreas;'";
            bindingSource.Sort = "name";
            this.cmbDivision.DisplayMember = "name";
            this.cmbDivision.ValueMember = "id";
            this.cmbDivision.DataSource = bindingSource;
            this.cmbDivision.SelectedIndex = -1;
        }

        private void FillComboBoxSignCrash()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;SignCrash;'";
            bindingSource.Sort = "value";
            this.cmbSignCrash.DisplayMember = "nameComment";
            this.cmbSignCrash.ValueMember = "id";
            this.cmbSignCrash.DataSource = bindingSource;
            this.cmbSignCrash.SelectedIndex = -1;
        }

        private void FillComboBoxTypeEquipment()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;TypeEquipment;'";
            bindingSource.Sort = "value";
            this.cmbTypeEquipment.DisplayMember = "nameComment";
            this.cmbTypeEquipment.ValueMember = "id";
            this.cmbTypeEquipment.DataSource = bindingSource;
            this.cmbTypeEquipment.SelectedIndex = -1;
        }

        private void FillComboBoxReasonCrashEquipment()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;ReasonCrashEquipment;'";
            bindingSource.Sort = "value";
            this.cmbReasonCrashEquipment.DisplayMember = "nameComment";
            this.cmbReasonCrashEquipment.ValueMember = "id";
            this.cmbReasonCrashEquipment.DataSource = bindingSource;
            this.cmbReasonCrashEquipment.SelectedIndex = -1;
        }

        private void FillComboBoxReasonCrash()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;ReasonCrash;'";
            bindingSource.Sort = "value";
            this.cmbReasonCrash.DisplayMember = "nameComment";
            this.cmbReasonCrash.ValueMember = "id";
            this.cmbReasonCrash.DataSource = bindingSource;
            this.cmbReasonCrash.SelectedIndex = -1;
        }

        private void FillComboBoxStatusBeforeCrash()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;StatusBeforeCrash;'";
            bindingSource.Sort = "value";
            this.cmbStatusBeforeCrash.DisplayMember = "nameComment";
            this.cmbStatusBeforeCrash.ValueMember = "id";
            this.cmbStatusBeforeCrash.DataSource = bindingSource;
            this.cmbStatusBeforeCrash.SelectedIndex = -1;
        }

        private void FillComboBoxStatusCurrentCrash()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;StatusCurrentCrash;'";
            bindingSource.Sort = "value";
            this.cmbStatusCurrentCrash.DisplayMember = "nameComment";
            this.cmbStatusCurrentCrash.ValueMember = "id";
            this.cmbStatusCurrentCrash.DataSource = bindingSource;
            this.cmbStatusCurrentCrash.SelectedIndex = -1;
        }

        private void FillComboBoxIdNoCrashMeasure()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;NoCrashMeasure;'";
            bindingSource.Sort = "value";
            this.idNoCrashMeasureColumn.DisplayMember = "name";
            this.idNoCrashMeasureColumn.ValueMember = "id";
            this.idNoCrashMeasureColumn.DataSource = bindingSource;
        }

        private void FillComboBoxIdDefection()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;Defection;'";
            bindingSource.Sort = "value";
            this.idDefectionDataGridViewTextBoxColumn.DisplayMember = "comment";
            this.idDefectionDataGridViewTextBoxColumn.ValueMember = "id";
            this.idDefectionDataGridViewTextBoxColumn.DataSource = bindingSource;
        }

        private void FillComboBoxIdNPA()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;NPA;'";
            bindingSource.Sort = "value";
            this.idNPADgvColumn.DisplayMember = "name";
            this.idNPADgvColumn.ValueMember = "id";
            this.idNPADgvColumn.DataSource = bindingSource;
        }

        private void FillComboBoxReasonBeginCrash()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;ReasonBeginCrash;'";
            bindingSource.Sort = "value";
            this.cmbReasonBeginCrash.DisplayMember = "comment";
            this.cmbReasonBeginCrash.ValueMember = "id";
            this.cmbReasonBeginCrash.DataSource = bindingSource;
        }

        private void FillComboBoxClassifierDamage()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;Damage;'";
            bindingSource.Sort = "value";
            this.cmbClassifierDamage.DisplayMember = "name";
            this.cmbClassifierDamage.ValueMember = "id";
            this.cmbClassifierDamage.DataSource = bindingSource;
        }

        private void FillComboBoxFault()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;Fault;'";
            bindingSource.Sort = "value";
            this.cmbFault.DisplayMember = "name";
            this.cmbFault.ValueMember = "id";
            this.cmbFault.DataSource = bindingSource;
        }

        private void FillComboBoxKontragents()
        {
            DataTable dataTable = this.CreateTableAbnType();
            base.SelectSqlData(dataTable, true, string.Format("where typeKontragent = {0} and deleted = 0 order by name", 1877), null, false, 0);
            this.cmbOrg.DisplayMember = "name";
            this.cmbOrg.ValueMember = "idAbn";
            this.cmbOrg.DataSource = dataTable;
            this.cmbOrg.SelectedIndex = -1;

            this.idOrgColumn.DisplayMember = "name";
            this.idOrgColumn.ValueMember = "idAbn";
            this.idOrgColumn.DataSource = dataTable.Copy();

            this.idOrgDefectionDgvColumn.DisplayMember = "name";
            this.idOrgDefectionDgvColumn.ValueMember = "idAbn";
            this.idOrgDefectionDgvColumn.DataSource = dataTable.Copy();

            this.cmbOrgCrashEq.DisplayMember = "name";
            this.cmbOrgCrashEq.ValueMember = "idAbn";
            this.cmbOrgCrashEq.DataSource = dataTable.Copy();
            this.cmbOrgCrashEq.SelectedIndex = -1;

            this.cmbOrgCrash.DisplayMember = "name";
            this.cmbOrgCrash.ValueMember = "idAbn";
            this.cmbOrgCrash.DataSource = dataTable.Copy();
            this.cmbOrgCrash.SelectedIndex = -1;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        /// <summary>
        /// проверка заполнения обязательных полей
        /// </summary>
        private bool CheckRequiredField()
        {
            bool result = true;
            if (this.chkCrash.Checked)
            {
                if (string.IsNullOrEmpty(this.txtNumCrash.Text))
                {
                    result = false;
                    this.labelNumCrash.ForeColor = Color.Red;
                }
                if (new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("select a.numCrash from tJ_DamageActDetection a\r\n                                            left join tj_damage d on d.id = a.idDamage\r\n                                            where a.numCrash = '{0}' and year(d.DateDoc) = {1} and d.id <> {2}", this.txtNumCrash.Text, this.dtpDateOwner.Value.Year, (this.GetIdDocument() == null) ? -1 : this.GetIdDocument().Value)).Rows.Count > 0)
                {
                    result = false;
                    this.labelNumCrash.ForeColor = Color.Red;
                }
            }
            return result;
        }

        private bool SaveDocument()
        {
            this.dataSetDamage.tJ_Damage.Rows[0].EndEdit();
            if (this.IdDocument == null)
            {
                this.IdDocument = new int?(base.InsertSqlDataOneRow(this.dataSetDamage, this.dataSetDamage.tJ_Damage));
                if (this.IdDocument == -1)
                {
                    this.IdDocument = null;
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
        /// сохранение дополнительных характеристик
        /// </summary>
        /// <returns></returns>
        private bool SaveTableDamageAddCharacter()
        {
            if (this.dataSetDamage.tJ_DamageActDetection.Rows.Count > 0)
            {
                this.dataSetDamage.tJ_DamageActDetection.Rows[0]["idDamage"] = this.IdDocument.Value;
                if (this.dataTableNoCrashMeasure.Rows.Count == 0)
                {
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["NoCrashMeasure"] = DBNull.Value;
                }
                else
                {
                    StringWriter stringWriter = new StringWriter();
                    this.dataTableNoCrashMeasure.WriteXml(stringWriter, XmlWriteMode.WriteSchema, false);
                    string value = stringWriter.ToString();
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["NoCrashMeasure"] = value;
                }
                if (this.dataTableDefection.Rows.Count == 0)
                {
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Defection"] = DBNull.Value;
                }
                else
                {
                    StringWriter stringWriter2 = new StringWriter();
                    this.dataTableDefection.WriteXml(stringWriter2, XmlWriteMode.WriteSchema, false);
                    string value2 = stringWriter2.ToString();
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Defection"] = value2;
                }

                if (this.dataTableComission.Rows.Count == 0)
                {
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Comission"] = DBNull.Value;
                }
                else
                {
                    StringWriter stringWriter3 = new StringWriter();
                    this.dataTableComission.WriteXml(stringWriter3, XmlWriteMode.WriteSchema, false);
                    string value3 = stringWriter3.ToString();
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Comission"] = value3;
                }
                /********************************************************************/
                //if (this.dataTableAnnex.Rows.Count == 0)
                //{
                //    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Annex"] = DBNull.Value;
                //}
                //else
                //{
                //    StringWriter stringWriter3 = new StringWriter();
                //    this.dataTableAnnex.WriteXml(stringWriter3, XmlWriteMode.WriteSchema, false);
                //    string value3 = stringWriter3.ToString();
                //    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Annex"] = value3;
                //}
                /************************************************************************/

                if (this.dataSetCrash.Tables.Count == 0)
                {
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["DataSet"] = DBNull.Value;
                }
                else
                {
                    StringWriter stringWriterDS = new StringWriter();
                    this.dataSetCrash.WriteXml(stringWriterDS, XmlWriteMode.WriteSchema);
                    string valueDS = stringWriterDS.ToString();
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["DataSet"] = valueDS;
                }
                /************************************************************************/

                this.dataSetDamage.tJ_DamageActDetection.Rows[0].EndEdit();
                if (!base.InsertSqlData(this.dataSetDamage.tJ_DamageActDetection))
                {
                    return false;
                }
                if (!base.UpdateSqlData(this.dataSetDamage.tJ_DamageActDetection))
                {
                    return false;
                }
                //LibraryTSQL.SqlDataCommand cTSQL = new LibraryTSQL.SqlDataCommand(SqlSettings);
                //DataTable tbl = cTSQL.SelectSqlData("tJ_DamageActDetection", true, "where idDamage = " + this.IdDocument.Value.ToString());
                //tbl.AsEnumerable().CopyToDataTable(this.dataSetDamage.tJ_DamageActDetection, LoadOption.OverwriteChanges);
                // cTSQL.SelectSqlData(this.dataSetDamage.tJ_DamageActDetection, true, "where idDamage = " + this.IdDocument.Value.ToString());
                // так было 
                this.SelectSqlData(this.dataSetDamage.tJ_DamageActDetection, true, "where idDamage = " + this.IdDocument.Value.ToString());

            }
            return true;
        }
        /// <summary>
        ///  сохранение характеристик повреждений
        /// </summary>
        /// <returns></returns>
        private bool SaveTableDamageCharacter()
        {

            this.DeleteSqlDataWhere(this.dataSetDamage.tJ_DamageCharacter, string.Format(" WHERE idDamage = {0}", this.IdDocument.ToString()));
            try
            {
                foreach (DataRow dataRow in this.dataSetDamage.tJ_DamageCharacter.Rows)
                {
                    if (dataRow.RowState != DataRowState.Deleted)
                    {
                        dataRow["idDamage"] = this.IdDocument.Value;
                        dataRow.EndEdit();
                    }
                    this.InsertSqlDataOneRow(dataRow);
                }
                this.dataSetDamage.tJ_DamageCharacter.AcceptChanges();
                return true;
            }
            catch
            {
                return false;
            }
            //return base.InsertSqlData(this.dataSetDamage.tJ_DamageCharacter) && base.UpdateSqlData(this.dataSetDamage.tJ_DamageCharacter) && base.DeleteSqlData(this.dataSetDamage.tJ_DamageCharacter);
        }

        private void btnChooseParentDamage_Click(object sender, EventArgs e)
        {
            FormSelectDamage form = new FormSelectDamage();
            form.SqlSettings = this.SqlSettings;
            if (form.ShowDialog() == DialogResult.OK)
            {
                int idParentDocument = form.GetIdDocument().Value;
                //TypeDocDamage = form.TypeDamage;
                List<int> listCharacterParent = new List<int>();
                FormChooseDamageCharacter form2 = new FormChooseDamageCharacter(new int?(idParentDocument), listCharacterParent, this.IdDocument);
                form2.SqlSettings = this.SqlSettings;
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    while (this.dgvEquipment.Rows.Count > 0)
                    {
                        this.dgvEquipment.Rows.RemoveAt(0);
                    }
                    this.IdParentDocument = new int?(idParentDocument);
                    this.FillWithTableDamageCharacter(form2.getListDamage());
                    this.dataSetDamage.tJ_Damage.Rows[0]["idParent"] = idParentDocument;
                    // this.FillDateEndCrashLocal(_idParentDocument);
                }
                this.FillDateEndCrashLocal(idParentDocument);
            }
        }

        private void btnOpenParentDamage_Click(object sender, EventArgs e)
        {
            if (this.IdParentDocument == null)
            {
                return;
            }
            DataTable dataTable = base.SelectSqlData("tJ_Damage", true, "where id = " + this.IdParentDocument.ToString());
            if (dataTable.Rows.Count == 0)
            {
                return;
            }
            this.OpenDokument(Convert.ToInt32(dataTable.Rows[0]["typeDoc"]), Convert.ToInt32(this.IdParentDocument), Convert.ToDateTime(dataTable.Rows[0]["dateDoc"]));
        }

        private void OpenDokument(int TypeDoc, int idDoc = -1, DateTime DateDoc = default(DateTime))
        {
            bool isNewVersionDoc = VersionDocDamage.isNew(this.SqlSettings, idDoc, DateDoc);
            switch (TypeDoc)
            {
                case (int)eTypeDocuments.DamageLV:
                    {
                        if (isNewVersionDoc == false)
                        {
                            DailyReport.JournalDamage.FormDamageLVAddEdit formLV = new DailyReport.JournalDamage.FormDamageLVAddEdit(idDoc, TypeDoc);
                            formLV.SqlSettings = this.SqlSettings;
                            formLV.MdiParent = base.MdiParent;
                            formLV.FormViewMode(true);
                            formLV.Show();
                        }
                        else
                        {
                            DailyReportN.JournalDamage.FormDamageLVAddEdit form = new DailyReportN.JournalDamage.FormDamageLVAddEdit(idDoc);
                            form.SqlSettings = this.SqlSettings;
                            form.MdiParent = base.MdiParent;
                            form.SetFormViewMode(true);
                            form.Show();
                        }
                        break;
                    }
                case (int)eTypeDocuments.DamageHV:
                    {
                        if (isNewVersionDoc == false)
                        {
                            DailyReport.JournalDamage.FormDamageHVAddEdit formHV = new DailyReport.JournalDamage.FormDamageHVAddEdit(idDoc);
                            formHV.SqlSettings = this.SqlSettings;
                            formHV.MdiParent = base.MdiParent;
                            formHV.FormViewMode(true);
                            formHV.Show();
                        }
                        else
                        {
                            DailyReportN.JournalDamage.FormDamageHVAddEdit form2 = new DailyReportN.JournalDamage.FormDamageHVAddEdit(idDoc);
                            form2.SqlSettings = this.SqlSettings;
                            form2.MdiParent = base.MdiParent;
                            form2.SetFormViewMode(true);
                            form2.Show();
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        private void chkCrash_CheckedChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.chkCrash.Checked)
            {
                this.txtNumCrash.Enabled = true;
                if (string.IsNullOrEmpty(this.txtNumCrash.Text))
                {
                    DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("select a.numCrash from tJ_DamageActDetection a\r\n                                            left join tj_damage d on d.id = a.idDamage\r\n                                            where isnumeric(a.numCrash) = 1 and year(d.DateDoc) = {0}\r\n                                            order by cast(a.numCrash as int) desc", this.dtpDateOwner.Value.Year));
                    if (dataTable.Rows.Count > 0)
                    {
                        this.txtNumCrash.Text = (Convert.ToInt32(dataTable.Rows[0]["numCrash"]) + 1).ToString();
                        return;
                    }
                    this.txtNumCrash.Text = "1";
                    return;
                }
            }
            else
            {
                this.txtNumCrash.Enabled = false;
                this.txtNumCrash.Text = "";
            }
        }

        private void txtNumCrash_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (!string.IsNullOrEmpty(this.txtNumCrash.Text))
            {
                this.labelNumCrash.ForeColor = Color.Black;
            }
        }

        private void dtpEndCrashLocal_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;

            if (this.dtpEndCrashLocal.Value != null)
            {
                if (this.dtpEndCrashLocal.Value != DBNull.Value)
                {
                    this.dtpEndCrashMoscow.Value = Convert.ToDateTime(this.dtpEndCrashLocal.Value).AddHours(3.0).AddHours(-TimeZoneInfo.Local.BaseUtcOffset.TotalHours);
                    return;
                }
            }
            this.dtpEndCrashMoscow.Value = DBNull.Value;

        }
        /// <summary>
        /// установить дату начала аварии по московскому веремени
        /// </summary>
        private void SetBeginCrashMoscow()
        {
            this.isChangedData = true;
            if (this.dtpDateDoc.Value != null)
            {
                if (this.dtpDateDoc.Value != DBNull.Value)
                {
                    this.dtpBeginCrashMoscow.Value = Convert.ToDateTime(this.dtpDateDoc.Value).AddHours(3.0).AddHours(-TimeZoneInfo.Local.BaseUtcOffset.TotalHours);
                    return;
                }
            }
            this.dtpBeginCrashMoscow.Value = DBNull.Value;
        }
        private void dtpDateDoc_ValueChanged(object sender, EventArgs e)
        {
            SetBeginCrashMoscow();
        }

        private void dgvNoCrashMeasure_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                ((ComboBox)e.Control).DropDownStyle = ComboBoxStyle.DropDown;
                ((ComboBox)e.Control).AutoCompleteSource = AutoCompleteSource.ListItems;
                ((ComboBox)e.Control).AutoCompleteMode = AutoCompleteMode.Suggest;
                ((ComboBox)e.Control).DropDown -= new EventHandler(this.cmb_DropDown);
                ((ComboBox)e.Control).DropDown += new EventHandler(this.cmb_DropDown);
            }
            if (((DataGridView)sender).CurrentCell != null && ((DataGridView)sender).Columns[((DataGridView)sender).CurrentCell.ColumnIndex] == this.dateCompleteDataGridViewTextBoxColumn && e.Control is DateTimePicker)
            {
                ((DateTimePicker)e.Control).Format = DateTimePickerFormat.Custom;
                ((DateTimePicker)e.Control).CustomFormat = "MMMM.yyyy";
                if (((DataGridView)sender).CurrentCell.Value == DBNull.Value)
                {
                    ((DataGridView)sender).CurrentCell.Value = ((DateTimePicker)e.Control).Value;
                }
            }
        }

        private void cmb_DropDown(object sender, EventArgs e)
        {
            ((ComboBox)sender).DropDownWidth = 500;
        }

        private void dgvNoCrashMeasure_MouseClick(object sender, MouseEventArgs e)
        {
            if (((DataGridView)sender).HitTest(e.X, e.Y).Type == DataGridViewHitTestType.RowHeader)
            {
                ((DataGridView)sender).EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                ((DataGridView)sender).EndEdit();
                return;
            }
            ((DataGridView)sender).EditMode = DataGridViewEditMode.EditOnEnter;
        }

        /// <summary>
        /// загрузка таблицы повреждений
        /// </summary>
        private void LoadTableDamageCharacter()
        {
            if (this.IdDocument != null)
            {
                base.SelectSqlData(this.dataSetDamage.tJ_DamageCharacter, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
            }
        }
        /// <summary>
        /// начальное заполнение выпадающих списков
        /// </summary>
        private void InitComboBoxs()
        {
            this.FillComboBoxDgvTypeEquipment();
            this.FillComboBoxParameters();
            this.FillComboBoxVoltageSeti();
            this.FillComboBoxNodeDetail();
            this.FillComboBoxNeutraState();
            this.FillComboBoxMaterial();
            this.FillComboBoxClauseWork();
            this.FillComboBoxCharacterDamage();
            this.FillComboBoxReasonDamage();
        }

        private void FillComboBoxDgvTypeEquipment()
        {
            DataTable dataTable = Reference.Tables.TableClassifier(null);
            base.SelectSqlData(dataTable, true, "where ParentId in (select id from  tr_classifier where ParentKey = ';ReportDaily;NatureDamage;HV;' or ParentKey = ';ReportDaily;NatureDamage;LV;')  and isGroup = 1 and deleted = 0 order by ParentKey", null, false, 0);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            bindingSource.Position = -1;
            this.typeEquipmentDgvColumn.DisplayMember = "name";
            this.typeEquipmentDgvColumn.ValueMember = "id";
            this.typeEquipmentDgvColumn.DataSource = bindingSource;
        }

        private void toolBtnAddEquipment_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (DataRow dataRow in this.dataSetDamage.tJ_DamageCharacter)
            {
                if (dataRow.RowState != DataRowState.Deleted && dataRow["idCharacterParent"] != DBNull.Value)
                {
                    list.Add(Convert.ToInt32(dataRow["idCharacterParent"]));
                }
            }
            FormChooseDamageCharacter form = new FormChooseDamageCharacter(this.IdParentDocument, list, this.IdDocument);
            form.SqlSettings = this.SqlSettings;
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.FillWithTableDamageCharacter(form.getListDamage());
            }
        }
        /// <summary>
        /// дозаполнение таблицы поврежденого оборудования
        /// </summary>
        private void FillWithTableDamageCharacter(IEnumerable<int> listDamage)
        {
            this.dataSetDamage.tJ_DamageCharacter.Clear();
            if (listDamage != null && listDamage.Count<int>() > 0)
            {
                this.txtYearManufature.TextChanged -= new EventHandler(this.txtYearManufature_TextChanged);
                string text = "";
                foreach (int num in listDamage)
                {
                    if (string.IsNullOrEmpty(text))
                    {
                        text = num.ToString();
                    }
                    else
                    {
                        text = text + "," + num.ToString();
                    }
                }
                DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable table = new DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable();
                base.SelectSqlData(table, true, "where id in (" + text + ")", null, false, 0);

                CreateActDetection actD = new CreateActDetection();
                actD.Sqlsettings = SqlSettings;
                actD.tJ_DamageCharacter = table;
                actD.tJ_Damage = this.dataSetDamage.tJ_Damage;

                // получим родительский документ
                System.Data.DataTable tableVoltageDamage = new SqlDataCommand(SqlSettings).SelectSqlData("SELECT  Case TypeDoc when 1401 then 0.4 when 1402 then tJ_DamageHV.PowerV end Voltage FROM  tJ_Damage LEFT JOIN  tJ_DamageHV ON tJ_Damage.id = tJ_DamageHV.idDamage where id = " + IdParentDocument.ToString());
                // получим уровень напряжения документа (хрень - маленькое облегчение пользователю)
                object idVoltageDamage = actD.GetVoltageLevels().AsEnumerable()
                    .Select(s => new { id = s["id"], Value = (decimal)s["Value"] })
                    .Where(t => t.Value == (decimal)tableVoltageDamage.Rows[0]["Voltage"])
                    .First().id;


                foreach (DataRow dataRow in table.Rows)
                {
                    DataRow dataRow2 = this.dataSetDamage.tJ_DamageCharacter.NewRow();
                    dataRow2["idDamage"] = ((this.IdDocument == null) ? -1 : this.IdDocument.Value);
                    dataRow2["col1"] = dataRow["col1"];
                    dataRow2["idSchmObj"] = dataRow["idSchmObj"];
                    dataRow2["idLineSection"] = dataRow["idLineSection"];
                    // dataRow2["idParameters"] = 2026;
                    dataRow2["idCharacterParent"] = dataRow["id"];
                    dataRow2["lengthOverLoad"] = 0;
                    dataRow2["idNeutralState"] = 2037;
                    dataRow2["nodeDetail"] = 2032;
                    if (dataRow2["idSchmObj"] != DBNull.Value)
                    {
                        // длина трассы
                        //decimal LengthLine = 0;
                        //// (!string.IsNullOrEmpty(LengthLine.ToString()))
                        //if (decimal.TryParse(actD.GetLengthLine(Convert.ToInt32(dataRow2["idSChmObj"])).ToString(), out LengthLine))
                        //{
                        //    dataRow2["LengthLine"] = LengthLine;
                        //}
                        dataRow2["LengthLine"] = actD.GetLengthLine(Convert.ToInt32(dataRow2["idSChmObj"]));
                        // марка кабеля  (тип оборудования)
                        object idMark = actD.GetIdMark(Convert.ToInt32(dataRow2["idSChmObj"]));
                        this.FillComboBoxMarkEquipment();
                        if (idMark != null)
                        {
                            dataRow2["idMark"] = idMark;
                            this.cmbMarkEquipment.SelectedValue = idMark;
                        }
                        // Параметры (cmbParameters)
                        object idParameters = actD.GetParameterLayingCable(Convert.ToInt32(dataRow2["idSChmObj"]));
                        if (idParameters != null)
                        {
                            dataRow2["idParameters"] = idParameters;
                            //this.cmbParameters.SelectedValue = idParameters;
                        }
                        
                        // напряжение сети (конструкторское)
                        object idVoltage = actD.GetValueVoltage(Convert.ToInt32(dataRow2["idSChmObj"]));
                        if (idVoltage != DBNull.Value && idVoltage.ToString() != string.Empty && this.cmbVoltage.DataSource != null && this.cmbVoltage.DataSource is BindingSource && ((BindingSource)this.cmbVoltage.DataSource).DataSource is DataTable)
                        {
                            DataRow[] array = ((DataTable)((BindingSource)this.cmbVoltage.DataSource).DataSource).Select("Value = '" + idVoltage.ToString() + "' and ParentKey like ';VoltageLevels;%'");
                            if (array.Length != 0)
                                dataRow2["idVoltage"] = array[0]["id"];
                        }
                        else
                            dataRow2["idVoltage"] = idVoltageDamage;
                        // рабочее напряжение сети
                        object idVoltageSeti = actD.GetValueVoltageSeti(Convert.ToInt32(dataRow2["idSChmObj"]));
                        if (idVoltageSeti != DBNull.Value && idVoltageSeti.ToString() != string.Empty && this.cmbVoltageSeti.DataSource != null && this.cmbVoltageSeti.DataSource is BindingSource && ((BindingSource)this.cmbVoltageSeti.DataSource).DataSource is DataTable)
                        {
                            DataRow[] array2 = ((DataTable)((BindingSource)this.cmbVoltageSeti.DataSource).DataSource).Select("Value = " + idVoltageSeti.ToString().Replace(',', '.') + " and ParentKey like ';VoltageLevels;%'");
                            if (array2.Length != 0)
                                dataRow2["idVoltageSeti"] = array2[0]["id"];
                        }
                        else
                            dataRow2["idVoltageSeti"] = idVoltageDamage;
                        // Изготовитель - Manufacturer
                        dataRow2["Manufacturer"] = actD.GetManufacture(Convert.ToInt32(dataRow2["idSChmObj"]));
                        // год изготовления
                        string YearManufacture = Convert.ToString(actD.GetYearManufacture(Convert.ToInt32(dataRow2["idSChmObj"])));
                        YearManufacture = YearManufacture == "" || YearManufacture == null  ? "0" : YearManufacture;
                        dataRow2["YearManufacture"] = YearManufacture;
                        // заводской номер FactoryNumber
                        dataRow2["FactoryNumber"] = actD.GetFactoryNumber(Convert.ToInt32(dataRow2["idSChmObj"]));
                        // начало эксплуатации
                        object YearBegEquipment = actD.GetYearBegEquipment(Convert.ToInt32(dataRow2["idSChmObj"]));
                        DateTime dateTime;
                        if (DateTime.TryParse(YearBegEquipment.ToString(), out dateTime))
                        {
                            dataRow2["YearBegEquipment"] = dateTime.ToString("yyyy");
                        }
                        else
                        {
                            dataRow2["YearBegEquipment"] = ((YearBegEquipment.ToString() == string.Empty) ? DBNull.Value : YearBegEquipment);
                        }
                        // последняя дата испытаний
                        dataRow2["LastDateTest"] = actD.GetLastDateTest(Convert.ToInt32(dataRow2["idSChmObj"]));
                        // дата восстановления
                        dataRow2["timeRecovery"] = actD.GetTimeRecovery(Convert.ToInt32(dataRow2["idSChmObj"]));
                        // срок эксплуатации узла - LengthWorkEquipment
                        // не нужен
                    }
                    else
                    {
                        dataRow2["idVoltage"] = idVoltageDamage;
                        dataRow2["idVoltageSeti"] = idVoltageDamage;
                    }
                    this.dataSetDamage.tJ_DamageCharacter.Rows.Add(dataRow2);
                }
            }
        }

        private void toolBtnDelEquipment_Click(object sender, EventArgs e)
        {
            if (this.dgvEquipment.CurrentRow != null)
            {
                if (this.dgvEquipment.Rows.Count == 1)
                {
                    DataTable dataTable = new DataTable("tJ_Damage");
                    dataTable.Columns.Add("id", typeof(int));
                    string arg = "";
                    if (this.IdDocument != null)
                    {
                        arg = "id <> " + this.IdDocument.Value.ToString() + " and ";
                    }
                    base.SelectSqlData(dataTable, true, string.Format("where {0} idParent = {1} and typeDoc = {2} \r\n                        and not  exists(select id from tJ_DamageCharacter where idDAmage = tj_damage.id)", arg, this.IdParentDocument, (int)eTypeDocuments.ActDetection), null, false, 0);
                    if (dataTable.Rows.Count > 0)
                    {
                        MessageBox.Show("Нельзя удалить последнюю строку.\r\nУже существуют документ без оборудования.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                if (MessageBox.Show("Вы  действительно хотите удалить выбранную строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.dgvEquipment.Rows.Remove(this.dgvEquipment.CurrentRow);
                }
            }
        }

        private void dgvEquipment_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                object value = this.dgvEquipment[this.idSchmObjDgvColumn.Name, i].Value;
                if (value != DBNull.Value && value != null)
                {
                    object obj = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                    {
                    value.ToString()
                    });
                    if (obj != null && obj != DBNull.Value)
                    {
                        this.dgvEquipment[this.schmObjDgvColumn.Index, i].Value = obj.ToString();
                    }
                }
            }
        }

        private void bsDamageCharacter_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bsDamageCharacter.Current != null)
            {
                DataRow row = ((DataRowView)this.bsDamageCharacter.Current).Row;
                object idMark = row["idMark"];
                this.FillComboBoxMarkEquipment();
                row["idMark"] = idMark;
                this.cmbMarkEquipment.SelectedValue = idMark;
                if (!this.GetFormViewMode() && !this.chkApply.Checked)
                {
                    this.ControlBlockingTabPageSchm(false);
                    return;
                }
            }
            else
            {
                this.ControlBlockingTabPageSchm(true);
            }
        }

        private void FillComboBoxMarkEquipment()
        {
            if (this.bsDamageCharacter.Current == null || ((DataRowView)this.bsDamageCharacter.Current).Row["col1"] == DBNull.Value)
            {
                this.cmbMarkEquipment.DataSource = null;
                return;
            }
            DataTable dataTable = Reference.Tables.TableClassifier(null);
            base.SelectSqlData(dataTable, true, " where id = " + ((DataRowView)this.bsDamageCharacter.Current).Row["col1"].ToString(), null, false, 0);
            if (dataTable.Rows.Count == 0)
            {
                this.cmbMarkEquipment.DataSource = null;
                return;
            }
            string ParentKey = dataTable.Rows[0]["ParentKey"].ToString();
            // отсечем КЛ И ВЛ
            if (!(ParentKey == ";ReportDaily;NatureDamage;HV;AirLine;") && !(ParentKey == ";ReportDaily;NatureDamage;HV;CableLine;")
                && !(ParentKey == ";ReportDaily;NatureDamage;LV;Code1;") && !(ParentKey == ";ReportDaily;NatureDamage;LV;Code4;"))
            {
                // уберем подстанции
                if (!(ParentKey == ";ReportDaily;NatureDamage;HV;Subs;") && !(ParentKey == ";ReportDaily;NatureDamage;LV;Code2;"))
                {
                    // трансформаторыыы
                    if (ParentKey == ";ReportDaily;NatureDamage;HV;Transformer;" || ParentKey == ";ReportDaily;NatureDamage;LV;Transformer;")
                    {
                        DataTable dataSource = new SqlDataCommand(this.SqlSettings).SelectSqlData("select id, name + \r\n                                                                isnull('/' + convert(varchar(20), convert(float, highVoltage)), '') as name\r\n                                                                from tR_Transformer \r\n                                                                where deleted = 0\r\n                                                                order by name, highvoltage");
                        this.cmbMarkEquipment.DisplayMember = "name";
                        this.cmbMarkEquipment.ValueMember = "id";
                        this.cmbMarkEquipment.DataSource = dataSource;
                    }
                }
                else
                {
                    DataTable dataSource2 = new SqlDataCommand(this.SqlSettings).SelectSqlData("select id, Name\r\n                                                                from tP_ValueLists\r\n                                                                where ParentKey = ';SubstationType;' and isGRoup = 0 and deleted = 0\r\n                                                                order by name");
                    this.cmbMarkEquipment.DisplayMember = "name";
                    this.cmbMarkEquipment.ValueMember = "id";
                    this.cmbMarkEquipment.DataSource = dataSource2;
                }
            }
            else
            {
                DataTable dataSource3 = new SqlDataCommand(this.SqlSettings).SelectSqlData("select cName.id,\r\n                                                                     cName.CableMakeup + '-' + cast(cName.wires as varchar(8)) + 'x' + \r\n                                                                     convert(varchar(20), convert(float, CName.CrossSection))  \r\n                                                                \t + isnull('+' + cast(cName.wiresAddl as varchar(8))+'x'+convert(varchar(20), convert(float, CName.CrossSectionAddl))+'(N)'  , '') \r\n                                                                \t + isnull('-' + convert(varchar(20),convert(float, cV.Value)), '')\r\n                                                                \t as name\r\n                                                                from tr_Cable cName\r\n                                                                \tleft join tr_classifier cV on cV.id = cName.idVoltage\r\n                                                                where cName.CableMakeup is not null and cName.wires is not null and cName.CrossSection is not null\r\n                                                                     and cname.CableMakeup not like '[0-9]%'\r\n                                                                order by cName.CableMakeup, cName.wires, cName.CrossSection");
                this.cmbMarkEquipment.DisplayMember = "name";
                this.cmbMarkEquipment.ValueMember = "id";
                this.cmbMarkEquipment.DataSource = dataSource3;
            }
            this.cmbMarkEquipment.SelectedIndex = -1;
        }

        private void FillComboBoxParameters()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;Equipment;Params;'";
            bindingSource.Sort = "name";
            this.cmbParameters.DisplayMember = "name";
            this.cmbParameters.ValueMember = "id";
            this.cmbParameters.DataSource = bindingSource;
        }

        private void FillComboBoxVoltageSeti()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey like ';VoltageLevels;%'";
            //bindingSource.Filter = "ParentKey like ';VoltageLevels;MV;%'";
            //bindingSource.Filter = "ParentKey like ';VoltageLevels;LV;%'";
            bindingSource.Sort = "value";
            this.cmbVoltage.DisplayMember = "name";
            this.cmbVoltage.ValueMember = "id";
            this.cmbVoltage.DataSource = bindingSource;

            BindingSource bindingSource2 = new BindingSource();
            bindingSource2.DataSource = this.tblClassifier.Copy();
            bindingSource2.Filter = "ParentKey like ';VoltageLevels;%'";
            // bindingSource2.Filter = "ParentKey like ';VoltageLevels;MV;%'";
            // bindingSource2.Filter = "ParentKey like ';VoltageLevels;LV;%'";
            bindingSource2.Sort = "value";
            this.cmbVoltageSeti.DisplayMember = "name";
            this.cmbVoltageSeti.ValueMember = "id";
            this.cmbVoltageSeti.DataSource = bindingSource2;
        }

        private void FillComboBoxNodeDetail()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;Equipment;NodeDetail;'";
            bindingSource.Sort = "name";
            this.cmbNodeDetail.DisplayMember = "name";
            this.cmbNodeDetail.ValueMember = "id";
            this.cmbNodeDetail.DataSource = bindingSource;
        }

        private void FillComboBoxNeutraState()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;Equipment;NeutralState;'";
            bindingSource.Sort = "name";
            this.cmbNeutralState.DisplayMember = "name";
            this.cmbNeutralState.ValueMember = "id";
            this.cmbNeutralState.DataSource = bindingSource;
            this.cmbNeutralState.DataBindings[0].DataSourceNullValue = ((DataRowView)this.cmbNeutralState.Items[0]).Row["id"];
        }

        private void FillComboBoxMaterial()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;Equipment;Material;'";
            bindingSource.Sort = "name";
            this.cmbMaterial.DisplayMember = "name";
            this.cmbMaterial.ValueMember = "id";
            this.cmbMaterial.DataSource = bindingSource;
            this.cmbMaterial.DataBindings[0].DataSourceNullValue = ((DataRowView)this.cmbMaterial.Items[0]).Row["id"];
        }

        private void FillComboBoxClauseWork()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;Equipment;ClauseWork;'";
            bindingSource.Sort = "name";
            this.cmbClauseWork.DisplayMember = "name";
            this.cmbClauseWork.ValueMember = "id";
            this.cmbClauseWork.DataSource = bindingSource;
            this.cmbClauseWork.DataBindings[0].DataSourceNullValue = ((DataRowView)this.cmbClauseWork.Items[0]).Row["id"];
        }

        private void FillComboBoxCharacterDamage()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;Equipment;ChrDamage;'";
            bindingSource.Sort = "name";
            this.cmbCharacterDamage.DisplayMember = "name";
            this.cmbCharacterDamage.ValueMember = "id";
            this.cmbCharacterDamage.DataSource = bindingSource;
        }

        private void FillComboBoxReasonDamage()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.tblClassifier.Copy();
            bindingSource.Filter = "ParentKey = ';ReportDaily;ActDetection;Equipment;ReasonDamage;'";
            bindingSource.Sort = "name";
            this.cmbReasonDamage.DisplayMember = "name";
            this.cmbReasonDamage.ValueMember = "id";
            this.cmbReasonDamage.DataSource = bindingSource;
        }

        /// <summary>
        /// Заполним списки последних членов комиссии
        /// </summary>
        private void FillComboBoxsLastMemberComission(bool isSearchFull = false)
        {
            this.cmbChairman.SelectedValueChanged -= new EventHandler(this.cmb_SelectedValueChanged);
            this.cmbMemberComission1.SelectedValueChanged -= new EventHandler(this.cmb_SelectedValueChanged);
            this.cmbMemberComission2.SelectedValueChanged -= new EventHandler(this.cmb_SelectedValueChanged);
            this.cmbMemberComission3.SelectedValueChanged -= new EventHandler(this.cmb_SelectedValueChanged);
            this.cmbMemberComission4.SelectedValueChanged -= new EventHandler(this.cmb_SelectedValueChanged);
            this.cmbMemberComission5.SelectedValueChanged -= new EventHandler(this.cmb_SelectedValueChanged);
            if (!isSearchFull)
                if (this.GetIdDocument() != null) // если сохраненный документ
                {
                    // если  акте есть и комиссия заполнена в первом документе (текущем)
                    if (this.dataSetDamage.tJ_DamageActDetection.Rows.Count > 0 && this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Comission"] != DBNull.Value)
                    {
                        string Comission = this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Comission"].ToString();
                        if (!string.IsNullOrEmpty(Comission))
                        {
                            this.dataTableComission.ReadXml(new StringReader(Comission));
                        }
                    }
                }
                else // если новый документ
                {
                    DailyReportN.DataSet.dsDamage ds = new DailyReportN.DataSet.dsDamage();
                    base.SelectSqlData(ds.tJ_DamageActDetection, true, " where Comission is not null order by idDamage desc", null, false, 1);
                    // если в списке акт есть и комиссия заполнена в первом документе
                    if (ds.tJ_DamageActDetection.Rows.Count > 0 && ds.tJ_DamageActDetection.Rows[0]["Comission"] != DBNull.Value)
                    {
                        string Comission = ds.tJ_DamageActDetection.Rows[0]["Comission"].ToString();
                        if (!string.IsNullOrEmpty(Comission))
                        {
                            this.dataTableComission.ReadXml(new StringReader(Comission));
                        }
                    }
                }
            else // ищем последние заполненные данные
            {
                // будем считать, что дата документа уже есть
                string strDateDoc = Convert.ToDateTime(this.dataSetDamage.tJ_Damage.Rows[0]["datedoc"]).ToString("yyyyMMdd");
                DailyReportN.DataSet.dsDamage ds = new DailyReportN.DataSet.dsDamage();
                base.SelectSqlData(ds.tJ_DamageActDetection, true, String.Format(" right join tJ_Damage on idDamage = id where DateDoc <= '{0}' and Comission.exist('//Chairman') = 1 order by idDamage desc", strDateDoc), null, false, 1);
                // если в списке акт есть и комиссия заполнена в первом документе
                if (ds.tJ_DamageActDetection.Rows.Count > 0 && ds.tJ_DamageActDetection.Rows[0]["Comission"] != DBNull.Value)
                {
                    string Comission = ds.tJ_DamageActDetection.Rows[0]["Comission"].ToString();
                    if (!string.IsNullOrEmpty(Comission))
                    {
                        this.dataTableComission.Rows.Clear();
                        this.dataTableComission.ReadXml(new StringReader(Comission));
                        foreach (DataRow row in this.dataTableComission.Rows)
                        {
                            row["isChairmanSpecial"] = false;
                            row["isMemberComissionSpecial1"] = false;
                            row["isMemberComissionSpecial2"] = false;
                            row["isMemberComissionSpecial3"] = false;
                            row["isMemberComissionSpecial4"] = false;
                            row["isMemberComissionSpecial5"] = false;
                        }
                    }
                }
            }
            if (this.dataTableComission.Rows.Count == 0)
            {
                this.dataTableComission.Rows.Add(new object[0]);
            }
            this.cmbChairman.SelectedValueChanged += new EventHandler(this.cmb_SelectedValueChanged);
            this.cmbMemberComission1.SelectedValueChanged += new EventHandler(this.cmb_SelectedValueChanged);
            this.cmbMemberComission2.SelectedValueChanged += new EventHandler(this.cmb_SelectedValueChanged);
            this.cmbMemberComission3.SelectedValueChanged += new EventHandler(this.cmb_SelectedValueChanged);
            this.cmbMemberComission4.SelectedValueChanged += new EventHandler(this.cmb_SelectedValueChanged);
            this.cmbMemberComission5.SelectedValueChanged += new EventHandler(this.cmb_SelectedValueChanged);

            cmb_SelectedValueChanged(cmbChairman, null);
            cmb_SelectedValueChanged(cmbMemberComission1, null);
            cmb_SelectedValueChanged(cmbMemberComission2, null);
            cmb_SelectedValueChanged(cmbMemberComission3, null);
            cmb_SelectedValueChanged(cmbMemberComission4, null);
            cmb_SelectedValueChanged(cmbMemberComission5, null);
        }

        private void cmb_SelectedValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex < 0)
            {
                if (comboBox == this.cmbChairman)
                {
                    this.txtPostChairman.Text = "";
                    this.chkChairmanSpecial.Enabled = false;
                    this.chkChairmanSpecial.Checked = false;
                    this.txtChairmanSpecial.Enabled = false;

                }
                if (comboBox == this.cmbMemberComission1)
                {
                    this.txtPostMemeber1.Text = "";
                    this.chkMemberComissionSpecial1.Enabled = false;
                    this.chkMemberComissionSpecial1.Checked = false;
                    this.txtMemberPostSpecial1.Enabled = false;
                }
                if (comboBox == this.cmbMemberComission2)
                {
                    this.txtPostMemeber2.Text = "";
                    this.chkMemberComissionSpecial2.Enabled = false;
                    this.chkMemberComissionSpecial2.Checked = false;
                    this.txtMemberPostSpecial2.Enabled = false;
                }
                if (comboBox == this.cmbMemberComission3)
                {
                    this.txtPostMemeber3.Text = "";
                    this.chkMemberComissionSpecial3.Enabled = false;
                    this.chkMemberComissionSpecial3.Checked = false;
                    this.txtMemberPostSpecial3.Enabled = false;
                }
                if (comboBox == this.cmbMemberComission4)
                {
                    this.txtPostMemeber4.Text = "";
                    this.chkMemberComissionSpecial4.Enabled = false;
                    this.chkMemberComissionSpecial4.Checked = false;
                    this.txtMemberPostSpecial4.Enabled = false;
                }
                if (comboBox == this.cmbMemberComission5)
                {
                    this.txtPostMemeber5.Text = "";
                    this.chkMemberComissionSpecial5.Enabled = false;
                    this.chkMemberComissionSpecial5.Checked = false;
                    this.txtMemberPostSpecial5.Enabled = false;
                    //return;
                }
            }
            else
            {
                DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData("select t.description from tR_JobTitle t \r\n\t                inner join tR_Worker w on t.id = w.jobtitle\r\n                    where w.id = " + comboBox.SelectedValue.ToString());
                if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["Description"] != DBNull.Value)
                {
                    if (comboBox == this.cmbChairman)
                    {
                        if (this.txtPostChairman.Text == "")
                            this.txtPostChairman.Text = dataTable.Rows[0]["Description"].ToString();
                        this.chkChairmanSpecial.Enabled = true;
                        //this.txtChairmanSpecial.Enabled = true;
                    }
                    if (comboBox == this.cmbMemberComission1)
                    {
                        if (this.txtPostMemeber1.Text == "")
                            this.txtPostMemeber1.Text = dataTable.Rows[0]["Description"].ToString();
                        this.chkMemberComissionSpecial1.Enabled = true;
                        //this.txtMemberPostSpecial1.Enabled = true;
                    }
                    if (comboBox == this.cmbMemberComission2)
                    {
                        if (this.txtPostMemeber2.Text == "")
                            this.txtPostMemeber2.Text = dataTable.Rows[0]["Description"].ToString();
                        this.chkMemberComissionSpecial2.Enabled = true;
                        //this.txtMemberPostSpecial2.Enabled = true;
                    }
                    if (comboBox == this.cmbMemberComission3)
                    {
                        if (this.txtPostMemeber3.Text == "")
                            this.txtPostMemeber3.Text = dataTable.Rows[0]["Description"].ToString();
                        this.chkMemberComissionSpecial3.Enabled = true;
                        //this.txtMemberPostSpecial3.Enabled = true;
                    }
                    if (comboBox == this.cmbMemberComission4)
                    {
                        if (this.txtPostMemeber4.Text == "")
                            this.txtPostMemeber4.Text = dataTable.Rows[0]["Description"].ToString();
                        this.chkMemberComissionSpecial4.Enabled = true;
                        //this.txtMemberPostSpecial4.Enabled = true;
                    }
                    if (comboBox == this.cmbMemberComission5)
                    {
                        if (this.txtPostMemeber5.Text == "")
                            this.txtPostMemeber5.Text = dataTable.Rows[0]["Description"].ToString();
                        this.chkMemberComissionSpecial5.Enabled = true;
                        //this.txtMemberPostSpecial1.Enabled = true;
                        //return;
                    }
                }
                else
                {
                    if (comboBox == this.cmbMemberComission1)
                    {
                        this.txtPostMemeber1.Text = "";
                        this.chkMemberComissionSpecial1.Enabled = false;
                        this.chkMemberComissionSpecial1.Checked = false;
                        this.txtMemberPostSpecial1.Enabled = false;
                    }
                    if (comboBox == this.cmbMemberComission2)
                    {
                        this.txtPostMemeber2.Text = "";
                        this.chkMemberComissionSpecial2.Enabled = false;
                        this.chkMemberComissionSpecial2.Checked = false;
                        this.txtMemberPostSpecial2.Enabled = false;
                    }
                    if (comboBox == this.cmbMemberComission3)
                    {
                        this.txtPostMemeber3.Text = "";
                        this.chkMemberComissionSpecial3.Enabled = false;
                        this.chkMemberComissionSpecial3.Checked = false;
                        this.txtMemberPostSpecial3.Enabled = false;
                    }
                    if (comboBox == this.cmbMemberComission4)
                    {
                        this.txtPostMemeber4.Text = "";
                        this.chkMemberComissionSpecial4.Enabled = false;
                        this.chkMemberComissionSpecial4.Checked = false;
                        this.txtMemberPostSpecial4.Enabled = false;
                    }
                    if (comboBox == this.cmbMemberComission5)
                    {
                        this.txtPostMemeber5.Text = "";
                        this.chkMemberComissionSpecial5.Enabled = false;
                        this.chkMemberComissionSpecial5.Checked = false;
                        this.txtMemberPostSpecial5.Enabled = false;
                    }
                }
                lblChairmanSpecial.Text = txtPostChairman.Text;
                lblMemberComissionSpecial1.Text = txtPostMemeber1.Text;
                lblMemberComissionSpecial2.Text = txtPostMemeber2.Text;
                lblMemberComissionSpecial3.Text = txtPostMemeber3.Text;
                lblMemberComissionSpecial4.Text = txtPostMemeber4.Text;
                lblMemberComissionSpecial5.Text = txtPostMemeber5.Text;


            }
        }


        private void ControlBlockingOtherDocuments()
        {
            if (!this.GetFormViewMode() && !this.chkApply.Checked)
            {
                this.cmbCompiler.ReadOnly = false;
                this.cmbDivision.ReadOnly = false;
                this.chkCrash.Enabled = true;
                this.buttonChooseParentDamage.Enabled = true;

                this.btnRefreshDateDoc.Enabled = true;
                this.chkNoOff.Enabled = true;
                this.dtpDateDoc.Enabled = true;
                this.dtpBeginCrashMoscow.Enabled = false;
                this.btnRefrshDateEndCrash.Enabled = true;

                this.cmbTypeEquipment.ReadOnly = false;
                this.cmbSignCrash.ReadOnly = false;
                this.cmbOrg.ReadOnly = false;
                this.cmbOrgCrash.ReadOnly = false;
                this.cmbOrgCrashEq.ReadOnly = false;

                this.cmbReasonCrash.ReadOnly = false;
                this.cmbReasonCrashEquipment.ReadOnly = false;
                this.dgvNoCrashMeasure.ReadOnly = false;

                this.txtStatusCurrentCrash.ReadOnly = false;
                this.cmbStatusCurrentCrash.ReadOnly = false;
                this.cmbStatusBeforeCrash.ReadOnly = false;
                this.txtStatusBeforeCrash.ReadOnly = false;
                this.dgvDefection.ReadOnly = false;

                this.cmbFault.ReadOnly = false;
                this.cmbClassifierDamage.ReadOnly = false;
                this.txtReasonBeginCrash.ReadOnly = false;
                this.txtClassifierDamage.ReadOnly = false;
                this.txtFault.ReadOnly = false;

                this.cmbReasonBeginCrash.ReadOnly = false;
                this.toolStripEquipment.Enabled = true;
                this.dgvEquipment.ReadOnly = false;

                this.ControlBlockingTabPageSchm(false);

                this.txtOrder.ReadOnly = false;

                this.txtPostChairman.ReadOnly = false;
                this.cmbChairman.ReadOnly = false;

                this.cmbMemberComission5.ReadOnly = false;
                this.cmbMemberComission4.ReadOnly = false;
                this.cmbMemberComission3.ReadOnly = false;
                this.cmbMemberComission2.ReadOnly = false;
                this.cmbMemberComission1.ReadOnly = false;

                this.txtPostMemeber5.ReadOnly = false;
                this.txtPostMemeber4.ReadOnly = false;
                this.txtPostMemeber3.ReadOnly = false;
                this.txtPostMemeber2.ReadOnly = false;
                this.txtPostMemeber1.ReadOnly = false;

                this.txtTotalComission.ReadOnly = false;
            }
            else
            {
                this.cmbCompiler.ReadOnly = true;
                this.cmbDivision.ReadOnly = true;
                this.chkCrash.Enabled = false;
                this.buttonChooseParentDamage.Enabled = false;

                this.btnRefreshDateDoc.Enabled = false;
                this.chkNoOff.Enabled = false;
                this.dtpDateDoc.Enabled = false;
                this.dtpBeginCrashMoscow.Enabled = false;
                this.btnRefrshDateEndCrash.Enabled = false;

                this.cmbTypeEquipment.ReadOnly = true;
                this.cmbSignCrash.ReadOnly = true;
                this.cmbOrg.ReadOnly = true;
                this.cmbOrgCrash.ReadOnly = true;
                this.cmbOrgCrashEq.ReadOnly = true;


                this.cmbReasonCrash.ReadOnly = true;
                this.cmbReasonCrashEquipment.ReadOnly = true;
                this.dgvNoCrashMeasure.ReadOnly = true;

                this.txtStatusCurrentCrash.ReadOnly = true;
                this.cmbStatusCurrentCrash.ReadOnly = true;
                this.cmbStatusBeforeCrash.ReadOnly = true;
                this.txtStatusBeforeCrash.ReadOnly = true;
                this.dgvDefection.ReadOnly = true;

                this.cmbFault.ReadOnly = true;
                this.cmbClassifierDamage.ReadOnly = true;
                this.txtReasonBeginCrash.ReadOnly = true;

                this.txtClassifierDamage.ReadOnly = true;
                this.txtFault.ReadOnly = true;

                this.cmbReasonBeginCrash.ReadOnly = true;
                this.toolStripEquipment.Enabled = false;
                this.dgvEquipment.ReadOnly = true;
                this.ControlBlockingTabPageSchm(true);
                this.txtOrder.ReadOnly = true;

                this.txtPostChairman.ReadOnly = true;
                this.cmbChairman.ReadOnly = true;

                this.cmbMemberComission5.ReadOnly = true;
                this.cmbMemberComission4.ReadOnly = true;
                this.cmbMemberComission3.ReadOnly = true;
                this.cmbMemberComission2.ReadOnly = true;
                this.cmbMemberComission1.ReadOnly = true;

                this.txtPostMemeber5.ReadOnly = true;
                this.txtPostMemeber4.ReadOnly = true;
                this.txtPostMemeber3.ReadOnly = true;
                this.txtPostMemeber2.ReadOnly = true;
                this.txtPostMemeber1.ReadOnly = true;
                this.txtTotalComission.ReadOnly = true;
            }
            if (this.GetFormViewMode())
            {
                this.chkApply.Enabled = false;
                this.cmbWorkerApply.ReadOnly = true;
                this.dtpApply.Enabled = false;
                this.buttonSave.Enabled = false;
                return;
            }
            this.buttonSave.Enabled = true;
        }
        /// <summary>
        ///  контроль блокировки контролов на странице оборудования
        /// </summary>
        private void ControlBlockingTabPageSchm(bool flag)
        {
            this.chkAutoProtect.Enabled = !flag;

            this.cmbVoltage.ReadOnly = flag;
            this.cmbParameters.ReadOnly = flag;
            this.cmbMarkEquipment.ReadOnly = flag;
            this.cmbVoltageSeti.ReadOnly = flag;
            this.txtCountDefectEquipment.ReadOnly = flag;
            this.cmbNodeDetail.ReadOnly = flag;
            this.txtNodeDetail.ReadOnly = flag;
            this.schmObjDgvColumn.ReadOnly = flag;
            this.txtYearManufature.ReadOnly = flag;
            this.txtFactoryNumber.ReadOnly = flag;
            this.txtManufacturer.ReadOnly = flag;
            this.txtClauseFail.ReadOnly = flag;
            this.cmbNeutralState.ReadOnly = flag;
            this.txtLenghtLine.ReadOnly = flag;
            this.txtLengthOverload.ReadOnly = flag;
            this.cmbClauseWork.ReadOnly = flag;
            this.cmbMaterial.ReadOnly = flag;
            this.cmbReasonDamage.ReadOnly = flag;
            this.cmbCharacterDamage.ReadOnly = flag;
            this.txtLengthWorkEquipment.ReadOnly = flag;
            this.txtYearBegEquipment.ReadOnly = flag;
            this.txtAssociatedFact.ReadOnly = flag;

            this.dtpLastDateTest.Enabled = (this.dtpTimeRecovery.Enabled = !flag);
        }

        private void chkApply_CheckedChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.ControlBlockingOtherDocuments();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab == this.tabPagePrint)
            {
                ReportViewerRus reportViewerRus = new ReportViewerRus();
                reportViewerRus.LocalReport.ReportEmbeddedResource = "DailyReportN.ActDetection.ReportActDetection.rdlc";
                //reportViewerRus.LocalReport.ReportEmbeddedResource = "DailyReportN.ActDetection.ReportActDetectionN.rdlc";
                reportViewerRus.Dock = DockStyle.Fill;
                this.tabPagePrint.Controls.Clear();
                this.tabPagePrint.Controls.Add(reportViewerRus);
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "dsDamage";
                reportDataSource.Value = this.bsDamage;
                reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
                reportDataSource = new ReportDataSource();
                reportDataSource.Name = "dsActDetection";
                reportDataSource.Value = new BindingSource
                {
                    DataSource = this.dataSetDamage.tJ_DamageActDetection
                };
                reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
                List<ReportParameter> list = new List<ReportParameter>();
                if (this.cmbOrg.SelectedIndex >= 0)
                {
                    list.Add(new ReportParameter("Org", ((DataRowView)this.cmbOrg.SelectedItem).Row["name"].ToString()));
                }
                if (this.cmbSignCrash.SelectedIndex >= 0)
                {
                    list.Add(new ReportParameter("signCrashCode", ((DataRowView)this.cmbSignCrash.SelectedItem).Row["name"].ToString()));
                    list.Add(new ReportParameter("signCrash", ((DataRowView)this.cmbSignCrash.SelectedItem).Row["comment"].ToString()));
                }
                if (this.cmbTypeEquipment.SelectedIndex >= 0)
                {
                    list.Add(new ReportParameter("typeEquipmentCode", ((DataRowView)this.cmbTypeEquipment.SelectedItem).Row["name"].ToString()));
                    list.Add(new ReportParameter("typeEquipment", ((DataRowView)this.cmbTypeEquipment.SelectedItem).Row["comment"].ToString()));
                }
                if (this.cmbReasonCrashEquipment.SelectedIndex >= 0)
                {
                    list.Add(new ReportParameter("reasonCrashEqCode", ((DataRowView)this.cmbReasonCrashEquipment.SelectedItem).Row["name"].ToString()));
                    list.Add(new ReportParameter("reasonCrashEq", ((DataRowView)this.cmbReasonCrashEquipment.SelectedItem).Row["comment"].ToString()));
                }
                if (this.cmbReasonCrash.SelectedIndex >= 0)
                {
                    list.Add(new ReportParameter("reasonCrashCode", ((DataRowView)this.cmbReasonCrash.SelectedItem).Row["name"].ToString()));
                    list.Add(new ReportParameter("reasonCrash", ((DataRowView)this.cmbReasonCrash.SelectedItem).Row["comment"].ToString()));
                }
                list.Add(new ReportParameter("schmObj", this.txtSchmObj.Text));
                // StatusBeforeCrash
                //if (this.cmbStatusBeforeCrash.SelectedIndex >= 0)
                //{
                //    list.Add(new ReportParameter("statusBeforeCrash", ((DataRowView)this.cmbStatusBeforeCrash.SelectedItem).Row["comment"].ToString()));
                //}
                if (!string.IsNullOrEmpty(this.txtStatusBeforeCrash.Text))
                {
                    list.Add(new ReportParameter("statusBeforeCrash", this.txtStatusBeforeCrash.Text));
                }
                else if (this.cmbStatusBeforeCrash.SelectedIndex >= 0)
                {
                    list.Add(new ReportParameter("statusBeforeCrash", ((DataRowView)this.cmbStatusBeforeCrash.SelectedItem).Row["comment"].ToString()));
                }
                //
                if (!string.IsNullOrEmpty(this.txtStatusCurrentCrash.Text))
                {
                    list.Add(new ReportParameter("statusCurrentCrash", this.txtStatusCurrentCrash.Text));
                }
                else if (this.cmbStatusCurrentCrash.SelectedIndex >= 0)
                {
                    list.Add(new ReportParameter("statusCurrentCrash", ((DataRowView)this.cmbStatusCurrentCrash.SelectedItem).Row["comment"].ToString()));
                }
                //
                reportDataSource = new ReportDataSource();
                reportDataSource.Name = "ds23";
                BindingSource bs23 = new BindingSource();
                bs23.DataSource = this.dataSetDamage.table23;
                this.dataSetDamage.table23.Clear();
                foreach (DataGridViewRow dataGridViewRow in this.dgvDefection.Rows)
                {
                    DataRow dataRow = this.dataSetDamage.table23.NewRow();
                    dataRow["Description"] = dataGridViewRow.Cells[this.idDefectionDataGridViewTextBoxColumn.Name].FormattedValue.ToString();
                    dataRow["NPA"] = dataGridViewRow.Cells[this.idNPADgvColumn.Name].FormattedValue.ToString();
                    if (dataGridViewRow.Cells[this.punctNPADataGridViewTextBoxColumn.Name].Value != null)
                    {
                        dataRow["punktNPA"] = dataGridViewRow.Cells[this.punctNPADataGridViewTextBoxColumn.Name].Value.ToString();
                    }
                    dataRow["Org"] = dataGridViewRow.Cells[this.idOrgDefectionDgvColumn.Name].FormattedValue.ToString();
                    this.dataSetDamage.table23.Rows.Add(dataRow);
                }
                if (this.dataSetDamage.table23.Rows.Count > 0)
                {
                    this.dataSetDamage.table23.Rows.RemoveAt(this.dataSetDamage.table23.Rows.Count - 1);
                }
                reportDataSource.Value = bs23;
                reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
                if (!string.IsNullOrEmpty(this.txtReasonBeginCrash.Text))
                {
                    list.Add(new ReportParameter("reasonBeginCrash", this.txtReasonBeginCrash.Text));
                }
                else if (this.cmbReasonBeginCrash.SelectedIndex >= 0)
                {
                    list.Add(new ReportParameter("reasonBeginCrashCode", ((DataRowView)this.cmbReasonBeginCrash.SelectedItem).Row["name"].ToString()));
                    list.Add(new ReportParameter("reasonBeginCrash", ((DataRowView)this.cmbReasonBeginCrash.SelectedItem).Row["comment"].ToString()));
                }

                if (!string.IsNullOrEmpty(this.txtClassifierDamage.Text))
                {
                    list.Add(new ReportParameter("classifierDamage", this.txtClassifierDamage.Text));
                }
                else if (this.cmbClassifierDamage.SelectedIndex >= 0)
                {
                    list.Add(new ReportParameter("classifierDamage", ((DataRowView)this.cmbClassifierDamage.SelectedItem).Row["name"].ToString()));
                }
                //if (this.cmbClassifierDamage.SelectedIndex >= 0)
                //{
                //    list.Add(new ReportParameter("classifierDamage", ((DataRowView)this.cmbClassifierDamage.SelectedItem).Row["name"].ToString()));
                //}
                if (!string.IsNullOrEmpty(this.txtFault.Text))
                {
                    list.Add(new ReportParameter("fault", this.txtFault.Text));
                }
                else if (this.cmbFault.SelectedIndex >= 0)
                {
                    list.Add(new ReportParameter("fault", ((DataRowView)this.cmbFault.SelectedItem).Row["name"].ToString()));
                }
                //if (this.cmbFault.SelectedIndex >= 0)
                //{
                //    list.Add(new ReportParameter("fault", ((DataRowView)this.cmbFault.SelectedItem).Row["name"].ToString()));
                //}
                //
                reportDataSource = new ReportDataSource();
                reportDataSource.Name = "ds31";
                BindingSource bs31 = new BindingSource();
                bs31.DataSource = this.dataSetDamage.table31;
                this.dataSetDamage.table31.Clear();
                foreach (DataGridViewRow dataGridViewRow2 in ((IEnumerable)this.dgvNoCrashMeasure.Rows))
                {
                    DataRow dataRow2 = this.dataSetDamage.table31.NewRow();
                    dataRow2["Measure"] = dataGridViewRow2.Cells[this.idNoCrashMeasureColumn.Name].FormattedValue.ToString();
                    if (dataGridViewRow2.Cells[this.dateCompleteDataGridViewTextBoxColumn.Name].Value != null && dataGridViewRow2.Cells[this.dateCompleteDataGridViewTextBoxColumn.Name].Value != DBNull.Value)
                    {
                        dataRow2["date"] = Convert.ToDateTime(dataGridViewRow2.Cells[this.dateCompleteDataGridViewTextBoxColumn.Name].Value).ToString("MMMM yyyy");
                    }
                    dataRow2["Org"] = dataGridViewRow2.Cells[this.idOrgColumn.Name].FormattedValue.ToString();
                    this.dataSetDamage.table31.Rows.Add(dataRow2);
                }
                if (this.dataSetDamage.table31.Rows.Count > 0)
                {
                    this.dataSetDamage.table31.Rows.RemoveAt(this.dataSetDamage.table31.Rows.Count - 1);
                }
                reportDataSource.Value = bs31;
                reportViewerRus.LocalReport.DataSources.Add(reportDataSource);

                #region Отказавшее оборудование
                reportDataSource = new ReportDataSource();
                reportDataSource.Name = "ds4";
                BindingSource bs4 = new BindingSource();
                bs4.DataSource = this.dataSetDamage.table4;
                this.dataSetDamage.table4.Clear();
                int num = 1;
                    for (int i = 0; i < this.dataSetDamage.tJ_DamageCharacter.Rows.Count; i++)
                    {
                        DataRow dataRow3 = this.dataSetDamage.tJ_DamageCharacter.Rows[i];
                        if (dataRow3.RowState != DataRowState.Deleted)
                        {
                            DataRow dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Отказавшее оборудование: ";
                            dataRow4["Description"] = dataRow4["Description"].ToString() + this.dgvEquipment[this.typeEquipmentDgvColumn.Name, i].FormattedValue.ToString();
                            if (this.dgvEquipment[this.schmObjDgvColumn.Name, i].Value != null)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + "   " + this.dgvEquipment[this.schmObjDgvColumn.Name, i].Value.ToString();
                            }
                            if (this.dgvEquipment[this.schmObjNameDgvColumn.Name, i].Value != null)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + "   " + this.dgvEquipment[this.schmObjNameDgvColumn.Name, i].Value.ToString();
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Марка: ";
                            if (dataRow3["idMark"] != DBNull.Value && dataRow3["col1"] != DBNull.Value)
                            {
                                DataTable dataTable = Reference.Tables.TableClassifier(null);
                                base.SelectSqlData(dataTable, true, " where id = " + dataRow3["col1"].ToString(), null, false, 0);
                                if (dataTable.Rows.Count > 0)
                                {
                                    string a = dataTable.Rows[0]["ParentKey"].ToString();
                                    if (!(a == ";ReportDaily;NatureDamage;HV;AirLine;") && !(a == ";ReportDaily;NatureDamage;HV;CableLine;"))
                                    {
                                        if (!(a == ";ReportDaily;NatureDamage;HV;Subs;"))
                                        {
                                            if (a == ";ReportDaily;NatureDamage;HV;Transformer;")
                                            {
                                                DataTable dataTable2 = new SqlDataCommand(this.SqlSettings).SelectSqlData("select id, name + \r\n                                                                isnull('/' + convert(varchar(20), convert(float, highVoltage)), '') as name\r\n                                                                from tR_Transformer \r\n                                                                where id = " + dataRow3["idMark"].ToString() + " order by name, highvoltage");
                                                if (dataTable2.Rows.Count > 0)
                                                {
                                                    dataRow4["Description"] = dataRow4["Description"].ToString() + dataTable2.Rows[0]["Name"].ToString();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            DataTable dataTable3 = new SqlDataCommand(this.SqlSettings).SelectSqlData("select id, Name\r\n                                                                from tP_ValueLists\r\n                                                                where ParentKey = ';SubstationType;' and isGRoup = 0 and deleted = 0\r\n                                                                    and id = " + dataRow3["idMark"].ToString() + " order by name");
                                            if (dataTable3.Rows.Count > 0)
                                            {
                                                dataRow4["Description"] = dataRow4["Description"].ToString() + dataTable3.Rows[0]["Name"].ToString();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        DataTable dataTable4 = new SqlDataCommand(this.SqlSettings).SelectSqlData("select id, CableMakeup + ' ' + cast(wires as varchar(8)) + 'x' + \r\n                                            convert(varchar(20), convert(float, CrossSection)) as name from tr_Cable \r\n                                            where id = " + dataRow3["idMark"].ToString() + " order by CableMakeup, wires, CrossSection");
                                        if (dataTable4.Rows.Count > 0)
                                        {
                                            dataRow4["Description"] = dataRow4["Description"].ToString() + dataTable4.Rows[0]["Name"].ToString();
                                        }
                                    }
                                }
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Параметры: ";
                            if (dataRow3["idParameters"] != DBNull.Value)
                            {
                                DataRow[] array = this.tblClassifier.Select("id = " + dataRow3["idParameters"].ToString());
                                if (array.Length != 0)
                                {
                                    dataRow4["Description"] = dataRow4["Description"].ToString() + array[0]["Name"].ToString();
                                }
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Конструктивное напряжение: ";
                            if (dataRow3["idVoltage"] != DBNull.Value)
                            {
                                DataRow[] array2 = this.tblClassifier.Select("id = " + dataRow3["idVoltage"].ToString());
                                if (array2.Length != 0)
                                {
                                    dataRow4["Description"] = dataRow4["Description"].ToString() + array2[0]["Name"].ToString();
                                }
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Узел, деталь: ";
                            if (dataRow3["NodeDetail"] != DBNull.Value)
                            {
                                DataRow[] array3 = this.tblClassifier.Select("id = " + dataRow3["NodeDetail"].ToString());
                                if (array3.Length != 0)
                                {
                                    dataRow4["Description"] = dataRow4["Description"].ToString() + array3[0]["Name"].ToString();
                                }
                            }
                            if (dataRow3["NodeDetailTxt"] != DBNull.Value)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + " " + dataRow3["NodeDetailTxt"].ToString();
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Количество отказавшего оборудования, узлов: ";
                            if (dataRow3["CountDefectEquipment"] != DBNull.Value)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["CountDefectEquipment"].ToString();
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Напряжение сети: ";
                            if (dataRow3["idVoltageSeti"] != DBNull.Value)
                            {
                                DataRow[] array4 = this.tblClassifier.Select("id = " + dataRow3["idVoltageSEti"].ToString());
                                if (array4.Length != 0)
                                {
                                    dataRow4["Description"] = dataRow4["Description"].ToString() + array4[0]["Name"].ToString();
                                }
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Изготовитель оборудования или повредившегося узла: ";
                            if (dataRow3["Manufacturer"] != DBNull.Value)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["Manufacturer"].ToString();
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Заводской номер: ";
                            if (dataRow3["FactoryNumber"] != DBNull.Value)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["FactoryNumber"].ToString();
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Год изготовления оборудования: ";
                            if (dataRow3["YearManufacture"] != DBNull.Value)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["YearManufacture"].ToString() + "г.";
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Состояние нейтрали: ";
                            if (dataRow3["idNeutralState"] != DBNull.Value)
                            {
                                DataRow[] array5 = this.tblClassifier.Select("id = " + dataRow3["idNeutralState"].ToString());
                                if (array5.Length != 0)
                                {
                                    dataRow4["Description"] = dataRow4["Description"].ToString() + array5[0]["Name"].ToString();
                                }
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Условия отказа оборудования, % относительная нагрузка кабеля, число цепей ВЛ: ";
                            if (dataRow3["ClauseFail"] != DBNull.Value)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["ClauseFail"].ToString();
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Продолжительность работы оборудования с перегрузкой: ";
                            if (dataRow3["LengthOverload"] != DBNull.Value)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["LengthOverload"].ToString();
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Длина КЛ, ВЛ, м: ";
                            if (dataRow3["LengthLine"] != DBNull.Value)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["LengthLine"].ToString();
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Материал: ";
                            if (dataRow3["idMaterial"] != DBNull.Value)
                            {
                                DataRow[] array6 = this.tblClassifier.Select("id = " + dataRow3["idMaterial"].ToString());
                                if (array6.Length != 0)
                                {
                                    dataRow4["Description"] = dataRow4["Description"].ToString() + array6[0]["Name"].ToString();
                                }
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Условия работы: ";
                            if (dataRow3["ClauseWork"] != DBNull.Value)
                            {
                                DataRow[] array7 = this.tblClassifier.Select("id = " + dataRow3["ClauseWork"].ToString());
                                if (array7.Length != 0)
                                {
                                    dataRow4["Description"] = dataRow4["Description"].ToString() + array7[0]["Name"].ToString();
                                }
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Характер повреждения: ";
                            if (this.cmbClassifierDamage.SelectedIndex >= 0)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + ((DataRowView)this.cmbClassifierDamage.SelectedItem).Row["name"].ToString();
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Причина повреждения: ";
                            if (this.cmbReasonBeginCrash.SelectedIndex >= 0)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + ((DataRowView)this.cmbReasonBeginCrash.SelectedItem).Row["comment"].ToString().ToLower();
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Сопутствующие обстоятельства: ";
                            if (dataRow3["AssociatedFact"] != DBNull.Value)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["AssociatedFact"].ToString();
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Срок службы оборудования от последнего капительного ремонта:\r\n \t\t 1) Начало эксплуатации: ";
                            if (dataRow3["yearBegEquipment"] != DBNull.Value)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["yearBegEquipment"].ToString() + "г.";
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Срок службы поврежденного узла: ";
                            if (dataRow3["lenghtWorkEquipment"] != DBNull.Value)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + dataRow3["lenghtWorkEquipment"].ToString() + " " + CreateActDetection.GetDeclineYears(Convert.ToInt32(dataRow3["lenghtWorkEquipment"]));
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Последние эксплуатационные испытания: ";
                            if (dataRow3["LastDateTest"] != DBNull.Value)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + Convert.ToDateTime(dataRow3["LastDateTest"]).ToString("yyyy") + "г.";
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                            dataRow4 = this.dataSetDamage.table4.NewRow();
                            dataRow4["num"] = "4." + num.ToString() + ".";
                            dataRow4["Description"] = "Дата восстановления: ";
                            if (dataRow3["timeRecovery"] != DBNull.Value)
                            {
                                dataRow4["Description"] = dataRow4["Description"].ToString() + Convert.ToDateTime(dataRow3["timeRecovery"]).ToString("dd.MM.yyyy") + "г.";
                            }
                            this.dataSetDamage.table4.Rows.Add(dataRow4);
                            num++;
                        }
                    }
                // если оборудования нет
                if (this.dataSetDamage.table4.Rows.Count == 0)
                {
                    DataRow dataRow4 = this.dataSetDamage.table4.NewRow();
                    dataRow4["num"] = "";
                    dataRow4["Description"] = "В сетях МУП \"Ульяновская городская электросеть\" отказавшее оборудование отсутствует ";
                    this.dataSetDamage.table4.Rows.Add(dataRow4);
                }
                reportDataSource.Value = bs4;
                reportViewerRus.LocalReport.DataSources.Add(reportDataSource);

                #endregion

                list.Add(new ReportParameter("Order", this.txtOrder.Text));
                if (this.cmbChairman.SelectedIndex >= 0)
                {
                    string text = ((DataRowView)this.cmbChairman.SelectedItem).Row["fio"].ToString();
                    if (!string.IsNullOrEmpty(this.txtPostChairman.Text))
                    {
                        text = text + ", " + this.txtPostChairman.Text.ToLower();
                    }
                    list.Add(new ReportParameter("Chairman", text));
                }
                if (this.cmbMemberComission1.SelectedIndex >= 0)
                {
                    string text2 = ((DataRowView)this.cmbMemberComission1.SelectedItem).Row["fio"].ToString();
                    if (!string.IsNullOrEmpty(this.txtPostMemeber1.Text))
                    {
                        text2 = text2 + ", " + this.txtPostMemeber1.Text.ToLower();
                    }
                    list.Add(new ReportParameter("Comission1", text2));
                }
                if (this.cmbMemberComission2.SelectedIndex >= 0)
                {
                    string text3 = ((DataRowView)this.cmbMemberComission2.SelectedItem).Row["fio"].ToString();
                    if (!string.IsNullOrEmpty(this.txtPostMemeber2.Text))
                    {
                        text3 = text3 + ", " + this.txtPostMemeber2.Text.ToLower();
                    }
                    list.Add(new ReportParameter("Comission2", text3));
                }
                if (this.cmbMemberComission3.SelectedIndex >= 0)
                {
                    string text4 = ((DataRowView)this.cmbMemberComission3.SelectedItem).Row["fio"].ToString();
                    if (!string.IsNullOrEmpty(this.txtPostMemeber3.Text))
                    {
                        text4 = text4 + ", " + this.txtPostMemeber3.Text.ToLower();
                    }
                    list.Add(new ReportParameter("Comission3", text4));
                }
                if (this.cmbMemberComission4.SelectedIndex >= 0)
                {
                    string text5 = ((DataRowView)this.cmbMemberComission4.SelectedItem).Row["fio"].ToString();
                    if (!string.IsNullOrEmpty(this.txtPostMemeber4.Text))
                    {
                        text5 = text5 + ", " + this.txtPostMemeber4.Text.ToLower();
                    }
                    list.Add(new ReportParameter("Comission4", text5));
                }
                if (this.cmbMemberComission5.SelectedIndex >= 0)
                {
                    string text6 = ((DataRowView)this.cmbMemberComission5.SelectedItem).Row["fio"].ToString();
                    if (!string.IsNullOrEmpty(this.txtPostMemeber5.Text))
                    {
                        text6 = text6 + ", " + this.txtPostMemeber5.Text.ToLower();
                    }
                    list.Add(new ReportParameter("Comission5", text6));
                }
                if (this.cmbCompiler.SelectedIndex >= 0)
                {
                    string text7 = ((DataRowView)this.cmbCompiler.SelectedItem).Row["fio"].ToString();
                    if (this.cmbCompiler.SelectedIndex >= 0)
                    {
                        DataTable dataTable5 = new SqlDataCommand(this.SqlSettings).SelectSqlData("select t.description from tR_JobTitle t \r\n\t                                                    inner join tR_Worker w on t.id = w.jobtitle\r\n                                                        where w.id = " + this.cmbCompiler.SelectedValue.ToString());
                        if (dataTable5.Rows.Count > 0 && dataTable5.Rows[0]["Description"] != DBNull.Value)
                        {
                            text7 = text7 + ", " + dataTable5.Rows[0]["Description"].ToString().ToLower();
                        }
                    }
                    list.Add(new ReportParameter("Compiler", text7));
                }
                reportViewerRus.LocalReport.SetParameters(list);
                reportViewerRus.RefreshReport();
            }
        }



        private void cmbWorkerApply_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.cmbWorkerApply.SelectedIndex >= 0 && (this.dtpApply.Value == null || this.dtpApply.Value == DBNull.Value))
            {
                this.dtpApply.Value = DateTime.Now;
            }
        }

        private void txtYearManufature_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.txtYearBegEquipment.Text = this.txtYearManufature.Text;
        }

        private void txtYearManufature_Enter(object sender, EventArgs e)
        {
            this.txtYearManufature.TextChanged += new EventHandler(this.txtYearManufature_TextChanged);
        }

        private void txtYearManufature_Leave(object sender, EventArgs e)
        {
            this.txtYearManufature.TextChanged -= new EventHandler(this.txtYearManufature_TextChanged);
        }

        private void dtpDateOwner_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.CalcLengthWorkEquipment();
        }

        private void dtpDateOwner_CloseUp(object sender, EventArgs e)
        {
            this.FillComboBoxWorker();
        }

        private void dtpDateOwner_Leave(object sender, EventArgs e)
        {
            this.FillComboBoxWorker();
        }

        private void txtYearBegEquipment_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.CalcLengthWorkEquipment();
        }
        /// <summary>
        /// расчет (вывод на  форму) срока службы поврежденного узла
        /// </summary>
        private void CalcLengthWorkEquipment()
        {
            int num = 0;
            if (int.TryParse(this.txtYearBegEquipment.Text, out num))
            {
                this.txtLengthWorkEquipment.Text = (this.dtpDateOwner.Value.Year - num).ToString();
            }
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                e.Cancel = true;
            }
        }

        private void dtpTimeRecovery_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpTimeRecovery.Value != null)
            {
                this.dtpLastDateTest.MaxDate = Convert.ToDateTime(this.dtpTimeRecovery.Value);
            }
        }

        private void btnRefreshDateDoc_Click(object sender, EventArgs e)
        {
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
            {
                if (this.dataSetDamage.tJ_Damage.Rows[0]["idParent"] == DBNull.Value)
                {
                    MessageBox.Show("Не выбран документ аварийного события", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DataTable dataTable = new DataTable("tJ_Damage");
                dataTable.Columns.Add("dateDoc", typeof(DateTime));
                base.SelectSqlData(dataTable, true, "where id = " + this.dataSetDamage.tJ_Damage.Rows[0]["idParent"].ToString(), null, false, 0);
                if (dataTable.Rows.Count > 0)
                {
                    //this.dtpDateDoc.Value = Convert.ToDateTime(dataTable.Rows[0]["DateDoc"].ToString());
                    this.dataSetDamage.tJ_Damage.Rows[0]["DateDoc"] = dataTable.Rows[0]["DateDoc"];
                    SetBeginCrashMoscow();
                }
            }
        }

        private void btnRefreshDateEndCrash_Click(object sender, EventArgs e)
        {
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
            {
                if (this.dataSetDamage.tJ_Damage.Rows[0]["idParent"] == DBNull.Value)
                {
                    MessageBox.Show("Не выбран документ аварийного события", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (this.dataSetDamage.tJ_DamageActDetection.Rows.Count > 0)
                {
                    DataTable dataTable = new DataTable("tj_DamageOn");
                    dataTable.Columns.Add("DateOn", typeof(DateTime));
                    base.SelectSqlData(dataTable, true, "where idDamage = " + this.dataSetDamage.tJ_Damage.Rows[0]["idParent"].ToString() + " order by DateOn desc", null, false, 0);
                    if (dataTable.Rows.Count > 0)
                    {
                        this.dataSetDamage.tJ_DamageActDetection.Rows[0]["dateEndCrashLocal"] = dataTable.Rows[0]["dateOn"];
                        return;
                    }
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["dateEndCrashLocal"] = DBNull.Value;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            new FormReportActDetection()
            {
                SqlSettings = this.SqlSettings,
                MdiParent = base.MdiParent,
                FormParent = this
            }.Show();
        }

        #region получение параметров объектов

        //private object GetLengthLine(int idSChmObj)
        //{
        //    DataTable dataTable = new DataTable("tSchm_ObjList");
        //    dataTable.Columns.Add("typeCodeId", typeof(int));
        //    this.SelectSqlData(dataTable, true, " where id = " + idSChmObj.ToString(), null, false, 0);
        //    if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value)
        //    {
        //        if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 546)
        //        {
        //            DataTable dataTable2 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Длина трассы'", idSChmObj));
        //            if (dataTable2.Rows.Count > 0 && dataTable2.Rows[0]["CharValue"] != DBNull.Value)
        //            {
        //                return dataTable2.Rows[0]["CharValue"];
        //            }
        //        }
        //        if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 547 || Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 983)
        //        {
        //            DataTable dataTable3 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Протяженность линии'", idSChmObj));
        //            if (dataTable3.Rows.Count > 0 && dataTable3.Rows[0]["CharValue"] != DBNull.Value)
        //            {
        //                return dataTable3.Rows[0]["CharValue"];
        //            }
        //        }
        //    }
        //    return DBNull.Value;
        //}

        //private object GetIdVoltage(int idSChmObj)
        //{
        //    DataTable dataTable = new DataTable("tSchm_ObjList");
        //    dataTable.Columns.Add("typeCodeId", typeof(int));
        //    base.SelectSqlData(dataTable, true, " where id = " + idSChmObj.ToString(), null, false, 0);
        //    if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value)
        //    {
        //        if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 546)
        //        {
        //            DataTable dataTable2 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Напряжение'", idSChmObj));
        //            if (dataTable2.Rows.Count > 0 && dataTable2.Rows[0]["CharValue"] != DBNull.Value)
        //            {
        //                return dataTable2.Rows[0]["CharValue"];
        //            }
        //        }
        //        if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 547 || Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 983)
        //        {
        //            DataTable dataTable3 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Напряжение'", idSChmObj));
        //            if (dataTable3.Rows.Count > 0 && dataTable3.Rows[0]["CharValue"] != DBNull.Value)
        //            {
        //                return dataTable3.Rows[0]["CharValue"];
        //            }
        //        }
        //    }
        //    return DBNull.Value;
        //}

        //private object GetIdVoltageSeti(int idSChmObj)
        //{
        //    DataTable dataTable = new DataTable("tSchm_ObjList");
        //    dataTable.Columns.Add("typeCodeId", typeof(int));
        //    base.SelectSqlData(dataTable, true, " where id = " + idSChmObj.ToString(), null, false, 0);
        //    if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value && Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 546)
        //    {
        //        DataTable dataTable2 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Рабочее напряжение'", idSChmObj));
        //        if (dataTable2.Rows.Count > 0 && dataTable2.Rows[0]["CharValue"] != DBNull.Value)
        //        {
        //            return dataTable2.Rows[0]["CharValue"];
        //        }
        //    }
        //    return DBNull.Value;
        //}

        //private object GetYearBegEquipment(int idSChmObj)
        //{
        //    DataTable dataTable = new DataTable("tSchm_ObjList");
        //    dataTable.Columns.Add("typeCodeId", typeof(int));
        //    base.SelectSqlData(dataTable, true, " where id = " + idSChmObj.ToString(), null, false, 0);
        //    if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value)
        //    {
        //        if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 546)
        //        {
        //            DataTable dataTable2 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Год ввода в эксплуатацию'", idSChmObj));
        //            if (dataTable2.Rows.Count > 0 && dataTable2.Rows[0]["CharValue"] != DBNull.Value)
        //            {
        //                return dataTable2.Rows[0]["CharValue"];
        //            }
        //        }
        //        if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 547 || Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 983)
        //        {
        //            string where = string.Format("where idObj = {0} and ([CharName] like 'Год ввода в эксплуатацию'\r\nor [CharName] like 'Дата ввода в эксплуатацию') and [CharValue] is not null and [CharValue] <> ''", idSChmObj);
        //            DataTable dataTable3 = base.SelectSqlData("vP_PassportDataReports", true, where);
        //            if (dataTable3.Rows.Count > 0 && dataTable3.Rows[0]["CharValue"] != DBNull.Value)
        //            {
        //                return dataTable3.Rows[0]["CharValue"];
        //            }
        //        }
        //    }
        //    return DBNull.Value;
        //}

        //private object GetYearManufacture(int idSChmObj)
        //{
        //    DataTable dataTable = new DataTable("tSchm_ObjList");
        //    dataTable.Columns.Add("typeCodeId", typeof(int));
        //    base.SelectSqlData(dataTable, true, " where id = " + idSChmObj.ToString(), null, false, 0);
        //    if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value)
        //    {
        //        if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 546)
        //        {
        //            DataTable dataTable2 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Год прокладки'", idSChmObj));
        //            if (dataTable2.Rows.Count > 0 && dataTable2.Rows[0]["CharValue"] != DBNull.Value)
        //            {
        //                return dataTable2.Rows[0]["CharValue"];
        //            }
        //        }
        //        if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 547 || Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 983)
        //        {
        //            DataTable dataTable3 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Год постройки'", idSChmObj));
        //            if (dataTable3.Rows.Count > 0 && dataTable3.Rows[0]["CharValue"] != DBNull.Value)
        //            {
        //                return dataTable3.Rows[0]["CharValue"];
        //            }
        //        }
        //    }
        //    return DBNull.Value;
        //}

        //private object GetIdMark(int idObjList)
        //{
        //    DataTable dataTable = new DataTable("tSchm_ObjList");
        //    dataTable.Columns.Add("typeCodeId", typeof(int));
        //    base.SelectSqlData(dataTable, true, " where id = " + idObjList.ToString(), null, false, 0);
        //    if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["TypeCodeId"] != DBNull.Value)
        //    {
        //        if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 546)
        //        {
        //            DataTable dataTable2 = base.SelectSqlData("tP_Passport", true, string.Format("where idObjList = {0} and [isActive] = '1' and deleted = '0'", idObjList));
        //            if (dataTable2.Rows.Count > 0 && dataTable2.Rows[0]["idEquipment"] != DBNull.Value)
        //            {
        //                return dataTable2.Rows[0]["idEquipment"];
        //            }
        //        }
        //        if (Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 547 || Convert.ToInt32(dataTable.Rows[0]["TypeCodeId"]) == 983)
        //        {
        //            DataTable dataTable3 = base.SelectSqlData("tP_Passport", true, string.Format("where idObjList = {0} and [isActive] = '1' and deleted = '0'", idObjList));
        //            if (dataTable3.Rows.Count > 0 && dataTable3.Rows[0]["idEquipment"] != DBNull.Value)
        //            {
        //                return dataTable3.Rows[0]["idEquipment"];
        //            }
        //        }
        //    }
        //    return DBNull.Value;
        //}

        //private object GetLastDateTest(int idObjList)
        //{
        //    DataTable dataTable = new DataTable("tP_CabTesting");
        //    dataTable.Columns.Add("date", typeof(DateTime));
        //    string str = "";
        //    if (this.dataSetDamage.tJ_Damage.Rows.Count > 0 && this.dataSetDamage.tJ_Damage.Rows[0]["datedoc"] != DBNull.Value)
        //    {
        //        str = " and [date] < '" + Convert.ToDateTime(this.dataSetDamage.tJ_Damage.Rows[0]["datedoc"]).ToString("yyyyMMdd") + "'";
        //    }
        //    base.SelectSqlData(dataTable, true, " where idObjList = " + idObjList.ToString() + str + " and deleted = 0 order by [date] desc", null, false, 0);
        //    if (dataTable.Rows.Count > 0)
        //    {
        //        return dataTable.Rows[0]["Date"];
        //    }
        //    return DBNull.Value;
        //}

        //private object GetTimeRecovery(int idObjList)
        //{
        //    DataTable dataTable = new DataTable("tP_CabOperation");
        //    dataTable.Columns.Add("datecommissioning", typeof(DateTime));
        //    string str = "";
        //    if (this.dataSetDamage.tJ_Damage.Rows.Count > 0 && this.dataSetDamage.tJ_Damage.Rows[0]["datedoc"] != DBNull.Value)
        //    {
        //        str = " and [datecommissioning] > '" + Convert.ToDateTime(this.dataSetDamage.tJ_Damage.Rows[0]["datedoc"]).ToString("yyyyMMdd") + "'";
        //    }
        //    base.SelectSqlData(dataTable, true, " where idObjList = " + idObjList.ToString() + str + " and deleted = 0 order by [datecommissioning]", null, false, 0);
        //    if (dataTable.Rows.Count > 0)
        //    {
        //        return dataTable.Rows[0]["datecommissioning"];
        //    }
        //    return DBNull.Value;
        //}


        #endregion

        private void btnRefreshUploadParentDoc_Click(object sender, EventArgs e)
        {
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
            {
                if (this.dataSetDamage.tJ_Damage.Rows[0]["idParent"] == DBNull.Value)
                {
                    MessageBox.Show("Не выбран документ аварийного события", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Заполнить документ с удалением данных", "Заполнение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    base.DialogResult = DialogResult.Cancel;
                    return;
                }
                // Library.Controls.ControlSelectionLengthComboBox(Controls);

                DataTable dataTable = new DataTable("tJ_Damage");
                dataTable.Columns.Add("dateDoc", typeof(DateTime));
                base.SelectSqlData(dataTable, true, "where id = " + IdParentDocument, null, false, 0);
                if (dataTable.Rows.Count > 0)
                {
                    this.dataSetDamage.tJ_Damage.Rows[0]["DateDoc"] = dataTable.Rows[0]["DateDoc"];
                    this.dtpDateDoc.Value = Convert.ToDateTime(dataTable.Rows[0]["DateDoc"].ToString());
                }
                this.FillDateEndCrashLocal((int)IdParentDocument);
                this.SetBeginCrashMoscow();

                DataTable dataTableJ = new DataTable("tJ_DamageCharacter");
                dataTableJ.Columns.Add("id", typeof(int));
                this.SelectSqlData(dataTableJ, true, "where idDamage = " + IdParentDocument + "", null, false, 0);

                List<int> list = new List<int>();
                foreach (DataRow dataRow in dataTableJ.AsEnumerable())
                {
                    if (dataRow.RowState != DataRowState.Deleted && dataRow["id"] != DBNull.Value)
                    {
                        list.Add(Convert.ToInt32(dataRow["id"]));
                    }
                }
                // this.dataSetDamage.tJ_DamageCharacter.Rows.Remove();
                //DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable
                this.FillWithTableDamageCharacter(list);

                // заполним приложение 1
                this.LoadTableAnnex((int)IdParentDocument);
                // 
                Library.Controls.ControlSelectionLengthComboBox(base.Controls);
                this.FillComboBoxsLastMemberComission(true);
            }

        }

        private void LoadTableAnnex(int IdDocument)
        {
            DateTime dataDoc = dtpDateDoc.Value == null ? Convert.ToDateTime(dtpDateOwner.Value) : Convert.ToDateTime(dtpDateDoc.Value);

            StatementsForME.SendRequestToME sendMe = new StatementsForME.SendRequestToME();
            sendMe.SqlSettings = this.SqlSettings;
            sendMe.IdDocument = (int)IdParentDocument;
            DataTable tableParent = sendMe.LoadDataOneDokument();
            if (tableParent.Rows.Count == 0)
            {
                MessageBox.Show("Из выбранного документа аварийного события не возвращаются данные", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            txtCountPointsSupply.Text = Convert.ToString(tableParent.Rows[0]["tp_total"]);
            txtFeedObjectsList.Text = tableParent.Rows[0]["feed_objects_list"].ToString();
            txtConsumerFullDeenergized.Text = "";
            txtConsumerPartialDeenergized.Text = tableParent.Rows[0]["consumers_partial_deenergized"].ToString();
            txtTSONeighList.Text = tableParent.Rows[0]["tso_neigh_list"].ToString();
            txtPowerTotal.Text = tableParent.Rows[0]["power_total"].ToString();

            txtCountDeEnergizedTP.Text = "0";
            txtCountDeEnergizedRP35.Text = "0";
            txtCountDeEnergizedRP110.Text = "0";
            txtCountDeEnergizedSettlements.Text = "0";
            //txtCountDeEnergizedSocialObjects.Text = "0";
            //txtCountDeEnergizedPopulation.Text = "0";
            //dgvVoltagePowerPlantConsumer

            DailyReportN.DataSet.dsDamage.tJ_DamageDataTable tableParentXML = new DataSet.dsDamage.tJ_DamageDataTable();
            SelectSqlData(tableParentXML, true, " where id = " + this.IdParentDocument.Value.ToString(), null, false, 0);
            if (tableParentXML.Rows.Count > 0 && tableParentXML.Rows[0]["CommentXml"] != DBNull.Value)
            {
                try
                {
                    var CommentXml = System.Xml.Linq.XDocument.Parse(tableParentXML.Rows[0]["CommentXml"].ToString());

//#if SkipFragment==false

                    #region Заполним список абонентов (начало)
                    var resAbnOff = CommentXml.Element("Doc").Element("AbnOff").Descendants("Row");

                    // 1. Проверить есть ли атрибут codeAbonent в таблице resAbnOff
                    // обновим документ родитель (по новой обработке)
                    var resAbnOffOldVormat = resAbnOff.Where(s => s.Attribute("codeAbonent") == null || s.Attribute("idSchmObj") == null || s.Attribute("TariffParentKey") == null);
                    if (resAbnOffOldVormat.Count() != 0) // если не присутствуют атрибуты по новому формату
                    {
                        DataTable tableSchmAbnFull = new DataTable();
                        Reference.Tables.LoadTableSChmAbnFull_2019(tableSchmAbnFull, this.SqlSettings, dataDoc);
                        //tableSchmAbnFull.Select("idAbnobj in (" + list786 + ")");
                        ChangeRowAbnObj(resAbnOffOldVormat, tableSchmAbnFull);
                        // 2. иначе стыкуем привзяки абонента с привязками отключенных объектов
                        // 3. если документ до 2019 года на будет найти рубильник и ячейки у подстанций и стыковать согласно второго шага
                        //// обновим документ родитель
                    }
                    // проверить количество отключенных точек поставки
                    // проверим объекты которые не дозаполнились
                    // обработаем старой обработкой (без привязки к периоду)
                    DataTable tableSchmAbn = new DataTable();
                    if (resAbnOffOldVormat.Count() != 0)
                    {
                        string listOld = String.Join(",", resAbnOffOldVormat.Select(s => s.Attribute("idAbnObj").Value).ToArray());
                        // 1.0 - проверим не используя запрос без привязок ко времени (также по регистрации договоров)
                        Reference.Tables.LoadTableSChmAbnFullNoTime(tableSchmAbn, this.SqlSettings, dataDoc, true, listOld);
                        ChangeRowAbnObj(resAbnOffOldVormat, tableSchmAbn);
                        // 1.1 - пройдем добиванием по справочникам (движухи юридической по объектам не было)
                        if (Reference.Tables.LoadTable(tableSchmAbn, this.SqlSettings, true, " where idAbnObj in (" + listOld + ")", true, "vL_SchmAbnFull2.sql"))
                            ChangeRowAbnObj(resAbnOffOldVormat, tableSchmAbn);
                    }
                    // Надо дозаполнить у объектов поле idSchmObj
                    // проверим заполнение idSchmObj, если реквизит присутствует
                    var resIdSchmObjEmpty = resAbnOff
                        .Where(w => w.Attribute("codeAbonent") != null || w.Attribute("idSchmObj") != null)
                        .Where(w => w.Attribute("idSchmObj").Value == "");// чтобы не подцепить пустые привязки
                    if (resIdSchmObjEmpty.Count() != 0)
                    {
                        string listIdSchmObjEmpty = String.Join(",", resIdSchmObjEmpty.Select(s => s.Attribute("idAbnObj").Value).ToArray());
                        if (Reference.Tables.LoadTable(tableSchmAbn, this.SqlSettings, true, " where idAbnObj in (" + listIdSchmObjEmpty + ")", true, "vL_SchmAbnFull2.sql"))
                            ChangeRowAbnObj(resIdSchmObjEmpty, tableSchmAbn);
                    }

                    // проверяем в глобальном логе
                    // ищем удаленнеы объекты и потерянные привязки
                    // 1.2 - проверим [GES_log].[dbo].[tL_SchmAbn] - найдем привязки по дате  - если то первая привязка снизу
                    // 1.3 - проверим [GES_log].[dbo].[tAbnObjReg] - так как он первым был поставлен на логирование
                    // 1.4 - проверим [GES_log].[dbo].[tAbnObj]
                    #region глобальный лог (начало)
                    if (resAbnOffOldVormat.Count() != 0)
                    {
                        DataTable trc = Reference.Tables.TableClassifier(null);
                        this.SelectSqlData(trc, true);

                        References.TableLog table = new References.TableLog();
                        table.SQLSettings = this.SqlSettings;

                        var listIdAbnObjForLog = resAbnOffOldVormat.Select(s => s.Attribute("idAbnObj").Value).ToList<string>();
                        var resIdAbnObjForLog = resAbnOff.Where(w => listIdAbnObjForLog.Contains(w.Attribute("idAbnObj").Value) == true);

                        // периодические (временные) характеристики объекта абонента
                        if (listIdAbnObjForLog.Count() != 0)
                        {
                            tableSchmAbn = table.Get("tAbnObjReg", dataDoc, listIdAbnObjForLog);
                            if (tableSchmAbn.Rows.Count > 0)
                            {
                                ChangeRowAbnObj(resIdAbnObjForLog, tableSchmAbn, eChangeAttribute.AddEdit);
                                tableSchmAbn.Columns["ConsumerGroup"].ColumnName = "idConsumerGroup";
                                // заполним реквизиты тарифа (idTariff, Category)  
                                foreach (XElement el in resIdAbnObjForLog)
                                {
                                    DataRow rowFind = null;
                                    DataRow[] rowsFind = tableSchmAbn.Select("idAbnObj =  (" + el.Attribute("idAbnObj").Value + ")");
                                    if (rowsFind.Count() != 0)
                                    {
                                        rowFind = rowsFind[0];
                                        DataRow rowTrc;
                                        if (rowFind["idTariff"] != DBNull.Value)
                                        {
                                            rowTrc = tblClassifier.Select("id = " + rowFind["idTariff"].ToString())[0];
                                            el.SetAttributeValue("TarifName", rowTrc["Name"]);
                                            el.SetAttributeValue("TariffParentKey", rowTrc["ParentKey"]);
                                            el.SetAttributeValue("Voltage", rowTrc["Comment"].ToString().Trim());
                                        }
                                        if (rowFind["Category"] != DBNull.Value)
                                        {
                                            rowTrc = tblClassifier.Select("id = " + rowFind["Category"].ToString())[0];
                                            el.SetAttributeValue("CategoryName", rowTrc["Name"]);
                                        }
                                    }
                                    if (el.Attribute("TarifName").Value == "") el.SetAttributeValue("TarifName", "НН");
                                    if (el.Attribute("Voltage").Value == "") el.SetAttributeValue("Voltage", "НН");
                                    if (el.Attribute("CategoryName").Value == "") el.SetAttributeValue("CategoryName", "III");
                                    if (el.Attribute("idConsumerGroup").Value == "") el.SetAttributeValue("idConsumerGroup", 785);
                                    //количество точек учета
                                    string CountPointName = TypeDocDamage == (int)eTypeDocuments.DamageHV ? "CountPoint" : "countPoint";
                                    if (el.Attribute(CountPointName).Value == "") el.SetAttributeValue(CountPointName, 1);

                                }
                            }
                        }
                        // характеристики объекта абонента
                        if (listIdAbnObjForLog.Count() != 0)
                        {
                            tableSchmAbn = table.Get("tAbnObj", dataDoc, listIdAbnObjForLog, "idObj");
                            tableSchmAbn.Columns["idObj"].ColumnName = "idAbnObj";
                            tableSchmAbn.Columns["name"].ColumnName = "nameObj";
                            if (tableSchmAbn.Rows.Count > 0)
                            {
                                ChangeRowAbnObj(resIdAbnObjForLog, tableSchmAbn, eChangeAttribute.AddEdit);
                            }
                        }
                        // заполним характеристики абонентов
                        var listIdAbnForLog = resIdAbnObjForLog.Select(s => s.Attribute("idAbn").Value).ToList<string>();
                        if (listIdAbnForLog.Count() != 0)
                        {
                            tableSchmAbn = table.Get("tAbn", dataDoc, listIdAbnForLog, "id_tAbn");
                            tableSchmAbn.Columns["id_tAbn"].ColumnName = "idAbn";
                            tableSchmAbn.Columns["Name"].ColumnName = "nameAbn";
                            if (tableSchmAbn.Rows.Count > 0)
                            {
                                ChangeRowAbnObj(resIdAbnObjForLog, tableSchmAbn, eChangeAttribute.AddEdit, "idAbn");
                                // заполним реквизиты тарифа (idTariff, Category)  
                                foreach (XElement el in resIdAbnObjForLog)
                                {
                                    if (el.Attribute("TariffParentKey").Value == "" && el.Attribute("typeAbn").Value != "")
                                        if (Array.IndexOf(new int[] { 207, 231, 230 }, Convert.ToInt32(el.Attribute("typeAbn").Value)) > 0)
                                            el.SetAttributeValue("TariffParentKey", ";SKUEE;Tariff;TariffLeg;");
                                        else // 206,253
                                            el.SetAttributeValue("TariffParentKey", ";SKUEE;Tariff;TariffFL;");
                                }
                            }
                        }
                        // заполним сетевую организацию
                        var listIdAbnNetForLog = resIdAbnObjForLog.Select(s => s.Attribute("idAbnNet").Value).ToList<string>();
                        if (listIdAbnNetForLog.Count() != 0)
                        {
                            tableSchmAbn = table.Get("tAbn", dataDoc, listIdAbnNetForLog, "id_tAbn");
                            tableSchmAbn.Columns["id_tAbn"].ColumnName = "idAbnNet";
                            tableSchmAbn.Columns["Name"].ColumnName = "nameAbnNet";
                            if (tableSchmAbn.Rows.Count > 0)
                            {
                                ChangeRowAbnObj(resIdAbnObjForLog, tableSchmAbn, eChangeAttribute.AddEdit, "idAbnNet");
                                foreach (XElement el in resIdAbnObjForLog.Where(w => w.Attribute("idAbnNet").Value == ""))
                                {
                                    el.SetAttributeValue("idAbnNet", "434002");
                                }
                            }
                        }
                        // если нигде не находим , то заполним недостающими атрибутами
                        if (resAbnOffOldVormat.Count() != 0)
                        {
                            ChangeRowAbnObj(resAbnOffOldVormat, null, eChangeAttribute.AddEmpty);
                        }
                    }
                    // заполним оставшиеся привязки
                    if (resIdSchmObjEmpty.Count() != 0)
                    {
                        References.TableLog table = new References.TableLog();
                        table.SQLSettings = this.SqlSettings;

                        tableSchmAbn = table.Get("tL_SchmAbn", dataDoc, resIdSchmObjEmpty.Select(s => s.Attribute("idAbnObj").Value).ToList<string>());
                        if (tableSchmAbn.Rows.Count > 0)
                        {
                            ChangeRowAbnObj(resIdSchmObjEmpty, tableSchmAbn, eChangeAttribute.AddEdit);
                        }
                    }

                    #endregion глобальный (конец)
                    //DataTable dt = Library.XmlParser.XElementToDataTable(resAbnOff);
                    #endregion Заполним список абонентов (конец)

                    #region  количество социально значимых объектов и населения
                    // 786 - это социально значимый объект
                    var resCountDeEnergizedSocialObjects = resAbnOff.Where(w => w.Attribute("idConsumerGroup").Value == "786");
                    txtCountDeEnergizedSocialObjects.Text = resCountDeEnergizedSocialObjects.Count().ToString();

                    // количество населения (будем выбирать по тарифам)
                    var resCountDeEnergizedPopulation = resAbnOff
                                 .Select(s => new { Tariff = s.Attribute("TariffParentKey").Value, Populatuion = Convert.ToInt32(s.Attribute("TariffParentKey").Value.IndexOf("TariffLeg") > 0 ? 10 : 2) })
                                 .GroupBy(g => new { Tariff = g.Tariff })
                                 .Select(s => new { s.Key.Tariff, summa = s.Sum(ss => ss.Populatuion) });

                    var res1 = resAbnOff
                        .Select(s => new { Tariff = s.Attribute("TariffParentKey").Value });
                    var res2 = res1.Select(s => new
                    {
                        Tariff = s.Tariff,
                        Populatuion = Convert.ToInt32(s.Tariff.IndexOf("TariffLeg") > 0 ? 10 :
                                          (s.Tariff.IndexOf("TariffFL") > 0 ||
                                          s.Tariff.ToString() == "") ? 2 : 0)
                    });
                    var res3 = res2.Where(c => c.Tariff.Contains(";SKUEE;Tariff;TariffFL;")
                                            || c.Tariff.Contains(";SKUEE;Tariff;TariffLeg;People;")
                                            || c.Tariff.Contains(";SKUEE;Tariff;TariffLeg;Direct;")
                                            || c.Tariff.Contains(";SKUEE;Tariff;TariffLeg;PeopleNull;"));

                    txtCountDeEnergizedPopulation.Text = res3.Sum(s => s.Populatuion).ToString();
                    #endregion
//#endif
                   
                    SchemeModelN.ElectricModel electricModel = new SchemeModelN.ElectricModel();
                    electricModel.SqlSettings = this.SqlSettings;
                    electricModel.LoadSchema();
//#if SkipFragment==false
                    #region  таблица напряжения
                    var select1 = resAbnOff
                        .Where(w => w.Attribute("codeAbonent") != null || w.Attribute("idSchmObj") != null)
                        .Where(w => w.Attribute("idSchmObj").Value != "");
                    var select = select1.Select(element => new
                    {
                        //el = electricModel.GetElectricObjectById(Convert.ToInt32(s.Attribute("idSchmObj").Value)),
                        VoltageLine = electricModel.GetParamsElectricObjectById(Convert.ToInt32(element.Attribute("idSchmObj").Value), false, true).VoltageLine,
                        Category = element.Attribute("CategoryName").Value,
                        CountPoint = Convert.ToInt32(element.Attribute(TypeDocDamage == Convert.ToInt32(eTypeDocuments.DamageHV) ? "CountPoint" : "countPoint").Value)
                    })
                        ;
                    var groupby = select
                        .GroupBy(g => new { g.VoltageLine, g.Category })
                        .Select(s => new { VoltageLine = s.Key.VoltageLine, Category = s.Key.Category, Summa = s.Sum(sm => sm.CountPoint) });

                    foreach (DataRow row in dataTableVoltagePowerPlantConsumer.Rows)
                    {
                        row["cat1"] = 0; row["cat2"] = 0; row["cat3"] = 0;
                    }
                    foreach (var element in groupby)
                    {
                        DataRow[] hasRows = dataTableVoltagePowerPlantConsumer.Select("Voltage = '" + element.VoltageLine + "'");
                        if (hasRows.Length != 0)
                        {
                            switch (element.Category)
                            {
                                case "I": hasRows[0]["cat1"] = element.Summa; break;
                                case "II": hasRows[0]["cat2"] = element.Summa; break;
                                case "III": hasRows[0]["cat3"] = element.Summa; break;
                            }
                        }
                    }
                    #endregion
//#endif
                    // 4. проверим объекты схемы
                    // 4.1 надо привести наименование объектов схемы в нормальный вид
                    // 4.2 по возможности занести между ячейками кабельные и воздушные линии
                    // надо найти удаленные объекты
                    // по пробовать выдернуть кл и вл (особенно между удаленными подстанциями)
                    var resNodeDgv = CommentXml.Descendants("NodeDgv");
                    if (resNodeDgv.Count() != 0 /*&& txtFeedObjectsList.Text.Trim() == ""*/)
                    {
                        // проверим новый формат отключенных объектов
                        string chkSchmObj = resNodeDgv.ElementAt(0).ToString();
                        if (!chkSchmObj.Contains("6 (6.3) кВ") && !chkSchmObj.Contains("10 (10.5) кВ") && !chkSchmObj.Contains("0.38 кВ") && !chkSchmObj.Contains("0.22 кВ"))
                        {
                            XElement resNodeDgvCopy = new XElement("TransTree");
                            ChangeNodeDgv(resNodeDgv.ElementAt(0), electricModel, resNodeDgvCopy, tableParent.Rows[0]["voltage_lvl"].ToString());
                        }

                        txtFeedObjectsList.Text = String.Join(",", resNodeDgv
                            .GroupBy(g => new { SubName = g.Attribute("SubName").Value })
                            .Select(s => s.Key.SubName).ToArray());
                    }
                    // количество отключенных трансформаторных подстанций 6-10кВ
                    txtCountDeEnergizedTP.Text = resNodeDgv
                        .Where(w => w.Attribute("SubName").ToString().Contains("ТП 10 (10.5)") || w.Attribute("SubName").ToString().Contains("ТП 6 (6.3)"))
                        .GroupBy(g => g.Attribute("idSub").Value)
                        .Count()
                        .ToString();

                    // обновим документ родитель

                    //LibraryTSQL.SqlDataCommand cTSQL = new LibraryTSQL.SqlDataCommand(SqlSettings);
                    //cTSQL.UpdateSqlData(tableParentXML, "[CommentXml] = '" + CommentXml.ToString() + "'", " [id] = " + this.IdParentDocument.Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
        }
        private enum eChangeAttribute
        {
            /// <summary>
            /// добавить атрибут и заполнить данными, если атрибут есть то не заполняем 
            /// (атрибуты создаются на основании колонок таблицы )
            /// </summary>
            Add = 1,
            /// <summary>
            /// изменить (обновить) действующий атрибут и добавить его, если атрибута нет
            /// (атрибуты создаются на основании колонок таблицы )
            /// </summary>
            AddEdit = 2,
            /// <summary>
            /// ни чего не делать
            /// </summary>
            No = 0,
            /// <summary>
            /// добавить атрибут не используя таблицу (строку) и если его нет элементе и заполнить пустыми данными
            /// </summary>
            AddEmpty = 4
        }
        private static void CreateAttributeXML(XElement el, DataRow rwFind, string NameAttribute, eChangeAttribute ChangeAttribute = eChangeAttribute.Add)
        {
            // если атрибут присутствует, то данные не заполняются
            if (ChangeAttribute == eChangeAttribute.Add && el.Attribute(NameAttribute) == null)
            {
                if (rwFind.Table.Columns.Contains(NameAttribute) == true)
                    el.SetAttributeValue(NameAttribute, rwFind[NameAttribute]);
            }
            else if (ChangeAttribute == eChangeAttribute.AddEdit)
            {
                if (el.Attribute(NameAttribute) == null || el.Attribute(NameAttribute).Value == "")
                    if (rwFind.Table.Columns.Contains(NameAttribute) == true)
                        el.SetAttributeValue(NameAttribute, rwFind[NameAttribute]);
                    else
                        el.SetAttributeValue(NameAttribute, "");
            }
            else if (ChangeAttribute == eChangeAttribute.AddEmpty)
                if (el.Attribute(NameAttribute) == null)
                    el.SetAttributeValue(NameAttribute, "");
        }
        /// <summary>
        /// обновим реквизиты отключенных объектов абонентов
        /// </summary>
        /// <param name="xElement"></param>
        /// <param name="table"></param>
        private static void ChangeRowAbnObj(IEnumerable<XElement> xElement, DataTable table, eChangeAttribute isCreateAttribute = eChangeAttribute.Add, string PrimaryColumn = "idAbnObj")
        {
            try
            {
                foreach (XElement el in xElement)
                {
                    DataRow rowFind;
                    if (table != null && isCreateAttribute != eChangeAttribute.AddEmpty)
                    {
                        DataRow[] rowsFind = table.Select(PrimaryColumn + " =  (" + el.Attribute(PrimaryColumn).Value + ")");
                        if (rowsFind.Count() == 0) continue;

                        rowFind = rowsFind[0];
                    }
                    else
                        rowFind = null;
                    // если атрибута нет и найдена строка, то создаем атрибут
                    // иначе если есть разршение на создание атибута - создаем его с пустым значенем
                    CreateAttributeXML(el, rowFind, "codeAbonent", isCreateAttribute);
                    CreateAttributeXML(el, rowFind, "idAbn", isCreateAttribute);
                    CreateAttributeXML(el, rowFind, "nameAbn", isCreateAttribute);
                    CreateAttributeXML(el, rowFind, "typeAbn", isCreateAttribute);
                    CreateAttributeXML(el, rowFind, "nameObj", isCreateAttribute);
                    CreateAttributeXML(el, rowFind, "CategoryName", isCreateAttribute);
                    CreateAttributeXML(el, rowFind, "TarifName", isCreateAttribute);
                    CreateAttributeXML(el, rowFind, "Voltage", isCreateAttribute);
                    CreateAttributeXML(el, rowFind, "PowerSet", isCreateAttribute);
                    CreateAttributeXML(el, rowFind, "CountPoint", isCreateAttribute);
                    CreateAttributeXML(el, rowFind, "CommentODS", isCreateAttribute);
                    CreateAttributeXML(el, rowFind, "idAbnNet", isCreateAttribute);
                    CreateAttributeXML(el, rowFind, "nameAbnNet", isCreateAttribute);
                    CreateAttributeXML(el, rowFind, "idSchmObj", isCreateAttribute);

                    CreateAttributeXML(el, rowFind, "TariffParentKey", isCreateAttribute);
                    CreateAttributeXML(el, rowFind, "idConsumerGroup", isCreateAttribute);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }
        /// <summary>
        /// обновим наименования отключенных объектов схемы и добавим недостающие
        /// </summary>
        /// <param name="RootNode">Корневой узел</param>
        /// <param name="electricModel">Модель схемы</param>
        private void ChangeNodeDgv(XElement RootNode, SchemeModelN.ElectricModel electricModel, XElement RootNodeCopy, string VoltageLine = "")
        {
            XAttribute idSub = RootNode.Attribute("idSub");
            var ElectricSub = electricModel.GetParamsElectricObjectById(Convert.ToInt32(idSub.Value), false, true);
            string ElectricSubName = ElectricSub.ElectricSubName;
            if (ElectricSub.VoltageSub != null) VoltageLine = ElectricSub.VoltageSub;

            if (ElectricSubName == null) ElectricSubName = "ПС " + VoltageLine + " кВ " + RootNode.Attribute("SubName").Value;

            RootNode.SetAttributeValue("SubName", ElectricSubName);

            //////////xElemLines.Elements().ElementAt(0)
            ////////var xElem1 = new XElement(RootNode.Name.ToString(), RootNode.Attributes());
            ////////((XNode)RootNodeCopy.DescendantsAndSelf().LastOrDefault()).AddAfterSelf(xElem1);

            //////////RootNodeCopy.DescendantsAndSelf().LastOrDefault().Add(xElem1);
            //////////RootNodeCopy.DescendantsAndSelf().LastOrDefault().AddAfterSelf(new XElement(RootNode.Name, RootNode.Attributes()));

            //txtFeedObjectsList.Text = txtFeedObjectsList.Text + "" + ElectricSubName + ", ";
            // что делать кабелями 0,4кв после подстанций????
            #region Ищем промежуточные объекты 
            // (между двумя ячейками подстанций - подстанций в промежутке нет)
            // с узла у которого уже есть родитель (у родителя есть атрибуты)
            //if (false)
            if (RootNode.Parent.HasAttributes)
            {
                int idCellEnd = Convert.ToInt32(RootNode.Attribute("idCell").Value);
                int idBusEnd = Convert.ToInt32(RootNode.Attribute("idBus").Value);
                int idSubEnd = Convert.ToInt32(RootNode.Attribute("idSub").Value);
                objCellSchm CellEnd = new objCellSchm(idSubEnd, idBusEnd, idCellEnd);

                int idCellBegin = Convert.ToInt32(RootNode.Parent.Attribute("idCell").Value);
                int idBusBegin = Convert.ToInt32(RootNode.Parent.Attribute("idBus").Value);
                int idSubBegin = Convert.ToInt32(RootNode.Parent.Attribute("idSub").Value);
                objCellSchm CellBegin = new objCellSchm(idSubBegin, idBusBegin, idCellBegin);

                List<ElectricRelation> listRelation = new List<ElectricRelation>();

                GetWayRelations(CellBegin, CellEnd, listRelation, electricModel);

                if (listRelation.Any(a => a.Parent is ElectricLine))
                {
                    // переименуем кабельные линии (которые находятся вне подстанции)
                    var eLines = listRelation.Where(ss => ((ElectricLine)ss.Parent).IsCell() == false).Select(s => (ElectricLine)s.Parent);
                    // занесем линии в xml, если цепочкой ->> то подчинением
                    XElement xElemLines = new XElement("xElemLines");
                    foreach (var elem in eLines)
                    {
                        string ElectricLineName = electricModel.GetParamsElectricObjectById(Convert.ToInt32(elem.Id), false, true).ElectricLineName;

                        XElement xElem = new XElement("NodeDgv",
                            new XAttribute("SubName", ElectricLineName),
                            new XAttribute("idSub", elem.Id.ToString()));

                        xElemLines.DescendantsAndSelf().LastOrDefault().Add(xElem);
                    }
                    if (xElemLines != null)
                    {
                        //var RootNodeParent = RootNode.Parent;
                        //int PositionRootNodeNew = xElemLines.Descendants().Count();

                        XElement RootNodeNew = new XElement(RootNode);
                        ChangeNodeDgv(RootNodeNew.Elements().ElementAt(0), electricModel, RootNodeCopy, VoltageLine);

                        xElemLines.Descendants().LastOrDefault().Add(RootNodeNew);
                        ((XNode)RootNode).AddBeforeSelf(xElemLines.Elements().ElementAt(0));

                        //RootNode.Remove();
                        RootNode.SetAttributeValue("Delete", true);
                        //RootNode = RootNodeParent.Descendants().ElementAt(PositionRootNodeNew);
                    }
                }
            }
            #endregion
            if (RootNode.HasElements)
            {
                //txtFeedObjectsList.Text = txtFeedObjectsList.Text + "1." + SubStation.ElectricSubName + "\r\n";
                foreach (XElement elem in RootNode.Descendants())
                {
                    ChangeNodeDgv(elem, electricModel, RootNodeCopy, VoltageLine);
                }
            }
            //else
            //{
            //    //txtFeedObjectsList.Text = txtFeedObjectsList.Text + "2." + SubStation.ElectricSubName + "\r\n";
            //}
        }

        private struct objCellSchm
        {
            public int idSub,idBus,idCell;
            public objCellSchm(int idSub, int idBus, int idCell)
            {
                this.idSub = idSub;
                this.idBus = idBus;
                this.idCell = idCell;
            }
        }
        /// <summary>
        /// Вернуть список линии между подстациями (ячейками);
        /// между точками только линии - подстанций недолжно быть
        /// </summary>
        /// <param name="pointsBegins">точки начала движения</param>
        /// <param name="pointsEnds">точки конца движения</param>
        /// <param name="listRelation">список собранных связей</param>\
        /// <param name="isGetCell">флаг возврата ячеек в списке связей</param>\
        private void GetWayRelations(objCellSchm CellBegin, objCellSchm CellEnd,  List<ElectricRelation> listRelation, SchemeModelN.ElectricModel electricModel, bool isGetCell = false)
        {
            ElectricLine eCellEnd = (ElectricLine)electricModel.GetElectricObjectById(CellEnd.idCell);
            ElectricLine eCellBegin = (ElectricLine)electricModel.GetElectricObjectById(CellBegin.idCell);

            // находим точки ячеек лежащие на шинах
            var PointsEnds = eCellEnd.Ends.Where(w => w.Parent != null).Where(w => w.Parent.Id == CellEnd.idBus);
            var PointsBegins = eCellBegin.Ends.Where(w => w.Parent != null).Where(w => w.Parent.Id == CellBegin.idBus);

            // проверить, принадлежат ли точки начала и конца одной подстанции
            if (CellBegin.idSub == CellEnd.idSub)
            {
                foreach (var pointsB in PointsBegins)
                {
                    //GetWayRelationsSub(pointsB, PointsEnds, listRelation);
                }
            }
            else
                foreach (var points in PointsBegins)
                {
                    GetWayRelations(points, PointsEnds, listRelation);
                }
        }
        /// <summary>
        /// движение от точки до точки 
        /// внутри подстанции
        /// </summary>
        /// <param name="Point">начало</param>
        /// <param name="pointsEnds">список окончаний</param>
        /// <param name="listRelation"></param>
        private static void GetWayRelationsSub(ElectricPoint pointsBegs, IEnumerable<ElectricPoint> pointsEnds, List<ElectricRelation> listRelation)
        {
            if (pointsBegs.Parent is ElectricBus && pointsBegs.Relations != null)
            {
                var PointsBegins = pointsBegs.Parent.ChildObjects.Where(w => w != pointsBegs && w is ElectricPoint).Select(s => (ElectricPoint)s);
                foreach (var points in PointsBegins)
                {
                    /*если вся цепочка уходит за подстанцию, то ее не включаем*/
                    GetWayRelations(points, pointsEnds, listRelation);
                }
            }
            if (pointsEnds == pointsBegs) return;
        }

        /// <summary>
        /// движение от точки до точек 
        /// подстанции неучитываются (вылетает программа)
        /// </summary>
        /// <param name="Point">начало</param>
        /// <param name="pointsEnds">список окончаний</param>
        /// <param name="listRelation"></param>
        private static void GetWayRelations(ElectricPoint Point, IEnumerable<ElectricPoint> pointsEnds, List<ElectricRelation> listRelation)
        {
            if (pointsEnds.Contains(Point)) return;
            foreach (ElectricRelation electricRelation in Point.Relations)
            {
                if (!listRelation.Contains(electricRelation))
                {
                    ElectricPoint electricPoint = (electricRelation.SourcePoint == Point) ? electricRelation.DestPoint : electricRelation.SourcePoint;
                    if (electricPoint != Point)
                    {
                        
                        listRelation.Add(electricRelation);
                        GetWayRelations(electricPoint, pointsEnds, listRelation);
                        /*Здесь дожны переходить в GetWayRelationsSub*/
                        //GetWayRelationsSub(electricPoint, pointsEnds, listRelation);
                    }
                }
            }
        }





        /// <summary>
        /// заполним дополнительные таблицы (приложение и персонал)
        /// уже созданного документа
        /// </summary>
        private void FillDateTableAdd(DataTable tableTo, string ColumnName)
        {
            if (this.GetIdDocument() != null)
            {
                if (this.dataSetDamage.tJ_DamageActDetection.Rows.Count > 0 && this.dataSetDamage.tJ_DamageActDetection.Rows[0][ColumnName] != DBNull.Value)
                {
                    string strXML = this.dataSetDamage.tJ_DamageActDetection.Rows[0][ColumnName].ToString();
                    if (!string.IsNullOrEmpty(strXML))
                    {
                        tableTo.ReadXml(new StringReader(strXML));
                        foreach (DataRow row in tableTo.Rows)
                        {
                            System.Windows.Forms.Control ctrl = Library.Controls.GetName(this, (string)row[0]);
                            ctrl.Text = (string)row[1];
                        }
                    }
                }
            }
        }
        /// <summary>
        /// заполним дополнительные таблицы (приложение и персонал)
        /// уже созданного документа (копия datasetcrash сохранена)
        /// </summary>
        private void FillDateTableAdd(string ColumnNameDataSet)
        {
            if (this.IdDocument != null)
            {
                if (this.dataSetDamage.tJ_DamageActDetection.Rows.Count > 0 && this.dataSetDamage.tJ_DamageActDetection.Rows[0][ColumnNameDataSet] != DBNull.Value)
                {
                    string strXML = this.dataSetDamage.tJ_DamageActDetection.Rows[0][ColumnNameDataSet].ToString();
                    if (!string.IsNullOrEmpty(strXML))
                    {
                        System.Data.DataSet ds = new System.Data.DataSet();
                        try
                        {
                            ds.ReadXml(new StringReader(strXML));
                        }
                        catch
                        {
                            return;
                        }
                        // 1. Приложение (Annex)
                        FillControlForms(ds.Tables["dataTableAnnex"]);
                        // 2. Уровни напряжений энергопринимающих установок (dataTableVoltagePowerPlantConsumer)
                        try
                        {
                            if (ds.Tables["dataTableVoltagePowerPlantConsumer"].Rows.Count > 0)
                                foreach (DataRow copyRow in ds.Tables["dataTableVoltagePowerPlantConsumer"].Rows)
                                    this.dataSetCrash.Tables["dataTableVoltagePowerPlantConsumer"].ImportRow(copyRow);
                        }
                        catch { }
                        // 3. Персонал (dataTablePersonal)
                        foreach (DataRow copyRow in ds.Tables["dataTablePersonal"].Rows)
                        {
                            try
                            {
                                this.dataSetCrash.Tables["dataTablePersonal"].ImportRow(copyRow);
                            }
                            catch { }
                        }
                    }
                }
            }
            // если таблица напряжений пустая, то надо ее создать
            if (this.dataSetCrash.Tables["dataTableVoltagePowerPlantConsumer"].Rows.Count == 0)
            {
                FillTableVoltagePowerPlantConsumer();
            }
        }
        private void FillControlForms(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                System.Windows.Forms.Control ctrl = Library.Controls.GetName(this, (string)row[0]);
                ctrl.Text = (string)row[1];
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            string Name = ((Control)sender).Name;
            string Value = ((Control)sender).Text;

            DataRow[] hasRows = dataSetCrash.Tables["dataTableAnnex"].Select("Name = '" + Name + "'");
            if (hasRows.Length != 0)
            {
                hasRows[0]["Value"] = Value;
            }
            else
            {
                DataRow row = this.dataSetCrash.Tables["dataTableAnnex"].NewRow();
                row["Name"] = Name;
                row["Value"] = Value;
                this.dataSetCrash.Tables["dataTableAnnex"].Rows.Add(row);
            }
        }
        /// <summary>
        /// заполнение таблицы напряжения для приложения 
        /// </summary>
        private void FillTableVoltagePowerPlantConsumer()
        {
            DataTable tableVoltageLevels = this.tblClassifier.Copy();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tableVoltageLevels;
            bindingSource.Filter = "ParentKey like ';VoltageLevels;%'";
            bindingSource.Sort = "value";

            foreach (var row in bindingSource.List)
            {
                DataRow rowr = dataTableVoltagePowerPlantConsumer.NewRow();
                rowr["Voltage"] = ((System.Data.DataRowView)row).Row["Comment"];
                dataTableVoltagePowerPlantConsumer.Rows.Add(rowr);
            }

        }
        /// <summary>
        /// заполним списки напряжений и напряжения для приложения
        /// </summary>
        private void FillComboBoxVoltageLevels()
        {
            DataTable tableVoltageLevels = this.tblClassifier.Copy();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tableVoltageLevels;
            bindingSource.Filter = "ParentKey like ';VoltageLevels;%'";
            bindingSource.Sort = "value";
            this.ColumnVoltage.DisplayMember = "name";
            this.ColumnVoltage.ValueMember = "comment";
            this.ColumnVoltage.DataSource = bindingSource;
            // если новый документ то формиркем пустую таблицу
            //if (this.IdDocument == null)// || dataTableVoltagePowerPlantConsumer.Rows.Count == 0)
            //{
            //    foreach (var row in bindingSource.List)
            //    {
            //        DataRow rowr = dataTableVoltagePowerPlantConsumer.NewRow();
            //        rowr["Voltage"] = ((System.Data.DataRowView)row).Row["Comment"];
            //        dataTableVoltagePowerPlantConsumer.Rows.Add(rowr);
            //    }
            //}
        }
        #region Personal
        // добавить персонал (забиваем карточку левую)
        private void tspAddPersonal_Click(object sender, EventArgs e)
        {
            ReferenceWorker.FormWorkerAddEdit frm = new ReferenceWorker.FormWorkerAddEdit(-1, -1);
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // надо проверить на совпадение ФИО и подразделения
                FillSelectPersonal(frm.idPersonalSelect);
            };
        }

        private void tsbDelPersonal_Click(object sender, EventArgs e)
        {
            if (this.dgvPersonal.CurrentRow != null)
            {
                if (MessageBox.Show("Вы  действительно хотите удалить выбранную строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.dgvPersonal.Rows.Remove(this.dgvPersonal.CurrentRow);
                }
            }
        }
        // добавить персонал из имеющегося списка
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ReferenceWorker.FormWorkersSelect frm = new ReferenceWorker.FormWorkersSelect();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                FillSelectPersonal(frm.idPersonalSelect);
            };
        }
        /// <summary>
        /// заполним список персонала виновного в аварии
        /// </summary>
        /// <param name="idPersonalSelect"></param>
        void FillSelectPersonal(int idPersonalSelect)
        {
            if (idPersonalSelect == -1) return;
            ReferenceWorker.DataSetWorker dsWorker = new ReferenceWorker.DataSetWorker();
            string where = " where id = " + idPersonalSelect;
            this.SelectSqlData(dsWorker, dsWorker.tR_Worker, true, where);

            DateTime data = dtpDateDoc.Value == null ? Convert.ToDateTime(dtpDateOwner.Value) : Convert.ToDateTime(dtpDateDoc.Value);
            DataRow row = dataSetCrash.Tables["dataTablePersonal"].NewRow();
            row["idPersonal"] = idPersonalSelect;
            row["Personal"] = dsWorker.tR_Worker.Rows[0]["F"].ToString().Trim() + ' ' + dsWorker.tR_Worker.Rows[0]["I"].ToString().Trim() + ' ' + dsWorker.tR_Worker.Rows[0]["O"].ToString().Trim();
            row["idPersonal"] = idPersonalSelect;

            this.SelectSqlData(dsWorker, dsWorker.tR_Classifier, true, " where (parentKey in (';StatusWorker;', ';ReasonWorker;', ';Contact;')  or parentKey LIKE '%;GroupWorker;%') and isgroup = 0");
            // получим должность и место работы
            this.SelectSqlData(dsWorker, dsWorker.tJ_StatusWorker, true, " where worker = " + idPersonalSelect + " and Period <= '" + data.ToString("yyyy-MM-dd HH:mm:ss") + "' and JobTitle is not null and Division is not null order by Period desc");
            if (dsWorker.tJ_StatusWorker.Rows.Count > 0)
            {
                row["idFunction"] = dsWorker.tJ_StatusWorker.First().JobTitle;
                row["idPlaceWork"] = dsWorker.tJ_StatusWorker.First().Division;
            }
            else
            {
                var JobTitle = dsWorker.tR_Worker.First()["JobTitle"];
                row["idFunction"] = JobTitle == DBNull.Value ? -1 : JobTitle;

                var DivisionCurrent = dsWorker.tR_Worker.First()["DivisionCurrent"];
                row["idPlaceWork"] = DivisionCurrent == DBNull.Value ? -1 : dsWorker.tR_Worker.First()["DivisionCurrent"];
            }
            if ((int)row["idFunction"] > 0)
            {
                this.SelectSqlData(dsWorker, dsWorker.k_tR_JobTitle, true, " where id = " + row["idFunction"]);
                row["Function"] = dsWorker.k_tR_JobTitle.Rows[0]["Description"];
            }

            if ((int)row["idPlaceWork"] > 0)
            {
                this.SelectSqlData(dsWorker, dsWorker.tR_Division, true, " where id = " + row["idPlaceWork"]);
                row["PlaceWork"] = dsWorker.tR_Division.Rows[0]["Description"];
            }

            this.SelectSqlData(dsWorker, dsWorker.tR_WorkerContact, true, "where worker = " + idPersonalSelect);
            try
            {
                var sel = dsWorker.tR_WorkerContact.AsEnumerable().Where(w => (int)w["type"] == 2352).First();
                row["Education"] = sel.Description;
                row["Specialty"] = sel.Comment.ToString().Trim();
            }
            catch { }

            this.SelectSqlData(dsWorker, dsWorker.tJ_GroupElectricalWorker, true, "where Idworker = " + idPersonalSelect + " and DateBegin <= '" + data.ToString("yyyy-MM-dd HH:mm:ss") + "' order by DateBegin desc");
            if (dsWorker.tJ_GroupElectricalWorker.Rows.Count > 0)
            {
                row["DateLastCheck"] = dsWorker.tJ_GroupElectricalWorker.AsEnumerable().Select(s => s.DateBegin).First();
                row["Function"] += (row["Function"] == DBNull.Value ? "" : ", ") + dsWorker.tJ_GroupElectricalWorker.AsEnumerable().Select(s => s.GroupElectrical).First() + " гр.";
            }

            row["WorkExperience"] = 0;
            if (dsWorker.tJ_StatusWorker.Rows.Count > 0)
            { 
                int age = data.Year - Convert.ToDateTime(dsWorker.tJ_StatusWorker.First().Period).Year;
                row["WorkExperience"] = age;
            }

            this.dataSetCrash.Tables["dataTablePersonal"].Rows.Add(row);

            if (dgvPersonal.RowCount > 0)
                this.dgvPersonal.CurrentCell = this.dgvPersonal.Rows[this.dgvPersonal.RowCount - 1].Cells["PersonalColumn"];

        }
        #endregion
        #region Работа с прикрепляемыми файлами (приложениями)
        private void toolBtnAddDoc_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                    {
                        DataRow dataRow = this.dataSetDamage.tJ_DamageDoc.NewRow();
                        dataRow["idDamage"] = this.IdDocument;
                        dataRow["Document"] = File.ReadAllBytes(openFileDialog.FileNames[i]);
                        dataRow["FileName"] = Path.GetFileName(openFileDialog.FileNames[i]);
                        this.dataSetDamage.tJ_DamageDoc.Rows.Add(dataRow);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void toolBtnDelDoc_Click(object sender, EventArgs e)
        {
            if (this.dgvDocs.CurrentRow != null)
            {
                Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
                this.dgvDocs.Rows.Remove(this.dgvDocs.CurrentRow);
                return;
            }
            MessageBox.Show("Не выбрано ни одного файла");
        }

        private void toolBtnViewDoc_Click(object sender, EventArgs e)
        {
            if (this.dgvDocs.CurrentRow == null)
            {
                return;
            }
            int num = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
            byte[] array = (byte[])this.dataSetDamage.tJ_DamageDoc.FindByid(num)["Document"];
            string text = Path.GetTempFileName();
            text = Path.ChangeExtension(text, Path.GetExtension(this.dataSetDamage.tJ_DamageDoc.FindByid(num)["FileName"].ToString()));
            FileStream fileStream = File.Create(text);
            fileStream.Write(array, 0, array.Length);
            fileStream.Close();
            new Process
            {
                StartInfo =
                {
                    FileName = text,
                    UseShellExecute = true
                }
            }.Start();
        }

        private void toolBtnSaveDoc_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
                string text = this.dgvDocs.CurrentRow.Cells[this.fileNameDataGridViewTextBoxColumn.Name].Value.ToString();
                string extension = Path.GetExtension(text);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "(*" + extension + ")|*" + extension;
                saveFileDialog.FileName = text;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] array = (byte[])this.dataSetDamage.tJ_DamageDoc.FindByid(num)["Document"];
                    FileStream fileStream = File.Create(saveFileDialog.FileName);
                    fileStream.Write(array, 0, array.Length);
                    fileStream.Close();
                    MessageBox.Show("Файл успешно сохранен", "Сохранение");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvDocs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDocs_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (this.dgvDocs.RowCount > 0 && this.dgvDocs[this.fileNameDataGridViewTextBoxColumn.Name, e.RowIndex].Value != null && e.ColumnIndex == this.dgvDocs.Columns[this.ColumnImage.Name].Index)
            {
                Icon icon = FileInfo.IconOfFile(this.dgvDocs[this.fileNameDataGridViewTextBoxColumn.Name, e.RowIndex].Value.ToString());
                e.Value = icon.ToBitmap();
            }
        }

        private void dgvDocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDocs.CurrentRow == null)
            {
                return;
            }
            int num = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
            if (e.ColumnIndex == this.dgvDocs.Columns[this.fileNameDataGridViewTextBoxColumn.Name].Index)
            {
                byte[] array = (byte[])this.dataSetDamage.tJ_DamageDoc.FindByid(num)["Document"];
                string text = Path.GetTempFileName();
                text = Path.ChangeExtension(text, Path.GetExtension(this.dataSetDamage.tJ_DamageDoc.FindByid(num)["FileName"].ToString()));
                FileStream fileStream = File.Create(text);
                fileStream.Write(array, 0, array.Length);
                fileStream.Close();
                new Process
                {
                    StartInfo =
                    {
                        FileName = text,
                        UseShellExecute = true
                    }
                }.Start();
            }
        }
        /// <summary>
        /// сохранение прикрепленных файлов
        /// </summary>
        private void UpdateRepairDoc()
        {
            foreach (DataRow dataRow in this.dataSetDamage.tJ_DamageDoc)
            {
                if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
                {
                    dataRow["idDamage"] = this.IdDocument;
                    dataRow.EndEdit();
                }
            }

            this.InsertSqlData(this.dataSetDamage, this.dataSetDamage.tJ_DamageDoc);
            base.UpdateSqlData(this.dataSetDamage, this.dataSetDamage.tJ_DamageDoc);
            base.DeleteSqlData(this.dataSetDamage, this.dataSetDamage.tJ_DamageDoc);
            this.dataSetDamage.tJ_DamageDoc.AcceptChanges();
        }
#endregion
        private void chkMemberComissionSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (sender.GetType() != typeof(CheckBox)) return;
            this.isChangedData = true;
            if (((CheckBox)sender).Checked)
            {
                if (tabControl1.Controls.Find(tabPageSpecialOpinion.Name, false).Count() == 0)
                    tabControl1.Controls.Add(tabPageSpecialOpinion);
                CheckBox chekBox = (CheckBox)sender;
                if (chekBox == chkChairmanSpecial) { this.txtChairmanSpecial.Enabled = true; }
                if (chekBox == chkMemberComissionSpecial1) { this.txtMemberPostSpecial1.Enabled = true; }
                if (chekBox == chkMemberComissionSpecial2) { this.txtMemberPostSpecial2.Enabled = true; }
                if (chekBox == chkMemberComissionSpecial3) { this.txtMemberPostSpecial3.Enabled = true; }
                if (chekBox == chkMemberComissionSpecial4) { this.txtMemberPostSpecial4.Enabled = true; }
                if (chekBox == chkMemberComissionSpecial5) { this.txtMemberPostSpecial5.Enabled = true; }
            }
            else if (!((CheckBox)sender).Checked)
            {
                if (tabControl1.Controls.Find(tabPageSpecialOpinion.Name, false).Count() != 0)
                    if (tabPageComission.Controls.OfType<CheckBox>().AsEnumerable().Where(w => w.Checked).Count() == 0)
                        tabControl1.Controls.Remove(tabPageSpecialOpinion);

                CheckBox chekBox = (CheckBox)sender;
                if (chekBox == chkChairmanSpecial) {this.txtChairmanSpecial.Text = ""; this.txtChairmanSpecial.Enabled = false; }
                if (chekBox == chkMemberComissionSpecial1) { this.txtMemberPostSpecial1.Text = ""; this.txtMemberPostSpecial1.Enabled = false; }
                if (chekBox == chkMemberComissionSpecial2) { this.txtMemberPostSpecial2.Text = ""; this.txtMemberPostSpecial2.Enabled = false; }
                if (chekBox == chkMemberComissionSpecial3) { this.txtMemberPostSpecial3.Text = ""; this.txtMemberPostSpecial3.Enabled = false; }
                if (chekBox == chkMemberComissionSpecial4) { this.txtMemberPostSpecial4.Text = ""; this.txtMemberPostSpecial4.Enabled = false; }
                if (chekBox == chkMemberComissionSpecial5) { this.txtMemberPostSpecial5.Text = ""; this.txtMemberPostSpecial5.Enabled = false; }
            
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DataTable dataTableJ = new DataTable("tJ_DamageCharacter");
            dataTableJ.Columns.Add("id", typeof(int));
            this.SelectSqlData(dataTableJ, true, "where idDamage = " + IdParentDocument + "", null, false, 0);

            List<int> list = new List<int>();
            foreach (DataRow dataRow in dataTableJ.AsEnumerable())
            {
                if (dataRow.RowState != DataRowState.Deleted && dataRow["id"] != DBNull.Value)
                {
                    list.Add(Convert.ToInt32(dataRow["id"]));
                }
            }

            this.FillWithTableDamageCharacter(list);
        }
    }
}
