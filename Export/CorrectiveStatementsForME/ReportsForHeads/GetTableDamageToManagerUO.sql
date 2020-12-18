/*

		Получение данных по аварийным событиям за период
		Используется база данных Repa MySQL
				-- дата заявки
				-- электроустановка
				-- сетевой район NetRegionSub
				-- место повреждения defectLocation
				-- характер повреждения Character
				-- причина Reason
				-- дата устранения dateApply
				-- выполненная работа completedWork
				-- выполненная работа текст ComletedWorkText

			вход 
			@dataBeg	- дата и время начала
			@dataEnd	- дата и время конца

			typeDoc =  (Нарушение УО)

*/

SELECT 'Нарушения УО'  typedoc, Cast(d.id as char) NumRequest, Cast('' as char) numDoc, Cast(Concat(d.date, ' ',d.time) as DateTime) DateDoc, Concat('ППНО-', build.name) obj_name, 
who.fullname NetRegion,
d.notLight DefectLocation, d.repairCharacter reason, CONCAT(parent.name, ' / ', f.name) 'Character',  
Cast(Concat(d.repairDate, ' ' , d.repairTime) as DateTime) as dateApply /*, w.name*/
, case
	when yes = 1 then 'Выполнено'
	when repairDate ="0000-00-00" then 'В работе'
	when who != 9 then concat('Передано в район: ', d.comment)
	else ''
 end  as completedWork /*Отметка о выполнении*/
, '' ComletedWorkText


FROM repa.data_in as d
left join repa.fault_in as f on d.fault = f.num
left join repa.who as w on d.who = w.name
left join repa.fault_in as parent on 
		parent.npp = left(f.npp,locate('.',f.npp)-1) 
		and locate('.',parent.npp) = 0
left join asoca.build as build  on build.id = d.ppno
left join repa.who as who on who.num = d.who
where  locate('.',f.npp)>0
  	and (Cast(Concat(d.date, ' ',d.time) as datetime) <= Cast(Concat(Cast(@dataEnd as Date),' ',@timeEnd) as datetime) /*'2019-10-15 23:59:59'*//*@dataEnd */
		and Cast(Concat(d.date, ' ',d.time) as datetime) >= Cast(Concat(Cast(@dataBeg as Date),' ',@timeBeg) as datetime))/*'2019-10-15 00:00:00'*//*@dataBeg*/
order by d.id desc;