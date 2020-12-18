using System;

namespace OfficeLB.Excel
{
	public delegate void WorkbookBeforePrintEventHandler(object Workbook, ref bool Cancel);
}
