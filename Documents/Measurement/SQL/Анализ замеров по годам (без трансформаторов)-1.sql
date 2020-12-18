use ges;
with 
 MeasPowerISR (Year, idSub, NameSub, idTransf, NameTransf, Power, Pmax) as
(SELECT      t.Year,  sub.Id AS idSub, csub.SocrName + '-' + sub.Name AS NameSub, tr.Id AS idTransf, tr.Name AS NameTransf,
 Cast(ref.Power as float)/1000,
 round(t.Isr*0.4*sqrt(3),0)
FROM dbo.tSchm_ObjList AS sub 
		LEFT JOIN  dbo.tR_Classifier AS csub ON sub.TypeCodeId = csub.Id
		LEFT JOIN  (Select   m1.Year, m1.idObjList, m1.idTransf, round( (cast((MAX(m1.Ia) + MAX(m1.Ib) + MAX(m1.Ic)) as float))/3,0) AS Isr--(MAX(m1.Ia) + MAX(m1.Ib) + MAX(m1.Ic)) / 3 AS Isr /*выбираем макс. замер*/
							From 
						      /*ночные замеры*/
							 (SELECT   m.Year, m.idObjList, mc.idTransf, SUM(mc.Ian) AS Ia, SUM(mc.Ibn) AS Ib, SUM(mc.Icn) AS Ic
                               FROM            dbo.tJ_Measurement AS m LEFT JOIN
                                                         dbo.tJ_MeasCable AS mc ON m.id = mc.idMeasurement AND mc.Deleted = 0
                               WHERE    (m.TypeDoc = 1191) AND (m.Deleted = 0)
                               GROUP BY m.Year,m.idObjList, mc.idTransf
                               UNION ALL
							   /*дневные замеры*/
                               SELECT    m.Year,    m.idObjList, mc.idTransf, SUM(mc.Iad) AS Ia, SUM(mc.Ibd) AS Ib, SUM(mc.Icd) AS Ic
                               FROM            dbo.tJ_Measurement AS m LEFT JOIN
                                                        dbo.tJ_MeasCable AS mc ON m.id = mc.idMeasurement AND mc.Deleted = 0
                               WHERE    (m.TypeDoc = 1191) AND (m.Deleted = 0)
                               GROUP BY m.Year, m.idObjList, mc.idTransf) AS m1 
							   --where m1.idObjList = 777325
							   group by m1.Year, m1.idObjList, m1.idTransf
							  
						)	t ON t.idObjList = sub.Id
		LEFT JOIN  dbo.tSchm_ObjList AS tr ON tr.Id = t.idTransf
		LEFT JOIN (SELECT [Id]       ,[IdPassport]      ,[TransfName]      ,[Type]      ,CASE Power WHEN '' THEN '0' WHEN NULL   THEN '0' ELSE Power END AS Power
						FROM [GES].[dbo].[vJ_MeasTransfPassport]) ref ON tr.Id = ref.Id
where  csub.ParentKey = ';SCM;PS;' AND csub.Value IN (2, 4) AND tr.TypeCodeId = 556 and tr.Name NOT LIKE '%СН%'
--order by t.Year
)
, cell (cellId, cellName, busId, busName, subId, subName, deleted) AS
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
, pow (idAbnObj, PowerSet, YearChange) AS
	(SELECT distinct idAbnObj, PowerSet, Year(MIN(Isnull(DateChange,2000))) 
		FROM tAbnObjReg
		WHERE PowerSet <> 0 AND PowerSet is not null
		GROUP BY idAbnObj, PowerSet) 	
, v_SubPowerSet (IdSub, YearPowerSetChange, PowerSet) as
		(select isnull(cell.subid, isnull(bus.subid, sub.id)) as IdSub, pow.YearChange YearPowerSetChange, sum(pow.PowerSet) PowerSet 
		 from tl_SchmAbn link
			left join cell on cell.cellid = link.idSchmObj
			left join bus on bus.id = link.idSChmObj
			left join sub on sub.id = link.idSChmObj
			left join pow on pow.idAbnObj = link.idAbnObj -- and pow.YearChange = Year(link.DateOwner)
		 where pow.YearChange  is not null
		 group by isnull(cell.subid, isnull(bus.subid, sub.id)), pow.YearChange
		)
/****************************************************************************/
SELECT  MeasPowerISR.Year 'Год замера', 
		'МУП УльГЭС' 'Сетевая организация',
		MeasPowerISR.NameSub as 'Подстанция'
		,'6-10/0,4 кВ' 'Класс напряжения'
		,pa1.[CharValue] 'Год ввода в эксплуатацию'
		,''  '(при изменении установленной мощности)'
		,max(MeasPowerISR.[Power]) 'Макимально допустимая загрузка трансформаторной мощности, МВА'
		,max(MeasPowerISR.[Power]) 'Макимально допустимая загрузка трансформаторной мощности, МВт'
		,round(Isnull(sum(vj.PowerSet),0)/1000, 3)       'Загруженная мощность по актам об осуществлении ТП, МВт'
		,round(Isnull(sum(MeasPowerISR.Pmax),0)/1000, 3) 'Загруженная мощность по факту замера режимного дня, МВт'
    FROM  MeasPowerISR  
		left join vP_PassportDataReports as pa on  pa.[IdObj] = MeasPowerISR.idSub and pa.typecodeid in (538,535,537,536) and pa.[CharName] like 'Принадлежность'
		left join vP_PassportDataReports as pa1 on  pa1.[IdObj] = MeasPowerISR.idSub and pa1.typecodeid in (538,535,537,536) and pa1.[CharName] like 'Год ввода в эксплуатацию'
		
		left join v_SubPowerSet vj on vJ.idSub  = MeasPowerISR.idSub and vJ.YearPowerSetChange = MeasPowerISR.Year

  where pa.[CharValue] = 'Балансовая'
  group by MeasPowerISR.Year
         ,MeasPowerISR.NameSub
         ,pa1.[CharValue] 
   order by   MeasPowerISR.NameSub
	,MeasPowerISR.Year
