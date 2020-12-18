using Microsoft.Office.Interop.Excel;
using System;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ControlsLbr.DataGridViewExcelFilter
{
    public class DataGridViewExcelFilterN: ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter
    {

        public new  void ExportToExcel()
        {
            try
            {
                DataGridViewClipboardCopyMode clipboardCopyMode = this.ClipboardCopyMode;
                this.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                Clipboard.Clear();
                this.RowHeadersVisible = false;
                bool multiSelect = this.MultiSelect;
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < this.Columns.Count; i++)
                {
                    if (this.Columns[i].Visible)
                    {
                        stringBuilder.Append("\"" + this.Columns[i].HeaderText + "\"\t");
                    }
                }
                stringBuilder.Append("\r\n");
                for (int j = 0; j < this.Rows.Count; j++)
                {
                    for (int k = 0; k < this.Columns.Count; k++)
                    {
                        if (this.Columns[k].Visible)
                        {
                            object value = this.Rows[j].Cells[k].Value;
                            if (value == null) value = "";
                            stringBuilder.Append("\"" + value.ToString().Replace("\"", "\"\"") + "\"\t");
                        }
                    }
                    stringBuilder.Append("\r\n");
                }
                Clipboard.SetDataObject(stringBuilder.ToString());
                this.RowHeadersVisible = true;

                Microsoft.Office.Interop.Excel.Application application = new ApplicationClass();
                application.SheetsInNewWorkbook = 1;
                CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                Workbook workbook = application.Workbooks.Add(-4167);
                workbook.Title = "Title";
                Worksheet worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "SheetName";
                Thread.CurrentThread.CurrentCulture = currentCulture;

                worksheet.Columns.NumberFormat = "@";

                worksheet.Paste(application.ActiveCell, false);
                application.ActiveCell.EntireRow.Font.Bold = true;
                worksheet.Columns.AutoFit();
                application.Visible = true;
                this.ClipboardCopyMode = clipboardCopyMode;
                this.MultiSelect = multiSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        public new void CopyToExcel(bool isAll = true)
        {
            try
            {
                DataGridViewClipboardCopyMode clipboardCopyMode = this.ClipboardCopyMode;
                this.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                Clipboard.Clear();
                this.RowHeadersVisible = false;
                bool multiSelect = this.MultiSelect;
                if (isAll)
                {
                    this.MultiSelect = true;
                    this.SelectAll();
                }
                Clipboard.SetDataObject(this.GetClipboardContent().GetData(DataFormats.UnicodeText));
                if (isAll)
                {
                    this.ClearSelection();
                }
                this.RowHeadersVisible = true;

                Microsoft.Office.Interop.Excel.Application application = new ApplicationClass();
                application.SheetsInNewWorkbook = 1;
                CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                Workbook workbook = application.Workbooks.Add(-4167);
                workbook.Title = "Title";
                Worksheet worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "SheetName";
                Thread.CurrentThread.CurrentCulture = currentCulture;
                worksheet.Paste(application.ActiveCell, false);
                application.ActiveCell.EntireRow.Font.Bold = true;
                worksheet.Columns.AutoFit();
                application.Visible = true;
                this.ClipboardCopyMode = clipboardCopyMode;
                this.MultiSelect = multiSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

    }
}
