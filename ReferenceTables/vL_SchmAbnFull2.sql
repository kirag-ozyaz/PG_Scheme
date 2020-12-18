/*3*/
--USE [GES]
--GO

with ActiveObj (idAbnObj,isActive) as
(select  abnObjDog.id, 1 from  tAbnDoc_List lst 
						inner JOIN tAbnDoc_Dogovor dog ON dog.idList = lst.id 
					    inner JOIN tG_Dog_Obj obj ON obj.idDog = dog.id
						inner JOIN tAbnObj AS abnobjDog ON abnobjDog.id = obj.idObj 
				where  lst.deleted = 0 and lst.isActive <> 0  and (dog.FlagBreak = 0 or dog.FlagBreak is null) and obj.dateEnd is null
				group by abnObjDog.id),
sub (Id, FullName, deleted) AS
(SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text], o.deleted
FROM tSchm_ObjList AS o
LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id
WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))),

bus (Id, busName, subid, subname, deleted) AS
(SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name, 
		case when o.deleted = 0 and sub.deleted = 0 then 0 else 1 end
FROM tSchm_ObjList AS o 
	JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id
	join tSChm_ObjList sub on sub.id = o.idParent
	join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id
WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0))),

cell	(cellId, cellName, busId, busName, subId, subName, deleted) AS
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
WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0))),

abnAll(idLink,idAbn,	codeAbonent,	nameAbn,	typeAbn,	abnActive,	idAbnObj,	nameObj,	idCity,	City,	id,	streetname,	house,	objActive,	CategoryName,	idTariff,	TarifName,	TariffParentKey, TariffNameSocr,	PowerSet, PowerFact, contact, abnNet, abnServicing, idSchmObj, TypeDoc, cellId, CellName, busid, busname, subid, subname, schmObjName, commentODS, Voltage, RealAbonent, idConsumerGroup, ConsumerGroupName, CountMeter) as
-- ЮРИКИ
(select link.id as idLink, abn.id as idAbn, abn.codeAbonent, abn.name as nameAbn, abn.typeAbn,
		isnull(statusAbn.isActive, 1) as abnActive, 
		abnObj.id as idAbnObj, abnObj.name as nameObj,
        klObj.Id AS idCity,
        klObj.Name + ' ' + ISNULL(klObj.Socr, '') AS City,
		street.id, street.name + isnull(' ' + street.socr, '') as streetname, CONVERT(varchar(10), map.House) + ISNULL(map.HousePrefix, '') AS house,
		isnull(ActiveObj.isActive, 0) as objActive,
		clcategory.Name AS CategoryName,
		abnobjreg.idTariff,
		isnull(cltr.name, 'НН') AS TarifName,
		isnull(cltr.ParentKey, ';SKUEE;Tariff;TariffLeg;') TariffParentKey, 
		cltr.socrname as TariffNameSocr,
		isnull(abnobjreg.PowerSet, 0) as PowerSet, 
        abnobjreg.PowerFact,
        contact.details as contact,
        abnNet.Name as abnNet,
        abnServicing.Name as abnServicing,
        link.idSchmObj,
       	link.TypeDoc,
        cell.cellId, cell.CellName,  
		isnull(cell.busId, bus.id) as busid,
		isnull(cell.BusName, bus.busname) as busname,
		isnull(cell.subid, isnull(bus.subid, sub.id)) as subid,
		isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname,
		isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+
			isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') as schmObjName
		,abnobjREg.commentODS
		, isnull(cltr.Comment,'НН') Voltage
		, case 
		    when abn.CodeAbonent <= 0 then 0
			when abnobjreg.idStatus not in (241,242,1293) then  0
			when charindex('ОДН ', abnObj.name) = 0 and charindex('ОДН,', abnObj.name) = 0 and substring(abnObj.name,1,3) != 'ОДН' 
			  and charindex('нулевой ', cltr.name) = 0 
			  and charindex('компенсация', cltr.name) = 0
			  and charindex('бездоговорное', cltr.name) = 0
			  and charindex('двухставочный', cltr.name) = 0	
			  and charindex('одноставочный', cltr.name) = 0 then 1
			 else 0
		end as RealAbonent -- показатель учитывающий реального абонента на основании тарифа
		--, abnobjREg.idAbnNet idAbnNet
		, abnobjReg.ConsumerGroup idConsumerGroup
		, cConsumerGroup.Name ConsumerGroupName
		, isnull(case when meter.CountMeter = 0 then 1 else CountMeter end, 0) as CountMeter
from tAbn abn
		left JOIN tAbnStatus AS statusAbn ON statusAbn.id =
												(SELECT     TOP (1) id
												 FROM dbo.tAbnStatus
												 WHERE (idAbn = abn.id)
												 ORDER BY DateChange DESC)
		left join tAbnObj abnObj on abnObj.idAbn = abn.id 	
		left join tl_SchmAbn link on link.idAbnObj = abnObj.id
		left join cell on cell.cellid = link.idSchmObj
		left join bus on bus.id = link.idSChmObj
		left join sub on sub.id = link.idSChmObj
		
		left join tMapObj AS map ON map.idMap = abnObj.idMap
		left join tR_KladrStreet AS street ON street.Id = map.Street 
        left join dbo.tR_KladrObj AS klObj ON klObj.Id = street.KladrObjId
		left join ActiveObj on ActiveObj.idAbnObj = abnObj.id
		LEFT JOIN dbo.tAbnObjReg AS abnobjreg ON abnobjreg.id =
                   (SELECT TOP (1) id
                    FROM   dbo.tAbnObjReg
                    WHERE (idAbnObj = abnobj.id)
                    ORDER BY DateChange DESC) 
		left join tAbn abnNet on abnNet.id = abnObjreg.idAbnNet   
		left join tAbn abnServicing on abnServicing.id = abnObjreg.idAbnServicing                 
        --LEFT JOIN dbo.tR_Classifier AS clcategory ON abnobjreg.Category = clcategory.Id
		LEFT JOIN dbo.tR_Classifier AS clcategory ON (case when abn.TypeAbn = 231 and abnobjreg.category is null then -1 -- сетевая организация
			else
				case when abn.typeAbn = 206 and abnobjreg.category is null then 493 -- если у физика нет категории - ставим ему третью
				--when idPoint is null then -1
				else 
					case when  abnobjreg.category is null then 493 
					else abnobjreg.category 
					end 
				end 
			end) = clcategory.Id        
        LEFT JOIN tR_Classifier AS cltr  ON abnobjreg.idTariff = cltr.Id
		left join tR_Classifier as cConsumerGroup on cConsumerGroup.id = abnobjReg.ConsumerGroup
        left join (select t.id,
					Details = (select td.Phone + '; ' from tabncontact td where t.id = td.idAbn for xml path(''))
				   from	tabn t) as contact on contact.id = abn.id
		left join vG_ObjMeter_Count meter on meter.idObj = abnObj.id
where abn.typeAbn in (207,230,231) and abn.deleted = 0  
		and isnull(cell.deleted, 0) = 0 and isnull(bus.deleted, 0) = 0 and isnull(sub.deleted, 0) = 0
union all
--ФИЗИКИ
select link.id as idLink, abn.id as idAbn, abn.codeAbonent, abn.name as nameAbn, abn.typeAbn,
	isnull(statusAbn.isActive,1) as abnActive, 
	abnObj.id as idAbnObj, 
    street.Name + ' ' + street.Socr + ', д.' + CAST(map.House AS varchar(10)) + ISNULL(map.HousePrefix, '') + isnull(', кв.' + abnObj.name,'') as nameObj,
    klObj.Id AS idCity,
    klObj.Name + ' ' + ISNULL(klObj.Socr, '') AS City,
	street.id, street.name + isnull(' ' + street.socr, '') as streetname, CONVERT(varchar(10), map.House) + ISNULL(map.HousePrefix, '') AS house ,
	1 as objActive,
	clcategory.Name AS CategoryName,
	abnobjreg.idTariff,
	isnull(cltr.name, 'НН') AS TarifName,
	isnull(cltr.ParentKey, ';SKUEE;Tariff;TariffFL;') TariffParentKey, 
	cltr.socrname as TariffNameSocr,
	isnull(abnobjreg.PowerSet, 0) as PowerSet, 
	abnobjreg.PowerFact,
	contact.details as contact,
	null,
	null,
	link.idSchmObj,
	link.TypeDoc,
        cell.cellId, cell.CellName,  
		isnull(cell.busId, bus.id) as busid,
		isnull(cell.BusName, bus.busname) as busname,
		isnull(cell.subid, isnull(bus.subid, sub.id)) as subid,
		isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname,
		isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+
			isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') as schmObjName
	,abnobjREg.commentODS
	, isnull(cltr.Comment,'НН') Voltage
	, 1 RealAbonent -- показатель учитывающий реального абонента на основании тарифа
	, '' idConsumerGroup, '' ConsumerGroupName
	, 1 as CountMeter
from tAbn abn
		left JOIN dbo.tAbnStatus AS statusAbn ON statusAbn.id =
												(SELECT     TOP (1) id
												 FROM dbo.tAbnStatus
												 WHERE (idAbn = abn.id)
												 ORDER BY DateChange DESC)
		left join tAbnObj abnObj on abnObj.idAbn = abn.id 	
		left join tl_SchmAbn link on link.idAbnObj = abnObj.id
		left join cell on cell.cellid = link.idSchmObj
		left join bus on bus.id = link.idSChmObj
		left join sub on sub.id = link.idSChmObj
		
		left join tMapObj AS map ON map.idMap = abnObj.idMap
		left join tR_KladrStreet AS street ON street.Id = map.Street
        left join dbo.tR_KladrObj AS klObj ON klObj.Id = street.KladrObjId 
		LEFT JOIN dbo.tAbnObjReg AS abnobjreg ON abnobjreg.id =
                   (SELECT TOP (1) id
                    FROM   dbo.tAbnObjReg
                    WHERE (idAbnObj = abnobj.id)
                    ORDER BY DateChange DESC)
        --LEFT JOIN dbo.tR_Classifier AS clcategory ON abnobjreg.Category = clcategory.Id
		LEFT JOIN dbo.tR_Classifier AS clcategory ON (case when abn.TypeAbn = 231 and abnobjreg.category is null then -1 -- сетевая организация
			else
				case when abn.typeAbn = 206 and abnobjreg.category is null then 493 -- если у физика нет категории - ставим ему третью
				--when idPoint is null then -1
				else 
					case when  abnobjreg.category is null then 493 
					else abnobjreg.category 
					end 
				end 
			end) = clcategory.Id        
        LEFT JOIN dbo.tR_Classifier AS cltr  ON abnobjreg.idTariff = cltr.Id
        left join (select t.id,
						  Details = (select td.Phone + '; ' from tabncontact td where t.id = td.idAbn for xml path(''))
				   from   tabn t) as contact on contact.id = abn.id
		
where abn.typeAbn in (206,253) and abn.deleted = 0
		and isnull(cell.deleted, 0) = 0 and isnull(bus.deleted, 0) = 0 and isnull(sub.deleted, 0) = 0

) 

select abn2.* --from abnAll
		,case 
			when countidobj > 0 and countidobj < CountMeter then 
				CountMeter/countidobj + (case when rowid <= CountMeter%countidobj then 1 else 0 end)
			else
				(case 
					when rowid <= CountMeter then 1 
					else 0 
				end)	
		end as CountPoint
		from 
			(select abn.*, 
					row_number() over (partition by abn.idAbnObj order by abn.idAbnObj, abn.idSchmObj) as rowid,	 -- порядковый номер  
					count(abn.idAbnObj) over (partition by abn.idAbnObj) as countidobj	    -- количество присоединений
			from 
				(select distinct abnAll.*, -- link2.idSchmObj idSchmObj2,
					link2.idDoc, /*link2.TypeDoc TypeDoc2,*/ cTypeDoc.name as typeDocName
				from abnAll
					left join (select idAbnObj, idSchmObj,idDoc, TypeDoc
								from tl_SchmAbn 
								group by idAbnObj, idSchmObj,idDoc, TypeDoc
								) link2  on link2.idAbnObj = abnAll.idAbnObj
					left join tR_Classifier cTypeDoc on cTypeDoc.id = link2.TypeDoc) abn
				)	abn2