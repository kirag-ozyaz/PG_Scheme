namespace Legal.Forms.Calculat
{
    partial class FormOverPower
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvPowerTable = new System.Windows.Forms.DataGridView();
            this.tPowerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCntVal = new Legal.DataSet.dsCntVal();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.clbObj = new System.Windows.Forms.ListBox();
            this.tbSumma = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDoc = new System.Windows.Forms.Button();
            this.powerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwr3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwr4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwr5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwr6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwr7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwr8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwr9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwr10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwr11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwr12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPowerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPowerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPowerTable
            // 
            this.dgvPowerTable.AllowUserToAddRows = false;
            this.dgvPowerTable.AllowUserToDeleteRows = false;
            this.dgvPowerTable.AutoGenerateColumns = false;
            this.dgvPowerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPowerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.powerTypeDataGridViewTextBoxColumn,
            this.Pwr1,
            this.Pwr2,
            this.Pwr3,
            this.Pwr4,
            this.Pwr5,
            this.Pwr6,
            this.Pwr7,
            this.Pwr8,
            this.Pwr9,
            this.Pwr10,
            this.Pwr11,
            this.Pwr12,
            this.CountPower});
            this.dgvPowerTable.DataSource = this.tPowerBindingSource;
            this.dgvPowerTable.Location = new System.Drawing.Point(12, 12);
            this.dgvPowerTable.Name = "dgvPowerTable";
            this.dgvPowerTable.ReadOnly = true;
            this.dgvPowerTable.RowHeadersWidth = 10;
            this.dgvPowerTable.Size = new System.Drawing.Size(921, 123);
            this.dgvPowerTable.TabIndex = 1;
            // 
            // tPowerBindingSource
            // 
            this.tPowerBindingSource.DataMember = "tPower";
            this.tPowerBindingSource.DataSource = this.dsCntVal;
            // 
            // dsCntVal
            // 
            this.dsCntVal.DataSetName = "dsCntVal";
            this.dsCntVal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.tPowerBindingSource;
            legend1.Name = "Legend1";
            legend2.Name = "Legend2";
            this.chart1.Legends.Add(legend1);
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(323, 151);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(610, 279);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // clbObj
            // 
            this.clbObj.FormattingEnabled = true;
            this.clbObj.Location = new System.Drawing.Point(12, 151);
            this.clbObj.Name = "clbObj";
            this.clbObj.Size = new System.Drawing.Size(289, 420);
            this.clbObj.TabIndex = 3;
            this.clbObj.SelectedIndexChanged += new System.EventHandler(this.clbObj_SelectedIndexChanged_1);
            // 
            // tbSumma
            // 
            this.tbSumma.Location = new System.Drawing.Point(385, 465);
            this.tbSumma.Name = "tbSumma";
            this.tbSumma.Size = new System.Drawing.Size(100, 20);
            this.tbSumma.TabIndex = 4;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(614, 465);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbQuantity.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(755, 465);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(178, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Предварительный расчет";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сумма:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Количество:";
            // 
            // btnDoc
            // 
            this.btnDoc.Location = new System.Drawing.Point(544, 533);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(170, 23);
            this.btnDoc.TabIndex = 9;
            this.btnDoc.Text = "Сформировать начисление";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // powerTypeDataGridViewTextBoxColumn
            // 
            this.powerTypeDataGridViewTextBoxColumn.DataPropertyName = "PowerType";
            this.powerTypeDataGridViewTextBoxColumn.HeaderText = "Объем";
            this.powerTypeDataGridViewTextBoxColumn.Name = "powerTypeDataGridViewTextBoxColumn";
            this.powerTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.powerTypeDataGridViewTextBoxColumn.Width = 180;
            // 
            // Pwr1
            // 
            this.Pwr1.DataPropertyName = "Pwr1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Pwr1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Pwr1.HeaderText = "Январь";
            this.Pwr1.Name = "Pwr1";
            this.Pwr1.ReadOnly = true;
            this.Pwr1.Width = 60;
            // 
            // Pwr2
            // 
            this.Pwr2.DataPropertyName = "Pwr2";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Pwr2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Pwr2.HeaderText = "Февраль";
            this.Pwr2.Name = "Pwr2";
            this.Pwr2.ReadOnly = true;
            this.Pwr2.Width = 60;
            // 
            // Pwr3
            // 
            this.Pwr3.DataPropertyName = "Pwr3";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Pwr3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Pwr3.HeaderText = "Март";
            this.Pwr3.Name = "Pwr3";
            this.Pwr3.ReadOnly = true;
            this.Pwr3.Width = 60;
            // 
            // Pwr4
            // 
            this.Pwr4.DataPropertyName = "Pwr4";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Pwr4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Pwr4.HeaderText = "Апрель";
            this.Pwr4.Name = "Pwr4";
            this.Pwr4.ReadOnly = true;
            this.Pwr4.Width = 60;
            // 
            // Pwr5
            // 
            this.Pwr5.DataPropertyName = "Pwr5";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Pwr5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Pwr5.HeaderText = "Май";
            this.Pwr5.Name = "Pwr5";
            this.Pwr5.ReadOnly = true;
            this.Pwr5.Width = 60;
            // 
            // Pwr6
            // 
            this.Pwr6.DataPropertyName = "Pwr6";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Pwr6.DefaultCellStyle = dataGridViewCellStyle6;
            this.Pwr6.HeaderText = "Июнь";
            this.Pwr6.Name = "Pwr6";
            this.Pwr6.ReadOnly = true;
            this.Pwr6.Width = 60;
            // 
            // Pwr7
            // 
            this.Pwr7.DataPropertyName = "Pwr7";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.Pwr7.DefaultCellStyle = dataGridViewCellStyle7;
            this.Pwr7.HeaderText = "Июль";
            this.Pwr7.Name = "Pwr7";
            this.Pwr7.ReadOnly = true;
            this.Pwr7.Width = 60;
            // 
            // Pwr8
            // 
            this.Pwr8.DataPropertyName = "Pwr8";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.Pwr8.DefaultCellStyle = dataGridViewCellStyle8;
            this.Pwr8.HeaderText = "Август";
            this.Pwr8.Name = "Pwr8";
            this.Pwr8.ReadOnly = true;
            this.Pwr8.Width = 60;
            // 
            // Pwr9
            // 
            this.Pwr9.DataPropertyName = "Pwr9";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.Pwr9.DefaultCellStyle = dataGridViewCellStyle9;
            this.Pwr9.HeaderText = "Сентябрь";
            this.Pwr9.Name = "Pwr9";
            this.Pwr9.ReadOnly = true;
            this.Pwr9.Width = 60;
            // 
            // Pwr10
            // 
            this.Pwr10.DataPropertyName = "Pwr10";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.Pwr10.DefaultCellStyle = dataGridViewCellStyle10;
            this.Pwr10.HeaderText = "Октябрь";
            this.Pwr10.Name = "Pwr10";
            this.Pwr10.ReadOnly = true;
            this.Pwr10.Width = 60;
            // 
            // Pwr11
            // 
            this.Pwr11.DataPropertyName = "Pwr11";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.Pwr11.DefaultCellStyle = dataGridViewCellStyle11;
            this.Pwr11.HeaderText = "Ноябрь";
            this.Pwr11.Name = "Pwr11";
            this.Pwr11.ReadOnly = true;
            this.Pwr11.Width = 60;
            // 
            // Pwr12
            // 
            this.Pwr12.DataPropertyName = "Pwr12";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.Pwr12.DefaultCellStyle = dataGridViewCellStyle12;
            this.Pwr12.HeaderText = "Декабрь";
            this.Pwr12.Name = "Pwr12";
            this.Pwr12.ReadOnly = true;
            this.Pwr12.Width = 60;
            // 
            // CountPower
            // 
            this.CountPower.DataPropertyName = "CountPower";
            this.CountPower.HeaderText = "";
            this.CountPower.Name = "CountPower";
            this.CountPower.ReadOnly = true;
            // 
            // FormOverPower
            // 
            this.ClientSize = new System.Drawing.Size(945, 591);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbSumma);
            this.Controls.Add(this.clbObj);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvPowerTable);
            this.Name = "FormOverPower";
            this.Load += new System.EventHandler(this.FormOverPower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPowerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPowerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvPowerTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idObjDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn p1DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn p2DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn p3DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn p4DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn p5DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn p6DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn p7DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn p8DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn p9DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn p10DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn p11DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn p12DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tPowerBindingSource;
        private DataSet.dsCntVal dsCntVal;
        private System.Windows.Forms.ListBox clbObj;
        private System.Windows.Forms.TextBox tbSumma;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwr2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwr3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwr4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwr5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwr6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwr7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwr8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwr9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwr10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwr11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwr12;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountPower;

    }
}
