using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;
using DataSql;

namespace Passport.Forms.Documents
{
	public class DataRetriever : IDataPageRetriever
	{
		public DataRetriever(SQLSettings settings, DataTable dataTable_1)
		{
			SqlConnection sqlConnection = new SqlConnection(string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", settings.ServerDB, settings.DBName));
			sqlConnection.Open();
			this.sqlCommand_0 = sqlConnection.CreateCommand();
			this.dataTable_0 = dataTable_1;
		}

		public int RowCount
		{
			get
			{
				if (this.int_0 != -1)
				{
					return this.int_0;
				}
				this.sqlCommand_0.CommandText = "SELECT COUNT(*) FROM " + this.dataTable_0.TableName;
				this.int_0 = (int)this.sqlCommand_0.ExecuteScalar();
				return this.int_0;
			}
		}

		public DataColumnCollection Columns
		{
			get
			{
				return this.dataTable_0.Columns;
			}
		}

		private string CommaSeparatedListOfColumnNames
		{
			get
			{
				if (this.string_0 != null)
				{
					return this.string_0;
				}
				StringBuilder stringBuilder = new StringBuilder();
				bool flag = true;
				foreach (object obj in this.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (!flag)
					{
						stringBuilder.Append(", ");
					}
					stringBuilder.Append(dataColumn.ColumnName);
					flag = false;
				}
				this.string_0 = stringBuilder.ToString();
				return this.string_0;
			}
		}

		public DataTable SupplyPageOfData(int lowerPageBoundary, int rowsPerPage)
		{
			if (this.string_1 == null)
			{
				this.string_1 = this.Columns[0].ColumnName;
			}
			if (!this.Columns[this.string_1].Unique)
			{
				throw new InvalidOperationException(string.Format("Column {0} must contain unique values.", this.string_1));
			}
			this.sqlCommand_0.CommandText = string.Concat(new object[]
			{
				"Select Top ",
				rowsPerPage,
				" ",
				this.CommaSeparatedListOfColumnNames,
				" From ",
				this.dataTable_0,
				" WHERE ",
				this.string_1,
				" NOT IN (SELECT TOP ",
				lowerPageBoundary,
				" ",
				this.string_1,
				" From ",
				this.dataTable_0.TableName,
				" Order By ",
				this.string_1,
				") Order By ",
				this.string_1
			});
			this.sqlDataAdapter_0.SelectCommand = this.sqlCommand_0;
			DataTable dataTable = new DataTable();
			dataTable.Locale = CultureInfo.InvariantCulture;
			this.sqlDataAdapter_0.Fill(dataTable);
			return dataTable;
		}

		private DataTable dataTable_0;

		private SqlCommand sqlCommand_0;

		private int int_0 = -1;

		private string string_0;

		private string string_1;

		private SqlDataAdapter sqlDataAdapter_0 = new SqlDataAdapter();
	}
}
