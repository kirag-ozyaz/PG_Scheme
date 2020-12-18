namespace Legal.Forms.Object
{
    partial class FormMeasurementsOfObject
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.dgvMeasurObj = new System.Windows.Forms.DataGridView();
            this.idDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObjDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfIntroductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMeasurementsOfObject = new System.Windows.Forms.BindingSource(this.components);
            this.dsObj1 = new Legal.DataSet.dsObj();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurementsOfObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(547, 25);
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
            this.btnAdd.Text = "Добавить замеры";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::Legal.Properties.Resources.ElementEdit;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Text = "Редактировать замеры";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = global::Legal.Properties.Resources.ElementDel;
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(23, 22);
            this.btnDel.Text = "Удалить замеры";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvMeasurObj
            // 
            this.dgvMeasurObj.AllowUserToAddRows = false;
            this.dgvMeasurObj.AllowUserToDeleteRows = false;
            this.dgvMeasurObj.AutoGenerateColumns = false;
            this.dgvMeasurObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasurObj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDGV,
            this.idObjDGV,
            this.dateOfIntroductionDataGridViewTextBoxColumn,
            this.averageValueDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dgvMeasurObj.DataSource = this.bsMeasurementsOfObject;
            this.dgvMeasurObj.Location = new System.Drawing.Point(0, 28);
            this.dgvMeasurObj.Name = "dgvMeasurObj";
            this.dgvMeasurObj.ReadOnly = true;
            this.dgvMeasurObj.RowHeadersWidth = 10;
            this.dgvMeasurObj.Size = new System.Drawing.Size(547, 278);
            this.dgvMeasurObj.TabIndex = 1;
            // 
            // idDGV
            // 
            this.idDGV.DataPropertyName = "id";
            this.idDGV.HeaderText = "id";
            this.idDGV.Name = "idDGV";
            this.idDGV.ReadOnly = true;
            this.idDGV.Visible = false;
            // 
            // idObjDGV
            // 
            this.idObjDGV.DataPropertyName = "idObj";
            this.idObjDGV.HeaderText = "idObj";
            this.idObjDGV.Name = "idObjDGV";
            this.idObjDGV.ReadOnly = true;
            this.idObjDGV.Visible = false;
            // 
            // dateOfIntroductionDataGridViewTextBoxColumn
            // 
            this.dateOfIntroductionDataGridViewTextBoxColumn.DataPropertyName = "DateOfIntroduction";
            this.dateOfIntroductionDataGridViewTextBoxColumn.HeaderText = "Дата замера";
            this.dateOfIntroductionDataGridViewTextBoxColumn.Name = "dateOfIntroductionDataGridViewTextBoxColumn";
            this.dateOfIntroductionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfIntroductionDataGridViewTextBoxColumn.Width = 150;
            // 
            // averageValueDataGridViewTextBoxColumn
            // 
            this.averageValueDataGridViewTextBoxColumn.DataPropertyName = "AverageValue";
            this.averageValueDataGridViewTextBoxColumn.HeaderText = "Среднее значение";
            this.averageValueDataGridViewTextBoxColumn.Name = "averageValueDataGridViewTextBoxColumn";
            this.averageValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.averageValueDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 250;
            // 
            // bsMeasurementsOfObject
            // 
            this.bsMeasurementsOfObject.DataMember = "vG_MeasurementsOfObject";
            this.bsMeasurementsOfObject.DataSource = this.dsObj1;
            // 
            // dsObj1
            // 
            this.dsObj1.DataSetName = "dsObj";
            this.dsObj1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(460, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormMeasurementsOfObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(547, 340);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvMeasurObj);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMeasurementsOfObject";
            this.Text = "Список замеров режимного дня";
            this.Load += new System.EventHandler(this.FormMeasurementsOfObject_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurementsOfObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.DataGridView dgvMeasurObj;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bsMeasurementsOfObject;
        private DataSet.dsObj dsObj1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfIntroductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}