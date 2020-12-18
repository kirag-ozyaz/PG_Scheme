namespace Legal.Forms.Object
{
    partial class FormObjFlagAdd
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
            this.bsObjFlags = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbn = new Legal.DataSet.DataSetAbn();
            this.comboBoxFlagsName = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelFlag = new System.Windows.Forms.Label();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.labelFlagDate = new System.Windows.Forms.Label();
            this.buttonFlagAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsObjFlags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            this.SuspendLayout();
            // 
            // bsObjFlags
            // 
            this.bsObjFlags.DataMember = "vG_ObjFlagsName";
            this.bsObjFlags.DataSource = this.dsAbn;
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetAbn";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxFlagsName
            // 
            this.comboBoxFlagsName.DataSource = this.bsObjFlags;
            this.comboBoxFlagsName.DisplayMember = "Name";
            this.comboBoxFlagsName.FormattingEnabled = true;
            this.comboBoxFlagsName.Location = new System.Drawing.Point(12, 36);
            this.comboBoxFlagsName.Name = "comboBoxFlagsName";
            this.comboBoxFlagsName.Size = new System.Drawing.Size(260, 21);
            this.comboBoxFlagsName.TabIndex = 0;
            this.comboBoxFlagsName.ValueMember = "Id";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(197, 136);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelFlag
            // 
            this.labelFlag.AutoSize = true;
            this.labelFlag.Location = new System.Drawing.Point(13, 13);
            this.labelFlag.Name = "labelFlag";
            this.labelFlag.Size = new System.Drawing.Size(134, 13);
            this.labelFlag.TabIndex = 2;
            this.labelFlag.Text = "Наименование признака";
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Location = new System.Drawing.Point(12, 96);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(260, 20);
            this.dateTimePickerBegin.TabIndex = 3;
            // 
            // labelFlagDate
            // 
            this.labelFlagDate.AutoSize = true;
            this.labelFlagDate.Location = new System.Drawing.Point(13, 70);
            this.labelFlagDate.Name = "labelFlagDate";
            this.labelFlagDate.Size = new System.Drawing.Size(121, 13);
            this.labelFlagDate.TabIndex = 4;
            this.labelFlagDate.Text = "Дата начала действия";
            // 
            // buttonFlagAdd
            // 
            this.buttonFlagAdd.Location = new System.Drawing.Point(12, 136);
            this.buttonFlagAdd.Name = "buttonFlagAdd";
            this.buttonFlagAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonFlagAdd.TabIndex = 5;
            this.buttonFlagAdd.Text = "Добавить";
            this.buttonFlagAdd.UseVisualStyleBackColor = true;
            this.buttonFlagAdd.Click += new System.EventHandler(this.buttonFlagAdd_Click);
            // 
            // FormObjFlagAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.buttonFlagAdd);
            this.Controls.Add(this.labelFlagDate);
            this.Controls.Add(this.dateTimePickerBegin);
            this.Controls.Add(this.labelFlag);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.comboBoxFlagsName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormObjFlagAdd";
            this.Text = "Добавить признак объекта";
            this.Load += new System.EventHandler(this.FormObjFlagAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsObjFlags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsObjFlags;
        private DataSet.DataSetAbn dsAbn;
        private System.Windows.Forms.ComboBox comboBoxFlagsName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelFlag;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.Label labelFlagDate;
        private System.Windows.Forms.Button buttonFlagAdd;
    }
}