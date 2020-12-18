namespace Legal.Forms.Calculat
{
    partial class FormGroupDocSchet
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
            this.dgvSchet = new System.Windows.Forms.DataGridView();
            this.dsCntVal = new Legal.DataSet.dsCntVal();
            this.vGDocSchetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCalcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGDocSchetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSchet
            // 
            this.dgvSchet.AllowUserToAddRows = false;
            this.dgvSchet.AllowUserToDeleteRows = false;
            this.dgvSchet.AutoGenerateColumns = false;
            this.dgvSchet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.dtCalcDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.tariffDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn});
            this.dgvSchet.DataSource = this.vGDocSchetBindingSource;
            this.dgvSchet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchet.Location = new System.Drawing.Point(0, 0);
            this.dgvSchet.Name = "dgvSchet";
            this.dgvSchet.ReadOnly = true;
            this.dgvSchet.Size = new System.Drawing.Size(598, 321);
            this.dgvSchet.TabIndex = 0;
            // 
            // dsCntVal
            // 
            this.dsCntVal.DataSetName = "dsCntVal";
            this.dsCntVal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vGDocSchetBindingSource
            // 
            this.vGDocSchetBindingSource.DataMember = "vG_DocSchet";
            this.vGDocSchetBindingSource.DataSource = this.dsCntVal;
            // 
            // idDocDataGridViewTextBoxColumn
            // 
            this.idDocDataGridViewTextBoxColumn.DataPropertyName = "idDoc";
            this.idDocDataGridViewTextBoxColumn.HeaderText = "idDoc";
            this.idDocDataGridViewTextBoxColumn.Name = "idDocDataGridViewTextBoxColumn";
            this.idDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDocDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 200;
            // 
            // dtCalcDataGridViewTextBoxColumn
            // 
            this.dtCalcDataGridViewTextBoxColumn.DataPropertyName = "dtCalc";
            this.dtCalcDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dtCalcDataGridViewTextBoxColumn.Name = "dtCalcDataGridViewTextBoxColumn";
            this.dtCalcDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtCalcDataGridViewTextBoxColumn.Width = 80;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "кВт*ч";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 70;
            // 
            // tariffDataGridViewTextBoxColumn
            // 
            this.tariffDataGridViewTextBoxColumn.DataPropertyName = "Tariff";
            this.tariffDataGridViewTextBoxColumn.HeaderText = "Тариф";
            this.tariffDataGridViewTextBoxColumn.Name = "tariffDataGridViewTextBoxColumn";
            this.tariffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormGroupDocSchet
            // 
            this.ClientSize = new System.Drawing.Size(598, 321);
            this.Controls.Add(this.dgvSchet);
            this.Name = "FormGroupDocSchet";
            this.Text = "Счет";
            this.Load += new System.EventHandler(this.FormGroupDocSchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGDocSchetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSchet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCalcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vGDocSchetBindingSource;
        private DataSet.dsCntVal dsCntVal;
    }
}
