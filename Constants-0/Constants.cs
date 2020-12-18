using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;

namespace Constants
{
    /// <summary> Тип абонента
    /// </summary>
    public enum AbnType
    {
        /// <summary>
        /// Частные лица
        /// </summary>
        Private = 206,
        /// <summary>
        /// Потребитель ЮЛ
        /// </summary>
        Legal = 207,
        /// <summary> Частные лица бездоговоровные
        /// </summary>
        PrivateNoDog = 253,
        /// <summary> Сетевые организации
        /// </summary>
        Net = 231,
        /// <summary>  Сбытовые организации 
        /// </summary>
        Sale = 230,
        /// <summary> Завод-изготовитель
        /// </summary>
        [Description("Завод-изготовитель")]
        Maker = 614,
        /// <summary> Монтажная организация
        /// </summary>
        [Description("Монтажная организация")]
        Mount = 680,
        /// <summary>
        /// Абоненты с пасспорта
        /// </summary>
        [Description("Контрагенты с паспорта")]
        PassportPS = 683,
        /// <summary>
        /// Конрагент ЮЛ
        /// </summary>
        [Description("Контрагент ЮЛ")]
        KontragentLegal = 1038,
        /// <summary>
        /// Контрагент ФЛ
        /// </summary>
        [Description("Контрагент ФЛ")]
        KontragentFL = 1037,
        /// <summary>
        /// Прочие контрагенты
        /// </summary>
        [Description("Прочие контрагенты")]
        OtherAbn = 581
    }

    /// <summary>
    /// Типы контрагента...
    /// </summary>
    public enum KontragentType
    {
        /// <summary>
        /// Раскопки
        /// </summary>
        Excavation = 1046, 
        /// <summary>
        /// Собственная орагнизация
        /// </summary>
        Own = 1115,
        /// <summary>
        /// Обслуживающая организация
        /// </summary>
        Servicing = 1243,
        /// <summary>
        /// Акт расследования
        /// </summary>
        ActDetection = 1877

    }

    /// <summary>
    /// Типы объектов контрагентов
    /// </summary>
    public enum KontragentObjType
    {
        AbnObjFL = 1146,
        AbnObjLegal = 1147,
        KontragentObjFL = 1148,
        KontragentObjLegal = 1149
    }

    /// <summary> Состояние актов на объект абонента
    /// </summary>
    public enum ActObjState
    {
        /// <summary> Нормальный
        /// </summary>
        Normal = 595,
        /// <summary> Повторный-нормальный
        /// </summary>
        RepeatedNormal = 596,
        /// <summary> Несовпадающий
        /// </summary>
        Mismatched = 597
    }

    /// <summary> Состояние точки учета приборов эл. энергии
    /// </summary>
    public enum ActPointState
    {
        /// <summary> Нормальное
        /// </summary>
        Normal = 0,
        /// <summary> Прибор закркплен за другой точкой учета
        /// </summary>
        OtherPoint = 1,
        /// <summary> Прибор не закреплен ни за одной точкой учета
        /// </summary>
        NoPoint = 2,
        /// <summary> Прибор присутствует на точке учета, но отсутствует в акте
        /// </summary>
        YesPoint = 3
    }

    /// <summary> Формат даты
    /// </summary>
    public enum DateFormat
    {
        /// <summary> День/Месяц/Год
        /// </summary>
        DayMonthYear = 0,
        /// <summary> Год
        /// </summary>
        Year = 1
    }

    /// <summary> Тип документов
    /// </summary>
    public enum DocType
    {

        /// <summary> Договор по передаче эл. энергии
        /// </summary>
        DogovorTransferEnergy = 217,
        /// <summary> Акт установки счетчика
        /// </summary>
        ActUst = 271,
        /// <summary> Акт демонтажа счечтика
        /// </summary>
        ActDem = 272,
        /// <summary> Акт контрольного снятия показаний
        /// </summary>
        ActKO = 273,
        /// <summary> Документ расчета потерь
        /// </summary>
        LossCalculation = 276,
        /// <summary> Переходные показания
        /// </summary>
        ActPerehod = 308,
        /// <summary> Акт разграничения балансовой принадлежности
        /// </summary>
        ActRBP = 497,
        /// <summary> Акт технологического присоединения
        /// </summary>        
        ActTP = 498,
        /// <summary> Акт разграничения эксплуатационной ответственности
        /// </summary>
        ActLiability = 1246,
        /// <summary> Акт технической проверки средств учета электрической энергии
        /// </summary>
        ActCheck = 588,
        /// <summary> Акт технической установки средств учета электрической энергии
        /// </summary>
        ActMeterInstallation = 599,
        /// <summary> Акт технического демонтажа средств учета электрической энергии
        /// </summary>
        ActMeterDismantling = 600,
        /// <summary> Акт технической замены средств учета электрической энергии
        /// </summary>
        ActMeterkReplacement = 601,
        /// <summary> Договор контрагента 
        /// </summary>
        Dogovor = 501,
        /// <summary> Договор контрагента по энергоснабжению
        /// </summary>
        DogovorEnergo = 533,
        /// <summary> Акт неучтенной электроэнергии
        /// </summary>
        ActBezuch = 312,
        /// <summary> Акт бездоговорного потребления
        /// </summary>
        ActBezdog = 311, 
        /// <summary>
        /// Показания от потребителя
        /// </summary>
        IndicationOfConsumer = 316,
        /// <summary>
        /// Показания УК
        /// </summary>
        IndicationUK = 1162,
        /// <summary>
        /// Акт контрольного обхода из Ульяновск Энерго
        /// </summary>
        UlEnergoKO = 315,
        /// <summary>
        /// Акт обследования из Ульяновск Энерго
        /// </summary>
        UlEnergoInspection = 274,
        /// <summary>
        /// Акт обследования
        /// </summary>
        Inspection = 309
    }

    /// <summary> Действия над пломбой
    /// </summary>
    public enum ActPlomb
    {
        /// <summary> Выдача пломбы
        /// </summary>
        Extradition = 299,
        /// <summary> Уничтожение/списание пломбы
        /// </summary>
        Destruction = 300,
        /// <summary> Установка пломбы
        /// </summary>
        Installation = 301,
        /// <summary> Демонтаж пломбы
        /// </summary>
        Dismantling = 302
    }

    /// <summary> Тип оборудования в точке учета
    /// </summary>
    public enum DevicePointType
    {
        /// <summary> Трансформатор тока (по старому просто трансформатор)
        /// </summary>
        TransAmperage = 246,
        /// <summary> Счетчик
        /// </summary>
        Meter = 245, 
        /// <summary>
        /// Отключена
        /// </summary>
        OffPoint = 247,
        /// <summary>
        /// Без счетчика
        /// </summary>
        NoMeter = 248, 
        /// <summary>
        /// Трансформатор напряжения
        /// </summary>
        TransVoltage = 1310

    }

    /// <summary> Тип трансформатора в точке учета
    /// </summary>
    public enum TransPointType
    {
        /// <summary> Трансформатор тока
        /// </summary>
        TransCurrent = 68,
        /// <summary> Трансформатор напряжения
        /// </summary>
        TransVoltage = 69
    }

    /// <summary> Тип оборудования
    /// </summary>
    public enum EquipmentType
    {
        /// <summary> Отсутствует
        /// </summary>
        None = -1,
        /// <summary> Подстанция
        /// </summary>
        Substation = 79,
        /// <summary> Шина
        /// </summary>
        Bus = 84,
        /// <summary> Выключатель
        /// </summary>
        Switch = 95,
        /// <summary> Кабель
        /// </summary>
        Line = 545,
        /// <summary> Ячейка
        /// </summary>
        Cell = 550,
        /// <summary> Муфта
        /// </summary>
        Clutch = 612,
        /// <summary> Муфта концевая
        /// </summary>
        ClutchEnd = 926,
        /// <summary> Центр питания
        /// </summary>
        NutritionCenter = 536,
        /// <summary> Распределительная подстанция
        /// </summary>
        DistributionSubstation = 537,
        /// <summary> Трансформаторная подстанция
        /// </summary>
        TransformerSubstation = 538,
        /// <summary> Преобразовательная подстанция
        /// </summary>
        ConverterSubstation = 535,
        /// <summary> СП подстанция
        /// </summary>
        SPSubstation = 1034,
        /// <summary> Шина 0.23 кВ
        /// </summary>
        Bus023 = 563,
        /// <summary> Шина 0.4 кВ
        /// </summary>
        Bus04 = 540,
        /// <summary> Шина 6 кВ
        /// </summary>
        Bus6 = 541,
        /// <summary> Шина 10 кВ
        /// </summary>
        Bus35 = 653,
        /// <summary> Шина 35 кВ
        /// </summary>
        Bus110 = 654,
        /// <summary> Шина 110 кВ
        /// </summary>
        Bus10 = 564,
        /// <summary> Выключатель нагрузки
        /// </summary>
        LoadSwitch = 554,
        /// <summary> Маслянный выключатель
        /// </summary>
        LubricantSwitch = 552,
        /// <summary> Вакуумный выключатель
        /// </summary>
        VacuumSwitch = 558,
        /// <summary> Линейный разъединитель
        /// </summary>
        LineDisconnector = 553,
        /// <summary> Наружний линейный разъединитель
        /// </summary>
        OutsideLineDisconnector = 559,
        /// <summary> Смешанная линия
        /// </summary>
        MixedLine = 548,
        /// <summary> Кабельная линия
        /// </summary>
        CableLine = 546,
        /// <summary> Воздушная линия
        /// </summary>
        AirWay = 547,
        /// <summary> Ячейка низкого напряжения
        /// </summary>
        CellLW = 584,
        /// <summary> Ячейка высокого напряжения
        /// </summary>
        CellHV = 551,
        /// <summary> Трансформатор
        /// </summary>
        Transformer = 556,
        /// <summary> Трансформатор напряжения
        /// </summary>
        VoltageTransformer = 603,
        /// <summary> Трансформатор тока
        /// </summary>
        AmperageTransformer = 976,
        /// <summary> Предохранитель
        /// </summary>
        Protector = 908,
        /// <summary> Разрядник
        /// </summary>
        Discharger = 1212,
        /// <summary> Ограничитель перенапряжения
        /// </summary>
        VoltageProtector = 1213,
        /// <summary>Рубильник с пердохранителем смещенный РПС
        /// </summary> 
        ContactBreaker = 975,
        /// <summary> Счетчик
        /// </summary>
        Counter = 1277,
        /// <summary> Автоматический выключатель
        /// </summary>
        AutoSwitch = 903
    }

    /// <summary> Расположение объекта
    /// </summary>
    public enum ObjLocation
    {
        ULGES = 777,
        Registr = 779,
        Warehouse = 778,
        Warehouse_4 = 780,
        Dispose = 909,
        RepairShop = 776,
        Unknow = 1028,
        Unbind = 1091
    }

    public enum PasspCharEquipType
    {
        /// <summary> Отсутствует
        /// </summary>
        [StringValue("None")]
        None = 0,
        /// <summary> Подстанция
        /// </summary>
        [StringValue(";EquipChar;Passp;PS;")]
        PS = 3,
        /// <summary> Шина
        /// </summary>
        [StringValue(";EquipChar;Passp;Bus;")]
        Bus = 27,
        /// <summary> Выключатель
        /// </summary>
        [StringValue(";EquipChar;Passp;Switch;")]
        Switch = 28,
        /// <summary> Воздушная линия
        /// </summary>
        [StringValue(";EquipChar;Passp;Line;")]
        Line = 29,
        /// <summary> Ячейка
        /// </summary>
        [StringValue(";EquipChar;Passp;Cell;")]
        Cell = 30,
        /// <summary> Муфта
        /// </summary>
        [StringValue(";EquipChar;Passp;Clutch;")]
        Clutch = 31,
        /// <summary> Трансформатор
        /// </summary>
        [StringValue(";EquipChar;Passp;Trans;")]
        Transformer = 32,
        /// <summary> Кабель
        /// </summary>
        [StringValue(";EquipChar;Passp;Cable;")]
        Cable = 81
    }

    /// <summary> Расположение точки учета
    /// </summary>
    public enum LocationType
    {
        /// <summary> Родительская группа
        /// </summary>
        Parent = 264,
        /// <summary> В квартире
        /// </summary>
        InAnApartment = 265,
        /// <summary> На площадке
        /// </summary>
        OnSite = 266,
        /// <summary> РУ-0.4 в здании
        /// </summary>
        RU04InTheBuilding = 534
    }

    /// <summary> Уровень напряжения
    /// </summary>
    public enum TensionType
    {
        /// <summary> Родительская группа
        /// </summary>
        Parent = 226,
        /// <summary> Высокое напряжение
        /// </summary>
        HighVoltage = 227,
        /// <summary> Среднее напряжение
        /// </summary>
        MiddleVoltage = 228,
        /// <summary> Низкое напряжение
        /// </summary>
        LowVoltage = 229
    }

    /// <summary> Тип временной зоны
    /// </summary>
    public enum TimeZoneType
    {
        /// <summary> Одноставочный тариф
        /// </summary>
        OnePartTariff = 259,
        /// <summary> Двухставочный тариф
        /// </summary>
        TwoPartTariff = 260
    }

    /// <summary> Тип одноставочного тарифа
    /// </summary>
    public enum TwoPartTariffType
    {
        /// <summary> День
        /// </summary>
        Day = 261,
        /// <summary> Ночь
        /// </summary>
        Night = 262
    }

    /// <summary> Тип двухставочного тарифа
    /// </summary>
    public enum OnePartTariffType
    {
        /// <summary> Сутки
        /// </summary>
        TwentyFourHours = 259
    }

    /// <summary> Состояние формы при ее создании
    /// </summary>
    public enum StateFormCreate
    {
        /// <summary> Добавление
        /// </summary>
        Add,
        /// <summary> Редактирование
        /// </summary>
        Edit,
        /// <summary> Удаление6
        /// </summary>
        Delete,
        /// <summary> Добавление группы
        /// </summary>
        AddGruop,
        /// <summary> Добавление элемента
        /// </summary>
        AddElement,
        /// <summary> Редактирование группы
        /// </summary>
        EditGroup,
        /// <summary> Редактирование элемента
        /// </summary>
        EditElement,
        /// <summary> Просмотр
        /// </summary>
        View,
        /// <summary> Перемещение
        /// </summary>
        Move,
        /// <summary> Привязка
        /// </summary>
        Bind,
        /// <summary> Отвязка
        /// </summary>
        Unbind,
        /// <summary> Копирование
        /// </summary>
        Copy
    }

    /// <summary> Обслуживающие организации
    /// </summary>
    public enum ServiceOrg
    {
        /// <summary> Сбытовая
        /// </summary>
        Sale = 9028,
        /// <summary> Сетевая
        /// </summary>
        Net = 9999
    }

    /// <summary> Режим создания контрола
    /// </summary>
    public enum ControlAddEditMode
    {
        /// <summary> Добавление
        /// </summary>
        Add,
        /// <summary> Редактирование
        /// </summary>
        Edit
    }

    namespace Scheme
    {
        /// <summary>
        /// Типы линий
        /// </summary>
        public enum TypeLine
        {
            AirLine = 547,
            AirLineProtected = 983,
            CabelLine = 546,
            MixedLine = 548,
        }
    }

    /// <summary>Типы подстанций</summary>
    public enum SchmTypeSubstation
    {
        /// <summary>Трансформаторная подстанция</summary>
        TP = 538,
        /// <summary>Центр питания</summary>
        CP = 536,
        /// <summary>Распределительная подстанция</summary>
        RP = 537,
        /// <summary>Подстанция переключения</summary>
        PP = 535,
        /// <summary>Соединительная подстанция</summary>
        SP = 1034,
        /// <summary>ППНО</summary>
        PPNO = 1275
    }
    /// <summary>Типы ячеек</summary>
    public enum SchmTypeCell
    {
        /// <summary>ячейка 0,23кВ</summary>
        Cell023 = 679,
        /// <summary>ячейка 0,4кВ</summary>
        Cell04 = 678,
        /// <summary>ячейка 6кВ</summary>
        Cell6 = 675,
        /// <summary>ячейка 10кВ</summary>
        Cell10 = 676,
        /// <summary>ячейка 35кВ</summary>
        Cell35 = 674,
        /// <summary>ячейка 110кВ</summary>
        Cell110 = 672
    }
    /// <summary>
    /// Типы шин
    /// </summary>
    public enum SchmTypeBus
    {
        Shina_023 = 563,
        Shina_04 = 540,
        Shina_6 = 541,
        Shina_10 = 564
    }

    public enum SchmTypeSwGear
    {
        SwGear_04 = 761,
        SwGear_6 = 762,
        SwGear_10 = 763,
        SwGear_110 = 764,
        SwGear_35 = 765,
        SwGear_023 = 766
    }

    namespace Passport
    {
        #region Enums
        /// <summary> Типы данных параметров пасспорта
        /// </summary>            
        public enum ParameterTypes
        {

            /// <summary> Отсутствует
            /// </summary>            
            None = 730,
            /// <summary> Текстовый
            /// </summary>
            Text = 721,
            /// <summary> Список
            /// </summary>
            List = 722,
            /// <summary> Логический
            /// </summary>
            Logical = 724,
            /// <summary> Дата
            /// </summary>
            Date = 726
        }

        /// <summary> Типы формата даты
        /// </summary>            
        public enum DateFormat
        {
            /// <summary> Отсутствует
            /// </summary>            
            None = 731,
            /// <summary> ГГГГ
            /// </summary>            
            YYYY = 729,
            /// <summary> ДД.ММ.ГГГГ
            /// </summary>            
            DDMMYYYY = 728
        }

        public enum StateRow
        {
            Edit,
            Delete,
            Recover
        }
        #endregion

        public static class ObjListKey
        {
            public const string Substation = ";SCM;PS;";
            public const string Switchgear = ";SCM;SwGear;";
            public const string Bus = ";SCM;BUS;";
            public const string Cell = ";SCM;Cell;";
            public const string Switch = ";SCM;INLINE_OBJ;SWITCH;";
            public const string Line = ";SCM;Line;";
            public const string Transformator = ";SCM;INLINE_OBJ;SWITCH;";
            public const string Sector = ";SCM;Sector;";
        }

        public enum LineValue
        {
            Cable = 1,
            Air = 2,
            Mixed = 4
        }
    }


    /// <summary> Статусы абонентов гос.сектора
    /// </summary>
    public enum StatusAbnLegal
    {
        /// <summary> Группа
        /// </summary>
        Parent = 288,
        /// <summary> Расторжение договора
        /// </summary>
        EndDog = 257,
        /// <summary> Временное прекращение деятельности
        /// </summary>
        TempEndDog = 258

    }

    public enum TypeSettings
    {
        /// <summary> Настройки изображений паспорта 
        /// </summary>
        PassportImage = 1,
        /// <summary> Настройки всплывающей панели паспорта
        /// </summary>
        PassportPanel = 2
    }

    public static class Constants
    {
        #region Типы абонента
        /// <summary>
        /// юридические лица
        /// </summary>
        public const int TypeAbnLegal = 207;
        public const string TypeAbnLegalAll = "207,231,230";
        /// <summary>
        /// Частные лица
        /// </summary>
        public const int TypeAbnPrivate = 206;
        /// <summary>
        /// частные лица бездоговоровные
        /// </summary>
        public const int TypeAbnPrivateNoDog = 253;
        /// <summary>
        /// сбытовые организации
        /// </summary>
        public const int TypeAbnNet = 231;
        /// <summary>
        /// сетевые организации
        /// </summary>
        public const int TypeAbnSale = 230;
        /// <summary>
        /// Производитель
        /// </summary>
        public const int TypeAbnMaker = 614;

        public const int TypeAbnPassport = 683;
        public const int TypeAbnOther = 581;
        #endregion

        #region Уровени напряжения
        /// <summary>
        /// Высокое напряжение
        /// </summary>
        public const int TensionHighVoltage = 227;
        /// <summary>
        /// Низкое напряжение
        /// </summary>
        public const int TensionLowVoltage = 229;
        /// <summary>
        /// Среднее напряжение
        /// </summary>
        public const int TensionMeanVoltage = 228;
        #endregion

        #region Группы сотрудников
        /// <summary>
        /// Мастера по работе с физ. лицами
        /// </summary>
        public const int WorkerGroupMasterBS = 268;
        /// <summary>
        /// Контролеры по работе с физ. лицами
        /// </summary>
        public const int WorkerGroupControlerBS = 216;
        /// <summary>
        /// операторы по работе с физ. лицами
        /// </summary>
        public const int WorkerGroupOperatorBS = 914;
        /// <summary>
        /// Мастера по работе с юр. лицами
        /// </summary>
        public const int WorkerGroupMasterUL = 222;
        /// <summary>
        /// Уполномоченные лица
        /// </summary>
        public const int WorkerGroupAuthorPerson = 569;
        /// <summary>
        /// Контролеры по работе с юр. лицами
        /// </summary>
        public const int WorkerGroupControlerUL = 220;
        /// <summary>
        /// Другие
        /// </summary>
        public const int WorkerGroupOther = 746;

        #endregion

        #region KladrObj
        public const int KladrObjUlyanovsk = 24;
        #endregion

        #region Виды шаблонов документов
        /// <summary>
        /// Договор передачи
        /// </summary>
        public const int TemplDogPer = 507;
        /// <summary>
        /// Перечень точек поставки электрической энергии Потребителя услуг
        /// </summary>
        public const int TemplListObj = 508;
        /// <summary>
        /// Заявленные (договорные) объемы передаваемой энергии и мощности с разбивкой по месяцам
        /// </summary>
        public const int TemplVolumPower = 509;
        /// <summary>
        /// Форма «Акт об оказанных услугах»
        /// </summary>
        public const int TemplActService = 510;
        /// <summary>
        /// Форма «Дополнительное соглашение Новые реквизиты»
        /// </summary>
        public const int TemplDopSogl = 736;
        /// <summary>
        /// Уведомление для потребителей о максимальной мощности
        /// </summary>
        public const int TemplPowerMax = 877;
        /// <summary>
        /// Уведомление для потребителей о максимальной мощности(>670)
        /// </summary>
        public const int TemplPowerMax670 = 878;
        /// <summary>
        /// Новый договор передачи
        /// </summary>
        public const int TemplDogPerNew = 912;
        /// <summary>
        /// Новый перечень точек поставки электрической энергии
        /// </summary>
        public const int TemplListObjNew = 915;
        /// <summary>
        /// Расчетные способы учета электроэнергии
        /// </summary>
        public const int TemplCalcMethod = 916;
        /// <summary>
        /// Новые заявленные объемы
        /// </summary>
        public const int TemplVolumNew = 918;
        /// <summary>
        /// Соглашение о максимальной мощности
        /// </summary>
        public const int TemplPowerMaxAgreement = 922;
        /// <summary>
        /// Ограничение на 2012 (энергоснабжение)
        /// </summary>
        public const int TemplRestrictionContractNo = 923;
        /// <summary>
        /// Ограничение на 2012 (транспортировка)
        /// </summary>
        public const int TemplRestrictionContract = 924;
        /// <summary>
        /// Уведомление замеры(транспортировка)
        /// </summary>
        public const int TemplMeasurementContract = 962;
        /// <summary>
        /// Уведомление замеры(энергоснабжение)
        /// </summary>
        public const int TemplMeasurementContractNo = 963;
        /// <summary>
        /// Сопроводиловка к актам границ
        /// </summary>
        public const int TemplActRBP = 1009;
        /// <summary>
        /// Дополнительное соглашение Приложения к договора по транспортировке
        /// </summary>
        public const int TemplDopSogl2 = 1174;
        /// <summary>
        /// Запрос о предоставлении данных для расчета потерь
        /// </summary>
        public const int TemplKloss = 1175;
        /// <summary>
        /// Соглашение о расторжении договора
        /// </summary>
        public const int TemplTerminationContract = 1210;
        /// <summary>
        /// Дополнительное соглашение Приложения к договора по транспортировке
        /// </summary>
        public const int TemplDopSogl3 = 1247;
        /// <summary>
        /// Предложение о заключении договора
        /// </summary>
        public const int TemplOffer = 2342;
        /// <summary>
        /// Дополнительное соглашение c третьими лицами
        /// </summary>
        public const int TemplDopSogl4 = 2444;


        #endregion

        #region Виды адресов
        /// <summary>
        /// Почтовый адрес
        /// </summary>
        public const int AddressMailing = 43;
        /// <summary>
        /// Юридический адрес
        /// </summary>
        public const int AddressLegal = 54;
        #endregion

        #region Виды ввода начислений
        /// <summary>
        /// Ручной
        /// </summary>
        public const int TypeEnter = 512;
        /// <summary>
        /// Мощность
        /// </summary>
        public const int TypePower = 513;
        /// <summary>
        /// Счетчики
        /// </summary>
        public const int TypeMeter = 514;
        /// <summary>
        /// Превышение мощности
        /// </summary>
        public const int TypeOverPower = 593;
        /// <summary>
        /// Ручной(безучетный)
        /// </summary>
        public const int TypeEnterOff = 1266;
        /// <summary>
        /// Счетчик(безучетный)
        /// </summary>
        public const int TypeMeterOff = 1267;
        /// <summary>
        /// Мощность(безучетный)
        /// </summary>
        public const int TypePowerOff = 1268;
        /// <summary>
        /// Ручной(перетоки)
        /// </summary>
        public const int TypeEnterСrossFlow = 1269;
        /// <summary>
        /// Счетчик(перетоки)
        /// </summary>
        public const int TypeMeterCrossFlow = 1270;
        /// <summary>
        /// Ручной(непосредственное управление)
        /// </summary>
        public const int TypeEnter_DirectControl = 1294;
        /// <summary>
        /// Счетчик(непосредственное управление)
        /// </summary>
        public const int TypeMeter_DirectControl = 1295;

        #endregion

        #region Виды начислений
        /// <summary>
        /// Виды начислений
        /// </summary>
        public const int TypeEnergy = 542;
        /// <summary>
        /// Услуги по передаче электроэнергии
        /// </summary>
        public const int TypeTransmission = 543;
        /// <summary>
        /// Активная энергия
        /// </summary>
        public const int TypeElectricity = 544;
        #endregion

        #region Платежные документы
        /// <summary>
        /// Счет к оплате
        /// </summary>
        public const int PaymentSchet = 571;
        /// <summary>
        /// Счет - фактура
        /// </summary>
        public const int PaymentSchetFact = 572;
        /// <summary>
        /// Счет - фактура корректировочный
        /// </summary>
        public const int PaymentSchetFactCorrect = 716;
        /// <summary>
        /// Накладная
        /// </summary>
        public const int PaymentInvoice = 574;
        /// <summary>
        /// Акт оказания услуг
        /// </summary>
        public const int PaymentAct = 573;
        /// <summary>
        /// Платежное требование
        /// </summary>
        public const int PaymentBankRequir = 575;
        /// <summary>
        /// Реестр в банк
        /// </summary>
        public const int PaymentBankRegister = 576;
        /// <summary>
        /// Платежные документы
        /// </summary>
        public const int PaymentDoc = 570;
        #endregion

        #region Документы подтверждающие право подписи
        public const int DocSignat = 577;
        #endregion

        #region Ставка НДС
        public const int TaxRate18 = 18;
        public const int TaxRate20 = 20;
        #endregion

        #region Состояние объекта
        /// <summary>
        /// Не рассчитывается
        /// </summary>
        public const int TypeObjStatus_Off = 243;
        /// <summary>
        /// Перетоки
        /// </summary>
        public const int TypeObjStatus_CrossFlow = 1271;
        /// <summary>
        /// Рассчитывается по доовору передачи
        /// </summary>
        public const int TypeObjStatus_Per = 241;
        /// <summary>
        /// Рассчитывается по договору энергоснабжения
        /// </summary>
        public const int TypeObjStatus_Snab = 242;
        /// <summary>
        /// Непосредственное управление
        /// </summary>
        public const int TypeObjStatus_DirectControl = 1293;
        #endregion

        #region Автор контактов потребителя
        /// <summary>
        /// СКиУЭЭ
        /// </summary>
        public const int AuthorContact_CS = 2247;
        /// <summary>
        /// ОДС
        /// </summary>
        public const int AuthorContact_ODS = 2248;
        #endregion

        #region Класс точки учета
        /// <summary>
        /// Учетный
        /// </summary>
        public const int idPointClassCalc = 2464;
        /// <summary>
        /// Контрольный
        /// </summary>
        public const int idPointClassControl = 2465;
        #endregion

    }
    /// <summary>
    /// Типы расчетов потерь
    /// </summary>
    public enum TypeCalcLoss
    {
        /// <summary>
        /// расчет потерь в трансформаторе
        /// </summary>
        TypeTrans = 1199,
        /// <summary>
        /// расчет потерь в воздушной линии
        /// </summary>
        TypeVL = 1198,
        /// <summary>
        /// расчет потерь в кабельной линии
        /// </summary>
        TypeKL = 1197
    }

    public class StringValue : System.Attribute
    {
        private string _value;

        public StringValue(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }

    }

    public static class StringEnum
    {
        public static string GetStringValue(Enum value)
        {
            string output = null;
            Type type = value.GetType();

            //Check first in our cached results...
            //Look for our 'StringValueAttribute' 
            //in the field's custom attributes

            FieldInfo fi = type.GetField(value.ToString());
            StringValue[] attrs =
               fi.GetCustomAttributes(typeof(StringValue),
                                       false) as StringValue[];
            if (attrs.Length > 0)
            {
                output = attrs[0].Value;
            }

            return output;
        }
    }

    public enum TypeDocValue
    {
        None = 0,
        ActBalance = 1,
        ActLiability = 4
    }

    public enum eTypeDocTC
    {
        /// <summary>
        /// заявка на техприсоединение
        /// </summary>
        Request = 1113,
        /// <summary>
        /// Тех условия
        /// </summary>
        TU = 1123,
        /// <summary>
        /// протокол разногласий
        /// </summary>
        Вisagreements = 1124,
        /// <summary>
        /// письмо
        /// </summary>
        MailRequest = 1125,
        /// <summary>
        /// Письмо на ТУ
        /// </summary>
        MailTU = 1218,
        /// <summary>
        /// Договор о комп
        /// </summary>
        DogComp = 1153,
        /// <summary>
        /// Соглашение
        /// </summary>
        Agreement = 1152,
        /// <summary>
        /// Доп соглашение
        /// </summary>
        AddittionalAgreement = 1151,
        /// <summary>
        /// Запрос
        /// </summary>
        Query = 1155,
        /// <summary>
        /// Уведомление
        /// </summary>
        Notice = 1154,
        /// <summary>
        /// Дополнение к заявке
        /// </summary>
        RequestAdditional = 1203,
        /// <summary>
        /// Договор на ТП
        /// </summary>
        DogOnTC = 1220,
        /// <summary>
        /// Соглашение о расторжении
        /// </summary>
        AgreementCancel = 1237,
        /// <summary>
        /// акт осмотра электроустановки
        /// </summary>
        ActElectricalInspection = 1238,
        /// <summary>
        /// Акт о выполнении ТУ
        /// </summary>
        ActPerformingTU = 1239,
        /// <summary>
        /// Акт о тех присоединении
        /// </summary>
        ActTC = 1240,
        /// <summary>
        /// Акт разграничения балансовой принадлежности
        /// </summary>
        ActRBP = 497,
        /// <summary>
        /// Акт эксплатационной ответсвенности
        /// </summary>
        ActOperation1Resp = 1246,
        /// <summary>
        /// Смена рубильника
        /// </summary>
        ChangeSwitch = 1346
    }
}
