using System;
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
	public partial class FormGroupWorker : FormBase
	{
		public FormGroupWorker()
		{
			
			
			this.InitializeComponent();
		}

		private void FormGroupWorker_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Division, true);
			base.SelectSqlData(this.class48_0, this.class48_0.tR_JobTitle, true);
			this.method_0(null);
		}

		private void method_0(TreeNode treeNode_0)
		{
			string str = this.toolBtnShowDeleteGroup.Checked ? "" : " and deleted = 0 ";
			base.SelectSqlData(this.class48_0, this.class48_0.tR_Classifier, true, " where ParentKey like ';GroupWorker;%' and isGRoup = 0 " + str + " order by name");
			this.treeViewGroup.Nodes.Clear();
			this.treeViewGroup.Nodes.Add("Группы");
			this.treeViewGroup.SelectedNode = this.treeViewGroup.Nodes[0];
			TreeNode treeNode = this.treeViewGroup.Nodes[0];
			foreach (object obj in this.class48_0.tR_Classifier.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				TreeNode treeNode2 = new TreeNode(dataRow["Name"].ToString());
				treeNode2.Tag = dataRow["Id"];
				treeNode.Nodes.Add(treeNode2);
				if (treeNode_0 != null && Convert.ToInt32(treeNode_0.Tag) == Convert.ToInt32(treeNode2.Tag))
				{
					this.treeViewGroup.SelectedNode = treeNode2;
					this.treeViewGroup.SelectedNode.Expand();
				}
			}
			this.treeViewGroup.Nodes[0].Expand();
		}

		private void toolBtnShowDeleteGroup_Click(object sender, EventArgs e)
		{
			this.toolBtnShowDeleteGroup.Text = (this.toolBtnShowDeleteGroup.Checked ? "Скрыть удаленных" : "Показать удаленных");
			this.method_0(this.treeViewGroup.SelectedNode);
		}

		private void toolTxtFindTreeGroup_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.toolBtnFindTreeGroup_Click(sender, e);
			}
		}

		private void toolBtnFindTreeGroup_Click(object sender, EventArgs e)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_1(this.treeViewGroup.Nodes, list_);
			TreeNode treeNode = this.method_2(list_, this.treeViewGroup.SelectedNode, this.toolTxtFindTreeGroup.Text);
			if (treeNode != null)
			{
				this.treeViewGroup.SelectedNode = treeNode;
				this.treeViewGroup.SelectedNode.Expand();
			}
		}

		private List<TreeNode> method_1(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_0)
		{
			foreach (object obj in treeNodeCollection_0)
			{
				TreeNode treeNode = (TreeNode)obj;
				list_0.Add(treeNode);
				list_0 = this.method_1(treeNode.Nodes, list_0);
			}
			return list_0;
		}

		private TreeNode method_2(List<TreeNode> list_0, TreeNode treeNode_0, string string_0)
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

		private void treeViewGroup_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.method_3();
		}

		private void method_3()
		{
			if (this.treeViewGroup.SelectedNode != this.treeViewGroup.Nodes[0])
			{
				int num = Convert.ToInt32(this.treeViewGroup.SelectedNode.Tag);
				base.SelectSqlData(this.class48_0, this.class48_0.tL_ClassifierWorker, true, " where idGroup = " + num.ToString());
				if (this.class48_0.tL_ClassifierWorker.Rows.Count > 0)
				{
					string text = "";
					foreach (object obj in this.class48_0.tL_ClassifierWorker.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						text = text + dataRow["idWorker"].ToString() + ",";
					}
					text = " where id in (" + text.Remove(text.Length - 1) + ") ";
					base.SelectSqlData(this.class48_0, this.class48_0.tR_Worker, true, text + " order by f, i, o");
					return;
				}
				this.class48_0.tR_Worker.Clear();
			}
		}

		private void toolBtnAddWorkerInGroup_Click(object sender, EventArgs e)
		{
			if (new FormGroupWorkerAdd((this.treeViewGroup.SelectedNode == this.treeViewGroup.Nodes[0]) ? -1 : Convert.ToInt32(this.treeViewGroup.SelectedNode.Tag))
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				this.method_3();
			}
		}

		private void toolBtnDelWorkerFromGroup_Click(object sender, EventArgs e)
		{
			if (this.treeViewGroup.SelectedNode != this.treeViewGroup.Nodes[0] && this.dgvGroupWorker.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить текущего сотрудника из группы?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.tL_ClassifierWorker, true, " where idGRoup = " + this.treeViewGroup.SelectedNode.Tag.ToString() + " and idWorker = " + this.dgvGroupWorker.CurrentRow.Cells["idDgvTxtColumn"].Value.ToString());
				if (this.class48_0.tL_ClassifierWorker.Rows.Count > 0 && base.DeleteSqlDataById(this.class48_0.tL_ClassifierWorker, Convert.ToInt32(this.class48_0.tL_ClassifierWorker.Rows[0]["Id"])))
				{
					this.method_3();
					MessageBox.Show("Сотрудник успешно удален из группы");
				}
			}
		}

		private void toolBtnShowDelWorker_Click(object sender, EventArgs e)
		{
			this.bindingSource_0.Filter = (this.toolBtnShowDelWorker.Checked ? "" : " DateEnd is null");
		}

		private void toolStripButtonFind_Click(object sender, EventArgs e)
		{
			this.dgvGroupWorker.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.toolStripTextBoxFind.Text);
		}

		private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.dgvGroupWorker.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxFind.Text);
			}
		}

		private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
		{
			this.dgvGroupWorker.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonFindNext_Click(object sender, EventArgs e)
		{
			this.dgvGroupWorker.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonPrint_Click(object sender, EventArgs e)
		{
			this.dgvGroupWorker.PrintDataGridView();
		}

		private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
		{
			this.dgvGroupWorker.CopyToExcel(true);
		}

		private void toolStripButtonRefresh_Click(object sender, EventArgs e)
		{
			this.method_0(this.treeViewGroup.SelectedNode);
		}

		private void dgvGroupWorker_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0 && this.dgvGroupWorker["dateEndDgvTxtColumn", e.RowIndex].Value != DBNull.Value)
			{
				e.CellStyle.ForeColor = Color.Red;
			}
		}
	}
}
