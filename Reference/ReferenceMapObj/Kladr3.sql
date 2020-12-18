select distinct  r.StreetId, r.GNINMB, stuff(( select  ',' + t.name from dbo.tR_KladrDoma t where t.StreetId = r.StreetId for xml path('')),1,1,'')
from dbo.tR_KladrDoma  r