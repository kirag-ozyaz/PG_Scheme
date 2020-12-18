using System;

internal class Class13
{
	internal Class13()
	{
		Class330.Mus9JxKz1CNxy();
		this.string_0 = string.Empty;
		this.string_1 = string.Empty;
		base..ctor();
		this.string_0 = string.Empty;
		this.string_1 = string.Empty;
	}

	internal Class13(string string_2, string string_3)
	{
		Class330.Mus9JxKz1CNxy();
		this.string_0 = string.Empty;
		this.string_1 = string.Empty;
		base..ctor();
		this.string_1 = string_2;
		this.string_0 = string_3;
	}

	internal Class13(Class13 class13_0)
	{
		Class330.Mus9JxKz1CNxy();
		this.string_0 = string.Empty;
		this.string_1 = string.Empty;
		base..ctor();
		this.string_1 = class13_0.Name;
		this.string_0 = class13_0.method_0();
	}

	internal string Name
	{
		get
		{
			return this.string_1;
		}
		set
		{
			this.string_1 = value;
		}
	}

	internal string method_0()
	{
		return this.string_0;
	}

	internal void method_1(string string_2)
	{
		this.string_0 = string_2;
	}

	private string string_0;

	private string string_1;
}
