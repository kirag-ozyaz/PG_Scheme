with sub (Id, FullName) AS
(SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text]
FROM tSchm_ObjList AS o
LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id
WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))),
bus (Id, busName, subid, subname) AS
(SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name
FROM tSchm_ObjList AS o 
JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id
join tSChm_ObjList sub on sub.id = o.idParent
join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id
WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0))),

cell	(cellId, cellName, busId, busName, subId, subName) AS
(SELECT  cell.Id, ISNULL(c.SocrName + ' ', '') + cell.Name [Text], 
		 bus.id,  ISNULL(cBus.SocrName + '-', '') + bus.Name [Text],
		 sub.id,  ISNULL(cSub.SocrName + '-', '') + sub.Name [Text]
FROM tSchm_ObjList AS bus
JOIN tR_Classifier AS cBus ON bus.TypeCodeId = cBus.id AND cBus.ParentKey LIKE ';SCM;BUS;%'
JOIN tSchm_ObjList AS point ON bus.id = point.IdParent
JOIN tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj
JOIN tSchm_ObjList AS cell ON rel.Edge = cell.id
JOIN tR_Classifier AS c ON cell.TypeCodeId = c.id AND c.ParentKey LIKE ';SCM;Cell;%'
join tschm_objlist as sub on sub.id = bus.idparent
JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id 

WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0)))

select d.id, d.numdoc, d.dateDoc, d.typeDoc, d.comment,
	   dc.numDocIn, dc.dateDocIn, dc.typeDocin,
	   dc.idSchmObjOld, dc.idSchmObjNew,
       isnull(cellOld.subid, isnull(busOld.subid, subOld.id)) as subOldid,
	   isnull(cellOld.subname, isnull(busOld.subname, subOld.fullname)) as subOldname,
	   isnull(isnull(cellOld.subname, isnull(busOld.subname, subOld.fullname)), '')+
			isnull('\' + isnull(cellOld.BusName, busOld.busname), '')+isnull('\'+cellOld.CellName, '') as schmObjNameOld,
			
	   isnull(cellNew.subid, isnull(busNew.subid, subNew.id)) as subNewid,
	   isnull(cellNew.subname, isnull(busNew.subname, subNew.fullname)) as subNewname,
	   isnull(isnull(cellNew.subname, isnull(busNew.subname, subNew.fullname)), '')+
			isnull('\' + isnull(cellNew.BusName, busNew.busname), '')+isnull('\'+cellNew.CellName, '') as schmObjNameNew,
		
	   dc.isApply 
from ttc_doc d
	left join ttc_ChangeSwitch dc on dc.id = d.id
	
	left join cell as cellOld on cellOld.cellid = dc.idSchmObjOld
	left join bus as busOld on busOld.id = dc.idSchmObjOld
	left join sub as subold on subOld.id = dc.idSchmObjOld
		
	left join cell as cellNew on cellNew.cellid = dc.idSchmObjNew
	left join bus as busNew on busNew.id = dc.idSchmObjNew
	left join sub as subNew on subNew.id = dc.idSchmObjNew
where d.typeDoc = 1346