using System;

namespace OfficeLB.Excel
{
	public delegate void WorkbookBeforeCloseEventHandler(object Workbook, ref bool Cancel);
}
