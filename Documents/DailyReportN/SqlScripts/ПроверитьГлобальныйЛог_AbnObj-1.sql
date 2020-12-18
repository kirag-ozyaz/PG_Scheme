use GES;
declare @dt datetime 
set @dt = '2017-01-02 18:44:00'
/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT obj.id, reg.idAbnObj, regLog.idAbnObj, *--, objLog.id--obj.*, reg.[DateChange], reg.idAbn

-- codeAbonent,
------obj.idAbn,
--------nameAbn,
--------typeAbn,

------obj.id idAbnObj,
------obj.name nameObj,
------'' CategoryName,
------'' TarifName,
------0 Voltage,
------0 PowerSet,
------0 CountPoint,
------reg.CommentODS,
------reg.idAbnNet
--------nameAbnNet,
--------idSchmObj

  FROM [GES].[dbo].[tAbnObj] obj
	left join [GES].[dbo].[tAbnObjReg] reg on obj.id = reg.idAbnObj
	
	left join [GES_log].[dbo].[tAbnObjReg] regLog on regLog.idAbnObj = reg.idAbnObj
		and (regLog.id = (SELECT MAX(bRegLog.id) FROM  [GES_log].[dbo].tAbnObjReg bRegLog where regLog.idAbnObj = bRegLog.idAbnObj and bRegLog.dateChange <= @dt ) /*or regLog.dateChange is null*/)
	
	left join [GES_log].[dbo].[tAbnObj] objLog on objLog.idobj = reg.idAbnObj
		and objLog.id = (SELECT MAX(bObjLog.id) FROM  [GES_log].[dbo].tAbnObj bObjLog where objLog.idobj = bObjLog.idobj 
			and Cast(Convert(varchar, bObjLog.DateCommand, 106) as datetime) <= Cast(Convert(varchar, regLog.dateCommand, 106) as datetime))

  WHERE obj.id in  (1492341,1493216,1493219,1494921,1494922,1498402,1765478,1765480,1765536,1875760,1877627,1880612,1880792,1885818,1887497,1889498)
  and (reg.id = (SELECT MAX(bReg.id) FROM  [GES].[dbo].tAbnObjReg bReg where reg.idAbnObj = bReg.idAbnObj  
			and bReg.dateChange <= @dt) or reg.dateChange is null)
		
  order by obj.id asc 

-------------------------
use GES;
declare @dt datetime 
set @dt = '2017-01-02 18:44:00'
/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT TOP 1000 obj.*, reg.[DateChange], reg.idAbn
  FROM [GES].[dbo].[tAbnObj] obj
	left join [GES].[dbo].[tAbnObjReg] reg on obj.id = reg.idAbnObj
  WHERE obj.id in  (1492341,1493216,1493219,1494921,1494922,1498402,1765478,1765480,1765536,1875760,1877627,1880612,1880792,1885818,1887497,1889498)
  and (reg.id = (SELECT MAX(bReg.id) FROM  [GES].[dbo].tAbnObjReg bReg where reg.idAbnObj = bReg.idAbnObj  
			and dateChange <= @dt) or dateChange is null)
		
  order by obj.id asc 
  
  	-------------------
	
	use GES;
declare @dt datetime 
set @dt = '2017-01-02 18:44:00'
/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT obj.id, reg.idAbnObj, regLog.idAbnObj--obj.*, reg.[DateChange], reg.idAbn
  FROM [GES].[dbo].[tAbnObj] obj
	left join [GES].[dbo].[tAbnObjReg] reg on obj.id = reg.idAbnObj
	left join [GES_log].[dbo].[tAbnObjReg] regLog on regLog.idAbnObj = reg.idAbnObj
		and (regLog.id = (SELECT MAX(bRegLog.id) FROM  [GES_log].[dbo].tAbnObjReg bRegLog where regLog.idAbnObj = bRegLog.idAbnObj and bRegLog.dateChange <= @dt ) or regLog.dateChange is null)
	

  WHERE obj.id in  (1492341,1493216,1493219,1494921,1494922,1498402,1765478,1765480,1765536,1875760,1877627,1880612,1880792,1885818,1887497,1889498)
  and (reg.id = (SELECT MAX(bReg.id) FROM  [GES].[dbo].tAbnObjReg bReg where reg.idAbnObj = bReg.idAbnObj  
			and bReg.dateChange <= @dt) or reg.dateChange is null)
		
  order by obj.id asc 
  
  
  SELECT *
  FROM [GES_log].[dbo].[tAbnObjReg] reg
  where reg.[idAbnObj] in (1492341,1493216,1493219,1494921,1494922,1498402,1765478,1765480,1765536,1875760,1877627,1880612,1880792,1885818,1887497,1889498)
	and (reg.id = (SELECT MAX(bReg.id) FROM  [GES_log].[dbo].tAbnObjReg bReg where reg.idAbnObj = bReg.idAbnObj and bReg.dateChange <= @dt ) )
  order by reg.[idAbnObj] asc
/***************************************************************************************/
declare @dt datetime 
set @dt = '2017-01-02 18:44:00'

--/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT objLog.id objLogId, objLog.idobj objId, ObjLog.DateCommand, *
  FROM [GES_log].[dbo].[tAbnObjReg] regLog
	 left join [GES_log].[dbo].[tAbnObj] objLog on objLog.idobj = regLog.idAbnObj
		and
		objLog.id = (SELECT MAX(bObjLog.id) FROM  [GES_log].[dbo].tAbnObj bObjLog where objLog.idobj = bObjLog.idobj 
			and Cast(Convert(varchar, bObjLog.DateCommand, 106) as datetime) <= Cast(Convert(varchar, regLog.dateCommand, 106) as datetime)
			)
  where regLog.[idAbnObj] in (1492341,1493216,1493219,1494921,1494922,1498402,1765478,1765480,1765536,1875760,1877627,1880612,1880792,1885818,1887497,1889498)
	and (regLog.id = (SELECT MAX(bReg.id) FROM  [GES_log].[dbo].tAbnObjReg bReg where regLog.idAbnObj = bReg.idAbnObj and bReg.dateChange <= @dt ) )
  order by regLog.[idAbnObj] asc
 



--  SELECT *
--  FROM [GES_log].[dbo].[tAbnObjReg]
--  where [idAbnObj] in (1492341)
--  order by id desc


--SELECT *
--  FROM [GES_log].[dbo].[tAbnObj] obj
--  where [idObj] in (1492341)-- and command in ('ins','updins')
--  order by id desc
----  ---------------------------------