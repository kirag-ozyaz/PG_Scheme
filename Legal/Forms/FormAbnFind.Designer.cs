namespace Legal.Forms
{
    partial class FormAbnObjFind
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
            this.dgvAbn = new System.Windows.Forms.DataGridView();
            this.dgvIDAbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodeAbonent = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dgvName = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.NumberObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberSubObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvObjName = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dgvNumber = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dgvNameGroup = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.TypeAbn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.AbnWorker = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.ObjWorker = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dgvIDAbnObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flag = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.DateOn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.DateOff = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.DateBegin = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schmObjName = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.tAbnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFind1 = new Legal.DataSet.dsFind();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbxFilter = new System.Windows.Forms.ToolStripComboBox();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.btnDelFilter = new System.Windows.Forms.ToolStripButton();
            this.cbxFilter2 = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAbnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFind1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAbn
            // 
            this.dgvAbn.AllowUserToAddRows = false;
            this.dgvAbn.AllowUserToDeleteRows = false;
            this.dgvAbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAbn.AutoGenerateColumns = false;
            this.dgvAbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIDAbn,
            this.dgvCodeAbonent,
            this.dgvName,
            this.NumberObj,
            this.NumberSubObj,
            this.dgvObjName,
            this.dgvNumber,
            this.dgvNameGroup,
            this.TypeAbn,
            this.AbnWorker,
            this.ObjWorker,
            this.dgvIDAbnObj,
            this.Flag,
            this.DateOn,
            this.DateOff,
            this.DateBegin,
            this.DateEnd,
            this.schmObjName});
            this.dgvAbn.DataSource = this.tAbnBindingSource;
            this.dgvAbn.Location = new System.Drawing.Point(0, 28);
            this.dgvAbn.MultiSelect = false;
            this.dgvAbn.Name = "dgvAbn";
            this.dgvAbn.ReadOnly = true;
            this.dgvAbn.RowHeadersWidth = 10;
            this.dgvAbn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbn.Size = new System.Drawing.Size(1002, 482);
            this.dgvAbn.TabIndex = 0;
            this.dgvAbn.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAbn_CellMouseDoubleClick);
            this.dgvAbn.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvAbn_RowPrePaint);
            this.dgvAbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAbn_KeyDown);
            // 
            // dgvIDAbn
            // 
            this.dgvIDAbn.DataPropertyName = "idAbn";
            this.dgvIDAbn.HeaderText = "idAbn";
            this.dgvIDAbn.Name = "dgvIDAbn";
            this.dgvIDAbn.ReadOnly = true;
            this.dgvIDAbn.Visible = false;
            // 
            // dgvCodeAbonent
            // 
            this.dgvCodeAbonent.DataPropertyName = "CodeAbonent";
            this.dgvCodeAbonent.HeaderText = "Код";
            this.dgvCodeAbonent.Name = "dgvCodeAbonent";
            this.dgvCodeAbonent.ReadOnly = true;
            this.dgvCodeAbonent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCodeAbonent.Width = 70;
            // 
            // dgvName
            // 
            this.dgvName.DataPropertyName = "Name";
            this.dgvName.HeaderText = "Потребитель";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            this.dgvName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvName.Width = 200;
            // 
            // NumberObj
            // 
            this.NumberObj.DataPropertyName = "NumberObj";
            this.NumberObj.HeaderText = "№об";
            this.NumberObj.Name = "NumberObj";
            this.NumberObj.ReadOnly = true;
            this.NumberObj.Width = 50;
            // 
            // NumberSubObj
            // 
            this.NumberSubObj.DataPropertyName = "NumberSubObj";
            this.NumberSubObj.HeaderText = "№суб";
            this.NumberSubObj.Name = "NumberSubObj";
            this.NumberSubObj.ReadOnly = true;
            this.NumberSubObj.Width = 50;
            // 
            // dgvObjName
            // 
            this.dgvObjName.DataPropertyName = "ObjName";
            this.dgvObjName.HeaderText = "Объект";
            this.dgvObjName.Name = "dgvObjName";
            this.dgvObjName.ReadOnly = true;
            this.dgvObjName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObjName.Width = 250;
            // 
            // dgvNumber
            // 
            this.dgvNumber.DataPropertyName = "Number";
            this.dgvNumber.HeaderText = "Счетчик";
            this.dgvNumber.Name = "dgvNumber";
            this.dgvNumber.ReadOnly = true;
            this.dgvNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNumber.Width = 130;
            // 
            // dgvNameGroup
            // 
            this.dgvNameGroup.DataPropertyName = "Name_Group";
            this.dgvNameGroup.HeaderText = "ТП";
            this.dgvNameGroup.Name = "dgvNameGroup";
            this.dgvNameGroup.ReadOnly = true;
            this.dgvNameGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNameGroup.Width = 130;
            // 
            // TypeAbn
            // 
            this.TypeAbn.DataPropertyName = "TypeAbn";
            this.TypeAbn.HeaderText = "Тип";
            this.TypeAbn.Name = "TypeAbn";
            this.TypeAbn.ReadOnly = true;
            this.TypeAbn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AbnWorker
            // 
            this.AbnWorker.DataPropertyName = "AbnWorker";
            this.AbnWorker.HeaderText = "Специалист";
            this.AbnWorker.Name = "AbnWorker";
            this.AbnWorker.ReadOnly = true;
            this.AbnWorker.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ObjWorker
            // 
            this.ObjWorker.DataPropertyName = "ObjWorker";
            this.ObjWorker.HeaderText = "Мастер";
            this.ObjWorker.Name = "ObjWorker";
            this.ObjWorker.ReadOnly = true;
            this.ObjWorker.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvIDAbnObj
            // 
            this.dgvIDAbnObj.DataPropertyName = "idAbnObj";
            this.dgvIDAbnObj.HeaderText = "idAbnObj";
            this.dgvIDAbnObj.Name = "dgvIDAbnObj";
            this.dgvIDAbnObj.ReadOnly = true;
            this.dgvIDAbnObj.Visible = false;
            // 
            // Flag
            // 
            this.Flag.DataPropertyName = "Flag";
            this.Flag.HeaderText = "Актив";
            this.Flag.Name = "Flag";
            this.Flag.ReadOnly = true;
            this.Flag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Flag.Width = 70;
            // 
            // DateOn
            // 
            this.DateOn.DataPropertyName = "DateOn";
            this.DateOn.HeaderText = "Включен с";
            this.DateOn.Name = "DateOn";
            this.DateOn.ReadOnly = true;
            this.DateOn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateOn.Width = 120;
            // 
            // DateOff
            // 
            this.DateOff.DataPropertyName = "DateOff";
            this.DateOff.HeaderText = "Исключен с";
            this.DateOff.Name = "DateOff";
            this.DateOff.ReadOnly = true;
            this.DateOff.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateOff.Width = 120;
            // 
            // DateBegin
            // 
            this.DateBegin.DataPropertyName = "DateBegin";
            this.DateBegin.HeaderText = "Установка";
            this.DateBegin.Name = "DateBegin";
            this.DateBegin.ReadOnly = true;
            this.DateBegin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateBegin.Width = 120;
            // 
            // DateEnd
            // 
            this.DateEnd.DataPropertyName = "DateEnd";
            this.DateEnd.HeaderText = "Демонтаж";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.ReadOnly = true;
            this.DateEnd.Width = 120;
            // 
            // schmObjName
            // 
            this.schmObjName.DataPropertyName = "schmObjName";
            this.schmObjName.HeaderText = "Подстанция";
            this.schmObjName.Name = "schmObjName";
            this.schmObjName.ReadOnly = true;
            this.schmObjName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tAbnBindingSource
            // 
            this.tAbnBindingSource.DataMember = "vG_AbnObjCnt";
            this.tAbnBindingSource.DataSource = this.dsFind1;
            // 
            // dsFind1
            // 
            this.dsFind1.DataSetName = "dsFind";
            this.dsFind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbxFilter,
            this.txtFilter,
            this.btnFilter,
            this.btnDelFilter,
            this.cbxFilter2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1002, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbxFilter
            // 
            this.cbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxFilter.Items.AddRange(new object[] {
            "Наименование",
            "Объект",
            "Счетчик",
            "ТП",
            "Сетевая организация",
            "Сбытовая организация",
            "Дополнительный код",
            "Подстанция"});
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(200, 25);
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(250, 25);
            // 
            // btnFilter
            // 
            this.btnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilter.Image = global::Legal.Properties.Resources.Filtr_my;
            this.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(23, 22);
            this.btnFilter.Text = "Фильтровать";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnDelFilter
            // 
            this.btnDelFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelFilter.Image = global::Legal.Properties.Resources.Close;
            this.btnDelFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelFilter.Name = "btnDelFilter";
            this.btnDelFilter.Size = new System.Drawing.Size(23, 22);
            this.btnDelFilter.Text = "Убрать фильтр";
            this.btnDelFilter.Click += new System.EventHandler(this.btnDelFilter_Click);
            // 
            // cbxFilter2
            // 
            this.cbxFilter2.Name = "cbxFilter2";
            this.cbxFilter2.Size = new System.Drawing.Size(250, 25);
            // 
            // FormAbnObjFind
            // 
            this.ClientSize = new System.Drawing.Size(1002, 506);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvAbn);
            this.Name = "FormAbnObjFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAbnObjFind_FormClosed);
            this.Load += new System.EventHandler(this.FormAbnFind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAbnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFind1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbn;
        private System.Windows.Forms.BindingSource tAbnBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cbxFilter;
        private System.Windows.Forms.ToolStripButton btnFilter;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
        //private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dgv_nameGroup;
        private System.Windows.Forms.ToolStripButton btnDelFilter;
        private System.Windows.Forms.ToolStripComboBox cbxFilter2;
        private DataSet.dsFind dsFind1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDAbn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dgvCodeAbonent;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberSubObj;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dgvObjName;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dgvNumber;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dgvNameGroup;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn TypeAbn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn AbnWorker;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn ObjWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDAbnObj;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn Flag;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn DateOn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn DateOff;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn DateBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn schmObjName;
    }
}
