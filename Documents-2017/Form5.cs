using DataSql;
using Documents.DataSets;
using FormLbr;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

internal class Form5 : FormBase
{
    public BindingSource bindingSource_0;
    public BindingSource bindingSource_1;
    public BindingSource bindingSource_2;
    public BindingSource bindingSource_3;
    private BindingSource bindingSource_4;
    private BindingSource bindingSource_5;
    private BindingSource bindingSource_6;
    public BindingSource bindingSource_7;
    private bool bool_0;
    private Class202 class202_0;
    private Class203 class203_0;
    private Class204 class204_0;
    private Class207 class207_0;
    private Class211 class211_0;
    private OrgDataSet.Class410 class410_0;
    private DateTime dateTime_0;
    private DateTime dateTime_1;
    private IContainer icontainer_0;
    private List<string> list_0;
    private List<string> list_1;
    private List<string> list_2;
    private OrgDataSet orgDataSet_0;
    private ReportViewer reportViewer_0;
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;
    private string string_4;
    private const string string_5 = "RequestODS";

    public Form5(OrgDataSet.Class410 class410_1, SQLSettings sqlsettings_0)
    {
        this.list_0 = new List<string>();
        this.list_1 = new List<string>();
        this.list_2 = new List<string>();
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.string_2 = string.Empty;
        this.string_3 = string.Empty;
        this.string_4 = string.Empty;
        this.method_4();
        this.set_SqlSettings(sqlsettings_0);
        this.class410_0 = class410_1;
        this.class211_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        this.class207_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        this.class203_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        this.class204_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        this.class202_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
    }

    public Form5(DateTime dateTime_2, DateTime dateTime_3, SQLSettings sqlsettings_0)
    {
        this.list_0 = new List<string>();
        this.list_1 = new List<string>();
        this.list_2 = new List<string>();
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.string_2 = string.Empty;
        this.string_3 = string.Empty;
        this.string_4 = string.Empty;
        this.method_4();
        this.set_SqlSettings(sqlsettings_0);
        this.bool_0 = true;
        this.dateTime_0 = dateTime_2;
        this.dateTime_1 = dateTime_3;
        this.class211_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        this.class207_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        this.class203_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        this.class204_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        this.class202_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form5_Load(object sender, EventArgs e)
    {
        SqlConnection connection = new SqlConnection(SqlDataConnect.GetConnectionString(this.get_SqlSettings()));
        connection.Open();
        SqlDataReader reader = new SqlCommand("select top 1 * from tSettings where Module = 'RequestODS'", connection).ExecuteReader();
        if (reader.Read())
        {
            XmlDocument document1 = new XmlDocument();
            document1.LoadXml(reader["Settings"].ToString());
            XmlNode node = document1.SelectSingleNode("ApplSet");
            foreach (XmlNode node3 in node.SelectNodes("NetArea"))
            {
                this.list_0.Add(node3.Attributes["Name"].Value);
                this.list_1.Add(node3.Attributes["Genitive"].Value);
                this.list_2.Add(node3.Attributes["Abbreviation"].Value);
            }
            XmlNode node2 = node.SelectSingleNode("Ratifying");
            if (node2 != null)
            {
                this.string_0 = node2.Attributes["Post"].Value;
                this.string_1 = node2.Attributes["Name"].Value;
            }
            node2 = node.SelectSingleNode("Signer");
            if (node2 != null)
            {
                this.string_2 = node2.Attributes["Post"].Value;
                this.string_3 = node2.Attributes["Name"].Value;
            }
            node2 = node.SelectSingleNode("Performer");
            if (node2 != null)
            {
                this.string_4 = node2.Attributes["Name"].Value;
            }
        }
        if (!this.bool_0)
        {
            switch (this.class410_0.TypeAction)
            {
                case 0:
                    this.method_3();
                    return;

                case 1:
                    this.method_2();
                    return;

                case 2:
                    this.method_1();
                    return;
            }
        }
        else
        {
            this.method_0();
        }
    }

    private void method_0()
    {
        this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Documents.Reports.ODSReport.rdlc";
        ReportDataSource item = new ReportDataSource {
            Name = "DataSet1",
            Value = this.bindingSource_7
        };
        this.reportViewer_0.LocalReport.DataSources.Add(item);
        if ((this.dateTime_0 != DateTime.MinValue) && (this.dateTime_1 != DateTime.MinValue))
        {
            string str = "";
            if (this.dateTime_0.Date == this.dateTime_1.Date)
            {
                str = "за " + this.dateTime_0.Date.ToString("dd.MM.yyyy");
            }
            else
            {
                str = "за период с " + this.dateTime_0.ToString("dd.MM.yyyy") + " по " + this.dateTime_1.ToString("dd.MM.yyyy");
            }
            ReportParameter parameter = new ReportParameter("period", str);
            this.reportViewer_0.LocalReport.SetParameters(parameter);
        }
        this.reportViewer_0.RefreshReport();
    }

    private void method_1()
    {
        object[] objArray1;
        IEnumerator enumerator;
        DataRow row2;
        this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Documents.Reports.ApplicationCancelReport.rdlc";
        if (this.class410_0.method_6())
        {
            using (enumerator = this.bindingSource_1.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    OrgDataSet.Class411 class2 = (OrgDataSet.Class411) ((DataRowView) enumerator.Current).Row;
                    DataRow row = this.orgDataSet_0.CancelReport1DataTable.NewRow();
                    if (!class2.method_48())
                    {
                        row[0] = class2.Code.ToString();
                        if (!class2.method_46())
                        {
                            row2 = row;
                            row2[0] = row2[0] + " от " + class2.DateDog.ToString("dd.MM.yyyy");
                        }
                    }
                    row[1] = class2.NameShort;
                    row[2] = class2.method_6();
                    DateTime time = Convert.ToDateTime(this.class202_0.vmethod_23(new int?(class2.method_8())));
                    row[3] = time.ToString("dd.MM.yyyy") + " c " + time.ToString("HH:mm");
                    row[4] = this.class204_0.vmethod_9(class2.Reason);
                    row[5] = "№" + class2.method_8().ToString() + " от " + Convert.ToDateTime(this.class202_0.vmethod_24(new int?(class2.method_8()))).ToString("dd.MM.yyyy");
                    this.orgDataSet_0.CancelReport1DataTable.Rows.Add(row);
                }
                goto Label_0384;
            }
        }
        using (enumerator = this.bindingSource_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                OrgDataSet.Class415 class3 = (OrgDataSet.Class415) ((DataRowView) enumerator.Current).Row;
                DataRow row3 = this.orgDataSet_0.CancelReport1DataTable.NewRow();
                if (!class3.method_46())
                {
                    row3[0] = class3.Code.ToString();
                    if (!class3.method_48())
                    {
                        row2 = row3;
                        row2[0] = row2[0] + " от " + class3.DateDog.ToString("dd.MM.yyyy");
                    }
                }
                if (!class3.method_30())
                {
                    row3[1] = class3.FIO;
                }
                row3[2] = class3.Address;
                DateTime time3 = Convert.ToDateTime(this.class202_0.vmethod_23(new int?(class3.method_4())));
                row3[3] = time3.ToString("dd.MM.yyyy") + " c " + time3.ToString("HH:mm");
                if (!class3.method_36())
                {
                    row3[4] = this.class204_0.vmethod_9(class3.Reason);
                }
                row3[5] = "№" + class3.method_4().ToString() + " от " + Convert.ToDateTime(this.class202_0.vmethod_24(new int?(class3.method_4()))).ToString("dd.MM.yyyy");
                this.orgDataSet_0.CancelReport1DataTable.Rows.Add(row3);
            }
        }
    Label_0384:
        objArray1 = new object[] { "№ ", this.class410_0.Id, " от ", this.class410_0.DateAppl.ToString("dd.MM.yyyy") };
        ReportParameter parameter = new ReportParameter("NumAndDateApplication", string.Concat(objArray1));
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("RatifyingName", this.string_1);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("RatifyingPost", this.string_0);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("SignerPost", this.string_2);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("SignerName", this.string_3);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("Performer", this.string_4);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        string str = "";
        if (this.list_0.Count > this.class410_0.NetArea)
        {
            str = this.list_0[this.class410_0.NetArea];
        }
        else
        {
            switch (this.class410_0.NetArea)
            {
                case 0:
                    str = "1 сетевой район";
                    break;

                case 1:
                    str = "2 сетевой район";
                    break;

                case 2:
                    str = "3 сетевой район";
                    break;

                case 3:
                    str = "4 сетевой район";
                    break;

                case 4:
                    str = "ОДС";
                    break;
            }
        }
        ReportParameter parameter2 = new ReportParameter("toExecuter", str);
        this.reportViewer_0.LocalReport.SetParameters(parameter2);
        ReportDataSource item = new ReportDataSource {
            Name = "CancelReport",
            Value = this.orgDataSet_0.CancelReport1DataTable
        };
        this.reportViewer_0.LocalReport.DataSources.Add(item);
        this.reportViewer_0.RefreshReport();
    }

    private void method_2()
    {
        object[] objArray1;
        IEnumerator enumerator;
        DataRow row2;
        this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Documents.Reports.ApplicationResumptionReport.rdlc";
        if (this.class410_0.method_6())
        {
            using (enumerator = this.bindingSource_1.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    OrgDataSet.Class411 class2 = (OrgDataSet.Class411) ((DataRowView) enumerator.Current).Row;
                    DataRow row = this.orgDataSet_0.Report1DataTable.NewRow();
                    if (!class2.method_48())
                    {
                        row[0] = class2.Code.ToString();
                        if (!class2.method_46())
                        {
                            row2 = row;
                            row2[0] = row2[0] + " от " + class2.DateDog.ToString("dd.MM.yyyy");
                        }
                    }
                    if (!class2.method_50())
                    {
                        row[1] = class2.NameShort;
                    }
                    if (!class2.method_52())
                    {
                        row[2] = class2.method_6();
                    }
                    if (!class2.method_40())
                    {
                        row[3] = class2.PlaceId;
                    }
                    if (!this.class410_0.method_18())
                    {
                        row[4] = this.class410_0.DateAction.ToString("dd.MM.yyyy") + " c " + this.class410_0.DateAction.ToString("HH:mm");
                    }
                    if (!class2.method_42())
                    {
                        row[5] = this.class204_0.vmethod_9(class2.Reason);
                    }
                    if (!class2.method_44())
                    {
                        row[6] = class2.Comments;
                    }
                    this.orgDataSet_0.Report1DataTable.Rows.Add(row);
                }
                goto Label_0363;
            }
        }
        using (enumerator = this.bindingSource_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                OrgDataSet.Class415 class3 = (OrgDataSet.Class415) ((DataRowView) enumerator.Current).Row;
                DataRow row3 = this.orgDataSet_0.Report1DataTable.NewRow();
                if (!class3.method_46())
                {
                    row3[0] = class3.Code.ToString();
                    if (!class3.method_48())
                    {
                        row2 = row3;
                        row2[0] = row2[0] + " от " + class3.DateDog.ToString("dd.MM.yyyy");
                    }
                }
                if (!class3.method_30())
                {
                    row3[1] = class3.FIO;
                }
                if (!class3.method_32())
                {
                    row3[2] = class3.Address;
                }
                if (!class3.method_52())
                {
                    row3[3] = class3.Point;
                }
                row3[4] = this.class410_0.DateAction.ToString("dd.MM.yyyy") + " c " + this.class410_0.DateAction.ToString("HH:mm");
                if (!class3.method_36())
                {
                    row3[5] = this.class204_0.vmethod_9(class3.Reason);
                }
                if (!class3.method_40())
                {
                    row3[6] = class3.Comments;
                }
                this.orgDataSet_0.Report1DataTable.Rows.Add(row3);
            }
        }
    Label_0363:
        objArray1 = new object[] { "№ ", this.class410_0.Id, " от ", this.class410_0.DateAppl.ToString("dd.MM.yyyy") };
        ReportParameter parameter = new ReportParameter("NumAndDateApplication", string.Concat(objArray1));
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("RatifyingName", this.string_1);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("RatifyingPost", this.string_0);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("SignerPost", this.string_2);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("SignerName", this.string_3);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("Performer", this.string_4);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        string str = "";
        if (this.list_1.Count > this.class410_0.NetArea)
        {
            str = this.list_1[this.class410_0.NetArea];
        }
        else
        {
            switch (this.class410_0.NetArea)
            {
                case 0:
                    str = "сетевого района №1";
                    break;

                case 1:
                    str = "сетевого района №2";
                    break;

                case 2:
                    str = "сетевого района №3";
                    break;

                case 3:
                    str = "сетевого района №4";
                    break;

                case 4:
                    str = "ОДС";
                    break;
            }
        }
        ReportParameter parameter2 = new ReportParameter("toExecuter", "Начальнику " + str + " произвести ВОЗОБНОВЛЕНИЕ");
        this.reportViewer_0.LocalReport.SetParameters(parameter2);
        this.reportViewer_0.RefreshReport();
    }

    private void method_3()
    {
        object[] objArray1;
        IEnumerator enumerator;
        DataRow row2;
        this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Documents.Reports.ApplicationReport.rdlc";
        if (this.class410_0.method_6())
        {
            using (enumerator = this.bindingSource_1.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    OrgDataSet.Class411 class2 = (OrgDataSet.Class411) ((DataRowView) enumerator.Current).Row;
                    DataRow row = this.orgDataSet_0.Report1DataTable.NewRow();
                    if (!class2.method_48())
                    {
                        row[0] = class2.Code.ToString();
                        if (!class2.method_46())
                        {
                            row2 = row;
                            row2[0] = row2[0] + " от " + class2.DateDog.ToString("dd.MM.yyyy");
                        }
                    }
                    if (!class2.method_50())
                    {
                        row[1] = class2.NameShort;
                    }
                    if (!class2.method_52())
                    {
                        row[2] = class2.method_6();
                    }
                    if (!class2.method_40())
                    {
                        row[3] = class2.PlaceId;
                    }
                    row[4] = this.class410_0.DateAction.ToString("dd.MM.yyyy") + " c " + this.class410_0.DateAction.ToString("HH:mm");
                    if (!class2.method_42())
                    {
                        row[5] = this.class204_0.vmethod_9(class2.Reason);
                    }
                    if (!class2.method_44())
                    {
                        row[6] = class2.Comments;
                    }
                    if (!class2.method_90())
                    {
                        if (class2.IsFullRestriction)
                        {
                            row[7] = "Полное";
                        }
                        else
                        {
                            row[7] = "Частичное";
                        }
                    }
                    this.orgDataSet_0.Report1DataTable.Rows.Add(row);
                }
                goto Label_03B2;
            }
        }
        using (enumerator = this.bindingSource_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                OrgDataSet.Class415 class3 = (OrgDataSet.Class415) ((DataRowView) enumerator.Current).Row;
                DataRow row3 = this.orgDataSet_0.Report1DataTable.NewRow();
                if (!class3.method_46())
                {
                    row3[0] = class3.Code.ToString();
                    if (!class3.method_48())
                    {
                        row2 = row3;
                        row2[0] = row2[0] + " от " + class3.DateDog.ToString("dd.MM.yyyy");
                    }
                }
                if (!class3.method_30())
                {
                    row3[1] = class3.FIO;
                }
                if (!class3.method_32())
                {
                    row3[2] = class3.Address;
                }
                if (!class3.method_34())
                {
                    row3[3] = class3.Point;
                }
                row3[4] = this.class410_0.DateAction.ToString("dd.MM.yyyy") + " c " + this.class410_0.DateAction.ToString("HH:mm");
                if (!class3.method_36())
                {
                    row3[5] = this.class204_0.vmethod_9(class3.Reason);
                }
                if (!class3.method_40())
                {
                    row3[6] = class3.Comments;
                }
                if (!class3.method_84())
                {
                    if (class3.IsFullRestriction)
                    {
                        row3[7] = "Полное";
                    }
                    else
                    {
                        row3[7] = "Частичное";
                    }
                }
                this.orgDataSet_0.Report1DataTable.Rows.Add(row3);
            }
        }
    Label_03B2:
        objArray1 = new object[] { "№ ", this.class410_0.Id, " от ", this.class410_0.DateAppl.ToString("dd.MM.yyyy") };
        ReportParameter parameter = new ReportParameter("NumAndDateApplication", string.Concat(objArray1));
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("RatifyingName", this.string_1);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("RatifyingPost", this.string_0);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("SignerPost", this.string_2);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("SignerName", this.string_3);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        parameter = new ReportParameter("Performer", this.string_4);
        this.reportViewer_0.LocalReport.SetParameters(parameter);
        string str = "";
        if (this.list_1.Count > this.class410_0.NetArea)
        {
            str = this.list_1[this.class410_0.NetArea];
        }
        else
        {
            switch (this.class410_0.NetArea)
            {
                case 0:
                    str = "сетевого района 1";
                    break;

                case 1:
                    str = "сетевого района 2";
                    break;

                case 2:
                    str = "сетевого района 3";
                    break;

                case 3:
                    str = "сетевого района 4";
                    break;

                case 4:
                    str = "ОДС";
                    break;
            }
        }
        ReportParameter parameter2 = new ReportParameter("toExecuter", "Начальнику " + str + " произвести ОТКЛЮЧЕНИЕ");
        this.reportViewer_0.LocalReport.SetParameters(parameter2);
        this.reportViewer_0.RefreshReport();
    }

    private void method_4()
    {
        this.icontainer_0 = new Container();
        ReportDataSource item = new ReportDataSource();
        this.bindingSource_4 = new BindingSource(this.icontainer_0);
        this.orgDataSet_0 = new OrgDataSet();
        this.reportViewer_0 = new ReportViewer();
        this.bindingSource_1 = new BindingSource(this.icontainer_0);
        this.class203_0 = new Class203();
        this.bindingSource_2 = new BindingSource(this.icontainer_0);
        this.class204_0 = new Class204();
        this.bindingSource_0 = new BindingSource(this.icontainer_0);
        this.class207_0 = new Class207();
        this.bindingSource_3 = new BindingSource(this.icontainer_0);
        this.class211_0 = new Class211();
        this.bindingSource_5 = new BindingSource(this.icontainer_0);
        this.bindingSource_6 = new BindingSource(this.icontainer_0);
        this.class202_0 = new Class202();
        this.bindingSource_7 = new BindingSource(this.icontainer_0);
        ((ISupportInitialize) this.bindingSource_4).BeginInit();
        this.orgDataSet_0.BeginInit();
        ((ISupportInitialize) this.bindingSource_1).BeginInit();
        ((ISupportInitialize) this.bindingSource_2).BeginInit();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        ((ISupportInitialize) this.bindingSource_3).BeginInit();
        ((ISupportInitialize) this.bindingSource_5).BeginInit();
        ((ISupportInitialize) this.bindingSource_6).BeginInit();
        ((ISupportInitialize) this.bindingSource_7).BeginInit();
        base.SuspendLayout();
        this.bindingSource_4.DataMember = "Report1DataTable";
        this.bindingSource_4.DataSource = this.orgDataSet_0;
        this.orgDataSet_0.DataSetName = "OrgDataSet";
        this.orgDataSet_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.reportViewer_0.Dock = DockStyle.Fill;
        item.Name = "Reptab";
        item.Value = this.bindingSource_4;
        this.reportViewer_0.LocalReport.DataSources.Add(item);
        this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Documents.Reports.ApplicationReport.rdlc";
        this.reportViewer_0.Location = new Point(0, 0);
        this.reportViewer_0.Name = "reportViewer1";
        this.reportViewer_0.Size = new Size(0x2d7, 0x20d);
        this.reportViewer_0.TabIndex = 0;
        this.bindingSource_1.DataMember = "tblAbnAplForDisconObjects";
        this.bindingSource_1.DataSource = this.orgDataSet_0;
        this.class203_0.method_7(true);
        this.bindingSource_2.DataMember = "tblAbnAplForDisconReason";
        this.bindingSource_2.DataSource = this.orgDataSet_0;
        this.class204_0.method_7(true);
        this.bindingSource_0.DataMember = "tblAbnAplForDisconIndividualUsers";
        this.bindingSource_0.DataSource = this.orgDataSet_0;
        this.class207_0.method_7(true);
        this.bindingSource_3.DataMember = "tblAbnAplConnectPointForIndividualUsers";
        this.bindingSource_3.DataSource = this.orgDataSet_0;
        this.class211_0.method_7(true);
        this.bindingSource_5.DataMember = "CancelReport1DataTable";
        this.bindingSource_5.DataSource = this.orgDataSet_0;
        this.bindingSource_6.DataMember = "tblAbnAplForDiscon";
        this.bindingSource_6.DataSource = this.orgDataSet_0;
        this.class202_0.method_7(true);
        this.bindingSource_7.DataMember = "ReportODS";
        this.bindingSource_7.DataSource = this.orgDataSet_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x2d7, 0x20d);
        base.Controls.Add(this.reportViewer_0);
        base.Name = "FormLegalApplReport";
        this.Text = "Печатная форма";
        base.Load += new EventHandler(this.Form5_Load);
        ((ISupportInitialize) this.bindingSource_4).EndInit();
        this.orgDataSet_0.EndInit();
        ((ISupportInitialize) this.bindingSource_1).EndInit();
        ((ISupportInitialize) this.bindingSource_2).EndInit();
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        ((ISupportInitialize) this.bindingSource_3).EndInit();
        ((ISupportInitialize) this.bindingSource_5).EndInit();
        ((ISupportInitialize) this.bindingSource_6).EndInit();
        ((ISupportInitialize) this.bindingSource_7).EndInit();
        base.ResumeLayout(false);
    }
}

