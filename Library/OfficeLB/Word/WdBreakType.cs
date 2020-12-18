using System;

namespace OfficeLB.Word
{
	public enum WdBreakType
	{
		wdColumnBreak = 8,
		wdLineBreak = 6,
		wdLineBreakClearLeft = 9,
		wdLineBreakClearRight,
		wdPageBreak = 7,
		wdSectionBreakContinuous = 3,
		wdSectionBreakEvenPage,
		wdSectionBreakNextPage = 2,
		wdSectionBreakOddPage = 5,
		wdTextWrappingBreak = 11
	}
}
