using System;

namespace OfficeLB.Word
{
	public delegate void DocumentBeforeCloseEventHandler(Document document, ref bool cancel);
}
