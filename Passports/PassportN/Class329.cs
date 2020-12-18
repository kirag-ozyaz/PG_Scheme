using System;
using System.Reflection;

internal class Class329
{
	internal static void y639JxKKlcX7A(int typemdt)
	{
		Type type = Class329.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class329.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class329()
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
	}

	// Note: this type is marked as 'beforefieldinit'.
	static Class329()
	{
		Class330.Mus9JxKz1CNxy();
		Class329.module_0 = typeof(Class329).Assembly.ManifestModule;
	}

	internal static Module module_0;

	internal delegate void Delegate146(object o);
}
