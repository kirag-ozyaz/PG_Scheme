/*


*/

SELECT reg.idAbn,reg.idAbnObj ,act.value('NumDoc[1]/@Value','varchar(max)') NumDoc,  act.value('DateDoc[1]/@Value','varchar(max)') DateDoc,  act.value('EmergencyReserv[1]/@Value','varchar(max)') EmergencyReserv,  act.value('TechnologicalReserv[1]/@Value','varchar(max)') TechnologicalReserv
from tAbn 
  left join  tAbnObj on tAbnObj.idAbn = tAbn.id
  left join tAbnObjReg reg on reg.id = (select top 1 id from tAbnObjReg
                                                            where idAbnObj = tAbnObj.id and idAbn = tAbn.id
                                                            order by dateChange desc)
  outer apply reg.CommentXml.nodes('/CommentXML/ActApprovalReservation') col(act)
  where reg.[CommentXML] is not null