-------------------
SELECT  obj.[Id],obj.[Name],'' idParent, obj.typecodeid,(case When oc.value is null then 0 else 1 end) as isSubscriber
 FROM [tSchm_ObjList] as obj
	 left join tP_Passport as p on p.id = (select top 1 id
	  from tp_Passport
	  where idObjList = obj.[Id] and deleted = 0 and isActive = 1
	   order by date desc)
	    left join tP_ObjectChar as oc on oc.[idPassport] = p.id and oc.idobjchar = 174 and oc.value = 293 and oc.deleted=0
		                                  where obj.typecodeid in (538,535,537,536,1034,1275) and obj.deleted=0
union 
select id, name, idParent, '111' typeCodeId, '' from tSChm_ObjList  where TypeCodeId = 111    and deleted = 0
union
select id, name, idParent, typeCodeId, '' from tSchm_ObjList  where typeCodeId in (563,540,564,653) and deleted = 0 and idParent in (select id from tSChm_ObjList where typeCodeId in (538,535,537,536,1034,1275) and deleted = 0)
union
select id, name, idParent, typeCodeId, ''  from tSchm_ObjList where typeCodeId in (547,983,546,548,676,675,678) and deleted = 0 and (idParent in (select id from tSChm_ObjList where typeCodeid in (538,535,537,536,1034,1275) and deleted = 0) or idParent is null)
select id, sourceobj, destobj, edge from tSchm_Relation  where edge in (select id from tSchm_ObjList where deleted = 0)
--------------------
select id, idParent, OnOff, TypeCodeId, Name  from tSchm_ObjList  where typeCodeId in (552,583,600,903,975,1215,1276,3,10,-1) and deleted = 0
-- или нормальная схема
select o.id, o.idParent, case when x.SchemaXml.exist('Obj[@IsNormal cast as xs:string? = "True"]') = 1 then 0 else 1 end  as OnOff, o.TypeCodeId, o.Name from tSchm_ObjList o left join tSchm_xml x on x.id = (select top 1 id  from tSchm_xml  where Objid = o.id order by typeSchema) where typeCodeId in (552,583,600,903,975,1215,1276,3,10,-1) and deleted = 0
-------------------------------------------------------
