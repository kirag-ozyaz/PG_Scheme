using DataSql;
using Documents.JournalRequestForRepair;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml;

internal static class Class198
{
    private const string string_0 = "DamageMail";

    internal static void smethod_0(int int_0, SQLSettings sqlsettings_0)
    {
        try
        {
            SqlDataCommand command = new SqlDataCommand(sqlsettings_0);
            DataTable table = command.SelectSqlData("select idSchmObj, idDivisionApply, isLaboratory from tj_damage where id = " + int_0.ToString());
            int num = -1;
            bool flag = false;
            if (table.Rows.Count != 0)
            {
                if (table.Rows[0]["idDivisionApply"] != DBNull.Value)
                {
                    num = Convert.ToInt32(table.Rows[0]["idDivisionApply"]);
                }
                if (table.Rows[0]["isLaboratory"] != DBNull.Value)
                {
                    flag = Convert.ToBoolean(table.Rows[0]["isLaboratory"]);
                }
                if ((num != -1) || flag)
                {
                    string str = "";
                    if (table.Rows[0]["idSchmObj"] != DBNull.Value)
                    {
                        string[] textArray1 = new string[] { table.Rows[0]["idSchmObj"].ToString() };
                        str = command.CallSQLScalarFunction("[dbo].[fn_Schm_GetFullNameObjById]", textArray1).ToString();
                    }
                    DataTable table2 = command.SelectSqlData("tSettings", true, "where module = 'DamageMail'", null);
                    if ((table2.Rows.Count != 0) && (table2.Rows[0]["Settings"] != DBNull.Value))
                    {
                        XmlDocument document = new XmlDocument();
                        document.LoadXml(table2.Rows[0]["Settings"].ToString());
                        XmlNode node = document.SelectSingleNode("DamageMail");
                        if (node != null)
                        {
                            XmlAttribute attribute = node.Attributes["useMail"];
                            if ((attribute != null) && Convert.ToBoolean(attribute.Value))
                            {
                                string str2 = "";
                                string str3 = "";
                                string str4 = "";
                                string str5 = "";
                                string str6 = "";
                                int num2 = 0x19;
                                XmlNode node2 = node.SelectSingleNode("SMTP");
                                if (node2 != null)
                                {
                                    attribute = node2.Attributes["Name"];
                                    if (attribute != null)
                                    {
                                        str2 = attribute.Value;
                                    }
                                    attribute = node2.Attributes["Port"];
                                    if ((attribute != null) && !string.IsNullOrEmpty(attribute.Value))
                                    {
                                        num2 = Convert.ToInt32(attribute.Value);
                                    }
                                    attribute = node2.Attributes["Login"];
                                    if (attribute != null)
                                    {
                                        str3 = attribute.Value;
                                    }
                                    attribute = node2.Attributes["Pwd"];
                                    if (attribute != null)
                                    {
                                        str4 = attribute.Value;
                                    }
                                    XmlNode node3 = node.SelectSingleNode("Sender");
                                    if (node3 != null)
                                    {
                                        attribute = node3.Attributes["Address"];
                                        if (attribute != null)
                                        {
                                            str5 = attribute.Value;
                                        }
                                        attribute = node3.Attributes["Name"];
                                        if (attribute != null)
                                        {
                                            str6 = attribute.Value;
                                        }
                                    }
                                    DataTable table3 = smethod_1(document, sqlsettings_0);
                                    string filterExpression = "divId in (";
                                    if (num != -1)
                                    {
                                        filterExpression = filterExpression + num.ToString();
                                    }
                                    if (flag)
                                    {
                                        if (num != -1)
                                        {
                                            filterExpression = filterExpression + ",-1";
                                        }
                                        else
                                        {
                                            filterExpression = filterExpression + "-1";
                                        }
                                    }
                                    filterExpression = filterExpression + ")";
                                    using (IEnumerator<DataRow> enumerator = table3.Select(filterExpression).AsEnumerable<DataRow>().GroupBy<DataRow, object>((С_1.С_9__1_0 ?? (С_1.С_9__1_0 = new Func<DataRow, object>(С_1.С_9.method_0)))).Select<IGrouping<object, DataRow>, DataRow>((С_1.С_9__1_1 ?? (С_1.С_9__1_1 = new Func<IGrouping<object, DataRow>, DataRow>(С_1.С_9.method_1)))).GetEnumerator())
                                    {
                                        while (enumerator.MoveNext())
                                        {
                                            string str8 = enumerator.Current["Tag"].ToString();
                                            DataTable table4 = command.SelectSqlData("select ch.id, isnull(ch.col3, isnull(ch.col2, col1)) as col from tJ_DamageCharacter ch\r\n\t                                                            left join tR_Classifier c on isnull(ch.col3, isnull(ch.col2, col1)) = c.id\r\n                                                             where ch.idDamage = " + int_0.ToString() + " and c.Comment like '%" + str8 + "%'");
                                            if (table4.Rows.Count != 0)
                                            {
                                                foreach (DataRow row in table4.Rows)
                                                {
                                                    int num3 = -1;
                                                    if (row["col"] != DBNull.Value)
                                                    {
                                                        num3 = Convert.ToInt32(row["col"]);
                                                    }
                                                    string str9 = "";
                                                    DataTable table5 = command.SelectSqlData("select name from tr_Classifier where id = " + num3.ToString());
                                                    if ((table5.Rows.Count > 0) && (table5.Rows[0]["NAme"] != DBNull.Value))
                                                    {
                                                        str9 = table5.Rows[0]["NAme"].ToString();
                                                    }
                                                    List<Struct4> list = new List<Struct4>();
                                                    foreach (DataRow row2 in table3.Select(filterExpression + " and tag = '" + str8 + "' and contact is not null"))
                                                    {
                                                        list.Add(new Struct4(row2["Contact"].ToString(), row2["FIO"].ToString()));
                                                    }
                                                    ExportRequestForRepair.smethod_13(str2, num2, str3, str4, str5, str6, list, "DamageMail", str + "\r\n" + str9, null, false);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, exception.Source);
        }
    }

    internal static DataTable smethod_1(XmlDocument xmlDocument_0, SQLSettings sqlsettings_0)
    {
        DataTable table = new DataTable();
        table.Columns.Add("tag", typeof(string));
        table.Columns.Add("divName", typeof(string));
        table.Columns.Add("divId", typeof(int));
        table.Columns.Add("FIO", typeof(string));
        table.Columns.Add("idWorker", typeof(int));
        table.Columns.Add("Contact", typeof(string));
        DataTable table2 = new DataTable("tR_Classifier");
        DataColumn column = table2.Columns.Add("id", typeof(int));
        table2.Columns.Add("name", typeof(string));
        table2.PrimaryKey = new DataColumn[] { column };
        SqlDataCommand command = new SqlDataCommand(sqlsettings_0);
        int? nullable = null;
        command.SelectSqlData(table2, true, "", nullable, false, 0);
        DataTable table3 = new DataTable("tR_Worker");
        DataColumn column2 = table3.Columns.Add("id", typeof(int));
        table3.Columns.Add("F", typeof(string));
        table3.Columns.Add("I", typeof(string));
        table3.Columns.Add("O", typeof(string));
        table3.Columns.Add("FIO", typeof(string), "F + isnull(' ' + I, '') + isnull(' ' + O, '')");
        table3.PrimaryKey = new DataColumn[] { column2 };
        command.SelectSqlData(table3, true, "", null, false, 0);
        XmlNode node = xmlDocument_0.SelectSingleNode("DamageMail");
        if (node != null)
        {
            XmlNode node2 = node.SelectSingleNode("Recipients");
            if (node2 != null)
            {
                foreach (XmlNode node3 in node2.SelectNodes("TagName"))
                {
                    string str = "";
                    XmlAttribute attribute = node3.Attributes["TagName"];
                    if (attribute != null)
                    {
                        str = attribute.Value;
                    }
                    object[] values = new object[] { str };
                    table.Rows.Add(values);
                    foreach (XmlNode node4 in node3.SelectNodes("Division"))
                    {
                        string str2 = "";
                        int? nullable2 = null;
                        attribute = node4.Attributes["DivId"];
                        if (attribute != null)
                        {
                            nullable2 = new int?(Convert.ToInt32(attribute.Value));
                        }
                        DataRow row = table2.Rows.Find(nullable2.Value);
                        if (row != null)
                        {
                            str2 = row["name"].ToString();
                        }
                        else
                        {
                            attribute = node4.Attributes["DivName"];
                            if (attribute != null)
                            {
                                str2 = attribute.Value;
                            }
                        }
                        object[] objArray2 = new object[] { str, str2, nullable2 };
                        table.Rows.Add(objArray2);
                        foreach (XmlNode node5 in node4.SelectNodes("Contact"))
                        {
                            string str3 = "";
                            int? nullable3 = null;
                            string str4 = "";
                            attribute = node5.Attributes["IdWorker"];
                            if (attribute != null)
                            {
                                nullable3 = new int?(Convert.ToInt32(attribute.Value));
                            }
                            row = table3.Rows.Find(nullable3.Value);
                            if (row != null)
                            {
                                str3 = row["fio"].ToString();
                            }
                            else
                            {
                                attribute = node5.Attributes["FIO"];
                                if (attribute != null)
                                {
                                    str3 = attribute.Value;
                                }
                            }
                            attribute = node5.Attributes["Contact"];
                            if (attribute != null)
                            {
                                str4 = attribute.Value;
                            }
                            object[] objArray3 = new object[] { str, str2, nullable2, str3, nullable3, str4 };
                            table.Rows.Add(objArray3);
                        }
                    }
                }
            }
        }
        DataView defaultView = table.DefaultView;
        defaultView.Sort = "tag, divname, fio, contact";
        return defaultView.ToTable();
    }

    [Serializable, CompilerGenerated]
    private sealed class С_1
    {
        public static readonly Class198.С_1 С_9 = new Class198.С_1();
        public static Func<DataRow, object> С_9__1_0;
        public static Func<IGrouping<object, DataRow>, DataRow> С_9__1_1;

        internal object method_0(DataRow dataRow_0)
        {
            return dataRow_0["Tag"];
        }

        internal DataRow method_1(IGrouping<object, DataRow> igrouping_0)
        {
            return igrouping_0.First<DataRow>();
        }
    }
}

