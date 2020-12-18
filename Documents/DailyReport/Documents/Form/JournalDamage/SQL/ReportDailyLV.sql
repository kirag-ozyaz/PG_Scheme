--use ges;
--declare @date smalldatetime;
--set @date = '20151105';

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

cell	(cellId, cellName, busId, busName, subId, subName, deleted) AS
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
JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id 

WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0)))


select d.id,
	   d.numRequest,
	   d.dateDoc,
	   case when map.idMap is not null then 
			kladrObj.name + ' ' + KladrObj.socr + ', ' + s.name + ' ' + s.socr + ', ' + cast(map.house as varchar(10)) + isnull(map.houseprefix, '') 
			+ isnull(char(13) + char(10) + d.defectLocation, '')
	   else case when line.id is not null then
			line.name + isnull(char(13) + char(10) + d.defectLocation, '')
			else d.defectLocation end end as defectLocation,
	   reason.name as reason, 
	   d.idSchmObj, 
	   isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+
			isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') as schmObjName,
		DamageCharacter.[Character],
		d.dateApply,
		isnull(complWork.name, '') + isnull(char(13)+char(10) + d.ComletedWorkText, '') as completedWork,
		workCompiler.fio as workCompiler, 
		workApply.fio as workApply,
		cNet.name as NetRegion
from tj_damage d
	left join tMapObj map on map.idMap = d.idMap
	left join tr_kladrStreet s on s.id = map.street
	left join tr_kladrObj kladrObj on kladrObj.id = s.kladrObjId
	left join tSChm_ObjList line on line.id = d.idLineSchmObj
	
	left join tR_Classifier reason on reason.id = d.idREason
	left join cell on cell.cellid = d.idSchmObj
	left join bus on bus.id = d.idSChmObj
	left join sub on sub.id = d.idSChmObj
	
	inner join (select id, 
					[Character] = (select isnull(col1.name, '') + isnull(',' + col2.name, '') + isnull(','+ col3.name, '') + '; '
									from dbo.tJ_DamageCharacter ch
										left join tr_Classifier col1 on col1.id = ch.col1
										left join tr_Classifier col2 on col2.id = ch.col2
										left join tr_Classifier col3 on col3.id = ch.col3
									where ch.idDamage = t.id for xml path(''))									
				from tj_Damage t) as DamageCharacter on damagecharacter.id = d.id
	left join tr_classifier complWork on complWork.id = d.idCompletedWork
	left join vr_worker workCompiler on WorkCompiler.id = d.idCompiler
	left join vr_worker workApply on workApply.id = d.idWorkerApply
	left join vP_SubstationByNetRegion subP on subP.id = isnull(cell.subid, isnull(bus.subid, sub.id))
	left join tR_Classifier cNet on cNet.id = subP.idNetREgion -- cNet.ParentKey = ';NetworkAreas;' and cNet.deleted = 0 and cNet.isGRoup = 0 and cNet.VAlue = subP.netREgionVAlue
where 	CAST(FLOOR(CAST(d.dateDoc AS FLOAT)) AS DATETIME) = @date and
		d.typeDoc = 1401 and d.deleted = 0
order by d.numRequest desc