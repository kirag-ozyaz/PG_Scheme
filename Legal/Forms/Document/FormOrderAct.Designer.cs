namespace Legal.Forms.Document
{
    partial class FormOrderAct
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
            this.dgvObjDoc = new System.Windows.Forms.DataGridView();
            this.bsObjDoc = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbnDocum1 = new Legal.DataSet.dsAbnDocum();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idObjDocDGVBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNumberDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.docDateDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idDocTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObjDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObjDoc
            // 
            this.dgvObjDoc.AllowUserToAddRows = false;
            this.dgvObjDoc.AllowUserToDeleteRows = false;
            this.dgvObjDoc.AutoGenerateColumns = false;
            this.dgvObjDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isActiveDataGridViewTextBoxColumn,
            this.idObjDocDGVBC,
            this.idAbnObjDataGridViewTextBoxColumn,
            this.docNumberDataGridViewTextBoxColumn,
            this.docDateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.idDocTypeDataGridViewTextBoxColumn,
            this.parentKeyDataGridViewTextBoxColumn});
            this.dgvObjDoc.DataSource = this.bsObjDoc;
            this.dgvObjDoc.Location = new System.Drawing.Point(3, 3);
            this.dgvObjDoc.Name = "dgvObjDoc";
            this.dgvObjDoc.ReadOnly = true;
            this.dgvObjDoc.RowHeadersWidth = 5;
            this.dgvObjDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjDoc.Size = new System.Drawing.Size(622, 246);
            this.dgvObjDoc.TabIndex = 0;
            this.dgvObjDoc.DoubleClick += new System.EventHandler(this.dgvObjDoc_DoubleClick);
            // 
            // bsObjDoc
            // 
            this.bsObjDoc.DataMember = "vAbnObjDoc_List";
            this.bsObjDoc.DataSource = this.dsAbnDocum1;
            // 
            // dsAbnDocum1
            // 
            this.dsAbnDocum1.DataSetName = "dsAbnDocum";
            this.dsAbnDocum1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(458, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(550, 261);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // isActiveDataGridViewTextBoxColumn
            // 
            this.isActiveDataGridViewTextBoxColumn.DataPropertyName = "isActive";
            this.isActiveDataGridViewTextBoxColumn.HeaderText = "";
            this.isActiveDataGridViewTextBoxColumn.Name = "isActiveDataGridViewTextBoxColumn";
            this.isActiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActiveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isActiveDataGridViewTextBoxColumn.Width = 30;
            // 
            // idObjDocDGVBC
            // 
            this.idObjDocDGVBC.DataPropertyName = "id";
            this.idObjDocDGVBC.HeaderText = "id";
            this.idObjDocDGVBC.Name = "idObjDocDGVBC";
            this.idObjDocDGVBC.ReadOnly = true;
            this.idObjDocDGVBC.Visible = false;
            // 
            // idAbnObjDataGridViewTextBoxColumn
            // 
            this.idAbnObjDataGridViewTextBoxColumn.DataPropertyName = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.HeaderText = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.idAbnObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // docNumberDataGridViewTextBoxColumn
            // 
            this.docNumberDataGridViewTextBoxColumn.DataPropertyName = "DocNumber";
            this.docNumberDataGridViewTextBoxColumn.HeaderText = "№";
            this.docNumberDataGridViewTextBoxColumn.Name = "docNumberDataGridViewTextBoxColumn";
            this.docNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.docNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // docDateDataGridViewTextBoxColumn
            // 
            this.docDateDataGridViewTextBoxColumn.DataPropertyName = "DocDate";
            this.docDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.docDateDataGridViewTextBoxColumn.Name = "docDateDataGridViewTextBoxColumn";
            this.docDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.docDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.docDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Тип документа";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.Width = 375;
            // 
            // idDocTypeDataGridViewTextBoxColumn
            // 
            this.idDocTypeDataGridViewTextBoxColumn.DataPropertyName = "idDocType";
            this.idDocTypeDataGridViewTextBoxColumn.HeaderText = "idDocType";
            this.idDocTypeDataGridViewTextBoxColumn.Name = "idDocTypeDataGridViewTextBoxColumn";
            this.idDocTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDocTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // parentKeyDataGridViewTextBoxColumn
            // 
            this.parentKeyDataGridViewTextBoxColumn.DataPropertyName = "ParentKey";
            this.parentKeyDataGridViewTextBoxColumn.HeaderText = "ParentKey";
            this.parentKeyDataGridViewTextBoxColumn.Name = "parentKeyDataGridViewTextBoxColumn";
            this.parentKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormOrderAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 290);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvObjDoc);
            this.Name = "FormOrderAct";
            this.Text = "Акты";
            this.Load += new System.EventHandler(this.FormOrderAct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObjDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObjDoc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.BindingSource bsObjDoc;
        private DataSet.dsAbnDocum dsAbnDocum1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjDocDGVBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnObjDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn docNumberDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn docDateDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentKeyDataGridViewTextBoxColumn;
    }
}