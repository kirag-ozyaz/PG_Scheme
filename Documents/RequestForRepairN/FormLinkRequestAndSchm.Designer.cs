internal partial class FormLinkRequestAndSchm : FormLbr.FormBase
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

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
		this.label3 = new System.Windows.Forms.Label();
		this.dateTimePickerDateBeg = new System.Windows.Forms.DateTimePicker();
		this.dateTimePickerDateEnd = new System.Windows.Forms.DateTimePicker();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.textBoxDuration = new System.Windows.Forms.TextBox();
		this.toolStrip1.SuspendLayout();
		this.groupBoxDuration.SuspendLayout();
		base.SuspendLayout();
		this.treeViewSubstation.CheckBoxes = true;
		this.treeViewSubstation.HideSelection = false;
		this.treeViewSubstation.Location = new System.Drawing.Point(2, 28);
		this.treeViewSubstation.Name = "treeViewSubstation";
		this.treeViewSubstation.Size = new System.Drawing.Size(210, 430);
		this.treeViewSubstation.TabIndex = 0;
		this.treeViewSubstation.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewSubstation_BeforeExpand);
		this.treeViewSubstation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSubstation_AfterSelect);
		this.treeViewSubs.CheckBoxes = true;
		this.treeViewSubs.Location = new System.Drawing.Point(2, 258);
		this.treeViewSubs.Name = "treeViewSubs";
		this.treeViewSubs.Size = new System.Drawing.Size(210, 200);
		this.treeViewSubs.TabIndex = 1;
		this.listBoxObjects.FormattingEnabled = true;
		this.listBoxObjects.Location = new System.Drawing.Point(277, 25);
		this.listBoxObjects.Name = "listBoxObjects";
		this.listBoxObjects.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
		this.listBoxObjects.Size = new System.Drawing.Size(232, 277);
		this.listBoxObjects.Sorted = true;
		this.listBoxObjects.TabIndex = 2;
		this.buttonAdd.Location = new System.Drawing.Point(218, 28);
		this.buttonAdd.Name = "buttonAdd";
		this.buttonAdd.Size = new System.Drawing.Size(53, 23);
		this.buttonAdd.TabIndex = 3;
		this.buttonAdd.Text = ">>>";
		this.buttonAdd.UseVisualStyleBackColor = true;
		this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
		this.buttonDel.Location = new System.Drawing.Point(218, 57);
		this.buttonDel.Name = "buttonDel";
		this.buttonDel.Size = new System.Drawing.Size(53, 23);
		this.buttonDel.TabIndex = 4;
		this.buttonDel.Text = "<<<";
		this.buttonDel.UseVisualStyleBackColor = true;
		this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
		this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.buttonOk.Location = new System.Drawing.Point(3, 464);
		this.buttonOk.Name = "buttonOk";
		this.buttonOk.Size = new System.Drawing.Size(75, 23);
		this.buttonOk.TabIndex = 5;
		this.buttonOk.Text = "OK";
		this.buttonOk.UseVisualStyleBackColor = true;
		this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
		this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.buttonCancel.Location = new System.Drawing.Point(434, 464);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(75, 23);
		this.buttonCancel.TabIndex = 6;
		this.buttonCancel.Text = "Отмена";
		this.buttonCancel.UseVisualStyleBackColor = true;
		this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
		this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
		{
			this.tooBtnFind,
			this.toolTxtFind,
			this.toolBtnFindNext,
			this.toolBtnFindPrev
		});
		this.toolStrip1.Location = new System.Drawing.Point(3, 0);
		this.toolStrip1.Name = "toolStrip1";
		this.toolStrip1.Size = new System.Drawing.Size(183, 25);
		this.toolStrip1.TabIndex = 7;
		this.toolStrip1.Text = "toolStripTreeSubstations";
		this.tooBtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.tooBtnFind.Image = RequestForRepairN.Properties.Resources.Find;
		this.tooBtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tooBtnFind.Name = "tooBtnFind";
		this.tooBtnFind.Size = new System.Drawing.Size(23, 22);
		this.tooBtnFind.Text = "toolStripButton1";
		this.tooBtnFind.Click += new System.EventHandler(this.tooBtnFind_Click);
		this.toolTxtFind.Name = "toolTxtFind";
		this.toolTxtFind.Size = new System.Drawing.Size(100, 25);
		this.toolTxtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTxtFind_KeyDown);
		this.toolBtnFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.toolBtnFindNext.Image = RequestForRepairN.Properties.Resources.FindNext;
		this.toolBtnFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolBtnFindNext.Name = "toolBtnFindNext";
		this.toolBtnFindNext.Size = new System.Drawing.Size(23, 22);
		this.toolBtnFindNext.Text = "toolStripButton1";
		this.toolBtnFindNext.Click += new System.EventHandler(this.toolBtnFindNext_Click);
		this.toolBtnFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.toolBtnFindPrev.Image = RequestForRepairN.Properties.Resources.FindPrev;
		this.toolBtnFindPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolBtnFindPrev.Name = "toolBtnFindPrev";
		this.toolBtnFindPrev.Size = new System.Drawing.Size(23, 22);
		this.toolBtnFindPrev.Text = "toolStripButton2";
		this.toolBtnFindPrev.Click += new System.EventHandler(this.toolBtnFindPrev_Click);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(12, 242);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(115, 13);
		this.label1.TabIndex = 8;
		this.label1.Text = "Объекты подстанции";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(274, 12);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(124, 13);
		this.label2.TabIndex = 9;
		this.label2.Text = "Привязанные объекты";
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
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(6, 16);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(71, 13);
		this.label3.TabIndex = 0;
		this.label3.Text = "Дата начала";
		this.dateTimePickerDateBeg.CustomFormat = "dd.MM.yyyy HH:mm";
		this.dateTimePickerDateBeg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
		this.dateTimePickerDateBeg.Location = new System.Drawing.Point(9, 32);
		this.dateTimePickerDateBeg.Name = "dateTimePickerDateBeg";
		this.dateTimePickerDateBeg.Size = new System.Drawing.Size(217, 20);
		this.dateTimePickerDateBeg.TabIndex = 1;
		this.dateTimePickerDateEnd.CustomFormat = "dd.MM.yyyy HH:mm";
		this.dateTimePickerDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
		this.dateTimePickerDateEnd.Location = new System.Drawing.Point(9, 71);
		this.dateTimePickerDateEnd.Name = "dateTimePickerDateEnd";
		this.dateTimePickerDateEnd.Size = new System.Drawing.Size(217, 20);
		this.dateTimePickerDateEnd.TabIndex = 3;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(6, 55);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(71, 13);
		this.label4.TabIndex = 2;
		this.label4.Text = "Дата начала";
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(6, 94);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(80, 13);
		this.label5.TabIndex = 4;
		this.label5.Text = "Длительность";
		this.textBoxDuration.Location = new System.Drawing.Point(9, 110);
		this.textBoxDuration.Name = "textBoxDuration";
		this.textBoxDuration.Size = new System.Drawing.Size(217, 20);
		this.textBoxDuration.TabIndex = 5;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.buttonCancel;
		base.ClientSize = new System.Drawing.Size(521, 495);
		base.Controls.Add(this.groupBoxDuration);
		base.Controls.Add(this.treeViewSubstation);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.toolStrip1);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.buttonOk);
		base.Controls.Add(this.buttonDel);
		base.Controls.Add(this.buttonAdd);
		base.Controls.Add(this.listBoxObjects);
		base.Controls.Add(this.treeViewSubs);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Name = "FormLinkRequestAndSchm";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Привязка заявок к схеме";
		base.Load += new System.EventHandler(this.FormLinkRequestAndSchm_Load);
		this.toolStrip1.ResumeLayout(false);
		this.toolStrip1.PerformLayout();
		this.groupBoxDuration.ResumeLayout(false);
		this.groupBoxDuration.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private System.ComponentModel.IContainer components = null;

	private System.Windows.Forms.TreeView treeViewSubstation;

	private System.Windows.Forms.TreeView treeViewSubs;

	private System.Windows.Forms.ListBox listBoxObjects;

	private System.Windows.Forms.Button buttonAdd;

	private System.Windows.Forms.Button buttonDel;

	private System.Windows.Forms.Button buttonOk;

	private System.Windows.Forms.Button buttonCancel;

	private System.Windows.Forms.ToolStrip toolStrip1;

	private System.Windows.Forms.ToolStripButton tooBtnFind;

	private System.Windows.Forms.ToolStripTextBox toolTxtFind;

	private System.Windows.Forms.ToolStripButton toolBtnFindNext;

	private System.Windows.Forms.ToolStripButton toolBtnFindPrev;

	private System.Windows.Forms.Label label1;

	private System.Windows.Forms.Label label2;

	private System.Windows.Forms.GroupBox groupBoxDuration;

	private System.Windows.Forms.TextBox textBoxDuration;

	private System.Windows.Forms.Label label5;

	private System.Windows.Forms.DateTimePicker dateTimePickerDateEnd;

	private System.Windows.Forms.Label label4;

	private System.Windows.Forms.DateTimePicker dateTimePickerDateBeg;

	private System.Windows.Forms.Label label3;
}
