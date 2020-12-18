select  ao.idAbn,
		ao.CodeAbonent,
		ao.Name as nameAbn, 
		ao.TypeAbn, 
		ao.typeAbnName,
		ao.id as idAbnObj,
		ao.nameObj, 
		ao.address,
		req.id as idRequest,
		req.numIn, 
		req.DateIn, 
		req.numdateIn,
		tu.id as tuId, 
		tu.numDoc as numTU, 
		tu.dateDoc as dateTU
from vAbnObj ao
	inner join vtc_Request req on req.idAbnObj = ao.id
	left join vtc_tu tu on tu.idRequest = req.id
where ao.deleted = 0	