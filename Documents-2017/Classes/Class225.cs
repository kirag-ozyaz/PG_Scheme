using System;
using System.Runtime.CompilerServices;

internal class Class225
{
    [CompilerGenerated]
    private decimal decimal_0;
    [CompilerGenerated]
    private decimal decimal_1;
    [CompilerGenerated]
    private decimal decimal_2;
    [CompilerGenerated]
    private decimal decimal_3;
    [CompilerGenerated]
    private decimal decimal_4;
    [CompilerGenerated]
    private decimal decimal_5;
    [CompilerGenerated]
    private decimal decimal_6;

    internal Class225()
    {
        this.method_1(decimal.Zero);
        this.method_3(decimal.Zero);
        this.method_5(decimal.Zero);
        this.method_7(decimal.Zero);
        this.method_9(decimal.Zero);
        this.method_11(decimal.Zero);
    }

    internal Class225(decimal decimal_7, decimal decimal_8, decimal decimal_9, decimal decimal_10, decimal decimal_11, decimal decimal_12, decimal decimal_13)
    {
        this.method_1(decimal_7);
        this.method_3(decimal_8);
        this.method_5(decimal_9);
        this.method_7(decimal_10);
        this.method_9(decimal_11);
        this.method_11(decimal_12);
        this.method_13(decimal_13);
    }

    [CompilerGenerated]
    public decimal method_0()
    {
        return this.decimal_0;
    }

    [CompilerGenerated]
    public void method_1(decimal decimal_7)
    {
        this.decimal_0 = decimal_7;
    }

    [CompilerGenerated]
    public decimal method_10()
    {
        return this.decimal_5;
    }

    [CompilerGenerated]
    public void method_11(decimal decimal_7)
    {
        this.decimal_5 = decimal_7;
    }

    [CompilerGenerated]
    public decimal method_12()
    {
        return this.decimal_6;
    }

    [CompilerGenerated]
    public void method_13(decimal decimal_7)
    {
        this.decimal_6 = decimal_7;
    }

    public decimal method_14()
    {
        return (((this.method_0() + this.method_4()) + this.method_8()) / 3M);
    }

    public decimal method_15()
    {
        return (((this.method_2() + this.method_6()) + this.method_10()) / 3M);
    }

    public decimal method_16()
    {
        return (this.method_14() / (this.method_12() / 100M));
    }

    public decimal method_17()
    {
        return Math.Round((decimal) (this.method_15() / (this.method_12() / 100M)), 0);
    }

    public decimal method_18()
    {
        return (Math.Max(Math.Max(Math.Abs((decimal) (this.method_0() - this.method_4())), Math.Abs((decimal) (this.method_0() - this.method_8()))), Math.Abs((decimal) (this.method_4() - this.method_8()))) / (((this.method_0() + this.method_4()) + this.method_8()) / 100M));
    }

    public decimal method_19()
    {
        return (Math.Max(Math.Max(Math.Abs((decimal) (this.method_2() - this.method_6())), Math.Abs((decimal) (this.method_2() - this.method_10()))), Math.Abs((decimal) (this.method_6() - this.method_10()))) / (((this.method_2() + this.method_6()) + this.method_10()) / 100M));
    }

    [CompilerGenerated]
    public decimal method_2()
    {
        return this.decimal_1;
    }

    [CompilerGenerated]
    public void method_3(decimal decimal_7)
    {
        this.decimal_1 = decimal_7;
    }

    [CompilerGenerated]
    public decimal method_4()
    {
        return this.decimal_2;
    }

    [CompilerGenerated]
    public void method_5(decimal decimal_7)
    {
        this.decimal_2 = decimal_7;
    }

    [CompilerGenerated]
    public decimal method_6()
    {
        return this.decimal_3;
    }

    [CompilerGenerated]
    public void method_7(decimal decimal_7)
    {
        this.decimal_3 = decimal_7;
    }

    [CompilerGenerated]
    public decimal method_8()
    {
        return this.decimal_4;
    }

    [CompilerGenerated]
    public void method_9(decimal decimal_7)
    {
        this.decimal_4 = decimal_7;
    }
}

