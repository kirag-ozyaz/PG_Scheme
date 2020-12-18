using System;
/// <summary>
/// Тип документа
/// </summary>
namespace ExportToPostGIS.Dokuments
{
    public enum eTypeDocuments
    {
        /// <summary>
        /// нарушение по НН
        /// </summary>
        DamageLV = 1401,
        /// <summary>
        /// нарушение по ВН
        /// </summary>
        DamageHV = 1402,
        /// <summary>
        /// дефект по НН
        /// </summary>
        DefectLV = 1403,
        /// <summary>
        /// дефект по ВН
        /// </summary>
        DefectHV = 1844,
        /// <summary>
        /// акт расследования
        /// </summary>
        ActDetection = 1874,
        /// <summary>
        /// Повреждение УО
        /// </summary>
        DamageSL = 2254,
        /// <summary>
        /// Наряд на работу
        /// </summary>
        Order = 2482,
        /// <summary>
        /// Заявки на ремонт
        /// </summary>
        RequestForRepair = 2488,
        /// <summary>
        /// Заявка на ремонт (производственная лаборатория)
        /// </summary>
        RequestForRepairPL = 2489,
        /// <summary>
        /// Уведомления об отключении абонентов
        /// </summary>
        NotificationOfRepairs = 2490,
        /// <summary>
        /// Раскопки
        /// </summary>
        Excavation = 2491
    }
}