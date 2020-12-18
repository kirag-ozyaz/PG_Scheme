using System;

namespace OfficeLB.Word
{
	public enum WdMailMergeState
	{
		wdDataSource = 5,
		wdMainAndDataSource = 2,
		wdMainAndHeader,
		wdMainAndSourceAndHeader,
		wdMainDocumentOnly = 1,
		wdNormalDocument = 0
	}
}
