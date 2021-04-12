--use ges; 
--declare @dateBegin smalldatetime;
--set @dateBegin = '20200101';
--declare @dateEnd smalldatetime;
--set @dateEnd = '20201231';
--declare @docNN integer; set @docNN = 1401;
--declare @docVN integer; set @docVN = 1402;

with ListTypeDoc(TypeDoc ) as
(select @docNN TypeDoc union select @docVN)
select pt.*
from
(
select resCrEq.idReasonCrashEquipment as id, c_resCrEq.Name as reasonCode, c_resCrEq.Comment as [Reason], 
dChar.col1 as typeCode, det.isCrash
from tJ_Damage as d
inner join tJ_DamageActDetection as det on det.idDamage = d.id
left join tJ_DamageActDetection as resCrEq on d.id = resCrEq.idDamage
left join tR_Classifier as c_resCrEq on c_resCrEq.Id = resCrEq.idReasonCrashEquipment
left join tJ_DamageCharacter as dChar on d.id = dChar.idDamage
left join tR_Classifier as c_eq on c_eq.Id = dChar.col1
left join tJ_Damage as docParent on d.idParent = docParent.id
where d.Deleted = '0'
and resCrEq.idReasonCrashEquipment is not null and dChar.col1 is not null
and ((d.dateDoc >= @dateBegin and d.dateDoc <= @dateEnd) or d.dateDoc is null)
and docParent.TypeDoc in (Select TypeDoc From ListTypeDoc)
union all
select resCrEq.idReasonCrashEquipment as id, c_resCrEq.Name as reasonCode, c_resCrEq.Comment as [Reason],
d.idDivision as typeCode, det.isCrash
from tJ_Damage as d
inner join tJ_DamageActDetection as det on det.idDamage = d.id
left join tR_Classifier as c_d on c_d.Id = d.idDivision
left join tJ_DamageActDetection as resCrEq on d.id = resCrEq.idDamage
left join tR_Classifier as c_resCrEq on c_resCrEq.Id = resCrEq.idReasonCrashEquipment
left join tJ_DamageCharacter as dChar on d.id = dChar.idDamage
left join tJ_Damage as docParent on d.idParent = docParent.id
where d.Deleted = '0'
and resCrEq.idReasonCrashEquipment is not null and d.idDivision is not null
and ((d.dateDoc >= @dateBegin and d.dateDoc <= @dateEnd) or d.dateDoc is null)
and docParent.TypeDoc in (Select TypeDoc From ListTypeDoc)
) as sq
pivot (count(typeCode) for typeCode in ([756], [757], [758], [759], [1518], [1519], [1520], [2308])) as pt
