--use ges;

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
WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0))),

testing (id, idSchmObj, dateDoc) as 
(select doc.id, ol.id, convert(datetime, doc.[Date], 104) as DateDoc
from vP_CabTesting as doc
inner join tSchm_ObjList as ol on ol.id = doc.idObjList
inner join tR_Classifier as cl on cl.Id = ol.TypeCodeId
where doc.Deleted = '0'
union all
select doc.id, ol.id, convert(datetime, doc.DateDoc, 104)
from tP_DocList as doc
inner join tSchm_ObjList as ol on ol.id = doc.idObjList
inner join tR_Classifier as cl on cl.Id = ol.TypeCodeId
where TypeDoc = '2082' and doc.Deleted = '0')


select d.id as idDamage
	,ad.numCrash
	,isnull(ad.isCrash, 0) as isCrash
	,isnull(dHV.dateDoc, d.dateDoc) as dateDoc
	,isnull(dOn.dateOn, d.dateApply) as dateEnd
	,isnull(dHV.isApply, d.isApply) as isApply
	,netRegion.netRegionVAlue
	,isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), null) as subName		-- подстанция
	,cell.cellname
	,typeRZA.name as TypeRZA
	,col1.name as TypeSchmObj
	,dCh.idSchmObj
	,case when passSubscribe.charValue  = 'Балансовая' then 'бал'
		 when passSubscribe.charValue  = 'Абонентская' then 'аб'
		 else passSubscribe.charValue end as Subscribe
	--,isnull(dHV.defectLocation, d.defectLocation) as defectLocation
	, dbo.fn_Schm_GetFullNameObjById(dCh.idSchmObj) as defectLocation
	,isnull(col2.name + isnull('; ' + col3.name, ''), '') + 
	case when col2.name is null and col3.name is null then nodeDetail.name
	else isnull('; ' + nodeDetail.name, '') end as [Character]
	,abn.name as abnName
	,dHVValue.NoAdmissionKWT
	,case when col1.parentKey = ';ReportDaily;NatureDamage;HV;Subs;' then markSub.name
		else markCable.CableMakeup + '-' + cast(markCable.wires as varchar(8)) + 'x' + 
           convert(varchar(20), convert(float, markCable.CrossSection))  
           + isnull('+' + cast(markCable.wiresAddl as varchar(8))+'x'+convert(varchar(20), convert(float, markCable.CrossSectionAddl))+'(N)'  , '') 
           + isnull('-' + convert(varchar(20),convert(float, cmarkCable.Value)), '') end as Mark
	,case when passIn.charValue is null or passIn.CharValue = '' then null 
		 when  passIn.[CharName] in ('Год прокладки',  'Год изготовления') then 
		  case when cast(passIn.charValue as int) > 0 then cast(passIn.charValue as int) else null end
		 when cast(substring(passIn.CharValue, 7, 4) as int) > 1990 then cast(substring(passIn.CharValue, 6, 4) as int)
		 else null end as passIn
	,passLength.CharValue as LineLenght
	,testing.dateDoc as DateTesting
	,dCh.timeRecovery
from tj_damage d
	left join tJ_DamageActDetection ad on ad.idDamage = d.id
	outer APPLY Defection.nodes('/NewDataSet/dtDefection') AS T(C)
	left join tAbn abn on abn.id = T.C.query('.').value('(/dtDefection/idOrg)[1]', 'int')
	left join tJ_Damage dHV on dHV.id = d.idParent and dHV.TypeDoc = 1402
	left join tJ_damageHV dHVValue on dHVVAlue.IDDamage = dHV.id
	left join tr_Classifier typeRZA on typeRZA.id = dHVVAlue.idTYpeRZA
	left join tj_DamageOn dOn on dOn.id = (select top 1 id 
										   from tj_damageOn 
										   where idDAmage = dhv.id
										   order by dateOn desc)
	outer apply (select top 1 * from cell
				where cellid = d.idSchmObj) cell
	left join bus on bus.id = d.idSChmObj
	left join sub on sub.id = d.idSChmObj
	left join [vP_SubstationByNetRegion] netRegion on netRegion.id = isnull(cell.subid, isnull(bus.subid, sub.id)) 
	left join tj_DamageCharacter dCh on dCh.idDAmage = d.id
	left join tj_DamageCharacter dHVCH on dHVCh.id = (select top 1 id from tj_damageCharacter where idDamage = dHv.id)
	left join tr_classifier col1 on col1.id = dCh.col1
	left join tr_classifier col2 on col2.id = isnull(dHVCh.col2, dCh.col2)
	left join tr_classifier col3 on col3.id = isnull(dHVCh.col3, dCh.col3)
	left join tr_Classifier nodeDetail on nodeDetail.id = dCh.nodeDetail
	left join vP_PassportDataReports passSubscribe on passSubscribe.idObj = dCh.idSchmObj and
											   passSubscribe.[CharName] = 'Принадлежность' 
	left join tP_ValueLists markSub on markSub.id = dCh.IdMark 
	left join tr_Cable markCable on markCable.id = dCh.idMark
	left join tr_Classifier cMarkCable on cMarkCable.id = markCable.idVoltage
	left join vP_PassportDataReports passIn on passIn.idObj = dCh.idSchmObj and
											   passIn.[CharName] in ('Дата ввода в эксплуатацию', 'Год прокладки',  'Год изготовления')
	left join vP_PassportDataReports passLength on passLength.idObj = dCh.idSchmObj and
											   passLength.[CharName] in ('Протяженность линии', 'Длина трассы')
	left join testing on testing.id = (select top 1 id from testing
										where idSchmObj = dCh.idSChmObj
										order by datedoc desc)
--where (d.typedoc = 1874 or (d.typeDoc = 1844 and d.idParent is null))

