using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

internal class Class25
{
    private Class24 class24_0;
    private Stack<XmlElement> stack_0 = new Stack<XmlElement>();
    private Stack<XmlElement> stack_1 = new Stack<XmlElement>();
    internal const string string_0 = "Version:1.0\r\nStartHTML:{0:D10}\r\nEndHTML:{1:D10}\r\nStartFragment:{2:D10}\r\nEndFragment:{3:D10}\r\nStartSelection:{4:D10}\r\nEndSelection:{5:D10}\r\n";
    internal const string string_1 = "<!--StartFragment-->";
    internal const string string_2 = "<!--EndFragment-->";
    internal const string string_3 = "http://www.w3.org/1999/xhtml";
    private XmlDocument xmlDocument_0 = new XmlDocument();

    private Class25(string string_4)
    {
        this.class24_0 = new Class24(string_4);
        this.class24_0.method_0();
    }

    private void method_0(bool bool_0, string string_4)
    {
        if (!bool_0)
        {
            throw new Exception("Assertion error: " + string_4);
        }
    }

    private XmlElement method_1()
    {
        XmlElement firstChild = this.xmlDocument_0.CreateElement("html", "http://www.w3.org/1999/xhtml");
        this.method_5(firstChild);
        while (this.class24_0.method_4() != Enum0.const_9)
        {
            if (this.class24_0.method_4() == Enum0.const_0)
            {
                this.class24_0.method_1();
                if (this.class24_0.method_4() == Enum0.const_5)
                {
                    string qualifiedName = this.class24_0.method_5().ToLower();
                    this.class24_0.method_1();
                    XmlElement element2 = this.xmlDocument_0.CreateElement(qualifiedName, "http://www.w3.org/1999/xhtml");
                    this.method_11(element2);
                    if ((this.class24_0.method_4() != Enum0.const_3) && !Class26.smethod_0(qualifiedName))
                    {
                        if (Class26.smethod_2(qualifiedName))
                        {
                            this.method_4(element2);
                        }
                        else if (Class26.smethod_1(qualifiedName) || Class26.smethod_3(qualifiedName))
                        {
                            this.method_5(element2);
                        }
                    }
                    else
                    {
                        this.method_3(element2);
                    }
                }
            }
            else if (this.class24_0.method_4() == Enum0.const_1)
            {
                this.class24_0.method_1();
                if (this.class24_0.method_4() == Enum0.const_5)
                {
                    string str2 = this.class24_0.method_5().ToLower();
                    this.class24_0.method_1();
                    this.method_7(str2);
                }
            }
            else if (this.class24_0.method_4() == Enum0.const_7)
            {
                this.method_8(this.class24_0.method_5());
            }
            else if (this.class24_0.method_4() == Enum0.const_8)
            {
                this.method_9(this.class24_0.method_5());
            }
            this.class24_0.method_0();
        }
        if (((firstChild.FirstChild is XmlElement) && (firstChild.FirstChild == firstChild.LastChild)) && (firstChild.FirstChild.LocalName.ToLower() == "html"))
        {
            firstChild = (XmlElement) firstChild.FirstChild;
        }
        return firstChild;
    }

    private void method_10()
    {
        if (this.stack_1.Count > 0)
        {
            XmlElement newChild = this.stack_1.Pop();
            this.method_10();
            this.method_0(this.stack_0.Count > 0, "OpenPendingInlineElements: Stack of opened elements cannot be empty, as we have at least one artificial root element");
            this.stack_0.Peek().AppendChild(newChild);
            this.stack_0.Push(newChild);
        }
    }

    private void method_11(XmlElement xmlElement_0)
    {
        while (this.class24_0.method_4() != Enum0.const_9)
        {
            if ((this.class24_0.method_4() == Enum0.const_2) || (this.class24_0.method_4() == Enum0.const_3))
            {
                break;
            }
            if (this.class24_0.method_4() == Enum0.const_5)
            {
                string name = this.class24_0.method_5();
                this.class24_0.method_2();
                this.class24_0.method_3();
                string str2 = this.class24_0.method_5();
                xmlElement_0.SetAttribute(name, str2);
            }
            this.class24_0.method_1();
        }
    }

    private XmlElement method_2(XmlElement xmlElement_0)
    {
        XmlElement element = this.xmlDocument_0.CreateElement(xmlElement_0.LocalName, "http://www.w3.org/1999/xhtml");
        for (int i = 0; i < xmlElement_0.Attributes.Count; i++)
        {
            XmlAttribute attribute = xmlElement_0.Attributes[i];
            element.SetAttribute(attribute.Name, attribute.Value);
        }
        return element;
    }

    private void method_3(XmlElement xmlElement_0)
    {
        this.method_0(this.stack_0.Count > 0, "AddEmptyElement: Stack of opened elements cannot be empty, as we have at least one artificial root element");
        this.stack_0.Peek().AppendChild(xmlElement_0);
    }

    private void method_4(XmlElement xmlElement_0)
    {
        this.stack_1.Push(xmlElement_0);
    }

    private void method_5(XmlElement xmlElement_0)
    {
        if (Class26.smethod_1(xmlElement_0.LocalName))
        {
            while (this.stack_0.Count > 0)
            {
                if (!Class26.smethod_2(this.stack_0.Peek().LocalName))
                {
                    break;
                }
                XmlElement element = this.stack_0.Pop();
                this.method_0(this.stack_0.Count > 0, "OpenStructuringElement: stack of opened elements cannot become empty here");
                this.stack_1.Push(this.method_2(element));
            }
        }
        if (this.stack_0.Count > 0)
        {
            XmlElement element2 = this.stack_0.Peek();
            if (Class26.smethod_5(element2.LocalName, xmlElement_0.LocalName))
            {
                this.stack_0.Pop();
                element2 = (this.stack_0.Count > 0) ? this.stack_0.Peek() : null;
            }
            if (element2 != null)
            {
                element2.AppendChild(xmlElement_0);
            }
        }
        this.stack_0.Push(xmlElement_0);
    }

    private bool method_6(string string_4)
    {
        using (Stack<XmlElement>.Enumerator enumerator = this.stack_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                if (enumerator.Current.LocalName == string_4)
                {
                    return true;
                }
            }
        }
        return false;
    }

    private void method_7(string string_4)
    {
        this.method_0(this.stack_0.Count > 0, "CloseElement: Stack of opened elements cannot be empty, as we have at least one artificial root element");
        if ((this.stack_1.Count > 0) && (this.stack_1.Peek().LocalName == string_4))
        {
            XmlElement newChild = this.stack_1.Pop();
            this.method_0(this.stack_0.Count > 0, "CloseElement: Stack of opened elements cannot be empty, as we have at least one artificial root element");
            this.stack_0.Peek().AppendChild(newChild);
        }
        else if (this.method_6(string_4))
        {
            while (this.stack_0.Count > 1)
            {
                XmlElement element2 = this.stack_0.Pop();
                if (element2.LocalName == string_4)
                {
                    return;
                }
                if (Class26.smethod_2(element2.LocalName))
                {
                    this.stack_1.Push(this.method_2(element2));
                }
            }
        }
    }

    private void method_8(string string_4)
    {
        this.method_10();
        this.method_0(this.stack_0.Count > 0, "AddTextContent: Stack of opened elements cannot be empty, as we have at least one artificial root element");
        this.stack_0.Peek().AppendChild(this.xmlDocument_0.CreateTextNode(string_4));
    }

    private void method_9(string string_4)
    {
        this.method_10();
        this.method_0(this.stack_0.Count > 0, "AddComment: Stack of opened elements cannot be empty, as we have at least one artificial root element");
        this.stack_0.Peek().AppendChild(this.xmlDocument_0.CreateComment(string_4));
    }

    internal static XmlElement smethod_0(string string_4)
    {
        return new Class25(string_4).method_1();
    }

    internal static string smethod_1(string string_4)
    {
        int index = string_4.IndexOf("StartHTML:");
        if (index < 0)
        {
            return "ERROR: Urecognized html header";
        }
        index = int.Parse(string_4.Substring(index + "StartHTML:".Length, "0123456789".Length));
        if ((index < 0) || (index > string_4.Length))
        {
            return "ERROR: Urecognized html header";
        }
        int length = string_4.IndexOf("EndHTML:");
        if (length < 0)
        {
            return "ERROR: Urecognized html header";
        }
        length = int.Parse(string_4.Substring(length + "EndHTML:".Length, "0123456789".Length));
        if (length > string_4.Length)
        {
            length = string_4.Length;
        }
        return string_4.Substring(index, length - index);
    }

    internal static string smethod_2(string string_4)
    {
        StringBuilder builder = new StringBuilder();
        int num = "Version:1.0\r\nStartHTML:{0:D10}\r\nEndHTML:{1:D10}\r\nStartFragment:{2:D10}\r\nEndFragment:{3:D10}\r\nStartSelection:{4:D10}\r\nEndSelection:{5:D10}\r\n".Length + (6 * ("0123456789".Length - "{0:D10}".Length));
        int num2 = num + string_4.Length;
        int index = string_4.IndexOf("<!--StartFragment-->", 0);
        if (index >= 0)
        {
            index = (num + index) + "<!--StartFragment-->".Length;
        }
        else
        {
            index = num;
        }
        int num4 = string_4.IndexOf("<!--EndFragment-->", 0);
        if (num4 >= 0)
        {
            num4 = num + num4;
        }
        else
        {
            num4 = num2;
        }
        object[] args = new object[] { num, num2, index, num4, index, num4 };
        builder.AppendFormat("Version:1.0\r\nStartHTML:{0:D10}\r\nEndHTML:{1:D10}\r\nStartFragment:{2:D10}\r\nEndFragment:{3:D10}\r\nStartSelection:{4:D10}\r\nEndSelection:{5:D10}\r\n", args);
        builder.Append(string_4);
        return builder.ToString();
    }
}

