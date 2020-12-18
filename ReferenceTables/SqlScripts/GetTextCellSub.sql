/*
Возвращвем текст привязанный к ячейкам подстанций
*/
-- use ges

  select obj.id idCell,  col.Text.value('@text', 'varchar(max)') cText, [dbo].[fn_Schm_GetFullNameObjById](_xml.ObjId) CellName,  _xml.Tag idSub, [dbo].[fn_Schm_GetFullNameObjById](_xml.Tag)  SubName
   from [tSchm_ObjList] obj -- линия
   left join [tSchm_Xml] _xml on _xml.objid = obj.id
   left join [tR_Classifier] trc on trc.id = obj.typecodeid
   cross apply _xml.[SchemaXml].nodes('//textBranch') AS col(Text)
   left join [tSchm_ObjList] objSub on objSub.id = _xml.Tag
   left join [tR_Classifier] trcS on trcS.id = objSub.typecodeid 
   
   where -- _xml.Tag = 773586  and 
   obj.deleted = 0
  and (trc.ParentKey = ';SCM;Line;' or trc.ParentKey like ';SCM;Cell;%')
  and trcS.ParentKey = ';SCM;PS;'