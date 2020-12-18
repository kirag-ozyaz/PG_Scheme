using System;
using System.IO;
using System.Reflection;
using System.Text;

internal class Class219
{
    private Class219()
    {
    }

    public static StreamReader smethod_0(Assembly assembly_0, string string_0)
    {
        foreach (string str in assembly_0.GetManifestResourceNames())
        {
            if (str.EndsWith(string_0))
            {
                return new StreamReader(assembly_0.GetManifestResourceStream(str), Encoding.GetEncoding(0x4e3));
            }
        }
        return null;
    }

    public static string smethod_1(Assembly assembly_0, string string_0)
    {
        StreamReader reader1 = smethod_0(assembly_0, string_0);
        string str = reader1.ReadToEnd();
        reader1.Close();
        return str;
    }

    public static string smethod_2(string string_0)
    {
        return smethod_1(typeof(Class219).Assembly, string_0);
    }
}

