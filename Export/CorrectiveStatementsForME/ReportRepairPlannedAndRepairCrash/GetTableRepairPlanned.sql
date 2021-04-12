/*

документы по плановому ремонту

(все подряд, даже не зарегестрированные)
*/
--declare  @dateBegin datetime;
--declare @dateEnd datetime;
--set @dateBegin = '2021-03-04 00:00:00';
--set @dateEnd = '2021-03-31 23:59:59';

select * from vJ_RequestForRepairDaily
where  
				 (
				    ((@dateBegin is null or (dateTripBeg >= @dateBegin)) and (@dateEnd is null or (datetripBeg <= @dateEnd))) 
				 or ((@dateBegin is null or (datetripEnd >= @dateBegin)) and (@dateEnd is null or (datetripEnd <= @dateEnd)))
				 or ((@dateBegin is null or (datetripBeg <= @dateBegin)) and (@dateEnd is null or (dateTRipEnd >= @dateEnd)))
				 ) 
and (idDivision =920) 
and  deleted = 0  and (crash = 0 or crash is null) 
and Left(reguestFiled,5) <> '*****'
order by sr, id, datetripBeg

