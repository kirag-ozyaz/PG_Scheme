//using Documents.DataSets;
//using Documents.Properties;
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
/// <summary>
/// Привязка объекта к схеме
/// NS039/c00015b
/// c00003a
/// </summary>
internal class FormSelectSchmObj : FormBase
{
    private bool bool_0;
    private Button buttonOk;
    private Button buttonCancel;
    private CheckBox checkBoxUseBusParent;
    private Dictionary<int, string> dictionary_0 = new Dictionary<int, string>();
    private IContainer components = null;
    private Label label_0;
    private ToolStrip toolStrip1;
    private ToolStripButton tooBtnFind;
    private ToolStripButton toolBtnFindNext;
    private ToolStripButton toolBtnFindPrev;
    private ToolStripTextBox toolTxtFind;
    private System.Windows.Forms.TreeView treeViewSubstation;

    internal FormSelectSchmObj()
    {
        this.InitializeComponent();
        //dictionary_0 = new Dictionary<int, string>();
    }

    private void buttonOk_Click(object sender, EventArgs e)
    {
        base.DialogResult = DialogResult.OK;
        this.dictionary_0.Clear();
        if (this.method_2())
        {
            List<int> list = new List<int>();
            foreach (TreeNode node in this.treeViewSubstation.Nodes)
            {
                this.GetListChecked(node, list);
            }
            foreach (int num in list)
            {
                if (!this.dictionary_0.ContainsKey(num))
                {
                    string[] textArray1 = new string[] { num.ToString() };
                    this.dictionary_0.Add(num, base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1).ToString());
                }
            }
        }
        else if (((this.treeViewSubstation.SelectedNode != null) && (this.treeViewSubstation.SelectedNode.Tag != null)) && (this.treeViewSubstation.SelectedNode.Level > 0))
        {
            List<int> list2 = new List<int>();
            if (this.treeViewSubstation.SelectedNode.Tag is int)
            {
                list2.Add(Convert.ToInt32(this.treeViewSubstation.SelectedNode.Tag));
            }
            if (this.treeViewSubstation.SelectedNode.Tag is List<int>)
            {
                list2.Add(((List<int>) this.treeViewSubstation.SelectedNode.Tag)[0]);
            }
            foreach (int num2 in list2)
            {
                if (!this.dictionary_0.ContainsKey(num2))
                {
                    string[] textArray2 = new string[] { num2.ToString() };
                    this.dictionary_0.Add(num2, base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray2).ToString());
                }
            }
        }
        base.Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        base.Close();
    }

    private void checkBoxUseBusParent_CheckedChanged(object sender, EventArgs e)
    {
        this.LoadTree();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void FormSelectSchmObj_Load(object sender, EventArgs e)
    {
        this.LoadTree();
    }
    /// <summary>
    /// Get
    /// </summary>
    internal Dictionary<int, string> method_0()
    {
        return this.dictionary_0;
    }
    /// <summary>
    /// Set
    /// </summary>
    internal void method_1(Dictionary<int, string> dictionary_1)
    {
        this.dictionary_0 = dictionary_1;
    }
    //internal Dictionary<int, string> dictionary_0
    //{
    //    get;set;
    //}



    internal bool method_2()
    {
        return this.bool_0;
    }

    internal void method_3(bool bool_1)
    {
        this.bool_0 = bool_1;
        this.treeViewSubstation.CheckBoxes = this.bool_0;
    }

    private void LoadTree()
    {
        //DataSetGES tges = new DataSetGES();
        DailyReport.DataSets.DataSetN tges = new DailyReport.DataSets.DataSetN();
        base.SelectSqlData(tges, tges.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name");
        this.treeViewSubstation.BeginUpdate();
        this.treeViewSubstation.Nodes.Clear();
        foreach (DataRow row in tges.tR_Classifier.Rows)
        {
            TreeNode node = this.treeViewSubstation.Nodes.Add(row["SocrName"].ToString());
            node.Tag = row["id"];
            base.SelectSqlData(tges, tges.vSchm_ObjList, true, " where typeCodeId = " + row["id"].ToString() + " and deleted = 0 order by name");
            foreach (DataRow row2 in tges.vSchm_ObjList)
            {
                TreeNode node1 = node.Nodes.Add(row2["typeCodeSocr"].ToString() + "-" + row2["Name"].ToString());
                node1.Tag = row2["id"];
                node1.Nodes.Add("");
            }
        }
        this.treeViewSubstation.EndUpdate();
    }

    private void GetListChecked(TreeNode node1, List<int> list)
    {
        if ((node1.Checked && (node1.Tag != null)) && (node1.Level > 0))
        {
            if (node1.Tag is int)
            {
                list.Add(Convert.ToInt32(node1.Tag));
            }
            if (node1.Tag is List<int>)
            {
                list.Add(((List<int>) node1.Tag)[0]);
            }
        }
        foreach (TreeNode node2 in node1.Nodes)
        {
            this.GetListChecked(node2, list);
        }
    }

    private List<TreeNode> AddNodeInList(TreeNodeCollection tcoll, List<TreeNode> nodeList)
    {
        foreach (TreeNode node in tcoll)
        {
            nodeList.Add(node);
            nodeList = this.AddNodeInList(node.Nodes, nodeList);
        }
        return nodeList;
    }

    private TreeNode SearchNode(List<TreeNode> nodeList, TreeNode selNode, string txt, eSearchNode searchNode)
    {
        bool flag = searchNode == eSearchNode.First;
        if (searchNode == eSearchNode.Prev)
        {
            nodeList.Reverse();
        }
        foreach (TreeNode node in nodeList)
        {
            if (flag && node.Text.ToUpper().Contains(txt.ToUpper()))
            {
                return node;
            }
            if (node == selNode)
            {
                flag = true;
            }
        }
        return null;
    }

    private void InitializeComponent()
    {
        this.treeViewSubstation = new TreeView();
        this.buttonOk = new Button();
        this.buttonCancel = new Button();
        this.toolStrip1 = new ToolStrip();
        this.tooBtnFind = new ToolStripButton();
        this.toolTxtFind = new ToolStripTextBox();
        this.toolBtnFindNext = new ToolStripButton();
        this.toolBtnFindPrev = new ToolStripButton();
        this.label_0 = new Label();
        this.checkBoxUseBusParent = new CheckBox();
        this.toolStrip1.SuspendLayout();
        base.SuspendLayout();
        this.treeViewSubstation.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.treeViewSubstation.HideSelection = false;
        this.treeViewSubstation.Location = new Point(0, 0x1c);
        this.treeViewSubstation.Name = "treeViewSubstation";
        this.treeViewSubstation.Size = new Size(0x1d2, 0x194);
        this.treeViewSubstation.TabIndex = 0;
        this.treeViewSubstation.BeforeExpand += new TreeViewCancelEventHandler(this.treeViewSubstation_BeforeExpand);
        
        this.buttonOk.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.buttonOk.Location = new Point(3, 0x1d0);
        this.buttonOk.Name = "buttonOk";
        this.buttonOk.Size = new Size(0x4b, 0x17);
        this.buttonOk.TabIndex = 5;
        this.buttonOk.Text = "OK";
        this.buttonOk.UseVisualStyleBackColor = true;
        this.buttonOk.Click += new EventHandler(this.buttonOk_Click);

        this.buttonCancel.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.buttonCancel.Location = new Point(0x17b, 0x1d0);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new Size(0x4b, 0x17);
        this.buttonCancel.TabIndex = 6;
        this.buttonCancel.Text = "Отмена";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
        ToolStripItem[] toolStripItems = new ToolStripItem[] { this.tooBtnFind, this.toolTxtFind, this.toolBtnFindNext, this.toolBtnFindPrev };
        this.toolStrip1.Items.AddRange(toolStripItems);
        this.toolStrip1.Location = new Point(0, 0);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new Size(0x1d2, 0x19);
        this.toolStrip1.TabIndex = 7;
        this.toolStrip1.Text = "toolStripTreeSubstations";
        this.tooBtnFind.DisplayStyle = ToolStripItemDisplayStyle.Image;
        // this.toolStripButton_0.Image = Resources.Find;
        this.tooBtnFind.Image = global::DailyReport.Properties.Resources.Find;
        this.tooBtnFind.ImageTransparentColor = Color.Magenta;
        this.tooBtnFind.Name = "tooBtnFind";
        this.tooBtnFind.Size = new Size(0x17, 0x16);
        this.tooBtnFind.Text = "Найти"; // toolStripButton1
        this.tooBtnFind.Click += new EventHandler(this.tooBtnFind_Click);
        this.toolTxtFind.Name = "toolTxtFind";
        this.toolTxtFind.Size = new Size(100, 0x19);
        this.toolTxtFind.KeyDown += new KeyEventHandler(this.toolStripTextBox_0_KeyDown);
        this.toolBtnFindNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
        // this.toolStripButton_1.Image = Resources.FindNext;
        this.toolBtnFindNext.Image = global::DailyReport.Properties.Resources.FindNext;
        this.toolBtnFindNext.ImageTransparentColor = Color.Magenta;
        this.toolBtnFindNext.Name = "toolBtnFindNext";
        this.toolBtnFindNext.Size = new Size(0x17, 0x16);
        this.toolBtnFindNext.Text = "Найти вперед";  // toolStripButton1
        this.toolBtnFindNext.Click += new EventHandler(this.toolBtnFindNext_Click);
        this.toolBtnFindPrev.DisplayStyle = ToolStripItemDisplayStyle.Image;
        // this.toolStripButton_2.Image = Resources.FindPrev;
        this.toolBtnFindPrev.Image = global::DailyReport.Properties.Resources.FindPrev;
        this.toolBtnFindPrev.ImageTransparentColor = Color.Magenta;
        this.toolBtnFindPrev.Name = "toolBtnFindPrev";
        this.toolBtnFindPrev.Size = new Size(0x17, 0x16);
        this.toolBtnFindPrev.Text = "Найти назад";  // toolStripButton2
        this.toolBtnFindPrev.Click += new EventHandler(this.toolBtnFindPrev_Click);
        this.label_0.AutoSize = true;
        this.label_0.Location = new Point(12, 0xf2);
        this.label_0.Name = "label1";
        this.label_0.Size = new Size(0x73, 13);
        this.label_0.TabIndex = 8;
        this.label_0.Text = "Объекты подстанции";
        this.checkBoxUseBusParent.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.checkBoxUseBusParent.AutoSize = true;
        this.checkBoxUseBusParent.Checked = true;
        this.checkBoxUseBusParent.CheckState = CheckState.Checked;
        this.checkBoxUseBusParent.Location = new Point(3, 0x1b9);
        this.checkBoxUseBusParent.Name = "checkBoxUseBusParent";
        this.checkBoxUseBusParent.Size = new Size(0x6d, 0x11);
        this.checkBoxUseBusParent.TabIndex = 10;
        this.checkBoxUseBusParent.Text = "Основные шины";
        this.checkBoxUseBusParent.UseVisualStyleBackColor = true;
        this.checkBoxUseBusParent.CheckedChanged += new EventHandler(this.checkBoxUseBusParent_CheckedChanged);
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.CancelButton = this.buttonCancel;
        base.ClientSize = new Size(0x1d2, 0x1f6);
        base.Controls.Add(this.checkBoxUseBusParent);
        base.Controls.Add(this.treeViewSubstation);
        base.Controls.Add(this.label_0);
        base.Controls.Add(this.toolStrip1);
        base.Controls.Add(this.buttonCancel);
        base.Controls.Add(this.buttonOk);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        base.Name = "FormSelectSchmObj";
        base.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Привязка объекта к схеме";
        base.Load += new EventHandler(this.FormSelectSchmObj_Load);
        this.toolStrip1.ResumeLayout(false);
        this.toolStrip1.PerformLayout();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void tooBtnFind_Click(object sender, EventArgs e)
    {
        List<TreeNode> list = new List<TreeNode>();
        list = this.AddNodeInList(this.treeViewSubstation.Nodes, list);
        TreeNode node = this.SearchNode(list, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, eSearchNode.First);
        if (node != null)
        {
            this.treeViewSubstation.SelectedNode = node;
            this.treeViewSubstation.SelectedNode.Expand();
        }
    }

    private void toolBtnFindNext_Click(object sender, EventArgs e)
    {
        List<TreeNode> list = new List<TreeNode>();
        list = this.AddNodeInList(this.treeViewSubstation.Nodes, list);
        TreeNode node = this.SearchNode(list, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, eSearchNode.Next);
        if (node != null)
        {
            this.treeViewSubstation.SelectedNode = node;
            this.treeViewSubstation.SelectedNode.Expand();
        }
    }

    private void toolBtnFindPrev_Click(object sender, EventArgs e)
    {
        List<TreeNode> list = new List<TreeNode>();
        list = this.AddNodeInList(this.treeViewSubstation.Nodes, list);
        TreeNode node = this.SearchNode(list, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, eSearchNode.Prev);
        if (node != null)
        {
            this.treeViewSubstation.SelectedNode = node;
            this.treeViewSubstation.SelectedNode.Expand();
        }
    }

    private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
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

    private void treeViewSubstation_BeforeExpand(object sender, TreeViewCancelEventArgs e)
    {
        if ((e.Node.Nodes.Count > 0) && (e.Node.Level > 0))
        {
            e.Node.Nodes.Clear();
            int level = e.Node.Level;
            DailyReport.DataSets.DataSetN tges;
            switch (level)
            {
                case 1:
                {
                    tges = new DailyReport.DataSets.DataSetN();
                    base.SelectSqlData(tges, tges.tR_Classifier, true, " where ParentKey like ';SCM;BUS;%' and deleted = 0 and isgroup = 0 ");
                    string str = "";
                    foreach (DataRow row in tges.tR_Classifier.Rows)
                    {
                        str = str + row["id"].ToString() + ",";
                    }
                    str = str.Remove(str.Length - 1);
                    base.SelectSqlData(tges, tges.vSchm_ObjList, true, " where idParent = " + e.Node.Tag.ToString() + " and typecodeId in (" + str + ") and deleted = 0");
                    if (!this.checkBoxUseBusParent.Checked)
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
                        DataRow[] source1 = table1.Select("Tag is null");
                        DataRow[] source = table1.Select("Tag is not null");
                        DataRow[] rowArray3 = source1;
                            DataRow row;
                        for (level = 0; level < rowArray3.Length; level++)
                        {
                            //Class34 class2 = new Class34 {
                                row = rowArray3[level];
                            //};
                            DataRow[] rowArray4 = tges.vSchm_ObjList.Select("id = " + row["id"].ToString());
                            TreeNode node = e.Node.Nodes.Add(rowArray4[0]["TypeCodeSocr"].ToString() + " - " + rowArray4[0]["Name"].ToString());
                            node.Tag = Convert.ToInt32(row["id"]);
                                //foreach (DataRow row3 in source.Where<DataRow>(new Func<DataRow, bool>(class2.method_0)))
                                var enumerate = source.Where(r => (r["Tag"] != DBNull.Value) && (Convert.ToInt32(r["Tag"]) == Convert.ToInt32(row["id"])));
                                foreach (DataRow row3 in enumerate)
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
                                        List<int> tag = (List<int>)node.Tag;
                                        tag.Add(Convert.ToInt32(row3["id"]));
                                        node.Tag = tag;
                                    }
                                    row3["Tag"] = DBNull.Value;
                                }
                            node.Nodes.Add("");
                        }
                            //foreach (DataRow row4 in source.Where<DataRow>(C1.C_9__11_1 ?? (C1.C_9__11_1 = new Func<DataRow, bool>(C1.C_9.method_0))))
                            var enumerate1 = source.Where(r => r["Tag"] != DBNull.Value);

                            foreach (DataRow row4 in enumerate1)
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
            tges = new DailyReport.DataSets.DataSetN();
            string text2 = "";
            if (e.Node.Tag is int)
            {
                text2 = e.Node.Tag.ToString();
            }
            if (e.Node.Tag is List<int>)
            {
                foreach (int current4 in ((List<int>)e.Node.Tag))
                {
                    if (string.IsNullOrEmpty(text2))
                    {
                        text2 = current4.ToString();
                    }
                    else
                    {
                        text2 = text2 + "," + current4.ToString();
                    }
                }
            }
            base.SelectSqlData(tges, tges.vSchm_TreeCellLine, true, " where ParentLink in (" + text2 + ")");
            foreach (DataRow current5 in tges.vSchm_TreeCellLine)
            {
                e.Node.Nodes.Add(current5["FullName"].ToString()).Tag = current5["id"];
            }
        }
    }

    //[Serializable, CompilerGenerated]
    //private sealed class C1
    //{
    //    public static readonly FormSelectSchmObj.C1 C_9 = new FormSelectSchmObj.C1();
    //    public static Func<DataRow, bool> C_9__11_1;

    //    internal bool method_0(DataRow row)
    //    {
    //        return (row["Tag"] != DBNull.Value);
    //    }
    //}

    //[CompilerGenerated]
    //private sealed class Class34
    //{
    //    public DataRow row;

    //    internal bool method_0(DataRow row1)
    //    {
    //        return ((row1["Tag"] != DBNull.Value) && (Convert.ToInt32(row1["Tag"]) == Convert.ToInt32(this.row["id"])));
    //    }
    //}

    private enum eSearchNode
    {
        First,
        Next,
        Prev
    }

    //[StructLayout(LayoutKind.Sequential)]
    //private struct SchmObject
    //{
    //    public string Text;
    //    public int Id;
    //    public SchmObject(int id, string text)
    //    {
    //        this.Text = text;
    //        this.Id = id;
    //    }

    //    public override string ToString()
    //    {
    //        return this.Text;
    //    }
    //}
}

