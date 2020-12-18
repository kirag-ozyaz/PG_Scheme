using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NsExcel = Microsoft.Office.Interop.Excel;

namespace ClassLibraries
{
    class ListToExcel
    {
        //start excel
        NsExcel.ApplicationClass excapp = new Microsoft.Office.Interop.Excel.ApplicationClass();
        
        //if you want to make excel visible           
        excapp.Visible = true;

    //create a blank workbook
    var workbook = excapp.Workbooks.Add(NsExcel.XlWBATemplate.xlWBATWorksheet);

        //or open one - this is no pleasant, but yue're probably interested in the first parameter
        string workbookPath = "C:\test.xls";
        var workbook = excapp.Workbooks.Open(workbookPath,
            0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "",
            true, false, 0, true, false, false);

        //Not done yet. You have to work on a specific sheet - note the cast
        //You may not have any sheets at all. Then you have to add one with NsExcel.Worksheet.Add()
        var sheet = (NsExcel.Worksheet)workbook.Sheets[1]; //indexing starts from 1

        //do something usefull: you select now an individual cell
        var range = sheet.get_Range("A1", "A1");
        range.Value2 = "test"; //Value2 is not a typo

    //now the list
    string cellName;
        int counter = 1;
    foreach (var item in list)
    {
        cellName = "A" + counter.ToString();
        var range = sheet.get_Range(cellName, cellName);
        range.Value2 = item.ToString();
        ++counter;
    }

    //you've probably got the point by now, so a detailed explanation about workbook.SaveAs and workbook.Close is not necessary
    //important: if you did not make excel visible terminating your application will terminate excel as well - I tested it
    //but if you did it - to be honest - I don't know how to close the main excel window - maybee somewhere around excapp.Windows or excapp.ActiveWindow
}
}
