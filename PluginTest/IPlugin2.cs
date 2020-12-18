using System.Windows.Forms;
using PluginInterfaces;

namespace PluginTest
{
    public interface IPlugin2
    {
        string Author { get; }
        string Author { get; }
        string Description { get; }
        string Description { get; }
        IPluginHost Host { get; set; }
        IPluginHost Host { get; set; }
        ToolStripMenuItem MenuItem { get; }
        ToolStripMenuItem MenuItem { get; }
        string Name { get; }
        string Name { get; }
        string Version { get; }
        string Version { get; }

        void Dispose();
        void Dispose();
        bool Equals(object obj);
        int GetHashCode();
        void Initialize();
        void Initialize();
        string ToString();
    }
}