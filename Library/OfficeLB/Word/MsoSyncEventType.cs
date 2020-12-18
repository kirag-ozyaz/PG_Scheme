using System;

namespace OfficeLB.Word
{
	public enum MsoSyncEventType
	{
		msoSyncEventDownloadFailed = 2,
		msoSyncEventDownloadInitiated = 0,
		msoSyncEventDownloadNoChange = 6,
		msoSyncEventDownloadSucceeded = 1,
		msoSyncEventOffline = 7,
		msoSyncEventUploadFailed = 5,
		msoSyncEventUploadInitiated = 3,
		msoSyncEventUploadSucceeded
	}
}
