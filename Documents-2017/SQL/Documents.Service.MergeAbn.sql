/*declare @idParentAbn int
declare @idChildAbn int 

set @idParentAbn = -1000
set @idChildAbn = -1001*/


update tAbn_Files
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tAbn_Image
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tAbnContact
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tAbnDoc_Dogovor
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tAbnDoc_List
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tAbnObj
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tAbnObjReg
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tAbnStatus
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tAbnType
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tblAbnAplForDisconIndividualUsers
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tblAbnAplForDisconObjects
set Abnid = @idParentAbn
where Abnid = @idChildAbn

update tG_AbnAddress
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tG_AbnChief
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tG_AbnInfo
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tG_AbnParent
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tG_BankReq
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tG_Doc
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tG_DocSchet
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tG_DocSchetTemp
set AbnID = @idParentAbn
where AbnID = @idChildAbn

update tG_Prognosis
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tG_Schet
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tG_Schetfact
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tG_Schetfact_Correct
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tJ_CalcLoss
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update dbo.tJ_Excavation
set idContractor = @idParentAbn
where idContractor = @idChildAbn

update tL_SchmAbn
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tTC_Mail
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tTC_Request
set idAbn = @idParentAbn
where idAbn = @idChildAbn

update tAbn 
set deleted = 1
where id = @idChildAbn