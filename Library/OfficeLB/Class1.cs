using System;
using OfficeLB;
using OfficeLB.Word;

internal class Class1 : Base
{
	public Class1()
	{
		
		
	}

	public Class1(object object_0)
	{
		
		base.ctor(object_0);
	}

	public string AlternativeText
	{
		get
		{
			return this.GetProperty("AlternativeText", null).ToString();
		}
		set
		{
			this.SetProperty("AlternativeText", new object[]
			{
				value
			});
		}
	}

	public Application Application
	{
		get
		{
			return (Application)this.GetProperty("Application", null);
		}
	}

	public Borders Borders
	{
		get
		{
			return new Borders(this.GetProperty("Borders", null));
		}
	}

	public int Creator
	{
		get
		{
			return (int)this.GetProperty("Creator", null);
		}
	}

	public void method_0()
	{
		this.InvokeMethod("Activate", null);
	}

	public void method_1()
	{
		this.InvokeMethod("Delete", null);
	}

	public void method_2()
	{
		this.InvokeMethod("Reset", null);
	}

	public void method_3()
	{
		this.InvokeMethod("Select", null);
	}
}
