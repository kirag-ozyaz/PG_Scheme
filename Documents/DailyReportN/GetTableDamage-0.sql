--use ges;
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
	-- feed_objects_list = [Перечень объектов] внутри системы выберем из CommentXml
	-- obj_type = [Вид объекта], obj_name = [Диспетчерское наименование], voltage_lvl = [Высший класс напряжения]
	-- '2' apv,'2' avr
	-- 1 dt_offset, 'В' deenergized_type
	-- '' org_reason_code
	-- '1' accounting_in_indicators
	-- '' consumers_fully_deenergized -- всегда пусто
--- состав CommentXml
AbnObj(idDoc, idAbnObj, TypeDoc, NumRequest, DateDoc, idPoint, AveragePowerConsumedAbn, AbnNameFull, AbnNameODS, typeAbn, CategoryAbn, TarifName, Voltage) as
(select d.id idDoc, col.idAbnObj.value('@idAbnObj', 'int') idAbnObj, d.TypeDoc, d.NumRequest,  d.DateDoc
	 , aopn.idPoint, [dbo].[fn_GetAveragePower] ( col.idAbnObj.value('@idAbnObj', 'int') , aopn.idPoint, d.DateDoc, 2) AveragePowerConsumedAbn
	 , col.idAbnObj.value('@nameAbn', 'varchar(max)') AbnNameFull, tG_AbnNameODS.NameODS
	 , col.idAbnObj.value('@typeAbn', 'int') typeAbn
	 , col.idAbnObj.value('@CategoryName', 'varchar(max)') CategoryAbn
	 , col.idAbnObj.value('@TarifName', 'varchar(max)') TarifName
	 , isnull(col.idAbnObj.value('@Voltage', 'varchar(max)'), 'НН') Voltage
			from tj_damage d
			outer apply d.CommentXml.nodes('/Doc/AbnOff/Row') col(idAbnObj)
			left join dbo.vAbnObjPointName aopn on aopn.id = col.idAbnObj.value('@idAbnObj', 'int') and aopn.isActive = 1 and aopn.Deleted = 0
			left join tG_AbnNameODS on aopn.idAbn = tG_AbnNameODS.idAbn
			where d.deleted = 0 and d.isSendSiteMe =  1)
--------- основной запрос ------------------						
select doc.id id, '' num, Cast(netRegion.netRegionVAlue as int) name
	--, doc.idSchmObj, doc.CommentXml
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
				 end), isnull(chNameCol1.SocrName,chNameCol1.name)) obj_type
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
 	, Cast(Cast(DATEDIFF (minute, Convert(smalldatetime,Convert(varchar(20), doc.datedoc,0),0),Convert(smalldatetime,Convert(varchar(20), doc.dateApply,0),0)) as numeric(10,2))/60 as numeric(10,2)) duration
	, Stuff(isnull((select Distinct ', ' + c.value('@SubName','varchar(max)') 
							from tj_damage d1
								cross apply CommentXml.nodes('//TransTree//*') t(c)
							where doc.id = d1.id  and d1.deleted = 0 and d1.isSendSiteMe =  1
							for xml path('')
							),''),1,2,'')  as feed_objects_list
    , Stuff((select distinct '; ' +  isnull(abn.AbnNameODS, abn.AbnNameFull)
		from AbnObj abn	where doc.id = abn.idDoc and abn.CategoryAbn in ('I', 'II') and abn.TypeAbn <> 231  and abn.idPoint is not null
		for xml path('')),1,2,'') as consumers_partial_deenergized
    , (select distinct  count(abn.idPoint) from AbnObj abn	where doc.id = abn.idDoc and abn.idPoint is not null) tp_total
    , (select distinct  count(abn.idPoint) from AbnObj abn	where doc.id = abn.idDoc and abn.CategoryAbn = 'I'   and abn.TypeAbn <> 231 and abn.idPoint is not null ) tp_cat_1
    , (select distinct  count(abn.idPoint) from AbnObj abn	where doc.id = abn.idDoc and abn.CategoryAbn = 'II'  and abn.TypeAbn <> 231 and abn.idPoint is not null ) tp_cat_2
    , (select distinct  count(abn.idPoint) from AbnObj abn	where doc.id = abn.idDoc and abn.CategoryAbn = 'III' and abn.TypeAbn <> 231 and abn.idPoint is not null ) tp_cat_3
    , (select distinct  count(abn.idPoint) from AbnObj abn	where doc.id = abn.idDoc and abn.Voltage = 'ВН'   and abn.TypeAbn <> 231 and abn.idPoint is not null) tp_vn
    , (select distinct  count(abn.idPoint) from AbnObj abn	where doc.id = abn.idDoc and abn.Voltage = 'СН-1' and abn.TypeAbn <> 231 and abn.idPoint is not null) tp_sn1
    , (select distinct  count(abn.idPoint) from AbnObj abn	where doc.id = abn.idDoc and abn.Voltage = 'СН-2' and abn.TypeAbn <> 231 and abn.idPoint is not null) tp_sn2
    , (select distinct  count(abn.idPoint) from AbnObj abn	where doc.id = abn.idDoc and abn.Voltage not in ('ВН','СН-1','СН-2')  and abn.TypeAbn <> 231 and abn.idPoint is not null) tp_nn
    , (select distinct  count(abn.idPoint) from AbnObj abn	where doc.id = abn.idDoc and abn.TypeAbn = 231 and abn.idPoint is not null  ) tp_neigh_org
    , isnull(Case doc.typeDoc
				when 1402 then dHV.NoAdmissionKWT
				else Cast((select distinct  sum(abn.AveragePowerConsumedAbn)
							from AbnObj abn
							where doc.id = abn.idDoc) * DATEDIFF (minute, doc.datedoc,doc.dateApply) /60 * 1000 * 0.000301711 as numeric(10,2))
							--  * 0.1 коэффициент неоднородности
							-- умножить на время отключения (часы) и  на количество физиков и т.д.
			end, 0 )as power_total
    , Stuff((select distinct '; ' +  isnull(abn.AbnNameODS, abn.AbnNameFull)
	   from AbnObj abn	where doc.id = abn.idDoc and abn.TypeAbn = 231 
	   for xml path('')) ,1,2,''			) tso_neigh_list -- из CommentXml
    , case when actD.id is not null then actD.numRequest + ' ' + convert( varchar(10),actd.dateDoc, 120)
       else doc.numRequest + ' ' + convert( varchar(10),doc.dateDoc, 120) end  as  log_info
    , Case (ISNULL((Case 
					when сTypeSchmObj.SocrName  in ('Т', 'ПП', 'ЦП', 'ППНО', 'СП') then 'ПС' 
					when сTypeSchmObj.SocrName  in ('ВЛЗ') then 'ВЛ' 
					when сTypeSchmObj.SocrName  in ('СЛ') then 'КВЛ' 
					when сTypeSchmObj.parentkey like ';SCM;Cell;%' or сTypeSchmObj.parentkey like ';SCM;BUS;%' 
						then (  
							select Case when c.SocrName in ('ПП', 'ЦП', 'ППНО', 'СП') then 'ПС' 
									when c.SocrName  in ('ВЛЗ') then 'ВЛ' 
									when c.SocrName  in ('СЛ') then 'КВЛ' 
									else c.SocrName
									end
							from tSchm_ObjList t1 
							join tSchm_ObjList t2 on t1.id = t2.idparent and t2.id = oTypeSchmObj.id
							left join tR_Classifier  c on t1.TypeCodeId = c.id )
					else сTypeSchmObj.SocrName 
				 end), isnull(chNameCol1.SocrName,chNameCol1.name)))
				when 'КЛ' then '4.12'
				when 'ВЛ' then '4.13'
				when 'ПС' then '4.13'
				when 'ТП' then '4.13'
				when 'РП' then '4.13'
				end as tech_reason_code
	, Case  when doc.is81 = 1 then 1 else 0 end accounting_in_indicators
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
	left join tj_damageHV dHV on dHV.idDamage = doc.id
where doc.deleted = 0 and doc.isSendSiteMe  = 1 and Year(doc.DateDoc) >= 2019
order by doc.id desc