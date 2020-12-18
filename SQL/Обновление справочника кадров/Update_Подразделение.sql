select Подразделение, GUIDПодразделения
from [GES].[dbo].[k_Employee]
group by Подразделение, GUIDПодразделения

/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT eee.*, ddd.Description, ddd.*
  FROM [GES].[dbo].[tR_Division] ddd
    right join (select Подразделение, GUIDПодразделения
from [GES].[dbo].[k_Employee]
group by Подразделение, GUIDПодразделения)  eee on ddd.Description = eee.Подразделение
/************************************************/
--update aaa
--set aaa.GUID = www.GUIDПодразделения
--FROM [GES].[dbo].[tR_Division] aaa
--join (
--		SELECT eee.*, ddd.*
--		  FROM [GES].[dbo].[tR_Division] ddd
--			join (select Подразделение, GUIDПодразделения
--		from [GES].[dbo].[k_Employee]
--		group by Подразделение, GUIDПодразделения)  eee on ddd.Description = eee.Подразделение

--) www
-- on aaa.id = www.id


SELECT  ddd.*
  FROM [GES].[dbo].[tR_Division] ddd
  where guid is not null
  ORDER BY Description