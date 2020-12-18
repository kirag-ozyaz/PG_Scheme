using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct4
{
    internal string str1;
    internal string str2;
    internal Struct4(string txt1, string txt2)
    {
        this.str1 = txt1;
        this.str2 = txt2;
    }
}

