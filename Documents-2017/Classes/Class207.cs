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

[ToolboxItem(true), DataObject(true), Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), HelpKeyword("vs.data.TableAdapter"), DesignerCategory("code")]
internal class Class207 : Component
{
    private bool bool_0;
    private SqlCommand[] sqlCommand_0;
    private SqlConnection sqlConnection_0;
    private SqlDataAdapter sqlDataAdapter_0;
    private SqlTransaction sqlTransaction_0;

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public Class207()
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
        this.sqlCommand_0 = new SqlCommand[8];
        this.sqlCommand_0[0] = new SqlCommand();
        this.sqlCommand_0[0].Connection = this.method_1();
        this.sqlCommand_0[0].CommandText = "SELECT        tblAbnAplForDisconIndividualUsers.Id, tblAbnAplForDisconIndividualUsers.FIO, tblAbnAplForDisconIndividualUsers.Address, \r\n                         tblAbnAplForDisconIndividualUsers.PlaceId, tblAbnAplForDisconIndividualUsers.Reason, tblAbnAplForDisconIndividualUsers.IdAplForDiscon, \r\n                         tblAbnAplForDisconIndividualUsers.Comments, tblAbnAplForDisconIndividualUsers.IsNC, tblAbnAplForDisconIndividualUsers.IdAbn, \r\n                         tblAbnAplForDisconIndividualUsers.Code, tblAbnAplForDisconIndividualUsers.DateDog, tblAbnAplForDisconIndividualUsers.IdCancelApl, \r\n                         tblAbnAplConnectPointForIndividualUsers.Point, tblAbnAplForDisconIndividualUsers.Officer, tblAbnAplForDisconIndividualUsers.DateExec, \r\n                         tblAbnAplForDisconIndividualUsers.FioExec, tblAbnAplForDisconIndividualUsers.NetAreaExec, tblAbnAplForDisconIndividualUsers.ReasonFailure, \r\n                         tblAbnAplForDisconReason.Reason AS ReasonCaption, tblAbnAplForDiscon.NumDoc AS CancelAplNum, Division.Description AS NetAreaExecDescription, \r\n                         Worker.F + ' ' + Worker.I + ' ' + Worker.O AS FIOWorker, tblAbnAplForDisconIndividualUsers.Matrix, tblAbnAplForDiscon.Sent, tblAbnAplForDiscon.DateAction, \r\n                         tblAbnAplForDiscon.TypeAction, tblAbnAplForDiscon.NetArea, tblAbnAplForDiscon.DateAppl, tblAbnAplForDisconIndividualUsers.IsFullRestriction\r\nFROM            tblAbnAplForDisconIndividualUsers INNER JOIN\r\n                         tblAbnAplConnectPointForIndividualUsers ON tblAbnAplForDisconIndividualUsers.PlaceId = tblAbnAplConnectPointForIndividualUsers.Id INNER JOIN\r\n                         tblAbnAplForDisconReason ON tblAbnAplForDisconIndividualUsers.Reason = tblAbnAplForDisconReason.Id LEFT OUTER JOIN\r\n                         tblAbnAplForDiscon ON tblAbnAplForDisconIndividualUsers.IdCancelApl = tblAbnAplForDiscon.Id LEFT OUTER JOIN\r\n                         tR_Division AS Division ON tblAbnAplForDisconIndividualUsers.NetAreaExec = Division.id LEFT OUTER JOIN\r\n                         tR_Worker AS Worker ON tblAbnAplForDisconIndividualUsers.FioExec = Worker.id\r\nWHERE        (tblAbnAplForDisconIndividualUsers.IdAplForDiscon = @IdAplForDiscon)";
        this.sqlCommand_0[0].CommandType = CommandType.Text;
        this.sqlCommand_0[0].Parameters.Add(new SqlParameter("@IdAplForDiscon", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdAplForDiscon", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[1] = new SqlCommand();
        this.sqlCommand_0[1].Connection = this.method_1();
        this.sqlCommand_0[1].CommandText = "SELECT        tblAbnAplForDisconIndividualUsers.Id, tblAbnAplForDisconIndividualUsers.FIO, tblAbnAplForDisconIndividualUsers.Address, \r\n                         tblAbnAplForDisconIndividualUsers.PlaceId, tblAbnAplForDisconIndividualUsers.Reason, tblAbnAplForDisconIndividualUsers.IdAplForDiscon, \r\n                         tblAbnAplForDisconIndividualUsers.Comments, tblAbnAplForDisconIndividualUsers.IsNC, tblAbnAplForDisconIndividualUsers.IdAbn, \r\n                         tblAbnAplForDisconIndividualUsers.Code, tblAbnAplForDisconIndividualUsers.DateDog, tblAbnAplForDisconIndividualUsers.IdCancelApl, \r\n                         tblAbnAplConnectPointForIndividualUsers.Point, tblAbnAplForDisconIndividualUsers.Officer, tblAbnAplForDisconIndividualUsers.DateExec, \r\n                         tblAbnAplForDisconIndividualUsers.FioExec, tblAbnAplForDisconIndividualUsers.NetAreaExec, tblAbnAplForDisconIndividualUsers.ReasonFailure, \r\n                         tblAbnAplForDisconReason.Reason AS ReasonCaption, tblAbnAplForDiscon.NumDoc AS CancelAplNum, Division.Description AS NetAreaExecDescription, \r\n                         Worker.F + ' ' + Worker.I + ' ' + Worker.O AS FIOWorker, tblAbnAplForDisconIndividualUsers.Matrix, tblAbnAplForDisconIndividualUsers.IsFullRestriction\r\nFROM            tblAbnAplForDisconIndividualUsers INNER JOIN\r\n                         tblAbnAplConnectPointForIndividualUsers ON tblAbnAplForDisconIndividualUsers.PlaceId = tblAbnAplConnectPointForIndividualUsers.Id INNER JOIN\r\n                         tblAbnAplForDisconReason ON tblAbnAplForDisconIndividualUsers.Reason = tblAbnAplForDisconReason.Id LEFT OUTER JOIN\r\n                         tblAbnAplForDiscon ON tblAbnAplForDisconIndividualUsers.IdCancelApl = tblAbnAplForDiscon.Id LEFT OUTER JOIN\r\n                         tR_Division AS Division ON tblAbnAplForDisconIndividualUsers.NetAreaExec = Division.id LEFT OUTER JOIN\r\n                         tR_Worker AS Worker ON tblAbnAplForDisconIndividualUsers.FioExec = Worker.id\r\nWHERE        (tblAbnAplForDisconIndividualUsers.Address LIKE @Address)";
        this.sqlCommand_0[1].CommandType = CommandType.Text;
        this.sqlCommand_0[1].Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, "Address", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[2] = new SqlCommand();
        this.sqlCommand_0[2].Connection = this.method_1();
        this.sqlCommand_0[2].CommandText = "SELECT        tblAbnAplForDisconIndividualUsers.Id, tblAbnAplForDisconIndividualUsers.FIO, tblAbnAplForDisconIndividualUsers.Address, \r\n                         tblAbnAplForDisconIndividualUsers.PlaceId, tblAbnAplForDisconIndividualUsers.Reason, tblAbnAplForDisconIndividualUsers.IdAplForDiscon, \r\n                         tblAbnAplForDisconIndividualUsers.Comments, tblAbnAplForDisconIndividualUsers.IsNC, tblAbnAplForDisconIndividualUsers.IdAbn, \r\n                         tblAbnAplForDisconIndividualUsers.Code, tblAbnAplForDisconIndividualUsers.DateDog, tblAbnAplForDisconIndividualUsers.IdCancelApl, \r\n                         tblAbnAplConnectPointForIndividualUsers.Point, tblAbnAplForDisconIndividualUsers.Officer, tblAbnAplForDisconIndividualUsers.DateExec, \r\n                         tblAbnAplForDisconIndividualUsers.FioExec, tblAbnAplForDisconIndividualUsers.NetAreaExec, tblAbnAplForDisconIndividualUsers.ReasonFailure, \r\n                         tblAbnAplForDisconReason.Reason AS ReasonCaption, tblAbnAplForDiscon.NumDoc AS CancelAplNum, Division.Description AS NetAreaExecDescription, \r\n                         Worker.F + ' ' + Worker.I + ' ' + Worker.O AS FIOWorker, tblAbnAplForDisconIndividualUsers.Matrix, tblAbnAplForDiscon.Sent, tblAbnAplForDiscon.DateAction, \r\n                         tblAbnAplForDiscon.TypeAction, tblAbnAplForDiscon.NetArea, tblAbnAplForDiscon.DateAppl, tblAbnAplForDisconIndividualUsers.IsFullRestriction\r\nFROM            tblAbnAplForDisconIndividualUsers INNER JOIN\r\n                         tblAbnAplConnectPointForIndividualUsers ON tblAbnAplForDisconIndividualUsers.PlaceId = tblAbnAplConnectPointForIndividualUsers.Id INNER JOIN\r\n                         tblAbnAplForDisconReason ON tblAbnAplForDisconIndividualUsers.Reason = tblAbnAplForDisconReason.Id LEFT OUTER JOIN\r\n                         tblAbnAplForDiscon ON tblAbnAplForDisconIndividualUsers.IdCancelApl = tblAbnAplForDiscon.Id LEFT OUTER JOIN\r\n                         tR_Division AS Division ON tblAbnAplForDisconIndividualUsers.NetAreaExec = Division.id LEFT OUTER JOIN\r\n                         tR_Worker AS Worker ON tblAbnAplForDisconIndividualUsers.FioExec = Worker.id INNER JOIN\r\n                         tblAbnAplForDiscon AS apl ON tblAbnAplForDisconIndividualUsers.IdAplForDiscon = apl.id AND apl.TypeAction = 0\r\nWHERE        (tblAbnAplForDisconIndividualUsers.IdAplForDiscon = @IdAplForDiscon) AND (tblAbnAplForDisconIndividualUsers.IdCancelApl IS NULL) AND \r\n                         (tblAbnAplForDisconIndividualUsers.DateExec IS NOT NULL) AND (tblAbnAplForDisconIndividualUsers.Code IS NOT NULL) AND \r\n                         (tblAbnAplForDisconIndividualUsers.Code NOT IN\r\n                             (SELECT        obj1.Code\r\n                               FROM            tblAbnAplForDisconIndividualUsers AS obj1 INNER JOIN\r\n                                                         tblAbnAplForDiscon AS apl1 ON obj1.IdAplForDiscon = apl1.Id AND apl1.TypeAction = 1\r\n                               WHERE        (obj1.IdCancelApl IS NULL) AND (obj1.DateExec IS NOT NULL) AND (obj1.Code IS NOT NULL) AND (apl.DateAppl < apl1.DateAppl)))";
        this.sqlCommand_0[2].CommandType = CommandType.Text;
        this.sqlCommand_0[2].Parameters.Add(new SqlParameter("@IdAplForDiscon", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdAplForDiscon", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[3] = new SqlCommand();
        this.sqlCommand_0[3].Connection = this.method_1();
        this.sqlCommand_0[3].CommandText = "SELECT        tblAbnAplForDisconIndividualUsers.Id, tblAbnAplForDisconIndividualUsers.FIO, tblAbnAplForDisconIndividualUsers.Address, \r\n                         tblAbnAplForDisconIndividualUsers.PlaceId, tblAbnAplForDisconIndividualUsers.Reason, tblAbnAplForDisconIndividualUsers.IdAplForDiscon, \r\n                         tblAbnAplForDisconIndividualUsers.Comments, tblAbnAplForDisconIndividualUsers.IsNC, tblAbnAplForDisconIndividualUsers.IdAbn, \r\n                         tblAbnAplForDisconIndividualUsers.Code, tblAbnAplForDisconIndividualUsers.DateDog, tblAbnAplForDisconIndividualUsers.IdCancelApl, \r\n                         tblAbnAplConnectPointForIndividualUsers.Point, tblAbnAplForDisconIndividualUsers.Officer, tblAbnAplForDisconIndividualUsers.DateExec, \r\n                         tblAbnAplForDisconIndividualUsers.FioExec, tblAbnAplForDisconIndividualUsers.NetAreaExec, tblAbnAplForDisconIndividualUsers.ReasonFailure, \r\n                         tblAbnAplForDisconReason.Reason AS ReasonCaption, tblAbnAplForDiscon.NumDoc AS CancelAplNum, Division.Description AS NetAreaExecDescription, \r\n                         Worker.F + ' ' + Worker.I + ' ' + Worker.O AS FIOWorker, tblAbnAplForDisconIndividualUsers.Matrix, tblAbnAplForDisconIndividualUsers.IsFullRestriction\r\nFROM            tblAbnAplForDisconIndividualUsers INNER JOIN\r\n                         tblAbnAplConnectPointForIndividualUsers ON tblAbnAplForDisconIndividualUsers.PlaceId = tblAbnAplConnectPointForIndividualUsers.Id INNER JOIN\r\n                         tblAbnAplForDisconReason ON tblAbnAplForDisconIndividualUsers.Reason = tblAbnAplForDisconReason.Id LEFT OUTER JOIN\r\n                         tblAbnAplForDiscon ON tblAbnAplForDisconIndividualUsers.IdCancelApl = tblAbnAplForDiscon.Id LEFT OUTER JOIN\r\n                         tR_Division AS Division ON tblAbnAplForDisconIndividualUsers.NetAreaExec = Division.id LEFT OUTER JOIN\r\n                         tR_Worker AS Worker ON tblAbnAplForDisconIndividualUsers.FioExec = Worker.id\r\nWHERE        (tblAbnAplForDisconIndividualUsers.Id = @Id)";
        this.sqlCommand_0[3].CommandType = CommandType.Text;
        this.sqlCommand_0[3].Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[4] = new SqlCommand();
        this.sqlCommand_0[4].Connection = this.method_1();
        this.sqlCommand_0[4].CommandText = "SELECT        tblAbnAplForDisconIndividualUsers.Id, tblAbnAplForDisconIndividualUsers.FIO, tblAbnAplForDisconIndividualUsers.Address, \r\n                         tblAbnAplForDisconIndividualUsers.PlaceId, tblAbnAplForDisconIndividualUsers.Reason, tblAbnAplForDisconIndividualUsers.IdAplForDiscon, \r\n                         tblAbnAplForDisconIndividualUsers.Comments, tblAbnAplForDisconIndividualUsers.IsNC, tblAbnAplForDisconIndividualUsers.IdAbn, \r\n                         tblAbnAplForDisconIndividualUsers.Code, tblAbnAplForDisconIndividualUsers.DateDog, tblAbnAplForDisconIndividualUsers.IdCancelApl, \r\n                         tblAbnAplConnectPointForIndividualUsers.Point, tblAbnAplForDisconIndividualUsers.Officer, tblAbnAplForDisconIndividualUsers.DateExec, \r\n                         tblAbnAplForDisconIndividualUsers.FioExec, tblAbnAplForDisconIndividualUsers.NetAreaExec, tblAbnAplForDisconIndividualUsers.ReasonFailure, \r\n                         tblAbnAplForDisconReason.Reason AS ReasonCaption, tblAbnAplForDiscon.NumDoc AS CancelAplNum, Division.Description AS NetAreaExecDescription, \r\n                         Worker.F + ' ' + Worker.I + ' ' + Worker.O AS FIOWorker, tblAbnAplForDisconIndividualUsers.Matrix, tblAbnAplForDisconIndividualUsers.IsFullRestriction\r\nFROM            tblAbnAplForDisconIndividualUsers INNER JOIN\r\n                         tblAbnAplConnectPointForIndividualUsers ON tblAbnAplForDisconIndividualUsers.PlaceId = tblAbnAplConnectPointForIndividualUsers.Id INNER JOIN\r\n                         tblAbnAplForDisconReason ON tblAbnAplForDisconIndividualUsers.Reason = tblAbnAplForDisconReason.Id LEFT OUTER JOIN\r\n                         tblAbnAplForDiscon ON tblAbnAplForDisconIndividualUsers.IdCancelApl = tblAbnAplForDiscon.Id LEFT OUTER JOIN\r\n                         tR_Division AS Division ON tblAbnAplForDisconIndividualUsers.NetAreaExec = Division.id LEFT OUTER JOIN\r\n                         tR_Worker AS Worker ON tblAbnAplForDisconIndividualUsers.FioExec = Worker.id\r\nWHERE        (tblAbnAplForDisconIndividualUsers.FIO LIKE @name)";
        this.sqlCommand_0[4].CommandType = CommandType.Text;
        this.sqlCommand_0[4].Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 100, ParameterDirection.Input, 0, 0, "FIO", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[5] = new SqlCommand();
        this.sqlCommand_0[5].Connection = this.method_1();
        this.sqlCommand_0[5].CommandText = "SELECT        tblAbnAplForDisconIndividualUsers.Id, tblAbnAplForDisconIndividualUsers.FIO, tblAbnAplForDisconIndividualUsers.Address, \r\n                         tblAbnAplForDisconIndividualUsers.PlaceId, tblAbnAplForDisconIndividualUsers.Reason, tblAbnAplForDisconIndividualUsers.IdAplForDiscon, \r\n                         tblAbnAplForDisconIndividualUsers.Comments, tblAbnAplForDisconIndividualUsers.IsNC, tblAbnAplForDisconIndividualUsers.IdAbn, \r\n                         tblAbnAplForDisconIndividualUsers.Code, tblAbnAplForDisconIndividualUsers.DateDog, tblAbnAplForDisconIndividualUsers.IdCancelApl, \r\n                         tblAbnAplConnectPointForIndividualUsers.Point, tblAbnAplForDisconIndividualUsers.Officer, tblAbnAplForDisconIndividualUsers.DateExec, \r\n                         tblAbnAplForDisconIndividualUsers.FioExec, tblAbnAplForDisconIndividualUsers.NetAreaExec, tblAbnAplForDisconIndividualUsers.ReasonFailure, \r\n                         tblAbnAplForDisconReason.Reason AS ReasonCaption, tblAbnAplForDiscon.NumDoc AS CancelAplNum, Division.Description AS NetAreaExecDescription, \r\n                         Worker.F + ' ' + Worker.I + ' ' + Worker.O AS FIOWorker, tblAbnAplForDisconIndividualUsers.Matrix, tblAbnAplForDiscon.DateAction, tblAbnAplForDiscon.NetArea, \r\n                         tblAbnAplForDiscon.TypeAction, tblAbnAplForDiscon.DateAppl, tblAbnAplForDiscon.Sent, tblAbnAplForDisconIndividualUsers.IsFullRestriction\r\nFROM            tblAbnAplForDisconIndividualUsers INNER JOIN\r\n                         tblAbnAplConnectPointForIndividualUsers ON tblAbnAplForDisconIndividualUsers.PlaceId = tblAbnAplConnectPointForIndividualUsers.Id INNER JOIN\r\n                         tblAbnAplForDisconReason ON tblAbnAplForDisconIndividualUsers.Reason = tblAbnAplForDisconReason.Id LEFT OUTER JOIN\r\n                         tblAbnAplForDiscon ON tblAbnAplForDisconIndividualUsers.IdAplForDiscon = tblAbnAplForDiscon.Id LEFT OUTER JOIN\r\n                         tR_Division AS Division ON tblAbnAplForDisconIndividualUsers.NetAreaExec = Division.id LEFT OUTER JOIN\r\n                         tR_Worker AS Worker ON tblAbnAplForDisconIndividualUsers.FioExec = Worker.id\r\nWHERE        (tblAbnAplForDisconIndividualUsers.DateExec IS NULL) AND (tblAbnAplForDiscon.DateAction < @BegPer) AND \r\n                         (tblAbnAplForDisconIndividualUsers.IdCancelApl IS NULL)";
        this.sqlCommand_0[5].CommandType = CommandType.Text;
        this.sqlCommand_0[5].Parameters.Add(new SqlParameter("@BegPer", SqlDbType.DateTime, 8, ParameterDirection.Input, 0, 0, "DateAction", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[6] = new SqlCommand();
        this.sqlCommand_0[6].Connection = this.method_1();
        this.sqlCommand_0[6].CommandText = "UPDATE       tblAbnAplForDisconIndividualUsers\r\nSET                IdCancelApl = NULL\r\nWHERE        (FIO = @FIO) AND (IdCancelApl = @IdCancelApl);      \r\n";
        this.sqlCommand_0[6].CommandType = CommandType.Text;
        this.sqlCommand_0[6].Parameters.Add(new SqlParameter("@FIO", SqlDbType.NVarChar, 100, ParameterDirection.Input, 0, 0, "FIO", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlCommand_0[6].Parameters.Add(new SqlParameter("@IdCancelApl", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdCancelApl", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlCommand_0[7] = new SqlCommand();
        this.sqlCommand_0[7].Connection = this.method_1();
        this.sqlCommand_0[7].CommandText = "UPDATE       tblAbnAplForDisconIndividualUsers\r\nSET                IdCancelApl = @IdCancelApl\r\nWHERE        (IdAplForDiscon = @Original_IdAplForDiscon) AND (FIO = @FIO);    \r\n";
        this.sqlCommand_0[7].CommandType = CommandType.Text;
        this.sqlCommand_0[7].Parameters.Add(new SqlParameter("@IdCancelApl", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdCancelApl", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlCommand_0[7].Parameters.Add(new SqlParameter("@Original_IdAplForDiscon", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdAplForDiscon", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlCommand_0[7].Parameters.Add(new SqlParameter("@FIO", SqlDbType.NVarChar, 100, ParameterDirection.Input, 0, 0, "FIO", DataRowVersion.Original, false, null, "", "", ""));
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
            DataSetTable = "tblAbnAplForDisconIndividualUsers",
            ColumnMappings = { 
                { 
                    "Id",
                    "Id"
                },
                { 
                    "FIO",
                    "FIO"
                },
                { 
                    "Address",
                    "Address"
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
                    "IdAplForDiscon",
                    "IdAplForDiscon"
                },
                { 
                    "Comments",
                    "Comments"
                },
                { 
                    "IsNC",
                    "IsNC"
                },
                { 
                    "IdAbn",
                    "IdAbn"
                },
                { 
                    "Code",
                    "Code"
                },
                { 
                    "DateDog",
                    "DateDog"
                },
                { 
                    "IdCancelApl",
                    "IdCancelApl"
                },
                { 
                    "Point",
                    "Point"
                },
                { 
                    "Officer",
                    "Officer"
                },
                { 
                    "DateExec",
                    "DateExec"
                },
                { 
                    "FioExec",
                    "FioExec"
                },
                { 
                    "NetAreaExec",
                    "NetAreaExec"
                },
                { 
                    "ReasonFailure",
                    "ReasonFailure"
                },
                { 
                    "ReasonCaption",
                    "ReasonCaption"
                },
                { 
                    "CancelAplNum",
                    "CancelAplNum"
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
                    "Matrix",
                    "Matrix"
                },
                { 
                    "Sent",
                    "Sent"
                },
                { 
                    "DateAction",
                    "DateAction"
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
                    "DateAppl",
                    "DateAppl"
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
        this.sqlDataAdapter_0.DeleteCommand.CommandText = "DELETE FROM tblAbnAplForDisconIndividualUsers\r\nWHERE        (Id = @Original_Id)";
        this.sqlDataAdapter_0.DeleteCommand.CommandType = CommandType.Text;
        this.sqlDataAdapter_0.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand = new SqlCommand();
        this.sqlDataAdapter_0.InsertCommand.Connection = this.method_1();
        this.sqlDataAdapter_0.InsertCommand.CommandText = "INSERT INTO tblAbnAplForDisconIndividualUsers\r\n                         (FIO, Address, PlaceId, Reason, IdAplForDiscon, Comments, IsNC, IdAbn, Code, DateDog, IdCancelApl, Officer, DateExec, FioExec, NetAreaExec, ReasonFailure, \r\n                         Matrix, IsFullRestriction)\r\nVALUES        (@FIO,@Address,@PlaceId,@Reason,@IdAplForDiscon,@Comments,@IsNC,@IdAbn,@Code,@DateDog,@IdCancelApl,@Officer,@DateExec,@FioExec,@NetAreaExec,@ReasonFailure,@Matrix,@IsFullRestriction);     \r\nSELECT Id, FIO, Address, PlaceId, Reason, IdAplForDiscon, Comments, IsNC, IdAbn, Code, DateDog, IdCancelApl FROM tblAbnAplForDisconIndividualUsers WHERE (Id = SCOPE_IDENTITY())";
        this.sqlDataAdapter_0.InsertCommand.CommandType = CommandType.Text;
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@FIO", SqlDbType.NVarChar, 100, ParameterDirection.Input, 0, 0, "FIO", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, "Address", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@PlaceId", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "PlaceId", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Reason", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Reason", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@IdAplForDiscon", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdAplForDiscon", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Comments", SqlDbType.NVarChar, 0xff, ParameterDirection.Input, 0, 0, "Comments", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@IsNC", SqlDbType.Bit, 1, ParameterDirection.Input, 0, 0, "IsNC", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@IdAbn", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdAbn", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Code", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Code", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@DateDog", SqlDbType.DateTime, 8, ParameterDirection.Input, 0, 0, "DateDog", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@IdCancelApl", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdCancelApl", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Officer", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, "Officer", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@DateExec", SqlDbType.DateTime, 8, ParameterDirection.Input, 0, 0, "DateExec", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@FioExec", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "FioExec", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@NetAreaExec", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "NetAreaExec", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@ReasonFailure", SqlDbType.VarChar, 500, ParameterDirection.Input, 0, 0, "ReasonFailure", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@Matrix", SqlDbType.Bit, 1, ParameterDirection.Input, 0, 0, "Matrix", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.InsertCommand.Parameters.Add(new SqlParameter("@IsFullRestriction", SqlDbType.Bit, 1, ParameterDirection.Input, 0, 0, "IsFullRestriction", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand = new SqlCommand();
        this.sqlDataAdapter_0.UpdateCommand.Connection = this.method_1();
        this.sqlDataAdapter_0.UpdateCommand.CommandText = "UPDATE       tblAbnAplForDisconIndividualUsers\r\nSET                FIO = @FIO, Address = @Address, PlaceId = @PlaceId, Reason = @Reason, IdAplForDiscon = @IdAplForDiscon, Comments = @Comments, IsNC = @IsNC, \r\n                         IdAbn = @IdAbn, Code = @Code, DateDog = @DateDog, IdCancelApl = @IdCancelApl, Officer = @Officer, DateExec = @DateExec, FioExec = @FioExec, \r\n                         NetAreaExec = @NetAreaExec, ReasonFailure = @ReasonFailure, Matrix = @Matrix, IsFullRestriction = @IsFullRestriction\r\nWHERE        (Id = @Original_Id);     \r\nSELECT Id, FIO, Address, PlaceId, Reason, IdAplForDiscon, Comments, IsNC, IdAbn, Code, DateDog, IdCancelApl FROM tblAbnAplForDisconIndividualUsers WHERE (Id = @Id)";
        this.sqlDataAdapter_0.UpdateCommand.CommandType = CommandType.Text;
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@FIO", SqlDbType.NVarChar, 100, ParameterDirection.Input, 0, 0, "FIO", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, "Address", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@PlaceId", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "PlaceId", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Reason", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Reason", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IdAplForDiscon", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdAplForDiscon", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Comments", SqlDbType.NVarChar, 0xff, ParameterDirection.Input, 0, 0, "Comments", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsNC", SqlDbType.Bit, 1, ParameterDirection.Input, 0, 0, "IsNC", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IdAbn", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdAbn", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Code", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Code", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@DateDog", SqlDbType.DateTime, 8, ParameterDirection.Input, 0, 0, "DateDog", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IdCancelApl", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "IdCancelApl", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Officer", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, "Officer", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@DateExec", SqlDbType.DateTime, 8, ParameterDirection.Input, 0, 0, "DateExec", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@FioExec", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "FioExec", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@NetAreaExec", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "NetAreaExec", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@ReasonFailure", SqlDbType.VarChar, 500, ParameterDirection.Input, 0, 0, "ReasonFailure", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Matrix", SqlDbType.Bit, 1, ParameterDirection.Input, 0, 0, "Matrix", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@IsFullRestriction", SqlDbType.Bit, 1, ParameterDirection.Input, 0, 0, "IsFullRestriction", DataRowVersion.Current, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Original, false, null, "", "", ""));
        this.sqlDataAdapter_0.UpdateCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "Id", DataRowVersion.Original, false, null, "", "", ""));
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    private void method_9()
    {
        this.sqlConnection_0 = new SqlConnection();
        this.sqlConnection_0.ConnectionString = Settings.Default.trueGESConnectionString;
    }

    [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Fill, true), DebuggerNonUserCode]
    public virtual int vmethod_0(OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable tblAbnAplForDisconIndividualUsersDataTable_0, int? nullable_0)
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
            tblAbnAplForDisconIndividualUsersDataTable_0.Clear();
        }
        return this.method_0().Fill(tblAbnAplForDisconIndividualUsersDataTable_0);
    }

    [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Select, true), DebuggerNonUserCode]
    public virtual OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable vmethod_1(int? nullable_0)
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
        OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable dataTable = new OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Fill, false), HelpKeyword("vs.data.TableAdapter")]
    public virtual int vmethod_10(OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable tblAbnAplForDisconIndividualUsersDataTable_0, DateTime? nullable_0)
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
            tblAbnAplForDisconIndividualUsersDataTable_0.Clear();
        }
        return this.method_0().Fill(tblAbnAplForDisconIndividualUsersDataTable_0);
    }

    [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Select, false)]
    public virtual OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable vmethod_11(DateTime? nullable_0)
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
        OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable dataTable = new OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
    public virtual int vmethod_12(OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable tblAbnAplForDisconIndividualUsersDataTable_0)
    {
        return this.method_0().Update(tblAbnAplForDisconIndividualUsersDataTable_0);
    }

    [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_13(OrgDataSet orgDataSet_0)
    {
        return this.method_0().Update(orgDataSet_0, "tblAbnAplForDisconIndividualUsers");
    }

    [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_14(DataRow dataRow_0)
    {
        DataRow[] dataRows = new DataRow[] { dataRow_0 };
        return this.method_0().Update(dataRows);
    }

    [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
    public virtual int vmethod_15(DataRow[] dataRow_0)
    {
        return this.method_0().Update(dataRow_0);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Delete, true), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Insert, true), HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode]
    public virtual int vmethod_17(string string_0, string string_1, int? nullable_0, int? nullable_1, int? nullable_2, string string_2, bool? nullable_3, int? nullable_4, int? nullable_5, DateTime? nullable_6, int? nullable_7, string string_3, DateTime? nullable_8, int? nullable_9, int? nullable_10, string string_4, bool? nullable_11, bool? nullable_12)
    {
        int num;
        if (string_0 == null)
        {
            this.method_0().InsertCommand.Parameters[0].Value = DBNull.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[0].Value = string_0;
        }
        if (string_1 == null)
        {
            this.method_0().InsertCommand.Parameters[1].Value = DBNull.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[1].Value = string_1;
        }
        if (nullable_0.HasValue)
        {
            this.method_0().InsertCommand.Parameters[2].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[2].Value = DBNull.Value;
        }
        if (nullable_1.HasValue)
        {
            this.method_0().InsertCommand.Parameters[3].Value = nullable_1.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[3].Value = DBNull.Value;
        }
        if (nullable_2.HasValue)
        {
            this.method_0().InsertCommand.Parameters[4].Value = nullable_2.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[4].Value = DBNull.Value;
        }
        if (string_2 == null)
        {
            this.method_0().InsertCommand.Parameters[5].Value = DBNull.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[5].Value = string_2;
        }
        if (nullable_3.HasValue)
        {
            this.method_0().InsertCommand.Parameters[6].Value = nullable_3.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[6].Value = DBNull.Value;
        }
        if (nullable_4.HasValue)
        {
            this.method_0().InsertCommand.Parameters[7].Value = nullable_4.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[7].Value = DBNull.Value;
        }
        if (nullable_5.HasValue)
        {
            this.method_0().InsertCommand.Parameters[8].Value = nullable_5.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[8].Value = DBNull.Value;
        }
        if (nullable_6.HasValue)
        {
            this.method_0().InsertCommand.Parameters[9].Value = nullable_6.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[9].Value = DBNull.Value;
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
        if (nullable_8.HasValue)
        {
            this.method_0().InsertCommand.Parameters[12].Value = nullable_8.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[12].Value = DBNull.Value;
        }
        if (nullable_9.HasValue)
        {
            this.method_0().InsertCommand.Parameters[13].Value = nullable_9.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[13].Value = DBNull.Value;
        }
        if (nullable_10.HasValue)
        {
            this.method_0().InsertCommand.Parameters[14].Value = nullable_10.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[14].Value = DBNull.Value;
        }
        if (string_4 == null)
        {
            this.method_0().InsertCommand.Parameters[15].Value = DBNull.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[15].Value = string_4;
        }
        if (nullable_11.HasValue)
        {
            this.method_0().InsertCommand.Parameters[0x10].Value = nullable_11.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[0x10].Value = DBNull.Value;
        }
        if (nullable_12.HasValue)
        {
            this.method_0().InsertCommand.Parameters[0x11].Value = nullable_12.Value;
        }
        else
        {
            this.method_0().InsertCommand.Parameters[0x11].Value = DBNull.Value;
        }
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

    [DataObjectMethod(DataObjectMethodType.Update, true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
    public virtual int vmethod_18(string string_0, string string_1, int? nullable_0, int? nullable_1, int? nullable_2, string string_2, bool? nullable_3, int? nullable_4, int? nullable_5, DateTime? nullable_6, int? nullable_7, string string_3, DateTime? nullable_8, int? nullable_9, int? nullable_10, string string_4, bool? nullable_11, bool? nullable_12, int int_0, int int_1)
    {
        int num;
        if (string_0 == null)
        {
            this.method_0().UpdateCommand.Parameters[0].Value = DBNull.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[0].Value = string_0;
        }
        if (string_1 == null)
        {
            this.method_0().UpdateCommand.Parameters[1].Value = DBNull.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[1].Value = string_1;
        }
        if (nullable_0.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[2].Value = nullable_0.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[2].Value = DBNull.Value;
        }
        if (nullable_1.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[3].Value = nullable_1.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[3].Value = DBNull.Value;
        }
        if (nullable_2.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[4].Value = nullable_2.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[4].Value = DBNull.Value;
        }
        if (string_2 == null)
        {
            this.method_0().UpdateCommand.Parameters[5].Value = DBNull.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[5].Value = string_2;
        }
        if (nullable_3.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[6].Value = nullable_3.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[6].Value = DBNull.Value;
        }
        if (nullable_4.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[7].Value = nullable_4.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[7].Value = DBNull.Value;
        }
        if (nullable_5.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[8].Value = nullable_5.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[8].Value = DBNull.Value;
        }
        if (nullable_6.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[9].Value = nullable_6.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[9].Value = DBNull.Value;
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
        if (nullable_8.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[12].Value = nullable_8.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[12].Value = DBNull.Value;
        }
        if (nullable_9.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[13].Value = nullable_9.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[13].Value = DBNull.Value;
        }
        if (nullable_10.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[14].Value = nullable_10.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[14].Value = DBNull.Value;
        }
        if (string_4 == null)
        {
            this.method_0().UpdateCommand.Parameters[15].Value = DBNull.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[15].Value = string_4;
        }
        if (nullable_11.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[0x10].Value = nullable_11.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[0x10].Value = DBNull.Value;
        }
        if (nullable_12.HasValue)
        {
            this.method_0().UpdateCommand.Parameters[0x11].Value = nullable_12.Value;
        }
        else
        {
            this.method_0().UpdateCommand.Parameters[0x11].Value = DBNull.Value;
        }
        this.method_0().UpdateCommand.Parameters[0x12].Value = int_0;
        this.method_0().UpdateCommand.Parameters[0x13].Value = int_1;
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

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
    public virtual int vmethod_19(string string_0, int? nullable_0)
    {
        int num;
        SqlCommand command = this.method_5()[6];
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

    [DataObjectMethod(DataObjectMethodType.Fill, false), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_2(OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable tblAbnAplForDisconIndividualUsersDataTable_0, string string_0)
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
            tblAbnAplForDisconIndividualUsersDataTable_0.Clear();
        }
        return this.method_0().Fill(tblAbnAplForDisconIndividualUsersDataTable_0);
    }

    [HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    public virtual int vmethod_20(int? nullable_0, int? nullable_1, string string_0)
    {
        int num;
        SqlCommand command = this.method_5()[7];
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

    [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Select, false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable vmethod_3(string string_0)
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
        OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable dataTable = new OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }

    [DataObjectMethod(DataObjectMethodType.Fill, false), HelpKeyword("vs.data.TableAdapter"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
    public virtual int vmethod_4(OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable tblAbnAplForDisconIndividualUsersDataTable_0, int? nullable_0)
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
            tblAbnAplForDisconIndividualUsersDataTable_0.Clear();
        }
        return this.method_0().Fill(tblAbnAplForDisconIndividualUsersDataTable_0);
    }

    [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Select, false)]
    public virtual OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable vmethod_5(int? nullable_0)
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
        OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable dataTable = new OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }

    [DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter"), DataObjectMethod(DataObjectMethodType.Fill, false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual int vmethod_6(OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable tblAbnAplForDisconIndividualUsersDataTable_0, int int_0)
    {
        this.method_0().SelectCommand = this.method_5()[3];
        this.method_0().SelectCommand.Parameters[0].Value = int_0;
        if (this.method_6())
        {
            tblAbnAplForDisconIndividualUsersDataTable_0.Clear();
        }
        return this.method_0().Fill(tblAbnAplForDisconIndividualUsersDataTable_0);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DataObjectMethod(DataObjectMethodType.Select, false), DebuggerNonUserCode, HelpKeyword("vs.data.TableAdapter")]
    public virtual OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable vmethod_7(int int_0)
    {
        this.method_0().SelectCommand = this.method_5()[3];
        this.method_0().SelectCommand.Parameters[0].Value = int_0;
        OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable dataTable = new OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }

    [DataObjectMethod(DataObjectMethodType.Fill, false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), HelpKeyword("vs.data.TableAdapter")]
    public virtual int vmethod_8(OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable tblAbnAplForDisconIndividualUsersDataTable_0, string string_0)
    {
        this.method_0().SelectCommand = this.method_5()[4];
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
            tblAbnAplForDisconIndividualUsersDataTable_0.Clear();
        }
        return this.method_0().Fill(tblAbnAplForDisconIndividualUsersDataTable_0);
    }

    [HelpKeyword("vs.data.TableAdapter"), DebuggerNonUserCode, DataObjectMethod(DataObjectMethodType.Select, false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public virtual OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable vmethod_9(string string_0)
    {
        this.method_0().SelectCommand = this.method_5()[4];
        if (string_0 == null)
        {
            this.method_0().SelectCommand.Parameters[0].Value = DBNull.Value;
        }
        else
        {
            this.method_0().SelectCommand.Parameters[0].Value = string_0;
        }
        OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable dataTable = new OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable();
        this.method_0().Fill(dataTable);
        return dataTable;
    }
}

