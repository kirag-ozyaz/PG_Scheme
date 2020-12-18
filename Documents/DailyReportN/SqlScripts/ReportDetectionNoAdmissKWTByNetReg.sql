select *
from 
(
select d.idDivision, dhv.NoAdmissionKWT, det.isCrash
from tJ_Damage as d
inner join tJ_DamageActDetection as det on det.idDamage = d.id
inner join tJ_Damage as dP on dP.id = d.idParent
left join tJ_DamageHV as dHV on dHV.idDamage = dP.id
left join tR_Classifier as c_NetReg on c_NetReg.Id = d.idDivision
where d.idDivision is not null
and ((d.dateDoc >= @dateBegin and d.dateDoc <= @dateEnd) or d.dateDoc is null)
) sq
pivot (sum(NoAdmissionKWT) for idDivision in ([756], [757], [758], [759])) as pt