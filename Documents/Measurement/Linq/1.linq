<Query Kind="Statements">
  <Connection>
    <ID>72825ff0-ff37-4a83-82d0-fdba997c33a2</ID>
    <Persist>true</Persist>
    <Server>ulges-sql2</Server>
    <Database>GES_KK</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

TJ_Measurements.Where (t => t.Id == 23329).Dump(); //замер
TJ_MeasVoltageTransfs.Where (t => t.IdMeasurement == 23329).Dump(); //замер

TJ_MeasVoltageTransfs.Where (t => t.IdObjList == 964048 & t.IdBus == 1151151).Dump(); //замер

TJ_MeasVoltageTransfs.Where (t =>  t.IdBus == 1151150 ).Dump(); // T2
TJ_MeasVoltageTransfs.Where (t =>  t.IdBus == 1151151 ).Dump(); // T1
