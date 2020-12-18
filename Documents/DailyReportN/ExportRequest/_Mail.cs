using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Xml;
using DataSql;

internal static class _MailRequest
{
	internal static void SendRequest(int idDamage, SQLSettings sqlsettings)
	{
		try
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings);
			DataTable dataTable = sqlDataCommand.SelectSqlData("select idSchmObj, idDivisionApply, isLaboratory from tj_damage where id = " + idDamage.ToString());
			int idDivisionApply = -1;
			bool isLaboratory = false;
			if (dataTable.Rows.Count != 0)
			{
				if (dataTable.Rows[0]["idDivisionApply"] != DBNull.Value)
				{
					idDivisionApply = Convert.ToInt32(dataTable.Rows[0]["idDivisionApply"]);
				}
				if (dataTable.Rows[0]["isLaboratory"] != DBNull.Value)
				{
					isLaboratory = Convert.ToBoolean(dataTable.Rows[0]["isLaboratory"]);
				}
				if (idDivisionApply != -1 || isLaboratory)
				{
					string bodyBeg = "";
					if (dataTable.Rows[0]["idSchmObj"] != DBNull.Value)
					{
						bodyBeg = sqlDataCommand.CallSQLScalarFunction("[dbo].[fn_Schm_GetFullNameObjById]", new string[]
						{
							dataTable.Rows[0]["idSchmObj"].ToString()
						}).ToString();
					}
					DataTable tblSettings = sqlDataCommand.SelectSqlData("tSettings", true, "where module = 'DamageMail'", null);
					if (tblSettings.Rows.Count != 0)
					{
						if (tblSettings.Rows[0]["Settings"] != DBNull.Value)
						{
							XmlDocument xmlDocument = new XmlDocument();
							xmlDocument.LoadXml(tblSettings.Rows[0]["Settings"].ToString());
							XmlNode xmlNode = xmlDocument.SelectSingleNode("DamageMail");
							if (xmlNode != null)
							{
								XmlAttribute xmlAttribute = xmlNode.Attributes["useMail"];
								if (xmlAttribute != null && Convert.ToBoolean(xmlAttribute.Value))
								{
									string host = "";
									string userName = "";
									string password = "";
									string address = "";
									string displayName = "";
									int port = 25;
									XmlNode xmlNode2 = xmlNode.SelectSingleNode("SMTP");
									if (xmlNode2 != null)
									{
										xmlAttribute = xmlNode2.Attributes["Name"];
										if (xmlAttribute != null)
										{
											host = xmlAttribute.Value;
										}
										xmlAttribute = xmlNode2.Attributes["Port"];
										if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
										{
											port = Convert.ToInt32(xmlAttribute.Value);
										}
										xmlAttribute = xmlNode2.Attributes["Login"];
										if (xmlAttribute != null)
										{
											userName = xmlAttribute.Value;
										}
										xmlAttribute = xmlNode2.Attributes["Pwd"];
										if (xmlAttribute != null)
										{
											password = xmlAttribute.Value;
										}
										XmlNode xmlNode3 = xmlNode.SelectSingleNode("Sender");
										if (xmlNode3 != null)
										{
											xmlAttribute = xmlNode3.Attributes["Address"];
											if (xmlAttribute != null)
											{
												address = xmlAttribute.Value;
											}
											xmlAttribute = xmlNode3.Attributes["Name"];
											if (xmlAttribute != null)
											{
												displayName = xmlAttribute.Value;
											}
										}
										DataTable dataTable3 = _MailRequest.CreateTableContact(xmlDocument, sqlsettings);
										string filterExpression = "divId in (";
										if (idDivisionApply != -1)
										{
											filterExpression += idDivisionApply.ToString();
										}
										if (isLaboratory)
										{
											if (idDivisionApply != -1)
											{
												filterExpression += ",-1";
											}
											else
											{
												filterExpression += "-1";
											}
										}
										filterExpression += ")";
										foreach (DataRow dataRow in from row in dataTable3.Select(filterExpression).AsEnumerable<DataRow>()
										                    group row by row["Tag"] into grp
										select grp.First<DataRow>())
										{
											string strTag = dataRow["Tag"].ToString();
											DataTable dataTable4 = sqlDataCommand.SelectSqlData(string.Concat(new string[]
											{
												"select ch.id, isnull(ch.col3, isnull(ch.col2, col1)) as col from tJ_DamageCharacter ch\r\n\t                                                            left join tR_Classifier c on isnull(ch.col3, isnull(ch.col2, col1)) = c.id\r\n                                                             where ch.idDamage = ",
												idDamage.ToString(),
												" and c.Comment like '%",
												strTag,
												"%'"
											}));
											if (dataTable4.Rows.Count != 0)
											{
												foreach (DataRow dataRow2 in dataTable4.Rows)
												{
													int col = -1;
													if (dataRow2["col"] != DBNull.Value)
													{
														col = Convert.ToInt32(dataRow2["col"]);
													}
													string bodyEnd = "";
													DataTable dataTable5 = sqlDataCommand.SelectSqlData("select name from tr_Classifier where id = " + col.ToString());
													if (dataTable5.Rows.Count > 0 && dataTable5.Rows[0]["NAme"] != DBNull.Value)
													{
														bodyEnd = dataTable5.Rows[0]["NAme"].ToString();
													}
													DataRow[] array = dataTable3.Select(filterExpression + " and tag = '" + strTag + "' and contact is not null");
													List<Recipient> listMailAddress = new List<Recipient>();
													foreach (DataRow dataRow3 in array)
													{
														listMailAddress.Add(new Recipient(dataRow3["Contact"].ToString(), dataRow3["FIO"].ToString()));
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
		catch (Exception ex)
		{
            System.Windows.Forms.MessageBox.Show(ex.Message, ex.Source);
		}
	}

	internal static DataTable CreateTableContact(XmlDocument xml, SQLSettings sqlsettings)
	{
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add("tag", typeof(string));
		dataTable.Columns.Add("divName", typeof(string));
		dataTable.Columns.Add("divId", typeof(int));
		dataTable.Columns.Add("FIO", typeof(string));
		dataTable.Columns.Add("idWorker", typeof(int));
		dataTable.Columns.Add("Contact", typeof(string));

        DataTable dtClassifier = new DataTable("tR_Classifier");
		DataColumn dataColumnId = dtClassifier.Columns.Add("id", typeof(int));
		dtClassifier.Columns.Add("name", typeof(string));
		dtClassifier.PrimaryKey = new DataColumn[]
		{
			dataColumnId
		};
		SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlsettings);
		sqlDataCommand.SelectSqlData(dtClassifier, true, "", null, false, 0);

        DataTable dataTableWorker = new DataTable("tR_Worker");
		DataColumn dataColumnIdWorker = dataTableWorker.Columns.Add("id", typeof(int));
		dataTableWorker.Columns.Add("F", typeof(string));
		dataTableWorker.Columns.Add("I", typeof(string));
		dataTableWorker.Columns.Add("O", typeof(string));
		dataTableWorker.Columns.Add("FIO", typeof(string), "F + isnull(' ' + I, '') + isnull(' ' + O, '')");
		dataTableWorker.PrimaryKey = new DataColumn[]
		{
			dataColumnIdWorker
		};
		sqlDataCommand.SelectSqlData(dataTableWorker, true, "", null, false, 0);

		XmlNode xmlNode = xml.SelectSingleNode("DamageMail");
		if (xmlNode != null)
		{
			XmlNode xmlNode2 = xmlNode.SelectSingleNode("Recipients");
			if (xmlNode2 != null)
			{
				foreach (XmlNode xmlNode3 in xmlNode2.SelectNodes("TagName"))
				{
					string TagName = "";
					XmlAttribute xmlAttribute = xmlNode3.Attributes["TagName"];
					if (xmlAttribute != null)
					{
						TagName = xmlAttribute.Value;
					}
					dataTable.Rows.Add(new object[]
					{
						TagName
					});
					foreach (XmlNode xmlNode4 in xmlNode3.SelectNodes("Division"))
					{
						string DivName = "";
						int? DivId = null;
						xmlAttribute = xmlNode4.Attributes["DivId"];
						if (xmlAttribute != null)
						{
							DivId = new int?(Convert.ToInt32(xmlAttribute.Value));
						}
						DataRow dataRow = dtClassifier.Rows.Find(DivId.Value);
						if (dataRow != null)
						{
							DivName = dataRow["name"].ToString();
						}
						else
						{
							xmlAttribute = xmlNode4.Attributes["DivName"];
							if (xmlAttribute != null)
							{
								DivName = xmlAttribute.Value;
							}
						}
						dataTable.Rows.Add(new object[]
						{
							TagName,
							DivName,
							DivId
						});
						foreach (XmlNode xmlNode5 in xmlNode4.SelectNodes("Contact"))
						{
							string FIO = "";
							int? IdWorker = null;
							string Contact = "";
							xmlAttribute = xmlNode5.Attributes["IdWorker"];
							if (xmlAttribute != null)
							{
								IdWorker = new int?(Convert.ToInt32(xmlAttribute.Value));
							}
							dataRow = dataTableWorker.Rows.Find(IdWorker.Value);
							if (dataRow != null)
							{
								FIO = dataRow["fio"].ToString();
							}
							else
							{
								xmlAttribute = xmlNode5.Attributes["FIO"];
								if (xmlAttribute != null)
								{
									FIO = xmlAttribute.Value;
								}
							}
							xmlAttribute = xmlNode5.Attributes["Contact"];
							if (xmlAttribute != null)
							{
								Contact = xmlAttribute.Value;
							}
							dataTable.Rows.Add(new object[]
							{
								TagName,
								DivName,
								DivId,
								FIO,
								IdWorker,
								Contact
							});
						}
					}
				}
			}
		}
		DataView defaultView = dataTable.DefaultView;
		defaultView.Sort = "tag, divname, fio, contact";
		return defaultView.ToTable();
	}
}
