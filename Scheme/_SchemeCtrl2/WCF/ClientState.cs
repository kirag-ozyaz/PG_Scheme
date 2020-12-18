using System;

namespace SchemeCtrl2.WCF
{
	public enum ClientState
	{
		empty,
		downloadPoints,
		downloadObjects,
		downloadChanges,
		busy,
		free
	}
}
