namespace Documents.Forms.Scheme
{
    using Documents.DataSets;
    using Documents.Properties;
    using FormLbr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class FormLinkAbnObjAndSchm : FormBase
    {
        private Button button_0;
        private Button button_1;
        private Button button_2;
        private Button button_3;
        private CheckBox checkBox_0;
        private Dictionary<int, string> dictionary_0 = new Dictionary<int, string>();
        private IContainer icontainer_0;
        private Label label_0;
        private Label label_1;
        private ListBox listBox_0;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripTextBox toolStripTextBox_0;
        private TreeView treeView_0;
        private TreeView treeView_1;

        public FormLinkAbnObjAndSchm()
        {
            this.method_4();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (TreeNode node in this.treeView_0.Nodes)
            {
                this.method_1(node, list);
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
                this.listBox_0.Items.Add(new Struct8(num2, this.dictionary_0[num2]));
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            foreach (object obj2 in this.listBox_0.SelectedItems)
            {
                this.dictionary_0.Remove(((Struct8) obj2).int_0);
            }
            this.listBox_0.Items.Clear();
            foreach (int num in this.dictionary_0.Keys)
            {
                this.listBox_0.Items.Add(new Struct8(num, this.dictionary_0[num]));
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private void checkBox_0_CheckedChanged(object sender, EventArgs e)
        {
            this.method_0();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormLinkAbnObjAndSchm_Load(object sender, EventArgs e)
        {
            this.method_0();
            this.listBox_0.Items.Clear();
            foreach (int num in this.dictionary_0.Keys)
            {
                this.listBox_0.Items.Add(new Struct8(num, this.dictionary_0[num]));
            }
        }

        private void method_0()
        {
            DataSetGES tges = new DataSetGES();
            base.SelectSqlData(tges, tges.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name");
            this.treeView_0.BeginUpdate();
            this.treeView_0.Nodes.Clear();
            foreach (DataRow row in tges.tR_Classifier.Rows)
            {
                TreeNode node = this.treeView_0.Nodes.Add(row["SocrName"].ToString());
                node.Tag = row["id"];
                base.SelectSqlData(tges, tges.vSchm_ObjList, true, " where typeCodeId = " + row["id"].ToString() + " and deleted = 0 order by name");
                foreach (DataRow row2 in tges.vSchm_ObjList)
                {
                    TreeNode node1 = node.Nodes.Add(row2["typeCodeSocr"].ToString() + "-" + row2["Name"].ToString());
                    node1.Tag = row2["id"];
                    node1.Nodes.Add("");
                }
            }
            this.treeView_0.EndUpdate();
        }

        private void method_1(TreeNode treeNode_0, List<int> list_0)
        {
            if ((treeNode_0.Checked && (treeNode_0.Tag != null)) && (treeNode_0.Level > 0))
            {
                if (treeNode_0.Tag is int)
                {
                    list_0.Add(Convert.ToInt32(treeNode_0.Tag));
                }
                if (treeNode_0.Tag is List<int>)
                {
                    list_0.Add(((List<int>) treeNode_0.Tag)[0]);
                }
            }
            foreach (TreeNode node in treeNode_0.Nodes)
            {
                this.method_1(node, list_0);
            }
        }

        private List<TreeNode> method_2(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_0)
        {
            foreach (TreeNode node in treeNodeCollection_0)
            {
                list_0.Add(node);
                list_0 = this.method_2(node.Nodes, list_0);
            }
            return list_0;
        }

        private TreeNode method_3(List<TreeNode> list_0, TreeNode treeNode_0, string string_0, Enum22 enum22_0)
        {
            bool flag = enum22_0 == Enum22.const_0;
            if (enum22_0 == Enum22.const_2)
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

        private void method_4()
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
            this.checkBox_0 = new CheckBox();
            this.toolStrip_0.SuspendLayout();
            base.SuspendLayout();
            this.treeView_0.CheckBoxes = true;
            this.treeView_0.HideSelection = false;
            this.treeView_0.Location = new Point(2, 0x1c);
            this.treeView_0.Name = "treeViewSubstation";
            this.treeView_0.Size = new Size(210, 0x194);
            this.treeView_0.TabIndex = 0;
            this.treeView_0.BeforeExpand += new TreeViewCancelEventHandler(this.treeView_0_BeforeExpand);
            this.treeView_1.CheckBoxes = true;
            this.treeView_1.Location = new Point(2, 0x102);
            this.treeView_1.Name = "treeViewSubs";
            this.treeView_1.Size = new Size(210, 0xae);
            this.treeView_1.TabIndex = 1;
            this.listBox_0.FormattingEnabled = true;
            this.listBox_0.Location = new Point(0x115, 0x19);
            this.listBox_0.Name = "listBoxObjects";
            this.listBox_0.SelectionMode = SelectionMode.MultiExtended;
            this.listBox_0.Size = new Size(0xe8, 0x197);
            this.listBox_0.Sorted = true;
            this.listBox_0.TabIndex = 2;
            this.button_0.Location = new Point(0xda, 180);
            this.button_0.Name = "buttonAdd";
            this.button_0.Size = new Size(0x35, 0x17);
            this.button_0.TabIndex = 3;
            this.button_0.Text = ">>>";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new EventHandler(this.button_0_Click);
            this.button_1.Location = new Point(0xda, 0x117);
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
            this.checkBox_0.AutoSize = true;
            this.checkBox_0.Checked = true;
            this.checkBox_0.CheckState = CheckState.Checked;
            this.checkBox_0.Location = new Point(3, 0x1b9);
            this.checkBox_0.Name = "checkBoxUseBusParent";
            this.checkBox_0.Size = new Size(0x6d, 0x11);
            this.checkBox_0.TabIndex = 10;
            this.checkBox_0.Text = "Основные шины";
            this.checkBox_0.UseVisualStyleBackColor = true;
            this.checkBox_0.CheckedChanged += new EventHandler(this.checkBox_0_CheckedChanged);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.button_3;
            base.ClientSize = new Size(0x209, 0x1f6);
            base.Controls.Add(this.checkBox_0);
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
            base.Name = "FormLinkAbnObjAndSchm";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Привязка объекта к схеме";
            base.Load += new EventHandler(this.FormLinkAbnObjAndSchm_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.method_2(this.treeView_0.Nodes, list);
            TreeNode node = this.method_3(list, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, Enum22.const_0);
            if (node != null)
            {
                this.treeView_0.SelectedNode = node;
                this.treeView_0.SelectedNode.Expand();
            }
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.method_2(this.treeView_0.Nodes, list);
            TreeNode node = this.method_3(list, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, Enum22.const_1);
            if (node != null)
            {
                this.treeView_0.SelectedNode = node;
                this.treeView_0.SelectedNode.Expand();
            }
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            List<TreeNode> list = new List<TreeNode>();
            list = this.method_2(this.treeView_0.Nodes, list);
            TreeNode node = this.method_3(list, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, Enum22.const_2);
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

        private void treeView_0_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if ((e.Node.Nodes.Count > 0) && (e.Node.Level > 0))
            {
                e.Node.Nodes.Clear();
                int level = e.Node.Level;
                switch (level)
                {
                    case 1:
                    {
                        DataSetGES tges = new DataSetGES();
                        base.SelectSqlData(tges, tges.tR_Classifier, true, " where ParentKey like ';SCM;BUS;%' and deleted = 0 and isgroup = 0 ");
                        string str = "";
                        foreach (DataRow row in tges.tR_Classifier.Rows)
                        {
                            str = str + row["id"].ToString() + ",";
                        }
                        str = str.Remove(str.Length - 1);
                        base.SelectSqlData(tges, tges.vSchm_ObjList, true, " where idParent = " + e.Node.Tag.ToString() + " and typecodeId in (" + str + ") and deleted = 0");
                        if (!this.checkBox_0.Checked)
                        {
                            foreach (DataRow row2 in tges.vSchm_ObjList)
                            {
                                TreeNode node1 = e.Node.Nodes.Add(row2["TypeCodeSocr"].ToString() + " - " + row2["Name"].ToString());
                                node1.Tag = row2["id"];
                                node1.Nodes.Add("");
                            }
                        }
                        else
                        {
                            DataTable table1 = base.SelectSqlData("tSchm_ObjList", true, " where idParent = " + e.Node.Tag.ToString() + " and typecodeId in (" + str + ") and deleted = 0");
                            DataRow[] rowArray = table1.Select("Tag is null");
                            DataRow[] source = table1.Select("Tag is not null");
                            DataRow[] rowArray3 = rowArray;
                            for (level = 0; level < rowArray3.Length; level++)
                            {
                                Class294 class2 = new Class294 {
                                    dataRow_0 = rowArray3[level]
                                };
                                DataRow[] rowArray4 = tges.vSchm_ObjList.Select("id = " + class2.dataRow_0["id"].ToString());
                                TreeNode node = e.Node.Nodes.Add(rowArray4[0]["TypeCodeSocr"].ToString() + " - " + rowArray4[0]["Name"].ToString());
                                node.Tag = Convert.ToInt32(class2.dataRow_0["id"]);
                                foreach (DataRow row3 in source.Where<DataRow>(new Func<DataRow, bool>(class2.method_0)))
                                {
                                    if (node.Tag is int)
                                    {
                                        List<int> list = new List<int> {
                                            Convert.ToInt32(node.Tag),
                                            Convert.ToInt32(row3["id"])
                                        };
                                        node.Tag = list;
                                    }
                                    else if (node.Tag is List<int>)
                                    {
                                        List<int> tag = (List<int>) node.Tag;
                                        tag.Add(Convert.ToInt32(row3["id"]));
                                        node.Tag = tag;
                                    }
                                    row3["Tag"] = DBNull.Value;
                                }
                                node.Nodes.Add("");
                            }
                            foreach (DataRow row4 in source.Where<DataRow>(<>c.<>9__7_1 ?? (<>c.<>9__7_1 = new Func<DataRow, bool>(<>c.<>9.method_0))))
                            {
                                DataRow[] rowArray5 = tges.vSchm_ObjList.Select("id = " + row4["id"].ToString());
                                TreeNode node2 = e.Node.Nodes.Add(rowArray5[0]["TypeCodeSocr"].ToString() + " - " + rowArray5[0]["Name"].ToString());
                                node2.Tag = Convert.ToInt32(row4["id"]);
                                node2.Nodes.Add("");
                            }
                        }
                        break;
                    }
                }
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

        [Serializable, CompilerGenerated]
        private sealed class <>c
        {
            public static readonly FormLinkAbnObjAndSchm.<>c <>9 = new FormLinkAbnObjAndSchm.<>c();
            public static Func<DataRow, bool> <>9__7_1;

            internal bool method_0(DataRow dataRow_0)
            {
                return (dataRow_0["Tag"] != DBNull.Value);
            }
        }

        [CompilerGenerated]
        private sealed class Class294
        {
            public DataRow dataRow_0;

            internal bool method_0(DataRow dataRow_1)
            {
                return ((dataRow_1["Tag"] != DBNull.Value) && (Convert.ToInt32(dataRow_1["Tag"]) == Convert.ToInt32(this.dataRow_0["id"])));
            }
        }

        private enum Enum22
        {
            const_0,
            const_1,
            const_2
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Struct8
        {
            public string string_0;
            public int int_0;
            public Struct8(int int_1, string string_1)
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

