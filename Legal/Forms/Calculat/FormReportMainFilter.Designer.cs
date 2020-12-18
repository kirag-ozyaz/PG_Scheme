namespace Legal.Forms.Calculat
{
    partial class FormReportMainFilter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.dgvListFilter = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNameFilter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTypeFilter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsListFilter = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportMainFilter1 = new Legal.DataSet.dsReportMainFilter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCheck = new System.Windows.Forms.ToolStripButton();
            this.btnUncheck = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.dgvFilter = new System.Windows.Forms.DataGridView();
            this.dgvFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvGroup = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dgvMember = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dgvIdClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFilter = new System.Windows.Forms.BindingSource(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportMainFilter1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.dgvListFilter);
            this.groupBox1.Location = new System.Drawing.Point(1, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Готовые фильтры";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(3, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 44);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnDel});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(170, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::Legal.Properties.Resources.ElementAdd;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "Добавить фильтр";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = global::Legal.Properties.Resources.ElementDel;
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(23, 22);
            this.btnDel.Text = "Удалить фильтр";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvListFilter
            // 
            this.dgvListFilter.AllowUserToAddRows = false;
            this.dgvListFilter.AllowUserToDeleteRows = false;
            this.dgvListFilter.AutoGenerateColumns = false;
            this.dgvListFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvNameFilter,
            this.dgvTypeFilter,
            this.dgvDeleted});
            this.dgvListFilter.DataSource = this.bsListFilter;
            this.dgvListFilter.Location = new System.Drawing.Point(3, 94);
            this.dgvListFilter.Name = "dgvListFilter";
            this.dgvListFilter.ReadOnly = true;
            this.dgvListFilter.RowHeadersWidth = 4;
            this.dgvListFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListFilter.Size = new System.Drawing.Size(172, 320);
            this.dgvListFilter.TabIndex = 0;
            this.dgvListFilter.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListFilter_CellMouseClick);
            this.dgvListFilter.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListFilter_CellMouseDoubleClick);
            // 
            // dgvID
            // 
            this.dgvID.DataPropertyName = "id";
            this.dgvID.HeaderText = "id";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Visible = false;
            // 
            // dgvNameFilter
            // 
            this.dgvNameFilter.DataPropertyName = "NameFilter";
            this.dgvNameFilter.HeaderText = "Фильтр";
            this.dgvNameFilter.Name = "dgvNameFilter";
            this.dgvNameFilter.ReadOnly = true;
            this.dgvNameFilter.Width = 200;
            // 
            // dgvTypeFilter
            // 
            this.dgvTypeFilter.DataPropertyName = "TypeFilter";
            this.dgvTypeFilter.HeaderText = "TypeFilter";
            this.dgvTypeFilter.Name = "dgvTypeFilter";
            this.dgvTypeFilter.ReadOnly = true;
            this.dgvTypeFilter.Visible = false;
            // 
            // dgvDeleted
            // 
            this.dgvDeleted.DataPropertyName = "Deleted";
            this.dgvDeleted.HeaderText = "Deleted";
            this.dgvDeleted.Name = "dgvDeleted";
            this.dgvDeleted.ReadOnly = true;
            this.dgvDeleted.Visible = false;
            // 
            // bsListFilter
            // 
            this.bsListFilter.DataMember = "tG_NameFilter";
            this.bsListFilter.DataSource = this.dsReportMainFilter1;
            // 
            // dsReportMainFilter1
            // 
            this.dsReportMainFilter1.DataSetName = "dsReportMainFilter";
            this.dsReportMainFilter1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip2);
            this.groupBox2.Controls.Add(this.dgvFilter);
            this.groupBox2.Location = new System.Drawing.Point(183, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 507);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Формирование фильтра";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCheck,
            this.btnUncheck,
            this.btnSave});
            this.toolStrip2.Location = new System.Drawing.Point(3, 16);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(558, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnCheck
            // 
            this.btnCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCheck.Image = global::Legal.Properties.Resources._1304663065_Add;
            this.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(23, 22);
            this.btnCheck.Text = "toolStripButton1";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnUncheck
            // 
            this.btnUncheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUncheck.Image = global::Legal.Properties.Resources.Delete;
            this.btnUncheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUncheck.Name = "btnUncheck";
            this.btnUncheck.Size = new System.Drawing.Size(23, 22);
            this.btnUncheck.Text = "toolStripButton2";
            this.btnUncheck.Click += new System.EventHandler(this.btnUncheck_Click);
            // 
            // btnSave
            // 
            this.btnSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::Legal.Properties.Resources.ElementEdit;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvFilter
            // 
            this.dgvFilter.AllowUserToAddRows = false;
            this.dgvFilter.AllowUserToDeleteRows = false;
            this.dgvFilter.AutoGenerateColumns = false;
            this.dgvFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFlag,
            this.dgvGroup,
            this.dgvMember,
            this.dgvIdClass});
            this.dgvFilter.DataSource = this.bsFilter;
            this.dgvFilter.Location = new System.Drawing.Point(0, 44);
            this.dgvFilter.MultiSelect = false;
            this.dgvFilter.Name = "dgvFilter";
            this.dgvFilter.RowHeadersWidth = 4;
            this.dgvFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilter.Size = new System.Drawing.Size(561, 457);
            this.dgvFilter.TabIndex = 0;
            this.dgvFilter.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvFilter_CurrentCellDirtyStateChanged);
            // 
            // dgvFlag
            // 
            this.dgvFlag.DataPropertyName = "Flag";
            this.dgvFlag.HeaderText = "Выбор";
            this.dgvFlag.Name = "dgvFlag";
            this.dgvFlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlag.Width = 50;
            // 
            // dgvGroup
            // 
            this.dgvGroup.DataPropertyName = "NameGroup";
            this.dgvGroup.HeaderText = "Группа ";
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroup.Width = 200;
            // 
            // dgvMember
            // 
            this.dgvMember.DataPropertyName = "NameMember";
            this.dgvMember.HeaderText = "Состав группы";
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMember.Width = 300;
            // 
            // dgvIdClass
            // 
            this.dgvIdClass.DataPropertyName = "idClass";
            this.dgvIdClass.HeaderText = "idClass";
            this.dgvIdClass.Name = "dgvIdClass";
            this.dgvIdClass.Visible = false;
            // 
            // bsFilter
            // 
            this.bsFilter.DataMember = "tFilter";
            this.bsFilter.DataSource = this.dsReportMainFilter1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(52, 440);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Выбрать";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(52, 477);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отказаться";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormReportMainFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(747, 512);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReportMainFilter";
            this.Text = "Фильтр по группам потребителей";
            this.Load += new System.EventHandler(this.FormReportMainFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportMainFilter1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFilter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.BindingSource bsListFilter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idFilterDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idGroupDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idConsumerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsFilter;
        private System.Windows.Forms.ToolStripButton btnCheck;
        private System.Windows.Forms.ToolStripButton btnUncheck;
        private System.Windows.Forms.RichTextBox txtName;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nameFilterDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn typeFilterDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private DataSet.dsReportMainFilter dsReportMainFilter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNameFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTypeFilter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvDeleted;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvFlag;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dgvGroup;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dgvMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdClass;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}