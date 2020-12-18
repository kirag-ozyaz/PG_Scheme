select oTypeSchmObj.id id, oTypeSchmObj.Name, oTypeSchmObj.TypeCodeId , ÒTypeSchmObj.Name NameClassificator, ÒTypeSchmObj.SocrName TypeCable, ÒTypeSchmObj.parentkey--, oTypeSchmObj.deleted
, ÒTypeSchmObj.Value
, Case ÒTypeSchmObj.Value
	when '0.4' then '0.38' 
	when '6'   then '6 (6.3)' 
	when '10'  then '10 (10.5)'
	else '0.38' 
end ValueME
,Case 
	when CHARINDEX('Obj',(oTypeSchmObj.Name)) > 0 then Cast(oTypeSchmObj.id as varchar)
	else Cast(oTypeSchmObj.Name as varchar)
end NameCell
from tSchm_ObjList AS oTypeSchmObj
	left join tR_Classifier AS ÒTypeSchmObj ON oTypeSchmObj.TypeCodeId = ÒTypeSchmObj.id 
	
	where (ÒTypeSchmObj.parentkey like ';SCM;Cell;%')

	order by id