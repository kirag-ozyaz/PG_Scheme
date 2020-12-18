using System;
using System.IO;
using System.Reflection;

internal class ResourceReader
{
	//private ResourceReader()
	//{
		
	//}
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
                return new StreamReader(assembly.GetManifestResourceStream(str), System.Text.Encoding.GetEncoding(1251));
            }
        }
        return null;
    }
    /// <summary>
    ///  вернуть строку из потока (StreamReader)
    /// </summary>
	public static string GetStringStream(Assembly assembly, string resurs)
	{
		StreamReader streamReader = ResourceReader.GetStream(assembly, resurs);
		string result = streamReader.ReadToEnd();
		streamReader.Close();
		return result;
	}
    /// <summary>
    /// Вернем тект (строку) из Assembly на основании наименовоания ресурса (resurs)
    /// </summary>
	//public static string GetStringAssembly(Type type, string resurs)
	//{
	//	return ResourceReader.GetStringStream(typeof(ResourceReader).Assembly, resurs);
	//}
    /// <summary>
    /// Вернем тект (строку) из Assembly на основании наименовоания ресурса (resurs)
    /// </summary>
    public static string GetStringAssembly(string resurs)
    {
        return ResourceReader.GetStringStream(typeof(ResourceReader).Assembly, resurs);
    }
}
