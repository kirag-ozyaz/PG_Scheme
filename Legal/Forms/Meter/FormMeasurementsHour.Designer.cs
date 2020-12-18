namespace Legal.Forms.Meter
{
    partial class FormMeasurementsHour
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
            this.dsAbnObjAct1 = new Legal.DataSet.dsAbnObjAct();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.dgvHour = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementsDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h3DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h4DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h5DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h6DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h7DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h8DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h9DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h10DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h11DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h12DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h13DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h14DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h15DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h16DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h17DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h18DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h19DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h20DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h21DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h22DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h23DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h24DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hourCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnObjAct1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsAbnObjAct1
            // 
            this.dsAbnObjAct1.DataSetName = "dsAbnObjAct";
            this.dsAbnObjAct1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(844, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::Legal.Properties.Resources.ElementAdd;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::Legal.Properties.Resources.ElementEdit;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Text = "редактировать";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = global::Legal.Properties.Resources.ElementDel;
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(23, 22);
            this.btnDel.Text = "удалить";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvHour
            // 
            this.dgvHour.AllowUserToAddRows = false;
            this.dgvHour.AllowUserToDeleteRows = false;
            this.dgvHour.AutoGenerateColumns = false;
            this.dgvHour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDGV,
            this.yearValueDataGridViewTextBoxColumn,
            this.monthValueDataGridViewTextBoxColumn,
            this.MeasurementsDay,
            this.h1DataGridViewCheckBoxColumn,
            this.h2DataGridViewCheckBoxColumn,
            this.h3DataGridViewCheckBoxColumn,
            this.h4DataGridViewCheckBoxColumn,
            this.h5DataGridViewCheckBoxColumn,
            this.h6DataGridViewCheckBoxColumn,
            this.h7DataGridViewCheckBoxColumn,
            this.h8DataGridViewCheckBoxColumn,
            this.h9DataGridViewCheckBoxColumn,
            this.h10DataGridViewCheckBoxColumn,
            this.h11DataGridViewCheckBoxColumn,
            this.h12DataGridViewCheckBoxColumn,
            this.h13DataGridViewCheckBoxColumn,
            this.h14DataGridViewCheckBoxColumn,
            this.h15DataGridViewCheckBoxColumn,
            this.h16DataGridViewCheckBoxColumn,
            this.h17DataGridViewCheckBoxColumn,
            this.h18DataGridViewCheckBoxColumn,
            this.h19DataGridViewCheckBoxColumn,
            this.h20DataGridViewCheckBoxColumn,
            this.h21DataGridViewCheckBoxColumn,
            this.h22DataGridViewCheckBoxColumn,
            this.h23DataGridViewCheckBoxColumn,
            this.h24DataGridViewCheckBoxColumn,
            this.hourCountDataGridViewTextBoxColumn});
            this.dgvHour.DataSource = this.bindingSource1;
            this.dgvHour.Location = new System.Drawing.Point(0, 28);
            this.dgvHour.Name = "dgvHour";
            this.dgvHour.ReadOnly = true;
            this.dgvHour.RowHeadersWidth = 10;
            this.dgvHour.Size = new System.Drawing.Size(844, 321);
            this.dgvHour.TabIndex = 1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tG_MeasurementsHour";
            this.bindingSource1.DataSource = this.dsAbnObjAct1;
            // 
            // idDGV
            // 
            this.idDGV.DataPropertyName = "id";
            this.idDGV.HeaderText = "id";
            this.idDGV.Name = "idDGV";
            this.idDGV.ReadOnly = true;
            this.idDGV.Visible = false;
            // 
            // yearValueDataGridViewTextBoxColumn
            // 
            this.yearValueDataGridViewTextBoxColumn.DataPropertyName = "YearValue";
            this.yearValueDataGridViewTextBoxColumn.HeaderText = "Год";
            this.yearValueDataGridViewTextBoxColumn.Name = "yearValueDataGridViewTextBoxColumn";
            this.yearValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearValueDataGridViewTextBoxColumn.Width = 60;
            // 
            // monthValueDataGridViewTextBoxColumn
            // 
            this.monthValueDataGridViewTextBoxColumn.DataPropertyName = "MonthValue";
            this.monthValueDataGridViewTextBoxColumn.HeaderText = "Месяц";
            this.monthValueDataGridViewTextBoxColumn.Name = "monthValueDataGridViewTextBoxColumn";
            this.monthValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthValueDataGridViewTextBoxColumn.Width = 50;
            // 
            // MeasurementsDay
            // 
            this.MeasurementsDay.DataPropertyName = "MeasurementsDay";
            this.MeasurementsDay.HeaderText = "День";
            this.MeasurementsDay.Name = "MeasurementsDay";
            this.MeasurementsDay.ReadOnly = true;
            this.MeasurementsDay.Width = 50;
            // 
            // h1DataGridViewCheckBoxColumn
            // 
            this.h1DataGridViewCheckBoxColumn.DataPropertyName = "h1";
            this.h1DataGridViewCheckBoxColumn.HeaderText = "1";
            this.h1DataGridViewCheckBoxColumn.Name = "h1DataGridViewCheckBoxColumn";
            this.h1DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h1DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h2DataGridViewCheckBoxColumn
            // 
            this.h2DataGridViewCheckBoxColumn.DataPropertyName = "h2";
            this.h2DataGridViewCheckBoxColumn.HeaderText = "2";
            this.h2DataGridViewCheckBoxColumn.Name = "h2DataGridViewCheckBoxColumn";
            this.h2DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h2DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h3DataGridViewCheckBoxColumn
            // 
            this.h3DataGridViewCheckBoxColumn.DataPropertyName = "h3";
            this.h3DataGridViewCheckBoxColumn.HeaderText = "3";
            this.h3DataGridViewCheckBoxColumn.Name = "h3DataGridViewCheckBoxColumn";
            this.h3DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h3DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h4DataGridViewCheckBoxColumn
            // 
            this.h4DataGridViewCheckBoxColumn.DataPropertyName = "h4";
            this.h4DataGridViewCheckBoxColumn.HeaderText = "4";
            this.h4DataGridViewCheckBoxColumn.Name = "h4DataGridViewCheckBoxColumn";
            this.h4DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h4DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h5DataGridViewCheckBoxColumn
            // 
            this.h5DataGridViewCheckBoxColumn.DataPropertyName = "h5";
            this.h5DataGridViewCheckBoxColumn.HeaderText = "5";
            this.h5DataGridViewCheckBoxColumn.Name = "h5DataGridViewCheckBoxColumn";
            this.h5DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h5DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h6DataGridViewCheckBoxColumn
            // 
            this.h6DataGridViewCheckBoxColumn.DataPropertyName = "h6";
            this.h6DataGridViewCheckBoxColumn.HeaderText = "6";
            this.h6DataGridViewCheckBoxColumn.Name = "h6DataGridViewCheckBoxColumn";
            this.h6DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h6DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h7DataGridViewCheckBoxColumn
            // 
            this.h7DataGridViewCheckBoxColumn.DataPropertyName = "h7";
            this.h7DataGridViewCheckBoxColumn.HeaderText = "7";
            this.h7DataGridViewCheckBoxColumn.Name = "h7DataGridViewCheckBoxColumn";
            this.h7DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h7DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h8DataGridViewCheckBoxColumn
            // 
            this.h8DataGridViewCheckBoxColumn.DataPropertyName = "h8";
            this.h8DataGridViewCheckBoxColumn.HeaderText = "8";
            this.h8DataGridViewCheckBoxColumn.Name = "h8DataGridViewCheckBoxColumn";
            this.h8DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h8DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h9DataGridViewCheckBoxColumn
            // 
            this.h9DataGridViewCheckBoxColumn.DataPropertyName = "h9";
            this.h9DataGridViewCheckBoxColumn.HeaderText = "9";
            this.h9DataGridViewCheckBoxColumn.Name = "h9DataGridViewCheckBoxColumn";
            this.h9DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h9DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h10DataGridViewCheckBoxColumn
            // 
            this.h10DataGridViewCheckBoxColumn.DataPropertyName = "h10";
            this.h10DataGridViewCheckBoxColumn.HeaderText = "10";
            this.h10DataGridViewCheckBoxColumn.Name = "h10DataGridViewCheckBoxColumn";
            this.h10DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h10DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h11DataGridViewCheckBoxColumn
            // 
            this.h11DataGridViewCheckBoxColumn.DataPropertyName = "h11";
            this.h11DataGridViewCheckBoxColumn.HeaderText = "11";
            this.h11DataGridViewCheckBoxColumn.Name = "h11DataGridViewCheckBoxColumn";
            this.h11DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h11DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h12DataGridViewCheckBoxColumn
            // 
            this.h12DataGridViewCheckBoxColumn.DataPropertyName = "h12";
            this.h12DataGridViewCheckBoxColumn.HeaderText = "12";
            this.h12DataGridViewCheckBoxColumn.Name = "h12DataGridViewCheckBoxColumn";
            this.h12DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h12DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h13DataGridViewCheckBoxColumn
            // 
            this.h13DataGridViewCheckBoxColumn.DataPropertyName = "h13";
            this.h13DataGridViewCheckBoxColumn.HeaderText = "13";
            this.h13DataGridViewCheckBoxColumn.Name = "h13DataGridViewCheckBoxColumn";
            this.h13DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h13DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h14DataGridViewCheckBoxColumn
            // 
            this.h14DataGridViewCheckBoxColumn.DataPropertyName = "h14";
            this.h14DataGridViewCheckBoxColumn.HeaderText = "14";
            this.h14DataGridViewCheckBoxColumn.Name = "h14DataGridViewCheckBoxColumn";
            this.h14DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h14DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h15DataGridViewCheckBoxColumn
            // 
            this.h15DataGridViewCheckBoxColumn.DataPropertyName = "h15";
            this.h15DataGridViewCheckBoxColumn.HeaderText = "15";
            this.h15DataGridViewCheckBoxColumn.Name = "h15DataGridViewCheckBoxColumn";
            this.h15DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h15DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h16DataGridViewCheckBoxColumn
            // 
            this.h16DataGridViewCheckBoxColumn.DataPropertyName = "h16";
            this.h16DataGridViewCheckBoxColumn.HeaderText = "16";
            this.h16DataGridViewCheckBoxColumn.Name = "h16DataGridViewCheckBoxColumn";
            this.h16DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h16DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h17DataGridViewCheckBoxColumn
            // 
            this.h17DataGridViewCheckBoxColumn.DataPropertyName = "h17";
            this.h17DataGridViewCheckBoxColumn.HeaderText = "17";
            this.h17DataGridViewCheckBoxColumn.Name = "h17DataGridViewCheckBoxColumn";
            this.h17DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h17DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h18DataGridViewCheckBoxColumn
            // 
            this.h18DataGridViewCheckBoxColumn.DataPropertyName = "h18";
            this.h18DataGridViewCheckBoxColumn.HeaderText = "18";
            this.h18DataGridViewCheckBoxColumn.Name = "h18DataGridViewCheckBoxColumn";
            this.h18DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h18DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h19DataGridViewCheckBoxColumn
            // 
            this.h19DataGridViewCheckBoxColumn.DataPropertyName = "h19";
            this.h19DataGridViewCheckBoxColumn.HeaderText = "19";
            this.h19DataGridViewCheckBoxColumn.Name = "h19DataGridViewCheckBoxColumn";
            this.h19DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h19DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h20DataGridViewCheckBoxColumn
            // 
            this.h20DataGridViewCheckBoxColumn.DataPropertyName = "h20";
            this.h20DataGridViewCheckBoxColumn.HeaderText = "20";
            this.h20DataGridViewCheckBoxColumn.Name = "h20DataGridViewCheckBoxColumn";
            this.h20DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h20DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h21DataGridViewCheckBoxColumn
            // 
            this.h21DataGridViewCheckBoxColumn.DataPropertyName = "h21";
            this.h21DataGridViewCheckBoxColumn.HeaderText = "21";
            this.h21DataGridViewCheckBoxColumn.Name = "h21DataGridViewCheckBoxColumn";
            this.h21DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h21DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h22DataGridViewCheckBoxColumn
            // 
            this.h22DataGridViewCheckBoxColumn.DataPropertyName = "h22";
            this.h22DataGridViewCheckBoxColumn.HeaderText = "22";
            this.h22DataGridViewCheckBoxColumn.Name = "h22DataGridViewCheckBoxColumn";
            this.h22DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h22DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h23DataGridViewCheckBoxColumn
            // 
            this.h23DataGridViewCheckBoxColumn.DataPropertyName = "h23";
            this.h23DataGridViewCheckBoxColumn.HeaderText = "23";
            this.h23DataGridViewCheckBoxColumn.Name = "h23DataGridViewCheckBoxColumn";
            this.h23DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h23DataGridViewCheckBoxColumn.Width = 25;
            // 
            // h24DataGridViewCheckBoxColumn
            // 
            this.h24DataGridViewCheckBoxColumn.DataPropertyName = "h24";
            this.h24DataGridViewCheckBoxColumn.HeaderText = "24";
            this.h24DataGridViewCheckBoxColumn.Name = "h24DataGridViewCheckBoxColumn";
            this.h24DataGridViewCheckBoxColumn.ReadOnly = true;
            this.h24DataGridViewCheckBoxColumn.Width = 25;
            // 
            // hourCountDataGridViewTextBoxColumn
            // 
            this.hourCountDataGridViewTextBoxColumn.DataPropertyName = "HourCount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.hourCountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.hourCountDataGridViewTextBoxColumn.HeaderText = "Часы";
            this.hourCountDataGridViewTextBoxColumn.Name = "hourCountDataGridViewTextBoxColumn";
            this.hourCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.hourCountDataGridViewTextBoxColumn.Width = 70;
            // 
            // FormMeasurementsHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 347);
            this.Controls.Add(this.dgvHour);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMeasurementsHour";
            this.Text = "Плановые часы пиковой нагрузки";
            this.Load += new System.EventHandler(this.FormMeasurementsHour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnObjAct1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet.dsAbnObjAct dsAbnObjAct1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.DataGridView dgvHour;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementsDay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h3DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h4DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h5DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h6DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h7DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h8DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h9DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h10DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h11DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h12DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h13DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h14DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h15DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h16DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h17DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h18DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h19DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h20DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h21DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h22DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h23DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn h24DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourCountDataGridViewTextBoxColumn;
    }
}