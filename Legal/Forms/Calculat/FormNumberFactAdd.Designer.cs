namespace Legal.Forms.Calculat
{
    partial class FormNumberFactAdd
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
            this.dsCalc1 = new Legal.DataSet.dsCalc();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbMonth = new System.Windows.Forms.TextBox();
            this.cbYear = new System.Windows.Forms.TextBox();
            this.txtNumberMin = new System.Windows.Forms.NumericUpDown();
            this.txtNumberMax = new System.Windows.Forms.NumericUpDown();
            this.txtNumberCurrent = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // dsCalc1
            // 
            this.dsCalc1.DataSetName = "dsCalc";
            this.dsCalc1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Месяц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Начало диапазона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Конец диапазона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Текущий номер:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(70, 189);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(185, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отказаться";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbMonth
            // 
            this.cbMonth.Enabled = false;
            this.cbMonth.Location = new System.Drawing.Point(19, 25);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(120, 20);
            this.cbMonth.TabIndex = 18;
            // 
            // cbYear
            // 
            this.cbYear.Enabled = false;
            this.cbYear.Location = new System.Drawing.Point(161, 25);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(120, 20);
            this.cbYear.TabIndex = 19;
            // 
            // txtNumberMin
            // 
            this.txtNumberMin.Location = new System.Drawing.Point(19, 81);
            this.txtNumberMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtNumberMin.Name = "txtNumberMin";
            this.txtNumberMin.Size = new System.Drawing.Size(120, 20);
            this.txtNumberMin.TabIndex = 0;
            this.txtNumberMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumberMin.ValueChanged += new System.EventHandler(this.txtNumberMin_ValueChanged);
            // 
            // txtNumberMax
            // 
            this.txtNumberMax.Location = new System.Drawing.Point(161, 81);
            this.txtNumberMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtNumberMax.Name = "txtNumberMax";
            this.txtNumberMax.Size = new System.Drawing.Size(120, 20);
            this.txtNumberMax.TabIndex = 1;
            this.txtNumberMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumberCurrent
            // 
            this.txtNumberCurrent.Enabled = false;
            this.txtNumberCurrent.Location = new System.Drawing.Point(19, 136);
            this.txtNumberCurrent.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtNumberCurrent.Name = "txtNumberCurrent";
            this.txtNumberCurrent.Size = new System.Drawing.Size(120, 20);
            this.txtNumberCurrent.TabIndex = 22;
            this.txtNumberCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormNumberFactAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(303, 227);
            this.Controls.Add(this.txtNumberCurrent);
            this.Controls.Add(this.txtNumberMax);
            this.Controls.Add(this.txtNumberMin);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNumberFactAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый диапазон";
            this.Load += new System.EventHandler(this.FormNumberFactAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberCurrent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet.dsCalc dsCalc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox cbMonth;
        private System.Windows.Forms.TextBox cbYear;
        private System.Windows.Forms.NumericUpDown txtNumberMin;
        private System.Windows.Forms.NumericUpDown txtNumberMax;
        private System.Windows.Forms.NumericUpDown txtNumberCurrent;
    }
}