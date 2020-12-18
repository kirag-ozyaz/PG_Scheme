using System;
using System.Drawing;
using System.Windows.Forms;

namespace RequestForRepair
{
    partial class FormLinkRequestAndSchm
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
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
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.Text = "Form0";
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
            this.groupBoxDuration = new GroupBox();
            this.label3 = new Label();
            this.dateTimePickerDateBeg = new DateTimePicker();
            this.dateTimePickerDateEnd = new DateTimePicker();
            this.label4 = new Label();
            this.label5 = new Label();
            this.textBoxDuration = new TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBoxDuration.SuspendLayout();
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
            this.listBoxObjects.Size = new Size(232, 277);
            this.listBoxObjects.Sorted = true;
            this.listBoxObjects.TabIndex = 2;
            this.buttonAdd.Location = new Point(218, 28);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new Size(53, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = ">>>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
            this.buttonDel.Location = new Point(218, 57);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new Size(53, 23);
            this.buttonDel.TabIndex = 4;
            this.buttonDel.Text = "<<<";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new EventHandler(this.buttonDel_Click);
            this.buttonOk.DialogResult = DialogResult.OK;
            this.buttonOk.Location = new Point(3, 464);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new EventHandler(this.buttonOk_Click);
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
            this.tooBtnFind.Image = global::RequestForRepair.Properties.Resources.Find;
            this.tooBtnFind.ImageTransparentColor = Color.Magenta;
            this.tooBtnFind.Name = "tooBtnFind";
            this.tooBtnFind.Size = new Size(23, 22);
            this.tooBtnFind.Text = "toolStripButton1";
            this.tooBtnFind.Click += new EventHandler(this.tooBtnFind_Click);
            this.toolTxtFind.Name = "toolTxtFind";
            this.toolTxtFind.Size = new Size(100, 25);
            this.toolTxtFind.KeyDown += new KeyEventHandler(this.toolTxtFind_KeyDown);
            this.toolBtnFindNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNext.Image = global::RequestForRepair.Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new Size(23, 22);
            this.toolBtnFindNext.Text = "toolStripButton1";
            this.toolBtnFindNext.Click += new EventHandler(this.toolBtnFindNext_Click);
            this.toolBtnFindPrev.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrev.Image = global::RequestForRepair.Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new Size(23, 22);
            this.toolBtnFindPrev.Text = "toolStripButton2";
            this.toolBtnFindPrev.Click += new EventHandler(this.toolBtnFindPrev_Click);
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
            this.groupBoxDuration.Controls.Add(this.textBoxDuration);
            this.groupBoxDuration.Controls.Add(this.label5);
            this.groupBoxDuration.Controls.Add(this.dateTimePickerDateEnd);
            this.groupBoxDuration.Controls.Add(this.label4);
            this.groupBoxDuration.Controls.Add(this.dateTimePickerDateBeg);
            this.groupBoxDuration.Controls.Add(this.label3);
            this.groupBoxDuration.Location = new Point(277, 308);
            this.groupBoxDuration.Name = "groupBoxDuration";
            this.groupBoxDuration.Size = new Size(232, 150);
            this.groupBoxDuration.TabIndex = 10;
            this.groupBoxDuration.TabStop = false;
            this.groupBoxDuration.Text = "Период";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дата начала";
            this.dateTimePickerDateBeg.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerDateBeg.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerDateBeg.Location = new Point(9, 32);
            this.dateTimePickerDateBeg.Name = "dateTimePickerDateBeg";
            this.dateTimePickerDateBeg.Size = new Size(217, 20);
            this.dateTimePickerDateBeg.TabIndex = 1;
            this.dateTimePickerDateEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerDateEnd.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerDateEnd.Location = new Point(9, 71);
            this.dateTimePickerDateEnd.Name = "dateTimePickerDateEnd";
            this.dateTimePickerDateEnd.Size = new Size(217, 20);
            this.dateTimePickerDateEnd.TabIndex = 3;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new Size(71, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата начала";
            this.label5.AutoSize = true;
            this.label5.Location = new Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Длительность";
            this.textBoxDuration.Location = new Point(9, 110);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new Size(217, 20);
            this.textBoxDuration.TabIndex = 5;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.buttonCancel;
            base.ClientSize = new Size(521, 495);
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
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Name = "FormLinkRequestAndSchm";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Привязка заявок к схеме";
            base.Load += new EventHandler(this.FormLinkRequestAndSchm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxDuration.ResumeLayout(false);
            this.groupBoxDuration.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        private System.ComponentModel.IContainer components = null;
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
        #endregion
    }
}