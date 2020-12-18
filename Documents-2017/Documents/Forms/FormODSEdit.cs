namespace Documents.Forms
{
    using DataSql;
    using Documents.DataSets;
    using FormLbr;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormODSEdit : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private BindingSource bindingSource_3;
        private bool bool_0;
        private Button button_0;
        private Button button_1;
        private CheckBox checkBox_0;
        private CheckBox checkBox_1;
        private CheckBox checkBox_2;
        private Class203 class203_0;
        private Class207 class207_0;
        private Class214 class214_0;
        private Class215 class215_0;
        private Class215 class215_1;
        private OrgDataSet.Class411 class411_0;
        private OrgDataSet.Class415 class415_0;
        private ComboBox comboBox_0;
        private ComboBox comboBox_1;
        private DateTimePicker dateTimePicker_0;
        private GroupBox groupBox_0;
        private GroupBox groupBox_1;
        private GroupBox groupBox_2;
        private GroupBox groupBox_3;
        private IContainer icontainer_0;
        private Label label_0;
        private Label label_1;
        private OrgDataSet orgDataSet_0;
        private TextBox textBox_0;
        private TextBox textBox_1;

        public FormODSEdit(bool legal, object object_0, SQLSettings SqlSettings)
        {
            this.method_0();
            this.set_SqlSettings(SqlSettings);
            this.bool_0 = legal;
            if (legal)
            {
                this.class411_0 = (OrgDataSet.Class411) ((DataRowView) object_0).Row;
                if (this.class411_0.method_48())
                {
                    if (!this.class411_0.method_74())
                    {
                        this.Text = this.class411_0.NoDogAbn;
                    }
                    else
                    {
                        this.Text = "";
                    }
                }
                else if (!this.class411_0.method_52())
                {
                    this.Text = this.class411_0.method_6();
                }
                else
                {
                    this.Text = "";
                }
            }
            else
            {
                this.class415_0 = (OrgDataSet.Class415) ((DataRowView) object_0).Row;
                if (!this.class415_0.method_30())
                {
                    this.Text = this.class415_0.FIO;
                    if (!this.class415_0.method_32())
                    {
                        this.Text = this.Text + ", " + this.class415_0.Address;
                    }
                }
                else if (!this.class415_0.method_32())
                {
                    this.Text = this.class415_0.Address;
                }
            }
            this.class214_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            this.class207_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            this.class215_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
        }

        private void checkBox_0_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox_1.Enabled = this.checkBox_0.Checked;
            this.groupBox_2.Enabled = !this.checkBox_0.Checked;
        }

        private void checkBox_0_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void checkBox_1_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox_0.Enabled = this.checkBox_1.Checked;
        }

        private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = string.Empty;
            int selectedValue = (int) this.comboBox_0.SelectedValue;
            switch (selectedValue)
            {
                case 0x17:
                    str = ";GroupWorker;PersonApplDiscon;Performer;NA1;";
                    break;

                case 0x18:
                    str = ";GroupWorker;PersonApplDiscon;Performer;NA2;";
                    break;

                case 0x19:
                    str = ";GroupWorker;PersonApplDiscon;Performer;NA3;";
                    break;

                case 0x1a:
                    break;

                case 0x1b:
                    str = ";GroupWorker;PersonApplDiscon;Performer;NA4;";
                    break;

                default:
                    if (selectedValue == 0x29)
                    {
                        str = ";GroupWorker;PersonApplDiscon;Performer;DispDep;";
                    }
                    break;
            }
            if (this.bool_0)
            {
                this.class411_0.method_17((int) this.comboBox_0.SelectedValue);
            }
            else
            {
                this.class415_0.method_13((int) this.comboBox_0.SelectedValue);
            }
            this.class215_0.vmethod_2(this.orgDataSet_0.tR_Worker, str);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormODSEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                if (this.bool_0)
                {
                    this.class411_0.Comments = this.textBox_1.Text;
                    if (this.checkBox_1.Checked)
                    {
                        this.class411_0.method_17((int) this.comboBox_0.SelectedValue);
                        this.class411_0.method_13((int) this.comboBox_1.SelectedValue);
                    }
                    else
                    {
                        this.class411_0.method_63();
                        this.class411_0.method_59();
                    }
                    if (this.checkBox_0.Checked)
                    {
                        this.class411_0.method_11(this.dateTimePicker_0.Value);
                        this.class411_0.method_61();
                    }
                    else
                    {
                        this.class411_0.method_15(this.textBox_0.Text);
                        this.class411_0.method_57();
                    }
                    this.class411_0.method_29(this.checkBox_2.Checked);
                    this.class411_0.EndEdit();
                }
                else
                {
                    this.class415_0.Comments = this.textBox_1.Text;
                    if (this.checkBox_1.Checked)
                    {
                        this.class415_0.method_13((int) this.comboBox_0.SelectedValue);
                        this.class415_0.method_11((int) this.comboBox_1.SelectedValue);
                    }
                    else
                    {
                        this.class415_0.method_61();
                        this.class415_0.method_59();
                    }
                    if (this.checkBox_0.Checked)
                    {
                        this.class415_0.method_9(this.dateTimePicker_0.Value);
                        this.class415_0.method_63();
                    }
                    else
                    {
                        this.class415_0.method_15(this.textBox_0.Text);
                        this.class415_0.method_57();
                    }
                    this.class415_0.method_25(this.checkBox_2.Checked);
                    this.class415_0.EndEdit();
                }
            }
            else if (this.bool_0)
            {
                this.class411_0.CancelEdit();
            }
            else
            {
                this.class415_0.CancelEdit();
            }
        }

        private void FormODSEdit_Load(object sender, EventArgs e)
        {
            this.class214_0.vmethod_0(this.orgDataSet_0.NetArea);
            string str = string.Empty;
            int num = -1;
            if (this.bool_0)
            {
                if (this.class411_0.method_56())
                {
                    this.checkBox_0.Checked = false;
                    if (!this.class411_0.method_60())
                    {
                        this.textBox_0.Text = this.class411_0.method_14();
                    }
                }
                else
                {
                    this.checkBox_0.Checked = true;
                    if (!this.class411_0.method_56())
                    {
                        this.dateTimePicker_0.Value = this.class411_0.method_10();
                    }
                }
                if (this.class411_0.method_58())
                {
                    this.comboBox_0.SelectedIndex = 0;
                    this.class411_0.method_17((int) this.comboBox_0.SelectedValue);
                    this.checkBox_1.Checked = false;
                }
                else
                {
                    this.comboBox_0.SelectedValue = this.class411_0.method_16();
                    this.class411_0.method_17((int) this.comboBox_0.SelectedValue);
                    this.comboBox_1.SelectedValue = this.class411_0.method_12();
                    this.checkBox_1.Checked = true;
                }
                num = this.class411_0.method_16();
                if (!this.class411_0.method_44())
                {
                    this.textBox_1.Text = this.class411_0.Comments;
                }
                if (!this.class411_0.method_78())
                {
                    this.checkBox_2.Checked = this.class411_0.method_28();
                }
                else
                {
                    this.checkBox_2.Checked = false;
                }
            }
            else
            {
                if (this.class415_0.method_56())
                {
                    this.checkBox_0.Checked = false;
                    if (!this.class415_0.method_62())
                    {
                        this.textBox_0.Text = this.class415_0.method_14();
                    }
                }
                else
                {
                    this.checkBox_0.Checked = true;
                    if (!this.class415_0.method_56())
                    {
                        this.dateTimePicker_0.Value = this.class415_0.method_8();
                    }
                }
                if (this.class415_0.method_58())
                {
                    this.comboBox_0.SelectedIndex = 0;
                    this.class415_0.method_13((int) this.comboBox_0.SelectedValue);
                    this.checkBox_1.Checked = false;
                }
                else
                {
                    this.comboBox_0.SelectedValue = this.class415_0.method_12();
                    this.class415_0.method_13((int) this.comboBox_0.SelectedValue);
                    this.comboBox_1.SelectedValue = this.class415_0.method_10();
                    this.checkBox_1.Checked = true;
                }
                num = this.class415_0.method_12();
                if (!this.class415_0.method_40())
                {
                    this.textBox_1.Text = this.class415_0.Comments;
                }
                if (!this.class415_0.method_72())
                {
                    this.checkBox_2.Checked = this.class415_0.method_24();
                }
                else
                {
                    this.checkBox_2.Checked = false;
                }
            }
            switch (num)
            {
                case 0x17:
                    str = ";GroupWorker;PersonApplDiscon;Performer;NA1;";
                    break;

                case 0x18:
                    str = ";GroupWorker;PersonApplDiscon;Performer;NA2;";
                    break;

                case 0x19:
                    str = ";GroupWorker;PersonApplDiscon;Performer;NA3;";
                    break;

                case 0x1a:
                    break;

                case 0x1b:
                    str = ";GroupWorker;PersonApplDiscon;Performer;NA4;";
                    break;

                default:
                    if (num == 0x29)
                    {
                        str = ";GroupWorker;PersonApplDiscon;Performer;DispDep;";
                    }
                    break;
            }
            this.class215_0.vmethod_2(this.orgDataSet_0.tR_Worker, str);
        }

        private void method_0()
        {
            this.icontainer_0 = new Container();
            this.orgDataSet_0 = new OrgDataSet();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.class203_0 = new Class203();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.class207_0 = new Class207();
            this.groupBox_0 = new GroupBox();
            this.label_0 = new Label();
            this.label_1 = new Label();
            this.comboBox_1 = new ComboBox();
            this.bindingSource_3 = new BindingSource(this.icontainer_0);
            this.comboBox_0 = new ComboBox();
            this.bindingSource_2 = new BindingSource(this.icontainer_0);
            this.groupBox_1 = new GroupBox();
            this.dateTimePicker_0 = new DateTimePicker();
            this.checkBox_0 = new CheckBox();
            this.class214_0 = new Class214();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.class215_0 = new Class215();
            this.groupBox_2 = new GroupBox();
            this.textBox_0 = new TextBox();
            this.groupBox_3 = new GroupBox();
            this.textBox_1 = new TextBox();
            this.checkBox_1 = new CheckBox();
            this.checkBox_2 = new CheckBox();
            this.class215_1 = new Class215();
            this.orgDataSet_0.BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            this.groupBox_0.SuspendLayout();
            ((ISupportInitialize) this.bindingSource_3).BeginInit();
            ((ISupportInitialize) this.bindingSource_2).BeginInit();
            this.groupBox_1.SuspendLayout();
            this.groupBox_2.SuspendLayout();
            this.groupBox_3.SuspendLayout();
            base.SuspendLayout();
            this.orgDataSet_0.DataSetName = "OrgDataSet";
            this.orgDataSet_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.bindingSource_0.DataMember = "tblAbnAplForDisconObjects";
            this.bindingSource_0.DataSource = this.orgDataSet_0;
            this.class203_0.method_7(true);
            this.bindingSource_1.DataMember = "tblAbnAplForDisconIndividualUsers";
            this.bindingSource_1.DataSource = this.orgDataSet_0;
            this.class207_0.method_7(true);
            this.groupBox_0.Controls.Add(this.label_0);
            this.groupBox_0.Controls.Add(this.label_1);
            this.groupBox_0.Controls.Add(this.comboBox_1);
            this.groupBox_0.Controls.Add(this.comboBox_0);
            this.groupBox_0.Dock = DockStyle.Top;
            this.groupBox_0.Enabled = false;
            this.groupBox_0.Location = new Point(0, 0);
            this.groupBox_0.Name = "groupBoxExecuter";
            this.groupBox_0.Size = new Size(0x216, 0x36);
            this.groupBox_0.TabIndex = 0;
            this.groupBox_0.TabStop = false;
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(0x10c, 0x16);
            this.label_0.Name = "label2";
            this.label_0.Size = new Size(0x25, 13);
            this.label_0.TabIndex = 1;
            this.label_0.Text = "ФИО:";
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(12, 0x16);
            this.label_1.Name = "label1";
            this.label_1.Size = new Size(0x55, 13);
            this.label_1.TabIndex = 1;
            this.label_1.Text = "Сетевой район:";
            this.comboBox_1.DataSource = this.bindingSource_3;
            this.comboBox_1.DisplayMember = "FIO";
            this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new Point(0x142, 0x13);
            this.comboBox_1.Name = "comboBoxFIOExec";
            this.comboBox_1.Size = new Size(200, 0x15);
            this.comboBox_1.TabIndex = 0;
            this.comboBox_1.ValueMember = "id";
            this.bindingSource_3.DataMember = "tR_Worker";
            this.bindingSource_3.DataSource = this.orgDataSet_0;
            this.comboBox_0.DataSource = this.bindingSource_2;
            this.comboBox_0.DisplayMember = "Description";
            this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_0.FormattingEnabled = true;
            this.comboBox_0.Location = new Point(0x67, 0x13);
            this.comboBox_0.Name = "comboBoxNetAreaExec";
            this.comboBox_0.Size = new Size(0x92, 0x15);
            this.comboBox_0.TabIndex = 0;
            this.comboBox_0.ValueMember = "id";
            this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
            this.bindingSource_2.DataMember = "NetArea";
            this.bindingSource_2.DataSource = this.orgDataSet_0;
            this.groupBox_1.Controls.Add(this.dateTimePicker_0);
            this.groupBox_1.Dock = DockStyle.Top;
            this.groupBox_1.Enabled = false;
            this.groupBox_1.Location = new Point(0, 0x36);
            this.groupBox_1.Name = "groupBoxExecution";
            this.groupBox_1.Size = new Size(0x216, 0x31);
            this.groupBox_1.TabIndex = 0;
            this.groupBox_1.TabStop = false;
            this.dateTimePicker_0.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker_0.Location = new Point(6, 0x15);
            this.dateTimePicker_0.Name = "dateTimePickerExec";
            this.dateTimePicker_0.ShowUpDown = true;
            this.dateTimePicker_0.Size = new Size(0xd4, 20);
            this.dateTimePicker_0.TabIndex = 1;
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Location = new Point(9, 0x36);
            this.checkBox_0.Name = "checkBoxExecute";
            this.checkBox_0.Size = new Size(0x52, 0x11);
            this.checkBox_0.TabIndex = 1;
            this.checkBox_0.Text = "Исполнено";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_0.CheckedChanged += new EventHandler(this.checkBox_0_CheckedChanged);
            this.checkBox_0.EnabledChanged += new EventHandler(this.checkBox_0_EnabledChanged);
            this.class214_0.method_7(true);
            this.button_0.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_0.DialogResult = DialogResult.Cancel;
            this.button_0.Location = new Point(0x1bf, 0x14e);
            this.button_0.Name = "buttonCancel";
            this.button_0.Size = new Size(0x4b, 0x17);
            this.button_0.TabIndex = 2;
            this.button_0.Text = "Отмена";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button_1.DialogResult = DialogResult.OK;
            this.button_1.Location = new Point(0x16e, 0x14e);
            this.button_1.Name = "buttonOK";
            this.button_1.Size = new Size(0x4b, 0x17);
            this.button_1.TabIndex = 2;
            this.button_1.Text = "Готово";
            this.button_1.UseVisualStyleBackColor = true;
            this.class215_0.method_7(true);
            this.groupBox_2.Controls.Add(this.textBox_0);
            this.groupBox_2.Dock = DockStyle.Top;
            this.groupBox_2.Location = new Point(0, 0x67);
            this.groupBox_2.Name = "groupBoxReasonFailure";
            this.groupBox_2.Size = new Size(0x216, 0x66);
            this.groupBox_2.TabIndex = 3;
            this.groupBox_2.TabStop = false;
            this.groupBox_2.Text = "Причина неисполнения";
            this.textBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.textBox_0.Location = new Point(8, 0x13);
            this.textBox_0.Multiline = true;
            this.textBox_0.Name = "textBoxReasonFailure";
            this.textBox_0.Size = new Size(0x209, 0x4d);
            this.textBox_0.TabIndex = 0;
            this.textBox_0.TextChanged += new EventHandler(this.textBox_0_TextChanged);
            this.groupBox_3.Controls.Add(this.textBox_1);
            this.groupBox_3.Dock = DockStyle.Top;
            this.groupBox_3.Location = new Point(0, 0xcd);
            this.groupBox_3.Name = "groupBox1";
            this.groupBox_3.Size = new Size(0x216, 0x66);
            this.groupBox_3.TabIndex = 4;
            this.groupBox_3.TabStop = false;
            this.groupBox_3.Text = "Примечание";
            this.textBox_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.textBox_1.Location = new Point(8, 0x13);
            this.textBox_1.Multiline = true;
            this.textBox_1.Name = "textBoxComments";
            this.textBox_1.Size = new Size(0x209, 0x4d);
            this.textBox_1.TabIndex = 0;
            this.checkBox_1.AutoSize = true;
            this.checkBox_1.Location = new Point(10, 0);
            this.checkBox_1.Name = "checkBoxExecuter";
            this.checkBox_1.Size = new Size(0x5d, 0x11);
            this.checkBox_1.TabIndex = 5;
            this.checkBox_1.Text = "Исполнитель";
            this.checkBox_1.UseVisualStyleBackColor = true;
            this.checkBox_1.CheckedChanged += new EventHandler(this.checkBox_1_CheckedChanged);
            this.checkBox_2.AutoSize = true;
            this.checkBox_2.Location = new Point(8, 0x139);
            this.checkBox_2.Name = "matrixCheckBox";
            this.checkBox_2.Size = new Size(0xb0, 0x11);
            this.checkBox_2.TabIndex = 6;
            this.checkBox_2.Text = "Клиент подключен к Матрице";
            this.checkBox_2.UseVisualStyleBackColor = true;
            this.class215_1.method_7(true);
            base.AcceptButton = this.button_1;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.button_0;
            base.ClientSize = new Size(0x216, 0x171);
            base.Controls.Add(this.checkBox_2);
            base.Controls.Add(this.checkBox_1);
            base.Controls.Add(this.groupBox_3);
            base.Controls.Add(this.checkBox_0);
            base.Controls.Add(this.groupBox_2);
            base.Controls.Add(this.groupBox_1);
            base.Controls.Add(this.groupBox_0);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "FormODSEdit";
            this.Text = "FormODSEdit";
            base.FormClosing += new FormClosingEventHandler(this.FormODSEdit_FormClosing);
            base.Load += new EventHandler(this.FormODSEdit_Load);
            this.orgDataSet_0.EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            ((ISupportInitialize) this.bindingSource_3).EndInit();
            ((ISupportInitialize) this.bindingSource_2).EndInit();
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_2.ResumeLayout(false);
            this.groupBox_2.PerformLayout();
            this.groupBox_3.ResumeLayout(false);
            this.groupBox_3.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void textBox_0_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

