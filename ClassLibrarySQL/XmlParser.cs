using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Library
{
    /// <summary>
    /// Convert List<XElement> to DataTable
    /// Convert XElement to DataTable 
    /// </summary>
    public static  class XmlParser
    {
        public static DataTable XElementToDataTable(this XElement element)
        {
            DataSet ds = new DataSet();
            string rawXml = element.ToString();
            ds.ReadXml(new StringReader(rawXml));
            return ds.Tables[0];
        }
        public static DataTable XElementToDataTable(this IEnumerable<XElement> elements)
        {
            return XElementToDataTable(new XElement("Root", elements));
        }
     }
    /*   Usage:

    protected void Page_Load(object sender, EventArgs e) 
    {
        string xmlFile = Server.MapPath("~/Data.xml");
        XDocument document = XDocument.Load(xmlFile);
        var booksQuery = from b in document.Elements("NewDataSet").Elements("Table")
                          select b;

        DataTable table = booksQuery.ToDataTable();
        GridView1.DataSource = table;
        GridView1.DataBind();
    }     
    */

}
