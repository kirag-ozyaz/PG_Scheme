using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
//using Documents.Properties;
using FormLbr;
namespace JournalOrder
{
    internal partial class FormLinkOrderAndSchm : FormBase
    {
        public Dictionary<int, string> LinkObjects
        {
            get
            {
                return this.objects;
            }
            set
            {
                this.objects = value;
            }
        }
        private Dictionary<int, string> objects = new Dictionary<int, string>();
        //private Dictionary<int, string> objects;

        internal FormLinkOrderAndSchm()
        {

            //this.objects = new Dictionary<int, string>();

            this.InitializeComponent();
        }

        private void FormLinkOrderAndSchm_Load(object sender, EventArgs e)
        {
            this.LoadSubStation();
            this.listBoxObjects.Items.Clear();
            foreach (int num in this.objects.Keys)
            {
                this.listBoxObjects.Items.Add(new Documents.Forms.JournalOrder.SchmObject(num, this.objects[num]));
            }
        }

        private void LoadSubStation()
        {
            DataSet.DataSetOrder dataSetOrder = new DataSet.DataSetOrder();
            base.SelectSqlData(dataSetOrder, dataSetOrder.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name");
            this.treeViewSubstation.BeginUpdate();
            foreach (DataRow dataRow in dataSetOrder.tR_Classifier.Rows)
            {
                TreeNode treeNode = this.treeViewSubstation.Nodes.Add(dataRow["SocrName"].ToString());
                treeNode.Tag = dataRow["id"];
                base.SelectSqlData(dataSetOrder, dataSetOrder.vSchm_ObjList, true, " where typeCodeId = " + dataRow["id"].ToString() + " and deleted = 0 order by name");
                foreach (DataRow dataRow2 in dataSetOrder.vSchm_ObjList)
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
                DataSet.DataSetOrder ds;
                switch (e.Node.Level)
                {
                    case 1:
                        {
                            ds = new DataSet.DataSetOrder();
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
                            foreach (DataRow dataRow2 in ds.vSchm_ObjList)
                            {
                                TreeNode treeNode = e.Node.Nodes.Add(dataRow2["TypeCodeSocr"].ToString() + " - " + dataRow2["Name"].ToString());
                                treeNode.Tag = dataRow2["id"];
                                treeNode.Nodes.Add("");
                            }
                            return;
                        }
                    case 2:
                        ds = new DataSet.DataSetOrder();
                        base.SelectSqlData(ds, ds.vSchm_TreeCellLine, true, " where ParentLink = " + e.Node.Tag.ToString());
                        foreach (DataRow dataRow3 in ds.vSchm_TreeCellLine)
                        {
                            TreeNode treeNode2 = e.Node.Nodes.Add(dataRow3["FullName"].ToString());
                            treeNode2.Tag = dataRow3["id"];
                            treeNode2.Nodes.Add("");
                        }
                        break;
                    case 3:
                        ds = new DataSet.DataSetOrder();
                        base.SelectSqlData(ds, ds.tSchm_Relation, true, " where Edge = " + e.Node.Tag.ToString());
                        if (ds.tSchm_Relation.Rows.Count > 0)
                        {
                            string text = "";
                            foreach (DataRow dataRow4 in ds.tSchm_Relation)
                            {
                                text = text + dataRow4["id"].ToString() + ",";
                            }
                            text = text.Remove(text.Length - 1);
                            base.SelectSqlData(ds, ds.vSchm_ObjList, true, " where idparent in (" + text + ") and deleted = 0");
                            foreach (DataRow dataRow5 in ds.vSchm_ObjList)
                            {
                                e.Node.Nodes.Add(dataRow5["TypeCodeSocr"].ToString() + " - " + dataRow5["Name"].ToString()).Tag = dataRow5["id"];
                            }
                        }
                        ds = new DataSet.DataSetOrder();
                        base.SelectSqlData(ds, ds.vSchm_TreeCellLine, true, " where ParentLink = " + e.Node.Tag.ToString());
                        foreach (DataRow dataRow6 in ds.vSchm_TreeCellLine)
                        {
                            e.Node.Nodes.Add(dataRow6["FullName"].ToString()).Tag = dataRow6["id"];
                        }
                        return;
                    default:
                        return;
                }
            }
        }

        private void LoadCells(TreeNode nodeBus)
        {
            DataSet.DataSetOrder dataSetOrder = new DataSet.DataSetOrder();
            base.SelectSqlData(dataSetOrder, dataSetOrder.vSchm_TreeCellLine, true, " where ParentLink = " + nodeBus.Tag.ToString());
            foreach (DataRow dataRow in dataSetOrder.vSchm_TreeCellLine)
            {
                TreeNode treeNode = nodeBus.Nodes.Add(dataRow["FullName"].ToString());
                treeNode.Tag = dataRow["id"];
                this.LoadSwitches(treeNode);
                this.LoadLines(treeNode);
            }
        }

        private void LoadSwitches(TreeNode node)
        {
            DataSet.DataSetOrder dataSetOrder = new DataSet.DataSetOrder();
            base.SelectSqlData(dataSetOrder, dataSetOrder.tSchm_Relation, true, " where Edge = " + node.Tag.ToString());
            if (dataSetOrder.tSchm_Relation.Rows.Count > 0)
            {
                string text = "";
                foreach (DataRow dataRow in dataSetOrder.tSchm_Relation)
                {
                    text = text + dataRow["id"].ToString() + ",";
                }
                text = text.Remove(text.Length - 1);
                base.SelectSqlData(dataSetOrder, dataSetOrder.vSchm_ObjList, true, " where idparent in (" + text + ") and deleted = 0");
                foreach (DataRow dataRow2 in dataSetOrder.vSchm_ObjList)
                {
                    node.Nodes.Add(dataRow2["TypeCodeSocr"].ToString() + " - " + dataRow2["Name"].ToString()).Tag = dataRow2["id"];
                }
            }
        }

        private void LoadLines(TreeNode node)
        {
            DataSet.DataSetOrder dataSetOrder = new DataSet.DataSetOrder();
            base.SelectSqlData(dataSetOrder, dataSetOrder.vSchm_TreeCellLine, true, " where ParentLink = " + node.Tag.ToString());
            foreach (DataRow dataRow in dataSetOrder.vSchm_TreeCellLine)
            {
                node.Nodes.Add(dataRow["FullName"].ToString()).Tag = dataRow["id"];
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (TreeNode node in this.treeViewSubstation.Nodes)
            {
                this.GetListChecked(node, list);
            }
            foreach (int key in list)
            {
                if (!this.objects.ContainsKey(key))
                {
                    this.objects.Add(key, base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                    {
                    key.ToString()
                    }).ToString());
                }
            }
            this.listBoxObjects.Items.Clear();
            foreach (int num in this.objects.Keys)
            {
                this.listBoxObjects.Items.Add(new Documents.Forms.JournalOrder.SchmObject(num, this.objects[num]));
            }
        }

        private void GetListChecked(TreeNode node, List<int> list)
        {
            if (node.Checked && node.Tag != null && node.Level > 0)
            {
                list.Add(Convert.ToInt32(node.Tag));
            }
            foreach (TreeNode node2 in node.Nodes)
            {
                this.GetListChecked(node2, list);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            foreach (object obj in this.listBoxObjects.SelectedItems)
            {
                this.objects.Remove(((Documents.Forms.JournalOrder.SchmObject)obj).Id);
            }
            this.listBoxObjects.Items.Clear();
            foreach (int num in this.objects.Keys)
            {
                this.listBoxObjects.Items.Add(new Documents.Forms.JournalOrder.SchmObject(num, this.objects[num]));
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        private void tooBtnFind_Click(object sender, EventArgs e)
        {
            List<TreeNode> nodeList = new List<TreeNode>();
            nodeList = this.AddNodeInList(this.treeViewSubstation.Nodes, nodeList);
            TreeNode treeNode = this.SearchNode(nodeList, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, (Documents.Forms.JournalOrder.eSearchNode.First));
            if (treeNode != null)
            {
                this.treeViewSubstation.SelectedNode = treeNode;
                this.treeViewSubstation.SelectedNode.Expand();
            }
        }

        private void toolBtnFindNext_Click(object sender, EventArgs e)
        {
            List<TreeNode> nodeList = new List<TreeNode>();
            nodeList = this.AddNodeInList(this.treeViewSubstation.Nodes, nodeList);
            TreeNode treeNode = this.SearchNode(nodeList, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, (Documents.Forms.JournalOrder.eSearchNode.Next));
            if (treeNode != null)
            {
                this.treeViewSubstation.SelectedNode = treeNode;
                this.treeViewSubstation.SelectedNode.Expand();
            }
        }

        private void toolBtnFindPrev_Click(object sender, EventArgs e)
        {
            List<TreeNode> nodeList = new List<TreeNode>();
            nodeList = this.AddNodeInList(this.treeViewSubstation.Nodes, nodeList);
            TreeNode treeNode = this.SearchNode(nodeList, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, (Documents.Forms.JournalOrder.eSearchNode.Prev));
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
                //TreeNode treeNode = (TreeNode)obj;
                nodeList.Add(treeNode);
                nodeList = this.AddNodeInList(treeNode.Nodes, nodeList);
            }
            return nodeList;
        }

        private TreeNode SearchNode(List<TreeNode> nodeList, TreeNode selNode, string text, Documents.Forms.JournalOrder.eSearchNode searchNode)
        {
            bool flag = searchNode == Documents.Forms.JournalOrder.eSearchNode.First;
            if (searchNode == Documents.Forms.JournalOrder.eSearchNode.Prev)
            {
                nodeList.Reverse();
            }
            foreach (TreeNode treeNode in nodeList)
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



    }
}