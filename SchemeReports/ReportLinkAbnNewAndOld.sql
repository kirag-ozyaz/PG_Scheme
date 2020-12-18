--use GES;
with ActiveObj (idAbnObj,isActive) as
(select  abnObjDog.id,1 from  tAbnDoc_List lst 
						inner JOIN tAbnDoc_Dogovor dog ON dog.idList = lst.id 
					    inner JOIN tG_Dog_Obj obj ON obj.idDog = dog.id
						inner JOIN tAbnObj AS abnobjDog ON abnobjDog.id = obj.idObj 
				where  lst.deleted = 0 and lst.isActive <> 0 and dog.FlagBreak = 0 and obj.dateEnd is null),
sub (Id, FullName) AS
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

-- ﬁ–» »
select /*link.id as idLink,*/ abn.id as idAbn, abn.codeAbonent, 

		--              abn.name as nameAbn, 
		replace(replace(abn.name, char(10), ' '), char(13), ' ') as nameAbn,
		
		abn.typeAbn,
		isnull(statusAbn.isActive,1) as aBnActive, 
		abnObj.id as idAbnObj, 
		--              abnObj.name as nameObj,
		replace(replace(abnObj.name, char(10), ' '), char(13), ' ') as nameObj, 
		street.id, street.name + isnull(' ' + street.socr, '') as streetname, CONVERT(varchar(10), map.House) + ISNULL(map.HousePrefix, '') AS house,
		--isnull(ActiveObj.isActive, 0) as objActive,
		--clcategory.Name AS CategoryName,
		--cltr.name AS TarifName,
		--abnobjreg.PowerSet, 
        --abnobjreg.PowerFact,
        --contact.details as contact,
        --link.idSchmObj,
        /*cell.cellId, cell.CellName,  
		isnull(cell.busId, bus.id) as busid,
		isnull(cell.BusName, bus.busname) as busname,
		isnull(cell.subid, isnull(bus.subid, sub.id)) as subid,
		isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname,
		isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+
			isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') as schmObjName,*/
		linkSub.NameGroup as subname, 	
        gosConnect.NameGroup as GosTP,
        razr.namegroup as razrTP
        
from tAbn abn
		left JOIN tAbnStatus AS statusAbn ON statusAbn.id =
												(SELECT     TOP (1) id
												 FROM dbo.tAbnStatus
												 WHERE (idAbn = abn.id)
												 ORDER BY DateChange DESC)
		left join tAbnObj abnObj on abnObj.idAbn = abn.id 	
		
        
        left join (select t.id,
					NameGRoup = (select isnull(cell.subname, isnull(bus.subname, sub.fullname)) +'; ' from tl_schmAbn l 
											left join cell on cell.cellid = l.idSchmObj
											left join bus on bus.id = l.idSChmObj
											left join sub on sub.id = l.idSChmObj
							      where l.idAbnObj = t.id group by cell.subname, bus.subname, sub.fullname for xml path(''))
					--NameGroup = (select sub.fullname + '; ' from sub where sub.id = t.idSchmObj group by sub.fullname for xml path(''))
				   from	tAbnObj/* tl_schmAbn*/ t
				   --group by t.idAbnObj
				   ) as linkSub on linkSub.Id = abnObj.id

		
		--left join tl_SchmAbn link on link.idAbnObj = abnObj.id
		/*left join cell on cell.cellid = link.idSchmObj
		left join bus on bus.id = link.idSChmObj
		left join sub on sub.id = link.idSChmObj*/
		
		left join tMapObj AS map ON map.idMap = abnObj.idMap
		left join tR_KladrStreet AS street ON street.Id = map.Street 
		left join ActiveObj on ActiveObj.idAbnObj = abnObj.id
		LEFT JOIN dbo.tAbnObjReg AS abnobjreg ON abnobjreg.id =
                   (SELECT TOP (1) id
                    FROM   dbo.tAbnObjReg
                    WHERE (idAbnObj = abnobj.id)
                    ORDER BY DateChange DESC) 
        --LEFT JOIN dbo.tR_Classifier AS clcategory ON abnobjreg.Category = clcategory.Id
        --LEFT JOIN dbo.tR_Classifier AS cltr  ON abnobjreg.idTariff = cltr.Id
        
	    left join (select t.id,
					NameGroup = (select Name_GRoup + '; ' from tConnect td where t.id = td.idObj group by name_group for xml path(''))
				   from	tabnObj t) as gosConnect on gosConnect.id = abnObj.id
				   
		left join (select r.num_razr, r.date_vidan,
					NameGroup = (
								 select case when td.type_TPRP = 2 then '–œ-' + TP_RP + '; ' 
										else case when td.type_tprp = 3 then '“œ-'+ TP_RP + '; ' 
										else case when td.type_tprp = 5 then '—œ-'+ TP_RP + '; ' end end end
								 from /*[ulges-sql].*/pts.dbo.tbl_PointPodkl td where r.id_razr = td.id_razr group by type_TPRP, TP_RP for xml path('') )
						from  /*[ulges-sql].*/pts.dbo.tbl_razresh r
						
						where r.urovenU in (3,4)) as razr 
								on razr.num_razr = AbnobjReg.numberTP and razr.date_vidan = AbnobjReg.dateTP 
		
		
where /*abnObj.id = 1496062 and*/  abn.typeAbn in (207,230,231)and statusAbn.isActive = 1 and ActiveObj.isActive = 1  and abn.deleted = 0
order by nameAbn, nameObj