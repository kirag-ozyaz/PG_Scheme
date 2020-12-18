USE [GES]
GO


SELECT      t.Year,  sub.Id AS idSub, csub.SocrName + '-' + sub.Name AS NameSub, tr.Id AS idTransf, tr.Name AS NameTransf,
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
                               GROUP BY m.Year, m.idObjList, mc.idTransf) AS t ON t.idObjList = sub.Id AND tr.Id = t.idTransf
left join (SELECT [Id]
      ,[IdPassport]
      ,[TransfName]
      ,[Type]
      ,CASE Power WHEN '' THEN '0' WHEN NULL 
                         THEN '0' ELSE Power END AS Power
      --,[InvNumber]
      --,[Unom]
      --,[Inom]
  FROM [GES].[dbo].[vJ_MeasTransfPassport]) ref ON tr.Id = ref.Id
WHERE        (tr.Name NOT LIKE '%СН%') and t.Year is not null
GROUP BY  t.Year, sub.Id, csub.SocrName + '-' + sub.Name, tr.Id, tr.Name, ref.Power
order by  t.Year, csub.SocrName + '-' + sub.Name
GO


