using System;
using System.Reflection;

internal class Class72
{
	internal static void e9KF9XuuYHHlc(int typemdt)
	{
		Type type = Class72.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class72.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class72()
	{
		
		
	}

	// Note: this type is marked as 'beforefieldinit'.
	static Class72()
	{
		
		Class72.module_0 = typeof(Class72).Assembly.ManifestModule;
	}

	internal static Module module_0;

	internal delegate void Delegate32(object o);
}
