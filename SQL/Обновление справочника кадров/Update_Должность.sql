------------------- 178 ��
--select ���������, isnull([������ (���������)], 0) ������ , GUID���������
--from [GES].[dbo].[k_Employee]
--group by ���������, [������ (���������)], GUID���������
-------------------------------------------
SELECT [id],[Description],RTrim([RName]) + ' ' + Cast([Razrjad] as varchar) Razrjad, kkk.���������, kkk.������, kkk.GUID���������
  FROM [GES].[dbo].[tR_JobTitle] jjj
  left join (
		  select ���������, isnull([������ (���������)], 0) ������ , GUID���������
			from [GES].[dbo].[k_Employee]
			group by ���������, [������ (���������)], GUID���������
			) kkk on  kkk.��������� = jjj.[Description] -- and (Cast([Razrjad] as varchar) + ' ' + RTrim([RName])) = kkk.������
  order by [Description]
  --------------------------------------------------------------------
--update aaa
--set aaa.GUID = www.GUID���������
--FROM [GES].[dbo].[tR_JobTitle] aaa
--join (
--	SELECT [id],[Description],RTrim([RName]) + ' ' + Cast([Razrjad] as varchar) Razrjad, kkk.���������, kkk.������, kkk.GUID���������
--		 FROM [GES].[dbo].[tR_JobTitle] jjj
--		 left join (
--			select ���������, isnull([������ (���������)], 0) ������ , GUID���������
--			from [GES].[dbo].[k_Employee]
--			group by ���������, [������ (���������)], GUID���������
--			) kkk on  kkk.��������� = jjj.[Description]

--) www
-- on aaa.id = www.id
-----------------------
SELECT  ddd.*
  FROM [GES].[dbo].tR_JobTitle ddd
  where guid is not null
  ORDER BY Description


