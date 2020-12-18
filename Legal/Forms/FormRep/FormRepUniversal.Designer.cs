namespace Legal.Forms.FormRep
{
    partial class FormRepUniversal
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pExecutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAbnCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAbnNext = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAbn = new System.Windows.Forms.DataGridView();
            this.bindingSourceAbn = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbnDocum1 = new Legal.DataSet.dsAbnDocum();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCheck = new System.Windows.Forms.ToolStripButton();
            this.btnUncheck = new System.Windows.Forms.ToolStripButton();
            this.idDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectCell = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeDogDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(166, 427);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Сформировать";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(281, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pExecutor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pPhone);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(522, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 112);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "параметры ";
            // 
            // pExecutor
            // 
            this.pExecutor.Location = new System.Drawing.Point(6, 35);
            this.pExecutor.Name = "pExecutor";
            this.pExecutor.Size = new System.Drawing.Size(241, 20);
            this.pExecutor.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "исполнитель";
            // 
            // pPhone
            // 
            this.pPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pPhone.Location = new System.Drawing.Point(6, 74);
            this.pPhone.Name = "pPhone";
            this.pPhone.Size = new System.Drawing.Size(241, 20);
            this.pPhone.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "телефон";
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(6, 45);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(500, 23);
            this.pBar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(275, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "из:";
            // 
            // txtAbnCount
            // 
            this.txtAbnCount.Location = new System.Drawing.Point(303, 19);
            this.txtAbnCount.Name = "txtAbnCount";
            this.txtAbnCount.Size = new System.Drawing.Size(91, 20);
            this.txtAbnCount.TabIndex = 13;
            this.txtAbnCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Сформировано документов:";
            // 
            // txtAbnNext
            // 
            this.txtAbnNext.Location = new System.Drawing.Point(162, 19);
            this.txtAbnNext.Name = "txtAbnNext";
            this.txtAbnNext.Size = new System.Drawing.Size(91, 20);
            this.txtAbnNext.TabIndex = 15;
            this.txtAbnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pBar);
            this.groupBox3.Controls.Add(this.txtAbnNext);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtAbnCount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(4, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 77);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "процесс формирования";
            // 
            // dgvAbn
            // 
            this.dgvAbn.AllowUserToAddRows = false;
            this.dgvAbn.AllowUserToDeleteRows = false;
            this.dgvAbn.AutoGenerateColumns = false;
            this.dgvAbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDgv,
            this.SelectCell,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.idWorkerDataGridViewTextBoxColumn,
            this.familDataGridViewTextBoxColumn,
            this.typeDogDataGridViewTextBoxColumn});
            this.dgvAbn.DataSource = this.bindingSourceAbn;
            this.dgvAbn.Location = new System.Drawing.Point(4, 28);
            this.dgvAbn.Name = "dgvAbn";
            this.dgvAbn.RowHeadersWidth = 5;
            this.dgvAbn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbn.Size = new System.Drawing.Size(777, 304);
            this.dgvAbn.TabIndex = 17;
            this.dgvAbn.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvAbn_CurrentCellDirtyStateChanged);
            // 
            // bindingSourceAbn
            // 
            this.bindingSourceAbn.DataMember = "vG_Customer";
            this.bindingSourceAbn.DataSource = this.dsAbnDocum1;
            // 
            // dsAbnDocum1
            // 
            this.dsAbnDocum1.DataSetName = "dsAbnDocum";
            this.dsAbnDocum1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCheck,
            this.btnUncheck});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(781, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
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
            // idDgv
            // 
            this.idDgv.DataPropertyName = "id";
            this.idDgv.HeaderText = "id";
            this.idDgv.Name = "idDgv";
            this.idDgv.Visible = false;
            // 
            // SelectCell
            // 
            this.SelectCell.HeaderText = "Выбор";
            this.SelectCell.Name = "SelectCell";
            this.SelectCell.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectCell.Width = 50;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 75;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Потребитель";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.Width = 375;
            // 
            // idWorkerDataGridViewTextBoxColumn
            // 
            this.idWorkerDataGridViewTextBoxColumn.DataPropertyName = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn.HeaderText = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn.Name = "idWorkerDataGridViewTextBoxColumn";
            this.idWorkerDataGridViewTextBoxColumn.Visible = false;
            // 
            // familDataGridViewTextBoxColumn
            // 
            this.familDataGridViewTextBoxColumn.DataPropertyName = "Famil";
            this.familDataGridViewTextBoxColumn.HeaderText = "Специалист";
            this.familDataGridViewTextBoxColumn.Name = "familDataGridViewTextBoxColumn";
            this.familDataGridViewTextBoxColumn.ReadOnly = true;
            this.familDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.familDataGridViewTextBoxColumn.Width = 120;
            // 
            // typeDogDataGridViewTextBoxColumn
            // 
            this.typeDogDataGridViewTextBoxColumn.DataPropertyName = "TypeDog";
            this.typeDogDataGridViewTextBoxColumn.HeaderText = "Договор";
            this.typeDogDataGridViewTextBoxColumn.Name = "typeDogDataGridViewTextBoxColumn";
            this.typeDogDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDogDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDogDataGridViewTextBoxColumn.Width = 120;
            // 
            // FormRepUniversal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 462);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvAbn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "FormRepUniversal";
            this.Text = "Печать документов по выбранным потребителям";
            this.Load += new System.EventHandler(this.FormRepUniversal_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox pExecutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pPhone;
        private System.Windows.Forms.Label label3;
        private DataSet.dsAbnDocum dsAbnDocum1;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAbnCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAbnNext;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvAbn;
        private System.Windows.Forms.BindingSource bindingSourceAbn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCheck;
        private System.Windows.Forms.ToolStripButton btnUncheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDgv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCell;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn familDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn typeDogDataGridViewTextBoxColumn;
    }
}