using ControlsLbr.DataGridViewExcelFilter;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormSelectTrans
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

	private System.ComponentModel.IContainer components=null;

    private void InitializeComponent()
    {
        this.components = new Container();
        this.toolStrip = new ToolStrip();
        this.toolStripLabel1 = new ToolStripLabel();
        this.txtFilter = new ToolStripTextBox();
        this.buttonOK = new Button();
        this.buttonCancel = new Button();
        this.dgvTrans = new DataGridViewExcelFilter();
        this.bindingSourceTransformer = new BindingSource(this.components);
        this.dsCalcN = new CalcLossN.DataSet.DataSetCalc();
        this.idDgvColumn = new DataGridViewTextBoxColumn();
        this.fullNameDgvColumn = new DataGridViewFilterTextBoxColumn();
        this.powerDgvColumn = new DataGridViewTextBoxColumn();
        this.noLoadLossDgvColumn = new DataGridViewTextBoxColumn();
        this.shortCircuitLossDgvColumn = new DataGridViewTextBoxColumn();
        this.highVoltageDgvVoltage = new DataGridViewTextBoxColumn();
        this.toolStrip.SuspendLayout();
        ((ISupportInitialize)this.dgvTrans).BeginInit();
        ((ISupportInitialize)this.bindingSourceTransformer).BeginInit();
        ((ISupportInitialize)this.dsCalcN).BeginInit();
        base.SuspendLayout();
        this.toolStrip.Items.AddRange(new ToolStripItem[]
        {
            this.toolStripLabel1,
            this.txtFilter
        });
        this.toolStrip.Location = new Point(0, 0);
        this.toolStrip.Name = "toolStrip";
        this.toolStrip.Size = new Size(507, 25);
        this.toolStrip.TabIndex = 0;
        this.toolStrip.TabStop = true;
        this.toolStrip.Text = "toolStrip1";
        this.toolStripLabel1.Name = "toolStripLabel1";
        this.toolStripLabel1.Size = new Size(48, 22);
        this.toolStripLabel1.Text = "Фильтр";
        this.txtFilter.Name = "txtFilter";
        this.txtFilter.Size = new Size(300, 25);
        this.txtFilter.TextChanged +=new System.EventHandler( this.txtFilter_TextChanged);
        this.buttonOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
        this.buttonOK.Location = new Point(12, 274);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new Size(75, 23);
        this.buttonOK.TabIndex = 2;
        this.buttonOK.Text = "ОК";
        this.buttonOK.UseVisualStyleBackColor = true;
        this.buttonOK.Click +=new System.EventHandler( this.buttonOK_Click);

        this.buttonCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        this.buttonCancel.Location = new Point(420, 274);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new Size(75, 23);
        this.buttonCancel.TabIndex = 3;
        this.buttonCancel.Text = "Отмена";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.buttonCancel.Click +=new System.EventHandler( this.buttonCancel_Click);

        this.dgvTrans.AllowUserToAddRows = false;
        this.dgvTrans.AllowUserToDeleteRows = false;
        this.dgvTrans.AllowUserToResizeRows = false;
        this.dgvTrans.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        this.dgvTrans.AutoGenerateColumns = false;
        this.dgvTrans.BackgroundColor = SystemColors.Control;
        this.dgvTrans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvTrans.Columns.AddRange(new DataGridViewColumn[]
        {
            this.idDgvColumn,
            this.fullNameDgvColumn,
            this.powerDgvColumn,
            this.noLoadLossDgvColumn,
            this.shortCircuitLossDgvColumn,
            this.highVoltageDgvVoltage
        });
        this.dgvTrans.DataSource = this.bindingSourceTransformer;
        this.dgvTrans.Location = new Point(0, 28);
        this.dgvTrans.Name = "dgvTrans";
        this.dgvTrans.ReadOnly = true;
        this.dgvTrans.RowHeadersVisible = false;
        this.dgvTrans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dgvTrans.Size = new Size(507, 240);
        this.dgvTrans.TabIndex = 1;
        this.dgvTrans.CellDoubleClick +=new DataGridViewCellEventHandler( this.dgvTrans_CellDoubleClick);
        this.bindingSourceTransformer.DataMember = "vR_Transformer";
        this.bindingSourceTransformer.DataSource = this.dsCalcN;
        this.dsCalcN.DataSetName = "dsCalc";
        this.dsCalcN.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.idDgvColumn.DataPropertyName = "id";
        this.idDgvColumn.HeaderText = "id";
        this.idDgvColumn.Name = "idDgvColumn";
        this.idDgvColumn.ReadOnly = true;
        this.idDgvColumn.Visible = false;
        this.fullNameDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.fullNameDgvColumn.DataPropertyName = "FullName";
        this.fullNameDgvColumn.HeaderText = "Марка трансформатора";
        this.fullNameDgvColumn.Name = "fullNameDgvColumn";
        this.fullNameDgvColumn.ReadOnly = true;
        this.fullNameDgvColumn.Resizable = DataGridViewTriState.True;
        this.powerDgvColumn.DataPropertyName = "Power";
        this.powerDgvColumn.HeaderText = "Power";
        this.powerDgvColumn.Name = "powerDgvColumn";
        this.powerDgvColumn.ReadOnly = true;
        this.powerDgvColumn.Visible = false;
        this.noLoadLossDgvColumn.DataPropertyName = "NoLoadLoss";
        this.noLoadLossDgvColumn.HeaderText = "NoLoadLoss";
        this.noLoadLossDgvColumn.Name = "noLoadLossDgvColumn";
        this.noLoadLossDgvColumn.ReadOnly = true;
        this.noLoadLossDgvColumn.Visible = false;
        this.shortCircuitLossDgvColumn.DataPropertyName = "ShortCircuitLoss";
        this.shortCircuitLossDgvColumn.HeaderText = "ShortCircuitLoss";
        this.shortCircuitLossDgvColumn.Name = "shortCircuitLossDgvColumn";
        this.shortCircuitLossDgvColumn.ReadOnly = true;
        this.shortCircuitLossDgvColumn.Visible = false;
        this.highVoltageDgvVoltage.DataPropertyName = "HighVoltage";
        this.highVoltageDgvVoltage.HeaderText = "HighVoltage";
        this.highVoltageDgvVoltage.Name = "highVoltageDgvVoltage";
        this.highVoltageDgvVoltage.ReadOnly = true;
        this.highVoltageDgvVoltage.Visible = false;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new Size(507, 309);
        base.Controls.Add(this.dgvTrans);
        base.Controls.Add(this.buttonCancel);
        base.Controls.Add(this.buttonOK);
        base.Controls.Add(this.toolStrip);
        base.Name = "FormSelectTrans";
        this.Text = "Выбор марки трансформатора";
        base.Load +=new System.EventHandler( this.FormSelectTrans_Load);
        this.toolStrip.ResumeLayout(false);
        this.toolStrip.PerformLayout();
        ((ISupportInitialize)this.dgvTrans).EndInit();
        ((ISupportInitialize)this.bindingSourceTransformer).EndInit();
        ((ISupportInitialize)this.dsCalcN).EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }



    private ToolStrip toolStrip;

    private Button buttonOK;

    private Button buttonCancel;

    private DataGridViewExcelFilter dgvTrans;

    private CalcLossN.DataSet.DataSetCalc dsCalcN;

    private BindingSource bindingSourceTransformer;

    private ToolStripLabel toolStripLabel1;

    private ToolStripTextBox txtFilter;

    private DataGridViewTextBoxColumn idDgvColumn;

    private DataGridViewFilterTextBoxColumn fullNameDgvColumn;

    private DataGridViewTextBoxColumn powerDgvColumn;

    private DataGridViewTextBoxColumn noLoadLossDgvColumn;

    private DataGridViewTextBoxColumn shortCircuitLossDgvColumn;

    private DataGridViewTextBoxColumn highVoltageDgvVoltage;
}
