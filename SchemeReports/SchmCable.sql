select oTypeSchmObj.id id, oTypeSchmObj.Name, oTypeSchmObj.TypeCodeId , ÒTypeSchmObj.Name, ÒTypeSchmObj.SocrName , ÒTypeSchmObj.parentkey--, oTypeSchmObj.deleted
,Case 
	when ÒTypeSchmObj.SocrName  = '—À' then ' ¬À' 
	when ÒTypeSchmObj.SocrName  = '¬À«' then '¬À' 
	else ÒTypeSchmObj.SocrName 
end TypeCable
from tSchm_ObjList AS oTypeSchmObj
	left join tR_Classifier AS ÒTypeSchmObj ON oTypeSchmObj.TypeCodeId = ÒTypeSchmObj.id 
	left join [dbo].[tP_Passport]  as passport on passport.[idObjList] = oTypeSchmObj.id

	where (ÒTypeSchmObj.parentkey = ';SCM;Line;')
	-- and 	 oTypeSchmObj.deleted = 0 
	-- and ÒTypeSchmObj.SocrName = '—À'
	order by id