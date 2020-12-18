using System;
using System.Collections.Generic;
using System.Windows.Forms;

internal static class FindElementTreeNode
{
	internal static bool Find(this TreeView treeView, string stringSearch, FindElementTreeNode.eSearchNode eSearchNode)
	{
		List<TreeNode> listBranchesTree_ = new List<TreeNode>();
		listBranchesTree_ = FindElementTreeNode.GetListBranchesTree(treeView.Nodes, listBranchesTree_);
		TreeNode treeNode = FindElementTreeNode.GetSearchNode(listBranchesTree_, treeView.SelectedNode, stringSearch, eSearchNode);
		if (treeNode != null)
		{
			treeView.SelectedNode = treeNode;
			treeView.SelectedNode.Expand();
			return true;
		}
		return false;
	}

    /// <summary>
    /// собрать все ветки для поиска
    /// </summary>
	private static List<TreeNode> GetListBranchesTree(TreeNodeCollection treeNodeCollection, List<TreeNode> list)
	{
		foreach (TreeNode treeNode in treeNodeCollection)
		{
			list.Add(treeNode);
			list = FindElementTreeNode.GetListBranchesTree(treeNode.Nodes, list);
		}
		return list;
	}
    /// <summary>
    ///  вернуть найденную ветку
    /// </summary>
	private static TreeNode GetSearchNode(List<TreeNode> list, TreeNode treeNode, string stringSearch, FindElementTreeNode.eSearchNode eSearchNode)
	{
		bool flag = (eSearchNode == FindElementTreeNode.eSearchNode.First) || (treeNode == null);
		if (eSearchNode == (FindElementTreeNode.eSearchNode.Prev))
		{
			list.Reverse();
		}
		foreach (TreeNode node in list)
		{
			if (flag && node.Text.ToUpper().Contains(stringSearch.ToUpper()))
			{
				return node;
			}
			if (node == treeNode)
			{
				flag = true;
			}
		}
		return null;
	}

	internal enum eSearchNode
	{
        First,
        Next,
        Prev
    }
}
