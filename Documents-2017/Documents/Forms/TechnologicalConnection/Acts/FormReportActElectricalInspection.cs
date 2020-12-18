namespace Documents.Forms.TechnologicalConnection.Acts
{
    using Documents.Forms.TechnologicalConnection;
    using FormLbr;
    using FormLbr.Classes;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Xml;

    public class FormReportActElectricalInspection : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private CheckBox checkBox_0;
        private DataSetTechConnection dataSetTechConnection_0;
        private DateTime dateTime_0;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private Panel panel_0;
        private ReportViewer reportViewer_0;

        public FormReportActElectricalInspection()
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.dateTime_0 = DateTime.MinValue;
            this.method_8();
        }

        public FormReportActElectricalInspection(int idAct)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.dateTime_0 = DateTime.MinValue;
            this.method_8();
            this.int_0 = idAct;
        }

        private void checkBox_0_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dataSetTechConnection_0.tTC_Doc.Rows.Count > 0)
            {
                if (this.checkBox_0.Checked && (this.dateTime_0 != DateTime.MinValue))
                {
                    this.dataSetTechConnection_0.tTC_Doc.Rows[0]["datedoc"] = this.dateTime_0;
                }
                else
                {
                    this.dataSetTechConnection_0.tTC_Doc.Rows[0]["datedoc"] = DBNull.Value;
                }
                this.reportViewer_0.RefreshReport();
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

        private void FormReportActElectricalInspection_Load(object sender, EventArgs e)
        {
            base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.tTC_Doc, true, "where id = " + this.int_0.ToString());
            if (this.dataSetTechConnection_0.tTC_Doc.Rows.Count > 0)
            {
                this.int_1 = Convert.ToInt32(this.dataSetTechConnection_0.tTC_Doc.Rows[0]["TypeDoc"]);
                this.dateTime_0 = Convert.ToDateTime(this.dataSetTechConnection_0.tTC_Doc.Rows[0]["dateDoc"]);
                switch (this.int_1)
                {
                    case 0x4d6:
                        this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.TechnologicalConnection.Acts.Reports.ActElectricalInspection2.rdlc";
                        this.method_1();
                        break;

                    case 0x4d7:
                        this.method_0();
                        return;

                    case 0x4d8:
                        this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.TechnologicalConnection.Acts.Reports.ActTC.rdlc";
                        this.Text = "Акт технологического присоединения";
                        break;
                }
                if (this.dataSetTechConnection_0.tTC_Doc.Rows[0]["idparent"] != DBNull.Value)
                {
                    DataTable table = base.SelectSqlData("vtc_tu", true, " where id = " + this.dataSetTechConnection_0.tTC_Doc.Rows[0]["idparent"].ToString());
                    if (table.Rows.Count > 0)
                    {
                        if (table.Rows[0]["dateDoc"] != DBNull.Value)
                        {
                            ReportParameter parameter = new ReportParameter("DateTU", Convert.ToDateTime(table.Rows[0]["dateDoc"]).ToString("dd.MM.yyyy"));
                            ReportParameter[] parameters = new ReportParameter[] { parameter };
                            this.reportViewer_0.LocalReport.SetParameters(parameters);
                        }
                        if (table.Rows[0]["numDoc"] != DBNull.Value)
                        {
                            ReportParameter parameter2 = new ReportParameter("NumTU", table.Rows[0]["numDoc"].ToString());
                            ReportParameter[] parameterArray2 = new ReportParameter[] { parameter2 };
                            this.reportViewer_0.LocalReport.SetParameters(parameterArray2);
                        }
                        if (table.Rows[0]["Power"] != DBNull.Value)
                        {
                            ReportParameter parameter3 = new ReportParameter("PowerAdd", table.Rows[0]["Power"].ToString());
                            ReportParameter[] parameterArray3 = new ReportParameter[] { parameter3 };
                            this.reportViewer_0.LocalReport.SetParameters(parameterArray3);
                        }
                        if (table.Rows[0]["PowerSum"] != DBNull.Value)
                        {
                            ReportParameter parameter4 = new ReportParameter("PowerSum", table.Rows[0]["PowerSum"].ToString());
                            ReportParameter[] parameterArray4 = new ReportParameter[] { parameter4 };
                            this.reportViewer_0.LocalReport.SetParameters(parameterArray4);
                        }
                        if (table.Rows[0]["dateContractor"] != DBNull.Value)
                        {
                            ReportParameter parameter5 = new ReportParameter("DateContract", Convert.ToDateTime(table.Rows[0]["dateContractor"]).ToString("dd.MM.yyyy"));
                            ReportParameter[] parameterArray5 = new ReportParameter[] { parameter5 };
                            this.reportViewer_0.LocalReport.SetParameters(parameterArray5);
                        }
                        if (table.Rows[0]["numContractor"] != DBNull.Value)
                        {
                            ReportParameter parameter6 = new ReportParameter("NumContract", table.Rows[0]["numContractor"].ToString());
                            ReportParameter[] parameterArray6 = new ReportParameter[] { parameter6 };
                            this.reportViewer_0.LocalReport.SetParameters(parameterArray6);
                        }
                        if (this.int_1 == 0x4d8)
                        {
                            if (table.Rows[0]["idContractor"] != DBNull.Value)
                            {
                                DataTable table3 = base.SelectSqlData("ttc_contract", true, "where id = " + table.Rows[0]["idContractor"].ToString());
                                if (table3.Rows.Count > 0)
                                {
                                    if (table3.Rows[0]["SumContract"] != DBNull.Value)
                                    {
                                        ReportParameter parameter7 = new ReportParameter("SumContract", Convert.ToDecimal(table3.Rows[0]["SumContract"]).ToString("N"));
                                        ReportParameter[] parameterArray7 = new ReportParameter[] { parameter7 };
                                        this.reportViewer_0.LocalReport.SetParameters(parameterArray7);
                                        string str = RuDateAndMoneyConverter.CurrencyToTxt(Convert.ToDouble(table3.Rows[0]["SumContract"]), false);
                                        parameter7 = new ReportParameter("SumContractTxt", str);
                                        ReportParameter[] parameterArray8 = new ReportParameter[] { parameter7 };
                                        this.reportViewer_0.LocalReport.SetParameters(parameterArray8);
                                    }
                                    if (table3.Rows[0]["SumNDS"] != DBNull.Value)
                                    {
                                        ReportParameter parameter8 = new ReportParameter("SumNDS", Convert.ToDecimal(table3.Rows[0]["SumNDS"]).ToString("N"));
                                        ReportParameter[] parameterArray9 = new ReportParameter[] { parameter8 };
                                        this.reportViewer_0.LocalReport.SetParameters(parameterArray9);
                                        string str2 = RuDateAndMoneyConverter.CurrencyToTxt(Convert.ToDouble(table3.Rows[0]["SumNDS"]), false);
                                        parameter8 = new ReportParameter("SumNDSTxt", str2);
                                        ReportParameter[] parameterArray10 = new ReportParameter[] { parameter8 };
                                        this.reportViewer_0.LocalReport.SetParameters(parameterArray10);
                                    }
                                }
                            }
                            DataTable table2 = base.SelectSqlData("tTC_doc", true, "where idParent = " + table.Rows[0]["id"].ToString() + " and typeDoc = " + 0x4d7.ToString());
                            if (table2.Rows.Count > 0)
                            {
                                if (table2.Rows[0]["numDoc"] != DBNull.Value)
                                {
                                    ReportParameter parameter9 = new ReportParameter("NumPerformanceTU", table2.Rows[0]["numDoc"].ToString());
                                    ReportParameter[] parameterArray11 = new ReportParameter[] { parameter9 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray11);
                                }
                                if (table2.Rows[0]["dateDoc"] != DBNull.Value)
                                {
                                    ReportParameter parameter10 = new ReportParameter("DatePerformanceTU", Convert.ToDateTime(table2.Rows[0]["dateDoc"]).ToString("dd.MM.yyyy"));
                                    ReportParameter[] parameterArray12 = new ReportParameter[] { parameter10 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray12);
                                }
                            }
                        }
                        if (table.Rows[0]["categoryName"] != DBNull.Value)
                        {
                            ReportParameter parameter11 = new ReportParameter("Category", table.Rows[0]["categoryName"].ToString());
                            ReportParameter[] parameterArray13 = new ReportParameter[] { parameter11 };
                            this.reportViewer_0.LocalReport.SetParameters(parameterArray13);
                        }
                        this.method_6();
                        string[] textArray1 = new string[] { "where idTU = ", table.Rows[0]["id"].ToString(), " and (typeDoc is null or typeDoc = ", 0x463.ToString(), ") " };
                        base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_TUPointAttach, true, string.Concat(textArray1));
                    }
                }
            }
            this.reportViewer_0.RefreshReport();
        }

        private void method_0()
        {
            this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.TechnologicalConnection.Acts.Reports.ActPerformingTU2.rdlc";
            this.Text = "Акт о выполнении технических условий";
            if (this.dataSetTechConnection_0.tTC_Doc.Rows[0]["idparent"] != DBNull.Value)
            {
                DataTable table = base.SelectSqlData("vtc_tu", true, " where id = " + this.dataSetTechConnection_0.tTC_Doc.Rows[0]["idparent"].ToString());
                if (table.Rows.Count > 0)
                {
                    if (table.Rows[0]["dateDoc"] != DBNull.Value)
                    {
                        ReportParameter parameter = new ReportParameter("DateTU", Convert.ToDateTime(table.Rows[0]["dateDoc"]).ToString("dd.MM.yyyy"));
                        ReportParameter[] parameters = new ReportParameter[] { parameter };
                        this.reportViewer_0.LocalReport.SetParameters(parameters);
                    }
                    if (table.Rows[0]["numDoc"] != DBNull.Value)
                    {
                        ReportParameter parameter2 = new ReportParameter("NumTU", table.Rows[0]["numDoc"].ToString());
                        ReportParameter[] parameterArray2 = new ReportParameter[] { parameter2 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray2);
                    }
                    if (table.Rows[0]["Power"] != DBNull.Value)
                    {
                        ReportParameter parameter3 = new ReportParameter("PowerAdd", table.Rows[0]["Power"].ToString());
                        ReportParameter[] parameterArray3 = new ReportParameter[] { parameter3 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray3);
                    }
                    if (table.Rows[0]["PowerSum"] != DBNull.Value)
                    {
                        ReportParameter parameter4 = new ReportParameter("PowerSum", table.Rows[0]["PowerSum"].ToString());
                        ReportParameter[] parameterArray4 = new ReportParameter[] { parameter4 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray4);
                    }
                    if (table.Rows[0]["dateContractor"] != DBNull.Value)
                    {
                        ReportParameter parameter5 = new ReportParameter("DateContract", Convert.ToDateTime(table.Rows[0]["dateContractor"]).ToString("dd.MM.yyyy"));
                        ReportParameter[] parameterArray5 = new ReportParameter[] { parameter5 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray5);
                    }
                    if (table.Rows[0]["numContractor"] != DBNull.Value)
                    {
                        ReportParameter parameter6 = new ReportParameter("NumContract", table.Rows[0]["numContractor"].ToString());
                        ReportParameter[] parameterArray6 = new ReportParameter[] { parameter6 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray6);
                    }
                    if (table.Rows[0]["categoryName"] != DBNull.Value)
                    {
                        ReportParameter parameter7 = new ReportParameter("Category", table.Rows[0]["categoryName"].ToString());
                        ReportParameter[] parameterArray7 = new ReportParameter[] { parameter7 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray7);
                    }
                    if (table.Rows[0]["NameAbn"] != DBNull.Value)
                    {
                        ReportParameter parameter8 = new ReportParameter("AbnName", table.Rows[0]["NameAbn"].ToString());
                        ReportParameter[] parameterArray8 = new ReportParameter[] { parameter8 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray8);
                    }
                    if (table.Rows[0]["Address"] != DBNull.Value)
                    {
                        ReportParameter parameter9 = new ReportParameter("Address", table.Rows[0]["Address"].ToString());
                        ReportParameter[] parameterArray9 = new ReportParameter[] { parameter9 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray9);
                    }
                    this.method_6();
                    this.method_7();
                    string[] textArray1 = new string[] { "where idTU = ", table.Rows[0]["id"].ToString(), " and (typeDoc is null or typeDoc = ", 0x463.ToString(), ") " };
                    base.SelectSqlData(this.dataSetTechConnection_0, this.dataSetTechConnection_0.vTC_TUPointAttach, true, string.Concat(textArray1));
                }
                DataTable table2 = base.SelectSqlData("ttc_tu", true, " where id = " + this.dataSetTechConnection_0.tTC_Doc.Rows[0]["idparent"].ToString());
                if ((table2.Rows.Count > 0) && (table2.Rows[0]["DeviceName"] != DBNull.Value))
                {
                    ReportParameter parameter10 = new ReportParameter("VRU", table2.Rows[0]["DeviceName"].ToString());
                    ReportParameter[] parameterArray10 = new ReportParameter[] { parameter10 };
                    this.reportViewer_0.LocalReport.SetParameters(parameterArray10);
                }
                DataTable table3 = base.SelectSqlData("ttc_PerformingTU", true, "where id = " + this.dataSetTechConnection_0.tTC_Doc.Rows[0]["id"].ToString());
                if (table3.Rows.Count > 0)
                {
                    if (table3.Rows[0]["FaceNetWork"] != DBNull.Value)
                    {
                        ReportParameter parameter11 = new ReportParameter("FaceNetWork", table3.Rows[0]["FaceNetWork"].ToString());
                        ReportParameter[] parameterArray11 = new ReportParameter[] { parameter11 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray11);
                    }
                    if (table3.Rows[0]["BasisNetWork"] != DBNull.Value)
                    {
                        ReportParameter parameter12 = new ReportParameter("BasisNetWork", table3.Rows[0]["BasisNetWork"].ToString());
                        ReportParameter[] parameterArray12 = new ReportParameter[] { parameter12 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray12);
                    }
                    if (table3.Rows[0]["FaceApplicant"] != DBNull.Value)
                    {
                        ReportParameter parameter13 = new ReportParameter("FaceApplicant", table3.Rows[0]["FaceApplicant"].ToString());
                        ReportParameter[] parameterArray13 = new ReportParameter[] { parameter13 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray13);
                    }
                    if (table3.Rows[0]["BasisApplicant"] != DBNull.Value)
                    {
                        ReportParameter parameter14 = new ReportParameter("BasisApplicant", table3.Rows[0]["BasisApplicant"].ToString());
                        ReportParameter[] parameterArray14 = new ReportParameter[] { parameter14 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray14);
                    }
                }
                ReportDataSource item = new ReportDataSource {
                    Name = "tTC_TUTypeWork",
                    Value = this.dataSetTechConnection_0.tTC_TUTypeWork
                };
                this.reportViewer_0.LocalReport.DataSources.Add(item);
                base.SelectSqlData(this.dataSetTechConnection_0.tTC_TUTypeWork, true, " where idTU = " + this.dataSetTechConnection_0.tTC_Doc.Rows[0]["idparent"].ToString() + " and typeWork = 2 order by num", false);
                DataTable table4 = base.SelectSqlData("ttc_doc", true, " where idParent = " + this.dataSetTechConnection_0.tTC_Doc.Rows[0]["idparent"].ToString() + " and typeDoc = " + 0x4d6.ToString());
                if (table4.Rows.Count > 0)
                {
                    string str = "";
                    if (table4.Rows[0]["numDoc"] != DBNull.Value)
                    {
                        str = "№" + table4.Rows[0]["numDoc"].ToString();
                        if (table4.Rows[0]["dateDoc"] != DBNull.Value)
                        {
                            str = str + " от " + Convert.ToDateTime(table4.Rows[0]["dateDoc"]).ToString("dd.MM.yyyy");
                        }
                        ReportParameter parameter15 = new ReportParameter("ActElInsp", str);
                        ReportParameter[] parameterArray15 = new ReportParameter[] { parameter15 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray15);
                    }
                }
            }
            this.reportViewer_0.RefreshReport();
        }

        private void method_1()
        {
            this.Text = "Акт осмотра электроустановок";
            if (this.int_1 == 0x4d6)
            {
                base.SelectSqlData(this.dataSetTechConnection_0.tTC_ElectricalInspection, true, "where id = " + this.int_0.ToString(), false);
                if (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows.Count > 0)
                {
                    if (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["idWorker"] != DBNull.Value)
                    {
                        this.method_4(Convert.ToInt32(this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["idWorker"]));
                    }
                    if (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["Declarer"] != DBNull.Value)
                    {
                        ReportParameter parameter = new ReportParameter("Declarer", this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["Declarer"].ToString());
                        ReportParameter[] parameters = new ReportParameter[] { parameter };
                        this.reportViewer_0.LocalReport.SetParameters(parameters);
                    }
                    if (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["Electrical"] != DBNull.Value)
                    {
                        ReportParameter parameter2 = new ReportParameter("Electrical", this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["Electrical"].ToString());
                        ReportParameter[] parameterArray2 = new ReportParameter[] { parameter2 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray2);
                    }
                    if (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["SetElectrical"] != DBNull.Value)
                    {
                        ReportParameter parameter3 = new ReportParameter("SetElectrical", this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["SetElectrical"].ToString());
                        ReportParameter[] parameterArray3 = new ReportParameter[] { parameter3 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray3);
                    }
                    if (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["SetMeterDevice"] != DBNull.Value)
                    {
                        ReportParameter parameter4 = new ReportParameter("SetMeterDevice", this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["SetMeterDevice"].ToString());
                        ReportParameter[] parameterArray4 = new ReportParameter[] { parameter4 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray4);
                    }
                    if (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["SetRZA"] != DBNull.Value)
                    {
                        ReportParameter parameter5 = new ReportParameter("SetRZA", this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["SetRZA"].ToString());
                        ReportParameter[] parameterArray5 = new ReportParameter[] { parameter5 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray5);
                    }
                    if (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["SetReserveCP"] != DBNull.Value)
                    {
                        ReportParameter parameter6 = new ReportParameter("SetReserveCP", this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["SetReserveCP"].ToString());
                        ReportParameter[] parameterArray6 = new ReportParameter[] { parameter6 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray6);
                    }
                    if (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["SetDocument"] != DBNull.Value)
                    {
                        ReportParameter parameter7 = new ReportParameter("SetDocument", this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["SetDocument"].ToString());
                        ReportParameter[] parameterArray7 = new ReportParameter[] { parameter7 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray7);
                    }
                    this.method_2();
                }
            }
        }

        private void method_2()
        {
            if ((this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows.Count > 0) && (this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["Officials"] != DBNull.Value))
            {
                try
                {
                    XmlDocument document1 = new XmlDocument();
                    document1.LoadXml(this.dataSetTechConnection_0.tTC_ElectricalInspection.Rows[0]["Officials"].ToString());
                    XmlNode node = document1.SelectSingleNode("Official");
                    if (node != null)
                    {
                        XmlNode node2 = node.SelectSingleNode("Seti");
                        if (node2 != null)
                        {
                            XmlNode node4 = node2.SelectSingleNode("FIO1");
                            if (node4 != null)
                            {
                                XmlAttribute attribute = node4.Attributes["FIO"];
                                if (attribute != null)
                                {
                                    ReportParameter parameter = new ReportParameter("SetFIO1", attribute.Value);
                                    ReportParameter[] parameters = new ReportParameter[] { parameter };
                                    this.reportViewer_0.LocalReport.SetParameters(parameters);
                                }
                                attribute = node4.Attributes["JobTitle"];
                                if (attribute != null)
                                {
                                    ReportParameter parameter2 = new ReportParameter("SetJob1", attribute.Value);
                                    ReportParameter[] parameterArray2 = new ReportParameter[] { parameter2 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray2);
                                }
                            }
                            XmlNode node5 = node2.SelectSingleNode("FIO2");
                            if (node5 != null)
                            {
                                XmlAttribute attribute2 = node5.Attributes["FIO"];
                                if (attribute2 != null)
                                {
                                    ReportParameter parameter3 = new ReportParameter("SetFIO2", attribute2.Value);
                                    ReportParameter[] parameterArray3 = new ReportParameter[] { parameter3 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray3);
                                }
                                attribute2 = node5.Attributes["JobTitle"];
                                if (attribute2 != null)
                                {
                                    ReportParameter parameter4 = new ReportParameter("SetJob2", attribute2.Value);
                                    ReportParameter[] parameterArray4 = new ReportParameter[] { parameter4 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray4);
                                }
                            }
                            XmlNode node6 = node2.SelectSingleNode("FIO3");
                            if (node6 != null)
                            {
                                XmlAttribute attribute3 = node6.Attributes["FIO"];
                                if (attribute3 != null)
                                {
                                    ReportParameter parameter5 = new ReportParameter("SetFIO3", attribute3.Value);
                                    ReportParameter[] parameterArray5 = new ReportParameter[] { parameter5 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray5);
                                }
                                attribute3 = node6.Attributes["JobTitle"];
                                if (attribute3 != null)
                                {
                                    ReportParameter parameter6 = new ReportParameter("SetJob3", attribute3.Value);
                                    ReportParameter[] parameterArray6 = new ReportParameter[] { parameter6 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray6);
                                }
                            }
                            XmlNode node7 = node2.SelectSingleNode("Official");
                            if (node7 != null)
                            {
                                XmlAttribute attribute4 = node7.Attributes["FIO"];
                                if (attribute4 != null)
                                {
                                    ReportParameter parameter7 = new ReportParameter("SetFIO4", attribute4.Value);
                                    ReportParameter[] parameterArray7 = new ReportParameter[] { parameter7 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray7);
                                }
                                attribute4 = node7.Attributes["JobTitle"];
                                if (attribute4 != null)
                                {
                                    ReportParameter parameter8 = new ReportParameter("SetJob4", attribute4.Value);
                                    ReportParameter[] parameterArray8 = new ReportParameter[] { parameter8 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray8);
                                }
                            }
                        }
                        XmlNode node3 = node.SelectSingleNode("Declarer");
                        if (node3 != null)
                        {
                            XmlNode node8 = node3.SelectSingleNode("FIO1");
                            if (node8 != null)
                            {
                                XmlAttribute attribute5 = node8.Attributes["FIO"];
                                if (attribute5 != null)
                                {
                                    ReportParameter parameter9 = new ReportParameter("DeclarerFIO1", attribute5.Value);
                                    ReportParameter[] parameterArray9 = new ReportParameter[] { parameter9 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray9);
                                }
                                attribute5 = node8.Attributes["JobTitle"];
                                if (attribute5 != null)
                                {
                                    ReportParameter parameter10 = new ReportParameter("DeclarerJob1", attribute5.Value);
                                    ReportParameter[] parameterArray10 = new ReportParameter[] { parameter10 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray10);
                                }
                            }
                            node8 = node3.SelectSingleNode("FIO2");
                            if (node8 != null)
                            {
                                XmlAttribute attribute6 = node8.Attributes["FIO"];
                                if (attribute6 != null)
                                {
                                    ReportParameter parameter11 = new ReportParameter("DeclarerFIO2", attribute6.Value);
                                    ReportParameter[] parameterArray11 = new ReportParameter[] { parameter11 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray11);
                                }
                                attribute6 = node8.Attributes["JobTitle"];
                                if (attribute6 != null)
                                {
                                    ReportParameter parameter12 = new ReportParameter("DeclarerJob2", attribute6.Value);
                                    ReportParameter[] parameterArray12 = new ReportParameter[] { parameter12 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray12);
                                }
                            }
                            node8 = node3.SelectSingleNode("FIO3");
                            if (node8 != null)
                            {
                                XmlAttribute attribute7 = node8.Attributes["FIO"];
                                if (attribute7 != null)
                                {
                                    ReportParameter parameter13 = new ReportParameter("DeclarerFIO3", attribute7.Value);
                                    ReportParameter[] parameterArray13 = new ReportParameter[] { parameter13 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray13);
                                }
                                attribute7 = node8.Attributes["JobTitle"];
                                if (attribute7 != null)
                                {
                                    ReportParameter parameter14 = new ReportParameter("DeclarerJob3", attribute7.Value);
                                    ReportParameter[] parameterArray14 = new ReportParameter[] { parameter14 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray14);
                                }
                            }
                            node8 = node3.SelectSingleNode("FIO4");
                            if (node8 != null)
                            {
                                XmlAttribute attribute8 = node8.Attributes["FIO"];
                                if (attribute8 != null)
                                {
                                    ReportParameter parameter15 = new ReportParameter("DeclarerFIO4", attribute8.Value);
                                    ReportParameter[] parameterArray15 = new ReportParameter[] { parameter15 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray15);
                                }
                                attribute8 = node8.Attributes["JobTitle"];
                                if (attribute8 != null)
                                {
                                    ReportParameter parameter16 = new ReportParameter("DeclarerJob4", attribute8.Value);
                                    ReportParameter[] parameterArray16 = new ReportParameter[] { parameter16 };
                                    this.reportViewer_0.LocalReport.SetParameters(parameterArray16);
                                }
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source);
                }
            }
        }

        private void method_3()
        {
        }

        private void method_4(int int_2)
        {
            DataTable table = base.SelectSqlData("tr_Worker", true, "where id = " + int_2.ToString());
            if (table.Rows.Count > 0)
            {
                string str = "";
                string str2 = "";
                string str3 = "";
                string str4 = "";
                if (table.Rows[0]["Padez"] != DBNull.Value)
                {
                    try
                    {
                        XmlDocument document1 = new XmlDocument();
                        document1.LoadXml((string) table.Rows[0]["Padez"]);
                        XmlNode node = document1.SelectSingleNode("FIO");
                        if (node != null)
                        {
                            XmlNode node2 = node.SelectSingleNode("ablative");
                            if (node2 != null)
                            {
                                XmlAttribute namedItem = (XmlAttribute) node2.Attributes.GetNamedItem("F");
                                if (namedItem != null)
                                {
                                    str = namedItem.Value;
                                }
                                namedItem = (XmlAttribute) node2.Attributes.GetNamedItem("I");
                                if (namedItem != null)
                                {
                                    str2 = namedItem.Value;
                                }
                                namedItem = (XmlAttribute) node2.Attributes.GetNamedItem("O");
                                if (namedItem != null)
                                {
                                    str3 = namedItem.Value;
                                }
                            }
                        }
                    }
                    catch
                    {
                    }
                }
                if (string.IsNullOrEmpty(str))
                {
                    str = table.Rows[0]["F"].ToString();
                }
                if (string.IsNullOrEmpty(str2))
                {
                    str2 = table.Rows[0]["i"].ToString();
                }
                if (string.IsNullOrEmpty(str3))
                {
                    str3 = table.Rows[0]["o"].ToString();
                }
                str4 = str;
                if (!string.IsNullOrEmpty(str2) && (str2.Length > 0))
                {
                    str4 = str4 + " " + str2.Substring(0, 1) + ".";
                    if (!string.IsNullOrEmpty(str3) && (str3.Length > 0))
                    {
                        str4 = str4 + str3.Substring(0, 1) + ".";
                    }
                }
                string str5 = "";
                if (table.Rows[0]["JobTitle"] != DBNull.Value)
                {
                    DataTable table2 = base.SelectSqlData("tr_JobTitle", true, "where id = " + table.Rows[0]["JobTitle"].ToString());
                    if (table2.Rows.Count > 0)
                    {
                        if (table2.Rows[0]["Padez"] != DBNull.Value)
                        {
                            try
                            {
                                XmlDocument document2 = new XmlDocument();
                                document2.LoadXml((string) table2.Rows[0]["Padez"]);
                                XmlNode node3 = document2.SelectSingleNode("JobTitle");
                                if (node3 != null)
                                {
                                    XmlNode node4 = node3.SelectSingleNode("ablative");
                                    if (node4 != null)
                                    {
                                        XmlAttribute attribute2 = (XmlAttribute) node4.Attributes.GetNamedItem("Description");
                                        if (attribute2 != null)
                                        {
                                            str5 = attribute2.Value;
                                        }
                                    }
                                }
                            }
                            catch
                            {
                            }
                        }
                        if (string.IsNullOrEmpty(str5) && (table2.Rows[0]["Description"] != DBNull.Value))
                        {
                            str5 = table2.Rows[0]["Description"].ToString();
                        }
                        ReportParameter parameter2 = new ReportParameter("JobTitle", str5);
                        ReportParameter[] parameterArray1 = new ReportParameter[] { parameter2 };
                        this.reportViewer_0.LocalReport.SetParameters(parameterArray1);
                    }
                }
                if (!string.IsNullOrEmpty(str5))
                {
                    string str6 = this.method_5();
                    if (!string.IsNullOrEmpty(str6))
                    {
                        str4 = str6 + " " + str4;
                    }
                }
                ReportParameter parameter = new ReportParameter("ChiefSR", str4);
                ReportParameter[] parameters = new ReportParameter[] { parameter };
                this.reportViewer_0.LocalReport.SetParameters(parameters);
            }
        }

        private string method_5()
        {
            DataTable table = base.SelectSqlData("vAbnType", true, " where typeKontragent = " + 0x45b.ToString());
            if (table.Rows.Count > 0)
            {
                return table.Rows[0]["Name"].ToString();
            }
            return string.Empty;
        }

        private void method_6()
        {
            DataTable table = base.SelectSqlData("vAbnType", true, " where typeKontragent = " + 0x45b.ToString());
            if (table.Rows.Count > 0)
            {
                ReportParameter parameter = new ReportParameter("OrgOwn", table.Rows[0]["Name"].ToString());
                ReportParameter[] parameters = new ReportParameter[] { parameter };
                this.reportViewer_0.LocalReport.SetParameters(parameters);
            }
        }

        private void method_7()
        {
            DataTable table = base.SelectSqlData("vAbnType", true, " where typeKontragent = " + 0x45b.ToString());
            if (table.Rows.Count > 0)
            {
                DataTable table2 = base.SelectSqlData("tg_AbnInfo", true, " where idAbn = " + table.Rows[0]["idAbn"].ToString() + " order by DateChange desc");
                if (((table2.Rows.Count > 0) && (table2.Rows[0]["NameShort"] != DBNull.Value)) && !string.IsNullOrEmpty(table2.Rows[0]["NameShort"].ToString()))
                {
                    ReportParameter parameter = new ReportParameter("OrgOwnShort", table2.Rows[0]["NameShort"].ToString());
                    ReportParameter[] parameters = new ReportParameter[] { parameter };
                    this.reportViewer_0.LocalReport.SetParameters(parameters);
                }
                else
                {
                    ReportParameter parameter2 = new ReportParameter("OrgOwnShort", table.Rows[0]["Name"].ToString());
                    ReportParameter[] parameterArray2 = new ReportParameter[] { parameter2 };
                    this.reportViewer_0.LocalReport.SetParameters(parameterArray2);
                }
            }
        }

        private void method_8()
        {
            this.icontainer_0 = new Container();
            ReportDataSource item = new ReportDataSource();
            ReportDataSource source2 = new ReportDataSource();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetTechConnection_0 = new DataSetTechConnection();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.reportViewer_0 = new ReportViewer();
            this.panel_0 = new Panel();
            this.checkBox_0 = new CheckBox();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetTechConnection_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            this.panel_0.SuspendLayout();
            base.SuspendLayout();
            this.bindingSource_0.DataMember = "tTC_Doc";
            this.bindingSource_0.DataSource = this.dataSetTechConnection_0;
            this.dataSetTechConnection_0.DataSetName = "DataSetTechConnection";
            this.dataSetTechConnection_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.bindingSource_1.DataMember = "vTC_TUPointAttach";
            this.bindingSource_1.DataSource = this.dataSetTechConnection_0;
            this.reportViewer_0.Dock = DockStyle.Fill;
            item.Name = "tTC_Doc";
            item.Value = this.bindingSource_0;
            source2.Name = "vTC_TUPointAttach";
            source2.Value = this.bindingSource_1;
            this.reportViewer_0.LocalReport.DataSources.Add(item);
            this.reportViewer_0.LocalReport.DataSources.Add(source2);
            this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.TechnologicalConnection.Acts.Reports.ActElectricalInspection.rdlc";
            this.reportViewer_0.Location = new Point(0, 0x26);
            this.reportViewer_0.Name = "reportViewer1";
            this.reportViewer_0.Size = new Size(0x303, 0x13c);
            this.reportViewer_0.TabIndex = 0;
            this.panel_0.Controls.Add(this.checkBox_0);
            this.panel_0.Dock = DockStyle.Top;
            this.panel_0.Location = new Point(0, 0);
            this.panel_0.Name = "panel1";
            this.panel_0.Size = new Size(0x303, 0x26);
            this.panel_0.TabIndex = 1;
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Checked = true;
            this.checkBox_0.CheckState = CheckState.Checked;
            this.checkBox_0.Location = new Point(12, 12);
            this.checkBox_0.Name = "checkBoxDateOut";
            this.checkBox_0.Size = new Size(0x98, 0x11);
            this.checkBox_0.TabIndex = 0;
            this.checkBox_0.Text = "Вывести дату документа";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_0.CheckedChanged += new EventHandler(this.checkBox_0_CheckedChanged);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x303, 0x162);
            base.Controls.Add(this.reportViewer_0);
            base.Controls.Add(this.panel_0);
            base.Name = "FormReportActElectricalInspection";
            this.Text = "Акт осмотра электроустановок";
            base.Load += new EventHandler(this.FormReportActElectricalInspection_Load);
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetTechConnection_0.EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            this.panel_0.ResumeLayout(false);
            this.panel_0.PerformLayout();
            base.ResumeLayout(false);
        }
    }
}

