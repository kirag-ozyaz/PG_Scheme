use ges;
with 
 MeasPowerISR (Year, idSub, NameSub, idTransf, NameTransf, Power, Isr) as
(SELECT      t.Year,  sub.Id AS idSub, csub.SocrName + '-' + sub.Name AS NameSub, tr.Id AS idTransf, tr.Name AS NameTransf,
 ref.Power, (MAX(t.Ia) + MAX(t.Ib) + MAX(t.Ic)) / 3 AS Isr /*выбираем макс. замер*/
FROM            dbo.tSchm_ObjList AS sub 
		INNER JOIN  dbo.tR_Classifier AS csub ON sub.TypeCodeId = csub.Id AND csub.ParentKey = ';SCM;PS;' AND csub.Value IN (2, 4) AND sub.Deleted = 0 
		INNER JOIN  dbo.tSchm_ObjList AS tr ON sub.Id = tr.idParentAddl AND tr.TypeCodeId = 556 AND tr.Deleted = 0 
		LEFT OUTER JOIN		/*ночные замеры*/
							 (SELECT   m.Year, m.idObjList, mc.idTransf, SUM(mc.Ian) AS Ia, SUM(mc.Ibn) AS Ib, SUM(mc.Icn) AS Ic
                               FROM            dbo.tJ_Measurement AS m LEFT OUTER JOIN
                                                         dbo.tJ_MeasCable AS mc ON m.id = mc.idMeasurement AND mc.Deleted = 0
                               WHERE    (m.TypeDoc = 1191) AND (m.Deleted = 0)
                               GROUP BY m.Year,m.idObjList, mc.idTransf
                               UNION ALL
							   /*дневные замеры*/
                               SELECT    m.Year,    m.idObjList, mc.idTransf, SUM(mc.Iad) AS Ia, SUM(mc.Ibd) AS Ib, SUM(mc.Icd) AS Ic
                               FROM            dbo.tJ_Measurement AS m LEFT OUTER JOIN
                                                        dbo.tJ_MeasCable AS mc ON m.id = mc.idMeasurement AND mc.Deleted = 0
                               WHERE    (m.TypeDoc = 1191) AND (m.Deleted = 0)
                               GROUP BY m.Year, m.idObjList, mc.idTransf) AS t ON t.idObjList = sub.Id --AND tr.Id = t.idTransf
		left join (SELECT [Id]       ,[IdPassport]      ,[TransfName]      ,[Type]      ,CASE Power WHEN '' THEN '0' WHEN NULL   THEN '0' ELSE Power END AS Power  FROM [GES].[dbo].[vJ_MeasTransfPassport]) ref ON tr.Id = ref.Id
WHERE        (tr.Name NOT LIKE '%СН%') and t.Year is not null
GROUP BY  t.Year, sub.Id, csub.SocrName + '-' + sub.Name, tr.Id, tr.Name, ref.Power
--order by  t.Year, csub.SocrName + '-' + sub.Name
)
,ActiveObj (idAbnObj,isActive) as
                                        (select  abnObjDog.id,1 from  tAbnDoc_List lst 
						                        inner JOIN tAbnDoc_Dogovor dog ON dog.idList = lst.id 
					                            inner JOIN tG_Dog_Obj obj ON obj.idDog = dog.id
						                        inner JOIN tAbnObj AS abnobjDog ON abnobjDog.id = obj.idObj 
				                         where  lst.deleted = 0 and lst.isActive <> 0 and dog.FlagBreak = 0 and obj.dateEnd is null
				                         group by abnObjDog.id)
, cell	(cellId, cellName, busId, busName, subId, subName, deleted) AS
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
                            WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0)))
, bus (Id, busName, subid, subname, deleted) AS
                                    (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name, 
		                                case when o.deleted = 0 and sub.deleted = 0 then 0 else 1 end
                                     FROM tSchm_ObjList AS o 
	                                    JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id
	                                    join tSChm_ObjList sub on sub.id = o.idParent
	                                    join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id
                                     WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0)))
, sub (Id, FullName, deleted) AS
                                (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text], o.deleted
                                 FROM tSchm_ObjList AS o
                                    LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id
                                 WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0)))
,	pow (idAbnObj, PowerSet, DateChange) AS
	(SELECT distinct idAbnObj, PowerSet, MIN(DateChange) 
		FROM tAbnObjReg
		WHERE PowerSet <> 0 AND PowerSet is not null
		GROUP BY idAbnObj, PowerSet) 	
,	vj_Consumer (idAbn,codeAbonent,nameAbn,typeAbn,TypeAbnName,deletedAbn,activeAbn,idAbnObj,nameAbnObj,KladrObjName,streetname,house,objActive,idSchmObj,CellName,
busname,subname,schmObjName,IdSub,PowerSet, YearPowerSetChange) as
(select a.idAbn, a.codeAbonent, a.name as nameAbn, a.typeAbn, 
	    a.TypeAbnName, a.deleted as deletedAbn, a.isActive as activeAbn,
	    a.id as idAbnObj, a.nameObj as nameAbnObj, a.KladrObjName, a.streetname,
	    cast(a.house as varchar(10)) + isnull(a.houseprefix, '') as house,
	    case when a.TypeAbn in (207,230,231) then isnull(ActiveObj.isActive, 0) else 1 end as objActive 
		,link.idSchmObj 
		,cell.CellName 
		,isnull(cell.BusName, bus.busname) as busname 
		,isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname 
		,isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+
		                              isnull('\' + isnull(cell.BusName, bus.busname), '')+isnull('\'+cell.CellName, '') as schmObjName 
		,isnull(cell.subid, isnull(bus.subid, sub.id)) as IdSub  
		, PowerSet, Year(DateChange) YearPowerSetChange
		from vAbnObj a 
            left join ActiveObj on ActiveObj.idAbnObj = a.id  
			left join tl_SchmAbn link on link.idAbnObj = a.id
			left join cell on cell.cellid = link.idSchmObj
			left join bus on bus.id = link.idSChmObj
			left join sub on sub.id = link.idSChmObj
			left join pow on pow.idAbnObj = a.id
		where (a.TypeAbn in (206,207)) and (a.isActive = 1) and (a.deleted = 0) and (a.TypeAbn not in (207,230,231) or activeObj.isActive = 1) 
		)
/****************************************************************************/
SELECT  MeasPowerISR.Year 'Год замера', 
		'МУП УльГЭС' 'Сетевая организация',
		c.Name+'-'+p.[Name]as 'Подстанция'
		,'6-10/0,4 кВ' 'Класс напряжения'
		,pa1.[CharValue] 'Год ввода в эксплуатацию'
		,''  '(при изменении установленной мощности)'
       -- ,transf.[Name] as transname
		,max(MeasPowerISR.[Power]) 'Макимально допустимая загрузка трансформаторной мощности, МВА'
		,max(MeasPowerISR.[Power]) 'Макимально допустимая загрузка трансформаторной мощности, МВт'
		,Isnull(sum(vJ.PowerSet),0)/1000 'Загруженная мощность по актам об осуществлении ТП, МВт'
		,sum(round(MeasPowerISR.Isr*0.4*sqrt(3),0)) 'Загруженная мощность по факту замера режимного дня, кВт'
		--,MeasPowerISR.Isr IMax
		
    FROM [tSchm_ObjList] as transf  
		left join [tSchm_ObjList] p on p.id = transf.idParentAddl
		left join tr_Classifier as c on c.id = p.[TypeCodeId]-- подстанция
		left join vP_PassportDataReports as pa on  pa.[IdObj] =p.id and pa.typecodeid in (538,535,537,536) and pa.[CharName] like 'Принадлежность'
		left join vP_PassportDataReports as pa1 on  pa1.[IdObj] =p.id and pa1.typecodeid in (538,535,537,536) and pa1.[CharName] like 'Год ввода в эксплуатацию'
		left join MeasPowerISR  on /*MeasPowerISR.idTransf = transf.[Id] and*/ MeasPowerISR.idSub = p.id
		left join (select idSub, YearPowerSetChange, sum(PowerSet) PowerSet from vJ_Consumer group by idSub, YearPowerSetChange ) vj on vJ.idSub  = p.id/*MeasPowerISR.idSub */ and vJ.YearPowerSetChange = MeasPowerISR.Year

  where transf.[TypeCodeId] = 556 and transf.deleted = 0
				and  c.Name+'-'+p.[Name] is not null
				and MeasPowerISR.Year is not null
				and pa.[CharValue] = 'Балансовая'
				--and p.[Name] = '101'
   group by MeasPowerISR.Year,
         c.Name+'-'+p.[Name],
         pa1.[CharValue]
         --,p.[TypeCodeId]
   order by   c.Name+'-'+p.[Name]--,Meas.[year]
	,MeasPowerISR.Year

