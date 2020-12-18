select chNameCol1.SocrName, doc.datedoc, dbo.fn_Schm_GetFullNameObjById(doc.idSchmObj),doc.* 
from tj_Damage doc 
	left join tJ_DamageCharacter ch on ch.id = (select top 1 id -- ch - строка с отключаем объектом
												from tJ_DamageCharacter
												where idDamage = doc.id)
	left join tr_classifier chNameCol1 on chNameCol1.id = ch.col1	-- тип (характер отключаемого объекта)
	where   ch.idDamage = @idDamage and doc.TypeDoc = 1874
	and doc.deleted = 0  and Year(doc.DateDoc) >= 2019
order by id desc