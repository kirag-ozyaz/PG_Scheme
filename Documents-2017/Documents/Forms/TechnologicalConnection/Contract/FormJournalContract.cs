namespace Documents.Forms.TechnologicalConnection.Contract
{
    using ControlsLbr.DataGridViewExcelFilter;
    using ControlsLbr.DataGridViewExcelFilter.DataGridViewColumsLibraty;
    using DataSql;
    using Documents.Forms.TechnologicalConnection;
    using Documents.Forms.TechnologicalConnection.TU;
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
    using System.Windows.Forms;
    using System.Xml;

    public class FormJournalContract : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private BindingSource bindingSource_3;
        private BindingSource bindingSource_4;
        private BindingSource bindingSource_5;
        private BindingSource bindingSource_6;
        private BindingSource bindingSource_7;
        private BindingSource bindingSource_8;
        private DataGridView dataGridView_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_2;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_3;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_4;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_5;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_6;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_7;
        private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_0;
        private DataGridViewFilterDateTimePickerColumn dataGridViewFilterDateTimePickerColumn_1;
        private DataGridViewFilterProgressColumn dataGridViewFilterProgressColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_11;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_12;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_13;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_14;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_15;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_16;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
        private DataGridViewLinkColumn dataGridViewLinkColumn_0;
        private DataGridViewLinkColumn dataGridViewLinkColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;
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
        private DataSetTechConnection dataSetTechConnection_0;
        private DataSetTechConnection dataSetTechConnection_1;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        private int int_4;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private List<int> list_0;
        private SplitContainer splitContainer_0;
        private SplitContainer splitContainer_1;
        private SplitContainer splitContainer_2;
        private SplitContainer splitContainer_3;
        private TabControl tabControl_0;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private TabPage tabPage_2;
        private TabPage tabPage_3;
        private TabPage tabPage_4;
        private TabPage tabPage_5;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStrip toolStrip_2;
        private ToolStrip toolStrip_3;
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
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;
        private ToolStripButton toolStripButton_7;
        private ToolStripButton toolStripButton_8;
        private ToolStripButton toolStripButton_9;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripSeparator toolStripSeparator_3;
        private ToolStripSeparator toolStripSeparator_4;
        private ToolStripTextBox toolStripTextBox_0;
        private TreeView treeView_0;

        public FormJournalContract()
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.method_8();
            this.method_3();
        }

        public FormJournalContract(List<int> checkedSubstation)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.method_8();
            this.method_3();
            this.list_0 = checkedSubstation;
        }

        public FormJournalContract(int idContract)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = -1;
            this.int_3 = -1;
            this.int_4 = -1;
            this.method_8();
            this.method_3();
            this.int_0 = idContract;
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

        private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
        {
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
                if (((DataRowView) this.bindingSource_0.Current).Row["idTU"] != DBNull.Value)
                {
                    this.int_2 = Convert.ToInt32(((DataRowView) this.bindingSource_0.Current).Row["idTU"]);
                }
                else
                {
                    this.int_2 = -1;
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
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_TUTypeWork, true, " where idTU = " + this.int_2.ToString());
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_Payment, true, " where idParent = " + this.int_0.ToString());
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_PaymentShedule, true, " where idDoc = " + this.int_0.ToString());
            }
            else
            {
                this.int_0 = -1;
                this.int_1 = -1;
                this.dataSetTechConnection_0.tTC_DocFile.Clear();
                this.dataSetTechConnection_0.vTC_DocOut.Clear();
                this.dataSetTechConnection_0.tTC_TUTypeWork.Clear();
                this.dataSetTechConnection_0.vTC_Payment.Clear();
                this.dataSetTechConnection_0.tTC_PaymentShedule.Clear();
                this.dataSetTechConnection_1.tTC_Doc.Clear();
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
            if (((e.RowIndex >= 0) && (this.dataGridViewExcelFilter_0[this.dataGridViewCheckBoxColumn_0.Name, e.RowIndex].Value != null)) && ((this.dataGridViewExcelFilter_0[this.dataGridViewCheckBoxColumn_0.Name, e.RowIndex].Value != DBNull.Value) && Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewCheckBoxColumn_0.Name, e.RowIndex].Value)))
            {
                e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void dataGridViewExcelFilter_0_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
        }

        private void dataGridViewExcelFilter_0_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ((DataGridView) sender).AutoResizeRow(e.RowIndex);
        }

        private void dataGridViewExcelFilter_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < (e.RowIndex + e.RowCount); i++)
            {
                if (i >= 0)
                {
                    DataGridViewColumn column = this.dataGridViewFilterProgressColumn_0;
                    if (((this.dataGridViewExcelFilter_0[column.Index, i].Value != null) && (this.dataGridViewExcelFilter_0[column.Index, i].Value != DBNull.Value)) && ((this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_97.Index, i].Value != null) && (this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_97.Index, i].Value != DBNull.Value)))
                    {
                        int num2 = Convert.ToInt32((decimal) ((Convert.ToDecimal(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_97.Index, i].Value) / Convert.ToDecimal(this.dataGridViewExcelFilter_0[column.Index, i].Value)) * 100M));
                        ((DataGridViewFilterProgressCell) this.dataGridViewExcelFilter_0[this.dataGridViewFilterProgressColumn_0.Index, i]).set_ProgressValue(num2);
                        this.dataGridViewExcelFilter_0[this.dataGridViewFilterProgressColumn_0.Index, i].ToolTipText = num2.ToString() + "%";
                    }
                    else
                    {
                        this.dataGridViewExcelFilter_0[this.dataGridViewFilterProgressColumn_0.Index, i].ToolTipText = "0%";
                    }
                }
            }
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
            if ((e.RowIndex >= 0) && (Convert.ToInt32(this.dataGridViewExcelFilter_2[this.dataGridViewTextBoxColumn_75.Name, e.RowIndex].Value) == 0x459))
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
            if ((e.RowIndex >= 0) && (Convert.ToInt32(this.dataGridViewExcelFilter_3[this.dataGridViewTextBoxColumn_24.Name, e.RowIndex].Value) != this.int_0))
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
            if (((e.RowIndex >= 0) && (e.ColumnIndex == this.dataGridViewExcelFilter_7.Columns[this.dataGridViewLinkColumn_1.Name].Index)) && (this.dataGridViewExcelFilter_7[this.dataGridViewTextBoxColumn_60.Name, e.RowIndex].Value != DBNull.Value))
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_7[this.dataGridViewTextBoxColumn_60.Name, e.RowIndex].Value);
                DataSetTechConnection.tTC_DocDataTable table = new DataSetTechConnection.tTC_DocDataTable();
                base.SelectSqlData(table, true, "where id = " + num.ToString(), false);
                if (table.Rows.Count > 0)
                {
                    DateTime time = Convert.ToDateTime(table.Rows[0]["datedoc"]);
                    this.dateTimePicker_1.Value = new DateTime(time.Year, 1, 1);
                    this.dateTimePicker_0.Value = new DateTime(time.Year + 1, 1, 1).AddSeconds(-1.0);
                    this.method_0();
                    this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_91.Name, num.ToString(), false);
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormJournalContract_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormJournalContract_Load(object sender, EventArgs e)
        {
            this.toolStripButton_16.Visible = false;
            base.LoadFormConfig(null);
            this.method_6();
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
                this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_91.Name, num.ToString(), false);
                if (this.dataGridViewExcelFilter_0.CurrentRow != null)
                {
                    this.dataGridViewExcelFilter_0.FirstDisplayedScrollingRowIndex = this.dataGridViewExcelFilter_0.CurrentRow.Index;
                }
            }
        }

        private void method_0()
        {
            int num = this.int_0;
            List<int> list = this.method_7(this.treeView_0.Nodes);
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
                str = str + string.Format(" and idTU in (select idTU from ttc_tuPointAttach where idSubPoint in ({0}) and (typeDoc is null or typeDoc = {1})) ", str2, 0x463);
            }
            str = str + " ORDER BY CONVERT(BIGINT, CASE WHEN numdoc like '%[^0-9]%' THEN SUBSTRING(numdoc,1,PATINDEX('%[^0-9]%',numdoc)-1) ELSE numdoc END) desc";
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_Contract, true, str);
            if (num > 0)
            {
                this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_91.Name, num.ToString(), false);
            }
        }

        private void method_1(object sender, FormClosedEventArgs e)
        {
            this.int_0 = ((Form12) sender).method_0();
            this.method_0();
        }

        private void method_2(DataGridView dataGridView_1)
        {
            _Application application = new ApplicationClass();
            _Workbook workbook = application.get_Workbooks().Add(Type.Missing);
            _Worksheet worksheet = null;
            application.set_Visible(false);
            worksheet = (Worksheet) workbook.get_ActiveSheet();
            worksheet.set_Name("Exported from gridview");
            int num = 1;
            for (int i = 0; i < dataGridView_1.Columns.Count; i++)
            {
                if (dataGridView_1.Columns[i].Visible)
                {
                    worksheet.get_Cells().set__Default(1, num, dataGridView_1.Columns[i].HeaderText);
                    ((Range) worksheet.get_Cells().get__Default(1, num)).get_Font().set_Bold(true);
                    num++;
                }
            }
            for (int j = 0; j < (dataGridView_1.Rows.Count - 1); j++)
            {
                num = 1;
                Color white = Color.White;
                for (int k = 0; k < dataGridView_1.Columns.Count; k++)
                {
                    if (dataGridView_1.Columns[k].Visible)
                    {
                        worksheet.get_Cells().set__Default(j + 2, num, dataGridView_1.Rows[j].Cells[k].Value.ToString());
                        ((Range) worksheet.get_Cells().get__Default(j + 2, num)).set_WrapText(true);
                        ((Range) worksheet.get_Cells().get__Default(j + 2, num)).get_Interior().set_Color(ColorTranslator.ToOle(white));
                        num++;
                    }
                }
            }
            application.set_Visible(true);
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
            this.dataGridViewTextBoxColumn_34.Visible = false;
        }

        private void method_6()
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

        private List<int> method_7(TreeNodeCollection treeNodeCollection_0)
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
                    list.AddRange(this.method_7(node.Nodes));
                }
            }
            return list;
        }

        private void method_8()
        {
            this.icontainer_0 = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormJournalContract));
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
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripButton_9 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_17 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripButton_6 = new ToolStripButton();
            this.toolStripButton_16 = new ToolStripButton();
            this.toolStripSeparator_3 = new ToolStripSeparator();
            this.toolStripButton_18 = new ToolStripButton();
            this.toolStripSeparator_4 = new ToolStripSeparator();
            this.toolStripButton_19 = new ToolStripButton();
            this.splitContainer_0 = new SplitContainer();
            this.treeView_0 = new TreeView();
            this.label_2 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_0 = new Label();
            this.dateTimePicker_1 = new DateTimePicker();
            this.label_1 = new Label();
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_7 = new ToolStripButton();
            this.toolStripButton_8 = new ToolStripButton();
            this.splitContainer_1 = new SplitContainer();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.tabControl_0 = new TabControl();
            this.tabPage_0 = new TabPage();
            this.dataGridViewExcelFilter_1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.tabPage_1 = new TabPage();
            this.dataGridViewExcelFilter_2 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.tabPage_3 = new TabPage();
            this.splitContainer_3 = new SplitContainer();
            this.dataGridViewExcelFilter_5 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewExcelFilter_6 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.tabPage_2 = new TabPage();
            this.splitContainer_2 = new SplitContainer();
            this.dataGridViewExcelFilter_3 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
            this.toolStrip_2 = new ToolStrip();
            this.toolStripButton_12 = new ToolStripButton();
            this.toolStripButton_10 = new ToolStripButton();
            this.toolStripButton_11 = new ToolStripButton();
            this.dataGridViewExcelFilter_4 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.toolStrip_3 = new ToolStrip();
            this.toolStripButton_13 = new ToolStripButton();
            this.toolStripButton_14 = new ToolStripButton();
            this.toolStripButton_15 = new ToolStripButton();
            this.tabPage_4 = new TabPage();
            this.dataGridViewExcelFilter_7 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.tabPage_5 = new TabPage();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewFilterDateTimePickerColumn_1 = new DataGridViewFilterDateTimePickerColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetTechConnection_0 = new DataSetTechConnection();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
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
            this.bindingSource_2 = new BindingSource(this.icontainer_0);
            this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
            this.bindingSource_5 = new BindingSource(this.icontainer_0);
            this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
            this.bindingSource_6 = new BindingSource(this.icontainer_0);
            this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
            this.bindingSource_3 = new BindingSource(this.icontainer_0);
            this.dataGridViewTextBoxColumn_83 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_84 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_85 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_86 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_87 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_88 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_89 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_90 = new DataGridViewTextBoxColumn();
            this.bindingSource_4 = new BindingSource(this.icontainer_0);
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
            this.dataGridViewLinkColumn_1 = new DataGridViewLinkColumn();
            this.bindingSource_7 = new BindingSource(this.icontainer_0);
            this.dataGridViewFilterDateTimePickerColumn_0 = new DataGridViewFilterDateTimePickerColumn();
            this.dataGridViewTextBoxColumn_61 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_62 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_63 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_64 = new DataGridViewTextBoxColumn();
            this.bindingSource_8 = new BindingSource(this.icontainer_0);
            this.dataSetTechConnection_1 = new DataSetTechConnection();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_91 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_92 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_93 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_94 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_95 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_96 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterProgressColumn_0 = new DataGridViewFilterProgressColumn();
            this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn_97 = new DataGridViewTextBoxColumn();
            this.toolStrip_0.SuspendLayout();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.toolStrip_1.SuspendLayout();
            this.splitContainer_1.Panel1.SuspendLayout();
            this.splitContainer_1.Panel2.SuspendLayout();
            this.splitContainer_1.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            this.tabControl_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.dataGridViewExcelFilter_1.BeginInit();
            this.tabPage_1.SuspendLayout();
            this.dataGridViewExcelFilter_2.BeginInit();
            this.tabPage_3.SuspendLayout();
            this.splitContainer_3.Panel1.SuspendLayout();
            this.splitContainer_3.Panel2.SuspendLayout();
            this.splitContainer_3.SuspendLayout();
            this.dataGridViewExcelFilter_5.BeginInit();
            this.dataGridViewExcelFilter_6.BeginInit();
            this.tabPage_2.SuspendLayout();
            this.splitContainer_2.Panel1.SuspendLayout();
            this.splitContainer_2.Panel2.SuspendLayout();
            this.splitContainer_2.SuspendLayout();
            this.dataGridViewExcelFilter_3.BeginInit();
            this.toolStrip_2.SuspendLayout();
            this.dataGridViewExcelFilter_4.BeginInit();
            this.toolStrip_3.SuspendLayout();
            this.tabPage_4.SuspendLayout();
            this.dataGridViewExcelFilter_7.BeginInit();
            this.tabPage_5.SuspendLayout();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetTechConnection_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            ((ISupportInitialize) this.bindingSource_2).BeginInit();
            ((ISupportInitialize) this.bindingSource_5).BeginInit();
            ((ISupportInitialize) this.bindingSource_6).BeginInit();
            ((ISupportInitialize) this.bindingSource_3).BeginInit();
            ((ISupportInitialize) this.bindingSource_4).BeginInit();
            ((ISupportInitialize) this.bindingSource_7).BeginInit();
            ((ISupportInitialize) this.bindingSource_8).BeginInit();
            this.dataSetTechConnection_1.BeginInit();
            base.SuspendLayout();
            this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { 
                this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripSeparator_2, this.toolStripButton_9, this.toolStripSeparator_0, this.toolStripButton_3, this.toolStripButton_17, this.toolStripSeparator_1, this.toolStripButton_4, this.toolStripTextBox_0, this.toolStripButton_5, this.toolStripButton_6, this.toolStripButton_16, this.toolStripSeparator_3, this.toolStripButton_18,
                this.toolStripSeparator_4, this.toolStripButton_19
            };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStrip";
            this.toolStrip_0.Size = new Size(0x3c4, 0x19);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.ElementAdd;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnAddTU";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Добавить договор";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.ElementEdit;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnEditTU";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Редактировать договор";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.ElementDel;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnDelTU";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Удалить договор";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator3";
            this.toolStripSeparator_2.Size = new Size(6, 0x19);
            this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_9.Image = Resources.refresh_16;
            this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_9.Name = "toolBtnRefresh";
            this.toolStripButton_9.Size = new Size(0x17, 0x16);
            this.toolStripButton_9.Text = "Обновить";
            this.toolStripButton_9.Click += new EventHandler(this.toolStripButton_9_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.network_connection_manager;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnShowRequest";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Открыть заявку";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripButton_17.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_17.Image = Resources._1381484495_Terms_rev;
            this.toolStripButton_17.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_17.Name = "toolBtnShowTU";
            this.toolStripButton_17.Size = new Size(0x17, 0x16);
            this.toolStripButton_17.Text = "Открыть тех условие";
            this.toolStripButton_17.Click += new EventHandler(this.toolStripButton_17_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator2";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.Find;
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
            this.toolStripButton_5.Image = Resources.FindPrev;
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolBtnFindPrev";
            this.toolStripButton_5.Size = new Size(0x17, 0x16);
            this.toolStripButton_5.Text = "Поиск назад";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = Resources.FindNext;
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
            this.toolStripButton_18.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_18.Image = Resources.microsoftoffice2007excel_7581;
            this.toolStripButton_18.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_18.Name = "toolBtnExportExcel";
            this.toolStripButton_18.Size = new Size(0x17, 0x16);
            this.toolStripButton_18.Text = "Экспорт в Excel";
            this.toolStripButton_18.Click += new EventHandler(this.toolStripButton_18_Click);
            this.toolStripSeparator_4.Name = "toolStripSeparator5";
            this.toolStripSeparator_4.Size = new Size(6, 0x19);
            this.toolStripButton_19.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_19.Image = Resources.Setting;
            this.toolStripButton_19.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_19.Name = "toolBtnSettingsWord";
            this.toolStripButton_19.Size = new Size(0x17, 0x16);
            this.toolStripButton_19.Text = "Настройки для шаблона";
            this.toolStripButton_19.Click += new EventHandler(this.toolStripButton_19_Click);
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.FixedPanel = FixedPanel.Panel1;
            this.splitContainer_0.Location = new Point(0, 0x19);
            this.splitContainer_0.Name = "splitContainerMain";
            this.splitContainer_0.Panel1.Controls.Add(this.treeView_0);
            this.splitContainer_0.Panel1.Controls.Add(this.label_2);
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
            this.treeView_0.TabIndex = 13;
            this.treeView_0.AfterCheck += new TreeViewEventHandler(this.treeView_0_AfterCheck);
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(12, 0x67);
            this.label_2.Name = "label6";
            this.label_2.Size = new Size(0x44, 13);
            this.label_2.TabIndex = 12;
            this.label_2.Text = "Подстанции";
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
            this.toolStripButton_7.Image = Resources.filter;
            this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_7.Name = "toolBtnApplyFilter";
            this.toolStripButton_7.Size = new Size(0x17, 0x16);
            this.toolStripButton_7.Text = "Применить фильтр";
            this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
            this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_8.Image = Resources.filter_delete;
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
                this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewTextBoxColumn_91, this.dataGridViewFilterTextBoxColumn_1, this.dataGridViewTextBoxColumn_92, this.dataGridViewFilterTextBoxColumn_2, this.dataGridViewFilterTextBoxColumn_3, this.dataGridViewTextBoxColumn_93, this.dataGridViewTextBoxColumn_94, this.dataGridViewFilterTextBoxColumn_4, this.dataGridViewFilterTextBoxColumn_5, this.dataGridViewTextBoxColumn_95, this.dataGridViewFilterTextBoxColumn_6, this.dataGridViewTextBoxColumn_96, this.dataGridViewFilterTextBoxColumn_7, this.dataGridViewFilterTextBoxColumn_8, this.dataGridViewFilterProgressColumn_0,
                this.dataGridViewFilterTextBoxColumn_9, this.dataGridViewFilterTextBoxColumn_10, this.dataGridViewFilterTextBoxColumn_11, this.dataGridViewFilterTextBoxColumn_12, this.dataGridViewFilterTextBoxColumn_13, this.dataGridViewFilterTextBoxColumn_14, this.dataGridViewFilterTextBoxColumn_15, this.dataGridViewFilterTextBoxColumn_16, this.dataGridViewCheckBoxColumn_0, this.dataGridViewTextBoxColumn_97
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
            this.dataGridViewExcelFilter_0.Name = "dgvContract";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.Size = new Size(0x315, 0x126);
            this.dataGridViewExcelFilter_0.TabIndex = 1;
            this.dataGridViewExcelFilter_0.VirtualMode = true;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.dataGridViewExcelFilter_0.CellPainting += new DataGridViewCellPaintingEventHandler(this.dataGridViewExcelFilter_0_CellPainting);
            this.dataGridViewExcelFilter_0.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_0_RowPostPaint);
            this.dataGridViewExcelFilter_0.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridViewExcelFilter_0_RowsAdded);
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Controls.Add(this.tabPage_3);
            this.tabControl_0.Controls.Add(this.tabPage_2);
            this.tabControl_0.Controls.Add(this.tabPage_4);
            this.tabControl_0.Controls.Add(this.tabPage_5);
            this.tabControl_0.Dock = DockStyle.Fill;
            this.tabControl_0.Location = new Point(0, 0);
            this.tabControl_0.Name = "tabControl";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x315, 0xc7);
            this.tabControl_0.TabIndex = 0;
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
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Control;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style3.ForeColor = SystemColors.WindowText;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_1.ColumnHeadersDefaultCellStyle = style3;
            this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewImageColumnNotNull_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewLinkColumn_0, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3 };
            this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray2);
            this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
            style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style4.BackColor = SystemColors.Window;
            style4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style4.ForeColor = SystemColors.ControlText;
            style4.SelectionBackColor = SystemColors.Highlight;
            style4.SelectionForeColor = SystemColors.HighlightText;
            style4.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_1.DefaultCellStyle = style4;
            this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_1.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewExcelFilter_1.Location = new Point(3, 3);
            this.dataGridViewExcelFilter_1.Name = "dgvFile";
            this.dataGridViewExcelFilter_1.ReadOnly = true;
            this.dataGridViewExcelFilter_1.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_1.Size = new Size(0x307, 0xa7);
            this.dataGridViewExcelFilter_1.TabIndex = 7;
            this.dataGridViewExcelFilter_1.VirtualMode = true;
            this.dataGridViewExcelFilter_1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_1_CellContentClick);
            this.dataGridViewExcelFilter_1.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dataGridViewExcelFilter_1_CellValueNeeded);
            style5.NullValue = null;
            this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style5;
            this.dataGridViewImageColumnNotNull_0.HeaderText = "";
            this.dataGridViewImageColumnNotNull_0.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumnNotNull_0.Name = "imageDgvColumn";
            this.dataGridViewImageColumnNotNull_0.ReadOnly = true;
            this.dataGridViewImageColumnNotNull_0.Width = 30;
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
            style6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style6.BackColor = SystemColors.Control;
            style6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style6.ForeColor = SystemColors.WindowText;
            style6.SelectionBackColor = SystemColors.Highlight;
            style6.SelectionForeColor = SystemColors.HighlightText;
            style6.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_2.ColumnHeadersDefaultCellStyle = style6;
            this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray3 = new DataGridViewColumn[] { 
                this.dataGridViewTextBoxColumn_65, this.dataGridViewTextBoxColumn_66, this.dataGridViewTextBoxColumn_67, this.dataGridViewTextBoxColumn_68, this.dataGridViewTextBoxColumn_69, this.dataGridViewTextBoxColumn_70, this.dataGridViewTextBoxColumn_71, this.dataGridViewTextBoxColumn_72, this.dataGridViewTextBoxColumn_73, this.dataGridViewTextBoxColumn_74, this.dataGridViewTextBoxColumn_75, this.dataGridViewTextBoxColumn_76, this.dataGridViewTextBoxColumn_77, this.dataGridViewTextBoxColumn_78, this.dataGridViewTextBoxColumn_79, this.dataGridViewTextBoxColumn_80,
                this.dataGridViewTextBoxColumn_81, this.dataGridViewTextBoxColumn_82
            };
            this.dataGridViewExcelFilter_2.Columns.AddRange(columnArray3);
            this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
            style7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style7.BackColor = SystemColors.Window;
            style7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style7.ForeColor = SystemColors.ControlText;
            style7.SelectionBackColor = SystemColors.Highlight;
            style7.SelectionForeColor = SystemColors.HighlightText;
            style7.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_2.DefaultCellStyle = style7;
            this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_2.Location = new Point(3, 3);
            this.dataGridViewExcelFilter_2.MultiSelect = false;
            this.dataGridViewExcelFilter_2.Name = "dgvRequestHistory";
            this.dataGridViewExcelFilter_2.ReadOnly = true;
            this.dataGridViewExcelFilter_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_2.Size = new Size(0x307, 0xa7);
            this.dataGridViewExcelFilter_2.TabIndex = 4;
            this.dataGridViewExcelFilter_2.VirtualMode = true;
            this.dataGridViewExcelFilter_2.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_2_CellFormatting);
            this.dataGridViewExcelFilter_2.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_2_RowPostPaint);
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
            this.dataGridViewExcelFilter_5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray4 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_41, this.dataGridViewTextBoxColumn_42, this.dataGridViewTextBoxColumn_43, this.dataGridViewTextBoxColumn_44, this.dataGridViewTextBoxColumn_45 };
            this.dataGridViewExcelFilter_5.Columns.AddRange(columnArray4);
            this.dataGridViewExcelFilter_5.DataSource = this.bindingSource_5;
            this.dataGridViewExcelFilter_5.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_5.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_5.Name = "dgvNetWork";
            this.dataGridViewExcelFilter_5.ReadOnly = true;
            this.dataGridViewExcelFilter_5.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_5.Size = new Size(0x16e, 0xad);
            this.dataGridViewExcelFilter_5.TabIndex = 2;
            this.dataGridViewExcelFilter_5.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_6_RowPostPaint);
            this.dataGridViewExcelFilter_6.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_6.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_6.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray5 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_46, this.dataGridViewTextBoxColumn_47, this.dataGridViewTextBoxColumn_48, this.dataGridViewTextBoxColumn_49, this.dataGridViewTextBoxColumn_50 };
            this.dataGridViewExcelFilter_6.Columns.AddRange(columnArray5);
            this.dataGridViewExcelFilter_6.DataSource = this.bindingSource_6;
            this.dataGridViewExcelFilter_6.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_6.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_6.Name = "dgvClientWork";
            this.dataGridViewExcelFilter_6.ReadOnly = true;
            this.dataGridViewExcelFilter_6.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_6.Size = new Size(0x19b, 0xad);
            this.dataGridViewExcelFilter_6.TabIndex = 3;
            this.dataGridViewExcelFilter_6.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_6_RowPostPaint);
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
            style8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style8.BackColor = SystemColors.Control;
            style8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style8.ForeColor = SystemColors.WindowText;
            style8.SelectionBackColor = SystemColors.Highlight;
            style8.SelectionForeColor = SystemColors.HighlightText;
            style8.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_3.ColumnHeadersDefaultCellStyle = style8;
            this.dataGridViewExcelFilter_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray6 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_21, this.dataGridViewTextBoxColumn_22, this.dataGridViewTextBoxColumn_23, this.dataGridViewTextBoxColumn_24, this.dataGridViewTextBoxColumn_25, this.dataGridViewTextBoxColumn_26, this.dataGridViewTextBoxColumn_27, this.dataGridViewTextBoxColumn_28, this.dataGridViewTextBoxColumn_29, this.dataGridViewTextBoxColumn_30, this.dataGridViewTextBoxColumn_31, this.dataGridViewTextBoxColumn_32, this.dataGridViewTextBoxColumn_33 };
            this.dataGridViewExcelFilter_3.Columns.AddRange(columnArray6);
            this.dataGridViewExcelFilter_3.DataSource = this.bindingSource_3;
            style9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style9.BackColor = SystemColors.Window;
            style9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style9.ForeColor = SystemColors.ControlText;
            style9.SelectionBackColor = SystemColors.Highlight;
            style9.SelectionForeColor = SystemColors.HighlightText;
            style9.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_3.DefaultCellStyle = style9;
            this.dataGridViewExcelFilter_3.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_3.Location = new Point(0x18, 0);
            this.dataGridViewExcelFilter_3.Name = "dgvDocOut";
            this.dataGridViewExcelFilter_3.ReadOnly = true;
            this.dataGridViewExcelFilter_3.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_3.Size = new Size(0x188, 0xa7);
            this.dataGridViewExcelFilter_3.TabIndex = 3;
            this.dataGridViewExcelFilter_3.VirtualMode = true;
            this.dataGridViewExcelFilter_3.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_3_CellFormatting);
            this.dataGridViewTextBoxColumn_24.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_24.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_24.Name = "idDocDgvColumn";
            this.dataGridViewTextBoxColumn_24.ReadOnly = true;
            this.dataGridViewTextBoxColumn_24.Visible = false;
            this.dataGridViewTextBoxColumn_26.DataPropertyName = "TypeDocOut";
            this.dataGridViewTextBoxColumn_26.HeaderText = "TypeDocOut";
            this.dataGridViewTextBoxColumn_26.Name = "typeDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_26.ReadOnly = true;
            this.dataGridViewTextBoxColumn_26.Visible = false;
            this.dataGridViewTextBoxColumn_27.DataPropertyName = "idDocOut";
            this.dataGridViewTextBoxColumn_27.HeaderText = "idDocOut";
            this.dataGridViewTextBoxColumn_27.Name = "idDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_27.ReadOnly = true;
            this.dataGridViewTextBoxColumn_27.Visible = false;
            this.dataGridViewTextBoxColumn_30.DataPropertyName = "BodyDocOut";
            this.dataGridViewTextBoxColumn_30.HeaderText = "Содержание";
            this.dataGridViewTextBoxColumn_30.Name = "bodyDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_30.ReadOnly = true;
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
            this.toolStripButton_12.Image = Resources.ElementAdd;
            this.toolStripButton_12.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_12.Name = "toolBtnAddDocOut";
            this.toolStripButton_12.Size = new Size(0x15, 20);
            this.toolStripButton_12.Text = "Новый документ";
            this.toolStripButton_12.Click += new EventHandler(this.toolStripButton_12_Click);
            this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_10.Image = Resources.ElementEdit;
            this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_10.Name = "toolBtnEditDocOut";
            this.toolStripButton_10.Size = new Size(0x15, 20);
            this.toolStripButton_10.Text = "Редактировать документ";
            this.toolStripButton_10.Click += new EventHandler(this.toolStripButton_10_Click);
            this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_11.Image = Resources.ElementDel;
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
            style10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style10.BackColor = SystemColors.Control;
            style10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style10.ForeColor = SystemColors.WindowText;
            style10.SelectionBackColor = SystemColors.Highlight;
            style10.SelectionForeColor = SystemColors.HighlightText;
            style10.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_4.ColumnHeadersDefaultCellStyle = style10;
            this.dataGridViewExcelFilter_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray7 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_83, this.dataGridViewTextBoxColumn_84, this.dataGridViewTextBoxColumn_85, this.dataGridViewTextBoxColumn_86, this.dataGridViewTextBoxColumn_87, this.dataGridViewTextBoxColumn_88, this.dataGridViewTextBoxColumn_89, this.dataGridViewTextBoxColumn_90 };
            this.dataGridViewExcelFilter_4.Columns.AddRange(columnArray7);
            this.dataGridViewExcelFilter_4.DataSource = this.bindingSource_4;
            style11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style11.BackColor = SystemColors.Window;
            style11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style11.ForeColor = SystemColors.ControlText;
            style11.SelectionBackColor = SystemColors.Highlight;
            style11.SelectionForeColor = SystemColors.HighlightText;
            style11.WrapMode = DataGridViewTriState.False;
            this.dataGridViewExcelFilter_4.DefaultCellStyle = style11;
            this.dataGridViewExcelFilter_4.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_4.Location = new Point(0, 0x19);
            this.dataGridViewExcelFilter_4.Name = "dgvDocOutStatus";
            this.dataGridViewExcelFilter_4.ReadOnly = true;
            this.dataGridViewExcelFilter_4.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_4.Size = new Size(0x163, 0x8e);
            this.dataGridViewExcelFilter_4.TabIndex = 3;
            this.toolStrip_3.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolStripButton_13, this.toolStripButton_14, this.toolStripButton_15 };
            this.toolStrip_3.Items.AddRange(itemArray4);
            this.toolStrip_3.Location = new Point(0, 0);
            this.toolStrip_3.Name = "toolStripDocOutStatus";
            this.toolStrip_3.Size = new Size(0x163, 0x19);
            this.toolStrip_3.TabIndex = 2;
            this.toolStrip_3.Text = "toolStrip1";
            this.toolStripButton_13.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_13.Image = Resources.ElementAdd;
            this.toolStripButton_13.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_13.Name = "toolBtnAddDocOutStatus";
            this.toolStripButton_13.Size = new Size(0x17, 0x16);
            this.toolStripButton_13.Text = "Новый статус";
            this.toolStripButton_13.Click += new EventHandler(this.toolStripButton_13_Click);
            this.toolStripButton_14.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_14.Image = Resources.ElementEdit;
            this.toolStripButton_14.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_14.Name = "toolBtnEditDocOutStatus";
            this.toolStripButton_14.Size = new Size(0x17, 0x16);
            this.toolStripButton_14.Text = "Редактировать статус";
            this.toolStripButton_14.Click += new EventHandler(this.toolStripButton_14_Click);
            this.toolStripButton_15.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_15.Image = Resources.ElementDel;
            this.toolStripButton_15.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_15.Name = "toolBtnDelDocOutStatus";
            this.toolStripButton_15.Size = new Size(0x17, 0x16);
            this.toolStripButton_15.Text = "Удалить статус";
            this.toolStripButton_15.Click += new EventHandler(this.toolStripButton_15_Click);
            this.tabPage_4.Controls.Add(this.dataGridViewExcelFilter_7);
            this.tabPage_4.Location = new Point(4, 0x16);
            this.tabPage_4.Name = "tabPagePayment";
            this.tabPage_4.Padding = new Padding(3);
            this.tabPage_4.Size = new Size(0x30d, 0xad);
            this.tabPage_4.TabIndex = 4;
            this.tabPage_4.Text = "Платежи";
            this.tabPage_4.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_7.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_7.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_7.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray8 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_51, this.dataGridViewTextBoxColumn_52, this.dataGridViewTextBoxColumn_53, this.dataGridViewTextBoxColumn_54, this.dataGridViewTextBoxColumn_55, this.dataGridViewTextBoxColumn_56, this.dataGridViewTextBoxColumn_57, this.dataGridViewTextBoxColumn_58, this.dataGridViewTextBoxColumn_59, this.dataGridViewTextBoxColumn_60, this.dataGridViewLinkColumn_1 };
            this.dataGridViewExcelFilter_7.Columns.AddRange(columnArray8);
            this.dataGridViewExcelFilter_7.DataSource = this.bindingSource_7;
            this.dataGridViewExcelFilter_7.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_7.Location = new Point(3, 3);
            this.dataGridViewExcelFilter_7.Name = "dgvPayment";
            this.dataGridViewExcelFilter_7.ReadOnly = true;
            this.dataGridViewExcelFilter_7.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_7.Size = new Size(0x307, 0xa7);
            this.dataGridViewExcelFilter_7.TabIndex = 0;
            this.dataGridViewExcelFilter_7.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_7_CellContentClick);
            this.tabPage_5.Controls.Add(this.dataGridView_0);
            this.tabPage_5.Location = new Point(4, 0x16);
            this.tabPage_5.Name = "tabPagePaymentShedule";
            this.tabPage_5.Padding = new Padding(3);
            this.tabPage_5.Size = new Size(0x30d, 0xad);
            this.tabPage_5.TabIndex = 5;
            this.tabPage_5.Text = "График платежей";
            this.tabPage_5.UseVisualStyleBackColor = true;
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.AutoGenerateColumns = false;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray9 = new DataGridViewColumn[] { this.dataGridViewFilterDateTimePickerColumn_0, this.dataGridViewTextBoxColumn_61, this.dataGridViewTextBoxColumn_62, this.dataGridViewTextBoxColumn_63, this.dataGridViewTextBoxColumn_64 };
            this.dataGridView_0.Columns.AddRange(columnArray9);
            this.dataGridView_0.DataSource = this.bindingSource_8;
            this.dataGridView_0.Dock = DockStyle.Fill;
            this.dataGridView_0.Location = new Point(3, 3);
            this.dataGridView_0.Name = "dgvPaymentShedule";
            this.dataGridView_0.ReadOnly = true;
            this.dataGridView_0.Size = new Size(0x307, 0xa7);
            this.dataGridView_0.TabIndex = 3;
            this.dataGridViewFilterDateTimePickerColumn_1.DataPropertyName = "DateShedule";
            style12.Format = "d";
            style12.NullValue = null;
            this.dataGridViewFilterDateTimePickerColumn_1.DefaultCellStyle = style12;
            this.dataGridViewFilterDateTimePickerColumn_1.HeaderText = "Дата";
            this.dataGridViewFilterDateTimePickerColumn_1.Name = "dataGridViewFilterDateTimePickerColumn1";
            this.dataGridViewFilterDateTimePickerColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterDateTimePickerColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "numDateIn";
            style13.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_4.DefaultCellStyle = style13;
            this.dataGridViewTextBoxColumn_4.HeaderText = "№, дата вход.";
            this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Visible = false;
            this.dataGridViewTextBoxColumn_4.Width = 80;
            this.dataGridViewTextBoxColumn_14.DataPropertyName = "PowerAdd";
            this.dataGridViewTextBoxColumn_14.HeaderText = "Доп мощность";
            this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_14.ReadOnly = true;
            this.dataGridViewTextBoxColumn_14.Visible = false;
            this.dataGridViewTextBoxColumn_14.Width = 70;
            this.dataGridViewTextBoxColumn_35.DataPropertyName = "idDoc";
            style14.Format = "N2";
            style14.NullValue = null;
            this.dataGridViewTextBoxColumn_35.DefaultCellStyle = style14;
            this.dataGridViewTextBoxColumn_35.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_35.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_35.ReadOnly = true;
            this.dataGridViewTextBoxColumn_35.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_35.Visible = false;
            this.dataGridViewTextBoxColumn_36.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_36.DataPropertyName = "idStatus";
            this.dataGridViewTextBoxColumn_36.HeaderText = "idStatus";
            this.dataGridViewTextBoxColumn_36.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn_36.ReadOnly = true;
            this.dataGridViewTextBoxColumn_36.Visible = false;
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
            this.dataGridViewTextBoxColumn_8.DataPropertyName = "numIn";
            this.dataGridViewTextBoxColumn_8.HeaderText = "numIn";
            this.dataGridViewTextBoxColumn_8.Name = "numInDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewTextBoxColumn_8.Visible = false;
            this.dataGridViewTextBoxColumn_9.DataPropertyName = "dateIn";
            this.dataGridViewTextBoxColumn_9.HeaderText = "dateIn";
            this.dataGridViewTextBoxColumn_9.Name = "dateInDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewTextBoxColumn_9.Visible = false;
            this.dataGridViewTextBoxColumn_10.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_10.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_10.Name = "idAbnDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewTextBoxColumn_10.Visible = false;
            this.dataGridViewTextBoxColumn_11.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_11.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_11.Name = "idAbnObjDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewTextBoxColumn_11.Visible = false;
            this.dataGridViewTextBoxColumn_12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_12.DataPropertyName = "body";
            style15.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_12.DefaultCellStyle = style15;
            this.dataGridViewTextBoxColumn_12.HeaderText = "Тело письма";
            this.dataGridViewTextBoxColumn_12.Name = "bodyDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewTextBoxColumn_13.DataPropertyName = "PowerCurrent";
            this.dataGridViewTextBoxColumn_13.HeaderText = "Текущая мощность";
            this.dataGridViewTextBoxColumn_13.Name = "powerCurrentDgvColumn";
            this.dataGridViewTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewTextBoxColumn_13.Width = 70;
            this.dataGridViewTextBoxColumn_15.DataPropertyName = "Power";
            this.dataGridViewTextBoxColumn_15.HeaderText = "Суммарная мощность";
            this.dataGridViewTextBoxColumn_15.Name = "powerDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_15.ReadOnly = true;
            this.dataGridViewTextBoxColumn_15.Width = 70;
            this.dataGridViewTextBoxColumn_16.DataPropertyName = "VoltageName";
            this.dataGridViewTextBoxColumn_16.HeaderText = "Напряжение";
            this.dataGridViewTextBoxColumn_16.Name = "voltageNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_16.ReadOnly = true;
            this.dataGridViewTextBoxColumn_16.Width = 70;
            this.dataGridViewTextBoxColumn_17.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_17.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_17.Name = "commentDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewTextBoxColumn_17.Width = 70;
            this.dataGridViewTextBoxColumn_18.DataPropertyName = "VoltageLevel";
            this.dataGridViewTextBoxColumn_18.HeaderText = "VoltageLevel";
            this.dataGridViewTextBoxColumn_18.Name = "voltageLevelDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_18.ReadOnly = true;
            this.dataGridViewTextBoxColumn_18.Visible = false;
            this.dataGridViewTextBoxColumn_19.DataPropertyName = "VoltageValue";
            this.dataGridViewTextBoxColumn_19.HeaderText = "VoltageValue";
            this.dataGridViewTextBoxColumn_19.Name = "voltageValueDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_19.ReadOnly = true;
            this.dataGridViewTextBoxColumn_19.Visible = false;
            this.dataGridViewTextBoxColumn_20.DataPropertyName = "IdParent";
            this.dataGridViewTextBoxColumn_20.HeaderText = "IdParent";
            this.dataGridViewTextBoxColumn_20.Name = "idParentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_20.ReadOnly = true;
            this.dataGridViewTextBoxColumn_20.Visible = false;
            this.dataGridViewTextBoxColumn_34.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_34.HeaderText = "id";
            this.dataGridViewTextBoxColumn_34.Name = "idStatusDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_34.ReadOnly = true;
            this.dataGridViewTextBoxColumn_34.Visible = false;
            this.dataGridViewTextBoxColumn_37.DataPropertyName = "statusName";
            this.dataGridViewTextBoxColumn_37.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn_37.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn_37.ReadOnly = true;
            this.dataGridViewTextBoxColumn_37.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_38.DataPropertyName = "DateChange";
            style16.Format = "d";
            style16.NullValue = null;
            this.dataGridViewTextBoxColumn_38.DefaultCellStyle = style16;
            this.dataGridViewTextBoxColumn_38.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_38.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn_38.ReadOnly = true;
            this.dataGridViewTextBoxColumn_38.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_38.Width = 70;
            this.dataGridViewTextBoxColumn_39.DataPropertyName = "SendName";
            this.dataGridViewTextBoxColumn_39.HeaderText = "Способ отправки";
            this.dataGridViewTextBoxColumn_39.Name = "sendNameDgvColumn";
            this.dataGridViewTextBoxColumn_39.ReadOnly = true;
            this.dataGridViewTextBoxColumn_40.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_40.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_40.Name = "сommentDocOutStatusDgvColumn";
            this.dataGridViewTextBoxColumn_40.ReadOnly = true;
            this.bindingSource_0.DataMember = "vTC_Contract";
            this.bindingSource_0.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
            this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
            this.dataGridViewLinkColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewLinkColumn_0.DataPropertyName = "FileName";
            this.dataGridViewLinkColumn_0.HeaderText = "Файл";
            this.dataGridViewLinkColumn_0.Name = "fileNameDgvColumn";
            this.dataGridViewLinkColumn_0.ReadOnly = true;
            this.dataGridViewLinkColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewLinkColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
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
            this.dataGridViewTextBoxColumn_65.DataPropertyName = "numDateIn";
            style17.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_65.DefaultCellStyle = style17;
            this.dataGridViewTextBoxColumn_65.HeaderText = "№,дата вход";
            this.dataGridViewTextBoxColumn_65.Name = "numDateInDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_65.ReadOnly = true;
            this.dataGridViewTextBoxColumn_65.Width = 80;
            this.dataGridViewTextBoxColumn_66.DataPropertyName = "dateDoc";
            this.dataGridViewTextBoxColumn_66.HeaderText = "Дата получения";
            this.dataGridViewTextBoxColumn_66.Name = "dateDocDataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_66.ReadOnly = true;
            this.dataGridViewTextBoxColumn_66.Width = 70;
            this.dataGridViewTextBoxColumn_67.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_67.DataPropertyName = "body";
            style18.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_67.DefaultCellStyle = style18;
            this.dataGridViewTextBoxColumn_67.HeaderText = "Тело письма";
            this.dataGridViewTextBoxColumn_67.Name = "bodyDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_67.ReadOnly = true;
            this.dataGridViewTextBoxColumn_68.DataPropertyName = "PowerCurrent";
            this.dataGridViewTextBoxColumn_68.HeaderText = "Текщая мощность";
            this.dataGridViewTextBoxColumn_68.Name = "powerCurrentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_68.ReadOnly = true;
            this.dataGridViewTextBoxColumn_68.Width = 70;
            this.dataGridViewTextBoxColumn_69.DataPropertyName = "PowerAdd";
            this.dataGridViewTextBoxColumn_69.HeaderText = "Доп мощность";
            this.dataGridViewTextBoxColumn_69.Name = "powerAddDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_69.ReadOnly = true;
            this.dataGridViewTextBoxColumn_69.Width = 70;
            this.dataGridViewTextBoxColumn_70.DataPropertyName = "Power";
            this.dataGridViewTextBoxColumn_70.HeaderText = "Суммарная мощность";
            this.dataGridViewTextBoxColumn_70.Name = "powerDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_70.ReadOnly = true;
            this.dataGridViewTextBoxColumn_70.Width = 70;
            this.dataGridViewTextBoxColumn_71.DataPropertyName = "VoltageName";
            this.dataGridViewTextBoxColumn_71.HeaderText = "Напряжение";
            this.dataGridViewTextBoxColumn_71.Name = "voltageNameDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_71.ReadOnly = true;
            this.dataGridViewTextBoxColumn_71.Width = 70;
            this.dataGridViewTextBoxColumn_72.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_72.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_72.Name = "commentDataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_72.ReadOnly = true;
            this.dataGridViewTextBoxColumn_72.Width = 70;
            this.dataGridViewTextBoxColumn_73.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_73.HeaderText = "id";
            this.dataGridViewTextBoxColumn_73.Name = "idDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_73.ReadOnly = true;
            this.dataGridViewTextBoxColumn_73.Visible = false;
            this.dataGridViewTextBoxColumn_74.DataPropertyName = "numDoc";
            this.dataGridViewTextBoxColumn_74.HeaderText = "numDoc";
            this.dataGridViewTextBoxColumn_74.Name = "numDocDataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_74.ReadOnly = true;
            this.dataGridViewTextBoxColumn_74.Visible = false;
            this.dataGridViewTextBoxColumn_75.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn_75.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn_75.Name = "typeDocRequestHistoryDgvColumn";
            this.dataGridViewTextBoxColumn_75.ReadOnly = true;
            this.dataGridViewTextBoxColumn_75.Visible = false;
            this.dataGridViewTextBoxColumn_76.DataPropertyName = "numIn";
            this.dataGridViewTextBoxColumn_76.HeaderText = "numIn";
            this.dataGridViewTextBoxColumn_76.Name = "numInDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_76.ReadOnly = true;
            this.dataGridViewTextBoxColumn_76.Visible = false;
            this.dataGridViewTextBoxColumn_77.DataPropertyName = "dateIn";
            this.dataGridViewTextBoxColumn_77.HeaderText = "dateIn";
            this.dataGridViewTextBoxColumn_77.Name = "dateInDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_77.ReadOnly = true;
            this.dataGridViewTextBoxColumn_77.Visible = false;
            this.dataGridViewTextBoxColumn_78.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_78.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_78.Name = "idAbnDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_78.ReadOnly = true;
            this.dataGridViewTextBoxColumn_78.Visible = false;
            this.dataGridViewTextBoxColumn_79.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_79.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_79.Name = "idAbnObjDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_79.ReadOnly = true;
            this.dataGridViewTextBoxColumn_79.Visible = false;
            this.dataGridViewTextBoxColumn_80.DataPropertyName = "VoltageLevel";
            this.dataGridViewTextBoxColumn_80.HeaderText = "VoltageLevel";
            this.dataGridViewTextBoxColumn_80.Name = "voltageLevelDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_80.ReadOnly = true;
            this.dataGridViewTextBoxColumn_80.Visible = false;
            this.dataGridViewTextBoxColumn_81.DataPropertyName = "VoltageValue";
            this.dataGridViewTextBoxColumn_81.HeaderText = "VoltageValue";
            this.dataGridViewTextBoxColumn_81.Name = "voltageValueDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_81.ReadOnly = true;
            this.dataGridViewTextBoxColumn_81.Visible = false;
            this.dataGridViewTextBoxColumn_82.DataPropertyName = "IdParent";
            this.dataGridViewTextBoxColumn_82.HeaderText = "IdParent";
            this.dataGridViewTextBoxColumn_82.Name = "idParentDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_82.ReadOnly = true;
            this.dataGridViewTextBoxColumn_82.Visible = false;
            this.bindingSource_2.DataMember = "vTC_RequestHistory";
            this.bindingSource_2.DataSource = this.dataSetTechConnection_0;
            this.dataGridViewTextBoxColumn_41.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_41.DataPropertyName = "Work";
            style19.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_41.DefaultCellStyle = style19;
            this.dataGridViewTextBoxColumn_41.HeaderText = "Работы сетевой организации";
            this.dataGridViewTextBoxColumn_41.Name = "workDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_41.ReadOnly = true;
            this.dataGridViewTextBoxColumn_41.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_42.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_42.HeaderText = "id";
            this.dataGridViewTextBoxColumn_42.Name = "idNetWorkDgvColumn";
            this.dataGridViewTextBoxColumn_42.ReadOnly = true;
            this.dataGridViewTextBoxColumn_42.Visible = false;
            this.dataGridViewTextBoxColumn_43.DataPropertyName = "idTU";
            this.dataGridViewTextBoxColumn_43.HeaderText = "idTU";
            this.dataGridViewTextBoxColumn_43.Name = "idTUNetWorkDgvColumn";
            this.dataGridViewTextBoxColumn_43.ReadOnly = true;
            this.dataGridViewTextBoxColumn_43.Visible = false;
            this.dataGridViewTextBoxColumn_44.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn_44.HeaderText = "num";
            this.dataGridViewTextBoxColumn_44.Name = "numNetWorkDgvColumn";
            this.dataGridViewTextBoxColumn_44.ReadOnly = true;
            this.dataGridViewTextBoxColumn_44.Visible = false;
            this.dataGridViewTextBoxColumn_45.DataPropertyName = "TypeWork";
            this.dataGridViewTextBoxColumn_45.HeaderText = "TypeWork";
            this.dataGridViewTextBoxColumn_45.Name = "typeWorkNetWorkDgvColumn";
            this.dataGridViewTextBoxColumn_45.ReadOnly = true;
            this.dataGridViewTextBoxColumn_45.Visible = false;
            this.bindingSource_5.DataMember = "tTC_TUTypeWork";
            this.bindingSource_5.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_5.Filter = "TypeWork = 1";
            this.bindingSource_5.Sort = "num";
            this.dataGridViewTextBoxColumn_46.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_46.DataPropertyName = "Work";
            style20.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_46.DefaultCellStyle = style20;
            this.dataGridViewTextBoxColumn_46.HeaderText = "Работы заказчика";
            this.dataGridViewTextBoxColumn_46.Name = "workDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_46.ReadOnly = true;
            this.dataGridViewTextBoxColumn_46.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_47.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_47.HeaderText = "id";
            this.dataGridViewTextBoxColumn_47.Name = "idClientWorkDgvColumn";
            this.dataGridViewTextBoxColumn_47.ReadOnly = true;
            this.dataGridViewTextBoxColumn_47.Visible = false;
            this.dataGridViewTextBoxColumn_48.DataPropertyName = "idTU";
            this.dataGridViewTextBoxColumn_48.HeaderText = "idTU";
            this.dataGridViewTextBoxColumn_48.Name = "idTUClientWorkDgvColumn";
            this.dataGridViewTextBoxColumn_48.ReadOnly = true;
            this.dataGridViewTextBoxColumn_48.Visible = false;
            this.dataGridViewTextBoxColumn_49.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn_49.HeaderText = "num";
            this.dataGridViewTextBoxColumn_49.Name = "numClientWorkDgvColumn";
            this.dataGridViewTextBoxColumn_49.ReadOnly = true;
            this.dataGridViewTextBoxColumn_49.Visible = false;
            this.dataGridViewTextBoxColumn_50.DataPropertyName = "TypeWork";
            this.dataGridViewTextBoxColumn_50.HeaderText = "TypeWork";
            this.dataGridViewTextBoxColumn_50.Name = "typeWorkClientWorkDgvColumn";
            this.dataGridViewTextBoxColumn_50.ReadOnly = true;
            this.dataGridViewTextBoxColumn_50.Visible = false;
            this.bindingSource_6.DataMember = "tTC_TUTypeWork";
            this.bindingSource_6.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_6.Filter = "TypeWork = 2";
            this.bindingSource_6.Sort = "num";
            this.dataGridViewTextBoxColumn_21.DataPropertyName = "TypeDocNameOut";
            this.dataGridViewTextBoxColumn_21.HeaderText = "Документ";
            this.dataGridViewTextBoxColumn_21.Name = "typeDocNameOutDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_21.ReadOnly = true;
            this.dataGridViewTextBoxColumn_22.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_22.HeaderText = "id";
            this.dataGridViewTextBoxColumn_22.Name = "idLinkDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_22.ReadOnly = true;
            this.dataGridViewTextBoxColumn_22.Visible = false;
            this.dataGridViewTextBoxColumn_23.DataPropertyName = "numDateDocOut";
            this.dataGridViewTextBoxColumn_23.HeaderText = "numDateDocOut";
            this.dataGridViewTextBoxColumn_23.Name = "numDateDocOutDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_23.ReadOnly = true;
            this.dataGridViewTextBoxColumn_23.Visible = false;
            this.dataGridViewTextBoxColumn_25.DataPropertyName = "numDocOut";
            this.dataGridViewTextBoxColumn_25.HeaderText = "№";
            this.dataGridViewTextBoxColumn_25.Name = "numDocOutDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_25.ReadOnly = true;
            this.dataGridViewTextBoxColumn_28.DataPropertyName = "dateDocOut";
            style21.Format = "d";
            style21.NullValue = null;
            this.dataGridViewTextBoxColumn_28.DefaultCellStyle = style21;
            this.dataGridViewTextBoxColumn_28.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_28.Name = "dateDocOutDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_28.ReadOnly = true;
            this.dataGridViewTextBoxColumn_29.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn_29.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn_29.Name = "statusDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_29.ReadOnly = true;
            this.dataGridViewTextBoxColumn_29.Visible = false;
            this.dataGridViewTextBoxColumn_31.DataPropertyName = "SendModeName";
            this.dataGridViewTextBoxColumn_31.HeaderText = "Способ отправки";
            this.dataGridViewTextBoxColumn_31.Name = "sendModeNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_31.ReadOnly = true;
            this.dataGridViewTextBoxColumn_31.Visible = false;
            this.dataGridViewTextBoxColumn_32.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn_32.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn_32.Name = "numberDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_32.ReadOnly = true;
            this.dataGridViewTextBoxColumn_33.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn_33.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_33.Name = "commentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_33.ReadOnly = true;
            this.dataGridViewTextBoxColumn_33.Visible = false;
            this.bindingSource_3.DataMember = "vTC_DocOut";
            this.bindingSource_3.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_3.CurrentChanged += new EventHandler(this.bindingSource_3_CurrentChanged);
            this.dataGridViewTextBoxColumn_83.DataPropertyName = "statusName";
            this.dataGridViewTextBoxColumn_83.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn_83.Name = "statusNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_83.ReadOnly = true;
            this.dataGridViewTextBoxColumn_84.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_84.HeaderText = "id";
            this.dataGridViewTextBoxColumn_84.Name = "idDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_84.ReadOnly = true;
            this.dataGridViewTextBoxColumn_84.Visible = false;
            this.dataGridViewTextBoxColumn_85.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_85.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_85.Name = "idDocDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_85.ReadOnly = true;
            this.dataGridViewTextBoxColumn_85.Visible = false;
            this.dataGridViewTextBoxColumn_86.DataPropertyName = "idStatus";
            this.dataGridViewTextBoxColumn_86.HeaderText = "idStatus";
            this.dataGridViewTextBoxColumn_86.Name = "idStatusDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_86.ReadOnly = true;
            this.dataGridViewTextBoxColumn_86.Visible = false;
            this.dataGridViewTextBoxColumn_87.DataPropertyName = "DateChange";
            this.dataGridViewTextBoxColumn_87.HeaderText = "Дата отправки";
            this.dataGridViewTextBoxColumn_87.Name = "dateChangeDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_87.ReadOnly = true;
            this.dataGridViewTextBoxColumn_88.DataPropertyName = "SendMode";
            this.dataGridViewTextBoxColumn_88.HeaderText = "SendMode";
            this.dataGridViewTextBoxColumn_88.Name = "sendModeDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_88.ReadOnly = true;
            this.dataGridViewTextBoxColumn_88.Visible = false;
            this.dataGridViewTextBoxColumn_89.DataPropertyName = "SendName";
            this.dataGridViewTextBoxColumn_89.HeaderText = "Способ отправки";
            this.dataGridViewTextBoxColumn_89.Name = "sendNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_89.ReadOnly = true;
            this.dataGridViewTextBoxColumn_90.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_90.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_90.Name = "commentDataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn_90.ReadOnly = true;
            this.bindingSource_4.DataMember = "vTC_DocStatus";
            this.bindingSource_4.DataSource = this.dataSetTechConnection_0;
            this.dataGridViewTextBoxColumn_51.DataPropertyName = "typeDocName";
            this.dataGridViewTextBoxColumn_51.HeaderText = "Тип документа";
            this.dataGridViewTextBoxColumn_51.Name = "typeDocNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_51.ReadOnly = true;
            this.dataGridViewTextBoxColumn_52.DataPropertyName = "numDoc";
            this.dataGridViewTextBoxColumn_52.HeaderText = "№ документа";
            this.dataGridViewTextBoxColumn_52.Name = "numDocDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_52.ReadOnly = true;
            this.dataGridViewTextBoxColumn_53.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_53.HeaderText = "id";
            this.dataGridViewTextBoxColumn_53.Name = "idDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_53.ReadOnly = true;
            this.dataGridViewTextBoxColumn_53.Visible = false;
            this.dataGridViewTextBoxColumn_54.DataPropertyName = "dateDoc";
            this.dataGridViewTextBoxColumn_54.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_54.Name = "dateDocDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_54.ReadOnly = true;
            this.dataGridViewTextBoxColumn_55.DataPropertyName = "summa";
            style22.Format = "N2";
            style22.NullValue = null;
            this.dataGridViewTextBoxColumn_55.DefaultCellStyle = style22;
            this.dataGridViewTextBoxColumn_55.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn_55.Name = "summaDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_55.ReadOnly = true;
            this.dataGridViewTextBoxColumn_56.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn_56.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn_56.Name = "typeDocDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_56.ReadOnly = true;
            this.dataGridViewTextBoxColumn_56.Visible = false;
            this.dataGridViewTextBoxColumn_57.DataPropertyName = "Body";
            this.dataGridViewTextBoxColumn_57.HeaderText = "Body";
            this.dataGridViewTextBoxColumn_57.Name = "bodyDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_57.ReadOnly = true;
            this.dataGridViewTextBoxColumn_57.Visible = false;
            this.dataGridViewTextBoxColumn_58.DataPropertyName = "IdParent";
            this.dataGridViewTextBoxColumn_58.HeaderText = "IdParent";
            this.dataGridViewTextBoxColumn_58.Name = "idParentDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_58.ReadOnly = true;
            this.dataGridViewTextBoxColumn_58.Visible = false;
            this.dataGridViewTextBoxColumn_59.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_59.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_59.Name = "commentDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_59.ReadOnly = true;
            this.dataGridViewTextBoxColumn_60.DataPropertyName = "idDog";
            this.dataGridViewTextBoxColumn_60.HeaderText = "idDog";
            this.dataGridViewTextBoxColumn_60.Name = "idDogPaymentDgvColumn";
            this.dataGridViewTextBoxColumn_60.ReadOnly = true;
            this.dataGridViewTextBoxColumn_60.Visible = false;
            this.dataGridViewLinkColumn_1.DataPropertyName = "Dog";
            this.dataGridViewLinkColumn_1.HeaderText = "Договор";
            this.dataGridViewLinkColumn_1.Name = "dogPaymentDgvColumn";
            this.dataGridViewLinkColumn_1.ReadOnly = true;
            this.dataGridViewLinkColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewLinkColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
            this.bindingSource_7.DataMember = "vTC_Payment";
            this.bindingSource_7.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_7.Filter = "";
            this.bindingSource_7.Sort = "dateDoc desc";
            this.dataGridViewFilterDateTimePickerColumn_0.DataPropertyName = "DateShedule";
            style23.Format = "d";
            style23.NullValue = null;
            this.dataGridViewFilterDateTimePickerColumn_0.DefaultCellStyle = style23;
            this.dataGridViewFilterDateTimePickerColumn_0.HeaderText = "Дата";
            this.dataGridViewFilterDateTimePickerColumn_0.Name = "dateSheduleDataGridViewTextBoxColumn";
            this.dataGridViewFilterDateTimePickerColumn_0.ReadOnly = true;
            this.dataGridViewFilterDateTimePickerColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterDateTimePickerColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn_61.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_61.HeaderText = "id";
            this.dataGridViewTextBoxColumn_61.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn_61.ReadOnly = true;
            this.dataGridViewTextBoxColumn_61.Visible = false;
            this.dataGridViewTextBoxColumn_62.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_62.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_62.Name = "idDocPSDgvColumn";
            this.dataGridViewTextBoxColumn_62.ReadOnly = true;
            this.dataGridViewTextBoxColumn_62.Visible = false;
            this.dataGridViewTextBoxColumn_63.DataPropertyName = "Summa";
            style24.Format = "N2";
            style24.NullValue = null;
            this.dataGridViewTextBoxColumn_63.DefaultCellStyle = style24;
            this.dataGridViewTextBoxColumn_63.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn_63.Name = "dataGridViewNumericColumn1";
            this.dataGridViewTextBoxColumn_63.ReadOnly = true;
            this.dataGridViewTextBoxColumn_63.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_64.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_64.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_64.HeaderText = "Коментарий";
            this.dataGridViewTextBoxColumn_64.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn_64.ReadOnly = true;
            this.bindingSource_8.DataMember = "tTC_PaymentShedule";
            this.bindingSource_8.DataSource = this.dataSetTechConnection_0;
            this.dataSetTechConnection_1.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "numDoc";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "№ дог";
            this.dataGridViewFilterTextBoxColumn_0.Name = "numDocDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_91.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_91.HeaderText = "id";
            this.dataGridViewTextBoxColumn_91.Name = "idDgvColumn";
            this.dataGridViewTextBoxColumn_91.ReadOnly = true;
            this.dataGridViewTextBoxColumn_91.Visible = false;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "dateDoc";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Дата";
            this.dataGridViewFilterTextBoxColumn_1.Name = "dateDocDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.Width = 70;
            this.dataGridViewTextBoxColumn_92.DataPropertyName = "idTU";
            this.dataGridViewTextBoxColumn_92.HeaderText = "idTU";
            this.dataGridViewTextBoxColumn_92.Name = "idTUDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_92.ReadOnly = true;
            this.dataGridViewTextBoxColumn_92.Visible = false;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "numTU";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "№ТУ";
            this.dataGridViewFilterTextBoxColumn_2.Name = "numTUDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.Width = 60;
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "dateTU";
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Дата ТУ";
            this.dataGridViewFilterTextBoxColumn_3.Name = "dateTUDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.Width = 70;
            this.dataGridViewTextBoxColumn_93.DataPropertyName = "idRequest";
            this.dataGridViewTextBoxColumn_93.HeaderText = "idRequest";
            this.dataGridViewTextBoxColumn_93.Name = "idRequestDgvColumn";
            this.dataGridViewTextBoxColumn_93.ReadOnly = true;
            this.dataGridViewTextBoxColumn_93.Visible = false;
            this.dataGridViewTextBoxColumn_94.DataPropertyName = "numDateIn";
            this.dataGridViewTextBoxColumn_94.HeaderText = "numDateIn";
            this.dataGridViewTextBoxColumn_94.Name = "numDateInDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_94.ReadOnly = true;
            this.dataGridViewTextBoxColumn_94.Visible = false;
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "numIn";
            this.dataGridViewFilterTextBoxColumn_4.HeaderText = "№ входящего";
            this.dataGridViewFilterTextBoxColumn_4.Name = "numInDgvColumn";
            this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_4.Visible = false;
            this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "dateIn";
            this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Дата входящего";
            this.dataGridViewFilterTextBoxColumn_5.Name = "dateInDgvColumn";
            this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_5.Visible = false;
            this.dataGridViewTextBoxColumn_95.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_95.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_95.Name = "idAbnDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_95.ReadOnly = true;
            this.dataGridViewTextBoxColumn_95.Visible = false;
            this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "nameAbn";
            style25.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_6.DefaultCellStyle = style25;
            this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Потребитель";
            this.dataGridViewFilterTextBoxColumn_6.Name = "nameAbnDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_96.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_96.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_96.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_96.ReadOnly = true;
            this.dataGridViewTextBoxColumn_96.Visible = false;
            this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "nameObj";
            style26.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_7.DefaultCellStyle = style26;
            this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn_7.Name = "nameObjDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "address";
            this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Адрес";
            this.dataGridViewFilterTextBoxColumn_8.Name = "addressDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterProgressColumn_0.DataPropertyName = "SumContract";
            style27.Format = "N2";
            style27.NullValue = null;
            this.dataGridViewFilterProgressColumn_0.DefaultCellStyle = style27;
            this.dataGridViewFilterProgressColumn_0.HeaderText = "Цена договора";
            this.dataGridViewFilterProgressColumn_0.Name = "sumContractDgvColumn";
            this.dataGridViewFilterProgressColumn_0.set_ProgressBarColor(Color.FromArgb(0, 0xc0, 0));
            this.dataGridViewFilterProgressColumn_0.ReadOnly = true;
            this.dataGridViewFilterProgressColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "DateBegFact";
            this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Дата начала дейс-ия";
            this.dataGridViewFilterTextBoxColumn_9.Name = "dateBegFactDgvColumn";
            this.dataGridViewFilterTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_9.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "DateImplFact";
            this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Дата фактич вып-ия мер-ий";
            this.dataGridViewFilterTextBoxColumn_10.Name = "dateImplFactDgvColumn";
            this.dataGridViewFilterTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_10.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "DatePerfomance";
            this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Срок исполнения";
            this.dataGridViewFilterTextBoxColumn_11.Name = "datePerformanceDgvColumn";
            this.dataGridViewFilterTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_11.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "PowerSum";
            this.dataGridViewFilterTextBoxColumn_12.HeaderText = "Кол-во, кВт";
            this.dataGridViewFilterTextBoxColumn_12.Name = "powerSumDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_12.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "CategoryName";
            this.dataGridViewFilterTextBoxColumn_13.HeaderText = "Категория";
            this.dataGridViewFilterTextBoxColumn_13.Name = "categoryNameDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_13.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "VoltageLevel";
            this.dataGridViewFilterTextBoxColumn_14.HeaderText = "Ур-нь напр-ия";
            this.dataGridViewFilterTextBoxColumn_14.Name = "voltageLevelDataGridViewTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn_14.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_14.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "SchmTP";
            style28.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_15.DefaultCellStyle = style28;
            this.dataGridViewFilterTextBoxColumn_15.HeaderText = "ТП";
            this.dataGridViewFilterTextBoxColumn_15.Name = "schmTPDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_15.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_15.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "SchmCP";
            style29.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_16.DefaultCellStyle = style29;
            this.dataGridViewFilterTextBoxColumn_16.HeaderText = "ЦП";
            this.dataGridViewFilterTextBoxColumn_16.Name = "schmCPDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_16.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_16.Resizable = DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn_0.DataPropertyName = "IsCancel";
            this.dataGridViewCheckBoxColumn_0.HeaderText = "IsCancel";
            this.dataGridViewCheckBoxColumn_0.Name = "isCancelDgvColumn";
            this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_97.DataPropertyName = "SumPayment";
            this.dataGridViewTextBoxColumn_97.HeaderText = "SumPayment";
            this.dataGridViewTextBoxColumn_97.Name = "sumPaymentDgvColumn";
            this.dataGridViewTextBoxColumn_97.ReadOnly = true;
            this.dataGridViewTextBoxColumn_97.Visible = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x3c4, 0x20a);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.toolStrip_0);
            base.Name = "FormJournalContract";
            this.Text = "Договора на ТП";
            base.FormClosed += new FormClosedEventHandler(this.FormJournalContract_FormClosed);
            base.Load += new EventHandler(this.FormJournalContract_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.ResumeLayout(false);
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.splitContainer_1.Panel1.ResumeLayout(false);
            this.splitContainer_1.Panel2.ResumeLayout(false);
            this.splitContainer_1.ResumeLayout(false);
            this.dataGridViewExcelFilter_0.EndInit();
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.dataGridViewExcelFilter_1.EndInit();
            this.tabPage_1.ResumeLayout(false);
            this.dataGridViewExcelFilter_2.EndInit();
            this.tabPage_3.ResumeLayout(false);
            this.splitContainer_3.Panel1.ResumeLayout(false);
            this.splitContainer_3.Panel2.ResumeLayout(false);
            this.splitContainer_3.ResumeLayout(false);
            this.dataGridViewExcelFilter_5.EndInit();
            this.dataGridViewExcelFilter_6.EndInit();
            this.tabPage_2.ResumeLayout(false);
            this.splitContainer_2.Panel1.ResumeLayout(false);
            this.splitContainer_2.Panel1.PerformLayout();
            this.splitContainer_2.Panel2.ResumeLayout(false);
            this.splitContainer_2.Panel2.PerformLayout();
            this.splitContainer_2.ResumeLayout(false);
            this.dataGridViewExcelFilter_3.EndInit();
            this.toolStrip_2.ResumeLayout(false);
            this.toolStrip_2.PerformLayout();
            this.dataGridViewExcelFilter_4.EndInit();
            this.toolStrip_3.ResumeLayout(false);
            this.toolStrip_3.PerformLayout();
            this.tabPage_4.ResumeLayout(false);
            this.dataGridViewExcelFilter_7.EndInit();
            this.tabPage_5.ResumeLayout(false);
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetTechConnection_0.EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            ((ISupportInitialize) this.bindingSource_2).EndInit();
            ((ISupportInitialize) this.bindingSource_5).EndInit();
            ((ISupportInitialize) this.bindingSource_6).EndInit();
            ((ISupportInitialize) this.bindingSource_3).EndInit();
            ((ISupportInitialize) this.bindingSource_4).EndInit();
            ((ISupportInitialize) this.bindingSource_7).EndInit();
            ((ISupportInitialize) this.bindingSource_8).EndInit();
            this.dataSetTechConnection_1.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            Form12 form1 = new Form12();
            form1.set_SqlSettings(this.get_SqlSettings());
            form1.MdiParent = base.MdiParent;
            form1.FormClosed += new FormClosedEventHandler(this.method_1);
            form1.Show();
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if (this.int_0 != -1)
            {
                Form12 form1 = new Form12(this.int_0, -1, -1);
                form1.set_SqlSettings(this.get_SqlSettings());
                form1.MdiParent = base.MdiParent;
                form1.FormClosed += new FormClosedEventHandler(this.method_1);
                form1.Show();
            }
        }

        private void toolStripButton_10_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_3.CurrentRow != null)
            {
                if (Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_24.Name].Value) != this.int_0)
                {
                    MessageBox.Show("Невозможно редактировать данный документ");
                }
                else
                {
                    FormTechConnectionDocOutAddEdit edit = new FormTechConnectionDocOutAddEdit(Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_22.Name].Value), this.int_0);
                    edit.set_SqlSettings(this.get_SqlSettings());
                    if (edit.ShowDialog() == DialogResult.OK)
                    {
                        this.method_0();
                        this.dataGridViewExcelFilter_3.SearchGrid(this.dataGridViewTextBoxColumn_22.Name, edit.IdDocOut.ToString(), false);
                    }
                }
            }
        }

        private void toolStripButton_11_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_3.CurrentRow != null)
            {
                if (Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_24.Name].Value) != this.int_0)
                {
                    MessageBox.Show("Невозможно удалить данный документ");
                }
                else if (MessageBox.Show("Вы действительно хотите удалить текущий документ", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_22.Name].Value);
                    int num = Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_27.Name].Value);
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
                    this.dataGridViewExcelFilter_3.SearchGrid(this.dataGridViewTextBoxColumn_22.Name, edit.IdDocOut.ToString(), false);
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
                    int num = Convert.ToInt32(this.dataGridViewExcelFilter_4.CurrentRow.Cells[this.dataGridViewTextBoxColumn_34.Name].Value);
                    Form6 form1 = new Form6(num, this.int_3, true);
                    form1.set_SqlSettings(this.get_SqlSettings());
                    if (form1.ShowDialog() == DialogResult.OK)
                    {
                        this.method_5();
                        this.dataGridViewExcelFilter_4.SearchGrid(this.dataGridViewTextBoxColumn_34.Name, num.ToString(), false);
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
                    int num = Convert.ToInt32(this.dataGridViewExcelFilter_4.CurrentRow.Cells[this.dataGridViewTextBoxColumn_34.Name].Value);
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
            if (this.int_2 != -1)
            {
                FormJournalTU ltu1 = new FormJournalTU(this.int_2) {
                    MdiParent = base.MdiParent
                };
                ltu1.set_SqlSettings(this.get_SqlSettings());
                ltu1.Show();
            }
        }

        private void toolStripButton_18_Click(object sender, EventArgs e)
        {
            this.method_2(this.dataGridViewExcelFilter_0);
        }

        private void toolStripButton_19_Click(object sender, EventArgs e)
        {
            Form13 form1 = new Form13();
            form1.set_SqlSettings(this.get_SqlSettings());
            form1.MdiParent = base.MdiParent;
            form1.Show();
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if (((this.int_0 > 0) && (this.dataGridViewExcelFilter_0.CurrentRow != null)) && ((MessageBox.Show("Вы действительно хотите удалить текущую запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && base.DeleteSqlDataById(this.dataSetTechConnection_0.tTC_Doc, this.int_0)))
            {
                this.dataGridViewExcelFilter_0.Rows.Remove(this.dataGridViewExcelFilter_0.CurrentRow);
                MessageBox.Show("Запись успешно удалена");
            }
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_0.CurrentRow != null) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_93.Name].Value != null)) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_93.Name].Value != DBNull.Value))
            {
                FormTechConnectionRequest request1 = new FormTechConnectionRequest(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_93.Name].Value)) {
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
            this.method_0();
        }

        private void toolStripButton_9_Click(object sender, EventArgs e)
        {
            this.method_0();
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

