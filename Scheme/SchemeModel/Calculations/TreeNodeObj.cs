using System;
using System.Collections.Generic;

namespace SchemeModelN.Calculations
{
	public class TreeNodeObj
	{
        /// <summary>
        /// список узлов
        /// </summary>
		public IEnumerable<TreeNodeObj> Nodes
		{
			get
			{
				return this.listNodeSchmObj;
			}
		}
        /// <summary>
        /// родитель ветки (объект схемы)
        /// </summary>
		public TreeNodeObj Parent
		{
			get
			{
				return this.SchmObj;
			}
		}
        /// <summary>
        /// уровень от корня (начала) ветки
        /// </summary>
		public int Level
		{
			get
			{
				return this.level;
			}
			set
			{
				this.level = value;
				foreach (TreeNodeObj node in this.listNodeSchmObj)
				{
					node.Level = this.Level + 1;
				}
			}
		}
        /// <summary>
        /// статус корня (узла)
        /// </summary>
		public bool IsRoot
		{
			get
			{
				return this.Level == 0;
			}
		}
        /// <summary>
        /// статус ветки
        /// </summary>
		public bool IsLeaf
		{
			get
			{
				return this.listNodeSchmObj.Count == 0;
			}
		}
        /// <summary>
        /// вернуть родителя (с верхнего уровня)
        /// </summary>
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
        /// <summary>
        /// список всех подчиненных веток
        /// </summary>
		public IEnumerable<TreeNodeObj> LeafsList
		{
			get
			{
				List<TreeNodeObj> list = new List<TreeNodeObj>();
				this.AddLeafsList(list, this);
				return list;
			}
		}

		public TreeNodeObj AddNode()
		{
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.SchmObj = this;
			treeNodeObj.Level = this.Level + 1;
			this.listNodeSchmObj.Add(treeNodeObj);
			return treeNodeObj;
		}

		public void AddNode(TreeNodeObj node)
		{
			node.SchmObj = this;
			node.Level = this.Level + 1;
			this.listNodeSchmObj.Add(node);
		}

		public void RemoveNode(TreeNodeObj node)
		{
			node.SchmObj = null;
			this.listNodeSchmObj.Remove(node);
			node.Level = 0;
		}

		public void Clear()
		{
			while (this.listNodeSchmObj.Count > 0)
			{
				TreeNodeObj treeNodeObj = this.listNodeSchmObj[0];
				treeNodeObj.Clear();
				this.RemoveNode(treeNodeObj);
			}
		}

		private void AddLeafsList(List<TreeNodeObj> listNode, TreeNodeObj ParentNode)
		{
			if (ParentNode.IsLeaf)
			{
				listNode.Add(ParentNode);
				return;
			}
			foreach (TreeNodeObj node in ParentNode.Nodes)
			{
				this.AddLeafsList(listNode, node);
			}
		}

		public TreeNodeObj()
		{
			
			this.listNodeSchmObj = new List<TreeNodeObj>();
			
		}

		private TreeNodeObj SchmObj;

		private List<TreeNodeObj> listNodeSchmObj;

		private int level;
        /// <summary>
        /// описание объекта ветки ()
        /// </summary>
		public object Tag;
	}
}
