------------------- 178 шт
--select Должность, isnull([Разряд (категория)], 0) Разряд , GUIDДолжности
--from [GES].[dbo].[k_Employee]
--group by Должность, [Разряд (категория)], GUIDДолжности
-------------------------------------------
SELECT [id],[Description],RTrim([RName]) + ' ' + Cast([Razrjad] as varchar) Razrjad, kkk.Должность, kkk.Разряд, kkk.GUIDДолжности
  FROM [GES].[dbo].[tR_JobTitle] jjj
  left join (
		  select Должность, isnull([Разряд (категория)], 0) Разряд , GUIDДолжности
			from [GES].[dbo].[k_Employee]
			group by Должность, [Разряд (категория)], GUIDДолжности
			) kkk on  kkk.Должность = jjj.[Description] -- and (Cast([Razrjad] as varchar) + ' ' + RTrim([RName])) = kkk.Разряд
  order by [Description]
  --------------------------------------------------------------------
--update aaa
--set aaa.GUID = www.GUIDДолжности
--FROM [GES].[dbo].[tR_JobTitle] aaa
--join (
--	SELECT [id],[Description],RTrim([RName]) + ' ' + Cast([Razrjad] as varchar) Razrjad, kkk.Должность, kkk.Разряд, kkk.GUIDДолжности
--		 FROM [GES].[dbo].[tR_JobTitle] jjj
--		 left join (
--			select Должность, isnull([Разряд (категория)], 0) Разряд , GUIDДолжности
--			from [GES].[dbo].[k_Employee]
--			group by Должность, [Разряд (категория)], GUIDДолжности
--			) kkk on  kkk.Должность = jjj.[Description]

--) www
-- on aaa.id = www.id
-----------------------
SELECT  ddd.*
  FROM [GES].[dbo].tR_JobTitle ddd
  where guid is not null
  ORDER BY Description


