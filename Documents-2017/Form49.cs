using ControlsLbr.DataGridViewExcelFilter;
using Documents.Forms.JournalExcavation;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class Form49 : FormBase
{
    private BindingSource bindingSource_0;
    private Button button_0;
    private Button button_1;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
    private DataSetExcavation dataSetExcavation_0;
    private IContainer icontainer_0;
    private int int_0;
    private int int_1;
    [CompilerGenerated]
    private int? nullable_0;
    private RadioButton radioButton_0;
    private RadioButton radioButton_1;
    [CompilerGenerated]
    private string string_0;
    private TextBox textBox_0;
    private TextBox textBox_1;

    public Form49()
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.method_6();
    }

    public Form49(int int_2, int int_3)
    {
        this.int_0 = -1;
        this.int_1 = -1;
        this.method_6();
        this.int_0 = int_3;
        this.int_1 = int_2;
    }

    private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        base.DialogResult = DialogResult.OK;
        base.Close();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.icontainer_0 != null))
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    private void Form49_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (base.DialogResult == DialogResult.OK)
        {
            string str;
            if (this.radioButton_0.Checked)
            {
                if (this.dataGridViewExcelFilter_0.CurrentRow == null)
                {
                    MessageBox.Show("Не выбрана кабельная линия");
                    e.Cancel = true;
                }
                else
                {
                    int? nullable;
                    if (this.int_1 != -1)
                    {
                        if (this.int_0 != -1)
                        {
                            this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["idExcavation"] = this.int_0;
                            this.method_3(str = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value.ToString());
                            this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["NameKL"] = str;
                            nullable = new int?(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value));
                            this.method_1(nullable);
                            this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["idKL"] = nullable;
                            this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0].EndEdit();
                            base.UpdateSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSchmObj);
                        }
                        else
                        {
                            this.method_3(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value.ToString());
                            this.method_1(new int?(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value)));
                        }
                    }
                    else
                    {
                        DataRow row = this.dataSetExcavation_0.tJ_ExcavationSchmObj.NewRow();
                        row["idExcavation"] = this.int_0;
                        this.method_3(str = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value.ToString());
                        row["NameKL"] = str;
                        nullable = new int?(Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value));
                        this.method_1(nullable);
                        row["idKL"] = nullable;
                        this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows.Add(row);
                        if (this.int_0 != -1)
                        {
                            this.int_1 = base.InsertSqlDataOneRow(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSchmObj);
                        }
                    }
                }
            }
            else if (string.IsNullOrEmpty(this.textBox_1.Text))
            {
                MessageBox.Show("Не введено имя кабельной линии");
                e.Cancel = true;
            }
            else if (this.int_1 == -1)
            {
                DataRow row2 = this.dataSetExcavation_0.tJ_ExcavationSchmObj.NewRow();
                row2["idExcavation"] = this.int_0;
                this.method_3(str = this.textBox_1.Text);
                row2["NameKL"] = str;
                this.method_1(null);
                this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows.Add(row2);
                if (this.int_0 != -1)
                {
                    this.int_1 = base.InsertSqlDataOneRow(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSchmObj);
                }
            }
            else
            {
                this.method_1(null);
                if (this.int_0 != -1)
                {
                    this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["idExcavation"] = this.int_0;
                    this.method_3(str = this.textBox_1.Text);
                    this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["NameKL"] = str;
                    this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["idKL"] = DBNull.Value;
                    this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0].EndEdit();
                    base.UpdateSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSchmObj);
                }
                else
                {
                    this.method_3(this.textBox_1.Text);
                }
            }
        }
    }

    private void Form49_Load(object sender, EventArgs e)
    {
        DataTable table = new DataTable("tSChm_ObjList");
        table.Columns.Add("id", typeof(int));
        table.Columns.Add("name", typeof(string));
        base.SelectSqlData(table, true, " where typeCodeid = 546 and deleted = 0 order by name", false);
        this.bindingSource_0.DataSource = table;
        this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
        if (this.int_0 != -1)
        {
            if (this.int_1 != -1)
            {
                base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.tJ_ExcavationSchmObj, true, "where id = " + this.int_1);
                base.SelectSqlData(this.dataSetExcavation_0, this.dataSetExcavation_0.vJ_ExcavationSchmObj, true, "where id = " + this.int_1);
                if (this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows.Count > 0)
                {
                    if (this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["idKL"] == DBNull.Value)
                    {
                        this.radioButton_1.Checked = true;
                        this.textBox_1.Text = this.dataSetExcavation_0.tJ_ExcavationSchmObj.Rows[0]["nameKL"].ToString();
                    }
                    else
                    {
                        this.textBox_0.Text = this.dataSetExcavation_0.vJ_ExcavationSchmObj.Rows[0]["name"].ToString();
                    }
                }
            }
        }
        else if (this.method_0().HasValue)
        {
            this.textBox_0.Text = this.method_2();
        }
        else if (!string.IsNullOrEmpty(this.method_2()))
        {
            this.radioButton_1.Checked = true;
            this.textBox_1.Text = this.method_2();
        }
    }

    [CompilerGenerated]
    internal int? method_0()
    {
        return this.nullable_0;
    }

    [CompilerGenerated]
    internal void method_1(int? nullable_1)
    {
        this.nullable_0 = nullable_1;
    }

    [CompilerGenerated]
    internal string method_2()
    {
        return this.string_0;
    }

    [CompilerGenerated]
    internal void method_3(string string_1)
    {
        this.string_0 = string_1;
    }

    internal int method_4()
    {
        return this.int_1;
    }

    internal void method_5(int int_2)
    {
        this.int_1 = int_2;
    }

    private void method_6()
    {
        this.icontainer_0 = new Container();
        this.radioButton_0 = new RadioButton();
        this.textBox_0 = new TextBox();
        this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
        this.radioButton_1 = new RadioButton();
        this.textBox_1 = new TextBox();
        this.button_0 = new Button();
        this.button_1 = new Button();
        this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
        this.bindingSource_0 = new BindingSource(this.icontainer_0);
        this.dataSetExcavation_0 = new DataSetExcavation();
        this.dataGridViewExcelFilter_0.BeginInit();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        this.dataSetExcavation_0.BeginInit();
        base.SuspendLayout();
        this.radioButton_0.AutoSize = true;
        this.radioButton_0.Checked = true;
        this.radioButton_0.Location = new Point(12, 12);
        this.radioButton_0.Name = "radioButtonExistKL";
        this.radioButton_0.Size = new Size(0x54, 0x11);
        this.radioButton_0.TabIndex = 0;
        this.radioButton_0.TabStop = true;
        this.radioButton_0.Text = "КЛ из базы";
        this.radioButton_0.UseVisualStyleBackColor = true;
        this.radioButton_0.CheckedChanged += new EventHandler(this.radioButton_0_CheckedChanged);
        this.textBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        this.textBox_0.Location = new Point(0x67, 9);
        this.textBox_0.Name = "textBoxFilter";
        this.textBox_0.Size = new Size(0x13e, 20);
        this.textBox_0.TabIndex = 1;
        this.textBox_0.TextChanged += new EventHandler(this.textBox_0_TextChanged);
        this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
        this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
        this.dataGridViewExcelFilter_0.AllowUserToResizeColumns = false;
        this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
        this.dataGridViewExcelFilter_0.set_AllowUserToVisibleColumns(false);
        this.dataGridViewExcelFilter_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1 };
        this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
        this.dataGridViewExcelFilter_0.Location = new Point(1, 0x23);
        this.dataGridViewExcelFilter_0.MultiSelect = false;
        this.dataGridViewExcelFilter_0.Name = "dgvKL";
        this.dataGridViewExcelFilter_0.ReadOnly = true;
        this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
        this.dataGridViewExcelFilter_0.RowHeadersWidth = 0x15;
        this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridViewExcelFilter_0.Size = new Size(430, 0xd1);
        this.dataGridViewExcelFilter_0.TabIndex = 2;
        this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
        this.radioButton_1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.radioButton_1.AutoSize = true;
        this.radioButton_1.Location = new Point(12, 0xfd);
        this.radioButton_1.Name = "radioButtonNewName";
        this.radioButton_1.Size = new Size(0x72, 0x11);
        this.radioButton_1.TabIndex = 3;
        this.radioButton_1.TabStop = true;
        this.radioButton_1.Text = "Собственное имя";
        this.radioButton_1.UseVisualStyleBackColor = true;
        this.textBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
        this.textBox_1.Enabled = false;
        this.textBox_1.Location = new Point(0x84, 250);
        this.textBox_1.Name = "textBoxName";
        this.textBox_1.Size = new Size(0x121, 20);
        this.textBox_1.TabIndex = 4;
        this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.button_0.DialogResult = DialogResult.OK;
        this.button_0.Location = new Point(12, 0x114);
        this.button_0.Name = "buttonOK";
        this.button_0.Size = new Size(0x4b, 0x17);
        this.button_0.TabIndex = 5;
        this.button_0.Text = "ОК";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Location = new Point(0x158, 0x114);
        this.button_1.Name = "buttonCancel";
        this.button_1.Size = new Size(0x4b, 0x17);
        this.button_1.TabIndex = 6;
        this.button_1.Text = "Отмена";
        this.button_1.UseVisualStyleBackColor = true;
        this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
        this.dataGridViewTextBoxColumn_0.HeaderText = "id";
        this.dataGridViewTextBoxColumn_0.Name = "idSgvColumn";
        this.dataGridViewTextBoxColumn_0.ReadOnly = true;
        this.dataGridViewTextBoxColumn_0.Visible = false;
        this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_1.DataPropertyName = "name";
        this.dataGridViewTextBoxColumn_1.HeaderText = "Имя КЛ";
        this.dataGridViewTextBoxColumn_1.Name = "nameDgvColumn";
        this.dataGridViewTextBoxColumn_1.ReadOnly = true;
        this.dataSetExcavation_0.DataSetName = "DataSetExcavation";
        this.dataSetExcavation_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        base.AcceptButton = this.button_0;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.button_1;
        base.ClientSize = new Size(0x1af, 0x137);
        base.Controls.Add(this.button_1);
        base.Controls.Add(this.button_0);
        base.Controls.Add(this.textBox_1);
        base.Controls.Add(this.radioButton_1);
        base.Controls.Add(this.dataGridViewExcelFilter_0);
        base.Controls.Add(this.textBox_0);
        base.Controls.Add(this.radioButton_0);
        base.Name = "FormFindKLExcavation";
        this.Text = "Кабельные линии";
        base.FormClosing += new FormClosingEventHandler(this.Form49_FormClosing);
        base.Load += new EventHandler(this.Form49_Load);
        this.dataGridViewExcelFilter_0.EndInit();
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        this.dataSetExcavation_0.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void radioButton_0_CheckedChanged(object sender, EventArgs e)
    {
        if (this.radioButton_0.Checked)
        {
            this.textBox_0.Enabled = true;
            this.dataGridViewExcelFilter_0.Enabled = true;
            this.textBox_1.Enabled = false;
            if (string.IsNullOrEmpty(this.textBox_0.Text))
            {
                this.textBox_0.Text = this.textBox_1.Text;
            }
        }
        else
        {
            this.textBox_0.Enabled = false;
            this.dataGridViewExcelFilter_0.Enabled = false;
            this.textBox_1.Enabled = true;
            if (string.IsNullOrEmpty(this.textBox_1.Text))
            {
                this.textBox_1.Text = this.textBox_0.Text;
            }
        }
    }

    private void textBox_0_TextChanged(object sender, EventArgs e)
    {
        this.bindingSource_0.Filter = "Name like '%" + this.textBox_0.Text + "%'";
    }
}

