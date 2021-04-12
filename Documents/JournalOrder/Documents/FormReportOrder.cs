using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;
using Microsoft.Reporting.WinForms;
namespace JournalOrder
{
    internal partial class FormReportOrder : FormBase
    {
        private int idOrder = -1;
        internal FormReportOrder()
        {
            this.InitializeComponent();
        }

        internal FormReportOrder(int id)
        {
            this.InitializeComponent();
            this.idOrder = id;
            this.reportViewer1.LocalReport.SubreportProcessing += this.LocalReport_SubreportProcessing;
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
        }

        private void FormReportOrder_Load(object sender, EventArgs e)
        {
            base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.tJ_Order, true, " where id = " + this.idOrder.ToString());
            base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.vJ_Order, true, " where id = " + this.idOrder.ToString());
            base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderBrigade, true, " where idorder = " + this.idOrder.ToString());
            string text = "";
            foreach (DataRow dataRow in this.dataSetOrder.tJ_OrderBrigade.Rows)
            {
                text = text + dataRow["idWorker"].ToString() + ",";
            }
            if (!string.IsNullOrEmpty(text))
            {
                text = text.Remove(text.Length - 1);
                base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.vR_Worker, true, " where id in (" + text + ")");
            }
            string text2 = "";
            foreach (DataRow dataRow2 in this.dataSetOrder.vR_Worker)
            {
                string str = "";
                if (dataRow2["GroupElectrical"] != DBNull.Value)
                {
                    switch (Convert.ToInt32(dataRow2["GroupElectrical"]))
                    {
                        case 1:
                            str = " I гр.";
                            break;
                        case 2:
                            str = " II гр.";
                            break;
                        case 3:
                            str = " III гр.";
                            break;
                        case 4:
                            str = " IV гр.";
                            break;
                        case 5:
                            str = " V гр.";
                            break;
                    }
                }
                text2 = text2 + dataRow2["FIO"].ToString() + str + ",";
            }
            if (!string.IsNullOrEmpty(text2))
            {
                text2 = text2.Remove(text2.Length - 1);
            }
            ReportParameter reportParameter = new ReportParameter("Brigade", text2);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            {
            reportParameter
            });
            base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderInstruction, true, " where idorder = " + this.idOrder.ToString() + " order by rec_num");
            base.SelectSqlData(this.dataSetOrder, this.dataSetOrder.tJ_OrderResolution, true, " where idorder = " + this.idOrder.ToString() + " order by datebegin ");
            this.reportViewer1.RefreshReport();
        }

        private void DemoSubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
        }


    }
}