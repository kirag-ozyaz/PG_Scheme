using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using Reference.Properties;

namespace Reference.Forms
{
	public partial class FormDivisions : FormBase
	{
		public FormDivisions()
		{
			
			
			this.InitializeComponent();
		}

		private void FormDivisions_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tr_Division"], true);
			this.method_1(null);
			this.method_0();
		}

		private void method_0()
		{
			this.toolBtnAdd.Visible = false;
			this.toolBtnDel.Visible = false;
			this.toolBtnEdit.Visible = false;
		}

		private void method_1(TreeNode treeNode_0)
		{
			this.treeView.Nodes.Clear();
			this.treeView.Nodes.Add("Все элементы");
			this.treeView.SelectedNode = this.treeView.Nodes[0];
			TreeNode treeNode = this.treeView.Nodes[0];
			string str = this.toolStripButtonHideDelete.Checked ? "" : " and Deleted = false";
			foreach (DataRow dataRow in this.dataSet_0.Tables["tR_Division"].Select("ParentId is NULL" + str, "Description"))
			{
				TreeNode treeNode2 = new TreeNode(dataRow["Description"].ToString());
				treeNode2.Tag = dataRow["Id"];
				treeNode2.ImageKey = this.method_3(dataRow);
				treeNode2.SelectedImageKey = this.method_3(dataRow);
				treeNode.Nodes.Add(treeNode2);
				this.method_2(treeNode2, treeNode_0);
				if (treeNode_0 != null && Convert.ToInt32(treeNode_0.Tag) == Convert.ToInt32(treeNode2.Tag))
				{
					this.treeView.SelectedNode = treeNode2;
					this.treeView.SelectedNode.Expand();
				}
			}
			this.treeView.Nodes[0].Expand();
		}

		private void method_2(TreeNode treeNode_0, TreeNode treeNode_1)
		{
			string str = this.toolStripButtonHideDelete.Checked ? "" : " and Deleted = false";
			foreach (DataRow dataRow in this.dataSet_0.Tables["tR_Division"].Select("ParentId = " + treeNode_0.Tag.ToString() + str, "Description ASC"))
			{
				TreeNode treeNode = new TreeNode(dataRow["Description"].ToString());
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageKey = this.method_3(dataRow);
				treeNode.SelectedImageKey = this.method_3(dataRow);
				treeNode_0.Nodes.Add(treeNode);
				this.method_2(treeNode, treeNode_1);
				if (treeNode_1 != null && Convert.ToInt32(treeNode_1.Tag) == Convert.ToInt32(treeNode.Tag))
				{
					this.treeView.SelectedNode = treeNode;
					this.treeView.SelectedNode.Expand();
				}
			}
		}

		private string method_3(DataRow dataRow_0)
		{
			if (Convert.ToBoolean(dataRow_0["Deleted"]))
			{
				return "FolderDeleteYellow.png";
			}
			string str = this.toolStripButtonHideDelete.Checked ? "" : " and Deleted = false";
			if (this.dataSet_0.Tables["tR_Division"].Select("ParentId = " + dataRow_0["id"].ToString() + str).Length != 0)
			{
				return "FolderDocumentYellow.png";
			}
			return "FolderYellow.png";
		}

		private void toolStripButtonFindTree_Click(object sender, EventArgs e)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_4(this.treeView.Nodes, list_);
			TreeNode treeNode = this.method_5(list_, this.treeView.SelectedNode, this.toolStripTextBoxFindTree.Text);
			if (treeNode != null)
			{
				this.treeView.SelectedNode = treeNode;
				this.treeView.SelectedNode.Expand();
			}
		}

		private List<TreeNode> method_4(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_0)
		{
			foreach (object obj in treeNodeCollection_0)
			{
				TreeNode treeNode = (TreeNode)obj;
				list_0.Add(treeNode);
				list_0 = this.method_4(treeNode.Nodes, list_0);
			}
			return list_0;
		}

		private TreeNode method_5(List<TreeNode> list_0, TreeNode treeNode_0, string string_0)
		{
			bool flag = false;
			foreach (TreeNode treeNode in list_0)
			{
				if (flag && treeNode.Text.ToUpper().Contains(string_0.ToUpper()))
				{
					return treeNode;
				}
				if (treeNode == treeNode_0)
				{
					flag = true;
				}
			}
			return null;
		}

		private void toolStripTextBoxFindTree_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.toolStripButtonFindTree_Click(sender, e);
			}
		}

		private void toolStripButtonClose_Click(object sender, EventArgs e)
		{
			this.splitContainer.Panel1Collapsed = true;
			this.toolStripButtonHideTree.Checked = false;
			this.toolStripButtonHideTree.Text = "Показать дерево";
			string filter = this.toolStripButtonHideDelete.Checked ? "" : "Deleted = false";
			this.bindingSource_0.Filter = filter;
		}

		private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.method_6(e.Node);
			if (this.method_8(e.Node))
			{
				this.toolBtnDelRestore.Text = "Восстановить";
				this.toolMenuDelRest.Text = "Восстановить";
				return;
			}
			this.toolBtnDelRestore.Text = "Пометить на удаление";
			this.toolMenuDelRest.Text = "Пометить на удаление";
		}

		private void method_6(TreeNode treeNode_0)
		{
			string filter = "";
			int num = -1;
			if (treeNode_0.IsSelected)
			{
				if (treeNode_0 == this.treeView.Nodes[0])
				{
					string str = this.toolStripButtonHideDelete.Checked ? "" : " and Deleted = false";
					filter = "ParentId is NULL" + str;
				}
				else
				{
					string str2 = this.toolStripButtonHideDelete.Checked ? "" : " and Deleted = false";
					if (treeNode_0.ImageKey.Contains("Folder"))
					{
						filter = "ParentId = " + treeNode_0.Tag.ToString() + str2;
					}
					num = Convert.ToInt32(treeNode_0.Tag);
				}
			}
			this.bindingSource_0.Filter = filter;
			this.bindingSource_0.Sort = "description";
			if (num >= 0 && this.dgvExcelFilter.Rows.Count > 0)
			{
				this.dgvExcelFilter.CurrentCell = this.dgvExcelFilter[0, this.method_7(this.dgvExcelFilter, "idDgvTextBoxColumn", num)];
			}
		}

		private int method_7(DataGridViewExcelFilter dataGridViewExcelFilter_0, string string_0, int int_0)
		{
			foreach (object obj in ((IEnumerable)dataGridViewExcelFilter_0.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if (Convert.ToInt32(dataGridViewRow.Cells[string_0].Value) == int_0)
				{
					return dataGridViewRow.Index;
				}
			}
			return 0;
		}

		private bool method_8(TreeNode treeNode_0)
		{
			int num;
			return treeNode_0.Tag != null && int.TryParse(this.treeView.SelectedNode.Tag.ToString(), out num) && (bool)this.dataSet_0.Tables["tR_Division"].Select("id = " + num.ToString())[0]["deleted"];
		}

		private void toolMenuAdd_Click(object sender, EventArgs e)
		{
			int parentId;
			if (this.treeView.SelectedNode.Tag == null)
			{
				parentId = -1;
			}
			else if (!int.TryParse(this.treeView.SelectedNode.Tag.ToString(), out parentId))
			{
				parentId = -1;
			}
			this.formDivisionsAddEdit_0 = new FormDivisionsAddEdit(-1, parentId);
			this.formDivisionsAddEdit_0.SqlSettings = this.SqlSettings;
			this.formDivisionsAddEdit_0.method_1(0);
			this.formDivisionsAddEdit_0.MdiParent = base.MdiParent;
			this.formDivisionsAddEdit_0.Show();
			this.formDivisionsAddEdit_0.FormClosed -= this.ohiuLkgoyw;
			this.formDivisionsAddEdit_0.FormClosed += this.ohiuLkgoyw;
		}

		private void ohiuLkgoyw(object sender, FormClosedEventArgs e)
		{
			if (this.formDivisionsAddEdit_0.DialogResult == DialogResult.OK)
			{
				base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tr_Division"], true);
				this.method_1(null);
			}
		}

		private void toolMenuEdit_Click(object sender, EventArgs e)
		{
			if (this.treeView.SelectedNode.Tag == null)
			{
				return;
			}
			int id;
			if (!int.TryParse(this.treeView.SelectedNode.Tag.ToString(), out id))
			{
				return;
			}
			int parentId;
			if (this.treeView.SelectedNode.Parent.Tag == null)
			{
				parentId = -1;
			}
			else if (!int.TryParse(this.treeView.SelectedNode.Parent.Tag.ToString(), out parentId))
			{
				parentId = -1;
			}
			this.formDivisionsAddEdit_0 = new FormDivisionsAddEdit(id, parentId);
			this.formDivisionsAddEdit_0.SqlSettings = this.SqlSettings;
			this.formDivisionsAddEdit_0.method_1(1);
			this.formDivisionsAddEdit_0.MdiParent = base.MdiParent;
			this.formDivisionsAddEdit_0.Show();
			this.formDivisionsAddEdit_0.FormClosed -= this.ohiuLkgoyw;
			this.formDivisionsAddEdit_0.FormClosed += this.ohiuLkgoyw;
		}

		private void toolMenuDelRest_Click(object sender, EventArgs e)
		{
			if (this.treeView.SelectedNode.Tag == null)
			{
				return;
			}
			int num;
			if (!int.TryParse(this.treeView.SelectedNode.Tag.ToString(), out num))
			{
				return;
			}
			if (this.method_8(this.treeView.SelectedNode))
			{
				DataRow[] array = this.dataSet_0.Tables["tR_Division"].Select(string.Format("id = {0}", num));
				array[0]["deleted"] = false;
				if (this.treeView.SelectedNode.Parent != null && this.treeView.SelectedNode.Parent.Tag != null)
				{
					DataRow[] array2 = this.dataSet_0.Tables["tR_Division"].Select(string.Format("id = {0}", (int)array[0]["ParentId"]));
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i]["deleted"] = false;
					}
				}
				this.method_9(this.treeView.SelectedNode, false);
			}
			else
			{
				DataRow[] array2 = this.dataSet_0.Tables["tR_Division"].Select(string.Format("id = {0} or parentId = {0}", num));
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i]["deleted"] = true;
				}
				this.method_9(this.treeView.SelectedNode, true);
			}
			if (!base.UpdateSqlDataOnlyChange(this.dataSet_0.Tables["tR_Division"]))
			{
				MessageBox.Show("Не удалось внести изменения", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tr_Division"], true);
			this.method_1(null);
		}

		private void method_9(TreeNode treeNode_0, bool bool_0)
		{
			foreach (object obj in treeNode_0.Nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				this.dataSet_0.Tables["tR_Division"].Select("id = " + treeNode.Tag.ToString())[0]["deleted"] = bool_0;
				this.method_9(treeNode, bool_0);
			}
		}

		private void toolMenuDelFull_Click(object sender, EventArgs e)
		{
			if (this.treeView.SelectedNode.Tag == null)
			{
				return;
			}
			int num;
			if (!int.TryParse(this.treeView.SelectedNode.Tag.ToString(), out num))
			{
				return;
			}
			if (MessageBox.Show("Вы действительно хотите удалить выбранное подразделение и все его дочерние элементы?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}
			DataRow[] array = this.dataSet_0.Tables["tR_Division"].Select(string.Format("id = {0}", num));
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Delete();
			}
			this.method_10(this.treeView.SelectedNode);
			if (!base.DeleteSqlData(this.dataSet_0.Tables["tR_Division"]))
			{
				MessageBox.Show("Не удалось внести изменения", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tr_Division"], true);
			this.method_1(null);
		}

		private void method_10(TreeNode treeNode_0)
		{
			foreach (object obj in treeNode_0.Nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				this.dataSet_0.Tables["tR_Division"].Select("id = " + treeNode.Tag.ToString())[0].Delete();
				this.method_10(treeNode);
			}
		}

		private void toolStripButtonHideDelete_Click(object sender, EventArgs e)
		{
			if (this.toolStripButtonHideDelete.Checked)
			{
				this.toolStripButtonHideDelete.Text = "Скрыть удаленных";
			}
			else
			{
				this.toolStripButtonHideDelete.Text = "Показать удаленных";
			}
			this.method_1(this.treeView.SelectedNode);
		}

		private void toolStripButtonHideTree_Click(object sender, EventArgs e)
		{
			if (this.toolStripButtonHideTree.Checked)
			{
				this.toolStripButtonHideTree.Text = "Скрыть дерево";
				this.splitContainer.Panel1Collapsed = false;
				this.method_6(this.treeView.SelectedNode);
				return;
			}
			this.toolStripButtonHideTree.Text = "Показать дерево";
			this.splitContainer.Panel1Collapsed = true;
			string filter = this.toolStripButtonHideDelete.Checked ? "" : "Deleted = false";
			this.bindingSource_0.Filter = filter;
		}

		private void toolStripButtonFind_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonFindNext_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxFind.Text);
		}

		private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.dgvExcelFilter.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxFind.Text);
			}
		}

		private void toolStripButtonPrint_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.PrintDataGridView();
		}

		private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.CopyToExcel(true);
		}

		private void toolStripButtonRefresh_Click(object sender, EventArgs e)
		{
			base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tr_Division"], true);
			this.method_1(null);
		}

		private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.CopyToBuffer(false);
		}

		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.CopyToExcel(false);
		}

		private void toolStripMenuItemPrint_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.PrintDataGridView();
		}

		private void FormDivisions_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.formDivisionsAddEdit_0 != null)
			{
				this.formDivisionsAddEdit_0.DialogResult = DialogResult.Cancel;
				this.formDivisionsAddEdit_0.Close();
			}
		}

		private FormDivisionsAddEdit formDivisionsAddEdit_0;
	}
}
