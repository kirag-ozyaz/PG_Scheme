using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormLbr;
using ControlsLbr.DataGridViewExcelFilter;

namespace ReferenceWorker
{
    public partial class FormWorkersSelect : FormBase
    {
        public int idPersonalSelect
        {
            get
            {
                return Convert.ToInt32(this.dgvWorker.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
            }
        }

        public FormWorkersSelect()
        {
            InitializeComponent();
        }

        private void FormWorkersSelect_Load(object sender, EventArgs e)
        {
            base.SelectSqlData(this.dsWorker, this.dsWorker.tR_Division, true);
            this.LoadTreeDivision(null);
            base.SelectSqlData(this.dsWorker, this.dsWorker.tR_JobTitle, true);

            string where = this.toolBtnShowWorkerDelete.Checked ? "" : " where DateEnd is null";
            base.SelectSqlData(this.dsWorker, this.dsWorker.tR_Worker, true, where);
            base.SelectSqlData(this.dsWorker, this.dsWorker.tR_Classifier, true, "where (parentKey in (';StatusWorker;', ';ReasonWorker;', ';Contact;')  or parentKey LIKE '%;GroupWorker;%') and isgroup = 0");
        }
        private void LoadTreeDivision(TreeNode selNode)
        {
            this.treeViewDivision.Nodes.Clear();
            this.treeViewDivision.Nodes.Add("Все подразделения");
            this.treeViewDivision.SelectedNode = this.treeViewDivision.Nodes[0];
            TreeNode treeNode = this.treeViewDivision.Nodes[0];
            string str = this.toolBtnShowDeleteDivision.Checked ? "" : " and Deleted = false";
            foreach (DataRow dataRow in this.dsWorker.Tables["tR_Division"].Select("ParentId is NULL" + str, "Description"))
            {
                TreeNode treeNode2 = new TreeNode(dataRow["Description"].ToString());
                treeNode2.Tag = dataRow["Id"];
                treeNode2.ImageKey = this.GetFolderName(dataRow);
                treeNode2.SelectedImageKey = this.GetFolderName(dataRow);
                treeNode.Nodes.Add(treeNode2);
                this.LoadTreeNodes(treeNode2, selNode);
                if (selNode != null && Convert.ToInt32(selNode.Tag) == Convert.ToInt32(treeNode2.Tag))
                {
                    this.treeViewDivision.SelectedNode = treeNode2;
                    this.treeViewDivision.SelectedNode.Expand();
                }
            }
            this.treeViewDivision.Nodes[0].Expand();
        }
        private string GetFolderName(DataRow row)
        {
            if (Convert.ToBoolean(row["Deleted"]))
            {
                return "FolderDeleteYellow.png";
            }
            string str = this.toolBtnShowDeleteDivision.Checked ? "" : " and Deleted = false";
            if (this.dsWorker.Tables["tR_Division"].Select("ParentId = " + row["id"].ToString() + str).Length != 0)
            {
                return "FolderDocumentYellow.png";
            }
            return "FolderYellow.png";
        }
        private void LoadTreeNodes(TreeNode root, TreeNode selNode)
        {
            string str = this.toolBtnShowDeleteDivision.Checked ? "" : " and Deleted = false";
            foreach (DataRow dataRow in this.dsWorker.Tables["tR_Division"].Select("ParentId = " + root.Tag.ToString() + str, "Description ASC"))
            {
                TreeNode treeNode = new TreeNode(dataRow["Description"].ToString());
                treeNode.Tag = dataRow["Id"];
                treeNode.ImageKey = this.GetFolderName(dataRow);
                treeNode.SelectedImageKey = this.GetFolderName(dataRow);
                root.Nodes.Add(treeNode);
                this.LoadTreeNodes(treeNode, selNode);
                if (selNode != null && Convert.ToInt32(selNode.Tag) == Convert.ToInt32(treeNode.Tag))
                {
                    this.treeViewDivision.SelectedNode = treeNode;
                    this.treeViewDivision.SelectedNode.Expand();
                }
            }
        }

        private void toolBtnShowWorkerDelete_Click(object sender, EventArgs e)
        {
            if (this.toolBtnShowWorkerDelete.Checked)
            {
                this.toolBtnShowWorkerDelete.Text = "Скрыть уволенных сотрудников";
                base.SelectSqlData(this.dsWorker, this.dsWorker.tR_Worker, true);
                return;
            }
            this.toolBtnShowWorkerDelete.Text = "Показать уволенных сотрудников";
            base.SelectSqlData(this.dsWorker, this.dsWorker.tR_Worker, true, " where dateEnd is null");
        }

        private void treeViewDivision_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.BindingFilterDivision(e.Node);
        }
        private void BindingFilterDivision(TreeNode tnd)
        {
            if (tnd.IsSelected)
            {
                if (tnd == this.treeViewDivision.Nodes[0])
                {
                    this.bsWorker.Filter = "";
                }
                else
                {
                    this.bsWorker.Filter = "DivisionCurrent = " + tnd.Tag.ToString();
                }
            }
            this.bsWorker.Sort = "F, I, O, DateBegin";
        }

        private void dgvWorker_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && this.dgvWorker["dateEndDgvTextBoxColumn", e.RowIndex].Value.ToString() != "")
            {
                e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void toolBtnShowDeleteDivision_Click(object sender, EventArgs e)
        {
            if (this.toolBtnShowDeleteDivision.Checked)
            {
                this.toolBtnShowDeleteDivision.Text = "Скрыть удаленных";
            }
            else
            {
                this.toolBtnShowDeleteDivision.Text = "Показать удаленных";
            }
            this.LoadTreeDivision(this.treeViewDivision.SelectedNode);
        }

 

        private void dgvWorker_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
