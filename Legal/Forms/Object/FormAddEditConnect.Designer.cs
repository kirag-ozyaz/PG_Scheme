namespace Legal.Forms.Object
{
    partial class FormAddEditConnect
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
            this.txtPrim = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTP = new System.Windows.Forms.ComboBox();
            this.dsDop1 = new Legal.DataSet.dsDop();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbShina = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttoтSave = new System.Windows.Forms.Button();
            this.cmbCenter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numCell = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dsDop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCell)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrim
            // 
            this.txtPrim.Location = new System.Drawing.Point(89, 123);
            this.txtPrim.Name = "txtPrim";
            this.txtPrim.Size = new System.Drawing.Size(328, 83);
            this.txtPrim.TabIndex = 11;
            this.txtPrim.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Примечание:";
            // 
            // cmbTP
            // 
            this.cmbTP.DataSource = this.dsDop1;
            this.cmbTP.DisplayMember = "vSchm_ObjList.NameFull";
            this.cmbTP.FormattingEnabled = true;
            this.cmbTP.Location = new System.Drawing.Point(213, 66);
            this.cmbTP.Name = "cmbTP";
            this.cmbTP.Size = new System.Drawing.Size(100, 21);
            this.cmbTP.TabIndex = 9;
            this.cmbTP.ValueMember = "vSchm_ObjList.Id";
            this.cmbTP.SelectedIndexChanged += new System.EventHandler(this.cmbTP_SelectedIndexChanged);
            // 
            // dsDop1
            // 
            this.dsDop1.DataSetName = "dsDop";
            this.dsDop1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Подстанция:";
            // 
            // cmbShina
            // 
            this.cmbShina.FormattingEnabled = true;
            this.cmbShina.Location = new System.Drawing.Point(371, 66);
            this.cmbShina.Name = "cmbShina";
            this.cmbShina.Size = new System.Drawing.Size(46, 21);
            this.cmbShina.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Шина:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(342, 217);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Назад";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttoтSave
            // 
            this.buttoтSave.Location = new System.Drawing.Point(255, 217);
            this.buttoтSave.Name = "buttoтSave";
            this.buttoтSave.Size = new System.Drawing.Size(75, 23);
            this.buttoтSave.TabIndex = 13;
            this.buttoтSave.Text = "Сохранить";
            this.buttoтSave.UseVisualStyleBackColor = true;
            this.buttoтSave.Click += new System.EventHandler(this.buttoтSave_Click);
            // 
            // cmbCenter
            // 
            this.cmbCenter.DataSource = this.dsDop1;
            this.cmbCenter.DisplayMember = "tSchm_ObjList.Name";
            this.cmbCenter.FormattingEnabled = true;
            this.cmbCenter.Location = new System.Drawing.Point(117, 22);
            this.cmbCenter.Name = "cmbCenter";
            this.cmbCenter.Size = new System.Drawing.Size(300, 21);
            this.cmbCenter.TabIndex = 14;
            this.cmbCenter.ValueMember = "tSchm_ObjList.Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Питающий центр:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ячейка:";
            // 
            // numCell
            // 
            this.numCell.Location = new System.Drawing.Point(68, 67);
            this.numCell.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCell.Name = "numCell";
            this.numCell.Size = new System.Drawing.Size(47, 20);
            this.numCell.TabIndex = 17;
            // 
            // FormAddEditConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 252);
            this.Controls.Add(this.numCell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCenter);
            this.Controls.Add(this.buttoтSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.txtPrim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbShina);
            this.Controls.Add(this.label5);
            this.Name = "FormAddEditConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение";
            this.Load += new System.EventHandler(this.FormAddEditConnect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtPrim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbShina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttoтSave;
        private System.Windows.Forms.ComboBox cmbCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCell;
        private DataSet.dsDop dsDop1;
    }
}