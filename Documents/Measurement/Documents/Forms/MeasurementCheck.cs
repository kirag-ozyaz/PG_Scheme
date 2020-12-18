using Measurement.DataSets;
using System;
using System.Data;
using System.Linq;

internal class MeasurementCheck
{
    internal static bool IsSaveTableValues(DataTable dt)
    {
        if (dt is DataSetMeasurementN.tJ_MeasAmperageTransfDataTable)
        {
            DataSetMeasurementN.tJ_MeasAmperageTransfDataTable table1 = (DataSetMeasurementN.tJ_MeasAmperageTransfDataTable)dt;
            return (!table1.First().IsIaNull() || !table1.First().IsIbNull() || table1.First().IsIcNull());
        }
        if (dt is DataSetMeasurementN.tJ_MeasVoltageTransfDataTable)
        {
            DataSetMeasurementN.tJ_MeasVoltageTransfDataTable table2 = (DataSetMeasurementN.tJ_MeasVoltageTransfDataTable) dt;
            return !table2.First().IsUabdNull() || !table2.First().IsUabnNull() || !table2.First().IsUaodNull() || !table2.First().IsUaonNull() || !table2.First().IsUbcdNull() || !table2.First().IsUbcnNull() || !table2.First().IsUbodNull() || !table2.First().IsUbonNull() || !table2.First().IsUcadNull() || !table2.First().IsUcanNull() || !table2.First().IsUcodNull() || !table2.First().IsUconNull();
        }
        if (dt is DataSetMeasurementN.tJ_MeasCableDataTable)
        {
            bool flag = false;
            foreach (DataSetMeasurementN.tJ_MeasCableRow row in (DataSetMeasurementN.tJ_MeasCableDataTable) dt)
            {
                flag = (!row.IsMakeupNull() || !row.IsWiresNull() || !row.IsCrossSectionNull() || !row.IsPermisAmperageNull() || !row.IsIadNull() || !row.IsIanNull() || !row.IsIbdNull() || !row.IsIbnNull() || !row.IsIcdNull() || !row.IsIcnNull());
            }
            return flag;
        }
        if (!(dt is DataSetMeasurementN.tJ_MeasCellDataTable))
        {
            return true;
        }
        bool flag2 = false;
        DataSetMeasurementN.tJ_MeasCellDataTable tJ_MeasCellDataTable = (DataSetMeasurementN.tJ_MeasCellDataTable)dt;
        foreach (DataSetMeasurementN.tJ_MeasCellRow row in tJ_MeasCellDataTable)
        {
            flag2 = (!row.IsPermissAmperageNull() || !row.IsIadNull() || !row.IsIanNull() || !row.IsIbdNull() || !row.IsIbnNull() || !row.IsIcdNull() || !row.IsIcnNull());
        }
        return flag2;
    }
}

