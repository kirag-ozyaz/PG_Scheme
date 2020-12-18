using System.IO;
using System.Reflection;
using System.Text;

internal class GetResource
{
    // Methods
    private GetResource()
    {
    }
    /// <summary>
    /// вернуть внутренности ресурса
    /// </summary>
    public static string GetStringAssembly(string name, int coding = 1251)
    {
        return GetStringStream(typeof(GetResource).Assembly, name, coding);
    }
    /// <summary>
    /// чтение данных ресурса
    /// </summary>
    public static string GetStringStream(Assembly assembly, string name, int coding)
    {
        StreamReader reader = GetStream(assembly, name, coding);
        string str = reader.ReadToEnd();
        reader.Close();
        return str;
    }
    /// <summary>
    /// поиск ресурса по имени
    /// </summary>
    public static StreamReader GetStream(Assembly assembly, string name, int coding)
    {
        foreach (string str in assembly.GetManifestResourceNames())
        {
            if (str.EndsWith(name))
            {
                return new StreamReader(assembly.GetManifestResourceStream(str), Encoding.GetEncoding(coding));
            }
        }
        return null;
    }

}



