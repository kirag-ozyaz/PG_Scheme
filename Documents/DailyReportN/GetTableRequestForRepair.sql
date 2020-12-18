with AbnObj(idDoc, idAbnObj,   idPoint, AveragePowerConsumedAbn, AbnNameFull, typeAbn, CategoryAbn, TarifName, Voltage, nameAbnNet) as
(select d.id idDoc, col.idAbnObj.value('@idAbnObj', 'int') idAbnObj 
	 , aopn.idPoint, [dbo].[fn_GetAveragePower] ( col.idAbnObj.value('@idAbnObj', 'int') , aopn.idPoint, d.DateCreate, 1) AveragePowerConsumedAbn
	 , col.idAbnObj.value('@nameAbn', 'varchar(max)') AbnNameFull
	 , col.idAbnObj.value('@typeAbn', 'int') typeAbn
	 , col.idAbnObj.value('@CategoryName', 'varchar(max)') CategoryAbn
	 , col.idAbnObj.value('@TarifName', 'varchar(max)') TarifName
	 , isnull(col.idAbnObj.value('@Voltage', 'varchar(max)'), 'НН') Voltage
     , case 
			when col.idAbnObj.value('@idAbnNet', 'int') not in (220859, 434002) then isnull(tG_AbnNameODS.NameODS, col.idAbnObj.value('@nameAbnNet' , 'varchar(max)')) 
			else null
		end 			AbnNet
		from [tJ_RequestForRepair] d
			outer apply d.CommentXml.nodes('//NodeDgvAbn//*') col(idAbnObj)
		left join dbo.vAbnObjPointName aopn on aopn.id = col.idAbnObj.value('@idAbnObj', 'int') and aopn.isActive = 1 and aopn.Deleted = 0
		left join tG_AbnNameODS on col.idAbnObj.value('@idAbnNet', 'int') = tG_AbnNameODS.idAbn

		where d.deleted = 0  and col.idAbnObj.value('@countPoint', 'int') > 0
		and col.idAbnObj.value('@idAbn', 'varchar(max)') <> ''
		and (d.Crash = 0  or d.crash is null)  /*and d.isSendSiteMe =  1*/)
		
			--and		((Select Year(min(daily.dateBeg)) from tJ_RequestForRepairDaily daily where d.id = daily.idRequest) = 2019
			--	or (Select Year(max(daily.dateEnd)) from tJ_RequestForRepairDaily daily where d.id = daily.idRequest) = 2019)
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

		from [tJ_RequestForRepair] d
			CROSS APPLY CommentXml.nodes('/Doc/AbnOff') AS T(C))
--------------------------------------------------------------------------------------------
select doc.id id, doc.numRequestME num, Cast(netRegion.Value as int) name
		,ISNULL((Case 
					when Left(ltrim(doc.schmObj),2) in ('ПП', 'ЦП', 'ППНО', 'СП', 'ПС') then 'ПС'
					when Left(ltrim(doc.schmObj),3) in ('КТП', 'СТП') then 'ТП' 
					when Left(ltrim(doc.schmObj),3) in ('ГПП') then 'ПС' 
					when Left(ltrim(doc.schmObj),3) in ('2КЛ') then 'КЛ'  
					when Left(ltrim(doc.schmObj),2) in ('СЛ') then 'КВЛ'  
					when Left(ltrim(doc.schmObj),3) in ('КВЛ') then 'КВЛ'  
					when Left(ltrim(doc.schmObj),2) in ('РП', 'ТП', 'КЛ', 'ВЛ') then Left(ltrim(doc.schmObj),2)
					--when c.SocrName  in ('СЛ') then 'ВЛ'  
					else ''
					end) , '') [obj_type]
		,ltrim(Replace(doc.schmObj,'  ',' ')) obj_name
		, Case --6/0,4
			when CharIndex('10/0,4' ,Replace(doc.schmObj,' ','')) <> 0 then '10 (10.5)'
			when CharIndex('10-0,4' ,Replace(doc.schmObj,' ','')) <> 0 then '10 (10.5)'
			when CharIndex('6/0,4' , Replace(doc.schmObj,' ','')) <> 0 then '6 (6.3)'
			when CharIndex('6-0,4' , Replace(doc.schmObj,' ','')) <> 0 then '6 (6.3)'
			when CharIndex('0,4кВ' , Replace(doc.schmObj,' ','')) <> 0 then '0.38'
			when CharIndex('0.4кВ' , Replace(doc.schmObj,' ','')) <> 0 then '0.38'
			when CharIndex('10кВ'  , Replace(doc.schmObj,' ','')) <> 0 then '10 (10.5)'
			when CharIndex('6кВ'   , Replace(doc.schmObj,' ','')) <> 0 then '6 (6.3)'
			when CharIndex('0,23кВ', Replace(doc.schmObj,' ','')) <> 0 then '0.22'
			when CharIndex('0.23кВ', Replace(doc.schmObj,' ','')) <> 0 then '0.22'
			else '0.38'
			end voltage_lvl
	    , Convert(smalldatetime,Convert(varchar(20), daily.dateBeg,0),0) as dt_start
	    , Convert(smalldatetime,Convert(varchar(20), daily.dateEnd,0),0) as dt_recover	
        , '1' dt_offset 
		, 'П' deenergized_type
		, Cast(Cast(DATEDIFF (minute, 
					Convert(smalldatetime,Convert(varchar(20), daily.dateBeg,0),0),
					Convert(smalldatetime,Convert(varchar(20), daily.dateEnd,0),0)) as numeric(10,2))/60 as numeric(10,2)) duration
         , 2  apv
         , 2  avr
			-----------------------------------------------------------------------------------------------------------
			, Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(
				Stuff(isnull((select Distinct ', ' + c.value('@SubName','varchar(max)') 
							from [tJ_RequestForRepair] d1
								cross apply CommentXml.nodes('//TransTree//*') t(c)
							where doc.id = d1.id  and d1.deleted = 0
								--	and (Case 
								--	when c.exist('@BusName') = 0 then 1
								--	when CHARINDEX('Ш04',c.value('@BusName','varchar(max)'))=0 then 1
								--	else 0
								--end) = 1
							for xml path('')
							),''),1,2,'') 
				,' Яч.<Object>',''),'<','_'),'>','_'),'  ',' '),' № 0',''),'  ',' '),'_Object_',''),',,',','),'&lt;Object&gt;','0'),'&lt;',''),'&gt;','')				
							as feed_objects_list
			----------------------------------------------------------------------------------------------------
         , null consumers_fully_deenergized
		 , Stuff((select distinct '; ' +  abn.AbnNameFull
				from AbnObj abn	where doc.id = abn.idDoc and abn.CategoryAbn in ('I', 'II') and abn.TypeAbn <> 231  and abn.idPoint is not null
				for xml path('')),1,2,'') as consumers_partial_deenergized
		, categorycount.countPointCat1 + categorycount.countPointCat2 + categorycount.countPointCat3+categorycount.countAbnObjEE tp_total
		, categorycount.countPointCat1 tp_cat_1
		, categorycount.countPointCat2 tp_cat_2
		, categorycount.countPointCat3 tp_cat_3
		, categorycount.countPointVoltageVN tp_vn
		, categorycount.countPointVoltageSN1 tp_sn1
		, categorycount.countPointVoltageSN2 tp_sn2
		, categorycount.countPointVoltageNN tp_nn
		, categorycount.countAbnObjEE tp_neigh_org
		, Cast((select distinct  sum(d2.AveragePowerConsumedAbn)
						from AbnObj d2
						where doc.id = d2.idDoc)  * 1000 * 0.000301711 as numeric(10,2)) as power_total
		, Stuff((select distinct '; ' +  abn.nameAbnNet
		   from AbnObj abn	where doc.id = abn.idDoc and abn.nameAbnNet <> ''-- and abn.TypeAbn = 231 
		   for xml path('')) ,1,2,''			) tso_neigh_list
		, Cast(doc.num as varchar(max)) + ' ' +  (Convert(varchar(10),doc.datecreate,120 ) ) log_info
		, null org_reason_code
		, null as tech_reason_code
		, 1 accounting_in_indicators
		, Cast((select distinct  sum(d2.AveragePowerConsumedAbn)
						from AbnObj d2
						where doc.id = d2.idDoc) * (DATEDIFF (minute, daily.dateBeg,daily.dateEnd) /60) * 1000 * 0.000301711 as numeric(10,2))
			--  * 0.1 коэффициент неоднородности
			-- надо бы [сред. мошность]*[время отключения]*1000 * [интегральная ф-я распределения вероятности отказа общей сети = 0.000301711]
			 -- умножить на время отключения (часы) и  на количество физиков и т.д.
		   power_undersupply
  FROM [tJ_RequestForRepair] doc
	right join [tJ_RequestForRepairDaily] daily on doc.id = daily.idRequest
	left join tR_Classifier netRegion on netRegion.id = doc.idSR
	------------------
	left join categorycount on categorycount.idDamage = doc.id
where doc.deleted = 0 
	and (doc.Crash = 0  or doc.crash is null)
	and (Year(daily.dateBeg) = 2019 or Year(daily.dateEnd) = 2019)  and doc.isSendSiteMe  is not null
	and doc.iddivision = 920