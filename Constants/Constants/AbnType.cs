using System;
using System.ComponentModel;

namespace Constants
{
	public enum AbnType
	{
		Private = 206,
		Legal,
		PrivateNoDog = 253,
		Net = 231,
		Sale = 230,
		[Description("Завод-изготовитель")]
		Maker = 614,
		[Description("Монтажная организация")]
		Mount = 680,
		[Description("Контрагенты с паспорта")]
		PassportPS = 683,
		[Description("Контрагент ЮЛ")]
		KontragentLegal = 1038,
		[Description("Контрагент ФЛ")]
		KontragentFL = 1037,
		[Description("Прочие контрагенты")]
		OtherAbn = 581
	}
}
