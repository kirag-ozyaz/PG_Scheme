
SELECT pt.Id, pt.IdPassport, 
		pt.idEquipment, 
		pt.[Расположение], 
		pt.[idSub],
		pt.[Наименование], pt.[Мощность],
		pt.[Тип],pt.[Заводской номер],
		pt.[Инвентарный номер],pt.[Номин. напр. обмотки ВН, кВ],
		pt.[Номин. напр. обмотки НН, кВ],pt.[Номинальный ток обмотки ВН, А],
		pt.[Номинальный ток обмотки НН, А],pt.[Группа соединений обмоток],
		pt.[Напряжение короткого замыкания, %],pt.[Потери короткого замыкания, кВт],pt.[Потери холостого хода, кВт],
		pt.[Ток холостого хода, А],pt.[Завод-изготовитель],pt.[Первоначальная стоимость],pt.[Балансовая стоимость],
		pt.[Год изготовления],pt.[Дата ввода в эксплуатацию],pt.[Примечание],pt.[ТА0,b-400/10], 
		(SELECT MAX(Data) 
		 FROM tSchm_Move 
		 WHERE Action = 865 AND idObjList = pt.id GROUP BY idObjList) [Дата ремонта],
		pvt.[Марка], 
		pvt.[Тип тр-ра], 
		pvt.[Мощность тр-ра], 
		pvt.[Номин. высшее напр., кВ],
		pvt.[Номин. низшее напр., кВ], pvt.[Номинальный ток высокого напряжения], 
		pvt.[Номинальный ток ниского напряжения],
		pvt.[Группа обмоток], pvt.[Напряжение короткого замыкания, %], pvt.[Потери короткого замыкания, кВт], 
		pvt.[Потери холостого хода, кВт]
FROM 
  (SELECT child.Id, tP_Passport.id AS IdPassport, 
		  tP_Passport.idEquipment, 
		  ISNULL(c_parent.Name + ' - ' + parent.Name, c_child_location.Name)
								+ (CASE WHEN parent.Deleted = 1 THEN ' (уд.)' ELSE '' END) AS [Расположение],
		  parent.id as idSub, 
		  child.Name AS [Наименование],  dbo.tP_CharList.Name, 
		  ISNULL(CASE WHEN tP_CharList.Type = 728 THEN 
						(SELECT Name FROM vP_GetValueList WHERE id = tP_ObjectChar.Value AND 
						ParentId = tP_CharList.idValueList AND TableName = tP_CharList.TableName) 
				WHEN tP_CharList.Type = 730 AND tP_CharList.Format = 732
				THEN ISNULL(CONVERT(varchar(10), tP_ObjectChar.Value, 104), '') 
				ELSE tP_ObjectChar.Value END, '') AS CharValue 
    FROM dbo.tSchm_ObjList AS child 
    LEFT JOIN tSchm_ObjList AS parent ON ISNULL(child.IdParentAddl, child.IdParent) = parent.Id AND parent.TypeCodeId != 111
    LEFT JOIN tR_Classifier AS c_parent ON parent.TypeCodeId = c_parent.Id 
    LEFT JOIN tR_Classifier AS c_child_location ON child.Location = c_child_location.Id 
    LEFT JOIN dbo.tP_Passport ON child.Id = dbo.tP_Passport.idObjList AND dbo.tP_Passport.Deleted = 0 AND dbo.tP_Passport.isActive = 1 
    LEFT JOIN dbo.tP_ObjectChar ON dbo.tP_Passport.id = dbo.tP_ObjectChar.idPassport
    LEFT JOIN dbo.tP_CharList ON dbo.tP_ObjectChar.idObjChar = dbo.tP_CharList.id AND dbo.tP_CharList.Deleted = 0 
WHERE (child.Deleted = 1 AND child.Location = 909 OR child.Deleted = 0) AND child.TypeCodeId IN (556)) sq 

PIVOT (MAX(CharValue) FOR sq.Name IN 
	([Мощность],[Тип],[Заводской номер],[Инвентарный номер],[Номин. напр. обмотки ВН, кВ],[Номин. напр. обмотки НН, кВ],
	[Номинальный ток обмотки ВН, А],[Номинальный ток обмотки НН, А],[Группа соединений обмоток],[Напряжение короткого замыкания, %],
	[Потери короткого замыкания, кВт],[Потери холостого хода, кВт],[Ток холостого хода, А],[Завод-изготовитель],[Первоначальная стоимость],
	[Балансовая стоимость],[Год изготовления],[Дата ввода в эксплуатацию],[Примечание],[ТА0,b-400/10], [Дата ремонта])) 
	AS pt 
		LEFT JOIN (SELECT id, [Description], Value 
					FROM vP_TransfReference) AS SourceTable 
					PIVOT (MIN([Value]) FOR [Description] IN ([Марка],[Тип тр-ра],
					[Мощность тр-ра],[Номин. высшее напр., кВ],
					[Номин. низшее напр., кВ],
					[Номинальный ток высокого напряжения],
					[Номинальный ток ниского напряжения],
					[Группа обмоток],[Напряжение короткого замыкания, %],[Потери короткого замыкания, кВт],
					[Потери холостого хода, кВт])) AS 
	pvt ON pt.idEquipment = pvt.id
