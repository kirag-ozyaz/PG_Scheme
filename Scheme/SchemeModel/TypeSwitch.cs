using System;

namespace SchemeModelN
{
	public enum TypeSwitch
	{
		LubricantSwitchTool = 552,
		LinearDisconnectorTool,
		LoadSwitchTool,
		GroundingTool,
		TransformerTool,
		DamageTool,
		VacuumSwitchTool,
		OutsideLineDisconnectorTool,
		EndTrimTool = 583,
		FuseTool = 600,
		DischargerTool,
		VoltageLimiterTool,
		VoltageTransformerTool,
		CircuitBreaker = 903,
		RPSTool = 975,
		AmperageTransformer,
		OffTool = 1215,
		NotPhasedTool,
		MagneticStarterTool = 1276,
		ElectricMeterTool,
		ArrowTool = 3,
		LinearDisconnectorToolWaxwork,
		LoadSwitchToolWaxwork,
		SeparatorTool = 10,
		ComplexSwitchgearTool,
		None = -1
	}
}
/* Если выбираем parentkey in (';SCM;INLINE_OBJ;SWITCH;',';SCM;INLINE_OBJ;STATELINE;') and [IsGroup] = 0 то то получаем 20 значений
 * 3,4,5,10,11,600,601,602 - эти не видны
ArrowTool = 3,
LinearDisconnectorToolWaxwork = 4,
LoadSwitchToolWaxwork = 5,
SeparatorTool = 10,
ComplexSwitchgearTool = 11,
LubricantSwitchTool = 552, -- Маслянный выключатель
LinearDisconnectorTool = 553, -- Линейный разъединитель
LoadSwitchTool = 554, -- Выключатель нагрузки
GroundingTool = 555, -- Заземление
TransformerTool = 556, -- Трансформатор
DamageTool = 557, -- Повреждение кабеля (;SCM;INLINE_OBJ;STATELINE;)
VacuumSwitchTool = 558, -- Вакуумный выключатель
OutsideLineDisconnectorTool = 559, -- Наружний линейный разъединитель
EndTrimTool = 583, -- Концевая разделка
FuseTool = 600,
DischargerTool = 601, ------------------ Это наверное 1212	Разрядник
VoltageLimiterTool = 602, ------------------ Это наверное 1213	Ограничитель перенапряжения
VoltageTransformerTool = 603, -- Трансформатор напряжения
CircuitBreaker = 903, -- Автоматический выключатель
RPSTool = 975, -- РПС
AmperageTransformer = 976, -- Трансформатор тока
OffTool = 1215, -- Отключение кабеля (;SCM;INLINE_OBJ;STATELINE;)
NotPhasedTool = 1216, -- Несфазировано (;SCM;INLINE_OBJ;STATELINE;)
MagneticStarterTool = 1276, -- Магнитный пускатель
ElectricMeterTool = 1277, -- Счетчик
None = -1,
 
 */
/*
1971	Заземлено - это внутри подстанции, земля
1212	Разрядник
1213	Ограничитель перенапряжения
*/
