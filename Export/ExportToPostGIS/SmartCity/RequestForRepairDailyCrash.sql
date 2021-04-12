/*
Документы по аварийному ремонту

для выгрузки в центр управления городом
- добавил поле idCMR - идентификатор возвращаемый от создаваемой заявки (отключения) на определенный временной промежуток
*/
--declare  @dateBegin datetime;
--declare @dateEnd datetime;
--declare @idDivision int;
--declare @DateStartShedule datetime;
--set @idDivision = 920;
--set @dateBegin = '2021-03-04 00:00:00';
--set @dateEnd = '2021-03-31 23:59:59';
--set @DateStartShedule = '2021-04-01 00:00:00';

SELECT   
		   Case 
				When (crash = 0 or crash is null) and j.IsPlanned = 1 Then 'ПР'
				When (crash = 0 or crash is null) and j.IsPlanned = 0 Then 'CР'
				When (sendSite = 1 and crash = 1 and agreed = 1) Then 'В1'
		   End TypeWorks,
		   j.id, j.num, j.dateCreate, 
		   j.idWorker, w.FIO AS workerCreate, 
		   j.reguestFiled, j.idSR, 
		   sr.Name AS SR, j.schmObj, j.Purpose, j.IsPlanned, 
		   rBeg.dateBeg AS dateTripBeg, 
		   rBeg.dateEnd AS dateTripEnd, 
		   rBeg.id as idDaily, -- RequestForRepairDaily
		   rBeg.idCMR, -- значение события из ЦУГ
		   j.AgreeWith, j.Comment, j.Address, j.Agreed, j.DateAgreed, j.WorkerAgreed, wAgreed.FIO, j.Crash,
		   j.iddivision, division.Name AS division, 
           j.idUserCreate, u.Name AS username, j.deleted, j.dateFactEnd, 
		   j.SendSite, 
		   rLog.Command as SiteStatus
		   , j.CommentXML
FROM         dbo.tJ_RequestForRepair AS j 
		LEFT JOIN  dbo.vR_Worker AS w ON w.id = j.idWorker LEFT OUTER JOIN
                      dbo.tR_Classifier AS sr ON sr.Id = j.idSR LEFT OUTER JOIN
                      dbo.vR_Worker AS wAgreed ON wAgreed.id = j.WorkerAgreed LEFT OUTER JOIN
                      dbo.tR_Classifier AS division ON division.Id = j.iddivision LEFT OUTER JOIN
                      dbo.tUser AS u ON u.IDUser = j.idUserCreate 
		LEFT JOIN dbo.tJ_RequestForRepairDaily AS rBeg ON rBeg.idRequest = j.id
		left join tJ_RequestForRepairLog rLog on rLog.id = (select top 1 id 
															from  tJ_RequestForRepairLog
															where idRequest = j.id and isSite = 1
															order by datelog desc, id desc)
where (@idDivision is null or j.idDivision = @idDivision)
 and  j.deleted = 0  and sendSite = 1 and crash = 1 and agreed = 1 -- Документы по аварийному ремонту
and (dateFactEnd is null or --(dateFactEnd >= @dateBegin and dateFactEnd <= @dateEnd)
		((@dateBegin is null or (dateFactEnd >= @dateBegin)) 
		and (@dateEnd is null or (dateFactEnd <= @dateEnd)))
) 
and Left(reguestFiled,5) <> '*****'

--order by id desc

--select * from [dbo].[tJ_RequestForRepairAddress] where idRequest = 103123


