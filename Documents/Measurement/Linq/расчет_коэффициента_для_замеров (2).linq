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
//	int IdMeasurement = 21677; //21601
//	int IdTransformer = 964048;//964922
//	int IdBus=1151151;//1110509
// ТП-1021
//	int IdMeasurement = 21601;
//	int IdTransformer = 964922;
//	int IdBus = 1110509;
// ТП - 5042
	int IdMeasurement = 21928;
	int IdTransformer = 804203;
	int IdBus = 945131;
// ТП-1026 - проверить, у него два замера за один период

	var dbo_fn_J_MeasTransfPassport = fn_J_MeasTransfPassport(IdTransformer).ToList();
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
	                 Iad = ((row.Iad != null) ? row.Iad : 0),
	                 Ian = ((row.Ian != null) ? row.Ian : 0),
	                 Ibd = ((row.Ibd != null) ? row.Ibd : 0),
	                 Ibn = ((row.Ibn != null) ? row.Ibn : 0),
	                 Icd = ((row.Icd != null) ? row.Icd : 0),
	                 Icn = ((row.Icn != null) ? row.Icn : 0),
	                 Iod = ((row.Iod != null) ? row.Iod : 0),
	                 Ion = ((row.Ion != null) ? row.Ion : 0),
	                 Comment = ((row.Comment != null) ? row.Comment : "")
	             })
	.Select(g => new
	             {
	                 id = g.Key.id,
	                 idMeasurement = g.Key.idMeasurement,
	                 idBus = g.Key.idBus,
					 idTransf = g.Key.idTransf,
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
	             );//.AsEnumerable()	;

// var I =  (s.Where(row => ((int)row.Iad) != -1)).Sum(row => ((int)row.Iad));
//группировка должна быть по замеру
// будем считать что есть только одна запись
// один замер и один рубильник
var res = s.GroupBy(row => new {row.idMeasurement, row.idBus, row.idTransf})
			.Select(q => new {Iad = q.Sum(row => row.Iad), Ian = q.Sum(row => row.Ian),Ibd = q.Sum(row => row.Ibd),Ibn = q.Sum(row => row.Ibn),
								Icd = q.Sum(row => row.Icd),Icn = q.Sum(row => row.Icn),Iod = q.Sum(row => row.Iod),Ion = q.Sum(row => row.Ion)})
			.ToArray();		

				decimal num1 = (decimal)res[0].Iad;
				decimal num2 = (decimal)res[0].Ian;
				decimal num3 = (decimal)res[0].Ibd;
				decimal num4 = (decimal)res[0].Ibn;
				decimal num5 = (decimal)res[0].Icd;
				decimal num6 = (decimal)res[0].Icn;
				decimal num7 = (decimal)res[0].Iod;
				decimal num8 = (decimal)res[0].Ion;

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
			decimal num9 = ((num1 + num3 + num5) != 0)? Math.Round((num16 / ((num1 + num3 + num5) / 100)), 0) : 0;
            decimal num17 = Math.Max(Math.Max(Math.Abs(num2 - num4), Math.Abs(num2 - num6)), Math.Abs(num4 - num6));
			decimal num10 =  ((num2 + num4 + num6) != 0) ? Math.Round((num17 / ((num2 + num4 + num6) / 100))) : 0;
			//////////////////////////////////////////////////
       Console.WriteLine("Iad =" + num1 + "; Ian =" + num2 + "; Ibd =" + num3 + "; Ibn =" + num4 + "; Icd =" + num5 + "; Icn =" + num6 + "; Iod =" + num7 + "; Ion =" +  num8);
	   Console.WriteLine("Icpd =" + num11 + "; Icpn =" + num12 + "; Kzd =" + num14 + "; Kzn =" + num15 + "; Kfd =" + num9 + "; Kfn =" + num10);