namespace Documents
{
    using System;
    using System.Data;
    using System.Runtime.InteropServices;

    public class Cache
    {
        private DataPage[] dataPage_0;
        private IDataPageRetriever idataPageRetriever_0;
        private static int int_0;

        public Cache(IDataPageRetriever dataSupplier, int rowsPerPage)
        {
            this.idataPageRetriever_0 = dataSupplier;
            int_0 = rowsPerPage;
            this.method_1();
        }

        private bool method_0(int int_1, int int_2, ref string string_0)
        {
            if (this.method_4(0, int_1))
            {
                string_0 = this.dataPage_0[0].table.Rows[int_1 % int_0][int_2].ToString();
                return true;
            }
            if (this.method_4(1, int_1))
            {
                string_0 = this.dataPage_0[1].table.Rows[int_1 % int_0][int_2].ToString();
                return true;
            }
            return false;
        }

        private void method_1()
        {
            this.dataPage_0 = new DataPage[] { new DataPage(this.idataPageRetriever_0.SupplyPageOfData(DataPage.MapToLowerBoundary(0), int_0), 0), new DataPage(this.idataPageRetriever_0.SupplyPageOfData(DataPage.MapToLowerBoundary(int_0), int_0), int_0) };
        }

        private string method_2(int int_1, int int_2)
        {
            DataTable table = this.idataPageRetriever_0.SupplyPageOfData(DataPage.MapToLowerBoundary(int_1), int_0);
            this.dataPage_0[this.method_3(int_1)] = new DataPage(table, int_1);
            return this.RetrieveElement(int_1, int_2);
        }

        private int method_3(int int_1)
        {
            if ((int_1 > this.dataPage_0[0].HighestIndex) && (int_1 > this.dataPage_0[1].HighestIndex))
            {
                if ((int_1 - this.dataPage_0[0].HighestIndex) < (int_1 - this.dataPage_0[1].HighestIndex))
                {
                    return 1;
                }
                return 0;
            }
            if ((this.dataPage_0[0].LowestIndex - int_1) < (this.dataPage_0[1].LowestIndex - int_1))
            {
                return 1;
            }
            return 0;
        }

        private bool method_4(int int_1, int int_2)
        {
            return ((int_2 <= this.dataPage_0[int_1].HighestIndex) && (int_2 >= this.dataPage_0[int_1].LowestIndex));
        }

        public string RetrieveElement(int rowIndex, int columnIndex)
        {
            string str = null;
            if (this.method_0(rowIndex, columnIndex, ref str))
            {
                return str;
            }
            return this.method_2(rowIndex, columnIndex);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DataPage
        {
            public DataTable table;
            private int int_0;
            private int int_1;
            public DataPage(DataTable table, int rowIndex)
            {
                this.table = table;
                this.int_0 = MapToLowerBoundary(rowIndex);
                this.int_1 = smethod_0(rowIndex);
            }

            public int LowestIndex
            {
                get
                {
                    return this.int_0;
                }
            }
            public int HighestIndex
            {
                get
                {
                    return this.int_1;
                }
            }
            public static int MapToLowerBoundary(int rowIndex)
            {
                return ((rowIndex / Cache.int_0) * Cache.int_0);
            }

            private static int smethod_0(int int_2)
            {
                return ((MapToLowerBoundary(int_2) + Cache.int_0) - 1);
            }
        }
    }
}

