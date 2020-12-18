select t.year '��� ������'
	   --,sub.Id AS idSub
	   --, '��� ������' '������� �����������'
	   , csub.SocrName + '-' + sub.Name AS '����������'
	   --, '6-10/0,4 ��' '����� ����������'
	   , pa1.[CharValue] '��� ����� � ������������'
	   --, ''  '(��� ��������� ������������� ��������)'
	   --, tr.Id AS idTransf
	   , tr.Name AS NameTransf
	   --, ref.Power '���������� ���������� �������� ���������������� ��������, ���'
	   , Cast(ref.Power as float)/1000 '���������� ���������� �������� ���������������� ��������, ���'
	   --, 0 '����������� �������� �� ����� �� ������������� ��, ���'-- ��� ������ ����� ���������������� ������� �� ���������������
	   , t.Isr '������������ �������� �� ����� ������ ��������� ���, �' --IMax
	   , round(t.Isr*0.4*sqrt(3),0) '����������� �������� �� ����� ������ ��������� ���, ��'
FROM dbo.tSchm_ObjList AS sub 
		LEFT JOIN  dbo.tR_Classifier AS csub ON sub.TypeCodeId = csub.Id
		LEFT JOIN  (Select   m1.Year, m1.idObjList, m1.idTransf, round( (cast((MAX(m1.Ia) + MAX(m1.Ib) + MAX(m1.Ic)) as float))/3,0) AS Isr--(MAX(m1.Ia) + MAX(m1.Ib) + MAX(m1.Ic)) / 3 AS Isr /*�������� ����. �����*/
							From 
						      /*������ ������*/
							 (SELECT   m.Year, m.idObjList, mc.idTransf, SUM(mc.Ian) AS Ia, SUM(mc.Ibn) AS Ib, SUM(mc.Icn) AS Ic
                               FROM            dbo.tJ_Measurement AS m LEFT JOIN
                                                         dbo.tJ_MeasCable AS mc ON m.id = mc.idMeasurement AND mc.Deleted = 0
                               WHERE    (m.TypeDoc = 1191) AND (m.Deleted = 0)
                               GROUP BY m.Year,m.idObjList, mc.idTransf
                               UNION ALL
							   /*������� ������*/
                               SELECT    m.Year,    m.idObjList, mc.idTransf, SUM(mc.Iad) AS Ia, SUM(mc.Ibd) AS Ib, SUM(mc.Icd) AS Ic
                               FROM            dbo.tJ_Measurement AS m LEFT JOIN
                                                        dbo.tJ_MeasCable AS mc ON m.id = mc.idMeasurement AND mc.Deleted = 0
                               WHERE    (m.TypeDoc = 1191) AND (m.Deleted = 0)
                               GROUP BY m.Year, m.idObjList, mc.idTransf) AS m1 
							   --where m1.idObjList = 777325
							   group by m1.Year, m1.idObjList, m1.idTransf
							   --order by m1.Year
						)	t ON t.idObjList = sub.Id
		LEFT JOIN  dbo.tSchm_ObjList AS tr ON tr.Id = t.idTransf
		LEFT JOIN (SELECT [Id]       ,[IdPassport]      ,[TransfName]      ,[Type]      ,CASE Power WHEN '' THEN '0' WHEN NULL   THEN '0' ELSE Power END AS Power
						FROM [GES].[dbo].[vJ_MeasTransfPassport]) ref ON tr.Id = ref.Id
		-----------
		left join vP_PassportDataReports as pa on  pa.[IdObj] =sub.id and pa.typecodeid in (538,535,537,536) and pa.[CharName] like '��������������'
		left join vP_PassportDataReports as pa1 on  pa1.[IdObj] =sub.id and pa1.typecodeid in (538,535,537,536) and pa1.[CharName] like '��� ����� � ������������'

where  csub.ParentKey = ';SCM;PS;' AND csub.Value IN (2, 4) AND tr.TypeCodeId = 556 and tr.Name NOT LIKE '%��%'
and pa.[CharValue] = '����������'
-- and t.year = '2010'
and sub.id = 777325
and t.Year is  not null
and csub.SocrName + '-' + sub.Name is not null
order by t.year, sub.id
