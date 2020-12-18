namespace Documents
{
    using Microsoft.Reporting.WinForms;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class ReportForm : Form
    {
        private DataTable dataTable_0;
        private IContainer icontainer_0;
        private ReportViewer rptViewer;

        public ReportForm(DataTable dataTable_1)
        {
            this.dataTable_0 = dataTable_1;
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rptViewer = new ReportViewer();
            base.SuspendLayout();
            this.rptViewer.Dock = DockStyle.Fill;
            this.rptViewer.LocalReport.DisplayName = "Расчет потерь";
            this.rptViewer.LocalReport.ReportEmbeddedResource = "Documents.Reports.Report.rdlc";
            this.rptViewer.Location = new Point(0, 0);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ShowBackButton = false;
            this.rptViewer.ShowDocumentMapButton = false;
            this.rptViewer.ShowFindControls = false;
            this.rptViewer.ShowPageNavigationControls = false;
            this.rptViewer.Size = new Size(0x293, 0x159);
            this.rptViewer.TabIndex = 0;
            this.rptViewer.ReportRefresh += new CancelEventHandler(this.rptViewer_ReportRefresh);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x293, 0x159);
            base.Controls.Add(this.rptViewer);
            base.Name = "ReportForm";
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            this.Text = "Расчет потерь 0,4кВ";
            base.Load += new EventHandler(this.ReportForm_Load);
            base.ResumeLayout(false);
        }

        private void method_0(object sender, EventArgs e)
        {
            base.Close();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.rptViewer.Reset();
            this.rptViewer.LocalReport.DataSources.Clear();
            this.rptViewer.ProcessingMode = ProcessingMode.Local;
            this.rptViewer.LocalReport.ReportEmbeddedResource = "Documents.Reports.Report.rdlc";
            string str = this.dataTable_0.Select("NameValue = 'AverageVoltage'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray());
            this.Text = "Расчет потерь " + str + "кВ " + this.dataTable_0.Select("NameValue = 'AbnName'")[0]["Val"].ToString().Trim();
            try
            {
                ReportParameter parameter = new ReportParameter("AbnName", this.dataTable_0.Select("NameValue = 'AbnName'")[0]["Val"].ToString().Trim());
                ReportParameter[] parameters = new ReportParameter[] { parameter };
                this.rptViewer.LocalReport.SetParameters(parameters);
                parameter = new ReportParameter("AverageVoltage", str);
                ReportParameter[] parameterArray2 = new ReportParameter[] { parameter };
                this.rptViewer.LocalReport.SetParameters(parameterArray2);
                string[] textArray1 = new string[] { this.dataTable_0.Select("NameValue = 'ElectricalResistance'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " * ", this.dataTable_0.Select("NameValue = 'LineLength'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " / ", this.dataTable_0.Select("NameValue = 'CountCepey'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " = ", this.dataTable_0.Select("NameValue = 'ActiveResistance'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " Ом" };
                string str2 = string.Concat(textArray1);
                parameter = new ReportParameter("ActiveResistance", str2);
                ReportParameter[] parameterArray3 = new ReportParameter[] { parameter };
                this.rptViewer.LocalReport.SetParameters(parameterArray3);
                string[] textArray2 = new string[] { this.dataTable_0.Select("NameValue = 'Consumption'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " * 0,001 / ", this.dataTable_0.Select("NameValue = 'Period'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " = ", this.dataTable_0.Select("NameValue = 'LoadAverage'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " МВт" };
                string str3 = string.Concat(textArray2);
                parameter = new ReportParameter("LoadAverage", str3);
                ReportParameter[] parameterArray4 = new ReportParameter[] { parameter };
                this.rptViewer.LocalReport.SetParameters(parameterArray4);
                string[] textArray3 = new string[] { this.dataTable_0.Select("NameValue = 'LoadAverage'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), "\x00b2 * (1 + ", this.dataTable_0.Select("NameValue = 'CoefficientPowerReactive'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), "\x00b2 ) * ", this.dataTable_0.Select("NameValue = 'ActiveResistance'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " * 10\x00b3 / ", this.dataTable_0.Select("NameValue = 'AverageVoltage'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), "\x00b2 = ", this.dataTable_0.Select("NameValue = 'LoadPowerLoss'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " кВт" };
                string str4 = string.Concat(textArray3);
                parameter = new ReportParameter("LoadPowerLoss1", str4);
                ReportParameter[] parameterArray5 = new ReportParameter[] { parameter };
                this.rptViewer.LocalReport.SetParameters(parameterArray5);
                parameter = new ReportParameter("LoadPowerLoss2", " ");
                ReportParameter[] parameterArray6 = new ReportParameter[] { parameter };
                this.rptViewer.LocalReport.SetParameters(parameterArray6);
                string[] textArray4 = new string[] { this.dataTable_0.Select("NameValue = 'CoefficientDifferences'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " * ", this.dataTable_0.Select("NameValue = 'LoadPowerLoss'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " * ", this.dataTable_0.Select("NameValue = 'Period'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " * ", this.dataTable_0.Select("NameValue = 'SquareCoefficientFormGraphics'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " = ", this.dataTable_0.Select("NameValue = 'LoadLosses'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " МВт" };
                string str5 = string.Concat(textArray4);
                parameter = new ReportParameter("LoadLosses1", str5);
                ReportParameter[] parameterArray7 = new ReportParameter[] { parameter };
                this.rptViewer.LocalReport.SetParameters(parameterArray7);
                parameter = new ReportParameter("LoadLosses2", " ");
                ReportParameter[] parameterArray8 = new ReportParameter[] { parameter };
                this.rptViewer.LocalReport.SetParameters(parameterArray8);
                string[] textArray5 = new string[] { this.dataTable_0.Select("NameValue = 'LoadLosses'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " * 100% / ", this.dataTable_0.Select("NameValue = 'Consumption'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), " = ", this.dataTable_0.Select("NameValue = 'CoefficientLoss'")[0]["Val"].ToString().TrimEnd(",0".ToCharArray()), "%" };
                string str6 = string.Concat(textArray5);
                parameter = new ReportParameter("CoefficientLoss", str6);
                ReportParameter[] parameterArray9 = new ReportParameter[] { parameter };
                this.rptViewer.LocalReport.SetParameters(parameterArray9);
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString());
            }
            ReportDataSource item = new ReportDataSource {
                Name = "Data",
                Value = this.dataTable_0.Select("Status = 'i'").CopyToDataTable<DataRow>()
            };
            this.rptViewer.LocalReport.DataSources.Add(item);
            this.rptViewer.RefreshReport();
        }

        private void rptViewer_ReportRefresh(object sender, CancelEventArgs e)
        {
            this.ReportForm_Load(sender, null);
        }
    }
}

