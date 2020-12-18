using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using ControlsLbr.DataGridViewExcelFilter;
//using JournalCalcLoss.Report;
//using JournalCalcLoss;
//using Documents.Properties;
using FormLbr;
using FormLbr.Classes;
using Constants;
using JournalCalcLoss;
/// <summary>
/// Расчет потерь в КЛ/ВЛ
/// </summary>

public partial class FormAddEditCalcCable : FormBase
	{
        

        private int idLossCable=-1;

        private int TypeCalc=-1;

        private int IdAbn=-1;

        private int IdAbnObj=-1;

        private int IdAbnBalance=-1;

        private Dictionary<int, int> unitYearLosses = new Dictionary<int, int>();

        private bool allowSpace=false;

        public int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}
        private int id;
 
        public FormAddEditCalcCable()
		{
		
			this.InitializeComponent();
			this.InitTxtBox();
		}

		public FormAddEditCalcCable(int id, int typeCalc, int idAbn = -1, int idAbnObj = -1)
		{
			this.InitializeComponent();
			this.id = id;
			this.TypeCalc = typeCalc;
			this.IdAbnBalance = idAbn;
			this.IdAbn = idAbn;
			this.IdAbnObj = idAbnObj;
			this.InitTxtBox();
		}

		private void InitTxtBox()
		{
			this.txtLineLenght.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtLineLenght.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
			this.txtUdActiveResistance.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtUdActiveResistance.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
			this.txtCountChain.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtCountChain.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
			this.txtConsumtion.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtConsumtion.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
			this.txtPeriod.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtPeriod.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
			this.txtLoadAverage.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtLoadAverage.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
			this.txtCoeffPowerReactive.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtCoeffPowerReactive.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
			this.txtVoltageValue.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtVoltageValue.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
			this.txtActiveResistance.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtActiveResistance.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
			this.txtSquareCoeff.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtSquareCoeff.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
			this.txtCoeffDifference.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtCoeffDifference.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
			this.txtUnitYearLoss.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtUnitYearLoss.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
			this.txtYearLoss.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtYearLoss.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
			this.txtSumLoadLoss.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtSumLoadLoss.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
			this.txtCoeffIsolation.TextChanged += new EventHandler(this.textBox_TextChanged);
			this.txtCoeffIsolation.KeyPress +=new KeyPressEventHandler(this.textBox_KeyPress);
		}

		private void InitDictionary()
		{
			this.unitYearLosses.Add(6, 310);
			this.unitYearLosses.Add(10, 510);
			this.unitYearLosses.Add(15, 750);
			this.unitYearLosses.Add(20, 1000);
			this.unitYearLosses.Add(35, 1070);
		}

		private void textBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			NumberFormatInfo numberFormat = CultureInfo.CurrentCulture.NumberFormat;
			string numberDecimalSeparator = numberFormat.NumberDecimalSeparator;
			string text = numberFormat.NumberGroupSeparator;
			string negativeSign = numberFormat.NegativeSign;
			if (text == '\u00a0'.ToString())
			{
				text = " ";
			}
			string text2 = e.KeyChar.ToString();
			if (!char.IsDigit(e.KeyChar) && !text2.Equals(numberDecimalSeparator) && !text2.Equals(text) && !text2.Equals(negativeSign) && e.KeyChar != '\b' && (!this.allowSpace || e.KeyChar != ' '))
			{
				e.Handled = true;
			}
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.CalcActiveResistance();
				this.CalcLoadAverage();
				this.CalcLoadPowerLoss();
				this.CalcLoadLosses();
				this.CalcYearLoss();
				this.CalcSumLoadLoss();
				this.CalcCoefLoss();
				this.CalcIsolationLoss();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void FormAddEditCalcCable_Load(object sender, EventArgs e)
		{
			this.InitDictionary();
			this.LoadLossIsolation();
			if (this.Id == -1)
			{
				this.CreateCalcLoss();
			}
			else
			{
				base.SelectSqlData(this.dataSetCalc.tUser, true, "", null, false, 0);
				base.SelectSqlData(this.dataSetCalc.tJ_CalcLoss, true, "where id = " + this.id.ToString(), null, false, 0);
				if (this.dataSetCalc.tJ_CalcLoss.Rows.Count > 0)
				{
					if (this.dataSetCalc.tJ_CalcLoss.Rows[0]["idAbn"] != DBNull.Value)
					{
						this.txtAbn.Tag = (this.IdAbn = Convert.ToInt32(this.dataSetCalc.tJ_CalcLoss.Rows[0]["idAbn"]));
						base.SelectSqlData(this.dataSetCalc.tAbn, true, "where id = " + this.IdAbn.ToString(), null, false, 0);
						if (this.dataSetCalc.tAbn.Rows.Count > 0)
						{
							this.txtAbn.Text = this.dataSetCalc.tAbn.Rows[0]["Name"].ToString();
						}
						if (this.dataSetCalc.tJ_CalcLoss.Rows[0]["idAbnObj"] != DBNull.Value)
						{
							this.cmbAbnObj.Tag = (this.IdAbnObj = Convert.ToInt32(this.dataSetCalc.tJ_CalcLoss.Rows[0]["idAbnObj"]));
						}
						this.InitCmbAbnObj();
					}
					if (this.dataSetCalc.tJ_CalcLoss.Rows[0]["idAbnBalance"] != DBNull.Value)
					{
						this.txtAbnBalance.Tag = (this.IdAbnBalance = Convert.ToInt32(this.dataSetCalc.tJ_CalcLoss.Rows[0]["idAbnBalance"]));
						base.SelectSqlData(this.dataSetCalc.tAbn, true, "where id = " + this.IdAbnBalance.ToString(), null, false, 0);
						if (this.dataSetCalc.tAbn.Rows.Count > 0)
						{
							this.txtAbnBalance.Text = this.dataSetCalc.tAbn.Rows[0]["Name"].ToString();
						}
					}
					base.SelectSqlData(this.dataSetCalc, this.dataSetCalc.tJ_CalcLossCable, true, " where idCalc = " + this.id.ToString());
					if (this.dataSetCalc.tJ_CalcLossCable.Rows.Count == 0)
					{
						this.CreateCalcLossCable();
					}
					else
					{
						this.idLossCable = Convert.ToInt32(this.dataSetCalc.tJ_CalcLossCable.Rows[0]["id"]);
						base.SelectSqlData(this.dataSetCalc.vR_Cable, true, "where id= " + this.dataSetCalc.tJ_CalcLossCable.Rows[0]["makeupCable"].ToString(), null, false, 0);
						if (this.dataSetCalc.vR_Cable.Rows.Count > 0)
						{
							this.txtMakeupCable.Text = this.dataSetCalc.vR_Cable.Rows[0]["FullName"].ToString();
						}
					}
					this.LoadCalcLossFile();
				}
				else
				{
					this.CreateCalcLoss();
				}
			}
			if (this.TypeCalc != 1198)
			{
				this.DelUnitYearLossControl();
			}
		}

		private void CreateCalcLoss()
		{
			base.SelectSqlData(this.dataSetCalc.tUser, true, "where Login = SYSTEM_USER", null, false, 0);
			this.cmbOwner.SelectedIndex = -1;
			base.SelectSqlData(this.dataSetCalc.tR_Classifier, true, "where id = " + this.TypeCalc.ToString(), null, false, 0);
			DataRow dataRow = this.dataSetCalc.tJ_CalcLoss.NewRow();
			dataRow["typeCalc"] = this.TypeCalc;
			if (this.dataSetCalc.tR_Classifier.Rows.Count > 0)
			{
				dataRow["nameCalc"] = this.dataSetCalc.tR_Classifier.Rows[0]["name"];
			}
			dataRow["idAbnObj"] = -1;
			dataRow["idAbnBalance"] = -1;
			dataRow["DateCalc"] = DateTime.Now.Date;
			if (this.dataSetCalc.tUser.Rows.Count > 0)
			{
				dataRow["idowner"] = this.dataSetCalc.tUser.Rows[0]["idUser"];
			}
			dataRow["isActive"] = true;
			dataRow["deleted"] = false;
			dataRow["tpName"] = "Источник питания: ";
			this.dataSetCalc.tJ_CalcLoss.Rows.Add(dataRow);
			this.initAbn();
			this.CreateCalcLossCable();
		}

		private void CreateCalcLossCable()
		{
			DataRow dataRow = this.dataSetCalc.tJ_CalcLossCable.NewRow();
			dataRow["idCalc"] = -1;
			dataRow["makeupCable"] = -1;
			dataRow["CoeffPowerREactive"] = 0.6;
			dataRow["CountChain"] = 1;
			dataRow["SquareCoeffFromGraph"] = 1.33;
			dataRow["CoeffDifferences"] = 0.99;
			this.dataSetCalc.tJ_CalcLossCable.Rows.Add(dataRow);
		}

		private void initAbn()
		{
			if (this.IdAbn != -1)
			{
				this.dataSetCalc.tJ_CalcLoss.Rows[0]["idAbn"] = this.IdAbn;
				base.SelectSqlData(this.dataSetCalc.tAbn, true, "where id = " + this.IdAbn.ToString(), null, false, 0);
				if (this.dataSetCalc.tAbn.Rows.Count > 0)
				{
					this.txtAbn.Text = this.dataSetCalc.tAbn.Rows[0]["Name"].ToString();
				}
			}
			if (this.IdAbnBalance != -1)
			{
				this.dataSetCalc.tJ_CalcLoss.Rows[0]["idAbnBalance"] = this.IdAbnBalance;
				base.SelectSqlData(this.dataSetCalc.tAbn, true, "where id = " + this.IdAbnBalance.ToString(), null, false, 0);
				if (this.dataSetCalc.tAbn.Rows.Count > 0)
				{
					this.txtAbnBalance.Text = this.dataSetCalc.tAbn.Rows[0]["Name"].ToString();
				}
			}
			if (this.IdAbnObj != -1)
			{
				this.dataSetCalc.tJ_CalcLoss.Rows[0]["idAbnObj"] = this.IdAbnObj;
			}
			this.InitCmbAbnObj();
			this.InitTPName();
		}

		private void InitTPName()
		{
			if (string.IsNullOrEmpty(this.txtTPName.Text))
			{
				base.SelectSqlData(this.dataSetCalc.vL_SchmAbn, true, "where idAbn = " + this.IdAbn.ToString() + " or idAbnObj = " + this.IdAbnObj.ToString(), null, false, 0);
				foreach (DataRow dataRow in this.dataSetCalc.vL_SchmAbn)
				{
					if (!string.IsNullOrEmpty(this.txtTPName.Text))
					{
						TextBox textBox = this.txtTPName;
						textBox.Text += ", ";
					}
					TextBox textBox2 = this.txtTPName;
					textBox2.Text += dataRow["SchmObjName"].ToString();
				}
			}
		}

		private void toolBtnContractor_Click(object sender, EventArgs e)
		{
			FormSelectAddAbn formTechConnectionAddAbn = new FormSelectAddAbn(this.IdAbn, this.IdAbnObj, true);
			formTechConnectionAddAbn.ShowForm +=new ShowFormEventHandler( this.f_ShowForm);
			formTechConnectionAddAbn.SqlSettings = this.SqlSettings;
			formTechConnectionAddAbn.MdiParent = base.MdiParent;
			formTechConnectionAddAbn.FormClosed +=new FormClosedEventHandler( this.f_FormClosed);
			formTechConnectionAddAbn.Show();
		}

		private void f_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormSelectAddAbn formTechConnectionAddAbn = (FormSelectAddAbn)sender;
			if (formTechConnectionAddAbn.DialogResult == DialogResult.OK)
			{
				this.txtAbn.Text = formTechConnectionAddAbn.AbnName;
				if (string.IsNullOrEmpty(this.txtAbnBalance.Text))
				{
					this.txtAbnBalance.Text = formTechConnectionAddAbn.AbnName;
					this.txtAbnBalance.Tag = (this.IdAbnBalance = formTechConnectionAddAbn.IdAbn);
					this.dataSetCalc.tJ_CalcLoss.Rows[0]["idAbnBalance"] = this.IdAbnBalance;
				}
				this.txtAbn.Tag = (this.IdAbn = formTechConnectionAddAbn.IdAbn);
				this.dataSetCalc.tJ_CalcLoss.Rows[0]["idAbn"] = this.IdAbn;
				this.cmbAbnObj.Tag = (this.IdAbnObj = formTechConnectionAddAbn.IdAbnObj);
				this.dataSetCalc.tJ_CalcLoss.Rows[0]["idAbnObj"] = this.IdAbnObj;
				this.InitCmbAbnObj();
				this.InitTPName();
			}
		}

		private FormBase f_ShowForm(object sender, ShowFormEventArgs e)
		{
			return this.OnShowForm(e);
		}

		private void InitCmbAbnObj()
		{
            CalcLossN.DataSet.DataSetCalc.tAbnDataTable tAbnDataTable = new CalcLossN.DataSet.DataSetCalc.tAbnDataTable();
			base.SelectSqlData(tAbnDataTable, true, " where id = " + this.IdAbn.ToString(), null, false, 0);
			if (tAbnDataTable.Rows.Count > 0)
			{
				this.cmbAbnObj.SelectedValueChanged -= this.cmbAbnObj_SelectedValueChanged;
				int typeAbn = Convert.ToInt32(tAbnDataTable.Rows[0]["typeAbn"]);

                CalcLossN.DataSet.DataSetCalc.vAbnObjAddressDataTable vAbnObjAddressDataTable = new CalcLossN.DataSet.DataSetCalc.vAbnObjAddressDataTable();
				DataColumn dataColumn = new DataColumn("AddressFL");
				dataColumn.Expression = "street + ', д. ' + houseall + ', кв. ' + name";
				vAbnObjAddressDataTable.Columns.Add(dataColumn);
				dataColumn = new DataColumn("AddressUL");
				dataColumn.Expression = "street + ', д. ' + houseall";
				vAbnObjAddressDataTable.Columns.Add(dataColumn);
				base.SelectSqlData(vAbnObjAddressDataTable, true, "where idAbn = " + this.IdAbn.ToString() + " order by name", null, false, 0);
                this.cmbAbnObj.ValueMember = "id";
                this.cmbAbnObj.DataSource = vAbnObjAddressDataTable;
                if (typeAbn == (int)AbnType.KontragentFL || typeAbn == (int)AbnType.Private || typeAbn == (int)AbnType.PrivateNoDog)
                    this.cmbAbnObj.DisplayMember = "name";
                else
                    this.cmbAbnObj.DisplayMember = "AddressFL";

                this.cmbAbnObj.SelectedValue = this.IdAbnObj;
				this.cmbAbnObj.SelectedValueChanged +=new EventHandler( this.cmbAbnObj_SelectedValueChanged);
				return;
			}
			this.cmbAbnObj.Items.Clear();
		}

		private void cmbAbnObj_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.cmbAbnObj.SelectedValue != null || this.cmbAbnObj.SelectedValue != DBNull.Value)
			{
				this.cmbAbnObj.Tag = (this.IdAbnObj = Convert.ToInt32(this.cmbAbnObj.SelectedValue));
			}
		}

		private void buttonAbnBalance_Click(object sender, EventArgs e)
		{
			FormSelectAddAbn formTechConnectionAddAbn = new FormSelectAddAbn(this.IdAbnBalance, -1, true);
            formTechConnectionAddAbn.ShowForm += new ShowFormEventHandler(this.f_ShowForm);
            
			formTechConnectionAddAbn.SqlSettings = this.SqlSettings;
			formTechConnectionAddAbn.MdiParent = base.MdiParent;
			formTechConnectionAddAbn.FormClosed +=new FormClosedEventHandler( this.fBalance_FormClosed);
			formTechConnectionAddAbn.Show();
		}

		private void fBalance_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormSelectAddAbn formTechConnectionAddAbn = (FormSelectAddAbn)sender;
			if (formTechConnectionAddAbn.DialogResult == DialogResult.OK)
			{
				this.txtAbnBalance.Text = formTechConnectionAddAbn.AbnName;
				this.txtAbnBalance.Tag = (this.IdAbnBalance = formTechConnectionAddAbn.IdAbn);
				this.dataSetCalc.tJ_CalcLoss.Rows[0]["idAbnBalance"] = this.IdAbnBalance;
			}
		}

		private void buttonMakeupCable_Click(object sender, EventArgs e)
		{
			FormSelectCable form = new FormSelectCable();
			form.ShowForm +=new ShowFormEventHandler( this.f_ShowForm);
			form.SqlSettings = this.SqlSettings;
			form.MdiParent = base.MdiParent;
			form.FormClosed += new FormClosedEventHandler(this.fSelectCable_FormClosed);
			form.Show();
		}

		private void fSelectCable_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (((Form)sender).DialogResult == DialogResult.OK)
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["makeupCable"] = ((FormSelectCable)sender).Id;
				this.txtMakeupCable.Text = ((FormSelectCable)sender).GetMakeupCable();
				if (((FormSelectCable)sender).Resistance == null)
				{
					this.txtUdActiveResistance.Text = null;
					this.dataSetCalc.tJ_CalcLossCable.Rows[0]["UdResistance"] = DBNull.Value;
				}
				else
				{
					this.txtUdActiveResistance.Text = ((FormSelectCable)sender).Resistance.ToString();
					this.dataSetCalc.tJ_CalcLossCable.Rows[0]["UdResistance"] = ((FormSelectCable)sender).Resistance;
				}
				if (((FormSelectCable)sender).VoltageValue == null)
				{
					this.txtVoltageValue.Text = null;
					this.dataSetCalc.tJ_CalcLossCable.Rows[0]["Voltage"] = DBNull.Value;
				}
				else
				{
					this.txtVoltageValue.Text = this.RoundDecimal(Convert.ToDecimal(((FormSelectCable)sender).VoltageValue), 2).ToString();
					this.dataSetCalc.tJ_CalcLossCable.Rows[0]["Voltage"] = this.RoundDecimal(Convert.ToDecimal(((FormSelectCable)sender).VoltageValue), 2);
				}
				if (((FormSelectCable)sender).CrossSection == null)
				{
					this.ResetIsolationLoss();
					return;
				}
				int num = this.TypeCalc;
				if (num != 1197)
				{
					if (num == 1198 && this.dataTableVLIsolation.Rows.Count > 0)
					{
						if (this.dataSetCalc.tJ_CalcLossCable.Rows[0]["Voltage"] == DBNull.Value)
						{
							this.ResetIsolationLoss();
							return;
						}
						if (Convert.ToSingle(this.dataSetCalc.tJ_CalcLossCable.Rows[0]["Voltage"]) == 6f && this.dataTableVLIsolation.Rows[0]["Isolation6"] != DBNull.Value)
						{
							this.txtCoeffIsolation.Text = this.dataTableVLIsolation.Rows[0]["Isolation6"].ToString();
							this.dataSetCalc.tJ_CalcLossCable.Rows[0]["CoeffIsolation"] = Convert.ToSingle(this.dataTableVLIsolation.Rows[0]["Isolation6"]);
							return;
						}
						if (Convert.ToSingle(this.dataSetCalc.tJ_CalcLossCable.Rows[0]["Voltage"]) == 10f && this.dataTableVLIsolation.Rows[0]["Isolation10"] != DBNull.Value)
						{
							this.txtCoeffIsolation.Text = this.dataTableVLIsolation.Rows[0]["Isolation10"].ToString();
							this.dataSetCalc.tJ_CalcLossCable.Rows[0]["CoeffIsolation"] = Convert.ToSingle(this.dataTableVLIsolation.Rows[0]["Isolation10"]);
							return;
						}
						this.ResetIsolationLoss();
						return;
					}
				}
				else
				{
					DataRow[] array = this.dataTableKLIsolation.Select("Section = " + ((FormSelectCable)sender).CrossSection.ToString());
					if (array.Length != 0)
					{
						if (this.dataSetCalc.tJ_CalcLossCable.Rows[0]["Voltage"] == DBNull.Value)
						{
							this.ResetIsolationLoss();
							return;
						}
						if (Convert.ToSingle(this.dataSetCalc.tJ_CalcLossCable.Rows[0]["Voltage"]) == 6f && array[0]["Isolation6"] != DBNull.Value)
						{
							this.txtCoeffIsolation.Text = array[0]["Isolation6"].ToString();
							this.dataSetCalc.tJ_CalcLossCable.Rows[0]["CoeffIsolation"] = Convert.ToSingle(array[0]["Isolation6"]);
							return;
						}
						if (Convert.ToSingle(this.dataSetCalc.tJ_CalcLossCable.Rows[0]["Voltage"]) == 10f && array[0]["Isolation10"] != DBNull.Value)
						{
							this.txtCoeffIsolation.Text = array[0]["Isolation10"].ToString();
							this.dataSetCalc.tJ_CalcLossCable.Rows[0]["CoeffIsolation"] = Convert.ToSingle(array[0]["Isolation10"]);
							return;
						}
						this.ResetIsolationLoss();
						return;
					}
					else
					{
						this.ResetIsolationLoss();
					}
				}
			}
		}

		private void ResetIsolationLoss()
		{
			this.txtCoeffIsolation.Text = null;
			this.dataSetCalc.tJ_CalcLossCable.Rows[0]["CoeffIsolation"] = DBNull.Value;
			this.txtIsolationLoss.Text = null;
			this.dataSetCalc.tJ_CalcLossCable.Rows[0]["IsolationLosses"] = DBNull.Value;
		}

		private decimal RoundDecimal(decimal d, int digits)
		{
			if (d == 0m)
			{
				return d;
			}
			decimal num = Math.Round(d, digits);
			if (digits < 15 && !(num != 0m))
			{
				return this.RoundDecimal(d, digits + 1);
			}
			return num;
		}

		private void CalcActiveResistance()
		{
			if (!string.IsNullOrEmpty(this.txtUdActiveResistance.Text) && !string.IsNullOrEmpty(this.txtLineLenght.Text) && !string.IsNullOrEmpty(this.txtCountChain.Text))
			{
				this.txtActiveResistance.Text = this.RoundDecimal(Convert.ToDecimal(this.txtUdActiveResistance.Text) * Convert.ToDecimal(this.txtLineLenght.Text) / Convert.ToDecimal(this.txtCountChain.Text), 5).ToString();
				return;
			}
			this.txtActiveResistance.Text = null;
		}

		private void CalcLoadAverage()
		{
			if (!string.IsNullOrEmpty(this.txtConsumtion.Text) && !string.IsNullOrEmpty(this.txtPeriod.Text))
			{
				this.txtLoadAverage.Text = this.RoundDecimal(0.001m * Convert.ToDecimal(this.txtConsumtion.Text) / Convert.ToDecimal(this.txtPeriod.Text), 5).ToString();
				return;
			}
			this.txtLoadAverage.Text = null;
		}

		private void CalcLoadPowerLoss()
		{
			if (!string.IsNullOrEmpty(this.txtLoadAverage.Text) && !string.IsNullOrEmpty(this.txtCoeffPowerReactive.Text) && !string.IsNullOrEmpty(this.txtVoltageValue.Text) && !string.IsNullOrEmpty(this.txtActiveResistance.Text))
			{
				this.txtLoadPowerLoss.Text = this.RoundDecimal(1000m * Convert.ToDecimal(this.txtLoadAverage.Text) * Convert.ToDecimal(this.txtLoadAverage.Text) * Convert.ToDecimal(this.txtActiveResistance.Text) * (1m + Convert.ToDecimal(this.txtCoeffPowerReactive.Text) * Convert.ToDecimal(this.txtCoeffPowerReactive.Text)) / (Convert.ToDecimal(this.txtVoltageValue.Text) * Convert.ToDecimal(this.txtVoltageValue.Text)), 5).ToString();
				return;
			}
			this.txtLoadPowerLoss.Text = null;
		}

		private void CalcLoadLosses()
		{
			if (!string.IsNullOrEmpty(this.txtSquareCoeff.Text) && !string.IsNullOrEmpty(this.txtCoeffDifference.Text) && !string.IsNullOrEmpty(this.txtLoadPowerLoss.Text) && !string.IsNullOrEmpty(this.txtPeriod.Text))
			{
				this.txtLoadLosses.Text = this.RoundDecimal(Convert.ToDecimal(this.txtCoeffDifference.Text) * Convert.ToDecimal(this.txtLoadPowerLoss.Text) * Convert.ToDecimal(this.txtPeriod.Text) * Convert.ToDecimal(this.txtSquareCoeff.Text), 5).ToString();
				return;
			}
			this.txtLoadLosses.Text = null;
		}

		private void CalcYearLoss()
		{
			if (!string.IsNullOrEmpty(this.txtUnitYearLoss.Text) && !string.IsNullOrEmpty(this.txtLineLenght.Text))
			{
				this.txtYearLoss.Text = this.RoundDecimal(Convert.ToDecimal(this.txtLineLenght.Text) * Convert.ToDecimal(this.txtUnitYearLoss.Text), 5).ToString();
				return;
			}
			this.txtYearLoss.Text = null;
		}

		private void CalcSumLoadLoss()
		{
			if (!string.IsNullOrEmpty(this.txtYearLoss.Text) && !string.IsNullOrEmpty(this.txtLoadLosses.Text))
			{
				this.txtSumLoadLoss.Text = (Convert.ToDecimal(this.txtYearLoss.Text) + Convert.ToDecimal(this.txtLoadLosses.Text)).ToString();
				return;
			}
			this.txtSumLoadLoss.Text = null;
		}

		private void CalcCoefLoss()
		{
			if (string.IsNullOrEmpty(this.txtSumLoadLoss.Text))
			{
				if (!string.IsNullOrEmpty(this.txtLoadLosses.Text) && !string.IsNullOrEmpty(this.txtConsumtion.Text))
				{
					this.txtCoefLoss.Text = this.RoundDecimal(100m * Convert.ToDecimal(this.txtLoadLosses.Text) / Convert.ToDecimal(this.txtConsumtion.Text), 3).ToString();
					return;
				}
				this.txtCoefLoss.Text = null;
				return;
			}
			else
			{
				if (!string.IsNullOrEmpty(this.txtConsumtion.Text))
				{
					this.txtCoefLoss.Text = this.RoundDecimal(100m * Convert.ToDecimal(this.txtSumLoadLoss.Text) / Convert.ToDecimal(this.txtConsumtion.Text), 3).ToString();
					return;
				}
				this.txtCoefLoss.Text = null;
				return;
			}
		}

		private void CalcIsolationLoss()
		{
			if (!string.IsNullOrEmpty(this.txtLineLenght.Text) && !string.IsNullOrEmpty(this.txtCoeffIsolation.Text) && !string.IsNullOrEmpty(this.txtCountChain.Text))
			{
				this.txtIsolationLoss.Text = (Convert.ToDecimal(this.txtLineLenght.Text) * Convert.ToDecimal(this.txtCoeffIsolation.Text) * Convert.ToDecimal(this.txtCountChain.Text) * 1000m).ToString();
				return;
			}
			this.txtIsolationLoss.Text = null;
		}

		private void txtVoltageValue_TextChanged(object sender, EventArgs e)
		{
			float num;
			if (!string.IsNullOrEmpty(this.txtVoltageValue.Text) && float.TryParse(this.txtVoltageValue.Text, out num))
			{
				if (num < 1f)
				{
					this.DelUnitYearLossControl();
					return;
				}
				if (this.TypeCalc == 1198)
				{
					this.InsUnitYearLossControl();
					int key;
					if (int.TryParse(this.txtVoltageValue.Text, out key))
					{
						if (this.unitYearLosses.ContainsKey(key))
						{
							this.txtUnitYearLoss.Text = this.unitYearLosses[key].ToString();
							return;
						}
						if (string.IsNullOrEmpty(this.txtUnitYearLoss.Text))
						{
							this.txtUnitYearLoss.Text = this.unitYearLosses[6].ToString();
							return;
						}
					}
					else
					{
						this.txtUnitYearLoss.Text = null;
					}
				}
			}
		}

		private void DelUnitYearLossControl()
		{
			this.txtSumLoadLoss.Visible = false;
            this.labelParamSumLoadLoss.Visible = false;
            this.labelSumLoadLoss.Visible = false;
            this.txtYearLoss.Visible = false;
            this.txtUnitYearLoss.Visible = false;
            this.labelParamUnitYearLoss.Visible = false;
            this.labelParamYearLoss.Visible = false;
            this.labelUnitYearLoss.Visible = false;
			this.txtCoefLoss.Top = 402;
            this.labelParamCoefLoss.Top = 402;
            this.labelCoefLoss.Top = 402;
			this.checkBoxIsIsolation.Top = 421;
            this.labelIsIsolation.Top = 421;
			this.txtCoeffIsolation.Top = 440;
            this.labelUnitCoeffIsolation.Top = 440;
            this.labelCoeffIsolataion.Top = 440;
			this.txtIsolationLoss.Top = 460;
            this.labelUnitIsolationLoss.Top = 460;
            this.labelIsolationLoss.Top = 460;
			this.txtComment.Top = 486;
            this.labelComment.Top = 486;
			this.txtComment.Height = base.Height - 67 - 486;
			this.MinimumSize = new Size(550, 640);
		}

		private void InsUnitYearLossControl()
		{
			this.txtSumLoadLoss.Visible = true;
            this.labelParamSumLoadLoss.Visible = true;
            this.labelSumLoadLoss.Visible = true;
            this.txtYearLoss.Visible = true;
            this.txtUnitYearLoss.Visible = true;
            this.labelParamUnitYearLoss.Visible = true;
            this.labelParamYearLoss.Visible = true;
            this.labelUnitYearLoss.Visible = true;

            this.txtCoefLoss.Top = 462;
            this.labelParamCoefLoss.Top = 462;
            this.labelCoefLoss.Top = 462;

			this.checkBoxIsIsolation.Top = 481;
            this.labelIsIsolation.Top = 481;

			this.txtCoeffIsolation.Top = 500;
            this.labelUnitCoeffIsolation.Top = 500;
            this.labelCoeffIsolataion.Top = 500;

			this.txtIsolationLoss.Top = 520;
            this.labelUnitIsolationLoss.Top = 520;
            this.labelIsolationLoss.Top = 520;

			this.txtComment.Top = 546;
            this.labelComment.Top = 546;

			this.txtComment.Height = base.Height - 67 - 546;
			this.MinimumSize = new Size(550, 700);
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (this.CheckSave())
			{
				this.SaveLossIsolation();
				if (this.Id == -1)
				{
					this.dataSetCalc.tJ_CalcLoss.Rows[0].EndEdit();
					this.Id = base.InsertSqlDataOneRow(this.dataSetCalc, this.dataSetCalc.tJ_CalcLoss);
					if (this.Id >= 0 && this.SaveFiles())
					{
						this.UpdateCalcLossCable();
						this.idLossCable = base.InsertSqlDataOneRow(this.dataSetCalc, this.dataSetCalc.tJ_CalcLossCable);
						if (this.idLossCable > 0)
						{
							base.DialogResult = DialogResult.OK;
							base.Close();
							return;
						}
					}
				}
				else
				{
					this.dataSetCalc.tJ_CalcLoss.Rows[0].EndEdit();
					if (base.UpdateSqlData(this.dataSetCalc, this.dataSetCalc.tJ_CalcLoss) && this.SaveFiles())
					{
						this.UpdateCalcLossCable();
						if (this.idLossCable == -1)
						{
							this.idLossCable = base.InsertSqlDataOneRow(this.dataSetCalc, this.dataSetCalc.tJ_CalcLossCable);
							if (this.idLossCable > 0)
							{
								base.DialogResult = DialogResult.OK;
								base.Close();
								return;
							}
						}
						else if (base.UpdateSqlData(this.dataSetCalc, this.dataSetCalc.tJ_CalcLossCable))
						{
							base.DialogResult = DialogResult.OK;
							base.Close();
						}
					}
				}
			}
		}

		private bool SaveFiles()
		{
			bool result;
			try
			{
				foreach (DataRow dataRow in this.dataSetCalc.tJ_CalcLossFile)
				{
					if (dataRow.RowState != DataRowState.Deleted && dataRow.RowState != DataRowState.Detached)
					{
						dataRow["idCalc"] = this.id;
						dataRow.EndEdit();
					}
				}
				base.InsertSqlData(this.dataSetCalc, this.dataSetCalc.tJ_CalcLossFile);
				base.UpdateSqlData(this.dataSetCalc, this.dataSetCalc.tJ_CalcLossFile);
				base.DeleteSqlData(this.dataSetCalc, this.dataSetCalc.tJ_CalcLossFile);
				result = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
				result = false;
			}
			return result;
		}

		private void UpdateCalcLossCable()
		{
			this.dataSetCalc.tJ_CalcLossCable.Rows[0]["idCalc"] = this.id;
			if (string.IsNullOrEmpty(this.txtCoeffIsolation.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["coeffIsolation"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["coeffIsolation"] = Convert.ToDecimal(this.txtCoeffIsolation.Text);
			}
			if (string.IsNullOrEmpty(this.txtIsolationLoss.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["isolationlosses"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["isolationlosses"] = Convert.ToDecimal(this.txtIsolationLoss.Text);
			}
			if (string.IsNullOrEmpty(this.txtUdActiveResistance.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["UdResistance"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["UdResistance"] = Convert.ToDecimal(this.txtUdActiveResistance.Text);
			}
			if (string.IsNullOrEmpty(this.txtVoltageValue.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["Voltage"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["Voltage"] = this.txtVoltageValue.Text;
			}
			if (string.IsNullOrEmpty(this.txtLineLenght.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["lenghtCable"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["lenghtCable"] = Convert.ToDecimal(this.txtLineLenght.Text);
			}
			if (string.IsNullOrEmpty(this.txtConsumtion.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["consumption"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["consumption"] = this.txtConsumtion.Text;
			}
			if (string.IsNullOrEmpty(this.txtPeriod.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["period"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["period"] = this.txtPeriod.Text;
			}
			if (string.IsNullOrEmpty(this.txtCoeffPowerReactive.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["CoeffPowerReactive"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["CoeffPowerReactive"] = Convert.ToDecimal(this.txtCoeffPowerReactive.Text);
			}
			if (string.IsNullOrEmpty(this.txtSquareCoeff.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["SquareCoeffFromGraph"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["SquareCoeffFromGraph"] = Convert.ToDecimal(this.txtSquareCoeff.Text);
			}
			if (string.IsNullOrEmpty(this.txtCoeffDifference.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["CoeffDifferences"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["CoeffDifferences"] = Convert.ToDecimal(this.txtCoeffDifference.Text);
			}
			if (string.IsNullOrEmpty(this.txtCountChain.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["CountChain"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["CountChain"] = this.txtCountChain.Text;
			}
			if (string.IsNullOrEmpty(this.txtActiveResistance.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["ActiveResistance"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["ActiveResistance"] = Convert.ToDecimal(this.txtActiveResistance.Text);
			}
			if (string.IsNullOrEmpty(this.txtLoadPowerLoss.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["LoadPowerLoss"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["LoadPowerLoss"] = Convert.ToDecimal(this.txtLoadPowerLoss.Text);
			}
			if (string.IsNullOrEmpty(this.txtLoadAverage.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["LoadAverage"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["LoadAverage"] = Convert.ToDecimal(this.txtLoadAverage.Text);
			}
			if (string.IsNullOrEmpty(this.txtLoadLosses.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["LoadLosses"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["LoadLosses"] = Convert.ToDecimal(this.txtLoadLosses.Text);
			}
			if (string.IsNullOrEmpty(this.txtUnitYearLoss.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["UnitYearLoss"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["UnitYearLoss"] = Convert.ToDecimal(this.txtUnitYearLoss.Text);
			}
			if (string.IsNullOrEmpty(this.txtYearLoss.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["YearLoss"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["YearLoss"] = Convert.ToDecimal(this.txtYearLoss.Text);
			}
			if (string.IsNullOrEmpty(this.txtSumLoadLoss.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["SumLoadLosses"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["SumLoadLosses"] = Convert.ToDecimal(this.txtSumLoadLoss.Text);
			}
			if (string.IsNullOrEmpty(this.txtCoefLoss.Text))
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["CoeffLosses"] = DBNull.Value;
			}
			else
			{
				this.dataSetCalc.tJ_CalcLossCable.Rows[0]["CoeffLosses"] = Convert.ToDecimal(this.txtCoefLoss.Text);
			}
			this.dataSetCalc.tJ_CalcLossCable.Rows[0].EndEdit();
		}

		private bool CheckSave()
		{
			if (this.cmbAbnObj.SelectedIndex < 0)
			{
				MessageBox.Show("Не указан объект абонента");
				return false;
			}
			if (string.IsNullOrEmpty(this.txtAbnBalance.Text))
			{
				MessageBox.Show("Не указана балансовая принадлежность");
				return false;
			}
			return true;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			this.dataSetCalc.tJ_CalcLoss.Rows[0].EndEdit();
			this.UpdateCalcLossCable();
			new FormReportCalcLoss(this.dataSetCalc.tJ_CalcLoss, this.dataSetCalc.tJ_CalcLossCable)
			{
				MdiParent = base.MdiParent,
				SqlSettings = this.SqlSettings
			}.Show();
		}

		private void LoadCalcLossFile()
		{
			base.SelectSqlData(this.dataSetCalc.tJ_CalcLossFile, true, " where idCalc = " + this.id.ToString(), null, false, 0);
		}

		private void dgvFiles_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
			if (this.dgvFiles.RowCount > 0 && this.dgvFiles[this.fileNameDataGridViewTextBoxColumn.Name, e.RowIndex].Value != null && e.ColumnIndex == this.dgvFiles.Columns[this.ColumnImage.Name].Index)
			{
				Icon icon = FormLbr.Classes.FileInfo.IconOfFile(this.dgvFiles[this.fileNameDataGridViewTextBoxColumn.Name, e.RowIndex].Value.ToString());
				e.Value = icon.ToBitmap();
			}
		}

		private void toolBtnFileAdd_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Multiselect = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					for (int i = 0; i < openFileDialog.FileNames.Length; i++)
					{
						DataRow dataRow = this.dataSetCalc.tJ_CalcLossFile.NewRow();
						dataRow["idCalc"] = this.id;
						dataRow["File"] = File.ReadAllBytes(openFileDialog.FileNames[i]);
						dataRow["FileName"] = Path.GetFileName(openFileDialog.FileNames[i]);
						dataRow["DateIn"] = DateTime.Now;
						this.dataSetCalc.tJ_CalcLossFile.Rows.Add(dataRow);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void toolBtnFileDelete_Click(object sender, EventArgs e)
		{
			if (this.dgvFiles.CurrentRow != null)
			{
				this.dgvFiles.Rows.Remove(this.dgvFiles.CurrentRow);
				return;
			}
			MessageBox.Show("Не выбрано ни одного файла");
		}

		private void toolBtnFileView_Click(object sender, EventArgs e)
		{
			if (this.dgvFiles.CurrentRow == null)
			{
				return;
			}
			int num = Convert.ToInt32(this.dgvFiles.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
			DataRow[] array = this.dataSetCalc.tJ_CalcLossFile.Select("id = " + num.ToString());
			if (array.Length != 0)
			{
				byte[] buffer = (byte[])array[0]["File"];
				string text = Path.GetTempFileName();
				text = Path.ChangeExtension(text, Path.GetExtension(array[0]["FileName"].ToString()));
				FileStream fileStream = File.Create(text);
				fileStream.Write(buffer, 0, buffer.Length);
				fileStream.Close();
				new Process
				{
					StartInfo = 
					{
						FileName = text,
						UseShellExecute = true
					}
				}.Start();
			}
		}

		private void toolBtnFileSave_Click(object sender, EventArgs e)
		{
			try
			{
				int num = Convert.ToInt32(this.dgvFiles.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
				DataRow[] array = this.dataSetCalc.tJ_CalcLossFile.Select("id = " + num.ToString());
				if (array.Length != 0)
				{
					string text = this.dgvFiles.CurrentRow.Cells[this.fileNameDataGridViewTextBoxColumn.Name].Value.ToString();
					string extension = Path.GetExtension(text);
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.Filter = "(*" + extension + ")|*" + extension;
					saveFileDialog.FileName = text;
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						byte[] array2 = (byte[])array[0]["file"];
						FileStream fileStream = File.Create(saveFileDialog.FileName);
						fileStream.Write(array2, 0, array2.Length);
						fileStream.Close();
						MessageBox.Show("Файл успешно сохранен", "Сохранение");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void dgvFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == this.dgvFiles.Columns[this.fileNameDataGridViewTextBoxColumn.Name].Index)
			{
				this.toolBtnFileView_Click(sender, e);
			}
		}

		private void LoadLossIsolation()
		{
			base.SelectSqlData(this.dataTableSettings, true, " where Module = 'calcLossIsolation'", null, false, 0);
			if (this.dataTableSettings.Rows.Count > 0 && this.dataTableSettings.Rows[0]["settings"] != DBNull.Value)
			{
				XmlDocument xmlDocument = new XmlDocument();
				try
				{
					xmlDocument.LoadXml(this.dataTableSettings.Rows[0]["Settings"].ToString());
					XmlNode xmlNode = xmlDocument.SelectSingleNode("Isolation");
					XmlNode xmlNode2 = xmlNode.SelectSingleNode("dtKLIsolation");
					this.dataTableKLIsolation.Clear();
					foreach (XmlNode xmlNode3 in xmlNode2.SelectNodes("Rows"))
					{
						this.dataTableKLIsolation.Rows.Add(new object[]
						{
							xmlNode3.Attributes["Section"].Value,
							xmlNode3.Attributes["Isolation6"].Value,
							xmlNode3.Attributes["Isolation10"].Value
						});
					}
					if (this.dataTableKLIsolation.Rows.Count == 0)
					{
						this.AddValuesDataTableKLIsolation();
					}
					XmlNode xmlNode4 = xmlNode.SelectSingleNode("dtVLIsolation");
					this.dataTableVLIsolation.Clear();
					foreach (XmlNode xmlNode5 in xmlNode4.SelectNodes("Rows"))
					{
						this.dataTableVLIsolation.Rows.Add(new object[]
						{
							xmlNode5.Attributes["Isolation6"].Value,
							xmlNode5.Attributes["Isolation10"].Value
						});
					}
					if (this.dataTableVLIsolation.Rows.Count == 0)
					{
						this.AddValuesDataTableVLIsolation();
					}
					return;
				}
				catch
				{
                    this.AddValuesDataTableKLIsolation();
                    this.AddValuesDataTableVLIsolation();
                    return;
				}
			}
            this.AddValuesDataTableKLIsolation();
            this.AddValuesDataTableVLIsolation();
        }

        //private void AddValuesDataTableIsolation()
        //{
        //	this.AddValuesDataTableKLIsolation();
        //	this.AddValuesDataTableVLIsolation();
        //}

        private void AddValuesDataTableKLIsolation()
		{
			this.dataTableKLIsolation.Clear();
			this.dataTableKLIsolation.Rows.Add(new object[]
			{
				10,
				0.14,
				0.33
			});
			this.dataTableKLIsolation.Rows.Add(new object[]
			{
				16,
				0.17,
				0.37
			});
			this.dataTableKLIsolation.Rows.Add(new object[]
			{
				25,
				0.26,
				0.55
			});
			this.dataTableKLIsolation.Rows.Add(new object[]
			{
				35,
				0.29,
				0.68
			});
			this.dataTableKLIsolation.Rows.Add(new object[]
			{
				50,
				0.33,
				0.75
			});
			this.dataTableKLIsolation.Rows.Add(new object[]
			{
				70,
				0.42,
				0.86
			});
			this.dataTableKLIsolation.Rows.Add(new object[]
			{
				95,
				0.55,
				0.99
			});
			this.dataTableKLIsolation.Rows.Add(new object[]
			{
				120,
				0.6,
				1.08
			});
			this.dataTableKLIsolation.Rows.Add(new object[]
			{
				150,
				0.67,
				1.17
			});
			this.dataTableKLIsolation.Rows.Add(new object[]
			{
				185,
				0.74,
				1.28
			});
			this.dataTableKLIsolation.Rows.Add(new object[]
			{
				240,
				0.83,
				1.67
			});
		}

		private void AddValuesDataTableVLIsolation()
		{
			this.dataTableVLIsolation.Clear();
			this.dataTableVLIsolation.Rows.Add(new object[]
			{
				0.31,
				0.51
			});
		}

		private void SaveLossIsolation()
		{
			if (this.dataTableSettings != null)
			{
				XmlDocument xmlDocument = new XmlDocument();
				XmlNode xmlNode = xmlDocument.CreateElement("Isolation");
				xmlDocument.AppendChild(xmlNode);
				XmlNode xmlNode2 = xmlDocument.CreateElement("dtKLIsolation");
				xmlNode.AppendChild(xmlNode2);
				foreach (DataRow dataRow in this.dataTableKLIsolation.Rows)
				{
					XmlNode xmlNode3 = xmlDocument.CreateElement("Rows");
					xmlNode2.AppendChild(xmlNode3);
					XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("Section");
					xmlAttribute.Value = dataRow["Section"].ToString();
					xmlNode3.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute("Isolation6");
					xmlAttribute.Value = dataRow["Isolation6"].ToString();
					xmlNode3.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute("Isolation10");
					xmlAttribute.Value = dataRow["isolation10"].ToString();
					xmlNode3.Attributes.Append(xmlAttribute);
				}
				XmlNode xmlNode4 = xmlDocument.CreateElement("dtVLIsolation");
				xmlNode.AppendChild(xmlNode4);
				foreach (DataRow dataRow2 in this.dataTableVLIsolation.Rows)
				{
					XmlNode xmlNode5 = xmlDocument.CreateElement("Rows");
					xmlNode4.AppendChild(xmlNode5);
					XmlAttribute xmlAttribute2 = xmlDocument.CreateAttribute("Isolation6");
					xmlAttribute2.Value = dataRow2["Isolation6"].ToString();
					xmlNode5.Attributes.Append(xmlAttribute2);
					xmlAttribute2 = xmlDocument.CreateAttribute("Isolation10");
					xmlAttribute2.Value = dataRow2["isolation10"].ToString();
					xmlNode5.Attributes.Append(xmlAttribute2);
				}
				if (this.dataTableSettings.Rows.Count == 0)
				{
					DataRow dataRow3 = this.dataTableSettings.NewRow();
					dataRow3["settings"] = xmlDocument.InnerXml;
					dataRow3["module"] = "calcLossIsolation";
					this.dataTableSettings.Rows.Add(dataRow3);
					base.InsertSqlData(this.dataTableSettings);
					this.LoadLossIsolation();
					return;
				}
				this.dataTableSettings.Rows[0]["Settings"] = xmlDocument.InnerXml;
				this.dataTableSettings.Rows[0].EndEdit();
				base.UpdateSqlData(this.dataTableSettings);
			}
		}

		private void checkBoxIsIsolation_CheckedChanged(object sender, EventArgs e)
		{
			this.txtCoeffIsolation.Enabled = this.checkBoxIsIsolation.Checked;
		}

		
	}

