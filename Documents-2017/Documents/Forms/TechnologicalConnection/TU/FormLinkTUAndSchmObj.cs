namespace Documents.Forms.TechnologicalConnection.TU
{
    using Constants;
    using ControlsLbr;
    using Documents.Forms.TechnologicalConnection;
    using FormLbr;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormLinkTUAndSchmObj : FormBase
    {
        private Button button_0;
        private Button button_1;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private ComboBox comboBox_2;
        private ComboBox comboBox_3;
        private ComboBox comboBox_4;
        private ComboBox comboBox_5;
        private ComboBox comboBox_6;
        private DataGridViewRow dataGridViewRow_0;
        private IContainer icontainer_0;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private NullableNumericUpDown nullableNumericUpDown_0;
        private TextBox textBox_0;

        public FormLinkTUAndSchmObj()
        {
            this.method_4();
        }

        public FormLinkTUAndSchmObj(DataGridViewRow dataGridViewRow_1)
        {
            this.method_4();
            this.dataGridViewRow_0 = dataGridViewRow_1;
        }

        private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((this.comboBox_0.SelectedIndex != -1) && (this.comboBox_0.SelectedValue != null))
            {
                int num = Convert.ToInt32(this.comboBox_0.SelectedValue);
                DataTable table = this.method_0();
                string str = "";
                foreach (SchmTypeBus bus in Enum.GetValues(typeof(SchmTypeBus)))
                {
                    if (string.IsNullOrEmpty(str))
                    {
                        int num2 = bus;
                        str = num2.ToString();
                    }
                    else
                    {
                        str = str + "," + ((int) bus).ToString();
                    }
                }
                base.SelectSqlData(table, true, "where idParent = " + num.ToString() + " and typeCodeId in (" + str + ") and deleted = 0 order by typeCodeSocr, name", false);
                this.comboBox_1.SelectedIndexChanged -= new EventHandler(this.comboBox_1_SelectedIndexChanged);
                this.comboBox_1.DataSource = table;
                this.comboBox_1.DisplayMember = "fullNameBus";
                this.comboBox_1.ValueMember = "id";
                this.comboBox_1.SelectedIndexChanged += new EventHandler(this.comboBox_1_SelectedIndexChanged);
                this.comboBox_1.SelectedIndex = -1;
            }
            else
            {
                this.comboBox_1.SelectedIndexChanged -= new EventHandler(this.comboBox_1_SelectedIndexChanged);
                this.comboBox_1.DataSource = null;
                this.comboBox_1.Items.Clear();
            }
        }

        private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((this.comboBox_1.SelectedIndex != -1) && (this.comboBox_1.SelectedValue != null))
            {
                string str = this.comboBox_1.SelectedValue.ToString();
                DataTable table = new DataTable("vSchm_TreeCellLine");
                table.Columns.Add("id", typeof(int));
                table.Columns.Add("FullName", typeof(string));
                this.comboBox_2.DataSource = table;
                this.comboBox_2.DisplayMember = "FullName";
                this.comboBox_2.ValueMember = "id";
                base.SelectSqlData(table, true, " where ParentLink = " + str + " order by fullname", false);
                this.comboBox_2.SelectedIndex = -1;
            }
            else
            {
                this.comboBox_2.DataSource = null;
                this.comboBox_2.Items.Clear();
            }
        }

        private void comboBox_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((this.comboBox_4.SelectedIndex != -1) && (this.comboBox_4.SelectedValue != null))
            {
                string str = this.comboBox_4.SelectedValue.ToString();
                DataTable table = new DataTable("vSchm_TreeCellLine");
                table.Columns.Add("id", typeof(int));
                table.Columns.Add("FullName", typeof(string));
                this.comboBox_3.DataSource = table;
                this.comboBox_3.DisplayMember = "FullName";
                this.comboBox_3.ValueMember = "id";
                base.SelectSqlData(table, true, " where ParentLink = " + str + " order by fullname", false);
                this.comboBox_3.SelectedIndex = -1;
            }
            else
            {
                this.comboBox_3.DataSource = null;
                this.comboBox_3.Items.Clear();
            }
        }

        private void comboBox_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((this.comboBox_5.SelectedIndex != -1) && (this.comboBox_5.SelectedValue != null))
            {
                int num = Convert.ToInt32(this.comboBox_5.SelectedValue);
                DataTable table = this.method_0();
                string str = "";
                foreach (SchmTypeBus bus in Enum.GetValues(typeof(SchmTypeBus)))
                {
                    if (string.IsNullOrEmpty(str))
                    {
                        int num2 = bus;
                        str = num2.ToString();
                    }
                    else
                    {
                        str = str + "," + ((int) bus).ToString();
                    }
                }
                base.SelectSqlData(table, true, "where idParent = " + num.ToString() + " and typeCodeId in (" + str + ") and deleted = 0 order by typeCodeSocr, name", false);
                this.comboBox_4.SelectedIndexChanged -= new EventHandler(this.comboBox_4_SelectedIndexChanged);
                this.comboBox_4.DataSource = table;
                this.comboBox_4.DisplayMember = "fullNameBus";
                this.comboBox_4.ValueMember = "id";
                this.comboBox_4.SelectedIndexChanged += new EventHandler(this.comboBox_4_SelectedIndexChanged);
                this.comboBox_4.SelectedIndex = -1;
            }
            else
            {
                this.comboBox_4.SelectedIndexChanged -= new EventHandler(this.comboBox_4_SelectedIndexChanged);
                this.comboBox_4.DataSource = null;
                this.comboBox_4.Items.Clear();
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

        private void FormLinkTUAndSchmObj_Load(object sender, EventArgs e)
        {
            this.nullableNumericUpDown_0.set_Value(null);
            this.method_1();
            this.method_2();
            this.method_3();
            if (this.dataGridViewRow_0 != null)
            {
                if ((this.dataGridViewRow_0.Cells["idSubPointColumn"].Value != null) && !string.IsNullOrEmpty(this.dataGridViewRow_0.Cells["idSubPointColumn"].Value.ToString()))
                {
                    this.comboBox_0.SelectedValue = Convert.ToInt32(this.dataGridViewRow_0.Cells["idSubPointColumn"].Value);
                }
                if ((this.dataGridViewRow_0.Cells["idBusPointColumn"].Value != null) && !string.IsNullOrEmpty(this.dataGridViewRow_0.Cells["idBusPointColumn"].Value.ToString()))
                {
                    this.comboBox_1.SelectedValue = Convert.ToInt32(this.dataGridViewRow_0.Cells["idBusPointColumn"].Value);
                }
                if ((this.dataGridViewRow_0.Cells["idCEllPointColumn"].Value != null) && !string.IsNullOrEmpty(this.dataGridViewRow_0.Cells["idCellPointColumn"].Value.ToString()))
                {
                    this.comboBox_2.SelectedValue = Convert.ToInt32(this.dataGridViewRow_0.Cells["idCellPointColumn"].Value);
                }
                if ((this.dataGridViewRow_0.Cells["idSubCPColumn"].Value != null) && !string.IsNullOrEmpty(this.dataGridViewRow_0.Cells["idSubCPColumn"].Value.ToString()))
                {
                    this.comboBox_5.SelectedValue = Convert.ToInt32(this.dataGridViewRow_0.Cells["idSubCPColumn"].Value);
                }
                if ((this.dataGridViewRow_0.Cells["idBusCPColumn"].Value != null) && !string.IsNullOrEmpty(this.dataGridViewRow_0.Cells["idBusCPColumn"].Value.ToString()))
                {
                    this.comboBox_4.SelectedValue = Convert.ToInt32(this.dataGridViewRow_0.Cells["idBusCPColumn"].Value);
                }
                if ((this.dataGridViewRow_0.Cells["idCellCPColumn"].Value != null) && !string.IsNullOrEmpty(this.dataGridViewRow_0.Cells["idCellCPColumn"].Value.ToString()))
                {
                    this.comboBox_3.SelectedValue = Convert.ToInt32(this.dataGridViewRow_0.Cells["idCellCPColumn"].Value);
                }
                if ((this.dataGridViewRow_0.Cells["voltageLevelDgvColumn"].Value != null) && !string.IsNullOrEmpty(this.dataGridViewRow_0.Cells["voltageLevelDgvColumn"].Value.ToString()))
                {
                    this.comboBox_6.SelectedValue = Convert.ToInt32(this.dataGridViewRow_0.Cells["voltageLevelDgvColumn"].Value);
                }
                if ((this.dataGridViewRow_0.Cells["powerSumDgvColumn"].Value != null) && !string.IsNullOrEmpty(this.dataGridViewRow_0.Cells["powerSumDgvColumn"].Value.ToString()))
                {
                    this.nullableNumericUpDown_0.set_Value(new decimal?(Convert.ToDecimal(this.dataGridViewRow_0.Cells["powerSumDgvColumn"].Value)));
                }
                if ((this.dataGridViewRow_0.DataGridView.Columns.Contains("descriptionDgvColumn") && (this.dataGridViewRow_0.Cells["descriptionDgvColumn"].Value != null)) && !string.IsNullOrEmpty(this.dataGridViewRow_0.Cells["descriptionDgvColumn"].Value.ToString()))
                {
                    this.textBox_0.Text = this.dataGridViewRow_0.Cells["descriptionDgvColumn"].Value.ToString();
                }
            }
        }

        private DataTable method_0()
        {
            DataTable table1 = new DataTable("vSchm_ObjList");
            table1.Columns.Add("id", typeof(int));
            table1.Columns.Add("name", typeof(string));
            table1.Columns.Add("typeCodeSocr", typeof(string));
            DataColumn column = new DataColumn("fullNameSub", typeof(string)) {
                Expression = "typeCodeSocr + '-' + name"
            };
            table1.Columns.Add(column);
            column = new DataColumn("fullNameBus", typeof(string)) {
                Expression = "typeCodeSocr + ' ' + name"
            };
            table1.Columns.Add(column);
            return table1;
        }

        private void method_1()
        {
            DataTable table = this.method_0();
            string str = "";
            foreach (SchmTypeSubstation substation in Enum.GetValues(typeof(SchmTypeSubstation)))
            {
                if (substation != 0x218)
                {
                    if (string.IsNullOrEmpty(str))
                    {
                        int num = substation;
                        str = num.ToString();
                    }
                    else
                    {
                        str = str + "," + ((int) substation).ToString();
                    }
                }
            }
            base.SelectSqlData(table, true, "where typeCodeId in (" + str + ") and deleted = 0 order by typeCodeSocr, name", false);
            this.comboBox_0.SelectedIndexChanged -= new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.comboBox_0.DataSource = table;
            this.comboBox_0.DisplayMember = "fullNameSub";
            this.comboBox_0.ValueMember = "id";
            this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.comboBox_0.SelectedIndex = -1;
        }

        private void method_2()
        {
            DataTable table = this.method_0();
            base.SelectSqlData(table, true, "where typeCodeId = " + 0x218.ToString() + " and deleted = 0 order by typeCodeSocr, name", false);
            this.comboBox_5.SelectedIndexChanged -= new EventHandler(this.comboBox_5_SelectedIndexChanged);
            this.comboBox_5.DataSource = table;
            this.comboBox_5.DisplayMember = "fullNameSub";
            this.comboBox_5.ValueMember = "id";
            this.comboBox_5.SelectedIndexChanged += new EventHandler(this.comboBox_5_SelectedIndexChanged);
            this.comboBox_5.SelectedIndex = -1;
        }

        private void method_3()
        {
            DataSetTechConnection.tR_ClassifierDataTable table = new DataSetTechConnection.tR_ClassifierDataTable();
            base.SelectSqlData(table, true, " where ParentKey like ';VoltageLevels;%' and isGroup = 0 and deleted = 0 order by value", false);
            this.comboBox_6.DataSource = table;
            this.comboBox_6.DisplayMember = "name";
            this.comboBox_6.ValueMember = "id";
            this.comboBox_6.SelectedIndex = -1;
        }

        private void method_4()
        {
            this.label_0 = new Label();
            this.comboBox_0 = new ComboBox();
            this.label_1 = new Label();
            this.comboBox_1 = new ComboBox();
            this.label_2 = new Label();
            this.comboBox_2 = new ComboBox();
            this.comboBox_3 = new ComboBox();
            this.label_3 = new Label();
            this.comboBox_4 = new ComboBox();
            this.label_4 = new Label();
            this.comboBox_5 = new ComboBox();
            this.label_5 = new Label();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.label_6 = new Label();
            this.comboBox_6 = new ComboBox();
            this.label_7 = new Label();
            this.nullableNumericUpDown_0 = new NullableNumericUpDown();
            this.label_8 = new Label();
            this.textBox_0 = new TextBox();
            this.nullableNumericUpDown_0.BeginInit();
            base.SuspendLayout();
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 9);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x2a, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "ТП/РП";
            this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_0.BackColor = SystemColors.Window;
            this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(15, 0x19);
            this.comboBox_0.Name = "cmbSubPoint";
            this.comboBox_0.Size = new Size(0x79, 0x15);
            this.comboBox_0.TabIndex = 1;
            this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(0xa3, 9);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(0x22, 13);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "Шина";
            this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(0xa6, 0x19);
            this.comboBox_1.Name = "cmbBusPoint";
            this.comboBox_1.Size = new Size(0x79, 0x15);
            this.comboBox_1.TabIndex = 3;
            this.comboBox_1.SelectedIndexChanged += new EventHandler(this.comboBox_1_SelectedIndexChanged);
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(0x131, 9);
            this.label_2.Name = "label3";
            this.label_2.Size = new Size(0x2c, 13);
            this.label_2.TabIndex = 4;
            this.label_2.Text = "Ячейка";
            this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_2.FormattingEnabled = true;
            this.comboBox_2.Location = new Point(0x134, 0x19);
            this.comboBox_2.Name = "cmbCellPoint";
            this.comboBox_2.Size = new Size(0x79, 0x15);
            this.comboBox_2.TabIndex = 5;
            this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_3.FormattingEnabled = true;
            this.comboBox_3.Location = new Point(0x134, 0x47);
            this.comboBox_3.Name = "cmbCellCP";
            this.comboBox_3.Size = new Size(0x79, 0x15);
            this.comboBox_3.TabIndex = 11;
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(0x131, 0x37);
            this.label_3.Name = "label4";
            this.label_3.Size = new Size(0x2c, 13);
            this.label_3.TabIndex = 10;
            this.label_3.Text = "Ячейка";
            this.comboBox_4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_4.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_4.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_4.FormattingEnabled = true;
            this.comboBox_4.Location = new Point(0xa6, 0x47);
            this.comboBox_4.Name = "cmbBusCP";
            this.comboBox_4.Size = new Size(0x79, 0x15);
            this.comboBox_4.TabIndex = 9;
            this.comboBox_4.SelectedIndexChanged += new EventHandler(this.comboBox_4_SelectedIndexChanged);
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(0xa3, 0x37);
            this.label_4.Name = "label5";
            this.label_4.Size = new Size(0x22, 13);
            this.label_4.TabIndex = 8;
            this.label_4.Text = "Шина";
            this.comboBox_5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox_5.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBox_5.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_5.FormattingEnabled = true;
            this.comboBox_5.Location = new Point(15, 0x47);
            this.comboBox_5.Name = "cmbSubCP";
            this.comboBox_5.Size = new Size(0x79, 0x15);
            this.comboBox_5.TabIndex = 7;
            this.comboBox_5.SelectedIndexChanged += new EventHandler(this.comboBox_5_SelectedIndexChanged);
            this.label_5.AutoSize = true;
            this.label_5.Location = new Point(12, 0x37);
            this.label_5.Name = "label6";
            this.label_5.Size = new Size(0x17, 13);
            this.label_5.TabIndex = 6;
            this.label_5.Text = "ЦП";
            this.button_0.DialogResult = DialogResult.OK;
            this.button_0.Location = new Point(15, 250);
            this.button_0.Name = "buttonOK";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 12;
            this.button_0.Text = "ОК";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_1.DialogResult = DialogResult.Cancel;
            this.button_1.Location = new Point(0x162, 250);
            this.button_1.Name = "buttonCancel";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 13;
            this.button_1.Text = "Отмена";
            this.button_1.UseVisualStyleBackColor = true;
            this.label_6.AutoSize = true;
            this.label_6.Location = new Point(12, 0x6a);
            this.label_6.Name = "label7";
            this.label_6.Size = new Size(0x74, 13);
            this.label_6.TabIndex = 14;
            this.label_6.Text = "Уровень напряжения";
            this.comboBox_6.FormattingEnabled = true;
            this.comboBox_6.Location = new Point(15, 0x7a);
            this.comboBox_6.Name = "cmbVoltageLevel";
            this.comboBox_6.Size = new Size(0xb6, 0x15);
            this.comboBox_6.TabIndex = 15;
            this.label_7.AutoSize = true;
            this.label_7.Location = new Point(0xe2, 0x6a);
            this.label_7.Name = "label8";
            this.label_7.Size = new Size(60, 13);
            this.label_7.TabIndex = 0x11;
            this.label_7.Text = "Мощность";
            this.nullableNumericUpDown_0.DecimalPlaces = 2;
            this.nullableNumericUpDown_0.Location = new Point(0xda, 0x7b);
            int[] bits = new int[4];
            bits[0] = 0x1869f;
            this.nullableNumericUpDown_0.Maximum = new decimal(bits);
            this.nullableNumericUpDown_0.Name = "numericUpDownPowerSum";
            this.nullableNumericUpDown_0.Size = new Size(0xd3, 20);
            this.nullableNumericUpDown_0.TabIndex = 0x12;
            this.nullableNumericUpDown_0.set_Value(null);
            this.label_8.AutoSize = true;
            this.label_8.Location = new Point(12, 0x92);
            this.label_8.Name = "label9";
            this.label_8.Size = new Size(0xa9, 13);
            this.label_8.TabIndex = 0x13;
            this.label_8.Text = "Описание точки присоединения";
            this.textBox_0.Location = new Point(15, 0xa2);
            this.textBox_0.Multiline = true;
            this.textBox_0.Name = "txtDescriptionPoint";
            this.textBox_0.Size = new Size(0x19e, 0x52);
            this.textBox_0.TabIndex = 20;
            base.AcceptButton = this.button_0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.button_1;
            base.ClientSize = new Size(0x1b7, 0x11d);
            base.Controls.Add(this.textBox_0);
            base.Controls.Add(this.label_8);
            base.Controls.Add(this.nullableNumericUpDown_0);
            base.Controls.Add(this.label_7);
            base.Controls.Add(this.comboBox_6);
            base.Controls.Add(this.label_6);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.comboBox_3);
            base.Controls.Add(this.label_3);
            base.Controls.Add(this.comboBox_4);
            base.Controls.Add(this.label_4);
            base.Controls.Add(this.comboBox_5);
            base.Controls.Add(this.label_5);
            base.Controls.Add(this.comboBox_2);
            base.Controls.Add(this.label_2);
            base.Controls.Add(this.comboBox_1);
            base.Controls.Add(this.label_1);
            base.Controls.Add(this.comboBox_0);
            base.Controls.Add(this.label_0);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "FormLinkTUAndSchmObj";
            this.Text = "Выбор точки присоединения";
            base.Load += new EventHandler(this.FormLinkTUAndSchmObj_Load);
            this.nullableNumericUpDown_0.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        public string BusCP
        {
            get
            {
                return this.comboBox_4.Text;
            }
        }

        public string BusPoint
        {
            get
            {
                return this.comboBox_1.Text;
            }
        }

        public string CellCP
        {
            get
            {
                return this.comboBox_3.Text;
            }
        }

        public string CellPoint
        {
            get
            {
                return this.comboBox_2.Text;
            }
        }

        public string DescriptionPoint
        {
            get
            {
                return this.textBox_0.Text;
            }
        }

        public int? idBusCP
        {
            get
            {
                if (this.comboBox_4.SelectedValue == null)
                {
                    return null;
                }
                return new int?(Convert.ToInt32(this.comboBox_4.SelectedValue));
            }
        }

        public int? idBusPoint
        {
            get
            {
                if (this.comboBox_1.SelectedValue == null)
                {
                    return null;
                }
                return new int?(Convert.ToInt32(this.comboBox_1.SelectedValue));
            }
        }

        public int? idCellCP
        {
            get
            {
                if (this.comboBox_3.SelectedValue == null)
                {
                    return null;
                }
                return new int?(Convert.ToInt32(this.comboBox_3.SelectedValue));
            }
        }

        public int? idCellPoint
        {
            get
            {
                if (this.comboBox_2.SelectedValue == null)
                {
                    return null;
                }
                return new int?(Convert.ToInt32(this.comboBox_2.SelectedValue));
            }
        }

        public int? idSubCP
        {
            get
            {
                if (this.comboBox_5.SelectedValue == null)
                {
                    return null;
                }
                return new int?(Convert.ToInt32(this.comboBox_5.SelectedValue));
            }
        }

        public int? idSubPoint
        {
            get
            {
                if (this.comboBox_0.SelectedValue == null)
                {
                    return null;
                }
                return new int?(Convert.ToInt32(this.comboBox_0.SelectedValue));
            }
        }

        public int? idVoltagelevel
        {
            get
            {
                if (this.comboBox_6.SelectedValue == null)
                {
                    return null;
                }
                return new int?(Convert.ToInt32(this.comboBox_6.SelectedValue));
            }
        }

        public decimal? PowerSum
        {
            get
            {
                return this.nullableNumericUpDown_0.get_Value();
            }
        }

        public string SubCP
        {
            get
            {
                return this.comboBox_5.Text;
            }
        }

        public string SubPoint
        {
            get
            {
                return this.comboBox_0.Text;
            }
        }

        public string VoltageLevel
        {
            get
            {
                return this.comboBox_6.Text;
            }
        }
    }
}

