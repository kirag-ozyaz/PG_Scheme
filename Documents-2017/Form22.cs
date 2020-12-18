using Documents.DataSets;
using FormLbr;
using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal class Form22 : FormBase
{
    private BindingSource bindingSource_0;
    private BindingSource bindingSource_1;
    private DataSetOrder dataSetOrder_0;
    private IContainer icontainer_0;
    private int int_0;
    private ReportViewer reportViewer_0;

    internal Form22()
    {
        this.int_0 = -1;
        this.method_2();
    }

    internal Form22(int int_1)
    {
        this.int_0 = -1;
        this.method_2();
        this.int_0 = int_1;
        this.reportViewer_0.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(this.method_0);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form22_Load(object sender, EventArgs e)
    {
        base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_Order, true, " where id = " + this.int_0.ToString());
        base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.vJ_Order, true, " where id = " + this.int_0.ToString());
        base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderBrigade, true, " where idorder = " + this.int_0.ToString());
        string str = "";
        foreach (DataRow row in this.dataSetOrder_0.tJ_OrderBrigade.Rows)
        {
            str = str + row["idWorker"].ToString() + ",";
        }
        if (!string.IsNullOrEmpty(str))
        {
            base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.vR_Worker, true, " where id in (" + str.Remove(str.Length - 1) + ")");
        }
        string str2 = "";
        foreach (DataRow row2 in this.dataSetOrder_0.vR_Worker)
        {
            string str3 = "";
            if (row2["GroupElectrical"] != DBNull.Value)
            {
                switch (Convert.ToInt32(row2["GroupElectrical"]))
                {
                    case 1:
                        str3 = " I гр.";
                        break;

                    case 2:
                        str3 = " II гр.";
                        break;

                    case 3:
                        str3 = " III гр.";
                        break;

                    case 4:
                        str3 = " IV гр.";
                        break;

                    case 5:
                        str3 = " V гр.";
                        break;
                }
            }
            str2 = str2 + row2["FIO"].ToString() + str3 + ",";
        }
        if (!string.IsNullOrEmpty(str2))
        {
            str2 = str2.Remove(str2.Length - 1);
        }
        ReportParameter parameter = new ReportParameter("Brigade", str2);
        ReportParameter[] parameters = new ReportParameter[] { parameter };
        this.reportViewer_0.LocalReport.SetParameters(parameters);
        base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderInstruction, true, " where idorder = " + this.int_0.ToString() + " order by rec_num");
        base.SelectSqlData(this.dataSetOrder_0, this.dataSetOrder_0.tJ_OrderResolution, true, " where idorder = " + this.int_0.ToString() + " order by datebegin ");
        this.reportViewer_0.RefreshReport();
    }

    private void method_0(object sender, SubreportProcessingEventArgs e)
    {
    }

    private void method_1(object sender, SubreportProcessingEventArgs e)
    {
    }

    private void method_2()
    {
        this.icontainer_0 = new Container();
        ReportDataSource item = new ReportDataSource();
        ReportDataSource source2 = new ReportDataSource();
        this.bindingSource_0 = new BindingSource(this.icontainer_0);
        this.dataSetOrder_0 = new DataSetOrder();
        this.bindingSource_1 = new BindingSource(this.icontainer_0);
        this.reportViewer_0 = new ReportViewer();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        this.dataSetOrder_0.BeginInit();
        ((ISupportInitialize) this.bindingSource_1).BeginInit();
        base.SuspendLayout();
        this.bindingSource_0.DataMember = "vJ_Order";
        this.bindingSource_0.DataSource = this.dataSetOrder_0;
        this.dataSetOrder_0.DataSetName = "DataSetOrder";
        this.dataSetOrder_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.bindingSource_1.DataMember = "tJ_OrderInstruction";
        this.bindingSource_1.DataSource = this.dataSetOrder_0;
        this.reportViewer_0.Dock = DockStyle.Fill;
        item.Name = "vJ_Order";
        item.Value = this.bindingSource_0;
        source2.Name = "tJ_OrderInstruction";
        source2.Value = this.bindingSource_1;
        this.reportViewer_0.LocalReport.DataSources.Add(item);
        this.reportViewer_0.LocalReport.DataSources.Add(source2);
        this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Documents.Reports.ReportOrder.rdlc";
        this.reportViewer_0.Location = new Point(0, 0);
        this.reportViewer_0.Name = "reportViewer1";
        this.reportViewer_0.Size = new Size(0x25f, 430);
        this.reportViewer_0.TabIndex = 0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x25f, 430);
        base.Controls.Add(this.reportViewer_0);
        base.Name = "FormReportOrder";
        this.Text = "FormReportOrder";
        base.Load += new EventHandler(this.Form22_Load);
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        this.dataSetOrder_0.EndInit();
        ((ISupportInitialize) this.bindingSource_1).EndInit();
        base.ResumeLayout(false);
    }
}

