namespace MarkupConverter
{
    using System;
    using System.IO;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;

    public static class RtfToHtmlConverter
    {
        private const string string_0 = "<FlowDocument>{0}</FlowDocument>";

        public static string ConvertRtfToHtml(string rtfText)
        {
            return HtmlFromXamlConverter.ConvertXamlToHtml(string.Format("<FlowDocument>{0}</FlowDocument>", smethod_0(rtfText)), false);
        }

        private static string smethod_0(string string_1)
        {
            string str;
            RichTextBox box = new RichTextBox();
            if (string.IsNullOrEmpty(string_1))
            {
                return "";
            }
            TextRange range = new TextRange(box.Document.ContentStart, box.Document.ContentEnd);
            using (MemoryStream stream = new MemoryStream())
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(string_1);
                    writer.Flush();
                    stream.Seek(0L, SeekOrigin.Begin);
                    range.Load(stream, DataFormats.Rtf);
                }
            }
            using (MemoryStream stream2 = new MemoryStream())
            {
                new TextRange(box.Document.ContentStart, box.Document.ContentEnd).Save(stream2, DataFormats.Xaml);
                stream2.Seek(0L, SeekOrigin.Begin);
                using (StreamReader reader = new StreamReader(stream2))
                {
                    str = reader.ReadToEnd();
                }
            }
            return str;
        }
    }
}

