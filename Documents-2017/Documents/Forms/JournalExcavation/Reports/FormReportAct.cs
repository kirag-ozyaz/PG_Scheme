namespace Documents.Forms.JournalExcavation.Reports
{
    using ControlsLbr.ReportViewerRus;
    using Documents.Forms.JournalExcavation;
    using FormLbr;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormReportAct : FormBase
    {
        private BindingSource bindingSource_0;
        private DataSetExcavation dataSetExcavation_0;
        private IContainer icontainer_0;
        private int int_0;
        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus_0;

        public FormReportAct()
        {
            this.int_0 = -1;
            this.method_0();
        }

        public FormReportAct(int idEx)
        {
            this.int_0 = -1;
            this.method_0();
            this.int_0 = idEx;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormReportAct_Load(object sender, EventArgs e)
        {
            DataSetExcavation.vJ_ExcavationSurfaceDataTable table = new DataSetExcavation.vJ_ExcavationSurfaceDataTable();
            base.SelectSqlData(table, true, " where idExcavation = " + this.int_0.ToString() + " and idType = " + 2.ToString(), false);
            this.bindingSource_0.DataSource = table;
            int num = 3;
            DataTable table2 = base.SelectSqlData("vj_excavationSurface", true, " where idExcavation = " + this.int_0.ToString() + " and idType = " + num.ToString());
            string str = string.Empty;
            foreach (DataRow row in table2.Rows)
            {
                if (!string.IsNullOrEmpty(str))
                {
                    str = str + "; ";
                }
                string[] textArray1 = new string[] { str, row["surName"].ToString(), ": ", row["Value"].ToString(), " ", row["Unit"].ToString() };
                str = string.Concat(textArray1);
            }
            ReportParameter parameter = new ReportParameter("Material", str);
            ReportParameter[] parameters = new ReportParameter[] { parameter };
            this.reportViewerRus_0.LocalReport.SetParameters(parameters);
            table2 = base.SelectSqlData("vj_excavationschmObj", true, " where idExcavation = " + this.int_0.ToString());
            string str2 = string.Empty;
            foreach (DataRow row2 in table2.Rows)
            {
                if (!string.IsNullOrEmpty(str2))
                {
                    str2 = str2 + "; ";
                }
                str2 = str2 + row2["name"].ToString();
            }
            ReportParameter parameter2 = new ReportParameter("Cable", str2);
            ReportParameter[] parameterArray2 = new ReportParameter[] { parameter2 };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray2);
            table2 = base.SelectSqlData("vj_excavation", true, " where id = " + this.int_0.ToString());
            if (table2.Rows.Count > 0)
            {
                if (table2.Rows[0]["typeWorkName"] != DBNull.Value)
                {
                    ReportParameter parameter4 = new ReportParameter("typeWork", table2.Rows[0]["typeWorkName"].ToString());
                    ReportParameter[] parameterArray3 = new ReportParameter[] { parameter4 };
                    this.reportViewerRus_0.LocalReport.SetParameters(parameterArray3);
                }
                Dictionary<int, int> dictionary = new Dictionary<int, int> {
                    { 
                        0x2f7,
                        4
                    },
                    { 
                        0x2f5,
                        2
                    },
                    { 
                        0x2f4,
                        1
                    },
                    { 
                        0x2f6,
                        3
                    }
                };
                Dictionary<int, string> dictionary2 = new Dictionary<int, string> {
                    { 
                        0x2f7,
                        "Исаев В.М."
                    },
                    { 
                        0x2f5,
                        "Рябов Д.А."
                    },
                    { 
                        0x2f4,
                        "Куфтырев Д.В."
                    },
                    { 
                        0x2f6,
                        "Савинов Ю.М."
                    }
                };
                if (table2.Rows.Count > 0)
                {
                    if (table2.Rows[0]["idSR"] == DBNull.Value)
                    {
                        MessageBox.Show("Не введен сетевой район");
                    }
                    else
                    {
                        try
                        {
                            int num2 = Convert.ToInt32(table2.Rows[0]["idSR"]);
                            num = dictionary[num2];
                            ReportParameter parameter5 = new ReportParameter("sr", num.ToString());
                            ReportParameter[] parameterArray4 = new ReportParameter[] { parameter5 };
                            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray4);
                            ReportParameter parameter6 = new ReportParameter("chieff", dictionary2[num2]);
                            ReportParameter[] parameterArray5 = new ReportParameter[] { parameter6 };
                            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray5);
                        }
                        catch
                        {
                        }
                    }
                }
            }
            table2 = base.SelectSqlData("vj_excavationaddress", true, " where idExcavation = " + this.int_0.ToString());
            string str3 = string.Empty;
            foreach (DataRow row3 in table2.Rows)
            {
                if (!string.IsNullOrEmpty(str3))
                {
                    str3 = str3 + "; ";
                }
                str3 = str3 + row3["street"].ToString() + ", " + row3["house"].ToString();
            }
            ReportParameter parameter3 = new ReportParameter("Address", str3);
            ReportParameter[] parameterArray6 = new ReportParameter[] { parameter3 };
            this.reportViewerRus_0.LocalReport.SetParameters(parameterArray6);
            this.reportViewerRus_0.RefreshReport();
        }

        private void method_0()
        {
            this.icontainer_0 = new Container();
            ReportDataSource item = new ReportDataSource();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormReportAct));
            this.reportViewerRus_0 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.dataSetExcavation_0 = new DataSetExcavation();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetExcavation_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            base.SuspendLayout();
            this.reportViewerRus_0.Dock = DockStyle.Fill;
            item.Name = "DataSetRecovery";
            item.Value = this.bindingSource_0;
            this.reportViewerRus_0.LocalReport.DataSources.Add(item);
            this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalExcavation.Reports.ReportExcavationAct.rdlc";
            this.reportViewerRus_0.Location = new Point(0, 0);
            this.reportViewerRus_0.Name = "reportViewerRus1";
            this.reportViewerRus_0.Size = new Size(0x29b, 0x19e);
            this.reportViewerRus_0.TabIndex = 0;
            this.dataSetExcavation_0.DataSetName = "DataSetExcavation";
            this.dataSetExcavation_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x29b, 0x19e);
            base.Controls.Add(this.reportViewerRus_0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "FormReportAct";
            this.Text = "Акт передачи раскопок под асфальтирование";
            base.Load += new EventHandler(this.FormReportAct_Load);
            this.dataSetExcavation_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            base.ResumeLayout(false);
        }
    }
}

