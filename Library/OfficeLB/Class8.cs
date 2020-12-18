using System;
using System.Reflection;

internal class Class8
{
	internal static void K3IhdbuuZTuI0(int typemdt)
	{
		Type type = Class8.wEtTgtIqgo.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class8.wEtTgtIqgo.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class8()
	{
		
		
	}

	// Note: this type is marked as 'beforefieldinit'.
	static Class8()
	{
		
		Class8.wEtTgtIqgo = typeof(Class8).Assembly.ManifestModule;
	}

	internal static Module wEtTgtIqgo;

	internal delegate void Delegate0(object o);
}
