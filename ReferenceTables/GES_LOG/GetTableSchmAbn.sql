declare @dt datetime
set @dt='20170102'
--SELECT top 1 id
--				FROM [GES_log].[dbo].[tL_SchmAbn]
--				where idabnobj = 1880612  and (@dt is null or datecommand <= @dt)

SELECT  tl.*
  FROM [GES_log].[dbo].[tL_SchmAbn] tl
  where tl.idabnobj in (1880792,1872456,1885818,1875760,1492341,1880612)  and tl.id = 
			(Select Top 1 id
			 from
			    (
				SELECT top 1 id -- смортим по последнему снизу 
					FROM [GES_log].[dbo].[tL_SchmAbn]
					where idabnobj = tl.idabnobj  and (@dt is null or datecommand > @dt)
						union all
				SELECT top 1 id -- запрос смотрим по последнему сверху
					FROM [GES_log].[dbo].[tL_SchmAbn]
					where idabnobj = tl.idabnobj  and (@dt is null or datecommand <= @dt)
					order by id desc
				) tlAll
				order by id asc
			)
  order by tl.id desc