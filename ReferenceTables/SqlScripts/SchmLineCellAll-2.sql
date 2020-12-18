/*
#2
Справоник всех линий и ячеек схемы
(данный вариант выполняется 2 сек.)

*/
with cellAll (id, fullname) as (select cell.Id id
	, ISNULL(clSub.SocrName + '-', '') + sub.Name + '\' +ISNULL(clBus.SocrName + '-', '') + bus.Name +'\'+ISNULL(clCell.SocrName + ' ', '') + cell.Name fullname
				from tSchm_ObjList AS bus
					left join tr_classifier clbus on clbus.id = bus.typecodeid
					left join tSchm_ObjList AS point ON bus.id = point.IdParent
					left join tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj
					left join tSchm_ObjList AS cell ON cell.id = rel.edge
					left JOIN tR_Classifier AS clCell ON cell.TypeCodeId = clCell.id AND clCell.ParentKey LIKE ';SCM;Cell;%'
					left join tSchm_ObjList AS sub ON sub.id = bus.IdParent
					left join tr_classifier clsub on clsub.id = sub.typecodeid
	where  bus.Id != cell.Id and clBus.ParentKey like ';SCM;BUS;%' 	
			 and isnull(cell.deleted, 0) = 0 and isnull(bus.deleted, 0) = 0 and isnull(sub.deleted, 0) = 0
			 AND isnull(point.deleted, 0) = 0 
)
-- Должно быть
--';SCM;Line;' = 18542 and  ';SCM;Cell;%' = 25649 (убрать 110 без связей - relation)
/*44191*/
select cell.id, cell.idParent, cell.name,  clCell.name typeCodeName, cell.typeCodeId, (select top 1 fullname from cellall where id = cell.id)  fullname
from tSchm_ObjList AS cell
	left join tr_classifier clCell on clCell.id = cell.typecodeid
	left join tSChm_ObjList sub on cell.idParent = sub.id 
	left join tr_classifier clSub on clSub.id = sub.typecodeid
where (  clCell.ParentKey like ';SCM;Cell;%'  )
      and isnull(cell.deleted, 0) = 0 
      and ((sub.deleted = 0 and clSub.ParentKey like ';SCM;PS;')  or cell.idParent is null)
	  and exists(select top 1 fullname from cellall where id = cell.id)
union all
select cell.id, cell.idParent, cell.name,  clCell.name typeCodeName, cell.typeCodeId,   clCell.socrname + '-' + cell.name fullname
from tSchm_ObjList AS cell
	left join tr_classifier clCell on clCell.id = cell.typecodeid
	left join tSChm_ObjList sub on cell.idParent = sub.id 
	left join tr_classifier clSub on clSub.id = sub.typecodeid
where (clCell.ParentKey like ';SCM;Line;' )
      and isnull(cell.deleted, 0) = 0 
      and ((sub.deleted = 0 and clSub.ParentKey like ';SCM;PS;')  or cell.idParent is null)