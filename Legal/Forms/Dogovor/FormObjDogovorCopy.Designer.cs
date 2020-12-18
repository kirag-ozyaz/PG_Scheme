namespace Legal.Forms.Dogovor
{
    partial class FormObjDogovorCopy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsAbn = new Legal.DataSet.DataSetAbn();
            this.bsAbnDoc = new System.Windows.Forms.BindingSource(this.components);
            this.dgvAbnDoc = new System.Windows.Forms.DataGridView();
            this.idDocDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnDGTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.docNumberDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocTypeDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDocObj = new System.Windows.Forms.BindingSource(this.components);
            this.dgvObj = new System.Windows.Forms.DataGridView();
            this.numberObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberSubObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObjParentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idListDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.bCancel = new System.Windows.Forms.Button();
            this.bCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbnDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObj)).BeginInit();
            this.SuspendLayout();
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetAbn";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsAbnDoc
            // 
            this.bsAbnDoc.DataMember = "vAbnDoc_List";
            this.bsAbnDoc.DataSource = this.dsAbn;
            // 
            // dgvAbnDoc
            // 
            this.dgvAbnDoc.AllowUserToAddRows = false;
            this.dgvAbnDoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvAbnDoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAbnDoc.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbnDoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAbnDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbnDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocDGVTBC,
            this.idAbnDGTBC,
            this.isActive,
            this.docNumberDGVTBC,
            this.docDateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn2,
            this.Comment,
            this.idDocTypeDGVTBC,
            this.parentKeyDataGridViewTextBoxColumn});
            this.dgvAbnDoc.DataSource = this.bsAbnDoc;
            this.dgvAbnDoc.Location = new System.Drawing.Point(2, 3);
            this.dgvAbnDoc.MultiSelect = false;
            this.dgvAbnDoc.Name = "dgvAbnDoc";
            this.dgvAbnDoc.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbnDoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAbnDoc.RowHeadersWidth = 5;
            this.dgvAbnDoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAbnDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbnDoc.Size = new System.Drawing.Size(642, 115);
            this.dgvAbnDoc.TabIndex = 4;
            this.dgvAbnDoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAbnDoc_CellMouseClick);
            // 
            // idDocDGVTBC
            // 
            this.idDocDGVTBC.DataPropertyName = "id";
            this.idDocDGVTBC.HeaderText = "id";
            this.idDocDGVTBC.Name = "idDocDGVTBC";
            this.idDocDGVTBC.ReadOnly = true;
            this.idDocDGVTBC.Visible = false;
            // 
            // idAbnDGTBC
            // 
            this.idAbnDGTBC.DataPropertyName = "idAbn";
            this.idAbnDGTBC.HeaderText = "idAbn";
            this.idAbnDGTBC.Name = "idAbnDGTBC";
            this.idAbnDGTBC.ReadOnly = true;
            this.idAbnDGTBC.Visible = false;
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "isActive";
            this.isActive.HeaderText = "";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.Width = 30;
            // 
            // docNumberDGVTBC
            // 
            this.docNumberDGVTBC.DataPropertyName = "DocNumber";
            this.docNumberDGVTBC.HeaderText = "№";
            this.docNumberDGVTBC.Name = "docNumberDGVTBC";
            this.docNumberDGVTBC.ReadOnly = true;
            this.docNumberDGVTBC.Width = 60;
            // 
            // docDateDataGridViewTextBoxColumn
            // 
            this.docDateDataGridViewTextBoxColumn.DataPropertyName = "DocDate";
            this.docDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.docDateDataGridViewTextBoxColumn.Name = "docDateDataGridViewTextBoxColumn";
            this.docDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Тип документа";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn2.Width = 250;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Примечание";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 500;
            // 
            // idDocTypeDGVTBC
            // 
            this.idDocTypeDGVTBC.DataPropertyName = "idDocType";
            this.idDocTypeDGVTBC.HeaderText = "idDocType";
            this.idDocTypeDGVTBC.Name = "idDocTypeDGVTBC";
            this.idDocTypeDGVTBC.ReadOnly = true;
            this.idDocTypeDGVTBC.Visible = false;
            // 
            // parentKeyDataGridViewTextBoxColumn
            // 
            this.parentKeyDataGridViewTextBoxColumn.DataPropertyName = "ParentKey";
            this.parentKeyDataGridViewTextBoxColumn.HeaderText = "ParentKey";
            this.parentKeyDataGridViewTextBoxColumn.Name = "parentKeyDataGridViewTextBoxColumn";
            this.parentKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsDocObj
            // 
            this.bsDocObj.DataMember = "vG_Dog_Obj";
            this.bsDocObj.DataSource = this.dsAbn;
            // 
            // dgvObj
            // 
            this.dgvObj.AllowUserToAddRows = false;
            this.dgvObj.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvObj.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvObj.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberObj,
            this.numberSubObj,
            this.nameDataGridViewTextBoxColumn,
            this.dateBeginDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn,
            this.idDogDataGridViewTextBoxColumn,
            this.idObj,
            this.idObjParentDataGridViewTextBoxColumn,
            this.idAbnDataGridViewTextBoxColumn,
            this.idMapDataGridViewTextBoxColumn,
            this.idListDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dgvObj.DataSource = this.bsDocObj;
            this.dgvObj.Location = new System.Drawing.Point(2, 125);
            this.dgvObj.Name = "dgvObj";
            this.dgvObj.ReadOnly = true;
            this.dgvObj.RowHeadersWidth = 5;
            this.dgvObj.Size = new System.Drawing.Size(642, 150);
            this.dgvObj.TabIndex = 5;
            // 
            // numberObj
            // 
            this.numberObj.DataPropertyName = "NumberObj";
            this.numberObj.HeaderText = "№об.";
            this.numberObj.Name = "numberObj";
            this.numberObj.ReadOnly = true;
            this.numberObj.Width = 50;
            // 
            // numberSubObj
            // 
            this.numberSubObj.DataPropertyName = "NumberSubObj";
            this.numberSubObj.HeaderText = "№суб.";
            this.numberSubObj.Name = "numberSubObj";
            this.numberSubObj.ReadOnly = true;
            this.numberSubObj.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // dateBeginDataGridViewTextBoxColumn
            // 
            this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "DateBegin";
            this.dateBeginDataGridViewTextBoxColumn.HeaderText = "Включен с";
            this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
            this.dateBeginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "Исключен с";
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDogDataGridViewTextBoxColumn
            // 
            this.idDogDataGridViewTextBoxColumn.DataPropertyName = "idDog";
            this.idDogDataGridViewTextBoxColumn.HeaderText = "idDog";
            this.idDogDataGridViewTextBoxColumn.Name = "idDogDataGridViewTextBoxColumn";
            this.idDogDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDogDataGridViewTextBoxColumn.Visible = false;
            // 
            // idObj
            // 
            this.idObj.DataPropertyName = "idObj";
            this.idObj.HeaderText = "idObj";
            this.idObj.Name = "idObj";
            this.idObj.ReadOnly = true;
            this.idObj.Visible = false;
            // 
            // idObjParentDataGridViewTextBoxColumn
            // 
            this.idObjParentDataGridViewTextBoxColumn.DataPropertyName = "IdObjParent";
            this.idObjParentDataGridViewTextBoxColumn.HeaderText = "IdObjParent";
            this.idObjParentDataGridViewTextBoxColumn.Name = "idObjParentDataGridViewTextBoxColumn";
            this.idObjParentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idObjParentDataGridViewTextBoxColumn.Visible = false;
            // 
            // idAbnDataGridViewTextBoxColumn
            // 
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // idMapDataGridViewTextBoxColumn
            // 
            this.idMapDataGridViewTextBoxColumn.DataPropertyName = "idMap";
            this.idMapDataGridViewTextBoxColumn.HeaderText = "idMap";
            this.idMapDataGridViewTextBoxColumn.Name = "idMapDataGridViewTextBoxColumn";
            this.idMapDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMapDataGridViewTextBoxColumn.Visible = false;
            // 
            // idListDataGridViewTextBoxColumn
            // 
            this.idListDataGridViewTextBoxColumn.DataPropertyName = "idList";
            this.idListDataGridViewTextBoxColumn.HeaderText = "idList";
            this.idListDataGridViewTextBoxColumn.Name = "idListDataGridViewTextBoxColumn";
            this.idListDataGridViewTextBoxColumn.ReadOnly = true;
            this.idListDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(117, 291);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(75, 13);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Включить с";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDate.Location = new System.Drawing.Point(198, 289);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 7;
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(569, 286);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Назад";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bCopy
            // 
            this.bCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCopy.Location = new System.Drawing.Point(439, 286);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(95, 23);
            this.bCopy.TabIndex = 9;
            this.bCopy.Text = "Копировать";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // FormObjDogovorCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 314);
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dgvObj);
            this.Controls.Add(this.dgvAbnDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormObjDogovorCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Копирование объектов договора";
            this.Load += new System.EventHandler(this.FormObjDogovorCopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbnDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet.DataSetAbn dsAbn;
        private System.Windows.Forms.BindingSource bsAbnDoc;
        private System.Windows.Forms.DataGridView dgvAbnDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDGTBC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumberDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocTypeDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsDocObj;
        private System.Windows.Forms.DataGridView dgvObj;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberSubObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjParentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idListDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}