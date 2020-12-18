namespace Legal.Forms.Calculat
{
    partial class FormNumberFact
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberFactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberCorrectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCalc1 = new Legal.DataSet.dsCalc();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnInfo = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.periodYear,
            this.periodMonth,
            this.numberMinDataGridViewTextBoxColumn,
            this.numberMaxDataGridViewTextBoxColumn,
            this.numberFactDataGridViewTextBoxColumn,
            this.Number_Count,
            this.numberCorrectDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bindingSource1;
            this.dgv.Location = new System.Drawing.Point(0, 28);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 10;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(671, 288);
            this.dgv.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // periodYear
            // 
            this.periodYear.DataPropertyName = "Period_Year";
            this.periodYear.HeaderText = "Год";
            this.periodYear.Name = "periodYear";
            this.periodYear.ReadOnly = true;
            this.periodYear.Width = 50;
            // 
            // periodMonth
            // 
            this.periodMonth.DataPropertyName = "Period_Month";
            this.periodMonth.HeaderText = "Месяц";
            this.periodMonth.Name = "periodMonth";
            this.periodMonth.ReadOnly = true;
            this.periodMonth.Width = 50;
            // 
            // numberMinDataGridViewTextBoxColumn
            // 
            this.numberMinDataGridViewTextBoxColumn.DataPropertyName = "Number_Min";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.numberMinDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.numberMinDataGridViewTextBoxColumn.HeaderText = "Начало диапазона";
            this.numberMinDataGridViewTextBoxColumn.Name = "numberMinDataGridViewTextBoxColumn";
            this.numberMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberMinDataGridViewTextBoxColumn.Width = 130;
            // 
            // numberMaxDataGridViewTextBoxColumn
            // 
            this.numberMaxDataGridViewTextBoxColumn.DataPropertyName = "Number_Max";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.numberMaxDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.numberMaxDataGridViewTextBoxColumn.HeaderText = "Конец диапазона";
            this.numberMaxDataGridViewTextBoxColumn.Name = "numberMaxDataGridViewTextBoxColumn";
            this.numberMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberMaxDataGridViewTextBoxColumn.Width = 130;
            // 
            // numberFactDataGridViewTextBoxColumn
            // 
            this.numberFactDataGridViewTextBoxColumn.DataPropertyName = "NumberFact";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.numberFactDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.numberFactDataGridViewTextBoxColumn.HeaderText = "Текущий номер";
            this.numberFactDataGridViewTextBoxColumn.Name = "numberFactDataGridViewTextBoxColumn";
            this.numberFactDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberFactDataGridViewTextBoxColumn.Width = 130;
            // 
            // Number_Count
            // 
            this.Number_Count.DataPropertyName = "Number_Count";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Number_Count.DefaultCellStyle = dataGridViewCellStyle12;
            this.Number_Count.HeaderText = "Всего использовано";
            this.Number_Count.Name = "Number_Count";
            this.Number_Count.ReadOnly = true;
            this.Number_Count.Width = 150;
            // 
            // numberCorrectDataGridViewTextBoxColumn
            // 
            this.numberCorrectDataGridViewTextBoxColumn.DataPropertyName = "NumberCorrect";
            this.numberCorrectDataGridViewTextBoxColumn.HeaderText = "Текущий_исправлен";
            this.numberCorrectDataGridViewTextBoxColumn.Name = "numberCorrectDataGridViewTextBoxColumn";
            this.numberCorrectDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberCorrectDataGridViewTextBoxColumn.Visible = false;
            this.numberCorrectDataGridViewTextBoxColumn.Width = 120;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tG_NumberFact";
            this.bindingSource1.DataSource = this.dsCalc1;
            // 
            // dsCalc1
            // 
            this.dsCalc1.DataSetName = "dsCalc";
            this.dsCalc1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(671, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::Legal.Properties.Resources._1304663065_Add;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "Добавить новый диапазон";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInfo.Image = global::Legal.Properties.Resources._1304672652_Information;
            this.btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(23, 22);
            this.btnInfo.Text = "Рассчитать количество использованных счетов-фактур";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // FormNumberFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 315);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv);
            this.MaximizeBox = false;
            this.Name = "FormNumberFact";
            this.Text = "Диапазон выделенных номеров счетов-фактур";
            this.Load += new System.EventHandler(this.FormNumberFact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private DataSet.dsCalc dsCalc1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberFactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberCorrectDataGridViewTextBoxColumn;
    }
}