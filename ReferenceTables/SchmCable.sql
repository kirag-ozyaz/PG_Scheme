/*


���������� �������


*/

select oTypeSchmObj.id id, oTypeSchmObj.Name, oTypeSchmObj.TypeCodeId , cTypeSchmObj.Name, cTypeSchmObj.SocrName , cTypeSchmObj.parentkey--, oTypeSchmObj.deleted
,Case 
	when cTypeSchmObj.SocrName  = '��' then '���' 
	when cTypeSchmObj.SocrName  = '���' then '��' 
	else cTypeSchmObj.SocrName 
end TypeCable
from tSchm_ObjList AS oTypeSchmObj
	left join tR_Classifier AS cTypeSchmObj ON oTypeSchmObj.TypeCodeId = cTypeSchmObj.id 
	left join tP_Passport  as passport on passport.[idObjList] = oTypeSchmObj.id

	where (cTypeSchmObj.parentkey = ';SCM;Line;')
	-- and 	 oTypeSchmObj.deleted = 0 
	-- and cTypeSchmObj.SocrName = 'c�'
	order by id
