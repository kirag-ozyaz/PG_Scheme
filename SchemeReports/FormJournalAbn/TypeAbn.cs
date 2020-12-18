using System;

internal class TypeAbn
{
	internal TypeAbn()
	{
		
	}

	internal TypeAbn(int id, string name)
	{
		this.Id = id;
		this.Name = name;
	}

	public override string ToString()
	{
		return this.Name;
	}

	internal int Id;

	internal string Name;
}
