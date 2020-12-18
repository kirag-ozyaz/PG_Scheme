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
		SELECT     tblAbn.Code [����� ��������], 
					tblAbn.AbnID, 
					tblAbn.NameShort [������������],
					Sum(0) [���� �� ������, ���],
					Sum([Quantity]) as [�����������, ���],
					((tbl_Doc.SumRealiz + tbl_Doc.SumNalog + tbl_Doc.SumPeni)/1000) AS [����������, ���],
					sum(0) [������, ���],
					Sum(0) [���� �� �����]
					
		FROM         tblAbn INNER JOIN
							  tbl_Doc INNER JOIN
							  tbl_DocSchet ON tbl_Doc.idDoc = tbl_DocSchet.idDoc ON tblAbn.AbnID = tbl_Doc.idAbn
		WHERE    
			Month(tbl_Doc.dtPay) = Month(@Date)
			and Year(tbl_Doc.dtPay) = Year(@Date)
					
							 and  (tbl_Doc.dtPay <= @Date)
							 AND (tbl_Doc.IsDoc <> 0) -- ������� ���������
							 AND (tbl_DocSchet.Type1 = 0) 
							 AND (tbl_DocSchet.Type2 = 4 OR
							 tbl_DocSchet.Type2 = 5 or
							 tbl_DocSchet.Type2 = 1) -- ��������������, �������������
							 AND (tbl_DocSchet.Summa <> 0)
							 
		GROUP BY tblAbn.AbnID, tblAbn.Code, tblAbn.NameShort, ((tbl_Doc.SumRealiz + tbl_Doc.SumNalog + tbl_Doc.SumPeni)/1000)


--ORDER BY tblAbn.Code
)


GO


