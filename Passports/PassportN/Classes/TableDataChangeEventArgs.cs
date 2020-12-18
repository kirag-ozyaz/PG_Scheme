using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Passport.Classes
{
	public class TableDataChangeEventArgs : SqlNotificationEventArgs
	{
		public TableDataChangeEventArgs(SqlNotificationType type, SqlNotificationInfo info, SqlNotificationSource source, int changeCount, string tableName)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor(type, info, source);
			this.ChangeCount = changeCount;
			this.TableName = tableName;
		}

		public string TableName { get; private set; }

		public int ChangeCount { get; private set; }

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private int int_0;
	}
}
