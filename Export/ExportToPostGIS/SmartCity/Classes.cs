using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportToPostGIS.SmartCity
{

    // Convert Json to C# Classes Online https://json2csharp.com/
    partial class SmartCity
    {
        #region Классы
        public class Authentication
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }
        public class Status
        {
            public string code { get; set; }
            public string details { get; set; }
            public string body { get; set; }
        }
        public class GetResult
        {
            public int result { get; set; }
            public Status status { get; set; }
        }
        public class GetResultToken : GetResult
        {
            public Token data { get; set; }
        }
        public class Token
        {
            public string accessToken { get; set; }
            public string validTo { get; set; }
        }
        /// <summary>
        /// список организаций
        /// </summary>
        public class Organizations
        {
            public int id { get; set; }
            public string name { get; set; }
            public string phone { get; set; }
            public string director { get; set; }
            public string inn { get; set; }
            public string ogrn { get; set; }
            public string kpp { get; set; }
            public string email { get; set; }
            public string note { get; set; }
            /// <summary>
            /// Фото до начала работ обязательное
            /// </summary>
            public bool isBeforeStartingWorkFilesRequred { get; set; }
            /// <summary>
            /// Фото после завершения работ обязательное
            /// </summary>
            public bool isCompletionFilesRequired { get; set; }
        }

        public class GetResultP<T>
        {
            public int status { get; set; }
            public Status result { get; set; }
            public List<T> data { get; set; }
        }
        #region Tickets - Получение списка заявок
        /// <summary>
        /// Получение списка заявок
        /// </summary>
        public class Tickets
        {
            //public int id { get; set; }
            //public int number { get; set; }
            //public string address { get; set; }
            //public string ticketStatusName { get; set; }
            //public string workTypeName { get; set; }
            //public string workKindName { get; set; }
            //public string created { get; set; }
            //public string performerOrganizationName { get; set; }
            public int id { get; set; }
            public int number { get; set; }
            public string address { get; set; }
            public string aisAddressGuid { get; set; }
            public string addressHouse { get; set; }
            /// <summary>
            /// Идентификатор адреса с домом
            /// </summary>
            public string addressHouseId { get; set; }
            public string apartmentNumber { get; set; }
            public string porch { get; set; }
            public string floor { get; set; }
            public string codeLock { get; set; }
            public string cause { get; set; }
            public string applicant { get; set; }
            public string applicantPhone { get; set; }
            public string applicantEmail { get; set; }
            public string comment { get; set; }
            public DateTime dateBegin { get; set; }
            public DateTime dateEnd { get; set; }
            public DateTime desiredDateBegin { get; set; }
            public DateTime desiredDateEnd { get; set; }
            public string damageTypeName { get; set; }
            public DateTime plannedExecuteDate { get; set; }
            public DateTime actualExecuteDate { get; set; }
            public DateTime completionDate { get; set; }
            public DateTime limitDate { get; set; }
            public DateTime created { get; set; }
            public int mark { get; set; }
            public bool isControl { get; set; }
            public bool isNotifed { get; set; }
            public string notifyBy { get; set; }
            public string notifyAbout { get; set; }
            public bool isVerifiedByApplicant { get; set; }
            public string organizationCreatorName { get; set; }
            public string organizationCreatorId { get; set; }
            public string ticketSourceName { get; set; }
            public string priorityName { get; set; }
            public string workTypeName { get; set; }
            public string workKindName { get; set; }
            public string ticketStatusName { get; set; }
            public string ticketStatusCode { get; set; }
            public string performerOrganizationName { get; set; }
            public bool isCompleted { get; set; }
            public string executorCommentary { get; set; }
            public int parentTicketId { get; set; }
            public List<Executor> executors { get; set; }
            public bool isIncidentFilesExists { get; set; }
            public bool isCompletionFilesExists { get; set; }
            public bool isBeforeStartingWorkFilesExists { get; set; }
            public string priorityCode { get; set; }
            public string ticketSourceCode { get; set; }
            public string workKindCode { get; set; }
            public string workTypeCode { get; set; }
            public int performerOrganizationId { get; set; }
            public string detailsUrl { get; set; }
            public string operatorName { get; set; }
            public string operatorId { get; set; }
            public string userNameWhoClosedTicket { get; set; }
        }
        public class Executor
        {
            public string id { get; set; }
            public string userName { get; set; }
            public string surname { get; set; }
            public string name { get; set; }
            public string patronymic { get; set; }
            public int organizationId { get; set; }
            public string organizationName { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
            public string roleCode { get; set; }
            public string roleName { get; set; }
            public string positionName { get; set; }
            public string specialtyName { get; set; }
            public int specialtyGrade { get; set; }
            public bool isMaster { get; set; }
            public string masterId { get; set; }
            public string masterComposedName { get; set; }
            public string basicNumber { get; set; }
            public DateTime workStartDate { get; set; }
            public DateTime workEndDate { get; set; }
            public DateTime created { get; set; }
            public DateTime updated { get; set; }
            public DateTime lockoutEndDate { get; set; }
            public bool isLocked { get; set; }
            public bool hasRiasPassport { get; set; }
        }
        #endregion
        /// <summary>
        /// Получение списка используемых сервисов
        /// </summary>
        public class ConnectedServices
        {
            public string code { get; set; }
            public string name { get; set; }
            public string link { get; set; }
        }

        /// <summary>
        /// Получение списка отключений
        /// </summary>
        public class ShutdownsGetDTO
        {
            /// <summary>
            /// Идентификатор отключения
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// Организация, создавшая отключение
            /// </summary>
            public int organizationId { get; set; }
            /// <summary>
            /// Вид работ
            /// </summary>
            public int workKindId { get; set; }
            /// <summary>
            /// Причина отключения
            /// </summary>
            public int shutdownCauseId { get; set; }
            /// <summary>
            /// Ответственный исполнитель
            /// </summary>
            public string executorName { get; set; }
            /// <summary>
            /// Телефон ответственного исполнителя
            /// </summary>
            public string executorPhone { get; set; }
            /// <summary>
            /// Дата начала отключения (string($date-time))
            /// </summary>
            public DateTime startDate { get; set; }
            /// <summary>
            /// Дата окончания отключения (string($date-time))
            /// </summary>
            public DateTime endDate { get; set; }
            /// <summary>
            /// Примечание
            /// </summary>
            public string comment { get; set; }
            /// <summary>
            /// Дата завершения отключения (string($date-time))
            /// </summary>
            public DateTime completionDate { get; set; }
            /// <summary>
            /// Дата обновления (string($date-time))
            /// </summary>
            public DateTime updated { get; set; }
            /// <summary>
            /// Количество домов в отключении
            /// </summary>
            public int countShutDownHouses { get; set; }
            /// <summary>
            /// Токен пагинации
            /// </summary>
            public string paginationToken { get; set; }
        }
        /// <summary>
        /// Добавление отключения
        /// </summary>
        public class ShutdownPostDTO
        {
            /// <summary>
            /// Идентификатор организации
            /// </summary>
            public int organizationId { get; set; }
            /// <summary>
            /// Вид работ
            /// </summary>
            public string workKindCode { get; set; }
            /// <summary>
            /// Код причины отключения
            /// </summary>
            public string shutdownCauseCode { get; set; }
            /// <summary>
            /// Ответственный исполнитель
            /// </summary>
            public string executorName { get; set; }
            /// <summary>
            /// Телефон ответственного
            /// </summary>
            public string executorPhone { get; set; }
            /// <summary>
            /// Дата начала отключения
            /// Формат = 2021-03-28T11:45:38.091Z
            /// </summary>
            public string startDate { get; set; }
            /// <summary>
            /// Дата окончания отключения
            /// </summary>
            public string endDate { get; set; }
            /// <summary>
            /// Примечание
            /// </summary>
            public string comment { get; set; }
        }
        /// <summary>
        /// Получение списка адресов по отключению с информацией из адресного сервиса 
        /// </summary>
        public class ShutdownsAddressesId
        {
            public int id { get; set; }
            public string addressComposedFullName { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
            public string aisAddressGuid { get; set; }
            public string fiasGuid { get; set; }
            /// <summary>
            /// Токен пагинации
            /// </summary>
            public string paginationToken { get; set; }
        }
        /// <summary>
        /// Получение списка адресов в отключении
        /// </summary>
        public class ShutdownsAddressLinkId
        {
            public int id { get; set; }
            public string addressComposedFullName { get; set; }
            public string addressId { get; set; }
            public string paginationToken { get; set; }
        }
        /// <summary>
        /// Получение списка привязок
        /// </summary>
        public class ObjectToOrganizationLinks
        {
            public int id { get; set; }
            public int organizationId { get; set; }
            public string organizationName { get; set; }
            public string address { get; set; }
            public string addressId { get; set; }
            public string addressHouse { get; set; }
            public string addressHouseId { get; set; }
            public string aisAddressId { get; set; }
            public int workKindId { get; set; }
            public string workKindName { get; set; }
            public string workKindCode { get; set; }
            public int workTypeId { get; set; }
            public string workTypeName { get; set; }
            public string workTypeCode { get; set; }
            public DateTime startDate { get; set; }
            public DateTime endDate { get; set; }
            public DateTime created { get; set; }
            public DateTime updated { get; set; }
            public bool isDeleted { get; set; }
            public string editorId { get; set; }
            public string editorName { get; set; }
        }
        /// <summary>
        /// Получение списка типов работ
        /// </summary>
        public class WorkTypes
        {
            public int id { get; set; }
            public string code { get; set; }
            public string name { get; set; }
            public string icon { get; set; }
        }
        /// <summary>
        /// Получение списка причин отключений
        /// </summary>
        public class ShutdownCauses
        {
            /// <summary>
            /// Идентификатор причины отключения
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// Код
            /// </summary>
            public string code { get; set; }
            /// <summary>
            /// Название
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// Идентфикатор организации
            /// </summary>
            public int organizationId { get; set; }
            /// <summary>
            /// Флаг системной причины (запрещено редактирование, удаление)
            /// </summary>
            public bool isSystem { get; set; }
            /// <summary>
            /// Системная причина отключения(родительская)
            /// </summary>
            public int systemShutdownCauseId { get; set; }
        }
        /// <summary>
        /// Получение списка видов работ
        /// </summary>
        public class WorkKinds
        {
            public int id { get; set; }
            public string code { get; set; }
            public string name { get; set; }
        }
        #endregion

        #region Классы возвращаемой с кодом ответа 400
        public class Errors
        {
            public List<string> WorkKindCode { get; set; }
            public List<string> OrganizationId { get; set; }
        }

        public class ShutdownsResponses400
        {
            public string title { get; set; }
            public int status { get; set; }
            public Errors errors { get; set; }
        }
        #endregion

        #region Классы возвращаемой с кодом ответа 200
        public class ShutdownsResponses200
        {
            public int id { get; set; }
            public int organizationId { get; set; }
            public int workKindId { get; set; }
            public int shutdownCauseId { get; set; }
            public string executorName { get; set; }
            public string executorPhone { get; set; }
            public DateTime startDate { get; set; }
            public DateTime endDate { get; set; }
            public string comment { get; set; }
            public DateTime completionDate { get; set; }
            public DateTime updated { get; set; }
            public int countShutDownHouses { get; set; }
            public string paginationToken { get; set; }
        }
        #endregion
        /// <summary>
        /// Отключение завершено
        /// /api/v1/Shutdowns/{id}
        /// </summary>
        public class ShutdownPatchDTO
        {
            /// <summary>
            /// /Дата завершения отключения
            /// </summary>
            public string completionDate { get; set; }
        }
    }
}
