using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;
//using DailyReportN.DataSet;
using DataSql;
using SchemeModel;
using Logger;

/// <summary>
/// Создание справочных таблиц (libr)
/// </summary>
namespace Reference
{
    public static class Tables
    {
        public static SQLSettings sqlsettings { get; set; }
        /// <summary>
        /// статусы отправки данных в минэнерго
        /// </summary>
        public static string getTextSendSiteME(object e)
        {
            switch (Convert.ToInt32(e))
            {
                case 1:
                    return "Готово к отправке";
                case 2:
                    return "Отменить отправку";
                case 3:
                    return "Отправлено";
                case 4:
                    return "Готова корректировка";
                case 5:
                    return "Ошибка отправки";
                case 6:
                    return "Отправлена корректировка";
                case 10:
                    return "Пустые настройки отправки";
                case 7:
                    return "Запрет отправки данных";
                case 11:
                    return "Пустой список абонентов!";
                case 12:
                    return "Некоррректный список повреждений!";
                case 24:
                    return "Ошибка авторизации";
                default:
                    return "Неправильный тип данных";
            }
        }
        public static string getTextSendSiteME(int Value, SQLSettings sqlsettings)
        {
            DataTable dt = getTextSendSiteME(sqlsettings);
            string resultat = dt.Select("value = " + Value)[0]["name"].ToString(); 
            return resultat;
        }

        //      SELECT*
        //FROM[GES].[dbo].[tR_Classifier]
        //      where[ParentKey] like '%;ReportDaily;%'
        //and isgroup = 1 and(LEN(REPLACE([ParentKey], ';', '**'))-LEN([ParentKey])) = 3
        //order by name

        public static DataTable getTextSendSiteME(SQLSettings sqlsettings)
        {
            DataTable dataTable = Reference.Tables.TableClassifier(null);
            using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString()))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("select id, name, value from tR_Classifier  where  parentKey = ';ReportDaily;StatusSend;' and isGRoup = 0 and deleted  = 0", sqlConnection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    sqlDataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                return dataTable;
            }
        }
        /// <summary>
        /// вернуть тип подстанции
        /// </summary>
        public static string GetTypeSubstation(SchemeModel.eTypeRectangleTool typesub)
        {
            switch (typesub)
            {
                case eTypeRectangleTool.TP:
                    return "ТП";
                case eTypeRectangleTool.RP:
                    return "РП";
                default:
                    return "ПС";
            }
        }
        public static string GetTypeSubstation(SchemeModelN.eTypeRectangleTool typesub)
        {
            switch (typesub)
            {
                case SchemeModelN.eTypeRectangleTool.TP:
                    return "ТП";
                case SchemeModelN.eTypeRectangleTool.RP:
                    return "РП";
                default:
                    return "ПС";
            }
        }
        /// <summary>
        /// вернуть напряжение
        /// me = true - формат напряжения для минэнерго
        /// </summary>
        public static string GetVoltageObject(eTypeShinaTool TypeBus, bool me = true)
        {
            switch (TypeBus)
            {
                case eTypeShinaTool.Shina_04:
                    return me ? "0.38" : "0,4";
                case eTypeShinaTool.Shina_023:
                    return me ? "0.22" : "0,23";
                case eTypeShinaTool.None:
                    return "0";
                case eTypeShinaTool.Shina_10:
                    return me ? "10 (10.5)" : "10";
                case eTypeShinaTool.Shina_6:
                    return me ? "6 (6.3)" : "6";
                default:
                    return TypeBus.ToString().Replace("Shina_", "");
            }
        }
        public static string GetVoltageObject(SchemeModelN.eTypeShinaTool TypeBus, bool me = true)
        {
            switch (TypeBus)
            {
                case SchemeModelN.eTypeShinaTool.Shina_04:
                    return me ? "0.38" : "0,4";
                case SchemeModelN.eTypeShinaTool.Shina_023:
                    return me ? "0.22" : "0,23";
                case SchemeModelN.eTypeShinaTool.None:
                    return "0";
                case SchemeModelN.eTypeShinaTool.Shina_10:
                    return me ? "10 (10.5)" : "10";
                case SchemeModelN.eTypeShinaTool.Shina_6:
                    return me ? "6 (6.3)" : "6";
                default:
                    return TypeBus.ToString().Replace("Shina_", "");
            }
        }

        public static DataTable CreateTableKladrKladrStreet()
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
                        "namefull",
                        typeof(string),
                        "name + ' ' + socr"
                    },
                    {
                        "index",
                        typeof(string)
                    }
                }
            };
        }
        public static DataTable CreateTableKladrObj()
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
                        "ParentId",
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
                        "namefull",
                        typeof(string),
                        "name + ' ' + socr"
                    },
                    {
                        "primarykey",
                        typeof(string)
                    }
                }
            };
        }
        public static DataTable TableClassifier()
        {
            return new DataTable("tR_Classifier")
            {
                Columns =
            {
                {
                    "id",
                    typeof(int)
                },
                {
                    "name",
                    typeof(string)
                }
            }
            };
        }
        public static DataTable TableClassifier(object sender)
        {
            return new DataTable("tR_Classifier")
            {
                Columns =
                {
                    { "id",typeof(int) },
                    { "name", typeof(string)},
                    { "socrname", typeof(string)},
                    { "comment", typeof(string)},
                    { "ParentKey", typeof(string)},
                    { "value", typeof(decimal)},
                    { "nameComment", Type.GetType("System.String"),"name + ' ' + comment" }
                }
            };
        }
        public static DataTable CreateTableAbnType()
        {
            return new DataTable("vAbnType")
            {
                Columns =
            {
                {
                    "idAbn",
                    typeof(int)
                },
                {
                    "Name",
                    typeof(string)
                }
            }
            };
        }
        /// <summary>
        /// новое заполнение списка абонентов с кладром
        /// </summary>
        public static void LoadTableSсhmAbnFullKladr(DataTable dt, SQLSettings sqlsettings, List<ElectricObject> listElectricObj, DateTime dateTime, bool isDataTableClear = true)
        {
            if (listElectricObj != null && listElectricObj.Count != 0)
            {
                string strWhereIN = "";
                foreach (ElectricObject electricObject in listElectricObj)
                {
                    if (string.IsNullOrEmpty(strWhereIN))
                    {
                        strWhereIN = electricObject.Id.ToString();
                    }
                    else
                    {
                        strWhereIN = strWhereIN + "," + electricObject.Id.ToString();
                    }
                }
                string strSelect = "select ";
                string strColumnSpec = ",countpoint,kladrobjid,idstreet";
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    //if (dataColumn.ColumnName.ToLower() != "countpoint")
                    //{
                    //    strSelect = strSelect + "[" + dataColumn.ColumnName + "], ";
                    //}
                    if (strColumnSpec.Contains(dataColumn.ColumnName.ToLower()) == false)
                    {
                        strSelect = strSelect + "[" + dataColumn.ColumnName + "], ";
                    }

                }
                strSelect += string.Format("(select count(id) from tPoint where idAbnObj = l.idAbnObj \r\n                                                    and dateBegin <= '{0}' \r\n                                                    and (dateEnd >= '{0}' or dateEnd is null)) as countPoint ", dateTime.ToString("yyyyMMdd"));
                strSelect += ",o.id as KladrObjId, l.id as idStreet";
                strSelect = strSelect + " from " + dt.TableName + " l ";
                strSelect += " left join tr_kladrStreet s on l.id = s.id";
                strSelect += " left join tr_kladrObj o on o.id = s.kladrobjid";
                strSelect = strSelect + " where idSchmObj in (" + strWhereIN + ") and abnActive = 1 and objactive = 1 ";
                //strSelect = strSelect + " and RealAbonent = 1 ";
                strSelect += " group by ";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    //if (dt.Columns[i].ColumnName.ToLower() != "countpoint")
                    if (strColumnSpec.Contains(dt.Columns[i].ColumnName.ToLower()) == false)
                    {
                        if (i == 0)
                        {
                            strSelect = strSelect + "[" + dt.Columns[i].ColumnName + "]";
                        }
                        else
                        {
                            strSelect = strSelect + ",[" + dt.Columns[i].ColumnName + "]";
                        }
                    }
                }
                strSelect += ",o.id,l.id";
                using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString()))
                {
                    if (isDataTableClear) dt.Clear();
                    sqlConnection.Open();
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSelect, sqlConnection))
                    {
                        sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                        sqlDataAdapter.Fill(dt);
                        // надо количество точек (countpoint) равномерно размазать
                        // создадим сгруппированную таблицу по количеству точек поставки
                        var dt1 = dt.AsEnumerable().OrderBy(r => r["idAbn"]).ThenBy(r => r["idAbnObj"]).CopyToDataTable();
                        var resGroupCountPoint = dt1.AsEnumerable().GroupBy(e => new
                        {
                            idAbn = e["idAbn"],
                            idAbnObj = e["idAbnObj"],
                            countPoint = e["countPoint"],
                        }
                        ).Select
                        (g => new
                        {
                            idAbn = g.Key.idAbn,
                            idAbnObj = g.Key.idAbnObj,
                            countPoint = g.Key.countPoint,
                            countIdSchmObj = g.Count()
                        }
                        ).OrderBy(r => r.idAbn).ThenBy(r => r.idAbnObj);

                        int? idAbn = null;
                        int? idAbnObj = null;
                        int? countPoint = 0;
                        int? countIdSchmObj = 0;
                        decimal powerSet = 0;

                        dt.Clear();
                        foreach (DataRow row in dt1.Rows)
                        {
                            if (countIdSchmObj == 0)
                            {
                                idAbn = (int)row["idAbn"];
                                idAbnObj = (int)row["idAbnObj"];
                                var res = resGroupCountPoint.Where(r => (int)r.idAbn == idAbn && (int)r.idAbnObj == idAbnObj).Select(r => r.countIdSchmObj).First();
                                countPoint = (int)row["countPoint"];
                                powerSet = (decimal)row["PowerSet"];
                                countIdSchmObj = (int)res;
                            }
                            row["countPoint"] = countPoint != 0 ? 1 : 0;
                            row["PowerSet"] = countPoint != 0 ? Math.Round((decimal)(powerSet / countPoint), 2) : 0;
                            powerSet = countPoint != 0 ? powerSet - Math.Round((decimal)(powerSet / countPoint), 2) : 0;
                            countPoint = countPoint != 0 ? countPoint - 1 : 0;

                            countIdSchmObj = countIdSchmObj - 1;

                            if (countIdSchmObj == 0 && countPoint > 0)
                            {
                                row["countPoint"] = (int)row["countPoint"] + countPoint;
                                row["PowerSet"] = (decimal)row["PowerSet"] + powerSet;
                            }
                            dt.ImportRow(row);
                        }
                    }
                }
                return;
            }
            if (isDataTableClear) dt.Clear();
        }
        /// <summary>
        /// заполнение/загрузка  списка абонентов с кладром из готового документа
        /// </summary>
        public static void LoadTableDamageAbnFullKladr(DataTable dtIN, DataTable dtOUT, SQLSettings sqlsettings, string ColumnDateDoc = "DateDoc")
        {
            dtOUT.Clear();
            if (dtIN.Rows.Count > 0 && dtIN.Rows[0]["CommentXml"] != DBNull.Value)
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(dtIN.Rows[0]["CommentXml"].ToString());
                    XmlNode xmlNode = xmlDocument.SelectSingleNode("Doc");
                    if (xmlNode != null)
                    {
                        XmlNode xmlNode2 = xmlNode.SelectSingleNode("AbnOff");
                        if (xmlNode2 != null)
                        {
                            List<string> listAbnObj = new List<string>();
                            List<string> listSchmObj = new List<string>();
                            foreach (object obj in xmlNode2.SelectNodes("Row"))
                            {
                                XmlAttribute xmlAttribute = ((XmlNode)obj).Attributes["idAbnObj"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    listAbnObj.Add(xmlAttribute.Value);
                                }
                                XmlAttribute xmlAttributeSchmObj = ((XmlNode)obj).Attributes["idSchmObj"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttributeSchmObj.Value))
                                {
                                    listSchmObj.Add(xmlAttributeSchmObj.Value);
                                }
                            }
                            if (listAbnObj.Count > 0)
                            {

                                DateTime dateTime = DateTime.Now;
                                if (dtIN.Rows[0][ColumnDateDoc] != DBNull.Value)
                                {
                                    dateTime = Convert.ToDateTime(dtIN.Rows[0][ColumnDateDoc]);
                                }
                                string strSelect = "select ";
                                string strColumnSpec = ",countpoint,kladrobjid,idstreet,";
                                foreach (DataColumn dataColumn in dtOUT.Columns)
                                {
   
                                    if (strColumnSpec.Contains(dataColumn.ColumnName.ToLower()) == false)
                                    {
                                        strSelect = strSelect + "[" + dataColumn.ColumnName + "], ";
                                    }
                                }

                                strSelect += string.Format("(select count(id) from tPoint where idAbnObj = l.idAbnObj \r\n                                                    and dateBegin <= '{0}' \r\n                                                    and (dateEnd >= '{0}' or dateEnd is null)) as countPoint ", dateTime.ToString("yyyyMMdd"));
                                strSelect += ",o.id as KladrObjId, l.id as idStreet";
                                strSelect = strSelect + " from " + dtOUT.TableName + " l ";
                                strSelect += " left join tr_kladrStreet s on l.id = s.id";
                                strSelect += " left join tr_kladrObj o on o.id = s.kladrobjid";
                                strSelect = strSelect + " where idAbnObj in (" + string.Join(",", listAbnObj.ToArray()) + ")" +
                                        //" and idSchmObj in (" + strWhereObjects + ")" +
                                        " and idSchmObj in (" + string.Join(",", listSchmObj.ToArray()) + ")" +
                                        " and abnActive = 1 and objactive = 1 ";
                            //    strSelect = strSelect + " and RealAbonent = 1 ";
                                strSelect += " group by ";

                                for (int i = 0; i < dtOUT.Columns.Count; i++)
                                {
    
                                    if (strColumnSpec.Contains(dtOUT.Columns[i].ColumnName.ToLower()) == false)
                                    {
                                        if (i == 0)
                                        {
                                            strSelect = strSelect + "[" + dtOUT.Columns[i].ColumnName + "]";
                                        }
                                        else
                                        {
                                            strSelect = strSelect + ",[" + dtOUT.Columns[i].ColumnName + "]";
                                        }
                                    }
                                }
                                strSelect += ",o.id,l.id";
                                using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString()))
                                {
                                    dtOUT.Clear();
                                    sqlConnection.Open();
                                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSelect, sqlConnection))
                                    {
                                        sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                                        sqlDataAdapter.Fill(dtOUT);
                                        // надо количество точек (countpoint) равномерно размазать
                                        // создадим сгруппированную таблицу по количеству точек поставки
                                        var dtOUT1 = dtOUT.AsEnumerable().OrderBy(r => r["idAbn"]).ThenBy(r => r["idAbnObj"]).CopyToDataTable();
                                        var resGroupCountPoint = dtOUT1.AsEnumerable().GroupBy(e => new
                                        {
                                            idAbn = e["idAbn"],
                                            idAbnObj = e["idAbnObj"],
                                            countPoint = e["countPoint"],
                                        }
                                        ).Select
                                        (g => new
                                        {
                                            idAbn = g.Key.idAbn,
                                            idAbnObj = g.Key.idAbnObj,
                                            countPoint = g.Key.countPoint,
                                            countIdSchmObj = g.Count()
                                        }
                                        ).OrderBy(r => r.idAbn).ThenBy(r => r.idAbnObj);

                                        int? idAbn = null;
                                        int? idAbnObj = null;
                                        int? countPoint = 0;
                                        int? countIdSchmObj = 0;
                                        decimal powerSet = 0;

                                        dtOUT.Clear();
                                        foreach (DataRow row in dtOUT1.Rows)
                                        {
                                            if (countIdSchmObj == 0)
                                            {
                                                idAbn = (int)row["idAbn"];
                                                idAbnObj = (int)row["idAbnObj"];
                                                var res = resGroupCountPoint.Where(r => (int)r.idAbn == idAbn && (int)r.idAbnObj == idAbnObj).Select(r => r.countIdSchmObj).First();
                                                countPoint = (int)row["countPoint"];
                                                powerSet = (decimal)row["PowerSet"];
                                                countIdSchmObj = (int)res;
                                            }
                                            row["countPoint"] = countPoint != 0 ? 1 : 0;
                                            row["PowerSet"] = countPoint != 0 ? Math.Round((decimal)(powerSet / countPoint), 2) : 0;
                                            powerSet = countPoint != 0 ? powerSet - Math.Round((decimal)(powerSet / countPoint), 2) : 0;
                                            countPoint = countPoint != 0 ? countPoint - 1 : 0;

                                            countIdSchmObj = countIdSchmObj - 1;

                                            if (countIdSchmObj == 0 && countPoint > 0)
                                            {
                                                row["countPoint"] = (int)row["countPoint"] + countPoint;
                                                row["PowerSet"] = (decimal)row["PowerSet"] + powerSet;
                                            }
                                            dtOUT.ImportRow(row);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
        }
        /// <summary>
        /// заполнение списка абонентов без кладром из готового документа
        /// </summary>
        public static void LoadTableDamageAbnFull2(DataTable dtIN, DataTable dtOUT, SQLSettings sqlsettings, string ColumnDateDoc = "DateDoc")
        {
            dtOUT.Clear();
            if (dtIN.Rows.Count > 0 && dtIN.Rows[0]["CommentXml"] != DBNull.Value)
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(dtIN.Rows[0]["CommentXml"].ToString());
                    XmlNode xmlNode = xmlDocument.SelectSingleNode("Doc");
                    if (xmlNode != null)
                    {
                        XmlNode xmlNode2 = xmlNode.SelectSingleNode("AbnOff");
                        if (xmlNode2 != null)
                        {
                            List<string> list = new List<string>();
                            foreach (object obj in xmlNode2.SelectNodes("Row"))
                            {
                                XmlAttribute xmlAttribute = ((XmlNode)obj).Attributes["idAbnObj"];
                                if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
                                {
                                    list.Add(xmlAttribute.Value);
                                }
                            }
                            if (list.Count > 0)
                            {
                                DateTime dateTime = DateTime.Now;
                                if (dtIN.Rows[0][ColumnDateDoc] != DBNull.Value)
                                {
                                    dateTime = Convert.ToDateTime(dtIN.Rows[0][ColumnDateDoc]);
                                }
                                string strSelect = "select ";
                                foreach (DataColumn dataColumn in dtOUT.Columns)
                                {
                                    if (dataColumn.ColumnName.ToLower() != "countpoint")
                                    {
                                        strSelect = strSelect + "[" + dataColumn.ColumnName + "], ";
                                    }
                                }
                                strSelect += string.Format("(select count(id) from tPoint where idAbnObj = vl_SChmAbnFull.idAbnObj \r\n                                                    and dateBegin <= '{0}' \r\n                                                    and (dateEnd >= '{0}' or dateEnd is null)) as countPoint ", dateTime.ToString("yyyyMMdd"));
                                strSelect = strSelect + " from " + dtOUT.TableName;
                                strSelect = strSelect + " where idAbnObj in (" + string.Join(",", list.ToArray()) + ") and abnActive = 1 and objactive = 1 ";
                             //   strSelect = strSelect + " and RealAbonent = 1 ";
                                strSelect += " group by ";
                                for (int i = 0; i < dtOUT.Columns.Count; i++)
                                {
                                    if (dtOUT.Columns[i].ColumnName.ToLower() != "countpoint")
                                    {
                                        if (i == 0)
                                        {
                                            strSelect = strSelect + "[" + dtOUT.Columns[i].ColumnName + "]";
                                        }
                                        else
                                        {
                                            strSelect = strSelect + ",[" + dtOUT.Columns[i].ColumnName + "]";
                                        }
                                    }
                                }
                                using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString()))
                                {
                                    dtOUT.Clear();
                                    sqlConnection.Open();
                                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSelect, sqlConnection))
                                    {
                                        sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                                        sqlDataAdapter.Fill(dtOUT);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
            }
        }

        public static void LoadTableSChmAbnFull(DataTable dt, SQLSettings sqlsettings, List<ElectricObject> listElectricObj, DateTime dateTime)
        {
            if (listElectricObj != null && listElectricObj.Count != 0)
            {
                string strWhereIN = "";
                foreach (ElectricObject electricObject in listElectricObj)
                {
                    if (string.IsNullOrEmpty(strWhereIN))
                    {
                        strWhereIN = electricObject.Id.ToString();
                    }
                    else
                    {
                        strWhereIN = strWhereIN + "," + electricObject.Id.ToString();
                    }
                }
                string strSelect = "select ";
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    if (dataColumn.ColumnName.ToLower() != "countpoint")
                    {
                        strSelect = strSelect + "[" + dataColumn.ColumnName + "], ";
                    }
                }
                strSelect += string.Format("(select count(id) from tPoint where idAbnObj = l.idAbnObj \r\n                                                    and dateBegin <= '{0}' \r\n                                                    and (dateEnd >= '{0}' or dateEnd is null)) as countPoint ", dateTime.ToString("yyyyMMdd"));
                strSelect = strSelect + " from " + dt.TableName + " l";
                strSelect = strSelect + " where idSchmObj in (" + strWhereIN + ") and abnActive = 1 and objactive = 1 ";
               // strSelect = strSelect + " and RealAbonent = 1 ";
                strSelect += " group by ";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (dt.Columns[i].ColumnName.ToLower() != "countpoint")
                    {
                        if (i == 0)
                        {
                            strSelect = strSelect + "[" + dt.Columns[i].ColumnName + "]";
                        }
                        else
                        {
                            strSelect = strSelect + ",[" + dt.Columns[i].ColumnName + "]";
                        }
                    }
                }
                using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString()))
                {
                    dt.Clear();
                    sqlConnection.Open();
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSelect, sqlConnection))
                    {
                        sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                        sqlDataAdapter.Fill(dt);
                    }
                }
                return;
            }
            dt.Clear();
        }

        public static void LoadTableSChmAbnFull_2019(DataTable dt, SQLSettings sqlsettings, List<ElectricObject> listElectricObj, DateTime dateTime, bool isDataTableClear = true)
        {
            if (listElectricObj != null && listElectricObj.Count != 0)
            {
                string strWhereIN = "";
                foreach (ElectricObject electricObject in listElectricObj)
                {
                    if (string.IsNullOrEmpty(strWhereIN))
                    {
                        strWhereIN = electricObject.Id.ToString();
                    }
                    else
                    {
                        strWhereIN = strWhereIN + "," + electricObject.Id.ToString();
                    }
                }
                using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString() + ";Connection Timeout=1000"))
                {
                    try
                    {
                        if (isDataTableClear) dt.Clear();
                        SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(typeof(Tables).Assembly, "References.vL_SchmAbnFull_2019.sql") + " \r\n\r\n and abn2.idSchmObj in (" + strWhereIN + ")", sqlConnection);
                        sqlCommand.Parameters.Add("dt", SqlDbType.DateTime).Value = dateTime;
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                        sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                        sqlDataAdapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                }
                return;
            }
            if (isDataTableClear) dt.Clear();
        }
        public static void LoadTableSChmAbnFull_2019(DataTable dt, SQLSettings sqlsettings, List<SchemeModelN.ElectricObject> listElectricObj, DateTime dateTime, bool isDataTableClear = true)
        {
            if (listElectricObj != null && listElectricObj.Count != 0)
            {
                string strWhereIN = "";
                foreach (var electricObject in listElectricObj)
                {
                    if (string.IsNullOrEmpty(strWhereIN))
                    {
                        strWhereIN = electricObject.Id.ToString();
                    }
                    else
                    {
                        strWhereIN = strWhereIN + "," + electricObject.Id.ToString();
                    }
                }
                using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString() + ";Connection Timeout=1000"))
                {
                    try
                    {
                        if (isDataTableClear) dt.Clear();
                        SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(typeof(Tables).Assembly, "References.vL_SchmAbnFull_2019.sql") + " \r\n\r\n and abn2.idSchmObj in (" + strWhereIN + ")", sqlConnection);
                        sqlCommand.Parameters.Add("dt", SqlDbType.DateTime).Value = dateTime;
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                        sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                        sqlDataAdapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source);
                    }
                }
                return;
            }
            if (isDataTableClear) dt.Clear();
        }
        /// <summary>
        /// Получение списка абонентов (по договорам и начислениям)
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="sqlsettings"></param>
        /// <param name="dateTime"></param>
        /// <param name="isDataTableClear">очистка данных в результирующей таблице</param>
        /// <param name="strWhereIN"> параметр в sql запросе where</param>
        /// <param name="showMessageBox">статус регистрации события в логе или выпадающем сообщении</param>
        public static void LoadTableSChmAbnFull_2019(DataTable dt, SQLSettings sqlsettings,  DateTime dateTime, bool isDataTableClear = true, string strWhereIN = "", bool showMessageBox = true)
        {
            if (strWhereIN != "") strWhereIN = " " + strWhereIN;
            using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    if (isDataTableClear) dt.Clear();
                    SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(typeof(Tables).Assembly, "References.vL_SchmAbnFull_2019.sql") + " " + strWhereIN, sqlConnection);
                    sqlCommand.Parameters.Add("dt", SqlDbType.DateTime).Value = dateTime;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    sqlDataAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    if (showMessageBox)
                        MessageBox.Show(ex.Message, ex.Source);
                    else
                        Log.Write(LogLevel.Error, "ReferenceTables", "CreateReferenceTables", "LoadTableSChmAbnFull_2019", ex.Message, null);
                }
            }
            return;
        }
        /// <summary>
        /// Получение списка привязок объектов абонентов без ограничения по периоду возникговения и отборов
        /// </summary>
        public static void LoadTableSChmAbnFullNoTime(DataTable dt, SQLSettings sqlsettings, DateTime dateTime, bool isDataTableClear = true, string listIdAbnObj = null, string strWhereIN = "order by idAbnObj", bool showMessageBox = true)
        {
            if (strWhereIN != "") strWhereIN = " " + strWhereIN;
            using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    if (isDataTableClear) dt.Clear();
                    SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(typeof(Tables).Assembly, "References.vL_SchmAbnFullNoTime.sql") + " " + strWhereIN, sqlConnection);
                    sqlCommand.Parameters.Add("dt", SqlDbType.DateTime).Value = dateTime;
                    sqlCommand.Parameters.Add("listIdAbnObj", SqlDbType.VarChar).Value = listIdAbnObj;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    sqlDataAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    if (showMessageBox)
                        MessageBox.Show(ex.Message, ex.Source);
                    else
                        Log.Write(LogLevel.Error, "ReferenceTables", "CreateReferenceTables", "LoadTableSChmAbnFull_2019", ex.Message, null);
                }
            }
            return;
        }
        /// <summary>
        /// Загрузка данных по запросу (sql)
        /// </summary>
        /// <param name="dt">Куда грузим - назначение</param>
        /// <param name="sqlsettings">Параметры соединения</param>
        /// <param name="isDataTableClear">очистка таблицы назначения</param>
        /// <param name="strWhereIN">where - условие</param>
        /// <param name="showMessageBox">сообщение об ошибке в выпадающей форме или в лог</param>
        /// <param name="Resurs"> сам ресурс (имя dll где ресурс. сам ресурс)</param>
        public static  bool  LoadTable(DataTable dt, SQLSettings sqlsettings, bool isDataTableClear = true, string strWhereIN = "", bool showMessageBox = true, string Resurs = "")
        {
            if (Resurs == "")
            {
                if (showMessageBox)
                    MessageBox.Show("Не заполнено поле Resurs", "Ошибка");
                else
                    Log.Write(LogLevel.Error, "ReferenceTables", "CreateReferenceTables", "LoadTable", "Не запоолнено поле Resurs", null);
                return false;
            }
            Resurs = "References." + Resurs;
            if (strWhereIN != "") strWhereIN = " " + strWhereIN;
            //if (strWhereIN.Trim().IndexOf("where",0) != 0) strWhereIN = " where " + strWhereIN;
            using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    if (isDataTableClear) dt.Clear();
                    SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(typeof(Tables).Assembly, Resurs) + " " + strWhereIN, sqlConnection);
                    //sqlCommand.Parameters.Add("dt", SqlDbType.DateTime).Value = dateTime;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    sqlDataAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    if (showMessageBox)
                        MessageBox.Show(ex.Message, ex.Source);
                    else
                        Log.Write(LogLevel.Error, "ReferenceTables", "CreateReferenceTables", "LoadTable", ex.Message, null);
                    return false;
                }
            }
            return true;
        }

    }
}