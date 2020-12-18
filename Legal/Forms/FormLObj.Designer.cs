namespace Legal.Forms
{
    partial class FormLObj
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
            System.Windows.Forms.BindingSource ObjBindingSource;
            this.dataGridViewObj = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxObj = new System.Windows.Forms.TextBox();
            ObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(ObjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObj)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjBindingSource
            // 
            ObjBindingSource.DataMember = "vG_AbnObj";
            // 
            // dataGridViewObj
            // 
            this.dataGridViewObj.AllowUserToAddRows = false;
            this.dataGridViewObj.AllowUserToDeleteRows = false;
            this.dataGridViewObj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObj.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewObj.Name = "dataGridViewObj";
            this.dataGridViewObj.ReadOnly = true;
            this.dataGridViewObj.RowHeadersWidth = 23;
            this.dataGridViewObj.RowTemplate.Height = 24;
            this.dataGridViewObj.Size = new System.Drawing.Size(968, 534);
            this.dataGridViewObj.TabIndex = 0;
            this.dataGridViewObj.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewObj_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Итого:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 618);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "объекты";
            // 
            // tBoxObj
            // 
            this.tBoxObj.Location = new System.Drawing.Point(217, 615);
            this.tBoxObj.Name = "tBoxObj";
            this.tBoxObj.Size = new System.Drawing.Size(57, 20);
            this.tBoxObj.TabIndex = 3;
            // 
            // FormLObj
            // 
            this.ClientSize = new System.Drawing.Size(992, 668);
            this.Controls.Add(this.tBoxObj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewObj);
            this.Name = "FormLObj";
            this.Text = "Объекты";
            this.Load += new System.EventHandler(this.FormLObj_Load);
            ((System.ComponentModel.ISupportInitialize)(ObjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewObj;
       // private Legal.DataSet.DataSetLObj dataSetLObj1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxObj;
        //private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn objNameDataGridViewTextBoxColumn;
        //private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn abnNameDataGridViewTextBoxColumn;
        //private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn masterDataGridViewTextBoxColumn;
    }
}
