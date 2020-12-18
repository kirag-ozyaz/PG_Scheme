using ControlsLbr.DataGridViewExcelFilter;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormSelectLine : FormLbr.FormBase
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewLine = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnFind = new System.Windows.Forms.ToolStripButton();
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolBTnFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFindNext = new System.Windows.Forms.ToolStripButton();
            this.dgvCabSection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.columnNameCabSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.progressBarLoad = new System.Windows.Forms.ProgressBar();
            this.labelLoad = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewLine);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvCabSection);
            this.splitContainer1.Size = new System.Drawing.Size(693, 522);
            this.splitContainer1.SplitterDistance = 335;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewLine
            // 
            this.treeViewLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewLine.HideSelection = false;
            this.treeViewLine.Location = new System.Drawing.Point(0, 25);
            this.treeViewLine.Name = "treeViewLine";
            this.treeViewLine.Size = new System.Drawing.Size(335, 497);
            this.treeViewLine.TabIndex = 1;
            this.treeViewLine.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewLine_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnFind,
            this.txtFind,
            this.toolBTnFindPrev,
            this.toolBtnFindNext});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(335, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnFind
            // 
            this.toolBtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFind.Image = global::DailyReportN.Properties.Resources.Find;
            this.toolBtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFind.Name = "toolBtnFind";
            this.toolBtnFind.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFind.Text = "Поиск";
            this.toolBtnFind.Click += new System.EventHandler(this.toolBtnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 25);
            this.txtFind.ToolTipText = "Строка поиска";
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // toolBTnFindPrev
            // 
            this.toolBTnFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBTnFindPrev.Image = global::DailyReportN.Properties.Resources.FindPrev;
            this.toolBTnFindPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBTnFindPrev.Name = "toolBTnFindPrev";
            this.toolBTnFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolBTnFindPrev.Text = "Поиск назад";
            this.toolBTnFindPrev.Click += new System.EventHandler(this.toolBTnFindPrev_Click);
            // 
            // toolBtnFindNext
            // 
            this.toolBtnFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNext.Image = global::DailyReportN.Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindNext.Text = "Поиск вперед";
            this.toolBtnFindNext.Click += new System.EventHandler(this.toolBtnFindNext_Click);
            // 
            // dgvCabSection
            // 
            this.dgvCabSection.AllowUserToAddRows = false;
            this.dgvCabSection.AllowUserToDeleteRows = false;
            this.dgvCabSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabSection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNameCabSection,
            this.columnId});
            this.dgvCabSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCabSection.Location = new System.Drawing.Point(0, 0);
            this.dgvCabSection.Name = "dgvCabSection";
            this.dgvCabSection.ReadOnly = true;
            this.dgvCabSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCabSection.Size = new System.Drawing.Size(354, 522);
            this.dgvCabSection.TabIndex = 0;
            // 
            // columnNameCabSrction
            // 
            this.columnNameCabSection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNameCabSection.DataPropertyName = "Number";
            this.columnNameCabSection.HeaderText = "Участок";
            this.columnNameCabSection.Name = "columnNameCabSection";
            this.columnNameCabSection.ReadOnly = true;
            // 
            // columnId
            // 
            this.columnId.DataPropertyName = "id";
            this.columnId.HeaderText = "Id";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Visible = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 531);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(606, 531);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarLoad.Location = new System.Drawing.Point(264, 531);
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(336, 23);
            this.progressBarLoad.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarLoad.TabIndex = 3;
            // 
            // labelLoad
            // 
            this.labelLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLoad.AutoSize = true;
            this.labelLoad.Location = new System.Drawing.Point(105, 536);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(153, 13);
            this.labelLoad.TabIndex = 4;
            this.labelLoad.Text = "Загрузка дерева объектов...";
            // 
            // Form26
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(693, 566);
            this.Controls.Add(this.labelLoad);
            this.Controls.Add(this.progressBarLoad);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormSelectLine";
            this.Text = "Выбор объекта схемы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSelectLine_FormClosing);
            this.Load += new System.EventHandler(this.FormSelectLine_Load);
            this.Shown += new System.EventHandler(this.FormSelectLine_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    private SplitContainer splitContainer1;

    private TreeView treeViewLine;

    private ToolStrip toolStrip1;

    private Button buttonOK;

    private Button buttonCancel;

    private ToolStripButton toolBtnFind;

    private ToolStripTextBox txtFind;

    private ToolStripButton toolBTnFindPrev;

    private ToolStripButton toolBtnFindNext;

    private ProgressBar progressBarLoad;

    private Label labelLoad;

    private DataGridViewExcelFilter dgvCabSection;

    private DataGridViewTextBoxColumn columnNameCabSection;

    private DataGridViewTextBoxColumn columnId;

    private BindingSource bindingSource1;

}
