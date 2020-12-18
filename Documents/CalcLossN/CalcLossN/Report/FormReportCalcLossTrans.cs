using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using Constants;
using ControlsLbr.ReportViewerRus;
using FormLbr;
//using JournalCalcLoss.Report;
using Microsoft.Reporting.WinForms;
/// <summary>
/// Печать расчета потерь трансформатора
/// </summary>

	public partial class FormReportCalcLossTrans : FormBase
    {
        private int Id = -1;
        public FormReportCalcLossTrans()
        {
            this.InitializeComponent();
		}

		public FormReportCalcLossTrans(int id)
		{
			this.InitializeComponent();
			this.Id = id;
		}

		public FormReportCalcLossTrans(DataTable dtCalcLoss, DataTable dtCalcLossCable)
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

		private void FormReportCalcLossTrans_Load(object sender, EventArgs e)
		{
			base.LoadFormConfig(null);
			if (this.Id != -1)
			{
				base.SelectSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLoss, true, "where id = " + this.Id.ToString());
				base.SelectSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossTrans, true, "where idcalc = " + this.Id.ToString() + " order by numTrans");
				base.SelectSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossTransHH, true, "where idcalc = " + this.Id.ToString());
				if (this.dsCalcN.tJ_CalcLossTransHH.Rows.Count == 0)
				{
					this.reportViewer1.LocalReport.ReportEmbeddedResource = "CalcLossN.Report.ReportTrans.rdlc";
				}
			}
			if (this.dsCalcN.tJ_CalcLoss.Rows.Count > 0)
			{
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
				this.LoadLossElectrHH();
				this.LoadDsTransHH();
				this.LoadDsTransSumHH();
				this.LoadActiveResistance();
				this.LoadLoadAverage();
				this.LoadPowerLoss();
				this.LoadLosses();
				this.LoadCoeffLoss();
				this.SetDatePerform();
				this.SetTitleJob();
				this.SetFIOBoss();
			}
			this.reportViewer1.RefreshReport();
		}

		private void FormReportCalcLossTrans_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.SaveFormConfig(null);
		}

		private void LoadTypeCalc()
		{
			string typeCalcStr = "";
			if (this.dsCalcN.tJ_CalcLossTrans.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["RatedPower"] != DBNull.Value)
			{
				typeCalcStr = typeCalcStr + Convert.ToInt32(Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["ratedpower"]) * 1000m).ToString() + " кВА";
			}
			ReportParameter reportParameter = new ReportParameter("typeCalcStr", typeCalcStr);
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
				if (this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbn"] != DBNull.Value && this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnBalance"].ToString() == this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbn"].ToString())
				{
					if (this.dsCalcN.tAbn.Rows.Count > 0)
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
                                if (typeAbn == (int)AbnType.KontragentFL || typeAbn == (int)AbnType.Private || typeAbn == (int)AbnType.PrivateNoDog)
                                    text = text + " (" + tblAbnObjAddressDataTable.Rows[0]["name"].ToString() + ")";
                                else
    								text = text + " (" + tblAbnObjAddressDataTable.Rows[0]["AddressFL"].ToString() + ")";
							}
						}
					}
				}
				else if (this.dsCalcN.tAbn.Rows.Count > 0)
				{
					if (Convert.ToInt32(this.dsCalcN.tAbn.Rows[0]["codeAbonent"]) > 0)
					{
						text = text + " д." + this.dsCalcN.tAbn.Rows[0]["codeAbonent"].ToString();
					}
					base.SelectSqlData(this.dsCalcN, this.dsCalcN.tAbn, true, "where id = " + this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbn"].ToString());
					if (this.dsCalcN.tAbn.Rows.Count > 0)
					{
						text = text + " для " + this.dsCalcN.tAbn.Rows[0]["name"].ToString();
						if (Convert.ToInt32(this.dsCalcN.tAbn.Rows[0]["codeAbonent"]) > 0)
						{
							text = text + " д." + this.dsCalcN.tAbn.Rows[0]["codeAbonent"].ToString();
						}
					}
					int typeAbn = Convert.ToInt32(this.dsCalcN.tAbn.Rows[0]["typeAbn"]);
					if (this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnObj"] != DBNull.Value)
					{
                        CalcLossN.DataSet.DataSetCalc.vAbnObjAddressDataTable tblAbnObjAddressDataTable = new CalcLossN.DataSet.DataSetCalc.vAbnObjAddressDataTable();
						DataColumn dataColumn2 = new DataColumn("AddressFL");
						dataColumn2.Expression = "street + ', д. ' + houseall + ', кв. ' + name";
						tblAbnObjAddressDataTable.Columns.Add(dataColumn2);
						base.SelectSqlData(tblAbnObjAddressDataTable, true, "where id = " + this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnObj"].ToString(), null, false, 0);
						if (tblAbnObjAddressDataTable.Rows.Count > 0)
						{
                           if (typeAbn == (int)AbnType.KontragentFL || typeAbn == (int)AbnType.Private || typeAbn == (int)AbnType.PrivateNoDog)
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
			if (this.dsCalcN.tJ_CalcLossTrans.Rows.Count > 0)
			{
				dataTable.Rows.Add(new object[]
				{
					"Номинальная мощность трансформатора",
					"Sном, МВА",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["RatedPower"]).AsString()
				});
				dataTable.Rows.Add(new object[]
				{
					"Количество трансформаторов",
					"n, шт",
					this.dsCalcN.tJ_CalcLossTrans.Rows.Count.ToString()
				});
				dataTable.Rows.Add(new object[]
				{
					"Потери мощности холостого хода",
					"∆Pхх, кВт",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["NoLoadLoss"]).AsString()
				});
				dataTable.Rows.Add(new object[]
				{
					"Потери мощности короткого замыкания",
					"∆Pкз, кВт",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["ShortCircuitLoss"]).AsString()
				});
				dataTable.Rows.Add(new object[]
				{
					"Годовое потребление активной электроэнергии за базовый период по счетчику",
					"Wт, кВт*ч",
					this.dsCalcN.tJ_CalcLossTrans.Rows[0]["Consumption"].ToString()
				});
				dataTable.Rows.Add(new object[]
				{
					"Номинальное напряжение высшей обмотки трансформатора",
					"Uном, кВ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["RatedVoltage"]).AsString()
				});
				dataTable.Rows.Add(new object[]
				{
					"Среднее напряжение на высшей стороне трансформатора за базовый период",
					"Uср, кВ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["MiddleVoltage"]).AsString()
				});
				dataTable.Rows.Add(new object[]
				{
					"Время работы трансформатора",
					"Т, час",
					this.dsCalcN.tJ_CalcLossTrans.Rows[0]["period"].ToString()
				});
				dataTable.Rows.Add(new object[]
				{
					"Коэффициент реактивной мощности",
					"tg φ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["CoeffPowerReactive"]).AsString()
				});
				dataTable.Rows.Add(new object[]
				{
					"Квадрат коэффициента формы графика за базовый период",
					"kφ², о.е.",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["SquareCoeffFromGraph"]).AsString()
				});
				dataTable.Rows.Add(new object[]
				{
					"Коэффициент учитывающий различие конфигураций графиков активной и реактивной нагрузки",
					"kк, о.е.",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["CoeffDifference"]).AsString()
				});
			}
			ReportDataSource reportDataSource = new ReportDataSource();
			reportDataSource.Name = "dsSource";
			reportDataSource.Value = dataTable;
			this.reportViewer1.LocalReport.DataSources.Clear();
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
		}

		private void LoadLossElectrHH()
		{
			string LossElectrHH = "";
			if (this.dsCalcN.tJ_CalcLossTrans.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["NoLoadLoss"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["Period"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["RatedVoltage"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["MiddleVoltage"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["LossElectrHH"] != DBNull.Value)
			{
				LossElectrHH = string.Concat(new string[]
				{
					" = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["NoLoadLoss"]).AsString(),
					" * ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["Period"]).AsString(),
					" * (",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["MiddleVoltage"]).AsString(),
					" / ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["RatedVoltage"]).AsString(),
					")² = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["LossElectrHH"]).AsString(),
					" кВт*ч"
				});
			}
			ReportParameter reportParameter = new ReportParameter("LossElectrHH", LossElectrHH);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
		}

		private void LoadDsTransHH()
		{
			if (this.dsCalcN.tJ_CalcLossTrans.Rows.Count > 0)
			{
                CalcLossN.DataSet.DataSetCalc.tJ_CalcLossTransHHDataTable tbl = new CalcLossN.DataSet.DataSetCalc.tJ_CalcLossTransHHDataTable();
				base.SelectSqlData(tbl, true, "where idTRans = " + this.dsCalcN.tJ_CalcLossTrans.Rows[0]["id"].ToString(), null, false, 0);
				ReportDataSource reportDataSource = new ReportDataSource();
				reportDataSource.Name = "dsTransHH";
				reportDataSource.Value = tbl;
				this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
			}
		}

		private void LoadDsTransSumHH()
		{
			if (this.dsCalcN.tJ_CalcLossTrans.Rows.Count > 0)
			{
				if (this.dsCalcN.tJ_CalcLossTransHH.Rows.Count > 2)
				{
					string value = "Т.к. в трансформаторной подстанции находятся " + (this.dsCalcN.tJ_CalcLossTransHH.Rows.Count - 1).ToString() + " силовых трансформатора, потери электроэнергии холостого хода учитываются в каждом. Следовательно, суммарные потери холостого хода силовых трансформаторов составят:";
					ReportParameter reportParameter = new ReportParameter("TransSumHH", value);
					this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
					{
						reportParameter
					});
				}
                CalcLossN.DataSet.DataSetCalc.tJ_CalcLossTransHHDataTable tbl = new CalcLossN.DataSet.DataSetCalc.tJ_CalcLossTransHHDataTable();
				base.SelectSqlData(tbl, true, "where idCalc = " + this.Id.ToString() + " and idTRans is null", null, false, 0);
				ReportDataSource reportDataSource = new ReportDataSource();
				reportDataSource.Name = "dsTransSumHH";
				reportDataSource.Value = tbl;
				this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
			}
		}

		private void LoadActiveResistance()
		{
			string ActiveResistance = "";
			if (this.dsCalcN.tJ_CalcLossTrans.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["ShortCircuitLoss"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["RatedVoltage"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["RatedPower"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["ActiveResistance"] != DBNull.Value)
			{
				ActiveResistance = string.Concat(new string[]
				{
					" = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["ShortCircuitLoss"]).AsString(),
					" * 0.001 * ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["RatedVoltage"]).AsString(),
					"² / ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["RatedPower"]).AsString(),
					"² = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["ActiveResistance"]).AsString(),
					" Ом/фазу"
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
			string LoadAverage = "";
			if (this.dsCalcN.tJ_CalcLossTrans.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["Consumption"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["period"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["LoadAverage"] != DBNull.Value)
			{
				LoadAverage = string.Concat(new string[]
				{
					" = ",
					this.dsCalcN.tJ_CalcLossTrans.Rows[0]["Consumption"].ToString(),
					" * 0.001 / ",
					this.dsCalcN.tJ_CalcLossTrans.Rows[0]["period"].ToString(),
					" = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["LoadAverage"]).AsString(),
					" МВт"
				});
			}
			ReportParameter reportParameter = new ReportParameter("LoadAverage", LoadAverage);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
		}

		private void LoadPowerLoss()
		{
			string PowerLoss = "";
			if (this.dsCalcN.tJ_CalcLossTrans.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["LoadAverage"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["ActiveResistance"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["CoeffPowerReactive"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["MiddleVoltage"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["LoadPowerLoss"] != DBNull.Value)
			{
				PowerLoss = string.Concat(new string[]
				{
					" = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["LoadAverage"]).AsString(),
					"² * 1000 * ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["ActiveResistance"]).AsString(),
					" * (1 + ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["CoeffPowerReactive"]).AsString(),
					"²) / ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["MiddleVoltage"]).AsString(),
					"² = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["LoadPowerLoss"]).AsString(),
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
			if (this.dsCalcN.tJ_CalcLossTrans.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["LoadPowerLoss"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["CoeffDifference"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["period"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["SquareCoeffFromGraph"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["LoadLosses"] != DBNull.Value)
			{
				Losses = string.Concat(new string[]
				{
					" = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["CoeffDifference"]).AsString(),
					" * ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["LoadPowerLoss"]).AsString(),
					" * ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["period"]).AsString(),
					" * ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["SquareCoeffFromGraph"]).AsString(),
					" = ",
					Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["LoadLosses"]).AsString(),
					" кВт*ч"
				});
			}
			ReportParameter reportParameter = new ReportParameter("LoadLosses", Losses);
			this.reportViewer1.LocalReport.SetParameters(new ReportParameter[]
			{
				reportParameter
			});
		}

		private void LoadCoeffLoss()
		{
			string CoeffLoss = "";
			string Coefficient = "";
			if (this.dsCalcN.tJ_CalcLossTrans.Rows.Count > 0 && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["CoeffLosses"] != DBNull.Value)
			{
				Coefficient = Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["CoeffLosses"]).AsString();
				if (this.dsCalcN.tJ_CalcLossTrans.Rows[0]["LoadLosses"] != DBNull.Value && this.dsCalcN.tJ_CalcLossTrans.Rows[0]["Consumption"] != DBNull.Value)
				{
					CoeffLoss = string.Concat(new string[]
					{
						"100% * ",
						Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["LoadLosses"]).AsString(),
						" / ",
						this.dsCalcN.tJ_CalcLossTrans.Rows[0]["Consumption"].ToString(),
						" = ",
						Convert.ToDecimal(this.dsCalcN.tJ_CalcLossTrans.Rows[0]["CoeffLosses"]).AsString(),
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

		private void txtFIO_TextChanged(object sender, EventArgs e)
		{
			ReportParameter reportParameter = new ReportParameter("FIOPerformer", this.txtFIO.Text);
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
			xmlAttribute.Value = this.txtFIO.Text;
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
					this.txtFIO.Text = xmlAttribute.Value;
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

