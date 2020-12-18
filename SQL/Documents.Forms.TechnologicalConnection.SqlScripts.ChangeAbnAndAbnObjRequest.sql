--use ges

--declare @idAbn int
--declare @idAbnObj int

--set @idAbn = 1468608
--set @idAbnObj = 1872144

--declare @id int 
--set @id = 41318
--set @id = 29967

-- обновление заявки
update ttc_request
set idAbn = @idAbn, idAbnObj = @idAbnObj 
where id = @id
-- обновление дочерней заяки
update ttc_request
set idAbn = @idAbn, idAbnObj = @idAbnObj 
where id in (select r.id from ttc_request r
	inner join ttc_doc d on d.id = r.id
where idparent = @id)
-- обновление заявки-родителя
update ttc_request
set idAbn = @idAbn, idAbnObj = @idAbnObj 
where id in (select idParent from ttc_doc where id = @id)
-- обновление писем по заявке (надо потом еще по ту)
update ttc_mail
set idAbn = @idAbn, idAbnObj = @idAbnObj
where id in (select idDocOut from vtc_docOut
where idDoc = @id 
	  or idDoc in (select r.id from ttc_request r
								inner join ttc_doc d on d.id = r.id
								where idparent = @id)
	  or iddoc in  (select idParent from ttc_doc where id = @id))   -- проверит11111
-- обновление писем по тех условию
update ttc_mail
set idAbn = @idAbn, idAbnObj = @idAbnObj
where id in (select idDocOut from vtc_docout
where idDoc in (select idDocout from vtc_docOut
where (idDoc = @id 
	  or idDoc in (select r.id from ttc_request r
								inner join ttc_doc d on d.id = r.id
								where idparent = @id)
	  or iddoc in  (select idParent from ttc_doc where id = @id))
	  and typeDocOut = 1123))
-- обновление актов разграничения и эксплуатационной ответсвенности
update tAbnObjDoc_List
set idAbn = @idAbn, idAbnObj = @idAbnObj
where id in (select idlist from tAbnObjDoc_AktRBP
			where idTU in (select idDocOut from vtc_docOut
							where (idDoc = @id 
									or idDoc in (select r.id from ttc_request r
													inner join ttc_doc d on d.id = r.id
												where idparent = @id)
									or iddoc in  (select idParent from ttc_doc where id = @id))
							and typeDocOut = 1123))
-- обновление tL_SchmAbn
update tl_SchmAbn
set idAbn = @idAbn, idAbnObj = @idAbnObj							
where idDoc in (select idlist from tAbnObjDoc_AktRBP
			where idTU in (select idDocOut from vtc_docOut
							where (idDoc = @id 
									or idDoc in (select r.id from ttc_request r
													inner join ttc_doc d on d.id = r.id
												where idparent = @id)
									or iddoc in  (select idParent from ttc_doc where id = @id))
							and typeDocOut = 1123))
		and typeDoc = 497	