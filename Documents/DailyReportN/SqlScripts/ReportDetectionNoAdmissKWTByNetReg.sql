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
select d.idDivision, dhv.NoAdmissionKWT, det.isCrash
from tJ_Damage as d
inner join tJ_DamageActDetection as det on det.idDamage = d.id
inner join tJ_Damage as dP on dP.id = d.idParent
left join tJ_DamageHV as dHV on dHV.idDamage = dP.id
left join tR_Classifier as c_NetReg on c_NetReg.Id = d.idDivision
left join tJ_Damage as docParent on d.idParent = docParent.id
where d.idDivision is not null
and ((d.dateDoc >= @dateBegin and d.dateDoc <= @dateEnd) or d.dateDoc is null)
and docParent.TypeDoc in (Select TypeDoc From ListTypeDoc)
) sq
pivot (sum(NoAdmissionKWT) for idDivision in ([756], [757], [758], [759])) as pt