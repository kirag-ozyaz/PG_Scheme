    using Documents.DataSets;
    using Documents.Properties;
    using FormLbr;
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
        private Button button_0;
        private Button button_1;
        private Button button_2;
        private Button button_3;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private Dictionary<int, string> dictionary_0 = new Dictionary<int, string>();
        private GroupBox groupBox_0;
        private IContainer icontainer_0;
        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label label_3;
        private Label label_4;
        private ListBox listBox_0;
        private short short_0;
        private TextBox textBox_0;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripTextBox toolStripTextBox_0;
        private TreeView treeView_0;
        private TreeView treeView_1;

        public FormLinkRequestAndSchm()
        {
            this.method_7();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (TreeNode node in this.treeView_0.Nodes)
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
            this.listBox_0.Items.Clear();
            foreach (int num2 in this.dictionary_0.Keys)
            {
                this.listBox_0.Items.Add(new Struct9(num2, this.dictionary_0[num2]));
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            foreach (object obj2 in this.listBox_0.SelectedItems)
            {
                this.dictionary_0.Remove(((Struct9) obj2).int_0);
            }
            this.listBox_0.Items.Clear();
            foreach (int num in this.dictionary_0.Keys)
            {
                this.listBox_0.Items.Add(new Struct9(num, this.dictionary_0[num]));
            }
        }

        private void button_2_Click(object sender, EventArgs e)
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
            this.method_0();
            this.listBox_0.Items.Clear();
            foreach (int num in this.dictionary_0.Keys)
            {
                this.listBox_0.Items.Add(new Struct9(num, this.dictionary_0[num]));
            }
        }

        private void method_0()
        {
            DataSetOrder order = new DataSetOrder();
            base.SelectSqlData(order, order.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name");
            this.treeView_0.BeginUpdate();
            foreach (DataRow row in order.tR_Classifier.Rows)
            {
                TreeNode node = this.treeView_0.Nodes.Add(row["SocrName"].ToString());
                node.Tag = row["id"];
                base.SelectSqlData(order, order.vSchm_ObjList, true, " where typeCodeId = " + row["id"].ToString() + " and deleted = 0 order by name");
                foreach (DataRow row2 in order.vSchm_ObjList)
                {
                    TreeNode node1 = node.Nodes.Add(row2["typeCodeSocr"].ToString() + "-" + row2["Name"].ToString());
                    node1.Tag = row2["id"];
                    node1.Nodes.Add("");
                }
            }
            this.treeView_0.EndUpdate();
        }

        private void method_1(TreeNode treeNode_0)
        {
            DataSetOrder order = new DataSetOrder();
            base.SelectSqlData(order, order.vSchm_TreeCellLine, true, " where ParentLink = " + treeNode_0.Tag.ToString());
            foreach (DataRow row in order.vSchm_TreeCellLine)
            {
                TreeNode node = treeNode_0.Nodes.Add(row["FullName"].ToString());
                node.Tag = row["id"];
                this.method_2(node);
                this.method_3(node);
            }
        }

        private void method_2(TreeNode treeNode_0)
        {
            DataSetOrder order = new DataSetOrder();
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

        private void method_3(TreeNode treeNode_0)
        {
            DataSetOrder order = new DataSetOrder();
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

        private TreeNode method_6(List<TreeNode> list_0, TreeNode treeNode_0, string string_0, Enum24 enum24_0)
        {
            bool flag = enum24_0 == Enum24.const_0;
            if (enum24_0 == Enum24.const_2)
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

        private void method_7()
        {
            this.treeView_0 = new TreeView();
            this.treeView_1 = new TreeView();
            this.listBox_0 = new ListBox();
            this.button_0 = new Button();
            this.button_1 = new Button();
            this.button_2 = new Button();
            this.button_3 = new Button();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.label_0 = new Label();
            this.label_1 = new Label();
            this.groupBox_0 = new GroupBox();
            this.label_4 = new Label();
            this.dateTimePicker_1 = new DateTimePicker();
            this.dateTimePicker_0 = new DateTimePicker();
            this.label_3 = new Label();
            this.label_2 = new Label();
            this.textBox_0 = new TextBox();
            this.toolStrip_0.SuspendLayout();
            this.groupBox_0.SuspendLayout();
            base.SuspendLayout();
            this.treeView_0.CheckBoxes = true;
            this.treeView_0.HideSelection = false;
            this.treeView_0.Location = new Point(2, 0x1c);
            this.treeView_0.Name = "treeViewSubstation";
            this.treeView_0.Size = new Size(210, 430);
            this.treeView_0.TabIndex = 0;
            this.treeView_0.BeforeExpand += new TreeViewCancelEventHandler(this.treeView_0_BeforeExpand);
            this.treeView_0.AfterSelect += new TreeViewEventHandler(this.treeView_0_AfterSelect);
            this.treeView_1.CheckBoxes = true;
            this.treeView_1.Location = new Point(2, 0x102);
            this.treeView_1.Name = "treeViewSubs";
            this.treeView_1.Size = new Size(210, 200);
            this.treeView_1.TabIndex = 1;
            this.listBox_0.FormattingEnabled = true;
            this.listBox_0.Location = new Point(0x115, 0x19);
            this.listBox_0.Name = "listBoxObjects";
            this.listBox_0.SelectionMode = SelectionMode.MultiExtended;
            this.listBox_0.Size = new Size(0xe8, 0x115);
            this.listBox_0.Sorted = true;
            this.listBox_0.TabIndex = 2;
            this.button_0.Location = new Point(0xda, 0x1c);
            this.button_0.Name = "buttonAdd";
            this.button_0.Size = new Size(0x35, 0x17);
            this.button_0.TabIndex = 3;
            this.button_0.Text = ">>>";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.button_1.Location = new Point(0xda, 0x39);
            this.button_1.Name = "buttonDel";
            this.button_1.Size = new Size(0x35, 0x17);
            this.button_1.TabIndex = 4;
            this.button_1.Text = "<<<";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new EventHandler(this.button_1_Click);
            this.button_2.DialogResult = DialogResult.OK;
            this.button_2.Location = new Point(3, 0x1d0);
            this.button_2.Name = "buttonOk";
            this.button_2.Size = new Size(0x4b, 0x17);
            this.button_2.TabIndex = 5;
            this.button_2.Text = "OK";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new EventHandler(this.button_2_Click);
            this.button_3.DialogResult = DialogResult.Cancel;
            this.button_3.Location = new Point(0x1b2, 0x1d0);
            this.button_3.Name = "buttonCancel";
            this.button_3.Size = new Size(0x4b, 0x17);
            this.button_3.TabIndex = 6;
            this.button_3.Text = "Отмена";
            this.button_3.UseVisualStyleBackColor = true;
            this.toolStrip_0.Dock = DockStyle.None;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripTextBox_0, this.toolStripButton_1, this.toolStripButton_2 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(3, 0);
            this.toolStrip_0.Name = "toolStrip1";
            this.toolStrip_0.Size = new Size(0xb7, 0x19);
            this.toolStrip_0.TabIndex = 7;
            this.toolStrip_0.Text = "toolStripTreeSubstations";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.Find;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "tooBtnFind";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "toolStripButton1";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripTextBox_0.Name = "toolTxtFind";
            this.toolStripTextBox_0.Size = new Size(100, 0x19);
            this.toolStripTextBox_0.KeyDown += new KeyEventHandler(this.toolStripTextBox_0_KeyDown);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.FindNext;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolBtnFindNext";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "toolStripButton1";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.FindPrev;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolBtnFindPrev";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "toolStripButton2";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
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
            this.groupBox_0.Controls.Add(this.textBox_0);
            this.groupBox_0.Controls.Add(this.label_2);
            this.groupBox_0.Controls.Add(this.dateTimePicker_0);
            this.groupBox_0.Controls.Add(this.label_3);
            this.groupBox_0.Controls.Add(this.dateTimePicker_1);
            this.groupBox_0.Controls.Add(this.label_4);
            this.groupBox_0.Location = new Point(0x115, 0x134);
            this.groupBox_0.Name = "groupBoxDuration";
            this.groupBox_0.Size = new Size(0xe8, 150);
            this.groupBox_0.TabIndex = 10;
            this.groupBox_0.TabStop = false;
            this.groupBox_0.Text = "Период";
            this.label_4.AutoSize = true;
            this.label_4.Location = new Point(6, 0x10);
            this.label_4.Name = "label3";
            this.label_4.Size = new Size(0x47, 13);
            this.label_4.TabIndex = 0;
            this.label_4.Text = "Дата начала";
            this.dateTimePicker_1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker_1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker_1.Location = new Point(9, 0x20);
            this.dateTimePicker_1.Name = "dateTimePickerDateBeg";
            this.dateTimePicker_1.Size = new Size(0xd9, 20);
            this.dateTimePicker_1.TabIndex = 1;
            this.dateTimePicker_0.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker_0.Location = new Point(9, 0x47);
            this.dateTimePicker_0.Name = "dateTimePickerDateEnd";
            this.dateTimePicker_0.Size = new Size(0xd9, 20);
            this.dateTimePicker_0.TabIndex = 3;
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
            this.textBox_0.Location = new Point(9, 110);
            this.textBox_0.Name = "textBoxDuration";
            this.textBox_0.Size = new Size(0xd9, 20);
            this.textBox_0.TabIndex = 5;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.button_3;
            base.ClientSize = new Size(0x209, 0x1ef);
            base.Controls.Add(this.groupBox_0);
            base.Controls.Add(this.treeView_0);
            base.Controls.Add(this.label_1);
            base.Controls.Add(this.label_0);
            base.Controls.Add(this.toolStrip_0);
            base.Controls.Add(this.button_3);
            base.Controls.Add(this.button_2);
            base.Controls.Add(this.button_1);
            base.Controls.Add(this.button_0);
            base.Controls.Add(this.listBox_0);
            base.Controls.Add(this.treeView_1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Name = "FormLinkRequestAndSchm";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Привязка заявок к схеме";
            base.Load += new EventHandler(this.FormLinkRequestAndSchm_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.groupBox_0.ResumeLayout(false);
            this.groupBox_0.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.method_5(this.treeView_0.Nodes, list);
            TreeNode node = this.method_6(list, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, Enum24.const_0);
            if (node != null)
            {
                this.treeView_0.SelectedNode = node;
                this.treeView_0.SelectedNode.Expand();
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.method_5(this.treeView_0.Nodes, list);
            TreeNode node = this.method_6(list, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, Enum24.const_1);
            if (node != null)
            {
                this.treeView_0.SelectedNode = node;
                this.treeView_0.SelectedNode.Expand();
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.method_5(this.treeView_0.Nodes, list);
            TreeNode node = this.method_6(list, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, Enum24.const_2);
            if (node != null)
            {
                this.treeView_0.SelectedNode = node;
                this.treeView_0.SelectedNode.Expand();
            }
        }

        private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (e.Modifiers)
                {
                    case Keys.None:
                        this.toolStripButton_1_Click(sender, e);
                        break;

                    case Keys.Shift:
                        this.toolStripButton_2_Click(sender, e);
                        break;
                }
            }
        }

        private void treeView_0_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void treeView_0_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if ((e.Node.Nodes.Count > 0) && (e.Node.Level > 0))
            {
                DataSetOrder order;
                string str;
                e.Node.Nodes.Clear();
                switch (e.Node.Level)
                {
                    case 1:
                        order = new DataSetOrder();
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
                        order = new DataSetOrder();
                        base.SelectSqlData(order, order.vSchm_TreeCellLine, true, " where ParentLink = " + e.Node.Tag.ToString());
                        foreach (DataRow row3 in order.vSchm_TreeCellLine)
                        {
                            TreeNode node2 = e.Node.Nodes.Add(row3["FullName"].ToString());
                            node2.Tag = row3["id"];
                            node2.Nodes.Add("");
                        }
                        return;

                    case 3:
                        order = new DataSetOrder();
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
                        order = new DataSetOrder();
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
                return this.dateTimePicker_1.Value;
            }
            set
            {
                this.dateTimePicker_1.Value = value;
            }
        }

        public DateTime DateEnd
        {
            get
            {
                return this.dateTimePicker_0.Value;
            }
            set
            {
                this.dateTimePicker_0.Value = value;
            }
        }

        public string Duration
        {
            get
            {
                return this.textBox_0.Text;
            }
            set
            {
                this.textBox_0.Text = value;
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

        private enum Enum24
        {
            const_0,
            const_1,
            const_2
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

