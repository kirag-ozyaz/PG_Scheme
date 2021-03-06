/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT map.*, cl.name raion, 
		clStreet.name Street, clStreet.GNINMB, 
		clSity1.name Sity1, clSity1.GNINMB,clSity.name Sity, clSity.GNINMB 
		,clDoma.name Doma, clDoma.GNINMB
  FROM [GES].[dbo].[tMapObj] map 
  left join tr_Classifier cl on map.raion = cl.id
  left join tR_KladrStreet clStreet on map.street = clStreet.id
  left join dbo.tR_KladrObj AS clSity ON clSity.Id = clStreet.KladrObjId
  left join dbo.tR_KladrObj AS clSity1 ON clSity1.Id = clSity.ParentId
  left join dbo.tR_KladrDoma AS clDoma ON clDoma.StreetId = clStreet.id
