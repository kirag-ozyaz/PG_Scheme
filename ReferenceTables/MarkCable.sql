/*

Марки кабеля


*/
SELECT  cab.[id]
      ,cab.[CableMakeup]
      ,isNull(cab.[Wires],0) as Wires
      ,isNull(cab.[CrossSection],0) as CrossSection
      ,cab.[WiresAddl]
      ,cab.[CrossSectionAddl]
      ,cab.[WiresLight]
      ,cab.[CrossSectionLight]
      ,cab.[AmperageAir]
      ,cab.[Amperage]
      ,cab.[Resistance]
      ,cab.[ResistanceAddl]
      ,cab.[IdVoltage]
      ,cab.[Deleted]
	  , clas.Value Voltage
  FROM [tR_Cable]   cab 
  left join tR_Classifier clas on clas.id = cab.[IdVoltage]