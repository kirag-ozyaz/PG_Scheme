/*4*/
/*
Получение списка привязок объектов абонентов без ограничения по периоду возникговения и отборов
*/
--USE [GES]
----GO
--declare @listIdAbnObj varchar(max)
--set @listIdAbnObj = '1887352,1889497,1493217,1889498,1493216,1877627,1488318,1879041,1765536,1880792,1889295,1880611,1872456,1493015,1885818,1873156,1875760,1493219,1765478,1492341,1494922,1494921,1880612,1765480,1887497,1483230,1493016,1891120,1493215';
DECLARE @XIdAbnObj XML;
set @XIdAbnObj =  Case
		when @listIdAbnObj is not null then  CAST('<i>' + REPLACE(@listIdAbnObj,',','</i><i>') + '</i>' AS XML)
		else null
	end;

--declare @dt smalldatetime;
--set @dt = '2017-01-02 18:44:00';
with 
-- ЮРИКИ
abnLegal (idAbn, codeAbonent,  nameAbn, typeAbn, idAbnObj, nameObj, CategoryName, idTariff, TarifName,  TariffParentKey, powerset,  idAbnNet, abnNet, CountMeter, CommentODS, idConsumerGroup, ConsumerGroupName) as
(
select  abnObj.idAbn,
 abnObj.codeAbonent, 
 abnObj.name nameAbn,	
 abnObj.TypeAbn, 
 abnObj.id as idAbnObj, 
 abnObj.nameObj,
 cCategory.name as CateGoryName, 
 objReg.idTariff, 
 isnull(cTariff.name, 'НН') AS TarifName,
 isnull(cTariff.ParentKey, ';SKUEE;Tariff;TariffLeg;') TariffParentKey,
 isnull(objReg.PowerSet,0), 
 isnull(abnNet.id, -1), 
 abnNet.Name as abnNet, 
 isnull(case when meter.CountMeter = 0 then 1 else CountMeter end, 0) as CountMeter, 
 objReg.CommentODS,
 objReg.ConsumerGroup idConsumerGroup, 
 cConsumerGroup.Name ConsumerGroupName
from  tAbnDoc_List lst
     left JOIN tAbnDoc_Dogovor dog ON dog.idList = lst.id 
     left JOIN tG_Dog_Obj obj ON obj.idDog = dog.id
     left JOIN vAbnObj AS abnobj ON abnobj.id = obj.idObj 
     --left join tg_AbnInfo abnInfo on abnInfo.id = (select top 1 id
     --                                                       from tg_abnInfo
     --                                                       where idAbn = abnObj.idAbn --and dateChange < @dt
     --                                                       order by dateChange desc)
     left join tAbnObjReg objReg on objReg.id = (select top 1 id from tAbnObjReg
                                                            where idAbnObj = abnObj.id --and dateChange < @dt
                                                            order by dateChange desc)
	 LEFT JOIN dbo.tR_Classifier AS cCategory ON (case when abnobj.TypeAbn = 231 and objReg.category is null then -1 -- сетевая организация
													else
														case when abnobj.typeAbn = 206 and objReg.category is null then 493 -- если у физика нет категории - ставим ему третью
														else 
															case when  objReg.category is null then 493 
															else objReg.category 
															end 
														end 
													end) = cCategory.Id   
     left join tR_Classifier cTariff on cTariff.id = objReg.idTariff
	 left join tR_Classifier cStatus on cStatus.id = objReg.idStatus
	 left join tR_Classifier cConsumerGroup on cConsumerGroup.id = objReg.ConsumerGroup
     left join tAbn abnNet on abnNet.id = Objreg.idAbnNet   
	 left join vG_ObjMeter_Count meter on meter.idObj = obj.idobj
where 
 abnObj.typeAbn in (207,231,230) 

	  --and ( obj.dateEnd is null or (obj.DateEnd is not null and obj.DateEnd > @dt))
	  --and charindex('ОДН ', abnObj.nameObj) = 0 and charindex('ОДН,', abnObj.nameObj) = 0 
	  --and objReg.idStatus in (241, 242, 1293, 2350)
	  --and substring(abnObj.nameObj,1,3) != 'ОДН'
	  --and abnobj.CodeAbonent > 0
	  --and charindex('компенсация', cTariff.name) = 0
	  --and charindex('бездоговорное', cTariff.name) = 0
	  --and charindex('двухставочный', cTariff.name) = 0	
	  --and charindex('одноставочный', cTariff.name) = 0
),	

-- ФИЗИКИ
abnFL (idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj,	categoryName, idTariff, TarifName, TariffParentKey, powerset, idAbnNet, abnNet, CountMeter, CommentODS, idConsumerGroup, ConsumerGroupName) as
(
select  abnObj.idAbn, abnObj.codeAbonent,
		abnObj.name as nameAbn,
		abnObj.TypeAbn, 
		abnObj.id as idAbnObj, abnObj.nameObj, 
		cCategory.name as categoryName,
		objReg.idTariff,
        isnull(cTariff.name, 'НН') AS TarifName,
		isnull(cTariff.ParentKey, ';SKUEE;Tariff;TariffFL;') TariffParentKey,
		isnull(objReg.PowerSet,0),
		isnull(abnNet.id,-1),
		abnNet.Name as abnNet,
		1 as CountMeter,
		objReg.CommentODS,
		'' idConsumerGroup, 
		'' ConsumerGroupName
from   vAbnObj AS abnobj 
	left join tAbnObjReg objReg on objReg.id = (select top 1 id from tAbnObjReg
												where idAbnObj = abnObj.id and dateChange < @dt
												order by dateChange desc)

	LEFT JOIN dbo.tR_Classifier AS cCategory ON (case when abnobj.TypeAbn = 231 and objReg.category is null then -1 -- сетевая организация
													else
														case when abnobj.typeAbn = 206 and objReg.category is null then 493 -- если у физика нет категории - ставим ему третью
														else 
															case when  objReg.category is null then 493 
															else objReg.category 
															end 
														end 
													end) = cCategory.Id 
	left join tR_Classifier cTariff on cTariff.id = objReg.idTariff
	left join tAbn abnNet on abnNet.id = Objreg.idAbnNet   
          
where abnObj.typeAbn in (206,253)
	--and (abnObj.typeObj = 1146 or abnObj.typeObj is NULL)    ---------- отсев левых объектов ------------
	)
,

-- ВСЕ АБОНЕНТЫ
abnAll (idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj, CategoryName, idTariff, TarifName, TariffParentKey, powerset, idAbnNet, nameAbnNet,  CountMeter, CommentODS, idConsumerGroup, ConsumerGroupName) as
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

cell     (cellId, cellName, busId, busName, subId, subName, deleted) AS
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
select
		abn2.*,
		case 
			when countidobj < CountMeter then  -- кол. счетчиков больше рубильников
				CountMeter/countidobj + (case when rowid <= CountMeter%countidobj then 1 else 0 end)
			else -- если количество счетчиков меньше количества присоединений
				(case 
					when rowid <= CountMeter then 1 
					else 0 
				end)	
		end as CountPoint
		, isnull(trc.Comment,'НН') Voltage

		from 
			(select abn.*, 
					row_number() over (partition by idAbnObj order by idAbnObj, idSchmObj) as rowid,	 -- порядковый номер  
					count(idAbnObj) over (partition by idAbnObj) as countidobj	    -- количество присоединений
			from 
				(select distinct abnAll.*,  link.idSchmObj
				from abnAll

					left join (select idAbnObj, idSchmObj,idDoc, TypeDoc
								from tl_SchmAbn 
								where tl_SchmAbn.DateOwner is null or tl_SchmAbn.DateOwner < @dt
								group by idAbnObj, idSchmObj,idDoc, TypeDoc
								) link  on link.idAbnObj = abnAll.idAbnObj
					) abn
				)	abn2
			left join cell on cell.cellid = abn2.idSchmObj
			left join bus on bus.id = abn2.idSChmObj
			left join sub on sub.id = abn2.idSChmObj
			left join tR_Classifier trc on trc.id = idTariff
		where isnull(cell.deleted, 0) = 0 and isnull(bus.deleted, 0) = 0 and isnull(sub.deleted, 0) = 0
		and (@listIdAbnObj is null or idAbnObj in (SELECT x.i.value('.','INT') FROM @XIdAbnObj.nodes('//i') x(i)) )
		--order by idabnobj



------declare @dt smalldatetime;
------set @dt = '2017-01-02 18:44:00';

--------select idAbnObj, idSchmObj,idDoc, TypeDoc
--------from tl_SchmAbn 
--------where tl_SchmAbn.DateOwner is null or tl_SchmAbn.DateOwner < @dt
								
--------group by idAbnObj, idSchmObj,idDoc, TypeDoc
--------order by idAbnObj

------select idAbnObj,idDoc, TypeDoc , 
------Cast((Select idSchmObj From tl_SchmAbn t2 where t1.idAbnObj = t2.idAbnObj and t1.idDoc = t2.idDoc and t1.TypeDoc = t2.TypeDoc FOR XML PATH ('')) as xml) idSchmObjXML
--------,STUFF((Select ',' + Cast(idSchmObj as varchar) From tl_SchmAbn t2 where t1.idAbnObj = t2.idAbnObj and t1.idDoc = t2.idDoc and t1.TypeDoc = t2.TypeDoc FOR XML PATH ('')),1,2,'' )idSchmObjString
------from tl_SchmAbn t1
------where t1.DateOwner is null or t1.DateOwner < @dt
								
------group by idAbnObj, idDoc, TypeDoc
------order by idAbnObj