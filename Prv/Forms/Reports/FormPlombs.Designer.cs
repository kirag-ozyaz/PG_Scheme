namespace Prv.Forms.Reports
{
    partial class FormPlombs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlombs));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.treeViewMasters = new nsThreeStateTreeview.ThreeStateTreeview();
            this.toolStripTree = new System.Windows.Forms.ToolStrip();
            this.toolBtnShowDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxGrid = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.buttonrReport = new System.Windows.Forms.Button();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.checkBoxFree = new System.Windows.Forms.CheckBox();
            this.checkBoxDel = new System.Windows.Forms.CheckBox();
            this.checkBoxDem = new System.Windows.Forms.CheckBox();
            this.checkBoxUst = new System.Windows.Forms.CheckBox();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButtonGive = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBoxItog = new System.Windows.Forms.GroupBox();
            this.radioButtonItog = new System.Windows.Forms.RadioButton();
            this.radioButtonDatail = new System.Windows.Forms.RadioButton();
            this.checkedListBoxType = new System.Windows.Forms.CheckedListBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.dateTimePickerBeg = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelDateBeg = new System.Windows.Forms.Label();
            this.dsPlomb = new Prv.DataSets.DataSetPlomb();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.toolStripTree.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBoxItog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlomb)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.treeViewMasters);
            this.splitContainerMain.Panel1.Controls.Add(this.toolStripTree);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.buttonrReport);
            this.splitContainerMain.Panel2.Controls.Add(this.radioButtonAll);
            this.splitContainerMain.Panel2.Controls.Add(this.checkBoxFree);
            this.splitContainerMain.Panel2.Controls.Add(this.checkBoxDel);
            this.splitContainerMain.Panel2.Controls.Add(this.checkBoxDem);
            this.splitContainerMain.Panel2.Controls.Add(this.checkBoxUst);
            this.splitContainerMain.Panel2.Controls.Add(this.radioButtonOther);
            this.splitContainerMain.Panel2.Controls.Add(this.radioButtonGive);
            this.splitContainerMain.Panel2.Controls.Add(this.buttonClose);
            this.splitContainerMain.Panel2.Controls.Add(this.groupBox);
            this.splitContainerMain.Size = new System.Drawing.Size(534, 291);
            this.splitContainerMain.SplitterDistance = 204;
            this.splitContainerMain.TabIndex = 0;
            // 
            // treeViewMasters
            // 
            this.treeViewMasters.CheckBoxes = true;
            this.treeViewMasters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMasters.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.treeViewMasters.Location = new System.Drawing.Point(0, 25);
            this.treeViewMasters.Name = "treeViewMasters";
            this.treeViewMasters.Size = new System.Drawing.Size(204, 266);
            this.treeViewMasters.TabIndex = 11;
            // 
            // toolStripTree
            // 
            this.toolStripTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnShowDel,
            this.toolStripTextBoxGrid,
            this.toolStripButtonFind});
            this.toolStripTree.Location = new System.Drawing.Point(0, 0);
            this.toolStripTree.Name = "toolStripTree";
            this.toolStripTree.Size = new System.Drawing.Size(204, 25);
            this.toolStripTree.TabIndex = 12;
            this.toolStripTree.Text = "toolStrip1";
            // 
            // toolBtnShowDel
            // 
            this.toolBtnShowDel.CheckOnClick = true;
            this.toolBtnShowDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnShowDel.Image = global::Prv.Properties.Resources.Trash;
            this.toolBtnShowDel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnShowDel.Name = "toolBtnShowDel";
            this.toolBtnShowDel.Size = new System.Drawing.Size(23, 22);
            this.toolBtnShowDel.Text = "Показать удаленных";
            this.toolBtnShowDel.Click += new System.EventHandler(this.toolBtnShowDel_Click);
            // 
            // toolStripTextBoxGrid
            // 
            this.toolStripTextBoxGrid.Name = "toolStripTextBoxGrid";
            this.toolStripTextBoxGrid.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxGrid_KeyDown);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFind.Image")));
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // buttonrReport
            // 
            this.buttonrReport.Location = new System.Drawing.Point(178, 163);
            this.buttonrReport.Name = "buttonrReport";
            this.buttonrReport.Size = new System.Drawing.Size(144, 23);
            this.buttonrReport.TabIndex = 26;
            this.buttonrReport.Text = "Отчет";
            this.buttonrReport.UseVisualStyleBackColor = true;
            this.buttonrReport.Click += new System.EventHandler(this.buttonrReport_Click);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(178, 140);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(44, 17);
            this.radioButtonAll.TabIndex = 25;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Все";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.Visible = false;
            // 
            // checkBoxFree
            // 
            this.checkBoxFree.AutoSize = true;
            this.checkBoxFree.Enabled = false;
            this.checkBoxFree.Location = new System.Drawing.Point(200, 117);
            this.checkBoxFree.Name = "checkBoxFree";
            this.checkBoxFree.Size = new System.Drawing.Size(83, 17);
            this.checkBoxFree.TabIndex = 24;
            this.checkBoxFree.Text = "Свободные";
            this.checkBoxFree.UseVisualStyleBackColor = true;
            // 
            // checkBoxDel
            // 
            this.checkBoxDel.AutoSize = true;
            this.checkBoxDel.Enabled = false;
            this.checkBoxDel.Location = new System.Drawing.Point(200, 94);
            this.checkBoxDel.Name = "checkBoxDel";
            this.checkBoxDel.Size = new System.Drawing.Size(102, 17);
            this.checkBoxDel.TabIndex = 23;
            this.checkBoxDel.Text = "Уничтоженные";
            this.checkBoxDel.UseVisualStyleBackColor = true;
            // 
            // checkBoxDem
            // 
            this.checkBoxDem.AutoSize = true;
            this.checkBoxDem.Enabled = false;
            this.checkBoxDem.Location = new System.Drawing.Point(200, 71);
            this.checkBoxDem.Name = "checkBoxDem";
            this.checkBoxDem.Size = new System.Drawing.Size(122, 17);
            this.checkBoxDem.TabIndex = 22;
            this.checkBoxDem.Text = "Демонтированные";
            this.checkBoxDem.UseVisualStyleBackColor = true;
            // 
            // checkBoxUst
            // 
            this.checkBoxUst.AutoSize = true;
            this.checkBoxUst.Enabled = false;
            this.checkBoxUst.Location = new System.Drawing.Point(200, 48);
            this.checkBoxUst.Name = "checkBoxUst";
            this.checkBoxUst.Size = new System.Drawing.Size(107, 17);
            this.checkBoxUst.TabIndex = 21;
            this.checkBoxUst.Text = "Установленные";
            this.checkBoxUst.UseVisualStyleBackColor = true;
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Location = new System.Drawing.Point(178, 25);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(62, 17);
            this.radioButtonOther.TabIndex = 20;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.Text = "Прочие";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            this.radioButtonOther.CheckedChanged += new System.EventHandler(this.radioButtonOther_CheckedChanged);
            // 
            // radioButtonGive
            // 
            this.radioButtonGive.AutoSize = true;
            this.radioButtonGive.Checked = true;
            this.radioButtonGive.Location = new System.Drawing.Point(178, 3);
            this.radioButtonGive.Name = "radioButtonGive";
            this.radioButtonGive.Size = new System.Drawing.Size(78, 17);
            this.radioButtonGive.TabIndex = 19;
            this.radioButtonGive.TabStop = true;
            this.radioButtonGive.Text = "Выданные";
            this.radioButtonGive.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.Location = new System.Drawing.Point(178, 265);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(144, 23);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.groupBoxItog);
            this.groupBox.Controls.Add(this.checkedListBoxType);
            this.groupBox.Controls.Add(this.labelType);
            this.groupBox.Controls.Add(this.labelDateEnd);
            this.groupBox.Controls.Add(this.dateTimePickerBeg);
            this.groupBox.Controls.Add(this.dateTimePickerEnd);
            this.groupBox.Controls.Add(this.labelDateBeg);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(172, 291);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Критерии выборки";
            // 
            // groupBoxItog
            // 
            this.groupBoxItog.Controls.Add(this.radioButtonItog);
            this.groupBoxItog.Controls.Add(this.radioButtonDatail);
            this.groupBoxItog.Location = new System.Drawing.Point(11, 186);
            this.groupBoxItog.Name = "groupBoxItog";
            this.groupBoxItog.Size = new System.Drawing.Size(149, 68);
            this.groupBoxItog.TabIndex = 9;
            this.groupBoxItog.TabStop = false;
            this.groupBoxItog.Visible = false;
            // 
            // radioButtonItog
            // 
            this.radioButtonItog.AutoSize = true;
            this.radioButtonItog.Location = new System.Drawing.Point(6, 42);
            this.radioButtonItog.Name = "radioButtonItog";
            this.radioButtonItog.Size = new System.Drawing.Size(49, 17);
            this.radioButtonItog.TabIndex = 1;
            this.radioButtonItog.Text = "Итог";
            this.radioButtonItog.UseVisualStyleBackColor = true;
            // 
            // radioButtonDatail
            // 
            this.radioButtonDatail.AutoSize = true;
            this.radioButtonDatail.Checked = true;
            this.radioButtonDatail.Location = new System.Drawing.Point(6, 19);
            this.radioButtonDatail.Name = "radioButtonDatail";
            this.radioButtonDatail.Size = new System.Drawing.Size(75, 17);
            this.radioButtonDatail.TabIndex = 0;
            this.radioButtonDatail.TabStop = true;
            this.radioButtonDatail.Text = "Подробно";
            this.radioButtonDatail.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxType
            // 
            this.checkedListBoxType.CheckOnClick = true;
            this.checkedListBoxType.FormattingEnabled = true;
            this.checkedListBoxType.Location = new System.Drawing.Point(11, 131);
            this.checkedListBoxType.Name = "checkedListBoxType";
            this.checkedListBoxType.Size = new System.Drawing.Size(149, 49);
            this.checkedListBoxType.TabIndex = 8;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(8, 115);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(26, 13);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Тип";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(8, 65);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(89, 13);
            this.labelDateEnd.TabIndex = 6;
            this.labelDateEnd.Text = "Дата окончания";
            // 
            // dateTimePickerBeg
            // 
            this.dateTimePickerBeg.Location = new System.Drawing.Point(9, 32);
            this.dateTimePickerBeg.Name = "dateTimePickerBeg";
            this.dateTimePickerBeg.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerBeg.TabIndex = 2;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(11, 81);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerEnd.TabIndex = 3;
            // 
            // labelDateBeg
            // 
            this.labelDateBeg.AutoSize = true;
            this.labelDateBeg.Location = new System.Drawing.Point(6, 16);
            this.labelDateBeg.Name = "labelDateBeg";
            this.labelDateBeg.Size = new System.Drawing.Size(71, 13);
            this.labelDateBeg.TabIndex = 1;
            this.labelDateBeg.Text = "Дата начала";
            // 
            // dsPlomb
            // 
            this.dsPlomb.DataSetName = "DataSetPlomb";
            this.dsPlomb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormPlombs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 291);
            this.Controls.Add(this.splitContainerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPlombs";
            this.Text = "Отчет по пломбам и маркам";
            this.Load += new System.EventHandler(this.FormPlombs_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            this.splitContainerMain.ResumeLayout(false);
            this.toolStripTree.ResumeLayout(false);
            this.toolStripTree.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBoxItog.ResumeLayout(false);
            this.groupBoxItog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlomb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private nsThreeStateTreeview.ThreeStateTreeview treeViewMasters;
        private System.Windows.Forms.ToolStrip toolStripTree;
        private System.Windows.Forms.ToolStripButton toolBtnShowDel;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxGrid;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBoxItog;
        private System.Windows.Forms.RadioButton radioButtonItog;
        private System.Windows.Forms.RadioButton radioButtonDatail;
        private System.Windows.Forms.CheckedListBox checkedListBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeg;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelDateBeg;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.RadioButton radioButtonGive;
        private System.Windows.Forms.Button buttonrReport;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.CheckBox checkBoxFree;
        private System.Windows.Forms.CheckBox checkBoxDel;
        private System.Windows.Forms.CheckBox checkBoxDem;
        private System.Windows.Forms.CheckBox checkBoxUst;
        private Prv.DataSets.DataSetPlomb dsPlomb;
    }
}