--select distinct  r.StreetId, r.GNINMB, stuff(( select  ',' + t.name from dbo.tR_KladrDoma t where t.StreetId = r.StreetId for xml path('')),1,1,'')
--from dbo.tR_KladrDoma  r


--select  stuff(( select  ',' + t.name from dbo.tR_KladrDoma t where  t.StreetId = 327 for xml path('')),1,1,'')


SELECT map.*, cl.name raion, 
		clStreet.name Street, clStreet.GNINMB, 
		clSity1.name Sity1, clSity1.GNINMB,clSity.name Sity, clSity.GNINMB 
		--,clDoma.name Doma, clDoma.GNINMB
		, ( stuff(( select  ',' + t.name from dbo.tR_KladrDoma t where  t.StreetId = clStreet.id for xml path('')),1,1,''))
		, houses.list, houses.GNINMB 
  FROM [GES].[dbo].[tMapObj] map 
  left join tr_Classifier cl on map.raion = cl.id
  left join tR_KladrStreet clStreet on map.street = clStreet.id
  left join dbo.tR_KladrObj AS clSity ON clSity.Id = clStreet.KladrObjId
  left join dbo.tR_KladrObj AS clSity1 ON clSity1.Id = clSity.ParentId
  --left join dbo.tR_KladrDoma AS clDoma ON clDoma.StreetId = clStreet.id
  left join (
  select distinct  r.StreetId, r.GNINMB, stuff(( select  ',' + t.name from dbo.tR_KladrDoma t where t.StreetId = r.StreetId for xml path('')),1,1,'') list
from dbo.tR_KladrDoma  r
   
  ) as houses on houses.StreetId  = clStreet.id 

 