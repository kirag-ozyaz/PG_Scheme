--declare @dt smalldatetime;
--set @dt = '20190128';

-- �����������
with abnLegalKWT (Dt, idObj, SumQuantity) as
( SELECT      d.dtPay as Dt,      obj.id as idObj, Sum(ds.Quantity) as SumQuantity
FROM tAbn a 
     LEFT JOIN tG_Doc d ON d.idAbn = a.id 
     LEFT JOIN tG_DocSchet ds ON ds.idDoc = d.id 
     LEFT JOIN tAbnObj obj ON obj.id = ds.idAbnObj
WHERE (d.dtPay between cast(cast(datepart(year, @dt)as varchar(4))+ '-' + cast(datepart(month, @dt) as varchar(2)) +'-'  + '01' as datetime) 
       and dateadd(day, -1, dateadd(month, 1, cast (cast(datepart(year, @dt)as varchar(4))+ '-' + cast(datepart(month, @dt) as varchar(2)) +'-'  + '01' as datetime)))) 
       and (ds.Summa <> 0) and (ds.Summa is not null) 
     and (a.codeabonent not in (9028,460)) and ((d.NumberStorno IS NULL) OR (d.NumberStorno = 0))
GROUP BY d.dtPay,a.id,a.CodeAbonent,a.Name,obj.id,obj.Name
),


-- �����
abnLegal (idAbn, codeAbonent, docAbn, nameAbn, typeAbn, typeAbnName, legalAddress, postAddress, idAbnObj, nameObj, [address], KladrObjid, kladrObjName,
                    category, categoryName, idtariff, tariffname, powerset, powerFact, sumKwt, Consumer, consumerName, contact, abnNet, abnServicing, CountMeter) as
(
select  abnObj.idAbn, abnObj.codeAbonent, (cast (abnObj.codeAbonent as varchar)+isnull(' �� '+CONVERT(varchar(10), dog.[DogDate],104)+' �.' , '')) as docAbn,

            replace(replace(isnull(abnInfo.nameFull, abnObj.name), char(10), ' '), char(13), ' ') as nameAbn
			, abnObj.TypeAbn, abnObj.typeAbnName,
          --                (SELECT  top 1 aa.[Representation] from tG_AbnAddress as aa where aa.[idTypeAddress] = 54 and aa.[idAbn] = abnObj.idAbn and aa.[DateChange]=(SELECT max(t1.[DateChange]) from [tG_AbnAddress] t1 where t1.[idAbn] = abnObj.idAbn and t1.[idTypeAddress] = 54)) as legalAddress, 
          --			    (SELECT  top 1 aa.[Representation] from tG_AbnAddress as aa where aa.[idTypeAddress] = 43 and aa.[idAbn] = abnObj.idAbn and aa.[DateChange]=(SELECT max(t1.[DateChange]) from [tG_AbnAddress] t1 where t1.[idAbn] = abnObj.idAbn and t1.[idTypeAddress] = 43)) as postAddress,
			replace(replace((SELECT  top 1 aa.[Representation] from tG_AbnAddress as aa where aa.[idTypeAddress] = 54 and aa.[idAbn] = abnObj.idAbn and aa.[DateChange]=(SELECT max(t1.[DateChange]) from [tG_AbnAddress] t1 where t1.[idAbn] = abnObj.idAbn and t1.[idTypeAddress] = 54)), char(10), ' '), char(13), ' ') as legalAddress, 
			replace(replace((SELECT  top 1 aa.[Representation] from tG_AbnAddress as aa where aa.[idTypeAddress] = 43 and aa.[idAbn] = abnObj.idAbn and aa.[DateChange]=(SELECT max(t1.[DateChange]) from [tG_AbnAddress] t1 where t1.[idAbn] = abnObj.idAbn and t1.[idTypeAddress] = 43)), char(10), ' '), char(13), ' ') as postAddress,

          abnObj.id as idAbnObj, 
		  
           replace(replace(abnObj.nameObj, char(10), ' '), char(13), ' ') as nameObj, 
           replace(replace(abnObj.address, char(10), ' '), char(13), ' ') as address,

          abnObj.KladrObjid, abnObj.KladrObjName, 
          objREg.category, 
		  --cCategory.name as cateGoryName,
		  ISNULL(cCategory.name, 'III') as cateGoryName,
          objReg.idTariff, cTariff.socrname as tariffName,
          objReg.PowerSet, objReg.PowerFact,
          abnLegalKWT.SumQuantity,
          objReg.Consumer, cConsumer.name as consumerName,
          replace(replace(contact.details, char(10), ' '), char(13), ' ') as contact,
          abnNet.Name as abnNet,
        abnServicing.Name as abnServicing,
		case when meter.CountMeter = 0 then 1 else CountMeter end as CountMeter
from  tAbnDoc_List lst
     left JOIN tAbnDoc_Dogovor dog ON dog.idList = lst.id 
     left JOIN tG_Dog_Obj obj ON obj.idDog = dog.id
     left JOIN vAbnObj AS abnobj ON abnobj.id = obj.idObj 
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
                      from     tabn t) as contact on contact.id = abnobj.idAbn
     left join tAbn abnNet on abnNet.id = Objreg.idAbnNet   
     left join tAbn abnServicing on abnServicing.id = Objreg.idAbnServicing   
     left join abnLegalKWT on abnLegalKWT.idObj = abnObj.id
	 
	 left join vG_ObjMeter_Count meter on meter.idObj = obj.idobj
	 
where 
 abnObj.typeAbn in (207,231) 
	and abnObj.isActive = 1 and abnObj.deleted = 0
      and lst.deleted = 0 and lst.isActive <> 0 and (dog.FlagBreak = 0 or dog.FlagBreak is null) and obj.dateEnd is null
	  and charindex('��� ', abnObj.nameObj) = 0 and charindex('���,', abnObj.nameObj) = 0 
	  and charindex('������� ', cTariff.name) = 0 and substring(abnObj.nameObj,1,3) != '���'
	  and abnobj.CodeAbonent > 0
	  and objReg.idStatus in (241,242,1293)
	  and charindex('�����������', cTariff.name) = 0
	  and charindex('�������������', cTariff.name) = 0
	  and charindex('�������������', cTariff.name) = 0	
	  and charindex('�������������', cTariff.name) = 0
),	


-- ������
abnFL (idAbn, codeAbonent, docAbn, nameAbn, typeAbn, typeAbnName, legalAddress, postAddress, idAbnObj, nameObj, [address], KladrObjid, kladrObjName,
				category, categoryName, idtariff, tariffname, powerset, powerFact, sumKwt, Consumer, consumerName, contact, abnNet, abnServicing, CountMeter) as
(
select  abnObj.idAbn, abnObj.codeAbonent, cast (abnObj.codeAbonent as varchar) as docAbn, 

		replace(replace(abnObj.name, char(10), ' '), char(13), ' ') as nameAbn,
		abnObj.TypeAbn, abnObj.typeAbnName,
		
		
		replace(replace(abnObj.address, char(10), ' '), char(13), ' ') as legalAddress,
		replace(replace(abnObj.address, char(10), ' '), char(13), ' ') as postAddress,

		abnObj.id as idAbnObj, 
		
		replace(replace(abnObj.nameObj, char(10), ' '), char(13), ' ') as nameObj,
		replace(replace(abnObj.address, char(10), ' '), char(13), ' ') as address,
		
		abnObj.KladrObjid, abnObj.KladrObjName, 
		objREg.category,-- cCategory.name as cateGoryName,
		ISNULL(cCategory.name, 'III') as cateGoryName,
		objReg.idTariff, cTariff.name as tariffName,
		objReg.PowerSet, objReg.PowerFact,
		null,
		objReg.Consumer, cConsumer.name as consumerName,
		replace(replace(contact.details, char(10), ' '), char(13), ' ') as contact,
		abnNet.Name as abnNet,
        abnServicing.Name as abnServicing,
		1 as CountMeter
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
    left join tAbnStatus AS statusAbn ON statusAbn.idAbn =  abnobj.idAbn AND statusAbn.id =
                          (SELECT     TOP (1) id
                            FROM          dbo.tAbnStatus
                            WHERE      (idAbn = abnobj.idAbn)
                            ORDER BY DateChange DESC)               
where abnObj.typeAbn in (206,253) and abnObj.isActive = 1 and abnObj.deleted = 0 
and (statusAbn.isActive = 1 or (statusAbn.isActive = 0  and statusAbn.datechange>@dt) ) 
and (statusAbn.idReason != 2340 or statusAbn.idReason is null)) ,

-- ��� ��������
abnAll (idAbn, codeAbonent, docAbn, nameAbn, typeAbn, typeAbnName, legalAddress, postAddress, idAbnObj, nameObj, [address], KladrObjid, kladrObjName,
                    category, categoryName, idtariff, tariffname, powerset, powerFact, sumkwt, Consumer, consumerName, contact, abnNet, abnServicing, CountMeter) as
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
     
     
select  -- Top 1000
	tmp.*,
	case 
		when countidobj < CountMeter then 
				(case rowid 
						when 1 then 1 + (CountMeter - countidobj) 
						else 1	
				end)
		else (case 
				when rowid <= CountMeter then 1 
				else 0 
			end)	
	end as Meter,
	case 
		when idTariff in (525,1016   ,1013) then '��' 
		when idTariff in (527,531,1017,1005,1278,1279,1001,1285,1003,1334,1332,1340,1360,1366,1363,1357,2095,2045,1393,1394,1864,2312,691   ,1014,2333,2334,2336,2337,2314,2316) then '��-2' 
		when idTariff in (528,532,1018,1006,1280,1002,1284,1004,1333,1331,1339,1359,1365,1362,1356,2094,2046,1386,1388,1387,1863,2311       ,2326,2327,2328,2329,2330,1015,2048) then '��' 
		when idTariff is null then '��'
		else '��-2'
	end as Voltage
	
from 
	(select abn.*,
	    cell.cellId, cell.CellName,  
	    isnull(cell.busId, bus.id) as busid,
	    isnull(cell.BusName, bus.busname) as busname,
	    isnull(cell.subid, isnull(bus.subid, sub.id)) as subid,
	    isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname,
	    isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+
	    isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') as schmObjName,
		row_number() over (partition by idAbnObj order by idAbnObj) as rowid,	  
		count(idAbnObj) over (partition by idAbnObj) as countidobj	  
	from
		(select distinct abnAll.*, link.idSchmObj,
        	link.idDoc, link.TypeDoc, cTypeDoc.name as typeDocName
		from abnAll
    		left join tl_SchmAbn link on link.idAbnObj = abnAll.idAbnObj
    		left join tR_Classifier cTypeDoc on cTypeDoc.id = link.TypeDoc
		)	
		abn
	    left join cell on cell.cellid = abn.idSchmObj
	    left join bus on bus.id = abn.idSChmObj
	    left join sub on sub.id = abn.idSChmObj
	where isnull(cell.deleted, 0) = 0 and isnull(bus.deleted, 0) = 0 and isnull(sub.deleted, 0) = 0  
	) tmp
