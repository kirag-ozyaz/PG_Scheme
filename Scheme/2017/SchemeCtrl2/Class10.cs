using System;
using System.Runtime.CompilerServices;

internal class Class10 : IEquatable<Class10>
{
	public int Id { get; set; }

	public int? IdParent { get; set; }

	public string Name { get; set; }

	public int method_0()
	{
		return this.int_0;
	}

	public void method_1(int int_2)
	{
		this.int_0 = int_2;
	}

	public override string ToString()
	{
		return this.Name;
	}

	public bool Equals(Class10 other)
	{
		return this.Name == other.Name && this.Id == other.Id && this.IdParent == other.IdParent;
	}

	public Class10()
	{
		Class90.TDroV38zslI2T();
		this.int_0 = 1;
		base..ctor();
	}

	private int int_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private int? nullable_0;

	[CompilerGenerated]
	private string string_0;
}
