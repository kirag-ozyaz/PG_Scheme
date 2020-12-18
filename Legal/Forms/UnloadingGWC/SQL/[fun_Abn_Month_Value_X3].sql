USE [Org]
GO

/****** Object:  UserDefinedFunction [dbo].[fun_Abn_Month_Value_X3]    Script Date: 08/06/2010 13:26:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION  [dbo].[fun_Abn_Month_Value_X3]
(	
	@Date datetime, @Select int
)
RETURNS TABLE 
AS
RETURN 
(
		SELECT     tblAbn.Code [Номер договора], 
					tblAbn.AbnID, 
					tblAbn.NameShort [Наименование],
					Sum(0) [Долг на начало, руб],
					Sum([Quantity]) as [Потребление, кВт],
					((tbl_Doc.SumRealiz + tbl_Doc.SumNalog + tbl_Doc.SumPeni)/1000) AS [Начисление, руб],
					sum(0) [Оплата, руб],
					Sum(0) [Долг на конец]
					
		FROM         tblAbn INNER JOIN
							  tbl_Doc INNER JOIN
							  tbl_DocSchet ON tbl_Doc.idDoc = tbl_DocSchet.idDoc ON tblAbn.AbnID = tbl_Doc.idAbn
		WHERE    
			Month(tbl_Doc.dtPay) = Month(@Date)
			and Year(tbl_Doc.dtPay) = Year(@Date)
					
							 and  (tbl_Doc.dtPay <= @Date)
							 AND (tbl_Doc.IsDoc <> 0) -- наличие документа
							 AND (tbl_DocSchet.Type1 = 0) 
							 AND (tbl_DocSchet.Type2 = 4 OR
							 tbl_DocSchet.Type2 = 5 or
							 tbl_DocSchet.Type2 = 1) -- электроэнергия, бездоговорные
							 AND (tbl_DocSchet.Summa <> 0)
							 
		GROUP BY tblAbn.AbnID, tblAbn.Code, tblAbn.NameShort, ((tbl_Doc.SumRealiz + tbl_Doc.SumNalog + tbl_Doc.SumPeni)/1000)


--ORDER BY tblAbn.Code
)


GO


