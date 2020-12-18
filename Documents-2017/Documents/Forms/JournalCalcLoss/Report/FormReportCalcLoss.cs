namespace Documents.Forms.JournalCalcLoss.Report
{
    using ControlsLbr.ReportViewerRus;
    using Documents.DataSets;
    using FormLbr;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Xml;

    public class FormReportCalcLoss : FormBase
    {
        private bool bool_0;
        private bool bool_1;
        private DateTime dateTime_0;
        private DateTime dateTime_1;
        private DateTimePicker dateTimePicker_0;
        private dsCalc dsCalc_0;
        private IContainer icontainer_0;
        private const int int_0 = 0x4ad;
        private const int int_1 = 0x4ae;
        private int int_2;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Panel panel_0;
        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus_0;
        private string string_0;
        private string string_1;
        private TextBox textBox_0;
        private TextBox textBox_1;
        private TextBox textBox_2;
        private TextBox textBox_3;

        public FormReportCalcLoss()
        {
            this.bool_0 = true;
            this.int_2 = -1;
            this.dateTime_0 = DateTime.Now;
            this.dateTime_1 = new DateTime(0x7de, 9, 1);
            this.string_0 = "";
            this.string_1 = "";
            this.method_15();
        }

        public FormReportCalcLoss(int int_3)
        {
            this.bool_0 = true;
            this.int_2 = -1;
            this.dateTime_0 = DateTime.Now;
            this.dateTime_1 = new DateTime(0x7de, 9, 1);
            this.string_0 = "";
            this.string_1 = "";
            this.method_15();
            this.int_2 = int_3;
        }

        public FormReportCalcLoss(DataTable dtCalcLoss, DataTable dtCalcLossCable)
        {
            this.bool_0 = true;
            this.int_2 = -1;
            this.dateTime_0 = DateTime.Now;
            this.dateTime_1 = new DateTime(0x7de, 9, 1);
            this.string_0 = "";
            this.string_1 = "";
            this.method_15();
            if (dtCalcLoss.Rows.Count > 0)
            {
                this.dsCalc_0.tJ_CalcLoss.ImportRow(dtCalcLoss.Rows[0]);
            }
            if (dtCalcLossCable.Rows.Count > 0)
            {
                this.dsCalc_0.tJ_CalcLossCable.ImportRow(dtCalcLossCable.Rows[0]);
            }
        }

        protected override void ApplyConfig(XmlDocument xmlDocument_0)
        {
            XmlNode node = xmlDocument_0.SelectSingleNode(base.Name);
            if (node != null)
            {
                XmlAttribute attribute = node.Attributes["FIOPerformer"];
                if (attribute != null)
                {
                    this.textBox_1.Text = attribute.Value;
                }
                attribute = node.Attributes["Phone"];
                if (attribute != null)
                {
                    this.textBox_0.Text = attribute.Value;
                }
                attribute = node.Attributes["JobTitle"];
                if (attribute != null)
                {
                    this.textBox_3.Text = attribute.Value;
                }
                attribute = node.Attributes["FIOBoss"];
                if (attribute != null)
                {
                    this.textBox_2.Text = attribute.Value;
                }
            }
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document1 = new XmlDocument();
            XmlNode newChild = document1.CreateXmlDeclaration("1.0", "UTF-8", null);
            document1.AppendChild(newChild);
            XmlNode node2 = document1.CreateElement(base.Name);
            document1.AppendChild(node2);
            XmlAttribute node = document1.CreateAttribute("FIOPerformer");
            node.Value = this.textBox_1.Text;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("Phone");
            node.Value = this.textBox_0.Text;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("JobTitle");
            node.Value = this.textBox_3.Text;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("FIOBoss");
            node.Value = this.textBox_2.Text;
            node2.Attributes.Append(node);
            return document1;
        }

        private void dateTimePicker_0_ValueChanged(object sender, EventArgs e)
        {
            ReportParameter parameter = new ReportParameter("DatePerform", this.dateTimePicker_0.Value.ToShortDateString());
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
            this.reportViewerRus_0.RefreshReport();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormReportCalcLoss_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormReportCalcLoss_Load(object sender, EventArgs e)
        {
            base.LoadFormConfig(null);
            if (this.int_2 != -1)
            {
                base.SelectSqlData(this.dsCalc_0, this.dsCalc_0.tJ_CalcLoss, true, "where id = " + this.int_2.ToString());
                base.SelectSqlData(this.dsCalc_0, this.dsCalc_0.tJ_CalcLossCable, true, "where idcalc = " + this.int_2.ToString());
            }
            if (this.dsCalc_0.tJ_CalcLoss.Rows.Count > 0)
            {
                this.dateTime_0 = Convert.ToDateTime(this.dsCalc_0.tJ_CalcLoss.Rows[0]["DateCalc"]);
                string str = "";
                if (this.dsCalc_0.tJ_CalcLoss.Rows[0]["num"] == DBNull.Value)
                {
                    str = "№ -1";
                }
                else
                {
                    str = "№ " + this.dsCalc_0.tJ_CalcLoss.Rows[0]["num"].ToString();
                }
                str = str + " от " + Convert.ToDateTime(this.dsCalc_0.tJ_CalcLoss.Rows[0]["DateCalc"]).ToString("dd MMMM yyyy");
                ReportParameter parameter = new ReportParameter("numDate", str);
                ReportParameter[] parameters = new ReportParameter[] { parameter };
                this.reportViewerRus_0.LocalReport.SetParameters(parameters);
                this.method_0();
                this.method_1();
                this.method_2();
                this.method_3();
                this.method_4();
                this.method_5();
                this.method_6();
                this.method_7();
                this.method_8();
                this.method_9();
                this.method_10();
                this.method_11();
                this.method_12();
                this.method_13();
                this.method_14();
            }
            this.reportViewerRus_0.RefreshReport();
        }

        private void method_0()
        {
            int num = Convert.ToInt32(this.dsCalc_0.tJ_CalcLoss.Rows[0]["typeCalc"]);
            if ((this.dsCalc_0.tJ_CalcLossCable.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["IsIsolation"] != DBNull.Value))
            {
                this.bool_1 = Convert.ToBoolean(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["isIsolation"]);
            }
            string str = "";
            string str2 = "";
            string str3 = "";
            switch (num)
            {
                case 0x4ad:
                    str3 = str = "КЛ";
                    if (this.bool_1)
                    {
                        this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalCalcLoss.Report.ReportKLIsolation.rdlc";
                    }
                    else
                    {
                        this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalCalcLoss.Report.ReportKL.rdlc";
                    }
                    this.bool_0 = true;
                    str2 = "кл";
                    break;

                case 0x4ae:
                    str3 = str = "ВЛ";
                    str2 = "вл";
                    if (this.bool_1)
                    {
                        this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalCalcLoss.Report.ReportVLIsolation.rdlc";
                    }
                    else
                    {
                        this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalCalcLoss.Report.ReportVL.rdlc";
                    }
                    this.bool_0 = false;
                    if (((this.dsCalc_0.tJ_CalcLossCable.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"] != DBNull.Value)) && (Convert.ToSingle(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"]) < 1f))
                    {
                        if (this.bool_1)
                        {
                            this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalCalcLoss.Report.ReportVLIsolation.rdlc";
                        }
                        else
                        {
                            this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalCalcLoss.Report.ReportKL.rdlc";
                        }
                        this.bool_0 = true;
                    }
                    break;
            }
            if ((this.dsCalc_0.tJ_CalcLossCable.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"] != DBNull.Value))
            {
                object[] objArray1 = new object[] { str, " ", this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"], "кВ" };
                str = string.Concat(objArray1);
            }
            ReportParameter parameter = new ReportParameter("typeCalcStr", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
            parameter = new ReportParameter("typeMin", str2);
            ReportParameter[] parameterArray2 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray2);
            parameter = new ReportParameter("typeMax", str3);
            ReportParameter[] parameterArray3 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray3);
            parameter = new ReportParameter("isKL", this.bool_0.ToString());
            ReportParameter[] parameterArray4 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray4);
        }

        private void method_1()
        {
            string str = "";
            if (this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnBalance"] != DBNull.Value)
            {
                base.SelectSqlData(this.dsCalc_0, this.dsCalc_0.tAbn, true, "where id = " + this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnBalance"].ToString());
                if (this.dsCalc_0.tAbn.Rows.Count > 0)
                {
                    str = this.dsCalc_0.tAbn.Rows[0]["name"].ToString();
                }
                if (((this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbn"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnBalance"].ToString() == this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbn"].ToString())) && (this.dsCalc_0.tAbn.Rows.Count > 0))
                {
                    if (Convert.ToInt32(this.dsCalc_0.tAbn.Rows[0]["codeAbonent"]) > 0)
                    {
                        str = str + " д." + this.dsCalc_0.tAbn.Rows[0]["codeAbonent"].ToString();
                    }
                    int num = Convert.ToInt32(this.dsCalc_0.tAbn.Rows[0]["typeAbn"]);
                    if (this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnObj"] != DBNull.Value)
                    {
                        dsCalc.vAbnObjAddressDataTable table = new dsCalc.vAbnObjAddressDataTable();
                        DataColumn column = new DataColumn("AddressFL") {
                            Expression = "street + ', д. ' + houseall + ', кв. ' + name"
                        };
                        table.Columns.Add(column);
                        base.SelectSqlData(table, true, "where id = " + this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnObj"].ToString(), false);
                        if (table.Rows.Count > 0)
                        {
                            if (((num != 0xce) && (num != 0xfd)) && (num != 0x40d))
                            {
                                str = str + " (" + table.Rows[0]["name"].ToString() + ")";
                            }
                            else
                            {
                                str = str + " (" + table.Rows[0]["AddressFL"].ToString() + ")";
                            }
                        }
                    }
                }
            }
            ReportParameter parameter = new ReportParameter("AbnBalance", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
        }

        private void method_10()
        {
            string str = "";
            string str2 = "";
            if ((this.dsCalc_0.tJ_CalcLossCable.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffLosses"] != DBNull.Value))
            {
                str2 = Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffLosses"]).smethod_0();
                if (this.bool_0)
                {
                    if ((this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadLosses"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Consumption"] != DBNull.Value))
                    {
                        string[] textArray1 = new string[] { "100% * ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadLosses"]).smethod_0(), " / ", this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Consumption"].ToString(), " = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffLosses"]).smethod_0(), "%" };
                        str = string.Concat(textArray1);
                    }
                }
                else if ((this.dsCalc_0.tJ_CalcLossCable.Rows[0]["SumLoadLosses"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Consumption"] != DBNull.Value))
                {
                    string[] textArray2 = new string[] { "100% * ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["SumLoadLosses"]).smethod_0(), " / ", this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Consumption"].ToString(), " = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffLosses"]).smethod_0(), "%" };
                    str = string.Concat(textArray2);
                }
            }
            ReportParameter parameter = new ReportParameter("CoeffLoss", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
            parameter = new ReportParameter("Coefficient", str2);
            ReportParameter[] parameterArray2 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray2);
        }

        private void method_11()
        {
            if (this.bool_1)
            {
                string str = "";
                decimal d = new decimal();
                if ((this.dsCalc_0.tJ_CalcLossCable.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["isolationLosses"] != DBNull.Value))
                {
                    d = Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["isolationLosses"]);
                    if (((this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffIsolation"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["lenghtCable"] != DBNull.Value)) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["countChain"] != DBNull.Value))
                    {
                        string[] textArray1 = new string[] { Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffIsolation"]).smethod_0(), " * ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["lenghtCable"]).smethod_0(), " * ", this.dsCalc_0.tJ_CalcLossCable.Rows[0]["countChain"].ToString(), " * 1000 = ", (this.dateTime_0 > this.dateTime_1) ? Math.Round(Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["isolationLosses"]), 0).smethod_0() : Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["isolationLosses"]).smethod_0(), " кВт*ч" };
                        str = string.Concat(textArray1);
                    }
                }
                ReportParameter parameter = new ReportParameter("IsolationLoss", str);
                ReportParameter[] parameters = new ReportParameter[] { parameter };
                this.reportViewerRus_0.LocalReport.SetParameters(parameters);
                parameter = new ReportParameter("IsolationLossValue", d.ToString());
                ReportParameter[] parameterArray2 = new ReportParameter[] { parameter };
                this.reportViewerRus_0.LocalReport.SetParameters(parameterArray2);
                DataTable table = new DataTable();
                for (int i = 1; i <= 12; i++)
                {
                    table.Columns.Add("Month" + i.ToString(), typeof(decimal));
                }
                DataRow row = table.NewRow();
                if (this.dateTime_0 < this.dateTime_1)
                {
                    for (int j = 1; j <= 12; j++)
                    {
                        if (j == 2)
                        {
                            row["Month" + j.ToString()] = (Math.Round(d, 2) - (Math.Round((decimal) ((d / 365M) * 30M), 2) * 4M)) - (Math.Round((decimal) ((d / 365M) * 31M), 2) * 7M);
                        }
                        else
                        {
                            row["Month" + j.ToString()] = Math.Round((decimal) ((d / 365M) * DateTime.DaysInMonth(this.dateTime_0.Year, j)), 2);
                        }
                    }
                }
                else
                {
                    for (int k = 1; k <= 12; k++)
                    {
                        if (k == 2)
                        {
                            row["Month" + k.ToString()] = (Math.Round(d, 0) - (Math.Round((decimal) ((d / 365M) * 30M), 0) * 4M)) - (Math.Round((decimal) ((d / 365M) * 31M), 0) * 7M);
                        }
                        else
                        {
                            row["Month" + k.ToString()] = Math.Round((decimal) ((d / 365M) * DateTime.DaysInMonth(this.dateTime_0.Year, k)), 0);
                        }
                    }
                }
                if (Convert.ToDecimal(row["Month2"]) < decimal.Zero)
                {
                    row["Month1"] = Convert.ToDecimal(row["Month1"]) + Convert.ToDecimal(row["Month2"]);
                    row["Month2"] = 0;
                    if (Convert.ToDecimal(row["Month1"]) < decimal.Zero)
                    {
                        row["Month3"] = Convert.ToDecimal(row["Month3"]) + Convert.ToDecimal(row["Month1"]);
                        row["Month1"] = 0;
                        for (int m = 3; m <= 12; m++)
                        {
                            if (Convert.ToDecimal(row["Month" + m.ToString()]) >= decimal.Zero)
                            {
                                break;
                            }
                            int num6 = m + 1;
                            num6 = m + 1;
                            row["Month" + num6.ToString()] = Convert.ToDecimal(row["Month" + num6.ToString()]) + Convert.ToDecimal(row["Month" + m.ToString()]);
                            row["Month" + m.ToString()] = 0;
                        }
                    }
                }
                table.Rows.Add(row);
                ReportDataSource item = new ReportDataSource {
                    Name = "dtIsolationLoss",
                    Value = table
                };
                this.reportViewerRus_0.LocalReport.DataSources.Add(item);
            }
        }

        private void method_12()
        {
            if ((this.dsCalc_0.tJ_CalcLoss.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLoss.Rows[0]["DateCalc"] != DBNull.Value))
            {
                this.dateTimePicker_0.Value = Convert.ToDateTime(this.dsCalc_0.tJ_CalcLoss.Rows[0]["DateCalc"]);
            }
            else
            {
                this.dateTimePicker_0.Value = DateTime.Now;
            }
            ReportParameter parameter = new ReportParameter("DatePerform", this.dateTimePicker_0.Value.ToShortDateString());
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
        }

        private void method_13()
        {
            ReportParameter parameter = new ReportParameter("JobTitle", this.textBox_3.Text);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
            this.reportViewerRus_0.RefreshReport();
        }

        private void method_14()
        {
            ReportParameter parameter = new ReportParameter("FIOBoss", this.textBox_2.Text);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
            this.reportViewerRus_0.RefreshReport();
        }

        private void method_15()
        {
            this.reportViewerRus_0 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.dsCalc_0 = new dsCalc();
            this.panel_0 = new Panel();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_0 = new Label();
            this.textBox_0 = new TextBox();
            this.label_1 = new Label();
            this.textBox_1 = new TextBox();
            this.label_2 = new Label();
            this.label_4 = new Label();
            this.textBox_3 = new TextBox();
            this.label_3 = new Label();
            this.textBox_2 = new TextBox();
            this.dsCalc_0.BeginInit();
            this.panel_0.SuspendLayout();
            base.SuspendLayout();
            this.reportViewerRus_0.Dock = DockStyle.Fill;
            this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalCalcLoss.Report.ReportKL.rdlc";
            this.reportViewerRus_0.Location = new Point(0, 0);
            this.reportViewerRus_0.Name = "reportViewer1";
            this.reportViewerRus_0.Size = new Size(0x32d, 440);
            this.reportViewerRus_0.TabIndex = 0;
            this.dsCalc_0.DataSetName = "dsCalc";
            this.dsCalc_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.panel_0.Controls.Add(this.textBox_2);
            this.panel_0.Controls.Add(this.label_3);
            this.panel_0.Controls.Add(this.textBox_3);
            this.panel_0.Controls.Add(this.label_4);
            this.panel_0.Controls.Add(this.dateTimePicker_0);
            this.panel_0.Controls.Add(this.label_0);
            this.panel_0.Controls.Add(this.textBox_0);
            this.panel_0.Controls.Add(this.label_1);
            this.panel_0.Controls.Add(this.textBox_1);
            this.panel_0.Controls.Add(this.label_2);
            this.panel_0.Dock = DockStyle.Bottom;
            this.panel_0.Location = new Point(0, 440);
            this.panel_0.Name = "panelIsp";
            this.panel_0.Size = new Size(0x32d, 0x5f);
            this.panel_0.TabIndex = 1;
            this.dateTimePicker_0.Location = new Point(0x1ef, 0x3e);
            this.dateTimePicker_0.Name = "dateTimePicker";
            this.dateTimePicker_0.Size = new Size(0x92, 20);
            this.dateTimePicker_0.TabIndex = 5;
            this.dateTimePicker_0.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(0x1ec, 0x2e);
            this.label_0.Name = "label3";
            this.label_0.Size = new Size(0x21, 13);
            this.label_0.TabIndex = 4;
            this.label_0.Text = "Дата";
            this.textBox_0.Location = new Point(0x11b, 0x3e);
            this.textBox_0.Name = "txtPhone";
            this.textBox_0.Size = new Size(0xae, 20);
            this.textBox_0.TabIndex = 3;
            this.textBox_0.TextChanged += new EventHandler(this.textBox_0_TextChanged);
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(280, 0x2e);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(0x34, 13);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "Телефон";
            this.textBox_1.Location = new Point(12, 0x3e);
            this.textBox_1.Name = "txtFIO";
            this.textBox_1.Size = new Size(0xfb, 20);
            this.textBox_1.TabIndex = 1;
            this.textBox_1.TextChanged += new EventHandler(this.textBox_1_TextChanged);
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(12, 0x2e);
            this.label_2.Name = "label1";
            this.label_2.Size = new Size(0x4a, 13);
            this.label_2.TabIndex = 0;
            this.label_2.Text = "Исполнитель";
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(12, 3);
            this.label_4.Name = "label4";
            this.label_4.Size = new Size(0x41, 13);
            this.label_4.TabIndex = 6;
            this.label_4.Text = "Должность";
            this.textBox_3.Location = new Point(12, 0x13);
            this.textBox_3.Name = "txtTitleJob";
            this.textBox_3.Size = new Size(0xfb, 20);
            this.textBox_3.TabIndex = 7;
            this.textBox_3.Text = "Начальник СКиУЭЭ";
            this.textBox_3.TextChanged += new EventHandler(this.textBox_3_TextChanged);
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(280, 3);
            this.label_3.Name = "label5";
            this.label_3.Size = new Size(0x22, 13);
            this.label_3.TabIndex = 8;
            this.label_3.Text = "ФИО";
            this.textBox_2.Location = new Point(0x11b, 0x13);
            this.textBox_2.Name = "txtFIOBoss";
            this.textBox_2.Size = new Size(0xae, 20);
            this.textBox_2.TabIndex = 9;
            this.textBox_2.Text = "Исаева Н.В.";
            this.textBox_2.TextChanged += new EventHandler(this.textBox_2_TextChanged);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x32d, 0x217);
            base.Controls.Add(this.reportViewerRus_0);
            base.Controls.Add(this.panel_0);
            base.Name = "FormReportCalcLoss";
            this.Text = "Печать расчета потерь";
            base.FormClosing += new FormClosingEventHandler(this.FormReportCalcLoss_FormClosing);
            base.Load += new EventHandler(this.FormReportCalcLoss_Load);
            this.dsCalc_0.EndInit();
            this.panel_0.ResumeLayout(false);
            this.panel_0.PerformLayout();
            base.ResumeLayout(false);
        }

        private void method_2()
        {
            string str = "";
            if (this.dsCalc_0.tJ_CalcLoss.Rows[0]["tpName"] != DBNull.Value)
            {
                str = this.dsCalc_0.tJ_CalcLoss.Rows[0]["tpName"].ToString();
            }
            if ((this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbn"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnBalance"].ToString() != this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbn"].ToString()))
            {
                base.SelectSqlData(this.dsCalc_0, this.dsCalc_0.tAbn, true, "where id = " + this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbn"].ToString());
                if (this.dsCalc_0.tAbn.Rows.Count > 0)
                {
                    str = str + " (" + this.dsCalc_0.tAbn.Rows[0]["name"].ToString();
                    if (Convert.ToInt32(this.dsCalc_0.tAbn.Rows[0]["codeAbonent"]) > 0)
                    {
                        str = str + " д." + this.dsCalc_0.tAbn.Rows[0]["codeAbonent"].ToString() + ")";
                    }
                    else
                    {
                        str = str + ")";
                    }
                }
            }
            ReportParameter parameter = new ReportParameter("tpName", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
        }

        private void method_3()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Desription");
            table.Columns.Add("Dimension");
            table.Columns.Add("Val");
            if (this.dsCalc_0.tJ_CalcLossCable.Rows.Count > 0)
            {
                if (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["lenghtcable"] != DBNull.Value)
                {
                    this.string_0 = Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["lenghtcable"]).smethod_0();
                }
                string str = "Длина линии";
                if (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["makeupCable"] != DBNull.Value)
                {
                    base.SelectSqlData(this.dsCalc_0.vR_Cable, true, "where id = " + this.dsCalc_0.tJ_CalcLossCable.Rows[0]["makeupCable"].ToString(), false);
                    if (((this.dsCalc_0.vR_Cable.Rows.Count > 0) && (this.dsCalc_0.vR_Cable.Rows[0]["CableMakeup"] != DBNull.Value)) && (this.dsCalc_0.vR_Cable.Rows[0]["CrossSection"] != DBNull.Value))
                    {
                        if (this.dsCalc_0.vR_Cable.Rows[0]["Wires"] != DBNull.Value)
                        {
                            string[] textArray1 = new string[] { str, ", (", this.dsCalc_0.vR_Cable.Rows[0]["CableMakeup"].ToString(), " ", this.dsCalc_0.vR_Cable.Rows[0]["Wires"].ToString(), "x", this.dsCalc_0.vR_Cable.Rows[0]["CrossSection"].ToString(), ")" };
                            str = string.Concat(textArray1);
                            if (((this.dsCalc_0.vR_Cable.Rows[0]["WiresAddl"] != DBNull.Value) && (Convert.ToInt32(this.dsCalc_0.vR_Cable.Rows[0]["WiresAddl"]) > 0)) && (this.dsCalc_0.vR_Cable.Rows[0]["CrossSectionAddl"] != DBNull.Value))
                            {
                                string[] textArray2 = new string[] { str.Remove(str.Length - 1), " + ", this.dsCalc_0.vR_Cable.Rows[0]["WiresAddl"].ToString(), "x", this.dsCalc_0.vR_Cable.Rows[0]["CrossSectionAddl"].ToString(), ")" };
                                str = string.Concat(textArray2);
                            }
                        }
                        else
                        {
                            string[] textArray3 = new string[] { str, ", (", this.dsCalc_0.vR_Cable.Rows[0]["CableMakeup"].ToString(), "-", this.dsCalc_0.vR_Cable.Rows[0]["CrossSection"].ToString(), ")" };
                            str = string.Concat(textArray3);
                        }
                    }
                }
                object[] values = new object[] { str, "L, км", this.string_0 };
                table.Rows.Add(values);
                if (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["UdResistance"] != DBNull.Value)
                {
                    object[] objArray2 = new object[] { "Удельное активное сопротивление линии на 1 км провода", "r0, Ом/км", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["UdResistance"]).smethod_0() };
                    table.Rows.Add(objArray2);
                }
                else
                {
                    object[] objArray3 = new object[] { "Удельное активное сопротивление линии на 1 км провода", "r0, Ом/км", "" };
                    table.Rows.Add(objArray3);
                }
                if (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"] != DBNull.Value)
                {
                    object[] objArray4 = new object[] { "Среднее напряжение линии", "Uср, кВ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"]).smethod_0() };
                    table.Rows.Add(objArray4);
                }
                else
                {
                    object[] objArray5 = new object[] { "Среднее напряжение линии", "Uср, кВ", "" };
                    table.Rows.Add(objArray5);
                }
                if (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Consumption"] != DBNull.Value)
                {
                    object[] objArray6 = new object[] { "Потребление активной электроэнергии за базовый период по счетчику", "Wт, кВт*ч", this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Consumption"].ToString() };
                    table.Rows.Add(objArray6);
                }
                else
                {
                    object[] objArray7 = new object[] { "Потребление активной электроэнергии за базовый период по счетчику", "Wт, кВт*ч", "" };
                    table.Rows.Add(objArray7);
                }
                if (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["period"] != DBNull.Value)
                {
                    object[] objArray8 = new object[] { "Базовый (расчетный) период", "Т, час", this.dsCalc_0.tJ_CalcLossCable.Rows[0]["period"].ToString() };
                    table.Rows.Add(objArray8);
                }
                else
                {
                    object[] objArray9 = new object[] { "Базовый (расчетный) период", "Т, час", "" };
                    table.Rows.Add(objArray9);
                }
                if (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffPowerReactive"] != DBNull.Value)
                {
                    object[] objArray10 = new object[] { "Коэффициент реактивной мощности", "tg φ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffPowerReactive"]).smethod_0() };
                    table.Rows.Add(objArray10);
                }
                else
                {
                    object[] objArray11 = new object[] { "Коэффициент реактивной мощности", "tg φ", "" };
                    table.Rows.Add(objArray11);
                }
                if (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["SquareCoeffFromGraph"] != DBNull.Value)
                {
                    object[] objArray12 = new object[] { "Квадрат коэффициента формы графика за базовый период", "kφ\x00b2, о.е.", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["SquareCoeffFromGraph"]).smethod_0() };
                    table.Rows.Add(objArray12);
                }
                else
                {
                    object[] objArray13 = new object[] { "Квадрат коэффициента формы графика за базовый период", "kφ\x00b2, о.е.", "" };
                    table.Rows.Add(objArray13);
                }
                if (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffDifferences"] != DBNull.Value)
                {
                    object[] objArray14 = new object[] { "Коэффициент учитывающий различие конфигураций графиков активной и реактивной нагрузки", "kк, о.е.", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffDifferences"]).smethod_0() };
                    table.Rows.Add(objArray14);
                }
                else
                {
                    object[] objArray15 = new object[] { "Коэффициент учитывающий различие конфигураций графиков активной и реактивной нагрузки", "kк, о.е.", "" };
                    table.Rows.Add(objArray15);
                }
                this.string_1 = this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CountChain"].ToString();
                object[] objArray16 = new object[] { "Количество параллельных цепей", "nц, шт", this.string_1 };
                table.Rows.Add(objArray16);
            }
            ReportDataSource item = new ReportDataSource {
                Name = "dsSource",
                Value = table
            };
            this.reportViewerRus_0.LocalReport.DataSources.Add(item);
        }

        private void method_4()
        {
            string str = "";
            if ((((this.dsCalc_0.tJ_CalcLossCable.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["UdResistance"] != DBNull.Value)) && (!string.IsNullOrEmpty(this.string_0) && !string.IsNullOrEmpty(this.string_1))) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["ActiveResistance"] != DBNull.Value))
            {
                string[] textArray1 = new string[] { " = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["UdResistance"]).smethod_0(), " * ", this.string_0, " / ", this.string_1, " = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["ActiveResistance"]).smethod_0(), " Ом" };
                str = string.Concat(textArray1);
            }
            ReportParameter parameter = new ReportParameter("ActiveResistance", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
        }

        private void method_5()
        {
            string str = "";
            if (((this.dsCalc_0.tJ_CalcLossCable.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Consumption"] != DBNull.Value)) && ((this.dsCalc_0.tJ_CalcLossCable.Rows[0]["period"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadAverage"] != DBNull.Value)))
            {
                string[] textArray1 = new string[] { this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Consumption"].ToString(), " * 0.001 / ", this.dsCalc_0.tJ_CalcLossCable.Rows[0]["period"].ToString(), " = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadAverage"]).smethod_0(), " МВт" };
                str = string.Concat(textArray1);
            }
            ReportParameter parameter = new ReportParameter("LoadAverage", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
        }

        private void method_6()
        {
            string str = "";
            if ((((this.dsCalc_0.tJ_CalcLossCable.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadAverage"] != DBNull.Value)) && ((this.dsCalc_0.tJ_CalcLossCable.Rows[0]["ActiveResistance"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffPowerReactive"] != DBNull.Value))) && ((this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadPowerLoss"] != DBNull.Value)))
            {
                string[] textArray1 = new string[] { Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadAverage"]).smethod_0(), "\x00b2 * 1000 * ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["ActiveResistance"]).smethod_0(), " * (1 + ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffPowerReactive"]).smethod_0(), "\x00b2) / ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"]).smethod_0(), "\x00b2 = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadPowerLoss"]).smethod_0(), " кВт" };
                str = string.Concat(textArray1);
            }
            ReportParameter parameter = new ReportParameter("LoadPowerLoss", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
        }

        private void method_7()
        {
            string str = "";
            if ((((this.dsCalc_0.tJ_CalcLossCable.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadPowerLoss"] != DBNull.Value)) && ((this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffDifferences"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["period"] != DBNull.Value))) && ((this.dsCalc_0.tJ_CalcLossCable.Rows[0]["SquareCoeffFromGraph"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadLosses"] != DBNull.Value)))
            {
                string[] textArray1 = new string[] { Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["CoeffDifferences"]).smethod_0(), " * ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadPowerLoss"]).smethod_0(), " * ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["period"]).smethod_0(), " * ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["SquareCoeffFromGraph"]).smethod_0(), " = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadLosses"]).smethod_0(), " кВт*ч" };
                str = string.Concat(textArray1);
            }
            ReportParameter parameter = new ReportParameter("LoadLosses", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
        }

        private void method_8()
        {
            string str = "";
            string str2 = "";
            if ((this.dsCalc_0.tJ_CalcLossCable.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"] != DBNull.Value))
            {
                str = "1 км - " + Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"]).smethod_0() + " кВ = ";
                if (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["UnitYearLoss"] != DBNull.Value)
                {
                    str = str + Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["UnitYearLoss"]).smethod_0() + " кВт.ч год";
                }
                if (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["lenghtCable"] != DBNull.Value)
                {
                    str2 = Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["lenghtCable"]).smethod_0() + " км - " + Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["Voltage"]).smethod_0() + " кВ = ";
                    if (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["YearLoss"] != DBNull.Value)
                    {
                        str2 = str2 + Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["YearLoss"]).smethod_0() + " кВт.ч год";
                    }
                }
            }
            ReportParameter parameter = new ReportParameter("UnitYearLoss", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
            parameter = new ReportParameter("YearLoss", str2);
            ReportParameter[] parameterArray2 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray2);
        }

        private void method_9()
        {
            string str = "";
            if (((this.dsCalc_0.tJ_CalcLossCable.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadLosses"] != DBNull.Value)) && ((this.dsCalc_0.tJ_CalcLossCable.Rows[0]["YearLoss"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossCable.Rows[0]["SumLoadLosses"] != DBNull.Value)))
            {
                string[] textArray1 = new string[] { Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["LoadLosses"]).smethod_0(), " + ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["YearLoss"]).smethod_0(), " = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossCable.Rows[0]["SumLoadLosses"]).smethod_0(), " кВт" };
                str = string.Concat(textArray1);
            }
            ReportParameter parameter = new ReportParameter("SumLoadLoss", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
        }

        private void textBox_0_TextChanged(object sender, EventArgs e)
        {
            ReportParameter parameter = new ReportParameter("Phone", this.textBox_0.Text);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
            this.reportViewerRus_0.RefreshReport();
        }

        private void textBox_1_TextChanged(object sender, EventArgs e)
        {
            ReportParameter parameter = new ReportParameter("FIOPerformer", this.textBox_1.Text);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
            this.reportViewerRus_0.RefreshReport();
        }

        private void textBox_2_TextChanged(object sender, EventArgs e)
        {
            this.method_14();
        }

        private void textBox_3_TextChanged(object sender, EventArgs e)
        {
            this.method_13();
        }
    }
}

