using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace EIS.Forms
{
    partial class FormAbout : Form
  {
    public FormAbout()
    {
      this.InitializeComponent();
      this.Label5.Text = "Версия продукта: " + Application.ProductVersion.ToString();
      this.Label4.Text = this.GetCopyright();
      this.Label3.Text = this.GetCompany();
      this.TextBox2.Text = this.Method5();
    }

    [SpecialName]
    public string Method7()
    {
      object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyTitleAttribute), false);
      if (customAttributes.Length != 0)
      {
        AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute) customAttributes[0];
        if (assemblyTitleAttribute.Title != "")
          return assemblyTitleAttribute.Title;
      }
      return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
    }

    [SpecialName]
    public string Method6()
    {
      return Assembly.GetExecutingAssembly().GetName().Version.ToString();
    }

    [SpecialName]
    public string Method5()
    {
      object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyDescriptionAttribute), false);
      if (customAttributes.Length == 0)
        return "";
      return ((AssemblyDescriptionAttribute) customAttributes[0]).Description;
    }

    [SpecialName]
    public string Method4()
    {
      object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyProductAttribute), false);
      if (customAttributes.Length == 0)
        return "";
      return ((AssemblyProductAttribute) customAttributes[0]).Product;
    }

    [SpecialName]
    public string GetCopyright()
    {
      object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyCopyrightAttribute), false);
      if (customAttributes.Length == 0)
                return "";
      return ((AssemblyCopyrightAttribute) customAttributes[0]).Copyright;
    }

    [SpecialName]
    public string GetCompany()
    {
      object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyCompanyAttribute), false);
      if (customAttributes.Length == 0)
        return "";
      return ((AssemblyCompanyAttribute) customAttributes[0]).Company;
    }
       
  }
}
