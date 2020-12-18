<Query Kind="Statements">
  <Connection>
    <ID>72825ff0-ff37-4a83-82d0-fdba997c33a2</ID>
    <Persist>true</Persist>
    <Server>ulges-sql2</Server>
    <Database>GES</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//VJ_CoefficientLoading
//.Where(v => v.IdMeasurement == 21677);

// для листка замеров
// VJ_MeasCableReport2
// для анализа коэффициента загрузки
var coef = VJ_CoefficientLoading;
var rep = VJ_MeasCableReport2;
var dt = TJ_Measurements;
//	int IdMeasurement = 21928;
//	int IdTransformer = 804203;
//	int IdBus = 945131;
//
//var res2 = from c in VJ_CoefficientLoading
//			join v in VJ_MeasCableReport2 on new {c.IdMeasurement , c.IdBus , c.IdTransf}  equals new {v.IdMeasurement , v.IdBus , v.IdTransf} into gr
//			from ss in gr.DefaultIfEmpty()
//			where c.Year == 2016 //& ss.IdMeasurement == IdMeasurement & ss.IdTransf == IdTransformer & ss.IdBus == IdBus
//			select new{c, ss};
//
//	res2.Dump();
	
//var res3 = 	VJ_CoefficientLoading 
//	.Where (v => v.Year == 2017 & v.IdMeasurement == IdMeasurement & v.IdTransf == IdTransformer & v.IdBus == IdBus)
//	
//	.GroupJoin (
//      VJ_MeasCableReport2, 
//      c =>  new   { IdMeasurement = c.IdMeasurement,  IdBus = c.IdBus, IdTransf = c.IdTransf    }, 
//      v =>  new   { IdMeasurement = v.IdMeasurement,  IdBus = v.IdBus, IdTransf = v.IdTransf     }, 
//      (c, gr) =>   new   
//				{
//					c = c, 
//		            gr = gr
//		         }
//   ).DefaultIfEmpty()
//  ;
// 
//   res3.Dump();
//
// вариант 1

//////	var dtCoefficient = VJ_MeasCableReport2//.Take(100)
//////	//.Where(v=> v.IdMeasurement == IdMeasurement & v.IdTransf == IdTransformer & v.IdBus == IdBus)
//////	// Сначало получаем сгруппированные данные
//////	// повторяются -> даже значения
//////	.GroupBy(row => new
//////	             {
//////	                 idMeasurement = ((row.IdMeasurement != null) ? row.IdMeasurement : -1),
//////	                 idBus = ((row.IdBus != null) ? row.IdBus : -1),
//////	                 idTransf = ((row.IdTransf != null) ? row.IdTransf : -1),
//////					 Iad = ((row.Iad != null) ? row.Iad : 0),	                 Ian = ((row.Ian != null) ? row.Ian : 0),
//////	                 Ibd = ((row.Ibd != null) ? row.Ibd : 0),	                 Ibn = ((row.Ibn != null) ? row.Ibn : 0),
//////	                 Icd = ((row.Icd != null) ? row.Icd : 0),	                 Icn = ((row.Icn != null) ? row.Icn : 0),
//////	                 Iod = ((row.Iod != null) ? row.Iod : 0),	                 Ion = ((row.Ion != null) ? row.Ion : 0)
//////	             })
//////	.Select(g => new
//////	             {
//////	                 idMeasurement = g.Key.idMeasurement,
//////	                 idBus = g.Key.idBus,
//////					 idTransf = g.Key.idTransf,
//////	                 Iad = g.Key.Iad,	                 Ian = g.Key.Ian,	                 Ibd = g.Key.Ibd,	                 Ibn = g.Key.Ibn,
//////	                 Icd = g.Key.Icd,	                 Icn = g.Key.Icn,	                 Iod = g.Key.Iod,	                 Ion = g.Key.Ion
//////	             }
//////				 )
//////	// Здесь суммируем токи
//////				.GroupBy(row => new {row.idMeasurement, row.idBus, row.idTransf})
//////				.Select(q => new {
//////					idMeasurement = q.Key.idMeasurement, 			idBus = q.Key.idBus, 							idTransf = q.Key.idTransf,
//////					Iad = q.Sum(row => row.Iad), 					Ian = q.Sum(row => row.Ian),					Ibd = q.Sum(row => row.Ibd),
//////					Ibn = q.Sum(row => row.Ibn),					Icd = q.Sum(row => row.Icd),					Icn = q.Sum(row => row.Icn),
//////					Iod = q.Sum(row => row.Iod),					Ion = q.Sum(row => row.Ion)
//////					,Inom = fn_J_MeasTransfPassport(q.Key.idTransf).First().Inom
//////					})
//////// Расчет коэффициентов
//////	.Select(q => new {//q,
//////		idMeasurement = q.idMeasurement, 			idBus = q.idBus, 							idTransf = q.idTransf,
//////		Iad = q.Iad,	Ian = q.Ian,	Ibd = q.Ibd, 
//////		Ibn = q.Ibn,	Icd = q.Icd,	Icn = q.Icn,
//////		Iod = q.Iod,	Ion = q.Ion,
//////		Inom = q.Inom,
//////		Icpd = Math.Round(((decimal)q.Iad + (decimal)q.Ibd + (decimal)q.Icd) / 3, MidpointRounding.AwayFromZero),
//////		Icpn = Math.Round(((decimal)q.Ian + (decimal)q.Ibn + (decimal)q.Icn) / 3, MidpointRounding.AwayFromZero),
//////		num16 = Math.Max(Math.Max(Math.Abs((decimal)q.Iad  - (decimal)q.Ibd), Math.Abs((decimal)q.Iad  - (decimal)q.Icd)), Math.Abs((decimal)q.Ibd - (decimal)q.Icd)),
//////		num17 = Math.Max(Math.Max(Math.Abs((decimal)q.Ian - (decimal)q.Ibn), Math.Abs((decimal)q.Ian - (decimal)q.Icn)), Math.Abs((decimal)q.Ibn - (decimal)q.Icn))
//////		})
//////	.Select(q => new{
//////			q, 
//////			Kzd = (q.Inom != 0) ? Math.Round(((decimal)q.Icpd / ((decimal)q.Inom / 100)), MidpointRounding.AwayFromZero) : 0,
//////			Kzn = (q.Inom != 0) ? Math.Round(((decimal)q.Icpn / ((decimal)q.Inom / 100)), MidpointRounding.AwayFromZero) : 0,
//////			Kfd =  (((decimal)q.Iad + (decimal)q.Ibd + (decimal)q.Icd) != 0)? Math.Round((q.num16 / (((decimal)q.Iad + (decimal)q.Ibd + (decimal)q.Icd) / 100)), MidpointRounding.AwayFromZero) : 0,
//////			Kfn =  (((decimal)q.Ian + (decimal)q.Ibn + (decimal)q.Icn) != 0) ? Math.Round((q.num17 / (((decimal)q.Ian + (decimal)q.Ibn + (decimal)q.Icn) / 100)), MidpointRounding.AwayFromZero) : 0
//////			});
//////	dtCoefficient.Dump();
/********************************************************************************************************/	
// Попытка убрать повотрряющиеся значения в первой части запроса
//	int IdMeasurement = 21928;
//	int IdTransformer = 804203;
//	int IdBus = 945131;
	int IdMeasurement = 23714;
	int IdTransformer = 965030;
	int IdBus = 1160211;
	// расчет коэффициентов   
	var dtCoefficientCalc = VJ_MeasCableReport2
	//.Where(v=> v.IdMeasurement == IdMeasurement & v.IdTransf == IdTransformer & v.IdBus == IdBus)
	.Select(row => new{	                 
					idMeasurement = ((row.IdMeasurement != null) ? row.IdMeasurement : -1),
	                idBus = ((row.IdBus != null) ? row.IdBus : -1),
	                idTransf = ((row.IdTransf != null) ? row.IdTransf : -1),
   
					Iad = row.Iad ?? 0,	                 Ian = row.Ian ?? 0,
	                Ibd = row.Ibd ?? 0,	                 Ibn = row.Ibn ?? 0,
	                Icd = row.Icd ?? 0,	                 Icn = row.Icn ?? 0,
	                Iod = row.Iod ?? 0,	                 Ion = row.Ion ?? 0})
	.Distinct()
	.GroupBy(row => new {row.idMeasurement, row.idBus, row.idTransf})
	.Select(q => new {
					idMeasurement = q.Key.idMeasurement, 			idBus = q.Key.idBus, 							idTransf = q.Key.idTransf,
					Iad = q.Sum(row => row.Iad), 					Ian = q.Sum(row => row.Ian),					Ibd = q.Sum(row => row.Ibd),
					Ibn = q.Sum(row => row.Ibn),					Icd = q.Sum(row => row.Icd),					Icn = q.Sum(row => row.Icn),
					Iod = q.Sum(row => row.Iod),					Ion = q.Sum(row => row.Ion)
					//,Inom = fn_J_MeasTransfPassport(q.Key.idTransf).Select(row=>row.Inom).First()
					//,PowerN = fn_J_MeasTransfPassport(q.Key.idTransf).First().Power,
					//Inom = fn_J_MeasTransfPassport(q.Key.idTransf).First().Inom
					//,param = fn_J_MeasTransfPassport(q.Key.idTransf).First()
					,param = VJ_MeasTransfPassportN.Where(r => (int)r.Id == (int)q.Key.idTransf).First()
					})
	.Select(qqc1 => new {
		// qqc1,
		idMeasurement = qqc1.idMeasurement, 			idBus = qqc1.idBus, 							idTransf = qqc1.idTransf,
		// PowerN = qqc1.param.Power,
		Iad = qqc1.Iad,	Ian = qqc1.Ian,	Ibd = qqc1.Ibd, 
		Ibn = qqc1.Ibn,	Icd = qqc1.Icd,	Icn = qqc1.Icn,
		//Iod = qqc1.Iod,	Ion = qqc1.Ion,
		Inom = qqc1.param.Inom,
		Icpd = Math.Round(((decimal)qqc1.Iad + (decimal)qqc1.Ibd + (decimal)qqc1.Icd) / 3, MidpointRounding.AwayFromZero),
		Icpn = Math.Round(((decimal)qqc1.Ian + (decimal)qqc1.Ibn + (decimal)qqc1.Icn) / 3, MidpointRounding.AwayFromZero),
		num16 = Math.Max(Math.Max(Math.Abs((decimal)qqc1.Iad  - (decimal)qqc1.Ibd), Math.Abs((decimal)qqc1.Iad  - (decimal)qqc1.Icd)), Math.Abs((decimal)qqc1.Ibd - (decimal)qqc1.Icd)),
		num17 = Math.Max(Math.Max(Math.Abs((decimal)qqc1.Ian - (decimal)qqc1.Ibn), Math.Abs((decimal)qqc1.Ian - (decimal)qqc1.Icn)), Math.Abs((decimal)qqc1.Ibn - (decimal)qqc1.Icn))
		})
	.Select(q => new{
			//q, 
			
			idMeasurement = q.idMeasurement, 			idBus = q.idBus, 							idTransf = q.idTransf,
			// PowerN = fn_J_MeasTransfPassport(q.idTransf).First().Power,
			// PowerN = q.qqc1.param.Power,
			// PowerN = q.PowerN,
			Kzd = (q.Inom != 0) ? Math.Round(((decimal)q.Icpd / ((decimal)q.Inom / 100)), MidpointRounding.AwayFromZero) : 0,
			Kzn = (q.Inom != 0) ? Math.Round(((decimal)q.Icpn / ((decimal)q.Inom / 100)), MidpointRounding.AwayFromZero) : 0,
			Kfd =  (((decimal)q.Iad + (decimal)q.Ibd + (decimal)q.Icd) != 0)? Math.Round((q.num16 / (((decimal)q.Iad + (decimal)q.Ibd + (decimal)q.Icd) / 100)), MidpointRounding.AwayFromZero) : 0,
			Kfn =  (((decimal)q.Ian + (decimal)q.Ibn + (decimal)q.Icn) != 0) ? Math.Round((q.num17 / (((decimal)q.Ian + (decimal)q.Ibn + (decimal)q.Icn) / 100)), MidpointRounding.AwayFromZero) : 0
			});

//dtCoefficientCalc.Where(v=> v.idMeasurement == IdMeasurement /*& v.idTransf == IdTransformer & v.idBus == IdBus*/).Dump();
/***************Вывод отчета******************/
/******************не выгружается мощность трансформатора?***************************/
var res4 = 	VJ_CoefficientLoading 
//	.Where (v =>   v.IdMeasurement == IdMeasurement & v.IdTransf == IdTransformer & v.IdBus == IdBus)
	.Where(v => v.Year == 2017)
	.GroupJoin (
      dtCoefficientCalc, 
      c =>  new   { IdMeasurement = c.IdMeasurement,  IdBus = c.IdBus, IdTransf = c.IdTransf }, 
      //v =>  new   { IdMeasurement = v.q.idMeasurement,  IdBus = v.q.idBus, IdTransf = v.q.idTransf }, 
	  v =>  new   { IdMeasurement = v.idMeasurement,  IdBus = v.idBus, IdTransf = v.idTransf }, 
      (c, grp) =>   new   
				{
					c.NetRegion, c.IdNetRegion,  c.Year, c.SSSocrName, c.Substation, c.Transformer,// c.Power,
					Power = fn_J_MeasTransfPassport(c.IdTransf).First().Power,//grp.FirstOrDefault().PowerN, 
					Kzd = grp.Count() == 0 ? 0 : grp.FirstOrDefault().Kzd,
					Kzn = grp.Count() == 0 ? 0 : grp.FirstOrDefault().Kzn,
					Kfd = grp.Count() == 0 ? 0 : grp.FirstOrDefault().Kfd,
					Kfn = grp.Count() == 0 ? 0 : grp.FirstOrDefault().Kfn,
//					grp,
//					list = grp.Select(ss => ss.q) ,
//					coeff = grp.Select(ss =>  new {ss.Kzd,ss.Kzn,ss.Kfd,ss.Kfn})
//					cKzd = grp.Select(ss =>  ss.Kzd).ToList()[0],
//					cKzn = grp.Select(ss =>  ss.Kzn).ToList()[0],
//					cKfd = grp.Select(ss =>  ss.Kfd).ToList()[0],
//					cKfn = grp.Select(ss =>  ss.Kfn).ToList()[0],
//count = grp.Count()
		         }
   )//.DefaultIfEmpty()
   .OrderBy (s => s.Substation)
   .ThenBy (s => s.Transformer)
   .ThenBy (s => s.Year)
;
 
   res4
 //.Where(v=>v.Substation == "ТП-3474")
   .Dump();
   
var res6 = from c in VJ_CoefficientLoading
			join v in dtCoefficientCalc on new   { IdMeasurement = c.IdMeasurement,  IdBus = c.IdBus, IdTransf = c.IdTransf }  equals 
				//new { IdMeasurement = v.q.idMeasurement,  IdBus = v.q.idBus, IdTransf = v.q.idTransf } into grp
				new { IdMeasurement = v.idMeasurement,  IdBus = v.idBus, IdTransf = v.idTransf } into grp
			from ss in grp.DefaultIfEmpty()
			where c.Year == 2017// & c.IdMeasurement == IdMeasurement & c.IdTransf == IdTransformer & c.IdBus == IdBus
			orderby c.Substation, c.Transformer,  c.Year
			select new {c.NetRegion, c.IdNetRegion,  c.Year, c.SSSocrName, c.Substation, c.Transformer, //c.Power, 
			//PowerN = ss == null ? null : ss.PowerN, 
			Power = fn_J_MeasTransfPassport(c.IdTransf).First().Power,
			Kzd = ss == null ? 0 : ss.Kzd,
			Kzn = ss == null ? 0 : ss.Kzn,
			Kfd = ss == null ? 0 : ss.Kfd,
			Kfn = ss == null ? 0 : ss.Kfn,
//			ss.Kzd, ss.Kzn, ss.Kfd, ss.Kfn
//c.IdMeasurement,c.IdBus,c.IdTransf
			};

res6
//.Where(v=>v.Substation == "ТП-3474")
.Dump();
//                string str = string.Join(",", (from r in dtCoefficientCalc
//                                                select r.Field<int>("idMeasurement").ToString()).ToArray<string>());
            var stridMeasurement = string.Join(",", (from r in VJ_CoefficientLoading.AsEnumerable()
where r.Year == 2017
select r.IdMeasurement.ToString()).ToArray<string>());
			stridMeasurement.Dump();
			//dtCoefficientCalc.Select(r => r.idTransf).Distinct ().ToArray<string>().Dump();
 string stridTransf = string.Join(",", ((from r in VJ_CoefficientLoading.AsEnumerable()
where r.Year == 2017
select r.IdTransf.ToString()
).Distinct())
                                                   .ToArray<string>()
												   );
			 stridTransf.Dump();
//			//if (!string.IsNullOrEmpty(str)) -- если пустое значение