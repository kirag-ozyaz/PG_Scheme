using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;
using Reference.Properties;

namespace Reference.Forms
{
	public partial class FormEquipment : FormBase
	{
		public FormEquipment(SQLSettings settings, EquipmentType equipmentType)
		{
			
			
			this.InitializeComponent();
			this.SqlSettings = settings;
			this.equipmentType_0 = equipmentType;
			this.ReloadDataGridView();
		}

		public void ReloadDataGridView()
		{
			EquipmentType equipmentType = this.equipmentType_0;
			if (equipmentType <= 95)
			{
				if (equipmentType == 79)
				{
					this.Text = "Справочник подстанций";
					this.method_0("535,536,537,538");
					return;
				}
				if (equipmentType == 84)
				{
					this.Text = "Справочник шин";
					this.method_0("540,541,563,564");
					return;
				}
				if (equipmentType != 95)
				{
					return;
				}
				this.Text = "Справочник выключателей";
				this.method_0("");
				return;
			}
			else if (equipmentType <= 550)
			{
				if (equipmentType == 545)
				{
					this.Text = "Справочник кабелей";
					this.method_0("");
					return;
				}
				if (equipmentType != 550)
				{
					return;
				}
				this.Text = "Справочник ячеек";
				this.method_0("551,584");
				return;
			}
			else
			{
				if (equipmentType == 556)
				{
					this.Text = "Справочник силовых трансформаторов";
					this.method_0("556");
					return;
				}
				if (equipmentType != 612)
				{
					return;
				}
				this.Text = "Справочник муфт";
				this.method_0("612");
				return;
			}
		}

		private void method_0(string string_0)
		{
			base.SelectSqlData(this.class1_0.tR_Equipment, true, "WHERE idTypeEquipment in (" + string_0 + ") and Deleted = 0", null, true, 0);
			this.dgvEquipment.DataSource = this.class1_0.tR_Equipment;
		}

		private void tsbEquipmentAdd_Click(object sender, EventArgs e)
		{
			new FormEquipmentChar(this.SqlSettings, this.equipmentType_0)
			{
				MdiParent = Application.OpenForms["FormMain"]
			}.Show();
		}

		private void tsbEquipmentDel_Click(object sender, EventArgs e)
		{
			if (this.dgvEquipment.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить оборудование?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.DeleteSqlDataById(this.class1_0.tR_Equipment, (int)this.dgvEquipment.CurrentRow.Cells["idEquipment"].Value);
			}
		}

		private void tsbEquipmentInfo_Click(object sender, EventArgs e)
		{
			if (this.dgvEquipment.CurrentRow != null)
			{
				new FormEquipmentChar(this.SqlSettings, (int)this.dgvEquipment.CurrentRow.Cells["idEquipment"].Value, (int)this.dgvEquipment.CurrentRow.Cells["idTypeEquipment"].Value, 7)
				{
					MdiParent = Application.OpenForms["FormMain"]
				}.Show();
			}
		}

		private void tsbEquipmentEdit_Click(object sender, EventArgs e)
		{
		}

		private EquipmentType equipmentType_0;
	}
}
