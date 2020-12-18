using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace Library
{
    /// <summary>
    /// Выгрузка в Excel - формат xml
    /// </summary>
    public static class ExportToExcel
    {

        #region Выгрузка в Excel - формат xml
        private static string _Newline = "\n";
        private static readonly string fileName = "report_heads.xls";
        public static void Create(DataTable dt, DateTime dateBeg, DateTime dateEnd)
        {
            //DataTable dt = this.LoadData(date, date);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(ExcelHeader());
            stringBuilder.Append(ExcelStyles());
            stringBuilder.Append(WriteFirstWorkSheet(dt, dateBeg, dateEnd));
            stringBuilder.Append(ExcelWorkSheetOptions());
            stringBuilder.Append("</Workbook>\n");
            UtilsFile.WriteToFile(fileName, stringBuilder, Encoding.Unicode, true);
        }
        private static string ExcelHeader()
        {
            // StartHeader
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<?xml version=\"1.0\"?>\n");
            stringBuilder.Append("<?mso-application progid=\"Excel.Sheet\"?>\n");
            stringBuilder.Append("<Workbook xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\" ");
            stringBuilder.Append("xmlns:o=\"urn:schemas-microsoft-com:office:office\" ");
            stringBuilder.Append("xmlns:x=\"urn:schemas-microsoft-com:office:excel\" ");
            stringBuilder.Append("xmlns:ss=\"urn:schemas-microsoft-com:office:spreadsheet\" ");
            stringBuilder.Append("xmlns:html=\"http://www.w3.org/TR/REC-html40\">\n");
            
            // DocumentProperties
            stringBuilder.Append("<DocumentProperties xmlns=\"urn:schemas-microsoft-com:office:office\">");
            stringBuilder.Append("<Author>Ulges</Author>");
            stringBuilder.Append("</DocumentProperties>");
            
            //ExcelWorkbook
            stringBuilder.Append("<ExcelWorkbook xmlns=\"urn:schemas-microsoft-com:office:excel\">\n");
            stringBuilder.Append("<ProtectStructure>False</ProtectStructure>\n");
            stringBuilder.Append("<ProtectWindows>False</ProtectWindows>\n");
            stringBuilder.Append("</ExcelWorkbook>\n");
            return stringBuilder.ToString();
        }
        /// <summary>
        /// стили ячеек
        /// </summary>
        /// <returns></returns>
        private static string ExcelStyles()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<Styles>" + _Newline);

            stringBuilder.Append("<Style ss:ID=\"Default\" ss:Name=\"Normal\">" + _Newline);
            stringBuilder.Append("<Alignment ss:Vertical=\"Bottom\"/>" + _Newline);
            stringBuilder.Append("<Font/><Interior/><NumberFormat/> <Protection/>" + _Newline);
            stringBuilder.Append("</Style>" + _Newline);

            stringBuilder.Append("<Style ss:ID=\"sTitle\" ss:Name=\"Title\">" + _Newline);
            stringBuilder.Append("<Alignment ss:Horizontal=\"Center\" ss:Vertical=\"Center\"/>" + _Newline);
            stringBuilder.Append("<Font ss:FontName=\"Arial\" ss:Size=\"10\" x:Family=\"Swiss\" ss:Bold=\"1\" ss:Italic=\"1\"/>" + _Newline);
            stringBuilder.Append("</Style>" + _Newline);

            stringBuilder.Append("<Style ss:ID=\"sHeadColumn\" ss:Name=\"HeadColumn\">" + _Newline);
            stringBuilder.Append("<Alignment ss:Horizontal=\"Center\" ss:Vertical=\"Center\"/>" + _Newline);
            stringBuilder.Append("<Font ss:FontName=\"Arial\" ss:Size=\"8\" x:Family=\"Swiss\" ss:Bold=\"1\"/>" + _Newline);
            stringBuilder.Append("<Borders>");
            stringBuilder.Append("<Border ss:Position=\"Bottom\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>" + _Newline);
            stringBuilder.Append("<Border ss:Position=\"Left\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>" + _Newline);
            stringBuilder.Append("<Border ss:Position=\"Right\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>" + _Newline);
            stringBuilder.Append("<Border ss:Position=\"Top\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>" + _Newline);
            stringBuilder.Append("</Borders>" + _Newline);
            stringBuilder.Append("</Style>" + _Newline);

            stringBuilder.Append("<Style ss:ID=\"sGroup\">" + _Newline);
            stringBuilder.Append("<Borders>" + _Newline);
            stringBuilder.Append("<Border ss:Position=\"Bottom\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>" + _Newline);
            stringBuilder.Append("<Border ss:Position=\"Left\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>" + _Newline);
            stringBuilder.Append("<Border ss:Position=\"Right\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>" + _Newline);
            stringBuilder.Append("<Border ss:Position=\"Top\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>" + _Newline);
            stringBuilder.Append("</Borders>" + _Newline);
            stringBuilder.Append("<Font ss:FontName=\"Arial\" ss:Size=\"8\" x:Family=\"Swiss\" ss:Bold=\"1\" ss:Italic=\"1\"/>" + _Newline);
            stringBuilder.Append("<Interior ss:Color=\"#c0dcc0\" ss:Pattern=\"Solid\"/>" + _Newline);
            stringBuilder.Append("</Style>" + _Newline);

            stringBuilder.Append("<Style ss:ID=\"sCell\">" + _Newline);
            stringBuilder.Append("<Borders>" + _Newline);
            stringBuilder.Append("<Border ss:Position=\"Bottom\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>" + _Newline);
            stringBuilder.Append("<Border ss:Position=\"Left\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>" + _Newline);
            stringBuilder.Append("<Border ss:Position=\"Right\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>" + _Newline);
            stringBuilder.Append("<Border ss:Position=\"Top\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>" + _Newline);
            stringBuilder.Append("</Borders>" + _Newline);
            stringBuilder.Append("<Font ss:FontName=\"Arial\" ss:Size=\"8\" x:Family=\"Swiss\"/>" + _Newline);
            stringBuilder.Append("<Alignment ss:Horizontal=\"Left\" ss:Vertical=\"Top\" ss:WrapText=\"1\"/>" + _Newline);
            stringBuilder.Append("</Style>" + _Newline);

            stringBuilder.Append("</Styles>" + _Newline);
            return stringBuilder.ToString();
        }
        private static string WriteFirstWorkSheet(DataTable dt, DateTime dateBeg, DateTime dateEnd)
        {
            string Тема = "Отчет руководителю на " + dateBeg.ToShortDateString();
            int countColumn = dt.Columns.Count;
            int WidthColumn = 100;
            string text = string.Empty;

            new StringBuilder();

            text = text + "<Worksheet ss:Name=\"Sheet1\">" + _Newline;
            text = string.Concat(new string[] { text,"<Table ss:ExpandedColumnCount=\"", countColumn.ToString(), "\" ss:ExpandedRowCount=\"1000\" x:FullColumns=\"1\"   x:FullRows=\"1\">" , _Newline });
            // ширина колонок
            for (int i = 0; i < countColumn; i++)
            {
                text = string.Concat(new string[]
                {
                    text,"<Column ss:AutoFitWidth=\"1\" ss:Width=\"",WidthColumn.ToString(),"\"/>",_Newline
                });
            }
            // заголовок /row = 1/
            text = text + "<Row ss:Index=\"1\">" + _Newline;
            text = string.Concat(new string[] { text, "<Cell ss:MergeAcross=\"3\" ss:StyleID=\"sTitle\"><Data ss:Type=\"String\">",Тема,"</Data></Cell>" ,_Newline });
            text = text + "</Row>" + _Newline;
            //  /row = 2/
            text = text + "<Row ss:Index=\"2\">" + _Newline;
            text = string.Concat(new string[]{text, "<Cell ss:MergeAcross=\"3\" ss:StyleID=\"sTitle\"><Data ss:Type=\"String\">на ", dateEnd.ToShortDateString(),"г.</Data></Cell>", _Newline
            });
            text = text + "</Row>" + _Newline;

            //// шапка /row = 3/ 
            text = text + "<Row ss:Index=\"3\" ss:Height=\"25\">" + _Newline;
            for (int i = 0; i < countColumn; i++)
            {
                string ColumnName = dt.Columns[i].ColumnName;
                text = string.Concat(new string[] { text, "<Cell ss:StyleID=\"sHeadColumn\"><Data ss:Type=\"String\">", ColumnName, "</Data></Cell>", _Newline });
            }
            text = text + "</Row>" + _Newline;

            int curRowReport = 4;
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                text = string.Concat(new string[]
                {
                        text,"<Row>",_Newline
                });
                DataRow dataRow = dt.Rows[j];
                for (int i = 0; i < countColumn; i++)
                {
                    string Value = dataRow[i].ToString();
                    text = string.Concat(new string[]{
                         text, "<Cell ss:StyleID=\"sCell\"><Data ss:Type=\"String\">", Value.ToString().Replace("\n", "&#10;"),"</Data></Cell>",  _Newline
                    });
                }
                text = text + "</Row>" + _Newline;
                curRowReport++;
            }

            text = text + "</Table>" + _Newline;
            return text + "</Worksheet>" + _Newline;
        }
        private static string ExcelWorkSheetOptions()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n<WorksheetOptions xmlns=\"urn:schemas-microsoft-com:office:excel\">\n<Selected/>\n </WorksheetOptions>\n");
            return stringBuilder.ToString();
        }
        private static float GetHeight(string str, int widthCol, int rowMerge)
        {
            float height = 0f;
            int num2 = 0;
            for (; ; )
            {
                int num3 = str.IndexOf('\n', num2);
                if (num3 == -1)
                {
                    break;
                }
                string text = str.Substring(num2, num3 - num2);
                num2 = num3 + 1;
                height += 12.75f * (float)(TextRenderer.MeasureText(text, new Font("Arial", 8f)).Width / widthCol + 1);
            }
            Size size = TextRenderer.MeasureText(str.Substring(num2), new Font("Arial", 8f));
            height += (float)(size.Height * (size.Width / 180 + 1));
            height -= (float)rowMerge * 12.75f;
            if (height < 0f)
            {
                height = 0f;
            }
            return height;
        }
        #endregion

        ///// <summary>
        ///// Выгрузка ASP.NET
        ///// </summary>
        ///// <param name="dt"></param>
        //public  void CreateASP(DataTable dt)
        //{
        //    try
        //    {
        //        HttpResponse Response = HttpContext.Current.Response;

        //        string attachment = "attachment; filename=city.xls";
        //        Response.ClearContent();
        //        Response.AddHeader("content-disposition", attachment);
        //        Response.ContentType = "application/vnd.ms-excel";
        //        string tab = "";
        //        foreach (DataColumn dc in dt.Columns)
        //        {
        //            Response.Write(tab + dc.ColumnName);
        //            tab = "\t";
        //        }
        //        Response.Write("\n");
        //        int i;
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            tab = "";
        //            for (i = 0; i < dt.Columns.Count; i++)
        //            {
        //                Response.Write(tab + dr[i].ToString());
        //                tab = "\t";
        //            }
        //            Response.Write("\n");
        //        }
        //        Response.End();
        //    }
        //    catch (Exception Ex)
        //    { }
        //}
    }
    internal static class UtilsFile
    {
        private static string ConvertHTMLToExcelXML(string strHtml)
        {
            strHtml = strHtml.Replace("<tr>", "<Row ss:AutoFitHeight=\"1\" >\n");
            strHtml = strHtml.Replace("</tr>", "</Row>\n");
            strHtml = strHtml.Replace("<td>", "<Cell><Data ss:Type=\"String\">");
            strHtml = strHtml.Replace("</td>", "</Data></Cell>\n");
            return strHtml;
        }
        internal static void WriteToFile(string fileName, StringBuilder sb, Encoding encoding, bool isConvertToXML = false)
        {
            Encoding.GetEncoding(1251);
            try
            {
                File.Delete(fileName);
                StreamWriter streamWriter = new StreamWriter(fileName, true, encoding);
                if (isConvertToXML)
                {
                    streamWriter.Write(UtilsFile.ConvertHTMLToExcelXML(sb.ToString()));
                }
                else
                {
                    streamWriter.Write(sb.ToString());
                }
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                SchemeEventLog.WriteEntry("WriteToFile: " + ex.Message, EventLogEntryType.Error);
            }
        }
    }
    internal static class SchemeEventLog
    {
        internal static void WriteEntry(string sEvent, EventLogEntryType entryType)
        {
            try
            {
                if (!EventLog.SourceExists(SchemeEventLog.sSource))
                {
                    EventLog.CreateEventSource(SchemeEventLog.sSource, SchemeEventLog.sLog);
                }
                EventLog.WriteEntry(SchemeEventLog.sSource, sEvent, entryType);
            }
            catch
            {
            }
        }
        private static string sSource = "SchemeService";
        private static string sLog = "Service";
    }
}
