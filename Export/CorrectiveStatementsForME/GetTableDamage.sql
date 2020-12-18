/*

Запрос получения аварийных работ в 2019
вход 
	@Year - год
	@Month - месяц
	@isSendSiteMe - статус отпрвки данных в минэнерго
	@idDoc - id документа
	
	typeDoc =  (1401, 1402)
	
	Текущая версия

*/
--use ges;
--declare @isSendSiteMe int;
--set @isSendSiteMe = 3;
--declare @Year int, @Month int;
--set @Year = 2019; 
--set @Month = 4;
--declare @idDoc int;

with sub (Id, FullName, deleted) AS
	(SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text], o.deleted
	FROM tSchm_ObjList AS o
		LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id
	WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))),
-- полный список подстанций всей схемы
bus (Id, busName, subid, subname, deleted) AS
	(SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name, 
			case when o.deleted = 0 and sub.deleted = 0 then 0 else 1 end
	FROM tSchm_ObjList AS o 
		JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id
		join tSChm_ObjList sub on sub.id = o.idParent
		join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id
	WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0))),
-- полный список ячеек всей схемы
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
	wHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0))),
AbnObj(idDoc, idAbnObj, TypeDoc, NumRequest, DateDoc, idPoint, AveragePowerConsumedAbn, AbnNameFull, typeAbn, CategoryAbn, TarifName, Voltage, nameAbnNet) as
(select d.id idDoc, col.idAbnObj.value('@idAbnObj', 'int') idAbnObj, d.TypeDoc, d.NumRequest,  d.DateDoc
	 , aopn.idPoint, [dbo].[fn_GetAveragePower] ( col.idAbnObj.value('@idAbnObj', 'int') , aopn.idPoint, d.DateDoc, 1) AveragePowerConsumedAbn
	 , col.idAbnObj.value('@nameAbn', 'varchar(max)') AbnNameFull
	 , col.idAbnObj.value('@typeAbn', 'int') typeAbn
	 , col.idAbnObj.value('@CategoryName', 'varchar(max)') CategoryAbn
	 , col.idAbnObj.value('@TarifName', 'varchar(max)') TarifName
	 , isnull(col.idAbnObj.value('@Voltage', 'varchar(max)'), 'НН') Voltage
     , case 
			when col.idAbnObj.value('@idAbnNet', 'int') not in (220859, 434002) then isnull(tG_AbnNameODS.NameODS, col.idAbnObj.value('@nameAbnNet' , 'varchar(max)')) 
			else null
		end 			AbnNet
		from tj_damage d
			outer apply d.CommentXml.nodes('/Doc/AbnOff/Row') col(idAbnObj)
			left join dbo.vAbnObjPointName aopn on aopn.id = col.idAbnObj.value('@idAbnObj', 'int') and aopn.isActive = 1 and aopn.Deleted = 0
			left join tG_AbnNameODS on col.idAbnObj.value('@idAbnNet', 'int') = tG_AbnNameODS.idAbn
		-- отсечем все нулевые значения количества точек учета
		where (d.id = @idDoc) or (@idDoc is  null and d.deleted = 0 
			and (col.idAbnObj.value('@countPoint', 'varchar(max)') > 0 or col.idAbnObj.value('@CountPoint', 'varchar(max)') > 0 )
			and d.typeDoc in (1401, 1402)
			and (@isSendSiteMe is null or d.isSendSiteMe  = @isSendSiteMe)
			and ((@Month is null and @Year is null) or (@Month = Month(d.datedoc) and @Year = Year(d.datedoc)))))
, categorycount (idDamage, countPointCat1, countPointCat2, 
					countPointCat3, countPointEE, countPointSource,	countAbnObjEE,
					countPointVoltageVN,countPointVoltageSN1, countPointVoltageSN2,countPointVoltageNN
					) as
		(select d.id,
		T.C.query('.').value('(/AbnOff/CountPoint/@countPointCat1)[1]', 'int' ) as countPointCat1,   
		T.C.query('.').value('(/AbnOff/CountPoint/@countPointCat2)[1]', 'int' ) as countPointCat2,   
		T.C.query('.').value('(/AbnOff/CountPoint/@countPointCat3)[1]', 'int' ) as countPointCat3,
		T.C.query('.').value('(/AbnOff/CountPoint/@countPointEE)[1]', 'int' ) as countPointEE,
		T.C.query('.').value('(/AbnOff/CountPoint/@countPointSource)[1]', 'int' ) as countPointSource,

		T.C.query('.').value('(/AbnOff/CountAbnObj/@countAbnObjEE)[1]', 'int') as countAbnObjEE,
		
		T.C.query('.').value('(/AbnOff/CountPointVoltage/@CountPointVoltageVN)[1]', 'int' ) as countPointVoltageVN,   
		T.C.query('.').value('(/AbnOff/CountPointVoltage/@CountPointVoltageSN1)[1]', 'int' ) as countPointVoltageSN1,   
		T.C.query('.').value('(/AbnOff/CountPointVoltage/@CountPointVoltageSN2)[1]', 'int' ) as countPointVoltageSN2,
		T.C.query('.').value('(/AbnOff/CountPointVoltage/@CountPointVoltageNN)[1]', 'int' ) as countPointVoltageNN

		from tj_damage d
			CROSS APPLY CommentXml.nodes('/Doc/AbnOff') AS T(C))
--------- основной запрос ------------------						
select doc.id id, doc.numRequestME num, Cast(netRegion.netRegionVAlue as int) name
	, ISNULL((Case 
					when сTypeSchmObj.SocrName  in ('Т', 'ПП', 'ЦП', 'ППНО', 'СП') then 'ПС' 
					when сTypeSchmObj.SocrName  in ('ВЛЗ') then 'ВЛ' 
					when сTypeSchmObj.SocrName  in ('СЛ') then 'КВЛ' 
					when сTypeSchmObj.parentkey like ';SCM;Cell;%' or сTypeSchmObj.parentkey like ';SCM;BUS;%' 
						then (  
							select Case when c.SocrName in ('Т', 'ПП', 'ЦП', 'ППНО', 'СП') then 'ПС' 
									when c.SocrName  in ('ВЛЗ') then 'ВЛ' 
									when c.SocrName  in ('СЛ') then 'КВЛ' 
									else c.SocrName
									end
							from tSchm_ObjList t1 
							join tSchm_ObjList t2 on t1.id = t2.idparent and t2.id = oTypeSchmObj.id
							left join tR_Classifier  c on t1.TypeCodeId = c.id )
					else сTypeSchmObj.SocrName 
				 end), Case 
							when chNameCol1.SocrName is null then chNameCol1.name
							when chNameCol1.SocrName = '' then chNameCol1.name
							else chNameCol1.SocrName
						end) obj_type
	, isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+
			isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') obj_name
	, case when dHV.iddamage is null then '0.38' 
			else	case 
						when dHV.PowerV  = 0.4 then '0.38'
						when dHV.PowerV  = 10 then '10 (10.5)'
						when dHV.PowerV  = 6 then '6 (6.3)'
						else Convert(varchar(max), dHV.PowerV)
					end
			end voltage_lvl
    , Convert(smalldatetime,Convert(varchar(20), doc.datedoc,0),0) dt_start 
    , Convert(smalldatetime,Convert(varchar(20), doc.dateApply,0),0) dt_recover
    , '1' dt_offset 
	, 'В' deenergized_type
 	, Cast(Cast(DATEDIFF (minute, Convert(smalldatetime,Convert(varchar(20), doc.datedoc,0),0),Convert(smalldatetime,Convert(varchar(20), doc.dateApply,0),0)) as numeric(10,2))/60 as numeric(10,2)) duration
    , 2  apv
    , 2  avr
	-----------------------------------------------------------------------------------------------------------------------------------	
	, Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(
	Stuff(isnull((select Distinct ', ' + c.value('@SubName','varchar(max)') 
							from tj_damage d1
								cross apply CommentXml.nodes('//TransTree//*') t(c)
							where doc.id = d1.id  and d1.deleted = 0
									and (Case 
											when dHV.iddamage is null  and CHARINDEX('0.38 кВ',c.value('@SubName','varchar(max)')) > 0 then 1
											when dHV.PowerV in (0.4)   and CHARINDEX('0.38 кВ',c.value('@SubName','varchar(max)')) > 0 then 1
											when dHV.PowerV in (6, 10) and (CHARINDEX('10 (10.5) кВ',c.value('@SubName','varchar(max)')) > 0 or CHARINDEX('6 (6.3) кВ',c.value('@SubName','varchar(max)')) > 0) then 1
												else 0
											end) = 1
							for xml path('')
							),''),1,2,'')  
					,' Яч.<Object>',''),'<','_'),'>','_'),'  ',' '),' № 0',''),'  ',' '),'_Object_',''),',,',','),'&lt;Object&gt;','0'),'&lt;',''),'&gt;','')
							as feed_objects_list
    ---------------------------------------------------------------------------------------------------------------------------------
	, null consumers_fully_deenergized
    , Stuff((select distinct '; ' +  abn.AbnNameFull
		from AbnObj abn	where doc.id = abn.idDoc and abn.CategoryAbn in ('I', 'II') and abn.TypeAbn <> 231  and abn.idPoint is not null
		for xml path('')),1,2,'') as consumers_partial_deenergized
    , categorycount.countPointCat1 + categorycount.countPointCat2 + categorycount.countPointCat3 + categorycount.countAbnObjEE tp_total
    , categorycount.countPointCat1 tp_cat_1
    , categorycount.countPointCat2 tp_cat_2
    , categorycount.countPointCat3 tp_cat_3
    , categorycount.countPointVoltageVN tp_vn
	, categorycount.countPointVoltageSN1 tp_sn1
	, categorycount.countPointVoltageSN2 tp_sn2
	, categorycount.countPointVoltageNN tp_nn
	, categorycount.countAbnObjEE tp_neigh_org
	, Round((Case doc.typeDoc
				when 1402 then Cast (dHV.[PowerV]*dHV.[PowerA]*[CoefFI]*[CoefSeason]*sqrt(3) as numeric(10,2))
				else Cast((select distinct  sum(d2.AveragePowerConsumedAbn)
								from AbnObj d2
								where doc.id = d2.idDoc)   as numeric(10,2)) 
				end),2) as power_total
	, Round((Case doc.typeDoc
				when 1402 then dHV.NoAdmissionKWT -- если ВН
				else Cast((select distinct  sum(abn.AveragePowerConsumedAbn)
							from AbnObj abn
							where doc.id = abn.idDoc) * DATEDIFF (minute, doc.datedoc,doc.dateApply) /60 * 1000 * 0.000301711 as numeric(10,2))
							--  * 0.1 коэффициент неоднородности
							-- умножить на время отключения (часы) и  на количество физиков и т.д.
			end ),2) as power_undersupply
    ,  replace(replace(Stuff((select distinct '; ' +  abn.nameAbnNet
	   from AbnObj abn	where doc.id = abn.idDoc and abn.nameAbnNet <> ''-- and abn.TypeAbn = 231 
	   for xml path('')) ,1,2,''), char(10), ' '), char(13), ' ') tso_neigh_list -- из CommentXml
    , case when actD.id is not null then actD.numRequest + ' ' + convert( varchar(10),actd.dateDoc, 120)
       else doc.numRequest + ' ' + convert( varchar(10),doc.dateDoc, 120) end  as  log_info
	, case when ISNUMERIC(Replace(chCodeReasonOrg.name, '.','')) = 0 then '' else chCodeReasonOrg.name	end as org_reason_code--chCodeReasonOrg.name 
	, case when ISNUMERIC(Replace(chCodeReasonTech.name, '.','')) = 0 then '' else chCodeReasonTech.name	end  as tech_reason_code--chCodeReasonTech.name
	, Case  when doc.is81 = 1 then 1 else 0 end accounting_in_indicators
	, Stuff((select distinct '; ' +  chNameCol1.SocrName
		from tJ_DamageCharacter dh	
			left join tr_classifier chNameCol1 on chNameCol1.id = dh.col1 and (chNameCol1.socrname is not null and chNameCol1.socrname <> '' and CHARINDEX(chNameCol1.socrname,';КЛ;ВЛ;КВЛ;ПС;ТП;РП;') > 0)
			where doc.id = dh.idDamage
		for xml path('')),1,2,'') list_obj_type
	, doc.isSendSiteMe isSendSiteMe
from tj_damage doc
	left join cell on cell.cellid = doc.idSchmObj
	left join bus on bus.id = doc.idSChmObj
	left join sub on sub.id = doc.idSChmObj
	left join [vP_SubstationByNetRegion] netRegion on netRegion.id = isnull(cell.subid, isnull(bus.subid, sub.id))
	---------------
	left join tJ_DamageCharacter ch on ch.id = (select top 1 id -- ch - строка с отключаем объектом
												from tJ_DamageCharacter
												where idDamage = doc.id)
	left join tr_classifier chNameCol1 on chNameCol1.id = ch.col1	-- тип (характер отключаемого объекта)
	left join tSchm_ObjList AS oTypeSchmObj on oTypeSchmObj.id = ch.idSchmObj /*для 6-10кВ*/
	left join tR_Classifier AS сTypeSchmObj ON oTypeSchmObj.TypeCodeId = сTypeSchmObj.id 
	---------------------	
	left join tj_damage actD on actD.id	= (select top 1 id from tj_damage 
											where idParent = doc.id and typeDoc = 1874 and deleted = 0)
	left join tJ_DamageActDetection actDD on actDD.idDamage = actD.id
	left join tr_classifier chCodeReasonTech on chCodeReasonTech.id = actDD.idReasonCrashEquipment	-- tech_reason_code
	left join tr_classifier chCodeReasonOrg on chCodeReasonOrg.id = actDD.idReasonCrash	-- org_reason_code
	-----------------------------------------------------------
	left join tj_damageHV dHV on dHV.idDamage = doc.id
	------------------
	left join categorycount on categorycount.idDamage = doc.id
where  (doc.id = @idDoc) or (@idDoc is  null and doc.deleted = 0  and Year(doc.DateDoc) >= 2019 
		and (@isSendSiteMe is null or doc.isSendSiteMe  = @isSendSiteMe)
		and doc.typeDoc in (1401, 1402)
		and ((@Month is null and @Year is null) or
			(@Month = Month(doc.datedoc) and @Year = Year(doc.datedoc))))
