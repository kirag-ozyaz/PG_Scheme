using System;
using System.Runtime.CompilerServices;

internal class Class29
{
    [CompilerGenerated]
    private int int_0;
    [CompilerGenerated]
    private string string_0;
    [CompilerGenerated]
    private string string_1;
    [CompilerGenerated]
    private string string_2;

    public Class29(int int_1, string string_3, string string_4, string string_5)
    {
        this.Id = int_1;
        this.Name = string_3;
        this.method_1(string_4);
        this.Comment = string_5;
    }

    [CompilerGenerated]
    public string method_0()
    {
        return this.string_1;
    }

    [CompilerGenerated]
    public void method_1(string string_3)
    {
        this.string_1 = string_3;
    }

    public override string ToString()
    {
        return this.Name;
    }

    public string Comment
    {
        [CompilerGenerated]
        get
        {
            return this.string_2;
        }
        [CompilerGenerated]
        set
        {
            this.string_2 = value;
        }
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

