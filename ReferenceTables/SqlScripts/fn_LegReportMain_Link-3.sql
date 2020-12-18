USE [GES]
GO

/****** Object:  UserDefinedFunction [dbo].[fn_LegReportMain_Link-3]    Script Date: 28.06.2020 23:26:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



/*

Эту версию не трогать
- добавил дату установки трансформатора и счетчика
*/




CREATE FUNCTION [dbo].[fn_LegReportMain_Link-3]
(	
	@DateBegin DATETIME, @DateEnd DATETIME
)
RETURNS
 --declare 
 @tbl TABLE(
	CodeAbonent INT, 
	Name VARCHAR(100), 
	idAbnObj INT, 
	ObjName VARCHAR(255),
	dtPay DATETIME, 
	Quantity INT, 
	idSchmObj INT,
	ValueKWT INT,
	SizeKWT INT,
	NumberMeter VARCHAR(255),
	MeterType VARCHAR(255),
	MeterDataBegin DATETIME,
	Location VARCHAR(255),
	PointName VARCHAR(255)
	, ObjParentName  VARCHAR(255)
	, TypeAct VARCHAR(255)
	, PointID INT
	, TypeAbn VARCHAR(100)
    , CheckMr smalldatetime
    , CheckIntervalMr tinyint
  --  , CheckTr smalldatetime
  		,NameTrans VARCHAR(50)
		,TypeTrans VARCHAR(50)
		,DateBeginTrans smalldatetime
		,DateCheckTrans smalldatetime
		,IntervalTrans tinyint
)		
AS
BEGIN

--declare @DateBegin DATETIME, @DateEnd DATETIME
--set @DateBegin = '20200101'
--set @DateEnd = '20200131'

set @dateBegin = dateadd( day, - datepart(day, @DateBegin) + 1, convert(datetime, @DateBegin))
set @dateEnd = dateadd( day, -1, dateadd( month, 1, dateadd( day, 1-datepart( day, @DateEnd ), @DateEnd )));

declare @monthbeg int, @monthend int
set @monthbeg = year(@DateBegin) * 100 + month(@DateBegin)
set @monthend = year(@DateEnd) * 100 + month(@DateEnd)	
-- соберем дипозон месяцев

declare 
 @tblDay TABLE([Day] int)

DECLARE @number INT
set @number = datediff(mm, @DateBegin, @DateEnd)+1
declare @DateLoop DATETIME set @DateLoop = @DateBegin
WHILE @number > 0
    BEGIN
        insert  into @tblDay([Day]) values (100 * Year(@DateLoop) + Month(@DateLoop))
        SET @number = @number - 1
		set @DateLoop = DateAdd(mm, 1, @DateLoop)
    END;
--select * from @tblDay order by [Day]

-- legal
	INSERT @tbl 
	SELECT DISTINCT
		a.CodeAbonent, 
		replace(replace(a.Name, char(10), ' '), char(13), ' ') AS Name, 
		ds.idAbnObj,
		replace(replace(obj.Name, char(10), ' '), char(13), ' ') AS ObjName,
		dateadd( day, -1, dateadd( month, 1, dateadd( day, 1-datepart( day, convert(datetime, Cast(d.dtPay as varchar)) ), convert(datetime, Cast(d.dtPay as varchar)) ))), --d.dtPay, 
		ds.Quantity, 
		vals.idSchmObj,
		vals.ValueKWT,
		vals.SizeKWT,-- показания приборов
		vals.Number,
		vals.[MeterType],
		vals.DateBegin [MeterDataBegin],
		replace(replace(vals.Location, char(10), ' '), char(13), ' ') as Location,
		replace(replace(vals.[PointName], char(10), ' '), char(13), ' ') as PointName,
		replace(replace(objParent.Name, char(10), ' '), char(13), ' ') as objParentName
		,vals.TypeAct
		,vals.PointID
		,clTypeAbn.Name as TypeAbn
        ,vals.DateCheck
        ,vals.Interval
        --,'19990101'
		,vals.NameTrans, vals.TypeTrans, vals.[DateBeginTrans], vals.DateCheckTrans, vals.IntervalTrans
	FROM
		tAbnDoc_List dl 
		LEFT JOIN tAbn a ON dl.idAbn = a.id

-- ГФФ
-- вместо первых двух строчек вставить
--tAbn abn
--	LEFT JOIN tAbnDoc_List lst ON lst.idAbn = abn.id
--	LEFT JOIN tAbnDoc_Dogovor dog ON dog.idList = lst.id
--	LEFT JOIN tG_Dog_Obj obj ON obj.idDog = dog.id
		
		
		LEFT JOIN tG_Doc d ON dl.id = d.idDogovor 
		LEFT JOIN tG_DocSchet ds ON d.id = ds.idDoc 
		LEFT JOIN tAbnObj obj ON obj.id = ds.idAbnObj
		LEFT JOIN tAbnObj objParent ON objParent.id = obj.IdObjParent
		LEFT JOIN tR_Classifier AS clTypeAbn ON a.TypeAbn = clTypeAbn.Id
		Left join (select meterALL.PointID, meterALL.idAbnObj, meterALL.idSchmObj , meterALL.Number, meterALL.MeterType, meterALL.Location, meterALL.PointName, isnull(valMeter.DateAct,@DateBegin) DateAct, valMeter.Name TypeAct, valMeter.ValueKWT, valMeter.SizeKWT 
                         , meterALL.DateCheck , meterAll.Interval, meterAll.NameTrans, meterAll.TypeTrans, meterAll.DateCheckTrans, meterall.[DateBeginTrans], meterAll.IntervalTrans, meterAll.DateBegin
			from 
				(SELECT   idAbnObj, PointID, MeterID, IdZone, DateAct, Name, ValueKWT, SizeKWT
                  FROM            vG_MeterValAll
                 WHERE        (DateAct BETWEEN @DateBegin AND @DateEnd)) AS valMeter -- объемы по прибору учета
				 
				 FULL OUTER JOIN
                         
						 (select  meter.PointID, isnull(link2.idSchmObj,0) idSchmObj ,meter.Number,meter.[MeterType],meter.Location,meter.[PointName], meter.IDZone, rowid1, rowid2, isnull(meter.idAbnObj, link2.idAbnObj) idAbnObj
								 ,meter.DateCheck,meter.Interval, meter.NameTrans, meter.TypeTrans, meter.DateCheckTrans, meter.[DateBeginTrans], meter.IntervalTrans, meter.DateBegin
                                  from
									(select row_number() over (partition by idAbnObj order by idSchmObj) as rowid1, tL_SchmAbn.*
									from tL_SchmAbn -- привязка к схеме
										left join tAbn on tAbn.id = tL_SchmAbn.idAbn
										where tAbn.typeAbn in (207,230,231)
									) link2 
									full outer join 
									(select row_number() over (partition by mt.idAbnObj order by mt.DateBegin desc, mt.PointID) as rowid2, mt.*, tr.*
									from vG_ObjMeter mt-- характеристики приборов учета
													left join (select pr.idPoint ,t.Name NameTrans, cl.Name as TypeTrans, convert(varchar(10), pr.DateCheck, 102) [DateCheckTrans],convert(varchar(10), pr.DateBegin, 102) [DateBeginTrans],  t.Interval [IntervalTrans] 
																from tPointReg pr
																	left join tR_MarkTrans t ON pr.idMark = t.id
																	left join tR_Classifier cl ON t.TypeTrans = cl.id
																	where pr.DateEnd IS NULL 
																	and pr.Type in (246, 1310)
																	and not cl.Name is null) tr on tr.idPoint = mt.PointId
																where mt.Number is not null 
									) meter
									on link2.idAbnObj = meter.idAbnObj and link2.rowid1 = meter.rowid2 
	
						) meterALL on valMeter.idAbnObj = meterALL.idAbnObj and meterALL.PointID = valMeter.PointID and valMeter.IDZone = meterALL.IDZone) vals on vals.idAbnObj = obj.id
								and (Year(vals.dateact) = Year(d.dtPay) and Month(vals.dateact) = Month(d.dtPay))

	WHERE (d.dtPay between @DateBegin and @DateEnd) 
		-- and (ds.Summa <> 0) 
		and (dl.idDocType = 501 or dl.idDocType = 533) 
		--and (ds.Summa is not null) 
-- ГФФ		
--  можно убрать	если нужны ДНУ	
--		and (d.Blocking <> 0) --убрал
and ds.idAbnObj is not null -- добавил, если объекто нет, то не выводим абонента
		
		
		and (a.codeabonent not in (9028,460)) and ((d.NumberStorno IS NULL) OR (d.NumberStorno = 0))
--		and link2.idSchmObj is not null and link2.SubID is not null
--		если включаем данный параметр, то остаются только расчеты по счетчикам
--		and (dateact between @DateBegin and @DateEnd)

-- ГФФ
-- фильтр чтобы оставить только активных абонентов
--(abn.Deleted = 0) and (lst.isActive <> 0) AND (lst.Deleted = 0)
--	AND (dog.FlagBreak = 0) AND (obj.DateEnd IS NULL) AND (pr.id IS NOT NULL)


	order by codeabonent

-- prv
INSERT @tbl 
select 
		valMeter.CodeAbonent, 
		replace(valMeter.Name,';','') as AbnName, 
		valMeter.idAbnObj,
		replace(replace(replace(valMeter.AbnObjName, char(10), ' '), char(13), ' '),';','') as AbnObjName,
		dateadd( day, -1, dateadd( month, 1, dateadd( day, 1-datepart( day, convert(datetime, Cast(valMeter.dtPay as varchar)+'01') ), convert(datetime, Cast(valMeter.dtPay as varchar)+'01') ))) as dtPay,
		valMeter.Quantity, -- 0, -- общая сумма пообъекту
		link3.idSchmObj,
		0, -- показания прибора учета
		valMeter.Quantity,--возьмем сумму по УЭ --valMeter.ValueKWT,
		replace(replace(valMeter.Number, char(10), ' '), char(13), ' ') as Number,
		replace(replace(valMeter.[MeterType], char(10), ' '), char(13), ' ') as [MeterType],
		valMeter.MeterDataBegin [MeterDataBegin] ,
		replace(replace(valMeter.Location, char(10), ' '), char(13), ' ') as Location,
		replace(replace(valMeter.[PointName], char(10), ' '), char(13), ' ') as PointName,
		null
		,null
		,valMeter.PointID
		,valMeter.TypeName as TypeAbn
        ,valMeter.DateCheckMr
        ,valMeter.IntervalMr
        --,valMeter.DateCheckTr
		, valMeter.NameTrans, valMeter.TypeTrans,  valMeter.DateBeginTrans, valMeter.DateCheckTrans, valMeter.IntervalTrans
       
from 
(select row_number() over (partition by obj.id order by abn.id, obj.id) as rowid2, abn.CodeAbonent, abn.id idAbn,
		rtrim (abn.Name ) [Name],
		obj.id [idAbnObj],
		rtrim( case when kladrobj.id = 24 then '' else kladrobj. name + ' ' + isnull (kladrobj.socr , '') + ' ' end + 
				isnull (street.name ,'') + 
				case when street.socr is null then '' else ' ' + street.socr end + 
				case when map.house is null then '' else '.' + rtrim ( ltrim (str ( map.house ))) + isnull (map.houseprefix , '' ) end + 
				case when obj.name is null or obj.name = '' then '' else + '.' + obj.name end) AbnObjName, -- [Adress] , 
		--obj.Name [AbnObjName] ,
		debUE.MonthDeb [dtPay] ,
		sum ( isnull (debUE.Itog ,0 )) [Quantity] --as DedUE
		, sum ( debUE.ItogUl ) [ValueKWT] --as DedUl
		, p.Number
		, p.counterName [MeterType]
		, p.MeterDataBegin
		, p.LocationName [Location]
		, p.Name [PointName]
		, p.id [PointID]
		, abn.TypeName
        , p.DateCheckMr
        , p.IntervalMr
       -- , p.DateCheckTr
	   ,tr.NameTrans, tr.TypeTrans, tr.DateCheckTrans, tr.DateBeginTrans, tr.IntervalTrans
from vPointRegLast p --tPoint p
	left join tAbnObj obj on p.idAbnObj = obj.id
	left join vAbn abn on obj.idAbn = abn.id
	left join tAbnStatus status ON status.id =
			(SELECT TOP (1 ) id 
				FROM dbo.tAbnStatus 
				WHERE (idAbn = abn.id ) 
			ORDER BY DateChange DESC ) 
	left join tMapObj map on map. idmap = obj.idmap
	left join tR_kladrStreet street on street. id = map.street
	left join tr_kladrObj kladrObj on kladrobj. id = street.kladrobjid 
	left join ( select ue.idPoint , ue.MonthDeb , sum (ue.[Itog] ) as Itog , sum (ul.KWT ) as ItogUl
					from tPrv_DebitorkaUE ue
					left join tPrv_Debitorka ul on ul.idPoint = ue.idPoint and ul.MonthRasch = ue.MonthDeb and ul.Ok =1
					where ue.MonthDeb >= @MonthBeg and ue.MonthDeb <= @MonthEnd 
					group by ue.idPoint ,ue.MonthDeb ,ul.IndicatorOpl , ul.IndicatorKO
				) debUE on debUE.idPoint =p.id -- объемы по прибору учета
			/*трансформаторы*/
	left join (select pr.idPoint ,t.Name NameTrans, cl.Name as TypeTrans, convert(varchar(10), pr.DateCheck, 102) [DateCheckTrans], convert(varchar(10), pr.DateBegin, 102) [DateBeginTrans], t.Interval [IntervalTrans] 
																from tPointReg pr
																left join tR_MarkTrans t ON pr.idMark = t.id
																left join tR_Classifier cl ON t.TypeTrans = cl.id
																where pr.DateEnd IS NULL 
																and pr.Type in (246, 1310)
																and not cl.Name is null) tr on tr.idPoint = p.id
where abn.typeAbn = 206
	and ( abn.isActive = 1 or ( abn.isActive = 0 and abn.DateChange > @DateEnd )) 
	-- and (debUl.KWT is null) 
	and MonthDeb is not null
	--and CodeAbonent = 100430
group by obj.id , debUE.MonthDeb ,
		abn.CodeAbonent , abn.id, abn. Name ,kladrobj.id ,kladrobj.name ,kladrobj.socr ,street.name ,street.socr ,map.house ,map.houseprefix ,obj.name 
		, p.counterName, p.Number, p.MeterDataBegin, p.LocationName , p. Name , p.id , abn.TypeName , p.DateCheckMr , p.DateCheckTr ,p.IntervalMr,tr.NameTrans, tr.TypeTrans, tr.DateCheckTrans, tr.DateBeginTrans, tr.IntervalTrans
)  valMeter 
full outer join --right join
(select row_number() over (partition by idAbnObj order by idAbn, idAbnObj, idSchmObj) as rowid1, tL_SchmAbn.*, ddd.[Day]
from tL_SchmAbn -- привязка к схеме
	left join vAbn abn on abn.id = tL_SchmAbn.idAbn
	cross join  @tblDay ddd
	where abn.typeAbn = 206 and ( abn.isActive = 1 or ( abn.isActive = 0 and abn.DateChange > @DateEnd ))		
) link3 
on link3.idAbn = valMeter.idAbn and link3.idAbnObj = valMeter.idAbnObj and (link3.[Day] = valmeter.[dtPay]) 
-- у физиков не попадают активные абоненты укоторых нет объемов
-- outer
 where CodeAbonent is not null

--select * from @tbl 

RETURN
END


GO


