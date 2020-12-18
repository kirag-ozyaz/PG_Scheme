use ges;
declare @dt datetime;
-- set @dt = '2019-02-06 15:36:000';
-- set @dt = '2019-03-15 10:54:000';
set @dt = '2019-03-07 19:23:000';
--set @dt = '2019-03-14 17:33:000' 

select -- lup.action, CHARINDEX('Повреждено', lup.action ) a, CHARINDEX('Отсоединено', lup.action ) b, 
		dbo.fn_Schm_GetFullNameObjById(o.id) , o.id, 
     ldown.dateLog as dateDown,  ldown.action as actionDown, lup.dateLog as dateup, lup.action as actionup
	 , case  when  ldown.action <> null and CHARINDEX('Повреждено', ldown.action )= 0 and  CHARINDEX('Отсоединено', ldown.action ) = 0 then 1   else 0  end IsDown 
	 , case  when  ldown.action <> null and CHARINDEX('Повреждено', ldown.action )= 0 and  CHARINDEX('Отсоединено', ldown.action ) = 0 then ldown.action  else lup.action end ActionCaption
from tSchm_ObjList o
	     left join [tSchm_LogDispatcher] lUp on lup.id = 
					(select top 1 id 
					 from [tSchm_LogDispatcher]
					 where idObj = o.id and DateLog > @dt
					 order by dateLog asc)
		  left join [tSchm_LogDispatcher] lDown on lDown.id = 
										(select top 1 id 
										 from [tSchm_LogDispatcher]
										 where idObj = o.id and DateLog <= @dt
										 order by dateLog desc)
where (lup.id is not null) --and o.id = 761923
order by ldown.id--dateDown, dateup
--order by o.id, dateDown desc