using System;
using System.Collections.Generic;
using System.Windows.Forms;

internal class Class1
{
	public void method_0(object object_0, Cursor cursor_0)
	{
		this.dictionary_0[object_0] = cursor_0;
	}

	public void FgpwEvlde(object object_0, string string_0)
	{
		string resource = "Resources." + string_0;
		base.GetType();
		Cursor value = new Cursor(base.GetType(), resource);
		this.dictionary_0[object_0] = value;
	}

	public Cursor method_1(object object_0)
	{
		if (this.dictionary_0.ContainsKey(object_0))
		{
			return this.dictionary_0[object_0];
		}
		return Cursors.Arrow;
	}

	public Class1()
	{
		
		this.dictionary_0 = new Dictionary<object, Cursor>();
		
	}

	private Dictionary<object, Cursor> dictionary_0;
}
