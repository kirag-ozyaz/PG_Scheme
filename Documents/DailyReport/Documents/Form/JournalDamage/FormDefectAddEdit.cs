using ControlsLbr;
//using Documents.Forms.DailyReport.DataSets;
using DailyReport.DataSets;
using FormLbr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

namespace DailyReport.JournalDamage
{
/// <summary>
/// Дефект
/// tHkHyhmxt5XQvb9Z5s2 
/// Form83
/// </summary>
    public class FormDefectAddEdit : FormBase
    {
        /// <summary>
        /// флаг изменения данных в реквизитах (контролах на форме)
        /// </summary>
        private bool isChangedData;
        private bool flagViewDoc;
        private Button buttonClose;
        private Button buttonSave;
        private Button btnChoiceSchmObj;
        private Button btnShowDocParent;
        private CheckBox checkBoxApply;
        private CheckBox checkBoxLaboratory;
        private ComboBox cmbWorkerApply;
        private ComboBox cmbCompletedWork;
        private ComboBoxReadOnly cmbDivision;
        private ComboBoxReadOnly cmbCompiler;
        private ComboBoxReadOnly cmbObl;
        private ComboBoxReadOnly cmbRaionObl;
        private ComboBoxReadOnly cmbCity;
        private ComboBoxReadOnly cmbStreet;
        private ComboBoxReadOnly cmbReason;
        private ComboBoxReadOnly cmbComplWorkODS;
        private ComboBoxReadOnly cmbDivisionApply;
        private DataGridView dgvCharacterDamage;
        private DataGridViewButtonColumn ColumnBtn;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_3;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_4;
        private DataGridViewComboBoxColumn ColumnCabSection;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_6;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn ColumnSchmObj;
        private DataGridViewTextBoxColumn ColumnIdSchmObj;
        // private DataSetDamage dataSetDamage_0;
        private dsDamage dataSetDamage;
        private DateTimePicker dtpDateOwner;
        private GroupBox groupBoxDefectData;
        private GroupBox groupBoxResult;
        private GroupBox groupBoxAddress;
        private IContainer components = null;
        private int IdDocument = -1;
        private int TypeDefect = 1403;
        private Label label_0;
        private Label labelCompiler;
        private Label labelStreet;
        private Label labelHousePrefix;
        private Label labelHouse;
        private Label labelDateAplly;
        private Label labelCompletedWork;
        private Label label1ChatacterDamage;
        private Label labelReason;
        private Label label_17;
        private Label labelDivisionApply;
        private Label label_19;
        private Label label_2;
        private Label label_20;
        private Label label_21;
        private Label label_22;
        private Label label_3;
        private Label labelDateDoc;
        private Label labelNumRequest;
        private Label labelSchmObj;
        private Label labelObl;
        private Label labelRaionObl;
        private Label labelCity;
        private int? nullable_0;
        private NullableDateTimePicker dtpDateDoc;
        private NullableDateTimePicker dtpDataApply;
        private NullableDateTimePicker dtpDatePlanApply;
        private RichTextBox txtCompletedWork;
        private RichTextBox txtLocation;
        private RichTextBox txtComplWorkODS;
        private RichTextBox txtInstruction;
        private SplitContainer splitContainer_0;
        private TabControl tabControl_0;
        private TabPage tabPageGeneral;
        private TextBox txtOwner;
        private TextBox txtNumRequest;
        private TextBox txtSchmObj;
        private TextBox txtHousePrefix;
        private TextBox txtHouse;
        private TextBox txtDocParent;
        private dsDamage.tJ_DamageCharacterDataTable tJ_DamageCharacterDataTable_0;
        private dsDamage.tJ_DamageDataTable tJ_DamageDataTable_0;
        private ToolTip toolTip_0;

        public FormDefectAddEdit(int idDocument = -1, int typeDefect = 1403)
        {
            this.InitializeComponent();
            this.dtpDateDoc.Value = (DateTime.Now);
            this.dtpDataApply.Value = (DateTime.Now);
            this.IdDocument = idDocument;
            this.TypeDefect = typeDefect;
            string str = (typeDefect == 1403) ? " НН" : " ВН";
            this.Text = (idDocument == -1) ? ("Добавить дефект" + str) : (this.get_ViewDocDefect() ? "Просмотр дефекта" : "Редактировать дефект");
        }

        protected override void ApplyConfig(XmlDocument xmlDocument_0)
        {
            XmlNode node = xmlDocument_0.SelectSingleNode(base.Name);
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
        }

        private void btnShowDocParent_Click(object sender, EventArgs e)
        {
            if ((this.dataSetDamage.tJ_Damage.Rows.Count > 0) && (this.dataSetDamage.tJ_Damage.Rows[0]["idParent"] != DBNull.Value))
            {
                DataTable table = new DataTable("tJ_Damage");
                table.Columns.Add("TypeDoc", typeof(int));
                base.SelectSqlData(table, true, "where id = " + this.dataSetDamage.tJ_Damage.Rows[0]["idParent"].ToString(), null, false, 0);
                if (table.Rows.Count > 0)
                {
                    switch (Convert.ToInt32(table.Rows[0]["TYpeDoc"]))
                    {
                        case 0x579://1401
                            {
                                FormDamageLVAddEdit form2 = new FormDamageLVAddEdit(Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idParent"]));
                                form2.SqlSettings = (this.SqlSettings);
                                form2.MdiParent = base.MdiParent;
                                form2.FormViewMode(true);
                                form2.Show();
                                break;
                            }
                        case 0x57a:
                            {
                                FormDamageHVAddEdit form1 = new FormDamageHVAddEdit(Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idParent"]));
                                form1.SqlSettings = (this.SqlSettings);
                                form1.MdiParent = base.MdiParent;
                                form1.FormViewMode(true);
                                form1.Show();
                                break;
                            }
                    }
                }
            }
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
            if ((this.TypeDefect == 1403) && (this.cmbCompletedWork.SelectedIndex >= 0))
            {
                this.labelCompletedWork.ForeColor = Color.Black;
            }
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
                    this.labelCompiler.ForeColor = Color.Black;
                    DataRow[] source = ((DataTable)this.cmbCompiler.DataSource).Select("id = " + this.cmbCompiler.SelectedValue.ToString());
                    if (source.Count<DataRow>() > 0)
                    {
                        this.cmbDivision.SelectedValue = source[0]["idGRoup"];
                    }
                }
            }
        }

        private void SelectedIndexChanged_SelectedIndexChanged(object sender, EventArgs e)
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
            if (this.cmbDivisionApply.SelectedIndex >= 0)
            {
                this.labelDivisionApply.ForeColor = Color.Black;
                this.checkBoxLaboratory.ForeColor = Color.Black;
            }
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

        private void dgvCharacterDamage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == this.ColumnBtn.Index) && (e.RowIndex >= 0))
            {
                if (this.dgvCharacterDamage[this.dataGridViewComboBoxColumn_4.Index, e.RowIndex].Value == null)
                {
                    MessageBox.Show("Не выбран тип объекта");
                }
                else
                {
                    DataTable table = this.method_6();
                    table.Columns.Add("ParentKey", typeof(string));
                    base.SelectSqlData(table, true, " where id = " + this.dgvCharacterDamage[this.dataGridViewComboBoxColumn_4.Index, e.RowIndex].Value.ToString(), null, false, 0);
                    if (table.Rows.Count != 0)
                    {
                        List<int> list = new List<int>();
                        switch (table.Rows[0]["ParentKey"].ToString())
                        {
                            case ";ReportDaily;NatureDamage;HV;AirLine;":
                                list.Add(0x223);
                                list.Add(0x3d7);
                                list.Add(0x224);
                                break;

                            case ";ReportDaily;NatureDamage;HV;CableLine;":
                                list.Add(0x222);
                                list.Add(0x224);
                                break;

                            case ";ReportDaily;NatureDamage;HV;Subs;":
                                list.Add(0x218);
                                list.Add(0x217);
                                list.Add(0x219);
                                list.Add(0x40a);
                                list.Add(0x21a);
                                list.Add(0x4fb);
                                break;
                        }
                        //Form17 form = new Form17(list);
                        FormSelectLine form = new FormSelectLine(list);
                        form.splitContainer1_Visible(false);
                        form.SqlSettings = (this.SqlSettings);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            this.dgvCharacterDamage[this.ColumnSchmObj.Name, e.RowIndex].Value = form.method_0().NameObjList;
                            this.dgvCharacterDamage[this.ColumnIdSchmObj.Name, e.RowIndex].Value = form.method_0().idObjList;
                            DataGridViewComboBoxCell cell = this.dgvCharacterDamage[this.ColumnCabSection.Index, e.RowIndex] as DataGridViewComboBoxCell;
                            if ((table.Rows[0]["ParentKey"].ToString() != ";ReportDaily;NatureDamage;HV;AirLine;") && (table.Rows[0]["ParentKey"].ToString() != ";ReportDaily;NatureDamage;HV;CableLine;"))
                            {
                                cell.DataSource = null;
                                cell.Value = null;
                                cell.ReadOnly = true;
                            }
                            else
                            {
                                DataTable table2 = new DataTable("tP_CabSection");
                                table2.Columns.Add("id", typeof(int));
                                table2.Columns.Add("number", typeof(int));
                                base.SelectSqlData(table2, true, "where idObjList = " + form.method_0().idObjList.ToString() + " order by number", null, false, 0);
                                cell.DataSource = table2;
                                cell.ValueMember = "id";
                                cell.DisplayMember = "number";
                                cell.Value = null;
                                cell.ReadOnly = false;
                            }
                            this.isChangedData = true;
                        }
                    }
                }
            }
        }

        private void dgvCharacterDamage_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvCharacterDamage.IsCurrentCellDirty)
            {
                this.dgvCharacterDamage.CommitEdit(DataGridViewDataErrorContexts.Commit);
                this.isChangedData = true;
                this.label1ChatacterDamage.ForeColor = Color.Black;
                if (((this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.dataGridViewComboBoxColumn_4.Index) || (this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.dataGridViewComboBoxColumn_6.Index)) && (this.dgvCharacterDamage.CurrentCell.Value != null))
                {
                    DataTable table = this.method_6();
                    base.SelectSqlData(table, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", this.dgvCharacterDamage.CurrentCell.Value), null, false, 0);
                    int num = (this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.dataGridViewComboBoxColumn_4.Index) ? this.dataGridViewComboBoxColumn_6.Index : ((this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.dataGridViewComboBoxColumn_6.Index) ? this.dataGridViewComboBoxColumn_7.Index : -1);
                    DataGridViewComboBoxCell cell = this.dgvCharacterDamage[num, this.dgvCharacterDamage.CurrentRow.Index] as DataGridViewComboBoxCell;
                    cell.DataSource = table;
                    cell.DisplayMember = "name";
                    cell.ValueMember = "id";
                    if ((cell.Value != null) && (table.Select("id = " + cell.Value.ToString()).Length == 0))
                    {
                        cell.Value = null;
                    }
                    if ((cell.Value == null) && (cell.ColumnIndex == this.dataGridViewComboBoxColumn_6.Index))
                    {
                        DataGridViewComboBoxCell cell1 = this.dgvCharacterDamage[this.dataGridViewComboBoxColumn_7.Index, this.dgvCharacterDamage.CurrentRow.Index] as DataGridViewComboBoxCell;
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

        private void FormDefectAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((base.DialogResult != DialogResult.OK) && ((!this.isChangedData || this.get_ViewDocDefect()) || (MessageBox.Show("Сохранить внесенные изменения", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)))
            {
                base.DialogResult = DialogResult.Cancel;
            }
            else if (this.method_16() && this.method_17())
            {
                if (this.method_18())
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

        private void FormDefectAddEdit_Load(object sender, EventArgs e)
        {
            this.method_5();
            this.method_4();
            this.method_7();
            this.method_8();
            this.method_22();
            this.method_10();
            this.method_11(this.cmbCompletedWork);
            this.method_11(this.cmbComplWorkODS);
            this.method_12();
            this.method_13();
            this.method_27();
            base.LoadFormConfig(null);
            if (this.IdDocument == -1)
            {
                DataRow row = this.dataSetDamage.tJ_Damage.NewRow();
                row["TypeDoc"] = this.TypeDefect;
                row["dateOwner"] = DateTime.Now;
                this.dataSetDamage.tJ_Damage.Rows.Add(row);
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
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["typeDoc"] != DBNull.Value)
                    {
                        this.TypeDefect = Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["typeDoc"]);
                        if (this.TypeDefect == 1403)
                        {
                            this.Text = this.Text + " НН";
                        }
                        else
                        {
                            this.Text = this.Text + " ВН";
                        }
                    }
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["numDoc"] != DBNull.Value)
                    {
                        this.Text = this.Text + " №" + this.dataSetDamage.tJ_Damage.Rows[0]["numDoc"].ToString();
                    }
                    if (this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"] != DBNull.Value)
                    {
                        string[] textArray1 = new string[] { this.dataSetDamage.tJ_Damage.Rows[0]["idSchmObj"].ToString() };
                        this.txtSchmObj.Text = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1).ToString();
                    }
                }
                this.method_26();
                this.method_23();
            }
            if (this.TypeDefect == 0x734)
            {
                this.cmbCompletedWork.Visible = false;
            }
            this.method_9();
            this.method_28();
            this.isChangedData = false;
        }

        private void FormDefectAddEdit_Shown(object sender, EventArgs e)
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

        public bool get_ViewDocDefect()
        {
            return this.flagViewDoc;
        }

        private void method_10()
        {
            DataTable table = this.method_6();
            int? nullable = this.nullable_0;
            if ((nullable.GetValueOrDefault() == 0x57a) ? nullable.HasValue : false)
            {
                if (((this.tJ_DamageDataTable_0 != null) && (this.tJ_DamageDataTable_0.Rows.Count > 0)) && (this.tJ_DamageDataTable_0.Rows[0]["idReason"] != DBNull.Value))
                {
                    base.SelectSqlData(table, true, string.Format(" where (ParentKey = ';ReportDaily;DamageReason;HV;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0}) order by name", this.tJ_DamageDataTable_0.Rows[0]["idReason"]), null, false, 0);
                }
                else
                {
                    base.SelectSqlData(table, true, " where ParentKey = ';ReportDaily;DamageReason;HV;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
                }
            }
            else if (((this.tJ_DamageDataTable_0 != null) && (this.tJ_DamageDataTable_0.Rows.Count > 0)) && (this.tJ_DamageDataTable_0.Rows[0]["idReason"] != DBNull.Value))
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

        private void method_11(ComboBox comboBox_2)
        {
            DataTable table = this.method_6();
            int? nullable = this.nullable_0;
            if ((nullable.GetValueOrDefault() == 0x57a) ? nullable.HasValue : false)
            {
                if (((this.tJ_DamageDataTable_0 != null) && (this.tJ_DamageDataTable_0.Rows.Count > 0)) && (this.tJ_DamageDataTable_0.Rows[0]["idCompletedWork"] != DBNull.Value))
                {
                    base.SelectSqlData(table, true, string.Format(" where (ParentKey = ';ReportDaily;CompletedWork;HV;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0}) order by name", this.tJ_DamageDataTable_0.Rows[0]["idCompletedWork"]), null, false, 0);
                }
                else
                {
                    base.SelectSqlData(table, true, " where ParentKey = ';ReportDaily;CompletedWork;HV;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
                }
            }
            else if (((this.tJ_DamageDataTable_0 != null) && (this.tJ_DamageDataTable_0.Rows.Count > 0)) && (this.tJ_DamageDataTable_0.Rows[0]["idCompletedWork"] != DBNull.Value))
            {
                base.SelectSqlData(table, true, string.Format(" where (ParentKey = ';ReportDaily;CompletedWork;LV;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0}) order by name", this.tJ_DamageDataTable_0.Rows[0]["idCompletedWork"]), null, false, 0);
            }
            else
            {
                base.SelectSqlData(table, true, " where ParentKey = ';ReportDaily;CompletedWork;LV;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
            }
            comboBox_2.DisplayMember = "name";
            comboBox_2.ValueMember = "id";
            comboBox_2.DataSource = table;
            comboBox_2.SelectedIndex = -1;
        }

        private void method_12()
        {
            DataTable table = new DataTable("vWorkerGroup");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("FIO", typeof(string));
            base.SelectSqlData(table, true, "where ParentKey in (';GroupWorker;PersonApplDiscon;Performer;NA1;',\r\n\t\t\t\t\t\t';GroupWorker;PersonApplDiscon;Performer;NA2;',\r\n\t\t\t\t\t\t';GroupWorker;PersonApplDiscon;Performer;NA3;',\r\n\t\t\t\t\t\t';GroupWorker;PersonApplDiscon;Performer;NA4;',\r\n\t\t\t\t\t\t';GroupWorker;PersonApplDiscon;Performer;PL;',\r\n\t\t\t\t\t\t';GroupWorker;PersonApplDiscon;Performer;SKUEE;',\r\n\t\t\t\t\t\t';GroupWorker;PersonApplDiscon;Performer;SESNO;') and dateEnd is null order by fio ", null, true, 0);
            this.cmbWorkerApply.DisplayMember = "FIO";
            this.cmbWorkerApply.ValueMember = "id";
            this.cmbWorkerApply.DataSource = table;
            this.cmbWorkerApply.SelectedIndex = -1;
        }

        private void method_13()
        {
            DataTable table = this.method_6();
            base.SelectSqlData(table, true, " where ParentKey = ';ReportDaily;DivisionApply;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
            this.cmbDivisionApply.DisplayMember = "name";
            this.cmbDivisionApply.ValueMember = "id";
            this.cmbDivisionApply.DataSource = table;
            this.cmbDivisionApply.SelectedIndex = -1;
        }

        private void method_14(object sender, EventArgs e)
        {
            this.isChangedData = true;
        }

        private void method_15(object sender, FormClosedEventArgs e)
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

        private bool method_16()
        {
            bool flag = true;
            if ((this.dtpDateDoc.Value == null) || (this.dtpDateDoc.Value == DBNull.Value))
            {
                this.labelDateDoc.ForeColor = Color.Red;
                flag = false;
            }
            if ((Convert.ToDateTime(this.dtpDateDoc.Value).Year < 0x7e0) && string.IsNullOrEmpty(this.txtNumRequest.Text))
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
                if (this.TypeDefect == 0x734)
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
                if ((this.dtpDataApply.Value == null) || (this.dtpDataApply.Value == DBNull.Value))
                {
                    this.labelDateAplly.ForeColor = Color.Red;
                    flag = false;
                }
            }
            if ((this.cmbDivisionApply.SelectedIndex < 0) && !this.checkBoxLaboratory.Checked)
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

        private bool method_17()
        {
            if (this.dataSetDamage.tJ_Damage.Rows.Count <= 0)
            {
                return true;
            }
            DataTable table = new DataTable("tJ_Damage");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("numREquest", typeof(string));
            table.Columns.Add("dateDoc", typeof(DateTime));
            base.SelectSqlData(table, true, string.Format("where numRequest = '{0}' and year(dateDoc) = {1} and typeDoc = {2} and id <> {3} and idDivision = {4}", new object[] { this.dataSetDamage.tJ_Damage.Rows[0]["numRequest"].ToString(), Convert.ToDateTime(this.dataSetDamage.tJ_Damage.Rows[0]["dateDoc"]).Year, this.TypeDefect, this.dataSetDamage.tJ_Damage.Rows[0]["id"].ToString(), Convert.ToInt32(this.dataSetDamage.tJ_Damage.Rows[0]["idDivision"]) }), null, false, 0);
            return ((table.Rows.Count <= 0) || (MessageBox.Show(string.Format("Заявка с номером {0} в текущем году уже была. Хотите все равно сохранить?", this.dataSetDamage.tJ_Damage.Rows[0]["numRequest"].ToString()), "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes));
        }

        private bool method_18()
        {
            int? nullable = this.nullable_0;
            if ((nullable.GetValueOrDefault() == 0x57a) ? !nullable.HasValue : true)
            {
                if ((this.cmbStreet.SelectedIndex >= 0) && !string.IsNullOrEmpty(this.txtHouse.Text))
                {
                    int num = this.method_21();
                    if (num == -1)
                    {
                        MessageBox.Show("Не удается создать объект - дом");
                        return false;
                    }
                    this.dataSetDamage.tJ_Damage.Rows[0]["idMap"] = num;
                }
                else
                {
                    this.dataSetDamage.tJ_Damage.Rows[0]["idMap"] = DBNull.Value;
                }
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
            if (!this.method_20())
            {
                return false;
            }
            if (!this.method_19())
            {
                return false;
            }
            return true;
        }

        private bool method_19()
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
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_4.Name].Value != null)
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col1"] = this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_4.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col1"] = DBNull.Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_6.Name].Value != null)
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col2"] = this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_6.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col2"] = DBNull.Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_7.Name].Value != null)
                    {
                        this.dataSetDamage.tJ_DamageCharacter.Rows[j]["col3"] = this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_7.Name].Value;
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
                    DataRow row = this.dataSetDamage.tJ_DamageCharacter.NewRow();
                    row["idDamage"] = this.IdDocument;
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_4.Name].Value != null)
                    {
                        row["col1"] = this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_4.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_6.Name].Value != null)
                    {
                        row["col2"] = this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_6.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_7.Name].Value != null)
                    {
                        row["col3"] = this.dgvCharacterDamage.Rows[j].Cells[this.dataGridViewComboBoxColumn_7.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.ColumnIdSchmObj.Name].Value != null)
                    {
                        row["idSchmObj"] = this.dgvCharacterDamage.Rows[j].Cells[this.ColumnIdSchmObj.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.ColumnCabSection.Name].Value != null)
                    {
                        row["idLineSection"] = this.dgvCharacterDamage.Rows[j].Cells[this.ColumnCabSection.Name].Value;
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
        /// <summary>
        /// режим просмотра документа
        /// </summary>
        public void FormViewMode(bool flg)
        {
            this.flagViewDoc = flg;
            this.ControlBlocking();
        }

        private bool method_20()
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

        private int method_21()
        {
            string str = string.IsNullOrEmpty(this.txtHousePrefix.Text) ? " and HousePrefix is null " : (" and HousePrefix = '" + this.txtHousePrefix.Text + "'");
            base.SelectSqlData(this.dataSetDamage.tMapObj, true, "where Street = " + this.cmbStreet.SelectedValue.ToString() + " and House = " + this.txtHouse.Text + str + " and IsHouse = 1 and Name is null", null, false, 0);
            if (this.dataSetDamage.tMapObj.Rows.Count > 0)
            {
                return Convert.ToInt32(this.dataSetDamage.tMapObj.Rows[0]["idMap"]);
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
            return base.InsertSqlDataOneRow(this.dataSetDamage, this.dataSetDamage.tMapObj);
        }

        private void method_22()
        {
            DataTable table = CreateReferenceTables.CreateTableKladObj();
            base.SelectSqlData(table, true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr", null, false, 0);
            this.cmbObl.DisplayMember = "fullname";
            this.cmbObl.ValueMember = "id";
            this.cmbObl.DataSource = table;
        }

        private void method_23()
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
                this.method_24(num, list);
                this.method_25(list);
                if (this.dataSetDamage.tMapObj.Rows[0]["Street"] != DBNull.Value)
                {
                    this.cmbStreet.SelectedValue = this.dataSetDamage.tMapObj.Rows[0]["Street"];
                }
            }
        }

        private void method_24(int int_2, List<DataRow> list_0)
        {
            DataTable table = CreateReferenceTables.CreateTableKladObj();
            base.SelectSqlData(table, true, " where id = " + int_2.ToString(), null, false, 0);
            if (((table.Rows.Count != 0) && ((table.Rows[0]["PrimaryKey"] == DBNull.Value) || (table.Rows[0]["PrimaryKey"].ToString() != "Country"))) && (table.Rows[0]["ParentId"] != DBNull.Value))
            {
                list_0.Add(table.Rows[0]);
                this.method_24(Convert.ToInt32(table.Rows[0]["ParentId"]), list_0);
            }
        }

        private void method_25(List<DataRow> list_0)
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

        private void method_26()
        {
            this.dgvCharacterDamage.Rows.Clear();
            base.SelectSqlData(this.dataSetDamage.tJ_DamageCharacter, true, "where idDamage = " + this.IdDocument.ToString(), null, false, 0);
            int num = 0;
            foreach (DataRow row in this.dataSetDamage.tJ_DamageCharacter)
            {
                this.dgvCharacterDamage.Rows.Add();
                if (row["col1"] != DBNull.Value)
                {
                    this.dgvCharacterDamage.CurrentCell = this.dgvCharacterDamage.Rows[num].Cells[this.dataGridViewComboBoxColumn_4.Name];
                    this.dgvCharacterDamage.Rows[num].Cells[this.dataGridViewComboBoxColumn_4.Name].Value = row["col1"];
                    DataTable table = this.method_6();
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
                    DataGridViewComboBoxCell cell1 = this.dgvCharacterDamage[this.dataGridViewComboBoxColumn_6.Index, num] as DataGridViewComboBoxCell;
                    cell1.DataSource = table;
                    cell1.DisplayMember = "name";
                    cell1.ValueMember = "id";
                }
                if (row["col2"] != DBNull.Value)
                {
                    this.dgvCharacterDamage.CurrentCell = this.dgvCharacterDamage.Rows[num].Cells[this.dataGridViewComboBoxColumn_4.Name];
                    this.dgvCharacterDamage.Rows[num].Cells[this.dataGridViewComboBoxColumn_6.Name].Value = row["col2"];
                    DataTable table2 = this.method_6();
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
                    DataGridViewComboBoxCell cell2 = this.dgvCharacterDamage[this.dataGridViewComboBoxColumn_7.Index, num] as DataGridViewComboBoxCell;
                    cell2.DataSource = table2;
                    cell2.DisplayMember = "name";
                    cell2.ValueMember = "id";
                }
                if (row["col3"] != DBNull.Value)
                {
                    this.dgvCharacterDamage.Rows[num].Cells[this.dataGridViewComboBoxColumn_7.Name].Value = row["col3"];
                }
                if (row["idSchmObj"] != DBNull.Value)
                {
                    this.dgvCharacterDamage[this.ColumnIdSchmObj.Index, num].Value = row["idSchmObj"];
                    string[] textArray1 = new string[] { row["idSchmObj"].ToString() };
                    object obj2 = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1);
                    if ((obj2 != null) && (obj2 != DBNull.Value))
                    {
                        this.dgvCharacterDamage[this.ColumnSchmObj.Index, num].Value = obj2.ToString();
                    }
                    DataGridViewComboBoxCell cell = this.dgvCharacterDamage[this.ColumnCabSection.Index, num] as DataGridViewComboBoxCell;
                    DataTable table3 = new DataTable("tP_CabSection");
                    table3.Columns.Add("id", typeof(int));
                    table3.Columns.Add("number", typeof(int));
                    base.SelectSqlData(table3, true, "where idObjList = " + row["idSchmObj"].ToString() + " order by number", null, false, 0);
                    cell.DataSource = table3;
                    cell.ValueMember = "id";
                    cell.DisplayMember = "number";
                    cell.ReadOnly = false;
                    if (row["idLineSection"] != DBNull.Value)
                    {
                        cell.Value = row["idLineSection"];
                    }
                    else
                    {
                        cell.Value = null;
                    }
                }
                num++;
            }
        }

        private void method_27()
        {
            int num = this.TypeDefect;
            if (this.nullable_0.HasValue)
            {
                num = this.nullable_0.Value;
            }
            this.ColumnSchmObj.Visible = this.ColumnCabSection.Visible = (num == 0x57a) || (num == 0x734);
            this.ColumnBtn.Visible = num == 0x734;
            this.dataGridViewComboBoxColumn_7.Visible = true;
            this.dataGridViewComboBoxColumn_6.Visible = true;
            DataTable table = this.method_6();
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
            switch (num)
            {
                case 1401:
                case 1403:
                    if (!string.IsNullOrEmpty(str))
                    {
                        base.SelectSqlData(table, true, string.Format("where (ParentId in (select id from \r\n                                        tr_classifier where ParentKey = ';ReportDaily;NatureDamage;LV;') \r\n                                        and isGroup = 1 and deleted = 0) or \r\n                                        (id in ({0})) order by ParentKey", str), null, false, 0);
                        break;
                    }
                    base.SelectSqlData(table, true, "where ParentId in (select id from \r\n                                        tr_classifier where ParentKey = ';ReportDaily;NatureDamage;LV;') \r\n                                        and isGroup = 1 and deleted = 0 order by ParentKey", null, false, 0);
                    break;

                case 1402:
                case 1844:
                    if (string.IsNullOrEmpty(str))
                    {
                        base.SelectSqlData(table, true, "where ParentId in (select id from \r\n                                        tr_classifier where ParentKey = ';ReportDaily;NatureDamage;HV;') \r\n                                        and isGroup = 1 and deleted = 0 order by ParentKey", null, false, 0);
                    }
                    else
                    {
                        base.SelectSqlData(table, true, string.Format("where (ParentId in (select id from \r\n                                        tr_classifier where ParentKey = ';ReportDaily;NatureDamage;HV;') \r\n                                        and isGroup = 1 and deleted = 0) or \r\n                                        (id in ({0})) order by ParentKey", str), null, false, 0);
                    }
                    break;
            }
            BindingSource source = new BindingSource
            {
                DataSource = table,
                Position = -1
            };
            this.dataGridViewComboBoxColumn_4.DisplayMember = "name";
            this.dataGridViewComboBoxColumn_4.ValueMember = "id";
            this.dataGridViewComboBoxColumn_4.DataSource = source;
        }

        private void method_28()
        {
            if (!this.get_ViewDocDefect() && (this.checkBoxApply.Checked || (this.dataSetDamage.tJ_Damage.Rows[0]["idParent"] != DBNull.Value)))
            {
                this.txtNumRequest.ReadOnly = true;
                this.dtpDateDoc.Enabled = false;
                this.cmbCompiler.ReadOnly = (true);
                this.cmbDivision.ReadOnly = (true);
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
                if (this.checkBoxApply.Checked)
                {
                    this.groupBoxResult.Enabled = false;
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
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            this.tabControl_0 = new TabControl();
            this.tabPageGeneral = new TabPage();
            this.cmbDivisionApply = new ComboBoxReadOnly();
            // this.dataSetDamage_0 = new DataSetDamage();
            this.dataSetDamage = new dsDamage();
            this.splitContainer_0 = new SplitContainer();
            this.groupBoxDefectData = new GroupBox();
            this.txtLocation = new RichTextBox();
            this.label_20 = new Label();
            this.groupBoxAddress = new GroupBox();
            this.txtHousePrefix = new TextBox();
            this.labelObl = new Label();
            this.labelHousePrefix = new Label();
            this.cmbObl = new ComboBoxReadOnly();
            this.txtHouse = new TextBox();
            this.labelRaionObl = new Label();
            this.labelHouse = new Label();
            this.cmbRaionObl = new ComboBoxReadOnly();
            this.cmbStreet = new ComboBoxReadOnly();
            this.cmbCity = new ComboBoxReadOnly();
            this.labelStreet = new Label();
            this.labelCity = new Label();
            this.dgvCharacterDamage = new DataGridView();
            this.dataGridViewComboBoxColumn_4 = new DataGridViewComboBoxColumn();
            this.ColumnSchmObj = new DataGridViewTextBoxColumn();
            this.ColumnIdSchmObj = new DataGridViewTextBoxColumn();
            this.ColumnBtn = new DataGridViewButtonColumn();
            this.ColumnCabSection = new DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn_6 = new DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn_7 = new DataGridViewComboBoxColumn();
            this.label1ChatacterDamage = new Label();
            this.cmbReason = new ComboBoxReadOnly();
            this.labelReason = new Label();
            this.btnChoiceSchmObj = new Button();
            this.labelSchmObj = new Label();
            this.txtSchmObj = new TextBox();
            this.cmbComplWorkODS = new ComboBoxReadOnly();
            this.txtComplWorkODS = new RichTextBox();
            this.label_21 = new Label();
            this.txtInstruction = new RichTextBox();
            this.label_22 = new Label();
            this.btnShowDocParent = new Button();
            this.checkBoxLaboratory = new CheckBox();
            this.labelDivisionApply = new Label();
            this.txtDocParent = new TextBox();
            this.label_17 = new Label();
            this.groupBoxResult = new GroupBox();
            this.dtpDatePlanApply = new NullableDateTimePicker();
            this.label_19 = new Label();
            this.dtpDataApply = new NullableDateTimePicker();
            this.labelDateAplly = new Label();
            this.cmbWorkerApply = new ComboBox();
            this.checkBoxApply = new CheckBox();
            this.txtCompletedWork = new RichTextBox();
            this.labelCompletedWork = new Label();
            this.cmbCompletedWork = new ComboBox();
            this.cmbDivision = new ComboBoxReadOnly();
            this.label_0 = new Label();
            this.labelCompiler = new Label();
            this.cmbCompiler = new ComboBoxReadOnly();
            this.dtpDateOwner = new DateTimePicker();
            this.label_2 = new Label();
            this.label_3 = new Label();
            this.txtOwner = new TextBox();
            this.labelDateDoc = new Label();
            this.dtpDateDoc = new NullableDateTimePicker();
            this.labelNumRequest = new Label();
            this.txtNumRequest = new TextBox();
            this.buttonClose = new Button();
            this.buttonSave = new Button();
            this.toolTip_0 = new ToolTip(this.components);
            this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn_1 = new DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn_2 = new DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn_3 = new DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.tabControl_0.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.dataSetDamage.BeginInit();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.groupBoxDefectData.SuspendLayout();
            this.groupBoxAddress.SuspendLayout();
            ((ISupportInitialize)this.dgvCharacterDamage).BeginInit();
            this.groupBoxResult.SuspendLayout();
            base.SuspendLayout();
            this.tabControl_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.tabControl_0.Controls.Add(this.tabPageGeneral);
            this.tabControl_0.Location = new Point(0, 0);
            this.tabControl_0.Name = "tabControl1";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x388, 0x2bd);
            this.tabControl_0.TabIndex = 0;
            this.tabPageGeneral.Controls.Add(this.cmbDivisionApply);
            this.tabPageGeneral.Controls.Add(this.splitContainer_0);
            this.tabPageGeneral.Controls.Add(this.btnShowDocParent);
            this.tabPageGeneral.Controls.Add(this.checkBoxLaboratory);
            this.tabPageGeneral.Controls.Add(this.labelDivisionApply);
            this.tabPageGeneral.Controls.Add(this.txtDocParent);
            this.tabPageGeneral.Controls.Add(this.label_17);
            this.tabPageGeneral.Controls.Add(this.groupBoxResult);
            this.tabPageGeneral.Controls.Add(this.cmbDivision);
            this.tabPageGeneral.Controls.Add(this.label_0);
            this.tabPageGeneral.Controls.Add(this.labelCompiler);
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
            this.tabPageGeneral.Size = new Size(0x380, 0x2a3);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Общий";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            this.cmbDivisionApply.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.cmbDivisionApply.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbDivisionApply.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbDivisionApply.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idDivisionApply", true));
            this.cmbDivisionApply.DropDownStyle = (ComboBoxStyle.DropDownList);
            this.cmbDivisionApply.FormattingEnabled = true;
            this.cmbDivisionApply.Location = new Point(0xa9, 0x1e6);
            this.cmbDivisionApply.Name = "cmbDivisionApply";
            this.cmbDivisionApply.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbDivisionApply.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbDivisionApply.Size = new Size(510, 0x15);
            this.cmbDivisionApply.TabIndex = 0x10;
            this.cmbDivisionApply.SelectedIndexChanged += new EventHandler(this.cmbDivisionApply_SelectedIndexChanged);
            this.cmbDivisionApply.KeyDown += new KeyEventHandler(this.cmbDivisionApply_KeyDown);
            this.dataSetDamage.DataSetName = "DataSetDamage";
            this.dataSetDamage.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.splitContainer_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.splitContainer_0.Location = new Point(3, 120);
            this.splitContainer_0.Name = "splitContainer1";
            this.splitContainer_0.Panel1.Controls.Add(this.groupBoxDefectData);
            this.splitContainer_0.Panel2.Controls.Add(this.cmbComplWorkODS);
            this.splitContainer_0.Panel2.Controls.Add(this.txtComplWorkODS);
            this.splitContainer_0.Panel2.Controls.Add(this.label_21);
            this.splitContainer_0.Panel2.Controls.Add(this.txtInstruction);
            this.splitContainer_0.Panel2.Controls.Add(this.label_22);
            this.splitContainer_0.Size = new Size(0x377, 0x165);
            this.splitContainer_0.SplitterDistance = 0x21e;
            this.splitContainer_0.TabIndex = 0x18;
            this.groupBoxDefectData.Controls.Add(this.txtLocation);
            this.groupBoxDefectData.Controls.Add(this.label_20);
            this.groupBoxDefectData.Controls.Add(this.groupBoxAddress);
            this.groupBoxDefectData.Controls.Add(this.dgvCharacterDamage);
            this.groupBoxDefectData.Controls.Add(this.label1ChatacterDamage);
            this.groupBoxDefectData.Controls.Add(this.cmbReason);
            this.groupBoxDefectData.Controls.Add(this.labelReason);
            this.groupBoxDefectData.Controls.Add(this.btnChoiceSchmObj);
            this.groupBoxDefectData.Controls.Add(this.labelSchmObj);
            this.groupBoxDefectData.Controls.Add(this.txtSchmObj);
            this.groupBoxDefectData.Dock = DockStyle.Fill;
            this.groupBoxDefectData.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.groupBoxDefectData.Location = new Point(0, 0);
            this.groupBoxDefectData.Name = "groupBoxDefectData";
            this.groupBoxDefectData.Size = new Size(0x21e, 0x165);
            this.groupBoxDefectData.TabIndex = 0;
            this.groupBoxDefectData.TabStop = false;
            this.groupBoxDefectData.Text = "Исходные данные";
            this.txtLocation.AcceptsTab = true;
            this.txtLocation.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtLocation.BackColor = SystemColors.Window;
            this.txtLocation.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.DefectLocation", true));
            this.txtLocation.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtLocation.Location = new Point(0x80, 0xb2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new Size(0x198, 40);
            this.txtLocation.TabIndex = 6;
            this.txtLocation.Text = "";
            this.label_20.AutoSize = true;
            this.label_20.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_20.Location = new Point(12, 0xb2);
            this.label_20.Name = "label7";
            this.label_20.Size = new Size(110, 13);
            this.label_20.TabIndex = 5;
            this.label_20.Text = "Место повреждения";
            this.groupBoxAddress.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBoxAddress.Controls.Add(this.txtHousePrefix);
            this.groupBoxAddress.Controls.Add(this.labelObl);
            this.groupBoxAddress.Controls.Add(this.labelHousePrefix);
            this.groupBoxAddress.Controls.Add(this.cmbObl);
            this.groupBoxAddress.Controls.Add(this.txtHouse);
            this.groupBoxAddress.Controls.Add(this.labelRaionObl);
            this.groupBoxAddress.Controls.Add(this.labelHouse);
            this.groupBoxAddress.Controls.Add(this.cmbRaionObl);
            this.groupBoxAddress.Controls.Add(this.cmbStreet);
            this.groupBoxAddress.Controls.Add(this.cmbCity);
            this.groupBoxAddress.Controls.Add(this.labelStreet);
            this.groupBoxAddress.Controls.Add(this.labelCity);
            this.groupBoxAddress.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.groupBoxAddress.Location = new Point(9, 0x48);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new Size(0x20f, 100);
            this.groupBoxAddress.TabIndex = 4;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Адрес";
            this.txtHousePrefix.BackColor = SystemColors.Window;
            this.txtHousePrefix.Location = new Point(0x160, 0x48);
            this.txtHousePrefix.Name = "txtHousePrefix";
            this.txtHousePrefix.Size = new Size(0x40, 20);
            this.txtHousePrefix.TabIndex = 11;
            this.txtHousePrefix.TextChanged += new EventHandler(this.txtHousePrefix_TextChanged);
            this.labelObl.AutoSize = true;
            this.labelObl.Location = new Point(6, 0x10);
            this.labelObl.Name = "labelObl";
            this.labelObl.Size = new Size(50, 13);
            this.labelObl.TabIndex = 0;
            this.labelObl.Text = "Область";
            this.labelHousePrefix.AutoSize = true;
            this.labelHousePrefix.Location = new Point(0x15d, 0x38);
            this.labelHousePrefix.Name = "labelHousePrefix";
            this.labelHousePrefix.Size = new Size(0x35, 13);
            this.labelHousePrefix.TabIndex = 10;
            this.labelHousePrefix.Text = "Префикс";
            this.cmbObl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbObl.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbObl.FormattingEnabled = true;
            this.cmbObl.Location = new Point(6, 0x20);
            this.cmbObl.Name = "cmbObl";
            this.cmbObl.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbObl.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbObl.Size = new Size(0xb3, 0x15);
            this.cmbObl.TabIndex = 1;
            this.cmbObl.ValueMember = "tR_KladrObj.Id";
            this.cmbObl.SelectedIndexChanged += new EventHandler(this.SelectedIndexChanged_SelectedIndexChanged);
            this.txtHouse.BackColor = SystemColors.Window;
            this.txtHouse.Location = new Point(0x111, 0x48);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new Size(0x3f, 20);
            this.txtHouse.TabIndex = 9;
            this.txtHouse.TextChanged += new EventHandler(this.txtHouse_TextChanged);
            this.labelRaionObl.AutoSize = true;
            this.labelRaionObl.Location = new Point(0xcb, 0x10);
            this.labelRaionObl.Name = "labelRaionObl";
            this.labelRaionObl.Size = new Size(0x48, 13);
            this.labelRaionObl.TabIndex = 2;
            this.labelRaionObl.Text = "Район/город";
            this.labelHouse.AutoSize = true;
            this.labelHouse.Location = new Point(270, 0x38);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new Size(30, 13);
            this.labelHouse.TabIndex = 8;
            this.labelHouse.Text = "Дом";
            this.cmbRaionObl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbRaionObl.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbRaionObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbRaionObl.FormattingEnabled = true;
            this.cmbRaionObl.Location = new Point(0xc3, 0x20);
            this.cmbRaionObl.Name = "cmbRaionObl";
            this.cmbRaionObl.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbRaionObl.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbRaionObl.Size = new Size(0xac, 0x15);
            this.cmbRaionObl.TabIndex = 3;
            this.cmbRaionObl.ValueMember = "tR_KladrObj.Id";
            this.cmbRaionObl.SelectedIndexChanged += new EventHandler(this.cmbRaionObl_SelectedIndexChanged);
            this.cmbStreet.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbStreet.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbStreet.DisplayMember = "tR_KladrStreet.NameSocr";
            this.cmbStreet.FormattingEnabled = true;
            this.cmbStreet.Location = new Point(6, 0x48);
            this.cmbStreet.Name = "cmbStreet";
            this.cmbStreet.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbStreet.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbStreet.Size = new Size(0xf4, 0x15);
            this.cmbStreet.TabIndex = 7;
            this.cmbStreet.ValueMember = "tR_KladrStreet.Id";
            this.cmbStreet.SelectedIndexChanged += new EventHandler(this.cmbStreet_SelectedIndexChanged);
            this.cmbCity.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbCity.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new Point(0x175, 0x20);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbCity.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbCity.Size = new Size(0x94, 0x15);
            this.cmbCity.TabIndex = 5;
            this.cmbCity.ValueMember = "tR_KladrObj.Id";
            this.cmbCity.SelectedIndexChanged += new EventHandler(this.cmbCity_SelectedIndexChanged);
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new Point(6, 0x38);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new Size(0x27, 13);
            this.labelStreet.TabIndex = 6;
            this.labelStreet.Text = "Улица";
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new Point(0x17e, 0x10);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new Size(0x66, 13);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "Населенный пункт";
            this.dgvCharacterDamage.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dgvCharacterDamage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewComboBoxColumn_4, this.ColumnSchmObj, this.ColumnIdSchmObj, this.ColumnBtn, this.ColumnCabSection, this.dataGridViewComboBoxColumn_6, this.dataGridViewComboBoxColumn_7 };
            this.dgvCharacterDamage.Columns.AddRange(dataGridViewColumns);
            this.dgvCharacterDamage.EditMode = DataGridViewEditMode.EditOnEnter;
            this.dgvCharacterDamage.Location = new Point(0, 0xed);
            this.dgvCharacterDamage.Name = "dgvCharacterDamage";
            this.dgvCharacterDamage.Size = new Size(0x21e, 120);
            this.dgvCharacterDamage.TabIndex = 8;
            this.dgvCharacterDamage.CellContentClick += new DataGridViewCellEventHandler(this.dgvCharacterDamage_CellContentClick);
            this.dgvCharacterDamage.CurrentCellDirtyStateChanged += new EventHandler(this.dgvCharacterDamage_CurrentCellDirtyStateChanged);
            this.dgvCharacterDamage.DataError += new DataGridViewDataErrorEventHandler(this.dgvCharacterDamage_DataError);
            this.dgvCharacterDamage.MouseClick += new MouseEventHandler(this.dgvCharacterDamage_MouseClick);
            this.dataGridViewComboBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dataGridViewComboBoxColumn_4.DefaultCellStyle = style;
            this.dataGridViewComboBoxColumn_4.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn_4.HeaderText = "Тип объекта";
            this.dataGridViewComboBoxColumn_4.Name = "Column1";
            this.dataGridViewComboBoxColumn_4.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_4.SortMode = DataGridViewColumnSortMode.Programmatic;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.ColumnSchmObj.DefaultCellStyle = style2;
            this.ColumnSchmObj.HeaderText = "Объект";
            this.ColumnSchmObj.Name = "ColumnSchmObj";
            this.ColumnSchmObj.ReadOnly = true;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.ColumnIdSchmObj.DefaultCellStyle = style3;
            this.ColumnIdSchmObj.HeaderText = "IdSchmObj";
            this.ColumnIdSchmObj.Name = "ColumnIdSchmObj";
            this.ColumnIdSchmObj.ReadOnly = true;
            this.ColumnIdSchmObj.Visible = false;
            this.ColumnBtn.HeaderText = "";
            this.ColumnBtn.Name = "ColumnBtn";
            this.ColumnBtn.Text = "...";
            this.ColumnBtn.ToolTipText = "Выбрать объект";
            this.ColumnBtn.Visible = false;
            this.ColumnBtn.Width = 0x19;
            style4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.ColumnCabSection.DefaultCellStyle = style4;
            this.ColumnCabSection.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnCabSection.HeaderText = "Участок";
            this.ColumnCabSection.Name = "ColumnCabSection";
            this.ColumnCabSection.ReadOnly = true;
            this.ColumnCabSection.Width = 60;
            this.dataGridViewComboBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            style5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dataGridViewComboBoxColumn_6.DefaultCellStyle = style5;
            this.dataGridViewComboBoxColumn_6.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn_6.HeaderText = "Повреждение";
            this.dataGridViewComboBoxColumn_6.Name = "Column2";
            this.dataGridViewComboBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            style6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dataGridViewComboBoxColumn_7.DefaultCellStyle = style6;
            this.dataGridViewComboBoxColumn_7.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn_7.HeaderText = "Уточнение";
            this.dataGridViewComboBoxColumn_7.Name = "Column3";
            this.label1ChatacterDamage.AutoSize = true;
            this.label1ChatacterDamage.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label1ChatacterDamage.Location = new Point(6, 0xdd);
            this.label1ChatacterDamage.Name = "label1ChatacterDamage";
            this.label1ChatacterDamage.Size = new Size(0x7e, 13);
            this.label1ChatacterDamage.TabIndex = 7;
            this.label1ChatacterDamage.Text = "Характер повреждения";
            this.cmbReason.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbReason.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbReason.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbReason.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idReason", true));
            this.cmbReason.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new Point(0x99, 0x2d);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbReason.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbReason.Size = new Size(0x17f, 0x15);
            this.cmbReason.TabIndex = 3;
            this.cmbReason.SelectedIndexChanged += new EventHandler(this.cmbReason_SelectedIndexChanged);
            this.labelReason.AutoSize = true;
            this.labelReason.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.labelReason.Location = new Point(6, 0x30);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new Size(0x56, 13);
            this.labelReason.TabIndex = 2;
            this.labelReason.Text = "Неисправность";
            this.btnChoiceSchmObj.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.btnChoiceSchmObj.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.btnChoiceSchmObj.Location = new Point(0x1fd, 0x13);
            this.btnChoiceSchmObj.Name = "btnChoiceSchmObj";
            this.btnChoiceSchmObj.Size = new Size(0x1b, 20);
            this.btnChoiceSchmObj.TabIndex = 2;
            this.btnChoiceSchmObj.Text = "...";
            this.btnChoiceSchmObj.UseVisualStyleBackColor = true;
            this.btnChoiceSchmObj.Click += new EventHandler(this.btnChoiceSchmObj_Click);
            this.labelSchmObj.AutoSize = true;
            this.labelSchmObj.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.labelSchmObj.Location = new Point(6, 0x16);
            this.labelSchmObj.Name = "labelSchmObj";
            this.labelSchmObj.Size = new Size(0x6c, 13);
            this.labelSchmObj.TabIndex = 0;
            this.labelSchmObj.Text = @"Подстанция\ячейка";
            this.txtSchmObj.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtSchmObj.BackColor = SystemColors.Window;
            this.txtSchmObj.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtSchmObj.Location = new Point(0x99, 0x13);
            this.txtSchmObj.Name = "txtSchmObj";
            this.txtSchmObj.ReadOnly = true;
            this.txtSchmObj.Size = new Size(0x165, 20);
            this.txtSchmObj.TabIndex = 1;
            this.txtSchmObj.TextChanged += new EventHandler(this.txtSchmObj_TextChanged);
            this.cmbComplWorkODS.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbComplWorkODS.BackColor = SystemColors.Window;
            this.cmbComplWorkODS.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idCompletedWorkODS", true));
            this.cmbComplWorkODS.ForeColor = SystemColors.WindowText;
            this.cmbComplWorkODS.FormattingEnabled = true;
            this.cmbComplWorkODS.Location = new Point(0xc0, 0xb2);
            this.cmbComplWorkODS.Name = "cmbComplWorkODS";
            this.cmbComplWorkODS.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbComplWorkODS.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbComplWorkODS.Size = new Size(0x91, 0x15);
            this.cmbComplWorkODS.TabIndex = 3;
            this.txtComplWorkODS.AcceptsTab = true;
            this.txtComplWorkODS.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.txtComplWorkODS.BackColor = SystemColors.Window;
            this.txtComplWorkODS.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.CompletedWorkTextODS", true));
            this.txtComplWorkODS.Location = new Point(2, 0xce);
            this.txtComplWorkODS.Name = "txtComplWorkODS";
            this.txtComplWorkODS.Size = new Size(0x14f, 0x97);
            this.txtComplWorkODS.TabIndex = 4;
            this.txtComplWorkODS.Text = "";
            this.label_21.AutoSize = true;
            this.label_21.Location = new Point(3, 0xb5);
            this.label_21.Name = "label9";
            this.label_21.Size = new Size(0xbd, 13);
            this.label_21.TabIndex = 2;
            this.label_21.Text = "Выполненная работа составителем";
            this.txtInstruction.AcceptsTab = true;
            this.txtInstruction.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtInstruction.BackColor = SystemColors.Window;
            this.txtInstruction.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.DivisionInstruction", true));
            this.txtInstruction.Location = new Point(2, 0x19);
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.Size = new Size(0x14f, 0x93);
            this.txtInstruction.TabIndex = 1;
            this.txtInstruction.Text = "";
            this.label_22.AutoSize = true;
            this.label_22.Location = new Point(12, 9);
            this.label_22.Name = "label8";
            this.label_22.Size = new Size(0x39, 13);
            this.label_22.TabIndex = 0;
            this.label_22.Text = "Указания";
            this.btnShowDocParent.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.btnShowDocParent.Enabled = false;
            this.btnShowDocParent.Location = new Point(0x355, 0x5c);
            this.btnShowDocParent.Name = "btnShowDocParent";
            this.btnShowDocParent.Size = new Size(0x1b, 20);
            this.btnShowDocParent.TabIndex = 0x17;
            this.btnShowDocParent.Text = "...";
            this.toolTip_0.SetToolTip(this.btnShowDocParent, "Открыть документ");
            this.btnShowDocParent.UseVisualStyleBackColor = true;
            this.btnShowDocParent.Click += new EventHandler(this.btnShowDocParent_Click);
            this.checkBoxLaboratory.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.checkBoxLaboratory.AutoSize = true;
            this.checkBoxLaboratory.DataBindings.Add(new Binding("Checked", this.dataSetDamage, "tJ_Damage.isLaboratory", true));
            this.checkBoxLaboratory.Location = new Point(0x2b1, 0x1e9);
            this.checkBoxLaboratory.Name = "checkBoxLaboratory";
            this.checkBoxLaboratory.Size = new Size(0xbf, 0x11);
            this.checkBoxLaboratory.TabIndex = 0x11;
            this.checkBoxLaboratory.Text = "Производственная лаборатория";
            this.checkBoxLaboratory.UseVisualStyleBackColor = true;
            this.checkBoxLaboratory.CheckedChanged += new EventHandler(this.checkBoxLaboratory_CheckedChanged);
            this.labelDivisionApply.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.labelDivisionApply.AutoSize = true;
            this.labelDivisionApply.Location = new Point(8, 0x1e9);
            this.labelDivisionApply.Name = "labelDivisionApply";
            this.labelDivisionApply.Size = new Size(0x9b, 13);
            this.labelDivisionApply.TabIndex = 15;
            this.labelDivisionApply.Text = "Подразделение исполнитель";
            this.txtDocParent.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtDocParent.BackColor = SystemColors.Window;
            this.txtDocParent.Location = new Point(0x81, 0x5d);
            this.txtDocParent.Name = "txtDocParent";
            this.txtDocParent.ReadOnly = true;
            this.txtDocParent.Size = new Size(0x2d5, 20);
            this.txtDocParent.TabIndex = 13;
            this.label_17.AutoSize = true;
            this.label_17.Location = new Point(8, 0x60);
            this.label_17.Name = "label1";
            this.label_17.Size = new Size(0x73, 13);
            this.label_17.TabIndex = 12;
            this.label_17.Text = "Документ-основание";
            this.groupBoxResult.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.groupBoxResult.Controls.Add(this.dtpDatePlanApply);
            this.groupBoxResult.Controls.Add(this.label_19);
            this.groupBoxResult.Controls.Add(this.dtpDataApply);
            this.groupBoxResult.Controls.Add(this.labelDateAplly);
            this.groupBoxResult.Controls.Add(this.cmbWorkerApply);
            this.groupBoxResult.Controls.Add(this.checkBoxApply);
            this.groupBoxResult.Controls.Add(this.txtCompletedWork);
            this.groupBoxResult.Controls.Add(this.labelCompletedWork);
            this.groupBoxResult.Controls.Add(this.cmbCompletedWork);
            this.groupBoxResult.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.groupBoxResult.Location = new Point(3, 0x201);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new Size(0x377, 0x9c);
            this.groupBoxResult.TabIndex = 14;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат (принятые меры)";
            this.dtpDatePlanApply.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dtpDatePlanApply.CustomFormat = ("dd.MM.yyyy HH:mm");
            this.dtpDatePlanApply.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DatePlanApply", true, DataSourceUpdateMode.OnPropertyChanged));
            this.dtpDatePlanApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dtpDatePlanApply.Format = (DateTimePickerFormat.Custom);
            this.dtpDatePlanApply.Location = new Point(0x10b, 0x67);
            this.dtpDatePlanApply.Name = "dtpDatePlanApply";
            this.dtpDatePlanApply.Size = new Size(0x1a1, 20);
            this.dtpDatePlanApply.TabIndex = 4;
            this.dtpDatePlanApply.Value = (new DateTime(0x7df, 8, 6, 10, 0, 0x35, 2));
            this.dtpDatePlanApply.ValueChanged += new EventHandler(this.ndtpDatePlanApply_ValueChanged);
            this.label_19.AutoSize = true;
            this.label_19.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_19.Location = new Point(10, 0x6c);
            this.label_19.Name = "label5";
            this.label_19.Size = new Size(0xfb, 13);
            this.label_19.TabIndex = 3;
            this.label_19.Text = "Планируемая дата и время выполнения работы";
            this.dtpDataApply.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dtpDataApply.CustomFormat = ("dd.MM.yyyy HH:mm");
            this.dtpDataApply.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateApply", true, DataSourceUpdateMode.OnPropertyChanged));
            this.dtpDataApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.dtpDataApply.Format = (DateTimePickerFormat.Custom);
            this.dtpDataApply.Location = new Point(0x19f, 0x81);
            this.dtpDataApply.Name = "dtpDataApply";
            this.dtpDataApply.Size = new Size(0x1d2, 20);
            this.dtpDataApply.TabIndex = 8;
            this.dtpDataApply.Value = (new DateTime(0x7df, 8, 6, 10, 0, 0x35, 2));
            this.dtpDataApply.ValueChanged += new EventHandler(this.dtpDataApply_ValueChanged);
            this.labelDateAplly.AutoSize = true;
            this.labelDateAplly.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.labelDateAplly.Location = new Point(0x14c, 0x84);
            this.labelDateAplly.Name = "labelDateAplly";
            this.labelDateAplly.Size = new Size(0x4d, 13);
            this.labelDateAplly.TabIndex = 7;
            this.labelDateAplly.Text = "Дата и время";
            this.cmbWorkerApply.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbWorkerApply.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbWorkerApply.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idWorkerApply", true));
            this.cmbWorkerApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbWorkerApply.FormattingEnabled = true;
            this.cmbWorkerApply.Location = new Point(130, 0x81);
            this.cmbWorkerApply.Name = "cmbWorkerApply";
            this.cmbWorkerApply.Size = new Size(0xc4, 0x15);
            this.cmbWorkerApply.TabIndex = 6;
            this.cmbWorkerApply.SelectedIndexChanged += new EventHandler(this.cmbWorkerApply_SelectedIndexChanged);
            this.checkBoxApply.AutoSize = true;
            this.checkBoxApply.DataBindings.Add(new Binding("Checked", this.dataSetDamage, "tJ_Damage.isApply", true));
            this.checkBoxApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.checkBoxApply.Location = new Point(13, 0x84);
            this.checkBoxApply.Name = "checkBoxApply";
            this.checkBoxApply.Size = new Size(0x52, 0x11);
            this.checkBoxApply.TabIndex = 5;
            this.checkBoxApply.Text = "Исполнено";
            this.checkBoxApply.UseVisualStyleBackColor = true;
            this.txtCompletedWork.AcceptsTab = true;
            this.txtCompletedWork.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtCompletedWork.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.ComletedWorkText", true));
            this.txtCompletedWork.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtCompletedWork.Location = new Point(9, 0x2f);
            this.txtCompletedWork.Name = "txtCompletedWork";
            this.txtCompletedWork.Size = new Size(0x36a, 0x2f);
            this.txtCompletedWork.TabIndex = 2;
            this.txtCompletedWork.Text = "";
            this.txtCompletedWork.TextChanged += new EventHandler(this.txtCompletedWork_TextChanged);
            this.labelCompletedWork.AutoSize = true;
            this.labelCompletedWork.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.labelCompletedWork.Location = new Point(10, 0x16);
            this.labelCompletedWork.Name = "labelCompletedWork";
            this.labelCompletedWork.Size = new Size(190, 13);
            this.labelCompletedWork.TabIndex = 0;
            this.labelCompletedWork.Text = "Выполненная работа исполнителем";
            this.cmbCompletedWork.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbCompletedWork.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idCompletedWork", true));
            this.cmbCompletedWork.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbCompletedWork.FormattingEnabled = true;
            this.cmbCompletedWork.Location = new Point(0xce, 0x13);
            this.cmbCompletedWork.Name = "cmbCompletedWork";
            this.cmbCompletedWork.Size = new Size(0x2a5, 0x15);
            this.cmbCompletedWork.TabIndex = 1;
            this.cmbCompletedWork.SelectedIndexChanged += new EventHandler(this.cmbCompletedWork_SelectedIndexChanged);
            this.cmbDivision.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbDivision.BackColor = SystemColors.Window;
            this.cmbDivision.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idDivision", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cmbDivision.ForeColor = SystemColors.WindowText;
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new Point(0x184, 0x3b);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.ReadOnly = (true);
            this.cmbDivision.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbDivision.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbDivision.Size = new Size(0x1f2, 0x15);
            this.cmbDivision.TabIndex = 11;
            this.cmbDivision.TabStop = false;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(0x127, 0x42);
            this.label_0.Name = "label6";
            this.label_0.Size = new Size(0x57, 13);
            this.label_0.TabIndex = 10;
            this.label_0.Text = "Подразделение";
            this.labelCompiler.AutoSize = true;
            this.labelCompiler.Location = new Point(8, 0x42);
            this.labelCompiler.Name = "labelCompiler";
            this.labelCompiler.Size = new Size(0x48, 13);
            this.labelCompiler.TabIndex = 8;
            this.labelCompiler.Text = "Составитель";
            this.cmbCompiler.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbCompiler.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbCompiler.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idCompiler", true));
            this.cmbCompiler.FormattingEnabled = true;
            this.cmbCompiler.Location = new Point(0x5e, 0x3b);
            this.cmbCompiler.Name = "cmbCompiler";
            this.cmbCompiler.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbCompiler.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbCompiler.Size = new Size(0xb9, 0x15);
            this.cmbCompiler.TabIndex = 9;
            this.cmbCompiler.SelectedValueChanged += new EventHandler(this.cmbCompiler_SelectedValueChanged);
            this.dtpDateOwner.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dtpDateOwner.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateOwner", true, DataSourceUpdateMode.OnPropertyChanged));
            this.dtpDateOwner.Enabled = false;
            this.dtpDateOwner.Location = new Point(0x163, 0x21);
            this.dtpDateOwner.Name = "dtpDateOwner";
            this.dtpDateOwner.Size = new Size(0x213, 20);
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
            this.label_3.TabIndex = 4;
            this.label_3.Text = "Автор заявки";
            this.txtOwner.Location = new Point(0x5e, 0x20);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new Size(0x85, 20);
            this.txtOwner.TabIndex = 5;
            this.labelDateDoc.AutoSize = true;
            this.labelDateDoc.Location = new Point(0xe9, 13);
            this.labelDateDoc.Name = "labelDateDoc";
            this.labelDateDoc.Size = new Size(0x74, 13);
            this.labelDateDoc.TabIndex = 2;
            this.labelDateDoc.Text = "Дата и время заявки";
            this.dtpDateDoc.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dtpDateDoc.CustomFormat = ("dd.MM.yyyy HH:mm");
            this.dtpDateDoc.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateDoc", true));
            this.dtpDateDoc.Format = (DateTimePickerFormat.Custom);
            this.dtpDateDoc.Location = new Point(0x163, 7);
            this.dtpDateDoc.Name = "dtpDateDoc";
            this.dtpDateDoc.Size = new Size(0x213, 20);
            this.dtpDateDoc.TabIndex = 3;
            this.dtpDateDoc.Value = (new DateTime(0x7df, 10, 14, 11, 0x1c, 0x1a, 0x2d5));
            this.dtpDateDoc.ValueChanged += new EventHandler(this.dtpDateDoc_ValueChanged);
            this.labelNumRequest.AutoSize = true;
            this.labelNumRequest.Location = new Point(8, 13);
            this.labelNumRequest.Name = "labelNumRequest";
            this.labelNumRequest.Size = new Size(80, 13);
            this.labelNumRequest.TabIndex = 0;
            this.labelNumRequest.Text = "Номер заявки";
            this.txtNumRequest.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.NumRequest", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtNumRequest.Location = new Point(0x5e, 6);
            this.txtNumRequest.Name = "txtNumRequest";
            this.txtNumRequest.Size = new Size(0x85, 20);
            this.txtNumRequest.TabIndex = 1;
            this.txtNumRequest.TextChanged += new EventHandler(this.txtNumRequest_TextChanged);
            this.buttonClose.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.buttonClose.DialogResult = DialogResult.Cancel;
            this.buttonClose.Location = new Point(0x32f, 0x2c3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(0x4b, 0x17);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
            this.buttonSave.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.buttonSave.DialogResult = DialogResult.OK;
            this.buttonSave.Location = new Point(12, 0x2c3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(0x4b, 0x17);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.dataGridViewComboBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn_0.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn_0.HeaderText = "Тип объекта";
            this.dataGridViewComboBoxColumn_0.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn_0.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewComboBoxColumn_1.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn_1.HeaderText = "Участок";
            this.dataGridViewComboBoxColumn_1.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn_1.ReadOnly = true;
            this.dataGridViewComboBoxColumn_1.Width = 60;
            this.dataGridViewComboBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn_2.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn_2.HeaderText = "Повреждение";
            this.dataGridViewComboBoxColumn_2.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn_3.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn_3.HeaderText = "Уточнение";
            this.dataGridViewComboBoxColumn_3.Name = "dataGridViewComboBoxColumn4";
            this.dataGridViewTextBoxColumn_2.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
            base.AcceptButton = this.buttonSave;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.buttonClose;
            base.ClientSize = new Size(0x386, 0x2e2);
            base.Controls.Add(this.buttonSave);
            base.Controls.Add(this.buttonClose);
            base.Controls.Add(this.tabControl_0);
            base.Name = "FormDefectAddEdit";
            this.Text = " ";
            base.FormClosing += new FormClosingEventHandler(this.FormDefectAddEdit_FormClosing);
            base.Load += new EventHandler(this.FormDefectAddEdit_Load);
            base.Shown += new EventHandler(this.FormDefectAddEdit_Shown);
            this.tabControl_0.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.dataSetDamage.EndInit();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.Panel2.PerformLayout();
            this.splitContainer_0.ResumeLayout(false);
            this.groupBoxDefectData.ResumeLayout(false);
            this.groupBoxDefectData.PerformLayout();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            ((ISupportInitialize)this.dgvCharacterDamage).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            base.ResumeLayout(false);
        }

        private void ControlBlocking()
        {
            bool flag;
            bool flag2;
            bool flag3;
            if (this.get_ViewDocDefect())
            {
                this.Text = "Просмотр дефекта";
            }
            this.txtNumRequest.ReadOnly = this.get_ViewDocDefect();
            this.dtpDateDoc.Enabled = !this.get_ViewDocDefect();
            this.cmbCompiler.ReadOnly = (this.get_ViewDocDefect());
            this.cmbDivision.ReadOnly = (this.get_ViewDocDefect());
            this.btnChoiceSchmObj.Enabled = !this.get_ViewDocDefect();
            this.txtLocation.ReadOnly = this.get_ViewDocDefect();
            this.cmbStreet.ReadOnly = (flag3 = this.get_ViewDocDefect());
            this.cmbCity.ReadOnly = (flag2 = flag3);
            this.cmbRaionObl.ReadOnly = (flag = flag2);
            this.cmbObl.ReadOnly = (flag);
            this.txtHouse.ReadOnly = this.txtHousePrefix.ReadOnly = this.get_ViewDocDefect();
            this.cmbReason.ReadOnly = (this.get_ViewDocDefect());
            this.dgvCharacterDamage.ReadOnly = this.get_ViewDocDefect();
            this.cmbCompletedWork.Enabled = !this.get_ViewDocDefect();
            this.txtCompletedWork.ReadOnly = this.get_ViewDocDefect();
            this.checkBoxApply.Enabled = !this.get_ViewDocDefect();
            this.cmbWorkerApply.Enabled = this.dtpDataApply.Enabled = this.dtpDatePlanApply.Enabled = !this.get_ViewDocDefect();
            this.buttonSave.Visible = !this.get_ViewDocDefect();
        }

        private void method_4()
        {
            if (this.getIdUseDoc() >= 0)
            {
                DataTable table = new DataTable("tJ_Damage");
                table.Columns.Add("idParent", typeof(int));
                base.SelectSqlData(table, true, "where id = " + this.IdDocument.ToString(), null, false, 0);
                if ((table.Rows.Count > 0) && (table.Rows[0]["idParent"] != DBNull.Value))
                {
                    this.cmbDivisionApply.ReadOnly = (true);
                    this.checkBoxLaboratory.Enabled = false;
                    this.txtComplWorkODS.ReadOnly = true;
                    this.cmbComplWorkODS.ReadOnly = (true);
                    this.txtInstruction.ReadOnly = true;
                    this.btnShowDocParent.Enabled = true;
                    DataTable table2 = new DataTable("vJ_Damage");
                    table2.Columns.Add("numDoc", typeof(int));
                    table2.Columns.Add("dateDoc", typeof(DateTime));
                    table2.Columns.Add("typeDocName", typeof(string));
                    table2.Columns.Add("TypeDoc", typeof(int));
                    table2.Columns.Add("nameDoc", typeof(string), "typedocname + isnull(' №' + convert(numDoc, System.String), ' №б/н') + isnull(' от ' + convert(dateDoc, System.String), '')");
                    base.SelectSqlData(table2, true, "where id = " + table.Rows[0]["idParent"].ToString(), null, false, 0);
                    if (table2.Rows.Count > 0)
                    {
                        this.txtDocParent.Text = table2.Rows[0]["nameDoc"].ToString();
                        this.nullable_0 = new int?(Convert.ToInt16(table2.Rows[0]["TypeDoc"]));
                    }
                }
            }
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

        private DataTable method_6()
        {
            DataTable table1 = new DataTable("tR_Classifier");
            table1.Columns.Add("id", typeof(int));
            table1.Columns.Add("name", typeof(string));
            return table1;
        }

        private void method_7()
        {
            DataTable table = this.method_6();
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

        private void method_8()
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

        private void method_9()
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

        private void dtpDateDoc_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if ((this.dtpDateDoc.Value != null) && (this.dtpDateDoc.Value != DBNull.Value))
            {
                if (Convert.ToDateTime(this.dtpDateDoc.Value).Year >= 0x7e0)
                {
                    this.txtNumRequest.ReadOnly = true;
                    this.txtNumRequest.Text = null;
                }
                else
                {
                    this.txtNumRequest.ReadOnly = false;
                }
                this.labelDateDoc.ForeColor = Color.Black;
                this.dtpDataApply.MinDate = this.dtpDatePlanApply.MinDate = Convert.ToDateTime(this.dtpDateDoc.Value);
            }
            else
            {
                this.dtpDataApply.MinDate = this.dtpDatePlanApply.MinDate = DateTimePicker.MinimumDateTime;
                this.txtNumRequest.Text = null;
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

        private void ndtpDatePlanApply_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
        }

        private void txtCompletedWork_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if ((this.TypeDefect == 0x734) && !string.IsNullOrEmpty(this.txtCompletedWork.Text))
            {
                this.labelCompletedWork.ForeColor = Color.Black;
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

        private void txtSchmObj_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtSchmObj.Text))
            {
                this.labelSchmObj.ForeColor = Color.Black;
            }
            this.isChangedData = true;
        }

        private void txtHousePrefix_TextChanged(object sender, EventArgs e)
        {
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
    }

}