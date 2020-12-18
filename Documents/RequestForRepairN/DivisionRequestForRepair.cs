using System;

internal struct DivisionRequestForRepair
{
	public DivisionRequestForRepair(int id, string name)
	{
		this.Id = id;
		this.Name = name;
	}

	public override string ToString()
	{
		return this.Name;
	}

	public int Id;

	public string Name;
}
