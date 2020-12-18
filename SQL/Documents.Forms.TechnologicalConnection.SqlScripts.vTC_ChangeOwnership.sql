select d.id, d.numdoc, d.dateDoc, d.typeDoc, d.comment,
		dc.numDocIn, dc.dateDocIn, dc.typeDocin,
		dc.idAbnOld, aoold.codeAbonent as codeAbonentold,
		aoold.name as nameAbnOld, dc.idAbnObjOld,
		aoold.nameObj as nameObjOld,
		dc.idAbnNew, aonew.codeAbonent as codeAbonentnew,
		aonew.name as nameAbnNew, dc.idAbnObjNew,
		aonew.nameObj as nameObjNew,
		
		dc.isApply from ttc_doc d
	left join ttc_ChangeOwnership dc on dc.id = d.id
	left join vAbnObj aoOld on aoOld.id = dc.idAbnObjOld
	left join vAbnObj aoNew on aoNew.id = dc.idAbnObjNEw
	
where d.typeDoc = 1345
