using System;
using System.IO;
using System.Text;

internal class Class24
{
    private bool bool_0;
    private bool bool_1;
    private char char_0;
    private char char_1;
    private char char_2;
    private Enum0 enum0_0;
    private int int_0;
    private int int_1;
    private StringBuilder stringBuilder_0;
    private StringReader stringReader_0;

    internal Class24(string string_0)
    {
        this.stringReader_0 = new StringReader(string_0);
        this.int_0 = 0;
        this.char_0 = ' ';
        this.int_1 = this.stringReader_0.Read();
        this.char_1 = (char) this.int_1;
        this.char_2 = ' ';
        this.bool_0 = true;
        this.stringBuilder_0 = new StringBuilder(100);
        this.enum0_0 = Enum0.const_7;
        this.method_6();
    }

    internal void method_0()
    {
        this.stringBuilder_0.Length = 0;
        if (this.method_18())
        {
            this.enum0_0 = Enum0.const_9;
        }
        else if (this.method_19())
        {
            this.method_6();
            if (this.method_17() == '/')
            {
                this.stringBuilder_0.Append("</");
                this.enum0_0 = Enum0.const_1;
                this.method_6();
                this.bool_0 = false;
            }
            else
            {
                this.enum0_0 = Enum0.const_0;
                this.stringBuilder_0.Append("<");
                this.bool_0 = true;
            }
        }
        else if (this.method_21())
        {
            this.method_6();
            if (this.char_1 == '[')
            {
                this.method_13();
            }
            else if (this.char_1 == '-')
            {
                this.method_14();
            }
            else
            {
                this.method_15();
            }
        }
        else
        {
            this.enum0_0 = Enum0.const_7;
            while (!this.method_19())
            {
                if (this.method_18() || this.method_21())
                {
                    break;
                }
                if (((this.method_17() == '<') && !this.method_22()) && (this.char_1 == '?'))
                {
                    this.method_16();
                }
                else
                {
                    if (this.method_17() <= ' ')
                    {
                        if (!this.bool_0)
                        {
                            this.stringBuilder_0.Append(' ');
                        }
                        this.bool_0 = true;
                    }
                    else
                    {
                        this.stringBuilder_0.Append(this.method_17());
                        this.bool_0 = false;
                    }
                    this.method_6();
                }
            }
        }
    }

    internal void method_1()
    {
        this.stringBuilder_0.Length = 0;
        if (this.method_18())
        {
            this.enum0_0 = Enum0.const_9;
        }
        else
        {
            this.method_8();
            if ((this.method_17() == '>') && !this.method_22())
            {
                this.enum0_0 = Enum0.const_2;
                this.stringBuilder_0.Append('>');
                this.method_6();
            }
            else if ((this.method_17() == '/') && (this.char_1 == '>'))
            {
                this.enum0_0 = Enum0.const_3;
                this.stringBuilder_0.Append("/>");
                this.method_6();
                this.method_6();
                this.bool_0 = false;
            }
            else if (!this.method_9(this.method_17()))
            {
                this.enum0_0 = Enum0.const_6;
                this.stringBuilder_0.Append(this.method_17());
                this.method_6();
            }
            else
            {
                this.enum0_0 = Enum0.const_5;
                while (this.method_10(this.method_17()))
                {
                    if (this.method_18())
                    {
                        return;
                    }
                    this.stringBuilder_0.Append(this.method_17());
                    this.method_6();
                }
            }
        }
    }

    private bool method_10(char char_3)
    {
        if (((!this.method_9(char_3) && (char_3 != '.')) && ((char_3 != '-') && (char_3 != ':'))) && (!char.IsDigit(char_3) && !this.method_11(char_3)))
        {
            return this.method_12(char_3);
        }
        return true;
    }

    private bool method_11(char char_3)
    {
        return false;
    }

    private bool method_12(char char_3)
    {
        return false;
    }

    private void method_13()
    {
        this.enum0_0 = Enum0.const_7;
        this.stringBuilder_0.Length = 0;
        this.method_6();
        this.method_6();
        while ((this.char_0 != ']') || (this.char_1 != '>'))
        {
            if (this.method_18())
            {
                break;
            }
            this.method_6();
        }
        if (!this.method_18())
        {
            this.method_6();
            this.method_6();
        }
    }

    private void method_14()
    {
        this.enum0_0 = Enum0.const_8;
        this.stringBuilder_0.Length = 0;
        this.method_6();
        this.method_6();
        this.method_6();
        while (true)
        {
            while (this.method_18() || (((this.char_0 == '-') && (this.char_1 == '-')) || ((this.char_0 == '!') && (this.char_1 == '>'))))
            {
                this.method_6();
                if (((this.char_2 == '-') && (this.char_0 == '-')) && (this.char_1 == '>'))
                {
                    this.method_6();
                    break;
                }
                if ((this.char_2 == '!') && (this.char_0 == '>'))
                {
                    break;
                }
                this.stringBuilder_0.Append(this.char_2);
            }
            this.stringBuilder_0.Append(this.method_17());
            this.method_6();
        }
        if (this.char_0 == '>')
        {
            this.method_6();
        }
    }

    private void method_15()
    {
        this.enum0_0 = Enum0.const_7;
        this.stringBuilder_0.Length = 0;
        this.method_6();
        while ((this.char_0 != '>') || this.method_22())
        {
            if (this.method_18())
            {
                break;
            }
            this.method_6();
        }
        if (!this.method_18())
        {
            this.method_6();
        }
    }

    private void method_16()
    {
        this.method_6();
        this.method_6();
        while (((this.char_0 != '?') && (this.char_0 != '/')) || (this.char_1 != '>'))
        {
            if (this.method_18())
            {
                break;
            }
            this.method_6();
        }
        if (!this.method_18())
        {
            this.method_6();
            this.method_6();
        }
    }

    private char method_17()
    {
        return this.char_0;
    }

    private bool method_18()
    {
        return (this.int_0 == -1);
    }

    private bool method_19()
    {
        if ((this.char_0 != '<') || ((this.char_1 != '/') && !this.method_9(this.char_1)))
        {
            return false;
        }
        return !this.bool_1;
    }

    internal void method_2()
    {
        this.stringBuilder_0.Length = 0;
        this.stringBuilder_0.Append('=');
        this.enum0_0 = Enum0.const_4;
        this.method_8();
        if (this.method_17() == '=')
        {
            this.method_6();
        }
    }

    private bool method_20()
    {
        return (((this.char_0 == '>') || ((this.char_0 == '/') && (this.char_1 == '>'))) && !this.bool_1);
    }

    private bool method_21()
    {
        return (((this.char_0 == '<') && (this.char_1 == '!')) && !this.method_22());
    }

    private bool method_22()
    {
        return this.bool_1;
    }

    internal void method_3()
    {
        this.stringBuilder_0.Length = 0;
        this.method_8();
        this.enum0_0 = Enum0.const_6;
        if (((this.method_17() != '\'') && (this.method_17() != '"')) || this.method_22())
        {
            while (!this.method_18())
            {
                if (char.IsWhiteSpace(this.method_17()) || (this.method_17() == '>'))
                {
                    return;
                }
                this.stringBuilder_0.Append(this.method_17());
                this.method_6();
            }
        }
        else
        {
            char ch = this.method_17();
            this.method_6();
            while ((this.method_17() != ch) || this.method_22())
            {
                if (this.method_18())
                {
                    break;
                }
                this.stringBuilder_0.Append(this.method_17());
                this.method_6();
            }
            if (this.method_17() == ch)
            {
                this.method_6();
            }
        }
    }

    internal Enum0 method_4()
    {
        return this.enum0_0;
    }

    internal string method_5()
    {
        return this.stringBuilder_0.ToString();
    }

    private void method_6()
    {
        if (this.int_0 == -1)
        {
            throw new InvalidOperationException("GetNextCharacter method called at the end of a stream");
        }
        this.char_2 = this.char_0;
        this.char_0 = this.char_1;
        this.int_0 = this.int_1;
        this.bool_1 = false;
        this.method_7();
        if (this.char_0 == '&')
        {
            if (this.char_1 != '#')
            {
                if (char.IsLetter(this.char_1))
                {
                    string str = "";
                    for (int i = 0; i < 10; i++)
                    {
                        if (!char.IsLetter(this.char_1) && !char.IsDigit(this.char_1))
                        {
                            break;
                        }
                        str = str + this.char_1.ToString();
                        this.method_7();
                    }
                    if (this.char_1 == ';')
                    {
                        this.method_7();
                        if (Class26.smethod_6(str))
                        {
                            this.char_0 = Class26.smethod_7(str);
                            this.int_0 = this.char_0;
                            this.bool_1 = true;
                        }
                        else
                        {
                            this.char_0 = this.char_1;
                            this.int_0 = this.int_1;
                            this.method_7();
                            this.bool_1 = false;
                        }
                    }
                    else
                    {
                        this.char_0 = this.char_1;
                        this.method_7();
                        this.bool_1 = false;
                    }
                }
            }
            else
            {
                int num = 0;
                this.method_7();
                for (int j = 0; j < 7; j++)
                {
                    if (!char.IsDigit(this.char_1))
                    {
                        break;
                    }
                    num = (10 * num) + (this.int_1 - 0x30);
                    this.method_7();
                }
                if (this.char_1 == ';')
                {
                    this.method_7();
                    this.int_0 = num;
                    this.char_0 = (char) this.int_0;
                    this.bool_1 = true;
                }
                else
                {
                    this.char_0 = this.char_1;
                    this.int_0 = this.int_1;
                    this.method_7();
                    this.bool_1 = false;
                }
            }
        }
    }

    private void method_7()
    {
        if (this.int_1 != -1)
        {
            this.int_1 = this.stringReader_0.Read();
            this.char_1 = (char) this.int_1;
        }
    }

    private void method_8()
    {
        while (true)
        {
            if ((this.char_0 == '<') && ((this.char_1 == '?') || (this.char_1 == '!')))
            {
                this.method_6();
                if (this.char_1 != '[')
                {
                    while (!this.method_18())
                    {
                        if (this.char_0 == '>')
                        {
                            break;
                        }
                        this.method_6();
                    }
                    if (this.char_0 == '>')
                    {
                        this.method_6();
                    }
                }
                else
                {
                    while (!this.method_18())
                    {
                        if (((this.char_2 == ']') && (this.char_0 == ']')) && (this.char_1 == '>'))
                        {
                            break;
                        }
                        this.method_6();
                    }
                    if (this.char_0 == '>')
                    {
                        this.method_6();
                    }
                }
            }
            if (!char.IsWhiteSpace(this.method_17()))
            {
                return;
            }
            this.method_6();
        }
    }

    private bool method_9(char char_3)
    {
        if (char_3 != '_')
        {
            return char.IsLetter(char_3);
        }
        return true;
    }
}

