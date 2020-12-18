namespace Legal.Forms.Document
{
    partial class FormOrderObjectAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderObjectAdd));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmbAdd = new System.Windows.Forms.ToolStripButton();
            this.cmbDel = new System.Windows.Forms.ToolStripButton();
            this.cmbAddObject = new System.Windows.Forms.ToolStripButton();
            this.txtCode = new System.Windows.Forms.ToolStripTextBox();
            this.cmbAddObjectAddress = new System.Windows.Forms.ToolStripButton();
            this.dgvObject = new System.Windows.Forms.DataGridView();
            this.SelectCell = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameObjDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameStreet = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.socr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.house = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.housePrefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.contDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateGraphDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateActDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbnDocum1 = new Legal.DataSet.dsAbnDocum();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbAdd,
            this.cmbDel,
            this.cmbAddObject,
            this.txtCode,
            this.cmbAddObjectAddress});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(939, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmbAdd
            // 
            this.cmbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmbAdd.Image = global::Legal.Properties.Resources._1304663065_Add;
            this.cmbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmbAdd.Name = "cmbAdd";
            this.cmbAdd.Size = new System.Drawing.Size(23, 22);
            this.cmbAdd.Text = "Выбрать все";
            this.cmbAdd.ToolTipText = "Выбрать все";
            this.cmbAdd.Click += new System.EventHandler(this.cmbAdd_Click);
            // 
            // cmbDel
            // 
            this.cmbDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmbDel.Image = global::Legal.Properties.Resources.Delete;
            this.cmbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmbDel.Name = "cmbDel";
            this.cmbDel.Size = new System.Drawing.Size(23, 22);
            this.cmbDel.ToolTipText = "Отменить все";
            this.cmbDel.Click += new System.EventHandler(this.cmbDel_Click);
            // 
            // cmbAddObject
            // 
            this.cmbAddObject.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbAddObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmbAddObject.ForeColor = System.Drawing.Color.Red;
            this.cmbAddObject.Image = ((System.Drawing.Image)(resources.GetObject("cmbAddObject.Image")));
            this.cmbAddObject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmbAddObject.Name = "cmbAddObject";
            this.cmbAddObject.Size = new System.Drawing.Size(58, 22);
            this.cmbAddObject.Text = "Выбрать";
            this.cmbAddObject.Click += new System.EventHandler(this.cmbAddObject_Click);
            // 
            // txtCode
            // 
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 25);
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyUp);
            // 
            // cmbAddObjectAddress
            // 
            this.cmbAddObjectAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmbAddObjectAddress.Image = global::Legal.Properties.Resources.tick_octagon;
            this.cmbAddObjectAddress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmbAddObjectAddress.Name = "cmbAddObjectAddress";
            this.cmbAddObjectAddress.Size = new System.Drawing.Size(23, 22);
            this.cmbAddObjectAddress.Text = "toolStripButton1";
            this.cmbAddObjectAddress.ToolTipText = "Отметить все объекты по данному адресу";
            this.cmbAddObjectAddress.Click += new System.EventHandler(this.cmbAddObjectAddress_Click);
            // 
            // dgvObject
            // 
            this.dgvObject.AllowUserToAddRows = false;
            this.dgvObject.AllowUserToDeleteRows = false;
            this.dgvObject.AutoGenerateColumns = false;
            this.dgvObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCell,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.typeAbnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn,
            this.idObj,
            this.numberObjDataGridViewTextBoxColumn,
            this.nameObjDataGridViewTextBoxColumn,
            this.nameStreet,
            this.socr,
            this.house,
            this.housePrefix,
            this.idAbnDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.docNumberDataGridViewTextBoxColumn,
            this.docNameDataGridViewTextBoxColumn,
            this.masterIDDataGridViewTextBoxColumn,
            this.masterDataGridViewTextBoxColumn,
            this.contDataGridViewTextBoxColumn,
            this.dateGraphDataGridViewTextBoxColumn,
            this.dateActDataGridViewTextBoxColumn});
            this.dgvObject.DataSource = this.bindingSource2;
            this.dgvObject.Location = new System.Drawing.Point(0, 28);
            this.dgvObject.Name = "dgvObject";
            this.dgvObject.RowHeadersWidth = 5;
            this.dgvObject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObject.Size = new System.Drawing.Size(939, 508);
            this.dgvObject.TabIndex = 1;
            this.dgvObject.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvObject_CurrentCellDirtyStateChanged);
            // 
            // SelectCell
            // 
            this.SelectCell.HeaderText = "Выбор";
            this.SelectCell.Name = "SelectCell";
            this.SelectCell.Width = 50;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 60;
            // 
            // typeAbnDataGridViewTextBoxColumn
            // 
            this.typeAbnDataGridViewTextBoxColumn.DataPropertyName = "TypeAbn";
            this.typeAbnDataGridViewTextBoxColumn.HeaderText = "TypeAbn";
            this.typeAbnDataGridViewTextBoxColumn.Name = "typeAbnDataGridViewTextBoxColumn";
            this.typeAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Потребитель";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // idObj
            // 
            this.idObj.DataPropertyName = "idObj";
            this.idObj.HeaderText = "idObj";
            this.idObj.Name = "idObj";
            this.idObj.Visible = false;
            // 
            // numberObjDataGridViewTextBoxColumn
            // 
            this.numberObjDataGridViewTextBoxColumn.DataPropertyName = "NumberObj";
            this.numberObjDataGridViewTextBoxColumn.HeaderText = "№об";
            this.numberObjDataGridViewTextBoxColumn.Name = "numberObjDataGridViewTextBoxColumn";
            this.numberObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberObjDataGridViewTextBoxColumn.Width = 40;
            // 
            // nameObjDataGridViewTextBoxColumn
            // 
            this.nameObjDataGridViewTextBoxColumn.DataPropertyName = "NameObj";
            this.nameObjDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.nameObjDataGridViewTextBoxColumn.Name = "nameObjDataGridViewTextBoxColumn";
            this.nameObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameObjDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameObjDataGridViewTextBoxColumn.Width = 160;
            // 
            // nameStreet
            // 
            this.nameStreet.DataPropertyName = "NameStreet";
            this.nameStreet.HeaderText = "Улица";
            this.nameStreet.Name = "nameStreet";
            this.nameStreet.ReadOnly = true;
            this.nameStreet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // socr
            // 
            this.socr.DataPropertyName = "Socr";
            this.socr.HeaderText = "";
            this.socr.Name = "socr";
            this.socr.ReadOnly = true;
            this.socr.Width = 25;
            // 
            // house
            // 
            this.house.DataPropertyName = "House";
            this.house.HeaderText = "Дом";
            this.house.Name = "house";
            this.house.ReadOnly = true;
            this.house.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.house.Width = 55;
            // 
            // housePrefix
            // 
            this.housePrefix.DataPropertyName = "HousePrefix";
            this.housePrefix.HeaderText = "";
            this.housePrefix.Name = "housePrefix";
            this.housePrefix.ReadOnly = true;
            this.housePrefix.Width = 30;
            // 
            // idAbnDataGridViewTextBoxColumn
            // 
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // docNumberDataGridViewTextBoxColumn
            // 
            this.docNumberDataGridViewTextBoxColumn.DataPropertyName = "DocNumber";
            this.docNumberDataGridViewTextBoxColumn.HeaderText = "DocNumber";
            this.docNumberDataGridViewTextBoxColumn.Name = "docNumberDataGridViewTextBoxColumn";
            this.docNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // docNameDataGridViewTextBoxColumn
            // 
            this.docNameDataGridViewTextBoxColumn.DataPropertyName = "DocName";
            this.docNameDataGridViewTextBoxColumn.HeaderText = "DocName";
            this.docNameDataGridViewTextBoxColumn.Name = "docNameDataGridViewTextBoxColumn";
            this.docNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // masterIDDataGridViewTextBoxColumn
            // 
            this.masterIDDataGridViewTextBoxColumn.DataPropertyName = "MasterID";
            this.masterIDDataGridViewTextBoxColumn.HeaderText = "MasterID";
            this.masterIDDataGridViewTextBoxColumn.Name = "masterIDDataGridViewTextBoxColumn";
            this.masterIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // masterDataGridViewTextBoxColumn
            // 
            this.masterDataGridViewTextBoxColumn.DataPropertyName = "Master";
            this.masterDataGridViewTextBoxColumn.HeaderText = "Мастер";
            this.masterDataGridViewTextBoxColumn.Name = "masterDataGridViewTextBoxColumn";
            this.masterDataGridViewTextBoxColumn.ReadOnly = true;
            this.masterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // contDataGridViewTextBoxColumn
            // 
            this.contDataGridViewTextBoxColumn.DataPropertyName = "Cont";
            this.contDataGridViewTextBoxColumn.HeaderText = "Специалист";
            this.contDataGridViewTextBoxColumn.Name = "contDataGridViewTextBoxColumn";
            this.contDataGridViewTextBoxColumn.ReadOnly = true;
            this.contDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateGraphDataGridViewTextBoxColumn
            // 
            this.dateGraphDataGridViewTextBoxColumn.DataPropertyName = "DateGraph";
            this.dateGraphDataGridViewTextBoxColumn.HeaderText = "DateGraph";
            this.dateGraphDataGridViewTextBoxColumn.Name = "dateGraphDataGridViewTextBoxColumn";
            this.dateGraphDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateActDataGridViewTextBoxColumn
            // 
            this.dateActDataGridViewTextBoxColumn.DataPropertyName = "DateAct";
            this.dateActDataGridViewTextBoxColumn.HeaderText = "Дата акта";
            this.dateActDataGridViewTextBoxColumn.Name = "dateActDataGridViewTextBoxColumn";
            this.dateActDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateActDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "vG_GraphicPointViewSmall";
            this.bindingSource2.DataSource = this.dsAbnDocum1;
            // 
            // dsAbnDocum1
            // 
            this.dsAbnDocum1.DataSetName = "dsAbnDocum";
            this.dsAbnDocum1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormOrderObjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 534);
            this.Controls.Add(this.dgvObject);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormOrderObjectAdd";
            this.Text = "Выберите объекты для обследования";
            this.Load += new System.EventHandler(this.FormOrderObjectAdd_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmbAdd;
        private System.Windows.Forms.ToolStripButton cmbDel;
        private System.Windows.Forms.DataGridView dgvObject;
        private DataSet.dsAbnDocum dsAbnDocum1;
        private System.Windows.Forms.ToolStripButton cmbAddObject;
        private System.Windows.Forms.ToolStripTextBox txtCode;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.ToolStripButton cmbAddObjectAddress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCell;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeAbnDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberObjDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameObjDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn socr;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn house;
        private System.Windows.Forms.DataGridViewTextBoxColumn housePrefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterIDDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn masterDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn contDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGraphDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dateActDataGridViewTextBoxColumn;
    }
}