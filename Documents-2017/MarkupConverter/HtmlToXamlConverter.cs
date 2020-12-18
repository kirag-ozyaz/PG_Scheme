namespace MarkupConverter
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System.Windows;
    using System.Windows.Documents;
    using System.Xml;

    public static class HtmlToXamlConverter
    {
        private static string string_0 = "http://schemas.microsoft.com/winfx/2006/xaml/presentation";
        public const string Xaml_Background = "Background";
        public const string Xaml_BorderBrush = "BorderBrush";
        public const string Xaml_BorderThickness = "BorderThickness";
        public const string Xaml_Brushes_Black = "Black";
        public const string Xaml_FlowDocument = "FlowDocument";
        public const string Xaml_FontFamily = "FontFamily";
        public const string Xaml_FontSize = "FontSize";
        public const string Xaml_FontSize_Large = "18pt";
        public const string Xaml_FontSize_Medium = "16pt";
        public const string Xaml_FontSize_Small = "12pt";
        public const string Xaml_FontSize_XLarge = "20pt";
        public const string Xaml_FontSize_XSmall = "10pt";
        public const string Xaml_FontSize_XXLarge = "22pt";
        public const string Xaml_FontSize_XXSmall = "8pt";
        public const string Xaml_FontStyle = "FontStyle";
        public const string Xaml_FontWeight = "FontWeight";
        public const string Xaml_FontWeight_Bold = "Bold";
        public const string Xaml_Foreground = "Foreground";
        public const string Xaml_Hyperlink = "Hyperlink";
        public const string Xaml_Hyperlink_NavigateUri = "NavigateUri";
        public const string Xaml_Hyperlink_TargetName = "TargetName";
        public const string Xaml_LineBreak = "LineBreak";
        public const string Xaml_List = "List";
        public const string Xaml_List_MarkerStyle = "MarkerStyle";
        public const string Xaml_List_MarkerStyle_Box = "Box";
        public const string Xaml_List_MarkerStyle_Circle = "Circle";
        public const string Xaml_List_MarkerStyle_Decimal = "Decimal";
        public const string Xaml_List_MarkerStyle_Disc = "Disc";
        public const string Xaml_List_MarkerStyle_LowerLatin = "LowerLatin";
        public const string Xaml_List_MarkerStyle_LowerRoman = "LowerRoman";
        public const string Xaml_List_MarkerStyle_None = "None";
        public const string Xaml_List_MarkerStyle_Square = "Square";
        public const string Xaml_List_MarkerStyle_UpperLatin = "UpperLatin";
        public const string Xaml_List_MarkerStyle_UpperRoman = "UpperRoman";
        public const string Xaml_ListItem = "ListItem";
        public const string Xaml_Margin = "Margin";
        public const string Xaml_Padding = "Padding";
        public const string Xaml_Paragraph = "Paragraph";
        public const string Xaml_Run = "Run";
        public const string Xaml_Section = "Section";
        public const string Xaml_Span = "Span";
        public const string Xaml_Table = "Table";
        public const string Xaml_TableCell = "TableCell";
        public const string Xaml_TableCell_BorderBrush = "BorderBrush";
        public const string Xaml_TableCell_BorderThickness = "BorderThickness";
        public const string Xaml_TableCell_ColumnSpan = "ColumnSpan";
        public const string Xaml_TableCell_RowSpan = "RowSpan";
        public const string Xaml_TableColumn = "TableColumn";
        public const string Xaml_TableRow = "TableRow";
        public const string Xaml_TableRowGroup = "TableRowGroup";
        public const string Xaml_TextAlignment = "TextAlignment";
        public const string Xaml_TextDecorations = "TextDecorations";
        public const string Xaml_TextDecorations_Underline = "Underline";
        public const string Xaml_TextIndent = "TextIndent";
        public const string Xaml_Width = "Width";
        private static XmlElement xmlElement_0;

        public static string ConvertHtmlToXaml(string htmlString, bool asFlowDocument)
        {
            XmlElement element = Class25.smethod_0(htmlString);
            string localName = asFlowDocument ? "FlowDocument" : "Section";
            XmlElement element2 = new XmlDocument().CreateElement(null, localName, string_0);
            Class22 class2 = new Class22(element);
            List<XmlElement> list = new List<XmlElement>(10);
            xmlElement_0 = null;
            smethod_1(element2, element, new Hashtable(), class2, list);
            if (!asFlowDocument)
            {
                element2 = smethod_11(element2);
            }
            element2.SetAttribute("xml:space", "preserve");
            return element2.OuterXml;
        }

        public static string GetAttribute(XmlElement element, string attributeName)
        {
            attributeName = attributeName.ToLower();
            for (int i = 0; i < element.Attributes.Count; i++)
            {
                if (element.Attributes[i].Name.ToLower() == attributeName)
                {
                    return element.Attributes[i].Value;
                }
            }
            return null;
        }

        internal static string smethod_0(string string_1)
        {
            if ((string_1.StartsWith("\"") && string_1.EndsWith("\"")) || (string_1.StartsWith("'") && string_1.EndsWith("'")))
            {
                string_1 = string_1.Substring(1, string_1.Length - 2).Trim();
            }
            return string_1;
        }

        private static XmlNode smethod_1(XmlElement xmlElement_1, XmlNode xmlNode_0, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            if (xmlNode_0 is XmlComment)
            {
                smethod_10((XmlComment) xmlNode_0, null);
                return xmlNode_0;
            }
            if (xmlNode_0 is XmlText)
            {
                xmlNode_0 = smethod_5(xmlElement_1, xmlNode_0, hashtable_0, class22_0, list_0);
                return xmlNode_0;
            }
            if (!(xmlNode_0 is XmlElement))
            {
                return xmlNode_0;
            }
            XmlElement item = (XmlElement) xmlNode_0;
            string localName = item.LocalName;
            if (item.NamespaceURI != "http://www.w3.org/1999/xhtml")
            {
                return item;
            }
            list_0.Add(item);
            localName = localName.ToLower();
            uint num = Class227.smethod_0(localName);
            if (num <= 0x8b3b2db3)
            {
                if (num <= 0x4a7ab7e6)
                {
                    if (num <= 0x3d454045)
                    {
                        if (num <= 0x58c4484)
                        {
                            if (num == 0x1c46e5e)
                            {
                                if (localName == "cite")
                                {
                                    goto Label_05D1;
                                }
                            }
                            else if ((num == 0x58c4484) && (localName == "center"))
                            {
                                goto Label_05D1;
                            }
                        }
                        else
                        {
                            switch (num)
                            {
                                case 0x203e6faa:
                                    if (localName == "script")
                                    {
                                        goto Label_0605;
                                    }
                                    goto Label_05EB;

                                case 0x32694bc3:
                                    if (localName == "head")
                                    {
                                        goto Label_0605;
                                    }
                                    goto Label_05EB;
                            }
                            if ((num == 0x3d454045) && (localName != "td"))
                            {
                            }
                        }
                    }
                    else if (num <= 0x4058c747)
                    {
                        if (num == 0x4031bd46)
                        {
                            if (localName != "li")
                            {
                                goto Label_05EB;
                            }
                            xmlNode_0 = smethod_14(xmlElement_1, item, hashtable_0, class22_0, list_0);
                            goto Label_0605;
                        }
                        if ((num == 0x4058c747) && (localName == "form"))
                        {
                            goto Label_05D1;
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0x41454691:
                                if (localName == "th")
                                {
                                }
                                goto Label_05EB;

                            case 0x47455003:
                                if (localName == "tr")
                                {
                                }
                                goto Label_05EB;
                        }
                        if ((num == 0x4a7ab7e6) && (localName == "pre"))
                        {
                            goto Label_05D1;
                        }
                    }
                }
                else if (num <= 0x5f433734)
                {
                    if (num <= 0x4d1cb705)
                    {
                        if (num == 0x4a9c9bdf)
                        {
                            if (localName != "table")
                            {
                                goto Label_05EB;
                            }
                            smethod_16(xmlElement_1, item, hashtable_0, class22_0, list_0);
                            goto Label_0605;
                        }
                        if ((num == 0x4d1cb705) && (localName == "dt"))
                        {
                            goto Label_05B7;
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0x4d455975:
                                if (localName == "tt")
                                {
                                    goto Label_05B7;
                                }
                                goto Label_05EB;

                            case 0x5d1cd035:
                                if (localName == "dd")
                                {
                                    goto Label_05B7;
                                }
                                goto Label_05EB;
                        }
                        if ((num == 0x5f433734) && (localName == "ul"))
                        {
                            goto Label_05FA;
                        }
                    }
                }
                else if (num <= 0x651cdccd)
                {
                    if (num == 0x633432f6)
                    {
                        if (localName == "ol")
                        {
                            goto Label_05FA;
                        }
                    }
                    else if ((num == 0x651cdccd) && (localName == "dl"))
                    {
                        goto Label_05B7;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x81fe4f58:
                            if (localName == "meta")
                            {
                                goto Label_0605;
                            }
                            goto Label_05EB;

                        case 0x84e72504:
                            if (localName != "img")
                            {
                                goto Label_05EB;
                            }
                            smethod_12(xmlElement_1, item, hashtable_0, class22_0, list_0);
                            goto Label_0605;
                    }
                    if ((num == 0x8b3b2db3) && (localName == "h6"))
                    {
                        goto Label_05B7;
                    }
                }
                goto Label_05EB;
            }
            if (num <= 0xac307ed6)
            {
                if (num <= 0x8f3b33ff)
                {
                    if (num <= 0x8c3b2f46)
                    {
                        if (num == 0x8b7cd36b)
                        {
                            if (localName == "tbody")
                            {
                            }
                        }
                        else if ((num == 0x8c3b2f46) && (localName == "h5"))
                        {
                            goto Label_05B7;
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0x8d3b30d9:
                                if (localName == "h4")
                                {
                                    goto Label_05B7;
                                }
                                goto Label_05EB;

                            case 0x8e3b326c:
                                if (localName == "h3")
                                {
                                    goto Label_05B7;
                                }
                                goto Label_05EB;
                        }
                        if ((num == 0x8f3b33ff) && (localName == "h2"))
                        {
                            goto Label_05B7;
                        }
                    }
                }
                else if (num <= 0x9865b509)
                {
                    if (num == 0x903b3592)
                    {
                        if (localName == "h1")
                        {
                            goto Label_05B7;
                        }
                    }
                    else if ((num == 0x9865b509) && (localName == "title"))
                    {
                        goto Label_0605;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x99e4dd3a:
                            if (localName == "menu")
                            {
                                goto Label_05FA;
                            }
                            goto Label_05EB;

                        case 0xaa108e99:
                            if (localName == "thead")
                            {
                            }
                            goto Label_05EB;
                    }
                    if ((num == 0xac307ed6) && (localName == "style"))
                    {
                        goto Label_0605;
                    }
                }
                goto Label_05EB;
            }
            if (num <= 0xdbaa7975)
            {
                if (num <= 0xbfb4741b)
                {
                    if (num == 0xb09187da)
                    {
                        if (localName == "nsrtitle")
                        {
                            goto Label_05B7;
                        }
                    }
                    else if ((num == 0xbfb4741b) && (localName != "tfoot"))
                    {
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0xd6aab9fb:
                            if (localName == "textarea")
                            {
                                goto Label_05B7;
                            }
                            goto Label_05EB;

                        case 0xd775a7d0:
                            if (localName == "html")
                            {
                                goto Label_05D1;
                            }
                            goto Label_05EB;
                    }
                    if ((num == 0xdbaa7975) && (localName == "body"))
                    {
                        goto Label_05D1;
                    }
                }
                goto Label_05EB;
            }
            if (num <= 0xe562ab48)
            {
                if (num == 0xe18d189e)
                {
                    if (localName == "blockquote")
                    {
                        goto Label_05D1;
                    }
                }
                else if ((num == 0xe562ab48) && (localName == "div"))
                {
                    goto Label_05D1;
                }
                goto Label_05EB;
            }
            switch (num)
            {
                case 0xe962b194:
                    if (localName == "dir")
                    {
                        goto Label_05FA;
                    }
                    goto Label_05EB;

                case 0xef131c65:
                    if (localName != "caption")
                    {
                        goto Label_05EB;
                    }
                    goto Label_05D1;

                default:
                    if ((num != 0xf50c43ef) || (localName != "p"))
                    {
                        goto Label_05EB;
                    }
                    break;
            }
        Label_05B7:
            smethod_4(xmlElement_1, item, hashtable_0, class22_0, list_0);
            goto Label_0605;
        Label_05D1:
            smethod_3(xmlElement_1, item, hashtable_0, class22_0, list_0);
            goto Label_0605;
        Label_05EB:
            xmlNode_0 = smethod_5(xmlElement_1, item, hashtable_0, class22_0, list_0);
            goto Label_0605;
        Label_05FA:
            smethod_13(xmlElement_1, item, hashtable_0, class22_0, list_0);
        Label_0605:
            list_0.RemoveAt(list_0.Count - 1);
            return xmlNode_0;
        }

        private static void smethod_10(XmlComment xmlComment_0, XmlElement xmlElement_1)
        {
            if (xmlComment_0.Value == "StartFragment")
            {
                xmlElement_0 = xmlElement_1;
            }
            else if (((xmlComment_0.Value == "EndFragment") && (xmlElement_0 == null)) && (xmlElement_1 != null))
            {
                xmlElement_0 = xmlElement_1;
            }
        }

        private static XmlElement smethod_11(XmlElement xmlElement_1)
        {
            if (xmlElement_0 != null)
            {
                if (xmlElement_0.LocalName == "Span")
                {
                    xmlElement_1 = xmlElement_0;
                    return xmlElement_1;
                }
                xmlElement_1 = xmlElement_1.OwnerDocument.CreateElement(null, "Span", string_0);
                while (xmlElement_0.FirstChild != null)
                {
                    XmlNode firstChild = xmlElement_0.FirstChild;
                    xmlElement_0.RemoveChild(firstChild);
                    xmlElement_1.AppendChild(firstChild);
                }
            }
            return xmlElement_1;
        }

        private static void smethod_12(XmlElement xmlElement_1, XmlElement xmlElement_2, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
        }

        private static void smethod_13(XmlElement xmlElement_1, XmlElement xmlElement_2, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            Hashtable hashtable;
            Hashtable hashtable2 = smethod_38(xmlElement_2, hashtable_0, out hashtable, class22_0, list_0);
            XmlElement element = xmlElement_1.OwnerDocument.CreateElement(null, "List", string_0);
            if (xmlElement_2.LocalName.ToLower() == "ol")
            {
                element.SetAttribute("MarkerStyle", "Decimal");
            }
            else
            {
                element.SetAttribute("MarkerStyle", "Disc");
            }
            smethod_35(element, hashtable, true);
            for (XmlNode node = xmlElement_2.FirstChild; node != null; node = node.NextSibling)
            {
                if ((node is XmlElement) && (node.LocalName.ToLower() == "li"))
                {
                    list_0.Add((XmlElement) node);
                    smethod_15(element, (XmlElement) node, hashtable2, class22_0, list_0);
                    list_0.RemoveAt(list_0.Count - 1);
                }
            }
            if (element.HasChildNodes)
            {
                xmlElement_1.AppendChild(element);
            }
        }

        private static XmlElement smethod_14(XmlElement xmlElement_1, XmlElement xmlElement_2, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            XmlElement element = null;
            XmlElement element2;
            XmlNode lastChild = xmlElement_1.LastChild;
            if ((lastChild != null) && (lastChild.LocalName == "List"))
            {
                element2 = (XmlElement) lastChild;
            }
            else
            {
                element2 = xmlElement_1.OwnerDocument.CreateElement(null, "List", string_0);
                xmlElement_1.AppendChild(element2);
            }
            XmlNode nextSibling = xmlElement_2;
            for (string str = (nextSibling == null) ? null : nextSibling.LocalName.ToLower(); nextSibling != null; str = (nextSibling == null) ? null : nextSibling.LocalName.ToLower())
            {
                if (str != "li")
                {
                    return element;
                }
                smethod_15(element2, (XmlElement) nextSibling, hashtable_0, class22_0, list_0);
                element = (XmlElement) nextSibling;
                nextSibling = nextSibling.NextSibling;
            }
            return element;
        }

        private static void smethod_15(XmlElement xmlElement_1, XmlElement xmlElement_2, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            Hashtable hashtable;
            Hashtable hashtable2 = smethod_38(xmlElement_2, hashtable_0, out hashtable, class22_0, list_0);
            XmlElement element = xmlElement_1.OwnerDocument.CreateElement(null, "ListItem", string_0);
            for (XmlNode node = xmlElement_2.FirstChild; node != null; node = (node != null) ? node.NextSibling : null)
            {
                node = smethod_1(element, node, hashtable2, class22_0, list_0);
            }
            xmlElement_1.AppendChild(element);
        }

        private static void smethod_16(XmlElement xmlElement_1, XmlElement xmlElement_2, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            Hashtable hashtable;
            Hashtable hashtable2 = smethod_38(xmlElement_2, hashtable_0, out hashtable, class22_0, list_0);
            XmlElement item = smethod_17(xmlElement_2);
            if (item != null)
            {
                list_0.Add(item);
                for (XmlNode node = item.FirstChild; node != null; node = (node != null) ? node.NextSibling : null)
                {
                    node = smethod_1(xmlElement_1, node, hashtable2, class22_0, list_0);
                }
                list_0.RemoveAt(list_0.Count - 1);
            }
            else
            {
                XmlElement element2 = xmlElement_1.OwnerDocument.CreateElement(null, "Table", string_0);
                ArrayList list = smethod_24(xmlElement_2, class22_0);
                smethod_18(xmlElement_2, element2, list, hashtable2, class22_0, list_0);
                XmlNode firstChild = xmlElement_2.FirstChild;
                while (firstChild != null)
                {
                    string str = firstChild.LocalName.ToLower();
                    if (((str == "tbody") || (str == "thead")) || (str == "tfoot"))
                    {
                        Hashtable hashtable3;
                        XmlElement newChild = element2.OwnerDocument.CreateElement(null, "TableRowGroup", string_0);
                        element2.AppendChild(newChild);
                        list_0.Add((XmlElement) firstChild);
                        Hashtable hashtable4 = smethod_38((XmlElement) firstChild, hashtable2, out hashtable3, class22_0, list_0);
                        smethod_21(newChild, firstChild.FirstChild, hashtable4, list, class22_0, list_0);
                        if (newChild.HasChildNodes)
                        {
                            element2.AppendChild(newChild);
                        }
                        list_0.RemoveAt(list_0.Count - 1);
                        firstChild = firstChild.NextSibling;
                    }
                    else if (str == "tr")
                    {
                        XmlElement element4 = element2.OwnerDocument.CreateElement(null, "TableRowGroup", string_0);
                        firstChild = smethod_21(element4, firstChild, hashtable2, list, class22_0, list_0);
                        if (element4.HasChildNodes)
                        {
                            element2.AppendChild(element4);
                        }
                    }
                    else
                    {
                        firstChild = firstChild.NextSibling;
                    }
                }
                if (element2.HasChildNodes)
                {
                    xmlElement_1.AppendChild(element2);
                }
            }
        }

        private static XmlElement smethod_17(XmlElement xmlElement_1)
        {
            XmlElement element = null;
            for (XmlNode node = xmlElement_1.FirstChild; node != null; node = node.NextSibling)
            {
                string str = node.LocalName.ToLower();
                if (((str != "tbody") && (str != "thead")) && (str != "tfoot"))
                {
                    if (node.LocalName.ToLower() == "tr")
                    {
                        if (element != null)
                        {
                            return null;
                        }
                        for (XmlNode node4 = node.FirstChild; node4 != null; node4 = node4.NextSibling)
                        {
                            switch (node4.LocalName.ToLower())
                            {
                                case "td":
                                case "th":
                                    if (element != null)
                                    {
                                        return null;
                                    }
                                    element = (XmlElement) node4;
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    if (element != null)
                    {
                        return null;
                    }
                    for (XmlNode node2 = node.FirstChild; node2 != null; node2 = node2.NextSibling)
                    {
                        if (node2.LocalName.ToLower() == "tr")
                        {
                            if (element != null)
                            {
                                return null;
                            }
                            for (XmlNode node3 = node2.FirstChild; node3 != null; node3 = node3.NextSibling)
                            {
                                switch (node3.LocalName.ToLower())
                                {
                                    case "td":
                                    case "th":
                                        if (element != null)
                                        {
                                            return null;
                                        }
                                        element = (XmlElement) node3;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            return element;
        }

        private static void smethod_18(XmlElement xmlElement_1, XmlElement xmlElement_2, ArrayList arrayList_0, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            if (arrayList_0 != null)
            {
                for (int i = 0; i < (arrayList_0.Count - 1); i++)
                {
                    XmlElement newChild = xmlElement_2.OwnerDocument.CreateElement(null, "TableColumn", string_0);
                    newChild.SetAttribute("Width", (((double) arrayList_0[i + 1]) - ((double) arrayList_0[i])).ToString());
                    xmlElement_2.AppendChild(newChild);
                }
            }
            else
            {
                for (XmlNode node = xmlElement_1.FirstChild; node != null; node = node.NextSibling)
                {
                    if (node.LocalName.ToLower() == "colgroup")
                    {
                        smethod_19(xmlElement_2, (XmlElement) node, hashtable_0, class22_0, list_0);
                    }
                    else if (node.LocalName.ToLower() == "col")
                    {
                        smethod_20(xmlElement_2, (XmlElement) node, hashtable_0, class22_0, list_0);
                    }
                    else if (node is XmlElement)
                    {
                        break;
                    }
                }
            }
        }

        private static void smethod_19(XmlElement xmlElement_1, XmlElement xmlElement_2, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            Hashtable hashtable;
            Hashtable hashtable2 = smethod_38(xmlElement_2, hashtable_0, out hashtable, class22_0, list_0);
            for (XmlNode node = xmlElement_2.FirstChild; node != null; node = node.NextSibling)
            {
                if ((node is XmlElement) && (node.LocalName.ToLower() == "col"))
                {
                    smethod_20(xmlElement_1, (XmlElement) node, hashtable2, class22_0, list_0);
                }
            }
        }

        private static void smethod_2(XmlElement xmlElement_1, string string_1)
        {
            XmlElement newChild = xmlElement_1.OwnerDocument.CreateElement(null, "LineBreak", string_0);
            xmlElement_1.AppendChild(newChild);
            if (string_1 == "hr")
            {
                XmlText text = xmlElement_1.OwnerDocument.CreateTextNode("----------------------");
                xmlElement_1.AppendChild(text);
                newChild = xmlElement_1.OwnerDocument.CreateElement(null, "LineBreak", string_0);
                xmlElement_1.AppendChild(newChild);
            }
        }

        private static void smethod_20(XmlElement xmlElement_1, XmlElement xmlElement_2, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            Hashtable hashtable;
            smethod_38(xmlElement_2, hashtable_0, out hashtable, class22_0, list_0);
            XmlElement newChild = xmlElement_1.OwnerDocument.CreateElement(null, "TableColumn", string_0);
            xmlElement_1.AppendChild(newChild);
        }

        private static XmlNode smethod_21(XmlElement xmlElement_1, XmlNode xmlNode_0, Hashtable hashtable_0, ArrayList arrayList_0, Class22 class22_0, List<XmlElement> list_0)
        {
            XmlNode nextSibling = xmlNode_0;
            ArrayList list = null;
            if (arrayList_0 != null)
            {
                list = new ArrayList();
                smethod_30(list, arrayList_0.Count);
            }
            while (nextSibling != null)
            {
                if (nextSibling.LocalName.ToLower() == "tbody")
                {
                    return nextSibling;
                }
                if (nextSibling.LocalName.ToLower() == "tr")
                {
                    Hashtable hashtable;
                    XmlElement element = xmlElement_1.OwnerDocument.CreateElement(null, "TableRow", string_0);
                    list_0.Add((XmlElement) nextSibling);
                    Hashtable hashtable2 = smethod_38((XmlElement) nextSibling, hashtable_0, out hashtable, class22_0, list_0);
                    smethod_22(element, nextSibling.FirstChild, hashtable2, arrayList_0, list, class22_0, list_0);
                    if (element.HasChildNodes)
                    {
                        xmlElement_1.AppendChild(element);
                    }
                    list_0.RemoveAt(list_0.Count - 1);
                    nextSibling = nextSibling.NextSibling;
                }
                else if (nextSibling.LocalName.ToLower() == "td")
                {
                    XmlElement element2 = xmlElement_1.OwnerDocument.CreateElement(null, "TableRow", string_0);
                    nextSibling = smethod_22(element2, nextSibling, hashtable_0, arrayList_0, list, class22_0, list_0);
                    if (element2.HasChildNodes)
                    {
                        xmlElement_1.AppendChild(element2);
                    }
                }
                else
                {
                    nextSibling = nextSibling.NextSibling;
                }
            }
            return nextSibling;
        }

        private static XmlNode smethod_22(XmlElement xmlElement_1, XmlNode xmlNode_0, Hashtable hashtable_0, ArrayList arrayList_0, ArrayList arrayList_1, Class22 class22_0, List<XmlElement> list_0)
        {
            XmlNode nextSibling = xmlNode_0;
            double num = 0.0;
            int num2 = 0;
            int num3 = 0;
            while (nextSibling != null)
            {
                Hashtable hashtable;
                if (((nextSibling.LocalName.ToLower() == "tr") || (nextSibling.LocalName.ToLower() == "tbody")) || ((nextSibling.LocalName.ToLower() == "thead") || (nextSibling.LocalName.ToLower() == "tfoot")))
                {
                    return nextSibling;
                }
                if ((nextSibling.LocalName.ToLower() != "td") && (nextSibling.LocalName.ToLower() != "th"))
                {
                    nextSibling = nextSibling.NextSibling;
                    continue;
                }
                XmlElement element = xmlElement_1.OwnerDocument.CreateElement(null, "TableCell", string_0);
                list_0.Add((XmlElement) nextSibling);
                Hashtable hashtable2 = smethod_38((XmlElement) nextSibling, hashtable_0, out hashtable, class22_0, list_0);
                smethod_42((XmlElement) nextSibling, element);
                if (arrayList_0 != null)
                {
                    while (num2 < arrayList_1.Count)
                    {
                        if (((int) arrayList_1[num2]) <= 0)
                        {
                            break;
                        }
                        arrayList_1[num2] = ((int) arrayList_1[num2]) - 1;
                        num2++;
                    }
                    double num1 = (double) arrayList_0[num2];
                    num = smethod_32((XmlElement) nextSibling);
                    num3 = smethod_33(num2, num, arrayList_0);
                    int num4 = smethod_27((XmlElement) nextSibling);
                    element.SetAttribute("ColumnSpan", num3.ToString());
                    for (int i = num2; i < (num2 + num3); i++)
                    {
                        arrayList_1[i] = num4 - 1;
                    }
                    num2 += num3;
                }
                smethod_23(element, nextSibling.FirstChild, hashtable2, class22_0, list_0);
                if (element.HasChildNodes)
                {
                    xmlElement_1.AppendChild(element);
                }
                list_0.RemoveAt(list_0.Count - 1);
                nextSibling = nextSibling.NextSibling;
            }
            return nextSibling;
        }

        private static void smethod_23(XmlElement xmlElement_1, XmlNode xmlNode_0, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            for (XmlNode node = xmlNode_0; node != null; node = (node != null) ? node.NextSibling : null)
            {
                node = smethod_1(xmlElement_1, node, hashtable_0, class22_0, list_0);
            }
        }

        private static ArrayList smethod_24(XmlElement xmlElement_1, Class22 class22_0)
        {
            if (xmlElement_1.HasChildNodes)
            {
                bool flag = true;
                ArrayList list = new ArrayList();
                ArrayList list2 = new ArrayList();
                XmlNode firstChild = xmlElement_1.FirstChild;
                double num = 0.0;
                while ((firstChild > null) & flag)
                {
                    switch (firstChild.LocalName.ToLower())
                    {
                        case "tbody":
                        {
                            double num2 = smethod_25((XmlElement) firstChild, list, list2, num, class22_0);
                            if (num2 > num)
                            {
                                num = num2;
                            }
                            else if (num2 == 0.0)
                            {
                                flag = false;
                            }
                            break;
                        }
                        case "tr":
                        {
                            double num3 = smethod_26((XmlElement) firstChild, list, list2, num, class22_0);
                            if (num3 > num)
                            {
                                num = num3;
                            }
                            else if (num3 == 0.0)
                            {
                                flag = false;
                            }
                            break;
                        }
                        case "td":
                            flag = false;
                            break;
                    }
                    firstChild = firstChild.NextSibling;
                }
                if (flag)
                {
                    list.Add(num);
                    smethod_34(list);
                    return list;
                }
            }
            return null;
        }

        private static double smethod_25(XmlElement xmlElement_1, ArrayList arrayList_0, ArrayList arrayList_1, double double_0, Class22 class22_0)
        {
            double num = 0.0;
            bool flag = true;
            if (xmlElement_1.HasChildNodes)
            {
                smethod_29(arrayList_1);
                for (XmlNode node = xmlElement_1.FirstChild; (node > null) & flag; node = node.NextSibling)
                {
                    switch (node.LocalName.ToLower())
                    {
                        case "tr":
                        {
                            double num2 = smethod_26((XmlElement) node, arrayList_0, arrayList_1, num, class22_0);
                            if (num2 > num)
                            {
                                num = num2;
                            }
                            break;
                        }
                        case "td":
                            flag = false;
                            break;
                    }
                }
                smethod_29(arrayList_1);
                if (!flag)
                {
                    return 0.0;
                }
            }
            return num;
        }

        private static double smethod_26(XmlElement xmlElement_1, ArrayList arrayList_0, ArrayList arrayList_1, double double_0, Class22 class22_0)
        {
            if (!xmlElement_1.HasChildNodes)
            {
                return 0.0;
            }
            bool flag = true;
            double num2 = 0.0;
            XmlNode firstChild = xmlElement_1.FirstChild;
            int index = 0;
            if ((0 >= arrayList_1.Count) || (((double) arrayList_0[index]) != num2))
            {
                goto Label_01F8;
            }
            while (true)
            {
                if ((index >= arrayList_1.Count) || (((int) arrayList_1[index]) <= 0))
                {
                    goto Label_01F8;
                }
                arrayList_1[index] = ((int) arrayList_1[index]) - 1;
                index++;
                num2 = (double) arrayList_0[index];
            }
        Label_01DF:
            while ((index < arrayList_1.Count) && (((int) arrayList_1[index]) > 0))
            {
                arrayList_1[index] = ((int) arrayList_1[index]) - 1;
                index++;
                num2 = (double) arrayList_0[index];
            }
        Label_01F1:
            firstChild = firstChild.NextSibling;
        Label_01F8:
            if ((firstChild > null) & flag)
            {
                smethod_34(arrayList_0);
                if (firstChild.LocalName.ToLower() != "td")
                {
                    goto Label_01F1;
                }
                if (index < arrayList_0.Count)
                {
                    if (num2 < ((double) arrayList_0[index]))
                    {
                        arrayList_0.Insert(index, num2);
                        arrayList_1.Insert(index, 0);
                    }
                }
                else
                {
                    arrayList_0.Add(num2);
                    arrayList_1.Add(0);
                }
                double num = smethod_32((XmlElement) firstChild);
                if (num == -1.0)
                {
                    flag = false;
                    goto Label_01F1;
                }
                int num6 = smethod_27((XmlElement) firstChild);
                int num5 = smethod_28(index, num, arrayList_0, arrayList_1);
                if (num5 == -1)
                {
                    flag = false;
                    goto Label_01F1;
                }
                for (int i = index; i < num5; i++)
                {
                    arrayList_1[i] = num6 - 1;
                }
                index = num5;
                num2 += num;
                if ((index >= arrayList_1.Count) || (((double) arrayList_0[index]) != num2))
                {
                    goto Label_01F1;
                }
                goto Label_01DF;
            }
            if (flag)
            {
                return num2;
            }
            return 0.0;
        }

        private static int smethod_27(XmlElement xmlElement_1)
        {
            int num;
            string attribute = GetAttribute(xmlElement_1, "rowspan");
            if (attribute == null)
            {
                return 1;
            }
            if (!int.TryParse(attribute, out num))
            {
                num = 1;
            }
            return num;
        }

        private static int smethod_28(int int_0, double double_0, ArrayList arrayList_0, ArrayList arrayList_1)
        {
            double num = (double) arrayList_0[int_0];
            int num2 = int_0 + 1;
            while (num2 < arrayList_0.Count)
            {
                if ((((double) arrayList_0[num2]) >= (num + double_0)) || (num2 == -1))
                {
                    return num2;
                }
                if (((int) arrayList_1[num2]) > 0)
                {
                    num2 = -1;
                }
                else
                {
                    num2++;
                }
            }
            return num2;
        }

        private static void smethod_29(ArrayList arrayList_0)
        {
            for (int i = 0; i < arrayList_0.Count; i++)
            {
                arrayList_0[i] = 0;
            }
        }

        private static void smethod_3(XmlElement xmlElement_1, XmlElement xmlElement_2, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            bool flag = false;
            for (XmlNode node = xmlElement_2.FirstChild; node != null; node = node.NextSibling)
            {
                if ((node is XmlElement) && Class26.smethod_1(((XmlElement) node).LocalName.ToLower()))
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                smethod_4(xmlElement_1, xmlElement_2, hashtable_0, class22_0, list_0);
            }
            else
            {
                Hashtable hashtable;
                Hashtable hashtable2 = smethod_38(xmlElement_2, hashtable_0, out hashtable, class22_0, list_0);
                XmlElement element = xmlElement_1.OwnerDocument.CreateElement(null, "Section", string_0);
                smethod_35(element, hashtable, true);
                if (!element.HasAttributes)
                {
                    element = xmlElement_1;
                }
                for (XmlNode node2 = xmlElement_2.FirstChild; node2 != null; node2 = (node2 != null) ? node2.NextSibling : null)
                {
                    node2 = smethod_1(element, node2, hashtable2, class22_0, list_0);
                }
                if (element != xmlElement_1)
                {
                    xmlElement_1.AppendChild(element);
                }
            }
        }

        private static void smethod_30(ArrayList arrayList_0, int int_0)
        {
            for (int i = 0; i < int_0; i++)
            {
                arrayList_0.Add(0);
            }
        }

        private static double smethod_31(XmlElement xmlElement_1, double double_0)
        {
            double num = smethod_32(xmlElement_1);
            if (num == -1.0)
            {
                return -1.0;
            }
            return (double_0 + num);
        }

        private static double smethod_32(XmlElement xmlElement_1)
        {
            string attribute = null;
            double num = -1.0;
            attribute = GetAttribute(xmlElement_1, "width");
            if (attribute == null)
            {
                attribute = smethod_39(GetAttribute(xmlElement_1, "style"), "width");
            }
            if (smethod_40(attribute, out num) && (num != 0.0))
            {
                return num;
            }
            return -1.0;
        }

        private static int smethod_33(int int_0, double double_0, ArrayList arrayList_0)
        {
            int num2 = int_0;
            double num = 0.0;
            double num3 = 0.0;
            while (num < double_0)
            {
                if (num2 >= (arrayList_0.Count - 1))
                {
                    break;
                }
                num3 = ((double) arrayList_0[num2 + 1]) - ((double) arrayList_0[num2]);
                num += num3;
                num2++;
            }
            return (num2 - int_0);
        }

        private static void smethod_34(ArrayList arrayList_0)
        {
            for (int i = 0; i < arrayList_0.Count; i++)
            {
                double num1 = (double) arrayList_0[i];
            }
        }

        private static void smethod_35(XmlElement xmlElement_1, Hashtable hashtable_0, bool bool_0)
        {
            bool flag = false;
            string str = "0";
            string str2 = "0";
            string str3 = "0";
            string str4 = "0";
            bool flag2 = false;
            string str5 = "0";
            string str6 = "0";
            string str7 = "0";
            string str8 = "0";
            string str9 = null;
            bool flag3 = false;
            string str10 = "0";
            string str11 = "0";
            string str12 = "0";
            string str13 = "0";
            IDictionaryEnumerator enumerator = hashtable_0.GetEnumerator();
            while (enumerator.MoveNext())
            {
                string str15;
                string key = (string) enumerator.Key;
                uint num = Class227.smethod_0(key);
                if (num <= 0x77dc382a)
                {
                    if (num <= 0x441a3ef7)
                    {
                        if (num <= 0x31139a45)
                        {
                            if (num <= 0xd0e23a8)
                            {
                                if (num == 0x79bd282)
                                {
                                    if ((key == "text-align") && bool_0)
                                    {
                                        xmlElement_1.SetAttribute("TextAlignment", (string) enumerator.Value);
                                    }
                                }
                                else if ((num == 0xd0e23a8) && (key != "font-variant"))
                                {
                                }
                            }
                            else
                            {
                                switch (num)
                                {
                                    case 0xf0cc3d8:
                                    {
                                        if (key == "font-style")
                                        {
                                            xmlElement_1.SetAttribute("FontStyle", (string) enumerator.Value);
                                        }
                                        continue;
                                    }
                                    case 0x20c4ce3f:
                                    {
                                        if (key == "font-family")
                                        {
                                            xmlElement_1.SetAttribute("FontFamily", (string) enumerator.Value);
                                        }
                                        continue;
                                    }
                                }
                                if ((num == 0x31139a45) && (key == "margin-top"))
                                {
                                    flag = true;
                                    str = (string) enumerator.Value;
                                }
                            }
                        }
                        else if (num <= 0x3d7e6258)
                        {
                            if (num == 0x34a74fa7)
                            {
                                if ((key == "text-indent") && bool_0)
                                {
                                    xmlElement_1.SetAttribute("TextIndent", (string) enumerator.Value);
                                }
                            }
                            else if ((num == 0x3d7e6258) && (key == "color"))
                            {
                                smethod_37(xmlElement_1, TextElement.ForegroundProperty, (string) enumerator.Value);
                            }
                        }
                        else
                        {
                            switch (num)
                            {
                                case 0x3e30e1c7:
                                {
                                    if (key == "border-style-left")
                                    {
                                    }
                                    continue;
                                }
                                case 0x3ecf3028:
                                {
                                    if (key == "text-decoration-line-through")
                                    {
                                        goto Label_0A19;
                                    }
                                    continue;
                                }
                            }
                            if ((num == 0x441a3ef7) && (key == "border-color-top"))
                            {
                                str9 = (string) enumerator.Value;
                            }
                        }
                    }
                    else if (num <= 0x576bfd10)
                    {
                        if (num <= 0x463684e0)
                        {
                            if (num == 0x4569f715)
                            {
                                if (key == "display")
                                {
                                }
                            }
                            else if ((num == 0x463684e0) && (key == "margin-right"))
                            {
                                flag = true;
                                str4 = (string) enumerator.Value;
                            }
                        }
                        else
                        {
                            switch (num)
                            {
                                case 0x4de11fef:
                                {
                                    if (key == "margin-left")
                                    {
                                        flag = true;
                                        str3 = (string) enumerator.Value;
                                    }
                                    continue;
                                }
                                case 0x55e41ca9:
                                {
                                    if (key == "border-style-bottom")
                                    {
                                    }
                                    continue;
                                }
                            }
                            if ((num == 0x576bfd10) && (key == "padding-top"))
                            {
                                flag2 = true;
                                str5 = (string) enumerator.Value;
                            }
                        }
                    }
                    else if (num <= 0x5e4f4ce5)
                    {
                        if (num == 0x5c6e1222)
                        {
                            if (key == "clear")
                            {
                            }
                        }
                        else if ((num == 0x5e4f4ce5) && (key == "border-width-right"))
                        {
                            flag3 = true;
                            str13 = (string) enumerator.Value;
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0x60c1cc35:
                            {
                                if (key == "border-color-left")
                                {
                                    str9 = (string) enumerator.Value;
                                }
                                continue;
                            }
                            case 0x6e78e356:
                            {
                                if (key == "text-decoration-overline")
                                {
                                    goto Label_0A19;
                                }
                                continue;
                            }
                        }
                        if ((num == 0x77dc382a) && (key == "border-width-bottom"))
                        {
                            flag3 = true;
                            str11 = (string) enumerator.Value;
                        }
                    }
                    continue;
                }
                if (num <= 0xa98a9434)
                {
                    if (num <= 0x96fdb170)
                    {
                        if (num <= 0x893cc67f)
                        {
                            if (num == 0x87a2233c)
                            {
                                if (key == "border-width-top")
                                {
                                    flag3 = true;
                                    str10 = (string) enumerator.Value;
                                }
                            }
                            else if ((num == 0x893cc67f) && (key == "border-color-bottom"))
                            {
                                str9 = (string) enumerator.Value;
                            }
                        }
                        else
                        {
                            switch (num)
                            {
                                case 0x900e0a71:
                                {
                                    if (key == "margin-bottom")
                                    {
                                        flag = true;
                                        str2 = (string) enumerator.Value;
                                    }
                                    continue;
                                }
                                case 0x95876e1f:
                                {
                                    if (key == "width")
                                    {
                                    }
                                    continue;
                                }
                            }
                            if ((num == 0x96fdb170) && (key == "border-width-left"))
                            {
                                flag3 = true;
                                str12 = (string) enumerator.Value;
                            }
                        }
                    }
                    else if (num <= 0xa6c45d85)
                    {
                        if (num == 0xa6497a0f)
                        {
                            if (key == "text-transform")
                            {
                            }
                        }
                        else if ((num == 0xa6c45d85) && (key != "float"))
                        {
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0xa89a820d:
                            {
                                if (key == "border-style-top")
                                {
                                }
                                continue;
                            }
                            case 0xa903704e:
                            {
                                if (key == "border-color-right")
                                {
                                    str9 = (string) enumerator.Value;
                                }
                                continue;
                            }
                        }
                        if ((num == 0xa98a9434) && (key == "text-decoration-none"))
                        {
                            goto Label_0A19;
                        }
                    }
                    continue;
                }
                if (num > 0xc731ddd2)
                {
                    goto Label_092D;
                }
                if (num > 0xbd2b1c24)
                {
                    goto Label_0869;
                }
                if (num == 0xab783b8c)
                {
                    goto Label_0842;
                }
                if ((num != 0xbd2b1c24) || ((key != "list-style-type") || (xmlElement_1.LocalName != "List")))
                {
                    continue;
                }
                key = ((string) enumerator.Value).ToLower();
                num = Class227.smethod_0(key);
                if (num <= 0x70c67e32)
                {
                    if (num <= 0x28217089)
                    {
                        if (num != 0x1f088d4c)
                        {
                            if ((num != 0x28217089) || (key != "circle"))
                            {
                                goto Label_0820;
                            }
                            str15 = "Circle";
                        }
                        else
                        {
                            if (key != "decimal")
                            {
                                goto Label_0820;
                            }
                            str15 = "Decimal";
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0x3d60340c:
                                if (key != "disc")
                                {
                                    goto Label_0820;
                                }
                                str15 = "Disc";
                                goto Label_0830;

                            case 0x51e63813:
                                if (key != "upper-roman")
                                {
                                    goto Label_0820;
                                }
                                str15 = "UpperRoman";
                                goto Label_0830;
                        }
                        if ((num != 0x70c67e32) || (key != "box"))
                        {
                            goto Label_0820;
                        }
                        str15 = "Box";
                    }
                    goto Label_0830;
                }
                if (num <= 0xb4b61246)
                {
                    if (num != 0xada7afdb)
                    {
                        if ((num != 0xb4b61246) || (key != "square"))
                        {
                            goto Label_0820;
                        }
                        str15 = "Square";
                    }
                    else
                    {
                        if (key != "none")
                        {
                            goto Label_0820;
                        }
                        str15 = "None";
                    }
                    goto Label_0830;
                }
                if (num != 0xb7dc1620)
                {
                    if (num != 0xe8ec1491)
                    {
                        if ((num != 0xf167b0e2) || (key != "lower-roman"))
                        {
                            goto Label_0820;
                        }
                        str15 = "LowerRoman";
                    }
                    else
                    {
                        if (key != "lower-latin")
                        {
                            goto Label_0820;
                        }
                        str15 = "LowerLatin";
                    }
                    goto Label_0830;
                }
                if (key == "upper-latin")
                {
                    goto Label_0829;
                }
            Label_0820:
                str15 = "Disc";
                goto Label_0830;
            Label_0829:
                str15 = "UpperLatin";
            Label_0830:
                xmlElement_1.SetAttribute("MarkerStyle", str15);
                continue;
            Label_0842:
                if (key == "padding-left")
                {
                    flag2 = true;
                    str7 = (string) enumerator.Value;
                }
                continue;
            Label_0869:
                switch (num)
                {
                    case 0xc18cc803:
                    {
                        if (key == "font-weight")
                        {
                            xmlElement_1.SetAttribute("FontWeight", (string) enumerator.Value);
                        }
                        continue;
                    }
                    case 0xc662ae27:
                    {
                        if (key == "background-color")
                        {
                            smethod_37(xmlElement_1, TextElement.BackgroundProperty, (string) enumerator.Value);
                        }
                        continue;
                    }
                    default:
                    {
                        if ((num == 0xc731ddd2) && (((key == "text-decoration-underline") && !bool_0) && (((string) enumerator.Value) == "true")))
                        {
                            xmlElement_1.SetAttribute("TextDecorations", "Underline");
                        }
                        continue;
                    }
                }
            Label_092D:
                if (num <= 0xda8ad1f8)
                {
                    switch (num)
                    {
                        case 0xca23d419:
                        {
                            if (key == "padding-right")
                            {
                                flag2 = true;
                                str8 = (string) enumerator.Value;
                            }
                            continue;
                        }
                        case 0xd5bdbb42:
                        {
                            if (key == "height")
                            {
                            }
                            continue;
                        }
                    }
                    if ((num == 0xda8ad1f8) && (key != "border-style-right"))
                    {
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0xe65d6984:
                            goto Label_0A0B;

                        case 0xecf9338e:
                        {
                            if (key == "padding-bottom")
                            {
                                flag2 = true;
                                str6 = (string) enumerator.Value;
                            }
                            continue;
                        }
                    }
                    if ((num == 0xff5ed19e) && (key == "font-size"))
                    {
                        xmlElement_1.SetAttribute("FontSize", (string) enumerator.Value);
                    }
                }
                continue;
            Label_0A0B:
                if (key != "text-decoration-blink")
                {
                    continue;
                }
            Label_0A19:
                if (bool_0)
                {
                }
            }
            if (bool_0)
            {
                if (flag)
                {
                    smethod_36(xmlElement_1, "Margin", str3, str4, str, str2);
                }
                if (flag2)
                {
                    smethod_36(xmlElement_1, "Padding", str7, str8, str5, str6);
                }
                if (str9 != null)
                {
                    xmlElement_1.SetAttribute("BorderBrush", str9);
                }
                if (flag3)
                {
                    smethod_36(xmlElement_1, "BorderThickness", str12, str13, str10, str11);
                }
            }
        }

        private static void smethod_36(XmlElement xmlElement_1, string string_1, string string_2, string string_3, string string_4, string string_5)
        {
            string str;
            if ((string_2[0] == '0') || (string_2[0] == '-'))
            {
                string_2 = "0";
            }
            if ((string_3[0] == '0') || (string_3[0] == '-'))
            {
                string_3 = "0";
            }
            if ((string_4[0] == '0') || (string_4[0] == '-'))
            {
                string_4 = "0";
            }
            if ((string_5[0] == '0') || (string_5[0] == '-'))
            {
                string_5 = "0";
            }
            if ((string_2 == string_3) && (string_4 == string_5))
            {
                if (string_2 == string_4)
                {
                    str = string_2;
                }
                else
                {
                    str = string_2 + "," + string_4;
                }
            }
            else
            {
                string[] textArray1 = new string[] { string_2, ",", string_4, ",", string_3, ",", string_5 };
                str = string.Concat(textArray1);
            }
            xmlElement_1.SetAttribute(string_1, str);
        }

        private static void smethod_37(XmlElement xmlElement_1, DependencyProperty dependencyProperty_0, string string_1)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(dependencyProperty_0.PropertyType);
            try
            {
                if (converter.ConvertFromInvariantString(string_1) != null)
                {
                    xmlElement_1.SetAttribute(dependencyProperty_0.Name, string_1);
                }
            }
            catch (Exception)
            {
            }
        }

        private static Hashtable smethod_38(XmlElement xmlElement_1, Hashtable hashtable_0, out Hashtable hashtable_1, Class22 class22_0, List<XmlElement> list_0)
        {
            Hashtable hashtable = new Hashtable();
            IDictionaryEnumerator enumerator = hashtable_0.GetEnumerator();
            while (enumerator.MoveNext())
            {
                hashtable[enumerator.Key] = enumerator.Value;
            }
            string str = xmlElement_1.LocalName.ToLower();
            string namespaceURI = xmlElement_1.NamespaceURI;
            hashtable_1 = new Hashtable();
            uint num = Class227.smethod_0(str);
            if (num <= 0xc51f5d7a)
            {
                if (num <= 0x633432f6)
                {
                    if (num <= 0x4a7ab7e6)
                    {
                        switch (num)
                        {
                            case 0x274e1290:
                                if (str == "font")
                                {
                                    string attribute = GetAttribute(xmlElement_1, "face");
                                    if (attribute != null)
                                    {
                                        hashtable_1["font-family"] = attribute;
                                    }
                                    attribute = GetAttribute(xmlElement_1, "size");
                                    if (attribute != null)
                                    {
                                        double num2 = double.Parse(attribute) * 4.0;
                                        if (num2 < 1.0)
                                        {
                                            num2 = 1.0;
                                        }
                                        else if (num2 > 1000.0)
                                        {
                                            num2 = 1000.0;
                                        }
                                        hashtable_1["font-size"] = num2.ToString();
                                    }
                                    attribute = GetAttribute(xmlElement_1, "color");
                                    if (attribute != null)
                                    {
                                        hashtable_1["color"] = attribute;
                                    }
                                }
                                goto Label_0626;

                            case 0x401a63f7:
                                if (str == "em")
                                {
                                    goto Label_05E5;
                                }
                                goto Label_0626;
                        }
                        if ((num == 0x4a7ab7e6) && (str == "pre"))
                        {
                            hashtable_1["font-family"] = "Courier New";
                            hashtable_1["font-size"] = "8pt";
                            hashtable_1["text-align"] = "Left";
                        }
                    }
                    else if (num <= 0x5f433734)
                    {
                        if (num == 0x4a9c9bdf)
                        {
                            if (str == "table")
                            {
                            }
                        }
                        else if ((num == 0x5f433734) && (str == "ul"))
                        {
                            hashtable_1["list-style-type"] = "disc";
                        }
                    }
                    else if (num != 0x60e9fb6d)
                    {
                        if ((num == 0x633432f6) && (str == "ol"))
                        {
                            hashtable_1["list-style-type"] = "decimal";
                        }
                    }
                    else if (str == "italic")
                    {
                        goto Label_05E5;
                    }
                }
                else if (num <= 0x8e3b326c)
                {
                    if (num <= 0x8c3b2f46)
                    {
                        if (num == 0x8b3b2db3)
                        {
                            if (str == "h6")
                            {
                                hashtable_1["font-size"] = "10pt";
                            }
                        }
                        else if ((num == 0x8c3b2f46) && (str == "h5"))
                        {
                            hashtable_1["font-size"] = "12pt";
                        }
                    }
                    else if (num != 0x8d3b30d9)
                    {
                        if ((num == 0x8e3b326c) && (str == "h3"))
                        {
                            hashtable_1["font-size"] = "18pt";
                        }
                    }
                    else if (str == "h4")
                    {
                        hashtable_1["font-size"] = "16pt";
                    }
                }
                else if (num <= 0x903b3592)
                {
                    if (num == 0x8f3b33ff)
                    {
                        if (str == "h2")
                        {
                            hashtable_1["font-size"] = "20pt";
                        }
                    }
                    else if ((num == 0x903b3592) && (str == "h1"))
                    {
                        hashtable_1["font-size"] = "22pt";
                    }
                }
                else if (num != 0xc00c35c4)
                {
                    if ((num == 0xc51f5d7a) && (str == "strong"))
                    {
                        goto Label_0576;
                    }
                }
                else if (str == "samp")
                {
                    hashtable_1["font-family"] = "Courier New";
                    hashtable_1["font-size"] = "8pt";
                    hashtable_1["text-align"] = "Left";
                }
                goto Label_0626;
            }
            if (num <= 0xe18d189e)
            {
                if (num <= 0xd775a7d0)
                {
                    switch (num)
                    {
                        case 0xca4e1cbf:
                            if (str == "sup")
                            {
                            }
                            goto Label_0626;

                        case 0xcf574fb3:
                            if (str == "dfn")
                            {
                                goto Label_0576;
                            }
                            goto Label_0626;
                    }
                    if ((num == 0xd775a7d0) && (str != "html"))
                    {
                    }
                }
                else if (num <= 0xdc4e3915)
                {
                    if (num == 0xdbaa7975)
                    {
                        if (str == "body")
                        {
                        }
                    }
                    else if ((num == 0xdc4e3915) && (str != "sub"))
                    {
                    }
                }
                else if (num != 0xde96f676)
                {
                    if ((num == 0xe18d189e) && (str == "blockquote"))
                    {
                        hashtable_1["margin-left"] = "16";
                    }
                }
                else if (str == "bold")
                {
                    goto Label_0576;
                }
                goto Label_0626;
            }
            if (num > 0xe70c2de5)
            {
                if (num > 0xf00c3c10)
                {
                    if (num != 0xf4ba662a)
                    {
                        if ((num != 0xf50c43ef) || (str == "p"))
                        {
                        }
                    }
                    else if (str == "acronym")
                    {
                    }
                    goto Label_0626;
                }
                if (num == 0xec0c35c4)
                {
                    if (str != "i")
                    {
                        goto Label_0626;
                    }
                    goto Label_05E5;
                }
                if ((num != 0xf00c3c10) || (str != "u"))
                {
                    goto Label_0626;
                }
                goto Label_05C5;
            }
            if (num <= 0xe562ab48)
            {
                if (num == 0xe40c292c)
                {
                    if (str == "a")
                    {
                    }
                }
                else if ((num == 0xe562ab48) && (str != "div"))
                {
                }
                goto Label_0626;
            }
            if (num == 0xe582347f)
            {
                if (str == "underline")
                {
                    goto Label_05C5;
                }
                goto Label_0626;
            }
            if ((num != 0xe70c2de5) || (str != "b"))
            {
                goto Label_0626;
            }
        Label_0576:
            hashtable_1["font-weight"] = "bold";
            goto Label_0626;
        Label_05C5:
            hashtable_1["text-decoration-underline"] = "true";
            goto Label_0626;
        Label_05E5:
            hashtable_1["font-style"] = "italic";
        Label_0626:
            Class21.smethod_0(xmlElement_1, str, class22_0, hashtable_1, list_0);
            enumerator = hashtable_1.GetEnumerator();
            while (enumerator.MoveNext())
            {
                hashtable[enumerator.Key] = enumerator.Value;
            }
            return hashtable;
        }

        private static string smethod_39(string string_1, string string_2)
        {
            if (string_1 != null)
            {
                string_2 = string_2.ToLower();
                char[] separator = new char[] { ';' };
                string[] strArray = string_1.Split(separator);
                for (int i = 0; i < strArray.Length; i++)
                {
                    char[] chArray2 = new char[] { ':' };
                    string[] strArray2 = strArray[i].Split(chArray2);
                    if ((strArray2.Length == 2) && (strArray2[0].Trim().ToLower() == string_2))
                    {
                        return strArray2[1].Trim();
                    }
                }
            }
            return null;
        }

        private static void smethod_4(XmlElement xmlElement_1, XmlElement xmlElement_2, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            Hashtable hashtable;
            Hashtable hashtable2 = smethod_38(xmlElement_2, hashtable_0, out hashtable, class22_0, list_0);
            XmlElement element = xmlElement_1.OwnerDocument.CreateElement(null, "Paragraph", string_0);
            smethod_35(element, hashtable, true);
            for (XmlNode node = xmlElement_2.FirstChild; node != null; node = node.NextSibling)
            {
                smethod_6(element, node, hashtable2, class22_0, list_0);
            }
            xmlElement_1.AppendChild(element);
        }

        private static bool smethod_40(string string_1, out double double_0)
        {
            double_0 = double.NaN;
            if (string_1 != null)
            {
                string_1 = string_1.Trim().ToLower();
                if (string_1.EndsWith("pt"))
                {
                    string_1 = string_1.Substring(0, string_1.Length - 2);
                    if (double.TryParse(string_1, out double_0))
                    {
                        double_0 = (double_0 * 96.0) / 72.0;
                    }
                    else
                    {
                        double_0 = double.NaN;
                    }
                }
                else if (string_1.EndsWith("px"))
                {
                    string_1 = string_1.Substring(0, string_1.Length - 2);
                    if (!double.TryParse(string_1, out double_0))
                    {
                        double_0 = double.NaN;
                    }
                }
                else if (!double.TryParse(string_1, out double_0))
                {
                    double_0 = double.NaN;
                }
            }
            return !double.IsNaN(double_0);
        }

        private static string smethod_41(string string_1)
        {
            return string_1;
        }

        private static void smethod_42(XmlElement xmlElement_1, XmlElement xmlElement_2)
        {
            xmlElement_2.SetAttribute("BorderThickness", "1,1,1,1");
            xmlElement_2.SetAttribute("BorderBrush", "Black");
            string attribute = GetAttribute(xmlElement_1, "rowspan");
            if (attribute != null)
            {
                xmlElement_2.SetAttribute("RowSpan", attribute);
            }
        }

        private static XmlNode smethod_5(XmlElement xmlElement_1, XmlNode xmlNode_0, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            XmlElement element = xmlElement_1.OwnerDocument.CreateElement(null, "Paragraph", string_0);
            XmlNode node = null;
            while (xmlNode_0 != null)
            {
                if (xmlNode_0 is XmlComment)
                {
                    smethod_10((XmlComment) xmlNode_0, null);
                }
                else if (xmlNode_0 is XmlText)
                {
                    if (xmlNode_0.Value.Trim().Length > 0)
                    {
                        smethod_8(element, xmlNode_0.Value);
                    }
                }
                else if (xmlNode_0 is XmlElement)
                {
                    if (Class26.smethod_1(((XmlElement) xmlNode_0).LocalName.ToLower()))
                    {
                        break;
                    }
                    smethod_6(element, (XmlElement) xmlNode_0, hashtable_0, class22_0, list_0);
                }
                node = xmlNode_0;
                xmlNode_0 = xmlNode_0.NextSibling;
            }
            if (element.FirstChild != null)
            {
                xmlElement_1.AppendChild(element);
            }
            return node;
        }

        private static void smethod_6(XmlElement xmlElement_1, XmlNode xmlNode_0, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            if (xmlNode_0 is XmlComment)
            {
                smethod_10((XmlComment) xmlNode_0, xmlElement_1);
            }
            else if (xmlNode_0 is XmlText)
            {
                smethod_8(xmlElement_1, xmlNode_0.Value);
            }
            else if (xmlNode_0 is XmlElement)
            {
                XmlElement item = (XmlElement) xmlNode_0;
                if (item.NamespaceURI == "http://www.w3.org/1999/xhtml")
                {
                    string str = item.LocalName.ToLower();
                    list_0.Add(item);
                    switch (str)
                    {
                        case "a":
                            smethod_9(xmlElement_1, item, hashtable_0, class22_0, list_0);
                            break;

                        case "img":
                            smethod_12(xmlElement_1, item, hashtable_0, class22_0, list_0);
                            break;

                        case "br":
                        case "hr":
                            smethod_2(xmlElement_1, str);
                            break;

                        default:
                            if (Class26.smethod_2(str) || Class26.smethod_1(str))
                            {
                                smethod_7(xmlElement_1, item, hashtable_0, class22_0, list_0);
                            }
                            break;
                    }
                    list_0.RemoveAt(list_0.Count - 1);
                }
            }
        }

        private static void smethod_7(XmlElement xmlElement_1, XmlElement xmlElement_2, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            Hashtable hashtable;
            bool flag = false;
            for (XmlNode node = xmlElement_2.FirstChild; node != null; node = node.NextSibling)
            {
                if (node is XmlElement)
                {
                    string str2 = ((XmlElement) node).LocalName.ToLower();
                    if (((Class26.smethod_2(str2) || Class26.smethod_1(str2)) || ((str2 == "img") || (str2 == "br"))) || (str2 == "hr"))
                    {
                        flag = true;
                        break;
                    }
                }
            }
            string localName = flag ? "Span" : "Run";
            Hashtable hashtable2 = smethod_38(xmlElement_2, hashtable_0, out hashtable, class22_0, list_0);
            XmlElement element = xmlElement_1.OwnerDocument.CreateElement(null, localName, string_0);
            smethod_35(element, hashtable, false);
            for (XmlNode node2 = xmlElement_2.FirstChild; node2 != null; node2 = node2.NextSibling)
            {
                smethod_6(element, node2, hashtable2, class22_0, list_0);
            }
            xmlElement_1.AppendChild(element);
        }

        private static void smethod_8(XmlElement xmlElement_1, string string_1)
        {
            for (int i = 0; i < string_1.Length; i++)
            {
                if (char.IsControl(string_1[i]))
                {
                    string_1 = string_1.Remove(i--, 1);
                }
            }
            string_1 = string_1.Replace('\x00a0', ' ');
            if (string_1.Length > 0)
            {
                xmlElement_1.AppendChild(xmlElement_1.OwnerDocument.CreateTextNode(string_1));
            }
        }

        private static void smethod_9(XmlElement xmlElement_1, XmlElement xmlElement_2, Hashtable hashtable_0, Class22 class22_0, List<XmlElement> list_0)
        {
            string attribute = GetAttribute(xmlElement_2, "href");
            if (attribute == null)
            {
                smethod_7(xmlElement_1, xmlElement_2, hashtable_0, class22_0, list_0);
            }
            else
            {
                Hashtable hashtable;
                Hashtable hashtable2 = smethod_38(xmlElement_2, hashtable_0, out hashtable, class22_0, list_0);
                XmlElement element = xmlElement_1.OwnerDocument.CreateElement(null, "Hyperlink", string_0);
                smethod_35(element, hashtable, false);
                char[] separator = new char[] { '#' };
                string[] strArray = attribute.Split(separator);
                if ((strArray.Length != 0) && (strArray[0].Trim().Length > 0))
                {
                    element.SetAttribute("NavigateUri", strArray[0].Trim());
                }
                if ((strArray.Length == 2) && (strArray[1].Trim().Length > 0))
                {
                    element.SetAttribute("TargetName", strArray[1].Trim());
                }
                for (XmlNode node = xmlElement_2.FirstChild; node != null; node = node.NextSibling)
                {
                    smethod_6(element, node, hashtable2, class22_0, list_0);
                }
                xmlElement_1.AppendChild(element);
            }
        }
    }
}

