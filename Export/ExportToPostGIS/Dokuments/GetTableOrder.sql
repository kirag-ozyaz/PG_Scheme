
/*

Запрос получения нарядов в 2020
вход 
	@IdDocument - идентификатор документа

рабочая версия

*/
--use ges;
--declare @IdDocument int;
--set @IdDocument = 0;


with sub (Id, FullName, deleted) AS
(SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text], o.deleted
FROM tSchm_ObjList AS o
LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id
WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))),

bus (Id, busName, subid, subname, deleted) AS
(SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name, 
          case when o.deleted = 0 and sub.deleted = 0 then 0 else 1 end
FROM tSchm_ObjList AS o 
JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id
join tSChm_ObjList sub on sub.id = o.idParent
join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id
WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0))),

cell     (cellId, cellName, busId, busName, subId, subName, deleted) AS
(SELECT  cell.Id, ISNULL(c.SocrName + ' ', '') + cell.Name [Text], 
          bus.id,  ISNULL(cBus.SocrName + '-', '') + bus.Name [Text],
          sub.id,  ISNULL(cSub.SocrName + '-', '') + sub.Name [Text], 
          case when cell.deleted = 0 and bus.deleted = 0 and sub.deleted = 0 then 0 else 1 end
FROM tSchm_ObjList AS bus
JOIN tR_Classifier AS cBus ON bus.TypeCodeId = cBus.id AND cBus.ParentKey LIKE ';SCM;BUS;%'
JOIN tSchm_ObjList AS point ON bus.id = point.IdParent
JOIN tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj
JOIN tSchm_ObjList AS cell ON rel.Edge = cell.id
JOIN tR_Classifier AS c ON cell.TypeCodeId = c.id AND c.ParentKey LIKE ';SCM;Cell;%'
join tschm_objlist as sub on sub.id = bus.idparent
JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id )
     


select doc.[ID], doc.[NUM], doc.[DATEBEGIN], doc.[DATEEND], 
doc.[IDSR], doc.[SRNUM], doc.[SRNAME], doc.[INSTRUCTION], 
doc.[HEADWORKER], doc.[HEADFIO], doc.[ACCEPTWORKER], doc.[ACCEPTFIO], 
doc.[WATCHWORKER], doc.[WATCHFIO], doc.[MAKERWORKER], doc.[MAKERFIO], 
doc.[OTHERINSTRUCTION], doc.[DATEOUTPUT], doc.[OUTPUTWORKER], doc.[OUTPUTFIO], 
doc.[REGISTERED], doc.[DATECLOSE], doc.[CLOSEWORKER], doc.[CLOSEFIO], 
doc.[BEGINRES], doc.[ENDRES], doc.[RESWORKERID], doc.[RESWORKER],
 doc.[EXTWORKER], doc.[EXTFIO], doc.[DATEENDEXT] 
 , tL_OrderSchmObjList.idSchmObj, [dbo].[fn_Schm_GetFullNameObjById](tL_OrderSchmObjList.idSchmObj) FullNameObj
 , [tSchm_Xml].[SchemaXml]
 	   ,
	   -- ,cell.cellId, cell.CellName,  
	    --isnull(cell.busId, bus.id) as busid,
	    --isnull(cell.BusName, bus.busname) as busname,
	    isnull(cell.subid, isnull(bus.subid, sub.id)) as subid,
	    isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname
		-- ,
	    --isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+
	    --isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') as schmObjName

 from vJ_Order doc
	left join tL_OrderSchmObjList on doc.id = tL_OrderSchmObjList.idOrder
	
	    left join cell on cell.cellid = tL_OrderSchmObjList.idSchmObj
	    left join bus on bus.id = tL_OrderSchmObjList.idSChmObj
	    left join sub on sub.id = tL_OrderSchmObjList.idSChmObj
		left join  [dbo].[tSchm_Xml] on isnull(cell.subid, isnull(bus.subid, sub.id)) = [tSchm_Xml].ObjId
  where [tSchm_Xml].TypeSchema = 1 --and
  ---( (datebegin >= '20200101' and datebegin <= '20201231 23:59:59') ) 
  and
   ( (beginRes is not null and dateClose is null) ) 
   and (@IdDocument is null or doc.id = @IdDocument)

   order by num
