using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace SchemeService
{
    public class UtilsFile
    {
        private static string ConvertHTMLToExcelXML(string strHtml)
        {
            strHtml = strHtml.Replace("<tr>", "<Row ss:AutoFitHeight=\"1\" >\n");
            strHtml = strHtml.Replace("</tr>", "</Row>\n");
            strHtml = strHtml.Replace("<td>", "<Cell><Data ss:Type=\"String\">");
            strHtml = strHtml.Replace("</td>", "</Data></Cell>\n");
            return strHtml;
        }

        public static void WriteToFileXML(string fileName, StringBuilder sb, Encoding encoding, bool isConvertToXML = false)
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
}
