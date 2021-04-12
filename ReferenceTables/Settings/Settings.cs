using DataSql;
using Logger;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml;

public class Settings
{
    public SQLSettings SqlSettings
    {
        get
        {
            return _sqlSettings;
        }

        set
        {
            if (value != null)
            {
                _sqlSettings = value;
                if (_param != null)
                {
                    setting = GetConfig();
                }
            }
        }
    }
    /// <summary>
    /// общее название настроек 
    /// похоже на таблицу
    /// </summary>
    public string Parametr {
        get
        {
            return _param;
        }

        set
        {
            if (value != null)
            {
                _param = value;
                if (_sqlSettings != null)
                {
                    setting = GetConfig();
                }
            }
        }
    }

    private string Module = "FTP05";
    private SQLSettings _sqlSettings;
    private string _param;

    private XmlNode setting { get; set; }

    /// <summary>
    /// вернуть таблицу установок
    /// </summary>
    private XmlNode GetConfig()
    {
        XmlNode resultat = null;
        if (Parametr == "" || SqlSettings == null) return resultat;

        using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
        {
            sqlConnection.Open();
            DbDataAdapter dbDataAdapter = new SqlDataAdapter("select [Settings] from tSettings where module = '" + Module + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            dbDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["Settings"] != DBNull.Value)
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(dataTable.Rows[0]["Settings"].ToString());
                XmlNode xmlNode = xmlDocument.SelectSingleNode("ReqForRepairFTP");
                if (xmlNode != null)
                {
                    XmlNode xmlNodeSetting = xmlNode.SelectSingleNode(Parametr);
                    if (xmlNodeSetting != null)
                    {
                        resultat = xmlNodeSetting;
                    }
                }
            }
        }
        return resultat;
    }
    /// <summary>
    /// Вернуть значение из InnerText узла (Nodes)
    /// </summary>
    /// <param name="Attribute"></param>
    /// <param name="typeResult"></param>
    /// <param name="NodeAttributeParent"></param>
    /// <returns></returns>
    public object GetTextNodes(string Attribute, string typeResult = "string", string NodeAttributeParent = "")
    {
        object value = null;
        bool isFlag = false;
        try
        {
            if (typeResult == "bool")
                value = false;
            else if (typeResult == "string")
                value = string.Empty;
            else if (typeResult == "int")
                value = 0;
            else
                value = null;

            if (NodeAttributeParent != "")
            {
                // выбираем из дочерних узлов
                // xmlNodeParent.ChildNodes.Count > 0
                // или можно xmlNodeParent.InnerXml
                XmlNode xmlNodeParent = setting.SelectSingleNode(NodeAttributeParent);
                if (xmlNodeParent != null)
                {
                    value = xmlNodeParent.InnerText;
                    if (value != null)
                    {
                        isFlag = true;
                    }
                }
            }
            else
            {
                // выбираем данные конкретного узла
                // setting.Attributes.Count > 0
                value = setting.InnerText;
                if (value != null)
                {
                    isFlag = true;
                }
            }
            //// Вернем хотя бы текст узла (InnerXML)
            //if (!isFlag)
            //{
            //    value = setting.InnerText.ToString();
            //}
            if (isFlag)
            {
                if (typeResult == "bool")
                    value = Convert.ToBoolean(value);
                else if (typeResult == "string")
                    value = Convert.ToString(value);
                else if (typeResult == "int")
                    value = Convert.ToInt32(value);
                
            }
        }
        catch { }
        return value;
    }
    /// <summary>
    ///  вернуть значение атрибута настроек 
    ///  передачи данных (строковое)
    /// </summary>
    public object GetAttribute(string Attribute, string typeResult = "string", string NodeAttributeParent = "")
    {
        object value = null;
        bool isFlag = false;
        try
        {
            if (typeResult == "bool")
                value = false;
            else if (typeResult == "string")
                value = string.Empty;
            else if (typeResult == "int")
                value = 0;
            else
                value = null;
            XmlAttribute xmlAttribute = null;
            if (NodeAttributeParent != "")
            {
                // выбираем из дочерних узлов
                // xmlNodeParent.ChildNodes.Count > 0
                // или можно xmlNodeParent.InnerXml
                XmlNode xmlNodeParent = setting.SelectSingleNode(NodeAttributeParent);
                if (xmlNodeParent != null)
                {
                    xmlAttribute = xmlNodeParent.Attributes[Attribute];
                    if (xmlAttribute != null)
                    {
                        isFlag = true;
                    }
                }
            }
            else
            {
                // выбираем данные конкретного узла
                // setting.Attributes.Count > 0
                xmlAttribute = setting.Attributes[Attribute];
                if (xmlAttribute != null)
                {
                    isFlag = true;
                }
            }
            if (isFlag)
            {
                if (typeResult == "bool")
                    value = Convert.ToBoolean(xmlAttribute.Value);
                else if (typeResult == "string")
                    value = Convert.ToString(xmlAttribute.Value);
                else if (typeResult == "int")
                    value = Convert.ToInt32(xmlAttribute.Value);
                else
                    value = xmlAttribute.Value;
            }
        }
        catch { }
        return value;
    }

    public DataTable GetAttributeTable(string AttributeParent, string Attribute)
    {
        DataTable dt = new DataTable();
        XmlNode xmlNode = setting.SelectSingleNode(AttributeParent);
        if (xmlNode != null)
        {
            foreach (object obj in xmlNode.SelectNodes(Attribute))
            {
                XmlNode item = (XmlNode)obj;
                // создадим колонки
                if (dt.Columns.Count == 0)
                {
                    foreach (XmlAttribute att in item.Attributes)
                    {
                        if (!dt.Columns.Contains(att.Name))
                        {
                            DataColumn column = new DataColumn();
                            column.ColumnName = att.Name;
                            column.DataType = Type.GetType("System.String");
                            dt.Columns.Add(column);
                        }
                    }
                }
                DataRow row = dt.NewRow();
                foreach (XmlAttribute att in item.Attributes)
                {
                    row[att.Name] = att.Value;
                }
                dt.Rows.Add(row);
            }
        }
        return dt;
    }
}


