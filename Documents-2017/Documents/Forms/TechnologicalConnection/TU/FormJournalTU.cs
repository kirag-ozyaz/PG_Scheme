namespace Documents.Forms.TechnologicalConnection.TU
{
    using ControlsLbr.DataGridViewExcelFilter;
    using DataSql;
    using Documents.Forms.Memorandums;
    using Documents.Forms.TechnologicalConnection;
    using Documents.Forms.TechnologicalConnection.Acts;
    using Documents.Forms.TechnologicalConnection.ActTC;
    using Documents.Forms.TechnologicalConnection.RBP;
    using Documents.Properties;
    using FormLbr;
    using FormLbr.Classes;
    using Microsoft.Office.Interop.Excel;
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
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;
    using System.Xml;

    public class FormJournalTU : FormBase
    {
        private BackgroundWorker backgroundWorker_0;
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private BindingSource bindingSource_3;
        private BindingSource bindingSource_4;
        private BindingSource bindingSource_5;
        private BindingSource bindingSource_6;
        private BindingSource bindingSource_7;
        private BindingSource bindingSource_8;
        private BindingSource bindingSource_9;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_2;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_3;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_4;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_5;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_6;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_7;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_8;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_9;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_11;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_12;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_13;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_14;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_15;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_16;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_17;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_18;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_19;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_20;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_21;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_22;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_23;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_24;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_25;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_26;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_27;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_28;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_29;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_30;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_31;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_32;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_33;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_1;
        private DataGridViewLinkColumn dataGridViewLinkColumn_0;
        private DataGridViewLinkColumn dataGridViewLinkColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_100;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_101;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_102;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_103;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_104;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_105;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_106;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_107;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_108;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_109;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_110;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_111;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_112;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_113;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_114;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_115;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_116;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_117;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_118;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_119;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_120;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_121;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_122;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_123;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_124;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_125;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_126;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_127;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_128;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_129;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_130;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_131;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_132;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_133;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_134;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_135;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_136;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_137;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_138;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_139;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_140;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_141;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_142;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_143;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_144;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_145;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_146;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_147;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_148;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_149;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_150;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_64;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_65;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_66;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_67;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_68;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_69;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_70;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_71;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_72;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_73;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_74;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_75;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_76;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_77;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_78;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_79;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_80;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_81;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_82;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_83;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_84;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_85;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_86;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_87;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_88;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_89;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_90;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_91;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_92;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_93;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_94;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_95;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_96;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_97;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_98;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_99;
        private DataSet dataSet_0;
        private DataSetTechConnection dataSetTechConnection_0;
        private DataSetTechConnection dataSetTechConnection_1;
        private DataTable dataTable_0;
        private DataTable dataTable_1;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private DateTimePicker dateTimePicker_2;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private int int_4;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private List<int> list_0;
        private RichTextBox richTextBox_0;
        private SplitContainer splitContainer_0;
        private SplitContainer splitContainer_1;
        private SplitContainer splitContainer_2;
        private SplitContainer splitContainer_3;
        private SplitContainer splitContainer_4;
        private TabControl tabControl_0;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private TabPage tabPage_2;
        private TabPage tabPage_3;
        private TabPage tabPage_4;
        private TabPage tabPage_5;
        private TabPage tabPage_6;
        private TextBox textBox_0;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStrip toolStrip_2;
        private ToolStrip toolStrip_3;
        private ToolStrip toolStrip_4;
        private ToolStrip toolStrip_5;
        private ToolStrip toolStrip_6;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_10;
        private ToolStripButton toolStripButton_11;
        private ToolStripButton toolStripButton_12;
        private ToolStripButton toolStripButton_13;
        private ToolStripButton toolStripButton_14;
        private ToolStripButton toolStripButton_15;
        private ToolStripButton toolStripButton_16;
        private ToolStripButton toolStripButton_17;
        private ToolStripButton toolStripButton_18;
        private ToolStripButton toolStripButton_19;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_20;
        private ToolStripButton toolStripButton_21;
        private ToolStripButton toolStripButton_22;
        private ToolStripButton toolStripButton_23;
        private ToolStripButton toolStripButton_24;
        private ToolStripButton toolStripButton_25;
        private ToolStripButton toolStripButton_26;
        private ToolStripButton toolStripButton_27;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;
        private ToolStripButton toolStripButton_7;
        private ToolStripButton toolStripButton_8;
        private ToolStripButton toolStripButton_9;
        private ToolStripDropDownButton toolStripDropDownButton_0;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripMenuItem toolStripMenuItem_1;
        private ToolStripMenuItem toolStripMenuItem_2;
        private ToolStripMenuItem toolStripMenuItem_3;
        private ToolStripMenuItem toolStripMenuItem_4;
        private ToolStripMenuItem toolStripMenuItem_5;
        private ToolStripMenuItem toolStripMenuItem_6;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripSeparator toolStripSeparator_3;
        private ToolStripSeparator toolStripSeparator_4;
        private ToolStripSeparator toolStripSeparator_5;
        private ToolStripSplitButton toolStripSplitButton_0;
        private ToolStripTextBox toolStripTextBox_0;
        private TreeView treeView_0;

        public FormJournalTU()
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.method_19();
            this.method_3();
        }

        public FormJournalTU(List<int> checkedSubstation)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.method_19();
            this.method_3();
            this.list_0 = checkedSubstation;
        }

        public FormJournalTU(int idTU)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.method_19();
            this.method_3();
            this.int_0 = idTU;
        }

        protected override void ApplyConfig(XmlDocument xmlDocument_0)
        {
            XmlNode node = xmlDocument_0.SelectSingleNode(base.Name);
            if (node != null)
            {
                XmlAttribute attribute = node.Attributes["FilterDateBeg"];
                if (attribute != null)
                {
                    this.dateTimePicker_1.Value = Convert.ToDateTime(attribute.Value);
                }
                attribute = node.Attributes["FilterDateEnd"];
                if (attribute != null)
                {
                    this.dateTimePicker_0.Value = Convert.ToDateTime(attribute.Value);
                }
            }
        }

        private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.toolStripButton_25.Enabled = true;
        }

        private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
        {
            this.int_2 = -1;
            this.toolStripButton_17.Enabled = true;
            this.toolStripButton_18.Enabled = false;
            this.toolStripButton_19.Enabled = false;
            if (this.bindingSource_0.Current != null)
            {
                this.int_0 = Convert.ToInt32(((DataRowView) this.bindingSource_0.Current).Row["id"]);
                if (((DataRowView) this.bindingSource_0.Current).Row["idRequest"] != DBNull.Value)
                {
                    this.int_1 = Convert.ToInt32(((DataRowView) this.bindingSource_0.Current).Row["idRequest"]);
                }
                else
                {
                    this.int_1 = -1;
                }
                this.method_4();
                if (this.int_1 == -1)
                {
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_DocOut, true, " where (idDoc = " + this.int_0.ToString() + ")  order by dateDocOut desc");
                }
                else
                {
                    string[] textArray1 = new string[] { " where (idDoc = ", this.int_0.ToString(), ") or  (idDoc = ", this.int_1.ToString(), " and TypeDocOut = ", 0x4c2.ToString(), ") order by dateDocOut desc" };
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_DocOut, true, string.Concat(textArray1));
                }
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_TUTypeWork, true, " where idTU = " + this.int_0.ToString());
                if (((DataRowView) this.bindingSource_0.Current).Row["idContractor"] != DBNull.Value)
                {
                    this.int_2 = Convert.ToInt32(((DataRowView) this.bindingSource_0.Current).Row["idContractor"]);
                    base.SelectSqlData(this.dataSetTechConnection_1, this.dataSetTechConnection_1.tTC_Doc, true, " where id = " + this.int_2.ToString());
                    this.toolStripButton_17.Enabled = false;
                    this.toolStripButton_18.Enabled = true;
                    this.toolStripButton_19.Enabled = true;
                }
                else
                {
                    this.dataSetTechConnection_1.tTC_Doc.Clear();
                }
                this.method_6();
                this.method_14(false);
            }
            else
            {
                this.int_0 = -1;
                this.int_1 = -1;
                this.dataSetTechConnection_0.tTC_DocFile.Clear();
                this.dataSetTechConnection_0.vTC_DocOut.Clear();
                this.dataSetTechConnection_0.tTC_TUTypeWork.Clear();
                this.dataSetTechConnection_1.tTC_Doc.Clear();
                this.dataSetTechConnection_0.vTC_Doc.Clear();
                this.dataSetTechConnection_0.tJ_Memorandum.Clear();
            }
            if (this.int_1 == -1)
            {
                this.dataSetTechConnection_0.vTC_RequestHistory.Clear();
            }
            else
            {
                DataSetTechConnection.tTC_DocDataTable table = new DataSetTechConnection.tTC_DocDataTable();
                base.SelectSqlData(table, true, " where id = " + this.int_1.ToString(), false);
                int num2 = this.int_1;
                if ((table.Rows.Count > 0) && (table.Rows[0]["idParent"] != DBNull.Value))
                {
                    num2 = Convert.ToInt32(table.Rows[0]["idParent"]);
                }
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_RequestHistory, true, "where id = " + num2.ToString() + " or IdParent = " + num2.ToString() + " order by dateDoc");
            }
        }

        private void bindingSource_3_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource_3.Current != null)
            {
                this.int_3 = Convert.ToInt32(((DataRowView) this.bindingSource_3.Current)["idDocOut"]);
                this.int_4 = Convert.ToInt32(((DataRowView) this.bindingSource_3.Current)["idDoc"]);
                this.method_5();
            }
            else
            {
                this.int_3 = -1;
                this.int_4 = -1;
                this.bindingSource_4.DataSource = null;
            }
        }

        private void bindingSource_7_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource_7.Current != null)
            {
                int num = Convert.ToInt32(((DataRowView) this.bindingSource_7.Current)["id"]);
                int num2 = Convert.ToInt32(((DataRowView) this.bindingSource_7.Current)["TypeDoc"]);
                if ((num2 != 0x1f1) && (num2 != 0x4de))
                {
                    this.bindingSource_8.DataSource = this.dataTable_0;
                    base.SelectSqlData(this.dataTable_0, true, " where idDoc = " + num.ToString() + " order by filename", false);
                }
                else
                {
                    this.bindingSource_8.DataSource = this.dataTable_1;
                    base.SelectSqlData(this.dataTable_1, true, " where idList = " + num.ToString() + " order by filename", false);
                }
            }
            else
            {
                this.dataTable_0.Clear();
            }
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document1 = new XmlDocument();
            XmlNode newChild = document1.CreateXmlDeclaration("1.0", "UTF-8", null);
            document1.AppendChild(newChild);
            XmlNode node2 = document1.CreateElement(base.Name);
            document1.AppendChild(node2);
            XmlAttribute node = document1.CreateAttribute("FilterDateBeg");
            node.Value = this.dateTimePicker_1.Value.ToString();
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("FilterDateEnd");
            node.Value = this.dateTimePicker_0.Value.ToString();
            node2.Attributes.Append(node);
            return document1;
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (this.toolStripButton_1.Enabled && this.toolStripButton_1.Visible))
            {
                this.toolStripButton_1_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_29.Name, e.RowIndex].Value != null) && (this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_29.Name, e.RowIndex].Value != DBNull.Value))
                {
                    e.CellStyle.BackColor = Color.LightGray;
                }
                if (((this.dataGridViewExcelFilter_0[this.dataGridViewCheckBoxColumn_0.Name, e.RowIndex].Value != null) && (this.dataGridViewExcelFilter_0[this.dataGridViewCheckBoxColumn_0.Name, e.RowIndex].Value != DBNull.Value)) && Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewCheckBoxColumn_0.Name, e.RowIndex].Value))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void dataGridViewExcelFilter_0_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ((DataGridView) sender).AutoResizeRow(e.RowIndex);
        }

        private void dataGridViewExcelFilter_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewExcelFilter_1.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
                if (e.ColumnIndex == this.dataGridViewExcelFilter_1.Columns[this.dataGridViewLinkColumn_0.Name].Index)
                {
                    DataTable table = new SqlDataCommand(this.get_SqlSettings()).SelectSqlData("select [FileName], [File] from [tTC_DocFile] where id = " + num.ToString());
                    if (table.Rows.Count > 0)
                    {
                        byte[] buffer = (byte[]) table.Rows[0]["File"];
                        string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(table.Rows[0]["FileName"].ToString()));
                        FileStream stream1 = File.Create(path);
                        stream1.Write(buffer, 0, buffer.Length);
                        stream1.Close();
                        try
                        {
                            new Process { StartInfo = { 
                                FileName = path,
                                UseShellExecute = true
                            } }.Start();
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, exception.Source);
                        }
                    }
                }
            }
        }

        private void dataGridViewExcelFilter_1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if ((((DataGridView) sender).RowCount > 0) && (this.dataGridViewExcelFilter_1[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value != null))
            {
                if (e.ColumnIndex == this.dataGridViewExcelFilter_1.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index)
                {
                    if (!string.IsNullOrEmpty(Path.GetFileName(this.dataGridViewExcelFilter_1[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value.ToString())))
                    {
                        e.Value = Path.GetFileName(this.dataGridViewExcelFilter_1[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value.ToString());
                    }
                    else
                    {
                        e.Value = this.dataGridViewExcelFilter_1[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value.ToString();
                    }
                }
                if (e.ColumnIndex == this.dataGridViewExcelFilter_1.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index)
                {
                    Icon icon = FileInfo.IconOfFile(this.dataGridViewExcelFilter_1[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value.ToString());
                    if (icon != null)
                    {
                        e.Value = icon.ToBitmap();
                    }
                }
            }
        }

        private void dataGridViewExcelFilter_2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.RowIndex >= 0) && (Convert.ToInt32(this.dataGridViewExcelFilter_2[this.dataGridViewTextBoxColumn_8.Name, e.RowIndex].Value) == 0x459))
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.BackColor = Color.LightGray;
            }
        }

        private void dataGridViewExcelFilter_2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewExcelFilter_2.AutoResizeRow(e.RowIndex);
        }

        private void dataGridViewExcelFilter_3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.RowIndex >= 0) && (Convert.ToInt32(this.dataGridViewExcelFilter_3[this.dataGridViewTextBoxColumn_25.Name, e.RowIndex].Value) != this.int_0))
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
        }

        private void dataGridViewExcelFilter_6_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ((DataGridView) sender).AutoResizeRow(e.RowIndex);
        }

        private void dataGridViewExcelFilter_7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView) sender;
            if (view.CurrentRow != null)
            {
                int num = Convert.ToInt32(view.CurrentRow.Cells[this.dataGridViewTextBoxColumn_45.Name].Value);
                if (e.ColumnIndex == view.Columns[this.dataGridViewLinkColumn_1.Name].Index)
                {
                    SqlDataCommand command = new SqlDataCommand(this.get_SqlSettings());
                    DataTable table = new DataTable();
                    if (this.bindingSource_8.DataSource == this.dataTable_0)
                    {
                        table = command.SelectSqlData("select [FileName], [File] from [tTC_DocFile] where id = " + num.ToString());
                    }
                    if (this.bindingSource_8.DataSource == this.dataTable_1)
                    {
                        table = command.SelectSqlData("select [FileName], [File] from [tAbnObjDoc_File] where id = " + num.ToString());
                    }
                    if (table.Rows.Count > 0)
                    {
                        byte[] buffer = (byte[]) table.Rows[0]["File"];
                        string path = Path.ChangeExtension(Path.GetTempFileName(), Path.GetExtension(table.Rows[0]["FileName"].ToString()));
                        FileStream stream1 = File.Create(path);
                        stream1.Write(buffer, 0, buffer.Length);
                        stream1.Close();
                        try
                        {
                            new Process { StartInfo = { 
                                FileName = path,
                                UseShellExecute = true
                            } }.Start();
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, exception.Source);
                        }
                    }
                }
            }
        }

        private void dataGridViewExcelFilter_7_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            DataGridView view = (DataGridView) sender;
            if (((view.RowCount > 0) && (view[this.dataGridViewLinkColumn_1.Name, e.RowIndex].Value != null)) && (e.ColumnIndex == view.Columns[this.dataGridViewImageColumnNotNull_1.Name].Index))
            {
                Icon icon = FileInfo.IconOfFile(view[this.dataGridViewLinkColumn_1.Name, e.RowIndex].Value.ToString());
                if (icon != null)
                {
                    e.Value = icon.ToBitmap();
                }
            }
        }

        private void dataGridViewExcelFilter_8_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (this.toolStripButton_21.Enabled && this.toolStripButton_21.Visible))
            {
                this.toolStripButton_21_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_9_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            {
                this.method_15();
            }
        }

        private void dataGridViewExcelFilter_9_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormJournalTU_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormJournalTU_Load(object sender, EventArgs e)
        {
            this.toolStripButton_16.Visible = false;
            base.LoadFormConfig(null);
            this.method_17();
            int num = -1;
            if (this.int_0 > 0)
            {
                DataSetTechConnection.tTC_DocDataTable table = new DataSetTechConnection.tTC_DocDataTable();
                base.SelectSqlData(table, true, " where id = " + this.int_0.ToString(), false);
                if (table.Rows.Count > 0)
                {
                    if (table.Rows[0]["DateDoc"] != DBNull.Value)
                    {
                        DateTime time = Convert.ToDateTime(table.Rows[0]["DateDoc"]);
                        this.dateTimePicker_1.Value = new DateTime(time.Year, 1, 1);
                        this.dateTimePicker_0.Value = new DateTime(time.Year, 12, 0x1f);
                    }
                    num = this.int_1;
                }
            }
            this.method_0();
            if (num != -1)
            {
                this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_140.Name, num.ToString(), false);
                if (this.dataGridViewExcelFilter_0.CurrentRow != null)
                {
                    this.dataGridViewExcelFilter_0.FirstDisplayedScrollingRowIndex = this.dataGridViewExcelFilter_0.CurrentRow.Index;
                }
            }
        }

        private void method_0()
        {
            int num = this.int_0;
            List<int> list = this.method_18(this.treeView_0.Nodes);
            string str = string.Format(" where DateDoc >= '{0}' and DateDoc <= '{1}'", this.dateTimePicker_1.Value.ToString("yyyyMMdd"), this.dateTimePicker_0.Value.ToString("yyyyMMdd"));
            if ((list != null) && (list.Count > 0))
            {
                string str2 = "";
                foreach (int num2 in list)
                {
                    if (string.IsNullOrEmpty(str2))
                    {
                        str2 = num2.ToString();
                    }
                    else
                    {
                        str2 = str2 + "," + num2.ToString();
                    }
                }
                str = str + string.Format(" and id in (select idTU from ttc_tuPointAttach where idSubPoint in ({0}) and (typeDoc is null or typeDoc = {1})) ", str2, 0x463);
            }
            str = str + " ORDER BY CONVERT(BIGINT, CASE WHEN numdoc like '%[^0-9]%' THEN SUBSTRING(numdoc,1,PATINDEX('%[^0-9]%',numdoc)-1) ELSE numdoc END) desc";
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_TU, true, str);
            if (num > 0)
            {
                this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_140.Name, num.ToString(), false);
            }
        }

        private void method_1(object sender, FormClosedEventArgs e)
        {
            this.int_0 = ((FormTUAddEdit) sender).IdTU;
            this.method_0();
        }

        private int method_10(string string_0)
        {
            DataTable table = base.SelectSqlData("tR_Worker", true, "WHERE F + ' ' + I + ' ' + O LIKE '" + string_0 + "'");
            if (table.Rows.Count > 0)
            {
                return (int) table.Rows[0]["ID"];
            }
            return -1;
        }

        private void method_11(object sender, FormClosedEventArgs e)
        {
            if (sender is FormMemorandumJournal)
            {
                this.method_14(false);
            }
            if (sender is Form27)
            {
                this.method_13(((Form27) sender).method_4());
            }
        }

        private void method_12()
        {
            if ((this.bindingSource_9.Current != null) && (MessageBox.Show("Вы действительно хотите удалить текущую запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                EnumerableRowCollection<DataSetTechConnection.Class271> source = this.dataSetTechConnection_0.tJ_Memorandum.Where<DataSetTechConnection.Class271>(new Func<DataSetTechConnection.Class271, bool>(this.method_20));
                if (source.Count<DataSetTechConnection.Class271>() > 0)
                {
                    source.First<DataSetTechConnection.Class271>().Deleted = true;
                    if (base.UpdateSqlData(this.dataSetTechConnection_0.tJ_Memorandum))
                    {
                        this.dataSetTechConnection_0.tJ_Memorandum.AcceptChanges();
                        MessageBox.Show("Запись успешно удалена.");
                        this.method_14(false);
                    }
                }
            }
        }

        private void method_13(int int_5)
        {
            this.method_14(false);
            this.bindingSource_9.Position = this.bindingSource_9.Find("id", int_5);
        }

        private void method_14(bool bool_0)
        {
            bool_0 = bool_0 ? (this.bindingSource_9.Current > null) : bool_0;
            int key = -1;
            if (bool_0)
            {
                key = (int) ((DataRowView) this.bindingSource_9.Current)["id"];
            }
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tJ_Memorandum, true, string.Format("WHERE idWorker = {0} AND idTehConnect = {1} AND Deleted = 0", this.method_8(), this.int_0));
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vJ_Memorandum, true, string.Format("WHERE idWorker = {0} AND idTehConnect = {1} AND Deleted = 0", this.method_8(), this.int_0));
            if (bool_0)
            {
                this.bindingSource_9.Position = this.bindingSource_9.Find("id", key);
            }
        }

        private void method_15()
        {
            if (this.bindingSource_9.Current != null)
            {
                Form27 form1 = new Form27();
                form1.set_SqlSettings(this.get_SqlSettings());
                form1.MdiParent = base.MdiParent;
                form1.method_1(this.int_0);
                form1.method_3(this.method_8());
                form1.method_5((int) ((DataRowView) this.bindingSource_9.Current)["id"]);
                form1.method_9(7);
                form1.FormClosed += new FormClosedEventHandler(this.method_11);
                form1.Show();
            }
        }

        private void method_16()
        {
            if (this.bindingSource_9.Current != null)
            {
                if ((((DataRowView) this.bindingSource_9.Current)["Status"].ToString() == "Отправлен") || (((DataRowView) this.bindingSource_9.Current)["Status"].ToString() == "Документ получен адресатом"))
                {
                    MessageBox.Show("Вы не можете править этот документ!", "Предупреждение.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Form27 form1 = new Form27();
                    form1.set_SqlSettings(this.get_SqlSettings());
                    form1.MdiParent = base.MdiParent;
                    form1.method_3(this.method_8());
                    form1.method_5((int) ((DataRowView) this.bindingSource_9.Current)["id"]);
                    form1.method_9(1);
                    form1.FormClosed += new FormClosedEventHandler(this.method_11);
                    form1.Show();
                }
            }
        }

        private void method_17()
        {
            this.treeView_0.Nodes.Clear();
            DataTable table = new DataTable("tr_Classifier");
            table.Columns.Add("id");
            table.Columns.Add("name");
            base.SelectSqlData(table, true, "where ParentKey = ';SCM;PS;' and isGroup = 0 and deleted = 0 order by name", false);
            foreach (DataRow row in table.Rows)
            {
                TreeNode node = new TreeNode(row["name"].ToString());
                DataSetTechConnection.vSchm_ObjListDataTable table2 = new DataSetTechConnection.vSchm_ObjListDataTable();
                base.SelectSqlData(table2, true, " where TypeCodeId = " + row["id"].ToString() + " and deleted = 0 order by name", false);
                foreach (DataRow row2 in table2.Rows)
                {
                    TreeNode node2 = new TreeNode(row2["TypeCode"].ToString() + "-" + row2["name"].ToString()) {
                        Tag = row2["id"]
                    };
                    node.Nodes.Add(node2);
                    if ((this.list_0 != null) && this.list_0.Contains(Convert.ToInt32(row2["id"])))
                    {
                        node2.Checked = true;
                        node.Expand();
                    }
                }
                if (node.Nodes.Count > 0)
                {
                    this.treeView_0.Nodes.Add(node);
                }
            }
        }

        private List<int> method_18(TreeNodeCollection treeNodeCollection_0)
        {
            List<int> list = new List<int>();
            if (treeNodeCollection_0 != null)
            {
                foreach (TreeNode node in treeNodeCollection_0)
                {
                    if (node.Checked && (node.Tag != null))
                    {
                        list.Add(Convert.ToInt32(node.Tag));
                    }
                    list.AddRange(this.method_18(node.Nodes));
                }
            }
            return list;
        }

        private void method_19()
        {
            this.icontainer_0 = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormJournalTU));
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
            DataGridViewCellStyle style18 = new DataGridViewCellStyle();
            DataGridViewCellStyle style19 = new DataGridViewCellStyle();
            DataGridViewCellStyle style20 = new DataGridViewCellStyle();
            DataGridViewCellStyle style21 = new DataGridViewCellStyle();
            DataGridViewCellStyle style22 = new DataGridViewCellStyle();
            DataGridViewCellStyle style23 = new DataGridViewCellStyle();
            DataGridViewCellStyle style24 = new DataGridViewCellStyle();
            DataGridViewCellStyle style25 = new DataGridViewCellStyle();
            DataGridViewCellStyle style26 = new DataGridViewCellStyle();
            DataGridViewCellStyle style27 = new DataGridViewCellStyle();
            DataGridViewCellStyle style28 = new DataGridViewCellStyle();
            DataGridViewCellStyle style29 = new DataGridViewCellStyle();
            DataGridViewCellStyle style30 = new DataGridViewCellStyle();
            DataGridViewCellStyle style31 = new DataGridViewCellStyle();
            DataGridViewCellStyle style32 = new DataGridViewCellStyle();
            DataGridViewCellStyle style33 = new DataGridViewCellStyle();
            DataGridViewCellStyle style34 = new DataGridViewCellStyle();
            DataGridViewCellStyle style35 = new DataGridViewCellStyle();
            DataGridViewCellStyle style36 = new DataGridViewCellStyle();
            DataGridViewCellStyle style37 = new DataGridViewCellStyle();
            DataGridViewCellStyle style38 = new DataGridViewCellStyle();
            DataGridViewCellStyle style39 = new DataGridViewCellStyle();
            DataGridViewCellStyle style40 = new DataGridViewCellStyle();
            DataGridViewCellStyle style41 = new DataGridViewCellStyle();
            DataGridViewCellStyle style42 = new DataGridViewCellStyle();
            DataGridViewCellStyle style43 = new DataGridViewCellStyle();
            DataGridViewCellStyle style44 = new DataGridViewCellStyle();
            DataGridViewCellStyle style45 = new DataGridViewCellStyle();
            DataGridViewCellStyle style46 = new DataGridViewCellStyle();
            DataGridViewCellStyle style47 = new DataGridViewCellStyle();
            DataGridViewCellStyle style48 = new DataGridViewCellStyle();
            DataGridViewCellStyle style49 = new DataGridViewCellStyle();
            DataGridViewCellStyle style50 = new DataGridViewCellStyle();
            DataGridViewCellStyle style51 = new DataGridViewCellStyle();
            DataGridViewCellStyle style52 = new DataGridViewCellStyle();
            DataGridViewCellStyle style53 = new DataGridViewCellStyle();
            DataGridViewCellStyle style54 = new DataGridViewCellStyle();
            DataGridViewCellStyle style55 = new DataGridViewCellStyle();
            DataGridViewCellStyle style56 = new DataGridViewCellStyle();
            DataGridViewCellStyle style57 = new DataGridViewCellStyle();
            DataGridViewCellStyle style58 = new DataGridViewCellStyle();
            DataGridViewCellStyle style59 = new DataGridViewCellStyle();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripButton_9 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripButton_6 = new ToolStripButton();
            this.toolStripButton_16 = new ToolStripButton();
            this.toolStripSeparator_3 = new ToolStripSeparator();
            this.toolStripButton_20 = new ToolStripButton();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetTechConnection_0 = new DataSetTechConnection();
            this.splitContainer_0 = new SplitContainer();
            this.treeView_0 = new TreeView();
            this.label_5 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_0 = new Label();
            this.dateTimePicker_1 = new DateTimePicker();
            this.label_1 = new Label();
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_7 = new ToolStripButton();
            this.toolStripButton_8 = new ToolStripButton();
            this.splitContainer_1 = new SplitContainer();
            this.tabControl_0 = new TabControl();
            this.tabPage_0 = new TabPage();
            this.dataGridViewExcelFilter_1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.tabPage_1 = new TabPage();
            this.dataGridViewExcelFilter_2 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
            this.bindingSource_2 = new BindingSource(this.icontainer_0);
            this.tabPage_3 = new TabPage();
            this.splitContainer_3 = new SplitContainer();
            this.dataGridViewExcelFilter_5 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
            this.bindingSource_5 = new BindingSource(this.icontainer_0);
            this.dataGridViewExcelFilter_6 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
            this.bindingSource_6 = new BindingSource(this.icontainer_0);
            this.tabPage_2 = new TabPage();
            this.splitContainer_2 = new SplitContainer();
            this.dataGridViewExcelFilter_3 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
            this.bindingSource_3 = new BindingSource(this.icontainer_0);
            this.toolStrip_2 = new ToolStrip();
            this.toolStripButton_12 = new ToolStripButton();
            this.toolStripButton_10 = new ToolStripButton();
            this.toolStripButton_11 = new ToolStripButton();
            this.dataGridViewExcelFilter_4 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_118 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_119 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_120 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_121 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_122 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_123 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_124 = new DataGridViewTextBoxColumn();
            this.bindingSource_4 = new BindingSource(this.icontainer_0);
            this.toolStrip_3 = new ToolStrip();
            this.toolStripButton_13 = new ToolStripButton();
            this.toolStripButton_14 = new ToolStripButton();
            this.toolStripButton_15 = new ToolStripButton();
            this.tabPage_4 = new TabPage();
            this.richTextBox_0 = new RichTextBox();
            this.dataSetTechConnection_1 = new DataSetTechConnection();
            this.label_2 = new Label();
            this.dateTimePicker_2 = new DateTimePicker();
            this.label_3 = new Label();
            this.textBox_0 = new TextBox();
            this.label_4 = new Label();
            this.toolStrip_4 = new ToolStrip();
            this.toolStripButton_17 = new ToolStripButton();
            this.toolStripButton_18 = new ToolStripButton();
            this.toolStripButton_19 = new ToolStripButton();
            this.tabPage_5 = new TabPage();
            this.splitContainer_4 = new SplitContainer();
            this.dataGridViewExcelFilter_8 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_111 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_112 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_113 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_114 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_115 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_116 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_117 = new DataGridViewTextBoxColumn();
            this.bindingSource_7 = new BindingSource(this.icontainer_0);
            this.toolStrip_5 = new ToolStrip();
            this.toolStripDropDownButton_0 = new ToolStripDropDownButton();
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.toolStripMenuItem_1 = new ToolStripMenuItem();
            this.toolStripMenuItem_2 = new ToolStripMenuItem();
            this.toolStripMenuItem_3 = new ToolStripMenuItem();
            this.toolStripMenuItem_4 = new ToolStripMenuItem();
            this.toolStripButton_21 = new ToolStripButton();
            this.toolStripButton_22 = new ToolStripButton();
            this.toolStripSeparator_4 = new ToolStripSeparator();
            this.toolStripButton_23 = new ToolStripButton();
            this.dataGridViewExcelFilter_7 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewLinkColumn_1 = new DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
            this.dataGridViewImageColumnNotNull_1 = new DataGridViewImageColumnNotNull();
            this.bindingSource_8 = new BindingSource(this.icontainer_0);
            this.dataSet_0 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataTable_1 = new DataTable();
            this.dataColumn_2 = new DataColumn();
            this.dataColumn_3 = new DataColumn();
            this.tabPage_6 = new TabPage();
            this.dataGridViewExcelFilter_9 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_125 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_126 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_127 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_128 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_129 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_130 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_131 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_132 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_133 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_134 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_135 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_136 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_137 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_138 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_139 = new DataGridViewTextBoxColumn();
            this.bindingSource_9 = new BindingSource(this.icontainer_0);
            this.toolStrip_6 = new ToolStrip();
            this.toolStripSplitButton_0 = new ToolStripSplitButton();
            this.toolStripMenuItem_5 = new ToolStripMenuItem();
            this.toolStripMenuItem_6 = new ToolStripMenuItem();
            this.toolStripButton_27 = new ToolStripButton();
            this.toolStripButton_26 = new ToolStripButton();
            this.toolStripButton_24 = new ToolStripButton();
            this.toolStripSeparator_5 = new ToolStripSeparator();
            this.toolStripButton_25 = new ToolStripButton();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_53 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_54 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_55 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_56 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_57 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_58 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_59 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_60 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_61 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_62 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_63 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_64 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_65 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_66 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_67 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_68 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_69 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_70 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_71 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_72 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_73 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_74 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_75 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_76 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_77 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_78 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_79 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_80 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_81 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_82 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_83 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_84 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_85 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_86 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_87 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_88 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_89 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_90 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_91 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_92 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_93 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_94 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_95 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_96 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_97 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_98 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_99 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_100 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_101 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_102 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_103 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_104 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_105 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_106 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_107 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_108 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_109 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_110 = new DataGridViewTextBoxColumn();
            this.backgroundWorker_0 = new BackgroundWorker();
            this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn_140 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_17 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_18 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_19 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_141 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_142 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_20 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_143 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_144 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_21 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_145 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_22 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_23 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_146 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_24 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_25 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_26 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_27 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_147 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_28 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_148 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_29 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_30 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_31 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_149 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_150 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_32 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_33 = new DataGridViewFilterTextBoxColumn();
            this.toolStrip_0.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetTechConnection_0.BeginInit();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.toolStrip_1.SuspendLayout();
            this.splitContainer_1.Panel1.SuspendLayout();
            this.splitContainer_1.Panel2.SuspendLayout();
            this.splitContainer_1.SuspendLayout();
            this.tabControl_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.dataGridViewExcelFilter_1.BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            this.tabPage_1.SuspendLayout();
            this.dataGridViewExcelFilter_2.BeginInit();
            ((ISupportInitialize) this.bindingSource_2).BeginInit();
            this.tabPage_3.SuspendLayout();
            this.splitContainer_3.Panel1.SuspendLayout();
            this.splitContainer_3.Panel2.SuspendLayout();
            this.splitContainer_3.SuspendLayout();
            this.dataGridViewExcelFilter_5.BeginInit();
            ((ISupportInitialize) this.bindingSource_5).BeginInit();
            this.dataGridViewExcelFilter_6.BeginInit();
            ((ISupportInitialize) this.bindingSource_6).BeginInit();
            this.tabPage_2.SuspendLayout();
            this.splitContainer_2.Panel1.SuspendLayout();
            this.splitContainer_2.Panel2.SuspendLayout();
            this.splitContainer_2.SuspendLayout();
            this.dataGridViewExcelFilter_3.BeginInit();
            ((ISupportInitialize) this.bindingSource_3).BeginInit();
            this.toolStrip_2.SuspendLayout();
            this.dataGridViewExcelFilter_4.BeginInit();
            ((ISupportInitialize) this.bindingSource_4).BeginInit();
            this.toolStrip_3.SuspendLayout();
            this.tabPage_4.SuspendLayout();
            this.dataSetTechConnection_1.BeginInit();
            this.toolStrip_4.SuspendLayout();
            this.tabPage_5.SuspendLayout();
            this.splitContainer_4.Panel1.SuspendLayout();
            this.splitContainer_4.Panel2.SuspendLayout();
            this.splitContainer_4.SuspendLayout();
            this.dataGridViewExcelFilter_8.BeginInit();
            ((ISupportInitialize) this.bindingSource_7).BeginInit();
            this.toolStrip_5.SuspendLayout();
            this.dataGridViewExcelFilter_7.BeginInit();
            ((ISupportInitialize) this.bindingSource_8).BeginInit();
            this.dataSet_0.BeginInit();
            this.dataTable_0.BeginInit();
            this.dataTable_1.BeginInit();
            this.tabPage_6.SuspendLayout();
            this.dataGridViewExcelFilter_9.BeginInit();
            ((ISupportInitialize) this.bindingSource_9).BeginInit();
            this.toolStrip_6.SuspendLayout();
            base.SuspendLayout();
            this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripSeparator_2, this.toolStripButton_9, this.toolStripSeparator_0, this.toolStripButton_3, this.toolStripSeparator_1, this.toolStripButton_4, this.toolStripTextBox_0, this.toolStripButton_5, this.toolStripButton_6, this.toolStripButton_16, this.toolStripSeparator_3, this.toolStripButton_20 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStrip";
            this.toolStrip_0.Size = new Size(0x3c4, 0x19);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = (Image) manager.GetObject("toolBtnAddTU.Image");
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnAddTU";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Добавить тех уловие";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = (Image) manager.GetObject("toolBtnEditTU.Image");
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnEditTU";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Редактировать тех условие";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = (Image) manager.GetObject("toolBtnDelTU.Image");
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnDelTU";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Удалить тех условие";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator3";
            this.toolStripSeparator_2.Size = new Size(6, 0x19);
            this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_9.Image = (Image) manager.GetObject("toolBtnRefresh.Image");
            this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_9.Name = "toolBtnRefresh";
            this.toolStripButton_9.Size = new Size(0x17, 0x16);
            this.toolStripButton_9.Text = "Обновить";
            this.toolStripButton_9.Click += new EventHandler(this.toolStripButton_9_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = (Image) manager.GetObject("toolBtnShowRequest.Image");
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnShowRequest";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Открыть заявку";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator2";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = (Image) manager.GetObject("toolBtnFind.Image");
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnFind";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Поиск";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.toolStripTextBox_0.Name = "toolTxtFind";
            this.toolStripTextBox_0.Size = new Size(100, 0x19);
            this.toolStripTextBox_0.ToolTipText = "Текст поиска";
            this.toolStripTextBox_0.KeyDown += new KeyEventHandler(this.toolStripTextBox_0_KeyDown);
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = (Image) manager.GetObject("toolBtnFindPrev.Image");
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolBtnFindPrev";
            this.toolStripButton_5.Size = new Size(0x17, 0x16);
            this.toolStripButton_5.Text = "Поиск назад";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = (Image) manager.GetObject("toolBtnFindNext.Image");
            this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_6.Name = "toolBtnFindNext";
            this.toolStripButton_6.Size = new Size(0x17, 0x16);
            this.toolStripButton_6.Text = "Поиск вперед";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
            this.toolStripButton_16.Alignment = ToolStripItemAlignment.Right;
            this.toolStripButton_16.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_16.Image = (Image) manager.GetObject("toolBtnLoadold.Image");
            this.toolStripButton_16.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_16.Name = "toolBtnLoadold";
            this.toolStripButton_16.Size = new Size(0x17, 0x16);
            this.toolStripButton_16.Text = "Загрузка из старой базы";
            this.toolStripButton_16.Click += new EventHandler(this.toolStripButton_16_Click);
            this.toolStripSeparator_3.Name = "toolStripSeparator4";
            this.toolStripSeparator_3.Size = new Size(6, 0x19);
            this.toolStripButton_20.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_20.Image = (Image) manager.GetObject("toolBtnExportExcel.Image");
            this.toolStripButton_20.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_20.Name = "toolBtnExportExcel";
            this.toolStripButton_20.Size = new Size(0x17, 0x16);
            this.toolStripButton_20.Text = "Экспорт в Excel";
            this.toolStripButton_20.Click += new EventHandler(this.toolStripButton_20_Click);
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style.ForeColor = SystemColors.WindowText;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = style;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
                this.dataGridViewCheckBoxColumn_0, this.dataGridViewTextBoxColumn_140, this.dataGridViewFilterTextBoxColumn_17, this.dataGridViewFilterTextBoxColumn_18, this.dataGridViewFilterTextBoxColumn_19, this.dataGridViewTextBoxColumn_141, this.dataGridViewTextBoxColumn_142, this.dataGridViewFilterTextBoxColumn_20, this.dataGridViewTextBoxColumn_143, this.dataGridViewTextBoxColumn_144, this.dataGridViewFilterTextBoxColumn_21, this.dataGridViewTextBoxColumn_145, this.dataGridViewFilterTextBoxColumn_22, this.dataGridViewFilterTextBoxColumn_23, this.dataGridViewTextBoxColumn_146, this.dataGridViewFilterTextBoxColumn_24,
                this.dataGridViewFilterTextBoxColumn_25, this.dataGridViewFilterTextBoxColumn_26, this.dataGridViewFilterTextBoxColumn_27, this.dataGridViewTextBoxColumn_147, this.dataGridViewFilterTextBoxColumn_28, this.dataGridViewTextBoxColumn_148, this.dataGridViewFilterTextBoxColumn_29, this.dataGridViewFilterTextBoxColumn_30, this.dataGridViewFilterTextBoxColumn_31, this.dataGridViewTextBoxColumn_149, this.dataGridViewTextBoxColumn_150, this.dataGridViewFilterTextBoxColumn_32, this.dataGridViewFilterTextBoxColumn_33
            };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = SystemColors.Window;
            style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style2.ForeColor = SystemColors.ControlText;
            style2.SelectionBackColor = SystemColors.Highlight;
            style2.SelectionForeColor = SystemColors.HighlightText;
            style2.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_0.DefaultCellStyle = style2;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_0.Name = "dgvTU";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Control;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style3.ForeColor = SystemColors.WindowText;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.RowHeadersDefaultCellStyle = style3;
            this.dataGridViewExcelFilter_0.Size = new Size(0x315, 0x126);
            this.dataGridViewExcelFilter_0.TabIndex = 1;
            this.dataGridViewExcelFilter_0.VirtualMode = true;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.dataGridViewExcelFilter_0.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_0_RowPostPaint);
            this.bindingSource_0.DataMember = "vTC_TU";
            this.bindingSource_0.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
            this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.FixedPanel = FixedPanel.Panel1;
            this.splitContainer_0.Location = new Point(0, 0x19);
            this.splitContainer_0.Name = "splitContainerMain";
            this.splitContainer_0.Panel1.Controls.Add(this.treeView_0);
            this.splitContainer_0.Panel1.Controls.Add(this.label_5);
            this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_0);
            this.splitContainer_0.Panel1.Controls.Add(this.label_0);
            this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_1);
            this.splitContainer_0.Panel1.Controls.Add(this.label_1);
            this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_1);
            this.splitContainer_0.Panel2.Controls.Add(this.splitContainer_1);
            this.splitContainer_0.Size = new Size(0x3c4, 0x1f1);
            this.splitContainer_0.SplitterDistance = 0xab;
            this.splitContainer_0.TabIndex = 2;
            this.treeView_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.treeView_0.CheckBoxes = true;
            this.treeView_0.Location = new Point(0, 0x77);
            this.treeView_0.Name = "treeViewSubstation";
            this.treeView_0.Size = new Size(0xab, 0x17a);
            this.treeView_0.TabIndex = 11;
            this.treeView_0.AfterCheck += new TreeViewEventHandler(this.treeView_0_AfterCheck);
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(12, 0x67);
            this.label_5.Name = "label6";
            this.label_5.Size = new Size(0x44, 13);
            this.label_5.TabIndex = 10;
            this.label_5.Text = "Подстанции";
            this.dateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_0.Location = new Point(12, 80);
            this.dateTimePicker_0.Name = "dateTimePickerFilterEnd";
            this.dateTimePicker_0.Size = new Size(0x88, 20);
            this.dateTimePicker_0.TabIndex = 9;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 0x40);
            this.label_0.Name = "label2";
            this.label_0.Size = new Size(0x59, 13);
            this.label_0.TabIndex = 8;
            this.label_0.Text = "Дата окончания";
            this.dateTimePicker_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_1.Location = new Point(12, 0x29);
            this.dateTimePicker_1.Name = "dateTimePickerFilterBeg";
            this.dateTimePicker_1.Size = new Size(0x8b, 20);
            this.dateTimePicker_1.TabIndex = 7;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(12, 0x19);
            this.label_1.Name = "label1";
            this.label_1.Size = new Size(0x47, 13);
            this.label_1.TabIndex = 6;
            this.label_1.Text = "Дата начала";
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_7, this.toolStripButton_8 };
            this.toolStrip_1.Items.AddRange(itemArray2);
            this.toolStrip_1.Location = new Point(0, 0);
            this.toolStrip_1.Name = "toolStripFilter";
            this.toolStrip_1.Size = new Size(0xab, 0x19);
            this.toolStrip_1.TabIndex = 5;
            this.toolStrip_1.Text = "toolStrip1";
            this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_7.Image = (Image) manager.GetObject("toolBtnApplyFilter.Image");
            this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_7.Name = "toolBtnApplyFilter";
            this.toolStripButton_7.Size = new Size(0x17, 0x16);
            this.toolStripButton_7.Text = "Применить фильтр";
            this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
            this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_8.Image = (Image) manager.GetObject("toolBtnClearFilter.Image");
            this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_8.Name = "toolBtnClearFilter";
            this.toolStripButton_8.Size = new Size(0x17, 0x16);
            this.toolStripButton_8.Text = "Очистить фильтр";
            this.toolStripButton_8.Click += new EventHandler(this.toolStripButton_8_Click);
            this.splitContainer_1.Dock = DockStyle.Fill;
            this.splitContainer_1.FixedPanel = FixedPanel.Panel2;
            this.splitContainer_1.Location = new Point(0, 0);
            this.splitContainer_1.Name = "splitContainer1";
            this.splitContainer_1.Orientation = Orientation.Horizontal;
            this.splitContainer_1.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
            this.splitContainer_1.Panel2.Controls.Add(this.tabControl_0);
            this.splitContainer_1.Size = new Size(0x315, 0x1f1);
            this.splitContainer_1.SplitterDistance = 0x126;
            this.splitContainer_1.TabIndex = 2;
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Controls.Add(this.tabPage_3);
            this.tabControl_0.Controls.Add(this.tabPage_2);
            this.tabControl_0.Controls.Add(this.tabPage_4);
            this.tabControl_0.Controls.Add(this.tabPage_5);
            this.tabControl_0.Controls.Add(this.tabPage_6);
            this.tabControl_0.Dock = DockStyle.Fill;
            this.tabControl_0.Location = new Point(0, 0);
            this.tabControl_0.Name = "tcGeneral";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x315, 0xc7);
            this.tabControl_0.TabIndex = 0;
            this.tabControl_0.SelectedIndexChanged += new EventHandler(this.tabControl_0_SelectedIndexChanged);
            this.tabPage_0.Controls.Add(this.dataGridViewExcelFilter_1);
            this.tabPage_0.Location = new Point(4, 0x16);
            this.tabPage_0.Name = "tabPageFiles";
            this.tabPage_0.Padding = new Padding(3);
            this.tabPage_0.Size = new Size(0x30d, 0xad);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Файлы";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToResizeColumns = false;
            this.dataGridViewExcelFilter_1.AllowUserToResizeRows = false;
            this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
            style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style4.BackColor = SystemColors.Control;
            style4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style4.ForeColor = SystemColors.WindowText;
            style4.SelectionBackColor = SystemColors.Highlight;
            style4.SelectionForeColor = SystemColors.HighlightText;
            style4.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_1.ColumnHeadersDefaultCellStyle = style4;
            this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewLinkColumn_0, this.dataGridViewImageColumnNotNull_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3 };
            this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray2);
            this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
            style5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style5.BackColor = SystemColors.Window;
            style5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style5.ForeColor = SystemColors.ControlText;
            style5.SelectionBackColor = SystemColors.Highlight;
            style5.SelectionForeColor = SystemColors.HighlightText;
            style5.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_1.DefaultCellStyle = style5;
            this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_1.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewExcelFilter_1.Location = new Point(3, 3);
            this.dataGridViewExcelFilter_1.Name = "dgvFile";
            this.dataGridViewExcelFilter_1.ReadOnly = true;
            style6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style6.BackColor = SystemColors.Control;
            style6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style6.ForeColor = SystemColors.WindowText;
            style6.SelectionBackColor = SystemColors.Highlight;
            style6.SelectionForeColor = SystemColors.HighlightText;
            style6.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_1.RowHeadersDefaultCellStyle = style6;
            this.dataGridViewExcelFilter_1.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_1.Size = new Size(0x307, 0xa7);
            this.dataGridViewExcelFilter_1.TabIndex = 7;
            this.dataGridViewExcelFilter_1.VirtualMode = true;
            this.dataGridViewExcelFilter_1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_1_CellContentClick);
            this.dataGridViewExcelFilter_1.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dataGridViewExcelFilter_1_CellValueNeeded);
            this.dataGridViewLinkColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewLinkColumn_0.DataPropertyName = "FileName";
            this.dataGridViewLinkColumn_0.HeaderText = "Файл";
            this.dataGridViewLinkColumn_0.Name = "fileNameDgvColumn";
            this.dataGridViewLinkColumn_0.ReadOnly = true;
            this.dataGridViewLinkColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewLinkColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
            style7.NullValue = null;
            this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style7;
            this.dataGridViewImageColumnNotNull_0.HeaderText = "";
            this.dataGridViewImageColumnNotNull_0.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumnNotNull_0.Name = "imageDgvColumn";
            this.dataGridViewImageColumnNotNull_0.ReadOnly = true;
            this.dataGridViewImageColumnNotNull_0.Width = 30;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "idFileDgvColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_1.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_1.Name = "idDocDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "dateChange";
            this.dataGridViewTextBoxColumn_2.HeaderText = "dateChange";
            this.dataGridViewTextBoxColumn_2.Name = "dateChangeDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "idTemplate";
            this.dataGridViewTextBoxColumn_3.HeaderText = "idTemplate";
            this.dataGridViewTextBoxColumn_3.Name = "idTemplateDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.Visible = false;
            this.bindingSource_1.DataMember = "tTC_DocFile";
            this.bindingSource_1.DataSource = this.dataSetTechConnection_0;
            this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_2);
            this.tabPage_1.Location = new Point(4, 0x16);
            this.tabPage_1.Name = "tabPageRequestHistory";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(0x30d, 0xad);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "История заявок";
            this.tabPage_1.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_2.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_2.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_2.AutoGenerateColumns = false;
            style8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style8.BackColor = SystemColors.Control;
            style8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style8.ForeColor = SystemColors.WindowText;
            style8.SelectionBackColor = SystemColors.Highlight;
            style8.SelectionForeColor = SystemColors.HighlightText;
            style8.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_2.ColumnHeadersDefaultCellStyle = style8;
            this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray3 = new DataGridViewColumn[] { 
                this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_15, this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6, this.dataGridViewTextBoxColumn_7, this.dataGridViewTextBoxColumn_8, this.dataGridViewTextBoxColumn_9, this.dataGridViewTextBoxColumn_10, this.dataGridViewTextBoxColumn_11, this.dataGridViewTextBoxColumn_12, this.dataGridViewTextBoxColumn_13, this.dataGridViewTextBoxColumn_14, this.dataGridViewTextBoxColumn_16, this.dataGridViewTextBoxColumn_17, this.dataGridViewTextBoxColumn_18, this.dataGridViewTextBoxColumn_19,
                this.dataGridViewTextBoxColumn_20, this.dataGridViewTextBoxColumn_21
            };
            this.dataGridViewExcelFilter_2.Columns.AddRange(columnArray3);
            this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
            style9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style9.BackColor = SystemColors.Window;
            style9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style9.ForeColor = SystemColors.ControlText;
            style9.SelectionBackColor = SystemColors.Highlight;
            style9.SelectionForeColor = SystemColors.HighlightText;
            style9.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_2.DefaultCellStyle = style9;
            this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_2.Location = new Point(3, 3);
            this.dataGridViewExcelFilter_2.MultiSelect = false;
            this.dataGridViewExcelFilter_2.Name = "dgvRequestHistory";
            this.dataGridViewExcelFilter_2.ReadOnly = true;
            style10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style10.BackColor = SystemColors.Control;
            style10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style10.ForeColor = SystemColors.WindowText;
            style10.SelectionBackColor = SystemColors.Highlight;
            style10.SelectionForeColor = SystemColors.HighlightText;
            style10.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_2.RowHeadersDefaultCellStyle = style10;
            this.dataGridViewExcelFilter_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_2.Size = new Size(0x307, 0xa7);
            this.dataGridViewExcelFilter_2.TabIndex = 4;
            this.dataGridViewExcelFilter_2.VirtualMode = true;
            this.dataGridViewExcelFilter_2.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_2_CellFormatting);
            this.dataGridViewExcelFilter_2.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_2_RowPostPaint);
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "numDateIn";
            style11.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_4.DefaultCellStyle = style11;
            this.dataGridViewTextBoxColumn_4.HeaderText = "№, дата вход.";
            this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewTextBoxColumn_4.Width = 80;
            this.dataGridViewTextBoxColumn_15.DataPropertyName = "PowerAdd";
            this.dataGridViewTextBoxColumn_15.HeaderText = "Доп мощность";
            this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_15.ReadOnly = true;
            this.dataGridViewTextBoxColumn_15.Visible = false;
            this.dataGridViewTextBoxColumn_15.Width = 70;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "numDoc";
            this.dataGridViewTextBoxColumn_5.HeaderText = "numDoc";
            this.dataGridViewTextBoxColumn_5.Name = "numDocDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.Visible = false;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_6.HeaderText = "id";
            this.dataGridViewTextBoxColumn_6.Name = "idRequestHistoryDgvColumn";
            this.dataGridViewTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewTextBoxColumn_6.Visible = false;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "dateDoc";
            this.dataGridViewTextBoxColumn_7.HeaderText = "Дата получения";
            this.dataGridViewTextBoxColumn_7.Name = "dateDocDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewTextBoxColumn_7.Width = 80;
            this.dataGridViewTextBoxColumn_8.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn_8.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn_8.Name = "typeDocRequestHistoryDgvColumn";
            this.dataGridViewTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewTextBoxColumn_8.Visible = false;
            this.dataGridViewTextBoxColumn_9.DataPropertyName = "numIn";
            this.dataGridViewTextBoxColumn_9.HeaderText = "numIn";
            this.dataGridViewTextBoxColumn_9.Name = "numInDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewTextBoxColumn_9.Visible = false;
            this.dataGridViewTextBoxColumn_10.DataPropertyName = "dateIn";
            this.dataGridViewTextBoxColumn_10.HeaderText = "dateIn";
            this.dataGridViewTextBoxColumn_10.Name = "dateInDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewTextBoxColumn_10.Visible = false;
            this.dataGridViewTextBoxColumn_11.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_11.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_11.Name = "idAbnDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewTextBoxColumn_11.Visible = false;
            this.dataGridViewTextBoxColumn_12.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_12.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_12.Name = "idAbnObjDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewTextBoxColumn_12.Visible = false;
            this.dataGridViewTextBoxColumn_13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_13.DataPropertyName = "body";
            style12.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_13.DefaultCellStyle = style12;
            this.dataGridViewTextBoxColumn_13.HeaderText = "Тело письма";
            this.dataGridViewTextBoxColumn_13.Name = "bodyDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewTextBoxColumn_14.DataPropertyName = "PowerCurrent";
            this.dataGridViewTextBoxColumn_14.HeaderText = "Текущая мощность";
            this.dataGridViewTextBoxColumn_14.Name = "powerCurrentDgvColumn";
            this.dataGridViewTextBoxColumn_14.ReadOnly = true;
            this.dataGridViewTextBoxColumn_14.Width = 70;
            this.dataGridViewTextBoxColumn_16.DataPropertyName = "Power";
            this.dataGridViewTextBoxColumn_16.HeaderText = "Суммарная мощность";
            this.dataGridViewTextBoxColumn_16.Name = "powerDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_16.ReadOnly = true;
            this.dataGridViewTextBoxColumn_16.Width = 70;
            this.dataGridViewTextBoxColumn_17.DataPropertyName = "VoltageName";
            this.dataGridViewTextBoxColumn_17.HeaderText = "Напряжение";
            this.dataGridViewTextBoxColumn_17.Name = "voltageNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewTextBoxColumn_17.Width = 70;
            this.dataGridViewTextBoxColumn_18.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_18.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_18.Name = "commentDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_18.ReadOnly = true;
            this.dataGridViewTextBoxColumn_18.Width = 70;
            this.dataGridViewTextBoxColumn_19.DataPropertyName = "VoltageLevel";
            this.dataGridViewTextBoxColumn_19.HeaderText = "VoltageLevel";
            this.dataGridViewTextBoxColumn_19.Name = "voltageLevelDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_19.ReadOnly = true;
            this.dataGridViewTextBoxColumn_19.Visible = false;
            this.dataGridViewTextBoxColumn_20.DataPropertyName = "VoltageValue";
            this.dataGridViewTextBoxColumn_20.HeaderText = "VoltageValue";
            this.dataGridViewTextBoxColumn_20.Name = "voltageValueDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_20.ReadOnly = true;
            this.dataGridViewTextBoxColumn_20.Visible = false;
            this.dataGridViewTextBoxColumn_21.DataPropertyName = "IdParent";
            this.dataGridViewTextBoxColumn_21.HeaderText = "IdParent";
            this.dataGridViewTextBoxColumn_21.Name = "idParentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_21.ReadOnly = true;
            this.dataGridViewTextBoxColumn_21.Visible = false;
            this.bindingSource_2.DataMember = "vTC_RequestHistory";
            this.bindingSource_2.DataSource = this.dataSetTechConnection_0;
            this.tabPage_3.Controls.Add(this.splitContainer_3);
            this.tabPage_3.Location = new Point(4, 0x16);
            this.tabPage_3.Name = "tabPageTypeWork";
            this.tabPage_3.Size = new Size(0x30d, 0xad);
            this.tabPage_3.TabIndex = 3;
            this.tabPage_3.Text = "Вид работ";
            this.tabPage_3.UseVisualStyleBackColor = true;
            this.splitContainer_3.Dock = DockStyle.Fill;
            this.splitContainer_3.Location = new Point(0, 0);
            this.splitContainer_3.Name = "splitContainer2";
            this.splitContainer_3.Panel1.Controls.Add(this.dataGridViewExcelFilter_5);
            this.splitContainer_3.Panel2.Controls.Add(this.dataGridViewExcelFilter_6);
            this.splitContainer_3.Size = new Size(0x30d, 0xad);
            this.splitContainer_3.SplitterDistance = 0x16e;
            this.splitContainer_3.TabIndex = 0;
            this.dataGridViewExcelFilter_5.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_5.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_5.AutoGenerateColumns = false;
            style13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style13.BackColor = SystemColors.Control;
            style13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style13.ForeColor = SystemColors.WindowText;
            style13.SelectionBackColor = SystemColors.Highlight;
            style13.SelectionForeColor = SystemColors.HighlightText;
            style13.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_5.ColumnHeadersDefaultCellStyle = style13;
            this.dataGridViewExcelFilter_5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray4 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_35, this.dataGridViewTextBoxColumn_36, this.dataGridViewTextBoxColumn_37, this.dataGridViewTextBoxColumn_38, this.dataGridViewTextBoxColumn_39 };
            this.dataGridViewExcelFilter_5.Columns.AddRange(columnArray4);
            this.dataGridViewExcelFilter_5.DataSource = this.bindingSource_5;
            style14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style14.BackColor = SystemColors.Window;
            style14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style14.ForeColor = SystemColors.ControlText;
            style14.SelectionBackColor = SystemColors.Highlight;
            style14.SelectionForeColor = SystemColors.HighlightText;
            style14.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_5.DefaultCellStyle = style14;
            this.dataGridViewExcelFilter_5.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_5.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_5.Name = "dgvNetWork";
            this.dataGridViewExcelFilter_5.ReadOnly = true;
            style15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style15.BackColor = SystemColors.Control;
            style15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style15.ForeColor = SystemColors.WindowText;
            style15.SelectionBackColor = SystemColors.Highlight;
            style15.SelectionForeColor = SystemColors.HighlightText;
            style15.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_5.RowHeadersDefaultCellStyle = style15;
            this.dataGridViewExcelFilter_5.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_5.Size = new Size(0x16e, 0xad);
            this.dataGridViewExcelFilter_5.TabIndex = 2;
            this.dataGridViewExcelFilter_5.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_6_RowPostPaint);
            this.dataGridViewTextBoxColumn_35.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_35.DataPropertyName = "Work";
            style16.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_35.DefaultCellStyle = style16;
            this.dataGridViewTextBoxColumn_35.HeaderText = "Работы сетевой организации";
            this.dataGridViewTextBoxColumn_35.Name = "workDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_35.ReadOnly = true;
            this.dataGridViewTextBoxColumn_35.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_36.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_36.HeaderText = "id";
            this.dataGridViewTextBoxColumn_36.Name = "idNetWorkDgvColumn";
            this.dataGridViewTextBoxColumn_36.ReadOnly = true;
            this.dataGridViewTextBoxColumn_36.Visible = false;
            this.dataGridViewTextBoxColumn_37.DataPropertyName = "idTU";
            this.dataGridViewTextBoxColumn_37.HeaderText = "idTU";
            this.dataGridViewTextBoxColumn_37.Name = "idTUNetWorkDgvColumn";
            this.dataGridViewTextBoxColumn_37.ReadOnly = true;
            this.dataGridViewTextBoxColumn_37.Visible = false;
            this.dataGridViewTextBoxColumn_38.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn_38.HeaderText = "num";
            this.dataGridViewTextBoxColumn_38.Name = "numNetWorkDgvColumn";
            this.dataGridViewTextBoxColumn_38.ReadOnly = true;
            this.dataGridViewTextBoxColumn_38.Visible = false;
            this.dataGridViewTextBoxColumn_39.DataPropertyName = "TypeWork";
            this.dataGridViewTextBoxColumn_39.HeaderText = "TypeWork";
            this.dataGridViewTextBoxColumn_39.Name = "typeWorkNetWorkDgvColumn";
            this.dataGridViewTextBoxColumn_39.ReadOnly = true;
            this.dataGridViewTextBoxColumn_39.Visible = false;
            this.bindingSource_5.DataMember = "tTC_TUTypeWork";
            this.bindingSource_5.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_5.Filter = "TypeWork = 1";
            this.bindingSource_5.Sort = "num";
            this.dataGridViewExcelFilter_6.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_6.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_6.AutoGenerateColumns = false;
            style17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style17.BackColor = SystemColors.Control;
            style17.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style17.ForeColor = SystemColors.WindowText;
            style17.SelectionBackColor = SystemColors.Highlight;
            style17.SelectionForeColor = SystemColors.HighlightText;
            style17.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_6.ColumnHeadersDefaultCellStyle = style17;
            this.dataGridViewExcelFilter_6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray5 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_40, this.dataGridViewTextBoxColumn_41, this.dataGridViewTextBoxColumn_42, this.dataGridViewTextBoxColumn_43, this.dataGridViewTextBoxColumn_44 };
            this.dataGridViewExcelFilter_6.Columns.AddRange(columnArray5);
            this.dataGridViewExcelFilter_6.DataSource = this.bindingSource_6;
            style18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style18.BackColor = SystemColors.Window;
            style18.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style18.ForeColor = SystemColors.ControlText;
            style18.SelectionBackColor = SystemColors.Highlight;
            style18.SelectionForeColor = SystemColors.HighlightText;
            style18.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_6.DefaultCellStyle = style18;
            this.dataGridViewExcelFilter_6.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_6.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_6.Name = "dgvClientWork";
            this.dataGridViewExcelFilter_6.ReadOnly = true;
            style19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style19.BackColor = SystemColors.Control;
            style19.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style19.ForeColor = SystemColors.WindowText;
            style19.SelectionBackColor = SystemColors.Highlight;
            style19.SelectionForeColor = SystemColors.HighlightText;
            style19.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_6.RowHeadersDefaultCellStyle = style19;
            this.dataGridViewExcelFilter_6.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_6.Size = new Size(0x19b, 0xad);
            this.dataGridViewExcelFilter_6.TabIndex = 3;
            this.dataGridViewExcelFilter_6.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_6_RowPostPaint);
            this.dataGridViewTextBoxColumn_40.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_40.DataPropertyName = "Work";
            style20.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_40.DefaultCellStyle = style20;
            this.dataGridViewTextBoxColumn_40.HeaderText = "Работы заказчика";
            this.dataGridViewTextBoxColumn_40.Name = "workDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_40.ReadOnly = true;
            this.dataGridViewTextBoxColumn_40.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_41.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_41.HeaderText = "id";
            this.dataGridViewTextBoxColumn_41.Name = "idClientWorkDgvColumn";
            this.dataGridViewTextBoxColumn_41.ReadOnly = true;
            this.dataGridViewTextBoxColumn_41.Visible = false;
            this.dataGridViewTextBoxColumn_42.DataPropertyName = "idTU";
            this.dataGridViewTextBoxColumn_42.HeaderText = "idTU";
            this.dataGridViewTextBoxColumn_42.Name = "idTUClientWorkDgvColumn";
            this.dataGridViewTextBoxColumn_42.ReadOnly = true;
            this.dataGridViewTextBoxColumn_42.Visible = false;
            this.dataGridViewTextBoxColumn_43.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn_43.HeaderText = "num";
            this.dataGridViewTextBoxColumn_43.Name = "numClientWorkDgvColumn";
            this.dataGridViewTextBoxColumn_43.ReadOnly = true;
            this.dataGridViewTextBoxColumn_43.Visible = false;
            this.dataGridViewTextBoxColumn_44.DataPropertyName = "TypeWork";
            this.dataGridViewTextBoxColumn_44.HeaderText = "TypeWork";
            this.dataGridViewTextBoxColumn_44.Name = "typeWorkClientWorkDgvColumn";
            this.dataGridViewTextBoxColumn_44.ReadOnly = true;
            this.dataGridViewTextBoxColumn_44.Visible = false;
            this.bindingSource_6.DataMember = "tTC_TUTypeWork";
            this.bindingSource_6.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_6.Filter = "TypeWork = 2";
            this.bindingSource_6.Sort = "num";
            this.tabPage_2.Controls.Add(this.splitContainer_2);
            this.tabPage_2.Location = new Point(4, 0x16);
            this.tabPage_2.Name = "tabPageDocOut";
            this.tabPage_2.Padding = new Padding(3);
            this.tabPage_2.Size = new Size(0x30d, 0xad);
            this.tabPage_2.TabIndex = 2;
            this.tabPage_2.Text = "Выданные документы";
            this.tabPage_2.UseVisualStyleBackColor = true;
            this.splitContainer_2.Dock = DockStyle.Fill;
            this.splitContainer_2.Location = new Point(3, 3);
            this.splitContainer_2.Name = "splitContainerDocOut";
            this.splitContainer_2.Panel1.Controls.Add(this.dataGridViewExcelFilter_3);
            this.splitContainer_2.Panel1.Controls.Add(this.toolStrip_2);
            this.splitContainer_2.Panel2.Controls.Add(this.dataGridViewExcelFilter_4);
            this.splitContainer_2.Panel2.Controls.Add(this.toolStrip_3);
            this.splitContainer_2.Size = new Size(0x307, 0xa7);
            this.splitContainer_2.SplitterDistance = 0x1a0;
            this.splitContainer_2.TabIndex = 0;
            this.dataGridViewExcelFilter_3.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_3.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_3.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_3.set_AllowUserToVisibleColumns(false);
            this.dataGridViewExcelFilter_3.AutoGenerateColumns = false;
            style21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style21.BackColor = SystemColors.Control;
            style21.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style21.ForeColor = SystemColors.WindowText;
            style21.SelectionBackColor = SystemColors.Highlight;
            style21.SelectionForeColor = SystemColors.HighlightText;
            style21.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_3.ColumnHeadersDefaultCellStyle = style21;
            this.dataGridViewExcelFilter_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray6 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_22, this.dataGridViewTextBoxColumn_23, this.dataGridViewTextBoxColumn_24, this.dataGridViewTextBoxColumn_25, this.dataGridViewTextBoxColumn_26, this.dataGridViewTextBoxColumn_27, this.dataGridViewTextBoxColumn_28, this.dataGridViewTextBoxColumn_29, this.dataGridViewTextBoxColumn_30, this.dataGridViewTextBoxColumn_31, this.dataGridViewTextBoxColumn_32, this.dataGridViewTextBoxColumn_33, this.dataGridViewTextBoxColumn_34 };
            this.dataGridViewExcelFilter_3.Columns.AddRange(columnArray6);
            this.dataGridViewExcelFilter_3.DataSource = this.bindingSource_3;
            style22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style22.BackColor = SystemColors.Window;
            style22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style22.ForeColor = SystemColors.ControlText;
            style22.SelectionBackColor = SystemColors.Highlight;
            style22.SelectionForeColor = SystemColors.HighlightText;
            style22.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_3.DefaultCellStyle = style22;
            this.dataGridViewExcelFilter_3.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_3.Location = new Point(0x18, 0);
            this.dataGridViewExcelFilter_3.Name = "dgvDocOut";
            this.dataGridViewExcelFilter_3.ReadOnly = true;
            style23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style23.BackColor = SystemColors.Control;
            style23.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style23.ForeColor = SystemColors.WindowText;
            style23.SelectionBackColor = SystemColors.Highlight;
            style23.SelectionForeColor = SystemColors.HighlightText;
            style23.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_3.RowHeadersDefaultCellStyle = style23;
            this.dataGridViewExcelFilter_3.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_3.Size = new Size(0x188, 0xa7);
            this.dataGridViewExcelFilter_3.TabIndex = 3;
            this.dataGridViewExcelFilter_3.VirtualMode = true;
            this.dataGridViewExcelFilter_3.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_3_CellFormatting);
            this.dataGridViewTextBoxColumn_22.DataPropertyName = "TypeDocNameOut";
            this.dataGridViewTextBoxColumn_22.HeaderText = "Документ";
            this.dataGridViewTextBoxColumn_22.Name = "typeDocNameOutDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_22.ReadOnly = true;
            this.dataGridViewTextBoxColumn_23.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_23.HeaderText = "id";
            this.dataGridViewTextBoxColumn_23.Name = "idLinkDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_23.ReadOnly = true;
            this.dataGridViewTextBoxColumn_23.Visible = false;
            this.dataGridViewTextBoxColumn_24.DataPropertyName = "numDateDocOut";
            this.dataGridViewTextBoxColumn_24.HeaderText = "numDateDocOut";
            this.dataGridViewTextBoxColumn_24.Name = "numDateDocOutDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_24.ReadOnly = true;
            this.dataGridViewTextBoxColumn_24.Visible = false;
            this.dataGridViewTextBoxColumn_25.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_25.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_25.Name = "idDocDgvColumn";
            this.dataGridViewTextBoxColumn_25.ReadOnly = true;
            this.dataGridViewTextBoxColumn_25.Visible = false;
            this.dataGridViewTextBoxColumn_26.DataPropertyName = "numDocOut";
            this.dataGridViewTextBoxColumn_26.HeaderText = "№";
            this.dataGridViewTextBoxColumn_26.Name = "numDocOutDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_26.ReadOnly = true;
            this.dataGridViewTextBoxColumn_27.DataPropertyName = "TypeDocOut";
            this.dataGridViewTextBoxColumn_27.HeaderText = "TypeDocOut";
            this.dataGridViewTextBoxColumn_27.Name = "typeDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_27.ReadOnly = true;
            this.dataGridViewTextBoxColumn_27.Visible = false;
            this.dataGridViewTextBoxColumn_28.DataPropertyName = "idDocOut";
            this.dataGridViewTextBoxColumn_28.HeaderText = "idDocOut";
            this.dataGridViewTextBoxColumn_28.Name = "idDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_28.ReadOnly = true;
            this.dataGridViewTextBoxColumn_28.Visible = false;
            this.dataGridViewTextBoxColumn_29.DataPropertyName = "dateDocOut";
            style24.Format = "d";
            style24.NullValue = null;
            this.dataGridViewTextBoxColumn_29.DefaultCellStyle = style24;
            this.dataGridViewTextBoxColumn_29.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_29.Name = "dateDocOutDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_29.ReadOnly = true;
            this.dataGridViewTextBoxColumn_30.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn_30.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn_30.Name = "statusDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_30.ReadOnly = true;
            this.dataGridViewTextBoxColumn_30.Visible = false;
            this.dataGridViewTextBoxColumn_31.DataPropertyName = "BodyDocOut";
            this.dataGridViewTextBoxColumn_31.HeaderText = "Содержание";
            this.dataGridViewTextBoxColumn_31.Name = "bodyDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_31.ReadOnly = true;
            this.dataGridViewTextBoxColumn_32.DataPropertyName = "SendModeName";
            this.dataGridViewTextBoxColumn_32.HeaderText = "Способ отправки";
            this.dataGridViewTextBoxColumn_32.Name = "sendModeNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_32.ReadOnly = true;
            this.dataGridViewTextBoxColumn_32.Visible = false;
            this.dataGridViewTextBoxColumn_33.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn_33.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn_33.Name = "numberDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_33.ReadOnly = true;
            this.dataGridViewTextBoxColumn_34.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn_34.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_34.Name = "commentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_34.ReadOnly = true;
            this.dataGridViewTextBoxColumn_34.Visible = false;
            this.bindingSource_3.DataMember = "vTC_DocOut";
            this.bindingSource_3.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_3.CurrentChanged += new EventHandler(this.bindingSource_3_CurrentChanged);
            this.toolStrip_2.Dock = DockStyle.Left;
            this.toolStrip_2.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripButton_12, this.toolStripButton_10, this.toolStripButton_11 };
            this.toolStrip_2.Items.AddRange(itemArray3);
            this.toolStrip_2.Location = new Point(0, 0);
            this.toolStrip_2.Name = "toolStripDocOut";
            this.toolStrip_2.Size = new Size(0x18, 0xa7);
            this.toolStrip_2.TabIndex = 2;
            this.toolStrip_2.Text = "toolStrip1";
            this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_12.Image = (Image) manager.GetObject("toolBtnAddDocOut.Image");
            this.toolStripButton_12.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_12.Name = "toolBtnAddDocOut";
            this.toolStripButton_12.Size = new Size(0x15, 20);
            this.toolStripButton_12.Text = "Новый документ";
            this.toolStripButton_12.Click += new EventHandler(this.toolStripButton_12_Click);
            this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_10.Image = (Image) manager.GetObject("toolBtnEditDocOut.Image");
            this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_10.Name = "toolBtnEditDocOut";
            this.toolStripButton_10.Size = new Size(0x15, 20);
            this.toolStripButton_10.Text = "Редактировать документ";
            this.toolStripButton_10.Click += new EventHandler(this.toolStripButton_10_Click);
            this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_11.Image = (Image) manager.GetObject("toolBtnDelDocOut.Image");
            this.toolStripButton_11.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_11.Name = "toolBtnDelDocOut";
            this.toolStripButton_11.Size = new Size(0x15, 20);
            this.toolStripButton_11.Text = "Удалить документ";
            this.toolStripButton_11.Click += new EventHandler(this.toolStripButton_11_Click);
            this.dataGridViewExcelFilter_4.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_4.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_4.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_4.set_AllowUserToVisibleColumns(false);
            this.dataGridViewExcelFilter_4.AutoGenerateColumns = false;
            style25.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style25.BackColor = SystemColors.Control;
            style25.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style25.ForeColor = SystemColors.WindowText;
            style25.SelectionBackColor = SystemColors.Highlight;
            style25.SelectionForeColor = SystemColors.HighlightText;
            style25.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_4.ColumnHeadersDefaultCellStyle = style25;
            this.dataGridViewExcelFilter_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray7 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_118, this.dataGridViewTextBoxColumn_119, this.dataGridViewTextBoxColumn_120, this.dataGridViewTextBoxColumn_121, this.dataGridViewTextBoxColumn_122, this.dataGridViewTextBoxColumn_123, this.dataGridViewTextBoxColumn_124 };
            this.dataGridViewExcelFilter_4.Columns.AddRange(columnArray7);
            this.dataGridViewExcelFilter_4.DataSource = this.bindingSource_4;
            style26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style26.BackColor = SystemColors.Window;
            style26.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style26.ForeColor = SystemColors.ControlText;
            style26.SelectionBackColor = SystemColors.Highlight;
            style26.SelectionForeColor = SystemColors.HighlightText;
            style26.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_4.DefaultCellStyle = style26;
            this.dataGridViewExcelFilter_4.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_4.Location = new Point(0, 0x19);
            this.dataGridViewExcelFilter_4.Name = "dgvDocOutStatus";
            this.dataGridViewExcelFilter_4.ReadOnly = true;
            style27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style27.BackColor = SystemColors.Control;
            style27.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style27.ForeColor = SystemColors.WindowText;
            style27.SelectionBackColor = SystemColors.Highlight;
            style27.SelectionForeColor = SystemColors.HighlightText;
            style27.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_4.RowHeadersDefaultCellStyle = style27;
            this.dataGridViewExcelFilter_4.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_4.Size = new Size(0x163, 0x8e);
            this.dataGridViewExcelFilter_4.TabIndex = 3;
            this.dataGridViewTextBoxColumn_118.DataPropertyName = "statusName";
            this.dataGridViewTextBoxColumn_118.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn_118.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn_118.ReadOnly = true;
            this.dataGridViewTextBoxColumn_118.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_119.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_119.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_119.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_119.ReadOnly = true;
            this.dataGridViewTextBoxColumn_119.Visible = false;
            this.dataGridViewTextBoxColumn_120.DataPropertyName = "idStatus";
            this.dataGridViewTextBoxColumn_120.HeaderText = "idStatus";
            this.dataGridViewTextBoxColumn_120.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn_120.ReadOnly = true;
            this.dataGridViewTextBoxColumn_120.Visible = false;
            this.dataGridViewTextBoxColumn_121.DataPropertyName = "DateChange";
            style28.Format = "d";
            style28.NullValue = null;
            this.dataGridViewTextBoxColumn_121.DefaultCellStyle = style28;
            this.dataGridViewTextBoxColumn_121.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_121.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn_121.ReadOnly = true;
            this.dataGridViewTextBoxColumn_121.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_121.Width = 70;
            this.dataGridViewTextBoxColumn_122.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_122.HeaderText = "id";
            this.dataGridViewTextBoxColumn_122.Name = "idStatusDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_122.ReadOnly = true;
            this.dataGridViewTextBoxColumn_122.Visible = false;
            this.dataGridViewTextBoxColumn_123.DataPropertyName = "SendName";
            this.dataGridViewTextBoxColumn_123.HeaderText = "Способ отправки";
            this.dataGridViewTextBoxColumn_123.Name = "sendNameDgvColumn";
            this.dataGridViewTextBoxColumn_123.ReadOnly = true;
            this.dataGridViewTextBoxColumn_124.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_124.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_124.Name = "сommentDocOutStatusDgvColumn";
            this.dataGridViewTextBoxColumn_124.ReadOnly = true;
            this.bindingSource_4.DataMember = "vTC_DocStatus";
            this.bindingSource_4.DataSource = this.dataSetTechConnection_0;
            this.toolStrip_3.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolStripButton_13, this.toolStripButton_14, this.toolStripButton_15 };
            this.toolStrip_3.Items.AddRange(itemArray4);
            this.toolStrip_3.Location = new Point(0, 0);
            this.toolStrip_3.Name = "toolStripDocOutStatus";
            this.toolStrip_3.Size = new Size(0x163, 0x19);
            this.toolStrip_3.TabIndex = 2;
            this.toolStrip_3.Text = "toolStrip1";
            this.toolStripButton_13.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_13.Image = (Image) manager.GetObject("toolBtnAddDocOutStatus.Image");
            this.toolStripButton_13.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_13.Name = "toolBtnAddDocOutStatus";
            this.toolStripButton_13.Size = new Size(0x17, 0x16);
            this.toolStripButton_13.Text = "Новый статус";
            this.toolStripButton_13.Click += new EventHandler(this.toolStripButton_13_Click);
            this.toolStripButton_14.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_14.Image = (Image) manager.GetObject("toolBtnEditDocOutStatus.Image");
            this.toolStripButton_14.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_14.Name = "toolBtnEditDocOutStatus";
            this.toolStripButton_14.Size = new Size(0x17, 0x16);
            this.toolStripButton_14.Text = "Редактировать статус";
            this.toolStripButton_14.Click += new EventHandler(this.toolStripButton_14_Click);
            this.toolStripButton_15.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_15.Image = (Image) manager.GetObject("toolBtnDelDocOutStatus.Image");
            this.toolStripButton_15.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_15.Name = "toolBtnDelDocOutStatus";
            this.toolStripButton_15.Size = new Size(0x17, 0x16);
            this.toolStripButton_15.Text = "Удалить статус";
            this.toolStripButton_15.Click += new EventHandler(this.toolStripButton_15_Click);
            this.tabPage_4.Controls.Add(this.richTextBox_0);
            this.tabPage_4.Controls.Add(this.label_2);
            this.tabPage_4.Controls.Add(this.dateTimePicker_2);
            this.tabPage_4.Controls.Add(this.label_3);
            this.tabPage_4.Controls.Add(this.textBox_0);
            this.tabPage_4.Controls.Add(this.label_4);
            this.tabPage_4.Controls.Add(this.toolStrip_4);
            this.tabPage_4.Location = new Point(4, 0x16);
            this.tabPage_4.Name = "tabPageContractor";
            this.tabPage_4.Padding = new Padding(3);
            this.tabPage_4.Size = new Size(0x30d, 0xad);
            this.tabPage_4.TabIndex = 4;
            this.tabPage_4.Text = "Договор на ТП";
            this.tabPage_4.UseVisualStyleBackColor = true;
            this.richTextBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.richTextBox_0.BackColor = SystemColors.Window;
            this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_1, "tTC_Doc.Body", true));
            this.richTextBox_0.Location = new Point(30, 0x45);
            this.richTextBox_0.Name = "richTextBox1";
            this.richTextBox_0.ReadOnly = true;
            this.richTextBox_0.Size = new Size(0x2ec, 0x68);
            this.richTextBox_0.TabIndex = 9;
            this.richTextBox_0.Text = "";
            this.dataSetTechConnection_1.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(0x27, 0x34);
            this.label_2.Name = "label5";
            this.label_2.Size = new Size(70, 13);
            this.label_2.TabIndex = 8;
            this.label_2.Text = "Содержание";
            this.dateTimePicker_2.DataBindings.Add(new Binding("Value", this.dataSetTechConnection_1, "tTC_Doc.dateDoc", true));
            this.dateTimePicker_2.Enabled = false;
            this.dateTimePicker_2.Location = new Point(0x106, 0x1d);
            this.dateTimePicker_2.Name = "dateTimePicker1";
            this.dateTimePicker_2.Size = new Size(200, 20);
            this.dateTimePicker_2.TabIndex = 7;
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(0x103, 13);
            this.label_3.Name = "label4";
            this.label_3.Size = new Size(0x21, 13);
            this.label_3.TabIndex = 6;
            this.label_3.Text = "Дата";
            this.textBox_0.BackColor = SystemColors.Window;
            this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSetTechConnection_1, "tTC_Doc.numDoc", true));
            this.textBox_0.Location = new Point(30, 0x1d);
            this.textBox_0.Name = "textBox1";
            this.textBox_0.ReadOnly = true;
            this.textBox_0.Size = new Size(0xd4, 20);
            this.textBox_0.TabIndex = 5;
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(0x27, 13);
            this.label_4.Name = "label3";
            this.label_4.Size = new Size(0x29, 13);
            this.label_4.TabIndex = 4;
            this.label_4.Text = "Номер";
            this.toolStrip_4.Dock = DockStyle.Left;
            this.toolStrip_4.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.toolStripButton_17, this.toolStripButton_18, this.toolStripButton_19 };
            this.toolStrip_4.Items.AddRange(itemArray5);
            this.toolStrip_4.Location = new Point(3, 3);
            this.toolStrip_4.Name = "toolStrip1";
            this.toolStrip_4.Size = new Size(0x18, 0xa7);
            this.toolStrip_4.TabIndex = 3;
            this.toolStrip_4.Text = "toolStrip1";
            this.toolStripButton_17.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_17.Image = (Image) manager.GetObject("toolBtnAddContractor.Image");
            this.toolStripButton_17.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_17.Name = "toolBtnAddContractor";
            this.toolStripButton_17.Size = new Size(0x15, 20);
            this.toolStripButton_17.Text = "Новый документ";
            this.toolStripButton_17.Click += new EventHandler(this.toolStripButton_17_Click);
            this.toolStripButton_18.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_18.Image = (Image) manager.GetObject("toolBtnEditContractor.Image");
            this.toolStripButton_18.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_18.Name = "toolBtnEditContractor";
            this.toolStripButton_18.Size = new Size(0x15, 20);
            this.toolStripButton_18.Text = "Редактировать документ";
            this.toolStripButton_18.Click += new EventHandler(this.toolStripButton_18_Click);
            this.toolStripButton_19.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_19.Image = (Image) manager.GetObject("toolBtnDelContractor.Image");
            this.toolStripButton_19.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_19.Name = "toolBtnDelContractor";
            this.toolStripButton_19.Size = new Size(0x15, 20);
            this.toolStripButton_19.Text = "Удалить документ";
            this.toolStripButton_19.Click += new EventHandler(this.toolStripButton_19_Click);
            this.tabPage_5.Controls.Add(this.splitContainer_4);
            this.tabPage_5.Location = new Point(4, 0x16);
            this.tabPage_5.Name = "tabPageActs";
            this.tabPage_5.Padding = new Padding(3);
            this.tabPage_5.Size = new Size(0x30d, 0xad);
            this.tabPage_5.TabIndex = 5;
            this.tabPage_5.Text = "Акты";
            this.tabPage_5.UseVisualStyleBackColor = true;
            this.splitContainer_4.Dock = DockStyle.Fill;
            this.splitContainer_4.Location = new Point(3, 3);
            this.splitContainer_4.Name = "splitContainerActs";
            this.splitContainer_4.Panel1.Controls.Add(this.dataGridViewExcelFilter_8);
            this.splitContainer_4.Panel1.Controls.Add(this.toolStrip_5);
            this.splitContainer_4.Panel2.Controls.Add(this.dataGridViewExcelFilter_7);
            this.splitContainer_4.Size = new Size(0x307, 0xa7);
            this.splitContainer_4.SplitterDistance = 0x1f9;
            this.splitContainer_4.TabIndex = 0;
            this.dataGridViewExcelFilter_8.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_8.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_8.AutoGenerateColumns = false;
            style29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style29.BackColor = SystemColors.Control;
            style29.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style29.ForeColor = SystemColors.WindowText;
            style29.SelectionBackColor = SystemColors.Highlight;
            style29.SelectionForeColor = SystemColors.HighlightText;
            style29.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_8.ColumnHeadersDefaultCellStyle = style29;
            this.dataGridViewExcelFilter_8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray8 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_111, this.dataGridViewTextBoxColumn_112, this.dataGridViewTextBoxColumn_113, this.dataGridViewTextBoxColumn_114, this.dataGridViewTextBoxColumn_115, this.dataGridViewTextBoxColumn_116, this.dataGridViewTextBoxColumn_117 };
            this.dataGridViewExcelFilter_8.Columns.AddRange(columnArray8);
            this.dataGridViewExcelFilter_8.DataSource = this.bindingSource_7;
            style30.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style30.BackColor = SystemColors.Window;
            style30.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style30.ForeColor = SystemColors.ControlText;
            style30.SelectionBackColor = SystemColors.Highlight;
            style30.SelectionForeColor = SystemColors.HighlightText;
            style30.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_8.DefaultCellStyle = style30;
            this.dataGridViewExcelFilter_8.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_8.Location = new Point(30, 0);
            this.dataGridViewExcelFilter_8.Name = "dgvActs";
            this.dataGridViewExcelFilter_8.ReadOnly = true;
            style31.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style31.BackColor = SystemColors.Control;
            style31.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style31.ForeColor = SystemColors.WindowText;
            style31.SelectionBackColor = SystemColors.Highlight;
            style31.SelectionForeColor = SystemColors.HighlightText;
            style31.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_8.RowHeadersDefaultCellStyle = style31;
            this.dataGridViewExcelFilter_8.Size = new Size(0x1db, 0xa7);
            this.dataGridViewExcelFilter_8.TabIndex = 4;
            this.dataGridViewExcelFilter_8.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_8_CellDoubleClick);
            this.dataGridViewTextBoxColumn_111.DataPropertyName = "typeDocName";
            this.dataGridViewTextBoxColumn_111.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn_111.Name = "typeDocNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_111.ReadOnly = true;
            this.dataGridViewTextBoxColumn_111.Width = 150;
            this.dataGridViewTextBoxColumn_112.DataPropertyName = "numDoc";
            this.dataGridViewTextBoxColumn_112.HeaderText = "№ акта";
            this.dataGridViewTextBoxColumn_112.Name = "numDocDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_112.ReadOnly = true;
            this.dataGridViewTextBoxColumn_113.DataPropertyName = "dateDoc";
            style32.Format = "d";
            style32.NullValue = null;
            this.dataGridViewTextBoxColumn_113.DefaultCellStyle = style32;
            this.dataGridViewTextBoxColumn_113.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_113.Name = "dateDocDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_113.ReadOnly = true;
            this.dataGridViewTextBoxColumn_114.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_114.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_114.Name = "commentDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_114.ReadOnly = true;
            this.dataGridViewTextBoxColumn_115.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_115.HeaderText = "id";
            this.dataGridViewTextBoxColumn_115.Name = "idActDgvColumn";
            this.dataGridViewTextBoxColumn_115.ReadOnly = true;
            this.dataGridViewTextBoxColumn_115.Visible = false;
            this.dataGridViewTextBoxColumn_116.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn_116.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn_116.Name = "typeActDgvColumn";
            this.dataGridViewTextBoxColumn_116.ReadOnly = true;
            this.dataGridViewTextBoxColumn_116.Visible = false;
            this.dataGridViewTextBoxColumn_117.DataPropertyName = "Body";
            this.dataGridViewTextBoxColumn_117.HeaderText = "Body";
            this.dataGridViewTextBoxColumn_117.Name = "bodyDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_117.ReadOnly = true;
            this.dataGridViewTextBoxColumn_117.Visible = false;
            this.bindingSource_7.DataMember = "vTC_Doc";
            this.bindingSource_7.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_7.CurrentChanged += new EventHandler(this.bindingSource_7_CurrentChanged);
            this.toolStrip_5.Dock = DockStyle.Left;
            this.toolStrip_5.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray6 = new ToolStripItem[] { this.toolStripDropDownButton_0, this.toolStripButton_21, this.toolStripButton_22, this.toolStripSeparator_4, this.toolStripButton_23 };
            this.toolStrip_5.Items.AddRange(itemArray6);
            this.toolStrip_5.Location = new Point(0, 0);
            this.toolStrip_5.Name = "toolStripActs";
            this.toolStrip_5.Size = new Size(30, 0xa7);
            this.toolStrip_5.TabIndex = 3;
            this.toolStrip_5.Text = "toolStrip1";
            this.toolStripDropDownButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripItem[] itemArray7 = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2, this.toolStripMenuItem_3, this.toolStripMenuItem_4 };
            this.toolStripDropDownButton_0.DropDownItems.AddRange(itemArray7);
            this.toolStripDropDownButton_0.Image = (Image) manager.GetObject("toolBtnAddAct.Image");
            this.toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripDropDownButton_0.Name = "toolBtnAddAct";
            this.toolStripDropDownButton_0.Size = new Size(0x1b, 20);
            this.toolStripDropDownButton_0.Text = "Новый документ";
            this.toolStripDropDownButton_0.Click += new EventHandler(this.toolStripDropDownButton_0_Click);
            this.toolStripMenuItem_0.Name = "toolBtnAddActElectricalInspection";
            this.toolStripMenuItem_0.Size = new Size(0x159, 0x16);
            this.toolStripMenuItem_0.Text = "Акт осмотра электроустановки";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
            this.toolStripMenuItem_1.Name = "toolBtnAddActPerformingTU";
            this.toolStripMenuItem_1.Size = new Size(0x159, 0x16);
            this.toolStripMenuItem_1.Text = "Акт о выполнении ТУ";
            this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
            this.toolStripMenuItem_2.Name = "toolBtnAddActTC";
            this.toolStripMenuItem_2.Size = new Size(0x159, 0x16);
            this.toolStripMenuItem_2.Text = "Акт о технологическом присоединении";
            this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripMenuItem_2_Click);
            this.toolStripMenuItem_3.Name = "toolBtnAddActRBP";
            this.toolStripMenuItem_3.Size = new Size(0x159, 0x16);
            this.toolStripMenuItem_3.Text = "Акт разграничения балансовой принадлежности";
            this.toolStripMenuItem_3.Click += new EventHandler(this.toolStripMenuItem_3_Click);
            this.toolStripMenuItem_4.Name = "toolBtnAddActOperRep";
            this.toolStripMenuItem_4.Size = new Size(0x159, 0x16);
            this.toolStripMenuItem_4.Text = "Акт эксплатационной ответственности";
            this.toolStripMenuItem_4.Click += new EventHandler(this.toolStripMenuItem_4_Click);
            this.toolStripButton_21.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_21.Image = (Image) manager.GetObject("toolBtnEditAct.Image");
            this.toolStripButton_21.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_21.Name = "toolBtnEditAct";
            this.toolStripButton_21.Size = new Size(0x1b, 20);
            this.toolStripButton_21.Text = "Редактировать документ";
            this.toolStripButton_21.Click += new EventHandler(this.toolStripButton_21_Click);
            this.toolStripButton_22.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_22.Image = (Image) manager.GetObject("toolBtnDelAct.Image");
            this.toolStripButton_22.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_22.Name = "toolBtnDelAct";
            this.toolStripButton_22.Size = new Size(0x1b, 20);
            this.toolStripButton_22.Text = "Удалить документ";
            this.toolStripButton_22.Click += new EventHandler(this.toolStripButton_22_Click);
            this.toolStripSeparator_4.Name = "toolStripSeparator5";
            this.toolStripSeparator_4.Size = new Size(0x1b, 6);
            this.toolStripButton_23.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_23.Image = (Image) manager.GetObject("toolBtnPrintAct.Image");
            this.toolStripButton_23.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_23.Name = "toolBtnPrintAct";
            this.toolStripButton_23.Size = new Size(0x1b, 20);
            this.toolStripButton_23.Text = "Печать";
            this.toolStripButton_23.Click += new EventHandler(this.toolStripButton_23_Click);
            this.dataGridViewExcelFilter_7.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_7.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_7.AllowUserToResizeColumns = false;
            this.dataGridViewExcelFilter_7.AllowUserToResizeRows = false;
            this.dataGridViewExcelFilter_7.AutoGenerateColumns = false;
            style33.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style33.BackColor = SystemColors.Control;
            style33.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style33.ForeColor = SystemColors.WindowText;
            style33.SelectionBackColor = SystemColors.Highlight;
            style33.SelectionForeColor = SystemColors.HighlightText;
            style33.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_7.ColumnHeadersDefaultCellStyle = style33;
            this.dataGridViewExcelFilter_7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray9 = new DataGridViewColumn[] { this.dataGridViewLinkColumn_1, this.dataGridViewTextBoxColumn_45, this.dataGridViewImageColumnNotNull_1 };
            this.dataGridViewExcelFilter_7.Columns.AddRange(columnArray9);
            this.dataGridViewExcelFilter_7.DataSource = this.bindingSource_8;
            style34.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style34.BackColor = SystemColors.Window;
            style34.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style34.ForeColor = SystemColors.ControlText;
            style34.SelectionBackColor = SystemColors.Highlight;
            style34.SelectionForeColor = SystemColors.HighlightText;
            style34.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_7.DefaultCellStyle = style34;
            this.dataGridViewExcelFilter_7.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_7.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewExcelFilter_7.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_7.Name = "dgvActsFiles";
            this.dataGridViewExcelFilter_7.ReadOnly = true;
            style35.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style35.BackColor = SystemColors.Control;
            style35.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style35.ForeColor = SystemColors.WindowText;
            style35.SelectionBackColor = SystemColors.Highlight;
            style35.SelectionForeColor = SystemColors.HighlightText;
            style35.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_7.RowHeadersDefaultCellStyle = style35;
            this.dataGridViewExcelFilter_7.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_7.Size = new Size(0x10a, 0xa7);
            this.dataGridViewExcelFilter_7.TabIndex = 8;
            this.dataGridViewExcelFilter_7.VirtualMode = true;
            this.dataGridViewExcelFilter_7.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_7_CellContentClick);
            this.dataGridViewExcelFilter_7.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dataGridViewExcelFilter_7_CellValueNeeded);
            this.dataGridViewLinkColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewLinkColumn_1.DataPropertyName = "FileName";
            this.dataGridViewLinkColumn_1.HeaderText = "Файлы";
            this.dataGridViewLinkColumn_1.Name = "fileNameActdgvColumn";
            this.dataGridViewLinkColumn_1.ReadOnly = true;
            this.dataGridViewLinkColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewLinkColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn_45.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_45.HeaderText = "id";
            this.dataGridViewTextBoxColumn_45.Name = "idActFileDgvColumn";
            this.dataGridViewTextBoxColumn_45.ReadOnly = true;
            this.dataGridViewTextBoxColumn_45.Visible = false;
            style36.NullValue = null;
            this.dataGridViewImageColumnNotNull_1.DefaultCellStyle = style36;
            this.dataGridViewImageColumnNotNull_1.HeaderText = "";
            this.dataGridViewImageColumnNotNull_1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumnNotNull_1.Name = "imageActDgvColumn";
            this.dataGridViewImageColumnNotNull_1.ReadOnly = true;
            this.dataGridViewImageColumnNotNull_1.Width = 30;
            this.bindingSource_8.DataMember = "tTC_DocFile";
            this.bindingSource_8.DataSource = this.dataSet_0;
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dataTable_0, this.dataTable_1 };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1 };
            this.dataTable_0.Columns.AddRange(columns);
            this.dataTable_0.TableName = "tTC_DocFile";
            this.dataColumn_0.ColumnName = "id";
            this.dataColumn_0.DataType = typeof(int);
            this.dataColumn_1.ColumnName = "FileName";
            DataColumn[] columnArray11 = new DataColumn[] { this.dataColumn_2, this.dataColumn_3 };
            this.dataTable_1.Columns.AddRange(columnArray11);
            this.dataTable_1.TableName = "tAbnObjDoc_File";
            this.dataColumn_2.ColumnName = "id";
            this.dataColumn_3.ColumnName = "FileName";
            this.tabPage_6.Controls.Add(this.dataGridViewExcelFilter_9);
            this.tabPage_6.Controls.Add(this.toolStrip_6);
            this.tabPage_6.Location = new Point(4, 0x16);
            this.tabPage_6.Name = "tpMemorandum";
            this.tabPage_6.Padding = new Padding(3);
            this.tabPage_6.Size = new Size(0x30d, 0xad);
            this.tabPage_6.TabIndex = 6;
            this.tabPage_6.Text = "Осущ. тех. присоединения";
            this.tabPage_6.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_9.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_9.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_9.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_9.set_AllowUserToVisibleColumns(false);
            this.dataGridViewExcelFilter_9.AutoGenerateColumns = false;
            style37.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style37.BackColor = SystemColors.Control;
            style37.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style37.ForeColor = SystemColors.WindowText;
            style37.SelectionBackColor = SystemColors.Highlight;
            style37.SelectionForeColor = SystemColors.HighlightText;
            style37.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_9.ColumnHeadersDefaultCellStyle = style37;
            this.dataGridViewExcelFilter_9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray12 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_125, this.dataGridViewTextBoxColumn_126, this.dataGridViewTextBoxColumn_127, this.dataGridViewTextBoxColumn_128, this.dataGridViewTextBoxColumn_129, this.dataGridViewTextBoxColumn_130, this.dataGridViewTextBoxColumn_131, this.dataGridViewTextBoxColumn_132, this.dataGridViewTextBoxColumn_133, this.dataGridViewTextBoxColumn_134, this.dataGridViewTextBoxColumn_135, this.dataGridViewTextBoxColumn_136, this.dataGridViewTextBoxColumn_137, this.dataGridViewTextBoxColumn_138, this.dataGridViewTextBoxColumn_139 };
            this.dataGridViewExcelFilter_9.Columns.AddRange(columnArray12);
            this.dataGridViewExcelFilter_9.DataSource = this.bindingSource_9;
            style38.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style38.BackColor = SystemColors.Window;
            style38.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style38.ForeColor = SystemColors.ControlText;
            style38.SelectionBackColor = SystemColors.Highlight;
            style38.SelectionForeColor = SystemColors.HighlightText;
            style38.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_9.DefaultCellStyle = style38;
            this.dataGridViewExcelFilter_9.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_9.Location = new Point(0x24, 3);
            this.dataGridViewExcelFilter_9.Name = "dgvMemorandum";
            this.dataGridViewExcelFilter_9.ReadOnly = true;
            style39.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style39.BackColor = SystemColors.Control;
            style39.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style39.ForeColor = SystemColors.WindowText;
            style39.SelectionBackColor = SystemColors.Highlight;
            style39.SelectionForeColor = SystemColors.HighlightText;
            style39.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_9.RowHeadersDefaultCellStyle = style39;
            this.dataGridViewExcelFilter_9.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_9.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_9.Size = new Size(0x2e6, 0xa7);
            this.dataGridViewExcelFilter_9.TabIndex = 5;
            this.dataGridViewExcelFilter_9.VirtualMode = true;
            this.dataGridViewExcelFilter_9.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_9_CellDoubleClick);
            this.dataGridViewExcelFilter_9.DataError += new DataGridViewDataErrorEventHandler(this.dataGridViewExcelFilter_9_DataError);
            this.dataGridViewTextBoxColumn_125.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_125.HeaderText = "id";
            this.dataGridViewTextBoxColumn_125.Name = "idDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_125.ReadOnly = true;
            this.dataGridViewTextBoxColumn_125.Visible = false;
            this.dataGridViewTextBoxColumn_126.DataPropertyName = "idTehConnect";
            this.dataGridViewTextBoxColumn_126.HeaderText = "idTehConnect";
            this.dataGridViewTextBoxColumn_126.Name = "idTehConnectDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_126.ReadOnly = true;
            this.dataGridViewTextBoxColumn_126.Visible = false;
            this.dataGridViewTextBoxColumn_127.DataPropertyName = "idWorker";
            this.dataGridViewTextBoxColumn_127.HeaderText = "idWorker";
            this.dataGridViewTextBoxColumn_127.Name = "idWorkerDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_127.ReadOnly = true;
            this.dataGridViewTextBoxColumn_127.Visible = false;
            this.dataGridViewTextBoxColumn_128.DataPropertyName = "UniversalID";
            this.dataGridViewTextBoxColumn_128.HeaderText = "UniversalID";
            this.dataGridViewTextBoxColumn_128.Name = "universalIDDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_128.ReadOnly = true;
            this.dataGridViewTextBoxColumn_128.Visible = false;
            this.dataGridViewTextBoxColumn_129.DataPropertyName = "ctb_InheritedID";
            this.dataGridViewTextBoxColumn_129.HeaderText = "ctb_InheritedID";
            this.dataGridViewTextBoxColumn_129.Name = "ctbInheritedIDDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_129.ReadOnly = true;
            this.dataGridViewTextBoxColumn_129.Visible = false;
            this.dataGridViewTextBoxColumn_130.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn_130.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn_130.Name = "statusDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_130.ReadOnly = true;
            this.dataGridViewTextBoxColumn_130.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_131.DataPropertyName = "StatusOrder";
            this.dataGridViewTextBoxColumn_131.HeaderText = "Статус поручения";
            this.dataGridViewTextBoxColumn_131.Name = "statusOrderDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_131.ReadOnly = true;
            this.dataGridViewTextBoxColumn_131.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_131.Width = 150;
            this.dataGridViewTextBoxColumn_132.DataPropertyName = "SignDate";
            this.dataGridViewTextBoxColumn_132.HeaderText = "Дата подписания";
            this.dataGridViewTextBoxColumn_132.Name = "signDateDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_132.ReadOnly = true;
            this.dataGridViewTextBoxColumn_133.DataPropertyName = "RgNum";
            this.dataGridViewTextBoxColumn_133.HeaderText = "Рег. номер";
            this.dataGridViewTextBoxColumn_133.Name = "rgNumDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_133.ReadOnly = true;
            this.dataGridViewTextBoxColumn_134.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_134.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn_134.HeaderText = "По вопросу";
            this.dataGridViewTextBoxColumn_134.Name = "subjectDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_134.ReadOnly = true;
            this.dataGridViewTextBoxColumn_135.DataPropertyName = "Body_C";
            this.dataGridViewTextBoxColumn_135.HeaderText = "Body_C";
            this.dataGridViewTextBoxColumn_135.Name = "bodyCDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_135.ReadOnly = true;
            this.dataGridViewTextBoxColumn_135.Visible = false;
            this.dataGridViewTextBoxColumn_136.DataPropertyName = "RespDate";
            this.dataGridViewTextBoxColumn_136.HeaderText = "RespDate";
            this.dataGridViewTextBoxColumn_136.Name = "respDateDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_136.ReadOnly = true;
            this.dataGridViewTextBoxColumn_136.Visible = false;
            this.dataGridViewTextBoxColumn_137.DataPropertyName = "RespNum";
            this.dataGridViewTextBoxColumn_137.HeaderText = "RespNum";
            this.dataGridViewTextBoxColumn_137.Name = "respNumDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_137.ReadOnly = true;
            this.dataGridViewTextBoxColumn_137.Visible = false;
            this.dataGridViewTextBoxColumn_138.DataPropertyName = "CorrName";
            this.dataGridViewTextBoxColumn_138.HeaderText = "CorrName";
            this.dataGridViewTextBoxColumn_138.Name = "corrNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_138.ReadOnly = true;
            this.dataGridViewTextBoxColumn_138.Visible = false;
            this.dataGridViewTextBoxColumn_139.DataPropertyName = "ctbDateCreate";
            this.dataGridViewTextBoxColumn_139.HeaderText = "ctbDateCreate";
            this.dataGridViewTextBoxColumn_139.Name = "ctbDateCreateDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_139.ReadOnly = true;
            this.dataGridViewTextBoxColumn_139.Visible = false;
            this.bindingSource_9.DataMember = "vJ_Memorandum";
            this.bindingSource_9.DataSource = this.dataSetTechConnection_0;
            this.toolStrip_6.Dock = DockStyle.Left;
            this.toolStrip_6.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray8 = new ToolStripItem[] { this.toolStripSplitButton_0, this.toolStripButton_27, this.toolStripButton_26, this.toolStripButton_24, this.toolStripSeparator_5, this.toolStripButton_25 };
            this.toolStrip_6.Items.AddRange(itemArray8);
            this.toolStrip_6.Location = new Point(3, 3);
            this.toolStrip_6.Name = "tsbMemorandum";
            this.toolStrip_6.Size = new Size(0x21, 0xa7);
            this.toolStrip_6.TabIndex = 4;
            this.toolStrip_6.Text = "toolStrip1";
            this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripItem[] itemArray9 = new ToolStripItem[] { this.toolStripMenuItem_5, this.toolStripMenuItem_6 };
            this.toolStripSplitButton_0.DropDownItems.AddRange(itemArray9);
            this.toolStripSplitButton_0.Image = Resources.ElementAdd;
            this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripSplitButton_0.Name = "Добавить";
            this.toolStripSplitButton_0.Size = new Size(30, 20);
            this.toolStripSplitButton_0.Text = "Добавить";
            this.toolStripMenuItem_5.Name = "tsmiSendMemorandum";
            this.toolStripMenuItem_5.Size = new Size(0xa3, 0x16);
            this.toolStripMenuItem_5.Text = "Новый";
            this.toolStripMenuItem_5.Click += new EventHandler(this.toolStripMenuItem_5_Click);
            this.toolStripMenuItem_6.Name = "tsmiExistsMemorandum";
            this.toolStripMenuItem_6.Size = new Size(0xa3, 0x16);
            this.toolStripMenuItem_6.Text = "Существующий";
            this.toolStripMenuItem_6.Click += new EventHandler(this.toolStripMenuItem_6_Click);
            this.toolStripButton_27.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_27.Image = Resources.ElementEdit;
            this.toolStripButton_27.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_27.Name = "tsbEdit";
            this.toolStripButton_27.Size = new Size(30, 20);
            this.toolStripButton_27.Text = "Редактирование";
            this.toolStripButton_27.Click += new EventHandler(this.toolStripButton_27_Click);
            this.toolStripButton_26.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_26.Image = Resources.ElementInformation;
            this.toolStripButton_26.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_26.Name = "tsbView";
            this.toolStripButton_26.Size = new Size(30, 20);
            this.toolStripButton_26.Text = "Открыть";
            this.toolStripButton_26.Click += new EventHandler(this.toolStripButton_26_Click);
            this.toolStripButton_24.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_24.Image = (Image) manager.GetObject("toolStripButton3.Image");
            this.toolStripButton_24.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_24.Name = "toolStripButton3";
            this.toolStripButton_24.Size = new Size(30, 20);
            this.toolStripButton_24.Text = "Удалить";
            this.toolStripButton_24.Click += new EventHandler(this.toolStripButton_24_Click);
            this.toolStripSeparator_5.Name = "toolStripSeparator6";
            this.toolStripSeparator_5.Size = new Size(30, 6);
            this.toolStripButton_25.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_25.Image = Resources.refresh_16;
            this.toolStripButton_25.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_25.Name = "tsbRefresh";
            this.toolStripButton_25.Size = new Size(30, 20);
            this.toolStripButton_25.Text = "Обновить";
            this.toolStripButton_25.Click += new EventHandler(this.toolStripButton_25_Click);
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "NumDateIn";
            style40.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_0.DefaultCellStyle = style40;
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "№, дата входящего";
            this.dataGridViewFilterTextBoxColumn_0.Name = "dataGridViewFilterTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "numDoc";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "№ ТУ";
            this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewFilterTextBoxColumn2";
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "dateDoc";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Дата выдачи";
            this.dataGridViewFilterTextBoxColumn_2.Name = "dataGridViewFilterTextBoxColumn3";
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "body";
            style41.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.DefaultCellStyle = style41;
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Содержание";
            this.dataGridViewFilterTextBoxColumn_3.Name = "dataGridViewFilterTextBoxColumn4";
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "nameAbn";
            style42.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_4.DefaultCellStyle = style42;
            this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Потребитель";
            this.dataGridViewFilterTextBoxColumn_4.Name = "dataGridViewFilterTextBoxColumn5";
            this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "nameObj";
            this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn_5.Name = "dataGridViewFilterTextBoxColumn6";
            this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "address";
            this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Адрес";
            this.dataGridViewFilterTextBoxColumn_6.Name = "dataGridViewFilterTextBoxColumn7";
            this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_46.DataPropertyName = "addressFull";
            this.dataGridViewTextBoxColumn_46.HeaderText = "addressFull";
            this.dataGridViewTextBoxColumn_46.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn_46.Visible = false;
            this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "Power";
            this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Существующая мощность";
            this.dataGridViewFilterTextBoxColumn_7.Name = "dataGridViewFilterTextBoxColumn8";
            this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "PowerAdd";
            this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Доп мощность";
            this.dataGridViewFilterTextBoxColumn_8.Name = "dataGridViewFilterTextBoxColumn9";
            this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "PowerSum";
            this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Максимальная мощность";
            this.dataGridViewFilterTextBoxColumn_9.Name = "dataGridViewFilterTextBoxColumn10";
            this.dataGridViewFilterTextBoxColumn_9.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "VoltageLevel";
            this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Ур-нь напр-ния";
            this.dataGridViewFilterTextBoxColumn_10.Name = "dataGridViewFilterTextBoxColumn11";
            this.dataGridViewFilterTextBoxColumn_10.Width = 70;
            this.dataGridViewTextBoxColumn_47.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn_47.HeaderText = "Category";
            this.dataGridViewTextBoxColumn_47.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn_47.Visible = false;
            this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "CategoryName";
            this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Категор. элек-ния";
            this.dataGridViewFilterTextBoxColumn_11.Name = "dataGridViewFilterTextBoxColumn12";
            this.dataGridViewFilterTextBoxColumn_11.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_48.DataPropertyName = "idSchmObj";
            this.dataGridViewTextBoxColumn_48.HeaderText = "idSchmObj";
            this.dataGridViewTextBoxColumn_48.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn_48.Visible = false;
            this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "numContractor";
            this.dataGridViewFilterTextBoxColumn_12.HeaderText = "№ договора";
            this.dataGridViewFilterTextBoxColumn_12.Name = "dataGridViewFilterTextBoxColumn13";
            this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "dateContractor";
            this.dataGridViewFilterTextBoxColumn_13.HeaderText = "Дата договора";
            this.dataGridViewFilterTextBoxColumn_13.Name = "dataGridViewFilterTextBoxColumn14";
            this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "PerformerFIO";
            this.dataGridViewFilterTextBoxColumn_14.HeaderText = "Исполнитель";
            this.dataGridViewFilterTextBoxColumn_14.Name = "dataGridViewFilterTextBoxColumn15";
            this.dataGridViewFilterTextBoxColumn_14.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_49.DataPropertyName = "NameDocOut";
            style43.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_49.DefaultCellStyle = style43;
            this.dataGridViewTextBoxColumn_49.HeaderText = "Выданные документы";
            this.dataGridViewTextBoxColumn_49.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn_50.DataPropertyName = "Performer";
            this.dataGridViewTextBoxColumn_50.HeaderText = "Performer";
            this.dataGridViewTextBoxColumn_50.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn_50.Visible = false;
            this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "SchmTP";
            style44.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_15.DefaultCellStyle = style44;
            this.dataGridViewFilterTextBoxColumn_15.HeaderText = "ТП";
            this.dataGridViewFilterTextBoxColumn_15.Name = "dataGridViewFilterTextBoxColumn16";
            this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "SchmCP";
            style45.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_16.DefaultCellStyle = style45;
            this.dataGridViewFilterTextBoxColumn_16.HeaderText = "ЦП";
            this.dataGridViewFilterTextBoxColumn_16.Name = "dataGridViewFilterTextBoxColumn17";
            this.dataGridViewFilterTextBoxColumn_16.Width = 150;
            this.dataGridViewTextBoxColumn_51.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_51.HeaderText = "id";
            this.dataGridViewTextBoxColumn_51.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn_51.Visible = false;
            this.dataGridViewTextBoxColumn_52.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_52.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_52.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn_52.Visible = false;
            this.dataGridViewTextBoxColumn_53.DataPropertyName = "dateChange";
            this.dataGridViewTextBoxColumn_53.HeaderText = "dateChange";
            this.dataGridViewTextBoxColumn_53.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn_53.Visible = false;
            this.dataGridViewTextBoxColumn_54.DataPropertyName = "idTemplate";
            this.dataGridViewTextBoxColumn_54.HeaderText = "idTemplate";
            this.dataGridViewTextBoxColumn_54.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn_54.Visible = false;
            this.dataGridViewTextBoxColumn_55.DataPropertyName = "numDateIn";
            style46.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_55.DefaultCellStyle = style46;
            this.dataGridViewTextBoxColumn_55.HeaderText = "№, дата вход.";
            this.dataGridViewTextBoxColumn_55.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn_55.Width = 80;
            this.dataGridViewTextBoxColumn_56.DataPropertyName = "numDoc";
            this.dataGridViewTextBoxColumn_56.HeaderText = "numDoc";
            this.dataGridViewTextBoxColumn_56.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn_56.Visible = false;
            this.dataGridViewTextBoxColumn_57.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_57.HeaderText = "id";
            this.dataGridViewTextBoxColumn_57.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn_57.Visible = false;
            this.dataGridViewTextBoxColumn_58.DataPropertyName = "dateDoc";
            this.dataGridViewTextBoxColumn_58.HeaderText = "Дата получения";
            this.dataGridViewTextBoxColumn_58.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn_58.Width = 80;
            this.dataGridViewTextBoxColumn_59.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn_59.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn_59.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn_59.Visible = false;
            this.dataGridViewTextBoxColumn_60.DataPropertyName = "numIn";
            this.dataGridViewTextBoxColumn_60.HeaderText = "numIn";
            this.dataGridViewTextBoxColumn_60.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn_60.Visible = false;
            this.dataGridViewTextBoxColumn_61.DataPropertyName = "dateIn";
            this.dataGridViewTextBoxColumn_61.HeaderText = "dateIn";
            this.dataGridViewTextBoxColumn_61.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn_61.Visible = false;
            this.dataGridViewTextBoxColumn_62.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_62.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_62.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn_62.Visible = false;
            this.dataGridViewTextBoxColumn_63.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_63.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_63.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn_63.Visible = false;
            this.dataGridViewTextBoxColumn_64.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_64.DataPropertyName = "body";
            style47.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_64.DefaultCellStyle = style47;
            this.dataGridViewTextBoxColumn_64.HeaderText = "Тело письма";
            this.dataGridViewTextBoxColumn_64.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn_65.DataPropertyName = "PowerCurrent";
            this.dataGridViewTextBoxColumn_65.HeaderText = "Текущая мощность";
            this.dataGridViewTextBoxColumn_65.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn_65.Width = 70;
            this.dataGridViewTextBoxColumn_66.DataPropertyName = "PowerAdd";
            this.dataGridViewTextBoxColumn_66.HeaderText = "Доп мощность";
            this.dataGridViewTextBoxColumn_66.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn_66.Width = 70;
            this.dataGridViewTextBoxColumn_67.DataPropertyName = "Power";
            this.dataGridViewTextBoxColumn_67.HeaderText = "Суммарная мощность";
            this.dataGridViewTextBoxColumn_67.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn_67.Width = 70;
            this.dataGridViewTextBoxColumn_68.DataPropertyName = "VoltageName";
            this.dataGridViewTextBoxColumn_68.HeaderText = "Напряжение";
            this.dataGridViewTextBoxColumn_68.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn_68.Width = 70;
            this.dataGridViewTextBoxColumn_69.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_69.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_69.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn_69.Width = 70;
            this.dataGridViewTextBoxColumn_70.DataPropertyName = "VoltageLevel";
            this.dataGridViewTextBoxColumn_70.HeaderText = "VoltageLevel";
            this.dataGridViewTextBoxColumn_70.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn_70.Visible = false;
            this.dataGridViewTextBoxColumn_71.DataPropertyName = "VoltageValue";
            this.dataGridViewTextBoxColumn_71.HeaderText = "VoltageValue";
            this.dataGridViewTextBoxColumn_71.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn_71.Visible = false;
            this.dataGridViewTextBoxColumn_72.DataPropertyName = "IdParent";
            this.dataGridViewTextBoxColumn_72.HeaderText = "IdParent";
            this.dataGridViewTextBoxColumn_72.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn_72.Visible = false;
            this.dataGridViewTextBoxColumn_73.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_73.DataPropertyName = "Work";
            style48.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_73.DefaultCellStyle = style48;
            this.dataGridViewTextBoxColumn_73.HeaderText = "Работы сетевой организации";
            this.dataGridViewTextBoxColumn_73.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn_73.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_74.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_74.HeaderText = "id";
            this.dataGridViewTextBoxColumn_74.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn_74.Visible = false;
            this.dataGridViewTextBoxColumn_75.DataPropertyName = "idTU";
            this.dataGridViewTextBoxColumn_75.HeaderText = "idTU";
            this.dataGridViewTextBoxColumn_75.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn_75.Visible = false;
            this.dataGridViewTextBoxColumn_76.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn_76.HeaderText = "num";
            this.dataGridViewTextBoxColumn_76.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn_76.Visible = false;
            this.dataGridViewTextBoxColumn_77.DataPropertyName = "TypeWork";
            this.dataGridViewTextBoxColumn_77.HeaderText = "TypeWork";
            this.dataGridViewTextBoxColumn_77.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn_77.Visible = false;
            this.dataGridViewTextBoxColumn_78.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_78.DataPropertyName = "Work";
            style49.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_78.DefaultCellStyle = style49;
            this.dataGridViewTextBoxColumn_78.HeaderText = "Работы заказчика";
            this.dataGridViewTextBoxColumn_78.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn_78.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_79.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_79.HeaderText = "id";
            this.dataGridViewTextBoxColumn_79.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn_79.Visible = false;
            this.dataGridViewTextBoxColumn_80.DataPropertyName = "idTU";
            this.dataGridViewTextBoxColumn_80.HeaderText = "idTU";
            this.dataGridViewTextBoxColumn_80.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn_80.Visible = false;
            this.dataGridViewTextBoxColumn_81.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn_81.HeaderText = "num";
            this.dataGridViewTextBoxColumn_81.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn_81.Visible = false;
            this.dataGridViewTextBoxColumn_82.DataPropertyName = "TypeWork";
            this.dataGridViewTextBoxColumn_82.HeaderText = "TypeWork";
            this.dataGridViewTextBoxColumn_82.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn_82.Visible = false;
            this.dataGridViewTextBoxColumn_83.DataPropertyName = "TypeDocNameOut";
            this.dataGridViewTextBoxColumn_83.HeaderText = "Документ";
            this.dataGridViewTextBoxColumn_83.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn_84.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_84.HeaderText = "id";
            this.dataGridViewTextBoxColumn_84.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn_84.Visible = false;
            this.dataGridViewTextBoxColumn_85.DataPropertyName = "numDateDocOut";
            this.dataGridViewTextBoxColumn_85.HeaderText = "numDateDocOut";
            this.dataGridViewTextBoxColumn_85.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn_85.Visible = false;
            this.dataGridViewTextBoxColumn_86.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_86.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_86.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn_86.Visible = false;
            this.dataGridViewTextBoxColumn_87.DataPropertyName = "numDocOut";
            this.dataGridViewTextBoxColumn_87.HeaderText = "№";
            this.dataGridViewTextBoxColumn_87.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn_88.DataPropertyName = "TypeDocOut";
            this.dataGridViewTextBoxColumn_88.HeaderText = "TypeDocOut";
            this.dataGridViewTextBoxColumn_88.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn_88.Visible = false;
            this.dataGridViewTextBoxColumn_89.DataPropertyName = "idDocOut";
            this.dataGridViewTextBoxColumn_89.HeaderText = "idDocOut";
            this.dataGridViewTextBoxColumn_89.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn_89.Visible = false;
            this.dataGridViewTextBoxColumn_90.DataPropertyName = "dateDocOut";
            style50.Format = "d";
            style50.NullValue = null;
            this.dataGridViewTextBoxColumn_90.DefaultCellStyle = style50;
            this.dataGridViewTextBoxColumn_90.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_90.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn_91.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn_91.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn_91.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn_91.Visible = false;
            this.dataGridViewTextBoxColumn_92.DataPropertyName = "BodyDocOut";
            this.dataGridViewTextBoxColumn_92.HeaderText = "Содержание";
            this.dataGridViewTextBoxColumn_92.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn_93.DataPropertyName = "SendModeName";
            this.dataGridViewTextBoxColumn_93.HeaderText = "Способ отправки";
            this.dataGridViewTextBoxColumn_93.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn_93.Visible = false;
            this.dataGridViewTextBoxColumn_94.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn_94.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn_94.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn_95.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn_95.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_95.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn_95.Visible = false;
            this.dataGridViewTextBoxColumn_96.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_96.HeaderText = "id";
            this.dataGridViewTextBoxColumn_96.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn_96.Visible = false;
            this.dataGridViewTextBoxColumn_97.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_97.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_97.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn_97.Visible = false;
            this.dataGridViewTextBoxColumn_98.DataPropertyName = "idStatus";
            this.dataGridViewTextBoxColumn_98.HeaderText = "idStatus";
            this.dataGridViewTextBoxColumn_98.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn_98.Visible = false;
            this.dataGridViewTextBoxColumn_99.DataPropertyName = "statusName";
            this.dataGridViewTextBoxColumn_99.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn_99.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn_99.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_100.DataPropertyName = "DateChange";
            style51.Format = "d";
            style51.NullValue = null;
            this.dataGridViewTextBoxColumn_100.DefaultCellStyle = style51;
            this.dataGridViewTextBoxColumn_100.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_100.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn_100.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_100.Width = 70;
            this.dataGridViewTextBoxColumn_101.DataPropertyName = "SendName";
            this.dataGridViewTextBoxColumn_101.HeaderText = "Способ отправки";
            this.dataGridViewTextBoxColumn_101.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn_102.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_102.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_102.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn_103.DataPropertyName = "typeDocName";
            this.dataGridViewTextBoxColumn_103.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn_103.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn_103.Width = 150;
            this.dataGridViewTextBoxColumn_104.DataPropertyName = "numDoc";
            this.dataGridViewTextBoxColumn_104.HeaderText = "№ акта";
            this.dataGridViewTextBoxColumn_104.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn_105.DataPropertyName = "dateDoc";
            this.dataGridViewTextBoxColumn_105.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_105.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn_106.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_106.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_106.Name = "dataGridViewTextBoxColumn67";
            this.dataGridViewTextBoxColumn_107.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_107.HeaderText = "id";
            this.dataGridViewTextBoxColumn_107.Name = "dataGridViewTextBoxColumn68";
            this.dataGridViewTextBoxColumn_107.Visible = false;
            this.dataGridViewTextBoxColumn_108.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn_108.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn_108.Name = "dataGridViewTextBoxColumn69";
            this.dataGridViewTextBoxColumn_108.Visible = false;
            this.dataGridViewTextBoxColumn_109.DataPropertyName = "Body";
            this.dataGridViewTextBoxColumn_109.HeaderText = "Body";
            this.dataGridViewTextBoxColumn_109.Name = "dataGridViewTextBoxColumn70";
            this.dataGridViewTextBoxColumn_109.Visible = false;
            this.dataGridViewTextBoxColumn_110.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_110.HeaderText = "id";
            this.dataGridViewTextBoxColumn_110.Name = "dataGridViewTextBoxColumn71";
            this.dataGridViewTextBoxColumn_110.Visible = false;
            this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork);
            this.backgroundWorker_0.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
            this.dataGridViewCheckBoxColumn_0.DataPropertyName = "IsCancelContract";
            this.dataGridViewCheckBoxColumn_0.HeaderText = "IsCancelContract";
            this.dataGridViewCheckBoxColumn_0.Name = "IsCancelContractDgvColumn";
            this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_140.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_140.HeaderText = "id";
            this.dataGridViewTextBoxColumn_140.Name = "idDgvColumn";
            this.dataGridViewTextBoxColumn_140.ReadOnly = true;
            this.dataGridViewTextBoxColumn_140.Visible = false;
            this.dataGridViewFilterTextBoxColumn_17.DataPropertyName = "NumDateIn";
            style52.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_17.DefaultCellStyle = style52;
            this.dataGridViewFilterTextBoxColumn_17.HeaderText = "№, дата входящего";
            this.dataGridViewFilterTextBoxColumn_17.Name = "numDateInDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_17.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_18.DataPropertyName = "numDoc";
            this.dataGridViewFilterTextBoxColumn_18.HeaderText = "№ ТУ";
            this.dataGridViewFilterTextBoxColumn_18.Name = "numDocDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_18.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_18.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_19.DataPropertyName = "dateDoc";
            this.dataGridViewFilterTextBoxColumn_19.HeaderText = "Дата выдачи";
            this.dataGridViewFilterTextBoxColumn_19.Name = "dateDocDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_19.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_19.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_141.DataPropertyName = "numIn";
            this.dataGridViewTextBoxColumn_141.HeaderText = "numIn";
            this.dataGridViewTextBoxColumn_141.Name = "numInDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_141.ReadOnly = true;
            this.dataGridViewTextBoxColumn_141.Visible = false;
            this.dataGridViewTextBoxColumn_142.DataPropertyName = "DateIn";
            this.dataGridViewTextBoxColumn_142.HeaderText = "DateIn";
            this.dataGridViewTextBoxColumn_142.Name = "dateInDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_142.ReadOnly = true;
            this.dataGridViewTextBoxColumn_142.Visible = false;
            this.dataGridViewFilterTextBoxColumn_20.DataPropertyName = "body";
            style53.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_20.DefaultCellStyle = style53;
            this.dataGridViewFilterTextBoxColumn_20.HeaderText = "Содержание";
            this.dataGridViewFilterTextBoxColumn_20.Name = "bodyDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_20.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_20.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_143.DataPropertyName = "idRequest";
            this.dataGridViewTextBoxColumn_143.HeaderText = "idRequest";
            this.dataGridViewTextBoxColumn_143.Name = "idRequestDgvColumn";
            this.dataGridViewTextBoxColumn_143.ReadOnly = true;
            this.dataGridViewTextBoxColumn_143.Visible = false;
            this.dataGridViewTextBoxColumn_144.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_144.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_144.Name = "idAbnDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_144.ReadOnly = true;
            this.dataGridViewTextBoxColumn_144.Visible = false;
            this.dataGridViewFilterTextBoxColumn_21.DataPropertyName = "nameAbn";
            style54.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_21.DefaultCellStyle = style54;
            this.dataGridViewFilterTextBoxColumn_21.HeaderText = "Потребитель";
            this.dataGridViewFilterTextBoxColumn_21.Name = "nameAbnDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_21.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_21.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_145.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_145.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_145.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_145.ReadOnly = true;
            this.dataGridViewTextBoxColumn_145.Visible = false;
            this.dataGridViewFilterTextBoxColumn_22.DataPropertyName = "nameObj";
            style55.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_22.DefaultCellStyle = style55;
            this.dataGridViewFilterTextBoxColumn_22.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn_22.Name = "nameObjDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_22.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_22.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_23.DataPropertyName = "address";
            style56.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_23.DefaultCellStyle = style56;
            this.dataGridViewFilterTextBoxColumn_23.HeaderText = "Адрес";
            this.dataGridViewFilterTextBoxColumn_23.Name = "addressDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_23.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_23.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_146.DataPropertyName = "addressFull";
            this.dataGridViewTextBoxColumn_146.HeaderText = "addressFull";
            this.dataGridViewTextBoxColumn_146.Name = "addressFullDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_146.ReadOnly = true;
            this.dataGridViewTextBoxColumn_146.Visible = false;
            this.dataGridViewFilterTextBoxColumn_24.DataPropertyName = "Power";
            this.dataGridViewFilterTextBoxColumn_24.HeaderText = "Существующая мощность";
            this.dataGridViewFilterTextBoxColumn_24.Name = "powerDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_24.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_24.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_25.DataPropertyName = "PowerAdd";
            this.dataGridViewFilterTextBoxColumn_25.HeaderText = "Доп мощность";
            this.dataGridViewFilterTextBoxColumn_25.Name = "powerAddDgvColumn";
            this.dataGridViewFilterTextBoxColumn_25.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_25.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_26.DataPropertyName = "PowerSum";
            this.dataGridViewFilterTextBoxColumn_26.HeaderText = "Максимальная мощность";
            this.dataGridViewFilterTextBoxColumn_26.Name = "powerSumDgvColumn";
            this.dataGridViewFilterTextBoxColumn_26.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_26.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_27.DataPropertyName = "VoltageLevel";
            this.dataGridViewFilterTextBoxColumn_27.HeaderText = "Ур-нь напр-ния";
            this.dataGridViewFilterTextBoxColumn_27.Name = "voltageLevelDgvColumn";
            this.dataGridViewFilterTextBoxColumn_27.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_27.Width = 70;
            this.dataGridViewTextBoxColumn_147.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn_147.HeaderText = "Category";
            this.dataGridViewTextBoxColumn_147.Name = "categoryDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_147.ReadOnly = true;
            this.dataGridViewTextBoxColumn_147.Visible = false;
            this.dataGridViewFilterTextBoxColumn_28.DataPropertyName = "CategoryName";
            this.dataGridViewFilterTextBoxColumn_28.HeaderText = "Категор. элек-ния";
            this.dataGridViewFilterTextBoxColumn_28.Name = "categoryNameDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_28.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_28.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_148.DataPropertyName = "idSchmObj";
            this.dataGridViewTextBoxColumn_148.HeaderText = "idSchmObj";
            this.dataGridViewTextBoxColumn_148.Name = "idSchmObjDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_148.ReadOnly = true;
            this.dataGridViewTextBoxColumn_148.Visible = false;
            this.dataGridViewFilterTextBoxColumn_29.DataPropertyName = "numContractor";
            this.dataGridViewFilterTextBoxColumn_29.HeaderText = "№ договора";
            this.dataGridViewFilterTextBoxColumn_29.Name = "numContractorDgvColumn";
            this.dataGridViewFilterTextBoxColumn_29.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_30.DataPropertyName = "dateContractor";
            this.dataGridViewFilterTextBoxColumn_30.HeaderText = "Дата договора";
            this.dataGridViewFilterTextBoxColumn_30.Name = "dateContractorDgvColumn";
            this.dataGridViewFilterTextBoxColumn_30.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_31.DataPropertyName = "PerformerFIO";
            this.dataGridViewFilterTextBoxColumn_31.HeaderText = "Исполнитель";
            this.dataGridViewFilterTextBoxColumn_31.Name = "performerFIODataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_31.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_31.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_149.DataPropertyName = "NameDocOut";
            style57.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_149.DefaultCellStyle = style57;
            this.dataGridViewTextBoxColumn_149.HeaderText = "Выданные документы";
            this.dataGridViewTextBoxColumn_149.Name = "nameDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_149.ReadOnly = true;
            this.dataGridViewTextBoxColumn_150.DataPropertyName = "Performer";
            this.dataGridViewTextBoxColumn_150.HeaderText = "Performer";
            this.dataGridViewTextBoxColumn_150.Name = "performerDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_150.ReadOnly = true;
            this.dataGridViewTextBoxColumn_150.Visible = false;
            this.dataGridViewFilterTextBoxColumn_32.DataPropertyName = "SchmTP";
            style58.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_32.DefaultCellStyle = style58;
            this.dataGridViewFilterTextBoxColumn_32.HeaderText = "ТП";
            this.dataGridViewFilterTextBoxColumn_32.Name = "schmTPDgvColumn";
            this.dataGridViewFilterTextBoxColumn_32.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_33.DataPropertyName = "SchmCP";
            style59.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_33.DefaultCellStyle = style59;
            this.dataGridViewFilterTextBoxColumn_33.HeaderText = "ЦП";
            this.dataGridViewFilterTextBoxColumn_33.Name = "schmCPDgvColumn";
            this.dataGridViewFilterTextBoxColumn_33.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_33.Width = 150;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x3c4, 0x20a);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.toolStrip_0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "FormJournalTU";
            this.Text = "Журнал технических условий";
            base.FormClosed += new FormClosedEventHandler(this.FormJournalTU_FormClosed);
            base.Load += new EventHandler(this.FormJournalTU_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetTechConnection_0.EndInit();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.ResumeLayout(false);
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.splitContainer_1.Panel1.ResumeLayout(false);
            this.splitContainer_1.Panel2.ResumeLayout(false);
            this.splitContainer_1.ResumeLayout(false);
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.dataGridViewExcelFilter_1.EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            this.tabPage_1.ResumeLayout(false);
            this.dataGridViewExcelFilter_2.EndInit();
            ((ISupportInitialize) this.bindingSource_2).EndInit();
            this.tabPage_3.ResumeLayout(false);
            this.splitContainer_3.Panel1.ResumeLayout(false);
            this.splitContainer_3.Panel2.ResumeLayout(false);
            this.splitContainer_3.ResumeLayout(false);
            this.dataGridViewExcelFilter_5.EndInit();
            ((ISupportInitialize) this.bindingSource_5).EndInit();
            this.dataGridViewExcelFilter_6.EndInit();
            ((ISupportInitialize) this.bindingSource_6).EndInit();
            this.tabPage_2.ResumeLayout(false);
            this.splitContainer_2.Panel1.ResumeLayout(false);
            this.splitContainer_2.Panel1.PerformLayout();
            this.splitContainer_2.Panel2.ResumeLayout(false);
            this.splitContainer_2.Panel2.PerformLayout();
            this.splitContainer_2.ResumeLayout(false);
            this.dataGridViewExcelFilter_3.EndInit();
            ((ISupportInitialize) this.bindingSource_3).EndInit();
            this.toolStrip_2.ResumeLayout(false);
            this.toolStrip_2.PerformLayout();
            this.dataGridViewExcelFilter_4.EndInit();
            ((ISupportInitialize) this.bindingSource_4).EndInit();
            this.toolStrip_3.ResumeLayout(false);
            this.toolStrip_3.PerformLayout();
            this.tabPage_4.ResumeLayout(false);
            this.tabPage_4.PerformLayout();
            this.dataSetTechConnection_1.EndInit();
            this.toolStrip_4.ResumeLayout(false);
            this.toolStrip_4.PerformLayout();
            this.tabPage_5.ResumeLayout(false);
            this.splitContainer_4.Panel1.ResumeLayout(false);
            this.splitContainer_4.Panel1.PerformLayout();
            this.splitContainer_4.Panel2.ResumeLayout(false);
            this.splitContainer_4.ResumeLayout(false);
            this.dataGridViewExcelFilter_8.EndInit();
            ((ISupportInitialize) this.bindingSource_7).EndInit();
            this.toolStrip_5.ResumeLayout(false);
            this.toolStrip_5.PerformLayout();
            this.dataGridViewExcelFilter_7.EndInit();
            ((ISupportInitialize) this.bindingSource_8).EndInit();
            this.dataSet_0.EndInit();
            this.dataTable_0.EndInit();
            this.dataTable_1.EndInit();
            this.tabPage_6.ResumeLayout(false);
            this.tabPage_6.PerformLayout();
            this.dataGridViewExcelFilter_9.EndInit();
            ((ISupportInitialize) this.bindingSource_9).EndInit();
            this.toolStrip_6.ResumeLayout(false);
            this.toolStrip_6.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void method_2(DataGridView dataGridView_0)
        {
            _Application application = new ApplicationClass();
            _Workbook workbook = application.get_Workbooks().Add(Type.Missing);
            _Worksheet worksheet = null;
            application.set_Visible(false);
            worksheet = (Worksheet) workbook.get_ActiveSheet();
            worksheet.set_Name("Exported from gridview");
            int num = 1;
            for (int i = 1; i < dataGridView_0.Columns.Count; i++)
            {
                if (dataGridView_0.Columns[i].Visible)
                {
                    worksheet.get_Cells().set__Default(1, num, dataGridView_0.Columns[i].HeaderText);
                    ((Range) worksheet.get_Cells().get__Default(1, num)).get_Font().set_Bold(true);
                    num++;
                }
            }
            for (int j = 0; j < (dataGridView_0.Rows.Count - 1); j++)
            {
                num = 1;
                Color white = Color.White;
                if ((dataGridView_0[this.dataGridViewTextBoxColumn_149.Name, j].Value != null) && (dataGridView_0[this.dataGridViewTextBoxColumn_149.Name, j].Value != DBNull.Value))
                {
                    white = Color.LightGreen;
                }
                for (int k = 1; k < dataGridView_0.Columns.Count; k++)
                {
                    if (dataGridView_0.Columns[k].Visible)
                    {
                        worksheet.get_Cells().set__Default(j + 2, num, dataGridView_0.Rows[j].Cells[k].Value.ToString());
                        ((Range) worksheet.get_Cells().get__Default(j + 2, num)).set_WrapText(true);
                        ((Range) worksheet.get_Cells().get__Default(j + 2, num)).get_Interior().set_Color(ColorTranslator.ToOle(white));
                        num++;
                    }
                }
            }
            application.set_Visible(true);
        }

        [CompilerGenerated]
        private bool method_20(DataSetTechConnection.Class271 class271_0)
        {
            return ((class271_0.RowState == DataRowState.Unchanged) && (class271_0.Int32_0 == ((int) ((DataRowView) this.bindingSource_9.Current)["id"])));
        }

        private void method_3()
        {
            this.dateTimePicker_1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePicker_0.Value = new DateTime(DateTime.Now.Year, 12, 0x1f);
        }

        private void method_4()
        {
            if (this.int_0 != -1)
            {
                try
                {
                    this.dataSetTechConnection_0.tTC_DocFile.Clear();
                    using (SqlConnection connection = new SqlConnection(this.get_SqlSettings().GetConnectionString()))
                    {
                        connection.Open();
                        SqlDataReader reader = new SqlCommand("SELECT id, idDoc, FileName, dateChange, idTemplate FROM tTC_DocFile WHERE idDoc = " + this.int_0.ToString(), connection).ExecuteReader();
                        while (reader.Read())
                        {
                            DataSetTechConnection.Class252 row = this.dataSetTechConnection_0.tTC_DocFile.method_5();
                            row.Int32_0 = (int) reader["id"];
                            row.idDoc = (int) reader["idDoc"];
                            row.FileName = reader["FileName"].ToString();
                            if (reader["dateChange"] != DBNull.Value)
                            {
                                row.dateChange = (DateTime) reader["dateChange"];
                            }
                            if (reader["idTemplate"] != DBNull.Value)
                            {
                                row.idTemplate = (int) reader["idTemplate"];
                            }
                            this.dataSetTechConnection_0.tTC_DocFile.Rows.Add(row);
                            row.AcceptChanges();
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        private void method_5()
        {
            DataSetTechConnection.vTC_DocStatusDataTable table = new DataSetTechConnection.vTC_DocStatusDataTable();
            base.SelectSqlData(table, true, " where idDoc = " + this.int_3.ToString() + " order by dateChange desc", false);
            this.bindingSource_4.DataSource = table;
            this.dataGridViewTextBoxColumn_122.Visible = false;
        }

        private void method_6()
        {
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_Doc, true, " where idParent = " + this.int_0.ToString() + " order by dateDoc");
            int num = 0x4d6;
            if (this.dataSetTechConnection_0.vTC_Doc.Select("typeDoc = " + num.ToString()).Length != 0)
            {
                this.toolStripMenuItem_0.Enabled = false;
            }
            else
            {
                this.toolStripMenuItem_0.Enabled = true;
            }
            num = 0x4d7;
            if (this.dataSetTechConnection_0.vTC_Doc.Select("typeDoc = " + num.ToString()).Length != 0)
            {
                this.toolStripMenuItem_1.Enabled = false;
            }
            else
            {
                this.toolStripMenuItem_1.Enabled = true;
            }
            num = 0x4d8;
            DataRow[] rowArray = this.dataSetTechConnection_0.vTC_Doc.Select("typeDoc = " + num.ToString());
            if (rowArray.Length != 0)
            {
                int num2 = Convert.ToInt32(rowArray[0]["id"]);
                string[] textArray1 = new string[] { " inner join tAbnObjDoc_AktRBP on tAbnObjDoc_AktRBP.idList = vActBalance.idList  where (tAbnObjDoc_AktRBP.idActTehConnection = ", num2.ToString(), " or tAbnObjDoc_AktRBP.idTU = ", this.int_0.ToString(), ")" };
                foreach (DataRow row in base.SelectSqlData("vActBalance", true, string.Concat(textArray1)).Rows)
                {
                    DataRow row2 = this.dataSetTechConnection_0.vTC_Doc.NewRow();
                    row2["id"] = row["idList"];
                    row2["numDoc"] = row["actNumber"];
                    row2["dateDoc"] = row["actDate"];
                    row2["typeDoc"] = row["idDocType"];
                    row2["TypeDocName"] = row["TypeDoc"];
                    this.dataSetTechConnection_0.vTC_Doc.Rows.Add(row2);
                    this.dataSetTechConnection_0.vTC_Doc.AcceptChanges();
                }
                this.toolStripMenuItem_2.Enabled = false;
            }
            else
            {
                foreach (DataRow row3 in base.SelectSqlData("vActBalance", true, " inner join tAbnObjDoc_AktRBP on tAbnObjDoc_AktRBP.idList = vActBalance.idList  where tAbnObjDoc_AktRBP.idTU = " + this.int_0.ToString()).Rows)
                {
                    DataRow row4 = this.dataSetTechConnection_0.vTC_Doc.NewRow();
                    row4["id"] = row3["idList"];
                    row4["numDoc"] = row3["actNumber"];
                    row4["dateDoc"] = row3["actDate"];
                    row4["typeDoc"] = row3["idDocType"];
                    row4["TypeDocName"] = row3["TypeDoc"];
                    this.dataSetTechConnection_0.vTC_Doc.Rows.Add(row4);
                    this.dataSetTechConnection_0.vTC_Doc.AcceptChanges();
                }
                this.toolStripMenuItem_2.Enabled = true;
            }
            num = 0x1f1;
            if (this.dataSetTechConnection_0.vTC_Doc.Select("typeDoc = " + num.ToString()).Length != 0)
            {
                this.toolStripMenuItem_3.Enabled = false;
            }
            else
            {
                this.toolStripMenuItem_2.Enabled = false;
                this.toolStripMenuItem_3.Enabled = true;
            }
            num = 0x4de;
            if (this.dataSetTechConnection_0.vTC_Doc.Select("typeDoc = " + num.ToString()).Length != 0)
            {
                this.toolStripMenuItem_4.Enabled = false;
            }
            else
            {
                this.toolStripMenuItem_4.Enabled = true;
            }
        }

        private void method_7(object sender, FormClosedEventArgs e)
        {
            this.method_6();
        }

        private int method_8()
        {
            int count = base.SelectSqlData("tUser", true, "WHERE [Login] LIKE SYSTEM_USER").Rows.Count;
            return 0xd5;
        }

        private int method_9(string string_0)
        {
            DataTable table = base.SelectSqlData("tUser", true, "WHERE [Login] LIKE '" + string_0 + "'");
            if (table.Rows.Count > 0)
            {
                return (int) table.Rows[0]["IDUser"];
            }
            return -1;
        }

        private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl_0.SelectedTab == this.tabPage_6)
            {
                this.method_14(false);
            }
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            FormTUAddEdit edit1 = new FormTUAddEdit();
            edit1.set_SqlSettings(this.get_SqlSettings());
            edit1.MdiParent = base.MdiParent;
            edit1.FormClosed += new FormClosedEventHandler(this.method_1);
            edit1.Show();
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if (this.int_0 != -1)
            {
                FormTUAddEdit edit1 = new FormTUAddEdit(this.int_0, -1);
                edit1.set_SqlSettings(this.get_SqlSettings());
                edit1.MdiParent = base.MdiParent;
                edit1.FormClosed += new FormClosedEventHandler(this.method_1);
                edit1.Show();
            }
        }

        private void toolStripButton_10_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_3.CurrentRow != null)
            {
                if (Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_25.Name].Value) != this.int_0)
                {
                    MessageBox.Show("Невозможно редактировать данный документ");
                }
                else
                {
                    FormTechConnectionDocOutAddEdit edit = new FormTechConnectionDocOutAddEdit(Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_23.Name].Value), this.int_0);
                    edit.set_SqlSettings(this.get_SqlSettings());
                    if (edit.ShowDialog() == DialogResult.OK)
                    {
                        this.method_0();
                        this.dataGridViewExcelFilter_3.SearchGrid(this.dataGridViewTextBoxColumn_23.Name, edit.IdDocOut.ToString(), false);
                    }
                }
            }
        }

        private void toolStripButton_11_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_3.CurrentRow != null)
            {
                if (Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_25.Name].Value) != this.int_0)
                {
                    MessageBox.Show("Невозможно удалить данный документ");
                }
                else if (MessageBox.Show("Вы действительно хотите удалить текущий документ", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_23.Name].Value);
                    int num = Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_28.Name].Value);
                    if (base.DeleteSqlDataById(this.dataSetTechConnection_0.tTC_Doc, num))
                    {
                        this.dataGridViewExcelFilter_3.Rows.Remove(this.dataGridViewExcelFilter_3.CurrentRow);
                        this.method_0();
                        MessageBox.Show("Документ успешно удален");
                    }
                }
            }
        }

        private void toolStripButton_12_Click(object sender, EventArgs e)
        {
            if (this.int_0 != -1)
            {
                FormTechConnectionDocOutAddEdit edit = new FormTechConnectionDocOutAddEdit(-1, this.int_0);
                edit.set_SqlSettings(this.get_SqlSettings());
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    this.method_0();
                    this.dataGridViewExcelFilter_3.SearchGrid(this.dataGridViewTextBoxColumn_23.Name, edit.IdDocOut.ToString(), false);
                }
            }
        }

        private void toolStripButton_13_Click(object sender, EventArgs e)
        {
            if (this.int_3 != -1)
            {
                if (this.int_4 != this.int_0)
                {
                    MessageBox.Show("Невозможно редактировать данный документ");
                }
                else
                {
                    Form6 form1 = new Form6(-1, this.int_3, true);
                    form1.set_SqlSettings(this.get_SqlSettings());
                    if (form1.ShowDialog() == DialogResult.OK)
                    {
                        this.method_5();
                    }
                }
            }
        }

        private void toolStripButton_14_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_4.CurrentRow != null) && (this.int_3 != -1))
            {
                if (this.int_4 != this.int_0)
                {
                    MessageBox.Show("Невозможно редактировать данный документ");
                }
                else
                {
                    int num = Convert.ToInt32(this.dataGridViewExcelFilter_4.CurrentRow.Cells[this.dataGridViewTextBoxColumn_122.Name].Value);
                    Form6 form1 = new Form6(num, this.int_3, true);
                    form1.set_SqlSettings(this.get_SqlSettings());
                    if (form1.ShowDialog() == DialogResult.OK)
                    {
                        this.method_5();
                        this.dataGridViewExcelFilter_4.SearchGrid(this.dataGridViewTextBoxColumn_122.Name, num.ToString(), false);
                    }
                }
            }
        }

        private void toolStripButton_15_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_4.CurrentRow != null)
            {
                if (this.int_4 != this.int_0)
                {
                    MessageBox.Show("Невозможно редактировать данный документ");
                }
                else if (MessageBox.Show("Вы действительно хотите удалить текущий статус", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int num = Convert.ToInt32(this.dataGridViewExcelFilter_4.CurrentRow.Cells[this.dataGridViewTextBoxColumn_122.Name].Value);
                    if (base.DeleteSqlDataById(this.dataSetTechConnection_0.tTC_DocStatus, num))
                    {
                        this.dataGridViewExcelFilter_4.Rows.Remove(this.dataGridViewExcelFilter_4.CurrentRow);
                        MessageBox.Show("Статус успешно удален");
                    }
                }
            }
        }

        private void toolStripButton_16_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in new SqlDataCommand(new SQLSettings("ulges-sql", "PTS", "WINDOWS", "", "")).SelectSqlData("tbl_TU", false, " where tuvid = 1 and year([Дата])>=2013 and year([Дата]) <= 2013 and [Номер] = 971 and [Номер] < 9999 order by [Дата] desc ", null).Rows)
            {
                int num = -1;
                if ((row["НомерВ"] != DBNull.Value) && (row["ДатаВ"] != DBNull.Value))
                {
                    DataTable table = base.SelectSqlData("ttc_Request", true, " where numIn = '" + row["НомерВ"].ToString() + "' and year(dateIn) = " + Convert.ToDateTime(row["ДатаВ"]).Year.ToString());
                    if (table.Rows.Count > 0)
                    {
                        num = Convert.ToInt32(table.Rows[0]["id"]);
                    }
                }
                int num2 = -1;
                DataSetTechConnection connection = new DataSetTechConnection();
                string[] textArray1 = new string[] { " where numDoc = '", row["Номер"].ToString(), "' and year(dateDoc) = ", Convert.ToDateTime(row["Дата"]).Year.ToString(), " and typeDoc = ", 0x463.ToString() };
                base.SelectSqlData(connection.tTC_Doc, true, string.Concat(textArray1), false);
                if (connection.tTC_Doc.Rows.Count == 0)
                {
                    DataRow row2 = connection.tTC_Doc.NewRow();
                    row2["numDoc"] = row["Номер"];
                    row2["dateDoc"] = row["Дата"];
                    row2["TypeDoc"] = 0x463;
                    row2["Body"] = row["Содержание"];
                    if (num == -1)
                    {
                        string[] textArray2 = new string[] { "NumIn:", row["НомерВ"].ToString(), ";DateIn:", row["ДатаВ"].ToString(), ";" };
                        row2["Comment"] = string.Concat(textArray2);
                    }
                    connection.tTC_Doc.Rows.Add(row2);
                    num2 = base.InsertSqlDataOneRow(connection.tTC_Doc.Rows[0]);
                }
                else
                {
                    if (connection.tTC_Doc.Rows[0]["Body"] == DBNull.Value)
                    {
                        connection.tTC_Doc.Rows[0]["Body"] = row["Содержание"];
                    }
                    if (num == -1)
                    {
                        string[] textArray3 = new string[] { "NumIn:", row["НомерВ"].ToString(), ";DateIn:", row["ДатаВ"].ToString(), ";" };
                        connection.tTC_Doc.Rows[0]["Comment"] = string.Concat(textArray3);
                    }
                    connection.tTC_Doc.Rows[0].EndEdit();
                    base.UpdateSqlData(connection, connection.tTC_Doc);
                    num2 = Convert.ToInt32(connection.tTC_Doc.Rows[0]["id"]);
                }
                if (((row["DogNom"] != DBNull.Value) && (row["DogDate"] != DBNull.Value)) && (row["DogNom"].ToString() != "не подписывались"))
                {
                    bool flag = false;
                    if (connection.tTC_Doc.Rows[0]["idParent"] == DBNull.Value)
                    {
                        flag = true;
                    }
                    else if (base.SelectSqlData("ttc_doc", true, "where id = " + connection.tTC_Doc.Rows[0]["idParent"].ToString()).Rows.Count == 0)
                    {
                        flag = true;
                    }
                    if (flag)
                    {
                        DataSetTechConnection connection2 = new DataSetTechConnection();
                        DataRow row3 = connection2.tTC_Doc.NewRow();
                        row3["numDoc"] = row["DogNom"];
                        row3["dateDoc"] = row["DogDate"];
                        row3["TypeDoc"] = 0x4c4;
                        connection2.tTC_Doc.Rows.Add(row3);
                        int num4 = base.InsertSqlDataOneRow(connection2, connection2.tTC_Doc);
                        if (num4 > 0)
                        {
                            connection.tTC_Doc.AcceptChanges();
                            connection.tTC_Doc.Rows[0]["idParent"] = num4;
                            connection.tTC_Doc.Rows[0].EndEdit();
                            base.UpdateSqlData(connection, connection.tTC_Doc);
                            if (num > 0)
                            {
                                base.SelectSqlData(connection2.tTC_DocOut, true, "where idDoc = " + num.ToString() + " and idDocOut = " + num4.ToString(), false);
                                if (connection2.tTC_DocOut.Rows.Count == 0)
                                {
                                    DataRow row4 = connection2.tTC_DocOut.NewRow();
                                    row4["iddoc"] = num;
                                    row4["iddocout"] = num4;
                                    connection2.tTC_DocOut.Rows.Add(row4);
                                    base.InsertSqlDataOneRow(connection2.tTC_DocOut.Rows[0]);
                                }
                            }
                        }
                    }
                }
                if (num > 0)
                {
                    base.SelectSqlData(connection.tTC_DocOut, true, "where idDoc = " + num.ToString() + " and idDocOut = " + num2.ToString(), false);
                    if (connection.tTC_DocOut.Rows.Count == 0)
                    {
                        DataRow row5 = connection.tTC_DocOut.NewRow();
                        row5["iddoc"] = num;
                        row5["iddocout"] = num2;
                        connection.tTC_DocOut.Rows.Add(row5);
                        base.InsertSqlDataOneRow(connection.tTC_DocOut.Rows[0]);
                    }
                }
                base.SelectSqlData(connection.tTC_TU, true, " where id = " + num2.ToString(), false);
                if (connection.tTC_TU.Rows.Count > 0)
                {
                    if (connection.tTC_TU.Rows[0]["PowerSum"] == DBNull.Value)
                    {
                        connection.tTC_TU.Rows[0]["PowerSum"] = row["Мощность"];
                    }
                    if ((connection.tTC_TU.Rows[0]["Category"] == DBNull.Value) && (row["categor"] != DBNull.Value))
                    {
                        switch (Convert.ToInt32(row["categor"]))
                        {
                            case 1:
                                connection.tTC_TU.Rows[0]["Category"] = 0x1eb;
                                break;

                            case 2:
                                connection.tTC_TU.Rows[0]["Category"] = 0x1ec;
                                break;

                            case 3:
                                connection.tTC_TU.Rows[0]["Category"] = 0x1ed;
                                break;
                        }
                    }
                    if ((connection.tTC_TU.Rows[0]["Performer"] == DBNull.Value) && (row["IspolnitTU"] != DBNull.Value))
                    {
                        switch (row["IspolnitTU"].ToString())
                        {
                            case "Барышникова Т.Б.":
                                connection.tTC_TU.Rows[0]["Performer"] = 0x88;
                                break;

                            case "Асланова Т.С.":
                                connection.tTC_TU.Rows[0]["Performer"] = 0x26;
                                break;

                            case "Белов А.П.":
                                connection.tTC_TU.Rows[0]["Performer"] = 0x182;
                                break;
                        }
                    }
                    connection.tTC_TU.Rows[0]["oldNameAbn"] = row["Потребитель"];
                    string str = "";
                    if (row["Улица"] != DBNull.Value)
                    {
                        str = row["Улица"].ToString();
                        if (row["Prefix"] != DBNull.Value)
                        {
                            str = str + " " + row["Prefix"].ToString();
                        }
                        if (row["Дом"] != DBNull.Value)
                        {
                            str = str + ", д." + row["Дом"].ToString();
                        }
                    }
                    if (!string.IsNullOrEmpty(str))
                    {
                        connection.tTC_TU.Rows[0]["oldAddress"] = str;
                    }
                    connection.tTC_TU.Rows[0].EndEdit();
                    base.UpdateSqlData(connection, connection.tTC_TU);
                }
                else
                {
                    DataRow row6 = connection.tTC_TU.NewRow();
                    row6["id"] = num2;
                    row6["PowerSum"] = row["Мощность"];
                    if (row["categor"] != DBNull.Value)
                    {
                        switch (Convert.ToInt32(row["categor"]))
                        {
                            case 1:
                                row6["Category"] = 0x1eb;
                                break;

                            case 2:
                                row6["Category"] = 0x1ec;
                                break;

                            case 3:
                                row6["Category"] = 0x1ed;
                                break;
                        }
                    }
                    if (row["IspolnitTU"] != DBNull.Value)
                    {
                        switch (row["IspolnitTU"].ToString())
                        {
                            case "Барышникова Т.Б.":
                                row6["Performer"] = 0x88;
                                break;

                            case "Асланова Т.С.":
                                row6["Performer"] = 0x26;
                                break;

                            case "Белов А.П.":
                                row6["Performer"] = 0x182;
                                break;
                        }
                    }
                    row6["oldNameAbn"] = row["Потребитель"];
                    string str3 = "";
                    if (row["Улица"] != DBNull.Value)
                    {
                        str3 = row["Улица"].ToString();
                        if (row["Prefix"] != DBNull.Value)
                        {
                            str3 = str3 + " " + row["Prefix"].ToString();
                        }
                        if (row["Дом"] != DBNull.Value)
                        {
                            str3 = str3 + ", д." + row["Дом"].ToString();
                        }
                    }
                    if (!string.IsNullOrEmpty(str3))
                    {
                        row6["oldAddress"] = str3;
                    }
                    connection.tTC_TU.Rows.Add(row6);
                    base.InsertSqlData(connection, connection.tTC_TU);
                }
                base.SelectSqlData(connection, connection.tTC_TUPointAttach, true, " where idTU = " + num2.ToString());
                if (connection.tTC_TUPointAttach.Rows.Count == 0)
                {
                    int num5 = -1;
                    int num6 = -1;
                    int num7 = -1;
                    if (row["№ТП/РП"] != DBNull.Value)
                    {
                        DataTable table2 = base.SelectSqlData("tSchm_ObjList", true, "where name = '" + row["№ТП/РП"].ToString() + "' and typeCodeId in (535,536,537,538,1034) ");
                        if (table2.Rows.Count > 0)
                        {
                            num5 = Convert.ToInt32(table2.Rows[0]["id"]);
                        }
                    }
                    if (row["ЦП"] != DBNull.Value)
                    {
                        DataTable table3 = base.SelectSqlData("tSchm_ObjList", true, "where name like '%" + row["ЦП"].ToString() + "%' and typeCodeId in (536) ");
                        if (table3.Rows.Count > 0)
                        {
                            num6 = Convert.ToInt32(table3.Rows[0]["id"]);
                            if (row["Яч"] != DBNull.Value)
                            {
                                DataTable table4 = base.SelectSqlData("tSchm_ObjList", true, "where name = '" + row["Яч"].ToString() + "' and typeCodeId in (678,679,676,675,674,672) and idParent = " + num6.ToString());
                                if (table4.Rows.Count > 0)
                                {
                                    num7 = Convert.ToInt32(table4.Rows[0]["id"]);
                                }
                            }
                        }
                    }
                    if (((num5 != -1) || (num6 != -1)) || (num7 != -1))
                    {
                        DataRow row7 = connection.tTC_TUPointAttach.NewRow();
                        row7["idTU"] = num2;
                        row7["num"] = 1;
                        if (num5 != -1)
                        {
                            row7["idsubpoint"] = num5;
                        }
                        if (num6 != -1)
                        {
                            row7["idsubcp"] = num6;
                        }
                        if (num7 != -1)
                        {
                            row7["idCellCP"] = num7;
                        }
                        connection.tTC_TUPointAttach.Rows.Add(row7);
                        base.InsertSqlDataOneRow(connection, connection.tTC_TUPointAttach);
                    }
                }
                string[] textArray4 = new string[] { @"\\ulges-fs\Work\TU\", Convert.ToDateTime(row["Дата"]).Year.ToString(), @"\", Convert.ToDateTime(row["Дата"]).Year.ToString(), row["номер"].ToString(), ".doc" };
                FileInfo info = new FileInfo(string.Concat(textArray4));
                if (info.Exists)
                {
                    base.SelectSqlData(connection.tTC_DocFile, true, "where idDoc = " + num2.ToString() + " and filename = '" + info.Name + "'", false);
                    if (connection.tTC_DocFile.Rows.Count == 0)
                    {
                        DataRow row8 = connection.tTC_DocFile.NewRow();
                        row8["idDoc"] = num2;
                        row8["FileName"] = info.Name;
                        row8["File"] = File.ReadAllBytes(info.FullName);
                        row8["DateChange"] = info.LastWriteTime;
                        connection.tTC_DocFile.Rows.Add(row8);
                        base.InsertSqlDataOneRow(connection, connection.tTC_DocFile);
                    }
                }
            }
        }

        private void toolStripButton_17_Click(object sender, EventArgs e)
        {
            if (this.int_0 != -1)
            {
                Form12 form1 = new Form12(-1, -1, this.int_0);
                form1.set_SqlSettings(this.get_SqlSettings());
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    this.method_0();
                }
            }
        }

        private void toolStripButton_18_Click(object sender, EventArgs e)
        {
            if ((this.int_0 != -1) && (this.int_2 != -1))
            {
                Form12 form1 = new Form12(this.int_2, -1, -1);
                form1.set_SqlSettings(this.get_SqlSettings());
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    this.method_0();
                }
            }
        }

        private void toolStripButton_19_Click(object sender, EventArgs e)
        {
            if (((this.int_2 != -1) && (this.int_0 != -1)) && ((MessageBox.Show("Вы действительно хотите удалить договор", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && base.DeleteSqlDataById(this.dataSetTechConnection_0.tTC_Doc, this.int_2)))
            {
                this.method_0();
                MessageBox.Show("Документ успешно удален");
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if (((this.int_0 > 0) && (this.dataGridViewExcelFilter_0.CurrentRow != null)) && ((MessageBox.Show("Вы действительно хотите удалить текущую запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && base.DeleteSqlDataById(this.dataSetTechConnection_0.tTC_Doc, this.int_0)))
            {
                this.dataGridViewExcelFilter_0.Rows.Remove(this.dataGridViewExcelFilter_0.CurrentRow);
                MessageBox.Show("Запись успешно удалена");
            }
        }

        private void toolStripButton_20_Click(object sender, EventArgs e)
        {
            this.method_2(this.dataGridViewExcelFilter_0);
        }

        private void toolStripButton_21_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_8.CurrentRow != null)
            {
                switch (Convert.ToInt32(this.dataGridViewExcelFilter_8.CurrentRow.Cells[this.dataGridViewTextBoxColumn_116.Name].Value))
                {
                    case 0x1f1:
                    case 0x4de:
                    {
                        FormAbnAktRBP trbp1 = new FormAbnAktRBP(this.get_SqlSettings(), -1, Convert.ToInt32(this.dataGridViewExcelFilter_8.CurrentRow.Cells[this.dataGridViewTextBoxColumn_115.Name].Value));
                        trbp1.set_SqlSettings(this.get_SqlSettings());
                        trbp1.MdiParent = base.MdiParent;
                        trbp1.FormClosed += new FormClosedEventHandler(this.method_7);
                        trbp1.Show();
                        return;
                    }
                    case 0x4d7:
                    {
                        FormActPerformingTU gtu1 = new FormActPerformingTU(Convert.ToInt32(this.dataGridViewExcelFilter_8.CurrentRow.Cells[this.dataGridViewTextBoxColumn_115.Name].Value), this.int_0, 0x4d7);
                        gtu1.set_SqlSettings(this.get_SqlSettings());
                        gtu1.MdiParent = base.MdiParent;
                        gtu1.FormClosed += new FormClosedEventHandler(this.method_7);
                        gtu1.Show();
                        return;
                    }
                    case 0x4d8:
                    {
                        FormTCAddEdit edit1 = new FormTCAddEdit(Convert.ToInt32(this.dataGridViewExcelFilter_8.CurrentRow.Cells[this.dataGridViewTextBoxColumn_115.Name].Value), this.int_0);
                        edit1.set_SqlSettings(this.get_SqlSettings());
                        edit1.MdiParent = base.MdiParent;
                        edit1.FormClosed += new FormClosedEventHandler(this.method_7);
                        edit1.Show();
                        return;
                    }
                }
                FormActElectricalInspection inspection1 = new FormActElectricalInspection(Convert.ToInt32(this.dataGridViewExcelFilter_8.CurrentRow.Cells[this.dataGridViewTextBoxColumn_115.Name].Value), this.int_0, 0x4d6);
                inspection1.set_SqlSettings(this.get_SqlSettings());
                inspection1.MdiParent = base.MdiParent;
                inspection1.FormClosed += new FormClosedEventHandler(this.method_7);
                inspection1.Show();
            }
        }

        private void toolStripButton_22_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_8.CurrentRow == null) || (MessageBox.Show("Вы действительно хотите удалить текущий документ?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes))
            {
                return;
            }
            int num = Convert.ToInt32(this.dataGridViewExcelFilter_8.CurrentRow.Cells[this.dataGridViewTextBoxColumn_116.Name].Value);
            if ((num != 0x1f1) && (num != 0x4de))
            {
                if (base.DeleteSqlDataById(this.dataSetTechConnection_0.tTC_Doc, Convert.ToInt32(this.dataGridViewExcelFilter_8.CurrentRow.Cells[this.dataGridViewTextBoxColumn_115.Name].Value)))
                {
                    this.method_6();
                    MessageBox.Show("Документ успешно удален");
                }
                return;
            }
            DataTable table = base.SelectSqlData("tAbnObjDoc_List", true, "where id = " + Convert.ToInt32(this.dataGridViewExcelFilter_8.CurrentRow.Cells[this.dataGridViewTextBoxColumn_115.Name].Value));
            using (IEnumerator enumerator = table.Columns.GetEnumerator())
            {
                DataColumn current;
                DataColumn[] columnArray;
                while (enumerator.MoveNext())
                {
                    current = (DataColumn) enumerator.Current;
                    if (current.ColumnName.ToUpper() == "id".ToUpper())
                    {
                        goto Label_0146;
                    }
                }
                goto Label_0172;
            Label_0146:
                columnArray = new DataColumn[] { current };
                table.PrimaryKey = columnArray;
            }
        Label_0172:
            if (table.Rows.Count > 0)
            {
                table.Rows[0]["deleted"] = true;
                table.Rows[0].EndEdit();
                if (base.UpdateSqlData(table))
                {
                    this.method_6();
                    MessageBox.Show("Документ успешно удален");
                    return;
                }
            }
        }

        private void toolStripButton_23_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_8.CurrentRow != null)
            {
                switch (Convert.ToInt32(this.dataGridViewExcelFilter_8.CurrentRow.Cells[this.dataGridViewTextBoxColumn_116.Name].Value))
                {
                    case 0x1f1:
                        return;

                    case 0x4de:
                        MessageBox.Show("Для данного акта не предусмотрена печатная форма.");
                        return;
                }
                FormReportActElectricalInspection inspection1 = new FormReportActElectricalInspection(Convert.ToInt32(this.dataGridViewExcelFilter_8.CurrentRow.Cells[this.dataGridViewTextBoxColumn_115.Name].Value));
                inspection1.set_SqlSettings(this.get_SqlSettings());
                inspection1.MdiParent = base.MdiParent;
                inspection1.Show();
            }
        }

        private void toolStripButton_24_Click(object sender, EventArgs e)
        {
            this.method_12();
        }

        private void toolStripButton_25_Click(object sender, EventArgs e)
        {
            this.method_14(true);
        }

        private void toolStripButton_26_Click(object sender, EventArgs e)
        {
            this.method_15();
        }

        private void toolStripButton_27_Click(object sender, EventArgs e)
        {
            this.method_16();
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_0.CurrentRow != null) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_143.Name].Value != null)) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_143.Name].Value != DBNull.Value))
            {
                FormTechConnectionRequest request1 = new FormTechConnectionRequest(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_143.Name].Value)) {
                    MdiParent = base.MdiParent
                };
                request1.set_SqlSettings(this.get_SqlSettings());
                request1.Show();
            }
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(1, this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_5_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(3, this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_6_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(2, this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_7_Click(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void toolStripButton_8_Click(object sender, EventArgs e)
        {
            this.method_3();
            using (IEnumerator enumerator = this.treeView_0.Nodes.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ((TreeNode) enumerator.Current).Checked = false;
                }
            }
            this.method_0();
        }

        private void toolStripButton_9_Click(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void toolStripDropDownButton_0_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            FormActElectricalInspection inspection1 = new FormActElectricalInspection(-1, this.int_0, 0x4d6);
            inspection1.set_SqlSettings(this.get_SqlSettings());
            inspection1.MdiParent = base.MdiParent;
            inspection1.FormClosed += new FormClosedEventHandler(this.method_7);
            inspection1.Show();
        }

        private void toolStripMenuItem_1_Click(object sender, EventArgs e)
        {
            FormActPerformingTU gtu1 = new FormActPerformingTU(-1, this.int_0, 0x4d7);
            gtu1.set_SqlSettings(this.get_SqlSettings());
            gtu1.MdiParent = base.MdiParent;
            gtu1.FormClosed += new FormClosedEventHandler(this.method_7);
            gtu1.Show();
        }

        private void toolStripMenuItem_2_Click(object sender, EventArgs e)
        {
            FormTCAddEdit edit1 = new FormTCAddEdit(-1, this.int_0);
            edit1.set_SqlSettings(this.get_SqlSettings());
            edit1.MdiParent = base.MdiParent;
            edit1.FormClosed += new FormClosedEventHandler(this.method_7);
            edit1.Show();
        }

        private void toolStripMenuItem_3_Click(object sender, EventArgs e)
        {
            int idActTeh = -1;
            int num2 = 0x4d8;
            DataRow[] rowArray = this.dataSetTechConnection_0.vTC_Doc.Select("typeDoc = " + num2.ToString());
            if (rowArray.Length != 0)
            {
                idActTeh = Convert.ToInt32(rowArray[0]["id"]);
            }
            FormAbnAktRBP trbp1 = new FormAbnAktRBP(this.get_SqlSettings(), idActTeh, this.int_0, 1);
            trbp1.set_SqlSettings(this.get_SqlSettings());
            trbp1.MdiParent = base.MdiParent;
            trbp1.FormClosed += new FormClosedEventHandler(this.method_7);
            trbp1.Show();
        }

        private void toolStripMenuItem_4_Click(object sender, EventArgs e)
        {
            int idActTeh = -1;
            int num2 = 0x4d8;
            DataRow[] rowArray = this.dataSetTechConnection_0.vTC_Doc.Select("typeDoc = " + num2.ToString());
            if (rowArray.Length != 0)
            {
                idActTeh = Convert.ToInt32(rowArray[0]["id"]);
            }
            FormAbnAktRBP trbp1 = new FormAbnAktRBP(this.get_SqlSettings(), idActTeh, this.int_0, 4);
            trbp1.set_SqlSettings(this.get_SqlSettings());
            trbp1.MdiParent = base.MdiParent;
            trbp1.FormClosed += new FormClosedEventHandler(this.method_7);
            trbp1.Show();
        }

        private void toolStripMenuItem_5_Click(object sender, EventArgs e)
        {
            Form27 form1 = new Form27();
            form1.set_SqlSettings(this.get_SqlSettings());
            form1.MdiParent = base.MdiParent;
            form1.method_1(this.int_0);
            form1.method_3(this.method_8());
            form1.method_9(0);
            form1.FormClosed += new FormClosedEventHandler(this.method_11);
            form1.Show();
        }

        private void toolStripMenuItem_6_Click(object sender, EventArgs e)
        {
            FormMemorandumJournal journal1 = new FormMemorandumJournal(0) {
                MdiParent = base.MdiParent
            };
            journal1.set_SqlSettings(this.get_SqlSettings());
            journal1.IdTU = this.int_0;
            journal1.FormClosed += new FormClosedEventHandler(this.method_11);
            journal1.Show();
        }

        private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Modifiers == Keys.None)
                {
                    this.dataGridViewExcelFilter_0.SearchGrid(2, this.toolStripTextBox_0.Text);
                }
                if (e.Modifiers == Keys.Shift)
                {
                    this.dataGridViewExcelFilter_0.SearchGrid(3, this.toolStripTextBox_0.Text);
                }
            }
        }

        private void treeView_0_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                using (IEnumerator enumerator = e.Node.Nodes.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        ((TreeNode) enumerator.Current).Checked = e.Node.Checked;
                    }
                }
            }
        }
    }
}

