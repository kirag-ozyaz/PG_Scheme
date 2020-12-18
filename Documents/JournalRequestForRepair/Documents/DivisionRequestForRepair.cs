using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct DivisionRequestForRepair
{
    public int id;
    public string name;
    public DivisionRequestForRepair(int a, string b)
    {
        this.id = a;
        this.name = b;
    }

    public override string ToString()
    {
        return this.name;
    }
}

