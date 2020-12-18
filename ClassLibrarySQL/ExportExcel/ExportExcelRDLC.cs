using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataSql;

namespace Library
{
    /// <summary>
    /// Экспорт в эксель с помощю repotyviewer (rdlc)
    /// </summary>
    public class ExportExcelRDLC
    {
        // таблица данных
        DataTable Table  { get; set; }
        // таблица rdlc, в которую  прогружаем Table
        string ReportEmbeddedResource { get; set; }
        string FileName { get; set; }
        string OutFormatFile { get; set; }

        public void CreateExcel()
        {
            DataTable tableReport = Table;
            // найти имя конечного файла
            string fileOut = this.FileName;
            string outFormatFile = this.OutFormatFile;
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.RestoreDirectory = true;
            dlg.Filter = "PDF|*.pdf|Excel|*.xls|Word|*.doc";
            dlg.FileName = Path.GetFileName(fileOut);
            dlg.OverwritePrompt = true;
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = dlg.FileName;
            CreateExcel(tableReport, filename, Path.GetExtension(filename).Substring(1));
        }
        /// <summary>
        /// создадим файл
        /// </summary>
        /// <param name="tableDamage"></param>
        /// <returns></returns>
        public string CreateExcel(DataTable tableDamage, string fileOut = "", string outFormatFile = null)
        {
            if (outFormatFile == null)
            {
                outFormatFile = Path.GetExtension(fileOut).Substring(1);
            }


            string typeOutFile = "";
            string typeFile = "";
            if (outFormatFile == null || outFormatFile.ToUpper() == "PDF")
            {
                typeOutFile = "PDF";
                typeFile = "PDF";
            }
            else if (outFormatFile == "Excel" || outFormatFile.ToUpper() == "XLS")
            {
                typeOutFile = "xls";
                typeFile = "Excel";
            }
            else if (outFormatFile == "Word" || outFormatFile.ToUpper() == "DOC")
            {
                typeOutFile = "doc";
                typeFile = "Word";
            }
            else
                return "";

            string temp_path = fileOut;
            try
            {

                Warning[] warnings;
                string deviceInfo =
                "<DeviceInfo>" +
                " <OutputFormat>" + typeOutFile + "</OutputFormat>" +
                " <PageWidth>9.5in</PageWidth>" +
                " <PageHeight>8.5in</PageHeight>" +
                " <MarginTop>0.05in</MarginTop>" +
                " <MarginLeft>0.05in</MarginLeft>" +
                " <MarginRight>0.05in</MarginRight>" +
                " <MarginBottom>0.05in</MarginBottom>" +
                "</DeviceInfo>";
                string[] streamIds;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                // Setup the report viewer object and get the array of bytes
                ReportViewer viewer = new ReportViewer();
                viewer.ProcessingMode = ProcessingMode.Local;
                viewer.LocalReport.ReportEmbeddedResource = ReportEmbeddedResource;
                //string dateReport = DataEnd.ToString("dd.MM.yyyy");
                //string Period = "( c " + DataBeg.ToLongDateString() + " " + TimeBeg.Hours.ToString("D2") + ":" + TimeBeg.Minutes.ToString("D2") + " по " + DataEnd.ToLongDateString() + " " + TimeEnd.Hours.ToString("D2") + ":" + TimeEnd.Minutes.ToString("D2") + " " + ")";

                //viewer.LocalReport.SetParameters(new ReportParameter("dateReport", dateReport));
                //viewer.LocalReport.SetParameters(new ReportParameter("User", GetCurrentUser()));
                //viewer.LocalReport.SetParameters(new ReportParameter("dateEnd", DataEnd.ToLongDateString()));
                //viewer.LocalReport.SetParameters(new ReportParameter("Period", Period));

                //viewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetReportToManager", tableDamage));

                byte[] bytes = viewer.LocalReport.Render(typeFile, deviceInfo, out mimeType,
                                                          out encoding, out extension,
                                                          out streamIds, out warnings);

                // Prepare filename and save_path, and then write the Excel using FileStream.
                // какая-то хрень млять
                string fileName = "report_other." + typeOutFile;
                temp_path = Path.Combine(System.IO.Path.GetTempPath(), fileName);
                if (fileOut != "")
                    temp_path = fileOut;

                try
                {
                    temp_path = Path.ChangeExtension(temp_path, typeOutFile);
                    FileStream fs = new FileStream(temp_path, FileMode.Create);
                    fs.Write(bytes, 0, bytes.Length);
                    fs.Close();
                }
                catch
                {
                    temp_path = Path.Combine(System.IO.Path.GetTempPath(), fileName);
                    FileStream fs = new FileStream(temp_path, FileMode.Create);
                    fs.Write(bytes, 0, bytes.Length);
                    fs.Close();
                }

            }
            catch
            {
                temp_path = "";
            }
            return temp_path;
        }  
    }
}
