using System;

namespace OfficeLB.Word
{
	public delegate void DocumentBeforePrintEventHandler(Document document, ref bool cancel);
}
