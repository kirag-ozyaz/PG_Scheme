using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormLinkRequestAndSchmPL
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

	private System.ComponentModel.IContainer components = null;

    private void InitializeComponent()
    {
            this.treeViewSubstation = new System.Windows.Forms.TreeView();
            this.treeViewSubs = new System.Windows.Forms.TreeView();
            this.listBoxObjects = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tooBtnFind = new System.Windows.Forms.ToolStripButton();
            this.toolTxtFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFindPrev = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDuration = new System.Windows.Forms.GroupBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDateBeg = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBoxDuration.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewSubstation
            // 
            this.treeViewSubstation.CheckBoxes = true;
            this.treeViewSubstation.HideSelection = false;
            this.treeViewSubstation.Location = new System.Drawing.Point(2, 28);
            this.treeViewSubstation.Name = "treeViewSubstation";
            this.treeViewSubstation.Size = new System.Drawing.Size(210, 430);
            this.treeViewSubstation.TabIndex = 0;
            this.treeViewSubstation.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewSubstation_BeforeExpand);
            this.treeViewSubstation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSubstation_AfterSelect);
            // 
            // treeViewSubs
            // 
            this.treeViewSubs.CheckBoxes = true;
            this.treeViewSubs.Location = new System.Drawing.Point(2, 258);
            this.treeViewSubs.Name = "treeViewSubs";
            this.treeViewSubs.Size = new System.Drawing.Size(210, 200);
            this.treeViewSubs.TabIndex = 1;
            // 
            // listBoxObjects
            // 
            this.listBoxObjects.FormattingEnabled = true;
            this.listBoxObjects.Location = new System.Drawing.Point(277, 25);
            this.listBoxObjects.Name = "listBoxObjects";
            this.listBoxObjects.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxObjects.Size = new System.Drawing.Size(232, 277);
            this.listBoxObjects.Sorted = true;
            this.listBoxObjects.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(218, 28);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(53, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = ">>>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(218, 57);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(53, 23);
            this.buttonDel.TabIndex = 4;
            this.buttonDel.Text = "<<<";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonOk
            // 
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
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(434, 464);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooBtnFind,
            this.toolTxtFind,
            this.toolBtnFindNext,
            this.toolBtnFindPrev});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(183, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStripTreeSubstations";
            // 
            // tooBtnFind
            // 
            this.tooBtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tooBtnFind.Image = global::RequestForRepairN.Properties.Resources.Find;
            this.tooBtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooBtnFind.Name = "tooBtnFind";
            this.tooBtnFind.Size = new System.Drawing.Size(23, 22);
            this.tooBtnFind.Text = "toolStripButton1";
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
            this.toolBtnFindNext.Image = global::RequestForRepairN.Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindNext.Text = "toolStripButton1";
            this.toolBtnFindNext.Click += new System.EventHandler(this.toolBtnFindNext_Click);
            // 
            // toolBtnFindPrev
            // 
            this.toolBtnFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrev.Image = global::RequestForRepairN.Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindPrev.Text = "toolStripButton2";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Привязанные объекты";
            // 
            // groupBoxDuration
            // 
            this.groupBoxDuration.Controls.Add(this.textBoxDuration);
            this.groupBoxDuration.Controls.Add(this.label5);
            this.groupBoxDuration.Controls.Add(this.dateTimePickerDateEnd);
            this.groupBoxDuration.Controls.Add(this.label4);
            this.groupBoxDuration.Controls.Add(this.dateTimePickerDateBeg);
            this.groupBoxDuration.Controls.Add(this.label3);
            this.groupBoxDuration.Location = new System.Drawing.Point(277, 308);
            this.groupBoxDuration.Name = "groupBoxDuration";
            this.groupBoxDuration.Size = new System.Drawing.Size(232, 150);
            this.groupBoxDuration.TabIndex = 10;
            this.groupBoxDuration.TabStop = false;
            this.groupBoxDuration.Text = "Период";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(9, 110);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(217, 20);
            this.textBoxDuration.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Длительность";
            // 
            // dateTimePickerDateEnd
            // 
            this.dateTimePickerDateEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateEnd.Location = new System.Drawing.Point(9, 71);
            this.dateTimePickerDateEnd.Name = "dateTimePickerDateEnd";
            this.dateTimePickerDateEnd.Size = new System.Drawing.Size(217, 20);
            this.dateTimePickerDateEnd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата начала";
            // 
            // dateTimePickerDateBeg
            // 
            this.dateTimePickerDateBeg.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerDateBeg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateBeg.Location = new System.Drawing.Point(9, 32);
            this.dateTimePickerDateBeg.Name = "dateTimePickerDateBeg";
            this.dateTimePickerDateBeg.Size = new System.Drawing.Size(217, 20);
            this.dateTimePickerDateBeg.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дата начала";
            // 
            // FormLinkRequestAndSchmPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(517, 495);
            this.Controls.Add(this.groupBoxDuration);
            this.Controls.Add(this.treeViewSubstation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxObjects);
            this.Controls.Add(this.treeViewSubs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormLinkRequestAndSchmPL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Привязка заявок к схеме";
            this.Load += new System.EventHandler(this.FormLinkRequestAndSchm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxDuration.ResumeLayout(false);
            this.groupBoxDuration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }


    private TreeView treeViewSubstation;
    private TreeView treeViewSubs;
    private ListBox listBoxObjects;
    private Button buttonAdd;
    private Button buttonDel;
    private Button buttonOk;
    private Button buttonCancel;
    private ToolStrip toolStrip1;
    private ToolStripButton tooBtnFind;
    private ToolStripTextBox toolTxtFind;
    private ToolStripButton toolBtnFindNext;
    private ToolStripButton toolBtnFindPrev;
    private Label label1;
    private Label label2;
    private GroupBox groupBoxDuration;
    private TextBox textBoxDuration;
    private Label label5;
    private DateTimePicker dateTimePickerDateEnd;
    private Label label4;
    private DateTimePicker dateTimePickerDateBeg;
    private Label label3;
}
