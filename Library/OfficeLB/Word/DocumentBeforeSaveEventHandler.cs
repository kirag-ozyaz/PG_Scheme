using System;

namespace OfficeLB.Word
{
	public delegate void DocumentBeforeSaveEventHandler(Document document, ref bool saveAsUI, ref bool cancel);
}
