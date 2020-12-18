/*use ges
declare @dBeg datetime;
declare @dEnd datetime;

set @dBeg = '20161219';
set @dEnd = '20161222';*/

select defect.id, defect.numREquest, defect.dateDoc, div.id as idDivisionApply, div.name as DivisionApply,
		case when defect.completedWorkTextODS = defect.divisionInstruction then
		isnull(defect.completedWorkTextODS, '') else 
		isnull(defect.completedWorkTextODS + char(13)+char(10), '') + isnull(defect.divisionInstruction, '') end 
		+ case when defect.idSChmObj is not null then char(13) + char(10) + [dbo].[fn_Schm_GetFullNameObjById](defect.idSchmObj) end
		+ case when s.id is not null then char(13)+char(10) + isnull(city.name + isnull(' ' + city.socr, '') + ', ', '') + 
					isnull(s.name + isnull(' ' + s.socr, '') + ', ', '') +
					isnull('д. ' + cast(m.house as varchar(10)) + isnull(m.housePrefix, ''), '') +
					isnull(', ' + defect.defectLocation, '')
				else
					isnull(char(13)+char(10)+defect.defectLocation, '') end as divisionInstruction, 
		div.value
		,dam.numREquest as numRequestParent, dam.dateDoc as dateDocParent
		,case when dam.TypeDoc = 1401 then '0,4 кВ' 
			  when dam.TYpeDoc = 1402 then '6-10 кВ' else null end as TypeDocParent
		,defect.isApply
from tr_classifier div
	left join tj_damage as defect on defect.idDivisionApply = div.id and defect.typeDoc in (1403,1844) and defect.iddivisionApply is not null
									and (defect.dateDoc >= @dBeg and defect.dateDoc < @dEnd) and defect.deleted = 0
	left join tj_Damage as dam on dam.id = defect.idParent and dam.deleted = 0
	left join tMapObj m on defect.idMap = m.idMap
	left join tR_KladrStreet s on s.id = isnull(m.Street, defect.idStreet)
	left join tr_KladrObj city on city.id = s.KladrObjid
where div.ParentKey = ';ReportDaily;DivisionApply;' and div.isGroup = 0 and div.deleted = 0 
union all
select defect.id, defect.numREquest, defect.dateDoc, div.id as idDivisionApply, div.name as DivisionApply,
		case when defect.completedWorkTextODS = defect.divisionInstruction then
		isnull(defect.completedWorkTextODS, '') else 
		isnull(defect.completedWorkTextODS + char(13)+char(10), '') + isnull(defect.divisionInstruction, '') end 
		+ case when defect.idSChmObj is not null then char(13) + char(10) + [dbo].[fn_Schm_GetFullNameObjById](defect.idSchmObj) end
		+ case when s.id is not null then char(13)+char(10) + isnull(city.name + isnull(' ' + city.socr, '') + ', ', '') + 
					isnull(s.name + isnull(' ' + s.socr, '') + ', ', '') +
					isnull('д. ' + cast(m.house as varchar(10)) + isnull(m.housePrefix, ''), '') +
					isnull(', ' + defect.defectLocation, '')
				else
					isnull(char(13)+char(10)+defect.defectLocation, '') end as divisionInstruction, 
		div.value
		,dam.numREquest, dam.dateDoc
		,case when dam.TypeDoc = 1401 then '0,4 кВ' 
			  when dam.TYpeDoc = 1402 then '6-10 кВ' else null end as TypeDocNAme
		,defect.isApply
from (select -1 as id, 'Производственная лаборатория' as name, 100.00 as value) as div 
	left join tj_damage as defect on defect.isLaboratory = 1 and defect.typeDoc in (1403,1844) 
					and (defect.dateDoc >= @dBeg and defect.dateDoc < @dEnd) and defect.deleted = 0
	left join tj_Damage as dam on dam.id = defect.idParent and dam.deleted = 0
	left join tMapObj m on defect.idMap = m.idMap
	left join tR_KladrStreet s on s.id = isnull(m.Street, defect.idStreet)
	left join tr_KladrObj city on city.id = s.KladrObjid

order by value