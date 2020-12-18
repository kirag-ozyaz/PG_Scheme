using System;

internal struct Recipient
{
	internal Recipient(string address, string name)
	{
		this.Address = address;
		this.Name = name;
	}

	internal string Address;

	internal string Name;
}
