using System;
using System.Reflection;

internal class Class89
{
	internal static void FycoV3889p5P1(int typemdt)
	{
		Type type = Class89.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class89.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class89()
	{
		Class90.TDroV38zslI2T();
		base..ctor();
	}

	// Note: this type is marked as 'beforefieldinit'.
	static Class89()
	{
		Class90.TDroV38zslI2T();
		Class89.module_0 = typeof(Class89).Assembly.ManifestModule;
	}

	internal static Module module_0;

	internal delegate void Delegate39(object o);
}
