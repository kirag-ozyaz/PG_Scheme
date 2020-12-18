namespace Legal.Forms.Object
{
    partial class FormMeasurementsOfObject_Edit
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
            this.dsObj1 = new Legal.DataSet.dsObj();
            this.bsMeasurObject_Edit = new System.Windows.Forms.BindingSource(this.components);
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt24 = new System.Windows.Forms.TextBox();
            this.txt23 = new System.Windows.Forms.TextBox();
            this.txt22 = new System.Windows.Forms.TextBox();
            this.txt21 = new System.Windows.Forms.TextBox();
            this.txt20 = new System.Windows.Forms.TextBox();
            this.txt19 = new System.Windows.Forms.TextBox();
            this.txt18 = new System.Windows.Forms.TextBox();
            this.txt17 = new System.Windows.Forms.TextBox();
            this.txt16 = new System.Windows.Forms.TextBox();
            this.txt15 = new System.Windows.Forms.TextBox();
            this.txt14 = new System.Windows.Forms.TextBox();
            this.txt13 = new System.Windows.Forms.TextBox();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtMeasur = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurObject_Edit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsObj1
            // 
            this.dsObj1.DataSetName = "dsObj";
            this.dsObj1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsMeasurObject_Edit
            // 
            this.bsMeasurObject_Edit.DataMember = "tG_MeasurementsOfObject";
            this.bsMeasurObject_Edit.DataSource = this.dsObj1;
            // 
            // txtAverage
            // 
            this.txtAverage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "AverageValue", true));
            this.txtAverage.Location = new System.Drawing.Point(534, 28);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 20);
            this.txtAverage.TabIndex = 53;
            this.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "пересчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt24);
            this.groupBox1.Controls.Add(this.txt23);
            this.groupBox1.Controls.Add(this.txt22);
            this.groupBox1.Controls.Add(this.txt21);
            this.groupBox1.Controls.Add(this.txt20);
            this.groupBox1.Controls.Add(this.txt19);
            this.groupBox1.Controls.Add(this.txt18);
            this.groupBox1.Controls.Add(this.txt17);
            this.groupBox1.Controls.Add(this.txt16);
            this.groupBox1.Controls.Add(this.txt15);
            this.groupBox1.Controls.Add(this.txt14);
            this.groupBox1.Controls.Add(this.txt13);
            this.groupBox1.Controls.Add(this.txt12);
            this.groupBox1.Controls.Add(this.txt11);
            this.groupBox1.Controls.Add(this.txt10);
            this.groupBox1.Controls.Add(this.txt9);
            this.groupBox1.Controls.Add(this.txt8);
            this.groupBox1.Controls.Add(this.txt7);
            this.groupBox1.Controls.Add(this.txt6);
            this.groupBox1.Controls.Add(this.txt5);
            this.groupBox1.Controls.Add(this.txt4);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(10, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 246);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Почасовые значения";
            // 
            // txt24
            // 
            this.txt24.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t24", true));
            this.txt24.Location = new System.Drawing.Point(591, 207);
            this.txt24.Name = "txt24";
            this.txt24.Size = new System.Drawing.Size(100, 20);
            this.txt24.TabIndex = 71;
            this.txt24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt24.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt23
            // 
            this.txt23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t23", true));
            this.txt23.Location = new System.Drawing.Point(478, 207);
            this.txt23.Name = "txt23";
            this.txt23.Size = new System.Drawing.Size(100, 20);
            this.txt23.TabIndex = 70;
            this.txt23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt22
            // 
            this.txt22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t22", true));
            this.txt22.Location = new System.Drawing.Point(365, 207);
            this.txt22.Name = "txt22";
            this.txt22.Size = new System.Drawing.Size(100, 20);
            this.txt22.TabIndex = 69;
            this.txt22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt21
            // 
            this.txt21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t21", true));
            this.txt21.Location = new System.Drawing.Point(252, 207);
            this.txt21.Name = "txt21";
            this.txt21.Size = new System.Drawing.Size(100, 20);
            this.txt21.TabIndex = 68;
            this.txt21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt20
            // 
            this.txt20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t20", true));
            this.txt20.Location = new System.Drawing.Point(139, 207);
            this.txt20.Name = "txt20";
            this.txt20.Size = new System.Drawing.Size(100, 20);
            this.txt20.TabIndex = 67;
            this.txt20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt19
            // 
            this.txt19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t19", true));
            this.txt19.Location = new System.Drawing.Point(26, 207);
            this.txt19.Name = "txt19";
            this.txt19.Size = new System.Drawing.Size(100, 20);
            this.txt19.TabIndex = 66;
            this.txt19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt18
            // 
            this.txt18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t18", true));
            this.txt18.Location = new System.Drawing.Point(591, 157);
            this.txt18.Name = "txt18";
            this.txt18.Size = new System.Drawing.Size(100, 20);
            this.txt18.TabIndex = 65;
            this.txt18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt17
            // 
            this.txt17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t17", true));
            this.txt17.Location = new System.Drawing.Point(478, 157);
            this.txt17.Name = "txt17";
            this.txt17.Size = new System.Drawing.Size(100, 20);
            this.txt17.TabIndex = 64;
            this.txt17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt16
            // 
            this.txt16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t16", true));
            this.txt16.Location = new System.Drawing.Point(365, 157);
            this.txt16.Name = "txt16";
            this.txt16.Size = new System.Drawing.Size(100, 20);
            this.txt16.TabIndex = 63;
            this.txt16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt15
            // 
            this.txt15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t15", true));
            this.txt15.Location = new System.Drawing.Point(252, 157);
            this.txt15.Name = "txt15";
            this.txt15.Size = new System.Drawing.Size(100, 20);
            this.txt15.TabIndex = 62;
            this.txt15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt14
            // 
            this.txt14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t14", true));
            this.txt14.Location = new System.Drawing.Point(139, 157);
            this.txt14.Name = "txt14";
            this.txt14.Size = new System.Drawing.Size(100, 20);
            this.txt14.TabIndex = 61;
            this.txt14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt13
            // 
            this.txt13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t13", true));
            this.txt13.Location = new System.Drawing.Point(26, 157);
            this.txt13.Name = "txt13";
            this.txt13.Size = new System.Drawing.Size(100, 20);
            this.txt13.TabIndex = 60;
            this.txt13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt12
            // 
            this.txt12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t12", true));
            this.txt12.Location = new System.Drawing.Point(591, 105);
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(100, 20);
            this.txt12.TabIndex = 59;
            this.txt12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt11
            // 
            this.txt11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t11", true));
            this.txt11.Location = new System.Drawing.Point(478, 105);
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(100, 20);
            this.txt11.TabIndex = 58;
            this.txt11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt10
            // 
            this.txt10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t10", true));
            this.txt10.Location = new System.Drawing.Point(365, 105);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(100, 20);
            this.txt10.TabIndex = 57;
            this.txt10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt9
            // 
            this.txt9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t9", true));
            this.txt9.Location = new System.Drawing.Point(252, 105);
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(100, 20);
            this.txt9.TabIndex = 56;
            this.txt9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt8
            // 
            this.txt8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t8", true));
            this.txt8.Location = new System.Drawing.Point(139, 105);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(100, 20);
            this.txt8.TabIndex = 55;
            this.txt8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt7
            // 
            this.txt7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t7", true));
            this.txt7.Location = new System.Drawing.Point(26, 105);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(100, 20);
            this.txt7.TabIndex = 54;
            this.txt7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt6
            // 
            this.txt6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t6", true));
            this.txt6.Location = new System.Drawing.Point(591, 50);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(100, 20);
            this.txt6.TabIndex = 53;
            this.txt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt5
            // 
            this.txt5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t5", true));
            this.txt5.Location = new System.Drawing.Point(478, 50);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 20);
            this.txt5.TabIndex = 52;
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt4
            // 
            this.txt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t4", true));
            this.txt4.Location = new System.Drawing.Point(365, 50);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 51;
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt3
            // 
            this.txt3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t3", true));
            this.txt3.Location = new System.Drawing.Point(252, 50);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 50;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt2
            // 
            this.txt2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t2", true));
            this.txt2.Location = new System.Drawing.Point(139, 50);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 49;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt1
            // 
            this.txt1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "t1", true));
            this.txt1.Location = new System.Drawing.Point(26, 50);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 48;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(631, 191);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "23-24";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(514, 191);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "22-23";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(402, 191);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "21-22";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(286, 191);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(34, 13);
            this.label25.TabIndex = 44;
            this.label25.Text = "20-21";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(172, 191);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 43;
            this.label26.Text = "19-20";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(57, 191);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 13);
            this.label27.TabIndex = 42;
            this.label27.Text = "18-19";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(631, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "17-18";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(514, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "16-17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(402, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "15-16";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(286, 141);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "14-15";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(172, 141);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "13-14";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(57, 141);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "12-13";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(631, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "11-12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(514, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "10-11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(402, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "09-10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(286, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "08-09";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(172, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "07-08";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "06-07";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(631, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "05-06";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "04-05";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "03-04";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "02-03";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "01-02";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "00-01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Среднее значение по выделенным часам:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(663, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(534, 375);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 48;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtComment
            // 
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "Comment", true));
            this.txtComment.Location = new System.Drawing.Point(107, 336);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(631, 20);
            this.txtComment.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Примечание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Дата замера:";
            // 
            // dtMeasur
            // 
            this.dtMeasur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasurObject_Edit, "DateOfIntroduction", true));
            this.dtMeasur.Location = new System.Drawing.Point(107, 28);
            this.dtMeasur.Name = "dtMeasur";
            this.dtMeasur.Size = new System.Drawing.Size(131, 20);
            this.dtMeasur.TabIndex = 44;
            this.dtMeasur.ValueChanged += new System.EventHandler(this.dtMeasur_ValueChanged);
            // 
            // FormMeasurementsOfObject_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 414);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtMeasur);
            this.Name = "FormMeasurementsOfObject_Edit";
            this.Load += new System.EventHandler(this.FormMeasurementsOfObject_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurObject_Edit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet.dsObj dsObj1;
        private System.Windows.Forms.BindingSource bsMeasurObject_Edit;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt24;
        private System.Windows.Forms.TextBox txt23;
        private System.Windows.Forms.TextBox txt22;
        private System.Windows.Forms.TextBox txt21;
        private System.Windows.Forms.TextBox txt20;
        private System.Windows.Forms.TextBox txt19;
        private System.Windows.Forms.TextBox txt18;
        private System.Windows.Forms.TextBox txt17;
        private System.Windows.Forms.TextBox txt16;
        private System.Windows.Forms.TextBox txt15;
        private System.Windows.Forms.TextBox txt14;
        private System.Windows.Forms.TextBox txt13;
        private System.Windows.Forms.TextBox txt12;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtMeasur;
    }
}