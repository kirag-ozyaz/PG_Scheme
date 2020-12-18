using System;
using System.Reflection;

internal class Class1
{
	internal static void SavePaEEuF7xF(int typemdt)
	{
		Type type = Class1.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class1.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class1()
	{
		//Class2.ugTePaEz97aN4();
		
	}

	// Note: this type is marked as 'beforefieldinit'.
	static Class1()
	{
		//Class2.ugTePaEz97aN4();
		Class1.module_0 = typeof(Class1).Assembly.ManifestModule;
	}

	internal static Module module_0;

	internal delegate void Delegate0(object o);
}
