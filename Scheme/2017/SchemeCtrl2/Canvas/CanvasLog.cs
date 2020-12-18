using System;
using System.Data;
using DataSql;

namespace SchemeCtrl2.Canvas
{
	public static class CanvasLog
	{
		public static void SaveLogDispatcher(SQLSettings sqlSett, int? idObj, string action, string comment)
		{
			Class22 @class = new Class22();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlSett);
			DataRow dataRow = @class.tSchm_LogDispatcher.NewRow();
			if (idObj != null)
			{
				dataRow["idObj"] = idObj;
			}
			dataRow["Action"] = action;
			if (!string.IsNullOrEmpty(comment))
			{
				dataRow["Comment"] = comment;
			}
			@class.tSchm_LogDispatcher.Rows.Add(dataRow);
			sqlDataCommand.InsertSqlData(@class, @class.tSchm_LogDispatcher);
		}
	}
}
