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

    public class FormReportCalcLossTrans : FormBase
    {
        private BindingSource bindingSource_0;
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
        private TextBox textBox_0;
        private TextBox textBox_1;
        private TextBox textBox_2;
        private TextBox textBox_3;

        public FormReportCalcLossTrans()
        {
            this.int_2 = -1;
            this.method_15();
        }

        public FormReportCalcLossTrans(int int_3)
        {
            this.int_2 = -1;
            this.method_15();
            this.int_2 = int_3;
        }

        public FormReportCalcLossTrans(DataTable dtCalcLoss, DataTable dtCalcLossCable)
        {
            this.int_2 = -1;
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

        private void FormReportCalcLossTrans_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormReportCalcLossTrans_Load(object sender, EventArgs e)
        {
            base.LoadFormConfig(null);
            if (this.int_2 != -1)
            {
                base.SelectSqlData(this.dsCalc_0, this.dsCalc_0.tJ_CalcLoss, true, "where id = " + this.int_2.ToString());
                base.SelectSqlData(this.dsCalc_0, this.dsCalc_0.tJ_CalcLossTrans, true, "where idcalc = " + this.int_2.ToString() + " order by numTrans");
                base.SelectSqlData(this.dsCalc_0, this.dsCalc_0.tJ_CalcLossTransHH, true, "where idcalc = " + this.int_2.ToString());
                if (this.dsCalc_0.tJ_CalcLossTransHH.Rows.Count == 0)
                {
                    this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalCalcLoss.Report.ReportTrans.rdlc";
                }
            }
            if (this.dsCalc_0.tJ_CalcLoss.Rows.Count > 0)
            {
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
            string str = "";
            if ((this.dsCalc_0.tJ_CalcLossTrans.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["RatedPower"] != DBNull.Value))
            {
                str = str + Convert.ToInt32((decimal) (Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["ratedpower"]) * 1000M)).ToString() + " кВА";
            }
            ReportParameter parameter = new ReportParameter("typeCalcStr", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
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
                if ((this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbn"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnBalance"].ToString() == this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbn"].ToString()))
                {
                    if (this.dsCalc_0.tAbn.Rows.Count > 0)
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
                else if (this.dsCalc_0.tAbn.Rows.Count > 0)
                {
                    if (Convert.ToInt32(this.dsCalc_0.tAbn.Rows[0]["codeAbonent"]) > 0)
                    {
                        str = str + " д." + this.dsCalc_0.tAbn.Rows[0]["codeAbonent"].ToString();
                    }
                    base.SelectSqlData(this.dsCalc_0, this.dsCalc_0.tAbn, true, "where id = " + this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbn"].ToString());
                    if (this.dsCalc_0.tAbn.Rows.Count > 0)
                    {
                        str = str + " для " + this.dsCalc_0.tAbn.Rows[0]["name"].ToString();
                        if (Convert.ToInt32(this.dsCalc_0.tAbn.Rows[0]["codeAbonent"]) > 0)
                        {
                            str = str + " д." + this.dsCalc_0.tAbn.Rows[0]["codeAbonent"].ToString();
                        }
                    }
                    int num2 = Convert.ToInt32(this.dsCalc_0.tAbn.Rows[0]["typeAbn"]);
                    if (this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnObj"] != DBNull.Value)
                    {
                        dsCalc.vAbnObjAddressDataTable table2 = new dsCalc.vAbnObjAddressDataTable();
                        DataColumn column2 = new DataColumn("AddressFL") {
                            Expression = "street + ', д. ' + houseall + ', кв. ' + name"
                        };
                        table2.Columns.Add(column2);
                        base.SelectSqlData(table2, true, "where id = " + this.dsCalc_0.tJ_CalcLoss.Rows[0]["idAbnObj"].ToString(), false);
                        if (table2.Rows.Count > 0)
                        {
                            if (((num2 != 0xce) && (num2 != 0xfd)) && (num2 != 0x40d))
                            {
                                str = str + " (" + table2.Rows[0]["name"].ToString() + ")";
                            }
                            else
                            {
                                str = str + " (" + table2.Rows[0]["AddressFL"].ToString() + ")";
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
            if ((((this.dsCalc_0.tJ_CalcLossTrans.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["LoadPowerLoss"] != DBNull.Value)) && ((this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["CoeffDifference"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["period"] != DBNull.Value))) && ((this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["SquareCoeffFromGraph"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["LoadLosses"] != DBNull.Value)))
            {
                string[] textArray1 = new string[] { " = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["CoeffDifference"]).smethod_0(), " * ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["LoadPowerLoss"]).smethod_0(), " * ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["period"]).smethod_0(), " * ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["SquareCoeffFromGraph"]).smethod_0(), " = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["LoadLosses"]).smethod_0(), " кВт*ч" };
                str = string.Concat(textArray1);
            }
            ReportParameter parameter = new ReportParameter("LoadLosses", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
        }

        private void method_11()
        {
            string str = "";
            string str2 = "";
            if ((this.dsCalc_0.tJ_CalcLossTrans.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["CoeffLosses"] != DBNull.Value))
            {
                str2 = Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["CoeffLosses"]).smethod_0();
                if ((this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["LoadLosses"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["Consumption"] != DBNull.Value))
                {
                    string[] textArray1 = new string[] { "100% * ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["LoadLosses"]).smethod_0(), " / ", this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["Consumption"].ToString(), " = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["CoeffLosses"]).smethod_0(), "%" };
                    str = string.Concat(textArray1);
                }
            }
            ReportParameter parameter = new ReportParameter("CoeffLoss", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
            parameter = new ReportParameter("Coefficient", str2);
            ReportParameter[] parameterArray2 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray2);
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
            this.icontainer_0 = new Container();
            ReportDataSource item = new ReportDataSource();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dsCalc_0 = new dsCalc();
            this.reportViewerRus_0 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.panel_0 = new Panel();
            this.textBox_2 = new TextBox();
            this.label_3 = new Label();
            this.textBox_3 = new TextBox();
            this.label_4 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_0 = new Label();
            this.textBox_0 = new TextBox();
            this.label_1 = new Label();
            this.textBox_1 = new TextBox();
            this.label_2 = new Label();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dsCalc_0.BeginInit();
            this.panel_0.SuspendLayout();
            base.SuspendLayout();
            this.bindingSource_0.DataMember = "dtSource";
            this.bindingSource_0.DataSource = this.dsCalc_0;
            this.dsCalc_0.DataSetName = "dsCalc";
            this.dsCalc_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.reportViewerRus_0.Dock = DockStyle.Fill;
            item.Name = "dsSource";
            item.Value = this.bindingSource_0;
            this.reportViewerRus_0.LocalReport.DataSources.Add(item);
            this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalCalcLoss.Report.ReportTransHH.rdlc";
            this.reportViewerRus_0.Location = new Point(0, 0);
            this.reportViewerRus_0.Name = "reportViewer1";
            this.reportViewerRus_0.Size = new Size(0x32d, 440);
            this.reportViewerRus_0.TabIndex = 0;
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
            this.textBox_2.Location = new Point(0x11b, 0x13);
            this.textBox_2.Name = "txtFIOBoss";
            this.textBox_2.Size = new Size(0xae, 20);
            this.textBox_2.TabIndex = 9;
            this.textBox_2.Text = "Исаева Н.В.";
            this.textBox_2.TextChanged += new EventHandler(this.textBox_2_TextChanged);
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(280, 3);
            this.label_3.Name = "label5";
            this.label_3.Size = new Size(0x22, 13);
            this.label_3.TabIndex = 8;
            this.label_3.Text = "ФИО";
            this.textBox_3.Location = new Point(12, 0x13);
            this.textBox_3.Name = "txtTitleJob";
            this.textBox_3.Size = new Size(0xfb, 20);
            this.textBox_3.TabIndex = 7;
            this.textBox_3.Text = "Начальник СКиУЭЭ";
            this.textBox_3.TextChanged += new EventHandler(this.textBox_3_TextChanged);
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(12, 3);
            this.label_4.Name = "label4";
            this.label_4.Size = new Size(0x41, 13);
            this.label_4.TabIndex = 6;
            this.label_4.Text = "Должность";
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
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x32d, 0x217);
            base.Controls.Add(this.reportViewerRus_0);
            base.Controls.Add(this.panel_0);
            base.Name = "FormReportCalcLossTrans";
            this.Text = "Печать расчета потерь";
            base.FormClosing += new FormClosingEventHandler(this.FormReportCalcLossTrans_FormClosing);
            base.Load += new EventHandler(this.FormReportCalcLossTrans_Load);
            ((ISupportInitialize) this.bindingSource_0).EndInit();
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
            if (this.dsCalc_0.tJ_CalcLossTrans.Rows.Count > 0)
            {
                object[] values = new object[] { "Номинальная мощность трансформатора", "Sном, МВА", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["RatedPower"]).smethod_0() };
                table.Rows.Add(values);
                object[] objArray2 = new object[] { "Количество трансформаторов", "n, шт", this.dsCalc_0.tJ_CalcLossTrans.Rows.Count.ToString() };
                table.Rows.Add(objArray2);
                object[] objArray3 = new object[] { "Потери мощности холостого хода", "∆Pхх, кВт", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["NoLoadLoss"]).smethod_0() };
                table.Rows.Add(objArray3);
                object[] objArray4 = new object[] { "Потери мощности короткого замыкания", "∆Pкз, кВт", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["ShortCircuitLoss"]).smethod_0() };
                table.Rows.Add(objArray4);
                object[] objArray5 = new object[] { "Годовое потребление активной электроэнергии за базовый период по счетчику", "Wт, кВт*ч", this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["Consumption"].ToString() };
                table.Rows.Add(objArray5);
                object[] objArray6 = new object[] { "Номинальное напряжение высшей обмотки трансформатора", "Uном, кВ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["RatedVoltage"]).smethod_0() };
                table.Rows.Add(objArray6);
                object[] objArray7 = new object[] { "Среднее напряжение на высшей стороне трансформатора за базовый период", "Uср, кВ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["MiddleVoltage"]).smethod_0() };
                table.Rows.Add(objArray7);
                object[] objArray8 = new object[] { "Время работы трансформатора", "Т, час", this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["period"].ToString() };
                table.Rows.Add(objArray8);
                object[] objArray9 = new object[] { "Коэффициент реактивной мощности", "tg φ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["CoeffPowerReactive"]).smethod_0() };
                table.Rows.Add(objArray9);
                object[] objArray10 = new object[] { "Квадрат коэффициента формы графика за базовый период", "kφ\x00b2, о.е.", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["SquareCoeffFromGraph"]).smethod_0() };
                table.Rows.Add(objArray10);
                object[] objArray11 = new object[] { "Коэффициент учитывающий различие конфигураций графиков активной и реактивной нагрузки", "kк, о.е.", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["CoeffDifference"]).smethod_0() };
                table.Rows.Add(objArray11);
            }
            ReportDataSource item = new ReportDataSource {
                Name = "dsSource",
                Value = table
            };
            this.reportViewerRus_0.LocalReport.DataSources.Clear();
            this.reportViewerRus_0.LocalReport.DataSources.Add(item);
        }

        private void method_4()
        {
            string str = "";
            if ((((this.dsCalc_0.tJ_CalcLossTrans.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["NoLoadLoss"] != DBNull.Value)) && ((this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["Period"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["RatedVoltage"] != DBNull.Value))) && ((this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["MiddleVoltage"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["LossElectrHH"] != DBNull.Value)))
            {
                string[] textArray1 = new string[] { " = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["NoLoadLoss"]).smethod_0(), " * ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["Period"]).smethod_0(), " * (", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["MiddleVoltage"]).smethod_0(), " / ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["RatedVoltage"]).smethod_0(), ")\x00b2 = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["LossElectrHH"]).smethod_0(), " кВт*ч" };
                str = string.Concat(textArray1);
            }
            ReportParameter parameter = new ReportParameter("LossElectrHH", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
        }

        private void method_5()
        {
            if (this.dsCalc_0.tJ_CalcLossTrans.Rows.Count > 0)
            {
                dsCalc.tJ_CalcLossTransHHDataTable table = new dsCalc.tJ_CalcLossTransHHDataTable();
                base.SelectSqlData(table, true, "where idTRans = " + this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["id"].ToString(), false);
                ReportDataSource item = new ReportDataSource {
                    Name = "dsTransHH",
                    Value = table
                };
                this.reportViewerRus_0.LocalReport.DataSources.Add(item);
            }
        }

        private void method_6()
        {
            if (this.dsCalc_0.tJ_CalcLossTrans.Rows.Count > 0)
            {
                if (this.dsCalc_0.tJ_CalcLossTransHH.Rows.Count > 2)
                {
                    string str = "Т.к. в трансформаторной подстанции находятся " + ((this.dsCalc_0.tJ_CalcLossTransHH.Rows.Count - 1)).ToString() + " силовых трансформатора, потери электроэнергии холостого хода учитываются в каждом. Следовательно, суммарные потери холостого хода силовых трансформаторов составят:";
                    ReportParameter parameter = new ReportParameter("TransSumHH", str);
                    ReportParameter[] parameters = new ReportParameter[] { parameter };
                    this.reportViewerRus_0.LocalReport.SetParameters(parameters);
                }
                dsCalc.tJ_CalcLossTransHHDataTable table = new dsCalc.tJ_CalcLossTransHHDataTable();
                base.SelectSqlData(table, true, "where idCalc = " + this.int_2.ToString() + " and idTRans is null", false);
                ReportDataSource item = new ReportDataSource {
                    Name = "dsTransSumHH",
                    Value = table
                };
                this.reportViewerRus_0.LocalReport.DataSources.Add(item);
            }
        }

        private void method_7()
        {
            string str = "";
            if ((((this.dsCalc_0.tJ_CalcLossTrans.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["ShortCircuitLoss"] != DBNull.Value)) && ((this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["RatedVoltage"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["RatedPower"] != DBNull.Value))) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["ActiveResistance"] != DBNull.Value))
            {
                string[] textArray1 = new string[] { " = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["ShortCircuitLoss"]).smethod_0(), " * 0.001 * ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["RatedVoltage"]).smethod_0(), "\x00b2 / ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["RatedPower"]).smethod_0(), "\x00b2 = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["ActiveResistance"]).smethod_0(), " Ом/фазу" };
                str = string.Concat(textArray1);
            }
            ReportParameter parameter = new ReportParameter("ActiveResistance", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
        }

        private void method_8()
        {
            string str = "";
            if (((this.dsCalc_0.tJ_CalcLossTrans.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["Consumption"] != DBNull.Value)) && ((this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["period"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["LoadAverage"] != DBNull.Value)))
            {
                string[] textArray1 = new string[] { " = ", this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["Consumption"].ToString(), " * 0.001 / ", this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["period"].ToString(), " = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["LoadAverage"]).smethod_0(), " МВт" };
                str = string.Concat(textArray1);
            }
            ReportParameter parameter = new ReportParameter("LoadAverage", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
        }

        private void method_9()
        {
            string str = "";
            if ((((this.dsCalc_0.tJ_CalcLossTrans.Rows.Count > 0) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["LoadAverage"] != DBNull.Value)) && ((this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["ActiveResistance"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["CoeffPowerReactive"] != DBNull.Value))) && ((this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["MiddleVoltage"] != DBNull.Value) && (this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["LoadPowerLoss"] != DBNull.Value)))
            {
                string[] textArray1 = new string[] { " = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["LoadAverage"]).smethod_0(), "\x00b2 * 1000 * ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["ActiveResistance"]).smethod_0(), " * (1 + ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["CoeffPowerReactive"]).smethod_0(), "\x00b2) / ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["MiddleVoltage"]).smethod_0(), "\x00b2 = ", Convert.ToDecimal(this.dsCalc_0.tJ_CalcLossTrans.Rows[0]["LoadPowerLoss"]).smethod_0(), " кВт" };
                str = string.Concat(textArray1);
            }
            ReportParameter parameter = new ReportParameter("LoadPowerLoss", str);
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

