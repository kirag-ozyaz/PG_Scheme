using DataSql;
using DailyReport.DataSets;
//using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

internal class ImportDataSESNO
{
    internal static void ImportDailyReport(SQLSettings sqlsettings)
    {
        MySqlConnection connection = new MySqlConnection(string.Format("Server=192.168.1.135; Port=3306; Database=repa; Uid=root; Pwd=312jDSK-98; CharSet=utf8;", new object[0]));
        try
        {
            connection.Open();
            DataTable dataTable = new DataTable("Data");
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            DataTable table4 = new DataTable();
            DataTable table5 = new DataTable();
            DataTable table6 = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("select id, num, `date`, `time`, street, house, fault, ppno,\r\n                                 cast( repait_fakt as char) as repait_fakt, repait_plan, who, comment, sms from data\r\n                                 where `date` < '20160927'\r\n                                 order by `date`", connection))
            {
                adapter.Fill(dataTable);
            }
            using (MySqlDataAdapter adapter2 = new MySqlDataAdapter("select * from asoca.build", connection))
            {
                adapter2.Fill(table2);
            }
            using (MySqlDataAdapter adapter3 = new MySqlDataAdapter("select * from street", connection))
            {
                adapter3.Fill(table3);
            }
            using (MySqlDataAdapter adapter4 = new MySqlDataAdapter("select * from fault", connection))
            {
                adapter4.Fill(table4);
            }
            using (MySqlDataAdapter adapter5 = new MySqlDataAdapter("select * from fault_in", connection))
            {
                adapter5.Fill(table5);
            }
            using (MySqlDataAdapter adapter6 = new MySqlDataAdapter("select id, `date`, ppno, fault, comment, yes, sms, notlight, who, \r\n                                `time`,  cast( repairdate as char) as repairdate,\r\n                                 repairtime, repairCharacter from data_In \r\n                                 where `date` < '20160927'\r\n                                 order by `date`", connection))
            {
                adapter6.Fill(table6);
            }
            foreach (DataRow row in dataTable.Rows)
            {
                try
                {
                    TimeSpan span;
                    dsDamage.tJ_DamageDataTable table7 = new dsDamage.tJ_DamageDataTable();
                    DataRow row2 = table7.NewRow();
                    DateTime time = Convert.ToDateTime(row["date"]);
                    TimeSpan.TryParse(row["time"].ToString(), out span);
                    time.Add(span);
                    row2["dateDoc"] = time;
                    row2["TypeDoc"] = 0x579;
                    row2["numRequest"] = row["num"];
                    row2["idDivision"] = 0x57f;
                    DataRow[] rowArray = table2.Select("id = " + row["ppno"].ToString());
                    if (rowArray.Length != 0)
                    {
                        SqlDataCommand command2 = new SqlDataCommand(new SQLSettings("ulges-sql2", "GES", "WINDOWS", "", ""));
                        DataTable table8 = command2.SelectSqlData("select id, name from tSChm_ObjList\r\n                                                    where typeCodeId = 1275 and name = '" + rowArray[0]["Name"].ToString() + "'");
                        if (table8.Rows.Count > 0)
                        {
                            row2["idSchmObj"] = table8.Rows[0]["id"];
                        }
                        else
                        {
                            string str = rowArray[0]["Name"].ToString();
                            if (str.IndexOf("-01") > 0)
                            {
                                str = str.Substring(0, str.IndexOf("-01"));
                                table8 = command2.SelectSqlData("select id, name from tSChm_ObjList\r\n                                                    where typeCodeId = 1275 and name = '" + str + "'");
                                if (table8.Rows.Count > 0)
                                {
                                    row2["idSchmObj"] = table8.Rows[0]["id"];
                                }
                                else if (str.IndexOf("-02") > 0)
                                {
                                    table8 = command2.SelectSqlData("select id, name from tSChm_ObjList\r\n                                                    where typeCodeId = 1275 and name = '" + str.Substring(0, str.IndexOf("-02")) + "'");
                                    if (table8.Rows.Count > 0)
                                    {
                                        row2["idSchmObj"] = table8.Rows[0]["id"];
                                    }
                                }
                            }
                        }
                        if (row2["idSchmObj"] == DBNull.Value)
                        {
                            row2["DefectLocation"] = "ППНО-" + rowArray[0]["Name"].ToString();
                        }
                    }
                    DataRow[] rowArray2 = table3.Select("num = " + row["street"].ToString());
                    if (rowArray2.Length != 0)
                    {
                        string str2 = rowArray2[0]["name"].ToString();
                        if (row["house"] != DBNull.Value)
                        {
                            str2 = str2 + " " + row["house"].ToString();
                        }
                        if (row2["DefectLocation"] == DBNull.Value)
                        {
                            row2["DefectLocation"] = str2;
                        }
                        else
                        {
                            row2["DefectLocation"] = row2["DefectLocation"].ToString() + "\r\n" + str2;
                        }
                    }
                    row2["ComletedWorkText"] = row["Comment"];
                    row2["DatePlanApply"] = row["repait_plan"];
                    if (row["repait_fakt"].ToString() != "0000-00-00")
                    {
                        DateTime time2 = Convert.ToDateTime(row["repait_fakt"]);
                        row2["isApply"] = true;
                        row2["dateApply"] = time2;
                    }
                    table7.Rows.Add(row2);
                    SqlDataCommand command = new SqlDataCommand(sqlsettings);
                    int num = command.InsertSqlDataOneRow(table7);
                    DataRow[] rowArray3 = table4.Select("num = " + row["Fault"]);
                    if (rowArray3.Length != 0)
                    {
                        DataTable table9 = command.SelectSqlData("select id, ParentId\r\n                                                                from tR_Classifier\r\n                                                                where ParentKey like ';ReportDaily;NatureDamage;LV;%' \r\n                                                                and name = '" + rowArray3[0]["name"].ToString() + "'");
                        if (table9.Rows.Count > 0)
                        {
                            GetTableClassifier(num, table9.Rows[0], sqlsettings);
                        }
                        else if (rowArray3[0]["name"].ToString().IndexOf("УО-") == 0)
                        {
                            table9 = command.SelectSqlData("select id, ParentId\r\n                                                                from tR_Classifier\r\n                                                                where ParentKey like ';ReportDaily;NatureDamage;LV;%' \r\n                                                                and ParentId = 2154\r\n                                                                and name = '" + rowArray3[0]["name"].ToString().Substring(3).Replace("\r\n", "") + "'");
                            if (table9.Rows.Count > 0)
                            {
                                GetTableClassifier(num, table9.Rows[0], sqlsettings);
                            }
                        }
                        else if (rowArray3[0]["name"].ToString().IndexOf("Св-к-") == 0)
                        {
                            table9 = command.SelectSqlData("select id, ParentId\r\n                                                                from tR_Classifier\r\n                                                                where ParentKey like ';ReportDaily;NatureDamage;LV;%' \r\n                                                                and ParentId = 2158\r\n                                                                and name = '" + rowArray3[0]["name"].ToString().Substring(5) + "'");
                            if (table9.Rows.Count > 0)
                            {
                                GetTableClassifier(num, table9.Rows[0], sqlsettings);
                            }
                        }
                        else if (rowArray3[0]["name"].ToString().IndexOf("Линия-") == 0)
                        {
                            table9 = command.SelectSqlData("select id, ParentId\r\n                                                                from tR_Classifier\r\n                                                                where ParentKey like ';ReportDaily;NatureDamage;LV;%' \r\n                                                                and ParentId in (2155, 2191)\r\n                                                                and name = '" + rowArray3[0]["name"].ToString().Substring(6) + "'");
                            if (table9.Rows.Count > 0)
                            {
                                GetTableClassifier(num, table9.Rows[0], sqlsettings);
                            }
                        }
                        else if (rowArray3[0]["name"].ToString().IndexOf("Сборка-") == 0)
                        {
                            table9 = command.SelectSqlData("select id, ParentId\r\n                                                                from tR_Classifier\r\n                                                                where ParentKey like ';ReportDaily;NatureDamage;LV;%' \r\n                                                                and ParentId = 2159\r\n                                                                and name = '" + rowArray3[0]["name"].ToString().Substring(7) + "'");
                            if (table9.Rows.Count > 0)
                            {
                                GetTableClassifier(num, table9.Rows[0], sqlsettings);
                            }
                        }
                        else if (rowArray3[0]["name"].ToString().IndexOf("Опора-") == 0)
                        {
                            table9 = command.SelectSqlData("select id, ParentId\r\n                                                                from tR_Classifier\r\n                                                                where ParentKey like ';ReportDaily;NatureDamage;LV;%' \r\n                                                                and ParentId = 2156\r\n                                                                and name = '" + rowArray3[0]["name"].ToString().Substring(6) + "'");
                            if (table9.Rows.Count > 0)
                            {
                                GetTableClassifier(num, table9.Rows[0], sqlsettings);
                            }
                        }
                        else if (rowArray3[0]["name"].ToString().IndexOf("Торшер-") == 0)
                        {
                            table9 = command.SelectSqlData("select id, ParentId\r\n                                                                from tR_Classifier\r\n                                                                where ParentKey like ';ReportDaily;NatureDamage;LV;%' \r\n                                                                and ParentId = 2157\r\n                                                                and name = '" + rowArray3[0]["name"].ToString().Substring(7) + "'");
                            if (table9.Rows.Count > 0)
                            {
                                GetTableClassifier(num, table9.Rows[0], sqlsettings);
                            }
                        }
                    }
                    GetTableDamageCharacte(num, row2, Convert.ToInt32(row["who"]), sqlsettings);
                }
                catch (Exception exception)
                {
                    System.Windows.Forms.MessageBox.Show(exception.Message, exception.Source);
                }
            }
            foreach (DataRow row3 in table6.Rows)
            {
                try
                {
                    TimeSpan span2;
                    dsDamage.tJ_DamageDataTable table10 = new dsDamage.tJ_DamageDataTable();
                    DataRow row4 = table10.NewRow();
                    DateTime time3 = Convert.ToDateTime(row3["date"]);
                    TimeSpan.TryParse(row3["time"].ToString(), out span2);
                    time3.Add(span2);
                    row4["dateDoc"] = time3;
                    row4["TypeDoc"] = 0x579;
                    row4["numRequest"] = row3["id"];
                    row4["idDivision"] = 0x57f;
                    DataRow[] rowArray4 = table2.Select("id = " + row3["ppno"].ToString());
                    if (rowArray4.Length != 0)
                    {
                        SqlDataCommand command3 = new SqlDataCommand(new SQLSettings("ulges-sql2", "GES", "WINDOWS", "", ""));
                        DataTable table11 = command3.SelectSqlData("select id, name from tSChm_ObjList\r\n                                                    where typeCodeId = 1275 and name = '" + rowArray4[0]["Name"].ToString() + "'");
                        if (table11.Rows.Count > 0)
                        {
                            row4["idSchmObj"] = table11.Rows[0]["id"];
                        }
                        else
                        {
                            string str3 = rowArray4[0]["Name"].ToString();
                            if (str3.IndexOf("-01") > 0)
                            {
                                str3 = str3.Substring(0, str3.IndexOf("-01"));
                                table11 = command3.SelectSqlData("select id, name from tSChm_ObjList\r\n                                                    where typeCodeId = 1275 and name = '" + str3 + "'");
                                if (table11.Rows.Count > 0)
                                {
                                    row4["idSchmObj"] = table11.Rows[0]["id"];
                                }
                                else if (str3.IndexOf("-02") > 0)
                                {
                                    table11 = command3.SelectSqlData("select id, name from tSChm_ObjList\r\n                                                    where typeCodeId = 1275 and name = '" + str3.Substring(0, str3.IndexOf("-02")) + "'");
                                    if (table11.Rows.Count > 0)
                                    {
                                        row4["idSchmObj"] = table11.Rows[0]["id"];
                                    }
                                }
                            }
                        }
                        if (row4["idSchmObj"] == DBNull.Value)
                        {
                            row4["DefectLocation"] = "ППНО-" + rowArray4[0]["Name"].ToString();
                        }
                    }
                    row4["ComletedWorkText"] = row3["Comment"];
                    if (row3["repairDate"].ToString() != "0000-00-00")
                    {
                        DateTime time4 = Convert.ToDateTime(row3["repairDate"]);
                        TimeSpan.TryParse(row3["repairtime"].ToString(), out span2);
                        time4.Add(span2);
                        row4["isApply"] = true;
                        row4["dateApply"] = time4;
                    }
                    table10.Rows.Add(row4);
                    int num1 = new SqlDataCommand(sqlsettings).InsertSqlDataOneRow(table10);
                    SetTableDamageCharacter(num1, Convert.ToInt32(row3["Fault"]), sqlsettings);
                    GetTableDamageCharacte(num1, row4, Convert.ToInt32(row3["who"]), sqlsettings);
                }
                catch (Exception exception2)
                {
                    MessageBox.Show(exception2.Message, exception2.Source);
                }
            }
        }
        catch (Exception exception3)
        {
            MessageBox.Show(exception3.Message, exception3.Source);
        }
    }

    private static void GetTableClassifier(int p0, DataRow dataRow, SQLSettings sqlsettings)
    {
        dsDamage.tJ_DamageCharacterDataTable table = new dsDamage.tJ_DamageCharacterDataTable();
        DataRow row = table.NewRow();
        row["idDamage"] = p0;
        if (Convert.ToInt32(dataRow["ParentId"]) == 0x862)
        {
            row["col2"] = dataRow["id"];
            row["col1"] = dataRow["ParentId"];
        }
        else
        {
            row["col3"] = dataRow["id"];
            if (dataRow["ParentId"] != DBNull.Value)
            {
                DataTable table2 = new SqlDataCommand(sqlsettings).SelectSqlData("select id, ParentId\r\n                                                                from tR_Classifier\r\n                                                                where id = " + dataRow["ParentId"].ToString());
                if (table2.Rows.Count > 0)
                {
                    row["col2"] = table2.Rows[0]["id"].ToString();
                    if (table2.Rows[0]["ParentId"] != DBNull.Value)
                    {
                        row["col1"] = table2.Rows[0]["ParentId"];
                    }
                }
            }
        }
        table.Rows.Add(row);
        new SqlDataCommand(sqlsettings).InsertSqlData(table);
    }

    private static void SetTableDamageCharacter(int p0, int p1, SQLSettings sqlsettings)
    {
        string str = "";
        switch (p1)
        {
            case 10:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2155, null)", p0);
                break;

            case 12:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2155, 2186)", p0);
                break;

            case 14:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2155, 2174)", p0);
                break;

            case 0x13:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2155, 2184)", p0);
                break;

            case 20:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2191, null)", p0);
                break;

            case 0x16:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2191, 2193)", p0);
                break;

            case 0x18:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2191, 2192)", p0);
                break;

            case 0x1a:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2191, 2194)", p0);
                break;

            case 0x1d:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2191, 2195)", p0);
                break;

            case 0x1f:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2159, 2216)", p0);
                break;

            case 0x20:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2159, 2217)", p0);
                break;

            case 0x21:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2159, 2218)", p0);
                break;

            case 0x22:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2159, 2219)", p0);
                break;

            case 0x23:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2159, 2220)", p0);
                break;

            case 0x27:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2159, 2215)", p0);
                break;

            case 0x2a:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2160, 2222)", p0);
                break;

            case 0x2b:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2160, 2223)", p0);
                break;

            case 0x2d:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2160, 2224)", p0);
                break;

            case 0x2e:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2160, 2225)", p0);
                break;

            case 0x2f:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2160, 2226)", p0);
                break;

            case 0x31:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2160, 2227)", p0);
                break;

            case 0x34:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2156, 2197)", p0);
                break;

            case 0x36:
                str = string.Format("insert into tJ_DamageCharacter (idDamage, col1, col2, col3)\r\n                                                values ({0}, 2146, 2156, 2196)", p0);
                break;
        }
        if (!string.IsNullOrEmpty(str))
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlsettings.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = str;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message);
            }
        }
    }

    private static void GetTableDamageCharacte(int p0, DataRow dataRow, int flag, SQLSettings sqlsettings)
    {
        if ((flag != 9) && (flag != 0))
        {
            int num = -1;
            switch (flag)
            {
                case 1:
                    num = 0x8be;
                    break;

                case 2:
                    num = 0x8bf;
                    break;

                case 3:
                    num = 0x8c0;
                    break;

                case 4:
                    num = 0x8c1;
                    break;
            }
            dsDamage.tJ_DamageDataTable table = new dsDamage.tJ_DamageDataTable();
            SqlDataCommand command = new SqlDataCommand(sqlsettings);
            command.SelectSqlData(table, true, "where id = " + p0.ToString(), null, false, 0);
            if (table.Rows.Count > 0)
            {
                table.Rows[0]["ComletedWorkText"] = DBNull.Value;
                if (flag == 5)
                {
                    table.Rows[0]["isLaboratory"] = true;
                }
                else
                {
                    table.Rows[0]["idDivisionApply"] = num;
                }
                table.Rows[0].EndEdit();
                command.UpdateSqlData(table);
            }
            dsDamage.tJ_DamageDataTable table2 = new dsDamage.tJ_DamageDataTable();
            DataRow row = table2.NewRow();
            row["idParent"] = p0;
            row["dateDoc"] = dataRow["dateDoc"];
            row["typeDoc"] = 0x57b;
            row["numRequest"] = dataRow["numRequest"];
            row["iddivision"] = dataRow["iddivision"];
            row["idSchmObj"] = dataRow["idSchmObj"];
            row["defectLocation"] = dataRow["defectLocation"];
            row["ComletedWorkText"] = dataRow["ComletedWorkText"];
            row["isApply"] = dataRow["isApply"];
            row["dateApply"] = dataRow["DateApply"];
            if (flag == 5)
            {
                row["isLaboratory"] = true;
            }
            else
            {
                row["idDivisionApply"] = num;
            }
            row["datePlanApply"] = dataRow["DatePlanApply"];
            table2.Rows.Add(row);
            int num2 = command.InsertSqlDataOneRow(table2);
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlsettings.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command2 = new SqlCommand())
                    {
                        command2.Connection = connection;
                        string[] textArray1 = new string[] { "insert into tj_damageCharacter (idDAmage, col1, col2, col3)\r\n                                            (select ", num2.ToString(), ", col1, col2, col3\r\n                                            from tJ_DamageCharacter where idDAmage = ", p0.ToString(), ")" };
                        command2.CommandText = string.Concat(textArray1);
                        command2.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message);
            }
        }
    }
}

