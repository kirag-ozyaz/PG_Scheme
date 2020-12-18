--use ges;
--declare @dt smalldatetime;
--set @dt = '20150302';
--select @dt, datepart(year, @dt) + datepart(month, @dt)
--select dateadd(day, -1, dateadd(month, 1, cast (cast(datepart(year, @dt)as varchar(4))+ '-' + cast(datepart(month, @dt) as varchar(2)) +'-'  + '01' as datetime)))

with abnLegalKWT (Dt, idObj, SumQuantity) as
( SELECT 	d.dtPay as Dt, 	obj.id as idObj, Sum(ds.Quantity) as SumQuantity
FROM tAbn a 
	LEFT JOIN tG_Doc d ON d.idAbn = a.id 
	LEFT JOIN tG_DocSchet ds ON ds.idDoc = d.id 
	LEFT JOIN tAbnObj obj ON obj.id = ds.idAbnObj
WHERE (d.dtPay between cast(cast(datepart(year, @dt)as varchar(4))+ '-' + cast(datepart(month, @dt) as varchar(2)) +'-'  + '01' as datetime) 
	   and dateadd(day, -1, dateadd(month, 1, cast (cast(datepart(year, @dt)as varchar(4))+ '-' + cast(datepart(month, @dt) as varchar(2)) +'-'  + '01' as datetime)))) 
	   and (ds.Summa <> 0) and (ds.Summa is not null) and (d.Blocking <> 0) 
	and (a.codeabonent not in (9028,460)) and ((d.NumberStorno IS NULL) OR (d.NumberStorno = 0))
GROUP BY d.dtPay,a.id,a.CodeAbonent,a.Name,obj.id,obj.Name
),

-- �����
abnLegal (idAbn, codeAbonent, nameAbn, typeAbn, typeAbnName, idAbnObj, nameObj, [address], KladrObjid, kladrObjName,
				category, categoryName, idtariff, tariffname, powerset, powerFact, sumKwt, Consumer, consumerName, contact, abnNet, abnServicing) as
(
select  abnObj.idAbn, abnObj.codeAbonent, isnull(abnInfo.nameFull, abnObj.name) as nameAbn, abnObj.TypeAbn, abnObj.typeAbnName,
		abnObj.id as idAbnObj, abnObj.nameObj, abnObj.address,
		abnObj.KladrObjid, abnObj.KladrObjName, 
		objREg.category, cCategory.name as cateGoryName,
		objReg.idTariff, cTariff.name as tariffName,
		objReg.PowerSet, objReg.PowerFact,
		abnLegalKWT.SumQuantity, -- ����� ���� ����������� � �����
		objReg.Consumer, cConsumer.name as consumerName,
		contact.details as contact,
		abnNet.Name as abnNet,
        abnServicing.Name as abnServicing
from  tAbnDoc_List lst
	inner JOIN tAbnDoc_Dogovor dog ON dog.idList = lst.id 
	inner JOIN tG_Dog_Obj obj ON obj.idDog = dog.id
	inner JOIN vAbnObj AS abnobj ON abnobj.id = obj.idObj 
	left join tg_AbnInfo abnInfo on abnInfo.id = (select top 1 id
												 from tg_abnInfo
												 where idAbn = abnObj.idAbn
												 order by dateChange desc)
	left join tAbnObjReg objReg on objReg.id = (select top 1 id from tAbnObjReg
												where idAbnObj = abnObj.id
												order by dateChange desc)
	left join tR_Classifier cCategory on cCategory.id = objReg.Category
	left join tR_Classifier cTariff on cTariff.id = objReg.idTariff
	left join tR_Classifier cConsumer on cConsumer.id = objReg.Consumer
	
	left join (select t.id,
					Details = (select td.Phone + '; ' from tabncontact td where t.id = td.idAbn for xml path(''))
				   from	tabn t) as contact on contact.id = abnobj.idAbn
	left join tAbn abnNet on abnNet.id = Objreg.idAbnNet   
	left join tAbn abnServicing on abnServicing.id = Objreg.idAbnServicing   
	left join abnLegalKWT on abnLegalKWT.idObj = abnObj.id              
where abnObj.typeAbn in (207,230,231) and abnObj.isActive = 1 and abnObj.deleted = 0
	  and lst.deleted = 0 and lst.isActive <> 0 and (dog.FlagBreak = 0 or dog.FlagBreak is null) and obj.dateEnd is null),
-- ������
abnFL (idAbn, codeAbonent, nameAbn, typeAbn, typeAbnName, idAbnObj, nameObj, [address], KladrObjid, kladrObjName,
				category, categoryName, idtariff, tariffname, powerset, powerFact, sumKwt, Consumer, consumerName, contact, abnNet, abnServicing) as
(
select  abnObj.idAbn, abnObj.codeAbonent, abnObj.name as nameAbn, abnObj.TypeAbn, abnObj.typeAbnName,
		abnObj.id as idAbnObj, abnObj.nameObj, abnObj.address,
		abnObj.KladrObjid, abnObj.KladrObjName, 
		objREg.category, cCategory.name as cateGoryName,
		objReg.idTariff, cTariff.name as tariffName,
		objReg.PowerSet, objReg.PowerFact,
		null,-- ����� ���� ����������� � �����
		objReg.Consumer, cConsumer.name as consumerName,
		contact.details as contact,
		abnNet.Name as abnNet,
        abnServicing.Name as abnServicing
from   vAbnObj AS abnobj 
	left join tAbnObjReg objReg on objReg.id = (select top 1 id from tAbnObjReg
												where idAbnObj = abnObj.id
												order by dateChange desc)
	left join tR_Classifier cCategory on cCategory.id = objReg.Category
	left join tR_Classifier cTariff on cTariff.id = objReg.idTariff
	left join tR_Classifier cConsumer on cConsumer.id = objReg.Consumer
	
	left join (select t.id,
					Details = (select td.Phone + '; ' from tabncontact td where t.id = td.idAbn for xml path(''))
				   from	tabn t) as contact on contact.id = abnobj.idAbn
	left join tAbn abnNet on abnNet.id = Objreg.idAbnNet   
	left join tAbn abnServicing on abnServicing.id = Objreg.idAbnServicing                 
where abnObj.typeAbn in (206,253) and abnObj.isActive = 1 and abnObj.deleted = 0),
-- ��� ��������
abnAll (idAbn, codeAbonent, nameAbn, typeAbn, typeAbnName, idAbnObj, nameObj, [address], KladrObjid, kladrObjName,
				category, categoryName, idtariff, tariffname, powerset, powerFact, sumkwt, Consumer, consumerName, contact, abnNet, abnServicing) as
(	
	select * from abnLegal
	union all
	select * from  abnFL),

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
JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id )
	
	
select  abnAll.*,
		link.idSchmObj,
		link.idDoc,	link.TypeDoc, cTypeDoc.name as typeDocName,
        cell.cellId, cell.CellName,  
		isnull(cell.busId, bus.id) as busid,
		isnull(cell.BusName, bus.busname) as busname,
		isnull(cell.subid, isnull(bus.subid, sub.id)) as subid,
		isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname,
		isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+
			isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') as schmObjName
from abnAll
    left join tl_SchmAbn link on link.idAbnObj = abnAll.idAbnObj
	left join tR_Classifier cTypeDoc on cTypeDoc.id = link.TypeDoc
	left join cell on cell.cellid = link.idSchmObj
	left join bus on bus.id = link.idSChmObj
	left join sub on sub.id = link.idSChmObj
where isnull(cell.deleted, 0) = 0 and isnull(bus.deleted, 0) = 0 and isnull(sub.deleted, 0) = 0	
