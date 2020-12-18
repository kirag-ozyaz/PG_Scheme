namespace Legal.Forms.Meter
{
    partial class FormPointKLoss
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
            this.dtDateChange = new System.Windows.Forms.DateTimePicker();
            this.numKLoss = new System.Windows.Forms.NumericUpDown();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dsAbn = new Legal.DataSet.DataSetAbn();
            ((System.ComponentModel.ISupportInitialize)(this.numKLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDateChange
            // 
            this.dtDateChange.Location = new System.Drawing.Point(122, 19);
            this.dtDateChange.Name = "dtDateChange";
            this.dtDateChange.Size = new System.Drawing.Size(200, 20);
            this.dtDateChange.TabIndex = 0;
            // 
            // numKLoss
            // 
            this.numKLoss.DecimalPlaces = 3;
            this.numKLoss.Location = new System.Drawing.Point(88, 74);
            this.numKLoss.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numKLoss.Name = "numKLoss";
            this.numKLoss.Size = new System.Drawing.Size(120, 20);
            this.numKLoss.TabIndex = 1;
            this.numKLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(24, 144);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(482, 54);
            this.txtComment.TabIndex = 2;
            this.txtComment.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(304, 211);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(414, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Выход:";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата изменения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Потери(%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Примечание:";
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetAbn";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormPointKLoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(518, 246);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.numKLoss);
            this.Controls.Add(this.dtDateChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPointKLoss";
            this.Text = "Потери электроэнергии холостого хода в силовом трансформаторе";
            this.Load += new System.EventHandler(this.FormPointKLoss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKLoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDateChange;
        private System.Windows.Forms.NumericUpDown numKLoss;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DataSet.DataSetAbn dsAbn;
    }
}