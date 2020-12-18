USE [Org]
GO

/****** Object:  UserDefinedFunction [dbo].[fun_Abn_X1]    Script Date: 08/06/2010 13:26:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
/*
SELECT DISTINCT tblAbn.AbnID, SUM(tbl_DocSchet.Quantity) AS [Sum-Quantity]
FROM         tblAbn INNER JOIN
                      tbl_DocSchet INNER JOIN
                      tbl_Doc ON tbl_DocSchet.idDoc = tbl_Doc.idDoc ON tblAbn.AbnID = tbl_Doc.idAbn
WHERE     (Year(tbl_Doc.dtPay) in (2009, 2010))
 AND (tbl_DocSchet.Type1 = 0) 
 AND (tbl_DocSchet.Type2 = 4 OR
                      tbl_DocSchet.Type2 = 5) AND (tbl_DocSchet.Summa <> 0) AND (tbl_Doc.IsDoc <> 0)
GROUP BY tblAbn.AbnID
HAVING      (SUM(tbl_DocSchet.Quantity) <> 0)
*/

/*ORDER BY dbo.tblAbn.Code*/
-- =======================================================
CREATE FUNCTION [dbo].[fun_Abn_X1]
(	
	
)
RETURNS TABLE 
AS
RETURN 
(
/*Всего на 2010-07-13 5564*/


SELECT     SUBSTRING('0000', 1, 4 - LEN(tblAbn.Code)) + CAST(tblAbn.Code AS varchar) AS Code, 
					tblAbn.AbnID, 
					tblAbn.NameShort, 
					tblAbn.NameFull, 
                      CASE tblAbn.NumPlatDoc WHEN 0 THEN 'купля' WHEN 1 THEN 'энергоснабжение' END AS TypeDog, 
                      '№' + CAST(tblAbn.Code AS varchar) + ' от ' + CONVERT(varchar, tblAbn.DateDog, 101) AS Dogovor, 
                      '' AS StatusDog, 
                      tblAbn.Chief_FirstName + ' ' + tblAbn.Chief_MiddleName + ' ' + tblAbn.Chief_LastName AS FIO, tblAbn.Chief_Status, tblAbn.Street, tblAbn.PostAddress, 
                      tblAbn.Phone, tbl_Contrl.Family, tblAbn.DateBegin
FROM         tblAbn LEFT OUTER JOIN
                      tbl_Contrl ON tblAbn.ContrlID = tbl_Contrl.ContrlID 
WHERE     (tblAbn.Code < 9003) 

)


GO


