namespace Documents
{
    using DataSql;
    using System;
    using System.Collections;
    using System.Data;
    using System.Data.SqlClient;
    using System.Globalization;
    using System.Text;

    public class DataRetriever : IDataPageRetriever
    {
        private DataColumnCollection dataColumnCollection_0;
        private int int_0;
        private SqlCommand sqlCommand_0;
        private SqlDataAdapter sqlDataAdapter_0;
        private string string_0;
        private string string_1;
        private string string_2;
        private string string_3;

        public DataRetriever(SQLSettings sqlSett, string tableName)
        {
            this.string_1 = "*";
            this.int_0 = -1;
            this.sqlDataAdapter_0 = new SqlDataAdapter();
            SqlDataConnect connect = new SqlDataConnect();
            connect.OpenConnection(sqlSett);
            this.sqlCommand_0 = connect.get_Connection().CreateCommand();
            this.string_0 = tableName;
        }

        public DataRetriever(string connectionString, string tableName)
        {
            this.string_1 = "*";
            this.int_0 = -1;
            this.sqlDataAdapter_0 = new SqlDataAdapter();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            this.sqlCommand_0 = connection.CreateCommand();
            this.string_0 = tableName;
        }

        public DataRetriever(SQLSettings sqlSett, string tableName, ArrayList listOfColumnNamesGridView)
        {
            this.string_1 = "*";
            this.int_0 = -1;
            this.sqlDataAdapter_0 = new SqlDataAdapter();
            SqlDataConnect connect = new SqlDataConnect();
            connect.OpenConnection(sqlSett);
            this.sqlCommand_0 = connect.get_Connection().CreateCommand();
            this.string_1 = " ";
            foreach (object obj2 in listOfColumnNamesGridView)
            {
                if (obj2.GetType() == typeof(ClassesDoc.ParametryColumnsDataGridView))
                {
                    object[] objArray1 = new object[] { this.string_1, "[", ((ClassesDoc.ParametryColumnsDataGridView) obj2).Column, "], " };
                    this.string_1 = string.Concat(objArray1);
                }
            }
            this.string_1 = this.string_1.Remove(this.string_1.LastIndexOf(", "));
            this.string_0 = tableName;
        }

        public DataTable SupplyPageOfData(int lowerPageBoundary, int rowsPerPage)
        {
            if (this.string_3 == null)
            {
                this.string_3 = this.Columns[0].ColumnName;
            }
            if (!this.Columns[this.string_3].Unique)
            {
                throw new InvalidOperationException(string.Format("Column {0} must contain unique values.", this.string_3));
            }
            object[] objArray1 = new object[] { 
                "Select Top ", rowsPerPage, " ", this.CommaSeparatedListOfColumnNames, " From ", this.string_0, " WHERE ", this.string_3, " NOT IN (SELECT TOP ", lowerPageBoundary, " ", this.string_3, " From ", this.string_0, " Order By ", this.string_3,
                ") Order By ", this.string_3
            };
            this.sqlCommand_0.CommandText = string.Concat(objArray1);
            this.sqlDataAdapter_0.SelectCommand = this.sqlCommand_0;
            DataTable dataTable = new DataTable {
                Locale = CultureInfo.InvariantCulture
            };
            this.sqlDataAdapter_0.Fill(dataTable);
            return dataTable;
        }

        public DataColumnCollection Columns
        {
            get
            {
                if (this.dataColumnCollection_0 == null)
                {
                    this.sqlCommand_0.CommandText = "SELECT " + this.string_1 + " FROM " + this.string_0;
                    SqlDataAdapter adapter1 = new SqlDataAdapter {
                        SelectCommand = this.sqlCommand_0
                    };
                    DataTable dataTable = new DataTable {
                        Locale = CultureInfo.InvariantCulture
                    };
                    adapter1.FillSchema(dataTable, SchemaType.Source);
                    this.dataColumnCollection_0 = dataTable.Columns;
                }
                return this.dataColumnCollection_0;
            }
        }

        private string CommaSeparatedListOfColumnNames
        {
            get
            {
                if (this.string_2 == null)
                {
                    StringBuilder builder = new StringBuilder();
                    bool flag = true;
                    foreach (DataColumn column in this.Columns)
                    {
                        if (!flag)
                        {
                            builder.Append(", ");
                        }
                        builder.Append(column.ColumnName);
                        flag = false;
                    }
                    this.string_2 = builder.ToString();
                }
                return this.string_2;
            }
        }

        public int RowCount
        {
            get
            {
                if (this.int_0 == -1)
                {
                    this.sqlCommand_0.CommandText = "SELECT COUNT(*) FROM " + this.string_0;
                    this.int_0 = (int) this.sqlCommand_0.ExecuteScalar();
                }
                return this.int_0;
            }
        }
    }
}

