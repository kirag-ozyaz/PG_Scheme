namespace Legal.Forms.Prognosis
{
    partial class FormPrognosisMonthAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsAbn = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbn = new Legal.DataSet.DataSetAbn();
            this.AbnMiniDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.II = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.III = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prognosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrognosisMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.textBoxAbnSearch = new System.Windows.Forms.TextBox();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.cBoxPeriod = new System.Windows.Forms.ComboBox();
            this.bI = new System.Windows.Forms.Button();
            this.bII = new System.Windows.Forms.Button();
            this.bIII = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbnMiniDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // bsAbn
            // 
            this.bsAbn.DataMember = "vG_AbnPrognosis";
            this.bsAbn.DataSource = this.dsAbn;
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetAbn";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AbnMiniDGV
            // 
            this.AbnMiniDGV.AllowUserToAddRows = false;
            this.AbnMiniDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.AbnMiniDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AbnMiniDGV.AutoGenerateColumns = false;
            this.AbnMiniDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbnMiniDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.I,
            this.II,
            this.III,
            this.Prognosis,
            this.PrognosisMonth});
            this.AbnMiniDGV.DataSource = this.bsAbn;
            this.AbnMiniDGV.Location = new System.Drawing.Point(0, 35);
            this.AbnMiniDGV.Name = "AbnMiniDGV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AbnMiniDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AbnMiniDGV.RowHeadersWidth = 4;
            this.AbnMiniDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AbnMiniDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AbnMiniDGV.Size = new System.Drawing.Size(984, 537);
            this.AbnMiniDGV.TabIndex = 36;
            this.AbnMiniDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AbnMiniDGV_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // I
            // 
            this.I.DataPropertyName = "I";
            this.I.HeaderText = "I";
            this.I.Name = "I";
            // 
            // II
            // 
            this.II.DataPropertyName = "II";
            this.II.HeaderText = "II";
            this.II.Name = "II";
            // 
            // III
            // 
            this.III.DataPropertyName = "III";
            this.III.HeaderText = "III";
            this.III.Name = "III";
            // 
            // Prognosis
            // 
            this.Prognosis.DataPropertyName = "Prognosis";
            this.Prognosis.HeaderText = "Prognosis";
            this.Prognosis.Name = "Prognosis";
            // 
            // PrognosisMonth
            // 
            this.PrognosisMonth.DataPropertyName = "PrognosisMonth";
            this.PrognosisMonth.HeaderText = "PrognosisMonth";
            this.PrognosisMonth.Name = "PrognosisMonth";
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.DataSource = this.dsAbn;
            this.comboBoxWorker.DisplayMember = "vG_Contrl.F";
            this.comboBoxWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(773, 5);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(199, 24);
            this.comboBoxWorker.TabIndex = 37;
            this.comboBoxWorker.ValueMember = "vG_Contrl.id";
            this.comboBoxWorker.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorker_SelectedIndexChanged);
            // 
            // textBoxAbnSearch
            // 
            this.textBoxAbnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAbnSearch.Location = new System.Drawing.Point(12, 6);
            this.textBoxAbnSearch.Name = "textBoxAbnSearch";
            this.textBoxAbnSearch.Size = new System.Drawing.Size(100, 22);
            this.textBoxAbnSearch.TabIndex = 38;
            this.textBoxAbnSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAbnSearch_KeyUp);
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchName.Location = new System.Drawing.Point(128, 6);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(213, 22);
            this.textBoxSearchName.TabIndex = 39;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Image = global::Legal.Properties.Resources.Filtr_my;
            this.buttonSearch.Location = new System.Drawing.Point(347, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(34, 23);
            this.buttonSearch.TabIndex = 40;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // cBoxPeriod
            // 
            this.cBoxPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxPeriod.FormatString = "MMMM yyyy";
            this.cBoxPeriod.FormattingEnabled = true;
            this.cBoxPeriod.Location = new System.Drawing.Point(387, 6);
            this.cBoxPeriod.Name = "cBoxPeriod";
            this.cBoxPeriod.Size = new System.Drawing.Size(210, 24);
            this.cBoxPeriod.TabIndex = 41;
            // 
            // bI
            // 
            this.bI.Location = new System.Drawing.Point(631, 5);
            this.bI.Name = "bI";
            this.bI.Size = new System.Drawing.Size(38, 23);
            this.bI.TabIndex = 42;
            this.bI.Text = "I";
            this.bI.UseVisualStyleBackColor = true;
            this.bI.Click += new System.EventHandler(this.bI_Click);
            // 
            // bII
            // 
            this.bII.Location = new System.Drawing.Point(675, 5);
            this.bII.Name = "bII";
            this.bII.Size = new System.Drawing.Size(43, 23);
            this.bII.TabIndex = 43;
            this.bII.Text = "II";
            this.bII.UseVisualStyleBackColor = true;
            this.bII.Click += new System.EventHandler(this.bII_Click);
            // 
            // bIII
            // 
            this.bIII.Location = new System.Drawing.Point(724, 5);
            this.bIII.Name = "bIII";
            this.bIII.Size = new System.Drawing.Size(43, 23);
            this.bIII.TabIndex = 44;
            this.bIII.Text = "III";
            this.bIII.UseVisualStyleBackColor = true;
            this.bIII.Click += new System.EventHandler(this.bIII_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(805, 578);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 45;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(897, 577);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 46;
            this.bCancel.Text = "Выход";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // FormPrognosisMonthAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 604);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bIII);
            this.Controls.Add(this.bII);
            this.Controls.Add(this.bI);
            this.Controls.Add(this.cBoxPeriod);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchName);
            this.Controls.Add(this.textBoxAbnSearch);
            this.Controls.Add(this.comboBoxWorker);
            this.Controls.Add(this.AbnMiniDGV);
            this.Name = "FormPrognosisMonthAdd";
            this.Text = "Ввод прогнозируемых данных";
            this.Load += new System.EventHandler(this.FormPrognosisMonthAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbnMiniDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsAbn;
        private DataSet.DataSetAbn dsAbn;
        private System.Windows.Forms.DataGridView AbnMiniDGV;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.TextBox textBoxAbnSearch;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox cBoxPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn I;
        private System.Windows.Forms.DataGridViewTextBoxColumn II;
        private System.Windows.Forms.DataGridViewTextBoxColumn III;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prognosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrognosisMonth;
        private System.Windows.Forms.Button bI;
        private System.Windows.Forms.Button bII;
        private System.Windows.Forms.Button bIII;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
    }
}