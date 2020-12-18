namespace MarkupConverter
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    public static class HtmlFromXamlConverter
    {
        public static string ConvertXamlToHtml(string xamlString, bool asFullDocument)
        {
            StringBuilder sb = new StringBuilder(100);
            XmlTextWriter writer = new XmlTextWriter(new StringWriter(sb));
            if (!smethod_0(new XmlTextReader(new StringReader(xamlString)), writer, asFullDocument))
            {
                return "";
            }
            return sb.ToString();
        }

        private static bool smethod_0(XmlTextReader xmlTextReader_0, XmlTextWriter xmlTextWriter_0, bool bool_0)
        {
            if (!smethod_7(xmlTextReader_0))
            {
                return false;
            }
            if ((xmlTextReader_0.NodeType != XmlNodeType.Element) || (xmlTextReader_0.Name != "FlowDocument"))
            {
                return false;
            }
            StringBuilder builder = new StringBuilder();
            if (bool_0)
            {
                xmlTextWriter_0.WriteStartElement("HTML");
                xmlTextWriter_0.WriteStartElement("BODY");
            }
            smethod_1(xmlTextReader_0, xmlTextWriter_0, builder);
            smethod_4(xmlTextReader_0, xmlTextWriter_0, builder);
            if (bool_0)
            {
                xmlTextWriter_0.WriteEndElement();
                xmlTextWriter_0.WriteEndElement();
            }
            return true;
        }

        private static void smethod_1(XmlTextReader xmlTextReader_0, XmlTextWriter xmlTextWriter_0, StringBuilder stringBuilder_0)
        {
            stringBuilder_0.Remove(0, stringBuilder_0.Length);
            if (xmlTextReader_0.HasAttributes)
            {
                bool flag = false;
                while (xmlTextReader_0.MoveToNextAttribute())
                {
                    string str = null;
                    string name = xmlTextReader_0.Name;
                    uint num = Class227.smethod_0(name);
                    if (num <= 0x820034b6)
                    {
                        if (num <= 0x4f679325)
                        {
                            if (num <= 0x3a03aa28)
                            {
                                switch (num)
                                {
                                    case 0x51b8917:
                                        if (name == "Emphasis")
                                        {
                                        }
                                        goto Label_0582;

                                    case 0x736dd56:
                                        if (name == "Padding")
                                        {
                                            str = "padding:" + smethod_3(xmlTextReader_0.Value) + ";";
                                        }
                                        goto Label_0582;
                                }
                                if ((num == 0x3a03aa28) && (name != "Capitals"))
                                {
                                }
                            }
                            else if (num <= 0x40f37aef)
                            {
                                if (num == 0x3b42dfbf)
                                {
                                    if (name == "Width")
                                    {
                                        str = "width:" + xmlTextReader_0.Value + ";";
                                    }
                                }
                                else if ((num == 0x40f37aef) && (name == "RowSpan"))
                                {
                                    xmlTextWriter_0.WriteAttributeString("ROWSPAN", xmlTextReader_0.Value);
                                }
                            }
                            else if (num != 0x4c70d6bf)
                            {
                                if ((num == 0x4f679325) && (name != "ColumnBreakBefore"))
                                {
                                }
                            }
                            else if (name == "BorderThickness")
                            {
                                str = "border-width:" + smethod_3(xmlTextReader_0.Value) + ";";
                                flag = true;
                            }
                        }
                        else if (num <= 0x6c164db5)
                        {
                            switch (num)
                            {
                                case 0x5880b986:
                                    if (name == "StandardLigatures")
                                    {
                                    }
                                    goto Label_0582;

                                case 0x66e35900:
                                    if (name == "IsKeptWithNext")
                                    {
                                    }
                                    goto Label_0582;
                            }
                            if ((num == 0x6c164db5) && (name == "FontStyle"))
                            {
                                str = "font-style:" + xmlTextReader_0.Value.ToLower() + ";";
                            }
                        }
                        else if (num <= 0x70433edc)
                        {
                            if (num == 0x6d72fe00)
                            {
                                if (name == "TextEffects")
                                {
                                }
                            }
                            else if ((num == 0x70433edc) && (name == "TextIndent"))
                            {
                                str = "text-indent:" + xmlTextReader_0.Value + ";";
                            }
                        }
                        else if (num != 0x725e95cf)
                        {
                            if ((num == 0x820034b6) && (name != "PageBreakBefore"))
                            {
                            }
                        }
                        else if (name == "Variants")
                        {
                        }
                    }
                    else if (num <= 0xb5107238)
                    {
                        if (num <= 0xa79f830d)
                        {
                            switch (num)
                            {
                                case 0x85c49123:
                                    if (name == "ColumnSpan")
                                    {
                                        xmlTextWriter_0.WriteAttributeString("COLSPAN", xmlTextReader_0.Value);
                                    }
                                    goto Label_0582;

                                case 0xa26a44e1:
                                    if (name == "FontSize")
                                    {
                                        str = "font-size:" + xmlTextReader_0.Value + ";";
                                    }
                                    goto Label_0582;
                            }
                            if ((num == 0xa79f830d) && (name != "FontStretch"))
                            {
                            }
                        }
                        else if (num <= 0xa98dc663)
                        {
                            if (num == 0xa8401cf3)
                            {
                                if (name == "IsKeptTogether")
                                {
                                }
                            }
                            else if ((num == 0xa98dc663) && (name == "TextAlignment"))
                            {
                                str = "text-align:" + xmlTextReader_0.Value + ";";
                            }
                        }
                        else if (num != 0xb27ae1a9)
                        {
                            if ((num == 0xb5107238) && (name != "LineHeight"))
                            {
                            }
                        }
                        else if (name == "TextDecorations")
                        {
                            str = "text-decoration:underline;";
                        }
                    }
                    else if (num <= 0xc4cc799b)
                    {
                        if (num <= 0xbafc0abd)
                        {
                            if (num == 0xbabdf163)
                            {
                                if (name == "Fraction")
                                {
                                }
                            }
                            else if ((num == 0xbafc0abd) && (name == "Background"))
                            {
                                str = "background-color:" + smethod_2(xmlTextReader_0.Value) + ";";
                            }
                        }
                        else if (num != 0xc3e4b7da)
                        {
                            if ((num == 0xc4cc799b) && (name == "Margin"))
                            {
                                str = "margin:" + smethod_3(xmlTextReader_0.Value) + ";";
                            }
                        }
                        else if (name == "FlowDirection")
                        {
                        }
                    }
                    else if (num <= 0xd2d98ad5)
                    {
                        if (num == 0xd0616ad0)
                        {
                            if (name == "FontWeight")
                            {
                                str = "font-weight:" + xmlTextReader_0.Value.ToLower() + ";";
                            }
                        }
                        else if ((num == 0xd2d98ad5) && (name == "BorderBrush"))
                        {
                            str = "border-color:" + smethod_2(xmlTextReader_0.Value) + ";";
                            flag = true;
                        }
                    }
                    else if (num != 0xd96b36e0)
                    {
                        if ((num == 0xf6319880) && (name == "FontFamily"))
                        {
                            str = "font-family:" + xmlTextReader_0.Value + ";";
                        }
                    }
                    else if (name == "Foreground")
                    {
                        str = "color:" + smethod_2(xmlTextReader_0.Value) + ";";
                    }
                Label_0582:
                    if (str != null)
                    {
                        stringBuilder_0.Append(str);
                    }
                }
                if (flag)
                {
                    stringBuilder_0.Append("border-style:solid;mso-element:para-border-div;");
                }
                xmlTextReader_0.MoveToElement();
            }
        }

        private static string smethod_2(string string_0)
        {
            if (string_0.StartsWith("#"))
            {
                string_0 = "#" + string_0.Substring(3);
            }
            return string_0;
        }

        private static string smethod_3(string string_0)
        {
            char[] separator = new char[] { ',' };
            string[] strArray = string_0.Split(separator);
            for (int i = 0; i < strArray.Length; i++)
            {
                double num2;
                if (double.TryParse(strArray[i], out num2))
                {
                    strArray[i] = Math.Ceiling(num2).ToString();
                }
                else
                {
                    strArray[i] = "1";
                }
            }
            switch (strArray.Length)
            {
                case 1:
                    return string_0;

                case 2:
                    return (strArray[1] + " " + strArray[0]);

                case 4:
                {
                    string[] textArray1 = new string[] { strArray[1], " ", strArray[2], " ", strArray[3], " ", strArray[0] };
                    return string.Concat(textArray1);
                }
            }
            return strArray[0];
        }

        private static void smethod_4(XmlTextReader xmlTextReader_0, XmlTextWriter xmlTextWriter_0, StringBuilder stringBuilder_0)
        {
            bool flag = false;
            if (!xmlTextReader_0.IsEmptyElement)
            {
                while (smethod_7(xmlTextReader_0))
                {
                    switch (xmlTextReader_0.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (!xmlTextReader_0.Name.Contains("."))
                            {
                                if (((xmlTextWriter_0 != null) && !flag) && (stringBuilder_0.Length > 0))
                                {
                                    xmlTextWriter_0.WriteAttributeString("STYLE", stringBuilder_0.ToString());
                                    stringBuilder_0.Remove(0, stringBuilder_0.Length);
                                }
                                flag = true;
                                smethod_6(xmlTextReader_0, xmlTextWriter_0, stringBuilder_0);
                                break;
                            }
                            smethod_5(xmlTextReader_0, stringBuilder_0);
                            break;

                        case XmlNodeType.Text:
                        case XmlNodeType.CDATA:
                        case XmlNodeType.SignificantWhitespace:
                            if (xmlTextWriter_0 != null)
                            {
                                if (!flag && (stringBuilder_0.Length > 0))
                                {
                                    xmlTextWriter_0.WriteAttributeString("STYLE", stringBuilder_0.ToString());
                                }
                                xmlTextWriter_0.WriteString(xmlTextReader_0.Value);
                            }
                            flag = true;
                            break;

                        case XmlNodeType.Comment:
                            if (xmlTextWriter_0 != null)
                            {
                                if (!flag && (stringBuilder_0.Length > 0))
                                {
                                    xmlTextWriter_0.WriteAttributeString("STYLE", stringBuilder_0.ToString());
                                }
                                xmlTextWriter_0.WriteComment(xmlTextReader_0.Value);
                            }
                            flag = true;
                            break;

                        case XmlNodeType.EndElement:
                            return;
                    }
                }
            }
            else
            {
                if (((xmlTextWriter_0 != null) && !flag) && (stringBuilder_0.Length > 0))
                {
                    xmlTextWriter_0.WriteAttributeString("STYLE", stringBuilder_0.ToString());
                    stringBuilder_0.Remove(0, stringBuilder_0.Length);
                }
                flag = true;
            }
        }

        private static void smethod_5(XmlTextReader xmlTextReader_0, StringBuilder stringBuilder_0)
        {
            if ((stringBuilder_0 != null) && xmlTextReader_0.Name.EndsWith(".TextDecorations"))
            {
                stringBuilder_0.Append("text-decoration:underline;");
            }
            smethod_4(xmlTextReader_0, null, null);
        }

        private static void smethod_6(XmlTextReader xmlTextReader_0, XmlTextWriter xmlTextWriter_0, StringBuilder stringBuilder_0)
        {
            if (xmlTextWriter_0 == null)
            {
                smethod_4(xmlTextReader_0, null, null);
                return;
            }
            string localName = null;
            string name = xmlTextReader_0.Name;
            uint num = Class227.smethod_0(name);
            if (num <= 0x8db0c08d)
            {
                if (num <= 0x5293aed9)
                {
                    switch (num)
                    {
                        case 0x2d877b6c:
                            if (name != "Section")
                            {
                                goto Label_02B7;
                            }
                            localName = "DIV";
                            goto Label_02C1;

                        case 0x45768d96:
                            if (name != "Bold")
                            {
                                goto Label_02B7;
                            }
                            localName = "B";
                            goto Label_02C1;
                    }
                    if ((num != 0x5293aed9) || (name != "Paragraph"))
                    {
                        goto Label_02B7;
                    }
                    localName = "P";
                    goto Label_02C1;
                }
                if (num <= 0x8d2937a1)
                {
                    if (num != 0x8937771b)
                    {
                        if ((num != 0x8d2937a1) || (name != "List"))
                        {
                            goto Label_02B7;
                        }
                        string attribute = xmlTextReader_0.GetAttribute("MarkerStyle");
                        if ((((attribute != null) && (attribute != "None")) && ((attribute != "Disc") && (attribute != "Circle"))) && ((attribute != "Square") && (attribute != "Box")))
                        {
                            localName = "OL";
                        }
                        else
                        {
                            localName = "UL";
                        }
                    }
                    else
                    {
                        if (name != "BlockUIContainer")
                        {
                            goto Label_02B7;
                        }
                        localName = "DIV";
                    }
                    goto Label_02C1;
                }
                if (num != 0x8d57e66a)
                {
                    if ((num != 0x8db0c08d) || (name != "Italic"))
                    {
                        goto Label_02B7;
                    }
                    localName = "I";
                    goto Label_02C1;
                }
                if (name == "Run")
                {
                    goto Label_0234;
                }
                goto Label_02B7;
            }
            if (num > 0xc3ac8d1a)
            {
                if (num <= 0xd65ae10d)
                {
                    if (num != 0xc3cd167d)
                    {
                        if ((num != 0xd65ae10d) || (name != "TableRow"))
                        {
                            goto Label_02B7;
                        }
                        localName = "TR";
                    }
                    else
                    {
                        if (name != "InlineUIContainer")
                        {
                            goto Label_02B7;
                        }
                        localName = "SPAN";
                    }
                    goto Label_02C1;
                }
                if (num != 0xd70ceb7f)
                {
                    if ((num != 0xeca5d2c3) || (name != "TableCell"))
                    {
                        goto Label_02B7;
                    }
                    localName = "TD";
                    goto Label_02C1;
                }
                if (name == "Table")
                {
                    localName = "TABLE";
                    goto Label_02C1;
                }
                goto Label_02B7;
            }
            if (num <= 0xa94a400d)
            {
                if (num != 0x9ea37dd4)
                {
                    if ((num != 0xa94a400d) || (name != "TableColumn"))
                    {
                        goto Label_02B7;
                    }
                    localName = "COL";
                }
                else
                {
                    if (name != "TableRowGroup")
                    {
                        goto Label_02B7;
                    }
                    localName = "TBODY";
                }
                goto Label_02C1;
            }
            if (num != 0xaba837e1)
            {
                if ((num != 0xc3ac8d1a) || (name != "ListItem"))
                {
                    goto Label_02B7;
                }
                localName = "LI";
                goto Label_02C1;
            }
            if (name != "Span")
            {
                goto Label_02B7;
            }
        Label_0234:
            localName = "SPAN";
            goto Label_02C1;
        Label_02B7:
            localName = null;
        Label_02C1:
            if ((xmlTextWriter_0 != null) && (localName != null))
            {
                xmlTextWriter_0.WriteStartElement(localName);
                smethod_1(xmlTextReader_0, xmlTextWriter_0, stringBuilder_0);
                smethod_4(xmlTextReader_0, xmlTextWriter_0, stringBuilder_0);
                xmlTextWriter_0.WriteEndElement();
            }
            else
            {
                smethod_4(xmlTextReader_0, null, null);
            }
        }

        private static bool smethod_7(XmlReader xmlReader_0)
        {
            while (xmlReader_0.Read())
            {
                switch (xmlReader_0.NodeType)
                {
                    case XmlNodeType.None:
                    case XmlNodeType.Element:
                    case XmlNodeType.Text:
                    case XmlNodeType.CDATA:
                    case XmlNodeType.SignificantWhitespace:
                    case XmlNodeType.EndElement:
                        return true;

                    case XmlNodeType.Comment:
                        return true;

                    case XmlNodeType.Whitespace:
                        if (xmlReader_0.XmlSpace == XmlSpace.Preserve)
                        {
                            return true;
                        }
                        break;
                }
            }
            return false;
        }
    }
}

