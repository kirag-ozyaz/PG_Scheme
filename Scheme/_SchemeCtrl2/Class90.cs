using System;
using System.Runtime.CompilerServices;

internal class Class90 : IEquatable<Class90>
{
	public int Id { get; set; }

	[CompilerGenerated]
	public int? method_0()
	{
		return this.nullable_0;
	}

	[CompilerGenerated]
	public void method_1(int? nullable_1)
	{
		this.nullable_0 = nullable_1;
	}

	public string Name { get; set; }

	public int method_2()
	{
		return this.int_0;
	}

	public void method_3(int int_2)
	{
		this.int_0 = int_2;
	}

	public override string ToString()
	{
		return this.Name;
	}

	public bool Equals(Class90 other)
	{
		return this.Name == other.Name && this.Id == other.Id && this.method_0() == other.method_0();
	}

	private int int_0 = 1;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private int? nullable_0;

	[CompilerGenerated]
	private string string_0;
}
