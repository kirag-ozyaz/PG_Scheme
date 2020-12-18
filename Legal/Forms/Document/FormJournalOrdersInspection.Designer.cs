namespace Legal.Forms.Document
{
    partial class FormJournalOrdersInspection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJournalOrdersInspection));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.cmbPrintOrder = new System.Windows.Forms.ToolStripButton();
            this.cmbExportExcel = new System.Windows.Forms.ToolStripButton();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbnDocum1 = new Legal.DataSet.dsAbnDocum();
            //this.dgvJournal = new System.Windows.Forms.DataGridView();
            this.dgvJournal = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOrderDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateOrderDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.contractorDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Member = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.AuthorOrder = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.DateCurrent = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.NumberJournal = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.DateJournal = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogExport = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDel,
            this.cmbPrintOrder,
            this.cmbExportExcel,
            this.btnFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(930, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(23, 22);
            this.btnDel.Text = "Удалить";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cmbPrintOrder
            // 
            this.cmbPrintOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmbPrintOrder.Image = global::Legal.Properties.Resources.Print;
            this.cmbPrintOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmbPrintOrder.Name = "cmbPrintOrder";
            this.cmbPrintOrder.Size = new System.Drawing.Size(23, 22);
            this.cmbPrintOrder.ToolTipText = "Печать распоряжения";
            this.cmbPrintOrder.Click += new System.EventHandler(this.cmbPrintOrder_Click);
            // 
            // cmbExportExcel
            // 
            this.cmbExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmbExportExcel.Image = global::Legal.Properties.Resources.xlsx_mac;
            this.cmbExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmbExportExcel.Name = "cmbExportExcel";
            this.cmbExportExcel.Size = new System.Drawing.Size(23, 22);
            this.cmbExportExcel.Text = "toolStripButton1";
            this.cmbExportExcel.ToolTipText = "Экспорт в Excel";
            this.cmbExportExcel.Click += new System.EventHandler(this.cmbExportExcel_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilter.Image = global::Legal.Properties.Resources.Filtr_my;
            this.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(23, 22);
            this.btnFilter.Text = "toolStripButton1";
            this.btnFilter.ToolTipText = "Обновить";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Конец";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Начало";
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(142, 92);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(16, 23);
            this.btnMinus.TabIndex = 62;
            this.btnMinus.Text = "<";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(142, 55);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(16, 23);
            this.btnPlus.TabIndex = 61;
            this.btnPlus.Text = ">";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(5, 95);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(131, 20);
            this.dtEnd.TabIndex = 60;
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(5, 56);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(131, 20);
            this.dtBegin.TabIndex = 59;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "vJournalOrdersInspection";
            this.bindingSource1.DataSource = this.dsAbnDocum1;
            // 
            // dsAbnDocum1
            // 
            this.dsAbnDocum1.DataSetName = "dsAbnDocum";
            this.dsAbnDocum1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvJournal
            // 
            this.dgvJournal.AllowUserToAddRows = false;
            this.dgvJournal.AllowUserToDeleteRows = false;
            this.dgvJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJournal.AutoGenerateColumns = false;
            this.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDGV,
            this.numberOrderDataGridViewTextBoxColumn,
            this.dateOrderDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn,
            this.contractorDataGridViewTextBoxColumn,
            this.Member,
            this.AuthorOrder,
            this.DateCurrent,
            this.NumberJournal,
            this.DateJournal});
            this.dgvJournal.DataSource = this.bindingSource1;
            this.dgvJournal.Location = new System.Drawing.Point(165, 28);
            this.dgvJournal.MultiSelect = false;
            this.dgvJournal.Name = "dgvJournal";
            this.dgvJournal.ReadOnly = true;
            this.dgvJournal.RowHeadersWidth = 5;
            this.dgvJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJournal.Size = new System.Drawing.Size(765, 477);
            this.dgvJournal.TabIndex = 0;
            this.dgvJournal.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvJournal_CellMouseDoubleClick);
            this.dgvJournal.DoubleClick += new System.EventHandler(this.dgvJournal_DoubleClick);
            this.dgvJournal.EnabledQuickFind = true;
            this.dgvJournal.AllowUserToVisibleColumns = true;
            this.dgvJournal.AllowUserToOrderColumns = true;
            // 
            // idDGV
            // 
            this.idDGV.DataPropertyName = "id";
            this.idDGV.HeaderText = "id";
            this.idDGV.Name = "idDGV";
            this.idDGV.ReadOnly = true;
            this.idDGV.Visible = false;
            // 
            // numberOrderDataGridViewTextBoxColumn
            // 
            this.numberOrderDataGridViewTextBoxColumn.DataPropertyName = "NumberOrder";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.numberOrderDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.numberOrderDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberOrderDataGridViewTextBoxColumn.Name = "numberOrderDataGridViewTextBoxColumn";
            this.numberOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOrderDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateOrderDataGridViewTextBoxColumn
            // 
            this.dateOrderDataGridViewTextBoxColumn.DataPropertyName = "DateOrder";
            this.dateOrderDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateOrderDataGridViewTextBoxColumn.Name = "dateOrderDataGridViewTextBoxColumn";
            this.dateOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOrderDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // managerDataGridViewTextBoxColumn
            // 
            this.managerDataGridViewTextBoxColumn.DataPropertyName = "Manager";
            this.managerDataGridViewTextBoxColumn.HeaderText = "Кто выдал";
            this.managerDataGridViewTextBoxColumn.Name = "managerDataGridViewTextBoxColumn";
            this.managerDataGridViewTextBoxColumn.ReadOnly = true;
            this.managerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.managerDataGridViewTextBoxColumn.Width = 150;
            // 
            // contractorDataGridViewTextBoxColumn
            // 
            this.contractorDataGridViewTextBoxColumn.DataPropertyName = "Contractor";
            this.contractorDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.contractorDataGridViewTextBoxColumn.Name = "contractorDataGridViewTextBoxColumn";
            this.contractorDataGridViewTextBoxColumn.ReadOnly = true;
            this.contractorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.contractorDataGridViewTextBoxColumn.Width = 150;
            // 
            // Member
            // 
            this.Member.DataPropertyName = "Member";
            this.Member.HeaderText = "Член бригады";
            this.Member.Name = "Member";
            this.Member.ReadOnly = true;
            this.Member.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Member.Width = 150;
            // 
            // AuthorOrder
            // 
            this.AuthorOrder.DataPropertyName = "AuthorOrder";
            this.AuthorOrder.HeaderText = "Автор";
            this.AuthorOrder.Name = "AuthorOrder";
            this.AuthorOrder.ReadOnly = true;
            this.AuthorOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DateCurrent
            // 
            this.DateCurrent.DataPropertyName = "DateCurrent";
            this.DateCurrent.HeaderText = "Дата создания";
            this.DateCurrent.Name = "DateCurrent";
            this.DateCurrent.ReadOnly = true;
            this.DateCurrent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateCurrent.Width = 150;
            // 
            // NumberJournal
            // 
            this.NumberJournal.DataPropertyName = "NumberJournal";
            this.NumberJournal.HeaderText = "Номер в журнале";
            this.NumberJournal.Name = "NumberJournal";
            this.NumberJournal.ReadOnly = true;
            this.NumberJournal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DateJournal
            // 
            this.DateJournal.DataPropertyName = "DateJournal";
            this.DateJournal.HeaderText = "Журнал начат";
            this.DateJournal.Name = "DateJournal";
            this.DateJournal.ReadOnly = true;
            this.DateJournal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateJournal.Width = 150;
            // 
            // openFileDialogExport
            // 
            this.openFileDialogExport.FileName = "openFileDialog1";
            // 
            // FormJournalOrdersInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvJournal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtBegin);
            this.Name = "FormJournalOrdersInspection";
            this.Text = "Журнал распоряжений";
            this.Load += new System.EventHandler(this.FormJournalOrdersInspection_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private DataSet.dsAbnDocum dsAbnDocum1;
        private System.Windows.Forms.BindingSource bindingSource1;
        //private System.Windows.Forms.DataGridView dgvJournal;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvJournal;
        private System.Windows.Forms.ToolStripButton cmbPrintOrder;
        private System.Windows.Forms.ToolStripButton btnFilter;
        private System.Windows.Forms.ToolStripButton cmbExportExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDGV;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn numberOrderDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dateOrderDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn managerDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn contractorDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn Member;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn AuthorOrder;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn DateCurrent;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn NumberJournal;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn DateJournal;
        private System.Windows.Forms.OpenFileDialog openFileDialogExport;

    }
}