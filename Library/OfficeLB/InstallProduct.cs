using System;
using System.IO;
using Microsoft.Win32;

namespace OfficeLB
{
	public static class InstallProduct
	{
		public static bool InstalledExcel
		{
			get
			{
				InstallProduct.smethod_0();
				return InstallProduct.bool_0;
			}
		}

		public static bool InstalledCalc
		{
			get
			{
				InstallProduct.smethod_2();
				return InstallProduct.bool_1;
			}
		}

		public static bool InstalledWord
		{
			get
			{
				InstallProduct.smethod_1();
				return InstallProduct.bool_2;
			}
		}

		public static string Version
		{
			get
			{
				if (InstallProduct.string_0 != null)
				{
					return InstallProduct.string_0;
				}
				return "Non found";
			}
		}

		private static void smethod_0()
		{
			InstallProduct.string_0 = null;
			InstallProduct.bool_0 = false;
			for (int i = 9; i <= 100; i++)
			{
				RegistryKey registryKey = (Environment.OSVersion.Platform.ToString().IndexOf("32") <= 0) ? Registry.LocalMachine.OpenSubKey("SOFTWARE\\MICROSOFT\\OFFICE\\" + i.ToString() + ".0\\Excel\\InstallRoot") : Registry.LocalMachine.OpenSubKey("SOFTWARE\\MICROSOFT\\OFFICE\\" + i.ToString() + ".0\\Excel\\InstallRoot");
				if (registryKey != null && File.Exists(registryKey.GetValue("Path").ToString() + "\\Excel.exe"))
				{
					InstallProduct.string_0 = i.ToString() + ".0";
					InstallProduct.bool_0 = true;
					return;
				}
			}
		}

		private static void smethod_1()
		{
			InstallProduct.string_0 = null;
			InstallProduct.bool_2 = false;
			for (int i = 9; i <= 100; i++)
			{
				RegistryKey registryKey = (Environment.OSVersion.Platform.ToString().IndexOf("32") <= 0) ? Registry.LocalMachine.OpenSubKey("SOFTWARE\\MICROSOFT\\OFFICE\\" + i.ToString() + ".0\\Word\\InstallRoot") : Registry.LocalMachine.OpenSubKey("SOFTWARE\\MICROSOFT\\OFFICE\\" + i.ToString() + ".0\\Word\\InstallRoot");
				if (registryKey != null && File.Exists(registryKey.GetValue("Path").ToString() + "\\Word.exe"))
				{
					InstallProduct.string_0 = i.ToString() + ".0";
					InstallProduct.bool_2 = true;
					return;
				}
			}
		}

		private static void smethod_2()
		{
			InstallProduct.string_0 = null;
			InstallProduct.bool_1 = false;
			for (double num = 11.0; num <= 1000.0; num += 1.0)
			{
				InstallProduct.double_0 = num / 10.0;
				RegistryKey registryKey = (Environment.OSVersion.Platform.ToString().IndexOf("32") <= 0) ? Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\OpenOffice.org\\OpenOffice.org\\" + InstallProduct.double_0.ToString().Replace(",", ".")) : Registry.LocalMachine.OpenSubKey("SOFTWARE\\OpenOffice.org\\OpenOffice.org\\" + InstallProduct.double_0.ToString().Replace(",", "."));
				if (registryKey != null && registryKey.GetValue("Path").ToString() != null && File.Exists(registryKey.GetValue("Path").ToString().Replace("soffice", "scalc")))
				{
					InstallProduct.string_0 = InstallProduct.double_0.ToString().Replace(",", ".");
					InstallProduct.bool_1 = true;
					return;
				}
			}
		}

		private static string string_0;

		private static bool bool_0;

		private static bool bool_1;

		private static bool bool_2;

		private static double double_0;
	}
}
