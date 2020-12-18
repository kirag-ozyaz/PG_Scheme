using System;

namespace OfficeLB.Word
{
	public enum WdMailMergeComparison
	{
		wdMergeIfEqual,
		wdMergeIfGreaterThan = 3,
		wdMergeIfGreaterThanOrEqual = 5,
		wdMergeIfIsBlank,
		wdMergeIfIsNotBlank,
		wdMergeIfLessThan = 2,
		wdMergeIfLessThanOrEqual = 4,
		wdMergeIfNotEqual = 1
	}
}
