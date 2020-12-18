using ControlsLbr.ReportViewerRus;
using Documents.Forms.DailyReport.DataSets;
using FormLbr;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
/// <summary>
/// Суточный рапорт по дефектам
/// </summary>
internal class FormReportDailyDefect : FormBase
{
    private BindingSource bindingSource_0;
    private Button buttonLoad;
    private CheckBox chkFullReport;
    private CheckBox chkNotApply;
    private CheckedListBox chkListBoxDivision;
    private DataSetDamage dataSetDamage_0;
    private DataTable dataTable_0;
    private DateTimePicker dtpEnd;
    private DateTimePicker dtpBeg;
    private IContainer components = null;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private Label label_4;
    private List<int> list_0 = new List<int>();
    private Panel panel_0;
    private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus1;
    private TextBox txtForWhom;
    private TextBox txt2;
    private TextBox txt1;

    internal FormReportDailyDefect()
    {
        this.InitializeComponent();
        this.dtpBeg.Value = this.dtpEnd.Value = DateTime.Now;
    }

    protected override void ApplyConfig(XmlDocument xmlDocument_0)
    {
        XmlNode node = xmlDocument_0.SelectSingleNode(base.Name);
        if (node != null)
        {
            foreach (XmlNode node2 in node.SelectNodes("Item"))
            {
                if (!string.IsNullOrEmpty(node2.InnerText))
                {
                    this.list_0.Add(Convert.ToInt32(node2.InnerText));
                }
            }
        }
    }

    private void buttonLoad_Click(object sender, EventArgs e)
    {
        this.method_1();
        this.method_2();
    }

    private void checkBox_0_CheckedChanged(object sender, EventArgs e)
    {
        this.method_2();
    }

    private void chkNotApply_CheckedChanged(object sender, EventArgs e)
    {
        this.method_2();
    }

    protected override XmlDocument CreateXmlConfig()
    {
        XmlDocument document = new XmlDocument();
        XmlNode newChild = document.CreateXmlDeclaration("1.0", "UTF-8", null);
        document.AppendChild(newChild);
        XmlNode node2 = document.CreateElement(base.Name);
        document.AppendChild(node2);
        foreach (object obj2 in this.chkListBoxDivision.CheckedItems)
        {
            XmlNode node3 = document.CreateElement("Item");
            node3.InnerText = ((Class191) obj2).int_0.ToString();
            node2.AppendChild(node3);
        }
        return document;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void FormReportDailyDefect_FormClosing(object sender, FormClosingEventArgs e)
    {
        this.method_5();
        base.SaveFormConfig(null);
    }

    private void FormReportDailyDefect_Load(object sender, EventArgs e)
    {
        base.LoadFormConfig(null);
        this.method_0();
        this.method_4();
        this.method_1();
        this.method_2();
    }

    private void method_0()
    {
        DataTable table = new DataTable("tR_Classifier");
        table.Columns.Add("id", typeof(int));
        table.Columns.Add("name", typeof(string));
        base.SelectSqlData(table, true, "where ParentKey = ';ReportDaily;DivisionApply;' and isGroup = 0 and deleted = 0 order by value", null, false, 0);
        object[] values = new object[] { -1, "Производственная лаборатория" };
        table.Rows.Add(values);
        foreach (DataRow row in table.Rows)
        {
            if ((this.list_0.Count != 0) && !this.list_0.Contains(Convert.ToInt32(row["id"])))
            {
                this.chkListBoxDivision.Items.Add(new Class191(Convert.ToInt32(row["id"]), row["name"].ToString()), false);
            }
            else
            {
                this.chkListBoxDivision.Items.Add(new Class191(Convert.ToInt32(row["id"]), row["name"].ToString()), true);
            }
        }
    }

    private void method_1()
    {
        this.dataSetDamage_0.ReportDailyDefect.Clear();
        using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
        {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                using (SqlCommand command = new SqlCommand(ResourceReader.GetStringAssembly("Documents.Forms.DailyReport.SqlScripts.ReportDailyDefect.sql"), connection))
                {
                    command.CommandTimeout = 0;
                    command.Transaction = transaction;
                    command.Parameters.Add("dBeg", SqlDbType.DateTime).Value = this.dtpBeg.Value.Date;
                    command.Parameters.Add("dEnd", SqlDbType.DateTime).Value = this.dtpEnd.Value.Date.AddDays(1.0);
                    new SqlDataAdapter(command).Fill(this.dataSetDamage_0.ReportDailyDefect);
                }
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                MessageBox.Show(exception.Message, exception.Source);
            }
            finally
            {
                if (transaction != null)
                {
                    transaction.Dispose();
                }
            }
        }
    }

    private void method_2()
    {
        bool flag;
        this.reportViewerRus1.Reset();
        ReportDataSource item = new ReportDataSource {
            Name = "DataSetReportDailyDefect",
            Value = this.bindingSource_0
        };
        this.reportViewerRus1.LocalReport.DataSources.Add(item);
        if (this.chkFullReport.Checked)
        {
            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Documents.Forms.DailyReport.Reports.ReportDailyDefectFull.rdlc";
        }
        else
        {
            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Documents.Forms.DailyReport.Reports.ReportDailyDefect.rdlc";
        }
        List<ReportParameter> parameters = new List<ReportParameter>();
        if (!string.IsNullOrEmpty(this.txt1.Text))
        {
            parameters.Add(new ReportParameter("textName1", this.txt1.Text));
        }
        else
        {
            parameters.Add(new ReportParameter("textName1"));
        }
        if (!string.IsNullOrEmpty(this.txt2.Text))
        {
            parameters.Add(new ReportParameter("textName2", this.txt2.Text));
        }
        if (!string.IsNullOrEmpty(this.txtForWhom.Text))
        {
            parameters.Add(new ReportParameter("textForWhom", this.txtForWhom.Text));
        }
        if (this.dtpBeg.Value.Date == this.dtpEnd.Value.Date)
        {
            parameters.Add(new ReportParameter("dateReport", this.dtpBeg.Value.Date.ToString("dd.MM.yyyy")));
        }
        else
        {
            parameters.Add(new ReportParameter("dateReport", this.dtpBeg.Value.Date.ToString("dd.MM.yyyy") + " - " + this.dtpEnd.Value.Date.ToString("dd.MM.yyyy")));
        }
        if (this.chkFullReport.Checked)
        {
            if (this.dtpBeg.Value.Date != this.dtpEnd.Value.Date)
            {
                flag = true;
                parameters.Add(new ReportParameter("VisibleDateDefect", flag.ToString()));
            }
            else
            {
                flag = false;
                parameters.Add(new ReportParameter("VisibleDateDefect", flag.ToString()));
            }
        }
        if ((this.chkListBoxDivision.CheckedItems.Count > 0) && (this.chkListBoxDivision.CheckedItems.Count < this.chkListBoxDivision.Items.Count))
        {
            string str = "";
            foreach (object obj2 in this.chkListBoxDivision.CheckedItems)
            {
                if (string.IsNullOrEmpty(str))
                {
                    str = ((Class191) obj2).int_0.ToString();
                }
                else
                {
                    str = str + "," + ((Class191) obj2).int_0.ToString();
                }
            }
            this.bindingSource_0.Filter = " idDivisionApply in (" + str + ") ";
        }
        else
        {
            this.bindingSource_0.Filter = "";
        }
        if (this.chkNotApply.Checked)
        {
            flag = true;
            parameters.Add(new ReportParameter("isNoApply", flag.ToString()));
            if (string.IsNullOrEmpty(this.bindingSource_0.Filter))
            {
                this.bindingSource_0.Filter = " (isApply = 0 or isApply is null)";
            }
            else
            {
                this.bindingSource_0.Filter = this.bindingSource_0.Filter + " and (isApply = 0 or isApply is null) ";
            }
        }
        parameters.Add(new ReportParameter("ReportUser", this.method_3()));
        this.reportViewerRus1.LocalReport.SetParameters(parameters);
        this.reportViewerRus1.RefreshReport();
    }

    private string method_3()
    {
        using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("select isnull(w.fio, u.name) as name from tuser u\r\n\t                                left join vr_worker w on u.idWorker = w.id\r\n                                    where login = SYSTEM_USER", connection))
            {
                command.CommandTimeout = 0;
                DataTable dataTable = new DataTable();
                new SqlDataAdapter(command).Fill(dataTable);
                if ((dataTable.Rows.Count > 0) && (dataTable.Rows[0]["name"] != DBNull.Value))
                {
                    return dataTable.Rows[0]["name"].ToString();
                }
            }
        }
        return string.Empty;
    }

    private void method_4()
    {
        this.dataTable_0 = new DataTable("tSettings");
        this.dataTable_0.Columns.Add("id", typeof(int));
        this.dataTable_0.PrimaryKey = new DataColumn[] { this.dataTable_0.Columns["id"] };
        this.dataTable_0.Columns["id"].AutoIncrement = true;
        this.dataTable_0.Columns.Add("hostIP", typeof(string));
        this.dataTable_0.Columns.Add("settings", typeof(object));
        this.dataTable_0.Columns.Add("module", typeof(string));
        base.SelectSqlData(this.dataTable_0, true, " where module = 'ReportDailyDefect' ", null, false, 0);
        if (this.dataTable_0.Rows.Count > 0)
        {
            string xml = this.dataTable_0.Rows[0]["settings"].ToString();
            XmlDocument document1 = new XmlDocument();
            document1.LoadXml(xml);
            XmlNode node = document1.SelectSingleNode("Sett");
            if (node != null)
            {
                if (node.Attributes["text1"] != null)
                {
                    this.txt1.Text = node.Attributes["text1"].Value.ToString();
                }
                if (node.Attributes["text2"] != null)
                {
                    this.txt2.Text = node.Attributes["text2"].Value.ToString();
                }
                if (node.Attributes["ForWhom"] != null)
                {
                    this.txtForWhom.Text = node.Attributes["ForWhom"].Value.ToString();
                }
            }
        }
    }

    private void method_5()
    {
        object[] content = new object[1];
        object[] objArray2 = new object[] { new XAttribute("text1", this.txt1.Text), new XAttribute("text2", this.txt2.Text), new XAttribute("ForWhom", this.txtForWhom.Text) };
        content[0] = new XElement("Sett", objArray2);
        XDocument document = new XDocument(new XDeclaration("1.0", "utf-16", null), content);
        if (this.dataTable_0.Rows.Count > 0)
        {
            this.dataTable_0.Rows[0]["settings"] = document.ToString();
            base.UpdateSqlData(this.dataTable_0);
        }
        else
        {
            DataRow row = this.dataTable_0.NewRow();
            row["settings"] = document.ToString();
            row["module"] = "ReportDailyDefect";
            this.dataTable_0.Rows.Add(row);
            this.dataTable_0.Rows[0].EndEdit();
            base.InsertSqlData(this.dataTable_0);
        }
    }

    private void InitializeComponent()
    {
        this.components = new Container();
        ReportDataSource item = new ReportDataSource();
        this.bindingSource_0 = new BindingSource(this.components);
        this.dataSetDamage_0 = new DataSetDamage();
        this.panel_0 = new Panel();
        this.chkListBoxDivision = new CheckedListBox();
        this.buttonLoad = new Button();
        this.dtpEnd = new DateTimePicker();
        this.label_0 = new Label();
        this.dtpBeg = new DateTimePicker();
        this.label_1 = new Label();
        this.label_2 = new Label();
        this.label_3 = new Label();
        this.label_4 = new Label();
        this.txtForWhom = new TextBox();
        this.txt2 = new TextBox();
        this.txt1 = new TextBox();
        this.reportViewerRus1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
        this.chkFullReport = new CheckBox();
        this.chkNotApply = new CheckBox();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        this.dataSetDamage_0.BeginInit();
        this.panel_0.SuspendLayout();
        base.SuspendLayout();
        this.bindingSource_0.DataMember = "ReportDailyDefect";
        this.bindingSource_0.DataSource = this.dataSetDamage_0;
        this.dataSetDamage_0.DataSetName = "DataSetDamage";
        this.dataSetDamage_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.panel_0.Controls.Add(this.chkListBoxDivision);
        this.panel_0.Controls.Add(this.buttonLoad);
        this.panel_0.Controls.Add(this.dtpEnd);
        this.panel_0.Controls.Add(this.label_0);
        this.panel_0.Controls.Add(this.dtpBeg);
        this.panel_0.Controls.Add(this.label_1);
        this.panel_0.Controls.Add(this.label_2);
        this.panel_0.Controls.Add(this.label_3);
        this.panel_0.Controls.Add(this.label_4);
        this.panel_0.Controls.Add(this.txtForWhom);
        this.panel_0.Controls.Add(this.txt2);
        this.panel_0.Controls.Add(this.txt1);
        this.panel_0.Dock = DockStyle.Top;
        this.panel_0.Location = new Point(0, 0);
        this.panel_0.Name = "panel1";
        this.panel_0.Size = new Size(0x31e, 100);
        this.panel_0.TabIndex = 0;
        this.chkListBoxDivision.CheckOnClick = true;
        this.chkListBoxDivision.FormattingEnabled = true;
        this.chkListBoxDivision.Location = new Point(0x171, 12);
        this.chkListBoxDivision.Name = "chkListBoxDivision";
        this.chkListBoxDivision.Size = new Size(0xa5, 0x4f);
        this.chkListBoxDivision.TabIndex = 11;
        this.buttonLoad.Location = new Point(540, 0x40);
        this.buttonLoad.Name = "buttonLoad";
        this.buttonLoad.Size = new Size(0x4b, 0x17);
        this.buttonLoad.TabIndex = 10;
        this.buttonLoad.Text = "Применить";
        this.buttonLoad.UseVisualStyleBackColor = true;
        this.buttonLoad.Click += new EventHandler(this.buttonLoad_Click);
        this.dtpEnd.Location = new Point(0x278, 0x26);
        this.dtpEnd.Name = "dtpEnd";
        this.dtpEnd.Size = new Size(0x98, 20);
        this.dtpEnd.TabIndex = 9;
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(0x219, 0x29);
        this.label_0.Name = "label5";
        this.label_0.Size = new Size(0x59, 13);
        this.label_0.TabIndex = 8;
        this.label_0.Text = "Дата окончания";
        this.dtpBeg.Location = new Point(0x277, 12);
        this.dtpBeg.Name = "dtpBeg";
        this.dtpBeg.Size = new Size(0x98, 20);
        this.dtpBeg.TabIndex = 7;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(0x219, 15);
        this.label_1.Name = "label4";
        this.label_1.Size = new Size(0x47, 13);
        this.label_1.TabIndex = 6;
        this.label_1.Text = "Дата начала";
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(12, 0x43);
        this.label_2.Name = "label3";
        this.label_2.Size = new Size(0x36, 13);
        this.label_2.TabIndex = 5;
        this.label_2.Text = "Для кого";
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(12, 0x29);
        this.label_3.Name = "label2";
        this.label_3.Size = new Size(0x31, 13);
        this.label_3.TabIndex = 4;
        this.label_3.Text = "Шапка 2";
        this.label_4.AutoSize = true;
        this.label_4.Location = new Point(12, 15);
        this.label_4.Name = "label1";
        this.label_4.Size = new Size(0x31, 13);
        this.label_4.TabIndex = 3;
        this.label_4.Text = "Шапка 1";
        this.txtForWhom.Location = new Point(0x48, 0x40);
        this.txtForWhom.Name = "txtForWhom";
        this.txtForWhom.Size = new Size(0x117, 20);
        this.txtForWhom.TabIndex = 2;
        this.txtForWhom.Leave += new EventHandler(this.txtForWhom_Leave);
        this.txt2.Location = new Point(0x48, 0x26);
        this.txt2.Name = "txt2";
        this.txt2.Size = new Size(0x117, 20);
        this.txt2.TabIndex = 1;
        this.txt2.Leave += new EventHandler(this.txtForWhom_Leave);
        this.txt1.Location = new Point(0x48, 12);
        this.txt1.Name = "txt1";
        this.txt1.Size = new Size(0x117, 20);
        this.txt1.TabIndex = 0;
        this.txt1.Leave += new EventHandler(this.txtForWhom_Leave);
        this.reportViewerRus1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        item.Name = "DataSetReportDailyDefect";
        item.Value = this.bindingSource_0;
        this.reportViewerRus1.LocalReport.DataSources.Add(item);
        this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Documents.Forms.DailyReport.Reports.ReportDailyDefect.rdlc";
        this.reportViewerRus1.Location = new Point(0, 100);
        this.reportViewerRus1.Name = "reportViewerRus1";
        this.reportViewerRus1.Size = new Size(0x31e, 0x1a3);
        this.reportViewerRus1.TabIndex = 1;
        this.chkFullReport.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.chkFullReport.AutoSize = true;
        this.chkFullReport.Location = new Point(12, 0x20d);
        this.chkFullReport.Name = "chkFullReport";
        this.chkFullReport.Size = new Size(0x7b, 0x11);
        this.chkFullReport.TabIndex = 2;
        this.chkFullReport.Text = "Развернутый отчет";
        this.chkFullReport.UseVisualStyleBackColor = true;
        this.chkFullReport.CheckedChanged += new EventHandler(this.checkBox_0_CheckedChanged);
        this.chkNotApply.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.chkNotApply.AutoSize = true;
        this.chkNotApply.Location = new Point(0x8d, 0x20d);
        this.chkNotApply.Name = "chkNotApply";
        this.chkNotApply.Size = new Size(110, 0x11);
        this.chkNotApply.TabIndex = 3;
        this.chkNotApply.Text = "Невыполненные";
        this.chkNotApply.UseVisualStyleBackColor = true;
        this.chkNotApply.CheckedChanged += new EventHandler(this.chkNotApply_CheckedChanged);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x31e, 550);
        base.Controls.Add(this.chkNotApply);
        base.Controls.Add(this.chkFullReport);
        base.Controls.Add(this.reportViewerRus1);
        base.Controls.Add(this.panel_0);
        base.Name = "FormReportDailyDefect";
        this.Text = "Суточный рапорт по дефектам";
        base.FormClosing += new FormClosingEventHandler(this.FormReportDailyDefect_FormClosing);
        base.Load += new EventHandler(this.FormReportDailyDefect_Load);
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        this.dataSetDamage_0.EndInit();
        this.panel_0.ResumeLayout(false);
        this.panel_0.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void txtForWhom_Leave(object sender, EventArgs e)
    {
        this.method_2();
    }

    private class Class191
    {
        internal int int_0;
        internal string string_0;

        internal Class191(int int_1, string string_1)
        {
            this.int_0 = int_1;
            this.string_0 = string_1;
        }

        public override string ToString()
        {
            return this.string_0;
        }
    }
}

