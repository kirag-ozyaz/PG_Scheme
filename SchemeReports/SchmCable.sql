select oTypeSchmObj.id id, oTypeSchmObj.Name, oTypeSchmObj.TypeCodeId , �TypeSchmObj.Name, �TypeSchmObj.SocrName , �TypeSchmObj.parentkey--, oTypeSchmObj.deleted
,Case 
	when �TypeSchmObj.SocrName  = '��' then '���' 
	when �TypeSchmObj.SocrName  = '���' then '��' 
	else �TypeSchmObj.SocrName 
end TypeCable
from tSchm_ObjList AS oTypeSchmObj
	left join tR_Classifier AS �TypeSchmObj ON oTypeSchmObj.TypeCodeId = �TypeSchmObj.id 
	left join [dbo].[tP_Passport]  as passport on passport.[idObjList] = oTypeSchmObj.id

	where (�TypeSchmObj.parentkey = ';SCM;Line;')
	-- and 	 oTypeSchmObj.deleted = 0 
	-- and �TypeSchmObj.SocrName = '��'
	order by id