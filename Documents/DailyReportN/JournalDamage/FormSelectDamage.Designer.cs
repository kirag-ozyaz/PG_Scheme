using ControlsLbr.DataGridViewExcelFilter;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

partial class FormSelectDamage
{
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

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnApplyFilter = new System.Windows.Forms.ToolStripButton();
            this.btnResetFilter = new System.Windows.Forms.ToolStripButton();
            this.dgv = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bsDamage = new System.Windows.Forms.BindingSource(this.components);
            this.dsDamageN = new DailyReportN.DataSet.dsDamage();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn4 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.numDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.TypeDocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schmObjName = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDamageN)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.btnApplyFilter,
            this.btnResetFilter});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(738, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel1.Text = "Дата от";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel2.Text = "до";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnApplyFilter.Image = global::DailyReportN.Properties.Resources.filter;
            this.btnApplyFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(23, 22);
            this.btnApplyFilter.Text = "Применить фильтр";
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnResetFilter.Image = global::DailyReportN.Properties.Resources.filter_delete;
            this.btnResetFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(23, 22);
            this.btnResetFilter.Text = "Сбросить фильтр";
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
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
            this.dataGridViewTextBoxColumn4,
            this.numDoc,
            this.dataGridViewTextBoxColumn3,
            this.TypeDocName,
            this.schmObjName});
            this.dgv.DataSource = this.bsDamage;
            this.dgv.Location = new System.Drawing.Point(0, 28);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 21;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(738, 270);
            this.dgv.TabIndex = 1;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // bsDamage
            // 
            this.bsDamage.DataMember = "vJ_Damage";
            this.bsDamage.DataSource = this.dsDamageN;
            // 
            // dsDamageN
            // 
            this.dsDamageN.DataSetName = "DataSetDamage";
            this.dsDamageN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 304);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(651, 304);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "numrequest";
            this.dataGridViewTextBoxColumn4.FilteringEnabled = false;
            this.dataGridViewTextBoxColumn4.HeaderText = "№ заявки";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // numDoc
            // 
            this.numDoc.DataPropertyName = "numDoc";
            this.numDoc.HeaderText = "№ документа";
            this.numDoc.Name = "numDoc";
            this.numDoc.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dateDoc";
            this.dataGridViewTextBoxColumn3.FilteringEnabled = false;
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата документа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TypeDocName
            // 
            this.TypeDocName.DataPropertyName = "TypeDocSocrName";
            this.TypeDocName.HeaderText = "Тип документа";
            this.TypeDocName.Name = "TypeDocName";
            this.TypeDocName.ReadOnly = true;
            // 
            // schmObjName
            // 
            this.schmObjName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.schmObjName.DataPropertyName = "schmObjName";
            this.schmObjName.FilteringEnabled = false;
            this.schmObjName.HeaderText = "Электроустановка";
            this.schmObjName.Name = "schmObjName";
            this.schmObjName.ReadOnly = true;
            this.schmObjName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormSelectDamage
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(738, 339);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip);
            this.Name = "FormSelectDamage";
            this.Text = "Выбор дефекта (N)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSelectDamage_FormClosing);
            this.Load += new System.EventHandler(this.FormSelectDamage_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDamageN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    private DateTimePicker dateBeg;

    private DateTimePicker dateEnd;

    private ToolStrip toolStrip;

    private DataGridViewExcelFilter dgv;

    private Button buttonOK;

    private Button buttonCancel;

    private ToolStripLabel toolStripLabel1;

    private ToolStripLabel toolStripLabel2;

    private ToolStripSeparator toolStripSeparator1;

    private ToolStripButton btnApplyFilter;

    private ToolStripButton btnResetFilter;

    private BindingSource bsDamage;

    private DailyReportN.DataSet.dsDamage dsDamageN;
    private DataGridViewFilterTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn numDoc;
    private DataGridViewFilterTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn TypeDocName;
    private DataGridViewFilterTextBoxColumn schmObjName;
}
