using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using Reference.Properties;

namespace Reference.Forms.MapObj
{
	public partial class FormMapObj : FormBase
	{
		public FormMapObj()
		{
			
			
			this.InitializeComponent();
		}

		private void FormMapObj_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class20_0, this.class20_0.tR_Classifier, true, " where parentKey like '%;HouseParam;%' and isgroup = 0");
			base.SelectSqlData(this.class20_0, this.class20_0.tR_KladrObj, true);
			this.method_0(null);
			base.SelectSqlData(this.dataSet_3, this.dataSet_3.Tables["tR_KladrObj"], true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr");
			if (this.cmbRaion_Obl.SelectedIndex >= 0)
			{
				base.SelectSqlData(this.dataSet_2, this.dataSet_2.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbRaion_Obl.SelectedValue.ToString() + " and deleted = 0  order by name, socr");
			}
			this.cmbRaion_RaionCity.SelectedIndex = -1;
			base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tR_KladrObj"], true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr");
			if (this.cmbStreet_Obl.SelectedIndex >= 0)
			{
				base.SelectSqlData(this.dataSet_5, this.dataSet_5.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbRaion_Obl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
			}
			this.cmbStreet_RaionCity.SelectedIndex = -1;
		}

		private void method_0(TreeNode treeNode_0)
		{
			this.treeViewPunkts.Nodes.Clear();
			string str = this.toolBtnShowDeletePunkts.Checked ? "" : " and deleted = false";
			foreach (DataRow dataRow in this.class20_0.tR_KladrObj.Select("ParentId is NULL" + str, "name"))
			{
				TreeNode treeNode = new TreeNode(dataRow["Name"].ToString() + " " + dataRow["Socr"].ToString());
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageKey = this.method_2(dataRow);
				treeNode.SelectedImageKey = this.method_2(dataRow);
				this.treeViewPunkts.Nodes.Add(treeNode);
				this.method_1(treeNode, treeNode_0);
				if (treeNode_0 != null && Convert.ToInt32(treeNode_0.Tag) == Convert.ToInt32(treeNode.Tag))
				{
					this.treeViewPunkts.SelectedNode = treeNode;
					this.treeViewPunkts.SelectedNode.Expand();
				}
			}
			if (treeNode_0 == null)
			{
				this.treeViewPunkts.SelectedNode = this.treeViewPunkts.Nodes[0];
			}
			this.treeViewPunkts.Nodes[0].Expand();
		}

		private void method_1(TreeNode treeNode_0, TreeNode treeNode_1)
		{
			string str = this.toolBtnShowDeletePunkts.Checked ? "" : " and Deleted = false";
			foreach (DataRow dataRow in this.class20_0.tR_KladrObj.Select("ParentId = " + treeNode_0.Tag.ToString() + str, "Name ASC"))
			{
				TreeNode treeNode = new TreeNode(dataRow["Name"].ToString() + " " + dataRow["Socr"].ToString());
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageKey = this.method_2(dataRow);
				treeNode.SelectedImageKey = this.method_2(dataRow);
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

		private void method_3(TreeNode treeNode_0)
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
			Class20 @class = new Class20();
			base.SelectSqlData(@class, @class.tR_Classifier, true, "where parentkey like '%;CityRaion;%' and value = " + treeNode.Tag.ToString());
			if (@class.tR_Classifier.Rows.Count <= 0)
			{
				return;
			}
			base.SelectSqlData(@class, @class.tR_Classifier, true, "where isGRoup = 0 and parentkey = '" + @class.tR_Classifier.Rows[0]["ParentKey"] + "'");
			string filterExpression = this.toolBtnShowDeleteRaions.Checked ? "" : "deleted = false";
			foreach (DataRow dataRow in @class.tR_Classifier.Select(filterExpression, "name"))
			{
				treeNode = new TreeNode(dataRow["Name"].ToString());
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageKey = this.method_2(dataRow);
				treeNode.SelectedImageKey = this.method_2(dataRow);
				this.treeViewRaion.Nodes[0].Nodes.Add(treeNode);
				if (treeNode_0 != null && Convert.ToInt32(treeNode_0.Tag) == Convert.ToInt32(treeNode.Tag))
				{
					this.treeViewRaion.SelectedNode = treeNode;
					this.treeViewRaion.SelectedNode.Expand();
				}
			}
			this.treeViewRaion.Nodes[0].Expand();
		}

		private void method_4(TreeNode treeNode_0)
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
			Class20 @class = new Class20();
			base.SelectSqlData(@class, @class.tR_KladrStreet, true, "where KladrObjId = " + treeNode.Tag.ToString());
			if (@class.tR_KladrStreet.Rows.Count <= 0)
			{
				return;
			}
			string filterExpression = this.toolBtnShowDeleteStreet.Checked ? "" : "deleted = false";
			foreach (DataRow dataRow in @class.tR_KladrStreet.Select(filterExpression, "name, socr"))
			{
				treeNode = new TreeNode(dataRow["Name"].ToString() + " " + dataRow["Socr"].ToString());
				treeNode.Tag = dataRow["Id"];
				treeNode.ImageKey = this.method_2(dataRow);
				treeNode.SelectedImageKey = this.method_2(dataRow);
				this.treeViewStreet.Nodes[0].Nodes.Add(treeNode);
				if (treeNode_0 != null && Convert.ToInt32(treeNode_0.Tag) == Convert.ToInt32(treeNode.Tag))
				{
					this.treeViewStreet.SelectedNode = treeNode;
					this.treeViewStreet.SelectedNode.Expand();
				}
			}
			this.treeViewStreet.Nodes[0].Expand();
		}

		private void VommcJqdrZ(object sender, EventArgs e)
		{
			this.method_0(this.treeViewPunkts.SelectedNode);
		}

		private void toolBtnFindPunkts_Click(object sender, EventArgs e)
		{
			this.ckimLboNod(this.treeViewPunkts, this.toolTxtFindPunkts.Text);
		}

		private void toolTxtFindPunkts_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.ckimLboNod(this.treeViewPunkts, this.toolTxtFindPunkts.Text);
			}
		}

		private void treeViewPunkts_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string str = this.toolBtnShowDeleteMapObj.Checked ? "" : " and deleted = 0";
			base.SelectSqlData(this.class20_0, this.class20_0.vMapObj, true, " where KladrObjId = " + this.treeViewPunkts.SelectedNode.Tag.ToString() + str + " order by streetname, house, houseprefix");
			this.bindingSource_0.Filter = "";
			this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = true;
		}

		private void cmbRaion_Obl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbRaion_Obl.SelectedIndex < 0)
			{
				this.dataSet_2.Tables["tR_KladrObj"].Clear();
			}
			else
			{
				base.SelectSqlData(this.dataSet_2, this.dataSet_2.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbRaion_Obl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
			}
			this.cmbRaion_RaionCity.SelectedIndex = -1;
		}

		private void cmbRaion_RaionCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbRaion_RaionCity.SelectedIndex < 0)
			{
				this.dataSet_1.Tables["tR_KladrObj"].Clear();
				return;
			}
			base.SelectSqlData(this.dataSet_1, this.dataSet_1.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbRaion_RaionCity.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
			this.cmbRaion_Punkt.SelectedIndex = -1;
			this.method_3(null);
		}

		private void cmbRaion_Punkt_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbRaion_Punkt.SelectedIndex >= 0)
			{
				this.method_3(null);
			}
		}

		private void toolBtnShowDeleteRaions_Click(object sender, EventArgs e)
		{
			this.method_3(this.treeViewRaion.SelectedNode);
		}

		private void toolBtnFindRaion_Click(object sender, EventArgs e)
		{
			this.ckimLboNod(this.treeViewRaion, this.aVffuKoEfC.Text);
		}

		private void aVffuKoEfC_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return && e.Modifiers == Keys.None)
			{
				this.ckimLboNod(this.treeViewRaion, this.aVffuKoEfC.Text);
			}
		}

		private void treeViewRaion_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string str = this.toolBtnShowDeleteMapObj.Checked ? "" : " and deleted = 0";
			if (e.Node == this.treeViewRaion.Nodes[0])
			{
				base.SelectSqlData(this.class20_0, this.class20_0.vMapObj, true, " where KladrObjId = " + e.Node.Tag.ToString() + str + " order by streetname, house, houseprefix");
				this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = true;
			}
			else
			{
				base.SelectSqlData(this.class20_0, this.class20_0.vMapObj, true, " where Raion = " + e.Node.Tag.ToString() + str + " order by streetname, house, houseprefix");
				this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = false;
			}
			this.bindingSource_0.Filter = "";
		}

		private void cmbStreet_Obl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbStreet_Obl.SelectedIndex < 0)
			{
				this.dataSet_5.Tables["tR_KladrObj"].Clear();
			}
			else
			{
				base.SelectSqlData(this.dataSet_5, this.dataSet_5.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbRaion_Obl.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
			}
			this.cmbStreet_RaionCity.SelectedIndex = -1;
		}

		private void cmbStreet_RaionCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbStreet_RaionCity.SelectedIndex < 0)
			{
				this.dataSet_4.Tables["tR_KladrObj"].Clear();
				return;
			}
			base.SelectSqlData(this.dataSet_4, this.dataSet_4.Tables["tR_kladrObj"], true, " where ParentId = " + this.cmbStreet_RaionCity.SelectedValue.ToString() + " and deleted = 0 order by name, socr");
			this.cmbStreet_Punkt.SelectedIndex = -1;
			this.method_4(null);
		}

		private void cmbStreet_Punkt_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbStreet_Punkt.SelectedIndex >= 0)
			{
				this.method_4(null);
			}
		}

		private void toolBtnShowDeleteStreet_Click(object sender, EventArgs e)
		{
			this.method_4(this.treeViewStreet.SelectedNode);
		}

		private void toolBtnFindStreet_Click(object sender, EventArgs e)
		{
			this.ckimLboNod(this.treeViewStreet, this.toolTxtFindStreet.Text);
		}

		private void toolTxtFindStreet_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.ckimLboNod(this.treeViewStreet, this.toolTxtFindStreet.Text);
			}
		}

		private void treeViewStreet_AfterSelect(object sender, TreeViewEventArgs e)
		{
			string str = this.toolBtnShowDeleteMapObj.Checked ? "" : " and deleted = 0";
			if (e.Node == this.treeViewStreet.Nodes[0])
			{
				base.SelectSqlData(this.class20_0, this.class20_0.vMapObj, true, " where KladrObjId = " + e.Node.Tag.ToString() + str + " order by streetname, house, houseprefix");
			}
			else
			{
				base.SelectSqlData(this.class20_0, this.class20_0.vMapObj, true, " where street = " + e.Node.Tag.ToString() + str + " order by streetname, house, houseprefix");
			}
			this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = true;
			this.bindingSource_0.Filter = "";
		}

		private void dgvMapObj_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
			if (this.dgvMapObj.RowCount > 0 && e.ColumnIndex == this.dgvMapObj.Columns["columnImage"].Index)
			{
				if (Convert.ToBoolean(this.dgvMapObj["deletedDgvCheckBoxColumn", e.RowIndex].Value))
				{
					e.Value = this.imageList_0.Images["ElementDelete.png"];
					return;
				}
				e.Value = this.imageList_0.Images["Element.png"];
			}
		}

		private void dgvMapObj_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			base.SelectSqlData(this.class20_0, this.class20_0.tMapObjParameter, true, " where MapObjId = " + this.dgvMapObj["idMapDgvTextBoxColumn", e.RowIndex].Value.ToString() + " order by datebegin desc");
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

		private void ckimLboNod(TreeView treeView_0, string string_0)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_5(treeView_0.Nodes, list_);
			TreeNode treeNode = this.method_6(list_, treeView_0.SelectedNode, string_0);
			if (treeNode != null)
			{
				treeView_0.SelectedNode = treeNode;
				treeView_0.SelectedNode.Expand();
			}
		}

		private void method_7()
		{
			string str = this.toolBtnShowDeleteMapObj.Checked ? "" : " and deleted = 0";
			if (this.tabControlTree.SelectedTab == this.tabPagePunkts)
			{
				base.SelectSqlData(this.class20_0, this.class20_0.vMapObj, true, " where KladrObjId = " + this.treeViewPunkts.SelectedNode.Tag.ToString() + str + " order by streetname, house, houseprefix");
				this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = true;
			}
			if (this.tabControlTree.SelectedTab == this.tabPageRaions)
			{
				if (this.treeViewRaion.SelectedNode == this.treeViewRaion.Nodes[0])
				{
					base.SelectSqlData(this.class20_0, this.class20_0.vMapObj, true, " where KladrObjId = " + this.treeViewRaion.SelectedNode.Tag.ToString() + str + " order by streetname, house, houseprefix");
					this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = true;
				}
				else
				{
					base.SelectSqlData(this.class20_0, this.class20_0.vMapObj, true, " where Raion = " + this.treeViewRaion.SelectedNode.Tag.ToString() + str + " order by streetname, house, houseprefix");
					this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = false;
				}
			}
			if (this.tabControlTree.SelectedTab == this.tabPageStreet)
			{
				if (this.treeViewStreet.SelectedNode == this.treeViewStreet.Nodes[0])
				{
					base.SelectSqlData(this.class20_0, this.class20_0.vMapObj, true, " where KladrObjId = " + this.treeViewStreet.SelectedNode.Tag.ToString() + str + " order by streetname, house, houseprefix");
				}
				else
				{
					base.SelectSqlData(this.class20_0, this.class20_0.vMapObj, true, " where street = " + this.treeViewStreet.SelectedNode.Tag.ToString() + str + " order by streetname, house, houseprefix");
				}
				this.dgvMapObj.Columns["raionNameDgvTextBoxColumn"].Visible = true;
			}
			this.bindingSource_0.Filter = "";
		}

		private void toolBtnShowDeleteMapObj_Click(object sender, EventArgs e)
		{
			this.method_7();
		}

		private void QakmBsilBY(object sender, EventArgs e)
		{
			if (new FormMapObjAddEdit(-1)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				this.method_7();
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
				this.method_7();
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
			base.SelectSqlData(this.class20_0, this.class20_0.tMapObj, true, "where idMap = " + this.dgvMapObj.CurrentRow.Cells["idMapDgvTextBoxColumn"].Value.ToString());
			this.class20_0.tMapObj.Rows[0]["Deleted"] = flag;
			this.class20_0.tMapObj.Rows[0].EndEdit();
			if (base.UpdateSqlData(this.class20_0, this.class20_0.tMapObj))
			{
				this.method_7();
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
				base.SelectSqlData(this.class20_0, this.class20_0.tMapObj, true, "where idMap = " + this.dgvMapObj.CurrentRow.Cells["idMapDgvTextBoxColumn"].Value.ToString());
				this.class20_0.tMapObj.Rows[0].Delete();
				base.DeleteSqlData(this.class20_0, this.class20_0.tMapObj);
				this.method_7();
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
				base.SelectSqlData(this.class20_0, this.class20_0.tMapObjParameter, true, " where MapObjId = " + this.dgvMapObj.CurrentRow.Cells["idMapDgvTextBoxColumn"].Value.ToString() + " order by datebegin desc");
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
				base.SelectSqlData(this.class20_0, this.class20_0.tMapObjParameter, true, " where MapObjId = " + this.dgvMapObj.CurrentRow.Cells["idMapDgvTextBoxColumn"].Value.ToString() + " order by datebegin desc");
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
				this.class20_0.tMapObjParameter.method_2((int)this.dgvMapObjParameter.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value).Delete();
				base.DeleteSqlData(this.class20_0, this.class20_0.tMapObjParameter);
				MessageBox.Show("Данные успешно удалены");
			}
		}

		private void toolStripButtonFind_Click(object sender, EventArgs e)
		{
			this.dgvMapObj.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.YaqfzqmoJo.Text);
		}

		private void YaqfzqmoJo_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.dgvMapObj.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.YaqfzqmoJo.Text);
			}
		}

		private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
		{
			this.dgvMapObj.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.YaqfzqmoJo.Text);
		}

		private void toolStripButtonFindNext_Click(object sender, EventArgs e)
		{
			this.dgvMapObj.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.YaqfzqmoJo.Text);
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
			this.method_7();
		}

		private void toolMenuItemAddObj_Click(object sender, EventArgs e)
		{
			this.QakmBsilBY(sender, e);
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

		private void fCbIjhllk4_Click(object sender, EventArgs e)
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

		private void TqdIidAoTN_Click(object sender, EventArgs e)
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
	}
}
