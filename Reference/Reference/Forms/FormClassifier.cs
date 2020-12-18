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
	public partial class FormClassifier : FormBase
	{
		public FormClassifier()
		{
			
			
			this.InitializeComponent();
		}

		private void FormClassifier_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tR_Classifier"], true);
			this.method_0(null);
		}

		private void FormClassifier_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keys = e.Modifiers;
			if (keys != Keys.None)
			{
				if (keys != Keys.Shift)
				{
					if (keys == Keys.Control)
					{
						keys = e.KeyCode;
						if (keys <= Keys.Delete)
						{
							if (keys == Keys.Insert)
							{
								this.toolStripButtonAddElement_Click(sender, e);
								return;
							}
							if (keys != Keys.Delete)
							{
								return;
							}
							this.toolStripButtonDelete_Click(sender, e);
							return;
						}
						else
						{
							if (keys == Keys.C)
							{
								this.dgvExcelFilter.CopyToBuffer(false);
								return;
							}
							if (keys == Keys.F)
							{
								this.toolStripTextBoxFind.Focus();
								return;
							}
							if (keys != Keys.P)
							{
								return;
							}
							this.dgvExcelFilter.PrintDataGridView();
							return;
						}
					}
				}
				else
				{
					keys = e.KeyCode;
					if (keys == Keys.Insert && e.Shift)
					{
						this.toolStripButtonAddGroup_Click(sender, e);
					}
				}
			}
			else
			{
				keys = e.KeyCode;
				if (keys == Keys.F2)
				{
					this.toolStripButtonEdit_Click(sender, e);
					return;
				}
			}
		}

		private void method_0(TreeNode treeNode_0)
		{
			this.treeView.Nodes.Clear();
			this.treeView.Nodes.Add("Все элементы");
			this.treeView.Nodes[0].ContextMenuStrip = this.contextMenuStripTree_1;
			this.treeView.SelectedNode = this.treeView.Nodes[0];
			TreeNode treeNode = this.treeView.Nodes[0];
			string str = this.toolStripButtonHideDelete.Checked ? "" : " and Deleted = false";
			foreach (DataRow dataRow in this.class48_0.DataTableCollection_0["tR_Classifier"].Select("ParentId is NULL" + str, "IsGroup DESC, Name ASC"))
			{
				TreeNode treeNode2 = new TreeNode(dataRow["Name"].ToString());
				treeNode2.Tag = dataRow["Id"];
				treeNode2.ImageKey = this.method_2(dataRow);
				treeNode2.SelectedImageKey = this.method_2(dataRow);
				treeNode2.ContextMenuStrip = this.contextMenuStripTree_1;
				treeNode.Nodes.Add(treeNode2);
				this.method_1(treeNode2, treeNode_0);
				if (treeNode_0 != null && Convert.ToInt32(treeNode_0.Tag) == Convert.ToInt32(treeNode2.Tag))
				{
					this.treeView.SelectedNode = treeNode2;
					this.treeView.SelectedNode.Expand();
				}
			}
			this.treeView.Nodes[0].Expand();
		}

		private void method_1(TreeNode treeNode_0, TreeNode treeNode_1)
		{
			string str = this.toolStripButtonHideDelete.Checked ? "" : " and Deleted = false";
			foreach (DataRow dataRow in this.class48_0.DataTableCollection_0["tR_Classifier"].Select("ParentId = " + treeNode_0.Tag.ToString() + str, "IsGRoup DESC, Name ASC"))
			{
				TreeNode treeNode = new TreeNode(dataRow["Name"].ToString());
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageKey = this.method_2(dataRow);
				treeNode.SelectedImageKey = this.method_2(dataRow);
				treeNode.ContextMenuStrip = this.contextMenuStripTree_1;
				if (this.toolStripButtonHideElement.Checked || Convert.ToBoolean(dataRow["IsGroup"]))
				{
					treeNode_0.Nodes.Add(treeNode);
				}
				this.method_1(treeNode, treeNode_1);
				if (treeNode_1 != null && Convert.ToInt32(treeNode_1.Tag) == Convert.ToInt32(treeNode.Tag))
				{
					this.treeView.SelectedNode = treeNode;
					this.treeView.SelectedNode.Expand();
				}
			}
		}

		private string method_2(DataRow dataRow_0)
		{
			if (Convert.ToBoolean(dataRow_0["IsGroup"]))
			{
				if (Convert.ToBoolean(dataRow_0["Deleted"]))
				{
					return "FolderDeleteYellow.png";
				}
				string str = this.toolStripButtonHideDelete.Checked ? "" : " and Deleted = false";
				if (this.class48_0.DataTableCollection_0["tR_Classifier"].Select("ParentId = " + dataRow_0["id"].ToString() + str).Length != 0)
				{
					return "FolderDocumentYellow.png";
				}
				return "FolderYellow.png";
			}
			else
			{
				if (Convert.ToBoolean(dataRow_0["Deleted"]))
				{
					return "ElementDelete.png";
				}
				return "Element.png";
			}
		}

		private void treeView_AfterExpand(object sender, TreeViewEventArgs e)
		{
			if (e.Node.IsExpanded && e.Node.ImageKey != "FolderDeleteYellow.png")
			{
				e.Node.SelectedImageKey = "FolderOpenYellow.png";
				e.Node.ImageKey = "FolderOpenYellow.png";
			}
		}

		private void treeView_AfterCollapse(object sender, TreeViewEventArgs e)
		{
			if (!e.Node.IsExpanded && e.Node.ImageKey != "FolderDeleteYellow.png")
			{
				if (e.Node.Nodes.Count > 0)
				{
					e.Node.SelectedImageKey = "FolderDocumentYellow.png";
					e.Node.ImageKey = "FolderDocumentYellow.png";
					return;
				}
				e.Node.SelectedImageKey = "FolderYellow.png";
				e.Node.ImageKey = "FolderYellow.png";
			}
		}

		private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string filter = "";
			string sort = "";
			int num = -1;
			if (e.Node.IsSelected)
			{
				if (e.Node == this.treeView.Nodes[0])
				{
					string str = this.toolStripButtonHideDelete.Checked ? "" : " and Deleted = false";
					filter = "ParentId is NULL" + str;
					sort = "Name";
				}
				else
				{
					string text = this.toolStripButtonHideDelete.Checked ? "" : " and Deleted = false";
					if (e.Node.ImageKey.Contains("Folder"))
					{
						filter = string.Concat(new string[]
						{
							"(id = ",
							e.Node.Tag.ToString(),
							" or ParentId = ",
							e.Node.Tag.ToString(),
							")",
							text
						});
						sort = "IsGroup desc, Parentkey asc, Name asc";
					}
					else
					{
						filter = string.Concat(new string[]
						{
							"(id = ",
							e.Node.Parent.Tag.ToString(),
							" or ParentId = ",
							e.Node.Parent.Tag.ToString(),
							")",
							text
						});
						sort = "IsGroup desc, Parentkey asc, Name asc";
					}
					num = Convert.ToInt32(e.Node.Tag);
				}
			}
			this.bindingSource_0.Filter = filter;
			this.bindingSource_0.Sort = sort;
			if (num >= 0)
			{
				this.dgvExcelFilter.CurrentCell = this.dgvExcelFilter[0, this.method_3(this.dgvExcelFilter, "idDgvTextBoxColumn", num)];
			}
			this.dgvExcelFilter.Rows[0].Frozen = true;
		}

		private int method_3(DataGridViewExcelFilter dataGridViewExcelFilter_0, string string_0, int int_0)
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

		private void treeView_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.treeView.SelectedNode = this.treeView.GetNodeAt(e.X, e.Y);
			}
		}

		private void dgvExcelFilter_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
			if (this.dgvExcelFilter.RowCount > 0)
			{
				if (e.ColumnIndex == this.dgvExcelFilter.Columns["columnImage"].Index)
				{
					if (Convert.ToBoolean(this.dgvExcelFilter["deletedDgvCheckBoxColumn", e.RowIndex].Value))
					{
						if (Convert.ToBoolean(this.dgvExcelFilter["IsGroup", e.RowIndex].Value))
						{
							e.Value = this.imageList_0.Images["FolderDeleteYellow.png"];
						}
						else
						{
							e.Value = this.imageList_0.Images["ElementDelete.png"];
						}
					}
					else if (Convert.ToBoolean(this.dgvExcelFilter["IsGroup", e.RowIndex].Value))
					{
						string str = this.toolStripButtonHideDelete.Checked ? "" : " and Deleted = false";
						if (this.class48_0.DataTableCollection_0["tR_Classifier"].Select("ParentId = " + this.dgvExcelFilter["idDgvTextBoxColumn", e.RowIndex].Value.ToString() + str).Length != 0)
						{
							e.Value = this.imageList_0.Images["FolderDocumentYellow.png"];
						}
						else
						{
							e.Value = this.imageList_0.Images["FolderYellow.png"];
						}
					}
					else
					{
						e.Value = this.imageList_0.Images["Element.png"];
					}
				}
				if (!this.treeView.Nodes[0].IsSelected && e.RowIndex == 0)
				{
					e.Value = this.imageList_0.Images["FolderParentYellow.png"];
				}
			}
		}

		private void dgvExcelFilter_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (this.dgvExcelFilter.RowCount > 0)
			{
				if (this.treeView.Nodes[0].IsSelected)
				{
					e.CellStyle.BackColor = Color.LightGray;
					return;
				}
				if (e.RowIndex == 0)
				{
					e.CellStyle.BackColor = Color.WhiteSmoke;
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
					return;
				}
				if (Convert.ToBoolean(this.dgvExcelFilter["IsGroup", e.RowIndex].Value))
				{
					e.CellStyle.BackColor = Color.LightGray;
				}
			}
		}

		private void dgvExcelFilter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if (this.treeView.Nodes[0].IsSelected)
				{
					if (!Convert.ToBoolean(this.dgvExcelFilter["IsGroup", e.RowIndex].Value))
					{
						return;
					}
					using (IEnumerator enumerator = this.treeView.SelectedNode.Nodes.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							TreeNode treeNode = (TreeNode)obj;
							if (Convert.ToInt32(treeNode.Tag) == Convert.ToInt32(this.dgvExcelFilter["idDgvTextBoxColumn", e.RowIndex].Value))
							{
								this.treeView.SelectedNode = treeNode;
								this.treeView.SelectedNode.Expand();
								break;
							}
						}
						return;
					}
				}
				if (e.RowIndex > 0)
				{
					if (Convert.ToBoolean(this.dgvExcelFilter["IsGroup", e.RowIndex].Value))
					{
						using (IEnumerator enumerator = this.treeView.SelectedNode.Nodes.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								object obj2 = enumerator.Current;
								TreeNode treeNode2 = (TreeNode)obj2;
								if (Convert.ToInt32(treeNode2.Tag) == Convert.ToInt32(this.dgvExcelFilter["idDgvTextBoxColumn", e.RowIndex].Value))
								{
									this.treeView.SelectedNode = treeNode2;
									this.treeView.SelectedNode.Expand();
									break;
								}
							}
							return;
						}
					}
					this.toolStripButtonEdit_Click(sender, e);
					return;
				}
				this.treeView.SelectedNode.Collapse();
				this.treeView.SelectedNode = this.treeView.SelectedNode.Parent;
			}
		}

		private void toolStripButtonHideElement_Click(object sender, EventArgs e)
		{
			this.toolStripButtonHideElement.Text = (this.toolStripButtonHideElement.Checked ? "Скрыть элементы" : "Показать элементы");
			TreeNode treeNode = this.treeView.SelectedNode;
			if (treeNode != this.treeView.Nodes[0])
			{
				DataRow[] array = this.class48_0.DataTableCollection_0["tR_Classifier"].Select("Id = " + treeNode.Tag.ToString());
				if (!this.toolStripButtonHideElement.Checked && !Convert.ToBoolean(array[0]["IsGRoup"]))
				{
					treeNode = treeNode.Parent;
				}
			}
			this.method_0(treeNode);
		}

		private void toolStripButtonHideDelete_Click(object sender, EventArgs e)
		{
			this.toolStripButtonHideDelete.Text = (this.toolStripButtonHideDelete.Checked ? "Скрыть удаленные" : "Показать удаленные");
			TreeNode treeNode = this.treeView.SelectedNode;
			if (treeNode != this.treeView.Nodes[0])
			{
				DataRow[] array = this.class48_0.DataTableCollection_0["tR_Classifier"].Select("Id = " + treeNode.Tag.ToString());
				if (!this.toolStripButtonHideDelete.Checked && Convert.ToBoolean(array[0]["Deleted"]))
				{
					treeNode = treeNode.Parent;
				}
			}
			this.method_0(treeNode);
		}

		private void toolStripButtonTreeFind_Click(object sender, EventArgs e)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_4(this.treeView.Nodes, list_);
			TreeNode treeNode = this.method_5(list_, this.treeView.SelectedNode, this.toolStripTextBoxFind.Text);
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

		private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.toolStripButtonTreeFind_Click(sender, e);
			}
		}

		private void toolStripButtonCloseTree_Click(object sender, EventArgs e)
		{
			this.toolStripTree.Visible = false;
			this.toolStripButtonHideToolTree.Checked = false;
		}

		private void toolStripButtonAddGroup_Click(object sender, EventArgs e)
		{
			int int_ = -1;
			if (this.treeView.SelectedNode != this.treeView.Nodes[0])
			{
				int_ = Convert.ToInt32(this.dgvExcelFilter["idDgvTextBoxColumn", 0].Value);
			}
			if (new FormAddUpdClassifier(-1, int_, true, true)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tR_Classifier"], true);
				this.method_0(null);
			}
		}

		private void toolStripButtonEdit_Click(object sender, EventArgs e)
		{
			int int_ = -1;
			if (this.treeView.SelectedNode != this.treeView.Nodes[0])
			{
				DataRow[] array = this.class48_0.tR_Classifier.Select("id = " + this.dgvExcelFilter.CurrentRow.Cells["idDgvTextBoxColumn"].Value.ToString());
				if (array[0]["ParentId"].ToString() != "")
				{
					int_ = Convert.ToInt32(array[0]["ParentId"]);
				}
			}
			if (new FormAddUpdClassifier(Convert.ToInt32(this.dgvExcelFilter.CurrentRow.Cells["idDgvTextBoxColumn"].Value), int_, Convert.ToBoolean(this.dgvExcelFilter.CurrentRow.Cells["IsGroup"].Value), false)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tR_Classifier"], true);
				this.method_0(this.treeView.SelectedNode);
			}
		}

		private void toolStripButtonAddElement_Click(object sender, EventArgs e)
		{
			if (this.dgvExcelFilter.CurrentRow == null)
			{
				return;
			}
			int int_;
			if (Convert.ToBoolean(this.dgvExcelFilter.CurrentRow.Cells["isgroup"].Value))
			{
				int_ = Convert.ToInt32(this.dgvExcelFilter.CurrentRow.Cells["idDgvTextBoxColumn"].Value);
			}
			else
			{
				int_ = Convert.ToInt32(this.dgvExcelFilter["idDgvTextBoxColumn", 0].Value);
			}
			if (new FormAddUpdClassifier(-1, int_, false, true)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tR_Classifier"], true);
				this.method_0(this.treeView.SelectedNode);
			}
		}

		private void toolStripButtonDelete_Click(object sender, EventArgs e)
		{
			if (this.dgvExcelFilter.CurrentRow == null)
			{
				return;
			}
			bool flag;
			if (Convert.ToBoolean(this.dgvExcelFilter.CurrentRow.Cells["deletedDgvCheckBoxColumn"].Value))
			{
				if (MessageBox.Show("Вы действительно хотите отменить пометку на удаление?", "Отмена удаления", MessageBoxButtons.YesNo) != DialogResult.Yes)
				{
					return;
				}
				this.dgvExcelFilter.CurrentRow.Cells["deletedDgvCheckBoxColumn"].Value = false;
				flag = false;
			}
			else
			{
				if (MessageBox.Show("Вы действительно хотите поменить на удаление выбранный элемент?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
				{
					return;
				}
				this.dgvExcelFilter.CurrentRow.Cells["deletedDgvCheckBoxColumn"].Value = true;
				flag = true;
			}
			((DataRowView)this.dgvExcelFilter.CurrentRow.DataBoundItem).EndEdit();
			if (base.UpdateSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tR_Classifier"]))
			{
				base.SelectSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tR_Classifier"], true);
				this.method_0(this.treeView.SelectedNode.Parent);
				if (flag)
				{
					MessageBox.Show("Выбранный элемент помечен на удаление");
					return;
				}
				MessageBox.Show("Пометка на удаления успешна снята");
			}
		}

		private void toolStripButtonDeleteFull_Click(object sender, EventArgs e)
		{
			if (this.dgvExcelFilter.CurrentRow == null)
			{
				return;
			}
			if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				if (Convert.ToBoolean(this.dgvExcelFilter.CurrentRow.Cells["IsGroup"].Value))
				{
					foreach (DataRow dataRow in this.class48_0.DataTableCollection_0["tr_Classifier"].Select("ParentId = " + this.dgvExcelFilter.CurrentRow.Cells["idDgvTextBoxColumn"].Value.ToString()))
					{
						this.class48_0.DataTableCollection_0["tR_Classifier"].Rows.Find(dataRow["id"]).Delete();
						this.class48_0.DataTableCollection_0["tR_Classifier"].GetChanges(DataRowState.Deleted);
					}
				}
				this.dgvExcelFilter.Rows.Remove(this.dgvExcelFilter.CurrentRow);
				this.dgvExcelFilter.EndEdit();
				base.DeleteSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tr_Classifier"]);
				this.method_0(this.treeView.SelectedNode.Parent);
				MessageBox.Show("Данные успешно удалены");
			}
		}

		private void EbjOqaSbwa(object sender, EventArgs e)
		{
			this.dgvExcelFilter.PrintDataGridView();
		}

		private void toolStripButtonExcel_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.CopyToExcel(true);
		}

		private void toolStripButtonRefresh_Click(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tR_Classifier"], true);
			this.method_0(this.treeView.SelectedNode);
		}

		private void toolStripButtonHideToolTree_Click(object sender, EventArgs e)
		{
			if (this.toolStripButtonHideToolTree.Checked)
			{
				this.toolStripButtonHideToolTree.Text = "Скрыть панель дерева";
				this.toolStripTree.Visible = true;
				return;
			}
			this.toolStripButtonHideToolTree.Text = "Показать панель дерева";
			this.toolStripTree.Visible = false;
		}

		private void contextMenuStripTree_1_Opening(object sender, CancelEventArgs e)
		{
			if (this.treeView.SelectedNode == this.treeView.Nodes[0])
			{
				this.toolStripMenuItemTreeAddElement.Visible = false;
				this.toolStripMenuItemTreeEdit.Visible = false;
				this.toolStripMenuItemTreeDel.Visible = false;
				return;
			}
			this.toolStripMenuItemTreeAddElement.Visible = true;
			this.toolStripMenuItemTreeEdit.Visible = true;
			this.toolStripMenuItemTreeDel.Visible = true;
			if (Convert.ToBoolean(this.class48_0.DataTableCollection_0["tr_Classifier"].Select("id = " + this.treeView.SelectedNode.Tag.ToString())[0]["Deleted"]))
			{
				this.toolStripMenuItemTreeDelCheck.Text = "Снять пометку на удаление";
				return;
			}
			this.toolStripMenuItemTreeDelCheck.Text = "Пометить на удаление";
		}

		private void toolStripMenuItemTreeAddGroup_Click(object sender, EventArgs e)
		{
			int int_ = -1;
			if (this.treeView.SelectedNode != this.treeView.Nodes[0])
			{
				if (Convert.ToBoolean(this.class48_0.DataTableCollection_0["tr_Classifier"].Select("id = " + this.treeView.SelectedNode.Tag.ToString())[0]["IsGroup"]))
				{
					int_ = Convert.ToInt32(this.treeView.SelectedNode.Tag);
				}
				else
				{
					int_ = Convert.ToInt32(this.treeView.SelectedNode.Parent.Tag);
				}
			}
			if (new FormAddUpdClassifier(-1, int_, true, true)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tR_Classifier"], true);
				this.method_0(this.treeView.SelectedNode);
			}
		}

		private void toolStripMenuItemTreeAddElement_Click(object sender, EventArgs e)
		{
			int int_ = -1;
			if (this.treeView.SelectedNode != this.treeView.Nodes[0])
			{
				if (Convert.ToBoolean(this.class48_0.DataTableCollection_0["tr_Classifier"].Select("id = " + this.treeView.SelectedNode.Tag.ToString())[0]["IsGroup"]))
				{
					int_ = Convert.ToInt32(this.treeView.SelectedNode.Tag);
				}
				else
				{
					int_ = Convert.ToInt32(this.treeView.SelectedNode.Parent.Tag);
				}
			}
			if (new FormAddUpdClassifier(-1, int_, false, true)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tR_Classifier"], true);
				this.method_0(this.treeView.SelectedNode);
			}
		}

		private void toolStripMenuItemTreeEdit_Click(object sender, EventArgs e)
		{
			int int_ = -1;
			DataRow[] array = this.class48_0.DataTableCollection_0["tr_Classifier"].Select("id = " + this.treeView.SelectedNode.Tag.ToString());
			if (array[0]["ParentId"].ToString() != "")
			{
				int_ = Convert.ToInt32(array[0]["ParentId"]);
			}
			if (new FormAddUpdClassifier(Convert.ToInt32(this.treeView.SelectedNode.Tag), int_, Convert.ToBoolean(array[0]["IsGroup"]), false)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tR_Classifier"], true);
				this.method_0(this.treeView.SelectedNode);
			}
		}

		private void toolStripMenuItemTreeDelCheck_Click(object sender, EventArgs e)
		{
			DataRow[] array = this.class48_0.DataTableCollection_0["tr_Classifier"].Select("id = " + this.treeView.SelectedNode.Tag.ToString());
			bool flag;
			if (Convert.ToBoolean(array[0]["Deleted"]))
			{
				if (MessageBox.Show("Вы действительно хотите отменить пометку на удаление?", "Отмена удаления", MessageBoxButtons.YesNo) != DialogResult.Yes)
				{
					return;
				}
				this.class48_0.DataTableCollection_0["tR_Classifier"].Rows.Find(array[0]["id"])["Deleted"] = false;
				flag = false;
			}
			else
			{
				if (MessageBox.Show("Вы действительно хотите поменить на удаление выбранный элемент?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
				{
					return;
				}
				this.class48_0.DataTableCollection_0["tR_Classifier"].Rows.Find(array[0]["id"])["Deleted"] = true;
				flag = true;
			}
			this.class48_0.DataTableCollection_0["tR_Classifier"].Rows.Find(array[0]["id"]).EndEdit();
			if (base.UpdateSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tR_Classifier"]))
			{
				base.SelectSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tR_Classifier"], true);
				this.method_0(this.treeView.SelectedNode.Parent);
				if (flag)
				{
					MessageBox.Show("Выбранный элемент помечен на удаление");
					return;
				}
				MessageBox.Show("Пометка на удаления успешна снята");
			}
		}

		private void toolStripMenuItemTreeDelFull_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				DataRow[] array = this.class48_0.DataTableCollection_0["tr_Classifier"].Select("id = " + this.treeView.SelectedNode.Tag.ToString());
				if (Convert.ToBoolean(array[0]["IsGroup"]))
				{
					foreach (DataRow dataRow in this.class48_0.DataTableCollection_0["tr_Classifier"].Select("ParentId = " + this.treeView.SelectedNode.Tag.ToString()))
					{
						this.class48_0.DataTableCollection_0["tR_Classifier"].Rows.Find(dataRow["id"]).Delete();
					}
				}
				this.class48_0.DataTableCollection_0["tR_Classifier"].Rows.Find(array[0]["id"]).Delete();
				base.DeleteSqlData(this.class48_0, this.class48_0.DataTableCollection_0["tr_Classifier"]);
				this.method_0(this.treeView.SelectedNode.Parent);
				MessageBox.Show("Данные успешно удалены");
			}
		}

		private void toolStripMenuItemGridAddGroup_Click(object sender, EventArgs e)
		{
			this.toolStripButtonAddGroup_Click(sender, e);
		}

		private void toolStripMenuItemGridAddElement_Click(object sender, EventArgs e)
		{
			this.toolStripButtonAddElement_Click(sender, e);
		}

		private void toolStripMenuItemGridEdit_Click(object sender, EventArgs e)
		{
			this.toolStripButtonEdit_Click(sender, e);
		}

		private void toolStripMenuItemGridDelCheck_Click(object sender, EventArgs e)
		{
			this.toolStripButtonDelete_Click(sender, e);
		}

		private void toolStripMenuItemGridDelFull_Click(object sender, EventArgs e)
		{
			this.toolStripButtonDeleteFull_Click(sender, e);
		}

		private void toolStripMenuItemGridCopy_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.CopyToBuffer(false);
		}

		private void toolStripMenuItemGridExport_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.CopyToExcel(false);
		}

		private void toolStripMenuItemGridPrint_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.PrintDataGridView();
		}
	}
}
