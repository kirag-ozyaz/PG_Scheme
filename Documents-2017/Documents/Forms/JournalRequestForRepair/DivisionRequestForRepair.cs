using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct DivisionRequestForRepair
{
    public int int_0;
    public string string_0;
    public DivisionRequestForRepair(int int_1, string string_1)
    {
        this.int_0 = int_1;
        this.string_0 = string_1;
    }

    public override string ToString()
    {
        return this.string_0;
    }
}

