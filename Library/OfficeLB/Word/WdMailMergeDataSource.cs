using System;

namespace OfficeLB.Word
{
	public enum WdMailMergeDataSource
	{
		wdMergeInfoFromAccessDDE = 1,
		wdMergeInfoFromExcelDDE,
		wdMergeInfoFromMSQueryDDE,
		wdMergeInfoFromODBC,
		wdMergeInfoFromODSO,
		wdMergeInfoFromWord = 0,
		wdNoMergeInfo = -1
	}
}
