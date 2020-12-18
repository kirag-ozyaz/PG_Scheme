using System;
using System.Collections.Generic;

namespace SchemeCtrl2.Canvas
{
	public class TreeNodeObj
	{
		public IEnumerable<TreeNodeObj> Nodes
		{
			get
			{
				return this.list_0;
			}
		}

		public TreeNodeObj Parent
		{
			get
			{
				return this.treeNodeObj_0;
			}
		}

		public int Level
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
				foreach (TreeNodeObj treeNodeObj in this.list_0)
				{
					treeNodeObj.Level = this.Level + 1;
				}
			}
		}

		public bool IsRoot
		{
			get
			{
				return this.Level == 0;
			}
		}

		public bool IsLeaf
		{
			get
			{
				return this.list_0.Count == 0;
			}
		}

		public TreeNodeObj GetRoot
		{
			get
			{
				TreeNodeObj treeNodeObj = this;
				while (!treeNodeObj.IsRoot)
				{
					treeNodeObj = treeNodeObj.Parent;
				}
				return treeNodeObj;
			}
		}

		public IEnumerable<TreeNodeObj> LeafsList
		{
			get
			{
				List<TreeNodeObj> list = new List<TreeNodeObj>();
				this.method_0(list, this);
				return list;
			}
		}

		public TreeNodeObj AddNode()
		{
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.treeNodeObj_0 = this;
			treeNodeObj.Level = this.Level + 1;
			this.list_0.Add(treeNodeObj);
			return treeNodeObj;
		}

		public void AddNode(TreeNodeObj node)
		{
			node.treeNodeObj_0 = this;
			node.Level = this.Level + 1;
			this.list_0.Add(node);
		}

		public void RemoveNode(TreeNodeObj node)
		{
			node.treeNodeObj_0 = null;
			this.list_0.Remove(node);
			node.Level = 0;
		}

		public void Clear()
		{
			while (this.list_0.Count > 0)
			{
				TreeNodeObj treeNodeObj = this.list_0[0];
				treeNodeObj.Clear();
				this.RemoveNode(treeNodeObj);
			}
		}

		private void method_0(List<TreeNodeObj> list_1, TreeNodeObj treeNodeObj_1)
		{
			if (treeNodeObj_1.IsLeaf)
			{
				list_1.Add(treeNodeObj_1);
				return;
			}
			foreach (TreeNodeObj treeNodeObj_2 in treeNodeObj_1.Nodes)
			{
				this.method_0(list_1, treeNodeObj_2);
			}
		}

		private TreeNodeObj treeNodeObj_0;

		private List<TreeNodeObj> list_0 = new List<TreeNodeObj>();

		private int int_0;

		public object Tag;
	}
}
