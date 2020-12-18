using System;
using System.Collections;
using OfficeLB;
using OfficeLB.Word;

internal class Class2 : Base
{
	public Class2()
	{
		
		
	}

	public Class2(object object_0)
	{
		
		base.ctor(object_0);
	}

	public IEnumerable method_0()
	{
		return (IEnumerable)this.InvokeReturn("GetEnumerator", null);
	}

	public Application Application
	{
		get
		{
			return (Application)this.GetProperty("Application", null);
		}
	}

	public int Count
	{
		get
		{
			return (int)this.GetProperty("Count", null);
		}
	}

	public int Creator
	{
		get
		{
			return (int)this.GetProperty("Creator", null);
		}
	}

	public Class3 this[WdListGalleryType wdListGalleryType_0]
	{
		get
		{
			return new Class3(this.InvokeReturn("Item", new object[]
			{
				wdListGalleryType_0
			}));
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
