------select *
------from
------(
------select /*d.id, datepart(MM,d.DateDoc) as [Month],*/ d.idDivision as typeNetReg--, c_d.Name as Name
------, dChar.col1 as typeEquip, det.isCrash
------from tJ_Damage as d
------inner join tJ_DamageActDetection as det on det.idDamage = d.id
------left join tR_Classifier as c_d on c_d.Id = d.idDivision
------left join tJ_DamageCharacter as dChar on d.id = dChar.idDamage
------where d.Deleted = '0'
------and d.idDivision is not null and dChar.col1 is not null
------and ((d.dateDoc >= @dateBegin and d.dateDoc <= @dateEnd) or d.dateDoc is null)
------) as sq
------pivot (count(typeEquip) for typeEquip in ([1518], [1519], [1520], [2308])) as pt


--use ges; 
--declare @dateBegin smalldatetime;
--set @dateBegin = '20200101';
--declare @dateEnd smalldatetime;
--set @dateEnd = '20201231';
--declare @docNN integer; set @docNN = 1401;
--declare @docVN integer; set @docVN = 1402;

with ListTypeDoc(TypeDoc ) as
(select @docNN TypeDoc union select @docVN)
select *
from
(
select /*d.id, datepart(MM,d.DateDoc) as [Month],*/ d.idDivision as typeNetReg--, c_d.Name as Name
, dChar.col1 as typeEquip, det.isCrash
--, Case docParent.TypeDoc when 1401 then 'НН' when 1402 then 'ВН' end Voltage
from tJ_Damage as d
inner join tJ_DamageActDetection as det on det.idDamage = d.id
left join tR_Classifier as c_d on c_d.Id = d.idDivision
left join tJ_DamageCharacter as dChar on d.id = dChar.idDamage
left join tJ_Damage as docParent on d.idParent = docParent.id
where d.Deleted = '0'
and d.idDivision is not null and dChar.col1 is not null
and ((d.dateDoc >= @dateBegin and d.dateDoc <= @dateEnd) or d.dateDoc is null)
and docParent.TypeDoc in (Select TypeDoc From ListTypeDoc)
) as sq
pivot (count(typeEquip) for typeEquip in ([1518], [1519], [1520], [2308])) as pt