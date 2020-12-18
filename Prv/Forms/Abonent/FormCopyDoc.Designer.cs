namespace Prv.Forms.Abonent
{
    partial class FormCopyDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCopyDoc));
            this.comboBoxObj = new System.Windows.Forms.ComboBox();
            this.dsAbn = new Prv.DataSets.DataSetPrv();
            this.labelObj = new System.Windows.Forms.Label();
            this.labelTypeDoc = new System.Windows.Forms.Label();
            this.buttonAbnSearch = new System.Windows.Forms.Button();
            this.labelAbn = new System.Windows.Forms.Label();
            this.labelDateBeg = new System.Windows.Forms.Label();
            this.dtpDateBeg = new System.Windows.Forms.DateTimePicker();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelZone = new System.Windows.Forms.Label();
            this.comboBoxZone = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeDoc = new System.Windows.Forms.ComboBox();
            this.tbAbn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxObj
            // 
            this.comboBoxObj.DataSource = this.dsAbn;
            this.comboBoxObj.DisplayMember = "vAbnObjPointName.namePoint";
            this.comboBoxObj.FormattingEnabled = true;
            this.comboBoxObj.Location = new System.Drawing.Point(12, 78);
            this.comboBoxObj.Name = "comboBoxObj";
            this.comboBoxObj.Size = new System.Drawing.Size(288, 21);
            this.comboBoxObj.TabIndex = 0;
            this.comboBoxObj.ValueMember = "vAbnObjPointName.idPoint";
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetPrv";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelObj
            // 
            this.labelObj.AutoSize = true;
            this.labelObj.Location = new System.Drawing.Point(9, 62);
            this.labelObj.Name = "labelObj";
            this.labelObj.Size = new System.Drawing.Size(45, 13);
            this.labelObj.TabIndex = 2;
            this.labelObj.Text = "Объект";
            // 
            // labelTypeDoc
            // 
            this.labelTypeDoc.AutoSize = true;
            this.labelTypeDoc.Location = new System.Drawing.Point(9, 102);
            this.labelTypeDoc.Name = "labelTypeDoc";
            this.labelTypeDoc.Size = new System.Drawing.Size(140, 13);
            this.labelTypeDoc.TabIndex = 3;
            this.labelTypeDoc.Text = "Наименование документа";
            // 
            // buttonAbnSearch
            // 
            this.buttonAbnSearch.Location = new System.Drawing.Point(225, 25);
            this.buttonAbnSearch.Name = "buttonAbnSearch";
            this.buttonAbnSearch.Size = new System.Drawing.Size(75, 29);
            this.buttonAbnSearch.TabIndex = 5;
            this.buttonAbnSearch.Text = "Найти";
            this.buttonAbnSearch.UseVisualStyleBackColor = true;
            this.buttonAbnSearch.Click += new System.EventHandler(this.buttonAbnSearch_Click);
            // 
            // labelAbn
            // 
            this.labelAbn.AutoSize = true;
            this.labelAbn.Location = new System.Drawing.Point(9, 9);
            this.labelAbn.Name = "labelAbn";
            this.labelAbn.Size = new System.Drawing.Size(49, 13);
            this.labelAbn.TabIndex = 6;
            this.labelAbn.Text = "Абонент";
            // 
            // labelDateBeg
            // 
            this.labelDateBeg.AutoSize = true;
            this.labelDateBeg.Location = new System.Drawing.Point(9, 200);
            this.labelDateBeg.Name = "labelDateBeg";
            this.labelDateBeg.Size = new System.Drawing.Size(71, 13);
            this.labelDateBeg.TabIndex = 7;
            this.labelDateBeg.Text = "Дата начала";
            // 
            // dtpDateBeg
            // 
            this.dtpDateBeg.Location = new System.Drawing.Point(12, 217);
            this.dtpDateBeg.Name = "dtpDateBeg";
            this.dtpDateBeg.Size = new System.Drawing.Size(137, 20);
            this.dtpDateBeg.TabIndex = 8;
            this.dtpDateBeg.Value = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Location = new System.Drawing.Point(166, 217);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(137, 20);
            this.dtpDateEnd.TabIndex = 9;
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(163, 200);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(89, 13);
            this.labelDateEnd.TabIndex = 10;
            this.labelDateEnd.Text = "Дата окончания";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(13, 261);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 11;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(228, 261);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelZone
            // 
            this.labelZone.AutoSize = true;
            this.labelZone.Location = new System.Drawing.Point(12, 146);
            this.labelZone.Name = "labelZone";
            this.labelZone.Size = new System.Drawing.Size(32, 13);
            this.labelZone.TabIndex = 15;
            this.labelZone.Text = "Зона";
            // 
            // comboBoxZone
            // 
            this.comboBoxZone.DataSource = this.dsAbn;
            this.comboBoxZone.DisplayMember = "vR_Zone.SubZoneName";
            this.comboBoxZone.FormattingEnabled = true;
            this.comboBoxZone.Location = new System.Drawing.Point(13, 162);
            this.comboBoxZone.Name = "comboBoxZone";
            this.comboBoxZone.Size = new System.Drawing.Size(287, 21);
            this.comboBoxZone.TabIndex = 16;
            this.comboBoxZone.ValueMember = "vR_Zone.IdSubZoneName";
            // 
            // comboBoxTypeDoc
            // 
            this.comboBoxTypeDoc.DataSource = this.dsAbn;
            this.comboBoxTypeDoc.DisplayMember = "tR_Classifier.Name";
            this.comboBoxTypeDoc.FormattingEnabled = true;
            this.comboBoxTypeDoc.Location = new System.Drawing.Point(12, 118);
            this.comboBoxTypeDoc.Name = "comboBoxTypeDoc";
            this.comboBoxTypeDoc.Size = new System.Drawing.Size(288, 21);
            this.comboBoxTypeDoc.TabIndex = 1;
            this.comboBoxTypeDoc.ValueMember = "tR_Classifier.Id";
            // 
            // tbAbn
            // 
            this.tbAbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAbn.Location = new System.Drawing.Point(12, 25);
            this.tbAbn.Name = "tbAbn";
            this.tbAbn.Size = new System.Drawing.Size(207, 29);
            this.tbAbn.TabIndex = 18;
            this.tbAbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAbn_KeyDown);
            // 
            // FormCopyDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 300);
            this.Controls.Add(this.tbAbn);
            this.Controls.Add(this.comboBoxZone);
            this.Controls.Add(this.labelZone);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.labelDateEnd);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.dtpDateBeg);
            this.Controls.Add(this.labelDateBeg);
            this.Controls.Add(this.labelAbn);
            this.Controls.Add(this.buttonAbnSearch);
            this.Controls.Add(this.labelTypeDoc);
            this.Controls.Add(this.labelObj);
            this.Controls.Add(this.comboBoxTypeDoc);
            this.Controls.Add(this.comboBoxObj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCopyDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Копирование документов";
            this.Load += new System.EventHandler(this.FormCopyDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxObj;
        private System.Windows.Forms.ComboBox comboBoxTypeDoc;
        private System.Windows.Forms.Label labelObj;
        private System.Windows.Forms.Label labelTypeDoc;
        private System.Windows.Forms.Button buttonAbnSearch;
        private System.Windows.Forms.Label labelAbn;
        private System.Windows.Forms.Label labelDateBeg;
        private System.Windows.Forms.DateTimePicker dtpDateBeg;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCancel;
        private DataSets.DataSetPrv dsAbn;
        private System.Windows.Forms.Label labelZone;
        private System.Windows.Forms.ComboBox comboBoxZone;
        private System.Windows.Forms.TextBox tbAbn;
    }
}