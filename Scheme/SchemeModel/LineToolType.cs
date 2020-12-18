using System;
using System.ComponentModel;
using System.Reflection;

namespace SchemeModelN
{
    public enum LineToolType
    {
        /// <summary>
        /// ВЛ (воздушная линии)
        /// </summary>
        [Description("ВЛ")]
        AirLine = 547,
        /// <summary>
        /// ВЛЗ
        /// </summary>
        [Description("ВЛЗ")]
        AirLineProtected = 983,
        /// <summary>
        /// КЛ (кабельная лини)
        /// </summary>
        [Description("КЛ")]
        CabelLine = 546,
        /// <summary>
        /// КВЛ (кабельновоздушная линия), (СЛ) смешанная линия
        /// </summary>
        [Description("КВЛ")]
        MixedLine = 548,
        CellLine_10 = 676,
        CellLine_6 = 675,
        CellLine_04 = 678,
        CellLine_023,
        None = -1
    }

}
