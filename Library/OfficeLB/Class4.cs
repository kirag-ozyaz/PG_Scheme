using System;
using System.Collections;
using OfficeLB;

internal class Class4 : Base
{
	public Class4()
	{
		
		
	}

	public Class4(object object_0)
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
}
