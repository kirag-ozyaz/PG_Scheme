using System;
using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class Class121
{
	internal static uint smethod_0(string string_0)
	{
		uint num;
		if (string_0 != null)
		{
			num = 2166136261u;
			for (int i = 0; i < string_0.Length; i++)
			{
				num = ((uint)string_0[i] ^ num) * 16777619u;
			}
		}
		return num;
	}
}
