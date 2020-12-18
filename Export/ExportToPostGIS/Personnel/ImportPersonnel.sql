USE [GES]
GO

/****** Object:  StoredProcedure [dbo].[ImportPersonnel]    Script Date: 10.02.2020 15:31:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--------    Импорт кадров из 1с
--------    tR_Division         tR_DivisionTemp
--------    tR_JobTitle         tR_JobTitleTemp
--------    tR_Worker           tR_WorkerTemp 
--------    tR_WorkerContact    tR_WorkerContactTemp
--------    tJ_StatusWorker     tJ_StatusWorkerTemp

CREATE PROCEDURE [dbo].[ImportPersonnel]
AS

BEGIN

declare @Code nchar(9),
		@ParentCode nchar(9),
	    @Description varchar(100),
        @ParentDescription varchar(100),
		@Deleted bit,
		@RName varchar(10),
		@Razrjad int,
		@F varchar(30),
		@I varchar(20),
		@O varchar(20),
		@Birthday datetime,
		@Division int,
		@DivisionCurrent int,
		@JobTitle int,
		@DateBegin datetime,
		@DateEnd datetime,
		@CodeFL nchar(10),
		@id int,
		@Flag int,
		@INN varchar(12)	

--------------- подразделения -----------------------
--update tR_Division set Flag = 0
--
--declare curDivision cursor local scroll for
--select Code, ParentCode, ParentDescription, [Description], Deleted
--from tR_DivisionTemp
--where Deleted = 0 
--
--open curDivision
--
--while (1 = 1)
--begin
--	fetch next from curDivision
--	into @Code, @ParentCode, @ParentDescription, @Description, @Deleted
--
--	if @@fetch_status = -1
--		break
--	if @@fetch_status <> 0
--		continue
--
--	set @id = Null
--
--	select top 1 @id = id
--	from tR_Division
--	where Code = @Code and ParentCode = @ParentCode and Flag = 0
----	where [Description] = @Description and Flag = 0
--
--	if (@id is not null) 
--	begin
--		update dbo.tR_Division
--		set Code = @Code, ParentCode = @ParentCode, ParentDescription = @ParentDescription, Deleted = @Deleted, Flag = 1
--		where id = @id
--	end
--	else 
--	begin
--		insert into dbo.tR_Division (Code, [Description], ParentCode, ParentDescription, Deleted, Flag, IDRRef, ParentIDRRef) values (@Code, @Description, @ParentCode, @ParentDescription, @Deleted, 1, 0, 0)
--	end
--end
--close curDivision
--deallocate curDivision
--
----update tR_Division
----set ParentID = (select id from tR_Division where [Description] = d.ParentDescription) 
----from tR_Division d
--
--END
-------------  должности -------------------------------

update tR_JobTitle set Flag = 0

declare curJob cursor local scroll for
select Code, [Description], RName, Razrjad, Deleted
from tR_JobTitleTemp
where Left(Code,2) <> 'ГС'

open curJob

while (1 = 1)
begin
	fetch next from curJob
	into @Code, @Description, @RName, @Razrjad, @Deleted

	if @@fetch_status = -1
		break
	if @@fetch_status <> 0
		continue

	set @id = Null

	select top 1 @id = id
	from tR_JobTitle
	where Code = @Code

	if (@id is null) 
	begin
		insert into dbo.tR_JobTitle (Code, [Description], RName, Razrjad, Deleted, Flag, IDRRef) values (@Code, @Description, @RName, @Razrjad, @Deleted, 1, 0)
	end
end
close curJob
deallocate curJob
--
-------------------------------- работники -------------------

declare curWorker cursor local scroll for
select w.Code, 
Upper(substring(w.F,1,1))+Lower(substring(w.F,2,100)) as F,
Upper(substring(w.I,1,1))+Lower(substring(w.I,2,100)) as I,
Upper(substring(w.O,1,1))+Lower(substring(w.O,2,100)) as O,
w.Birthday, d.id as Division, dc.id as DivisionCurrent, jt.id, w.DateBegin, w.DateEnd, w.INN
from tR_WorkerTemp w
	left join tR_Division d on w.Division = d.Code
	left join tR_Division dc on w.DivisionCurrent = dc.Code
	left join tR_JobTitle jt on REPLICATE('0', 9-LEN(w.JobTitle)) + w.JobTitle = jt.Code and Left(jt.Code,2) <> 'ГС'
where (Birthday is not null) and (I is not null) and (DateBegin is not null)  

open curWorker

while (1 = 1)
begin
	fetch next from curWorker
	into @CodeFL, @F, @I, @O, @Birthday, @Division, @DivisionCurrent, @JobTitle, @DateBegin, @DateEnd, @INN

	if @@fetch_status = -1
		break
	if @@fetch_status <> 0
		continue
	
	if @DateEnd > GetDate()
		set @DateEnd = Null

	set @id = Null

	select top 1 @id = id
	from tR_Worker
	where ltrim(rtrim(F)) = ltrim(rtrim(@F)) and Birthday = @Birthday and DateBegin = @DateBegin

	if (@id is not null) 
	begin
		update dbo.tR_Worker
		set Code = @CodeFL, F = @F, Division = @Division, DivisionCurrent = @DivisionCurrent, JobTitle = @JobTitle, DateEnd = @DateEnd, INN = @INN
		where id = @id
	end
	else 
	begin
		insert into dbo.tR_Worker (Code, F, I, O, Birthday, Division, DivisionCurrent, JobTitle, DateBegin, DateEnd, INN, IDRRef) 
			values (@CodeFL, @F, @I, @O, @Birthday, @Division, @DivisionCurrent, @JobTitle, @DateBegin, @DateEnd, @INN, 0)
	end
end

------------------------------ контакты ------------------------------------------------
--
declare @t table (id int, worker int,  [description] varchar(100), [type] int, kadrexport bit, comment varchar, GUID varchar)
insert into @t(id, worker, [description], type, kadrexport, comment, GUID)
(select *
from tR_WorkerContact
where kadrexport = 0)

delete tR_WorkerContact

DBCC CHECKIDENT (tR_WorkerContact, RESEED, 0)  

insert into tR_WorkerContact(worker, [description], [type], kadrexport, comment)
(select worker, description, type, kadrexport, comment
from @t)

insert into tR_WorkerContact(Worker, [Description], KadrExport, [Type], Comment)
(select w.id, wc.[Description], 1,
	case 
		when [CodeType] = 1 then 38 -- Адрес для информирования физ. лица
		when [CodeType] = 2 then 39 -- Адрес по прописке физ. лица
		when [CodeType] = 3 then 40 -- Адрес проживания физ. лица
		when [CodeType] = 4 then 41 -- Адрес физ. лица за пределами РФ 
		when [CodeType] = 7 then 49 -- Телефон физ. лица
		when [CodeType] = 8 then 42 -- контакт. телефон
		when [CodeType] = 9 then 54 -- юр.адр.орг.
		when [CodeType] = 10 then 45 -- тел.орг.
		when [CodeType] = 11 then 53 -- факт.адр.орг.
		when [CodeType] = 12 then 44 -- электр.почта
		when [CodeType] = 13 then 43 -- почт.адр.орг.
		when [CodeType] = 14 then 51 -- факс орг.
		when [CodeType] = 15 then 50 -- учр.адр.ин.орг.
		when [CodeType] = 18 then 52 -- факт.адр.контр.
		when [CodeType] = 20 then 46 -- тел.служ.
		when [CodeType] = 21 then 47 -- тел.служ. 2
		when [CodeType] = 22 then 46 -- тел.служ. на подр.
		when [CodeType] = 23 then 47 -- тел.служ. на подр.2
		when [CodeType] = 24 then 48 -- тел.служ. на подр.3
		when [CodeType] = 25 then 38 -- адрес для информ.физ.лица
		when [CodeType] = 2352 then 2352  -- образование
		else 0
	end
	as ClassStatus,
	wc.Comment
from tR_WorkerContactTemp wc
	left join tR_Worker w on wc.CodeWorker = w.Code
where (CodeType is not null) and w.Code is not null)
	

---------------------------- состояние работников ------------------------------

delete from tJ_StatusWorker

DBCC CHECKIDENT (tJ_StatusWorker, RESEED, 0)

-- смена подразделения или должности
insert into tJ_StatusWorker (Period, Worker, Division, JobTitle, [Status])
(select ws.Period, w.id, d.id, jt.id, 
	case 
		when [Status] = 0 then 5 -- прием
		when [Status] = 1 then 6 -- перемещение
		when [Status] = 2 then 7 -- увольнение
	end
	as ClassStatus
from tJ_StatusWorkerTemp ws
		left join  dbo.tR_Worker w on w.Code= ws.CodeWorker
		left join  dbo.tR_Division d on d.Code= ws.CodeDivision
		left join  dbo.tR_JobTitle jt on jt.Code= ws.CodeJobTitle
where ws.CodeDivision is not null
)

-- периоды работы
insert into tJ_StatusWorker (Period, Worker, [Status])
(select ws.Period, w.id, 
	case 
		when [Status] = 0 then 10 -- работает
		when [Status] = 1 then 11 -- уволен
		when [Status] = 2 then 12 -- болеет
		when [Status] = 3 then 13 -- в командировке
		when [Status] = 4 then 14 -- в ежегод. отпуске
		when [Status] = 5 then 15 -- в уч. опл. отпуске
		when [Status] = 6 then 16 -- в уч. неопл.отпуске
		when [Status] = 7 then 17 -- в отпуске без сохр. зарпл.
		when [Status] = 8 then 18 -- в отпуске по берем.
		when [Status] = 9 then 19 -- в отп. по уходу за ребенком
		when [Status] = 10 then 20 -- отсутст. по невыясн.причине
		when [Status] = 11 then 21 -- время вынужд.прогула
		when [Status] = 12 then 22 -- время исполн.гос.об.
		when [Status] = 13 then 23 -- прогулы
		when [Status] = 14 then 24 -- доп.вых.дни
		when [Status] = 15 then 25 -- простаивает
		when [Status] = 16 then 26 -- травма
		when [Status] = 17 then 27 -- уход за больным реб.
		when [Status] = 18 then 28 -- уход за больным взрослым
		when [Status] = 19 then 29 -- карантин
		when [Status] = 20 then 30 -- протезиров
		when [Status] = 21 then 31 -- долечивание
	end
	as ClassStatus
from tJ_StatusWorkerTemp ws
		left join tR_Worker w on w.Code= ws.CodeWorker
where ws.CodeDivision is null
)

END
GO


