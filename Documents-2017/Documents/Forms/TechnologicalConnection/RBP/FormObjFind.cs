namespace Documents.Forms.TechnologicalConnection.RBP
{
    using ControlsLbr.DataGridViewExcelFilter;
    using Documents.DataSets;
    using Documents.Properties;
    using FormLbr;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormObjFind : FormBase
    {
        private BindingSource bindingSource_0;
        private DataGridView dataGridView_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataSetFind dataSetFind_0;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private string string_0;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripComboBox toolStripComboBox_0;
        private ToolStripTextBox toolStripTextBox_0;

        public FormObjFind()
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.string_0 = "";
            this.method_2();
        }

        public FormObjFind(int idAbn)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.string_0 = "";
            this.method_2();
            this.int_0 = idAbn;
        }

        public FormObjFind(int idAbn, int idAbnObj)
        {
            this.int_0 = -1;
            this.int_1 = -1;
            this.string_0 = "";
            this.method_2();
            this.int_0 = idAbn;
            this.int_1 = idAbnObj;
        }

        private void dataGridView_0_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.method_1();
        }

        private void dataGridView_0_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.string_0.Length > 3)
            {
                this.string_0 = "";
            }
            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.D0:
                        this.string_0 = this.string_0 + "0";
                        break;

                    case Keys.D1:
                        this.string_0 = this.string_0 + "1";
                        break;

                    case Keys.D2:
                        this.string_0 = this.string_0 + "2";
                        break;

                    case Keys.D3:
                        this.string_0 = this.string_0 + "3";
                        break;

                    case Keys.D4:
                        this.string_0 = this.string_0 + "4";
                        break;

                    case Keys.D5:
                        this.string_0 = this.string_0 + "5";
                        break;

                    case Keys.D6:
                        this.string_0 = this.string_0 + "6";
                        break;

                    case Keys.D7:
                        this.string_0 = this.string_0 + "7";
                        break;

                    case Keys.D8:
                        this.string_0 = this.string_0 + "8";
                        break;

                    case Keys.D9:
                        this.string_0 = this.string_0 + "9";
                        break;

                    case Keys.Enter:
                        this.method_1();
                        break;

                    case Keys.NumPad0:
                        this.string_0 = this.string_0 + "0";
                        break;

                    case Keys.NumPad1:
                        this.string_0 = this.string_0 + "1";
                        break;

                    case Keys.NumPad2:
                        this.string_0 = this.string_0 + "2";
                        break;

                    case Keys.NumPad3:
                        this.string_0 = this.string_0 + "3";
                        break;

                    case Keys.NumPad4:
                        this.string_0 = this.string_0 + "4";
                        break;

                    case Keys.NumPad5:
                        this.string_0 = this.string_0 + "5";
                        break;

                    case Keys.NumPad6:
                        this.string_0 = this.string_0 + "6";
                        break;

                    case Keys.NumPad7:
                        this.string_0 = this.string_0 + "7";
                        break;

                    case Keys.NumPad8:
                        this.string_0 = this.string_0 + "8";
                        break;

                    case Keys.NumPad9:
                        this.string_0 = this.string_0 + "9";
                        break;

                    default:
                        this.string_0 = "";
                        break;
                }
                if (this.string_0 != "")
                {
                    this.method_0();
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormObjFind_Load(object sender, EventArgs e)
        {
            this.toolStripComboBox_0.SelectedIndex = 0;
            base.SelectSqlData(this.dataSetFind_0, this.dataSetFind_0.vG_Find, true, " order by CodeAbonent");
            if (this.int_0 <= 0)
            {
                if (this.int_1 > 0)
                {
                    for (int i = 0; i < this.dataGridView_0.RowCount; i++)
                    {
                        if (this.dataGridView_0[8, i].FormattedValue.ToString().Contains(this.int_1.ToString()))
                        {
                            this.dataGridView_0.CurrentCell = this.dataGridView_0[1, i];
                            return;
                        }
                    }
                }
            }
            else
            {
                for (int j = 0; j < this.dataGridView_0.RowCount; j++)
                {
                    if (this.dataGridView_0[0, j].FormattedValue.ToString().Contains(this.int_0.ToString()))
                    {
                        this.dataGridView_0.CurrentCell = this.dataGridView_0[1, j];
                        return;
                    }
                }
            }
        }

        private void method_0()
        {
            for (int i = 0; i < this.dataGridView_0.RowCount; i++)
            {
                if (this.dataGridView_0[1, i].FormattedValue.ToString().Contains(this.string_0))
                {
                    this.dataGridView_0.CurrentCell = this.dataGridView_0[1, i];
                    return;
                }
            }
        }

        private void method_1()
        {
            FormJournalActRBP owner = (FormJournalActRBP) base.Owner;
            owner.ABNSELECT = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells["dgvIDAbn"].Value);
            if (this.dataGridView_0.CurrentRow.Cells["dgvIDAbnObj"].Value != DBNull.Value)
            {
                owner.OBJSELECT = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells["dgvIDAbnObj"].Value);
            }
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private void method_2()
        {
            this.icontainer_0 = new Container();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripComboBox_0 = new ToolStripComboBox();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetFind_0 = new DataSetFind();
            this.toolStrip_0.SuspendLayout();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetFind_0.BeginInit();
            base.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripComboBox_0, this.toolStripTextBox_0, this.toolStripButton_0, this.toolStripButton_1 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStrip1";
            this.toolStrip_0.Size = new Size(670, 0x19);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            object[] items = new object[] { "Наименование", "Объект" };
            this.toolStripComboBox_0.Items.AddRange(items);
            this.toolStripComboBox_0.Name = "cbxFilter";
            this.toolStripComboBox_0.Size = new Size(200, 0x19);
            this.toolStripTextBox_0.Name = "txtFilter";
            this.toolStripTextBox_0.Size = new Size(250, 0x19);
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.Filtr_my;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "btnFilter";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "toolStripButton1";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.dialog_close;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "btnDelFilter";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "toolStripButton2";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dataGridView_0.AutoGenerateColumns = false;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_1, this.dataGridViewFilterTextBoxColumn_2, this.dataGridViewTextBoxColumn_1 };
            this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridView_0.DataSource = this.bindingSource_0;
            this.dataGridView_0.Location = new Point(0, 0x1c);
            this.dataGridView_0.MultiSelect = false;
            this.dataGridView_0.Name = "dgvAbn";
            this.dataGridView_0.ReadOnly = true;
            this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_0.Size = new Size(670, 0x17f);
            this.dataGridView_0.TabIndex = 1;
            this.dataGridView_0.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView_0_CellMouseDoubleClick);
            this.dataGridView_0.KeyDown += new KeyEventHandler(this.dataGridView_0_KeyDown);
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "idAbn";
            this.dataGridViewTextBoxColumn_0.HeaderText = "idAbn";
            this.dataGridViewTextBoxColumn_0.Name = "dgvidAbn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "CodeAbonent";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Код";
            this.dataGridViewFilterTextBoxColumn_0.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_0.Width = 70;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "Name";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Потребитель";
            this.dataGridViewFilterTextBoxColumn_1.Name = "nameDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_1.Width = 250;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "ObjName";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn_2.Name = "objNameDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.Width = 300;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "idAbnObj";
            this.dataGridViewTextBoxColumn_1.HeaderText = "idAbnObj";
            this.dataGridViewTextBoxColumn_1.Name = "dgvidAbnObj";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.bindingSource_0.DataMember = "vG_Find";
            this.bindingSource_0.DataSource = this.dataSetFind_0;
            this.dataSetFind_0.DataSetName = "dsFind";
            this.dataSetFind_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(670, 0x197);
            base.Controls.Add(this.dataGridView_0);
            base.Controls.Add(this.toolStrip_0);
            base.Name = "FormObjFind";
            this.Text = "Выбор";
            base.Load += new EventHandler(this.FormObjFind_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetFind_0.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.toolStripComboBox_0.SelectedIndex;
            if (selectedIndex != 0)
            {
                if (selectedIndex != 1)
                {
                    this.dataSetFind_0.vG_Find.Clear();
                }
                else
                {
                    base.SelectSqlData(this.dataSetFind_0.vG_Find, true, " where [objname] like '%" + this.toolStripTextBox_0.Text + "%' order by codeAbonent ", false);
                }
            }
            else
            {
                base.SelectSqlData(this.dataSetFind_0.vG_Find, true, " where [name] like '%" + this.toolStripTextBox_0.Text + "%' order by codeAbonent ", false);
            }
            this.dataGridView_0.Refresh();
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            this.dataSetFind_0.vG_Find.Clear();
            base.SelectSqlData(this.dataSetFind_0, this.dataSetFind_0.vG_Find, true, " order by CodeAbonent");
            this.dataGridView_0.Refresh();
        }
    }
}

