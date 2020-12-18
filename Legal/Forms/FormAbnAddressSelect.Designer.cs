namespace Legal.Forms
{
    partial class FormAbnAddressSelect
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
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.zipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.local = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.city = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.district = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.region = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDistrict = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCity = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbnAddressSelect1 = new Legal.DataSet.dsAbnAddressSelect();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnAddressSelect1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelect
            // 
            this.dgvSelect.AllowUserToAddRows = false;
            this.dgvSelect.AllowUserToDeleteRows = false;
            this.dgvSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelect.AutoGenerateColumns = false;
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zipCode,
            this.street,
            this.local,
            this.city,
            this.district,
            this.region,
            this.idRegion,
            this.idDistrict,
            this.idCity,
            this.idLocal,
            this.idStreet});
            this.dgvSelect.DataSource = this.bs;
            this.dgvSelect.Location = new System.Drawing.Point(10, 12);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.ReadOnly = true;
            this.dgvSelect.RowHeadersWidth = 20;
            this.dgvSelect.RowTemplate.Height = 24;
            this.dgvSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelect.Size = new System.Drawing.Size(970, 636);
            this.dgvSelect.TabIndex = 0;
            this.dgvSelect.DoubleClick += new System.EventHandler(this.dgvSelect_DoubleClick);
            // 
            // zipCode
            // 
            this.zipCode.DataPropertyName = "ZipCode";
            this.zipCode.FillWeight = 150F;
            this.zipCode.HeaderText = "Индекс";
            this.zipCode.Name = "zipCode";
            this.zipCode.ReadOnly = true;
            this.zipCode.Width = 80;
            // 
            // street
            // 
            this.street.DataPropertyName = "Street";
            this.street.HeaderText = "Улица";
            this.street.Name = "street";
            this.street.ReadOnly = true;
            this.street.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.street.Width = 300;
            // 
            // local
            // 
            this.local.DataPropertyName = "Local";
            this.local.HeaderText = "Нас.пункт";
            this.local.Name = "local";
            this.local.ReadOnly = true;
            this.local.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.local.Width = 150;
            // 
            // city
            // 
            this.city.DataPropertyName = "City";
            this.city.HeaderText = "Город";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.city.Width = 120;
            // 
            // district
            // 
            this.district.DataPropertyName = "District";
            this.district.HeaderText = "Район";
            this.district.Name = "district";
            this.district.ReadOnly = true;
            this.district.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // region
            // 
            this.region.DataPropertyName = "Region";
            this.region.HeaderText = "Регион";
            this.region.Name = "region";
            this.region.ReadOnly = true;
            this.region.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.region.Width = 150;
            // 
            // idRegion
            // 
            this.idRegion.DataPropertyName = "idRegion";
            this.idRegion.HeaderText = "idRegion";
            this.idRegion.Name = "idRegion";
            this.idRegion.ReadOnly = true;
            this.idRegion.Visible = false;
            // 
            // idDistrict
            // 
            this.idDistrict.DataPropertyName = "idDistrict";
            this.idDistrict.HeaderText = "idDistrict";
            this.idDistrict.Name = "idDistrict";
            this.idDistrict.ReadOnly = true;
            this.idDistrict.Visible = false;
            // 
            // idCity
            // 
            this.idCity.DataPropertyName = "idCity";
            this.idCity.HeaderText = "idCity";
            this.idCity.Name = "idCity";
            this.idCity.ReadOnly = true;
            this.idCity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCity.Visible = false;
            // 
            // idLocal
            // 
            this.idLocal.DataPropertyName = "idLocal";
            this.idLocal.HeaderText = "idLocal";
            this.idLocal.Name = "idLocal";
            this.idLocal.ReadOnly = true;
            this.idLocal.Visible = false;
            // 
            // idStreet
            // 
            this.idStreet.DataPropertyName = "idStreet";
            this.idStreet.HeaderText = "idStreet";
            this.idStreet.Name = "idStreet";
            this.idStreet.ReadOnly = true;
            // 
            // bs
            // 
            this.bs.DataMember = "tG_AbnAddressSelect";
            this.bs.DataSource = this.dsAbnAddressSelect1;
            // 
            // dsAbnAddressSelect1
            // 
            this.dsAbnAddressSelect1.DataSetName = "dsAbnAddressSelect";
            this.dsAbnAddressSelect1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormAbnAddressSelect
            // 
            this.ClientSize = new System.Drawing.Size(992, 660);
            this.Controls.Add(this.dgvSelect);
            this.Name = "FormAbnAddressSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор улицы";
            this.Load += new System.EventHandler(this.FormAbnAddressSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnAddressSelect1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelect;
        private Legal.DataSet.dsAbnAddressSelect dsAbnAddressSelect1;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCode;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn street;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn local;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn city;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn district;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDistrict;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn idCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStreet;
    }
}
