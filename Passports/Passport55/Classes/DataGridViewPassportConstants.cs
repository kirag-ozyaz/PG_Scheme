using System;

namespace Passport.Classes
{
	public class DataGridViewPassportConstants
	{
		public const string whereAbn = "WHERE Deleted = ((0)) AND (TypeAbn = 231 OR TypeAbn = 230 OR TypeAbn = 207 OR TypeAbn = 614 OR TypeAbn = 683) AND (Name NOT LIKE '')";

		public const string sqlDependencyQueue = "ContractorCacheMessages";

		public const string sqlDependencyOptions = "Service=ContractorNotifications";

		public const int sqlDependencyTimeout = 0;

		public const string ParameterTypesKey = ";Passport;DataType;";

		public const string DateFormatsKey = ";Passport;DateFormat;";

		public const string DigitFormatsKey = ";Passport;DigitFormat;";

		public const string Substation = ";EquipChar;Passp;PS;";

		public const string Cable = ";EquipChar;Passp;Cable;";

		public const string Line = ";EquipChar;Passp;Line;";

		public const string Bus = ";EquipChar;Passp;Bus;";

		public const string Cell = ";EquipChar;Passp;Cell;";

		public const string Clutch = ";EquipChar;Passp;Clutch;";

		public const string Transformer = ";EquipChar;Passp;Trans;";

		public const string Switch = ";EquipChar;Passp;Switch;";
	}
}
