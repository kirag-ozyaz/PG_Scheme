namespace Legal.Forms.Meter
{
    partial class FormAddTariff
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
            this.dtpDatePrice = new System.Windows.Forms.DateTimePicker();
            this.cbTariff = new System.Windows.Forms.ComboBox();
            this.bsTariffNew = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbn = new Legal.DataSet.DataSetAbn();
            this.tbObjName = new System.Windows.Forms.TextBox();
            this.bsObjMeter = new System.Windows.Forms.BindingSource(this.components);
            this.objMeterdgv = new System.Windows.Forms.DataGridView();
            this.idAbnObjMeterDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointIDDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDateBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterIDDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBeginDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digitDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxObj = new System.Windows.Forms.GroupBox();
            this.groupBoxObjMeter = new System.Windows.Forms.GroupBox();
            this.labelDateTariff = new System.Windows.Forms.Label();
            this.gbTariff = new System.Windows.Forms.GroupBox();
            this.buttonОк = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.bsTariff = new System.Windows.Forms.BindingSource(this.components);
            this.TariffDGV = new System.Windows.Forms.DataGridView();
            this.gbTariffOld = new System.Windows.Forms.GroupBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTariffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetDateDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsTariffNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObjMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objMeterdgv)).BeginInit();
            this.groupBoxObj.SuspendLayout();
            this.groupBoxObjMeter.SuspendLayout();
            this.gbTariff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTariff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TariffDGV)).BeginInit();
            this.gbTariffOld.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDatePrice
            // 
            this.dtpDatePrice.Location = new System.Drawing.Point(272, 419);
            this.dtpDatePrice.Name = "dtpDatePrice";
            this.dtpDatePrice.Size = new System.Drawing.Size(200, 20);
            this.dtpDatePrice.TabIndex = 0;
            this.dtpDatePrice.ValueChanged += new System.EventHandler(this.dtpDatePrice_ValueChanged);
            // 
            // cbTariff
            // 
            this.cbTariff.DataSource = this.bsTariffNew;
            this.cbTariff.DisplayMember = "TariffName";
            this.cbTariff.FormattingEnabled = true;
            this.cbTariff.Location = new System.Drawing.Point(6, 26);
            this.cbTariff.Name = "cbTariff";
            this.cbTariff.Size = new System.Drawing.Size(536, 21);
            this.cbTariff.TabIndex = 1;
            this.cbTariff.ValueMember = "id";
            // 
            // bsTariffNew
            // 
            this.bsTariffNew.DataMember = "vG_Tariff";
            this.bsTariffNew.DataSource = this.dsAbn;
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetAbn";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbObjName
            // 
            this.tbObjName.Location = new System.Drawing.Point(6, 16);
            this.tbObjName.Name = "tbObjName";
            this.tbObjName.Size = new System.Drawing.Size(536, 20);
            this.tbObjName.TabIndex = 2;
            // 
            // bsObjMeter
            // 
            this.bsObjMeter.DataMember = "vG_ObjMeter";
            this.bsObjMeter.DataSource = this.dsAbn;
            // 
            // objMeterdgv
            // 
            this.objMeterdgv.AllowUserToAddRows = false;
            this.objMeterdgv.AllowUserToDeleteRows = false;
            this.objMeterdgv.AutoGenerateColumns = false;
            this.objMeterdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objMeterdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAbnObjMeterDGVTBC,
            this.pointIDDGVTBC,
            this.PDateBegin,
            this.PDateEnd,
            this.meterIDDGVTBC,
            this.dateBeginDGVTBC,
            this.numberDataGridViewTextBoxColumn,
            this.idZoneDataGridViewTextBoxColumn1,
            this.meterTypeDataGridViewTextBoxColumn,
            this.digitDGVTBC,
            this.zoneDataGridViewTextBoxColumn});
            this.objMeterdgv.DataSource = this.bsObjMeter;
            this.objMeterdgv.Location = new System.Drawing.Point(26, 19);
            this.objMeterdgv.MultiSelect = false;
            this.objMeterdgv.Name = "objMeterdgv";
            this.objMeterdgv.ReadOnly = true;
            this.objMeterdgv.RowHeadersWidth = 4;
            this.objMeterdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.objMeterdgv.Size = new System.Drawing.Size(430, 160);
            this.objMeterdgv.TabIndex = 3;
            this.objMeterdgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.objMeterdgv_CellMouseClick);
            this.objMeterdgv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.objMeterdgv_KeyUp);
            // 
            // idAbnObjMeterDGVTBC
            // 
            this.idAbnObjMeterDGVTBC.DataPropertyName = "idAbnObj";
            this.idAbnObjMeterDGVTBC.HeaderText = "idAbnObj";
            this.idAbnObjMeterDGVTBC.Name = "idAbnObjMeterDGVTBC";
            this.idAbnObjMeterDGVTBC.ReadOnly = true;
            this.idAbnObjMeterDGVTBC.Visible = false;
            // 
            // pointIDDGVTBC
            // 
            this.pointIDDGVTBC.DataPropertyName = "PointID";
            this.pointIDDGVTBC.HeaderText = "PointID";
            this.pointIDDGVTBC.Name = "pointIDDGVTBC";
            this.pointIDDGVTBC.ReadOnly = true;
            this.pointIDDGVTBC.Visible = false;
            // 
            // PDateBegin
            // 
            this.PDateBegin.DataPropertyName = "PDateBegin";
            this.PDateBegin.HeaderText = "PDateBegin";
            this.PDateBegin.Name = "PDateBegin";
            this.PDateBegin.ReadOnly = true;
            this.PDateBegin.Visible = false;
            // 
            // PDateEnd
            // 
            this.PDateEnd.DataPropertyName = "PDateEnd";
            this.PDateEnd.HeaderText = "PDateEnd";
            this.PDateEnd.Name = "PDateEnd";
            this.PDateEnd.ReadOnly = true;
            this.PDateEnd.Visible = false;
            // 
            // meterIDDGVTBC
            // 
            this.meterIDDGVTBC.DataPropertyName = "MeterID";
            this.meterIDDGVTBC.HeaderText = "MeterID";
            this.meterIDDGVTBC.Name = "meterIDDGVTBC";
            this.meterIDDGVTBC.ReadOnly = true;
            this.meterIDDGVTBC.Visible = false;
            // 
            // dateBeginDGVTBC
            // 
            this.dateBeginDGVTBC.DataPropertyName = "DateBegin";
            this.dateBeginDGVTBC.HeaderText = "DateBegin";
            this.dateBeginDGVTBC.Name = "dateBeginDGVTBC";
            this.dateBeginDGVTBC.ReadOnly = true;
            this.dateBeginDGVTBC.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idZoneDataGridViewTextBoxColumn1
            // 
            this.idZoneDataGridViewTextBoxColumn1.DataPropertyName = "idZone";
            this.idZoneDataGridViewTextBoxColumn1.HeaderText = "idZone";
            this.idZoneDataGridViewTextBoxColumn1.Name = "idZoneDataGridViewTextBoxColumn1";
            this.idZoneDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idZoneDataGridViewTextBoxColumn1.Visible = false;
            this.idZoneDataGridViewTextBoxColumn1.Width = 60;
            // 
            // meterTypeDataGridViewTextBoxColumn
            // 
            this.meterTypeDataGridViewTextBoxColumn.DataPropertyName = "MeterType";
            this.meterTypeDataGridViewTextBoxColumn.HeaderText = "Тип счетчика";
            this.meterTypeDataGridViewTextBoxColumn.Name = "meterTypeDataGridViewTextBoxColumn";
            this.meterTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.meterTypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // digitDGVTBC
            // 
            this.digitDGVTBC.DataPropertyName = "Digit";
            this.digitDGVTBC.HeaderText = "Digit";
            this.digitDGVTBC.Name = "digitDGVTBC";
            this.digitDGVTBC.ReadOnly = true;
            this.digitDGVTBC.Visible = false;
            // 
            // zoneDataGridViewTextBoxColumn
            // 
            this.zoneDataGridViewTextBoxColumn.DataPropertyName = "Zone";
            this.zoneDataGridViewTextBoxColumn.HeaderText = "Зона";
            this.zoneDataGridViewTextBoxColumn.Name = "zoneDataGridViewTextBoxColumn";
            this.zoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBoxObj
            // 
            this.groupBoxObj.Controls.Add(this.tbObjName);
            this.groupBoxObj.Location = new System.Drawing.Point(12, 6);
            this.groupBoxObj.Name = "groupBoxObj";
            this.groupBoxObj.Size = new System.Drawing.Size(548, 42);
            this.groupBoxObj.TabIndex = 4;
            this.groupBoxObj.TabStop = false;
            this.groupBoxObj.Text = "Объект";
            // 
            // groupBoxObjMeter
            // 
            this.groupBoxObjMeter.Controls.Add(this.objMeterdgv);
            this.groupBoxObjMeter.Location = new System.Drawing.Point(50, 54);
            this.groupBoxObjMeter.Name = "groupBoxObjMeter";
            this.groupBoxObjMeter.Size = new System.Drawing.Size(482, 185);
            this.groupBoxObjMeter.TabIndex = 5;
            this.groupBoxObjMeter.TabStop = false;
            this.groupBoxObjMeter.Text = "Приборы учета";
            // 
            // labelDateTariff
            // 
            this.labelDateTariff.AutoSize = true;
            this.labelDateTariff.Location = new System.Drawing.Point(90, 421);
            this.labelDateTariff.Name = "labelDateTariff";
            this.labelDateTariff.Size = new System.Drawing.Size(167, 13);
            this.labelDateTariff.TabIndex = 6;
            this.labelDateTariff.Text = "Дата начала действия тарифа :";
            // 
            // gbTariff
            // 
            this.gbTariff.Controls.Add(this.cbTariff);
            this.gbTariff.Location = new System.Drawing.Point(12, 445);
            this.gbTariff.Name = "gbTariff";
            this.gbTariff.Size = new System.Drawing.Size(548, 67);
            this.gbTariff.TabIndex = 7;
            this.gbTariff.TabStop = false;
            this.gbTariff.Text = "Выбор тарифа";
            // 
            // buttonОк
            // 
            this.buttonОк.Location = new System.Drawing.Point(397, 518);
            this.buttonОк.Name = "buttonОк";
            this.buttonОк.Size = new System.Drawing.Size(75, 23);
            this.buttonОк.TabIndex = 8;
            this.buttonОк.Text = "Сохранить";
            this.buttonОк.UseVisualStyleBackColor = true;
            this.buttonОк.Click += new System.EventHandler(this.buttonОк_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(485, 518);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // bsTariff
            // 
            this.bsTariff.DataMember = "vG_TariffPoint";
            this.bsTariff.DataSource = this.dsAbn;
            // 
            // TariffDGV
            // 
            this.TariffDGV.AllowUserToAddRows = false;
            this.TariffDGV.AllowUserToDeleteRows = false;
            this.TariffDGV.AutoGenerateColumns = false;
            this.TariffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TariffDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idTariffDataGridViewTextBoxColumn,
            this.idPointDataGridViewTextBoxColumn,
            this.SetDateDGVTBC,
            this.tariffNameDataGridViewTextBoxColumn,
            this.Price});
            this.TariffDGV.DataSource = this.bsTariff;
            this.TariffDGV.Location = new System.Drawing.Point(6, 18);
            this.TariffDGV.Name = "TariffDGV";
            this.TariffDGV.ReadOnly = true;
            this.TariffDGV.RowHeadersWidth = 5;
            this.TariffDGV.Size = new System.Drawing.Size(536, 140);
            this.TariffDGV.TabIndex = 10;
            // 
            // gbTariffOld
            // 
            this.gbTariffOld.Controls.Add(this.TariffDGV);
            this.gbTariffOld.Location = new System.Drawing.Point(12, 245);
            this.gbTariffOld.Name = "gbTariffOld";
            this.gbTariffOld.Size = new System.Drawing.Size(550, 163);
            this.gbTariffOld.TabIndex = 11;
            this.gbTariffOld.TabStop = false;
            this.gbTariffOld.Text = "Тарифы";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTariffDataGridViewTextBoxColumn
            // 
            this.idTariffDataGridViewTextBoxColumn.DataPropertyName = "idTariff";
            this.idTariffDataGridViewTextBoxColumn.HeaderText = "idTariff";
            this.idTariffDataGridViewTextBoxColumn.Name = "idTariffDataGridViewTextBoxColumn";
            this.idTariffDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTariffDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPointDataGridViewTextBoxColumn
            // 
            this.idPointDataGridViewTextBoxColumn.DataPropertyName = "idPoint";
            this.idPointDataGridViewTextBoxColumn.HeaderText = "idPoint";
            this.idPointDataGridViewTextBoxColumn.Name = "idPointDataGridViewTextBoxColumn";
            this.idPointDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPointDataGridViewTextBoxColumn.Visible = false;
            // 
            // SetDateDGVTBC
            // 
            this.SetDateDGVTBC.DataPropertyName = "SetDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.SetDateDGVTBC.DefaultCellStyle = dataGridViewCellStyle1;
            this.SetDateDGVTBC.HeaderText = "Дата";
            this.SetDateDGVTBC.Name = "SetDateDGVTBC";
            this.SetDateDGVTBC.ReadOnly = true;
            this.SetDateDGVTBC.Width = 65;
            // 
            // tariffNameDataGridViewTextBoxColumn
            // 
            this.tariffNameDataGridViewTextBoxColumn.DataPropertyName = "TariffName";
            this.tariffNameDataGridViewTextBoxColumn.HeaderText = "Наименование тарифа";
            this.tariffNameDataGridViewTextBoxColumn.Name = "tariffNameDataGridViewTextBoxColumn";
            this.tariffNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tariffNameDataGridViewTextBoxColumn.Width = 370;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 75;
            // 
            // FormAddTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 548);
            this.Controls.Add(this.gbTariffOld);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonОк);
            this.Controls.Add(this.gbTariff);
            this.Controls.Add(this.labelDateTariff);
            this.Controls.Add(this.groupBoxObjMeter);
            this.Controls.Add(this.groupBoxObj);
            this.Controls.Add(this.dtpDatePrice);
            this.Name = "FormAddTariff";
            this.Text = "Тариф";
            this.Load += new System.EventHandler(this.FormAddTariff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTariffNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObjMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objMeterdgv)).EndInit();
            this.groupBoxObj.ResumeLayout(false);
            this.groupBoxObj.PerformLayout();
            this.groupBoxObjMeter.ResumeLayout(false);
            this.gbTariff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsTariff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TariffDGV)).EndInit();
            this.gbTariffOld.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatePrice;
        private System.Windows.Forms.ComboBox cbTariff;
        private DataSet.DataSetAbn dsAbn;
        private System.Windows.Forms.BindingSource bsTariffNew;
        private System.Windows.Forms.TextBox tbObjName;
        private System.Windows.Forms.BindingSource bsObjMeter;
        private System.Windows.Forms.DataGridView objMeterdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnObjMeterDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointIDDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDateBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterIDDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBeginDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digitDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxObj;
        private System.Windows.Forms.GroupBox groupBoxObjMeter;
        private System.Windows.Forms.Label labelDateTariff;
        private System.Windows.Forms.GroupBox gbTariff;
        private System.Windows.Forms.Button buttonОк;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.BindingSource bsTariff;
        private System.Windows.Forms.DataGridView TariffDGV;
        private System.Windows.Forms.GroupBox gbTariffOld;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTariffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetDateDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}