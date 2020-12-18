using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using ReferenceMapObj.DataSets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ReferenceMapObj
{
    public partial class FormMapObj : FormBase
	{
		public FormMapObj()
		{
			this.InitializeComponent();
            //
            //this.cmbStreet_Obl.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsStreet_Obl, "tR_KladrObj.Id", true));
        }

		private void FormMapObj_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.dsKladr, this.dsKladr.tR_Classifier, true, " where parentKey like '%;HouseParam;%' and isgroup = 0");
			base.SelectSqlData(this.dsKladr, this.dsKladr.tR_KladrObj, true);
			this.LoadTreePunkts(null);
			base.SelectSqlData(this.dsRaion_Obl, this.dsRaion_Obl.Tables["tR_KladrObj"], true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr");
			if (this.cmbRaion_Obl.SelectedIndex >= 0)
			{
				base.SelectSqlData(this.dsRaion_RaionCity, this.dsRaion_RaionCity.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbRaion_Obl.SelectedValue.ToString() + " and deleted = 0  order by name, socr");
			}
			this.cmbRaion_RaionCity.SelectedIndex = -1;
			base.SelectSqlData(this.dsStreet_Obl, this.dsStreet_Obl.Tables["tR_KladrObj"], true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr");
			if (this.cmbStreet_Obl.SelectedIndex >= 0)
			{
				base.SelectSqlData(this.dsStreet_RaionCity, this.dsStreet_RaionCity.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbRaion_Obl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
			}
			this.cmbStreet_RaionCity.SelectedIndex = -1;
		}

		private void LoadTreePunkts(TreeNode selNode)
		{
			this.treeViewPunkts.Nodes.Clear();
			string str = this.toolBtnShowDeletePunkts.Checked ? "" : " and deleted = false";
			foreach (DataRow dataRow in this.dsKladr.tR_KladrObj.Select("ParentId is NULL" + str, "name"))
			{
				TreeNode treeNode = new TreeNode(dataRow["Name"].ToString() + " " + dataRow["Socr"].ToString());
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageKey = this.GetFolderName(dataRow);
				treeNode.SelectedImageKey = this.GetFolderName(dataRow);
				this.treeViewPunkts.Nodes.Add(treeNode);
				this.LoadTreePunktsNodes(treeNode, selNode);
				if (selNode != null && Convert.ToInt32(selNode.Tag) == Convert.ToInt32(treeNode.Tag))
				{
					this.treeViewPunkts.SelectedNode = treeNode;
					this.treeViewPunkts.SelectedNode.Expand();
				}
			}
			if (selNode == null)
			{
				this.treeViewPunkts.SelectedNode = this.treeViewPunkts.Nodes[0];
			}
			this.treeViewPunkts.Nodes[0].Expand();
		}

		private void LoadTreePunktsNodes(TreeNode root, TreeNode selNode)
		{
			string str = this.toolBtnShowDeletePunkts.Checked ? "" : " and Deleted = false";
			foreach (DataRow dataRow in this.dsKladr.tR_KladrObj.Select("ParentId = " + root.Tag.ToString() + str, "Name ASC"))
			{
				TreeNode treeNode = new TreeNode(dataRow["Name"].ToString() + " " + dataRow["Socr"].ToString());
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageKey = this.GetFolderName(dataRow);
				treeNode.SelectedImageKey = this.GetFolderName(dataRow);
				root.Nodes.Add(treeNode);
				this.LoadTreePunktsNodes(treeNode, selNode);
				if (selNode != null && Convert.ToInt32(selNode.Tag) == Convert.ToInt32(treeNode.Tag))
				{
					this.treeViewPunkts.SelectedNode = treeNode;
					this.treeViewPunkts.SelectedNode.Expand();
				}
			}
		}

		private string GetFolderName(DataRow row)
		{
			if (!Convert.ToBoolean(row["Deleted"]))
			{
				return "FolderDocumentYellow.png";
			}
			return "FolderDeleteYellow.png";
		}

		private void LoadTreeRaions(TreeNode selNode)
		{
			this.treeViewRaion.Nodes.Clear();
			TreeNode treeNode = new TreeNode();
			if (this.cmbRaion_Punkt.SelectedIndex >= 0)
			{
				treeNode.Text = this.cmbRaion_Punkt.Text;
				treeNode.Tag = this.cmbRaion_Punkt.SelectedValue;
			}
			else
			{
				if (this.cmbRaion_RaionCity.SelectedIndex < 0)
				{
					return;
				}
				treeNode.Text = this.cmbRaion_RaionCity.Text;
				treeNode.Tag = this.cmbRaion_RaionCity.SelectedValue;
			}
			treeNode.ImageKey = "FolderDocumentYellow.png";
			treeNode.SelectedImageKey = "FolderDocumentYellow.png";
			this.treeViewRaion.Nodes.Add(treeNode);
			this.treeViewRaion.SelectedNode = treeNode;
			this.treeViewRaion.SelectedNode.Expand();
			DataSetKladr dataSetKladr = new DataSetKladr();
			base.SelectSqlData(dataSetKladr, dataSetKladr.tR_Classifier, true, "where parentkey like '%;CityRaion;%' and value = " + treeNode.Tag.ToString());
			if (dataSetKladr.tR_Classifier.Rows.Count <= 0)
			{
				return;
			}
			base.SelectSqlData(dataSetKladr, dataSetKladr.tR_Classifier, true, "where isGRoup = 0 and parentkey = '" + dataSetKladr.tR_Classifier.Rows[0]["ParentKey"] + "'");
			string filterExpression = this.toolBtnShowDeleteRaions.Checked ? "" : "deleted = false";
			foreach (DataRow dataRow in dataSetKladr.tR_Classifier.Select(filterExpression, "name"))
			{
				treeNode = new TreeNode(dataRow["Name"].ToString());
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageKey = this.GetFolderName(dataRow);
				treeNode.SelectedImageKey = this.GetFolderName(dataRow);
				this.treeViewRaion.Nodes[0].Nodes.Add(treeNode);
				if (selNode != null && Convert.ToInt32(selNode.Tag) == Convert.ToInt32(treeNode.Tag))
				{
					this.treeViewRaion.SelectedNode = treeNode;
					this.treeViewRaion.SelectedNode.Expand();
				}
			}
			this.treeViewRaion.Nodes[0].Expand();
		}

		private void LoadTreeStreet(TreeNode selNode)
		{
			this.treeViewStreet.Nodes.Clear();
			TreeNode treeNode = new TreeNode();
			if (this.cmbStreet_Punkt.SelectedIndex >= 0)
			{
				treeNode.Text = this.cmbStreet_Punkt.Text;
				treeNode.Tag = this.cmbStreet_Punkt.SelectedValue;
			}
			else
			{
				if (this.cmbStreet_RaionCity.SelectedIndex < 0)
				{
					return;
				}
				treeNode.Text = this.cmbStreet_RaionCity.Text;
				treeNode.Tag = this.cmbStreet_RaionCity.SelectedValue;
			}
			treeNode.ImageKey = "FolderDocumentYellow.png";
			treeNode.SelectedImageKey = "FolderDocumentYellow.png";
			this.treeViewStreet.Nodes.Add(treeNode);
			this.treeViewStreet.SelectedNode = treeNode;
			this.treeViewStreet.SelectedNode.Expand();
            DataSetKladr dataSetKladr = new DataSetKladr();
			base.SelectSqlData(dataSetKladr, dataSetKladr.tR_KladrStreet, true, "where KladrObjId = " + treeNode.Tag.ToString());
			if (dataSetKladr.tR_KladrStreet.Rows.Count <= 0)
			{
				return;
			}
			string filterExpression = this.toolBtnShowDeleteStreet.Checked ? "" : "deleted = false";
			foreach (DataRow dataRow in dataSetKladr.tR_KladrStreet.Select(filterExpression, "name, socr"))
			{
				treeNode = new TreeNode(dataRow["Name"].ToString() + " " + dataRow["Socr"].ToString());
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageKey = this.GetFolderName(dataRow);
				treeNode.SelectedImageKey = this.GetFolderName(dataRow);
				this.treeViewStreet.Nodes[0].Nodes.Add(treeNode);
				if (selNode != null && Convert.ToInt32(selNode.Tag) == Convert.ToInt32(treeNode.Tag))
				{
					this.treeViewStreet.SelectedNode = treeNode;
					this.treeViewStreet.SelectedNode.Expand();
				}
			}
			this.treeViewStreet.Nodes[0].Expand();
		}

		private void toolBtnShowDeletePunkts_Click(object sender, EventArgs e)
		{
			this.LoadTreePunkts(this.treeViewPunkts.SelectedNode);
		}

		private void toolBtnFindPunkts_Click(object sender, EventArgs e)
		{
			this.SearchInTreeView(this.treeViewPunkts, this.toolTxtFindPunkts.Text);
		}

		private void toolTxtFindPunkts_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.SearchInTreeView(this.treeViewPunkts, this.toolTxtFindPunkts.Text);
			}
		}

		private void treeViewPunkts_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string str = this.toolBtnShowDeleteMapObj.Checked ? "" : " and deleted = 0";
			base.SelectSqlData(this.dsKladr, this.dsKladr.vMapObj, true, " where KladrObjId = " + this.treeViewPunkts.SelectedNode.Tag.ToString() + str + " order by streetname, house, houseprefix");
			this.bindingSourceMapObj.Filter = "";
			this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = true;
		}

		private void cmbRaion_Obl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbRaion_Obl.SelectedIndex < 0)
			{
				this.dsRaion_RaionCity.Tables["tR_KladrObj"].Clear();
			}
			else
			{
				base.SelectSqlData(this.dsRaion_RaionCity, this.dsRaion_RaionCity.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbRaion_Obl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
			}
			this.cmbRaion_RaionCity.SelectedIndex = -1;
		}

		private void cmbRaion_RaionCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbRaion_RaionCity.SelectedIndex < 0)
			{
				this.dsRaion_Punkt.Tables["tR_KladrObj"].Clear();
				return;
			}
			base.SelectSqlData(this.dsRaion_Punkt, this.dsRaion_Punkt.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbRaion_RaionCity.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
			this.cmbRaion_Punkt.SelectedIndex = -1;
			this.LoadTreeRaions(null);
		}

		private void cmbRaion_Punkt_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbRaion_Punkt.SelectedIndex >= 0)
			{
				this.LoadTreeRaions(null);
			}
		}

		private void toolBtnShowDeleteRaions_Click(object sender, EventArgs e)
		{
			this.LoadTreeRaions(this.treeViewRaion.SelectedNode);
		}

		private void toolBtnFindRaion_Click(object sender, EventArgs e)
		{
			this.SearchInTreeView(this.treeViewRaion, this.toolTxtFindRaion.Text);
		}

		private void aVffuKoEfC_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return && e.Modifiers == Keys.None)
			{
				this.SearchInTreeView(this.treeViewRaion, this.toolTxtFindRaion.Text);
			}
		}

		private void treeViewRaion_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string str = this.toolBtnShowDeleteMapObj.Checked ? "" : " and deleted = 0";
			if (e.Node == this.treeViewRaion.Nodes[0])
			{
				base.SelectSqlData(this.dsKladr, this.dsKladr.vMapObj, true, " where KladrObjId = " + e.Node.Tag.ToString() + str + " order by streetname, house, houseprefix");
				this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = true;
			}
			else
			{
				base.SelectSqlData(this.dsKladr, this.dsKladr.vMapObj, true, " where Raion = " + e.Node.Tag.ToString() + str + " order by streetname, house, houseprefix");
				this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = false;
			}
			this.bindingSourceMapObj.Filter = "";
		}

		private void cmbStreet_Obl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbStreet_Obl.SelectedIndex < 0)
			{
				this.dsStreet_RaionCity.Tables["tR_KladrObj"].Clear();
			}
			else
			{
				base.SelectSqlData(this.dsStreet_RaionCity, this.dsStreet_RaionCity.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbRaion_Obl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
			}
			this.cmbStreet_RaionCity.SelectedIndex = -1;
		}

		private void cmbStreet_RaionCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbStreet_RaionCity.SelectedIndex < 0)
			{
				this.dsStreet_Punkt.Tables["tR_KladrObj"].Clear();
				return;
			}
			base.SelectSqlData(this.dsStreet_Punkt, this.dsStreet_Punkt.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbStreet_RaionCity.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
			this.cmbStreet_Punkt.SelectedIndex = -1;
			this.LoadTreeStreet(null);
		}

		private void cmbStreet_Punkt_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbStreet_Punkt.SelectedIndex >= 0)
			{
				this.LoadTreeStreet(null);
			}
		}

		private void toolBtnShowDeleteStreet_Click(object sender, EventArgs e)
		{
			this.LoadTreeStreet(this.treeViewStreet.SelectedNode);
		}

		private void toolBtnFindStreet_Click(object sender, EventArgs e)
		{
			this.SearchInTreeView(this.treeViewStreet, this.toolTxtFindStreet.Text);
		}

		private void toolTxtFindStreet_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.SearchInTreeView(this.treeViewStreet, this.toolTxtFindStreet.Text);
			}
		}

		private void treeViewStreet_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string str = this.toolBtnShowDeleteMapObj.Checked ? "" : " and deleted = 0";
			if (e.Node == this.treeViewStreet.Nodes[0])
			{
				base.SelectSqlData(this.dsKladr, this.dsKladr.vMapObj, true, " where KladrObjId = " + e.Node.Tag.ToString() + str + " order by streetname, house, houseprefix");
			}
			else
			{
				base.SelectSqlData(this.dsKladr, this.dsKladr.vMapObj, true, " where street = " + e.Node.Tag.ToString() + str + " order by streetname, house, houseprefix");
			}
			this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = true;
			this.bindingSourceMapObj.Filter = "";
		}

		private void dgvMapObj_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
			if (this.dgvMapObj.RowCount > 0 && e.ColumnIndex == this.dgvMapObj.Columns["columnImage"].Index)
			{
				if (Convert.ToBoolean(this.dgvMapObj["deletedDgvCheckBoxColumn", e.RowIndex].Value))
				{
					e.Value = this.imageList.Images["ElementDelete.png"];
					return;
				}
				e.Value = this.imageList.Images["Element.png"];
			}
		}

		private void dgvMapObj_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			base.SelectSqlData(this.dsKladr, this.dsKladr.tMapObjParameter, true, " where MapObjId = " + this.dgvMapObj["idMapDgvTextBoxColumn", e.RowIndex].Value.ToString() + " order by datebegin desc");
		}

		private List<TreeNode> AddNodeInList(TreeNodeCollection tcoll, List<TreeNode> nodeList)
		{
			foreach (object obj in tcoll)
			{
				TreeNode treeNode = (TreeNode)obj;
				nodeList.Add(treeNode);
				nodeList = this.AddNodeInList(treeNode.Nodes, nodeList);
			}
			return nodeList;
		}

		private TreeNode SearchNextNode(List<TreeNode> nodeList, TreeNode selNode, string text)
		{
			bool flag = false;
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

		private void SearchInTreeView(TreeView treeView, string text)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.AddNodeInList(treeView.Nodes, list_);
			TreeNode treeNode = this.SearchNextNode(list_, treeView.SelectedNode, text);
			if (treeNode != null)
			{
				treeView.SelectedNode = treeNode;
				treeView.SelectedNode.Expand();
			}
		}

		private void ReLoadvMapObj()
		{
			string str = this.toolBtnShowDeleteMapObj.Checked ? "" : " and deleted = 0";
			if (this.tabControlTree.SelectedTab == this.tabPagePunkts)
			{
				base.SelectSqlData(this.dsKladr, this.dsKladr.vMapObj, true, " where KladrObjId = " + this.treeViewPunkts.SelectedNode.Tag.ToString() + str + " order by streetname, house, houseprefix");
				this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = true;
			}
			if (this.tabControlTree.SelectedTab == this.tabPageRaions)
			{
                if (this.treeViewRaion.SelectedNode != null || this.treeViewRaion.Nodes.Count != 0)
                    if (this.treeViewRaion.SelectedNode == this.treeViewRaion.Nodes[0])
                    {
                        base.SelectSqlData(this.dsKladr, this.dsKladr.vMapObj, true, " where KladrObjId = " + this.treeViewRaion.SelectedNode.Tag.ToString() + str + " order by streetname, house, houseprefix");
                        this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = true;
                    }
                    else
                    {
                        base.SelectSqlData(this.dsKladr, this.dsKladr.vMapObj, true, " where Raion = " + this.treeViewRaion.SelectedNode.Tag.ToString() + str + " order by streetname, house, houseprefix");
                        this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = false;
                    }
            }
            if (this.tabControlTree.SelectedTab == this.tabPageStreet)
            {
                if (this.treeViewStreet.SelectedNode != null || this.treeViewStreet.Nodes.Count != 0)
                    if (this.treeViewStreet.SelectedNode == this.treeViewStreet.Nodes[0])
                    {
                        base.SelectSqlData(this.dsKladr, this.dsKladr.vMapObj, true, " where KladrObjId = " + this.treeViewStreet.SelectedNode.Tag.ToString() + str + " order by streetname, house, houseprefix");
                    }
                    else
                    {
                        base.SelectSqlData(this.dsKladr, this.dsKladr.vMapObj, true, " where street = " + this.treeViewStreet.SelectedNode.Tag.ToString() + str + " order by streetname, house, houseprefix");
                    }
                this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = true;
            }
            this.bindingSourceMapObj.Filter = "";
        }

		private void toolBtnShowDeleteMapObj_Click(object sender, EventArgs e)
		{
			this.ReLoadvMapObj();
		}

		private void toolBtnAddObj_Click(object sender, EventArgs e)
		{
			if (new FormMapObjAddEdit(-1)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				this.ReLoadvMapObj();
			}
		}

		private void toolBtnEditObj_Click(object sender, EventArgs e)
		{
			if (this.dgvMapObj.CurrentRow == null)
			{
				return;
			}
			if (new FormMapObjAddEdit((int)this.dgvMapObj.CurrentRow.Cells["idMapDgvTextBoxColumn"].Value)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				this.ReLoadvMapObj();
			}
		}

		private void toolBtnDelObj_Click(object sender, EventArgs e)
		{
			if (this.dgvMapObj.CurrentRow == null)
			{
				return;
			}
			bool flag;
			if (Convert.ToBoolean(this.dgvMapObj.CurrentRow.Cells["deletedDgvCheckBoxColumn"].Value))
			{
				if (MessageBox.Show("Вы действительно хотите отменить пометку на удаление?", "Отмена удаления", MessageBoxButtons.YesNo) != DialogResult.Yes)
				{
					return;
				}
				this.dgvMapObj.CurrentRow.Cells["deletedDgvCheckBoxColumn"].Value = false;
				flag = false;
			}
			else
			{
				if (MessageBox.Show("Вы действительно хотите поменить на удаление выбранный элемент?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
				{
					return;
				}
				this.dgvMapObj.CurrentRow.Cells["deletedDgvCheckBoxColumn"].Value = true;
				flag = true;
			}
			this.dgvMapObj.EndEdit();
			base.SelectSqlData(this.dsKladr, this.dsKladr.tMapObj, true, "where idMap = " + this.dgvMapObj.CurrentRow.Cells["idMapDgvTextBoxColumn"].Value.ToString());
			this.dsKladr.tMapObj.Rows[0]["Deleted"] = flag;
			this.dsKladr.tMapObj.Rows[0].EndEdit();
			if (base.UpdateSqlData(this.dsKladr, this.dsKladr.tMapObj))
			{
				this.ReLoadvMapObj();
				if (flag)
				{
					MessageBox.Show("Выбранный элемент помечен на удаление");
					return;
				}
				MessageBox.Show("Пометка на удаления успешна снята");
			}
		}

		private void toolBtnDelObjFull_Click(object sender, EventArgs e)
		{
			if (this.dgvMapObj.CurrentRow == null)
			{
				return;
			}
			if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				base.SelectSqlData(this.dsKladr, this.dsKladr.tMapObj, true, "where idMap = " + this.dgvMapObj.CurrentRow.Cells["idMapDgvTextBoxColumn"].Value.ToString());
				this.dsKladr.tMapObj.Rows[0].Delete();
				base.DeleteSqlData(this.dsKladr, this.dsKladr.tMapObj);
				this.ReLoadvMapObj();
				MessageBox.Show("Данные успешно удалены");
			}
		}

		private void tootBtnAddParam_Click(object sender, EventArgs e)
		{
			if (this.dgvMapObj.CurrentRow == null)
			{
				return;
			}
			if (new FormMapObjParamAddEdit(-1, (int)this.dgvMapObj.CurrentRow.Cells["idMapDgvTextBoxColumn"].Value)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.dsKladr, this.dsKladr.tMapObjParameter, true, " where MapObjId = " + this.dgvMapObj.CurrentRow.Cells["idMapDgvTextBoxColumn"].Value.ToString() + " order by datebegin desc");
			}
		}

		private void toolBtnEditParam_Click(object sender, EventArgs e)
		{
			if (this.dgvMapObjParameter.CurrentRow == null)
			{
				return;
			}
			if (new FormMapObjParamAddEdit((int)this.dgvMapObjParameter.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value, (int)this.dgvMapObj.CurrentRow.Cells["idMapDgvTextBoxColumn"].Value)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.dsKladr, this.dsKladr.tMapObjParameter, true, " where MapObjId = " + this.dgvMapObj.CurrentRow.Cells["idMapDgvTextBoxColumn"].Value.ToString() + " order by datebegin desc");
			}
		}

		private void toolBtnDelParam_Click(object sender, EventArgs e)
		{
			if (this.dgvMapObjParameter.CurrentRow == null)
			{
				return;
			}
			if (MessageBox.Show("Вы действительно хотите удалить выбранную запись с характеристиками?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.dsKladr.tMapObjParameter.FindById((int)this.dgvMapObjParameter.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value).Delete();
				base.DeleteSqlData(this.dsKladr, this.dsKladr.tMapObjParameter);
				MessageBox.Show("Данные успешно удалены");
			}
		}

		private void toolStripButtonFind_Click(object sender, EventArgs e)
		{
			this.dgvMapObj.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.toolStripTextBoxFind.Text);
		}

		private void YaqfzqmoJo_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.dgvMapObj.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxFind.Text);
			}
		}

		private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
		{
			this.dgvMapObj.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonFindNext_Click(object sender, EventArgs e)
		{
			this.dgvMapObj.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonPrint_Click(object sender, EventArgs e)
		{
			this.dgvMapObj.PrintDataGridView();
		}

		private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
		{
			this.dgvMapObj.CopyToExcel(true);
		}

		private void toolStripButtonRefresh_Click(object sender, EventArgs e)
		{
			this.ReLoadvMapObj();
		}

		private void toolMenuItemAddObj_Click(object sender, EventArgs e)
		{
			this.toolBtnAddObj_Click(sender, e);
		}

		private void toolMenuItemEditObj_Click(object sender, EventArgs e)
		{
			this.toolBtnEditObj_Click(sender, e);
		}

		private void toolMenuItemDelObjCheck_Click(object sender, EventArgs e)
		{
			this.toolBtnDelObj_Click(sender, e);
		}

		private void toolMenuItemDelObjFull_Click(object sender, EventArgs e)
		{
			this.toolBtnDelObjFull_Click(sender, e);
		}

		private void toolMenuItemCopyObj_Click(object sender, EventArgs e)
		{
			this.dgvMapObj.CopyToBuffer(false);
		}

		private void toolMenuItemExcelObj_Click(object sender, EventArgs e)
		{
			this.dgvMapObj.CopyToExcel(false);
		}

		private void toolMenuItemPrintObj_Click(object sender, EventArgs e)
		{
			this.dgvMapObj.PrintDataGridView();
		}

		private void toolMenuAddObjParam_Click(object sender, EventArgs e)
		{
			this.tootBtnAddParam_Click(sender, e);
		}

		private void toolMenuEditObjParam_Click(object sender, EventArgs e)
		{
			this.toolBtnEditParam_Click(sender, e);
		}

		private void toolMenuItemDelObjParam_Click(object sender, EventArgs e)
		{
			this.toolBtnDelParam_Click(sender, e);
		}

		private void toolMenuCopyObjParam_Click(object sender, EventArgs e)
		{
			this.dgvMapObjParameter.CopyToBuffer(false);
		}

		private void toolMenuExportObjParam_Click(object sender, EventArgs e)
		{
			this.dgvMapObjParameter.CopyToExcel(false);
		}

		private void toolMenuPrintObjParam_Click(object sender, EventArgs e)
		{
			this.dgvMapObjParameter.PrintDataGridView();
		}

        private void dgvMapObj_DoubleClick(object sender, EventArgs e)
        {
            toolBtnEditObj_Click(sender, e);
        }
    }
}
