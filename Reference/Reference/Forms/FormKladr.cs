using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;

namespace Reference.Forms
{
	public partial class FormKladr : FormBase
	{
		public FormKladr()
		{
			
			
			this.InitializeComponent();
		}

		private void FormKladr_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrObj, true);
			this.method_0(null);
		}

		private void method_0(TreeNode treeNode_0)
		{
			this.treeViewPunkts.Nodes.Clear();
			string str = this.toolBtnShowDeletePunkts.Checked ? "" : " and deleted = false";
			foreach (DataRow dataRow in this.yoidejFsp2.tR_KladrObj.Select("ParentId is NULL" + str, "name"))
			{
				TreeNode treeNode = new TreeNode(dataRow["Name"].ToString() + " " + dataRow["Socr"].ToString());
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageKey = this.method_2(dataRow);
				treeNode.SelectedImageKey = this.method_2(dataRow);
				treeNode.ContextMenuStrip = this.contextMenuTreeView;
				this.treeViewPunkts.Nodes.Add(treeNode);
				this.method_1(treeNode, treeNode_0);
				if (treeNode_0 != null && Convert.ToInt32(treeNode_0.Tag) == Convert.ToInt32(treeNode.Tag))
				{
					this.treeViewPunkts.SelectedNode = treeNode;
					this.treeViewPunkts.SelectedNode.Expand();
				}
			}
			this.treeViewPunkts.Nodes[0].Expand();
		}

		private void method_1(TreeNode treeNode_0, TreeNode treeNode_1)
		{
			string str = this.toolBtnShowDeletePunkts.Checked ? "" : " and Deleted = false";
			foreach (DataRow dataRow in this.yoidejFsp2.tR_KladrObj.Select("ParentId = " + treeNode_0.Tag.ToString() + str, "Name ASC"))
			{
				TreeNode treeNode = new TreeNode(dataRow["Name"].ToString() + " " + dataRow["Socr"].ToString());
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageKey = this.method_2(dataRow);
				treeNode.SelectedImageKey = this.method_2(dataRow);
				treeNode.ContextMenuStrip = this.contextMenuTreeView;
				treeNode_0.Nodes.Add(treeNode);
				this.method_1(treeNode, treeNode_1);
				if (treeNode_1 != null && Convert.ToInt32(treeNode_1.Tag) == Convert.ToInt32(treeNode.Tag))
				{
					this.treeViewPunkts.SelectedNode = treeNode;
					this.treeViewPunkts.SelectedNode.Expand();
				}
			}
		}

		private string method_2(DataRow dataRow_0)
		{
			if (!Convert.ToBoolean(dataRow_0["Deleted"]))
			{
				return "FolderDocumentYellow.png";
			}
			return "FolderDeleteYellow.png";
		}

		private void treeViewPunkts_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node.IsSelected)
			{
				base.SelectSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrStreet, true, "where KladrObjId = " + e.Node.Tag.ToString() + " order by name, socr");
				base.SelectSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrDoma, true, "where streetId in (select id from tr_kladrstreet where kladrobjid = " + e.Node.Tag.ToString() + ")");
			}
		}

		private void treeViewPunkts_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				((TreeView)sender).SelectedNode = ((TreeView)sender).GetNodeAt(e.X, e.Y);
			}
		}

		private void toolBtnShowDeletePunkts_Click(object sender, EventArgs e)
		{
			this.method_0(this.treeViewPunkts.SelectedNode);
		}

		private void toolBtnFindPunkts_Click(object sender, EventArgs e)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_3(this.treeViewPunkts.Nodes, list_);
			TreeNode treeNode = this.method_4(list_, this.treeViewPunkts.SelectedNode, this.toolTextBoxFindPunkts.Text);
			if (treeNode != null)
			{
				this.treeViewPunkts.SelectedNode = treeNode;
				this.treeViewPunkts.SelectedNode.Expand();
			}
		}

		private List<TreeNode> method_3(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_0)
		{
			foreach (object obj in treeNodeCollection_0)
			{
				TreeNode treeNode = (TreeNode)obj;
				list_0.Add(treeNode);
				list_0 = this.method_3(treeNode.Nodes, list_0);
			}
			return list_0;
		}

		private TreeNode method_4(List<TreeNode> list_0, TreeNode treeNode_0, string string_0)
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

		private void toolTextBoxFindPunkts_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.toolBtnFindPunkts_Click(sender, e);
			}
		}

		private void toolBtnAddPunkts_Click(object sender, EventArgs e)
		{
			if (new FormKladrAddEditPunkts(-1, (int)this.treeViewPunkts.SelectedNode.Tag)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrObj, true);
				this.method_0(this.treeViewPunkts.SelectedNode);
			}
		}

		private void toolBtnEditPunkts_Click(object sender, EventArgs e)
		{
			int int_ = (this.treeViewPunkts.SelectedNode.Level == 0) ? -1 : ((int)this.treeViewPunkts.SelectedNode.Parent.Tag);
			if (new FormKladrAddEditPunkts((int)this.treeViewPunkts.SelectedNode.Tag, int_)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrObj, true);
				this.method_0(this.treeViewPunkts.SelectedNode);
			}
		}

		private void toolBtnDelPunkts_Click(object sender, EventArgs e)
		{
			int int_ = Convert.ToInt32(this.treeViewPunkts.SelectedNode.Tag);
			if (!Convert.ToBoolean(this.yoidejFsp2.tR_KladrObj.Select("ID = " + int_.ToString())[0]["Deleted"]))
			{
				if (MessageBox.Show("Вы действительно хотите пометить на удаление текущий населенный пункт?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					this.yoidejFsp2.tR_KladrObj.method_2(int_).Deleted = true;
					this.yoidejFsp2.tR_KladrObj.method_2(int_).EndEdit();
					base.UpdateSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrObj);
					this.method_0(this.treeViewPunkts.SelectedNode);
					MessageBox.Show("Выбранный населенный пункт успешно помечен на удаление");
					return;
				}
			}
			else if (MessageBox.Show("Вы действительно хотите восстановить текущий населенный пункт?", "Восстановление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.yoidejFsp2.tR_KladrObj.method_2(int_).Deleted = false;
				this.yoidejFsp2.tR_KladrObj.method_2(int_).EndEdit();
				base.UpdateSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrObj);
				this.method_0(this.treeViewPunkts.SelectedNode);
				MessageBox.Show("Выбранный населенный пункт успешно восстановлен");
			}
		}

		private void toolBtnDelPunktsFull_Click(object sender, EventArgs e)
		{
			int int_ = Convert.ToInt32(this.treeViewPunkts.SelectedNode.Tag);
			this.yoidejFsp2.tR_KladrObj.Select("ID = " + int_.ToString());
			if (MessageBox.Show("Вы действительно хотите удалить текущий населенный пункт?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.yoidejFsp2.tR_KladrObj.method_2(int_).Delete();
				base.DeleteSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrObj);
				this.method_0(this.treeViewPunkts.SelectedNode);
				MessageBox.Show("Выбранный населенный пункт успешно удален");
			}
		}

		private void toolBtnAddStreet_Click(object sender, EventArgs e)
		{
			if (new FormKladrAddEditStreet(-1, (int)this.treeViewPunkts.SelectedNode.Tag)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrStreet, true, "where KladrObjId = " + this.treeViewPunkts.SelectedNode.Tag.ToString());
				base.SelectSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrDoma, true, "where streetId in (select id from tr_kladrstreet where kladrobjid = " + this.treeViewPunkts.SelectedNode.Tag.ToString() + ")");
			}
		}

		private void toolBtnEditStreet_Click(object sender, EventArgs e)
		{
			if (this.dgvStreet.CurrentRow == null)
			{
				return;
			}
			if (new FormKladrAddEditStreet((int)this.dgvStreet.CurrentRow.Cells["idColumnStreet"].Value, -1)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrStreet, true, "where KladrObjId = " + this.treeViewPunkts.SelectedNode.Tag.ToString());
				base.SelectSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrDoma, true, "where streetId in (select id from tr_kladrstreet where kladrobjid = " + this.treeViewPunkts.SelectedNode.Tag.ToString() + ")");
			}
		}

		private void toolBtnDelStreet_Click(object sender, EventArgs e)
		{
			if (this.dgvStreet.CurrentRow == null)
			{
				return;
			}
			int int_ = (int)this.dgvStreet.CurrentRow.Cells["idColumnStreet"].Value;
			if (!Convert.ToBoolean(this.yoidejFsp2.tR_KladrStreet.Select("ID = " + int_.ToString())[0]["Deleted"]))
			{
				if (MessageBox.Show("Вы действительно хотите пометить на удаление текущую улицу", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					this.yoidejFsp2.tR_KladrStreet.method_2(int_).Deleted = true;
					this.yoidejFsp2.tR_KladrStreet.method_2(int_).EndEdit();
					base.UpdateSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrStreet);
					this.dgvStreet.Refresh();
					MessageBox.Show("Выбранная улица помечена на удаление");
					return;
				}
			}
			else if (MessageBox.Show("Вы действительно хотите восстановить текущую улицу?", "Восстановление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.yoidejFsp2.tR_KladrStreet.method_2(int_).Deleted = false;
				this.yoidejFsp2.tR_KladrStreet.method_2(int_).EndEdit();
				base.UpdateSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrStreet);
				this.dgvStreet.Refresh();
				MessageBox.Show("Выбранная улица успешно восстановлена");
			}
		}

		private void toolBtnDelStreetFull_Click(object sender, EventArgs e)
		{
			if (this.dgvStreet.CurrentRow == null)
			{
				return;
			}
			int int_ = (int)this.dgvStreet.CurrentRow.Cells["idColumnStreet"].Value;
			this.yoidejFsp2.tR_KladrStreet.Select("ID = " + int_.ToString());
			if (MessageBox.Show("Вы действительно хотите удалить текущую улицу", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.yoidejFsp2.tR_KladrStreet.method_2(int_).Delete();
				base.DeleteSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrStreet);
				MessageBox.Show("Выбранная улица успешно удалена");
			}
		}

		private void toolBtnShowDelStreet_Click(object sender, EventArgs e)
		{
			if (this.toolBtnShowDelStreet.Checked)
			{
				this.bindingSource_0.Filter = this.bindingSource_0.Filter.Replace("Deleted = false AND ", string.Empty);
				this.bindingSource_0.Filter = this.bindingSource_0.Filter.Replace(" AND Deleted = false", string.Empty);
				this.bindingSource_0.Filter = this.bindingSource_0.Filter.Replace("Deleted = false", string.Empty);
				return;
			}
			if (this.bindingSource_0.Filter.Length > 0)
			{
				BindingSource bindingSource = this.bindingSource_0;
				bindingSource.Filter += " AND Deleted = false";
				return;
			}
			BindingSource bindingSource2 = this.bindingSource_0;
			bindingSource2.Filter += "Deleted = false";
		}

		private void toolStripButtonFind_Click(object sender, EventArgs e)
		{
			this.dgvStreet.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.toolStripTextBoxFind.Text);
		}

		private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.dgvStreet.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxFind.Text);
			}
		}

		private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
		{
			this.dgvStreet.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonFindNext_Click(object sender, EventArgs e)
		{
			this.dgvStreet.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonPrint_Click(object sender, EventArgs e)
		{
			this.dgvStreet.PrintDataGridView();
		}

		private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
		{
			this.dgvStreet.CopyToExcel(true);
		}

		private void toolStripButtonRefresh_Click(object sender, EventArgs e)
		{
			base.SelectSqlData(this.yoidejFsp2, this.yoidejFsp2.tR_KladrObj, true);
			this.method_0(this.treeViewPunkts.SelectedNode);
		}

		private void dgvStreet_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
			if (this.dgvStreet.RowCount > 0 && e.ColumnIndex == this.dgvStreet.Columns["columnImage"].Index)
			{
				if (Convert.ToBoolean(this.dgvStreet["deletedDgvCheckBoxColumn", e.RowIndex].Value))
				{
					e.Value = this.imageList_0.Images["ElementDelete.png"];
					return;
				}
				e.Value = this.imageList_0.Images["Element.png"];
			}
		}

		private void zfidCpbaOL_Click(object sender, EventArgs e)
		{
			this.toolBtnAddPunkts_Click(sender, e);
		}

		private void zenlJaxyjH(object sender, EventArgs e)
		{
			this.toolBtnAddStreet_Click(sender, e);
		}

		private void toolMenuItemEditPunkt_Click(object sender, EventArgs e)
		{
			this.toolBtnEditPunkts_Click(sender, e);
		}

		private void toolMenuItemDelPunkt_Click(object sender, EventArgs e)
		{
			this.toolBtnDelPunkts_Click(sender, e);
		}

		private void toolMenuItemDelPunktFull_Click(object sender, EventArgs e)
		{
			this.toolBtnDelPunktsFull_Click(sender, e);
		}

		private void toolMenuItemAddStreet_Click(object sender, EventArgs e)
		{
			this.toolBtnAddStreet_Click(sender, e);
		}

		private void toolMenuItemEditStreet_Click(object sender, EventArgs e)
		{
			this.toolBtnEditStreet_Click(sender, e);
		}

		private void toolMenuItemDelStreet_Click(object sender, EventArgs e)
		{
			this.toolBtnDelStreet_Click(sender, e);
		}

		private void toolMenuItemDelStreetFull_Click(object sender, EventArgs e)
		{
			this.toolBtnDelStreetFull_Click(sender, e);
		}

		private void toolMenuItemCopyGrid_Click(object sender, EventArgs e)
		{
			this.dgvStreet.CopyToBuffer(false);
		}

		private void toolMenuItemExportExcel_Click(object sender, EventArgs e)
		{
			this.dgvStreet.CopyToExcel(false);
		}

		private void toolMenuItemPrint_Click(object sender, EventArgs e)
		{
			this.dgvStreet.PrintDataGridView();
		}
	}
}
