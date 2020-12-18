namespace Documents.Forms.TechnologicalConnection.ActTC
{
    using ControlsLbr.DataGridViewExcelFilter;
    using DataSql;
    using Documents.Forms.TechnologicalConnection;
    using Documents.Forms.TechnologicalConnection.Acts;
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
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using System.Xml;

    public class FormJournalActs : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_2;
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
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_34;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_35;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_36;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_37;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_38;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_39;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_40;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_41;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_42;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;
        private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;
        private DataGridViewLinkColumn dataGridViewLinkColumn_0;
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
        private DataSet dataSet_0;
        private DataSetTechConnection dataSetTechConnection_0;
        private DataSetTechConnection dataSetTechConnection_1;
        private DataTable dataTable_0;
        private DataTable dataTable_1;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private List<int> list_0;
        private SplitContainer splitContainer_0;
        private SplitContainer splitContainer_1;
        private TabControl tabControl_0;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_10;
        private ToolStripButton toolStripButton_11;
        private ToolStripButton toolStripButton_12;
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
        private ToolStripTextBox toolStripTextBox_0;
        private TreeView treeView_0;

        public FormJournalActs()
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = 0x4d8;
            this.method_8();
            this.method_4();
            this.method_0();
        }

        public FormJournalActs(List<int> checkedSubstation, int typeAct = 0x4d8)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = 0x4d8;
            this.method_8();
            this.method_4();
            this.list_0 = checkedSubstation;
            this.int_2 = typeAct;
            this.method_0();
        }

        public FormJournalActs(int int_3 = -1, int typeAct = 0x4d8)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.int_2 = 0x4d8;
            this.method_8();
            this.method_4();
            this.int_0 = int_3;
            this.int_2 = typeAct;
            this.method_0();
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
                this.method_5();
            }
            else
            {
                this.int_0 = -1;
                this.int_1 = -1;
                this.dataSetTechConnection_0.tTC_DocFile.Clear();
                this.dataSetTechConnection_0.vTC_Doc.Clear();
            }
            if (this.int_1 == -1)
            {
                this.dataSetTechConnection_0.vTC_RequestHistory.Clear();
            }
            else
            {
                DataSetTechConnection.tTC_DocDataTable table = new DataSetTechConnection.tTC_DocDataTable();
                base.SelectSqlData(table, true, " where id = " + this.int_1.ToString(), false);
                int num = this.int_1;
                if ((table.Rows.Count > 0) && (table.Rows[0]["idParent"] != DBNull.Value))
                {
                    num = Convert.ToInt32(table.Rows[0]["idParent"]);
                }
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_RequestHistory, true, "where id = " + num.ToString() + " or IdParent = " + num.ToString() + " order by dateDoc");
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
            int rowIndex = e.RowIndex;
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormJournalActs_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormJournalActs_Load(object sender, EventArgs e)
        {
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
            this.method_1();
            if (num != -1)
            {
                this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewFilterTextBoxColumn_20.Name, num.ToString(), false);
                if (this.dataGridViewExcelFilter_0.CurrentRow != null)
                {
                    this.dataGridViewExcelFilter_0.FirstDisplayedScrollingRowIndex = this.dataGridViewExcelFilter_0.CurrentRow.Index;
                }
            }
        }

        private void method_0()
        {
            switch (this.int_2)
            {
                case 0x4d6:
                    this.Text = "Журнал актов осмотра электроустановок";
                    break;

                case 0x4d7:
                    this.Text = "Журнал актов выполнения технических условий";
                    break;
            }
        }

        private void method_1()
        {
            int num = this.int_0;
            List<int> list = this.method_7(this.treeView_0.Nodes);
            string str = string.Format(" where DateDoc >= '{0}' and DateDoc <= '{1}' and typeDoc = {2} ", this.dateTimePicker_1.Value.ToString("yyyyMMdd"), this.dateTimePicker_0.Value.ToString("yyyyMMdd"), this.int_2);
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
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_Act, true, str);
            if (num > 0)
            {
                this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewFilterTextBoxColumn_20.Name, num.ToString(), false);
            }
        }

        private void method_2(object sender, FormClosedEventArgs e)
        {
            switch (this.int_2)
            {
                case 0x4d6:
                    this.int_0 = ((FormActElectricalInspection) sender).IdAct;
                    break;

                case 0x4d7:
                    this.int_0 = ((FormActPerformingTU) sender).IdAct;
                    break;

                case 0x4d8:
                    this.int_0 = ((FormTCAddEdit) sender).IdTC;
                    break;
            }
            this.method_1();
        }

        private void method_3(DataGridView dataGridView_0)
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

        private void method_4()
        {
            this.dateTimePicker_1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePicker_0.Value = new DateTime(DateTime.Now.Year, 12, 0x1f);
        }

        private void method_5()
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormJournalActs));
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
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripButton_9 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_11 = new ToolStripButton();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripButton_6 = new ToolStripButton();
            this.toolStripSeparator_3 = new ToolStripSeparator();
            this.toolStripButton_10 = new ToolStripButton();
            this.toolStripButton_12 = new ToolStripButton();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetTechConnection_0 = new DataSetTechConnection();
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
            this.dataSet_0 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataTable_1 = new DataTable();
            this.dataColumn_2 = new DataColumn();
            this.dataColumn_3 = new DataColumn();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
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
            this.dataSetTechConnection_1 = new DataSetTechConnection();
            this.dataGridViewFilterTextBoxColumn_17 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_87 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_18 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_19 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_20 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_21 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_22 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_23 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_24 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_25 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_26 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_27 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_28 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_29 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_30 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_31 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_32 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_33 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_34 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_35 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_36 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_37 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_38 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_88 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_89 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_39 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_40 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_41 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_42 = new DataGridViewFilterTextBoxColumn();
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
            this.dataSet_0.BeginInit();
            this.dataTable_0.BeginInit();
            this.dataTable_1.BeginInit();
            this.dataSetTechConnection_1.BeginInit();
            base.SuspendLayout();
            this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripSeparator_2, this.toolStripButton_9, this.toolStripSeparator_0, this.toolStripButton_11, this.toolStripButton_3, this.toolStripSeparator_1, this.toolStripButton_4, this.toolStripTextBox_0, this.toolStripButton_5, this.toolStripButton_6, this.toolStripSeparator_3, this.toolStripButton_10, this.toolStripButton_12 };
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
            this.toolStripButton_0.Text = "Добавить акт";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = (Image) manager.GetObject("toolBtnEditTU.Image");
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnEditTU";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Редактировать акт";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = (Image) manager.GetObject("toolBtnDelTU.Image");
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnDelTU";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Удалить акт";
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
            this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_11.Image = Resources._1381484495_Terms_rev;
            this.toolStripButton_11.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_11.Name = "toolBtnShowTU";
            this.toolStripButton_11.Size = new Size(0x17, 0x16);
            this.toolStripButton_11.Text = "Открыть тех условие";
            this.toolStripButton_11.Click += new EventHandler(this.toolStripButton_11_Click);
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
            this.toolStripSeparator_3.Name = "toolStripSeparator4";
            this.toolStripSeparator_3.Size = new Size(6, 0x19);
            this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_10.Image = (Image) manager.GetObject("toolBtnExportExcel.Image");
            this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_10.Name = "toolBtnExportExcel";
            this.toolStripButton_10.Size = new Size(0x17, 0x16);
            this.toolStripButton_10.Text = "Экспорт в Excel";
            this.toolStripButton_10.Click += new EventHandler(this.toolStripButton_10_Click);
            this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_12.Image = Resources.printer;
            this.toolStripButton_12.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_12.Name = "toolBtnPrint";
            this.toolStripButton_12.Size = new Size(0x17, 0x16);
            this.toolStripButton_12.Text = "Печать";
            this.toolStripButton_12.Click += new EventHandler(this.toolStripButton_12_Click);
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
                this.dataGridViewFilterTextBoxColumn_17, this.dataGridViewTextBoxColumn_87, this.dataGridViewFilterTextBoxColumn_18, this.dataGridViewFilterTextBoxColumn_19, this.dataGridViewFilterTextBoxColumn_20, this.dataGridViewFilterTextBoxColumn_21, this.dataGridViewFilterTextBoxColumn_22, this.dataGridViewFilterTextBoxColumn_23, this.dataGridViewFilterTextBoxColumn_24, this.dataGridViewFilterTextBoxColumn_25, this.dataGridViewFilterTextBoxColumn_26, this.dataGridViewFilterTextBoxColumn_27, this.dataGridViewFilterTextBoxColumn_28, this.dataGridViewFilterTextBoxColumn_29, this.dataGridViewFilterTextBoxColumn_30, this.dataGridViewFilterTextBoxColumn_31,
                this.dataGridViewFilterTextBoxColumn_32, this.dataGridViewFilterTextBoxColumn_33, this.dataGridViewFilterTextBoxColumn_34, this.dataGridViewFilterTextBoxColumn_35, this.dataGridViewFilterTextBoxColumn_36, this.dataGridViewFilterTextBoxColumn_37, this.dataGridViewFilterTextBoxColumn_38, this.dataGridViewTextBoxColumn_88, this.dataGridViewTextBoxColumn_89, this.dataGridViewFilterTextBoxColumn_39, this.dataGridViewFilterTextBoxColumn_40, this.dataGridViewFilterTextBoxColumn_41, this.dataGridViewFilterTextBoxColumn_42
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
            this.dataGridViewExcelFilter_0.Name = "dgvTС";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Control;
            style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
            style3.ForeColor = SystemColors.WindowText;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.True;
            this.dataGridViewExcelFilter_0.RowHeadersDefaultCellStyle = style3;
            this.dataGridViewExcelFilter_0.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_0.Size = new Size(0x315, 0x126);
            this.dataGridViewExcelFilter_0.TabIndex = 1;
            this.dataGridViewExcelFilter_0.VirtualMode = true;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.dataGridViewExcelFilter_0.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_0_RowPostPaint);
            this.bindingSource_0.DataMember = "vTC_Act";
            this.bindingSource_0.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
            this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
            this.treeView_0.Location = new Point(0, 0x74);
            this.treeView_0.Name = "treeViewSubstation";
            this.treeView_0.Size = new Size(0xab, 0x17a);
            this.treeView_0.TabIndex = 12;
            this.treeView_0.AfterCheck += new TreeViewEventHandler(this.treeView_0_AfterCheck);
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(12, 0x67);
            this.label_2.Name = "label6";
            this.label_2.Size = new Size(0x44, 13);
            this.label_2.TabIndex = 11;
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
            this.dataSet_0.DataSetName = "NewDataSet";
            DataTable[] tables = new DataTable[] { this.dataTable_0, this.dataTable_1 };
            this.dataSet_0.Tables.AddRange(tables);
            DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1 };
            this.dataTable_0.Columns.AddRange(columns);
            this.dataTable_0.TableName = "tTC_DocFile";
            this.dataColumn_0.ColumnName = "id";
            this.dataColumn_0.DataType = typeof(int);
            this.dataColumn_1.ColumnName = "FileName";
            DataColumn[] columnArray5 = new DataColumn[] { this.dataColumn_2, this.dataColumn_3 };
            this.dataTable_1.Columns.AddRange(columnArray5);
            this.dataTable_1.TableName = "tAbnObjDoc_File";
            this.dataColumn_2.ColumnName = "id";
            this.dataColumn_3.ColumnName = "FileName";
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "NumDateIn";
            style13.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_0.DefaultCellStyle = style13;
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
            style14.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.DefaultCellStyle = style14;
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Содержание";
            this.dataGridViewFilterTextBoxColumn_3.Name = "dataGridViewFilterTextBoxColumn4";
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "nameAbn";
            style15.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_4.DefaultCellStyle = style15;
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
            this.dataGridViewTextBoxColumn_22.DataPropertyName = "addressFull";
            this.dataGridViewTextBoxColumn_22.HeaderText = "addressFull";
            this.dataGridViewTextBoxColumn_22.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn_22.Visible = false;
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
            this.dataGridViewTextBoxColumn_23.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn_23.HeaderText = "Category";
            this.dataGridViewTextBoxColumn_23.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn_23.Visible = false;
            this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "CategoryName";
            this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Категор. элек-ния";
            this.dataGridViewFilterTextBoxColumn_11.Name = "dataGridViewFilterTextBoxColumn12";
            this.dataGridViewFilterTextBoxColumn_11.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_24.DataPropertyName = "idSchmObj";
            this.dataGridViewTextBoxColumn_24.HeaderText = "idSchmObj";
            this.dataGridViewTextBoxColumn_24.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn_24.Visible = false;
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
            this.dataGridViewTextBoxColumn_25.DataPropertyName = "NameDocOut";
            style16.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_25.DefaultCellStyle = style16;
            this.dataGridViewTextBoxColumn_25.HeaderText = "Выданные документы";
            this.dataGridViewTextBoxColumn_25.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn_26.DataPropertyName = "Performer";
            this.dataGridViewTextBoxColumn_26.HeaderText = "Performer";
            this.dataGridViewTextBoxColumn_26.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn_26.Visible = false;
            this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "SchmTP";
            style17.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_15.DefaultCellStyle = style17;
            this.dataGridViewFilterTextBoxColumn_15.HeaderText = "ТП";
            this.dataGridViewFilterTextBoxColumn_15.Name = "dataGridViewFilterTextBoxColumn16";
            this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "SchmCP";
            style18.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_16.DefaultCellStyle = style18;
            this.dataGridViewFilterTextBoxColumn_16.HeaderText = "ЦП";
            this.dataGridViewFilterTextBoxColumn_16.Name = "dataGridViewFilterTextBoxColumn17";
            this.dataGridViewFilterTextBoxColumn_16.Width = 150;
            this.dataGridViewTextBoxColumn_27.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_27.HeaderText = "id";
            this.dataGridViewTextBoxColumn_27.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn_27.Visible = false;
            this.dataGridViewTextBoxColumn_28.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_28.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_28.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn_28.Visible = false;
            this.dataGridViewTextBoxColumn_29.DataPropertyName = "dateChange";
            this.dataGridViewTextBoxColumn_29.HeaderText = "dateChange";
            this.dataGridViewTextBoxColumn_29.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn_29.Visible = false;
            this.dataGridViewTextBoxColumn_30.DataPropertyName = "idTemplate";
            this.dataGridViewTextBoxColumn_30.HeaderText = "idTemplate";
            this.dataGridViewTextBoxColumn_30.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn_30.Visible = false;
            this.dataGridViewTextBoxColumn_31.DataPropertyName = "numDateIn";
            style19.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_31.DefaultCellStyle = style19;
            this.dataGridViewTextBoxColumn_31.HeaderText = "№, дата вход.";
            this.dataGridViewTextBoxColumn_31.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn_31.Width = 80;
            this.dataGridViewTextBoxColumn_32.DataPropertyName = "numDoc";
            this.dataGridViewTextBoxColumn_32.HeaderText = "numDoc";
            this.dataGridViewTextBoxColumn_32.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn_32.Visible = false;
            this.dataGridViewTextBoxColumn_33.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_33.HeaderText = "id";
            this.dataGridViewTextBoxColumn_33.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn_33.Visible = false;
            this.dataGridViewTextBoxColumn_34.DataPropertyName = "dateDoc";
            this.dataGridViewTextBoxColumn_34.HeaderText = "Дата получения";
            this.dataGridViewTextBoxColumn_34.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn_34.Width = 80;
            this.dataGridViewTextBoxColumn_35.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn_35.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn_35.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn_35.Visible = false;
            this.dataGridViewTextBoxColumn_36.DataPropertyName = "numIn";
            this.dataGridViewTextBoxColumn_36.HeaderText = "numIn";
            this.dataGridViewTextBoxColumn_36.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn_36.Visible = false;
            this.dataGridViewTextBoxColumn_37.DataPropertyName = "dateIn";
            this.dataGridViewTextBoxColumn_37.HeaderText = "dateIn";
            this.dataGridViewTextBoxColumn_37.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn_37.Visible = false;
            this.dataGridViewTextBoxColumn_38.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_38.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_38.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn_38.Visible = false;
            this.dataGridViewTextBoxColumn_39.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_39.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_39.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn_39.Visible = false;
            this.dataGridViewTextBoxColumn_40.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_40.DataPropertyName = "body";
            style20.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_40.DefaultCellStyle = style20;
            this.dataGridViewTextBoxColumn_40.HeaderText = "Тело письма";
            this.dataGridViewTextBoxColumn_40.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn_41.DataPropertyName = "PowerCurrent";
            this.dataGridViewTextBoxColumn_41.HeaderText = "Текущая мощность";
            this.dataGridViewTextBoxColumn_41.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn_41.Width = 70;
            this.dataGridViewTextBoxColumn_42.DataPropertyName = "PowerAdd";
            this.dataGridViewTextBoxColumn_42.HeaderText = "Доп мощность";
            this.dataGridViewTextBoxColumn_42.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn_42.Width = 70;
            this.dataGridViewTextBoxColumn_43.DataPropertyName = "Power";
            this.dataGridViewTextBoxColumn_43.HeaderText = "Суммарная мощность";
            this.dataGridViewTextBoxColumn_43.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn_43.Width = 70;
            this.dataGridViewTextBoxColumn_44.DataPropertyName = "VoltageName";
            this.dataGridViewTextBoxColumn_44.HeaderText = "Напряжение";
            this.dataGridViewTextBoxColumn_44.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn_44.Width = 70;
            this.dataGridViewTextBoxColumn_45.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_45.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_45.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn_45.Width = 70;
            this.dataGridViewTextBoxColumn_46.DataPropertyName = "VoltageLevel";
            this.dataGridViewTextBoxColumn_46.HeaderText = "VoltageLevel";
            this.dataGridViewTextBoxColumn_46.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn_46.Visible = false;
            this.dataGridViewTextBoxColumn_47.DataPropertyName = "VoltageValue";
            this.dataGridViewTextBoxColumn_47.HeaderText = "VoltageValue";
            this.dataGridViewTextBoxColumn_47.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn_47.Visible = false;
            this.dataGridViewTextBoxColumn_48.DataPropertyName = "IdParent";
            this.dataGridViewTextBoxColumn_48.HeaderText = "IdParent";
            this.dataGridViewTextBoxColumn_48.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn_48.Visible = false;
            this.dataGridViewTextBoxColumn_49.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_49.DataPropertyName = "Work";
            style21.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_49.DefaultCellStyle = style21;
            this.dataGridViewTextBoxColumn_49.HeaderText = "Работы сетевой организации";
            this.dataGridViewTextBoxColumn_49.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn_49.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_50.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_50.HeaderText = "id";
            this.dataGridViewTextBoxColumn_50.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn_50.Visible = false;
            this.dataGridViewTextBoxColumn_51.DataPropertyName = "idTU";
            this.dataGridViewTextBoxColumn_51.HeaderText = "idTU";
            this.dataGridViewTextBoxColumn_51.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn_51.Visible = false;
            this.dataGridViewTextBoxColumn_52.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn_52.HeaderText = "num";
            this.dataGridViewTextBoxColumn_52.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn_52.Visible = false;
            this.dataGridViewTextBoxColumn_53.DataPropertyName = "TypeWork";
            this.dataGridViewTextBoxColumn_53.HeaderText = "TypeWork";
            this.dataGridViewTextBoxColumn_53.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn_53.Visible = false;
            this.dataGridViewTextBoxColumn_54.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_54.DataPropertyName = "Work";
            style22.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_54.DefaultCellStyle = style22;
            this.dataGridViewTextBoxColumn_54.HeaderText = "Работы заказчика";
            this.dataGridViewTextBoxColumn_54.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn_54.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_55.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_55.HeaderText = "id";
            this.dataGridViewTextBoxColumn_55.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn_55.Visible = false;
            this.dataGridViewTextBoxColumn_56.DataPropertyName = "idTU";
            this.dataGridViewTextBoxColumn_56.HeaderText = "idTU";
            this.dataGridViewTextBoxColumn_56.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn_56.Visible = false;
            this.dataGridViewTextBoxColumn_57.DataPropertyName = "num";
            this.dataGridViewTextBoxColumn_57.HeaderText = "num";
            this.dataGridViewTextBoxColumn_57.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn_57.Visible = false;
            this.dataGridViewTextBoxColumn_58.DataPropertyName = "TypeWork";
            this.dataGridViewTextBoxColumn_58.HeaderText = "TypeWork";
            this.dataGridViewTextBoxColumn_58.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn_58.Visible = false;
            this.dataGridViewTextBoxColumn_59.DataPropertyName = "TypeDocNameOut";
            this.dataGridViewTextBoxColumn_59.HeaderText = "Документ";
            this.dataGridViewTextBoxColumn_59.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn_60.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_60.HeaderText = "id";
            this.dataGridViewTextBoxColumn_60.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn_60.Visible = false;
            this.dataGridViewTextBoxColumn_61.DataPropertyName = "numDateDocOut";
            this.dataGridViewTextBoxColumn_61.HeaderText = "numDateDocOut";
            this.dataGridViewTextBoxColumn_61.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn_61.Visible = false;
            this.dataGridViewTextBoxColumn_62.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_62.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_62.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn_62.Visible = false;
            this.dataGridViewTextBoxColumn_63.DataPropertyName = "numDocOut";
            this.dataGridViewTextBoxColumn_63.HeaderText = "№";
            this.dataGridViewTextBoxColumn_63.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn_64.DataPropertyName = "TypeDocOut";
            this.dataGridViewTextBoxColumn_64.HeaderText = "TypeDocOut";
            this.dataGridViewTextBoxColumn_64.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn_64.Visible = false;
            this.dataGridViewTextBoxColumn_65.DataPropertyName = "idDocOut";
            this.dataGridViewTextBoxColumn_65.HeaderText = "idDocOut";
            this.dataGridViewTextBoxColumn_65.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn_65.Visible = false;
            this.dataGridViewTextBoxColumn_66.DataPropertyName = "dateDocOut";
            style23.Format = "d";
            style23.NullValue = null;
            this.dataGridViewTextBoxColumn_66.DefaultCellStyle = style23;
            this.dataGridViewTextBoxColumn_66.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_66.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn_67.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn_67.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn_67.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn_67.Visible = false;
            this.dataGridViewTextBoxColumn_68.DataPropertyName = "BodyDocOut";
            this.dataGridViewTextBoxColumn_68.HeaderText = "Содержание";
            this.dataGridViewTextBoxColumn_68.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn_69.DataPropertyName = "SendModeName";
            this.dataGridViewTextBoxColumn_69.HeaderText = "Способ отправки";
            this.dataGridViewTextBoxColumn_69.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn_69.Visible = false;
            this.dataGridViewTextBoxColumn_70.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn_70.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn_70.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn_71.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn_71.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_71.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn_71.Visible = false;
            this.dataGridViewTextBoxColumn_72.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_72.HeaderText = "id";
            this.dataGridViewTextBoxColumn_72.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn_72.Visible = false;
            this.dataGridViewTextBoxColumn_73.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_73.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_73.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn_73.Visible = false;
            this.dataGridViewTextBoxColumn_74.DataPropertyName = "idStatus";
            this.dataGridViewTextBoxColumn_74.HeaderText = "idStatus";
            this.dataGridViewTextBoxColumn_74.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn_74.Visible = false;
            this.dataGridViewTextBoxColumn_75.DataPropertyName = "statusName";
            this.dataGridViewTextBoxColumn_75.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn_75.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn_75.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_76.DataPropertyName = "DateChange";
            style24.Format = "d";
            style24.NullValue = null;
            this.dataGridViewTextBoxColumn_76.DefaultCellStyle = style24;
            this.dataGridViewTextBoxColumn_76.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_76.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn_76.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_76.Width = 70;
            this.dataGridViewTextBoxColumn_77.DataPropertyName = "SendName";
            this.dataGridViewTextBoxColumn_77.HeaderText = "Способ отправки";
            this.dataGridViewTextBoxColumn_77.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn_78.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_78.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_78.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn_79.DataPropertyName = "typeDocName";
            this.dataGridViewTextBoxColumn_79.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn_79.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn_79.Width = 150;
            this.dataGridViewTextBoxColumn_80.DataPropertyName = "numDoc";
            this.dataGridViewTextBoxColumn_80.HeaderText = "№ акта";
            this.dataGridViewTextBoxColumn_80.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn_81.DataPropertyName = "dateDoc";
            this.dataGridViewTextBoxColumn_81.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_81.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn_82.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_82.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_82.Name = "dataGridViewTextBoxColumn67";
            this.dataGridViewTextBoxColumn_83.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_83.HeaderText = "id";
            this.dataGridViewTextBoxColumn_83.Name = "dataGridViewTextBoxColumn68";
            this.dataGridViewTextBoxColumn_83.Visible = false;
            this.dataGridViewTextBoxColumn_84.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn_84.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn_84.Name = "dataGridViewTextBoxColumn69";
            this.dataGridViewTextBoxColumn_84.Visible = false;
            this.dataGridViewTextBoxColumn_85.DataPropertyName = "Body";
            this.dataGridViewTextBoxColumn_85.HeaderText = "Body";
            this.dataGridViewTextBoxColumn_85.Name = "dataGridViewTextBoxColumn70";
            this.dataGridViewTextBoxColumn_85.Visible = false;
            this.dataGridViewTextBoxColumn_86.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_86.HeaderText = "id";
            this.dataGridViewTextBoxColumn_86.Name = "dataGridViewTextBoxColumn71";
            this.dataGridViewTextBoxColumn_86.Visible = false;
            this.dataSetTechConnection_1.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.dataGridViewFilterTextBoxColumn_17.DataPropertyName = "numDoc";
            this.dataGridViewFilterTextBoxColumn_17.HeaderText = "№ ТП";
            this.dataGridViewFilterTextBoxColumn_17.Name = "numDocDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_17.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_87.DataPropertyName = "dateDoc";
            this.dataGridViewTextBoxColumn_87.HeaderText = "Дата ТП";
            this.dataGridViewTextBoxColumn_87.Name = "dateDocDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_87.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_18.DataPropertyName = "nameAbn";
            style25.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_18.DefaultCellStyle = style25;
            this.dataGridViewFilterTextBoxColumn_18.HeaderText = "Потребитель";
            this.dataGridViewFilterTextBoxColumn_18.Name = "nameAbnDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_18.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_18.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_19.DataPropertyName = "nameObj";
            style26.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_19.DefaultCellStyle = style26;
            this.dataGridViewFilterTextBoxColumn_19.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn_19.Name = "nameObjDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_19.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_19.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_20.DataPropertyName = "id";
            this.dataGridViewFilterTextBoxColumn_20.HeaderText = "id";
            this.dataGridViewFilterTextBoxColumn_20.Name = "idDgvColumn";
            this.dataGridViewFilterTextBoxColumn_20.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_20.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_20.Visible = false;
            this.dataGridViewFilterTextBoxColumn_21.DataPropertyName = "numIn";
            this.dataGridViewFilterTextBoxColumn_21.HeaderText = "№ вх.";
            this.dataGridViewFilterTextBoxColumn_21.Name = "numInDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_21.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_21.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_21.Visible = false;
            this.dataGridViewFilterTextBoxColumn_22.DataPropertyName = "DateIn";
            this.dataGridViewFilterTextBoxColumn_22.HeaderText = "Дата вх.";
            this.dataGridViewFilterTextBoxColumn_22.Name = "dateInDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_22.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_22.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_22.Visible = false;
            this.dataGridViewFilterTextBoxColumn_23.DataPropertyName = "numDateIn";
            this.dataGridViewFilterTextBoxColumn_23.HeaderText = "№ и дата вх.";
            this.dataGridViewFilterTextBoxColumn_23.Name = "numDateInDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_23.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_23.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_23.Visible = false;
            this.dataGridViewFilterTextBoxColumn_24.DataPropertyName = "idTU";
            this.dataGridViewFilterTextBoxColumn_24.HeaderText = "idTU";
            this.dataGridViewFilterTextBoxColumn_24.Name = "idTUDgvColumn";
            this.dataGridViewFilterTextBoxColumn_24.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_24.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_24.Visible = false;
            this.dataGridViewFilterTextBoxColumn_25.DataPropertyName = "body";
            this.dataGridViewFilterTextBoxColumn_25.HeaderText = "body";
            this.dataGridViewFilterTextBoxColumn_25.Name = "bodyDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_25.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_25.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_25.Visible = false;
            this.dataGridViewFilterTextBoxColumn_26.DataPropertyName = "idRequest";
            this.dataGridViewFilterTextBoxColumn_26.HeaderText = "idRequest";
            this.dataGridViewFilterTextBoxColumn_26.Name = "idRequestDgvColumn";
            this.dataGridViewFilterTextBoxColumn_26.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_26.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_26.Visible = false;
            this.dataGridViewFilterTextBoxColumn_27.DataPropertyName = "idAbn";
            this.dataGridViewFilterTextBoxColumn_27.HeaderText = "idAbn";
            this.dataGridViewFilterTextBoxColumn_27.Name = "idAbnDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_27.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_27.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_27.Visible = false;
            this.dataGridViewFilterTextBoxColumn_28.DataPropertyName = "idAbnObj";
            this.dataGridViewFilterTextBoxColumn_28.HeaderText = "idAbnObj";
            this.dataGridViewFilterTextBoxColumn_28.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_28.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_28.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_28.Visible = false;
            this.dataGridViewFilterTextBoxColumn_29.DataPropertyName = "address";
            style27.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_29.DefaultCellStyle = style27;
            this.dataGridViewFilterTextBoxColumn_29.HeaderText = "Адрес";
            this.dataGridViewFilterTextBoxColumn_29.Name = "addressDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_29.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_29.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_30.DataPropertyName = "numDateTU";
            this.dataGridViewFilterTextBoxColumn_30.HeaderText = "№ и дата ТУ";
            this.dataGridViewFilterTextBoxColumn_30.Name = "numDateTUDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_30.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_30.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_31.DataPropertyName = "addressFull";
            this.dataGridViewFilterTextBoxColumn_31.HeaderText = "Адрес объекта";
            this.dataGridViewFilterTextBoxColumn_31.Name = "addressFullDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_31.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_31.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_31.Visible = false;
            this.dataGridViewFilterTextBoxColumn_32.DataPropertyName = "PowerCurrent";
            this.dataGridViewFilterTextBoxColumn_32.HeaderText = "Существующая мощность";
            this.dataGridViewFilterTextBoxColumn_32.Name = "powerCurrentDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_32.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_32.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_33.DataPropertyName = "PowerAdd";
            this.dataGridViewFilterTextBoxColumn_33.HeaderText = "Дополнительная мощность";
            this.dataGridViewFilterTextBoxColumn_33.Name = "powerAddDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_33.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_33.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_34.DataPropertyName = "PowerSum";
            this.dataGridViewFilterTextBoxColumn_34.HeaderText = "Максимальная мощность";
            this.dataGridViewFilterTextBoxColumn_34.Name = "powerSumDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_34.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_34.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_35.DataPropertyName = "Category";
            this.dataGridViewFilterTextBoxColumn_35.HeaderText = "Category";
            this.dataGridViewFilterTextBoxColumn_35.Name = "categoryDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_35.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_35.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_35.Visible = false;
            this.dataGridViewFilterTextBoxColumn_36.DataPropertyName = "CategoryName";
            this.dataGridViewFilterTextBoxColumn_36.HeaderText = "Категория";
            this.dataGridViewFilterTextBoxColumn_36.Name = "categoryNameDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_36.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_36.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_37.DataPropertyName = "VoltageLevel";
            this.dataGridViewFilterTextBoxColumn_37.HeaderText = "Ур-нь напряжения";
            this.dataGridViewFilterTextBoxColumn_37.Name = "voltageLevelDataGridViewTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn_37.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_37.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_38.DataPropertyName = "PerformerFIO";
            this.dataGridViewFilterTextBoxColumn_38.HeaderText = "Исполнитель";
            this.dataGridViewFilterTextBoxColumn_38.Name = "performerFIODataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_38.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_38.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_88.DataPropertyName = "SchmTP";
            style28.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_88.DefaultCellStyle = style28;
            this.dataGridViewTextBoxColumn_88.HeaderText = "Точки прис-ия";
            this.dataGridViewTextBoxColumn_88.Name = "schmTPDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_88.ReadOnly = true;
            this.dataGridViewTextBoxColumn_89.DataPropertyName = "SchmCP";
            style29.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_89.DefaultCellStyle = style29;
            this.dataGridViewTextBoxColumn_89.HeaderText = "ЦП";
            this.dataGridViewTextBoxColumn_89.Name = "schmCPDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_89.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_39.DataPropertyName = "numContractor";
            this.dataGridViewFilterTextBoxColumn_39.HeaderText = "№ договора ТП";
            this.dataGridViewFilterTextBoxColumn_39.Name = "numContractorDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_39.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_39.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_40.DataPropertyName = "dateContractor";
            this.dataGridViewFilterTextBoxColumn_40.HeaderText = "Дата договора ТП";
            this.dataGridViewFilterTextBoxColumn_40.Name = "dateContractorDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_40.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_40.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_41.DataPropertyName = "Contact";
            style30.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_41.DefaultCellStyle = style30;
            this.dataGridViewFilterTextBoxColumn_41.HeaderText = "Контакты";
            this.dataGridViewFilterTextBoxColumn_41.Name = "contactDgvColumn";
            this.dataGridViewFilterTextBoxColumn_41.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_41.Visible = false;
            this.dataGridViewFilterTextBoxColumn_42.DataPropertyName = "LegalAddress";
            this.dataGridViewFilterTextBoxColumn_42.HeaderText = "Юр. адрес";
            this.dataGridViewFilterTextBoxColumn_42.Name = "legalAddressDgvColumn";
            this.dataGridViewFilterTextBoxColumn_42.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_42.Visible = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x3c4, 0x20a);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.toolStrip_0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "FormJournalActs";
            this.Text = "Журнал актов технологических присоединений";
            base.FormClosed += new FormClosedEventHandler(this.FormJournalActs_FormClosed);
            base.Load += new EventHandler(this.FormJournalActs_Load);
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
            this.dataSet_0.EndInit();
            this.dataTable_0.EndInit();
            this.dataTable_1.EndInit();
            this.dataSetTechConnection_1.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            switch (this.int_2)
            {
                case 0x4d6:
                {
                    FormActElectricalInspection inspection1 = new FormActElectricalInspection();
                    inspection1.set_SqlSettings(this.get_SqlSettings());
                    inspection1.MdiParent = base.MdiParent;
                    inspection1.FormClosed += new FormClosedEventHandler(this.method_2);
                    inspection1.Show();
                    return;
                }
                case 0x4d7:
                {
                    FormActPerformingTU gtu1 = new FormActPerformingTU();
                    gtu1.set_SqlSettings(this.get_SqlSettings());
                    gtu1.MdiParent = base.MdiParent;
                    gtu1.FormClosed += new FormClosedEventHandler(this.method_2);
                    gtu1.Show();
                    return;
                }
                case 0x4d8:
                {
                    FormTCAddEdit edit1 = new FormTCAddEdit();
                    edit1.set_SqlSettings(this.get_SqlSettings());
                    edit1.MdiParent = base.MdiParent;
                    edit1.FormClosed += new FormClosedEventHandler(this.method_2);
                    edit1.Show();
                    return;
                }
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if (this.int_0 != -1)
            {
                switch (this.int_2)
                {
                    case 0x4d6:
                    {
                        FormActElectricalInspection inspection1 = new FormActElectricalInspection(this.int_0, -1, 0x4d6);
                        inspection1.set_SqlSettings(this.get_SqlSettings());
                        inspection1.MdiParent = base.MdiParent;
                        inspection1.FormClosed += new FormClosedEventHandler(this.method_2);
                        inspection1.Show();
                        return;
                    }
                    case 0x4d7:
                    {
                        FormActPerformingTU gtu1 = new FormActPerformingTU(this.int_0, -1, 0x4d7);
                        gtu1.set_SqlSettings(this.get_SqlSettings());
                        gtu1.MdiParent = base.MdiParent;
                        gtu1.FormClosed += new FormClosedEventHandler(this.method_2);
                        gtu1.Show();
                        return;
                    }
                    case 0x4d8:
                    {
                        FormTCAddEdit edit1 = new FormTCAddEdit(this.int_0, -1);
                        edit1.set_SqlSettings(this.get_SqlSettings());
                        edit1.MdiParent = base.MdiParent;
                        edit1.FormClosed += new FormClosedEventHandler(this.method_2);
                        edit1.Show();
                        return;
                    }
                }
            }
        }

        private void toolStripButton_10_Click(object sender, EventArgs e)
        {
            this.method_3(this.dataGridViewExcelFilter_0);
        }

        private void toolStripButton_11_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_0.CurrentRow != null) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_24.Name].Value != null)) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_24.Name].Value != DBNull.Value))
            {
                FormJournalTU ltu1 = new FormJournalTU(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_24.Name].Value)) {
                    MdiParent = base.MdiParent
                };
                ltu1.set_SqlSettings(this.get_SqlSettings());
                ltu1.Show();
            }
        }

        private void toolStripButton_12_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                FormReportActElectricalInspection inspection1 = new FormReportActElectricalInspection(this.int_0);
                inspection1.set_SqlSettings(this.get_SqlSettings());
                inspection1.MdiParent = base.MdiParent;
                inspection1.Show();
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

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            if (((this.dataGridViewExcelFilter_0.CurrentRow != null) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_26.Name].Value != null)) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_26.Name].Value != DBNull.Value))
            {
                FormTechConnectionRequest request1 = new FormTechConnectionRequest(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_26.Name].Value)) {
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
            this.method_1();
        }

        private void toolStripButton_8_Click(object sender, EventArgs e)
        {
            this.method_4();
            this.method_1();
        }

        private void toolStripButton_9_Click(object sender, EventArgs e)
        {
            this.method_1();
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

