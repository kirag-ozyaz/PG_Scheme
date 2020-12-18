using Documents.DataSets;
using Documents.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), DataObject(true), DesignerCategory("code"), ToolboxItem(true), HelpKeyword("vs.data.TableAdapter")]
internal class Class203 : Component
{
    private bool bool_0;
    private SqlCommand[] sqlCommand_0;
    private SqlConnection sqlConnection_0;
    private SqlDataAdapter sqlDataAdapter_0;
    private SqlTransaction sqlTransaction_0;

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Class203()
    {
        this.method_7(true);
    }

    protected internal SqlDataAdapter method_0()
    {
        if (this.sqlDataAdapter_0 == null)
        {
            this.method_8();
        }
        return this.sqlDataAdapter_0;
    }

    internal SqlConnection method_1()
    {
        if (this.sqlConnection_0 == null)
        {
            this.method_9();
        }
        return this.sqlConnection_0;
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void method_10()
    {
        this.sqlCommand_0 = new SqlCommand[10];
        this.sqlCommand_0[0] = new SqlCommand();
        this.sqlCommand_0[0].Connection = this.method_1();
        this.sqlCommand_0[0].CommandText = "SELECT        tblAbnAplForDisconObjects.Id, tblAbnAplForDisconObjects.IdAplForDiscon, tblAbnAplForDisconObjects.AbnId, tblAbnAplForDisconObjects.AbnObjId, \r\n                         tblAbnAplForDisconObjects.PlaceId, tblAbnAplForDisconObjects.Reason, tblAbnAplForDisconObjects.Comments, tAbnDoc_Dogovor.DogDate AS DateDog, \r\n                         tAbn.CodeAbonent AS Code, tAbn.Name AS NameShort, tAbnObj.Name AS AbnObj, tblAbnAplForDisconObjects.IdCancelApl, tblAbnAplForDisconObjects.DateExec, \r\n                         tblAbnAplForDisconObjects.FIOExec, tblAbnAplForDisconObjects.ReasonFailure, tblAbnAplForDisconObjects.NetAreaExec, tblAbnAplForDisconObjects.Officer, \r\n                         tblAbnAplForDisconReason.Reason AS ReasonCaption, tblAbnAplForDiscon.NumDoc AS CancelAplNumDoc, Division.Description AS NetAreaExecDescription, \r\n                         Worker.F + ' ' + Worker.I + ' ' + Worker.O AS FIOWorker, tblAbnAplForDisconObjects.NoDogAbn, tblAbnAplForDisconObjects.NoDogObj, \r\n                         tblAbnAplForDisconObjects.Matrix, tblAbnAplForDiscon.DateAppl, tblAbnAplForDiscon.TypeAction, tblAbnAplForDiscon.NetArea, tblAbnAplForDiscon.DateAction, \r\n                         tblAbnAplForDiscon.Sent, tblAbnAplForDisconObjects.IsFullRestriction\r\nFROM            tblAbnAplForDisconObjects LEFT OUTER JOIN\r\n                         tAbn ON tblAbnAplForDisconObjects.AbnId = tAbn.id LEFT OUTER JOIN\r\n                         tAbnDoc_Dogovor ON tblAbnAplForDisconObjects.AbnId = tAbnDoc_Dogovor.idAbn LEFT OUTER JOIN\r\n                         tAbnDoc_List ON tAbnDoc_Dogovor.idList = tAbnDoc_List.id LEFT OUTER JOIN\r\n                         tAbnObj ON tblAbnAplForDisconObjects.AbnObjId = tAbnObj.id LEFT OUTER JOIN\r\n                         tblAbnAplForDisconReason ON tblAbnAplForDisconObjects.Reason = tblAbnAplForDisconReason.Id LEFT OUTER JOIN\r\n                         tblAbnAplForDiscon ON tblAbnAplForDisconObjects.IdCancelApl = tblAbnAplForDiscon.Id LEFT OUTER JOIN\r\n                         tR_Division AS Division ON tblAbnAplForDisconObjects.NetAreaExec = Division.id LEFT OUTER JOIN\r\n                         tR_Worker AS Worker ON tblAbnAplForDisconObjects.FIOExec = Worker.id\r\nWHERE        (tblAbnAplForDisconObjects.IdAplForDiscon = @IdAplForDiscon) AND (tblAbnAplForDisconObjects.AbnId IS NULL) OR\r\n                         (tblAbnAplForDisconObjects.IdAplForDiscon = @IdAplForDiscon) AND (tblAbnAplForDisconObjects.AbnId IS NOT NULL) AND (tAbnDoc_List.isActive = 1)";
        this.sqlCommand_0[0].CommandType = CommandType.Text;
        this.sqlCommand_0[0].Parameters.Add(new SqlParameter("@IdAplForDiscon", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdAplForDiscon", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[1] = new SqlCommand();
        this.sqlCommand_0[1].Connection = this.method_1();
        this.sqlCommand_0[1].CommandText = "SELECT        tblAbnAplForDisconObjects.Id, tblAbnAplForDisconObjects.IdAplForDiscon, tblAbnAplForDisconObjects.AbnId, tblAbnAplForDisconObjects.AbnObjId, \r\n                         tblAbnAplForDisconObjects.PlaceId, tblAbnAplForDisconObjects.Reason, tblAbnAplForDisconObjects.Comments, tAbnDoc_Dogovor.DogDate AS DateDog, \r\n                         tAbn.CodeAbonent AS Code, tAbn.Name AS NameShort, tAbnObj.Name AS AbnObj, tblAbnAplForDisconObjects.IdCancelApl, tblAbnAplForDisconObjects.DateExec, \r\n                         tblAbnAplForDisconObjects.FIOExec, tblAbnAplForDisconObjects.ReasonFailure, tblAbnAplForDisconObjects.NetAreaExec, tblAbnAplForDisconObjects.Officer, \r\n                         tblAbnAplForDisconReason.Reason AS ReasonCaption, tblAbnAplForDiscon.NumDoc AS CancelAplNumDoc, Division.Description AS NetAreaExecDescription, \r\n                         Worker.F + ' ' + Worker.I + ' ' + Worker.O AS FIOWorker, tblAbnAplForDisconObjects.NoDogAbn, tblAbnAplForDisconObjects.NoDogObj, \r\n                         tblAbnAplForDisconObjects.Matrix, tblAbnAplForDiscon.DateAppl, tblAbnAplForDiscon.TypeAction, tblAbnAplForDiscon.NetArea, tblAbnAplForDiscon.DateAction, \r\n                         tblAbnAplForDiscon.Sent, tblAbnAplForDisconObjects.IsFullRestriction\r\nFROM            tblAbnAplForDisconObjects LEFT OUTER JOIN\r\n                         tAbn ON tblAbnAplForDisconObjects.AbnId = tAbn.id LEFT OUTER JOIN\r\n                         tAbnDoc_Dogovor ON tblAbnAplForDisconObjects.AbnId = tAbnDoc_Dogovor.idAbn LEFT OUTER JOIN\r\n                         tAbnDoc_List ON tAbnDoc_Dogovor.idList = tAbnDoc_List.id LEFT OUTER JOIN\r\n                         tAbnObj ON tblAbnAplForDisconObjects.AbnObjId = tAbnObj.id LEFT OUTER JOIN\r\n                         tblAbnAplForDisconReason ON tblAbnAplForDisconObjects.Reason = tblAbnAplForDisconReason.Id LEFT OUTER JOIN\r\n                         tblAbnAplForDiscon ON tblAbnAplForDisconObjects.IdCancelApl = tblAbnAplForDiscon.Id LEFT OUTER JOIN\r\n                         tR_Division AS Division ON tblAbnAplForDisconObjects.NetAreaExec = Division.id LEFT OUTER JOIN\r\n                         tR_Worker AS Worker ON tblAbnAplForDisconObjects.FIOExec = Worker.id\r\nWHERE        (tblAbnAplForDisconObjects.AbnId IS NULL) AND (tblAbnAplForDisconObjects.NoDogAbn LIKE @name) OR\r\n                         (tblAbnAplForDisconObjects.AbnId IS NOT NULL) AND (tAbnDoc_List.isActive = 1) AND (tAbn.Name LIKE @name)";
        this.sqlCommand_0[1].CommandType = CommandType.Text;
        this.sqlCommand_0[1].Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 0x7fffffff, ParameterDirection.Input, 0, 0, "NoDogAbn", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[2] = new SqlCommand();
        this.sqlCommand_0[2].Connection = this.method_1();
        this.sqlCommand_0[2].CommandText = "SELECT        tblAbnAplForDisconObjects.Id, tblAbnAplForDisconObjects.IdAplForDiscon, tblAbnAplForDisconObjects.AbnId, tblAbnAplForDisconObjects.AbnObjId, \r\n                         tblAbnAplForDisconObjects.PlaceId, tblAbnAplForDisconObjects.Reason, tblAbnAplForDisconObjects.Comments, tAbnDoc_Dogovor.DogDate AS DateDog, \r\n                         tAbn.CodeAbonent AS Code, tAbn.Name AS NameShort, tAbnObj.Name AS AbnObj, tblAbnAplForDisconObjects.IdCancelApl, tblAbnAplForDisconObjects.DateExec, \r\n                         tblAbnAplForDisconObjects.FIOExec, tblAbnAplForDisconObjects.ReasonFailure, tblAbnAplForDisconObjects.NetAreaExec, tblAbnAplForDisconObjects.Officer, \r\n                         tblAbnAplForDisconReason.Reason AS ReasonCaption, tblAbnAplForDiscon.NumDoc AS CancelAplNumDoc, Division.Description AS NetAreaExecDescription, \r\n                         Worker.F + ' ' + Worker.I + ' ' + Worker.O AS FIOWorker, tblAbnAplForDisconObjects.NoDogAbn, tblAbnAplForDisconObjects.NoDogObj, \r\n                         tblAbnAplForDisconObjects.Matrix, tblAbnAplForDisconObjects.IsFullRestriction\r\nFROM            tblAbnAplForDisconObjects LEFT OUTER JOIN\r\n                         tAbn ON tblAbnAplForDisconObjects.AbnId = tAbn.id LEFT OUTER JOIN\r\n                         tAbnDoc_Dogovor ON tblAbnAplForDisconObjects.AbnId = tAbnDoc_Dogovor.idAbn LEFT OUTER JOIN\r\n                         tAbnDoc_List ON tAbnDoc_Dogovor.idList = tAbnDoc_List.id LEFT OUTER JOIN\r\n                         tAbnObj ON tblAbnAplForDisconObjects.AbnObjId = tAbnObj.id LEFT OUTER JOIN\r\n                         tblAbnAplForDisconReason ON tblAbnAplForDisconObjects.Reason = tblAbnAplForDisconReason.Id LEFT OUTER JOIN\r\n                         tblAbnAplForDiscon ON tblAbnAplForDisconObjects.IdCancelApl = tblAbnAplForDiscon.Id LEFT OUTER JOIN\r\n                         tR_Division AS Division ON tblAbnAplForDisconObjects.NetAreaExec = Division.id LEFT OUTER JOIN\r\n                         tR_Worker AS Worker ON tblAbnAplForDisconObjects.FIOExec = Worker.id\r\nWHERE        (tblAbnAplForDisconObjects.Id = @Id) AND (tblAbnAplForDisconObjects.AbnId IS NULL) OR\r\n                         (tblAbnAplForDisconObjects.Id = @Id) AND (tblAbnAplForDisconObjects.AbnId IS NOT NULL) AND (tAbnDoc_List.isActive = 1)";
        this.sqlCommand_0[2].CommandType = CommandType.Text;
        this.sqlCommand_0[2].Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[3] = new SqlCommand();
        this.sqlCommand_0[3].Connection = this.method_1();
        this.sqlCommand_0[3].CommandText = "SELECT        tblAbnAplForDisconObjects.Id, tblAbnAplForDisconObjects.IdAplForDiscon, tblAbnAplForDisconObjects.AbnId, tblAbnAplForDisconObjects.AbnObjId, \r\n                         tblAbnAplForDisconObjects.PlaceId, tblAbnAplForDisconObjects.Reason, tblAbnAplForDisconObjects.Comments, tAbnDoc_Dogovor.DogDate AS DateDog, \r\n                         tAbn.CodeAbonent AS Code, tAbn.Name AS NameShort, tAbnObj.Name AS AbnObj, tblAbnAplForDisconObjects.IdCancelApl, tblAbnAplForDisconObjects.DateExec, \r\n                         tblAbnAplForDisconObjects.FIOExec, tblAbnAplForDisconObjects.ReasonFailure, tblAbnAplForDisconObjects.NetAreaExec, tblAbnAplForDisconObjects.Officer, \r\n                         tblAbnAplForDisconReason.Reason AS ReasonCaption, tblAbnAplForDiscon.NumDoc AS CancelAplNumDoc, Division.Description AS NetAreaExecDescription, \r\n                         Worker.F + ' ' + Worker.I + ' ' + Worker.O AS FIOWorker, tblAbnAplForDisconObjects.NoDogAbn, tblAbnAplForDisconObjects.NoDogObj, \r\n                         tblAbnAplForDisconObjects.Matrix, tblAbnAplForDiscon.DateAppl, tblAbnAplForDiscon.TypeAction, tblAbnAplForDiscon.NetArea, tblAbnAplForDiscon.DateAction, \r\n                         tblAbnAplForDiscon.Sent, tblAbnAplForDisconObjects.IsFullRestriction\r\nFROM            tblAbnAplForDisconObjects LEFT OUTER JOIN\r\n                         tAbn ON tblAbnAplForDisconObjects.AbnId = tAbn.id LEFT OUTER JOIN\r\n                         tAbnDoc_Dogovor ON tblAbnAplForDisconObjects.AbnId = tAbnDoc_Dogovor.idAbn LEFT OUTER JOIN\r\n                         tAbnDoc_List ON tAbnDoc_Dogovor.idList = tAbnDoc_List.id LEFT OUTER JOIN\r\n                         tAbnObj ON tblAbnAplForDisconObjects.AbnObjId = tAbnObj.id LEFT OUTER JOIN\r\n                         tblAbnAplForDisconReason ON tblAbnAplForDisconObjects.Reason = tblAbnAplForDisconReason.Id LEFT OUTER JOIN\r\n                         tblAbnAplForDiscon ON tblAbnAplForDisconObjects.IdCancelApl = tblAbnAplForDiscon.Id LEFT OUTER JOIN\r\n                         tR_Division AS Division ON tblAbnAplForDisconObjects.NetAreaExec = Division.id LEFT OUTER JOIN\r\n                         tR_Worker AS Worker ON tblAbnAplForDisconObjects.FIOExec = Worker.id\r\nWHERE        (tAbnDoc_List.isActive = 1) AND (tblAbnAplForDisconObjects.AbnId IS NOT NULL) AND (tAbnObj.Name LIKE @name)";
        this.sqlCommand_0[3].CommandType = CommandType.Text;
        this.sqlCommand_0[3].Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 0xff, ParameterDirection.Input, 0, 0, "AbnObj", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[4] = new SqlCommand();
        this.sqlCommand_0[4].Connection = this.method_1();
        this.sqlCommand_0[4].CommandText = "SELECT        tblAbnAplForDisconObjects.Id, tblAbnAplForDisconObjects.IdAplForDiscon, tblAbnAplForDisconObjects.AbnId, tblAbnAplForDisconObjects.AbnObjId, \r\n                         tblAbnAplForDisconObjects.PlaceId, tblAbnAplForDisconObjects.Reason, tblAbnAplForDisconObjects.Comments, tAbnDoc_Dogovor.DogDate AS DateDog, \r\n                         tAbn.CodeAbonent AS Code, tAbn.Name AS NameShort, tAbnObj.Name AS AbnObj, tblAbnAplForDisconObjects.IdCancelApl, tblAbnAplForDisconObjects.DateExec, \r\n                         tblAbnAplForDisconObjects.FIOExec, tblAbnAplForDisconObjects.ReasonFailure, tblAbnAplForDisconObjects.NetAreaExec, tblAbnAplForDisconObjects.Officer, \r\n                         tblAbnAplForDisconReason.Reason AS ReasonCaption, tblAbnAplForDiscon.NumDoc AS CancelAplNumDoc, Division.Description AS NetAreaExecDescription, \r\n                         Worker.F + ' ' + Worker.I + ' ' + Worker.O AS FIOWorker, tblAbnAplForDisconObjects.NoDogAbn, tblAbnAplForDisconObjects.NoDogObj, \r\n                         tblAbnAplForDisconObjects.Matrix, tblAbnAplForDiscon.DateAppl, tblAbnAplForDiscon.TypeAction, tblAbnAplForDiscon.NetArea, tblAbnAplForDiscon.DateAction, \r\n                         tblAbnAplForDiscon.Sent, tblAbnAplForDisconObjects.IsFullRestriction\r\nFROM            tblAbnAplForDisconObjects LEFT OUTER JOIN\r\n                         tAbn ON tblAbnAplForDisconObjects.AbnId = tAbn.id LEFT OUTER JOIN\r\n                         tAbnDoc_Dogovor ON tblAbnAplForDisconObjects.AbnId = tAbnDoc_Dogovor.idAbn LEFT OUTER JOIN\r\n                         tAbnDoc_List ON tAbnDoc_Dogovor.idList = tAbnDoc_List.id LEFT OUTER JOIN\r\n                         tAbnObj ON tblAbnAplForDisconObjects.AbnObjId = tAbnObj.id LEFT OUTER JOIN\r\n                         tblAbnAplForDisconReason ON tblAbnAplForDisconObjects.Reason = tblAbnAplForDisconReason.Id LEFT OUTER JOIN\r\n                         tblAbnAplForDiscon ON tblAbnAplForDisconObjects.IdCancelApl = tblAbnAplForDiscon.Id LEFT OUTER JOIN\r\n                         tR_Division AS Division ON tblAbnAplForDisconObjects.NetAreaExec = Division.id LEFT OUTER JOIN\r\n                         tR_Worker AS Worker ON tblAbnAplForDisconObjects.FIOExec = Worker.id INNER JOIN\r\n                         tblAbnAplForDiscon AS apl ON apl.Id = tblAbnAplForDisconObjects.IdAplForDiscon AND apl.TypeAction = 0\r\nWHERE        (tblAbnAplForDisconObjects.IdAplForDiscon = @IdAplForDiscon) AND (tblAbnAplForDisconObjects.AbnId IS NOT NULL) AND (tAbnDoc_List.isActive = 1) AND \r\n                         (tblAbnAplForDisconObjects.IdCancelApl IS NULL) AND (tblAbnAplForDisconObjects.DateExec IS NOT NULL) AND \r\n                         (tblAbnAplForDisconObjects.AbnObjId NOT IN\r\n                             (SELECT        obj1.AbnObjId\r\n                               FROM            tblAbnAplForDisconObjects AS obj1 INNER JOIN\r\n                                                         tblAbnAplForDiscon AS apl1 ON obj1.IdAplForDiscon = apl1.Id AND apl1.TypeAction = 1\r\n                               WHERE        (obj1.IdCancelApl IS NULL) AND (obj1.DateExec IS NOT NULL) AND (obj1.AbnId IS NOT NULL) AND (apl.DateAppl < apl1.DateAppl)))";
        this.sqlCommand_0[4].CommandType = CommandType.Text;
        this.sqlCommand_0[4].Parameters.Add(new SqlParameter("@IdAplForDiscon", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdAplForDiscon", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[5] = new SqlCommand();
        this.sqlCommand_0[5].Connection = this.method_1();
        this.sqlCommand_0[5].CommandText = "SELECT        tblAbnAplForDisconObjects.Id, tblAbnAplForDisconObjects.IdAplForDiscon, tblAbnAplForDisconObjects.AbnId, tblAbnAplForDisconObjects.AbnObjId, \r\n                         tblAbnAplForDisconObjects.PlaceId, tblAbnAplForDisconObjects.Reason, tblAbnAplForDisconObjects.Comments, tAbnDoc_Dogovor.DogDate AS DateDog, \r\n                         tAbn.CodeAbonent AS Code, tAbn.Name AS NameShort, tAbnObj.Name AS AbnObj, tblAbnAplForDisconObjects.IdCancelApl, tblAbnAplForDisconObjects.DateExec, \r\n                         tblAbnAplForDisconObjects.FIOExec, tblAbnAplForDisconObjects.ReasonFailure, tblAbnAplForDisconObjects.NetAreaExec, tblAbnAplForDisconObjects.Officer, \r\n                         tblAbnAplForDisconReason.Reason AS ReasonCaption, tblAbnAplForDiscon.NumDoc AS CancelAplNumDoc, Division.Description AS NetAreaExecDescription, \r\n                         Worker.F + ' ' + Worker.I + ' ' + Worker.O AS FIOWorker, tblAbnAplForDisconObjects.NoDogAbn, tblAbnAplForDisconObjects.NoDogObj, \r\n                         tblAbnAplForDisconObjects.Matrix, tblAbnAplForDiscon.TypeAction, tblAbnAplForDiscon.DateAppl, tblAbnAplForDiscon.NetArea, tblAbnAplForDiscon.Sent, \r\n                         tblAbnAplForDiscon.DateAction, tblAbnAplForDisconObjects.IsFullRestriction\r\nFROM            tblAbnAplForDisconObjects LEFT OUTER JOIN\r\n                         tAbn ON tblAbnAplForDisconObjects.AbnId = tAbn.id LEFT OUTER JOIN\r\n                         tAbnDoc_Dogovor ON tblAbnAplForDisconObjects.AbnId = tAbnDoc_Dogovor.idAbn LEFT OUTER JOIN\r\n                         tAbnDoc_List ON tAbnDoc_Dogovor.idList = tAbnDoc_List.id LEFT OUTER JOIN\r\n                         tAbnObj ON tblAbnAplForDisconObjects.AbnObjId = tAbnObj.id LEFT OUTER JOIN\r\n                         tblAbnAplForDisconReason ON tblAbnAplForDisconObjects.Reason = tblAbnAplForDisconReason.Id LEFT OUTER JOIN\r\n                         tblAbnAplForDiscon ON tblAbnAplForDisconObjects.IdAplForDiscon = tblAbnAplForDiscon.Id LEFT OUTER JOIN\r\n                         tR_Division AS Division ON tblAbnAplForDisconObjects.NetAreaExec = Division.id LEFT OUTER JOIN\r\n                         tR_Worker AS Worker ON tblAbnAplForDisconObjects.FIOExec = Worker.id\r\nWHERE        (tblAbnAplForDisconObjects.DateExec IS NULL) AND (tblAbnAplForDiscon.DateAction < @BegPer) AND (tblAbnAplForDisconObjects.IdCancelApl IS NULL) AND \r\n                         (tblAbnAplForDisconObjects.AbnId IS NULL) OR\r\n                         (tblAbnAplForDisconObjects.DateExec IS NULL) AND (tblAbnAplForDiscon.DateAction < @BegPer) AND (tblAbnAplForDisconObjects.IdCancelApl IS NULL) AND \r\n                         (tblAbnAplForDisconObjects.AbnId IS NOT NULL) AND (tAbnDoc_List.isActive = 1)";
        this.sqlCommand_0[5].CommandType = CommandType.Text;
        this.sqlCommand_0[5].Parameters.Add(new SqlParameter("@BegPer", SqlDbType.DateTime, 8, ParameterDirection.Input, 0, 0, "DateAction", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[6] = new SqlCommand();
        this.sqlCommand_0[6].Connection = this.method_1();
        this.sqlCommand_0[6].CommandText = "UPDATE       tblAbnAplForDisconObjects\r\nSET                IdCancelApl = NULL\r\nWHERE        (AbnObjId = @AbnObjId) AND (IdCancelApl = @IdCancelApl)";
        this.sqlCommand_0[6].CommandType = CommandType.Text;
        this.sqlCommand_0[6].Parameters.Add(new SqlParameter("@AbnObjId", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "AbnObjId", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlCommand_0[6].Parameters.Add(new SqlParameter("@IdCancelApl", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdCancelApl", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlCommand_0[7] = new SqlCommand();
        this.sqlCommand_0[7].Connection = this.method_1();
        this.sqlCommand_0[7].CommandText = "UPDATE       tblAbnAplForDisconObjects\r\nSET                IdCancelApl = NULL\r\nWHERE        (NoDogObj = @NoDogObj) AND (IdCancelApl = @IdCancelApl)";
        this.sqlCommand_0[7].CommandType = CommandType.Text;
        this.sqlCommand_0[7].Parameters.Add(new SqlParameter("@NoDogObj", SqlDbType.VarChar, 0x7fffffff, ParameterDirection.Input, 0, 0, "NoDogObj", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlCommand_0[7].Parameters.Add(new SqlParameter("@IdCancelApl", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdCancelApl", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlCommand_0[8] = new SqlCommand();
        this.sqlCommand_0[8].Connection = this.method_1();
        this.sqlCommand_0[8].CommandText = "UPDATE       tblAbnAplForDisconObjects\r\nSET                IdCancelApl = @IdCancelApl\r\nWHERE        (IdAplForDiscon = @idAplForDiscon) AND (NoDogObj = @NoDogObj)";
        this.sqlCommand_0[8].CommandType = CommandType.Text;
        this.sqlCommand_0[8].Parameters.Add(new SqlParameter("@IdCancelApl", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdCancelApl", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[8].Parameters.Add(new SqlParameter("@idAplForDiscon", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdAplForDiscon", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlCommand_0[8].Parameters.Add(new SqlParameter("@NoDogObj", SqlDbType.VarChar, 0xff, ParameterDirection.Input, 0, 0, "NoDogObj", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlCommand_0[9] = new SqlCommand();
        this.sqlCommand_0[9].Connection = this.method_1();
        this.sqlCommand_0[9].CommandText = "UPDATE       tblAbnAplForDisconObjects\r\nSET                IdCancelApl = @IdCancelApl\r\nWHERE        (AbnObjId = @AbnObjId) AND (IdAplForDiscon = @idAplForDiscon)";
        this.sqlCommand_0[9].CommandType = CommandType.Text;
        this.sqlCommand_0[9].Parameters.Add(new SqlParameter("@IdCancelApl", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdCancelApl", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[9].Parameters.Add(new SqlParameter("@AbnObjId", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "AbnObjId", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlCommand_0[9].Parameters.Add(new SqlParameter("@idAplForDiscon", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdAplForDiscon", DataRowVersion.Original, false, null, "", "", ""));
    }

    internal void method_2(SqlConnection sqlConnection_1)
    {
        this.sqlConnection_0 = sqlConnection_1;
        if (this.method_0().InsertCommand != null)
        {
            this.method_0().InsertCommand.Connection = sqlConnection_1;
        }
        if (this.method_0().DeleteCommand != null)
        {
            this.method_0().DeleteCommand.Connection = sqlConnection_1;
        }
        if (this.method_0().UpdateCommand != null)
        {
            this.method_0().UpdateCommand.Connection = sqlConnection_1;
        }
        for (int i = 0; i < this.method_5().Length; i++)
        {
            if (this.method_5()[i] != null)
            {
                this.method_5()[i].Connection = sqlConnection_1;
            }
        }
    }

    internal SqlTransaction method_3()
    {
        return this.sqlTransaction_0;
    }

    internal void method_4(SqlTransaction sqlTransaction_1)
    {
        this.sqlTransaction_0 = sqlTransaction_1;
        for (int i = 0; i < this.method_5().Length; i++)
        {
            this.method_5()[i].Transaction = this.sqlTransaction_0;
        }
        if ((this.method_0() != null) && (this.method_0().DeleteCommand != null))
        {
            this.method_0().DeleteCommand.Transaction = this.sqlTransaction_0;
        }
        if ((this.method_0() != null) && (this.method_0().InsertCommand != null))
        {
            this.method_0().InsertCommand.Transaction = this.sqlTransaction_0;
        }
        if ((this.method_0() != null) && (this.method_0().UpdateCommand != null))
        {
            this.method_0().UpdateCommand.Transaction = this.sqlTransaction_0;
        }
    }

    protected SqlCommand[] method_5()
    {
        if (this.sqlCommand_0 == null)
        {
            this.method_10();
        }
        return this.sqlCommand_0;
    }

    public bool method_6()
    {
        return this.bool_0;
    }

    public void method_7(bool bool_1)
    {
        this.bool_0 = bool_1;
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void method_8()
    {
        this.sqlDataAdapter_0 = new SqlDataAdapter();
        DataTableMapping mapping = new DataTableMapping {
            SourceTable = "Table",
            DataSetTable = "tblAbnAplForDisconObjects",
            ColumnMappings = { 
                { 
                    "Id",
                    "Id"
                },
                { 
                    "IdAplForDiscon",
                    "IdAplForDiscon"
                },
                { 
                    "AbnId",
                    "AbnId"
                },
                { 
                    "AbnObjId",
                    "AbnObjId"
                },
                { 
                    "PlaceId",
                    "PlaceId"
                },
                { 
                    "Reason",
                    "Reason"
                },
                { 
                    "Comments",
                    "Comments"
                },
                { 
                    "DateDog",
                    "DateDog"
                },
                { 
                    "Code",
                    "Code"
                },
                { 
                    "NameShort",
                    "NameShort"
                },
                { 
                    "AbnObj",
                    "AbnObj"
                },
                { 
                    "IdCancelApl",
                    "IdCancelApl"
                },
                { 
                    "DateExec",
                    "DateExec"
                },
                { 
                    "FIOExec",
                    "FIOExec"
                },
                { 
                    "ReasonFailure",
                    "ReasonFailure"
                },
                { 
                    "NetAreaExec",
                    "NetAreaExec"
                },
                { 
                    "Officer",
                    "Officer"
                },
                { 
                    "ReasonCaption",
                    "ReasonCaption"
                },
                { 
                    "CancelAplNumDoc",
                    "CancelAplNumDoc"
                },
                { 
                    "NetAreaExecDescription",
                    "NetAreaExecDescription"
                },
                { 
                    "FIOWorker",
                    "FIOWorker"
                },
                { 
                    "NoDogAbn",
                    "NoDogAbn"
                },
                { 
                    "NoDogObj",
                    "NoDogObj"
                },
                { 
                    "Matrix",
                    "Matrix"
                },
                { 
                    "DateAppl",
                    "DateAppl"
                },
                { 
                    "TypeAction",
                    "TypeAction"
                },
                { 
                    "NetArea",
                    "NetArea"
                },
                { 
                    "DateAction",
                    "DateAction"
                },
                { 
                    "Sent",
                    "Sent"
                },
                { 
                    "IsFullRestriction",
                    "IsFullRestriction"
                }
            }
        };
        this.sqlDataAdapter_0.TableMappings.Add(mapping);
        this.sqlDataAdapter_0.DeleteCommand = new SqlCommand();
        this.sqlDataAdapter_0.DeleteCommand.Connection = this.method_1();
        this.sqlDataAdapter_0.DeleteCommand.CommandText = "DELETE FROM tblAbnAplForDisconObjects\r\nWHERE        (Id = @Original_Id)";
        this.sqlDataAdapter_0.DeleteCommand.CommandType = CommandType.Text;
        this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand = new SqlCommand();
        this.sqlDataAdapter_0.InsertCommand.Connection = this.method_1();
        this.sqlDataAdapter_0.InsertCommand.CommandText = "INSERT INTO tblAbnAplForDisconObjects\r\n                         (IdAplForDiscon, AbnId, AbnObjId, PlaceId, Reason, Comments, IdCancelApl, DateExec, FIOExec, ReasonFailure, NetAreaExec, Officer, NoDogAbn, NoDogObj, Matrix, \r\n                         IsFullRestriction)\r\nVALUES        (@IdAplForDiscon,@AbnId,@AbnObjId,@PlaceId,@Reason,@Comments,@IdCancelApl,@DateExec,@FIOExec,@ReasonFailure,@NetAreaExec,@Officer,@NoDogAbn,@NoDogObj,@Matrix,@IsFullRestriction);          \r\nSELECT Id, IdAplForDiscon, AbnId, AbnObjId, PlaceId, Reason, Comments FROM tblAbnAplForDisconObjects WHERE (Id = @Id)";
        this.sqlDataAdapter_0.InsertCommand.CommandType = CommandType.Text;
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@IdAplForDiscon", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdAplForDiscon", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@AbnId", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "AbnId", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@AbnObjId", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "AbnObjId", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@PlaceId", SqlDbType.VarChar, 0xff, ParameterDirection.Input, 0, 0, "PlaceId", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Reason", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Reason", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Comments", SqlDbType.VarChar, 0xff, ParameterDirection.Input, 0, 0, "Comments", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@IdCancelApl", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdCancelApl", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@DateExec", SqlDbType.DateTime, 8, ParameterDirection.Input, 0, 0, "DateExec", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@FIOExec", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "FIOExec", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@ReasonFailure", SqlDbType.VarChar, 500, ParameterDirection.Input, 0, 0, "ReasonFailure", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@NetAreaExec", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "NetAreaExec", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Officer", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, "Officer", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@NoDogAbn", SqlDbType.VarChar, 0x7fffffff, ParameterDirection.Input, 0, 0, "NoDogAbn", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@NoDogObj", SqlDbType.VarChar, 0x7fffffff, ParameterDirection.Input, 0, 0, "NoDogObj", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Matrix", SqlDbType.Bit, 1, ParameterDirection.Input, 0, 0, "Matrix", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@IsFullRestriction", SqlDbType.Bit, 1, ParameterDirection.Input, 0, 0, "IsFullRestriction", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand = new SqlCommand();
        this.sqlDataAdapter_0.UpdateCommand.Connection = this.method_1();
        this.sqlDataAdapter_0.UpdateCommand.CommandText = "UPDATE       tblAbnAplForDisconObjects\r\nSET                IdAplForDiscon = @IdAplForDiscon, AbnId = @AbnId, AbnObjId = @AbnObjId, PlaceId = @PlaceId, Reason = @Reason, Comments = @Comments, \r\n                         IdCancelApl = @IdCancelApl, DateExec = @DateExec, FIOExec = @FIOExec, ReasonFailure = @ReasonFailure, NetAreaExec = @NetAreaExec, Officer = @Officer, \r\n                         NoDogAbn = @NoDogAbn, NoDogObj = @NoDogObj, Matrix = @Matrix, IsFullRestriction = @IsFullRestriction\r\nWHERE        (Id = @Original_Id)";
        this.sqlDataAdapter_0.UpdateCommand.CommandType = CommandType.Text;
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IdAplForDiscon", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdAplForDiscon", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@AbnId", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "AbnId", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@AbnObjId", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "AbnObjId", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@PlaceId", SqlDbType.VarChar, 0xff, ParameterDirection.Input, 0, 0, "PlaceId", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Reason", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Reason", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Comments", SqlDbType.VarChar, 0xff, ParameterDirection.Input, 0, 0, "Comments", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IdCancelApl", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdCancelApl", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@DateExec", SqlDbType.DateTime, 8, ParameterDirection.Input, 0, 0, "DateExec", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@FIOExec", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "FIOExec", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@ReasonFailure", SqlDbType.VarChar, 500, ParameterDirection.Input, 0, 0, "ReasonFailure", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@NetAreaExec", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "NetAreaExec", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Officer", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, "Officer", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@NoDogAbn", SqlDbType.VarChar, 0x7fffffff, ParameterDirection.Input, 0, 0, "NoDogAbn", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@NoDogObj", SqlDbType.VarChar, 0x7fffffff, ParameterDirection.Input, 0, 0, "NoDogObj", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Matrix", SqlDbType.Bit, 1, ParameterDirection.Input, 0, 0, "Matrix", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsFullRestriction", SqlDbType.Bit, 1, ParameterDirection.Input, 0, 0, "IsFullRestriction", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Original, false, null, "", "", ""));
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void method_9()
    {
        this.sqlConnection_0 = new SqlConnection();
        this.sqlConnection_0.ConnectionString = Settings.Default.trueGESConnectionString;
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Fill, true), HelpKeyword("vs.data.TableAdapter")]
    public virtual int vmethod_0(OrgDataSet.tblAbnAplForDisconObjectsDataTable tblAbnAplForDisconObjectsDataTable_0, int? nullable_0)
    {
        this.method_0().SelectCommand = this.method_5()[0];
        if (nullable_0.HasValue)
        {
            this.method_0().SelectCommand.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        if (this.method_6())
        {
            tblAbnAplForDisconObjectsDataTable_0.Clear();
        }
        return this.method_0().Fill(tblAbnAplForDisconObjectsDataTable_0);
    }

    [DataObjectMethod(DataObjectMethodType.Select, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
    public virtual OrgDataSet.tblAbnAplForDisconObjectsDataTable vmethod_1(int? nullable_0)
    {
        this.method_0().SelectCommand = this.method_5()[0];
        if (nullable_0.HasValue)
        {
            this.method_0().SelectCommand.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        OrgDataSet.tblAbnAplForDisconObjectsDataTable dataTable = new OrgDataSet.tblAbnAplForDisconObjectsDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Fill, false)]
    public virtual int vmethod_10(OrgDataSet.tblAbnAplForDisconObjectsDataTable tblAbnAplForDisconObjectsDataTable_0, DateTime? nullable_0)
    {
        this.method_0().SelectCommand = this.method_5()[5];
        if (nullable_0.HasValue)
        {
            this.method_0().SelectCommand.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        if (this.method_6())
        {
            tblAbnAplForDisconObjectsDataTable_0.Clear();
        }
        return this.method_0().Fill(tblAbnAplForDisconObjectsDataTable_0);
    }

    [DataObjectMethod(DataObjectMethodType.Select, false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
    public virtual OrgDataSet.tblAbnAplForDisconObjectsDataTable vmethod_11(DateTime? nullable_0)
    {
        this.method_0().SelectCommand = this.method_5()[5];
        if (nullable_0.HasValue)
        {
            this.method_0().SelectCommand.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        OrgDataSet.tblAbnAplForDisconObjectsDataTable dataTable = new OrgDataSet.tblAbnAplForDisconObjectsDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
    public virtual int vmethod_12(OrgDataSet.tblAbnAplForDisconObjectsDataTable tblAbnAplForDisconObjectsDataTable_0)
    {
        return this.method_0().Update(tblAbnAplForDisconObjectsDataTable_0);
    }

    [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    public virtual int vmethod_13(OrgDataSet orgDataSet_0)
    {
        return this.method_0().Update(orgDataSet_0, "tblAbnAplForDisconObjects");
    }

    [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    public virtual int vmethod_14(DataRow dataRow_0)
    {
        DataRow[] dataRows = new DataRow[] { dataRow_0 };
        return this.method_0().Update(dataRows);
    }

    [DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_15(DataRow[] dataRow_0)
    {
        return this.method_0().Update(dataRow_0);
    }

    [DataObjectMethod(DataObjectMethodType.Delete, true), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_16(int? nullable_0)
    {
        int num;
        if (nullable_0.HasValue)
        {
            this.method_0().DeleteCommand.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().DeleteCommand.Parameters[0].Value = DBNull.Value;
        }
        ConnectionState state = this.method_0().DeleteCommand.Connection.State;
        if ((this.method_0().DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            this.method_0().DeleteCommand.Connection.Open();
        }
        try
        {
            num = this.method_0().DeleteCommand.ExecuteNonQuery();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                this.method_0().DeleteCommand.Connection.Close();
            }
        }
        return num;
    }

    [DataObjectMethod(DataObjectMethodType.Insert, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
    public virtual int vmethod_17(int? nullable_0, int? nullable_1, int? nullable_2, string string_0, int? nullable_3, string string_1, int? nullable_4, DateTime? nullable_5, int? nullable_6, string string_2, int? nullable_7, string string_3, string string_4, string string_5, bool? nullable_8, bool? nullable_9, int int_0)
    {
        int num;
        if (nullable_0.HasValue)
        {
            this.method_0().InsertCommand.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[0].Value = DBNull.Value;
        }
        if (nullable_1.HasValue)
        {
            this.method_0().InsertCommand.Parameters[1].Value = nullable_1.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[1].Value = DBNull.Value;
        }
        if (nullable_2.HasValue)
        {
            this.method_0().InsertCommand.Parameters[2].Value = nullable_2.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[2].Value = DBNull.Value;
        }
        if (string_0 == null)
        {
            this.method_0().InsertCommand.Parameters[3].Value = DBNull.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[3].Value = string_0;
        }
        if (nullable_3.HasValue)
        {
            this.method_0().InsertCommand.Parameters[4].Value = nullable_3.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[4].Value = DBNull.Value;
        }
        if (string_1 == null)
        {
            this.method_0().InsertCommand.Parameters[5].Value = DBNull.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[5].Value = string_1;
        }
        if (nullable_4.HasValue)
        {
            this.method_0().InsertCommand.Parameters[6].Value = nullable_4.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[6].Value = DBNull.Value;
        }
        if (nullable_5.HasValue)
        {
            this.method_0().InsertCommand.Parameters[7].Value = nullable_5.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[7].Value = DBNull.Value;
        }
        if (nullable_6.HasValue)
        {
            this.method_0().InsertCommand.Parameters[8].Value = nullable_6.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[8].Value = DBNull.Value;
        }
        if (string_2 == null)
        {
            this.method_0().InsertCommand.Parameters[9].Value = DBNull.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[9].Value = string_2;
        }
        if (nullable_7.HasValue)
        {
            this.method_0().InsertCommand.Parameters[10].Value = nullable_7.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[10].Value = DBNull.Value;
        }
        if (string_3 == null)
        {
            this.method_0().InsertCommand.Parameters[11].Value = DBNull.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[11].Value = string_3;
        }
        if (string_4 == null)
        {
            this.method_0().InsertCommand.Parameters[12].Value = DBNull.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[12].Value = string_4;
        }
        if (string_5 == null)
        {
            this.method_0().InsertCommand.Parameters[13].Value = DBNull.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[13].Value = string_5;
        }
        if (nullable_8.HasValue)
        {
            this.method_0().InsertCommand.Parameters[14].Value = nullable_8.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[14].Value = DBNull.Value;
        }
        if (nullable_9.HasValue)
        {
            this.method_0().InsertCommand.Parameters[15].Value = nullable_9.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[15].Value = DBNull.Value;
        }
        this.method_0().InsertCommand.Parameters[0x10].Value = int_0;
        ConnectionState state = this.method_0().InsertCommand.Connection.State;
        if ((this.method_0().InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            this.method_0().InsertCommand.Connection.Open();
        }
        try
        {
            num = this.method_0().InsertCommand.ExecuteNonQuery();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                this.method_0().InsertCommand.Connection.Close();
            }
        }
        return num;
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Update, true), HelpKeyword("vs.data.TableAdapter")]
    public virtual int vmethod_18(int? nullable_0, int? nullable_1, int? nullable_2, string string_0, int? nullable_3, string string_1, int? nullable_4, DateTime? nullable_5, int? nullable_6, string string_2, int? nullable_7, string string_3, string string_4, string string_5, bool? nullable_8, bool? nullable_9, int int_0)
    {
        int num;
        if (nullable_0.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[0].Value = DBNull.Value;
        }
        if (nullable_1.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[1].Value = nullable_1.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[1].Value = DBNull.Value;
        }
        if (nullable_2.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[2].Value = nullable_2.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[2].Value = DBNull.Value;
        }
        if (string_0 == null)
        {
            this.method_0().UpdateCommand.Parameters[3].Value = DBNull.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[3].Value = string_0;
        }
        if (nullable_3.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[4].Value = nullable_3.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[4].Value = DBNull.Value;
        }
        if (string_1 == null)
        {
            this.method_0().UpdateCommand.Parameters[5].Value = DBNull.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[5].Value = string_1;
        }
        if (nullable_4.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[6].Value = nullable_4.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[6].Value = DBNull.Value;
        }
        if (nullable_5.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[7].Value = nullable_5.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[7].Value = DBNull.Value;
        }
        if (nullable_6.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[8].Value = nullable_6.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[8].Value = DBNull.Value;
        }
        if (string_2 == null)
        {
            this.method_0().UpdateCommand.Parameters[9].Value = DBNull.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[9].Value = string_2;
        }
        if (nullable_7.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[10].Value = nullable_7.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[10].Value = DBNull.Value;
        }
        if (string_3 == null)
        {
            this.method_0().UpdateCommand.Parameters[11].Value = DBNull.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[11].Value = string_3;
        }
        if (string_4 == null)
        {
            this.method_0().UpdateCommand.Parameters[12].Value = DBNull.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[12].Value = string_4;
        }
        if (string_5 == null)
        {
            this.method_0().UpdateCommand.Parameters[13].Value = DBNull.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[13].Value = string_5;
        }
        if (nullable_8.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[14].Value = nullable_8.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[14].Value = DBNull.Value;
        }
        if (nullable_9.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[15].Value = nullable_9.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[15].Value = DBNull.Value;
        }
        this.method_0().UpdateCommand.Parameters[0x10].Value = int_0;
        ConnectionState state = this.method_0().UpdateCommand.Connection.State;
        if ((this.method_0().UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            this.method_0().UpdateCommand.Connection.Open();
        }
        try
        {
            num = this.method_0().UpdateCommand.ExecuteNonQuery();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                this.method_0().UpdateCommand.Connection.Close();
            }
        }
        return num;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Update, false), DebuggerNonUserCode]
    public virtual int vmethod_19(int? nullable_0, int? nullable_1)
    {
        int num;
        SqlCommand command = this.method_5()[6];
        if (nullable_0.HasValue)
        {
            command.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            command.Parameters[0].Value = DBNull.Value;
        }
        if (nullable_1.HasValue)
        {
            command.Parameters[1].Value = nullable_1.Value;
        }
        else
        {
            command.Parameters[1].Value = DBNull.Value;
        }
        ConnectionState state = command.Connection.State;
        if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            command.Connection.Open();
        }
        try
        {
            num = command.ExecuteNonQuery();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                command.Connection.Close();
            }
        }
        return num;
    }

    [DataObjectMethod(DataObjectMethodType.Fill, false), HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    public virtual int vmethod_2(OrgDataSet.tblAbnAplForDisconObjectsDataTable tblAbnAplForDisconObjectsDataTable_0, string string_0)
    {
        this.method_0().SelectCommand = this.method_5()[1];
        if (string_0 == null)
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = string_0;
        }
        if (this.method_6())
        {
            tblAbnAplForDisconObjectsDataTable_0.Clear();
        }
        return this.method_0().Fill(tblAbnAplForDisconObjectsDataTable_0);
    }

    [DataObjectMethod(DataObjectMethodType.Update, false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
    public virtual int vmethod_20(string string_0, int? nullable_0)
    {
        int num;
        SqlCommand command = this.method_5()[7];
        if (string_0 == null)
        {
            command.Parameters[0].Value = DBNull.Value;
        }
        else
        {
            command.Parameters[0].Value = string_0;
        }
        if (nullable_0.HasValue)
        {
            command.Parameters[1].Value = nullable_0.Value;
        }
        else
        {
            command.Parameters[1].Value = DBNull.Value;
        }
        ConnectionState state = command.Connection.State;
        if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            command.Connection.Open();
        }
        try
        {
            num = command.ExecuteNonQuery();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                command.Connection.Close();
            }
        }
        return num;
    }

    [DataObjectMethod(DataObjectMethodType.Update, false), HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    public virtual int vmethod_21(int? nullable_0, int? nullable_1, string string_0)
    {
        int num;
        SqlCommand command = this.method_5()[8];
        if (nullable_0.HasValue)
        {
            command.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            command.Parameters[0].Value = DBNull.Value;
        }
        if (nullable_1.HasValue)
        {
            command.Parameters[1].Value = nullable_1.Value;
        }
        else
        {
            command.Parameters[1].Value = DBNull.Value;
        }
        if (string_0 == null)
        {
            command.Parameters[2].Value = DBNull.Value;
        }
        else
        {
            command.Parameters[2].Value = string_0;
        }
        ConnectionState state = command.Connection.State;
        if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            command.Connection.Open();
        }
        try
        {
            num = command.ExecuteNonQuery();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                command.Connection.Close();
            }
        }
        return num;
    }

    [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    public virtual int vmethod_22(int? nullable_0, int? nullable_1, int? nullable_2)
    {
        int num;
        SqlCommand command = this.method_5()[9];
        if (nullable_0.HasValue)
        {
            command.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            command.Parameters[0].Value = DBNull.Value;
        }
        if (nullable_1.HasValue)
        {
            command.Parameters[1].Value = nullable_1.Value;
        }
        else
        {
            command.Parameters[1].Value = DBNull.Value;
        }
        if (nullable_2.HasValue)
        {
            command.Parameters[2].Value = nullable_2.Value;
        }
        else
        {
            command.Parameters[2].Value = DBNull.Value;
        }
        ConnectionState state = command.Connection.State;
        if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        {
            command.Connection.Open();
        }
        try
        {
            num = command.ExecuteNonQuery();
        }
        finally
        {
            if (state == ConnectionState.Closed)
            {
                command.Connection.Close();
            }
        }
        return num;
    }

    [DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Select, false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
    public virtual OrgDataSet.tblAbnAplForDisconObjectsDataTable vmethod_3(string string_0)
    {
        this.method_0().SelectCommand = this.method_5()[1];
        if (string_0 == null)
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = string_0;
        }
        OrgDataSet.tblAbnAplForDisconObjectsDataTable dataTable = new OrgDataSet.tblAbnAplForDisconObjectsDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }

    [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Fill, false), DebuggerNonUserCode]
    public virtual int vmethod_4(OrgDataSet.tblAbnAplForDisconObjectsDataTable tblAbnAplForDisconObjectsDataTable_0, int? nullable_0)
    {
        this.method_0().SelectCommand = this.method_5()[2];
        if (nullable_0.HasValue)
        {
            this.method_0().SelectCommand.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        if (this.method_6())
        {
            tblAbnAplForDisconObjectsDataTable_0.Clear();
        }
        return this.method_0().Fill(tblAbnAplForDisconObjectsDataTable_0);
    }

    [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Select, false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual OrgDataSet.tblAbnAplForDisconObjectsDataTable vmethod_5(int? nullable_0)
    {
        this.method_0().SelectCommand = this.method_5()[2];
        if (nullable_0.HasValue)
        {
            this.method_0().SelectCommand.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        OrgDataSet.tblAbnAplForDisconObjectsDataTable dataTable = new OrgDataSet.tblAbnAplForDisconObjectsDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }

    [DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Fill, false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_6(OrgDataSet.tblAbnAplForDisconObjectsDataTable tblAbnAplForDisconObjectsDataTable_0, string string_0)
    {
        this.method_0().SelectCommand = this.method_5()[3];
        if (string_0 == null)
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = string_0;
        }
        if (this.method_6())
        {
            tblAbnAplForDisconObjectsDataTable_0.Clear();
        }
        return this.method_0().Fill(tblAbnAplForDisconObjectsDataTable_0);
    }

    [DataObjectMethod(DataObjectMethodType.Select, false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
    public virtual OrgDataSet.tblAbnAplForDisconObjectsDataTable vmethod_7(string string_0)
    {
        this.method_0().SelectCommand = this.method_5()[3];
        if (string_0 == null)
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = string_0;
        }
        OrgDataSet.tblAbnAplForDisconObjectsDataTable dataTable = new OrgDataSet.tblAbnAplForDisconObjectsDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }

    [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Fill, false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_8(OrgDataSet.tblAbnAplForDisconObjectsDataTable tblAbnAplForDisconObjectsDataTable_0, int? nullable_0)
    {
        this.method_0().SelectCommand = this.method_5()[4];
        if (nullable_0.HasValue)
        {
            this.method_0().SelectCommand.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        if (this.method_6())
        {
            tblAbnAplForDisconObjectsDataTable_0.Clear();
        }
        return this.method_0().Fill(tblAbnAplForDisconObjectsDataTable_0);
    }

    [HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Select, false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual OrgDataSet.tblAbnAplForDisconObjectsDataTable vmethod_9(int? nullable_0)
    {
        this.method_0().SelectCommand = this.method_5()[4];
        if (nullable_0.HasValue)
        {
            this.method_0().SelectCommand.Parameters[0].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        OrgDataSet.tblAbnAplForDisconObjectsDataTable dataTable = new OrgDataSet.tblAbnAplForDisconObjectsDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }
}

