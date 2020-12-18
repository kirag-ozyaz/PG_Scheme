using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ControlsLbr;
using FormLbr;
/// <summary>
/// Редактирование/добавление погоды
/// </summary>
internal partial class FormTemperatureAddEdit : FormBase
{
    private bool isChangedData;
    private DateTime? DateWeather;
    private int? Id;

	internal int? GetIdTemperature()
	{
		return this.Id;
	}
	internal void SetIdWeather(int? id)
	{
		this.Id = id;
	}

	internal FormTemperatureAddEdit(int? id = null)
	{
		this.InitializeComponent();
		this.SetIdWeather(id);
		this.Text = ((this.GetIdTemperature() == null) ? "Добавить погоду" : "Редактирование погоды");
	}

	internal FormTemperatureAddEdit(DateTime dateWeather)
	{
		this.InitializeComponent();
		this.DateWeather = new DateTime?(dateWeather.Date);
		this.dateTimePickerWeather.Enabled = false;
		this.Text = ((this.GetIdTemperature() == null) ? "Добавить погоду" : "Редактирование погоды");
	}

	private void FormTemperatureAddEDit_Load(object sender, EventArgs e)
	{
		this.FillColumnWindDirect();
		if (this.GetIdTemperature() == null)
		{
			DataRow dataRow = this.dsDamage.tJ_Temperature.NewRow();
			if (this.DateWeather != null)
			{
				dataRow["DateTemp"] = this.DateWeather;
			}
			else
			{
				dataRow["DateTemp"] = DateTime.Now.Date;
			}
			this.dsDamage.tJ_Temperature.Rows.Add(dataRow);
		}
		else
		{
			base.SelectSqlData(this.dsDamage.tJ_Temperature, true, "where id = " + this.GetIdTemperature().ToString(), null, false, 0);
		}
		this.isChangedData = false;
	}

	private void FillColumnWindDirect()
	{
		DataTable dataTable = new DataTable("tR_Classifier");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("name", typeof(string));
		base.SelectSqlData(dataTable, true, "where ParentKey = ';ReportDaily;WindDirect;' and isGroup = 0 and deleted = 0 order by name", null, false, 0);
		this.cmbWindDirect.DisplayMember = "name";
		this.cmbWindDirect.ValueMember = "id";
		this.cmbWindDirect.DataSource = dataTable;
		this.cmbWindDirect.SelectedIndex = -1;
	}

	private void dateTimePickerWeather_ValueChanged(object sender, EventArgs e)
	{
		this.isChangedData = true;
	}

	private void nullableNumericUpDown5_ValueChanged(object sender, EventArgs e)
	{
		this.isChangedData = true;
	}

	private void cmbWindDirect_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.cmbWindDirect.SelectedIndex >= 0)
		{
			this.labelWind.ForeColor = Color.Black;
		}
		this.isChangedData = true;
	}

	private void richTextBox1_TextChanged(object sender, EventArgs e)
	{
		this.isChangedData = true;
	}

	private bool CheckRequiredField()
	{
		bool result = true;
		if (this.txtNightOt.Value == null)
		{
			this.labelNightOt.ForeColor = Color.Red;
			result = false;
		}
		if (this.txtNightDo.Value == null)
		{
			this.labelNightDo.ForeColor = Color.Red;
			result = false;
		}
		if (this.txtDayOt.Value == null)
		{
			this.labelDayOt.ForeColor = Color.Red;
			result = false;
		}
		if (this.txtDayDo.Value == null)
		{
			this.labelDayDo.ForeColor = Color.Red;
			result = false;
		}
		if (this.cmbWindDirect.SelectedIndex == -1)
		{
			this.labelWind.ForeColor = Color.Red;
			result = false;
		}
		return result;
	}

	private void FormTemperatureAddEDit_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (base.DialogResult == DialogResult.OK || (this.isChangedData && MessageBox.Show("Были внесены изменения. Сохранить?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
		{
			if (!this.CheckRequiredField())
			{
				MessageBox.Show("Не заполнены обязательные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				base.DialogResult = DialogResult.None;
				e.Cancel = true;
				return;
			}
			this.dsDamage.tJ_Temperature.Rows[0].EndEdit();
			if (this.GetIdTemperature() == null)
			{
				this.SetIdWeather(new int?(base.InsertSqlDataOneRow(this.dsDamage.tJ_Temperature.Rows[0])));
				if (this.GetIdTemperature() == null || this.GetIdTemperature() < 0)
				{
					this.SetIdWeather(null);
					base.DialogResult = DialogResult.None;
					e.Cancel = true;
					return;
				}
			}
			else if (!base.UpdateSqlData(this.dsDamage.tJ_Temperature))
			{
				base.DialogResult = DialogResult.None;
				e.Cancel = true;
				return;
			}
		}
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void txtNightOt_ValueChanged(object sender, EventArgs e)
	{
		this.isChangedData = true;
		if (this.txtNightOt.Value != null)
		{
			this.labelNightOt.ForeColor = Color.Black;
		}
	}

	private void txtNightDo_ValueChanged(object sender, EventArgs e)
	{
		this.isChangedData = true;
		if (this.txtNightDo.Value != null)
		{
			this.labelNightDo.ForeColor = Color.Black;
		}
	}

	private void txtDayOt_ValueChanged(object sender, EventArgs e)
	{
		this.isChangedData = true;
		if (this.txtDayOt.Value != null)
		{
			this.labelDayOt.ForeColor = Color.Black;
		}
	}

	private void txtDayDo_ValueChanged(object sender, EventArgs e)
	{
		this.isChangedData = true;
		if (this.txtDayDo.Value != null)
		{
			this.labelDayDo.ForeColor = Color.Black;
		}
	}

	
}
