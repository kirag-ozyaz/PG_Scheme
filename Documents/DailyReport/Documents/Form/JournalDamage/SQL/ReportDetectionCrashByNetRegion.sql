select *
from
(
select /*d.id, datepart(MM,d.DateDoc) as [Month],*/ d.idDivision as typeNetReg--, c_d.Name as Name
, dChar.col1 as typeEquip, det.isCrash
from tJ_Damage as d
inner join tJ_DamageActDetection as det on det.idDamage = d.id
left join tR_Classifier as c_d on c_d.Id = d.idDivision
left join tJ_DamageCharacter as dChar on d.id = dChar.idDamage
where d.Deleted = '0'
and d.idDivision is not null and dChar.col1 is not null
and ((d.dateDoc >= @dateBegin and d.dateDoc <= @dateEnd) or d.dateDoc is null)
) as sq
pivot (count(typeEquip) for typeEquip in ([1518], [1519], [1520])) as pt