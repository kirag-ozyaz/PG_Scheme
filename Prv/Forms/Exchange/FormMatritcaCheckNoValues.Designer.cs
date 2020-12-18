namespace Prv.Forms.Exchange
{
    partial class FormMatritcaCheckNoValues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatritcaCheckNoValues));
            this.labelDate = new System.Windows.Forms.Label();
            this.bsData = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetExchange = new Prv.DataSets.DataSetExchange();
            this.dgveData = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idPointRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitAddressDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.sNDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonXls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgveData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(12, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(62, 25);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "дата";
            // 
            // bsData
            // 
            this.bsData.DataMember = "fn_PrvFromMatritcaCheckNoValues";
            this.bsData.DataSource = this.dataSetExchange;
            // 
            // dataSetExchange
            // 
            this.dataSetExchange.DataSetName = "DataSetExchange";
            this.dataSetExchange.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgveData
            // 
            this.dgveData.AllowUserToAddRows = false;
            this.dgveData.AllowUserToDeleteRows = false;
            this.dgveData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgveData.AutoGenerateColumns = false;
            this.dgveData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgveData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeAbonentDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.idPointRegDataGridViewTextBoxColumn,
            this.idPointDataGridViewTextBoxColumn,
            this.unitAddressDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sNDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.nValueDataGridViewTextBoxColumn,
            this.dValueDataGridViewTextBoxColumn});
            this.dgveData.DataSource = this.bsData;
            this.dgveData.Location = new System.Drawing.Point(1, 37);
            this.dgveData.Name = "dgveData";
            this.dgveData.ReadOnly = true;
            this.dgveData.RowHeadersWidth = 21;
            this.dgveData.Size = new System.Drawing.Size(950, 483);
            this.dgveData.TabIndex = 2;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Лицевой счет";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес Энергосхема";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idPointRegDataGridViewTextBoxColumn
            // 
            this.idPointRegDataGridViewTextBoxColumn.DataPropertyName = "idPointReg";
            this.idPointRegDataGridViewTextBoxColumn.HeaderText = "idPointReg";
            this.idPointRegDataGridViewTextBoxColumn.Name = "idPointRegDataGridViewTextBoxColumn";
            this.idPointRegDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPointRegDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPointDataGridViewTextBoxColumn
            // 
            this.idPointDataGridViewTextBoxColumn.DataPropertyName = "idPoint";
            this.idPointDataGridViewTextBoxColumn.HeaderText = "idPoint";
            this.idPointDataGridViewTextBoxColumn.Name = "idPointDataGridViewTextBoxColumn";
            this.idPointDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPointDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitAddressDataGridViewTextBoxColumn
            // 
            this.unitAddressDataGridViewTextBoxColumn.DataPropertyName = "UnitAddress";
            this.unitAddressDataGridViewTextBoxColumn.HeaderText = "Адрес Матрица";
            this.unitAddressDataGridViewTextBoxColumn.Name = "unitAddressDataGridViewTextBoxColumn";
            this.unitAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitAddressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // sNDataGridViewTextBoxColumn
            // 
            this.sNDataGridViewTextBoxColumn.DataPropertyName = "SN";
            this.sNDataGridViewTextBoxColumn.HeaderText = "Серийный номер";
            this.sNDataGridViewTextBoxColumn.Name = "sNDataGridViewTextBoxColumn";
            this.sNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nValueDataGridViewTextBoxColumn
            // 
            this.nValueDataGridViewTextBoxColumn.DataPropertyName = "NValue";
            this.nValueDataGridViewTextBoxColumn.HeaderText = "Ночь";
            this.nValueDataGridViewTextBoxColumn.Name = "nValueDataGridViewTextBoxColumn";
            this.nValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dValueDataGridViewTextBoxColumn
            // 
            this.dValueDataGridViewTextBoxColumn.DataPropertyName = "DValue";
            this.dValueDataGridViewTextBoxColumn.HeaderText = "День";
            this.dValueDataGridViewTextBoxColumn.Name = "dValueDataGridViewTextBoxColumn";
            this.dValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buttonXls
            // 
            this.buttonXls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXls.Image = global::Prv.Properties.Resources._1482423561_export_excel;
            this.buttonXls.Location = new System.Drawing.Point(909, 8);
            this.buttonXls.Name = "buttonXls";
            this.buttonXls.Size = new System.Drawing.Size(31, 23);
            this.buttonXls.TabIndex = 3;
            this.buttonXls.UseVisualStyleBackColor = true;
            this.buttonXls.Click += new System.EventHandler(this.buttonXls_Click);
            // 
            // FormMatritcaCheckNoValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 520);
            this.Controls.Add(this.buttonXls);
            this.Controls.Add(this.dgveData);
            this.Controls.Add(this.labelDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMatritcaCheckNoValues";
            this.Text = "Нет показаний за период";
            this.Load += new System.EventHandler(this.FormMatritcaCheckNoValues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgveData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.BindingSource bsData;
        private DataSets.DataSetExchange dataSetExchange;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgveData;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn fIODataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn unitAddressDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn sNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonXls;
    }
}