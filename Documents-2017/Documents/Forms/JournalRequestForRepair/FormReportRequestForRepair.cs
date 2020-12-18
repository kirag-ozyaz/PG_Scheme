using ControlsLbr.ReportViewerRus;
using Documents.DataSets;
using Documents.Properties;
using FormLbr;
using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
namespace Documents.JournalRequestForRepair
{
    /// <summary>
    /// Отчет заявок на ремонт оборудования
    /// </summary>

    internal class FormReportRequestForRepair : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private bool bool_0;
        private Button button_0;
        private Button button_1;
        private CheckBox checkBox_0;
        private CheckBox checkBox_1;
        private CheckedListBox checkedListBox_0;
        private ComboBox comboBox_0;
        private DataSetGES dataSetGES_0;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private IContainer icontainer_0;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Panel panel_0;
        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus_0;
        private string string_0;
        private string string_1;
        private string string_2;
        private string string_3;
        private string string_4;
        private string string_5;
        private string string_6;
        private TextBox textBox_0;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;

        internal FormReportRequestForRepair()
        {
            this.string_0 = "Главный инженер";
            this.string_1 = "МУП \"УльГЭС\"";
            this.string_2 = "Л.Н.Демченко";
            this.string_3 = "Начальник ОДС";
            this.string_4 = "Л.Г. Белавина";
            this.string_5 = "Зам.начальника ОДС";
            this.string_6 = "А.Б. Манузин";
            this.method_1();
            this.dateTimePicker_1.Value = this.dateTimePicker_0.Value = DateTime.Now;
        }

        internal FormReportRequestForRepair(bool bool_1 = false)
        {
            this.string_0 = "Главный инженер";
            this.string_1 = "МУП \"УльГЭС\"";
            this.string_2 = "Л.Н.Демченко";
            this.string_3 = "Начальник ОДС";
            this.string_4 = "Л.Г. Белавина";
            this.string_5 = "Зам.начальника ОДС";
            this.string_6 = "А.Б. Манузин";
            this.method_1();
            this.dateTimePicker_1.Value = this.dateTimePicker_0.Value = DateTime.Now;
            this.bool_0 = bool_1;
            if (bool_1)
            {
                this.Text = "Отчет аварийных заявок на ремонт оборудования";
            }
        }

        protected override void ApplyConfig(XmlDocument xmlDocument_0)
        {
            XmlNode node = xmlDocument_0.SelectSingleNode(base.Name);
            if (node != null)
            {
                XmlAttribute attribute = node.Attributes["appoveTitle"];
                if (attribute != null)
                {
                    this.string_0 = attribute.Value;
                }
                attribute = node.Attributes["appoveOrg"];
                if (attribute != null)
                {
                    this.string_1 = attribute.Value;
                }
                attribute = node.Attributes["appoveFIO"];
                if (attribute != null)
                {
                    this.string_2 = attribute.Value;
                }
                attribute = node.Attributes["signatureTitle1"];
                if (attribute != null)
                {
                    this.string_3 = attribute.Value;
                }
                attribute = node.Attributes["signatureFIO1"];
                if (attribute != null)
                {
                    this.string_4 = attribute.Value;
                }
                attribute = node.Attributes["signatureTitle2"];
                if (attribute != null)
                {
                    this.string_5 = attribute.Value;
                }
                attribute = node.Attributes["signatureFIO2"];
                if (attribute != null)
                {
                    this.string_6 = attribute.Value;
                }
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (this.checkBox_0.Checked)
            {
                if (this.dateTimePicker_1.Value.Date == this.dateTimePicker_0.Value.Date)
                {
                    this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalRequestForRepair.Reports.ReportrequestForRepairFull.rdlc";
                }
                else
                {
                    this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalRequestForRepair.Reports.ReportrequestForRepairFullPeriod.rdlc";
                }
            }
            else if (this.dateTimePicker_1.Value.Date == this.dateTimePicker_0.Value.Date)
            {
                this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalRequestForRepair.Reports.ReportrequestForRepairNoAddress.rdlc";
            }
            else
            {
                this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalRequestForRepair.Reports.ReportrequestForRepairNoAddressPeriod.rdlc";
            }
            ReportParameter parameter = new ReportParameter("DateBegin", this.dateTimePicker_1.Value.Date.ToString());
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
            parameter = new ReportParameter("DateEnd", this.dateTimePicker_0.Value.Date.ToString());
            ReportParameter[] parameterArray2 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray2);
            bool flag = !this.checkBox_1.Checked;
            parameter = new ReportParameter("ShowAgreed", flag.ToString());
            ReportParameter[] parameterArray3 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray3);
            parameter = new ReportParameter("AppoveTitle", this.string_0);
            ReportParameter[] parameterArray4 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray4);
            parameter = new ReportParameter("AppoveOrg", this.string_1);
            ReportParameter[] parameterArray5 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray5);
            parameter = new ReportParameter("AppoveFIO", this.string_2);
            ReportParameter[] parameterArray6 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray6);
            parameter = new ReportParameter("SignatureTitle1", string.IsNullOrEmpty(this.string_3) ? null : this.string_3);
            ReportParameter[] parameterArray7 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray7);
            parameter = new ReportParameter("SignatureFIO1", string.IsNullOrEmpty(this.string_4) ? null : this.string_4);
            ReportParameter[] parameterArray8 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray8);
            parameter = new ReportParameter("SignatureTitle2", string.IsNullOrEmpty(this.string_5) ? null : this.string_5);
            ReportParameter[] parameterArray9 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray9);
            parameter = new ReportParameter("SignatureFIO2", string.IsNullOrEmpty(this.string_6) ? null : this.string_6);
            ReportParameter[] parameterArray10 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray10);
            parameter = new ReportParameter("isCrash", this.bool_0.ToString());
            ReportParameter[] parameterArray11 = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray11);
            string str = "'" + this.dateTimePicker_1.Value.Date.ToString("yyyyMMdd") + "'";
            string str2 = "'" + this.dateTimePicker_0.Value.Date.ToString("yyyyMMdd") + " 23:59:59'";
            string[] textArray1 = new string[] { " ((dateTripBeg >= ", str, " and datetripBEg <= ", str2, ") or (datetripend >= ", str, " and datetripEnd <= ", str2, ") or (datetripBeg <= ", str, " and dateTRipEnd >= ", str2, ")) " };
            string str3 = string.Concat(textArray1);
            if (this.checkedListBox_0.CheckedItems.Count <= 0)
            {
                this.dataSetGES_0.vJ_RequestForRepairDaily.Clear();
            }
            else
            {
                string str4 = "";
                foreach (object obj2 in this.checkedListBox_0.CheckedItems)
                {
                    SRForRepair struct2 = (SRForRepair)obj2;
                    str4 = str4 + struct2.Id.ToString() + ",";
                }
                str4 = " (idSR in (" + str4.Remove(str4.Length - 1) + ")) ";
                if (this.comboBox_0.SelectedValue == null)
                {
                    this.dataSetGES_0.vJ_RequestForRepairDaily.Clear();
                }
                else
                {
                    string str5 = " (idDivision = " + this.comboBox_0.SelectedValue.ToString() + ") ";
                    string str6 = "";
                    if (!string.IsNullOrEmpty(this.textBox_0.Text))
                    {
                        str6 = " and (schmObj like '%" + this.textBox_0.Text + "%') ";
                    }
                    string str7 = "";
                    if (this.checkBox_1.Checked)
                    {
                        str7 = " and (Agreed = 1) ";
                    }
                    string str8 = "";
                    if (this.bool_0)
                    {
                        str8 = " and (Crash = 1) ";
                    }
                    else
                    {
                        str8 = " and (Crash = 0 or Crash is null) ";
                    }
                    base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_RequestForRepairDaily, true, " where " + str3 + " and " + str4 + " and " + str5 + str6 + str7 + str8 + " and deleted = 0 order by sr, id, datetripBeg");
                    this.method_0(this.dateTimePicker_1.Value.Date, this.dateTimePicker_0.Value.Date);
                }
            }
            this.reportViewerRus_0.RefreshReport();
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document1 = new XmlDocument();
            XmlNode newChild = document1.CreateXmlDeclaration("1.0", "UTF-8", null);
            document1.AppendChild(newChild);
            XmlNode node2 = document1.CreateElement(base.Name);
            document1.AppendChild(node2);
            XmlAttribute node = document1.CreateAttribute("appoveTitle");
            node.Value = this.string_0;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("appoveOrg");
            node.Value = this.string_1;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("appoveFIO");
            node.Value = this.string_2;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("signatureTitle1");
            node.Value = this.string_3;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("signatureFIO1");
            node.Value = this.string_4;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("signatureTitle2");
            node.Value = this.string_5;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("signatureFIO2");
            node.Value = this.string_6;
            node2.Attributes.Append(node);
            return document1;
        }

        private void dateTimePicker_0_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker_1.MaxDate = this.dateTimePicker_0.Value;
        }

        private void dateTimePicker_1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker_0.MinDate = this.dateTimePicker_1.Value;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form44_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void Form44_Load(object sender, EventArgs e)
        {
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tR_Classifier, true, " where ParentKey = ';NetworkAreas;' and deleted = 0 and isGroup = 0 order by name ");
            foreach (DataRow row in this.dataSetGES_0.tR_Classifier)
            {
                SRForRepair item = new SRForRepair(Convert.ToInt32(row["id"]), row["name"].ToString());
                this.checkedListBox_0.Items.Add(item, true);
            }
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tR_Classifier, true, " where ParentKey = ';Other;DivisionRequestRepair;' and isgroup = 0 and deleted = 0 order by name");
            this.comboBox_0.DataSource = this.dataSetGES_0.tR_Classifier;
            this.comboBox_0.DisplayMember = "name";
            this.comboBox_0.ValueMember = "ID";
            this.comboBox_0.SelectedValue = 920;
            base.LoadFormConfig(null);
        }

        private void method_0(DateTime dateTime_0, DateTime dateTime_1)
        {
            bool flag = dateTime_0 == dateTime_1;
            for (int i = 0; i < this.dataSetGES_0.vJ_RequestForRepairDaily.Rows.Count; i++)
            {
                DataRow row = this.dataSetGES_0.vJ_RequestForRepairDaily.Rows[i];
                string str = "";
                string str2 = "";
                string str3 = "";
                string str4 = "";
                if (!flag)
                {
                    str = Convert.ToDateTime(row["DateTripBeg"]).ToShortDateString();
                    str2 = Convert.ToDateTime(row["DateTripBeg"]).ToShortTimeString();
                    str3 = Convert.ToDateTime(row["DateTripEnd"]).ToShortDateString();
                    str4 = Convert.ToDateTime(row["DateTripEnd"]).ToShortTimeString();
                }
                else
                {
                    if (dateTime_0 > Convert.ToDateTime(row["DateTripBeg"]))
                    {
                        str2 = "0:00";
                    }
                    else
                    {
                        str2 = Convert.ToDateTime(row["DateTripBeg"]).ToShortTimeString();
                    }
                    if (dateTime_1.AddDays(1.0).AddMinutes(-1.0) < Convert.ToDateTime(row["DateTripEnd"]))
                    {
                        str2 = str2 + " - 23:59";
                    }
                    else
                    {
                        str2 = str2 + " - " + Convert.ToDateTime(row["DateTripEnd"]).ToShortTimeString();
                    }
                }
                int num2 = 1;
                while ((i + num2) < this.dataSetGES_0.vJ_RequestForRepairDaily.Rows.Count)
                {
                    DataRow row2 = this.dataSetGES_0.vJ_RequestForRepairDaily.Rows[i + num2];
                    if (Convert.ToInt32(row["id"]) != Convert.ToInt32(row2["id"]))
                    {
                        break;
                    }
                    if (!flag)
                    {
                        str = str + "\n" + Convert.ToDateTime(row2["DateTripBeg"]).ToShortDateString();
                        str2 = str2 + "\n" + Convert.ToDateTime(row2["DateTripBeg"]).ToShortTimeString();
                        str3 = str3 + "\n" + Convert.ToDateTime(row2["DateTripEnd"]).ToShortDateString();
                        str4 = str4 + "\n" + Convert.ToDateTime(row2["DateTripEnd"]).ToShortTimeString();
                    }
                    else
                    {
                        if (dateTime_0 > Convert.ToDateTime(row2["DateTripBeg"]))
                        {
                            str2 = str2 + "\n0:00";
                        }
                        else
                        {
                            str2 = str2 + "\n" + Convert.ToDateTime(row2["DateTripBeg"]).ToShortTimeString();
                        }
                        if (dateTime_1.AddDays(1.0).AddMinutes(-1.0) < Convert.ToDateTime(row2["DateTripEnd"]))
                        {
                            str2 = str2 + " - 23:59";
                        }
                        else
                        {
                            str2 = str2 + " - " + Convert.ToDateTime(row2["DateTripEnd"]).ToShortTimeString();
                        }
                    }
                    this.dataSetGES_0.vJ_RequestForRepairDaily.Rows.Remove(row2);
                }
                row["dateBeg"] = str;
                row["dateEnd"] = str3;
                row["timeBeg"] = str2;
                row["timeEnd"] = str4;
            }
        }

        private void method_1()
        {
            this.icontainer_0 = new Container();
            ReportDataSource item = new ReportDataSource();
            ReportDataSource source2 = new ReportDataSource();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormReportRequestForRepair));
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetGES_0 = new DataSetGES();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.reportViewerRus_0 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.panel_0 = new Panel();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.comboBox_0 = new ComboBox();
            this.label_5 = new Label();
            this.checkedListBox_0 = new CheckedListBox();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.textBox_0 = new TextBox();
            this.label_0 = new Label();
            this.checkBox_0 = new CheckBox();
            this.checkBox_1 = new CheckBox();
            this.label_1 = new Label();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_2 = new Label();
            this.dateTimePicker_1 = new DateTimePicker();
            this.label_3 = new Label();
            this.label_4 = new Label();
            ((ISupportInitialize)this.bindingSource_0).BeginInit();
            this.dataSetGES_0.BeginInit();
            ((ISupportInitialize)this.bindingSource_1).BeginInit();
            this.panel_0.SuspendLayout();
            this.toolStrip_0.SuspendLayout();
            base.SuspendLayout();
            this.bindingSource_0.DataMember = "vJ_RequestForRepair";
            this.bindingSource_0.DataSource = this.dataSetGES_0;
            this.dataSetGES_0.DataSetName = "DataSetGES";
            this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.bindingSource_1.DataMember = "vJ_RequestForRepairDaily";
            this.bindingSource_1.DataSource = this.dataSetGES_0;
            this.reportViewerRus_0.Dock = DockStyle.Fill;
            item.Name = "DataSetGES";
            item.Value = this.bindingSource_0;
            source2.Name = "DataSetDaily";
            source2.Value = this.bindingSource_1;
            this.reportViewerRus_0.LocalReport.DataSources.Add(item);
            this.reportViewerRus_0.LocalReport.DataSources.Add(source2);
            this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalRequestForRepair.Reports.ReportrequestForRepairFull.rdlc";
            this.reportViewerRus_0.Location = new Point(0xd3, 0);
            this.reportViewerRus_0.Name = "reportViewerRus1";
            this.reportViewerRus_0.Size = new Size(0x1e5, 0x1ee);
            this.reportViewerRus_0.TabIndex = 0;
            this.panel_0.Controls.Add(this.toolStrip_0);
            this.panel_0.Controls.Add(this.comboBox_0);
            this.panel_0.Controls.Add(this.label_5);
            this.panel_0.Controls.Add(this.checkedListBox_0);
            this.panel_0.Controls.Add(this.button_0);
            this.panel_0.Controls.Add(this.button_1);
            this.panel_0.Controls.Add(this.textBox_0);
            this.panel_0.Controls.Add(this.label_0);
            this.panel_0.Controls.Add(this.checkBox_0);
            this.panel_0.Controls.Add(this.checkBox_1);
            this.panel_0.Controls.Add(this.label_1);
            this.panel_0.Controls.Add(this.dateTimePicker_0);
            this.panel_0.Controls.Add(this.label_2);
            this.panel_0.Controls.Add(this.dateTimePicker_1);
            this.panel_0.Controls.Add(this.label_3);
            this.panel_0.Controls.Add(this.label_4);
            this.panel_0.Dock = DockStyle.Left;
            this.panel_0.Location = new Point(0, 0);
            this.panel_0.Name = "panel1";
            this.panel_0.Size = new Size(0xd3, 0x1ee);
            this.panel_0.TabIndex = 1;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStrip";
            this.toolStrip_0.Size = new Size(0xd3, 0x19);
            this.toolStrip_0.TabIndex = 0x10;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.Setting;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolBtnSettings";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Настройки";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(9, 0xed);
            this.comboBox_0.Name = "cmdDivision";
            this.comboBox_0.Size = new Size(0xc7, 0x15);
            this.comboBox_0.TabIndex = 15;
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(6, 0xdd);
            this.label_5.Name = "label6";
            this.label_5.Size = new Size(0x57, 13);
            this.label_5.TabIndex = 14;
            this.label_5.Text = "Подразделения";
            this.checkedListBox_0.CheckOnClick = true;
            this.checkedListBox_0.FormattingEnabled = true;
            this.checkedListBox_0.Location = new Point(9, 0x7c);
            this.checkedListBox_0.Name = "checkedListBoxSR";
            this.checkedListBox_0.Size = new Size(0xc7, 0x5e);
            this.checkedListBox_0.TabIndex = 13;
            this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_0.Location = new Point(0x72, 0x1d2);
            this.button_0.Name = "buttonClose";
            this.button_0.Size = new Size(0x5e, 0x19);
            this.button_0.TabIndex = 12;
            this.button_0.Text = "Закрыть";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.button_1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_1.Location = new Point(9, 0x1d2);
            this.button_1.Name = "buttonAplly";
            this.button_1.Size = new Size(0x60, 0x19);
            this.button_1.TabIndex = 11;
            this.button_1.Text = "Сформировать";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            this.textBox_0.Location = new Point(9, 0x143);
            this.textBox_0.Name = "txtObject";
            this.textBox_0.Size = new Size(0xc7, 20);
            this.textBox_0.TabIndex = 10;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(6, 0x133);
            this.label_0.Name = "label5";
            this.label_0.Size = new Size(0x70, 13);
            this.label_0.TabIndex = 9;
            this.label_0.Text = "Отключаемы объект";
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Location = new Point(9, 0x11f);
            this.checkBox_0.Name = "checkBoxShowAdresses";
            this.checkBox_0.Size = new Size(0x73, 0x11);
            this.checkBox_0.TabIndex = 8;
            this.checkBox_0.Text = "Выводить адреса";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_1.AutoSize = true;
            this.checkBox_1.Location = new Point(9, 0x108);
            this.checkBox_1.Name = "checkBoxIsAgreed";
            this.checkBox_1.Size = new Size(0x9b, 0x11);
            this.checkBox_1.TabIndex = 7;
            this.checkBox_1.Text = "Учитывать согласование";
            this.checkBox_1.UseVisualStyleBackColor = true;
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(6, 0x6c);
            this.label_1.Name = "label4";
            this.label_1.Size = new Size(0x5c, 13);
            this.label_1.TabIndex = 5;
            this.label_1.Text = "Сетевые районы";
            this.dateTimePicker_0.Location = new Point(0x1f, 0x4c);
            this.dateTimePicker_0.Name = "dateTimePickerEnd";
            this.dateTimePicker_0.Size = new Size(0xb1, 20);
            this.dateTimePicker_0.TabIndex = 4;
            this.dateTimePicker_0.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(6, 0x52);
            this.label_2.Name = "label3";
            this.label_2.Size = new Size(0x13, 13);
            this.label_2.TabIndex = 3;
            this.label_2.Text = "по";
            this.dateTimePicker_1.Location = new Point(0x1f, 50);
            this.dateTimePicker_1.Name = "dateTimePickerBeg";
            this.dateTimePicker_1.Size = new Size(0xb1, 20);
            this.dateTimePicker_1.TabIndex = 2;
            this.dateTimePicker_1.ValueChanged += new EventHandler(this.dateTimePicker_1_ValueChanged);
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(12, 0x38);
            this.label_3.Name = "label2";
            this.label_3.Size = new Size(13, 13);
            this.label_3.TabIndex = 1;
            this.label_3.Text = "с";
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(12, 0x20);
            this.label_4.Name = "label1";
            this.label_4.Size = new Size(0x2d, 13);
            this.label_4.TabIndex = 0;
            this.label_4.Text = "Период";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x2b8, 0x1ee);
            base.Controls.Add(this.reportViewerRus_0);
            base.Controls.Add(this.panel_0);
            base.Icon = (Icon)manager.GetObject("$this.Icon");
            this.MinimumSize = new Size(500, 400);
            base.Name = "FormReportRequestForRepair";
            this.Text = "Отчет заявок на ремонт оборудования";
            base.FormClosed += new FormClosedEventHandler(this.Form44_FormClosed);
            base.Load += new EventHandler(this.Form44_Load);
            ((ISupportInitialize)this.bindingSource_0).EndInit();
            this.dataSetGES_0.EndInit();
            ((ISupportInitialize)this.bindingSource_1).EndInit();
            this.panel_0.ResumeLayout(false);
            this.panel_0.PerformLayout();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            base.ResumeLayout(false);
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            FormReportReguestForRepairSettings settings = new FormReportReguestForRepairSettings();
            settings.method_1(this.string_0);
            settings.method_3(this.string_1);
            settings.method_5(this.string_2);
            settings.method_7(this.string_3);
            settings.method_9(this.string_4);
            settings.method_11(this.string_5);
            settings.method_13(this.string_6);
            if (settings.ShowDialog() == DialogResult.OK)
            {
                this.string_0 = settings.method_0();
                this.string_1 = settings.method_2();
                this.string_2 = settings.method_4();
                this.string_3 = settings.method_6();
                this.string_4 = settings.method_8();
                this.string_5 = settings.method_10();
                this.string_6 = settings.method_12();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct SRForRepair
        {
            public int Id;
            public string Name;
            public SRForRepair(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }

            public override string ToString()
            {
                return this.Name;
            }
        }
    }

}