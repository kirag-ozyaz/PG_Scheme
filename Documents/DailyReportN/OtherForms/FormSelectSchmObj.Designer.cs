using System.Drawing;
using System.Windows.Forms;

internal partial class FormSelectSchmObj : global::FormLbr.FormBase
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		//global::Form28.B6WK5MOV84LK6ZhrCq7c(this, disposing);
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.treeViewSubstation = new System.Windows.Forms.TreeView();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tooBtnFind = new System.Windows.Forms.ToolStripButton();
            this.toolTxtFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFindPrev = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxUseBusParent = new System.Windows.Forms.CheckBox();
            this.chkFilterAllSubstations = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewSubstation
            // 
            this.treeViewSubstation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewSubstation.HideSelection = false;
            this.treeViewSubstation.Location = new System.Drawing.Point(0, 28);
            this.treeViewSubstation.Name = "treeViewSubstation";
            this.treeViewSubstation.Size = new System.Drawing.Size(466, 404);
            this.treeViewSubstation.TabIndex = 0;
            this.treeViewSubstation.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewSubstation_BeforeExpand);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(3, 464);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(379, 464);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooBtnFind,
            this.toolTxtFind,
            this.toolBtnFindNext,
            this.toolBtnFindPrev});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(466, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStripTreeSubstations";
            // 
            // tooBtnFind
            // 
            this.tooBtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooBtnFind.Image = global::DailyReportN.Properties.Resources.Find;
            this.tooBtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooBtnFind.Name = "tooBtnFind";
            this.tooBtnFind.Size = new System.Drawing.Size(23, 22);
            this.tooBtnFind.Text = "Поиск";
            this.tooBtnFind.Click += new System.EventHandler(this.tooBtnFind_Click);
            // 
            // toolTxtFind
            // 
            this.toolTxtFind.Name = "toolTxtFind";
            this.toolTxtFind.Size = new System.Drawing.Size(100, 25);
            this.toolTxtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTxtFind_KeyDown);
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
            // toolBtnFindPrev
            // 
            this.toolBtnFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrev.Image = global::DailyReportN.Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindPrev.Text = "Поиск назад";
            this.toolBtnFindPrev.Click += new System.EventHandler(this.toolBtnFindPrev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Объекты подстанции";
            // 
            // checkBoxUseBusParent
            // 
            this.checkBoxUseBusParent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxUseBusParent.AutoSize = true;
            this.checkBoxUseBusParent.Checked = true;
            this.checkBoxUseBusParent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseBusParent.Location = new System.Drawing.Point(3, 441);
            this.checkBoxUseBusParent.Name = "checkBoxUseBusParent";
            this.checkBoxUseBusParent.Size = new System.Drawing.Size(109, 17);
            this.checkBoxUseBusParent.TabIndex = 10;
            this.checkBoxUseBusParent.Text = "Основные шины";
            this.checkBoxUseBusParent.UseVisualStyleBackColor = true;
            this.checkBoxUseBusParent.CheckedChanged += new System.EventHandler(this.checkBoxUseBusParent_CheckedChanged);
            // 
            // chkFilterAllSubstations
            // 
            this.chkFilterAllSubstations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFilterAllSubstations.AutoSize = true;
            this.chkFilterAllSubstations.Location = new System.Drawing.Point(296, 441);
            this.chkFilterAllSubstations.Name = "chkFilterAllSubstations";
            this.chkFilterAllSubstations.Size = new System.Drawing.Size(158, 17);
            this.chkFilterAllSubstations.TabIndex = 11;
            this.chkFilterAllSubstations.Text = "Показать все подстанции";
            this.chkFilterAllSubstations.UseVisualStyleBackColor = true;
            this.chkFilterAllSubstations.Visible = false;
            this.chkFilterAllSubstations.CheckedChanged += new System.EventHandler(this.chkFilterAllSubstations_CheckedChanged);
            // 
            // FormSelectSchmObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(466, 502);
            this.Controls.Add(this.chkFilterAllSubstations);
            this.Controls.Add(this.checkBoxUseBusParent);
            this.Controls.Add(this.treeViewSubstation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSelectSchmObj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Привязка объекта к схеме";
        this.Load += new System.EventHandler(this.FormSelectSchmObj_Load);
        this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }


    private global::System.ComponentModel.IContainer components =null;
    private TreeView treeViewSubstation;

    private Button buttonOk;

    private Button buttonCancel;

    private ToolStrip toolStrip1;

    private ToolStripButton tooBtnFind;

    private ToolStripTextBox toolTxtFind;

    private ToolStripButton toolBtnFindNext;

    private ToolStripButton toolBtnFindPrev;

    private Label label1;

    private CheckBox checkBoxUseBusParent;

    private CheckBox chkFilterAllSubstations;
}
