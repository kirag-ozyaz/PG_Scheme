using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using DailyReportN.DataSet;
using DataSql;
using SchemeModel;
/// <summary>
/// Создание справочных таблиц
/// </summary>
internal static class CreateReferenceTables
{
    /// <summary>
    /// Выбор объекта схемы
    /// </summary>
    internal static void GetSelectSchmObj(SQLSettings sqlsettings, DataRow row, TextBox txt, ref bool flag, int? flagVisibleSubstantion = null)
	{
		FormSelectSchmObj form = new FormSelectSchmObj();
		form.SqlSettings = sqlsettings;
		form.SetFlagChkSelectionAllSubstantion(flagVisibleSubstantion);
		form.FormBorderStyle = FormBorderStyle.FixedDialog;
		form.MaximizeBox = false;
		form.MinimizeBox = false;
		if (form.ShowDialog() == DialogResult.OK)
		{
			flag = true; 
			if (form.GetDictionaryKey().Count > 0)
			{
				row["idSchmObj"] = form.GetDictionaryKey().First<KeyValuePair<int, string>>().Key;
				txt.Text = form.GetDictionaryKey().First<KeyValuePair<int, string>>().Value;
				return;
			}
			row["idSchmObj"] = DBNull.Value;
			txt.Text = string.Empty;
		}
	}
    //internal static void SetTableActDetection(DataTable table, dsDamage ds, int idParent)
    //{
    //    foreach (DataRow dataRow in table.Rows)
    //    {
    //    }
    //}
    internal static void SetTableDamage(DataRow row, dsDamage ds, int idParent, int TypeDoc, bool isDivisionApply = false, bool isLaboratory = false)
    {
        row["DateDoc"] = ds.tJ_Damage.Rows[0]["dateDoc"];
        row["TypeDoc"] = TypeDoc;
        if (Convert.ToDateTime(ds.tJ_Damage.Rows[0]["dateDoc"]).Year < 2016)
        {
            row["numRequest"] = ds.tJ_Damage.Rows[0]["numRequest"];
        }
        row["idCompiler"] = ds.tJ_Damage.Rows[0]["idCompiler"];
        row["idDivision"] = ds.tJ_Damage.Rows[0]["idDivision"];
        row["idSchmObj"] = ds.tJ_Damage.Rows[0]["idSchmObj"];
        row["idStreet"] = ds.tJ_Damage.Rows[0]["idStreet"];
        row["idMap"] = ds.tJ_Damage.Rows[0]["idMap"];
        row["defectlocation"] = ds.tJ_Damage.Rows[0]["defectlocation"];
        row["idreason"] = ds.tJ_Damage.Rows[0]["idreason"];
        if (isDivisionApply)
        {
            row["idDivisionApply"] = ds.tJ_Damage.Rows[0]["idDivisionApply"];
            row["DivisionInstruction"] = ds.tJ_Damage.Rows[0]["DivisionInstruction"];
        }
        else
        {
            row["idDivisionApply"] = DBNull.Value;
        }
        if (isLaboratory)
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
        row["is81"] = ds.tJ_Damage.Rows[0]["is81"];
        row["idParent"] = idParent;
    }
    internal static void SetTableDamage(DataRow row, DataTable tJ_Damage, int idParent, int TypeDoc, bool isDivisionApply = false, bool isLaboratory = false)
    {
        row["DateDoc"] = tJ_Damage.Rows[0]["dateDoc"];
        row["TypeDoc"] = TypeDoc;
        if (Convert.ToDateTime(tJ_Damage.Rows[0]["dateDoc"]).Year < 2016)
        {
            row["numRequest"] = tJ_Damage.Rows[0]["numRequest"];
        }
        row["idCompiler"] = tJ_Damage.Rows[0]["idCompiler"];
        row["idDivision"] = tJ_Damage.Rows[0]["idDivision"];
        row["idSchmObj"] = tJ_Damage.Rows[0]["idSchmObj"];
        row["idStreet"] = tJ_Damage.Rows[0]["idStreet"];
        row["idMap"] = tJ_Damage.Rows[0]["idMap"];
        row["defectlocation"] = tJ_Damage.Rows[0]["defectlocation"];
        row["idreason"] = tJ_Damage.Rows[0]["idreason"];
        if (isDivisionApply)
        {
            row["idDivisionApply"] = tJ_Damage.Rows[0]["idDivisionApply"];
            row["DivisionInstruction"] = tJ_Damage.Rows[0]["DivisionInstruction"];
        }
        else
        {
            row["idDivisionApply"] = DBNull.Value;
        }
        if (isLaboratory)
        {
            row["isLaboratory"] = tJ_Damage.Rows[0]["isLaboratory"];
            row["DivisionInstruction"] = tJ_Damage.Rows[0]["LaboratoryInstruction"];
        }
        else
        {
            row["isLaboratory"] = DBNull.Value;
        }
        row["idCompletedWorkODS"] = tJ_Damage.Rows[0]["idCompletedWork"];
        row["CompletedWorkTextODS"] = tJ_Damage.Rows[0]["ComletedWorkText"];
        row["is81"] = tJ_Damage.Rows[0]["is81"];
        row["idParent"] = idParent;
    }
    internal static DataTable CreateTableKladObj()
    {
        return new DataTable("tR_KladrObj")
        {
            Columns =
            {
                {
                    "id",
                    typeof(int)
                },
                {
                    "parentid",
                    typeof(int)
                },
                {
                    "name",
                    typeof(string)
                },
                {
                    "primarykey",
                    typeof(string)
                },
                {
                    "socr",
                    typeof(string)
                },
                {
                    "fullname",
                    typeof(string),
                    "name + isnull(' ' + socr, '')"
                }
            }
        };
    }

    internal static DataTable CreateTableKladrStreet()
	{
		return new DataTable("tR_KladrStreet")
		{
			Columns = 
			{
				{
					"id",
					typeof(int)
				},
				{
					"KladrObjId",
					typeof(int)
				},
				{
					"name",
					typeof(string)
				},
				{
					"socr",
					typeof(string)
				},
				{
					"fullname",
					typeof(string),
					"name + isnull(' ' + socr, '')"
				}
			}
		};
	}

    //internal static DataTable CreateTableClassifier()
    //{
    //    return new DataTable("tR_Classifier")
    //    {
    //        Columns =
    //        {
    //            {
    //                "id",
    //                typeof(int)
    //            },
    //            {
    //                "name",
    //                typeof(string)
    //            }
    //        }
    //    };
    //}

    internal static XmlDocument CreateXmlAbnOff(DataTable dt)
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode xmlNode = xmlDocument.CreateElement("AbnOff");
		xmlDocument.AppendChild(xmlNode);
		foreach (object obj in dt.Rows)
		{
			DataRow dataRow = (DataRow)obj;
			if (dataRow.RowState != DataRowState.Deleted)
			{
				XmlNode xmlNode2 = xmlDocument.CreateElement("Row");
				xmlNode.AppendChild(xmlNode2);
				XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("idAbnObj");
				xmlAttribute.Value = dataRow["idAbnObj"].ToString();
				xmlNode2.Attributes.Append(xmlAttribute);
			}
		}
		return xmlDocument;
	}

	//internal static void LoadTableDamageAbnFull(DataTable dtIN, DataTable dtOUT, SQLSettings sqlsettings)
	//{
	//	dtOUT.Clear();
	//	if (dtIN.Rows.Count > 0 && dtIN.Rows[0]["AbnOff"] != DBNull.Value)
	//	{
	//		try
	//		{
	//			XmlDocument xmlDocument = new XmlDocument();
	//			xmlDocument.LoadXml(dtIN.Rows[0]["AbnOff"].ToString());
	//			XmlNode xmlNode = xmlDocument.SelectSingleNode("AbnOff");
	//			if (xmlNode != null)
	//			{
	//				List<string> list = new List<string>();
	//				foreach (object obj in xmlNode.SelectNodes("Row"))
	//				{
	//					XmlAttribute xmlAttribute = ((XmlNode)obj).Attributes["idAbnObj"];
	//					if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
	//					{
	//						list.Add(xmlAttribute.Value);
	//					}
	//				}
	//				if (list.Count > 0)
	//				{
	//					new SqlDataCommand(sqlsettings).SelectSqlData(dtOUT, true, " where idAbnObj in (" + string.Join(",", list.ToArray()) + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj, commentODS ", 0, false, 0);
	//				}
	//			}
	//		}
	//		catch (Exception ex)
	//		{
	//			MessageBox.Show(ex.Message, ex.Source);
	//		}
	//	}
	//}



	//internal static void LoadTableDamageAbnFull2(DataTable dtIN, DataTable dtOUT, SQLSettings sqlsettings)
	//{
	//	dtOUT.Clear();
	//	if (dtIN.Rows.Count > 0 && dtIN.Rows[0]["CommentXml"] != DBNull.Value)
	//	{
	//		try
	//		{
	//			XmlDocument xmlDocument = new XmlDocument();
	//			xmlDocument.LoadXml(dtIN.Rows[0]["CommentXml"].ToString());
	//			XmlNode xmlNode = xmlDocument.SelectSingleNode("Doc");
	//			if (xmlNode != null)
	//			{
	//				XmlNode xmlNode2 = xmlNode.SelectSingleNode("AbnOff");
	//				if (xmlNode2 != null)
	//				{
	//					List<string> list = new List<string>();
	//					foreach (object obj in xmlNode2.SelectNodes("Row"))
	//					{
	//						XmlAttribute xmlAttribute = ((XmlNode)obj).Attributes["idAbnObj"];
	//						if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
	//						{
	//							list.Add(xmlAttribute.Value);
	//						}
	//					}
	//					if (list.Count > 0)
	//					{
	//						DateTime dateTime = DateTime.Now;
	//						if (dtIN.Rows[0]["DateDoc"] != DBNull.Value)
	//						{
	//							dateTime = Convert.ToDateTime(dtIN.Rows[0]["DateDoc"]);
	//						}
	//						string strSelect = "select ";
	//						foreach (DataColumn dataColumn in dtOUT.Columns)
	//						{
	//							if (dataColumn.ColumnName.ToLower() != "countpoint")
	//							{
	//								strSelect = strSelect + "[" + dataColumn.ColumnName + "], ";
	//							}
	//						}
	//						strSelect += string.Format("(select count(id) from tPoint where idAbnObj = vl_SChmAbnFull.idAbnObj \r\n                                                    and dateBegin <= '{0}' \r\n                                                    and (dateEnd >= '{0}' or dateEnd is null)) as countPoint ", dateTime.ToString("yyyyMMdd"));
	//						strSelect = strSelect + " from " + dtOUT.TableName;
	//						strSelect = strSelect + " where idAbnObj in (" + string.Join(",", list.ToArray()) + ") and abnActive = 1 and objactive = 1 ";
	//						strSelect += " group by ";
	//						for (int i = 0; i < dtOUT.Columns.Count; i++)
	//						{
	//							if (dtOUT.Columns[i].ColumnName.ToLower() != "countpoint")
	//							{
	//								if (i == 0)
	//								{
	//									strSelect = strSelect + "[" + dtOUT.Columns[i].ColumnName + "]";
	//								}
	//								else
	//								{
	//									strSelect = strSelect + ",[" + dtOUT.Columns[i].ColumnName + "]";
	//								}
	//							}
	//						}
	//						using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString()))
	//						{
	//							dtOUT.Clear();
	//							sqlConnection.Open();
	//							using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSelect, sqlConnection))
	//							{
	//								sqlDataAdapter.SelectCommand.CommandTimeout = 0;
	//								sqlDataAdapter.Fill(dtOUT);
	//							}
	//						}
	//					}
	//				}
	//			}
	//		}
	//		catch (Exception ex)
	//		{
	//			MessageBox.Show(ex.Message, ex.Source);
	//		}
	//	}
	//}

	//internal static void LoadTableSChmAbnFull(DataTable dt, SQLSettings sqlsettings, List<ElectricObject> listElectricObj, DateTime dateTime)
	//{
	//	if (listElectricObj != null && listElectricObj.Count != 0)
	//	{
	//		string strWhereIN = "";
	//		foreach (ElectricObject electricObject in listElectricObj)
	//		{
	//			if (string.IsNullOrEmpty(strWhereIN))
	//			{
	//				strWhereIN = electricObject.Id.ToString();
	//			}
	//			else
	//			{
	//				strWhereIN = strWhereIN + "," + electricObject.Id.ToString();
	//			}
	//		}
	//		string strSelect = "select ";
	//		foreach (DataColumn dataColumn in dt.Columns)
	//		{
	//			if (dataColumn.ColumnName.ToLower() != "countpoint")
	//			{
	//				strSelect = strSelect + "[" + dataColumn.ColumnName + "], ";
	//			}
	//		}
	//		strSelect += string.Format("(select count(id) from tPoint where idAbnObj = vl_SChmAbnFull.idAbnObj \r\n                                                    and dateBegin <= '{0}' \r\n                                                    and (dateEnd >= '{0}' or dateEnd is null)) as countPoint ", dateTime.ToString("yyyyMMdd"));
	//		strSelect = strSelect + " from " + dt.TableName;
	//		strSelect = strSelect + " where idSchmObj in (" + strWhereIN + ") and abnActive = 1 and objactive = 1 ";
	//		strSelect += " group by ";
	//		for (int i = 0; i < dt.Columns.Count; i++)
	//		{
	//			if (dt.Columns[i].ColumnName.ToLower() != "countpoint")
	//			{
	//				if (i == 0)
	//				{
	//					strSelect = strSelect + "[" + dt.Columns[i].ColumnName + "]";
	//				}
	//				else
	//				{
	//					strSelect = strSelect + ",[" + dt.Columns[i].ColumnName + "]";
	//				}
	//			}
	//		}
	//		using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString()))
	//		{
	//			dt.Clear();
	//			sqlConnection.Open();
	//			using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSelect, sqlConnection))
	//			{
	//				sqlDataAdapter.SelectCommand.CommandTimeout = 0;
	//				sqlDataAdapter.Fill(dt);
	//			}
	//		}
	//		return;
	//	}
	//	dt.Clear();
	//}
}
