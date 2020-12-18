namespace Prv.Forms.Exchange
{
    partial class FormMatritca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatritca));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBoxСheck = new System.Windows.Forms.GroupBox();
            this.buttonCheckNoValue = new System.Windows.Forms.Button();
            this.buttonInsToGES = new System.Windows.Forms.Button();
            this.groupBoxFillData = new System.Windows.Forms.GroupBox();
            this.buttonFillData = new System.Windows.Forms.Button();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.labelDateBegin = new System.Windows.Forms.Label();
            this.dTimeBeg = new System.Windows.Forms.DateTimePicker();
            this.dTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dgveData = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idPointRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitAddressDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.TP = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.sNDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsData = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetExchange = new Prv.DataSets.DataSetExchange();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExportExcel = new System.Windows.Forms.ToolStripButton();
            this.checkBoxDateIns = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDateIns = new System.Windows.Forms.DateTimePicker();
            this.checkBoxOnlyOne = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.groupBoxСheck.SuspendLayout();
            this.groupBoxFillData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgveData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetExchange)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dateTimePickerDateIns);
            this.panel1.Controls.Add(this.checkBoxDateIns);
            this.panel1.Controls.Add(this.toolStripMain);
            this.panel1.Controls.Add(this.groupBoxСheck);
            this.panel1.Controls.Add(this.buttonInsToGES);
            this.panel1.Controls.Add(this.groupBoxFillData);
            this.panel1.Location = new System.Drawing.Point(778, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 588);
            this.panel1.TabIndex = 0;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPrint,
            this.toolStripSeparator4,
            this.toolStripButtonExportExcel});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(210, 25);
            this.toolStripMain.TabIndex = 3;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBoxСheck
            // 
            this.groupBoxСheck.Controls.Add(this.buttonCheckNoValue);
            this.groupBoxСheck.Location = new System.Drawing.Point(9, 234);
            this.groupBoxСheck.Name = "groupBoxСheck";
            this.groupBoxСheck.Size = new System.Drawing.Size(200, 272);
            this.groupBoxСheck.TabIndex = 2;
            this.groupBoxСheck.TabStop = false;
            this.groupBoxСheck.Text = "Проверки";
            // 
            // buttonCheckNoValue
            // 
            this.buttonCheckNoValue.Location = new System.Drawing.Point(7, 20);
            this.buttonCheckNoValue.Name = "buttonCheckNoValue";
            this.buttonCheckNoValue.Size = new System.Drawing.Size(184, 40);
            this.buttonCheckNoValue.TabIndex = 0;
            this.buttonCheckNoValue.Text = "Нет показаний за период";
            this.buttonCheckNoValue.UseVisualStyleBackColor = true;
            this.buttonCheckNoValue.Click += new System.EventHandler(this.buttonCheckNoValue_Click);
            // 
            // buttonInsToGES
            // 
            this.buttonInsToGES.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsToGES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsToGES.Location = new System.Drawing.Point(16, 535);
            this.buttonInsToGES.Name = "buttonInsToGES";
            this.buttonInsToGES.Size = new System.Drawing.Size(183, 35);
            this.buttonInsToGES.TabIndex = 1;
            this.buttonInsToGES.Text = "Внести в базу";
            this.buttonInsToGES.UseVisualStyleBackColor = true;
            this.buttonInsToGES.Click += new System.EventHandler(this.buttonInsToGES_Click);
            // 
            // groupBoxFillData
            // 
            this.groupBoxFillData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFillData.Controls.Add(this.checkBoxOnlyOne);
            this.groupBoxFillData.Controls.Add(this.buttonFillData);
            this.groupBoxFillData.Controls.Add(this.labelDateEnd);
            this.groupBoxFillData.Controls.Add(this.labelDateBegin);
            this.groupBoxFillData.Controls.Add(this.dTimeBeg);
            this.groupBoxFillData.Controls.Add(this.dTimeEnd);
            this.groupBoxFillData.Location = new System.Drawing.Point(8, 39);
            this.groupBoxFillData.Name = "groupBoxFillData";
            this.groupBoxFillData.Size = new System.Drawing.Size(202, 189);
            this.groupBoxFillData.TabIndex = 0;
            this.groupBoxFillData.TabStop = false;
            this.groupBoxFillData.Text = "Выбрать данные";
            // 
            // buttonFillData
            // 
            this.buttonFillData.Location = new System.Drawing.Point(8, 135);
            this.buttonFillData.Name = "buttonFillData";
            this.buttonFillData.Size = new System.Drawing.Size(184, 39);
            this.buttonFillData.TabIndex = 37;
            this.buttonFillData.Text = "Заполнить";
            this.buttonFillData.UseVisualStyleBackColor = true;
            this.buttonFillData.Click += new System.EventHandler(this.buttonFillData_Click);
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(24, 57);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(92, 13);
            this.labelDateEnd.TabIndex = 36;
            this.labelDateEnd.Text = "Дата окончания:";
            // 
            // labelDateBegin
            // 
            this.labelDateBegin.AutoSize = true;
            this.labelDateBegin.Location = new System.Drawing.Point(24, 16);
            this.labelDateBegin.Name = "labelDateBegin";
            this.labelDateBegin.Size = new System.Drawing.Size(74, 13);
            this.labelDateBegin.TabIndex = 35;
            this.labelDateBegin.Text = "Дата начала:";
            // 
            // dTimeBeg
            // 
            this.dTimeBeg.Location = new System.Drawing.Point(22, 33);
            this.dTimeBeg.Name = "dTimeBeg";
            this.dTimeBeg.Size = new System.Drawing.Size(156, 20);
            this.dTimeBeg.TabIndex = 33;
            // 
            // dTimeEnd
            // 
            this.dTimeEnd.Location = new System.Drawing.Point(22, 73);
            this.dTimeEnd.Name = "dTimeEnd";
            this.dTimeEnd.Size = new System.Drawing.Size(156, 20);
            this.dTimeEnd.TabIndex = 34;
            // 
            // dgveData
            // 
            this.dgveData.AllowUserToAddRows = false;
            this.dgveData.AllowUserToDeleteRows = false;
            this.dgveData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgveData.AutoGenerateColumns = false;
            this.dgveData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgveData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeAbonentDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.idPointRegDataGridViewTextBoxColumn,
            this.idPointDataGridViewTextBoxColumn,
            this.unitAddressDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.TP,
            this.sNDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.nValueDataGridViewTextBoxColumn,
            this.dValueDataGridViewTextBoxColumn});
            this.dgveData.DataSource = this.bsData;
            this.dgveData.Location = new System.Drawing.Point(1, 4);
            this.dgveData.Name = "dgveData";
            this.dgveData.ReadOnly = true;
            this.dgveData.RowHeadersWidth = 21;
            this.dgveData.Size = new System.Drawing.Size(778, 588);
            this.dgveData.TabIndex = 1;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Лицевой счет";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес Энергосхема";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idPointRegDataGridViewTextBoxColumn
            // 
            this.idPointRegDataGridViewTextBoxColumn.DataPropertyName = "idPointReg";
            this.idPointRegDataGridViewTextBoxColumn.HeaderText = "idPointReg";
            this.idPointRegDataGridViewTextBoxColumn.Name = "idPointRegDataGridViewTextBoxColumn";
            this.idPointRegDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPointRegDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPointDataGridViewTextBoxColumn
            // 
            this.idPointDataGridViewTextBoxColumn.DataPropertyName = "idPoint";
            this.idPointDataGridViewTextBoxColumn.HeaderText = "idPoint";
            this.idPointDataGridViewTextBoxColumn.Name = "idPointDataGridViewTextBoxColumn";
            this.idPointDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPointDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitAddressDataGridViewTextBoxColumn
            // 
            this.unitAddressDataGridViewTextBoxColumn.DataPropertyName = "UnitAddress";
            this.unitAddressDataGridViewTextBoxColumn.HeaderText = "Адрес Матрица";
            this.unitAddressDataGridViewTextBoxColumn.Name = "unitAddressDataGridViewTextBoxColumn";
            this.unitAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitAddressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TP
            // 
            this.TP.DataPropertyName = "TP";
            this.TP.HeaderText = "ТП";
            this.TP.Name = "TP";
            this.TP.ReadOnly = true;
            // 
            // sNDataGridViewTextBoxColumn
            // 
            this.sNDataGridViewTextBoxColumn.DataPropertyName = "SN";
            this.sNDataGridViewTextBoxColumn.HeaderText = "Серийный номер";
            this.sNDataGridViewTextBoxColumn.Name = "sNDataGridViewTextBoxColumn";
            this.sNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nValueDataGridViewTextBoxColumn
            // 
            this.nValueDataGridViewTextBoxColumn.DataPropertyName = "NValue";
            this.nValueDataGridViewTextBoxColumn.HeaderText = "Ночь";
            this.nValueDataGridViewTextBoxColumn.Name = "nValueDataGridViewTextBoxColumn";
            this.nValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dValueDataGridViewTextBoxColumn
            // 
            this.dValueDataGridViewTextBoxColumn.DataPropertyName = "DValue";
            this.dValueDataGridViewTextBoxColumn.HeaderText = "День";
            this.dValueDataGridViewTextBoxColumn.Name = "dValueDataGridViewTextBoxColumn";
            this.dValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsData
            // 
            this.bsData.DataMember = "fn_PrvFromMatritca";
            this.bsData.DataSource = this.dataSetExchange;
            // 
            // dataSetExchange
            // 
            this.dataSetExchange.DataSetName = "DataSetExchange";
            this.dataSetExchange.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrint.Image = global::Prv.Properties.Resources.Print;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrint.Text = "Печать";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // toolStripButtonExportExcel
            // 
            this.toolStripButtonExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExportExcel.Image = global::Prv.Properties.Resources.Excel;
            this.toolStripButtonExportExcel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonExportExcel.Name = "toolStripButtonExportExcel";
            this.toolStripButtonExportExcel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExportExcel.Text = "Экспорт в Excel";
            this.toolStripButtonExportExcel.Click += new System.EventHandler(this.toolStripButtonExportExcel_Click);
            // 
            // checkBoxDateIns
            // 
            this.checkBoxDateIns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDateIns.AutoSize = true;
            this.checkBoxDateIns.Checked = true;
            this.checkBoxDateIns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDateIns.Location = new System.Drawing.Point(14, 515);
            this.checkBoxDateIns.Name = "checkBoxDateIns";
            this.checkBoxDateIns.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDateIns.TabIndex = 4;
            this.checkBoxDateIns.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDateIns
            // 
            this.dateTimePickerDateIns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateIns.Location = new System.Drawing.Point(35, 512);
            this.dateTimePickerDateIns.Name = "dateTimePickerDateIns";
            this.dateTimePickerDateIns.Size = new System.Drawing.Size(152, 20);
            this.dateTimePickerDateIns.TabIndex = 5;
            // 
            // checkBoxOnlyOne
            // 
            this.checkBoxOnlyOne.AutoSize = true;
            this.checkBoxOnlyOne.Checked = true;
            this.checkBoxOnlyOne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOnlyOne.Location = new System.Drawing.Point(22, 112);
            this.checkBoxOnlyOne.Name = "checkBoxOnlyOne";
            this.checkBoxOnlyOne.Size = new System.Drawing.Size(137, 17);
            this.checkBoxOnlyOne.TabIndex = 38;
            this.checkBoxOnlyOne.Text = "последнее показание";
            this.checkBoxOnlyOne.UseVisualStyleBackColor = true;
            // 
            // FormMatritca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 594);
            this.Controls.Add(this.dgveData);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMatritca";
            this.Text = "Импорт данных счетчиков Матрица";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.groupBoxСheck.ResumeLayout(false);
            this.groupBoxFillData.ResumeLayout(false);
            this.groupBoxFillData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgveData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetExchange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSets.DataSetExchange dataSetExchange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxFillData;
        private System.Windows.Forms.Button buttonFillData;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.Label labelDateBegin;
        private System.Windows.Forms.DateTimePicker dTimeBeg;
        private System.Windows.Forms.DateTimePicker dTimeEnd;
        private System.Windows.Forms.BindingSource bsData;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgveData;
        private System.Windows.Forms.Button buttonInsToGES;
        private System.Windows.Forms.GroupBox groupBoxСheck;
        private System.Windows.Forms.Button buttonCheckNoValue;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn fIODataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn unitAddressDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn TP;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn sNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateIns;
        private System.Windows.Forms.CheckBox checkBoxDateIns;
        private System.Windows.Forms.CheckBox checkBoxOnlyOne;
    }
}