﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NotificationOfRepairs.Classes
{
    public class AbonentToNotification
    {
        [XmlRoot(ElementName = "Row")]
        public class Row
        {
            [XmlAttribute(AttributeName = "codeAbonent")]
            public string CodeAbonent { get; set; }
            [XmlAttribute(AttributeName = "idAbn")]
            public string IdAbn { get; set; }
            [XmlAttribute(AttributeName = "nameAbn")]
            public string NameAbn { get; set; }
            [XmlAttribute(AttributeName = "typeAbn")]
            public string TypeAbn { get; set; }
            [XmlAttribute(AttributeName = "idAbnObj")]
            public string IdAbnObj { get; set; }
            [XmlAttribute(AttributeName = "nameObj")]
            public string NameObj { get; set; }
            [XmlAttribute(AttributeName = "CategoryName")]
            public string CategoryName { get; set; }
            [XmlAttribute(AttributeName = "TarifName")]
            public string TarifName { get; set; }
            [XmlAttribute(AttributeName = "Voltage")]
            public string Voltage { get; set; }
            [XmlAttribute(AttributeName = "PowerSet")]
            public string PowerSet { get; set; }
            [XmlAttribute(AttributeName = "countPoint")]
            public string CountPoint { get; set; }
            [XmlAttribute(AttributeName = "CommentODS")]
            public string CommentODS { get; set; }
            [XmlAttribute(AttributeName = "idAbnNet")]
            public string IdAbnNet { get; set; }
            [XmlAttribute(AttributeName = "nameAbnNet")]
            public string NameAbnNet { get; set; }
            [XmlAttribute(AttributeName = "idSchmObj")]
            public string IdSchmObj { get; set; }
        }

        [XmlRoot(ElementName = "CountPoint")]
        public class CountPoint
        {
            [XmlAttribute(AttributeName = "countPointCat1")]
            public string CountPointCat1 { get; set; }
            [XmlAttribute(AttributeName = "countPointCat1Full")]
            public string CountPointCat1Full { get; set; }
            [XmlAttribute(AttributeName = "countPointCat2")]
            public string CountPointCat2 { get; set; }
            [XmlAttribute(AttributeName = "countPointCat2Full")]
            public string CountPointCat2Full { get; set; }
            [XmlAttribute(AttributeName = "countPointCat3")]
            public string CountPointCat3 { get; set; }
            [XmlAttribute(AttributeName = "countPointEE")]
            public string CountPointEE { get; set; }
            [XmlAttribute(AttributeName = "countPointSource")]
            public string CountPointSource { get; set; }
        }

        [XmlRoot(ElementName = "CountPointVoltage")]
        public class CountPointVoltage
        {
            [XmlAttribute(AttributeName = "CountPointVoltageVN")]
            public string CountPointVoltageVN { get; set; }
            [XmlAttribute(AttributeName = "CountPointVoltageSN1")]
            public string CountPointVoltageSN1 { get; set; }
            [XmlAttribute(AttributeName = "CountPointVoltageSN2")]
            public string CountPointVoltageSN2 { get; set; }
            [XmlAttribute(AttributeName = "CountPointVoltageNN")]
            public string CountPointVoltageNN { get; set; }
        }

        [XmlRoot(ElementName = "CountAbnObj")]
        public class CountAbnObj
        {
            [XmlAttribute(AttributeName = "countAbnObjCat1")]
            public string CountAbnObjCat1 { get; set; }
            [XmlAttribute(AttributeName = "countAbnObjCat1Full")]
            public string CountAbnObjCat1Full { get; set; }
            [XmlAttribute(AttributeName = "countAbnObjCat2")]
            public string CountAbnObjCat2 { get; set; }
            [XmlAttribute(AttributeName = "countAbnObjCat2Full")]
            public string CountAbnObjCat2Full { get; set; }
            [XmlAttribute(AttributeName = "countAbnObjCat3")]
            public string CountAbnObjCat3 { get; set; }
            [XmlAttribute(AttributeName = "countAbnObjEE")]
            public string CountAbnObjEE { get; set; }
            [XmlAttribute(AttributeName = "countAbnObjSource")]
            public string CountAbnObjSource { get; set; }
            [XmlAttribute(AttributeName = "countAbnObj150")]
            public string CountAbnObj150 { get; set; }
            [XmlAttribute(AttributeName = "countAbnObj150670")]
            public string CountAbnObj150670 { get; set; }
            [XmlAttribute(AttributeName = "countAbnObj670")]
            public string CountAbnObj670 { get; set; }
        }

        [XmlRoot(ElementName = "AbnOff")]
        public class AbnOff
        {
            [XmlElement(ElementName = "Row")]
            public List<Row> Row { get; set; }
            [XmlElement(ElementName = "CountPoint")]
            public CountPoint CountPoint { get; set; }
            [XmlElement(ElementName = "CountPointVoltage")]
            public CountPointVoltage CountPointVoltage { get; set; }
            [XmlElement(ElementName = "CountAbnObj")]
            public CountAbnObj CountAbnObj { get; set; }
        }

        [XmlRoot(ElementName = "Doc")]
        public class Doc
        {
            [XmlElement(ElementName = "AbnOff")]
            public AbnOff AbnOff { get; set; }
        }

    }
}
