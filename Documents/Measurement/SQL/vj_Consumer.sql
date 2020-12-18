with 
	ActiveObj (idAbnObj,isActive) as
	    (select  abnObjDog.id,1 from  tAbnDoc_List lst 
            inner JOIN tAbnDoc_Dogovor dog ON dog.idList = lst.id 
            inner JOIN tG_Dog_Obj obj ON obj.idDog = dog.id
            inner JOIN tAbnObj AS abnobjDog ON abnobjDog.id = obj.idObj 
        where  lst.deleted = 0 and lst.isActive <> 0 and dog.FlagBreak = 0 and obj.dateEnd is null
        group by abnObjDog.id) , 
		
	cell (cellId, cellName, busId, busName, subId, subName, deleted) AS
        (SELECT  cell.Id, ISNULL(c.SocrName + ' ', '') + cell.Name [Text], 
             bus.id,  ISNULL(cBus.SocrName + '-', '') + bus.Name [Text],
             sub.id,  ISNULL(cSub.SocrName + '-', '') + sub.Name [Text], 
             case when cell.deleted = 0 and bus.deleted = 0 and sub.deleted = 0 then 0 else 1 end
        FROM tSchm_ObjList AS bus
            JOIN tR_Classifier AS cBus ON bus.TypeCodeId = cBus.id AND cBus.ParentKey LIKE ';SCM;BUS;%'
            JOIN tSchm_ObjList AS point ON bus.id = point.IdParent
            JOIN tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj
            JOIN tSchm_ObjList AS cell ON rel.Edge = cell.id
            JOIN tR_Classifier AS c ON cell.TypeCodeId = c.id AND c.ParentKey LIKE ';SCM;Cell;%'
            join tschm_objlist as sub on sub.id = bus.idparent
            JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id 
        WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0))) ,
		
	bus (Id, busName, subid, subname, deleted) AS
        (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name, 
             case when o.deleted = 0 and sub.deleted = 0 then 0 else 1 end
         FROM tSchm_ObjList AS o 
            JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id
            join tSChm_ObjList sub on sub.id = o.idParent
            join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id
         WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0))) ,

	sub (Id, FullName, deleted) AS
        (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text], o.deleted
        FROM tSchm_ObjList AS o
            LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id
        WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))) ,
		
	pow (idAbnObj, PowerSet, DateChange) AS
	(SELECT distinct idAbnObj, PowerSet, MIN(DateChange) 
		FROM tAbnObjReg
		WHERE PowerSet <> 0 AND PowerSet is not null
		GROUP BY idAbnObj, PowerSet) 		 

	select a.idAbn, a.codeAbonent, a.name as nameAbn, a.typeAbn, 
	    a.TypeAbnName, a.deleted as deletedAbn, a.isActive as activeAbn,
	    a.id as idAbnObj, a.nameObj as nameAbnObj, a.KladrObjName, a.streetname,
	    cast(a.house as varchar(10)) + isnull(a.houseprefix, '') as house,
	    case when a.TypeAbn in (207,230,231) then isnull(ActiveObj.isActive, 0) else 1 end as objActive 
		,link.idSchmObj 
		,cell.CellName 
		,isnull(cell.BusName, bus.busname) as busname 
		,isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname 
		,isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+
		                              isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') as schmObjName 
		,isnull(cell.subid, isnull(bus.subid, sub.id)) as IdSub  
		, PowerSet, DateChange
		from vAbnObj a 
            left join ActiveObj on ActiveObj.idAbnObj = a.id  
			left join tl_SchmAbn link on link.idAbnObj = a.id
			left join cell on cell.cellid = link.idSchmObj
			left join bus on bus.id = link.idSChmObj
			left join sub on sub.id = link.idSChmObj
			left join pow on pow.idAbnObj = a.id
		where (a.TypeAbn in (206,207)) and (a.isActive = 1) and (a.deleted = 0) and (a.TypeAbn not in (207,230,231) or activeObj.isActive = 1) 
		and ActiveObj.idAbnObj = 1881893
