using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
//using Documents.Forms.DailyReport.DataSets;
using DailyReport.DataSets;
using FormLbr;
using FormLbr.Classes;
using RequestsClient.Forms.JournalRequestForRepair;
using SchemeModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
/// <summary>
/// аварийное отключение 0,4 кВ
/// </summary>
namespace DailyReport.JournalDamage
{
    public class FormDamageLVAddEdit : FormBase
    {
        private BackgroundWorker backgroundWorker_0;
        private BindingSource bindingSource_0;
        /// <summary>
        /// флаг изменения данных в реквизитах (контролах на форме)
        /// </summary>
        private bool isChangedData;
        /// <summary>
        /// флаг просмотра/редактирования документа
        /// </summary>
        private bool flagViewDoc;
        private Button buttonClose;
        private Button buttonSave;
        private Button btnChoiceSchmObj;
        private Button btnRequestForRepair;
        private CheckBox checkBoxApply;
        private CheckBox checkBoxLaboratory;
        private CheckBox chbDefect;
        private ComboBox cmbWindDirect;
        private ComboBoxReadOnly cmbDivision;
        private ComboBoxReadOnly cmbCompiler;
        private ComboBoxReadOnly cmbReasonPTS;
        private ComboBoxReadOnly cmbObl;
        private ComboBoxReadOnly cmbRaionObl;
        private ComboBoxReadOnly cmbCity;
        private ComboBoxReadOnly cmbStreet;
        private ComboBoxReadOnly cmbWorkerApply;
        private ComboBoxReadOnly cmbCompletedWork;
        private ComboBoxReadOnly cmbReason;
        private ComboBoxReadOnly cmbDivisionApply;
        private DataColumn idSub;
        private DataColumn Sub;
        private DataColumn idAbnObj;
        private DataColumn nameObj;
        private DataColumn CommentODS;
        private DataColumn idTr;
        private DataColumn TrName;
        private DataColumn Power;
        private DataColumn ColumnLoad;
        private DataColumn idAbn;
        private DataColumn codeAbonent;
        private DataColumn nameAbn;
        private DataColumn typeAbn;
        private DataGridView dgvCharacterDamage;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_3;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_5;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvAbn;
        private DataGridViewFilterComboBoxColumn typeAbnDgvColumn;
        private DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn nameAbnDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn nameObjDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn commentODSDgvColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idAbnObjDataGridViewTextBoxColumn;

        private DataSet dataSet_0;
        private dsDamage dataSetDamage;
        private dsDamage dataSetDamage_1;

        private DataTable Table1;
        private DataTable table_vl_SchmAbnFull;

        private DateTime dateTime_0 = DateTimePicker.MaximumDateTime;
        private DateTimePicker dtpDateOwner;
        private GroupBox groupBoxDeclarer;
        private GroupBox groupBoxDefectData;
        private GroupBox groupBoxResult;
        private GroupBox groupBox_3;
        private GroupBox groupBox_4;
        private GroupBox groupBox_5;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private IContainer components = null;

        private int IdDocument = -1;

        private Label label_0;
        private Label label_1;
        private Label labelRaionObl;
        private Label labelCity;
        private Label labelStreet;
        private Label labelHousePrefix;
        private Label labelHouse;
        private Label labelDateAplly;
        private Label labelCompletedWork;
        private Label label1ChatacterDamage;
        private Label labelReason;
        private Label labelDivisionApply;
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
        private Label label_3;
        private Label label18;
        private Label labelDivisionInstruction;
        private Label labelLaboratoryInstruction;
        private Label labelProgress;
        private Label label2;
        private Label labelDateDoc;
        private Label labelNumRequest;
        private Label label8;
        private Label label_7;
        private Label labelSchmObj;
        private Label labelObl;
        private NullableDateTimePicker dtpDateDoc;
        private NullableDateTimePicker dtpDataApply;
        private ProgressBar progressBar;
        private RichTextBox txtLocation;
        private RichTextBox txtCompletedWork;
        private RichTextBox txtTempComment;
        private RichTextBox txtLaboratoryInstruction;
        private RichTextBox txtDivisionInstruction;
        private SplitContainer splitContainer1;
        private string string_0 = "";
        private TabControl tabControl1;
        private TabPage tabPageGeneral;
        private TabPage tabPageWeather;
        private TabPage tabPagePTS;
        private TabPage tabPageAbn;
        private TextBox txtOwner;
        private TextBox txtNumRequest;
        private TextBox txtTempAverage;
        private TextBox txtNightUp;
        private TextBox txtNightDown;
        private TextBox txtDayUp;
        private TextBox txtDayDown;
        private TextBox txtReasonPTS;
        private TextBox txtDocParent;
        private TextBox txtDeclarerAddress;
        private TextBox txtDeclarerTel;
        private TextBox txtDeclarer;
        private TextBox txtSchmObj;
        private TextBox txtHousePrefix;
        private TextBox txtHouse;
        private TextBox txtSpeedUp;
        private TextBox txtSpeedDown;
        private dsDamage.tJ_DamageCharacterDataTable tJ_DamageCharacterDataTable_0;
        private dsDamage.tJ_DamageDataTable tJ_DamageDataTable_0;
        private ToolStrip toolStripAbn;
        private ToolStripButton toolBtnRefreshAbn;
        private ToolStripButton toolBrnDelAbn;
        private ToolTip toolTip_0;
        private int TypeDoc;

   
        public FormDamageLVAddEdit(int idDocument = -1, int typeDoc = 1401)// добавить тип документа для уличного освещения
        {
            ////////////////////////////
            this.InitializeComponent();//qav43Bcfa8Y()
            this.dtpDateDoc.Value = DateTime.Now;
            this.dtpDataApply.Value = (DateTime.Now.Date);

            this.TypeDoc = typeDoc;
            this.IdDocument = idDocument;

            if (typeDoc == 1401)
            {
                this.Text = (idDocument == -1) ? "Добавить аварийное отключение 0,4 кВ" : (this.get_ViewDocDamageLV() ? "Просмотр документа аварийное отключение 0,4 кВ" : "Редактировать аварийное отключение 0,4 кВ") + "(N)";
            }
            else
            {
                this.Text = (idDocument == -1) ? "Добавить повреждение УО" : (this.get_ViewDocDamageLV() ? "Просмотр повреждение УО" : "Редактировать повреждение УО") + "(N)";
            }
        }

        protected override void ApplyConfig(XmlDocument xmlDocument)
        {
            XmlNode node = xmlDocument.SelectSingleNode(base.Name);
            if (node != null)
            {
                XmlAttribute attribute = node.Attributes["idObl"];
                if (attribute != null)
                {
                    this.cmbObl.SelectedValue = Convert.ToInt32(attribute.Value);
                }
                attribute = node.Attributes["idRaionObl"];
                if (attribute != null)
                {
                    this.cmbRaionObl.SelectedValue = Convert.ToInt32(attribute.Value);
                }
            }
        }

        // менять!!!!!!!!!!!!!!!
        private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
        {
            ElectricModel model1 = new ElectricModel();
            model1.SqlSettings = (this.SqlSettings);
            model1.LoadSchema(Convert.ToDateTime(e.Argument));
            model1.PoweringReportForDrawObject(Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"]), true);
            List<ElectricObject> list = model1.PoweringReportForDrawObject(model1.Objects
                .Where<ElectricObject>(new Func<ElectricObject, bool>(this.method_41))
                .First<ElectricObject>(), true, true);
            if (list.Count > 0)
            {
                string str = "";
                foreach (ElectricObject obj2 in list)
                {
                    if (string.IsNullOrEmpty(str))
                    {
                        str = obj2.Id.ToString();
                    }
                    else
                    {
                        str = str + "," + obj2.Id.ToString();
                    }
                }
                base.SelectSqlData(table_vl_SchmAbnFull.TableName, true, " where idSchmObj in (" + str + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj, commentODS ");
            }
            else
            {
                this.table_vl_SchmAbnFull.Clear();
            }
        }

        private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.progressBar.Visible = false;
            this.labelProgress.Visible = false;
            this.toolBtnRefreshAbn.Enabled = true;
            this.dgvAbn.Enabled = true;
            this.dgvAbn.DataSource = this.bindingSource_0;
            this.buttonSave.Enabled = true;
            this.buttonClose.Enabled = true;
            this.btnChoiceSchmObj.Enabled = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnChoiceSchmObj_Click(object sender, EventArgs e)
        {
            CreateReferenceTables.Get_SelectSchmObj(this.SqlSettings, this.dataSetDamage.tJ_Damage.Rows[0], this.txtSchmObj, ref this.isChangedData);
            this.toolRefreshAbn();
        }

        private void btnRequestForRepair_Click(object sender, EventArgs e)
        {
            if (this.dataSetDamage.tJ_Damage.Rows[0]["idReqForRepair"] != DBNull.Value)
            {
                RequestsClient.Forms.JournalRequestForRepair.FormJournalRequestForRepairAddEdit edit1 = new RequestsClient.Forms.JournalRequestForRepair.FormJournalRequestForRepairAddEdit(Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idReqForRepair"]), -1, RequestsClient.Forms.JournalRequestForRepair.eActionRequestRepair.Read, false);
                edit1.GoToSchema += (new GoToSchemaEventHandler(this.method_39));
                edit1.SqlSettings = (this.SqlSettings);
                edit1.MdiParent = base.MdiParent;
                edit1.Show();
            }
        }

        private void checkBoxApply_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBoxLaboratory_CheckedChanged(object sender, EventArgs e)
        {
            this.labelLaboratoryInstruction.Visible = this.txtLaboratoryInstruction.Visible = this.chbDefect.Checked && this.checkBoxLaboratory.Checked;
            this.isChangedData = true;
        }

        private void chbDefect_CheckedChanged(object sender, EventArgs e)
        {
            this.labelDivisionApply.Visible = this.chbDefect.Checked;
            this.cmbDivisionApply.Visible = (this.chbDefect.Checked);
            this.checkBoxLaboratory.Visible = this.chbDefect.Checked;
            this.labelDivisionInstruction.Visible = this.txtDivisionInstruction.Visible = this.chbDefect.Checked && (this.cmbDivisionApply.SelectedIndex >= 0);
            this.labelLaboratoryInstruction.Visible = this.txtLaboratoryInstruction.Visible = this.chbDefect.Checked && this.checkBoxLaboratory.Checked;
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
                }
                else
                {
                    this.label_1.ForeColor = Color.Black;
                    DataRow[] source = ((DataTable)this.cmbCompiler.DataSource).Select("id = " + this.cmbCompiler.SelectedValue.ToString());
                    if (source.Count<DataRow>() > 0)
                    {
                        this.cmbDivision.SelectedValue = source[0]["idGRoup"];
                    }
                }
            }
        }

        private void cmbReasonPTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((this.cmbReasonPTS.SelectedIndex >= 0) && (this.cmbReasonPTS.SelectedValue != null))
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

        private void cmbObl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbObl.SelectedIndex < 0)
            {
                this.cmbRaionObl.DataSource = null;
            }
            else
            {
                this.labelObl.ForeColor = Color.Black;
                DataTable table = CreateReferenceTables.CreateTableKladObj();
                base.SelectSqlData(table, true, " where ParentId = " + this.cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
                this.cmbRaionObl.DisplayMember = "fullname";
                this.cmbRaionObl.ValueMember = "id";
                this.cmbRaionObl.DataSource = table;
                this.cmbRaionObl.SelectedIndex = -1;
            }
        }

        private void cmbRaionObl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbRaionObl.SelectedIndex < 0)
            {
                this.cmbCity.DataSource = null;
                this.cmbStreet.DataSource = null;
            }
            else
            {
                this.labelRaionObl.ForeColor = Color.Black;
                DataTable table = CreateReferenceTables.CreateTableKladObj();
                base.SelectSqlData(table, true, " where ParentId = " + this.cmbRaionObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
                this.cmbCity.DisplayMember = "fullname";
                this.cmbCity.ValueMember = "id";
                this.cmbCity.DataSource = table;
                this.cmbCity.SelectedIndex = -1;
                DataTable table2 = CreateReferenceTables.CreateTableKladrStreet();
                base.SelectSqlData(table2, true, " where KladrObjId = " + this.cmbRaionObl.SelectedValue + " and deleted = 0 order by name, socr ", null, false, 0);
                this.cmbStreet.DisplayMember = "fullname";
                this.cmbStreet.ValueMember = "id";
                this.cmbStreet.DataSource = table2;
                this.cmbStreet.SelectedIndex = -1;
            }
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCity.SelectedIndex >= 0)
            {
                DataTable table = CreateReferenceTables.CreateTableKladrStreet();
                base.SelectSqlData(table, true, " where KladrObjId = " + this.cmbCity.SelectedValue + " and deleted = 0 order by name, socr ", null, false, 0);
                this.cmbStreet.DisplayMember = "fullname";
                this.cmbStreet.ValueMember = "id";
                this.cmbStreet.DataSource = table;
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

        private void cmbWorkerApply_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.cmbWorkerApply.SelectedIndex >= 0)
            {
                this.checkBoxApply.ForeColor = Color.Black;
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

        private void cmbReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbReason.SelectedIndex >= 0)
            {
                this.labelReason.ForeColor = Color.Black;
            }
            this.isChangedData = true;
        }

        private void cmbDivisionApply_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back))
            {
                this.cmbDivisionApply.SelectedIndex = -1;
                this.isChangedData = true;
            }
        }

        private void cmbDivisionApply_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelDivisionInstruction.Visible = this.txtDivisionInstruction.Visible = this.chbDefect.Checked && (this.cmbDivisionApply.SelectedIndex >= 0);
            this.isChangedData = true;
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document = new XmlDocument();
            XmlNode newChild = document.CreateXmlDeclaration("1.0", "UTF-8", null);
            document.AppendChild(newChild);
            XmlNode node2 = document.CreateElement(base.Name);
            document.AppendChild(node2);
            if (this.cmbObl.SelectedValue != null)
            {
                XmlAttribute node = document.CreateAttribute("idObl");
                node.Value = this.cmbObl.SelectedValue.ToString();
                node2.Attributes.Append(node);
            }
            if (this.cmbRaionObl.SelectedValue != null)
            {
                XmlAttribute attribute2 = document.CreateAttribute("idRaionObl");
                attribute2.Value = this.cmbRaionObl.SelectedValue.ToString();
                node2.Attributes.Append(attribute2);
            }
            return document;
        }

        private void dgvCharacterDamage_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvCharacterDamage.IsCurrentCellDirty)
            {
                this.dgvCharacterDamage.CommitEdit(DataGridViewDataErrorContexts.Commit);
                this.isChangedData = true;
                this.label1ChatacterDamage.ForeColor = Color.Black;
                if (((this.dgvCharacterDamage.CurrentCell.ColumnIndex == 0) || (this.dgvCharacterDamage.CurrentCell.ColumnIndex == 1)) && (this.dgvCharacterDamage.CurrentCell.Value != null))
                {
                    DataTable table = this.method_7();
                    base.SelectSqlData(table, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", this.dgvCharacterDamage.CurrentCell.Value), null, false, 0);
                    DataGridViewComboBoxCell cell = this.dgvCharacterDamage[this.dgvCharacterDamage.CurrentCell.ColumnIndex + 1, this.dgvCharacterDamage.CurrentRow.Index] as DataGridViewComboBoxCell;
                    cell.DataSource = table;
                    cell.DisplayMember = "name";
                    cell.ValueMember = "id";
                    if ((cell.Value != null) && (table.Select("id = " + cell.Value.ToString()).Length == 0))
                    {
                        cell.Value = null;
                    }
                    if ((cell.Value == null) && (cell.ColumnIndex == 1))
                    {
                        DataGridViewComboBoxCell cell1 = this.dgvCharacterDamage[cell.ColumnIndex + 1, this.dgvCharacterDamage.CurrentRow.Index] as DataGridViewComboBoxCell;
                        cell1.DataSource = null;
                        cell1.Value = null;
                    }
                }
            }
        }

        private void dgvCharacterDamage_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (this.dgvCharacterDamage.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                e.Cancel = true;
            }
        }

        private void dgvCharacterDamage_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dgvCharacterDamage.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.RowHeader)
            {
                this.dgvCharacterDamage.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                this.dgvCharacterDamage.EndEdit();
            }
            else
            {
                this.dgvCharacterDamage.EditMode = DataGridViewEditMode.EditOnEnter;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormDamageLVAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((base.DialogResult != DialogResult.OK) && ((!this.isChangedData || this.get_ViewDocDamageLV()) || (MessageBox.Show("Сохранить внесенные изменения", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)))
            {
                base.DialogResult = DialogResult.Cancel;
            }
            else if (this.method_21() && this.method_22())
            {
                this.method_36();
                if (this.method_23())
                {
                    base.SaveFormConfig(null);
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
                base.DialogResult = DialogResult.None;
                e.Cancel = true;
            }
        }

        private void FormDamageLVAddEdit_Load(object sender, EventArgs e)
        {
            this.method_5();
            this.method_8();
            this.method_9();
            this.method_29();
            this.method_11();
            this.method_12();
            this.method_13();
            this.method_14();
            this.method_15();
            this.method_16();
            this.method_17();
            this.method_34();
            base.LoadFormConfig(null);
            if (this.IdDocument == -1)
            {
                DataRow row = this.dataSetDamage.tJ_Damage.NewRow();
                row["TYpeDoc"] = 0x579;
                row["dateOwner"] = DateTime.Now;
                this.dataSetDamage.tJ_Damage.Rows.Add(row);
                this.method_6();
            }
            else
            {
                dsDamage.tJ_DamageDataTable table = new dsDamage.tJ_DamageDataTable();
                base.SelectSqlData(table, true, "where id = " + this.IdDocument.ToString(), null, false, 0);
                if ((table.Rows.Count > 0) && (table.Rows[0]["dateDoc"] != DBNull.Value))
                {
                    this.dtpDateDoc.Value = (Convert.ToDateTime(table.Rows[0]["dateDoc"]));
                }
                base.SelectSqlData(this.dataSetDamage.tJ_Damage, true, "where id = " + this.IdDocument.ToString(), null, false, 0);
                if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
                {
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["numDoc"] != DBNull.Value)
                    {
                        this.Text = this.Text + " №" + this.dataSetDamage.tJ_Damage.Rows[0]["numDoc"].ToString();
                    }
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"] != DBNull.Value)
                    {
                        string[] textArray1 = new string[] { this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"].ToString() };
                        this.txtSchmObj.Text = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1).ToString();
                    }
                    if ((this.dataSetDamage.tJ_Damage.Rows[0]["idDivisionApply"] != DBNull.Value) || ((this.dataSetDamage.tJ_Damage.Rows[0]["isLaboratory"] != DBNull.Value) && Convert.ToBoolean(this.dataSetDamage.tJ_Damage.Rows[0]["isLaboratory"])))
                    {
                        this.chbDefect.Checked = true;
                    }
                }
                this.method_33();
                this.method_30();
                this.method_4();
                this.method_38();
                base.SelectSqlData(this.dataSetDamage.tJ_DamageLV, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
                if (this.dataSetDamage.tJ_DamageLV.Rows.Count == 0)
                {
                    this.method_6();
                }
                CreateReferenceTables.Load_TableDamageAbnFull(this.dataSetDamage.tJ_DamageLV, this.table_vl_SchmAbnFull, this.SqlSettings);
            }
            this.method_10();
            this.method_35();
            this.isChangedData = false;
        }

        private void FormDamageLVAddEdit_Shown(object sender, EventArgs e)
        {
            this.isChangedData = false;
        }
        /// <summary>
        /// вернуть id документа
        /// </summary>
        public int getIdUseDoc()
        {
            return this.IdDocument;
        }
        /// <summary>
        /// режим открытия документа (редактирование/просмотр)
        /// </summary>
        /// <returns></returns>
        public bool get_ViewDocDamageLV()
        {
            return this.flagViewDoc;
        }

        private void method_10()
        {
            if (this.IdDocument == -1)
            {
                DataTable table = new DataTable("tUser");
                table.Columns.Add("name", typeof(string));
                table.Columns.Add("idWorker", typeof(string));
                base.SelectSqlData(table, true, "where [login] = SYSTEM_USER", null, false, 0);
                if (table.Rows.Count > 0)
                {
                    if (table.Rows[0]["name"] != DBNull.Value)
                    {
                        this.txtOwner.Text = table.Rows[0]["name"].ToString();
                    }
                    if (table.Rows[0]["idWorker"] != DBNull.Value)
                    {
                        DataRow[] source = ((DataTable)this.cmbCompiler.DataSource).Select("id = " + table.Rows[0]["idWorker"]);
                        if (((source.Count<DataRow>() > 0) && (this.IdDocument == -1)) && (this.dataSetDamage.tJ_Damage.Rows.Count > 0))
                        {
                            this.dataSetDamage.tJ_Damage.Rows[0]["idCompiler"] = source[0]["id"];
                        }
                    }
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

        private void method_11()
        {
            DataTable table = this.method_7();
            if (((this.tJ_DamageDataTable_0 != null) && (this.tJ_DamageDataTable_0.Rows.Count > 0)) && (this.tJ_DamageDataTable_0.Rows[0]["idReason"] != DBNull.Value))
            {
                base.SelectSqlData(table, true, string.Format(" where (ParentKey = ';ReportDaily;DamageReason;LV;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0}) order by name", this.tJ_DamageDataTable_0.Rows[0]["idReason"]), null, false, 0);
            }
            else
            {
                base.SelectSqlData(table, true, " where ParentKey = ';ReportDaily;DamageReason;LV;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
            }
            this.cmbReason.DisplayMember = "name";
            this.cmbReason.ValueMember = "id";
            this.cmbReason.DataSource = table;
            this.cmbReason.SelectedIndex = -1;
        }

        private void method_12()
        {
            DataTable table = this.method_7();
            if (((this.tJ_DamageDataTable_0 != null) && (this.tJ_DamageDataTable_0.Rows.Count > 0)) && (this.tJ_DamageDataTable_0.Rows[0]["idCompletedWork"] != DBNull.Value))
            {
                base.SelectSqlData(table, true, string.Format(" where (ParentKey = ';ReportDaily;CompletedWork;LV;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0}) order by name", this.tJ_DamageDataTable_0.Rows[0]["idCompletedWork"]), null, false, 0);
            }
            else
            {
                base.SelectSqlData(table, true, " where ParentKey = ';ReportDaily;CompletedWork;LV;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
            }
            this.cmbCompletedWork.DisplayMember = "name";
            this.cmbCompletedWork.ValueMember = "id";
            this.cmbCompletedWork.DataSource = table;
            this.cmbCompletedWork.SelectedIndex = -1;
        }

        private void method_13()
        {
            DataTable table = new DataTable("vWorkerGroup");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("FIO", typeof(string));
            table.Columns.Add("idGroup", typeof(int));
            base.SelectSqlData(table, true, " where ParentKey in (';GroupWorker;Workers;')  and dateend is null group by id, fio, idGRoup order by fio ", null, false, 0);
            this.cmbWorkerApply.DisplayMember = "FIO";
            this.cmbWorkerApply.ValueMember = "id";
            this.cmbWorkerApply.DataSource = table;
            this.cmbWorkerApply.SelectedIndex = -1;
        }

        private void method_14()
        {
            DataTable table = this.method_7();
            base.SelectSqlData(table, true, " where ParentKey = ';ReportDaily;DivisionApply;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
            this.cmbDivisionApply.DisplayMember = "name";
            this.cmbDivisionApply.ValueMember = "id";
            this.cmbDivisionApply.DataSource = table;
            this.cmbDivisionApply.SelectedIndex = -1;
        }

        private void method_15()
        {
            DataTable table = new DataTable("tR_Classifier");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            base.SelectSqlData(table, true, "where ParentKey = ';ReportDaily;WindDirect;' and isGroup = 0 and deleted = 0 order by name", null, false, 0);
            this.cmbWindDirect.DisplayMember = "name";
            this.cmbWindDirect.ValueMember = "id";
            this.cmbWindDirect.DataSource = table;
            this.cmbWindDirect.SelectedIndex = -1;
        }

        private void method_16()
        {
            DataTable table = this.method_7();
            table.Columns.Add("value", typeof(decimal));
            table.Columns.Add("nameFull", typeof(string), "name + ' (' + convert(convert(value, 'System.Single'), 'System.String') + ')'");
            base.SelectSqlData(table, true, " where ParentKey like ';ReportDaily;PTS;ReasonDamage;LV;%' and isGRoup =0 and deleted = 0 order by value", null, false, 0);
            this.cmbReasonPTS.DisplayMember = "nameFull";
            this.cmbReasonPTS.ValueMember = "id";
            this.cmbReasonPTS.DataSource = table;
        }

        private void method_17()
        {
            DataTable table = this.method_7();
            base.SelectSqlData(table, true, " where  parentKey = ';SKUEE;TypeAbn;' and isGRoup = 0 and deleted  = 0", null, false, 0);
            this.typeAbnDgvColumn.DisplayMember = "name";
            this.typeAbnDgvColumn.ValueMember = "id";
            BindingSource source = new BindingSource
            {
                DataSource = table
            };
            this.typeAbnDgvColumn.DataSource = source;
        }

        private void method_18(object sender, EventArgs e)
        {
            this.isChangedData = true;
        }

        private void method_19(object sender, EventArgs e)
        {
            this.isChangedData = true;
        }
        /// <summary>
        /// режим просмотра документа
        /// </summary>
        public void FormViewMode(bool flg)
        {
            this.flagViewDoc = flg;
            this.ControlBlocking();
        }

        private void method_20(object sender, FormClosedEventArgs e)
        {
            FormSelectSchmObj form = (FormSelectSchmObj)sender;
            if (form.DialogResult == DialogResult.OK)
            {
                this.isChangedData = true;
                if (form.method_0().Count > 0)
                {
                    this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"] = form.method_0().First<KeyValuePair<int, string>>().Key;
                    this.txtSchmObj.Text = form.method_0().First<KeyValuePair<int, string>>().Value;
                }
                else
                {
                    this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"] = DBNull.Value;
                    this.txtSchmObj.Text = string.Empty;
                }
            }
        }

        private bool method_21()
        {
            bool flag = true;
            if ((this.dtpDateDoc.Value == null) || (this.dtpDateDoc.Value == DBNull.Value))
            {
                this.labelDateDoc.ForeColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrEmpty(this.txtNumRequest.Text))
            {
                this.labelNumRequest.ForeColor = Color.Red;
                flag = false;
            }
            if (this.cmbCompiler.SelectedIndex < 0)
            {
                this.label_1.ForeColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrEmpty(this.txtSchmObj.Text))
            {
                this.labelSchmObj.ForeColor = Color.Red;
                flag = false;
            }
            if ((((this.dtpDateDoc.Value != null) && (this.dtpDateDoc.Value != DBNull.Value)) && ((this.dtpDataApply.Value != null) && (this.dtpDataApply.Value != DBNull.Value))) && (Convert.ToDateTime(this.dtpDataApply.Value) < Convert.ToDateTime(this.dtpDateDoc.Value)))
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
                if (this.cmbCompletedWork.SelectedIndex < 0)
                {
                    this.labelCompletedWork.ForeColor = Color.Red;
                    flag = false;
                }
                if (this.cmbWorkerApply.SelectedIndex < 0)
                {
                    this.checkBoxApply.ForeColor = Color.Red;
                    flag = false;
                }
                if ((this.dtpDataApply.Value == null) || (this.dtpDataApply.Value == DBNull.Value))
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

        private bool method_22()
        {
            if (this.dataSetDamage.tJ_Damage.Rows.Count <= 0)
            {
                return true;
            }
            DataTable table = new DataTable("tJ_Damage");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("numREquest", typeof(string));
            table.Columns.Add("dateDoc", typeof(DateTime));
            base.SelectSqlData(table, true, string.Format("where numRequest = '{0}' and year(dateDoc) = {1} and typeDoc = {2} and id <> {3} and idDivision = {4}", new object[] { this.dataSetDamage.tJ_Damage.Rows[0]["numRequest"].ToString(), Convert.ToDateTime(this.dataSetDamage.tJ_Damage.Rows[0]["dateDoc"]).Year, 0x579, this.dataSetDamage.tJ_Damage.Rows[0]["id"].ToString(), Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idDivision"]) }), null, false, 0);
            return ((table.Rows.Count <= 0) || (MessageBox.Show(string.Format("Заявка с номером {0} в текущем году уже была. Хотите все равно сохранить?", this.dataSetDamage.tJ_Damage.Rows[0]["numRequest"].ToString()), "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes));
        }

        private bool method_23()
        {
            if (!this.chbDefect.Checked)
            {
                this.cmbDivisionApply.SelectedIndex = -1;
                this.checkBoxLaboratory.Checked = false;
            }
            int? nullable = this.method_28();
            if (!nullable.HasValue)
            {
                this.dataSetDamage.tJ_Damage.Rows[0]["idMap"] = DBNull.Value;
            }
            else
            {
                this.dataSetDamage.tJ_Damage.Rows[0]["idMap"] = nullable;
            }
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
            if (!this.method_25())
            {
                return false;
            }
            if (!this.method_24())
            {
                return false;
            }
            if (!this.method_26())
            {
                return false;
            }
            return true;
        }

        private bool method_24()
        {
            base.SelectSqlData(this.dataSetDamage.tJ_DamageCharacter, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
            for (int i = this.dgvCharacterDamage.Rows.Count - 1; i < this.dataSetDamage.tJ_DamageCharacter.Rows.Count; i++)
            {
                this.dataSetDamage.tJ_DamageCharacter.Rows[i].Delete();
            }
            for (int j = 0; j < (this.dgvCharacterDamage.Rows.Count - 1); j++)
            {
                if (j < this.dataSetDamage.tJ_DamageCharacter.Rows.Count)
                {
                    this.dataSetDamage.tJ_DamageCharacter.Rows[j]["idDamage"] = this.IdDocument;
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_3.Name].Value != null)
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col1"] = this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_3.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col1"] = DBNull.Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_4.Name].Value != null)
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col2"] = this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_4.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col2"] = DBNull.Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_5.Name].Value != null)
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col3"] = this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_5.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col3"] = DBNull.Value;
                    }
                    this.dataSetDamage.tJ_DamageCharacter.Rows[j].EndEdit();
                }
                else
                {
                    DataRow row = this.dataSetDamage.tJ_DamageCharacter.NewRow();
                    row["idDamage"] = this.IdDocument;
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_3.Name].Value != null)
                    {
                        row["col1"] = this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_3.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_4.Name].Value != null)
                    {
                        row["col2"] = this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_4.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_5.Name].Value != null)
                    {
                        row["col3"] = this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_5.Name].Value;
                    }
                    this.dataSetDamage.tJ_DamageCharacter.Rows.Add(row);
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

        private bool method_25()
        {
            if (this.dataSetDamage.tJ_DamageLV.Rows.Count > 0)
            {
                this.dataSetDamage.tJ_DamageLV.Rows[0]["idDamage"] = this.IdDocument;
                this.dataSetDamage.tJ_DamageLV.Rows[0]["AbnOff"] = CreateReferenceTables.CreateXmlAbnOff(this.table_vl_SchmAbnFull).InnerXml;
                this.dataSetDamage.tJ_DamageLV.Rows[0].EndEdit();
                if (!base.InsertSqlData(this.dataSetDamage.tJ_DamageLV))
                {
                    return false;
                }
                if (!base.UpdateSqlDataOnlyChange(this.dataSetDamage.tJ_DamageLV))
                {
                    return false;
                }
                base.SelectSqlData(this.dataSetDamage.tJ_DamageLV, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
            }
            return true;
        }

        private bool method_26()
        {
            //IEnumerator enumerator;
            dsDamage.tJ_DamageDataTable table = new dsDamage.tJ_DamageDataTable();
            base.SelectSqlData(table, true, string.Format("where idParent = {0} and TypeDoc = {1} and idDivisionApply is not null", this.IdDocument, 1403), null, false, 0);
            if (this.cmbDivisionApply.SelectedIndex >= 0)
            {
                for (int i = 1; i < table.Rows.Count; i++)
                {
                    table.Rows[i].Delete();
                }
                int idDamage = -1;
                if (table.Rows.Count > 0)
                {
                    CreateReferenceTables.Set_TableDamage(table.Rows[0], this.dataSetDamage, this.IdDocument, 1403, true, false);
                    table.Rows[0].EndEdit();
                    if (!base.UpdateSqlData(table))
                    {
                        return false;
                    }
                    if (!this.method_27(Convert.ToInt32(table.Rows[0]["id"])))
                    {
                        return false;
                    }
                    idDamage = Convert.ToInt32(table.Rows[0]["id"]);
                }
                else
                {
                    DataRow row = table.NewRow();
                    CreateReferenceTables.Set_TableDamage(row, this.dataSetDamage, this.IdDocument, 1403, true, false);
                    table.Rows.Add(row);
                    idDamage = base.InsertSqlDataOneRow(row);
                    if (idDamage <= 0)
                    {
                        return false;
                    }
                    if (!this.method_27(idDamage))
                    {
                        return false;
                    }
                }
                _Mail.Send(idDamage, this.SqlSettings);
            }
            else
            {
                // using (enumerator = table.Rows.GetEnumerator())
                // {
                //    while (enumerator.MoveNext())
                foreach (IEnumerator row in table.Rows)
                {
                    ((DataRow)row.Current).Delete();
                }
                //}
                if (!base.DeleteSqlData(table))
                {
                    return false;
                }
            }
            base.SelectSqlData(table, true, string.Format("where idParent = {0} and TypeDoc = {1} and isLaboratory is not null", this.IdDocument, 1403), null, false, 0);
            if (this.checkBoxLaboratory.Checked)
            {
                for (int j = 1; j < table.Rows.Count; j++)
                {
                    table.Rows[j].Delete();
                }
                int idDamage = -1;
                if (table.Rows.Count > 0)
                {
                    CreateReferenceTables.Set_TableDamage(table.Rows[0], this.dataSetDamage, this.IdDocument, 1403, false, true);
                    table.Rows[0].EndEdit();
                    if (!base.UpdateSqlData(table))
                    {
                        return false;
                    }
                    if (!this.method_27(Convert.ToInt32(table.Rows[0]["id"])))
                    {
                        return false;
                    }
                    idDamage = Convert.ToInt32(table.Rows[0]["id"]);
                }
                else
                {
                    DataRow row2 = table.NewRow();
                    CreateReferenceTables.Set_TableDamage(row2, this.dataSetDamage, this.IdDocument, 1403, false, true);
                    table.Rows.Add(row2);
                    idDamage = base.InsertSqlDataOneRow(row2);
                    if (idDamage <= 0)
                    {
                        return false;
                    }
                    if (!this.method_27(idDamage))
                    {
                        return false;
                    }
                }
                _Mail.Send(idDamage, this.SqlSettings);
            }
            else
            {
                //using (enumerator = table.Rows.GetEnumerator())
                //{
                //    while (enumerator.MoveNext())
                //    {
                //        ((DataRow) enumerator.Current).Delete();
                //    }
                //}
                foreach (IEnumerator row in table.Rows)
                {
                    ((DataRow)row.Current).Delete();
                }
                if (!base.DeleteSqlData(table))
                {
                    return false;
                }
            }
            return true;
        }

        private bool method_27(int id)
        {
            dsDamage.tJ_DamageCharacterDataTable table = new dsDamage.tJ_DamageCharacterDataTable();
            base.SelectSqlData(table, true, "where idDamage = " + id.ToString(), null, false, 0);
            for (int i = this.dataSetDamage.tJ_DamageCharacter.Rows.Count; i < table.Rows.Count; i++)
            {
                table.Rows[i].Delete();
            }
            for (int j = 0; j < this.dataSetDamage.tJ_DamageCharacter.Rows.Count; j++)
            {
                if (j < table.Rows.Count)
                {
                    table.Rows[j]["idDamage"] = id;
                    table.Rows[j]["col1"] = this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col1"];
                    table.Rows[j]["col2"] = this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col2"];
                    table.Rows[j]["col3"] = this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col3"];
                    table.Rows[j].EndEdit();
                }
                else
                {
                    DataRow row = table.NewRow();
                    row["idDamage"] = id;
                    row["col1"] = this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col1"];
                    row["col2"] = this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col2"];
                    row["col3"] = this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col3"];
                    table.Rows.Add(row);
                }
            }
            if (!base.DeleteSqlData(table))
            {
                return false;
            }
            if (!base.UpdateSqlData(table))
            {
                return false;
            }
            if (!base.InsertSqlData(table))
            {
                return false;
            }
            return true;
        }

        private int? method_28()
        {
            if (((this.cmbStreet.SelectedValue == null) || (this.cmbStreet.SelectedValue == DBNull.Value)) || string.IsNullOrEmpty(this.txtHouse.Text))
            {
                return null;
            }
            string str = string.IsNullOrEmpty(this.txtHousePrefix.Text) ? " and HousePrefix is null " : (" and HousePrefix = '" + this.txtHousePrefix.Text + "'");
            base.SelectSqlData(this.dataSetDamage.tMapObj, true, "where Street = " + this.cmbStreet.SelectedValue.ToString() + " and House = " + this.txtHouse.Text + str + " and IsHouse = 1 and Name is null", null, false, 0);
            if (this.dataSetDamage.tMapObj.Rows.Count > 0)
            {
                return new int?(Convert.ToInt32(this.dataSetDamage.tMapObj.Rows[0]["idMap"]));
            }
            DataRow row = this.dataSetDamage.tMapObj.NewRow();
            row["Street"] = this.cmbStreet.SelectedValue;
            row["House"] = this.txtHouse.Text;
            if (!string.IsNullOrEmpty(this.txtHousePrefix.Text))
            {
                row["HousePrefix"] = this.txtHousePrefix.Text;
            }
            row["IsHouse"] = true;
            row["Deleted"] = 0;
            this.dataSetDamage.tMapObj.Rows.Add(row);
            this.dataSetDamage.tMapObj.Rows[0].EndEdit();
            int num = base.InsertSqlDataOneRow(this.dataSetDamage, this.dataSetDamage.tMapObj);
            if (num == -1)
            {
                return null;
            }
            return new int?(num);
        }

        private void method_29()
        {
            DataTable table = CreateReferenceTables.CreateTableKladObj();
            base.SelectSqlData(table, true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr", null, false, 0);
            this.cmbObl.DisplayMember = "fullname";
            this.cmbObl.ValueMember = "id";
            this.cmbObl.DataSource = table;
        }
        /// <summary>
        /// Метод блокирующий контролы для редактирования, при просмотре документа и наоборт
        /// </summary>
        private void ControlBlocking()
        {
            bool flag;
            bool flag2;
            bool flag3;
            if (this.get_ViewDocDamageLV()) // get_ViewDocDamageLV
            {
                this.Text = "Просмотр документа аварийное отключение 0,4 кВ";
            }
            this.txtNumRequest.ReadOnly = this.get_ViewDocDamageLV();
            this.dtpDateDoc.Enabled = !this.get_ViewDocDamageLV();
            this.cmbCompiler.ReadOnly = (this.get_ViewDocDamageLV());
            this.cmbDivision.ReadOnly = (this.get_ViewDocDamageLV());
            this.txtDeclarer.ReadOnly = this.get_ViewDocDamageLV();
            this.txtDeclarerTel.ReadOnly = this.get_ViewDocDamageLV();
            this.txtDeclarerAddress.ReadOnly = this.get_ViewDocDamageLV();
            this.btnChoiceSchmObj.Enabled = !this.get_ViewDocDamageLV();
            this.txtLocation.ReadOnly = this.get_ViewDocDamageLV();
            this.cmbStreet.ReadOnly = (flag3 = this.get_ViewDocDamageLV());
            this.cmbCity.ReadOnly = (flag2 = flag3);
            this.cmbRaionObl.ReadOnly = (flag = flag2);
            this.cmbObl.ReadOnly = (flag);
            this.txtHouse.ReadOnly = this.txtHousePrefix.ReadOnly = this.get_ViewDocDamageLV();
            this.cmbReason.ReadOnly = (this.get_ViewDocDamageLV());
            this.dgvCharacterDamage.ReadOnly = this.get_ViewDocDamageLV();
            this.cmbCompletedWork.ReadOnly = (this.get_ViewDocDamageLV());
            this.txtCompletedWork.ReadOnly = this.get_ViewDocDamageLV();
            this.checkBoxApply.Enabled = !this.get_ViewDocDamageLV();
            this.cmbWorkerApply.ReadOnly = (this.get_ViewDocDamageLV());
            this.dtpDataApply.Enabled = !this.get_ViewDocDamageLV();
            this.chbDefect.Enabled = !this.get_ViewDocDamageLV();
            this.cmbDivisionApply.ReadOnly = (this.get_ViewDocDamageLV());
            this.checkBoxLaboratory.Enabled = !this.get_ViewDocDamageLV();
            this.txtLaboratoryInstruction.ReadOnly = this.txtDivisionInstruction.ReadOnly = !this.chbDefect.Checked && this.get_ViewDocDamageLV();
            this.cmbReasonPTS.ReadOnly = (this.get_ViewDocDamageLV());
            this.toolBtnRefreshAbn.Enabled = this.toolBrnDelAbn.Enabled = !this.get_ViewDocDamageLV();
            this.buttonSave.Visible = !this.get_ViewDocDamageLV();
        }

        private void method_30()
        {
            if (this.dataSetDamage.tJ_Damage.Rows[0]["idmap"] != DBNull.Value)
            {
                base.SelectSqlData(this.dataSetDamage.tMapObj, true, " where idMap = " + this.dataSetDamage.tJ_Damage.Rows[0]["idmap"].ToString(), null, false, 0);
                this.txtHouse.Text = this.dataSetDamage.tMapObj.Rows[0]["House"].ToString();
                this.txtHousePrefix.Text = this.dataSetDamage.tMapObj.Rows[0]["HousePrefix"].ToString();
                DataTable table = CreateReferenceTables.CreateTableKladrStreet();
                base.SelectSqlData(table, true, " where id = " + this.dataSetDamage.tMapObj.Rows[0]["Street"].ToString(), null, false, 0);
                int num = 0x18;
                if (table.Rows.Count > 0)
                {
                    num = Convert.ToInt32(table.Rows[0]["KladrObjId"]);
                }
                List<DataRow> list = new List<DataRow>();
                this.method_31(num, list);
                this.method_32(list);
                if (this.dataSetDamage.tMapObj.Rows[0]["Street"] != DBNull.Value)
                {
                    this.cmbStreet.SelectedValue = this.dataSetDamage.tMapObj.Rows[0]["Street"];
                }
            }
        }

        private void method_31(int int_1, List<DataRow> list_0)
        {
            DataTable table = CreateReferenceTables.CreateTableKladObj();
            base.SelectSqlData(table, true, " where id = " + int_1.ToString(), null, false, 0);
            if (((table.Rows.Count != 0) && ((table.Rows[0]["PrimaryKey"] == DBNull.Value) || (table.Rows[0]["PrimaryKey"].ToString() != "Country"))) && (table.Rows[0]["ParentId"] != DBNull.Value))
            {
                list_0.Add(table.Rows[0]);
                this.method_31(Convert.ToInt32(table.Rows[0]["ParentId"]), list_0);
            }
        }

        private void method_32(List<DataRow> list_0)
        {
            DataTable table = CreateReferenceTables.CreateTableKladObj();
            switch (list_0.Count)
            {
                case 0:
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.DisplayMember = "namefull";
                    this.cmbObl.ValueMember = "id";
                    this.cmbObl.DataSource = table;
                    base.SelectSqlData(table, true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr", null, false, 0);
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.SelectedIndex = 0;
                    return;

                case 1:
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.DisplayMember = "namefull";
                    this.cmbObl.ValueMember = "id";
                    this.cmbObl.DataSource = table;
                    base.SelectSqlData(table, true, " where ParentId = " + list_0[0]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.SelectedValue = Convert.ToInt32(list_0[0]["Id"]);
                    return;

                case 2:
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.DisplayMember = "namefull";
                    this.cmbObl.ValueMember = "id";
                    this.cmbObl.DataSource = table;
                    base.SelectSqlData(table, true, " where ParentId = " + list_0[1]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.SelectedValue = Convert.ToInt32(list_0[1]["Id"]);
                    this.cmbRaionObl.SelectedValue = Convert.ToInt32(list_0[0]["Id"]);
                    return;
            }
            this.cmbObl.SelectedIndex = -1;
            this.cmbObl.DisplayMember = "namefull";
            this.cmbObl.ValueMember = "id";
            this.cmbObl.DataSource = table;
            base.SelectSqlData(table, true, " where ParentId = " + list_0[2]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
            this.cmbObl.SelectedIndex = -1;
            this.cmbObl.SelectedValue = Convert.ToInt32(list_0[2]["Id"]);
            this.cmbRaionObl.SelectedValue = Convert.ToInt32(list_0[1]["Id"]);
            this.cmbCity.SelectedValue = Convert.ToInt32(list_0[0]["Id"]);
        }

        private void method_33()
        {
            this.dgvCharacterDamage.Rows.Clear();
            base.SelectSqlData(this.dataSetDamage.tJ_DamageCharacter, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
            int num = 0;
            foreach (DataRow row in this.dataSetDamage.tJ_DamageCharacter)
            {
                this.dgvCharacterDamage.Rows.Add();
                if (row["col1"] != DBNull.Value)
                {
                    this.dgvCharacterDamage.CurrentCell = this.dgvCharacterDamage.Rows[num].Cells[this.dataGridViewComboBoxColumn_3.Name];
                    this.dgvCharacterDamage.Rows[num].Cells[this.dataGridViewComboBoxColumn_3.Name].Value = row["col1"];
                    DataTable table = this.method_7();
                    if (this.tJ_DamageCharacterDataTable_0 != null)
                    {
                        DataRow[] rowArray = this.tJ_DamageCharacterDataTable_0.Select("id = " + row["id"].ToString());
                        if ((rowArray.Length != 0) && (rowArray[0]["col2"] != DBNull.Value))
                        {
                            base.SelectSqlData(table, true, string.Format(" where (parentId = {0} and isGroup = 1 and Deleted = 0) or (id = {1}) order by parentKey", row["col1"], rowArray[0]["col2"]), null, false, 0);
                        }
                        else
                        {
                            base.SelectSqlData(table, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", row["col1"]), null, false, 0);
                        }
                    }
                    else
                    {
                        base.SelectSqlData(table, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", row["col1"]), null, false, 0);
                    }
                    DataGridViewComboBoxCell cell1 = this.dgvCharacterDamage[1, num] as DataGridViewComboBoxCell;
                    cell1.DataSource = table;
                    cell1.DisplayMember = "name";
                    cell1.ValueMember = "id";
                }
                if (row["col2"] != DBNull.Value)
                {
                    this.dgvCharacterDamage.CurrentCell = this.dgvCharacterDamage.Rows[num].Cells[this.dataGridViewComboBoxColumn_3.Name];
                    this.dgvCharacterDamage.Rows[num].Cells[this.dataGridViewComboBoxColumn_4.Name].Value = row["col2"];
                    DataTable table2 = this.method_7();
                    if (this.tJ_DamageCharacterDataTable_0 != null)
                    {
                        DataRow[] rowArray2 = this.tJ_DamageCharacterDataTable_0.Select("id = " + row["id"].ToString());
                        if ((rowArray2.Length != 0) && (rowArray2[0]["col3"] != DBNull.Value))
                        {
                            base.SelectSqlData(table2, true, string.Format(" where (parentId = {0} and isGroup = 1 and Deleted = 0) or (id = {1}) order by parentKey", row["col2"], rowArray2[0]["col3"]), null, false, 0);
                        }
                        else
                        {
                            base.SelectSqlData(table2, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", row["col2"]), null, false, 0);
                        }
                    }
                    else
                    {
                        base.SelectSqlData(table2, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", row["col2"]), null, false, 0);
                    }
                    DataGridViewComboBoxCell cell2 = this.dgvCharacterDamage[2, num] as DataGridViewComboBoxCell;
                    cell2.DataSource = table2;
                    cell2.DisplayMember = "name";
                    cell2.ValueMember = "id";
                }
                if (row["col3"] != DBNull.Value)
                {
                    this.dgvCharacterDamage.Rows[num].Cells[this.dataGridViewComboBoxColumn_5.Name].Value = row["col3"];
                }
                num++;
            }
        }

        private void method_34()
        {
            DataTable table = this.method_7();
            string str = "";
            if ((this.tJ_DamageCharacterDataTable_0 != null) && (this.tJ_DamageCharacterDataTable_0.Rows.Count > 0))
            {
                foreach (DataRow row in this.tJ_DamageCharacterDataTable_0.Rows)
                {
                    if (string.IsNullOrEmpty(str))
                    {
                        str = row["col1"].ToString();
                    }
                    else
                    {
                        str = str + "," + row["col1"].ToString();
                    }
                }
            }
            if (string.IsNullOrEmpty(str))
            {
                base.SelectSqlData(table, true, "where ParentId in (select id from \r\n                                        tr_classifier where ParentKey = ';ReportDaily;NatureDamage;LV;') \r\n                                        and isGroup = 1 and deleted = 0 order by ParentKey", null, false, 0);
            }
            else
            {
                base.SelectSqlData(table, true, string.Format("where (ParentId in (select id from \r\n                                        tr_classifier where ParentKey = ';ReportDaily;NatureDamage;LV;') \r\n                                        and isGroup = 1 and deleted = 0) or \r\n                                        (id in ({0})) order by ParentKey", str), null, false, 0);
            }
            BindingSource source = new BindingSource
            {
                DataSource = table,
                Position = -1
            };
            this.dataGridViewComboBoxColumn_3.DisplayMember = "name";
            this.dataGridViewComboBoxColumn_3.ValueMember = "id";
            this.dataGridViewComboBoxColumn_3.DataSource = source;
        }

        private void method_35()
        {
            if (!this.get_ViewDocDamageLV() && this.checkBoxApply.Checked)
            {
                this.txtNumRequest.ReadOnly = true;
                this.dtpDateDoc.Enabled = false;
                this.cmbCompiler.ReadOnly = (true);
                this.cmbDivision.ReadOnly = (true);
                this.txtDeclarerTel.ReadOnly = true;
                this.txtDeclarerAddress.ReadOnly = true;
                this.txtDeclarer.ReadOnly = true;
                this.btnChoiceSchmObj.Enabled = false;
                this.cmbStreet.ReadOnly = (true);
                this.cmbCity.ReadOnly = (true);
                this.cmbRaionObl.ReadOnly = (true);
                this.cmbObl.ReadOnly = (true);
                this.txtHousePrefix.ReadOnly = true;
                this.txtHouse.ReadOnly = true;
                this.txtLocation.ReadOnly = true;
                this.cmbReason.ReadOnly = (true);
                this.dgvCharacterDamage.ReadOnly = true;
                this.cmbCompletedWork.ReadOnly = (true);
                this.txtCompletedWork.ReadOnly = true;
                this.checkBoxApply.Enabled = false;
                this.cmbWorkerApply.ReadOnly = (true);
                this.dtpDataApply.Enabled = false;
                this.toolBrnDelAbn.Enabled = false;
                this.toolBtnRefreshAbn.Enabled = false;
            }
        }

        private bool method_36()
        {
            base.SelectSqlData(this.dataSetDamage_1.tJ_Temperature, true, string.Format("where datetemp = '{0}'", Convert.ToDateTime(this.dtpDateDoc.Value).ToString("yyyyMMdd")), null, false, 0);
            if (this.dataSetDamage_1.tJ_Temperature.Rows.Count > 0)
            {
                return true;
            }
            if (MessageBox.Show("На день заявки не введены данные о погоде. Ввести данные?", "Погода", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormTemperatureAddEdit form1 = new FormTemperatureAddEdit(Convert.ToDateTime(this.dtpDateDoc.Value).Date);
                form1.SqlSettings = (this.SqlSettings);
                if (form1.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }
                base.SelectSqlData(this.dataSetDamage_1.tJ_Temperature, true, string.Format("where datetemp = '{0}'", Convert.ToDateTime(this.dtpDateDoc.Value).ToString("yyyyMMdd")), null, false, 0);
                if (this.dataSetDamage_1.tJ_Temperature.Rows.Count > 0)
                {
                    return true;
                }
                MessageBox.Show("Что то пошло не так.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return false;
        }

        private void toolRefreshAbn()
        {
            if ((this.dataSetDamage.tJ_Damage.Rows.Count > 0) && (this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"] != DBNull.Value))
            {
                this.progressBar.Visible = true;
                this.labelProgress.Visible = true;
                this.toolBtnRefreshAbn.Enabled = false;
                this.btnChoiceSchmObj.Enabled = false;
                this.dgvAbn.Enabled = false;
                this.dgvAbn.DataSource = null;
                this.buttonSave.Enabled = false;
                this.buttonClose.Enabled = false;
                this.backgroundWorker_0.RunWorkerAsync(this.dtpDateDoc.Value);
            }
            else
            {
                this.Table1.Clear();
                this.table_vl_SchmAbnFull.Clear();
            }
        }

        private void method_38()
        {
            if (this.dataSetDamage.tJ_Damage.Rows.Count > 0)
            {
                if (this.dataSetDamage.tJ_Damage.Rows[0]["idReqForRepair"] != DBNull.Value)
                {
                    DataTable table = base.SelectSqlData("tj_requestForRepair", true, "where id = " + this.dataSetDamage.tJ_Damage.Rows[0]["idReqForRepair"].ToString());
                    if (table.Rows.Count > 0)
                    {
                        this.txtDocParent.Text = "Аварийная заявка №" + table.Rows[0]["num"].ToString() + " от " + Convert.ToDateTime(table.Rows[0]["dateCreate"]).ToString("dd.MM.yyyy");
                        if (table.Rows[0]["dateFactEnd"] != DBNull.Value)
                        {
                            this.dateTime_0 = Convert.ToDateTime(table.Rows[0]["dateFactEnd"]);
                        }
                        this.string_0 = "";
                        if (table.Rows[0]["schmObj"] != DBNull.Value)
                        {
                            this.string_0 = "Объект: " + table.Rows[0]["schmObj"].ToString();
                        }
                        if (table.Rows[0]["Purpose"] != DBNull.Value)
                        {
                            if (string.IsNullOrEmpty(this.string_0))
                            {
                                this.string_0 = "Цель: " + table.Rows[0]["Purpose"].ToString();
                            }
                            else
                            {
                                this.string_0 = this.string_0 + "\r\nЦель: " + table.Rows[0]["Purpose"].ToString();
                            }
                        }
                        if (table.Rows[0]["AgreeWith"] != DBNull.Value)
                        {
                            if (string.IsNullOrEmpty(this.string_0))
                            {
                                this.string_0 = "Согласовать с: " + table.Rows[0]["AgreeWith"].ToString();
                            }
                            else
                            {
                                this.string_0 = this.string_0 + "\r\nСогласовать с: " + table.Rows[0]["AgreeWith"].ToString();
                            }
                        }
                        if (table.Rows[0]["Comment"] != DBNull.Value)
                        {
                            if (string.IsNullOrEmpty(this.string_0))
                            {
                                this.string_0 = "Комментарий: " + table.Rows[0]["Comment"].ToString();
                            }
                            else
                            {
                                this.string_0 = this.string_0 + "\r\nКомментарий: " + table.Rows[0]["Comment"].ToString();
                            }
                        }
                        this.toolTip_0.ToolTipTitle = this.txtDocParent.Text;
                        this.toolTip_0.SetToolTip(this.txtDocParent, this.string_0);
                        this.toolTip_0.SetToolTip(this.btnRequestForRepair, "Открыть документ");
                    }
                    this.btnChoiceSchmObj.Enabled = false;
                }
                else
                {
                    this.btnRequestForRepair.Enabled = false;
                }
            }
        }

        private void method_39(object sender, GoToSchemaEventArgs e)
        {
            this.OnGoToSchema(e);
        }

        private void method_4()
        {
            if (this.IdDocument > 0)
            {
                dsDamage.tJ_DamageDataTable table = new dsDamage.tJ_DamageDataTable();
                base.SelectSqlData(table, true, string.Format("where idParent = {0} and TypeDoc = {1} and idDivisionApply is not null and isApply = 1 ", this.IdDocument, 1403), null, false, 0);
                if (table.Rows.Count > 0)
                {
                    this.chbDefect.Enabled = false;
                    this.cmbDivisionApply.ReadOnly = (true);
                    this.txtDivisionInstruction.ReadOnly = true;
                }
                base.SelectSqlData(table, true, string.Format("where idParent = {0} and TypeDoc = {1} and isLaboratory is not null and isApply = 1 ", this.IdDocument, 1403), null, false, 0);
                if (table.Rows.Count > 0)
                {
                    this.chbDefect.Enabled = false;
                    this.checkBoxLaboratory.Enabled = false;
                    this.txtLaboratoryInstruction.ReadOnly = true;
                }
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormDamageLVAddEdit));
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            this.tabControl1 = new TabControl();
            this.tabPageGeneral = new TabPage();
            this.splitContainer1 = new SplitContainer();
            this.groupBoxDefectData = new GroupBox();
            this.btnRequestForRepair = new Button();
            this.label2 = new Label();
            this.txtDocParent = new TextBox();
            this.label18 = new Label();
            this.groupBox4 = new GroupBox();
            this.labelObl = new Label();
            this.cmbObl = new ComboBoxReadOnly();
            this.txtHousePrefix = new TextBox();
            this.labelRaionObl = new Label();
            this.cmbRaionObl = new ComboBoxReadOnly();
            this.labelHousePrefix = new Label();
            this.cmbCity = new ComboBoxReadOnly();
            this.labelCity = new Label();
            this.txtHouse = new TextBox();
            this.labelStreet = new Label();
            this.cmbStreet = new ComboBoxReadOnly();
            this.labelHouse = new Label();
            this.txtLocation = new RichTextBox();
            this.dataSetDamage = new dsDamage();
            this.dgvCharacterDamage = new DataGridView();
            this.dataGridViewComboBoxColumn_3 = new DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn_4 = new DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn_5 = new DataGridViewComboBoxColumn();
            this.label1ChatacterDamage = new Label();
            this.labelReason = new Label();
            this.cmbReason = new ComboBoxReadOnly();
            this.btnChoiceSchmObj = new Button();
            this.labelSchmObj = new Label();
            this.txtSchmObj = new TextBox();
            this.groupBoxResult = new GroupBox();
            this.dtpDataApply = new NullableDateTimePicker();
            this.labelDateAplly = new Label();
            this.cmbWorkerApply = new ComboBoxReadOnly();
            this.checkBoxApply = new CheckBox();
            this.txtCompletedWork = new RichTextBox();
            this.labelCompletedWork = new Label();
            this.cmbCompletedWork = new ComboBoxReadOnly();
            this.groupBox5 = new GroupBox();
            this.txtLaboratoryInstruction = new RichTextBox();
            this.labelLaboratoryInstruction = new Label();
            this.txtDivisionInstruction = new RichTextBox();
            this.labelDivisionInstruction = new Label();
            this.chbDefect = new CheckBox();
            this.labelDivisionApply = new Label();
            this.checkBoxLaboratory = new CheckBox();
            this.cmbDivisionApply = new ComboBoxReadOnly();
            this.groupBoxDeclarer = new GroupBox();
            this.label8 = new Label();
            this.txtDeclarerAddress = new TextBox();
            this.txtDeclarerTel = new TextBox();
            this.label_7 = new Label();
            this.txtDeclarer = new TextBox();
            this.cmbDivision = new ComboBoxReadOnly();
            this.label_0 = new Label();
            this.label_1 = new Label();
            this.cmbCompiler = new ComboBoxReadOnly();
            this.dtpDateOwner = new DateTimePicker();
            this.label_2 = new Label();
            this.label_3 = new Label();
            this.txtOwner = new TextBox();
            this.labelDateDoc = new Label();
            this.dtpDateDoc = new NullableDateTimePicker();
            this.labelNumRequest = new Label();
            this.txtNumRequest = new TextBox();
            this.tabPageWeather = new TabPage();
            this.label_20 = new Label();
            this.txtTempComment = new RichTextBox();
            this.dataSetDamage_1 = new dsDamage();
            this.groupBox_3 = new GroupBox();
            this.txtSpeedUp = new TextBox();
            this.txtSpeedDown = new TextBox();
            this.label_21 = new Label();
            this.label_22 = new Label();
            this.cmbWindDirect = new ComboBox();
            this.label_23 = new Label();
            this.label_24 = new Label();
            this.txtTempAverage = new TextBox();
            this.groupBox_4 = new GroupBox();
            this.txtNightUp = new TextBox();
            this.label_25 = new Label();
            this.txtNightDown = new TextBox();
            this.label_26 = new Label();
            this.groupBox_5 = new GroupBox();
            this.txtDayUp = new TextBox();
            this.label_27 = new Label();
            this.txtDayDown = new TextBox();
            this.label_28 = new Label();
            this.tabPagePTS = new TabPage();
            this.txtReasonPTS = new TextBox();
            this.label_29 = new Label();
            this.cmbReasonPTS = new ComboBoxReadOnly();
            this.tabPageAbn = new TabPage();
            this.dgvAbn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.codeAbonentDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nameAbnDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.typeAbnDgvColumn = new DataGridViewFilterComboBoxColumn();
            this.idAbnObjDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nameObjDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.commentODSDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.components);
            this.dataSet_0 = new DataSet();
            this.Table1 = new DataTable();
            this.idSub = new DataColumn();
            this.Sub = new DataColumn();
            this.idTr = new DataColumn();
            this.TrName = new DataColumn();
            this.Power = new DataColumn();
            this.ColumnLoad = new DataColumn();
            this.table_vl_SchmAbnFull = new DataTable();
            this.idAbn = new DataColumn();
            this.codeAbonent = new DataColumn();
            this.nameAbn = new DataColumn();
            this.typeAbn = new DataColumn();
            this.idAbnObj = new DataColumn();
            this.nameObj = new DataColumn();
            this.CommentODS = new DataColumn();
            this.toolStripAbn = new ToolStrip();
            this.toolBtnRefreshAbn = new ToolStripButton();
            this.toolBrnDelAbn = new ToolStripButton();
            this.buttonClose = new Button();
            this.buttonSave = new Button();
            this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn_1 = new DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn_2 = new DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.progressBar = new ProgressBar();
            this.labelProgress = new Label();
            this.backgroundWorker_0 = new BackgroundWorker();
            this.toolTip_0 = new ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxDefectData.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.dataSetDamage.BeginInit();
            ((ISupportInitialize)this.dgvCharacterDamage).BeginInit();
            this.groupBoxResult.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxDeclarer.SuspendLayout();
            this.tabPageWeather.SuspendLayout();
            this.dataSetDamage_1.BeginInit();
            this.groupBox_3.SuspendLayout();
            this.groupBox_4.SuspendLayout();
            this.groupBox_5.SuspendLayout();
            this.tabPagePTS.SuspendLayout();
            this.tabPageAbn.SuspendLayout();
            ((ISupportInitialize)this.dgvAbn).BeginInit();
            ((ISupportInitialize)this.bindingSource_0).BeginInit();
            this.dataSet_0.BeginInit();
            this.Table1.BeginInit();
            this.table_vl_SchmAbnFull.BeginInit();
            this.toolStripAbn.SuspendLayout();
            base.SuspendLayout();
            this.tabControl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageWeather);
            this.tabControl1.Controls.Add(this.tabPagePTS);
            this.tabControl1.Controls.Add(this.tabPageAbn);
            this.tabControl1.Location = new Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(0x420, 0x26d);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabPageGeneral.Controls.Add(this.splitContainer1);
            this.tabPageGeneral.Controls.Add(this.groupBoxDeclarer);
            this.tabPageGeneral.Controls.Add(this.cmbDivision);
            this.tabPageGeneral.Controls.Add(this.label_0);
            this.tabPageGeneral.Controls.Add(this.label_1);
            this.tabPageGeneral.Controls.Add(this.cmbCompiler);
            this.tabPageGeneral.Controls.Add(this.dtpDateOwner);
            this.tabPageGeneral.Controls.Add(this.label_2);
            this.tabPageGeneral.Controls.Add(this.label_3);
            this.tabPageGeneral.Controls.Add(this.txtOwner);
            this.tabPageGeneral.Controls.Add(this.labelDateDoc);
            this.tabPageGeneral.Controls.Add(this.dtpDateDoc);
            this.tabPageGeneral.Controls.Add(this.labelNumRequest);
            this.tabPageGeneral.Controls.Add(this.txtNumRequest);
            this.tabPageGeneral.Location = new Point(4, 0x16);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new Padding(3);
            this.tabPageGeneral.Size = new Size(0x418, 0x253);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Общий";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            this.splitContainer1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.splitContainer1.Location = new Point(0, 0xa6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxDefectData);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxResult);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Size = new Size(0x418, 0x1ad);
            this.splitContainer1.SplitterDistance = 0x1e1;
            this.splitContainer1.TabIndex = 0x13;
            this.groupBoxDefectData.Controls.Add(this.btnRequestForRepair);
            this.groupBoxDefectData.Controls.Add(this.label2);
            this.groupBoxDefectData.Controls.Add(this.txtDocParent);
            this.groupBoxDefectData.Controls.Add(this.label18);
            this.groupBoxDefectData.Controls.Add(this.groupBox4);
            this.groupBoxDefectData.Controls.Add(this.txtLocation);
            this.groupBoxDefectData.Controls.Add(this.dgvCharacterDamage);
            this.groupBoxDefectData.Controls.Add(this.label1ChatacterDamage);
            this.groupBoxDefectData.Controls.Add(this.labelReason);
            this.groupBoxDefectData.Controls.Add(this.cmbReason);
            this.groupBoxDefectData.Controls.Add(this.btnChoiceSchmObj);
            this.groupBoxDefectData.Controls.Add(this.labelSchmObj);
            this.groupBoxDefectData.Controls.Add(this.txtSchmObj);
            this.groupBoxDefectData.Dock = DockStyle.Fill;
            this.groupBoxDefectData.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.groupBoxDefectData.Location = new Point(0, 0);
            this.groupBoxDefectData.Name = "groupBoxDefectData";
            this.groupBoxDefectData.Size = new Size(0x1e1, 0x1ad);
            this.groupBoxDefectData.TabIndex = 13;
            this.groupBoxDefectData.TabStop = false;
            this.groupBoxDefectData.Text = "Исходные данные";
            this.btnRequestForRepair.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.btnRequestForRepair.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.btnRequestForRepair.Location = new Point(0x1bf, 0x13);
            this.btnRequestForRepair.Name = "btnRequestForRepair";
            this.btnRequestForRepair.Size = new Size(0x1b, 20);
            this.btnRequestForRepair.TabIndex = 0x18;
            this.btnRequestForRepair.Text = "...";
            this.btnRequestForRepair.UseVisualStyleBackColor = true;
            this.btnRequestForRepair.Click += new EventHandler(this.btnRequestForRepair_Click);
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label2.Location = new Point(14, 0x1b);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x73, 13);
            this.label2.TabIndex = 0x17;
            this.label2.Text = "Документ-основание";
            this.txtDocParent.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtDocParent.BackColor = SystemColors.Window;
            this.txtDocParent.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtDocParent.Location = new Point(0x92, 20);
            this.txtDocParent.Name = "txtDocParent";
            this.txtDocParent.ReadOnly = true;
            this.txtDocParent.Size = new Size(0x127, 20);
            this.txtDocParent.TabIndex = 0x16;
            this.label18.AutoSize = true;
            this.label18.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label18.Location = new Point(14, 0xcd);
            this.label18.Name = "label18";
            this.label18.Size = new Size(110, 13);
            this.label18.TabIndex = 0x13;
            this.label18.Text = "Место повреждения";
            this.groupBox4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.labelObl);
            this.groupBox4.Controls.Add(this.cmbObl);
            this.groupBox4.Controls.Add(this.txtHousePrefix);
            this.groupBox4.Controls.Add(this.labelRaionObl);
            this.groupBox4.Controls.Add(this.cmbRaionObl);
            this.groupBox4.Controls.Add(this.labelHousePrefix);
            this.groupBox4.Controls.Add(this.cmbCity);
            this.groupBox4.Controls.Add(this.labelCity);
            this.groupBox4.Controls.Add(this.txtHouse);
            this.groupBox4.Controls.Add(this.labelStreet);
            this.groupBox4.Controls.Add(this.cmbStreet);
            this.groupBox4.Controls.Add(this.labelHouse);
            this.groupBox4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.groupBox4.Location = new Point(11, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(0x1d1, 0x66);
            this.groupBox4.TabIndex = 0x12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Адрес";
            this.labelObl.AutoSize = true;
            this.labelObl.Location = new Point(6, 0x10);
            this.labelObl.Name = "labelObl";
            this.labelObl.Size = new Size(50, 13);
            this.labelObl.TabIndex = 2;
            this.labelObl.Text = "Область";
            this.cmbObl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbObl.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbObl.FormattingEnabled = true;
            this.cmbObl.Location = new Point(6, 0x20);
            this.cmbObl.Name = "cmbObl";
            this.cmbObl.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbObl.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbObl.Size = new Size(0xb3, 0x15);
            this.cmbObl.TabIndex = 3;
            this.cmbObl.ValueMember = "tR_KladrObj.Id";
            this.cmbObl.SelectedIndexChanged += new EventHandler(this.cmbObl_SelectedIndexChanged);
            this.txtHousePrefix.BackColor = SystemColors.Window;
            this.txtHousePrefix.Location = new Point(0x160, 0x48);
            this.txtHousePrefix.Name = "txtHousePrefix";
            this.txtHousePrefix.Size = new Size(0x40, 20);
            this.txtHousePrefix.TabIndex = 0x11;
            this.txtHousePrefix.TextChanged += new EventHandler(this.txtHousePrefix_TextChanged);
            this.labelRaionObl.AutoSize = true;
            this.labelRaionObl.Location = new Point(0xcb, 0x10);
            this.labelRaionObl.Name = "labelRaionObl";
            this.labelRaionObl.Size = new Size(0x48, 13);
            this.labelRaionObl.TabIndex = 4;
            this.labelRaionObl.Text = "Район/город";
            this.cmbRaionObl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbRaionObl.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbRaionObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbRaionObl.FormattingEnabled = true;
            this.cmbRaionObl.Location = new Point(0xc3, 0x20);
            this.cmbRaionObl.Name = "cmbRaionObl";
            this.cmbRaionObl.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbRaionObl.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbRaionObl.Size = new Size(0xac, 0x15);
            this.cmbRaionObl.TabIndex = 5;
            this.cmbRaionObl.ValueMember = "tR_KladrObj.Id";
            this.cmbRaionObl.SelectedIndexChanged += new EventHandler(this.cmbRaionObl_SelectedIndexChanged);
            this.labelHousePrefix.AutoSize = true;
            this.labelHousePrefix.Location = new Point(0x15d, 0x38);
            this.labelHousePrefix.Name = "labelHousePrefix";
            this.labelHousePrefix.Size = new Size(0x35, 13);
            this.labelHousePrefix.TabIndex = 0x10;
            this.labelHousePrefix.Text = "Префикс";
            this.cmbCity.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbCity.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new Point(0x175, 0x20);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbCity.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbCity.Size = new Size(0x56, 0x15);
            this.cmbCity.TabIndex = 7;
            this.cmbCity.ValueMember = "tR_KladrObj.Id";
            this.cmbCity.SelectedIndexChanged += new EventHandler(this.cmbCity_SelectedIndexChanged);
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new Point(0x17e, 0x10);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new Size(0x66, 13);
            this.labelCity.TabIndex = 6;
            this.labelCity.Text = "Населенный пункт";
            this.txtHouse.BackColor = SystemColors.Window;
            this.txtHouse.Location = new Point(0x111, 0x48);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new Size(0x3f, 20);
            this.txtHouse.TabIndex = 15;
            this.txtHouse.TextChanged += new EventHandler(this.txtHouse_TextChanged);
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new Point(6, 0x38);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new Size(0x27, 13);
            this.labelStreet.TabIndex = 10;
            this.labelStreet.Text = "Улица";
            this.cmbStreet.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbStreet.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbStreet.DisplayMember = "tR_KladrStreet.NameSocr";
            this.cmbStreet.FormattingEnabled = true;
            this.cmbStreet.Location = new Point(6, 0x48);
            this.cmbStreet.Name = "cmbStreet";
            this.cmbStreet.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbStreet.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbStreet.Size = new Size(0xf4, 0x15);
            this.cmbStreet.TabIndex = 11;
            this.cmbStreet.ValueMember = "tR_KladrStreet.Id";
            this.cmbStreet.SelectedIndexChanged += new EventHandler(this.cmbStreet_SelectedIndexChanged);
            this.labelHouse.AutoSize = true;
            this.labelHouse.Location = new Point(270, 0x38);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new Size(30, 13);
            this.labelHouse.TabIndex = 14;
            this.labelHouse.Text = "Дом";
            this.txtLocation.AcceptsTab = true;
            this.txtLocation.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtLocation.BackColor = SystemColors.Window;
            this.txtLocation.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.DefectLocation", true));
            this.txtLocation.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtLocation.Location = new Point(11, 0xdd);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new Size(0x1cf, 0x2a);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.Text = "";
            this.dataSetDamage.DataSetName = "DataSetDamage";
            this.dataSetDamage.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.dgvCharacterDamage.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dgvCharacterDamage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewComboBoxColumn_3, this.dataGridViewComboBoxColumn_4, this.dataGridViewComboBoxColumn_5 };
            this.dgvCharacterDamage.Columns.AddRange(dataGridViewColumns);
            this.dgvCharacterDamage.EditMode = DataGridViewEditMode.EditOnEnter;
            this.dgvCharacterDamage.Location = new Point(0, 0x120);
            this.dgvCharacterDamage.Name = "dgvCharacterDamage";
            this.dgvCharacterDamage.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dgvCharacterDamage.Size = new Size(0x1e1, 0x87);
            this.dgvCharacterDamage.TabIndex = 7;
            this.dgvCharacterDamage.CurrentCellDirtyStateChanged += new EventHandler(this.dgvCharacterDamage_CurrentCellDirtyStateChanged);
            this.dgvCharacterDamage.DataError += new DataGridViewDataErrorEventHandler(this.dgvCharacterDamage_DataError);
            this.dgvCharacterDamage.MouseClick += new MouseEventHandler(this.dgvCharacterDamage_MouseClick);
            this.dataGridViewComboBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dataGridViewComboBoxColumn_3.DefaultCellStyle = style;
            this.dataGridViewComboBoxColumn_3.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn_3.HeaderText = "Объект";
            this.dataGridViewComboBoxColumn_3.Name = "Column1";
            this.dataGridViewComboBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_3.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewComboBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dataGridViewComboBoxColumn_4.DefaultCellStyle = style2;
            this.dataGridViewComboBoxColumn_4.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn_4.HeaderText = "Повреждение";
            this.dataGridViewComboBoxColumn_4.Name = "Column2";
            this.dataGridViewComboBoxColumn_4.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_4.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dataGridViewComboBoxColumn_5.DefaultCellStyle = style3;
            this.dataGridViewComboBoxColumn_5.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn_5.HeaderText = "Уточнение";
            this.dataGridViewComboBoxColumn_5.Name = "Column3";
            this.dataGridViewComboBoxColumn_5.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_5.SortMode = DataGridViewColumnSortMode.Automatic;
            this.label1ChatacterDamage.AutoSize = true;
            this.label1ChatacterDamage.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label1ChatacterDamage.Location = new Point(14, 0x109);
            this.label1ChatacterDamage.Name = "label1ChatacterDamage";
            this.label1ChatacterDamage.Size = new Size(0x7e, 13);
            this.label1ChatacterDamage.TabIndex = 6;
            this.label1ChatacterDamage.Text = "Характер повреждения";
            this.labelReason.AutoSize = true;
            this.labelReason.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.labelReason.Location = new Point(14, 0x4e);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new Size(0x56, 13);
            this.labelReason.TabIndex = 4;
            this.labelReason.Text = "Неисправность";
            this.cmbReason.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbReason.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbReason.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbReason.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idReason", true));
            this.cmbReason.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new Point(0x6a, 0x4b);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbReason.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbReason.Size = new Size(0x170, 0x15);
            this.cmbReason.TabIndex = 5;
            this.cmbReason.SelectedIndexChanged += new EventHandler(this.cmbReason_SelectedIndexChanged);
            this.btnChoiceSchmObj.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.btnChoiceSchmObj.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.btnChoiceSchmObj.Location = new Point(0x1bf, 0x2f);
            this.btnChoiceSchmObj.Name = "btnChoiceSchmObj";
            this.btnChoiceSchmObj.Size = new Size(0x1b, 20);
            this.btnChoiceSchmObj.TabIndex = 2;
            this.btnChoiceSchmObj.Text = "...";
            this.btnChoiceSchmObj.UseVisualStyleBackColor = true;
            this.btnChoiceSchmObj.Click += new EventHandler(this.btnChoiceSchmObj_Click);
            this.labelSchmObj.AutoSize = true;
            this.labelSchmObj.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.labelSchmObj.Location = new Point(14, 50);
            this.labelSchmObj.Name = "labelSchmObj";
            this.labelSchmObj.Size = new Size(0x6c, 13);
            this.labelSchmObj.TabIndex = 1;
            this.labelSchmObj.Text = @"Подстанция\ячейка";
            this.txtSchmObj.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtSchmObj.BackColor = SystemColors.Window;
            this.txtSchmObj.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtSchmObj.Location = new Point(0x92, 0x2f);
            this.txtSchmObj.Name = "txtSchmObj";
            this.txtSchmObj.ReadOnly = true;
            this.txtSchmObj.Size = new Size(0x127, 20);
            this.txtSchmObj.TabIndex = 0;
            this.txtSchmObj.TextChanged += new EventHandler(this.txtSchmObj_TextChanged);
            this.groupBoxResult.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.groupBoxResult.Controls.Add(this.dtpDataApply);
            this.groupBoxResult.Controls.Add(this.labelDateAplly);
            this.groupBoxResult.Controls.Add(this.cmbWorkerApply);
            this.groupBoxResult.Controls.Add(this.checkBoxApply);
            this.groupBoxResult.Controls.Add(this.txtCompletedWork);
            this.groupBoxResult.Controls.Add(this.labelCompletedWork);
            this.groupBoxResult.Controls.Add(this.cmbCompletedWork);
            this.groupBoxResult.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.groupBoxResult.Location = new Point(3, 0);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new Size(0x227, 0xc9);
            this.groupBoxResult.TabIndex = 14;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат (принятые меры)";
            this.dtpDataApply.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.dtpDataApply.CustomFormat = ("dd.MM.yyyy HH:mm");
            this.dtpDataApply.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateApply", true, DataSourceUpdateMode.OnPropertyChanged));
            this.dtpDataApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dtpDataApply.Format = (DateTimePickerFormat.Custom);
            this.dtpDataApply.Location = new Point(0x19f, 0xa9);
            this.dtpDataApply.Name = "dtpDataApply";
            this.dtpDataApply.Size = new Size(0x80, 20);
            this.dtpDataApply.TabIndex = 6;
            this.dtpDataApply.Value = (new DateTime(0x7df, 8, 6, 10, 0, 0x35, 2));
            this.dtpDataApply.ValueChanged += new EventHandler(this.dtpDataApply_ValueChanged);
            this.labelDateAplly.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.labelDateAplly.AutoSize = true;
            this.labelDateAplly.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.labelDateAplly.Location = new Point(0x14c, 0xaf);
            this.labelDateAplly.Name = "labelDateAplly";
            this.labelDateAplly.Size = new Size(0x4d, 13);
            this.labelDateAplly.TabIndex = 5;
            this.labelDateAplly.Text = "Дата и время";
            this.cmbWorkerApply.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.cmbWorkerApply.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbWorkerApply.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbWorkerApply.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idWorkerApply", true));
            this.cmbWorkerApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbWorkerApply.FormattingEnabled = true;
            this.cmbWorkerApply.Location = new Point(130, 170);
            this.cmbWorkerApply.Name = "cmbWorkerApply";
            this.cmbWorkerApply.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbWorkerApply.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbWorkerApply.Size = new Size(0xc4, 0x15);
            this.cmbWorkerApply.TabIndex = 4;
            this.cmbWorkerApply.SelectedIndexChanged += new EventHandler(this.cmbWorkerApply_SelectedIndexChanged);
            this.checkBoxApply.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.checkBoxApply.AutoSize = true;
            this.checkBoxApply.DataBindings.Add(new Binding("Checked", this.dataSetDamage, "tJ_Damage.isApply", true, DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.checkBoxApply.Location = new Point(13, 0xae);
            this.checkBoxApply.Name = "checkBoxApply";
            this.checkBoxApply.Size = new Size(0x52, 0x11);
            this.checkBoxApply.TabIndex = 3;
            this.checkBoxApply.Text = "Исполнено";
            this.checkBoxApply.UseVisualStyleBackColor = true;
            this.checkBoxApply.CheckedChanged += new EventHandler(this.checkBoxApply_CheckedChanged);
            this.txtCompletedWork.AcceptsTab = true;
            this.txtCompletedWork.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.txtCompletedWork.BackColor = SystemColors.Window;
            this.txtCompletedWork.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.ComletedWorkText", true));
            this.txtCompletedWork.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtCompletedWork.Location = new Point(9, 0x2f);
            this.txtCompletedWork.Name = "txtCompletedWork";
            this.txtCompletedWork.Size = new Size(0x218, 0x79);
            this.txtCompletedWork.TabIndex = 2;
            this.txtCompletedWork.Text = "";
            this.txtCompletedWork.TextChanged += new EventHandler(this.txtHousePrefix_TextChanged);
            this.labelCompletedWork.AutoSize = true;
            this.labelCompletedWork.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.labelCompletedWork.Location = new Point(10, 0x16);
            this.labelCompletedWork.Name = "labelCompletedWork";
            this.labelCompletedWork.Size = new Size(0x72, 13);
            this.labelCompletedWork.TabIndex = 1;
            this.labelCompletedWork.Text = "Выполненная работа";
            this.cmbCompletedWork.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbCompletedWork.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idCompletedWork", true));
            this.cmbCompletedWork.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbCompletedWork.FormattingEnabled = true;
            this.cmbCompletedWork.Location = new Point(130, 0x13);
            this.cmbCompletedWork.Name = "cmbCompletedWork";
            this.cmbCompletedWork.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbCompletedWork.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbCompletedWork.Size = new Size(0x19f, 0x15);
            this.cmbCompletedWork.TabIndex = 0;
            this.cmbCompletedWork.SelectedIndexChanged += new EventHandler(this.cmbCompletedWork_SelectedIndexChanged);
            this.groupBox5.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.groupBox5.Controls.Add(this.txtLaboratoryInstruction);
            this.groupBox5.Controls.Add(this.labelLaboratoryInstruction);
            this.groupBox5.Controls.Add(this.txtDivisionInstruction);
            this.groupBox5.Controls.Add(this.labelDivisionInstruction);
            this.groupBox5.Controls.Add(this.chbDefect);
            this.groupBox5.Controls.Add(this.labelDivisionApply);
            this.groupBox5.Controls.Add(this.checkBoxLaboratory);
            this.groupBox5.Controls.Add(this.cmbDivisionApply);
            this.groupBox5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.groupBox5.Location = new Point(3, 0xcc);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new Size(0x227, 0xd7);
            this.groupBox5.TabIndex = 0x12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Журнал дефектов";
            this.txtLaboratoryInstruction.AcceptsTab = true;
            this.txtLaboratoryInstruction.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtLaboratoryInstruction.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.LaboratoryInstruction", true));
            this.txtLaboratoryInstruction.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtLaboratoryInstruction.Location = new Point(0x51, 0x91);
            this.txtLaboratoryInstruction.Name = "txtLaboratoryInstruction";
            this.txtLaboratoryInstruction.Size = new Size(0x1d0, 0x3a);
            this.txtLaboratoryInstruction.TabIndex = 0x16;
            this.txtLaboratoryInstruction.Text = "";
            this.txtLaboratoryInstruction.Visible = false;
            this.txtLaboratoryInstruction.TextChanged += new EventHandler(this.txtHousePrefix_TextChanged);
            this.labelLaboratoryInstruction.AutoSize = true;
            this.labelLaboratoryInstruction.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.labelLaboratoryInstruction.Location = new Point(6, 0x91);
            this.labelLaboratoryInstruction.Name = "labelLaboratoryInstruction";
            this.labelLaboratoryInstruction.Size = new Size(0x39, 13);
            this.labelLaboratoryInstruction.TabIndex = 0x15;
            this.labelLaboratoryInstruction.Text = "Указания";
            this.labelLaboratoryInstruction.Visible = false;
            this.txtDivisionInstruction.AcceptsTab = true;
            this.txtDivisionInstruction.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtDivisionInstruction.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.DivisionInstruction", true));
            this.txtDivisionInstruction.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtDivisionInstruction.Location = new Point(0x51, 0x3d);
            this.txtDivisionInstruction.Name = "txtDivisionInstruction";
            this.txtDivisionInstruction.Size = new Size(0x1d0, 0x3a);
            this.txtDivisionInstruction.TabIndex = 20;
            this.txtDivisionInstruction.Text = "";
            this.txtDivisionInstruction.Visible = false;
            this.txtDivisionInstruction.TextChanged += new EventHandler(this.txtHousePrefix_TextChanged);
            this.labelDivisionInstruction.AutoSize = true;
            this.labelDivisionInstruction.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.labelDivisionInstruction.Location = new Point(6, 0x3d);
            this.labelDivisionInstruction.Name = "labelDivisionInstruction";
            this.labelDivisionInstruction.Size = new Size(0x39, 13);
            this.labelDivisionInstruction.TabIndex = 0x13;
            this.labelDivisionInstruction.Text = "Указания";
            this.labelDivisionInstruction.Visible = false;
            this.chbDefect.AutoSize = true;
            this.chbDefect.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.chbDefect.Location = new Point(6, 0x19);
            this.chbDefect.Name = "chbDefect";
            this.chbDefect.Size = new Size(0x42, 0x11);
            this.chbDefect.TabIndex = 0x12;
            this.chbDefect.Text = "Дефект";
            this.chbDefect.UseVisualStyleBackColor = true;
            this.chbDefect.CheckedChanged += new EventHandler(this.chbDefect_CheckedChanged);
            this.labelDivisionApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.labelDivisionApply.Location = new Point(0x4e, 0x13);
            this.labelDivisionApply.Name = "labelDivisionApply";
            this.labelDivisionApply.Size = new Size(0x60, 0x1b);
            this.labelDivisionApply.TabIndex = 15;
            this.labelDivisionApply.Text = "Подразделение исполнитель";
            this.labelDivisionApply.Visible = false;
            this.checkBoxLaboratory.AutoSize = true;
            this.checkBoxLaboratory.DataBindings.Add(new Binding("Checked", this.dataSetDamage, "tJ_Damage.isLaboratory", true, DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxLaboratory.Enabled = false;
            this.checkBoxLaboratory.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.checkBoxLaboratory.Location = new Point(6, 0x7d);
            this.checkBoxLaboratory.Name = "checkBoxLaboratory";
            this.checkBoxLaboratory.Size = new Size(0xbf, 0x11);
            this.checkBoxLaboratory.TabIndex = 0x11;
            this.checkBoxLaboratory.Text = "Производственная лаборатория";
            this.checkBoxLaboratory.UseVisualStyleBackColor = true;
            this.checkBoxLaboratory.Visible = false;
            this.checkBoxLaboratory.CheckedChanged += new EventHandler(this.checkBoxLaboratory_CheckedChanged);
            this.cmbDivisionApply.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbDivisionApply.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbDivisionApply.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbDivisionApply.BackColor = SystemColors.Control;
            this.cmbDivisionApply.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idDivisionApply", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cmbDivisionApply.DropDownStyle = (ComboBoxStyle.DropDownList);
            this.cmbDivisionApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbDivisionApply.ForeColor = SystemColors.WindowText;
            this.cmbDivisionApply.FormattingEnabled = true;
            this.cmbDivisionApply.Location = new Point(180, 0x15);
            this.cmbDivisionApply.Name = "cmbDivisionApply";
            this.cmbDivisionApply.ReadOnly = (true);
            this.cmbDivisionApply.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbDivisionApply.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbDivisionApply.Size = new Size(0x16d, 0x15);
            this.cmbDivisionApply.TabIndex = 0x10;
            this.cmbDivisionApply.TabStop = false;
            this.cmbDivisionApply.Visible = (false);
            this.cmbDivisionApply.SelectedIndexChanged += new EventHandler(this.cmbDivisionApply_SelectedIndexChanged);
            this.cmbDivisionApply.KeyDown += new KeyEventHandler(this.cmbDivisionApply_KeyDown);
            this.groupBoxDeclarer.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBoxDeclarer.Controls.Add(this.label8);
            this.groupBoxDeclarer.Controls.Add(this.txtDeclarerAddress);
            this.groupBoxDeclarer.Controls.Add(this.txtDeclarerTel);
            this.groupBoxDeclarer.Controls.Add(this.label_7);
            this.groupBoxDeclarer.Controls.Add(this.txtDeclarer);
            this.groupBoxDeclarer.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.groupBoxDeclarer.Location = new Point(11, 0x55);
            this.groupBoxDeclarer.Name = "groupBoxDeclarer";
            this.groupBoxDeclarer.Size = new Size(0x403, 0x4b);
            this.groupBoxDeclarer.TabIndex = 12;
            this.groupBoxDeclarer.TabStop = false;
            this.groupBoxDeclarer.Text = "Заявитель";
            this.label8.AutoSize = true;
            this.label8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label8.Location = new Point(6, 0x30);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x5e, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Адрес заявителя";
            this.txtDeclarerAddress.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtDeclarerAddress.BackColor = SystemColors.Window;
            this.txtDeclarerAddress.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageLV.DeclarerAddress", true));
            this.txtDeclarerAddress.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtDeclarerAddress.Location = new Point(0x6a, 0x2d);
            this.txtDeclarerAddress.Name = "txtDeclarerAddress";
            this.txtDeclarerAddress.Size = new Size(0x393, 20);
            this.txtDeclarerAddress.TabIndex = 3;
            this.txtDeclarerAddress.TextChanged += new EventHandler(this.txtHousePrefix_TextChanged);
            this.txtDeclarerTel.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtDeclarerTel.BackColor = SystemColors.Window;
            this.txtDeclarerTel.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageLV.DeclarerTel", true));
            this.txtDeclarerTel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtDeclarerTel.Location = new Point(0x14c, 0x13);
            this.txtDeclarerTel.Name = "txtDeclarerTel";
            this.txtDeclarerTel.Size = new Size(0x2b1, 20);
            this.txtDeclarerTel.TabIndex = 2;
            this.txtDeclarerTel.TextChanged += new EventHandler(this.txtHousePrefix_TextChanged);
            this.txtDeclarerTel.KeyPress += new KeyPressEventHandler(this.txtDeclarerTel_KeyPress);
            this.label_7.AutoSize = true;
            this.label_7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_7.Location = new Point(0x112, 0x16);
            this.label_7.Name = "label7";
            this.label_7.Size = new Size(0x34, 13);
            this.label_7.TabIndex = 1;
            this.label_7.Text = "Телефон";
            this.txtDeclarer.BackColor = SystemColors.Window;
            this.txtDeclarer.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageLV.Declarer", true));
            this.txtDeclarer.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtDeclarer.Location = new Point(6, 0x13);
            this.txtDeclarer.Name = "txtDeclarer";
            this.txtDeclarer.Size = new Size(0x106, 20);
            this.txtDeclarer.TabIndex = 0;
            this.txtDeclarer.TextChanged += new EventHandler(this.txtHousePrefix_TextChanged);
            this.cmbDivision.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbDivision.BackColor = SystemColors.Control;
            this.cmbDivision.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idDivision", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cmbDivision.ForeColor = SystemColors.WindowText;
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new Point(0x184, 0x3b);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.ReadOnly = (true);
            this.cmbDivision.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbDivision.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbDivision.Size = new Size(650, 0x15);
            this.cmbDivision.TabIndex = 11;
            this.cmbDivision.TabStop = false;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(0x127, 0x42);
            this.label_0.Name = "label6";
            this.label_0.Size = new Size(0x57, 13);
            this.label_0.TabIndex = 10;
            this.label_0.Text = "Подразделение";
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(8, 0x42);
            this.label_1.Name = "labelCompiler";
            this.label_1.Size = new Size(0x48, 13);
            this.label_1.TabIndex = 9;
            this.label_1.Text = "Составитель";
            this.cmbCompiler.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbCompiler.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbCompiler.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idCompiler", true));
            this.cmbCompiler.FormattingEnabled = true;
            this.cmbCompiler.Location = new Point(0x5e, 0x3a);
            this.cmbCompiler.Name = "cmbCompiler";
            this.cmbCompiler.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbCompiler.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbCompiler.Size = new Size(0xb9, 0x15);
            this.cmbCompiler.TabIndex = 8;
            this.cmbCompiler.SelectedValueChanged += new EventHandler(this.cmbCompiler_SelectedValueChanged);
            this.dtpDateOwner.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dtpDateOwner.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateOwner.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateOwner", true));
            this.dtpDateOwner.Enabled = false;
            this.dtpDateOwner.Format = DateTimePickerFormat.Custom;
            this.dtpDateOwner.Location = new Point(0x163, 0x21);
            this.dtpDateOwner.Name = "dtpDateOwner";
            this.dtpDateOwner.Size = new Size(0x2ab, 20);
            this.dtpDateOwner.TabIndex = 7;
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(0xe9, 0x27);
            this.label_2.Name = "label4";
            this.label_2.Size = new Size(0x54, 13);
            this.label_2.TabIndex = 6;
            this.label_2.Text = "Дата создания";
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(8, 0x27);
            this.label_3.Name = "label3";
            this.label_3.Size = new Size(0x4c, 13);
            this.label_3.TabIndex = 5;
            this.label_3.Text = "Автор заявки";
            this.txtOwner.Location = new Point(0x5e, 0x20);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new Size(0x85, 20);
            this.txtOwner.TabIndex = 4;
            this.labelDateDoc.AutoSize = true;
            this.labelDateDoc.Location = new Point(0xe9, 13);
            this.labelDateDoc.Name = "labelDateDoc";
            this.labelDateDoc.Size = new Size(0x74, 13);
            this.labelDateDoc.TabIndex = 3;
            this.labelDateDoc.Text = "Дата и время заявки";
            this.dtpDateDoc.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dtpDateDoc.CustomFormat = ("dd.MM.yyyy HH:mm");
            this.dtpDateDoc.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateDoc", true, DataSourceUpdateMode.OnPropertyChanged));
            this.dtpDateDoc.Format = (DateTimePickerFormat.Custom);
            this.dtpDateDoc.Location = new Point(0x163, 7);
            this.dtpDateDoc.Name = "dtpDateDoc";
            this.dtpDateDoc.Size = new Size(0x2ab, 20);
            this.dtpDateDoc.TabIndex = 2;
            this.dtpDateDoc.Value = (new DateTime(0x7df, 10, 14, 9, 0x35, 30, 0x1f1));
            this.dtpDateDoc.ValueChanged += new EventHandler(this.dtpDateDoc_ValueChanged);
            this.labelNumRequest.AutoSize = true;
            this.labelNumRequest.Location = new Point(8, 13);
            this.labelNumRequest.Name = "labelNumRequest";
            this.labelNumRequest.Size = new Size(80, 13);
            this.labelNumRequest.TabIndex = 1;
            this.labelNumRequest.Text = "Номер заявки";
            this.txtNumRequest.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.NumRequest", true));
            this.txtNumRequest.Location = new Point(0x5e, 6);
            this.txtNumRequest.Name = "txtNumRequest";
            this.txtNumRequest.Size = new Size(0x85, 20);
            this.txtNumRequest.TabIndex = 0;
            this.txtNumRequest.TextChanged += new EventHandler(this.txtNumRequest_TextChanged);
            this.tabPageWeather.Controls.Add(this.label_20);
            this.tabPageWeather.Controls.Add(this.txtTempComment);
            this.tabPageWeather.Controls.Add(this.groupBox_3);
            this.tabPageWeather.Controls.Add(this.label_24);
            this.tabPageWeather.Controls.Add(this.txtTempAverage);
            this.tabPageWeather.Controls.Add(this.groupBox_4);
            this.tabPageWeather.Controls.Add(this.groupBox_5);
            this.tabPageWeather.Location = new Point(4, 0x16);
            this.tabPageWeather.Name = "tabPageWeather";
            this.tabPageWeather.Padding = new Padding(3);
            this.tabPageWeather.Size = new Size(0x418, 0x253);
            this.tabPageWeather.TabIndex = 1;
            this.tabPageWeather.Text = "Погода";
            this.tabPageWeather.UseVisualStyleBackColor = true;
            this.label_20.AutoSize = true;
            this.label_20.Location = new Point(14, 0xf4);
            this.label_20.Name = "label10";
            this.label_20.Size = new Size(70, 13);
            this.label_20.TabIndex = 0x13;
            this.label_20.Text = "Примечание";
            this.txtTempComment.AcceptsTab = true;
            this.txtTempComment.BackColor = SystemColors.Window;
            this.txtTempComment.DataBindings.Add(new Binding("Text", this.dataSetDamage_1, "tJ_Temperature.Comment", true));
            this.txtTempComment.Location = new Point(8, 260);
            this.txtTempComment.Name = "txtTempComment";
            this.txtTempComment.ReadOnly = true;
            this.txtTempComment.Size = new Size(0x10f, 0x52);
            this.txtTempComment.TabIndex = 20;
            this.txtTempComment.Text = "";
            this.dataSetDamage_1.DataSetName = "DataSetDamage";
            this.dataSetDamage_1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.groupBox_3.Controls.Add(this.txtSpeedUp);
            this.groupBox_3.Controls.Add(this.txtSpeedDown);
            this.groupBox_3.Controls.Add(this.label_21);
            this.groupBox_3.Controls.Add(this.label_22);
            this.groupBox_3.Controls.Add(this.cmbWindDirect);
            this.groupBox_3.Controls.Add(this.label_23);
            this.groupBox_3.Location = new Point(8, 0x90);
            this.groupBox_3.Name = "groupBox3";
            this.groupBox_3.Size = new Size(0x10f, 0x61);
            this.groupBox_3.TabIndex = 0x12;
            this.groupBox_3.TabStop = false;
            this.groupBox_3.Text = "Ветер";
            this.txtSpeedUp.BackColor = SystemColors.Window;
            this.txtSpeedUp.DataBindings.Add(new Binding("Text", this.dataSetDamage_1, "tJ_Temperature.SpeedUp", true));
            this.txtSpeedUp.Location = new Point(0x91, 0x41);
            this.txtSpeedUp.Name = "txtSpeedUp";
            this.txtSpeedUp.ReadOnly = true;
            this.txtSpeedUp.Size = new Size(120, 20);
            this.txtSpeedUp.TabIndex = 5;
            this.txtSpeedDown.BackColor = SystemColors.Window;
            this.txtSpeedDown.DataBindings.Add(new Binding("Text", this.dataSetDamage_1, "tJ_Temperature.SpeedDown", true));
            this.txtSpeedDown.Location = new Point(9, 0x41);
            this.txtSpeedDown.Name = "txtSpeedDown";
            this.txtSpeedDown.ReadOnly = true;
            this.txtSpeedDown.Size = new Size(120, 20);
            this.txtSpeedDown.TabIndex = 4;
            this.label_21.AutoSize = true;
            this.label_21.Location = new Point(0x8e, 0x31);
            this.label_21.Name = "label9";
            this.label_21.Size = new Size(0x62, 13);
            this.label_21.TabIndex = 3;
            this.label_21.Text = "Скорость до (м/с)";
            this.label_22.AutoSize = true;
            this.label_22.Location = new Point(6, 0x31);
            this.label_22.Name = "label5";
            this.label_22.Size = new Size(0x61, 13);
            this.label_22.TabIndex = 2;
            this.label_22.Text = "Скорость от (м/с)";
            this.cmbWindDirect.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbWindDirect.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbWindDirect.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage_1, "tJ_Temperature.Wind", true));
            this.cmbWindDirect.DropDownStyle = ComboBoxStyle.Simple;
            this.cmbWindDirect.Enabled = false;
            this.cmbWindDirect.FormattingEnabled = true;
            this.cmbWindDirect.Location = new Point(0x57, 0x13);
            this.cmbWindDirect.Name = "cmbWindDirect";
            this.cmbWindDirect.Size = new Size(0xb2, 0x15);
            this.cmbWindDirect.TabIndex = 1;
            this.label_23.AutoSize = true;
            this.label_23.Location = new Point(6, 0x16);
            this.label_23.Name = "label11";
            this.label_23.Size = new Size(0x4b, 13);
            this.label_23.TabIndex = 0;
            this.label_23.Text = "Направление";
            this.label_24.AutoSize = true;
            this.label_24.Location = new Point(5, 120);
            this.label_24.Name = "label12";
            this.label_24.Size = new Size(0x9d, 13);
            this.label_24.TabIndex = 0x11;
            this.label_24.Text = "Среднесуточная температура";
            this.txtTempAverage.BackColor = SystemColors.Window;
            this.txtTempAverage.DataBindings.Add(new Binding("Text", this.dataSetDamage_1, "tJ_Temperature.TempAverage", true));
            this.txtTempAverage.Location = new Point(0xab, 0x76);
            this.txtTempAverage.Name = "txtTempAverage";
            this.txtTempAverage.ReadOnly = true;
            this.txtTempAverage.Size = new Size(0x6c, 20);
            this.txtTempAverage.TabIndex = 0x10;
            this.groupBox_4.Controls.Add(this.txtNightUp);
            this.groupBox_4.Controls.Add(this.label_25);
            this.groupBox_4.Controls.Add(this.txtNightDown);
            this.groupBox_4.Controls.Add(this.label_26);
            this.groupBox_4.Location = new Point(8, 6);
            this.groupBox_4.Name = "groupBox1";
            this.groupBox_4.Size = new Size(0x10f, 50);
            this.groupBox_4.TabIndex = 14;
            this.groupBox_4.TabStop = false;
            this.groupBox_4.Text = "Температура ночью";
            this.txtNightUp.BackColor = SystemColors.Window;
            this.txtNightUp.DataBindings.Add(new Binding("Text", this.dataSetDamage_1, "tJ_Temperature.NightUp", true));
            this.txtNightUp.Location = new Point(0xa3, 0x13);
            this.txtNightUp.Name = "txtNightUp";
            this.txtNightUp.ReadOnly = true;
            this.txtNightUp.Size = new Size(0x66, 20);
            this.txtNightUp.TabIndex = 3;
            this.label_25.AutoSize = true;
            this.label_25.Location = new Point(0x89, 0x19);
            this.label_25.Name = "label13";
            this.label_25.Size = new Size(0x16, 13);
            this.label_25.TabIndex = 2;
            this.label_25.Text = "До";
            this.txtNightDown.BackColor = SystemColors.Window;
            this.txtNightDown.DataBindings.Add(new Binding("Text", this.dataSetDamage_1, "tJ_Temperature.NightDown", true));
            this.txtNightDown.Location = new Point(0x20, 0x13);
            this.txtNightDown.Name = "txtNightDown";
            this.txtNightDown.ReadOnly = true;
            this.txtNightDown.Size = new Size(0x63, 20);
            this.txtNightDown.TabIndex = 1;
            this.label_26.AutoSize = true;
            this.label_26.Location = new Point(6, 0x19);
            this.label_26.Name = "label15";
            this.label_26.Size = new Size(20, 13);
            this.label_26.TabIndex = 0;
            this.label_26.Text = "От";
            this.groupBox_5.Controls.Add(this.txtDayUp);
            this.groupBox_5.Controls.Add(this.label_27);
            this.groupBox_5.Controls.Add(this.txtDayDown);
            this.groupBox_5.Controls.Add(this.label_28);
            this.groupBox_5.Location = new Point(8, 0x3e);
            this.groupBox_5.Name = "groupBox2";
            this.groupBox_5.Size = new Size(0x10f, 50);
            this.groupBox_5.TabIndex = 15;
            this.groupBox_5.TabStop = false;
            this.groupBox_5.Text = "Температура днем";
            this.txtDayUp.BackColor = SystemColors.Window;
            this.txtDayUp.DataBindings.Add(new Binding("Text", this.dataSetDamage_1, "tJ_Temperature.DayUp", true));
            this.txtDayUp.Location = new Point(0xa3, 0x13);
            this.txtDayUp.Name = "txtDayUp";
            this.txtDayUp.ReadOnly = true;
            this.txtDayUp.Size = new Size(0x66, 20);
            this.txtDayUp.TabIndex = 3;
            this.label_27.AutoSize = true;
            this.label_27.Location = new Point(0x89, 0x19);
            this.label_27.Name = "label1";
            this.label_27.Size = new Size(0x16, 13);
            this.label_27.TabIndex = 2;
            this.label_27.Text = "До";
            this.txtDayDown.BackColor = SystemColors.Window;
            this.txtDayDown.DataBindings.Add(new Binding("Text", this.dataSetDamage_1, "tJ_Temperature.DayDown", true));
            this.txtDayDown.Location = new Point(0x20, 0x13);
            this.txtDayDown.Name = "txtDayDown";
            this.txtDayDown.ReadOnly = true;
            this.txtDayDown.Size = new Size(0x63, 20);
            this.txtDayDown.TabIndex = 1;
            this.label_28.AutoSize = true;
            this.label_28.Location = new Point(6, 0x19);
            this.label_28.Name = "label17";
            this.label_28.Size = new Size(20, 13);
            this.label_28.TabIndex = 0;
            this.label_28.Text = "От";
            this.tabPagePTS.Controls.Add(this.txtReasonPTS);
            this.tabPagePTS.Controls.Add(this.label_29);
            this.tabPagePTS.Controls.Add(this.cmbReasonPTS);
            this.tabPagePTS.Location = new Point(4, 0x16);
            this.tabPagePTS.Name = "tabPagePTS";
            this.tabPagePTS.Padding = new Padding(3);
            this.tabPagePTS.Size = new Size(0x418, 0x253);
            this.tabPagePTS.TabIndex = 2;
            this.tabPagePTS.Text = "ПТС";
            this.tabPagePTS.UseVisualStyleBackColor = true;
            this.txtReasonPTS.Location = new Point(0x18e, 0x1c);
            this.txtReasonPTS.Name = "txtReasonPTS";
            this.txtReasonPTS.ReadOnly = true;
            this.txtReasonPTS.Size = new Size(100, 20);
            this.txtReasonPTS.TabIndex = 2;
            this.label_29.AutoSize = true;
            this.label_29.Location = new Point(8, 12);
            this.label_29.Name = "label16";
            this.label_29.Size = new Size(0x61, 13);
            this.label_29.TabIndex = 1;
            this.label_29.Text = "Код повреждения";
            this.cmbReasonPTS.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbReasonPTS.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbReasonPTS.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idReasonPTS", true));
            this.cmbReasonPTS.FormattingEnabled = true;
            this.cmbReasonPTS.Location = new Point(11, 0x1c);
            this.cmbReasonPTS.Name = "cmbReasonPTS";
            this.cmbReasonPTS.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbReasonPTS.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbReasonPTS.Size = new Size(0x17d, 0x15);
            this.cmbReasonPTS.TabIndex = 0;
            this.cmbReasonPTS.SelectedIndexChanged += new EventHandler(this.cmbReasonPTS_SelectedIndexChanged);
            this.tabPageAbn.Controls.Add(this.dgvAbn);
            this.tabPageAbn.Controls.Add(this.toolStripAbn);
            this.tabPageAbn.Location = new Point(4, 0x16);
            this.tabPageAbn.Name = "tabPageAbn";
            this.tabPageAbn.Padding = new Padding(3);
            this.tabPageAbn.Size = new Size(0x418, 0x253);
            this.tabPageAbn.TabIndex = 3;
            this.tabPageAbn.Text = "Отключенные абоненты";
            this.tabPageAbn.UseVisualStyleBackColor = true;
            this.dgvAbn.AllowUserToAddRows = false;
            this.dgvAbn.AllowUserToDeleteRows = false;
            this.dgvAbn.AllowUserToOrderColumns = true;
            style4.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dgvAbn.AlternatingRowsDefaultCellStyle = style4;
            this.dgvAbn.AutoGenerateColumns = false;
            this.dgvAbn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.codeAbonentDataGridViewTextBoxColumn, this.idAbnDataGridViewTextBoxColumn, this.nameAbnDataGridViewTextBoxColumn, this.typeAbnDgvColumn, this.idAbnObjDataGridViewTextBoxColumn, this.nameObjDataGridViewTextBoxColumn, this.commentODSDgvColumn };
            this.dgvAbn.Columns.AddRange(columnArray2);
            this.dgvAbn.DataSource = this.bindingSource_0;
            this.dgvAbn.Dock = DockStyle.Fill;
            this.dgvAbn.Location = new Point(3, 0x1c);
            this.dgvAbn.Name = "dgvAbn";
            this.dgvAbn.ReadOnly = true;
            this.dgvAbn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbn.Size = new Size(0x412, 0x234);
            this.dgvAbn.TabIndex = 7;
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "codeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            this.nameAbnDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.nameAbnDataGridViewTextBoxColumn.DataPropertyName = "nameAbn";
            this.nameAbnDataGridViewTextBoxColumn.FillWeight = 88.31693f;
            this.nameAbnDataGridViewTextBoxColumn.HeaderText = "Абонент";
            this.nameAbnDataGridViewTextBoxColumn.Name = "nameAbnDataGridViewTextBoxColumn";
            this.nameAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameAbnDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.typeAbnDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.typeAbnDgvColumn.DataPropertyName = "typeAbn";
            this.typeAbnDgvColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeAbnDgvColumn.FillWeight = 60.04105f;
            this.typeAbnDgvColumn.HeaderText = "Тип абонента";
            this.typeAbnDgvColumn.Name = "typeAbnDgvColumn";
            this.typeAbnDgvColumn.ReadOnly = true;
            this.typeAbnDgvColumn.Resizable = DataGridViewTriState.True;
            this.idAbnObjDataGridViewTextBoxColumn.DataPropertyName = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.HeaderText = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.idAbnObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnObjDataGridViewTextBoxColumn.Visible = false;
            this.nameObjDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.nameObjDataGridViewTextBoxColumn.DataPropertyName = "nameObj";
            this.nameObjDataGridViewTextBoxColumn.FillWeight = 99.93649f;
            this.nameObjDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.nameObjDataGridViewTextBoxColumn.Name = "nameObjDataGridViewTextBoxColumn";
            this.nameObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameObjDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.commentODSDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.commentODSDgvColumn.DataPropertyName = "CommentODS";
            this.commentODSDgvColumn.FillWeight = 99.93755f;
            this.commentODSDgvColumn.HeaderText = "Примечание";
            this.commentODSDgvColumn.Name = "commentODSDgvColumn";
            this.commentODSDgvColumn.ReadOnly = true;
            this.bindingSource_0.DataMember = "vl_SchmAbnFull";
            this.bindingSource_0.DataSource = this.dataSet_0;
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.Table1, this.table_vl_SchmAbnFull };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.idSub, this.Sub, this.idTr, this.TrName, this.Power, this.ColumnLoad };
            this.Table1.Columns.AddRange(columns);
            this.Table1.TableName = "Table1";
            this.idSub.ColumnName = "idSub";
            this.idSub.DataType = typeof(int);
            this.Sub.ColumnName = "Sub";
            this.idTr.ColumnName = "idTr";
            this.idTr.DataType = typeof(int);
            this.TrName.ColumnName = "TrName";
            this.Power.ColumnName = "Power";
            this.Power.DataType = typeof(int);
            this.ColumnLoad.ColumnName = "Load";
            this.ColumnLoad.DataType = typeof(int);
            DataColumn[] columnArray4 = new DataColumn[] { this.idAbn, this.codeAbonent, this.nameAbn, this.typeAbn, this.idAbnObj, this.nameObj, this.CommentODS };
            this.table_vl_SchmAbnFull.Columns.AddRange(columnArray4);
            this.table_vl_SchmAbnFull.TableName = "vl_SchmAbnFull";
            this.idAbn.ColumnName = "idAbn";
            this.idAbn.DataType = typeof(int);
            this.codeAbonent.ColumnName = "codeAbonent";
            this.codeAbonent.DataType = typeof(int);
            this.nameAbn.ColumnName = "nameAbn";
            this.typeAbn.ColumnName = "typeAbn";
            this.typeAbn.DataType = typeof(int);
            this.idAbnObj.ColumnName = "idAbnObj";
            this.idAbnObj.DataType = typeof(int);
            this.nameObj.ColumnName = "nameObj";
            this.CommentODS.ColumnName = "CommentODS";
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolBtnRefreshAbn, this.toolBrnDelAbn };
            this.toolStripAbn.Items.AddRange(toolStripItems);
            this.toolStripAbn.Location = new Point(3, 3);
            this.toolStripAbn.Name = "toolStripAbn";
            this.toolStripAbn.Size = new Size(0x412, 0x19);
            this.toolStripAbn.TabIndex = 6;
            this.toolStripAbn.Text = "toolStrip1";
            this.toolBtnRefreshAbn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnRefreshAbn.Image = (Image) resources.GetObject("toolBtnRefreshAbn.Image");
            this.toolBtnRefreshAbn.Image = global::DailyReport.Properties.Resources.Refresh;

            this.toolBtnRefreshAbn.ImageTransparentColor = Color.Magenta;
            this.toolBtnRefreshAbn.Name = "toolBtnRefreshAbn";
            this.toolBtnRefreshAbn.Size = new Size(0x17, 0x16);
            this.toolBtnRefreshAbn.Text = "Обновить";
            this.toolBtnRefreshAbn.Click += new EventHandler(this.toolBtnRefreshAbn_Click);
            this.toolBrnDelAbn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBrnDelAbn.Image = (Image) resources.GetObject("toolBrnDelAbn.Image");
            this.toolBrnDelAbn.Image = global::DailyReport.Properties.Resources.Delete;
            this.toolBrnDelAbn.ImageTransparentColor = Color.Magenta;
            this.toolBrnDelAbn.Name = "toolBrnDelAbn";
            this.toolBrnDelAbn.Size = new Size(0x17, 0x16);
            this.toolBrnDelAbn.Text = "Удалить абонентов";
            this.toolBrnDelAbn.Click += new EventHandler(this.toolBrnDelAbn_Click);
            this.buttonClose.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.buttonClose.DialogResult = DialogResult.Cancel;
            this.buttonClose.Location = new Point(0x3c7, 0x273);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(0x4b, 0x17);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
            this.buttonSave.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.buttonSave.DialogResult = DialogResult.OK;
            this.buttonSave.Location = new Point(12, 0x273);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(0x4b, 0x17);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.dataGridViewComboBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            style5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dataGridViewComboBoxColumn_0.DefaultCellStyle = style5;
            this.dataGridViewComboBoxColumn_0.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn_0.HeaderText = "Объект";
            this.dataGridViewComboBoxColumn_0.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewComboBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn_1.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn_1.HeaderText = "Повреждение";
            this.dataGridViewComboBoxColumn_1.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn_2.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn_2.HeaderText = "Уточнение";
            this.dataGridViewComboBoxColumn_2.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_2.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn_0.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_1.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_2.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
            this.progressBar.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.progressBar.Location = new Point(0x141, 0x273);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new Size(640, 0x17);
            this.progressBar.Style = ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            this.labelProgress.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new Point(0x5d, 0x278);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new Size(180, 13);
            this.labelProgress.TabIndex = 5;
            this.labelProgress.Text = "Загрузка отключенных абонентов";
            this.labelProgress.Visible = false;
            this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork);
            this.backgroundWorker_0.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
            this.toolTip_0.IsBalloon = true;
            this.toolTip_0.ShowAlways = true;
            base.AcceptButton = this.buttonSave;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.buttonClose;
            base.ClientSize = new Size(0x41e, 0x292);
            base.Controls.Add(this.progressBar);
            base.Controls.Add(this.labelProgress);
            base.Controls.Add(this.buttonSave);
            base.Controls.Add(this.buttonClose);
            base.Controls.Add(this.tabControl1);
            base.Name = "FormDamageLVAddEdit";
            this.Text = "FormDamageLVAddEdit";
            base.FormClosing += new FormClosingEventHandler(this.FormDamageLVAddEdit_FormClosing);
            base.Load += new EventHandler(this.FormDamageLVAddEdit_Load);
            base.Shown += new EventHandler(this.FormDamageLVAddEdit_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxDefectData.ResumeLayout(false);
            this.groupBoxDefectData.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.dataSetDamage.EndInit();
            ((ISupportInitialize)this.dgvCharacterDamage).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxDeclarer.ResumeLayout(false);
            this.groupBoxDeclarer.PerformLayout();
            this.tabPageWeather.ResumeLayout(false);
            this.tabPageWeather.PerformLayout();
            this.dataSetDamage_1.EndInit();
            this.groupBox_3.ResumeLayout(false);
            this.groupBox_3.PerformLayout();
            this.groupBox_4.ResumeLayout(false);
            this.groupBox_4.PerformLayout();
            this.groupBox_5.ResumeLayout(false);
            this.groupBox_5.PerformLayout();
            this.tabPagePTS.ResumeLayout(false);
            this.tabPagePTS.PerformLayout();
            this.tabPageAbn.ResumeLayout(false);
            this.tabPageAbn.PerformLayout();
            ((ISupportInitialize)this.dgvAbn).EndInit();
            ((ISupportInitialize)this.bindingSource_0).EndInit();
            this.dataSet_0.EndInit();
            this.Table1.EndInit();
            this.table_vl_SchmAbnFull.EndInit();
            this.toolStripAbn.ResumeLayout(false);
            this.toolStripAbn.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        [CompilerGenerated]
        private bool method_41(ElectricObject electricObject_0)
        {
            return (electricObject_0.Id == Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"]));
        }

        private void method_5()
        {
            if (this.IdDocument > 0)
            {
                this.tJ_DamageDataTable_0 = new dsDamage.tJ_DamageDataTable();
                base.SelectSqlData(this.tJ_DamageDataTable_0, true, "where id = " + this.IdDocument.ToString(), null, false, 0);
                this.tJ_DamageCharacterDataTable_0 = new dsDamage.tJ_DamageCharacterDataTable();
                base.SelectSqlData(this.tJ_DamageCharacterDataTable_0, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
            }
        }

        private void method_6()
        {
            DataRow row = this.dataSetDamage.tJ_DamageLV.NewRow();
            row["idDamage"] = this.IdDocument;
            this.dataSetDamage.tJ_DamageLV.Rows.Add(row);
        }

        private DataTable method_7()
        {
            DataTable table1 = new DataTable("tR_Classifier");
            table1.Columns.Add("id", typeof(int));
            table1.Columns.Add("name", typeof(string));
            return table1;
        }

        private void method_8()
        {
            DataTable table = this.method_7();
            if (((this.tJ_DamageDataTable_0 != null) && (this.tJ_DamageDataTable_0.Rows.Count > 0)) && (this.tJ_DamageDataTable_0.Rows[0]["idDivision"] != DBNull.Value))
            {
                base.SelectSqlData(table, true, string.Format(" where (ParentKey = ';GroupWorker;DailyREport;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0})", this.tJ_DamageDataTable_0.Rows[0]["idDivision"]), null, false, 0);
            }
            else
            {
                base.SelectSqlData(table, true, " where ParentKey = ';GroupWorker;DailyREport;' and isgroup = 0 and deleted = 0", null, false, 0);
            }
            this.cmbDivision.DisplayMember = "name";
            this.cmbDivision.ValueMember = "id";
            this.cmbDivision.DataSource = table;
            this.cmbDivision.SelectedIndex = -1;
        }

        private void method_9()
        {
            DataTable table = new DataTable("vWorkerGroup");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("FIO", typeof(string));
            table.Columns.Add("idGroup", typeof(int));
            base.SelectSqlData(table, true, "where ParentKey like ';GroupWorker;DailyReport;' and dateEnd is null order by fio ", null, false, 0);
            this.cmbCompiler.DisplayMember = "FIO";
            this.cmbCompiler.ValueMember = "id";
            this.cmbCompiler.DataSource = table;
            this.cmbCompiler.SelectedIndex = -1;
        }

        private void dtpDateDoc_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if ((this.dtpDateDoc.Value != null) && (this.dtpDateDoc.Value != DBNull.Value))
            {
                this.labelDateDoc.ForeColor = Color.Black;
                this.dtpDataApply.MinDate = Convert.ToDateTime(this.dtpDateDoc.Value).Date;
            }
            else
            {
                this.dtpDataApply.MinDate = DateTimePicker.MinimumDateTime;
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((this.dtpDateDoc.Value == null) || (this.dtpDateDoc.Value == DBNull.Value)) && (this.tabControl1.SelectedTab == this.tabPageWeather))
            {
                this.tabControl1.SelectedTab = this.tabPageGeneral;
                this.labelDateDoc.ForeColor = Color.Red;
                MessageBox.Show("Не введена дата заявки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.tabControl1.SelectedTab == this.tabPageWeather)
            {
                base.SelectSqlData(this.dataSetDamage_1.tJ_Temperature, true, string.Format("where datetemp = '{0}'", Convert.ToDateTime(this.dtpDateDoc.Value).ToString("yyyyMMdd")), null, false, 0);
            }
        }

        private void txtNumRequest_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNumRequest.Text))
            {
                this.labelNumRequest.ForeColor = Color.Black;
            }
            this.isChangedData = true;
        }

        private void txtDeclarerTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b')) && ((e.KeyChar != '(') && (e.KeyChar != ')'))) && (((e.KeyChar != '-') && (e.KeyChar != ',')) && ((e.KeyChar != '.') && (e.KeyChar != ' ')))) && (e.KeyChar != ';'))
            {
                e.Handled = true;
            }
        }

        private void txtHousePrefix_TextChanged(object sender, EventArgs e)
        {
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

        private void txtHouse_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (!string.IsNullOrEmpty(this.txtHouse.Text))
            {
                this.labelHouse.ForeColor = Color.Black;
            }
        }

        private void toolBtnRefreshAbn_Click(object sender, EventArgs e)
        {
            this.toolRefreshAbn();
        }

        private void toolBrnDelAbn_Click(object sender, EventArgs e)
        {
            if ((this.dgvAbn.SelectedRows.Count > 0) && (MessageBox.Show("Вы действительно хотите удалить выбранные строки?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                foreach (DataGridViewRow row in this.dgvAbn.SelectedRows)
                {
                    this.dgvAbn.Rows.Remove(row);
                }
            }
        }
    }

}