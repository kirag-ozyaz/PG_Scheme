select �������������, GUID�������������
from [GES].[dbo].[k_Employee]
group by �������������, GUID�������������

/****** ������ ��� ������� SelectTopNRows �� ����� SSMS  ******/
SELECT eee.*, ddd.Description, ddd.*
  FROM [GES].[dbo].[tR_Division] ddd
    right join (select �������������, GUID�������������
from [GES].[dbo].[k_Employee]
group by �������������, GUID�������������)  eee on ddd.Description = eee.�������������
/************************************************/
--update aaa
--set aaa.GUID = www.GUID�������������
--FROM [GES].[dbo].[tR_Division] aaa
--join (
--		SELECT eee.*, ddd.*
--		  FROM [GES].[dbo].[tR_Division] ddd
--			join (select �������������, GUID�������������
--		from [GES].[dbo].[k_Employee]
--		group by �������������, GUID�������������)  eee on ddd.Description = eee.�������������

--) www
-- on aaa.id = www.id


SELECT  ddd.*
  FROM [GES].[dbo].[tR_Division] ddd
  where guid is not null
  ORDER BY Description