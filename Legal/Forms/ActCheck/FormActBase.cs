using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataSql;
using Constants;

namespace Legal.Forms.ActCheck
{
    public enum Device { Meter, TransCurrent, TransVoltage }

    public enum ComboBoxName { cbNumMeter, cbNumTransI, cbNumTransU, cbTypeMeter, cbTypeTransI, cbTypeTransU, cbAllMeter, cbAllTransI, cbAllTransU,
    cbNumMeterInst, cbNumTransIInst, cbNumTransUInst, cbTypeMeterInst, cbTypeTransIInst, cbTypeTransUInst, cbAllMeterInst, cbAllTransIInst, cbAllTransUInst,
    cbNumMeterDis, cbNumTransIDis, cbNumTransUDis, cbTypeMeterDis, cbTypeTransIDis, cbTypeTransUDis, cbAllMeterDis, cbAllTransIDis, cbAllTransUDis}

    public enum Seal { New, Old, Dis }

    public partial class FormActBase : FormLbr.FormBase
    {        
        public FormActBase()
        {
            InitializeComponent();
        }

        protected SQLSettings SQLSettings 
        {
            get { return this.SqlSettings; }
            set { this.SqlSettings = value; } 
        }

        /// <summary> Сбор нарушений собранных в результате осмотра
        /// </summary>
        public string CollectionMalfunction(DataGridView dgv)
        {
            string result = "";
            foreach (DataGridViewRow item in dgv.Rows)
            {
                if (Convert.ToBoolean(item.Cells["MalfunctionValue"].Value) == true) result += "1;";
                else result += "0;";
            }
            result = result.Remove(result.Length - 1);
            return result;
        }

        /// <summary> Сбор предписаний
        /// </summary>        
        public string CollectionStrikeReveal(DataGridView dgv)
        {
            string result = "";
            foreach (DataGridViewRow item in dgv.Rows)
            {
                if (Convert.ToBoolean(item.Cells["StrikeRevealValue"].Value) == true) result += "1;";
                else result += "0;";
            }
            return result.Remove(result.Length - 1);
        }

        #region Заполнение таблиц данными
        /// <summary> Добавление строки в таблицу tDocAct
        /// </summary>
        /// <param name="idPoint">Идентификатор точки учета</param>
        /// <param name="idPointReg">Идентификатор счетчика</param>
        /// <param name="ValueKWT">Показания счетчика</param>
        /// <param name="DateIn">Дата добавления документа</param>
        /// <param name="DateAct">Дата акта</param>
        /// <param name="idWorker">Идентификатор мастера</param>
        /// <param name="DocNumber">Номер акта</param>
        /// <returns>Идентификатор добавленной строки</returns>
        protected int tDocActInsert(int idPoint, int idPointReg, int docType, int ValueKWT, DateTime DateIn, DateTime DateAct, int idWorker, string DocNumber)
        {
            dsAbnObjAkt1.tDocAct.Clear();
            SelectSqlData(dsAbnObjAkt1.tDocAct, true, String.Format("where idDocType in (588,599,600,601) and isActive = 1 and idPoint = {0}",  idPoint), null, true); //(int)DocType.ActCheck
            for (int i = 0; i < dsAbnObjAkt1.tDocAct.Rows.Count; i++)
            {
                if ((dsAbnObjAkt1.tDocAct.Rows[i]["DocNumber"].ToString().Trim() == DocNumber.Trim()) && (Convert.ToInt32(dsAbnObjAkt1.tDocAct.Rows[i]["idDocType"]) == docType))
                {
                    dsAbnObjAkt1.tDocAct.Rows[i]["Deleted"] = true;
                    dsAbnObjAkt1.tDocAct.Rows[i]["isActive"] = false;
                }
            }
            if (dsAbnObjAkt1.tDocAct.Rows.Count > 0) UpdateSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tDocAct);
            var rowDocAct = dsAbnObjAkt1.tDocAct.NewRow();
            rowDocAct["idPoint"] = idPoint;
            rowDocAct["idPointReg"] = idPointReg;
            rowDocAct["idDocType"] = docType;
            rowDocAct["idZone"] = 263;            
            rowDocAct["ValueKWT"] = ValueKWT;
            rowDocAct["DateIn"] = DateIn;
            rowDocAct["DateAct"] = DateAct;
            rowDocAct["idWorker"] = idWorker;
            rowDocAct["DocNumber"] = DocNumber.Trim();
            rowDocAct["isActive"] = true;
            rowDocAct["Deleted"] = false;
            dsAbnObjAkt1.tDocAct.Rows.Add(rowDocAct);
            return InsertSqlDataOneRow(dsAbnObjAkt1, dsAbnObjAkt1.tDocAct);
        }

        /// <summary> Добавляет в акт информацию о приборе 
        /// </summary>
        /// <param name="idPointReg">Идентификатор прибора</param>
        /// <returns></returns>
        protected int DeviceInst(int idPointReg)
        {
            dsAbnObjAkt1.tDocAct_Device.AddtDocAct_DeviceRow(-1, idPointReg, "", "", Convert.ToDateTime("2000-01-01"));
            return InsertSqlDataOneRow(dsAbnObjAkt1, dsAbnObjAkt1.tDocAct_Device);
        }

        /// <summary> Добавляет в акт информацию о пломбе
        /// </summary>
        /// <param name="idDevice">Идентификатор устройства</param>
        /// <param name="idPlomb">Идентификатор пломбы</param>
        /// <param name="SealLocation">Место расположения пломбы</param>
        /// <param name="SealComment">Комментарий к пломбе</param>
        /// <returns>Идентификатор tAbnObjDoc_ActCheckPlomb</returns>
        protected int SealInsert(int idDevice, int idPlomb, string SealLocation, string SealComment)
        {
            dsAbnObjAkt1.tDocAct_Plomb.Clear();
            dsAbnObjAkt1.tDocAct_Plomb.AddtDocAct_PlombRow(idDevice, idPlomb, SealLocation, SealComment);
            return InsertSqlDataOneRow(dsAbnObjAkt1, dsAbnObjAkt1.tDocAct_Plomb);
        }

        /// <summary> Устанавливает/демонтирует пломбу на данный прибор учета
        /// </summary>
        /// <param name="idPointReg">Идентификатор устройства</param>
        /// <param name="idWorker">Идентификатор мастера</param>
        /// <param name="idPlomb">Идентификатор выбранной пломбы</param>
        /// <returns>Идентификатор tPlomb</returns>
        protected int SealInstDis(int idPointReg, int idWorker, int idPlomb, ActPlomb actPlomb)
        {
            SelectSqlData(dsAbnObjAkt1.tPlomb, true, "where id = " + idPlomb.ToString(), null, true);
            var rowPlomb = dsAbnObjAkt1.tPlomb.NewtPlombRow();
            var a = (int)actPlomb;
            rowPlomb.idPointReg = idPointReg;
            if (dsAbnObjAkt1.tPlomb.Rows[0]["typePlomb"] != System.DBNull.Value)
                rowPlomb.typePlomb = (int)dsAbnObjAkt1.tPlomb.Rows[0]["typePlomb"];
            rowPlomb.idActPlomb = (int)actPlomb;
            rowPlomb.idWorker = idWorker;
            rowPlomb.Seria = dsAbnObjAkt1.tPlomb.Rows[0]["Seria"].ToString();
            if (dsAbnObjAkt1.tPlomb.Rows[0]["Number"] != System.DBNull.Value)
                rowPlomb.Number = (int)dsAbnObjAkt1.tPlomb.Rows[0]["Number"];
            if (dsAbnObjAkt1.tPlomb.Rows[0]["DigitNumber"] != System.DBNull.Value)
                rowPlomb.DigitNumber = (short)dsAbnObjAkt1.tPlomb.Rows[0]["DigitNumber"];
            rowPlomb.Date = DateTime.Parse(dsAbnObjAkt1.tPlomb.Rows[0]["Date"].ToString());
            rowPlomb.DateInst = DateTime.Now;
            if (dsAbnObjAkt1.tPlomb.Rows[0]["idOwner"] != System.DBNull.Value)
                rowPlomb.idOwner = (short)dsAbnObjAkt1.tPlomb.Rows[0]["idOwner"];
            dsAbnObjAkt1.tPlomb.AddtPlombRow(rowPlomb);
            return InsertSqlDataOneRow(dsAbnObjAkt1, dsAbnObjAkt1.tPlomb);
        }

        /// <summary> Добавление записей о пломбах из данных в DataTable
        /// </summary>
        /// <param name="dt">DataTable c данными</param>
        /// <param name="idPointReg">Идентификатор устройства</param>
        /// <param name="idDevice">Идентификатор устройства в акте</param>
        protected void InstSealFromDataTable(DataTable dt, int idPointReg, int idDevice)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                switch (dt.Rows[i]["Act"].ToString())
                {
                    case "Установка":
                        SealInsert(idDevice, SealInstDis(idPointReg, int.Parse(dt.Rows[i]["idWorker"].ToString()), int.Parse(dt.Rows[i]["id"].ToString()), ActPlomb.Installation), dt.Rows[i]["Location"].ToString(), dt.Rows[i]["Comment"].ToString());
                        break;
                    case "Демонтаж":
                        SealInsert(idDevice, SealInstDis(idPointReg, int.Parse(dt.Rows[i]["idWorker"].ToString()), int.Parse(dt.Rows[i]["id"].ToString()), ActPlomb.Dismantling), dt.Rows[i]["Location"].ToString(), dt.Rows[i]["Comment"].ToString());
                        break;
                    case "Установлена":
                        SealInsert(idDevice, int.Parse(dt.Rows[i]["id"].ToString()), dt.Rows[i]["Location"].ToString(), dt.Rows[i]["Comment"].ToString());
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary> Добавление новой точки учета
        /// </summary>
        /// <param name="idAbnObj">Идентификатор объекта абонента</param>
        /// <param name="idLocation">Идентификатор места расположения</param>
        /// <param name="idTension">Идентификатор уровня напряжения</param>
        /// <param name="Voltage">Напряжение</param>
        /// <returns></returns>
        protected int InserttPointRow(int idAbnObj, int idLocation, int idTension, float Voltage)
        {
            var row = dsAbnObjAkt1.tPoint.NewtPointRow();
            row.idAbnObj = idAbnObj;
            row.idLocation = idLocation;
            row.idTension = idTension;
            row.Voltage = Voltage;
            row.DateBegin = DateTime.Now;
            dsAbnObjAkt1.tPoint.AddtPointRow(row);
            return InsertSqlDataOneRow(dsAbnObjAkt1, dsAbnObjAkt1.tPoint);
        }

        /// <summary> Добавление нового прибора на точку учета
        /// </summary>
        /// <param name="idPoint">Идентификатор точки учета</param>
        ///<param name="TypeDevice">Идентификатор типа устройства</param>
        ///<param name="idMark">Идентификатор марки счетчика</param>
        ///<param name="idWorkerBegin">Идентификатор мастера установки прибора</param>
        ///<param name="DateCheck">Дата гос. поверки</param>
        ///<param name="idZone">Идентификатор тарифной зоны</param>
        ///<param name="Number">Номер прибора учета</param>
        protected int InserttPointRegRow(int idPoint, int TypeDevice, int idMark, int idWorkerBegin, int idWorkerEnd, DateTime DateCheck, string Number, int idZone)
        {
            var row = dsAbnObjAkt1.tPointReg.NewtPointRegRow();
            row.IdPoint = idPoint;
            row.Type = TypeDevice;
            row.IdMark = idMark;
            row.idWorkerBegin = idWorkerBegin;
            row.idWorkerEnd = idWorkerEnd;
            row.DateMade = DateTime.Now;
            row.DateCheck = DateCheck;
            row.Number = Number;
            row.IdZone = idZone;
            dsAbnObjAkt1.tPointReg.AddtPointRegRow(row);
            return InsertSqlDataOneRow(dsAbnObjAkt1, dsAbnObjAkt1.tPointReg);
        }

        /// <summary> Демонтаж точки учета
        /// </summary>
        /// <param name="idPoint"></param>
        protected void DismantlingPoint(int idPoint)
        {
            SelectSqlData(dsAbnObjAkt1.tPoint, true, "where id =" + idPoint, null, true);
            dsAbnObjAkt1.tPoint.Rows[0]["DateEnd"] = DateTime.Now;
            UpdateSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tPoint);
        }

        /// <summary> Демонтаж прибора учета учета
        /// </summary>
        /// <param name="idPointReg"></param>
        protected void DismantlingPointReg(int idPointReg, int idWorkerEnd)
        {
            SelectSqlData(dsAbnObjAkt1.tPoint, true, "where id =" + idPointReg, null, true);
            dsAbnObjAkt1.tPoint.Rows[0]["idWorkerEnd"] = idWorkerEnd;
            dsAbnObjAkt1.tPoint.Rows[0]["DateEnd"] = DateTime.Now;
            UpdateSqlData(dsAbnObjAkt1, dsAbnObjAkt1.tPoint);
        }
        #endregion

    }
}
