using System;

namespace OfficeLB.Excel
{
	public delegate void WorkbookBeforeSaveEventHandler(object Workbook, bool save, ref bool Cancel);
}
