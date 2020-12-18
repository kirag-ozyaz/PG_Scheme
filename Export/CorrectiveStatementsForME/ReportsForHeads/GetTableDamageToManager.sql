/*

		Получение данных по аварийным событиям за период
				-- дата заявки
				-- электроустановка
				-- сетевой район NetRegionSub
				-- место повреждения defectLocation
				-- характер повреждения Character
				-- причина Reason
				-- дата устранения dateApply
				-- выполненная работа completedWork
				-- выполненная работа текст ComletedWorkText

			вход 
			@dataBeg	- дата и время начала
			@dataEnd	- дата и время конца

			typeDoc =  (1401, 1402)

*/
--USE [GES]
--	GO

--declare @dataBeg datetime; 
--declare @dataEnd datetime;
--declare @periodToBeginDay int;  -- диапозон выборки данных от @dataEnd (количество дней)
--declare @timeBeg varchar(5); 
--declare @timeEnd varchar(5); 

--set @timeBeg = '17:00';
--set @timeEnd = '06:00';
--set @periodToBeginDay = 1;
--set @dataEnd = GetDate();

---------------------------------------------
-- необходимы переменные по умолчанию
-- declare @dataBegDefault datetime; 

/* Это для тестов*/
declare @dataEndDefault datetime; set @dataEndDefault = GetDate();
declare @periodToBeginDayDefault int;  set @periodToBeginDayDefault = 1;-- диапозон выборки данных от @dataEnd (количество дней)
declare @timeBegDefault varchar(5); set @timeBegDefault = '17:00';
declare @timeEndDefault varchar(5); set @timeEndDefault = '06:00';
---------------------------
set @dataEnd = Case when @dataEnd is null then @dataEndDefault else @dataEnd end;
set @periodToBeginDay = Case when @periodToBeginDay is null then @periodToBeginDayDefault else @periodToBeginDay end;
set @timeBeg = Case when @timeBeg is null or @timeBeg = '' then @timeBegDefault else @timeBeg end;
set @timeEnd = Case when @timeEnd is null or @timeEnd = '' then @timeEndDefault else @timeEnd end;

set @dataBeg = Case when @dataBeg is null then DATEADD(day, -@periodToBeginDay, @dataEnd) else @dataBeg end;

set @dataBeg = Cast(Cast(Year(@dataBeg) as varchar)+'-'+ Cast(Month(@dataBeg)as varchar)+'-'+Cast(Day(@dataBeg)as varchar) +' ' + @timeBeg as smalldatetime);
set @dataEnd = Cast(Cast(Year(@dataEnd) as varchar)+'-'+ Cast(Month(@dataEnd)as varchar)+'-'+Cast(Day(@dataEnd)as varchar) +' ' + @timeEnd as smalldatetime);

set @dataBeg = Case when @dataBeg >= @dataEnd then @dataEnd else @dataBeg end;

--select @dataEnd, @dataBeg, datediff(minute,  @dataBeg, @dataEnd);


----------------------------------------------------------
-- полный список подстанций всей схемы
with sub (Id, FullName, deleted) AS
	(SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text], o.deleted
	FROM tSchm_ObjList AS o
		LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id
	WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))),
-- полный список шин всей схемы
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
	wHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0)))

					
--------- основной запрос ------------------
SELECT  Case doc.typedoc 
			When 1401 then 'Нарушения НН' 
			when 1402 then 'Нарушения ВН' 
		end typedoc
			, doc.NumRequest,  Cast(doc.numDoc as varchar(max))  as numDoc
			, Convert(smalldatetime,Convert(varchar(20), doc.datedoc,0)) DateDoc
			, isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') obj_name
			, trcNetRegion.socrname + ' (' + trcNetRegion.Comment + ')'  NetRegion -- Cast(netRegion.netRegionVAlue as int)
			, isnull(doc.DefectLocation, '') DefectLocation
			, replace(replace(DamageCharacter.[Character], ',,', ','),',;',';') [Character]
			, reason.name +  isnull( ', '+  Case 
					when map.idMap is null AND doc.idStreet is null then docLV.DeclarerAddress
					else
						(case 
							when streetMap.id is null then streetDoc.Socr + '. ' + streetDoc.Name 
							else 
								streetMap.Socr + '. ' + streetMap.Name+', '+	Cast(map.House as varchar(max)) +
										+ Case when (substring(map.HousePrefix, 1, 1) = '/') then '' when map.HousePrefix is null then '' else '/' end + isNull(map.HousePrefix, '')
						end) 
					end, '')  as reason -- причина + адрес по НН
			, doc.dateApply
			, isnull(complWork.name, '') +' '+  isnull(doc.ComletedWorkText, '') as completedWork
			, doc.ComletedWorkText
		
  FROM [dbo].[tJ_Damage] doc
	left join cell on cell.cellid = doc.idSchmObj
	left join bus on bus.id = doc.idSChmObj
	left join sub on sub.id = doc.idSChmObj
	------------------------
	left join [vP_SubstationByNetRegion] netRegion on netRegion.id = isnull(cell.subid, isnull(bus.subid, sub.id))
	left join tR_Classifier trcNetRegion on trcNetRegion.id = netRegion.idNetRegion
	---------------
	left join tR_Classifier reason on reason.id = doc.idReason
	left join tr_classifier complWork on complWork.id = doc.idCompletedWork
	---------------
		inner join (select id, 
					[Character] = (select isnull(col1.name, '') +
									isnull(',' + dbo.fn_Schm_GetFullNameObjById(ch.idSChmObj), '') +
									isnull(',' + case when pass.charvalue = 'Балансовая' then 'бал' else case when pass.charvalue = 'Абонентская' then 'аб' else null end end, '') +
									isnull(',' + col2.name, '') + isnull(','+ col3.name, '') + '; '
									from dbo.tJ_DamageCharacter ch
										left join tr_Classifier col1 on col1.id = ch.col1
										left join tr_Classifier col2 on col2.id = ch.col2
										left join tr_Classifier col3 on col3.id = ch.col3
										left join vP_PassportDataReports pass on pass.idObj = ch.idSChmObj
											 and pass.[CharName] like 'Принадлежность' 											 
									where ch.idDamage = t.id for xml path(''))									
				from tj_Damage t) as DamageCharacter on damagecharacter.id = doc.id
	--------------- соберем адреc события
		left join tMapObj map on map.idMap = doc.idMap
		left join tR_KladrStreet streetMap on streetMap.id = map.[Street]
		left join tR_KladrStreet streetDoc on streetDoc.id = doc.idStreet
		left join tJ_DamageLV docLV on docLV.idDamage = doc.id
  where doc.typedoc in (1401,1402) and doc.deleted= 0
	and (doc.DateDoc <= @dataEnd and doc.DateDoc >= @dataBeg)
  order by  doc.typedoc, doc.datedoc
