using ControlsLbr.DataGridViewExcelFilter;
using Documents.Forms.DailyReport.DataSets;
using FormLbr;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
/// <summary>
/// Выбор дефекта
/// c0002db
/// </summary>
internal class FormSelectDamage : FormBase
{
    private BindingSource bindingSource_0;
    private Button buttonOK;
    private Button buttonCancel;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgv;
    private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
    private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
    private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
    private DataSetDamage dataSetDamage_0;
    private DateTimePicker dateTimePicker_0;
    private DateTimePicker dateTimePicker_1;
    private IContainer components = null;
    private ToolStrip toolStrip;
    private ToolStripButton btnApplyFilter;
    private ToolStripButton btnResetFilter;
    private ToolStripLabel toolStripLabel_0;
    private ToolStripLabel toolStripLabel_1;
    private ToolStripSeparator toolStripSeparator_0;

    internal FormSelectDamage()
    {
        this.InitializeComponent();
        this.SetPeriodTimer();
        this.toolStrip.Items.Insert(1, new ToolStripControlHost(this.dateTimePicker_0));
        this.toolStrip.Items.Insert(3, new ToolStripControlHost(this.dateTimePicker_1));
    }

    private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0))
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void FormSelectDamage_FormClosing(object sender, FormClosingEventArgs e)
    {
        if ((base.DialogResult == DialogResult.OK) && (this.bindingSource_0.Current == null))
        {
            MessageBox.Show("Не выбран ни один документ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Cancel = true;
        }
    }

    private void FormSelectDamage_Load(object sender, EventArgs e)
    {
        this.GetTableDamge();
    }

    internal int? method_0()
    {
        if (this.bindingSource_0.Current != null)
        {
            return new int?(Convert.ToInt32(((DataRowView) this.bindingSource_0.Current).Row["id"]));
        }
        return null;
    }

    private void SetPeriodTimer()
    {
        this.dateTimePicker_0 = new DateTimePicker();
        this.dateTimePicker_0.Value = new DateTime(DateTime.Now.Year, 1, 1);
        this.dateTimePicker_1 = new DateTimePicker();
        this.dateTimePicker_1.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddMilliseconds(-1.0);
    }

    private void GetTableDamge()
    {
        base.SelectSqlData(this.dataSetDamage_0.vJ_Damage, true, string.Format(" where dateDoc >= '{0}' and dateDoc <= '{1}' \r\n                and typeDoc = {2} order by dateDoc desc", this.dateTimePicker_0.Value.ToString("yyyyMMdd"), this.dateTimePicker_1.Value.ToString("yyyyMMdd"), 0x57a), null, false, 0);
    }

    private void InitializeComponent()
    {
        this.components = new Container();
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FormSelectDamage));
        this.toolStrip = new ToolStrip();
        this.toolStripLabel_0 = new ToolStripLabel();
        this.toolStripLabel_1 = new ToolStripLabel();
        this.toolStripSeparator_0 = new ToolStripSeparator();
        this.btnApplyFilter = new ToolStripButton();
        this.btnResetFilter = new ToolStripButton();
        this.dgv = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
        this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
        this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
        this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
        this.bindingSource_0 = new BindingSource(this.components);
        this.dataSetDamage_0 = new DataSetDamage();
        this.buttonOK = new Button();
        this.buttonCancel = new Button();
        this.toolStrip.SuspendLayout();
        ((ISupportInitialize) this.dgv).BeginInit();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        this.dataSetDamage_0.BeginInit();
        base.SuspendLayout();
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripLabel_0, this.toolStripLabel_1, this.toolStripSeparator_0, this.btnApplyFilter, this.btnResetFilter };
        this.toolStrip.Items.AddRange(toolStripItems);
        this.toolStrip.Location = new Point(0, 0);
        this.toolStrip.Name = "toolStrip";
        this.toolStrip.Size = new Size(0x2e2, 0x19);
        this.toolStrip.TabIndex = 0;
        this.toolStrip.Text = "toolStrip1";
        this.toolStripLabel_0.Name = "toolStripLabel1";
        this.toolStripLabel_0.Size = new Size(0x2f, 0x16);
        this.toolStripLabel_0.Text = "Дата от";
        this.toolStripLabel_1.Name = "toolStripLabel2";
        this.toolStripLabel_1.Size = new Size(20, 0x16);
        this.toolStripLabel_1.Text = "до";
        this.toolStripSeparator_0.Name = "toolStripSeparator1";
        this.toolStripSeparator_0.Size = new Size(6, 0x19);
        this.btnApplyFilter.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.btnApplyFilter.Image = (Image) resources.GetObject("btnApplyFilter.Image");
        this.btnApplyFilter.ImageTransparentColor = Color.Magenta;
        this.btnApplyFilter.Name = "btnApplyFilter";
        this.btnApplyFilter.Size = new Size(0x17, 0x16);
        this.btnApplyFilter.Text = "Применить фильтр";
        this.btnApplyFilter.Click += new EventHandler(this.btnApplyFilter_Click);
        this.btnResetFilter.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.btnResetFilter.Image = (Image) resources.GetObject("btnResetFilter.Image");
        this.btnResetFilter.ImageTransparentColor = Color.Magenta;
        this.btnResetFilter.Name = "btnResetFilter";
        this.btnResetFilter.Size = new Size(0x17, 0x16);
        this.btnResetFilter.Text = "Сбросить фильтр";
        this.btnResetFilter.Click += new EventHandler(this.btnResetFilter_Click);
        this.dgv.AllowUserToAddRows = false;
        this.dgv.AllowUserToDeleteRows = false;
        this.dgv.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.dgv.AutoGenerateColumns = false;
        this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_1, this.dataGridViewFilterTextBoxColumn_2 };
        this.dgv.Columns.AddRange(dataGridViewColumns);
        this.dgv.DataSource = this.bindingSource_0;
        this.dgv.Location = new Point(0, 0x1c);
        this.dgv.Name = "dgv";
        this.dgv.ReadOnly = true;
        this.dgv.RowHeadersWidth = 0x15;
        this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dgv.Size = new Size(0x2e2, 270);
        this.dgv.TabIndex = 1;
        this.dgv.CellDoubleClick += new DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
        this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "numrequest";
        this.dataGridViewFilterTextBoxColumn_0.FilteringEnabled=(false);
        this.dataGridViewFilterTextBoxColumn_0.HeaderText = "№ документа";
        this.dataGridViewFilterTextBoxColumn_0.Name = "dataGridViewTextBoxColumn4";
        this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
        this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
        this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "dateDoc";
        this.dataGridViewFilterTextBoxColumn_1.FilteringEnabled=(false);
        this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Дата документа";
        this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewTextBoxColumn3";
        this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
        this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
        this.dataGridViewFilterTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "schmObjName";
        this.dataGridViewFilterTextBoxColumn_2.FilteringEnabled=(false);
        this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Электроустановка";
        this.dataGridViewFilterTextBoxColumn_2.Name = "schmObjName";
        this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
        this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
        this.bindingSource_0.DataMember = "vJ_Damage";
        this.bindingSource_0.DataSource = this.dataSetDamage_0;
        this.dataSetDamage_0.DataSetName = "DataSetDamage";
        this.dataSetDamage_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        this.buttonOK.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.buttonOK.DialogResult = DialogResult.OK;
        this.buttonOK.Location = new Point(12, 0x130);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new Size(0x4b, 0x17);
        this.buttonOK.TabIndex = 2;
        this.buttonOK.Text = "ОК";
        this.buttonOK.UseVisualStyleBackColor = true;
        this.buttonCancel.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.buttonCancel.DialogResult = DialogResult.Cancel;
        this.buttonCancel.Location = new Point(0x28b, 0x130);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new Size(0x4b, 0x17);
        this.buttonCancel.TabIndex = 3;
        this.buttonCancel.Text = "Отмена";
        this.buttonCancel.UseVisualStyleBackColor = true;
        base.AcceptButton = this.buttonOK;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.buttonCancel;
        base.ClientSize = new Size(0x2e2, 0x153);
        base.Controls.Add(this.buttonCancel);
        base.Controls.Add(this.buttonOK);
        base.Controls.Add(this.dgv);
        base.Controls.Add(this.toolStrip);
        base.Name = "FormSelectDamage";
        this.Text = "Выбор дефекта";
        base.FormClosing += new FormClosingEventHandler(this.FormSelectDamage_FormClosing);
        base.Load += new EventHandler(this.FormSelectDamage_Load);
        this.toolStrip.ResumeLayout(false);
        this.toolStrip.PerformLayout();
        ((ISupportInitialize) this.dgv).EndInit();
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        this.dataSetDamage_0.EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void btnApplyFilter_Click(object sender, EventArgs e)
    {
        this.GetTableDamge();
    }

    private void btnResetFilter_Click(object sender, EventArgs e)
    {
        this.SetPeriodTimer();
        this.GetTableDamge();
    }
}

