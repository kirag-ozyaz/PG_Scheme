    //using Documents.DataSets;
    //using Documents.Properties;
    using FormLbr;
using RequestForRepair.DataSets;
using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

namespace Documents.JournalRequestForRepair
{
    /// <summary>
    /// Привязка заявок к схеме
    /// </summary>

    public class FormLinkRequestAndSchm : FormBase
    {
        private Button buttonAdd;
        private Button buttonDel;
        private Button buttonOk;
        private Button buttonCancel;
        private DateTimePicker dateTimePickerDateEnd;
        private DateTimePicker dateTimePickerDateBeg;
        private Dictionary<int, string> dictionary_0 = new Dictionary<int, string>();
        private GroupBox groupBoxDuration;
        private IContainer icontainer_0=null;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private ListBox listBoxObjects;
        private short short_0;
        private TextBox textBoxDuration;
        private ToolStrip toolStripTreeSubstations;
        private ToolStripButton tooBtnFind;
        private ToolStripButton toolBtnFindNext;
        private ToolStripButton toolBtnFindPrev;
        private ToolStripTextBox toolTxtFind;
        private TreeView treeViewSubstation;
        private TreeView treeViewSubs;

        public FormLinkRequestAndSchm()
        {
            this.InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (TreeNode node in this.treeViewSubstation.Nodes)
            {
                this.method_4(node, list);
            }
            foreach (int num in list)
            {
                if (!this.dictionary_0.ContainsKey(num))
                {
                    string[] textArray1 = new string[] { num.ToString() };
                    this.dictionary_0.Add(num, base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1).ToString());
                }
            }
            this.listBoxObjects.Items.Clear();
            foreach (int num2 in this.dictionary_0.Keys)
            {
                this.listBoxObjects.Items.Add(new Struct9(num2, this.dictionary_0[num2]));
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            foreach (object obj2 in this.listBoxObjects.SelectedItems)
            {
                this.dictionary_0.Remove(((Struct9) obj2).int_0);
            }
            this.listBoxObjects.Items.Clear();
            foreach (int num in this.dictionary_0.Keys)
            {
                this.listBoxObjects.Items.Add(new Struct9(num, this.dictionary_0[num]));
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormLinkRequestAndSchm_Load(object sender, EventArgs e)
        {
            this.Load_SubStation();
            this.listBoxObjects.Items.Clear();
            foreach (int num in this.dictionary_0.Keys)
            {
                this.listBoxObjects.Items.Add(new Struct9(num, this.dictionary_0[num]));
            }
        }
        /// <summary>
        /// Формирование списка подстанций
        /// </summary>
        private void Load_SubStation()
        {
            // DataSetOrder order = new DataSetOrder();
            DataSetN order = new DataSetN();
            base.SelectSqlData(order, order.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name");
            this.treeViewSubstation.BeginUpdate();
            foreach (DataRow row in order.tR_Classifier.Rows)
            {
                TreeNode node = this.treeViewSubstation.Nodes.Add(row["SocrName"].ToString());
                node.Tag = row["id"];
                base.SelectSqlData(order, order.vSchm_ObjList, true, " where typeCodeId = " + row["id"].ToString() + " and deleted = 0 order by name");
                foreach (DataRow row2 in order.vSchm_ObjList)
                {
                    TreeNode node1 = node.Nodes.Add(row2["typeCodeSocr"].ToString() + "-" + row2["Name"].ToString());
                    node1.Tag = row2["id"];
                    node1.Nodes.Add("");
                }
            }
            this.treeViewSubstation.EndUpdate();
        }

        private void Load_Schm_TreeCellLine(TreeNode treeNode_0)
        {
            //DataSetOrder order = new DataSetOrder();
            DataSetN order = new DataSetN();
            base.SelectSqlData(order, order.vSchm_TreeCellLine, true, " where ParentLink = " + treeNode_0.Tag.ToString());
            foreach (DataRow row in order.vSchm_TreeCellLine)
            {
                TreeNode node = treeNode_0.Nodes.Add(row["FullName"].ToString());
                node.Tag = row["id"];
                this.Load_Schm_Relation(node);
                this.Load_Schm_TreeCellLine_1(node);
            }
        }

        private void Load_Schm_Relation(TreeNode treeNode_0)
        {
            //DataSetOrder order = new DataSetOrder();
            DataSetN order = new DataSetN();
            base.SelectSqlData(order, order.tSchm_Relation, true, " where Edge = " + treeNode_0.Tag.ToString());
            if (order.tSchm_Relation.Rows.Count > 0)
            {
                string str = "";
                foreach (DataRow row in order.tSchm_Relation)
                {
                    str = str + row["id"].ToString() + ",";
                }
                base.SelectSqlData(order, order.vSchm_ObjList, true, " where idparent in (" + str.Remove(str.Length - 1) + ") and deleted = 0");
                foreach (DataRow row2 in order.vSchm_ObjList)
                {
                    treeNode_0.Nodes.Add(row2["TypeCodeSocr"].ToString() + " - " + row2["Name"].ToString()).Tag = row2["id"];
                }
            }
        }

        private void Load_Schm_TreeCellLine_1(TreeNode treeNode_0)
        {
            //   DataSetOrder order = new DataSetOrder();
            DataSetN order = new DataSetN();
            base.SelectSqlData(order, order.vSchm_TreeCellLine, true, " where ParentLink = " + treeNode_0.Tag.ToString());
            foreach (DataRow row in order.vSchm_TreeCellLine)
            {
                treeNode_0.Nodes.Add(row["FullName"].ToString()).Tag = row["id"];
            }
        }

        private void method_4(TreeNode treeNode_0, List<int> list_0)
        {
            if ((treeNode_0.Checked && (treeNode_0.Tag != null)) && (treeNode_0.Level > 0))
            {
                list_0.Add(Convert.ToInt32(treeNode_0.Tag));
            }
            foreach (TreeNode node in treeNode_0.Nodes)
            {
                this.method_4(node, list_0);
            }
        }

        private List<TreeNode> method_5(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_0)
        {
            foreach (TreeNode node in treeNodeCollection_0)
            {
                list_0.Add(node);
                list_0 = this.method_5(node.Nodes, list_0);
            }
            return list_0;
        }

        private TreeNode method_6(List<TreeNode> list_0, TreeNode treeNode_0, string string_0, eFind typefind)
        {
            bool flag = typefind == eFind.First;
            if (typefind == eFind.Prev)
            {
                list_0.Reverse();
            }
            foreach (TreeNode node in list_0)
            {
                if (flag && node.Text.ToUpper().Contains(string_0.ToUpper()))
                {
                    return node;
                }
                if (node == treeNode_0)
                {
                    flag = true;
                }
            }
            return null;
        }

        private void InitializeComponent()
        {
            this.treeViewSubstation = new TreeView();
            this.treeViewSubs = new TreeView();
            this.listBoxObjects = new ListBox();
            this.buttonAdd = new Button();
            this.buttonDel = new Button();
            this.buttonOk = new Button();
            this.buttonCancel = new Button();
            this.toolStripTreeSubstations = new ToolStrip();
            this.tooBtnFind = new ToolStripButton();
            this.toolTxtFind = new ToolStripTextBox();
            this.toolBtnFindNext = new ToolStripButton();
            this.toolBtnFindPrev = new ToolStripButton();
            this.label_0 = new Label();
            this.label_1 = new Label();
            this.groupBoxDuration = new GroupBox();
            this.label_4 = new Label();
            this.dateTimePickerDateBeg = new DateTimePicker();
            this.dateTimePickerDateEnd = new DateTimePicker();
            this.label_3 = new Label();
            this.label_2 = new Label();
            this.textBoxDuration = new TextBox();
            this.toolStripTreeSubstations.SuspendLayout();
            this.groupBoxDuration.SuspendLayout();
            base.SuspendLayout();
            this.treeViewSubstation.CheckBoxes = true;
            this.treeViewSubstation.HideSelection = false;
            this.treeViewSubstation.Location = new Point(2, 0x1c);
            this.treeViewSubstation.Name = "treeViewSubstation";
            this.treeViewSubstation.Size = new Size(210, 430);
            this.treeViewSubstation.TabIndex = 0;
            this.treeViewSubstation.BeforeExpand += new TreeViewCancelEventHandler(this.treeViewSubstation_BeforeExpand);
            this.treeViewSubstation.AfterSelect += new TreeViewEventHandler(this.treeViewSubstation_AfterSelect);
            this.treeViewSubs.CheckBoxes = true;
            this.treeViewSubs.Location = new Point(2, 0x102);
            this.treeViewSubs.Name = "treeViewSubs";
            this.treeViewSubs.Size = new Size(210, 200);
            this.treeViewSubs.TabIndex = 1;
            this.listBoxObjects.FormattingEnabled = true;
            this.listBoxObjects.Location = new Point(0x115, 0x19);
            this.listBoxObjects.Name = "listBoxObjects";
            this.listBoxObjects.SelectionMode = SelectionMode.MultiExtended;
            this.listBoxObjects.Size = new Size(0xe8, 0x115);
            this.listBoxObjects.Sorted = true;
            this.listBoxObjects.TabIndex = 2;
            this.buttonAdd.Location = new Point(0xda, 0x1c);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new Size(0x35, 0x17);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = ">>>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new EventHandler(this.buttonAdd_Click);
            this.buttonDel.Location = new Point(0xda, 0x39);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new Size(0x35, 0x17);
            this.buttonDel.TabIndex = 4;
            this.buttonDel.Text = "<<<";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new EventHandler(this.buttonDel_Click);
            this.buttonOk.DialogResult = DialogResult.OK;
            this.buttonOk.Location = new Point(3, 0x1d0);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new Size(0x4b, 0x17);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new EventHandler(this.buttonOk_Click);
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.Location = new Point(0x1b2, 0x1d0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(0x4b, 0x17);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.toolStripTreeSubstations.Dock = DockStyle.None;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.tooBtnFind, this.toolTxtFind, this.toolBtnFindNext, this.toolBtnFindPrev };
            this.toolStripTreeSubstations.Items.AddRange(toolStripItems);
            this.toolStripTreeSubstations.Location = new Point(3, 0);
            this.toolStripTreeSubstations.Name = "toolStrip1";
            this.toolStripTreeSubstations.Size = new Size(0xb7, 0x19);
            this.toolStripTreeSubstations.TabIndex = 7;
            this.toolStripTreeSubstations.Text = "toolStripTreeSubstations";
            this.tooBtnFind.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tooBtnFind.Image = global::RequestForRepair.Properties.Resources.Find;
            this.tooBtnFind.ImageTransparentColor = Color.Magenta;
            this.tooBtnFind.Name = "tooBtnFind";
            this.tooBtnFind.Size = new Size(0x17, 0x16);
            this.tooBtnFind.Text = "toolStripButton1";
            this.tooBtnFind.Click += new EventHandler(this.tooBtnFind_Click);
            this.toolTxtFind.Name = "toolTxtFind";
            this.toolTxtFind.Size = new Size(100, 0x19);
            this.toolTxtFind.KeyDown += new KeyEventHandler(this.toolTxtFind_KeyDown);
            this.toolBtnFindNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNext.Image = global::RequestForRepair.Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new Size(0x17, 0x16);
            this.toolBtnFindNext.Text = "toolStripButton1";
            this.toolBtnFindNext.Click += new EventHandler(this.toolBtnFindNext_Click);
            this.toolBtnFindPrev.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrev.Image = global::RequestForRepair.Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new Size(0x17, 0x16);
            this.toolBtnFindPrev.Text = "toolStripButton2";
            this.toolBtnFindPrev.Click += new EventHandler(this.toolBtnFindPrev_Click);
            this.label_0.AutoSize = true;
            this.label_0.Location = new Point(12, 0xf2);
            this.label_0.Name = "label1";
            this.label_0.Size = new Size(0x73, 13);
            this.label_0.TabIndex = 8;
            this.label_0.Text = "Объекты подстанции";
            this.label_1.AutoSize = true;
            this.label_1.Location = new Point(0x112, 12);
            this.label_1.Name = "label2";
            this.label_1.Size = new Size(0x7c, 13);
            this.label_1.TabIndex = 9;
            this.label_1.Text = "Привязанные объекты";
            this.groupBoxDuration.Controls.Add(this.textBoxDuration);
            this.groupBoxDuration.Controls.Add(this.label_2);
            this.groupBoxDuration.Controls.Add(this.dateTimePickerDateEnd);
            this.groupBoxDuration.Controls.Add(this.label_3);
            this.groupBoxDuration.Controls.Add(this.dateTimePickerDateBeg);
            this.groupBoxDuration.Controls.Add(this.label_4);
            this.groupBoxDuration.Location = new Point(0x115, 0x134);
            this.groupBoxDuration.Name = "groupBoxDuration";
            this.groupBoxDuration.Size = new Size(0xe8, 150);
            this.groupBoxDuration.TabIndex = 10;
            this.groupBoxDuration.TabStop = false;
            this.groupBoxDuration.Text = "Период";
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(6, 0x10);
            this.label_4.Name = "label3";
            this.label_4.Size = new Size(0x47, 13);
            this.label_4.TabIndex = 0;
            this.label_4.Text = "Дата начала";
            this.dateTimePickerDateBeg.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerDateBeg.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerDateBeg.Location = new Point(9, 0x20);
            this.dateTimePickerDateBeg.Name = "dateTimePickerDateBeg";
            this.dateTimePickerDateBeg.Size = new Size(0xd9, 20);
            this.dateTimePickerDateBeg.TabIndex = 1;
            this.dateTimePickerDateEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerDateEnd.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerDateEnd.Location = new Point(9, 0x47);
            this.dateTimePickerDateEnd.Name = "dateTimePickerDateEnd";
            this.dateTimePickerDateEnd.Size = new Size(0xd9, 20);
            this.dateTimePickerDateEnd.TabIndex = 3;
            this.label_3.AutoSize = true;
            this.label_3.Location = new Point(6, 0x37);
            this.label_3.Name = "label4";
            this.label_3.Size = new Size(0x47, 13);
            this.label_3.TabIndex = 2;
            this.label_3.Text = "Дата начала";
            this.label_2.AutoSize = true;
            this.label_2.Location = new Point(6, 0x5e);
            this.label_2.Name = "label5";
            this.label_2.Size = new Size(80, 13);
            this.label_2.TabIndex = 4;
            this.label_2.Text = "Длительность";
            this.textBoxDuration.Location = new Point(9, 110);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new Size(0xd9, 20);
            this.textBoxDuration.TabIndex = 5;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.buttonCancel;
            base.ClientSize = new Size(0x209, 0x1ef);
            base.Controls.Add(this.groupBoxDuration);
            base.Controls.Add(this.treeViewSubstation);
            base.Controls.Add(this.label_1);
            base.Controls.Add(this.label_0);
            base.Controls.Add(this.toolStripTreeSubstations);
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
            this.toolStripTreeSubstations.ResumeLayout(false);
            this.toolStripTreeSubstations.PerformLayout();
            this.groupBoxDuration.ResumeLayout(false);
            this.groupBoxDuration.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void tooBtnFind_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.method_5(this.treeViewSubstation.Nodes, list);
            TreeNode node = this.method_6(list, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, eFind.First);
            if (node != null)
            {
                this.treeViewSubstation.SelectedNode = node;
                this.treeViewSubstation.SelectedNode.Expand();
            }
        }

        private void toolBtnFindNext_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.method_5(this.treeViewSubstation.Nodes, list);
            TreeNode node = this.method_6(list, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, eFind.Next);
            if (node != null)
            {
                this.treeViewSubstation.SelectedNode = node;
                this.treeViewSubstation.SelectedNode.Expand();
            }
        }

        private void toolBtnFindPrev_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.method_5(this.treeViewSubstation.Nodes, list);
            TreeNode node = this.method_6(list, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, eFind.Prev);
            if (node != null)
            {
                this.treeViewSubstation.SelectedNode = node;
                this.treeViewSubstation.SelectedNode.Expand();
            }
        }

        private void toolTxtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (e.Modifiers)
                {
                    case Keys.None:
                        this.toolBtnFindNext_Click(sender, e);
                        break;

                    case Keys.Shift:
                        this.toolBtnFindPrev_Click(sender, e);
                        break;
                }
            }
        }

        private void treeViewSubstation_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void treeViewSubstation_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if ((e.Node.Nodes.Count > 0) && (e.Node.Level > 0))
            {
                // DataSetOrder order;
                DataSetN order;
                string str;
                e.Node.Nodes.Clear();
                switch (e.Node.Level)
                {
                    case 1:
                        order = new DataSetN();//DataSetOrder();
                        base.SelectSqlData(order, order.tR_Classifier, true, " where ParentKey like ';SCM;BUS;%' and deleted = 0 and isgroup = 0 ");
                        str = "";
                        foreach (DataRow row in order.tR_Classifier.Rows)
                        {
                            str = str + row["id"].ToString() + ",";
                        }
                        str = str.Remove(str.Length - 1);
                        base.SelectSqlData(order, order.vSchm_ObjList, true, " where idParent = " + e.Node.Tag.ToString() + " and typecodeId in (" + str + ") and deleted = 0");
                        foreach (DataRow row2 in order.vSchm_ObjList)
                        {
                            TreeNode node1 = e.Node.Nodes.Add(row2["TypeCodeSocr"].ToString() + " - " + row2["Name"].ToString());
                            node1.Tag = row2["id"];
                            node1.Nodes.Add("");
                        }
                        return;

                    case 2:
                        // order = new DataSetOrder();
                        order = new DataSetN();
                        base.SelectSqlData(order, order.vSchm_TreeCellLine, true, " where ParentLink = " + e.Node.Tag.ToString());
                        foreach (DataRow row3 in order.vSchm_TreeCellLine)
                        {
                            TreeNode node2 = e.Node.Nodes.Add(row3["FullName"].ToString());
                            node2.Tag = row3["id"];
                            node2.Nodes.Add("");
                        }
                        return;

                    case 3:
                        //order = new DataSetOrder();
                        order = new DataSetN();
                        base.SelectSqlData(order, order.tSchm_Relation, true, " where Edge = " + e.Node.Tag.ToString());
                        if (order.tSchm_Relation.Rows.Count > 0)
                        {
                            str = "";
                            foreach (DataRow row4 in order.tSchm_Relation)
                            {
                                str = str + row4["id"].ToString() + ",";
                            }
                            base.SelectSqlData(order, order.vSchm_ObjList, true, " where idparent in (" + str.Remove(str.Length - 1) + ") and deleted = 0");
                            foreach (DataRow row5 in order.vSchm_ObjList)
                            {
                                e.Node.Nodes.Add(row5["TypeCodeSocr"].ToString() + " - " + row5["Name"].ToString()).Tag = row5["id"];
                            }
                        }
                        //order = new DataSetOrder();
                        order = new DataSetN();
                        base.SelectSqlData(order, order.vSchm_TreeCellLine, true, " where ParentLink = " + e.Node.Tag.ToString());
                        foreach (DataRow row6 in order.vSchm_TreeCellLine)
                        {
                            e.Node.Nodes.Add(row6["FullName"].ToString()).Tag = row6["id"];
                        }
                        return;
                }
            }
        }

        public DateTime DateBeg
        {
            get
            {
                return this.dateTimePickerDateBeg.Value;
            }
            set
            {
                this.dateTimePickerDateBeg.Value = value;
            }
        }

        public DateTime DateEnd
        {
            get
            {
                return this.dateTimePickerDateEnd.Value;
            }
            set
            {
                this.dateTimePickerDateEnd.Value = value;
            }
        }

        public string Duration
        {
            get
            {
                return this.textBoxDuration.Text;
            }
            set
            {
                this.textBoxDuration.Text = value;
            }
        }

        public Dictionary<int, string> LinkObjects
        {
            get
            {
                return this.dictionary_0;
            }
            set
            {
                this.dictionary_0 = value;
            }
        }

        public short Num
        {
            get
            {
                return this.short_0;
            }
            set
            {
                this.short_0 = value;
            }
        }

        private enum eFind
        {
            First,
            Next,
            Prev
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Struct9
        {
            public string string_0;
            public int int_0;
            public Struct9(int int_1, string string_1)
            {
                this.string_0 = string_1;
                this.int_0 = int_1;
            }

            public override string ToString()
            {
                return this.string_0;
            }
        }
    }
}

