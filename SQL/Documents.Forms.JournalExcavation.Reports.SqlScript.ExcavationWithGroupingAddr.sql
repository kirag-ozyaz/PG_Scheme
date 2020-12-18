;with vJ_Exc([id], [idContractor], [dateBeg], [typeWork], [typeWorkName], 
[workComment], [region], [address], [nameKL], [statusOrder], [dateEndOrder], [dateEndPlanned],
[permission], [statusWork], [agreed], [damage], [recovery]) as
(
select ex.id, ex.idContractor, ex.dateBeg, ex.TypeWork, cWork.name as typeWorkName,
sWork.Comment as workComment, adr.region, 
case when (len(adr.[address]) > 2) then substring(adr.[address], 0, len(adr.[address])-2) else null end as [address],
substring(schmObj.nameKL, 0, len(schmObj.nameKL)-2) as nameKL, cOrder.name as statusOrder, 
case when cOrder.value = 4 then sOrder.dateElongation else ex.dateEndOrder end as dateEndOrder,
ex.dateEnd as dateEndPlanned, 
'№'+ex.numpermission + char(13) + char(10) + 'от '+ Convert(varchar(10),ex.datePermission,104) as permission,
cStatusWork.name as statusWork, ex.agreed, tDamage.damage, tRecovery.[recovery]
from tJ_Excavation as ex left join
tr_classifier cWork on cWork.id = ex.typeWork
inner join (select t.id, 
			region = (select top 1 c.name
						from tj_excavationaddress td 
						left join tr_classifier c on c.id = td.idRegion 
						where t.id = td.idExcavation),
			[address] = (select cast(s.name + ' ' + isnull(s.socr,'') + isnull(', д.' + td.house,'') + ';'+char(13)+char(10) as varchar(max))
						from tj_excavationaddress td
						left join tr_kladrstreet s on s.id = td.idstreet
						where t.id = td.idExcavation for xml path(''),TYPE).value('.','varchar(max)')
			from tj_excavation t) as adr on adr.id = ex.id
inner join (select t.id, 
			[nameKL] = (select cast(td.name+';'+char(13)+char(10) as varchar(max))
						from vj_excavationSchmObj td 
						where t.id = td.idExcavation for xml path(''),TYPE).value('.','varchar(max)')
			from tj_excavation t) as schmObj on schmObj.id = ex.id
inner join (select t.id, 
			[damage] = (select cast(td.surName+';' as varchar(max))
						from vj_excavationSurface td 
						where t.id = td.idExcavation and td.idType = 1 for xml path(''),TYPE).value('.','varchar(max)')
			from tj_excavation t) as tdamage on tDamage.id = ex.id
inner join (select t.id, 
			[recovery] = (select cast(trec.surName+';' as varchar(max))
						from vj_excavationSurface trec 
						where t.id = trec.idExcavation and trec.idType = 2 for xml path(''),TYPE).value('.','varchar(max)')
			from tj_excavation t) as tRecovery on tRecovery.id = ex.id
left join tj_excavationstatus sOrder on sOrder.id = (select top 1 id
													from tj_excavationstatus
													where idExcavation = ex.id and idType = 1
													order by datechange desc)
left join tr_classifier cOrder on cOrder.id = sOrder.idStatus
left join tj_excavationstatus sWork on sWork.id = (select top 1 id
													from tj_excavationstatus
													where idExcavation = ex.id and idType = 2
													order by datechange desc)
left join tr_classifier cStatusWork on cStatusWork.id = sWork.idStatus
)

select exc.*
from vJ_Exc as exc
left join tj_excavationstatus sOrder on sOrder.id = (select top 1 id from tj_excavationstatus 
													where idExcavation = exc.id and idType = 1 
													order by datechange desc)
left join tr_classifier cOrder on cOrder.id = sOrder.idStatus 
left join tj_excavationstatus sWork on sWork.id = (select top 1 id from tj_excavationstatus 
													where idExcavation = exc.id and idType = 2  
													order by datechange desc)
left join tr_classifier cStatusWork on cStatusWork.id = sWork.idStatus 
where (cOrder.value not in (1,6) or cOrder.id is null) 
	and (cStatusWork.ParentKey <> ';Excavation;StatusWork;RealEnd;'  or cStatusWork.id is null)
and (exc.dateBeg <= @dateBeg) and 
(exc.dateEndPlanned is null or exc.dateEndPlanned >= @dateEnd) 
