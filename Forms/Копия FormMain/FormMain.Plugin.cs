using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PluginInterfaces;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace EIS.Forms
{
    partial class FormMain
    {
        private AvailablePlugins colAvailablePlugins = new AvailablePlugins();
        private void LoadPlugins()
        {
            try
            {
                this.colAvailablePlugins.Clear();
                foreach (string file in Directory.GetFiles(Application.StartupPath + @"\Plugins"))
                {
                    if (new System.IO.FileInfo(file).Extension.Equals(".dll"))
                        this.AddPlugin(file);
                }
                foreach (AvailablePlugin availablePlugin in this.colAvailablePlugins)
                    this.toolStripMenuItemAditionally.DropDownItems.Add((ToolStripItem)availablePlugin.Instance.MenuItem);
            }
            catch
            {
            }
            if (this.toolStripMenuItemAditionally.DropDownItems.Count != 0)
                return;
            this.toolStripMenuItemAditionally.Visible = false;
        }

        private void AddPlugin(string AssemblyPath)
        {
            Assembly assembly = Assembly.LoadFrom(AssemblyPath);
            foreach (System.Type type in assembly.GetTypes())
            {
                if (type.IsPublic && !type.IsAbstract && type.GetInterface("PluginInterfaces.IPlugin", true) != null)
                {
                    AvailablePlugin pluginToAdd = new AvailablePlugin();
                    pluginToAdd.AssemblyPath = AssemblyPath;
                    pluginToAdd.Instance = (IPlugin)Activator.CreateInstance(assembly.GetType(type.ToString()));
                    pluginToAdd.Instance.Host = (IPluginHost)this;
                    pluginToAdd.Instance.Initialize();
                    this.colAvailablePlugins.Add(pluginToAdd);
                }
            }
        }

        public void ClosePlugins()
        {
            foreach (AvailablePlugin availablePlugin in this.colAvailablePlugins)
            {
                availablePlugin.Instance.Dispose();
                availablePlugin.Instance = null;
            }
            this.colAvailablePlugins.Clear();
        }

        public void Feedback(string Feedback, IPlugin Plugin)
        {
        }
    }
    public class AvailablePlugins : System.Collections.CollectionBase
    {
        public void Add(AvailablePlugin pluginToAdd)
        {
            this.List.Add((object)pluginToAdd);
        }

        public void Remove(AvailablePlugin pluginToRemove)
        {
            this.List.Remove((object)pluginToRemove);
        }

        public AvailablePlugin Find(string pluginNameOrPath)
        {
            AvailablePlugin toReturn = (AvailablePlugin)null;
            foreach (AvailablePlugin pluginOn in this.List)
            {
                if ((pluginOn.Instance.Name.Equals(pluginNameOrPath)) || pluginOn.AssemblyPath.Equals(pluginNameOrPath))
                {
                    toReturn = pluginOn;
                    break;
                }
            }
            return toReturn;
        }
    }
    public class AvailablePlugin
    {
        private string myAssemblyPath = "";
        private IPlugin myInstance;

        public IPlugin Instance
        {
            get
            {
                return this.myInstance;
            }
            set
            {
                this.myInstance = value;
            }
        }

        public string AssemblyPath
        {
            get
            {
                return this.myAssemblyPath;
            }
            set
            {
                this.myAssemblyPath = value;
            }
        }
    }
}
