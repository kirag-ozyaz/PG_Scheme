namespace Documents.Forms.TechnologicalConnection
{
    using ControlsLbr.DataGridViewExcelFilter;
    using DataSql;
    using Documents.Forms.TechnologicalConnection.TU;
    using Documents.Properties;
    using FormLbr;
    using FormLbr.Classes;
    using Microsoft.Office.Interop.Excel;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Xml;

    public class FormTechConnectionRequest : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private BindingSource bindingSource_3;
        private BindingSource bindingSource_4;
        private CheckBox checkBox_0;
        private ContextMenuStrip contextMenuStrip_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_2;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_3;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private DataSetTechConnection dataSetTechConnection_0;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private Label label_0;
        private Label label_1;
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
        private ToolStrip toolStrip_4;
        private ToolStrip toolStrip_5;
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
        private ToolStripSeparator toolStripSeparator_6;
        private ToolStripTextBox toolStripTextBox_0;

        public FormTechConnectionRequest()
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.method_7();
            this.method_5();
        }

        public FormTechConnectionRequest(int int_2)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.method_7();
            this.method_5();
            this.int_0 = int_2;
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
                attribute = node.Attributes["HideNoDate"];
                if (attribute != null)
                {
                    this.checkBox_0.Checked = Convert.ToBoolean(attribute.Value);
                }
            }
        }

        private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                if (this.int_0 != Convert.ToInt32(((DataRowView) this.bindingSource_0.Current)["id"]))
                {
                    int num;
                    this.int_0 = Convert.ToInt32(((DataRowView) this.bindingSource_0.Current)["id"]);
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_DocStatus, true, " where idDoc = " + this.int_0.ToString() + " order by datechange desc");
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_RequestHistory, true, "where id = " + this.int_0.ToString() + " or IdParent = " + this.int_0.ToString() + " order by dateDoc");
                    string str = "";
                    foreach (DataRow row in this.dataSetTechConnection_0.vTC_RequestHistory)
                    {
                        if (string.IsNullOrEmpty(str))
                        {
                            str = row["id"].ToString();
                        }
                        else
                        {
                            str = str + "," + row["id"].ToString();
                        }
                    }
                    if (string.IsNullOrEmpty(str))
                    {
                        base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_DocOut, true, " where idDoc = " + this.int_0.ToString() + " order by dateDocOut desc");
                    }
                    else
                    {
                        base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_DocOut, true, " where idDoc in (" + str + ") order by dateDocOut desc");
                    }
                    string str2 = "";
                    foreach (DataRow row2 in this.dataSetTechConnection_0.vTC_DocOut)
                    {
                        if (Convert.ToInt32(row2["TypeDocOut"]) == 0x463)
                        {
                            if (string.IsNullOrEmpty(str2))
                            {
                                str2 = row2["idDocOut"].ToString();
                            }
                            else
                            {
                                str2 = str2 + "," + row2["idDocOut"].ToString();
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(str2))
                    {
                        DataSetTechConnection.vTC_DocOutDataTable table = new DataSetTechConnection.vTC_DocOutDataTable();
                        string[] textArray2 = new string[5];
                        textArray2[0] = " where idDoc in (";
                        textArray2[1] = str2;
                        textArray2[2] = ") and typeDocout = ";
                        num = 0x4c2;
                        textArray2[3] = num.ToString();
                        textArray2[4] = " order by dateDocOut desc";
                        base.SelectSqlData(table, true, string.Concat(textArray2), false);
                        foreach (DataRow row3 in table.Rows)
                        {
                            this.dataSetTechConnection_0.vTC_DocOut.ImportRow(row3);
                        }
                    }
                    num = 0x463;
                    if (this.dataSetTechConnection_0.vTC_DocOut.Select("typeDocOut = " + num.ToString()).Length != 0)
                    {
                        this.toolStripMenuItem_4.Enabled = false;
                        num = 0x4c4;
                        if (this.dataSetTechConnection_0.vTC_DocOut.Select("typeDocOut = " + num.ToString()).Length != 0)
                        {
                            this.toolStripMenuItem_6.Enabled = false;
                        }
                        else
                        {
                            this.toolStripMenuItem_6.Enabled = true;
                        }
                    }
                    else
                    {
                        this.toolStripMenuItem_4.Enabled = true;
                        this.toolStripMenuItem_6.Enabled = false;
                    }
                }
            }
            else
            {
                this.int_0 = -1;
                this.dataSetTechConnection_0.vTC_DocStatus.Clear();
                this.dataSetTechConnection_0.vTC_DocOut.Clear();
                this.dataSetTechConnection_0.vTC_RequestHistory.Clear();
            }
        }

        private void bindingSource_2_CurrentChanged(object sender, EventArgs e)
        {
            if (this.bindingSource_2.Current != null)
            {
                this.int_1 = Convert.ToInt32(((DataRowView) this.bindingSource_2.Current)["idDocOut"]);
                this.method_6();
            }
            else
            {
                this.int_1 = -1;
                this.bindingSource_3.DataSource = null;
            }
        }

        private void contextMenuStrip_0_Opening(object sender, CancelEventArgs e)
        {
            this.toolStripMenuItem_0.Visible = this.toolStripButton_0.Visible;
            this.toolStripMenuItem_0.Enabled = this.toolStripButton_0.Enabled;
            this.toolStripMenuItem_1.Visible = this.toolStripButton_1.Visible;
            this.toolStripMenuItem_1.Enabled = this.toolStripButton_1.Enabled;
            this.toolStripMenuItem_2.Visible = this.toolStripButton_2.Visible;
            this.toolStripMenuItem_2.Enabled = this.toolStripButton_2.Enabled;
            this.toolStripMenuItem_3.Visible = this.toolStripButton_22.Visible;
            this.toolStripMenuItem_3.Enabled = this.toolStripButton_22.Enabled;
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
            node = document1.CreateAttribute("HideNoDate");
            node.Value = this.checkBox_0.Checked.ToString();
            node2.Attributes.Append(node);
            return document1;
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((this.toolStripButton_1.Enabled && this.toolStripButton_1.Visible) && ((e.RowIndex >= 0) && (e.ColumnIndex >= 0)))
            {
                this.toolStripButton_1_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (((e.RowIndex >= 0) && (this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_7.Name, e.RowIndex].Value != null)) && (this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_7.Name, e.RowIndex].Value != DBNull.Value))
            {
                e.CellStyle.BackColor = Color.LightGreen;
            }
        }

        private void dataGridViewExcelFilter_0_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (((e.Button == MouseButtons.Right) && (e.RowIndex >= 0)) && (e.ColumnIndex >= 0))
            {
                this.dataGridViewExcelFilter_0.CurrentCell = this.dataGridViewExcelFilter_0[e.ColumnIndex, e.RowIndex];
                this.contextMenuStrip_0.Show(Cursor.Position);
            }
        }

        private void dataGridViewExcelFilter_0_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewExcelFilter_0.AutoResizeRow(e.RowIndex);
        }

        private void dataGridViewExcelFilter_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.toolStripButton_5.Enabled && this.toolStripButton_5.Visible)
            {
                this.toolStripButton_5_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.toolStripButton_7.Enabled && this.toolStripButton_7.Visible)
            {
                this.toolStripButton_7_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (((e.RowIndex >= 0) && (this.dataGridViewExcelFilter_2[this.dataGridViewTextBoxColumn_28.Name, e.RowIndex].Value != null)) && (Convert.ToInt32(this.dataGridViewExcelFilter_2[this.dataGridViewTextBoxColumn_28.Name, e.RowIndex].Value) != this.int_0))
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
        }

        private void dataGridViewExcelFilter_4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((this.toolStripButton_1.Enabled && this.toolStripButton_1.Visible) && ((e.RowIndex >= 0) && (e.ColumnIndex >= 0)))
            {
                this.toolStripButton_20_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.RowIndex >= 0) && (Convert.ToInt32(this.dataGridViewExcelFilter_4[this.dataGridViewTextBoxColumn_11.Name, e.RowIndex].Value) == 0x459))
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.BackColor = Color.LightGray;
            }
        }

        private void dataGridViewExcelFilter_4_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridViewExcelFilter_4.AutoResizeRow(e.RowIndex);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormTechConnectionRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormTechConnectionRequest_Load(object sender, EventArgs e)
        {
            base.LoadFormConfig(null);
            int num = -1;
            if (this.int_0 > 0)
            {
                DataSetTechConnection.tTC_DocDataTable table = new DataSetTechConnection.tTC_DocDataTable();
                base.SelectSqlData(table, true, " where id = " + this.int_0.ToString(), false);
                if ((table.Rows.Count > 0) && (table.Rows[0]["idParent"] != DBNull.Value))
                {
                    base.SelectSqlData(table, true, " where id = " + table.Rows[0]["idParent"].ToString(), false);
                }
                if (table.Rows.Count > 0)
                {
                    this.int_0 = Convert.ToInt32(table.Rows[0]["id"]);
                    if (table.Rows[0]["DateDoc"] != DBNull.Value)
                    {
                        DateTime time = Convert.ToDateTime(table.Rows[0]["DateDoc"]);
                        this.dateTimePicker_1.Value = new DateTime(time.Year, 1, 1);
                        this.dateTimePicker_0.Value = new DateTime(time.Year, 12, 0x1f);
                    }
                    num = this.int_0;
                }
            }
            this.method_0();
            if (num != -1)
            {
                this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_38.Name, num.ToString(), false);
                if (this.dataGridViewExcelFilter_0.CurrentRow != null)
                {
                    this.dataGridViewExcelFilter_0.FirstDisplayedScrollingRowIndex = this.dataGridViewExcelFilter_0.CurrentRow.Index;
                }
            }
        }

        private void FormTechConnectionRequest_Shown(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                this.dataGridViewExcelFilter_0.FirstDisplayedScrollingRowIndex = this.dataGridViewExcelFilter_0.CurrentRow.Index;
            }
        }

        private void method_0()
        {
            int num = this.int_0;
            if (this.checkBox_0.Checked)
            {
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_Request, true, " where (dateDoc >= '" + this.dateTimePicker_1.Value.ToString("yyyyMMdd") + "' and dateDoc < '" + this.dateTimePicker_0.Value.AddDays(1.0).ToString("yyyyMMdd") + "') order by dateDoc desc");
            }
            else
            {
                base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_Request, true, " where (dateDoc >= '" + this.dateTimePicker_1.Value.ToString("yyyyMMdd") + "' and dateDoc < '" + this.dateTimePicker_0.Value.AddDays(1.0).ToString("yyyyMMdd") + "') or dateDoc is null order by dateDoc desc");
            }
            this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_38.Name, num.ToString(), false);
        }

        private FormBase method_1(object object_0, ShowFormEventArgs showFormEventArgs_0)
        {
            return this.OnShowForm(showFormEventArgs_0);
        }

        private void method_2(object sender, FormClosedEventArgs e)
        {
            if (((Form) sender).DialogResult == DialogResult.OK)
            {
                if (sender is FormTechConnectionRequestAddEdit)
                {
                    this.int_0 = ((FormTechConnectionRequestAddEdit) sender).Id;
                }
                this.method_0();
            }
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
                if ((dataGridView_0[this.dataGridViewFilterTextBoxColumn_7.Name, j].Value != null) && (dataGridView_0[this.dataGridViewFilterTextBoxColumn_7.Name, j].Value != DBNull.Value))
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

        private void method_4(object sender, FormClosedEventArgs e)
        {
            int idTU = ((FormTUAddEdit) sender).IdTU;
            this.method_0();
            this.dataGridViewExcelFilter_2.SearchGrid(this.dataGridViewTextBoxColumn_26.Name, idTU.ToString(), false);
        }

        private void method_5()
        {
            this.dateTimePicker_1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePicker_0.Value = new DateTime(DateTime.Now.Year, 12, 0x1f);
        }

        private void method_6()
        {
            DataSetTechConnection.vTC_DocStatusDataTable table = new DataSetTechConnection.vTC_DocStatusDataTable();
            base.SelectSqlData(table, true, " where idDoc = " + this.int_1.ToString() + " order by dateChange desc", false);
            this.bindingSource_3.DataSource = table;
            this.dataGridViewTextBoxColumn_0.Visible = false;
        }

        private void method_7()
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
            DataGridViewCellStyle style11 = new DataGridViewCellStyle();
            DataGridViewCellStyle style12 = new DataGridViewCellStyle();
            DataGridViewCellStyle style13 = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormTechConnectionRequest));
            this.dataSetTechConnection_0 = new DataSetTechConnection();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripSeparator_4 = new ToolStripSeparator();
            this.toolStripButton_22 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_9 = new ToolStripButton();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripButton_10 = new ToolStripButton();
            this.toolStripButton_11 = new ToolStripButton();
            this.toolStripButton_17 = new ToolStripButton();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripButton_18 = new ToolStripButton();
            this.toolStripButton_24 = new ToolStripButton();
            this.splitContainer_0 = new SplitContainer();
            this.checkBox_0 = new CheckBox();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_0 = new Label();
            this.dateTimePicker_1 = new DateTimePicker();
            this.label_1 = new Label();
            this.toolStrip_3 = new ToolStrip();
            this.toolStripButton_12 = new ToolStripButton();
            this.toolStripButton_13 = new ToolStripButton();
            this.splitContainer_1 = new SplitContainer();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.tabControl_0 = new TabControl();
            this.tabPage_1 = new TabPage();
            this.splitContainer_2 = new SplitContainer();
            this.dataGridViewExcelFilter_2 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
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
            this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
            this.bindingSource_2 = new BindingSource(this.icontainer_0);
            this.dataGridViewExcelFilter_3 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.bindingSource_3 = new BindingSource(this.icontainer_0);
            this.toolStrip_4 = new ToolStrip();
            this.toolStripButton_14 = new ToolStripButton();
            this.toolStripButton_15 = new ToolStripButton();
            this.toolStripButton_16 = new ToolStripButton();
            this.toolStrip_2 = new ToolStrip();
            this.toolStripDropDownButton_0 = new ToolStripDropDownButton();
            this.toolStripMenuItem_4 = new ToolStripMenuItem();
            this.toolStripMenuItem_6 = new ToolStripMenuItem();
            this.toolStripSeparator_6 = new ToolStripSeparator();
            this.toolStripMenuItem_5 = new ToolStripMenuItem();
            this.toolStripButton_7 = new ToolStripButton();
            this.toolStripButton_8 = new ToolStripButton();
            this.tabPage_2 = new TabPage();
            this.dataGridViewExcelFilter_4 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
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
            this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
            this.bindingSource_4 = new BindingSource(this.icontainer_0);
            this.toolStrip_5 = new ToolStrip();
            this.toolStripButton_19 = new ToolStripButton();
            this.toolStripButton_20 = new ToolStripButton();
            this.toolStripButton_21 = new ToolStripButton();
            this.toolStripSeparator_5 = new ToolStripSeparator();
            this.toolStripButton_23 = new ToolStripButton();
            this.tabPage_0 = new TabPage();
            this.dataGridViewExcelFilter_1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.toolStrip_1 = new ToolStrip();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripButton_5 = new ToolStripButton();
            this.toolStripButton_6 = new ToolStripButton();
            this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.toolStripMenuItem_1 = new ToolStripMenuItem();
            this.toolStripMenuItem_2 = new ToolStripMenuItem();
            this.toolStripSeparator_3 = new ToolStripSeparator();
            this.toolStripMenuItem_3 = new ToolStripMenuItem();
            this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
            this.dataSetTechConnection_0.BeginInit();
            this.toolStrip_0.SuspendLayout();
            this.splitContainer_0.Panel1.SuspendLayout();
            this.splitContainer_0.Panel2.SuspendLayout();
            this.splitContainer_0.SuspendLayout();
            this.toolStrip_3.SuspendLayout();
            this.splitContainer_1.Panel1.SuspendLayout();
            this.splitContainer_1.Panel2.SuspendLayout();
            this.splitContainer_1.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.tabControl_0.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            this.splitContainer_2.Panel1.SuspendLayout();
            this.splitContainer_2.Panel2.SuspendLayout();
            this.splitContainer_2.SuspendLayout();
            this.dataGridViewExcelFilter_2.BeginInit();
            ((ISupportInitialize) this.bindingSource_2).BeginInit();
            this.dataGridViewExcelFilter_3.BeginInit();
            ((ISupportInitialize) this.bindingSource_3).BeginInit();
            this.toolStrip_4.SuspendLayout();
            this.toolStrip_2.SuspendLayout();
            this.tabPage_2.SuspendLayout();
            this.dataGridViewExcelFilter_4.BeginInit();
            ((ISupportInitialize) this.bindingSource_4).BeginInit();
            this.toolStrip_5.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.dataGridViewExcelFilter_1.BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            this.toolStrip_1.SuspendLayout();
            this.contextMenuStrip_0.SuspendLayout();
            base.SuspendLayout();
            this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_1, this.toolStripButton_2, this.toolStripSeparator_4, this.toolStripButton_22, this.toolStripSeparator_0, this.toolStripButton_3, this.toolStripSeparator_1, this.toolStripButton_9, this.toolStripTextBox_0, this.toolStripButton_10, this.toolStripButton_11, this.toolStripButton_17, this.toolStripSeparator_2, this.toolStripButton_18, this.toolStripButton_24 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStripMain";
            this.toolStrip_0.Size = new Size(0x389, 0x19);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.ElementAdd;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnAddRequest";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Добавить";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.ElementEdit;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnEditRequest";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Редактировать";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.ElementDel;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnDelRequest";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Удалить";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripSeparator_4.Name = "toolStripSeparator5";
            this.toolStripSeparator_4.Size = new Size(6, 0x19);
            this.toolStripButton_22.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_22.Image = Resources.mergedialog;
            this.toolStripButton_22.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_22.Name = "toolBtnMergeRequest";
            this.toolStripButton_22.Size = new Size(0x17, 0x16);
            this.toolStripButton_22.Text = "Привязать к основной заявке";
            this.toolStripButton_22.Click += new EventHandler(this.toolStripButton_22_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.refresh_16;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolBtnRefresh";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Обновить";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator2";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_9.Image = Resources.Find;
            this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_9.Name = "toolBtnFindRequest";
            this.toolStripButton_9.Size = new Size(0x17, 0x16);
            this.toolStripButton_9.Text = "Поиск";
            this.toolStripButton_9.Click += new EventHandler(this.toolStripButton_9_Click);
            this.toolStripTextBox_0.Name = "toolTxtFind";
            this.toolStripTextBox_0.Size = new Size(100, 0x19);
            this.toolStripTextBox_0.ToolTipText = "Текст для поиска";
            this.toolStripTextBox_0.KeyDown += new KeyEventHandler(this.toolStripTextBox_0_KeyDown);
            this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_10.Image = Resources.FindPrev;
            this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_10.Name = "toolBtnFindPrev";
            this.toolStripButton_10.Size = new Size(0x17, 0x16);
            this.toolStripButton_10.Text = "поиск назад";
            this.toolStripButton_10.Click += new EventHandler(this.toolStripButton_10_Click);
            this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_11.Image = Resources.FindNext;
            this.toolStripButton_11.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_11.Name = "toolBtnFindNext";
            this.toolStripButton_11.Size = new Size(0x17, 0x16);
            this.toolStripButton_11.Text = "поиск вперед";
            this.toolStripButton_11.Click += new EventHandler(this.toolStripButton_11_Click);
            this.toolStripButton_17.Alignment = ToolStripItemAlignment.Right;
            this.toolStripButton_17.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_17.Image = Resources.ElementGo;
            this.toolStripButton_17.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_17.Name = "toolBtnImportOldData";
            this.toolStripButton_17.Size = new Size(0x17, 0x16);
            this.toolStripButton_17.Text = "Импорт старых данных";
            this.toolStripButton_17.Visible = false;
            this.toolStripButton_17.Click += new EventHandler(this.toolStripButton_17_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator3";
            this.toolStripSeparator_2.Size = new Size(6, 0x19);
            this.toolStripButton_18.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_18.Image = Resources.microsoftoffice2007excel_7581;
            this.toolStripButton_18.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_18.Name = "toolBtnExportExcel";
            this.toolStripButton_18.Size = new Size(0x17, 0x16);
            this.toolStripButton_18.Text = "Экспорт в Excel";
            this.toolStripButton_18.Click += new EventHandler(this.toolStripButton_18_Click);
            this.toolStripButton_24.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_24.Image = Resources.report;
            this.toolStripButton_24.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_24.Name = "toolBtnReport";
            this.toolStripButton_24.Size = new Size(0x17, 0x16);
            this.toolStripButton_24.Text = "Отчет";
            this.toolStripButton_24.Click += new EventHandler(this.toolStripButton_24_Click);
            this.splitContainer_0.Dock = DockStyle.Fill;
            this.splitContainer_0.Location = new Point(0, 0x19);
            this.splitContainer_0.Name = "splitContainer";
            this.splitContainer_0.Panel1.Controls.Add(this.checkBox_0);
            this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_0);
            this.splitContainer_0.Panel1.Controls.Add(this.label_0);
            this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_1);
            this.splitContainer_0.Panel1.Controls.Add(this.label_1);
            this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_3);
            this.splitContainer_0.Panel2.Controls.Add(this.splitContainer_1);
            this.splitContainer_0.Size = new Size(0x389, 0x1af);
            this.splitContainer_0.SplitterDistance = 0x9a;
            this.splitContainer_0.TabIndex = 1;
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Checked = true;
            this.checkBox_0.CheckState = CheckState.Checked;
            this.checkBox_0.Location = new Point(15, 0x6a);
            this.checkBox_0.Name = "checkBoxNoDate";
            this.checkBox_0.Size = new Size(0x71, 0x11);
            this.checkBox_0.TabIndex = 5;
            this.checkBox_0.Text = "Скрыть без даты";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.dateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_0.Location = new Point(12, 80);
            this.dateTimePicker_0.Name = "dateTimePickerFilterEnd";
            this.dateTimePicker_0.Size = new Size(0x88, 20);
            this.dateTimePicker_0.TabIndex = 4;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 0x40);
            this.label_0.Name = "label2";
            this.label_0.Size = new Size(0x59, 13);
            this.label_0.TabIndex = 3;
            this.label_0.Text = "Дата окончания";
            this.dateTimePicker_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.dateTimePicker_1.Location = new Point(12, 0x29);
            this.dateTimePicker_1.Name = "dateTimePickerFilterBeg";
            this.dateTimePicker_1.Size = new Size(0x8b, 20);
            this.dateTimePicker_1.TabIndex = 2;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(12, 0x19);
            this.label_1.Name = "label1";
            this.label_1.Size = new Size(0x47, 13);
            this.label_1.TabIndex = 1;
            this.label_1.Text = "Дата начала";
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_12, this.toolStripButton_13 };
            this.toolStrip_3.Items.AddRange(itemArray2);
            this.toolStrip_3.Location = new Point(0, 0);
            this.toolStrip_3.Name = "toolStripFilter";
            this.toolStrip_3.Size = new Size(0x9a, 0x19);
            this.toolStrip_3.TabIndex = 0;
            this.toolStrip_3.Text = "toolStrip1";
            this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_12.Image = Resources.filter;
            this.toolStripButton_12.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_12.Name = "toolBtnApplyFilter";
            this.toolStripButton_12.Size = new Size(0x17, 0x16);
            this.toolStripButton_12.Text = "Применить фильтр";
            this.toolStripButton_12.Click += new EventHandler(this.toolStripButton_12_Click);
            this.toolStripButton_13.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_13.Image = Resources.filter_delete;
            this.toolStripButton_13.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_13.Name = "toolBtnClearFilter";
            this.toolStripButton_13.Size = new Size(0x17, 0x16);
            this.toolStripButton_13.Text = "Очистить фильтр";
            this.toolStripButton_13.Click += new EventHandler(this.toolStripButton_13_Click);
            this.splitContainer_1.Dock = DockStyle.Fill;
            this.splitContainer_1.Location = new Point(0, 0);
            this.splitContainer_1.Name = "splitContainerDgv";
            this.splitContainer_1.Orientation = Orientation.Horizontal;
            this.splitContainer_1.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
            this.splitContainer_1.Panel2.Controls.Add(this.tabControl_0);
            this.splitContainer_1.Size = new Size(0x2eb, 0x1af);
            this.splitContainer_1.SplitterDistance = 0xfd;
            this.splitContainer_1.TabIndex = 0;
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_0.set_AllowUserToVisibleColumns(false);
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
                this.dataGridViewTextBoxColumn_38, this.dataGridViewTextBoxColumn_39, this.dataGridViewTextBoxColumn_40, this.dataGridViewTextBoxColumn_41, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_1, this.dataGridViewFilterTextBoxColumn_2, this.dataGridViewTextBoxColumn_42, this.dataGridViewTextBoxColumn_43, this.dataGridViewTextBoxColumn_44, this.dataGridViewTextBoxColumn_45, this.dataGridViewFilterTextBoxColumn_3, this.dataGridViewFilterTextBoxColumn_4, this.dataGridViewFilterTextBoxColumn_5, this.dataGridViewFilterTextBoxColumn_6, this.dataGridViewTextBoxColumn_46,
                this.dataGridViewFilterTextBoxColumn_7, this.dataGridViewFilterTextBoxColumn_8
            };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_0.Name = "dgvRequest";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(0x2eb, 0xfd);
            this.dataGridViewExcelFilter_0.TabIndex = 0;
            this.dataGridViewExcelFilter_0.VirtualMode = true;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.dataGridViewExcelFilter_0.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dataGridViewExcelFilter_0_CellMouseClick);
            this.dataGridViewExcelFilter_0.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_0_RowPostPaint);
            this.bindingSource_0.DataMember = "vTC_Request";
            this.bindingSource_0.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
            this.tabControl_0.Controls.Add(this.tabPage_1);
            this.tabControl_0.Controls.Add(this.tabPage_2);
            this.tabControl_0.Controls.Add(this.tabPage_0);
            this.tabControl_0.Dock = DockStyle.Fill;
            this.tabControl_0.Location = new Point(0, 0);
            this.tabControl_0.Name = "tabControlRequest";
            this.tabControl_0.SelectedIndex = 0;
            this.tabControl_0.Size = new Size(0x2eb, 0xae);
            this.tabControl_0.TabIndex = 0;
            this.tabPage_1.Controls.Add(this.splitContainer_2);
            this.tabPage_1.Controls.Add(this.toolStrip_2);
            this.tabPage_1.Location = new Point(4, 0x16);
            this.tabPage_1.Name = "tabPageDocOut";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(0x2e3, 0x94);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "Выданные документы";
            this.tabPage_1.UseVisualStyleBackColor = true;
            this.splitContainer_2.Dock = DockStyle.Fill;
            this.splitContainer_2.Location = new Point(0x21, 3);
            this.splitContainer_2.Name = "splitContainer1";
            this.splitContainer_2.Panel1.Controls.Add(this.dataGridViewExcelFilter_2);
            this.splitContainer_2.Panel2.Controls.Add(this.dataGridViewExcelFilter_3);
            this.splitContainer_2.Panel2.Controls.Add(this.toolStrip_4);
            this.splitContainer_2.Size = new Size(0x2bf, 0x8e);
            this.splitContainer_2.SplitterDistance = 0x144;
            this.splitContainer_2.TabIndex = 3;
            this.dataGridViewExcelFilter_2.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_2.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_2.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_2.set_AllowUserToVisibleColumns(false);
            this.dataGridViewExcelFilter_2.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_25, this.dataGridViewTextBoxColumn_26, this.dataGridViewTextBoxColumn_27, this.dataGridViewTextBoxColumn_28, this.dataGridViewTextBoxColumn_29, this.dataGridViewTextBoxColumn_30, this.dataGridViewTextBoxColumn_31, this.dataGridViewTextBoxColumn_32, this.dataGridViewTextBoxColumn_33, this.dataGridViewTextBoxColumn_34, this.dataGridViewTextBoxColumn_35, this.dataGridViewTextBoxColumn_36, this.dataGridViewTextBoxColumn_37 };
            this.dataGridViewExcelFilter_2.Columns.AddRange(columnArray2);
            this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
            this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_2.Location = new Point(0, 0);
            this.dataGridViewExcelFilter_2.Name = "dgvDocOut";
            this.dataGridViewExcelFilter_2.ReadOnly = true;
            this.dataGridViewExcelFilter_2.RowHeadersWidth = 0x15;
            this.dataGridViewExcelFilter_2.Size = new Size(0x144, 0x8e);
            this.dataGridViewExcelFilter_2.TabIndex = 2;
            this.dataGridViewExcelFilter_2.VirtualMode = true;
            this.dataGridViewExcelFilter_2.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_2_CellDoubleClick);
            this.dataGridViewExcelFilter_2.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_2_CellFormatting);
            this.dataGridViewTextBoxColumn_25.DataPropertyName = "TypeDocNameOut";
            this.dataGridViewTextBoxColumn_25.HeaderText = "Документ";
            this.dataGridViewTextBoxColumn_25.Name = "typeDocNameOutDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_25.ReadOnly = true;
            this.dataGridViewTextBoxColumn_26.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_26.HeaderText = "id";
            this.dataGridViewTextBoxColumn_26.Name = "idLinkDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_26.ReadOnly = true;
            this.dataGridViewTextBoxColumn_26.Visible = false;
            this.dataGridViewTextBoxColumn_27.DataPropertyName = "numDateDocOut";
            this.dataGridViewTextBoxColumn_27.HeaderText = "numDateDocOut";
            this.dataGridViewTextBoxColumn_27.Name = "numDateDocOutDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_27.ReadOnly = true;
            this.dataGridViewTextBoxColumn_27.Visible = false;
            this.dataGridViewTextBoxColumn_28.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_28.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_28.Name = "idDocDgvColumnIndgvDocOut";
            this.dataGridViewTextBoxColumn_28.ReadOnly = true;
            this.dataGridViewTextBoxColumn_28.Visible = false;
            this.dataGridViewTextBoxColumn_29.DataPropertyName = "numDocOut";
            this.dataGridViewTextBoxColumn_29.HeaderText = "№";
            this.dataGridViewTextBoxColumn_29.Name = "numDocOutDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_29.ReadOnly = true;
            this.dataGridViewTextBoxColumn_30.DataPropertyName = "TypeDocOut";
            this.dataGridViewTextBoxColumn_30.HeaderText = "TypeDocOut";
            this.dataGridViewTextBoxColumn_30.Name = "typeDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_30.ReadOnly = true;
            this.dataGridViewTextBoxColumn_30.Visible = false;
            this.dataGridViewTextBoxColumn_31.DataPropertyName = "idDocOut";
            this.dataGridViewTextBoxColumn_31.HeaderText = "idDocOut";
            this.dataGridViewTextBoxColumn_31.Name = "idDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_31.ReadOnly = true;
            this.dataGridViewTextBoxColumn_31.Visible = false;
            this.dataGridViewTextBoxColumn_32.DataPropertyName = "dateDocOut";
            style.Format = "d";
            style.NullValue = null;
            this.dataGridViewTextBoxColumn_32.DefaultCellStyle = style;
            this.dataGridViewTextBoxColumn_32.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_32.Name = "dateDocOutDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_32.ReadOnly = true;
            this.dataGridViewTextBoxColumn_33.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn_33.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn_33.Name = "statusDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_33.ReadOnly = true;
            this.dataGridViewTextBoxColumn_33.Visible = false;
            this.dataGridViewTextBoxColumn_34.DataPropertyName = "BodyDocOut";
            this.dataGridViewTextBoxColumn_34.HeaderText = "Содержание";
            this.dataGridViewTextBoxColumn_34.Name = "bodyDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_34.ReadOnly = true;
            this.dataGridViewTextBoxColumn_35.DataPropertyName = "SendModeName";
            this.dataGridViewTextBoxColumn_35.HeaderText = "Способ отправки";
            this.dataGridViewTextBoxColumn_35.Name = "sendModeNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_35.ReadOnly = true;
            this.dataGridViewTextBoxColumn_35.Visible = false;
            this.dataGridViewTextBoxColumn_36.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn_36.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn_36.Name = "numberDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_36.ReadOnly = true;
            this.dataGridViewTextBoxColumn_37.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn_37.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_37.Name = "commentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_37.ReadOnly = true;
            this.dataGridViewTextBoxColumn_37.Visible = false;
            this.bindingSource_2.DataMember = "vTC_DocOut";
            this.bindingSource_2.DataSource = this.dataSetTechConnection_0;
            this.bindingSource_2.CurrentChanged += new EventHandler(this.bindingSource_2_CurrentChanged);
            this.dataGridViewExcelFilter_3.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_3.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_3.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_3.set_AllowUserToVisibleColumns(false);
            this.dataGridViewExcelFilter_3.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray3 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6 };
            this.dataGridViewExcelFilter_3.Columns.AddRange(columnArray3);
            this.dataGridViewExcelFilter_3.DataSource = this.bindingSource_3;
            this.dataGridViewExcelFilter_3.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_3.Location = new Point(0, 0x19);
            this.dataGridViewExcelFilter_3.Name = "dgvDocOutStatus";
            this.dataGridViewExcelFilter_3.ReadOnly = true;
            this.dataGridViewExcelFilter_3.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_3.Size = new Size(0x177, 0x75);
            this.dataGridViewExcelFilter_3.TabIndex = 2;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "idStatusDocOutDgvColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_1.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "idStatus";
            this.dataGridViewTextBoxColumn_2.HeaderText = "idStatus";
            this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "statusName";
            this.dataGridViewTextBoxColumn_3.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "DateChange";
            style2.Format = "d";
            style2.NullValue = null;
            this.dataGridViewTextBoxColumn_4.DefaultCellStyle = style2;
            this.dataGridViewTextBoxColumn_4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_4.Width = 70;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "SendName";
            this.dataGridViewTextBoxColumn_5.HeaderText = "Способ отправки";
            this.dataGridViewTextBoxColumn_5.Name = "sendNameDgvColumn";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_6.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_6.Name = "сommentDocOutStatusDgvColumn";
            this.dataGridViewTextBoxColumn_6.ReadOnly = true;
            this.bindingSource_3.DataMember = "vTC_DocStatus";
            this.bindingSource_3.DataSource = this.dataSetTechConnection_0;
            this.toolStrip_4.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripButton_14, this.toolStripButton_15, this.toolStripButton_16 };
            this.toolStrip_4.Items.AddRange(itemArray3);
            this.toolStrip_4.Location = new Point(0, 0);
            this.toolStrip_4.Name = "toolStripDocOutStatus";
            this.toolStrip_4.Size = new Size(0x177, 0x19);
            this.toolStrip_4.TabIndex = 1;
            this.toolStrip_4.Text = "toolStrip1";
            this.toolStripButton_14.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_14.Image = Resources.ElementAdd;
            this.toolStripButton_14.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_14.Name = "toolBtnAddDocOutStatus";
            this.toolStripButton_14.Size = new Size(0x17, 0x16);
            this.toolStripButton_14.Text = "Новый статус";
            this.toolStripButton_14.Click += new EventHandler(this.toolStripButton_14_Click);
            this.toolStripButton_15.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_15.Image = Resources.ElementEdit;
            this.toolStripButton_15.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_15.Name = "toolBtnEditDocOutStatus";
            this.toolStripButton_15.Size = new Size(0x17, 0x16);
            this.toolStripButton_15.Text = "Редактировать статус";
            this.toolStripButton_15.Click += new EventHandler(this.toolStripButton_15_Click);
            this.toolStripButton_16.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_16.Image = Resources.ElementDel;
            this.toolStripButton_16.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_16.Name = "toolBtnDelDocOutStatus";
            this.toolStripButton_16.Size = new Size(0x17, 0x16);
            this.toolStripButton_16.Text = "Удалить статус";
            this.toolStripButton_16.Click += new EventHandler(this.toolStripButton_16_Click);
            this.toolStrip_2.Dock = DockStyle.Left;
            this.toolStrip_2.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolStripDropDownButton_0, this.toolStripButton_7, this.toolStripButton_8 };
            this.toolStrip_2.Items.AddRange(itemArray4);
            this.toolStrip_2.Location = new Point(3, 3);
            this.toolStrip_2.Name = "toolStripDocOut";
            this.toolStrip_2.Size = new Size(30, 0x8e);
            this.toolStrip_2.TabIndex = 1;
            this.toolStrip_2.Text = "toolStrip1";
            this.toolStripDropDownButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.toolStripMenuItem_4, this.toolStripMenuItem_6, this.toolStripSeparator_6, this.toolStripMenuItem_5 };
            this.toolStripDropDownButton_0.DropDownItems.AddRange(itemArray5);
            this.toolStripDropDownButton_0.Image = Resources.ElementAdd;
            this.toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripDropDownButton_0.Name = "toolBtnAddDocOut";
            this.toolStripDropDownButton_0.Size = new Size(0x1b, 20);
            this.toolStripDropDownButton_0.Text = "Новый документ";
            this.toolStripMenuItem_4.Name = "toolBtnAddTU";
            this.toolStripMenuItem_4.Size = new Size(0xb1, 0x16);
            this.toolStripMenuItem_4.Text = "Тех. условие";
            this.toolStripMenuItem_4.Click += new EventHandler(this.toolStripMenuItem_4_Click);
            this.toolStripMenuItem_6.Name = "toolBtnAddContract";
            this.toolStripMenuItem_6.Size = new Size(0xb1, 0x16);
            this.toolStripMenuItem_6.Text = "Договор на ТП";
            this.toolStripMenuItem_6.Click += new EventHandler(this.toolStripMenuItem_6_Click);
            this.toolStripSeparator_6.Name = "toolStripSeparator7";
            this.toolStripSeparator_6.Size = new Size(0xae, 6);
            this.toolStripMenuItem_5.Name = "toolBtnAddDocOutOther";
            this.toolStripMenuItem_5.Size = new Size(0xb1, 0x16);
            this.toolStripMenuItem_5.Text = "Другие документы";
            this.toolStripMenuItem_5.Click += new EventHandler(this.toolStripMenuItem_5_Click);
            this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_7.Image = Resources.ElementEdit;
            this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_7.Name = "toolBtnEditDocOut";
            this.toolStripButton_7.Size = new Size(0x1b, 20);
            this.toolStripButton_7.Text = "Редактировать документ";
            this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
            this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_8.Image = Resources.ElementDel;
            this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_8.Name = "toolBtnDelDocOut";
            this.toolStripButton_8.Size = new Size(0x1b, 20);
            this.toolStripButton_8.Text = "Удалить документ";
            this.toolStripButton_8.Click += new EventHandler(this.toolStripButton_8_Click);
            this.tabPage_2.Controls.Add(this.dataGridViewExcelFilter_4);
            this.tabPage_2.Controls.Add(this.toolStrip_5);
            this.tabPage_2.Location = new Point(4, 0x16);
            this.tabPage_2.Name = "tabPageRequestHistory";
            this.tabPage_2.Padding = new Padding(3);
            this.tabPage_2.Size = new Size(0x2e3, 0x94);
            this.tabPage_2.TabIndex = 2;
            this.tabPage_2.Text = "История заявок";
            this.tabPage_2.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_4.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_4.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_4.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray4 = new DataGridViewColumn[] { 
                this.dataGridViewTextBoxColumn_7, this.dataGridViewTextBoxColumn_8, this.dataGridViewTextBoxColumn_9, this.dataGridViewTextBoxColumn_10, this.dataGridViewTextBoxColumn_11, this.dataGridViewTextBoxColumn_12, this.dataGridViewTextBoxColumn_13, this.dataGridViewTextBoxColumn_14, this.dataGridViewTextBoxColumn_15, this.dataGridViewTextBoxColumn_16, this.dataGridViewTextBoxColumn_17, this.dataGridViewTextBoxColumn_18, this.dataGridViewTextBoxColumn_19, this.dataGridViewTextBoxColumn_20, this.dataGridViewTextBoxColumn_21, this.dataGridViewTextBoxColumn_22,
                this.dataGridViewTextBoxColumn_23, this.dataGridViewTextBoxColumn_24
            };
            this.dataGridViewExcelFilter_4.Columns.AddRange(columnArray4);
            this.dataGridViewExcelFilter_4.DataSource = this.bindingSource_4;
            this.dataGridViewExcelFilter_4.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_4.Location = new Point(0x1b, 3);
            this.dataGridViewExcelFilter_4.MultiSelect = false;
            this.dataGridViewExcelFilter_4.Name = "dgvRequestHistory";
            this.dataGridViewExcelFilter_4.ReadOnly = true;
            this.dataGridViewExcelFilter_4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_4.Size = new Size(0x2c5, 0x8e);
            this.dataGridViewExcelFilter_4.TabIndex = 3;
            this.dataGridViewExcelFilter_4.VirtualMode = true;
            this.dataGridViewExcelFilter_4.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_4_CellDoubleClick);
            this.dataGridViewExcelFilter_4.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_4_CellFormatting);
            this.dataGridViewExcelFilter_4.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_4_RowPostPaint);
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "numDateIn";
            style3.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_7.DefaultCellStyle = style3;
            this.dataGridViewTextBoxColumn_7.HeaderText = "№, дата вход.";
            this.dataGridViewTextBoxColumn_7.Name = "numDateInDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewTextBoxColumn_7.Width = 80;
            this.dataGridViewTextBoxColumn_8.DataPropertyName = "numDoc";
            this.dataGridViewTextBoxColumn_8.HeaderText = "numDoc";
            this.dataGridViewTextBoxColumn_8.Name = "numDocDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewTextBoxColumn_8.Visible = false;
            this.dataGridViewTextBoxColumn_9.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_9.HeaderText = "id";
            this.dataGridViewTextBoxColumn_9.Name = "idRequestHistoryDgvColumn";
            this.dataGridViewTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewTextBoxColumn_9.Visible = false;
            this.dataGridViewTextBoxColumn_10.DataPropertyName = "dateDoc";
            this.dataGridViewTextBoxColumn_10.HeaderText = "Дата получения";
            this.dataGridViewTextBoxColumn_10.Name = "dateDocDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewTextBoxColumn_10.Width = 80;
            this.dataGridViewTextBoxColumn_11.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn_11.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn_11.Name = "typeDocRequestHistoryDgvColumn";
            this.dataGridViewTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewTextBoxColumn_11.Visible = false;
            this.dataGridViewTextBoxColumn_12.DataPropertyName = "numIn";
            this.dataGridViewTextBoxColumn_12.HeaderText = "numIn";
            this.dataGridViewTextBoxColumn_12.Name = "numInDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewTextBoxColumn_12.Visible = false;
            this.dataGridViewTextBoxColumn_13.DataPropertyName = "dateIn";
            this.dataGridViewTextBoxColumn_13.HeaderText = "dateIn";
            this.dataGridViewTextBoxColumn_13.Name = "dateInDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewTextBoxColumn_13.Visible = false;
            this.dataGridViewTextBoxColumn_14.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_14.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_14.Name = "idAbnDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_14.ReadOnly = true;
            this.dataGridViewTextBoxColumn_14.Visible = false;
            this.dataGridViewTextBoxColumn_15.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_15.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_15.Name = "idAbnObjDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_15.ReadOnly = true;
            this.dataGridViewTextBoxColumn_15.Visible = false;
            this.dataGridViewTextBoxColumn_16.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_16.DataPropertyName = "body";
            style4.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_16.DefaultCellStyle = style4;
            this.dataGridViewTextBoxColumn_16.HeaderText = "Тело письма";
            this.dataGridViewTextBoxColumn_16.Name = "bodyDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_16.ReadOnly = true;
            this.dataGridViewTextBoxColumn_17.DataPropertyName = "PowerCurrent";
            this.dataGridViewTextBoxColumn_17.HeaderText = "Текущая мощность";
            this.dataGridViewTextBoxColumn_17.Name = "powerCurrentDgvColumn";
            this.dataGridViewTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewTextBoxColumn_17.Width = 70;
            this.dataGridViewTextBoxColumn_18.DataPropertyName = "PowerAdd";
            this.dataGridViewTextBoxColumn_18.HeaderText = "Доп мощность";
            this.dataGridViewTextBoxColumn_18.Name = "PowerAddDgvColumn";
            this.dataGridViewTextBoxColumn_18.ReadOnly = true;
            this.dataGridViewTextBoxColumn_18.Width = 70;
            this.dataGridViewTextBoxColumn_19.DataPropertyName = "Power";
            this.dataGridViewTextBoxColumn_19.HeaderText = "Суммарная мощность";
            this.dataGridViewTextBoxColumn_19.Name = "powerDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_19.ReadOnly = true;
            this.dataGridViewTextBoxColumn_19.Width = 70;
            this.dataGridViewTextBoxColumn_20.DataPropertyName = "VoltageName";
            this.dataGridViewTextBoxColumn_20.HeaderText = "Напряжение";
            this.dataGridViewTextBoxColumn_20.Name = "voltageNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_20.ReadOnly = true;
            this.dataGridViewTextBoxColumn_20.Width = 70;
            this.dataGridViewTextBoxColumn_21.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_21.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_21.Name = "commentDataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_21.ReadOnly = true;
            this.dataGridViewTextBoxColumn_21.Width = 70;
            this.dataGridViewTextBoxColumn_22.DataPropertyName = "VoltageLevel";
            this.dataGridViewTextBoxColumn_22.HeaderText = "VoltageLevel";
            this.dataGridViewTextBoxColumn_22.Name = "voltageLevelDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_22.ReadOnly = true;
            this.dataGridViewTextBoxColumn_22.Visible = false;
            this.dataGridViewTextBoxColumn_23.DataPropertyName = "VoltageValue";
            this.dataGridViewTextBoxColumn_23.HeaderText = "VoltageValue";
            this.dataGridViewTextBoxColumn_23.Name = "voltageValueDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_23.ReadOnly = true;
            this.dataGridViewTextBoxColumn_23.Visible = false;
            this.dataGridViewTextBoxColumn_24.DataPropertyName = "IdParent";
            this.dataGridViewTextBoxColumn_24.HeaderText = "IdParent";
            this.dataGridViewTextBoxColumn_24.Name = "idParentDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_24.ReadOnly = true;
            this.dataGridViewTextBoxColumn_24.Visible = false;
            this.bindingSource_4.DataMember = "vTC_RequestHistory";
            this.bindingSource_4.DataSource = this.dataSetTechConnection_0;
            this.toolStrip_5.Dock = DockStyle.Left;
            this.toolStrip_5.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray6 = new ToolStripItem[] { this.toolStripButton_19, this.toolStripButton_20, this.toolStripButton_21, this.toolStripSeparator_5, this.toolStripButton_23 };
            this.toolStrip_5.Items.AddRange(itemArray6);
            this.toolStrip_5.Location = new Point(3, 3);
            this.toolStrip_5.Name = "toolStripRequestHistory";
            this.toolStrip_5.Size = new Size(0x18, 0x8e);
            this.toolStrip_5.TabIndex = 2;
            this.toolStrip_5.Text = "toolStrip1";
            this.toolStripButton_19.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_19.Image = Resources.ElementAdd;
            this.toolStripButton_19.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_19.Name = "toolBtnAddReuestAdditional";
            this.toolStripButton_19.Size = new Size(0x15, 20);
            this.toolStripButton_19.Text = "Добавить";
            this.toolStripButton_19.Click += new EventHandler(this.toolStripButton_19_Click);
            this.toolStripButton_20.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_20.Image = Resources.ElementEdit;
            this.toolStripButton_20.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_20.Name = "toolBtnEditReuestAdditional";
            this.toolStripButton_20.Size = new Size(0x15, 20);
            this.toolStripButton_20.Text = "Редактировать";
            this.toolStripButton_20.Click += new EventHandler(this.toolStripButton_20_Click);
            this.toolStripButton_21.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_21.Image = Resources.ElementDel;
            this.toolStripButton_21.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_21.Name = "toolBtnDelReuestAdditional";
            this.toolStripButton_21.Size = new Size(0x15, 20);
            this.toolStripButton_21.Text = "Удалить";
            this.toolStripButton_21.Click += new EventHandler(this.toolStripButton_21_Click);
            this.toolStripSeparator_5.Name = "toolStripSeparator6";
            this.toolStripSeparator_5.Size = new Size(0x15, 6);
            this.toolStripButton_23.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_23.Image = Resources.ElementGo;
            this.toolStripButton_23.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_23.Name = "toolBtnRequestSplit";
            this.toolStripButton_23.Size = new Size(0x15, 20);
            this.toolStripButton_23.Text = "Переместить в основные заявки";
            this.toolStripButton_23.Click += new EventHandler(this.toolStripButton_23_Click);
            this.tabPage_0.Controls.Add(this.dataGridViewExcelFilter_1);
            this.tabPage_0.Controls.Add(this.toolStrip_1);
            this.tabPage_0.Location = new Point(4, 0x16);
            this.tabPage_0.Name = "tabPageDocStatus";
            this.tabPage_0.Padding = new Padding(3);
            this.tabPage_0.Size = new Size(0x2e3, 0x94);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Статус заявки";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_1.AllowUserToOrderColumns = true;
            this.dataGridViewExcelFilter_1.set_AllowUserToVisibleColumns(false);
            this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] columnArray5 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_47, this.dataGridViewTextBoxColumn_48, this.dataGridViewTextBoxColumn_49, this.dataGridViewTextBoxColumn_50, this.dataGridViewTextBoxColumn_51, this.dataGridViewTextBoxColumn_52 };
            this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray5);
            this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
            this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_1.Location = new Point(0x1b, 3);
            this.dataGridViewExcelFilter_1.Name = "dgvDocStatus";
            this.dataGridViewExcelFilter_1.ReadOnly = true;
            this.dataGridViewExcelFilter_1.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_1.Size = new Size(0x2c5, 0x8e);
            this.dataGridViewExcelFilter_1.TabIndex = 1;
            this.dataGridViewExcelFilter_1.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_1_CellDoubleClick);
            this.bindingSource_1.DataMember = "vTC_DocStatus";
            this.bindingSource_1.DataSource = this.dataSetTechConnection_0;
            this.toolStrip_1.Dock = DockStyle.Left;
            this.toolStrip_1.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray7 = new ToolStripItem[] { this.toolStripButton_4, this.toolStripButton_5, this.toolStripButton_6 };
            this.toolStrip_1.Items.AddRange(itemArray7);
            this.toolStrip_1.Location = new Point(3, 3);
            this.toolStrip_1.Name = "toolStripDocStatus";
            this.toolStrip_1.Size = new Size(0x18, 0x8e);
            this.toolStrip_1.TabIndex = 0;
            this.toolStrip_1.Text = "toolStrip1";
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.ElementAdd;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolBtnAddDocStatus";
            this.toolStripButton_4.Size = new Size(0x15, 20);
            this.toolStripButton_4.Text = "Новый статус";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = Resources.ElementEdit;
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolBtnEditDocStatus";
            this.toolStripButton_5.Size = new Size(0x15, 20);
            this.toolStripButton_5.Text = "Редактировать статус";
            this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = Resources.ElementDel;
            this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_6.Name = "toolBtnDelDocStatus";
            this.toolStripButton_6.Size = new Size(0x15, 20);
            this.toolStripButton_6.Text = "Удалить статус";
            this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
            ToolStripItem[] itemArray8 = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2, this.toolStripSeparator_3, this.toolStripMenuItem_3 };
            this.contextMenuStrip_0.Items.AddRange(itemArray8);
            this.contextMenuStrip_0.Name = "contextMenuRequest";
            this.contextMenuStrip_0.Size = new Size(0xec, 0x62);
            this.contextMenuStrip_0.Opening += new CancelEventHandler(this.contextMenuStrip_0_Opening);
            this.toolStripMenuItem_0.Image = Resources.ElementAdd;
            this.toolStripMenuItem_0.Name = "toolMenuAddRequest";
            this.toolStripMenuItem_0.Size = new Size(0xeb, 0x16);
            this.toolStripMenuItem_0.Text = "Добавить";
            this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
            this.toolStripMenuItem_1.Image = Resources.ElementEdit;
            this.toolStripMenuItem_1.Name = "toolMenuEditRequest";
            this.toolStripMenuItem_1.Size = new Size(0xeb, 0x16);
            this.toolStripMenuItem_1.Text = "Редактировать";
            this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
            this.toolStripMenuItem_2.Image = Resources.ElementDel;
            this.toolStripMenuItem_2.Name = "toolMenuDelRequest";
            this.toolStripMenuItem_2.Size = new Size(0xeb, 0x16);
            this.toolStripMenuItem_2.Text = "Удалить";
            this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripMenuItem_2_Click);
            this.toolStripSeparator_3.Name = "toolStripSeparator4";
            this.toolStripSeparator_3.Size = new Size(0xe8, 6);
            this.toolStripMenuItem_3.Image = Resources.mergedialog;
            this.toolStripMenuItem_3.Name = "toolMenuMergeRequest";
            this.toolStripMenuItem_3.Size = new Size(0xeb, 0x16);
            this.toolStripMenuItem_3.Text = "Привязать к основной заявке";
            this.toolStripMenuItem_3.Click += new EventHandler(this.toolStripMenuItem_3_Click);
            this.dataGridViewTextBoxColumn_38.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_38.HeaderText = "id";
            this.dataGridViewTextBoxColumn_38.Name = "idDgvColumn";
            this.dataGridViewTextBoxColumn_38.ReadOnly = true;
            this.dataGridViewTextBoxColumn_38.Visible = false;
            this.dataGridViewTextBoxColumn_39.DataPropertyName = "numDateIn";
            style5.WrapMode = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_39.DefaultCellStyle = style5;
            this.dataGridViewTextBoxColumn_39.HeaderText = "№, дата вход.";
            this.dataGridViewTextBoxColumn_39.Name = "numDateInDgvColumn";
            this.dataGridViewTextBoxColumn_39.ReadOnly = true;
            this.dataGridViewTextBoxColumn_40.DataPropertyName = "numDoc";
            this.dataGridViewTextBoxColumn_40.HeaderText = "numDoc";
            this.dataGridViewTextBoxColumn_40.Name = "numDocDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_40.ReadOnly = true;
            this.dataGridViewTextBoxColumn_40.Visible = false;
            this.dataGridViewTextBoxColumn_41.DataPropertyName = "dateDoc";
            this.dataGridViewTextBoxColumn_41.HeaderText = "Дата получения";
            this.dataGridViewTextBoxColumn_41.Name = "dateDocDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_41.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "nameAbn";
            style6.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_0.DefaultCellStyle = style6;
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Абонент";
            this.dataGridViewFilterTextBoxColumn_0.Name = "nameAbnDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "nameObj";
            style7.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.DefaultCellStyle = style7;
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn_1.Name = "nameObjDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "address";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Адрес";
            this.dataGridViewFilterTextBoxColumn_2.Name = "addressDgvColumn";
            this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_42.DataPropertyName = "numIn";
            this.dataGridViewTextBoxColumn_42.HeaderText = "numIn";
            this.dataGridViewTextBoxColumn_42.Name = "numInDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_42.ReadOnly = true;
            this.dataGridViewTextBoxColumn_42.Visible = false;
            this.dataGridViewTextBoxColumn_43.DataPropertyName = "dateIn";
            this.dataGridViewTextBoxColumn_43.HeaderText = "dateIn";
            this.dataGridViewTextBoxColumn_43.Name = "dateInDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_43.ReadOnly = true;
            this.dataGridViewTextBoxColumn_43.Visible = false;
            this.dataGridViewTextBoxColumn_44.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_44.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_44.Name = "idAbnDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_44.ReadOnly = true;
            this.dataGridViewTextBoxColumn_44.Visible = false;
            this.dataGridViewTextBoxColumn_45.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_45.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_45.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_45.ReadOnly = true;
            this.dataGridViewTextBoxColumn_45.Visible = false;
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "body";
            style8.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.DefaultCellStyle = style8;
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Тело письма";
            this.dataGridViewFilterTextBoxColumn_3.Name = "bodyDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "Power";
            style9.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_4.DefaultCellStyle = style9;
            this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Максимальная мощность";
            this.dataGridViewFilterTextBoxColumn_4.Name = "powerDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "VoltageName";
            this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Напр-ие";
            this.dataGridViewFilterTextBoxColumn_5.Name = "VoltageNameDgvColumn";
            this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "docStatus";
            style10.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_6.DefaultCellStyle = style10;
            this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Статус";
            this.dataGridViewFilterTextBoxColumn_6.Name = "docStatusDgvColumn";
            this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_46.DataPropertyName = "addressFull";
            this.dataGridViewTextBoxColumn_46.HeaderText = "addressFull";
            this.dataGridViewTextBoxColumn_46.Name = "addressFullDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_46.ReadOnly = true;
            this.dataGridViewTextBoxColumn_46.Visible = false;
            this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "NameDocOut";
            style11.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_7.DefaultCellStyle = style11;
            this.dataGridViewFilterTextBoxColumn_7.FillWeight = 120f;
            this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Выданные документы";
            this.dataGridViewFilterTextBoxColumn_7.Name = "nameDocOutDgvColumn";
            this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "Comment";
            style12.WrapMode = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_8.DefaultCellStyle = style12;
            this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Комментарий";
            this.dataGridViewFilterTextBoxColumn_8.Name = "commentdgvColumn";
            this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_47.DataPropertyName = "DateChange";
            style13.Format = "d";
            style13.NullValue = null;
            this.dataGridViewTextBoxColumn_47.DefaultCellStyle = style13;
            this.dataGridViewTextBoxColumn_47.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn_47.Name = "dateChangeDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_47.ReadOnly = true;
            this.dataGridViewTextBoxColumn_47.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_48.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_48.HeaderText = "id";
            this.dataGridViewTextBoxColumn_48.Name = "idRequestStatusDgvColumn";
            this.dataGridViewTextBoxColumn_48.ReadOnly = true;
            this.dataGridViewTextBoxColumn_48.Visible = false;
            this.dataGridViewTextBoxColumn_49.DataPropertyName = "idDoc";
            this.dataGridViewTextBoxColumn_49.HeaderText = "idDoc";
            this.dataGridViewTextBoxColumn_49.Name = "idDocDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_49.ReadOnly = true;
            this.dataGridViewTextBoxColumn_49.Visible = false;
            this.dataGridViewTextBoxColumn_50.DataPropertyName = "idStatus";
            this.dataGridViewTextBoxColumn_50.HeaderText = "idStatus";
            this.dataGridViewTextBoxColumn_50.Name = "idStatusDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_50.ReadOnly = true;
            this.dataGridViewTextBoxColumn_50.Visible = false;
            this.dataGridViewTextBoxColumn_51.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_51.DataPropertyName = "statusName";
            this.dataGridViewTextBoxColumn_51.FillWeight = 30.03301f;
            this.dataGridViewTextBoxColumn_51.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn_51.Name = "statusNameDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_51.ReadOnly = true;
            this.dataGridViewTextBoxColumn_51.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn_52.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_52.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn_52.FillWeight = 69.967f;
            this.dataGridViewTextBoxColumn_52.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn_52.Name = "commentStatusDgvColumn";
            this.dataGridViewTextBoxColumn_52.ReadOnly = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x389, 0x1c8);
            base.Controls.Add(this.splitContainer_0);
            base.Controls.Add(this.toolStrip_0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "FormTechConnectionRequest";
            this.Text = "Заявки на тех присоединение";
            base.FormClosed += new FormClosedEventHandler(this.FormTechConnectionRequest_FormClosed);
            base.Load += new EventHandler(this.FormTechConnectionRequest_Load);
            base.Shown += new EventHandler(this.FormTechConnectionRequest_Shown);
            this.dataSetTechConnection_0.EndInit();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.splitContainer_0.Panel1.ResumeLayout(false);
            this.splitContainer_0.Panel1.PerformLayout();
            this.splitContainer_0.Panel2.ResumeLayout(false);
            this.splitContainer_0.ResumeLayout(false);
            this.toolStrip_3.ResumeLayout(false);
            this.toolStrip_3.PerformLayout();
            this.splitContainer_1.Panel1.ResumeLayout(false);
            this.splitContainer_1.Panel2.ResumeLayout(false);
            this.splitContainer_1.ResumeLayout(false);
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.tabControl_0.ResumeLayout(false);
            this.tabPage_1.ResumeLayout(false);
            this.tabPage_1.PerformLayout();
            this.splitContainer_2.Panel1.ResumeLayout(false);
            this.splitContainer_2.Panel2.ResumeLayout(false);
            this.splitContainer_2.Panel2.PerformLayout();
            this.splitContainer_2.ResumeLayout(false);
            this.dataGridViewExcelFilter_2.EndInit();
            ((ISupportInitialize) this.bindingSource_2).EndInit();
            this.dataGridViewExcelFilter_3.EndInit();
            ((ISupportInitialize) this.bindingSource_3).EndInit();
            this.toolStrip_4.ResumeLayout(false);
            this.toolStrip_4.PerformLayout();
            this.toolStrip_2.ResumeLayout(false);
            this.toolStrip_2.PerformLayout();
            this.tabPage_2.ResumeLayout(false);
            this.tabPage_2.PerformLayout();
            this.dataGridViewExcelFilter_4.EndInit();
            ((ISupportInitialize) this.bindingSource_4).EndInit();
            this.toolStrip_5.ResumeLayout(false);
            this.toolStrip_5.PerformLayout();
            this.tabPage_0.ResumeLayout(false);
            this.tabPage_0.PerformLayout();
            this.dataGridViewExcelFilter_1.EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.contextMenuStrip_0.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        public void SearchInDgvRequest(ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter.TypeFind typeFind, string textFind)
        {
            DataSetTechConnection.vTC_RequestHistoryDataTable table = new DataSetTechConnection.vTC_RequestHistoryDataTable();
            base.SelectSqlData(table, true, " where idParent is not null and numIn like '%" + textFind + "%'", false);
            int num = (typeFind == 1) ? -1 : this.dataGridViewExcelFilter_0.CurrentCell.ColumnIndex;
            int num2 = (typeFind == 1) ? 0 : this.dataGridViewExcelFilter_0.CurrentCell.RowIndex;
            int num3 = num2;
            if (textFind.Length > 0)
            {
                while (true)
                {
                    switch (typeFind)
                    {
                        case 1:
                        case 2:
                            if (num >= (this.dataGridViewExcelFilter_0.Columns.Count - 1))
                            {
                                if ((num2 != num3) && (table.Select("idParent = " + this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_38.Name, num2].Value.ToString()).Length != 0))
                                {
                                    this.dataGridViewExcelFilter_0.FirstDisplayedScrollingRowIndex = num2;
                                    this.dataGridViewExcelFilter_0[num, num2].Selected = true;
                                    this.dataGridViewExcelFilter_0.CurrentCell = this.dataGridViewExcelFilter_0.Rows[num2].Cells[this.dataGridViewTextBoxColumn_39.Name];
                                    return;
                                }
                                num = 0;
                                num2++;
                                if (num2 < this.dataGridViewExcelFilter_0.Rows.Count)
                                {
                                    break;
                                }
                                MessageBox.Show("Фраза не найдена!");
                                return;
                            }
                            num++;
                            break;

                        case 3:
                            if (num <= 0)
                            {
                                if ((num2 != num3) && (table.Select("idParent = " + this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_38.Name, num2].Value.ToString()).Length != 0))
                                {
                                    this.dataGridViewExcelFilter_0.FirstDisplayedScrollingRowIndex = num2;
                                    this.dataGridViewExcelFilter_0[num, num2].Selected = true;
                                    this.dataGridViewExcelFilter_0.CurrentCell = this.dataGridViewExcelFilter_0.Rows[num2].Cells[this.dataGridViewTextBoxColumn_39.Name];
                                    return;
                                }
                                num = this.dataGridViewExcelFilter_0.Columns.Count - 1;
                                num2--;
                                if (num2 >= 0)
                                {
                                    break;
                                }
                                MessageBox.Show("Фраза не найдена!");
                                return;
                            }
                            num--;
                            break;
                    }
                    if ((this.dataGridViewExcelFilter_0.Columns[num].Visible && (this.dataGridViewExcelFilter_0[num, num2].Value != null)) && this.dataGridViewExcelFilter_0[num, num2].Value.ToString().ToUpper().Contains(textFind.ToUpper()))
                    {
                        this.dataGridViewExcelFilter_0.FirstDisplayedScrollingRowIndex = num2;
                        this.dataGridViewExcelFilter_0[num, num2].Selected = true;
                        this.dataGridViewExcelFilter_0.CurrentCell = this.dataGridViewExcelFilter_0.Rows[num2].Cells[num];
                        return;
                    }
                }
            }
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            FormTechConnectionRequestAddEdit edit1 = new FormTechConnectionRequestAddEdit(-1, 0x459, null);
            edit1.set_SqlSettings(this.get_SqlSettings());
            edit1.MdiParent = base.MdiParent;
            edit1.FormClosed += new FormClosedEventHandler(this.method_2);
            edit1.add_ShowForm(new ShowFormEventHandler(this, this.method_1));
            edit1.Show();
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                FormTechConnectionRequestAddEdit edit1 = new FormTechConnectionRequestAddEdit(this.int_0, 0x459, null);
                edit1.add_ShowForm(new ShowFormEventHandler(this, this.method_1));
                edit1.set_SqlSettings(this.get_SqlSettings());
                edit1.MdiParent = base.MdiParent;
                edit1.FormClosed += new FormClosedEventHandler(this.method_2);
                edit1.Show();
            }
        }

        private void toolStripButton_10_Click(object sender, EventArgs e)
        {
            this.SearchInDgvRequest(3, this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_11_Click(object sender, EventArgs e)
        {
            this.SearchInDgvRequest(2, this.toolStripTextBox_0.Text);
        }

        private void toolStripButton_12_Click(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void toolStripButton_13_Click(object sender, EventArgs e)
        {
            this.method_5();
            this.method_0();
        }

        private void toolStripButton_14_Click(object sender, EventArgs e)
        {
            if (this.int_1 != -1)
            {
                Form6 form1 = new Form6(-1, this.int_1, true);
                form1.set_SqlSettings(this.get_SqlSettings());
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    this.method_6();
                }
            }
        }

        private void toolStripButton_15_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_3.CurrentRow != null) && (this.int_1 != -1))
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
                Form6 form1 = new Form6(num, this.int_1, true);
                form1.set_SqlSettings(this.get_SqlSettings());
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    this.method_6();
                    this.dataGridViewExcelFilter_3.SearchGrid(this.dataGridViewTextBoxColumn_0.Name, num.ToString(), false);
                }
            }
        }

        private void toolStripButton_16_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_3.CurrentRow != null) && (MessageBox.Show("Вы действительно хотите удалить текущий статус", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
                if (base.DeleteSqlDataById(this.dataSetTechConnection_0.tTC_DocStatus, num))
                {
                    this.dataGridViewExcelFilter_3.Rows.Remove(this.dataGridViewExcelFilter_3.CurrentRow);
                    MessageBox.Show("Статус успешно удален");
                }
            }
        }

        private void toolStripButton_17_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DataSetTechConnection connection = new DataSetTechConnection();
                Application application = new ApplicationClass();
                Worksheet worksheet = (Worksheet) application.get_Workbooks().Open(dialog.FileName, 0, false, 5, "", "", false, (XlPlatform) 2, "", true, false, 0, true, false, false).get_Sheets().get__Default(1);
                for (int i = 2; i < 0xcf5; i++)
                {
                    string str = worksheet.get_Range("A" + i.ToString(), "A" + i.ToString()).get_Text().ToString();
                    string str2 = null;
                    DateTime minValue = DateTime.MinValue;
                    if (!string.IsNullOrEmpty(str))
                    {
                        int index = str.IndexOf("от");
                        if (index >= 0)
                        {
                            str2 = str.Substring(0, index).Trim();
                            if (str2.IndexOf("№") >= 0)
                            {
                                str2 = str2.Substring(str2.IndexOf("№") + 1).Trim();
                            }
                            string str7 = str.Substring(index + 2).Trim();
                            if ((str7.Length > 0) && (str7[str7.Length - 1] == '.'))
                            {
                                str7 = str7.Remove(str7.Length - 1);
                            }
                            DateTime.TryParse(str7, out minValue);
                        }
                        else
                        {
                            str2 = str;
                            if (str2.IndexOf("№") >= 0)
                            {
                                str2 = str2.Substring(str2.IndexOf("№") + 1).Trim();
                            }
                        }
                    }
                    string s = worksheet.get_Range("B" + i.ToString(), "B" + i.ToString()).get_Text().ToString();
                    if ((s.Length > 0) && (s[s.Length - 1] == '.'))
                    {
                        s = s.Remove(s.Length - 1);
                    }
                    DateTime result = DateTime.MinValue;
                    DateTime.TryParse(s, out result);
                    if (result < new DateTime(0x7dd, 5, 1))
                    {
                        float num2;
                        string str4 = worksheet.get_Range("C" + i.ToString(), "C" + i.ToString()).get_Text().ToString();
                        string str5 = null;
                        int? nullable = null;
                        int? nullable4 = null;
                        new SqlDataCommand(new SQLSettings("ulges-sql2", "ges", "WINDOWS", "", "")).SelectSqlData(connection.tAbn, true, " where Name = '" + str4 + "'", nullable4, false, 0);
                        if (connection.tAbn.Rows.Count > 0)
                        {
                            nullable = new int?(Convert.ToInt32(connection.tAbn.Rows[0]["id"]));
                        }
                        else
                        {
                            str5 = "Абонент: " + str4 + "\n";
                        }
                        string str6 = worksheet.get_Range("D" + i.ToString(), "D" + i.ToString()).get_Text().ToString();
                        Range range = worksheet.get_Range("E" + i.ToString(), "E" + i.ToString());
                        float? nullable2 = null;
                        if (float.TryParse(range.get_Text().ToString(), out num2))
                        {
                            nullable2 = new float?(num2);
                        }
                        range = worksheet.get_Range("F" + i.ToString(), "F" + i.ToString());
                        int? nullable3 = null;
                        if (float.TryParse(range.get_Text().ToString(), out num2))
                        {
                            if (num2 == 0.23)
                            {
                                nullable3 = 0x473;
                            }
                            if (num2 == 0.4)
                            {
                                nullable3 = 0x474;
                            }
                            if (num2 == 6f)
                            {
                                nullable3 = 0x478;
                            }
                            if (num2 == 10f)
                            {
                                nullable3 = 0x477;
                            }
                            if (num2 == 35f)
                            {
                                nullable3 = 0x476;
                            }
                            if (num2 == 110f)
                            {
                                nullable3 = 0x475;
                            }
                        }
                        range = worksheet.get_Range("K" + i.ToString(), "K" + i.ToString());
                        if (!string.IsNullOrEmpty(range.get_Text().ToString()))
                        {
                            if (string.IsNullOrEmpty(str5))
                            {
                                str5 = "Выданные документы: " + range.get_Text().ToString();
                            }
                            else
                            {
                                str5 = str5 + "Выданные документы: " + range.get_Text().ToString();
                            }
                        }
                        DataRow row = connection.tTC_Doc.NewRow();
                        row["TypeDoc"] = 0x459;
                        if (result != DateTime.MinValue)
                        {
                            row["dateDoc"] = result;
                        }
                        if (!string.IsNullOrEmpty(str5))
                        {
                            row["comment"] = str5;
                        }
                        connection.tTC_Doc.Rows.Add(row);
                        int num3 = base.InsertSqlDataOneRow(connection, connection.tTC_Doc);
                        connection.tTC_Doc.Clear();
                        DataRow row2 = connection.tTC_Request.NewRow();
                        row2["id"] = num3;
                        if (!string.IsNullOrEmpty(str2))
                        {
                            row2["numIn"] = str2;
                        }
                        if (minValue != DateTime.MinValue)
                        {
                            row2["dateIn"] = minValue;
                        }
                        if (nullable.HasValue)
                        {
                            row2["idAbn"] = nullable;
                        }
                        if (!string.IsNullOrEmpty(str6))
                        {
                            row2["body"] = str6;
                        }
                        if (nullable2.HasValue)
                        {
                            row2["Power"] = nullable2;
                        }
                        if (nullable3.HasValue)
                        {
                            row2["VoltageLevel"] = nullable3;
                        }
                        connection.tTC_Request.Rows.Add(row2);
                        base.InsertSqlData(connection, connection.tTC_Request);
                        connection.tTC_Request.Clear();
                        Application.DoEvents();
                    }
                }
                application.Quit();
                MessageBox.Show("Всё");
            }
        }

        private void toolStripButton_18_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.ExportToExcel();
        }

        private void toolStripButton_19_Click(object sender, EventArgs e)
        {
            if (this.int_0 != -1)
            {
                FormTechConnectionRequestAddEdit edit1 = new FormTechConnectionRequestAddEdit(-1, 0x4b3, new int?(this.int_0));
                edit1.set_SqlSettings(this.get_SqlSettings());
                edit1.MdiParent = base.MdiParent;
                edit1.FormClosed += new FormClosedEventHandler(this.method_2);
                edit1.add_ShowForm(new ShowFormEventHandler(this, this.method_1));
                edit1.Show();
            }
            else
            {
                MessageBox.Show("Не выбрана основная заявка");
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_0.CurrentRow != null) && (MessageBox.Show("Вы действительно хотите удалить текущую заявку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if ((this.dataSetTechConnection_0.vTC_DocOut.Rows.Count > 0) && (MessageBox.Show("Удалить все выданные документы по данной заявке?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    foreach (DataRow row in this.dataSetTechConnection_0.vTC_DocOut)
                    {
                        base.DeleteSqlDataById(this.dataSetTechConnection_0.tTC_Doc, Convert.ToInt32(row["idDocOut"]));
                    }
                    this.dataSetTechConnection_0.vTC_DocOut.Clear();
                }
                if (base.DeleteSqlDataById(this.dataSetTechConnection_0.tTC_Doc, this.int_0))
                {
                    this.dataGridViewExcelFilter_0.Rows.Remove(this.dataGridViewExcelFilter_0.CurrentRow);
                    MessageBox.Show("Заявка успешно удалена");
                }
            }
        }

        private void toolStripButton_20_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_4.CurrentRow != null)
            {
                FormTechConnectionRequestAddEdit edit1 = new FormTechConnectionRequestAddEdit(Convert.ToInt32(this.dataGridViewExcelFilter_4.CurrentRow.Cells[this.dataGridViewTextBoxColumn_9.Name].Value), 0x459, null);
                edit1.add_ShowForm(new ShowFormEventHandler(this, this.method_1));
                edit1.set_SqlSettings(this.get_SqlSettings());
                edit1.MdiParent = base.MdiParent;
                edit1.FormClosed += new FormClosedEventHandler(this.method_2);
                edit1.Show();
            }
        }

        private void toolStripButton_21_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_4.CurrentRow != null)
            {
                if (Convert.ToInt32(this.dataGridViewExcelFilter_4.CurrentRow.Cells[this.dataGridViewTextBoxColumn_11.Name].Value) == 0x459)
                {
                    MessageBox.Show("Вы не можете удалить основную заявку из истории");
                }
                else if ((MessageBox.Show("Вы действительно хотите удалить текущую заявку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && base.DeleteSqlDataById(this.dataSetTechConnection_0.tTC_Doc, Convert.ToInt32(this.dataGridViewExcelFilter_4.CurrentRow.Cells[this.dataGridViewTextBoxColumn_9.Name].Value)))
                {
                    this.dataGridViewExcelFilter_4.Rows.Remove(this.dataGridViewExcelFilter_4.CurrentRow);
                    MessageBox.Show("Заявка успешно удалена");
                }
            }
        }

        private void toolStripButton_22_Click(object sender, EventArgs e)
        {
            if ((this.int_0 != -1) && ((this.dataSetTechConnection_0.vTC_RequestHistory.Rows.Count <= 1) || (MessageBox.Show("Все дочерние заявки тоже привяжутся к выбранной", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.Cancel)))
            {
                FormTechConnectionRequestMerge merge = new FormTechConnectionRequestMerge(this.int_0);
                merge.set_SqlSettings(this.get_SqlSettings());
                if (merge.ShowDialog() == DialogResult.OK)
                {
                    this.int_0 = merge.Id;
                    this.method_0();
                }
            }
        }

        private void toolStripButton_23_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_4.CurrentRow != null)
            {
                if (Convert.ToInt32(this.dataGridViewExcelFilter_4.CurrentRow.Cells[this.dataGridViewTextBoxColumn_11.Name].Value) == 0x459)
                {
                    MessageBox.Show("Данная заявка уже находится в списке основных заявок");
                }
                else if (MessageBox.Show("Вы действительно хотите переместить текущую заявку в основной список?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataSetTechConnection connection = new DataSetTechConnection();
                    base.SelectSqlData(connection, connection.tTC_Doc, true, " where id = " + this.dataGridViewExcelFilter_4.CurrentRow.Cells[this.dataGridViewTextBoxColumn_9.Name].Value.ToString());
                    if (connection.tTC_Doc.Rows.Count > 0)
                    {
                        connection.tTC_Doc.Rows[0]["TypeDoc"] = 0x459;
                        connection.tTC_Doc.Rows[0]["IdParent"] = DBNull.Value;
                        connection.tTC_Doc.Rows[0].EndEdit();
                    }
                    if (base.UpdateSqlData(connection, connection.tTC_Doc))
                    {
                        this.int_0 = Convert.ToInt32(this.dataGridViewExcelFilter_4.CurrentRow.Cells[this.dataGridViewTextBoxColumn_9.Name].Value);
                        this.method_0();
                        MessageBox.Show("Заявка успешно перемещена");
                    }
                }
            }
        }

        private void toolStripButton_24_Click(object sender, EventArgs e)
        {
            Form8 form1 = new Form8();
            form1.set_SqlSettings(this.get_SqlSettings());
            form1.MdiParent = base.MdiParent;
            form1.Show();
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            Form6 form1 = new Form6(-1, this.int_0, false);
            form1.set_SqlSettings(this.get_SqlSettings());
            if (form1.ShowDialog() == DialogResult.OK)
            {
                this.method_0();
            }
        }

        private void toolStripButton_5_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_1.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_48.Name].Value);
                Form6 form1 = new Form6(num, this.int_0, false);
                form1.set_SqlSettings(this.get_SqlSettings());
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    this.method_0();
                    this.dataGridViewExcelFilter_1.SearchGrid(this.dataGridViewTextBoxColumn_48.Name, num.ToString(), false);
                }
            }
        }

        private void toolStripButton_6_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_1.CurrentRow != null) && (MessageBox.Show("Вы действительно хотите удалить текущий статус", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_48.Name].Value);
                if (base.DeleteSqlDataById(this.dataSetTechConnection_0.tTC_DocStatus, num))
                {
                    this.dataGridViewExcelFilter_1.Rows.Remove(this.dataGridViewExcelFilter_1.CurrentRow);
                    MessageBox.Show("Статус успешно удален");
                }
            }
        }

        private void toolStripButton_7_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_2.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_26.Name].Value);
                int num2 = Convert.ToInt32(this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_30.Name].Value);
                int idTU = Convert.ToInt32(this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_31.Name].Value);
                if (num2 == 0x463)
                {
                    FormTUAddEdit edit = new FormTUAddEdit(idTU, -1);
                    edit.set_SqlSettings(this.get_SqlSettings());
                    if (edit.ShowDialog() == DialogResult.OK)
                    {
                        this.method_0();
                        this.dataGridViewExcelFilter_2.SearchGrid(this.dataGridViewTextBoxColumn_31.Name, edit.IdTU.ToString(), false);
                    }
                }
                else if (num2 == 0x4c4)
                {
                    Form15 form = new Form15(idTU, -1, -1);
                    form.set_SqlSettings(this.get_SqlSettings());
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.method_0();
                        this.dataGridViewExcelFilter_2.SearchGrid(this.dataGridViewTextBoxColumn_31.Name, form.method_0().ToString(), false);
                    }
                }
                else
                {
                    FormTechConnectionDocOutAddEdit edit2 = new FormTechConnectionDocOutAddEdit(num, this.int_0);
                    edit2.set_SqlSettings(this.get_SqlSettings());
                    if (edit2.ShowDialog() == DialogResult.OK)
                    {
                        this.method_0();
                        this.dataGridViewExcelFilter_2.SearchGrid(this.dataGridViewTextBoxColumn_26.Name, edit2.IdDocOut.ToString(), false);
                    }
                }
            }
        }

        private void toolStripButton_8_Click(object sender, EventArgs e)
        {
            if ((this.dataGridViewExcelFilter_2.CurrentRow != null) && (MessageBox.Show("Вы действительно хотите удалить текущий документ", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Convert.ToInt32(this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_26.Name].Value);
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_31.Name].Value);
                if (base.DeleteSqlDataById(this.dataSetTechConnection_0.tTC_Doc, num))
                {
                    this.dataGridViewExcelFilter_2.Rows.Remove(this.dataGridViewExcelFilter_2.CurrentRow);
                    this.method_0();
                    MessageBox.Show("Документ успешно удален");
                }
            }
        }

        private void toolStripButton_9_Click(object sender, EventArgs e)
        {
            this.SearchInDgvRequest(1, this.toolStripTextBox_0.Text);
        }

        private void toolStripMenuItem_0_Click(object sender, EventArgs e)
        {
            this.toolStripButton_0_Click(sender, e);
        }

        private void toolStripMenuItem_1_Click(object sender, EventArgs e)
        {
            this.toolStripButton_1_Click(sender, e);
        }

        private void toolStripMenuItem_2_Click(object sender, EventArgs e)
        {
            this.toolStripButton_2_Click(sender, e);
        }

        private void toolStripMenuItem_3_Click(object sender, EventArgs e)
        {
            this.toolStripButton_22_Click(sender, e);
        }

        private void toolStripMenuItem_4_Click(object sender, EventArgs e)
        {
            if (this.int_0 != -1)
            {
                FormTUAddEdit edit1 = new FormTUAddEdit(-1, this.int_0);
                edit1.set_SqlSettings(this.get_SqlSettings());
                edit1.MdiParent = base.MdiParent;
                edit1.FormClosed += new FormClosedEventHandler(this.method_4);
                edit1.Show();
            }
        }

        private void toolStripMenuItem_5_Click(object sender, EventArgs e)
        {
            if (this.int_0 != -1)
            {
                FormTechConnectionDocOutAddEdit edit = new FormTechConnectionDocOutAddEdit(-1, this.int_0);
                edit.set_SqlSettings(this.get_SqlSettings());
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    this.method_0();
                    this.dataGridViewExcelFilter_2.SearchGrid(this.dataGridViewTextBoxColumn_26.Name, edit.IdDocOut.ToString(), false);
                }
            }
        }

        private void toolStripMenuItem_6_Click(object sender, EventArgs e)
        {
            if (this.int_0 != -1)
            {
                int num = 0x463;
                DataRow[] rowArray = this.dataSetTechConnection_0.vTC_DocOut.Select("typeDocOut = " + num.ToString());
                if (rowArray.Length != 0)
                {
                    int num2 = Convert.ToInt32(rowArray[0]["idDocOut"]);
                    Form12 form = new Form12(-1, this.int_0, num2);
                    form.set_SqlSettings(this.get_SqlSettings());
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.method_0();
                        this.dataGridViewExcelFilter_2.SearchGrid(this.dataGridViewTextBoxColumn_26.Name, form.method_0().ToString(), false);
                    }
                }
            }
        }

        private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (e.Modifiers == Keys.None))
            {
                this.SearchInDgvRequest(2, this.toolStripTextBox_0.Text);
            }
            if ((e.KeyCode == Keys.Enter) && (e.Modifiers == Keys.Shift))
            {
                this.SearchInDgvRequest(3, this.toolStripTextBox_0.Text);
            }
        }
    }
}

