using System;
using System.Data;
using DataSql;
using SchemeCtrl2.Data;

namespace SchemeCtrl2.Canvas
{
	public static class CanvasLog
	{
		public static void SaveLogDispatcher(SQLSettings sqlSett, int? idObj, string action, string comment)
		{
			DataSetScheme dataSetScheme = new DataSetScheme();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlSett);
			DataRow dataRow = dataSetScheme.tSchm_LogDispatcher.NewRow();
			if (idObj != null)
			{
				dataRow["idObj"] = idObj;
			}
			dataRow["Action"] = action;
			if (!string.IsNullOrEmpty(comment))
			{
				dataRow["Comment"] = comment;
			}
			dataSetScheme.tSchm_LogDispatcher.Rows.Add(dataRow);
			sqlDataCommand.InsertSqlData(dataSetScheme, dataSetScheme.tSchm_LogDispatcher);
		}
	}
}
