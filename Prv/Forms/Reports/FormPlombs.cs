using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Constants;

namespace Prv.Forms.Reports
{
    public partial class FormPlombs : FormLbr.FormBase
    {
        private class ItemChecked
        {
            public string Name { get; set; }
            public int Id { get; set; }

            public ItemChecked()
            {
            }

            public ItemChecked(string name, int id)
            {
                Name = name;
                Id = id;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        #region FormPlombs Events
        // консруктор
        public FormPlombs()
        {
            InitializeComponent();

            dateTimePickerBeg.Value = new DateTime(System.DateTime.Now.Year, 1, 1);
            dateTimePickerEnd.Value = new DateTime(System.DateTime.Now.Year, 12, 31);
        }
        // загрузка формы
        private void FormPlombs_Load(object sender, EventArgs e)
        {
            LoadTreeMasters(null);
            LoadTypePlombs();
        }
        #endregion

        private void LoadTypePlombs()
        {
            DataSets.DataSetPlomb ds = new Prv.DataSets.DataSetPlomb();
            this.SelectSqlData(ds, ds.tR_Classifier, true, " where ParentKey = ';SKUEE;Plomb;TypePlomb;' and isGroup = 0 and Deleted = 0 order by name");
            checkedListBoxType.Items.Clear();

            foreach (DataRow dr in ds.tR_Classifier.Rows)
            {
                ItemChecked item = new ItemChecked(dr["Name"].ToString(),  Convert.ToInt32(dr["Id"]));
                checkedListBoxType.Items.Add(item, true);
            }
        }

        #region LoadTree
        // мастера
        private void LoadTreeMasters(TreeNode selNode)
        {
            treeViewMasters.Nodes.Clear();
            DataSets.DataSetPlomb ds = new Prv.DataSets.DataSetPlomb();
            this.SelectSqlData(ds, ds.tR_Classifier, true, " where ParentKey = ';GroupWorker;MasterPlomber;' " +
                "and isGroup = 1 and deleted = 0");
            if (ds.tR_Classifier.Rows.Count <= 0) return;
            TreeNode root = new TreeNode(ds.tR_Classifier.Rows[0]["Name"].ToString());
            root.Tag = "All";
            treeViewMasters.Nodes.Add(root);

            if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(root.Tag)))
            {   // выделяем элемент, если надо
                treeViewMasters.SelectedNode = root;
                treeViewMasters.SelectedNode.Expand();
            }
            // группы мастеров
            string delete = (toolBtnShowDel.Checked) ? "" : " and deleted = 0 ";
            this.SelectSqlData(ds, ds.tR_Classifier, true, " where ParentKey = ';GroupWorker;MasterPlomber;' " +
                "and isGroup = 0 " + delete + " order by name");

            foreach (DataRow dr in ds.tR_Classifier.Rows)
            {
                TreeNode nodeGroup = new TreeNode();
                nodeGroup.Text = dr["Name"].ToString();
                nodeGroup.Tag = "Group" + dr["Id"].ToString();
                if (Convert.ToBoolean(dr["Deleted"])) nodeGroup.ForeColor = Color.Red;
                root.Nodes.Add(nodeGroup);

                if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(nodeGroup.Tag)))
                {   // выделяем элемент, если надо
                    treeViewMasters.SelectedNode = nodeGroup;
                    treeViewMasters.SelectedNode.Expand();
                }
                delete = (toolBtnShowDel.Checked) ? "" : " and DateEnd is null ";
                this.SelectSqlData(ds, ds.vWorkerGroup, true, " where idGRoup = " + GetIdFromNodeTag(nodeGroup.Tag).ToString() +
                    delete + " order by fio");
                foreach (DataRow drMaster in ds.vWorkerGroup.Rows)
                {
                    TreeNode nodeMaster = new TreeNode();
                    nodeMaster.Text = drMaster["FIO"].ToString();
                    nodeMaster.Tag = "Master" + drMaster["id"].ToString();
                    if (drMaster["DateEnd"] != DBNull.Value) nodeMaster.ForeColor = Color.Red;
                    nodeGroup.Nodes.Add(nodeMaster);
                    if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(nodeMaster.Tag)))
                    {   // выделяем элемент, если надо
                        treeViewMasters.SelectedNode = nodeMaster;
                        treeViewMasters.SelectedNode.Expand();
                    }
                }
            }
            treeViewMasters.ExpandAll();

            treeViewMasters.Nodes[0].Checked = false;
            treeViewMasters.Nodes[0].Checked = true;
        }
        // Возвращает Id из ветки
        private int GetIdFromNodeTag(Object tag)
        {
            string stTag = tag.ToString();

            if (stTag.IndexOf("All") >= 0) // all
                return -1;
            if (stTag.IndexOf("Group") >= 0) // ветка group
                return Convert.ToInt32(stTag.Substring(5));
            if (stTag.IndexOf("Master") >= 0) // ветка master
                return Convert.ToInt32(stTag.Substring(6));

            return -1;
        }
        #endregion

        #region toolStripTree Events
        // показать/скрыть удаленных
        private void toolBtnShowDel_Click(object sender, EventArgs e)
        {
            LoadTreeMasters(treeViewMasters.SelectedNode);
        }
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            List<TreeNode> nodeList = new List<TreeNode>();
            nodeList = AddNodeInList(treeViewMasters.Nodes, nodeList); // закинем все в список (с ним легче работать)
            TreeNode findNode = SearchNextNode(nodeList, treeViewMasters.SelectedNode, toolStripTextBoxGrid.Text); // поиск
            if (findNode != null)
            {   // веделение найденного элемента
                treeViewMasters.SelectedNode = findNode;
                treeViewMasters.SelectedNode.Expand();
            }
        }

        private void toolStripTextBoxGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.None) && (e.KeyCode == Keys.Enter))
                toolStripButtonFind_Click(sender, e);

        }
        // дерево в список
        private List<TreeNode> AddNodeInList(TreeNodeCollection tcoll, List<TreeNode> nodeList)
        {
            foreach (TreeNode n in tcoll)
            {
                nodeList.Add(n);
                nodeList = AddNodeInList(n.Nodes, nodeList);
            }
            return nodeList;
        }
        // поиск в списке
        private TreeNode SearchNextNode(List<TreeNode> nodeList, TreeNode selNode, string text)
        {
            bool find = false;
            foreach (TreeNode node in nodeList)
            {
                if (find)
                    if (node.Text.ToUpper().Contains(text.ToUpper()))
                    {
                        return node;
                    }
                if (node == selNode)
                    find = true;
            }
            return null;
        }
        #endregion

        private void radioButtonOther_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxUst.Enabled = radioButtonOther.Checked;
            checkBoxDem.Enabled = radioButtonOther.Checked;
            checkBoxFree.Enabled = radioButtonOther.Checked;
            checkBoxDel.Enabled = radioButtonOther.Checked;
        }

        // кнопка формирования отчета
        private void buttonrReport_Click(object sender, EventArgs e)
        {
            if (treeViewMasters.GetState(treeViewMasters.Nodes[0]) == CheckState.Unchecked)
            {
                MessageBox.Show("Не выбрано ни одного мастера");
                return;
            }

            if (checkedListBoxType.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Не выбраны типы пломб");
                return;
            }

            if (radioButtonOther.Checked)
            {
                if ((!checkBoxUst.Checked) && (!checkBoxDem.Checked) &&
                    (!checkBoxDel.Checked) && (!checkBoxFree.Checked))
                {
                    MessageBox.Show("Не выбраны действия над пломбами");
                    return;
                }
            }

            string where = BuildWhere();
            this.SelectSqlData(dsPlomb, dsPlomb.vPlombStatus, true, where);

            int typeRdlc = 1;
            if (radioButtonOther.Checked) typeRdlc = 2;
            if (radioButtonAll.Checked) typeRdlc = 3;
            FormRepPlombs f = new FormRepPlombs(dsPlomb, dateTimePickerBeg.Value.Date, 
                dateTimePickerEnd.Value.Date, typeRdlc);
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private string BuildWhere()
        {
            string where = "";

            // МАСТЕРА
            string whereMasters = "";
            foreach (TreeNode group in treeViewMasters.Nodes[0].Nodes) //group masters
            {
                foreach (TreeNode node in group.Nodes) // masters
                {
                    if (treeViewMasters.GetState(node) == CheckState.Checked)
                        whereMasters += GetIdFromNodeTag(node.Tag).ToString() + ",";
                }
            }
            if (whereMasters != "")
                where = " where (idWorker in (" + whereMasters.Remove(whereMasters.Length - 1) + ")) ";

            // ДАТА
            if (where != "")
                where += " and (dateInst >= '" + dateTimePickerBeg.Value.Date.ToString("yyyyMMdd") + "') and " + 
                    " (dateInst <= '" + dateTimePickerEnd.Value.Date.ToString("yyyyMMdd") + "') ";
            else
                where += " where (dateInst >= '" + dateTimePickerBeg.Value.Date.ToString("yyyyMMdd") + "') and " +
                    " (dateInst <= '" + dateTimePickerEnd.Value.Date.ToString("yyyyMMdd") + "') ";

            // Тип пломбы
            string whereType = "";
            if (checkedListBoxType.CheckedItems.Count != checkedListBoxType.Items.Count)
                foreach (ItemChecked item in checkedListBoxType.CheckedItems)
                    whereType += item.Id + ",";

            if (whereType != "")
                if (where != "")
                    where += " and (typePlomb in (" + whereType.Remove(whereType.Length - 1) + ")) ";
                else
                    where += " where (typePlomb in (" + whereType.Remove(whereType.Length - 1) + ")) ";

            // Действия над пломбами
            if (radioButtonOther.Checked)
            {
                string whereActPlomb = "";
                if (checkBoxUst.Checked) // Установленные
                    whereActPlomb = ((int)ActPlomb.Installation).ToString();
                if (checkBoxDem.Checked)
                    if (whereActPlomb != "")
                        whereActPlomb += "," + ((int)ActPlomb.Dismantling).ToString();
                    else
                        whereActPlomb = ((int)ActPlomb.Dismantling).ToString();
                if (checkBoxDel.Checked)
                    if (whereActPlomb != "")
                        whereActPlomb += "," + ((int)ActPlomb.Destruction).ToString();
                    else
                        whereActPlomb = ((int)ActPlomb.Destruction).ToString();
                if (checkBoxFree.Checked)
                    if (whereActPlomb != "")
                        whereActPlomb += "," + ((int)ActPlomb.Extradition).ToString();
                    else
                        whereActPlomb = ((int)ActPlomb.Extradition).ToString();
                
                if (whereActPlomb != "")
                    if (where != "")
                        where += " and (idStatusPlomb in (" + whereActPlomb + ")) ";
                    else
                        where += " where (idStatusPlomb in (" + whereActPlomb + ")) ";

            }

            return where;
        }
    }
}
