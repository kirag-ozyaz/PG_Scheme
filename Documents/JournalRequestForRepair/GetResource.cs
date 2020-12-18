using System.IO;
using System.Reflection;
using System.Text;

namespace RequestForRepair
{
    internal class ResourceReader
    {
        private ResourceReader()
        {
        }

        public static StreamReader GetStream(Assembly assembly, string name)
        {
            string[] manifestResourceNames = assembly.GetManifestResourceNames();
            for (int i = 0; i < manifestResourceNames.Length; i++)
            {
                string text = manifestResourceNames[i];
                if (text.EndsWith(name))
                {
                    return new StreamReader(assembly.GetManifestResourceStream(text), Encoding.GetEncoding(1251));
                }
            }
            return null;
        }

        public static string GetStringStream(Assembly assembly, string name)
        {
            StreamReader reader = ResourceReader.GetStream(assembly, name);
            string result = reader.ReadToEnd();
            reader.Close();
            return result;
        }

        public static string GetStringAssembly(string name)
        {
            return ResourceReader.GetStringStream(typeof(ResourceReader).Assembly, name);
        }
    }
}
