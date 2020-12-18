namespace MarkupConverter
{
    using System;

    public interface IMarkupConverter
    {
        string ConvertHtmlToXaml(string htmlText);
        string ConvertRtfToHtml(string rtfText);
        string ConvertXamlToHtml(string xamlText);
    }
}

