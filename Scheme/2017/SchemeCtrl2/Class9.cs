using System;
using System.Runtime.CompilerServices;

internal class Class9 : IEquatable<Class9>
{
	public int Id { get; set; }

	public int? IdParent { get; set; }

	public string Name { get; set; }

	public override string ToString()
	{
		return this.Name;
	}

	public bool Equals(Class9 other)
	{
		return this.Name == other.Name && this.Id == other.Id && this.IdParent == other.IdParent;
	}

	public Class9()
	{
		Class90.TDroV38zslI2T();
		base..ctor();
	}

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int? nullable_0;

	[CompilerGenerated]
	private string string_0;
}
