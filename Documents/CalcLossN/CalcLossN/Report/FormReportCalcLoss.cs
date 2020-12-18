using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using ControlsLbr.ReportViewerRus;
using FormLbr;
//using JournalCalcLoss.Report;
using Microsoft.Reporting.WinForms;
/// <summary>
/// Печать расчета потерь
/// </summary>
	public partial class FormReportCalcLoss : FormBase
	{
        private bool isKL = true;
        private int Id = -1;
        private bool isIsolationLoss;
        private DateTime DateCalc = DateTime.Now;
        /// <summary>
        /// дата начала округления
        /// </summary>
        private DateTime DateCalcBeginRound = new DateTime(2014, 9, 1);
        private string Lenghtcable = "";
        private string CountChain = "";

        public FormReportCalcLoss()
		{
			this.InitializeComponent();
		}

		public FormReportCalcLoss(int id)
		{
			this.InitializeComponent();
			this.Id = id;
		}

		public FormReportCalcLoss(DataTable dtCalcLoss, DataTable dtCalcLossCable)
		{
			this.InitializeComponent();
			if (dtCalcLoss.Rows.Count > 0)
			{
				this.dsCalcN.tJ_CalcLoss.ImportRow(dtCalcLoss.Rows[0]);
			}
			if (dtCalcLossCable.Rows.Count > 0)
			{
				this.dsCalcN.tJ_CalcLossCable.ImportRow(dtCalcLossCable.Rows[0]);
			}
		}

		private void FormReportCalcLoss_Load(object sender, EventArgs e)
		{
			base.LoadFormConfig(null);
			if (this.Id != -1)
			{
				base.SelectSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLoss, true, "where id = " + this.Id.ToString());
				base.SelectSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossCable, true, "where idcalc = " + this.Id.ToString());
			}
			if (this.dsCalcN.tJ_CalcLoss.Rows.Count > 0)
			{
				this.DateCalc = Convert.ToDateTime(this.dsCalcN.tJ_CalcLoss.Rows[0]["DateCalc"]);
				string text;
				if (this.dsCalcN.tJ_CalcLoss.Rows[0]["num"] == DBNull.Value)
				{
					text = "№ -1";
				}
				else
				{
					text = "№ " + this.dsCalcN.tJ_CalcLoss.Rows[0]["num"].ToString();
				}
				text = text + " от " + Convert.ToDateTime(this.dsCalcN.tJ_CalcLoss.Rows[0]["DateCalc"]).ToString("dd MMMM yyyy");
				ReportParameter reportParameter = new ReportParameter("numDate", text);
				this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
				{
					reportParameter
				});
				this.LoadTypeCalc();
				this.LoadAbnBalance();
				this.LoadTpName();
				this.LoadDataTable();
				this.LoadActiveResistance();
				this.LoadLoadAverage();
				this.LoadPowerLoss();
				this.LoadLosses();
				this.LoadYearLoss();
				this.LoadSumLoadLoss();
				this.LoadCoeffLoss();
				this.LoadIsolationLoss();
				this.SetDatePerform();
				this.SetTitleJob();
				this.SetFIOBoss();
			}
			this.reportViewer1.RefreshReport();
		}

		private void FormReportCalcLoss_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.SaveFormConfig(null);
		}

        private void LoadTypeCalc()
        {
            int typeCalc = Convert.ToInt32(this.dsCalcN.tJ_CalcLoss.Rows[0]["typeCalc"]);
            if (this.dsCalcN.tJ_CalcLossCable.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossCable.Rows[0]["IsIsolation"] != DBNull.Value)
            {
                this.isIsolationLoss = Convert.ToBoolean(this.dsCalcN.tJ_CalcLossCable.Rows[0]["isIsolation"]);
            }
            string typeCalcStr = "";
            string typeMin = "";
            string typeMax = "";
            switch (typeCalc)
            {
                case 1198:
                    typeCalcStr = (typeMax = "ВЛ");
                    typeMin = "вл";
                    if (this.isIsolationLoss)
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "CalcLossN.Report.ReportVLIsolation.rdlc";
                    }
                    else
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "CalcLossN.Report.ReportVL.rdlc";
                    }
                    this.isKL = false;
                    if (this.dsCalcN.tJ_CalcLossCable.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossCable.Rows[0]["Voltage"] != DBNull.Value && Convert.ToSingle(this.dsCalcN.tJ_CalcLossCable.Rows[0]["Voltage"]) < 1f)
                    {
                        if (this.isIsolationLoss)
                        {
                            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CalcLossN.Report.ReportVLIsolation.rdlc";
                        }
                        else
                        {
                            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CalcLossN.Report.ReportKL.rdlc";
                        }
                        this.isKL = true;
                    }
                    break;
                case 1197:
                    typeCalcStr = (typeMax = "КЛ");
                    if (this.isIsolationLoss)
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "CalcLossN.Report.ReportKLIsolation.rdlc";
                    }
                    else
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "CalcLossN.Report.ReportKL.rdlc";
                    }
                    this.isKL = true;
                    typeMin = "кл";
                    break;
            }

            if (this.dsCalcN.tJ_CalcLossCable.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossCable.Rows[0]["Voltage"] != DBNull.Value)
            {
                typeCalcStr = string.Concat(new object[]
                {
                    typeCalcStr,
                    " ",
                    this.dsCalcN.tJ_CalcLossCable.Rows[0]["Voltage"],
                    "кВ"
                });
            }
            ReportParameter reportParameter = new ReportParameter("typeCalcStr", typeCalcStr);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            {
                reportParameter
            });
            reportParameter = new ReportParameter("typeMin", typeMin);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            {
                reportParameter
            });
            reportParameter = new ReportParameter("typeMax", typeMax);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            {
                reportParameter
            });
            reportParameter = new ReportParameter("isKL", this.isKL.ToString());
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            {
                reportParameter
            });
        }

        private void LoadAbnBalance()
		{
			string text = "";
			if (this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnBalance"] != DBNull.Value)
			{
				base.SelectSqlData(this.dsCalcN, this.dsCalcN.tAbn, true, "where id = " + this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnBalance"].ToString());
				if (this.dsCalcN.tAbn.Rows.Count > 0)
				{
					text = this.dsCalcN.tAbn.Rows[0]["name"].ToString();
				}
				if (this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbn"] != DBNull.Value && this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnBalance"].ToString() == this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbn"].ToString() && this.dsCalcN.tAbn.Rows.Count > 0)
				{
					if (Convert.ToInt32(this.dsCalcN.tAbn.Rows[0]["codeAbonent"]) > 0)
					{
						text = text + " д." + this.dsCalcN.tAbn.Rows[0]["codeAbonent"].ToString();
					}
					int typeAbn = Convert.ToInt32(this.dsCalcN.tAbn.Rows[0]["typeAbn"]);
					if (this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnObj"] != DBNull.Value)
					{
                        CalcLossN.DataSet.DataSetCalc.vAbnObjAddressDataTable tblAbnObjAddressDataTable = new CalcLossN.DataSet.DataSetCalc.vAbnObjAddressDataTable();
						DataColumn dataColumn = new DataColumn("AddressFL");
						dataColumn.Expression = "street + ', д. ' + houseall + ', кв. ' + name";
						tblAbnObjAddressDataTable.Columns.Add(dataColumn);
						base.SelectSqlData(tblAbnObjAddressDataTable, true, "where id = " + this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnObj"].ToString(), null, false, 0);
						if (tblAbnObjAddressDataTable.Rows.Count > 0)
						{
                            if (typeAbn == 206 || typeAbn == 253 || typeAbn == 1037)
                            {
									text = text + " (" + tblAbnObjAddressDataTable.Rows[0]["name"].ToString() + ")";
							}
                            else
							text = text + " (" + tblAbnObjAddressDataTable.Rows[0]["AddressFL"].ToString() + ")";
						}
					}
				}
			}
			ReportParameter reportParameter = new ReportParameter("AbnBalance", text);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
		}

		private void LoadTpName()
		{
			string tpName = "";
			if (this.dsCalcN.tJ_CalcLoss.Rows[0]["tpName"] != DBNull.Value)
			{
				tpName = this.dsCalcN.tJ_CalcLoss.Rows[0]["tpName"].ToString();
			}
			if (this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbn"] != DBNull.Value && this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnBalance"].ToString() != this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbn"].ToString())
			{
				base.SelectSqlData(this.dsCalcN, this.dsCalcN.tAbn, true, "where id = " + this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbn"].ToString());
				if (this.dsCalcN.tAbn.Rows.Count > 0)
				{
					tpName = tpName + " (" + this.dsCalcN.tAbn.Rows[0]["name"].ToString();
					if (Convert.ToInt32(this.dsCalcN.tAbn.Rows[0]["codeAbonent"]) > 0)
					{
						tpName = tpName + " д." + this.dsCalcN.tAbn.Rows[0]["codeAbonent"].ToString() + ")";
					}
					else
					{
						tpName += ")";
					}
				}
			}
			ReportParameter reportParameter = new ReportParameter("tpName", tpName);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
		}

		private void LoadDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("Desription");
			dataTable.Columns.Add("Dimension");
			dataTable.Columns.Add("Val");
			if (this.dsCalcN.tJ_CalcLossCable.Rows.Count > 0)
			{
				if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["lenghtcable"] != DBNull.Value)
				{
					this.Lenghtcable = Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["lenghtcable"]).AsString();
				}
				string text = "Длина линии";
				if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["makeupCable"] != DBNull.Value)
				{
					base.SelectSqlData(this.dsCalcN.vR_Cable, true, "where id = " + this.dsCalcN.tJ_CalcLossCable.Rows[0]["makeupCable"].ToString(), null, false, 0);
					if (this.dsCalcN.vR_Cable.Rows.Count > 0 && this.dsCalcN.vR_Cable.Rows[0]["CableMakeup"] != DBNull.Value && this.dsCalcN.vR_Cable.Rows[0]["CrossSection"] != DBNull.Value)
					{
						if (this.dsCalcN.vR_Cable.Rows[0]["Wires"] != DBNull.Value)
						{
							text = string.Concat(new string[]
							{
								text,
								", (",
								this.dsCalcN.vR_Cable.Rows[0]["CableMakeup"].ToString(),
								" ",
								this.dsCalcN.vR_Cable.Rows[0]["Wires"].ToString(),
								"x",
								this.dsCalcN.vR_Cable.Rows[0]["CrossSection"].ToString(),
								")"
							});
							if (this.dsCalcN.vR_Cable.Rows[0]["WiresAddl"] != DBNull.Value && Convert.ToInt32(this.dsCalcN.vR_Cable.Rows[0]["WiresAddl"]) > 0 && this.dsCalcN.vR_Cable.Rows[0]["CrossSectionAddl"] != DBNull.Value)
							{
								text = string.Concat(new string[]
								{
									text.Remove(text.Length - 1),
									" + ",
									this.dsCalcN.vR_Cable.Rows[0]["WiresAddl"].ToString(),
									"x",
									this.dsCalcN.vR_Cable.Rows[0]["CrossSectionAddl"].ToString(),
									")"
								});
							}
						}
						else
						{
							text = string.Concat(new string[]
							{
								text,
								", (",
								this.dsCalcN.vR_Cable.Rows[0]["CableMakeup"].ToString(),
								"-",
								this.dsCalcN.vR_Cable.Rows[0]["CrossSection"].ToString(),
								")"
							});
						}
					}
				}
				dataTable.Rows.Add(new object[]
				{
					text,
					"L, км",
					this.Lenghtcable
				});
				if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["UdResistance"] != DBNull.Value)
				{
					dataTable.Rows.Add(new object[]
					{
						"Удельное активное сопротивление линии на 1 км провода",
						"r0, Ом/км",
						Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["UdResistance"]).AsString()
					});
				}
				else
				{
					dataTable.Rows.Add(new object[]
					{
						"Удельное активное сопротивление линии на 1 км провода",
						"r0, Ом/км",
						""
					});
				}
				if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["Voltage"] != DBNull.Value)
				{
					dataTable.Rows.Add(new object[]
					{
						"Среднее напряжение линии",
						"Uср, кВ",
						Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["Voltage"]).AsString()
					});
				}
				else
				{
					dataTable.Rows.Add(new object[]
					{
						"Среднее напряжение линии",
						"Uср, кВ",
						""
					});
				}
				if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["Consumption"] != DBNull.Value)
				{
					dataTable.Rows.Add(new object[]
					{
						"Потребление активной электроэнергии за базовый период по счетчику",
						"Wт, кВт*ч",
						this.dsCalcN.tJ_CalcLossCable.Rows[0]["Consumption"].ToString()
					});
				}
				else
				{
					dataTable.Rows.Add(new object[]
					{
						"Потребление активной электроэнергии за базовый период по счетчику",
						"Wт, кВт*ч",
						""
					});
				}
				if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["period"] != DBNull.Value)
				{
					dataTable.Rows.Add(new object[]
					{
						"Базовый (расчетный) период",
						"Т, час",
						this.dsCalcN.tJ_CalcLossCable.Rows[0]["period"].ToString()
					});
				}
				else
				{
					dataTable.Rows.Add(new object[]
					{
						"Базовый (расчетный) период",
						"Т, час",
						""
					});
				}
				if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["CoeffPowerReactive"] != DBNull.Value)
				{
					dataTable.Rows.Add(new object[]
					{
						"Коэффициент реактивной мощности",
						"tg φ",
						Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["CoeffPowerReactive"]).AsString()
					});
				}
				else
				{
					dataTable.Rows.Add(new object[]
					{
						"Коэффициент реактивной мощности",
						"tg φ",
						""
					});
				}
				if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["SquareCoeffFromGraph"] != DBNull.Value)
				{
					dataTable.Rows.Add(new object[]
					{
						"Квадрат коэффициента формы графика за базовый период",
						"kφ², о.е.",
						Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["SquareCoeffFromGraph"]).AsString()
					});
				}
				else
				{
					dataTable.Rows.Add(new object[]
					{
						"Квадрат коэффициента формы графика за базовый период",
						"kφ², о.е.",
						""
					});
				}
				if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["CoeffDifferences"] != DBNull.Value)
				{
					dataTable.Rows.Add(new object[]
					{
						"Коэффициент учитывающий различие конфигураций графиков активной и реактивной нагрузки",
						"kк, о.е.",
						Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["CoeffDifferences"]).AsString()
					});
				}
				else
				{
					dataTable.Rows.Add(new object[]
					{
						"Коэффициент учитывающий различие конфигураций графиков активной и реактивной нагрузки",
						"kк, о.е.",
						""
					});
				}
				this.CountChain = this.dsCalcN.tJ_CalcLossCable.Rows[0]["CountChain"].ToString();
				dataTable.Rows.Add(new object[]
				{
					"Количество параллельных цепей",
					"nц, шт",
					this.CountChain
				});
			}
			ReportDataSource reportDataSource = new ReportDataSource();
			reportDataSource.Name = "dsSource";
			reportDataSource.Value = dataTable;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
		}

		private void LoadActiveResistance()
		{
			string ActiveResistance = "";
			if (this.dsCalcN.tJ_CalcLossCable.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossCable.Rows[0]["UdResistance"] != DBNull.Value && !string.IsNullOrEmpty(this.Lenghtcable) && !string.IsNullOrEmpty(this.CountChain) && this.dsCalcN.tJ_CalcLossCable.Rows[0]["ActiveResistance"] != DBNull.Value)
			{
				ActiveResistance = string.Concat(new string[]
				{
					" = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["UdResistance"]).AsString(),
					" * ",
					this.Lenghtcable,
					" / ",
					this.CountChain,
					" = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["ActiveResistance"]).AsString(),
					" Ом"
				});
			}
			ReportParameter reportParameter = new ReportParameter("ActiveResistance", ActiveResistance);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
		}

		private void LoadLoadAverage()
		{
			string Average = "";
			if (this.dsCalcN.tJ_CalcLossCable.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossCable.Rows[0]["Consumption"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["period"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["LoadAverage"] != DBNull.Value)
			{
				Average = string.Concat(new string[]
				{
					this.dsCalcN.tJ_CalcLossCable.Rows[0]["Consumption"].ToString(),
					" * 0.001 / ",
					this.dsCalcN.tJ_CalcLossCable.Rows[0]["period"].ToString(),
					" = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["LoadAverage"]).AsString(),
					" МВт"
				});
			}
			ReportParameter reportParameter = new ReportParameter("LoadAverage", Average);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
		}

		private void LoadPowerLoss()
		{
			string PowerLoss = "";
			if (this.dsCalcN.tJ_CalcLossCable.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossCable.Rows[0]["LoadAverage"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["ActiveResistance"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["CoeffPowerReactive"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["Voltage"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["LoadPowerLoss"] != DBNull.Value)
			{
				PowerLoss = string.Concat(new string[]
				{
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["LoadAverage"]).AsString(),
					"² * 1000 * ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["ActiveResistance"]).AsString(),
					" * (1 + ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["CoeffPowerReactive"]).AsString(),
					"²) / ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["Voltage"]).AsString(),
					"² = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["LoadPowerLoss"]).AsString(),
					" кВт"
				});
			}
			ReportParameter reportParameter = new ReportParameter("LoadPowerLoss", PowerLoss);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
		}

		private void LoadLosses()
		{
			string Losses = "";
			if (this.dsCalcN.tJ_CalcLossCable.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossCable.Rows[0]["LoadPowerLoss"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["CoeffDifferences"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["period"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["SquareCoeffFromGraph"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["LoadLosses"] != DBNull.Value)
			{
				Losses = string.Concat(new string[]
				{
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["CoeffDifferences"]).AsString(),
					" * ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["LoadPowerLoss"]).AsString(),
					" * ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["period"]).AsString(),
					" * ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["SquareCoeffFromGraph"]).AsString(),
					" = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["LoadLosses"]).AsString(),
					" кВт*ч"
				});
			}
			ReportParameter reportParameter = new ReportParameter("LoadLosses", Losses);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
		}

		private void LoadYearLoss()
		{
			string UnitYearLoss = "";
			string YearLoss = "";
			if (this.dsCalcN.tJ_CalcLossCable.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossCable.Rows[0]["Voltage"] != DBNull.Value)
			{
				UnitYearLoss = "1 км - " + Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["Voltage"]).AsString() + " кВ = ";
				if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["UnitYearLoss"] != DBNull.Value)
				{
					UnitYearLoss = UnitYearLoss + Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["UnitYearLoss"]).AsString() + " кВт.ч год";
				}
				if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["lenghtCable"] != DBNull.Value)
				{
					YearLoss = Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["lenghtCable"]).AsString() + " км - " + Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["Voltage"]).AsString() + " кВ = ";
					if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["YearLoss"] != DBNull.Value)
					{
						YearLoss = YearLoss + Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["YearLoss"]).AsString() + " кВт.ч год";
					}
				}
			}
			ReportParameter reportParameter = new ReportParameter("UnitYearLoss", UnitYearLoss);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
			reportParameter = new ReportParameter("YearLoss", YearLoss);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
		}

		private void LoadSumLoadLoss()
		{
			string SumLoss = "";
			if (this.dsCalcN.tJ_CalcLossCable.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossCable.Rows[0]["LoadLosses"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["YearLoss"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["SumLoadLosses"] != DBNull.Value)
			{
				SumLoss = string.Concat(new string[]
				{
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["LoadLosses"]).AsString(),
					" + ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["YearLoss"]).AsString(),
					" = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["SumLoadLosses"]).AsString(),
					" кВт"
				});
			}
			ReportParameter reportParameter = new ReportParameter("SumLoadLoss", SumLoss);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
		}

		private void LoadCoeffLoss()
		{
			string CoeffLoss = "";
			string Coefficient = "";
			if (this.dsCalcN.tJ_CalcLossCable.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossCable.Rows[0]["CoeffLosses"] != DBNull.Value)
			{
				Coefficient = Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["CoeffLosses"]).AsString();
				if (this.isKL)
				{
					if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["LoadLosses"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["Consumption"] != DBNull.Value)
					{
						CoeffLoss = string.Concat(new string[]
						{
							"100% * ",
							Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["LoadLosses"]).AsString(),
							" / ",
							this.dsCalcN.tJ_CalcLossCable.Rows[0]["Consumption"].ToString(),
							" = ",
							Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["CoeffLosses"]).AsString(),
							"%"
						});
					}
				}
				else if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["SumLoadLosses"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["Consumption"] != DBNull.Value)
				{
					CoeffLoss = string.Concat(new string[]
					{
						"100% * ",
						Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["SumLoadLosses"]).AsString(),
						" / ",
						this.dsCalcN.tJ_CalcLossCable.Rows[0]["Consumption"].ToString(),
						" = ",
						Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["CoeffLosses"]).AsString(),
						"%"
					});
				}
			}
			ReportParameter reportParameter = new ReportParameter("CoeffLoss", CoeffLoss);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
			reportParameter = new ReportParameter("Coefficient", Coefficient);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
		}

		private void LoadIsolationLoss()
		{
			if (!this.isIsolationLoss)
			{
				return;
			}
			string IsolationLoss = "";
			decimal IsolationLossValue = 0m;
			if (this.dsCalcN.tJ_CalcLossCable.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossCable.Rows[0]["isolationLosses"] != DBNull.Value)
			{
				IsolationLossValue = Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["isolationLosses"]);
				if (this.dsCalcN.tJ_CalcLossCable.Rows[0]["CoeffIsolation"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["lenghtCable"] != DBNull.Value && this.dsCalcN.tJ_CalcLossCable.Rows[0]["countChain"] != DBNull.Value)
				{
					IsolationLoss = string.Concat(new string[]
					{
						Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["CoeffIsolation"]).AsString(),
						" * ",
						Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["lenghtCable"]).AsString(),
						" * ",
						this.dsCalcN.tJ_CalcLossCable.Rows[0]["countChain"].ToString(),
						" * 1000 = ",
						(this.DateCalc > this.DateCalcBeginRound) ? Math.Round(Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["isolationLosses"]), 0).AsString() : Convert.ToDecimal(this.dsCalcN.tJ_CalcLossCable.Rows[0]["isolationLosses"]).AsString(),
						" кВт*ч"
					});
				}
			}
			ReportParameter reportParameter = new ReportParameter("IsolationLoss", IsolationLoss);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
			reportParameter = new ReportParameter("IsolationLossValue", IsolationLossValue.ToString());
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
			DataTable dataTable = new DataTable();
			for (int i = 1; i <= 12; i++)
			{
				dataTable.Columns.Add("Month" + i.ToString(), typeof(decimal));
			}
			DataRow dataRow = dataTable.NewRow();
			if (this.DateCalc < this.DateCalcBeginRound)
			{
				for (int j = 1; j <= 12; j++)
				{
					if (j == 2)
					{
						dataRow["Month" + j.ToString()] = Math.Round(IsolationLossValue, 2) - Math.Round(IsolationLossValue / 365m * 30m, 2) * 4m - Math.Round(IsolationLossValue / 365m * 31m, 2) * 7m;
					}
					else
					{
						dataRow["Month" + j.ToString()] = Math.Round(IsolationLossValue / 365m * DateTime.DaysInMonth(this.DateCalc.Year, j), 2);
					}
				}
			}
			else
			{
				for (int k = 1; k <= 12; k++)
				{
					if (k == 2)
					{
						dataRow["Month" + k.ToString()] = Math.Round(IsolationLossValue, 0) - Math.Round(IsolationLossValue / 365m * 30m, 0) * 4m - Math.Round(IsolationLossValue / 365m * 31m, 0) * 7m;
					}
					else
					{
						dataRow["Month" + k.ToString()] = Math.Round(IsolationLossValue / 365m * DateTime.DaysInMonth(this.DateCalc.Year, k), 0);
					}
				}
			}
			if (Convert.ToDecimal(dataRow["Month2"]) < 0m)
			{
				dataRow["Month1"] = Convert.ToDecimal(dataRow["Month1"]) + Convert.ToDecimal(dataRow["Month2"]);
				dataRow["Month2"] = 0;
				if (Convert.ToDecimal(dataRow["Month1"]) < 0m)
				{
					dataRow["Month3"] = Convert.ToDecimal(dataRow["Month3"]) + Convert.ToDecimal(dataRow["Month1"]);
					dataRow["Month1"] = 0;
					int num2 = 3;
					while (num2 <= 12 && Convert.ToDecimal(dataRow["Month" + num2.ToString()]) < 0m)
					{
						dataRow["Month" + (num2 + 1).ToString()] = Convert.ToDecimal(dataRow["Month" + (num2 + 1).ToString()]) + Convert.ToDecimal(dataRow["Month" + num2.ToString()]);
						dataRow["Month" + num2.ToString()] = 0;
						num2++;
					}
				}
			}
			dataTable.Rows.Add(dataRow);
			ReportDataSource reportDataSource = new ReportDataSource();
			reportDataSource.Name = "dtIsolationLoss";
			reportDataSource.Value = dataTable;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
		}

		private void txtFIO_TextChanged(object sender, EventArgs e)
		{
			ReportParameter reportParameter = new ReportParameter("FIOPerformer", this.FIOPerformer.Text);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
			this.reportViewer1.RefreshReport();
		}

		private void txtPhone_TextChanged(object sender, EventArgs e)
		{
			ReportParameter reportParameter = new ReportParameter("Phone", this.txtPhone.Text);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
			this.reportViewer1.RefreshReport();
		}

		private void dateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			ReportParameter reportParameter = new ReportParameter("DatePerform", this.dateTimePicker.Value.ToShortDateString());
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
			this.reportViewer1.RefreshReport();
		}

		private void SetDatePerform()
		{
			if (this.dsCalcN.tJ_CalcLoss.Rows.Count > 0 && this.dsCalcN.tJ_CalcLoss.Rows[0]["DateCalc"] != DBNull.Value)
			{
				this.dateTimePicker.Value = Convert.ToDateTime(this.dsCalcN.tJ_CalcLoss.Rows[0]["DateCalc"]);
			}
			else
			{
				this.dateTimePicker.Value = DateTime.Now;
			}
			ReportParameter reportParameter = new ReportParameter("DatePerform", this.dateTimePicker.Value.ToShortDateString());
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
		}

		protected override XmlDocument CreateXmlConfig()
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
			xmlDocument.AppendChild(newChild);
			XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
			xmlDocument.AppendChild(xmlNode);
			XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("FIOPerformer");
			xmlAttribute.Value = this.FIOPerformer.Text;
			xmlNode.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Phone");
			xmlAttribute.Value = this.txtPhone.Text;
			xmlNode.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("JobTitle");
			xmlAttribute.Value = this.txtTitleJob.Text;
			xmlNode.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("FIOBoss");
			xmlAttribute.Value = this.txtFIOBoss.Text;
			xmlNode.Attributes.Append(xmlAttribute);
			return xmlDocument;
		}

		protected override void ApplyConfig(XmlDocument doc)
		{
			XmlNode xmlNode = doc.SelectSingleNode(base.Name);
			if (xmlNode != null)
			{
				XmlAttribute xmlAttribute = xmlNode.Attributes["FIOPerformer"];
				if (xmlAttribute != null)
				{
					this.FIOPerformer.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode.Attributes["Phone"];
				if (xmlAttribute != null)
				{
					this.txtPhone.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode.Attributes["JobTitle"];
				if (xmlAttribute != null)
				{
					this.txtTitleJob.Text = xmlAttribute.Value;
				}
				xmlAttribute = xmlNode.Attributes["FIOBoss"];
				if (xmlAttribute != null)
				{
					this.txtFIOBoss.Text = xmlAttribute.Value;
				}
			}
		}

		private void SetTitleJob()
		{
			ReportParameter reportParameter = new ReportParameter("JobTitle", this.txtTitleJob.Text);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
			this.reportViewer1.RefreshReport();
		}

		private void SetFIOBoss()
		{
			ReportParameter reportParameter = new ReportParameter("FIOBoss", this.txtFIOBoss.Text);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
			this.reportViewer1.RefreshReport();
		}

		private void txtTitleJob_TextChanged(object sender, EventArgs e)
		{
			this.SetTitleJob();
		}

		private void txtFIOBoss_TextChanged(object sender, EventArgs e)
		{
			this.SetFIOBoss();
		}

	}

