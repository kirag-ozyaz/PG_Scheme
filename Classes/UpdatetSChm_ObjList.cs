// Decompiled with JetBrains decompiler
// Type: EIS.Class2
// Assembly: EIS, Version=1.1.20.0, Culture=neutral, PublicKeyToken=null
// MVID: D97E7465-1D18-4676-A9AC-C679BB2F90D9
// Assembly location: D:\Декомпилятор C#\EIS_2016-11-07\Deobfuscated\EIS.exe

using DataSql;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EIS
{
    internal static class UpdatetSChm_ObjList
    {
        /// <summary>
        /// Замена (апдейт) кода разрдников(1212) и ограничителей перенапряжения(1213)
        /// так код typeCodeId совпадает с кодами в классификаторе других элементов
        /// </summary>
        /// <param name="settings"></param>
        internal static void UpdatetSChm_ObjListTypeCodeId(SQLSettings settings)
        {
            return;
            //try
            //{
            //    using (SqlConnection sqlConnection = new SqlConnection(settings.GetConnectionString()))
            //    {
            //        sqlConnection.Open();
            //        using (SqlCommand sqlCommand = new SqlCommand())
            //        {
            //            sqlCommand.Connection = sqlConnection;
            //            sqlCommand.CommandTimeout = 10000;
            //            sqlCommand.CommandText = "update tSChm_ObjList\r\n                                            set typeCodeId = 1212\r\n                                            where typeCodeId = 601";
            //            sqlCommand.ExecuteNonQuery();
            //            sqlCommand.CommandText = "update tSChm_ObjList\r\n                                            set typeCodeId = 1213\r\n                                            where typeCodeId = 602";
            //            sqlCommand.ExecuteNonQuery();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    int num = (int)MessageBox.Show(ex.Message);
            //}
        }
    }
}
