--use ges
--declare @idParentAbnObj int
--declare @idChildAbnObj int 

--set @idParentAbnObj = -1000
--set @idChildAbnObj = -1001
declare @idParentAbn int

select @idParentAbn = idAbn from tAbnObj where id = @idParentAbnObj


update tAbnDogObj
set idAbnObj = @idParentAbnObj
where idAbnObj = @idChildAbnObj

update tAbnObj
set idObjParent = @idParentAbnObj
where idObjParent = @idChildAbnObj


update tAbnObj_Image
set idAbnObj = @idParentAbnObj
where idAbnObj = @idChildAbnObj

update tAbnObjDoc_List
set idAbnObj = @idParentAbnObj
where idAbnObj = @idChildAbnObj

update tAbnObjFlags
set idAbnObj = @idParentAbnObj
where idAbnObj = @idChildAbnObj

update tAbnObjReg
set idAbnObj = @idParentAbnObj, idAbn = @idParentAbn
where idAbnObj = @idChildAbnObj

update tAbnObjReg
set idAbnObjSame = @idParentAbnObj
where idAbnObjSame = @idChildAbnObj

update dbo.tblAbnAplForDisconObjects
set AbnObjId = @idParentAbnObj, AbnId = @idParentAbn
where AbnObjId = @idChildAbnObj

update tConnect
set idObj = @idParentAbnObj
where idObj = @idChildAbnObj

update dbo.tG_AbnObjKLossTrans
set idAbnObj = @idParentAbnObj
where idAbnObj = @idChildAbnObj

update dbo.tG_DocSchet
set idAbnObj = @idParentAbnObj
where idAbnObj = @idChildAbnObj


update dbo.tG_DocSchetTemp
set idObj = @idParentAbnObj
where idObj = @idChildAbnObj

update dbo.tG_DocSchetTemp
set idObjParent = @idParentAbnObj
where idObjParent = @idChildAbnObj

update tG_Dog_Obj
set idObj = @idParentAbnObj
where idObj = @idChildAbnObj

update dbo.tG_MeasurementsOfObject
set idObj = @idParentAbnObj
where idObj = @idChildAbnObj

update dbo.tG_ObjMax
set [objid] = @idParentAbnObj
where [objid] = @idChildAbnObj


update dbo.tG_SchetValue
set idAbnObj = @idParentAbnObj
where idAbnObj = @idChildAbnObj

update dbo.tJ_CalcLoss
set idAbnObj = @idParentAbnObj, idAbn = @idParentAbn
where idAbnObj = @idChildAbnObj

update dbo.tL_SchmAbn
set idAbnObj = @idParentAbnObj, idAbn = @idParentAbn
where idAbnObj = @idChildAbnObj

update dbo.tPoint
set idAbnObj = @idParentAbnObj
where idAbnObj = @idChildAbnObj


update tTC_Mail
set idAbnObj = @idParentAbnObj, idAbn = @idParentAbn
where idAbnObj = @idChildAbnObj

update tTC_Request
set idAbnObj = @idParentAbnObj, idAbn = @idParentAbn
where idAbnObj = @idChildAbnObj

delete tAbnObj where id = @IdChildAbnObj