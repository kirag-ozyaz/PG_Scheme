using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
// using Documents.Forms.DailyReport.DataSets;
using DailyReport.DataSets;
using FormLbr;
using FormLbr.Classes;
using RequestsClient.Forms.JournalRequestForRepair;
using SchemeModel;
using SchemeModel.Calculations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

/// <summary>
///  аварийное отключение 6-10 кВ
/// </summary>
namespace DailyReport.JournalDamage
{
    public class FormDamageHVAddEdit : FormBase
    {
        private BackgroundWorker backgroundWorker_0;
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;

        /// <summary>
        /// флаг изменения данных в реквизитах (контролах на форме)
        /// </summary>
        private bool isChangedData;
        private bool flagViewDoc;
        private bool bool_2;
        private Button buttonClose;
        private Button buttonSave;
        private Button btnChoiceSchmObj;
        private Button buttonLoadTextBoxSum;
        private Button btnRequestForRepair;
        private CheckBox checkBoxApply;
        private CheckBox chbDefect;
        private CheckBox checkBoxLaboratory;
        private ComboBox cmbAVR;
        private ComboBox cmbAPV;
        private ComboBoxReadOnly cmbDivision;
        private ComboBoxReadOnly cmbCompiler;
        private ComboBoxReadOnly cmbWorkerApply;
        private ComboBoxReadOnly cmbCompletedWork;
        private ComboBoxReadOnly cmbReason;
        private ComboBoxReadOnly cmbTypeRZA;
        private ComboBoxReadOnly cmbDivisionApply;
        private ContextMenuStrip contextMenuDgvTree;
        private DataColumn idSub;
        private DataColumn Sub;
        private DataColumn idAbnObj;
        private DataColumn nameObj;
        private DataColumn CommentODS;
        private DataColumn idTr;
        private DataColumn TrName;
        private DataColumn Power;
        private DataColumn load;
        private DataColumn idAbn;
        private DataColumn codeAbonent;
        private DataColumn nameAbn;
        private DataColumn typeAbn;
        private DataGridView dgvCharacterDamage;
        private DataGridViewButtonColumn ColumnBtn;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewComboBoxColumn Column1;
        private DataGridViewComboBoxColumn ColumnCabSection;
        private DataGridViewComboBoxColumn Column2;
        private DataGridViewComboBoxColumn Column3;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn4;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvOn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvTrans;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvAbn;
        private DataGridViewFilterComboBoxColumn typeAbnDgvColumn;
        private DataGridViewFilterDateTimePickerColumn dateOnDgvColumn;
        private DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn nameAbnDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn nameObjDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn commentODSDgvColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn subDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idSubDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateBegDgvColumn;
        private DataGridViewTextBoxColumn countSchmObjOffDgvColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn countSchmObjDgvColumn;
        private DataGridViewTextBoxColumn noAdmissionKWTDgvColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idDamageDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idSubColumn;
        private DataGridViewTextBoxColumn busNameColumn;
        private DataGridViewTextBoxColumn idBusColumn;
        private DataGridViewTextBoxColumn cellNameColumn;
        private DataGridViewTextBoxColumn idCellColumn;
        private DataGridViewTextBoxColumn trNameColumn;
        private DataGridViewTextBoxColumn ColumnSchmObj;
        private DataGridViewTextBoxColumn idTrColumn;
        private DataGridViewTextBoxColumn powerColumn;
        private DataGridViewTextBoxColumn loadColumn;
        private DataGridViewTextBoxColumn dateOnColumn;
        private DataGridViewTextBoxColumn noAdmissionKWTColumn;
        private DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idAbnObjDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn columnIdSchmObj;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataSet dataSet_0;
        private dsDamage dataSetDamage_0;
        private DataTable tableTrans;
        private DataTable table_vl_SchmAbnFull;
        private DateTime dateTime_0 = DateTimePicker.MaximumDateTime;
        private DateTimePicker dtpDateOwner;
        private DateTimePicker dtpDateDoc;
        private GroupBox groupBoxDefectData;
        private GroupBox groupBoxResult;
        private GroupBox groupBoxDefect;
        private IContainer components = null;
        private int IdDocument = -1;
        private Label label_0;
        private Label label_1;
        private Label label_10;
        private Label labelDamageOn;
        private Label label_12;
        private Label label_13;
        private Label label_14;
        private Label label_15;
        private Label label_16;
        private Label label_17;
        private Label label_18;
        private Label label_19;
        private Label label_2;
        private Label labelProgress;
        private Label label_21;
        private Label label_22;
        private Label label_23;
        private Label label_24;
        private Label label_25;
        private Label label_26;
        private Label label8;
        private Label label12;
        private Label label_29;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label labelSchmObj;
        private Label label_7;
        private Label labelCompletedWork;
        private Label label_9;
        private List<int> list_0 = new List<int>();
        private NullableDateTimePicker dtpDataApply;
        private ProgressBar progressBar;
        private RadioButton rbOnFact;
        private RadioButton rbOnAverage;
        private RichTextBox txtLocation;
        private RichTextBox txtCompletedWork;
        private RichTextBox txtLaboratoryInstruction;
        private RichTextBox txtDivisionInstruction;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private StatusStrip statusStripTrans;
        private StatusStrip statusStripAbn;
        private string string_0 = "";
        private TabControl tabControlMain;
        private TabPage tabPageGeneral;
        private TabPage tabPageTransformer;
        private TabPage tabPageAbn;
        private TextBox txtOwner;
        private TextBox txtNumRequest;
        private TextBox txtCoefSeason;
        private TextBox txtDocParent;
        private TextBox txtSchmObj;
        private TextBox txtNoKWT;
        private TextBox txtV;
        private TextBox txtA;
        private TextBox txtKWT;
        private TextBox txtCountSchmObj;
        private TextBox txtCosFi;
        private TextBox txtCountSchmObjOff;
        private dsDamage.tJ_DamageCharacterDataTable tJ_DamageCharacterDataTable_0;
        private dsDamage.tJ_DamageDataTable tJ_DamageDataTable_0;
        private dsDamage.tJ_DamageOnDataTable tJ_DamageOnDataTable_0;
        private ToolStrip toolStripTransformer;
        private ToolStrip toolStripAbn;
        private ToolStripButton toolBtnRefreshTrans;
        private ToolStripButton toolBtnRefreshAbn;
        private ToolStripMenuItem toolMenuItemOn;
        private ToolStripMenuItem toolMenuItemOff;
        private ToolStripStatusLabel labelCountTr;
        private ToolStripStatusLabel labelSumPower;
        private ToolStripStatusLabel labelSumLoad;
        private ToolStripStatusLabel labelCountAbn;
        private ToolStripStatusLabel labelCountAbnObj;
        private ToolTip toolTip_0;
        private TreeDataGridView dgvTree;
        private TreeGridColumn subNameColumn;

        public FormDamageHVAddEdit(int idDocument = -1)
        {
            this.InitializeComponent();
            this.IdDocument = idDocument;
            this.Text = (idDocument == -1) ? "Добавить аварийное отключение 6-10 кВ" : (this.get_ViewDocDamageHV() ? "Просмотр документа аварийное отключение 6-10 кВ" : "Редактировать аварийное отключение 6-10 кВ") + "(N)";
            this.dtpDataApply.Value = (DateTime.Now);
        }

        protected override void ApplyConfig(XmlDocument xml)
        {
            xml.SelectSingleNode(base.Name);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ElectricModel model1 = new ElectricModel();
            model1.SqlSettings = (this.SqlSettings);
            model1.LoadSchema(Convert.ToDateTime(e.Argument));
            TreeNodeObj obj2 = model1.PoweringReportForDrawObject(Convert.ToInt32(this.dataSetDamage_0.tJ_Damage.Rows[0]["idSchmObj"]), true);
            List<int> list = new List<int>();
            this.method_43(obj2, list);
            this.method_44(list);
            this.method_53();
            this.list_0 = new List<int>();
            this.method_55(null, obj2);
            List<ElectricObject> list2 = model1.PoweringReportForDrawObject(model1.Objects.Where<ElectricObject>(new Func<ElectricObject, bool>(this.method_65)).First<ElectricObject>(), true, true);
            if (list2.Count > 0)
            {
                string str = "";
                foreach (ElectricObject obj3 in list2)
                {
                    if (string.IsNullOrEmpty(str))
                    {
                        str = obj3.Id.ToString();
                    }
                    else
                    {
                        str = str + "," + obj3.Id.ToString();
                    }
                }
                // tG442HhZJrf
                // см. c0002d5
                // base.SelectSqlData(this.dataSet_0, this.dataTable_1.TableName, true, " where idSchmObj in (" + str + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj, commentODS ", new TimeSpan(0L));
                base.SelectSqlData(table_vl_SchmAbnFull, true, " where idSchmObj in (" + str + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj, commentODS ", 0);
            }
            else
            {
                this.table_vl_SchmAbnFull.Clear();
            }
            string[] columnNames = new string[] { "idAbn" };
            this.labelCountAbn.Text = "Количество абонентов: " + this.table_vl_SchmAbnFull.DefaultView.ToTable(true, columnNames).Rows.Count.ToString();
            string[] textArray2 = new string[] { "idAbnObj" };
            this.labelCountAbnObj.Text = "Количество объектов: " + this.table_vl_SchmAbnFull.DefaultView.ToTable(true, textArray2).Rows.Count.ToString();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.progressBar.Visible = false;
            this.labelProgress.Visible = false;
            this.toolBtnRefreshTrans.Enabled = true;
            this.toolBtnRefreshAbn.Enabled = true;
            this.dgvTrans.Enabled = true;
            this.dgvTrans.DataSource = this.bindingSource_0;
            this.dgvTree.Enabled = true;
            this.dgvAbn.Enabled = true;
            this.dgvAbn.DataSource = this.bindingSource_1;
            this.buttonSave.Enabled = true;
            this.buttonClose.Enabled = true;
            this.btnChoiceSchmObj.Enabled = true;
            this.dtpDateDoc.Enabled = true;
            this.method_50();
            this.method_60(this.dgvTree.Nodes);
            this.method_63();
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
            CreateReferenceTables.Get_SelectSchmObj(this.SqlSettings, this.dataSetDamage_0.tJ_Damage.Rows[0], this.txtSchmObj, ref this.isChangedData);
            this.method_21();
            this.method_45();
        }

        private void buttonLoadTextBoxSum_Click(object sender, EventArgs e)
        {
            this.method_50();
            this.method_21();
        }

        private void btnRequestForRepair_Click(object sender, EventArgs e)
        {
            if (this.dataSetDamage_0.tJ_Damage.Rows[0]["idReqForRepair"] != DBNull.Value)
            {
                RequestsClient.Forms.JournalRequestForRepair.FormJournalRequestForRepairAddEdit edit1 = new RequestsClient.Forms.JournalRequestForRepair.FormJournalRequestForRepairAddEdit(Convert.ToInt32(this.dataSetDamage_0.tJ_Damage.Rows[0]["idReqForRepair"]), -1, RequestsClient.Forms.JournalRequestForRepair.eActionRequestRepair.Read, false);
                edit1.GoToSchema += (new GoToSchemaEventHandler(this.method_52));
                edit1.SqlSettings = (this.SqlSettings);
                edit1.MdiParent = base.MdiParent;
                edit1.Show();
            }
        }

        private void checkBoxApply_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chbDefect_CheckedChanged(object sender, EventArgs e)
        {
            this.label_25.Visible = this.chbDefect.Checked;
            this.cmbDivisionApply.Visible = (this.chbDefect.Checked);
            this.checkBoxLaboratory.Visible = this.chbDefect.Checked;
            this.label_24.Visible = this.txtDivisionInstruction.Visible = this.chbDefect.Checked && (this.cmbDivisionApply.SelectedIndex >= 0);
            this.label_23.Visible = this.txtLaboratoryInstruction.Visible = this.chbDefect.Checked && this.checkBoxLaboratory.Checked;
            this.isChangedData = true;
        }

        private void checkBoxLaboratory_CheckedChanged(object sender, EventArgs e)
        {
            this.label_23.Visible = this.txtLaboratoryInstruction.Visible = this.chbDefect.Checked && this.checkBoxLaboratory.Checked;
            this.isChangedData = true;
        }

        private void cmbCompiler_SelectedValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.dataSetDamage_0.tJ_Damage.Rows.Count > 0)
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

        private void SelectedIndexChanged_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbReason.SelectedIndex >= 0)
            {
                this.label_9.ForeColor = Color.Black;
            }
            this.isChangedData = true;
        }

        private void cmbTypeRZA_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.cmbTypeRZA.SelectedIndex >= 0)
            {
                this.label_10.ForeColor = Color.Black;
            }
        }

        private void cmbDivisionApply_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label_24.Visible = this.txtDivisionInstruction.Visible = this.chbDefect.Checked && (this.cmbDivisionApply.SelectedIndex >= 0);
            this.isChangedData = true;
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document1 = new XmlDocument();
            XmlNode newChild = document1.CreateXmlDeclaration("1.0", "UTF-8", null);
            document1.AppendChild(newChild);
            XmlNode node2 = document1.CreateElement(base.Name);
            document1.AppendChild(node2);
            return document1;
        }

        private void dgvCharacterDamage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == this.ColumnBtn.Index) && (e.RowIndex >= 0))
            {
                if (this.dgvCharacterDamage[this.Column1.Index, e.RowIndex].Value == null)
                {
                    MessageBox.Show("Не выбран тип объекта");
                }
                else
                {
                    DataTable table = this.method_7();
                    table.Columns.Add("ParentKey", typeof(string));
                    base.SelectSqlData(table, true, " where id = " + this.dgvCharacterDamage[this.Column1.Index, e.RowIndex].Value.ToString());
                    if (table.Rows.Count != 0)
                    {
                        List<int> list = new List<int>();
                        switch (table.Rows[0]["ParentKey"].ToString())
                        {
                            case ";ReportDaily;NatureDamage;HV;AirLine;":
                                list.Add(0x223);//547
                                list.Add(0x3d7);//983
                                list.Add(0x224);//548
                                break;

                            case ";ReportDaily;NatureDamage;HV;CableLine;":
                                list.Add(0x222);//546
                                list.Add(0x224);//548
                                break;

                            case ";ReportDaily;NatureDamage;HV;Subs;":
                                list.Add(0x218);//536
                                list.Add(0x217);//535
                                list.Add(0x219);//537
                                list.Add(0x40a);//1034
                                list.Add(0x21a);//538
                                list.Add(0x4fb);//1275
                                break;
                        }
                        // зачем-то открывается FormSelectTrans NS038/c000158 (Привязка объекта к схеме)
                        // NS039/c00015b FormSelectSchmObj (Привязка объекта к схеме)
                        FormSelectLine form = new FormSelectLine(list);
                        form.splitContainer1_Visible(false);
                        form.SqlSettings = (this.SqlSettings);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            this.dgvCharacterDamage[this.ColumnSchmObj.Name, e.RowIndex].Value = form.method_0().NameObjList;
                            this.dgvCharacterDamage[this.columnIdSchmObj.Name, e.RowIndex].Value = form.method_0().idObjList;
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
                                base.SelectSqlData(table2, true, "where idObjList = " + form.method_0().idObjList.ToString() + " order by number");
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
                this.label_22.ForeColor = Color.Black;
                if (((this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.Column1.Index) || (this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.Column2.Index)) && (this.dgvCharacterDamage.CurrentCell.Value != null))
                {
                    if (this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.Column1.Index)
                    {
                        DataGridViewComboBoxCell cell1 = this.dgvCharacterDamage[this.ColumnCabSection.Index, this.dgvCharacterDamage.CurrentRow.Index] as DataGridViewComboBoxCell;
                        cell1.DataSource = null;
                        cell1.Value = null;
                        this.dgvCharacterDamage[this.ColumnSchmObj.Index, this.dgvCharacterDamage.CurrentRow.Index].Value = null;
                        this.dgvCharacterDamage[this.columnIdSchmObj.Index, this.dgvCharacterDamage.CurrentRow.Index].Value = null;
                    }
                    DataTable table = this.method_7();
                    base.SelectSqlData(table, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", this.dgvCharacterDamage.CurrentCell.Value));
                    int num = (this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.Column1.Index) ? this.Column2.Index : ((this.dgvCharacterDamage.CurrentCell.ColumnIndex == this.Column2.Index) ? this.Column3.Index : -1);
                    DataGridViewComboBoxCell cell = this.dgvCharacterDamage[num, this.dgvCharacterDamage.CurrentRow.Index] as DataGridViewComboBoxCell;
                    cell.DataSource = table;
                    cell.DisplayMember = "name";
                    cell.ValueMember = "id";
                    if ((cell.Value != null) && (table.Select("id = " + cell.Value.ToString()).Length == 0))
                    {
                        cell.Value = null;
                    }
                    if ((cell.Value == null) && (cell.ColumnIndex == this.Column2.Index))
                    {
                        DataGridViewComboBoxCell cell2 = this.dgvCharacterDamage[this.Column3.Index, this.dgvCharacterDamage.CurrentRow.Index] as DataGridViewComboBoxCell;
                        cell2.DataSource = null;
                        cell2.Value = null;
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

        private void dgvOn_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((this.dgvOn[this.idDamageDataGridViewTextBoxColumn1.Name, e.RowIndex].Value == DBNull.Value) || (Convert.ToInt32(this.dgvOn[this.idDamageDataGridViewTextBoxColumn1.Name, e.RowIndex].Value) != this.IdDocument))
                {
                    this.dgvOn[this.idDamageDataGridViewTextBoxColumn1.Name, e.RowIndex].Value = this.IdDocument;
                }
                if ((this.dgvOn.Columns[e.ColumnIndex] == this.dateOnDgvColumn) || (this.dgvOn.Columns[e.ColumnIndex] == this.countSchmObjDgvColumn))
                {
                    this.isChangedData = true;
                    if (this.dgvOn[this.countSchmObjDgvColumn.Name, e.RowIndex].Value != DBNull.Value)
                    {
                        this.method_39();
                        this.method_38();
                    }
                    if (this.dgvOn[this.dateOnDgvColumn.Name, e.RowIndex].Value != DBNull.Value)
                    {
                        this.method_42();
                    }
                    if ((this.dgvOn[this.dateOnDgvColumn.Name, e.RowIndex].Value != DBNull.Value) && (this.dgvOn[this.countSchmObjDgvColumn.Name, e.RowIndex].Value != DBNull.Value))
                    {
                        this.dgvOn[this.noAdmissionKWTDgvColumn.Name, e.RowIndex].Value = this.method_35(e.RowIndex);
                        for (int i = e.RowIndex + 1; i < (this.dgvOn.Rows.Count - 1); i++)
                        {
                            this.dgvOn[this.noAdmissionKWTDgvColumn.Name, i].Value = this.method_35(i);
                        }
                        this.method_37();
                    }
                }
            }
        }

        private void dgvOn_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
                e.Cancel = true;
                MessageBox.Show(e.Exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception)
            {
            }
        }

        private void dgvOn_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (((this.dgvOn.CurrentCell != null) && (this.dgvOn.Columns[this.dgvOn.CurrentCell.ColumnIndex] == this.dateOnDgvColumn)) && (e.Control is DateTimePicker))
            {
                if (this.dgvOn.CurrentCell.RowIndex == 0)
                {
                    ((DateTimePicker)e.Control).MinDate = this.dtpDateDoc.Value;
                }
                else
                {
                    ((DateTimePicker)e.Control).MinDate = Convert.ToDateTime(this.dgvOn[this.dateOnDgvColumn.Index, this.dgvOn.CurrentCell.RowIndex - 1].Value);
                }
                ((DateTimePicker)e.Control).MaxDate = this.dateTime_0;
                if (this.dgvOn.CurrentCell.Value == DBNull.Value)
                {
                    this.dgvOn.CurrentCell.Value = ((DateTimePicker)e.Control).Value;
                }
            }
        }

        private void dgvOn_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if ((this.dataSetDamage_0.tJ_DamageOn.Rows.Count > 0) || (this.dgvOn.Rows.Count > 1))
            {
                this.labelDamageOn.ForeColor = Color.Black;
            }
        }

        private void dgvOn_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.isChangedData = true;
            this.method_36();
        }

        private void dgvTrans_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvTrans_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void dgvTrans_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }

        private void dateTimePicker_1_Validated(object sender, EventArgs e)
        {
            if (this.bool_2)
            {
                this.method_45();
            }
            this.bool_2 = false;
        }

        private void dtpDateDoc_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpDateDoc.Value.Year >= 0x7e0)
            {
                this.label_5.ForeColor = Color.Black;
                this.txtNumRequest.ReadOnly = true;
            }
            else
            {
                if (string.IsNullOrEmpty(this.txtNumRequest.Text))
                {
                    this.label_5.ForeColor = Color.Red;
                }
                this.txtNumRequest.ReadOnly = false;
            }
            this.bool_2 = true;
            this.isChangedData = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormDamageHVAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.buttonClose.Enabled)
            {
                e.Cancel = true;
            }
            else if ((base.DialogResult != DialogResult.OK) && ((!this.isChangedData || this.get_ViewDocDamageHV()) || (MessageBox.Show("Сохранить внесенные изменения", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)))
            {
                base.DialogResult = DialogResult.Cancel;
            }
            else if (this.method_22() && this.method_23())
            {
                if (this.method_24())
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

        private void FormDamageHVAddEdit_Load(object sender, EventArgs e)
        {
            this.method_5();
            this.method_9();
            this.method_10();
            this.method_12();
            this.method_13();
            this.method_14();
            this.method_15();
            this.method_16();
            this.method_17();
            this.method_18(this.cmbAVR);
            this.method_18(this.cmbAPV);
            this.method_33();
            base.SelectSqlData(this.dataSetDamage_0.vWorkerGroup, true, " where ParentKey in (';GroupWorker;ITR;', ';GroupWorker;Workers;', ';GroupWorker;Dispatchers;')  and dateend is null order by fio ");
            base.LoadFormConfig(null);
            if (this.IdDocument == -1)
            {
                DataRow row = this.dataSetDamage_0.tJ_Damage.NewRow();
                row["TYpeDoc"] = 0x57a;
                row["dateDoc"] = DateTime.Now;
                row["dateOwner"] = DateTime.Now;
                this.dataSetDamage_0.tJ_Damage.Rows.Add(row);
                this.method_6();
            }
            else
            {
                this.dtpDateDoc.ValueChanged -= new EventHandler(this.dtpDateDoc_ValueChanged);
                base.SelectSqlData(this.dataSetDamage_0.tJ_Damage, true, "where id = " + this.IdDocument.ToString());
                this.dtpDateDoc.ValueChanged += new EventHandler(this.dtpDateDoc_ValueChanged);
                if (this.dataSetDamage_0.tJ_Damage.Rows.Count > 0)
                {
                    if (this.dataSetDamage_0.tJ_Damage.Rows[0]["numDoc"] != DBNull.Value)
                    {
                        this.Text = this.Text + " №" + this.dataSetDamage_0.tJ_Damage.Rows[0]["numDoc"].ToString();
                    }
                    if (this.dataSetDamage_0.tJ_Damage.Rows[0]["idSchmObj"] != DBNull.Value)
                    {
                        string[] textArray1 = new string[] { this.dataSetDamage_0.tJ_Damage.Rows[0]["idSchmObj"].ToString() };
                        this.txtSchmObj.Text = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1).ToString();
                    }
                    if ((this.dataSetDamage_0.tJ_Damage.Rows[0]["idDivisionApply"] != DBNull.Value) || ((this.dataSetDamage_0.tJ_Damage.Rows[0]["isLaboratory"] != DBNull.Value) && Convert.ToBoolean(this.dataSetDamage_0.tJ_Damage.Rows[0]["isLaboratory"])))
                    {
                        this.chbDefect.Checked = true;
                    }
                }
                this.method_32();
                this.method_4();
                base.SelectSqlData(this.dataSetDamage_0.tJ_DamageHV, true, "where idDamage = " + this.IdDocument.ToString());
                if (this.dataSetDamage_0.tJ_DamageHV.Rows.Count == 0)
                {
                    this.method_6();
                }
                this.method_47();
                CreateReferenceTables.Load_TableDamageAbnFull(this.dataSetDamage_0.tJ_DamageHV, this.table_vl_SchmAbnFull, this.SqlSettings);
                string[] columnNames = new string[] { "idAbn" };
                this.labelCountAbn.Text = "Количество абонентов: " + this.table_vl_SchmAbnFull.DefaultView.ToTable(true, columnNames).Rows.Count.ToString();
                string[] textArray3 = new string[] { "idAbnObj" };
                this.labelCountAbnObj.Text = "Количество объектов: " + this.table_vl_SchmAbnFull.DefaultView.ToTable(true, textArray3).Rows.Count.ToString();
                base.SelectSqlData(this.dataSetDamage_0.tJ_DamageOn, true, "where idDamage = " + this.IdDocument.ToString());
                if (this.dataSetDamage_0.tJ_DamageHV.Rows.Count > 0)
                {
                    if ((this.dataSetDamage_0.tJ_DamageHV.Rows[0]["isAverage"] != DBNull.Value) && !Convert.ToBoolean(this.dataSetDamage_0.tJ_DamageHV.Rows[0]["isAverage"]))
                    {
                        this.rbOnFact.Checked = true;
                    }
                    else
                    {
                        this.rbOnAverage.Checked = true;
                    }
                }
            }
            this.method_51();
            this.method_11();
            this.method_34();
            if (this.dtpDateDoc.Value.Year >= 0x7e0)
            {
                this.txtNumRequest.ReadOnly = true;
            }
            this.isChangedData = false;
        }

        private void FormDamageHVAddEdit_Shown(object sender, EventArgs e)
        {
            this.isChangedData = false;
            this.method_36();
        }

        internal int method_0()
        {
            return this.IdDocument;
        }

        internal bool get_ViewDocDamageHV()
        {
            return this.flagViewDoc;
        }

        private void method_10()
        {
            DataTable table = new DataTable("vWorkerGroup");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("FIO", typeof(string));
            table.Columns.Add("idGroup", typeof(int));
            base.SelectSqlData(table, true, "where ParentKey like ';GroupWorker;DailyReport;' and dateEnd is null order by fio ");
            this.cmbCompiler.DisplayMember = "FIO";
            this.cmbCompiler.ValueMember = "id";
            this.cmbCompiler.DataSource = table;
            this.cmbCompiler.SelectedIndex = -1;
        }

        private void method_11()
        {
            if (this.IdDocument == -1)
            {
                DataTable table = new DataTable("tUser");
                table.Columns.Add("name", typeof(string));
                table.Columns.Add("idWorker", typeof(string));
                base.SelectSqlData(table, true, "where [login] = SYSTEM_USER");
                if (table.Rows.Count > 0)
                {
                    if (table.Rows[0]["name"] != DBNull.Value)
                    {
                        this.txtOwner.Text = table.Rows[0]["name"].ToString();
                    }
                    if (table.Rows[0]["idWorker"] != DBNull.Value)
                    {
                        DataRow[] source = ((DataTable)this.cmbCompiler.DataSource).Select("id = " + table.Rows[0]["idWorker"]);
                        if (((source.Count<DataRow>() > 0) && (this.IdDocument == -1)) && (this.dataSetDamage_0.tJ_Damage.Rows.Count > 0))
                        {
                            this.dataSetDamage_0.tJ_Damage.Rows[0]["idCompiler"] = source[0]["id"];
                        }
                    }
                }
            }
            else if ((this.dataSetDamage_0.tJ_Damage.Rows.Count > 0) && (this.dataSetDamage_0.tJ_Damage.Rows[0]["idOwner"] != DBNull.Value))
            {
                DataTable table2 = new DataTable("tUser");
                table2.Columns.Add("name", typeof(string));
                base.SelectSqlData(table2, true, "where [idUser] = " + this.dataSetDamage_0.tJ_Damage.Rows[0]["idOwner"].ToString());
                if ((table2.Rows.Count > 0) && (table2.Rows[0]["name"] != DBNull.Value))
                {
                    this.txtOwner.Text = table2.Rows[0]["name"].ToString();
                }
            }
        }

        private void method_12()
        {
            DataTable table = this.method_7();
            if (((this.tJ_DamageDataTable_0 != null) && (this.tJ_DamageDataTable_0.Rows.Count > 0)) && (this.tJ_DamageDataTable_0.Rows[0]["idReason"] != DBNull.Value))
            {
                base.SelectSqlData(table, true, string.Format(" where (ParentKey = ';ReportDaily;DamageReason;HV;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0}) order by name", this.tJ_DamageDataTable_0.Rows[0]["idReason"]));
            }
            else
            {
                base.SelectSqlData(table, true, " where ParentKey = ';ReportDaily;DamageReason;HV;' and isgroup = 0 and deleted = 0 order by name");
            }
            this.cmbReason.DisplayMember = "name";
            this.cmbReason.ValueMember = "id";
            this.cmbReason.DataSource = table;
            this.cmbReason.SelectedIndex = -1;
        }

        private void method_13()
        {
            DataTable table = this.method_7();
            if (((this.tJ_DamageDataTable_0 != null) && (this.tJ_DamageDataTable_0.Rows.Count > 0)) && (this.tJ_DamageDataTable_0.Rows[0]["idCompletedWork"] != DBNull.Value))
            {
                base.SelectSqlData(table, true, string.Format(" where (ParentKey = ';ReportDaily;CompletedWork;HV;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0}) order by name", this.tJ_DamageDataTable_0.Rows[0]["idCompletedWork"]));
            }
            else
            {
                base.SelectSqlData(table, true, " where ParentKey = ';ReportDaily;CompletedWork;HV;' and isgroup = 0 and deleted = 0 order by name");
            }
            this.cmbCompletedWork.DisplayMember = "name";
            this.cmbCompletedWork.ValueMember = "id";
            this.cmbCompletedWork.DataSource = table;
            this.cmbCompletedWork.SelectedIndex = -1;
        }

        private void method_14()
        {
            DataTable table = new DataTable("vWorkerGroup");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("FIO", typeof(string));
            table.Columns.Add("idGroup", typeof(int));
            base.SelectSqlData(table, true, "where ParentKey like ';GroupWorker;DailyReport;' and dateEnd is null order by fio ");
            this.cmbWorkerApply.DisplayMember = "FIO";
            this.cmbWorkerApply.ValueMember = "id";
            this.cmbWorkerApply.DataSource = table;
            this.cmbWorkerApply.SelectedIndex = -1;
        }

        private void method_15()
        {
            DataTable table = this.method_7();
            base.SelectSqlData(table, true, " where ParentKey = ';ReportDaily;DivisionApply;' and isgroup = 0 and deleted = 0 order by name");
            this.cmbDivisionApply.DisplayMember = "name";
            this.cmbDivisionApply.ValueMember = "id";
            this.cmbDivisionApply.DataSource = table;
            this.cmbDivisionApply.SelectedIndex = -1;
        }

        private void method_16()
        {
            DataTable table = this.method_7();
            base.SelectSqlData(table, true, " where ParentKey = ';ReportDaily;TypeRZA;' and isgroup = 0 and deleted = 0 order by name");
            this.cmbTypeRZA.DisplayMember = "name";
            this.cmbTypeRZA.ValueMember = "id";
            this.cmbTypeRZA.DataSource = table;
            this.cmbTypeRZA.SelectedIndex = -1;
        }

        private void method_17()
        {
            DataTable table = this.method_7();
            base.SelectSqlData(table, true, " where  parentKey = ';SKUEE;TypeAbn;' and isGRoup = 0 and deleted  = 0");
            this.typeAbnDgvColumn.DisplayMember = "name";
            this.typeAbnDgvColumn.ValueMember = "id";
            BindingSource source = new BindingSource
            {
                DataSource = table
            };
            this.typeAbnDgvColumn.DataSource = source;
        }

        private void method_18(ComboBox comboBox_2)
        {
            DataTable table = this.method_8();
            comboBox_2.DisplayMember = "name";
            comboBox_2.ValueMember = "flag";
            comboBox_2.DataSource = table;
            comboBox_2.SelectedIndex = -1;
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

        private void method_20(object sender, EventArgs e)
        {
            this.isChangedData = true;
        }

        private void method_21()
        {
            if ((this.dataSetDamage_0.tJ_Damage.Rows.Count > 0) && (this.dataSetDamage_0.tJ_Damage.Rows[0]["idSchmObj"] != DBNull.Value))
            {
                DataTable table = base.SelectSqlData("tR_Classifier", true, string.Format(" inner join tSchm_ObjList o on o.typeCodeId = tR_Classifier.id\r\n                            where o.id = {0} and (tR_Classifier.ParentKey like ';SCM;BUS;%' or tR_Classifier.ParentKey like ';SCM;BUS;%')", this.dataSetDamage_0.tJ_Damage.Rows[0]["idSchmObj"]));
                if ((table.Rows.Count > 0) && (table.Rows[0]["Value"] != DBNull.Value))
                {
                    this.txtV.Text = Convert.ToDecimal(table.Rows[0]["Value"]).ToString("0.####");
                }
                else
                {
                    this.txtV.Text = "";
                    this.label_14.ForeColor = Color.Red;
                }
            }
        }

        private bool method_22()
        {
            bool flag = true;
            if ((this.dtpDateDoc.Value.Year < 0x7e0) && string.IsNullOrEmpty(this.txtNumRequest.Text))
            {
                this.label_5.ForeColor = Color.Red;
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
            if (this.cmbReason.SelectedIndex < 0)
            {
                this.label_9.ForeColor = Color.Red;
                flag = false;
            }
            if (this.dgvCharacterDamage.Rows.Count <= 1)
            {
                this.label_22.ForeColor = Color.Red;
                flag = false;
            }
            if (this.cmbTypeRZA.SelectedIndex < 0)
            {
                this.label_10.ForeColor = Color.Red;
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
                    this.label_7.ForeColor = Color.Red;
                    flag = false;
                }
                if ((this.dataSetDamage_0.tJ_DamageOn.Rows.Count == 0) || (this.dgvOn.Rows.Count <= 1))
                {
                    this.labelDamageOn.ForeColor = Color.Red;
                    flag = false;
                }
            }
            if (!flag)
            {
                MessageBox.Show("Не заполнены обязательный поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return flag;
        }

        private bool method_23()
        {
            if (this.dataSetDamage_0.tJ_Damage.Rows.Count <= 0)
            {
                return true;
            }
            DataTable table = new DataTable("tJ_Damage");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("numREquest", typeof(string));
            table.Columns.Add("dateDoc", typeof(DateTime));
            base.SelectSqlData(table, true, string.Format("where numRequest = '{0}' and year(dateDoc) = {1} and typeDoc = {2} and id <> {3} and idDivision = {4}", new object[] { this.dataSetDamage_0.tJ_Damage.Rows[0]["numRequest"].ToString(), Convert.ToDateTime(this.dataSetDamage_0.tJ_Damage.Rows[0]["dateDoc"]).Year, 0x57a, this.dataSetDamage_0.tJ_Damage.Rows[0]["id"].ToString(), Convert.ToInt32(this.dataSetDamage_0.tJ_Damage.Rows[0]["idDivision"]) }));
            return ((table.Rows.Count <= 0) || (MessageBox.Show(string.Format("Заявка с номером {0} в текущем году уже была. Хотите все равно сохранить?", this.dataSetDamage_0.tJ_Damage.Rows[0]["numRequest"].ToString()), "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes));
        }

        private bool method_24()
        {
            if (!this.chbDefect.Checked)
            {
                this.cmbDivisionApply.SelectedIndex = -1;
                this.checkBoxLaboratory.Checked = false;
            }
            this.dataSetDamage_0.tJ_Damage.Rows[0].EndEdit();
            if (this.IdDocument == -1)
            {
                this.IdDocument = base.InsertSqlDataOneRow(this.dataSetDamage_0, this.dataSetDamage_0.tJ_Damage);
                if (this.IdDocument == -1)
                {
                    return false;
                }
            }
            else if (!base.UpdateSqlData(this.dataSetDamage_0.tJ_Damage))
            {
                return false;
            }
            base.SelectSqlData(this.dataSetDamage_0.tJ_Damage, true, "where id = " + this.IdDocument.ToString());
            if (!this.method_26())
            {
                return false;
            }
            if (!this.method_25())
            {
                return false;
            }
            if (!this.method_27())
            {
                return false;
            }
            if (!this.method_28())
            {
                return false;
            }
            return true;
        }

        private bool method_25()
        {
            base.SelectSqlData(this.dataSetDamage_0.tJ_DamageCharacter, true, "where idDamage = " + this.IdDocument.ToString());
            for (int i = this.dgvCharacterDamage.Rows.Count - 1; i < this.dataSetDamage_0.tJ_DamageCharacter.Rows.Count; i++)
            {
                this.dataSetDamage_0.tJ_DamageCharacter.Rows[i].Delete();
            }
            for (int j = 0; j < (this.dgvCharacterDamage.Rows.Count - 1); j++)
            {
                if (j < this.dataSetDamage_0.tJ_DamageCharacter.Rows.Count)
                {
                    this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["idDamage"] = this.IdDocument;
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.Column1.Name].Value != null)
                    {
                        this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["col1"] = this.dgvCharacterDamage.Rows[j].Cells[this.Column1.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["col1"] = DBNull.Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.Column2.Name].Value != null)
                    {
                        this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["col2"] = this.dgvCharacterDamage.Rows[j].Cells[this.Column2.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["col2"] = DBNull.Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.Column3.Name].Value != null)
                    {
                        this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["col3"] = this.dgvCharacterDamage.Rows[j].Cells[this.Column3.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["col3"] = DBNull.Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.columnIdSchmObj.Name].Value != null)
                    {
                        this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["idSchmObj"] = this.dgvCharacterDamage.Rows[j].Cells[this.columnIdSchmObj.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["idSchmObj"] = DBNull.Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.ColumnCabSection.Name].Value != null)
                    {
                        this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["idLineSection"] = this.dgvCharacterDamage.Rows[j].Cells[this.ColumnCabSection.Name].Value;
                    }
                    else
                    {
                        this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["idLineSection"] = DBNull.Value;
                    }
                    this.dataSetDamage_0.tJ_DamageCharacter.Rows[j].EndEdit();
                }
                else
                {
                    DataRow row = this.dataSetDamage_0.tJ_DamageCharacter.NewRow();
                    row["idDamage"] = this.IdDocument;
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.Column1.Name].Value != null)
                    {
                        row["col1"] = this.dgvCharacterDamage.Rows[j].Cells[this.Column1.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.Column2.Name].Value != null)
                    {
                        row["col2"] = this.dgvCharacterDamage.Rows[j].Cells[this.Column2.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.Column3.Name].Value != null)
                    {
                        row["col3"] = this.dgvCharacterDamage.Rows[j].Cells[this.Column3.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.columnIdSchmObj.Name].Value != null)
                    {
                        row["idSchmObj"] = this.dgvCharacterDamage.Rows[j].Cells[this.columnIdSchmObj.Name].Value;
                    }
                    if (this.dgvCharacterDamage.Rows[j].Cells[this.ColumnCabSection.Name].Value != null)
                    {
                        row["idLineSection"] = this.dgvCharacterDamage.Rows[j].Cells[this.ColumnCabSection.Name].Value;
                    }
                    this.dataSetDamage_0.tJ_DamageCharacter.Rows.Add(row);
                }
            }
            if (!base.DeleteSqlData(this.dataSetDamage_0.tJ_DamageCharacter))
            {
                return false;
            }
            if (!base.UpdateSqlData(this.dataSetDamage_0.tJ_DamageCharacter))
            {
                return false;
            }
            if (!base.InsertSqlData(this.dataSetDamage_0.tJ_DamageCharacter))
            {
                return false;
            }
            base.SelectSqlData(this.dataSetDamage_0.tJ_DamageCharacter, true, "where idDamage = " + this.IdDocument.ToString());
            return true;
        }

        private bool method_26()
        {
            if (this.dataSetDamage_0.tJ_DamageHV.Rows.Count > 0)
            {
                this.dataSetDamage_0.tJ_DamageHV.Rows[0]["idDamage"] = this.IdDocument;
                this.dataSetDamage_0.tJ_DamageHV.Rows[0]["TransOff"] = this.method_46().InnerXml;
                this.dataSetDamage_0.tJ_DamageHV.Rows[0]["AbnOff"] = CreateReferenceTables.CreateXmlAbnOff(this.table_vl_SchmAbnFull).InnerXml;
                this.dataSetDamage_0.tJ_DamageHV.Rows[0]["isAverage"] = this.rbOnAverage.Checked;
                this.dataSetDamage_0.tJ_DamageHV.Rows[0].EndEdit();
                if (!base.InsertSqlData(this.dataSetDamage_0.tJ_DamageHV))
                {
                    return false;
                }
                if (!base.UpdateSqlData(this.dataSetDamage_0.tJ_DamageHV))
                {
                    return false;
                }
                base.SelectSqlData(this.dataSetDamage_0.tJ_DamageHV, true, "where idDamage = " + this.IdDocument.ToString());
            }
            return true;
        }

        private bool method_27()
        {
            if (this.rbOnAverage.Checked)
            {
                foreach (DataRow row in this.dataSetDamage_0.tJ_DamageOn.Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        row["idDamage"] = this.IdDocument;
                        row.EndEdit();
                    }
                }
            }
            else
            {
                DataTable table = new DataTable();
                if (this.tJ_DamageOnDataTable_0.Rows.Count > 0)
                {
                    //table = this.tJ_DamageOnDataTable_0
                    //    .AsEnumerable<DataSetDamage.Class332>()
                    //    .OrderBy<DataSetDamage.Class332, DateTime>((C_1.C_9__51_0 ?? (C_1.C_9__51_0 = new Func<DataSetDamage.Class332, DateTime>(C_1.C_9.method_0))))
                    //    .CopyToDataTable<DataSetDamage.Class332>();
                    table = this.tJ_DamageOnDataTable_0
                        .AsEnumerable()
                        .OrderBy(r => r.Field<DateTime>("DateOn"))
                        .CopyToDataTable();

                }
                else
                {
                    table = this.tJ_DamageOnDataTable_0;
                }
                int num = 0;
                foreach (DataRow row2 in this.dataSetDamage_0.tJ_DamageOn)
                {
                    if (row2.RowState != DataRowState.Deleted)
                    {
                        if (num < this.tJ_DamageOnDataTable_0.Rows.Count)
                        {
                            row2["idDamage"] = this.IdDocument;
                            row2["dateOn"] = table.Rows[num]["dateOn"];
                            row2["countSchmObj"] = table.Rows[num]["countSchmObj"];
                            row2["noAdmissionKWT"] = table.Rows[num]["noAdmissionKWT"];
                            row2.EndEdit();
                        }
                        else
                        {
                            this.tJ_DamageOnDataTable_0.Rows[num].Delete();
                        }
                        num++;
                    }
                }
                if (num < this.tJ_DamageOnDataTable_0.Rows.Count)
                {
                    for (int i = num; i < table.Rows.Count; i++)
                    {
                        DataRow row3 = this.dataSetDamage_0.tJ_DamageOn.NewRow();
                        row3["idDamage"] = this.IdDocument;
                        row3["dateOn"] = table.Rows[i]["dateOn"];
                        row3["countSchmObj"] = table.Rows[i]["countSchmObj"];
                        row3["noAdmissionKWT"] = table.Rows[i]["noAdmissionKWT"];
                        this.dataSetDamage_0.tJ_DamageOn.Rows.Add(row3);
                    }
                }
            }
            if ((base.InsertSqlData(this.dataSetDamage_0.tJ_DamageOn) && base.UpdateSqlData(this.dataSetDamage_0.tJ_DamageOn)) && base.DeleteSqlData(this.dataSetDamage_0.tJ_DamageOn))
            {
                base.SelectSqlData(this.dataSetDamage_0.tJ_DamageOn, true, " where idDamage = " + this.IdDocument.ToString());
                return true;
            }
            return false;
        }

        private bool method_28()
        {
            //IEnumerator enumerator;
            dsDamage.tJ_DamageDataTable table = new dsDamage.tJ_DamageDataTable();
            base.SelectSqlData(table, true, string.Format("where idParent = {0} and TypeDoc = {1} and idDivisionApply is not null", this.IdDocument, 0x734));
            if (this.chbDefect.Checked && (this.cmbDivisionApply.SelectedIndex >= 0))
            {
                for (int i = 1; i < table.Rows.Count; i++)
                {
                    table.Rows[i].Delete();
                }
                if (table.Rows.Count <= 0)
                {
                    DataRow row = table.NewRow();
                    CreateReferenceTables.Set_TableDamage(row, this.dataSetDamage_0, this.IdDocument, 0x734, true, false);
                    table.Rows.Add(row);
                    int num2 = base.InsertSqlDataOneRow(row);
                    if (num2 <= 0)
                    {
                        return false;
                    }
                    if (!this.method_29(num2))
                    {
                        return false;
                    }
                }
                else
                {
                    CreateReferenceTables.Set_TableDamage(table.Rows[0], this.dataSetDamage_0, this.IdDocument, 0x734, true, false);
                    table.Rows[0].EndEdit();
                    if (!base.UpdateSqlData(table))
                    {
                        return false;
                    }
                    if (!this.method_29(Convert.ToInt32(table.Rows[0]["id"])))
                    {
                        return false;
                    }
                }
            }
            else
            {
                //using (enumerator = table.Rows.GetEnumerator())
                //{
                //while (enumerator.MoveNext())
                foreach (IEnumerator enumerator in table.Rows)
                {
                    ((DataRow)enumerator.Current).Delete();
                }
                //}
                if (!base.DeleteSqlData(table))
                {
                    return false;
                }
            }
            base.SelectSqlData(table, true, string.Format("where idParent = {0} and TypeDoc = {1} and isLaboratory is not null", this.IdDocument, 0x734));
            if (this.chbDefect.Checked && this.checkBoxLaboratory.Checked)
            {
                for (int j = 1; j < table.Rows.Count; j++)
                {
                    table.Rows[j].Delete();
                }
                if (table.Rows.Count <= 0)
                {
                    DataRow row2 = table.NewRow();
                    CreateReferenceTables.Set_TableDamage(row2, this.dataSetDamage_0, this.IdDocument, 0x734, false, true);
                    table.Rows.Add(row2);
                    int num4 = base.InsertSqlDataOneRow(row2);
                    if (num4 <= 0)
                    {
                        return false;
                    }
                    if (!this.method_29(num4))
                    {
                        return false;
                    }
                }
                else
                {
                    CreateReferenceTables.Set_TableDamage(table.Rows[0], this.dataSetDamage_0, this.IdDocument, 0x734, false, true);
                    table.Rows[0].EndEdit();
                    if (!base.UpdateSqlData(table))
                    {
                        return false;
                    }
                    if (!this.method_29(Convert.ToInt32(table.Rows[0]["id"])))
                    {
                        return false;
                    }
                }
            }
            else
            {
                //using (enumerator = table.Rows.GetEnumerator())
                //{
                //    while (enumerator.MoveNext())
                foreach (IEnumerator enumerator in table.Rows)
                {
                    ((DataRow)enumerator.Current).Delete();
                }
                //}
                if (!base.DeleteSqlData(table))
                {
                    return false;
                }
            }
            return true;
        }

        private bool method_29(int int_1)
        {
            dsDamage.tJ_DamageCharacterDataTable table = new dsDamage.tJ_DamageCharacterDataTable();
            base.SelectSqlData(table, true, "where idDamage = " + int_1.ToString());
            for (int i = this.dataSetDamage_0.tJ_DamageCharacter.Rows.Count; i < table.Rows.Count; i++)
            {
                table.Rows[i].Delete();
            }
            for (int j = 0; j < this.dataSetDamage_0.tJ_DamageCharacter.Rows.Count; j++)
            {
                if (j < table.Rows.Count)
                {
                    table.Rows[j]["idDamage"] = int_1;
                    table.Rows[j]["col1"] = this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["col1"];
                    table.Rows[j]["col2"] = this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["col2"];
                    table.Rows[j]["col3"] = this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["col3"];
                    table.Rows[j]["idSchmObj"] = this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["idSchmObj"];
                    table.Rows[j]["idLineSection"] = this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["idLineSection"];
                    table.Rows[j].EndEdit();
                }
                else
                {
                    DataRow row = table.NewRow();
                    row["idDamage"] = int_1;
                    row["col1"] = this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["col1"];
                    row["col2"] = this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["col2"];
                    row["col3"] = this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["col3"];
                    row["idSChmObj"] = this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["idSchmObj"];
                    row["idLineSection"] = this.dataSetDamage_0.tJ_DamageCharacter.Rows[j]["idLineSection"];
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

        private void ControlBlocking()
        {
            if (this.get_ViewDocDamageHV())
            {
                this.Text = "Просмотр документа аварийное отключение 6-10 кВ";
            }
            if (this.dtpDateDoc.Value.Year < 0x7e0)
            {
                this.txtNumRequest.ReadOnly = this.get_ViewDocDamageHV();
            }
            this.dtpDateDoc.Enabled = !this.get_ViewDocDamageHV();
            this.cmbCompiler.ReadOnly = (this.get_ViewDocDamageHV());
            this.cmbDivision.ReadOnly = (this.get_ViewDocDamageHV());
            this.btnChoiceSchmObj.Enabled = !this.get_ViewDocDamageHV();
            this.txtLocation.ReadOnly = this.get_ViewDocDamageHV();
            this.cmbReason.ReadOnly = (this.get_ViewDocDamageHV());
            this.dgvCharacterDamage.ReadOnly = this.get_ViewDocDamageHV();
            this.dgvCharacterDamage.AllowUserToDeleteRows = false;
            this.ColumnBtn.Visible = !this.get_ViewDocDamageHV();
            this.cmbTypeRZA.ReadOnly = (this.get_ViewDocDamageHV());
            this.txtCountSchmObj.ReadOnly = this.get_ViewDocDamageHV();
            this.txtKWT.ReadOnly = this.get_ViewDocDamageHV();
            this.txtA.ReadOnly = this.get_ViewDocDamageHV();
            this.txtV.ReadOnly = this.get_ViewDocDamageHV();
            this.txtCoefSeason.ReadOnly = this.get_ViewDocDamageHV();
            this.txtCosFi.ReadOnly = this.get_ViewDocDamageHV();
            this.cmbAVR.Enabled = !this.get_ViewDocDamageHV();
            this.cmbAPV.Enabled = !this.get_ViewDocDamageHV();
            this.cmbCompletedWork.ReadOnly = (this.get_ViewDocDamageHV());
            this.dgvOn.ReadOnly = this.get_ViewDocDamageHV();
            this.dgvOn.AllowUserToDeleteRows = false;
            this.rbOnAverage.Enabled = this.rbOnFact.Enabled = !this.get_ViewDocDamageHV();
            this.txtCompletedWork.ReadOnly = this.get_ViewDocDamageHV();
            this.checkBoxApply.Enabled = !this.get_ViewDocDamageHV();
            this.cmbWorkerApply.ReadOnly = (this.get_ViewDocDamageHV());
            this.dtpDataApply.Enabled = !this.get_ViewDocDamageHV();
            this.cmbDivisionApply.ReadOnly = (this.get_ViewDocDamageHV());
            this.checkBoxLaboratory.Enabled = !this.get_ViewDocDamageHV();
            this.chbDefect.Enabled = !this.get_ViewDocDamageHV();
            this.txtLaboratoryInstruction.ReadOnly = this.txtDivisionInstruction.ReadOnly = !this.chbDefect.Checked && this.get_ViewDocDamageHV();
            this.toolBtnRefreshAbn.Enabled = this.toolBtnRefreshTrans.Enabled = !this.get_ViewDocDamageHV();
            this.buttonSave.Visible = !this.get_ViewDocDamageHV();
            this.buttonLoadTextBoxSum.Visible = !this.get_ViewDocDamageHV();
        }

        private DataTable method_30()
        {
            DataTable table1 = new DataTable("tR_KladrObj");
            table1.Columns.Add("id", typeof(int));
            table1.Columns.Add("name", typeof(string));
            table1.Columns.Add("socr", typeof(string));
            table1.Columns.Add("fullname", typeof(string), "name + isnull(' ' + socr, '')");
            return table1;
        }

        private DataTable method_31()
        {
            DataTable table1 = new DataTable("tR_KladrStreet");
            table1.Columns.Add("id", typeof(int));
            table1.Columns.Add("KladrObjId", typeof(int));
            table1.Columns.Add("name", typeof(string));
            table1.Columns.Add("socr", typeof(string));
            table1.Columns.Add("fullname", typeof(string), "name + isnull(' ' + socr, '')");
            return table1;
        }

        private void method_32()
        {
            this.dgvCharacterDamage.Rows.Clear();
            base.SelectSqlData(this.dataSetDamage_0.tJ_DamageCharacter, true, "where idDamage = " + this.IdDocument.ToString());
            int num = 0;
            foreach (DataRow row in this.dataSetDamage_0.tJ_DamageCharacter)
            {
                this.dgvCharacterDamage.Rows.Add();
                if (row["col1"] != DBNull.Value)
                {
                    this.dgvCharacterDamage.CurrentCell = this.dgvCharacterDamage.Rows[num].Cells[this.Column1.Name];
                    this.dgvCharacterDamage.Rows[num].Cells[this.Column1.Name].Value = row["col1"];
                    DataTable table = this.method_7();
                    if (this.tJ_DamageCharacterDataTable_0 != null)
                    {
                        DataRow[] rowArray = this.tJ_DamageCharacterDataTable_0.Select("id = " + row["id"].ToString());
                        if ((rowArray.Length != 0) && (rowArray[0]["col2"] != DBNull.Value))
                        {
                            base.SelectSqlData(table, true, string.Format(" where (parentId = {0} and isGroup = 1 and Deleted = 0) or (id = {1}) order by parentKey", row["col1"], rowArray[0]["col2"]));
                        }
                        else
                        {
                            base.SelectSqlData(table, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", row["col1"]));
                        }
                    }
                    else
                    {
                        base.SelectSqlData(table, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", row["col1"]));
                    }
                    DataGridViewComboBoxCell cell1 = this.dgvCharacterDamage[this.Column2.Index, num] as DataGridViewComboBoxCell;
                    cell1.DataSource = table;
                    cell1.DisplayMember = "name";
                    cell1.ValueMember = "id";
                }
                if (row["col2"] != DBNull.Value)
                {
                    this.dgvCharacterDamage.CurrentCell = this.dgvCharacterDamage.Rows[num].Cells[this.Column1.Name];
                    this.dgvCharacterDamage.Rows[num].Cells[this.Column2.Name].Value = row["col2"];
                    DataTable table2 = this.method_7();
                    if (this.tJ_DamageCharacterDataTable_0 != null)
                    {
                        DataRow[] rowArray2 = this.tJ_DamageCharacterDataTable_0.Select("id = " + row["id"].ToString());
                        if ((rowArray2.Length != 0) && (rowArray2[0]["col3"] != DBNull.Value))
                        {
                            base.SelectSqlData(table2, true, string.Format(" where (parentId = {0} and isGroup = 1 and Deleted = 0) or (id = {1}) order by parentKey", row["col2"], rowArray2[0]["col3"]));
                        }
                        else
                        {
                            base.SelectSqlData(table2, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", row["col2"]));
                        }
                    }
                    else
                    {
                        base.SelectSqlData(table2, true, string.Format(" where parentId = {0} and isGroup = 1 and Deleted = 0 order by parentKey", row["col2"]));
                    }
                    DataGridViewComboBoxCell cell2 = this.dgvCharacterDamage[this.Column3.Index, num] as DataGridViewComboBoxCell;
                    cell2.DataSource = table2;
                    cell2.DisplayMember = "name";
                    cell2.ValueMember = "id";
                }
                if (row["col3"] != DBNull.Value)
                {
                    this.dgvCharacterDamage.Rows[num].Cells[this.Column3.Name].Value = row["col3"];
                }
                if (row["idSchmObj"] != DBNull.Value)
                {
                    this.dgvCharacterDamage[this.columnIdSchmObj.Index, num].Value = row["idSchmObj"];
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
                    base.SelectSqlData(table3, true, "where idObjList = " + row["idSchmObj"].ToString() + " order by number");
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

        private void method_33()
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
                base.SelectSqlData(table, true, "where ParentId in (select id from \r\n                                        tr_classifier where ParentKey = ';ReportDaily;NatureDamage;HV;') \r\n                                        and isGroup = 1 and deleted = 0 order by ParentKey");
            }
            else
            {
                base.SelectSqlData(table, true, string.Format("where (ParentId in (select id from \r\n                                        tr_classifier where ParentKey = ';ReportDaily;NatureDamage;HV;') \r\n                                        and isGroup = 1 and deleted = 0) or \r\n                                        (id in ({0})) order by ParentKey", str));
            }
            BindingSource source = new BindingSource
            {
                DataSource = table,
                Position = -1
            };
            this.Column1.DisplayMember = "name";
            this.Column1.ValueMember = "id";
            this.Column1.DataSource = source;
        }

        private void method_34()
        {
            if (!this.get_ViewDocDamageHV() && this.checkBoxApply.Checked)
            {
                this.txtNumRequest.ReadOnly = true;
                this.dtpDateDoc.Enabled = false;
                this.cmbCompiler.ReadOnly = (true);
                this.cmbDivision.ReadOnly = (true);
                this.btnChoiceSchmObj.Enabled = false;
                this.dgvCharacterDamage.ReadOnly = true;
                this.dgvCharacterDamage.AllowUserToDeleteRows = false;
                this.txtLocation.ReadOnly = true;
                this.cmbReason.ReadOnly = (true);
                this.cmbTypeRZA.ReadOnly = (true);
                this.txtCoefSeason.ReadOnly = true;
                this.txtCosFi.ReadOnly = true;
                this.txtV.ReadOnly = true;
                this.txtA.ReadOnly = true;
                this.txtKWT.ReadOnly = true;
                this.txtCountSchmObj.ReadOnly = true;
                this.cmbAVR.Enabled = false;
                this.cmbAPV.Enabled = false;
                this.ColumnBtn.Visible = false;
                this.toolBtnRefreshTrans.Enabled = false;
                this.toolBtnRefreshAbn.Enabled = false;
                this.cmbCompletedWork.ReadOnly = (true);
                this.dgvOn.ReadOnly = true;
                this.dgvOn.AllowUserToDeleteRows = false;
                this.rbOnFact.Enabled = false;
                this.rbOnAverage.Enabled = false;
                this.txtCompletedWork.ReadOnly = true;
                this.checkBoxApply.Enabled = false;
                this.cmbWorkerApply.ReadOnly = (true);
                this.dtpDataApply.Enabled = false;
                this.buttonLoadTextBoxSum.Visible = false;
            }
        }

        private decimal method_35(int int_1)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtCosFi.Text))
                {
                    return decimal.Zero;
                }
                if (string.IsNullOrEmpty(this.txtA.Text))
                {
                    return decimal.Zero;
                }
                if (string.IsNullOrEmpty(this.txtV.Text))
                {
                    return decimal.Zero;
                }
                if (string.IsNullOrEmpty(this.txtCountSchmObj.Text))
                {
                    return decimal.Zero;
                }
                if (string.IsNullOrEmpty(this.txtCoefSeason.Text))
                {
                    return decimal.Zero;
                }
                if (this.dgvOn[this.dateOnDgvColumn.Name, int_1].Value == DBNull.Value)
                {
                    return decimal.Zero;
                }
                if (this.dgvOn[this.countSchmObjDgvColumn.Name, int_1].Value == DBNull.Value)
                {
                    return decimal.Zero;
                }
                int num = 0;
                for (int i = 0; i < int_1; i++)
                {
                    num += Convert.ToInt32(this.dgvOn[this.countSchmObjDgvColumn.Name, i].Value);
                }
                DateTime time = Convert.ToDateTime(this.dgvOn[this.dateOnDgvColumn.Name, int_1].Value);
                time = time.AddSeconds((double)-time.Second);
                DateTime time2 = (int_1 > 0) ? Convert.ToDateTime(this.dgvOn[this.dateOnDgvColumn.Name, int_1 - 1].Value) : this.dtpDateDoc.Value;
                TimeSpan span = (TimeSpan)(time - time2.AddSeconds((double)-time2.Second));
                decimal num2 = Convert.ToDecimal(span.TotalHours);
                decimal num3 = (((((Convert.ToDecimal(Math.Sqrt(3.0)) * (Convert.ToDecimal(this.txtA.Text) / Convert.ToInt32(this.txtCountSchmObj.Text))) * Convert.ToDecimal(this.txtV.Text)) * num2) * Convert.ToDecimal(this.txtCosFi.Text)) * (Convert.ToInt32(this.txtCountSchmObj.Text) - num)) * Convert.ToDecimal(this.txtCoefSeason.Text);
                return Convert.ToDecimal(num3.ToString("0.##"));
            }
            catch
            {
                return decimal.Zero;
            }
        }

        private void method_36()
        {
            if (this.rbOnAverage.Checked)
            {
                for (int i = 0; i < (this.dgvOn.Rows.Count - 1); i++)
                {
                    this.dgvOn[this.noAdmissionKWTDgvColumn.Name, i].Value = this.method_35(i);
                }
            }
            this.method_42();
            this.method_39();
            this.method_38();
            this.method_37();
        }

        private void method_37()
        {
            decimal num = new decimal();
            for (int i = 0; i < (this.dgvOn.Rows.Count - 1); i++)
            {
                if (this.dgvOn[this.noAdmissionKWTDgvColumn.Name, i].Value != DBNull.Value)
                {
                    num += Convert.ToDecimal(this.dgvOn[this.noAdmissionKWTDgvColumn.Name, i].Value);
                }
            }
            this.txtNoKWT.Text = num.ToString("0.##");
        }

        private void method_38()
        {
            if (!string.IsNullOrEmpty(this.txtCountSchmObj.Text))
            {
                int num = this.method_41();
                this.txtCountSchmObjOff.Text = (Convert.ToInt32(this.txtCountSchmObj.Text) - num).ToString();
                if (num != 0)
                {
                    this.label_13.Text = string.Format("Недопуск эл. энергии, кВт*ч ({0} тр.)", num);
                }
            }
        }

        private void method_39()
        {
            for (int i = 0; i < (this.dgvOn.Rows.Count - 1); i++)
            {
                this.dgvOn[this.countSchmObjOffDgvColumn.Name, i].Value = this.method_40(i);
            }
        }

        private void method_4()
        {
            if (this.IdDocument > 0)
            {
                dsDamage.tJ_DamageDataTable table = new dsDamage.tJ_DamageDataTable();
                base.SelectSqlData(table, true, string.Format("where idParent = {0} and TypeDoc = {1} and idDivisionApply is not null and isApply = 1 ", this.IdDocument, 0x734));
                if (table.Rows.Count > 0)
                {
                    this.chbDefect.Enabled = false;
                    this.cmbDivisionApply.ReadOnly = (true);
                    this.txtDivisionInstruction.ReadOnly = true;
                }
                base.SelectSqlData(table, true, string.Format("where idParent = {0} and TypeDoc = {1} and isLaboratory is not null and isApply = 1 ", this.IdDocument, 0x734));
                if (table.Rows.Count > 0)
                {
                    this.chbDefect.Enabled = false;
                    this.checkBoxLaboratory.Enabled = false;
                    this.txtLaboratoryInstruction.ReadOnly = true;
                }
            }
        }

        private int method_40(int int_1)
        {
            int num = 0;
            if (!string.IsNullOrEmpty(this.txtCountSchmObj.Text))
            {
                num = Convert.ToInt32(this.txtCountSchmObj.Text);
                for (int i = 0; i < int_1; i++)
                {
                    num -= Convert.ToInt32(this.dgvOn[this.countSchmObjDgvColumn.Name, i].Value);
                }
            }
            return num;
        }

        private int method_41()
        {
            int num = 0;
            for (int i = 0; i < (this.dgvOn.Rows.Count - 1); i++)
            {
                if (this.dgvOn[this.countSchmObjDgvColumn.Name, i].Value != DBNull.Value)
                {
                    num += Convert.ToInt32(this.dgvOn[this.countSchmObjDgvColumn.Name, i].Value);
                }
            }
            return num;
        }

        private void method_42()
        {
            for (int i = 0; i < (this.dgvOn.Rows.Count - 1); i++)
            {
                if (i == 0)
                {
                    this.dgvOn[this.dateBegDgvColumn.Name, i].Value = this.dtpDateDoc.Value;
                }
                else
                {
                    this.dgvOn[this.dateBegDgvColumn.Name, i].Value = this.dgvOn[this.dateOnDgvColumn.Name, i - 1].Value;
                }
            }
        }

        private void method_43(TreeNodeObj treeNodeObj_0, List<int> list_1)
        {
            if ((treeNodeObj_0.Tag != null) && (treeNodeObj_0.Tag is ElectricLine))
            {
                using (List<ElectricRelation>.Enumerator enumerator = ((ElectricLine)treeNodeObj_0.Tag).Relations.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        foreach (ElectricObject obj2 in enumerator.Current.ChildObjects)
                        {
                            if (((obj2 is ElectricSwitch) && (((ElectricSwitch)obj2).TypeSwitch == TypeSwitch.TransformerTool/*0x22c*/)) && !list_1.Contains(obj2.Id))
                            {
                                list_1.Add(obj2.Id);
                            }
                        }
                    }
                }
            }
            foreach (TreeNodeObj obj3 in treeNodeObj_0.Nodes)
            {
                this.method_43(obj3, list_1);
            }
        }

        private void method_44(List<int> list_1)
        {
            this.tableTrans.Clear();
            using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(Library.ResourceReader.GetStringAssembly("Documents.Forms.DailyReport.SqlScripts.GetTransformerSchmObj.sql"), connection))
                {
                    command.CommandTimeout = 0;
                    DataTable dataTable = new DataTable();
                    new SqlDataAdapter(command).Fill(dataTable);
                    int num = 0;
                    foreach (int num2 in list_1)
                    {
                        DataRow[] rowArray = dataTable.Select("id = " + num2.ToString());
                        if (rowArray.Length != 0)
                        {
                            DataRow row = this.tableTrans.NewRow();
                            row["idTR"] = rowArray[0]["id"];
                            row["TrNAme"] = rowArray[0]["Наименование"];
                            row["idSub"] = rowArray[0]["idSub"];
                            row["Sub"] = rowArray[0]["Расположение"];
                            if ((rowArray[0]["Мощность"] != DBNull.Value) && !string.IsNullOrEmpty(rowArray[0]["Мощность"].ToString()))
                            {
                                row["Power"] = rowArray[0]["Мощность"];
                            }
                            if ((rowArray[0]["Мощность"] != DBNull.Value) && !string.IsNullOrEmpty(rowArray[0]["Мощность"].ToString()))
                            {
                                num += Convert.ToInt32(rowArray[0]["Мощность"]);
                            }
                            this.tableTrans.Rows.Add(row);
                        }
                    }
                }
                using (SqlCommand command2 = new SqlCommand("SELECT mat.idbus, mat.[IdObjList],\r\n                        \t(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) \r\n                        \t then max([Ia]) \telse case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) \r\n                        \t\t\t\t\t                                else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) \r\n                        \t\t\t\t\t                                then max([Ic]) end end end) as I\r\n                         FROM [tJ_MeasAmperageTransf] as mat\r\n                               inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n                          where  mat.deleted = 0 and m.[TypeDoc] = 1192\r\n                        \tand ((year(m.[DateD]) = \r\n                        \t\t\t(select case when month(max(dateD)) = 12 then year(max(dateD)) + 1\r\n                        \t\t\t\t\telse year(max(dateD)) end from tj_measurement mes \r\n                        \t\t\tleft join [tJ_MeasAmperageTransf] mt on mt.[idMeasurement] = mes.id\r\n                        \t\t\t where mt.idBus = mat.idBus and mt.deleted = 0 and m.typeDoc = 1192\t\r\n                        \t\t\t and  mt.[Ia] is not null and  mt.[Ib] is not null and  mt.[Ic] is not null)\r\n                                      and month(m.[DateD]) between 1 and 11)\t\r\n                           or (year(m.[DateD]) =(select case when month(max(dateD)) = 12 then year(max(dateD)) + 1\r\n                        \telse year(max(dateD)) end\r\n                        \tfrom tj_measurement mes \r\n                        \tleft join [tJ_MeasAmperageTransf] mt on mt.[idMeasurement] = mes.id\r\n                        \twhere mt.idBus = mat.idBus and mt.deleted = 0 and m.typeDoc = 1192\r\n                        \t and  mt.[Ia] is not null and  mt.[Ib] is not null and  mt.[Ic] is not null)-1 and month(m.[DateD])=12)) \r\n                            and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n                          group by mat.idBus,  mat.[idObjList]", connection))
                {
                    command2.CommandTimeout = 0;
                    DataTable table2 = new DataTable();
                    new SqlDataAdapter(command2).Fill(table2);
                    foreach (DataRow row2 in this.tableTrans.Rows)
                    {
                        DataRow[] rowArray2 = table2.Select("idObjList = " + row2["idTr"].ToString());
                        if (rowArray2.Length != 0)
                        {
                            row2["Load"] = rowArray2[0]["I"];
                        }
                    }
                }
            }
        }

        private void method_45()
        {
            if ((this.dataSetDamage_0.tJ_Damage.Rows.Count > 0) && (this.dataSetDamage_0.tJ_Damage.Rows[0]["idSchmObj"] != DBNull.Value))
            {
                this.progressBar.Visible = true;
                this.labelProgress.Visible = true;
                this.toolBtnRefreshTrans.Enabled = false;
                this.toolBtnRefreshAbn.Enabled = false;
                this.btnChoiceSchmObj.Enabled = false;
                this.dtpDateDoc.Enabled = false;
                this.dgvTrans.Enabled = false;
                this.dgvTrans.DataSource = null;
                this.dgvTree.Enabled = false;
                this.dgvAbn.Enabled = false;
                this.dgvAbn.DataSource = null;
                this.buttonSave.Enabled = false;
                this.buttonClose.Enabled = false;
                this.backgroundWorker_0.RunWorkerAsync(this.dtpDateDoc.Value);
            }
            else
            {
                this.tableTrans.Clear();
                this.table_vl_SchmAbnFull.Clear();
            }
        }

        private XmlDocument method_46()
        {
            XmlDocument document = new XmlDocument();
            XmlNode newChild = document.CreateElement("TransOff");
            document.AppendChild(newChild);
            foreach (DataRow row in this.tableTrans.Rows)
            {
                XmlNode node2 = document.CreateElement("Row");
                newChild.AppendChild(node2);
                XmlAttribute node = document.CreateAttribute("idSub");
                node.Value = row["idSub"].ToString();
                node2.Attributes.Append(node);
                node = document.CreateAttribute("idTr");
                node.Value = row["idTr"].ToString();
                node2.Attributes.Append(node);
                node = document.CreateAttribute("Power");
                node.Value = row["Power"].ToString();
                node2.Attributes.Append(node);
                node = document.CreateAttribute("Load");
                node.Value = row["Load"].ToString();
                node2.Attributes.Append(node);
            }
            this.method_56(document);
            return document;
        }

        private void method_47()
        {
            this.tableTrans.Clear();
            if ((this.dataSetDamage_0.tJ_DamageHV.Rows.Count > 0) && (this.dataSetDamage_0.tJ_DamageHV.Rows[0]["TransOff"] != DBNull.Value))
            {
                try
                {
                    XmlDocument document = new XmlDocument();
                    document.LoadXml(this.dataSetDamage_0.tJ_DamageHV.Rows[0]["TransOff"].ToString());
                    XmlNode node = document.SelectSingleNode("TransOff");
                    if (node != null)
                    {
                        List<string> list = new List<string>();
                        List<string> list2 = new List<string>();
                        //using (IEnumerator enumerator = node.SelectNodes("Row").GetEnumerator())
                        //{
                        //    while (enumerator.MoveNext())
                        //    {
                        foreach (IEnumerator enumerator in node.SelectNodes("Row"))
                        {
                            DataRow row = this.tableTrans.NewRow();
                            XmlNode current = (XmlNode)enumerator.Current;
                            XmlAttribute attribute = current.Attributes["idSub"];
                            if ((attribute != null) && !string.IsNullOrEmpty(attribute.Value))
                            {
                                row["idSub"] = attribute.Value;
                                list.Add(attribute.Value);
                            }
                            attribute = current.Attributes["idTr"];
                            if ((attribute != null) && !string.IsNullOrEmpty(attribute.Value))
                            {
                                row["idTr"] = attribute.Value;
                                list2.Add(attribute.Value);
                            }
                            attribute = current.Attributes["Power"];
                            if ((attribute != null) && !string.IsNullOrEmpty(attribute.Value))
                            {
                                row["Power"] = attribute.Value;
                            }
                            attribute = current.Attributes["Load"];
                            if ((attribute != null) && !string.IsNullOrEmpty(attribute.Value))
                            {
                                row["Load"] = attribute.Value;
                            }
                            this.tableTrans.Rows.Add(row);
                        }
                        //}
                        DataTable table = new DataTable("vSchm_ObjList");
                        table.Columns.Add("id", typeof(int));
                        table.Columns.Add("name", typeof(string));
                        table.Columns.Add("typeCodeSocr", typeof(string));
                        table.Columns.Add("fullname", typeof(string), "typeCodeSocr + '-'+name");
                        if (list.Count > 0)
                        {
                            base.SelectSqlData(table, true, " where id in (" + string.Join(",", list.ToArray()) + ")");
                        }
                        DataTable table2 = new DataTable("tSchm_ObjList");
                        table2.Columns.Add("id", typeof(int));
                        table2.Columns.Add("name", typeof(string));
                        if (list2.Count > 0)
                        {
                            base.SelectSqlData(table2, true, " where id in (" + string.Join(",", list2.ToArray()) + ")");
                        }
                        if ((table.Rows.Count > 0) || (table2.Rows.Count > 0))
                        {
                            foreach (DataRow row2 in this.tableTrans.Rows)
                            {
                                if (row2["idSub"] != DBNull.Value)
                                {
                                    DataRow[] rowArray = table.Select("id = " + row2["idSub"].ToString());
                                    if (rowArray.Length != 0)
                                    {
                                        row2["Sub"] = rowArray[0]["FullName"];
                                    }
                                }
                                if (row2["idTr"] != DBNull.Value)
                                {
                                    DataRow[] rowArray2 = table2.Select("id = " + row2["idTr"].ToString());
                                    if (rowArray2.Length != 0)
                                    {
                                        row2["TrName"] = rowArray2[0]["Name"];
                                    }
                                }
                            }
                        }
                        this.labelCountTr.Text = "Кол-во трансформаторов: " + this.tableTrans.Rows.Count.ToString();
                        this.labelSumPower.Text = "Суммарная мощность: " + this.tableTrans.Compute("Sum(Power)", "").ToString();
                        this.labelSumLoad.Text = "Суммарная нагрузка: " + this.tableTrans.Compute("Sum(Load)", "").ToString();
                        this.method_58(document);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        private void method_48()
        {
            this.txtKWT.Text = this.tableTrans.Compute("Sum(Power)", "").ToString();
            this.labelSumPower.Text = "Суммарная мощность: " + this.tableTrans.Compute("Sum(Power)", "").ToString();
        }

        private void method_49()
        {
            this.txtA.Text = this.tableTrans.Compute("Sum(Load)", "").ToString();
            this.labelSumLoad.Text = "Суммарная нагрузка: " + this.tableTrans.Compute("Sum(Load)", "").ToString();
        }

        private void method_5()
        {
            if (this.IdDocument > 0)
            {
                this.tJ_DamageDataTable_0 = new dsDamage.tJ_DamageDataTable();
                base.SelectSqlData(this.tJ_DamageDataTable_0, true, "where id = " + this.IdDocument.ToString());
                this.tJ_DamageCharacterDataTable_0 = new dsDamage.tJ_DamageCharacterDataTable();
                base.SelectSqlData(this.tJ_DamageCharacterDataTable_0, true, "where idDamage = " + this.IdDocument.ToString());
            }
        }

        private void method_50()
        {
            if (this.tableTrans.Rows.Count == 0)
            {
                this.txtCountSchmObj.Text = string.Empty;
            }
            else
            {
                this.txtCountSchmObj.Text = this.tableTrans.Rows.Count.ToString();
            }
            this.labelCountTr.Text = "Кол-во трансформаторов: " + this.tableTrans.Rows.Count.ToString();
            this.method_48();
            this.method_49();
        }

        private void method_51()
        {
            if (this.dataSetDamage_0.tJ_Damage.Rows.Count > 0)
            {
                if (this.dataSetDamage_0.tJ_Damage.Rows[0]["idReqForRepair"] != DBNull.Value)
                {
                    DataTable table = base.SelectSqlData("tj_requestForRepair", true, "where id = " + this.dataSetDamage_0.tJ_Damage.Rows[0]["idReqForRepair"].ToString());
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

        private void method_52(object sender, GoToSchemaEventArgs e)
        {
            this.OnGoToSchema(e);
        }

        private void method_53()
        {
            if (this.dgvTree.InvokeRequired)
            {
                this.dgvTree.Invoke(new MethodInvoker(this.method_53));
            }
            else
            {
                this.dgvTree.Nodes.Clear();
            }
        }

        private TreeDataGridViewNode method_54(TreeDataGridViewNodeCollection treeDataGridViewNodeCollection_0, params object[] object_0)
        {
            if (this.dgvTree.InvokeRequired)
            {
                object[] args = new object[] { treeDataGridViewNodeCollection_0, object_0 };
                return (TreeDataGridViewNode)this.dgvTree.Invoke(new Delegate114(this.method_54), args);
            }
            return treeDataGridViewNodeCollection_0.Add(object_0);
        }

        private void method_55(TreeDataGridViewNode treeDataGridViewNode, TreeNodeObj treeNodeObj)
        {
            if (treeNodeObj.Tag != null)
            {
                if (treeNodeObj.Tag is ElectricBus)
                {
                    if (this.list_0.Contains(((ElectricBus)treeNodeObj.Tag).Id))
                    {
                        return;
                    }
                    this.list_0.Add(((ElectricBus)treeNodeObj.Tag).Id);
                }
                if (treeNodeObj.Tag is ElectricLine)
                {
                    ElectricLine tag = (ElectricLine)treeNodeObj.Tag;
                    if (tag.IsCell())
                    {
                        ElectricBus bus = null;
                        foreach (ElectricPoint point in tag.Ends)
                        {
                            if (point.Parent is ElectricBus)
                            {
                                bus = (ElectricBus)point.Parent;

                                if (bus.TypeBus == eTypeShinaTool.Shina_10 || bus.TypeBus == eTypeShinaTool.Shina_110 || bus.TypeBus == eTypeShinaTool.Shina_35)
                                {
                                    break;
                                }
                                if (bus.TypeBus == eTypeShinaTool.Shina_6)
                                {
                                    break;
                                }
                                bus = null;
                            }
                        }
                        if (bus != null)
                        {
                            if (treeDataGridViewNode == null)
                            {
                                object[] objArray1 = new object[] { bus.Parent.ToString(), bus.Parent.Id, bus.ToString(), bus.Id, tag.ToString(), tag.Id };
                                treeDataGridViewNode = this.method_54(this.dgvTree.Nodes, objArray1);
                            }
                            else
                            {
                                object[] objArray2 = new object[] { bus.Parent.ToString(), bus.Parent.Id, bus.ToString(), bus.Id, tag.ToString(), tag.Id };
                                treeDataGridViewNode = this.method_54(treeDataGridViewNode.Nodes, objArray2);
                            }
                        }
                    }
                    //using (List<ElectricRelation>.Enumerator enumerator2 = ((ElectricLine)treeNodeObj_0.Tag).Relations.GetEnumerator())
                    {
                        //while (enumerator2.MoveNext())
                        foreach (ElectricRelation electricRelation in ((ElectricLine)treeNodeObj.Tag).Relations)
                        {
                            foreach (ElectricObject obj2 in electricRelation.ChildObjects)
                            //foreach (ElectricObject obj2 in enumerator2.Current.ChildObjects)
                            {
                                if (((obj2 is ElectricSwitch) && (((ElectricSwitch)obj2).TypeSwitch == TypeSwitch.TransformerTool/*0x22c*/)) && (treeDataGridViewNode != null))
                                {
                                    int num;
                                    //int? nullable3;
                                    //int? nullable4;
                                    if ((treeDataGridViewNode.Cells[this.idTrColumn.Index].Value != null) && !string.IsNullOrEmpty(treeDataGridViewNode.Cells[this.idTrColumn.Index].Value.ToString()))
                                    {
                                        object[] objArray3 = new object[]
                                        {
                                        treeDataGridViewNode.Cells[this.subNameColumn.Index].Value,
                                        treeDataGridViewNode.Cells[this.idSubColumn.Index].Value,
                                        treeDataGridViewNode.Cells[this.busNameColumn.Index].Value,
                                        treeDataGridViewNode.Cells[this.idBusColumn.Index].Value,
                                        treeDataGridViewNode.Cells[this.cellNameColumn.Index].Value,
                                        treeDataGridViewNode.Cells[this.idCellColumn.Index].Value
                                        };
                                        treeDataGridViewNode = treeDataGridViewNode.Parent.Nodes.Add(objArray3);
                                    }
                                    DataRow[] rowArray = this.tableTrans.Select("idTr = " + obj2.Id.ToString());
                                    int? power = null;
                                    int? load = null;
                                    if (rowArray.Length != 0)
                                    {
                                        if (rowArray[0]["power"] != DBNull.Value)
                                        {
                                            power = new int?(Convert.ToInt32(rowArray[0]["power"]));
                                        }
                                        if (rowArray[0]["load"] != DBNull.Value)
                                        {
                                            load = new int?(Convert.ToInt32(rowArray[0]["load"]));
                                        }
                                    }
                                    if (power.HasValue)
                                    {
                                        if ((treeDataGridViewNode.Cells[8].Value != null) && !string.IsNullOrEmpty(treeDataGridViewNode.Cells[8].Value.ToString()))
                                        {
                                            num = Convert.ToInt32(treeDataGridViewNode.Cells[8].Value);

                                            //nullable3 = power;
                                            //treeDataGridViewNode_0.Cells[8].Value = nullable3.HasValue ? new int?(num + nullable3.GetValueOrDefault()) : (nullable4 = null);

                                            treeDataGridViewNode.Cells[8].Value = new int?(num + power.GetValueOrDefault());
                                        }
                                        else
                                        {
                                            treeDataGridViewNode.Cells[8].Value = power;
                                        }
                                    }
                                    if (load.HasValue)
                                    {
                                        if ((treeDataGridViewNode.Cells[9].Value != null) && !string.IsNullOrEmpty(treeDataGridViewNode.Cells[9].Value.ToString()))
                                        {
                                            num = Convert.ToInt32(treeDataGridViewNode.Cells[9].Value);

                                            //nullable3 = load;
                                            //treeDataGridViewNode_0.Cells[9].Value = nullable3.HasValue ? new int?(num + nullable3.GetValueOrDefault()) : (nullable4 = null);

                                            treeDataGridViewNode.Cells[9].Value = new int?(num + load.GetValueOrDefault());
                                        }
                                        else
                                        {
                                            treeDataGridViewNode.Cells[9].Value = load;
                                        }
                                    }
                                    if ((treeDataGridViewNode.Cells[6].Value != null) && !string.IsNullOrEmpty(treeDataGridViewNode.Cells[6].Value.ToString()))
                                    {
                                        DataGridViewCell cell1 = treeDataGridViewNode.Cells[6];
                                        cell1.Value = cell1.Value + ";" + obj2.ToString();
                                        DataGridViewCell cell2 = treeDataGridViewNode.Cells[7];
                                        cell2.Value = cell2.Value + ";" + obj2.Id;
                                    }
                                    else
                                    {
                                        treeDataGridViewNode.Cells[6].Value = obj2.ToString();
                                        treeDataGridViewNode.Cells[7].Value = obj2.Id;
                                    }
                                }
                            }//foreach
                        }// while
                    }// using
                }
            }
            foreach (TreeNodeObj obj3 in treeNodeObj.Nodes)
            {
                this.method_55(treeDataGridViewNode, obj3);
            }
        }

        private void method_56(XmlDocument xmlDocument_0)
        {
            XmlNode node = xmlDocument_0.SelectSingleNode("TransOff");
            if (node != null)
            {
                XmlNode newChild = xmlDocument_0.CreateElement("TransTree");
                node.AppendChild(newChild);
                foreach (TreeDataGridViewNode node3 in this.dgvTree.Nodes)
                {
                    this.method_57(node3, newChild);
                }
            }
        }

        private void method_57(TreeDataGridViewNode treeDataGridViewNode_0, XmlNode xmlNode_0)
        {
            XmlNode newChild = xmlNode_0.OwnerDocument.CreateElement("NodeDgv");
            xmlNode_0.AppendChild(newChild);
            foreach (DataGridViewColumn column in this.dgvTree.Columns)
            {
                if (!string.IsNullOrEmpty(column.DataPropertyName) && (treeDataGridViewNode_0.Cells[column.Index].Value != null))
                {
                    XmlAttribute node = xmlNode_0.OwnerDocument.CreateAttribute(column.DataPropertyName);
                    node.Value = treeDataGridViewNode_0.Cells[column.Index].Value.ToString();
                    newChild.Attributes.Append(node);
                }
            }
            foreach (TreeDataGridViewNode node2 in treeDataGridViewNode_0.Nodes)
            {
                this.method_57(node2, newChild);
            }
        }

        private void method_58(XmlDocument xmlDocument_0)
        {
            XmlNode node = xmlDocument_0.SelectSingleNode("TransOff");
            if (node != null)
            {
                XmlNode node2 = node.SelectSingleNode("TransTree");
                if (node2 != null)
                {
                    foreach (XmlNode node3 in node2.SelectNodes("NodeDgv"))
                    {
                        this.method_59(node3, this.dgvTree.Nodes);
                    }
                }
            }
        }

        private void method_59(XmlNode xmlNode_0, TreeDataGridViewNodeCollection treeDataGridViewNodeCollection_0)
        {
            TreeDataGridViewNode node = treeDataGridViewNodeCollection_0.Add(new object[0]);
            foreach (DataGridViewColumn column in this.dgvTree.Columns)
            {
                if (!string.IsNullOrEmpty(column.DataPropertyName))
                {
                    XmlAttribute attribute = xmlNode_0.Attributes[column.DataPropertyName];
                    if ((attribute != null) && !string.IsNullOrEmpty(attribute.Value))
                    {
                        node.Cells[column.Index].Value = attribute.Value;
                    }
                }
            }
            foreach (XmlNode node2 in xmlNode_0.SelectNodes("NodeDgv"))
            {
                this.method_59(node2, node.Nodes);
            }
        }

        private void method_6()
        {
            DataRow row = this.dataSetDamage_0.tJ_DamageHV.NewRow();
            row["idDamage"] = this.IdDocument;
            row["CoefFI"] = 0.9;
            row["CoefSeason"] = 0.8;
            this.dataSetDamage_0.tJ_DamageHV.Rows.Add(row);
        }

        private decimal method_60(TreeDataGridViewNodeCollection treeDataGridViewNodeCollection_0)
        {
            decimal num = new decimal();
            foreach (TreeDataGridViewNode node in treeDataGridViewNodeCollection_0)
            {
                decimal num2 = this.method_60(node.Nodes);
                node.Cells[this.noAdmissionKWTColumn.Index].Value = num2;
                num += num2;
                if ((!string.IsNullOrEmpty(this.txtV.Text) && (node.Cells[this.loadColumn.Index].Value != null)) && (node.Cells[this.dateOnColumn.Index].Value != null))
                {
                    TimeSpan span = (TimeSpan)(Convert.ToDateTime(node.Cells[this.dateOnColumn.Index].Value) - this.dtpDateDoc.Value.AddSeconds((double)-this.dtpDateDoc.Value.Second));
                    decimal num3 = Convert.ToDecimal(span.TotalHours);
                    decimal num5 = Convert.ToDecimal((((((Convert.ToDecimal(Math.Sqrt(3.0)) * Convert.ToDecimal(node.Cells[this.loadColumn.Index].Value)) * Convert.ToDecimal(this.txtV.Text)) * num3) * Convert.ToDecimal(this.txtCosFi.Text)) * Convert.ToDecimal(this.txtCoefSeason.Text)).ToString("0.##"));
                    node.Cells[this.noAdmissionKWTColumn.Index].Value = num5;
                    num += num5;
                }
            }
            return num;
        }

        private void method_61(TreeDataGridViewNode treeDataGridViewNode_0, DateTime? nullable_0)
        {
            if (treeDataGridViewNode_0 != null)
            {
                if (!nullable_0.HasValue)
                {
                    treeDataGridViewNode_0.Cells[this.dateOnColumn.Index].Value = null;
                }
                else
                {
                    treeDataGridViewNode_0.Cells[this.dateOnColumn.Index].Value = nullable_0.Value.ToString("dd.MM.yyyy HH:mm");
                }
                foreach (TreeDataGridViewNode node in treeDataGridViewNode_0.Nodes)
                {
                    this.method_61(node, nullable_0);
                }
            }
        }

        private void method_62(TreeDataGridViewNodeCollection treeDataGridViewNodeCollection_0)
        {
            foreach (TreeDataGridViewNode node in treeDataGridViewNodeCollection_0)
            {
                this.method_62(node.Nodes);
                if (((node.Cells[this.dateOnColumn.Index].Value != null) && !string.IsNullOrEmpty(node.Cells[this.dateOnColumn.Index].Value.ToString())) && ((node.Cells[this.idTrColumn.Index].Value != null) && !string.IsNullOrEmpty(node.Cells[this.idTrColumn.Index].Value.ToString())))
                {
                    DateTime time = Convert.ToDateTime(node.Cells[this.dateOnColumn.Index].Value);
                    decimal num = new decimal();
                    if (((node.Cells[this.noAdmissionKWTColumn.Index].Value != null) && !string.IsNullOrEmpty(node.Cells[this.noAdmissionKWTColumn.Index].Value.ToString())) && ((node.Cells[this.loadColumn.Index].Value != null) && !string.IsNullOrEmpty(node.Cells[this.loadColumn.Index].Value.ToString())))
                    {
                        num = Convert.ToDecimal(node.Cells[this.noAdmissionKWTColumn.Index].Value);
                    }
                    DataRow[] rowArray = this.tJ_DamageOnDataTable_0.Select("dateOn = '" + time.ToString("dd.MM.yyyy HH:mm") + "'");
                    if (rowArray.Length != 0)
                    {
                        rowArray[0]["CountSchmObj"] = Convert.ToInt32(rowArray[0]["CountSchmObj"]) + 1;
                        rowArray[0]["noAdmissionKWT"] = Convert.ToDecimal(rowArray[0]["noAdmissionKWT"]) + num;
                    }
                    else
                    {
                        DataRow row = this.tJ_DamageOnDataTable_0.NewRow();
                        row["IdDamage"] = this.method_0();
                        row["dateOn"] = time;
                        row["CountSchmObj"] = 1;
                        row["noAdmissionKWT"] = num;
                        this.tJ_DamageOnDataTable_0.Rows.Add(row);
                    }
                }
            }
        }

        private void method_63()
        {
            if (this.rbOnAverage.Checked)
            {
                this.dgvOn.DataSource = this.dataSetDamage_0.tJ_DamageOn;
                if (!this.get_ViewDocDamageHV() && !this.checkBoxApply.Checked)
                {
                    this.dgvOn.ReadOnly = false;
                    this.dgvOn.AllowUserToDeleteRows = true;
                }
            }
            else
            {
                this.tJ_DamageOnDataTable_0 = new dsDamage.tJ_DamageOnDataTable();
                this.method_62(this.dgvTree.Nodes);
                if (this.tJ_DamageOnDataTable_0.Rows.Count > 0)
                {
                    //this.dgvOn.DataSource = this.tJ_DamageOnDataTable_0
                    //    .AsEnumerable<DataSetDamage.Class332>()
                    //    .OrderBy<DataSetDamage.Class332, DateTime>((C_1.C_9__128_0 ?? (C_1.C_9__128_0 = new Func<DataSetDamage.Class332, DateTime>(C_1.C_9.method_1))))
                    //    .CopyToDataTable<DataSetDamage.Class332>();
                    this.dgvOn.DataSource = this.tJ_DamageOnDataTable_0
                        .AsEnumerable()
                        .OrderBy(r => r.Field<DateTime>("DateOn"))
                        .CopyToDataTable();
                }
                else
                {
                    this.dgvOn.DataSource = this.tJ_DamageOnDataTable_0;
                }
                this.dgvOn.ReadOnly = true;
                this.dgvOn.AllowUserToDeleteRows = false;
            }
            this.method_36();
            this.isChangedData = true;
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormDamageHVAddEdit));
            DataGridViewCellStyle style7 = new DataGridViewCellStyle();
            this.tabControlMain = new TabControl();
            this.tabPageGeneral = new TabPage();
            this.splitContainer1 = new SplitContainer();
            this.cmbAPV = new ComboBox();
            this.dataSetDamage_0 = new dsDamage();
            this.label12 = new Label();
            this.cmbAVR = new ComboBox();
            this.label8 = new Label();
            this.label_26 = new Label();
            this.txtCoefSeason = new TextBox();
            this.buttonLoadTextBoxSum = new Button();
            this.txtCosFi = new TextBox();
            this.label_18 = new Label();
            this.label_14 = new Label();
            this.txtV = new TextBox();
            this.label_15 = new Label();
            this.txtA = new TextBox();
            this.txtKWT = new TextBox();
            this.label_16 = new Label();
            this.txtCountSchmObj = new TextBox();
            this.label_17 = new Label();
            this.cmbTypeRZA = new ComboBoxReadOnly();
            this.label_10 = new Label();
            this.groupBoxDefectData = new GroupBox();
            this.btnRequestForRepair = new Button();
            this.txtDocParent = new TextBox();
            this.label_29 = new Label();
            this.label_21 = new Label();
            this.label_22 = new Label();
            this.dgvCharacterDamage = new DataGridView();
            this.Column1 = new DataGridViewComboBoxColumn();
            this.ColumnSchmObj = new DataGridViewTextBoxColumn();
            this.columnIdSchmObj = new DataGridViewTextBoxColumn();
            this.ColumnBtn = new DataGridViewButtonColumn();
            this.ColumnCabSection = new DataGridViewComboBoxColumn();
            this.Column2 = new DataGridViewComboBoxColumn();
            this.Column3 = new DataGridViewComboBoxColumn();
            this.txtLocation = new RichTextBox();
            this.cmbReason = new ComboBoxReadOnly();
            this.label_9 = new Label();
            this.btnChoiceSchmObj = new Button();
            this.labelSchmObj = new Label();
            this.txtSchmObj = new TextBox();
            this.groupBoxResult = new GroupBox();
            this.groupBoxDefect = new GroupBox();
            this.txtLaboratoryInstruction = new RichTextBox();
            this.label_23 = new Label();
            this.txtDivisionInstruction = new RichTextBox();
            this.label_24 = new Label();
            this.chbDefect = new CheckBox();
            this.label_25 = new Label();
            this.checkBoxLaboratory = new CheckBox();
            this.cmbDivisionApply = new ComboBoxReadOnly();
            this.splitContainer2 = new SplitContainer();
            this.rbOnFact = new RadioButton();
            this.rbOnAverage = new RadioButton();
            this.label_19 = new Label();
            this.label_13 = new Label();
            this.txtCountSchmObjOff = new TextBox();
            this.txtNoKWT = new TextBox();
            this.dgvOn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dateBegDgvColumn = new DataGridViewTextBoxColumn();
            this.dateOnDgvColumn = new DataGridViewFilterDateTimePickerColumn();
            this.countSchmObjDgvColumn = new DataGridViewTextBoxColumn();
            this.countSchmObjOffDgvColumn = new DataGridViewTextBoxColumn();
            this.noAdmissionKWTDgvColumn = new DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.idDamageDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.labelDamageOn = new Label();
            this.label_12 = new Label();
            this.checkBoxApply = new CheckBox();
            this.dtpDataApply = new NullableDateTimePicker();
            this.label_7 = new Label();
            this.txtCompletedWork = new RichTextBox();
            this.cmbWorkerApply = new ComboBoxReadOnly();
            this.labelCompletedWork = new Label();
            this.cmbCompletedWork = new ComboBoxReadOnly();
            this.cmbDivision = new ComboBoxReadOnly();
            this.label_0 = new Label();
            this.label_1 = new Label();
            this.cmbCompiler = new ComboBoxReadOnly();
            this.dtpDateOwner = new DateTimePicker();
            this.label_2 = new Label();
            this.label_3 = new Label();
            this.txtOwner = new TextBox();
            this.label_4 = new Label();
            this.dtpDateDoc = new DateTimePicker();
            this.label_5 = new Label();
            this.txtNumRequest = new TextBox();
            this.tabPageTransformer = new TabPage();
            this.splitContainer3 = new SplitContainer();
            this.dgvTrans = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.subDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.idSubDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.idTrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.trNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.loadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.components);
            this.dataSet_0 = new DataSet();
            this.tableTrans = new DataTable();
            this.idSub = new DataColumn();
            this.Sub = new DataColumn();
            this.idTr = new DataColumn();
            this.TrName = new DataColumn();
            this.Power = new DataColumn();
            this.load = new DataColumn();
            this.table_vl_SchmAbnFull = new DataTable();
            this.idAbn = new DataColumn();
            this.codeAbonent = new DataColumn();
            this.nameAbn = new DataColumn();
            this.typeAbn = new DataColumn();
            this.idAbnObj = new DataColumn();
            this.nameObj = new DataColumn();
            this.CommentODS = new DataColumn();
            this.dgvTree = new TreeDataGridView();
            this.subNameColumn = new TreeGridColumn();
            this.idSubColumn = new DataGridViewTextBoxColumn();
            this.busNameColumn = new DataGridViewTextBoxColumn();
            this.idBusColumn = new DataGridViewTextBoxColumn();
            this.cellNameColumn = new DataGridViewTextBoxColumn();
            this.idCellColumn = new DataGridViewTextBoxColumn();
            this.trNameColumn = new DataGridViewTextBoxColumn();
            this.idTrColumn = new DataGridViewTextBoxColumn();
            this.powerColumn = new DataGridViewTextBoxColumn();
            this.loadColumn = new DataGridViewTextBoxColumn();
            this.dateOnColumn = new DataGridViewTextBoxColumn();
            this.noAdmissionKWTColumn = new DataGridViewTextBoxColumn();
            this.statusStripTrans = new StatusStrip();
            this.labelCountTr = new ToolStripStatusLabel();
            this.labelSumPower = new ToolStripStatusLabel();
            this.labelSumLoad = new ToolStripStatusLabel();
            this.toolStripTransformer = new ToolStrip();
            this.toolBtnRefreshTrans = new ToolStripButton();
            this.tabPageAbn = new TabPage();
            this.dgvAbn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.codeAbonentDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nameAbnDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.typeAbnDgvColumn = new DataGridViewFilterComboBoxColumn();
            this.idAbnObjDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nameObjDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.commentODSDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.bindingSource_1 = new BindingSource(this.components);
            this.statusStripAbn = new StatusStrip();
            this.labelCountAbn = new ToolStripStatusLabel();
            this.labelCountAbnObj = new ToolStripStatusLabel();
            this.toolStripAbn = new ToolStrip();
            this.toolBtnRefreshAbn = new ToolStripButton();
            this.buttonClose = new Button();
            this.buttonSave = new Button();
            this.backgroundWorker_0 = new BackgroundWorker();
            this.labelProgress = new Label();
            this.progressBar = new ProgressBar();
            this.dataGridViewComboBoxColumn1 = new DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            this.dataGridViewComboBoxColumn2 = new DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn4 = new DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            this.toolTip_0 = new ToolTip(this.components);
            this.contextMenuDgvTree = new ContextMenuStrip(this.components);
            this.toolMenuItemOn = new ToolStripMenuItem();
            this.toolMenuItemOff = new ToolStripMenuItem();
            this.tabControlMain.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.dataSetDamage_0.BeginInit();
            this.groupBoxDefectData.SuspendLayout();
            ((ISupportInitialize)this.dgvCharacterDamage).BeginInit();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxDefect.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((ISupportInitialize)this.dgvOn).BeginInit();
            this.tabPageTransformer.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((ISupportInitialize)this.dgvTrans).BeginInit();
            ((ISupportInitialize)this.bindingSource_0).BeginInit();
            this.dataSet_0.BeginInit();
            this.tableTrans.BeginInit();
            this.table_vl_SchmAbnFull.BeginInit();
            ((ISupportInitialize)this.dgvTree).BeginInit();
            this.statusStripTrans.SuspendLayout();
            this.toolStripTransformer.SuspendLayout();
            this.tabPageAbn.SuspendLayout();
            ((ISupportInitialize)this.dgvAbn).BeginInit();
            ((ISupportInitialize)this.bindingSource_1).BeginInit();
            this.statusStripAbn.SuspendLayout();
            this.toolStripAbn.SuspendLayout();
            this.contextMenuDgvTree.SuspendLayout();
            base.SuspendLayout();
            this.tabControlMain.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.tabControlMain.Controls.Add(this.tabPageGeneral);
            this.tabControlMain.Controls.Add(this.tabPageTransformer);
            this.tabControlMain.Controls.Add(this.tabPageAbn);
            this.tabControlMain.Location = new Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new Size(0x3c9, 0x285);
            this.tabControlMain.TabIndex = 0;
            this.tabPageGeneral.Controls.Add(this.splitContainer1);
            this.tabPageGeneral.Controls.Add(this.cmbDivision);
            this.tabPageGeneral.Controls.Add(this.label_0);
            this.tabPageGeneral.Controls.Add(this.label_1);
            this.tabPageGeneral.Controls.Add(this.cmbCompiler);
            this.tabPageGeneral.Controls.Add(this.dtpDateOwner);
            this.tabPageGeneral.Controls.Add(this.label_2);
            this.tabPageGeneral.Controls.Add(this.label_3);
            this.tabPageGeneral.Controls.Add(this.txtOwner);
            this.tabPageGeneral.Controls.Add(this.label_4);
            this.tabPageGeneral.Controls.Add(this.dtpDateDoc);
            this.tabPageGeneral.Controls.Add(this.label_5);
            this.tabPageGeneral.Controls.Add(this.txtNumRequest);
            this.tabPageGeneral.Location = new Point(4, 0x16);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new Padding(3);
            this.tabPageGeneral.Size = new Size(0x3c1, 0x26b);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Общий";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            this.splitContainer1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.splitContainer1.Location = new Point(3, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add(this.cmbAPV);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.cmbAVR);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label_26);
            this.splitContainer1.Panel1.Controls.Add(this.txtCoefSeason);
            this.splitContainer1.Panel1.Controls.Add(this.buttonLoadTextBoxSum);
            this.splitContainer1.Panel1.Controls.Add(this.txtCosFi);
            this.splitContainer1.Panel1.Controls.Add(this.label_18);
            this.splitContainer1.Panel1.Controls.Add(this.label_14);
            this.splitContainer1.Panel1.Controls.Add(this.txtV);
            this.splitContainer1.Panel1.Controls.Add(this.label_15);
            this.splitContainer1.Panel1.Controls.Add(this.txtA);
            this.splitContainer1.Panel1.Controls.Add(this.txtKWT);
            this.splitContainer1.Panel1.Controls.Add(this.label_16);
            this.splitContainer1.Panel1.Controls.Add(this.txtCountSchmObj);
            this.splitContainer1.Panel1.Controls.Add(this.label_17);
            this.splitContainer1.Panel1.Controls.Add(this.cmbTypeRZA);
            this.splitContainer1.Panel1.Controls.Add(this.label_10);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxDefectData);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxResult);
            this.splitContainer1.Size = new Size(0x3be, 0x22c);
            this.splitContainer1.SplitterDistance = 0x1fb;
            this.splitContainer1.TabIndex = 0x12;
            this.cmbAPV.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.cmbAPV.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage_0, "tJ_DamageHV.APR", true));
            this.cmbAPV.FormattingEnabled = true;
            this.cmbAPV.Location = new Point(0x115, 530);
            this.cmbAPV.Name = "cmbAPV";
            this.cmbAPV.Size = new Size(0x4a, 0x15);
            this.cmbAPV.TabIndex = 0x23;
            this.dataSetDamage_0.DataSetName = "DataSetDamage";
            this.dataSetDamage_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.label12.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.Location = new Point(0xb2, 0x217);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x1d, 13);
            this.label12.TabIndex = 0x22;
            this.label12.Text = "АПВ";
            this.cmbAVR.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.cmbAVR.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage_0, "tJ_DamageHV.AVR", true));
            this.cmbAVR.FormattingEnabled = true;
            this.cmbAVR.Location = new Point(0x73, 530);
            this.cmbAVR.Name = "cmbAVR";
            this.cmbAVR.Size = new Size(0x37, 0x15);
            this.cmbAVR.TabIndex = 0x21;
            this.label8.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new Point(10, 0x217);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x1c, 13);
            this.label8.TabIndex = 0x20;
            this.label8.Text = "АВР";
            this.label_26.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_26.Location = new Point(0x165, 0x1df);
            this.label_26.Name = "label7";
            this.label_26.Size = new Size(0x44, 0x1a);
            this.label_26.TabIndex = 0x1f;
            this.label_26.Text = "Коэфф. сезонности";
            this.txtCoefSeason.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.txtCoefSeason.BackColor = SystemColors.Window;
            this.txtCoefSeason.DataBindings.Add(new Binding("Text", this.dataSetDamage_0, "tJ_DamageHV.CoefSeason", true));
            this.txtCoefSeason.Location = new Point(0x1af, 0x1df);
            this.txtCoefSeason.Name = "txtCoefSeason";
            this.txtCoefSeason.Size = new Size(0x41, 20);
            this.txtCoefSeason.TabIndex = 30;
            this.txtCoefSeason.TextChanged += new EventHandler(this.txtCoefSeason_TextChanged);
            this.buttonLoadTextBoxSum.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.buttonLoadTextBoxSum.Location = new Point(430, 530);
            this.buttonLoadTextBoxSum.Name = "buttonLoadTextBoxSum";
            this.buttonLoadTextBoxSum.Size = new Size(0x4b, 0x17);
            this.buttonLoadTextBoxSum.TabIndex = 0x1d;
            this.buttonLoadTextBoxSum.Text = "Заполнить";
            this.buttonLoadTextBoxSum.UseVisualStyleBackColor = true;
            this.buttonLoadTextBoxSum.Click += new EventHandler(this.buttonLoadTextBoxSum_Click);
            this.txtCosFi.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.txtCosFi.BackColor = SystemColors.Window;
            this.txtCosFi.DataBindings.Add(new Binding("Text", this.dataSetDamage_0, "tJ_DamageHV.CoefFI", true));
            this.txtCosFi.Location = new Point(0x1af, 0x1f9);
            this.txtCosFi.Name = "txtCosFi";
            this.txtCosFi.Size = new Size(0x41, 20);
            this.txtCosFi.TabIndex = 0x1c;
            this.txtCosFi.TextChanged += new EventHandler(this.txtCosFi_TextChanged);
            this.label_18.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_18.AutoSize = true;
            this.label_18.Location = new Point(0x165, 0x1ff);
            this.label_18.Name = "label16";
            this.label_18.Size = new Size(0x20, 13);
            this.label_18.TabIndex = 0x1b;
            this.label_18.Text = "cos fi";
            this.label_14.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_14.AutoSize = true;
            this.label_14.Location = new Point(0xb2, 0x1ff);
            this.label_14.Name = "labelPowerV";
            this.label_14.Size = new Size(90, 13);
            this.label_14.TabIndex = 0x18;
            this.label_14.Text = "Напряжение, кВ";
            this.txtV.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.txtV.BackColor = SystemColors.Window;
            this.txtV.DataBindings.Add(new Binding("Text", this.dataSetDamage_0, "tJ_DamageHV.PowerV", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtV.Location = new Point(0x115, 0x1fc);
            this.txtV.Name = "txtV";
            this.txtV.Size = new Size(0x4a, 20);
            this.txtV.TabIndex = 0x17;
            this.txtV.TextChanged += new EventHandler(this.txtV_TextChanged);
            this.label_15.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_15.AutoSize = true;
            this.label_15.Location = new Point(10, 0x1ff);
            this.label_15.Name = "label11";
            this.label_15.Size = new Size(0x44, 13);
            this.label_15.TabIndex = 0x16;
            this.label_15.Text = "Нагрузка, А";
            this.txtA.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.txtA.BackColor = SystemColors.Window;
            this.txtA.DataBindings.Add(new Binding("Text", this.dataSetDamage_0, "tJ_DamageHV.PowerA", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtA.Location = new Point(0x73, 0x1fc);
            this.txtA.Name = "txtA";
            this.txtA.Size = new Size(0x37, 20);
            this.txtA.TabIndex = 20;
            this.txtA.TextChanged += new EventHandler(this.txtA_TextChanged);
            this.txtKWT.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.txtKWT.BackColor = SystemColors.Window;
            this.txtKWT.DataBindings.Add(new Binding("Text", this.dataSetDamage_0, "tJ_DamageHV.ConnectedPower", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtKWT.Location = new Point(0x115, 0x1df);
            this.txtKWT.Name = "txtKWT";
            this.txtKWT.ReadOnly = true;
            this.txtKWT.Size = new Size(0x4a, 20);
            this.txtKWT.TabIndex = 0x13;
            this.txtKWT.TextChanged += new EventHandler(this.txtKWT_TextChanged);
            this.label_16.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_16.Location = new Point(0xb2, 0x1dc);
            this.label_16.Name = "label10";
            this.label_16.Size = new Size(0x6c, 0x1d);
            this.label_16.TabIndex = 0x12;
            this.label_16.Text = "Присоединенная мощность, кВт";
            this.txtCountSchmObj.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.txtCountSchmObj.BackColor = SystemColors.Window;
            this.txtCountSchmObj.DataBindings.Add(new Binding("Text", this.dataSetDamage_0, "tJ_DamageHV.CountSchmObj", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtCountSchmObj.Location = new Point(0x73, 0x1df);
            this.txtCountSchmObj.Name = "txtCountSchmObj";
            this.txtCountSchmObj.Size = new Size(0x37, 20);
            this.txtCountSchmObj.TabIndex = 0x11;
            this.txtCountSchmObj.TextChanged += new EventHandler(this.txtCountSchmObj_TextChanged);
            this.label_17.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_17.Location = new Point(10, 0x1dc);
            this.label_17.Name = "label9";
            this.label_17.Size = new Size(0x6c, 0x1d);
            this.label_17.TabIndex = 0x10;
            this.label_17.Text = "Количество электроустановок";
            this.cmbTypeRZA.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.cmbTypeRZA.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage_0, "tJ_DamageHV.idTypeRZA", true));
            this.cmbTypeRZA.FormattingEnabled = true;
            this.cmbTypeRZA.Location = new Point(0xca, 0x1c1);
            this.cmbTypeRZA.Name = "cmbTypeRZA";
            this.cmbTypeRZA.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbTypeRZA.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbTypeRZA.Size = new Size(0x128, 0x15);
            this.cmbTypeRZA.TabIndex = 15;
            this.cmbTypeRZA.SelectedIndexChanged += new EventHandler(this.cmbTypeRZA_SelectedIndexChanged);
            this.label_10.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_10.AutoSize = true;
            this.label_10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.label_10.Location = new Point(10, 0x1c4);
            this.label_10.Name = "labelTypeRZA";
            this.label_10.Size = new Size(0xba, 13);
            this.label_10.TabIndex = 14;
            this.label_10.Text = "Тип работы релейной защиты";
            this.groupBoxDefectData.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.groupBoxDefectData.Controls.Add(this.btnRequestForRepair);
            this.groupBoxDefectData.Controls.Add(this.txtDocParent);
            this.groupBoxDefectData.Controls.Add(this.label_29);
            this.groupBoxDefectData.Controls.Add(this.label_21);
            this.groupBoxDefectData.Controls.Add(this.label_22);
            this.groupBoxDefectData.Controls.Add(this.dgvCharacterDamage);
            this.groupBoxDefectData.Controls.Add(this.txtLocation);
            this.groupBoxDefectData.Controls.Add(this.cmbReason);
            this.groupBoxDefectData.Controls.Add(this.label_9);
            this.groupBoxDefectData.Controls.Add(this.btnChoiceSchmObj);
            this.groupBoxDefectData.Controls.Add(this.labelSchmObj);
            this.groupBoxDefectData.Controls.Add(this.txtSchmObj);
            this.groupBoxDefectData.Location = new Point(0, 0);
            this.groupBoxDefectData.Name = "groupBoxDefectData";
            this.groupBoxDefectData.Size = new Size(0x1f8, 0x1bb);
            this.groupBoxDefectData.TabIndex = 13;
            this.groupBoxDefectData.TabStop = false;
            this.groupBoxDefectData.Text = "Исходные данные";
            this.btnRequestForRepair.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.btnRequestForRepair.Location = new Point(0x1d5, 15);
            this.btnRequestForRepair.Name = "btnRequestForRepair";
            this.btnRequestForRepair.Size = new Size(0x1b, 20);
            this.btnRequestForRepair.TabIndex = 12;
            this.btnRequestForRepair.Text = "...";
            this.btnRequestForRepair.UseVisualStyleBackColor = true;
            this.btnRequestForRepair.Click += new EventHandler(this.btnRequestForRepair_Click);
            this.txtDocParent.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtDocParent.BackColor = SystemColors.Window;
            this.txtDocParent.Location = new Point(0x8d, 0x10);
            this.txtDocParent.Name = "txtDocParent";
            this.txtDocParent.ReadOnly = true;
            this.txtDocParent.Size = new Size(0x149, 20);
            this.txtDocParent.TabIndex = 11;
            this.txtDocParent.MouseLeave += new EventHandler(this.txtDocParent_MouseLeave);
            this.txtDocParent.MouseHover += new EventHandler(this.txtDocParent_MouseHover);
            this.label_29.AutoSize = true;
            this.label_29.Location = new Point(10, 0x13);
            this.label_29.Name = "label13";
            this.label_29.Size = new Size(0x73, 13);
            this.label_29.TabIndex = 10;
            this.label_29.Text = "Документ-основание";
            this.label_21.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_21.AutoSize = true;
            this.label_21.Location = new Point(5, 0x13e);
            this.label_21.Name = "label17";
            this.label_21.Size = new Size(110, 13);
            this.label_21.TabIndex = 9;
            this.label_21.Text = "Место повреждения";
            this.label_22.AutoSize = true;
            this.label_22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.label_22.Location = new Point(10, 0x4f);
            this.label_22.Name = "labelDamageCharacter";
            this.label_22.Size = new Size(0x92, 13);
            this.label_22.TabIndex = 8;
            this.label_22.Text = "Характер повреждения";
            this.dgvCharacterDamage.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dgvCharacterDamage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.Column1, this.ColumnSchmObj, this.columnIdSchmObj, this.ColumnBtn, this.ColumnCabSection, this.Column2, this.Column3 };
            this.dgvCharacterDamage.Columns.AddRange(dataGridViewColumns);
            this.dgvCharacterDamage.EditMode = DataGridViewEditMode.EditOnEnter;
            this.dgvCharacterDamage.Location = new Point(0, 0x5f);
            this.dgvCharacterDamage.Name = "dgvCharacterDamage";
            this.dgvCharacterDamage.Size = new Size(0x1f8, 220);
            this.dgvCharacterDamage.TabIndex = 7;
            this.dgvCharacterDamage.CellContentClick += new DataGridViewCellEventHandler(this.dgvCharacterDamage_CellContentClick);
            this.dgvCharacterDamage.CurrentCellDirtyStateChanged += new EventHandler(this.dgvCharacterDamage_CurrentCellDirtyStateChanged);
            this.dgvCharacterDamage.DataError += new DataGridViewDataErrorEventHandler(this.dgvCharacterDamage_DataError);
            this.dgvCharacterDamage.MouseClick += new MouseEventHandler(this.dgvCharacterDamage_MouseClick);
            this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column1.FillWeight = 50f;
            this.Column1.HeaderText = "Тип объекта";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = DataGridViewTriState.True;
            this.Column1.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.ColumnSchmObj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSchmObj.HeaderText = "Объект";
            this.ColumnSchmObj.Name = "ColumnSchmObj";
            this.columnIdSchmObj.HeaderText = "idSchmObj";
            this.columnIdSchmObj.Name = "columnIdSchmObj";
            this.columnIdSchmObj.Visible = false;
            this.ColumnBtn.FillWeight = 40f;
            this.ColumnBtn.HeaderText = "";
            this.ColumnBtn.Name = "ColumnBtn";
            this.ColumnBtn.Text = "...";
            this.ColumnBtn.ToolTipText = "Выбрать объект";
            this.ColumnBtn.Width = 0x19;
            this.ColumnCabSection.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnCabSection.HeaderText = "Участок";
            this.ColumnCabSection.Name = "ColumnCabSection";
            this.ColumnCabSection.Resizable = DataGridViewTriState.True;
            this.ColumnCabSection.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.ColumnCabSection.Width = 60;
            this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column2.HeaderText = "Повреждение";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = DataGridViewTriState.True;
            this.Column2.SortMode = DataGridViewColumnSortMode.Automatic;
            this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column3.HeaderText = "Уточнение";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = DataGridViewTriState.True;
            this.Column3.SortMode = DataGridViewColumnSortMode.Automatic;
            this.txtLocation.AcceptsTab = true;
            this.txtLocation.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.txtLocation.BackColor = SystemColors.Window;
            this.txtLocation.DataBindings.Add(new Binding("Text", this.dataSetDamage_0, "tJ_Damage.DefectLocation", true));
            this.txtLocation.Location = new Point(0, 0x14e);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new Size(0x1f8, 0x42);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.Text = "";
            this.cmbReason.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.cmbReason.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbReason.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbReason.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage_0, "tJ_Damage.idReason", true));
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new Point(0x73, 0x196);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.ReadOnlyBackColor = SystemColors.Window;
            this.cmbReason.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbReason.Size = new Size(0x17e, 0x15);
            this.cmbReason.TabIndex = 5;
            this.cmbReason.SelectedIndexChanged += new EventHandler(this.SelectedIndexChanged_SelectedIndexChanged);
            this.label_9.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_9.AutoSize = true;
            this.label_9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.label_9.Location = new Point(10, 0x199);
            this.label_9.Name = "labelReason";
            this.label_9.Size = new Size(0x63, 13);
            this.label_9.TabIndex = 4;
            this.label_9.Text = "Неисправность";
            this.btnChoiceSchmObj.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.btnChoiceSchmObj.Location = new Point(0x1d5, 0x2d);
            this.btnChoiceSchmObj.Name = "btnChoiceSchmObj";
            this.btnChoiceSchmObj.Size = new Size(0x1b, 20);
            this.btnChoiceSchmObj.TabIndex = 2;
            this.btnChoiceSchmObj.Text = "...";
            this.btnChoiceSchmObj.UseVisualStyleBackColor = true;
            this.btnChoiceSchmObj.Click += new EventHandler(this.btnChoiceSchmObj_Click);
            this.labelSchmObj.AutoSize = true;
            this.labelSchmObj.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.labelSchmObj.Location = new Point(10, 0x31);
            this.labelSchmObj.Name = "labelSchmObj";
            this.labelSchmObj.Size = new Size(0x7d, 13);
            this.labelSchmObj.TabIndex = 1;
            this.labelSchmObj.Text = @"Подстанция\ячейка";
            this.txtSchmObj.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtSchmObj.BackColor = SystemColors.Window;
            this.txtSchmObj.Location = new Point(0x8d, 0x2d);
            this.txtSchmObj.Name = "txtSchmObj";
            this.txtSchmObj.ReadOnly = true;
            this.txtSchmObj.Size = new Size(0x149, 20);
            this.txtSchmObj.TabIndex = 0;
            this.txtSchmObj.TextChanged += new EventHandler(this.txtSchmObj_TextChanged);
            this.groupBoxResult.Controls.Add(this.groupBoxDefect);
            this.groupBoxResult.Controls.Add(this.splitContainer2);
            this.groupBoxResult.Controls.Add(this.labelCompletedWork);
            this.groupBoxResult.Controls.Add(this.cmbCompletedWork);
            this.groupBoxResult.Dock = DockStyle.Fill;
            this.groupBoxResult.Location = new Point(0, 0);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new Size(0x1bf, 0x22c);
            this.groupBoxResult.TabIndex = 14;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат (принятые меры)";
            this.groupBoxDefect.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.groupBoxDefect.Controls.Add(this.txtLaboratoryInstruction);
            this.groupBoxDefect.Controls.Add(this.label_23);
            this.groupBoxDefect.Controls.Add(this.txtDivisionInstruction);
            this.groupBoxDefect.Controls.Add(this.label_24);
            this.groupBoxDefect.Controls.Add(this.chbDefect);
            this.groupBoxDefect.Controls.Add(this.label_25);
            this.groupBoxDefect.Controls.Add(this.checkBoxLaboratory);
            this.groupBoxDefect.Controls.Add(this.cmbDivisionApply);
            this.groupBoxDefect.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.groupBoxDefect.Location = new Point(0, 0x169);
            this.groupBoxDefect.Name = "groupBoxDefect";
            this.groupBoxDefect.Size = new Size(0x1bf, 0xc3);
            this.groupBoxDefect.TabIndex = 0x13;
            this.groupBoxDefect.TabStop = false;
            this.groupBoxDefect.Text = "Журнал дефектов";
            this.txtLaboratoryInstruction.AcceptsTab = true;
            this.txtLaboratoryInstruction.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtLaboratoryInstruction.BackColor = SystemColors.Window;
            this.txtLaboratoryInstruction.DataBindings.Add(new Binding("Text", this.dataSetDamage_0, "tJ_Damage.LaboratoryInstruction", true));
            this.txtLaboratoryInstruction.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtLaboratoryInstruction.Location = new Point(0x51, 0x90);
            this.txtLaboratoryInstruction.Name = "txtLaboratoryInstruction";
            this.txtLaboratoryInstruction.Size = new Size(360, 0x30);
            this.txtLaboratoryInstruction.TabIndex = 0x16;
            this.txtLaboratoryInstruction.Text = "";
            this.txtLaboratoryInstruction.Visible = false;
            this.label_23.AutoSize = true;
            this.label_23.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_23.Location = new Point(6, 0x91);
            this.label_23.Name = "labelLaboratoryInstruction";
            this.label_23.Size = new Size(0x39, 13);
            this.label_23.TabIndex = 0x15;
            this.label_23.Text = "Указания";
            this.label_23.Visible = false;
            this.txtDivisionInstruction.AcceptsTab = true;
            this.txtDivisionInstruction.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.txtDivisionInstruction.BackColor = SystemColors.Window;
            this.txtDivisionInstruction.DataBindings.Add(new Binding("Text", this.dataSetDamage_0, "tJ_Damage.DivisionInstruction", true));
            this.txtDivisionInstruction.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.txtDivisionInstruction.Location = new Point(0x51, 0x3d);
            this.txtDivisionInstruction.Name = "txtDivisionInstruction";
            this.txtDivisionInstruction.Size = new Size(360, 0x3a);
            this.txtDivisionInstruction.TabIndex = 20;
            this.txtDivisionInstruction.Text = "";
            this.txtDivisionInstruction.Visible = false;
            this.label_24.AutoSize = true;
            this.label_24.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_24.Location = new Point(6, 0x3d);
            this.label_24.Name = "labelDivisionInstruction";
            this.label_24.Size = new Size(0x39, 13);
            this.label_24.TabIndex = 0x13;
            this.label_24.Text = "Указания";
            this.label_24.Visible = false;
            this.chbDefect.AutoSize = true;
            this.chbDefect.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.chbDefect.Location = new Point(6, 0x19);
            this.chbDefect.Name = "chbDefect";
            this.chbDefect.Size = new Size(0x42, 0x11);
            this.chbDefect.TabIndex = 0x12;
            this.chbDefect.Text = "Дефект";
            this.chbDefect.UseVisualStyleBackColor = true;
            this.chbDefect.CheckedChanged += new EventHandler(this.chbDefect_CheckedChanged);
            this.label_25.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.label_25.Location = new Point(0x4e, 0x13);
            this.label_25.Name = "labelDivisionApply";
            this.label_25.Size = new Size(0x60, 0x1b);
            this.label_25.TabIndex = 15;
            this.label_25.Text = "Подразделение исполнитель";
            this.label_25.Visible = false;
            this.checkBoxLaboratory.AutoSize = true;
            this.checkBoxLaboratory.DataBindings.Add(new Binding("Checked", this.dataSetDamage_0, "tJ_Damage.isLaboratory", true, DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxLaboratory.Enabled = false;
            this.checkBoxLaboratory.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.checkBoxLaboratory.Location = new Point(6, 0x79);
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
            this.cmbDivisionApply.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage_0, "tJ_Damage.idDivisionApply", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cmbDivisionApply.DropDownStyle = (ComboBoxStyle.DropDownList);
            this.cmbDivisionApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            this.cmbDivisionApply.ForeColor = SystemColors.WindowText;
            this.cmbDivisionApply.FormattingEnabled = true;
            this.cmbDivisionApply.Location = new Point(180, 0x15);
            this.cmbDivisionApply.Name = "cmbDivisionApply";
            this.cmbDivisionApply.ReadOnly = (true);
            this.cmbDivisionApply.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbDivisionApply.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbDivisionApply.Size = new Size(0x105, 0x15);
            this.cmbDivisionApply.TabIndex = 0x10;
            this.cmbDivisionApply.TabStop = false;
            this.cmbDivisionApply.Visible = (false);
            this.cmbDivisionApply.SelectedIndexChanged += new EventHandler(this.cmbDivisionApply_SelectedIndexChanged);
            this.splitContainer2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.splitContainer2.Location = new Point(0, 0x26);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = Orientation.Horizontal;
            this.splitContainer2.Panel1.Controls.Add(this.rbOnFact);
            this.splitContainer2.Panel1.Controls.Add(this.rbOnAverage);
            this.splitContainer2.Panel1.Controls.Add(this.label_19);
            this.splitContainer2.Panel1.Controls.Add(this.label_13);
            this.splitContainer2.Panel1.Controls.Add(this.txtCountSchmObjOff);
            this.splitContainer2.Panel1.Controls.Add(this.txtNoKWT);
            this.splitContainer2.Panel1.Controls.Add(this.dgvOn);
            this.splitContainer2.Panel1.Controls.Add(this.labelDamageOn);
            this.splitContainer2.Panel2.Controls.Add(this.label_12);
            this.splitContainer2.Panel2.Controls.Add(this.checkBoxApply);
            this.splitContainer2.Panel2.Controls.Add(this.dtpDataApply);
            this.splitContainer2.Panel2.Controls.Add(this.label_7);
            this.splitContainer2.Panel2.Controls.Add(this.txtCompletedWork);
            this.splitContainer2.Panel2.Controls.Add(this.cmbWorkerApply);
            this.splitContainer2.Size = new Size(0x1bf, 0x143);
            this.splitContainer2.SplitterDistance = 0xc0;
            this.splitContainer2.TabIndex = 8;
            this.rbOnFact.AutoSize = true;
            this.rbOnFact.Location = new Point(0xdf, 5);
            this.rbOnFact.Name = "rbOnFact";
            this.rbOnFact.Size = new Size(70, 0x11);
            this.rbOnFact.TabIndex = 0x1c;
            this.rbOnFact.Text = "по факту";
            this.rbOnFact.UseVisualStyleBackColor = true;
            this.rbOnAverage.AutoSize = true;
            this.rbOnAverage.Checked = true;
            this.rbOnAverage.Location = new Point(0x4b, 5);
            this.rbOnAverage.Name = "rbOnAverage";
            this.rbOnAverage.Size = new Size(0x59, 0x11);
            this.rbOnAverage.TabIndex = 0x1b;
            this.rbOnAverage.TabStop = true;
            this.rbOnAverage.Text = "по среднему";
            this.rbOnAverage.UseVisualStyleBackColor = true;
            this.rbOnAverage.CheckedChanged += new EventHandler(this.rbOnAverage_CheckedChanged);
            this.label_19.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_19.AutoSize = true;
            this.label_19.Location = new Point(10, 140);
            this.label_19.Name = "label15";
            this.label_19.Size = new Size(0xd5, 13);
            this.label_19.TabIndex = 4;
            this.label_19.Text = "Количество невключенных эл.установок";
            this.label_13.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_13.AutoSize = true;
            this.label_13.Location = new Point(10, 0xa6);
            this.label_13.Name = "labelSumNoAdmissionKWT";
            this.label_13.Size = new Size(0x97, 13);
            this.label_13.TabIndex = 0x1a;
            this.label_13.Text = "Недопуск эл. энергии, кВт*ч";
            this.txtCountSchmObjOff.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.txtCountSchmObjOff.BackColor = SystemColors.Window;
            this.txtCountSchmObjOff.DataBindings.Add(new Binding("Text", this.dataSetDamage_0, "tJ_DamageHV.CountSchmObjOff", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtCountSchmObjOff.Location = new Point(0x100, 0x89);
            this.txtCountSchmObjOff.Name = "txtCountSchmObjOff";
            this.txtCountSchmObjOff.ReadOnly = true;
            this.txtCountSchmObjOff.Size = new Size(100, 20);
            this.txtCountSchmObjOff.TabIndex = 2;
            this.txtNoKWT.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.txtNoKWT.BackColor = SystemColors.Window;
            this.txtNoKWT.DataBindings.Add(new Binding("Text", this.dataSetDamage_0, "tJ_DamageHV.NoAdmissionKWT", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtNoKWT.Location = new Point(0x100, 0xa3);
            this.txtNoKWT.Name = "txtNoKWT";
            this.txtNoKWT.ReadOnly = true;
            this.txtNoKWT.Size = new Size(100, 20);
            this.txtNoKWT.TabIndex = 0x19;
            this.dgvOn.AllowUserToOrderColumns = true;
            this.dgvOn.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dgvOn.AutoGenerateColumns = false;
            this.dgvOn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dateBegDgvColumn, this.dateOnDgvColumn, this.countSchmObjDgvColumn, this.countSchmObjOffDgvColumn, this.noAdmissionKWTDgvColumn, this.idDataGridViewTextBoxColumn1, this.idDamageDataGridViewTextBoxColumn1 };
            this.dgvOn.Columns.AddRange(columnArray2);
            this.dgvOn.DataMember = "tJ_DamageOn";
            this.dgvOn.DataSource = this.dataSetDamage_0;
            this.dgvOn.Location = new Point(0, 0x17);
            this.dgvOn.Name = "dgvOn";
            this.dgvOn.RowHeadersWidth = 0x15;
            this.dgvOn.Size = new Size(0x1bf, 0x6c);
            this.dgvOn.TabIndex = 1;
            this.dgvOn.CellValueChanged += new DataGridViewCellEventHandler(this.dgvOn_CellValueChanged);
            this.dgvOn.DataError += new DataGridViewDataErrorEventHandler(this.dgvOn_DataError);
            this.dgvOn.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgvOn_EditingControlShowing);
            this.dgvOn.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgvOn_RowsAdded);
            this.dgvOn.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dgvOn_RowsRemoved);
            this.dateBegDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            style.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            style.Format = "dd.MM.yyyy HH:mm";
            this.dateBegDgvColumn.DefaultCellStyle = style;
            this.dateBegDgvColumn.HeaderText = "Дата1";
            this.dateBegDgvColumn.Name = "dateBegDgvColumn";
            this.dateBegDgvColumn.ReadOnly = true;
            this.dateBegDgvColumn.Visible = false;
            this.dateOnDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dateOnDgvColumn.DataPropertyName = "dateOn";
            style2.Format = "dd.MM.yyyy HH:mm";
            this.dateOnDgvColumn.DefaultCellStyle = style2;
            this.dateOnDgvColumn.FillWeight = 100.5905f;
            this.dateOnDgvColumn.HeaderText = "Дата включения";
            this.dateOnDgvColumn.MinimumWidth = 70;
            this.dateOnDgvColumn.Name = "dateOnDgvColumn";
            this.dateOnDgvColumn.Resizable = DataGridViewTriState.True;
            this.dateOnDgvColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            this.countSchmObjDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.countSchmObjDgvColumn.DataPropertyName = "countSchmObj";
            this.countSchmObjDgvColumn.FillWeight = 99.64599f;
            this.countSchmObjDgvColumn.HeaderText = "Количество трансформаторов";
            this.countSchmObjDgvColumn.MinimumWidth = 70;
            this.countSchmObjDgvColumn.Name = "countSchmObjDgvColumn";
            this.countSchmObjOffDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            style3.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.countSchmObjOffDgvColumn.DefaultCellStyle = style3;
            this.countSchmObjOffDgvColumn.HeaderText = "Количество отключенных";
            this.countSchmObjOffDgvColumn.Name = "countSchmObjOffDgvColumn";
            this.countSchmObjOffDgvColumn.ReadOnly = true;
            this.countSchmObjOffDgvColumn.Visible = false;
            this.noAdmissionKWTDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.noAdmissionKWTDgvColumn.DataPropertyName = "noAdmissionKWT";
            style4.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.noAdmissionKWTDgvColumn.DefaultCellStyle = style4;
            this.noAdmissionKWTDgvColumn.HeaderText = "Недопуск эл.энергии";
            this.noAdmissionKWTDgvColumn.Name = "noAdmissionKWTDgvColumn";
            this.noAdmissionKWTDgvColumn.ReadOnly = true;
            this.noAdmissionKWTDgvColumn.Visible = false;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDamageDataGridViewTextBoxColumn1.DataPropertyName = "idDamage";
            this.idDamageDataGridViewTextBoxColumn1.HeaderText = "idDamage";
            this.idDamageDataGridViewTextBoxColumn1.Name = "idDamageDataGridViewTextBoxColumn1";
            this.idDamageDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDamageDataGridViewTextBoxColumn1.Visible = false;
            this.labelDamageOn.AutoSize = true;
            this.labelDamageOn.Location = new Point(6, 7);
            this.labelDamageOn.Name = "labelDamageOn";
            this.labelDamageOn.Size = new Size(0x3f, 13);
            this.labelDamageOn.TabIndex = 0;
            this.labelDamageOn.Text = "Включение";
            this.label_12.AutoSize = true;
            this.label_12.Location = new Point(10, 0);
            this.label_12.Name = "label1";
            this.label_12.Size = new Size(70, 13);
            this.label_12.TabIndex = 7;
            this.label_12.Text = "Примечание";
            this.checkBoxApply.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.checkBoxApply.AutoSize = true;
            this.checkBoxApply.DataBindings.Add(new Binding("Checked", this.dataSetDamage_0, "tJ_Damage.isApply", true, DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxApply.Location = new Point(13, 0x4c);
            this.checkBoxApply.Name = "checkBoxApply";
            this.checkBoxApply.Size = new Size(0x52, 0x11);
            this.checkBoxApply.TabIndex = 3;
            this.checkBoxApply.Text = "Исполнено";
            this.checkBoxApply.UseVisualStyleBackColor = true;
            this.checkBoxApply.CheckedChanged += new EventHandler(this.checkBoxApply_CheckedChanged);
            this.dtpDataApply.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.dtpDataApply.CustomFormat = ("dd.MM.yyyy HH:mm");
            this.dtpDataApply.DataBindings.Add(new Binding("Value", this.dataSetDamage_0, "tJ_Damage.DateApply", true));
            this.dtpDataApply.Format = (DateTimePickerFormat.Custom);
            this.dtpDataApply.Location = new Point(0x65, 0x65);
            this.dtpDataApply.Name = "dtpDataApply";
            this.dtpDataApply.Size = new Size(0x100, 20);
            this.dtpDataApply.TabIndex = 6;
            this.dtpDataApply.Value = (new DateTime(0x7df, 8, 6, 10, 0, 0x35, 2));
            this.dtpDataApply.ValueChanged += new EventHandler(this.dtpDataApply_ValueChanged);
            this.label_7.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(10, 0x6a);
            this.label_7.Name = "labelDateAplly";
            this.label_7.Size = new Size(0x4d, 13);
            this.label_7.TabIndex = 5;
            this.label_7.Text = "Дата и время";
            this.txtCompletedWork.AcceptsTab = true;
            this.txtCompletedWork.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.txtCompletedWork.BackColor = SystemColors.Window;
            this.txtCompletedWork.DataBindings.Add(new Binding("Text", this.dataSetDamage_0, "tJ_Damage.ComletedWorkText", true));
            this.txtCompletedWork.Location = new Point(0, 0x10);
            this.txtCompletedWork.Name = "txtCompletedWork";
            this.txtCompletedWork.Size = new Size(0x1bf, 0x34);
            this.txtCompletedWork.TabIndex = 2;
            this.txtCompletedWork.Text = "";
            this.txtCompletedWork.TextChanged += new EventHandler(this.txtKWT_TextChanged);
            this.cmbWorkerApply.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.cmbWorkerApply.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbWorkerApply.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbWorkerApply.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage_0, "tJ_Damage.idWorkerApply", true));
            this.cmbWorkerApply.FormattingEnabled = true;
            this.cmbWorkerApply.Location = new Point(0x65, 0x4a);
            this.cmbWorkerApply.Name = "cmbWorkerApply";
            this.cmbWorkerApply.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbWorkerApply.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbWorkerApply.Size = new Size(0xc4, 0x15);
            this.cmbWorkerApply.TabIndex = 4;
            this.cmbWorkerApply.SelectedIndexChanged += new EventHandler(this.cmbWorkerApply_SelectedIndexChanged);
            this.labelCompletedWork.AutoSize = true;
            this.labelCompletedWork.Location = new Point(10, 0x16);
            this.labelCompletedWork.Name = "labelCompletedWork";
            this.labelCompletedWork.Size = new Size(0x72, 13);
            this.labelCompletedWork.TabIndex = 1;
            this.labelCompletedWork.Text = "Выполненная работа";
            this.cmbCompletedWork.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.cmbCompletedWork.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage_0, "tJ_Damage.idCompletedWork", true));
            this.cmbCompletedWork.FormattingEnabled = true;
            this.cmbCompletedWork.Location = new Point(130, 0x13);
            this.cmbCompletedWork.Name = "cmbCompletedWork";
            this.cmbCompletedWork.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbCompletedWork.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbCompletedWork.Size = new Size(0x139, 0x15);
            this.cmbCompletedWork.TabIndex = 0;
            this.cmbCompletedWork.SelectedIndexChanged += new EventHandler(this.cmbCompletedWork_SelectedIndexChanged);
            this.cmbDivision.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage_0, "tJ_Damage.idDivision", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new Point(0x25d, 0x21);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.ReadOnly = (true);
            this.cmbDivision.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbDivision.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbDivision.Size = new Size(0x10a, 0x15);
            this.cmbDivision.TabIndex = 11;
            this.cmbDivision.TabStop = false;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(0x203, 0x27);
            this.label_0.Name = "label6";
            this.label_0.Size = new Size(0x57, 13);
            this.label_0.TabIndex = 10;
            this.label_0.Text = "Подразделение";
            this.label_1.AutoSize = true;
            this.label_1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.label_1.Location = new Point(0x203, 13);
            this.label_1.Name = "labelCompiler";
            this.label_1.Size = new Size(0x53, 13);
            this.label_1.TabIndex = 9;
            this.label_1.Text = "Составитель";
            this.cmbCompiler.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbCompiler.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbCompiler.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage_0, "tJ_Damage.idCompiler", true));
            this.cmbCompiler.FormattingEnabled = true;
            this.cmbCompiler.Location = new Point(0x25d, 5);
            this.cmbCompiler.Name = "cmbCompiler";
            this.cmbCompiler.ReadOnlyBackColor = (SystemColors.Window);
            this.cmbCompiler.ReadOnlyForeColor = (SystemColors.WindowText);
            this.cmbCompiler.Size = new Size(0x10a, 0x15);
            this.cmbCompiler.TabIndex = 8;
            this.cmbCompiler.SelectedValueChanged += new EventHandler(this.cmbCompiler_SelectedValueChanged);
            this.dtpDateOwner.DataBindings.Add(new Binding("Value", this.dataSetDamage_0, "tJ_Damage.DateOwner", true));
            this.dtpDateOwner.Enabled = false;
            this.dtpDateOwner.Location = new Point(0x163, 0x21);
            this.dtpDateOwner.Name = "dtpDateOwner";
            this.dtpDateOwner.Size = new Size(0x90, 20);
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
            this.txtOwner.Location = new Point(0x69, 0x20);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new Size(0x7a, 20);
            this.txtOwner.TabIndex = 4;
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(0xe9, 13);
            this.label_4.Name = "label2";
            this.label_4.Size = new Size(0x74, 13);
            this.label_4.TabIndex = 3;
            this.label_4.Text = "Дата и время заявки";
            this.dtpDateDoc.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateDoc.DataBindings.Add(new Binding("Value", this.dataSetDamage_0, "tJ_Damage.DateDoc", true));
            this.dtpDateDoc.Format = DateTimePickerFormat.Custom;
            this.dtpDateDoc.Location = new Point(0x163, 7);
            this.dtpDateDoc.Name = "dtpDateDoc";
            this.dtpDateDoc.Size = new Size(0x90, 20);
            this.dtpDateDoc.TabIndex = 2;
            this.dtpDateDoc.ValueChanged += new EventHandler(this.dtpDateDoc_ValueChanged);
            this.dtpDateDoc.Validated += new EventHandler(this.dateTimePicker_1_Validated);
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(8, 13);
            this.label_5.Name = "labelNumRequest";
            this.label_5.Size = new Size(80, 13);
            this.label_5.TabIndex = 1;
            this.label_5.Text = "Номер заявки";
            this.txtNumRequest.BackColor = SystemColors.Window;
            this.txtNumRequest.DataBindings.Add(new Binding("Text", this.dataSetDamage_0, "tJ_Damage.NumRequest", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtNumRequest.Location = new Point(0x69, 6);
            this.txtNumRequest.Name = "txtNumRequest";
            this.txtNumRequest.Size = new Size(0x7a, 20);
            this.txtNumRequest.TabIndex = 0;
            this.txtNumRequest.TextChanged += new EventHandler(this.txtNumRequest_TextChanged);
            this.tabPageTransformer.Controls.Add(this.splitContainer3);
            this.tabPageTransformer.Controls.Add(this.statusStripTrans);
            this.tabPageTransformer.Controls.Add(this.toolStripTransformer);
            this.tabPageTransformer.Location = new Point(4, 0x16);
            this.tabPageTransformer.Name = "tabPageTransformer";
            this.tabPageTransformer.Padding = new Padding(3);
            this.tabPageTransformer.Size = new Size(0x3c1, 0x26b);
            this.tabPageTransformer.TabIndex = 1;
            this.tabPageTransformer.Text = "Отключенные трансформаторы";
            this.tabPageTransformer.UseVisualStyleBackColor = true;
            this.splitContainer3.Dock = DockStyle.Fill;
            this.splitContainer3.Location = new Point(3, 0x1c);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = Orientation.Horizontal;
            this.splitContainer3.Panel1.Controls.Add(this.dgvTrans);
            this.splitContainer3.Panel2.Controls.Add(this.dgvTree);
            this.splitContainer3.Size = new Size(0x3bb, 0x236);
            this.splitContainer3.SplitterDistance = 0x11b;
            this.splitContainer3.TabIndex = 4;
            this.dgvTrans.AllowUserToAddRows = false;
            this.dgvTrans.AllowUserToDeleteRows = false;
            this.dgvTrans.AllowUserToOrderColumns = true;
            style5.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dgvTrans.AlternatingRowsDefaultCellStyle = style5;
            this.dgvTrans.AutoGenerateColumns = false;
            this.dgvTrans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray3 = new DataGridViewColumn[] { this.subDataGridViewTextBoxColumn, this.idSubDataGridViewTextBoxColumn, this.idTrDataGridViewTextBoxColumn, this.trNameDataGridViewTextBoxColumn, this.powerDataGridViewTextBoxColumn, this.loadDataGridViewTextBoxColumn };
            this.dgvTrans.Columns.AddRange(columnArray3);
            this.dgvTrans.DataSource = this.bindingSource_0;
            this.dgvTrans.Dock = DockStyle.Fill;
            this.dgvTrans.Location = new Point(0, 0);
            this.dgvTrans.Name = "dgvTrans";
            this.dgvTrans.RowHeadersWidth = 0x15;
            this.dgvTrans.Size = new Size(0x3bb, 0x11b);
            this.dgvTrans.TabIndex = 2;
            this.dgvTrans.CellEndEdit += new DataGridViewCellEventHandler(this.dgvTrans_CellEndEdit);
            this.dgvTrans.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgvTrans_RowsAdded);
            this.dgvTrans.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dgvTrans_RowsRemoved);
            this.subDataGridViewTextBoxColumn.DataPropertyName = "Sub";
            this.subDataGridViewTextBoxColumn.HeaderText = "Подстанция";
            this.subDataGridViewTextBoxColumn.Name = "subDataGridViewTextBoxColumn";
            this.subDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSubDataGridViewTextBoxColumn.DataPropertyName = "idSub";
            this.idSubDataGridViewTextBoxColumn.HeaderText = "idSub";
            this.idSubDataGridViewTextBoxColumn.Name = "idSubDataGridViewTextBoxColumn";
            this.idSubDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSubDataGridViewTextBoxColumn.Visible = false;
            this.idTrDataGridViewTextBoxColumn.DataPropertyName = "idTr";
            this.idTrDataGridViewTextBoxColumn.HeaderText = "idTr";
            this.idTrDataGridViewTextBoxColumn.Name = "idTrDataGridViewTextBoxColumn";
            this.idTrDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTrDataGridViewTextBoxColumn.Visible = false;
            this.trNameDataGridViewTextBoxColumn.DataPropertyName = "TrName";
            this.trNameDataGridViewTextBoxColumn.HeaderText = "Трасформатор";
            this.trNameDataGridViewTextBoxColumn.Name = "trNameDataGridViewTextBoxColumn";
            this.trNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.powerDataGridViewTextBoxColumn.DataPropertyName = "Power";
            this.powerDataGridViewTextBoxColumn.HeaderText = "Мощность";
            this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            this.loadDataGridViewTextBoxColumn.DataPropertyName = "Load";
            this.loadDataGridViewTextBoxColumn.HeaderText = "Нагрузка";
            this.loadDataGridViewTextBoxColumn.Name = "loadDataGridViewTextBoxColumn";
            this.bindingSource_0.DataMember = "tableTrans";
            this.bindingSource_0.DataSource = this.dataSet_0;
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.tableTrans, this.table_vl_SchmAbnFull };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.idSub, this.Sub, this.idTr, this.TrName, this.Power, this.load };
            this.tableTrans.Columns.AddRange(columns);
            this.tableTrans.TableName = "tableTrans";
            this.idSub.ColumnName = "idSub";
            this.idSub.DataType = typeof(int);
            this.Sub.ColumnName = "Sub";
            this.idTr.ColumnName = "idTr";
            this.idTr.DataType = typeof(int);
            this.TrName.ColumnName = "TrName";
            this.Power.ColumnName = "Power";
            this.Power.DataType = typeof(int);
            this.load.ColumnName = "Load";
            this.load.DataType = typeof(int);
            DataColumn[] columnArray5 = new DataColumn[] { this.idAbn, this.codeAbonent, this.nameAbn, this.typeAbn, this.idAbnObj, this.nameObj, this.CommentODS };
            this.table_vl_SchmAbnFull.Columns.AddRange(columnArray5);
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
            this.dgvTree.AllowUserToAddRows = false;
            this.dgvTree.AllowUserToDeleteRows = false;
            DataGridViewColumn[] columnArray6 = new DataGridViewColumn[] { this.subNameColumn, this.idSubColumn, this.busNameColumn, this.idBusColumn, this.cellNameColumn, this.idCellColumn, this.trNameColumn, this.idTrColumn, this.powerColumn, this.loadColumn, this.dateOnColumn, this.noAdmissionKWTColumn };
            this.dgvTree.Columns.AddRange(columnArray6);
            this.dgvTree.Dock = DockStyle.Fill;
            this.dgvTree.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dgvTree.ImageList = (null);
            this.dgvTree.Location = new Point(0, 0);
            this.dgvTree.Name = "dgvTree";
            this.dgvTree.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvTree.Size = new Size(0x3bb, 0x117);
            this.dgvTree.TabIndex = 3;
            this.dgvTree.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dgvTree_CellFormatting);
            this.dgvTree.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dgvTree_CellMouseClick);
            this.subNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.subNameColumn.DataPropertyName = "SubName";
            this.subNameColumn.DefaultNodeImage = (null);
            this.subNameColumn.HeaderText = "Подстанция";
            this.subNameColumn.Name = "subNameColumn";
            this.subNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idSubColumn.DataPropertyName = "idSub";
            this.idSubColumn.HeaderText = "idSub";
            this.idSubColumn.Name = "idSubColumn";
            this.idSubColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idSubColumn.Visible = false;
            this.busNameColumn.DataPropertyName = "BusName";
            this.busNameColumn.HeaderText = "Шина";
            this.busNameColumn.Name = "busNameColumn";
            this.busNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idBusColumn.DataPropertyName = "idBus";
            this.idBusColumn.HeaderText = "idBus";
            this.idBusColumn.Name = "idBusColumn";
            this.idBusColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idBusColumn.Visible = false;
            this.cellNameColumn.DataPropertyName = "CellName";
            this.cellNameColumn.HeaderText = "Ячейка";
            this.cellNameColumn.Name = "cellNameColumn";
            this.cellNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idCellColumn.DataPropertyName = "idCell";
            this.idCellColumn.HeaderText = "idCell";
            this.idCellColumn.Name = "idCellColumn";
            this.idCellColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idCellColumn.Visible = false;
            this.trNameColumn.DataPropertyName = "TrName";
            this.trNameColumn.HeaderText = "Трансформатор";
            this.trNameColumn.Name = "trNameColumn";
            this.trNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idTrColumn.DataPropertyName = "idTr";
            this.idTrColumn.HeaderText = "idTr";
            this.idTrColumn.Name = "idTrColumn";
            this.idTrColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idTrColumn.Visible = false;
            this.powerColumn.DataPropertyName = "Power";
            this.powerColumn.HeaderText = "Мощность";
            this.powerColumn.Name = "powerColumn";
            this.powerColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.loadColumn.DataPropertyName = "Load";
            this.loadColumn.HeaderText = "Нагрузка";
            this.loadColumn.Name = "loadColumn";
            this.loadColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dateOnColumn.DataPropertyName = "DateOn";
            style6.Format = "g";
            style6.NullValue = null;
            this.dateOnColumn.DefaultCellStyle = style6;
            this.dateOnColumn.HeaderText = "Дата включения";
            this.dateOnColumn.Name = "dateOnColumn";
            this.dateOnColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.noAdmissionKWTColumn.DataPropertyName = "noAddmissionKWT";
            this.noAdmissionKWTColumn.HeaderText = "Недоотпуск";
            this.noAdmissionKWTColumn.Name = "noAdmissionKWTColumn";
            this.noAdmissionKWTColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.labelCountTr, this.labelSumPower, this.labelSumLoad };
            this.statusStripTrans.Items.AddRange(toolStripItems);
            this.statusStripTrans.Location = new Point(3, 0x252);
            this.statusStripTrans.Name = "statusStripTrans";
            this.statusStripTrans.Size = new Size(0x3bb, 0x16);
            this.statusStripTrans.TabIndex = 5;
            this.statusStripTrans.Text = "statusStrip1";
            this.labelCountTr.Name = "labelCountTr";
            this.labelCountTr.Size = new Size(0x139, 0x11);
            this.labelCountTr.Spring = true;
            this.labelCountTr.Text = "Кол-во трансформаторов: 0";
            this.labelSumPower.Name = "labelSumPower";
            this.labelSumPower.Size = new Size(0x139, 0x11);
            this.labelSumPower.Spring = true;
            this.labelSumPower.Text = "Суммарная мощность: 0";
            this.labelSumLoad.Name = "labelSumLoad";
            this.labelSumLoad.Size = new Size(0x139, 0x11);
            this.labelSumLoad.Spring = true;
            this.labelSumLoad.Text = "Суммарная нагрузка: 0";
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolBtnRefreshTrans };
            this.toolStripTransformer.Items.AddRange(itemArray2);
            this.toolStripTransformer.Location = new Point(3, 3);
            this.toolStripTransformer.Name = "toolStripTransformer";
            this.toolStripTransformer.Size = new Size(0x3bb, 0x19);
            this.toolStripTransformer.TabIndex = 0;
            this.toolStripTransformer.Text = "toolStrip1";
            this.toolBtnRefreshTrans.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnRefreshTrans.Image = (Image) resources.GetObject("toolBtnRefreshTrans.Image");
            this.toolBtnRefreshTrans.Image = global::DailyReport.Properties.Resources.Refresh;
            this.toolBtnRefreshTrans.ImageTransparentColor = Color.Magenta;
            this.toolBtnRefreshTrans.Name = "toolBtnRefreshTrans";
            this.toolBtnRefreshTrans.Size = new Size(0x17, 0x16);
            this.toolBtnRefreshTrans.Text = "Обновить";
            this.toolBtnRefreshTrans.Click += new EventHandler(this.toolBtnRefreshAbn_Click);
            this.tabPageAbn.Controls.Add(this.dgvAbn);
            this.tabPageAbn.Controls.Add(this.statusStripAbn);
            this.tabPageAbn.Controls.Add(this.toolStripAbn);
            this.tabPageAbn.Location = new Point(4, 0x16);
            this.tabPageAbn.Name = "tabPageAbn";
            this.tabPageAbn.Padding = new Padding(3);
            this.tabPageAbn.Size = new Size(0x3c1, 0x26b);
            this.tabPageAbn.TabIndex = 2;
            this.tabPageAbn.Text = "Отключенные абоненты";
            this.tabPageAbn.UseVisualStyleBackColor = true;
            this.dgvAbn.AllowUserToAddRows = false;
            this.dgvAbn.AllowUserToDeleteRows = false;
            this.dgvAbn.AllowUserToOrderColumns = true;
            style7.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dgvAbn.AlternatingRowsDefaultCellStyle = style7;
            this.dgvAbn.AutoGenerateColumns = false;
            this.dgvAbn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray7 = new DataGridViewColumn[]
            {
            this.codeAbonentDataGridViewTextBoxColumn,
            this.idAbnDataGridViewTextBoxColumn,
            this.nameAbnDataGridViewTextBoxColumn,
            this.typeAbnDgvColumn,
            this.idAbnObjDataGridViewTextBoxColumn,
            this.nameObjDataGridViewTextBoxColumn,
            this.commentODSDgvColumn
            };
            this.dgvAbn.Columns.AddRange(columnArray7);
            this.dgvAbn.DataSource = this.bindingSource_1;
            this.dgvAbn.Dock = DockStyle.Fill;
            this.dgvAbn.Location = new Point(3, 0x1c);
            this.dgvAbn.Name = "dgvAbn";
            this.dgvAbn.ReadOnly = true;
            this.dgvAbn.Size = new Size(0x3bb, 0x236);
            this.dgvAbn.TabIndex = 4;
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
            this.nameAbnDataGridViewTextBoxColumn.FillWeight = 82.98449f;
            this.nameAbnDataGridViewTextBoxColumn.HeaderText = "Абонент";
            this.nameAbnDataGridViewTextBoxColumn.Name = "nameAbnDataGridViewTextBoxColumn";
            this.nameAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameAbnDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.typeAbnDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.typeAbnDgvColumn.DataPropertyName = "typeAbn";
            this.typeAbnDgvColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeAbnDgvColumn.FillWeight = 59.49019f;
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
            this.nameObjDataGridViewTextBoxColumn.FillWeight = 95.05233f;
            this.nameObjDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.nameObjDataGridViewTextBoxColumn.Name = "nameObjDataGridViewTextBoxColumn";
            this.nameObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameObjDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.commentODSDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.commentODSDgvColumn.DataPropertyName = "CommentODS";
            this.commentODSDgvColumn.FillWeight = 110.6173f;
            this.commentODSDgvColumn.HeaderText = "Примечание";
            this.commentODSDgvColumn.Name = "commentODSDgvColumn";
            this.commentODSDgvColumn.ReadOnly = true;
            this.bindingSource_1.DataMember = "vl_SchmAbnFull";
            this.bindingSource_1.DataSource = this.dataSet_0;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.labelCountAbn, this.labelCountAbnObj };
            this.statusStripAbn.Items.AddRange(itemArray3);
            this.statusStripAbn.Location = new Point(3, 0x252);
            this.statusStripAbn.Name = "statusStripAbn";
            this.statusStripAbn.Size = new Size(0x3bb, 0x16);
            this.statusStripAbn.TabIndex = 6;
            this.statusStripAbn.Text = "statusStrip1";
            this.labelCountAbn.Name = "labelCountAbn";
            this.labelCountAbn.Size = new Size(470, 0x11);
            this.labelCountAbn.Spring = true;
            this.labelCountAbn.Text = "Количество абонентов: 0";
            this.labelCountAbnObj.Name = "labelCountAbnObj";
            this.labelCountAbnObj.Size = new Size(470, 0x11);
            this.labelCountAbnObj.Spring = true;
            this.labelCountAbnObj.Text = "Количество объектов: 0";
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolBtnRefreshAbn };
            this.toolStripAbn.Items.AddRange(itemArray4);
            this.toolStripAbn.Location = new Point(3, 3);
            this.toolStripAbn.Name = "toolStripAbn";
            this.toolStripAbn.Size = new Size(0x3bb, 0x19);
            this.toolStripAbn.TabIndex = 5;
            this.toolStripAbn.Text = "toolStrip1";
            this.toolBtnRefreshAbn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnRefreshAbn.Image = (Image) resources.GetObject("toolBtnRefreshAbn.Image");
            this.toolBtnRefreshAbn.Image = global::DailyReport.Properties.Resources.Refresh;
            this.toolBtnRefreshAbn.ImageTransparentColor = Color.Magenta;
            this.toolBtnRefreshAbn.Name = "toolBtnRefreshAbn";
            this.toolBtnRefreshAbn.Size = new Size(0x17, 0x16);
            this.toolBtnRefreshAbn.Text = "Обновить";
            this.toolBtnRefreshAbn.Click += new EventHandler(this.toolBtnRefreshAbn_Click);
            this.buttonClose.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.buttonClose.DialogResult = DialogResult.Cancel;
            this.buttonClose.Location = new Point(880, 0x28b);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(0x4b, 0x17);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
            this.buttonSave.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.buttonSave.DialogResult = DialogResult.OK;
            this.buttonSave.Location = new Point(13, 0x28b);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(0x4b, 0x17);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker_0.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            this.labelProgress.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new Point(0x5d, 0x290);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new Size(0xde, 13);
            this.labelProgress.TabIndex = 3;
            this.labelProgress.Text = "Загрузка отключенных трансформаторов ";
            this.labelProgress.Visible = false;
            this.progressBar.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.progressBar.Location = new Point(0x141, 0x28b);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new Size(0x229, 0x17);
            this.progressBar.Style = ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 4;
            this.progressBar.Visible = false;
            this.dataGridViewComboBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn1.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn1.FillWeight = 50f;
            this.dataGridViewComboBoxColumn1.HeaderText = "Тип объекта";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewButtonColumn1.FillWeight = 40f;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "...";
            this.dataGridViewButtonColumn1.ToolTipText = "Выбрать объект";
            this.dataGridViewButtonColumn1.Width = 0x19;
            this.dataGridViewComboBoxColumn2.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn2.HeaderText = "Участок";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewComboBoxColumn2.Width = 60;
            this.dataGridViewComboBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn3.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn3.HeaderText = "Повреждение";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn3.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn4.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn4.HeaderText = "Уточнение";
            this.dataGridViewComboBoxColumn4.Name = "dataGridViewComboBoxColumn4";
            this.dataGridViewComboBoxColumn4.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn4.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idDamage";
            this.dataGridViewTextBoxColumn4.HeaderText = "idDamage";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "countSchmObj";
            this.dataGridViewTextBoxColumn5.HeaderText = "Количество подстанций";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "noAdmissionKWT";
            this.dataGridViewTextBoxColumn6.HeaderText = "Недопуск эл.энергии";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Sub";
            this.dataGridViewTextBoxColumn13.HeaderText = "Подстанция";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn14.DataPropertyName = "idSub";
            this.dataGridViewTextBoxColumn14.HeaderText = "idSub";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Power";
            this.dataGridViewTextBoxColumn17.HeaderText = "Мощность";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Load";
            this.dataGridViewTextBoxColumn18.HeaderText = "Нагрузка";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.toolTip_0.IsBalloon = true;
            this.toolTip_0.ShowAlways = true;
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.toolMenuItemOn, this.toolMenuItemOff };
            this.contextMenuDgvTree.Items.AddRange(itemArray5);
            this.contextMenuDgvTree.Name = "contextMenuDgvTree";
            this.contextMenuDgvTree.Size = new Size(0x89, 0x30);
            this.toolMenuItemOn.Name = "toolMenuItemOn";
            this.toolMenuItemOn.Size = new Size(0x88, 0x16);
            this.toolMenuItemOn.Text = "Включить";
            this.toolMenuItemOn.Click += new EventHandler(this.toolMenuItemOn_Click);
            this.toolMenuItemOff.Name = "toolMenuItemOff";
            this.toolMenuItemOff.Size = new Size(0x88, 0x16);
            this.toolMenuItemOff.Text = "Отключить";
            this.toolMenuItemOff.Click += new EventHandler(this.toolMenuItemOff_Click);
            base.AcceptButton = this.buttonSave;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.buttonClose;
            base.ClientSize = new Size(0x3c7, 0x2aa);
            base.Controls.Add(this.progressBar);
            base.Controls.Add(this.labelProgress);
            base.Controls.Add(this.buttonSave);
            base.Controls.Add(this.buttonClose);
            base.Controls.Add(this.tabControlMain);
            base.Name = "FormDamageHVAddEdit";
            this.Text = "FormDamageLVAddEdit";
            base.FormClosing += new FormClosingEventHandler(this.FormDamageHVAddEdit_FormClosing);
            base.Load += new EventHandler(this.FormDamageHVAddEdit_Load);
            base.Shown += new EventHandler(this.FormDamageHVAddEdit_Shown);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.dataSetDamage_0.EndInit();
            this.groupBoxDefectData.ResumeLayout(false);
            this.groupBoxDefectData.PerformLayout();
            ((ISupportInitialize)this.dgvCharacterDamage).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxDefect.ResumeLayout(false);
            this.groupBoxDefect.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((ISupportInitialize)this.dgvOn).EndInit();
            this.tabPageTransformer.ResumeLayout(false);
            this.tabPageTransformer.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((ISupportInitialize)this.dgvTrans).EndInit();
            ((ISupportInitialize)this.bindingSource_0).EndInit();
            this.dataSet_0.EndInit();
            this.tableTrans.EndInit();
            this.table_vl_SchmAbnFull.EndInit();
            ((ISupportInitialize)this.dgvTree).EndInit();
            this.statusStripTrans.ResumeLayout(false);
            this.statusStripTrans.PerformLayout();
            this.toolStripTransformer.ResumeLayout(false);
            this.toolStripTransformer.PerformLayout();
            this.tabPageAbn.ResumeLayout(false);
            this.tabPageAbn.PerformLayout();
            ((ISupportInitialize)this.dgvAbn).EndInit();
            ((ISupportInitialize)this.bindingSource_1).EndInit();
            this.statusStripAbn.ResumeLayout(false);
            this.statusStripAbn.PerformLayout();
            this.toolStripAbn.ResumeLayout(false);
            this.toolStripAbn.PerformLayout();
            this.contextMenuDgvTree.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        [CompilerGenerated]
        private bool method_65(ElectricObject electricObject_0)
        {
            return (electricObject_0.Id == Convert.ToInt32(this.dataSetDamage_0.tJ_Damage.Rows[0]["idSchmObj"]));
        }

        private DataTable method_7()
        {
            DataTable table1 = new DataTable("tR_Classifier");
            table1.Columns.Add("id", typeof(int));
            table1.Columns.Add("name", typeof(string));
            return table1;
        }

        private DataTable method_8()
        {
            DataTable table = new DataTable();
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("flag", typeof(bool));
            object[] values = new object[] { "", DBNull.Value };
            table.Rows.Add(values);
            object[] objArray2 = new object[] { "0", false };
            table.Rows.Add(objArray2);
            object[] objArray3 = new object[] { "1", true };
            table.Rows.Add(objArray3);
            return table;
        }

        private void method_9()
        {
            DataTable table = this.method_7();
            if (((this.tJ_DamageDataTable_0 != null) && (this.tJ_DamageDataTable_0.Rows.Count > 0)) && (this.tJ_DamageDataTable_0.Rows[0]["idDivision"] != DBNull.Value))
            {
                base.SelectSqlData(table, true, string.Format(" where (ParentKey = ';GroupWorker;DailyREport;' and isgroup = 0 and deleted = 0) \r\n                                            or (id = {0})", this.tJ_DamageDataTable_0.Rows[0]["idDivision"]));
            }
            else
            {
                base.SelectSqlData(table, true, " where ParentKey = ';GroupWorker;DailyREport;' and isgroup = 0 and deleted = 0");
            }
            this.cmbDivision.DisplayMember = "name";
            this.cmbDivision.ValueMember = "id";
            this.cmbDivision.DataSource = table;
            this.cmbDivision.SelectedIndex = -1;
        }

        private void dtpDataApply_ValueChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            if (this.dtpDataApply.Value != null)
            {
                this.label_7.ForeColor = Color.Black;
            }
        }

        private void rbOnAverage_CheckedChanged(object sender, EventArgs e)
        {
            this.method_63();
        }

        private void txtKWT_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
        }

        private void txtNumRequest_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtNumRequest.Text))
            {
                this.label_5.ForeColor = Color.Black;
            }
            this.isChangedData = true;
        }

        private void txtCoefSeason_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.method_60(this.dgvTree.Nodes);
            this.method_63();
        }

        private void txtDocParent_MouseHover(object sender, EventArgs e)
        {
        }

        private void txtDocParent_MouseLeave(object sender, EventArgs e)
        {
        }

        private void txtSchmObj_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtSchmObj.Text))
            {
                this.labelSchmObj.ForeColor = Color.Black;
            }
            this.isChangedData = true;
        }

        private void txtV_TextChanged(object sender, EventArgs e)
        {
            this.label_14.ForeColor = Color.Black;
            this.isChangedData = true;
            this.method_60(this.dgvTree.Nodes);
            this.method_63();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.method_36();
        }

        private void txtCountSchmObj_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.method_36();
        }

        private void txtCosFi_TextChanged(object sender, EventArgs e)
        {
            this.isChangedData = true;
            this.method_60(this.dgvTree.Nodes);
            this.method_63();
        }

        private void toolBtnRefreshAbn_Click(object sender, EventArgs e)
        {
            this.method_45();
        }

        private void toolMenuItemOn_Click(object sender, EventArgs e)
        {
            FormChooseDateOn on = new FormChooseDateOn();
            if (on.ShowDialog() == DialogResult.OK)
            {
                foreach (DataGridViewRow row in this.dgvTree.SelectedRows)
                {
                    row.Cells[this.dateOnColumn.Index].Value = on.method_0().ToString("dd.MM.yyyy HH:mm");
                    if (on.method_1())
                    {
                        TreeDataGridViewNode nodeForRow = this.dgvTree.GetNodeForRow(row);
                        this.method_61(nodeForRow, new DateTime?(on.method_0()));
                    }
                }
                this.method_60(this.dgvTree.Nodes);
                this.method_63();
                this.isChangedData = true;
            }
        }

        private void toolMenuItemOff_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvTree.SelectedRows)
            {
                row.Cells[this.dateOnColumn.Index].Value = null;
                TreeDataGridViewNode nodeForRow = this.dgvTree.GetNodeForRow(row);
                DateTime? nullable = null;
                this.method_61(nodeForRow, nullable);
            }
            this.method_60(this.dgvTree.Nodes);
            this.method_63();
            this.isChangedData = true;
        }

        private void dgvTree_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0))
            {
                if ((this.dgvTree[this.trNameColumn.Index, e.RowIndex].Value != null) && !string.IsNullOrEmpty(this.dgvTree[this.trNameColumn.Index, e.RowIndex].Value.ToString()))
                {
                    e.CellStyle.BackColor = Color.LightGray;
                }
                if ((this.dgvTree[this.dateOnColumn.Index, e.RowIndex].Value != null) && !string.IsNullOrEmpty(this.dgvTree[this.dateOnColumn.Index, e.RowIndex].Value.ToString()))
                {
                    e.CellStyle.ForeColor = Color.Blue;
                }
            }
        }

        private void dgvTree_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && ((e.Button == MouseButtons.Right) && !this.get_ViewDocDamageHV())) && !this.checkBoxApply.Checked)
            {
                this.contextMenuDgvTree.Show(Cursor.Position);
            }
        }

        //[Serializable, CompilerGenerated]
        //private sealed class C_1
        //{
        //    public static readonly FormDamageHVAddEdit.C_1 C_9 = new FormDamageHVAddEdit.C_1();
        //    public static Func<DataSetDamage.Class332, DateTime> C_9__128_0;
        //    public static Func<DataSetDamage.Class332, DateTime> C_9__51_0;

        //    internal DateTime method_0(DataSetDamage.Class332 class332_0)
        //    {
        //        return class332_0.Field<DateTime>("DateOn");
        //    }

        //    internal DateTime method_1(DataSetDamage.Class332 class332_0)
        //    {
        //        return class332_0.Field<DateTime>("DateOn");
        //    }
        //}

        private delegate TreeDataGridViewNode Delegate114(TreeDataGridViewNodeCollection treeDataGridViewNodeCollection_0, params object[] object_0);
    }

}