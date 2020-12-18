using System;
using System.Runtime.InteropServices;

[ComVisible(false)]
[AttributeUsage(AttributeTargets.Assembly)]
public sealed class DotfuscatorAttribute : Attribute
{
    private string a;
    private int b;

    public string A
    {
        get
        {
            return this.a;
        }
    }

    public int C
    {
        get
        {
            return this.b;
        }
    }

    public DotfuscatorAttribute(string a, int c)
    {
        this.a = a;
        this.b = c;
    }

    //public string a()
    //{
    //    return this.a;
    //}

    //public int c()
    //{
    //    return this.b;
    //}
}
