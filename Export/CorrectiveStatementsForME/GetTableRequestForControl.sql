-- Запрос проверки плановых работ - есть ли данные простым запросом, чтобы не запускать тяжелый
SELECT doc.isSendSiteMe, doc.sendSite
  FROM [GES].[dbo].[tJ_RequestForRepair] doc
  left join [GES].[dbo].[tJ_RequestForRepairDaily] daily on daily.[idRequest] = doc.id
where doc.deleted = 0 and doc.sendSite = 1
	and (doc.Crash = 0  or doc.crash is null)
	and (Year(daily.dateBeg) >= 2019 or Year(daily.dateEnd) >= 2019) 
	and doc.iddivision = 920
			and ((@Month is null and @Year is null) or
			(@Month = Month(daily.dateBeg) and @Year = Year(daily.dateBeg)) or
			(@Month = Month(daily.dateEnd) and @Year = Year(daily.dateEnd))
			)