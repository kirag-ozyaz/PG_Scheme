namespace Prv.Forms.Reports
{
    partial class FormActAddEdit
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
            this.dataSetRep1 = new Prv.DataSets.DataSetRep();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.dtActDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeControllerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kladrObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kladrObjIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housePrefixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countFloorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countPorchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countApartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherTypeObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idJournalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetRep1
            // 
            this.dataSetRep1.DataSetName = "DataSetRep";
            this.dataSetRep1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressDataGridViewTextBoxColumn,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.contFIODataGridViewTextBoxColumn,
            this.codeControllerDataGridViewTextBoxColumn,
            this.kladrObjDataGridViewTextBoxColumn,
            this.kladrObjIDDataGridViewTextBoxColumn,
            this.raionDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.codeStreetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.housePrefixDataGridViewTextBoxColumn,
            this.apartmentDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn,
            this.idMarkDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.countFloorDataGridViewTextBoxColumn,
            this.countPorchDataGridViewTextBoxColumn,
            this.countApartmentDataGridViewTextBoxColumn,
            this.typeObjDataGridViewTextBoxColumn,
            this.otherTypeObjDataGridViewTextBoxColumn,
            this.idReasonDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.idJournalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.Size = new System.Drawing.Size(747, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(109, 23);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // dtActDate
            // 
            this.dtActDate.Location = new System.Drawing.Point(314, 23);
            this.dtActDate.Name = "dtActDate";
            this.dtActDate.Size = new System.Drawing.Size(150, 20);
            this.dtActDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер акта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата акта:";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tPrv_RepAct";
            this.bindingSource1.DataSource = this.dataSetRep1;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 230;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Лицевой счет";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.Width = 150;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // contFIODataGridViewTextBoxColumn
            // 
            this.contFIODataGridViewTextBoxColumn.DataPropertyName = "ContFIO";
            this.contFIODataGridViewTextBoxColumn.HeaderText = "ContFIO";
            this.contFIODataGridViewTextBoxColumn.Name = "contFIODataGridViewTextBoxColumn";
            this.contFIODataGridViewTextBoxColumn.Visible = false;
            // 
            // codeControllerDataGridViewTextBoxColumn
            // 
            this.codeControllerDataGridViewTextBoxColumn.DataPropertyName = "CodeController";
            this.codeControllerDataGridViewTextBoxColumn.HeaderText = "CodeController";
            this.codeControllerDataGridViewTextBoxColumn.Name = "codeControllerDataGridViewTextBoxColumn";
            this.codeControllerDataGridViewTextBoxColumn.Visible = false;
            // 
            // kladrObjDataGridViewTextBoxColumn
            // 
            this.kladrObjDataGridViewTextBoxColumn.DataPropertyName = "KladrObj";
            this.kladrObjDataGridViewTextBoxColumn.HeaderText = "KladrObj";
            this.kladrObjDataGridViewTextBoxColumn.Name = "kladrObjDataGridViewTextBoxColumn";
            this.kladrObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // kladrObjIDDataGridViewTextBoxColumn
            // 
            this.kladrObjIDDataGridViewTextBoxColumn.DataPropertyName = "KladrObjID";
            this.kladrObjIDDataGridViewTextBoxColumn.HeaderText = "KladrObjID";
            this.kladrObjIDDataGridViewTextBoxColumn.Name = "kladrObjIDDataGridViewTextBoxColumn";
            this.kladrObjIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // raionDataGridViewTextBoxColumn
            // 
            this.raionDataGridViewTextBoxColumn.DataPropertyName = "Raion";
            this.raionDataGridViewTextBoxColumn.HeaderText = "Raion";
            this.raionDataGridViewTextBoxColumn.Name = "raionDataGridViewTextBoxColumn";
            this.raionDataGridViewTextBoxColumn.Visible = false;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeStreetDataGridViewTextBoxColumn
            // 
            this.codeStreetDataGridViewTextBoxColumn.DataPropertyName = "CodeStreet";
            this.codeStreetDataGridViewTextBoxColumn.HeaderText = "CodeStreet";
            this.codeStreetDataGridViewTextBoxColumn.Name = "codeStreetDataGridViewTextBoxColumn";
            this.codeStreetDataGridViewTextBoxColumn.Visible = false;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.HeaderText = "House";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.Visible = false;
            // 
            // housePrefixDataGridViewTextBoxColumn
            // 
            this.housePrefixDataGridViewTextBoxColumn.DataPropertyName = "HousePrefix";
            this.housePrefixDataGridViewTextBoxColumn.HeaderText = "HousePrefix";
            this.housePrefixDataGridViewTextBoxColumn.Name = "housePrefixDataGridViewTextBoxColumn";
            this.housePrefixDataGridViewTextBoxColumn.Visible = false;
            // 
            // apartmentDataGridViewTextBoxColumn
            // 
            this.apartmentDataGridViewTextBoxColumn.DataPropertyName = "Apartment";
            this.apartmentDataGridViewTextBoxColumn.HeaderText = "Apartment";
            this.apartmentDataGridViewTextBoxColumn.Name = "apartmentDataGridViewTextBoxColumn";
            this.apartmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "Марка счетчика";
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            this.markDataGridViewTextBoxColumn.Width = 150;
            // 
            // idMarkDataGridViewTextBoxColumn
            // 
            this.idMarkDataGridViewTextBoxColumn.DataPropertyName = "idMark";
            this.idMarkDataGridViewTextBoxColumn.HeaderText = "idMark";
            this.idMarkDataGridViewTextBoxColumn.Name = "idMarkDataGridViewTextBoxColumn";
            this.idMarkDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // countFloorDataGridViewTextBoxColumn
            // 
            this.countFloorDataGridViewTextBoxColumn.DataPropertyName = "CountFloor";
            this.countFloorDataGridViewTextBoxColumn.HeaderText = "CountFloor";
            this.countFloorDataGridViewTextBoxColumn.Name = "countFloorDataGridViewTextBoxColumn";
            this.countFloorDataGridViewTextBoxColumn.Visible = false;
            // 
            // countPorchDataGridViewTextBoxColumn
            // 
            this.countPorchDataGridViewTextBoxColumn.DataPropertyName = "CountPorch";
            this.countPorchDataGridViewTextBoxColumn.HeaderText = "CountPorch";
            this.countPorchDataGridViewTextBoxColumn.Name = "countPorchDataGridViewTextBoxColumn";
            this.countPorchDataGridViewTextBoxColumn.Visible = false;
            // 
            // countApartmentDataGridViewTextBoxColumn
            // 
            this.countApartmentDataGridViewTextBoxColumn.DataPropertyName = "CountApartment";
            this.countApartmentDataGridViewTextBoxColumn.HeaderText = "CountApartment";
            this.countApartmentDataGridViewTextBoxColumn.Name = "countApartmentDataGridViewTextBoxColumn";
            this.countApartmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeObjDataGridViewTextBoxColumn
            // 
            this.typeObjDataGridViewTextBoxColumn.DataPropertyName = "TypeObj";
            this.typeObjDataGridViewTextBoxColumn.HeaderText = "TypeObj";
            this.typeObjDataGridViewTextBoxColumn.Name = "typeObjDataGridViewTextBoxColumn";
            this.typeObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // otherTypeObjDataGridViewTextBoxColumn
            // 
            this.otherTypeObjDataGridViewTextBoxColumn.DataPropertyName = "OtherTypeObj";
            this.otherTypeObjDataGridViewTextBoxColumn.HeaderText = "OtherTypeObj";
            this.otherTypeObjDataGridViewTextBoxColumn.Name = "otherTypeObjDataGridViewTextBoxColumn";
            this.otherTypeObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // idReasonDataGridViewTextBoxColumn
            // 
            this.idReasonDataGridViewTextBoxColumn.DataPropertyName = "idReason";
            this.idReasonDataGridViewTextBoxColumn.HeaderText = "idReason";
            this.idReasonDataGridViewTextBoxColumn.Name = "idReasonDataGridViewTextBoxColumn";
            this.idReasonDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idJournalDataGridViewTextBoxColumn
            // 
            this.idJournalDataGridViewTextBoxColumn.DataPropertyName = "idJournal";
            this.idJournalDataGridViewTextBoxColumn.HeaderText = "idJournal";
            this.idJournalDataGridViewTextBoxColumn.Name = "idJournalDataGridViewTextBoxColumn";
            this.idJournalDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormActAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtActDate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormActAddEdit";
            this.Text = "Акт снятия показаний";
            this.Load += new System.EventHandler(this.FormActAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.DataSetRep dataSetRep1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.DateTimePicker dtActDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeControllerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kladrObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kladrObjIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housePrefixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countFloorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countPorchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countApartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherTypeObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJournalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}