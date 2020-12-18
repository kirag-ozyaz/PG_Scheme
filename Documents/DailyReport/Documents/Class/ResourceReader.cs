using System;
using System.IO;
using System.Reflection;
using System.Text;

internal class ResourceReader
{
    private ResourceReader()
    {
    }

    /// <summary>
    /// Находим внедренный ресурс "resurs" (считываем ресурс)
    /// кладем в поток
    /// </summary>
    public static StreamReader GetStream(Assembly assembly, string resurs)
    {
        foreach (string str in assembly.GetManifestResourceNames())
        {
            if (str.EndsWith(resurs))
            {
                return new StreamReader(assembly.GetManifestResourceStream(str), Encoding.GetEncoding(0x4e3));
            }
        }
        return null;
    }
    /// <summary>
    ///  вернуть строку из потока (StreamReader)
    /// </summary>
    public static string GetStringStream(Assembly assembly, string resurs)
    {
        StreamReader reader1 = GetStream(assembly, resurs);
        string str = reader1.ReadToEnd();
        reader1.Close();
        return str;
    }
    /// <summary>
    /// Вернем тект (строку) из Assembly на основании наименовоания ресурса (resurs)
    /// </summary>
    public static string GetStringAssembly(string resurs)
    {
        return GetStringStream(typeof(ResourceReader).Assembly, resurs);
    }

    //public static string GetStringAssembly(string resurs)
    //{
    //    Assembly assembly = typeof(ResourceReader).Assembly;
    //    StreamReader reader1 = GetStream(assembly, resurs);
    //    string str = reader1.ReadToEnd();
    //    reader1.Close();
    //    return str;
    //}

}

