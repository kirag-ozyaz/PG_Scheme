--use ges
--declare @idParentAbnObj int
--declare @idChildAbnObj int 

--set @idParentAbnObj = -1000
--set @idChildAbnObj = -1001
--declare @idParentAbn int

--select @idParentAbn = idAbn from tAbnObj where id = @idParentAbnObj

update tAbnDogObj
set idAbnDog = @idMoveAbn
where idAbnObj = @idAbnObj

update tAbnObj
set idAbn = @idMoveAbn
where id = @idAbnObj

update tAbnObjDoc_List
set idAbn = @idMoveAbn
where idAbnObj = @idAbnObj

update tAbnObjReg
set idAbn = @idMoveAbn
where idAbnObj = @idAbnObj

update dbo.tblAbnAplForDisconObjects
set AbnId = @idMoveAbn
where AbnObjId = @idAbnObj

update dbo.tJ_CalcLoss
set idAbn = @idMoveAbn
where idAbnObj = @idAbnObj

update dbo.tL_SchmAbn
set idAbn = @idMoveAbn
where idAbnObj = @idAbnObj

update tTC_Mail
set idAbn = @idMoveAbn
where idAbnObj = @idAbnObj

update tTC_Request
set idAbn = @idMoveAbn
where idAbnObj = @idAbnObj
