--use ges;
--declare @dateBeg smalldatetime;
--declare @dateEnd smalldatetime;
--set @dateBeg = '20160113';
--set @dateEnd = '20160323';

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
  	   isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+
			isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') as schmObjName,
	   case when pass.charvalue = 'Балансовая' then 'бал' else case when pass.charvalue = 'Абонентская' then 'аб' else null end end as subscriber,
	   dHV.PowerA,
	   dHV.CountSchmObj,
	   dHV.ConnectedPower,
	   d.dateDoc,
	   dOn.dateOn as dateApply, -- Задача 1511
	   --d.dateApply,
	   typeRZA.name as typeRZA,
	   dHV.NoAdmissionKWT,
	   reason.name + isnull(char(13)+char(10) + d.defectLocation, '') as reasonAndLocation, 
	   DamageCharacter.[Character],
	   isnull(complWork.name, '') + isnull(char(13)+char(10) + d.ComletedWorkText, '') as completedWork,
	   compiler.fio as compiler
from tj_damage d
	left join tj_damageHV dHV on dHV.idDAmage = d.id
	left join tR_Classifier typeRZA on typeRZA.id = dHV.idTypeRZA
	left join tR_Classifier reason on reason.id = d.idREason
	left join cell on cell.cellid = d.idSchmObj
	left join bus on bus.id = d.idSChmObj
	left join sub on sub.id = d.idSChmObj
    left join vP_PassportDataReports pass on pass.typecodeid in (538,535,537,536) and 
											 pass.[CharName] like 'Принадлежность' and 
											 pass.idObj = isnull(cell.subid, isnull(bus.subid, sub.id))
	inner join (select id, 
					[Character] = (select isnull(col1.name, '') +
									isnull(',' + dbo.fn_Schm_GetFullNameObjById(ch.idSChmObj), '') +
									isnull(',' + case when pass.charvalue = 'Балансовая' then 'бал' else case when pass.charvalue = 'Абонентская' then 'аб' else null end end, '') +
									isnull(',' + col2.name, '') + isnull(','+ col3.name, '') + '; '
									from dbo.tJ_DamageCharacter ch
										left join tr_Classifier col1 on col1.id = ch.col1
										left join tr_Classifier col2 on col2.id = ch.col2
										left join tr_Classifier col3 on col3.id = ch.col3
										left join vP_PassportDataReports pass on pass.idObj = ch.idSChmObj
											 and pass.[CharName] like 'Принадлежность' 											 
									where ch.idDamage = t.id for xml path(''))									
				from tj_Damage t) as DamageCharacter on damagecharacter.id = d.id
	left join tr_classifier complWork on complWork.id = d.idCompletedWork
	left join vr_worker compiler on compiler.id = d.idCompiler	
	left join tj_damageOn dOn on dOn.id = (select top 1 id
											from tj_damageOn
											where idDamage = d.id
											order by dateOn desc)
where 	d.dateDoc >= @dateBeg and d.dateDoc <= @dateEnd and
		d.typeDoc = 1402 and d.deleted = 0
order by d.numRequest desc
