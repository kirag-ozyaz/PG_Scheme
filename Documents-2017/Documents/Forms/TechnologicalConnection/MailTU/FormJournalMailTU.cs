namespace Documents.Forms.TechnologicalConnection.MailTU
{
    using ControlsLbr.DataGridViewExcelFilter;
    using DataSql;
    using Documents.Forms.TechnologicalConnection;
    using Documents.Forms.TechnologicalConnection.TU;
    using Documents.Properties;
    using FormLbr;
    using FormLbr.Classes;
    using Microsoft.Office.Interop.Excel;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;
    using System.Xml;

    public class FormJournalMailTU : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private BindingSource bindingSource_3;
        private BindingSource bindingSource_4;
        private CheckedListBox checkedListBox_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_2;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_3;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private DataSetTechConnection dataSetTechConnection_0;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private IContainer icontainer_0;
        private int int_0 = -1;
        private int int_1 = -1;
        private int int_2 = -1;
        private int int_3 = -1;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private SplitContainer splitContainer_0;
        private SplitContainer splitContainer_1;
        private SplitContainer splitContainer_2;
        private TabControl tabControl_0;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private TabPage tabPage_2;
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

        public FormJournalMailTU()
        {
            this.method_8();
            this.method_5();
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
                XmlNode node2 = node.SelectSingleNode("CheckedTypeDoc");
                if (node2 != null)
                {
                    foreach (XmlAttribute attribute2 in node2.Attributes)
                    {
                        this.checkedListBox_0.SetItemChecked(this.method_2(this.checkedListBox_0, Convert.ToInt32(attribute2.Value)), true);
                    }
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
                this.method_6();
                if (this.int_1 == -1)
                {
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_DocOut, true, " where (idDoc = " + this.int_0.ToString() + ")  order by dateDocOut desc");
                }
                else
                {
                    string[] textArray1 = new string[] { " where (idDoc = ", this.int_0.ToString(), ") or  (idDoc = ", this.int_1.ToString(), " and TypeDocOut = ", 0x4c2.ToString(), ") order by dateDocOut desc" };
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_DocOut, true, string.Concat(textArray1));
                }
            }
            else
            {
                this.int_0 = -1;
                this.int_1 = -1;
                this.dataSetTechConnection_0.tTC_DocFile.Clear();
                this.dataSetTechConnection_0.vTC_DocOut.Clear();
            }
            if (this.int_1 == -1)
            {
                this.dataSetTechConnection_0.vTC_RequestHistory.Clear();
            }
            else
            {
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_RequestHistory, true, "where id = " + this.int_1.ToString() + " or IdParent = " + this.int_1.ToString() + " order by dateDoc");
            }
        }

        private void bindingSource_3_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource_3.Current != null)
            {
                this.int_2 = Convert.ToInt32(((DataRowView) this.bindingSource_3.Current)["idDocOut"]);
                this.int_3 = Convert.ToInt32(((DataRowView) this.bindingSource_3.Current)["idDoc"]);
                this.method_7();
            }
            else
            {
                this.int_2 = -1;
                this.int_3 = -1;
                this.bindingSource_4.DataSource = null;
            }
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document = new XmlDocument();
            XmlNode newChild = document.CreateXmlDeclaration("1.0", "UTF-8", null);
            document.AppendChild(newChild);
            XmlNode node2 = document.CreateElement(base.Name);
            document.AppendChild(node2);
            XmlAttribute node = document.CreateAttribute("FilterDateBeg");
            node.Value = this.dateTimePicker_1.Value.ToString();
            node2.Attributes.Append(node);
            node = document.CreateAttribute("FilterDateEnd");
            node.Value = this.dateTimePicker_0.Value.ToString();
            node2.Attributes.Append(node);
            XmlNode node3 = document.CreateElement("CheckedTypeDoc");
            node2.AppendChild(node3);
            foreach (object obj2 in this.checkedListBox_0.CheckedItems)
            {
                node = document.CreateAttribute("i" + ((Class287) obj2).Id.ToString());
                node.Value = ((Class287) obj2).Id.ToString();
                node3.Attributes.Append(node);
            }
            return document;
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
            if (((e.RowIndex >= 0) && (this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_43.Name, e.RowIndex].Value != DBNull.Value)) && (Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_43.Name, e.RowIndex].Value) == 0x465))
            {
                e.CellStyle.BackColor = Color.LightGray;
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormJournalMailTU_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormJournalMailTU_Load(object sender, EventArgs e)
        {
            this.method_1();
            base.LoadFormConfig(null);
            this.method_0();
        }

        private void method_0()
        {
            int num = this.int_0;
            if (this.checkedListBox_0.CheckedItems.Count == 0)
            {
                this.dataSetTechConnection_0.vTC_Mail.Clear();
            }
            else
            {
                string str = "";
                foreach (object obj2 in this.checkedListBox_0.CheckedItems)
                {
                    if (string.IsNullOrEmpty(str))
                    {
                        str = ((Class287) obj2).Id.ToString();
                    }
                    else
                    {
                        str = str + "," + ((Class287) obj2).Id.ToString();
                    }
                }
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_Mail, true, " where DateDoc >= '" + this.dateTimePicker_1.Value.ToString("yyyyMMdd") + "' and DateDoc <= '" + this.dateTimePicker_0.Value.ToString("yyyyMMdd") + "'  and typeDoc in (" + str + ")  order by datedoc desc, CONVERT(INT, CASE WHEN numdoc like '%[^0-9]%' THEN SUBSTRING(numdoc,1,PATINDEX('%[^0-9]%',numdoc)-1) ELSE numdoc END) desc");
                if (num > 0)
                {
                    this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_42.Name, num.ToString(), false);
                }
            }
        }

        private void method_1()
        {
            string[] textArray1 = new string[] { " where id in (", 0x465.ToString(), ",", 0x4c2.ToString(), ") order by name" };
            this.checkedListBox_0.Items.Clear();
            foreach (DataRow row in base.SelectSqlData("tr_Classifier", true, string.Concat(textArray1)).Rows)
            {
                this.checkedListBox_0.Items.Add(new Class287(Convert.ToInt32(row["id"]), row["name"].ToString()));
            }
        }

        private int method_2(CheckedListBox checkedListBox_1, int int_4)
        {
            for (int i = 0; i < checkedListBox_1.Items.Count; i++)
            {
                object obj2 = checkedListBox_1.Items[i];
                if ((obj2 is Class287) && (((Class287) obj2).Id == int_4))
                {
                    return i;
                }
            }
            return -1;
        }

        private void method_3(object sender, FormClosedEventArgs e)
        {
            this.int_0 = ((Form11) sender).method_0();
            this.method_0();
        }

        private void method_4(DataGridView dataGridView_0)
        {
            _Application application = new ApplicationClass();
            _Workbook workbook = application.get_Workbooks().Add(Type.Missing);
            _Worksheet worksheet = null;
            application.set_Visible(false);
            worksheet = (Worksheet) workbook.get_ActiveSheet();
            worksheet.set_Name("Exported from gridview");
            int num = 1;
            for (int i = 0; i < dataGridView_0.Columns.Count; i++)
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
                for (int k = 0; k < dataGridView_0.Columns.Count; k++)
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

        private void method_5()
        {
            this.dateTimePicker_1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePicker_0.Value = new DateTime(DateTime.Now.Year, 12, 0x1f);
        }

        private void method_6()
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

        private void method_7()
        {
            DataSetTechConnection.vTC_DocStatusDataTable table = new DataSetTechConnection.vTC_DocStatusDataTable();
            base.SelectSqlData(table, true, " where idDoc = " + this.int_2.ToString() + " order by dateChange desc", false);
            this.bindingSource_4.DataSource = table;
            this.dataGridViewTextBoxColumn_35.Visible = false;
        }

        private void method_8()
        {
            this.icontainer_0 = new Container();
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormJournalMailTU));
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripButton_9 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_16 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripButton_6 = new ToolStripButton();
            this.toolStripSeparator_3 = new ToolStripSeparator();
            this.toolStripButton_17 = new ToolStripButton();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetTechConnection_0 = new DataSetTechConnection();
            this.splitContainer_0 = new SplitContainer();
            this.checkedListBox_0 = new CheckedListBox();
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
            this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.tabPage_1 = new TabPage();
            this.dataGridViewExcelFilter_2 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
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
            this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
            this.bindingSource_2 = new BindingSource(this.icontainer_0);
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
            this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
            this.bindingSource_4 = new BindingSource(this.icontainer_0);
            this.toolStrip_3 = new ToolStrip();
            this.toolStripButton_13 = new ToolStripButton();
            this.toolStripButton_14 = new ToolStripButton();
            this.toolStripButton_15 = new ToolStripButton();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_53 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
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
            base.SuspendLayout();
            this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripSeparator_2, this.toolStripButton_9, this.toolStripSeparator_0, this.toolStripButton_3, this.toolStripButton_16, this.toolStripSeparator_1, this.toolStripButton_4, this.toolStripTextBox_0, this.toolStripButton_5, this.toolStripButton_6, this.toolStripSeparator_3, this.toolStripButton_17 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStrip";
            this.toolStrip_0.Size = new Size(0x373, 0x19);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.ElementAdd;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnAddTU";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Добавить тех уловие";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.ElementEdit;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnEditTU";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Редактировать тех условие";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.ElementDel;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnDelTU";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Удалить тех условие";
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
            this.toolStripButton_16.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_16.Image = Resources._1381484495_Terms_rev;
            this.toolStripButton_16.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_16.Name = "toolBtnShowTU";
            this.toolStripButton_16.Size = new Size(0x17, 0x16);
            this.toolStripButton_16.Text = "Открыть тех условие";
            this.toolStripButton_16.Click += new EventHandler(this.toolStripButton_16_Click);
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
            this.toolStripSeparator_3.Name = "toolStripSeparator4";
            this.toolStripSeparator_3.Size = new Size(6, 0x19);
            this.toolStripButton_17.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_17.Image = Resources.microsoftoffice2007excel_7581;
            this.toolStripButton_17.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_17.Name = "toolBtnExportExcel";
            this.toolStripButton_17.Size = new Size(0x17, 0x16);
            this.toolStripButton_17.Text = "Экспорт в Excel";
            this.toolStripButton_17.Click += new EventHandler(this.toolStripButton_17_Click);
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
                this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewTextBoxColumn_42, this.dataGridViewFilterTextBoxColumn_1, this.dataGridViewFilterTextBoxColumn_2, this.dataGridViewTextBoxColumn_43, this.dataGridViewFilterTextBoxColumn_3, this.dataGridViewTextBoxColumn_44, this.dataGridViewTextBoxColumn_45, this.dataGridViewTextBoxColumn_46, this.dataGridViewTextBoxColumn_47, this.dataGridViewTextBoxColumn_48, this.dataGridViewTextBoxColumn_49, this.dataGridViewFilterTextBoxColumn_4, this.dataGridViewTextBoxColumn_50, this.dataGridViewFilterTextBoxColumn_5, this.dataGridViewFilterTextBoxColumn_6,
                this.dataGridViewTextBoxColumn_51, this.dataGridViewTextBoxColumn_52, this.dataGridViewFilterTextBoxColumn_7, this.dataGridViewFilterTextBoxColumn_8, this.dataGridViewFilterTextBoxColumn_9, this.dataGridViewTextBoxColumn_53, this.dataGridViewFilterTextBoxColumn_10
            };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_0.Name = "dgvMailTU";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.Size = new Size(0x2c4, 0xf4);
            this.dataGridViewExcelFilter_0.TabIndex = 1;
            this.dataGridViewExcelFilter_0.VirtualMode = true;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.dataGridViewExcelFilter_0.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_0_RowPostPaint);
            this.bindingSource_0.DataMember = "vTC_Mail";
            this.bindingSource_0.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
            this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.FixedPanel = FixedPanel.Panel1;
            this.splitContainer_0.Location = new Point(0, 0x19);
            this.splitContainer_0.Name = "splitContainerMain";
            this.splitContainer_0.Panel1.Controls.Add(this.checkedListBox_0);
            this.splitContainer_0.Panel1.Controls.Add(this.label_2);
            this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_0);
            this.splitContainer_0.Panel1.Controls.Add(this.label_0);
            this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_1);
            this.splitContainer_0.Panel1.Controls.Add(this.label_1);
            this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_1);
            this.splitContainer_0.Panel2.Controls.Add(this.splitContainer_1);
            this.splitContainer_0.Size = new Size(0x373, 0x1bf);
            this.splitContainer_0.SplitterDistance = 0xab;
            this.splitContainer_0.TabIndex = 2;
            this.checkedListBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.checkedListBox_0.CheckOnClick = true;
            this.checkedListBox_0.FormattingEnabled = true;
            this.checkedListBox_0.Location = new Point(12, 0x77);
            this.checkedListBox_0.Name = "checkedListBoxTypeDoc";
            this.checkedListBox_0.Size = new Size(0x88, 0x5e);
            this.checkedListBox_0.TabIndex = 11;
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(12, 0x67);
            this.label_2.Name = "label3";
            this.label_2.Size = new Size(0x45, 13);
            this.label_2.TabIndex = 10;
            this.label_2.Text = "Типы писем";
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
            this.splitContainer_1.Size = new Size(0x2c4, 0x1bf);
            this.splitContainer_1.SplitterDistance = 0xf4;
            this.splitContainer_1.TabIndex = 2;
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Controls.Add(this.tabPage_2);
            this.tabControl_0.Dock = DockStyle.Fill;
            this.tabControl_0.Location = new Point(0, 0);
            this.tabControl_0.Name = "tabControl";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x2c4, 0xc7);
            this.tabControl_0.TabIndex = 0;
            this.tabPage_0.Controls.Add(this.dataGridViewExcelFilter_1);
            this.tabPage_0.Location = new Point(4, 0x16);
            this.tabPage_0.Name = "tabPageFiles";
            this.tabPage_0.Padding = new Padding(3);
            this.tabPage_0.Size = new Size(700, 0xad);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Файлы";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToResizeColumns = false;
            this.dataGridViewExcelFilter_1.AllowUserToResizeRows = false;
            this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewImageColumnNotNull_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewLinkColumn_0, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3 };
            this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray2);
            this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
            this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_1.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewExcelFilter_1.Location = new Point(3, 3);
            this.dataGridViewExcelFilter_1.Name = "dgvFile";
            this.dataGridViewExcelFilter_1.ReadOnly = true;
            this.dataGridViewExcelFilter_1.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_1.Size = new Size(0x2b6, 0xa7);
            this.dataGridViewExcelFilter_1.TabIndex = 7;
            this.dataGridViewExcelFilter_1.VirtualMode = true;
            this.dataGridViewExcelFilter_1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_1_CellContentClick);
            this.dataGridViewExcelFilter_1.CellValueNeeded += new DataGridViewCellValueEventHandler(this.dataGridViewExcelFilter_1_CellValueNeeded);
            style.NullValue = null;
            this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = style;
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
            this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_2);
            this.tabPage_1.Location = new Point(4, 0x16);
            this.tabPage_1.Name = "tabPageRequestHistory";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(700, 0xad);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "История заявок";
            this.tabPage_1.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_2.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_2.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_2.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray3 = new DataGridViewColumn[] { 
                this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6, this.dataGridViewTextBoxColumn_7, this.dataGridViewTextBoxColumn_8, this.dataGridViewTextBoxColumn_9, this.dataGridViewTextBoxColumn_10, this.dataGridViewTextBoxColumn_11, this.dataGridViewTextBoxColumn_12, this.dataGridViewTextBoxColumn_13, this.dataGridViewTextBoxColumn_14, this.dataGridViewTextBoxColumn_15, this.dataGridViewTextBoxColumn_16, this.dataGridViewTextBoxColumn_17, this.dataGridViewTextBoxColumn_18, this.dataGridViewTextBoxColumn_19,
                this.dataGridViewTextBoxColumn_20, this.dataGridViewTextBoxColumn_21
            };
            this.dataGridViewExcelFilter_2.Columns.AddRange(columnArray3);
            this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
            this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_2.Location = new Point(3, 3);
            this.dataGridViewExcelFilter_2.MultiSelect = false;
            this.dataGridViewExcelFilter_2.Name = "dgvRequestHistory";
            this.dataGridViewExcelFilter_2.ReadOnly = true;
            this.dataGridViewExcelFilter_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_2.Size = new Size(0x2b6, 0xa7);
            this.dataGridViewExcelFilter_2.TabIndex = 4;
            this.dataGridViewExcelFilter_2.VirtualMode = true;
            this.dataGridViewExcelFilter_2.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_2_CellFormatting);
            this.dataGridViewExcelFilter_2.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_2_RowPostPaint);
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "numDateIn";
            style2.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_4.DefaultCellStyle = style2;
            this.dataGridViewTextBoxColumn_4.HeaderText = "№, дата вход.";
            this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Width = 80;
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
            style3.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_13.DefaultCellStyle = style3;
            this.dataGridViewTextBoxColumn_13.HeaderText = "Тело письма";
            this.dataGridViewTextBoxColumn_13.Name = "bodyDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewTextBoxColumn_14.DataPropertyName = "PowerCurrent";
            this.dataGridViewTextBoxColumn_14.HeaderText = "Текущая мощность";
            this.dataGridViewTextBoxColumn_14.Name = "powerCurrentDgvColumn";
            this.dataGridViewTextBoxColumn_14.ReadOnly = true;
            this.dataGridViewTextBoxColumn_14.Width = 70;
            this.dataGridViewTextBoxColumn_15.DataPropertyName = "PowerAdd";
            this.dataGridViewTextBoxColumn_15.HeaderText = "Доп мощность";
            this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_15.ReadOnly = true;
            this.dataGridViewTextBoxColumn_15.Width = 70;
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
            this.tabPage_2.Controls.Add(this.splitContainer_2);
            this.tabPage_2.Location = new Point(4, 0x16);
            this.tabPage_2.Name = "tabPageDocOut";
            this.tabPage_2.Padding = new Padding(3);
            this.tabPage_2.Size = new Size(700, 0xad);
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
            this.splitContainer_2.Size = new Size(0x2b6, 0xa7);
            this.splitContainer_2.SplitterDistance = 0x175;
            this.splitContainer_2.TabIndex = 0;
            this.dataGridViewExcelFilter_3.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_3.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_3.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_3.set_AllowUserToVisibleColumns(false);
            this.dataGridViewExcelFilter_3.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray4 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_22, this.dataGridViewTextBoxColumn_23, this.dataGridViewTextBoxColumn_24, this.dataGridViewTextBoxColumn_25, this.dataGridViewTextBoxColumn_26, this.dataGridViewTextBoxColumn_27, this.dataGridViewTextBoxColumn_28, this.dataGridViewTextBoxColumn_29, this.dataGridViewTextBoxColumn_30, this.dataGridViewTextBoxColumn_31, this.dataGridViewTextBoxColumn_32, this.dataGridViewTextBoxColumn_33, this.dataGridViewTextBoxColumn_34 };
            this.dataGridViewExcelFilter_3.Columns.AddRange(columnArray4);
            this.dataGridViewExcelFilter_3.DataSource = this.bindingSource_3;
            this.dataGridViewExcelFilter_3.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_3.Location = new Point(0x18, 0);
            this.dataGridViewExcelFilter_3.Name = "dgvDocOut";
            this.dataGridViewExcelFilter_3.ReadOnly = true;
            this.dataGridViewExcelFilter_3.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_3.Size = new Size(0x15d, 0xa7);
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
            style4.Format = "d";
            style4.NullValue = null;
            this.dataGridViewTextBoxColumn_29.DefaultCellStyle = style4;
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
            this.dataGridViewExcelFilter_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray5 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_35, this.dataGridViewTextBoxColumn_36, this.dataGridViewTextBoxColumn_37, this.dataGridViewTextBoxColumn_38, this.dataGridViewTextBoxColumn_39, this.dataGridViewTextBoxColumn_40, this.dataGridViewTextBoxColumn_41 };
            this.dataGridViewExcelFilter_4.Columns.AddRange(columnArray5);
            this.dataGridViewExcelFilter_4.DataSource = this.bindingSource_4;
            this.dataGridViewExcelFilter_4.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_4.Location = new Point(0, 0x19);
            this.dataGridViewExcelFilter_4.Name = "dgvDocOutStatus";
            this.dataGridViewExcelFilter_4.ReadOnly = true;
            this.dataGridViewExcelFilter_4.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_4.Size = new Size(0x13d, 0x8e);
            this.dataGridViewExcelFilter_4.TabIndex = 3;
            this.dataGridViewTextBoxColumn_35.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_35.HeaderText = "id";
            this.dataGridViewTextBoxColumn_35.Name = "idStatusDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_35.ReadOnly = true;
            this.dataGridViewTextBoxColumn_35.Visible = false;
            this.dataGridViewTextBoxColumn_36.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_36.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_36.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_36.ReadOnly = true;
            this.dataGridViewTextBoxColumn_36.Visible = false;
            this.dataGridViewTextBoxColumn_37.DataPropertyName = "idStatus";
            this.dataGridViewTextBoxColumn_37.HeaderText = "idStatus";
            this.dataGridViewTextBoxColumn_37.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn_37.ReadOnly = true;
            this.dataGridViewTextBoxColumn_37.Visible = false;
            this.dataGridViewTextBoxColumn_38.DataPropertyName = "statusName";
            this.dataGridViewTextBoxColumn_38.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn_38.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn_38.ReadOnly = true;
            this.dataGridViewTextBoxColumn_38.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_39.DataPropertyName = "DateChange";
            style5.Format = "d";
            style5.NullValue = null;
            this.dataGridViewTextBoxColumn_39.DefaultCellStyle = style5;
            this.dataGridViewTextBoxColumn_39.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_39.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn_39.ReadOnly = true;
            this.dataGridViewTextBoxColumn_39.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_39.Width = 70;
            this.dataGridViewTextBoxColumn_40.DataPropertyName = "SendName";
            this.dataGridViewTextBoxColumn_40.HeaderText = "Способ отправки";
            this.dataGridViewTextBoxColumn_40.Name = "sendNameDgvColumn";
            this.dataGridViewTextBoxColumn_40.ReadOnly = true;
            this.dataGridViewTextBoxColumn_41.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_41.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_41.Name = "сommentDocOutStatusDgvColumn";
            this.dataGridViewTextBoxColumn_41.ReadOnly = true;
            this.bindingSource_4.DataMember = "vTC_DocStatus";
            this.bindingSource_4.DataSource = this.dataSetTechConnection_0;
            this.toolStrip_3.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolStripButton_13, this.toolStripButton_14, this.toolStripButton_15 };
            this.toolStrip_3.Items.AddRange(itemArray4);
            this.toolStrip_3.Location = new Point(0, 0);
            this.toolStrip_3.Name = "toolStripDocOutStatus";
            this.toolStrip_3.Size = new Size(0x13d, 0x19);
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
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "numDateIn";
            style6.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_0.DefaultCellStyle = style6;
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "№, дата входящего";
            this.dataGridViewFilterTextBoxColumn_0.Name = "numDateInDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_42.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_42.HeaderText = "id";
            this.dataGridViewTextBoxColumn_42.Name = "idDgvColumn";
            this.dataGridViewTextBoxColumn_42.ReadOnly = true;
            this.dataGridViewTextBoxColumn_42.Visible = false;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "numDoc";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "№";
            this.dataGridViewFilterTextBoxColumn_1.Name = "numDocDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.Width = 70;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "dateDoc";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Дата";
            this.dataGridViewFilterTextBoxColumn_2.Name = "dateDocDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.Width = 80;
            this.dataGridViewTextBoxColumn_43.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn_43.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn_43.Name = "typeMailDgvColumn";
            this.dataGridViewTextBoxColumn_43.ReadOnly = true;
            this.dataGridViewTextBoxColumn_43.Visible = false;
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "Body";
            style7.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.DefaultCellStyle = style7;
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Содержание";
            this.dataGridViewFilterTextBoxColumn_3.Name = "bodyDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_44.DataPropertyName = "IdParent";
            this.dataGridViewTextBoxColumn_44.HeaderText = "IdParent";
            this.dataGridViewTextBoxColumn_44.Name = "idParentDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_44.ReadOnly = true;
            this.dataGridViewTextBoxColumn_44.Visible = false;
            this.dataGridViewTextBoxColumn_45.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_45.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn_45.Name = "commentDataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_45.ReadOnly = true;
            this.dataGridViewTextBoxColumn_45.Visible = false;
            this.dataGridViewTextBoxColumn_46.DataPropertyName = "idRequest";
            this.dataGridViewTextBoxColumn_46.HeaderText = "idRequest";
            this.dataGridViewTextBoxColumn_46.Name = "idRequestDgvColumn";
            this.dataGridViewTextBoxColumn_46.ReadOnly = true;
            this.dataGridViewTextBoxColumn_46.Visible = false;
            this.dataGridViewTextBoxColumn_47.DataPropertyName = "numIn";
            this.dataGridViewTextBoxColumn_47.HeaderText = "numIn";
            this.dataGridViewTextBoxColumn_47.Name = "numInDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_47.ReadOnly = true;
            this.dataGridViewTextBoxColumn_47.Visible = false;
            this.dataGridViewTextBoxColumn_48.DataPropertyName = "dateIn";
            this.dataGridViewTextBoxColumn_48.HeaderText = "dateIn";
            this.dataGridViewTextBoxColumn_48.Name = "dateInDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_48.ReadOnly = true;
            this.dataGridViewTextBoxColumn_48.Visible = false;
            this.dataGridViewTextBoxColumn_49.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_49.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_49.Name = "idAbnDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_49.ReadOnly = true;
            this.dataGridViewTextBoxColumn_49.Visible = false;
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "nameAbn";
            style8.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_4.DefaultCellStyle = style8;
            this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Потребитель";
            this.dataGridViewFilterTextBoxColumn_4.Name = "nameAbnDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_50.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_50.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_50.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_50.ReadOnly = true;
            this.dataGridViewTextBoxColumn_50.Visible = false;
            this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "nameObj";
            style9.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_5.DefaultCellStyle = style9;
            this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn_5.Name = "nameObjDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "address";
            style10.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_6.DefaultCellStyle = style10;
            this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Адрес";
            this.dataGridViewFilterTextBoxColumn_6.Name = "addressDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_51.DataPropertyName = "addressFull";
            this.dataGridViewTextBoxColumn_51.HeaderText = "addressFull";
            this.dataGridViewTextBoxColumn_51.Name = "addressFullDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_51.ReadOnly = true;
            this.dataGridViewTextBoxColumn_51.Visible = false;
            this.dataGridViewTextBoxColumn_52.DataPropertyName = "idTU";
            this.dataGridViewTextBoxColumn_52.HeaderText = "idTU";
            this.dataGridViewTextBoxColumn_52.Name = "idTUDgvColumn";
            this.dataGridViewTextBoxColumn_52.ReadOnly = true;
            this.dataGridViewTextBoxColumn_52.Visible = false;
            this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "PerformerFIO";
            this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Исполнитель";
            this.dataGridViewFilterTextBoxColumn_7.Name = "performerFIODataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "numTU";
            this.dataGridViewFilterTextBoxColumn_8.HeaderText = "№ ТУ";
            this.dataGridViewFilterTextBoxColumn_8.Name = "numTUDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_8.Width = 70;
            this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "dateTU";
            this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Дата ТУ";
            this.dataGridViewFilterTextBoxColumn_9.Name = "dateTUDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_9.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_9.Width = 80;
            this.dataGridViewTextBoxColumn_53.DataPropertyName = "Performer";
            this.dataGridViewTextBoxColumn_53.HeaderText = "Performer";
            this.dataGridViewTextBoxColumn_53.Name = "performerDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_53.ReadOnly = true;
            this.dataGridViewTextBoxColumn_53.Visible = false;
            this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "TypeDocName";
            this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Тип письма";
            this.dataGridViewFilterTextBoxColumn_10.Name = "typeDocNameDgvColumn";
            this.dataGridViewFilterTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_10.Width = 80;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x373, 0x1d8);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.toolStrip_0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "FormJournalMailTU";
            this.Text = "Журнал писем";
            base.FormClosed += new FormClosedEventHandler(this.FormJournalMailTU_FormClosed);
            base.Load += new EventHandler(this.FormJournalMailTU_Load);
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
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            Form11 form1 = new Form11(-1, -1);
            form1.set_SqlSettings(this.get_SqlSettings());
            form1.MdiParent = base.MdiParent;
            form1.FormClosed += new FormClosedEventHandler(this.method_3);
            form1.Show();
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if (this.int_0 != -1)
            {
                Form11 form1 = new Form11(this.int_0, -1);
                form1.set_SqlSettings(this.get_SqlSettings());
                form1.MdiParent = base.MdiParent;
                form1.FormClosed += new FormClosedEventHandler(this.method_3);
                form1.Show();
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
                    Form11 form = new Form11(Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_23.Name].Value), this.int_0);
                    form.set_SqlSettings(this.get_SqlSettings());
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.method_0();
                        this.dataGridViewExcelFilter_3.SearchGrid(this.dataGridViewTextBoxColumn_23.Name, form.method_0().ToString(), false);
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
                Form11 form = new Form11(-1, this.int_0);
                form.set_SqlSettings(this.get_SqlSettings());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.method_0();
                    this.dataGridViewExcelFilter_3.SearchGrid(this.dataGridViewTextBoxColumn_23.Name, form.method_0().ToString(), false);
                }
            }
        }

        private void toolStripButton_13_Click(object sender, EventArgs e)
        {
            if (this.int_2 != -1)
            {
                if (this.int_3 != this.int_0)
                {
                    MessageBox.Show("Невозможно редактировать данный документ");
                }
                else
                {
                    Form6 form1 = new Form6(-1, this.int_2, true);
                    form1.set_SqlSettings(this.get_SqlSettings());
                    if (form1.ShowDialog() == DialogResult.OK)
                    {
                        this.method_7();
                    }
                }
            }
        }

        private void toolStripButton_14_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_4.CurrentRow != null) && (this.int_2 != -1))
            {
                if (this.int_3 != this.int_0)
                {
                    MessageBox.Show("Невозможно редактировать данный документ");
                }
                else
                {
                    int num = Convert.ToInt32(this.dataGridViewExcelFilter_4.CurrentRow.Cells[this.dataGridViewTextBoxColumn_35.Name].Value);
                    Form6 form1 = new Form6(num, this.int_2, true);
                    form1.set_SqlSettings(this.get_SqlSettings());
                    if (form1.ShowDialog() == DialogResult.OK)
                    {
                        this.method_7();
                        this.dataGridViewExcelFilter_4.SearchGrid(this.dataGridViewTextBoxColumn_35.Name, num.ToString(), false);
                    }
                }
            }
        }

        private void toolStripButton_15_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_4.CurrentRow != null)
            {
                if (this.int_3 != this.int_0)
                {
                    MessageBox.Show("Невозможно редактировать данный документ");
                }
                else if (MessageBox.Show("Вы действительно хотите удалить текущий статус", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int num = Convert.ToInt32(this.dataGridViewExcelFilter_4.CurrentRow.Cells[this.dataGridViewTextBoxColumn_35.Name].Value);
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
            if (((this.dataGridViewExcelFilter_0.CurrentRow != null) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_52.Name].Value != null)) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_52.Name].Value != DBNull.Value))
            {
                FormJournalTU ltu1 = new FormJournalTU(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_52.Name].Value)) {
                    MdiParent = base.MdiParent
                };
                ltu1.set_SqlSettings(this.get_SqlSettings());
                ltu1.Show();
            }
        }

        private void toolStripButton_17_Click(object sender, EventArgs e)
        {
            this.method_4(this.dataGridViewExcelFilter_0);
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
            if (((this.dataGridViewExcelFilter_0.CurrentRow != null) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_46.Name].Value != null)) && (this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_46.Name].Value != DBNull.Value))
            {
                FormTechConnectionRequest request1 = new FormTechConnectionRequest(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_46.Name].Value)) {
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
            this.method_5();
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

        private class Class287
        {
            [CompilerGenerated]
            private int int_0;
            [CompilerGenerated]
            private string string_0;

            internal Class287(int int_1, string string_1)
            {
                this.Id = int_1;
                this.name = string_1;
            }

            public override string ToString()
            {
                return this.name;
            }

            internal int Id
            {
                [CompilerGenerated]
                get
                {
                    return this.int_0;
                }
                [CompilerGenerated]
                set
                {
                    this.int_0 = value;
                }
            }

            private string name
            {
                [CompilerGenerated]
                get
                {
                    return this.string_0;
                }
                [CompilerGenerated]
                set
                {
                    this.string_0 = value;
                }
            }
        }
    }
}

