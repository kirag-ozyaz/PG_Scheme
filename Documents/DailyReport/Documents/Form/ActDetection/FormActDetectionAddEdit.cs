using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using ControlsLbr.ReportViewerRus;
using DataSql;
using DailyReport.DataSets;
//using Documents.Properties;
using FormLbr;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
/// <summary>
/// Акт расследования
/// c0002d6
/// c0000bf
/// qjw4Q69sZWR6iDWpTIv
/// Form86
/// </summary>
namespace DailyReport.JournalActDetection
{
    public class FormActDetectionAddEdit : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private BindingSource bindingSource_3;
        /// <summary>
        /// флаг изменения данных в реквизитах (контролах на форме)
        /// </summary>
        private bool isChangedData;
        //private bool flagViewDoc;
        private Button buttonSave;
        private Button buttonCancel;
        private Button buttonChooseParentDamage;
        private Button btnOpenParentDamage;
        private Button btnRefreshDataEndCrash;
        private Button btnRefreshDataBeginCrash;
        private CheckBox chkCrash;
        private CheckBox chkNoOff;
        private CheckBox chkAutoProtect;
        private CheckBox chkApply;
        private ComboBoxReadOnly cmbDivision;
        private ComboBoxReadOnly cmbCompiler;
        private ComboBoxReadOnly cmbClassifierDamage;
        private ComboBoxReadOnly cmbReasonBeginCrash;
        private ComboBoxReadOnly cmbNodeDetail;
        private ComboBoxReadOnly cmbVoltage;
        private ComboBoxReadOnly cmbParameters;
        private ComboBoxReadOnly cmbMarkEquipment;
        private ComboBoxReadOnly cmbVoltageSeti;
        private ComboBoxReadOnly cmbClauseWork;
        private ComboBoxReadOnly cmbMaterial;
        private ComboBoxReadOnly cmbNeutralState;
        private ComboBoxReadOnly cmbOrg;
        private ComboBoxReadOnly cmbReasonDamage;
        private ComboBoxReadOnly cmbCharacterDamage;
        private ComboBoxReadOnly cmbChairman;
        private ComboBoxReadOnly cmbMemberComission3;
        private ComboBoxReadOnly cmbMemberComission2;
        private ComboBoxReadOnly cmbMemberComission1;
        private ComboBoxReadOnly cmbWorkerApply;
        private ComboBoxReadOnly cmbMemberComission5;
        private ComboBoxReadOnly cmbMemberComission4;
        private ComboBoxReadOnly cmbSignCrash;
        private ComboBoxReadOnly cmbTypeEquipment;
        private ComboBoxReadOnly cmbReasonCrashEquipment;
        private ComboBoxReadOnly cmbReasonCrash;
        private ComboBoxReadOnly cmbStatusBeforeCrash;
        private ComboBoxReadOnly cmbStatusCurrentCrash;
        private ComboBoxReadOnly cmbFault;
        private DataColumn idNoCrashMeasure;
        private DataColumn dateComplete;
        private DataColumn dataColumn_10;
        private DataColumn dataColumn_11;
        private DataColumn dataColumn_12;
        private DataColumn dataColumn_13;
        private DataColumn dataColumn_14;
        private DataColumn dataColumn_15;
        private DataColumn dataColumn_16;
        private DataColumn dataColumn_17;
        private DataColumn dataColumn_18;
        private DataColumn dataColumn_19;
        private DataColumn idOrg;
        private DataColumn dataColumn_20;
        private DataColumn dataColumn_21;
        private DataColumn dataColumn_22;
        private DataColumn dataColumn_23;
        private DataColumn dataColumn_24;
        private DataColumn dataColumn_25;
        private DataColumn dataColumn_26;
        private DataColumn idDefection;
        private DataColumn idNPA;
        private DataColumn punctNPA;
        private DataColumn dataColumn_6;
        private DataColumn dataColumn_7;
        private DataColumn dataColumn_8;
        private DataColumn dataColumn_9;
        private DataGridView dgvEquipment;
        private DataGridViewComboBoxColumn idDefectionDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idNPADgvColumn;
        private DataGridViewComboBoxColumn idOrgDefectionDgvColumn;
        private DataGridViewComboBoxColumn idNoCrashMeasureColumn;
        private DataGridViewComboBoxColumn idOrgColumn;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_5;
        private DataGridViewComboBoxColumn typeEquipmentDgvColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvNoCrashMeasure;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvDefection;
        private DataGridViewFilterDateTimePickerColumn dateCompleteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn punctNPADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn schmObjDgvColumn;
        private DataGridViewTextBoxColumn idDamageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn col2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn col3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn schmObjNameDgvColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn idDamCharacterDgvColumn;
        private DataGridViewTextBoxColumn idSchmObjDgvColumn;
        private DataSet ds;
        private dsDamage dataSetDamage;
        private DataTable dtClassifier;
        private DataTable dtNoCrashMeasure;
        private DataTable dtDefection;
        private DataTable dtParametersEquipment;
        private DataTable dtComission;
        private DateTimePicker dtpDateOwner;
        private GroupBox groupBoxGeneral;
        private GroupBox groupBoxDescription;
        private GroupBox groupBoxNoCrashEvents;
        private IContainer components = null;
        private Label label_0;
        private Label label_1;
        private Label label_10;
        private Label label_11;
        private Label label_12;
        private Label label_13;
        private Label label_14;
        private Label label_15;
        private Label label_16;
        private Label label_17;
        private Label label19;
        private Label label22;
        private Label label_2;
        private Label label_20;
        private Label label_21;
        private Label label_22;
        private Label label_23;
        private Label label_24;
        private Label label_25;
        private Label label_26;
        private Label label_27;
        private Label label_28;
        private Label label_29;
        private Label labelOwner;
        private Label label_30;
        private Label label_31;
        private Label label_32;
        private Label label_33;
        private Label label_34;
        private Label label_35;
        private Label label_36;
        private Label label_37;
        private Label label_38;
        private Label label_39;
        private Label label_4;
        private Label label_40;
        private Label label_41;
        private Label label_42;
        private Label label_43;
        private Label label_44;
        private Label label_45;
        private Label label_46;
        private Label label_47;
        private Label label_48;
        private Label label_49;
        private Label label_5;
        private Label label_50;
        private Label label_51;
        private Label label_52;
        private Label label_53;
        private Label labelNumCrash;
        private Label label_55;
        private Label label_56;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private Label label_9;
        private List<int> list_0;
        public int? IdDocument { get; set; }
        private int? IdParent;
        private NullableDateTimePicker dtpDateDoc;
        private NullableDateTimePicker dtpEndCrashMoscow;
        private NullableDateTimePicker dtpEndCrashLocal;
        private NullableDateTimePicker dtpLastDateTest;
        private NullableDateTimePicker dtpTimeRecovery;
        private NullableDateTimePicker dtpApply;
        private RichTextBox txtTotalComission;
        private RichTextBox txtReasonBeginCrash;
        private RichTextBox txtStatusCurrentCrash;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TabControl tabControl1;
        private TabPage tabPageGeneral;
        private TabPage tabPageSchm;
        private TabPage tabPageComission;
        private TabPage tabPagePrint;
        private TabPage tabPageDescription;
        private TextBox txtOwner;
        private TextBox txtNumRequest;
        private TextBox txtClauseFail;
        private TextBox txtYearBegEquipment;
        private TextBox txtAssociatedFact;
        private TextBox txtLengthWorkEquipment;
        private TextBox txtOrder;
        private TextBox txtPostChairman;
        private TextBox txtPostMemeber3;
        private TextBox txtPostMemeber2;
        private TextBox txtPostMemeber1;
        private TextBox txtNumCrash;
        private TextBox txtParentDamage;
        private TextBox txtPostMemeber5;
        private TextBox txtPostMemeber4;
        private TextBox txtNodeDetail;
        private TextBox txtSchmObj;
        private TextBox txtCountDefectEquipment;
        private TextBox txtFactoryNumber;
        private TextBox txtManufacturer;
        private TextBox txtYearManufature;
        private TextBox txtLenghtLine;
        private TextBox txtLengthOverload;
        private ToolStrip toolStripEquipment;
        private ToolStripButton toolBtnAddEquipment;
        private ToolStripButton toolBtnDelEquipment;

        public FormActDetectionAddEdit()
        {
            this.InitializeComponent();
            this.AssignStartDates();
        }

        public FormActDetectionAddEdit(int? idDocument = new int?())
        {
            this.InitializeComponent();
            this.IdDocument = idDocument;
            this.AssignStartDates();
        }

        public FormActDetectionAddEdit(int? idParentDocument = new int?(), List<int> list_1 = null)
        {
            this.InitializeComponent();
            this.AssignStartDates();
            this.IdParent = idParentDocument;
            this.list_0 = list_1;
        }

        private void bindingSource_2_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource_2.Current != null)
            {
                DataRow row = ((DataRowView)this.bindingSource_2.Current).Row;
                object obj2 = row["idMark"];
                this.method_48();
                row["idMark"] = obj2;
                this.cmbMarkEquipment.SelectedValue = obj2;
                if (!this.GetflagViewDoc() && !this.chkApply.Checked)
                {
                    this.method_60(false);
                }
            }
            else
            {
                this.method_60(true);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void buttonChooseParentDamage_Click(object sender, EventArgs e)
        {
            // Form63 form = new Form63();
            FormSelectDamage form = new FormSelectDamage();
            form.SqlSettings = (this.SqlSettings);
            if (form.ShowDialog() == DialogResult.OK)
            {
                int idParentDocument = form.GetIdDamage().Value;
                List<int> list = new List<int>();
                FormChooseDamageCharacter form2 = new FormChooseDamageCharacter(new int?(idParentDocument), list, this.IdDocument);
                form2.SqlSettings = (this.SqlSettings);
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    while (this.dgvEquipment.Rows.Count > 0)
                    {
                        this.dgvEquipment.Rows.RemoveAt(0);
                    }
                    this.method_39(form2.getListDamage());
                    this.dataSetDamage.tJ_Damage.Rows[0]["idParent"] = this.IdParent = new int?(idParentDocument);
                    this.GetParentDocument(idParentDocument);
                }
            }
        }

        private void btnOpenParentDamage_Click(object sender, EventArgs e)
        {
            if (this.IdParent.HasValue)
            {
                DataTable table = base.SelectSqlData("tJ_Damage", true, "where id = " + this.IdParent.ToString());
                if (table.Rows.Count != 0)
                {
                    this.OpenDocument(Convert.ToInt32(table.Rows[0]["typeDoc"]), Convert.ToInt32(this.IdParent));
                }
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
                    DataTable table = new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("select a.numCrash from tJ_DamageActDetection a\r\n                                            left join tj_damage d on d.id = a.idDamage\r\n                                            where isnumeric(a.numCrash) = 1 and year(d.DateDoc) = {0}\r\n                                            order by cast(a.numCrash as int) desc", this.dtpDateOwner.Value.Year));
                    if (table.Rows.Count > 0)
                    {
                        this.txtNumCrash.Text = (Convert.ToInt32(table.Rows[0]["numCrash"]) + 1).ToString();
                    }
                    else
                    {
                        this.txtNumCrash.Text = "1";
                    }
                }
            }
            else
            {
                this.txtNumCrash.Enabled = false;
                this.txtNumCrash.Text = "";
            }
        }

        private void chkApply_CheckedChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.ControlBlocking();
        }

        private void cmbChairman_SelectedValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            ComboBox box = (ComboBox)sender;
            if (box.SelectedIndex < 0)
            {
                if (box == this.cmbChairman)
                {
                    this.txtPostChairman.Text = "";
                }
                if (box == this.cmbMemberComission1)
                {
                    this.txtPostMemeber1.Text = "";
                }
                if (box == this.cmbMemberComission2)
                {
                    this.txtPostMemeber2.Text = "";
                }
                if (box == this.cmbMemberComission3)
                {
                    this.txtPostMemeber3.Text = "";
                }
                if (box == this.cmbMemberComission4)
                {
                    this.txtPostMemeber4.Text = "";
                }
                if (box == this.cmbMemberComission5)
                {
                    this.txtPostMemeber5.Text = "";
                }
            }
            else
            {
                DataTable table = new SqlDataCommand(this.SqlSettings).SelectSqlData("select t.description from tR_JobTitle t \r\n\t                inner join tR_Worker w on t.id = w.jobtitle\r\n                    where w.id = " + box.SelectedValue.ToString());
                if ((table.Rows.Count > 0) && (table.Rows[0]["Description"] != DBNull.Value))
                {
                    if (box == this.cmbChairman)
                    {
                        this.txtPostChairman.Text = table.Rows[0]["Description"].ToString();
                    }
                    if (box == this.cmbMemberComission1)
                    {
                        this.txtPostMemeber1.Text = table.Rows[0]["Description"].ToString();
                    }
                    if (box == this.cmbMemberComission2)
                    {
                        this.txtPostMemeber2.Text = table.Rows[0]["Description"].ToString();
                    }
                    if (box == this.cmbMemberComission3)
                    {
                        this.txtPostMemeber3.Text = table.Rows[0]["Description"].ToString();
                    }
                    if (box == this.cmbMemberComission4)
                    {
                        this.txtPostMemeber4.Text = table.Rows[0]["Description"].ToString();
                    }
                    if (box == this.cmbMemberComission5)
                    {
                        this.txtPostMemeber5.Text = table.Rows[0]["Description"].ToString();
                    }
                }
                else
                {
                    if (box == this.cmbMemberComission1)
                    {
                        this.txtPostMemeber1.Text = "";
                    }
                    if (box == this.cmbMemberComission2)
                    {
                        this.txtPostMemeber2.Text = "";
                    }
                    if (box == this.cmbMemberComission3)
                    {
                        this.txtPostMemeber3.Text = "";
                    }
                    if (box == this.cmbMemberComission4)
                    {
                        this.txtPostMemeber4.Text = "";
                    }
                    if (box == this.cmbMemberComission5)
                    {
                        this.txtPostMemeber5.Text = "";
                    }
                }
            }
        }

        private void cmbWorkerApply_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if ((this.cmbWorkerApply.SelectedIndex >= 0) && ((this.dtpApply.Value == null) || (this.dtpApply.Value == DBNull.Value)))
            {
                this.dtpApply.Value = (DateTime.Now);
            }
        }

        private void dataGridView_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < (e.RowIndex + e.RowCount); i++)
            {
                object obj2 = this.dgvEquipment[this.idSchmObjDgvColumn.Name, i].Value;
                if ((obj2 != DBNull.Value) && (obj2 != null))
                {
                    string[] textArray1 = new string[] { obj2.ToString() };
                    object obj3 = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1);
                    if ((obj3 != null) && (obj3 != DBNull.Value))
                    {
                        this.dgvEquipment[this.schmObjDgvColumn.Index, i].Value = obj3.ToString();
                    }
                }
            }
        }

        private void dgvNoCrashMeasure_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                ((ComboBox)e.Control).DropDownStyle = ComboBoxStyle.DropDown;
                ((ComboBox)e.Control).AutoCompleteSource = AutoCompleteSource.ListItems;
                ((ComboBox)e.Control).AutoCompleteMode = AutoCompleteMode.Suggest;
                ((ComboBox)e.Control).DropDown -= new EventHandler(this.SetDropDownWidth);
                ((ComboBox)e.Control).DropDown += new EventHandler(this.SetDropDownWidth);
            }
            if (((((DataGridView)sender).CurrentCell != null) && (((DataGridView)sender).Columns[((DataGridView)sender).CurrentCell.ColumnIndex] == this.dateCompleteDataGridViewTextBoxColumn)) && (e.Control is DateTimePicker))
            {
                ((DateTimePicker)e.Control).Format = DateTimePickerFormat.Custom;
                ((DateTimePicker)e.Control).CustomFormat = "MMMM.yyyy";
                if (((DataGridView)sender).CurrentCell.Value == DBNull.Value)
                {
                    ((DataGridView)sender).CurrentCell.Value = ((DateTimePicker)e.Control).Value;
                }
            }
        }

        private void dgvNoCrashMeasure_MouseClick(object sender, MouseEventArgs e)
        {
            if (((DataGridView)sender).HitTest(e.X, e.Y).Type == DataGridViewHitTestType.RowHeader)
            {
                ((DataGridView)sender).EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                ((DataGridView)sender).EndEdit();
            }
            else
            {
                ((DataGridView)sender).EditMode = DataGridViewEditMode.EditOnEnter;
            }
        }

        private void dgvNoCrashMeasure_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                e.Cancel = true;
            }
        }

        private void dtpDateOwner_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.method_62();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormActDetectionAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((base.DialogResult != DialogResult.OK) && ((!this.isChangedData || this.GetflagViewDoc()) || (MessageBox.Show("Сохранить внесенные изменения", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)))
            {
                base.DialogResult = DialogResult.Cancel;
            }
            else if (this.method_30())
            {
                if (this.GetIdDocument())
                {
                    base.DialogResult = DialogResult.OK;
                }
                else
                {
                    base.DialogResult = DialogResult.None;
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Введите обязательные поля для заполнения");
                base.DialogResult = DialogResult.None;
                e.Cancel = true;
            }
        }

        private void FormActDetectionAddEdit_Load(object sender, EventArgs e)
        {
            this.txtxControlShow();
            this.GetTableClassifier();
            this.GetTableWorkerGroup();
            this.FillCmbDivision();
            this.GetTableAbnType();
            this.FillcmbSignCrash();
            this.FillcmbTypeEquipment();
            this.FillcmbReasonCrashEquipment();
            this.FillcmbReasonCrash();
            this.FillcmbStatusBeforeCrash();
            this.FillcmbStatusCurrentCrash();
            this.method_23();
            this.method_24();
            this.method_25();
            this.method_26();
            this.method_27();
            this.method_28();
            this.method_37();
            if (!this.IdDocument.HasValue)
            {
                DataRow row = this.dataSetDamage.tJ_Damage.NewRow();
                row["TypeDoc"] = 0x752;
                if (this.IdParent.HasValue)
                {
                    row["idParent"] = this.IdParent.Value;
                    this.method_10(this.IdParent.Value, row);
                }
                this.dataSetDamage.tJ_Damage.Rows.Add(row);
                this.CreateActDecettionRow();
                this.method_39(this.list_0);
                this.method_6();
                this.method_7();
            }
            else
            {
                base.SelectSqlData(this.dataSetDamage.tJ_Damage, true, " where id = " + this.IdDocument.Value.ToString(), null, false, 0);
                if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
                {
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["idParent"] != DBNull.Value)
                    {
                        this.IdParent = new int?(Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idParent"]));
                    }
                    if ((this.dataSetDamage.tJ_Damage.Rows[0]["isApply"] != DBNull.Value) && Convert.ToBoolean(this.dataSetDamage.tJ_Damage.Rows[0]["isApply"]))
                    {
                        this.cmbWorkerApply.ReadOnly = (true);
                        this.dtpApply.Enabled = false;
                    }
                }
                base.SelectSqlData(this.dataSetDamage.tJ_DamageActDetection, true, " where idDamage = " + this.IdDocument.Value.ToString(), null, false, 0);
                if (this.dataSetDamage.tJ_DamageActDetection.Rows.Count == 0)
                {
                    this.CreateActDecettionRow();
                }
                else
                {
                    if (this.dataSetDamage.tJ_DamageActDetection.Rows[0]["NoCrashMeasure"] != DBNull.Value)
                    {
                        string str = this.dataSetDamage.tJ_DamageActDetection.Rows[0]["NoCrashMeasure"].ToString();
                        if (!string.IsNullOrEmpty(str))
                        {
                            this.dtNoCrashMeasure.ReadXml(new StringReader(str));
                        }
                    }
                    if (this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Defection"] != DBNull.Value)
                    {
                        string str2 = this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Defection"].ToString();
                        if (!string.IsNullOrEmpty(str2))
                        {
                            this.dtDefection.ReadXml(new StringReader(str2));
                        }
                    }
                }
                this.GetDamageCharacter();
            }
            this.method_57();
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
            {
                if (this.dataSetDamage.tJ_Damage.Rows[0]["idParent"] != DBNull.Value)
                {
                    this.GetParentDocument(Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idParent"]));
                }
                if (this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"] != DBNull.Value)
                {
                    string[] textArray1 = new string[] { this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"].ToString() };
                    this.txtSchmObj.Text = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1).ToString();
                }
            }
            if (string.IsNullOrEmpty(this.txtLengthOverload.Text))
            {
                this.txtLengthOverload.Text = "0";
            }
            this.GetAutorAkt();
            this.method_58(base.Controls);
            this.isChangedData = false;
        }

        private bool flagViewDoc;
        public bool GetflagViewDoc()
        { return this.flagViewDoc; }

        public void FormViewMode(bool value)
        {
            this.flagViewDoc = value;
            ControlBlocking();
        }



        private void method_10(int idDoc, DataRow row)
        {
            DataTable table = new SqlDataCommand(this.SqlSettings).SelectSqlData("select pSub.idNetRegion, d.dateDoc, d.idSchmObj  from vj_damage d\r\n                                        left join vP_SubstationByNetRegion pSub on pSub.id = d.idSub\r\n                                        where d.id = " + idDoc.ToString());
            if (table.Rows.Count > 0)
            {
                row["idDivision"] = table.Rows[0]["idNetRegion"];
                row["dateDoc"] = table.Rows[0]["dateDoc"];
                row["idSchmObj"] = table.Rows[0]["idSChmObj"];
            }
        }

        private DataTable CreateTableWorkerGroup()
        {
            Type dataType = Type.GetType("System.Int32");
            DataTable table = new DataTable("vWorkerGroup");
            DataColumn column = new DataColumn("id", dataType);
            table.Columns.Add(column);
            DataColumn column2 = new DataColumn("fio", Type.GetType("System.String"));
            table.Columns.Add(column2);
            DataColumn column3 = new DataColumn("GroupElectrical", dataType);
            table.Columns.Add(column3);
            table.PrimaryKey = new DataColumn[] { column };
            DataColumn column4 = new DataColumn("GroupRoman", Type.GetType("System.String"))
            {
                Expression = "IIF(groupElectrical = 1, 'I', IIF(groupElectrical = 2, 'II', IIF(groupelectrical=3, 'III', IIF(groupelectrical = 4, 'IV', iif(groupelectrical = 5, 'V', '')))))"
            };
            table.Columns.Add(column4);
            DataColumn column5 = new DataColumn("fioGroup", Type.GetType("System.String"))
            {
                Expression = "fio + ' (' + GroupRoman + ')'"
            };
            table.Columns.Add(column5);
            return table;
        }

        private DataTable CreateTableClassifier()
        {
            DataTable table1 = new DataTable("tR_Classifier");
            table1.Columns.Add("id", typeof(int));
            table1.Columns.Add("name", typeof(string));
            table1.Columns.Add("comment", typeof(string));
            table1.Columns.Add("ParentKey", typeof(string));
            table1.Columns.Add("value", typeof(decimal));
            DataColumn column = new DataColumn("nameComment", Type.GetType("System.String"))
            {
                Expression = "name + ' ' + comment"
            };
            table1.Columns.Add(column);
            return table1;
        }

        private DataTable CreateTableAbnType()
        {
            DataTable table1 = new DataTable("vAbnType");
            table1.Columns.Add("idAbn", typeof(int));
            table1.Columns.Add("Name", typeof(string));
            return table1;
        }

        private void GetTableClassifier()
        {
            this.dtClassifier = this.CreateTableClassifier();
            base.SelectSqlData(this.dtClassifier, true, string.Format(" where (ParentKey in ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}',  \r\n                                        '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{15}', \r\n                                         '{16}', '{17}', '{18}', '{19}', '{20}') or ParentKey like '{14}%')\r\n                and isgroup = 0 and deleted = 0", new object[] {
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

        private void GetTableWorkerGroup()
        {
            DataTable table = this.CreateTableWorkerGroup();
            base.SelectSqlData(table, true, "where ParentKey like ';GroupWorker;DailyReport;MemberActDetection;' and dateEnd is null order by fio ", null, false, 0);
            this.cmbCompiler.DisplayMember = "FIO";
            this.cmbCompiler.ValueMember = "id";
            this.cmbCompiler.DataSource = table;
            this.cmbCompiler.SelectedIndex = -1;

            this.cmbWorkerApply.DisplayMember = "FIO";
            this.cmbWorkerApply.ValueMember = "id";
            this.cmbWorkerApply.DataSource = table.Copy();
            this.cmbWorkerApply.SelectedIndex = -1;

            this.cmbChairman.DisplayMember = "FIO";
            this.cmbChairman.ValueMember = "id";
            this.cmbChairman.DataSource = table.Copy();
            this.cmbChairman.SelectedIndex = -1;

            this.cmbMemberComission1.DisplayMember = this.cmbMemberComission2.DisplayMember = this.cmbMemberComission3.DisplayMember = this.cmbMemberComission4.DisplayMember = this.cmbMemberComission5.DisplayMember = "FIO";
            this.cmbMemberComission1.ValueMember = this.cmbMemberComission2.ValueMember = this.cmbMemberComission3.ValueMember = this.cmbMemberComission4.ValueMember = this.cmbMemberComission5.ValueMember = "id";

            DataTable table1 = table.Copy();
            table1.Columns["id"].AutoIncrement = true;
            table1.Columns["id"].AutoIncrementSeed = -1L;
            table1.Columns["id"].AutoIncrementStep = -1L;
            DataRow row = table1.NewRow();
            row["FIO"] = "";
            row.EndEdit();
            table1.Rows.Add(row);

            DataView defaultView = table1.DefaultView;
            defaultView.Sort = "FIO asc";

            DataTable table2 = defaultView.ToTable();
            this.cmbMemberComission1.DataSource = table2.Copy();
            this.cmbMemberComission2.DataSource = table2.Copy();
            this.cmbMemberComission3.DataSource = table2.Copy();
            this.cmbMemberComission4.DataSource = table2.Copy();
            this.cmbMemberComission5.DataSource = table2.Copy();
            this.cmbMemberComission5.SelectedIndex = -1;
            this.cmbMemberComission4.SelectedIndex = -1;
            this.cmbMemberComission3.SelectedIndex = -1;
            this.cmbMemberComission2.SelectedIndex = -1;
            this.cmbMemberComission1.SelectedIndex = -1;
        }

        private void FillCmbDivision()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';NetworkAreas;'",
                Sort = "name"
            };
            this.cmbDivision.DisplayMember = "name";
            this.cmbDivision.ValueMember = "id";
            this.cmbDivision.DataSource = source;
            this.cmbDivision.SelectedIndex = -1;
        }

        private void FillcmbSignCrash()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;SignCrash;'",
                Sort = "value"
            };
            this.cmbSignCrash.DisplayMember = "nameComment";
            this.cmbSignCrash.ValueMember = "id";
            this.cmbSignCrash.DataSource = source;
            this.cmbSignCrash.SelectedIndex = -1;
        }

        private void FillcmbTypeEquipment()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;TypeEquipment;'",
                Sort = "value"
            };
            this.cmbTypeEquipment.DisplayMember = "nameComment";
            this.cmbTypeEquipment.ValueMember = "id";
            this.cmbTypeEquipment.DataSource = source;
            this.cmbTypeEquipment.SelectedIndex = -1;
        }

        private void FillcmbReasonCrashEquipment()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;ReasonCrashEquipment;'",
                Sort = "value"
            };
            this.cmbReasonCrashEquipment.DisplayMember = "nameComment";
            this.cmbReasonCrashEquipment.ValueMember = "id";
            this.cmbReasonCrashEquipment.DataSource = source;
            this.cmbReasonCrashEquipment.SelectedIndex = -1;
        }

        //internal int? method_2()
        //{
        //    return this.IdDocument;
        //}

        private void FillcmbReasonCrash()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;ReasonCrash;'",
                Sort = "value"
            };
            this.cmbReasonCrash.DisplayMember = "nameComment";
            this.cmbReasonCrash.ValueMember = "id";
            this.cmbReasonCrash.DataSource = source;
            this.cmbReasonCrash.SelectedIndex = -1;
        }

        private void FillcmbStatusBeforeCrash()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;StatusBeforeCrash;'",
                Sort = "value"
            };
            this.cmbStatusBeforeCrash.DisplayMember = "nameComment";
            this.cmbStatusBeforeCrash.ValueMember = "id";
            this.cmbStatusBeforeCrash.DataSource = source;
            this.cmbStatusBeforeCrash.SelectedIndex = -1;
        }

        private void FillcmbStatusCurrentCrash()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;StatusCurrentCrash;'",
                Sort = "value"
            };
            this.cmbStatusCurrentCrash.DisplayMember = "nameComment";
            this.cmbStatusCurrentCrash.ValueMember = "id";
            this.cmbStatusCurrentCrash.DataSource = source;
            this.cmbStatusCurrentCrash.SelectedIndex = -1;
        }

        private void method_23()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;NoCrashMeasure;'",
                Sort = "value"
            };
            this.idNoCrashMeasureColumn.DisplayMember = "name";
            this.idNoCrashMeasureColumn.ValueMember = "id";
            this.idNoCrashMeasureColumn.DataSource = source;
        }

        private void method_24()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;Defection;'",
                Sort = "value"
            };
            this.idDefectionDataGridViewTextBoxColumn.DisplayMember = "comment";
            this.idDefectionDataGridViewTextBoxColumn.ValueMember = "id";
            this.idDefectionDataGridViewTextBoxColumn.DataSource = source;
        }

        private void method_25()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;NPA;'",
                Sort = "value"
            };
            this.idNPADgvColumn.DisplayMember = "name";
            this.idNPADgvColumn.ValueMember = "id";
            this.idNPADgvColumn.DataSource = source;
        }

        private void method_26()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;ReasonBeginCrash;'",
                Sort = "value"
            };
            this.cmbReasonBeginCrash.DisplayMember = "comment";
            this.cmbReasonBeginCrash.ValueMember = "id";
            this.cmbReasonBeginCrash.DataSource = source;
        }

        private void method_27()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;Damage;'",
                Sort = "value"
            };
            this.cmbClassifierDamage.DisplayMember = "name";
            this.cmbClassifierDamage.ValueMember = "id";
            this.cmbClassifierDamage.DataSource = source;
        }

        private void method_28()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;Fault;'",
                Sort = "value"
            };
            this.cmbFault.DisplayMember = "name";
            this.cmbFault.ValueMember = "id";
            this.cmbFault.DataSource = source;
        }

        private void GetTableAbnType()
        {
            DataTable table = this.CreateTableAbnType();
            base.SelectSqlData(table, true, string.Format("where typeKontragent = {0} and deleted = 0 order by name", 0x755), null, false, 0);
            this.cmbOrg.DisplayMember = "name";
            this.cmbOrg.ValueMember = "idAbn";
            this.cmbOrg.DataSource = table;
            this.cmbOrg.SelectedIndex = -1;

            this.idOrgColumn.DisplayMember = "name";
            this.idOrgColumn.ValueMember = "idAbn";
            this.idOrgColumn.DataSource = table.Copy();
            this.idOrgDefectionDgvColumn.DisplayMember = "name";
            this.idOrgDefectionDgvColumn.ValueMember = "idAbn";
            this.idOrgDefectionDgvColumn.DataSource = table.Copy();
        }
        /// <summary>
        /// присвоить начальные даты
        /// </summary>
        private void AssignStartDates()
        {
            this.dtpDateDoc.Value = (DateTime.Now);
            this.dtpApply.Value = (DateTime.Now);
            this.dtpLastDateTest.Value = (DateTime.Now);
            this.dtpTimeRecovery.Value = (DateTime.Now);
            this.dtpLastDateTest.MaxDate = (DateTime)this.dtpTimeRecovery.Value;
        }

        private bool method_30()
        {
            bool flag = true;
            if (this.chkCrash.Checked)
            {
                if (string.IsNullOrEmpty(this.txtNumCrash.Text))
                {
                    flag = false;
                    this.labelNumCrash.ForeColor = Color.Red;
                }
                if (new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("select a.numCrash from tJ_DamageActDetection a\r\n                                            left join tj_damage d on d.id = a.idDamage\r\n                                            where a.numCrash = '{0}' and year(d.DateDoc) = {1} and d.id <> {2}", this.txtNumCrash.Text, this.dtpDateOwner.Value.Year, !this.IdDocument.HasValue ? -1 : this.IdDocument.Value)).Rows.Count > 0)
                {
                    flag = false;
                    this.labelNumCrash.ForeColor = Color.Red;
                }
            }
            return flag;
        }

        private bool GetIdDocument()
        {
            this.dataSetDamage.tJ_Damage.Rows[0].EndEdit();
            if (!this.IdDocument.HasValue)
            {
                this.IdDocument = new int?(base.InsertSqlDataOneRow(this.dataSetDamage, this.dataSetDamage.tJ_Damage));
                int? id = this.IdDocument;
                if ((id.GetValueOrDefault() == -1) ? id.HasValue : false)
                {
                    this.IdDocument = null;
                    return false;
                }
            }
            else if (!base.UpdateSqlData(this.dataSetDamage.tJ_Damage))
            {
                return false;
            }
            if (!this.method_32())
            {
                return false;
            }
            if (!this.method_33())
            {
                return false;
            }
            return true;
        }

        private bool method_32()
        {
            if (this.dataSetDamage.tJ_DamageActDetection.Rows.Count > 0)
            {
                this.dataSetDamage.tJ_DamageActDetection.Rows[0]["idDamage"] = this.IdDocument.Value;
                if (this.dtNoCrashMeasure.Rows.Count == 0)
                {
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["NoCrashMeasure"] = DBNull.Value;
                }
                else
                {
                    StringWriter writer = new StringWriter();
                    this.dtNoCrashMeasure.WriteXml(writer, XmlWriteMode.WriteSchema, false);
                    string str = writer.ToString();
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["NoCrashMeasure"] = str;
                }
                if (this.dtDefection.Rows.Count == 0)
                {
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Defection"] = DBNull.Value;
                }
                else
                {
                    StringWriter writer2 = new StringWriter();
                    this.dtDefection.WriteXml(writer2, XmlWriteMode.WriteSchema, false);
                    string str2 = writer2.ToString();
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Defection"] = str2;
                }
                if (this.dtComission.Rows.Count == 0)
                {
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Comission"] = DBNull.Value;
                }
                else
                {
                    StringWriter writer3 = new StringWriter();
                    this.dtComission.WriteXml(writer3, XmlWriteMode.WriteSchema, false);
                    string str3 = writer3.ToString();
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Comission"] = str3;
                }
                this.dataSetDamage.tJ_DamageActDetection.Rows[0].EndEdit();
                if (!base.InsertSqlData(this.dataSetDamage.tJ_DamageActDetection))
                {
                    return false;
                }
                if (!base.UpdateSqlData(this.dataSetDamage.tJ_DamageActDetection))
                {
                    return false;
                }
                base.SelectSqlData(this.dataSetDamage.tJ_DamageActDetection, true, "where idDamage = " + this.IdDocument.Value.ToString(), null, false, 0);
            }
            return true;
        }

        private bool method_33()
        {
            foreach (DataRow row in this.dataSetDamage.tJ_DamageCharacter.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    row["idDamage"] = this.IdDocument.Value;
                    row.EndEdit();
                }
            }
            if (!base.InsertSqlData(this.dataSetDamage.tJ_DamageCharacter))
            {
                return false;
            }
            if (!base.UpdateSqlData(this.dataSetDamage.tJ_DamageCharacter))
            {
                return false;
            }
            if (!base.DeleteSqlData(this.dataSetDamage.tJ_DamageCharacter))
            {
                return false;
            }
            return true;
        }

        private void OpenDocument(int TypeDoc, int idDocument = -1)
        {
            switch (TypeDoc)
            {
                case 0x579://1401
                    {
                        DailyReport.JournalDamage.FormDamageLVAddEdit form2 = new DailyReport.JournalDamage.FormDamageLVAddEdit(idDocument);
                        form2.SqlSettings = (this.SqlSettings);
                        form2.MdiParent = base.MdiParent;
                        form2.FormViewMode(true);
                        form2.Show();
                        return;
                    }
                case 0x57a://1402
                    {
                        DailyReport.JournalDamage.FormDamageHVAddEdit form3 = new DailyReport.JournalDamage.FormDamageHVAddEdit(idDocument);
                        form3.SqlSettings = (this.SqlSettings);
                        form3.MdiParent = base.MdiParent;
                        form3.FormViewMode(true);
                        form3.Show();
                        return;
                    }
                case 0x57b://1403
                case 0x734://1844
                    {
                        DailyReport.JournalDamage.FormDefectAddEdit form4 = new DailyReport.JournalDamage.FormDefectAddEdit(idDocument, TypeDoc);
                        form4.SqlSettings = (this.SqlSettings);
                        form4.MdiParent = base.MdiParent;
                        form4.FormViewMode(true);
                        form4.Show();
                        return;
                    }
                case 0x752://1874
                    {
                        FormActDetectionAddEdit form1 = new FormActDetectionAddEdit(new int?(idDocument));
                        form1.SqlSettings = (this.SqlSettings);
                        form1.MdiParent = base.MdiParent;
                        form1.FormViewMode((true));
                        form1.Show();
                        return;
                    }
            }
        }

        private void SetDropDownWidth(object sender, EventArgs e)
        {
            ((ComboBox)sender).DropDownWidth = 500;
        }

        private void GetDamageCharacter()
        {
            if (this.IdDocument.HasValue)
            {
                base.SelectSqlData(this.dataSetDamage.tJ_DamageCharacter, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
            }
        }

        private void method_37()
        {
            this.method_38();
            this.method_49();
            this.method_50();
            this.method_51();
            this.method_52();
            this.method_53();
            this.method_54();
            this.method_55();
            this.method_56();
        }

        private void method_38()
        {
            DataTable table = this.CreateTableClassifier();
            base.SelectSqlData(table, true, "where ParentId in (select id from \r\n                                        tr_classifier where ParentKey = ';ReportDaily;NatureDamage;HV;') \r\n                                        and isGroup = 1 and deleted = 0 order by ParentKey", null, false, 0);
            BindingSource source = new BindingSource
            {
                DataSource = table,
                Position = -1
            };
            this.typeEquipmentDgvColumn.DisplayMember = "name";
            this.typeEquipmentDgvColumn.ValueMember = "id";
            this.typeEquipmentDgvColumn.DataSource = source;
        }

        private void method_39(IEnumerable<int> ienumerable_0)
        {
            if ((ienumerable_0 != null) && (ienumerable_0.Count<int>() > 0))
            {
                this.txtYearManufature.TextChanged -= new EventHandler(this.txtYearManufature_TextChanged);
                string str = "";
                foreach (int num in ienumerable_0)
                {
                    if (string.IsNullOrEmpty(str))
                    {
                        str = num.ToString();
                    }
                    else
                    {
                        str = str + "," + num.ToString();
                    }
                }
                dsDamage.tJ_DamageCharacterDataTable table = new dsDamage.tJ_DamageCharacterDataTable();
                base.SelectSqlData(table, true, "where id in (" + str + ")", null, false, 0);
                foreach (DataRow row in table.Rows)
                {
                    DataRow row2 = this.dataSetDamage.tJ_DamageCharacter.NewRow();
                    row2["idDamage"] = !this.IdDocument.HasValue ? -1 : this.IdDocument.Value;
                    row2["col1"] = row["col1"];
                    row2["idSchmObj"] = row["idSchmObj"];
                    row2["idLineSection"] = row["idLineSection"];
                    row2["idParameters"] = 0x7ea;
                    row2["idCharacterParent"] = row["id"];
                    row2["lengthOverLoad"] = 0;
                    row2["idNeutralState"] = 2037;
                    row2["nodeDetail"] = 2037;
                    if (row2["idSchmObj"] != DBNull.Value)
                    {
                        DateTime time;
                        object obj2 = this.GetLengthLine(Convert.ToInt32(row2["idSChmObj"]));
                        if (!string.IsNullOrEmpty(obj2.ToString()))
                        {
                            row2["LengthLine"] = obj2;
                        }

                        object obj3 = this.method_45(Convert.ToInt32(row2["idSChmObj"]));
                        row2["idMark"] = obj3;

                        object obj4 = this.method_41(Convert.ToInt32(row2["idSChmObj"]));
                        if ((((obj4 != DBNull.Value) && (obj4.ToString() != string.Empty)) && ((this.cmbVoltage.DataSource != null) && (this.cmbVoltage.DataSource is BindingSource))) && (((BindingSource)this.cmbVoltage.DataSource).DataSource is DataTable))
                        {
                            DataRow[] rowArray = ((DataTable)((BindingSource)this.cmbVoltage.DataSource).DataSource).Select("Value = '" + obj4.ToString() + "' and ParentKey like ';VoltageLevels;%'");
                            if (rowArray.Length != 0)
                            {
                                row2["idVoltage"] = rowArray[0]["id"];
                            }
                        }
                        obj4 = this.method_42(Convert.ToInt32(row2["idSChmObj"]));
                        if (((obj4 != DBNull.Value) && (this.cmbVoltageSeti.DataSource != null)) && ((this.cmbVoltageSeti.DataSource is BindingSource) && (((BindingSource)this.cmbVoltageSeti.DataSource).DataSource is DataTable)))
                        {
                            DataRow[] rowArray2 = ((DataTable)((BindingSource)this.cmbVoltageSeti.DataSource).DataSource).Select("Value = " + obj4.ToString().Replace(',', '.') + " and ParentKey like ';VoltageLevels;%'");
                            if (rowArray2.Length != 0)
                            {
                                row2["idVoltageSeti"] = rowArray2[0]["id"];
                            }
                        }

                        object obj5 = this.GetYearConstruction(Convert.ToInt32(row2["idSChmObj"]));
                        row2["YearManufacture"] = obj5;

                        object obj6 = this.GetYearCommissioning(Convert.ToInt32(row2["idSChmObj"]));
                        if (DateTime.TryParse(obj6.ToString(), out time))
                        {
                            row2["YearBegEquipment"] = time.ToString("yyyy");
                        }
                        else
                        {
                            row2["YearBegEquipment"] = (obj6.ToString() == string.Empty) ? DBNull.Value : obj6;
                        }
                        object obj7 = this.method_46(Convert.ToInt32(row2["idSChmObj"]));
                        row2["LastDateTest"] = obj7;

                        object obj8 = this.method_47(Convert.ToInt32(row2["idSChmObj"]));
                        row2["timeRecovery"] = obj8;
                    }
                    this.dataSetDamage.tJ_DamageCharacter.Rows.Add(row2);
                }
            }
        }

        private void txtxControlShow()
        {
            this.txtNumCrash.DataBindings.Clear();
            this.txtNumCrash.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.numCrash", true, DataSourceUpdateMode.OnPropertyChanged, ""));
            this.txtTotalComission.DataBindings.Clear();
            this.txtTotalComission.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.TotalComission", true, DataSourceUpdateMode.OnValidation, ""));
            this.dtpEndCrashLocal.Value = (DateTime.Now);
            this.txtCountDefectEquipment.Enabled = true;
            this.txtPostChairman.Enabled = true;
            this.txtPostMemeber3.Enabled = true;
            this.txtPostMemeber2.Enabled = true;
            this.txtPostMemeber1.Enabled = true;
            this.txtOrder.Enabled = true;
            this.txtLengthOverload.DataBindings[0].NullValue = "0";

            //using (IEnumerator enumerator = this.tabControl1.TabPages.GetEnumerator())
            //{
            //    while (enumerator.MoveNext())
            //    {
            //        ((TabPage)enumerator.Current).Show();
            //    }
            //}
            foreach (object obj in this.tabControl1.TabPages)
            {
                ((TabPage)obj).Show();
            }
        }
        /// <summary>
        /// возвращает Длина трассы
        /// </summary>
        private object GetLengthLine(int idObj)
        {
            DataTable table = new DataTable("tSchm_ObjList");
            table.Columns.Add("typeCodeId", typeof(int));
            base.SelectSqlData(table, true, " where id = " + idObj.ToString(), null, false, 0);
            if ((table.Rows.Count > 0) && (table.Rows[0]["TypeCodeId"] != DBNull.Value))
            {
                if (Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x222)
                {
                    DataTable table2 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Длина трассы'", idObj));
                    if ((table2.Rows.Count > 0) && (table2.Rows[0]["CharValue"] != DBNull.Value))
                    {
                        return table2.Rows[0]["CharValue"];
                    }
                }
                if ((Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x223) || (Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x3d7))
                {
                    DataTable table3 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Протяженность линии'", idObj));
                    if ((table3.Rows.Count > 0) && (table3.Rows[0]["CharValue"] != DBNull.Value))
                    {
                        return table3.Rows[0]["CharValue"];
                    }
                }
            }
            return DBNull.Value;
        }

        private object method_41(int idObj)
        {
            DataTable table = new DataTable("tSchm_ObjList");
            table.Columns.Add("typeCodeId", typeof(int));
            base.SelectSqlData(table, true, " where id = " + idObj.ToString(), null, false, 0);
            if ((table.Rows.Count > 0) && (table.Rows[0]["TypeCodeId"] != DBNull.Value))
            {
                if (Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x222)
                {
                    DataTable table2 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Напряжение'", idObj));
                    if ((table2.Rows.Count > 0) && (table2.Rows[0]["CharValue"] != DBNull.Value))
                    {
                        return table2.Rows[0]["CharValue"];
                    }
                }
                if ((Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x223) || (Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x3d7))
                {
                    DataTable table3 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Напряжение'", idObj));
                    if ((table3.Rows.Count > 0) && (table3.Rows[0]["CharValue"] != DBNull.Value))
                    {
                        return table3.Rows[0]["CharValue"];
                    }
                }
            }
            return DBNull.Value;
        }

        private object method_42(int idObj)
        {
            DataTable table = new DataTable("tSchm_ObjList");
            table.Columns.Add("typeCodeId", typeof(int));
            base.SelectSqlData(table, true, " where id = " + idObj.ToString(), null, false, 0);
            if (((table.Rows.Count > 0) && (table.Rows[0]["TypeCodeId"] != DBNull.Value)) && (Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x222))
            {
                DataTable table2 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Рабочее напряжение'", idObj));
                if ((table2.Rows.Count > 0) && (table2.Rows[0]["CharValue"] != DBNull.Value))
                {
                    return table2.Rows[0]["CharValue"];
                }
            }
            return DBNull.Value;
        }

        /// <summary>
        /// вернуть год/дату вводу в эксплуатацию
        /// </summary>
        /// <param name="idObj"></param>
        /// <returns></returns>
        private object GetYearCommissioning(int idObj)
        {
            DataTable table = new DataTable("tSchm_ObjList");
            table.Columns.Add("typeCodeId", typeof(int));
            base.SelectSqlData(table, true, " where id = " + idObj.ToString(), null, false, 0);
            if ((table.Rows.Count > 0) && (table.Rows[0]["TypeCodeId"] != DBNull.Value))
            {
                if (Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x222)
                {
                    DataTable table2 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Год ввода в эксплуатацию'", idObj));
                    if ((table2.Rows.Count > 0) && (table2.Rows[0]["CharValue"] != DBNull.Value))
                    {
                        return table2.Rows[0]["CharValue"];
                    }
                }
                if ((Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x223) || (Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x3d7))
                {
                    string str = string.Format("where idObj = {0} and ([CharName] like 'Год ввода в эксплуатацию'\r\nor [CharName] like 'Дата ввода в эксплуатацию') and [CharValue] is not null and [CharValue] <> ''", idObj);
                    DataTable table3 = base.SelectSqlData("vP_PassportDataReports", true, str);
                    if ((table3.Rows.Count > 0) && (table3.Rows[0]["CharValue"] != DBNull.Value))
                    {
                        return table3.Rows[0]["CharValue"];
                    }
                }
            }
            return DBNull.Value;
        }
        /// <summary>
        /// год постройки
        /// </summary>
        private object GetYearConstruction(int idObj)
        {
            DataTable table = new DataTable("tSchm_ObjList");
            table.Columns.Add("typeCodeId", typeof(int));
            base.SelectSqlData(table, true, " where id = " + idObj.ToString(), null, false, 0);
            if ((table.Rows.Count > 0) && (table.Rows[0]["TypeCodeId"] != DBNull.Value))
            {
                if (Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x222)
                {
                    DataTable table2 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Год прокладки'", idObj));
                    if ((table2.Rows.Count > 0) && (table2.Rows[0]["CharValue"] != DBNull.Value))
                    {
                        return table2.Rows[0]["CharValue"];
                    }
                }
                if ((Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x223) || (Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x3d7))
                {
                    DataTable table3 = base.SelectSqlData("vP_PassportDataReports", true, string.Format("where idObj = {0} and [CharName] like 'Год постройки'", idObj));
                    if ((table3.Rows.Count > 0) && (table3.Rows[0]["CharValue"] != DBNull.Value))
                    {
                        return table3.Rows[0]["CharValue"];
                    }
                }
            }
            return DBNull.Value;
        }
        /// <summary>
        /// возвращает idEquipment
        /// </summary>
        private object method_45(int idObjList)
        {
            DataTable table = new DataTable("tSchm_ObjList");
            table.Columns.Add("typeCodeId", typeof(int));
            base.SelectSqlData(table, true, " where id = " + idObjList.ToString(), null, false, 0);
            if ((table.Rows.Count > 0) && (table.Rows[0]["TypeCodeId"] != DBNull.Value))
            {
                if (Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x222)
                {
                    DataTable table2 = base.SelectSqlData("tP_Passport", true, string.Format("where idObjList = {0} and [isActive] = '1' and deleted = '0'", idObjList));
                    if ((table2.Rows.Count > 0) && (table2.Rows[0]["idEquipment"] != DBNull.Value))
                    {
                        return table2.Rows[0]["idEquipment"];
                    }
                }
                if ((Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x223) || (Convert.ToInt32(table.Rows[0]["TypeCodeId"]) == 0x3d7))
                {
                    DataTable table3 = base.SelectSqlData("tP_Passport", true, string.Format("where idObjList = {0} and [isActive] = '1' and deleted = '0'", idObjList));
                    if ((table3.Rows.Count > 0) && (table3.Rows[0]["idEquipment"] != DBNull.Value))
                    {
                        return table3.Rows[0]["idEquipment"];
                    }
                }
            }
            return DBNull.Value;
        }

        private object method_46(int int_0)
        {
            DataTable table = new DataTable("tP_CabTesting");
            table.Columns.Add("date", typeof(DateTime));
            string str = "";
            if ((this.dataSetDamage.tJ_Damage.Rows.Count > 0) && (this.dataSetDamage.tJ_Damage.Rows[0]["datedoc"] != DBNull.Value))
            {
                str = " and [date] < '" + Convert.ToDateTime(this.dataSetDamage.tJ_Damage.Rows[0]["datedoc"]).ToString("yyyyMMdd") + "'";
            }
            base.SelectSqlData(table, true, " where idObjList = " + int_0.ToString() + str + " and deleted = 0 order by [date] desc", null, false, 0);
            if (table.Rows.Count > 0)
            {
                return table.Rows[0]["Date"];
            }
            return DBNull.Value;
        }

        private object method_47(int int_0)
        {
            DataTable table = new DataTable("tP_CabOperation");
            table.Columns.Add("datecommissioning", typeof(DateTime));
            string str = "";
            if ((this.dataSetDamage.tJ_Damage.Rows.Count > 0) && (this.dataSetDamage.tJ_Damage.Rows[0]["datedoc"] != DBNull.Value))
            {
                str = " and [datecommissioning] > '" + Convert.ToDateTime(this.dataSetDamage.tJ_Damage.Rows[0]["datedoc"]).ToString("yyyyMMdd") + "'";
            }
            base.SelectSqlData(table, true, " where idObjList = " + int_0.ToString() + str + " and deleted = 0 order by [datecommissioning]", null, false, 0);
            if (table.Rows.Count > 0)
            {
                return table.Rows[0]["datecommissioning"];
            }
            return DBNull.Value;
        }

        private void method_48()
        {
            if ((this.bindingSource_2.Current != null) && (((DataRowView)this.bindingSource_2.Current).Row["col1"] != DBNull.Value))
            {
                DataTable table = this.CreateTableClassifier();
                base.SelectSqlData(table, true, " where id = " + ((DataRowView)this.bindingSource_2.Current).Row["col1"].ToString(), null, false, 0);
                if (table.Rows.Count == 0)
                {
                    this.cmbMarkEquipment.DataSource = null;
                }
                else
                {
                    switch (table.Rows[0]["ParentKey"].ToString())
                    {
                        case ";ReportDaily;NatureDamage;HV;AirLine;":
                        case ";ReportDaily;NatureDamage;HV;CableLine;":
                            {
                                DataTable table2 = new SqlDataCommand(this.SqlSettings).SelectSqlData("select cName.id,\r\n                                                                     cName.CableMakeup + '-' + cast(cName.wires as varchar(8)) + 'x' + \r\n                                                                     convert(varchar(20), convert(float, CName.CrossSection))  \r\n                                                                \t + isnull('+' + cast(cName.wiresAddl as varchar(8))+'x'+convert(varchar(20), convert(float, CName.CrossSectionAddl))+'(N)'  , '') \r\n                                                                \t + isnull('-' + convert(varchar(20),convert(float, cV.Value)), '')\r\n                                                                \t as name\r\n                                                                from tr_Cable cName\r\n                                                                \tleft join tr_classifier cV on cV.id = cName.idVoltage\r\n                                                                where cName.CableMakeup is not null and cName.wires is not null and cName.CrossSection is not null\r\n                                                                     and cname.CableMakeup not like '[0-9]%'\r\n                                                                order by cName.CableMakeup, cName.wires, cName.CrossSection");
                                this.cmbMarkEquipment.DisplayMember = "name";
                                this.cmbMarkEquipment.ValueMember = "id";
                                this.cmbMarkEquipment.DataSource = table2;
                                break;
                            }
                        case ";ReportDaily;NatureDamage;HV;Subs;":
                            {
                                DataTable table3 = new SqlDataCommand(this.SqlSettings).SelectSqlData("select id, Name\r\n                                                                from tP_ValueLists\r\n                                                                where ParentKey = ';SubstationType;' and isGRoup = 0 and deleted = 0\r\n                                                                order by name");
                                this.cmbMarkEquipment.DisplayMember = "name";
                                this.cmbMarkEquipment.ValueMember = "id";
                                this.cmbMarkEquipment.DataSource = table3;
                                break;
                            }
                    }
                    this.cmbMarkEquipment.SelectedIndex = -1;
                }
            }
            else
            {
                this.cmbMarkEquipment.DataSource = null;
            }
        }

        private void method_49()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;Equipment;Params;'",
                Sort = "name"
            };
            this.cmbParameters.DisplayMember = "name";
            this.cmbParameters.ValueMember = "id";
            this.cmbParameters.DataSource = source;
        }

        private void CreateActDecettionRow()
        {
            DataRow row = this.dataSetDamage.tJ_DamageActDetection.NewRow();
            row["idDamage"] = -1;
            DataTable table = this.CreateTableAbnType();
            base.SelectSqlData(table, true, string.Format("where typeKontragent = {0} and deleted = 0 order by name", 0x45b), null, false, 0);
            if (table.Rows.Count > 0)
            {
                row["idOrg"] = table.Rows[0]["idAbn"];
            }
            if (((this.cmbSignCrash.DataSource != null) && (this.cmbSignCrash.DataSource is BindingSource)) && (((BindingSource)this.cmbSignCrash.DataSource).DataSource is DataTable))
            {
                DataRow[] rowArray = ((DataTable)((BindingSource)this.cmbSignCrash.DataSource).DataSource).Select("Value = 2.3");
                if (rowArray.Length != 0)
                {
                    row["idSignCrash"] = rowArray[0]["id"];
                }
            }
            if (((this.cmbTypeEquipment.DataSource != null) && (this.cmbTypeEquipment.DataSource is BindingSource)) && (((BindingSource)this.cmbTypeEquipment.DataSource).DataSource is DataTable))
            {
                DataRow[] rowArray2 = ((DataTable)((BindingSource)this.cmbTypeEquipment.DataSource).DataSource).Select("Value = 3.311");
                if (rowArray2.Length != 0)
                {
                    row["idTypeEquipment"] = rowArray2[0]["id"];
                }
            }
            if (((this.cmbReasonCrashEquipment.DataSource != null) && (this.cmbReasonCrashEquipment.DataSource is BindingSource)) && (((BindingSource)this.cmbReasonCrashEquipment.DataSource).DataSource is DataTable))
            {
                DataRow[] rowArray3 = ((DataTable)((BindingSource)this.cmbReasonCrashEquipment.DataSource).DataSource).Select("Value = 4.12 and ParentKey = ';ReportDaily;ActDetection;ReasonCrashEquipment;'");
                if (rowArray3.Length != 0)
                {
                    row["idReasonCrashEquipment"] = rowArray3[0]["id"];
                }
            }
            if (((this.cmbReasonBeginCrash.DataSource != null) && (this.cmbReasonBeginCrash.DataSource is BindingSource)) && (((BindingSource)this.cmbReasonBeginCrash.DataSource).DataSource is DataTable))
            {
                DataRow[] rowArray4 = ((DataTable)((BindingSource)this.cmbReasonBeginCrash.DataSource).DataSource).Select("Value = 4.12 and ParentKey = ';ReportDaily;ActDetection;ReasonBeginCrash;'");
                if (rowArray4.Length != 0)
                {
                    row["idReasonBeginCrash"] = rowArray4[0]["id"];
                }
            }
            if (((this.cmbStatusBeforeCrash.DataSource != null) && (this.cmbStatusBeforeCrash.DataSource is BindingSource)) && (((BindingSource)this.cmbStatusBeforeCrash.DataSource).DataSource is DataTable))
            {
                DataRow[] rowArray5 = ((DataTable)((BindingSource)this.cmbStatusBeforeCrash.DataSource).DataSource).Select("Value = 2.01");
                if (rowArray5.Length != 0)
                {
                    row["idStatusBeforeCrash"] = rowArray5[0]["id"];
                }
            }
            if (((this.cmbStatusCurrentCrash.DataSource != null) && (this.cmbStatusCurrentCrash.DataSource is BindingSource)) && (((BindingSource)this.cmbStatusCurrentCrash.DataSource).DataSource is DataTable))
            {
                DataRow[] rowArray6 = ((DataTable)((BindingSource)this.cmbStatusCurrentCrash.DataSource).DataSource).Select("Value = 2.201");
                if (rowArray6.Length != 0)
                {
                    row["idStatusCurrentCrash"] = rowArray6[0]["id"];
                }
            }
            row["idClassifierDamage"] = 0x7da;
            row["idFault"] = 0x7e4;
            this.dataSetDamage.tJ_DamageActDetection.Rows.Add(row);
        }

        private void method_50()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey like ';VoltageLevels;MV;%'",
                Sort = "value"
            };
            this.cmbVoltage.DisplayMember = "name";
            this.cmbVoltage.ValueMember = "id";
            this.cmbVoltage.DataSource = source;
            BindingSource source2 = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey like ';VoltageLevels;MV;%'",
                Sort = "value"
            };
            this.cmbVoltageSeti.DisplayMember = "name";
            this.cmbVoltageSeti.ValueMember = "id";
            this.cmbVoltageSeti.DataSource = source2;
        }

        private void method_51()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;Equipment;NodeDetail;'",
                Sort = "name"
            };
            this.cmbNodeDetail.DisplayMember = "name";
            this.cmbNodeDetail.ValueMember = "id";
            this.cmbNodeDetail.DataSource = source;
        }

        private void method_52()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;Equipment;NeutralState;'",
                Sort = "name"
            };
            this.cmbNeutralState.DisplayMember = "name";
            this.cmbNeutralState.ValueMember = "id";
            this.cmbNeutralState.DataSource = source;
            this.cmbNeutralState.DataBindings[0].DataSourceNullValue = ((DataRowView)this.cmbNeutralState.Items[0]).Row["id"];
        }

        private void method_53()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;Equipment;Material;'",
                Sort = "name"
            };
            this.cmbMaterial.DisplayMember = "name";
            this.cmbMaterial.ValueMember = "id";
            this.cmbMaterial.DataSource = source;
            this.cmbMaterial.DataBindings[0].DataSourceNullValue = ((DataRowView)this.cmbMaterial.Items[0]).Row["id"];
        }

        private void method_54()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;Equipment;ClauseWork;'",
                Sort = "name"
            };
            this.cmbClauseWork.DisplayMember = "name";
            this.cmbClauseWork.ValueMember = "id";
            this.cmbClauseWork.DataSource = source;
            this.cmbClauseWork.DataBindings[0].DataSourceNullValue = ((DataRowView)this.cmbClauseWork.Items[0]).Row["id"];
        }

        private void method_55()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;Equipment;ChrDamage;'",
                Sort = "name"
            };
            this.cmbCharacterDamage.DisplayMember = "name";
            this.cmbCharacterDamage.ValueMember = "id";
            this.cmbCharacterDamage.DataSource = source;
        }

        private void method_56()
        {
            BindingSource source = new BindingSource
            {
                DataSource = this.dtClassifier.Copy(),
                Filter = "ParentKey = ';ReportDaily;ActDetection;Equipment;ReasonDamage;'",
                Sort = "name"
            };
            this.cmbReasonDamage.DisplayMember = "name";
            this.cmbReasonDamage.ValueMember = "id";
            this.cmbReasonDamage.DataSource = source;
        }

        private void method_57()
        {
            this.cmbChairman.SelectedValueChanged -= new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.cmbMemberComission1.SelectedValueChanged -= new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.cmbMemberComission2.SelectedValueChanged -= new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.cmbMemberComission3.SelectedValueChanged -= new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.cmbMemberComission4.SelectedValueChanged -= new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.cmbMemberComission5.SelectedValueChanged -= new EventHandler(this.cmbChairman_SelectedValueChanged);
            if (this.IdDocument.HasValue)
            {
                if ((this.dataSetDamage.tJ_DamageActDetection.Rows.Count > 0) && (this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Comission"] != DBNull.Value))
                {
                    string str = this.dataSetDamage.tJ_DamageActDetection.Rows[0]["Comission"].ToString();
                    if (!string.IsNullOrEmpty(str))
                    {
                        this.dtComission.ReadXml(new StringReader(str));
                    }
                }
            }
            else
            {
                dsDamage damage = new dsDamage();
                //base.SelectSqlData(damage, damage.tJ_DamageActDetection, true, " where Comission is not null order by idDamage desc", 1);
                base.SelectSqlData(damage.tJ_DamageActDetection, true, " where Comission is not null order by idDamage desc", null, false, 1);
                if ((damage.tJ_DamageActDetection.Rows.Count > 0) && (damage.tJ_DamageActDetection.Rows[0]["Comission"] != DBNull.Value))
                {
                    string str2 = damage.tJ_DamageActDetection.Rows[0]["Comission"].ToString();
                    if (!string.IsNullOrEmpty(str2))
                    {
                        this.dtComission.ReadXml(new StringReader(str2));
                    }
                }
            }
            if (this.dtComission.Rows.Count == 0)
            {
                this.dtComission.Rows.Add(new object[0]);
            }
            this.cmbChairman.SelectedValueChanged += new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.cmbMemberComission1.SelectedValueChanged += new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.cmbMemberComission2.SelectedValueChanged += new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.cmbMemberComission3.SelectedValueChanged += new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.cmbMemberComission4.SelectedValueChanged += new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.cmbMemberComission5.SelectedValueChanged += new EventHandler(this.cmbChairman_SelectedValueChanged);
        }

        private void method_58(Control.ControlCollection controlCollection_0)
        {
            //using (IEnumerator enumerator = controlCollection_0.GetEnumerator())
            //{
            //    while (enumerator.MoveNext())
            //    {
            //        Class200 class2 = new Class200 {
            //            control_0 = (Control) enumerator.Current
            //        };
            //        if (class2.control_0 is ComboBox)
            //        {
            //            class2.control_0.Resize += new EventHandler(class2.method_0);
            //        }
            //        this.method_58(class2.control_0.Controls);
            //    }
            //}
            foreach (IEnumerator enumerator in controlCollection_0)
            {

                Control cb = (Control)enumerator.Current;
                if (cb is ComboBox)
                {
                    cb.Resize += delegate (object sender, EventArgs e)
                    {
                        if (cb is ComboBox && !cb.Focused)
                        {
                            ((ComboBox)cb).SelectionLength = 0;
                        }
                    };
                }
                this.method_58(cb.Controls);


                //Class200 class2 = new Class200
                //{
                //    ctrl = (Control)enumerator.Current
                //};

                //if (class2.ctrl is ComboBox)
                //{
                //    class2.ctrl.Resize += new EventHandler(class2.method_0);
                //}
                //this.method_58(class2.ctrl.Controls);

            }
        }

        private void ControlBlocking()
        {
            if (!this.GetflagViewDoc() && !this.chkApply.Checked)
            {
                this.cmbCompiler.ReadOnly = (false);
                this.cmbDivision.ReadOnly = (false);
                this.chkCrash.Enabled = true;
                this.buttonChooseParentDamage.Enabled = true;
                this.chkNoOff.Enabled = true;
                this.btnRefreshDataEndCrash.Enabled = true;
                this.btnRefreshDataBeginCrash.Enabled = true;
                this.dtpDateDoc.Enabled = true;
                this.cmbTypeEquipment.ReadOnly = (false);
                this.cmbSignCrash.ReadOnly = (false);
                this.cmbOrg.ReadOnly = (false);
                this.cmbReasonCrash.ReadOnly = (false);
                this.cmbReasonCrashEquipment.ReadOnly = (false);
                this.dgvNoCrashMeasure.ReadOnly = false;
                this.txtStatusCurrentCrash.ReadOnly = false;
                this.cmbStatusCurrentCrash.ReadOnly = (false);
                this.cmbStatusBeforeCrash.ReadOnly = (false);
                this.dgvDefection.ReadOnly = false;
                this.cmbFault.ReadOnly = (false);
                this.cmbClassifierDamage.ReadOnly = (false);
                this.txtReasonBeginCrash.ReadOnly = false;
                this.cmbReasonBeginCrash.ReadOnly = (false);
                this.toolStripEquipment.Enabled = true;
                this.dgvEquipment.ReadOnly = false;
                this.method_60(false);
                this.txtOrder.ReadOnly = false;
                this.txtPostChairman.ReadOnly = false;
                this.cmbChairman.ReadOnly = (false);
                this.cmbMemberComission5.ReadOnly = (false);
                this.cmbMemberComission4.ReadOnly = (false);
                this.cmbMemberComission3.ReadOnly = (false);
                this.cmbMemberComission2.ReadOnly = (false);
                this.cmbMemberComission1.ReadOnly = (false);
                this.txtPostMemeber5.ReadOnly = false;
                this.txtPostMemeber4.ReadOnly = false;
                this.txtPostMemeber3.ReadOnly = false;
                this.txtPostMemeber2.ReadOnly = false;
                this.txtPostMemeber1.ReadOnly = false;
                this.txtTotalComission.ReadOnly = false;
            }
            else
            {
                this.cmbCompiler.ReadOnly = (true);
                this.cmbDivision.ReadOnly = (true);
                this.chkCrash.Enabled = false;
                this.buttonChooseParentDamage.Enabled = false;
                this.chkNoOff.Enabled = false;
                this.btnRefreshDataEndCrash.Enabled = false;
                this.btnRefreshDataBeginCrash.Enabled = false;
                this.dtpDateDoc.Enabled = false;
                this.cmbTypeEquipment.ReadOnly = (true);
                this.cmbSignCrash.ReadOnly = (true);
                this.cmbOrg.ReadOnly = (true);
                this.cmbReasonCrash.ReadOnly = (true);
                this.cmbReasonCrashEquipment.ReadOnly = (true);
                this.dgvNoCrashMeasure.ReadOnly = true;
                this.txtStatusCurrentCrash.ReadOnly = true;
                this.cmbStatusCurrentCrash.ReadOnly = (true);
                this.cmbStatusBeforeCrash.ReadOnly = (true);
                this.dgvDefection.ReadOnly = true;
                this.cmbFault.ReadOnly = (true);
                this.cmbClassifierDamage.ReadOnly = (true);
                this.txtReasonBeginCrash.ReadOnly = true;
                this.cmbReasonBeginCrash.ReadOnly = (true);
                this.toolStripEquipment.Enabled = false;
                this.dgvEquipment.ReadOnly = true;
                this.method_60(true);
                this.txtOrder.ReadOnly = true;
                this.txtPostChairman.ReadOnly = true;
                this.cmbChairman.ReadOnly = (true);
                this.cmbMemberComission5.ReadOnly = (true);
                this.cmbMemberComission4.ReadOnly = (true);
                this.cmbMemberComission3.ReadOnly = (true);
                this.cmbMemberComission2.ReadOnly = (true);
                this.cmbMemberComission1.ReadOnly = (true);
                this.txtPostMemeber5.ReadOnly = true;
                this.txtPostMemeber4.ReadOnly = true;
                this.txtPostMemeber3.ReadOnly = true;
                this.txtPostMemeber2.ReadOnly = true;
                this.txtPostMemeber1.ReadOnly = true;
                this.txtTotalComission.ReadOnly = true;
            }
            if (this.GetflagViewDoc())
            {
                this.chkApply.Enabled = false;
                this.cmbWorkerApply.ReadOnly = (true);
                this.dtpApply.Enabled = false;
                this.buttonSave.Enabled = false;
            }
            else
            {
                this.buttonSave.Enabled = true;
            }
        }

        private void method_6()
        {
            DataRow row = this.dtNoCrashMeasure.NewRow();
            row["idNoCrashMeasure"] = 0x7ab;
            DataTable table = new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("select idabn from vAbnType where typeKontragent = {0}", 0x45b));
            if (table.Rows.Count > 0)
            {
                row["idOrg"] = table.Rows[0]["idabn"];
            }
            this.dtNoCrashMeasure.Rows.Add(row);
        }

        private void method_60(bool flgView)
        {
            bool flag;
            bool flag2;
            this.chkAutoProtect.Enabled = !flgView;
            this.cmbVoltage.ReadOnly = (flag2 = flgView);
            this.cmbParameters.ReadOnly = (flag = flag2);
            this.cmbMarkEquipment.ReadOnly = (flag);
            this.cmbVoltageSeti.ReadOnly = (flag2 = flgView);
            this.cmbNodeDetail.ReadOnly = (this.txtCountDefectEquipment.ReadOnly = flag2);
            this.schmObjDgvColumn.ReadOnly = this.txtNodeDetail.ReadOnly = flgView;
            this.txtManufacturer.ReadOnly = this.txtFactoryNumber.ReadOnly = this.txtYearManufature.ReadOnly = flgView;
            this.cmbNeutralState.ReadOnly = (this.txtClauseFail.ReadOnly = flgView);
            this.txtLengthOverload.ReadOnly = this.txtLenghtLine.ReadOnly = flgView;
            this.cmbClauseWork.ReadOnly = (flag = flgView);
            this.cmbMaterial.ReadOnly = (flag);
            this.cmbReasonDamage.ReadOnly = (flag = flgView);
            this.cmbCharacterDamage.ReadOnly = (flag);
            this.txtAssociatedFact.ReadOnly = this.txtYearBegEquipment.ReadOnly = this.txtLengthWorkEquipment.ReadOnly = flgView;
            this.dtpLastDateTest.Enabled = this.dtpTimeRecovery.Enabled = !flgView;
        }

        private string method_61(int p0)
        {
            switch ((p0 % 10))
            {
                case 1:
                    return "год";

                case 2:
                case 3:
                case 4:
                    return "года";
            }
            return "лет";
        }

        private void method_62()
        {
            int result = 0;
            if (int.TryParse(this.txtYearBegEquipment.Text, out result))
            {
                this.txtLengthWorkEquipment.Text = (this.dtpDateOwner.Value.Year - result).ToString();
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormActDetectionAddEdit));
            this.tabControl1 = new TabControl();
            this.tabPageGeneral = new TabPage();
            this.labelNumCrash = new Label();
            this.txtNumCrash = new TextBox();
            this.dataSetDamage = new dsDamage();
            this.splitContainer1 = new SplitContainer();
            this.btnOpenParentDamage = new Button();
            this.groupBoxNoCrashEvents = new GroupBox();
            this.dgvNoCrashMeasure = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idNoCrashMeasureColumn = new DataGridViewComboBoxColumn();
            this.dateCompleteDataGridViewTextBoxColumn = new DataGridViewFilterDateTimePickerColumn();
            this.idOrgColumn = new DataGridViewComboBoxColumn();
            this.bindingSource_0 = new BindingSource(this.components);
            this.ds = new DataSet();
            this.dtNoCrashMeasure = new DataTable();
            this.idNoCrashMeasure = new DataColumn();
            this.dateComplete = new DataColumn();
            this.idOrg = new DataColumn();
            this.dtDefection = new DataTable();
            this.idDefection = new DataColumn();
            this.idNPA = new DataColumn();
            this.punctNPA = new DataColumn();
            this.dataColumn_6 = new DataColumn();
            this.dtParametersEquipment = new DataTable();
            this.dataColumn_7 = new DataColumn();
            this.dataColumn_8 = new DataColumn();
            this.dataColumn_9 = new DataColumn();
            this.dataColumn_10 = new DataColumn();
            this.dataColumn_11 = new DataColumn();
            this.dataColumn_12 = new DataColumn();
            this.dataColumn_13 = new DataColumn();
            this.dtComission = new DataTable();
            this.dataColumn_14 = new DataColumn();
            this.dataColumn_15 = new DataColumn();
            this.dataColumn_16 = new DataColumn();
            this.dataColumn_17 = new DataColumn();
            this.dataColumn_18 = new DataColumn();
            this.dataColumn_19 = new DataColumn();
            this.dataColumn_20 = new DataColumn();
            this.dataColumn_21 = new DataColumn();
            this.dataColumn_22 = new DataColumn();
            this.dataColumn_23 = new DataColumn();
            this.dataColumn_24 = new DataColumn();
            this.dataColumn_25 = new DataColumn();
            this.dataColumn_26 = new DataColumn();
            this.groupBoxGeneral = new GroupBox();
            this.dtpEndCrashMoscow = new NullableDateTimePicker();
            this.dtpEndCrashLocal = new NullableDateTimePicker();
            this.label_14 = new Label();
            this.label_15 = new Label();
            this.label_16 = new Label();
            this.cmbReasonCrash = new ComboBoxReadOnly();
            this.label_13 = new Label();
            this.cmbReasonCrashEquipment = new ComboBoxReadOnly();
            this.label_12 = new Label();
            this.cmbTypeEquipment = new ComboBoxReadOnly();
            this.label_11 = new Label();
            this.cmbSignCrash = new ComboBoxReadOnly();
            this.label_10 = new Label();
            this.label_9 = new Label();
            this.cmbOrg = new ComboBoxReadOnly();
            this.chkNoOff = new CheckBox();
            this.dtpDateDoc = new NullableDateTimePicker();
            this.label_6 = new Label();
            this.btnRefreshDataEndCrash = new Button();
            this.btnRefreshDataBeginCrash = new Button();
            this.buttonChooseParentDamage = new Button();
            this.txtParentDamage = new TextBox();
            this.label_5 = new Label();
            this.chkCrash = new CheckBox();
            this.cmbDivision = new ComboBoxReadOnly();
            this.label_0 = new Label();
            this.cmbCompiler = new ComboBoxReadOnly();
            this.label_1 = new Label();
            this.dtpDateOwner = new DateTimePicker();
            this.label_2 = new Label();
            this.txtOwner = new TextBox();
            this.labelOwner = new Label();
            this.label_4 = new Label();
            this.txtNumRequest = new TextBox();
            this.tabPageDescription = new TabPage();
            this.groupBoxDescription = new GroupBox();
            this.txtReasonBeginCrash = new RichTextBox();
            this.txtStatusCurrentCrash = new RichTextBox();
            this.cmbFault = new ComboBoxReadOnly();
            this.label22 = new Label();
            this.cmbClassifierDamage = new ComboBoxReadOnly();
            this.label_20 = new Label();
            this.cmbReasonBeginCrash = new ComboBoxReadOnly();
            this.label_21 = new Label();
            this.dgvDefection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDefectionDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            this.idNPADgvColumn = new DataGridViewComboBoxColumn();
            this.punctNPADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.idOrgDefectionDgvColumn = new DataGridViewComboBoxColumn();
            this.bindingSource_1 = new BindingSource(this.components);
            this.label19 = new Label();
            this.cmbStatusCurrentCrash = new ComboBoxReadOnly();
            this.label_17 = new Label();
            this.cmbStatusBeforeCrash = new ComboBoxReadOnly();
            this.txtSchmObj = new TextBox();
            this.label_7 = new Label();
            this.label_8 = new Label();
            this.tabPageSchm = new TabPage();
            this.splitContainer2 = new SplitContainer();
            this.txtNodeDetail = new TextBox();
            this.bindingSource_2 = new BindingSource(this.components);
            this.label_33 = new Label();
            this.cmbMaterial = new ComboBoxReadOnly();
            this.label_34 = new Label();
            this.txtLenghtLine = new TextBox();
            this.chkAutoProtect = new CheckBox();
            this.label_35 = new Label();
            this.cmbMarkEquipment = new ComboBoxReadOnly();
            this.txtLengthOverload = new TextBox();
            this.cmbParameters = new ComboBoxReadOnly();
            this.label_36 = new Label();
            this.label_26 = new Label();
            this.txtClauseFail = new TextBox();
            this.label_25 = new Label();
            this.label_37 = new Label();
            this.cmbVoltage = new ComboBoxReadOnly();
            this.cmbNeutralState = new ComboBoxReadOnly();
            this.label_24 = new Label();
            this.label_31 = new Label();
            this.cmbNodeDetail = new ComboBoxReadOnly();
            this.txtYearManufature = new TextBox();
            this.label_23 = new Label();
            this.label_29 = new Label();
            this.cmbVoltageSeti = new ComboBoxReadOnly();
            this.txtFactoryNumber = new TextBox();
            this.label_27 = new Label();
            this.label_30 = new Label();
            this.txtCountDefectEquipment = new TextBox();
            this.txtManufacturer = new TextBox();
            this.label_28 = new Label();
            this.label_32 = new Label();
            this.cmbClauseWork = new ComboBoxReadOnly();
            this.label_44 = new Label();
            this.dtpTimeRecovery = new NullableDateTimePicker();
            this.label_42 = new Label();
            this.label_43 = new Label();
            this.txtLengthWorkEquipment = new TextBox();
            this.label_40 = new Label();
            this.txtYearBegEquipment = new TextBox();
            this.label_41 = new Label();
            this.txtAssociatedFact = new TextBox();
            this.label_38 = new Label();
            this.cmbReasonDamage = new ComboBoxReadOnly();
            this.label_39 = new Label();
            this.cmbCharacterDamage = new ComboBoxReadOnly();
            this.dtpLastDateTest = new NullableDateTimePicker();
            this.dgvEquipment = new DataGridView();
            this.typeEquipmentDgvColumn = new DataGridViewComboBoxColumn();
            this.idDamCharacterDgvColumn = new DataGridViewTextBoxColumn();
            this.idSchmObjDgvColumn = new DataGridViewTextBoxColumn();
            this.schmObjDgvColumn = new DataGridViewTextBoxColumn();
            this.idDamageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.col2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.col3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.schmObjNameDgvColumn = new DataGridViewTextBoxColumn();
            this.toolStripEquipment = new ToolStrip();
            this.toolBtnAddEquipment = new ToolStripButton();
            this.toolBtnDelEquipment = new ToolStripButton();
            this.label_22 = new Label();
            this.tabPageComission = new TabPage();
            this.txtPostMemeber5 = new TextBox();
            this.label_55 = new Label();
            this.cmbMemberComission5 = new ComboBoxReadOnly();
            this.txtPostMemeber4 = new TextBox();
            this.label_56 = new Label();
            this.cmbMemberComission4 = new ComboBoxReadOnly();
            this.txtTotalComission = new RichTextBox();
            this.label_48 = new Label();
            this.txtPostMemeber3 = new TextBox();
            this.label_49 = new Label();
            this.cmbMemberComission3 = new ComboBoxReadOnly();
            this.txtPostMemeber2 = new TextBox();
            this.label_50 = new Label();
            this.cmbMemberComission2 = new ComboBoxReadOnly();
            this.txtPostMemeber1 = new TextBox();
            this.label_51 = new Label();
            this.cmbMemberComission1 = new ComboBoxReadOnly();
            this.label_52 = new Label();
            this.txtPostChairman = new TextBox();
            this.label_46 = new Label();
            this.cmbChairman = new ComboBoxReadOnly();
            this.label_47 = new Label();
            this.txtOrder = new TextBox();
            this.label_45 = new Label();
            this.tabPagePrint = new TabPage();
            this.buttonSave = new Button();
            this.buttonCancel = new Button();
            this.chkApply = new CheckBox();
            this.label_53 = new Label();
            this.bindingSource_3 = new BindingSource(this.components);
            this.dataGridViewComboBoxColumn_5 = new DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dtpApply = new NullableDateTimePicker();
            this.cmbWorkerApply = new ComboBoxReadOnly();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.dataSetDamage.BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxNoCrashEvents.SuspendLayout();
            ((ISupportInitialize)this.dgvNoCrashMeasure).BeginInit();
            ((ISupportInitialize)this.bindingSource_0).BeginInit();
            this.ds.BeginInit();
            this.dtNoCrashMeasure.BeginInit();
            this.dtDefection.BeginInit();
            this.dtParametersEquipment.BeginInit();
            this.dtComission.BeginInit();
            this.groupBoxGeneral.SuspendLayout();
            this.tabPageDescription.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            ((ISupportInitialize)this.dgvDefection).BeginInit();
            ((ISupportInitialize)this.bindingSource_1).BeginInit();
            this.tabPageSchm.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((ISupportInitialize)this.bindingSource_2).BeginInit();
            ((ISupportInitialize)this.dgvEquipment).BeginInit();
            this.toolStripEquipment.SuspendLayout();
            this.tabPageComission.SuspendLayout();
            ((ISupportInitialize)this.bindingSource_3).BeginInit();
            base.SuspendLayout();
            this.tabControl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageDescription);
            this.tabControl1.Controls.Add(this.tabPageSchm);
            this.tabControl1.Controls.Add(this.tabPageComission);
            this.tabControl1.Controls.Add(this.tabPagePrint);
            this.tabControl1.Location = new Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(0x310, 0x237);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabPageGeneral.Controls.Add(this.labelNumCrash);
            this.tabPageGeneral.Controls.Add(this.txtNumCrash);
            this.tabPageGeneral.Controls.Add(this.splitContainer1);
            this.tabPageGeneral.Controls.Add(this.chkCrash);
            this.tabPageGeneral.Controls.Add(this.cmbDivision);
            this.tabPageGeneral.Controls.Add(this.label_0);
            this.tabPageGeneral.Controls.Add(this.cmbCompiler);
            this.tabPageGeneral.Controls.Add(this.label_1);
            this.tabPageGeneral.Controls.Add(this.dtpDateOwner);
            this.tabPageGeneral.Controls.Add(this.label_2);
            this.tabPageGeneral.Controls.Add(this.txtOwner);
            this.tabPageGeneral.Controls.Add(this.labelOwner);
            this.tabPageGeneral.Controls.Add(this.label_4);
            this.tabPageGeneral.Controls.Add(this.txtNumRequest);
            this.tabPageGeneral.Location = new Point(4, 0x16);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new Padding(3);
            this.tabPageGeneral.Size = new Size(0x308, 0x21d);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Общие";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            this.labelNumCrash.AutoSize = true;
            this.labelNumCrash.Location = new Point(0x28d, 0x26);
            this.labelNumCrash.Name = "labelNumCrash";
            this.labelNumCrash.Size = new Size(0x39, 13);
            this.labelNumCrash.TabIndex = 13;
            this.labelNumCrash.Text = "№ аварии";
            this.txtNumCrash.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.numCrash", true));
            this.txtNumCrash.Enabled = false;
            this.txtNumCrash.Location = new Point(0x2cc, 0x23);
            this.txtNumCrash.Name = "txtNumCrash";
            this.txtNumCrash.Size = new Size(0x34, 20);
            this.txtNumCrash.TabIndex = 12;
            this.txtNumCrash.TextChanged += new EventHandler(this.txtNumCrash_TextChanged);
            this.dataSetDamage.DataSetName = "DataSetDamage";
            this.dataSetDamage.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.splitContainer1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.splitContainer1.Location = new Point(0, 0x3e);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenParentDamage);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxNoCrashEvents);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxGeneral);
            this.splitContainer1.Panel1.Controls.Add(this.buttonChooseParentDamage);
            this.splitContainer1.Panel1.Controls.Add(this.txtParentDamage);
            this.splitContainer1.Panel1.Controls.Add(this.label_5);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new Size(0x308, 0x1df);
            this.splitContainer1.SplitterDistance = 0x193;
            this.splitContainer1.TabIndex = 11;
            this.btnOpenParentDamage.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.btnOpenParentDamage.BackgroundImage = global::DailyReport.Properties.Resources.ElementInformation;
            this.btnOpenParentDamage.BackgroundImageLayout = ImageLayout.Stretch;
            this.btnOpenParentDamage.FlatStyle = FlatStyle.Popup;
            this.btnOpenParentDamage.Location = new Point(0x2e9, 12);
            this.btnOpenParentDamage.Name = "btnOpenParentDamage";
            this.btnOpenParentDamage.Size = new Size(0x16, 0x17);
            this.btnOpenParentDamage.TabIndex = 5;
            this.btnOpenParentDamage.UseVisualStyleBackColor = true;
            this.btnOpenParentDamage.Click += new EventHandler(this.btnOpenParentDamage_Click);
            this.groupBoxNoCrashEvents.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.groupBoxNoCrashEvents.Controls.Add(this.dgvNoCrashMeasure);
            this.groupBoxNoCrashEvents.Location = new Point(0, 0x15d);
            this.groupBoxNoCrashEvents.Name = "groupBoxNoCrashEvents";
            this.groupBoxNoCrashEvents.Size = new Size(0x308, 130);
            this.groupBoxNoCrashEvents.TabIndex = 4;
            this.groupBoxNoCrashEvents.TabStop = false;
            this.groupBoxNoCrashEvents.Text = "3. Противоаварийные мероприятия";
            this.groupBoxNoCrashEvents.UseCompatibleTextRendering = true;
            this.dgvNoCrashMeasure.AutoGenerateColumns = false;
            this.dgvNoCrashMeasure.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.idNoCrashMeasureColumn, this.dateCompleteDataGridViewTextBoxColumn, this.idOrgColumn };
            this.dgvNoCrashMeasure.Columns.AddRange(dataGridViewColumns);
            this.dgvNoCrashMeasure.DataSource = this.bindingSource_0;
            this.dgvNoCrashMeasure.Dock = DockStyle.Fill;
            this.dgvNoCrashMeasure.EditMode = DataGridViewEditMode.EditOnEnter;
            this.dgvNoCrashMeasure.Location = new Point(3, 0x10);
            this.dgvNoCrashMeasure.Name = "dgvNoCrashMeasure";
            this.dgvNoCrashMeasure.RowHeadersWidth = 0x15;
            this.dgvNoCrashMeasure.Size = new Size(770, 0x6f);
            this.dgvNoCrashMeasure.TabIndex = 0;
            this.dgvNoCrashMeasure.DataError += new DataGridViewDataErrorEventHandler(this.dgvNoCrashMeasure_DataError);
            this.dgvNoCrashMeasure.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgvNoCrashMeasure_EditingControlShowing);
            this.dgvNoCrashMeasure.MouseClick += new MouseEventHandler(this.dgvNoCrashMeasure_MouseClick);
            this.idNoCrashMeasureColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.idNoCrashMeasureColumn.DataPropertyName = "idNoCrashMeasure";
            this.idNoCrashMeasureColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.idNoCrashMeasureColumn.HeaderText = "Мероприятие";
            this.idNoCrashMeasureColumn.Name = "idNoCrashMeasureColumn";
            this.idNoCrashMeasureColumn.Resizable = DataGridViewTriState.True;
            this.dateCompleteDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dateCompleteDataGridViewTextBoxColumn.DataPropertyName = "dateComplete";
            style.Format = "MMMM.yyyy";
            this.dateCompleteDataGridViewTextBoxColumn.DefaultCellStyle = style;
            this.dateCompleteDataGridViewTextBoxColumn.HeaderText = "Срок выполнения";
            this.dateCompleteDataGridViewTextBoxColumn.Name = "dateCompleteDataGridViewTextBoxColumn";
            this.dateCompleteDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.dateCompleteDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            this.idOrgColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.idOrgColumn.DataPropertyName = "idOrg";
            this.idOrgColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.idOrgColumn.HeaderText = "Организация";
            this.idOrgColumn.Name = "idOrgColumn";
            this.idOrgColumn.Resizable = DataGridViewTriState.True;
            this.bindingSource_0.DataMember = "dtNoCrashMeasure";
            this.bindingSource_0.DataSource = this.ds;
            this.ds.DataSetName = "NewDataSet";

            DataTable[] tables = new DataTable[] { this.dtNoCrashMeasure, this.dtDefection, this.dtParametersEquipment, this.dtComission };
            this.ds.Tables.AddRange(tables);

            DataColumn[] columns = new DataColumn[] { this.idNoCrashMeasure, this.dateComplete, this.idOrg };
            this.dtNoCrashMeasure.Columns.AddRange(columns);
            this.dtNoCrashMeasure.TableName = "dtNoCrashMeasure";
            this.idNoCrashMeasure.ColumnName = "idNoCrashMeasure";
            this.idNoCrashMeasure.DataType = typeof(int);
            this.dateComplete.ColumnName = "dateComplete";
            this.dateComplete.DataType = typeof(DateTime);
            this.idOrg.ColumnName = "idOrg";
            this.idOrg.DataType = typeof(int);

            DataColumn[] columnArray3 = new DataColumn[] { this.idDefection, this.idNPA, this.punctNPA, this.dataColumn_6 };
            this.dtDefection.Columns.AddRange(columnArray3);
            this.dtDefection.TableName = "dtDefection";
            this.idDefection.Caption = "idDefection";
            this.idDefection.ColumnName = "idDefection";
            this.idDefection.DataType = typeof(int);
            this.idNPA.ColumnName = "idNPA";
            this.idNPA.DataType = typeof(int);
            this.punctNPA.ColumnName = "punctNPA";
            this.dataColumn_6.ColumnName = "idOrg";
            this.dataColumn_6.DataType = typeof(int);

            DataColumn[] columnArray4 = new DataColumn[] { this.dataColumn_7, this.dataColumn_8, this.dataColumn_9, this.dataColumn_10, this.dataColumn_11, this.dataColumn_12, this.dataColumn_13 };
            this.dtParametersEquipment.Columns.AddRange(columnArray4);
            this.dtParametersEquipment.TableName = "dtParametersEquipment";
            this.dataColumn_7.ColumnName = "AutoProtect";
            this.dataColumn_7.DataType = typeof(bool);
            this.dataColumn_8.ColumnName = "idMark";
            this.dataColumn_8.DataType = typeof(int);
            this.dataColumn_9.ColumnName = "Parameters";
            this.dataColumn_9.DataType = typeof(int);
            this.dataColumn_10.ColumnName = "Voltage";
            this.dataColumn_10.DataType = typeof(int);
            this.dataColumn_11.ColumnName = "NodeDetail";
            this.dataColumn_11.DataType = typeof(int);
            this.dataColumn_12.ColumnName = "VoltageSeti";
            this.dataColumn_12.DataType = typeof(int);
            this.dataColumn_13.ColumnName = "CountDefectEquipment";
            this.dataColumn_13.DataType = typeof(int);

            DataColumn[] columnArray5 = new DataColumn[] { this.dataColumn_14, this.dataColumn_15, this.dataColumn_16, this.dataColumn_17, this.dataColumn_18, this.dataColumn_19, this.dataColumn_20, this.dataColumn_21, this.dataColumn_22, this.dataColumn_23, this.dataColumn_24, this.dataColumn_25, this.dataColumn_26 };
            this.dtComission.Columns.AddRange(columnArray5);
            this.dtComission.TableName = "dtComission";
            this.dataColumn_14.ColumnName = "Order";
            this.dataColumn_15.ColumnName = "Chairman";
            this.dataColumn_15.DataType = typeof(int);
            this.dataColumn_16.ColumnName = "PostChairman";
            this.dataColumn_17.ColumnName = "Member1";
            this.dataColumn_17.DataType = typeof(int);
            this.dataColumn_18.ColumnName = "PostMember1";
            this.dataColumn_19.ColumnName = "Member2";
            this.dataColumn_19.DataType = typeof(int);
            this.dataColumn_20.ColumnName = "PostMember2";
            this.dataColumn_21.ColumnName = "Member3";
            this.dataColumn_21.DataType = typeof(int);
            this.dataColumn_22.ColumnName = "PostMember3";
            this.dataColumn_23.ColumnName = "Member4";
            this.dataColumn_23.DataType = typeof(int);
            this.dataColumn_24.ColumnName = "PostMember4";
            this.dataColumn_25.ColumnName = "Member5";
            this.dataColumn_25.DataType = typeof(int);
            this.dataColumn_26.ColumnName = "PostMember5";

            this.groupBoxGeneral.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBoxGeneral.Controls.Add(this.dtpEndCrashMoscow);
            this.groupBoxGeneral.Controls.Add(this.dtpEndCrashLocal);
            this.groupBoxGeneral.Controls.Add(this.label_14);
            this.groupBoxGeneral.Controls.Add(this.label_15);
            this.groupBoxGeneral.Controls.Add(this.label_16);
            this.groupBoxGeneral.Controls.Add(this.cmbReasonCrash);
            this.groupBoxGeneral.Controls.Add(this.label_13);
            this.groupBoxGeneral.Controls.Add(this.cmbReasonCrashEquipment);
            this.groupBoxGeneral.Controls.Add(this.label_12);
            this.groupBoxGeneral.Controls.Add(this.cmbTypeEquipment);
            this.groupBoxGeneral.Controls.Add(this.label_11);
            this.groupBoxGeneral.Controls.Add(this.cmbSignCrash);
            this.groupBoxGeneral.Controls.Add(this.label_10);
            this.groupBoxGeneral.Controls.Add(this.label_9);
            this.groupBoxGeneral.Controls.Add(this.cmbOrg);
            this.groupBoxGeneral.Controls.Add(this.chkNoOff);
            this.groupBoxGeneral.Controls.Add(this.dtpDateDoc);
            this.groupBoxGeneral.Controls.Add(this.label_6);
            this.groupBoxGeneral.Controls.Add(this.btnRefreshDataEndCrash);
            this.groupBoxGeneral.Controls.Add(this.btnRefreshDataBeginCrash);
            this.groupBoxGeneral.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.groupBoxGeneral.Location = new Point(0, 0x2c);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new Size(0x308, 0x12b);
            this.groupBoxGeneral.TabIndex = 3;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "1. Общие сведения";
            this.dtpEndCrashMoscow.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dtpEndCrashMoscow.CustomFormat = ("dd.MM.yyyy HH:mm");
            this.dtpEndCrashMoscow.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_DamageActDetection.dateEndCrashMoscow", true, DataSourceUpdateMode.OnPropertyChanged));
            this.dtpEndCrashMoscow.Enabled = false;
            this.dtpEndCrashMoscow.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dtpEndCrashMoscow.Format = (DateTimePickerFormat.Custom);
            this.dtpEndCrashMoscow.Location = new Point(228, 270);
            this.dtpEndCrashMoscow.Name = "dtpEndCrashMoscow";
            this.dtpEndCrashMoscow.Size = new Size(510, 20);
            this.dtpEndCrashMoscow.TabIndex = 0x11;
            this.dtpEndCrashMoscow.Value = (new DateTime(0x7e0, 3, 0x1c, 0x10, 0x20, 0x37, 0x21d));
            this.dtpEndCrashLocal.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dtpEndCrashLocal.CustomFormat = ("dd.MM.yyyy HH:mm");
            this.dtpEndCrashLocal.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_DamageActDetection.dateEndCrashLocal", true));
            this.dtpEndCrashLocal.Enabled = false;
            this.dtpEndCrashLocal.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dtpEndCrashLocal.Format = (DateTimePickerFormat.Custom);
            this.dtpEndCrashLocal.Location = new Point(228, 0xf4);
            this.dtpEndCrashLocal.Name = "dtpEndCrashLocal";
            this.dtpEndCrashLocal.Size = new Size(510, 20);
            this.dtpEndCrashLocal.TabIndex = 0x10;
            this.dtpEndCrashLocal.Value = (new DateTime(0x7e0, 3, 0x1c, 0x10, 0x20, 0x37, 0x21d));
            this.dtpEndCrashLocal.ValueChanged += new EventHandler(this.dtpEndCrashLocal_ValueChanged);
            this.label_14.AutoSize = true;
            this.label_14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_14.Location = new Point(0x8e, 0x114);
            this.label_14.Name = "label17";
            this.label_14.Size = new Size(80, 13);
            this.label_14.TabIndex = 15;
            this.label_14.Text = "(московского)";
            this.label_15.AutoSize = true;
            this.label_15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_15.Location = new Point(0xa1, 250);
            this.label_15.Name = "label16";
            this.label_15.Size = new Size(0x3d, 13);
            this.label_15.TabIndex = 14;
            this.label_15.Text = "(местного)";
            this.label_16.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_16.Location = new Point(8, 250);
            this.label_16.Name = "label15";
            this.label_16.Size = new Size(0x74, 0x35);
            this.label_16.TabIndex = 13;
            this.label_16.Text = "Дата и время ликвидации аварийного режима";
            this.cmbReasonCrash.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbReasonCrash.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbReasonCrash.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbReasonCrash.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idReasonCrash", true));
            this.cmbReasonCrash.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbReasonCrash.FormattingEnabled = true;
            this.cmbReasonCrash.Location = new Point(11, 0xd7);
            this.cmbReasonCrash.Name = "cmbReasonCrash";
            this.cmbReasonCrash.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbReasonCrash.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbReasonCrash.Size = new Size(0x2f7, 0x15);
            this.cmbReasonCrash.TabIndex = 12;
            this.label_13.AutoSize = true;
            this.label_13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_13.Location = new Point(8, 0xc7);
            this.label_13.Name = "label14";
            this.label_13.Size = new Size(0x102, 13);
            this.label_13.TabIndex = 11;
            this.label_13.Text = "Классификация организационных причин аварии";
            this.cmbReasonCrashEquipment.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbReasonCrashEquipment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbReasonCrashEquipment.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbReasonCrashEquipment.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idReasonCrashEquipment", true));
            this.cmbReasonCrashEquipment.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbReasonCrashEquipment.FormattingEnabled = true;
            this.cmbReasonCrashEquipment.Location = new Point(11, 0xaf);
            this.cmbReasonCrashEquipment.Name = "cmbReasonCrashEquipment";
            this.cmbReasonCrashEquipment.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbReasonCrashEquipment.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbReasonCrashEquipment.Size = new Size(0x2f7, 0x15);
            this.cmbReasonCrashEquipment.TabIndex = 10;
            this.label_12.AutoSize = true;
            this.label_12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_12.Location = new Point(8, 0x9f);
            this.label_12.Name = "label13";
            this.label_12.Size = new Size(0x150, 13);
            this.label_12.TabIndex = 9;
            this.label_12.Text = "Классификация технических причин повреждений оборудования";
            this.cmbTypeEquipment.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbTypeEquipment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbTypeEquipment.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbTypeEquipment.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idTypeEquipment", true));
            this.cmbTypeEquipment.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbTypeEquipment.FormattingEnabled = true;
            this.cmbTypeEquipment.Location = new Point(11, 0x87);
            this.cmbTypeEquipment.Name = "cmbTypeEquipment";
            this.cmbTypeEquipment.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbTypeEquipment.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbTypeEquipment.Size = new Size(0x2f7, 0x15);
            this.cmbTypeEquipment.TabIndex = 8;
            this.label_11.AutoSize = true;
            this.label_11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_11.Location = new Point(8, 0x77);
            this.label_11.Name = "label12";
            this.label_11.Size = new Size(0xc3, 13);
            this.label_11.TabIndex = 7;
            this.label_11.Text = "Классификация видов оборудования";
            this.cmbSignCrash.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbSignCrash.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbSignCrash.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbSignCrash.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idSignCrash", true));
            this.cmbSignCrash.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbSignCrash.FormattingEnabled = true;
            this.cmbSignCrash.Location = new Point(11, 0x5f);
            this.cmbSignCrash.Name = "cmbSignCrash";
            this.cmbSignCrash.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbSignCrash.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbSignCrash.Size = new Size(0x2f7, 0x15);
            this.cmbSignCrash.TabIndex = 6;
            this.label_10.AutoSize = true;
            this.label_10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_10.Location = new Point(8, 0x4f);
            this.label_10.Name = "label11";
            this.label_10.Size = new Size(0x8d, 13);
            this.label_10.TabIndex = 5;
            this.label_10.Text = "Учетные признаки аварии";
            this.label_9.AutoSize = true;
            this.label_9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_9.Location = new Point(8, 0x36);
            this.label_9.Name = "label10";
            this.label_9.Size = new Size(0x4a, 13);
            this.label_9.TabIndex = 4;
            this.label_9.Text = "Организация";
            this.cmbOrg.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbOrg.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbOrg.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbOrg.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idOrg", true));
            this.cmbOrg.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbOrg.FormattingEnabled = true;
            this.cmbOrg.Location = new Point(0x72, 0x33);
            this.cmbOrg.Name = "cmbOrg";
            this.cmbOrg.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbOrg.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbOrg.Size = new Size(0x290, 0x15);
            this.cmbOrg.TabIndex = 3;
            this.chkNoOff.AutoSize = true;
            this.chkNoOff.DataBindings.Add(new Binding("Checked", this.dataSetDamage, "tJ_DamageActDetection.isNoOff", true));
            this.chkNoOff.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.chkNoOff.Location = new Point(326, 21);//326, 21
            this.chkNoOff.Name = "chkNoOff";
            this.chkNoOff.Size = new Size(0x49, 0x11);//73,17
            this.chkNoOff.TabIndex = 2;
            this.chkNoOff.Text = "без откл.";
            this.chkNoOff.UseVisualStyleBackColor = true;
            this.dtpDateDoc.CustomFormat = ("dd.MM.yyyy HH:mm");
            this.dtpDateDoc.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateDoc", true));
            this.dtpDateDoc.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dtpDateDoc.Format = (DateTimePickerFormat.Custom);
            this.dtpDateDoc.Location = new Point(0xa4, 0x13);
            this.dtpDateDoc.Name = "dtpDateDoc";
            this.dtpDateDoc.Size = new Size(130, 20);
            this.dtpDateDoc.TabIndex = 1;
            this.dtpDateDoc.Value = (new DateTime(0x7e0, 3, 0x1c, 0x10, 0x20, 0x37, 0x21d));
            this.label_6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_6.Location = new Point(8, 0x10);
            this.label_6.Name = "label7";
            this.label_6.Size = new Size(0x98, 0x20);
            this.label_6.TabIndex = 0;
            this.label_6.Text = "Дата и время возникновения события";

            this.btnRefreshDataBeginCrash.Size = new Size(20, 20);
            this.btnRefreshDataBeginCrash.TabIndex = 18;
            this.btnRefreshDataBeginCrash.UseVisualStyleBackColor = true;
            this.btnRefreshDataBeginCrash.Enabled = true;
            // this.btnRefreshDataBeginCrash.Click += this.KV8C4RYpMy8;
            this.btnRefreshDataBeginCrash.Click += new EventHandler(this.btnRefreshDataBeginCrash_Click);
            this.btnRefreshDataBeginCrash.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnRefreshDataBeginCrash.BackgroundImage = global::DailyReport.Properties.Resources.refresh_16;
            this.btnRefreshDataBeginCrash.BackgroundImageLayout = ImageLayout.Stretch;
            this.btnRefreshDataBeginCrash.FlatStyle = FlatStyle.Popup;
            this.btnRefreshDataBeginCrash.Location = new Point(300, 19);
            //this.btnRefreshDataBeginCrash.Name = IEke2PrwQVqDJhcsPJkT(500352);


            this.btnRefreshDataEndCrash.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnRefreshDataEndCrash.BackgroundImage = global::DailyReport.Properties.Resources.refresh_16;
            this.btnRefreshDataEndCrash.BackgroundImageLayout = ImageLayout.Stretch;
            this.btnRefreshDataEndCrash.Enabled = true;
            this.btnRefreshDataEndCrash.Location = new Point(745, 244);// (300, 19);
            this.btnRefreshDataEndCrash.UseVisualStyleBackColor = true;
            this.btnRefreshDataEndCrash.Size = new Size(20, 20);
            this.btnRefreshDataEndCrash.FlatStyle = FlatStyle.Popup;
            this.btnRefreshDataEndCrash.TabIndex = 19;
            this.btnRefreshDataEndCrash.Click += new EventHandler(this.btnRefreshDataEndCrash_Click); // D4bC4LohPOe

            this.buttonChooseParentDamage.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.buttonChooseParentDamage.Location = new Point(0x2cc, 12);
            this.buttonChooseParentDamage.Name = "buttonChooseParentDamage";
            this.buttonChooseParentDamage.Size = new Size(0x1a, 0x17);
            this.buttonChooseParentDamage.TabIndex = 2;
            this.buttonChooseParentDamage.Text = "...";
            this.buttonChooseParentDamage.UseVisualStyleBackColor = true;
            this.buttonChooseParentDamage.Click += new EventHandler(this.buttonChooseParentDamage_Click);
            this.txtParentDamage.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtParentDamage.BackColor = SystemColors.Window;
            this.txtParentDamage.Location = new Point(130, 12);
            this.txtParentDamage.Name = "txtParentDamage";
            this.txtParentDamage.ReadOnly = true;
            this.txtParentDamage.Size = new Size(580, 20);
            this.txtParentDamage.TabIndex = 1;
            this.label_5.Location = new Point(8, 9);
            this.label_5.Name = "label6";
            this.label_5.Size = new Size(0x74, 0x20);
            this.label_5.TabIndex = 0;
            this.label_5.Text = "Документ аварийного события";
            this.chkCrash.AutoSize = true;
            this.chkCrash.DataBindings.Add(new Binding("Checked", this.dataSetDamage, "tJ_DamageActDetection.isCrash", true));
            this.chkCrash.Location = new Point(0x248, 0x24);
            this.chkCrash.Name = "chkCrash";
            this.chkCrash.Size = new Size(0x3f, 0x11);
            this.chkCrash.TabIndex = 10;
            this.chkCrash.Text = "Авария";
            this.chkCrash.UseVisualStyleBackColor = true;
            this.chkCrash.CheckedChanged += new EventHandler(this.chkCrash_CheckedChanged);
            this.cmbDivision.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbDivision.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbDivision.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idDivision", true));
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new Point(390, 0x22);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbDivision.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbDivision.Size = new Size(0xae, 0x15);
            this.cmbDivision.TabIndex = 9;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(0x12e, 0x23);
            this.label_0.Name = "label5";
            this.label_0.Size = new Size(0x52, 13);
            this.label_0.TabIndex = 8;
            this.label_0.Text = "Сетевой район";
            this.cmbCompiler.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbCompiler.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbCompiler.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idCompiler", true));
            this.cmbCompiler.FormattingEnabled = true;
            this.cmbCompiler.Location = new Point(0x72, 0x20);
            this.cmbCompiler.Name = "cmbCompiler";
            this.cmbCompiler.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbCompiler.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbCompiler.Size = new Size(0xa6, 0x15);
            this.cmbCompiler.TabIndex = 7;
            this.label_1.Location = new Point(8, 0x1d);
            this.label_1.Name = "label4";
            this.label_1.Size = new Size(0x68, 30);
            this.label_1.TabIndex = 6;
            this.label_1.Text = "Ответственный за оформление акта";
            this.dtpDateOwner.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateOwner.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateOwner", true));
            this.dtpDateOwner.Format = DateTimePickerFormat.Custom;
            this.dtpDateOwner.Location = new Point(0x267, 6);
            this.dtpDateOwner.Name = "dtpDateOwner";
            this.dtpDateOwner.Size = new Size(0x99, 20);
            this.dtpDateOwner.TabIndex = 5;
            this.dtpDateOwner.ValueChanged += new EventHandler(this.dtpDateOwner_ValueChanged);
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(0x1f3, 9);
            this.label_2.Name = "label3";
            this.label_2.Size = new Size(110, 13);
            this.label_2.TabIndex = 4;
            this.label_2.Text = "Дата создания акта";
            this.txtOwner.BackColor = SystemColors.Window;
            this.txtOwner.Location = new Point(0x11e, 6);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new Size(0xcf, 20);
            this.txtOwner.TabIndex = 3;
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new Point(0xd9, 9);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new Size(0x3f, 13);
            this.labelOwner.TabIndex = 2;
            this.labelOwner.Text = "Автор акта";
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(8, 9);
            this.label_4.Name = "label1";
            this.label_4.Size = new Size(80, 13);
            this.label_4.TabIndex = 1;
            this.label_4.Text = "Номер заявки";
            this.txtNumRequest.BackColor = SystemColors.Window;
            this.txtNumRequest.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.NumRequest", true));
            this.txtNumRequest.Location = new Point(0x72, 6);
            this.txtNumRequest.Name = "txtNumRequest";
            this.txtNumRequest.ReadOnly = true;
            this.txtNumRequest.Size = new Size(80, 20);
            this.txtNumRequest.TabIndex = 0;
            this.tabPageDescription.Controls.Add(this.groupBoxDescription);
            this.tabPageDescription.Location = new Point(4, 0x16);
            this.tabPageDescription.Name = "tabPageDescription";
            this.tabPageDescription.Size = new Size(0x308, 0x21d);
            this.tabPageDescription.TabIndex = 4;
            this.tabPageDescription.Text = "Описательный блок";
            this.tabPageDescription.UseVisualStyleBackColor = true;
            this.groupBoxDescription.Controls.Add(this.txtReasonBeginCrash);
            this.groupBoxDescription.Controls.Add(this.txtStatusCurrentCrash);
            this.groupBoxDescription.Controls.Add(this.cmbFault);
            this.groupBoxDescription.Controls.Add(this.label22);
            this.groupBoxDescription.Controls.Add(this.cmbClassifierDamage);
            this.groupBoxDescription.Controls.Add(this.label_20);
            this.groupBoxDescription.Controls.Add(this.cmbReasonBeginCrash);
            this.groupBoxDescription.Controls.Add(this.label_21);
            this.groupBoxDescription.Controls.Add(this.dgvDefection);
            this.groupBoxDescription.Controls.Add(this.label19);
            this.groupBoxDescription.Controls.Add(this.cmbStatusCurrentCrash);
            this.groupBoxDescription.Controls.Add(this.label_17);
            this.groupBoxDescription.Controls.Add(this.cmbStatusBeforeCrash);
            this.groupBoxDescription.Controls.Add(this.txtSchmObj);
            this.groupBoxDescription.Controls.Add(this.label_7);
            this.groupBoxDescription.Controls.Add(this.label_8);
            this.groupBoxDescription.Dock = DockStyle.Fill;
            this.groupBoxDescription.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.groupBoxDescription.Location = new Point(0, 0);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new Size(0x308, 0x21d);
            this.groupBoxDescription.TabIndex = 0;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "2. Описательный блок";
            this.txtReasonBeginCrash.AcceptsTab = true;
            this.txtReasonBeginCrash.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.txtReasonBeginCrash.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.ReasonBeginCrash", true));
            this.txtReasonBeginCrash.Font = new Font("Microsoft Sans Serif", 8.25f);
            this.txtReasonBeginCrash.Location = new Point(8, 0x175);
            this.txtReasonBeginCrash.Name = "txtReasonBeginCrash";
            this.txtReasonBeginCrash.Size = new Size(0x2f6, 0x44);
            this.txtReasonBeginCrash.TabIndex = 0x19;
            this.txtReasonBeginCrash.Text = "";
            this.txtStatusCurrentCrash.AcceptsTab = true;
            this.txtStatusCurrentCrash.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtStatusCurrentCrash.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.StatusCurrentCrash", true));
            this.txtStatusCurrentCrash.Font = new Font("Microsoft Sans Serif", 8.25f);
            this.txtStatusCurrentCrash.Location = new Point(9, 0x7d);
            this.txtStatusCurrentCrash.Name = "txtStatusCurrentCrash";
            this.txtStatusCurrentCrash.Size = new Size(0x2f5, 0x34);
            this.txtStatusCurrentCrash.TabIndex = 0x18;
            this.txtStatusCurrentCrash.Text = "";
            this.cmbFault.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.cmbFault.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbFault.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbFault.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idFault", true));
            this.cmbFault.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbFault.FormattingEnabled = true;
            this.cmbFault.Location = new Point(9, 0x202);
            this.cmbFault.Name = "cmbFault";
            this.cmbFault.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbFault.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbFault.Size = new Size(0x2f5, 0x15);
            this.cmbFault.TabIndex = 0x17;
            this.label22.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label22.Location = new Point(9, 0x1e3);
            this.label22.Name = "label22";
            this.label22.Size = new Size(0x2f3, 0x1c);
            this.label22.TabIndex = 0x16;
            this.label22.Text = global::DailyReport.Properties.Resources.label22;//resources.GetString("label22.Text");
            this.cmbClassifierDamage.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.cmbClassifierDamage.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbClassifierDamage.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbClassifierDamage.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idClassifierDamage", true));
            this.cmbClassifierDamage.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbClassifierDamage.FormattingEnabled = true;
            this.cmbClassifierDamage.Location = new Point(8, 460);
            this.cmbClassifierDamage.Name = "cmbClassifierDamage";
            this.cmbClassifierDamage.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbClassifierDamage.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbClassifierDamage.Size = new Size(0x2f5, 0x15);
            this.cmbClassifierDamage.TabIndex = 0x15;
            this.label_20.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_20.AutoSize = true;
            this.label_20.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_20.Location = new Point(4, 0x1bc);
            this.label_20.Name = "label21";
            this.label_20.Size = new Size(0x24b, 13);
            this.label_20.TabIndex = 20;
            this.label_20.Text = "Перечень и описание повреждения оборудования объектов электроэнергетики и энергопринимающих устройств";
            this.cmbReasonBeginCrash.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.cmbReasonBeginCrash.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbReasonBeginCrash.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbReasonBeginCrash.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idReasonBeginCrash", true));
            this.cmbReasonBeginCrash.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbReasonBeginCrash.FormattingEnabled = true;
            this.cmbReasonBeginCrash.Location = new Point(8, 0x162);
            this.cmbReasonBeginCrash.Name = "cmbReasonBeginCrash";
            this.cmbReasonBeginCrash.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbReasonBeginCrash.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbReasonBeginCrash.Size = new Size(0x2f4, 0x15);
            this.cmbReasonBeginCrash.TabIndex = 0x13;
            this.label_21.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_21.AutoSize = true;
            this.label_21.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_21.Location = new Point(6, 0x152);
            this.label_21.Name = "label20";
            this.label_21.Size = new Size(0xf6, 13);
            this.label_21.TabIndex = 0x12;
            this.label_21.Text = "Причины возникновения аварии и ее развития";
            this.dgvDefection.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dgvDefection.AutoGenerateColumns = false;
            this.dgvDefection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray6 = new DataGridViewColumn[] { this.idDefectionDataGridViewTextBoxColumn, this.idNPADgvColumn, this.punctNPADataGridViewTextBoxColumn, this.idOrgDefectionDgvColumn };
            this.dgvDefection.Columns.AddRange(columnArray6);
            this.dgvDefection.DataSource = this.bindingSource_1;
            this.dgvDefection.Location = new Point(0, 0xdd);
            this.dgvDefection.Margin = new Padding(2);
            this.dgvDefection.Name = "dgvDefection";
            this.dgvDefection.RowHeadersWidth = 0x16;
            this.dgvDefection.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dgvDefection.RowTemplate.Height = 0x18;
            this.dgvDefection.Size = new Size(0x309, 0x73);
            this.dgvDefection.TabIndex = 0x11;
            this.dgvDefection.DataError += new DataGridViewDataErrorEventHandler(this.dgvNoCrashMeasure_DataError);
            this.idDefectionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.idDefectionDataGridViewTextBoxColumn.DataPropertyName = "idDefection";
            this.idDefectionDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.idDefectionDataGridViewTextBoxColumn.FillWeight = 103.6082f;
            this.idDefectionDataGridViewTextBoxColumn.HeaderText = "Описание нарушения";
            this.idDefectionDataGridViewTextBoxColumn.Name = "idDefectionDataGridViewTextBoxColumn";
            this.idDefectionDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.idNPADgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.idNPADgvColumn.DataPropertyName = "idNPA";
            this.idNPADgvColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.idNPADgvColumn.HeaderText = "Наименование НПА (НТД)";
            this.idNPADgvColumn.Name = "idNPADgvColumn";
            this.idNPADgvColumn.Resizable = DataGridViewTriState.True;
            this.idNPADgvColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            this.punctNPADataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.punctNPADataGridViewTextBoxColumn.DataPropertyName = "punctNPA";
            this.punctNPADataGridViewTextBoxColumn.FillWeight = 50f;
            this.punctNPADataGridViewTextBoxColumn.HeaderText = "Пункт НПА (НТД)";
            this.punctNPADataGridViewTextBoxColumn.Name = "punctNPADataGridViewTextBoxColumn";
            this.idOrgDefectionDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.idOrgDefectionDgvColumn.DataPropertyName = "idOrg";
            this.idOrgDefectionDgvColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.idOrgDefectionDgvColumn.FillWeight = 103.6082f;
            this.idOrgDefectionDgvColumn.HeaderText = "Организация";
            this.idOrgDefectionDgvColumn.Name = "idOrgDefectionDgvColumn";
            this.idOrgDefectionDgvColumn.Resizable = DataGridViewTriState.True;
            this.bindingSource_1.DataMember = "dtDefection";
            this.bindingSource_1.DataSource = this.ds;
            this.label19.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label19.Location = new Point(6, 180);
            this.label19.Name = "label19";
            this.label19.Size = new Size(0x2f7, 0x27);
            this.label19.TabIndex = 0x10;
            //this.label19.Text = resources.GetString("label19.Text");
            this.label19.Text = global::DailyReport.Properties.Resources.label19;
            this.cmbStatusCurrentCrash.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbStatusCurrentCrash.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbStatusCurrentCrash.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbStatusCurrentCrash.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idStatusCurrentCrash", true));
            this.cmbStatusCurrentCrash.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbStatusCurrentCrash.FormattingEnabled = true;
            this.cmbStatusCurrentCrash.Location = new Point(9, 0x6a);
            this.cmbStatusCurrentCrash.Name = "cmbStatusCurrentCrash";
            this.cmbStatusCurrentCrash.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbStatusCurrentCrash.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbStatusCurrentCrash.Size = new Size(0x2f4, 0x15);
            this.cmbStatusCurrentCrash.TabIndex = 15;
            this.label_17.AutoSize = true;
            this.label_17.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_17.Location = new Point(9, 90);
            this.label_17.Name = "label18";
            this.label_17.Size = new Size(0x288, 13);
            this.label_17.TabIndex = 14;
            this.label_17.Text = "Описание состояния и режима работы объектов электроэнергетики и (или) энергопринимающих установок во время аварии";
            this.cmbStatusBeforeCrash.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbStatusBeforeCrash.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbStatusBeforeCrash.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbStatusBeforeCrash.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_DamageActDetection.idStatusBeforeCrash", true));
            this.cmbStatusBeforeCrash.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbStatusBeforeCrash.FormattingEnabled = true;
            this.cmbStatusBeforeCrash.Location = new Point(9, 0x42);
            this.cmbStatusBeforeCrash.Name = "cmbStatusBeforeCrash";
            this.cmbStatusBeforeCrash.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbStatusBeforeCrash.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbStatusBeforeCrash.Size = new Size(0x2f5, 0x15);
            this.cmbStatusBeforeCrash.TabIndex = 13;
            this.txtSchmObj.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtSchmObj.BackColor = SystemColors.Window;
            this.txtSchmObj.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtSchmObj.Location = new Point(0x38, 40);
            this.txtSchmObj.Name = "txtSchmObj";
            this.txtSchmObj.ReadOnly = true;
            this.txtSchmObj.Size = new Size(710, 20);
            this.txtSchmObj.TabIndex = 2;
            this.label_7.AutoSize = true;
            this.label_7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_7.Location = new Point(6, 0x2b);
            this.label_7.Name = "label9";
            this.label_7.Size = new Size(0x2d, 13);
            this.label_7.TabIndex = 1;
            this.label_7.Text = "Объект";
            this.label_8.AutoSize = true;
            this.label_8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_8.Location = new Point(6, 0x13);
            this.label_8.Name = "label8";
            this.label_8.Size = new Size(0x2b6, 13);
            this.label_8.TabIndex = 0;
            this.label_8.Text = "Описание состояния и режима работы объектов электроэнергетики и (или) энергопринимающих установок до возникновения аварии";
            this.tabPageSchm.Controls.Add(this.splitContainer2);
            this.tabPageSchm.Controls.Add(this.dgvEquipment);
            this.tabPageSchm.Controls.Add(this.toolStripEquipment);
            this.tabPageSchm.Controls.Add(this.label_22);
            this.tabPageSchm.Location = new Point(4, 0x16);
            this.tabPageSchm.Name = "tabPageSchm";
            this.tabPageSchm.Padding = new Padding(3);
            this.tabPageSchm.Size = new Size(0x308, 0x21d);
            this.tabPageSchm.TabIndex = 1;
            this.tabPageSchm.Text = "Оборудование";
            this.tabPageSchm.UseVisualStyleBackColor = true;
            this.splitContainer2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.splitContainer2.Location = new Point(3, 0x99);
            this.splitContainer2.Margin = new Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Panel1.Controls.Add(this.txtNodeDetail);
            this.splitContainer2.Panel1.Controls.Add(this.label_33);
            this.splitContainer2.Panel1.Controls.Add(this.cmbMaterial);
            this.splitContainer2.Panel1.Controls.Add(this.label_34);
            this.splitContainer2.Panel1.Controls.Add(this.txtLenghtLine);
            this.splitContainer2.Panel1.Controls.Add(this.chkAutoProtect);
            this.splitContainer2.Panel1.Controls.Add(this.label_35);
            this.splitContainer2.Panel1.Controls.Add(this.cmbMarkEquipment);
            this.splitContainer2.Panel1.Controls.Add(this.txtLengthOverload);
            this.splitContainer2.Panel1.Controls.Add(this.cmbParameters);
            this.splitContainer2.Panel1.Controls.Add(this.label_36);
            this.splitContainer2.Panel1.Controls.Add(this.label_26);
            this.splitContainer2.Panel1.Controls.Add(this.txtClauseFail);
            this.splitContainer2.Panel1.Controls.Add(this.label_25);
            this.splitContainer2.Panel1.Controls.Add(this.label_37);
            this.splitContainer2.Panel1.Controls.Add(this.cmbVoltage);
            this.splitContainer2.Panel1.Controls.Add(this.cmbNeutralState);
            this.splitContainer2.Panel1.Controls.Add(this.label_24);
            this.splitContainer2.Panel1.Controls.Add(this.label_31);
            this.splitContainer2.Panel1.Controls.Add(this.cmbNodeDetail);
            this.splitContainer2.Panel1.Controls.Add(this.txtYearManufature);
            this.splitContainer2.Panel1.Controls.Add(this.label_23);
            this.splitContainer2.Panel1.Controls.Add(this.label_29);
            this.splitContainer2.Panel1.Controls.Add(this.cmbVoltageSeti);
            this.splitContainer2.Panel1.Controls.Add(this.txtFactoryNumber);
            this.splitContainer2.Panel1.Controls.Add(this.label_27);
            this.splitContainer2.Panel1.Controls.Add(this.label_30);
            this.splitContainer2.Panel1.Controls.Add(this.txtCountDefectEquipment);
            this.splitContainer2.Panel1.Controls.Add(this.txtManufacturer);
            this.splitContainer2.Panel1.Controls.Add(this.label_28);
            this.splitContainer2.Panel2.Controls.Add(this.label_32);
            this.splitContainer2.Panel2.Controls.Add(this.cmbClauseWork);
            this.splitContainer2.Panel2.Controls.Add(this.label_44);
            this.splitContainer2.Panel2.Controls.Add(this.dtpTimeRecovery);
            this.splitContainer2.Panel2.Controls.Add(this.label_42);
            this.splitContainer2.Panel2.Controls.Add(this.label_43);
            this.splitContainer2.Panel2.Controls.Add(this.txtLengthWorkEquipment);
            this.splitContainer2.Panel2.Controls.Add(this.label_40);
            this.splitContainer2.Panel2.Controls.Add(this.txtYearBegEquipment);
            this.splitContainer2.Panel2.Controls.Add(this.label_41);
            this.splitContainer2.Panel2.Controls.Add(this.txtAssociatedFact);
            this.splitContainer2.Panel2.Controls.Add(this.label_38);
            this.splitContainer2.Panel2.Controls.Add(this.cmbReasonDamage);
            this.splitContainer2.Panel2.Controls.Add(this.label_39);
            this.splitContainer2.Panel2.Controls.Add(this.cmbCharacterDamage);
            this.splitContainer2.Panel2.Controls.Add(this.dtpLastDateTest);
            this.splitContainer2.Size = new Size(0x305, 0x18a);
            this.splitContainer2.SplitterDistance = 0x15a;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0x1c;
            this.txtNodeDetail.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtNodeDetail.DataBindings.Add(new Binding("Text", this.bindingSource_2, "nodeDetailTxt", true));
            this.txtNodeDetail.Location = new Point(0x7f, 0x79);
            this.txtNodeDetail.Name = "txtNodeDetail";
            this.txtNodeDetail.Size = new Size(0xcf, 20);
            this.txtNodeDetail.TabIndex = 0x20;
            this.bindingSource_2.DataMember = "tJ_DamageCharacter";
            this.bindingSource_2.DataSource = this.dataSetDamage;
            this.bindingSource_2.CurrentChanged += new EventHandler(this.bindingSource_2_CurrentChanged);
            this.label_33.AutoSize = true;
            this.label_33.Location = new Point(11, 0x16a);
            this.label_33.Margin = new Padding(2, 0, 2, 0);
            this.label_33.Name = "label37";
            this.label_33.Size = new Size(0x39, 13);
            this.label_33.TabIndex = 0x1f;
            this.label_33.Text = "Материал";
            this.cmbMaterial.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbMaterial.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbMaterial.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbMaterial.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_2, "idMaterial", true));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new Point(0x7f, 0x167);
            this.cmbMaterial.Margin = new Padding(2);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbMaterial.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbMaterial.Size = new Size(0xcf, 0x15);
            this.cmbMaterial.TabIndex = 30;
            this.label_34.AutoSize = true;
            this.label_34.Location = new Point(11, 0x153);
            this.label_34.Margin = new Padding(2, 0, 2, 0);
            this.label_34.Name = "label36";
            this.label_34.Size = new Size(0x5d, 13);
            this.label_34.TabIndex = 0x1d;
            this.label_34.Text = "Длина КЛ, ВЛ, м";
            this.txtLenghtLine.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtLenghtLine.DataBindings.Add(new Binding("Text", this.bindingSource_2, "LengthLine", true));
            this.txtLenghtLine.Location = new Point(0x7f, 0x151);
            this.txtLenghtLine.Margin = new Padding(2);
            this.txtLenghtLine.Name = "txtLenghtLine";
            this.txtLenghtLine.Size = new Size(0xcf, 20);
            this.txtLenghtLine.TabIndex = 0x1c;
            this.chkAutoProtect.AutoSize = true;
            this.chkAutoProtect.DataBindings.Add(new Binding("Checked", this.bindingSource_2, "AutoProtect", true));
            this.chkAutoProtect.Location = new Point(14, 6);
            this.chkAutoProtect.Margin = new Padding(2);
            this.chkAutoProtect.Name = "chkAutoProtect";
            this.chkAutoProtect.Size = new Size(0x97, 0x11);
            this.chkAutoProtect.TabIndex = 11;
            this.chkAutoProtect.Text = "Автоматическая защита";
            this.chkAutoProtect.UseVisualStyleBackColor = true;
            this.label_35.Location = new Point(11, 0x132);
            this.label_35.Margin = new Padding(2, 0, 2, 0);
            this.label_35.Name = "label35";
            this.label_35.Size = new Size(0x9e, 0x1d);
            this.label_35.TabIndex = 0x1b;
            this.label_35.Text = "Продолжительность работы оборудования с перегрузкой";
            this.cmbMarkEquipment.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbMarkEquipment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbMarkEquipment.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbMarkEquipment.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_2, "idMark", true));
            this.cmbMarkEquipment.FormattingEnabled = true;
            this.cmbMarkEquipment.Location = new Point(0x7f, 0x1c);
            this.cmbMarkEquipment.Margin = new Padding(2);
            this.cmbMarkEquipment.Name = "cmbMarkEquipment";
            this.cmbMarkEquipment.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbMarkEquipment.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbMarkEquipment.Size = new Size(0xcf, 0x15);
            this.cmbMarkEquipment.TabIndex = 3;
            this.txtLengthOverload.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtLengthOverload.DataBindings.Add(new Binding("Text", this.bindingSource_2, "LengthOverload", true));
            this.txtLengthOverload.Location = new Point(0xb8, 0x13a);
            this.txtLengthOverload.Margin = new Padding(2);
            this.txtLengthOverload.Name = "txtLengthOverload";
            this.txtLengthOverload.Size = new Size(150, 20);
            this.txtLengthOverload.TabIndex = 0x1a;
            this.cmbParameters.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbParameters.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbParameters.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbParameters.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_2, "idParameters", true));
            this.cmbParameters.FormattingEnabled = true;
            this.cmbParameters.Location = new Point(0x7f, 0x34);
            this.cmbParameters.Margin = new Padding(2);
            this.cmbParameters.Name = "cmbParameters";
            this.cmbParameters.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbParameters.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbParameters.Size = new Size(0xcf, 0x15);
            this.cmbParameters.TabIndex = 4;
            this.label_36.AutoSize = true;
            this.label_36.Location = new Point(11, 0x11e);
            this.label_36.Margin = new Padding(2, 0, 2, 0);
            this.label_36.Name = "label34";
            this.label_36.Size = new Size(0xa3, 13);
            this.label_36.TabIndex = 0x19;
            this.label_36.Text = "Условия отказа оборудования";
            this.label_26.AutoSize = true;
            this.label_26.Location = new Point(11, 30);
            this.label_26.Margin = new Padding(2, 0, 2, 0);
            this.label_26.Name = "label24";
            this.label_26.Size = new Size(40, 13);
            this.label_26.TabIndex = 5;
            this.label_26.Text = "Марка";
            this.txtClauseFail.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtClauseFail.DataBindings.Add(new Binding("Text", this.bindingSource_2, "ClauseFail", true));
            this.txtClauseFail.Location = new Point(0xb8, 0x11c);
            this.txtClauseFail.Margin = new Padding(2);
            this.txtClauseFail.Name = "txtClauseFail";
            this.txtClauseFail.Size = new Size(150, 20);
            this.txtClauseFail.TabIndex = 0x18;
            this.label_25.AutoSize = true;
            this.label_25.Location = new Point(11, 0x36);
            this.label_25.Margin = new Padding(2, 0, 2, 0);
            this.label_25.Name = "label25";
            this.label_25.Size = new Size(0x42, 13);
            this.label_25.TabIndex = 6;
            this.label_25.Text = "Параметры";
            this.label_37.AutoSize = true;
            this.label_37.Location = new Point(11, 0x106);
            this.label_37.Margin = new Padding(2, 0, 2, 0);
            this.label_37.Name = "label33";
            this.label_37.Size = new Size(0x6f, 13);
            this.label_37.TabIndex = 0x17;
            this.label_37.Text = "Состояние нейтрали";
            this.cmbVoltage.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbVoltage.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbVoltage.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbVoltage.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_2, "idVoltage", true));
            this.cmbVoltage.FormattingEnabled = true;
            this.cmbVoltage.Location = new Point(0xa6, 0x4c);
            this.cmbVoltage.Margin = new Padding(2);
            this.cmbVoltage.Name = "cmbVoltage";
            this.cmbVoltage.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbVoltage.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbVoltage.Size = new Size(0xa8, 0x15);
            this.cmbVoltage.TabIndex = 7;
            this.cmbNeutralState.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbNeutralState.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbNeutralState.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbNeutralState.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_2, "idNeutralState", true));
            this.cmbNeutralState.FormattingEnabled = true;
            this.cmbNeutralState.Location = new Point(0x7f, 0x103);
            this.cmbNeutralState.Margin = new Padding(2);
            this.cmbNeutralState.Name = "cmbNeutralState";
            this.cmbNeutralState.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbNeutralState.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbNeutralState.Size = new Size(0xcf, 0x15);
            this.cmbNeutralState.TabIndex = 0x16;
            this.label_24.AutoSize = true;
            this.label_24.Location = new Point(11, 0x4f);
            this.label_24.Margin = new Padding(2, 0, 2, 0);
            this.label_24.Name = "label26";
            this.label_24.Size = new Size(0x9a, 13);
            this.label_24.TabIndex = 8;
            this.label_24.Text = "Контсруктивное напряжение";
            this.label_31.AutoSize = true;
            this.label_31.Location = new Point(11, 0xef);
            this.label_31.Margin = new Padding(2, 0, 2, 0);
            this.label_31.Name = "label32";
            this.label_31.Size = new Size(0xac, 13);
            this.label_31.TabIndex = 0x15;
            this.label_31.Text = "Год изготовления оборудования";
            this.cmbNodeDetail.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbNodeDetail.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbNodeDetail.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbNodeDetail.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_2, "nodeDetail", true));
            this.cmbNodeDetail.FormattingEnabled = true;
            this.cmbNodeDetail.Location = new Point(0x7f, 0x65);
            this.cmbNodeDetail.Margin = new Padding(2);
            this.cmbNodeDetail.Name = "cmbNodeDetail";
            this.cmbNodeDetail.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbNodeDetail.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbNodeDetail.Size = new Size(0xcf, 0x15);
            this.cmbNodeDetail.TabIndex = 9;
            this.txtYearManufature.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtYearManufature.DataBindings.Add(new Binding("Text", this.bindingSource_2, "YearManufacture", true));
            this.txtYearManufature.Location = new Point(0xb8, 0xed);
            this.txtYearManufature.Margin = new Padding(2);
            this.txtYearManufature.Name = "txtYearManufature";
            this.txtYearManufature.Size = new Size(150, 20);
            this.txtYearManufature.TabIndex = 20;
            this.txtYearManufature.Enter += new EventHandler(this.txtYearManufature_Enter);
            this.txtYearManufature.Leave += new EventHandler(this.txtYearManufature_Leave);
            this.label_23.AutoSize = true;
            this.label_23.Location = new Point(11, 0x67);
            this.label_23.Margin = new Padding(2, 0, 2, 0);
            this.label_23.Name = "label27";
            this.label_23.Size = new Size(0x4a, 13);
            this.label_23.TabIndex = 10;
            this.label_23.Text = "Узел. деталь";
            this.label_29.AutoSize = true;
            this.label_29.Location = new Point(11, 0xd8);
            this.label_29.Margin = new Padding(2, 0, 2, 0);
            this.label_29.Name = "label31";
            this.label_29.Size = new Size(0x61, 13);
            this.label_29.TabIndex = 0x13;
            this.label_29.Text = "Заводской номер";
            this.cmbVoltageSeti.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbVoltageSeti.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbVoltageSeti.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbVoltageSeti.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_2, "idVoltageSeti", true));
            this.cmbVoltageSeti.FormattingEnabled = true;
            this.cmbVoltageSeti.Location = new Point(0xa6, 0xa7);
            this.cmbVoltageSeti.Margin = new Padding(2);
            this.cmbVoltageSeti.Name = "cmbVoltageSeti";
            this.cmbVoltageSeti.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbVoltageSeti.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbVoltageSeti.Size = new Size(0xa8, 0x15);
            this.cmbVoltageSeti.TabIndex = 12;
            this.txtFactoryNumber.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtFactoryNumber.DataBindings.Add(new Binding("Text", this.bindingSource_2, "FactoryNumber", true));
            this.txtFactoryNumber.Location = new Point(0x7f, 0xd6);
            this.txtFactoryNumber.Margin = new Padding(2);
            this.txtFactoryNumber.Name = "txtFactoryNumber";
            this.txtFactoryNumber.Size = new Size(0xcf, 20);
            this.txtFactoryNumber.TabIndex = 0x12;
            this.label_27.AutoSize = true;
            this.label_27.Location = new Point(11, 0xa9);
            this.label_27.Margin = new Padding(2, 0, 2, 0);
            this.label_27.Name = "label28";
            this.label_27.Size = new Size(0x61, 13);
            this.label_27.TabIndex = 13;
            this.label_27.Text = "Напряжение сети";
            this.label_30.AutoSize = true;
            this.label_30.Location = new Point(11, 0xc2);
            this.label_30.Margin = new Padding(2, 0, 2, 0);
            this.label_30.Name = "label30";
            this.label_30.Size = new Size(0x98, 13);
            this.label_30.TabIndex = 0x11;
            this.label_30.Text = "Изготовитель оборудования";
            this.txtCountDefectEquipment.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtCountDefectEquipment.DataBindings.Add(new Binding("Text", this.bindingSource_2, "CountDefectEquipment", true));
            this.txtCountDefectEquipment.Location = new Point(0xcf, 0x90);
            this.txtCountDefectEquipment.Margin = new Padding(2);
            this.txtCountDefectEquipment.Name = "txtCountDefectEquipment";
            this.txtCountDefectEquipment.Size = new Size(0x7f, 20);
            this.txtCountDefectEquipment.TabIndex = 14;
            this.txtManufacturer.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtManufacturer.DataBindings.Add(new Binding("Text", this.bindingSource_2, "Manufacturer", true));
            this.txtManufacturer.Location = new Point(0xa6, 0xbf);
            this.txtManufacturer.Margin = new Padding(2);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new Size(0xa8, 20);
            this.txtManufacturer.TabIndex = 0x10;
            this.label_28.AutoSize = true;
            this.label_28.Location = new Point(11, 0x93);
            this.label_28.Margin = new Padding(2, 0, 2, 0);
            this.label_28.Name = "label29";
            this.label_28.Size = new Size(0xb8, 13);
            this.label_28.TabIndex = 15;
            this.label_28.Text = "Кол-во отказавшего оборудования";
            this.label_32.AutoSize = true;
            this.label_32.Location = new Point(15, 30);
            this.label_32.Margin = new Padding(2, 0, 2, 0);
            this.label_32.Name = "label38";
            this.label_32.Size = new Size(0x5b, 13);
            this.label_32.TabIndex = 0x21;
            this.label_32.Text = "Условия работы";
            this.cmbClauseWork.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbClauseWork.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbClauseWork.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbClauseWork.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_2, "ClauseWork", true));
            this.cmbClauseWork.FormattingEnabled = true;
            this.cmbClauseWork.Location = new Point(0xba, 0x1b);
            this.cmbClauseWork.Margin = new Padding(2);
            this.cmbClauseWork.Name = "cmbClauseWork";
            this.cmbClauseWork.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbClauseWork.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbClauseWork.Size = new Size(0xe2, 0x15);
            this.cmbClauseWork.TabIndex = 0x20;
            this.label_44.AutoSize = true;
            this.label_44.Location = new Point(14, 0x93);
            this.label_44.Margin = new Padding(2, 0, 2, 0);
            this.label_44.Name = "label45";
            this.label_44.Size = new Size(0x77, 13);
            this.label_44.TabIndex = 0x17;
            this.label_44.Text = "Дата восстановления";
            this.dtpTimeRecovery.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dtpTimeRecovery.CustomFormat = ("HH:mm");
            this.dtpTimeRecovery.DataBindings.Add(new Binding("Value", this.bindingSource_2, "timeRecovery", true));
            this.dtpTimeRecovery.Location = new Point(0xee, 0x8f);
            this.dtpTimeRecovery.Margin = new Padding(2);
            this.dtpTimeRecovery.Name = "dtpTimeRecovery";
            this.dtpTimeRecovery.Size = new Size(0xae, 20);
            this.dtpTimeRecovery.TabIndex = 0x16;
            this.dtpTimeRecovery.Value = (new DateTime(0x7e0, 4, 12, 13, 0x2f, 0x29, 0x90));
            this.dtpTimeRecovery.ValueChanged += new EventHandler(this.dtpTimeRecovery_ValueChanged);
            this.label_42.AutoSize = true;
            this.label_42.Location = new Point(14, 0x7c);
            this.label_42.Margin = new Padding(2, 0, 2, 0);
            this.label_42.Name = "label44";
            this.label_42.Size = new Size(220, 13);
            this.label_42.TabIndex = 0x15;
            this.label_42.Text = "Последние эксплуатационные испытания";
            this.label_43.AutoSize = true;
            this.label_43.Location = new Point(14, 100);
            this.label_43.Margin = new Padding(2, 0, 2, 0);
            this.label_43.Name = "label43";
            this.label_43.Size = new Size(0xb6, 13);
            this.label_43.TabIndex = 20;
            this.label_43.Text = "Срок службы поврежденного узла";
            this.txtLengthWorkEquipment.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtLengthWorkEquipment.DataBindings.Add(new Binding("Text", this.bindingSource_2, "lenghtWorkEquipment", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtLengthWorkEquipment.Location = new Point(0xc9, 0x62);
            this.txtLengthWorkEquipment.Margin = new Padding(2);
            this.txtLengthWorkEquipment.Name = "txtLengthWorkEquipment";
            this.txtLengthWorkEquipment.Size = new Size(0xd3, 20);
            this.txtLengthWorkEquipment.TabIndex = 0x13;
            this.label_40.AutoSize = true;
            this.label_40.Location = new Point(15, 0x4d);
            this.label_40.Margin = new Padding(2, 0, 2, 0);
            this.label_40.Name = "label42";
            this.label_40.Size = new Size(0x75, 13);
            this.label_40.TabIndex = 0x12;
            this.label_40.Text = "Начало эксплуатации";
            this.txtYearBegEquipment.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtYearBegEquipment.DataBindings.Add(new Binding("Text", this.bindingSource_2, "yearBegEquipment", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtYearBegEquipment.Location = new Point(0xba, 0x4b);
            this.txtYearBegEquipment.Margin = new Padding(2);
            this.txtYearBegEquipment.Name = "txtYearBegEquipment";
            this.txtYearBegEquipment.Size = new Size(0xe2, 20);
            this.txtYearBegEquipment.TabIndex = 0x11;
            this.txtYearBegEquipment.TextChanged += new EventHandler(this.txtYearBegEquipment_TextChanged);
            this.label_41.AutoSize = true;
            this.label_41.Location = new Point(15, 0x36);
            this.label_41.Margin = new Padding(2, 0, 2, 0);
            this.label_41.Name = "label41";
            this.label_41.Size = new Size(0xa6, 13);
            this.label_41.TabIndex = 0x10;
            this.label_41.Text = "Сопутсвующие обстоятельства";
            this.txtAssociatedFact.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtAssociatedFact.DataBindings.Add(new Binding("Text", this.bindingSource_2, "AssociatedFact", true));
            this.txtAssociatedFact.Location = new Point(0xba, 0x34);
            this.txtAssociatedFact.Margin = new Padding(2);
            this.txtAssociatedFact.Name = "txtAssociatedFact";
            this.txtAssociatedFact.Size = new Size(0xe2, 20);
            this.txtAssociatedFact.TabIndex = 15;
            this.label_38.AutoSize = true;
            this.label_38.Location = new Point(15, 0x121);
            this.label_38.Margin = new Padding(2, 0, 2, 0);
            this.label_38.Name = "label40";
            this.label_38.Size = new Size(0x79, 13);
            this.label_38.TabIndex = 8;
            this.label_38.Text = "Причина повреждения";
            this.label_38.Visible = false;
            this.cmbReasonDamage.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbReasonDamage.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbReasonDamage.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbReasonDamage.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_2, "idReasonDamage", true));
            this.cmbReasonDamage.FormattingEnabled = true;
            this.cmbReasonDamage.Location = new Point(0x8d, 0x11f);
            this.cmbReasonDamage.Margin = new Padding(2);
            this.cmbReasonDamage.Name = "cmbReasonDamage";
            this.cmbReasonDamage.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbReasonDamage.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbReasonDamage.Size = new Size(0xef, 0x15);
            this.cmbReasonDamage.TabIndex = 7;
            this.cmbReasonDamage.Visible = (false);
            this.label_39.AutoSize = true;
            this.label_39.Location = new Point(15, 0x109);
            this.label_39.Margin = new Padding(2, 0, 2, 0);
            this.label_39.Name = "label39";
            this.label_39.Size = new Size(0x7e, 13);
            this.label_39.TabIndex = 6;
            this.label_39.Text = "Характер повреждения";
            this.label_39.Visible = false;
            this.cmbCharacterDamage.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbCharacterDamage.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbCharacterDamage.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbCharacterDamage.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_2, "idCharacterDamage", true));
            this.cmbCharacterDamage.FormattingEnabled = true;
            this.cmbCharacterDamage.Location = new Point(0x8d, 0x107);
            this.cmbCharacterDamage.Margin = new Padding(2);
            this.cmbCharacterDamage.Name = "cmbCharacterDamage";
            this.cmbCharacterDamage.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbCharacterDamage.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbCharacterDamage.Size = new Size(0xef, 0x15);
            this.cmbCharacterDamage.TabIndex = 4;
            this.cmbCharacterDamage.Visible = (false);
            this.dtpLastDateTest.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dtpLastDateTest.CustomFormat = ("yyyy г.");
            this.dtpLastDateTest.DataBindings.Add(new Binding("Value", this.bindingSource_2, "LastDateTest", true));
            this.dtpLastDateTest.Format = (DateTimePickerFormat.Custom);
            this.dtpLastDateTest.Location = new Point(0xee, 120);
            this.dtpLastDateTest.Margin = new Padding(2);
            this.dtpLastDateTest.MinDate = new DateTime(0x779, 1, 1, 0, 0, 0, 0);
            this.dtpLastDateTest.Name = "dtpLastDateTest";
            this.dtpLastDateTest.ShowUpDown = true;
            this.dtpLastDateTest.Size = new Size(0xae, 20);
            this.dtpLastDateTest.TabIndex = 0;
            this.dtpLastDateTest.Value = (new DateTime(0x7e0, 4, 12, 13, 0x2f, 0x29, 0x90));
            this.dgvEquipment.AllowUserToAddRows = false;
            this.dgvEquipment.AllowUserToDeleteRows = false;
            this.dgvEquipment.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dgvEquipment.AutoGenerateColumns = false;
            this.dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray7 = new DataGridViewColumn[] { this.typeEquipmentDgvColumn, this.idDamCharacterDgvColumn, this.idSchmObjDgvColumn, this.schmObjDgvColumn, this.idDamageDataGridViewTextBoxColumn, this.col2DataGridViewTextBoxColumn, this.col3DataGridViewTextBoxColumn, this.schmObjNameDgvColumn };
            this.dgvEquipment.Columns.AddRange(columnArray7);
            this.dgvEquipment.DataSource = this.bindingSource_2;
            this.dgvEquipment.Location = new Point(3, 0x27);
            this.dgvEquipment.Margin = new Padding(2);
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.RowTemplate.Height = 0x18;
            this.dgvEquipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipment.Size = new Size(0x305, 0x73);
            this.dgvEquipment.TabIndex = 2;
            this.dgvEquipment.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridView_0_RowsAdded);
            this.typeEquipmentDgvColumn.DataPropertyName = "col1";
            this.typeEquipmentDgvColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.typeEquipmentDgvColumn.HeaderText = "Тип";
            this.typeEquipmentDgvColumn.Name = "typeEquipmentDgvColumn";
            this.typeEquipmentDgvColumn.ReadOnly = true;
            this.typeEquipmentDgvColumn.Resizable = DataGridViewTriState.True;
            this.typeEquipmentDgvColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            this.idDamCharacterDgvColumn.DataPropertyName = "id";
            this.idDamCharacterDgvColumn.HeaderText = "id";
            this.idDamCharacterDgvColumn.Name = "idDamCharacterDgvColumn";
            this.idDamCharacterDgvColumn.ReadOnly = true;
            this.idDamCharacterDgvColumn.Visible = false;
            this.idSchmObjDgvColumn.DataPropertyName = "idSchmObj";
            this.idSchmObjDgvColumn.HeaderText = "idSchmObj";
            this.idSchmObjDgvColumn.Name = "idSchmObjDgvColumn";
            this.idSchmObjDgvColumn.ReadOnly = true;
            this.idSchmObjDgvColumn.Visible = false;
            this.schmObjDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.schmObjDgvColumn.HeaderText = "Оборудование";
            this.schmObjDgvColumn.Name = "schmObjDgvColumn";
            this.schmObjDgvColumn.ReadOnly = true;
            this.idDamageDataGridViewTextBoxColumn.DataPropertyName = "idDamage";
            this.idDamageDataGridViewTextBoxColumn.HeaderText = "idDamage";
            this.idDamageDataGridViewTextBoxColumn.Name = "idDamageDataGridViewTextBoxColumn";
            this.idDamageDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDamageDataGridViewTextBoxColumn.Visible = false;
            this.col2DataGridViewTextBoxColumn.DataPropertyName = "col2";
            this.col2DataGridViewTextBoxColumn.HeaderText = "col2";
            this.col2DataGridViewTextBoxColumn.Name = "col2DataGridViewTextBoxColumn";
            this.col2DataGridViewTextBoxColumn.ReadOnly = true;
            this.col2DataGridViewTextBoxColumn.Visible = false;
            this.col3DataGridViewTextBoxColumn.DataPropertyName = "col3";
            this.col3DataGridViewTextBoxColumn.HeaderText = "col3";
            this.col3DataGridViewTextBoxColumn.Name = "col3DataGridViewTextBoxColumn";
            this.col3DataGridViewTextBoxColumn.ReadOnly = true;
            this.col3DataGridViewTextBoxColumn.Visible = false;
            this.schmObjNameDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.schmObjNameDgvColumn.DataPropertyName = "SchmObjName";
            this.schmObjNameDgvColumn.HeaderText = "Примечание";
            this.schmObjNameDgvColumn.Name = "schmObjNameDgvColumn";
            this.toolStripEquipment.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolBtnAddEquipment, this.toolBtnDelEquipment };
            this.toolStripEquipment.Items.AddRange(toolStripItems);
            this.toolStripEquipment.Location = new Point(3, 0x11);
            this.toolStripEquipment.Name = "toolStripEquipment";
            this.toolStripEquipment.Size = new Size(770, 0x19);
            this.toolStripEquipment.TabIndex = 1;
            this.toolStripEquipment.Text = "toolStrip1";
            this.toolBtnAddEquipment.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnAddEquipment.Image = (Image) resources.GetObject("toolBtnAddEquipment.Image");
            this.toolBtnAddEquipment.Image = global::DailyReport.Properties.Resources.ElementAdd;
            this.toolBtnAddEquipment.ImageTransparentColor = Color.Magenta;
            this.toolBtnAddEquipment.Name = "toolBtnAddEquipment";
            this.toolBtnAddEquipment.Size = new Size(0x17, 0x16);
            this.toolBtnAddEquipment.Text = "Добавить отказавшее оборудование";
            this.toolBtnAddEquipment.Click += new EventHandler(this.toolBtnAddEquipment_Click);
            this.toolBtnDelEquipment.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnDelEquipment.Image = (Image) resources.GetObject("toolBtnDelEquipment.Image");
            this.toolBtnDelEquipment.Image = global::DailyReport.Properties.Resources.ElementDel;
            this.toolBtnDelEquipment.ImageTransparentColor = Color.Magenta;
            this.toolBtnDelEquipment.Name = "toolBtnDelEquipment";
            this.toolBtnDelEquipment.Size = new Size(0x17, 0x16);
            this.toolBtnDelEquipment.Text = "Удалить отказавшее оборудование";
            this.toolBtnDelEquipment.Click += new EventHandler(this.toolBtnDelEquipment_Click);
            this.label_22.Dock = DockStyle.Top;
            this.label_22.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.label_22.Location = new Point(3, 3);
            this.label_22.Margin = new Padding(2, 0, 2, 0);
            this.label_22.Name = "label23";
            this.label_22.Size = new Size(770, 14);
            this.label_22.TabIndex = 0;
            this.label_22.Text = "Сведения о поврежденном или отказавшем электротехническом оборудовании элеткрических сетей";
            this.label_22.TextAlign = ContentAlignment.TopCenter;
            this.tabPageComission.Controls.Add(this.txtPostMemeber5);
            this.tabPageComission.Controls.Add(this.label_55);
            this.tabPageComission.Controls.Add(this.cmbMemberComission5);
            this.tabPageComission.Controls.Add(this.txtPostMemeber4);
            this.tabPageComission.Controls.Add(this.label_56);
            this.tabPageComission.Controls.Add(this.cmbMemberComission4);
            this.tabPageComission.Controls.Add(this.txtTotalComission);
            this.tabPageComission.Controls.Add(this.label_48);
            this.tabPageComission.Controls.Add(this.txtPostMemeber3);
            this.tabPageComission.Controls.Add(this.label_49);
            this.tabPageComission.Controls.Add(this.cmbMemberComission3);
            this.tabPageComission.Controls.Add(this.txtPostMemeber2);
            this.tabPageComission.Controls.Add(this.label_50);
            this.tabPageComission.Controls.Add(this.cmbMemberComission2);
            this.tabPageComission.Controls.Add(this.txtPostMemeber1);
            this.tabPageComission.Controls.Add(this.label_51);
            this.tabPageComission.Controls.Add(this.cmbMemberComission1);
            this.tabPageComission.Controls.Add(this.label_52);
            this.tabPageComission.Controls.Add(this.txtPostChairman);
            this.tabPageComission.Controls.Add(this.label_46);
            this.tabPageComission.Controls.Add(this.cmbChairman);
            this.tabPageComission.Controls.Add(this.label_47);
            this.tabPageComission.Controls.Add(this.txtOrder);
            this.tabPageComission.Controls.Add(this.label_45);
            this.tabPageComission.Location = new Point(4, 0x16);
            this.tabPageComission.Margin = new Padding(2);
            this.tabPageComission.Name = "tabPageComission";
            this.tabPageComission.Size = new Size(0x308, 0x21d);
            this.tabPageComission.TabIndex = 2;
            this.tabPageComission.Text = "Комиссия";
            this.tabPageComission.UseVisualStyleBackColor = true;
            this.txtPostMemeber5.DataBindings.Add(new Binding("Text", this.ds, "dtComission.PostMember5", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtPostMemeber5.Location = new Point(0x128, 0xc7);
            this.txtPostMemeber5.Margin = new Padding(2);
            this.txtPostMemeber5.Name = "txtPostMemeber5";
            this.txtPostMemeber5.Size = new Size(0x103, 20);
            this.txtPostMemeber5.TabIndex = 0x17;
            this.label_55.AutoSize = true;
            this.label_55.Location = new Point(230, 0xc9);
            this.label_55.Margin = new Padding(2, 0, 2, 0);
            this.label_55.Name = "label55";
            this.label_55.Size = new Size(0x41, 13);
            this.label_55.TabIndex = 0x16;
            this.label_55.Text = "Должность";
            this.cmbMemberComission5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbMemberComission5.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbMemberComission5.DataBindings.Add(new Binding("SelectedValue", this.ds, "dtComission.Member5", true));
            this.cmbMemberComission5.DropDownStyle = (ComboBoxStyle.DropDownList);
            this.cmbMemberComission5.FormattingEnabled = true;
            this.cmbMemberComission5.Location = new Point(9, 0xc7);
            this.cmbMemberComission5.Margin = new Padding(2);
            this.cmbMemberComission5.Name = "cmbMemberComission5";
            this.cmbMemberComission5.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbMemberComission5.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbMemberComission5.Size = new Size(0xc9, 0x15);
            this.cmbMemberComission5.TabIndex = 0x15;
            this.cmbMemberComission5.SelectedValueChanged += new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.txtPostMemeber4.DataBindings.Add(new Binding("Text", this.ds, "dtComission.PostMember4", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtPostMemeber4.Location = new Point(0x128, 0xae);
            this.txtPostMemeber4.Margin = new Padding(2);
            this.txtPostMemeber4.Name = "txtPostMemeber4";
            this.txtPostMemeber4.Size = new Size(0x103, 20);
            this.txtPostMemeber4.TabIndex = 20;
            this.label_56.AutoSize = true;
            this.label_56.Location = new Point(230, 0xb1);
            this.label_56.Margin = new Padding(2, 0, 2, 0);
            this.label_56.Name = "label56";
            this.label_56.Size = new Size(0x41, 13);
            this.label_56.TabIndex = 0x13;
            this.label_56.Text = "Должность";
            this.cmbMemberComission4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbMemberComission4.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbMemberComission4.DataBindings.Add(new Binding("SelectedValue", this.ds, "dtComission.Member4", true));
            this.cmbMemberComission4.DropDownStyle = (ComboBoxStyle.DropDownList);
            this.cmbMemberComission4.FormattingEnabled = true;
            this.cmbMemberComission4.Location = new Point(9, 0xae);
            this.cmbMemberComission4.Margin = new Padding(2);
            this.cmbMemberComission4.Name = "cmbMemberComission4";
            this.cmbMemberComission4.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbMemberComission4.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbMemberComission4.Size = new Size(0xc9, 0x15);
            this.cmbMemberComission4.TabIndex = 0x12;
            this.cmbMemberComission4.SelectedValueChanged += new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.txtTotalComission.AcceptsTab = true;
            this.txtTotalComission.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.txtTotalComission.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageActDetection.TotalComission", true));
            this.txtTotalComission.Location = new Point(9, 0xf1);
            this.txtTotalComission.Margin = new Padding(2);
            this.txtTotalComission.Name = "txtTotalComission";
            this.txtTotalComission.Size = new Size(0x2fd, 0x12d);
            this.txtTotalComission.TabIndex = 0x11;
            this.txtTotalComission.Text = "";
            this.label_48.AutoSize = true;
            this.label_48.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.label_48.Location = new Point(7, 0xe2);
            this.label_48.Margin = new Padding(2, 0, 2, 0);
            this.label_48.Name = "label53";
            this.label_48.Size = new Size(0x74, 13);
            this.label_48.TabIndex = 0x10;
            this.label_48.Text = "Выводы комиссии";
            this.txtPostMemeber3.DataBindings.Add(new Binding("Text", this.ds, "dtComission.PostMember3", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtPostMemeber3.Location = new Point(0x128, 0x95);
            this.txtPostMemeber3.Margin = new Padding(2);
            this.txtPostMemeber3.Name = "txtPostMemeber3";
            this.txtPostMemeber3.Size = new Size(0x103, 20);
            this.txtPostMemeber3.TabIndex = 15;
            this.label_49.AutoSize = true;
            this.label_49.Location = new Point(230, 0x97);
            this.label_49.Margin = new Padding(2, 0, 2, 0);
            this.label_49.Name = "label52";
            this.label_49.Size = new Size(0x41, 13);
            this.label_49.TabIndex = 14;
            this.label_49.Text = "Должность";
            this.cmbMemberComission3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbMemberComission3.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbMemberComission3.DataBindings.Add(new Binding("SelectedValue", this.ds, "dtComission.Member3", true));
            this.cmbMemberComission3.DropDownStyle = (ComboBoxStyle.DropDownList);
            this.cmbMemberComission3.FormattingEnabled = true;
            this.cmbMemberComission3.Location = new Point(9, 0x95);
            this.cmbMemberComission3.Margin = new Padding(2);
            this.cmbMemberComission3.Name = "cmbMemberComission3";
            this.cmbMemberComission3.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbMemberComission3.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbMemberComission3.Size = new Size(0xc9, 0x15);
            this.cmbMemberComission3.TabIndex = 13;
            this.cmbMemberComission3.SelectedValueChanged += new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.txtPostMemeber2.DataBindings.Add(new Binding("Text", this.ds, "dtComission.PostMember2", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtPostMemeber2.Location = new Point(0x128, 0x7c);
            this.txtPostMemeber2.Margin = new Padding(2);
            this.txtPostMemeber2.Name = "txtPostMemeber2";
            this.txtPostMemeber2.Size = new Size(0x103, 20);
            this.txtPostMemeber2.TabIndex = 12;
            this.label_50.AutoSize = true;
            this.label_50.Location = new Point(230, 0x7f);
            this.label_50.Margin = new Padding(2, 0, 2, 0);
            this.label_50.Name = "label51";
            this.label_50.Size = new Size(0x41, 13);
            this.label_50.TabIndex = 11;
            this.label_50.Text = "Должность";
            this.cmbMemberComission2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbMemberComission2.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbMemberComission2.DataBindings.Add(new Binding("SelectedValue", this.ds, "dtComission.Member2", true));
            this.cmbMemberComission2.DropDownStyle = (ComboBoxStyle.DropDownList);
            this.cmbMemberComission2.FormattingEnabled = true;
            this.cmbMemberComission2.Location = new Point(9, 0x7c);
            this.cmbMemberComission2.Margin = new Padding(2);
            this.cmbMemberComission2.Name = "cmbMemberComission2";
            this.cmbMemberComission2.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbMemberComission2.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbMemberComission2.Size = new Size(0xc9, 0x15);
            this.cmbMemberComission2.TabIndex = 10;
            this.cmbMemberComission2.SelectedValueChanged += new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.txtPostMemeber1.DataBindings.Add(new Binding("Text", this.ds, "dtComission.PostMember1", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtPostMemeber1.Location = new Point(0x128, 100);
            this.txtPostMemeber1.Margin = new Padding(2);
            this.txtPostMemeber1.Name = "txtPostMemeber1";
            this.txtPostMemeber1.Size = new Size(0x103, 20);
            this.txtPostMemeber1.TabIndex = 9;
            this.label_51.AutoSize = true;
            this.label_51.Location = new Point(230, 0x66);
            this.label_51.Margin = new Padding(2, 0, 2, 0);
            this.label_51.Name = "label50";
            this.label_51.Size = new Size(0x41, 13);
            this.label_51.TabIndex = 8;
            this.label_51.Text = "Должность";
            this.cmbMemberComission1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbMemberComission1.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbMemberComission1.DataBindings.Add(new Binding("SelectedValue", this.ds, "dtComission.Member1", true));
            this.cmbMemberComission1.DropDownStyle = (ComboBoxStyle.DropDownList);
            this.cmbMemberComission1.FormattingEnabled = true;
            this.cmbMemberComission1.Location = new Point(9, 100);
            this.cmbMemberComission1.Margin = new Padding(2);
            this.cmbMemberComission1.Name = "cmbMemberComission1";
            this.cmbMemberComission1.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbMemberComission1.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbMemberComission1.Size = new Size(0xc9, 0x15);
            this.cmbMemberComission1.TabIndex = 7;
            this.cmbMemberComission1.SelectedValueChanged += new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.label_52.AutoSize = true;
            this.label_52.Location = new Point(7, 0x54);
            this.label_52.Margin = new Padding(2, 0, 2, 0);
            this.label_52.Name = "label49";
            this.label_52.Size = new Size(0x5e, 13);
            this.label_52.TabIndex = 6;
            this.label_52.Text = "Члены комиссии";
            this.txtPostChairman.DataBindings.Add(new Binding("Text", this.ds, "dtComission.PostChairman", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtPostChairman.Location = new Point(0x128, 0x34);
            this.txtPostChairman.Margin = new Padding(2);
            this.txtPostChairman.Name = "txtPostChairman";
            this.txtPostChairman.Size = new Size(0x103, 20);
            this.txtPostChairman.TabIndex = 5;
            this.label_46.AutoSize = true;
            this.label_46.Location = new Point(230, 0x36);
            this.label_46.Margin = new Padding(2, 0, 2, 0);
            this.label_46.Name = "label48";
            this.label_46.Size = new Size(0x41, 13);
            this.label_46.TabIndex = 4;
            this.label_46.Text = "Должность";
            this.cmbChairman.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbChairman.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbChairman.DataBindings.Add(new Binding("SelectedValue", this.ds, "dtComission.Chairman", true));
            this.cmbChairman.DropDownStyle = (ComboBoxStyle.DropDownList);
            this.cmbChairman.FormattingEnabled = true;
            this.cmbChairman.Location = new Point(9, 0x34);
            this.cmbChairman.Margin = new Padding(2);
            this.cmbChairman.Name = "cmbChairman";
            this.cmbChairman.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbChairman.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbChairman.Size = new Size(0xc9, 0x15);
            this.cmbChairman.TabIndex = 3;
            this.cmbChairman.SelectedValueChanged += new EventHandler(this.cmbChairman_SelectedValueChanged);
            this.label_47.AutoSize = true;
            this.label_47.Location = new Point(7, 0x24);
            this.label_47.Margin = new Padding(2, 0, 2, 0);
            this.label_47.Name = "label47";
            this.label_47.Size = new Size(80, 13);
            this.label_47.TabIndex = 2;
            this.label_47.Text = "Председатель";
            this.txtOrder.DataBindings.Add(new Binding("Text", this.ds, "dtComission.Order", true));
            this.txtOrder.Location = new Point(430, 11);
            this.txtOrder.Margin = new Padding(2);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new Size(0xf2, 20);
            this.txtOrder.TabIndex = 1;
            this.label_45.AutoSize = true;
            this.label_45.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.label_45.Location = new Point(0x3a, 13);
            this.label_45.Margin = new Padding(2, 0, 2, 0);
            this.label_45.Name = "label46";
            this.label_45.Size = new Size(0x171, 13);
            this.label_45.TabIndex = 0;
            this.label_45.Text = "Комиссия, расследовавшая аварии, назначена приказом от";
            this.tabPagePrint.Location = new Point(4, 0x16);
            this.tabPagePrint.Margin = new Padding(2);
            this.tabPagePrint.Name = "tabPagePrint";
            this.tabPagePrint.Padding = new Padding(2);
            this.tabPagePrint.Size = new Size(0x308, 0x21d);
            this.tabPagePrint.TabIndex = 3;
            this.tabPagePrint.Text = "Печать";
            this.tabPagePrint.UseVisualStyleBackColor = true;
            this.buttonSave.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.buttonSave.DialogResult = DialogResult.OK;
            this.buttonSave.Location = new Point(12, 0x23d);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(0x4b, 0x17);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.buttonCancel.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.Location = new Point(700, 570);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(0x4b, 0x17);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
            this.chkApply.Anchor = AnchorStyles.Bottom;
            this.chkApply.AutoSize = true;
            this.chkApply.DataBindings.Add(new Binding("Checked", this.dataSetDamage, "tJ_Damage.isApply", true));
            this.chkApply.Location = new Point(0x7f, 580);
            this.chkApply.Margin = new Padding(2);
            this.chkApply.Name = "chkApply";
            this.chkApply.Size = new Size(0x52, 0x11);
            this.chkApply.TabIndex = 3;
            this.chkApply.Text = "Исполнено";
            this.chkApply.UseVisualStyleBackColor = true;
            this.chkApply.CheckedChanged += new EventHandler(this.chkApply_CheckedChanged);
            this.label_53.Anchor = AnchorStyles.Bottom;
            this.label_53.AutoSize = true;
            this.label_53.Location = new Point(0x1b6, 0x245);
            this.label_53.Margin = new Padding(2, 0, 2, 0);
            this.label_53.Name = "label54";
            this.label_53.Size = new Size(0x4d, 13);
            this.label_53.TabIndex = 5;
            this.label_53.Text = "Дата и время";
            this.bindingSource_3.DataMember = "tJ_Damage";
            this.bindingSource_3.DataSource = this.dataSetDamage;
            this.dataGridViewComboBoxColumn_5.DataPropertyName = "col1";
            this.dataGridViewComboBoxColumn_5.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn_5.HeaderText = "Тип";
            this.dataGridViewComboBoxColumn_5.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn_5.ReadOnly = true;
            this.dataGridViewComboBoxColumn_5.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_5.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_1.HeaderText = "id";
            this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "idSchmObj";
            this.dataGridViewTextBoxColumn_2.HeaderText = "idSchmObj";
            this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_3.HeaderText = "Оборудование";
            this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "idDamage";
            this.dataGridViewTextBoxColumn_4.HeaderText = "idDamage";
            this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "col2";
            this.dataGridViewTextBoxColumn_5.HeaderText = "col2";
            this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "col3";
            this.dataGridViewTextBoxColumn_6.HeaderText = "col3";
            this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewTextBoxColumn_6.Visible = false;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "idLineSection";
            this.dataGridViewTextBoxColumn_7.HeaderText = "idLineSection";
            this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewTextBoxColumn_7.Visible = false;
            this.dtpApply.Anchor = AnchorStyles.Bottom;
            this.dtpApply.CustomFormat = ("dd.MM.yyyy HH:mm");
            this.dtpApply.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateApply", true, DataSourceUpdateMode.OnPropertyChanged));
            this.dtpApply.Format = (DateTimePickerFormat.Custom);
            this.dtpApply.Location = new Point(520, 0x240);
            this.dtpApply.Margin = new Padding(2);
            this.dtpApply.Name = "dtpApply";
            this.dtpApply.Size = new Size(0x97, 20);
            this.dtpApply.TabIndex = 6;
            this.dtpApply.Value = (new DateTime(0x7e0, 4, 14, 9, 0x15, 0x2d, 0x19e));
            this.cmbWorkerApply.Anchor = AnchorStyles.Bottom;
            this.cmbWorkerApply.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbWorkerApply.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbWorkerApply.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idWorkerApply", true));
            this.cmbWorkerApply.FormattingEnabled = true;
            this.cmbWorkerApply.Location = new Point(0xd5, 0x240);
            this.cmbWorkerApply.Margin = new Padding(2);
            this.cmbWorkerApply.Name = "cmbWorkerApply";
            this.cmbWorkerApply.ReadOnlyBackColor = (SystemColors.Control);
            this.cmbWorkerApply.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbWorkerApply.Size = new Size(0xde, 0x15);
            this.cmbWorkerApply.TabIndex = 4;
            this.cmbWorkerApply.SelectedIndexChanged += new EventHandler(this.cmbWorkerApply_SelectedIndexChanged);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x310, 0x260);
            base.Controls.Add(this.dtpApply);
            base.Controls.Add(this.label_53);
            base.Controls.Add(this.cmbWorkerApply);
            base.Controls.Add(this.chkApply);
            base.Controls.Add(this.buttonCancel);
            base.Controls.Add(this.buttonSave);
            base.Controls.Add(this.tabControl1);
            this.MinimumSize = new Size(800, 0x255);
            base.Name = "FormActDetectionAddEdit";
            base.PermissionsSql = (false);
            this.Text = "Акт расследования (N)";
            base.FormClosing += new FormClosingEventHandler(this.FormActDetectionAddEdit_FormClosing);
            base.Load += new EventHandler(this.FormActDetectionAddEdit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.dataSetDamage.EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxNoCrashEvents.ResumeLayout(false);
            ((ISupportInitialize)this.dgvNoCrashMeasure).EndInit();
            ((ISupportInitialize)this.bindingSource_0).EndInit();
            this.ds.EndInit();
            this.dtNoCrashMeasure.EndInit();
            this.dtDefection.EndInit();
            this.dtParametersEquipment.EndInit();
            this.dtComission.EndInit();
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.tabPageDescription.ResumeLayout(false);
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxDescription.PerformLayout();
            ((ISupportInitialize)this.dgvDefection).EndInit();
            ((ISupportInitialize)this.bindingSource_1).EndInit();
            this.tabPageSchm.ResumeLayout(false);
            this.tabPageSchm.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((ISupportInitialize)this.bindingSource_2).EndInit();
            ((ISupportInitialize)this.dgvEquipment).EndInit();
            this.toolStripEquipment.ResumeLayout(false);
            this.toolStripEquipment.PerformLayout();
            this.tabPageComission.ResumeLayout(false);
            this.tabPageComission.PerformLayout();
            ((ISupportInitialize)this.bindingSource_3).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        /// <summary>
        ////обновление даты ликвидации аварийного события
        /// </summary>
        private void btnRefreshDataEndCrash_Click(object sender, EventArgs e)
        {
            if (dataSetDamage.tJ_Damage.Rows.Count > 0)
            {
                if (dataSetDamage.tJ_Damage.Rows[0]["idParent"] == DBNull.Value)

                {
                    // Не выбран документ аварийного события
                    MessageBox.Show("Не выбран документ аварийного события", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }
                else
                {
                    if (this.dataSetDamage.tJ_DamageActDetection.Rows.Count > 0)
                    {
                        DataTable dataTable = new DataTable("tj_DamageOn");
                        dataTable.Columns.Add("DateOn", typeof(DateTime));
                        SelectSqlData(dataTable, true, "where idDamage = " + this.dataSetDamage.tJ_Damage.Rows[0]["idParent"].ToString() + " order by DateOn desc", null, false, 0);
                        if (dataTable.Rows.Count <= 0)
                        {
                            dataSetDamage.tJ_DamageActDetection.Rows[0]["dateEndCrashLocal"] = DBNull.Value;
                            return;
                        }
                        this.dataSetDamage.tJ_DamageActDetection.Rows[0]["dateEndCrashLocal"] = dataTable.Rows[0]["dateOn"];
                    }
                }
            }
        }

        private void method_7()
        {
            DataRow row = this.dtDefection.NewRow();
            row["idDefection"] = 1976;// 0x7b8;
            this.dtDefection.Rows.Add(row);
        }
        /// <summary>
        /// Вернуть родительский документ аварийного события
        /// </summary>
        private void GetParentDocument(int idParentDocument)
        {
            DataTable table = new DataTable("vJ_Damage");
            table.Columns.Add("numDoc", typeof(int));
            table.Columns.Add("dateDoc", typeof(DateTime));
            table.Columns.Add("typeDocName", typeof(string));
            table.Columns.Add("nameDoc", typeof(string), "typedocname + isnull(' №' + convert(numDoc, System.String), ' №б/н') + isnull(' от ' + convert(dateDoc, System.String), '')");

            base.SelectSqlData(table, true, "where id = " + idParentDocument.ToString(), null, false, 0);
            if (table.Rows.Count > 0)
            {
                this.txtParentDamage.Text = table.Rows[0]["nameDoc"].ToString();
            }
            if (this.dataSetDamage.tJ_DamageActDetection.Rows.Count > 0)
            {
                DataTable table2 = new DataTable("tj_DamageOn");
                table2.Columns.Add("DateOn", typeof(DateTime));
                base.SelectSqlData(table2, true, "where idDamage = " + idParentDocument.ToString() + " order by DateOn desc", null, false, 0);
                if (table2.Rows.Count > 0)
                {
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["dateEndCrashLocal"] = table2.Rows[0]["dateOn"];
                }
                else
                {
                    this.dataSetDamage.tJ_DamageActDetection.Rows[0]["dateEndCrashLocal"] = DBNull.Value;
                }
            }
        }
        /// <summary>
        /// вернуть Автора акта
        /// </summary>
        private void GetAutorAkt()
        {
            if (!this.IdDocument.HasValue)
            {
                DataTable table = new DataTable("tUser");
                table.Columns.Add("name", typeof(string));
                table.Columns.Add("idWorker", typeof(string));
                base.SelectSqlData(table, true, "where [login] = SYSTEM_USER", null, false, 0);
                if ((table.Rows.Count > 0) && (table.Rows[0]["name"] != DBNull.Value))
                {
                    this.txtOwner.Text = table.Rows[0]["name"].ToString();
                }
            }
            else if ((this.dataSetDamage.tJ_Damage.Rows.Count > 0) && (this.dataSetDamage.tJ_Damage.Rows[0]["idOwner"] != DBNull.Value))
            {
                DataTable table2 = new DataTable("tUser");
                table2.Columns.Add("name", typeof(string));
                base.SelectSqlData(table2, true, "where [idUser] = " + this.dataSetDamage.tJ_Damage.Rows[0]["idOwner"].ToString(), null, false, 0);
                if ((table2.Rows.Count > 0) && (table2.Rows[0]["name"] != DBNull.Value))
                {
                    this.txtOwner.Text = table2.Rows[0]["name"].ToString();
                }
            }
        }

        private void dtpEndCrashLocal_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if ((this.dtpEndCrashLocal.Value != null) && (this.dtpEndCrashLocal.Value != DBNull.Value))
            {
                this.dtpEndCrashMoscow.Value = (Convert.ToDateTime(this.dtpEndCrashLocal.Value).AddHours(3.0).AddHours(-TimeZoneInfo.Local.BaseUtcOffset.TotalHours));
            }
            else
            {
                this.dtpEndCrashMoscow.Value = (DBNull.Value);
            }
        }

        private void dtpTimeRecovery_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpTimeRecovery.Value != null)
            {
                this.dtpLastDateTest.MaxDate = Convert.ToDateTime(this.dtpTimeRecovery.Value);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab == this.tabPagePrint)
            {
                ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus = new ControlsLbr.ReportViewerRus.ReportViewerRus
                {
                    LocalReport = { ReportEmbeddedResource = "DailyReport.Documents.RDLC.ReportActDetection.rdlc" },
                    Dock = DockStyle.Fill
                };
                this.tabPagePrint.Controls.Clear();
                this.tabPagePrint.Controls.Add(reportViewerRus);
                ReportDataSource reportDataSource = new ReportDataSource
                {
                    Name = "dsDamage",
                    Value = this.bindingSource_3
                };
                reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
                reportDataSource = new ReportDataSource
                {
                    Name = "dsActDetection"
                };
                BindingSource source2 = new BindingSource
                {
                    DataSource = this.dataSetDamage.tJ_DamageActDetection
                };
                reportDataSource.Value = source2;
                reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
                List<ReportParameter> parameters = new List<ReportParameter>();
                if (this.cmbOrg.SelectedIndex >= 0)
                {
                    parameters.Add(new ReportParameter("Org", ((DataRowView)this.cmbOrg.SelectedItem).Row["name"].ToString()));
                }
                if (this.cmbSignCrash.SelectedIndex >= 0)
                {
                    parameters.Add(new ReportParameter("signCrashCode", ((DataRowView)this.cmbSignCrash.SelectedItem).Row["name"].ToString()));
                    parameters.Add(new ReportParameter("signCrash", ((DataRowView)this.cmbSignCrash.SelectedItem).Row["comment"].ToString()));
                }
                if (this.cmbTypeEquipment.SelectedIndex >= 0)
                {
                    parameters.Add(new ReportParameter("typeEquipmentCode", ((DataRowView)this.cmbTypeEquipment.SelectedItem).Row["name"].ToString()));
                    parameters.Add(new ReportParameter("typeEquipment", ((DataRowView)this.cmbTypeEquipment.SelectedItem).Row["comment"].ToString()));
                }
                if (this.cmbReasonCrashEquipment.SelectedIndex >= 0)
                {
                    parameters.Add(new ReportParameter("reasonCrashEqCode", ((DataRowView)this.cmbReasonCrashEquipment.SelectedItem).Row["name"].ToString()));
                    parameters.Add(new ReportParameter("reasonCrashEq", ((DataRowView)this.cmbReasonCrashEquipment.SelectedItem).Row["comment"].ToString()));
                }
                if (this.cmbReasonCrash.SelectedIndex >= 0)
                {
                    parameters.Add(new ReportParameter("reasonCrashCode", ((DataRowView)this.cmbReasonCrash.SelectedItem).Row["name"].ToString()));
                    parameters.Add(new ReportParameter("reasonCrash", ((DataRowView)this.cmbReasonCrash.SelectedItem).Row["comment"].ToString()));
                }
                parameters.Add(new ReportParameter("schmObj", this.txtSchmObj.Text));
                if (this.cmbStatusBeforeCrash.SelectedIndex >= 0)
                {
                    parameters.Add(new ReportParameter("statusBeforeCrash", ((DataRowView)this.cmbStatusBeforeCrash.SelectedItem).Row["comment"].ToString()));
                }
                if (!string.IsNullOrEmpty(this.txtStatusCurrentCrash.Text))
                {
                    parameters.Add(new ReportParameter("statusCurrentCrash", this.txtStatusCurrentCrash.Text));
                }
                else if (this.cmbStatusCurrentCrash.SelectedIndex >= 0)
                {
                    parameters.Add(new ReportParameter("statusCurrentCrash", ((DataRowView)this.cmbStatusCurrentCrash.SelectedItem).Row["comment"].ToString()));
                }
                reportDataSource = new ReportDataSource
                {
                    Name = "ds23"
                };
                BindingSource bindingSourceReport = new BindingSource
                {
                    DataSource = this.dataSetDamage.table23
                };
                this.dataSetDamage.table23.Clear();
                foreach (DataGridViewRow row in (IEnumerable)this.dgvDefection.Rows)
                {
                    DataRow row2 = this.dataSetDamage.table23.NewRow();
                    row2["Description"] = row.Cells[this.idDefectionDataGridViewTextBoxColumn.Name].FormattedValue.ToString();
                    row2["NPA"] = row.Cells[this.idNPADgvColumn.Name].FormattedValue.ToString();
                    if (row.Cells[this.punctNPADataGridViewTextBoxColumn.Name].Value != null)
                    {
                        row2["punktNPA"] = row.Cells[this.punctNPADataGridViewTextBoxColumn.Name].Value.ToString();
                    }
                    row2["Org"] = row.Cells[this.idOrgDefectionDgvColumn.Name].FormattedValue.ToString();
                    this.dataSetDamage.table23.Rows.Add(row2);
                }
                if (this.dataSetDamage.table23.Rows.Count > 0)
                {
                    this.dataSetDamage.table23.Rows.RemoveAt(this.dataSetDamage.table23.Rows.Count - 1);
                }
                reportDataSource.Value = bindingSourceReport;
                reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
                if (!string.IsNullOrEmpty(this.txtReasonBeginCrash.Text))
                {
                    parameters.Add(new ReportParameter("reasonBeginCrash", this.txtReasonBeginCrash.Text));
                }
                else if (this.cmbReasonBeginCrash.SelectedIndex >= 0)
                {
                    parameters.Add(new ReportParameter("reasonBeginCrashCode", ((DataRowView)this.cmbReasonBeginCrash.SelectedItem).Row["name"].ToString()));
                    parameters.Add(new ReportParameter("reasonBeginCrash", ((DataRowView)this.cmbReasonBeginCrash.SelectedItem).Row["comment"].ToString()));
                }
                if (this.cmbClassifierDamage.SelectedIndex >= 0)
                {
                    parameters.Add(new ReportParameter("classifierDamage", ((DataRowView)this.cmbClassifierDamage.SelectedItem).Row["name"].ToString()));
                }
                if (this.cmbFault.SelectedIndex >= 0)
                {
                    parameters.Add(new ReportParameter("fault", ((DataRowView)this.cmbFault.SelectedItem).Row["name"].ToString()));
                }
                reportDataSource = new ReportDataSource
                {
                    Name = "ds31"
                };
                BindingSource bindingSource2 = new BindingSource
                {
                    DataSource = this.dataSetDamage.table31
                };
                this.dataSetDamage.table31.Clear();
                foreach (DataGridViewRow row3 in (IEnumerable)this.dgvNoCrashMeasure.Rows)
                {
                    DataRow row4 = this.dataSetDamage.table31.NewRow();
                    row4["Measure"] = row3.Cells[this.idNoCrashMeasureColumn.Name].FormattedValue.ToString();
                    if ((row3.Cells[this.dateCompleteDataGridViewTextBoxColumn.Name].Value != null) && (row3.Cells[this.dateCompleteDataGridViewTextBoxColumn.Name].Value != DBNull.Value))
                    {
                        row4["date"] = Convert.ToDateTime(row3.Cells[this.dateCompleteDataGridViewTextBoxColumn.Name].Value).ToString("MMMM yyyy");
                    }
                    row4["Org"] = row3.Cells[this.idOrgColumn.Name].FormattedValue.ToString();
                    this.dataSetDamage.table31.Rows.Add(row4);
                }
                if (this.dataSetDamage.table31.Rows.Count > 0)
                {
                    this.dataSetDamage.table31.Rows.RemoveAt(this.dataSetDamage.table31.Rows.Count - 1);
                }
                reportDataSource.Value = bindingSource2;
                reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
                reportDataSource = new ReportDataSource
                {
                    Name = "ds4"
                };
                BindingSource bindingSource5 = new BindingSource
                {
                    DataSource = this.dataSetDamage.table4
                };
                this.dataSetDamage.table4.Clear();
                int num = 1;
                for (int i = 0; i < this.dataSetDamage.tJ_DamageCharacter.Rows.Count; i++)
                {
                    DataRow row5 = this.dataSetDamage.tJ_DamageCharacter.Rows[i];
                    DataRow row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Отказавшее оборудование: ";
                    row6["Description"] = row6["Description"].ToString() + this.dgvEquipment[this.typeEquipmentDgvColumn.Name, i].FormattedValue.ToString();
                    if (this.dgvEquipment[this.schmObjDgvColumn.Name, i].Value != null)
                    {
                        row6["Description"] = row6["Description"].ToString() + "   " + this.dgvEquipment[this.schmObjDgvColumn.Name, i].Value.ToString();
                    }
                    if (this.dgvEquipment[this.schmObjNameDgvColumn.Name, i].Value != null)
                    {
                        row6["Description"] = row6["Description"].ToString() + "   " + this.dgvEquipment[this.schmObjNameDgvColumn.Name, i].Value.ToString();
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Марка: ";
                    if ((row5["idMark"] != DBNull.Value) && (row5["col1"] != DBNull.Value))
                    {
                        DataTable table = this.CreateTableClassifier();
                        base.SelectSqlData(table, true, " where id = " + row5["col1"].ToString(), null, false, 0);
                        if (table.Rows.Count > 0)
                        {
                            switch (table.Rows[0]["ParentKey"].ToString())
                            {
                                case ";ReportDaily;NatureDamage;HV;AirLine;":
                                case ";ReportDaily;NatureDamage;HV;CableLine;":
                                    {
                                        DataTable table2 = new SqlDataCommand(this.SqlSettings).SelectSqlData("select id, CableMakeup + ' ' + cast(wires as varchar(8)) + 'x' + \r\n                                            convert(varchar(20), convert(float, CrossSection)) as name from tr_Cable \r\n                                            where id = " + row5["idMark"].ToString() + " order by CableMakeup, wires, CrossSection");
                                        if (table2.Rows.Count > 0)
                                        {
                                            row6["Description"] = row6["Description"].ToString() + table2.Rows[0]["Name"].ToString();
                                        }
                                        break;
                                    }
                                case ";ReportDaily;NatureDamage;HV;Subs;":
                                    {
                                        DataTable table3 = new SqlDataCommand(this.SqlSettings).SelectSqlData("select id, Name\r\n                                                                from tP_ValueLists\r\n                                                                where ParentKey = ';SubstationType;' and isGRoup = 0 and deleted = 0\r\n                                                                    and id = " + row5["idMark"].ToString() + " order by name");
                                        if (table3.Rows.Count > 0)
                                        {
                                            row6["Description"] = row6["Description"].ToString() + table3.Rows[0]["Name"].ToString();
                                        }
                                        break;
                                    }
                            }
                        }
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Параметры: ";
                    if (row5["idParameters"] != DBNull.Value)
                    {
                        DataRow[] rowArray = this.dtClassifier.Select("id = " + row5["idParameters"].ToString());
                        if (rowArray.Length != 0)
                        {
                            row6["Description"] = row6["Description"].ToString() + rowArray[0]["Name"].ToString();
                        }
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Конструктивное напряжение: ";
                    if (row5["idVoltage"] != DBNull.Value)
                    {
                        DataRow[] rowArray2 = this.dtClassifier.Select("id = " + row5["idVoltage"].ToString());
                        if (rowArray2.Length != 0)
                        {
                            row6["Description"] = row6["Description"].ToString() + rowArray2[0]["Name"].ToString();
                        }
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Узел, деталь: ";
                    if (row5["NodeDetail"] != DBNull.Value)
                    {
                        DataRow[] rowArray3 = this.dtClassifier.Select("id = " + row5["NodeDetail"].ToString());
                        if (rowArray3.Length != 0)
                        {
                            row6["Description"] = row6["Description"].ToString() + rowArray3[0]["Name"].ToString();
                        }
                    }
                    if (row5["NodeDetailTxt"] != DBNull.Value)
                    {
                        row6["Description"] = row6["Description"].ToString() + " " + row5["NodeDetailTxt"].ToString();
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Количество отказавшего оборудования, узлов: ";
                    if (row5["CountDefectEquipment"] != DBNull.Value)
                    {
                        row6["Description"] = row6["Description"].ToString() + row5["CountDefectEquipment"].ToString();
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Напряжение сети: ";
                    if (row5["idVoltageSeti"] != DBNull.Value)
                    {
                        DataRow[] rowArray4 = this.dtClassifier.Select("id = " + row5["idVoltageSEti"].ToString());
                        if (rowArray4.Length != 0)
                        {
                            row6["Description"] = row6["Description"].ToString() + rowArray4[0]["Name"].ToString();
                        }
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Изготовитель оборудования или повредившегося узла: ";
                    if (row5["Manufacturer"] != DBNull.Value)
                    {
                        row6["Description"] = row6["Description"].ToString() + row5["Manufacturer"].ToString();
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Заводской номер: ";
                    if (row5["FactoryNumber"] != DBNull.Value)
                    {
                        row6["Description"] = row6["Description"].ToString() + row5["FactoryNumber"].ToString();
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Год изготовления оборудования: ";
                    if (row5["YearManufacture"] != DBNull.Value)
                    {
                        row6["Description"] = row6["Description"].ToString() + row5["YearManufacture"].ToString() + "г.";
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Состояние нейтрали: ";
                    if (row5["idNeutralState"] != DBNull.Value)
                    {
                        DataRow[] rowArray5 = this.dtClassifier.Select("id = " + row5["idNeutralState"].ToString());
                        if (rowArray5.Length != 0)
                        {
                            row6["Description"] = row6["Description"].ToString() + rowArray5[0]["Name"].ToString();
                        }
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Условия отказа оборудования, % относительная нагрузка кабеля, число цепей ВЛ: ";
                    if (row5["ClauseFail"] != DBNull.Value)
                    {
                        row6["Description"] = row6["Description"].ToString() + row5["ClauseFail"].ToString();
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Продолжительность работы оборудования с перегрузкой: ";
                    if (row5["LengthOverload"] != DBNull.Value)
                    {
                        row6["Description"] = row6["Description"].ToString() + row5["LengthOverload"].ToString();
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Длина КЛ, ВЛ, м: ";
                    if (row5["LengthLine"] != DBNull.Value)
                    {
                        row6["Description"] = row6["Description"].ToString() + row5["LengthLine"].ToString();
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Материал: ";
                    if (row5["idMaterial"] != DBNull.Value)
                    {
                        DataRow[] rowArray6 = this.dtClassifier.Select("id = " + row5["idMaterial"].ToString());
                        if (rowArray6.Length != 0)
                        {
                            row6["Description"] = row6["Description"].ToString() + rowArray6[0]["Name"].ToString();
                        }
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Условия работы: ";
                    if (row5["ClauseWork"] != DBNull.Value)
                    {
                        DataRow[] rowArray7 = this.dtClassifier.Select("id = " + row5["ClauseWork"].ToString());
                        if (rowArray7.Length != 0)
                        {
                            row6["Description"] = row6["Description"].ToString() + rowArray7[0]["Name"].ToString();
                        }
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Характер повреждения: ";
                    if (this.cmbClassifierDamage.SelectedIndex >= 0)
                    {
                        row6["Description"] = row6["Description"].ToString() + ((DataRowView)this.cmbClassifierDamage.SelectedItem).Row["name"].ToString();
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Причина повреждения: ";
                    if (this.cmbReasonBeginCrash.SelectedIndex >= 0)
                    {
                        row6["Description"] = row6["Description"].ToString() + ((DataRowView)this.cmbReasonBeginCrash.SelectedItem).Row["comment"].ToString().ToLower();
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Сопутствующие обстоятельства: ";
                    if (row5["AssociatedFact"] != DBNull.Value)
                    {
                        row6["Description"] = row6["Description"].ToString() + row5["AssociatedFact"].ToString();
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Срок службы оборудования от последнего капительного ремонта:\r\n \t\t 1) Начало эксплуатации: ";
                    if (row5["yearBegEquipment"] != DBNull.Value)
                    {
                        row6["Description"] = row6["Description"].ToString() + row5["yearBegEquipment"].ToString() + "г.";
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Срок службы поврежденного узла: ";
                    if (row5["lenghtWorkEquipment"] != DBNull.Value)
                    {
                        row6["Description"] = row6["Description"].ToString() + row5["lenghtWorkEquipment"].ToString() + " " + this.method_61(Convert.ToInt32(row5["lenghtWorkEquipment"]));
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Последние эксплуатационные испытания: ";
                    if (row5["LastDateTest"] != DBNull.Value)
                    {
                        row6["Description"] = row6["Description"].ToString() + Convert.ToDateTime(row5["LastDateTest"]).ToString("yyyy") + "г.";
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                    row6 = this.dataSetDamage.table4.NewRow();
                    row6["num"] = "4." + num.ToString() + ".";
                    row6["Description"] = "Дата восстановления: ";
                    if (row5["timeRecovery"] != DBNull.Value)
                    {
                        row6["Description"] = row6["Description"].ToString() + Convert.ToDateTime(row5["timeRecovery"]).ToString("dd.MM.yyyy") + "г.";
                    }
                    this.dataSetDamage.table4.Rows.Add(row6);
                    num++;
                }
                reportDataSource.Value = bindingSource5;
                reportViewerRus.LocalReport.DataSources.Add(reportDataSource);
                parameters.Add(new ReportParameter("Order", this.txtOrder.Text));
                if (this.cmbChairman.SelectedIndex >= 0)
                {
                    string str2 = ((DataRowView)this.cmbChairman.SelectedItem).Row["fio"].ToString();
                    if (!string.IsNullOrEmpty(this.txtPostChairman.Text))
                    {
                        str2 = str2 + ", " + this.txtPostChairman.Text.ToLower();
                    }
                    parameters.Add(new ReportParameter("Chairman", str2));
                }
                if (this.cmbMemberComission1.SelectedIndex >= 0)
                {
                    string str3 = ((DataRowView)this.cmbMemberComission1.SelectedItem).Row["fio"].ToString();
                    if (!string.IsNullOrEmpty(this.txtPostMemeber1.Text))
                    {
                        str3 = str3 + ", " + this.txtPostMemeber1.Text.ToLower();
                    }
                    parameters.Add(new ReportParameter("Comission1", str3));
                }
                if (this.cmbMemberComission2.SelectedIndex >= 0)
                {
                    string str4 = ((DataRowView)this.cmbMemberComission2.SelectedItem).Row["fio"].ToString();
                    if (!string.IsNullOrEmpty(this.txtPostMemeber2.Text))
                    {
                        str4 = str4 + ", " + this.txtPostMemeber2.Text.ToLower();
                    }
                    parameters.Add(new ReportParameter("Comission2", str4));
                }
                if (this.cmbMemberComission3.SelectedIndex >= 0)
                {
                    string str5 = ((DataRowView)this.cmbMemberComission3.SelectedItem).Row["fio"].ToString();
                    if (!string.IsNullOrEmpty(this.txtPostMemeber3.Text))
                    {
                        str5 = str5 + ", " + this.txtPostMemeber3.Text.ToLower();
                    }
                    parameters.Add(new ReportParameter("Comission3", str5));
                }
                if (this.cmbMemberComission4.SelectedIndex >= 0)
                {
                    string str6 = ((DataRowView)this.cmbMemberComission4.SelectedItem).Row["fio"].ToString();
                    if (!string.IsNullOrEmpty(this.txtPostMemeber4.Text))
                    {
                        str6 = str6 + ", " + this.txtPostMemeber4.Text.ToLower();
                    }
                    parameters.Add(new ReportParameter("Comission4", str6));
                }
                if (this.cmbMemberComission5.SelectedIndex >= 0)
                {
                    string str7 = ((DataRowView)this.cmbMemberComission5.SelectedItem).Row["fio"].ToString();
                    if (!string.IsNullOrEmpty(this.txtPostMemeber5.Text))
                    {
                        str7 = str7 + ", " + this.txtPostMemeber5.Text.ToLower();
                    }
                    parameters.Add(new ReportParameter("Comission5", str7));
                }
                if (this.cmbCompiler.SelectedIndex >= 0)
                {
                    string str8 = ((DataRowView)this.cmbCompiler.SelectedItem).Row["fio"].ToString();
                    if (this.cmbCompiler.SelectedIndex >= 0)
                    {
                        DataTable table4 = new SqlDataCommand(this.SqlSettings).SelectSqlData("select t.description from tR_JobTitle t \r\n\t                                                    inner join tR_Worker w on t.id = w.jobtitle\r\n                                                        where w.id = " + this.cmbCompiler.SelectedValue.ToString());
                        if ((table4.Rows.Count > 0) && (table4.Rows[0]["Description"] != DBNull.Value))
                        {
                            str8 = str8 + ", " + table4.Rows[0]["Description"].ToString().ToLower();
                        }
                    }
                    parameters.Add(new ReportParameter("Compiler", str8));
                }
                reportViewerRus.LocalReport.SetParameters(parameters);
                reportViewerRus.RefreshReport();
            }
        }

        private void txtYearBegEquipment_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.method_62();
        }

        private void txtNumCrash_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (!string.IsNullOrEmpty(this.txtNumCrash.Text))
            {
                this.labelNumCrash.ForeColor = Color.Black;
            }
        }

        private void txtYearManufature_Enter(object sender, EventArgs e)
        {
            this.txtYearManufature.TextChanged += new EventHandler(this.txtYearManufature_TextChanged);
        }

        private void txtYearManufature_Leave(object sender, EventArgs e)
        {
            this.txtYearManufature.TextChanged -= new EventHandler(this.txtYearManufature_TextChanged);
        }

        private void txtYearManufature_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.txtYearBegEquipment.Text = this.txtYearManufature.Text;
        }

        private void toolBtnAddEquipment_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (DataRow row in this.dataSetDamage.tJ_DamageCharacter)
            {
                if ((row.RowState != DataRowState.Deleted) && (row["idCharacterParent"] != DBNull.Value))
                {
                    list.Add(Convert.ToInt32(row["idCharacterParent"]));
                }
            }
            FormChooseDamageCharacter form = new FormChooseDamageCharacter(this.IdParent, list, this.IdDocument);
            form.SqlSettings = (this.SqlSettings);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.method_39(form.getListDamage());
            }
        }

        private void toolBtnDelEquipment_Click(object sender, EventArgs e)
        {
            if (this.dgvEquipment.CurrentRow != null)
            {
                if (this.dgvEquipment.Rows.Count == 1)
                {
                    DataTable table = new DataTable("tJ_Damage");
                    table.Columns.Add("id", typeof(int));
                    string str = "";
                    if (this.IdDocument.HasValue)
                    {
                        str = "id <> " + this.IdDocument.Value.ToString() + " and ";
                    }
                    base.SelectSqlData(table, true, string.Format("where {0} idParent = {1} and typeDoc = {2} \r\n                        and not  exists(select id from tJ_DamageCharacter where idDAmage = tj_damage.id)", str, this.IdParent, 0x752), null, false, 0);
                    if (table.Rows.Count > 0)
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
        /// <summary>
        /// обновление даты начала аварии 
        /// </summary>
        private void btnRefreshDataBeginCrash_Click(object sender, EventArgs e)
        {
            if (dataSetDamage.tJ_Damage.Rows.Count < 0)
            {
                return;
            }

            DataTable dataTable;
            if (dataSetDamage.tJ_Damage.Rows[0]["idParent"] == DBNull.Value)
            {
                MessageBox.Show("Не выбран документ аварийного события", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dataTable = new DataTable("tJ_Damage");
            dataTable.Columns.Add("dateDoc", typeof(DateTime));
            this.SelectSqlData(dataTable, true, "  where id = " + this.dataSetDamage.tJ_Damage.Rows[0]["idParent"].ToString(), null, false, 0);
            if (dataTable.Rows.Count > 0)
            {
                this.dataSetDamage.tJ_Damage.Rows[0]["DateDoc"] = dataTable.Rows[0]["dateDoc"];
                return;
            }

        }

        //[CompilerGenerated]
        //private sealed class Class200
        //{
        //    public Control ctrl;

        //    internal void method_0(object sender, EventArgs e)
        //    {
        //        if ((this.ctrl is ComboBox) && !this.ctrl.Focused)
        //        {
        //            ((ComboBox) this.ctrl).SelectionLength = 0;
        //        }
        //    }
        //}
    }

}