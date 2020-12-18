using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;
using Reference.Properties;

namespace Reference.Forms
{
	public partial class FormEquipmentChar : FormBase
	{
		public FormEquipmentChar(SQLSettings settings, int idEquipment, int idTypeEquipment, StateFormCreate state)
		{
			
			
			this.InitializeComponent();
			this.SqlSettings = settings;
			this.int_0 = idEquipment;
			this.int_1 = idTypeEquipment;
			this.stateFormCreate_0 = state;
			if (idTypeEquipment <= 556)
			{
				switch (idTypeEquipment)
				{
				case 535:
				case 536:
				case 537:
				case 538:
					if (state == 1)
					{
						this.Text = "Редактирование подстанции";
						goto IL_14A;
					}
					this.Text = "Информация о подстанции";
					goto IL_14A;
				case 539:
					goto IL_14A;
				case 540:
				case 541:
					break;
				default:
					if (idTypeEquipment == 551)
					{
						goto IL_12D;
					}
					if (idTypeEquipment != 556)
					{
						goto IL_14A;
					}
					if (state == 1)
					{
						this.Text = "Редактирование силового трансформатора";
						goto IL_14A;
					}
					this.Text = "Информация о силовом трансформаторе";
					goto IL_14A;
				}
			}
			else if (idTypeEquipment <= 564)
			{
				if (idTypeEquipment != 563 && idTypeEquipment != 564)
				{
					goto IL_14A;
				}
			}
			else
			{
				if (idTypeEquipment == 584)
				{
					goto IL_12D;
				}
				if (idTypeEquipment != 612)
				{
					goto IL_14A;
				}
				if (state == 1)
				{
					this.Text = "Редактирование муфты";
					goto IL_14A;
				}
				this.Text = "Информация о муфте";
				goto IL_14A;
			}
			if (state == 1)
			{
				this.Text = "Редактирование шины";
				goto IL_14A;
			}
			this.Text = "Информация о шине";
			goto IL_14A;
			IL_12D:
			if (state == 1)
			{
				this.Text = "Редактирование ячейки";
			}
			else
			{
				this.Text = "Информация о ячейке";
			}
			IL_14A:
			this.method_2("Id", idTypeEquipment.ToString());
			this.method_3(idEquipment, idTypeEquipment);
			if (state == 7)
			{
				this.btnOk.Enabled = false;
			}
		}

		public FormEquipmentChar(SQLSettings settings, EquipmentType equipmentType)
		{
			
			
			this.InitializeComponent();
			this.SqlSettings = settings;
			this.equipmentType_0 = equipmentType;
			if (equipmentType <= 95)
			{
				if (equipmentType != 79)
				{
					if (equipmentType != 84)
					{
						if (equipmentType == 95)
						{
							this.Text = "Добавление выключателя";
						}
					}
					else
					{
						this.Text = "Добавление шины";
						this.method_2("ParentId", 84.ToString());
					}
				}
				else
				{
					this.Text = "Добавление подстанции";
					this.method_2("ParentId", 79.ToString());
				}
			}
			else if (equipmentType <= 550)
			{
				if (equipmentType != 545)
				{
					if (equipmentType == 550)
					{
						this.Text = "Добавление ячейки";
						this.method_2("ParentId", 550.ToString());
					}
				}
				else
				{
					this.Text = "Добавление кабеля";
				}
			}
			else if (equipmentType != 556)
			{
				if (equipmentType == 612)
				{
					this.Text = "Добавление муфты";
					this.method_2("Id", 612.ToString());
				}
			}
			else
			{
				this.Text = "Добавление силового трансформатора";
				this.method_2("Id", 556.ToString());
			}
		}

		private void method_0()
		{
		}

		private DataTable method_1(int int_2)
		{
			new Class69
			{
				SqlConnection_0 = new SqlConnection(string.Concat(new string[]
				{
					"Data Source=",
					this.SqlSettings.ServerDB,
					";Initial Catalog=",
					this.SqlSettings.DBName,
					";Integrated Security=True"
				}))
			}.vmethod_0(this.class1_0.fn_EquipmentCharAdd, int_2);
			return this.class1_0.fn_EquipmentCharAdd;
		}

		private void cmsEquipChar_Opened(object sender, EventArgs e)
		{
			DataTable dataSource = this.method_1(this.equipmentType_0);
			this.tscEqupCharAdd.ComboBox.BindingContext = this.BindingContext;
			this.tscEqupCharAdd.ComboBox.DataSource = dataSource;
			this.tscEqupCharAdd.ComboBox.DisplayMember = "Name";
			this.tscEqupCharAdd.ComboBox.ValueMember = "id";
			this.tscEqupCharAdd.ComboBox.SelectedIndex = -1;
		}

		private void tscEqupCharAdd_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.class1_0.tR_TypeCharRel.method_1(this.equipmentType_0, (int)this.tscEqupCharAdd.ComboBox.SelectedValue);
			base.InsertSqlDataOneRow(this.class1_0, this.class1_0.tR_TypeCharRel);
			this.cmsEquipChar.Visible = false;
		}

		private void method_2(string string_0, string string_1)
		{
			base.SelectSqlData(this.class1_0.tR_Classifier, true, string.Concat(new string[]
			{
				"where ",
				string_0,
				" in (",
				string_1,
				")"
			}), null, true, 0);
			base.SelectSqlData(this.class1_0.vR_EquipmentChar, true, "where idTypeEquipment = " + this.equipmentType_0, null, true, 0);
			this.dgvEquipmentChar.DataSource = this.class1_0.vR_EquipmentChar;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.dgvEquipmentChar.RowCount; i++)
			{
				if (this.dgvEquipmentChar.Rows[i].Cells["ValueDGV"].Value == null)
				{
					MessageBox.Show("Введите значение поля \"" + this.dgvEquipmentChar.Rows[i].Cells["NameCharDGV"].Value.ToString() + "\"", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			Class1.Class19 @class = this.class1_0.tR_Equipment.method_5();
			@class.Name = this.cbEquipment.Text;
			@class.idTypeEquipment = (int)this.cbTypeEquipment.SelectedValue;
			@class.Deleted = false;
			this.class1_0.tR_Equipment.method_0(@class);
			this.int_0 = base.InsertSqlDataOneRow(this.class1_0, this.class1_0.tR_Equipment);
			for (int j = 0; j < this.dgvEquipmentChar.RowCount; j++)
			{
				Class1.Class14 class2 = this.class1_0.tR_EquipmentChar.method_5();
				class2.idEquipment = this.int_0;
				class2.idNameChar = (int)this.dgvEquipmentChar.Rows[j].Cells["idEquipmentCharDGV"].Value;
				class2.Value = this.dgvEquipmentChar.Rows[j].Cells["ValueDGV"].Value.ToString();
				this.class1_0.tR_EquipmentChar.method_0(class2);
			}
			base.InsertSqlData(this.class1_0, this.class1_0.tR_EquipmentChar);
			((FormEquipment)Application.OpenForms["FormEquipment"]).ReloadDataGridView();
			base.Close();
		}

		private void method_3(int int_2, int int_3)
		{
			base.SelectSqlData(this.class1_0.tR_Equipment, true, string.Format("where id = {0} and Deleted = 0", this.int_0), null, true, 0);
			this.cbEquipment.Text = this.class1_0.tR_Equipment.Rows[0]["Name"].ToString();
			this.cbTypeEquipment.DataSource = this.class1_0.tR_Classifier;
			this.cbTypeEquipment.DisplayMember = "Name";
			this.cbTypeEquipment.ValueMember = "id";
			this.cbTypeEquipment.SelectedValue = int_3;
			base.SelectSqlData(this.class1_0.vR_EquipmentCharInfo, true, "where idEquipment = " + this.int_0, null, true, 0);
			this.dgvEquipmentChar.DataSource = this.class1_0.vR_EquipmentCharInfo;
		}

		private void method_4()
		{
			base.SelectSqlData(this.class1_0.tAbn, true, "where TypeAbn = " + 614, null, true, 0);
			this.dataGridView1.DataSource = this.class1_0.tAbn;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void tbcDeviceChar_TabIndexChanged(object sender, EventArgs e)
		{
			if (this.tbcDeviceChar.SelectedTab == this.tbpManufacturer)
			{
				this.method_4();
			}
		}

		private int int_0;

		private int int_1;

		private EquipmentType equipmentType_0;

		private StateFormCreate stateFormCreate_0;
	}
}
