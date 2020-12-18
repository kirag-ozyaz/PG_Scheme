using DataSql;
using DailyReport.DataSets;
using FormLbr;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
/// <summary>
/// "Бюллетень перерывов электроснабжения в сетях 0,4 кВ
/// </summary>
internal class FormReportInterruptLV : FormBase
{
    private BindingSource bindingSource_0;
    private bool bool_0 = true;
    private Button btnApply;
    private CheckBox checkBox1;
    private dsDamage dataSetDamage_0;
    private DataTable dataTable_0;
    private DataTable dataTable_1;
    private DateTimePicker dtpBegin;
    private DateTimePicker dtpEnd;
    private double double_0 = 37.79527559055;
    private double double_1 = 6.82708;
    private IContainer components=null;
    private Label label_0;
    private Label label_1;
    private Label label_2;
    private Label label_3;
    private Panel panel_0;
    private ReportViewer rViewerDoc;
    private TextBox txtFIO;
    private TextBox txtPost;

    internal FormReportInterruptLV()
    {
        this.InitializeComponent();
    }

    private void btnApply_Click(object sender, EventArgs e)
    {
        this.method_5();
        this.method_6();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (this.checkBox1.Checked)
        {
            this.bool_0 = false;
        }
        else
        {
            this.bool_0 = true;
        }
        this.method_6();
    }

    private void dtpBegin_ValueChanged(object sender, EventArgs e)
    {
        if (this.dtpEnd.Value < this.dtpBegin.Value)
        {
            this.dtpEnd.Value = this.dtpBegin.Value;
        }
    }

    private void dtpEnd_ValueChanged(object sender, EventArgs e)
    {
        if (this.dtpEnd.Value < this.dtpBegin.Value)
        {
            this.dtpBegin.Value = this.dtpEnd.Value;
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

    private void FormReportInterruptLV_FormClosed(object sender, FormClosedEventArgs e)
    {
        object[] content = new object[1];
        object[] objArray2 = new object[] { new XAttribute("post", this.txtPost.Text), new XAttribute("FIO", this.txtFIO.Text), new XAttribute("visible", this.checkBox1.Checked.ToString()) };
        content[0] = new XElement("confirm", objArray2);
        XDocument document = new XDocument(new XDeclaration("1.0", "utf-16", null), content);
        if (this.dataTable_1.Rows.Count > 0)
        {
            this.dataTable_1.Rows[0]["settings"] = document.ToString();
            base.UpdateSqlData(this.dataTable_1);
        }
        else
        {
            DataRow row = this.dataTable_1.NewRow();
            row["settings"] = document.ToString();
            row["module"] = "ReportInterruptLV";
            this.dataTable_1.Rows.Add(row);
            this.dataTable_1.Rows[0].EndEdit();
            base.InsertSqlData(this.dataTable_1);
        }
    }

    private void FormReportInterruptLV_Load(object sender, EventArgs e)
    {
        this.dtpBegin.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        this.dtpEnd.Value = time.AddMonths(1).AddSeconds(-1.0);
        this.method_5();
        this.method_1();
        if (!this.checkBox1.Checked)
        {
            this.method_6();
        }
    }

    private void method_0()
    {
        this.dataTable_1 = new DataTable("tSettings");
        this.dataTable_1.Columns.Add("id", typeof(int));
        this.dataTable_1.PrimaryKey = new DataColumn[] { this.dataTable_1.Columns["id"] };
        this.dataTable_1.Columns["id"].AutoIncrement = true;
        this.dataTable_1.Columns.Add("hostIP", typeof(string));
        this.dataTable_1.Columns.Add("settings", typeof(object));
        this.dataTable_1.Columns.Add("module", typeof(string));
        base.SelectSqlData(this.dataTable_1, true, " where module = 'ReportInterruptLV' ", null, false, 0);
    }

    private void method_1()
    {
        this.method_0();
        if (this.dataTable_1.Rows.Count > 0)
        {
            foreach (XElement element in XDocument.Parse(this.dataTable_1.Rows[0]["settings"].ToString()).Elements("confirm"))
            {
                if (element.Attribute("post") != null)
                {
                    this.txtPost.Text = element.Attribute("post").Value.ToString();
                }
                if (element.Attribute("FIO") != null)
                {
                    this.txtFIO.Text = element.Attribute("FIO").Value.ToString();
                }
                if (element.Attribute("visible") != null)
                {
                    this.checkBox1.Checked = Convert.ToBoolean(element.Attribute("visible").Value);
                }
            }
        }
    }

    private void method_2()
    {
        this.dataSetDamage_0.tReportIterruptLV.Clear();
        foreach (DataRow row in this.method_3().Rows)
        {
            DataRow row2 = this.dataSetDamage_0.tReportIterruptLV.NewRow();
            row2["numNetRegion"] = row["value"];
            row2["netRegionValue"] = row["name"];
            for (int i = 2; i < this.dataSetDamage_0.tReportIterruptLV.Columns.Count; i++)
            {
                row2[i] = 0;
            }
            this.dataSetDamage_0.tReportIterruptLV.Rows.Add(row2);
        }
    }

    private DataTable method_3()
    {
        DataTable table = new DataTable("tR_Classifier");
        table.Columns.Add("value", typeof(decimal));
        table.Columns.Add("name", typeof(string));
        base.SelectSqlData(table, true, " where ParentKey = ';NetworkAreas;' and deleted = 0 and isGroup = 0 order by value asc ", null, false, 0);
        DataRow row = table.NewRow();
        row["value"] = 0;
        row["name"] = "Нет данных";
        table.Rows.Add(row);
        return table;
    }

    private DataTable method_4()
    {
        DataTable table = new DataTable("tR_Classifier");
        table.Columns.Add("value", typeof(decimal));
        base.SelectSqlData(table, true, " where ParentKey like ';ReportDaily;PTS;ReasonDamage;LV;%' and deleted = '0' and isGroup = 0 order by value", null, false, 0);
        foreach (DataRow row in table.Rows)
        {
            row["value"] = Convert.ToInt32(row["value"]);
        }
        return table;
    }

    private void method_5()
    {
        string str = string.Empty;
        string str2 = string.Empty;
        foreach (DataRow row in this.method_4().Rows)
        {
            if (string.IsNullOrEmpty(str2))
            {
                str = " [" + row["value"].ToString() + "] as c" + row["value"].ToString();
                str2 = " [" + row["value"].ToString() + "]";
            }
            else
            {
                string[] textArray1 = new string[] { str, ", [", row["value"].ToString(), "] as c", row["Value"].ToString() };
                str = string.Concat(textArray1);
                str2 = str2 + ", [" + row["value"].ToString() + "]";
            }
        }
        string str3 = string.Format(" select netRegionValue as numNetRegion, {0}  from  (select t.netRegionValue, t.codeDamage from  (select dam.id, dam.numDoc, dam.dateDoc, dam.idSchmObj, dam.idReasonPTS,  sub.idNetRegion, convert(int, sub.netRegionValue) as netRegionValue, c.value as codeDamage, c.name  from tJ_Damage as dam left join  tR_Classifier as c on dam.idReasonPTS = c.Id left join  vj_damage dv on dv.id = dam.id left join  vP_SubstationByNetRegion as sub on dv.idSub = sub.id  where dam.dateDoc >= '{2}' and dam.dateDoc < '{3}' and dam.deleted = 0 ) as t  ) as res  pivot  (  count(codeDamage)  for codeDamage in ({1})  ) as pvt ", new object[] { str, str2, this.dtpBegin.Value.Date.ToString("yyyyMMdd"), Convert.ToDateTime(this.dtpEnd.Value.AddDays(1.0)).Date.ToString("yyyyMMdd") });
        this.dataTable_0 = new SqlDataCommand(this.SqlSettings).SelectSqlData(str3);
        this.method_2();
        int count = this.dataSetDamage_0.tReportIterruptLV.Columns.Count;
        int num2 = this.dataSetDamage_0.tReportIterruptLV.Rows.Count;
        for (int i = 0; i < num2; i++)
        {
            for (int k = 2; k < count; k++)
            {
                this.dataSetDamage_0.tReportIterruptLV.Rows[i][k] = 0;
            }
        }
        foreach (DataRow row2 in this.dataTable_0.Rows)
        {
            for (int m = 0; m < num2; m++)
            {
                if (row2["numNetRegion"] != DBNull.Value)
                {
                    if (((int) row2["numNetRegion"]) == ((int) this.dataSetDamage_0.tReportIterruptLV.Rows[m]["numNetRegion"]))
                    {
                        for (int n = 2; n < count; n++)
                        {
                            if (((int) row2[n - 1]) > 0)
                            {
                                this.dataSetDamage_0.tReportIterruptLV.Rows[m][n] = row2[n - 1];
                            }
                        }
                    }
                }
                else
                {
                    for (int num7 = 2; num7 < count; num7++)
                    {
                        if (((int) row2[num7 - 1]) > 0)
                        {
                            this.dataSetDamage_0.tReportIterruptLV.Rows[num2 - 1][num7] = row2[num7 - 1];
                        }
                    }
                }
            }
        }
        bool flag = true;
        for (int j = 0; j < num2; j++)
        {
            if (((int) this.dataSetDamage_0.tReportIterruptLV.Rows[j]["numNetRegion"]) != 0)
            {
                continue;
            }
            for (int num9 = 2; num9 < count; num9++)
            {
                if (((int) this.dataSetDamage_0.tReportIterruptLV[j][num9]) != 0)
                {
                    goto Label_03DC;
                }
            }
            goto Label_03DF;
        Label_03DC:
            flag = false;
        Label_03DF:
            if (flag)
            {
                this.dataSetDamage_0.tReportIterruptLV.Rows.RemoveAt(j);
            }
        }
        this.bindingSource_0.DataSource = this.dataSetDamage_0.tReportIterruptLV;
    }

    private void method_6()
    {
        this.rViewerDoc.LocalReport.ReportEmbeddedResource = "Documents.Forms.DailyReport.Reports.reportInterruptLV.rdlc";
        List<ReportParameter> parameters = new List<ReportParameter> {
            new ReportParameter("dateBegin", this.dtpBegin.Value.ToString("dd.MM.yyyy")),
            new ReportParameter("dateEnd", this.dtpEnd.Value.ToString("dd.MM.yyyy")),
            new ReportParameter("post", this.txtPost.Text),
            new ReportParameter("FIO", this.method_7()),
            new ReportParameter("hiddenConfirm", this.bool_0.ToString())
        };
        if (string.IsNullOrEmpty(this.txtPost.Text))
        {
            parameters.Add(new ReportParameter("line", "true"));
        }
        else
        {
            parameters.Add(new ReportParameter("line", "false"));
        }
        this.rViewerDoc.LocalReport.SetParameters(parameters);
        this.rViewerDoc.RefreshReport();
    }

    private string method_7()
    {
        string text = "_______";
        Font font = new Font("Arial", 10f);
        double num = (this.double_1 * this.double_0) + 39.0;
        text = text + this.txtFIO.Text;
        Size size = TextRenderer.MeasureText(text, font);
        if ((size.Width <= num) && ((num - size.Width) >= 2.0))
        {
            while (size.Width < (num - 13.0))
            {
                text = text.Insert(1, "_");
                size = TextRenderer.MeasureText(text, font);
            }
            return text;
        }
        while ((size.Width > num) || ((num - size.Width) < 2.0))
        {
            text = text.Remove(text.Length - 1);
            size = TextRenderer.MeasureText(text, font);
        }
        return text;
    }

    private void InitializeComponent()
    {
        this.components = new Container();
        ReportDataSource item = new ReportDataSource();
        this.bindingSource_0 = new BindingSource(this.components);
        this.dataSetDamage_0 = new dsDamage();
        this.dtpBegin = new DateTimePicker();
        this.dtpEnd = new DateTimePicker();
        this.label_0 = new Label();
        this.label_1 = new Label();
        this.panel_0 = new Panel();
        this.btnApply = new Button();
        this.checkBox1 = new CheckBox();
        this.rViewerDoc = new ReportViewer();
        this.txtFIO = new TextBox();
        this.txtPost = new TextBox();
        this.label_2 = new Label();
        this.label_3 = new Label();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        this.dataSetDamage_0.BeginInit();
        this.panel_0.SuspendLayout();
        base.SuspendLayout();
        this.bindingSource_0.DataMember = "tReportIterruptLV";
        this.bindingSource_0.DataSource = this.dataSetDamage_0;
        this.dataSetDamage_0.DataSetName = "DataSetDamage";
        this.dataSetDamage_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.dtpBegin.Anchor = AnchorStyles.Top;
        this.dtpBegin.Location = new Point(0x156, 8);
        this.dtpBegin.Name = "dtpBegin";
        this.dtpBegin.Size = new Size(0x83, 20);
        this.dtpBegin.TabIndex = 0;
        this.dtpBegin.ValueChanged += new EventHandler(this.dtpBegin_ValueChanged);
        this.dtpEnd.Anchor = AnchorStyles.Top;
        this.dtpEnd.Location = new Point(0x20b, 8);
        this.dtpEnd.Name = "dtpEnd";
        this.dtpEnd.Size = new Size(0x83, 20);
        this.dtpEnd.TabIndex = 1;
        this.dtpEnd.ValueChanged += new EventHandler(this.dtpEnd_ValueChanged);
        this.label_0.Anchor = AnchorStyles.Top;
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(0x11a, 14);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x36, 13);
        this.label_0.TabIndex = 2;
        this.label_0.Text = "Период с";
        this.label_1.Anchor = AnchorStyles.Top;
        this.label_1.AutoSize = true;
        this.label_1.Location = new Point(0x1f2, 14);
        this.label_1.Name = "label2";
        this.label_1.Size = new Size(0x13, 13);
        this.label_1.TabIndex = 3;
        this.label_1.Text = "по";
        this.panel_0.Controls.Add(this.txtFIO);
        this.panel_0.Controls.Add(this.btnApply);
        this.panel_0.Controls.Add(this.txtPost);
        this.panel_0.Controls.Add(this.checkBox1);
        this.panel_0.Controls.Add(this.label_2);
        this.panel_0.Controls.Add(this.label_0);
        this.panel_0.Controls.Add(this.label_3);
        this.panel_0.Controls.Add(this.dtpBegin);
        this.panel_0.Controls.Add(this.label_1);
        this.panel_0.Controls.Add(this.dtpEnd);
        this.panel_0.Dock = DockStyle.Top;
        this.panel_0.Location = new Point(0, 0);
        this.panel_0.Name = "panel1";
        this.panel_0.Size = new Size(890, 90);
        this.panel_0.TabIndex = 5;
        this.btnApply.Anchor = AnchorStyles.Top;
        this.btnApply.Location = new Point(0x29d, 5);
        this.btnApply.Name = "btnApply";
        this.btnApply.Size = new Size(0x4b, 0x17);
        this.btnApply.TabIndex = 5;
        this.btnApply.Text = "Применить";
        this.btnApply.UseVisualStyleBackColor = true;
        this.btnApply.Click += new EventHandler(this.btnApply_Click);
        this.checkBox1.AutoSize = true;
        this.checkBox1.Location = new Point(12, 13);
        this.checkBox1.Name = "checkBox1";
        this.checkBox1.Size = new Size(160, 0x11);
        this.checkBox1.TabIndex = 4;
        this.checkBox1.Text = "Показать \"УТВЕРЖДАЮ\"";
        this.checkBox1.UseVisualStyleBackColor = true;
        this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
        this.rViewerDoc.Dock = DockStyle.Fill;
        item.Name = "dsReport";
        item.Value = this.bindingSource_0;
        this.rViewerDoc.LocalReport.DataSources.Add(item);
        this.rViewerDoc.LocalReport.ReportEmbeddedResource = "Documents.Forms.DailyReport.Reports.reportInterruptLV.rdlc";
        this.rViewerDoc.Location = new Point(0, 90);
        this.rViewerDoc.Name = "rViewerDoc";
        this.rViewerDoc.Size = new Size(890, 0x1c6);
        this.rViewerDoc.TabIndex = 6;
        this.txtFIO.Location = new Point(0x56, 0x3e);
        this.txtFIO.Name = "txtFIO";
        this.txtFIO.Size = new Size(0x12e, 20);
        this.txtFIO.TabIndex = 3;
        this.txtFIO.Leave += new EventHandler(this.txtFIO_Leave);
        this.txtPost.Location = new Point(0x56, 0x24);
        this.txtPost.Name = "txtPost";
        this.txtPost.Size = new Size(0x12e, 20);
        this.txtPost.TabIndex = 2;
        this.txtPost.Leave += new EventHandler(this.txtPost_Leave);
        this.label_2.AutoSize = true;
        this.label_2.Location = new Point(12, 0x3f);
        this.label_2.Name = "label4";
        this.label_2.Size = new Size(0x25, 13);
        this.label_2.TabIndex = 1;
        this.label_2.Text = "ФИО:";
        this.label_3.AutoSize = true;
        this.label_3.Location = new Point(12, 0x27);
        this.label_3.Name = "label3";
        this.label_3.Size = new Size(0x44, 13);
        this.label_3.TabIndex = 0;
        this.label_3.Text = "Должность:";
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(890, 0x220);
        base.Controls.Add(this.rViewerDoc);
        base.Controls.Add(this.panel_0);
        base.Name = "FormReportInterruptLV";
        this.Text = "Бюллетень перерывов электроснабжения в сетях 0,4 кВ";
        base.FormClosed += new FormClosedEventHandler(this.FormReportInterruptLV_FormClosed);
        base.Load += new EventHandler(this.FormReportInterruptLV_Load);
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        this.dataSetDamage_0.EndInit();
        this.panel_0.ResumeLayout(false);
        this.panel_0.PerformLayout();
        base.ResumeLayout(false);
    }

    private void txtFIO_Leave(object sender, EventArgs e)
    {
        if (!this.bool_0)
        {
            this.method_6();
        }
    }

    private void txtPost_Leave(object sender, EventArgs e)
    {
        if (!this.bool_0)
        {
            this.method_6();
        }
    }
}

