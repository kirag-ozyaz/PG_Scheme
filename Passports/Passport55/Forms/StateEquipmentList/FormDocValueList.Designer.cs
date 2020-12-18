using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using Passport.DataSets;
using Passport.Properties;
using WeifenLuo.WinFormsUI.Docking;

namespace Passport.Forms.StateEquipmentList
{
	public class FormDocValueList : DockContentBase
	{
		public FormDocValueList(SQLSettings settings)
		{
			this.SqlSettings = settings;
			this.method_12();
			this.method_0(";TypeDoc;tPassport;");
		}

		private void method_0(string string_1)
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vP_GetDocGroupState, true, "where not (isGroup = 0 and level = 1) order by level, isGroup, Name");
			DataRow[] array = this.dsDocuments_0.vP_GetDocGroupState.Select("ParentId = " + 682.ToString());
			this.treeView_0.Nodes.Clear();
			this.treeView_0.BeginUpdate();
			foreach (DataRow dataRow in array)
			{
				TreeNode treeNode = new TreeNode(dataRow["Name"].ToString());
				treeNode.Name = dataRow["Name"].ToString();
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageIndex = (treeNode.SelectedImageIndex = this.method_2(dataRow));
				this.treeView_0.Nodes.Add(treeNode);
				this.method_1(treeNode);
			}
			this.treeView_0.EndUpdate();
		}

		private void method_1(TreeNode treeNode_0)
		{
			foreach (DataRow dataRow in this.dsDocuments_0.vP_GetDocGroupState.Select("ParentId = " + treeNode_0.Tag.ToString()))
			{
				TreeNode treeNode = new TreeNode(dataRow["Name"].ToString());
				treeNode.Name = dataRow["Name"].ToString();
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageIndex = (treeNode.SelectedImageIndex = this.method_2(dataRow));
				treeNode.ContextMenuStrip = this.method_3(dataRow);
				treeNode_0.Nodes.Add(treeNode);
				this.method_1(treeNode);
			}
		}

		private int method_2(DataRow dataRow_0)
		{
			if (Convert.ToBoolean(dataRow_0["isGroup"]) && !Convert.ToBoolean(dataRow_0["Level"]))
			{
				return 0;
			}
			if (!Convert.ToBoolean(dataRow_0["isGroup"]) && !Convert.ToBoolean(dataRow_0["Level"]))
			{
				return 1;
			}
			if (Convert.ToBoolean(dataRow_0["isGroup"]) && Convert.ToBoolean(dataRow_0["Level"]))
			{
				return 2;
			}
			if (!Convert.ToBoolean(dataRow_0["isGroup"]) && Convert.ToBoolean(dataRow_0["Level"]))
			{
				return 3;
			}
			return 0;
		}

		private ContextMenuStrip method_3(DataRow dataRow_0)
		{
			if (!Convert.ToBoolean(dataRow_0["isGroup"]) && !Convert.ToBoolean(dataRow_0["Level"]))
			{
				this.contextMenuStrip_0.Items["tscmiEditGroup"].Enabled = false;
				this.contextMenuStrip_0.Items["tssGroup"].Enabled = false;
				this.contextMenuStrip_0.Items["tscmiDeleteGroup"].Enabled = false;
			}
			if (Convert.ToBoolean(dataRow_0["isGroup"]) && Convert.ToBoolean(dataRow_0["Level"]))
			{
				this.contextMenuStrip_0.Items["tscmiEditGroup"].Enabled = true;
				this.contextMenuStrip_0.Items["tssGroup"].Enabled = true;
				this.contextMenuStrip_0.Items["tscmiDeleteGroup"].Enabled = true;
			}
			return this.contextMenuStrip_0;
		}

		private void treeView_0_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.method_8((int)this.treeView_0.SelectedNode.Tag);
		}

		private int method_4(TreeNode treeNode_0)
		{
			if (treeNode_0 == null)
			{
				return -1;
			}
			if (treeNode_0.ImageIndex == this.imageList_0.Images.IndexOfKey("Document"))
			{
				return (int)treeNode_0.Tag;
			}
			return this.method_4(treeNode_0.Parent);
		}

		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null && this.treeView_0.SelectedNode.Parent != null)
			{
				FormAddEditGroupValue formAddEditGroupValue = new FormAddEditGroupValue();
				formAddEditGroupValue.SqlSettings = this.SqlSettings;
				TreeNode selectedNode = this.treeView_0.SelectedNode;
				new TreeNode();
				if (selectedNode.ImageIndex == this.imageList_0.Images.IndexOfKey("Document"))
				{
					formAddEditGroupValue.Id = (int)selectedNode.Tag;
					formAddEditGroupValue.CreateState = 0;
				}
				if (selectedNode.ImageIndex == this.imageList_0.Images.IndexOfKey("Group"))
				{
					formAddEditGroupValue.Id = (int)selectedNode.Tag;
					formAddEditGroupValue.TypeDoc = this.method_4(selectedNode);
					formAddEditGroupValue.CreateState = 0;
				}
				if (formAddEditGroupValue.CreateState == null && formAddEditGroupValue.ShowDialog() != DialogResult.Cancel)
				{
					this.method_10(formAddEditGroupValue.Id);
				}
				formAddEditGroupValue.Dispose();
			}
		}

		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null && this.treeView_0.SelectedNode.ImageIndex == this.imageList_0.Images.IndexOfKey("Element"))
			{
				TreeNode selectedNode = this.treeView_0.SelectedNode;
				if (new FormAddEditGroupValue(this.SqlSettings, (int)selectedNode.Tag, 1).DialogResult == DialogResult.OK)
				{
					this.method_11();
				}
			}
		}

		private void toolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				int int_ = (int)this.treeView_0.SelectedNode.Parent.Tag;
				if (this.treeView_0.SelectedNode.ImageIndex == this.imageList_0.Images.IndexOfKey("Group") && MessageBox.Show("Вы действительно хотите удалить данную ветку дерева?", "Удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					base.SelectSqlDataTableOther(this.dsDocuments_0, this.dsDocuments_0.tR_DocValueListDeleted, "tR_DocValueList", true, string.Format("where id = {0} or parentId = {0}", this.treeView_0.SelectedNode.Tag));
					foreach (dsDocuments.Class157 @class in this.dsDocuments_0.tR_DocValueListDeleted)
					{
						@class.method_7(true);
					}
					base.UpdateSqlDataTableOther(this.dsDocuments_0, this.dsDocuments_0.tR_DocValueListDeleted, "tR_DocValueList");
					this.method_0(";TypeDoc;tPassport;");
					this.method_10(int_);
					return;
				}
				MessageBox.Show("Невозможно удалить данную ветку дерева", "Вннимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null && this.treeView_0.SelectedNode.ImageIndex == this.imageList_0.Images.IndexOfKey("Document"))
			{
				FormAddEditStateValue formAddEditStateValue = new FormAddEditStateValue(this.SqlSettings, (int)this.treeView_0.SelectedNode.Tag, this.method_4(this.treeView_0.SelectedNode));
				formAddEditStateValue.ShowDialog();
				this.method_9((int)this.treeView_0.SelectedNode.Tag, formAddEditStateValue.Id);
				formAddEditStateValue.Dispose();
			}
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.CurrentRow != null)
			{
				FormAddEditStateValue formAddEditStateValue = new FormAddEditStateValue(this.SqlSettings, (int)this.dataGridView_0.CurrentRow.Cells["id"].Value);
				formAddEditStateValue.ShowDialog();
				formAddEditStateValue.Dispose();
				this.method_9((int)this.treeView_0.SelectedNode.Tag, (int)this.dataGridView_0.CurrentRow.Cells["id"].Value);
			}
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.dsDocuments_0.tR_DocValueList.Select("id = " + this.dataGridView_0.CurrentRow.Cells["id"].Value.ToString())[0]["Deleted"] = true;
				base.UpdateSqlData(this.dsDocuments_0, this.dsDocuments_0.tR_DocValueList);
				this.method_8((int)this.treeView_0.SelectedNode.Tag);
			}
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private TreeNode method_5(TreeNodeCollection treeNodeCollection_0, int int_2)
		{
			foreach (object obj in treeNodeCollection_0)
			{
				TreeNode treeNode = (TreeNode)obj;
				if ((int)treeNode.Tag == int_2)
				{
					return treeNode;
				}
			}
			return null;
		}

		private void toolStripButton_5_Click(object sender, EventArgs e)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_6(this.treeView_0.Nodes, list_);
			TreeNode treeNode = this.method_7(list_, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text);
			if (treeNode != null)
			{
				this.treeView_0.SelectedNode = treeNode;
				if (treeNode.IsExpanded)
				{
					this.treeView_0.SelectedNode.Expand();
				}
			}
		}

		private List<TreeNode> method_6(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_1)
		{
			foreach (object obj in treeNodeCollection_0)
			{
				TreeNode treeNode = (TreeNode)obj;
				list_1.Add(treeNode);
				list_1 = this.method_6(treeNode.Nodes, list_1);
			}
			return list_1;
		}

		private TreeNode method_7(List<TreeNode> list_1, TreeNode treeNode_0, string string_1)
		{
			bool flag = false;
			foreach (TreeNode treeNode in list_1)
			{
				if (flag && treeNode.Text.ToUpper().Contains(string_1.ToUpper()))
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

		private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.toolStripButton_5_Click(sender, e);
			}
		}

		private void method_8(int int_2)
		{
			int num = -1;
			if (this.dataGridView_0.RowCount > 0)
			{
				num = this.dataGridView_0.FirstDisplayedScrollingRowIndex;
			}
			if (this.treeView_0.SelectedNode != null && this.treeView_0.SelectedNode.ImageIndex == this.imageList_0.Images.IndexOfKey("Group"))
			{
				base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tR_DocValueList, true, "where ParentId = " + int_2.ToString() + " and isGroup = 0 and deleted = 0  order by Name", true);
				this.dataGridView_0.DataSource = this.dsDocuments_0.tR_DocValueList;
				if (this.dataGridView_0.RowCount > 0 && num != -1)
				{
					this.dataGridView_0.FirstDisplayedScrollingRowIndex = num;
					return;
				}
			}
			else
			{
				this.dsDocuments_0.tR_DocValueList.Rows.Clear();
			}
		}

		private void method_9(int int_2, int int_3)
		{
			if (this.treeView_0.SelectedNode != null && this.treeView_0.SelectedNode.ImageIndex == this.imageList_0.Images.IndexOfKey("Group"))
			{
				base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tR_DocValueList, true, "where ParentId = " + int_2.ToString() + " and isGroup = 0 and deleted = 0 order by Name", true);
				this.dataGridView_0.DataSource = this.dsDocuments_0.tR_DocValueList;
				for (int i = 0; i < this.dataGridView_0.RowCount; i++)
				{
					if ((int)this.dataGridView_0.Rows[i].Cells["id"].Value == int_3)
					{
						this.dataGridView_0.FirstDisplayedScrollingRowIndex = this.dataGridView_0.Rows[i].Index;
						this.dataGridView_0.Rows[i].Selected = true;
					}
				}
				return;
			}
			this.dsDocuments_0.tR_DocValueList.Rows.Clear();
		}

		private void toolStripButton_7_Click(object sender, EventArgs e)
		{
			this.method_11();
		}

		private void method_10(int int_2)
		{
			this.list_0.Clear();
			List<TreeNode> list = new List<TreeNode>();
			list = this.method_6(this.treeView_0.Nodes, list);
			foreach (TreeNode treeNode in list)
			{
				if (treeNode.IsExpanded)
				{
					this.list_0.Add((int)treeNode.Tag);
				}
			}
			this.method_0(";TypeDoc;tPassport;");
			this.treeView_0.BeginUpdate();
			list = this.method_6(this.treeView_0.Nodes, list);
			foreach (TreeNode treeNode2 in list)
			{
				using (List<int>.Enumerator enumerator2 = this.list_0.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						int num = enumerator2.Current;
						if ((int)treeNode2.Tag == num)
						{
							treeNode2.Expand();
							break;
						}
					}
					goto IL_108;
				}
				IL_FA:
				this.treeView_0.SelectedNode = treeNode2;
				continue;
				IL_108:
				if ((int)treeNode2.Tag == int_2)
				{
					goto IL_FA;
				}
			}
			this.treeView_0.EndUpdate();
		}

		private void method_11()
		{
			this.list_0.Clear();
			List<TreeNode> list = new List<TreeNode>();
			list = this.method_6(this.treeView_0.Nodes, list);
			foreach (TreeNode treeNode in list)
			{
				if (treeNode.IsExpanded)
				{
					this.list_0.Add((int)treeNode.Tag);
				}
				if (treeNode.IsSelected)
				{
					this.int_1 = (int)treeNode.Tag;
				}
			}
			this.method_0(";TypeDoc;tPassport;");
			this.treeView_0.BeginUpdate();
			list = this.method_6(this.treeView_0.Nodes, list);
			foreach (TreeNode treeNode2 in list)
			{
				using (List<int>.Enumerator enumerator2 = this.list_0.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						int num = enumerator2.Current;
						if ((int)treeNode2.Tag == num)
						{
							treeNode2.Expand();
							break;
						}
					}
					goto IL_121;
				}
				IL_113:
				this.treeView_0.SelectedNode = treeNode2;
				continue;
				IL_121:
				if ((int)treeNode2.Tag == this.int_1)
				{
					goto IL_113;
				}
			}
			this.treeView_0.EndUpdate();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_12()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDocValueList));
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.tableLayoutPanel_1 = new TableLayoutPanel();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.tableLayoutPanel_2 = new TableLayoutPanel();
			this.toolStrip_1 = new ToolStrip();
			this.toolStripButton_6 = new ToolStripButton();
			this.toolStripButton_3 = new ToolStripButton();
			this.toolStripButton_4 = new ToolStripButton();
			this.toolStripTextBox_0 = new ToolStripTextBox();
			this.toolStripButton_5 = new ToolStripButton();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.toolStripButton_7 = new ToolStripButton();
			this.treeView_0 = new TreeView();
			this.imageList_0 = new ImageList(this.icontainer_0);
			this.button_0 = new Button();
			this.dsDocuments_0 = new dsDocuments();
			this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripMenuItem_2 = new ToolStripMenuItem();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.tableLayoutPanel_0.SuspendLayout();
			this.tableLayoutPanel_1.SuspendLayout();
			this.toolStrip_0.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			this.tableLayoutPanel_2.SuspendLayout();
			this.toolStrip_1.SuspendLayout();
			((ISupportInitialize)this.dsDocuments_0).BeginInit();
			this.contextMenuStrip_0.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.70739f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.29261f));
			this.tableLayoutPanel_0.Controls.Add(this.tableLayoutPanel_1, 1, 0);
			this.tableLayoutPanel_0.Controls.Add(this.tableLayoutPanel_2, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 1, 1);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 2;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_0.Size = new Size(766, 361);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.tableLayoutPanel_1.ColumnCount = 1;
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_1.Controls.Add(this.toolStrip_0, 0, 0);
			this.tableLayoutPanel_1.Controls.Add(this.dataGridView_0, 0, 1);
			this.tableLayoutPanel_1.Dock = DockStyle.Fill;
			this.tableLayoutPanel_1.Location = new Point(291, 3);
			this.tableLayoutPanel_1.Name = "tableLayoutPanel2";
			this.tableLayoutPanel_1.RowCount = 2;
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.Size = new Size(472, 323);
			this.tableLayoutPanel_1.TabIndex = 0;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripButton_2
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "tsValue";
			this.toolStrip_0.Size = new Size(472, 24);
			this.toolStrip_0.TabIndex = 0;
			this.toolStrip_0.Text = "toolStrip2";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources._1304663065_Add;
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "tsbAddValue";
			this.toolStripButton_0.Size = new Size(23, 21);
			this.toolStripButton_0.Text = "Добавить значение состояния";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources._1304663141_Pen;
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "tsbEditValue";
			this.toolStripButton_1.Size = new Size(23, 21);
			this.toolStripButton_1.Text = "Редактировать значение состояния";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources.Delete;
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "tsbDelValue";
			this.toolStripButton_2.Size = new Size(23, 21);
			this.toolStripButton_2.Text = "Удалить значение состояния";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.AllowUserToResizeRows = false;
			this.dataGridView_0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridView_0.BackgroundColor = Color.White;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7
			});
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.White;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = Color.Black;
			dataGridViewCellStyle.SelectionBackColor = Color.White;
			dataGridViewCellStyle.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.Location = new Point(3, 27);
			this.dataGridView_0.MultiSelect = false;
			this.dataGridView_0.Name = "dgvValueList";
			this.dataGridView_0.ReadOnly = true;
			this.dataGridView_0.RowHeadersVisible = false;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(466, 293);
			this.dataGridView_0.TabIndex = 1;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "id";
			this.dataGridViewTextBoxColumn_0.Name = "id";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_1.HeaderText = "ParentId";
			this.dataGridViewTextBoxColumn_1.Name = "ParentId";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "TypeDoc";
			this.dataGridViewTextBoxColumn_2.HeaderText = "TypeDoc";
			this.dataGridViewTextBoxColumn_2.Name = "TypeDoc";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_3.HeaderText = "Значения";
			this.dataGridViewTextBoxColumn_3.Name = "NameValue";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "isGroup";
			this.dataGridViewTextBoxColumn_4.HeaderText = "isGroup";
			this.dataGridViewTextBoxColumn_4.Name = "isGroup";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_5.HeaderText = "Deleted";
			this.dataGridViewTextBoxColumn_5.Name = "Deleted";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "User";
			this.dataGridViewTextBoxColumn_6.HeaderText = "User";
			this.dataGridViewTextBoxColumn_6.Name = "User";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn_7.HeaderText = "Date";
			this.dataGridViewTextBoxColumn_7.Name = "Date";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.tableLayoutPanel_2.ColumnCount = 1;
			this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_2.Controls.Add(this.toolStrip_1, 0, 0);
			this.tableLayoutPanel_2.Controls.Add(this.treeView_0, 0, 1);
			this.tableLayoutPanel_2.Dock = DockStyle.Fill;
			this.tableLayoutPanel_2.Location = new Point(3, 3);
			this.tableLayoutPanel_2.Name = "tableLayoutPanel3";
			this.tableLayoutPanel_2.RowCount = 2;
			this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
			this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_2.Size = new Size(282, 323);
			this.tableLayoutPanel_2.TabIndex = 1;
			this.toolStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_6,
				this.toolStripButton_3,
				this.toolStripButton_4,
				this.toolStripTextBox_0,
				this.toolStripButton_5,
				this.toolStripSeparator_1,
				this.toolStripButton_7
			});
			this.toolStrip_1.Location = new Point(0, 0);
			this.toolStrip_1.Name = "tsGroup";
			this.toolStrip_1.Size = new Size(282, 24);
			this.toolStrip_1.TabIndex = 0;
			this.toolStrip_1.Text = "toolStrip1";
			this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_6.Image = Resources.ElementAdd;
			this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_6.Name = "tsbAddElement";
			this.toolStripButton_6.Size = new Size(23, 21);
			this.toolStripButton_6.Text = "Добавить";
			this.toolStripButton_6.Click += this.toolStripMenuItem_0_Click;
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = Resources.ElementEdit;
			this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_3.Name = "tsbEditElement";
			this.toolStripButton_3.Size = new Size(23, 21);
			this.toolStripButton_3.Text = "Редактировать";
			this.toolStripButton_3.Click += this.toolStripMenuItem_1_Click;
			this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_4.Image = Resources.ElementDel;
			this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_4.Name = "tsbDeletedElement";
			this.toolStripButton_4.Size = new Size(23, 21);
			this.toolStripButton_4.Text = "Удалить";
			this.toolStripButton_4.Click += this.toolStripMenuItem_2_Click;
			this.toolStripTextBox_0.Name = "tstbFindText";
			this.toolStripTextBox_0.Size = new Size(100, 24);
			this.toolStripTextBox_0.KeyDown += this.toolStripTextBox_0_KeyDown;
			this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_5.Image = Resources.Find;
			this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_5.Name = "tsbTreeFind";
			this.toolStripButton_5.Size = new Size(23, 21);
			this.toolStripButton_5.Text = "Поиск документа";
			this.toolStripButton_5.Click += this.toolStripButton_5_Click;
			this.toolStripSeparator_1.Name = "toolStripSeparator1";
			this.toolStripSeparator_1.Size = new Size(6, 24);
			this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_7.Image = Resources.refresh_16;
			this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_7.Name = "tsbUpdate";
			this.toolStripButton_7.Size = new Size(23, 21);
			this.toolStripButton_7.Text = "Обновить";
			this.toolStripButton_7.Click += this.toolStripButton_7_Click;
			this.treeView_0.Dock = DockStyle.Fill;
			this.treeView_0.ImageIndex = 0;
			this.treeView_0.ImageList = this.imageList_0;
			this.treeView_0.Location = new Point(3, 27);
			this.treeView_0.Name = "trvDocuments";
			this.treeView_0.SelectedImageIndex = 0;
			this.treeView_0.ShowNodeToolTips = true;
			this.treeView_0.Size = new Size(276, 293);
			this.treeView_0.StateImageList = this.imageList_0;
			this.treeView_0.TabIndex = 1;
			this.treeView_0.AfterSelect += this.treeView_0_AfterSelect;
			this.imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList.ImageStream");
			this.imageList_0.TransparentColor = Color.Transparent;
			this.imageList_0.Images.SetKeyName(0, "Folder");
			this.imageList_0.Images.SetKeyName(1, "Document");
			this.imageList_0.Images.SetKeyName(2, "Group");
			this.imageList_0.Images.SetKeyName(3, "Element");
			this.button_0.Dock = DockStyle.Right;
			this.button_0.Location = new Point(656, 332);
			this.button_0.Margin = new Padding(3, 3, 25, 3);
			this.button_0.Name = "btnClose";
			this.button_0.Size = new Size(85, 26);
			this.button_0.TabIndex = 2;
			this.button_0.Text = "Закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.dsDocuments_0.DataSetName = "dsDocuments";
			this.dsDocuments_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_1,
				this.toolStripSeparator_0,
				this.toolStripMenuItem_2
			});
			this.contextMenuStrip_0.Name = "cmsGroup";
			this.contextMenuStrip_0.Size = new Size(155, 76);
			this.toolStripMenuItem_0.Image = Resources.ElementAdd;
			this.toolStripMenuItem_0.Name = "tscmiAddGroup";
			this.toolStripMenuItem_0.Size = new Size(154, 22);
			this.toolStripMenuItem_0.Text = "Добавить";
			this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
			this.toolStripMenuItem_1.Image = Resources.ElementEdit;
			this.toolStripMenuItem_1.Name = "tscmiEditGroup";
			this.toolStripMenuItem_1.Size = new Size(154, 22);
			this.toolStripMenuItem_1.Text = "Редактировать";
			this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
			this.toolStripSeparator_0.Name = "tssGroup";
			this.toolStripSeparator_0.Size = new Size(151, 6);
			this.toolStripMenuItem_2.Image = Resources.ElementDel;
			this.toolStripMenuItem_2.Name = "tscmiDeleteGroup";
			this.toolStripMenuItem_2.Size = new Size(154, 22);
			this.toolStripMenuItem_2.Text = "Удалить";
			this.toolStripMenuItem_2.Click += this.toolStripMenuItem_2_Click;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_8.HeaderText = "id";
			this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_9.HeaderText = "ParentId";
			this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "TypeDoc";
			this.dataGridViewTextBoxColumn_10.HeaderText = "TypeDoc";
			this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.Visible = false;
			this.dataGridViewTextBoxColumn_11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_11.HeaderText = "Значения";
			this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "isGroup";
			this.dataGridViewTextBoxColumn_12.HeaderText = "isGroup";
			this.dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_13.HeaderText = "Deleted";
			this.dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.Visible = false;
			this.dataGridViewTextBoxColumn_14.DataPropertyName = "User";
			this.dataGridViewTextBoxColumn_14.HeaderText = "User";
			this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewTextBoxColumn_14.Visible = false;
			this.dataGridViewTextBoxColumn_15.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn_15.HeaderText = "Date";
			this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_15.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(766, 361);
			base.Controls.Add(this.tableLayoutPanel_0);
			this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			base.Name = "FormDocValueList";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Перечень состояний оборудования паспорта";
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_1.ResumeLayout(false);
			this.tableLayoutPanel_1.PerformLayout();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			this.tableLayoutPanel_2.ResumeLayout(false);
			this.tableLayoutPanel_2.PerformLayout();
			this.toolStrip_1.ResumeLayout(false);
			this.toolStrip_1.PerformLayout();
			((ISupportInitialize)this.dsDocuments_0).EndInit();
			this.contextMenuStrip_0.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private const int int_0 = 682;

		private const string string_0 = ";TypeDoc;tPassport;";

		private List<int> list_0 = new List<int>();

		private int int_1 = -1;

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private TableLayoutPanel tableLayoutPanel_1;

		private TableLayoutPanel tableLayoutPanel_2;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripButton toolStripButton_2;

		private ToolStrip toolStrip_1;

		private ToolStripButton toolStripButton_3;

		private ToolStripButton toolStripButton_4;

		private TreeView treeView_0;

		private ImageList imageList_0;

		private dsDocuments dsDocuments_0;

		private DataGridView dataGridView_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private Button button_0;

		private ToolStripTextBox toolStripTextBox_0;

		private ToolStripButton toolStripButton_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private ToolStripButton toolStripButton_6;

		private ContextMenuStrip contextMenuStrip_0;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripMenuItem toolStripMenuItem_1;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripMenuItem toolStripMenuItem_2;

		private ToolStripSeparator toolStripSeparator_1;

		private ToolStripButton toolStripButton_7;
	}
}
