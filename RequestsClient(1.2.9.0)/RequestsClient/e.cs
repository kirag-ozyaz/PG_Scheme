using System;
using System.Runtime.CompilerServices;

// Token: 0x0200000A RID: 10
internal class e
{
	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600003F RID: 63 RVA: 0x00004475 File Offset: 0x00002675
	// (set) Token: 0x06000040 RID: 64 RVA: 0x0000447D File Offset: 0x0000267D
	internal string Name { get; set; }

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000041 RID: 65 RVA: 0x00004486 File Offset: 0x00002686
	// (set) Token: 0x06000042 RID: 66 RVA: 0x0000448E File Offset: 0x0000268E
	internal int Id { get; set; }

	// Token: 0x06000043 RID: 67 RVA: 0x00004497 File Offset: 0x00002697
	internal e()
	{
	}

	// Token: 0x06000044 RID: 68 RVA: 0x0000449F File Offset: 0x0000269F
	internal e(string A_0, int A_1)
	{
		this.Name = A_0;
		this.Id = A_1;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x000044B5 File Offset: 0x000026B5
	public override string ToString()
	{
		return this.Name;
	}

	// Token: 0x0400002F RID: 47
	[CompilerGenerated]
	private string a;

	// Token: 0x04000030 RID: 48
	[CompilerGenerated]
	private int b;
}
