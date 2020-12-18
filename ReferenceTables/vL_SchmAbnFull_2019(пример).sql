--USE [GES]
----GO

declare @dt smalldatetime;
set @dt = '20190213 21:37:37';

-- потребление
with abnLegalKWT (Dt, idObj, SumQuantity) as
( 
SELECT      d.dtPay as Dt,      obj.id as idObj, Sum(ds.Quantity) as SumQuantity
FROM tAbn a 
     LEFT JOIN tG_Doc d ON d.idAbn = a.id 
     LEFT JOIN tG_DocSchet ds ON ds.idDoc = d.id 
     LEFT JOIN tAbnObj obj ON obj.id = ds.idAbnObj
WHERE (d.dtPay between cast(cast(datepart(year, @dt)as varchar(4))+ '-' + cast(datepart(month, @dt) as varchar(2)) +'-'  + '01' as datetime) 
       and dateadd(day, -1, dateadd(month, 1, cast (cast(datepart(year, @dt)as varchar(4))+ '-' + cast(datepart(month, @dt) as varchar(2)) +'-'  + '01' as datetime)))) 
       and (ds.Summa <> 0) and (ds.Summa is not null) 
     and (a.codeabonent not in (9028,460)) and ((d.NumberStorno IS NULL) OR (d.NumberStorno = 0))
GROUP BY d.dtPay,a.id,a.CodeAbonent,a.Name,obj.id,obj.Name
)
,
-- ЮРИКИ
abnLegal (idAbn, codeAbonent, docAbn, nameAbn, nameAbnFull, typeAbn, typeAbnName, legalAddress, postAddress, idAbnObj, nameObj, [address], KladrObjid, kladrObjName, idStreet, StreetName, House,
                    idCategory, CategoryName, idTariff, TarifName, TariffNameSocr, powerset, powerFact, sumKwt, Consumer, consumerName, contact, idAbnNet, abnNet, abnServicing, CountMeter, CommentODS) as
(
select  abnObj.idAbn, abnObj.codeAbonent, (cast (abnObj.codeAbonent as varchar)+isnull(' от '+CONVERT(varchar(10), dog.[DogDate],104)+' г.' , '')) as docAbn,
		  abnObj.name
		  , isnull(abnInfo.nameFull, abnObj.name) as nameAbnFull
		  ,	abnObj.TypeAbn, abnObj.typeAbnName,
          (SELECT  top 1 aa.[Representation] from tG_AbnAddress as aa where aa.[idTypeAddress] = 54 and aa.[idAbn] = abnObj.idAbn and aa.[DateChange]=(SELECT max(t1.[DateChange]) from [tG_AbnAddress] t1 where t1.[idAbn] = abnObj.idAbn and t1.[idTypeAddress] = 54)) as legalAddress, 
          (SELECT  top 1 aa.[Representation] from tG_AbnAddress as aa where aa.[idTypeAddress] = 43 and aa.[idAbn] = abnObj.idAbn and aa.[DateChange]=(SELECT max(t1.[DateChange]) from [tG_AbnAddress] t1 where t1.[idAbn] = abnObj.idAbn and t1.[idTypeAddress] = 43)) as postAddress,
          abnObj.id as idAbnObj, abnObj.nameObj, abnObj.address,
          abnObj.KladrObjid, abnObj.KladrObjName, 
		  abnobj.idStreet, abnobj.StreetName, abnobj.house,
          -- objREg.Category, 
		  cCategory.id,
		  cCategory.name as CateGoryName,
		  objReg.idTariff, isnull(cTariff.name, 'НН') AS TarifName, cTariff.socrname as TariffNameSocr,
		  isnull(objReg.PowerSet,0), objReg.PowerFact,
          abnLegalKWT.SumQuantity,
          objReg.Consumer, cConsumer.name as consumerName,
          contact.details as contact,
		  abnNet.id,
          abnNet.Name as abnNet,
        abnServicing.Name as abnServicing,
		case when meter.CountMeter = 0 then 1 else CountMeter end as CountMeter
		, objReg.CommentODS
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
     -- left join tR_Classifier cCategory on cCategory.id = objReg.Category
	LEFT JOIN dbo.tR_Classifier AS cCategory ON (case when abnobj.TypeAbn = 231 and objReg.category is null then -1 -- сетевая организация
													else
														case when abnobj.typeAbn = 206 and objReg.category is null then 493 -- если у физика нет категории - ставим ему третью
														--when idPoint is null then -1
														else 
															case when  objReg.category is null then 493 
															else objReg.category 
															end 
														end 
													end) = cCategory.Id   
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
 abnObj.typeAbn in (207,231,230) 
	and abnObj.isActive = 1 and abnObj.deleted = 0
      and lst.deleted = 0 and lst.isActive <> 0 and (dog.FlagBreak = 0 or dog.FlagBreak is null) and obj.dateEnd is null
	  and charindex('ОДН ', abnObj.nameObj) = 0 and charindex('ОДН,', abnObj.nameObj) = 0 
	  and charindex('нулевой ', cTariff.name) = 0 and substring(abnObj.nameObj,1,3) != 'ОДН'
	  and abnobj.CodeAbonent > 0
	  and objReg.idStatus in (241,242,1293)
	  and charindex('компенсация', cTariff.name) = 0
	  and charindex('бездоговорное', cTariff.name) = 0
	  and charindex('двухставочный', cTariff.name) = 0	
	  and charindex('одноставочный', cTariff.name) = 0
--	  and ((charindex('население',cTariff.socrname) <> 0) or (charindex('непосредственное',cTariff.socrname) <> 0))
),	


-- ФИЗИКИ
abnFL (idAbn, codeAbonent, docAbn, nameAbn, nameAbnFull, typeAbn, typeAbnName, legalAddress, postAddress, idAbnObj, nameObj, [address], KladrObjid, kladrObjName, idStreet, StreetName, House,
				category, categoryName, idTariff, TarifName, TariffNameSocr, powerset, powerFact, sumKwt, Consumer, consumerName, contact, idAbnNet, abnNet, abnServicing, CountMeter, CommentODS) as
(
select  abnObj.idAbn, abnObj.codeAbonent, cast (abnObj.codeAbonent as varchar) as docAbn, 
		abnObj.name as nameAbn,
		abnObj.name as nameAbnFull, 
		abnObj.TypeAbn, abnObj.typeAbnName,abnObj.address as legalAddress,abnObj.address as postAddress,
		abnObj.id as idAbnObj, abnObj.nameObj, abnObj.address,
		abnObj.KladrObjid, abnObj.KladrObjName,
		abnobj.idStreet, abnobj.StreetName, abnobj.House,
		--objREg.category,
		cCategory.id,
		cCategory.name as CateGoryName,
        objReg.idTariff, isnull(cTariff.name, 'НН') AS TarifName, cTariff.socrname as TariffNameSocr,  
		isnull(objReg.PowerSet,0), objReg.PowerFact,
		null,
		objReg.Consumer, cConsumer.name as consumerName,
		contact.details as contact,
		abnNet.id,
		abnNet.Name as abnNet,
        abnServicing.Name as abnServicing,
		1 as CountMeter
		, objReg.CommentODS
from   vAbnObj AS abnobj 
	left join tAbnObjReg objReg on objReg.id = (select top 1 id from tAbnObjReg
												where idAbnObj = abnObj.id
												order by dateChange desc)
--	left join tR_Classifier cCategory on cCategory.id = objReg.Category
	LEFT JOIN dbo.tR_Classifier AS cCategory ON (case when abnobj.TypeAbn = 231 and objReg.category is null then -1 -- сетевая организация
													else
														case when abnobj.typeAbn = 206 and objReg.category is null then 493 -- если у физика нет категории - ставим ему третью
														--when idPoint is null then -1
														else 
															case when  objReg.category is null then 493 
															else objReg.category 
															end 
														end 
													end) = cCategory.Id 
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

-- ВСЕ АБОНЕНТЫ
abnAll (idAbn, codeAbonent, docAbn, nameAbn, nameAbnFull, typeAbn, typeAbnName, legalAddress, postAddress, idAbnObj, nameObj, [address], idCity, City, idStreet, StreetName, House,
                    idCategory, CategoryName, idTariff, TarifName, TariffNameSocr, powerset, powerFact, sumkwt, Consumer, consumerName, contact, idAbnNet, abnNet, abnServicing, CountMeter, CommentODS) as
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

-- select * from abnAll
select aaa.idAbn	,CodeAbonent,	nameAbn	,TypeAbn	,idAbnObj	,NameObj,	CommentODS,	CategoryName	,TarifName	,Voltage,	PowerSet	,CountPoint,	idAbnNet, rowid, countidobj, CountMeter, idSchmObj
from
(
select
		abn2.*,
		cell.cellId, cell.CellName,  
		isnull(cell.busId, bus.id) as busid,
		isnull(cell.BusName, bus.busname) as busname,
		isnull(cell.subid, isnull(bus.subid, sub.id)) as subid,
		isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname,
		isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+
		isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') as schmObjName,
		case 
			when idTariff in (525,1016,1013) then 'ВН' 
			when idTariff in (527,531,1017,1005,1278,1279,1001,1285,1003,1334,1332,1340,1360,1366,1363,1357,2095,2045,1393,1394,1864,2312,691,1014,2333,2334,2336,2337,2314,2316) then 'СН-2' 
			when idTariff in (528,532,1018,1006,1280,1002,1284,1004,1333,1331,1339,1359,1365,1362,1356,2094,2046,1386,1388,1387,1863,2311,2326,2327,2328,2329,2330,1015,2048) then 'НН' 
			when idTariff is null then 'НН'
			else ''
		end as Voltage,
		case 
			when countidobj < CountMeter then (case rowid when 1 then 1 + (CountMeter - countidobj) else 1 end)
			else (case when rowid <= CountMeter then 1 else 0 end)	
		end as CountPoint
		from 
			(select abn.*, 
					row_number() over (partition by idAbnObj order by idAbnObj, idSchmObj) as rowid,	 -- порядковый номер 
					count(idAbnObj) over (partition by idAbnObj) as countidobj	  -- количество присоединений
			from 
				(select distinct abnAll.*, /*link.id idLink,*/ link.idSchmObj,
					link.idDoc, link.TypeDoc, cTypeDoc.name as typeDocName
				from abnAll
					--left join tl_SchmAbn link on link.idAbnObj = abnAll.idAbnObj
					left join (select idAbnObj, idSchmObj,idDoc, TypeDoc
								from tl_SchmAbn 
								group by idAbnObj, idSchmObj,idDoc, TypeDoc
								) link  on link.idAbnObj = abnAll.idAbnObj
	
					--left join tl_SchmAbn link on link.id = (select top 1 id from tl_SchmAbn
					--							where idAbnObj = abnAll.idAbnObj
					--							order by id)
					left join tR_Classifier cTypeDoc on cTypeDoc.id = link.TypeDoc
				) abn
				)	abn2
			left join cell on cell.cellid = abn2.idSchmObj
			left join bus on bus.id = abn2.idSChmObj
			left join sub on sub.id = abn2.idSChmObj
		where isnull(cell.deleted, 0) = 0 and isnull(bus.deleted, 0) = 0 and isnull(sub.deleted, 0) = 0

	 and abn2.idSchmObj in (985926,1198807,1198799,1198796,1198798,1198803,1033439,791264,1168619,1168611,1168613,1168622,1168629,777508,777414,777415,777480,789799,775321,775309,775315,775333,789794,772104,772090,772091,1012295,1012310,1012842,1012841,1012849,1012854,1012865,1012870,1012873,1012878,1012881,1012886,1012889,1012894,1012905,1012910,1012913,1012918,1012921,1012926,1012929,1012934,1012937,1012942,1012945,1012950,1012953,1012958,1012961,1012966,1012969,1012974,1194312,1106727,1106734,1106741,1106739,1106826,1106831,1106834,1106839,1106842,1106847,1106866,1106871,1106874,1106879,791306,775409,775393,775397,775404,789854,892950,1111247,777435,789746,772221,772217,772218,772224,789726,1200649,776016,776000,776004,776013,789826,776249,776234,776235,996706,996712,996789,996788,996806,996811,996822,996827,996830,996835,996838,996843,996862,996867,996886,996891,996894,996899,996902,996907,996910,996915,996918,996923,996926,996931,996934,996939,996942,996947,996950,996955,995661,995669,995675,995674,995684,995689,995692,995697,995716,995721,995732,995737,995740,995745,1183075,777442,789750,772214,772211,772212,1011823,1011833,1169952,1011845,1011844,1169887,1169892,1169911,1169916,1169943,1169948,1169895,1169900,1193488,791179,776439,776430,776431,1098010,1098016,1098028,1098027,777503,791182,772254,772246,772247,1111543,1111548,1111571,1111569,1111597,1111602,1111605,1111610,1111613,1111618,1111621,1111626,1111629,1111634,1111637,1111642,1111645,1111650,1175144,790784,1168633,1168614,1168637,789734,772004,771985,771991,771998,789735,775520,775510,775511,775523,775514,775517,789737,775836,775826,775827,992692,1159364,992752,992755,992760,992763,992768,992771,992776,992779,992784,993107,993106,993111,993116,993173,993177,1171133,1171130,827172,834878,834884,834886,834892,834894,834900,834910,834916,834926,834932,834942,834948,1171141,1155763,827160,835022,835028,835038,835044,835046,835052,835054,835060,835062,835068,835070,835076,835094,835100,835102,835108,835118,835124,835126,835132,835134,835140,835150,835156,772013,791134,772200,772188,772189,772203,791133,1182098,1015741,1015757,1015764,1015762,1016186,1016191,1183276,1182229,1183275,1016194,1016199,1016202,1016207,1016218,1016223,1016226,1016231,1016234,1016239,1016242,1016247,1016250,1016255,1016266,1016271,1016277,1016282,1016285,1016290,1016293,1016298,1016301,1016306,1016309,1016314,1169099,1169129,1169137,1169135,1169149,1169154,1169669,1169661,1169663,1169666,1169720,1169445,1169402,1169403,1169311,1169400,1169308,1169429,1169434,1169461,1169466,1169672,1169677,1169688,1169693,1189899,1169696,1169701,1169704,1169709,1169712,1169717,1169157,1169162,1169181,1169186,1169189,1169194,795565,826441,826444,1155570,1155573,1113724,1113725,1113730,1182411,1182204,1182410,1113733,1113738,1113741,1113746,1113749,1113754,1113757,1113762,1113765,1113770,772010,771986,772007,789791,772479,772464,772469,772482,789801,951593,776232,776229,776230,1182149,772488,791461,782666,782654,782658,813124,1181608,1004877,1004883,1005309,1005211,1005228,1005233,1005318,1005236,1005241,1005252,1005257,1005260,1005265,1005276,1005281,1005284,1005289,1005293,1005298,1005301,1005306,1194288,1015747,1015753,1015768,1015763,1015776,1015781,1015784,1015789,1015792,1015797,1015800,1015805,1015808,1015813,1015816,1015821,1015824,1015829,1015832,1015837,1015848,1015853,1015864,1015869,1015872,1015877,1015880,1015885,1015888,1015893,1015896,1015901,1198814,1198819,1198894,1198829,1198830,1198835)
 ) aaa

 --where idabn = 1086438
 --where CountPoint <> 0