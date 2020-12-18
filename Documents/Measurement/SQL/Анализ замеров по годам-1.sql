with 
 MeasPowerISR (Year, idSub, NameSub, idTransf, NameTransf, Power, Isr) as
(select t.year, sub.Id AS idSub, csub.SocrName + '-' + sub.Name AS NameSub, tr.Id AS idTransf, tr.Name AS NameTransf, ref.Power, t.Isr
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
							   --order by m1.Year
						)	t ON t.idObjList = sub.Id
		LEFT JOIN  dbo.tSchm_ObjList AS tr ON tr.Id = t.idTransf
		LEFT JOIN (SELECT [Id]       ,[IdPassport]      ,[TransfName]      ,[Type]      ,CASE Power WHEN '' THEN '0' WHEN NULL   THEN '0' ELSE Power END AS Power
						FROM [GES].[dbo].[vJ_MeasTransfPassport]) ref ON tr.Id = ref.Id
where  csub.ParentKey = ';SCM;PS;' AND csub.Value IN (2, 4) AND tr.TypeCodeId = 556 and tr.Name NOT LIKE '%СН%'
--and sub.id = 777325
--order by t.year, sub.id
)
,ActiveObj (idAbnObj,isActive) as
                                        (select  abnObjDog.id,1 from  tAbnDoc_List lst 
						                        inner JOIN tAbnDoc_Dogovor dog ON dog.idList = lst.id 
					                            inner JOIN tG_Dog_Obj obj ON obj.idDog = dog.id
						                        inner JOIN tAbnObj AS abnobjDog ON abnobjDog.id = obj.idObj 
				                         where  lst.deleted = 0 and lst.isActive <> 0 and dog.FlagBreak = 0 and obj.dateEnd is null
				                         group by abnObjDog.id) , cell	(cellId, cellName, busId, busName, subId, subName, deleted) AS
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
/****************************************************************************/
SELECT MeasPowerISR.Year 'Год замера', 'МУП УльГЭС' 'Сетевая организация',
c.Name+'-'+p.[Name]as 'Подстанция'
		,'6-10/0,4 кВ' 'Класс напряжения'
		,pa1.[CharValue] 'Год ввода в эксплуатацию'
        ,transf.[Name] as transname
		,MeasPowerISR.[Power] 'Мощность трансформатора'
		,round(MeasPowerISR.Isr*0.4*sqrt(3),0) 'Загруженная мощность по факту замера режимного дня'
		,MeasPowerISR.Isr IMax
    FROM [tSchm_ObjList] as transf  
    left join [tSchm_ObjList] p on p.id = transf.idParentAddl
    left join tr_Classifier as c on c.id = p.[TypeCodeId]
    left join vP_PassportDataReports as pa on  pa.[IdObj] =p.id and pa.typecodeid in (538,535,537,536) and pa.[CharName] like 'Принадлежность'
	left join vP_PassportDataReports as pa1 on  pa1.[IdObj] =p.id and pa1.typecodeid in (538,535,537,536) and pa1.[CharName] like 'Год ввода в эксплуатацию'
	
	left join MeasPowerISR  on /*meas.year = MeasPowerISR.year and*/MeasPowerISR.idTransf = transf.[Id] and MeasPowerISR.idSub = p.id
	--left join vJ_Consumer on vJ_Consumer.idSub = MeasPowerISR.idSub
	--left join tr_Classifier as c1 on c1.id = Meas.[TypeDoc]
    where transf.[TypeCodeId] = 556 --and transf.deleted = 0 --and ((Meas.[year]>=2018 and Meas.[year]<=2018) /*or Meas.[year] is null*/)
	and  c.Name+'-'+p.[Name] is not null
	and MeasPowerISR.Year is not null
	and pa.[CharValue] = 'Балансовая'
	--and Meas.[TypeDoc] = 1191 /*замеры только по 0.4кВ*/
    order by MeasPowerISR.Year, p.[TypeCodeId],  c.Name+'-'+p.[Name]

