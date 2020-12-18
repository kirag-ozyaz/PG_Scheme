using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DataSql;
using SchemeCtrl2.Data;

namespace SchemeCtrl2.TreeViewSchmObjects
{
	public class TreeViewSchmObjects : TreeView
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_0()
		{
			base.SuspendLayout();
			base.BeforeExpand += this.TreeViewSchmObjects_BeforeExpand;
			base.ResumeLayout(false);
		}

		public SQLSettings SqlSettings
		{
			get
			{
				return this.sqlsettings_0;
			}
			set
			{
				this.sqlsettings_0 = value;
			}
		}

		public TreeViewSchmObjects()
		{
			this.method_0();
		}

		public void Load()
		{
			if (this.SqlSettings == null)
			{
				return;
			}
			DataSetScheme dataSetScheme = new DataSetScheme();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name");
			base.BeginUpdate();
			foreach (object obj in dataSetScheme.tR_Classifier.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				TreeNode treeNode = base.Nodes.Add(dataRow["SocrName"].ToString());
				treeNode.Tag = dataRow["id"];
				sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.vSchm_ObjList, true, " where typeCodeId = " + dataRow["id"].ToString() + " and deleted = 0 order by name");
				foreach (DataRow dataRow2 in dataSetScheme.vSchm_ObjList)
				{
					TreeNode treeNode2 = treeNode.Nodes.Add(dataRow2["typeCodeSocr"].ToString() + "-" + dataRow2["Name"].ToString());
					treeNode2.Tag = dataRow2["id"];
					treeNode2.Nodes.Add("");
				}
			}
			base.EndUpdate();
		}

		public void Find(string textFind)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_1(base.Nodes, list_);
			TreeNode treeNode = this.method_2(list_, base.SelectedNode, textFind, TreeViewSchmObjects.Enum4.const_0);
			if (treeNode != null)
			{
				base.SelectedNode = treeNode;
				base.SelectedNode.Expand();
			}
		}

		public void FindPrev(string textFind)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_1(base.Nodes, list_);
			TreeNode treeNode = this.method_2(list_, base.SelectedNode, textFind, TreeViewSchmObjects.Enum4.const_2);
			if (treeNode != null)
			{
				base.SelectedNode = treeNode;
				base.SelectedNode.Expand();
			}
		}

		public void FindNext(string textFind)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_1(base.Nodes, list_);
			TreeNode treeNode = this.method_2(list_, base.SelectedNode, textFind, TreeViewSchmObjects.Enum4.const_1);
			if (treeNode != null)
			{
				base.SelectedNode = treeNode;
				base.SelectedNode.Expand();
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

		private TreeNode method_2(List<TreeNode> list_0, TreeNode treeNode_0, string string_0, TreeViewSchmObjects.Enum4 enum4_0)
		{
			bool flag = enum4_0 == TreeViewSchmObjects.Enum4.const_0;
			if (enum4_0 == TreeViewSchmObjects.Enum4.const_2)
			{
				list_0.Reverse();
			}
			foreach (TreeNode treeNode in list_0)
			{
				if ((flag || treeNode_0 == null) && treeNode.Text.ToUpper().Contains(string_0.ToUpper()))
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

		private void method_3(TreeNode treeNode_0)
		{
			if (this.SqlSettings == null)
			{
				return;
			}
			DataSetScheme dataSetScheme = new DataSetScheme();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.vSchm_TreeCellLine, true, " where ParentLink = " + treeNode_0.Tag.ToString());
			foreach (DataRow dataRow in dataSetScheme.vSchm_TreeCellLine)
			{
				TreeNode treeNode = treeNode_0.Nodes.Add(dataRow["FullName"].ToString());
				treeNode.Tag = dataRow["id"];
				this.method_4(treeNode);
				this.method_5(treeNode);
			}
		}

		private void method_4(TreeNode treeNode_0)
		{
			if (this.SqlSettings == null)
			{
				return;
			}
			DataSetScheme dataSetScheme = new DataSetScheme();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_Relation, true, " where Edge = " + treeNode_0.Tag.ToString());
			if (dataSetScheme.tSchm_Relation.Rows.Count > 0)
			{
				string text = "";
				foreach (DataRow dataRow in dataSetScheme.tSchm_Relation)
				{
					text = text + dataRow["id"].ToString() + ",";
				}
				text = text.Remove(text.Length - 1);
				sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.vSchm_ObjList, true, " where idparent in (" + text + ") and deleted = 0");
				foreach (DataRow dataRow2 in dataSetScheme.vSchm_ObjList)
				{
					TreeNode treeNode = treeNode_0.Nodes.Add(dataRow2["TypeCodeSocr"].ToString() + " - " + dataRow2["Name"].ToString());
					treeNode.Tag = dataRow2["id"];
				}
			}
		}

		private void method_5(TreeNode treeNode_0)
		{
			if (this.SqlSettings == null)
			{
				return;
			}
			DataSetScheme dataSetScheme = new DataSetScheme();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.vSchm_TreeCellLine, true, " where ParentLink = " + treeNode_0.Tag.ToString());
			foreach (DataRow dataRow in dataSetScheme.vSchm_TreeCellLine)
			{
				TreeNode treeNode = treeNode_0.Nodes.Add(dataRow["FullName"].ToString());
				treeNode.Tag = dataRow["id"];
			}
		}

		private void TreeViewSchmObjects_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node.Nodes.Count > 0 && e.Node.Level > 0)
			{
				if (this.SqlSettings == null)
				{
					return;
				}
				DataSetScheme dataSetScheme = new DataSetScheme();
				SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
				e.Node.Nodes.Clear();
				switch (e.Node.Level)
				{
				case 1:
				{
					sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tR_Classifier, true, " where ParentKey like ';SCM;BUS;%' and deleted = 0 and isgroup = 0 ");
					string text = "";
					foreach (object obj in dataSetScheme.tR_Classifier.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						text = text + dataRow["id"].ToString() + ",";
					}
					text = text.Remove(text.Length - 1);
					sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.vSchm_ObjList, true, string.Concat(new string[]
					{
						" where idParent = ",
						e.Node.Tag.ToString(),
						" and typecodeId in (",
						text,
						") and deleted = 0"
					}));
					using (IEnumerator<DataSetScheme.Class53> enumerator2 = dataSetScheme.vSchm_ObjList.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = enumerator2.Current;
							TreeNode treeNode = e.Node.Nodes.Add(dataRow2["TypeCodeSocr"].ToString() + " - " + dataRow2["Name"].ToString());
							treeNode.Tag = dataRow2["id"];
							treeNode.Nodes.Add("");
						}
						return;
					}
					break;
				}
				case 2:
					break;
				case 3:
					goto IL_288;
				default:
					return;
				}
				sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.vSchm_TreeCellLine, true, " where ParentLink = " + e.Node.Tag.ToString());
				using (IEnumerator<DataSetScheme.Class58> enumerator3 = dataSetScheme.vSchm_TreeCellLine.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						DataRow dataRow3 = enumerator3.Current;
						TreeNode treeNode2 = e.Node.Nodes.Add(dataRow3["FullName"].ToString());
						treeNode2.Tag = dataRow3["id"];
						treeNode2.Nodes.Add("");
					}
					return;
				}
				IL_288:
				sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_Relation, true, " where Edge = " + e.Node.Tag.ToString());
				if (dataSetScheme.tSchm_Relation.Rows.Count > 0)
				{
					string text = "";
					foreach (DataRow dataRow4 in dataSetScheme.tSchm_Relation)
					{
						text = text + dataRow4["id"].ToString() + ",";
					}
					text = text.Remove(text.Length - 1);
					sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.vSchm_ObjList, true, " where idparent in (" + text + ") and deleted = 0");
					foreach (DataRow dataRow5 in dataSetScheme.vSchm_ObjList)
					{
						TreeNode treeNode3 = e.Node.Nodes.Add(dataRow5["TypeCodeSocr"].ToString() + " - " + dataRow5["Name"].ToString());
						treeNode3.Tag = dataRow5["id"];
					}
				}
				sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.vSchm_TreeCellLine, true, " where ParentLink = " + e.Node.Tag.ToString());
				foreach (DataRow dataRow6 in dataSetScheme.vSchm_TreeCellLine)
				{
					TreeNode treeNode4 = e.Node.Nodes.Add(dataRow6["FullName"].ToString());
					treeNode4.Tag = dataRow6["id"];
				}
			}
		}

		private IContainer icontainer_0;

		private SQLSettings sqlsettings_0;

		private enum Enum4
		{
			const_0,
			const_1,
			const_2
		}
	}
}
