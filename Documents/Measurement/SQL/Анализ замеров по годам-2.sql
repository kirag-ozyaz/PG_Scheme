select t.year 'Год замера'
	   --,sub.Id AS idSub
	   --, 'МУП УльГЭС' 'Сетевая организация'
	   , csub.SocrName + '-' + sub.Name AS 'Подстанция'
	   --, '6-10/0,4 кВ' 'Класс напряжения'
	   , pa1.[CharValue] 'Год ввода в эксплуатацию'
	   --, ''  '(при изменении установленной мощности)'
	   --, tr.Id AS idTransf
	   , tr.Name AS NameTransf
	   --, ref.Power 'Макимально допустимая загрузка трансформаторной мощности, МВА'
	   , Cast(ref.Power as float)/1000 'Макимально допустимая загрузка трансформаторной мощности, МВт'
	   --, 0 'Загруженная мощность по актам об осуществлении ТП, МВт'-- нет данных чтобы техприсоединение разбить по трансформаторам
	   , t.Isr 'Максимальная нагрузка по факту замера режимного дня, А' --IMax
	   , round(t.Isr*0.4*sqrt(3),0) 'Загруженная мощность по факту замера режимного дня, Вт'
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
		-----------
		left join vP_PassportDataReports as pa on  pa.[IdObj] =sub.id and pa.typecodeid in (538,535,537,536) and pa.[CharName] like 'Принадлежность'
		left join vP_PassportDataReports as pa1 on  pa1.[IdObj] =sub.id and pa1.typecodeid in (538,535,537,536) and pa1.[CharName] like 'Год ввода в эксплуатацию'

where  csub.ParentKey = ';SCM;PS;' AND csub.Value IN (2, 4) AND tr.TypeCodeId = 556 and tr.Name NOT LIKE '%СН%'
and pa.[CharValue] = 'Балансовая'
-- and t.year = '2010'
and sub.id = 777325
and t.Year is  not null
and csub.SocrName + '-' + sub.Name is not null
order by t.year, sub.id
