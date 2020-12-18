using DataSql;
using Documents.Forms.DailyReport.DataSets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
//CreateReferenceTables
internal static class CreateReferenceTables
{
    //Get_SelectSchmObj
    internal static void Get_SelectSchmObj(SQLSettings sqlsettings, DataRow row, TextBox txt, ref bool flag)
    {
        FormSelectSchmObj form = new FormSelectSchmObj();
        form.SqlSettings=(sqlsettings);
        form.FormBorderStyle = FormBorderStyle.FixedDialog;
        form.MaximizeBox = false;
        form.MinimizeBox = false;
        if (form.ShowDialog() == DialogResult.OK)
        {
            flag = true;
            if (form.method_0().Count > 0)
            {
                row["idSchmObj"] = form.method_0().First<KeyValuePair<int, string>>().Key;
                txt.Text = form.method_0().First<KeyValuePair<int, string>>().Value;
            }
            else
            {
                row["idSchmObj"] = DBNull.Value;
                txt.Text = string.Empty;
            }
        }
    }
    //Set_TableDamage
    internal static void Set_TableDamage(DataRow row, DataSetDamage ds, int int_0, int int_1, bool flag1 = false, bool flag2 = false)
    {
        row["DateDoc"] = ds.tJ_Damage.Rows[0]["dateDoc"];
        row["TypeDoc"] = int_1;
        if (Convert.ToDateTime(ds.tJ_Damage.Rows[0]["dateDoc"]).Year < 0x7e0)
        {
            row["numRequest"] = ds.tJ_Damage.Rows[0]["numRequest"];
        }
        row["idCompiler"] = ds.tJ_Damage.Rows[0]["idCompiler"];
        row["idDivision"] = ds.tJ_Damage.Rows[0]["idDivision"];
        row["idSchmObj"] = ds.tJ_Damage.Rows[0]["idSchmObj"];
        row["idMap"] = ds.tJ_Damage.Rows[0]["idMap"];
        row["defectlocation"] = ds.tJ_Damage.Rows[0]["defectlocation"];
        row["idreason"] = ds.tJ_Damage.Rows[0]["idreason"];
        if (flag1)
        {
            row["idDivisionApply"] = ds.tJ_Damage.Rows[0]["idDivisionApply"];
            row["DivisionInstruction"] = ds.tJ_Damage.Rows[0]["DivisionInstruction"];
        }
        else
        {
            row["idDivisionApply"] = DBNull.Value;
        }
        if (flag2)
        {
            row["isLaboratory"] = ds.tJ_Damage.Rows[0]["isLaboratory"];
            row["DivisionInstruction"] = ds.tJ_Damage.Rows[0]["LaboratoryInstruction"];
        }
        else
        {
            row["isLaboratory"] = DBNull.Value;
        }
        row["idCompletedWorkODS"] = ds.tJ_Damage.Rows[0]["idCompletedWork"];
        row["CompletedWorkTextODS"] = ds.tJ_Damage.Rows[0]["ComletedWorkText"];
        row["idParent"] = int_0;
    }
    //CreateTableKladObj
    internal static DataTable CreateTableKladObj()
    {
        DataTable table1 = new DataTable("tR_KladrObj");
        table1.Columns.Add("id", typeof(int));
        table1.Columns.Add("parentid", typeof(int));
        table1.Columns.Add("name", typeof(string));
        table1.Columns.Add("primarykey", typeof(string));
        table1.Columns.Add("socr", typeof(string));
        table1.Columns.Add("fullname", typeof(string), "name + isnull(' ' + socr, '')");
        return table1;
    }

    internal static DataTable CreateTableKladrStreet()
    {
        DataTable table1 = new DataTable("tR_KladrStreet");
        table1.Columns.Add("id", typeof(int));
        table1.Columns.Add("KladrObjId", typeof(int));
        table1.Columns.Add("name", typeof(string));
        table1.Columns.Add("socr", typeof(string));
        table1.Columns.Add("fullname", typeof(string), "name + isnull(' ' + socr, '')");
        return table1;
    }

    internal static XmlDocument CreateXmlAbnOff(DataTable dt)
    {
        XmlDocument document = new XmlDocument();
        XmlNode newChild = document.CreateElement("AbnOff");
        document.AppendChild(newChild);
        foreach (DataRow row in dt.Rows)
        {
            if (row.RowState != DataRowState.Deleted)
            {
                XmlNode node2 = document.CreateElement("Row");
                newChild.AppendChild(node2);
                XmlAttribute node = document.CreateAttribute("idAbnObj");
                node.Value = row["idAbnObj"].ToString();
                node2.Attributes.Append(node);
            }
        }
        return document;
    }
    //Load_TableDamageAbnFull
    internal static void Load_TableDamageAbnFull(DataTable dt1, DataTable dt2, SQLSettings sqlsettings)
    {
        dt2.Clear();
        if ((dt1.Rows.Count > 0) && (dt1.Rows[0]["AbnOff"] != DBNull.Value))
        {
            try
            {
                XmlDocument document1 = new XmlDocument();
                document1.LoadXml(dt1.Rows[0]["AbnOff"].ToString());
                XmlNode node = document1.SelectSingleNode("AbnOff");
                if (node != null)
                {
                    List<string> list = new List<string>();
                    //using (IEnumerator enumerator = node.SelectNodes("Row").GetEnumerator())
                    //{
                    //    while (enumerator.MoveNext())
                    foreach (IEnumerator enumerator in node.SelectNodes("Row"))
                        {
                            XmlAttribute attribute = ((XmlNode) enumerator.Current).Attributes["idAbnObj"];
                            if ((attribute != null) && !string.IsNullOrEmpty(attribute.Value))
                            {
                                list.Add(attribute.Value);
                            }
                        }
                    //}
                    if (list.Count > 0)
                    {
                        new SqlDataCommand(sqlsettings).SelectSqlData(dt2, true, " where idAbnObj in (" + string.Join(",", list.ToArray()) + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj, commentODS ", 0, false, 0);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source);
            }
        }
    }
}

