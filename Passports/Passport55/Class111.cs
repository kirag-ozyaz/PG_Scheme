using System;

internal class Class111
{
	public Class111(string string_3)
	{
		this.string_0 = string_3;
	}

	public Class111(string string_3, string string_4)
	{
		this.string_0 = string_3;
		this.string_1 = string_4;
	}

	public Class111(string string_3, string string_4, string string_5)
	{
		this.string_0 = string_3;
		this.string_1 = string_4;
		this.string_2 = string_5;
	}

	public string Col1
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	public string Col2
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

	public string Col3
	{
		get
		{
			return this.string_2;
		}
		set
		{
			this.string_2 = value;
		}
	}

	private string string_0;

	private string string_1;

	private string string_2;
}
