/*


Список ячеек

(но могут попасть у которых нет связей в таблицу Relation и двойные - образованные из шинных мостов)



*/
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
		
select 		
		cell.cellId, cell.CellName,  
		isnull(cell.busId, bus.id) as busid,
		isnull(cell.BusName, bus.busname) as busname,
		isnull(cell.subid, isnull(bus.subid, sub.id)) as subid,
		isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname,
		isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+
		isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') as fullname
from  cell
			left join bus on bus.id = cell.cellid
			left join sub on sub.id = cell.cellid
where isnull(cell.deleted, 0) = 0 and isnull(bus.deleted, 0) = 0 and isnull(sub.deleted, 0) = 0
