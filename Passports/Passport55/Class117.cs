using System;

internal class Class117
{
	public Class117(string string_2, string string_3)
	{
		this.string_0 = string_2;
		this.string_1 = string_3;
	}

	public string method_0()
	{
		return this.string_0;
	}

	public void method_1(string string_2)
	{
		this.string_0 = string_2;
	}

	public string Name
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

	private string string_0;

	private string string_1;
}
