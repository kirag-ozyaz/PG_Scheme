using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace ExcelMacrosRun
{
	public static class DatabaseData
	{
		public static DataTable ConnectedPower()
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

		public static DataTable Equipments()
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

		public static DataTable Substations()
		{
			SqlConnection sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = "Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True";
			sqlConnection.Open();
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand("SELECT DISTINCT [Наименование], CASE WHEN Type = 538 AND (v.Name LIKE '%КТП%' OR v.Name LIKE '%ГТП%') THEN 'комплексная трансформаторная подстанция' WHEN Type = 538 AND (v.Name LIKE '%мачт.%' OR v.Name LIKE '%столбовая%') THEN 'мачтовая подстанция' WHEN Type = 537 AND tr.id IS NULL THEN 'распределительный пункт' WHEN Type = 537 AND tr.id IS NOT NULL THEN 'распределительная трансформаторная подстанция' ELSE 'трансформаторная подстанция' END [Type], Voltage [Напряжение], [Инвентарный номер], CASE WHEN [Принадлежность] = 294 THEN 'хозяйственное ведение' ELSE '' END AS [Основание], LOWER(kos.SocrName) [Тип региона], ko.Name [Регион], LOWER(kss.SocrName) [Тип улицы], ks.Name [Улица],[Дом] FROM (SELECT DISTINCT o.id, ISNULL(c_o.Name + '-' + o.Name, '') AS [Наименование], o.TypeCodeId [Type],v.Voltage, chl.Name, och.Value FROM tSchm_ObjList AS o OUTER APPLY (SELECT MAX(c.Value) Voltage FROM tSchm_ObjList AS bus JOIN tR_Classifier AS c ON bus.TypeCodeId = c.id AND c.parentKey LIKE ';SCM;BUS;%' WHERE bus.idParent = o.id) v LEFT JOIN tR_Classifier AS c_o ON o.TypeCodeId = c_o.Id LEFT JOIN tP_Passport AS p ON o.Id = p.idObjList AND p.Deleted = 0 AND p.isActive = 1 LEFT JOIN tP_ObjectChar AS och ON p.id = och.idPassport LEFT JOIN tP_CharList AS chl ON och.idObjChar = chl.id AND chl.Deleted = 0 LEFT JOIN tSchm_ObjList AS tr ON tr.TypeCodeId = 556 AND (o.id = tr.idParentAddl OR o.id = tr.idParent) AND tr.Deleted = 0 AND tr.Location IS NULL WHERE o.TypeCodeId IN (537, 538)) sq PIVOT (MAX(Value) FOR sq.Name IN ([Тип],[Инвентарный номер], [Принадлежность], [Регион] ,[Улица],[Дом])) AS pt LEFT JOIN tR_KladrStreet AS ks ON pt.[Улица] = ks.id LEFT JOIN tR_KladrSocr AS kss ON ks.Socr = kss.scname LEFT JOIN tR_KladrObj AS ko ON ks.KladrObjId = ko.id LEFT JOIN tR_KladrSocr AS kos ON ko.Socr = kos.scname LEFT JOIN tSchm_ObjList AS tr ON tr.TypeCodeId = 556 AND (pt.id = tr.idParentAddl OR pt.id = tr.idParent) AND tr.Deleted = 0 AND tr.Location IS NULL LEFT JOIN tP_ValueLists AS v ON [Тип] = v.id WHERE kos.SocrName IS NOT NULL ORDER BY [Наименование]", sqlConnection));
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			sqlConnection.Close();
			return dataTable;
		}

		public static DataTable TransfFactPower()
		{
			SqlConnection sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = "Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True";
			sqlConnection.Open();
			DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand("SELECT csm.SocrName + '-' + sm.Name TP ,ISNULL(tm.Name, 'Т1') tr ,MAX(ISNULL(at.[Ia], 0) + ISNULL(at.[Ib], 0) + ISNULL(at.[Ic], 0) + ISNULL(at.[Io], 0)) tok FROM tJ_Measurement AS m JOIN vSchm_ObjList AS sm ON m.idObjList = sm.id JOIN tR_Classifier AS csm ON sm.TypeCodeId = csm.id LEFT JOIN tJ_MeasAmperageTransf AS at ON m.id = at.idMeasurement AND at.Deleted = 0 LEFT JOIN vSchm_ObjList AS tm ON at.idObjList = tm.id WHERE m.TypeDoc = 1192 AND m.Year = 2014 AND m.Deleted = 0 GROUP BY csm.SocrName + '-' + sm.Name, tm.Name", sqlConnection));
			DataTable dataTable = new DataTable();
			dbDataAdapter.Fill(dataTable);
			sqlConnection.Close();
			return dataTable;
		}

		public static DataTable TransfMaxPower()
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

		public static DataTable Transformers()
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
	}
}
