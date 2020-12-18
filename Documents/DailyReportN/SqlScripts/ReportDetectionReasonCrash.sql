select pt.*
from
(
select resCr.idReasonCrash as id, c_resCr.Name as reasonCode, c_resCr.Comment as Reason, 
dChar.col1 as typeCode, det.isCrash
from tJ_Damage as d
inner join tJ_DamageActDetection as det on det.idDamage = d.id
left join tJ_DamageActDetection as resCr on d.id = resCr.idDamage
left join tR_Classifier as c_resCr on c_resCr.Id = resCr.idReasonCrash
left join tJ_DamageCharacter as dChar on d.id = dChar.idDamage
left join tR_Classifier as c_eq on c_eq.Id = dChar.col1
where d.Deleted = '0'
and resCr.idReasonCrash is not null and dChar.col1 is not null
and ((d.dateDoc >= @dateBegin and d.dateDoc <= @dateEnd) or d.dateDoc is null)
union all
select resCr.idReasonCrash as id, c_resCr.Name as reasonCode, c_resCr.Comment as Reason,
d.idDivision as typeCode, det.isCrash
from tJ_Damage as d
inner join tJ_DamageActDetection as det on det.idDamage = d.id
left join tR_Classifier as c_d on c_d.Id = d.idDivision
left join tJ_DamageActDetection as resCr on d.id = resCr.idDamage
left join tR_Classifier as c_resCr on c_resCr.Id = resCr.idReasonCrash
left join tJ_DamageCharacter as dChar on d.id = dChar.idDamage
where d.Deleted = '0'
and resCr.idReasonCrash is not null and d.idDivision is not null
and ((d.dateDoc >= @dateBegin and d.dateDoc <= @dateEnd) or d.dateDoc is null)
) as sq
pivot (count(typeCode) for typeCode in ([756], [757], [758], [759], [1518], [1519], [1520], [2308])) as pt