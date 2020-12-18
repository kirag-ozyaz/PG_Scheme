using System;

internal struct Struct0
{
	internal Struct0(int? nullable_1, string string_1, DateTime dateTime_1, int int_1)
	{
		Class330.Mus9JxKz1CNxy();
		this.nullable_0 = nullable_1;
		this.string_0 = string_1;
		this.dateTime_0 = dateTime_1;
		this.int_0 = int_1;
	}

	public static bool operator ==(Struct0 struct0_1, Struct0 struct0_2)
	{
		return struct0_1.dateTime_0 == struct0_2.dateTime_0 && struct0_1.nullable_0 == struct0_2.nullable_0 && struct0_1.string_0 == struct0_2.string_0 && struct0_1.int_0 == struct0_2.int_0;
	}

	public static bool operator !=(Struct0 struct0_1, Struct0 struct0_2)
	{
		if (!(struct0_1.dateTime_0 != struct0_2.dateTime_0) && !(struct0_1.nullable_0 != struct0_2.nullable_0))
		{
			if (!(struct0_1.string_0 != struct0_2.string_0) || struct0_1.int_0 == struct0_2.int_0)
			{
				return false;
			}
		}
		return true;
	}

	// Note: this type is marked as 'beforefieldinit'.
	static Struct0()
	{
		Class330.Mus9JxKz1CNxy();
	}

	internal int? nullable_0;

	internal string string_0;

	internal DateTime dateTime_0;

	internal int int_0;

	internal static readonly Struct0 struct0_0;
}
