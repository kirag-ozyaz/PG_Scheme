using DataSql;
using Documents.Forms.DailyReport.DataSets;
using Microsoft.Office.Interop.Excel;
using SchemeModel;
using SchemeModel.Calculations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml;

internal class ImportOldData
{
    internal static void ImportOldDamage(string file, SQLSettings sqlsettings_0)
    {
        int num = 0;
        try
        {
            Microsoft.Office.Interop.Excel.Application application = new ApplicationClass();
            application.Visible=(true);
            Workbook workbook = application.Workbooks.Open(file, 0, false, 5, "", "", false, (XlPlatform) 2, "", true, false, 0, true, false, false);
            try
            {
                Range range = ((Worksheet) workbook.ActiveSheet).UsedRange;
                for (int i = 5; i <= range.Rows.Count; i++)
                {
                    int? nullable;
                    DataRow row4;
                    //Class193 class2 = new Class193();
                    DataRow rowD;
                    DataSetDamage damage = new DataSetDamage();
                    damage.tJ_Damage.Columns.Add("commentXml", typeof(string));
                    rowD = damage.tJ_Damage.NewRow();
                    rowD["TypeDoc"] = 0x57a;
                    rowD["idCompiler"] = 0xff;
                    rowD["idDivision"] = 0x57d;
                    DataRow row = damage.tJ_DamageOn.NewRow();
                    row["idDamage"] = -1;
                    row["countSchmObj"] = 0;
                    DataRow row2 = damage.tJ_DamageHV.NewRow();
                    row2["idDamage"] = -1;
                    row2["coefFI"] = 0.9;
                    row2["coefseason"] = 0.8;
                    DataRow row3 = damage.tJ_DamageCharacter.NewRow();
                    row3["idDamage"] = -1;
                    num++;
                    if (num == 0x40)
                    {
                    }
                    SQLSettings settings = new SQLSettings("ulges-sql2", "ges", "WINDOWS", "", "");
                    SqlDataCommand command = new SqlDataCommand(settings);
                    XmlDocument document = new XmlDocument();
                    XmlNode newChild = document.CreateElement("Doc");
                    document.AppendChild(newChild);
                    XmlNode node2 = document.CreateElement("Row");
                    newChild.AppendChild(node2);
                    XmlNode node3 = document.CreateElement("Comment");
                    newChild.AppendChild(node3);
                    XmlAttribute node = document.CreateAttribute("NYear");

                    if ((range.Cells[i, 1] as Range).get_Value(Type.Missing) != null)
                    {
                        node.Value = (range.Cells[i, 1] as Range).get_Value(Type.Missing).ToString();
                    }
                    node3.Attributes.Append(node);
                    node = document.CreateAttribute("ClassificationDamage");
                    if ((range.Cells[i, 2] as Range).get_Value(Type.Missing) != null)
                    {
                        node.Value = (range.Cells[i, 2] as Range).get_Value(Type.Missing).ToString();
                    }
                    node3.Attributes.Append(node);
                    node = document.CreateAttribute("NMonth");
                    if ((range.Cells[i, 3] as Range).get_Value(Type.Missing) != null)
                    {
                        node.Value = (range.Cells[i, 3] as Range).get_Value(Type.Missing).ToString();
                    }
                    node3.Attributes.Append(node);
                    DateTime time = new DateTime(0x7df, 1, 1);
                    node = document.CreateAttribute("DateOff");
                    if (((range.Cells[i, 6] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 6] as Range).get_Value(Type.Missing).ToString()))
                    {
                        time = Convert.ToDateTime((range.Cells[i, 6] as Range).get_Value(Type.Missing).ToString());
                    }
                    if (((range.Cells[i, 7] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 7] as Range).get_Value(Type.Missing).ToString()))
                    {
                        TimeSpan timeOfDay = Convert.ToDateTime(CalcTime((range.Cells[i, 7] as Range).get_Value(Type.Missing).ToString())).TimeOfDay;
                        time = time.Add(timeOfDay);
                    }
                    node.Value = time.ToString();
                    node2.Attributes.Append(node);
                    rowD["dateDoc"] = time;
                    DateTime time3 = time;
                    node = document.CreateAttribute("DateOn");
                    if (((range.Cells[i, 8] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 8] as Range).get_Value(Type.Missing).ToString()))
                    {
                        time3 = Convert.ToDateTime((range.Cells[i, 8] as Range).get_Value(Type.Missing).ToString());
                    }
                    if (((range.Cells[i, 9] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 9] as Range).get_Value(Type.Missing).ToString()))
                    {
                        TimeSpan span2 = Convert.ToDateTime(CalcTime((range.Cells[i, 9] as Range).get_Value(Type.Missing).ToString())).TimeOfDay;
                        time3 = time3.Add(span2);
                    }
                    node.Value = time3.ToString();
                    node2.Attributes.Append(node);
                    rowD["isApply"] = true;
                    rowD["dateApply"] = time3;
                    row["dateOn"] = time3;
                    node = document.CreateAttribute("SR");
                    if ((range.Cells[i, 10] as Range).get_Value(Type.Missing) != null)
                    {
                        node.Value = (range.Cells[i, 10] as Range).get_Value(Type.Missing).ToString();
                    }
                    node3.Attributes.Append(node);
                    node = document.CreateAttribute("SchmName");
                    if (((range.Cells[i, 11] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 11] as Range).get_Value(Type.Missing).ToString()))
                    {
                        string str = (range.Cells[i, 11] as Range).get_Value(Type.Missing).ToString();
                        node.Value = (range.Cells[i, 11] as Range).get_Value(Type.Missing).ToString();
                        nullable = null;
                        System.Data.DataTable table = command.SelectSqlData("vSchm_ObjList", true, "where (typeCodeSocr+'-'+name) = '" + str + "' and deleted = 0 ", nullable);
                        if (table.Rows.Count > 0)
                        {
                            XmlAttribute attribute2 = document.CreateAttribute("SchmId");
                            attribute2.Value = table.Rows[0]["id"].ToString();
                            rowD["idSchmObj"] = table.Rows[0]["id"];
                            node2.Attributes.Append(attribute2);
                        }
                        if (((range.Cells[i, 12] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 12] as Range).get_Value(Type.Missing).ToString()))
                        {
                            string str2 = (range.Cells[i, 12] as Range).get_Value(Type.Missing).ToString();
                            XmlAttribute attribute3 = document.CreateAttribute("CellName");
                            attribute3.Value = str2;
                            node2.Attributes.Append(attribute3);
                            if (table.Rows.Count > 0)
                            {
                                string[] textArray1 = new string[] { "where idParent = ", table.Rows[0]["id"].ToString(), " and typeCodeId in (672,674,675,676) and deleted = 0 and name = '", str2, "'" };
                                nullable = null;
                                System.Data.DataTable table2 = command.SelectSqlData("vSchm_ObjList", true, string.Concat(textArray1), nullable);
                                if (table2.Rows.Count > 0)
                                {
                                    XmlAttribute attribute4 = document.CreateAttribute("CellId");
                                    attribute4.Value = table2.Rows[0]["Id"].ToString();
                                    rowD["idSchmObj"] = table2.Rows[0]["Id"];
                                    node2.Attributes.Append(attribute4);
                                    switch (Convert.ToInt32(table2.Rows[0]["TypeCodeId"]))
                                    {
                                        case 0x2a3:
                                            row2["PowerV"] = 6;
                                            break;

                                        case 0x2a4:
                                            row2["PowerV"] = 10;
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    node2.Attributes.Append(node);
                    if (((range.Cells[i, 13] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 13] as Range).get_Value(Type.Missing).ToString()))
                    {
                        node = document.CreateAttribute("TypeRZA");
                        node.Value = (range.Cells[i, 13] as Range).get_Value(Type.Missing).ToString();
                        node2.Attributes.Append(node);
                        nullable = null;
                        System.Data.DataTable table3 = command.SelectSqlData("tr_classifier", true, " where PArentId = 1566 and Name = '" + node.Value + "'", nullable);
                        if (table3.Rows.Count > 0)
                        {
                            node = document.CreateAttribute("TypeRZA");
                            node.Value = table3.Rows[0]["id"].ToString();
                            row2["idTypeRZA"] = table3.Rows[0]["id"];
                            node2.Attributes.Append(node);
                        }
                    }
                    if (((range.Cells[i, 14] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 14] as Range).get_Value(Type.Missing).ToString()))
                    {
                        node = document.CreateAttribute("col1Name");
                        node.Value = (range.Cells[i, 14] as Range).get_Value(Type.Missing).ToString();
                        node2.Attributes.Append(node);
                        nullable = null;
                        System.Data.DataTable table4 = command.SelectSqlData("tr_classifier", true, " where PArentId = 1438 and Name like '%" + node.Value + "%'", nullable);
                        if (table4.Rows.Count > 0)
                        {
                            node = document.CreateAttribute("col1");
                            node.Value = table4.Rows[0]["id"].ToString();
                            row3["col1"] = table4.Rows[0]["id"];
                            node2.Attributes.Append(node);
                            if (((range.Cells[i, 0x11] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 0x11] as Range).get_Value(Type.Missing).ToString()))
                            {
                                node = document.CreateAttribute("col2Name");
                                node.Value = (range.Cells[i, 0x11] as Range).get_Value(Type.Missing).ToString();
                                node2.Attributes.Append(node);
                                string[] textArray2 = new string[] { " where PArentId = ", table4.Rows[0]["id"].ToString(), " and Name like '%", node.Value, "%'" };
                                nullable = null;
                                System.Data.DataTable table5 = command.SelectSqlData("tr_classifier", true, string.Concat(textArray2), nullable);
                                if (table5.Rows.Count > 0)
                                {
                                    node = document.CreateAttribute("col2");
                                    node.Value = table5.Rows[0]["id"].ToString();
                                    row3["col2"] = table5.Rows[0]["id"];
                                    node2.Attributes.Append(node);
                                }
                            }
                        }
                    }
                    if (((range.Cells[i, 15] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 15] as Range).get_Value(Type.Missing).ToString()))
                    {
                        node = document.CreateAttribute("Accessory");
                        node.Value = (range.Cells[i, 15] as Range).get_Value(Type.Missing).ToString();
                        node2.Attributes.Append(node);
                    }
                    if (((range.Cells[i, 0x10] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 0x10] as Range).get_Value(Type.Missing).ToString()))
                    {
                        node = document.CreateAttribute("Location");
                        node.Value = (range.Cells[i, 0x10] as Range).get_Value(Type.Missing).ToString();
                        rowD["DefectLocation"] = node.Value;
                        node2.Attributes.Append(node);
                    }
                    rowD["ComletedWorkText"] = "";
                    if (((range.Cells[i, 0x12] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 0x12] as Range).get_Value(Type.Missing).ToString()))
                    {
                        node = document.CreateAttribute("Responsible");
                        node.Value = (range.Cells[i, 0x12] as Range).get_Value(Type.Missing).ToString();
                        row4 = rowD;
                        row4["ComletedWorkText"] = row4["ComletedWorkText"] + node.Value;
                        node3.Attributes.Append(node);
                    }
                    if (((range.Cells[i, 0x13] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 0x13] as Range).get_Value(Type.Missing).ToString()))
                    {
                        node = document.CreateAttribute("Nokwt");
                        decimal result = new decimal();
                        decimal.TryParse((range.Cells[i, 0x13] as Range).get_Value(Type.Missing).ToString(), out result);
                        node.Value = result.ToString();
                        row["noAdmissionKWT"] = result;
                        row2["NoAdmissionKWT"] = result;
                        node3.Attributes.Append(node);
                    }
                    if (((range.Cells[i, 0x16] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 0x16] as Range).get_Value(Type.Missing).ToString()))
                    {
                        node = document.CreateAttribute("Reason");
                        string str3 = (range.Cells[i, 0x16] as Range).get_Value(Type.Missing).ToString();
                        node.Value = str3;
                        row4 = rowD;
                        row4["ComletedWorkText"] = row4["ComletedWorkText"] + "\r\n" + str3;
                        node3.Attributes.Append(node);
                    }
                    if (((range.Cells[i, 0x17] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 0x17] as Range).get_Value(Type.Missing).ToString()))
                    {
                        node = document.CreateAttribute("Comment");
                        string str4 = (range.Cells[i, 0x17] as Range).get_Value(Type.Missing).ToString();
                        node.Value = str4;
                        row4 = rowD;
                        row4["ComletedWorkText"] = row4["ComletedWorkText"] + "\r\n" + str4;
                        node3.Attributes.Append(node);
                    }
                    if (((range.Cells[i, 0x18] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 0x18] as Range).get_Value(Type.Missing).ToString()))
                    {
                        node = document.CreateAttribute("CommentX");
                        string str5 = (range.Cells[i, 0x18] as Range).get_Value(Type.Missing).ToString();
                        node.Value = str5;
                        row4 = rowD;
                        row4["ComletedWorkText"] = row4["ComletedWorkText"] + "\r\n" + str5;
                        node3.Attributes.Append(node);
                    }
                    if (((range.Cells[i, 0x19] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 0x19] as Range).get_Value(Type.Missing).ToString()))
                    {
                        node = document.CreateAttribute("CommentY");
                        string str6 = (range.Cells[i, 0x19] as Range).get_Value(Type.Missing).ToString();
                        node.Value = str6;
                        row4 = rowD;
                        row4["ComletedWorkText"] = row4["ComletedWorkText"] + "\r\n" + str6;
                        node3.Attributes.Append(node);
                    }
                    if (((range.Cells[i, 0x1a] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 0x1a] as Range).get_Value(Type.Missing).ToString()))
                    {
                        node = document.CreateAttribute("CommentZ");
                        string str7 = (range.Cells[i, 0x1a] as Range).get_Value(Type.Missing).ToString();
                        node.Value = str7;
                        row4 = rowD;
                        row4["ComletedWorkText"] = row4["ComletedWorkText"] + "\r\n" + str7;
                        node3.Attributes.Append(node);
                    }
                    if (((range.Cells[i, 27 /*0x1b*/] as Range).get_Value(Type.Missing) != null) && !string.IsNullOrEmpty((range.Cells[i, 27 /*0x1b*/] as Range).get_Value(Type.Missing).ToString()))
                    {
                        node = document.CreateAttribute("CommentAA");
                        string str8 = (range.Cells[i, 27 /*0x1b*/] as Range).get_Value(Type.Missing).ToString();
                        node.Value = str8;
                        row4 = rowD;
                        row4["ComletedWorkText"] = row4["ComletedWorkText"] + "\r\n" + str8;
                        node3.Attributes.Append(node);
                    }
                    rowD["CommentXml"] = document.InnerXml;
                    if (rowD["idSchmObj"] != DBNull.Value)
                    {
                        ElectricModel model1 = new ElectricModel();
                        model1.SqlSettings=(settings);
                        model1.LoadSchema(time);
                        List<int> list = new List<int>();
                        GetListTransformer(model1.PoweringReportForDrawObject(Convert.ToInt32(rowD["idSchmObj"]), true), list);
                        System.Data.DataTable table6 = GetTableLoadTr(list, settings);
                        //List<ElectricObject> list2 = model1.PoweringReportForDrawObject(model1.Objects.Where<ElectricObject>(new Func<ElectricObject, bool>(class2.method_0)).First<ElectricObject>(), true, true);
                        List<ElectricObject> list2 = model1.PoweringReportForDrawObject(model1.Objects
                            .Where<ElectricObject>(el=> el.Id == Convert.ToInt32(rowD["idSchmObj"]))
                            .First<ElectricObject>(), true, true);

                        System.Data.DataTable table7 = new System.Data.DataTable("vl_schmAbnFull");
                        table7.Columns.Add("idAbn", typeof(int));
                        table7.Columns.Add("idAbnObj", typeof(int));
                        if (list2.Count > 0)
                        {
                            string str9 = "";
                            foreach (ElectricObject obj2 in list2)
                            {
                                if (string.IsNullOrEmpty(str9))
                                {
                                    str9 = obj2.Id.ToString();
                                }
                                else
                                {
                                    str9 = str9 + "," + obj2.Id.ToString();
                                }
                            }
                            command.SelectSqlData(table7, true, " where idSchmObj in (" + str9 + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj ", 0, false, 0);
                        }
                        else
                        {
                            table7.Clear();
                        }
                        row["countSchmObj"] = table6.Rows.Count;
                        row2["countSchmObj"] = table6.Rows.Count;
                        row2["countSchmObjOff"] = 0;
                        row2["ConnectedPower"] = table6.Compute("Sum(Power)", "");
                        row2["PowerA"] = table6.Compute("Sum(Load)", "");
                        row2["TransOff"] = GetXmlTransOff(table6).InnerXml;
                        row2["AbnOff"] = CreateReferenceTables.CreateXmlAbnOff(table7).InnerXml;
                    }
                    damage.tJ_Damage.Rows.Add(rowD);
                    damage.tJ_DamageCharacter.Rows.Add(row3);
                    damage.tJ_DamageHV.Rows.Add(row2);
                    damage.tJ_DamageOn.Rows.Add(row);
                    SqlDataCommand command2 = new SqlDataCommand(sqlsettings_0);
                    int num5 = command2.InsertSqlDataOneRow(damage.tJ_Damage);
                    if (num5 > 0)
                    {
                        damage.tJ_DamageCharacter.Rows[0]["idDamage"] = num5;
                        damage.tJ_DamageCharacter.Rows[0].EndEdit();
                        command2.InsertSqlData(damage, damage.tJ_DamageCharacter);
                        damage.tJ_DamageHV.Rows[0]["idDamage"] = num5;
                        damage.tJ_DamageHV.Rows[0].EndEdit();
                        command2.InsertSqlData(damage, damage.tJ_DamageHV);
                        damage.tJ_DamageOn.Rows[0]["idDamage"] = num5;
                        damage.tJ_DamageOn.Rows[0].EndEdit();
                        command2.InsertSqlData(damage, damage.tJ_DamageOn);
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message + num.ToString(), file);
            }
            finally
            {
                workbook.Close(Type.Missing, Type.Missing, Type.Missing);
                application.Quit();
            }
        }
        catch
        {
        }
    }

    internal static string CalcTime(string str)
    {
        double num = 0.0;
        try
        {
            num = double.Parse(str);
        }
        catch
        {
        }
        int num3 = (int) Math.Round((double) ((num * 1440.0) % 60.0));
        int num2 = (int) ((num * 1440.0) / 60.0);
        if (num3 == 60)
        {
            num3 = 0;
            num2++;
        }
        return (num2 + ":" + num3);
    }

    private static XmlDocument GetXmlTransOff(System.Data.DataTable dt)
    {
        XmlDocument document = new XmlDocument();
        XmlNode newChild = document.CreateElement("TransOff");
        document.AppendChild(newChild);
        foreach (DataRow row in dt.Rows)
        {
            XmlNode node2 = document.CreateElement("Row");
            newChild.AppendChild(node2);
            XmlAttribute node = document.CreateAttribute("idSub");
            node.Value = row["idSub"].ToString();
            node2.Attributes.Append(node);
            node = document.CreateAttribute("idTr");
            node.Value = row["idTr"].ToString();
            node2.Attributes.Append(node);
            node = document.CreateAttribute("Power");
            node.Value = row["Power"].ToString();
            node2.Attributes.Append(node);
            node = document.CreateAttribute("Load");
            node.Value = row["Load"].ToString();
            node2.Attributes.Append(node);
        }
        return document;
    }

    private static void GetListTransformer(TreeNodeObj node, List<int> list)
    {
        if ((node.Tag != null) && (node.Tag is ElectricLine))
        {
            using (List<ElectricRelation>.Enumerator enumerator = ((ElectricLine) node.Tag).Relations.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    foreach (ElectricObject obj2 in enumerator.Current.ChildObjects)
                    {
                        if (((obj2 is ElectricSwitch) && (((ElectricSwitch) obj2).TypeSwitch == TypeSwitch.TransformerTool /*0x22c*/)) && !list.Contains(obj2.Id))
                        {
                            list.Add(obj2.Id);
                        }
                    }
                }
            }
        }
        using (IEnumerator<TreeNodeObj> enumerator3 = node.Nodes.GetEnumerator())
        {
            while (enumerator3.MoveNext())
            {
                GetListTransformer(enumerator3.Current, list);
            }
        }
    }

    private static System.Data.DataTable GetTableLoadTr(List<int> list_0, SQLSettings sqlsettings_0)
    {
        System.Data.DataTable table = new System.Data.DataTable();
        table.Columns.Add("idTr", typeof(int));
        table.Columns.Add("TrName", typeof(string));
        table.Columns.Add("idSub", typeof(int));
        table.Columns.Add("Sub", typeof(string));
        table.Columns.Add("Power", typeof(int));
        table.Columns.Add("load", typeof(int));
        table.Clear();
        using (SqlConnection connection = new SqlConnection(sqlsettings_0.GetConnectionString() + ";Connection Timeout=1000"))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(ResourceReader.GetStringAssembly("Documents.Forms.DailyReport.SqlScripts.GetTransformerSchmObj.sql"), connection))
            {
                command.CommandTimeout = 0;
                System.Data.DataTable dataTable = new System.Data.DataTable();
                new SqlDataAdapter(command).Fill(dataTable);
                int num = 0;
                foreach (int num2 in list_0)
                {
                    DataRow[] rowArray = dataTable.Select("id = " + num2.ToString());
                    if (rowArray.Length != 0)
                    {
                        DataRow row = table.NewRow();
                        row["idTR"] = rowArray[0]["id"];
                        row["TrNAme"] = rowArray[0]["Наименование"];
                        row["idSub"] = rowArray[0]["idSub"];
                        row["Sub"] = rowArray[0]["Расположение"];
                        if ((rowArray[0]["Мощность"] != DBNull.Value) && !string.IsNullOrEmpty(rowArray[0]["Мощность"].ToString()))
                        {
                            row["Power"] = rowArray[0]["Мощность"];
                        }
                        if ((rowArray[0]["Мощность"] != DBNull.Value) && !string.IsNullOrEmpty(rowArray[0]["Мощность"].ToString()))
                        {
                            num += Convert.ToInt32(rowArray[0]["Мощность"]);
                        }
                        table.Rows.Add(row);
                    }
                }
            }
            using (SqlCommand command2 = new SqlCommand("SELECT mat.idbus, mat.[IdObjList],\r\n                        \t(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) \r\n                        \t then max([Ia]) \telse case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) \r\n                        \t\t\t\t\t                                else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) \r\n                        \t\t\t\t\t                                then max([Ic]) end end end) as I\r\n                         FROM [tJ_MeasAmperageTransf] as mat\r\n                               inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n                          where  mat.deleted = 0 and m.[TypeDoc] = 1192\r\n                        \tand ((year(m.[DateD]) = \r\n                        \t\t\t(select case when month(max(dateD)) = 12 then year(max(dateD)) + 1\r\n                        \t\t\t\t\telse year(max(dateD)) end from tj_measurement mes \r\n                        \t\t\tleft join [tJ_MeasAmperageTransf] mt on mt.[idMeasurement] = mes.id\r\n                        \t\t\t where mt.idBus = mat.idBus and mt.deleted = 0 and m.typeDoc = 1192\t\r\n                        \t\t\t and  mt.[Ia] is not null and  mt.[Ib] is not null and  mt.[Ic] is not null)\r\n                                      and month(m.[DateD]) between 1 and 11)\t\r\n                           or (year(m.[DateD]) =(select case when month(max(dateD)) = 12 then year(max(dateD)) + 1\r\n                        \telse year(max(dateD)) end\r\n                        \tfrom tj_measurement mes \r\n                        \tleft join [tJ_MeasAmperageTransf] mt on mt.[idMeasurement] = mes.id\r\n                        \twhere mt.idBus = mat.idBus and mt.deleted = 0 and m.typeDoc = 1192\r\n                        \t and  mt.[Ia] is not null and  mt.[Ib] is not null and  mt.[Ic] is not null)-1 and month(m.[DateD])=12)) \r\n                            and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n                          group by mat.idBus,  mat.[idObjList]", connection))
            {
                command2.CommandTimeout = 0;
                System.Data.DataTable table3 = new System.Data.DataTable();
                new SqlDataAdapter(command2).Fill(table3);
                foreach (DataRow row2 in table.Rows)
                {
                    DataRow[] rowArray2 = table3.Select("idObjList = " + row2["idTr"].ToString());
                    if (rowArray2.Length != 0)
                    {
                        row2["Load"] = rowArray2[0]["I"];
                    }
                }
                return table;
            }
        }
    }

    //[CompilerGenerated]
    //private sealed class Class193
    //{
    //    public DataRow row;

    //    internal bool method_0(ElectricObject el)
    //    {
    //        return (el.Id == Convert.ToInt32(this.row["idSchmObj"]));
    //    }
    //}
}

