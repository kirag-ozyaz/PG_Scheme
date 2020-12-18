namespace Legal.Forms.Object
{
    partial class FormObjDog_Linking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormObjDog_Linking));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPlus = new System.Windows.Forms.ToolStripButton();
            this.btnMinus = new System.Windows.Forms.ToolStripButton();
            this.btnOk = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectCell = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsObj1 = new Legal.DataSet.dsObj();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPlus,
            this.btnMinus,
            this.btnOk,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(574, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPlus
            // 
            this.btnPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPlus.Image = global::Legal.Properties.Resources._1304663065_Add;
            this.btnPlus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(23, 22);
            this.btnPlus.Text = "toolStripButton1";
            this.btnPlus.ToolTipText = "Выбрать все";
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMinus.Image = global::Legal.Properties.Resources.Delete;
            this.btnMinus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(23, 22);
            this.btnMinus.Text = "toolStripButton2";
            this.btnMinus.ToolTipText = "Отменить все";
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnOk
            // 
            this.btnOk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(68, 22);
            this.btnOk.Text = "Привязать";
            this.btnOk.ToolTipText = "Привязать выбранные объекты к договору";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.id,
            this.SelectCell,
            this.title});
            this.dgvSelect.DataSource = this.bindingSource1;
            this.dgvSelect.Location = new System.Drawing.Point(0, 25);
            this.dgvSelect.MultiSelect = false;
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.RowHeadersWidth = 10;
            this.dgvSelect.Size = new System.Drawing.Size(574, 386);
            this.dgvSelect.TabIndex = 1;
            this.dgvSelect.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvSelect_CurrentCellDirtyStateChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "idObj";
            this.id.HeaderText = "idObj";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // SelectCell
            // 
            this.SelectCell.HeaderText = "Выбор";
            this.SelectCell.Name = "SelectCell";
            this.SelectCell.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectCell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SelectCell.Width = 50;
            // 
            // title
            // 
            this.title.DataPropertyName = "Title";
            this.title.HeaderText = "Объект";
            this.title.Name = "title";
            this.title.Width = 500;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "dtObj";
            this.bindingSource1.DataSource = this.dsObj1;
            // 
            // dsObj1
            // 
            this.dsObj1.DataSetName = "dsObj";
            this.dsObj1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormObjDog_Linking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 411);
            this.Controls.Add(this.dgvSelect);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormObjDog_Linking";
            this.Text = "Привязка объектов к договору";
            this.Load += new System.EventHandler(this.FormObjDog_Linking_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.ToolStripButton btnPlus;
        private System.Windows.Forms.ToolStripButton btnMinus;
        private System.Windows.Forms.ToolStripButton btnOk;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DataSet.dsObj dsObj1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
    }
}