namespace Legal.Forms
{
    partial class FormAbn_Log
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsInfo1 = new Legal.DataSet.dsInfo();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recTypeDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.datecommandDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameShortDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameFullDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.kPPDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.oKVEDDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.oKPODataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Bank1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.bankAcntDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.acceptDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acceptDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfo1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.recTypeDataGridViewTextBoxColumn,
            this.datecommandDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.idAbnDataGridViewTextBoxColumn,
            this.nameShortDataGridViewTextBoxColumn,
            this.nameFullDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn,
            this.kPPDataGridViewTextBoxColumn,
            this.oKVEDDataGridViewTextBoxColumn,
            this.oKPODataGridViewTextBoxColumn,
            this.Bank1,
            this.bankDataGridViewTextBoxColumn,
            this.bankAcntDataGridViewTextBoxColumn,
            this.acceptDataGridViewCheckBoxColumn,
            this.acceptDaysDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 8;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(984, 562);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "vG_AbnInfo_Log";
            this.bindingSource1.DataSource = this.dsInfo1;
            // 
            // dsInfo1
            // 
            this.dsInfo1.DataSetName = "dsInfo";
            this.dsInfo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // recTypeDataGridViewTextBoxColumn
            // 
            this.recTypeDataGridViewTextBoxColumn.DataPropertyName = "RecType";
            this.recTypeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.recTypeDataGridViewTextBoxColumn.Name = "recTypeDataGridViewTextBoxColumn";
            this.recTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.recTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // datecommandDataGridViewTextBoxColumn
            // 
            this.datecommandDataGridViewTextBoxColumn.DataPropertyName = "datecommand";
            this.datecommandDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.datecommandDataGridViewTextBoxColumn.Name = "datecommandDataGridViewTextBoxColumn";
            this.datecommandDataGridViewTextBoxColumn.ReadOnly = true;
            this.datecommandDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Пользователь";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.usernameDataGridViewTextBoxColumn.Width = 200;
            // 
            // idAbnDataGridViewTextBoxColumn
            // 
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameShortDataGridViewTextBoxColumn
            // 
            this.nameShortDataGridViewTextBoxColumn.DataPropertyName = "NameShort";
            this.nameShortDataGridViewTextBoxColumn.HeaderText = "Краткое имя";
            this.nameShortDataGridViewTextBoxColumn.Name = "nameShortDataGridViewTextBoxColumn";
            this.nameShortDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameShortDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameShortDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameFullDataGridViewTextBoxColumn
            // 
            this.nameFullDataGridViewTextBoxColumn.DataPropertyName = "NameFull";
            this.nameFullDataGridViewTextBoxColumn.HeaderText = "Полное имя";
            this.nameFullDataGridViewTextBoxColumn.Name = "nameFullDataGridViewTextBoxColumn";
            this.nameFullDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameFullDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameFullDataGridViewTextBoxColumn.Width = 200;
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            this.iNNDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNNDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // kPPDataGridViewTextBoxColumn
            // 
            this.kPPDataGridViewTextBoxColumn.DataPropertyName = "KPP";
            this.kPPDataGridViewTextBoxColumn.HeaderText = "КПП";
            this.kPPDataGridViewTextBoxColumn.Name = "kPPDataGridViewTextBoxColumn";
            this.kPPDataGridViewTextBoxColumn.ReadOnly = true;
            this.kPPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // oKVEDDataGridViewTextBoxColumn
            // 
            this.oKVEDDataGridViewTextBoxColumn.DataPropertyName = "OKVED";
            this.oKVEDDataGridViewTextBoxColumn.HeaderText = "ОКВЕД";
            this.oKVEDDataGridViewTextBoxColumn.Name = "oKVEDDataGridViewTextBoxColumn";
            this.oKVEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oKVEDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // oKPODataGridViewTextBoxColumn
            // 
            this.oKPODataGridViewTextBoxColumn.DataPropertyName = "OKPO";
            this.oKPODataGridViewTextBoxColumn.HeaderText = "ОКПО";
            this.oKPODataGridViewTextBoxColumn.Name = "oKPODataGridViewTextBoxColumn";
            this.oKPODataGridViewTextBoxColumn.ReadOnly = true;
            this.oKPODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Bank1
            // 
            this.Bank1.DataPropertyName = "Bank1";
            this.Bank1.HeaderText = "Банк";
            this.Bank1.Name = "Bank1";
            this.Bank1.ReadOnly = true;
            this.Bank1.Width = 200;
            // 
            // bankDataGridViewTextBoxColumn
            // 
            this.bankDataGridViewTextBoxColumn.DataPropertyName = "Bank";
            this.bankDataGridViewTextBoxColumn.HeaderText = "Банк плат.";
            this.bankDataGridViewTextBoxColumn.Name = "bankDataGridViewTextBoxColumn";
            this.bankDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bankDataGridViewTextBoxColumn.Width = 200;
            // 
            // bankAcntDataGridViewTextBoxColumn
            // 
            this.bankAcntDataGridViewTextBoxColumn.DataPropertyName = "BankAcnt";
            this.bankAcntDataGridViewTextBoxColumn.HeaderText = "Счет";
            this.bankAcntDataGridViewTextBoxColumn.Name = "bankAcntDataGridViewTextBoxColumn";
            this.bankAcntDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankAcntDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bankAcntDataGridViewTextBoxColumn.Width = 150;
            // 
            // acceptDataGridViewCheckBoxColumn
            // 
            this.acceptDataGridViewCheckBoxColumn.DataPropertyName = "Accept";
            this.acceptDataGridViewCheckBoxColumn.HeaderText = "Акцепт";
            this.acceptDataGridViewCheckBoxColumn.Name = "acceptDataGridViewCheckBoxColumn";
            this.acceptDataGridViewCheckBoxColumn.ReadOnly = true;
            this.acceptDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acceptDataGridViewCheckBoxColumn.Width = 50;
            // 
            // acceptDaysDataGridViewTextBoxColumn
            // 
            this.acceptDaysDataGridViewTextBoxColumn.DataPropertyName = "AcceptDays";
            this.acceptDaysDataGridViewTextBoxColumn.HeaderText = "Дни";
            this.acceptDaysDataGridViewTextBoxColumn.Name = "acceptDaysDataGridViewTextBoxColumn";
            this.acceptDaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.acceptDaysDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acceptDaysDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.acceptDaysDataGridViewTextBoxColumn.Width = 30;
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "Branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "Branch";
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            this.branchDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormAbn_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAbn_Log";
            this.Text = "Протокол изменений реквизитов потребителя";
            this.Load += new System.EventHandler(this.FormAbn_Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet.dsInfo dsInfo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn recTypeDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn datecommandDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameShortDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameFullDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn iNNDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn kPPDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn oKVEDDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn oKPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn bankDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn bankAcntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acceptDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
    }
}