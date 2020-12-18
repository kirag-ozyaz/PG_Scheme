using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace RequestsClient.Properties
{
	// Token: 0x0200003E RID: 62
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00007785 File Offset: 0x00005985
		internal Resources()
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000778D File Offset: 0x0000598D
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.a == null)
				{
					Resources.a = new ResourceManager("RequestsClient.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.a;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000077B9 File Offset: 0x000059B9
		// (set) Token: 0x0600012D RID: 301 RVA: 0x000077C0 File Offset: 0x000059C0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.b;
			}
			set
			{
				Resources.b = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000077C8 File Offset: 0x000059C8
		internal static Bitmap CopyBuffer
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("CopyBuffer", Resources.b);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000077E3 File Offset: 0x000059E3
		internal static Bitmap ElementAccept
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("ElementAccept", Resources.b);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000077FE File Offset: 0x000059FE
		internal static Bitmap ElementAdd
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("ElementAdd", Resources.b);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00007819 File Offset: 0x00005A19
		internal static Bitmap ElementDel
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("ElementDel", Resources.b);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00007834 File Offset: 0x00005A34
		internal static Bitmap ElementEdit
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("ElementEdit", Resources.b);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000784F File Offset: 0x00005A4F
		internal static Bitmap ElementError
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("ElementError", Resources.b);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0000786A File Offset: 0x00005A6A
		internal static Bitmap ElementGo
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("ElementGo", Resources.b);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00007885 File Offset: 0x00005A85
		internal static Bitmap ElementInformation
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("ElementInformation", Resources.b);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000078A0 File Offset: 0x00005AA0
		internal static Bitmap Find
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Find", Resources.b);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000078BB File Offset: 0x00005ABB
		internal static Bitmap FindNext
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("FindNext", Resources.b);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000078D6 File Offset: 0x00005AD6
		internal static Bitmap FindPrev
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("FindPrev", Resources.b);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000078F1 File Offset: 0x00005AF1
		internal static Bitmap FTP
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("FTP", Resources.b);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000790C File Offset: 0x00005B0C
		internal static Bitmap refresh_16
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("refresh 16", Resources.b);
			}
		}

		// Token: 0x0400009F RID: 159
		private static ResourceManager a;

		// Token: 0x040000A0 RID: 160
		private static CultureInfo b;
	}
}
