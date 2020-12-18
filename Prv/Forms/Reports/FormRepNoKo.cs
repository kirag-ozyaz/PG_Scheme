using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Reporting.WinForms;

namespace Prv.Forms.Reports
{
	internal partial class FormRepNoKo : FormLbr.FormBase
	{
		public FormRepNoKo()
		{
			InitializeComponent();
		}


		public FormRepNoKo(DataSets.DataSetRep ds, bool isDetail = false)
		{
			InitializeComponent();

            if (isDetail)
            {
                reportViewer.LocalReport.DataSources[0].Name = "DataSetRep_RepActDetail";
                this.reportViewer.LocalReport.ReportEmbeddedResource = "Prv.FileReports.ReportNoKoDetail.rdlc";
                this.bindingSource.DataMember = "RepActDetail";
            }

            if (isDetail)
                for (int i = 0; i < ds.RepActDetail.Rows.Count; i++)
                    dsRep.RepActDetail.ImportRow(ds.RepActDetail.Rows[i]);
            else
                for (int i = 0; i < ds.RepAct.Rows.Count; i++)
                    dsRep.RepAct.ImportRow(ds.RepAct.Rows[i]);
		}

        private void FormRepNoKo_Load(object sender, EventArgs e)
        {
            this.LoadFormConfig();

            ReportParameter p = new ReportParameter("Seti", textBoxSet.Text);
            reportViewer.LocalReport.SetParameters(new ReportParameter[] { p });

            if (dsRep.RepAct.Rows.Count > 0)
            {
                ReportParameter n = new ReportParameter("NumberAct", dsRep.RepAct.Rows[0]["NumberAct"].ToString());
                reportViewer.LocalReport.SetParameters(new ReportParameter[] { n });

                ReportParameter d = new ReportParameter("DateAct", Convert.ToDateTime(dsRep.RepAct.Rows[0]["DateAct"]).ToShortDateString());
                reportViewer.LocalReport.SetParameters(new ReportParameter[] { d });
            }

            this.reportViewer.RefreshReport();
        }

        private void FormRepNoKo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveFormConfig();
        }

        protected override void ApplyConfig(System.Xml.XmlDocument doc)
        {

            XmlNode node = doc.SelectSingleNode("Settings");
            if (node != null)
            {
                XmlAttribute atr = node.Attributes["Seti"];
                if (atr != null) textBoxSet.Text = atr.Value;
            }
        }
        protected override System.Xml.XmlDocument CreateXmlConfig()
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            XmlNode formnode = doc.CreateElement("Settings");
            doc.AppendChild(formnode);

            XmlAttribute attr = doc.CreateAttribute("Seti");
            attr.Value = textBoxSet.Text;
            formnode.Attributes.Append(attr);

            return doc;
        }

        private void textBoxSet_TextChanged(object sender, EventArgs e)
        {
            ReportParameter p = new ReportParameter("Seti", textBoxSet.Text);
            reportViewer.LocalReport.SetParameters(new ReportParameter[] { p });

            this.reportViewer.RefreshReport();
        }
	}
}
