using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using Reference.Forms.Worker;
using Reference.Properties;

namespace Reference.Forms
{
	public partial class FormWorkers : FormBase
	{
		public FormWorkers()
		{
			
			
			this.InitializeComponent();
		}

		private void FormWorkers_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Division, true);
			this.method_0(null);
			base.SelectSqlData(this.class48_0, this.class48_0.tR_JobTitle, true);
			this.method_3(null);
			Class48 @class = new Class48();
			base.SelectSqlData(@class, @class.tR_Classifier, true, " where ParentKey LIKE '%;GroupWorker;%' and isGRoup = 0 and Deleted = 0 order by name");
			this.method_4(@class.tR_Classifier, null);
			string where = this.toolBtnShowWorkerDelete.Checked ? "" : " where DateEnd is null";
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Worker, true, where);
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Classifier, true, "where (parentKey in (';StatusWorker;', ';ReasonWorker;', ';Contact;')  or parentKey LIKE '%;GroupWorker;%') and isgroup = 0");
		}

		private void method_0(TreeNode treeNode_0)
		{
			this.treeViewDivision.Nodes.Clear();
			this.treeViewDivision.Nodes.Add("Все подразделения");
			this.treeViewDivision.SelectedNode = this.treeViewDivision.Nodes[0];
			TreeNode treeNode = this.treeViewDivision.Nodes[0];
			string str = this.toolBtnShowDeleteDivision.Checked ? "" : " and Deleted = false";
			foreach (DataRow dataRow in this.class48_0.DataTableCollection_0["tR_Division"].Select("ParentId is NULL" + str, "Description"))
			{
				TreeNode treeNode2 = new TreeNode(dataRow["Description"].ToString());
				treeNode2.Tag = dataRow["Id"];
				treeNode2.ImageKey = this.method_2(dataRow);
				treeNode2.SelectedImageKey = this.method_2(dataRow);
				treeNode.Nodes.Add(treeNode2);
				this.method_1(treeNode2, treeNode_0);
				if (treeNode_0 != null && Convert.ToInt32(treeNode_0.Tag) == Convert.ToInt32(treeNode2.Tag))
				{
					this.treeViewDivision.SelectedNode = treeNode2;
					this.treeViewDivision.SelectedNode.Expand();
				}
			}
			this.treeViewDivision.Nodes[0].Expand();
		}

		private void method_1(TreeNode treeNode_0, TreeNode treeNode_1)
		{
			string str = this.toolBtnShowDeleteDivision.Checked ? "" : " and Deleted = false";
			foreach (DataRow dataRow in this.class48_0.DataTableCollection_0["tR_Division"].Select("ParentId = " + treeNode_0.Tag.ToString() + str, "Description ASC"))
			{
				TreeNode treeNode = new TreeNode(dataRow["Description"].ToString());
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageKey = this.method_2(dataRow);
				treeNode.SelectedImageKey = this.method_2(dataRow);
				treeNode_0.Nodes.Add(treeNode);
				this.method_1(treeNode, treeNode_1);
				if (treeNode_1 != null && Convert.ToInt32(treeNode_1.Tag) == Convert.ToInt32(treeNode.Tag))
				{
					this.treeViewDivision.SelectedNode = treeNode;
					this.treeViewDivision.SelectedNode.Expand();
				}
			}
		}

		private string method_2(DataRow dataRow_0)
		{
			if (Convert.ToBoolean(dataRow_0["Deleted"]))
			{
				return "FolderDeleteYellow.png";
			}
			string str = this.toolBtnShowDeleteDivision.Checked ? "" : " and Deleted = false";
			if (this.class48_0.DataTableCollection_0["tR_Division"].Select("ParentId = " + dataRow_0["id"].ToString() + str).Length != 0)
			{
				return "FolderDocumentYellow.png";
			}
			return "FolderYellow.png";
		}

		private void method_3(TreeNode treeNode_0)
		{
			this.treeViewJobTitles.Nodes.Clear();
			this.treeViewJobTitles.Nodes.Add("Все должности");
			this.treeViewJobTitles.SelectedNode = this.treeViewJobTitles.Nodes[0];
			TreeNode treeNode = this.treeViewJobTitles.Nodes[0];
			string filterExpression = this.WovakdZmwK.Checked ? "" : " Deleted = false";
			foreach (DataRow dataRow in this.class48_0.DataTableCollection_0["tR_JobTitle"].Select(filterExpression, "Description, Razrjad"))
			{
				TreeNode treeNode2 = new TreeNode(string.IsNullOrEmpty(dataRow["RName"].ToString().Trim()) ? dataRow["Description"].ToString() : (dataRow["Description"].ToString() + " " + dataRow["Razrjad"].ToString()));
				treeNode2.Tag = dataRow["Id"];
				treeNode.Nodes.Add(treeNode2);
				if (treeNode_0 != null && Convert.ToInt32(treeNode_0.Tag) == Convert.ToInt32(treeNode2.Tag))
				{
					this.treeViewJobTitles.SelectedNode = treeNode2;
					this.treeViewJobTitles.SelectedNode.Expand();
				}
			}
			this.treeViewJobTitles.Nodes[0].Expand();
		}

		private void method_4(DataTable dataTable_0, TreeNode treeNode_0)
		{
			this.treeViewGroupWorker.Nodes.Clear();
			this.treeViewGroupWorker.Nodes.Add("Все группы");
			this.treeViewGroupWorker.SelectedNode = this.treeViewGroupWorker.Nodes[0];
			TreeNode treeNode = this.treeViewGroupWorker.Nodes[0];
			string filterExpression = this.toolBtnShowDeleteGroupWorker.Checked ? "" : " Deleted = false";
			foreach (DataRow dataRow in dataTable_0.Select(filterExpression, "Name"))
			{
				TreeNode treeNode2 = new TreeNode(dataRow["Name"].ToString());
				treeNode2.Tag = dataRow["Id"];
				treeNode.Nodes.Add(treeNode2);
				if (treeNode_0 != null && Convert.ToInt32(treeNode_0.Tag) == Convert.ToInt32(treeNode2.Tag))
				{
					this.treeViewGroupWorker.SelectedNode = treeNode2;
					this.treeViewGroupWorker.SelectedNode.Expand();
				}
			}
			this.treeViewGroupWorker.Nodes[0].Expand();
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
			this.method_0(this.treeViewDivision.SelectedNode);
		}

		private void toolTxtFindTreeDivision_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.toolBtnFindTreeDivision_Click(sender, e);
			}
		}

		private void toolBtnFindTreeDivision_Click(object sender, EventArgs e)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_5(this.treeViewDivision.Nodes, list_);
			TreeNode treeNode = this.method_6(list_, this.treeViewDivision.SelectedNode, this.toolTxtFindTreeDivision.Text);
			if (treeNode != null)
			{
				this.treeViewDivision.SelectedNode = treeNode;
				this.treeViewDivision.SelectedNode.Expand();
			}
		}

		private List<TreeNode> method_5(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_0)
		{
			foreach (object obj in treeNodeCollection_0)
			{
				TreeNode treeNode = (TreeNode)obj;
				list_0.Add(treeNode);
				list_0 = this.method_5(treeNode.Nodes, list_0);
			}
			return list_0;
		}

		private TreeNode method_6(List<TreeNode> list_0, TreeNode treeNode_0, string string_0)
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

		private void toolBtnCloseDivision_Click(object sender, EventArgs e)
		{
			this.toolBtnShowDivision.Checked = false;
			this.toolBtnShowDivision.Text = "Показать подразделения";
			this.tabControlTree.TabPages.Remove(this.tabPageDivision);
			if (this.tabControlTree.TabPages.Count == 0)
			{
				this.splitContainerMain.Panel1Collapsed = true;
			}
		}

		private void WovakdZmwK_Click(object sender, EventArgs e)
		{
			if (this.WovakdZmwK.Checked)
			{
				this.WovakdZmwK.Text = "Скрыть удаленных";
			}
			else
			{
				this.WovakdZmwK.Text = "Показать удаленных";
			}
			this.method_3(this.treeViewJobTitles.SelectedNode);
		}

		private void toolTxtFindTreeJobTitles_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.toolBtnFindTreeJobTitles_Click(sender, e);
			}
		}

		private void toolBtnFindTreeJobTitles_Click(object sender, EventArgs e)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_5(this.treeViewJobTitles.Nodes, list_);
			TreeNode treeNode = this.method_6(list_, this.treeViewJobTitles.SelectedNode, this.toolTxtFindTreeJobTitles.Text);
			if (treeNode != null)
			{
				this.treeViewJobTitles.SelectedNode = treeNode;
				this.treeViewJobTitles.SelectedNode.Expand();
			}
		}

		private void toolBtnCloseJobTitles_Click(object sender, EventArgs e)
		{
			this.toolBtnShowJobTitle.Checked = false;
			this.toolBtnShowJobTitle.Text = "Показать должности";
			this.tabControlTree.TabPages.Remove(this.tabPageJobTitles);
			if (this.tabControlTree.TabPages.Count == 0)
			{
				this.splitContainerMain.Panel1Collapsed = true;
			}
		}

		private void toolBtnShowDeleteGroupWorker_Click(object sender, EventArgs e)
		{
			if (this.toolBtnShowDeleteGroupWorker.Checked)
			{
				this.toolBtnShowDeleteGroupWorker.Text = "Скрыть удаленных";
			}
			else
			{
				this.toolBtnShowDeleteGroupWorker.Text = "Показать удаленных";
			}
			Class48 @class = new Class48();
			base.SelectSqlData(@class, @class.tR_Classifier, true, " where ParentKey LIKE '%;GroupWorker;%' and isGRoup = 0 order by name");
			this.method_4(@class.tR_Classifier, this.treeViewGroupWorker.SelectedNode);
		}

		private void toolTxtFindTreeGroupWorker_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.toolBtnFindTreeGroupWorker_Click(sender, e);
			}
		}

		private void toolBtnFindTreeGroupWorker_Click(object sender, EventArgs e)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_5(this.treeViewGroupWorker.Nodes, list_);
			TreeNode treeNode = this.method_6(list_, this.treeViewGroupWorker.SelectedNode, this.toolTxtFindTreeGroupWorker.Text);
			if (treeNode != null)
			{
				this.treeViewGroupWorker.SelectedNode = treeNode;
				this.treeViewGroupWorker.SelectedNode.Expand();
			}
		}

		private void toolBtnCloseGRoupWorker_Click(object sender, EventArgs e)
		{
			this.toolBtnShowGroupWorker.Checked = false;
			this.toolBtnShowGroupWorker.Text = "Показать группы";
			this.tabControlTree.TabPages.Remove(this.tabPageGroupWorkerTree);
			if (this.tabControlTree.TabPages.Count == 0)
			{
				this.splitContainerMain.Panel1Collapsed = true;
			}
		}

		private void treeViewDivision_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.method_7(e.Node);
		}

		private void method_7(TreeNode treeNode_0)
		{
			if (treeNode_0.IsSelected)
			{
				if (treeNode_0 == this.treeViewDivision.Nodes[0])
				{
					this.bindingSource_0.Filter = "";
				}
				else
				{
					this.bindingSource_0.Filter = "DivisionCurrent = " + treeNode_0.Tag.ToString();
				}
			}
			this.bindingSource_0.Sort = "F, I, O, DateBegin";
		}

		private void treeViewJobTitles_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.method_8(e.Node);
		}

		private void method_8(TreeNode treeNode_0)
		{
			if (treeNode_0.IsSelected)
			{
				if (treeNode_0 == this.treeViewJobTitles.Nodes[0])
				{
					this.bindingSource_0.Filter = "";
				}
				else
				{
					this.bindingSource_0.Filter = "JobTitle = " + treeNode_0.Tag.ToString();
				}
			}
			this.bindingSource_0.Sort = "F, I, O, DateBegin";
		}

		private void treeViewGroupWorker_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.method_9(e.Node);
		}

		private void method_9(TreeNode treeNode_0)
		{
			if (treeNode_0.IsSelected)
			{
				if (treeNode_0 == this.treeViewGroupWorker.Nodes[0])
				{
					this.bindingSource_0.Filter = "";
				}
				else
				{
					Class48 @class = new Class48();
					base.SelectSqlData(@class, @class.tL_ClassifierWorker, true, "where IdGroup = " + treeNode_0.Tag.ToString());
					string text = "";
					foreach (object obj in @class.tL_ClassifierWorker.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						text = text + dataRow["IdWorker"].ToString() + ",";
					}
					if (text != "")
					{
						this.bindingSource_0.Filter = "Id in (" + text.Remove(text.Length - 1) + ")";
					}
					else
					{
						this.bindingSource_0.Filter = "Id = -1";
					}
				}
			}
			this.bindingSource_0.Sort = "F, I, O, DateBegin";
		}

		private void toolBtnShowDivision_Click(object sender, EventArgs e)
		{
			if (this.toolBtnShowDivision.Checked)
			{
				this.toolBtnShowDivision.Text = "Скрыть подразделения";
				this.tabControlTree.TabPages.Insert(0, this.tabPageDivision);
				this.tabControlTree.SelectedTab = this.tabPageDivision;
				this.treeViewDivision.SelectedNode = this.treeViewDivision.Nodes[0];
				this.method_7(this.treeViewDivision.SelectedNode);
				this.splitContainerMain.Panel1Collapsed = false;
				return;
			}
			this.toolBtnShowDivision.Text = "Показать подразделения";
			this.tabControlTree.TabPages.Remove(this.tabPageDivision);
			if (this.tabControlTree.TabPages.Count == 0)
			{
				this.splitContainerMain.Panel1Collapsed = true;
			}
		}

		private void toolBtnShowJobTitle_Click(object sender, EventArgs e)
		{
			if (this.toolBtnShowJobTitle.Checked)
			{
				this.toolBtnShowJobTitle.Text = "Скрыть должности";
				this.tabControlTree.TabPages.Add(this.tabPageJobTitles);
				this.tabControlTree.SelectedTab = this.tabPageJobTitles;
				this.treeViewJobTitles.SelectedNode = this.treeViewJobTitles.Nodes[0];
				this.method_8(this.treeViewJobTitles.SelectedNode);
				this.splitContainerMain.Panel1Collapsed = false;
				return;
			}
			this.toolBtnShowJobTitle.Text = "Показать должности";
			this.tabControlTree.TabPages.Remove(this.tabPageJobTitles);
			if (this.tabControlTree.TabPages.Count == 0)
			{
				this.splitContainerMain.Panel1Collapsed = true;
			}
		}

		private void toolBtnShowGroupWorker_Click(object sender, EventArgs e)
		{
			if (this.toolBtnShowGroupWorker.Checked)
			{
				this.toolBtnShowGroupWorker.Text = "Скрыть группы";
				this.tabControlTree.TabPages.Add(this.tabPageGroupWorkerTree);
				this.tabControlTree.SelectedTab = this.tabPageGroupWorkerTree;
				this.treeViewGroupWorker.SelectedNode = this.treeViewGroupWorker.Nodes[0];
				this.splitContainerMain.Panel1Collapsed = false;
				return;
			}
			this.toolBtnShowGroupWorker.Text = "Показать группы";
			this.tabControlTree.TabPages.Remove(this.tabPageGroupWorkerTree);
			if (this.tabControlTree.TabPages.Count == 0)
			{
				this.splitContainerMain.Panel1Collapsed = true;
			}
		}

		private void toolBtnShowWorkerDelete_Click(object sender, EventArgs e)
		{
			if (this.toolBtnShowWorkerDelete.Checked)
			{
				this.toolBtnShowWorkerDelete.Text = "Скрыть уволенных сотрудников";
				base.SelectSqlData(this.class48_0, this.class48_0.tR_Worker, true);
				return;
			}
			this.toolBtnShowWorkerDelete.Text = "Показать уволенных сотрудников";
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Worker, true, " where dateEnd is null");
		}

		private void toolStripButtonFind_Click(object sender, EventArgs e)
		{
			this.dgvWorker.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.toolStripTextBoxFind.Text);
		}

		private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.dgvWorker.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxFind.Text);
			}
		}

		private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
		{
			this.dgvWorker.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonFindNext_Click(object sender, EventArgs e)
		{
			this.dgvWorker.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonPrint_Click(object sender, EventArgs e)
		{
			this.dgvWorker.PrintDataGridView();
		}

		private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
		{
			this.dgvWorker.CopyToExcel(true);
		}

		private void toolStripButtonRefresh_Click(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Division, true);
			this.method_0(this.treeViewDivision.SelectedNode);
			base.SelectSqlData(this.class48_0, this.class48_0.tR_JobTitle, true);
			this.method_3(this.treeViewJobTitles.SelectedNode);
			Class48 @class = new Class48();
			base.SelectSqlData(@class, @class.tR_Classifier, true, " where ParentKey LIKE '%;GroupWorker;%' and isGRoup = 0 order by name");
			this.method_4(@class.tR_Classifier, null);
			string where = this.toolBtnShowWorkerDelete.Checked ? "" : " where DateEnd is null";
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Worker, true, where);
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Classifier, true, "where (parentKey in (';StatusWorker;', ';ReasonWorker;', ';Contact;')  or parentKey LIKE '%;GroupWorker;%') and isgroup = 0");
		}

		private void toolBtnPadez_Click(object sender, EventArgs e)
		{
			if (this.dgvWorker.CurrentRow != null)
			{
				new FormWorkerAddEditPadez(Convert.ToInt32(this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value))
				{
					SqlSettings = this.SqlSettings
				}.ShowDialog();
			}
		}

		private void tabControlTree_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.tabControlTree.SelectedTab == this.tabPageDivision)
			{
				this.method_7(this.treeViewDivision.SelectedNode);
			}
			if (this.tabControlTree.SelectedTab == this.tabPageJobTitles)
			{
				this.method_8(this.treeViewJobTitles.SelectedNode);
			}
		}

		private void dgvWorker_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dgvWorker.Rows.Count > 0)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.tJ_StatusWorker, true, "where worker = " + this.dgvWorker["idDgvWorkerTextBoxColumn", e.RowIndex].Value.ToString());
				base.SelectSqlData(this.class48_0, this.class48_0.tR_WorkerContact, true, "where worker = " + this.dgvWorker["idDgvWorkerTextBoxColumn", e.RowIndex].Value.ToString());
				base.SelectSqlData(this.class48_0, this.class48_0.tL_ClassifierWorker, true, "where Idworker = " + this.dgvWorker["idDgvWorkerTextBoxColumn", e.RowIndex].Value.ToString());
				base.SelectSqlData(this.class48_0, this.class48_0.tJ_GroupElectricalWorker, true, "where Idworker = " + this.dgvWorker["idDgvWorkerTextBoxColumn", e.RowIndex].Value.ToString());
				this.method_10();
				return;
			}
			this.class48_0.tR_WorkerContact.Clear();
			this.class48_0.tJ_StatusWorker.Clear();
			this.class48_0.tL_ClassifierWorker.Clear();
			this.class48_0.tJ_GroupElectricalWorker.Clear();
		}

		private void dgvWorker_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			if (this.dgvWorker.Rows.Count == 0)
			{
				this.class48_0.tJ_StatusWorker.Clear();
				this.class48_0.tJ_GroupElectricalWorker.Clear();
				this.class48_0.tR_WorkerContact.Clear();
			}
		}

		private void dgvWorker_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
		}

		private void dgvWorker_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0 && this.dgvWorker["dateEndDgvTextBoxColumn", e.RowIndex].Value.ToString() != "")
			{
				e.CellStyle.ForeColor = Color.Red;
			}
		}

		private void dgvWorker_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			try
			{
				e.ThrowException = false;
				e.Cancel = true;
				if (e.ColumnIndex >= 0 && e.ColumnIndex < ((DataGridView)sender).Columns.Count && e.RowIndex >= 0 && e.RowIndex < ((DataGridView)sender).Rows.Count)
				{
					((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = e.Exception.Message;
				}
			}
			catch (Exception)
			{
			}
		}

		private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			if (this.treeViewDivision.SelectedNode.Text == "Другие" && this.treeViewDivision.SelectedNode.Level == 1 && this.tabControlTree.SelectedTab == this.tabPageDivision)
			{
				this.toolMenuAddWorker.Visible = true;
				this.toolMenuDelWorker.Visible = true;
				this.toolMenuEditWorker.Visible = true;
				this.toolStripSeparatorEditWorker.Visible = true;
				return;
			}
			this.toolMenuAddWorker.Visible = false;
			this.toolMenuDelWorker.Visible = false;
			this.toolMenuEditWorker.Visible = false;
			this.toolStripSeparatorEditWorker.Visible = false;
		}

		private void toolMenuItemCopyWorker_Click(object sender, EventArgs e)
		{
			this.dgvWorker.CopyToBuffer(false);
		}

		private void toolMenuItemExportToExcelWorker_Click(object sender, EventArgs e)
		{
			this.dgvWorker.CopyToExcel(false);
		}

		private void toolMenuItemPrintWorker_Click(object sender, EventArgs e)
		{
			this.dgvWorker.PrintDataGridView();
		}

		private void toolMenuAddWorker_Click(object sender, EventArgs e)
		{
			if (new FormWorkerAddEdit(-1, Convert.ToInt32(this.treeViewDivision.SelectedNode.Tag))
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				string where = this.toolBtnShowWorkerDelete.Checked ? "" : " where DateEnd is null";
				base.SelectSqlData(this.class48_0, this.class48_0.tR_Worker, true, where);
			}
		}

		private void toolMenuEditWorker_Click(object sender, EventArgs e)
		{
			if (this.dgvWorker.CurrentRow != null && new FormWorkerAddEdit(Convert.ToInt32(this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value), Convert.ToInt32(this.treeViewDivision.SelectedNode.Tag))
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				string where = this.toolBtnShowWorkerDelete.Checked ? "" : " where DateEnd is null";
				base.SelectSqlData(this.class48_0, this.class48_0.tR_Worker, true, where);
			}
		}

		private void toolMenuDateEndWorker_Click(object sender, EventArgs e)
		{
			if (this.dgvWorker.CurrentRow != null)
			{
				Class48 @class = new Class48();
				base.SelectSqlData(@class, @class.tR_Worker, true, "where id = " + this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value.ToString());
				if (@class.tR_Worker.Rows.Count > 0)
				{
					@class.tR_Worker.Rows[0]["DateEnd"] = @class.tR_Worker.Rows[0]["DateBegin"];
					@class.tR_Worker.Rows[0].EndEdit();
					base.UpdateSqlData(@class, @class.tR_Worker);
					string where = this.toolBtnShowWorkerDelete.Checked ? "" : " where DateEnd is null";
					base.SelectSqlData(this.class48_0, this.class48_0.tR_Worker, true, where);
				}
			}
		}

		private void toolMenuDelFullWorker_Click(object sender, EventArgs e)
		{
			if (this.dgvWorker.CurrentRow != null)
			{
				base.DeleteSqlDataById(this.class48_0.tR_Worker, Convert.ToInt32(this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value));
				this.dgvWorker.Rows.Remove(this.dgvWorker.CurrentRow);
			}
		}

		private void dgvHistory_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if (this.dgvHistory.Rows.Count > 0)
			{
				this.dgvHistory.ContextMenuStrip = this.contextMenuStrip_2;
			}
		}

		private void dgvHistory_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			if (this.dgvHistory.Rows.Count == 0)
			{
				this.dgvHistory.ContextMenuStrip = null;
			}
		}

		private void dgvHistory_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			try
			{
				e.ThrowException = false;
				e.Cancel = true;
				if (e.ColumnIndex >= 0 && e.ColumnIndex < this.dgvHistory.Columns.Count && e.RowIndex >= 0 && e.RowIndex < this.dgvHistory.Rows.Count)
				{
					this.dgvHistory.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Ошибка";
				}
			}
			catch (Exception)
			{
			}
		}

		private void toolMenuItemCopyHistory_Click(object sender, EventArgs e)
		{
			this.dgvHistory.CopyToBuffer(false);
		}

		private void toolMenuItemExportToExcelHistory_Click(object sender, EventArgs e)
		{
			this.dgvHistory.CopyToExcel(false);
		}

		private void toolMenuItemPrintHistory_Click(object sender, EventArgs e)
		{
			this.dgvHistory.PrintDataGridView();
		}

		private void dgvContact_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
		}

		private void dgvContact_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
		}

		private void dgvContact_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0 && Convert.ToBoolean(this.dgvContact["kadrExportDgvCheckBoxColumn", e.RowIndex].Value))
			{
				e.CellStyle.ForeColor = Color.Blue;
			}
		}

		private void toolMenuItemCopyContact_Click(object sender, EventArgs e)
		{
			this.dgvContact.CopyToBuffer(false);
		}

		private void toolMenuItemExportToExcelContact_Click(object sender, EventArgs e)
		{
			this.dgvContact.CopyToExcel(false);
		}

		private void toolMenuItemPrintContact_Click(object sender, EventArgs e)
		{
			this.dgvContact.PrintDataGridView();
		}

		private void toolBtnAddContact_Click(object sender, EventArgs e)
		{
			if (new FormWorkerContactAddEdit(-1, Convert.ToInt32(this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value), true)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.tR_WorkerContact, true, "where worker = " + this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value.ToString());
				MessageBox.Show("Контактная информация успешно добавлена");
			}
		}

		private void toolBtnEditContact_Click(object sender, EventArgs e)
		{
			if (Convert.ToBoolean(this.dgvContact.CurrentRow.Cells["kadrExportDgvCheckBoxColumn"].Value))
			{
				MessageBox.Show("Данные были загружены из отдела кадров. Редактирование невозможно.", "Ошибка");
				return;
			}
			if (new FormWorkerContactAddEdit(Convert.ToInt32(this.dgvContact.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value), Convert.ToInt32(this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value), false)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.tR_WorkerContact, true, "where worker = " + this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value.ToString());
				MessageBox.Show("Контактная информация успешно изменена");
			}
		}

		private void toolBtnDelContact_Click(object sender, EventArgs e)
		{
			if (Convert.ToBoolean(this.dgvContact.CurrentRow.Cells["kadrExportDgvCheckBoxColumn"].Value))
			{
				MessageBox.Show("Данные были загружены из отдела кадров. Удаление невозможно.", "Ошибка");
				return;
			}
			if (MessageBox.Show("Вы действительно хотите удалить текущую запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.dgvContact.Rows.Remove(this.dgvContact.CurrentRow);
				this.dgvContact.EndEdit();
				base.DeleteSqlData(this.class48_0, this.class48_0.tR_WorkerContact);
				MessageBox.Show("Данные успешно удалены");
			}
		}

		private void toolManuItemAddGroupWorker_Click(object sender, EventArgs e)
		{
			FormWorkerGroupAddEdit formWorkerGroupAddEdit;
			if (this.dgvWorker.SelectedRows.Count < 2)
			{
				formWorkerGroupAddEdit = new FormWorkerGroupAddEdit(-1, Convert.ToInt32(this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value));
			}
			else
			{
				List<int> list = new List<int>();
				foreach (object obj in this.dgvWorker.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					list.Add(Convert.ToInt32(dataGridViewRow.Cells["idDgvWorkerTextBoxColumn"].Value));
				}
				formWorkerGroupAddEdit = new FormWorkerGroupAddEdit(-1, list);
			}
			formWorkerGroupAddEdit.SqlSettings = this.SqlSettings;
			if (formWorkerGroupAddEdit.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.tL_ClassifierWorker, true, "where Idworker = " + this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value.ToString());
				MessageBox.Show("Группа успешно добавлена");
			}
		}

		private void toolMenuItemEditGroupWorker_Click(object sender, EventArgs e)
		{
			if (new FormWorkerGroupAddEdit(Convert.ToInt32(this.dgvGroupWorker.CurrentRow.Cells["idDataGridViewTextBoxColumn2"].Value), Convert.ToInt32(this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value))
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.tL_ClassifierWorker, true, "where Idworker = " + this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value.ToString());
				MessageBox.Show("Группа успешно изменена");
			}
		}

		private void toolMenuItemDelGroupWorker_Click(object sender, EventArgs e)
		{
			if (this.dgvGroupWorker.CurrentRow == null)
			{
				return;
			}
			if (MessageBox.Show("Вы действительно хотите удалить текущую запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.dgvGroupWorker.Rows.Remove(this.dgvGroupWorker.CurrentRow);
				this.dgvGroupWorker.EndEdit();
				base.DeleteSqlData(this.class48_0, this.class48_0.tL_ClassifierWorker);
				MessageBox.Show("Данные успешно удалены");
			}
		}

		private void toolBtnAddGroup_Click(object sender, EventArgs e)
		{
			this.toolManuItemAddGroupWorker_Click(sender, e);
		}

		private void toolBtnEditGroup_Click(object sender, EventArgs e)
		{
			this.toolMenuItemEditGroupWorker_Click(sender, e);
		}

		private void CnlibZbwCb_Click(object sender, EventArgs e)
		{
			this.toolMenuItemDelGroupWorker_Click(sender, e);
		}

		private void method_10()
		{
			object obj = this.class48_0.tJ_GroupElectricalWorker.Compute("max(dateBegin)", "");
			DataRow[] array = this.class48_0.tJ_GroupElectricalWorker.Select("datebegin = '" + obj.ToString() + "'");
			if (array.Length != 0 && (array[0]["DateEnd"] == DBNull.Value || Convert.ToDateTime(array[0]["DateEnd"]) > DateTime.Now))
			{
				this.txtCurrentgroupElectrical.Text = array[0]["GroupElectrical"].ToString();
				return;
			}
			this.txtCurrentgroupElectrical.Text = "";
		}

		private void toolMenuAddGroupElectrical_Click(object sender, EventArgs e)
		{
			object obj = this.class48_0.tJ_GroupElectricalWorker.Compute("max(dateBegin)", "");
			DataRow[] array = this.class48_0.tJ_GroupElectricalWorker.Select("datebegin = '" + obj.ToString() + "'");
			if (array.Length != 0 && array[0]["DateEnd"] == DBNull.Value)
			{
				MessageBox.Show("Последняя группа допуска не имеет даты окончания");
				return;
			}
			if (new FormWorkerGroupElectricalAddEdit(-1, Convert.ToInt32(this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value))
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.tJ_GroupElectricalWorker, true, "where Idworker = " + this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value.ToString());
				this.method_10();
				MessageBox.Show("Группа успешно добавлена");
			}
		}

		private void toolMenuEditGroupElectrical_Click(object sender, EventArgs e)
		{
			if (this.dgvGroupElectrical.CurrentRow == null)
			{
				MessageBox.Show("Не выбрана запись для удаления");
				return;
			}
			if (new FormWorkerGroupElectricalAddEdit(Convert.ToInt32(this.dgvGroupElectrical.CurrentRow.Cells["idDgvGroupElectricalColumn"].Value), Convert.ToInt32(this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value))
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.tJ_GroupElectricalWorker, true, "where Idworker = " + this.dgvWorker.CurrentRow.Cells["idDgvWorkerTextBoxColumn"].Value.ToString());
				this.method_10();
				MessageBox.Show("Группа успешно изменена");
			}
		}

		private void toolMenuDelGroupElectrical_Click(object sender, EventArgs e)
		{
			if (this.dgvGroupElectrical.CurrentRow == null)
			{
				MessageBox.Show("Не выбрана запись для удаления");
				return;
			}
			if (MessageBox.Show("Вы действительно хотите удалить текущую запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.dgvGroupElectrical.Rows.Remove(this.dgvGroupElectrical.CurrentRow);
				this.dgvGroupElectrical.EndEdit();
				base.DeleteSqlData(this.class48_0, this.class48_0.tJ_GroupElectricalWorker);
				MessageBox.Show("Данные успешно удалены");
			}
		}

		private void toolBtnAddGroupElectrical_Click(object sender, EventArgs e)
		{
			this.toolMenuAddGroupElectrical_Click(sender, e);
		}

		private void SapixrypWu_Click(object sender, EventArgs e)
		{
			this.toolMenuEditGroupElectrical_Click(sender, e);
		}

		private void toolBtnDelGroupElectrical_Click(object sender, EventArgs e)
		{
			this.toolMenuDelGroupElectrical_Click(sender, e);
		}
	}
}
