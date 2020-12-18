using DataSql;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

internal static class Class188
{
    private static DataTable smethod_0(SQLSettings sqlsettings_0, DateTime dateTime_0, bool bool_0, bool bool_1)
    {
        SqlDataCommand command = new SqlDataCommand(sqlsettings_0);
        int num = 0x45b;
        int? nullable = null;
        string str = "";
        foreach (DataRow row in command.SelectSqlData("vAbnType", true, " where typeKontragent = " + num.ToString(), nullable).Rows)
        {
            if (!string.IsNullOrEmpty(str))
            {
                str = str + ",";
            }
            str = str + row["idAbn"].ToString();
        }
        string str2 = "";
        if (!string.IsNullOrEmpty(str))
        {
            if (bool_1)
            {
                str2 = str2 + " and (vj_excavation.idContractor in (" + str + ")) ";
            }
            else
            {
                str2 = str2 + " and (vj_excavation.idContractor not in (" + str + ")) ";
            }
        }
        string str3 = bool_0 ? " and vj_excavation.agreed = 1 " : "";
        string[] textArray1 = new string[] { "left join tj_excavationstatus sOrder on sOrder.id = (select top 1 id from tj_excavationstatus where idExcavation = vj_excavation.id and idType = 1  and datechange <= '", dateTime_0.ToString("yyyyMMdd"), "' order by datechange desc) left join tr_classifier cOrder on cOrder.id = sOrder.idStatus left join tj_excavationstatus sWork on sWork.id = (select top 1 id from tj_excavationstatus where idExcavation = vj_excavation.id and idType = 2  and datechange <= '", dateTime_0.ToString("yyyyMMdd"), "'  order by datechange desc) left join tr_classifier cStatusWork on cStatusWork.id = sWork.idStatus where cOrder.value not in (1,6) and cStatusWork.ParentKey <> ';Excavation;StatusWork;RealEnd;'  and (vj_excavation.dateBeg <= '", dateTime_0.ToString("yyyyMMdd"), "') and (vj_excavation.dateend is null or vj_excavation.dateEnd >= '", dateTime_0.ToString("yyyyMMdd"), "') ", str3, str2, " order by vj_excavation.region, vj_excavation.address" };
        string str4 = string.Concat(textArray1);
        return command.SelectSqlData("vJ_Excavation", true, str4, null);
    }

    private static void smethod_1(StringBuilder stringBuilder_0, DataTable dataTable_0)
    {
        string str = "";
        for (int i = 0; i < dataTable_0.Rows.Count; i++)
        {
            DataRow row = dataTable_0.Rows[i];
            if (str != row["region"].ToString())
            {
                str = row["region"].ToString();
                stringBuilder_0.Append("<TR>\n");
                stringBuilder_0.Append("<TD VALIGN=CENTER BGCOLOR=#c0dcc0 COLSPAN=6><FONT SIZE=2><I><B>" + (string.IsNullOrEmpty(str) ? "&nbsp" : (str + " район")) + "</B></I></FONT>\n");
                stringBuilder_0.Append("</tr>\n");
            }
            stringBuilder_0.Append("<TR>\n");
            if (row["address"] != DBNull.Value)
            {
                stringBuilder_0.Append("<TD width=\"150\" VALIGN=CENTER><FONT SIZE=2>" + row["address"].ToString() + "</FONT>\n");
            }
            else
            {
                stringBuilder_0.Append("<TD width=\"150\" VALIGN=CENTER><FONT SIZE=2>&nbsp</FONT>\n");
            }
            if (row["permission"] != DBNull.Value)
            {
                stringBuilder_0.Append("<TD width=\"80\" VALIGN=CENTER><FONT SIZE=2>" + row["permission"].ToString() + "</FONT>\n");
            }
            else
            {
                stringBuilder_0.Append("<TD width=\"80\" VALIGN=CENTER><FONT SIZE=2>&nbsp</FONT>\n");
            }
            string[] textArray1 = new string[] { row["typeWorkName"].ToString(), ", (", row["nameKL"].ToString(), "),\n<br>", row["StatusWork"].ToString() };
            string str2 = string.Concat(textArray1);
            if (string.IsNullOrEmpty(str2))
            {
                str2 = "&nbsp";
            }
            stringBuilder_0.Append("<TD width=\"300\" VALIGN=CENTER><FONT SIZE=2>" + str2 + "</FONT>\n");
            if (row["damage"] != DBNull.Value)
            {
                stringBuilder_0.Append("<TD width=\"100\" VALIGN=CENTER><FONT SIZE=2>" + row["damage"].ToString() + "</FONT>\n");
            }
            else
            {
                stringBuilder_0.Append("<TD width=\"100\" VALIGN=CENTER><FONT SIZE=2>&nbsp</FONT>\n");
            }
            stringBuilder_0.Append("<TD width=\"150\" VALIGN=CENTER><FONT SIZE=2>" + ("ордер " + row["statusorder"].ToString() + "\n<br>до " + ((row["dateEndorder"] == DBNull.Value) ? "--.--.----" : Convert.ToDateTime(row["dateEndorder"]).ToString("dd.MM.yyyy"))) + "</FONT>\n");
            stringBuilder_0.Append("</tr>\n");
            i = i++;
        }
    }

    internal static bool smethod_2(SQLSettings sqlsettings_0, string string_0, DateTime dateTime_0, bool bool_0)
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("<html>\n");
        builder.Append("<head>\n");
        builder.Append("<title></title>\n");
        builder.Append("<BASEFONT FACE=\"Arial\" SIZE=8>\n");
        builder.Append("</head>\n");
        builder.Append("<body>\n");
        builder.Append("<TABLE BORDER CELLSPACING=0 style=\"word-wrap: break-word\">\n");
        builder.Append("<TR>\n");
        builder.Append("<TD ALIGN=CENTER BORDERCOLOR=#ffffff COLSPAN=5><FONT SIZE=2><I><B>Сведения о земляных работах МУП \"УльГЭС\"</B></I></FONT>\n");
        builder.Append("</tr>\n");
        builder.Append("<TR>\n");
        builder.Append("<TD ALIGN=RIGHT BORDERCOLOR=#ffffff COLSPAN=5><FONT SIZE=2><I><B>по состоянию на " + dateTime_0.ToShortDateString() + "г.</B></I></FONT>\n");
        builder.Append("</tr>\n");
        builder.Append("<TR>\n");
        builder.Append("<TD width=\"150\" ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Адрес</B></FONT>\n");
        builder.Append("<TD width=\"80\"  ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Номер, дата разрешения</B></FONT>\n");
        builder.Append("<TD width=\"300\" ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Характер и состояние земляных работ</B></FONT>\n");
        builder.Append("<TD width=\"100\" ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Место производства работ</B></FONT>\n");
        builder.Append("<TD width=\"150\" ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Срок сдачи разрешения</B></FONT>\n");
        builder.Append("</tr>\n");
        DataTable table = smethod_0(sqlsettings_0, dateTime_0, bool_0, true);
        smethod_1(builder, table);
        table = smethod_0(sqlsettings_0, dateTime_0, bool_0, false);
        if (table.Rows.Count > 0)
        {
            builder.Append("<TR>\n");
            builder.Append("<TD ALIGN=CENTER VALIGN=CENTER BGCOLOR=#808080 COLSPAN=6><FONT SIZE=2><I><B>Земляные работы, выполняемые подрядчиками</B></I></FONT>\n");
            builder.Append("</tr>\n");
        }
        smethod_1(builder, table);
        builder.Append("</table>\n");
        builder.Append("</body>\n");
        builder.Append("</html>\n");
        return smethod_3(string_0, builder);
    }

    private static bool smethod_3(string string_0, StringBuilder stringBuilder_0)
    {
        try
        {
            File.Delete(string_0);
            StreamWriter writer1 = new StreamWriter(string_0, true, Encoding.Unicode);
            writer1.Write(stringBuilder_0.ToString());
            writer1.Close();
            return true;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return false;
        }
    }
}

