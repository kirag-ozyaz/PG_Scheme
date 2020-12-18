using System;
using System.Reflection;

internal class Class3
{
	internal static void YmOsML55i5IWr(int typemdt)
	{
		Type type = Class3.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class3.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class3()
	{
		
		
	}

	// Note: this type is marked as 'beforefieldinit'.
	static Class3()
	{
		
		Class3.module_0 = typeof(Class3).Assembly.ManifestModule;
	}

	internal static Module module_0;

	internal delegate void Delegate1(object o);
}
