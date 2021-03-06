﻿using ControlsLbr.ReportViewerRus;
//using Documents.DataSets;
//using Documents.Properties;
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
        private BindingSource bsRequestForRepair;
        private BindingSource bsRequestForRepairDaily;
        private bool isCrash;
        private Button buttonClose;
        private Button buttonAplly;
        private CheckBox checkBoxShowAdresses;
        private CheckBox checkBoxIsAgreed;
        private CheckedListBox checkedListBoxSR;
        private ComboBox cmdDivision;
        private RequestForRepair.DataSets.DataSetN dsGES;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerBeg;
        private IContainer components = null;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Panel panel1;
        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus1;
        private string AppoveTitle= "Главный инженер";
        private string AppoveOrg = "МУП \"УльГЭС\"";
        private string AppoveFIO= "Л.Н.Демченко";
        private string SignatureTitle1 = "Начальник ОДС";
        private string SignatureFIO1 = "Л.Г. Белавина";
        private string SignatureTitle2 = "Зам.начальника ОДС";
        private string SignatureFIO2 = "А.Б. Манузин";
        private TextBox txtObject;
        private ToolStrip toolStrip;
        private ToolStripButton toolBtnSettings;

        internal FormReportRequestForRepair()
        {
            this.InitializeComponent();
            this.dateTimePickerBeg.Value = this.dateTimePickerEnd.Value = DateTime.Now;
        }

        internal FormReportRequestForRepair(bool IsCrash = false)
        {
            this.InitializeComponent();
            this.dateTimePickerBeg.Value = this.dateTimePickerEnd.Value = DateTime.Now;
            this.isCrash = IsCrash;
            if (IsCrash)
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
                    this.AppoveTitle = attribute.Value;
                }
                attribute = node.Attributes["appoveOrg"];
                if (attribute != null)
                {
                    this.AppoveOrg = attribute.Value;
                }
                attribute = node.Attributes["appoveFIO"];
                if (attribute != null)
                {
                    this.AppoveFIO = attribute.Value;
                }
                attribute = node.Attributes["signatureTitle1"];
                if (attribute != null)
                {
                    this.SignatureTitle1 = attribute.Value;
                }
                attribute = node.Attributes["signatureFIO1"];
                if (attribute != null)
                {
                    this.SignatureFIO1 = attribute.Value;
                }
                attribute = node.Attributes["signatureTitle2"];
                if (attribute != null)
                {
                    this.SignatureTitle2 = attribute.Value;
                }
                attribute = node.Attributes["signatureFIO2"];
                if (attribute != null)
                {
                    this.SignatureFIO2 = attribute.Value;
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void buttonAplly_Click(object sender, EventArgs e)
        {
            if (this.checkBoxShowAdresses.Checked)
            {
                if (this.dateTimePickerBeg.Value.Date == this.dateTimePickerEnd.Value.Date)
                {
                    this.reportViewerRus1.LocalReport.ReportEmbeddedResource = 
                        "RequestForRepair.Documents.RDLC.ReportrequestForRepairFull.rdlc";
                }
                else
                {
                    this.reportViewerRus1.LocalReport.ReportEmbeddedResource = 
                    "RequestForRepair.Documents.RDLC.ReportrequestForRepairFullPeriod.rdlc";
                }
            }
            else if (this.dateTimePickerBeg.Value.Date == this.dateTimePickerEnd.Value.Date)
            {
                this.reportViewerRus1.LocalReport.ReportEmbeddedResource = 
                "RequestForRepair.Documents.RDLC.ReportrequestForRepairNoAddress.rdlc";
            }
            else
            {
                this.reportViewerRus1.LocalReport.ReportEmbeddedResource = 
                "RequestForRepair.Documents.RDLC.ReportrequestForRepairNoAddressPeriod.rdlc";
            }
            ReportParameter parameter = new ReportParameter("DateBegin", this.dateTimePickerBeg.Value.Date.ToString());
            this.reportViewerRus1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { parameter });


            parameter = new ReportParameter("DateEnd", this.dateTimePickerEnd.Value.Date.ToString());
            ReportParameter[] parameterArray2 = new ReportParameter[] { parameter };
            this.reportViewerRus1.LocalReport.SetParameters(parameterArray2);

            bool flag = !this.checkBoxIsAgreed.Checked;
            parameter = new ReportParameter("ShowAgreed", flag.ToString());
            ReportParameter[] parameterArray3 = new ReportParameter[] { parameter };
            this.reportViewerRus1.LocalReport.SetParameters(parameterArray3);

            parameter = new ReportParameter("AppoveTitle", this.AppoveTitle);
            ReportParameter[] parameterArray4 = new ReportParameter[] { parameter };
            this.reportViewerRus1.LocalReport.SetParameters(parameterArray4);

            parameter = new ReportParameter("AppoveOrg", this.AppoveOrg);
            ReportParameter[] parameterArray5 = new ReportParameter[] { parameter };
            this.reportViewerRus1.LocalReport.SetParameters(parameterArray5);

            parameter = new ReportParameter("AppoveFIO", this.AppoveFIO);
            ReportParameter[] parameterArray6 = new ReportParameter[] { parameter };
            this.reportViewerRus1.LocalReport.SetParameters(parameterArray6);

            parameter = new ReportParameter("SignatureTitle1", string.IsNullOrEmpty(this.SignatureTitle1) ? null : this.SignatureTitle1);
            ReportParameter[] parameterArray7 = new ReportParameter[] { parameter };
            this.reportViewerRus1.LocalReport.SetParameters(parameterArray7);

            parameter = new ReportParameter("SignatureFIO1", string.IsNullOrEmpty(this.SignatureFIO1) ? null : this.SignatureFIO1);
            ReportParameter[] parameterArray8 = new ReportParameter[] { parameter };
            this.reportViewerRus1.LocalReport.SetParameters(parameterArray8);

            parameter = new ReportParameter("SignatureTitle2", string.IsNullOrEmpty(this.SignatureTitle2) ? null : this.SignatureTitle2);
            ReportParameter[] parameterArray9 = new ReportParameter[] { parameter };
            this.reportViewerRus1.LocalReport.SetParameters(parameterArray9);

            parameter = new ReportParameter("SignatureFIO2", string.IsNullOrEmpty(this.SignatureFIO2) ? null : this.SignatureFIO2);
            ReportParameter[] parameterArray10 = new ReportParameter[] { parameter };
            this.reportViewerRus1.LocalReport.SetParameters(parameterArray10);

            parameter = new ReportParameter("isCrash", this.isCrash.ToString());
            ReportParameter[] parameterArray11 = new ReportParameter[] { parameter };
            this.reportViewerRus1.LocalReport.SetParameters(parameterArray11);

            string str = "'" + this.dateTimePickerBeg.Value.Date.ToString("yyyyMMdd") + "'";
            string str2 = "'" + this.dateTimePickerEnd.Value.Date.ToString("yyyyMMdd") + " 23:59:59'";
            string[] textArray1 = new string[] { " ((dateTripBeg >= ", str, " and datetripBEg <= ", str2, ") or (datetripend >= ", str, " and datetripEnd <= ", str2, ") or (datetripBeg <= ", str, " and dateTRipEnd >= ", str2, ")) " };
            string str3 = string.Concat(textArray1);
            if (this.checkedListBoxSR.CheckedItems.Count <= 0)
            {
                this.dsGES.vJ_RequestForRepairDaily.Clear();
            }
            else
            {
                string str4 = "";
                foreach (object obj2 in this.checkedListBoxSR.CheckedItems)
                {
                    SRForRepair struct2 = (SRForRepair)obj2;
                    str4 = str4 + struct2.Id.ToString() + ",";
                }
                str4 = " (idSR in (" + str4.Remove(str4.Length - 1) + ")) ";
                if (this.cmdDivision.SelectedValue == null)
                {
                    this.dsGES.vJ_RequestForRepairDaily.Clear();
                }
                else
                {
                    string str5 = " (idDivision = " + this.cmdDivision.SelectedValue.ToString() + ") ";
                    string str6 = "";
                    if (!string.IsNullOrEmpty(this.txtObject.Text))
                    {
                        str6 = " and (schmObj like '%" + this.txtObject.Text + "%') ";
                    }
                    string str7 = "";
                    if (this.checkBoxIsAgreed.Checked)
                    {
                        str7 = " and (Agreed = 1) ";
                    }
                    string str8 = "";
                    if (this.isCrash)
                    {
                        str8 = " and (Crash = 1) ";
                    }
                    else
                    {
                        str8 = " and (Crash = 0 or Crash is null) ";
                    }
                    base.SelectSqlData(this.dsGES, this.dsGES.vJ_RequestForRepairDaily, true, " where " + str3 + " and " + str4 + " and " + str5 + str6 + str7 + str8 + " and deleted = 0 order by sr, id, datetripBeg");
                    this.FullTableRepairDaily(this.dateTimePickerBeg.Value.Date, this.dateTimePickerEnd.Value.Date);
                }
            }
            this.reportViewerRus1.RefreshReport();
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument document1 = new XmlDocument();
            XmlNode newChild = document1.CreateXmlDeclaration("1.0", "UTF-8", null);
            document1.AppendChild(newChild);
            XmlNode node2 = document1.CreateElement(base.Name);
            document1.AppendChild(node2);
            XmlAttribute node = document1.CreateAttribute("appoveTitle");
            node.Value = this.AppoveTitle;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("appoveOrg");
            node.Value = this.AppoveOrg;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("appoveFIO");
            node.Value = this.AppoveFIO;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("signatureTitle1");
            node.Value = this.SignatureTitle1;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("signatureFIO1");
            node.Value = this.SignatureFIO1;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("signatureTitle2");
            node.Value = this.SignatureTitle2;
            node2.Attributes.Append(node);
            node = document1.CreateAttribute("signatureFIO2");
            node.Value = this.SignatureFIO2;
            node2.Attributes.Append(node);
            return document1;
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerBeg.MaxDate = this.dateTimePickerEnd.Value;
        }

        private void dateTimePickerBeg_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerEnd.MinDate = this.dateTimePickerBeg.Value;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormReportRequestForRepair_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.SaveFormConfig(null);
        }

        private void FormReportRequestForRepair_Load(object sender, EventArgs e)
        {
            base.SelectSqlData(this.dsGES, this.dsGES.tR_Classifier, true, " where ParentKey = ';NetworkAreas;' and deleted = 0 and isGroup = 0 order by name ");
            foreach (DataRow row in this.dsGES.tR_Classifier)
            {
                SRForRepair item = new SRForRepair(Convert.ToInt32(row["id"]), row["name"].ToString());
                this.checkedListBoxSR.Items.Add(item, true);
            }
            base.SelectSqlData(this.dsGES, this.dsGES.tR_Classifier, true, " where ParentKey = ';Other;DivisionRequestRepair;' and isgroup = 0 and deleted = 0 order by name");
            this.cmdDivision.DataSource = this.dsGES.tR_Classifier;
            this.cmdDivision.DisplayMember = "name";
            this.cmdDivision.ValueMember = "ID";
            this.cmdDivision.SelectedValue = 920;
            base.LoadFormConfig(null);
        }

        private void FullTableRepairDaily(DateTime dateTime_0, DateTime dateTime_1)
        {
            bool flag = dateTime_0 == dateTime_1;
            for (int i = 0; i < this.dsGES.vJ_RequestForRepairDaily.Rows.Count; i++)
            {
                DataRow row = this.dsGES.vJ_RequestForRepairDaily.Rows[i];
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
                while ((i + num2) < this.dsGES.vJ_RequestForRepairDaily.Rows.Count)
                {
                    DataRow row2 = this.dsGES.vJ_RequestForRepairDaily.Rows[i + num2];
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
                    this.dsGES.vJ_RequestForRepairDaily.Rows.Remove(row2);
                }
                row["dateBeg"] = str;
                row["dateEnd"] = str3;
                row["timeBeg"] = str2;
                row["timeEnd"] = str4;
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ReportDataSource reportSource1 = new ReportDataSource();
            ReportDataSource reportSource2 = new ReportDataSource();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormReportRequestForRepair));
            this.bsRequestForRepair = new BindingSource(this.components);
            this.dsGES = new RequestForRepair.DataSets.DataSetN();
            this.bsRequestForRepairDaily = new BindingSource(this.components);
            this.reportViewerRus1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.panel1 = new Panel();
            this.toolStrip = new ToolStrip();
            this.toolBtnSettings = new ToolStripButton();
            this.cmdDivision = new ComboBox();
            this.label6 = new Label();
            this.checkedListBoxSR = new CheckedListBox();
            this.buttonClose = new Button();
            this.buttonAplly = new Button();
            this.txtObject = new TextBox();
            this.label5 = new Label();
            this.checkBoxShowAdresses = new CheckBox();
            this.checkBoxIsAgreed = new CheckBox();
            this.label4 = new Label();
            this.dateTimePickerEnd = new DateTimePicker();
            this.label3 = new Label();
            this.dateTimePickerBeg = new DateTimePicker();
            this.label2 = new Label();
            this.label1 = new Label();
            ((ISupportInitialize)this.bsRequestForRepair).BeginInit();
            this.dsGES.BeginInit();
            ((ISupportInitialize)this.bsRequestForRepairDaily).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            base.SuspendLayout();

            this.bsRequestForRepair.DataMember = "vJ_RequestForRepair";
            this.bsRequestForRepair.DataSource = this.dsGES;

            this.dsGES.DataSetName = "DataSetGES";
            this.dsGES.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;

            this.bsRequestForRepairDaily.DataMember = "vJ_RequestForRepairDaily";
            this.bsRequestForRepairDaily.DataSource = this.dsGES;

            this.reportViewerRus1.Dock = DockStyle.Fill;

            reportSource1.Name = "DataSetGES";
            reportSource1.Value = this.bsRequestForRepair;
            reportSource2.Name = "DataSetDaily";
            reportSource2.Value = this.bsRequestForRepairDaily;

            this.reportViewerRus1.LocalReport.DataSources.Add(reportSource1);
            this.reportViewerRus1.LocalReport.DataSources.Add(reportSource2);
            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "RequestForRepair.Documents.RDLC.ReportrequestForRepairFull.rdlc";
            this.reportViewerRus1.Location = new Point(0xd3, 0);
            this.reportViewerRus1.Name = "reportViewerRus1";
            this.reportViewerRus1.Size = new Size(0x1e5, 0x1ee);
            this.reportViewerRus1.TabIndex = 0;

            this.panel1.Controls.Add(this.toolStrip);
            this.panel1.Controls.Add(this.cmdDivision);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkedListBoxSR);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonAplly);
            this.panel1.Controls.Add(this.txtObject);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkBoxShowAdresses);
            this.panel1.Controls.Add(this.checkBoxIsAgreed);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePickerEnd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePickerBeg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = DockStyle.Left;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0xd3, 0x1ee);
            this.panel1.TabIndex = 1;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolBtnSettings };
            this.toolStrip.Items.AddRange(toolStripItems);
            this.toolStrip.Location = new Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new Size(0xd3, 0x19);
            this.toolStrip.TabIndex = 0x10;
            this.toolStrip.Text = "toolStrip1";
            this.toolBtnSettings.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnSettings.Image = global::RequestForRepair.Properties.Resources.Setting;
            this.toolBtnSettings.ImageTransparentColor = Color.Magenta;
            this.toolBtnSettings.Name = "toolBtnSettings";
            this.toolBtnSettings.Size = new Size(0x17, 0x16);
            this.toolBtnSettings.Text = "Настройки";
            this.toolBtnSettings.Click += new EventHandler(this.toolBtnSettings_Click);
            this.cmdDivision.FormattingEnabled = true;
            this.cmdDivision.Location = new Point(9, 0xed);
            this.cmdDivision.Name = "cmdDivision";
            this.cmdDivision.Size = new Size(0xc7, 0x15);
            this.cmdDivision.TabIndex = 15;
            this.label6.AutoSize = true;
            this.label6.Location = new Point(6, 0xdd);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Подразделения";
            this.checkedListBoxSR.CheckOnClick = true;
            this.checkedListBoxSR.FormattingEnabled = true;
            this.checkedListBoxSR.Location = new Point(9, 0x7c);
            this.checkedListBoxSR.Name = "checkedListBoxSR";
            this.checkedListBoxSR.Size = new Size(0xc7, 0x5e);
            this.checkedListBoxSR.TabIndex = 13;
            this.buttonClose.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.buttonClose.Location = new Point(0x72, 0x1d2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(0x5e, 0x19);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
            this.buttonAplly.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.buttonAplly.Location = new Point(9, 0x1d2);
            this.buttonAplly.Name = "buttonAplly";
            this.buttonAplly.Size = new Size(0x60, 0x19);
            this.buttonAplly.TabIndex = 11;
            this.buttonAplly.Text = "Сформировать";
            this.buttonAplly.UseVisualStyleBackColor = true;
            this.buttonAplly.Click += new EventHandler(this.buttonAplly_Click);
            this.txtObject.Location = new Point(9, 0x143);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new Size(0xc7, 20);
            this.txtObject.TabIndex = 10;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(6, 0x133);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Отключаемы объект";
            this.checkBoxShowAdresses.AutoSize = true;
            this.checkBoxShowAdresses.Location = new Point(9, 0x11f);
            this.checkBoxShowAdresses.Name = "checkBoxShowAdresses";
            this.checkBoxShowAdresses.Size = new Size(0x73, 0x11);
            this.checkBoxShowAdresses.TabIndex = 8;
            this.checkBoxShowAdresses.Text = "Выводить адреса";
            this.checkBoxShowAdresses.UseVisualStyleBackColor = true;
            this.checkBoxIsAgreed.AutoSize = true;
            this.checkBoxIsAgreed.Location = new Point(9, 0x108);
            this.checkBoxIsAgreed.Name = "checkBoxIsAgreed";
            this.checkBoxIsAgreed.Size = new Size(0x9b, 0x11);
            this.checkBoxIsAgreed.TabIndex = 7;
            this.checkBoxIsAgreed.Text = "Учитывать согласование";
            this.checkBoxIsAgreed.UseVisualStyleBackColor = true;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(6, 0x6c);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x5c, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сетевые районы";
            this.dateTimePickerEnd.Location = new Point(0x1f, 0x4c);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new Size(0xb1, 20);
            this.dateTimePickerEnd.TabIndex = 4;
            this.dateTimePickerEnd.ValueChanged += new EventHandler(this.dateTimePickerEnd_ValueChanged);
            this.label3.AutoSize = true;
            this.label3.Location = new Point(6, 0x52);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "по";
            this.dateTimePickerBeg.Location = new Point(0x1f, 50);
            this.dateTimePickerBeg.Name = "dateTimePickerBeg";
            this.dateTimePickerBeg.Size = new Size(0xb1, 20);
            this.dateTimePickerBeg.TabIndex = 2;
            this.dateTimePickerBeg.ValueChanged += new EventHandler(this.dateTimePickerBeg_ValueChanged);
            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 0x38);
            this.label2.Name = "label2";
            this.label2.Size = new Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "с";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 0x20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2d, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Период";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            //this.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x2b8, 0x1ee);
            base.Controls.Add(this.reportViewerRus1);
            base.Controls.Add(this.panel1);
            //base.Icon = (Icon)resources.GetObject("$this.Icon");
            this.MinimumSize = new Size(500, 400);
            base.Name = "FormReportRequestForRepair";
            this.Text = "Журнал заявок на ремонт оборудования (N)";
            base.FormClosed += new FormClosedEventHandler(this.FormReportRequestForRepair_FormClosed);
            base.Load += new EventHandler(this.FormReportRequestForRepair_Load);
            ((ISupportInitialize)this.bsRequestForRepair).EndInit();
            this.dsGES.EndInit();
            ((ISupportInitialize)this.bsRequestForRepairDaily).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            base.ResumeLayout(false);
        }

        private void toolBtnSettings_Click(object sender, EventArgs e)
        {
            FormReportReguestForRepairSettings settings = new FormReportReguestForRepairSettings();
            settings.SetAppoveTitle(this.AppoveTitle);
            settings.method_3(this.AppoveOrg);
            settings.method_5(this.AppoveFIO);
            settings.method_7(this.SignatureTitle1);
            //settings.SetSignatureFIO1(this.SignatureFIO1);
            settings.SignatureFIO1 = SignatureFIO1;
            settings.SetSignatureTitle2(this.SignatureTitle2);
            settings.method_13(this.SignatureFIO2);
            if (settings.ShowDialog() == DialogResult.OK)
            {
                this.AppoveTitle = settings.GetAppoveTitle();
                this.AppoveOrg = settings.method_2();
                this.AppoveFIO = settings.method_4();
                this.SignatureTitle1 = settings.method_6();
                //this.SignatureFIO1 = settings.GetSignatureFIO1();
                this.SignatureFIO1 = settings.SignatureFIO1;


                this.SignatureTitle2 = settings.GetSignatureTitle2();
                this.SignatureFIO2 = settings.method_12();
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