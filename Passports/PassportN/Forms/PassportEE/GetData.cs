using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Passport.Forms.PassportEE
{
	public static class GetData
	{
		public static DataTable GetEquipment()
		{
			SqlConnection sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = "Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True";
			sqlConnection.Open();
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand("WITH t (TP, Equipment, TypeEquipment, Value, [Count]) AS ( SELECT tp, equipment, typeequipment, value, [Count] FROM [GES].[dbo].[vP_Equipment_Report] UNION SELECT tp.typecode + '-' + tp.name AS TP, 'выключатели' AS equipment, CASE WHEN s.typecodeid = 558 THEN 'вакуумный' WHEN s.typecodeid = 552 THEN 'масляный' WHEN s.typecodeid in (554,559,553) THEN 'нагрузки' ELSE '' END AS TypeEquipment, c.value,  count(*) AS [Count] from vSchm_ObjList s LEFT JOIN tSChm_Relation rel ON rel.id = s.idParent LEFT JOIN  vSchm_ObjList cell ON cell.id = rel.edge LEFT JOIN vSchm_ObjList tp ON tp.id = cell.idParent LEFT JOIN  tR_Classifier AS c ON cell.typecodeid = c.id WHERE s.typeCodeid IN (559,553) AND s.deleted = 0  AND cell.deleted = 0 AND tp.deleted = 0 GROUP BY c.value, s.typeCodeid, tp.name, tp.typeCode) SELECT TP, RANK()  OVER(PARTITION BY tp ORDER BY Value, TypeEquipment, Equipment, tp ASC)  AS [RANK], [Equipment], [TypeEquipment], [Value], SUM([Count]) [Count] FROM t  GROUP BY [TP], [Equipment], [TypeEquipment], Value", sqlConnection));
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			sqlConnection.Close();
			return dataTable;
		}

		public static DataTable GetMaxPower()
		{
			SqlConnection sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = "Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True";
			sqlConnection.Open();
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand("select REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(name_group), ' А', 'А'), 'ЦП-', '') , 'ТП-', ''), 'РП-', ''), 'ПП-', ''), 'СП-', '') as TP, sum(powerset) as powerset from vg_AbnObj_new group by REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(name_group), ' А', 'А'), 'ЦП-', ''), 'ТП-', ''), 'РП-', ''), 'ПП-', ''), 'СП-', '') order by REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(name_group), ' А', 'А'), 'ЦП-', ''), 'ТП-', ''), 'РП-', ''), 'ПП-', ''), 'СП-', '')", sqlConnection));
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			sqlConnection.Close();
			return dataTable;
		}

		public static DataTable GetFactPower()
		{
			SqlConnection sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = "Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True";
			sqlConnection.Open();
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand("SELECT name_ist as TP, tr_num as tr, case when (sum(isnull(ia_d,0))+ sum(isnull(ib_d,0))+ sum(isnull(ic_d,0)))/3 >(sum(isnull(ia_v,0))+ sum(isnull(ib_v,0))+ sum(isnull(ic_v,0)))/3 then (sum(isnull(ia_d,0))+ sum(isnull(ib_d,0))+ sum(isnull(ic_d,0)))/3 else  (sum(isnull(ia_v,0))+ sum(isnull(ib_v,0))+ sum(isnull(ic_v,0)))/3 end as tok FROM [ULGES-SQL].[PTS].[dbo].[ZRubilnik] where zYear = 2013 group by name_ist, tr_num", sqlConnection));
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			sqlConnection.Close();
			return dataTable;
		}

		public static DataTable GetFactPower2014()
		{
			SqlConnection sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = "Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True";
			sqlConnection.Open();
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand("SELECT csm.SocrName + '-' + sm.Name TP, ISNULL(tm.Name, 'Т1') tr, 0.9 M, ROUND((MAX(t.tok) * SQRT(3) * MAX(CONVERT(DECIMAL(3,1), ISNULL(r.[Высокое напряжение], '0'))))/1000, 4) tok, 0 Q, 0 R FROM tJ_Measurement AS m JOIN vSchm_ObjList AS sm ON m.idObjList = sm.id JOIN tR_Classifier AS csm ON sm.TypeCodeId = csm.id CROSS APPLY (SELECT idObjList, MAX(Ia) tok FROM tJ_MeasAmperageTransf WHERE m.id = idMeasurement AND Deleted = 0 GROUP BY idObjList UNION ALL \t\t     SELECT idObjList, MAX(Ib) tok FROM tJ_MeasAmperageTransf WHERE m.id = idMeasurement AND Deleted = 0 GROUP BY idObjList UNION ALL \t\t     SELECT idObjList, MAX(Ic) tok FROM tJ_MeasAmperageTransf WHERE m.id = idMeasurement AND Deleted = 0 GROUP BY idObjList UNION ALL \t\t     SELECT idObjList, MAX(Io) tok FROM tJ_MeasAmperageTransf WHERE m.id = idMeasurement AND Deleted = 0 GROUP BY idObjList) t LEFT JOIN vSchm_ObjList AS tm ON t.idObjList = tm.id LEFT JOIN vP_Transformer_Report r ON tm.id = r.id WHERE m.TypeDoc = 1192 AND m.Year = 2014 AND m.Deleted = 0 AND r.[Высокое напряжение] IS NOT NULL AND LTRIM(RTRIM(r.[Высокое напряжение])) != '' GROUP BY csm.SocrName + '-' + sm.Name, tm.Name HAVING ROUND((MAX(t.tok) * SQRT(3) * MAX(CONVERT(DECIMAL(3,1), ISNULL(r.[Высокое напряжение], '0'))))/1000, 4) != 0 ORDER BY csm.SocrName + '-' + sm.Name, tm.Name", sqlConnection));
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			sqlConnection.Close();
			return dataTable;
		}

		public static DataTable GetSwitchAddl()
		{
			SqlConnection sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = "Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True";
			sqlConnection.Open();
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand("select tp.typecode + '-' + tp.name as TP, 'выключатели' as equipment, case when s.typecodeid = 558 then 'Масляный (вакуумный) выключатель' when s.typecodeid = 552 then 'Масляный (вакуумный) выключатель' when s.typecodeid in (554,559,553) then 'Выключатель нагрузки' else '' end as TypeEquipment, c.value, count(*) as count from vSchm_ObjList s left join tSChm_Relation rel on rel.id = s.idParent left join vSchm_ObjList cell on cell.id = rel.edge left join vSchm_ObjList tp on tp.id = cell.idParent left join tR_Classifier as c on cell.typecodeid = c.id where s.typeCodeid in (559,553) and s.deleted = 0  and cell.deleted = 0 and tp.deleted = 0 group by c.value, s.typeCodeid, tp.name, tp.typeCode", sqlConnection));
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			sqlConnection.Close();
			return dataTable;
		}

		public static DataTable GetConnectedPower()
		{
			SqlConnection sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = "Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True";
			sqlConnection.Open();
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand("select isnull(sub.typeCode, '') + '-' + isnull(sub.name, '') as SUBNAME, 2 -((RANK() OVER(PARTITION BY sub.name ORDER BY tup.id  ASC)) % 2) as rank, tr.name as NAMETRANS, dog.numDoc as NUMDOGOVOR, dog.dateDoc as DATEDOGOVOR, null as DATEENDDOGOVOR, dog.nameAbn as NAMEABN, tu.POWERSUM from vtc_Contract dog left join ttc_tuPointattach tuP on tuP.idtu = dog.idtu left join vSchm_ObjList sub on sub.id = tup.idSubPoint left join vtc_tu tu on  tu.id = dog.idTu outer apply dbo.fn_J_GetTransfByBusLV(tup.idBusPoint) as tr where tup.id is not null\tand sub.id is not null", sqlConnection));
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			sqlConnection.Close();
			return dataTable;
		}

		public static DataTable GetSubstation()
		{
			SqlConnection sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = "Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True";
			sqlConnection.Open();
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand("SELECT DISTINCT [Наименование], CASE WHEN Type = 538 AND (v.Name LIKE '%КТП%' OR v.Name LIKE '%ГТП%') THEN 'комплексная трансформаторная подстанция' WHEN Type = 538 AND (v.Name LIKE '%мачт.%' OR v.Name LIKE '%столбовая%') THEN 'мачтовая подстанция' WHEN Type = 537 AND tr.id IS NULL THEN 'распределительный пункт' WHEN Type = 537 AND tr.id IS NOT NULL THEN 'распределительная трансформаторная подстанция' ELSE 'трансформаторная подстанция' END [Type], Voltage [Напряжение], CASE WHEN [Инвентарный номер] = '0' THEN '' ELSE [Инвентарный номер] END [Инвентарный номер], CASE WHEN [Принадлежность] = 294 THEN 'хозяйственное ведение' ELSE '' END AS [Основание], ISNULL(LOWER(kos.SocrName), 'город') [Тип региона], ISNULL(ko.Name, 'Ульяновск') [Регион], LOWER(kss.SocrName) [Тип улицы], ks.Name [Улица], [Дом] FROM (SELECT DISTINCT o.id, o.Deleted, ISNULL(c_o.Name + '-' + o.Name, '') AS [Наименование], o.TypeCodeId [Type],v.Voltage, chl.Name, och.Value FROM tSchm_ObjList AS o CROSS APPLY (SELECT MAX(c.Value) Voltage FROM tSchm_ObjList AS bus JOIN tR_Classifier AS c ON bus.TypeCodeId = c.id AND c.parentKey LIKE ';SCM;BUS;%' WHERE bus.idParent = o.id) v LEFT JOIN tR_Classifier AS c_o ON o.TypeCodeId = c_o.Id LEFT JOIN tP_Passport AS p ON o.Id = p.idObjList AND p.Deleted = 0 AND p.isActive = 1 LEFT JOIN tP_ObjectChar AS och ON p.id = och.idPassport LEFT JOIN tP_CharList AS chl ON och.idObjChar = chl.id AND chl.Deleted = 0 LEFT JOIN tSchm_ObjList AS tr ON tr.TypeCodeId = 556 AND (o.id = tr.idParentAddl OR o.id = tr.idParent) AND tr.Deleted = 0 AND tr.Location IS NULL WHERE o.TypeCodeId IN (537, 538) AND o.Deleted = 0) sq PIVOT (MAX(Value) FOR sq.Name IN ([Тип],[Инвентарный номер], [Принадлежность], [Регион] ,[Улица],[Дом])) AS pt LEFT JOIN tR_KladrStreet AS ks ON pt.[Улица] = ks.id LEFT JOIN tR_KladrSocr AS kss ON ks.Socr = kss.scname LEFT JOIN tR_KladrObj AS ko ON ks.KladrObjId = ko.id LEFT JOIN tR_KladrSocr AS kos ON ko.Socr = kos.scname AND kos.SocrName IS NOT NULL LEFT JOIN tSchm_ObjList AS tr ON tr.TypeCodeId = 556 AND (pt.id = tr.idParentAddl OR pt.id = tr.idParent) AND tr.Deleted = 0 AND tr.Location IS NULL LEFT JOIN tP_ValueLists AS v ON [Тип] = v.id WHERE [Принадлежность] = 294 ORDER BY [Наименование]", sqlConnection));
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			sqlConnection.Close();
			return dataTable;
		}

		public static DataTable GetTransformer()
		{
			SqlConnection sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = "Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True";
			sqlConnection.Open();
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand("SELECT [Расположение], RANK() OVER(PARTITION BY [Расположение] ORDER BY [Наименование] ASC) as rank, Id, IdPassport, [Наименование], [Тип],[Мощность], CASE WHEN [Инвентарный номер] = '00 аб' OR [Инвентарный номер] = 'аб' THEN '' ELSE [Инвентарный номер] END [Инвентарный номер] ,[Заводской номер], CASE WHEN [Тип] IN ('Т','TZOxa','TTU','TTU-AI','ТМ','ТМN','ТМА','ТМГ','ТМГ 12','ТМГ 21','ТМГ11','ТМГэ','ТМЗ','ТМФ') THEN 'масляная' WHEN [Тип] IN ('ТС' ,'ТСЛ','ТСМ','ТСМА') THEN 'сухая' WHEN [Тип] IN ('ТЛС') THEN 'литая' ELSE '' END [Изоляция], [Высокое напряжение], [Низкое напряжение],[Потери холостого хода] ,[Завод-изготовитель], CASE WHEN LEN([Год изготовления]) = 10 THEN SUBSTRING([Год изготовления],7,4) ELSE [Год изготовления] END [Год изготовления], CONVERT(varchar(10), [Дата ремонта], 104) as [Дата ремонта], CASE WHEN [Дата ввода в эксплуатацию] = '01.01.0001' THEN '' WHEN LEN([Дата ввода в эксплуатацию]) = 10 THEN SUBSTRING([Дата ввода в эксплуатацию],7,4) ELSE [Дата ввода в эксплуатацию] END [Дата ввода в эксплуатацию] FROM [GES].[dbo].[vP_Transformer_Report] WHERE [Расположение] is not null and [Расположение] not in ('Списан', 'Склад', 'Склад 4 р-на', 'Цех ремонта') order by [Расположение] ASC, [Наименование] ASC", sqlConnection));
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			sqlConnection.Close();
			return dataTable;
		}

		public static string GetSSNameFromDB(string p)
		{
			SqlConnection sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = "Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True";
			sqlConnection.Open();
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand("SELECT c.SocrName + '-' + o.name AS name FROM [GES].[dbo].[tSchm_ObjList] AS o INNER JOIN tR_Classifier AS c ON o.TypeCodeId = c.id WHERE c.id in (536, 537, 538, 535, 1034) AND o.name = '" + p + "'", sqlConnection));
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			sqlConnection.Close();
			if (dataTable.Rows.Count <= 0)
			{
				return "";
			}
			return dataTable.Rows[0]["name"].ToString();
		}

		public static DataTable GetSubstationNames()
		{
			SqlConnection sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = "Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True";
			sqlConnection.Open();
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand("SELECT DISTINCT subname Substation, a.Name FROM tAbnObjDoc_List AS doc INNER JOIN tAbn AS a ON doc.idAbn = a.id INNER JOIN vL_SchmAbnFull AS l ON doc.idAbn = l.idAbn AND idSchmObj IS NOT NULL AND subname IS NOT NULL WHERE idDocType = 497", sqlConnection)
			{
				CommandTimeout = 400
			});
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			sqlConnection.Close();
			return dataTable;
		}
	}
}
