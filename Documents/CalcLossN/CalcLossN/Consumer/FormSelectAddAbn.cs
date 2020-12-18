using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using Contractor.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using FormLbr.Classes;
/// <summary>
/// Выбор/создание контрагента
/// </summary>
namespace JournalCalcLoss
{
    /// <summary>
    /// FormTechConnectionAddAbn
    /// </summary>
	public partial class FormSelectAddAbn : FormBase
	{
        private int typeAbn=-1;
        private bool isSelect;

        private CalcLossN.DataSet.DataSetConsumer.vAbnObjAddressDataTable tableAbnObjAddress;

        private int idAbn=-1;
        internal int IdAbn
		{
			get
			{
				return this.idAbn;
			}
			set
			{
				this.idAbn = value;
			}
		}

        //internal int IdAbnObj { get; private set; } = -1;
        
        internal int IdAbnObj { get { return idAbnObj; } private set { this.idAbnObj = value; } }
        private int idAbnObj = -1;


  //      internal int GetIdAbnObj()
		//{
		//	return this.IdAbnObj;
		//}
  //      private void SetIdAbnObj(int idAbnObj)
  //      {
  //          //throw new NotImplementedException();
  //          this.IdAbnObj = idAbnObj;
  //      }

        //public int IdAbnObj
        //{
        //    get
        //    {
        //        return this.idAbnObj;
        //    }
        //    set
        //    {
        //        this.idAbnObj = value;
        //    }
        //}

        internal string AbnName { get; private set; }
        //private string string_0;

        internal string AbnObjName { get; private set; }
  //      internal string GetAbnObjName()
		//{
		//	return this.AbnObjName;
		//}
  //      private void SetAbnObjName(string name)
		//{
		//	this.AbnObjName = name;
		//}

		public FormSelectAddAbn()
		{
			this.InitializeComponent();
			this.Init();
		}

		internal FormSelectAddAbn(int idAbn = -1, int idAbnObj = -1, bool isSelect = false)
		{
			this.InitializeComponent();
			this.IdAbn = idAbn;
			this.IdAbnObj = (idAbnObj);
			this.isSelect = isSelect;
			this.Init();
		}

        private void Init()
		{
			//this.tableAbnObjAddress = new DataSetTechConnection.vAbnObjAddressDataTable();
            this.tableAbnObjAddress = new CalcLossN.DataSet.DataSetConsumer.vAbnObjAddressDataTable();
       
            DataColumn dataColumn = new DataColumn("AddressFL");
			dataColumn.Expression = "isnull(street + ', ', '') + 'д. ' + houseall + isnull(' - ' + name, '')";
			this.tableAbnObjAddress.Columns.Add(dataColumn);
			dataColumn = new DataColumn("AddressUL");
			dataColumn.Expression = "isnull(street + ', ', '') + 'д. ' + houseall";
			this.tableAbnObjAddress.Columns.Add(dataColumn);
			this.addressFLDgvColumn.DataPropertyName = "AddressFL";
			this.addressULDgvColumn.DataPropertyName = "AddressUL";
			this.bindingSourceObj.DataSource = this.tableAbnObjAddress;
			if (!this.isSelect)
			{
				this.buttonCancel.Visible = false;
                this.buttonОК.Visible = false;
				this.Text = "Контрагенты";
				this.splitContainerDgv.Height += 33;
				this.tabControlContr.Top += 33;
			}
		}

		private void FormTechConnectionAddAbn_Load(object sender, EventArgs e)
		{
			if (this.IdAbn != -1)
			{
                CalcLossN.DataSet.DataSetConsumer ds = new CalcLossN.DataSet.DataSetConsumer();
				base.SelectSqlData(ds, ds.vAbn, true, "where id = " + this.IdAbn.ToString());
				if (ds.vAbn.Rows.Count > 0)
				{
					int typeAbn = Convert.ToInt32(ds.vAbn.Rows[0]["typeAbn"]);
					if (typeAbn == (int)AbnType.KontragentFL || typeAbn == (int)AbnType.Private || typeAbn == (int)AbnType.PrivateNoDog)
					{
						this.radioButtonFL.Checked = true;
					}
					this.txtCurrentAbn.Text = ds.vAbn.Rows[0]["Name"].ToString();
				}
			}
			this.LoadKladr();
			this.LoadData();
		}

		private void LoadData()
		{
			//int num = this.idAbn;
			//int num2 = this.IdAbnObj;
			string text = this.toolBtnShowDelAbn.Checked ? " " : " and deleted = 0 ";
			string str = this.chkVisibleNoActiveAbn.Checked ? " " : " and (isActive = 1 or isActive is null) ";
			text += str;
			string text2 = string.Empty;
			foreach (AbnType abnType in Enum.GetValues(typeof(AbnType)))
			{
				if (abnType != AbnType.KontragentFL && abnType != AbnType.Private && abnType != AbnType.PrivateNoDog)
				{
					if (!string.IsNullOrEmpty(text2))
					{
						text2 += ",";
					}
					string str2 = text2;
					int num3 = (int)abnType;
					text2 = str2 + num3.ToString();
				}
			}
			if (this.radioButtonUL.Checked)
			{
				if (this.radioButtonSelectName.Checked)
				{
					base.SelectSqlData(this.dsTC, this.dsTC.vAbn, true, string.Concat(new string[]
					{
						" where typeAbn in (",
						text2,
						") ",
						text,
						" order by name"
					}));
					if (!string.IsNullOrEmpty(this.txtCurrentAbn.Text))
					{
						this.bindingSourceTAbn.Filter = "Name like '%" + this.txtCurrentAbn.Text + "%'";
					}
					else
					{
						this.bindingSourceTAbn.Filter = "";
					}
				}
				else
				{
					if (this.cmbStreet.SelectedIndex < 0)
					{
						if (this.cmbPunkt.SelectedIndex < 0)
						{
							if (this.cmbCity.SelectedIndex < 0)
							{
								base.SelectSqlData(this.dsTC, this.dsTC.vAbn, true, string.Concat(new string[]
								{
									" where typeAbn in (",
									text2,
									") ",
									text,
									" order by name"
								}));
							}
							else
							{
								base.SelectSqlData(this.dsTC, this.dsTC.vAbn, true, string.Concat(new string[]
								{
									" where typeAbn in (",
									text2,
									") ",
									text,
									" and id in (select idAbn from vAbnObjAddress where idCity = ",
									this.cmbCity.SelectedValue.ToString(),
									")  order by name"
								}));
							}
						}
						else
						{
							base.SelectSqlData(this.dsTC, this.dsTC.vAbn, true, string.Concat(new string[]
							{
								" where typeAbn in (",
								text2,
								") ",
								text,
								" and id in (select idAbn from vAbnObjAddress where idCity = ",
								this.cmbPunkt.SelectedValue.ToString(),
								")  order by name"
							}));
						}
					}
					else if (string.IsNullOrEmpty(this.txtHouse.Text) && string.IsNullOrEmpty(this.txtHousePrefix.Text))
					{
						base.SelectSqlData(this.dsTC, this.dsTC.vAbn, true, string.Concat(new string[]
						{
							" where typeAbn in (",
							text2,
							") ",
							text,
							" and id in (select idAbn from vAbnObjAddress where idStreet = ",
							this.cmbStreet.SelectedValue.ToString(),
							")  order by name"
						}));
					}
					else
					{
						base.SelectSqlData(this.dsTC, this.dsTC.vAbn, true, string.Concat(new string[]
						{
							" where typeAbn in (",
							text2,
							") ",
							text,
							" and id in (select idAbn from vAbnObjAddress where idStreet = ",
							this.cmbStreet.SelectedValue.ToString(),
							" and HouseAll like '%",
							this.txtHouse.Text,
							this.txtHousePrefix.Text,
							"%')  order by name"
						}));
					}
					this.bindingSourceTAbn.Filter = "";
				}
			}
			else if (this.radioButtonSelectName.Checked)
			{
				if (string.IsNullOrEmpty(this.txtCurrentAbn.Text))
				{
					this.dsTC.vAbn.Clear();
				}
				else
				{
					base.SelectSqlData(this.dsTC, this.dsTC.vAbn, true, string.Concat(new string[]
					{
						" where name like '%",
						this.txtCurrentAbn.Text,
						"%' and typeAbn not in (",
						text2,
						") ",
						text,
						" order by name"
					}));
				}
			}
			else
			{
				if (this.cmbStreet.SelectedIndex < 0)
				{
					this.dsTC.vAbn.Clear();
				}
				else if (string.IsNullOrEmpty(this.txtHouse.Text) && string.IsNullOrEmpty(this.txtHousePrefix.Text))
				{
					base.SelectSqlData(this.dsTC, this.dsTC.vAbn, true, string.Concat(new string[]
					{
						" where typeAbn not in (",
						text2,
						") ",
						text,
						" and id in (select idAbn from vAbnObjAddress where idStreet = ",
						this.cmbStreet.SelectedValue.ToString(),
						")  order by name"
					}));
				}
				else
				{
					base.SelectSqlData(this.dsTC, this.dsTC.vAbn, true, string.Concat(new string[]
					{
						" where typeAbn not in (",
						text2,
						") ",
						text,
						" and id in (select idAbn from vAbnObjAddress where idStreet = ",
						this.cmbStreet.SelectedValue.ToString(),
						" and HouseAll like '%",
						this.txtHouse.Text,
						this.txtHousePrefix.Text,
						"%')  order by name"
					}));
				}
				this.bindingSourceTAbn.Filter = "";
			}
			this.dgvAbn.SearchGrid(this.idKontragentDgvColumn.Name, this.idAbn.ToString(), false);
			this.dgvObj.SearchGrid(this.idObjDgvColumn.Name, this.IdAbnObj.ToString(), false);
		}

		private void radioButtonUL_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButtonUL.Checked)
			{
				this.addressFLDgvColumn.Visible = false;
				this.addressULDgvColumn.Visible = true;
				this.nameObjDgvColumn.Visible = true;
				if (!this.tabControlContr.TabPages.Contains(this.tabPageDirector))
				{
					this.tabControlContr.TabPages.Insert(1, this.tabPageDirector);
				}
				if (!string.IsNullOrEmpty(this.txtCurrentAbn.Text))
				{
					this.bindingSourceTAbn.Filter = "Name like '%" + this.txtCurrentAbn.Text + "%'";
				}
				else
				{
					this.bindingSourceTAbn.Filter = "";
				}
			}
			else
			{
				this.addressFLDgvColumn.Visible = true;
				this.addressULDgvColumn.Visible = false;
				this.nameObjDgvColumn.Visible = false;
				if (this.tabControlContr.TabPages.Contains(this.tabPageDirector))
				{
					this.tabControlContr.TabPages.Remove(this.tabPageDirector);
				}
				this.bindingSourceTAbn.Filter = "";
			}
			this.LoadData();
		}

		private void txtCurrentAbn_TextChanged(object sender, EventArgs e)
		{
			if (!this.radioButtonUL.Checked)
			{
				this.timerLoadAbn.Stop();
				this.timerLoadAbn.Start();
				return;
			}
			if (!string.IsNullOrEmpty(this.txtCurrentAbn.Text))
			{
				this.bindingSourceTAbn.Filter = "Name like '%" + this.txtCurrentAbn.Text + "%'";
				return;
			}
			this.bindingSourceTAbn.Filter = "";
		}

		private void timerLoadAbn_Tick(object sender, EventArgs e)
		{
			this.LoadData();
			this.timerLoadAbn.Stop();
		}

		private void bindingSourceTAbn_CurrentChanged(object sender, EventArgs e)
		{
			if (this.bindingSourceTAbn.Current != null)
			{
				this.idAbn = Convert.ToInt32(((DataRowView)this.bindingSourceTAbn.Current)["id"]);
				this.typeAbn = Convert.ToInt32(((DataRowView)this.bindingSourceTAbn.Current)["typeAbn"]);
				this.AbnName = ((DataRowView)this.bindingSourceTAbn.Current)["name"].ToString();
				base.SelectSqlData(this.tableAbnObjAddress, true, "where idAbn = " + this.idAbn.ToString(), null, false, 0);
				base.SelectSqlData(this.dsTC.vG_AbnInfo, true, " where idAbn = " + this.idAbn.ToString() + " order by DateChange desc", null, false, 1);
				base.SelectSqlData(this.dsTC.tG_AbnChief, true, " where idAbn = " + this.idAbn.ToString() + " order by DateChange desc", null, false, 1);
				base.SelectSqlData(this.dsTC.vG_AbnAddressL, true, " where idAbn = " + this.idAbn.ToString() + " order by DateChange desc", null, false, 1);
				base.SelectSqlData(this.dsTC.vG_AbnAddressP, true, " where idAbn = " + this.idAbn.ToString() + " order by DateChange desc", null, false, 1);
				base.SelectSqlData(this.dsTC.tAbnContact, true, " where idAbn = " + this.idAbn.ToString() + " order by DateChange desc", null, false, 0);
				base.SelectSqlData(this.dsTC.vAbnType, true, " where idAbn = " + this.idAbn.ToString(), null, false, 0);
				return;
			}
			this.idAbn = -1;
			this.typeAbn = -1;
			this.AbnName = null;
			this.tableAbnObjAddress.Clear();
			this.dsTC.vG_AbnInfo.Clear();
			this.dsTC.tG_AbnChief.Clear();
			this.dsTC.vG_AbnAddressL.Clear();
			this.dsTC.vG_AbnAddressP.Clear();
			this.dsTC.tAbnContact.Clear();
			this.dsTC.vAbnType.Clear();
		}

		private void bindingSourceObj_CurrentChanged(object sender, EventArgs e)
		{
			if (this.bindingSourceObj.Current == null)
			{
				this.IdAbnObj = -1;
				this.AbnObjName = (null);
				return;
			}
			this.IdAbnObj = Convert.ToInt32(((DataRowView)this.bindingSourceObj.Current)["id"]);
			if (this.radioButtonFL.Checked)
			{
				this.AbnObjName = (((DataRowView)this.bindingSourceObj.Current)["AddressFl"].ToString());
				return;
			}
			this.AbnObjName = (((DataRowView)this.bindingSourceObj.Current)["Name"].ToString());
		}

		private bool IsCanEditAbn()
		{
			if (this.typeAbn != (int)AbnType.Legal && this.typeAbn != (int)AbnType.Net && this.typeAbn != (int)AbnType.Private && this.typeAbn != (int)AbnType.PrivateNoDog)
			{
				if (this.typeAbn != (int)AbnType.Sale)
				{
					return true;
				}
			}
			return false;
		}

		private void radioButtonSelectName_CheckedChanged(object sender, EventArgs e)
		{
			this.txtCurrentAbn.Enabled = this.radioButtonSelectName.Checked;
			this.cmbObl.Enabled = !this.radioButtonSelectName.Checked;
			this.cmbCity.Enabled = !this.radioButtonSelectName.Checked;
			this.cmbPunkt.Enabled = !this.radioButtonSelectName.Checked;
			this.cmbStreet.Enabled = !this.radioButtonSelectName.Checked;
			this.txtHouse.Enabled = !this.radioButtonSelectName.Checked;
			this.txtHousePrefix.Enabled = !this.radioButtonSelectName.Checked;
			this.txtFlat.Enabled = !this.radioButtonSelectName.Checked;
			this.LoadData();
		}

		private void LoadKladr()
		{
			if (this.SqlSettings != null)
			{
				base.SelectSqlData(this.dataTableObl, true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr", null, false, 0);
				if (this.cmbObl.SelectedIndex >= 0)
				{
					base.SelectSqlData(this.dataTableRaionObl, true, " where ParentId = " + this.cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
					this.cmbCity.Text = "Ульяновск г";
				}
			}
		}

		private void cmbObl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbObl.SelectedIndex < 0)
			{
				this.dsRaionObl.Tables["tR_KladrObj"].Clear();
				return;
			}
			base.SelectSqlData(this.dataTableRaionObl, true, " where ParentId = " + this.cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
		}

		private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbCity.SelectedIndex < 0)
			{
				this.dsPunkt.Tables["tR_KladrObj"].Clear();
				this.dsStreet.Tables["tR_KladrStreet"].Clear();
			}
			else
			{
				base.SelectSqlData(this.dataTablePunkt, true, " where ParentId = " + this.cmbCity.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
				this.cmbPunkt.SelectedIndex = -1;
				base.SelectSqlData(this.dataTablesRaionObl, true, " where KladrObjId = " + this.cmbCity.SelectedValue + " and deleted = 0 order by name, socr ", null, false, 0);
				this.cmbStreet.SelectedIndex = -1;
			}
			this.LoadData();
		}

		private void cmbPunkt_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbPunkt.SelectedIndex >= 0)
			{
				base.SelectSqlData(this.dataTablesRaionObl, true, " where KladrObjId = " + this.cmbPunkt.SelectedValue + " and deleted = 0 order by name, socr ", null, false, 0);
			}
			else if (this.cmbCity.SelectedIndex >= 0)
			{
				base.SelectSqlData(this.dataTablesRaionObl, true, " where KladrObjId = " + this.cmbCity.SelectedValue + " and deleted = 0 order by name, socr ", null, false, 0);
			}
			this.cmbStreet.SelectedIndex = -1;
			this.LoadData();
		}

		private void cmbStreet_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void txtHouse_TextChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void txtHousePrefix_TextChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void txtFlat_TextChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void toolBtnAddCont_Click(object sender, EventArgs e)
		{
			FormAddEditContracor formAddEditContracor = new FormAddEditContracor(-1, this.radioButtonFL.Checked ? AbnType.KontragentFL : AbnType.KontragentLegal, string.IsNullOrEmpty(this.txtCurrentAbn.Text) ? "NoName" : this.txtCurrentAbn.Text);
			formAddEditContracor.SqlSettings = this.SqlSettings;
			if (formAddEditContracor.ShowDialog() == DialogResult.OK)
			{
				if (formAddEditContracor.TypeAbn == AbnType.KontragentLegal)
				{
					this.radioButtonUL.Checked = true;
				}
				else
				{
					this.radioButtonFL.Checked = true;
				}
				this.txtCurrentAbn.Text = formAddEditContracor.NameAbn;
				this.LoadData();
				this.dgvAbn.SearchGrid(this.idKontragentDgvColumn.Name, formAddEditContracor.Id.ToString(), false);
			}
		}

		private void toolBtnEditCont_Click(object sender, EventArgs e)
		{
			if (this.bindingSourceTAbn.Current != null)
			{
				if (!this.IsCanEditAbn())
				{
					MessageBox.Show("Редактирование данного контрагента невозможно");
					return;
				}
				FormAddEditContracor formAddEditContracor = new FormAddEditContracor(this.idAbn, this.radioButtonFL.Checked ? AbnType.KontragentFL : AbnType.KontragentLegal, string.IsNullOrEmpty(this.txtCurrentAbn.Text) ? "NoName" : this.txtCurrentAbn.Text);
				formAddEditContracor.SqlSettings = this.SqlSettings;
				if (formAddEditContracor.ShowDialog() == DialogResult.OK)
				{
					if (formAddEditContracor.TypeAbn == AbnType.KontragentLegal)
					{
						this.radioButtonUL.Checked = true;
					}
					else
					{
						this.radioButtonFL.Checked = true;
					}
					this.txtCurrentAbn.Text = formAddEditContracor.NameAbn;
					this.LoadData();
					this.dgvAbn.SearchGrid(this.idKontragentDgvColumn.Name, this.idAbn.ToString(), false);
				}
			}
		}

		private void toolBtnDelCont_Click(object sender, EventArgs e)
		{
			if (this.dgvAbn.CurrentRow != null)
			{
				if (!this.IsCanEditAbn())
				{
					MessageBox.Show("Удаление данного контрагента невозможно");
					return;
				}
				if (MessageBox.Show(Convert.ToBoolean(this.dgvAbn.CurrentRow.Cells[this.deletedKontragentDgvColumn.Name].Value) ? "Вы действительно хотите восстановить текущего контрагента" : "Вы действительно хотите удалить текущего контрагента?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					int currentRow = -1;
					if (this.dgvAbn.CurrentRow.Index > 0)
					{
						currentRow = Convert.ToInt32(this.dgvAbn.Rows[this.dgvAbn.CurrentRow.Index - 1].Cells[this.idKontragentDgvColumn.Name].Value);
					}
                    CalcLossN.DataSet.DataSetConsumer dsTechConnection = new CalcLossN.DataSet.DataSetConsumer();
					base.SelectSqlData(dsTechConnection, dsTechConnection.tAbn, true, "where id = " + this.idAbn);
					dsTechConnection.tAbn.Rows[0]["Deleted"] = !Convert.ToBoolean(dsTechConnection.tAbn.Rows[0]["Deleted"]);
					dsTechConnection.tAbn.Rows[0].EndEdit();
					if (base.UpdateSqlData(dsTechConnection, dsTechConnection.tAbn))
					{
						if (Convert.ToBoolean(dsTechConnection.tAbn.Rows[0]["Deleted"]))
						{
							MessageBox.Show("Абонент успешно удален");
						}
						else
						{
							MessageBox.Show("Абонент успешно восстановлен");
						}
					}
					this.LoadData();
					if (Convert.ToBoolean(dsTechConnection.tAbn.Rows[0]["Deleted"]) && !this.toolBtnShowDelAbn.Checked)
					{
						this.dgvAbn.SearchGrid(this.idKontragentDgvColumn.Name, currentRow.ToString(), false);
					}
				}
			}
		}

		private void toolBtnShowDelAbn_Click(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void dgvAbn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if (Convert.ToInt32(this.dgvAbn[this.typeAbnDgvColumn.Name, e.RowIndex].Value) == (int)AbnType.Private)
				{
					e.CellStyle.ForeColor = Color.Blue;
				}
				if (Convert.ToInt32(this.dgvAbn[this.typeAbnDgvColumn.Name, e.RowIndex].Value) == (int)AbnType.Legal)
				{
					e.CellStyle.ForeColor = Color.Green;
				}
				if (Convert.ToInt32(this.dgvAbn[this.typeAbnDgvColumn.Name, e.RowIndex].Value) == (int)AbnType.Net)
				{
					e.CellStyle.ForeColor = Color.Red;
				}
				if (Convert.ToInt32(this.dgvAbn[this.typeAbnDgvColumn.Name, e.RowIndex].Value) == (int)AbnType.Sale)
				{
					e.CellStyle.ForeColor = Color.Purple;
				}
				if (Convert.ToBoolean(this.dgvAbn[this.deletedKontragentDgvColumn.Name, e.RowIndex].Value))
				{
					e.CellStyle.ForeColor = Color.Red;
				}
				if (this.dgvAbn[this.isActiveDgvColumn.Name, e.RowIndex].Value != DBNull.Value && !Convert.ToBoolean(this.dgvAbn[this.isActiveDgvColumn.Name, e.RowIndex].Value))
				{
					e.CellStyle.BackColor = Color.Yellow;
				}
			}
		}

		private void toolBtnAddObj_Click(object sender, EventArgs e)
		{
			KontragentObjType typeObj = (this.typeAbn == (int)AbnType.Private || this.typeAbn == (int)AbnType.PrivateNoDog || this.typeAbn == (int)AbnType.KontragentFL) ? KontragentObjType.KontragentObjFL : KontragentObjType.KontragentObjLegal;
			if (new FormAddEditObj(this.idAbn, -1, FormAddEditObj.ActionAbnObj.Add, -1, FormAddEditObj.ActionAbnObjReg.Add, this.typeAbn, typeObj)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.tableAbnObjAddress, true, "where idAbn = " + this.idAbn.ToString(), null, false, 0);
			}
		}

		private void toolBtnEditObj_Click(object sender, EventArgs e)
        {
			if (this.dgvObj.CurrentRow != null)
			{
				int idObj = Convert.ToInt32(this.dgvObj.CurrentRow.Cells[this.idObjDgvColumn.Name].Value);
				int idObjReg = (this.dgvObj.CurrentRow.Cells[this.idObjRegDgvColumn.Name].Value == DBNull.Value) ? 0 : Convert.ToInt32(this.dgvObj.CurrentRow.Cells[this.idObjRegDgvColumn.Name].Value);
				KontragentObjType typeObj = (this.typeAbn == (int)AbnType.Private || this.typeAbn == (int)AbnType.PrivateNoDog || this.typeAbn == (int)AbnType.KontragentFL) ? KontragentObjType.KontragentObjFL : KontragentObjType.KontragentObjLegal;
				base.SelectSqlData(this.dsTC, this.dsTC.tAbnObj, true, "where id = " + idObj.ToString());
				if (this.dsTC.tAbnObj.Rows.Count > 0 && (this.dsTC.tAbnObj.Rows[0]["typeObj"] == DBNull.Value || (Convert.ToInt32(this.dsTC.tAbnObj.Rows[0]["typeObj"]) != 1148 && Convert.ToInt32(this.dsTC.tAbnObj.Rows[0]["typeObj"]) != 1149)))
				{
					MessageBox.Show("Редактирование данного объекта невозможно");
					return;
				}
				if (new FormAddEditObj(this.idAbn, idObj, FormAddEditObj.ActionAbnObj.Edit, idObjReg, FormAddEditObj.ActionAbnObjReg.Edit, this.typeAbn, typeObj)
				{
					SqlSettings = this.SqlSettings
				}.ShowDialog() == DialogResult.OK)
				{
					base.SelectSqlData(this.tableAbnObjAddress, true, "where idAbn = " + this.idAbn.ToString(), null, false, 0);
					return;
				}
			}
			else
			{
				MessageBox.Show("Нечего редактировать.");
			}
		}

		private void toolBtnDelObj_Click(object sender, EventArgs e)
		{
			if (this.dgvObj.CurrentRow != null && MessageBox.Show("Удалить текущий объект?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes && MessageBox.Show("Уверены? ВСЕ ТЕКУЩИЕ ДАННЫЕ БУДУТ ПОТЕРЯНЫ!!!", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				MessageBox.Show("Функция отключена. Обратитесь в ОА.");
			}
		}

		private void tsbAddAbnInfo_Click(object sender, EventArgs e)
		{
			if (!this.IsCanEditAbn())
			{
				MessageBox.Show("Редактирование данного контрагента невозможно");
				return;
			}
			ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
			showFormEventArgs.TypeForm = "Legal.Forms.FormAbnDetails, Legal";
			showFormEventArgs.FormMode = eFormMode.Dialog;
			showFormEventArgs.Param = new object[2];
			showFormEventArgs.Param[0] = this.idAbn;
			showFormEventArgs.Param[1] = true;
			showFormEventArgs.SQLSettings = this.SqlSettings;
			this.OnShowForm(showFormEventArgs);
			if (showFormEventArgs.DialogResult == DialogResult.OK)
			{
				base.SelectSqlData(this.dsTC.vG_AbnInfo, true, " where idAbn = " + this.idAbn.ToString() + " order by DateChange desc", null, false, 1);
			}
		}

		private void tsbEditInfo_Click(object sender, EventArgs e)
		{
			if (!this.IsCanEditAbn())
			{
				MessageBox.Show("Редактирование данного контрагента невозможно");
				return;
			}
			ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
			showFormEventArgs.TypeForm = "Legal.Forms.FormAbnDetails, Legal";
			showFormEventArgs.FormMode = eFormMode.Dialog;
			showFormEventArgs.Param = new object[2];
			showFormEventArgs.Param[0] = this.idAbn;
			showFormEventArgs.Param[1] = false;
			showFormEventArgs.SQLSettings = this.SqlSettings;
			this.OnShowForm(showFormEventArgs);
			if (showFormEventArgs.DialogResult == DialogResult.OK)
			{
				base.SelectSqlData(this.dsTC.vG_AbnInfo, true, " where idAbn = " + this.idAbn.ToString() + " order by DateChange desc", null, false, 1);
			}
		}

		private void tsbInfoHistory_Click(object sender, EventArgs e)
		{
			ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
			showFormEventArgs.TypeForm = "Legal.Forms.FormAbnDetailsHistory, Legal";
			if (base.MdiParent == null)
			{
				showFormEventArgs.FormMode = eFormMode.Dialog;
			}
			else
			{
				showFormEventArgs.FormMode = eFormMode.Mdi;
			}
			showFormEventArgs.Param = new object[1];
			showFormEventArgs.Param[0] = this.idAbn;
			showFormEventArgs.SQLSettings = this.SqlSettings;
			this.OnShowForm(showFormEventArgs);
		}

		private void tsbDirectorAdd_Click(object sender, EventArgs e)
		{
			if (!this.IsCanEditAbn())
			{
				MessageBox.Show("Редактирование данного контрагента невозможно");
				return;
			}
			ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
			showFormEventArgs.TypeForm = "Legal.Forms.FormAbnChief, Legal";
			showFormEventArgs.FormMode = eFormMode.Dialog;
			showFormEventArgs.Param = new object[2];
			showFormEventArgs.Param[0] = this.idAbn;
			showFormEventArgs.Param[1] = true;
			showFormEventArgs.SQLSettings = this.SqlSettings;
			this.OnShowForm(showFormEventArgs);
			if (showFormEventArgs.DialogResult == DialogResult.OK)
			{
				base.SelectSqlData(this.dsTC.tG_AbnChief, true, " where idAbn = " + this.idAbn.ToString() + " order by DateChange desc", null, false, 1);
			}
		}

		private void tsbDirectorEdit_Click(object sender, EventArgs e)
		{
			if (!this.IsCanEditAbn())
			{
				MessageBox.Show("Редактирование данного контрагента невозможно");
				return;
			}
			ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
			showFormEventArgs.TypeForm = "Legal.Forms.FormAbnChief, Legal";
			showFormEventArgs.FormMode = eFormMode.Dialog;
			showFormEventArgs.Param = new object[2];
			showFormEventArgs.Param[0] = this.idAbn;
			showFormEventArgs.Param[1] = false;
			showFormEventArgs.SQLSettings = this.SqlSettings;
			this.OnShowForm(showFormEventArgs);
			if (showFormEventArgs.DialogResult == DialogResult.OK)
			{
				base.SelectSqlData(this.dsTC.tG_AbnChief, true, " where idAbn = " + this.idAbn.ToString() + " order by DateChange desc", null, false, 1);
			}
		}

		private void tsbDirectorHistory_Click(object sender, EventArgs e)
		{
			ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
			showFormEventArgs.TypeForm = "Legal.Forms.FormAbnChiefHistory, Legal";
			showFormEventArgs.FormMode = ((base.MdiParent == null) ? eFormMode.Dialog : eFormMode.Mdi);
			showFormEventArgs.Param = new object[1];
			showFormEventArgs.Param[0] = this.idAbn;
			showFormEventArgs.SQLSettings = this.SqlSettings;
			this.OnShowForm(showFormEventArgs);
		}

		private void tsbAddressHistory_Click(object sender, EventArgs e)
		{
			if (!this.IsCanEditAbn())
			{
				MessageBox.Show("Редактирование данного контрагента невозможно");
				return;
			}
			ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
			showFormEventArgs.TypeForm = "Legal.Forms.FormAbnAddressHistory, Legal";
			showFormEventArgs.FormMode = eFormMode.Dialog;
			showFormEventArgs.Param = new object[1];
			showFormEventArgs.Param[0] = this.idAbn;
			showFormEventArgs.SQLSettings = this.SqlSettings;
			this.OnShowForm(showFormEventArgs);
			if (showFormEventArgs.DialogResult == DialogResult.OK)
			{
				base.SelectSqlData(this.dsTC.vG_AbnAddressL, true, " where idAbn = " + this.idAbn.ToString() + " order by DateChange desc", null, false, 1);
				base.SelectSqlData(this.dsTC.vG_AbnAddressP, true, " where idAbn = " + this.idAbn.ToString() + " order by DateChange desc", null, false, 1);
			}
		}

		private void toolStripButtonNewContact_Click(object sender, EventArgs e)
		{
			ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
			showFormEventArgs.TypeForm = "Legal.Forms.FormAbnContactAdd, Legal";
			showFormEventArgs.FormMode = eFormMode.Dialog;
			showFormEventArgs.Param = new object[2];
			showFormEventArgs.Param[0] = this.idAbn;
			showFormEventArgs.Param[1] = true;
			showFormEventArgs.SQLSettings = this.SqlSettings;
			this.OnShowForm(showFormEventArgs);
			if (showFormEventArgs.DialogResult == DialogResult.OK)
			{
				base.SelectSqlData(this.dsTC, this.dsTC.tAbnContact, true, " where idAbn = " + this.idAbn.ToString() + " order by DateChange desc");
			}
		}

		private void toolStripButtonEditContac_Click(object sender, EventArgs e)
		{
			ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
			showFormEventArgs.TypeForm = "Legal.Forms.FormAbnContactAdd, Legal";
			showFormEventArgs.FormMode = eFormMode.Dialog;
			showFormEventArgs.Param = new object[2];
			showFormEventArgs.Param[0] = Convert.ToInt32(this.dGVAbnContact.CurrentRow.Cells["idDGVTBC"].Value);
			showFormEventArgs.Param[1] = false;
			showFormEventArgs.SQLSettings = this.SqlSettings;
			this.OnShowForm(showFormEventArgs);
			if (showFormEventArgs.DialogResult == DialogResult.OK)
			{
				base.SelectSqlData(this.dsTC, this.dsTC.tAbnContact, true, " where idAbn = " + this.idAbn.ToString() + " order by DateChange desc");
			}
		}

		private void toolStripButtonDelContact_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Хотите удалить контакт?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				base.DeleteSqlDataById(this.dsTC.tAbnContact, Convert.ToInt32(this.dGVAbnContact.CurrentRow.Cells["idDGVTBC"].Value));
				base.SelectSqlData(this.dsTC, this.dsTC.tAbnContact, true, " where idAbn = " + this.idAbn.ToString() + " order by DateChange desc");
			}
		}

		private void buttonОК_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			if (this.idAbn != -1 && new FormaddEditAbnType(-1, this.idAbn)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.dsTC, this.dsTC.vAbnType, true, " where idAbn = " + this.idAbn.ToString());
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			if (this.idAbn != -1 && this.dgvAbnType.CurrentRow != null && new FormaddEditAbnType(Convert.ToInt32(this.dgvAbnType.CurrentRow.Cells[this.idAbnTypeDgvColumn.Name].Value), this.idAbn)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.dsTC, this.dsTC.vAbnType, true, " where idAbn = " + this.idAbn.ToString());
			}
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			if (this.dgvAbnType.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить текущую запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				base.DeleteSqlDataById(this.dsTC.tAbnType, Convert.ToInt32(this.dgvAbnType.CurrentRow.Cells[this.idAbnTypeDgvColumn.Name].Value));
				base.SelectSqlData(this.dsTC, this.dsTC.vAbnType, true, " where idAbn = " + this.idAbn.ToString());
				MessageBox.Show("Запись успешно удалена");
			}
		}

		private void chkVisibleNoActiveAbn_CheckedChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

	

	}
}
