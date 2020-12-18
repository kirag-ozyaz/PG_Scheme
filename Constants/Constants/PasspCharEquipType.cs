using System;

namespace Constants
{
	public enum PasspCharEquipType
	{
		[StringValue("None")]
		None,
		[StringValue(";EquipChar;Passp;PS;")]
		PS = 3,
		[StringValue(";EquipChar;Passp;Bus;")]
		Bus = 27,
		[StringValue(";EquipChar;Passp;Switch;")]
		Switch,
		[StringValue(";EquipChar;Passp;Line;")]
		Line,
		[StringValue(";EquipChar;Passp;Cell;")]
		Cell,
		[StringValue(";EquipChar;Passp;Clutch;")]
		Clutch,
		[StringValue(";EquipChar;Passp;Trans;")]
		Transformer,
		[StringValue(";EquipChar;Passp;Cable;")]
		Cable = 81
	}
}
