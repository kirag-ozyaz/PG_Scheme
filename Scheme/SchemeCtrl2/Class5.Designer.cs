using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DataSql;

internal class Class5 : TreeView
{
	internal SQLSettings method_0()
	{
		return this.sqlsettings_0;
	}

	internal void method_1(SQLSettings sqlsettings_1)
	{
		this.sqlsettings_0 = sqlsettings_1;
	}

	public Class5()
	{
		
		
		this.method_10();
	}

	internal void method_2()
	{
		if (this.method_0() == null)
		{
			return;
		}
		DataSetScheme @class = new DataSetScheme();
		SqlDataCommand sqlDataCommand = new SqlDataCommand(this.method_0());
		sqlDataCommand.SelectSqlData(@class.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name", null, false, 0);
		base.BeginUpdate();
		foreach (object obj in @class.tR_Classifier.Rows)
		{
			DataRow dataRow = (DataRow)obj;
			TreeNode treeNode = base.Nodes.Add(dataRow["SocrName"].ToString());
			treeNode.Tag = dataRow["id"];
			sqlDataCommand.SelectSqlData(@class.vSchm_ObjList, true, " where typeCodeId = " + dataRow["id"].ToString() + " and deleted = 0 order by name", null, false, 0);
			foreach (DataRow dataRow2 in @class.vSchm_ObjList)
			{
				TreeNode treeNode2 = treeNode.Nodes.Add(dataRow2["typeCodeSocr"].ToString() + "-" + dataRow2["Name"].ToString());
				treeNode2.Tag = dataRow2["id"];
				treeNode2.Nodes.Add("");
			}
		}
		base.EndUpdate();
	}

	internal void method_3(string string_0)
	{
		List<TreeNode> list_ = new List<TreeNode>();
		list_ = this.method_5(base.Nodes, list_);
		TreeNode treeNode = this.method_6(list_, base.SelectedNode, string_0, (Class5.Enum0)0);
		if (treeNode != null)
		{
			base.SelectedNode = treeNode;
			base.SelectedNode.Expand();
		}
	}

	internal void DouQquBvat(string string_0)
	{
		List<TreeNode> list_ = new List<TreeNode>();
		list_ = this.method_5(base.Nodes, list_);
		TreeNode treeNode = this.method_6(list_, base.SelectedNode, string_0, (Class5.Enum0)2);
		if (treeNode != null)
		{
			base.SelectedNode = treeNode;
			base.SelectedNode.Expand();
		}
	}

	internal void method_4(string string_0)
	{
		List<TreeNode> list_ = new List<TreeNode>();
		list_ = this.method_5(base.Nodes, list_);
		TreeNode treeNode = this.method_6(list_, base.SelectedNode, string_0, (Class5.Enum0)1);
		if (treeNode != null)
		{
			base.SelectedNode = treeNode;
			base.SelectedNode.Expand();
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

	private TreeNode method_6(List<TreeNode> list_0, TreeNode treeNode_0, string string_0, Class5.Enum0 enum0_0)
	{
		bool flag = enum0_0 == (Class5.Enum0)0;
		if (enum0_0 == (Class5.Enum0)2)
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

	private void method_7(TreeNode treeNode_0)
	{
		if (this.method_0() == null)
		{
			return;
		}
		DataSetScheme @class = new DataSetScheme();
		new SqlDataCommand(this.method_0()).SelectSqlData(@class.vSchm_TreeCellLine, true, " where ParentLink = " + treeNode_0.Tag.ToString(), null, false, 0);
		foreach (DataRow dataRow in @class.vSchm_TreeCellLine)
		{
			TreeNode treeNode = treeNode_0.Nodes.Add(dataRow["FullName"].ToString());
			treeNode.Tag = dataRow["id"];
			this.method_8(treeNode);
			this.method_9(treeNode);
		}
	}

	private void method_8(TreeNode treeNode_0)
	{
		if (this.method_0() == null)
		{
			return;
		}
		DataSetScheme @class = new DataSetScheme();
		SqlDataCommand sqlDataCommand = new SqlDataCommand(this.method_0());
		sqlDataCommand.SelectSqlData(@class.tSchm_Relation, true, " where Edge = " + treeNode_0.Tag.ToString(), null, false, 0);
		if (@class.tSchm_Relation.Rows.Count > 0)
		{
			string text = "";
			foreach (DataRow dataRow in @class.tSchm_Relation)
			{
				text = text + dataRow["id"].ToString() + ",";
			}
			text = text.Remove(text.Length - 1);
			sqlDataCommand.SelectSqlData(@class.vSchm_ObjList, true, " where idparent in (" + text + ") and deleted = 0", null, false, 0);
			foreach (DataRow dataRow2 in @class.vSchm_ObjList)
			{
				treeNode_0.Nodes.Add(dataRow2["TypeCodeSocr"].ToString() + " - " + dataRow2["Name"].ToString()).Tag = dataRow2["id"];
			}
		}
	}

	private void method_9(TreeNode treeNode_0)
	{
		if (this.method_0() == null)
		{
			return;
		}
		DataSetScheme @class = new DataSetScheme();
		new SqlDataCommand(this.method_0()).SelectSqlData(@class.vSchm_TreeCellLine, true, " where ParentLink = " + treeNode_0.Tag.ToString(), null, false, 0);
		foreach (DataRow dataRow in @class.vSchm_TreeCellLine)
		{
			treeNode_0.Nodes.Add(dataRow["FullName"].ToString()).Tag = dataRow["id"];
		}
	}

	private void Class5_BeforeExpand(object sender, TreeViewCancelEventArgs e)
	{
		if (e.Node.Nodes.Count > 0 && e.Node.Level > 0)
		{
			if (this.method_0() == null)
			{
				return;
			}
			DataSetScheme @class = new DataSetScheme();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.method_0());
			e.Node.Nodes.Clear();
			switch (e.Node.Level)
			{
			case 1:
			{
				sqlDataCommand.SelectSqlData(@class.tR_Classifier, true, " where ParentKey like ';SCM;BUS;%' and deleted = 0 and isgroup = 0 ", null, false, 0);
				string text = "";
				foreach (object obj in @class.tR_Classifier.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					text = text + dataRow["id"].ToString() + ",";
				}
				text = text.Remove(text.Length - 1);
				sqlDataCommand.SelectSqlData(@class.vSchm_ObjList, true, string.Concat(new string[]
				{
					" where idParent = ",
					e.Node.Tag.ToString(),
					" and typecodeId in (",
					text,
					") and deleted = 0"
				}), null, false, 0);
				using (IEnumerator<DataSetScheme.Class59> enumerator2 = @class.vSchm_ObjList.GetEnumerator())
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
				goto IL_295;
			default:
				return;
			}
			sqlDataCommand.SelectSqlData(@class.vSchm_TreeCellLine, true, " where ParentLink = " + e.Node.Tag.ToString(), null, false, 0);
			using (IEnumerator<DataSetScheme.Class64> enumerator3 = @class.vSchm_TreeCellLine.GetEnumerator())
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
			IL_295:
			sqlDataCommand.SelectSqlData(@class.tSchm_Relation, true, " where Edge = " + e.Node.Tag.ToString(), null, false, 0);
			if (@class.tSchm_Relation.Rows.Count > 0)
			{
				string text = "";
				foreach (DataRow dataRow4 in @class.tSchm_Relation)
				{
					text = text + dataRow4["id"].ToString() + ",";
				}
				text = text.Remove(text.Length - 1);
				sqlDataCommand.SelectSqlData(@class.vSchm_ObjList, true, " where idparent in (" + text + ") and deleted = 0", null, false, 0);
				foreach (DataRow dataRow5 in @class.vSchm_ObjList)
				{
					e.Node.Nodes.Add(dataRow5["TypeCodeSocr"].ToString() + " - " + dataRow5["Name"].ToString()).Tag = dataRow5["id"];
				}
			}
			sqlDataCommand.SelectSqlData(@class.vSchm_TreeCellLine, true, " where ParentLink = " + e.Node.Tag.ToString(), null, false, 0);
			foreach (DataRow dataRow6 in @class.vSchm_TreeCellLine)
			{
				e.Node.Nodes.Add(dataRow6["FullName"].ToString()).Tag = dataRow6["id"];
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_10()
	{
		base.SuspendLayout();
		base.BeforeExpand += this.Class5_BeforeExpand;
		base.ResumeLayout(false);
	}

	private SQLSettings sqlsettings_0;

	private IContainer icontainer_0;

	private enum Enum0
	{

	}
}
