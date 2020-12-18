
    using ControlsLbr.DataGridViewExcelFilter;
    using ControlsLbr.Scheme;
using DailyReport.DataSets;
using DataSql;
    using Documents.Forms.DailyReport.DataSets;
    //using Documents.Forms.DailyReport.Reports;
//    using Documents.Properties;
//    using DailyReport;
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

namespace DailyReport.JournalDamage
{
    /// <summary>
    /// Журнал технологических нарушений
    /// </summary>
    public class FormJournalDamage : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private CheckBox checkBoxWhereSub;
        private CheckedListBox checkedListBoxDivision;
        private CheckedListBox checkedListBoxDivisionApply;
        private ContextMenuStrip contextMenuDamage;
        private DataColumn id;
        private DataColumn TypeDoc;
        private DataColumn TypeDocName;
        private DataColumn numDoc;
        private DataColumn dateDoc;
        private DataColumn idReqForRepair;
        private DataColumn isParent;
        private DataGridViewCheckBoxColumn isParentDgvColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvDamage;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvLinkDocs;
        private DataGridViewFilterCheckBoxColumn isLaboratoryDgvColumn;
        private DataGridViewFilterCheckBoxColumn isApplyDgvColumn;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_11;
        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_12;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_13;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_14;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_15;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_16;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_17;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_18;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_19;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewFilterTextBoxColumn numrequestDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn numDocDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateDocDgvColumn;
        private DataGridViewFilterTextBoxColumn typeDocNameDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn divisionDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn schmObjNameDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn netRegionSubDgvColumn;
        private DataGridViewFilterTextBoxColumn defectLocationDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn reasonDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn divisionApplyDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        private DataGridViewFilterTextBoxColumn dateApplyDgvColumn;
        private DataGridViewFilterTextBoxColumn datePlanEndDgvColumn;
        private DataGridViewFilterTextBoxColumn workerApplyDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn completedWorkDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn compilerDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn InstructionDgvColumn;
        private DataGridViewFilterTextBoxColumn nameOwnerDgvColumn;
        private DataGridViewFilterTextBoxColumn dateOwnerDgvColumn;
        private DataGridViewFilterTextBoxColumn KodPTSDgvColumn;
        private DataGridViewFilterTextBoxColumn kodPTSStrDgvColumn;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
        private DataGridViewFilterTextBoxColumn isNoSESNODgvColumn;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn typeDocNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn comletedWorkTextDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idParentDgvColumn;
        private DataGridViewTextBoxColumn typeDocDgvColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idReasonDgvColumn;
        private DataGridViewTextBoxColumn idReqForRepairDgvColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn numDocDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateDocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idLinkDocDgvColumn;
        private DataGridViewTextBoxColumn typeDocDataGridViewTextBoxColumn;

        private DataSet ds;
        // private DataSetDamage dsDamage;
        private dsDamage dsDamageN;
        private DataTable dtLinkDocs;

        private DateTimePicker dtpFilterEnd;
        private DateTimePicker dtpFilterBeg;
        private GroupBox groupBoxLegend;
        private IContainer components = null;
        private int int_0;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbLinkDoc;
        private Label label4;
        private List<int> list_0;
        private SplitContainer splitContainer;
        private SplitContainer splitContainerDgv;
        private TextBox txtLegendApply;
        private TextBox txtLegendNoSESNO;
        private TextBox txtLegendUnExec;
        private TextBox txtLegendOverdue;
        private TextBox txtLegendInWork;
        private ToolStrip toolStrip;
        private ToolStrip toolStripFilter;
        private ToolStrip toolStrip1;
        private ToolStripButton toolBtnFilterApply;
        private ToolStripButton toolBtnFilterDelete;
        private ToolStripButton toolBtnRefresh;
        private ToolStripButton toolBtnFind;
        private ToolStripButton toolBtnFindPrev;
        private ToolStripButton toolBtnFindNext;
        private ToolStripButton toolBtnDamageNoApply;
        private ToolStripButton toolBtnExportExcel;
        private ToolStripButton toolBtnPrint;
        private ToolStripButton toolBtnSettingMail;
        private ToolStripButton toolBtnPrevYear;
        private ToolStripButton toolBtnNextYear;
        private ToolStripButton toolBtnEdit;
        private ToolStripButton toolBtnInfo;
        private ToolStripButton toolBtnFindTreeSchmObj;
        private ToolStripButton toolBtnFindPrevTreeSchmObj;
        private ToolStripButton toolBtnFindNextTreeSchmObj;
        private ToolStripButton toolBtnDel;
        private ToolStripDropDownButton toolBtnAdd;
        private ToolStripDropDownButton toolBtnReport;
        private ToolStripDropDownButton toolBTnLoadOld;
        private ToolStripMenuItem toolMenuItemReportDailyLV;
        private ToolStripMenuItem toolBtnLoadOldDamageLV;
        private ToolStripMenuItem toolItemInfo;
        private ToolStripMenuItem toolItemDel;
        private ToolStripMenuItem toolItemActDetection;
        private ToolStripMenuItem toolItemActDetectionAdd;
        private ToolStripMenuItem tsMenuAmergencyShutdown;
        private ToolStripMenuItem toolBtnLoadOldDamageLVMySQL;
        private ToolStripMenuItem toolMenuItemSheetInterruptLV;
        private ToolStripMenuItem toolMenuItemReportDailyDefect;
        private ToolStripMenuItem toolBtnLoadOldDefect;
        private ToolStripMenuItem toolMenuItemReportDailyHV;
        private ToolStripMenuItem toolBtnLoadAbnDefectLV;
        private ToolStripMenuItem toolBtnLoadOldDamageНV;
        private ToolStripMenuItem toolItemAdd;
        private ToolStripMenuItem toolItemEdit;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripTextBox txtFindTreeSchmObj;
        private ToolStripTextBox txtFind;
        private TreeViewSchmObjects treeViewSchmObjects;

        public FormJournalDamage()
        {
            this.int_0 = 400;
            this.InitializeComponent();
            this.toolBTnLoadOld.Visible = false;
        }

        public FormJournalDamage(List<int> checkedSubstation)
        {
            this.int_0 = 400;
            this.InitializeComponent();
            this.list_0 = checkedSubstation;
            this.toolBTnLoadOld.Visible = false;
        }

        protected override void ApplyConfig(XmlDocument xmlDocument_0)
        {
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            XmlNode node = xmlDocument_0.SelectSingleNode(base.Name);
            if (node != null)
            {
                
                //using (var enumr = node.SelectNodes("CheckDivision").GetEnumerator())
                //{
                //    while (enumr.MoveNext())
                //    {
                //        XmlAttribute attribute2 = ((XmlNode) enumr.Current).Attributes["Id"];
                //        if (attribute2 != null)
                //        {
                //            list.Add(Convert.ToInt32(attribute2.Value));
                //        }
                //    }
                //}
                foreach (IEnumerator enumr in node.SelectNodes("CheckDivision"))
                {
                    XmlAttribute attribute2 = ((XmlNode)enumr.Current).Attributes["Id"];
                    if (attribute2 != null)
                    {
                        list.Add(Convert.ToInt32(attribute2.Value));
                    }
                }


                // IEnumerator enumerator;
                for (int i = 0; i < this.checkedListBoxDivision.Items.Count; i++)
                {
                    if (list.Contains(((Struct10) this.checkedListBoxDivision.Items[i]).id))
                    {
                        this.checkedListBoxDivision.SetItemChecked(i, true);
                    }
                    else
                    {
                        this.checkedListBoxDivision.SetItemChecked(i, false);
                    }
                }
                XmlNode node2 = node.SelectSingleNode("DivisionApply");
                if (node2 != null)
                {
                    //using (enumerator = node2.SelectNodes("CheckDivisionApply").GetEnumerator())
                    //{
                    //    while (enumerator.MoveNext())
                    //    {
                    //        XmlAttribute attribute3 = ((XmlNode) enumerator.Current).Attributes["Id"];
                    //        if (attribute3 != null)
                    //        {
                    //            list2.Add(Convert.ToInt32(attribute3.Value));
                    //        }
                    //    }
                    //}
                    foreach (IEnumerator enumerator in node2.SelectNodes("CheckDivisionApply"))
                    {
                            XmlAttribute attribute3 = ((XmlNode)enumerator.Current).Attributes["Id"];
                            if (attribute3 != null)
                            {
                                list2.Add(Convert.ToInt32(attribute3.Value));
                            }
                    }
                    for (int j = 0; j < this.checkedListBoxDivisionApply.Items.Count; j++)
                    {
                        if (list2.Contains(((Struct10) this.checkedListBoxDivisionApply.Items[j]).id))
                        {
                            this.checkedListBoxDivisionApply.SetItemChecked(j, true);
                        }
                        else
                        {
                            this.checkedListBoxDivisionApply.SetItemChecked(j, false);
                        }
                    }
                }
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

        private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
        {
            this.method_9();
        }

        private void bindingSource_0_ListChanged(object sender, ListChangedEventArgs e)
        {
            string str = "";
            if ((this.bindingSource_0.Filter != null) && !string.IsNullOrEmpty(this.bindingSource_0.Filter))
            {
                str = string.Format("({0}) and ", this.bindingSource_0.Filter);
            }
            this.txtLegendApply.Text = this.dsDamageN.vJ_Damage.Compute("count(id)", string.Format("{0} isApply = 1", str)).ToString() + " - устранено";
            this.txtLegendInWork.Text = this.dsDamageN.vJ_Damage.Compute("count(id)", string.Format("{0} (isApply is null or isApply = 0) \r\n                    and (datePlanEnd is null or datePlanEnd >= '{1}')\r\n                    and not (idReqForRepair is not null and idReason is null)", str, DateTime.Now.Date.ToString("yyyy-MM-dd") + " 00:00:00")).ToString() + " - в работе";
            this.txtLegendOverdue.Text = this.dsDamageN.vJ_Damage.Compute("count(id)", string.Format("{0} (isApply is null or isApply = 0) \r\n                    and (datePlanEnd < '{1}')\r\n                    and not (idReqForRepair is not null and idReason is null)", str, DateTime.Now.Date.ToString("yyyy-MM-dd") + " 00:00:00")).ToString() + " - просрочено";
            this.txtLegendUnExec.Text = this.dsDamageN.vJ_Damage.Compute("count(id)", string.Format("{0} (isApply is null or isApply = 0) \r\n                    and (idReqForRepair is not null and idReason is null)", str)).ToString() + " - неоформлено";
            this.txtLegendNoSESNO.Text = this.dsDamageN.vJ_Damage.Compute("count(id)", string.Format("{0} (isNoSESNO = 1)", str)).ToString() + " - нет сетей Горсвет";
        }

        private void contextMenuDamage_Opening(object sender, CancelEventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                this.toolItemEdit.Enabled = true;
                this.toolItemInfo.Enabled = true;
                this.toolItemDel.Enabled = true;
                if (Convert.ToInt32(((DataRowView) this.bindingSource_0.Current).Row["TypeDoc"]) == 0x57a)
                {
                    this.toolItemActDetection.Visible = true;
                }
                else
                {
                    this.toolItemActDetection.Visible = false;
                }
            }
            else
            {
                this.toolItemEdit.Enabled = false;
                this.toolItemInfo.Enabled = false;
                this.toolItemDel.Enabled = false;
                this.toolItemActDetection.Visible = false;
            }
        }

        protected override XmlDocument CreateXmlConfig()
        {
            Struct10 struct2;
            XmlDocument document = new XmlDocument();
            XmlNode newChild = document.CreateXmlDeclaration("1.0", "UTF-8", null);
            document.AppendChild(newChild);
            XmlNode node2 = document.CreateElement(base.Name);
            document.AppendChild(node2);
            foreach (object obj2 in this.checkedListBoxDivision.CheckedItems)
            {
                XmlNode node4 = document.CreateElement("CheckDivision");
                XmlAttribute attribute2 = document.CreateAttribute("Id");
                struct2 = (Struct10) obj2;
                attribute2.Value = struct2.id.ToString();
                node4.Attributes.Append(attribute2);
                node2.AppendChild(node4);
            }
            XmlNode node3 = document.CreateElement("DivisionApply");
            node2.AppendChild(node3);
            foreach (object obj3 in this.checkedListBoxDivisionApply.CheckedItems)
            {
                XmlNode node5 = document.CreateElement("CheckDivisionApply");
                XmlAttribute attribute3 = document.CreateAttribute("Id");
                struct2 = (Struct10) obj3;
                attribute3.Value = struct2.id.ToString();
                node5.Attributes.Append(attribute3);
                node3.AppendChild(node5);
            }
            XmlAttribute node = document.CreateAttribute("dateBeg");
            node.Value = this.dtpFilterBeg.Value.ToString();
            node2.Attributes.Append(node);
            node = document.CreateAttribute("dateEnd");
            node.Value = this.dtpFilterEnd.Value.ToString();
            node2.Attributes.Append(node);
            return document;
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0))
            {
                if (this.toolBtnEdit.Enabled && this.toolBtnEdit.Visible)
                {
                    this.toolBtnEdit_Click(sender, e);
                }
                else if (this.toolBtnInfo.Enabled && this.toolBtnInfo.Visible)
                {
                    this.toolItemInfo_Click(sender, e);
                }
            }
        }

        private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (((this.dgvDamage[this.isApplyDgvColumn.Name, e.RowIndex].Value != DBNull.Value) && (this.dgvDamage[this.isApplyDgvColumn.Name, e.RowIndex].Value != null)) && Convert.ToBoolean(this.dgvDamage[this.isApplyDgvColumn.Name, e.RowIndex].Value))
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    if ((this.dgvDamage[this.datePlanEndDgvColumn.Name, e.RowIndex].Value != DBNull.Value) && (this.dgvDamage[this.datePlanEndDgvColumn.Name, e.RowIndex].Value != null))
                    {
                        TimeSpan span;
                        DateTime time = Convert.ToDateTime(this.dgvDamage[this.datePlanEndDgvColumn.Name, e.RowIndex].Value);
                        if (time.Date.AddDays(1.0) < DateTime.Now)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                            if (e.ColumnIndex == this.completedWorkDataGridViewTextBoxColumn.Index)
                            {
                                e.CellStyle.ForeColor = Color.Gray;
                                e.CellStyle.Font = new Font(e.CellStyle.Font.FontFamily, e.CellStyle.Font.Size - 1f, FontStyle.Italic);
                                span = (TimeSpan) (DateTime.Now.Date - time.Date);
                                e.Value = "Просрочено на " + span.Days.ToString() + " дн.";
                            }
                        }
                        else if (time.Date == DateTime.Now.Date)
                        {
                            if (e.ColumnIndex == this.completedWorkDataGridViewTextBoxColumn.Index)
                            {
                                e.CellStyle.ForeColor = Color.Gray;
                                e.CellStyle.Font = new Font(e.CellStyle.Font.FontFamily, e.CellStyle.Font.Size - 1f, FontStyle.Italic);
                                e.Value = "Просрочится сегодня";
                            }
                        }
                        else if (e.ColumnIndex == this.completedWorkDataGridViewTextBoxColumn.Index)
                        {
                            e.CellStyle.ForeColor = Color.Gray;
                            e.CellStyle.Font = new Font(e.CellStyle.Font.FontFamily, e.CellStyle.Font.Size - 1f, FontStyle.Italic);
                            span = (TimeSpan) (time.Date - DateTime.Now.Date);
                            e.Value = "Осталось по плану " + span.Days.ToString() + " дн.";
                        }
                    }
                    if ((this.dgvDamage[this.idReqForRepairDgvColumn.Name, e.RowIndex].Value != DBNull.Value) && (this.dgvDamage[this.idReasonDgvColumn.Name, e.RowIndex].Value == DBNull.Value))
                    {
                        e.CellStyle.BackColor = Color.LightPink;
                        if (e.ColumnIndex != this.completedWorkDataGridViewTextBoxColumn.Index)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                        }
                    }
                }
                if (Convert.ToBoolean(this.dgvDamage[this.isNoSESNODgvColumn.Name, e.RowIndex].Value) && (e.ColumnIndex == this.dateDocDgvColumn.Index))
                {
                    e.CellStyle.BackColor = Color.Orange;
                }
            }
        }

        private void dataGridViewExcelFilter_0_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (e.Button == MouseButtons.Right))
            {
                this.contextMenuDamage.Show(Cursor.Position);
            }
        }

        private void dataGridViewExcelFilter_0_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvDamage.AutoResizeRow(e.RowIndex);
        }

        private void dgvLinkDocs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && ((this.bindingSource_0.Current != null) && (this.bindingSource_0.Current is DataRowView)))
            {
                if ((((DataRowView) this.bindingSource_0.Current).Row["idParent"] != DBNull.Value) && (Convert.ToInt32(this.dgvLinkDocs[this.idLinkDocDgvColumn.Name, e.RowIndex].Value) == Convert.ToInt32(((DataRowView) this.bindingSource_0.Current).Row["idParent"])))
                {
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                }
                if ((((DataRowView) this.bindingSource_0.Current).Row["idReqForRepair"] != DBNull.Value) && (Convert.ToInt32(this.dgvLinkDocs[this.idLinkDocDgvColumn.Name, e.RowIndex].Value) == Convert.ToInt32(((DataRowView) this.bindingSource_0.Current).Row["idReqForRepair"])))
                {
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                }
                if ((this.dgvLinkDocs[this.isParentDgvColumn.Name, e.RowIndex].Value != DBNull.Value) && Convert.ToBoolean(this.dgvLinkDocs[this.isParentDgvColumn.Name, e.RowIndex].Value))
                {
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                }
            }
        }

        private void dtpFilterEnd_ValueChanged(object sender, EventArgs e)
        {
            this.dtpFilterBeg.MaxDate = this.dtpFilterEnd.Value;
        }

        private void dtpFilterBeg_ValueChanged(object sender, EventArgs e)
        {
            this.dtpFilterEnd.MinDate = this.dtpFilterBeg.Value;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormJournalDamage_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormJournalDamage_Load(object sender, EventArgs e)
        {
            this.method_7();
            this.method_0();
            this.method_8();
            base.LoadFormConfig(null);
            this.method_1();
            this.treeViewSchmObjects.SqlSettings=(this.SqlSettings);
            this.treeViewSchmObjects.Load(this.list_0);
            this.SearchIdDamage(-1);
        }

        private void lbLinkDoc_Click(object sender, EventArgs e)
        {
            if (this.lbLinkDoc.Cursor == Cursors.PanNorth)
            {
                this.splitContainerDgv.SplitterDistance = this.int_0;
                this.splitContainerDgv.IsSplitterFixed = false;
                this.lbLinkDoc.Cursor = Cursors.PanSouth;
            }
            else if (this.lbLinkDoc.Cursor == Cursors.PanSouth)
            {
                this.int_0 = this.splitContainerDgv.SplitterDistance;
                this.splitContainerDgv.SplitterDistance = (this.splitContainerDgv.Height - this.splitContainerDgv.SplitterWidth) - this.lbLinkDoc.Height;
                this.splitContainerDgv.IsSplitterFixed = true;
                this.lbLinkDoc.Cursor = Cursors.PanNorth;
            }
        }

        private void method_0()
        {
            this.dtpFilterBeg.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dtpFilterEnd.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddSeconds(-1.0);
            this.checkedListBoxDivision.Items.Clear();
            DataTable table = new DataTable("tR_Classifier");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("socrname", typeof(string));
            base.SelectSqlData(table, true, "where ParentKey = ';GroupWorker;DailyReport;' and isGroup = 0 and Deleted = 0", null, false, 0);
            foreach (DataRow row in table.Rows)
            {
                this.checkedListBoxDivision.Items.Add(new Struct10(Convert.ToInt32(row["id"]), row["SocrName"].ToString()), true);
            }
            this.treeViewSchmObjects.ClearTreeChecked();
            this.checkedListBoxDivisionApply.Items.Clear();
            base.SelectSqlData(table, true, "where ParentKey = ';GroupWorker;DailyReport;' and isGroup = 0 and Deleted = 0", null, false, 0);
            foreach (DataRow row2 in table.Rows)
            {
                this.checkedListBoxDivisionApply.Items.Add(new Struct10(Convert.ToInt32(row2["id"]), row2["SocrName"].ToString()), true);
            }
            base.SelectSqlData(table, true, "where ParentKey = ';ReportDaily;DivisionApply;' and isGroup = 0 and Deleted = 0", null, false, 0);
            foreach (DataRow row3 in table.Rows)
            {
                this.checkedListBoxDivisionApply.Items.Add(new Struct10(Convert.ToInt32(row3["id"]), row3["Name"].ToString()), true);
            }
            this.checkedListBoxDivisionApply.Items.Add(new Struct10(-1, "Производственная лаборатория"), true);
        }

        private void method_1()
        {
            DataTable table = new DataTable("tR_Classifier");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            base.SelectSqlData(table, true, " where ParentKey = ';ReportDaily;TypeDoc;' and isgroup = 0 and deleted = 0", null, false, 0);
            foreach (DataRow row in table.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Click += new EventHandler(this.method_2);
                item.Text = row["Name"].ToString();
                item.Tag = row["id"];
                this.toolBtnAdd.DropDownItems.Add(item);
                ToolStripMenuItem item2 = new ToolStripMenuItem();
                item2.Click += new EventHandler(this.method_2);
                item2.Text = row["Name"].ToString();
                item2.Tag = row["id"];
                this.toolItemAdd.DropDownItems.Add(item2);
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormJournalDamage));
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            DataGridViewCellStyle style7 = new DataGridViewCellStyle();
            DataGridViewCellStyle style8 = new DataGridViewCellStyle();
            DataGridViewCellStyle style9 = new DataGridViewCellStyle();
            DataGridViewCellStyle style10 = new DataGridViewCellStyle();
            DataGridViewCellStyle style11 = new DataGridViewCellStyle();
            DataGridViewCellStyle style12 = new DataGridViewCellStyle();
            DataGridViewCellStyle style13 = new DataGridViewCellStyle();
            DataGridViewCellStyle style14 = new DataGridViewCellStyle();
            DataGridViewCellStyle style15 = new DataGridViewCellStyle();
            DataGridViewCellStyle style16 = new DataGridViewCellStyle();
            DataGridViewCellStyle style17 = new DataGridViewCellStyle();
            this.toolStrip = new ToolStrip();
            this.toolBtnAdd = new ToolStripDropDownButton();
            this.toolBtnEdit = new ToolStripButton();
            this.toolBtnInfo = new ToolStripButton();
            this.toolBtnDel = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolBtnRefresh = new ToolStripButton();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolBtnFind = new ToolStripButton();
            this.txtFind = new ToolStripTextBox();
            this.toolBtnFindPrev = new ToolStripButton();
            this.toolBtnFindNext = new ToolStripButton();
            this.toolStripSeparator3 = new ToolStripSeparator();
            this.toolBtnReport = new ToolStripDropDownButton();
            this.toolMenuItemReportDailyLV = new ToolStripMenuItem();
            this.toolMenuItemSheetInterruptLV = new ToolStripMenuItem();
            this.toolMenuItemReportDailyDefect = new ToolStripMenuItem();
            this.toolMenuItemReportDailyHV = new ToolStripMenuItem();
            this.tsMenuAmergencyShutdown = new ToolStripMenuItem();
            this.toolBTnLoadOld = new ToolStripDropDownButton();
            this.toolBtnLoadOldDamageLV = new ToolStripMenuItem();
            this.toolBtnLoadOldDefect = new ToolStripMenuItem();
            this.toolBtnLoadAbnDefectLV = new ToolStripMenuItem();
            this.toolBtnLoadOldDamageНV = new ToolStripMenuItem();
            this.toolBtnLoadOldDamageLVMySQL = new ToolStripMenuItem();
            this.toolBtnDamageNoApply = new ToolStripButton();
            this.toolBtnExportExcel = new ToolStripButton();
            this.toolBtnPrint = new ToolStripButton();
            this.splitContainer = new SplitContainer();
            this.groupBoxLegend = new GroupBox();
            this.txtLegendNoSESNO = new TextBox();
            this.txtLegendUnExec = new TextBox();
            this.txtLegendOverdue = new TextBox();
            this.txtLegendInWork = new TextBox();
            this.txtLegendApply = new TextBox();
            this.checkedListBoxDivisionApply = new CheckedListBox();
            this.checkBoxWhereSub = new CheckBox();
            this.label4 = new Label();
            this.toolStrip1 = new ToolStrip();
            this.toolBtnFindTreeSchmObj = new ToolStripButton();
            this.txtFindTreeSchmObj = new ToolStripTextBox();
            this.toolBtnFindPrevTreeSchmObj = new ToolStripButton();
            this.toolBtnFindNextTreeSchmObj = new ToolStripButton();
            this.treeViewSchmObjects = new TreeViewSchmObjects();
            this.checkedListBoxDivision = new CheckedListBox();
            this.label3 = new Label();
            this.dtpFilterEnd = new DateTimePicker();
            this.label2 = new Label();
            this.dtpFilterBeg = new DateTimePicker();
            this.label1 = new Label();
            this.toolStripFilter = new ToolStrip();
            this.toolBtnFilterApply = new ToolStripButton();
            this.toolBtnFilterDelete = new ToolStripButton();
            this.toolStripSeparator4 = new ToolStripSeparator();
            this.toolBtnPrevYear = new ToolStripButton();
            this.toolBtnNextYear = new ToolStripButton();
            this.splitContainerDgv = new SplitContainer();
            this.dgvDamage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.isLaboratoryDgvColumn = new DataGridViewFilterCheckBoxColumn();
            this.isApplyDgvColumn = new DataGridViewFilterCheckBoxColumn();
            this.numrequestDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.numDocDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.dateDocDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.typeDocNameDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.schmObjNameDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.netRegionSubDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.defectLocationDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.divisionApplyDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.dateApplyDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.datePlanEndDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.workerApplyDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.completedWorkDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.compilerDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.InstructionDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.nameOwnerDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.dateOwnerDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.comletedWorkTextDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.KodPTSDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.kodPTSStrDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.idParentDgvColumn = new DataGridViewTextBoxColumn();
            this.isNoSESNODgvColumn = new DataGridViewFilterTextBoxColumn();
            this.typeDocDgvColumn = new DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.idReasonDgvColumn = new DataGridViewTextBoxColumn();
            this.idReqForRepairDgvColumn = new DataGridViewTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.components);
            //this.dsDamage = new DataSetDamage();
            this.dsDamageN = new dsDamage();
            this.dgvLinkDocs = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.numDocDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.dateDocDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.idLinkDocDgvColumn = new DataGridViewTextBoxColumn();
            this.typeDocDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.typeDocNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.isParentDgvColumn = new DataGridViewCheckBoxColumn();
            this.bindingSource_1 = new BindingSource(this.components);
            this.ds = new DataSet();
            this.dtLinkDocs = new DataTable();
            this.id = new DataColumn();
            this.TypeDoc = new DataColumn();
            this.TypeDocName = new DataColumn();
            this.numDoc = new DataColumn();
            this.dateDoc = new DataColumn();
            this.idReqForRepair = new DataColumn();
            this.isParent = new DataColumn();
            this.lbLinkDoc = new Label();
            this.contextMenuDamage = new ContextMenuStrip(this.components);
            this.toolItemAdd = new ToolStripMenuItem();
            this.toolItemEdit = new ToolStripMenuItem();
            this.toolItemInfo = new ToolStripMenuItem();
            this.toolItemDel = new ToolStripMenuItem();
            this.toolStripSeparator5 = new ToolStripSeparator();
            this.toolItemActDetection = new ToolStripMenuItem();
            this.toolItemActDetectionAdd = new ToolStripMenuItem();
            this.toolStripSeparator6 = new ToolStripSeparator();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_19 = new DataGridViewFilterTextBoxColumn();
            //this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_17 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_18 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.toolBtnSettingMail = new ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBoxLegend.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripFilter.SuspendLayout();
            this.splitContainerDgv.Panel1.SuspendLayout();
            this.splitContainerDgv.Panel2.SuspendLayout();
            this.splitContainerDgv.SuspendLayout();
            ((ISupportInitialize)this.dgvDamage).BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            ((ISupportInitialize) this.dsDamageN).BeginInit();
            ((ISupportInitialize)this.dgvLinkDocs).BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            this.ds.BeginInit();
            this.dtLinkDocs.BeginInit();
            this.contextMenuDamage.SuspendLayout();
            base.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { 
                this.toolBtnAdd, this.toolBtnEdit, this.toolBtnInfo, this.toolBtnDel, this.toolStripSeparator_0, this.toolBtnRefresh, this.toolStripSeparator2, this.toolBtnFind, this.txtFind, this.toolBtnFindPrev, this.toolBtnFindNext, this.toolStripSeparator3, this.toolBtnReport, this.toolBTnLoadOld, this.toolBtnDamageNoApply, this.toolBtnExportExcel,
                this.toolBtnPrint, this.toolBtnSettingMail
            };
            this.toolStrip.Items.AddRange(toolStripItems);
            this.toolStrip.Location = new Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new Size(0x531, 0x19);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            this.toolBtnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnAdd.Image = (Image) resources.GetObject("toolBtnAdd.Image");
            this.toolBtnAdd.Image = global::DailyReport.Properties.Resources.ElementAdd;
            this.toolBtnAdd.ImageTransparentColor = Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new Size(0x1d, 0x16);
            this.toolBtnAdd.Text = "Добавить";
            this.toolBtnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnEdit.Image = (Image) resources.GetObject("toolBtnEdit.Image");
            this.toolBtnEdit.Image = global::DailyReport.Properties.Resources.ElementEdit;
            this.toolBtnEdit.ImageTransparentColor = Color.Magenta;
            this.toolBtnEdit.Name = "toolBtnEdit";
            this.toolBtnEdit.Size = new Size(0x17, 0x16);
            this.toolBtnEdit.Text = "Редактировать";
            this.toolBtnEdit.Click += new EventHandler(this.toolBtnEdit_Click);
            this.toolBtnInfo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnInfo.Image = (Image) resources.GetObject("toolBtnInfo.Image");
            this.toolBtnInfo.Image = global::DailyReport.Properties.Resources.ElementInformation;
            this.toolBtnInfo.ImageTransparentColor = Color.Magenta;
            this.toolBtnInfo.Name = "toolBtnInfo";
            this.toolBtnInfo.Size = new Size(0x17, 0x16);
            this.toolBtnInfo.Text = "Информация";
            this.toolBtnInfo.Click += new EventHandler(this.toolItemInfo_Click);
            this.toolBtnDel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnDel.Image = (Image) resources.GetObject("toolBtnDel.Image");
            this.toolBtnDel.Image = global::DailyReport.Properties.Resources.ElementDel;
            this.toolBtnDel.ImageTransparentColor = Color.Magenta;
            this.toolBtnDel.Name = "toolBtnDel";
            this.toolBtnDel.Size = new Size(0x17, 0x16);
            this.toolBtnDel.Text = "Удалить документ";
            this.toolBtnDel.Click += new EventHandler(this.toolItemDel_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolBtnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnRefresh.Image = (Image) resources.GetObject("toolBtnRefresh.Image");
            this.toolBtnRefresh.Image = global::DailyReport.Properties.Resources.Refresh;
            this.toolBtnRefresh.ImageTransparentColor = Color.Magenta;
            this.toolBtnRefresh.Name = "toolBtnRefresh";
            this.toolBtnRefresh.Size = new Size(0x17, 0x16);
            this.toolBtnRefresh.Text = "Обновить";
            this.toolBtnRefresh.Click += new EventHandler(this.toolBtnRefresh_Click);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(6, 0x19);
            this.toolBtnFind.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnFind.Image = (Image) resources.GetObject("toolBtnFind.Image");
            this.toolBtnFind.Image = global::DailyReport.Properties.Resources.Find;
            this.toolBtnFind.ImageTransparentColor = Color.Magenta;
            this.toolBtnFind.Name = "toolBtnFind";
            this.toolBtnFind.Size = new Size(0x17, 0x16);
            this.toolBtnFind.Text = "Искать";
            this.toolBtnFind.Click += new EventHandler(this.toolBtnFind_Click);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new Size(100, 0x19);
            this.txtFind.ToolTipText = "Текст для поиска";
            this.txtFind.KeyDown += new KeyEventHandler(this.txtFind_KeyDown);
            this.toolBtnFindPrev.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //this.toolBtnFindPrev.Image = (Image) resources.GetObject("toolBtnFindPrev.Image");
            this.toolBtnFindPrev.Image = global::DailyReport.Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new Size(0x17, 0x16);
            this.toolBtnFindPrev.Text = "Искать назад";
            this.toolBtnFindPrev.Click += new EventHandler(this.toolBtnFindPrev_Click);
            this.toolBtnFindNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnFindNext.Image = (Image) resources.GetObject("toolBtnFindNext.Image");
            this.toolBtnFindNext.Image = global::DailyReport.Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new Size(0x17, 0x16);
            this.toolBtnFindNext.Text = "Искать вперед";
            this.toolBtnFindNext.Click += new EventHandler(this.toolBtnFindNext_Click);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new Size(6, 0x19);
            this.toolBtnReport.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolMenuItemReportDailyLV, this.toolMenuItemSheetInterruptLV, this.toolMenuItemReportDailyDefect, this.toolMenuItemReportDailyHV, this.tsMenuAmergencyShutdown };
            this.toolBtnReport.DropDownItems.AddRange(itemArray2);
            // this.toolBtnReport.Image = (Image) resources.GetObject("toolBtnReport.Image");
            this.toolBtnReport.Image = global::DailyReport.Properties.Resources.Report;
            this.toolBtnReport.ImageTransparentColor = Color.Magenta;
            this.toolBtnReport.Name = "toolBtnReport";
            this.toolBtnReport.Size = new Size(0x1d, 0x16);
            this.toolBtnReport.Text = "Отчеты";
            this.toolMenuItemReportDailyLV.Name = "toolMenuItemReportDailyLV";
            this.toolMenuItemReportDailyLV.Size = new Size(0x17d, 0x16);
            this.toolMenuItemReportDailyLV.Text = "Суточный рапорт в сетях 0,4кВ (ОДС)";
            this.toolMenuItemReportDailyLV.Click += new EventHandler(this.toolMenuItemReportDailyLV_Click);
            this.toolMenuItemSheetInterruptLV.Name = "toolMenuItemSheetInterruptLV";
            this.toolMenuItemSheetInterruptLV.Size = new Size(0x17d, 0x16);
            this.toolMenuItemSheetInterruptLV.Text = "Бюллетень перерывов электроснабжения в сетях 0,4 кВ";
            this.toolMenuItemSheetInterruptLV.Click += new EventHandler(this.toolMenuItemSheetInterruptLV_Click);
            this.toolMenuItemReportDailyDefect.Name = "toolMenuItemReportDailyDefect";
            this.toolMenuItemReportDailyDefect.Size = new Size(0x17d, 0x16);
            this.toolMenuItemReportDailyDefect.Text = "Суточный рапорт по дефектам";
            this.toolMenuItemReportDailyDefect.Click += new EventHandler(this.toolMenuItemReportDailyDefect_Click);
            this.toolMenuItemReportDailyHV.Name = "toolMenuItemReportDailyHV";
            this.toolMenuItemReportDailyHV.Size = new Size(0x17d, 0x16);
            this.toolMenuItemReportDailyHV.Text = "Суточный рапорт в сетях 6-10 кВ";
            this.toolMenuItemReportDailyHV.Click += new EventHandler(this.toolMenuItemReportDailyHV_Click);
            this.tsMenuAmergencyShutdown.Name = "tsMenuAmergencyShutdown";
            this.tsMenuAmergencyShutdown.Size = new Size(0x17d, 0x16);
            this.tsMenuAmergencyShutdown.Text = "Бюллетень аварийных отключений";
            this.tsMenuAmergencyShutdown.Click += new EventHandler(this.tsMenuAmergencyShutdown_Click);
            this.toolBTnLoadOld.Alignment = ToolStripItemAlignment.Right;
            this.toolBTnLoadOld.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolBtnLoadOldDamageLV, this.toolBtnLoadOldDefect, this.toolBtnLoadAbnDefectLV, this.toolBtnLoadOldDamageНV, this.toolBtnLoadOldDamageLVMySQL };
            this.toolBTnLoadOld.DropDownItems.AddRange(itemArray3);
            // this.toolBTnLoadOld.Image = (Image) resources.GetObject("toolBTnLoadOld.Image");
            this.toolBTnLoadOld.Image = global::DailyReport.Properties.Resources.Load;
            this.toolBTnLoadOld.ImageTransparentColor = Color.Magenta;
            this.toolBTnLoadOld.Name = "toolBTnLoadOld";
            this.toolBTnLoadOld.Size = new Size(0x1d, 0x16);
            this.toolBTnLoadOld.Text = "Загрузка из старой базы";
            this.toolBtnLoadOldDamageLV.Name = "toolBtnLoadOldDamageLV";
            this.toolBtnLoadOldDamageLV.Size = new Size(210, 0x16);
            this.toolBtnLoadOldDamageLV.Text = "0.4кВ";
            this.toolBtnLoadOldDamageLV.Click += new EventHandler(this.toolBtnLoadOldDamageLV_Click);
            this.toolBtnLoadOldDefect.Name = "toolBtnLoadOldDefect";
            this.toolBtnLoadOldDefect.Size = new Size(210, 0x16);
            this.toolBtnLoadOldDefect.Text = "Дефект";
            this.toolBtnLoadOldDefect.Click += new EventHandler(this.toolBtnLoadOldDefect_Click);
            this.toolBtnLoadAbnDefectLV.Name = "toolBtnLoadAbnDefectLV";
            this.toolBtnLoadAbnDefectLV.Size = new Size(210, 0x16);
            this.toolBtnLoadAbnDefectLV.Text = "Загрузить абонентов НН";
            this.toolBtnLoadAbnDefectLV.Click += new EventHandler(this.toolBtnLoadAbnDefectLV_Click);
            this.toolBtnLoadOldDamageНV.Name = "toolBtnLoadOldDamageНV";
            this.toolBtnLoadOldDamageНV.Size = new Size(210, 0x16);
            this.toolBtnLoadOldDamageНV.Text = "ВН";
            this.toolBtnLoadOldDamageНV.Click += new EventHandler(this.toolBtnLoadOldDamageНV_Click);
            this.toolBtnLoadOldDamageLVMySQL.Name = "toolBtnLoadOldDamageLVMySQL";
            this.toolBtnLoadOldDamageLVMySQL.Size = new Size(210, 0x16);
            this.toolBtnLoadOldDamageLVMySQL.Text = "Mysql";
            this.toolBtnLoadOldDamageLVMySQL.Click += new EventHandler(this.toolBtnLoadOldDamageLVMySQL_Click);
            this.toolBtnDamageNoApply.Alignment = ToolStripItemAlignment.Right;
            this.toolBtnDamageNoApply.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnDamageNoApply.Image = (Image) resources.GetObject("toolBtnDamageNoApply.Image");
            this.toolBtnDamageNoApply.Image = global::DailyReport.Properties.Resources.ElementAccept;
            this.toolBtnDamageNoApply.ImageTransparentColor = Color.Magenta;
            this.toolBtnDamageNoApply.Name = "toolBtnDamageNoApply";
            this.toolBtnDamageNoApply.Size = new Size(0x17, 0x16);
            this.toolBtnDamageNoApply.Text = "Разблокировать документ";
            this.toolBtnDamageNoApply.Visible = false;
            this.toolBtnDamageNoApply.Click += new EventHandler(this.toolBtnDamageNoApply_Click);
            this.toolBtnExportExcel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnExportExcel.Image = (Image) resources.GetObject("toolBtnExportExcel.Image");
            this.toolBtnExportExcel.Image = global::DailyReport.Properties.Resources.Excel;
            this.toolBtnExportExcel.ImageTransparentColor = Color.Magenta;
            this.toolBtnExportExcel.Name = "toolBtnExportExcel";
            this.toolBtnExportExcel.Size = new Size(0x17, 0x16);
            this.toolBtnExportExcel.Text = "Экспорт в Excel";
            this.toolBtnExportExcel.Click += new EventHandler(this.toolBtnExportExcel_Click);
            this.toolBtnPrint.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnPrint.Image = (Image) resources.GetObject("toolBtnPrint.Image");
            this.toolBtnPrint.Image = global::DailyReport.Properties.Resources.Print;
            this.toolBtnPrint.ImageTransparentColor = Color.Magenta;
            this.toolBtnPrint.Name = "toolBtnPrint";
            this.toolBtnPrint.Size = new Size(0x17, 0x16);
            this.toolBtnPrint.Text = "Печать";
            this.toolBtnPrint.Click += new EventHandler(this.toolBtnPrint_Click);
            this.splitContainer.Dock = DockStyle.Fill;
            this.splitContainer.FixedPanel = FixedPanel.Panel1;
            this.splitContainer.Location = new Point(0, 0x19);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.groupBoxLegend);
            this.splitContainer.Panel1.Controls.Add(this.checkedListBoxDivisionApply);
            this.splitContainer.Panel1.Controls.Add(this.checkBoxWhereSub);
            this.splitContainer.Panel1.Controls.Add(this.label4);
            this.splitContainer.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer.Panel1.Controls.Add(this.treeViewSchmObjects);
            this.splitContainer.Panel1.Controls.Add(this.checkedListBoxDivision);
            this.splitContainer.Panel1.Controls.Add(this.label3);
            this.splitContainer.Panel1.Controls.Add(this.dtpFilterEnd);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.dtpFilterBeg);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.toolStripFilter);
            this.splitContainer.Panel2.Controls.Add(this.splitContainerDgv);
            this.splitContainer.Size = new Size(0x531, 0x2c9);
            this.splitContainer.SplitterDistance = 0x102;
            this.splitContainer.TabIndex = 1;
            this.groupBoxLegend.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.groupBoxLegend.Controls.Add(this.txtLegendNoSESNO);
            this.groupBoxLegend.Controls.Add(this.txtLegendUnExec);
            this.groupBoxLegend.Controls.Add(this.txtLegendOverdue);
            this.groupBoxLegend.Controls.Add(this.txtLegendInWork);
            this.groupBoxLegend.Controls.Add(this.txtLegendApply);
            this.groupBoxLegend.Location = new Point(0, 0x22f);
            this.groupBoxLegend.Name = "groupBoxLegend";
            this.groupBoxLegend.Size = new Size(0x102, 0x97);
            this.groupBoxLegend.TabIndex = 0x10;
            this.groupBoxLegend.TabStop = false;
            this.groupBoxLegend.Text = "Легенда";
            this.txtLegendNoSESNO.BackColor = Color.Orange;
            this.txtLegendNoSESNO.Location = new Point(6, 0x7b);
            this.txtLegendNoSESNO.Name = "txtLegendNoSESNO";
            this.txtLegendNoSESNO.ReadOnly = true;
            this.txtLegendNoSESNO.Size = new Size(0xb7, 20);
            this.txtLegendNoSESNO.TabIndex = 5;
            this.txtLegendNoSESNO.Text = "0 - нет сетей Горсвет";
            this.txtLegendUnExec.BackColor = Color.LightPink;
            this.txtLegendUnExec.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xcc);
            this.txtLegendUnExec.ForeColor = Color.Red;
            this.txtLegendUnExec.Location = new Point(6, 0x61);
            this.txtLegendUnExec.Name = "txtLegendUnExec";
            this.txtLegendUnExec.ReadOnly = true;
            this.txtLegendUnExec.Size = new Size(0xb7, 20);
            this.txtLegendUnExec.TabIndex = 4;
            this.txtLegendUnExec.Text = "0 - неоформлено";
            this.txtLegendOverdue.BackColor = SystemColors.Window;
            this.txtLegendOverdue.ForeColor = Color.Red;
            this.txtLegendOverdue.Location = new Point(6, 0x47);
            this.txtLegendOverdue.Name = "txtLegendOverdue";
            this.txtLegendOverdue.ReadOnly = true;
            this.txtLegendOverdue.Size = new Size(0xb7, 20);
            this.txtLegendOverdue.TabIndex = 3;
            this.txtLegendOverdue.Text = "0 - просрочено";
            this.txtLegendInWork.BackColor = SystemColors.Window;
            this.txtLegendInWork.Location = new Point(6, 0x2d);
            this.txtLegendInWork.Name = "txtLegendInWork";
            this.txtLegendInWork.ReadOnly = true;
            this.txtLegendInWork.Size = new Size(0xb7, 20);
            this.txtLegendInWork.TabIndex = 2;
            this.txtLegendInWork.Text = "0 - в работе";
            this.txtLegendApply.BackColor = SystemColors.Window;
            this.txtLegendApply.ForeColor = Color.Green;
            this.txtLegendApply.Location = new Point(6, 0x13);
            this.txtLegendApply.Name = "txtLegendApply";
            this.txtLegendApply.ReadOnly = true;
            this.txtLegendApply.Size = new Size(0xb7, 20);
            this.txtLegendApply.TabIndex = 0;
            this.txtLegendApply.Text = "0 - устранено";
            this.checkedListBoxDivisionApply.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.checkedListBoxDivisionApply.CheckOnClick = true;
            this.checkedListBoxDivisionApply.FormattingEnabled = true;
            this.checkedListBoxDivisionApply.Location = new Point(12, 0xd9);
            this.checkedListBoxDivisionApply.Name = "checkedListBoxDivisionApply";
            this.checkedListBoxDivisionApply.Size = new Size(0xea, 0x5e);
            this.checkedListBoxDivisionApply.TabIndex = 14;
            this.checkBoxWhereSub.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.checkBoxWhereSub.AutoSize = true;
            this.checkBoxWhereSub.Checked = true;
            this.checkBoxWhereSub.CheckState = CheckState.Checked;
            this.checkBoxWhereSub.Location = new Point(12, 0x218);
            this.checkBoxWhereSub.Name = "checkBoxWhereSub";
            this.checkBoxWhereSub.Size = new Size(180, 0x11);
            this.checkBoxWhereSub.TabIndex = 12;
            this.checkBoxWhereSub.Text = "Фильтровать по подстанциям";
            this.checkBoxWhereSub.UseVisualStyleBackColor = true;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(12, 0xc9);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x9b, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Подразделение-исполнитель";
            this.toolStrip1.Dock = DockStyle.None;
            this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolBtnFindTreeSchmObj, this.txtFindTreeSchmObj, this.toolBtnFindPrevTreeSchmObj, this.toolBtnFindNextTreeSchmObj };
            this.toolStrip1.Items.AddRange(itemArray4);
            this.toolStrip1.Location = new Point(15, 0x13a);
            this.toolStrip1.Name = "toolStripTreeSchmObj";
            this.toolStrip1.Size = new Size(0xae, 0x19);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            this.toolBtnFindTreeSchmObj.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnFindTreeSchmObj.Image = (Image) resources.GetObject("toolBtnFindTreeSchmObj.Image");
            this.toolBtnFindTreeSchmObj.Image = global::DailyReport.Properties.Resources.Find;
            this.toolBtnFindTreeSchmObj.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindTreeSchmObj.Name = "toolBtnFindTreeSchmObj";
            this.toolBtnFindTreeSchmObj.Size = new Size(0x17, 0x16);
            this.toolBtnFindTreeSchmObj.Text = "Искать";
            this.toolBtnFindTreeSchmObj.Click += new EventHandler(this.toolBtnFindTreeSchmObj_Click);
            this.txtFindTreeSchmObj.Name = "txtFindTreeSchmObj";
            this.txtFindTreeSchmObj.Size = new Size(100, 0x19);
            this.txtFindTreeSchmObj.ToolTipText = "Текст для поиска";
            this.txtFindTreeSchmObj.KeyDown += new KeyEventHandler(this.txtFindTreeSchmObj_KeyDown);
            this.toolBtnFindPrevTreeSchmObj.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnFindPrevTreeSchmObj.Image = (Image) resources.GetObject("toolBtnFindPrevTreeSchmObj.Image");
            this.toolBtnFindPrevTreeSchmObj.Image = global::DailyReport.Properties.Resources.FindPrev;
            this.toolBtnFindPrevTreeSchmObj.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindPrevTreeSchmObj.Name = "toolBtnFindPrevTreeSchmObj";
            this.toolBtnFindPrevTreeSchmObj.Size = new Size(0x17, 0x16);
            this.toolBtnFindPrevTreeSchmObj.Text = "Искать назад";
            this.toolBtnFindPrevTreeSchmObj.Click += new EventHandler(this.toolBtnFindPrevTreeSchmObj_Click);
            this.toolBtnFindNextTreeSchmObj.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnFindNextTreeSchmObj.Image = (Image) resources.GetObject("toolBtnFindNextTreeSchmObj.Image");
            this.toolBtnFindNextTreeSchmObj.Image = global::DailyReport.Properties.Resources.FindNext;
            this.toolBtnFindNextTreeSchmObj.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindNextTreeSchmObj.Name = "toolBtnFindNextTreeSchmObj";
            this.toolBtnFindNextTreeSchmObj.Size = new Size(0x17, 0x16);
            this.toolBtnFindNextTreeSchmObj.Text = "Искать вперед";
            this.toolBtnFindNextTreeSchmObj.Click += new EventHandler(this.toolBtnFindNextTreeSchmObj_Click);
            this.treeViewSchmObjects.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.treeViewSchmObjects.CheckBoxes = true;
            this.treeViewSchmObjects.Location = new Point(12, 0x156);
            this.treeViewSchmObjects.Name = "treeViewSchmObjects";
            this.treeViewSchmObjects.Size = new Size(0xea, 0xbc);
            this.treeViewSchmObjects.SqlSettings=(null);
            this.treeViewSchmObjects.TabIndex = 10;
            this.checkedListBoxDivision.CheckOnClick = true;
            this.checkedListBoxDivision.FormattingEnabled = true;
            this.checkedListBoxDivision.Location = new Point(12, 0x77);
            this.checkedListBoxDivision.Name = "checkedListBoxDivision";
            this.checkedListBoxDivision.Size = new Size(0xea, 0x4f);
            this.checkedListBoxDivision.TabIndex = 6;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(12, 0x67);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Подразделения";
            this.dtpFilterEnd.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dtpFilterEnd.CausesValidation = false;
            this.dtpFilterEnd.Location = new Point(12, 80);
            this.dtpFilterEnd.Name = "dtpFilterEnd";
            this.dtpFilterEnd.Size = new Size(0xea, 20);
            this.dtpFilterEnd.TabIndex = 4;
            this.dtpFilterEnd.ValueChanged += new EventHandler(this.dtpFilterEnd_ValueChanged);
            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 0x40);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "До";
            this.dtpFilterBeg.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dtpFilterBeg.CausesValidation = false;
            this.dtpFilterBeg.Location = new Point(12, 0x29);
            this.dtpFilterBeg.Name = "dtpFilterBeg";
            this.dtpFilterBeg.Size = new Size(0xea, 20);
            this.dtpFilterBeg.TabIndex = 2;
            this.dtpFilterBeg.ValueChanged += new EventHandler(this.dtpFilterBeg_ValueChanged);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 0x19);
            this.label1.Name = "label1";
            this.label1.Size = new Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "От";
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.toolBtnFilterApply, this.toolBtnFilterDelete, this.toolStripSeparator4, this.toolBtnPrevYear, this.toolBtnNextYear };
            this.toolStripFilter.Items.AddRange(itemArray5);
            this.toolStripFilter.Location = new Point(0, 0);
            this.toolStripFilter.Name = "toolStripFilter";
            this.toolStripFilter.Size = new Size(0x102, 0x19);
            this.toolStripFilter.TabIndex = 0;
            this.toolStripFilter.Text = "toolStrip1";
            this.toolBtnFilterApply.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnFilterApply.Image = (Image) resources.GetObject("toolBtnFilterApply.Image");
            this.toolBtnFilterApply.Image = global::DailyReport.Properties.Resources.filter;
            this.toolBtnFilterApply.ImageTransparentColor = Color.Magenta;
            this.toolBtnFilterApply.Name = "toolBtnFilterApply";
            this.toolBtnFilterApply.Size = new Size(0x17, 0x16);
            this.toolBtnFilterApply.Text = "Применить фильтр";
            this.toolBtnFilterApply.Click += new EventHandler(this.toolBtnFilterApply_Click);
            this.toolBtnFilterDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnFilterDelete.Image = (Image) resources.GetObject("toolBtnFilterDelete.Image");
            this.toolBtnFilterDelete.Image = global::DailyReport.Properties.Resources.filter_delete;
            this.toolBtnFilterDelete.ImageTransparentColor = Color.Magenta;
            this.toolBtnFilterDelete.Name = "toolBtnFilterDelete";
            this.toolBtnFilterDelete.Size = new Size(0x17, 0x16);
            this.toolBtnFilterDelete.Text = "Убрать фильтр";
            this.toolBtnFilterDelete.Click += new EventHandler(this.toolBtnFilterDelete_Click);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new Size(6, 0x19);
            this.toolBtnPrevYear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnPrevYear.Image = (Image) resources.GetObject("toolBtnPrevYear.Image");
            this.toolBtnPrevYear.Image = global::DailyReport.Properties.Resources.arrowPrev;
            this.toolBtnPrevYear.ImageTransparentColor = Color.Magenta;
            this.toolBtnPrevYear.Name = "toolBtnPrevYear";
            this.toolBtnPrevYear.Size = new Size(0x17, 0x16);
            this.toolBtnPrevYear.Text = "Предыдущий год";
            this.toolBtnPrevYear.Click += new EventHandler(this.toolBtnPrevYear_Click);
            this.toolBtnNextYear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            // this.toolBtnNextYear.Image = (Image) resources.GetObject("toolBtnNextYear.Image");
            this.toolBtnNextYear.Image = global::DailyReport.Properties.Resources.arrowNext;
            this.toolBtnNextYear.ImageTransparentColor = Color.Magenta;
            this.toolBtnNextYear.Name = "toolBtnNextYear";
            this.toolBtnNextYear.Size = new Size(0x17, 0x16);
            this.toolBtnNextYear.Text = "Следующий год";
            this.toolBtnNextYear.Click += new EventHandler(this.toolBtnNextYear_Click);
            this.splitContainerDgv.Dock = DockStyle.Fill;
            this.splitContainerDgv.FixedPanel = FixedPanel.Panel2;
            this.splitContainerDgv.Location = new Point(0, 0);
            this.splitContainerDgv.Name = "splitContainerDgv";
            this.splitContainerDgv.Orientation = Orientation.Horizontal;
            this.splitContainerDgv.Panel1.Controls.Add(this.dgvDamage);
            this.splitContainerDgv.Panel2.Controls.Add(this.dgvLinkDocs);
            this.splitContainerDgv.Panel2.Controls.Add(this.lbLinkDoc);
            this.splitContainerDgv.Panel2MinSize = 13;
            this.splitContainerDgv.Size = new Size(0x42b, 0x2c9);
            this.splitContainerDgv.SplitterDistance = 0x22b;
            this.splitContainerDgv.TabIndex = 1;
            this.dgvDamage.AllowUserToAddRows = false;
            this.dgvDamage.AllowUserToDeleteRows = false;
            this.dgvDamage.AllowUserToOrderColumns = true;
            this.dgvDamage.AutoGenerateColumns = false;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dgvDamage.ColumnHeadersDefaultCellStyle = style;
            this.dgvDamage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
                this.isLaboratoryDgvColumn, this.isApplyDgvColumn, this.numrequestDataGridViewTextBoxColumn, this.numDocDataGridViewTextBoxColumn, this.dateDocDgvColumn, this.typeDocNameDataGridViewTextBoxColumn, this.divisionDataGridViewTextBoxColumn, this.schmObjNameDataGridViewTextBoxColumn, this.netRegionSubDgvColumn, this.defectLocationDataGridViewTextBoxColumn, this.reasonDataGridViewTextBoxColumn, this.divisionApplyDataGridViewTextBoxColumn, this.dateApplyDgvColumn, this.datePlanEndDgvColumn, this.workerApplyDataGridViewTextBoxColumn, this.completedWorkDataGridViewTextBoxColumn,
                this.compilerDataGridViewTextBoxColumn, this.InstructionDgvColumn, this.nameOwnerDgvColumn, this.dateOwnerDgvColumn, this.comletedWorkTextDataGridViewTextBoxColumn, this.KodPTSDgvColumn, this.kodPTSStrDgvColumn, this.idParentDgvColumn, this.isNoSESNODgvColumn, this.typeDocDgvColumn, this.idDataGridViewTextBoxColumn, this.idReasonDgvColumn, this.idReqForRepairDgvColumn
            };
            this.dgvDamage.Columns.AddRange(dataGridViewColumns);
            this.dgvDamage.DataSource = this.bindingSource_0;
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = SystemColors.Window;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style2.ForeColor = SystemColors.ControlText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.False;
            this.dgvDamage.DefaultCellStyle = style2;
            this.dgvDamage.Dock = DockStyle.Fill;
            this.dgvDamage.Location = new Point(0, 0);
            this.dgvDamage.Name = "dgvDamage";
            this.dgvDamage.ReadOnly = true;
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Control;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style3.ForeColor = SystemColors.WindowText;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.True;
            this.dgvDamage.RowHeadersDefaultCellStyle = style3;
            this.dgvDamage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDamage.Size = new Size(0x42b, 0x22b);
            this.dgvDamage.TabIndex = 0;
            this.dgvDamage.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dgvDamage.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.dgvDamage.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dataGridViewExcelFilter_0_CellMouseClick);
            this.dgvDamage.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_0_RowPostPaint);
            this.isLaboratoryDgvColumn.DataPropertyName = "isLaboratory";
            this.isLaboratoryDgvColumn.FalseValue = "Нет";
            this.isLaboratoryDgvColumn.HeaderText = "ПЛ";
            this.isLaboratoryDgvColumn.Name = "isLaboratoryDgvColumn";
            this.isLaboratoryDgvColumn.ReadOnly = true;
            this.isLaboratoryDgvColumn.Resizable = DataGridViewTriState.True;
            this.isLaboratoryDgvColumn.TrueValue = "Да";
            this.isLaboratoryDgvColumn.Visible = false;
            this.isLaboratoryDgvColumn.Width = 40;
            this.isApplyDgvColumn.DataPropertyName = "isApply";
            this.isApplyDgvColumn.HeaderText = "Выполнено";
            this.isApplyDgvColumn.Name = "isApplyDgvColumn";
            this.isApplyDgvColumn.ReadOnly = true;
            this.isApplyDgvColumn.Resizable = DataGridViewTriState.True;
            this.isApplyDgvColumn.SortMode=(DataGridViewColumnSortMode.NotSortable);
            this.isApplyDgvColumn.Visible = false;
            this.numrequestDataGridViewTextBoxColumn.DataPropertyName = "numrequest";
            this.numrequestDataGridViewTextBoxColumn.HeaderText = "№ заявки";
            this.numrequestDataGridViewTextBoxColumn.Name = "numrequestDataGridViewTextBoxColumn";
            this.numrequestDataGridViewTextBoxColumn.ReadOnly = true;
            this.numrequestDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.numDocDataGridViewTextBoxColumn.DataPropertyName = "numDoc";
            this.numDocDataGridViewTextBoxColumn.HeaderText = "№ документа";
            this.numDocDataGridViewTextBoxColumn.Name = "numDocDataGridViewTextBoxColumn";
            this.numDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDocDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.numDocDataGridViewTextBoxColumn.Visible = false;
            this.dateDocDgvColumn.DataPropertyName = "dateDoc";
            this.dateDocDgvColumn.HeaderText = "Дата заявки";
            this.dateDocDgvColumn.Name = "dateDocDgvColumn";
            this.dateDocDgvColumn.ReadOnly = true;
            this.dateDocDgvColumn.Resizable = DataGridViewTriState.True;
            this.typeDocNameDataGridViewTextBoxColumn.DataPropertyName = "TypeDocName";
            this.typeDocNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDocNameDataGridViewTextBoxColumn.Name = "typeDocNameDataGridViewTextBoxColumn";
            this.typeDocNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDocNameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            this.divisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.divisionDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.divisionDataGridViewTextBoxColumn.Visible = false;
            this.schmObjNameDataGridViewTextBoxColumn.DataPropertyName = "schmObjName";
            this.schmObjNameDataGridViewTextBoxColumn.HeaderText = "Электроустановка";
            this.schmObjNameDataGridViewTextBoxColumn.Name = "schmObjNameDataGridViewTextBoxColumn";
            this.schmObjNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.schmObjNameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.netRegionSubDgvColumn.DataPropertyName = "NetRegionSub";
            this.netRegionSubDgvColumn.HeaderText = "Сетевой район";
            this.netRegionSubDgvColumn.Name = "netRegionSubDgvColumn";
            this.netRegionSubDgvColumn.ReadOnly = true;
            this.defectLocationDataGridViewTextBoxColumn.DataPropertyName = "defectLocation";
            style4.WrapMode = DataGridViewTriState.True;
            this.defectLocationDataGridViewTextBoxColumn.DefaultCellStyle = style4;
            this.defectLocationDataGridViewTextBoxColumn.HeaderText = "Место повреждения";
            this.defectLocationDataGridViewTextBoxColumn.Name = "defectLocationDataGridViewTextBoxColumn";
            this.defectLocationDataGridViewTextBoxColumn.ReadOnly = true;
            this.defectLocationDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            style5.WrapMode = DataGridViewTriState.True;
            this.reasonDataGridViewTextBoxColumn.DefaultCellStyle = style5;
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Причина";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.divisionApplyDataGridViewTextBoxColumn.DataPropertyName = "DivisionApply";
            style6.WrapMode = DataGridViewTriState.True;
            this.divisionApplyDataGridViewTextBoxColumn.DefaultCellStyle = style6;
            this.divisionApplyDataGridViewTextBoxColumn.HeaderText = "Подразделение исполнитель";
            this.divisionApplyDataGridViewTextBoxColumn.Name = "divisionApplyDataGridViewTextBoxColumn";
            this.divisionApplyDataGridViewTextBoxColumn.ReadOnly = true;
            this.divisionApplyDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.dateApplyDgvColumn.DataPropertyName = "dateApply";
            this.dateApplyDgvColumn.HeaderText = "Дата устранения";
            this.dateApplyDgvColumn.Name = "dateApplyDgvColumn";
            this.dateApplyDgvColumn.ReadOnly = true;
            this.dateApplyDgvColumn.Resizable = DataGridViewTriState.True;
            this.datePlanEndDgvColumn.DataPropertyName = "datePlanEnd";
            this.datePlanEndDgvColumn.HeaderText = "План дата устранения";
            this.datePlanEndDgvColumn.Name = "datePlanEndDgvColumn";
            this.datePlanEndDgvColumn.ReadOnly = true;
            this.workerApplyDataGridViewTextBoxColumn.DataPropertyName = "workerApply";
            this.workerApplyDataGridViewTextBoxColumn.HeaderText = "Выполнил";
            this.workerApplyDataGridViewTextBoxColumn.Name = "workerApplyDataGridViewTextBoxColumn";
            this.workerApplyDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerApplyDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.completedWorkDataGridViewTextBoxColumn.DataPropertyName = "completedWork";
            style7.WrapMode = DataGridViewTriState.True;
            this.completedWorkDataGridViewTextBoxColumn.DefaultCellStyle = style7;
            this.completedWorkDataGridViewTextBoxColumn.HeaderText = "Выполненная работа";
            this.completedWorkDataGridViewTextBoxColumn.Name = "completedWorkDataGridViewTextBoxColumn";
            this.completedWorkDataGridViewTextBoxColumn.ReadOnly = true;
            this.completedWorkDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.compilerDataGridViewTextBoxColumn.DataPropertyName = "compiler";
            this.compilerDataGridViewTextBoxColumn.HeaderText = "Составитель";
            this.compilerDataGridViewTextBoxColumn.Name = "compilerDataGridViewTextBoxColumn";
            this.compilerDataGridViewTextBoxColumn.ReadOnly = true;
            this.compilerDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.compilerDataGridViewTextBoxColumn.Visible = false;
            this.InstructionDgvColumn.DataPropertyName = "Instruction";
            style8.WrapMode = DataGridViewTriState.True;
            this.InstructionDgvColumn.DefaultCellStyle = style8;
            this.InstructionDgvColumn.HeaderText = "Указания";
            this.InstructionDgvColumn.Name = "InstructionDgvColumn";
            this.InstructionDgvColumn.ReadOnly = true;
            this.InstructionDgvColumn.Width = 120;
            this.nameOwnerDgvColumn.DataPropertyName = "ownerName";
            this.nameOwnerDgvColumn.HeaderText = "Автор";
            this.nameOwnerDgvColumn.Name = "nameOwnerDgvColumn";
            this.nameOwnerDgvColumn.ReadOnly = true;
            this.nameOwnerDgvColumn.Visible = false;
            this.dateOwnerDgvColumn.DataPropertyName = "dateOwner";
            this.dateOwnerDgvColumn.HeaderText = "Дата создания";
            this.dateOwnerDgvColumn.Name = "dateOwnerDgvColumn";
            this.dateOwnerDgvColumn.ReadOnly = true;
            this.dateOwnerDgvColumn.Visible = false;
            this.comletedWorkTextDataGridViewTextBoxColumn.DataPropertyName = "ComletedWorkText";
            style9.WrapMode = DataGridViewTriState.True;
            this.comletedWorkTextDataGridViewTextBoxColumn.DefaultCellStyle = style9;
            this.comletedWorkTextDataGridViewTextBoxColumn.HeaderText = "Выполненная работа текст";
            this.comletedWorkTextDataGridViewTextBoxColumn.Name = "comletedWorkTextDataGridViewTextBoxColumn";
            this.comletedWorkTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.comletedWorkTextDataGridViewTextBoxColumn.Visible = false;
            this.KodPTSDgvColumn.DataPropertyName = "KodPTS";
            style10.Format = "N0";
            style10.NullValue = null;
            this.KodPTSDgvColumn.DefaultCellStyle = style10;
            this.KodPTSDgvColumn.HeaderText = "Код повреждения";
            this.KodPTSDgvColumn.Name = "KodPTSDgvColumn";
            this.KodPTSDgvColumn.ReadOnly = true;
            this.KodPTSDgvColumn.Visible = false;
            this.kodPTSStrDgvColumn.DataPropertyName = "KodPTSStr";
            this.kodPTSStrDgvColumn.HeaderText = "Код повреждения (стр)";
            this.kodPTSStrDgvColumn.Name = "kodPTSStrDgvColumn";
            this.kodPTSStrDgvColumn.ReadOnly = true;
            this.kodPTSStrDgvColumn.Resizable = DataGridViewTriState.True;
            this.idParentDgvColumn.DataPropertyName = "idParent";
            this.idParentDgvColumn.HeaderText = "Родитель";
            this.idParentDgvColumn.Name = "idParentDgvColumn";
            this.idParentDgvColumn.ReadOnly = true;
            this.idParentDgvColumn.Visible = false;
            this.isNoSESNODgvColumn.DataPropertyName = "isNoSESNO";
            this.isNoSESNODgvColumn.HeaderText = "не горсвет";
            this.isNoSESNODgvColumn.Name = "isNoSESNODgvColumn";
            this.isNoSESNODgvColumn.ReadOnly = true;
            this.isNoSESNODgvColumn.Visible = false;
            this.typeDocDgvColumn.DataPropertyName = "TypeDoc";
            this.typeDocDgvColumn.HeaderText = "TypeDoc";
            this.typeDocDgvColumn.Name = "typeDocDgvColumn";
            this.typeDocDgvColumn.ReadOnly = true;
            this.typeDocDgvColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idReasonDgvColumn.DataPropertyName = "idReason";
            this.idReasonDgvColumn.HeaderText = "idReason";
            this.idReasonDgvColumn.Name = "idReasonDgvColumn";
            this.idReasonDgvColumn.ReadOnly = true;
            this.idReasonDgvColumn.Visible = false;
            this.idReqForRepairDgvColumn.DataPropertyName = "idReqForRepair";
            this.idReqForRepairDgvColumn.HeaderText = "idReqForRepair";
            this.idReqForRepairDgvColumn.Name = "idReqForRepairDgvColumn";
            this.idReqForRepairDgvColumn.ReadOnly = true;
            this.idReqForRepairDgvColumn.Visible = false;
            this.bindingSource_0.DataMember = "vJ_Damage";
            this.bindingSource_0.DataSource = this.dsDamageN;
            this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
            this.bindingSource_0.ListChanged += new ListChangedEventHandler(this.bindingSource_0_ListChanged);
            this.dsDamageN.DataSetName = "DataSetDamage";
            this.dsDamageN.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.dgvLinkDocs.AllowUserToAddRows = false;
            this.dgvLinkDocs.AllowUserToDeleteRows = false;
            this.dgvLinkDocs.AllowUserToVisibleColumns=(false);
            this.dgvLinkDocs.AutoGenerateColumns = false;
            this.dgvLinkDocs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.numDocDataGridViewTextBoxColumn1, this.dateDocDataGridViewTextBoxColumn, this.idLinkDocDgvColumn, this.typeDocDataGridViewTextBoxColumn, this.typeDocNameDataGridViewTextBoxColumn1, this.isParentDgvColumn };
            this.dgvLinkDocs.Columns.AddRange(columnArray2);
            this.dgvLinkDocs.DataSource = this.bindingSource_1;
            this.dgvLinkDocs.Dock = DockStyle.Fill;
            this.dgvLinkDocs.Location = new Point(0, 13);
            this.dgvLinkDocs.Name = "dgvLinkDocs";
            this.dgvLinkDocs.ReadOnly = true;
            this.dgvLinkDocs.Size = new Size(0x42b, 0x8d);
            this.dgvLinkDocs.TabIndex = 10;
            this.dgvLinkDocs.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dgvLinkDocs_CellFormatting);
            this.numDocDataGridViewTextBoxColumn1.DataPropertyName = "numDoc";
            this.numDocDataGridViewTextBoxColumn1.HeaderText = "№ документа";
            this.numDocDataGridViewTextBoxColumn1.Name = "numDocDataGridViewTextBoxColumn1";
            this.numDocDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dateDocDataGridViewTextBoxColumn.DataPropertyName = "dateDoc";
            this.dateDocDataGridViewTextBoxColumn.HeaderText = "Дата документа";
            this.dateDocDataGridViewTextBoxColumn.Name = "dateDocDataGridViewTextBoxColumn";
            this.dateDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDocDataGridViewTextBoxColumn.Width = 150;
            this.idLinkDocDgvColumn.DataPropertyName = "id";
            this.idLinkDocDgvColumn.HeaderText = "id";
            this.idLinkDocDgvColumn.Name = "idLinkDocDgvColumn";
            this.idLinkDocDgvColumn.ReadOnly = true;
            this.idLinkDocDgvColumn.Visible = false;
            this.typeDocDataGridViewTextBoxColumn.DataPropertyName = "TypeDoc";
            this.typeDocDataGridViewTextBoxColumn.HeaderText = "TypeDoc";
            this.typeDocDataGridViewTextBoxColumn.Name = "typeDocDataGridViewTextBoxColumn";
            this.typeDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDocDataGridViewTextBoxColumn.Visible = false;
            this.typeDocNameDataGridViewTextBoxColumn1.DataPropertyName = "TypeDocName";
            this.typeDocNameDataGridViewTextBoxColumn1.HeaderText = "Тип документа";
            this.typeDocNameDataGridViewTextBoxColumn1.Name = "typeDocNameDataGridViewTextBoxColumn1";
            this.typeDocNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.typeDocNameDataGridViewTextBoxColumn1.Width = 250;
            this.isParentDgvColumn.DataPropertyName = "isParent";
            this.isParentDgvColumn.HeaderText = "isParent";
            this.isParentDgvColumn.Name = "isParentDgvColumn";
            this.isParentDgvColumn.ReadOnly = true;
            this.isParentDgvColumn.Visible = false;
            this.bindingSource_1.DataMember = "dtLinkDocs";
            this.bindingSource_1.DataSource = this.ds;
            this.ds.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dtLinkDocs };
            this.ds.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.id, this.TypeDoc, this.TypeDocName, this.numDoc, this.dateDoc, this.idReqForRepair, this.isParent };
            this.dtLinkDocs.Columns.AddRange(columns);
            this.dtLinkDocs.TableName = "dtLinkDocs";
            this.id.ColumnName = "id";
            this.id.DataType = typeof(int);
            this.TypeDoc.ColumnName = "TypeDoc";
            this.TypeDoc.DataType = typeof(int);
            this.TypeDocName.ColumnName = "TypeDocName";
            this.numDoc.ColumnName = "numDoc";
            this.dateDoc.ColumnName = "dateDoc";
            this.dateDoc.DataType = typeof(DateTime);
            this.idReqForRepair.ColumnName = "idReqForRepair";
            this.idReqForRepair.DataType = typeof(int);
            this.isParent.ColumnName = "isParent";
            this.isParent.DataType = typeof(bool);
            this.lbLinkDoc.Cursor = Cursors.PanNorth;
            this.lbLinkDoc.Dock = DockStyle.Top;
            this.lbLinkDoc.Location = new Point(0, 0);
            this.lbLinkDoc.Name = "lbLinkDoc";
            this.lbLinkDoc.Size = new Size(0x42b, 13);
            this.lbLinkDoc.TabIndex = 9;
            this.lbLinkDoc.Text = "Связанные документы";
            this.lbLinkDoc.TextAlign = ContentAlignment.TopCenter;
            this.lbLinkDoc.Click += new EventHandler(this.lbLinkDoc_Click);
            ToolStripItem[] itemArray6 = new ToolStripItem[] { this.toolItemAdd, this.toolItemEdit, this.toolItemInfo, this.toolItemDel, this.toolStripSeparator5, this.toolItemActDetection };
            this.contextMenuDamage.Items.AddRange(itemArray6);
            this.contextMenuDamage.Name = "contextMenuDamage";
            this.contextMenuDamage.Size = new Size(180, 120);
            this.contextMenuDamage.Opening += new CancelEventHandler(this.contextMenuDamage_Opening);
            // this.toolItemAdd.Image = (Image) resources.GetObject("toolItemAdd.Image");
            this.toolItemAdd.Image = global::DailyReport.Properties.Resources.ElementAdd;
            this.toolItemAdd.Name = "toolItemAdd";
            this.toolItemAdd.Size = new Size(0xb3, 0x16);
            this.toolItemAdd.Text = "Добавить";
            // this.toolItemEdit.Image = (Image) resources.GetObject("toolItemEdit.Image");
            this.toolItemEdit.Image = global::DailyReport.Properties.Resources.ElementEdit;
            this.toolItemEdit.Name = "toolItemEdit";
            this.toolItemEdit.Size = new Size(0xb3, 0x16);
            this.toolItemEdit.Text = "Изменить";
            this.toolItemEdit.Click += new EventHandler(this.toolBtnEdit_Click);
            // this.toolItemInfo.Image = (Image) resources.GetObject("toolItemInfo.Image");
            this.toolItemInfo.Image = global::DailyReport.Properties.Resources.ElementInformation;
            this.toolItemInfo.Name = "toolItemInfo";
            this.toolItemInfo.Size = new Size(0xb3, 0x16);
            this.toolItemInfo.Text = "Просмотр";
            this.toolItemInfo.Click += new EventHandler(this.toolItemInfo_Click);
            // this.toolItemDel.Image = (Image) resources.GetObject("toolItemDel.Image");
            this.toolItemDel.Image = global::DailyReport.Properties.Resources.ElementDel;
            this.toolItemDel.Name = "toolItemDel";
            this.toolItemDel.Size = new Size(0xb3, 0x16);
            this.toolItemDel.Text = "Удалить";
            this.toolItemDel.Click += new EventHandler(this.toolItemDel_Click);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new Size(0xb0, 6);
            ToolStripItem[] itemArray7 = new ToolStripItem[] { this.toolItemActDetectionAdd, this.toolStripSeparator6 };
            this.toolItemActDetection.DropDownItems.AddRange(itemArray7);
            this.toolItemActDetection.Name = "toolItemActDetection";
            this.toolItemActDetection.Size = new Size(0xb3, 0x16);
            this.toolItemActDetection.Text = "Акт расследования";
            this.toolItemActDetectionAdd.Name = "toolItemActDetectionAdd";
            this.toolItemActDetectionAdd.Size = new Size(0x75, 0x16);
            this.toolItemActDetectionAdd.Text = "Создать";
            this.toolItemActDetectionAdd.Click += new EventHandler(this.toolItemActDetectionAdd_Click);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new Size(0x72, 6);
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "numrequest";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "№ заявки";
            this.dataGridViewFilterTextBoxColumn_0.Name = "dataGridViewFilterTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "numDoc";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "№ документа";
            this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewFilterTextBoxColumn2";
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.Visible = false;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "dateDoc";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Дата заявки";
            this.dataGridViewFilterTextBoxColumn_2.Name = "dataGridViewFilterTextBoxColumn3";
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "TypeDocName";
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Тип";
            this.dataGridViewFilterTextBoxColumn_3.Name = "dataGridViewFilterTextBoxColumn4";
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "Division";
            this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Подразделение";
            this.dataGridViewFilterTextBoxColumn_4.Name = "dataGridViewFilterTextBoxColumn5";
            this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_4.Visible = false;
            this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "schmObjName";
            this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Электроустановка";
            this.dataGridViewFilterTextBoxColumn_5.Name = "dataGridViewFilterTextBoxColumn6";
            this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "NetRegionSub";
            this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Сетевой район";
            this.dataGridViewFilterTextBoxColumn_6.Name = "dataGridViewFilterTextBoxColumn7";
            this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "defectLocation";
            style11.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_7.DefaultCellStyle = style11;
            this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Место повреждения";
            this.dataGridViewFilterTextBoxColumn_7.Name = "dataGridViewFilterTextBoxColumn8";
            this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "Reason";
            style12.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_8.DefaultCellStyle = style12;
            this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Причина";
            this.dataGridViewFilterTextBoxColumn_8.Name = "dataGridViewFilterTextBoxColumn9";
            this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "DivisionApply";
            style13.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_9.DefaultCellStyle = style13;
            this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Подразделение исполнитель";
            this.dataGridViewFilterTextBoxColumn_9.Name = "dataGridViewFilterTextBoxColumn10";
            this.dataGridViewFilterTextBoxColumn_9.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "dateApply";
            this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Дата устранения";
            this.dataGridViewFilterTextBoxColumn_10.Name = "dataGridViewFilterTextBoxColumn11";
            this.dataGridViewFilterTextBoxColumn_10.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "workerApply";
            this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Выполнил";
            this.dataGridViewFilterTextBoxColumn_11.Name = "dataGridViewFilterTextBoxColumn12";
            this.dataGridViewFilterTextBoxColumn_11.Resizable = DataGridViewTriState.True;

            this.dataGridViewFilterTextBoxColumn_19.DataPropertyName = "completedWork";
            style14.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_19.DefaultCellStyle = style14;
            this.dataGridViewFilterTextBoxColumn_19.HeaderText = "Выполненная работа";
            this.dataGridViewFilterTextBoxColumn_19.Name = "dataGridViewFilterTextBoxColumn13";
            this.dataGridViewFilterTextBoxColumn_19.Resizable = DataGridViewTriState.True;

            this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "compiler";
            this.dataGridViewFilterTextBoxColumn_13.HeaderText = "Составитель";
            this.dataGridViewFilterTextBoxColumn_13.Name = "dataGridViewFilterTextBoxColumn14";
            this.dataGridViewFilterTextBoxColumn_13.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_13.Visible = false;

            //this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "workerApply";
            //this.dataGridViewFilterTextBoxColumn_12.HeaderText = "Выполнил";
            //this.dataGridViewFilterTextBoxColumn_12.Name = "dataGridViewFilterTextBoxColumn12";
            //this.dataGridViewFilterTextBoxColumn_12.Resizable = DataGridViewTriState.True;


            this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "Instruction";
            style15.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_14.DefaultCellStyle = style15;
            this.dataGridViewFilterTextBoxColumn_14.HeaderText = "Указания";
            this.dataGridViewFilterTextBoxColumn_14.Name = "dataGridViewFilterTextBoxColumn15";
            this.dataGridViewFilterTextBoxColumn_14.Width = 120;
            this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "ownerName";
            this.dataGridViewFilterTextBoxColumn_15.HeaderText = "Автор";
            this.dataGridViewFilterTextBoxColumn_15.Name = "dataGridViewFilterTextBoxColumn16";
            this.dataGridViewFilterTextBoxColumn_15.Visible = false;
            this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "dateOwner";
            this.dataGridViewFilterTextBoxColumn_16.HeaderText = "Дата создания";
            this.dataGridViewFilterTextBoxColumn_16.Name = "dataGridViewFilterTextBoxColumn17";
            this.dataGridViewFilterTextBoxColumn_16.Visible = false;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "ComletedWorkText";
            style16.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_0.DefaultCellStyle = style16;
            this.dataGridViewTextBoxColumn_0.HeaderText = "Выполненная работа текст";
            this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewFilterTextBoxColumn_17.DataPropertyName = "KodPTS";
            style17.Format = "N0";
            style17.NullValue = null;
            this.dataGridViewFilterTextBoxColumn_17.DefaultCellStyle = style17;
            this.dataGridViewFilterTextBoxColumn_17.HeaderText = "Код повреждения";
            this.dataGridViewFilterTextBoxColumn_17.Name = "dataGridViewFilterTextBoxColumn18";
            this.dataGridViewFilterTextBoxColumn_17.Visible = false;
            this.dataGridViewFilterTextBoxColumn_18.DataPropertyName = "KodPTSStr";
            this.dataGridViewFilterTextBoxColumn_18.HeaderText = "Код повреждения (стр)";
            this.dataGridViewFilterTextBoxColumn_18.Name = "dataGridViewFilterTextBoxColumn19";
            this.dataGridViewFilterTextBoxColumn_18.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "idParent";
            this.dataGridViewTextBoxColumn_1.HeaderText = "Родитель";
            this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn_2.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_3.HeaderText = "id";
            this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn_3.Visible = false;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "idReason";
            this.dataGridViewTextBoxColumn_4.HeaderText = "idReason";
            this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "idReqForRepair";
            this.dataGridViewTextBoxColumn_5.HeaderText = "idReqForRepair";
            this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.toolBtnSettingMail.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnSettingMail.Image = global::DailyReport.Properties.Resources.mail;
            this.toolBtnSettingMail.ImageTransparentColor = Color.Magenta;
            this.toolBtnSettingMail.Name = "toolBtnSettingMail";
            this.toolBtnSettingMail.Size = new Size(0x17, 0x16);
            this.toolBtnSettingMail.Text = "Настройки отправки почты";
            this.toolBtnSettingMail.Click += new EventHandler(this.toolBtnSettingMail_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x531, 0x2e2);
            base.Controls.Add(this.splitContainer);
            base.Controls.Add(this.toolStrip);
            base.Name = "FormJournalDamage";
            this.Text = "Журнал технологических нарушений (N)";
            base.FormClosed += new FormClosedEventHandler(this.FormJournalDamage_FormClosed);
            base.Load += new EventHandler(this.FormJournalDamage_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.groupBoxLegend.ResumeLayout(false);
            this.groupBoxLegend.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripFilter.ResumeLayout(false);
            this.toolStripFilter.PerformLayout();
            this.splitContainerDgv.Panel1.ResumeLayout(false);
            this.splitContainerDgv.Panel2.ResumeLayout(false);
            this.splitContainerDgv.ResumeLayout(false);
            ((ISupportInitialize)this.dgvDamage).EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            ((ISupportInitialize) this.dsDamageN).EndInit();
            ((ISupportInitialize)this.dgvLinkDocs).EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            this.ds.EndInit();
            this.dtLinkDocs.EndInit();
            this.contextMenuDamage.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_2(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem) sender;
            if (item.Tag != null)
            {
                this.OpenDocument(Convert.ToInt32(item.Tag), -1, false);
            }
        }

        // TW846ung6ju
        private void OpenDocument(int TypeDoc, int idDoc = -1, bool statusPositioningOnCloseForm = false)
        {
            switch (TypeDoc)
            {
                case 0x579://1401
                {
                    FormDamageLVAddEdit form = new FormDamageLVAddEdit(idDoc, TypeDoc);//c000260
                    form.SqlSettings = this.SqlSettings;
                    form.MdiParent = base.MdiParent;
                    form.FormViewMode(statusPositioningOnCloseForm);
                    if (!statusPositioningOnCloseForm)
                    {
                        form.FormClosed += new FormClosedEventHandler(this.Damage_FormClosed);
                    }
                    form.Show();
                    return;
                }
                case 0x57a: //1402
                {
                    FormDamageHVAddEdit form2 = new FormDamageHVAddEdit(idDoc);//c00025b
                        form2.SqlSettings=this.SqlSettings;
                    form2.MdiParent = base.MdiParent;
                    form2.FormViewMode(statusPositioningOnCloseForm);
                    if (!statusPositioningOnCloseForm)
                    {
                        form2.FormClosed += new FormClosedEventHandler(this.Damage_FormClosed);
                    }
                    form2.Show();
                    return;
                }
                case 0x57b://1403
                case 0x734://1844
                {
                    FormDefectAddEdit form3 = new FormDefectAddEdit(idDoc, TypeDoc);//c00025f
                        form3.SqlSettings=(this.SqlSettings);
                    form3.MdiParent = base.MdiParent;
                    form3.FormViewMode(statusPositioningOnCloseForm);
                    if (!statusPositioningOnCloseForm)
                    {
                        form3.FormClosed += new FormClosedEventHandler(this.Damage_FormClosed);
                    }
                    form3.Show();
                    return;
                }
                case 0x752://1874
                {
                        JournalActDetection.FormActDetectionAddEdit form1 = new JournalActDetection.FormActDetectionAddEdit(new int?(idDoc)); //c0002d6
                        form1.SqlSettings = (this.SqlSettings);
                        form1.MdiParent = base.MdiParent;
                        form1.FormViewMode((statusPositioningOnCloseForm));
                        form1.Show();
                        return;
                    }
            }
        }

        private void Damage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((sender is Form) && (((Form) sender).DialogResult == DialogResult.OK))
            {
                int num = -1;
                if (sender is FormDamageLVAddEdit)
                {
                    num = ((FormDamageLVAddEdit) sender).getIdUseDoc();
                }
                if (sender is FormDefectAddEdit)
                {
                    num = ((FormDefectAddEdit) sender).getIdUseDoc();
                }
                this.SearchIdDamage(num);//vkl46GAdVS1
            }
        }

        private void method_5(int int_1)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("update tj_damage \r\n                                                          set idParent = null\r\n                                                          where idParent = {0} and isApply = 1", int_1);
                        command.ExecuteNonQuery();
                        command.CommandText = string.Format("delete tj_damage \r\n                                                          where idParent = {0} and (isApply = 0 or isApply is null)", int_1);
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
        /// <summary>
        /// Поиск строки по idDamage, с позиционированеим
        /// </summary>
        private void SearchIdDamage(int idDamage = -1)
        {
            Struct10 struct2;
            if ((idDamage == -1) && (this.dgvDamage.CurrentRow != null))
            {
                idDamage = Convert.ToInt32(this.dgvDamage.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
            }
            string str = "";
            str = string.Format(" where (deleted = 0) and (dateDoc >= '{0}' and dateDoc < '{1}') ", this.dtpFilterBeg.Value.ToString("yyyyMMdd"), this.dtpFilterEnd.Value.AddDays(1.0).ToString("yyyyMMdd"));
            if ((this.checkedListBoxDivision.CheckedItems.Count > 0) && (this.checkedListBoxDivision.CheckedItems.Count < this.checkedListBoxDivision.Items.Count))
            {
                string listDivision = ""; // список подразделений
                foreach (object obj2 in this.checkedListBoxDivision.CheckedItems)
                {
                    if (string.IsNullOrEmpty(listDivision))
                    {
                        struct2 = (Struct10) obj2;
                        listDivision = struct2.id.ToString();
                    }
                    else
                    {
                        struct2 = (Struct10) obj2;
                        listDivision = listDivision + "," + struct2.id.ToString();
                    }
                }
                str = str + string.Format(" and (idDivision in ({0}))", listDivision);
            }
            List<int> listChecked = this.treeViewSchmObjects.GetListChecked();
            if (listChecked.Count > 0)
            {
                string listSchmObj = "";// список объектов схемы
                foreach (int num in listChecked)
                {
                    if (string.IsNullOrEmpty(listSchmObj))
                    {
                        listSchmObj = num.ToString();
                    }
                    else
                    {
                        listSchmObj = listSchmObj + "," + num.ToString();
                    }
                }
                if (this.checkBoxWhereSub.Checked)
                {
                    str = str + string.Format(" and (idSchmObj in ({0}) or idSub in ({0}))", listSchmObj);
                }
                else
                {
                    str = str + string.Format(" and (idSchmObj in ({0}))", listSchmObj);
                }
            }
            if (this.checkedListBoxDivisionApply.Items.Count > 0)
            {
                if (this.checkedListBoxDivisionApply.CheckedItems.Count == 0)
                {
                    str = str + " and (idDivisionApply is null and (isLaboratory is null or isLaboratory = 0)) ";
                }
                if (this.checkedListBoxDivisionApply.CheckedItems.Count < this.checkedListBoxDivisionApply.Items.Count)
                {
                    bool flag = false;
                    string listDivisionApply = "";
                    foreach (object obj3 in this.checkedListBoxDivisionApply.CheckedItems)
                    {
                        if (((Struct10) obj3).id == -1)
                        {
                            flag = true;
                        }
                        else if (string.IsNullOrEmpty(listDivisionApply))
                        {
                            struct2 = (Struct10) obj3;
                            listDivisionApply = struct2.id.ToString();
                        }
                        else
                        {
                            struct2 = (Struct10) obj3;
                            listDivisionApply = listDivisionApply + "," + struct2.id.ToString();
                        }
                    }
                    if (string.IsNullOrEmpty(listDivisionApply))
                    {
                        if (flag)
                        {
                            str = str + " and (IsLaboratory = 1 and typedoc in (1403,1844)) ";
                        }
                    }
                    else if (flag)
                    {
                        str = str + string.Format(" and (idDivisionApply in ({0}) or (isLaboratory = 1 and typedoc in (1403,1844))\r\n                                                       or (idDivisionApply is null and (isLaboratory is null or isLaboratory = 0)))", listDivisionApply);
                    }
                    else
                    {
                        str = str + string.Format(" and (idDivisionApply in ({0}) or\r\n                                                          (idDivisionApply is null and (isLaboratory is null or isLaboratory = 0)))", listDivisionApply);
                    }
                }
            }
            base.SelectSqlData(this.dsDamageN.vJ_Damage, true, str + " order by dateDoc desc", null, false, 0);
            this.dgvDamage.SearchGrid(this.idDataGridViewTextBoxColumn.Name, idDamage.ToString(), true);
        }

        private void method_7()
        {
            DataTable table = new DataTable("tUser");
            table.Columns.Add("idUser", typeof(int));
            base.SelectSqlData(table, true, " left join vworkergroup w on w.id = tuser.idWorker\r\n                                where w.ParentKey = ';GroupWorker;DailyReport;Admin;' and tuser.login = SYSTEM_USER", null, false, 0);
            if (table.Rows.Count > 0)
            {
                this.toolBtnDamageNoApply.Visible = true;
            }
            else
            {
                this.toolBtnDamageNoApply.Visible = false;
            }
        }

        private void method_8()
        {
            this.splitContainerDgv.SplitterDistance = (this.splitContainerDgv.Height - this.splitContainerDgv.SplitterWidth) - this.lbLinkDoc.Height;
            this.splitContainerDgv.IsSplitterFixed = true;
        }

        private void method_9()
        {
            if ((this.bindingSource_0.Current != null) && (this.bindingSource_0.Current is DataRowView))
            {
                this.dtLinkDocs.Clear();
                Convert.ToInt32(((DataRowView) this.bindingSource_0.Current).Row["id"]);
                try
                {
                    using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                    {
                        connection.Open();
                        if (((DataRowView) this.bindingSource_0.Current).Row["idParent"] != DBNull.Value)
                        {
                            using (SqlCommand command = new SqlCommand())
                            {
                                command.CommandText = " select id, typeDoc, typedocName, \r\n                                                      numRequest as numDoc, dateDoc, idReqForRepair, (1) as isParent\r\n                                                    from vj_damage \r\n                                                    where id = " + ((DataRowView) this.bindingSource_0.Current).Row["idParent"] + " and deleted = 0 ";
                                command.Connection = connection;
                                new SqlDataAdapter(command).Fill(this.dtLinkDocs);
                            }
                        }
                        if ((this.dtLinkDocs.Rows.Count > 0) && (this.dtLinkDocs.Rows[0]["idReqForRepair"] != DBNull.Value))
                        {
                            using (SqlCommand command2 = new SqlCommand())
                            {
                                command2.CommandText = " select id, -1 as typeDoc, 'Аварийная заявка' as typedocName, \r\n                                                      num as numDoc, datecreate as dateDoc, null as idReqForRepair, (1) as isParent\r\n                                                    from tJ_RequestForRepair \r\n                                                    where id = " + this.dtLinkDocs.Rows[0]["idReqForRepair"].ToString() + " and deleted = 0 ";
                                command2.Connection = connection;
                                new SqlDataAdapter(command2).Fill(this.dtLinkDocs);
                            }
                        }
                        if (((DataRowView) this.bindingSource_0.Current).Row["idReqForRepair"] != DBNull.Value)
                        {
                            using (SqlCommand command3 = new SqlCommand())
                            {
                                command3.CommandText = " select id, -1 as typeDoc, 'Аварийная заявка' as typedocName, \r\n                                                      num as numDoc, datecreate as dateDoc, null as idReqForRepair, (1) as isParent\r\n                                                    from tJ_RequestForRepair \r\n                                                    where id = " + ((DataRowView) this.bindingSource_0.Current).Row["idReqForRepair"] + " and deleted = 0 ";
                                command3.Connection = connection;
                                new SqlDataAdapter(command3).Fill(this.dtLinkDocs);
                            }
                        }
                        using (SqlCommand command4 = new SqlCommand())
                        {
                            command4.CommandText = " select id, typeDoc, typedocName, \r\n                                                      numRequest as numDoc, dateDoc\r\n                                                    from vj_damage \r\n                                                    where idParent = " + ((DataRowView) this.bindingSource_0.Current).Row["id"] + " and deleted = 0 ";
                            command4.Connection = connection;
                            new SqlDataAdapter(command4).Fill(this.dtLinkDocs);
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source);
                }
            }
            else
            {
                this.dtLinkDocs.Clear();
            }
        }

        private void toolBtnFilterApply_Click(object sender, EventArgs e)
        {
            this.SearchIdDamage(-1);
        }

        private void toolBtnFilterDelete_Click(object sender, EventArgs e)
        {
            this.method_0();
            this.dgvDamage.ClearFilter();
            this.SearchIdDamage(-1);
        }

        private void toolBtnRefresh_Click(object sender, EventArgs e)
        {
            this.SearchIdDamage(-1);
        }

        private void toolBtnFind_Click(object sender, EventArgs e)
        {
            this.dgvDamage.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.txtFind.Text);
        }

        private void toolBtnFindPrev_Click(object sender, EventArgs e)
        {
            this.dgvDamage.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
        }

        private void toolBtnFindNext_Click(object sender, EventArgs e)
        {
            this.dgvDamage.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
        }

        private void toolBtnDamageNoApply_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                if (((this.dgvDamage.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != DBNull.Value) && (this.dgvDamage.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != null)) && Convert.ToBoolean(this.dgvDamage.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value))
                {
                    if (MessageBox.Show("Вы действительно хотите разблокировать текущий документ?", "Разблокировка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int num = Convert.ToInt32(this.dgvDamage.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
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
                                        this.SearchIdDamage(-1);
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
            this.dgvDamage.ExportToExcel();
        }

        private void toolBtnPrint_Click(object sender, EventArgs e)
        {
            this.dgvDamage.PrintDataGridView();
        }

        private void toolBtnSettingMail_Click(object sender, EventArgs e)
        {
            FormDamageSettingMail form1 = new FormDamageSettingMail();
            form1.SqlSettings=(this.SqlSettings);
            form1.MdiParent = base.MdiParent;
            form1.Show();
        }

        private void toolBtnPrevYear_Click(object sender, EventArgs e)
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

        private void toolMenuItemReportDailyLV_Click(object sender, EventArgs e)
        {
            FormReportDailyLV form1 = new FormReportDailyLV();
            form1.SqlSettings=(this.SqlSettings);
            form1.MdiParent = base.MdiParent;
            form1.Show();
        }

        private void toolBtnLoadOldDamageLV_Click(object sender, EventArgs e)
        {
            LoadOldDamageLV.Load(this.SqlSettings, new SQLSettings("ulges-sql", "SR4", "WINDOWS", "", ""));
            this.SearchIdDamage(-1);
        }

        private void toolItemInfo_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                DataRow row = ((DataRowView) this.bindingSource_0.Current).Row;
                this.OpenDocument(Convert.ToInt32(row["TypeDoc"]), Convert.ToInt32(row["id"]), true);
            }
        }

        private void toolItemDel_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                if (((this.dgvDamage.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != DBNull.Value) && (this.dgvDamage.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value != null)) && Convert.ToBoolean(this.dgvDamage.CurrentRow.Cells[this.isApplyDgvColumn.Name].Value))
                {
                    MessageBox.Show("Невозможно удалить исполненный документ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (((Convert.ToInt32(this.dgvDamage.CurrentRow.Cells[this.typeDocDgvColumn.Name].Value) == 0x57b) || (Convert.ToInt32(this.dgvDamage.CurrentRow.Cells[this.typeDocDgvColumn.Name].Value) == 0x734)) && ((this.dgvDamage.CurrentRow.Cells[this.idParentDgvColumn.Name].Value != DBNull.Value) && (this.dgvDamage.CurrentRow.Cells[this.idParentDgvColumn.Name].Value != null)))
                {
                    DataTable table = new DataTable("VJ_Damage");
                    table.Columns.Add("Division", typeof(string));
                    base.SelectSqlData(table, true, " where id = " + this.dgvDamage.CurrentRow.Cells[this.idParentDgvColumn.Name].Value.ToString(), null, false, 0);
                    string str = "";
                    if ((table.Rows.Count > 0) && (table.Rows[0]["Division"] != DBNull.Value))
                    {
                        str = table.Rows[0]["division"].ToString();
                    }
                    MessageBox.Show("Для удаления данного документа обратитесь в службу " + str, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (MessageBox.Show("Вы действительно хотите удалить выбранный документ и подчиненные данному документу?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int num = Convert.ToInt32(this.dgvDamage.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
                    if (base.DeleteSqlDataById(this.dsDamageN.tJ_Damage, num))
                    {
                        this.method_5(num);
                        this.SearchIdDamage(-1);
                        MessageBox.Show("Документ успешно удален");
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбран документ для удаления");
            }
        }

        /// <summary>
        /// заполняем акт расследования обрудованием
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolItemActDetectionAdd_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                DataRow row = ((DataRowView) this.bindingSource_0.Current).Row;
                if (Convert.ToInt32(row["TypeDoc"]) == 1402)
                {
                    int idParentDocument = Convert.ToInt32(row["id"]);
                    FormChooseDamageCharacter form = new FormChooseDamageCharacter(new int?(idParentDocument), null, null);
                    form.SqlSettings = (this.SqlSettings);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        JournalActDetection.FormActDetectionAddEdit form1 = new JournalActDetection.FormActDetectionAddEdit(new int?(idParentDocument), form.getListDamage().ToList<int>());
                        form1.SqlSettings = (this.SqlSettings);
                        form1.MdiParent = base.MdiParent;
                        form1.Show();
                    }
                }
            }
        }

        private void tsMenuAmergencyShutdown_Click(object sender, EventArgs e)
        {
            Documents.Reports.FormReportDetectionCrash crash1 = new Documents.Reports.FormReportDetectionCrash();
            crash1.SqlSettings=(this.SqlSettings);
            crash1.MdiParent = base.MdiParent;
            crash1.Show();
        }

        private void toolBtnLoadOldDamageLVMySQL_Click(object sender, EventArgs e)
        {
            ImportDataSESNO.ImportDailyReport(this.SqlSettings);
            this.SearchIdDamage(-1);
        }

        private void toolMenuItemSheetInterruptLV_Click(object sender, EventArgs e)
        {
            FormReportInterruptLV form1 = new FormReportInterruptLV();
            form1.SqlSettings=(this.SqlSettings);
            form1.MdiParent = base.MdiParent;
            form1.Show();
        }

        private void toolMenuItemReportDailyDefect_Click(object sender, EventArgs e)
        {
            FormReportDailyDefect form1 = new FormReportDailyDefect();
            form1.SqlSettings=(this.SqlSettings);
            form1.MdiParent = base.MdiParent;
            form1.Show();
        }

        private void toolBtnLoadOldDefect_Click(object sender, EventArgs e)
        {
            ImportOldDefectExcel.Load(this.SqlSettings);
            this.SearchIdDamage(-1);
        }

        private void toolMenuItemReportDailyHV_Click(object sender, EventArgs e)
        {
            FormReportDailyHV form1 = new FormReportDailyHV();
            form1.SqlSettings=(this.SqlSettings);
            form1.MdiParent = base.MdiParent;
            form1.Show();
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
                            foreach (DataRow row in dataTable.Rows)
                                {
                                //Class327 class2 = new Class327
                                //{
                                //    dataRow_0 = (DataRow)enumerator.Current
                                //};

                                if (row["dateDoc"] != DBNull.Value)
                                    {
                                        ElectricModel model = new ElectricModel();
                                        model.SqlSettings=(this.SqlSettings);
                                        model.LoadSchema(Convert.ToDateTime(row["dateDoc"]));
                                        model.PoweringReportForDrawObject(Convert.ToInt32(row["idSchmObj"]), true);
                                        //IEnumerable<ElectricObject> source = model.Objects.Where(new Func<ElectricObject, bool>(class2.method_0));
                                        IEnumerable<ElectricObject> source = model.Objects.Where((ElectricObject r)=>r.Id == Convert.ToInt32(row["idSchmObj"]));

                                    if (source.Count() > 0)
                                        {
                                            List<ElectricObject> list = model.PoweringReportForDrawObject(source.First(), true, true);
                                            DataSet ds = new DataSet();
                                            DataTable table = new DataTable("vL_SchmAbnFull");
                                            table.Columns.Add("idAbn", typeof(int));
                                            table.Columns.Add("idAbnObj", typeof(int));
                                            ds.Tables.Add(table);
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
                                            base.SelectSqlData(table3, true, "where iddamage = " + row["id"].ToString(), null, false, 0);
                                            if (table3.Rows.Count == 0)
                                            {
                                                DataRow row1 = table3.NewRow();
                                                row1["idDamage"] = row["id"];
                                                row1["abnOff"] = CreateReferenceTables.CreateXmlAbnOff(table).InnerXml;
                                                table3.Rows.Add(row1);
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
                           // }
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

        private void toolBtnEdit_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                DataRow row = ((DataRowView) this.bindingSource_0.Current).Row;
                this.OpenDocument(Convert.ToInt32(row["TypeDoc"]), Convert.ToInt32(row["id"]), false);
            }
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
                    this.dgvDamage.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
                }
                if (e.Modifiers == Keys.Shift)
                {
                    this.dgvDamage.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
                }
            }
        }

        //[CompilerGenerated]
        //private sealed class Class327
        //{
        //    public DataRow dataRow_0;

        //    internal bool method_0(ElectricObject electricObject_0)
        //    {
        //        return (electricObject_0.Id == Convert.ToInt32(this.dataRow_0["idSchmObj"]));
        //    }
        //}

        private struct Struct10
        {
            internal int id;
            internal string name;
            internal Struct10(int a, string b)
            {
                this.id = a;
                this.name = b;
            }

            public override string ToString()
            {
                return this.name;
            }
        }
    }
}

