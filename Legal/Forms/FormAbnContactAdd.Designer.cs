namespace Legal.Forms
{
    partial class FormAbnContactAdd
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
            System.Windows.Forms.Label fLabel;
            System.Windows.Forms.Label iLabel;
            System.Windows.Forms.Label oLabel;
            System.Windows.Forms.Label dateChangeLabel;
            this.fTextBox = new System.Windows.Forms.TextBox();
            this.dsAbn = new Legal.DataSet.DataSetAbn();
            this.iTextBox = new System.Windows.Forms.TextBox();
            this.oTextBox = new System.Windows.Forms.TextBox();
            this.dateChangeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.richTextBoxPost = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPhone = new System.Windows.Forms.RichTextBox();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.groupBoxPost = new System.Windows.Forms.GroupBox();
            this.groupBoxPhone = new System.Windows.Forms.GroupBox();
            this.groupBoxComment = new System.Windows.Forms.GroupBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.lemail = new System.Windows.Forms.Label();
            fLabel = new System.Windows.Forms.Label();
            iLabel = new System.Windows.Forms.Label();
            oLabel = new System.Windows.Forms.Label();
            dateChangeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            this.groupBoxPost.SuspendLayout();
            this.groupBoxPhone.SuspendLayout();
            this.groupBoxComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // fLabel
            // 
            fLabel.AutoSize = true;
            fLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fLabel.Location = new System.Drawing.Point(11, 96);
            fLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fLabel.Name = "fLabel";
            fLabel.Size = new System.Drawing.Size(67, 13);
            fLabel.TabIndex = 2;
            fLabel.Text = "Фамилия:";
            // 
            // iLabel
            // 
            iLabel.AutoSize = true;
            iLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iLabel.Location = new System.Drawing.Point(38, 126);
            iLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iLabel.Name = "iLabel";
            iLabel.Size = new System.Drawing.Size(36, 13);
            iLabel.TabIndex = 4;
            iLabel.Text = "Имя:";
            // 
            // oLabel
            // 
            oLabel.AutoSize = true;
            oLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            oLabel.Location = new System.Drawing.Point(8, 150);
            oLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            oLabel.Name = "oLabel";
            oLabel.Size = new System.Drawing.Size(66, 13);
            oLabel.TabIndex = 6;
            oLabel.Text = "Отчество:";
            // 
            // dateChangeLabel
            // 
            dateChangeLabel.AutoSize = true;
            dateChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateChangeLabel.Location = new System.Drawing.Point(33, 366);
            dateChangeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateChangeLabel.Name = "dateChangeLabel";
            dateChangeLabel.Size = new System.Drawing.Size(41, 13);
            dateChangeLabel.TabIndex = 10;
            dateChangeLabel.Text = "Дата:";
            // 
            // fTextBox
            // 
            this.fTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbn, "tAbnContact.F", true));
            this.fTextBox.Location = new System.Drawing.Point(87, 93);
            this.fTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fTextBox.Name = "fTextBox";
            this.fTextBox.Size = new System.Drawing.Size(229, 20);
            this.fTextBox.TabIndex = 3;
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetAbn";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTextBox
            // 
            this.iTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbn, "tAbnContact.I", true));
            this.iTextBox.Location = new System.Drawing.Point(87, 119);
            this.iTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iTextBox.Name = "iTextBox";
            this.iTextBox.Size = new System.Drawing.Size(229, 20);
            this.iTextBox.TabIndex = 5;
            // 
            // oTextBox
            // 
            this.oTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbn, "tAbnContact.O", true));
            this.oTextBox.Location = new System.Drawing.Point(87, 143);
            this.oTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.oTextBox.Name = "oTextBox";
            this.oTextBox.Size = new System.Drawing.Size(229, 20);
            this.oTextBox.TabIndex = 7;
            // 
            // dateChangeDateTimePicker
            // 
            this.dateChangeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsAbn, "tAbnContact.DateChange", true));
            this.dateChangeDateTimePicker.Location = new System.Drawing.Point(87, 363);
            this.dateChangeDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateChangeDateTimePicker.Name = "dateChangeDateTimePicker";
            this.dateChangeDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.dateChangeDateTimePicker.TabIndex = 11;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(247, 393);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(163, 393);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "Сохранить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // richTextBoxPost
            // 
            this.richTextBoxPost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbn, "tAbnContact.Post", true));
            this.richTextBoxPost.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxPost.Name = "richTextBoxPost";
            this.richTextBoxPost.Size = new System.Drawing.Size(307, 43);
            this.richTextBoxPost.TabIndex = 16;
            this.richTextBoxPost.Text = "";
            // 
            // richTextBoxPhone
            // 
            this.richTextBoxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbn, "tAbnContact.Phone", true));
            this.richTextBoxPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxPhone.Location = new System.Drawing.Point(3, 16);
            this.richTextBoxPhone.Name = "richTextBoxPhone";
            this.richTextBoxPhone.Size = new System.Drawing.Size(313, 30);
            this.richTextBoxPhone.TabIndex = 17;
            this.richTextBoxPhone.Text = "";
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbn, "tAbnContact.Comment", true));
            this.richTextBoxComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxComment.Location = new System.Drawing.Point(3, 16);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(313, 77);
            this.richTextBoxComment.TabIndex = 18;
            this.richTextBoxComment.Text = "";
            // 
            // groupBoxPost
            // 
            this.groupBoxPost.Controls.Add(this.richTextBoxPost);
            this.groupBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPost.Location = new System.Drawing.Point(3, 10);
            this.groupBoxPost.Name = "groupBoxPost";
            this.groupBoxPost.Size = new System.Drawing.Size(319, 78);
            this.groupBoxPost.TabIndex = 19;
            this.groupBoxPost.TabStop = false;
            this.groupBoxPost.Text = "Должность";
            // 
            // groupBoxPhone
            // 
            this.groupBoxPhone.Controls.Add(this.richTextBoxPhone);
            this.groupBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPhone.Location = new System.Drawing.Point(3, 168);
            this.groupBoxPhone.Name = "groupBoxPhone";
            this.groupBoxPhone.Size = new System.Drawing.Size(319, 49);
            this.groupBoxPhone.TabIndex = 20;
            this.groupBoxPhone.TabStop = false;
            this.groupBoxPhone.Text = "Телефоны";
            // 
            // groupBoxComment
            // 
            this.groupBoxComment.Controls.Add(this.richTextBoxComment);
            this.groupBoxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxComment.Location = new System.Drawing.Point(3, 254);
            this.groupBoxComment.Name = "groupBoxComment";
            this.groupBoxComment.Size = new System.Drawing.Size(319, 96);
            this.groupBoxComment.TabIndex = 21;
            this.groupBoxComment.TabStop = false;
            this.groupBoxComment.Text = "Примечание";
            // 
            // tbemail
            // 
            this.tbemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsAbn, "tAbnContact.email", true));
            this.tbemail.Location = new System.Drawing.Point(87, 226);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(229, 20);
            this.tbemail.TabIndex = 22;
            // 
            // lemail
            // 
            this.lemail.AutoSize = true;
            this.lemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lemail.Location = new System.Drawing.Point(25, 229);
            this.lemail.Name = "lemail";
            this.lemail.Size = new System.Drawing.Size(49, 13);
            this.lemail.TabIndex = 23;
            this.lemail.Text = "E-mail :";
            // 
            // FormAbnContactAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 424);
            this.Controls.Add(this.lemail);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.groupBoxComment);
            this.Controls.Add(this.groupBoxPhone);
            this.Controls.Add(this.groupBoxPost);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(dateChangeLabel);
            this.Controls.Add(this.dateChangeDateTimePicker);
            this.Controls.Add(oLabel);
            this.Controls.Add(this.oTextBox);
            this.Controls.Add(iLabel);
            this.Controls.Add(this.iTextBox);
            this.Controls.Add(fLabel);
            this.Controls.Add(this.fTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbnContactAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormAbnContactAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            this.groupBoxPost.ResumeLayout(false);
            this.groupBoxPhone.ResumeLayout(false);
            this.groupBoxComment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fTextBox;
        private System.Windows.Forms.TextBox iTextBox;
        private System.Windows.Forms.TextBox oTextBox;
        private System.Windows.Forms.DateTimePicker dateChangeDateTimePicker;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.RichTextBox richTextBoxPost;
        private System.Windows.Forms.RichTextBox richTextBoxPhone;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.GroupBox groupBoxPost;
        private System.Windows.Forms.GroupBox groupBoxPhone;
        private System.Windows.Forms.GroupBox groupBoxComment;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label lemail;
        private DataSet.DataSetAbn dsAbn;
    }
}