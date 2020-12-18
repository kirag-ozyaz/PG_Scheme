    using ControlsLbr.DataGridViewExcelFilter;
    using ControlsLbr.Scheme;
    using DataSql;
    using DailyReport.DataSets;
   // using Documents.Forms.DailyReport.Reports;
    using FormLbr;
    using SchemeModel;
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
using Documents.Reports;

namespace Documents.ActDetection
{
    /// <summary>
    /// Журнал актов расследования
    /// </summary>
    public class FormJournalActDetection : FormBase
    {
        private BindingSource bindingSource;
        private CheckBox checkBoxWhereSub;
        private ContextMenuStrip contextMenuDamage;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvActDetection;
        private DataGridViewFilterCheckBoxColumn isLaboratoryDgvColumn;
        //private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_1;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_11;
        private DataGridViewFilterTextBoxColumn workerApplyDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn completedWorkDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn compilerDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn InstructionDgvColumn;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_16;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_17;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_18;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_19;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_20;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_21;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_22;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_23;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_24;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_25;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_26;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_27;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private dsDamage dataSetDamage;
        private DateTimePicker dtpFilterEnd;
        private DateTimePicker dtpFilterBeg;
        private IContainer components = null;
        private Label label_0;
        private Label label_1;
        private List<int> list_0;
        private SplitContainer splitContainer_0;
        private ToolStrip toolStrip;
        private ToolStrip toolStripFilter;
        private ToolStrip toolStripTreeSchmObj;
        private ToolStripButton toolBtnFilterApply;
        private ToolStripButton toolBtnFilterDelete;
        private ToolStripButton toolBtnRefresh;
        private ToolStripButton toolBtnFind;
        private ToolStripButton toolBtnFindPrev;
        private ToolStripButton toolBtnFindNext;
        private ToolStripButton toolBtnDamageNoApply;
        private ToolStripButton toolBtnExportExcel;
        private ToolStripButton toolBtnPrint;
        private ToolStripButton toolBtnAdd;
        private ToolStripButton toolBtnPrevYear;
        private ToolStripButton toolBtnNextYear;
        private ToolStripButton toolBtnEdit;
        private ToolStripButton toolBtnInfo;
        private ToolStripButton toolBtnFindTreeSchmObj;
        private ToolStripButton toolBtnFindPrevTreeSchmObj;
        private ToolStripButton toolBtnFindNextTreeSchmObj;
        private ToolStripButton toolBtnDel;
        private ToolStripDropDownButton toolBtnReport;
        private ToolStripDropDownButton toolBTnLoadOld;
        private ToolStripMenuItem toolBtnLoadOldDamageLV;
        private ToolStripMenuItem toolBtnLoadOldDefect;
        private ToolStripMenuItem toolBtnLoadAbnDefectLV;
        private ToolStripMenuItem toolBtnLoadOldDamageНV;
        private ToolStripMenuItem toolItemAdd;
        private ToolStripMenuItem toolItemEdit;
        private ToolStripMenuItem toolItemInfo;
        private ToolStripMenuItem toolItemDel;
        private ToolStripMenuItem tsMenuAmergencyShutdown;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripSeparator toolStripSeparator_3;
        private ToolStripTextBox txtFindTreeSchmObj;
        private ToolStripTextBox txtFind;
        private DataGridViewFilterTextBoxColumn numrequestDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn numDocDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateDocDgvColumn;
        private DataGridViewFilterTextBoxColumn typeDocNameDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn divisionDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn schmObjNameDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn netRegionSubDgvColumn;
        private DataGridViewFilterTextBoxColumn numcrashDgvColumn;
        private DataGridViewFilterTextBoxColumn defectLocationDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn reasonDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn divisionApplyDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateApplyDgvColumn;
        private DataGridViewFilterCheckBoxColumn isApplyDgvColumn;
        private DataGridViewFilterTextBoxColumn nameOwnerDgvColumn;
        private DataGridViewFilterTextBoxColumn dateOwnerDgvColumn;
        private DataGridViewTextBoxColumn comletedWorkTextDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn KodPTSDgvColumn;
        private DataGridViewFilterTextBoxColumn kodPTSStrDgvColumn;
        private DataGridViewTextBoxColumn idParentDgvColumn;
        private DataGridViewTextBoxColumn typeDocDgvColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn signCrashTypeDgvActDetection;
        private DataGridViewFilterTextBoxColumn signCrashNameDgvActDetection;
        private DataGridViewFilterTextBoxColumn typeEquipDgvActDetection;
        private DataGridViewFilterTextBoxColumn typeEquipNameDgvActDetection;
        private DataGridViewFilterTextBoxColumn reasonCrashEquipTypeDgvActDetection;
        private DataGridViewFilterTextBoxColumn reasonCrashEquipNameDgvActDetection;
        private DataGridViewFilterTextBoxColumn reasonCrashTypeDgvActDetection;
        private DataGridViewFilterTextBoxColumn reasonCrashNameDgvActDetection;
        private TreeViewSchmObjects treeViewSchmObjects;

        public FormJournalActDetection()
        {
            this.InitializeComponent();
            this.toolBTnLoadOld.Visible = false;
        }

        public FormJournalActDetection(List<int> checkedSubstation)
        {
            this.InitializeComponent();
            this.list_0 = checkedSubstation;
            this.toolBTnLoadOld.Visible = false;
        }

        protected override void ApplyConfig(XmlDocument xmlDocument_0)
        {
            List<int> list = new List<int>();
            XmlNode node = xmlDocument_0.SelectSingleNode(base.Name);
            if (node != null)
            {
                //using (IEnumerator enumerator = node.SelectNodes("CheckDivision").GetEnumerator())
                //{
                //    while (enumerator.MoveNext())
                    foreach (IEnumerator enumerator in node.SelectNodes("CheckDivision"))
                    {
                        XmlAttribute attribute2 = ((XmlNode) enumerator.Current).Attributes["Id"];
                        if (attribute2 != null)
                        {
                            list.Add(Convert.ToInt32(attribute2.Value));
                        }
                    }
                //}
                XmlAttribute attribute = node.Attributes["dateBeg"];
                if (attribute.Value != null)
                {
                    this.dtpFilterBeg.Value = Convert.ToDateTime(attribute.Value);
                }
                attribute = node.Attributes["dateEnd"];
                if (attribute.Value != null)
                {
                    this.dtpFilterEnd.Value = Convert.ToDateTime(attribute.Value);
                }
            }
        }

        private void contextMenuDamage_Opening(object sender, CancelEventArgs e)
        {
            if (this.bindingSource.Current != null)
            {
                this.toolItemEdit.Enabled = true;
                this.toolItemInfo.Enabled = true;
                this.toolItemDel.Enabled = true;
            }
            else
            {
                this.toolItemEdit.Enabled = false;
                this.toolItemInfo.Enabled = false;
                this.toolItemDel.Enabled = false;
            }
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document1 = new XmlDocument();
            XmlNode newChild = document1.CreateXmlDeclaration("1.0", "UTF-8", null);
            document1.AppendChild(newChild);
            XmlNode node2 = document1.CreateElement(base.Name);
            document1.AppendChild(node2);
            XmlAttribute node = document1.CreateAttribute("dateBeg");
            node.Value = this.dtpFilterBeg.Value.ToString();
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("dateEnd");
            node.Value = this.dtpFilterEnd.Value.ToString();
            node2.Attributes.Append(node);
            return document1;
        }

        private void ddgvActDetection_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0))
            {
                if (this.toolBtnEdit.Enabled && this.toolBtnEdit.Visible)
                {
                    this.toolBtnEdit_Click(sender, e);
                }
                else if (this.toolBtnInfo.Enabled && this.toolBtnInfo.Visible)
                {
                    this.toolBtnInfo_Click(sender, e);
                }
            }
        }

        private void dgvActDetection_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (((this.dgvActDetection[this.isApplyDgvColumn.Name, e.RowIndex].Value != DBNull.Value) && (this.dgvActDetection[this.isApplyDgvColumn.Name, e.RowIndex].Value != null)) && Convert.ToBoolean(this.dgvActDetection[this.isApplyDgvColumn.Name, e.RowIndex].Value))
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (((this.dgvActDetection[this.dateDocDgvColumn.Name, e.RowIndex].Value != DBNull.Value) && (this.dgvActDetection[this.dateDocDgvColumn.Name, e.RowIndex].Value != null)) && (Convert.ToDateTime(this.dgvActDetection[this.dateDocDgvColumn.Name, e.RowIndex].Value).Date < DateTime.Now.Date.AddDays(-10.0)))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void dgvActDetection_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (e.Button == MouseButtons.Right))
            {
                this.contextMenuDamage.Show(Cursor.Position);
            }
        }

        private void dgvActDetection_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvActDetection.AutoResizeRow(e.RowIndex);
        }

        private void dtpFilterEnd_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpFilterEnd.Value < this.dtpFilterBeg.Value)
            {
                this.dtpFilterBeg.Value = this.dtpFilterEnd.Value;
            }
        }

        private void ddtpFilterBeg_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpFilterBeg.Value > this.dtpFilterEnd.Value)
            {
                this.dtpFilterEnd.Value = this.dtpFilterBeg.Value;
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

        private void FormJournalActDetection_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormJournalActDetection_Load(object sender, EventArgs e)
        {
            this.method_5();
            this.method_0();
            base.LoadFormConfig(null);
            this.treeViewSchmObjects.SqlSettings=(this.SqlSettings);
            this.treeViewSchmObjects.Load(this.list_0);
            this.ActDetectionSearchGrid(-1);
        }

        private void method_0()
        {
            this.dtpFilterEnd.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddSeconds(-1.0);
            this.dtpFilterBeg.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.treeViewSchmObjects.ClearTreeChecked();
        }

        private void OpenDocument(int? idDoc = new int?(), bool statusPositioningOnCloseForm = false)
        {
            DailyReport.JournalActDetection.FormActDetectionAddEdit form = new DailyReport.JournalActDetection.FormActDetectionAddEdit(idDoc);
            form.SqlSettings = (this.SqlSettings);
            form.MdiParent = base.MdiParent;
            form.FormViewMode((statusPositioningOnCloseForm));
            if (!statusPositioningOnCloseForm)
            {
                form.FormClosed += new FormClosedEventHandler(this.FormActDetectionAddEdit_FormClosed);
            }
            form.Show();
        }

        private void FormActDetectionAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((sender is Form) && (((Form) sender).DialogResult == DialogResult.OK))
            {
                int IdDocument = -1;
                if ((sender is DailyReport.JournalActDetection.FormActDetectionAddEdit) && ((DailyReport.JournalActDetection.FormActDetectionAddEdit) sender).IdDocument.HasValue)
                {
                    IdDocument = ((DailyReport.JournalActDetection.FormActDetectionAddEdit) sender).IdDocument.Value;
                }
                this.ActDetectionSearchGrid(IdDocument);
            }
        }

        private void method_3(int int_0)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("update tj_damage \r\n                                                          set idParent = null\r\n                                                          where idParent = {0} and isApply = 1", int_0);
                        command.ExecuteNonQuery();
                        command.CommandText = string.Format("delete tj_damage \r\n                                                          where idParent = {0} and (isApply = 0 or isApply is null)", int_0.ToString());
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }

        private void ActDetectionSearchGrid(int idDoc = -1)
        {
            if ((idDoc == -1) && (this.dgvActDetection.CurrentRow != null))
            {
                idDoc = Convert.ToInt32(this.dgvActDetection.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
            }
            string str = "select d.*, c_sc.Name as signCrashType, c_sc.Name + ' ' + c_sc.Comment as signCrashName,\r\nc_te.Name as typeEquip, c_te.Name + ' ' + c_te.Comment as typeEquipName,\r\nc_rce.Name as reasonCrashEquipType, c_rce.Name + ' ' + c_rce.Comment as reasonCrashEquipName,\r\nc_rc.Name as reasonCrashType, c_rc.Name + ' ' + c_rc.Comment as reasonCrashName\r\n" +
                "from vJ_Damage as d\r\nleft join tJ_DamageActDetection as dAct on dAct.idDamage = d.id\r\nleft join tR_Classifier as c_sc on c_sc.Id = dAct.idSignCrash\r\nleft join tR_Classifier as c_te on c_te.Id = dAct.idTypeEquipment\r\nleft join tR_Classifier as c_rce on c_rce.Id = dAct.idReasonCrashEquipment\r\nleft join tR_Classifier as c_rc on c_rc.Id = dAct.idReasonCrash\r\n";
            string str2 = "";
            str2 = string.Format(" where (d.deleted = 0) and ((d.dateDoc >= '{0}' and d.dateDoc < '{1}') or d.dateDoc is null)", this.dtpFilterBeg.Value.ToString("yyyyMMdd"), this.dtpFilterEnd.Value.AddDays(1.0).ToString("yyyyMMdd")) + string.Format(" and (d.TypeDoc = {0}) ", 0x752);
            List<int> listChecked = this.treeViewSchmObjects.GetListChecked();
            if (listChecked.Count > 0)
            {
                string idSchmObj = "";
                foreach (int num in listChecked)
                {
                    if (string.IsNullOrEmpty(idSchmObj))
                    {
                        idSchmObj = num.ToString();
                    }
                    else
                    {
                        idSchmObj = idSchmObj + "," + num.ToString();
                    }
                }
                if (this.checkBoxWhereSub.Checked)
                {
                    str2 = str2 + string.Format(" and (d.idSchmObj in ({0}) or d.idSub in ({0}))", idSchmObj);
                }
                else
                {
                    str2 = str2 + string.Format(" and (d.idSchmObj in ({0}))", idSchmObj);
                }
            }
            str = str + str2;
            DataTable table = new SqlDataCommand(this.SqlSettings).SelectSqlData(str);
            this.dgvActDetection.AutoGenerateColumns = false;
            this.bindingSource.DataSource = table;
            this.dgvActDetection.SearchGrid(this.idDataGridViewTextBoxColumn.Name, idDoc.ToString(), true);
        }

        private void method_5()
        {
            DataTable table = new DataTable("tUser");
            table.Columns.Add("idUser", typeof(int));
            base.SelectSqlData(table, true, " left join vworkergroup w on w.id = tuser.idWorker\r\n                                where w.ParentKey = ';GroupWorker;DailyReport;AdminActDetection;' and tuser.login = SYSTEM_USER", null, false, 0);
            if (table.Rows.Count > 0)
            {
                this.toolBtnDamageNoApply.Visible = true;
            }
            else
            {
                this.toolBtnDamageNoApply.Visible = false;
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolBtnInfo = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnFind = new System.Windows.Forms.ToolStripButton();
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnReport = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsMenuAmergencyShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBTnLoadOld = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolBtnLoadOldDamageLV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnLoadOldDefect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnLoadAbnDefectLV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnLoadOldDamageНV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnDamageNoApply = new System.Windows.Forms.ToolStripButton();
            this.toolBtnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolBtnPrint = new System.Windows.Forms.ToolStripButton();
            this.splitContainer_0 = new System.Windows.Forms.SplitContainer();
            this.checkBoxWhereSub = new System.Windows.Forms.CheckBox();
            this.toolStripTreeSchmObj = new System.Windows.Forms.ToolStrip();
            this.toolBtnFindTreeSchmObj = new System.Windows.Forms.ToolStripButton();
            this.txtFindTreeSchmObj = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindPrevTreeSchmObj = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFindNextTreeSchmObj = new System.Windows.Forms.ToolStripButton();
            this.treeViewSchmObjects = new ControlsLbr.Scheme.TreeViewSchmObjects();
            this.dtpFilterEnd = new System.Windows.Forms.DateTimePicker();
            this.label_0 = new System.Windows.Forms.Label();
            this.dtpFilterBeg = new System.Windows.Forms.DateTimePicker();
            this.label_1 = new System.Windows.Forms.Label();
            this.toolStripFilter = new System.Windows.Forms.ToolStrip();
            this.toolBtnFilterApply = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFilterDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnPrevYear = new System.Windows.Forms.ToolStripButton();
            this.toolBtnNextYear = new System.Windows.Forms.ToolStripButton();
            this.dgvActDetection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.numrequestDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.numDocDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateDocDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeDocNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.schmObjNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.netRegionSubDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.numcrashDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.defectLocationDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.divisionApplyDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.isLaboratoryDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.dateApplyDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.isApplyDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.workerApplyDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.completedWorkDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.compilerDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.InstructionDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameOwnerDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateOwnerDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.comletedWorkTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodPTSDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.kodPTSStrDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idParentDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signCrashTypeDgvActDetection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.signCrashNameDgvActDetection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeEquipDgvActDetection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeEquipNameDgvActDetection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.reasonCrashEquipTypeDgvActDetection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.reasonCrashEquipNameDgvActDetection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.reasonCrashTypeDgvActDetection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.reasonCrashNameDgvActDetection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDamage = new dsDamage();
            this.toolItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDamage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip.SuspendLayout();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.toolStripTreeSchmObj.SuspendLayout();
            this.toolStripFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActDetection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).BeginInit();
            this.contextMenuDamage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAdd,
            this.toolBtnEdit,
            this.toolBtnInfo,
            this.toolBtnDel,
            this.toolStripSeparator1,
            this.toolBtnRefresh,
            this.toolStripSeparator_1,
            this.toolBtnFind,
            this.txtFind,
            this.toolBtnFindPrev,
            this.toolBtnFindNext,
            this.toolStripSeparator_2,
            this.toolBtnReport,
            this.toolBTnLoadOld,
            this.toolBtnDamageNoApply,
            this.toolBtnExportExcel,
            this.toolBtnPrint});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1022, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolBtnAdd
            // 
            this.toolBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAdd.Image = global::DailyReport.Properties.Resources.ElementAdd;
            this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAdd.Text = "Добавить";
            this.toolBtnAdd.Click += new System.EventHandler(this.toolItemAdd_Click);
            // 
            // toolBtnEdit
            // 
            this.toolBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnEdit.Image = global::DailyReport.Properties.Resources.ElementEdit;
            this.toolBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEdit.Name = "toolBtnEdit";
            this.toolBtnEdit.Size = new System.Drawing.Size(23, 22);
            this.toolBtnEdit.Text = "Редактировать";
            this.toolBtnEdit.Click += new System.EventHandler(this.toolBtnEdit_Click);
            // 
            // toolBtnInfo
            // 
            this.toolBtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnInfo.Image = global::DailyReport.Properties.Resources.ElementInformation;
            this.toolBtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnInfo.Name = "toolBtnInfo";
            this.toolBtnInfo.Size = new System.Drawing.Size(23, 22);
            this.toolBtnInfo.Text = "Информация";
            this.toolBtnInfo.Click += new System.EventHandler(this.toolBtnInfo_Click);
            // 
            // toolBtnDel
            // 
            this.toolBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDel.Image = global::DailyReport.Properties.Resources.ElementDel;
            this.toolBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDel.Name = "toolBtnDel";
            this.toolBtnDel.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDel.Text = "Удалить документ";
            this.toolBtnDel.Click += new System.EventHandler(this.toolBtnDel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnRefresh
            // 
            this.toolBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefresh.Image = global::DailyReport.Properties.Resources.Refresh;
            this.toolBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRefresh.Name = "toolBtnRefresh";
            this.toolBtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolBtnRefresh.Text = "Обновить";
            this.toolBtnRefresh.Click += new System.EventHandler(this.toolBtnRefresh_Click);
            // 
            // toolStripSeparator_1
            // 
            this.toolStripSeparator_1.Name = "toolStripSeparator_1";
            this.toolStripSeparator_1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnFind
            // 
            this.toolBtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFind.Image = global::DailyReport.Properties.Resources.Find;
            this.toolBtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFind.Name = "toolBtnFind";
            this.toolBtnFind.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFind.Text = "Искать";
            this.toolBtnFind.Click += new System.EventHandler(this.toolBtnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 25);
            this.txtFind.ToolTipText = "Текст для поиска";
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // toolBtnFindPrev
            // 
            this.toolBtnFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrev.Image = global::DailyReport.Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindPrev.Text = "Искать назад";
            this.toolBtnFindPrev.Click += new System.EventHandler(this.toolBtnFindPrev_Click);
            // 
            // toolBtnFindNext
            // 
            this.toolBtnFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNext.Image = global::DailyReport.Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindNext.Text = "Искать вперед";
            this.toolBtnFindNext.Click += new System.EventHandler(this.toolBtnFindNext_Click);
            // 
            // toolStripSeparator_2
            // 
            this.toolStripSeparator_2.Name = "toolStripSeparator_2";
            this.toolStripSeparator_2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnReport
            // 
            this.toolBtnReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuAmergencyShutdown});
            this.toolBtnReport.Image = global::DailyReport.Properties.Resources.Report;
            this.toolBtnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReport.Name = "toolBtnReport";
            this.toolBtnReport.Size = new System.Drawing.Size(29, 22);
            this.toolBtnReport.Text = "Отчеты";
            // 
            // tsMenuAmergencyShutdown
            // 
            this.tsMenuAmergencyShutdown.Name = "tsMenuAmergencyShutdown";
            this.tsMenuAmergencyShutdown.Size = new System.Drawing.Size(270, 22);
            this.tsMenuAmergencyShutdown.Text = "Бюллетень аварийных отключений";
            this.tsMenuAmergencyShutdown.Click += new System.EventHandler(this.tsMenuAmergencyShutdown_Click);
            // 
            // toolBTnLoadOld
            // 
            this.toolBTnLoadOld.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBTnLoadOld.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBTnLoadOld.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnLoadOldDamageLV,
            this.toolBtnLoadOldDefect,
            this.toolBtnLoadAbnDefectLV,
            this.toolBtnLoadOldDamageНV});
            this.toolBTnLoadOld.Image = global::DailyReport.Properties.Resources.Load;
            this.toolBTnLoadOld.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBTnLoadOld.Name = "toolBTnLoadOld";
            this.toolBTnLoadOld.Size = new System.Drawing.Size(29, 22);
            this.toolBTnLoadOld.Text = "Загрузка из старой базы";
            // 
            // toolBtnLoadOldDamageLV
            // 
            this.toolBtnLoadOldDamageLV.Name = "toolBtnLoadOldDamageLV";
            this.toolBtnLoadOldDamageLV.Size = new System.Drawing.Size(210, 22);
            this.toolBtnLoadOldDamageLV.Text = "0.4кВ";
            this.toolBtnLoadOldDamageLV.Click += new System.EventHandler(this.toolBtnLoadOldDamageLV_Click);
            // 
            // toolBtnLoadOldDefect
            // 
            this.toolBtnLoadOldDefect.Name = "toolBtnLoadOldDefect";
            this.toolBtnLoadOldDefect.Size = new System.Drawing.Size(210, 22);
            this.toolBtnLoadOldDefect.Text = "Дефект";
            this.toolBtnLoadOldDefect.Click += new System.EventHandler(this.toolBtnLoadOldDefect_Click);
            // 
            // toolBtnLoadAbnDefectLV
            // 
            this.toolBtnLoadAbnDefectLV.Name = "toolBtnLoadAbnDefectLV";
            this.toolBtnLoadAbnDefectLV.Size = new System.Drawing.Size(210, 22);
            this.toolBtnLoadAbnDefectLV.Text = "Загрузить абонентов НН";
            this.toolBtnLoadAbnDefectLV.Click += new System.EventHandler(this.toolBtnLoadAbnDefectLV_Click);
            // 
            // toolBtnLoadOldDamageНV
            // 
            this.toolBtnLoadOldDamageНV.Name = "toolBtnLoadOldDamageНV";
            this.toolBtnLoadOldDamageНV.Size = new System.Drawing.Size(210, 22);
            this.toolBtnLoadOldDamageНV.Text = "ВН";
            this.toolBtnLoadOldDamageНV.Click += new System.EventHandler(this.toolBtnLoadOldDamageНV_Click);
            // 
            // toolBtnDamageNoApply
            // 
            this.toolBtnDamageNoApply.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBtnDamageNoApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDamageNoApply.Image = global::DailyReport.Properties.Resources.ElementAccept;
            this.toolBtnDamageNoApply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDamageNoApply.Name = "toolBtnDamageNoApply";
            this.toolBtnDamageNoApply.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDamageNoApply.Text = "Разблокировать документ";
            this.toolBtnDamageNoApply.Visible = false;
            this.toolBtnDamageNoApply.Click += new System.EventHandler(this.toolBtnDamageNoApply_Click);
            // 
            // toolBtnExportExcel
            // 
            this.toolBtnExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnExportExcel.Image = global::DailyReport.Properties.Resources.Excel;
            this.toolBtnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnExportExcel.Name = "toolBtnExportExcel";
            this.toolBtnExportExcel.Size = new System.Drawing.Size(23, 22);
            this.toolBtnExportExcel.Text = "Экспорт в Excel";
            this.toolBtnExportExcel.Click += new System.EventHandler(this.toolBtnExportExcel_Click);
            // 
            // toolBtnPrint
            // 
            this.toolBtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnPrint.Image = global::DailyReport.Properties.Resources.Print;
            this.toolBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnPrint.Name = "toolBtnPrint";
            this.toolBtnPrint.Size = new System.Drawing.Size(23, 22);
            this.toolBtnPrint.Text = "Печать";
            this.toolBtnPrint.Click += new System.EventHandler(this.toolStripButton_16_Click);
            // 
            // splitContainer_0
            // 
            this.splitContainer_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_0.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_0.Location = new System.Drawing.Point(0, 25);
            this.splitContainer_0.Name = "splitContainer_0";
            // 
            // splitContainer_0.Panel1
            // 
            this.splitContainer_0.Panel1.Controls.Add(this.checkBoxWhereSub);
            this.splitContainer_0.Panel1.Controls.Add(this.toolStripTreeSchmObj);
            this.splitContainer_0.Panel1.Controls.Add(this.treeViewSchmObjects);
            this.splitContainer_0.Panel1.Controls.Add(this.dtpFilterEnd);
            this.splitContainer_0.Panel1.Controls.Add(this.label_0);
            this.splitContainer_0.Panel1.Controls.Add(this.dtpFilterBeg);
            this.splitContainer_0.Panel1.Controls.Add(this.label_1);
            this.splitContainer_0.Panel1.Controls.Add(this.toolStripFilter);
            // 
            // splitContainer_0.Panel2
            // 
            this.splitContainer_0.Panel2.Controls.Add(this.dgvActDetection);
            this.splitContainer_0.Size = new System.Drawing.Size(1022, 577);
            this.splitContainer_0.SplitterDistance = 258;
            this.splitContainer_0.TabIndex = 1;
            // 
            // checkBoxWhereSub
            // 
            this.checkBoxWhereSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxWhereSub.AutoSize = true;
            this.checkBoxWhereSub.Checked = true;
            this.checkBoxWhereSub.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWhereSub.Location = new System.Drawing.Point(15, 555);
            this.checkBoxWhereSub.Name = "checkBoxWhereSub";
            this.checkBoxWhereSub.Size = new System.Drawing.Size(180, 17);
            this.checkBoxWhereSub.TabIndex = 12;
            this.checkBoxWhereSub.Text = "Фильтровать по подстанциям";
            this.checkBoxWhereSub.UseVisualStyleBackColor = true;
            // 
            // toolStripTreeSchmObj
            // 
            this.toolStripTreeSchmObj.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTreeSchmObj.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripTreeSchmObj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnFindTreeSchmObj,
            this.txtFindTreeSchmObj,
            this.toolBtnFindPrevTreeSchmObj,
            this.toolBtnFindNextTreeSchmObj});
            this.toolStripTreeSchmObj.Location = new System.Drawing.Point(15, 103);
            this.toolStripTreeSchmObj.Name = "toolStripTreeSchmObj";
            this.toolStripTreeSchmObj.Size = new System.Drawing.Size(174, 25);
            this.toolStripTreeSchmObj.TabIndex = 11;
            this.toolStripTreeSchmObj.Text = "toolStrip1";
            // 
            // toolBtnFindTreeSchmObj
            // 
            this.toolBtnFindTreeSchmObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindTreeSchmObj.Image = global::DailyReport.Properties.Resources.Find;
            this.toolBtnFindTreeSchmObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindTreeSchmObj.Name = "toolBtnFindTreeSchmObj";
            this.toolBtnFindTreeSchmObj.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindTreeSchmObj.Text = "Искать";
            this.toolBtnFindTreeSchmObj.Click += new System.EventHandler(this.toolBtnFindTreeSchmObj_Click);
            // 
            // txtFindTreeSchmObj
            // 
            this.txtFindTreeSchmObj.Name = "txtFindTreeSchmObj";
            this.txtFindTreeSchmObj.Size = new System.Drawing.Size(100, 25);
            this.txtFindTreeSchmObj.ToolTipText = "Текст для поиска";
            this.txtFindTreeSchmObj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFindTreeSchmObj_KeyDown);
            // 
            // toolBtnFindPrevTreeSchmObj
            // 
            this.toolBtnFindPrevTreeSchmObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrevTreeSchmObj.Image = global::DailyReport.Properties.Resources.FindPrev;
            this.toolBtnFindPrevTreeSchmObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindPrevTreeSchmObj.Name = "toolBtnFindPrevTreeSchmObj";
            this.toolBtnFindPrevTreeSchmObj.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindPrevTreeSchmObj.Text = "Искать назад";
            this.toolBtnFindPrevTreeSchmObj.Click += new System.EventHandler(this.toolBtnFindPrevTreeSchmObj_Click);
            // 
            // toolBtnFindNextTreeSchmObj
            // 
            this.toolBtnFindNextTreeSchmObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNextTreeSchmObj.Image = global::DailyReport.Properties.Resources.FindNext;
            this.toolBtnFindNextTreeSchmObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindNextTreeSchmObj.Name = "toolBtnFindNextTreeSchmObj";
            this.toolBtnFindNextTreeSchmObj.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindNextTreeSchmObj.Text = "Искать вперед";
            this.toolBtnFindNextTreeSchmObj.Click += new System.EventHandler(this.toolBtnFindNextTreeSchmObj_Click);
            // 
            // treeViewSchmObjects
            // 
            this.treeViewSchmObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewSchmObjects.CheckBoxes = true;
            this.treeViewSchmObjects.Location = new System.Drawing.Point(12, 127);
            this.treeViewSchmObjects.Name = "treeViewSchmObjects";
            this.treeViewSchmObjects.Size = new System.Drawing.Size(234, 423);
            this.treeViewSchmObjects.SqlSettings = null;
            this.treeViewSchmObjects.TabIndex = 10;
            // 
            // dtpFilterEnd
            // 
            this.dtpFilterEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFilterEnd.CausesValidation = false;
            this.dtpFilterEnd.Location = new System.Drawing.Point(12, 80);
            this.dtpFilterEnd.Name = "dtpFilterEnd";
            this.dtpFilterEnd.Size = new System.Drawing.Size(234, 20);
            this.dtpFilterEnd.TabIndex = 4;
            this.dtpFilterEnd.ValueChanged += new System.EventHandler(this.dtpFilterEnd_ValueChanged);
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.Location = new System.Drawing.Point(12, 64);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(22, 13);
            this.label_0.TabIndex = 3;
            this.label_0.Text = "До";
            // 
            // dtpFilterBeg
            // 
            this.dtpFilterBeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFilterBeg.CausesValidation = false;
            this.dtpFilterBeg.Location = new System.Drawing.Point(12, 41);
            this.dtpFilterBeg.Name = "dtpFilterBeg";
            this.dtpFilterBeg.Size = new System.Drawing.Size(234, 20);
            this.dtpFilterBeg.TabIndex = 2;
            this.dtpFilterBeg.ValueChanged += new System.EventHandler(this.ddtpFilterBeg_ValueChanged);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(12, 25);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(20, 13);
            this.label_1.TabIndex = 1;
            this.label_1.Text = "От";
            // 
            // toolStripFilter
            // 
            this.toolStripFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnFilterApply,
            this.toolBtnFilterDelete,
            this.toolStripSeparator_3,
            this.toolBtnPrevYear,
            this.toolBtnNextYear});
            this.toolStripFilter.Location = new System.Drawing.Point(0, 0);
            this.toolStripFilter.Name = "toolStripFilter";
            this.toolStripFilter.Size = new System.Drawing.Size(258, 25);
            this.toolStripFilter.TabIndex = 0;
            this.toolStripFilter.Text = "toolStrip1";
            // 
            // toolBtnFilterApply
            // 
            this.toolBtnFilterApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFilterApply.Image = global::DailyReport.Properties.Resources.filter;
            this.toolBtnFilterApply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFilterApply.Name = "toolBtnFilterApply";
            this.toolBtnFilterApply.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFilterApply.Text = "Применить фильтр";
            this.toolBtnFilterApply.Click += new System.EventHandler(this.toolBtnFilterApply_Click);
            // 
            // toolBtnFilterDelete
            // 
            this.toolBtnFilterDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFilterDelete.Image = global::DailyReport.Properties.Resources.filter_delete;
            this.toolBtnFilterDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFilterDelete.Name = "toolBtnFilterDelete";
            this.toolBtnFilterDelete.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFilterDelete.Text = "Убрать фильтр";
            this.toolBtnFilterDelete.Click += new System.EventHandler(this.toolBtnFilterDelete_Click);
            // 
            // toolStripSeparator_3
            // 
            this.toolStripSeparator_3.Name = "toolStripSeparator_3";
            this.toolStripSeparator_3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnPrevYear
            // 
            this.toolBtnPrevYear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnPrevYear.Image = global::DailyReport.Properties.Resources.arrowPrev;
            this.toolBtnPrevYear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnPrevYear.Name = "toolBtnPrevYear";
            this.toolBtnPrevYear.Size = new System.Drawing.Size(23, 22);
            this.toolBtnPrevYear.Text = "Предыдущий год";
            this.toolBtnPrevYear.Click += new System.EventHandler(this.toolStripButton_2_Click);
            // 
            // toolBtnNextYear
            // 
            this.toolBtnNextYear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnNextYear.Image = global::DailyReport.Properties.Resources.arrowNext;
            this.toolBtnNextYear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnNextYear.Name = "toolBtnNextYear";
            this.toolBtnNextYear.Size = new System.Drawing.Size(23, 22);
            this.toolBtnNextYear.Text = "Следующий год";
            this.toolBtnNextYear.Click += new System.EventHandler(this.toolBtnNextYear_Click);
            // 
            // dgvActDetection
            // 
            this.dgvActDetection.AllowUserToAddRows = false;
            this.dgvActDetection.AllowUserToDeleteRows = false;
            this.dgvActDetection.AllowUserToOrderColumns = true;
            this.dgvActDetection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActDetection.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActDetection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActDetection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActDetection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numrequestDataGridViewTextBoxColumn,
            this.numDocDataGridViewTextBoxColumn,
            this.dateDocDgvColumn,
            this.typeDocNameDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.schmObjNameDataGridViewTextBoxColumn,
            this.netRegionSubDgvColumn,
            this.numcrashDgvColumn,
            this.defectLocationDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.divisionApplyDataGridViewTextBoxColumn,
            this.isLaboratoryDgvColumn,
            this.dateApplyDgvColumn,
            this.isApplyDgvColumn,
            this.workerApplyDataGridViewTextBoxColumn,
            this.completedWorkDataGridViewTextBoxColumn,
            this.compilerDataGridViewTextBoxColumn,
            this.InstructionDgvColumn,
            this.nameOwnerDgvColumn,
            this.dateOwnerDgvColumn,
            this.comletedWorkTextDataGridViewTextBoxColumn,
            this.KodPTSDgvColumn,
            this.kodPTSStrDgvColumn,
            this.idParentDgvColumn,
            this.typeDocDgvColumn,
            this.idDataGridViewTextBoxColumn,
            this.signCrashTypeDgvActDetection,
            this.signCrashNameDgvActDetection,
            this.typeEquipDgvActDetection,
            this.typeEquipNameDgvActDetection,
            this.reasonCrashEquipTypeDgvActDetection,
            this.reasonCrashEquipNameDgvActDetection,
            this.reasonCrashTypeDgvActDetection,
            this.reasonCrashNameDgvActDetection});
            this.dgvActDetection.DataSource = this.bindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActDetection.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvActDetection.Location = new System.Drawing.Point(0, 0);
            this.dgvActDetection.Name = "dgvActDetection";
            this.dgvActDetection.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActDetection.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvActDetection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActDetection.Size = new System.Drawing.Size(760, 577);
            this.dgvActDetection.TabIndex = 0;
            this.dgvActDetection.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ddgvActDetection_CellDoubleClick);
            this.dgvActDetection.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvActDetection_CellFormatting);
            this.dgvActDetection.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvActDetection_CellMouseClick);
            this.dgvActDetection.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvActDetection_RowPostPaint);
            //this.dgvActDetection.DoubleClick += new System.EventHandler(this.dgvActDetection_DoubleClick);
            // 
            // numrequestDataGridViewTextBoxColumn
            // 
            this.numrequestDataGridViewTextBoxColumn.DataPropertyName = "numrequest";
            this.numrequestDataGridViewTextBoxColumn.HeaderText = "№ заявки";
            this.numrequestDataGridViewTextBoxColumn.Name = "numrequestDataGridViewTextBoxColumn";
            this.numrequestDataGridViewTextBoxColumn.ReadOnly = true;
            this.numrequestDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // numDocDataGridViewTextBoxColumn
            // 
            this.numDocDataGridViewTextBoxColumn.DataPropertyName = "numDoc";
            this.numDocDataGridViewTextBoxColumn.HeaderText = "№ документа";
            this.numDocDataGridViewTextBoxColumn.Name = "numDocDataGridViewTextBoxColumn";
            this.numDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDocDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numDocDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDocDgvColumn
            // 
            this.dateDocDgvColumn.DataPropertyName = "dateDoc";
            this.dateDocDgvColumn.HeaderText = "Дата заявки";
            this.dateDocDgvColumn.Name = "dateDocDgvColumn";
            this.dateDocDgvColumn.ReadOnly = true;
            this.dateDocDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeDocNameDataGridViewTextBoxColumn
            // 
            this.typeDocNameDataGridViewTextBoxColumn.DataPropertyName = "TypeDocName";
            this.typeDocNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDocNameDataGridViewTextBoxColumn.Name = "typeDocNameDataGridViewTextBoxColumn";
            this.typeDocNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDocNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDocNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            this.divisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.divisionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.divisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // schmObjNameDataGridViewTextBoxColumn
            // 
            this.schmObjNameDataGridViewTextBoxColumn.DataPropertyName = "schmObjName";
            this.schmObjNameDataGridViewTextBoxColumn.HeaderText = "Электроустановка";
            this.schmObjNameDataGridViewTextBoxColumn.Name = "schmObjNameDataGridViewTextBoxColumn";
            this.schmObjNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.schmObjNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.schmObjNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // netRegionSubDgvColumn
            // 
            this.netRegionSubDgvColumn.DataPropertyName = "NetRegionSub";
            this.netRegionSubDgvColumn.HeaderText = "Сетевой район";
            this.netRegionSubDgvColumn.Name = "netRegionSubDgvColumn";
            this.netRegionSubDgvColumn.ReadOnly = true;
            // 
            // numcrashDgvColumn
            // 
            this.numcrashDgvColumn.DataPropertyName = "numcrash";
            this.numcrashDgvColumn.HeaderText = "Номер аварии";
            this.numcrashDgvColumn.Name = "numcrashDgvColumn";
            this.numcrashDgvColumn.ReadOnly = true;
            // 
            // defectLocationDataGridViewTextBoxColumn
            // 
            this.defectLocationDataGridViewTextBoxColumn.DataPropertyName = "defectLocation";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.defectLocationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.defectLocationDataGridViewTextBoxColumn.HeaderText = "Место повреждения";
            this.defectLocationDataGridViewTextBoxColumn.Name = "defectLocationDataGridViewTextBoxColumn";
            this.defectLocationDataGridViewTextBoxColumn.ReadOnly = true;
            this.defectLocationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.defectLocationDataGridViewTextBoxColumn.Visible = false;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reasonDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Причина";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reasonDataGridViewTextBoxColumn.Visible = false;
            // 
            // divisionApplyDataGridViewTextBoxColumn
            // 
            this.divisionApplyDataGridViewTextBoxColumn.DataPropertyName = "DivisionApply";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.divisionApplyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.divisionApplyDataGridViewTextBoxColumn.HeaderText = "Подразделение исполнитель";
            this.divisionApplyDataGridViewTextBoxColumn.Name = "divisionApplyDataGridViewTextBoxColumn";
            this.divisionApplyDataGridViewTextBoxColumn.ReadOnly = true;
            this.divisionApplyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.divisionApplyDataGridViewTextBoxColumn.Visible = false;
            // 
            // isLaboratoryDgvColumn
            // 
            this.isLaboratoryDgvColumn.DataPropertyName = "isLaboratory";
            this.isLaboratoryDgvColumn.HeaderText = "ПЛ";
            this.isLaboratoryDgvColumn.Name = "isLaboratoryDgvColumn";
            this.isLaboratoryDgvColumn.ReadOnly = true;
            this.isLaboratoryDgvColumn.Visible = false;
            this.isLaboratoryDgvColumn.Width = 40;
            // 
            // dateApplyDgvColumn
            // 
            this.dateApplyDgvColumn.DataPropertyName = "dateApply";
            this.dateApplyDgvColumn.HeaderText = "Дата устранения";
            this.dateApplyDgvColumn.Name = "dateApplyDgvColumn";
            this.dateApplyDgvColumn.ReadOnly = true;
            this.dateApplyDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateApplyDgvColumn.Visible = false;
            // 
            // isApplyDgvColumn
            // 
            this.isApplyDgvColumn.DataPropertyName = "isApply";
            this.isApplyDgvColumn.HeaderText = "Выполнено";
            this.isApplyDgvColumn.Name = "isApplyDgvColumn";
            this.isApplyDgvColumn.ReadOnly = true;
            this.isApplyDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isApplyDgvColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.isApplyDgvColumn.Visible = false;
            // 
            // workerApplyDataGridViewTextBoxColumn
            // 
            this.workerApplyDataGridViewTextBoxColumn.DataPropertyName = "workerApply";
            this.workerApplyDataGridViewTextBoxColumn.HeaderText = "Выполнил";
            this.workerApplyDataGridViewTextBoxColumn.Name = "workerApplyDataGridViewTextBoxColumn";
            this.workerApplyDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerApplyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workerApplyDataGridViewTextBoxColumn.Visible = false;
            // 
            // completedWorkDataGridViewTextBoxColumn
            // 
            this.completedWorkDataGridViewTextBoxColumn.DataPropertyName = "completedWork";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.completedWorkDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.completedWorkDataGridViewTextBoxColumn.HeaderText = "Выполненная работа";
            this.completedWorkDataGridViewTextBoxColumn.Name = "completedWorkDataGridViewTextBoxColumn";
            this.completedWorkDataGridViewTextBoxColumn.ReadOnly = true;
            this.completedWorkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.completedWorkDataGridViewTextBoxColumn.Visible = false;
            // 
            // compilerDataGridViewTextBoxColumn
            // 
            this.compilerDataGridViewTextBoxColumn.DataPropertyName = "compiler";
            this.compilerDataGridViewTextBoxColumn.HeaderText = "Составитель";
            this.compilerDataGridViewTextBoxColumn.Name = "compilerDataGridViewTextBoxColumn";
            this.compilerDataGridViewTextBoxColumn.ReadOnly = true;
            this.compilerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.compilerDataGridViewTextBoxColumn.Visible = false;
            // 
            // InstructionDgvColumn
            // 
            this.InstructionDgvColumn.DataPropertyName = "Instruction";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InstructionDgvColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.InstructionDgvColumn.HeaderText = "Указания";
            this.InstructionDgvColumn.Name = "InstructionDgvColumn";
            this.InstructionDgvColumn.ReadOnly = true;
            this.InstructionDgvColumn.Visible = false;
            this.InstructionDgvColumn.Width = 120;
            // 
            // nameOwnerDgvColumn
            // 
            this.nameOwnerDgvColumn.DataPropertyName = "ownerName";
            this.nameOwnerDgvColumn.HeaderText = "Автор";
            this.nameOwnerDgvColumn.Name = "nameOwnerDgvColumn";
            this.nameOwnerDgvColumn.ReadOnly = true;
            this.nameOwnerDgvColumn.Visible = false;
            // 
            // dateOwnerDgvColumn
            // 
            this.dateOwnerDgvColumn.DataPropertyName = "dateOwner";
            this.dateOwnerDgvColumn.HeaderText = "Дата создания";
            this.dateOwnerDgvColumn.Name = "dateOwnerDgvColumn";
            this.dateOwnerDgvColumn.ReadOnly = true;
            this.dateOwnerDgvColumn.Visible = false;
            // 
            // comletedWorkTextDataGridViewTextBoxColumn
            // 
            this.comletedWorkTextDataGridViewTextBoxColumn.DataPropertyName = "ComletedWorkText";
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.comletedWorkTextDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.comletedWorkTextDataGridViewTextBoxColumn.HeaderText = "Выполненная работа текст";
            this.comletedWorkTextDataGridViewTextBoxColumn.Name = "comletedWorkTextDataGridViewTextBoxColumn";
            this.comletedWorkTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.comletedWorkTextDataGridViewTextBoxColumn.Visible = false;
            // 
            // KodPTSDgvColumn
            // 
            this.KodPTSDgvColumn.DataPropertyName = "KodPTS";
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.KodPTSDgvColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.KodPTSDgvColumn.HeaderText = "Код повреждения";
            this.KodPTSDgvColumn.Name = "KodPTSDgvColumn";
            this.KodPTSDgvColumn.ReadOnly = true;
            this.KodPTSDgvColumn.Visible = false;
            // 
            // kodPTSStrDgvColumn
            // 
            this.kodPTSStrDgvColumn.DataPropertyName = "KodPTSStr";
            this.kodPTSStrDgvColumn.HeaderText = "Код повреждения (стр)";
            this.kodPTSStrDgvColumn.Name = "kodPTSStrDgvColumn";
            this.kodPTSStrDgvColumn.ReadOnly = true;
            this.kodPTSStrDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kodPTSStrDgvColumn.Visible = false;
            // 
            // idParentDgvColumn
            // 
            this.idParentDgvColumn.DataPropertyName = "idParent";
            this.idParentDgvColumn.HeaderText = "Родитель";
            this.idParentDgvColumn.Name = "idParentDgvColumn";
            this.idParentDgvColumn.ReadOnly = true;
            this.idParentDgvColumn.Visible = false;
            // 
            // typeDocDgvColumn
            // 
            this.typeDocDgvColumn.DataPropertyName = "TypeDoc";
            this.typeDocDgvColumn.HeaderText = "TypeDoc";
            this.typeDocDgvColumn.Name = "typeDocDgvColumn";
            this.typeDocDgvColumn.ReadOnly = true;
            this.typeDocDgvColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // signCrashTypeDgvActDetection
            // 
            this.signCrashTypeDgvActDetection.DataPropertyName = "signCrashType";
            this.signCrashTypeDgvActDetection.HeaderText = "Код учетного признака аварии";
            this.signCrashTypeDgvActDetection.Name = "signCrashTypeDgvActDetection";
            this.signCrashTypeDgvActDetection.ReadOnly = true;
            this.signCrashTypeDgvActDetection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // signCrashNameDgvActDetection
            // 
            this.signCrashNameDgvActDetection.DataPropertyName = "signCrashName";
            this.signCrashNameDgvActDetection.HeaderText = "Учетный признак аварии";
            this.signCrashNameDgvActDetection.Name = "signCrashNameDgvActDetection";
            this.signCrashNameDgvActDetection.ReadOnly = true;
            this.signCrashNameDgvActDetection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeEquipDgvActDetection
            // 
            this.typeEquipDgvActDetection.DataPropertyName = "typeEquip";
            this.typeEquipDgvActDetection.HeaderText = "Код оборудования";
            this.typeEquipDgvActDetection.Name = "typeEquipDgvActDetection";
            this.typeEquipDgvActDetection.ReadOnly = true;
            this.typeEquipDgvActDetection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeEquipNameDgvActDetection
            // 
            this.typeEquipNameDgvActDetection.DataPropertyName = "typeEquipName";
            this.typeEquipNameDgvActDetection.HeaderText = "Вид оборудования";
            this.typeEquipNameDgvActDetection.Name = "typeEquipNameDgvActDetection";
            this.typeEquipNameDgvActDetection.ReadOnly = true;
            this.typeEquipNameDgvActDetection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // reasonCrashEquipTypeDgvActDetection
            // 
            this.reasonCrashEquipTypeDgvActDetection.DataPropertyName = "reasonCrashEquipType";
            this.reasonCrashEquipTypeDgvActDetection.HeaderText = "Код технической причины";
            this.reasonCrashEquipTypeDgvActDetection.Name = "reasonCrashEquipTypeDgvActDetection";
            this.reasonCrashEquipTypeDgvActDetection.ReadOnly = true;
            this.reasonCrashEquipTypeDgvActDetection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // reasonCrashEquipNameDgvActDetection
            // 
            this.reasonCrashEquipNameDgvActDetection.DataPropertyName = "reasonCrashEquipName";
            this.reasonCrashEquipNameDgvActDetection.HeaderText = "Техническая причина";
            this.reasonCrashEquipNameDgvActDetection.Name = "reasonCrashEquipNameDgvActDetection";
            this.reasonCrashEquipNameDgvActDetection.ReadOnly = true;
            this.reasonCrashEquipNameDgvActDetection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // reasonCrashTypeDgvActDetection
            // 
            this.reasonCrashTypeDgvActDetection.DataPropertyName = "reasonCrashType";
            this.reasonCrashTypeDgvActDetection.HeaderText = "Код организ. причины аварии";
            this.reasonCrashTypeDgvActDetection.Name = "reasonCrashTypeDgvActDetection";
            this.reasonCrashTypeDgvActDetection.ReadOnly = true;
            this.reasonCrashTypeDgvActDetection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // reasonCrashNameDgvActDetection
            // 
            this.reasonCrashNameDgvActDetection.DataPropertyName = "reasonCrashName";
            this.reasonCrashNameDgvActDetection.HeaderText = "Организ. причина аварии";
            this.reasonCrashNameDgvActDetection.Name = "reasonCrashNameDgvActDetection";
            this.reasonCrashNameDgvActDetection.ReadOnly = true;
            this.reasonCrashNameDgvActDetection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "vJ_Damage";
            this.bindingSource.DataSource = this.dataSetDamage;
            // 
            // dataSetDamage
            // 
            this.dataSetDamage.DataSetName = "DataSetDamage";
            this.dataSetDamage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolItemAdd
            // 
            this.toolItemAdd.Image = global::DailyReport.Properties.Resources.ElementAdd;
            this.toolItemAdd.Name = "toolItemAdd";
            this.toolItemAdd.Size = new System.Drawing.Size(135, 26);
            this.toolItemAdd.Text = "Добавить";
            this.toolItemAdd.Click += new System.EventHandler(this.toolItemAdd_Click);
            // 
            // toolItemEdit
            // 
            this.toolItemEdit.Image = global::DailyReport.Properties.Resources.ElementEdit;
            this.toolItemEdit.Name = "toolItemEdit";
            this.toolItemEdit.Size = new System.Drawing.Size(135, 26);
            this.toolItemEdit.Text = "Изменить";
            this.toolItemEdit.Click += new System.EventHandler(this.toolBtnEdit_Click);
            // 
            // toolItemInfo
            // 
            this.toolItemInfo.Image = global::DailyReport.Properties.Resources.ElementInformation;
            this.toolItemInfo.Name = "toolItemInfo";
            this.toolItemInfo.Size = new System.Drawing.Size(135, 26);
            this.toolItemInfo.Text = "Просмотр";
            this.toolItemInfo.Click += new System.EventHandler(this.toolBtnInfo_Click);
            // 
            // toolItemDel
            // 
            this.toolItemDel.Image = global::DailyReport.Properties.Resources.ElementDel;
            this.toolItemDel.Name = "toolItemDel";
            this.toolItemDel.Size = new System.Drawing.Size(135, 26);
            this.toolItemDel.Text = "Удалить";
            this.toolItemDel.Click += new System.EventHandler(this.toolBtnDel_Click);
            // 
            // contextMenuDamage
            // 
            this.contextMenuDamage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuDamage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolItemAdd,
            this.toolItemEdit,
            this.toolItemInfo,
            this.toolItemDel});
            this.contextMenuDamage.Name = "contextMenuDamage";
            this.contextMenuDamage.Size = new System.Drawing.Size(136, 108);
            this.contextMenuDamage.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuDamage_Opening);
            // 
            // FormJournalActDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.splitContainer_0);
            this.Controls.Add(this.toolStrip);
            this.Name = "FormJournalActDetection";
            this.Text = "Журнал актов расследования (N)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJournalActDetection_FormClosed);
            this.Load += new System.EventHandler(this.FormJournalActDetection_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.ResumeLayout(false);
            this.toolStripTreeSchmObj.ResumeLayout(false);
            this.toolStripTreeSchmObj.PerformLayout();
            this.toolStripFilter.ResumeLayout(false);
            this.toolStripFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActDetection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).EndInit();
            this.contextMenuDamage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void toolBtnFilterApply_Click(object sender, EventArgs e)
        {
            this.ActDetectionSearchGrid(-1);
        }

        private void toolBtnFilterDelete_Click(object sender, EventArgs e)
        {
            this.method_0();
            this.dgvActDetection.ClearFilter();
            this.ActDetectionSearchGrid(-1);
        }

        private void toolBtnRefresh_Click(object sender, EventArgs e)
        {
            this.ActDetectionSearchGrid(-1);
        }

        private void toolBtnFind_Click(object sender, EventArgs e)
        {
            this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.txtFind.Text);
        }

        private void toolBtnFindPrev_Click(object sender, EventArgs e)
        {
            this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
        }

        private void toolBtnFindNext_Click(object sender, EventArgs e)
        {
            this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
        }

        private void toolBtnDamageNoApply_Click(object sender, EventArgs e)
        {
            if (this.bindingSource.Current != null)
            {
                if (((this.dgvActDetection.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != DBNull.Value) && (this.dgvActDetection.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != null)) && Convert.ToBoolean(this.dgvActDetection.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value))
                {
                    if (MessageBox.Show("Вы действительно хотите разблокировать текущий документ?", "Разблокировка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int num = Convert.ToInt32(this.dgvActDetection.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
                        try
                        {
                            using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                            {
                                connection.Open();
                                using (SqlCommand command = new SqlCommand())
                                {
                                    command.Connection = connection;
                                    command.CommandText = string.Format("update tj_damage \r\n                                                                  set isapply = 0\r\n                                                                   where id = {0}", num);
                                    if (command.ExecuteNonQuery() > 0)
                                    {
                                        this.ActDetectionSearchGrid(-1);
                                    }
                                }
                                connection.Close();
                                MessageBox.Show("Документ успешно разблокирован");
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, exception.Source);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Документ уже разблокирован");
                }
            }
        }

        private void toolBtnExportExcel_Click(object sender, EventArgs e)
        {
            this.dgvActDetection.ExportToExcel();
        }

        private void toolStripButton_16_Click(object sender, EventArgs e)
        {
            this.dgvActDetection.PrintDataGridView();
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            this.dtpFilterBeg.Value = new DateTime(this.dtpFilterBeg.Value.Year - 1, this.dtpFilterBeg.Value.Month, this.dtpFilterBeg.Value.Day);
            this.dtpFilterEnd.Value = new DateTime(this.dtpFilterEnd.Value.Year - 1, this.dtpFilterEnd.Value.Month, this.dtpFilterEnd.Value.Day);
        }

        private void toolBtnNextYear_Click(object sender, EventArgs e)
        {
            this.dtpFilterEnd.Value = new DateTime(this.dtpFilterEnd.Value.Year + 1, this.dtpFilterEnd.Value.Month, this.dtpFilterEnd.Value.Day);
            this.dtpFilterBeg.Value = new DateTime(this.dtpFilterBeg.Value.Year + 1, this.dtpFilterBeg.Value.Month, this.dtpFilterBeg.Value.Day);
        }

        private void toolBtnFindTreeSchmObj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
            {
                this.treeViewSchmObjects.Find(this.txtFindTreeSchmObj.Text);
            }
        }

        private void toolBtnFindPrevTreeSchmObj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
            {
                this.treeViewSchmObjects.FindPrev(this.txtFindTreeSchmObj.Text);
            }
        }

        private void toolBtnFindNextTreeSchmObj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
            {
                this.treeViewSchmObjects.FindNext(this.txtFindTreeSchmObj.Text);
            }
        }

        private void toolBtnLoadOldDamageLV_Click(object sender, EventArgs e)
        {
            LoadOldDamageLV.Load(this.SqlSettings, new SQLSettings("ulges-sql", "SR4", "WINDOWS", "", ""));
            this.ActDetectionSearchGrid(-1);
        }

        private void toolBtnLoadOldDefect_Click(object sender, EventArgs e)
        {
            ImportOldDefectExcel.Load(this.SqlSettings);
            this.ActDetectionSearchGrid(-1);
        }

        private void toolBtnLoadAbnDefectLV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                {
                    try
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();
                        try
                        {
                            DataTable dataTable = new DataTable();
                            using (SqlCommand command = new SqlCommand())
                            {
                                command.Connection = connection;
                                command.Transaction = transaction;
                                command.CommandText = "select d.id, d.idSchmObj, d.dateDoc, dLv.iddamage, dlv.abnOff from tj_damage d\r\n\t                                                left join tj_damagelv dlv on dlv.iddamage = d.id\r\n                                                where d.typeDoc = 1401\r\n\t                                                    and d.idSchmObj is not null\r\n\t                                                    and d.datedoc >= '20150101'\r\n\t                                                    and dlv.abnOff is null\r\n                                            and d.id not in (48483, 48485, 48487,48615,48888,48897)";
                                new SqlDataAdapter(command).Fill(dataTable);
                            }
                            //using (IEnumerator enumerator = dataTable.Rows.GetEnumerator())
                            //{
                            //    while (enumerator.MoveNext())
                            //    {
                            //        Class351 class2 = new Class351 {
                            //            dataRow_0 = (DataRow) enumerator.Current
                            //        };
                                    foreach (DataRow dataRow_0 in dataTable.Rows)
                                    {
                                        if (dataRow_0["dateDoc"] != DBNull.Value)
                                    {
                                        ElectricModel model = new ElectricModel();
                                        model.SqlSettings = (this.SqlSettings);
                                        model.LoadSchema(Convert.ToDateTime(dataRow_0["dateDoc"]));
                                        model.PoweringReportForDrawObject(Convert.ToInt32(dataRow_0["idSchmObj"]), true);
                                    // IEnumerable<ElectricObject> source = model.Objects.Where<ElectricObject>(new Func<ElectricObject, bool>(class2.method_0));
                                    IEnumerable<ElectricObject> source = model.Objects.Where((ElectricObject r) => r.Id == Convert.ToInt32(dataRow_0["idSchmObj"]));
                                    if (source.Count<ElectricObject>() > 0)
                                        {
                                            List<ElectricObject> list = model.PoweringReportForDrawObject(source.First<ElectricObject>(), true, true);
                                            DataSet set = new DataSet();
                                            DataTable table = new DataTable("vL_SchmAbnFull");
                                            table.Columns.Add("idAbn", typeof(int));
                                            table.Columns.Add("idAbnObj", typeof(int));
                                            set.Tables.Add(table);
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
                                            //base.SelectSqlData(set, table.TableName, true, " where idSchmObj in (" + str + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj ", new int?(0), false, 0);
                                            base.SelectSqlData(table, true, " where idSchmObj in (" + str + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj ", new int?(0), false, 0);
                                        }
                                            else
                                            {
                                                table.Clear();
                                            }
                                            DataTable table3 = new DataTable("tj_damagelv");
                                            DataColumn column = table3.Columns.Add("idDamage", typeof(int));
                                            table3.Columns.Add("abnoff", typeof(string));
                                            table3.PrimaryKey = new DataColumn[] { column };
                                            base.SelectSqlData(table3, true, "where iddamage = " + dataRow_0["id"].ToString(), null, false, 0);
                                            if (table3.Rows.Count == 0)
                                            {
                                                DataRow row = table3.NewRow();
                                                row["idDamage"] = dataRow_0["id"];
                                                row["abnOff"] = CreateReferenceTables.CreateXmlAbnOff(table).InnerXml;
                                                table3.Rows.Add(row);
                                                base.InsertSqlData(table3);
                                            }
                                            else
                                            {
                                                table3.Rows[0]["abnOff"] = CreateReferenceTables.CreateXmlAbnOff(table).InnerXml;
                                                table3.Rows[0].EndEdit();
                                                base.UpdateSqlData(table3);
                                            }
                                        }
                                    }
                                }
                            //}
                            transaction.Commit();
                        }
                        catch (Exception exception)
                        {
                            transaction.Rollback();
                            MessageBox.Show(exception.Message, exception.Source);
                        }
                    }
                    catch (Exception exception2)
                    {
                        MessageBox.Show(exception2.Message, exception2.Source);
                    }
                }
            }
            catch (Exception exception3)
            {
                MessageBox.Show(exception3.Message, exception3.Source);
            }
        }

        private void toolBtnLoadOldDamageНV_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImportOldData.ImportOldDamage(dialog.FileName, this.SqlSettings);
            }
        }

        private void toolItemAdd_Click(object sender, EventArgs e)
        {
            this.OpenDocument(null, false);
        }

        private void toolBtnEdit_Click(object sender, EventArgs e)
        {
            if (this.bindingSource.Current != null)
            {
                DataRow row = ((DataRowView) this.bindingSource.Current).Row;
                this.OpenDocument(new int?(Convert.ToInt32(row["id"])), false);
            }
        }

        private void toolBtnInfo_Click(object sender, EventArgs e)
        {
            if (this.bindingSource.Current != null)
            {
                DataRow row = ((DataRowView) this.bindingSource.Current).Row;
                this.OpenDocument(new int?(Convert.ToInt32(row["id"])), true);
            }
        }

        private void toolBtnDel_Click(object sender, EventArgs e)
        {
            if (this.bindingSource.Current != null)
            {
                if (((this.dgvActDetection.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != DBNull.Value) && (this.dgvActDetection.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != null)) && Convert.ToBoolean(this.dgvActDetection.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value))
                {
                    MessageBox.Show("Невозможно удалить исполненный документ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (MessageBox.Show("Вы действительно хотите удалить выбранный документ и подчиненные данному документу?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int num = Convert.ToInt32(this.dgvActDetection.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
                    if (base.DeleteSqlDataById(this.dataSetDamage.tJ_Damage, num))
                    {
                        this.method_3(num);
                        this.ActDetectionSearchGrid(-1);
                        MessageBox.Show("Документ успешно удален");
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбран документ для удаления");
            }
        }

        private void tsMenuAmergencyShutdown_Click(object sender, EventArgs e)
        {
            FormReportDetectionCrash crash1 = new FormReportDetectionCrash();
            crash1.SqlSettings = (this.SqlSettings);
            crash1.MdiParent = base.MdiParent;
            crash1.Show();
        }

        private void txtFindTreeSchmObj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Keys modifiers = e.Modifiers;
                if (modifiers != Keys.None)
                {
                    if ((modifiers == Keys.Shift) && !string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
                    {
                        this.treeViewSchmObjects.FindPrev(this.txtFindTreeSchmObj.Text);
                    }
                }
                else if (!string.IsNullOrEmpty(this.txtFindTreeSchmObj.Text))
                {
                    this.treeViewSchmObjects.FindNext(this.txtFindTreeSchmObj.Text);
                }
            }
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Modifiers == Keys.None)
                {
                    this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
                }
                if (e.Modifiers == Keys.Shift)
                {
                    this.dgvActDetection.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
                }
            }
        }

   

        //[CompilerGenerated]
        //private sealed class Class351
        //{
        //    public DataRow dataRow_0;

        //    internal bool method_0(ElectricObject electricObject_0)
        //    {
        //        return (electricObject_0.get_Id() == Convert.ToInt32(this.dataRow_0["idSchmObj"]));
        //    }
        //}
    }
}

