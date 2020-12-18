namespace Legal.Forms
{
    partial class FormObjSelect
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.vGAbnObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsObj1 = new Legal.DataSet.dsObj();
            this.ObjBS = new System.Windows.Forms.BindingSource(this.components);
            this.SelectDGVEF = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.SelectCell = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameStreetDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.socrDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.housePrefixDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAbnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeAbonent_old = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Name_old = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tsObjSelect = new System.Windows.Forms.ToolStrip();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.vGAbnObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDGVEF)).BeginInit();
            this.tsObjSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // vGAbnObjBindingSource
            // 
            this.vGAbnObjBindingSource.DataMember = "vG_AbnObj";
            this.vGAbnObjBindingSource.DataSource = this.dsObj1;
            // 
            // dsObj1
            // 
            this.dsObj1.DataSetName = "dsObj";
            this.dsObj1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ObjBS
            // 
            this.ObjBS.DataMember = "vG_Obj";
            this.ObjBS.DataSource = this.dsObj1;
            // 
            // SelectDGVEF
            // 
            this.SelectDGVEF.AllowUserToAddRows = false;
            this.SelectDGVEF.AllowUserToDeleteRows = false;
            this.SelectDGVEF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectDGVEF.AutoGenerateColumns = false;
            this.SelectDGVEF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectDGVEF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCell,
            this.nameDataGridViewTextBoxColumn,
            this.nameStreetDataGridViewTextBoxColumn,
            this.socrDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.housePrefixDataGridViewTextBoxColumn,
            this.idAbnDataGridViewTextBoxColumn1,
            this.id,
            this.typeAbnDataGridViewTextBoxColumn1,
            this.docNumberDataGridViewTextBoxColumn,
            this.docNameDataGridViewTextBoxColumn,
            this.CodeAbonent_old,
            this.Name_old});
            this.SelectDGVEF.DataSource = this.ObjBS;
            this.SelectDGVEF.Location = new System.Drawing.Point(0, 28);
            this.SelectDGVEF.Name = "SelectDGVEF";
            this.SelectDGVEF.RowHeadersWidth = 21;
            this.SelectDGVEF.Size = new System.Drawing.Size(871, 455);
            this.SelectDGVEF.TabIndex = 2;
            this.SelectDGVEF.DoubleClick += new System.EventHandler(this.SelectDGVEF_DoubleClick);
            // 
            // SelectCell
            // 
            this.SelectCell.HeaderText = "Выбор";
            this.SelectCell.Name = "SelectCell";
            this.SelectCell.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.Width = 350;
            // 
            // nameStreetDataGridViewTextBoxColumn
            // 
            this.nameStreetDataGridViewTextBoxColumn.DataPropertyName = "NameStreet";
            this.nameStreetDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.nameStreetDataGridViewTextBoxColumn.Name = "nameStreetDataGridViewTextBoxColumn";
            this.nameStreetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // socrDataGridViewTextBoxColumn
            // 
            this.socrDataGridViewTextBoxColumn.DataPropertyName = "Socr";
            this.socrDataGridViewTextBoxColumn.HeaderText = "";
            this.socrDataGridViewTextBoxColumn.Name = "socrDataGridViewTextBoxColumn";
            this.socrDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.socrDataGridViewTextBoxColumn.Width = 30;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.houseDataGridViewTextBoxColumn.Width = 60;
            // 
            // housePrefixDataGridViewTextBoxColumn
            // 
            this.housePrefixDataGridViewTextBoxColumn.DataPropertyName = "HousePrefix";
            this.housePrefixDataGridViewTextBoxColumn.HeaderText = "";
            this.housePrefixDataGridViewTextBoxColumn.Name = "housePrefixDataGridViewTextBoxColumn";
            this.housePrefixDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.housePrefixDataGridViewTextBoxColumn.Width = 30;
            // 
            // idAbnDataGridViewTextBoxColumn1
            // 
            this.idAbnDataGridViewTextBoxColumn1.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn1.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn1.Name = "idAbnDataGridViewTextBoxColumn1";
            this.idAbnDataGridViewTextBoxColumn1.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // typeAbnDataGridViewTextBoxColumn1
            // 
            this.typeAbnDataGridViewTextBoxColumn1.DataPropertyName = "TypeAbn";
            this.typeAbnDataGridViewTextBoxColumn1.HeaderText = "TypeAbn";
            this.typeAbnDataGridViewTextBoxColumn1.Name = "typeAbnDataGridViewTextBoxColumn1";
            this.typeAbnDataGridViewTextBoxColumn1.Visible = false;
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
            // CodeAbonent_old
            // 
            this.CodeAbonent_old.DataPropertyName = "CodeAbonent_old";
            this.CodeAbonent_old.HeaderText = "Код";
            this.CodeAbonent_old.Name = "CodeAbonent_old";
            this.CodeAbonent_old.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CodeAbonent_old.Width = 80;
            // 
            // Name_old
            // 
            this.Name_old.DataPropertyName = "Name_old";
            this.Name_old.HeaderText = "Контрагент";
            this.Name_old.Name = "Name_old";
            this.Name_old.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Name_old.Width = 115;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSelect.Location = new System.Drawing.Point(355, 489);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "Выбрать";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(463, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tsObjSelect
            // 
            this.tsObjSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK,
            this.btnCancel});
            this.tsObjSelect.Location = new System.Drawing.Point(0, 0);
            this.tsObjSelect.Name = "tsObjSelect";
            this.tsObjSelect.Size = new System.Drawing.Size(871, 25);
            this.tsObjSelect.TabIndex = 5;
            this.tsObjSelect.Text = "toolStrip1";
            // 
            // btnOK
            // 
            this.btnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOK.Image = global::Legal.Properties.Resources._1304663065_Add;
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(23, 22);
            this.btnOK.Text = "выбрать все";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancel.Image = global::Legal.Properties.Resources.Delete;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(23, 22);
            this.btnCancel.Text = "отменить все";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormObjSelect
            // 
            this.AcceptButton = this.buttonSelect;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(871, 524);
            this.Controls.Add(this.tsObjSelect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.SelectDGVEF);
            this.Name = "FormObjSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выберите объект или несколько объектов";
            this.Load += new System.EventHandler(this.FormObjSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vGAbnObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDGVEF)).EndInit();
            this.tsObjSelect.ResumeLayout(false);
            this.tsObjSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Legal.DataSet.dsObj dsObj1;
        private System.Windows.Forms.BindingSource vGAbnObjBindingSource;
        private System.Windows.Forms.BindingSource ObjBS;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter SelectDGVEF;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip tsObjSelect;
        private System.Windows.Forms.ToolStripButton btnOK;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCell;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameStreetDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn socrDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn houseDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn housePrefixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeAbnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn CodeAbonent_old;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn Name_old;

    }
}
