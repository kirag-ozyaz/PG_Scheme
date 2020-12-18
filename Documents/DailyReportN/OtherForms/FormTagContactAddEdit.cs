using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr;
using DataSql;
using FormLbr;
/// <summary>
/// FormTagContactAddEdit
/// Form85
/// </summary>
internal partial class FormTagContactAddEdit : FormBase
{
	internal string TagName
	{
		get
		{
			return this.txtTag.Text;
		}
	}

	internal string method_0()
	{
		if (this.cmbDivision.SelectedItem != null)
		{
			return ((DataRowView)this.cmbDivision.SelectedItem).Row["Name"].ToString();
		}
		return null;
	}

	internal object method_1()
	{
		return this.cmbDivision.SelectedValue;
	}

	internal string method_2()
	{
		if (this.cmbFIO.SelectedItem != null)
		{
			return ((DataRowView)this.cmbFIO.SelectedItem).Row["FIO"].ToString();
		}
		return null;
	}

	internal object method_3()
	{
		return this.cmbFIO.SelectedValue;
	}

	internal string Contact
	{
		get
		{
			return this.txtContact.Text;
		}
	}

	internal FormTagContactAddEdit(FormTagContactAddEdit.eActionRequest editMode = (FormTagContactAddEdit.eActionRequest.Add), FormTagContactAddEdit.eSelectTypeFieldContact typeFieldContact = (FormTagContactAddEdit.eSelectTypeFieldContact.Tag), TreeDataGridViewNode treeDataGridViewNode_1 = null)
	{
		////////////
		
		this.InitializeComponent();
		this.EditMode = editMode;
		this.Text = ((editMode == (FormTagContactAddEdit.eActionRequest.Add)) ? "Добавление" : "Редактирование");
		this.typeFieldContact = typeFieldContact;
		this.treeDataGridViewNode_0 = treeDataGridViewNode_1;
		switch (typeFieldContact)
		{
		case (FormTagContactAddEdit.eSelectTypeFieldContact.Tag):
		{
			this.Text += " тэга";
			Control control = this.labelDivision;
			this.cmbDivision.Visible = false;
			control.Visible = false;
			this.panel1.Visible = false;
			base.Height -= 114;
			return;
		}
		case (FormTagContactAddEdit.eSelectTypeFieldContact.Division):
			this.Text += " подразделения";
			this.panel1.Visible = false;
			base.Height -= 79;
			this.txtTag.ReadOnly = true;
			this.txtTag.BackColor = SystemColors.Window;
			return;
		case (FormTagContactAddEdit.eSelectTypeFieldContact.Contact):
			this.txtTag.ReadOnly = true;
			this.txtTag.BackColor = SystemColors.Window;
			this.cmbDivision.Enabled = false;
			return;
		default:
			return;
		}
	}

	private void FormTagContactAddEdit_Load(object sender, EventArgs e)
	{
		this.txtTag.Text = this.method_4(this.treeDataGridViewNode_0);
		DataTable dataTable = this.method_7();
		base.SelectSqlData(dataTable, true, " where ParentKey = ';ReportDaily;DivisionApply;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
		dataTable.Rows.Add(new object[]
		{
			"-1",
			"Производственная лаборатория"
		});
		List<int> list = new List<int>();
		TreeDataGridViewNode treeDataGridViewNode = null;
		if (this.treeDataGridViewNode_0 != null)
		{
			switch (this.treeDataGridViewNode_0.Level)
			{
			case 1:
				treeDataGridViewNode = this.treeDataGridViewNode_0;
				break;
			case 2:
				treeDataGridViewNode = this.treeDataGridViewNode_0.Parent;
				break;
			case 3:
				treeDataGridViewNode = this.treeDataGridViewNode_0.Parent.Parent;
				break;
			}
		}
		if (treeDataGridViewNode != null)
		{
			foreach (TreeDataGridViewNode treeDataGridViewNode2 in treeDataGridViewNode.Nodes)
			{
				if (treeDataGridViewNode2.Cells[1].Value != null && (this.EditMode != (FormTagContactAddEdit.eActionRequest)1 || this.typeFieldContact != (FormTagContactAddEdit.eSelectTypeFieldContact)1 || this.treeDataGridViewNode_0.Cells[1].Value != treeDataGridViewNode2.Cells[1].Value) && this.typeFieldContact != (FormTagContactAddEdit.eSelectTypeFieldContact)2)
				{
					list.Add(Convert.ToInt32(treeDataGridViewNode2.Cells[1].Value));
				}
			}
		}
		foreach (int num in list)
		{
			DataRow dataRow = dataTable.Rows.Find(num);
			if (dataRow != null)
			{
				dataTable.Rows.Remove(dataRow);
			}
		}
		this.cmbDivision.DisplayMember = "name";
		this.cmbDivision.ValueMember = "id";
		this.cmbDivision.DataSource = dataTable;
		int? num2 = this.method_5(this.treeDataGridViewNode_0);
		if (num2 != null)
		{
			this.cmbDivision.SelectedValue = num2;
		}
		else
		{
			this.cmbDivision.SelectedIndex = -1;
		}
		DataTable dataSource = new SqlDataCommand(this.SqlSettings).SelectSqlData("select id, f + isnull(' ' + i, '') + isnull(' ' + o, '') as fio from tr_worker where dateEnd is null order by f,i,o");
		this.cmbFIO.DisplayMember = "FIO";
		this.cmbFIO.ValueMember = "ID";
		this.cmbFIO.DataSource = dataSource;
		int? num3 = this.method_6(this.treeDataGridViewNode_0);
		if (num3 != null)
		{
			this.cmbFIO.SelectedValue = num3;
		}
		else
		{
			this.cmbFIO.SelectedIndex = -1;
		}
		if (this.treeDataGridViewNode_0 != null && this.treeDataGridViewNode_0.Level == 3 && this.treeDataGridViewNode_0.Cells[4].Value != null)
		{
			this.txtContact.Text = this.treeDataGridViewNode_0.Cells[4].Value.ToString();
		}
	}

	private string method_4(TreeDataGridViewNode treeDataGridViewNode_1)
	{
		if (treeDataGridViewNode_1 == null)
		{
			return null;
		}
		switch (treeDataGridViewNode_1.Level)
		{
		case 1:
			return treeDataGridViewNode_1.Cells[0].Value.ToString();
		case 2:
			return treeDataGridViewNode_1.Parent.Cells[0].Value.ToString();
		case 3:
			return treeDataGridViewNode_1.Parent.Parent.Cells[0].Value.ToString();
		default:
			return null;
		}
	}

	private int? method_5(TreeDataGridViewNode treeDataGridViewNode_1)
	{
		if (treeDataGridViewNode_1 == null)
		{
			return null;
		}
		int level = treeDataGridViewNode_1.Level;
		if (level != 2)
		{
			if (level != 3)
			{
				return null;
			}
			if (treeDataGridViewNode_1.Parent.Cells[1].Value != null)
			{
				return new int?(Convert.ToInt32(treeDataGridViewNode_1.Parent.Cells[1].Value));
			}
			return null;
		}
		else
		{
			if (treeDataGridViewNode_1.Cells[1].Value != null)
			{
				return new int?(Convert.ToInt32(treeDataGridViewNode_1.Cells[1].Value));
			}
			return null;
		}
	}

	private int? method_6(TreeDataGridViewNode treeDataGridViewNode_1)
	{
		if (treeDataGridViewNode_1 == null)
		{
			return null;
		}
		int level = treeDataGridViewNode_1.Level;
		if (level != 3)
		{
			return null;
		}
		if (treeDataGridViewNode_1.Cells[3].Value != null)
		{
			return new int?(Convert.ToInt32(treeDataGridViewNode_1.Cells[3].Value));
		}
		return null;
	}

	private void FormTagContactAddEdit_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (base.DialogResult == DialogResult.OK)
		{
			if (string.IsNullOrEmpty(this.txtTag.Text))
			{
				MessageBox.Show("Не введено имя тэга", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				e.Cancel = true;
				return;
			}
			if (this.typeFieldContact == (FormTagContactAddEdit.eSelectTypeFieldContact.Division) && this.cmbDivision.SelectedIndex < 0)
			{
				MessageBox.Show("Не выбрано подразделение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				e.Cancel = true;
				return;
			}
			if (this.typeFieldContact == (FormTagContactAddEdit.eSelectTypeFieldContact.Contact))
			{
				if (this.cmbFIO.SelectedIndex < 0)
				{
					MessageBox.Show("Не выбран сотрудник", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					e.Cancel = true;
					return;
				}
				if (string.IsNullOrEmpty(this.txtContact.Text))
				{
					MessageBox.Show("Не введен контакт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					e.Cancel = true;
					return;
				}
			}
		}
	}

	private DataTable method_7()
	{
		DataTable dataTable = new DataTable("tR_Classifier");
		DataColumn dataColumn = dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("name", typeof(string));
		dataTable.PrimaryKey = new DataColumn[]
		{
			dataColumn
		};
		return dataTable;
	}

	

	private FormTagContactAddEdit.eActionRequest EditMode;

	private FormTagContactAddEdit.eSelectTypeFieldContact typeFieldContact;

	

    /// <summary>
    /// Режим редактирования документа
    /// eActionRequest = Enum21
    /// </summary>
    internal enum eActionRequest
    {
        Add = 0, Edit = 1, Read = 2
    }

    private enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    /// <summary>
    /// Тип полей контактных данных
    /// </summary>
    internal enum eSelectTypeFieldContact
    {
        Tag = 0,//тэг
        Division = 1,//подразделение
        Contact = 2// прочее
    }
}
