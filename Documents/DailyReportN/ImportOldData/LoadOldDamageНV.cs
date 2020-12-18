using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Xml;
using DataSql;
using Microsoft.Office.Interop.Excel;
using SchemeModel;
using SchemeModel.Calculations;

internal class LoadOldDamageНV
{
#pragma warning disable CS0436 // Тип конфликтует с импортированным типом
    internal static void Load(string FileName, StaticFormData Me)//sqlsettingOut
#pragma warning restore CS0436 // Тип конфликтует с импортированным типом
    {
		int num = 0;
		try
		{
			Microsoft.Office.Interop.Excel.Application application = new ApplicationClass();
			application.Visible = true;
			Workbook workbook = application.Workbooks.Open(FileName, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
			try
			{
				Range usedRange = ((Worksheet)workbook.ActiveSheet).UsedRange;
				for (int i = 5; i <= usedRange.Rows.Count; i++)
				{
                    DailyReportN.DataSet.dsDamage ds = new DailyReportN.DataSet.dsDamage();
                    ds.tJ_Damage.Columns.Add("commentXml", typeof(string));

                    DataRow newRD = ds.tJ_Damage.NewRow();
					newRD["TypeDoc"] = 1402;
					newRD["idCompiler"] = 255;
					newRD["idDivision"] = 1405;

                    DataRow dataRowOn = ds.tJ_DamageOn.NewRow();
					dataRowOn["idDamage"] = -1;
					dataRowOn["countSchmObj"] = 0;

                    DataRow dataRowHV = ds.tJ_DamageHV.NewRow();
					dataRowHV["idDamage"] = -1;
					dataRowHV["coefFI"] = 0.9;
					dataRowHV["coefseason"] = 0.8;

                    DataRow dataRowCharacter = ds.tJ_DamageCharacter.NewRow();
					dataRowCharacter["idDamage"] = -1;
					num++;// тек. строка
					if (num == 64)
					{
					}

                    SQLSettings sqlsettings = new SQLSettings("ulges-sql2", "ges", "WINDOWS", "", "");
					SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings);
					XmlDocument xmlDocument = new XmlDocument();
					XmlNode xmlNodeDoc = xmlDocument.CreateElement("Doc");
					xmlDocument.AppendChild(xmlNodeDoc);
					XmlNode xmlNodeRow = xmlDocument.CreateElement("Row");
					xmlNodeDoc.AppendChild(xmlNodeRow);
					XmlNode xmlNodeComment = xmlDocument.CreateElement("Comment");
					xmlNodeDoc.AppendChild(xmlNodeComment);
                    //
                    XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("NYear");
					if ((usedRange.Cells[i, 1] as Range).get_Value(Type.Missing) != null)
					{
						xmlAttribute.Value = (usedRange.Cells[i, 1] as Range).get_Value(Type.Missing).ToString();
					}
					xmlNodeComment.Attributes.Append(xmlAttribute);

                    xmlAttribute = xmlDocument.CreateAttribute("ClassificationDamage");
					if ((usedRange.Cells[i, 2] as Range).get_Value(Type.Missing) != null)
					{
						xmlAttribute.Value = (usedRange.Cells[i, 2] as Range).get_Value(Type.Missing).ToString();
					}
					xmlNodeComment.Attributes.Append(xmlAttribute);

                    xmlAttribute = xmlDocument.CreateAttribute("NMonth");
					if ((usedRange.Cells[i, 3] as Range).get_Value(Type.Missing) != null)
					{
						xmlAttribute.Value = (usedRange.Cells[i, 3] as Range).get_Value(Type.Missing).ToString();
					}
					xmlNodeComment.Attributes.Append(xmlAttribute);

                    DateTime dateDoc = new DateTime(2015, 1, 1);
					xmlAttribute = xmlDocument.CreateAttribute("DateOff");
					if ((usedRange.Cells[i, 6] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 6] as Range).get_Value(Type.Missing).ToString()))
					{
						dateDoc = Convert.ToDateTime((usedRange.Cells[i, 6] as Range).get_Value(Type.Missing).ToString());
					}
					if ((usedRange.Cells[i, 7] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 7] as Range).get_Value(Type.Missing).ToString()))
					{
						TimeSpan timeOfDay = Convert.ToDateTime(LoadOldDamageНV.ConvertToDateTime((usedRange.Cells[i, 7] as Range).get_Value(Type.Missing).ToString())).TimeOfDay;
						dateDoc = dateDoc.Add(timeOfDay);
					}
					xmlAttribute.Value = dateDoc.ToString();
					xmlNodeRow.Attributes.Append(xmlAttribute);
					newRD["dateDoc"] = dateDoc;

                    DateTime DateOn = dateDoc;
					xmlAttribute = xmlDocument.CreateAttribute("DateOn");
					if ((usedRange.Cells[i, 8] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 8] as Range).get_Value(Type.Missing).ToString()))
					{
						DateOn = Convert.ToDateTime((usedRange.Cells[i, 8] as Range).get_Value(Type.Missing).ToString());
					}
					if ((usedRange.Cells[i, 9] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 9] as Range).get_Value(Type.Missing).ToString()))
					{
						TimeSpan timeOfDay2 = Convert.ToDateTime(LoadOldDamageНV.ConvertToDateTime((usedRange.Cells[i, 9] as Range).get_Value(Type.Missing).ToString())).TimeOfDay;
						DateOn = DateOn.Add(timeOfDay2);
					}
					xmlAttribute.Value = DateOn.ToString();
					xmlNodeRow.Attributes.Append(xmlAttribute);
					newRD["isApply"] = true;
					newRD["dateApply"] = DateOn;
					dataRowOn["dateOn"] = DateOn;

                    xmlAttribute = xmlDocument.CreateAttribute("SR");
					if ((usedRange.Cells[i, 10] as Range).get_Value(Type.Missing) != null)
					{
						xmlAttribute.Value = (usedRange.Cells[i, 10] as Range).get_Value(Type.Missing).ToString();
					}
					xmlNodeComment.Attributes.Append(xmlAttribute);

                    xmlAttribute = xmlDocument.CreateAttribute("SchmName");
					if ((usedRange.Cells[i, 11] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 11] as Range).get_Value(Type.Missing).ToString()))
					{
						string SchmName = (usedRange.Cells[i, 11] as Range).get_Value(Type.Missing).ToString();
						xmlAttribute.Value = (usedRange.Cells[i, 11] as Range).get_Value(Type.Missing).ToString();
						System.Data.DataTable dataTable = sqlDataCommand.SelectSqlData("vSchm_ObjList", true, "where (typeCodeSocr+'-'+name) = '" + SchmName + "' and deleted = 0 ", null);
						if (dataTable.Rows.Count > 0)
						{
							XmlAttribute xmlAttributeSchmId = xmlDocument.CreateAttribute("SchmId");
							xmlAttributeSchmId.Value = dataTable.Rows[0]["id"].ToString();
							newRD["idSchmObj"] = dataTable.Rows[0]["id"];
							xmlNodeRow.Attributes.Append(xmlAttributeSchmId);
						}
						if ((usedRange.Cells[i, 12] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 12] as Range).get_Value(Type.Missing).ToString()))
						{
							string CellName = (usedRange.Cells[i, 12] as Range).get_Value(Type.Missing).ToString();
							XmlAttribute xmlAttributeCellName = xmlDocument.CreateAttribute("CellName");
							xmlAttributeCellName.Value = CellName;
							xmlNodeRow.Attributes.Append(xmlAttributeCellName);
							if (dataTable.Rows.Count > 0)
							{
								System.Data.DataTable dtVSchm_ObjList = sqlDataCommand.SelectSqlData("vSchm_ObjList", true, string.Concat(new string[]
								{
									"where idParent = ",
									dataTable.Rows[0]["id"].ToString(),
									" and typeCodeId in (672,674,675,676) and deleted = 0 and name = '",
									CellName,
									"'"
								}), null);
								if (dtVSchm_ObjList.Rows.Count > 0)
								{
									XmlAttribute xmlAttributeCellId = xmlDocument.CreateAttribute("CellId");
									xmlAttributeCellId.Value = dtVSchm_ObjList.Rows[0]["Id"].ToString();
									newRD["idSchmObj"] = dtVSchm_ObjList.Rows[0]["Id"];
									xmlNodeRow.Attributes.Append(xmlAttributeCellId);
									int TypeCodeId = Convert.ToInt32(dtVSchm_ObjList.Rows[0]["TypeCodeId"]);
									if (TypeCodeId != 675)
									{
										if (TypeCodeId == 676)
										{
											dataRowHV["PowerV"] = 10;
										}
									}
									else
									{
										dataRowHV["PowerV"] = 6;
									}
								}
							}
						}
					}
					xmlNodeRow.Attributes.Append(xmlAttribute);
					if ((usedRange.Cells[i, 13] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 13] as Range).get_Value(Type.Missing).ToString()))
					{
						xmlAttribute = xmlDocument.CreateAttribute("TypeRZA");
						xmlAttribute.Value = (usedRange.Cells[i, 13] as Range).get_Value(Type.Missing).ToString();
						xmlNodeRow.Attributes.Append(xmlAttribute);
						System.Data.DataTable dataTable3 = sqlDataCommand.SelectSqlData("tr_classifier", true, " where PArentId = 1566 and Name = '" + xmlAttribute.Value + "'", null);
						if (dataTable3.Rows.Count > 0)
						{
							xmlAttribute = xmlDocument.CreateAttribute("TypeRZA");
							xmlAttribute.Value = dataTable3.Rows[0]["id"].ToString();
							dataRowHV["idTypeRZA"] = dataTable3.Rows[0]["id"];
							xmlNodeRow.Attributes.Append(xmlAttribute);
						}
					}
					if ((usedRange.Cells[i, 14] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 14] as Range).get_Value(Type.Missing).ToString()))
					{
						xmlAttribute = xmlDocument.CreateAttribute("col1Name");
						xmlAttribute.Value = (usedRange.Cells[i, 14] as Range).get_Value(Type.Missing).ToString();
						xmlNodeRow.Attributes.Append(xmlAttribute);
						System.Data.DataTable dataTable4 = sqlDataCommand.SelectSqlData("tr_classifier", true, " where PArentId = 1438 and Name like '%" + xmlAttribute.Value + "%'", null);
						if (dataTable4.Rows.Count > 0)
						{
							xmlAttribute = xmlDocument.CreateAttribute("col1");
							xmlAttribute.Value = dataTable4.Rows[0]["id"].ToString();
							dataRowCharacter["col1"] = dataTable4.Rows[0]["id"];
							xmlNodeRow.Attributes.Append(xmlAttribute);
							if ((usedRange.Cells[i, 17] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 17] as Range).get_Value(Type.Missing).ToString()))
							{
								xmlAttribute = xmlDocument.CreateAttribute("col2Name");
								xmlAttribute.Value = (usedRange.Cells[i, 17] as Range).get_Value(Type.Missing).ToString();
								xmlNodeRow.Attributes.Append(xmlAttribute);
								System.Data.DataTable dataTable5 = sqlDataCommand.SelectSqlData("tr_classifier", true, string.Concat(new string[]
								{
									" where PArentId = ",
									dataTable4.Rows[0]["id"].ToString(),
									" and Name like '%",
									xmlAttribute.Value,
									"%'"
								}), null);
								if (dataTable5.Rows.Count > 0)
								{
									xmlAttribute = xmlDocument.CreateAttribute("col2");
									xmlAttribute.Value = dataTable5.Rows[0]["id"].ToString();
									dataRowCharacter["col2"] = dataTable5.Rows[0]["id"];
									xmlNodeRow.Attributes.Append(xmlAttribute);
								}
							}
						}
					}
					if ((usedRange.Cells[i, 15] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 15] as Range).get_Value(Type.Missing).ToString()))
					{
						xmlAttribute = xmlDocument.CreateAttribute("Accessory");
						xmlAttribute.Value = (usedRange.Cells[i, 15] as Range).get_Value(Type.Missing).ToString();
						xmlNodeRow.Attributes.Append(xmlAttribute);
					}
					if ((usedRange.Cells[i, 16] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 16] as Range).get_Value(Type.Missing).ToString()))
					{
						xmlAttribute = xmlDocument.CreateAttribute("Location");
						xmlAttribute.Value = (usedRange.Cells[i, 16] as Range).get_Value(Type.Missing).ToString();
						newRD["DefectLocation"] = xmlAttribute.Value;
						xmlNodeRow.Attributes.Append(xmlAttribute);
					}
					newRD["ComletedWorkText"] = "";
					if ((usedRange.Cells[i, 18] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 18] as Range).get_Value(Type.Missing).ToString()))
					{
						xmlAttribute = xmlDocument.CreateAttribute("Responsible");
						xmlAttribute.Value = (usedRange.Cells[i, 18] as Range).get_Value(Type.Missing).ToString();
						DataRow newRD2 = newRD;
						newRD2["ComletedWorkText"] = newRD2["ComletedWorkText"] + xmlAttribute.Value;
						xmlNodeComment.Attributes.Append(xmlAttribute);
					}
					if ((usedRange.Cells[i, 19] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 19] as Range).get_Value(Type.Missing).ToString()))
					{
						xmlAttribute = xmlDocument.CreateAttribute("Nokwt");
						string Nokwt = (usedRange.Cells[i, 19] as Range).get_Value(Type.Missing).ToString();
						decimal noAdmissionKWT = 0m;
						decimal.TryParse(Nokwt, out noAdmissionKWT);
						xmlAttribute.Value = noAdmissionKWT.ToString();
						dataRowOn["noAdmissionKWT"] = noAdmissionKWT;
						dataRowHV["NoAdmissionKWT"] = noAdmissionKWT;
						xmlNodeComment.Attributes.Append(xmlAttribute);
					}
					if ((usedRange.Cells[i, 22] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 22] as Range).get_Value(Type.Missing).ToString()))
					{
						xmlAttribute = xmlDocument.CreateAttribute("Reason");
						string Reason = (usedRange.Cells[i, 22] as Range).get_Value(Type.Missing).ToString();
						xmlAttribute.Value = Reason;
						DataRow newRD2 = newRD;
						newRD2["ComletedWorkText"] = newRD2["ComletedWorkText"] + "\r\n" + Reason;
						xmlNodeComment.Attributes.Append(xmlAttribute);
					}
					if ((usedRange.Cells[i, 23] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 23] as Range).get_Value(Type.Missing).ToString()))
					{
						xmlAttribute = xmlDocument.CreateAttribute("Comment");
						string Comment = (usedRange.Cells[i, 23] as Range).get_Value(Type.Missing).ToString();
						xmlAttribute.Value = Comment;
						DataRow newRD2 = newRD;
						newRD2["ComletedWorkText"] = newRD2["ComletedWorkText"] + "\r\n" + Comment;
						xmlNodeComment.Attributes.Append(xmlAttribute);
					}
					if ((usedRange.Cells[i, 24] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 24] as Range).get_Value(Type.Missing).ToString()))
					{
						xmlAttribute = xmlDocument.CreateAttribute("CommentX");
						string CommentX = (usedRange.Cells[i, 24] as Range).get_Value(Type.Missing).ToString();
						xmlAttribute.Value = CommentX;
						DataRow newRD2 = newRD;
						newRD2["ComletedWorkText"] = newRD2["ComletedWorkText"] + "\r\n" + CommentX;
						xmlNodeComment.Attributes.Append(xmlAttribute);
					}
					if ((usedRange.Cells[i, 25] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 25] as Range).get_Value(Type.Missing).ToString()))
					{
						xmlAttribute = xmlDocument.CreateAttribute("CommentY");
						string CommentY = (usedRange.Cells[i, 25] as Range).get_Value(Type.Missing).ToString();
						xmlAttribute.Value = CommentY;
						DataRow newRD2 = newRD;
						newRD2["ComletedWorkText"] = newRD2["ComletedWorkText"] + "\r\n" + CommentY;
						xmlNodeComment.Attributes.Append(xmlAttribute);
					}
					if ((usedRange.Cells[i, 26] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 26] as Range).get_Value(Type.Missing).ToString()))
					{
						xmlAttribute = xmlDocument.CreateAttribute("CommentZ");
						string CommentZ = (usedRange.Cells[i, 26] as Range).get_Value(Type.Missing).ToString();
						xmlAttribute.Value = CommentZ;
						DataRow newRD2 = newRD;
						newRD2["ComletedWorkText"] = newRD2["ComletedWorkText"] + "\r\n" + CommentZ;
						xmlNodeComment.Attributes.Append(xmlAttribute);
					}
					if ((usedRange.Cells[i, 27] as Range).get_Value(Type.Missing) != null && !string.IsNullOrEmpty((usedRange.Cells[i, 27] as Range).get_Value(Type.Missing).ToString()))
					{
						xmlAttribute = xmlDocument.CreateAttribute("CommentAA");
						string CommentAA = (usedRange.Cells[i, 27] as Range).get_Value(Type.Missing).ToString();
						xmlAttribute.Value = CommentAA;
						DataRow newRD2 = newRD;
						newRD2["ComletedWorkText"] = newRD2["ComletedWorkText"] + "\r\n" + CommentAA;
						xmlNodeComment.Attributes.Append(xmlAttribute);
					}
					newRD["CommentXml"] = xmlDocument.InnerXml;
					if (newRD["idSchmObj"] != DBNull.Value)
					{
						ElectricModel electricModel = new ElectricModel();
						electricModel.SqlSettings = sqlsettings;
						electricModel.LoadSchema(dateDoc);
						TreeNodeObj treeNodeObj_ = electricModel.PoweringReportForDrawObject(Convert.ToInt32(newRD["idSchmObj"]), true);
						List<int> listSchmObj = new List<int>();

                        LoadOldDamageНV.GetListSchmObj(treeNodeObj_, listSchmObj);
#pragma warning disable CS0436 // Тип конфликтует с импортированным типом
                        System.Data.DataTable dtTransformerSchmObj = LoadOldDamageНV.GetTableTransformerSchmObj(listSchmObj, new StaticFormData { Sqlsettings = sqlsettings, eForm = Me.eForm });//
#pragma warning restore CS0436 // Тип конфликтует с импортированным типом
                        IEnumerable<ElectricObject> source = from obj in electricModel.Objects
						                                    where obj.Id == Convert.ToInt32(newRD["idSchmObj"])
						                                    select obj;

                        List<ElectricObject> listElectricObject = electricModel.PoweringReportForDrawObject(source.First<ElectricObject>(), true, true);
						System.Data.DataTable dtSchmAbnFull = new System.Data.DataTable("vl_schmAbnFull");
						dtSchmAbnFull.Columns.Add("idAbn", typeof(int));
						dtSchmAbnFull.Columns.Add("idAbnObj", typeof(int));
						if (listElectricObject.Count > 0)
						{
							string strIdSchmObj = "";
							foreach (ElectricObject electricObject in listElectricObject)
							{
								if (string.IsNullOrEmpty(strIdSchmObj))
								{
									strIdSchmObj = electricObject.Id.ToString();
								}
								else
								{
									strIdSchmObj = strIdSchmObj + "," + electricObject.Id.ToString();
								}
							}
							sqlDataCommand.SelectSqlData(dtSchmAbnFull, true, " where idSchmObj in (" + strIdSchmObj + ") and abnActive = 1 and objactive = 1  group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj ", new int?(0), false, 0);
						}
						else
						{
							dtSchmAbnFull.Clear();
						}
						dataRowOn["countSchmObj"] = dtTransformerSchmObj.Rows.Count;
						dataRowHV["countSchmObj"] = dtTransformerSchmObj.Rows.Count;
						dataRowHV["countSchmObjOff"] = 0;
						dataRowHV["ConnectedPower"] = dtTransformerSchmObj.Compute("Sum(Power)", "");
						dataRowHV["PowerA"] = dtTransformerSchmObj.Compute("Sum(Load)", "");
						dataRowHV["TransOff"] = LoadOldDamageНV.GetXmlTableTransformerSchmObj(dtTransformerSchmObj).InnerXml;
						dataRowHV["AbnOff"] = CreateReferenceTables.CreateXmlAbnOff(dtSchmAbnFull).InnerXml;
					}
					ds.tJ_Damage.Rows.Add(newRD);
					ds.tJ_DamageCharacter.Rows.Add(dataRowCharacter);
					ds.tJ_DamageHV.Rows.Add(dataRowHV);
					ds.tJ_DamageOn.Rows.Add(dataRowOn);
					SqlDataCommand sqlDataCommand2 = new SqlDataCommand(Me.Sqlsettings);
					int idDamage = sqlDataCommand2.InsertSqlDataOneRow(ds.tJ_Damage);
					if (idDamage > 0)
					{
						ds.tJ_DamageCharacter.Rows[0]["idDamage"] = idDamage;
						ds.tJ_DamageCharacter.Rows[0].EndEdit();
						sqlDataCommand2.InsertSqlData(ds, ds.tJ_DamageCharacter);
						ds.tJ_DamageHV.Rows[0]["idDamage"] = idDamage;
						ds.tJ_DamageHV.Rows[0].EndEdit();
						sqlDataCommand2.InsertSqlData(ds, ds.tJ_DamageHV);
						ds.tJ_DamageOn.Rows[0]["idDamage"] = idDamage;
						ds.tJ_DamageOn.Rows[0].EndEdit();
						sqlDataCommand2.InsertSqlData(ds, ds.tJ_DamageOn);
					}
				}
			}
			catch (Exception ex)
			{
                System.Windows.Forms.MessageBox.Show(ex.Message + num.ToString(), FileName);
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

	internal static string ConvertToDateTime(string strIn)
	{
		double num = 0.0;
		try
		{
			num = double.Parse(strIn);
		}
		catch
		{
		}
		int num2 = (int)Math.Round(num * 1440.0 % 60.0);
		int num3 = (int)(num * 1440.0 / 60.0);
		if (num2 == 60)
		{
			num2 = 0;
			num3++;
		}
		return num3 + ":" + num2;
	}

    /// <summary>
    /// Конвертация таблицы datatable TransformerSchmObj в xml таблицу
    /// </summary>
    /// <returns></returns>
	private static XmlDocument GetXmlTableTransformerSchmObj(System.Data.DataTable TableTransformerSchmObj)
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode xmlNode = xmlDocument.CreateElement("TransOff");
		xmlDocument.AppendChild(xmlNode);
		foreach (DataRow dataRow in TableTransformerSchmObj.Rows)
		{
			//DataRow dataRow = (DataRow)obj;
			XmlNode xmlNode2 = xmlDocument.CreateElement("Row");
			xmlNode.AppendChild(xmlNode2);
			XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("idSub");
			xmlAttribute.Value = dataRow["idSub"].ToString();
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("idTr");
			xmlAttribute.Value = dataRow["idTr"].ToString();
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Power");
			xmlAttribute.Value = dataRow["Power"].ToString();
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Load");
			xmlAttribute.Value = dataRow["Load"].ToString();
			xmlNode2.Attributes.Append(xmlAttribute);
		}
		return xmlDocument;
	}
    /// <summary>
    /// возвращаем список (реестр) объектов от головных
    /// </summary>
	private static void GetListSchmObj(TreeNodeObj treeNodeObj, List<int> listSchmObj)
	{
		if (treeNodeObj.Tag != null && treeNodeObj.Tag is ElectricLine)
		{
			foreach (ElectricRelation electricRelation in ((ElectricLine)treeNodeObj.Tag).Relations)
			{
				foreach (ElectricObject electricObject in electricRelation.ChildObjects)
				{
					if (electricObject is ElectricSwitch && ((ElectricSwitch)electricObject).TypeSwitch == TypeSwitch.TransformerTool && !listSchmObj.Contains(electricObject.Id))
					{
						listSchmObj.Add(electricObject.Id);
					}
				}
			}
		}
		foreach (TreeNodeObj treeNodeObj_ in treeNodeObj.Nodes)
		{
			LoadOldDamageНV.GetListSchmObj(treeNodeObj_, listSchmObj);
		}
	}

#pragma warning disable CS0436 // Тип конфликтует с импортированным типом
    private static System.Data.DataTable GetTableTransformerSchmObj(List<int> listSchmObj, StaticFormData Me)
#pragma warning restore CS0436 // Тип конфликтует с импортированным типом
    {
		System.Data.DataTable dataTable = new System.Data.DataTable();
		dataTable.Columns.Add("idTr", typeof(int));
		dataTable.Columns.Add("TrName", typeof(string));
		dataTable.Columns.Add("idSub", typeof(int));
		dataTable.Columns.Add("Sub", typeof(string));
		dataTable.Columns.Add("Power", typeof(int));
		dataTable.Columns.Add("load", typeof(int));
		dataTable.Clear();
		using (SqlConnection sqlConnection = new SqlConnection(Me.Sqlsettings.GetConnectionString() + ";Connection Timeout=1000"))
		{
			sqlConnection.Open();
			using (SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(Me.eForm.GetType(),"DailyReportN.SqlScripts.GetTransformerSchmObj.sql"), sqlConnection))
			{
				sqlCommand.CommandTimeout = 0;
				System.Data.DataTable dataTable2 = new System.Data.DataTable();
				new SqlDataAdapter(sqlCommand).Fill(dataTable2);
				int PowerFull = 0;
				foreach (int IdSchmObj in listSchmObj)
				{
					DataRow[] array = dataTable2.Select("id = " + IdSchmObj.ToString());
					if (array.Length != 0)
					{
						DataRow dataRow = dataTable.NewRow();
						dataRow["idTR"] = array[0]["id"];
						dataRow["TrNAme"] = array[0]["Наименование"];
						dataRow["idSub"] = array[0]["idSub"];
						dataRow["Sub"] = array[0]["Расположение"];
						if (array[0]["Мощность"] != DBNull.Value && !string.IsNullOrEmpty(array[0]["Мощность"].ToString()))
						{
							dataRow["Power"] = array[0]["Мощность"];
						}
						if (array[0]["Мощность"] != DBNull.Value && !string.IsNullOrEmpty(array[0]["Мощность"].ToString()))
						{
							PowerFull += Convert.ToInt32(array[0]["Мощность"]);
						}
						dataTable.Rows.Add(dataRow);
					}
				}
			}
			using (SqlCommand sqlCommand2 = new SqlCommand("SELECT mat.idbus, mat.[IdObjList],\r\n                        \t(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) \r\n                        \t then max([Ia]) \telse case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) \r\n                        \t\t\t\t\t                                else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) \r\n                        \t\t\t\t\t                                then max([Ic]) end end end) as I\r\n                         FROM [tJ_MeasAmperageTransf] as mat\r\n                               inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n                          where  mat.deleted = 0 and m.[TypeDoc] = 1192\r\n                        \tand ((year(m.[DateD]) = \r\n                        \t\t\t(select case when month(max(dateD)) = 12 then year(max(dateD)) + 1\r\n                        \t\t\t\t\telse year(max(dateD)) end from tj_measurement mes \r\n                        \t\t\tleft join [tJ_MeasAmperageTransf] mt on mt.[idMeasurement] = mes.id\r\n                        \t\t\t where mt.idBus = mat.idBus and mt.deleted = 0 and m.typeDoc = 1192\t\r\n                        \t\t\t and  mt.[Ia] is not null and  mt.[Ib] is not null and  mt.[Ic] is not null)\r\n                                      and month(m.[DateD]) between 1 and 11)\t\r\n                           or (year(m.[DateD]) =(select case when month(max(dateD)) = 12 then year(max(dateD)) + 1\r\n                        \telse year(max(dateD)) end\r\n                        \tfrom tj_measurement mes \r\n                        \tleft join [tJ_MeasAmperageTransf] mt on mt.[idMeasurement] = mes.id\r\n                        \twhere mt.idBus = mat.idBus and mt.deleted = 0 and m.typeDoc = 1192\r\n                        \t and  mt.[Ia] is not null and  mt.[Ib] is not null and  mt.[Ic] is not null)-1 and month(m.[DateD])=12)) \r\n                            and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n                          group by mat.idBus,  mat.[idObjList]", sqlConnection))
			{
				sqlCommand2.CommandTimeout = 0;
				System.Data.DataTable dataTable3 = new System.Data.DataTable();
				new SqlDataAdapter(sqlCommand2).Fill(dataTable3);
				foreach (DataRow dataRow2 in dataTable.Rows)
				{
					DataRow[] array2 = dataTable3.Select("idObjList = " + dataRow2["idTr"].ToString());
					if (array2.Length != 0)
					{
						dataRow2["Load"] = array2[0]["I"];
					}
				}
			}
		}
		return dataTable;
	}

}
