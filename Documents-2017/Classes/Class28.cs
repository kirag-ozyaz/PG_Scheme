using System;
using System.Runtime.CompilerServices;

internal class Class28
{
    [CompilerGenerated]
    private int int_0;
    [CompilerGenerated]
    private int int_1;
    [CompilerGenerated]
    private int int_2;
    [CompilerGenerated]
    private string string_0;
    [CompilerGenerated]
    private string string_1;

    public Class28(int int_3, int int_4, int int_5, string string_2, string string_3)
    {
        this.Id = int_3;
        this.IdParent = int_4;
        this.method_3(int_5);
        this.Name = string_2;
        this.method_1(string_3);
    }

    [CompilerGenerated]
    public string method_0()
    {
        return this.string_1;
    }

    [CompilerGenerated]
    public void method_1(string string_2)
    {
        this.string_1 = string_2;
    }

    [CompilerGenerated]
    public int method_2()
    {
        return this.int_1;
    }

    [CompilerGenerated]
    public void method_3(int int_3)
    {
        this.int_1 = int_3;
    }

    public override string ToString()
    {
        return this.Name;
    }

    public int Id
    {
        [CompilerGenerated]
        get
        {
            return this.int_0;
        }
        [CompilerGenerated]
        set
        {
            this.int_0 = value;
        }
    }

    public int IdParent
    {
        [CompilerGenerated]
        get
        {
            return this.int_2;
        }
        [CompilerGenerated]
        set
        {
            this.int_2 = value;
        }
    }

    public string Name
    {
        [CompilerGenerated]
        get
        {
            return this.string_0;
        }
        [CompilerGenerated]
        set
        {
            this.string_0 = value;
        }
    }
}

