using ControlsLbr;
using DataSql;
using FormLbr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class FormTagContactAddEdit : FormBase
{
    private Button buttonOK;
    private Button buttonCancel;
    private ComboBox cmbDivision;
    private ComboBox cmbFIO;
    private EditMode editMode;
    private SelectTypeFieldContact typeFieldContact;
    private IContainer components = null;
    private Label labelTag;
    private Label labelDivision;
    private Label labelFIO;
    private Label labelContact;
    private Panel panel_0;
    private TextBox txtTag;
    private TextBox txtContact;
    private TreeDataGridViewNode treeDataGridViewNode_0;

    internal FormTagContactAddEdit(EditMode enum15_1 = 0, SelectTypeFieldContact enum16_1 = 0, TreeDataGridViewNode treeDataGridViewNode_1 = null)
    {
        this.InitializeComponent();
        this.editMode = enum15_1;
        this.Text = (enum15_1 == EditMode.Add) ? "Добавление" : "Редактирование";
        this.typeFieldContact = enum16_1;
        this.treeDataGridViewNode_0 = treeDataGridViewNode_1;
        switch (enum16_1)
        {
            case SelectTypeFieldContact.Tag:
                this.Text = this.Text + " тэга";
                this.cmbDivision.Visible = false;
                this.labelDivision.Visible = false;
                this.panel_0.Visible = false;
                base.Height -= 0x72;
                return;

            case SelectTypeFieldContact.Division:
                this.Text = this.Text + " подразделения";
                this.panel_0.Visible = false;
                base.Height -= 0x4f;
                this.txtTag.ReadOnly = true;
                this.txtTag.BackColor = SystemColors.Window;
                return;

            case SelectTypeFieldContact.Contact:
                this.txtTag.ReadOnly = true;
                this.txtTag.BackColor = SystemColors.Window;
                this.cmbDivision.Enabled = false;
                return;
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void FormTagContactAddEdit_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            if (string.IsNullOrEmpty(this.txtTag.Text))
            {
                MessageBox.Show("Не введено имя тэга", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                e.Cancel = true;
            }
            else if ((this.typeFieldContact == SelectTypeFieldContact.Division) && (this.cmbDivision.SelectedIndex < 0))
            {
                MessageBox.Show("Не выбрано подразделение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                e.Cancel = true;
            }
            else if (this.typeFieldContact == SelectTypeFieldContact.Contact)
            {
                if (this.cmbFIO.SelectedIndex < 0)
                {
                    MessageBox.Show("Не выбран сотрудник", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    e.Cancel = true;
                }
                else if (string.IsNullOrEmpty(this.txtContact.Text))
                {
                    MessageBox.Show("Не введен контакт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    e.Cancel = true;
                }
            }
        }
    }

    private void FormTagContactAddEdit_Load(object sender, EventArgs e)
    {
        this.txtTag.Text = this.method_6(this.treeDataGridViewNode_0);
        DataTable table = this.method_9();
        base.SelectSqlData(table, true, " where ParentKey = ';ReportDaily;DivisionApply;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
        object[] values = new object[] { "-1", "Производственная лаборатория" };
        table.Rows.Add(values);
        List<int> list = new List<int>();
        TreeDataGridViewNode node = null;
        if (this.treeDataGridViewNode_0 != null)
        {
            switch (this.treeDataGridViewNode_0.Level)
            {
                case 1:
                    node = this.treeDataGridViewNode_0;
                    break;

                case 2:
                    node = this.treeDataGridViewNode_0.Parent;
                    break;

                case 3:
                    node = this.treeDataGridViewNode_0.Parent.Parent;
                    break;
            }
        }
        if (node != null)
        {
            foreach (TreeDataGridViewNode node2 in node.Nodes)
            {
                if (((node2.Cells[1].Value != null) && (((this.editMode != EditMode.Edit) || (this.typeFieldContact != SelectTypeFieldContact.Division)) || (this.treeDataGridViewNode_0.Cells[1].Value != node2.Cells[1].Value))) && (this.typeFieldContact != SelectTypeFieldContact.Contact))
                {
                    list.Add(Convert.ToInt32(node2.Cells[1].Value));
                }
            }
        }
        foreach (int num2 in list)
        {
            DataRow row = table.Rows.Find(num2);
            if (row != null)
            {
                table.Rows.Remove(row);
            }
        }
        this.cmbDivision.DisplayMember = "name";
        this.cmbDivision.ValueMember = "id";
        this.cmbDivision.DataSource = table;
        int? nullable = this.method_7(this.treeDataGridViewNode_0);
        if (nullable.HasValue)
        {
            this.cmbDivision.SelectedValue = nullable;
        }
        else
        {
            this.cmbDivision.SelectedIndex = -1;
        }
        DataTable table2 = new SqlDataCommand(this.SqlSettings).SelectSqlData("select id, f + isnull(' ' + i, '') + isnull(' ' + o, '') as fio from tr_worker where dateEnd is null order by f,i,o");
        this.cmbFIO.DisplayMember = "FIO";
        this.cmbFIO.ValueMember = "ID";
        this.cmbFIO.DataSource = table2;
        int? nullable2 = this.method_8(this.treeDataGridViewNode_0);
        if (nullable2.HasValue)
        {
            this.cmbFIO.SelectedValue = nullable2;
        }
        else
        {
            this.cmbFIO.SelectedIndex = -1;
        }
        if (((this.treeDataGridViewNode_0 != null) && (this.treeDataGridViewNode_0.Level == 3)) && (this.treeDataGridViewNode_0.Cells[4].Value != null))
        {
            this.txtContact.Text = this.treeDataGridViewNode_0.Cells[4].Value.ToString();
        }
    }

    internal string method_0()
    {
        return this.txtTag.Text;
    }

    internal string method_1()
    {
        if (this.cmbDivision.SelectedItem != null)
        {
            return ((DataRowView) this.cmbDivision.SelectedItem).Row["Name"].ToString();
        }
        return null;
    }

    private void InitializeComponent()
    {
        this.labelTag = new Label();
        this.txtTag = new TextBox();
        this.labelDivision = new Label();
        this.cmbDivision = new ComboBox();
        this.labelFIO = new Label();
        this.cmbFIO = new ComboBox();
        this.labelContact = new Label();
        this.txtContact = new TextBox();
        this.buttonOK = new Button();
        this.buttonCancel = new Button();
        this.panel_0 = new Panel();
        this.panel_0.SuspendLayout();
        base.SuspendLayout();
        this.labelTag.AutoSize = true;
        this.labelTag.Location = new Point(12, 9);
        this.labelTag.Name = "labelTag";
        this.labelTag.Size = new Size(0x36, 13);
        this.labelTag.TabIndex = 0;
        this.labelTag.Text = "Имя тэга";
        this.txtTag.Location = new Point(12, 0x19);
        this.txtTag.Name = "txtTag";
        this.txtTag.Size = new Size(0x18c, 20);
        this.txtTag.TabIndex = 1;
        this.labelDivision.AutoSize = true;
        this.labelDivision.Location = new Point(12, 0x30);
        this.labelDivision.Name = "labelDivision";
        this.labelDivision.Size = new Size(0x57, 13);
        this.labelDivision.TabIndex = 2;
        this.labelDivision.Text = "Подразделение";
        this.cmbDivision.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.cmbDivision.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.cmbDivision.FormattingEnabled = true;
        this.cmbDivision.Location = new Point(12, 0x40);
        this.cmbDivision.Name = "cmbDivision";
        this.cmbDivision.Size = new Size(0x18c, 0x15);
        this.cmbDivision.TabIndex = 3;
        this.labelFIO.AutoSize = true;
        this.labelFIO.Location = new Point(13, 0);
        this.labelFIO.Name = "labelFIO";
        this.labelFIO.Size = new Size(0x22, 13);
        this.labelFIO.TabIndex = 4;
        this.labelFIO.Text = "ФИО";
        this.cmbFIO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.cmbFIO.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.cmbFIO.FormattingEnabled = true;
        this.cmbFIO.Location = new Point(12, 0x10);
        this.cmbFIO.Name = "cmbFIO";
        this.cmbFIO.Size = new Size(0x18c, 0x15);
        this.cmbFIO.TabIndex = 5;
        this.labelContact.AutoSize = true;
        this.labelContact.Location = new Point(13, 40);
        this.labelContact.Name = "labelContact";
        this.labelContact.Size = new Size(0x30, 13);
        this.labelContact.TabIndex = 6;
        this.labelContact.Text = "Контакт";
        this.txtContact.Location = new Point(13, 0x38);
        this.txtContact.Name = "txtContact";
        this.txtContact.Size = new Size(0x18c, 20);
        this.txtContact.TabIndex = 7;
        this.buttonOK.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.buttonOK.DialogResult = DialogResult.OK;
        this.buttonOK.Location = new Point(12, 170);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new Size(0x4b, 0x17);
        this.buttonOK.TabIndex = 8;
        this.buttonOK.Text = "ОК";
        this.buttonOK.UseVisualStyleBackColor = true;
        this.buttonCancel.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.buttonCancel.DialogResult = DialogResult.Cancel;
        this.buttonCancel.Location = new Point(0x14d, 170);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new Size(0x4b, 0x17);
        this.buttonCancel.TabIndex = 9;
        this.buttonCancel.Text = "Отмена";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.panel_0.AutoSize = true;
        this.panel_0.Controls.Add(this.labelFIO);
        this.panel_0.Controls.Add(this.cmbFIO);
        this.panel_0.Controls.Add(this.labelContact);
        this.panel_0.Controls.Add(this.txtContact);
        this.panel_0.Location = new Point(0, 0x58);
        this.panel_0.Name = "panel1";
        this.panel_0.Size = new Size(0x19c, 0x4f);
        this.panel_0.TabIndex = 10;
        base.AcceptButton = this.buttonOK;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.buttonCancel;
        base.ClientSize = new Size(0x19d, 200);
        base.Controls.Add(this.panel_0);
        base.Controls.Add(this.buttonCancel);
        base.Controls.Add(this.buttonOK);
        base.Controls.Add(this.cmbDivision);
        base.Controls.Add(this.labelDivision);
        base.Controls.Add(this.txtTag);
        base.Controls.Add(this.labelTag);
        base.Name = "FormTagContactAddEdit";
        this.Text = "FormTagContactAddEdit";
        base.FormClosing += new FormClosingEventHandler(this.FormTagContactAddEdit_FormClosing);
        base.Load += new EventHandler(this.FormTagContactAddEdit_Load);
        this.panel_0.ResumeLayout(false);
        this.panel_0.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    internal object method_2()
    {
        return this.cmbDivision.SelectedValue;
    }

    internal string method_3()
    {
        if (this.cmbFIO.SelectedItem != null)
        {
            return ((DataRowView) this.cmbFIO.SelectedItem).Row["FIO"].ToString();
        }
        return null;
    }

    internal object method_4()
    {
        return this.cmbFIO.SelectedValue;
    }

    internal string method_5()
    {
        return this.txtContact.Text;
    }

    private string method_6(TreeDataGridViewNode treeDataGridViewNode_1)
    {
        if (treeDataGridViewNode_1 != null)
        {
            switch (treeDataGridViewNode_1.Level)
            {
                case 1:
                    return treeDataGridViewNode_1.Cells[0].Value.ToString();

                case 2:
                    return treeDataGridViewNode_1.Parent.Cells[0].Value.ToString();

                case 3:
                    return treeDataGridViewNode_1.Parent.Parent.Cells[0].Value.ToString();
            }
        }
        return null;
    }

    private int? method_7(TreeDataGridViewNode treeDataGridViewNode_1)
    {
        if (treeDataGridViewNode_1 != null)
        {
            int num = treeDataGridViewNode_1.Level;
            if (num == 2)
            {
                if (treeDataGridViewNode_1.Cells[1].Value != null)
                {
                    return new int?(Convert.ToInt32(treeDataGridViewNode_1.Cells[1].Value));
                }
                return null;
            }
            if ((num == 3) && (treeDataGridViewNode_1.Parent.Cells[1].Value != null))
            {
                return new int?(Convert.ToInt32(treeDataGridViewNode_1.Parent.Cells[1].Value));
            }
        }
        return null;
    }

    private int? method_8(TreeDataGridViewNode treeDataGridViewNode_1)
    {
        if (treeDataGridViewNode_1 != null)
        {
            if (treeDataGridViewNode_1.Level != 3)
            {
                return null;
            }
            if (treeDataGridViewNode_1.Cells[3].Value != null)
            {
                return new int?(Convert.ToInt32(treeDataGridViewNode_1.Cells[3].Value));
            }
        }
        return null;
    }

    private DataTable method_9()
    {
        DataTable table = new DataTable("tR_Classifier");
        DataColumn column = table.Columns.Add("id", typeof(int));
        table.Columns.Add("name", typeof(string));
        table.PrimaryKey = new DataColumn[] { column };
        return table;
    }

    internal enum EditMode //EditMode
    {
        Add, //ADD
        Edit //EDIT
    }
    /// <summary>
    /// Тип полей контактных данных
    /// </summary>
    internal enum SelectTypeFieldContact
    {
        Tag, // TagAdd
        Division, // DivisionAdd
        Contact // ContactAdd
    }
}

