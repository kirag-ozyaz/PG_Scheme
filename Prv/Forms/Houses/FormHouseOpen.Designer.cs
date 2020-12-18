namespace Prv.Forms.Houses
{
    partial class FormHouseOpen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsPrv = new Prv.DataSets.DataSetPrv();
            this.bsAbnClose = new System.Windows.Forms.BindingSource(this.components);
            this.DGVEFAbnClose = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.DelStatbutton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datechange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idmapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kladrobjidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allKWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y2007DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y2008DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEFAbnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dsPrv
            // 
            this.dsPrv.DataSetName = "DataSetPrv";
            this.dsPrv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsAbnClose
            // 
            this.bsAbnClose.DataMember = "vPrv_HousesClose";
            this.bsAbnClose.DataSource = this.dsPrv;
            // 
            // DGVEFAbnClose
            // 
            this.DGVEFAbnClose.AllowUserToAddRows = false;
            this.DGVEFAbnClose.AllowUserToDeleteRows = false;
            this.DGVEFAbnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVEFAbnClose.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVEFAbnClose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVEFAbnClose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEFAbnClose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.apartmentDataGridViewTextBoxColumn,
            this.Reason,
            this.idStatus,
            this.datechange,
            this.idReason,
            this.isActive,
            this.idmapDataGridViewTextBoxColumn,
            this.kladrobjidDataGridViewTextBoxColumn,
            this.allKWTDataGridViewTextBoxColumn,
            this.y2007DataGridViewTextBoxColumn,
            this.y2008DataGridViewTextBoxColumn});
            this.DGVEFAbnClose.DataSource = this.bsAbnClose;
            this.DGVEFAbnClose.Location = new System.Drawing.Point(0, 0);
            this.DGVEFAbnClose.Name = "DGVEFAbnClose";
            this.DGVEFAbnClose.ReadOnly = true;
            this.DGVEFAbnClose.Size = new System.Drawing.Size(833, 489);
            this.DGVEFAbnClose.TabIndex = 4;
            // 
            // DelStatbutton
            // 
            this.DelStatbutton.Location = new System.Drawing.Point(12, 495);
            this.DelStatbutton.Name = "DelStatbutton";
            this.DelStatbutton.Size = new System.Drawing.Size(122, 23);
            this.DelStatbutton.TabIndex = 5;
            this.DelStatbutton.Text = "Удалить статус";
            this.DelStatbutton.UseVisualStyleBackColor = true;
            this.DelStatbutton.Click += new System.EventHandler(this.DelStatbutton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(746, 495);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Выход";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Лиц. счет";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 80;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "Ф.И.О";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Width = 140;
            // 
            // apartmentDataGridViewTextBoxColumn
            // 
            this.apartmentDataGridViewTextBoxColumn.DataPropertyName = "Apartment";
            this.apartmentDataGridViewTextBoxColumn.HeaderText = "кв.";
            this.apartmentDataGridViewTextBoxColumn.Name = "apartmentDataGridViewTextBoxColumn";
            this.apartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.apartmentDataGridViewTextBoxColumn.Width = 40;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Статус";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            this.Reason.Width = 120;
            // 
            // idStatus
            // 
            this.idStatus.DataPropertyName = "idStatus";
            this.idStatus.HeaderText = "idStatus";
            this.idStatus.Name = "idStatus";
            this.idStatus.ReadOnly = true;
            this.idStatus.Visible = false;
            // 
            // datechange
            // 
            this.datechange.DataPropertyName = "datechange";
            this.datechange.HeaderText = "Дата";
            this.datechange.Name = "datechange";
            this.datechange.ReadOnly = true;
            this.datechange.Width = 80;
            // 
            // idReason
            // 
            this.idReason.DataPropertyName = "idReason";
            this.idReason.HeaderText = "idReason";
            this.idReason.Name = "idReason";
            this.idReason.ReadOnly = true;
            this.idReason.Visible = false;
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "isActive";
            this.isActive.HeaderText = "isActive";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.Visible = false;
            // 
            // idmapDataGridViewTextBoxColumn
            // 
            this.idmapDataGridViewTextBoxColumn.DataPropertyName = "idmap";
            this.idmapDataGridViewTextBoxColumn.HeaderText = "idmap";
            this.idmapDataGridViewTextBoxColumn.Name = "idmapDataGridViewTextBoxColumn";
            this.idmapDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmapDataGridViewTextBoxColumn.Visible = false;
            // 
            // kladrobjidDataGridViewTextBoxColumn
            // 
            this.kladrobjidDataGridViewTextBoxColumn.DataPropertyName = "kladrobjid";
            this.kladrobjidDataGridViewTextBoxColumn.HeaderText = "kladrobjid";
            this.kladrobjidDataGridViewTextBoxColumn.Name = "kladrobjidDataGridViewTextBoxColumn";
            this.kladrobjidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kladrobjidDataGridViewTextBoxColumn.Visible = false;
            // 
            // allKWTDataGridViewTextBoxColumn
            // 
            this.allKWTDataGridViewTextBoxColumn.DataPropertyName = "allKWT";
            this.allKWTDataGridViewTextBoxColumn.HeaderText = "Всего, кВт";
            this.allKWTDataGridViewTextBoxColumn.Name = "allKWTDataGridViewTextBoxColumn";
            this.allKWTDataGridViewTextBoxColumn.ReadOnly = true;
            this.allKWTDataGridViewTextBoxColumn.Width = 60;
            // 
            // y2007DataGridViewTextBoxColumn
            // 
            this.y2007DataGridViewTextBoxColumn.DataPropertyName = "y2007";
            this.y2007DataGridViewTextBoxColumn.HeaderText = "2007г.";
            this.y2007DataGridViewTextBoxColumn.Name = "y2007DataGridViewTextBoxColumn";
            this.y2007DataGridViewTextBoxColumn.ReadOnly = true;
            this.y2007DataGridViewTextBoxColumn.Width = 60;
            // 
            // y2008DataGridViewTextBoxColumn
            // 
            this.y2008DataGridViewTextBoxColumn.DataPropertyName = "y2008";
            this.y2008DataGridViewTextBoxColumn.HeaderText = "2008г.";
            this.y2008DataGridViewTextBoxColumn.Name = "y2008DataGridViewTextBoxColumn";
            this.y2008DataGridViewTextBoxColumn.ReadOnly = true;
            this.y2008DataGridViewTextBoxColumn.Width = 60;
            // 
            // FormHouseOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 526);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DelStatbutton);
            this.Controls.Add(this.DGVEFAbnClose);
            this.Name = "FormHouseOpen";
            this.Text = "FormHouseOpen";
            this.Load += new System.EventHandler(this.FormHouseOpen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEFAbnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSets.DataSetPrv dsPrv;
        private System.Windows.Forms.BindingSource bsAbnClose;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter DGVEFAbnClose;
        private System.Windows.Forms.Button DelStatbutton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn datechange;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReason;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kladrobjidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allKWTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn y2007DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn y2008DataGridViewTextBoxColumn;
    }
}