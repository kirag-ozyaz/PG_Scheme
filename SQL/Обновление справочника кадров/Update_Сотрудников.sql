update aaa
set aaa.GUID = www.GUIDEmp
from [GES].[dbo].[tR_Worker] aaa
join (SELECT  w.*, e.GUIDEmp
		FROM (
			Select * from [GES].[dbo].[tR_Worker] w1
				where  w1.id = 
					(Select top 1 id 
						from [GES].[dbo].[tR_Worker]
						where inn = w1.inn 
						order by id desc
					)
		) w
	join [GES].[dbo].[k_Employee] e on e.INN = w.INN
  where dateend is  null and [Division] <> 52
  and (f is not null and i is not null and i <> '' and o is not null and o <> '' and w.INN is not null and w.INN <> '')
) www
  on aaa.id = www.id