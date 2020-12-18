using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using DataSql;

namespace Passport.Classes
{
	public class ObjectBase
	{
		public static int GetTypeCodeId(SQLSettings settings, string parentKey, decimal value)
		{
			SqlConnection sqlConnection = new SqlConnection(settings.GetConnectionString());
			int result;
			try
			{
				string cmdText = string.Format("SELECT Id FROM tR_Classifier WHERE parentKey = '{0}' AND Value = {1} AND Deleted = ((0))", parentKey, value.ToString(new CultureInfo(1033)));
				sqlConnection.Open();
				SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
				DataTable dataTable = new DataTable();
				new SqlDataAdapter(selectCommand).Fill(dataTable);
				if (dataTable.Rows.Count > 0)
				{
					result = (int)dataTable.Rows[0]["id"];
				}
				else
				{
					result = -1;
				}
			}
			catch (Exception)
			{
				result = -1;
			}
			finally
			{
				if (sqlConnection.State == ConnectionState.Open)
				{
					sqlConnection.Close();
				}
			}
			return result;
		}

		public ObjectBase()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}
	}
}
