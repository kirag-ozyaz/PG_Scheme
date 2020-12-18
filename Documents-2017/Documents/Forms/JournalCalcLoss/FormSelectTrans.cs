    using ControlsLbr.DataGridViewExcelFilter;
    using Documents.DataSets;
    using FormLbr;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;
/// <summary>
/// Выбор марки трансформатора
/// /// </summary>
namespace Documents.Forms.JournalCalcLoss
{

    public class FormSelectTrans : FormBase
    {
        private BindingSource bindingSource_0;
        private Button button_0;
        private Button button_1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private dsCalc dsCalc_0;
        private IContainer icontainer_0;
        [CompilerGenerated]
        private int int_0;
        [CompilerGenerated]
        private float? nullable_0;
        [CompilerGenerated]
        private float? nullable_1;
        [CompilerGenerated]
        private float? nullable_2;
        [CompilerGenerated]
        private float? nullable_3;
        [CompilerGenerated]
        private string string_0;
        private ToolStrip toolStrip_0;
        private ToolStripLabel toolStripLabel_0;
        private ToolStripTextBox toolStripTextBox_0;

        public FormSelectTrans()
        {
            this.method_1();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
            {
                this.method_0(this.dataGridViewExcelFilter_0.SelectedRows[0]);
                base.DialogResult = DialogResult.OK;
                base.Close();
            }
            else
            {
                MessageBox.Show("Не выбрана ни одна марка трансформатора");
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex >= 0) && (e.RowIndex >= 0))
            {
                this.method_0(this.dataGridViewExcelFilter_0.Rows[e.RowIndex]);
                base.DialogResult = DialogResult.OK;
                base.Close();
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

        private void FormSelectTrans_Load(object sender, EventArgs e)
        {
            base.SelectSqlData(this.dsCalc_0.vR_Transformer, true, "where deleted = 0 order by fullname", false);
            this.toolStripTextBox_0.Select();
            this.toolStripTextBox_0.Focus();
        }

        private void method_0(DataGridViewRow dataGridViewRow_0)
        {
            float? nullable;
            this.Id = Convert.ToInt32(dataGridViewRow_0.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
            this.MakeupTrans = dataGridViewRow_0.Cells[this.dataGridViewFilterTextBoxColumn_0.Name].Value.ToString();
            if (dataGridViewRow_0.Cells[this.dataGridViewTextBoxColumn_1.Name].Value == DBNull.Value)
            {
                nullable = null;
                this.RatedPower = nullable;
            }
            else
            {
                this.RatedPower = new float?(Convert.ToSingle(dataGridViewRow_0.Cells[this.dataGridViewTextBoxColumn_1.Name].Value) / 1000f);
            }
            if (dataGridViewRow_0.Cells[this.dataGridViewTextBoxColumn_2.Name].Value == DBNull.Value)
            {
                nullable = null;
                this.NoLoadLoss = nullable;
            }
            else
            {
                this.NoLoadLoss = new float?(Convert.ToSingle(dataGridViewRow_0.Cells[this.dataGridViewTextBoxColumn_2.Name].Value));
            }
            if (dataGridViewRow_0.Cells[this.dataGridViewTextBoxColumn_3.Name].Value == DBNull.Value)
            {
                nullable = null;
                this.ShortCircuitLoss = nullable;
            }
            else
            {
                this.ShortCircuitLoss = new float?(Convert.ToSingle(dataGridViewRow_0.Cells[this.dataGridViewTextBoxColumn_3.Name].Value));
            }
            if (dataGridViewRow_0.Cells[this.dataGridViewTextBoxColumn_4.Name].Value == DBNull.Value)
            {
                this.HightVoltage = null;
            }
            else
            {
                this.HightVoltage = new float?(Convert.ToSingle(dataGridViewRow_0.Cells[this.dataGridViewTextBoxColumn_4.Name].Value));
            }
        }

        private void method_1()
        {
            this.icontainer_0 = new Container();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripLabel_0 = new ToolStripLabel();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dsCalc_0 = new dsCalc();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.toolStrip_0.SuspendLayout();
            this.dataGridViewExcelFilter_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dsCalc_0.BeginInit();
            base.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripLabel_0, this.toolStripTextBox_0 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStrip";
            this.toolStrip_0.Size = new Size(0x1fb, 0x19);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.TabStop = true;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripLabel_0.Name = "toolStripLabel1";
            this.toolStripLabel_0.Size = new Size(0x30, 0x16);
            this.toolStripLabel_0.Text = "Фильтр";
            this.toolStripTextBox_0.Name = "txtFilter";
            this.toolStripTextBox_0.Size = new Size(300, 0x19);
            this.toolStripTextBox_0.TextChanged += new EventHandler(this.toolStripTextBox_0_TextChanged);
            this.button_0.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button_0.Location = new Point(12, 0x112);
            this.button_0.Name = "buttonOK";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 2;
            this.button_0.Text = "ОК";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_1.Location = new Point(420, 0x112);
            this.button_1.Name = "buttonCancel";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 3;
            this.button_1.Text = "Отмена";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
            this.dataGridViewExcelFilter_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.BackgroundColor = SystemColors.Control;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4 };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Location = new Point(0, 0x1c);
            this.dataGridViewExcelFilter_0.Name = "dgvTrans";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(0x1fb, 240);
            this.dataGridViewExcelFilter_0.TabIndex = 1;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.bindingSource_0.DataMember = "vR_Transformer";
            this.bindingSource_0.DataSource = this.dsCalc_0;
            this.dsCalc_0.DataSetName = "dsCalc";
            this.dsCalc_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "idDgvColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewFilterTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "FullName";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Марка трансформатора";
            this.dataGridViewFilterTextBoxColumn_0.Name = "fullNameDgvColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "Power";
            this.dataGridViewTextBoxColumn_1.HeaderText = "Power";
            this.dataGridViewTextBoxColumn_1.Name = "powerDgvColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "NoLoadLoss";
            this.dataGridViewTextBoxColumn_2.HeaderText = "NoLoadLoss";
            this.dataGridViewTextBoxColumn_2.Name = "noLoadLossDgvColumn";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.Visible = false;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "ShortCircuitLoss";
            this.dataGridViewTextBoxColumn_3.HeaderText = "ShortCircuitLoss";
            this.dataGridViewTextBoxColumn_3.Name = "shortCircuitLossDgvColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.Visible = false;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "HighVoltage";
            this.dataGridViewTextBoxColumn_4.HeaderText = "HighVoltage";
            this.dataGridViewTextBoxColumn_4.Name = "highVoltageDgvVoltage";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Visible = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x1fb, 0x135);
            base.Controls.Add(this.dataGridViewExcelFilter_0);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.toolStrip_0);
            base.Name = "FormSelectTrans";
            this.Text = "Выбор марки трансформатора";
            base.Load += new EventHandler(this.FormSelectTrans_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.dataGridViewExcelFilter_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dsCalc_0.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripTextBox_0_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.toolStripTextBox_0.Text))
            {
                this.bindingSource_0.Filter = "";
            }
            else
            {
                this.bindingSource_0.Filter = "fullName like '%" + this.toolStripTextBox_0.Text + "%'";
            }
        }

        public float? HightVoltage
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_3;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_3 = value;
            }
        }

        public int Id
        {
            [CompilerGenerated]
            get
            {
                return this.int_0;
            }
            [CompilerGenerated]
            set
            {
                this.int_0 = value;
            }
        }

        public string MakeupTrans
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            set
            {
                this.string_0 = value;
            }
        }

        public float? NoLoadLoss
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_1;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_1 = value;
            }
        }

        public float? RatedPower
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_0;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_0 = value;
            }
        }

        public float? ShortCircuitLoss
        {
            [CompilerGenerated]
            get
            {
                return this.nullable_2;
            }
            [CompilerGenerated]
            set
            {
                this.nullable_2 = value;
            }
        }
    }
}

