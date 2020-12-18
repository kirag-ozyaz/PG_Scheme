using DataSql;
//using RequestForRepair;
using Documents.JournalRequestForRepair;
using RequestForRepair;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml;

internal static class _Mail
{
    private const string subject = "DamageMail";

    internal static void Send(int idDamage, SQLSettings sqlsettings)
    {
        try
        {
            SqlDataCommand command = new SqlDataCommand(sqlsettings);
            DataTable table = command.SelectSqlData("select idSchmObj, idDivisionApply, isLaboratory from tj_damage where id = " + idDamage.ToString());
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
                    string bodyBeg = "";
                    if (table.Rows[0]["idSchmObj"] != DBNull.Value)
                    {
                        string[] textArray1 = new string[] { table.Rows[0]["idSchmObj"].ToString() };
                        bodyBeg = command.CallSQLScalarFunction("[dbo].[fn_Schm_GetFullNameObjById]", textArray1).ToString();
                    }
                    DataTable tblSettings = command.SelectSqlData("tSettings", true, "where module = 'DamageMail'", null);
                    if ((tblSettings.Rows.Count != 0) && (tblSettings.Rows[0]["Settings"] != DBNull.Value))
                    {
                        XmlDocument document = new XmlDocument();
                        document.LoadXml(tblSettings.Rows[0]["Settings"].ToString());
                        XmlNode node = document.SelectSingleNode("DamageMail");
                        if (node != null)
                        {
                            XmlAttribute attribute = node.Attributes["useMail"];
                            if ((attribute != null) && Convert.ToBoolean(attribute.Value))
                            {
                                string host = "";
                                string userName = "";
                                string password = "";
                                string address = "";
                                string displayName = "";
                                int port = 25;// 0x19;
                                XmlNode node2 = node.SelectSingleNode("SMTP");
                                if (node2 != null)
                                {
                                    attribute = node2.Attributes["Name"];
                                    if (attribute != null)
                                    {
                                        host = attribute.Value;
                                    }
                                    attribute = node2.Attributes["Port"];
                                    if ((attribute != null) && !string.IsNullOrEmpty(attribute.Value))
                                    {
                                        port = Convert.ToInt32(attribute.Value);
                                    }
                                    attribute = node2.Attributes["Login"];
                                    if (attribute != null)
                                    {
                                        userName = attribute.Value;
                                    }
                                    attribute = node2.Attributes["Pwd"];
                                    if (attribute != null)
                                    {
                                        password = attribute.Value;
                                    }
                                    XmlNode node3 = node.SelectSingleNode("Sender");
                                    if (node3 != null)
                                    {
                                        attribute = node3.Attributes["Address"];
                                        if (attribute != null)
                                        {
                                            address = attribute.Value;
                                        }
                                        attribute = node3.Attributes["Name"];
                                        if (attribute != null)
                                        {
                                            displayName = attribute.Value;
                                        }
                                    }
                                    DataTable table3 = getTableContact(document, sqlsettings);
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
                                    //using (IEnumerator<DataRow> enumerator = table3.Select(filterExpression).AsEnumerable<DataRow>().GroupBy<DataRow, object>((С_1.С_9__1_0 ?? (С_1.С_9__1_0 = new Func<DataRow, object>(С_1.С_9.method_0))))
                                    //.Select<IGrouping<object, DataRow>, DataRow>((С_1.С_9__1_1 ?? (С_1.С_9__1_1 = new Func<IGrouping<object, DataRow>, DataRow>(С_1.С_9.method_1)))).GetEnumerator())
                                    using (IEnumerator<DataRow> enumerator = table3
                                        .Select(filterExpression)
                                        .AsEnumerable()
                                        .GroupBy(r=>r["Tag"])
                                        .First()
                                        .GetEnumerator())

                                    {
                                        while (enumerator.MoveNext())
                                        {
                                            string strTag = enumerator.Current["Tag"].ToString();
                                            DataTable table4 = command.SelectSqlData("select ch.id, isnull(ch.col3, isnull(ch.col2, col1)) as col from tJ_DamageCharacter ch\r\n\t                                                            left join tR_Classifier c on isnull(ch.col3, isnull(ch.col2, col1)) = c.id\r\n                                                             where ch.idDamage = " + idDamage.ToString() + " and c.Comment like '%" + strTag + "%'");
                                            if (table4.Rows.Count != 0)
                                            {
                                                foreach (DataRow row in table4.Rows)
                                                {
                                                    int num3 = -1;
                                                    if (row["col"] != DBNull.Value)
                                                    {
                                                        num3 = Convert.ToInt32(row["col"]);
                                                    }
                                                    string bodyEnd = "";
                                                    DataTable table5 = command.SelectSqlData("select name from tr_Classifier where id = " + num3.ToString());
                                                    if ((table5.Rows.Count > 0) && (table5.Rows[0]["NAme"] != DBNull.Value))
                                                    {
                                                        bodyEnd = table5.Rows[0]["NAme"].ToString();
                                                    }
                                                    List<RequestForRepair.StructMailAddress> listMailAddress = new List<RequestForRepair.StructMailAddress>();
                                                    foreach (DataRow row2 in table3.Select(filterExpression + " and tag = '" + strTag + "' and contact is not null"))
                                                    {
                                                        listMailAddress.Add(new RequestForRepair.StructMailAddress(row2["Contact"].ToString(), row2["FIO"].ToString()));
                                                    }
                                                    ExportRequestForRepair.SendMessage(host, port, userName, password, address, displayName, listMailAddress, "DamageMail", bodyBeg + "\r\n" + bodyEnd, null, false);
                                                    


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
            System.Windows.Forms.MessageBox.Show(exception.Message, exception.Source);
        }
    }

    internal static DataTable getTableContact(XmlDocument xml, SQLSettings sqlsettings)
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
        SqlDataCommand command = new SqlDataCommand(sqlsettings);
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
        XmlNode node = xml.SelectSingleNode("DamageMail");
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

    //[Serializable, CompilerGenerated]
    //private sealed class С_1
    //{
    //    public static readonly Class198.С_1 С_9 = new Class198.С_1();
    //    public static Func<DataRow, object> С_9__1_0;
    //    public static Func<IGrouping<object, DataRow>, DataRow> С_9__1_1;

    //    internal object method_0(DataRow dataRow_0)
    //    {
    //        return dataRow_0["Tag"];
    //    }

    //    internal DataRow method_1(IGrouping<object, DataRow> igrouping_0)
    //    {
    //        return igrouping_0.First<DataRow>();
    //    }
    //}
}

