using DataSql;
using Documents.DataSets;
using FormLbr;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
//FormReportSheetMeasuring
namespace Documents.Forms.Measurement
{
    internal partial class FormMeasurementReports : FormBase
    {

        //private bool IsPowerLarge;

        //private bool bool_1;

        //private bool bool_2;

        //private bool bool_3;

        //private DataSetMeasurementN dsMeasurementN;

        public decimal Factor
        {
            get;
            set;
        }

  

        public int IdMeasurement
        {
            get;
            set;
        }
        //private int IdMeasurement;
        //internal void method_3(int id)
        //{
        //    this.IdMeasurement = id;
        //}
        //internal int method_2()
        //{
        //    return this.IdMeasurement;
        //}

        //private int int_1;

        //private int IdMeasTransfAmperage;

        //private int int_3;

        //private int int_4;

        //private int int_5;

        //private int int_6;

        public int IdNetworkAreas
        {
            get;
            set;
        }

        //private int PowerTransf;

        public int Year
        {

            get;
            //{
            //    return this.int_6;
            //}

            set;
            //{
            //    this.int_6 = value;
            //}
        }

        public int IdMeasTransfAmperage
        {
            get;
            set;
        }
        private int IdTransformer
        {
            get;
            set;
        }
        public int PowerTransf
        {
            get;
            set;
        }
        public bool IsPowerLarge
        {
            get;
            set;
        }
        public bool IsNight { get; set; }
        public int IdMeasTransfVoltage
        {
            get;
            set;
        }
        public bool IsDay
        {
            get;
            set;
        }
        public bool IsCoefficientLarge { get; set; }
        public decimal CoefficientLoading
        { get; set; }
        public int IdBus
        {
            get;
            set;
        }
        public ReportType TypeReport
        {
            get;
            set;
        }

        //private int IdMeasTransfAmperage;
        //internal int method_6()
        //{
        //    return this.IdMeasTransfAmperage;
        //}

        //internal void method_7(int int_9)
        //{
        //    this.IdMeasTransfAmperage = int_9;
        //}

        //internal void method_9(int int_9)
        //{
        //    this.int_3 = int_9;
        //}

        internal FormMeasurementReports()
        {
            this.InitializeComponent();
        }

        internal FormMeasurementReports(SQLSettings sqlsettings, int year, int idNetworkAreas, decimal factor)
        {
            this.InitializeComponent();
            this.SqlSettings = (sqlsettings);
            this.Year = year;
            this.IdNetworkAreas = (idNetworkAreas);
            this.Factor = (factor);
            this.TypeReport = (ReportType.ExcelessLoad);
        }

        internal FormMeasurementReports(SQLSettings sqlsettings, ReportType typeReport, int idMeasurement, int idTransf, int idMeasTransf)
        {
            this.InitializeComponent();
            this.SqlSettings = (sqlsettings);
            this.TypeReport = (typeReport);
            this.IdMeasurement = (idMeasurement);
            this.IdTransformer = (idTransf);
            //if (typeReport != ReportType.MeasurementLowVoltage)//0
            //{
            //    if (typeReport == ReportType.MeasurementHighVoltage)//2
            //    {
            //        this.method_7(idMeasTransf);
            //    }
            //}
            //else
            //{
            //    this.method_5(idMeasTransf);
            //}

            switch (typeReport)
            {
                case ReportType.MeasurementHighVoltage://2
                    this.IdMeasTransfAmperage = (idMeasTransf);
                    break;
                case ReportType.MeasurementLowVoltage://0
                    this.IdMeasTransfVoltage = (idMeasTransf);
                    break;
                default:
                    break;
            }
        }

        internal FormMeasurementReports(SQLSettings sqlsettings, ReportType typeReport, int idMeasurement, int idBus, int idTransf = -1, int idMeasTransf = -1)
        {
            this.InitializeComponent();
            this.SqlSettings = sqlsettings;
            this.TypeReport = (typeReport);
            this.IdMeasurement = (idMeasurement);
            this.IdBus = (idBus);
            this.IdTransformer = (idTransf);
            //if (typeReport != ReportType.MeasurementLowVoltage)
            //{
            //    if (typeReport == ReportType.MeasurementHighVoltage)
            //    {
            //        this.method_7(idMeasTransf);
            //    }
            //}
            //else
            //{
            //    this.method_5(idMeasTransf);
            //}
            switch (typeReport)
            {
                case ReportType.MeasurementHighVoltage://2
                    this.IdMeasTransfAmperage = (idMeasTransf);
                    break;
                case ReportType.MeasurementLowVoltage://0
                    this.IdMeasTransfVoltage = (idMeasTransf);
                    break;
                default:
                    break;
            }
        }

        internal FormMeasurementReports(SQLSettings sqlsettings, ReportType typeReport, int year, int idNetworkAreas, int powerTransf, bool isPowerLarge, decimal coeffLoading, bool isCoeffLarge, bool isDay, bool isNight)
        {
            this.InitializeComponent();
            this.SqlSettings = (sqlsettings);
            this.Year = year;
            this.IdNetworkAreas = (idNetworkAreas);
            this.PowerTransf = (powerTransf);
            this.IsPowerLarge = (isPowerLarge);
            this.CoefficientLoading = (coeffLoading);
            this.IsCoefficientLarge = (isCoeffLarge);
            this.IsDay = (isDay);
            this.IsNight = (isNight);
            this.TypeReport = (typeReport);
        }

        private void chbWitnName_CheckedChanged(object sender, EventArgs e)
        {
            this.CreateReport();
        }

        private void chbHideNameObj_CheckedChanged(object sender, EventArgs e)
        {
            this.CreateReport();
        }


        private void FormMeasurementReports_Load(object sender, EventArgs e)
        {
            this.CreateReport();
        }

        //private ReportType reportType;
        //internal ReportType method_0()
        //{
        //    return this.reportType;
        //}


        //internal void method_1(ReportType enum1)
        //{
        //    this.reportType = enum1;
        //}

        //private int IdBus;
        //internal int method_10()
        //{
        //    return this.IdBus;
        //}


        //internal void method_11(int int_9)
        //{
        //    this.IdBus = int_9;
        //}

        //idTransf

        //internal int method_12()
        //{
        //    return this.IdTransformer;
        //}


        //internal void method_13(int id)
        //{
        //    this.IdTransformer = id;
        //}


        //internal int method_14()
        //{
        //    return this.IdNetworkAreas;
        //}


        //internal void method_15(int id)
        //{
        //    this.IdNetworkAreas = id;
        //}


        //internal decimal method_16()
        //{
        //    return this.Factor;
        //}


        //internal void method_17(decimal id)
        //{
        //    this.Factor = id;
        //}

        //private int PowerTransf;
        //internal int method_18()
        //{
        //    return this.PowerTransf;
        //}


        //internal void method_19(int int_9)
        //{
        //    this.PowerTransf = int_9;
        //}



        //private bool IsPowerLarge;

        //internal bool method_20()
        //{
        //    return this.IsPowerLarge;
        //}


        //internal void method_21(bool bool_4)
        //{
        //    this.IsPowerLarge = bool_4;
        //}

        //internal decimal method_22()
        //{
        //    return this.CoefficientLoading;
        //}


        //internal void method_23(decimal decimal_2)
        //{
        //    this.CoefficientLoading = decimal_2;
        //}

        //internal bool method_24()
        //{
        //    return this.IsCoefficientLarge;
        //}
        //internal void method_25(bool bool_4)
        //{
        //    this.IsCoefficientLarge = bool_4;
        //}

        //private bool IsDay;
        //internal bool method_26()
        //{
        //    return this.IsDay;
        //}


        //internal void method_27(bool bool_4)
        //{
        //    this.IsDay = bool_4;
        //}

        //private bool bool_3;
        //internal bool method_28()
        //{
        //    return this.bool_3;
        //}


        //internal void method_29(bool bool_4)
        //{
        //    this.bool_3 = bool_4;
        //}

        private void CreateReport()
        {
            this.rpGeneral.Clear();
            this.rpGeneral.Reset();
            this.SetTextForm();
            string reportEmbeddedResource = this.GetReportURI(this.TypeReport);
            this.rpGeneral.LocalReport.ReportEmbeddedResource = reportEmbeddedResource;

            this.tableLayoutPanel1.RowStyles[0] = new RowStyle(SizeType.Absolute, (this.TypeReport == ReportType.MeasurementLowVoltage) ? 41 : 0);
            this.rpGeneral.LocalReport.DataSources.Clear();

            if ((this.TypeReport == ReportType.MeasurementLowVoltage) || (this.TypeReport == ReportType.MeasurementHighVoltage))
            {
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsMeasurement", this.GetMeasurementData()));
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsMeasTransfPassport", this.GetMeasTransfPassportData()));
            }
            if (this.TypeReport == ReportType.MeasurementLowVoltage)
            {
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsVoltageTransf", this.GetMeasTransfVoltageData()));
                if (this.chbWitnName.Checked)
                {
                    this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsMeasCable", this.GetMeasCableData()));
                }
                else
                {
                    this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsMeasCable", this.GetMeasCableDataWithoutName()));
                }
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsMeasCableRatio", this.GetMeasCableRatioData()));
            }
            if (this.TypeReport == ReportType.MeasurementLowVoltageSP)
            {
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsMeasurement", this.GetMeasurementData()));
                BindingSource dataSourceValue = this.GetMeasCableDataWithoutName();
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsMeasCable", dataSourceValue));
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsMeasCableRatio", this.GetMeasCableRatioData()));
            }
            if (this.TypeReport == ReportType.MeasurementHighVoltage)
            {
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsMeasTransfAmperage", this.GetMeasTransfAmperageData()));
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dtAddlData", this.GetMeasTransfAmperageAddlData()));
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsMeasCell", this.GetMeasCellData()));
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsMeasCellRatio", this.GetMeasCellRatioData()));
            }
            if (this.TypeReport == ReportType.ExcelessLoad)
            {
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsExcelessLoad", this.GetExcelessLoadData()));
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsAddl", this.GetExcelessLoadData()));
            }
            if (this.TypeReport == ReportType.CoefficientLoading)
            {
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsCoefficientLoading", this.GetCoefficientLoadingData()));
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsAddl", this.GetCoefficientAddlData()));
            }
            if (this.TypeReport == ReportType.CoefficientIrregularity)
            {
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsCoefficientIrregularity", this.GetCoefficientIrregularityData()));
                this.rpGeneral.LocalReport.DataSources.Add(new ReportDataSource("dsAddl", this.GetCoefficientAddlData()));
            }
            this.rpGeneral.RefreshReport();
        }

        private void SetTextForm()
        {
            switch (this.TypeReport)
            {
                case ReportType.MeasurementLowVoltage:
                    this.Text = "Отчет по замерам низкой стороны";
                    return;

                case ReportType.MeasurementLowVoltageSP:
                    break;

                case ReportType.MeasurementHighVoltage:
                    this.Text = "Отчет по замерам высокой стороны";
                    return;

                case ReportType.ExcelessLoad:
                    this.Text = "Превышение нагрузки";
                    return;

                case ReportType.CoefficientLoading:
                    this.Text = "Анализ коэффициента загрузки трансформаторов";
                    return;

                case ReportType.CoefficientIrregularity:
                    this.Text = "Анализ коэффициента неравномерности фаз";
                    return;

                case ReportType.TransformerBySubstation:
                    this.Text = "Трансформаторы по центрам питания";
                    break;

                default:
                    return;
            }
        }

        private string GetReportURI(ReportType type)
        {
            switch (type)
            {
                case ReportType.MeasurementLowVoltage:
                    if (!this.chbHideNameObj.Checked)
                    {
                        return "Documents.Forms.Measurement.ReportMeasLowVoltage.rdlc";
                    }
                    return "Documents.Forms.Measurement.ReportMeasLowVoltageWithOutNameObj.rdlc";

                case ReportType.MeasurementLowVoltageSP:
                    return "Documents.Forms.Measurement.ReportMeasLowVoltageSP.rdlc";

                case ReportType.MeasurementHighVoltage:
                    return "Documents.Forms.Measurement.ReportMeasHighVoltage.rdlc";

                case ReportType.ExcelessLoad:
                    return "Documents.Forms.Measurement.ReportExcelessLoad.rdlc";

                case ReportType.CoefficientLoading:
                    return "Documents.Forms.Measurement.ReportCoefficientLoading.rdlc";

                case ReportType.CoefficientIrregularity:
                    return "Documents.Forms.Measurement.ReportCoefficientIrregularity.rdlc";

                case ReportType.TransformerBySubstation:
                    return "Documents.Forms.Measurement.";
            }
            return "";
        }

        private BindingSource GetMeasurementData()
        {
            base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.vJ_MeasurementReport, true, "WHERE id = " + this.IdMeasurement.ToString());
            return new BindingSource { DataSource = this.dsMeasurementN.vJ_MeasurementReport };
        }

        private BindingSource GetMeasTransfPassportData()
        {
            string[] strTransf = new string[] { this.IdTransformer.ToString() };
            base.CallSQLTableValuedFunction(this.dsMeasurementN, this.dsMeasurementN.fn_J_MeasTransfPassport, "", strTransf);
            return new BindingSource { DataSource = this.dsMeasurementN.fn_J_MeasTransfPassport };
        }

        private BindingSource GetMeasTransfVoltageData()
        {
            base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.vJ_MeasTransfVoltage, true, string.Format("WHERE id = {0}", this.IdMeasTransfVoltage));
            return new BindingSource { DataSource = this.dsMeasurementN.vJ_MeasTransfVoltage };
        }

        private BindingSource GetMeasTransfAmperageData()
        {
            base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.tJ_MeasAmperageTransf, true, string.Format("WHERE id = {0}", this.IdMeasTransfAmperage));
            return new BindingSource { DataSource = this.dsMeasurementN.tJ_MeasAmperageTransf };
        }

        private BindingSource GetMeasCableData()
        {
            base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.vJ_MeasCableReport, true, string.Format("WHERE idMeasurement = {0} AND idBus = {1} AND idTransf = {2} ORDER BY CONVERT(BIGINT, CASE WHEN CellName like '%[^0-9]%' THEN SUBSTRING(CellName,1,PATINDEX('%[^0-9]%',CellName)-1) ELSE CellName END)", this.IdMeasurement, this.IdBus, this.IdTransformer));
            return new BindingSource { DataSource = this.dsMeasurementN.vJ_MeasCableReport };
        }
        //GetMeasCableDataWithoutName
        private BindingSource GetMeasCableDataWithoutName()
        {
            this.dsMeasurementN.vJ_MeasCableReport2.Rows.Clear();
            base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.vJ_MeasCableReport2, true, string.Format("WHERE idMeasurement = {0} AND idBus = {1} AND idTransf = {2} ORDER BY CONVERT(BIGINT, CASE WHEN CellName like '%[^0-9]%' THEN SUBSTRING(CellName,1,PATINDEX('%[^0-9]%',CellName)-1) ELSE CellName END), Company, Street, House", this.IdMeasurement, this.IdBus, this.IdTransformer));
            //IEnumerable<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>> dataSource = this.dsMeasurementN.vJ_MeasCableReport2
            //    .GroupBy<DataSetGES.Class125, Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>>((C_1.C_9__78_0 ?? (C_1.C_9__78_0 = new Func<DataSetGES.Class125, Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>>(C_1.C_9.method_0))))
            //    .Select<IGrouping<Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>, DataSetGES.Class125>, Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>(new Func<IGrouping<Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>, DataSetGES.Class125>, Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>(this.method_50))
            //    .AsEnumerable<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>();

            //IEnumerable<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>> dataSource = this.dsMeasurementN.vJ_MeasCableReport2
            //         .GroupBy<DataSetGES.Class125, Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>>((C_1.C_9__78_0 ?? (C_1.C_9__78_0 = new Func<DataSetGES.Class125, Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>>(C_1.C_9.method_0))))
            //         .Select<IGrouping<Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>, DataSetGES.Class125>, Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>(new Func<IGrouping<Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>, DataSetGES.Class125>, Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>(this.method_50))
            //         .AsEnumerable<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>();
            var dataSource = (from row in this.dsMeasurementN.vJ_MeasCableReport2
                              group row by new
                              {
                                  id = ((row["id"] != null) ? row["id"] : -1),//id = (row["id"] ?? -1),
                                  idMeasurement = ((row["idMeasurement"] != null) ? row["idMeasurement"] : -1),
                                  idBus = ((row["idBus"] != null) ? row["idBus"] : -1),
                                  idTransf = ((row["idTransf"] != null) ? row["idTransf"] : -1),
                                  idCell = ((row["idCell"] != null) ? row["idCell"] : -1),
                                  CellName = ((row["CellName"] != null) ? row["CellName"] : ""),
                                  idCable = ((row["idCable"] != null) ? row["idCable"] : -1),
                                  idSchmAbn = ((row["idSchmAbn"] != null) ? row["idSchmAbn"] : -1),
                                  Makeup = ((row["Makeup"] != null) ? row["Makeup"] : ""),
                                  Voltage = ((row["Voltage"] != null) ? row["Voltage"] : -1),
                                  Wires = ((row["Wires"] != null) ? row["Wires"] : -1),
                                  CrossSection = Convert.ToDouble((row["CrossSection"] != DBNull.Value) ? row["CrossSection"] : 0),
                                  PermisAmperage = Convert.ToDouble((row["PermisAmperage"] != DBNull.Value) ? row["PermisAmperage"] : 0),
                                  Iad = ((row["Iad"] != null) ? row["Iad"] : -1),
                                  Ian = ((row["Ian"] != null) ? row["Ian"] : -1),
                                  Ibd = ((row["Ibd"] != null) ? row["Ibd"] : -1),
                                  Ibn = ((row["Ibn"] != null) ? row["Ibn"] : -1),
                                  Icd = ((row["Icd"] != null) ? row["Icd"] : -1),
                                  Icn = ((row["Icn"] != null) ? row["Icn"] : -1),
                                  Iod = ((row["Iod"] != null) ? row["Iod"] : -1),
                                  Ion = ((row["Ion"] != null) ? row["Ion"] : -1),
                                  Comment = ((row["Comment"] != null) ? row["Comment"] : "")
                              } into g
                              select new
                              {
                                  id = g.Key.id,
                                  idMeasurement = g.Key.idMeasurement,
                                  idBus = g.Key.idBus,
                                  idCell = g.Key.idCell,
                                  CellName = g.Key.CellName,
                                  idCable = g.Key.idCable,
                                  Address = this.GetAddress(this.dsMeasurementN.vJ_MeasCableReport2, (g.Key.idCell == DBNull.Value) ? -1 : ((int)g.Key.idCell), (g.Key.idCable == DBNull.Value) ? -1 : ((int)g.Key.idCable)),
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
                              }).AsEnumerable();


            //System.Collections.IEnumerable enumerable = this.dsMeasurementN.vJ_MeasCableReport2
            //           .GroupBy(C_1.C_9.method_0)
            //           .Select(this.method_50)
            //           .AsEnumerable();
            return new BindingSource { DataSource = dataSource };
        }

        private string GetAddress(DataSetMeasurementN.vJ_MeasCableReport2DataTable dt, int idCell, int idCable)
        {
            //Class185 class2 = new Class185
            //{
            //    int_0 = idCell,
            //    int_1 = idCable,
            //    vJ_MeasCableReport2DataTable_0 = dt
            //};
            //IEnumerable<Class20<int, int, string, string>> source = class2.vJ_MeasCableReport2DataTable_0
            //    .Where<DataSetGES.Class125>((C_1.C_9__79_0 ?? (C_1.C_9__79_0 = new Func<DataSetGES.Class125, bool>(C_1.C_9.method_1))))
            //    .GroupBy<DataSetGES.Class125, Class19<int, int, string>>((C_1.C_9__79_1 ?? (C_1.C_9__79_1 = new Func<DataSetGES.Class125, Class19<int, int, string>>(C_1.C_9.method_2))))
            //.Where<IGrouping<Class19<int, int, string>, DataSetGES.Class125>>(new Func<IGrouping<Class19<int, int, string>, DataSetGES.Class125>, bool>(class2.method_0))
            //    .Select<IGrouping<Class19<int, int, string>, DataSetGES.Class125>, Class20<int, int, string, string>>(new Func<IGrouping<Class19<int, int, string>, DataSetGES.Class125>, Class20<int, int, string, string>>(class2.method_1));


            var source = dt
         .Where(r => (r["House"] != DBNull.Value)) //C_1.C_9.method_1 = return (row["House"] != DBNull.Value)
         .GroupBy(r => new
         {
             idCell = (r["idCell"] == DBNull.Value) ? -1 : r.idCell,
             idCable = (r["idCable"] == DBNull.Value) ? -1 : r.idCable,
             Street = (r["Street"] == DBNull.Value) ? "" : r.Street.ToString()
         })
         //C_1.C_9.method_2 = return new
         //(row["idCell"] == DBNull.Value) ? -1 : row.idCell,
         //(row["idCable"] == DBNull.Value) ? -1 : row.idCable, 
         //(row["Street"] == DBNull.Value) ? "" : row.Street.ToString()

         .Where(r => (r.Key.idCell == idCell) && (r.Key.idCable == idCable))
         //return ((igrouping_0.Key.idCell == dt.idCell) && (igrouping_0.Key.idCable == dt.idCable));
         //.Select(new Func<IGrouping<Class19<int, int, string>, DataSetGES.Class125>, Class20<int, int, string, string>>(class2.method_1))
         .Select(r => new
         {
             idCell = r.Key.idCell,
             idCable = r.Key.idCable,
             Street = r.Key.Street,
             House = GroupingSequenceNumbers(dt
                    .Where(row => (
                    (((row["idCell"] == DBNull.Value) ? -1 : row.idCell) == idCell) &&
                    (((row["idCable"] == DBNull.Value) ? -1 : row.idCable) == idCable) &&
                    (((row["Street"] == DBNull.Value) ? "" : row.Street) == r.Key.Street)
                    ))
                  .OrderBy(row => row.House)
                  .Select(row => row.FullHouse)
                    .Distinct()
                    .ToArray())
         })
         ;
            //Было
            //return string
            //    .Join("; ", source.Select<Class20<int, int, string, string>, string>((C_1.C_9__79_7 ?? (C_1.C_9__79_7 = new Func<Class20<int, int, string, string>, string>(C_1.C_9.method_5))))
            //    .ToArray<string>());
            return string
             .Join("; ", source.Select(r => r.Street + ", " + r.House)  //C_1.C_9.method_5 = return (r.Street + ", " + r.House)
             .ToArray());

            //примерно надо
            //var source = from r in dt
            //             where r["House"] != DBNull.Value
            //             select r into row
            //             group row by new
            //             {
            //                 idCell = ((row["idCell"] == DBNull.Value) ? -1 : row.idCell),
            //                 idCable = ((row["idCable"] == DBNull.Value) ? -1 : row.idCable),
            //                 Street = ((row["Street"] == DBNull.Value) ? "" : row.Street.ToString())
            //             } into g
            //             where g.Key.idCell == idCell && g.Key.idCable == idCable
            //             select new
            //             {
            //                 idCell = g.Key.idCell,
            //                 idCable = g.Key.idCable,
            //                 Street = g.Key.Street,
            //                 House = FormMeasurementReports.GroupingSequenceNumbers((from r in dt
            //                                                                         where ((r["idCell"] == DBNull.Value) ? -1 : r.idCell) == idCell && ((r["idCable"] == DBNull.Value) ? -1 : r.idCable) == idCable && ((r["Street"] == DBNull.Value) ? "" : r.Street) == g.Key.Street
            //                                                                         orderby r.House
            //                                                                         select r.FullHouse).Distinct<string>().ToArray<string>())
            //             };
            //return string.Join("; ", (from r in source
            //                          select r.Street + ", " + r.House).ToArray<string>());


        }

        //private int IdMeasTransfVoltage;
        //internal int method_4()
        //{
        //    return this.IdMeasTransfVoltage;
        //}

        //internal void method_5(int int_9)
        //{
        //    this.IdMeasTransfVoltage = int_9;
        //}


        private BindingSource GetMeasCellData()
        {
            base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.vJ_MeasCell, true, string.Format("WHERE idMeasurement = {0} AND idBus = {1} ORDER BY CONVERT(BIGINT, CASE WHEN NameBus like '%[^0-9]%' THEN SUBSTRING(NameBus,1,PATINDEX('%[^0-9]%',NameBus)-1) ELSE NameBus END), CONVERT(INT, CASE WHEN NameCell like '%[^0-9]%' THEN SUBSTRING(NameCell,1,PATINDEX('%[^0-9]%',NameCell)-1) ELSE NameCell END)", this.IdMeasurement, this.IdBus));
            return new BindingSource { DataSource = this.dsMeasurementN.vJ_MeasCell };
        }

        //private string QQQ()
        //{

        //    string[] fruits = { "apple", "banana", "mango", "orange",
        //                  "passionfruit", "grape" };

        //    var query =
        //        fruits.Select((fruit, index) =>
        //                          new { index, str = fruit.Substring(0, index) });

        //    foreach (var obj in query)
        //    {
        //        Console.WriteLine("{0}", obj);
        //    }

        //    return "";

        //}

        private BindingSource GetMeasCableRatioData()
        {
            this.dsMeasurementN.dtMeasCableRatio.Rows.Clear();

            //IEnumerable<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>> source = this.dsMeasurementN.vJ_MeasCableReport2
            //    .GroupBy<DataSetGES.Class125, Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>>((C_1.C_9__82_0 ?? (C_1.C_9__82_0 = new Func<DataSetGES.Class125, Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>>(C_1.C_9.method_6))))
            //    .Select<IGrouping<Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>, DataSetGES.Class125>, Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>(new Func<IGrouping<Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>, DataSetGES.Class125>, Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>(this.method_51))
            //    .AsEnumerable<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>();

            var s = this.dsMeasurementN.vJ_MeasCableReport2
             .GroupBy(row => new
             {
                 id = ((row["id"] != DBNull.Value) ? row["id"] : -1),
                 idMeasurement = ((row["idMeasurement"] != DBNull.Value) ? row["idMeasurement"] : -1),
                 idBus = ((row["idBus"] != DBNull.Value) ? row["idBus"] : -1),
                 idTransf = ((row["idTransf"] != DBNull.Value) ? row["idTransf"] : -1),
                 idCell = ((row["idCell"] != DBNull.Value) ? row["idCell"] : -1),
                 CellName = ((row["CellName"] != DBNull.Value) ? row["CellName"] : ""),
                 idCable = ((row["idCable"] != DBNull.Value) ? row["idCable"] : -1),
                 idSchmAbn = ((row["idSchmAbn"] != DBNull.Value) ? row["idSchmAbn"] : -1),
                 Makeup = ((row["Makeup"] != DBNull.Value) ? row["Makeup"] : ""),
                 Voltage = ((row["Voltage"] != DBNull.Value) ? row["Voltage"] : -1),
                 Wires = ((row["Wires"] != DBNull.Value) ? row["Wires"] : -1),
                 CrossSection = Convert.ToDouble((row["CrossSection"] != DBNull.Value) ? row["CrossSection"] : 0),
                 PermisAmperage = Convert.ToDouble((row["PermisAmperage"] != DBNull.Value) ? row["PermisAmperage"] : 0),
                 Iad = ((row["Iad"] != DBNull.Value) ? row["Iad"] : -1),
                 Ian = ((row["Ian"] != DBNull.Value) ? row["Ian"] : -1),
                 Ibd = ((row["Ibd"] != DBNull.Value) ? row["Ibd"] : -1),
                 Ibn = ((row["Ibn"] != DBNull.Value) ? row["Ibn"] : -1),
                 Icd = ((row["Icd"] != DBNull.Value) ? row["Icd"] : -1),
                 Icn = ((row["Icn"] != DBNull.Value) ? row["Icn"] : -1),
                 Iod = ((row["Iod"] != DBNull.Value) ? row["Iod"] : -1),
                 Ion = ((row["Ion"] != DBNull.Value) ? row["Ion"] : -1),
                 Comment = ((row["Comment"] != DBNull.Value) ? row["Comment"] : "")
             })
             .Select(g => new
             {
                 id = g.Key.id,
                 idMeasurement = g.Key.idMeasurement,
                 idBus = g.Key.idBus,
                 idCell = g.Key.idCell,
                 CellName = g.Key.CellName,
                 idCable = g.Key.idCable,
                 Address = this.GetAddress(this.dsMeasurementN.vJ_MeasCableReport2, (g.Key.idCell == DBNull.Value) ? -1 : ((int)g.Key.idCell), (g.Key.idCable == DBNull.Value) ? -1 : ((int)g.Key.idCable)),
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
             )
             .AsEnumerable();

            //IEnumerable<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>> enumerable = source
            //    .Where<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>(C_1.C_9__82_2 ?? (C_1.C_9__82_2 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool>(C_1.C_9.method_7)));
            //IEnumerable<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>> enumerable2 = source
            //    .Where<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>(C_1.C_9__82_3 ?? (C_1.C_9__82_3 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool>(C_1.C_9.method_8)));
            //IEnumerable<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>> enumerable3 = source
            //    .Where<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>(C_1.C_9__82_4 ?? (C_1.C_9__82_4 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool>(C_1.C_9.method_9)));
            //IEnumerable<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>> enumerable4 = source
            //    .Where<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>(C_1.C_9__82_5 ?? (C_1.C_9__82_5 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool>(C_1.C_9.method_10)));
            //IEnumerable<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>> enumerable5 = source.Where<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>(C_1.C_9__82_6 ?? (C_1.C_9__82_6 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool>(C_1.C_9.method_11)));
            //IEnumerable<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>> enumerable6 = source
            //    .Where<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>(C_1.C_9__82_7 ?? (C_1.C_9__82_7 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool>(C_1.C_9.method_12)));
            //IEnumerable<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>> enumerable7 = source
            //    .Where<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>(C_1.C_9__82_8 ?? (C_1.C_9__82_8 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool>(C_1.C_9.method_13)));
            //IEnumerable<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>> enumerable8 = source
            //    .Where<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>(C_1.C_9__82_9 ?? (C_1.C_9__82_9 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool>(C_1.C_9.method_14)));
            var enumerable1 = s.Where(row => ((int)row.Iad) != -1);
            var enumerable2 = s.Where(row => ((int)row.Ian) != -1);
            var enumerable3 = s.Where(row => ((int)row.Ibd) != -1);
            var enumerable4 = s.Where(row => ((int)row.Ibn) != -1);
            var enumerable5 = s.Where(row => ((int)row.Icd) != -1);
            var enumerable6 = s.Where(row => ((int)row.Icn) != -1);
            var enumerable7 = s.Where(row => ((int)row.Iod) != -1);
            var enumerable8 = s.Where(row => ((int)row.Ion) != -1);

            //decimal num1 = (enumerable1.Count<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>() > 0) ? enumerable1.Sum<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>((C_1.C_9__82_10 ?? (C_1.C_9__82_10 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int>(C_1.C_9.method_15)))) : 0;
            //decimal num2 = (enumerable2.Count<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>() > 0) ? enumerable2.Sum<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>((C_1.C_9__82_11 ?? (C_1.C_9__82_11 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int>(C_1.C_9.method_16)))) : 0;
            //decimal num3 = (enumerable3.Count<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>() > 0) ? enumerable3.Sum<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>((C_1.C_9__82_12 ?? (C_1.C_9__82_12 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int>(C_1.C_9.method_17)))) : 0;
            //decimal num4 = (enumerable4.Count<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>() > 0) ? enumerable4.Sum<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>((C_1.C_9__82_13 ?? (C_1.C_9__82_13 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int>(C_1.C_9.method_18)))) : 0;
            //decimal num5 = (enumerable5.Count<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>() > 0) ? enumerable5.Sum<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>((C_1.C_9__82_14 ?? (C_1.C_9__82_14 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int>(C_1.C_9.method_19)))) : 0;
            //decimal num6 = (enumerable6.Count<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>() > 0) ? enumerable6.Sum<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>((C_1.C_9__82_15 ?? (C_1.C_9__82_15 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int>(C_1.C_9.method_20)))) : 0;
            //decimal num7 = (enumerable7.Count<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>() > 0) ? enumerable7.Sum<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>>((C_1.C_9__82_16 ?? (C_1.C_9__82_16 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int>(C_1.C_9.method_21)))) : 0;
            //decimal num8 = (enumerable8.Count() > 0) ? enumerable8.Sum((C_1.C_9__82_17 ?? (C_1.C_9__82_17 = new Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int>(C_1.C_9.method_22)))) : 0;
            decimal num1 = (enumerable1.Count() > 0) ? enumerable1.Sum(row => ((int)row.Iad)) : 0;
            decimal num2 = (enumerable2.Count() > 0) ? enumerable2.Sum(row => ((int)row.Ian)) : 0;
            decimal num3 = (enumerable3.Count() > 0) ? enumerable3.Sum(row => ((int)row.Ibd)) : 0;
            decimal num4 = (enumerable4.Count() > 0) ? enumerable4.Sum(row => ((int)row.Ibn)) : 0;
            decimal num5 = (enumerable5.Count() > 0) ? enumerable5.Sum(row => ((int)row.Icd)) : 0;
            decimal num6 = (enumerable6.Count() > 0) ? enumerable6.Sum(row => ((int)row.Icn)) : 0;
            decimal num7 = (enumerable7.Count() > 0) ? enumerable7.Sum(row => ((int)row.Iod)) : 0;
            decimal num8 = (enumerable8.Count() > 0) ? enumerable8.Sum(row => ((int)row.Ion)) : 0;

            decimal num9 = 0;// new decimal();
            decimal num10 = 0;// new decimal();
            decimal num11 = Math.Round((((num1 + num3) + num5) / 3M), 0);
            decimal num12 = Math.Round((((num2 + num4) + num6) / 3M), 0);
            decimal num13 = ((this.dsMeasurementN.fn_J_MeasTransfPassport.Rows.Count <= 0) || !(this.dsMeasurementN.fn_J_MeasTransfPassport.Rows[0]["Inom"] is decimal)) ? 0 : ((decimal)this.dsMeasurementN.fn_J_MeasTransfPassport.Rows[0]["Inom"]);
            decimal num14 = (num13 != 0) ? Math.Round((num11 / (num13 / 100M)), 0) : 0;
            decimal num15 = (num13 != 0) ? Math.Round((num12 / (num13 / 100M)), 0) : 0;
            decimal num16 = Math.Max(Math.Max(Math.Abs((num1 - num3)), Math.Abs((num1 - num5))), Math.Abs((num3 - num5)));
            if (((num1 + num3) + num5) != 0)
            {
                num9 = Math.Round((num16 / (((num1 + num3) + num5) / 100M)), 0);
            }
            decimal num17 = Math.Max(Math.Max(Math.Abs((num2 - num4)), Math.Abs((num2 - num6))), Math.Abs((num4 - num6)));
            if (((num2 + num4) + num6) != 0)
            {
                num10 = Math.Round((num17 / (((num2 + num4) + num6) / 100M)));
            }

            string str = (this.IdTransformer == -1) ? "" : base.SelectSqlData("tSchm_ObjList", true, "WHERE id = " + this.IdTransformer.ToString()).Rows[0]["Name"].ToString();
            string str2 = (this.IdBus == -1) ? "" : base.SelectSqlData("vP_ObjList", true, "WHERE id = " + this.IdBus.ToString()).Rows[0]["Text"].ToString();
            string str3 = (this.dsMeasurementN.vJ_MeasurementReport.Rows.Count > 0) ? this.dsMeasurementN.vJ_MeasurementReport.Rows[0]["FIO"].ToString() : "";
            object[] values = new object[] {
            "", str, str2, str3, num1, num2, num3, num4, num5, num6, num7, num8, num11, num12, num14, num15,
            num9, num10
        };
            this.dsMeasurementN.dtMeasCableRatio.Rows.Add(values);
            return new BindingSource { DataSource = this.dsMeasurementN.dtMeasCableRatio };
        }

        private BindingSource GetMeasCellRatioData()
        {
            this.dsMeasurementN.dtMeasCellRatio.Rows.Clear();
            //EnumerableRowCollection source = this.dsMeasurementN.vJ_MeasCell.Where(C_1.C_9__83_0 ?? (C_1.C_9__83_0 = new Func<DataSetGES.Class128, bool>(C_1.C_9.method_23)));
            //EnumerableRowCollection rows2 = this.dsMeasurementN.vJ_MeasCell.Where(C_1.C_9__83_1 ?? (C_1.C_9__83_1 = new Func<DataSetGES.Class128, bool>(C_1.C_9.method_24)));
            //EnumerableRowCollection rows3 = this.dsMeasurementN.vJ_MeasCell.Where(C_1.C_9__83_2 ?? (C_1.C_9__83_2 = new Func<DataSetGES.Class128, bool>(C_1.C_9.method_25)));
            //EnumerableRowCollection rows4 = this.dsMeasurementN.vJ_MeasCell.Where(C_1.C_9__83_3 ?? (C_1.C_9__83_3 = new Func<DataSetGES.Class128, bool>(C_1.C_9.method_26)));
            //EnumerableRowCollection rows5 = this.dsMeasurementN.vJ_MeasCell.Where(C_1.C_9__83_4 ?? (C_1.C_9__83_4 = new Func<DataSetGES.Class128, bool>(C_1.C_9.method_27)));
            //EnumerableRowCollection rows6 = this.dsMeasurementN.vJ_MeasCell.Where(C_1.C_9__83_5 ?? (C_1.C_9__83_5 = new Func<DataSetGES.Class128, bool>(C_1.C_9.method_28)));
            // Вариант 2
            //EnumerableRowCollection<DataSetMeasurementN.vJ_MeasCellRow> rows1 = this.dsMeasurementN.vJ_MeasCell.Where(r => r["Iad"] != DBNull.Value);
            // Вариант 3
            var rows1 = this.dsMeasurementN.vJ_MeasCell.Where(r => r["Iad"] != DBNull.Value);
            // В идеале
            //EnumerableRowCollection<DataSetGES.vJ_MeasCellRow> source = from row in this.dsJournal.vJ_MeasCell
            //                                                            where row["Iad"] != DBNull.Value
            //                                                            select row;

            //EnumerableRowCollection<DataSetMeasurementN.vJ_MeasCellRow> rows2 = this.dsMeasurementN.vJ_MeasCell.Where(r => r["Ian"] != DBNull.Value);
            var rows2 = this.dsMeasurementN.vJ_MeasCell.Where(r => r["Ian"] != DBNull.Value);
            //EnumerableRowCollection<DataSetMeasurementN.vJ_MeasCellRow> rows3 = this.dsMeasurementN.vJ_MeasCell.Where(r => r["Ibd"] != DBNull.Value);
            var rows3 = this.dsMeasurementN.vJ_MeasCell.Where(r => r["Ibd"] != DBNull.Value);
            //EnumerableRowCollection<DataSetMeasurementN.vJ_MeasCellRow> rows4 = this.dsMeasurementN.vJ_MeasCell.Where(r => r["Ibn"] != DBNull.Value);
            var rows4 = this.dsMeasurementN.vJ_MeasCell.Where(r => r["Ibn"] != DBNull.Value);
            //EnumerableRowCollection<DataSetMeasurementN.vJ_MeasCellRow> rows5 = this.dsMeasurementN.vJ_MeasCell.Where(r => r["Icd"] != DBNull.Value);
            var rows5 = this.dsMeasurementN.vJ_MeasCell.Where(r => r["Icd"] != DBNull.Value);
            //EnumerableRowCollection<DataSetMeasurementN.vJ_MeasCellRow> rows6 = this.dsMeasurementN.vJ_MeasCell.Where(r => r["Icn"] != DBNull.Value);
            var rows6 = this.dsMeasurementN.vJ_MeasCell.Where(r => r["Icn"] != DBNull.Value);

            // decimal num = (source.Count() > 0) ? source.Sum((C_1.C_9__83_6 ?? (C_1.C_9__83_6 = new Func<DataSetGES.Class128, int>(C_1.C_9.method_29)))) : 0;
            //decimal num2 = (rows2.Count() > 0) ? rows2.Sum((C_1.C_9__83_7 ?? (C_1.C_9__83_7 = new Func<DataSetGES.Class128, int>(C_1.C_9.method_30)))) : 0;
            //decimal num3 = (rows3.Count() > 0) ? rows3.Sum((C_1.C_9__83_8 ?? (C_1.C_9__83_8 = new Func<DataSetGES.Class128, int>(C_1.C_9.method_31)))) : 0;
            //decimal num4 = (rows4.Count() > 0) ? rows4.Sum((C_1.C_9__83_9 ?? (C_1.C_9__83_9 = new Func<DataSetGES.Class128, int>(C_1.C_9.method_32)))) : 0;
            //decimal num5 = (rows5.Count() > 0) ? rows5.Sum((C_1.C_9__83_10 ?? (C_1.C_9__83_10 = new Func<DataSetGES.Class128, int>(C_1.C_9.method_33)))) : 0;
            //decimal num6 = (rows6.Count() > 0) ? rows6.Sum((C_1.C_9__83_11 ?? (C_1.C_9__83_11 = new Func<DataSetGES.Class128, int>(C_1.C_9.method_34)))) : 0;
            decimal num1 = (rows1.Count() > 0) ? rows1.Sum(r => r.Iad) : 0;
            decimal num2 = (rows2.Count() > 0) ? rows2.Sum(r => r.Ian) : 0;
            decimal num3 = (rows3.Count() > 0) ? rows3.Sum(r => r.Ibd) : 0;
            decimal num4 = (rows4.Count() > 0) ? rows4.Sum(r => r.Ibn) : 0;
            decimal num5 = (rows5.Count() > 0) ? rows5.Sum(r => r.Icd) : 0;
            decimal num6 = (rows6.Count() > 0) ? rows6.Sum(r => r.Icn) : 0;
            object[] values = new object[] { num1, num2, num3, num4, num5, num6 };
            this.dsMeasurementN.dtMeasCellRatio.Rows.Add(values);
            return new BindingSource { DataSource = this.dsMeasurementN.dtMeasCellRatio };
        }

        private BindingSource GetMeasTransfAmperageAddlData()
        {
            string[] strTransf = new string[] { this.IdTransformer.ToString() };
            base.CallSQLTableValuedFunction(this.dsMeasurementN, this.dsMeasurementN.fn_J_GetBusLVByTransf, "", strTransf);

            //        EnumerableRowCollection<string> source = this.dsMeasurementN.fn_J_GetBusLVByTransf.Where<DataSetGES.Class81>((C_1.C_9__84_0 ?? (C_1.C_9__84_0 = new Func<DataSetGES.Class81, bool>(C_1.C_9.method_35)))).Select<DataSetGES.Class81, string>(C_1.C_9__84_1 ?? (C_1.C_9__84_1 = new Func<DataSetGES.Class81, string>(C_1.C_9.method_36)));

            EnumerableRowCollection<string> source = this.dsMeasurementN.fn_J_GetBusLVByTransf
                .Where(r => r.TypeCodeId == 540)
                .Select(r => r.Name);


            string str = (source.Count() > 0) ? source.First() : "";
            object[] values = new object[]
            {
            strTransf
            };
            this.dsMeasurementN.dtMeasTransfAmperageDopDataReport.Rows.Add(values);
            return new BindingSource { DataSource = this.dsMeasurementN.dtMeasTransfAmperageDopDataReport };
        }

        private BindingSource GetExcelessLoadData()
        {
            string[] str = new string[] { this.Year.ToString(), this.Factor.ToString() };
            base.CallSQLTableValuedFunction(this.dsMeasurementN, this.dsMeasurementN.fn_J_ExcelessLoadReport, "ORDER BY NetRegion, SSSocrName, CONVERT(INT, CASE WHEN Substation like '%[^0-9]%' THEN SUBSTRING(Substation,1,PATINDEX('%[^0-9]%',Substation)-1) ELSE Substation END), CONVERT(INT, CASE WHEN Switch like '%[^0-9]%' THEN SUBSTRING(Switch,1,PATINDEX('%[^0-9]%',Switch)-1) ELSE Switch END)", str);
            return new BindingSource { DataSource = this.dsMeasurementN.fn_J_ExcelessLoadReport };
        }

        private BindingSource GetExcelessLoadAddlData()
        {
            //DataSetGES.Class85 row = this.dsMeasurementN.dtExcelessLoadAddlReport.method_4();
            DataSetMeasurementN.dtExcelessLoadAddlReportRow row = this.dsMeasurementN.dtExcelessLoadAddlReport.NewdtExcelessLoadAddlReportRow();
            row.Year = this.Year;
            row.Coefficient = (this.Factor);
            this.dsMeasurementN.dtExcelessLoadAddlReport.AdddtExcelessLoadAddlReportRow(row);

            return new BindingSource { DataSource = this.dsMeasurementN.dtExcelessLoadAddlReport };
        }

        private BindingSource GetCoefficientLoadingData()
        {
            string str = (this.IdNetworkAreas == -1) ? "" : (" AND idNetRegion = " + IdNetworkAreas.ToString());
            string str2 = (this.PowerTransf == -1) ? "" : (" AND Power " + (this.IsPowerLarge ? "> " : "< ") + this.PowerTransf.ToString());
            string str3 = this.IsDay ? (" AND Kntd " + (this.IsCoefficientLarge ? "> " : "< ") + this.CoefficientLoading.ToString()) : "";
            string str4 = this.IsNight ? (" AND Kntn " + (this.IsCoefficientLarge ? "> " : "< ") + this.CoefficientLoading.ToString()) : "";
            string str5 = string.Format(" WHERE Year = {0}{1}{2}{3}{4} ORDER BY NetRegion, SSSocrName, CONVERT(INT, CASE WHEN Substation like '%[^0-9]%' THEN SUBSTRING(Substation,1,PATINDEX('%[^0-9]%',Substation)-1) ELSE Substation END), CONVERT(INT, CASE WHEN Transformer like '%[^0-9]%' THEN SUBSTRING(Transformer,1,PATINDEX('%[^0-9]%',Transformer)-1) ELSE Transformer END)", new object[]
            {
            this.Year,
            str,
            str2,
            str3,
            str4
            });
            base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.vJ_CoefficientLoading, true, str5);
            return new BindingSource { DataSource = this.dsMeasurementN.vJ_CoefficientLoading };
        }

        private BindingSource GetCoefficientAddlData()
        {
            //DataSetGES.Class87 class2 = this.dsMeasurementN.dtCoefficientLoadingAddl.method_4();
            DataSetMeasurementN.dtCoefficientLoadingAddlRow row = dsMeasurementN.dtCoefficientLoadingAddl.NewdtCoefficientLoadingAddlRow();
            row.Year = this.Year;
            row.Power = (this.PowerTransf == -1) ? "" : ((this.IsPowerLarge ? "> " : "< ") + this.PowerTransf.ToString());
            row.Kntd = (this.IsDay ? ((this.IsCoefficientLarge ? "> " : "< ") + this.CoefficientLoading.ToString()) : "");
            row.Kntn = (this.IsNight ? ((this.IsCoefficientLarge ? "> " : "< ") + this.CoefficientLoading.ToString()) : "");
            this.dsMeasurementN.dtCoefficientLoadingAddl.AdddtCoefficientLoadingAddlRow(row);
            return new BindingSource { DataSource = this.dsMeasurementN.dtCoefficientLoadingAddl };
        }

        private BindingSource GetCoefficientIrregularityData()
        {
            string str = (this.IdNetworkAreas == -1) ? "" : (" AND idNetRegion = " + IdNetworkAreas.ToString());
            string str2 = (this.PowerTransf == -1) ? "" : (" AND Power " + (this.IsPowerLarge ? "> " : "< ") + this.PowerTransf.ToString());
            string str3 = this.IsDay ? (" AND Kpfd " + (this.IsCoefficientLarge ? "> " : "< ") + this.CoefficientLoading.ToString()) : "";
            string str4 = this.IsNight ? (" AND Kpfn " + (this.IsCoefficientLarge ? "> " : "< ") + this.CoefficientLoading.ToString()) : "";
            string str5 = string.Format(" WHERE Year = {0}{1}{2}{3}{4} ORDER BY NetRegion, SSSocrName, CONVERT(INT, CASE WHEN Substation like '%[^0-9]%' THEN SUBSTRING(Substation,1,PATINDEX('%[^0-9]%',Substation)-1) ELSE Substation END), CONVERT(INT, CASE WHEN Transformer like '%[^0-9]%' THEN SUBSTRING(Transformer,1,PATINDEX('%[^0-9]%',Transformer)-1) ELSE Transformer END)", new object[] { this.Year, str, str2, str3, str4 });
            base.SelectSqlData(this.dsMeasurementN, this.dsMeasurementN.vJ_CoefficientIrregularity, true, str5);
            return new BindingSource { DataSource = this.dsMeasurementN.vJ_CoefficientIrregularity };
        }


        //private Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> method_50(IGrouping<Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>, DataSetGES.Class125> igrouping_0)
        //{
        //    return new Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>(igrouping_0.Key.Prop_0, igrouping_0.Key.idMeasurement, igrouping_0.Key.idBus, igrouping_0.Key.idCell, igrouping_0.Key.CellName, igrouping_0.Key.idCable, this.GetAddress(this.dsMeasurementN.vJ_MeasCableReport2, (igrouping_0.Key.idCell == DBNull.Value) ? -1 : ((int) igrouping_0.Key.idCell), (igrouping_0.Key.idCable == DBNull.Value) ? -1 : ((int) igrouping_0.Key.idCable)), igrouping_0.Key.idSchmAbn, igrouping_0.Key.Makeup, igrouping_0.Key.Voltage, igrouping_0.Key.Wires, igrouping_0.Key.CrossSection, igrouping_0.Key.PermisAmperage, igrouping_0.Key.Iad, igrouping_0.Key.Ian, igrouping_0.Key.Ibd, igrouping_0.Key.Ibn, igrouping_0.Key.Icd, igrouping_0.Key.Icn, igrouping_0.Key.Iod, igrouping_0.Key.Ion);
        //}

        //internal class Class18<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
        //{
        //    public object id;
        //    public object idMeasurement;
        //    public object idBus;
        //    public object idCell;
        //    public object cellName;
        //    public object idCable;
        //    public string v;
        //    public object idSchmAbn;
        //    public object makeup;
        //    public object voltage;
        //    public object wires;
        //    public object crossSection;
        //    public object permisAmperage;
        //    public object iad;
        //    public object ian;
        //    public object ibd;
        //    public object ibn;
        //    public object icd;
        //    public object icn;
        //    public object iod;
        //    public object ion;
        //    internal int Ibd;
        //    internal int Ian;
        //    internal int Iad;
        //    internal int Ion;
        //    internal int Iod;
        //    internal int Icn;
        //    internal int Icd;
        //    internal int Ibn;

        //    public Class18(object id, object idMeasurement, object idBus, object idCell, object cellName, object idCable, string v, object idSchmAbn, object makeup, object voltage, object wires, object crossSection, object permisAmperage, object iad, object ian, object ibd, object ibn, object icd, object icn, object iod, object ion)
        //    {
        //        this.id = id;
        //        this.idMeasurement = idMeasurement;
        //        this.idBus = idBus;
        //        this.idCell = idCell;
        //        this.cellName = cellName;
        //        this.idCable = idCable;
        //        this.v = v;
        //        this.idSchmAbn = idSchmAbn;
        //        this.makeup = makeup;
        //        this.voltage = voltage;
        //        this.wires = wires;
        //        this.crossSection = crossSection;
        //        this.permisAmperage = permisAmperage;
        //        this.iad = iad;
        //        this.ian = ian;
        //        this.ibd = ibd;
        //        this.ibn = ibn;
        //        this.icd = icd;
        //        this.icn = icn;
        //        this.iod = iod;
        //        this.ion = ion;
        //    }
        //}
        //internal class Class17<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
        //{
        //    public object Prop_0;
        //    public object idMeasurement;
        //    public object idBus;
        //    public object idCell;
        //    public object CellName;
        //    public object idCable;
        //    public object v7;
        //    public object v8;
        //    public object idSchmAbn;
        //    public object Makeup;
        //    public object Voltage;
        //    public double Wires;
        //    public double CrossSection;
        //    public object PermisAmperage;
        //    public object Iad;
        //    public object Ian;
        //    public object Ibd;
        //    public object Ibn;
        //    public object Icd;
        //    public object Icn;
        //    public object Iod;
        //    public object Ion;

        //    public Class17(object v1, object v2, object v3, object v4, object v5, object v6, object v7, object v8, object v9, object v10, object v11, double v12, double v13, object v14, object v15, object v16, object v17, object v18, object v19, object v20, object v21, object v22)
        //    {
        //        this.Prop_0 = v1;
        //        this.idMeasurement = v2;
        //        this.idBus = v3;
        //        this.idCell = v4;
        //        this.CellName = v5;
        //        this.idCable = v6;
        //        this.v7 = v7;
        //        this.v8 = v8;
        //        this.idSchmAbn = v9;
        //        this.Makeup = v10;
        //        this.Voltage = v11;
        //        this.Wires = v12;
        //        this.CrossSection = v13;
        //        this.PermisAmperage = v14;
        //        this.Iad = v15;
        //        this.Ian = v16;
        //        this.Ibd = v17;
        //        this.Ibn = v18;
        //        this.Icd = v19;
        //        this.Icn = v20;
        //        this.Iod = v21;
        //        this.Ion = v22;
        //    }
        //}
        ////internal class Class20<T1, T2, T3, T4>
        ////{
        ////    public object Street;
        ////    public string House;
        ////    public object idCell;
        ////    public object idCable;

        ////    //private object street;
        ////    //private string v;

        ////    public Class20(object idCell, object idCable, object Street, string House)
        ////    {
        ////        this.idCell = idCell;
        ////        this.idCable = idCable;
        ////        this.Street = Street;
        ////        this.House = House;
        ////    }
        ////}
        ////internal class Class19<T1, T2, T3>
        ////{
        ////    public string Street;
        ////    public int idCell;
        ////    public int idCable;
        ////    private int v1;
        ////    private int v2;
        ////    private string v3;

        ////    public Class19(int v1, int v2, string v3)
        ////    {
        ////        this.v1 = v1;
        ////        this.v2 = v2;
        ////        this.v3 = v3;
        ////    }
        ////}


        //private Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> method_51(IGrouping<Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>, DataSetGES.Class125> igrouping_0)
        //{
        //    return new Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>(igrouping_0.Key.Prop_0, igrouping_0.Key.idMeasurement, igrouping_0.Key.idBus, igrouping_0.Key.idCell, igrouping_0.Key.CellName, igrouping_0.Key.idCable, this.GetAddress(this.dsMeasurementN.vJ_MeasCableReport2, (igrouping_0.Key.idCell == DBNull.Value) ? -1 : ((int) igrouping_0.Key.idCell), (igrouping_0.Key.idCable == DBNull.Value) ? -1 : ((int) igrouping_0.Key.idCable)), igrouping_0.Key.idSchmAbn, igrouping_0.Key.Makeup, igrouping_0.Key.Voltage, igrouping_0.Key.Wires, igrouping_0.Key.CrossSection, igrouping_0.Key.PermisAmperage, igrouping_0.Key.Iad, igrouping_0.Key.Ian, igrouping_0.Key.Ibd, igrouping_0.Key.Ibn, igrouping_0.Key.Icd, igrouping_0.Key.Icn, igrouping_0.Key.Iod, igrouping_0.Key.Ion);
        //}



        private static string GroupingSequenceNumbers(string[] str)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                int num;
                if (int.TryParse(str[i], out num))
                {
                    while (i < (str.Length - 1))
                    {
                        int num4;
                        if (!int.TryParse(str[i + 1], out num4) || ((int.Parse(str[i]) + 1) != num4))
                        {
                            break;
                        }
                        i++;
                    }
                    int num2 = int.Parse(str[i]);
                    builder.Append((num == num2) ? (num.ToString() + ((i < (str.Length - 1)) ? "," : "")) : ((num == (num2 - 1)) ? string.Concat(new object[] { num, ",", num2, (i < (str.Length - 1)) ? "," : "" }) : string.Concat(new object[] { num, "-", num2, (i < (str.Length - 1)) ? "," : "" })));
                    continue;
                }
                builder.Append(str[i] + ((i < (str.Length - 1)) ? "," : ""));
            }
            return builder.ToString();
        }



        //[Serializable, CompilerGenerated]
        //private sealed class C_1
        //{
        //    public static readonly FormMeasurementReports.C_1 C_9 = new FormMeasurementReports.C_1();
        //    public static Func<DataSetGES.Class125, Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>> C_9__78_0;
        //    public static Func<DataSetGES.Class125, bool> C_9__79_0;
        //    public static Func<DataSetGES.Class125, Class19<int, int, string>> C_9__79_1;
        //    public static Func<DataSetGES.Class125, int> C_9__79_5;
        //    public static Func<DataSetGES.Class125, string> C_9__79_6;
        //    public static Func<Class20<int, int, string, string>, string> C_9__79_7;
        //    public static Func<DataSetGES.Class125, Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>> C_9__82_0;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int> C_9__82_10;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int> C_9__82_11;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int> C_9__82_12;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int> C_9__82_13;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int> C_9__82_14;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int> C_9__82_15;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int> C_9__82_16;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, int> C_9__82_17;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool> C_9__82_2;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool> C_9__82_3;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool> C_9__82_4;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool> C_9__82_5;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool> C_9__82_6;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool> C_9__82_7;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool> C_9__82_8;
        //    public static Func<Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object>, bool> C_9__82_9;
        //    public static Func<DataSetGES.Class128, bool> C_9__83_0;
        //    public static Func<DataSetGES.Class128, bool> C_9__83_1;
        //    public static Func<DataSetGES.Class128, int> C_9__83_10;
        //    public static Func<DataSetGES.Class128, int> C_9__83_11;
        //    public static Func<DataSetGES.Class128, bool> C_9__83_2;
        //    public static Func<DataSetGES.Class128, bool> C_9__83_3;
        //    public static Func<DataSetGES.Class128, bool> C_9__83_4;
        //    public static Func<DataSetGES.Class128, bool> C_9__83_5;
        //    public static Func<DataSetGES.Class128, int> C_9__83_6;
        //    public static Func<DataSetGES.Class128, int> C_9__83_7;
        //    public static Func<DataSetGES.Class128, int> C_9__83_8;
        //    public static Func<DataSetGES.Class128, int> C_9__83_9;
        //    public static Func<DataSetGES.Class81, bool> C_9__84_0;
        //    public static Func<DataSetGES.Class81, string> C_9__84_1;

        //    internal Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object> method_0(DataSetGES.Class125 row)
        //    {
        //        return new Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>(
        //            (row["id"] != null) ? row["id"] : -1,
        //            (row["idMeasurement"] != null) ? row["idMeasurement"] : -1,
        //            (row["idBus"] != null) ? row["idBus"] : -1,
        //            (row["idTransf"] != null) ? row["idTransf"] : -1,
        //            (row["idCell"] != null) ? row["idCell"] : -1,
        //            (row["CellName"] != null) ? row["CellName"] : "",
        //            (row["idCable"] != null) ? row["idCable"] : -1,
        //            (row["idSchmAbn"] != null) ? row["idSchmAbn"] : -1,
        //            (row["Makeup"] != null) ? row["Makeup"] : "",
        //            (row["Voltage"] != null) ? row["Voltage"] : -1,
        //            (row["Wires"] != null) ? row["Wires"] : -1,
        //            Convert.ToDouble((row["CrossSection"] != DBNull.Value) ? row["CrossSection"] : 0),
        //            Convert.ToDouble((row["PermisAmperage"] != DBNull.Value) ? row["PermisAmperage"] : 0),
        //            (row["Iad"] != null) ? row["Iad"] : -1,
        //            (row["Ian"] != null) ? row["Ian"] : -1,
        //            (row["Ibd"] != null) ? row["Ibd"] : -1,
        //            (row["Ibn"] != null) ? row["Ibn"] : -1,
        //            (row["Icd"] != null) ? row["Icd"] : -1,
        //            (row["Icn"] != null) ? row["Icn"] : -1,
        //            (row["Iod"] != null) ? row["Iod"] : -1,
        //            (row["Ion"] != null) ? row["Ion"] : -1,
        //            (row["Comment"] != null) ? row["Comment"] : "");
        //    }

        //    internal bool method_1(DataSetGES.Class125 row)
        //    {
        //        return (row["House"] != DBNull.Value);
        //    }

        //    internal bool method_10(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (((int)class18_0.Ibn) != -1);
        //    }

        //    internal bool method_11(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (((int)class18_0.Icd) != -1);
        //    }

        //    internal bool method_12(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (((int)class18_0.Icn) != -1);
        //    }

        //    internal bool method_13(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (((int)class18_0.Iod) != -1);
        //    }

        //    internal bool method_14(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (((int)class18_0.Ion) != -1);
        //    }

        //    internal int method_15(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (int)class18_0.Iad;
        //    }

        //    internal int method_16(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (int)class18_0.Ian;
        //    }

        //    internal int method_17(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (int)class18_0.Ibd;
        //    }

        //    internal int method_18(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (int)class18_0.Ibn;
        //    }

        //    internal int method_19(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (int)class18_0.Icd;
        //    }

        //    internal Class19<int, int, string> method_2(DataSetGES.Class125 row)
        //    {
        //        return new Class19<int, int, string>(
        //            (row["idCell"] == DBNull.Value) ? -1 : row.idCell,
        //            (row["idCable"] == DBNull.Value) ? -1 : row.idCable,
        //            (row["Street"] == DBNull.Value) ? "" : row.Street.ToString()
        //            );
        //    }

        //    internal int method_20(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (int)class18_0.Icn;
        //    }

        //    internal int method_21(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (int)class18_0.Iod;
        //    }

        //    internal int method_22(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (int)class18_0.Ion;
        //    }

        //    internal bool method_23(DataSetGES.Class128 class128_0)
        //    {
        //        return (class128_0["Iad"] != DBNull.Value);
        //    }

        //    internal bool method_24(DataSetGES.Class128 class128_0)
        //    {
        //        return (class128_0["Ian"] != DBNull.Value);
        //    }

        //    internal bool method_25(DataSetGES.Class128 class128_0)
        //    {
        //        return (class128_0["Ibd"] != DBNull.Value);
        //    }

        //    internal bool method_26(DataSetGES.Class128 class128_0)
        //    {
        //        return (class128_0["Ibn"] != DBNull.Value);
        //    }

        //    internal bool method_27(DataSetGES.Class128 class128_0)
        //    {
        //        return (class128_0["Icd"] != DBNull.Value);
        //    }

        //    internal bool method_28(DataSetGES.Class128 class128_0)
        //    {
        //        return (class128_0["Icn"] != DBNull.Value);
        //    }

        //    internal int method_29(DataSetGES.Class128 class128_0)
        //    {
        //        return class128_0.Iad;
        //    }

        //    internal int method_3(DataSetGES.Class125 class125_0)
        //    {
        //        return class125_0.House;
        //    }

        //    internal int method_30(DataSetGES.Class128 class128_0)
        //    {
        //        return class128_0.Ian;
        //    }

        //    internal int method_31(DataSetGES.Class128 class128_0)
        //    {
        //        return class128_0.Ibd;
        //    }

        //    internal int method_32(DataSetGES.Class128 class128_0)
        //    {
        //        return class128_0.Ibn;
        //    }

        //    internal int method_33(DataSetGES.Class128 class128_0)
        //    {
        //        return class128_0.Icd;
        //    }

        //    internal int method_34(DataSetGES.Class128 class128_0)
        //    {
        //        return class128_0.Icn;
        //    }

        //    internal bool method_35(DataSetGES.Class81 class81_0)
        //    {
        //        return (class81_0.TypeCodeId == 540);
        //    }

        //    internal string method_36(DataSetGES.Class81 class81_0)
        //    {
        //        return class81_0.Name;
        //    }

        //    internal string method_4(DataSetGES.Class125 class125_0)
        //    {
        //        return class125_0.FullHouse;
        //    }

        //    //internal string method_5(Class20<int, int, string, string> r)
        //    //{
        //    //    return (r.Street + ", " + r.House);
        //    //}

        //    internal Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object> method_6(DataSetGES.Class125 row)
        //    {
        //        return new Class17<object, object, object, object, object, object, object, object, object, object, object, double, double, object, object, object, object, object, object, object, object, object>(
        //            (row["id"] != DBNull.Value) ? row["id"] : -1,
        //            (row["idMeasurement"] != DBNull.Value) ? row["idMeasurement"] : -1,
        //            (row["idBus"] != DBNull.Value) ? row["idBus"] : -1,
        //            (row["idTransf"] != DBNull.Value) ? row["idTransf"] : -1,
        //            (row["idCell"] != DBNull.Value) ? row["idCell"] : -1,
        //            (row["CellName"] != DBNull.Value) ? row["CellName"] : "",
        //            (row["idCable"] != DBNull.Value) ? row["idCable"] : -1,
        //            (row["idSchmAbn"] != DBNull.Value) ? row["idSchmAbn"] : -1,
        //            (row["Makeup"] != DBNull.Value) ? row["Makeup"] : "",
        //            (row["Voltage"] != DBNull.Value) ? row["Voltage"] : -1,
        //            (row["Wires"] != DBNull.Value) ? row["Wires"] : -1,
        //            Convert.ToDouble((row["CrossSection"] != DBNull.Value) ? row["CrossSection"] : 0),
        //            Convert.ToDouble((row["PermisAmperage"] != DBNull.Value) ? row["PermisAmperage"] : 0),
        //            (row["Iad"] != DBNull.Value) ? row["Iad"] : -1,
        //            (row["Ian"] != DBNull.Value) ? row["Ian"] : -1,
        //            (row["Ibd"] != DBNull.Value) ? row["Ibd"] : -1,
        //            (row["Ibn"] != DBNull.Value) ? row["Ibn"] : -1,
        //            (row["Icd"] != DBNull.Value) ? row["Icd"] : -1,
        //            (row["Icn"] != DBNull.Value) ? row["Icn"] : -1,
        //            (row["Iod"] != DBNull.Value) ? row["Iod"] : -1,
        //            (row["Ion"] != DBNull.Value) ? row["Ion"] : -1,
        //            (row["Comment"] != DBNull.Value) ? row["Comment"] : "");
        //    }

        //    internal bool method_7(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (((int)class18_0.Iad) != -1);
        //    }

        //    internal bool method_8(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (((int)class18_0.Ian) != -1);
        //    }

        //    internal bool method_9(Class18<object, object, object, object, object, object, string, object, object, object, object, double, double, object, object, object, object, object, object, object, object> class18_0)
        //    {
        //        return (((int)class18_0.Ibd) != -1);
        //    }
        //}


        //private sealed class Class185
        //{
        //    public int int_0;
        //    public int int_1;
        //    public DataSetGES.vJ_MeasCableReport2DataTable vJ_MeasCableReport2DataTable_0;

        //    internal bool method_0(IGrouping<Class19<int, int, string>, DataSetGES.Class125> igrouping_0)
        //    {
        //        return ((igrouping_0.Key.idCell == this.int_0) && (igrouping_0.Key.idCable == this.int_1));
        //    }

        //    internal Class20<int, int, string, string> method_1(IGrouping<Class19<int, int, string>, DataSetGES.Class125> igrouping_0)
        //    {
        //        Class186 class2 = new Class186
        //        {
        //            class185_0 = this,
        //            igrouping_0 = igrouping_0
        //        };
        //        return new Class20<int, int, string, string>(class2.igrouping_0.Key.idCell, class2.igrouping_0.Key.idCable, class2.igrouping_0.Key.Street, GroupingSequenceNumbers(vJ_MeasCableReport2DataTable_0
        //            .Where(new Func<DataSetGES.Class125, bool>(class2.method_0))// (((((row["idCell"] == DBNull.Value) ? -1 : row.idCell) == this.class185_0.int_0) && (((row["idCable"] == DBNull.Value) ? -1 : row.idCable) == this.class185_0.int_1)) && (((row["Street"] == DBNull.Value) ? "" : row.Street) == this.igrouping_0.Key.Street));
        //                                                                        //  .OrderBy((C_1.C_9__79_5 ?? (C_1.C_9__79_5 = new Func<DataSetGES.Class125, int>(C_1.C_9.method_3))))//return datarow.House;
        //          .OrderBy(r => r.House)
        //          //  .Select((C_1.C_9__79_6 ?? (C_1.C_9__79_6 = new Func<DataSetGES.Class125, string>(C_1.C_9.method_4))))//return datarow.FullHouse;
        //          .Select(r => r.FullHouse)
        //            .Distinct()
        //            .ToArray()));
        //    }
        //}


        //private sealed class Class186
        //{
        //    public Class185 class185_0;
        //    public IGrouping<Class19<int, int, string>, DataSetGES.Class125> igrouping_0;

        //    internal bool method_0(DataSetGES.Class125 row)
        //    {
        //        return (((((row["idCell"] == DBNull.Value) ? -1 : row.idCell) == this.class185_0.int_0) && (((row["idCable"] == DBNull.Value) ? -1 : row.idCable) == this.class185_0.int_1)) && (((row["Street"] == DBNull.Value) ? "" : row.Street) == this.igrouping_0.Key.Street));
        //    }
        //}
    }

}