<Query Kind="Statements">
  <Connection>
    <ID>72825ff0-ff37-4a83-82d0-fdba997c33a2</ID>
    <Persist>true</Persist>
    <Server>ulges-sql2</Server>
    <Database>GES</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// ТП-1011
	int IdMeasurement = 21677;
	int IdTransformer = 964048;
	int IdBus=1151151;
	var dbo_fn_J_MeasTransfPassport = fn_J_MeasTransfPassport(IdTransformer).ToList();
	//
	//
	var s = VJ_MeasCableReport2//.Take(100)
	.Where(v=> v.IdMeasurement == IdMeasurement & v.IdTransf == IdTransformer & v.IdBus == IdBus)
	.GroupBy(row => new
	             {
	                 id = ((row.Id != null) ? row.Id : -1),
	                 idMeasurement = ((row.IdMeasurement != null) ? row.IdMeasurement : -1),
	                 idBus = ((row.IdBus != null) ? row.IdBus : -1),
	                 idTransf = ((row.IdTransf != null) ? row.IdTransf : -1),
	                 idCell = ((row.IdCell != null) ? row.IdCell : -1),
	                 CellName = ((row.CellName != null) ? row.CellName : ""),
	                 idCable = ((row.IdCable != null) ? row.IdCable : -1),
	                 idSchmAbn = ((row.IdSchmAbn != null) ? row.IdSchmAbn : -1),
	                 Makeup = ((row.Makeup != null) ? row.Makeup : ""),
	                 Voltage = ((row.Voltage != null) ? row.Voltage : -1),
	                 Wires = ((row.Wires != null) ? row.Wires : -1),
	                 CrossSection = Convert.ToDouble((row.CrossSection != null) ? row.CrossSection : 0),
	                 PermisAmperage = Convert.ToDouble((row.PermisAmperage != null) ? row.PermisAmperage : 0),
	                 Iad = ((row.Iad != null) ? row.Iad : -1),
	                 Ian = ((row.Ian != null) ? row.Ian : -1),
	                 Ibd = ((row.Ibd != null) ? row.Ibd : -1),
	                 Ibn = ((row.Ibn != null) ? row.Ibn : -1),
	                 Icd = ((row.Icd != null) ? row.Icd : -1),
	                 Icn = ((row.Icn != null) ? row.Icn : -1),
	                 Iod = ((row.Iod != null) ? row.Iod : -1),
	                 Ion = ((row.Ion != null) ? row.Ion : -1),
	                 Comment = ((row.Comment != null) ? row.Comment : "")
	             })
	.Select(g => new
	             {
	                 id = g.Key.id,
	                 idMeasurement = g.Key.idMeasurement,
	                 idBus = g.Key.idBus,
	                 idCell = g.Key.idCell,
	                 CellName = g.Key.CellName,
	                 idCable = g.Key.idCable,
	                 Address = "",//this.GetAddress(this.dsMeasurementN.vJ_MeasCableReport2, (g.Key.idCell == DBNull.Value) ? -1 : ((int)g.Key.idCell), (g.Key.idCable == DBNull.Value) ? -1 : ((int)g.Key.idCable)),
	                 idSchmAbn = g.Key.idSchmAbn,
	                 Makeup = g.Key.Makeup,
	                 Voltage = g.Key.Voltage,
	                 Wires = g.Key.Wires,
	                 CrossSection = g.Key.CrossSection,
	                 PermisAmperage = g.Key.PermisAmperage,
	                 Iad = g.Key.Iad,
	                 Ian = g.Key.Ian,
	                 Ibd = g.Key.Ibd,
	                 Ibn = g.Key.Ibn,
	                 Icd = g.Key.Icd,
	                 Icn = g.Key.Icn,
	                 Iod = g.Key.Iod,
	                 Ion = g.Key.Ion
	             }
	             ).Dump()	;

				var enumerable1 = s.Where(row => ((int)row.Iad) != -1);
	            var enumerable2 = s.Where(row => ((int)row.Ian) != -1);
	            var enumerable3 = s.Where(row => ((int)row.Ibd) != -1);
	            var enumerable4 = s.Where(row => ((int)row.Ibn) != -1);
	            var enumerable5 = s.Where(row => ((int)row.Icd) != -1);
	            var enumerable6 = s.Where(row => ((int)row.Icn) != -1);
	            var enumerable7 = s.Where(row => ((int)row.Iod) != -1);
	            var enumerable8 = s.Where(row => ((int)row.Ion) != -1);
	         
			    decimal num1 = (enumerable1.Count() > 0) ? enumerable1.Sum(row => ((int)row.Iad)) : 0;
	            decimal num2 = (enumerable2.Count() > 0) ? enumerable2.Sum(row => ((int)row.Ian)) : 0;
	            decimal num3 = (enumerable3.Count() > 0) ? enumerable3.Sum(row => ((int)row.Ibd)) : 0;
	            decimal num4 = (enumerable4.Count() > 0) ? enumerable4.Sum(row => ((int)row.Ibn)) : 0;
	            decimal num5 = (enumerable5.Count() > 0) ? enumerable5.Sum(row => ((int)row.Icd)) : 0;
	            decimal num6 = (enumerable6.Count() > 0) ? enumerable6.Sum(row => ((int)row.Icn)) : 0;
	            decimal num7 = (enumerable7.Count() > 0) ? enumerable7.Sum(row => ((int)row.Iod)) : 0;
	            decimal num8 = (enumerable8.Count() > 0) ? enumerable8.Sum(row => ((int)row.Ion)) : 0;
	


				
	            //decimal num9 = 0;// new decimal();
	            //decimal num10 = 0;// new decimal();
	            decimal num11 = Math.Round(((num1 + num3 + num5) / 3), 0);
	            decimal num12 = Math.Round(((num2 + num4 + num6) / 3), 0);	
	/************************************************************/
	decimal num13 = (decimal)dbo_fn_J_MeasTransfPassport[0].Inom;
	// decimal num13 = dbo_fn_J_MeasTransfPassport.Count > 0 ? ((decimal)dbo_fn_J_MeasTransfPassport[0].Inom) : 0;
	// decimal num13 = (dbo_fn_J_MeasTransfPassport.Count > 0 && dbo_fn_J_MeasTransfPassport[0].Inom is decimal) ? ((decimal)dbo_fn_J_MeasTransfPassport[0].Inom) : 0;
	// decimal num13 = (dbo_fn_J_MeasTransfPassport.Count <= 0 ||  !(dbo_fn_J_MeasTransfPassport[0].Inom is decimal) ? 0 : ((decimal)dbo_fn_J_MeasTransfPassport[0].Inom); 
	// decimal num13 = decimal.Parse(dbo_fn_J_MeasTransfPassport[0].Inom.ToString().Length == 0 ? "0" :  dbo_fn_J_MeasTransfPassport[0].Inom.ToString());
	/***************************************************/
	        decimal num14 = (num13 != 0) ? Math.Round((num11 / (num13 / 100)), 0) : 0;
            decimal num15 = (num13 != 0) ? Math.Round((num12 / (num13 / 100)), 0) : 0;
            decimal num16 = Math.Max(Math.Max(Math.Abs(num1 - num3), Math.Abs(num1 - num5)), Math.Abs(num3 - num5));
//            if ((num1 + num3 + num5) != 0)
//            {
//                num9 = Math.Round((num16 / ((num1 + num3 + num5) / 100)), 0);
//            }
			decimal num9 = ((num1 + num3 + num5) != 0)? Math.Round((num16 / ((num1 + num3 + num5) / 100)), 0) : 0;
            decimal num17 = Math.Max(Math.Max(Math.Abs(num2 - num4), Math.Abs(num2 - num6)), Math.Abs(num4 - num6));
//            if ((num2 + num4 + num6) != 0)
//            {
//                num10 = Math.Round((num17 / ((num2 + num4 + num6) / 100)));
//            }
			decimal num10 =  ((num2 + num4 + num6) != 0) ? Math.Round((num17 / ((num2 + num4 + num6) / 100))) : 0;
			//////////////////////////////////////////////////
	num1.Dump();
	num2.Dump(); num3.Dump(); num4.Dump(); num5.Dump(); num6.Dump(); num7.Dump(); num8.Dump(); num11.Dump(); num12.Dump(); num14.Dump(); num15.Dump();
            num9.Dump(); num10.Dump();	
			//Console.WriteLine("111");