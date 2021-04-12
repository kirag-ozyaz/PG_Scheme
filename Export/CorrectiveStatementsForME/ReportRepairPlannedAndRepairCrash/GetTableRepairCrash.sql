/*


Документы по аварийному ремонту

(все подряд даже не зарегистрированные)

*/
--declare  @dateBegin datetime;
--declare @dateEnd datetime;
--set @dateBegin = '2021-03-01 00:00:00';
--set @dateEnd = '2021-03-31 23:59:59';

select * from vJ_RequestForRepairDaily
where  
		(dateFactEnd is null or --(dateFactEnd >= @dateBegin and dateFactEnd <= @dateEnd)
		((@dateBegin is null or (dateFactEnd >= @dateBegin)) 
		and (@dateEnd is null or (dateFactEnd <= @dateEnd)))
) 
and (idDivision =920) 
and  deleted = 0  and sendSite = 1 and crash = 1 and agreed = 1 
and Left(reguestFiled,5) <> '*****'
order by sr, id desc, datetripBeg
