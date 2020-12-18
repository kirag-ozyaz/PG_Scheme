using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// свойства документа аварии
/// </summary>
internal static class VersionDocDamage
{
    /// <summary>
    ///  проверим версию открываемых документов, ранее созданных.
    ///  true то ver.2019
    ///  false то ver. не 2019
    /// </summary>
    internal static bool isNew(DataSql.SQLSettings SqlSettings, int idDoc, DateTime DateDoc = default(DateTime))
    {
        if (idDoc != -1)
        {
            DailyReportN.DataSet.dsDamage.tJ_DamageDataTable tblDamage = new DailyReportN.DataSet.dsDamage.tJ_DamageDataTable();
            LibraryTSQL.SqlDataCommand cTSQL = new LibraryTSQL.SqlDataCommand(SqlSettings);
            cTSQL.SelectSqlData(tblDamage, true, string.Format(" where id = {0}", idDoc));

            int TypeDoc = Convert.ToInt32(tblDamage.Rows[0]["TypeDoc"]);
            switch (TypeDoc)
            {
                case (int)eTypeDocuments.DamageHV:
                case (int)eTypeDocuments.DamageLV:
                    {
                        // если дата документа >=2019 и он сохранен, то новая версия
                        if (DateDoc.Year >= 2019 && idDoc != -1)
                        {
                            return true;
                        }
                        if (tblDamage.Rows.Count > 0 && tblDamage.Rows[0]["CommentXml"] != DBNull.Value)
                        {
                            var CommentXml = System.Xml.Linq.XDocument.Parse(tblDamage.Rows[0]["CommentXml"].ToString());
                            var resAbnOff = CommentXml.Element("Doc").Element("AbnOff").Descendants("Row");
                            // если в какой-либо строке нет атрибуда "codeAbonent", то старый документ
                            // с 2019 года количество колонок больше одной
                            if (resAbnOff.Where(s => s.Attribute("codeAbonent") == null).Count() != 0)
                            {
                                return false;
                            }
                        }
                        break;
                    }
                default:
                    break;
            }
        }
        return true;
    }
}

