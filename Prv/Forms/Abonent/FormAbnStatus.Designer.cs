namespace Prv.Forms.Abonent
{
    partial class FormAbnStatus
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
            System.Windows.Forms.Label dateChangeLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGVEFStat = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReasonDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateChangeDGrVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDGVCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSAbnStat = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbn = new Prv.DataSets.DataSetPrv();
            this.dTPStat = new System.Windows.Forms.DateTimePicker();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idReasonComboBox = new System.Windows.Forms.ComboBox();
            this.radioButtonEdit = new System.Windows.Forms.RadioButton();
            this.radioButtonNew = new System.Windows.Forms.RadioButton();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            dateChangeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEFStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSAbnStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            this.SuspendLayout();
            // 
            // dateChangeLabel
            // 
            dateChangeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            dateChangeLabel.AutoSize = true;
            dateChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateChangeLabel.Location = new System.Drawing.Point(64, 324);
            dateChangeLabel.Name = "dateChangeLabel";
            dateChangeLabel.Size = new System.Drawing.Size(137, 17);
            dateChangeLabel.TabIndex = 24;
            dateChangeLabel.Text = "Дата изменения:";
            // 
            // dGVEFStat
            // 
            this.dGVEFStat.AllowUserToAddRows = false;
            this.dGVEFStat.AllowUserToDeleteRows = false;
            this.dGVEFStat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVEFStat.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVEFStat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGVEFStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEFStat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDGVTBC,
            this.idAbnDGVTBC,
            this.idReasonDGVTBC,
            this.dateChangeDGrVTBC,
            this.isActiveDGVCheckBoxColumn,
            this.nameDGVTBC});
            this.dGVEFStat.DataSource = this.bSAbnStat;
            this.dGVEFStat.Location = new System.Drawing.Point(12, 12);
            this.dGVEFStat.MultiSelect = false;
            this.dGVEFStat.Name = "dGVEFStat";
            this.dGVEFStat.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVEFStat.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dGVEFStat.RowHeadersWidth = 5;
            this.dGVEFStat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEFStat.Size = new System.Drawing.Size(587, 219);
            this.dGVEFStat.TabIndex = 0;
            this.dGVEFStat.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVEFStat_CellMouseClick);
            this.dGVEFStat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dGVEFStat_KeyUp);
            // 
            // idDGVTBC
            // 
            this.idDGVTBC.DataPropertyName = "id";
            this.idDGVTBC.HeaderText = "id";
            this.idDGVTBC.Name = "idDGVTBC";
            this.idDGVTBC.ReadOnly = true;
            this.idDGVTBC.Visible = false;
            // 
            // idAbnDGVTBC
            // 
            this.idAbnDGVTBC.DataPropertyName = "idAbn";
            this.idAbnDGVTBC.HeaderText = "idAbn";
            this.idAbnDGVTBC.Name = "idAbnDGVTBC";
            this.idAbnDGVTBC.ReadOnly = true;
            this.idAbnDGVTBC.Visible = false;
            // 
            // idReasonDGVTBC
            // 
            this.idReasonDGVTBC.DataPropertyName = "idReason";
            this.idReasonDGVTBC.HeaderText = "idReason";
            this.idReasonDGVTBC.Name = "idReasonDGVTBC";
            this.idReasonDGVTBC.ReadOnly = true;
            this.idReasonDGVTBC.Visible = false;
            // 
            // dateChangeDGrVTBC
            // 
            this.dateChangeDGrVTBC.DataPropertyName = "DateChange";
            this.dateChangeDGrVTBC.HeaderText = "Дата";
            this.dateChangeDGrVTBC.Name = "dateChangeDGrVTBC";
            this.dateChangeDGrVTBC.ReadOnly = true;
            // 
            // isActiveDGVCheckBoxColumn
            // 
            this.isActiveDGVCheckBoxColumn.DataPropertyName = "isActive";
            this.isActiveDGVCheckBoxColumn.HeaderText = "Статус";
            this.isActiveDGVCheckBoxColumn.Name = "isActiveDGVCheckBoxColumn";
            this.isActiveDGVCheckBoxColumn.ReadOnly = true;
            this.isActiveDGVCheckBoxColumn.Width = 60;
            // 
            // nameDGVTBC
            // 
            this.nameDGVTBC.DataPropertyName = "Name";
            this.nameDGVTBC.HeaderText = "Причина смены";
            this.nameDGVTBC.Name = "nameDGVTBC";
            this.nameDGVTBC.ReadOnly = true;
            this.nameDGVTBC.Width = 420;
            // 
            // bSAbnStat
            // 
            this.bSAbnStat.DataMember = "vAbnStatusReason";
            this.bSAbnStat.DataSource = this.dsAbn;
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetPrv";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTPStat
            // 
            this.dTPStat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dTPStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dTPStat.Location = new System.Drawing.Point(219, 324);
            this.dTPStat.Name = "dTPStat";
            this.dTPStat.Size = new System.Drawing.Size(200, 23);
            this.dTPStat.TabIndex = 27;
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxStatus.Location = new System.Drawing.Point(428, 250);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(154, 21);
            this.checkBoxStatus.TabIndex = 26;
            this.checkBoxStatus.Text = "Статус активный";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Причины изменения:";
            // 
            // idReasonComboBox
            // 
            this.idReasonComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.idReasonComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAbn, "tAbnStatus.idReason", true));
            this.idReasonComboBox.DataSource = this.dsAbn;
            this.idReasonComboBox.DisplayMember = "tR_Classifier.Name";
            this.idReasonComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idReasonComboBox.FormattingEnabled = true;
            this.idReasonComboBox.Location = new System.Drawing.Point(219, 286);
            this.idReasonComboBox.Name = "idReasonComboBox";
            this.idReasonComboBox.Size = new System.Drawing.Size(363, 24);
            this.idReasonComboBox.TabIndex = 23;
            this.idReasonComboBox.ValueMember = "tR_Classifier.Id";
            // 
            // radioButtonEdit
            // 
            this.radioButtonEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonEdit.AutoSize = true;
            this.radioButtonEdit.Location = new System.Drawing.Point(152, 251);
            this.radioButtonEdit.Name = "radioButtonEdit";
            this.radioButtonEdit.Size = new System.Drawing.Size(109, 17);
            this.radioButtonEdit.TabIndex = 28;
            this.radioButtonEdit.Text = "Редактирование";
            this.radioButtonEdit.UseVisualStyleBackColor = true;
            this.radioButtonEdit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonEdit_MouseClick);
            // 
            // radioButtonNew
            // 
            this.radioButtonNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonNew.AutoSize = true;
            this.radioButtonNew.Checked = true;
            this.radioButtonNew.Location = new System.Drawing.Point(50, 250);
            this.radioButtonNew.Name = "radioButtonNew";
            this.radioButtonNew.Size = new System.Drawing.Size(59, 17);
            this.radioButtonNew.TabIndex = 29;
            this.radioButtonNew.TabStop = true;
            this.radioButtonNew.Text = "Новый";
            this.radioButtonNew.UseVisualStyleBackColor = true;
            this.radioButtonNew.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonNew_MouseClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(505, 362);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Выход";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(399, 362);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 30;
            this.buttonOK.Text = "Сохранить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormAbnStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 398);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.radioButtonNew);
            this.Controls.Add(this.radioButtonEdit);
            this.Controls.Add(this.dTPStat);
            this.Controls.Add(this.checkBoxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(dateChangeLabel);
            this.Controls.Add(this.idReasonComboBox);
            this.Controls.Add(this.dGVEFStat);
            this.Name = "FormAbnStatus";
            this.Text = "Статус контрагента";
            this.Load += new System.EventHandler(this.FormAbnStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEFStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSAbnStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dGVEFStat;
        private System.Windows.Forms.DateTimePicker dTPStat;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox idReasonComboBox;
        private System.Windows.Forms.RadioButton radioButtonEdit;
        private System.Windows.Forms.RadioButton radioButtonNew;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;

        private Prv.DataSets.DataSetPrv dsAbn;
        private System.Windows.Forms.BindingSource bSAbnStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReasonDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateChangeDGrVTBC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDGVCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDGVTBC;
    }
}