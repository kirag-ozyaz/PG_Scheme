using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
//using JournalCalcLoss.Report;
using JournalCalcLoss;
//using Documents.Properties;
using FormLbr;
using FormLbr.Classes;
using Constants;
/// <summary>
/// Расчет потерь в трансформаторе
/// </summary>

	public partial class FormAddEditCalcTrans : FormBase
	{
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}
        private int id_;
        // public int Id { get; set; }

        private int TypeCalc=-1;
        private int IdAbn=-1;
        private int IdAbnObj=-1;
        private int IdAbnBalance=-1;
        private bool allowSpace=false;
        private bool dgvMonthVisible;

        public FormAddEditCalcTrans()
		{
			this.InitializeComponent();
			this.InitTxtBox();
		}

		public FormAddEditCalcTrans(int id, int typeCalc, int idAbn = -1, int idAbnObj = -1)
		{
			this.InitializeComponent();
			this.id_ = id;
			this.TypeCalc = typeCalc;
			this.IdAbnBalance = idAbn;
			this.IdAbn = idAbn;
			this.IdAbnObj = idAbnObj;
			this.InitTxtBox();
		}

		private void InitTxtBox()
		{
			this.txtRatedPowerTrans1.TextChanged +=new EventHandler( this.txtBox_TextChanged);
			this.txtRatedPowerTrans1.KeyPress +=new KeyPressEventHandler( this.txtBox_KeyPress);
			this.txtNoLoadLoss.TextChanged +=new EventHandler( this.txtBox_TextChanged);
			this.txtNoLoadLoss.KeyPress +=new KeyPressEventHandler(this.txtBox_KeyPress);
			this.ShortCircuitLoss.TextChanged +=new EventHandler( this.txtBox_TextChanged);
			this.ShortCircuitLoss.KeyPress +=new KeyPressEventHandler(this.txtBox_KeyPress);
			this.txtMiddleVoltage.TextChanged +=new EventHandler( this.txtBox_TextChanged);
			this.txtMiddleVoltage.KeyPress +=new KeyPressEventHandler(this.txtBox_KeyPress);
			this.txtRatedVoltage.TextChanged +=new EventHandler( this.txtBox_TextChanged);
			this.txtRatedVoltage.KeyPress +=new KeyPressEventHandler(this.txtBox_KeyPress);
			this.txtConsumtion.TextChanged +=new EventHandler( this.txtBox_TextChanged);
			this.txtConsumtion.KeyPress +=new KeyPressEventHandler(this.txtBox_KeyPress);
			this.txtPeriod.TextChanged +=new EventHandler( this.txtBox_TextChanged);
			this.txtPeriod.KeyPress +=new KeyPressEventHandler(this.txtBox_KeyPress);
			this.txtActiveResistance.TextChanged +=new EventHandler( this.txtBox_TextChanged);
			this.txtActiveResistance.KeyPress +=new KeyPressEventHandler(this.txtBox_KeyPress);
			this.txtCoeffPowerReactive.TextChanged +=new EventHandler( this.txtBox_TextChanged);
			this.txtCoeffPowerReactive.KeyPress +=new KeyPressEventHandler(this.txtBox_KeyPress);
			this.txtLossElectrHH.TextChanged +=new EventHandler( this.txtBox_TextChanged);
			this.txtLossElectrHH.KeyPress +=new KeyPressEventHandler(this.txtBox_KeyPress);
			this.txtSquareCoeff.TextChanged +=new EventHandler( this.txtBox_TextChanged);
			this.txtSquareCoeff.KeyPress +=new KeyPressEventHandler(this.txtBox_KeyPress);
			this.txtCoeffDifference.TextChanged +=new EventHandler( this.txtBox_TextChanged);
			this.txtCoeffDifference.KeyPress +=new KeyPressEventHandler(this.txtBox_KeyPress);
			this.txtLoadAverage.TextChanged +=new EventHandler( this.txtBox_TextChanged);
			this.txtLoadAverage.KeyPress +=new KeyPressEventHandler(this.txtBox_KeyPress);
		}

		private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
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

		private void txtBox_TextChanged(object sender, EventArgs e)
		{
			TabPage tabPage_ = null;
			if (((TextBox)sender).Tag != null && ((TextBox)sender).Parent is TabPage)
			{
				tabPage_ = (TabPage)((TextBox)sender).Parent;
			}
			try
			{
				this.CalcLossElectrHH(tabPage_);
				this.CalcActiveResistance();
				this.CalcLoadAverage();
				this.CalcLoadPowerLoss();
				this.CalcLoadLosses();
				this.CalcCoefLoss();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void Control_TextChanged(object sender, EventArgs e)
		{
			TabPage tabPage_ = null;
			if (((TextBox)sender).Tag != null && ((TextBox)sender).Parent is TabPage)
			{
				tabPage_ = (TabPage)((TextBox)sender).Parent;
			}
			try
			{
				this.CalcLossElectrHH(tabPage_);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void FormAddEditCalcTrans_Load(object sender, EventArgs e)
		{
			this.dgvMonth.Rows.Add();
			this.dgvMonthSum.Rows.Add();
			if (this.Id == -1)
			{
				this.CreateCalcLoss();
				return;
			}
			base.SelectSqlData(this.dsCalcN.tUser, true, "", null, false, 0);
			base.SelectSqlData(this.dsCalcN.tJ_CalcLoss, true, "where id = " + this.id_.ToString(), null, false, 0);
			if (this.dsCalcN.tJ_CalcLoss.Rows.Count > 0)
			{
				if (this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbn"] != DBNull.Value)
				{
					this.txtAbn.Tag = (this.IdAbn = Convert.ToInt32(this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbn"]));
					base.SelectSqlData(this.dsCalcN.tAbn, true, "where id = " + this.IdAbn.ToString(), null, false, 0);
					if (this.dsCalcN.tAbn.Rows.Count > 0)
					{
						this.txtAbn.Text = this.dsCalcN.tAbn.Rows[0]["Name"].ToString();
					}
					if (this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnObj"] != DBNull.Value)
					{
						this.cmbAbnObj.Tag = (this.IdAbnObj = Convert.ToInt32(this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnObj"]));
					}
					this.InitCmbAbnObj();
				}
				if (this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnBalance"] != DBNull.Value)
				{
					this.txtAbnBalance.Tag = (this.IdAbnBalance = Convert.ToInt32(this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnBalance"]));
					base.SelectSqlData(this.dsCalcN.tAbn, true, "where id = " + this.IdAbnBalance.ToString(), null, false, 0);
					if (this.dsCalcN.tAbn.Rows.Count > 0)
					{
						this.txtAbnBalance.Text = this.dsCalcN.tAbn.Rows[0]["Name"].ToString();
					}
				}
				base.SelectSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossTrans, true, " where idCalc = " + this.id_.ToString() + " order by numTrans");
				if (this.dsCalcN.tJ_CalcLossTrans.Rows.Count == 0)
				{
					this.CreateCalcLossTrans();
				}
				else
				{
					this.LoadCalcTrans();
				}
				base.SelectSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossTransHH, true, " where idCalc = " + this.id_.ToString() + " order by id");
				this.LoadCalcLossFile();
				this.SetVisibleControls();
				return;
			}
			this.CreateCalcLoss();
		}

		private void CreateCalcLoss()
		{
			base.SelectSqlData(this.dsCalcN.tUser, true, "where Login = SYSTEM_USER", null, false, 0);
			this.cmbOwner.SelectedIndex = -1;

            base.SelectSqlData(this.dsCalcN.tR_Classifier, true, "where id = " + this.TypeCalc.ToString(), null, false, 0);
			DataRow dataRow = this.dsCalcN.tJ_CalcLoss.NewRow();
			dataRow["typeCalc"] = this.TypeCalc;
			if (this.dsCalcN.tR_Classifier.Rows.Count > 0)
			{
				dataRow["nameCalc"] = this.dsCalcN.tR_Classifier.Rows[0]["name"];
			}
			dataRow["idAbnObj"] = -1;
			dataRow["idAbnBalance"] = -1;
			dataRow["DateCalc"] = DateTime.Now.Date;

            if (this.dsCalcN.tUser.Rows.Count > 0)
			{
				dataRow["idowner"] = this.dsCalcN.tUser.Rows[0]["idUser"];
			}
			dataRow["isActive"] = true;
			dataRow["deleted"] = false;
			dataRow["tpName"] = "Источник питания: ";

            this.dsCalcN.tJ_CalcLoss.Rows.Add(dataRow);
			this.initAbn();
			this.CreateCalcLossTrans();
		}

		private void CreateCalcLossTrans()
		{
			this.txtCoeffPowerReactive.Text = 0.6.ToString();
			this.txtSquareCoeff.Text = 1.33.ToString();
			this.txtCoeffDifference.Text = 0.99.ToString();
		}

		private void initAbn()
		{
			if (this.IdAbn != -1)
			{
				this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbn"] = this.IdAbn;
				base.SelectSqlData(this.dsCalcN.tAbn, true, "where id = " + this.IdAbn.ToString(), null, false, 0);
				if (this.dsCalcN.tAbn.Rows.Count > 0)
				{
					this.txtAbn.Text = this.dsCalcN.tAbn.Rows[0]["Name"].ToString();
				}
			}
			if (this.IdAbnBalance != -1)
			{
				this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnBalance"] = this.IdAbnBalance;
				base.SelectSqlData(this.dsCalcN.tAbn, true, "where id = " + this.IdAbnBalance.ToString(), null, false, 0);
				if (this.dsCalcN.tAbn.Rows.Count > 0)
				{
					this.txtAbnBalance.Text = this.dsCalcN.tAbn.Rows[0]["Name"].ToString();
				}
			}
			if (this.IdAbnObj != -1)
			{
				this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnObj"] = this.IdAbnObj;
			}
			this.InitCmbAbnObj();
			this.InitTPName();
		}

		private void InitTPName()
		{
			if (string.IsNullOrEmpty(this.txtTPName.Text))
			{
				base.SelectSqlData(this.dsCalcN.vL_SchmAbn, true, "where idAbn = " + this.IdAbn.ToString() + " or idAbnObj = " + this.IdAbnObj.ToString(), null, false, 0);
				foreach (DataRow dataRow in this.dsCalcN.vL_SchmAbn)
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

		private void LoadCalcTrans()
		{
			int num = 0;
			foreach (DataRow dataRow in this.dsCalcN.tJ_CalcLossTrans)
			{
				TabPage tabPage;
				if (num == 0)
				{
					tabPage = this.tabPageTrans1;
				}
				else
				{
					tabPage = this.AddTabPage();
				}
				tabPage.Tag = dataRow["makeupTrans"];
				base.SelectSqlData(this.dsCalcN.vR_Transformer, true, "where id= " + dataRow["makeupTrans"].ToString(), null, false, 0);
				if (this.dsCalcN.vR_Transformer.Rows.Count > 0)
				{
					TextBox textBox = this.SearchTextBoxByTag(tabPage, "MakeupTrans");
					if (textBox != null)
					{
						textBox.Text = this.dsCalcN.vR_Transformer.Rows[0]["FullName"].ToString();
					}
				}
				this.LoadTxtByColumn(tabPage, dataRow, "RatedPower");
				this.LoadTxtByColumn(tabPage, dataRow, "NoLoadLoss");
				this.LoadTxtByColumn(tabPage, dataRow, "ShortCircuitLoss");
				this.LoadTxtByColumn(tabPage, dataRow, "Consumption");
				this.LoadTxtByColumn(tabPage, dataRow, "RatedVoltage");
				this.LoadTxtByColumn(tabPage, dataRow, "MiddleVoltage");
				this.LoadTxtByColumn(tabPage, dataRow, "Period");
				this.LoadTxtByColumn(tabPage, dataRow, "CoeffPowerReactive");
				this.LoadTxtByColumn(tabPage, dataRow, "SquareCoeffFromGraph");
				this.LoadTxtByColumn(tabPage, dataRow, "CoeffDifference");
				this.LoadTxtByColumn(tabPage, dataRow, "LossElectrHH");
				if (Convert.ToInt32(dataRow["numTrans"]) == 1)
				{
					this.txtActiveResistance.Text = dataRow["ActiveResistance"].ToString();
					this.txtLoadAverage.Text = dataRow["LoadAverage"].ToString();
					this.txtLoadPowerLoss.Text = this.RoundDecimal(Convert.ToDecimal(dataRow["LoadPowerLoss"]), 5).ToString();
					this.txtLoadLosses.Text = this.RoundDecimal(Convert.ToDecimal(dataRow["LoadLosses"]), 5).ToString();
					this.txtCoefLoss.Text = this.RoundDecimal(Convert.ToDecimal(dataRow["CoeffLosses"]), 3).ToString();
				}
				num++;
			}
		}

		private void LoadTxtByColumn(TabPage p, DataRow row, string column)
		{
			TextBox textBox = this.SearchTextBoxByTag(p, column);
			if (textBox != null)
			{
				textBox.Text = row[column].ToString();
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
					this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnBalance"] = this.IdAbnBalance;
				}
				this.txtAbn.Tag = (this.IdAbn = formTechConnectionAddAbn.IdAbn);
				this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbn"] = this.IdAbn;
				this.cmbAbnObj.Tag = (this.IdAbnObj = formTechConnectionAddAbn.IdAbnObj);
				this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnObj"] = this.IdAbnObj;
				this.InitCmbAbnObj();
				this.InitTPName();
				this.SetVisibleControls();
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
			formTechConnectionAddAbn.ShowForm +=new ShowFormEventHandler( this.f_ShowForm);
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
				this.dsCalcN.tJ_CalcLoss.Rows[0]["idAbnBalance"] = this.IdAbnBalance;
				this.SetVisibleControls();
			}
		}

		private void buttonMakeupTrans_Click(object sender, EventArgs e)
		{
			FormSelectTrans form = new FormSelectTrans();
			form.Tag = ((Button)sender).Parent;
			form.ShowForm +=new ShowFormEventHandler( this.f_ShowForm);
			form.SqlSettings = this.SqlSettings;
			form.MdiParent = base.MdiParent;
			form.FormClosed +=new FormClosedEventHandler( this.fSelectTrans_FormClosed);
			form.Show();
		}

		private void fSelectTrans_FormClosed(object sender, FormClosedEventArgs e)
		{
			TabPage tabPage = (TabPage)((Form)sender).Tag;
			if (((Form)sender).DialogResult == DialogResult.OK)
			{
				tabPage.Tag = ((FormSelectTrans)sender).Id;
				TextBox textBox = this.SearchTextBoxByTag(tabPage, "MakeupTrans");
				if (textBox != null)
				{
					textBox.Text = ((FormSelectTrans)sender).MakeupTrans;
				}
				textBox = this.SearchTextBoxByTag(tabPage, "RatedPower");
				if (textBox != null)
				{
					if (((FormSelectTrans)sender).RatedPower == null)
					{
						textBox.Text = null;
					}
					else
					{
						textBox.Text = ((FormSelectTrans)sender).RatedPower.ToString();
					}
				}
				textBox = this.SearchTextBoxByTag(tabPage, "NoLoadLoss");
				if (textBox != null)
				{
					if (((FormSelectTrans)sender).NoLoadLoss == null)
					{
						textBox.Text = null;
					}
					else
					{
						textBox.Text = this.RoundDecimal(Convert.ToDecimal(((FormSelectTrans)sender).NoLoadLoss), 2).ToString();
					}
				}
				textBox = this.SearchTextBoxByTag(tabPage, "ShortCircuitLoss");
				if (textBox != null)
				{
					if (((FormSelectTrans)sender).ShortCircuitLoss == null)
					{
						textBox.Text = null;
					}
					else
					{
						textBox.Text = this.RoundDecimal(Convert.ToDecimal(((FormSelectTrans)sender).ShortCircuitLoss), 2).ToString();
					}
				}
				textBox = this.SearchTextBoxByTag(tabPage, "RatedVoltage");
				if (textBox != null)
				{
					if (((FormSelectTrans)sender).GetHightVoltage() == null)
					{
						textBox.Text = null;
					}
					else
					{
						textBox.Text = this.RoundDecimal(Convert.ToDecimal(((FormSelectTrans)sender).GetHightVoltage()), 2).ToString();
					}
				}
				textBox = this.SearchTextBoxByTag(tabPage, "MiddleVoltage");
				if (textBox != null)
				{
					if (((FormSelectTrans)sender).GetHightVoltage() == null)
					{
						textBox.Text = null;
						return;
					}
					textBox.Text = this.RoundDecimal(Convert.ToDecimal(((FormSelectTrans)sender).GetHightVoltage()), 2).ToString();
				}
			}
		}
        
        private void CalcLossElectrHH(TabPage tabPage)
		{
			if (tabPage != null)
			{ 
				TextBox textBox = this.SearchTextBoxByTag(tabPage, "NoLoadLoss");
				TextBox textBox2 = this.SearchTextBoxByTag(tabPage, "Period");
				TextBox textBox3 = this.SearchTextBoxByTag(tabPage, "MiddleVoltage");
				TextBox textBox4 = this.SearchTextBoxByTag(tabPage, "RatedVoltage");
				TextBox textBox5 = this.SearchTextBoxByTag(tabPage, "LossElectrHH");
				if (textBox != null && textBox2 != null && textBox3 != null && textBox4 != null && textBox5 != null)
				{
					if (!string.IsNullOrEmpty(textBox.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text))
					{
						textBox5.Text = this.RoundDecimal(Convert.ToDecimal(Convert.ToDouble(textBox.Text) * Convert.ToDouble(textBox2.Text) * Math.Pow(Convert.ToDouble(textBox3.Text) / Convert.ToDouble(textBox4.Text), 2.0)), 0).ToString();
						return;
					}
					textBox5.Text = "";
				}
			}
		}

		private void CalcActiveResistance()
		{
			if (!string.IsNullOrEmpty(this.ShortCircuitLoss.Text) && !string.IsNullOrEmpty(this.txtRatedVoltage.Text) && !string.IsNullOrEmpty(this.txtRatedPowerTrans1.Text))
			{
				this.txtActiveResistance.Text = this.RoundDecimal(0.001m * Convert.ToDecimal(this.ShortCircuitLoss.Text) * Convert.ToDecimal(Math.Pow(Convert.ToDouble(this.txtRatedVoltage.Text), 2.0) / Math.Pow(Convert.ToDouble(this.txtRatedPowerTrans1.Text), 2.0)), 5).ToString();
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
			if (!string.IsNullOrEmpty(this.txtLoadAverage.Text) && !string.IsNullOrEmpty(this.txtCoeffPowerReactive.Text) && !string.IsNullOrEmpty(this.ShortCircuitLoss.Text) && !string.IsNullOrEmpty(this.txtLossElectrHH.Text) && !string.IsNullOrEmpty(this.txtActiveResistance.Text))
			{
				this.txtLoadPowerLoss.Text = this.RoundDecimal(1000m * Convert.ToDecimal(Math.Pow(Convert.ToDouble(this.txtLoadAverage.Text), 2.0)) * Convert.ToDecimal(this.txtActiveResistance.Text) * (1m + Convert.ToDecimal(this.txtCoeffPowerReactive.Text) * Convert.ToDecimal(this.txtCoeffPowerReactive.Text)) / Convert.ToDecimal(Math.Pow(Convert.ToDouble(this.txtMiddleVoltage.Text), 2.0)), 5).ToString();
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

		private void CalcCoefLoss()
		{
			if (!string.IsNullOrEmpty(this.txtLoadLosses.Text) && !string.IsNullOrEmpty(this.txtConsumtion.Text))
			{
				this.txtCoefLoss.Text = this.RoundDecimal(100m * Convert.ToDecimal(this.txtLoadLosses.Text) / Convert.ToDecimal(this.txtConsumtion.Text), 3).ToString();
				return;
			}
			this.txtCoefLoss.Text = null;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (this.SaveCalcLossTrans())
			{
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
		}

		private bool SaveCalcLossTrans()
		{
			if (this.CheckSave())
			{
				if (this.Id == -1)
				{
					this.dsCalcN.tJ_CalcLoss.Rows[0].EndEdit();
					this.Id = base.InsertSqlDataOneRow(this.dsCalcN, this.dsCalcN.tJ_CalcLoss);
					if (this.Id >= 0 && this.SaveFiles() && this.UpdateCalcLossTrans())
					{
						return true;
					}
				}
				else
				{
					this.dsCalcN.tJ_CalcLoss.Rows[0].EndEdit();
					if (base.UpdateSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLoss) && this.SaveFiles() && this.UpdateCalcLossTrans())
					{
						return true;
					}
				}
			}
			return false;
		}

		private bool UpdateCalcLossTrans()
		{
			int num = 0;
			foreach (TabPage tabPage in this.tabControlTrans.TabPages)
			{
				//TabPage tabPage = (TabPage)obj;
				while (this.dsCalcN.tJ_CalcLossTrans.Rows.Count <= num)
				{
					DataRow dataRow = this.dsCalcN.tJ_CalcLossTrans.NewRow();
					dataRow["idCalc"] = this.id_;
					dataRow["makeupTrans"] = -1;
					this.dsCalcN.tJ_CalcLossTrans.Rows.Add(dataRow);
				}
				if (this.dsCalcN.tJ_CalcLossTrans.Rows.Count > num)
				{
					this.dsCalcN.tJ_CalcLossTrans.Rows[num]["idCalc"] = this.id_;
					this.dsCalcN.tJ_CalcLossTrans.Rows[num]["numTrans"] = num + 1;
					if (tabPage.Tag == null)
					{
						this.dsCalcN.tJ_CalcLossTrans.Rows[num]["MakeupTrans"] = -1;
					}
					else
					{
						this.dsCalcN.tJ_CalcLossTrans.Rows[num]["MakeupTrans"] = tabPage.Tag;
					}
					this.SetCellDecimalValue(tabPage, this.dsCalcN.tJ_CalcLossTrans.Rows[num], "RatedPower");
					this.SetCellDecimalValue(tabPage, this.dsCalcN.tJ_CalcLossTrans.Rows[num], "NoLoadLoss");
					this.SetCellDecimalValue(tabPage, this.dsCalcN.tJ_CalcLossTrans.Rows[num], "ShortCircuitLoss");
					this.SetCellDecimalValue(tabPage, this.dsCalcN.tJ_CalcLossTrans.Rows[num], "Consumption");
					this.SetCellDecimalValue(tabPage, this.dsCalcN.tJ_CalcLossTrans.Rows[num], "RatedVoltage");
					this.SetCellDecimalValue(tabPage, this.dsCalcN.tJ_CalcLossTrans.Rows[num], "MiddleVoltage");
					this.SetCellDecimalValue(tabPage, this.dsCalcN.tJ_CalcLossTrans.Rows[num], "Period");
					this.SetCellDecimalValue(tabPage, this.dsCalcN.tJ_CalcLossTrans.Rows[num], "CoeffPowerReactive");
					this.SetCellDecimalValue(tabPage, this.dsCalcN.tJ_CalcLossTrans.Rows[num], "SquareCoeffFromGraph");
					this.SetCellDecimalValue(tabPage, this.dsCalcN.tJ_CalcLossTrans.Rows[num], "CoeffDifference");
					this.SetCellDecimalValue(tabPage, this.dsCalcN.tJ_CalcLossTrans.Rows[num], "LossElectrHH");
					if (num == 0)
					{
						if (string.IsNullOrEmpty(this.txtActiveResistance.Text))
						{
							this.dsCalcN.tJ_CalcLossTrans.Rows[num]["ActiveResistance"] = DBNull.Value;
						}
						else
						{
							this.dsCalcN.tJ_CalcLossTrans.Rows[num]["ActiveResistance"] = Convert.ToDecimal(this.txtActiveResistance.Text);
						}
						if (string.IsNullOrEmpty(this.txtLoadAverage.Text))
						{
							this.dsCalcN.tJ_CalcLossTrans.Rows[num]["LoadAverage"] = DBNull.Value;
						}
						else
						{
							this.dsCalcN.tJ_CalcLossTrans.Rows[num]["LoadAverage"] = Convert.ToDecimal(this.txtLoadAverage.Text);
						}
						if (string.IsNullOrEmpty(this.txtLoadPowerLoss.Text))
						{
							this.dsCalcN.tJ_CalcLossTrans.Rows[num]["LoadPowerLoss"] = DBNull.Value;
						}
						else
						{
							this.dsCalcN.tJ_CalcLossTrans.Rows[num]["LoadPowerLoss"] = Convert.ToDecimal(this.txtLoadPowerLoss.Text);
						}
						if (string.IsNullOrEmpty(this.txtLoadLosses.Text))
						{
							this.dsCalcN.tJ_CalcLossTrans.Rows[num]["LoadLosses"] = DBNull.Value;
						}
						else
						{
							this.dsCalcN.tJ_CalcLossTrans.Rows[num]["LoadLosses"] = Convert.ToDecimal(this.txtLoadLosses.Text);
						}
						if (string.IsNullOrEmpty(this.txtCoefLoss.Text))
						{
							this.dsCalcN.tJ_CalcLossTrans.Rows[num]["CoeffLosses"] = DBNull.Value;
						}
						else
						{
							this.dsCalcN.tJ_CalcLossTrans.Rows[num]["CoeffLosses"] = Convert.ToDecimal(this.txtCoefLoss.Text);
						}
					}
					this.dsCalcN.tJ_CalcLossTrans.Rows[num].EndEdit();
				}
				num++;
			}
			for (int i = this.tabControlTrans.TabPages.Count; i < this.dsCalcN.tJ_CalcLossTrans.Rows.Count; i++)
			{
				this.dsCalcN.tJ_CalcLossTrans.Rows[i].Delete();
			}
			if (base.InsertSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossTrans) && base.UpdateSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossTrans) && base.DeleteSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossTrans))
			{
				base.SelectSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossTrans, true, " where idCalc = " + this.id_.ToString() + " order by numTrans");
				return this.UpdateCalcLossTransHH();
			}
			return false;
		}

		private bool UpdateCalcLossTransHH()
		{
            CalcLossN.DataSet.DataSetCalc.tJ_CalcLossTransDataTable tJ_CalcLossTransDataTable = new CalcLossN.DataSet.DataSetCalc.tJ_CalcLossTransDataTable();
			base.SelectSqlData(tJ_CalcLossTransDataTable, true, "where idCalc = " + this.id_.ToString() + " order by numTrans", null, false, 0);
			if (tJ_CalcLossTransDataTable.Rows.Count != this.tabControlTrans.TabPages.Count)
			{
				MessageBox.Show("Ошибка сохранения расчета потерь холостого хода");
				return false;
			}
			if (this.dgvMonthVisible) 

            {
				int num = 0;
                //using (IEnumerator enumerator = tJ_CalcLossTransDataTable.Rows.GetEnumerator())
                //{
                //	while (enumerator.MoveNext())
                foreach (DataRow dataRow in tJ_CalcLossTransDataTable.Rows)
                        {
				//		object obj = enumerator.Current;
				//		DataRow dataRow = (DataRow)obj;
						while (this.dsCalcN.tJ_CalcLossTransHH.Rows.Count <= num)
						{
							DataRow dataRow2 = this.dsCalcN.tJ_CalcLossTransHH.NewRow();
							dataRow2["idCalc"] = this.id_;
							this.dsCalcN.tJ_CalcLossTransHH.Rows.Add(dataRow2);
						}
						if (this.dsCalcN.tJ_CalcLossTransHH.Rows.Count > num)
						{
							this.dsCalcN.tJ_CalcLossTransHH.Rows[num]["idTrans"] = dataRow["id"];
							DataGridView dataGridView = this.SearchDataGridInTabPage(this.tabControlTrans.TabPages[num]);
							if (dataGridView != null)
							{
								short num2 = 1;
								foreach (object obj2 in dataGridView.Columns)
								{
									DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj2;
									if (dataGridView[dataGridViewColumn.Index, 0].Value != null)
									{
										this.dsCalcN.tJ_CalcLossTransHH.Rows[num]["month" + num2.ToString("00")] = Convert.ToInt32(dataGridView[dataGridViewColumn.Index, 0].Value);
									}
									else
									{
										this.dsCalcN.tJ_CalcLossTransHH.Rows[num]["month" + num2.ToString("00")] = DBNull.Value;
									}
									num2 += 1;
								}
							}
						}
						num++;
					}

                while (this.dsCalcN.tJ_CalcLossTransHH.Rows.Count <= num)
                {
                    DataRow dataRow3 = this.dsCalcN.tJ_CalcLossTransHH.NewRow();
                    dataRow3["idCalc"] = this.id_;
                    this.dsCalcN.tJ_CalcLossTransHH.Rows.Add(dataRow3);
                }

                if (this.dsCalcN.tJ_CalcLossTransHH.Rows.Count > num)
				{
					short num3 = 1;
					foreach (DataGridViewColumn dataGridViewColumn2 in this.dgvMonthSum.Columns)
					{
						if (this.dgvMonthSum[dataGridViewColumn2.Index, 0].Value != null)
						{
							this.dsCalcN.tJ_CalcLossTransHH.Rows[num]["month" + num3.ToString("00")] = Convert.ToInt32(this.dgvMonthSum[dataGridViewColumn2.Index, 0].Value);
						}
						else
						{
							this.dsCalcN.tJ_CalcLossTransHH.Rows[num]["month" + num3.ToString("00")] = DBNull.Value;
						}
						num3 += 1;
					}
				}
				for (int i = tJ_CalcLossTransDataTable.Rows.Count + 1; i < this.dsCalcN.tJ_CalcLossTransHH.Rows.Count; i++)
				{
					this.dsCalcN.tJ_CalcLossTransHH.Rows[i].Delete();
				}
			}
			else
			{
				for (int j = 0; j < this.dsCalcN.tJ_CalcLossTransHH.Rows.Count; j++)
				{
					this.dsCalcN.tJ_CalcLossTransHH.Rows[j].Delete();
				}
			}
			if (base.InsertSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossTransHH) && base.UpdateSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossTransHH) && base.DeleteSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossTransHH))
			{
				base.SelectSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossTransHH, true, " where idCalc = " + this.id_.ToString() + " order by id");
				return true;
			}
			return false;
		}

		private void SetCellDecimalValue(TabPage tabPage, DataRow row, string column)
		{
			TextBox textBox = this.SearchTextBoxByTag(tabPage, column);
			if (textBox != null)
			{
				if (string.IsNullOrEmpty(textBox.Text))
				{
					row[column] = DBNull.Value;
					return;
				}
				row[column] = Convert.ToDecimal(textBox.Text);
			}
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
			if (this.SaveCalcLossTrans())
			{
				new FormReportCalcLossTrans(this.id_)
				{
					MdiParent = base.MdiParent,
					SqlSettings = this.SqlSettings
				}.Show();
			}
		}

		private bool SaveFiles()
		{
			bool result;
			try
			{
				foreach (DataRow dataRow in this.dsCalcN.tJ_CalcLossFile)
				{
					if (dataRow.RowState != DataRowState.Deleted && dataRow.RowState != DataRowState.Detached)
					{
						dataRow["idCalc"] = this.id_;
						dataRow.EndEdit();
					}
				}
				base.InsertSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossFile);
				base.UpdateSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossFile);
				base.DeleteSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLossFile);
				result = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
				result = false;
			}
			return result;
		}

		private void LoadCalcLossFile()
		{
			base.SelectSqlData(this.dsCalcN.tJ_CalcLossFile, true, " where idCalc = " + this.id_.ToString(), null, false, 0);
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
						DataRow dataRow = this.dsCalcN.tJ_CalcLossFile.NewRow();
						dataRow["idCalc"] = this.id_;
						dataRow["File"] = File.ReadAllBytes(openFileDialog.FileNames[i]);
						dataRow["FileName"] = Path.GetFileName(openFileDialog.FileNames[i]);
						dataRow["DateIn"] = DateTime.Now;
						this.dsCalcN.tJ_CalcLossFile.Rows.Add(dataRow);
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
			DataRow[] array = this.dsCalcN.tJ_CalcLossFile.Select("id = " + num.ToString());
			if (array.Length != 0)
			{
				byte[] array2 = (byte[])array[0]["File"];
				string text = Path.GetTempFileName();
				text = Path.ChangeExtension(text, Path.GetExtension(array[0]["FileName"].ToString()));
				FileStream fileStream = File.Create(text);
				fileStream.Write(array2, 0, array2.Length);
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
				DataRow[] array = this.dsCalcN.tJ_CalcLossFile.Select("id = " + num.ToString());
				if (array.Length != 0)
				{
					string text = this.dgvFiles.CurrentRow.Cells[this.fileNameDataGridViewTextBoxColumn.Name].Value.ToString();
					string extension = Path.GetExtension(text);
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.Filter = "(*" + extension + ")|*" + extension;
					saveFileDialog.FileName = text;
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						byte[] buffer = (byte[])array[0]["file"];
						FileStream fileStream = File.Create(saveFileDialog.FileName);
						fileStream.Write(buffer, 0, buffer.Length);
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

		private void dgvFiles_CellContent_Click(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == this.dgvFiles.Columns[this.fileNameDataGridViewTextBoxColumn.Name].Index)
			{
				this.toolBtnFileView_Click(sender, e);
			}
		}

		private void SetVisibleControls()
		{
			if (this.IdAbn != this.IdAbnBalance)
			{
				this.txtLossElectrHH.Visible = false;
                this.txtParamLossElectrHH.Visible = false;
                this.lalbelLossElectrHH.Visible = false;
				this.dgvMonth.Visible = false;
                this.labelDgvMonth.Visible = false;
				this.dgvMonthVisible = false;
				this.tabControlTrans.Height = 244;
				this.dgvMonthSum.Visible = false;
                this.labeldgvMonthSum.Visible = false;
				this.panelBottom.Top = 387;
				this.panelBottom.Height = this.tabControl.Bottom - this.panelBottom.Top - 20;
				this.toolBtnAddTrans1.Enabled = false;
				while (this.tabControlTrans.TabPages.Count > 1)
				{
					this.tabControlTrans.TabPages.RemoveAt(1);
				}
				return;
			}
			this.txtLossElectrHH.Visible = true;
            this.txtParamLossElectrHH.Visible = true;
            this.lalbelLossElectrHH.Visible = true;
			this.dgvMonth.Visible = true;
            this.labelDgvMonth.Visible = true;
			this.dgvMonthVisible = true;
			this.tabControlTrans.Height = 339;
			this.toolBtnAddTrans1.Enabled = true;
			if (this.tabControlTrans.TabPages.Count > 1)
			{
				this.dgvMonthSum.Visible = true;
                this.labeldgvMonthSum.Visible = true;
				this.panelBottom.Top = 557;
				this.panelBottom.Height = this.tabControl.Bottom - this.panelBottom.Top - 20;
				return;
			}
			this.panelBottom.Top = 477;
			this.panelBottom.Height = this.tabControl.Bottom - this.panelBottom.Top - 20;
			this.dgvMonthSum.Visible = false;
            this.labeldgvMonthSum.Visible = false;
		}

		private void txtLossElectrHH_TextChanged(object sender, EventArgs e)
		{
			TextBox textBox = (TextBox)sender;
			DataGridView dgv = this.dgvMonth;
			if (textBox.Parent != null && textBox.Parent is TabPage)
			{
				dgv = this.SearchDataGridInTabPage((TabPage)textBox.Parent);
			}
			if (string.IsNullOrEmpty(textBox.Text))
			{
                //using (IEnumerator enumerator = dataGridView.Columns.GetEnumerator())
                //{
                //    while (enumerator.MoveNext())
                //    {
                //        object obj = enumerator.Current;
                //        DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
                //        dataGridView[dataGridViewColumn.Index, 0].Value = null;
                //    }
                //    return;
                //}
                foreach (DataGridViewColumn dataGridViewColumn in dgv.Columns)
                {
                    dgv[dataGridViewColumn.Index, 0].Value = null;
                }
                return;
            }
			float num = Convert.ToSingle(textBox.Text);
			int CountDayYear = DateTime.IsLeapYear(this.dateTimePickerDateCalc.Value.Year) ? 366 : 365;
			int num3 = 0;
			foreach (DataGridViewColumn dataGridViewColumn2 in dgv.Columns)
			{
				//DataGridViewColumn dataGridViewColumn2 = (DataGridViewColumn)obj2;
				if (dataGridViewColumn2.Index != 1)
				{
					dgv[dataGridViewColumn2.Index, 0].Value = Math.Round((double)((float)DateTime.DaysInMonth(this.dateTimePickerDateCalc.Value.Year, dataGridViewColumn2.Index + 1) * num / (float)CountDayYear), 0);
					num3 += Convert.ToInt32(Math.Round((double)((float)DateTime.DaysInMonth(this.dateTimePickerDateCalc.Value.Year, dataGridViewColumn2.Index + 1) * num / (float)CountDayYear), 0));
				}
			}
			dgv[1, 0].Value = Convert.ToInt32(Math.Round((double)(num - (float)num3), 0));
		}

		private TabPage AddTabPage()
		{
			TabPage tabPage = new TabPage("Т" + (this.tabControlTrans.TabCount + 1).ToString());
			tabPage.Name = "tabPageTrans" + (this.tabControlTrans.TabCount + 1).ToString();
			tabPage.Size = this.tabPageTrans1.Size;
			foreach (Control control in this.tabPageTrans1.Controls)
			{
				Type type = control.GetType();

                Control control2 = (Control)Activator.CreateInstance(type);
				control2.Dock = control.Dock;
				control2.Location = control.Location;
				control2.Size = control.Size;
				control2.Anchor = control.Anchor;
				control2.BackColor = control.BackColor;
				control2.TabStop = control.TabStop;
				if (type == typeof(TextBox))
				{
					((TextBox)control2).ReadOnly = ((TextBox)control).ReadOnly;
					((TextBox)control2).TextAlign = ((TextBox)control).TextAlign;
					if (!((TextBox)control2).ReadOnly)
					{
						((TextBox)control2).KeyPress +=new KeyPressEventHandler( this.txtBox_KeyPress);
						((TextBox)control2).TextChanged +=new EventHandler( this.Control_TextChanged);
					}
					if (((TextBox)control).Tag != null && ((TextBox)control).Tag.ToString() == "LossElectrHH")
					{
						((TextBox)control2).TextChanged +=new EventHandler (this.txtLossElectrHH_TextChanged);
					}
					control2.Tag = control.Tag;
				}
				if (type == typeof(ToolStrip))
				{
					((ToolStrip)control2).LayoutStyle = ((ToolStrip)control).LayoutStyle;
					((ToolStrip)control2).GripStyle = ((ToolStrip)control).GripStyle;
					foreach (ToolStripItem toolStripItem in ((ToolStrip)control).Items)
					{
						ToolStripItem toolStripItem2 = (ToolStripItem)Activator.CreateInstance(toolStripItem.GetType());
						toolStripItem2.Text = toolStripItem.Text;
						toolStripItem2.Image = toolStripItem.Image;
						toolStripItem2.DisplayStyle = toolStripItem.DisplayStyle;
						toolStripItem2.Visible = true;
						toolStripItem2.Tag = tabPage;
						FieldInfo field = typeof(Component).GetField("events", BindingFlags.Instance | BindingFlags.NonPublic);
						object value = field.GetValue(toolStripItem);
						field.SetValue(toolStripItem2, value);
						((ToolStrip)control2).Items.Add(toolStripItem2);
					}
				}
				if (type == typeof(Button))
				{
					FieldInfo field2 = typeof(Component).GetField("events", BindingFlags.Instance | BindingFlags.NonPublic);
					object value2 = field2.GetValue(control);
					field2.SetValue(control2, value2);
				}
				if (type == typeof(DataGridView))
				{
					((DataGridView)control2).AllowUserToAddRows = ((DataGridView)control).AllowUserToAddRows;
					((DataGridView)control2).AllowUserToDeleteRows = ((DataGridView)control).AllowUserToDeleteRows;
					((DataGridView)control2).AllowUserToOrderColumns = ((DataGridView)control).AllowUserToOrderColumns;
					((DataGridView)control2).AllowUserToResizeColumns = ((DataGridView)control).AllowUserToResizeColumns;
					((DataGridView)control2).AllowUserToResizeRows = ((DataGridView)control).AllowUserToResizeRows;
					((DataGridView)control2).RowHeadersVisible = ((DataGridView)control).RowHeadersVisible;
					FieldInfo field3 = typeof(Component).GetField("events", BindingFlags.Instance | BindingFlags.NonPublic);
					object value3 = field3.GetValue(control);
					field3.SetValue(control2, value3);
					foreach (object obj3 in ((DataGridView)control).Columns)
					{
						DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj3;
						DataGridViewColumn dataGridViewColumn2 = new DataGridViewColumn();
						dataGridViewColumn2.CellTemplate = dataGridViewColumn.CellTemplate;
						dataGridViewColumn2.HeaderText = dataGridViewColumn.HeaderText;
						dataGridViewColumn2.AutoSizeMode = dataGridViewColumn.AutoSizeMode;
						((DataGridView)control2).Columns.Add(dataGridViewColumn2);
					}
					((DataGridView)control2).Rows.Add();
				}
				tabPage.Controls.Add(control2);
				control2.Text = control.Text;
			}
			this.tabControlTrans.TabPages.Add(tabPage);
			this.RecalDgvMonthSum();
			this.SetVisibleControls();
			return tabPage;
		}

		private void toolBtnAddTrans1_Click(object sender, EventArgs e)
		{
			this.AddTabPage();
		}

		private void toolBtnDelTrans1_Click(object sender, EventArgs e)
		{
			TabPage value = (TabPage)((ToolStripItem)sender).Tag;
			this.tabControlTrans.TabPages.Remove(value);
			int num = 0;
			foreach (Control control in this.tabControlTrans.TabPages)
			{
				string str = "Т";
				int num2 = num + 1;
				num = num2;
				control.Text = str + num2.ToString();
			}
			this.RecalDgvMonthSum();
			this.SetVisibleControls();
		}

		private TextBox SearchTextBoxByTag(TabPage tabPage, object tag)
		{
			if (tag == null)
			{
				return null;
			}
			foreach (Control control in tabPage.Controls)
			{
				if (control is TextBox && ((TextBox)control).Tag != null && ((TextBox)control).Tag.ToString() == tag.ToString())
				{
					return (TextBox)control;
				}
			}
			return null;
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

		private void dgvMonth_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				int? num = null;
				foreach (TabPage tabPage_ in this.tabControlTrans.TabPages)
				{
					DataGridView dataGridView = this.SearchDataGridInTabPage(tabPage_);
					if (dataGridView[e.ColumnIndex, e.RowIndex].Value != null)
					{
						if (num != null)
						{
							num += Convert.ToInt32(dataGridView[e.ColumnIndex, e.RowIndex].Value);
						}
						else
						{
							num = new int?(Convert.ToInt32(dataGridView[e.ColumnIndex, e.RowIndex].Value));
						}
					}
				}
				this.dgvMonthSum[e.ColumnIndex, e.RowIndex].Value = num;
			}
		}

		private void RecalDgvMonthSum()
		{
			int?[] array = new int?[12];
			foreach (TabPage tabPage_ in this.tabControlTrans.TabPages)
            {
                DataGridView dataGridView = this.SearchDataGridInTabPage(tabPage_);
				foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
				{
					if (dataGridView[dataGridViewColumn.Index, 0].Value != null)
					{
						if (array[dataGridViewColumn.Index] != null)
						{
							array[dataGridViewColumn.Index] += Convert.ToInt32(dataGridView[dataGridViewColumn.Index, 0].Value);
						}
						else
						{
							array[dataGridViewColumn.Index] = new int?(Convert.ToInt32(dataGridView[dataGridViewColumn.Index, 0].Value));
						}
					}
				}
			}
			for (int i = 0; i < array.Length; i++)
			{
				this.dgvMonthSum[i, 0].Value = array[i];
			}
		}

		private DataGridView SearchDataGridInTabPage(TabPage tabPage)
		{
			DataGridView dgv = this.dgvMonth;
			foreach (Control control in tabPage.Controls)
			{
				if (control is DataGridView)
				{
					dgv = (DataGridView)control;
					break;
				}
			}
			return dgv;
		}

	
	}

