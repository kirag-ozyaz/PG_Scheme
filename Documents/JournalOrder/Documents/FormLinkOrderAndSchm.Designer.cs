using System.Drawing;
using System.Windows.Forms;
namespace JournalOrder
{
    internal partial class FormLinkOrderAndSchm
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
            this.treeViewSubstation = new TreeView();
            this.treeViewSubs = new TreeView();
            this.listBoxObjects = new ListBox();
            this.buttonAdd = new Button();
            this.buttonDel = new Button();
            this.buttonOk = new Button();
            this.buttonCancel = new Button();
            this.toolStrip1 = new ToolStrip();
            this.tooBtnFind = new ToolStripButton();
            this.toolTxtFind = new ToolStripTextBox();
            this.toolBtnFindNext = new ToolStripButton();
            this.toolBtnFindPrev = new ToolStripButton();
            this.label1 = new Label();
            this.label2 = new Label();
            this.toolStrip1.SuspendLayout();
            base.SuspendLayout();
            this.treeViewSubstation.CheckBoxes = true;
            this.treeViewSubstation.HideSelection = false;
            this.treeViewSubstation.Location = new Point(2, 28);
            this.treeViewSubstation.Name = "treeViewSubstation";
            this.treeViewSubstation.Size = new Size(210, 430);
            this.treeViewSubstation.TabIndex = 0;
            this.treeViewSubstation.BeforeExpand += new TreeViewCancelEventHandler(this.treeViewSubstation_BeforeExpand);
            this.treeViewSubstation.AfterSelect += new TreeViewEventHandler(this.treeViewSubstation_AfterSelect);
            this.treeViewSubs.CheckBoxes = true;
            this.treeViewSubs.Location = new Point(2, 258);
            this.treeViewSubs.Name = "treeViewSubs";
            this.treeViewSubs.Size = new Size(210, 200);
            this.treeViewSubs.TabIndex = 1;
            this.listBoxObjects.FormattingEnabled = true;
            this.listBoxObjects.Location = new Point(277, 25);
            this.listBoxObjects.Name = "listBoxObjects";
            this.listBoxObjects.SelectionMode = SelectionMode.MultiExtended;
            this.listBoxObjects.Size = new Size(232, 433);
            this.listBoxObjects.Sorted = true;
            this.listBoxObjects.TabIndex = 2;
            this.buttonAdd.Location = new Point(218, 180);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new Size(53, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = ">>>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonDel.Location = new Point(218, 279);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new Size(53, 23);
            this.buttonDel.TabIndex = 4;
            this.buttonDel.Text = "<<<";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            this.buttonOk.DialogResult = DialogResult.OK;
            this.buttonOk.Location = new Point(3, 464);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.Location = new Point(434, 464);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.toolStrip1.Dock = DockStyle.None;
            this.toolStrip1.Items.AddRange(new ToolStripItem[]
            {
            this.tooBtnFind,
            this.toolTxtFind,
            this.toolBtnFindNext,
            this.toolBtnFindPrev
            });
            this.toolStrip1.Location = new Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(183, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStripTreeSubstations";
            this.tooBtnFind.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tooBtnFind.Image = Properties.Resources.Find;
            this.tooBtnFind.ImageTransparentColor = Color.Magenta;
            this.tooBtnFind.Name = "tooBtnFind";
            this.tooBtnFind.Size = new Size(23, 22);
            this.tooBtnFind.Text = "toolStripButton1";
            this.tooBtnFind.Click += new System.EventHandler(this.tooBtnFind_Click);
            this.toolTxtFind.Name = "toolTxtFind";
            this.toolTxtFind.Size = new Size(100, 25);
            this.toolTxtFind.KeyDown += new KeyEventHandler(this.toolTxtFind_KeyDown);
            this.toolBtnFindNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNext.Image = Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new Size(23, 22);
            this.toolBtnFindNext.Text = "toolStripButton1";
            this.toolBtnFindNext.Click += new System.EventHandler(this.toolBtnFindNext_Click);
            this.toolBtnFindPrev.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrev.Image = Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new Size(23, 22);
            this.toolBtnFindPrev.Text = "toolStripButton2";
            this.toolBtnFindPrev.Click += new System.EventHandler(this.toolBtnFindPrev_Click);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Объекты подстанции";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(274, 12);
            this.label2.Name = "label2";
            this.label2.Size = new Size(124, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Привязанные объекты";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.buttonCancel;
            base.ClientSize = new Size(512, 495);
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
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Name = "FormLinkOrderAndSchm";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Привязка нарядов к схеме";
            base.Load += new System.EventHandler(this.FormLinkOrderAndSchm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
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
    }
}