/*use ges;
declare @dateBeg smalldatetime
declare @dateEnd smalldateTime
set @dateBeg = '20161201';
set @dateEnd = '20170101';*/

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
wHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0)))
, categorycount (idDamage, countPointCat1, countPointCat1Full, countPointCat2, countPointCat2Full, 
					countPointCat3, countPointEE, countPointSource,
					countAbnObjCat1, countAbnObjCat1Full, countAbnObjCat2, countAbnObjCat2Full, 
					countAbnObjCat3, countAbnObjEE, countAbnObjSource,
					countAbnObj150, countAbnObj150670, countAbnObj670) as
(select d.id,
T.C.query('.').value('(/AbnOff/CountPoint/@countPointCat1)[1]', 'int' ) as countPointCat1,   
T.C.query('.').value('(/AbnOff/CountPoint/@countPointCat1Full)[1]', 'int' ) as countPointCat1Full,   
T.C.query('.').value('(/AbnOff/CountPoint/@countPointCat2)[1]', 'int' ) as countPointCat2,   
T.C.query('.').value('(/AbnOff/CountPoint/@countPointCat2Full)[1]', 'int' ) as countPointCat2Full,   
T.C.query('.').value('(/AbnOff/CountPoint/@countPointCat3)[1]', 'int' ) as countPointCat3,
T.C.query('.').value('(/AbnOff/CountPoint/@countPointEE)[1]', 'int' ) as countPointEE,
T.C.query('.').value('(/AbnOff/CountPoint/@countPointSource)[1]', 'int' ) as countPointSource,

T.C.query('.').value('(/AbnOff/CountAbnObj/@countAbnObjCat1)[1]', 'int' ) as countAbnObjCat1,   
T.C.query('.').value('(/AbnOff/CountAbnObj/@countAbnObjCat1Full)[1]', 'int' ) as countAbnObjCat1Full,   
T.C.query('.').value('(/AbnOff/CountAbnObj/@countAbnObjCat2)[1]', 'int' ) as countAbnObjCat2,   
T.C.query('.').value('(/AbnOff/CountAbnObj/@countAbnObjCat2Full)[1]', 'int' ) as countAbnObjCat2Full,   
T.C.query('.').value('(/AbnOff/CountAbnObj/@countAbnObjCat3)[1]', 'int' ) as countAbnObjCat3,
T.C.query('.').value('(/AbnOff/CountAbnObj/@countAbnObjEE)[1]', 'int' ) as countAbnObjEE,
T.C.query('.').value('(/AbnOff/CountAbnObj/@countAbnObjSource)[1]', 'int' ) as countAbnObjSource,

T.C.query('.').value('(/AbnOff/CountAbnObj/@countAbnObj150)[1]', 'int' ) as countAbnObj150,   
T.C.query('.').value('(/AbnOff/CountAbnObj/@countAbnObj150670)[1]', 'int' ) as countAbnObj150670,   
T.C.query('.').value('(/AbnOff/CountAbnObj/@countAbnObj670)[1]', 'int' ) as countAbnObj670   

from tj_damage d
	CROSS APPLY CommentXml.nodes('/Doc/AbnOff') AS T(C))

select d.id as IDDAMAGE
		,passSR.charValue as SRName
		,netRegion.netRegionVAlue																-- наименование структурной единицы 
	   ,isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+
			isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') as schmObjName 
	   ,isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), null) as subName		-- подстанция
	   ,chNameCol1.name as TypeSchmObj															-- вид объекта (характер повреждения из первой строки)
	   ,case when dHV.iddamage is null then 0.4 else dHV.PowerV end as PowerV					-- напряжение
	   ,chNameCol2.name as REason																-- причина прекращения ээ
	   ,isnull(dHV.APR, 0) as APV																			-- признак АПВ
	   ,isnull(dhv.AVR, 0) as AVR																			-- признак АВР 
	   -- Количество точек поставки по кот орым произошло прекращение ЭЭ
	   -- точки учета
	   ,categorycount.countPointCat1Full
	   ,categorycount.countPointCat1
	   ,categorycount.countPointCat2Full
	   ,categorycount.countPointCat2
	   ,categorycount.countPointCat3
	   ,categorycount.countPointEE
	   ,categorycount.countPointSource
	   -- объекты
	   ,categorycount.countAbnObjCat1Full
	   ,categorycount.countAbnObjCat1
	   ,categorycount.countAbnObjCat2Full
	   ,categorycount.countAbnObjCat2
	   ,categorycount.countAbnObjCat3
	   ,categorycount.countAbnObjEE
	   ,categorycount.countAbnObjSource

	   ,categorycount.countAbnObj150
	   ,categorycount.countAbnObj150670
	   ,categorycount.countAbnObj670
   
	   ,d.datedoc as dateBegin   -- дата начала заявки
	   ,d.dateApply as dateApply -- дата исполнения заявки
	   ,case when defectLast.DateApply is null or defectLast.dateApply < d.dateApply 
	   then d.dateApply else defectLast.DAteApply end as dateApplyMax
	   ,cTypeDoc.name as TYpeDoc
	   ,case when actD.id is not null then '№' + actD.numRequest + ' от ' + convert( varchar(10),actd.dateDoc, 104)
	   else '№' + d.numRequest + ' от ' + convert( varchar(10),d.dateDoc, 104) end as numDateDoc
from tj_damage d
	left join cell on cell.cellid = d.idSchmObj
	left join bus on bus.id = d.idSChmObj
	left join sub on sub.id = d.idSChmObj
    left join vP_PassportDataReports passSR on passSR.idObj = isnull(cell.subid, isnull(bus.subid, sub.id)) and
											   passSR.typecodeid in (538,535,537,536) and 
											   passSR.[CharName] = 'Сетевой район' 
	left join [vP_SubstationByNetRegion] netRegion on netRegion.id = isnull(cell.subid, isnull(bus.subid, sub.id)) 
	--left join tr_classifier sr on sr.id = passSR.TYpeCodeId
	left join tJ_DamageCharacter ch on ch.id = (select top 1 id 
												from tJ_DamageCharacter
												where idDamage = d.id)									 
	left join tr_classifier chNameCol1 on chNameCol1.id = ch.col1												
	left join tr_classifier chNameCol2 on chNameCol2.id = ch.col2
	left join tj_damageHV dHV on dHV.idDamage = d.id
	left join categorycount on categorycount.iddamage = d.id
	left join tj_damage defectLast on defectLast.id = (select top 1 id from tj_damage
														where idParent = d.id and dateapply is not null 
														and typeDoc in (1403,1844) and deleted = 0
														order by dateApply desc)
	left join tj_damage actD on actD.id	= (select top 1 id from tj_damage 
											where idParent = d.id and typeDoc = 1874 and deleted = 0)
	left join  tR_Classifier cTypeDoc on cTypeDoc.id = isnull (actD.TypeDoc, d.typeDoc)
where d.dateDoc >= @dateBeg and d.datedoc < @dateEnd
	and (d.typeDoc in (1401,1402) or (d.typeDoc in (1403, 1844) and d.idparent is null))
	and d.deleted = 0


