/*








Юридические лица (активные)






*/
with ActiveObj (idAbnObj,isActive) as
(select  abnObjDog.id, 1 from  tAbnDoc_List lst 
						inner JOIN tAbnDoc_Dogovor dog ON dog.idList = lst.id 
					    inner JOIN tG_Dog_Obj obj ON obj.idDog = dog.id
						inner JOIN tAbnObj AS abnobjDog ON abnobjDog.id = obj.idObj 
				where  lst.deleted = 0 and lst.isActive <> 0  and (dog.FlagBreak = 0 or dog.FlagBreak is null) and obj.dateEnd is null
				group by abnObjDog.id)
select abnObj.id idAbnObj, abnObj.idAbn, abnObj.Name AbnName, kladrObjName as Sity,  StreetName, House, HousePrefix, [Index], nameObj AbnObjName, idSchmObj -- *
, cCategory.name as CateGoryName
,  isnull(objReg.PowerSet,0) PowerSet, objReg.PowerFact
from vAbnObj as abnObj
		 --left join tl_SchmAbn link on link.idAbnObj = abnObj.id
		left join (select idAbnObj,idSchmObj from tl_SchmAbn group by idAbnObj,idSchmObj) as link on link.idAbnObj = abnObj.id
		left join ActiveObj on ActiveObj.idAbnObj = abnObj.id
		left join tAbnObjReg objReg on objReg.id = (select top 1 id from tAbnObjReg
                                                            where idAbnObj = abnObj.id
                                                            order by dateChange desc)		
		LEFT JOIN dbo.tR_Classifier AS cCategory ON (case when abnobj.TypeAbn = 231 and objReg.category is null then -1 -- сетевая организация
													else
														case when abnobj.typeAbn = 206 and objReg.category is null then 493 -- если у физика нет категории - ставим ему третью
														else 
															case when  objReg.category is null then 493 
															else objReg.category 
															end 
														end 
													end) = cCategory.Id   
where isnull(ActiveObj.isActive, 0) = 1