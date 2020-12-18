using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
//using Documents.Properties;
using FormLbr;
using FormLbr.Classes;
/// <summary>
/// Документ аварийные заявки и на ремонт оборудования (ПЛ)
/// Производственная лаборатория
/// </summary>
internal partial class FormJournalRequestForRepairAddEditPL : FormBase
{
    private const int ODS_DIVISION = 920; //ODS_DIVISION
    private const int PL_DIVISION = 921; //PL_DIVISION
    private const int NO_DIVISION = 1665;

    private int IdRequest = -1;
    private int IdDivision = -1;
    private eActionRequestRepair eAction  = eActionRequestRepair.Read;
    private DateTime dateTimeBeg = new DateTime(1900, 1, 1);
    private DateTime dateTimeEnd = new DateTime(9000, 1, 1);
    /// <summary>
    /// Тип заявки (ремонт или авария)
    /// </summary>    
    private bool typeRequestRepair;
    private DataRow DataRowCurrent;
    private DataTable tblRequestForRepairClient;
    private Dictionary<int, string> dictionaryIdSchmObj = new Dictionary<int, string>();
    private int IdSR = -1;

    public FormJournalRequestForRepairAddEditPL()
	{
		this.InitializeComponent();
	}

	public FormJournalRequestForRepairAddEditPL(int idRequest, int idDivision, eActionRequestRepair action, bool isCrash = false)
	{
		this.InitializeComponent();
		this.IdRequest = idRequest;
		this.IdDivision = idDivision;
		this.eAction = action;
		this.typeRequestRepair = isCrash;
	}

	public FormJournalRequestForRepairAddEditPL(DataRow rowCurrent)
	{
		this.InitializeComponent();
		this.IdRequest = -1;
		this.IdDivision = Convert.ToInt32(rowCurrent["idDivision"]);
		this.eAction = eActionRequestRepair.Add;
		this.DataRowCurrent = rowCurrent;
	}

	private void FormJournalRequestForRepairAddEdit_Load(object sender, EventArgs e)
	{
		this.dtpDateCreate.Value = DateTime.Now;
		this.dateTimePickerBeg.Value = DateTime.Now.Date.AddHours(8.0);
		this.dateTimePickerEnd.Value = DateTime.Now.Date.AddHours(17.0);
        this.FillComboBoxs(IdDivision);
		this.FillComboBoxStatus();
		this.SetVisibleControl();
		base.LoadFormConfig(null);
		switch (this.eAction)
		{
		case eActionRequestRepair.Add:
			if (this.DataRowCurrent != null)
			{
				DataRow dataRow = this.dataSetDamage.tJ_RequestForRepair.NewRow();
				dataRow["num"] = 0;
				dataRow["dateCreate"] = DateTime.Now;
				dataRow["idWorker"] = this.DataRowCurrent["idWorker"];
				dataRow["reguestFiled"] = this.DataRowCurrent["reguestFiled"];
				dataRow["idSR"] = this.DataRowCurrent["idSR"];
				dataRow["schmObj"] = this.DataRowCurrent["schmObj"];
				dataRow["Purpose"] = this.DataRowCurrent["Purpose"];
				dataRow["IsPlanned"] = this.DataRowCurrent["IsPlanned"];
				dataRow["agreed"] = this.DataRowCurrent["agreed"];
				dataRow["iddivision"] = this.DataRowCurrent["iddivision"];
				dataRow["Crash"] = this.DataRowCurrent["Crash"];
				DataTable dataTable = this.GetTableUser();
				base.SelectSqlData(dataTable, true, " where [Login] = SYSTEM_USER ", null, false, 0);
				if (dataTable.Rows.Count > 0)
				{
					dataRow["idUserCreate"] = dataTable.Rows[0]["iduser"];
					if (dataTable.Rows[0]["idWorker"] != DBNull.Value)
					{
						dataRow["IdWorker"] = dataTable.Rows[0]["idWorker"];
					}
				}
				this.dataSetDamage.tJ_RequestForRepair.Rows.Add(dataRow);
			}
			else
			{
				DataRow dataRow2 = this.dataSetDamage.tJ_RequestForRepair.NewRow();
				dataRow2["num"] = 0;
				dataRow2["dateCreate"] = DateTime.Now;
				dataRow2["idWorker"] = -1;
				dataRow2["reguestFiled"] = "";
				dataRow2["idSR"] = this.IdSR;
				dataRow2["schmObj"] = "";
				dataRow2["Purpose"] = "";
				dataRow2["Crash"] = this.typeRequestRepair;
				if (this.typeRequestRepair)
				{
					dataRow2["isPlanned"] = false;
				}
				else
				{
					dataRow2["IsPlanned"] = true;
				}
				dataRow2["agreed"] = false;
				dataRow2["iddivision"] = this.IdDivision;
				DataTable dataTable2 = this.GetTableUser();
				base.SelectSqlData(dataTable2, true, " where [Login] = SYSTEM_USER ", null, false, 0);
				if (dataTable2.Rows.Count > 0)
				{
					dataRow2["idUserCreate"] = dataTable2.Rows[0]["iduser"];
					if (dataTable2.Rows[0]["idWorker"] != DBNull.Value)
					{
						dataRow2["IdWorker"] = dataTable2.Rows[0]["idWorker"];
					}
				}
				this.dataSetDamage.tJ_RequestForRepair.Rows.Add(dataRow2);
				if (this.typeRequestRepair)
				{
					this.cmbIsPlanned.SelectedIndex = 0;
				}
				else
				{
					this.cmbIsPlanned.SelectedIndex = 1;
				}
				if (this.cmbWorker.SelectedItem != null)
				{
					dataRow2["reguestFiled"] = this.cmbWorker.Text;
				}
			}
			break;
		case eActionRequestRepair.Edit:
			if (this.IdRequest > 0)
			{
				base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepair, true, " where id = " + this.IdRequest.ToString());
				base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDaily, true, " where idRequest = " + this.IdRequest.ToString());
				base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDoc, true, " where idRequest = " + this.IdRequest.ToString());
				this.LoadTableSchmObjects();
			}
			break;
		case eActionRequestRepair.Read:
			if (this.IdRequest > 0)
			{
				base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepair, true, " where id = " + this.IdRequest.ToString());
				base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDaily, true, " where idRequest = " + this.IdRequest.ToString());
				base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDoc, true, " where idRequest = " + this.IdRequest.ToString());
				this.LoadTableSchmObjects();
			}
			this.cmbWorker.Enabled = false;
			this.txtRequestFiled.Enabled = false;
			this.cmbSR.Enabled = false;
			this.txtObject.ReadOnly = true;
			this.txtPurpose.ReadOnly = true;
			this.cmbIsPlanned.Enabled = false;
			this.groupBoxDaily.Enabled = false;
			this.txtAgreeWith.ReadOnly = true;
			this.txtComment.ReadOnly = true;
			this.txtAdress.ReadOnly = true;
			this.checkBoxAgreed.Enabled = false;
			this.dateTimePickerDateAgreed.Enabled = false;
			this.cmbDispatcher.Enabled = false;
			break;
		}
		if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0)
		{
            if (this.IdDivision <= 0)
            {
                this.IdDivision = Convert.ToInt32(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["IdDivision"]);
            }
            if (Convert.ToBoolean(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["IsPlanned"]))
			{
				this.cmbIsPlanned.SelectedIndex = 1;
			}
			else
			{
				this.cmbIsPlanned.SelectedIndex = 0;
			}
			if (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Crash"] != DBNull.Value && Convert.ToBoolean(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Crash"]))
			{
				this.cmbIsPlanned.Enabled = false;
			}
		}
        this.CreateCaptionNames();
        if (this.IdDivision == PL_DIVISION)
		{
			this.groupBoxODS.Visible = false;
		}
	}

	private void SetVisibleControl()
	{
		DataTable dataTable = new DataTable("tUser");
		dataTable.Columns.Add("idUser", typeof(int));
		base.SelectSqlData(dataTable, true, " left join vworkergroup w on w.id = tuser.idWorker  where w.ParentKey = ';GroupWorker;Dispatchers;' and tuser.login = SYSTEM_USER", null, false, 0);
        if (dataTable.Rows.Count == 0)
        {
            this.dtpDateCreate.Enabled = false;
            this.dtpFactEnd.Enabled = false;

            if (this.IdDivision == PL_DIVISION)
            {
                this.groupBoxODS.Enabled = false;
            }
            else if (this.IdDivision == NO_DIVISION)
            {
                this.cmbStatus.Visible = false;
                this.labelStatus.Visible = false;
            }

        }
        else
        {
            this.groupBoxODS.Enabled = true;
            this.dtpDateCreate.Enabled = true;
            this.dtpFactEnd.Enabled = true;
        }
	}

	private void groupBoxODS_VisibleChanged(object sender, EventArgs e)
	{
		if (!this.groupBoxODS.Visible)
		{
			this.tabControl.Height = 325;
			base.Height = 391;
			this.buttonCancel.Location = new Point(this.buttonCancel.Location.X, 331);
			this.buttonOK.Location = new Point(this.buttonOK.Location.X, 331);
			return;
		}
		this.tabControl.Height = 581;
		base.Height = 647;
		this.buttonCancel.Location = new Point(this.buttonCancel.Location.X, 587);
		this.buttonOK.Location = new Point(this.buttonOK.Location.X, 587);
	}

    private void CreateCaptionNames()
    {
        string str = "";
        if (this.IdDivision > 0)
        {
            //base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tR_Classifier, true, "where id = " + this.IdDivision.ToString());

            DataTable dataTable = new DataTable("tR_Classifier");
            dataTable.Columns.Add("SocrName", typeof(string));
            base.SelectSqlData(dataTable, true, "where id = " + this.IdDivision.ToString(), null, false, 0);
            if (dataTable.Rows.Count > 0)
            {
                str = " " + dataTable.Rows[0]["SocrName"].ToString();
            }
        }
        
        //if (this.dataSetDamage.tR_Classifier.Rows.Count > 0)
        //{
        //    str = " " + this.dataSetDamage.tR_Classifier.Rows[0]["SocrName"].ToString();
        //}
        switch (this.eAction)
        {
            case (eActionRequestRepair.Add):
                if (this.typeRequestRepair)
                    this.Text = "Создать новую аварийную заявку" + str;
                else
                    this.Text = "Создать новую заявку" + str;
                break;
            case (eActionRequestRepair.Edit):
                if (this.typeRequestRepair)
                    this.Text = "Редактирование аварийной заявки" + str;
                else
                    this.Text = "Редактирование заявки" + str;
                break;
            case (eActionRequestRepair.Read):
                if (this.typeRequestRepair)
                    this.Text = "Просмотр аварийной заявки" + str;
                else
                    this.Text = "Просмотр заявки" + str;
                break;
            default:
                this.Text = "!!! " + str;
                break;
        }

        this.Text = this.Text
            + "  №" + this.dataSetDamage.tJ_RequestForRepair.Rows[0]["num"].ToString()
            + " от " + Convert.ToDateTime(this.dataSetDamage.tJ_RequestForRepair.Rows[0]["DateCreate"]).ToShortDateString();

        this.Text = this.Text + " (N2)";
    }

    private DataTable GetTabletWorkerGroup()
	{
		Type type = Type.GetType("System.Int32");
		DataTable dataTable = new DataTable("vWorkerGroup");
		DataColumn dataColumn = new DataColumn("id", type);
		dataTable.Columns.Add(dataColumn);
		DataColumn column = new DataColumn("fio", Type.GetType("System.String"));
		dataTable.Columns.Add(column);
		DataColumn column2 = new DataColumn("GroupElectrical", type);
		dataTable.Columns.Add(column2);
		dataTable.PrimaryKey = new DataColumn[]
		{
			dataColumn
		};
		DataColumn dataColumn2 = new DataColumn("GroupRoman", Type.GetType("System.String"));
		dataColumn2.Expression = "IIF(groupElectrical = 1, 'I', IIF(groupElectrical = 2, 'II', IIF(groupelectrical=3, 'III', IIF(groupelectrical = 4, 'IV', iif(groupelectrical = 5, 'V', '')))))";
		dataTable.Columns.Add(dataColumn2);
		return dataTable;
	}

	private DataTable GetTableUser()
	{
		Type type = Type.GetType("System.Int32");
		DataTable dataTable = new DataTable("tUser");
		DataColumn dataColumn = new DataColumn("idUser", type);
		dataTable.Columns.Add(dataColumn);
		DataColumn column = new DataColumn("idWorker", type);
		dataTable.Columns.Add(column);
		DataColumn column2 = new DataColumn("name", Type.GetType("System.String"));
		dataTable.Columns.Add(column2);
		dataTable.PrimaryKey = new DataColumn[]
		{
			dataColumn
		};
		return dataTable;
	}

	private void FillComboBoxs(int idDivision = 0)
	{
        string wSelectByDivision = "";
        if (idDivision == NO_DIVISION) wSelectByDivision = "SESNO;";

        DataTable dataTable = this.GetTableUser();
		base.SelectSqlData(dataTable, true, " order by name ", null, false, 0);
		this.cmbUserCreate.DataSource = dataTable;
		this.cmbUserCreate.DisplayMember = "NAME";
		this.cmbUserCreate.ValueMember = "IDUSER";

        DataTable tableITR = this.GetTabletWorkerGroup();
		base.SelectSqlData(tableITR, true, " where ParentKey in (';GroupWorker;ITR;"+ wSelectByDivision + "')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
		this.cmbWorker.DataSource = tableITR;
		this.cmbWorker.DisplayMember = "FIO";
		this.cmbWorker.ValueMember = "ID";

        this.txtRequestFiled.DataSource = tableITR;
		this.txtRequestFiled.DisplayMember = "FIO";
		this.txtRequestFiled.ValueMember = "ID";

        DataTable tableDispatcher = this.GetTabletWorkerGroup();
		base.SelectSqlData(tableDispatcher, true, " where ParentKey in (';GroupWorker;ReconcileRequestRepair;" + wSelectByDivision + "')  and dateend is null group by id, fio, groupelectrical order by fio ", null, false, 0);
		this.cmbDispatcher.DataSource = tableDispatcher;
		this.cmbDispatcher.DisplayMember = "FIO";
		this.cmbDispatcher.ValueMember = "ID";

        base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tR_Classifier, true, " where ParentKey = ';NetworkAreas;" + wSelectByDivision + "' and deleted = 0 and isGroup = 0 order by name ");
		this.cmbSR.DataSource = this.dataSetDamage.tR_Classifier;
		this.cmbSR.DisplayMember = "name";
		this.cmbSR.ValueMember = "ID";
	}

	private void FillComboBoxStatus()
	{
		this.tblRequestForRepairClient = new DataTable("tR_RequestForRepairClient");
		base.SelectSqlData(this.tblRequestForRepairClient, true, "where type = 5 order by name", null, false, 0);
		DataTable dataTable = new DataTable("tR_RequestForRepairClient");
		dataTable.Columns.Add("name", typeof(string));
		dataTable.Columns.Add("value", typeof(int));
		this.cmbStatus.DataSource = dataTable;
		this.cmbStatus.DisplayMember = "Name";
		this.cmbStatus.ValueMember = "Value";
		if (dataTable.Rows.Count == 0)
		{
			foreach (DataRow dataRow in this.tblRequestForRepairClient.Rows)
			{
				dataTable.Rows.Add(new object[]
				{
					dataRow["name"],
					dataRow["Value"]
				});
			}
		}
	}

	private bool CheckRequiredFields()
	{
		bool result = true;
		if (string.IsNullOrEmpty(this.txtRequestFiled.Text))
		{
			this.labelRequestFiled.ForeColor = Color.Red;
			result = false;
		}
		if (this.cmbSR.SelectedIndex < 0)
		{
			this.labelSR.ForeColor = Color.Red;
			result = false;
		}
		if (string.IsNullOrEmpty(this.txtObject.Text))
		{
			this.labelObject.ForeColor = Color.Red;
			result = false;
		}
		if (string.IsNullOrEmpty(this.txtPurpose.Text))
		{
			this.labelPurpose.ForeColor = Color.Red;
			result = false;
		}
		if (this.cmbIsPlanned.SelectedIndex < 0)
		{
			this.labelIsPlanned.ForeColor = Color.Red;
			result = false;
		}
		if (this.dataSetDamage.tJ_RequestForRepairDaily.Rows.Count <= 0)
		{
			List<Color> list = new List<Color>();
			foreach (Control control in this.groupBoxDaily.Controls)
			{
				list.Add(control.ForeColor);
			}
			this.groupBoxDaily.ForeColor = Color.Red;
			int num = 0;
			foreach (Control control in this.groupBoxDaily.Controls)
			{
                control.ForeColor = list[num];
                num++;
			}
			result = false;
		}
		if (this.checkBoxAgreed.Checked && this.IdDivision == ODS_DIVISION && this.cmbStatus.SelectedIndex < 0)
		{
			this.labelStatus.ForeColor = Color.Red;
			result = false;
		}
		return result;
	}

	private void FormJournalRequestForRepairAddEdit_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (base.DialogResult == DialogResult.OK)
		{
			if (this.eAction != (eActionRequestRepair.Read) && !this.CheckRequiredFields())
			{
				MessageBox.Show("Не введены обязательные поля", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				e.Cancel = true;
				return;
			}
			eActionRequestRepair eAction = this.eAction;
			if (eAction == (eActionRequestRepair.Add))
			{
				this.dataSetDamage.tJ_RequestForRepair.Rows[0].EndEdit();
				this.IdRequest = base.InsertSqlDataOneRow(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepair);
				foreach (DataRow dataRow in this.dataSetDamage.tJ_RequestForRepairDaily)
				{
					if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
					{
						dataRow["idRequest"] = this.IdRequest;
						dataRow.EndEdit();
					}
				}
				base.InsertSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDaily);
				base.UpdateSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDaily);
				base.DeleteSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDaily);
				this.UpdateSchmObjList();
				this.UpdateRepairDoc();
				return;
			}
			if (eAction != (eActionRequestRepair.Edit))
			{
				return;
			}
			this.dataSetDamage.tJ_RequestForRepair.Rows[0].EndEdit();
			base.UpdateSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepair);
			foreach (DataRow dataRow2 in this.dataSetDamage.tJ_RequestForRepairDaily)
			{
				if (dataRow2.RowState != DataRowState.Detached && dataRow2.RowState != DataRowState.Deleted)
				{
					dataRow2["idRequest"] = this.IdRequest;
					dataRow2.EndEdit();
				}
			}
			base.InsertSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDaily);
			base.UpdateSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDaily);
			base.DeleteSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDaily);
			this.UpdateSchmObjList();
			this.UpdateRepairDoc();
		}
	}

	private void FormJournalRequestForRepairAddEdit_FormClosed(object sender, FormClosedEventArgs e)
	{
		base.SaveFormConfig(null);
        //base.SaveFormConfig(@"c:\temp\aaa.txt");
    }

	private void cmbIsPlanned_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.cmbIsPlanned.SelectedIndex >= 0)
		{
			this.labelIsPlanned.ForeColor = SystemColors.ControlText;
		}
		if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0)
		{
			if (this.cmbIsPlanned.SelectedIndex == 0)
			{
				this.dataSetDamage.tJ_RequestForRepair.Rows[0]["IsPlanned"] = false;
				return;
			}
			this.dataSetDamage.tJ_RequestForRepair.Rows[0]["IsPlanned"] = true;
		}
	}

	private void checkBoxDaily_CheckedChanged(object sender, EventArgs e)
	{
		this.checkBoxWeekEnd.Enabled = this.checkBoxDaily.Checked;
	}

	private void dateTimePickerBeg_ValueChanged(object sender, EventArgs e)
	{
		this.dateTimePickerEnd.MinDate = this.dateTimePickerBeg.Value.AddMinutes(1.0);
	}

	private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
	{
		this.dateTimePickerBeg.MaxDate = this.dateTimePickerEnd.Value.AddMinutes(-1.0);
	}

	private void dgvDaily_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
        DataRow dataRow = (from o in this.dataSetDamage.tJ_RequestForRepairDaily
                           where o.RowState != DataRowState.Deleted && o.RowState != DataRowState.Detached
                           select o into a
                           orderby a.dateEnd descending
                           select a).First();

        //DataRow dataRow = this.dataSetDamage.tJ_RequestForRepairDaily
        //    .Where(r => ((r.RowState != DataRowState.Deleted) && (r.RowState != DataRowState.Detached)))
        //    .OrderByDescending(r => r.dateEnd)
        //    .First();

        if (Convert.ToDateTime(dataRow["DateEnd"]) > this.dateTimePickerBeg.MaxDate)
		{
			this.dateTimePickerBeg.MaxDate = DateTimePicker.MaximumDateTime;
		}
		this.dateTimePickerBeg.MinDate = Convert.ToDateTime(dataRow["DateEnd"]);
	}

	private void dgvDaily_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		if (this.dataSetDamage.tJ_RequestForRepairDaily.Rows.Count <= 0)
		{
			this.dateTimePickerBeg.MinDate = this.dateTimeBeg;
			return;
		}
        if ((from o in this.dataSetDamage.tJ_RequestForRepairDaily
             where o.RowState != DataRowState.Deleted && o.RowState != DataRowState.Detached
             select o).Count() > 0)
        {
            DataRow dataRow = (from o in this.dataSetDamage.tJ_RequestForRepairDaily
                               where o.RowState != DataRowState.Deleted && o.RowState != DataRowState.Detached
                               select o into a
                               orderby a.dateEnd descending
                               select a).First();

            this.dateTimePickerBeg.MinDate = Convert.ToDateTime(dataRow["DateEnd"]);
			return;
		}
		this.dateTimePickerBeg.MinDate = this.dateTimeBeg;
	}

	private void dgvDaily_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex == this.dgvDaily.Rows.Count - 1)
		{
			DateTime dateTime = Convert.ToDateTime(this.dgvDaily[this.dateEndDataGridViewTextBoxColumn.Name, e.RowIndex].Value);
			if (dateTime > this.dateTimePickerBeg.MaxDate)
			{
				this.dateTimePickerBeg.MaxDate = DateTimePicker.MaximumDateTime;
			}
			this.dateTimePickerBeg.MinDate = dateTime;
		}
	}

	private void dgvDaily_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		if (e.Control is DateTimePicker)
		{
			if (this.dgvDaily.CurrentCell.OwningColumn.Name == this.dateBegDataGridViewTextBoxColumn.Name)
			{
				(e.Control as DateTimePicker).MaxDate = Convert.ToDateTime(this.dgvDaily[this.dateEndDataGridViewTextBoxColumn.Name, this.dgvDaily.CurrentCell.RowIndex].Value);
				if (this.dgvDaily.CurrentCell.RowIndex == 0)
				{
					(e.Control as DateTimePicker).MinDate = new DateTime(2000, 1, 1);
				}
				if (this.dgvDaily.CurrentCell.RowIndex > 0)
				{
					(e.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.dgvDaily[this.dateEndDataGridViewTextBoxColumn.Name, this.dgvDaily.CurrentCell.RowIndex - 1].Value);
				}
			}
			if (this.dgvDaily.CurrentCell.OwningColumn.Name == this.dateEndDataGridViewTextBoxColumn.Name)
			{
				(e.Control as DateTimePicker).MinDate = Convert.ToDateTime(this.dgvDaily[this.dateBegDataGridViewTextBoxColumn.Name, this.dgvDaily.CurrentCell.RowIndex].Value);
				if (this.dgvDaily.CurrentCell.RowIndex == this.dgvDaily.Rows.Count - 1)
				{
					(e.Control as DateTimePicker).MaxDate = new DateTime(9998, 12, 31);
				}
				if (this.dgvDaily.CurrentCell.RowIndex < this.dgvDaily.Rows.Count - 1)
				{
					(e.Control as DateTimePicker).MaxDate = Convert.ToDateTime(this.dgvDaily[this.dateBegDataGridViewTextBoxColumn.Name, this.dgvDaily.CurrentCell.RowIndex + 1].Value);
				}
			}
		}
	}

	private void dgvDaily_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			DayOfWeek dayOfWeek = Convert.ToDateTime(this.dgvDaily[this.dateBegDataGridViewTextBoxColumn.Name, e.RowIndex].Value).DayOfWeek;
			DayOfWeek dayOfWeek2 = Convert.ToDateTime(this.dgvDaily[this.dateEndDataGridViewTextBoxColumn.Name, e.RowIndex].Value).DayOfWeek;
			if ((dayOfWeek == DayOfWeek.Sunday || dayOfWeek == DayOfWeek.Saturday) && this.dgvDaily.Columns[e.ColumnIndex] == this.dateBegDataGridViewTextBoxColumn)
			{
				e.CellStyle.ForeColor = Color.Red;
			}
			if ((dayOfWeek2 == DayOfWeek.Sunday || dayOfWeek2 == DayOfWeek.Saturday) && this.dgvDaily.Columns[e.ColumnIndex] == this.dateEndDataGridViewTextBoxColumn)
			{
				e.CellStyle.ForeColor = Color.Red;
			}
		}
	}

	private void buttonDaily_Click(object sender, EventArgs e)
	{
		bool flag = false;
		this.dgvDaily.RowsAdded -= this.dgvDaily_RowsAdded;
		if (this.checkBoxDaily.Checked)
		{
			for (int i = 0; i <= (this.dateTimePickerEnd.Value - this.dateTimePickerBeg.Value).Days; i++)
			{
				if (this.checkBoxWeekEnd.Checked || (this.dateTimePickerBeg.Value.AddDays((double)i).DayOfWeek != DayOfWeek.Saturday && this.dateTimePickerBeg.Value.AddDays((double)i).DayOfWeek != DayOfWeek.Sunday))
				{
					try
					{
						DataRow dataRow = this.dataSetDamage.tJ_RequestForRepairDaily.NewRow();
						dataRow["idRequest"] = this.IdRequest;
						dataRow["dateBeg"] = this.dateTimePickerBeg.Value.AddDays((double)i);
						dataRow["dateEnd"] = this.dateTimePickerBeg.Value.AddDays((double)i).Date + this.dateTimePickerEnd.Value.TimeOfDay;
						this.dataSetDamage.tJ_RequestForRepairDaily.Rows.Add(dataRow);
						flag = true;
						this.groupBoxDaily.ForeColor = SystemColors.ControlText;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
			}
		}
		else
		{
			try
			{
				DataRow dataRow2 = this.dataSetDamage.tJ_RequestForRepairDaily.NewRow();
				dataRow2["idRequest"] = this.IdRequest;
				dataRow2["dateBeg"] = this.dateTimePickerBeg.Value;
				dataRow2["dateEnd"] = this.dateTimePickerEnd.Value;
				this.dataSetDamage.tJ_RequestForRepairDaily.Rows.Add(dataRow2);
				flag = true;
				this.groupBoxDaily.ForeColor = SystemColors.ControlText;
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.Message, ex2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		this.dgvDaily.RowsAdded += this.dgvDaily_RowsAdded;
		if (flag)
        {
            DataRow dataRow3 = (from o in this.dataSetDamage.tJ_RequestForRepairDaily
                                where o.RowState != DataRowState.Deleted && o.RowState != DataRowState.Detached
                                select o into a
                                orderby a.dateEnd descending
                                select a).First();
            if (Convert.ToDateTime(dataRow3["DateEnd"]) > this.dateTimePickerBeg.MaxDate)
			{
				this.dateTimePickerBeg.MaxDate = this.dateTimeEnd;
			}
			this.dateTimePickerBeg.MinDate = Convert.ToDateTime(dataRow3["DateEnd"]);
		}
	}

	private void cmbWorker_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.cmbWorker.SelectedIndex >= 0)
		{
			this.labelWorker.ForeColor = SystemColors.ControlText;
		}
	}

	//private void txtRequestFiled_TextChanged(object sender, EventArgs e)
	//{
	//	if (!string.IsNullOrEmpty(this.txtRequestFiled.Text))
	//	{
	//		this.labelRequestFiled.ForeColor = SystemColors.ControlText;
	//	}
	//}

	private void cmbSR_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.cmbSR.SelectedIndex >= 0)
		{
			this.labelSR.ForeColor = SystemColors.ControlText;
		}
	}

	private void txtObject_TextChanged(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(this.txtObject.Text))
		{
			this.labelObject.ForeColor = SystemColors.ControlText;
		}
	}

	private void txtPurpose_TextChanged(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(this.txtPurpose.Text))
		{
			this.labelObject.ForeColor = SystemColors.ControlText;
		}
	}

	private void checkBoxAgreed_CheckedChanged(object sender, EventArgs e)
	{
		if (this.checkBoxAgreed.Checked)
		{
			if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0 && this.dateTimePickerDateAgreed.Value == null)
			{
				this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Agreed"] = true;
				this.dateTimePickerDateAgreed.Value = (this.dataSetDamage.tJ_RequestForRepair.Rows[0]["DateAgreed"] = DateTime.Now);
				return;
			}
		}
		else if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count > 0 && this.dateTimePickerDateAgreed.Value != null)
		{
			this.dataSetDamage.tJ_RequestForRepair.Rows[0]["Agreed"] = false;
			this.dateTimePickerDateAgreed.Value = null;
			this.dataSetDamage.tJ_RequestForRepair.Rows[0]["DateAgreed"] = DBNull.Value;
		}
	}

	private void LoadTableLinkObjects()
	{
		this.dsLinkObjects.Tables[this.tableLinkObjects.TableName].Clear();
		if (this.dataSetDamage.tL_RequestForRepairSchmObjList.Rows.Count > 0)
		{
			DataView defaultView = this.dataSetDamage.tL_RequestForRepairSchmObjList.DefaultView;
			defaultView.Sort = "Num";
			DataTable dataTable = defaultView.ToTable();
			int num = 0;
			List<string> list = new List<string>();
			DateTime dateTime = DateTime.Now;
			DateTime dateTime2 = DateTime.Now;
			string value = "";
			foreach (DataRow dataRow in dataTable.Rows)
			{
				if (num == (int)Convert.ToInt16(dataRow["num"]))
				{
					list.Add(base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
					{
						dataRow["idSchmObj"].ToString()
					}).ToString());
				}
				else
				{
					if (list.Count > 0)
					{
						list.Sort();
						DataRow dataRow2 = this.dsLinkObjects.Tables[this.tableLinkObjects.TableName].NewRow();
						dataRow2["Objects"] = "";
						foreach (string arg in list)
						{
							DataRow dataRow3 = dataRow2;
							dataRow3["Objects"] = dataRow3["Objects"] + arg + "\n";
						}
						dataRow2["Objects"] = ((string)dataRow2["Objects"]).Remove(dataRow2["Objects"].ToString().Length - 1);
						dataRow2["DateBeg"] = dateTime;
						dataRow2["DateEnd"] = dateTime2;
						dataRow2["Duration"] = value;
						dataRow2["Num"] = num;
						this.dsLinkObjects.Tables[this.tableLinkObjects.TableName].Rows.Add(dataRow2);
					}
					list = new List<string>();
					list.Add(base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
					{
						dataRow["idSchmObj"].ToString()
					}).ToString());
					dateTime = Convert.ToDateTime(dataRow["DateBeg"]);
					dateTime2 = Convert.ToDateTime(dataRow["DateEnd"]);
					value = dataRow["Duration"].ToString();
					num = (int)Convert.ToInt16(dataRow["Num"]);
				}
			}
			if (list.Count > 0)
			{
				list.Sort();
				DataRow dataRow4 = this.dsLinkObjects.Tables[this.tableLinkObjects.TableName].NewRow();
				dataRow4["Objects"] = "";
				foreach (string arg2 in list)
				{
					DataRow dataRow3 = dataRow4;
					dataRow3["Objects"] = dataRow3["Objects"] + arg2 + "\n";
				}
				dataRow4["Objects"] = ((string)dataRow4["Objects"]).Remove(dataRow4["Objects"].ToString().Length - 1);
				dataRow4["DateBeg"] = dateTime;
				dataRow4["DateEnd"] = dateTime2;
				dataRow4["Duration"] = value;
				dataRow4["Num"] = num;
				this.dsLinkObjects.Tables[this.tableLinkObjects.TableName].Rows.Add(dataRow4);
			}
			if (this.dsLinkObjects.Tables[this.tableLinkObjects.TableName].Rows.Count > 0)
			{
				this.toolBtnViewSChmObj.Enabled = true;
				return;
			}
			this.toolBtnViewSChmObj.Enabled = false;
		}
	}

	private void LoadTableSchmObjects()
	{
		base.SelectSqlData(this.dataSetDamage, this.dataSetDamage.tL_RequestForRepairSchmObjList, true, " where idRequest = " + this.IdRequest.ToString());
		this.LoadTableLinkObjects();
	}

	private void toolBtnLinkSchmObj_Click(object sender, EventArgs e)
	{
        FormLinkRequestAndSchmPL form = new FormLinkRequestAndSchmPL();
		form.SqlSettings = this.SqlSettings;
		if (form.ShowDialog() == DialogResult.OK)
		{
			int num = 1;
			if (this.dataSetDamage.tL_RequestForRepairSchmObjList.Rows.Count > 0)
			{
                num = (int)(this.dataSetDamage.tL_RequestForRepairSchmObjList.Max(r => r.Num) + 1);
            }
			this.dictionaryIdSchmObj = form.GetLinkObjects();
			foreach (int num2 in this.dictionaryIdSchmObj.Keys)
			{
				DataRow dataRow = this.dataSetDamage.tL_RequestForRepairSchmObjList.NewRow();
				dataRow["idRequest"] = this.IdRequest;
				dataRow["idSchmObj"] = num2;
				dataRow["DAteBeg"] = form.DateBeg;
				dataRow["DAteEnd"] = form.DateEnd;
				dataRow["duration"] = form.Duration;
				dataRow["num"] = num;
				this.dataSetDamage.tL_RequestForRepairSchmObjList.Rows.Add(dataRow);
			}
			this.LoadTableLinkObjects();
		}
	}

	private void dgvLinkObjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		this.toolBtnLinkSchmObjEdit_Click(sender, e);
	}

	private void toolBtnLinkSchmObjEdit_Click(object sender, EventArgs e)
	{
		if (this.dgvLinkObjects.CurrentRow == null)
		{
			return;
		}
		DataRow[] array = this.dataSetDamage.tL_RequestForRepairSchmObjList.Select("num = " + this.dgvLinkObjects.CurrentRow.Cells[this.numDataGridViewTextBoxColumn1.Name].Value.ToString());
		this.dictionaryIdSchmObj.Clear();
		if (array.Length != 0)
		{
            FormLinkRequestAndSchmPL form = new FormLinkRequestAndSchmPL();
			form.SqlSettings = this.SqlSettings;
			form.DateBeg = Convert.ToDateTime(array[0]["dateBeg"]);
			form.DateEnd = Convert.ToDateTime(array[0]["dateEnd"]);
			form.Duration = array[0]["Duration"].ToString();
			form.Num = Convert.ToInt16(array[0]["Num"]);
			foreach (DataRow dataRow in array)
			{
				this.dictionaryIdSchmObj.Add(Convert.ToInt32(dataRow["idSchmObj"]), base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
				{
					dataRow["idSchmObj"].ToString()
				}).ToString());
			}
			form.SetLinkObjects(this.dictionaryIdSchmObj);
			if (form.ShowDialog() == DialogResult.OK)
			{
				this.dictionaryIdSchmObj = form.GetLinkObjects();
				foreach (DataRow dataRow2 in array)
				{
					if (this.dictionaryIdSchmObj.ContainsKey(Convert.ToInt32(dataRow2["idSchmObj"])))
					{
						dataRow2["DAteBeg"] = form.DateBeg;
						dataRow2["DAteEnd"] = form.DateEnd;
						dataRow2["duration"] = form.Duration;
						this.dictionaryIdSchmObj.Remove(Convert.ToInt32(dataRow2["idSchmObj"]));
					}
					else
					{
						dataRow2.Delete();
					}
				}
				foreach (int num in this.dictionaryIdSchmObj.Keys)
				{
					DataRow dataRow3 = this.dataSetDamage.tL_RequestForRepairSchmObjList.NewRow();
					dataRow3["idRequest"] = this.IdRequest;
					dataRow3["idSchmObj"] = num;
					dataRow3["DAteBeg"] = form.DateBeg;
					dataRow3["DAteEnd"] = form.DateEnd;
					dataRow3["duration"] = form.Duration;
					dataRow3["num"] = form.Num;
					this.dataSetDamage.tL_RequestForRepairSchmObjList.Rows.Add(dataRow3);
				}
				this.LoadTableLinkObjects();
			}
		}
	}

	private void toolBtnDelSchmObj_Click(object sender, EventArgs e)
	{
		foreach (DataGridViewRow dataGridViewRow in this.dgvLinkObjects.SelectedRows)
		{
			DataRow[] array = this.dataSetDamage.tL_RequestForRepairSchmObjList.Select("num = " + dataGridViewRow.Cells[this.numDataGridViewTextBoxColumn1.Name].Value.ToString());
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Delete();
			}
		}
		this.LoadTableLinkObjects();
	}

	private void toolBtnViewSChmObj_Click(object sender, EventArgs e)
	{
		this.dictionaryIdSchmObj.Clear();
		foreach (DataGridViewRow dataGridViewRow in this.dgvLinkObjects.SelectedRows)
		{
			foreach (DataRow dataRow in this.dataSetDamage.tL_RequestForRepairSchmObjList.Select("num = " + dataGridViewRow.Cells[this.numDataGridViewTextBoxColumn1.Name].Value.ToString()))
			{
				if (!this.dictionaryIdSchmObj.ContainsKey(Convert.ToInt32(dataRow["idSchmObj"])))
				{
					this.dictionaryIdSchmObj.Add(Convert.ToInt32(dataRow["idSchmObj"]), "");
				}
			}
		}
		GoToSchemaEventArgs e2 = new GoToSchemaEventArgs(this.dictionaryIdSchmObj.Keys.ToList<int>());
		this.OnGoToSchema(e2);
	}

	private void UpdateSchmObjList()
	{
		foreach (DataRow dataRow in this.dataSetDamage.tL_RequestForRepairSchmObjList)
		{
			if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
			{
				dataRow["idRequest"] = this.IdRequest;
				dataRow.EndEdit();
			}
		}
		base.InsertSqlData(this.dataSetDamage, this.dataSetDamage.tL_RequestForRepairSchmObjList);
		base.UpdateSqlData(this.dataSetDamage, this.dataSetDamage.tL_RequestForRepairSchmObjList);
		base.DeleteSqlData(this.dataSetDamage, this.dataSetDamage.tL_RequestForRepairSchmObjList);
		this.dataSetDamage.tL_RequestForRepairSchmObjList.AcceptChanges();
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
		base.Close();
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		base.Close();
	}

	private void toolBtnAddDoc_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				for (int i = 0; i < openFileDialog.FileNames.Length; i++)
				{
					DataRow dataRow = this.dataSetDamage.tJ_RequestForRepairDoc.NewRow();
					dataRow["idRequest"] = this.IdRequest;
					dataRow["Document"] = File.ReadAllBytes(openFileDialog.FileNames[i]);
					dataRow["FileName"] = Path.GetFileName(openFileDialog.FileNames[i]);
					this.dataSetDamage.tJ_RequestForRepairDoc.Rows.Add(dataRow);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ex.Source);
		}
	}

	private void toolBtnDelDoc_Click(object sender, EventArgs e)
	{
		if (this.dgvDocs.CurrentRow != null)
		{
			Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
			this.dgvDocs.Rows.Remove(this.dgvDocs.CurrentRow);
			return;
		}
		MessageBox.Show("Не выбрано ни одного файла");
	}

	private void toolBtnViewDoc_Click(object sender, EventArgs e)
	{
		if (this.dgvDocs.CurrentRow == null)
		{
			return;
		}
		int id = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
		byte[] buffer = (byte[])this.dataSetDamage.tJ_RequestForRepairDoc.Rows.Find(id)["Document"];
		string text = Path.GetTempFileName();
		text = Path.ChangeExtension(text, Path.GetExtension(this.dataSetDamage.tJ_RequestForRepairDoc.Rows.Find(id)["FileName"].ToString()));
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

	private void toolBtnSaveDoc_Click(object sender, EventArgs e)
	{
		try
		{
			int id = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
			string fileName = this.dgvDocs.CurrentRow.Cells[this.fileNameDataGridViewTextBoxColumn.Name].Value.ToString();
			string extension = Path.GetExtension(fileName);
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "(*" + extension + ")|*" + extension;
			saveFileDialog.FileName = fileName;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				byte[] buffer = (byte[])this.dataSetDamage.tJ_RequestForRepairDoc.Rows.Find(id)["Document"];
				FileStream fileStream = File.Create(saveFileDialog.FileName);
				fileStream.Write(buffer, 0, buffer.Length);
				fileStream.Close();
				MessageBox.Show("Файл успешно сохранен", "Сохранение");
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ex.Source);
		}
	}

	private void dgvDocs_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
	{
		if (this.dgvDocs.RowCount > 0 && this.dgvDocs[this.fileNameDataGridViewTextBoxColumn.Name, e.RowIndex].Value != null && e.ColumnIndex == this.dgvDocs.Columns[this.ColumnImage.Name].Index)
		{
			Icon icon = FileInfo.IconOfFile(this.dgvDocs[this.fileNameDataGridViewTextBoxColumn.Name, e.RowIndex].Value.ToString());
			e.Value = icon.ToBitmap();
		}
	}

	private void dgvDocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		if (this.dgvDocs.CurrentRow == null)
		{
			return;
		}
		int id = Convert.ToInt32(this.dgvDocs.CurrentRow.Cells[this.idDataGridViewTextBoxColumnDoc.Name].Value);
		if (e.ColumnIndex == this.dgvDocs.Columns[this.fileNameDataGridViewTextBoxColumn.Name].Index)
		{
			byte[] buffer = (byte[])this.dataSetDamage.tJ_RequestForRepairDoc.Rows.Find(id)["Document"];
			string fileName = Path.GetTempFileName();
			fileName = Path.ChangeExtension(fileName, Path.GetExtension(this.dataSetDamage.tJ_RequestForRepairDoc.Rows.Find(id)["FileName"].ToString()));

            FileStream fileStream = File.Create(fileName);
			fileStream.Write(buffer, 0, buffer.Length);
			fileStream.Close();
			new Process
			{
				StartInfo = 
				{
					FileName = fileName,
					UseShellExecute = true
				}
			}.Start();
		}
	}

	private void UpdateRepairDoc()
	{
		foreach (DataRow dataRow in this.dataSetDamage.tJ_RequestForRepairDoc)
		{
			if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
			{
				dataRow["idRequest"] = this.IdRequest;
				dataRow.EndEdit();
			}
		}
		base.InsertSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDoc);
		base.UpdateSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDoc);
		base.DeleteSqlData(this.dataSetDamage, this.dataSetDamage.tJ_RequestForRepairDoc);
		this.dataSetDamage.tL_RequestForRepairSchmObjList.AcceptChanges();
	}

	private void toolBtnCopy_Click(object sender, EventArgs e)
	{
		if (this.dataSetDamage.tJ_RequestForRepair.Rows.Count <= 0)
		{
			return;
		}
		DataRow dataRow = this.dataSetDamage.tJ_RequestForRepair.NewRow();
		dataRow.ItemArray = this.dataSetDamage.tJ_RequestForRepair.Rows[0].ItemArray;
		this.dataSetDamage.tJ_RequestForRepairDoc.Clear();
		this.dataSetDamage.tJ_RequestForRepairDaily.Clear();
		DataRow dataRow2 = this.dataSetDamage.tJ_RequestForRepair.NewRow();
		dataRow2["num"] = 0;
		dataRow2["dateCreate"] = DateTime.Now;
		if (dataRow["idWorker"] != DBNull.Value)
		{
			dataRow2["idWorker"] = dataRow["idWorker"];
		}
		dataRow2["reguestFiled"] = dataRow["reguestFiled"];
		dataRow2["idSR"] = dataRow["idSR"];
		dataRow2["schmObj"] = dataRow["schmObj"];
		dataRow2["Purpose"] = dataRow["Purpose"];
		dataRow2["IsPlanned"] = dataRow["IsPlanned"];
		dataRow2["Crash"] = dataRow["Crash"];
		dataRow2["agreed"] = false;
		dataRow2["iddivision"] = dataRow["iddivision"];
		DataTable dataTable = this.GetTableUser();
		base.SelectSqlData(dataTable, true, " where [Login] = SYSTEM_USER ", null, false, 0);
		if (dataTable.Rows.Count > 0)
		{
			dataRow2["idUserCreate"] = dataTable.Rows[0]["iduser"];
			if (dataTable.Rows[0]["idWorker"] != DBNull.Value)
			{
				dataRow2["IdWorker"] = dataTable.Rows[0]["idWorker"];
			}
		}
		if (dataRow2["idWorker"] == DBNull.Value)
		{
			dataRow2["idWorker"] = -1;
		}
		this.IdRequest = -1;
		this.eAction = (eActionRequestRepair.Add);
		this.dataSetDamage.tJ_RequestForRepair.Rows.Add(dataRow2);
		this.dataSetDamage.tJ_RequestForRepair.Rows.RemoveAt(0);
	}

	protected override XmlDocument CreateXmlConfig()
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
		xmlDocument.AppendChild(newChild);
		XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
		xmlDocument.AppendChild(xmlNode);
		XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("X");
		xmlAttribute.Value = base.Location.X.ToString();
		xmlNode.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("Y");
		xmlAttribute.Value = base.Location.Y.ToString();
		xmlNode.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("SR");
		if (this.eAction == (eActionRequestRepair.Add))
		{
			xmlAttribute.Value = this.cmbSR.SelectedValue.ToString();
		}
		else
		{
			xmlAttribute.Value = this.IdSR.ToString();
		}
		xmlNode.Attributes.Append(xmlAttribute);
		return xmlDocument;
	}

	protected override void ApplyConfig(XmlDocument doc)
	{
		XmlNode xmlNode = doc.SelectSingleNode(base.Name);
		if (xmlNode != null)
		{
			XmlAttribute xmlAttribute = xmlNode.Attributes["X"];
			int? numX = null;
			int? numY = null;
			if (xmlAttribute != null)
			{
				numX = new int?(Convert.ToInt32(xmlAttribute.Value));
			}
			xmlAttribute = xmlNode.Attributes["Y"];
			if (xmlAttribute != null)
			{
				numY = new int?(Convert.ToInt32(xmlAttribute.Value));
			}
			if (numX != null && numY != null)
			{
				if (numX < 0)
				{
					numX = new int?(0);
				}
				if (numY < 0)
				{
					numY = new int?(0);
				}
				base.Location = new Point(numX.Value, numY.Value);
			}
			xmlAttribute = xmlNode.Attributes["SR"];
			if (xmlAttribute != null)
			{
				this.IdSR = Convert.ToInt32(xmlAttribute.Value);
			}
		}
	}

	
}
