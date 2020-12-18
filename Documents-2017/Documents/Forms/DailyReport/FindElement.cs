using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal static class FindElementTreeNode
{
    internal static bool Find(this TreeView treeView_0, string string_0, eSearchNode enum20_0)
    {
        List<TreeNode> list = new List<TreeNode>();
        TreeNode node = smethod_2(smethod_1(treeView_0.Nodes, list), treeView_0.SelectedNode, string_0, enum20_0);
        if (node != null)
        {
            treeView_0.SelectedNode = node;
            treeView_0.SelectedNode.Expand();
            return true;
        }
        return false;
    }

    private static List<TreeNode> smethod_1(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_0)
    {
        foreach (TreeNode node in treeNodeCollection_0)
        {
            list_0.Add(node);
            list_0 = smethod_1(node.Nodes, list_0);
        }
        return list_0;
    }

    private static TreeNode smethod_2(List<TreeNode> list_0, TreeNode treeNode_0, string string_0, eSearchNode enum20_0)
    {
        bool flag = (enum20_0 == eSearchNode.First) || (treeNode_0 == null);
        if (enum20_0 == eSearchNode.Prev)
        {
            list_0.Reverse();
        }
        foreach (TreeNode node in list_0)
        {
            if (flag && node.Text.ToUpper().Contains(string_0.ToUpper()))
            {
                return node;
            }
            if (node == treeNode_0)
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

