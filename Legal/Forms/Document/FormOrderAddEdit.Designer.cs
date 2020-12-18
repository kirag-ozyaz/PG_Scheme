namespace Legal.Forms.Document
{
    partial class FormOrderAddEdit
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
            this.dsAbnDocum1 = new Legal.DataSet.dsAbnDocum();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtAbn = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtNumObj = new System.Windows.Forms.TextBox();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTypeMeter = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtGosMeter = new System.Windows.Forms.TextBox();
            this.txtGosTr = new System.Windows.Forms.TextBox();
            this.txtKtr = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtAct = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsAbnDocum1
            // 
            this.dsAbnDocum1.DataSetName = "dsAbnDocum";
            this.dsAbnDocum1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(597, 364);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(689, 364);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Выйти";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDocum1, "tOrdersInspection.CodeAbonent", true));
            this.txtCode.Location = new System.Drawing.Point(96, 21);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(84, 20);
            this.txtCode.TabIndex = 2;
            // 
            // txtAbn
            // 
            this.txtAbn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDocum1, "tOrdersInspection.Name", true));
            this.txtAbn.Location = new System.Drawing.Point(287, 21);
            this.txtAbn.Name = "txtAbn";
            this.txtAbn.Size = new System.Drawing.Size(477, 20);
            this.txtAbn.TabIndex = 3;
            // 
            // txtContact
            // 
            this.txtContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDocum1, "tOrdersInspection.AbnPhone", true));
            this.txtContact.Location = new System.Drawing.Point(96, 61);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(668, 20);
            this.txtContact.TabIndex = 4;
            // 
            // txtNumObj
            // 
            this.txtNumObj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDocum1, "tOrdersInspection.NumberObj", true));
            this.txtNumObj.Location = new System.Drawing.Point(96, 109);
            this.txtNumObj.Name = "txtNumObj";
            this.txtNumObj.Size = new System.Drawing.Size(81, 20);
            this.txtNumObj.TabIndex = 5;
            // 
            // txtObject
            // 
            this.txtObject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDocum1, "tOrdersInspection.NameObj", true));
            this.txtObject.Location = new System.Drawing.Point(287, 109);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(477, 20);
            this.txtObject.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDocum1, "tOrdersInspection.ObjAdress", true));
            this.txtAddress.Location = new System.Drawing.Point(96, 155);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(668, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // txtTypeMeter
            // 
            this.txtTypeMeter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDocum1, "tOrdersInspection.NameMeter", true));
            this.txtTypeMeter.Location = new System.Drawing.Point(96, 201);
            this.txtTypeMeter.Name = "txtTypeMeter";
            this.txtTypeMeter.Size = new System.Drawing.Size(384, 20);
            this.txtTypeMeter.TabIndex = 8;
            // 
            // txtNumber
            // 
            this.txtNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDocum1, "tOrdersInspection.Number", true));
            this.txtNumber.Location = new System.Drawing.Point(623, 201);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(141, 20);
            this.txtNumber.TabIndex = 9;
            // 
            // txtGosMeter
            // 
            this.txtGosMeter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDocum1, "tOrdersInspection.GosEndMeter", true));
            this.txtGosMeter.Location = new System.Drawing.Point(96, 251);
            this.txtGosMeter.Name = "txtGosMeter";
            this.txtGosMeter.Size = new System.Drawing.Size(100, 20);
            this.txtGosMeter.TabIndex = 10;
            // 
            // txtGosTr
            // 
            this.txtGosTr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDocum1, "tOrdersInspection.GosEndTrans", true));
            this.txtGosTr.Location = new System.Drawing.Point(380, 251);
            this.txtGosTr.Name = "txtGosTr";
            this.txtGosTr.Size = new System.Drawing.Size(100, 20);
            this.txtGosTr.TabIndex = 11;
            // 
            // txtKtr
            // 
            this.txtKtr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDocum1, "tOrdersInspection.Ktran", true));
            this.txtKtr.Location = new System.Drawing.Point(623, 251);
            this.txtKtr.Name = "txtKtr";
            this.txtKtr.Size = new System.Drawing.Size(140, 20);
            this.txtKtr.TabIndex = 12;
            // 
            // txtValue
            // 
            this.txtValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDocum1, "tOrdersInspection.Values", true));
            this.txtValue.Location = new System.Drawing.Point(96, 301);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(384, 20);
            this.txtValue.TabIndex = 13;
            // 
            // txtPower
            // 
            this.txtPower.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbnDocum1, "tOrdersInspection.PowerSet", true));
            this.txtPower.Location = new System.Drawing.Point(624, 301);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(140, 20);
            this.txtPower.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Код:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Потребитель:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Контакты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "№ объекта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Объект:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Адрес:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Тип прибора:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Номер:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "ГП счетчика:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "ГП трансформ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(580, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "К тр:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Показания:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Дата акта:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(540, 308);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "P установки:";
            // 
            // dtAct
            // 
            this.dtAct.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsAbnDocum1, "tOrdersInspection.DateAct", true));
            this.dtAct.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAct.Location = new System.Drawing.Point(96, 345);
            this.dtAct.Name = "dtAct";
            this.dtAct.Size = new System.Drawing.Size(159, 20);
            this.dtAct.TabIndex = 29;
            // 
            // FormOrderAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 411);
            this.Controls.Add(this.dtAct);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKtr);
            this.Controls.Add(this.txtGosTr);
            this.Controls.Add(this.txtGosMeter);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtTypeMeter);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtObject);
            this.Controls.Add(this.txtNumObj);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtAbn);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Name = "FormOrderAddEdit";
            this.Load += new System.EventHandler(this.FormOrderAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet.dsAbnDocum dsAbnDocum1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtAbn;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtNumObj;
        private System.Windows.Forms.TextBox txtObject;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTypeMeter;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtGosMeter;
        private System.Windows.Forms.TextBox txtGosTr;
        private System.Windows.Forms.TextBox txtKtr;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtAct;
    }
}