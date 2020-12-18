using MarkupConverter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

internal class Class22
{
    private List<Class23> list_0;

    public Class22(XmlElement xmlElement_0)
    {
        if (xmlElement_0 != null)
        {
            this.method_0(xmlElement_0);
        }
    }

    public void method_0(XmlElement xmlElement_0)
    {
        if (xmlElement_0.LocalName.ToLower() != "link")
        {
            if (xmlElement_0.LocalName.ToLower() != "style")
            {
                for (XmlNode node = xmlElement_0.FirstChild; node != null; node = node.NextSibling)
                {
                    if (node is XmlElement)
                    {
                        this.method_0((XmlElement) node);
                    }
                }
            }
            else
            {
                StringBuilder builder = new StringBuilder();
                for (XmlNode node2 = xmlElement_0.FirstChild; node2 != null; node2 = node2.NextSibling)
                {
                    if ((node2 is XmlText) || (node2 is XmlComment))
                    {
                        builder.Append(this.method_1(node2.Value));
                    }
                }
                int num = 0;
                while (num < builder.Length)
                {
                    int startIndex = num;
                    while (num < builder.Length)
                    {
                        if (builder[num] == '{')
                        {
                            break;
                        }
                        if (builder[num] == '@')
                        {
                            while (num < builder.Length)
                            {
                                if (builder[num] == ';')
                                {
                                    break;
                                }
                                num++;
                            }
                            startIndex = num + 1;
                        }
                        num++;
                    }
                    if (num < builder.Length)
                    {
                        int num3 = num;
                        while (num < builder.Length)
                        {
                            if (builder[num] == '}')
                            {
                                break;
                            }
                            num++;
                        }
                        if ((num - num3) > 2)
                        {
                            this.method_2(builder.ToString(startIndex, num3 - startIndex), builder.ToString(num3 + 1, (num - num3) - 2));
                        }
                        if (num < builder.Length)
                        {
                            num++;
                        }
                    }
                }
            }
        }
    }

    private string method_1(string string_0)
    {
        int index = string_0.IndexOf("/*");
        if (index < 0)
        {
            return string_0;
        }
        int num2 = string_0.IndexOf("*/", (int) (index + 2));
        if (num2 < 0)
        {
            return string_0.Substring(0, index);
        }
        return (string_0.Substring(0, index) + " " + this.method_1(string_0.Substring(num2 + 2)));
    }

    public void method_2(string string_0, string string_1)
    {
        string_0 = string_0.Trim().ToLower();
        string_1 = string_1.Trim().ToLower();
        if ((string_0.Length != 0) && (string_1.Length != 0))
        {
            if (this.list_0 == null)
            {
                this.list_0 = new List<Class23>();
            }
            char[] separator = new char[] { ',' };
            string[] strArray = string_0.Split(separator);
            for (int i = 0; i < strArray.Length; i++)
            {
                string str = strArray[i].Trim();
                if (str.Length > 0)
                {
                    this.list_0.Add(new Class23(str, string_1));
                }
            }
        }
    }

    public string method_3(string string_0, List<XmlElement> list_1)
    {
        if (this.list_0 != null)
        {
            for (int i = this.list_0.Count - 1; i >= 0; i--)
            {
                char[] separator = new char[] { ' ' };
                string[] textArray1 = this.list_0[i].string_0.Split(separator);
                int index = textArray1.Length - 1;
                int count = list_1.Count;
                string str = textArray1[index].Trim();
                if (this.method_4(str, list_1[list_1.Count - 1]))
                {
                    return this.list_0[i].string_1;
                }
            }
        }
        return null;
    }

    private bool method_4(string string_0, XmlElement xmlElement_0)
    {
        if (string_0.Length == 0)
        {
            return false;
        }
        int index = string_0.IndexOf('.');
        int length = string_0.IndexOf('#');
        string str = null;
        string str2 = null;
        string str3 = null;
        if (index >= 0)
        {
            if (index > 0)
            {
                str3 = string_0.Substring(0, index);
            }
            str = string_0.Substring(index + 1);
        }
        else if (length >= 0)
        {
            if (length > 0)
            {
                str3 = string_0.Substring(0, length);
            }
            str2 = string_0.Substring(length + 1);
        }
        else
        {
            str3 = string_0;
        }
        if ((str3 != null) && (str3 != xmlElement_0.LocalName))
        {
            return false;
        }
        if ((str2 != null) && (HtmlToXamlConverter.GetAttribute(xmlElement_0, "id") != str2))
        {
            return false;
        }
        if ((str != null) && (HtmlToXamlConverter.GetAttribute(xmlElement_0, "class") != str))
        {
            return false;
        }
        return true;
    }

    private class Class23
    {
        public string string_0;
        public string string_1;

        public Class23(string string_2, string string_3)
        {
            this.string_0 = string_2;
            this.string_1 = string_3;
        }
    }
}

