namespace Legal.Forms.Meter
{
    partial class FormNewPoint
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
            this.dateTimePickerBeg = new System.Windows.Forms.DateTimePicker();
            this.NUDN = new System.Windows.Forms.NumericUpDown();
            this.lLocation = new System.Windows.Forms.Label();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.bIns = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.dsPoint = new Legal.DataSet.DataSetAbn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelN = new System.Windows.Forms.Label();
            this.labelDateBeg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPoint)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerBeg
            // 
            this.dateTimePickerBeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBeg.Location = new System.Drawing.Point(136, 37);
            this.dateTimePickerBeg.Name = "dateTimePickerBeg";
            this.dateTimePickerBeg.Size = new System.Drawing.Size(192, 26);
            this.dateTimePickerBeg.TabIndex = 38;
            // 
            // NUDN
            // 
            this.NUDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NUDN.Location = new System.Drawing.Point(53, 37);
            this.NUDN.Name = "NUDN";
            this.NUDN.Size = new System.Drawing.Size(55, 26);
            this.NUDN.TabIndex = 54;
            // 
            // lLocation
            // 
            this.lLocation.AutoSize = true;
            this.lLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLocation.Location = new System.Drawing.Point(14, 62);
            this.lLocation.Name = "lLocation";
            this.lLocation.Size = new System.Drawing.Size(132, 20);
            this.lLocation.TabIndex = 57;
            this.lLocation.Text = "Расположение";
            // 
            // rtbLocation
            // 
            this.rtbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbLocation.Location = new System.Drawing.Point(14, 85);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.Size = new System.Drawing.Size(317, 52);
            this.rtbLocation.TabIndex = 58;
            this.rtbLocation.Text = "";
            // 
            // bIns
            // 
            this.bIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bIns.Location = new System.Drawing.Point(173, 145);
            this.bIns.Name = "bIns";
            this.bIns.Size = new System.Drawing.Size(75, 31);
            this.bIns.TabIndex = 59;
            this.bIns.Text = "Внести";
            this.bIns.UseVisualStyleBackColor = true;
            this.bIns.Click += new System.EventHandler(this.bIns_Click);
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(254, 145);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 31);
            this.bCancel.TabIndex = 60;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // dsPoint
            // 
            this.dsPoint.DataSetName = "DataSetAbn";
            this.dsPoint.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelN);
            this.groupBox1.Controls.Add(this.labelDateBeg);
            this.groupBox1.Controls.Add(this.rtbLocation);
            this.groupBox1.Controls.Add(this.lLocation);
            this.groupBox1.Controls.Add(this.NUDN);
            this.groupBox1.Controls.Add(this.dateTimePickerBeg);
            this.groupBox1.Location = new System.Drawing.Point(1, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 144);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(49, 14);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(25, 20);
            this.labelN.TabIndex = 60;
            this.labelN.Text = "№";
            // 
            // labelDateBeg
            // 
            this.labelDateBeg.AutoSize = true;
            this.labelDateBeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateBeg.Location = new System.Drawing.Point(132, 14);
            this.labelDateBeg.Name = "labelDateBeg";
            this.labelDateBeg.Size = new System.Drawing.Size(118, 20);
            this.labelDateBeg.TabIndex = 59;
            this.labelDateBeg.Text = "Дата начала";
            // 
            // FormNewPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 181);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bIns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новая точка учета";
            ((System.ComponentModel.ISupportInitialize)(this.NUDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPoint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerBeg;
        private System.Windows.Forms.NumericUpDown NUDN;
        private System.Windows.Forms.Label lLocation;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.Button bIns;
        private System.Windows.Forms.Button bCancel;
        private DataSet.DataSetAbn dsPoint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelDateBeg;
    }
}