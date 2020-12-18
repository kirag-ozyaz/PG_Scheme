using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
//using Documents.Properties;
using FormLbr;
using RequestForRepairN.DataSets;
/// <summary>
/// Привязка заявок к схеме (PL)
/// </summary>
internal partial class FormLinkRequestAndSchmPL : FormBase
{
    private Dictionary<int, string> LinkObjects;

    internal Dictionary<int, string> GetLinkObjects()
    {
        return this.LinkObjects;
    }

    internal void SetLinkObjects(Dictionary<int, string> link)
    {
        this.LinkObjects = link;
    }

    private short num;
    internal short Num
    {
        get
        {
            return this.num;
        }
        set
        {
            this.num = value;
        }
    }

    internal DateTime DateBeg
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

    internal DateTime DateEnd
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

    internal string Duration
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

    internal FormLinkRequestAndSchmPL()
    {
        this.LinkObjects = new Dictionary<int, string>();
        this.InitializeComponent();
    }

    private void FormLinkRequestAndSchm_Load(object sender, EventArgs e)
    {
        this.LoadTree();
        this.listBoxObjects.Items.Clear();
        foreach (int num in this.LinkObjects.Keys)
        {
            this.listBoxObjects.Items.Add(new FormLinkRequestAndSchmPL.SchmObject(num, this.LinkObjects[num]));
        }
    }

    private void LoadTree()
    {
        DataSetDamage ds = new DataSetDamage();
        base.SelectSqlData(ds, ds.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name");
        foreach (DataRow dataRow in ds.tR_Classifier.Rows)
        {
            TreeNode treeNode = this.treeViewSubstation.Nodes.Add(dataRow["SocrName"].ToString());
            treeNode.Tag = dataRow["id"];
            base.SelectSqlData(ds, ds.vSchm_ObjList, true, " where typeCodeId = " + dataRow["id"].ToString() + " and deleted = 0 order by name");
            foreach (DataRow dataRow2 in ds.vSchm_ObjList)
            {
                TreeNode treeNode2 = treeNode.Nodes.Add(dataRow2["typeCodeSocr"].ToString() + "-" + dataRow2["Name"].ToString());
                treeNode2.Tag = dataRow2["id"];
                treeNode2.Nodes.Add("");
            }
        }
        this.treeViewSubstation.EndUpdate();
    }

    private void treeViewSubstation_AfterSelect(object sender, TreeViewEventArgs e)
    {
    }

    private void treeViewSubstation_BeforeExpand(object sender, TreeViewCancelEventArgs e)
    {
        if (e.Node.Nodes.Count > 0 && e.Node.Level > 0)
        {
            e.Node.Nodes.Clear();
            DataSetDamage ds;
            switch (e.Node.Level)
            {
                case 1:
                    {
                        ds = new DataSetDamage();
                        base.SelectSqlData(ds, ds.tR_Classifier, true, " where ParentKey like ';SCM;BUS;%' and deleted = 0 and isgroup = 0 ");
                        string text = "";
                        foreach (DataRow dataRow in ds.tR_Classifier.Rows)
                        {
                            text = text + dataRow["id"].ToString() + ",";
                        }
                        text = text.Remove(text.Length - 1);
                        base.SelectSqlData(ds, ds.vSchm_ObjList, true, string.Concat(new string[]
                        {
                            " where idParent = ",
                            e.Node.Tag.ToString(),
                            " and typecodeId in (",
                            text,
                            ") and deleted = 0"
                        }));
                        foreach (DataRow row2 in ds.vSchm_ObjList)
                        {
                            TreeNode node1 = e.Node.Nodes.Add(row2["TypeCodeSocr"].ToString() + " - " + row2["Name"].ToString());
                            node1.Tag = row2["id"];
                            node1.Nodes.Add("");
                        }
                        return;
                    }
                case 2:
                    ds = new RequestForRepairN.DataSets.DataSetDamage();
                    base.SelectSqlData(ds, ds.vSchm_TreeCellLine, true, " where ParentLink = " + e.Node.Tag.ToString());
                    foreach (DataRow row3 in ds.vSchm_TreeCellLine)
                    {
                        TreeNode node2 = e.Node.Nodes.Add(row3["FullName"].ToString());
                        node2.Tag = row3["id"];
                        node2.Nodes.Add("");
                    }
                    break;
                case 3:
                    ds = new RequestForRepairN.DataSets.DataSetDamage();
                    base.SelectSqlData(ds, ds.tSchm_Relation, true, " where Edge = " + e.Node.Tag.ToString());
                    if (ds.tSchm_Relation.Rows.Count > 0)
                    {
                        string text = "";
                        foreach (DataRow row3 in ds.tSchm_Relation)
                        {
                            text = text + row3["id"].ToString() + ",";
                        }
                        text = text.Remove(text.Length - 1);
                        base.SelectSqlData(ds, ds.vSchm_ObjList, true, " where idparent in (" + text + ") and deleted = 0");
                        foreach (DataRow row4 in ds.vSchm_ObjList)
                        {
                            e.Node.Nodes.Add(row4["TypeCodeSocr"].ToString() + " - " + row4["Name"].ToString()).Tag = row4["id"];
                        }
                    }
                    ds = new RequestForRepairN.DataSets.DataSetDamage();
                    base.SelectSqlData(ds, ds.vSchm_TreeCellLine, true, " where ParentLink = " + e.Node.Tag.ToString());
                    foreach (DataRow row5 in ds.vSchm_TreeCellLine)
                    {
                        e.Node.Nodes.Add(row5["FullName"].ToString()).Tag = row5["id"];
                    }
                    return;
                default:
                    return;
            }

        }
    }

    private void LoadCells(TreeNode nodeBus)
    {
        DataSetDamage ds = new DataSetDamage();
        base.SelectSqlData(ds, ds.vSchm_TreeCellLine, true, " where ParentLink = " + nodeBus.Tag.ToString());
        foreach (DataRow dataRow in ds.vSchm_TreeCellLine)
        {
            TreeNode treeNode = nodeBus.Nodes.Add(dataRow["FullName"].ToString());
            treeNode.Tag = dataRow["id"];
            this.LoadSwitches(treeNode);
            this.LoadLines(treeNode);
        }
    }

    private void LoadSwitches(TreeNode bnode)
    {
        DataSetDamage ds = new DataSetDamage();
        base.SelectSqlData(ds, ds.tSchm_Relation, true, " where Edge = " + bnode.Tag.ToString());
        if (ds.tSchm_Relation.Rows.Count > 0)
        {
            string text = "";
            foreach (DataRow dataRow in ds.tSchm_Relation)
            {
                text = text + dataRow["id"].ToString() + ",";
            }
            text = text.Remove(text.Length - 1);
            base.SelectSqlData(ds, ds.vSchm_ObjList, true, " where idparent in (" + text + ") and deleted = 0");
            foreach (DataRow dataRow2 in ds.vSchm_ObjList)
            {
                bnode.Nodes.Add(dataRow2["TypeCodeSocr"].ToString() + " - " + dataRow2["Name"].ToString()).Tag = dataRow2["id"];
            }
        }
    }

    private void LoadLines(TreeNode bnode)
    {
        DataSetDamage ds = new DataSetDamage();
        base.SelectSqlData(ds, ds.vSchm_TreeCellLine, true, " where ParentLink = " + bnode.Tag.ToString());
        foreach (DataRow dataRow in ds.vSchm_TreeCellLine)
        {
            bnode.Nodes.Add(dataRow["FullName"].ToString()).Tag = dataRow["id"];
        }
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        List<int> list = new List<int>();

        foreach (TreeNode treeNode_ in treeViewSubstation.Nodes)
        {
            this.GetListChecked(treeNode_, list);
        }
        foreach (int key in list)
        {
            if (!this.LinkObjects.ContainsKey(key))
            {
                this.LinkObjects.Add(key, base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                {
                    key.ToString()
                }).ToString());
            }
        }
        this.listBoxObjects.Items.Clear();
        foreach (int num in this.LinkObjects.Keys)
        {
            this.listBoxObjects.Items.Add(new FormLinkRequestAndSchmPL.SchmObject(num, LinkObjects[num]));
        }

    }

    private void GetListChecked(TreeNode node, List<int> list)
    {
        if (node.Checked && node.Tag != null && node.Level > 0)
        {
            list.Add(Convert.ToInt32(node.Tag));
        }
        foreach (TreeNode treeNode_ in node.Nodes)
        {
            this.GetListChecked(treeNode_, list);
        }
    }

    private void buttonDel_Click(object sender, EventArgs e)
    {
        foreach (object obj in this.listBoxObjects.SelectedItems)
        {
            this.LinkObjects.Remove(((FormLinkRequestAndSchmPL.SchmObject)obj).Id);
        }
        this.listBoxObjects.Items.Clear();
        foreach (int num in this.LinkObjects.Keys)
        {
            this.listBoxObjects.Items.Add(new FormLinkRequestAndSchmPL.SchmObject(num, this.LinkObjects[num]));
        }
    }

    private void buttonOk_Click(object sender, EventArgs e)
    {
        base.DialogResult = DialogResult.OK;
        base.Close();
    }

    private void tooBtnFind_Click(object sender, EventArgs e)
    {
        List<TreeNode> list_ = new List<TreeNode>();
        list_ = this.AddNodeInList(this.treeViewSubstation.Nodes, list_);
        TreeNode treeNode = this.SearchNode(list_, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, (FormLinkRequestAndSchmPL.eFind.First));
        if (treeNode != null)
        {
            this.treeViewSubstation.SelectedNode = treeNode;
            this.treeViewSubstation.SelectedNode.Expand();
        }
    }

    private void toolBtnFindNext_Click(object sender, EventArgs e)
    {

        List<TreeNode> list_ = new List<TreeNode>();
        list_ = this.AddNodeInList(this.treeViewSubstation.Nodes, list_);
        TreeNode treeNode = this.SearchNode(list_, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, (FormLinkRequestAndSchmPL.eFind.Next));
        if (treeNode != null)
        {
            this.treeViewSubstation.SelectedNode = treeNode;
            this.treeViewSubstation.SelectedNode.Expand();
        }
    }

    private void toolBtnFindPrev_Click(object sender, EventArgs e)
    {
        List<TreeNode> list_ = new List<TreeNode>();
        list_ = this.AddNodeInList(this.treeViewSubstation.Nodes, list_);
        TreeNode treeNode = this.SearchNode(list_, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, (FormLinkRequestAndSchmPL.eFind.Prev));
        if (treeNode != null)
        {
            this.treeViewSubstation.SelectedNode = treeNode;
            this.treeViewSubstation.SelectedNode.Expand();
        }
    }


    private void toolTxtFind_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Return)
        {
            Keys modifiers = e.Modifiers;
            if (modifiers == Keys.None)
            {
                this.toolBtnFindNext_Click(sender, e);
                return;
            }
            if (modifiers != Keys.Shift)
            {
                return;
            }
            this.toolBtnFindPrev_Click(sender, e);
        }
    }

    private List<TreeNode> AddNodeInList(TreeNodeCollection tcoll, List<TreeNode> nodeList)
    {
        foreach (TreeNode treeNode in tcoll)
        {
            nodeList.Add(treeNode);
            nodeList = this.AddNodeInList(treeNode.Nodes, nodeList);
        }
        return nodeList;
    }

    private TreeNode SearchNode(List<TreeNode> nodelist, TreeNode selNode, string text, FormLinkRequestAndSchmPL.eFind e)
    {
        bool flag = e == (eFind.First);
        if (e == eFind.Prev)
        {
            nodelist.Reverse();
        }
        foreach (TreeNode treeNode in nodelist)
        {
            if (flag && treeNode.Text.ToUpper().Contains(text.ToUpper()))
            {
                return treeNode;
            }
            if (treeNode == selNode)
            {
                flag = true;
            }
        }
        return null;
    }

    private struct SchmObject
    {
        public SchmObject(int id, string text)
        {
            this.Text = text;
            this.Id = id;
        }
        public override string ToString()
        {
            return this.Text;
        }

        public string Text;

        public int Id;
    }

    private enum eFind
    {
        First = 0,
        Next = 1,
        Prev = 2
    }
}
