namespace Legal.Forms.Object
{
    partial class FormObjPower
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsObj1 = new Legal.DataSet.dsObj();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVolumYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPowerAverage = new System.Windows.Forms.TextBox();
            this.groupBoxPower = new System.Windows.Forms.GroupBox();
            this.textBox12Power = new System.Windows.Forms.TextBox();
            this.textBox11Power = new System.Windows.Forms.TextBox();
            this.textBox10Power = new System.Windows.Forms.TextBox();
            this.textBox9Power = new System.Windows.Forms.TextBox();
            this.textBox8Power = new System.Windows.Forms.TextBox();
            this.textBox7Power = new System.Windows.Forms.TextBox();
            this.textBox6Power = new System.Windows.Forms.TextBox();
            this.textBox5Power = new System.Windows.Forms.TextBox();
            this.textBox4Power = new System.Windows.Forms.TextBox();
            this.textBox3Power = new System.Windows.Forms.TextBox();
            this.textBox2Power = new System.Windows.Forms.TextBox();
            this.textBox1Power = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxVolum = new System.Windows.Forms.GroupBox();
            this.textBox12Volum = new System.Windows.Forms.TextBox();
            this.textBox11Volum = new System.Windows.Forms.TextBox();
            this.textBox10Volum = new System.Windows.Forms.TextBox();
            this.textBox9Volum = new System.Windows.Forms.TextBox();
            this.textBox8Volum = new System.Windows.Forms.TextBox();
            this.textBox7Volum = new System.Windows.Forms.TextBox();
            this.textBox6Volum = new System.Windows.Forms.TextBox();
            this.textBox5Volum = new System.Windows.Forms.TextBox();
            this.textBox4Volum = new System.Windows.Forms.TextBox();
            this.textBox3Volum = new System.Windows.Forms.TextBox();
            this.textBox2Volum = new System.Windows.Forms.TextBox();
            this.textBox1Volum = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopyBack = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).BeginInit();
            this.groupBoxPower.SuspendLayout();
            this.groupBoxVolum.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(25, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(125, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numYear
            // 
            this.numYear.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "Year", true));
            this.numYear.Location = new System.Drawing.Point(52, 21);
            this.numYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(61, 20);
            this.numYear.TabIndex = 1;
            this.numYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numYear.Value = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tG_ObjMax";
            this.bindingSource1.DataSource = this.dsObj1;
            // 
            // dsObj1
            // 
            this.dsObj1.DataSetName = "dsObj";
            this.dsObj1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Год:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Объем за год:";
            // 
            // txtVolumYear
            // 
            this.txtVolumYear.Location = new System.Drawing.Point(243, 20);
            this.txtVolumYear.Name = "txtVolumYear";
            this.txtVolumYear.ReadOnly = true;
            this.txtVolumYear.Size = new System.Drawing.Size(100, 20);
            this.txtVolumYear.TabIndex = 5;
            this.txtVolumYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Среднемесячная величина мощности:";
            // 
            // txtPowerAverage
            // 
            this.txtPowerAverage.Location = new System.Drawing.Point(585, 20);
            this.txtPowerAverage.Name = "txtPowerAverage";
            this.txtPowerAverage.ReadOnly = true;
            this.txtPowerAverage.Size = new System.Drawing.Size(100, 20);
            this.txtPowerAverage.TabIndex = 7;
            this.txtPowerAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxPower
            // 
            this.groupBoxPower.Controls.Add(this.textBox12Power);
            this.groupBoxPower.Controls.Add(this.textBox11Power);
            this.groupBoxPower.Controls.Add(this.textBox10Power);
            this.groupBoxPower.Controls.Add(this.textBox9Power);
            this.groupBoxPower.Controls.Add(this.textBox8Power);
            this.groupBoxPower.Controls.Add(this.textBox7Power);
            this.groupBoxPower.Controls.Add(this.textBox6Power);
            this.groupBoxPower.Controls.Add(this.textBox5Power);
            this.groupBoxPower.Controls.Add(this.textBox4Power);
            this.groupBoxPower.Controls.Add(this.textBox3Power);
            this.groupBoxPower.Controls.Add(this.textBox2Power);
            this.groupBoxPower.Controls.Add(this.textBox1Power);
            this.groupBoxPower.Controls.Add(this.label15);
            this.groupBoxPower.Controls.Add(this.label14);
            this.groupBoxPower.Controls.Add(this.label13);
            this.groupBoxPower.Controls.Add(this.label12);
            this.groupBoxPower.Controls.Add(this.label11);
            this.groupBoxPower.Controls.Add(this.label10);
            this.groupBoxPower.Controls.Add(this.label9);
            this.groupBoxPower.Controls.Add(this.label8);
            this.groupBoxPower.Controls.Add(this.label7);
            this.groupBoxPower.Controls.Add(this.label6);
            this.groupBoxPower.Controls.Add(this.label5);
            this.groupBoxPower.Controls.Add(this.label4);
            this.groupBoxPower.Location = new System.Drawing.Point(15, 168);
            this.groupBoxPower.Name = "groupBoxPower";
            this.groupBoxPower.Size = new System.Drawing.Size(351, 260);
            this.groupBoxPower.TabIndex = 2;
            this.groupBoxPower.TabStop = false;
            this.groupBoxPower.Text = " Мощность ";
            // 
            // textBox12Power
            // 
            this.textBox12Power.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Month12", true));
            this.textBox12Power.Location = new System.Drawing.Point(245, 221);
            this.textBox12Power.Name = "textBox12Power";
            this.textBox12Power.Size = new System.Drawing.Size(100, 20);
            this.textBox12Power.TabIndex = 23;
            this.textBox12Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox12Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox12Power_KeyPress);
            // 
            // textBox11Power
            // 
            this.textBox11Power.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Month11", true));
            this.textBox11Power.Location = new System.Drawing.Point(127, 221);
            this.textBox11Power.Name = "textBox11Power";
            this.textBox11Power.Size = new System.Drawing.Size(100, 20);
            this.textBox11Power.TabIndex = 22;
            this.textBox11Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox11Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox11Power_KeyPress);
            // 
            // textBox10Power
            // 
            this.textBox10Power.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Month10", true));
            this.textBox10Power.Location = new System.Drawing.Point(6, 221);
            this.textBox10Power.Name = "textBox10Power";
            this.textBox10Power.Size = new System.Drawing.Size(100, 20);
            this.textBox10Power.TabIndex = 21;
            this.textBox10Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox10Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10Power_KeyPress);
            // 
            // textBox9Power
            // 
            this.textBox9Power.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Month09", true));
            this.textBox9Power.Location = new System.Drawing.Point(245, 162);
            this.textBox9Power.Name = "textBox9Power";
            this.textBox9Power.Size = new System.Drawing.Size(100, 20);
            this.textBox9Power.TabIndex = 20;
            this.textBox9Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox9Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9Power_KeyPress);
            // 
            // textBox8Power
            // 
            this.textBox8Power.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Month08", true));
            this.textBox8Power.Location = new System.Drawing.Point(127, 162);
            this.textBox8Power.Name = "textBox8Power";
            this.textBox8Power.Size = new System.Drawing.Size(100, 20);
            this.textBox8Power.TabIndex = 19;
            this.textBox8Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox8Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8Power_KeyPress);
            // 
            // textBox7Power
            // 
            this.textBox7Power.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Month07", true));
            this.textBox7Power.Location = new System.Drawing.Point(6, 162);
            this.textBox7Power.Name = "textBox7Power";
            this.textBox7Power.Size = new System.Drawing.Size(100, 20);
            this.textBox7Power.TabIndex = 18;
            this.textBox7Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox7Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7Power_KeyPress);
            // 
            // textBox6Power
            // 
            this.textBox6Power.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Month06", true));
            this.textBox6Power.Location = new System.Drawing.Point(245, 103);
            this.textBox6Power.Name = "textBox6Power";
            this.textBox6Power.Size = new System.Drawing.Size(100, 20);
            this.textBox6Power.TabIndex = 17;
            this.textBox6Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox6Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6Power_KeyPress);
            // 
            // textBox5Power
            // 
            this.textBox5Power.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Month05", true));
            this.textBox5Power.Location = new System.Drawing.Point(127, 103);
            this.textBox5Power.Name = "textBox5Power";
            this.textBox5Power.Size = new System.Drawing.Size(100, 20);
            this.textBox5Power.TabIndex = 16;
            this.textBox5Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox5Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5Power_KeyPress);
            // 
            // textBox4Power
            // 
            this.textBox4Power.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Month04", true));
            this.textBox4Power.Location = new System.Drawing.Point(6, 103);
            this.textBox4Power.Name = "textBox4Power";
            this.textBox4Power.Size = new System.Drawing.Size(100, 20);
            this.textBox4Power.TabIndex = 15;
            this.textBox4Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4Power_KeyPress);
            // 
            // textBox3Power
            // 
            this.textBox3Power.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Month03", true));
            this.textBox3Power.Location = new System.Drawing.Point(245, 44);
            this.textBox3Power.Name = "textBox3Power";
            this.textBox3Power.Size = new System.Drawing.Size(100, 20);
            this.textBox3Power.TabIndex = 14;
            this.textBox3Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3Power_KeyPress);
            // 
            // textBox2Power
            // 
            this.textBox2Power.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Month02", true));
            this.textBox2Power.Location = new System.Drawing.Point(127, 44);
            this.textBox2Power.Name = "textBox2Power";
            this.textBox2Power.Size = new System.Drawing.Size(100, 20);
            this.textBox2Power.TabIndex = 13;
            this.textBox2Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2Power_KeyPress);
            // 
            // textBox1Power
            // 
            this.textBox1Power.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Month01", true));
            this.textBox1Power.Location = new System.Drawing.Point(6, 44);
            this.textBox1Power.Name = "textBox1Power";
            this.textBox1Power.Size = new System.Drawing.Size(100, 20);
            this.textBox1Power.TabIndex = 12;
            this.textBox1Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1Power_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(274, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "декабрь";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(152, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "ноябрь";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "октябрь";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(274, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "сентябрь";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "август";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "июль";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "июнь";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "май";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "апрель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "март";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "февраль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "январь";
            // 
            // groupBoxVolum
            // 
            this.groupBoxVolum.Controls.Add(this.textBox12Volum);
            this.groupBoxVolum.Controls.Add(this.textBox11Volum);
            this.groupBoxVolum.Controls.Add(this.textBox10Volum);
            this.groupBoxVolum.Controls.Add(this.textBox9Volum);
            this.groupBoxVolum.Controls.Add(this.textBox8Volum);
            this.groupBoxVolum.Controls.Add(this.textBox7Volum);
            this.groupBoxVolum.Controls.Add(this.textBox6Volum);
            this.groupBoxVolum.Controls.Add(this.textBox5Volum);
            this.groupBoxVolum.Controls.Add(this.textBox4Volum);
            this.groupBoxVolum.Controls.Add(this.textBox3Volum);
            this.groupBoxVolum.Controls.Add(this.textBox2Volum);
            this.groupBoxVolum.Controls.Add(this.textBox1Volum);
            this.groupBoxVolum.Controls.Add(this.label16);
            this.groupBoxVolum.Controls.Add(this.label17);
            this.groupBoxVolum.Controls.Add(this.label18);
            this.groupBoxVolum.Controls.Add(this.label19);
            this.groupBoxVolum.Controls.Add(this.label20);
            this.groupBoxVolum.Controls.Add(this.label21);
            this.groupBoxVolum.Controls.Add(this.label22);
            this.groupBoxVolum.Controls.Add(this.label23);
            this.groupBoxVolum.Controls.Add(this.label24);
            this.groupBoxVolum.Controls.Add(this.label25);
            this.groupBoxVolum.Controls.Add(this.label26);
            this.groupBoxVolum.Controls.Add(this.label27);
            this.groupBoxVolum.Location = new System.Drawing.Point(372, 168);
            this.groupBoxVolum.Name = "groupBoxVolum";
            this.groupBoxVolum.Size = new System.Drawing.Size(347, 260);
            this.groupBoxVolum.TabIndex = 4;
            this.groupBoxVolum.TabStop = false;
            this.groupBoxVolum.Text = " Объем ";
            // 
            // textBox12Volum
            // 
            this.textBox12Volum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Volume12", true));
            this.textBox12Volum.Location = new System.Drawing.Point(241, 221);
            this.textBox12Volum.Name = "textBox12Volum";
            this.textBox12Volum.Size = new System.Drawing.Size(100, 20);
            this.textBox12Volum.TabIndex = 47;
            this.textBox12Volum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox12Volum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox12Volum_KeyPress);
            // 
            // textBox11Volum
            // 
            this.textBox11Volum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Volume11", true));
            this.textBox11Volum.Location = new System.Drawing.Point(123, 221);
            this.textBox11Volum.Name = "textBox11Volum";
            this.textBox11Volum.Size = new System.Drawing.Size(100, 20);
            this.textBox11Volum.TabIndex = 46;
            this.textBox11Volum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox11Volum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox11Volum_KeyPress);
            // 
            // textBox10Volum
            // 
            this.textBox10Volum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Volume10", true));
            this.textBox10Volum.Location = new System.Drawing.Point(6, 221);
            this.textBox10Volum.Name = "textBox10Volum";
            this.textBox10Volum.Size = new System.Drawing.Size(100, 20);
            this.textBox10Volum.TabIndex = 45;
            this.textBox10Volum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox10Volum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10Volum_KeyPress);
            // 
            // textBox9Volum
            // 
            this.textBox9Volum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Volume09", true));
            this.textBox9Volum.Location = new System.Drawing.Point(241, 162);
            this.textBox9Volum.Name = "textBox9Volum";
            this.textBox9Volum.Size = new System.Drawing.Size(100, 20);
            this.textBox9Volum.TabIndex = 44;
            this.textBox9Volum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox9Volum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9Volum_KeyPress);
            // 
            // textBox8Volum
            // 
            this.textBox8Volum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Volume08", true));
            this.textBox8Volum.Location = new System.Drawing.Point(123, 162);
            this.textBox8Volum.Name = "textBox8Volum";
            this.textBox8Volum.Size = new System.Drawing.Size(100, 20);
            this.textBox8Volum.TabIndex = 43;
            this.textBox8Volum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox8Volum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8Volum_KeyPress);
            // 
            // textBox7Volum
            // 
            this.textBox7Volum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Volume07", true));
            this.textBox7Volum.Location = new System.Drawing.Point(6, 162);
            this.textBox7Volum.Name = "textBox7Volum";
            this.textBox7Volum.Size = new System.Drawing.Size(100, 20);
            this.textBox7Volum.TabIndex = 42;
            this.textBox7Volum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox7Volum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7Volum_KeyPress);
            // 
            // textBox6Volum
            // 
            this.textBox6Volum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Volume06", true));
            this.textBox6Volum.Location = new System.Drawing.Point(241, 103);
            this.textBox6Volum.Name = "textBox6Volum";
            this.textBox6Volum.Size = new System.Drawing.Size(100, 20);
            this.textBox6Volum.TabIndex = 41;
            this.textBox6Volum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox6Volum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6Volum_KeyPress);
            // 
            // textBox5Volum
            // 
            this.textBox5Volum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Volume05", true));
            this.textBox5Volum.Location = new System.Drawing.Point(123, 103);
            this.textBox5Volum.Name = "textBox5Volum";
            this.textBox5Volum.Size = new System.Drawing.Size(100, 20);
            this.textBox5Volum.TabIndex = 40;
            this.textBox5Volum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox5Volum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5Volum_KeyPress);
            // 
            // textBox4Volum
            // 
            this.textBox4Volum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Volume04", true));
            this.textBox4Volum.Location = new System.Drawing.Point(6, 103);
            this.textBox4Volum.Name = "textBox4Volum";
            this.textBox4Volum.Size = new System.Drawing.Size(100, 20);
            this.textBox4Volum.TabIndex = 39;
            this.textBox4Volum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4Volum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4Volum_KeyPress);
            // 
            // textBox3Volum
            // 
            this.textBox3Volum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Volume03", true));
            this.textBox3Volum.Location = new System.Drawing.Point(241, 44);
            this.textBox3Volum.Name = "textBox3Volum";
            this.textBox3Volum.Size = new System.Drawing.Size(100, 20);
            this.textBox3Volum.TabIndex = 38;
            this.textBox3Volum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3Volum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3Volum_KeyPress);
            // 
            // textBox2Volum
            // 
            this.textBox2Volum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Volume02", true));
            this.textBox2Volum.Location = new System.Drawing.Point(123, 44);
            this.textBox2Volum.Name = "textBox2Volum";
            this.textBox2Volum.Size = new System.Drawing.Size(100, 20);
            this.textBox2Volum.TabIndex = 37;
            this.textBox2Volum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2Volum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2Volum_KeyPress);
            // 
            // textBox1Volum
            // 
            this.textBox1Volum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Volume01", true));
            this.textBox1Volum.Location = new System.Drawing.Point(6, 44);
            this.textBox1Volum.Name = "textBox1Volum";
            this.textBox1Volum.Size = new System.Drawing.Size(100, 20);
            this.textBox1Volum.TabIndex = 36;
            this.textBox1Volum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1Volum.WordWrap = false;
            this.textBox1Volum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1Volum_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(262, 205);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "декабрь";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(149, 205);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "ноябрь";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "октябрь";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(262, 146);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "сентябрь";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(155, 146);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "август";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 146);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "июль";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(268, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 29;
            this.label22.Text = "июнь";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(155, 87);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 13);
            this.label23.TabIndex = 28;
            this.label23.Text = "май";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(35, 87);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 13);
            this.label24.TabIndex = 27;
            this.label24.Text = "апрель";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(268, 28);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 13);
            this.label25.TabIndex = 26;
            this.label25.Text = "март";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(149, 28);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(51, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "февраль";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(34, 28);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(43, 13);
            this.label27.TabIndex = 24;
            this.label27.Text = "январь";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(17, 61);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 13);
            this.label28.TabIndex = 10;
            this.label28.Text = "Режим:";
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(21, 77);
            this.txtMode.Name = "txtMode";
            this.txtMode.ReadOnly = true;
            this.txtMode.Size = new System.Drawing.Size(100, 20);
            this.txtMode.TabIndex = 11;
            this.txtMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(303, 103);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(130, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Заполнить ------->";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Location = new System.Drawing.Point(495, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 46);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnCopyBack
            // 
            this.btnCopyBack.Location = new System.Drawing.Point(303, 132);
            this.btnCopyBack.Name = "btnCopyBack";
            this.btnCopyBack.Size = new System.Drawing.Size(130, 23);
            this.btnCopyBack.TabIndex = 12;
            this.btnCopyBack.Text = "<------- Заполнить";
            this.btnCopyBack.UseVisualStyleBackColor = true;
            this.btnCopyBack.Click += new System.EventHandler(this.btnCopyBack_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 108);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(126, 13);
            this.label29.TabIndex = 13;
            this.label29.Text = "Заявленная мощность:";
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(21, 124);
            this.txtPower.Name = "txtPower";
            this.txtPower.ReadOnly = true;
            this.txtPower.Size = new System.Drawing.Size(100, 20);
            this.txtPower.TabIndex = 14;
            this.txtPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormObjPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 440);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.btnCopyBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.groupBoxVolum);
            this.Controls.Add(this.groupBoxPower);
            this.Controls.Add(this.txtPowerAverage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVolumYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormObjPower";
            this.Text = "Заявленные параметры";
            this.Load += new System.EventHandler(this.FormObjPower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).EndInit();
            this.groupBoxPower.ResumeLayout(false);
            this.groupBoxPower.PerformLayout();
            this.groupBoxVolum.ResumeLayout(false);
            this.groupBoxVolum.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVolumYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPowerAverage;
        private System.Windows.Forms.GroupBox groupBoxPower;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxVolum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Button btnCopy;
        private DataSet.dsObj dsObj1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox12Power;
        private System.Windows.Forms.TextBox textBox11Power;
        private System.Windows.Forms.TextBox textBox10Power;
        private System.Windows.Forms.TextBox textBox9Power;
        private System.Windows.Forms.TextBox textBox8Power;
        private System.Windows.Forms.TextBox textBox7Power;
        private System.Windows.Forms.TextBox textBox6Power;
        private System.Windows.Forms.TextBox textBox5Power;
        private System.Windows.Forms.TextBox textBox4Power;
        private System.Windows.Forms.TextBox textBox3Power;
        private System.Windows.Forms.TextBox textBox2Power;
        private System.Windows.Forms.TextBox textBox1Power;
        private System.Windows.Forms.TextBox textBox12Volum;
        private System.Windows.Forms.TextBox textBox11Volum;
        private System.Windows.Forms.TextBox textBox10Volum;
        private System.Windows.Forms.TextBox textBox9Volum;
        private System.Windows.Forms.TextBox textBox8Volum;
        private System.Windows.Forms.TextBox textBox7Volum;
        private System.Windows.Forms.TextBox textBox6Volum;
        private System.Windows.Forms.TextBox textBox5Volum;
        private System.Windows.Forms.TextBox textBox4Volum;
        private System.Windows.Forms.TextBox textBox3Volum;
        private System.Windows.Forms.TextBox textBox2Volum;
        private System.Windows.Forms.TextBox textBox1Volum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCopyBack;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtPower;
    }
}