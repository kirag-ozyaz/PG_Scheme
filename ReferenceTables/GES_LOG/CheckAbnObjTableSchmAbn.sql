declare @dt datetime
set @dt='20170102'
declare @id int
set @id = 1492341

select *
from(
SELECT top 1 id
  FROM [GES_log].[dbo].[tL_SchmAbn]
  where idabnobj = @id  and (@dt is null or datecommand > @dt)
  union all
SELECT top 1 id
  FROM [GES_log].[dbo].[tL_SchmAbn]
  where idabnobj = @id  and (@dt is null or datecommand <= @dt)
  order by id desc
  ) aa order by id asc
SELECT  * FROM [GES_log].[dbo].[tL_SchmAbn]	where idabnobj = @id  --and (@dt is null or datecommand <= @dt)
order by id desc
SELECT top 1 id FROM [GES_log].[dbo].[tL_SchmAbn] where idabnobj = @id  and (@dt is null or datecommand <= @dt)  order by id desc -- up
SELECT top 1 id FROM [GES_log].[dbo].[tL_SchmAbn] where idabnobj = @id  and (@dt is null or datecommand > @dt)  --  down

/**

** Шумилов прислал - не работает

declare @dt datetime
set @dt='20170102'

select l.* from ges.dbo.TAbnObj ao
	left join ges_log.dbo.tL_SchmAbn l on l.id = 
			(select top 1 id from GES_log.dbo.tL_SchmAbn where idAbnObj = ao.id and ((Command in ('ins','updins') and dateCommand <= @dt) or
																						(Command in  ('del', 'upddel') and dateCommand >= @dt))
			order by dateCommand desc)
where ao.id in (1880792,1872456,1885818,1875760,1492341,1880612)

**/