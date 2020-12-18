namespace ReferenceWorker
{
    partial class FormWorkersSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkersSelect));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dsWorker = new ReferenceWorker.DataSetWorker();
            this.bsWorker = new System.Windows.Forms.BindingSource(this.components);
            this.tRWorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvWorker = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRRefDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.fDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.divisionCurrentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDgvTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtnShowDeleteDivision = new System.Windows.Forms.ToolStripButton();
            this.toolTxtFindTreeDivision = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindTreeDivision = new System.Windows.Forms.ToolStripButton();
            this.toolBtnCloseDivision = new System.Windows.Forms.ToolStripButton();
            this.toolBtnShowWorkerDelete = new System.Windows.Forms.ToolStripButton();
            this.treeViewDivision = new System.Windows.Forms.TreeView();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.toolStripTreeDivision = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRWorkerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.toolStripTreeDivision.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "FolderDocumentYellow.png");
            this.imageList.Images.SetKeyName(1, "FolderDeleteYellow.png");
            this.imageList.Images.SetKeyName(2, "FolderYellow.png");
            this.imageList.Images.SetKeyName(3, "JOBPost.png");
            this.imageList.Images.SetKeyName(4, "Company.png");
            this.imageList.Images.SetKeyName(5, "Workers.png");
            // 
            // dsWorker
            // 
            this.dsWorker.DataSetName = "DataSetWorkers";
            this.dsWorker.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsWorker
            // 
            this.bsWorker.DataMember = "tR_Worker";
            this.bsWorker.DataSource = this.dsWorker;
            // 
            // tRWorkerBindingSource
            // 
            this.tRWorkerBindingSource.DataMember = "tR_Worker";
            this.tRWorkerBindingSource.DataSource = this.dsWorker;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 42);
            this.panel1.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(713, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelect.Location = new System.Drawing.Point(12, 7);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // dgvWorker
            // 
            this.dgvWorker.AllowUserToAddRows = false;
            this.dgvWorker.AllowUserToDeleteRows = false;
            this.dgvWorker.AllowUserToOrderColumns = true;
            this.dgvWorker.AllowUserToResizeRows = false;
            this.dgvWorker.AllowUserToVisibleColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvWorker.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWorker.AutoGenerateColumns = false;
            this.dgvWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iDRRefDataGridViewImageColumn,
            this.fDataGridViewTextBoxColumn,
            this.iDataGridViewTextBoxColumn,
            this.oDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn,
            this.divisionCurrentDataGridViewTextBoxColumn,
            this.dateBeginDataGridViewTextBoxColumn,
            this.dateEndDgvTextBoxColumn,
            this.Division});
            this.dgvWorker.DataSource = this.bsWorker;
            this.dgvWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorker.Location = new System.Drawing.Point(0, 0);
            this.dgvWorker.Name = "dgvWorker";
            this.dgvWorker.ReadOnly = true;
            this.dgvWorker.RowHeadersWidth = 21;
            this.dgvWorker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorker.Size = new System.Drawing.Size(554, 408);
            this.dgvWorker.TabIndex = 1;
            this.dgvWorker.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorker_CellDoubleClick);
            this.dgvWorker.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvWorker_CellFormatting);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDRRefDataGridViewImageColumn
            // 
            this.iDRRefDataGridViewImageColumn.DataPropertyName = "IDRRef";
            this.iDRRefDataGridViewImageColumn.HeaderText = "IDRRef";
            this.iDRRefDataGridViewImageColumn.Name = "iDRRefDataGridViewImageColumn";
            this.iDRRefDataGridViewImageColumn.ReadOnly = true;
            this.iDRRefDataGridViewImageColumn.Visible = false;
            // 
            // fDataGridViewTextBoxColumn
            // 
            this.fDataGridViewTextBoxColumn.DataPropertyName = "F";
            this.fDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.fDataGridViewTextBoxColumn.Name = "fDataGridViewTextBoxColumn";
            this.fDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDataGridViewTextBoxColumn
            // 
            this.iDataGridViewTextBoxColumn.DataPropertyName = "I";
            this.iDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.iDataGridViewTextBoxColumn.Name = "iDataGridViewTextBoxColumn";
            this.iDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oDataGridViewTextBoxColumn
            // 
            this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
            this.oDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
            this.oDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.DataSource = this.dsWorker;
            this.jobTitleDataGridViewTextBoxColumn.DisplayMember = "tR_JobTitle.Description";
            this.jobTitleDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            this.jobTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobTitleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jobTitleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.jobTitleDataGridViewTextBoxColumn.ValueMember = "tR_JobTitle.id";
            // 
            // divisionCurrentDataGridViewTextBoxColumn
            // 
            this.divisionCurrentDataGridViewTextBoxColumn.DataPropertyName = "DivisionCurrent";
            this.divisionCurrentDataGridViewTextBoxColumn.DataSource = this.dsWorker;
            this.divisionCurrentDataGridViewTextBoxColumn.DisplayMember = "tR_Division.Description";
            this.divisionCurrentDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.divisionCurrentDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.divisionCurrentDataGridViewTextBoxColumn.Name = "divisionCurrentDataGridViewTextBoxColumn";
            this.divisionCurrentDataGridViewTextBoxColumn.ReadOnly = true;
            this.divisionCurrentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.divisionCurrentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.divisionCurrentDataGridViewTextBoxColumn.ValueMember = "tR_Division.id";
            // 
            // dateBeginDataGridViewTextBoxColumn
            // 
            this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "DateBegin";
            this.dateBeginDataGridViewTextBoxColumn.HeaderText = "Работает с";
            this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
            this.dateBeginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEndDgvTextBoxColumn
            // 
            this.dateEndDgvTextBoxColumn.DataPropertyName = "DateEnd";
            this.dateEndDgvTextBoxColumn.HeaderText = "Уволен";
            this.dateEndDgvTextBoxColumn.Name = "dateEndDgvTextBoxColumn";
            this.dateEndDgvTextBoxColumn.ReadOnly = true;
            // 
            // Division
            // 
            this.Division.DataPropertyName = "Division";
            this.Division.HeaderText = "Division";
            this.Division.Name = "Division";
            this.Division.ReadOnly = true;
            this.Division.Visible = false;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "Выбор нового элемента";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(180, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(226, 25);
            this.miniToolStrip.TabIndex = 3;
            // 
            // toolBtnShowDeleteDivision
            // 
            this.toolBtnShowDeleteDivision.CheckOnClick = true;
            this.toolBtnShowDeleteDivision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnShowDeleteDivision.Image = global::ReferenceWorker.Properties.Resources.Trash;
            this.toolBtnShowDeleteDivision.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnShowDeleteDivision.Name = "toolBtnShowDeleteDivision";
            this.toolBtnShowDeleteDivision.Size = new System.Drawing.Size(23, 22);
            this.toolBtnShowDeleteDivision.Text = "Показать удаленные";
            this.toolBtnShowDeleteDivision.Click += new System.EventHandler(this.toolBtnShowDeleteDivision_Click);
            // 
            // toolTxtFindTreeDivision
            // 
            this.toolTxtFindTreeDivision.Name = "toolTxtFindTreeDivision";
            this.toolTxtFindTreeDivision.Size = new System.Drawing.Size(100, 25);
            // 
            // toolBtnFindTreeDivision
            // 
            this.toolBtnFindTreeDivision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindTreeDivision.Image = global::ReferenceWorker.Properties.Resources.Find;
            this.toolBtnFindTreeDivision.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnFindTreeDivision.Name = "toolBtnFindTreeDivision";
            this.toolBtnFindTreeDivision.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindTreeDivision.Text = "Поиск";
            // 
            // toolBtnCloseDivision
            // 
            this.toolBtnCloseDivision.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBtnCloseDivision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnCloseDivision.Image = global::ReferenceWorker.Properties.Resources.Close;
            this.toolBtnCloseDivision.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnCloseDivision.Name = "toolBtnCloseDivision";
            this.toolBtnCloseDivision.Size = new System.Drawing.Size(23, 22);
            this.toolBtnCloseDivision.Text = "Скрыть дерево";
            // 
            // toolBtnShowWorkerDelete
            // 
            this.toolBtnShowWorkerDelete.CheckOnClick = true;
            this.toolBtnShowWorkerDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnShowWorkerDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnShowWorkerDelete.Image")));
            this.toolBtnShowWorkerDelete.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnShowWorkerDelete.Name = "toolBtnShowWorkerDelete";
            this.toolBtnShowWorkerDelete.Size = new System.Drawing.Size(23, 22);
            this.toolBtnShowWorkerDelete.Text = "Показать уволенных";
            this.toolBtnShowWorkerDelete.Click += new System.EventHandler(this.toolBtnShowWorkerDelete_Click);
            // 
            // treeViewDivision
            // 
            this.treeViewDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDivision.ImageIndex = 0;
            this.treeViewDivision.ImageList = this.imageList;
            this.treeViewDivision.Location = new System.Drawing.Point(0, 25);
            this.treeViewDivision.Name = "treeViewDivision";
            this.treeViewDivision.SelectedImageIndex = 0;
            this.treeViewDivision.Size = new System.Drawing.Size(242, 383);
            this.treeViewDivision.TabIndex = 2;
            this.treeViewDivision.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDivision_AfterSelect);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.treeViewDivision);
            this.splitContainerMain.Panel1.Controls.Add(this.toolStripTreeDivision);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.dgvWorker);
            this.splitContainerMain.Size = new System.Drawing.Size(800, 408);
            this.splitContainerMain.SplitterDistance = 242;
            this.splitContainerMain.TabIndex = 2;
            // 
            // toolStripTreeDivision
            // 
            this.toolStripTreeDivision.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnShowDeleteDivision,
            this.toolTxtFindTreeDivision,
            this.toolBtnFindTreeDivision,
            this.toolBtnCloseDivision,
            this.toolBtnShowWorkerDelete});
            this.toolStripTreeDivision.Location = new System.Drawing.Point(0, 0);
            this.toolStripTreeDivision.Name = "toolStripTreeDivision";
            this.toolStripTreeDivision.Size = new System.Drawing.Size(242, 25);
            this.toolStripTreeDivision.TabIndex = 3;
            this.toolStripTreeDivision.Text = "toolStrip1";
            // 
            // FormWorkersSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panel1);
            this.Name = "FormWorkersSelect";
            this.Text = "Выбор персонала";
            this.Load += new System.EventHandler(this.FormWorkersSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRWorkerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.ResumeLayout(false);
            this.toolStripTreeDivision.ResumeLayout(false);
            this.toolStripTreeDivision.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSetWorker dsWorker;
        private System.Windows.Forms.BindingSource tRWorkerBindingSource;
        private System.Windows.Forms.BindingSource bsWorker;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelect;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn iDRRefDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn jobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn divisionCurrentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEndDgvTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Division;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStripButton toolBtnShowDeleteDivision;
        private System.Windows.Forms.ToolStripTextBox toolTxtFindTreeDivision;
        private System.Windows.Forms.ToolStripButton toolBtnFindTreeDivision;
        private System.Windows.Forms.ToolStripButton toolBtnCloseDivision;
        private System.Windows.Forms.ToolStripButton toolBtnShowWorkerDelete;
        private System.Windows.Forms.TreeView treeViewDivision;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ToolStrip toolStripTreeDivision;
        private System.Windows.Forms.Button buttonCancel;
    }
}