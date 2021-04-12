/*

Плановые работы которые в таблице отправленных данных [tJ_RequestForRepairSendCMR]
не обработаны (не присвоены статусы отправки, окончания работ или уддаления)


*/

SELECT send.*, daily.*, dok.status, dok.deleted,rLog.Command as SiteStatus
  FROM [GES].[dbo].[tJ_RequestForRepairSendCMR] send
		left join [dbo].[tJ_RequestForRepairDaily] daily on daily.id = send.[idDaily]
		left join [dbo].[tJ_RequestForRepair] dok on dok.id = daily.idRequest
		left join tJ_RequestForRepairLog rLog on rLog.id = (select top 1 id 
															from  tJ_RequestForRepairLog
															where idRequest = dok.id and isSite = 1
															order by datelog desc, id desc)
		
			where send.deleted = 0 and send.dateFactEnd is null
 -- where [idDaily] not in 
 --(92744,93379,92743,93389,93390,93388,93292,92687)


 --ORDER by daily.dateBeg

