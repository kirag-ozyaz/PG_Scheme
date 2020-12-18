using System;
using System.Reflection;

internal class Class62
{
	internal static void uSY1PxHHLmOjR(int typemdt)
	{
		Type type = Class62.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class62.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class62()
	{
		
		
	}

	// Note: this type is marked as 'beforefieldinit'.
	static Class62()
	{
		
		Class62.module_0 = typeof(Class62).Assembly.ManifestModule;
	}

	internal static Module module_0;

	internal delegate void Delegate26(object o);
}
