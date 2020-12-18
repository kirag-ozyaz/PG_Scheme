select pt.*
from
(
select /*d.id,*/ datepart(MM,d.DateDoc) as [Month], dChar.col1 as typeCode--, c_eq.Name as Name
, det.isCrash
from tJ_Damage as d
inner join tJ_DamageActDetection as det on det.idDamage = d.id
left join tJ_DamageCharacter as dChar on d.id = dChar.idDamage
left join tR_Classifier as c_eq on c_eq.Id = dChar.col1
where d.Deleted = '0'
and dchar.col1 is not null
and ((d.dateDoc >= @dateBegin and d.dateDoc <= @dateEnd) or d.dateDoc is null)
union all
select /*d.id,*/ datepart(MM,d.DateDoc) as [Month], d.idDivision as typeCode--, c_d.Name as Name
, det.isCrash
from tJ_Damage as d
inner join tJ_DamageActDetection as det on det.idDamage = d.id
left join tR_Classifier as c_d on c_d.Id = d.idDivision
left join tJ_DamageCharacter as dChar on d.id = dChar.idDamage
where d.Deleted = '0'
and d.idDivision is not null
and ((d.dateDoc >= @dateBegin and d.dateDoc <= @dateEnd) or d.dateDoc is null)
) as sq
pivot (count(typeCode) for typeCode in ([756], [757], [758], [759], [1518], [1519], [1520])) as pt