using ControlsLbr.DataGridViewExcelFilter;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormSelectCable 
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
        this.dgvCable = new DataGridViewExcelFilter();
        this.bindingSourceCable = new BindingSource(this.components);
        this.dsCalcN = new CalcLossN.DataSet.DataSetCalc();
        this.fullNameDgvColumn = new DataGridViewFilterTextBoxColumn();
        this.idDgvColumn = new DataGridViewTextBoxColumn();
        this.crossSectionDgvColumn = new DataGridViewTextBoxColumn();
        this.resistanceDgvColumn = new DataGridViewTextBoxColumn();
        this.voltageValueDgvColumn = new DataGridViewTextBoxColumn();
        this.toolStrip.SuspendLayout();
        ((ISupportInitialize)this.dgvCable).BeginInit();
        ((ISupportInitialize)this.bindingSourceCable).BeginInit();
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
        this.dgvCable.AllowUserToAddRows = false;
        this.dgvCable.AllowUserToDeleteRows = false;
        this.dgvCable.AllowUserToResizeRows = false;
        this.dgvCable.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        this.dgvCable.AutoGenerateColumns = false;
        this.dgvCable.BackgroundColor = SystemColors.Control;
        this.dgvCable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvCable.Columns.AddRange(new DataGridViewColumn[]
        {
            this.fullNameDgvColumn,
            this.idDgvColumn,
            this.crossSectionDgvColumn,
            this.resistanceDgvColumn,
            this.voltageValueDgvColumn
        });
        this.dgvCable.DataSource = this.bindingSourceCable;
        this.dgvCable.Location = new Point(0, 28);
        this.dgvCable.Name = "dgvCable";
        this.dgvCable.ReadOnly = true;
        this.dgvCable.RowHeadersVisible = false;
        this.dgvCable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dgvCable.Size = new Size(507, 240);
        this.dgvCable.TabIndex = 1;
        this.dgvCable.CellDoubleClick +=new DataGridViewCellEventHandler( this.dgvCable_CellDoubleClick);
        this.bindingSourceCable.DataMember = "vR_Cable";
        this.bindingSourceCable.DataSource = this.dsCalcN;
        this.dsCalcN.DataSetName = "dsCalc";
        this.dsCalcN.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.fullNameDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.fullNameDgvColumn.DataPropertyName = "FullName";
        this.fullNameDgvColumn.HeaderText = "Марка провода";
        this.fullNameDgvColumn.Name = "fullNameDgvColumn";
        this.fullNameDgvColumn.ReadOnly = true;
        this.fullNameDgvColumn.Resizable = DataGridViewTriState.True;
        this.idDgvColumn.DataPropertyName = "id";
        this.idDgvColumn.HeaderText = "id";
        this.idDgvColumn.Name = "idDgvColumn";
        this.idDgvColumn.ReadOnly = true;
        this.idDgvColumn.Visible = false;
        this.crossSectionDgvColumn.DataPropertyName = "CrossSection";
        this.crossSectionDgvColumn.HeaderText = "CrossSection";
        this.crossSectionDgvColumn.Name = "crossSectionDgvColumn";
        this.crossSectionDgvColumn.ReadOnly = true;
        this.crossSectionDgvColumn.Visible = false;
        this.resistanceDgvColumn.DataPropertyName = "Resistance";
        this.resistanceDgvColumn.HeaderText = "Resistance";
        this.resistanceDgvColumn.Name = "resistanceDgvColumn";
        this.resistanceDgvColumn.ReadOnly = true;
        this.resistanceDgvColumn.Visible = false;
        this.voltageValueDgvColumn.DataPropertyName = "VoltageValue";
        this.voltageValueDgvColumn.HeaderText = "VoltageValue";
        this.voltageValueDgvColumn.Name = "voltageValueDgvColumn";
        this.voltageValueDgvColumn.ReadOnly = true;
        this.voltageValueDgvColumn.Visible = false;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new Size(507, 309);
        base.Controls.Add(this.dgvCable);
        base.Controls.Add(this.buttonCancel);
        base.Controls.Add(this.buttonOK);
        base.Controls.Add(this.toolStrip);
        base.Name = "FormSelectCable";
        this.Text = "Выбор марки провода";
        base.Load +=new System.EventHandler( this.FormSelectCable_Load);
        this.toolStrip.ResumeLayout(false);
        this.toolStrip.PerformLayout();
        ((ISupportInitialize)this.dgvCable).EndInit();
        ((ISupportInitialize)this.bindingSourceCable).EndInit();
        ((ISupportInitialize)this.dsCalcN).EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }



    private ToolStrip toolStrip;

    private Button buttonOK;

    private Button buttonCancel;

    private DataGridViewExcelFilter dgvCable;

    private CalcLossN.DataSet.DataSetCalc dsCalcN;

    private BindingSource bindingSourceCable;

    private ToolStripLabel toolStripLabel1;

    private ToolStripTextBox txtFilter;

    private DataGridViewFilterTextBoxColumn fullNameDgvColumn;

    private DataGridViewTextBoxColumn idDgvColumn;

    private DataGridViewTextBoxColumn crossSectionDgvColumn;

    private DataGridViewTextBoxColumn resistanceDgvColumn;

    private DataGridViewTextBoxColumn voltageValueDgvColumn;
}
