using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Legal.Classes
{
    internal enum eTypeDoc
    {
        /// <summary> Заявка на техприсоединение
        /// </summary>
        Request = 1113,
        /// <summary> Тех условия
        /// </summary>
        TU = 1123,
        /// <summary> Протокол разногласий
        /// </summary>
        Вisagreements = 1124,
        /// <summary> Письмо
        /// </summary>
        MailRequest = 1125,
        /// <summary> Письмо на ТУ
        /// </summary>
        MailTU = 1218,
        /// <summary> Договор о комп
        /// </summary>
        DogComp = 1153,
        /// <summary> Соглашение
        /// </summary>
        Agreement = 1152,
        /// <summary> Доп соглашение
        /// </summary>
        AddittionalAgreement = 1151,
        /// <summary> Запрос
        /// </summary>
        Query = 1155,
        /// <summary> Уведомление
        /// </summary>
        Notice = 1154,
        /// <summary> Дополнение к заявке
        /// </summary>
        RequestAdditional = 1203,
        /// <summary> Договор на ТП
        /// </summary>
        DogOnTC = 1220,
        /// <summary> Соглашение о расторжении
        /// </summary>
        AgreementCancel = 1237,
        /// <summary> Акт осмотра электроустановки
        /// </summary>
        ActElectricalInspection = 1238,
        /// <summary> Акт о выполнении ТУ
        /// </summary>
        ActPerformingTU = 1239,
        /// <summary> Акт о технологическом присоединении
        /// </summary>
        ActTehConnection = 1240
    }

    internal enum StateCreate
    {
        Add,
        Copy,
        Edit,
        Show
    }    
}
