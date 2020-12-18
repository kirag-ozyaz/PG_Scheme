------ ПОКА ПРАВЫЙ БЕРЕГ --------

declare @CodeAbn     int
declare @idAbn		 int
declare @typeAbn     int

set @typeAbn = 206   /* Потребители ФЛ */

set @codeAbn = 612110--7091610--419000091--100100  /* Код абоента*/


-- tAbn
-- сначала удаляем
delete tAbn
where codeABonent = @codeAbn and typeAbn = @typeAbn
-- Добавляем в tAbn
insert into tAbn (codeAbonent, [name], TypeAbn, idWorker, deleted)
(
select codeabonent,
		fio,
		@typeAbn,
		isnull(c.ges, 0),
		0
from PrvDB.dbo.tAbonent abn
	left join _tPrvControler c on c.PrvDB = abn.codecontroller
where abn.codeabonent = @codeAbn
)
select @idAbn=IDENT_CURRENT('tAbn')

-- tAbnStatus --
insert into tAbnStatus(idAbn, isActive, DateChange)
(
select @idAbn, 1, StartDate
from PrvDB.dbo.tAbonent abn
where abn.codeabonent = @codeAbn
)
if ((select top 1 notactiv from PrvDB.dbo.tAbonent abn where abn.codeabonent = @codeAbn) = 1)  -- ЕСЛИ НЕАКТИВНЫЙ
begin
insert into tAbnStatus(idAbn, isActive, idReason,DateChange)
(
select @idAbn, 0, 
		r.ges,
		DateClose
from PrvDB.dbo.tAbonent abn
	left join _tPrvNaReason r on r.PrvDB = abn.codeNaReason
where abn.codeabonent = @codeAbn
)
end

--- tAbnContact ---
insert into tAbnContact (idAbn, F, Phone, DateChange)
(	select @idAbn,
			fio, tel, 
			startDate
	from PrvDB.dbo.tAbonent abn
	where abn.codeabonent = @codeAbn
)

------------------------------------ Объект --------------------------------------------
--- Улица ---
declare @codeStreet int
if (select top 1 g.ges from PrvDB.dbo.tAbonent p left join _tprvStreet g on g.prvdb = p.codestreet
	where p.codeabonent = @codeAbn) is null
begin
	declare @tmp varchar(100)
	select @tmp = s.name + ' ' + isnull(s.prefix, '') + '   '  + str(a.codestreet)
	from PrvDB.dbo.tAbonent a
		left join PrvDB.dbo.tStreet s on s.codestreet = a.codestreet
	where a.codeabonent = @codeabn
	print ' Не найдена улица ' + @tmp
	return
end
else
begin
	select @codeStreet = g.ges from PrvDB.dbo.tAbonent p left join _tprvStreet g on g.prvdb = p.codestreet
		where p.codeabonent = @codeAbn
end
--P.S. --- Нашли улицу ----

declare @house int
declare @houseprefix varchar(20)

select @housePrefix = house from PrvDB.dbo.tAbonent where codeabonent = @codeAbn
select @house = PrvDB.dbo.GetInt(@housePrefix)
select @housePrefix = substring(@housePrefix, len(ltrim(rtrim(str(@house))))+1, len(@housePrefix)-len(ltrim(rtrim(str(@house)))))
---- Теперь надо найти дом, tMapObj
declare @idMap int

if (len(@housePrefix) <= 0)
	select @idMap = idMap
	from tMapObj
	where street = @codeStreet and house = @house
			and housePrefix is null and ishouse = 1 and [name] is null
else
	select @idMap = idMap 
	from tMapObj
	where street = @codeStreet and house = @house
			and housePrefix = @housePrefix and ishouse = 1 and [name] is null

if (@idMap is null) -- НЕ НАШЛИ ДОМ
begin 
	if (len(@housePrefix) <= 0) set @houseprefix = null

	insert into tMapObj (street, house, houseprefix, ishouse, deleted)
	values (@codestreet, @house, @housePrefix, 1, 0)

	select @idMap = IDENT_CURRENT('tMapObj')
end
----- P.S. Получили idMap -------
---- ОБЪЕКТ -----
insert into tAbnObj (idAbn, idMap, [Name])
(select @idAbn, @idMap, Apartment
from PrvDB.dbo.tAbonent where codeabonent = @codeAbn)

declare @idAbnObj int
select @idAbnObj = IDENT_CURRENT('tAbnObj')

insert into tAbnObjReg(idAbn, idAbnObj, CountRooms, CountPeoples, [Square], idAbnNet, idAbnSale, DateChange)
(select @idAbn, @idAbnObj, QRooms, QPeoples, round([Square],2), 220859, 23269, startDate
  from PrvDB.dbo.tAbonent
  where codeabonent = @codeAbn)


--------- tPoint ---------------
declare @placePoint int

set @placePoint =(select top 1  case place when  1 then  265 
		                                   when  2 then  266 
		                              else           
		                           null end 
from prvdb.dbo.tAbonentMeter
where codeabonent = @codeAbn
order by datebegin desc)

insert into tPoint(idAbnObj, idLocation, idTension, DateBegin)
values (@idAbnObj, @placePoint, 229, '20000101')

declare @idPoint int
select @idPoint = IDENT_CURRENT('tPoint')


------- tPointReg --------------
declare @Type int
        ,@SetDate smalldatetime
        ,@EndDate smalldateTime
		,@lastCAlc int
declare --@date smalldatetime,
        @RC int,
        @i int
declare cAbonentCalc cursor local scroll for
select Type, SetDate, EndDate 
from PrvDb.dbo.tAbonentCalc
where CodeAbonent = @CodeAbn 
order by SetDate asc
BEGIN
open cAbonentCalc
  set @RC=@@cursor_rows
  set @i=1

  begin tran
	set @lastCalc = 0
    while @i<=@RC begin
    fetch absolute @i from cAbonentCalc into @Type,@SetDate,@EndDate
    

	select top 1 @endDate = SetDate
	from prvdb.dbo.TabonentCAlc
	where codeabonent = @codeAbn and setdate > @setDate
	order by setdate asc
    
    IF @Type=0  --НОРМА
              Begin
              INSERT INTO [tPointReg]([IdPoint], [DateBegin],[DateEnd],[Type])
              VALUES (@idPoint, @SetDate, @EndDate, 248)
              End
    IF @Type=1 -- СЧЕТЧИК
              Begin
				if (@lastCalc = 0)
				begin
					insert into tpointreg(idpoint, datebegin, dateend, type, idmark, datemade, datecheck, number)
					(select @idPoint, @SetDate, case when isnull(DateEnd,getdate()) > @EndDate then @endDate
										else DateEnd end,
						245,
						m.ges, abnm.datemake, abnm.checkdate, abnm.number
					 from PrvDB.dbo.tAbonentMeter abnm
						left join _tprvmarkmeter m on m.prvdb = abnm.codemeter
						where codeabonentmeter = (select top 1 codeabonentmeter 
												  from PrvDB.dbo.tAbonentMeter 
						   					      where CodeAbonent=@CodeAbn and isnull(DateEnd,getdate())>=@SetDate 
                                            			 and ((not DateEnd is null) or (select count(*) from PrvDB.dbo.tAbonentMeter
												  									    where CodeAbonent=@CodeAbn and DateBegin >= @SetDate
																		                and DateBegin <=  isnull(@EndDate,convert(smalldatetime,convert(varchar(8),getdate(),112)))) <= 0)
														and DateBegin < @SetDate
					order by DateBegin Desc))
				end
				
				insert into tpointreg(idpoint, datebegin, dateend, type, idmark, datemade, datecheck, number)
				(select @idPoint, DateBegin, case when isnull(DateEnd,getdate()) > @EndDate then @endDate
										else DateEnd end ,
											245,
						m.ges, abnm.datemake, abnm.checkdate, abnm.number
				from PrvDB.dbo.tAbonentMeter abnm
					left join _tprvmarkmeter m on m.prvdb = abnm.codemeter
				where CodeAbonent=@CodeAbn and DateBegin >= @SetDate
											 and DateBegin <=  isnull(@EndDate,convert(smalldatetime,convert(varchar(8),getdate(),112)))
			    /*order by DateBegin asc*/)
              End
	set @lastCalc = @Type

     if @@error<>0 begin
        print 'Случился какой-то 3.14дец!'
        rollback tran
        goto quit
      end
      set @i=@i+1
    end --while
  commit tran
quit:
close cAbonentCalc
deallocate cAbonentCalc
END


---------------- tDocAct -----------------
insert into tDocAct (idPoint, idDocType, valuekwt, sizekwt, valuemoney, datein, dateact, idworker)
(select @idpoint, _r.ges, r.indicator, r.[size], r.sum_, r.datepay, r.monthpay, c.ges
from PrvDB.dbo.tReceipt r
	left join _tprvreceipt _r on _r.prv = r.codetypepay
	left join _tprvcontroler c on c.prvdb = r.codecontroller
where CodeABonent = @codeabn and codetypepay in (16,17,24,25,35,38,42,43,44,45,47,48,49))

---------------- tDocOpl -------------------
insert into tDocOpl (idPoint, idDocType, valuekwt, sizekwt, valuemoney, datein, dateopl)
(select @idpoint, _r.ges, r.indicator, r.[size], r.sum_, r.datepay, r.monthpay
from PrvDB.dbo.tReceipt r
	left join _tprvreceipt _r on _r.prv = r.codetypepay
where CodeABonent = @codeabn and codetypepay in (3,15,41))
