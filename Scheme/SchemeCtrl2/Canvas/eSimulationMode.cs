using System;

namespace SchemeCtrl2.Canvas
{
	public enum eSimulationMode
	{
        /// <summary>
        /// оперативное использование
        /// </summary>
		Online = 1,
        /// <summary>
        /// нормальная схема (по точкам токораздела)
        /// </summary>
        Normal,
        /// <summary>
        /// тренировочная схема
        /// </summary>
		Training
	}
}
