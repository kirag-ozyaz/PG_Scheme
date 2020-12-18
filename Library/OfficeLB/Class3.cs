using System;
using System.Collections;
using OfficeLB;
using OfficeLB.Word;

internal class Class3 : Base
{
	public Class3()
	{
		
		
	}

	public Class3(object object_0)
	{
		
		base.ctor(object_0);
	}

	public IEnumerable method_0()
	{
		return (IEnumerable)this.InvokeReturn("GetEnumerator", null);
	}

	public bool method_1(int int_0)
	{
		return (bool)this.GetProperty("Range", new object[]
		{
			int_0
		});
	}

	public Application Application
	{
		get
		{
			return (Application)this.GetProperty("Application", null);
		}
	}

	public int Creator
	{
		get
		{
			return (int)this.GetProperty("Creator", null);
		}
	}

	public Class7 ListTemplates
	{
		get
		{
			return (Class7)this.GetProperty("ListTemplates", null);
		}
	}

	public object Parent
	{
		get
		{
			return this.GetProperty("Parent", null);
		}
	}
}
