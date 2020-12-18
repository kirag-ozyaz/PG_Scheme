using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Passport.Classes
{
	public static class ExtensionsMethods
	{
		public static string Join(this int[] value, string separator)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < value.Length; i++)
			{
				stringBuilder.Append((i == 0) ? value[0].ToString() : (separator + value[i].ToString()));
			}
			return stringBuilder.ToString();
		}

		public static void VisibleTab(this TabControl control, TabPage page, bool value)
		{
			if (value)
			{
				if (page.Parent == null)
				{
					page.Parent = control;
					return;
				}
			}
			else if (page.Parent == control)
			{
				page.Parent = null;
			}
		}

		public static void VisibleTabRange(this TabControl control, IEnumerable<TabPage> page)
		{
			foreach (object obj in control.TabPages)
			{
				((TabPage)obj).Parent = null;
			}
			foreach (TabPage tabPage in page)
			{
				if (tabPage.Parent == null)
				{
					tabPage.Parent = control;
				}
			}
		}
	}
}
