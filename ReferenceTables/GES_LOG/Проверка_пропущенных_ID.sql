/*

Как выбрать пропущеные ID?

*/
SELECT id1+1 start_interval, id2-1 finish_interval
FROM(
  SELECT 
    MAX(CASE WHEN dN=1 THEN Id END)id1,
    MAX(CASE WHEN dN=0 THEN Id END)id2
  FROM(
    SELECT ROW_NUMBER()OVER(ORDER BY Id)as N, Id
    FROM [GES_log].[dbo].[tL_SchmAbn]
  )T1 , ( SELECT 0 as dN UNION ALL SELECT 1 )T2
  GROUP BY N+dN
)T
WHERE Id1+1 <> Id2