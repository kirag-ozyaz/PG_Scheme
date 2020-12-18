using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
//using Documents.Properties;
using FormLbr;
/// <summary>
/// Привязка объекта к схеме (по трансформатору)
/// </summary>
internal partial class FormSelectTrans : FormBase
{
    #region переменные
    private Dictionary<int, string> DictionaryKey;
    internal Dictionary<int, string> GetDictionaryKey()
	{
		return this.DictionaryKey;
	}

	internal void method_1(Dictionary<int, string> dictionaryKey)
	{
		this.DictionaryKey = dictionaryKey;
	}


    private bool FlagCheckBoxes;
    internal bool GetCheckBoxes()
	{
		return this.FlagCheckBoxes;
	}
	internal void SetCheckBoxes(bool flag)
	{
		this.FlagCheckBoxes = flag;
		this.treeViewSubstation.CheckBoxes = this.FlagCheckBoxes;
	}


    private int? FlagChkSelectionAllSubstantion;
    internal int? GetFlagChkSelectionAllSubstantion()
	{
		return this.FlagChkSelectionAllSubstantion;
	}
	internal void SetFlagChkSelectionAllSubstantion(int? flag)
	{
		this.chkFilterAllSubstations.Checked = (flag == null);
		this.chkFilterAllSubstations.Visible = (flag != null);
		this.FlagChkSelectionAllSubstantion = flag;
	}
    #endregion

    internal FormSelectTrans()
	{
		//
		this.DictionaryKey = new Dictionary<int, string>();
		
		this.InitializeComponent();
	}

	private void FormSelectTrans_Load(object sender, EventArgs e)
	{
		this.LoadTree();
	}

	private void LoadTree()
	{
        DailyReportN.DataSet.DataSetN tges = new DailyReportN.DataSet.DataSetN();
        base.SelectSqlData(tges, tges.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name");
		this.treeViewSubstation.BeginUpdate();
		this.treeViewSubstation.Nodes.Clear();
		foreach (DataRow dataRow in tges.tR_Classifier.Rows)
		{
			TreeNode treeNode = this.treeViewSubstation.Nodes.Add(dataRow["SocrName"].ToString());
			treeNode.Tag = dataRow["id"];
			DataTable dataTable = new DataTable();
			if (this.FlagChkSelectionAllSubstantion != null && !this.chkFilterAllSubstations.Checked)
			{
				dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("select sub.id, sub.typeCodeSocr, sub.name from tSChm_ObjList line\r\n\t                                                    inner join tSChm_Relation relLine on relLine.Edge = line.id\r\n\t                                                    inner join tSChm_Relation relCell on relCell.id <> relLine.id and (relCell.DestObj in (relLine.DestObj, relLine.SourceObj) or\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\trelCell.SourceObj in (relLine.DestObj, relLine.SourceObj))\r\n\t                                                    inner join tSchm_ObjList cell on cell.id = relCell.Edge and cell.TypeCodeId in (672,679,678,676,674,675) and cell.Deleted = 0\r\n\t                                                    inner join vSchm_ObjList sub on sub.id = cell.idparent and sub.TypeCodeId in (535,536,537,538,1034,1275) and sub.deleted = 0\r\n\t                                                    inner join tP_ObjAddress addr on addr.idObjList = line.id and addr.idStreet = {0}\r\n                                                       where line.typeCodeId in (546,547,983)\r\n\t                                                            and line.deleted = 0 and sub.typeCodeId = {1}\r\n                                                       group by  sub.id, sub.typeCodeSocr, sub.name", this.FlagChkSelectionAllSubstantion, dataRow["id"]));
			}
			else
			{
				base.SelectSqlData(tges, tges.vSchm_ObjList, true, " where typeCodeId = " + dataRow["id"].ToString() + " and deleted = 0 order by name");
				dataTable = tges.vSchm_ObjList;
			}
			foreach (DataRow dataRow2 in dataTable.Rows)
			{
				TreeNode treeNode2 = treeNode.Nodes.Add(dataRow2["typeCodeSocr"].ToString() + "-" + dataRow2["Name"].ToString());
				treeNode2.Tag = dataRow2["id"];
				treeNode2.Nodes.Add("");
			}
		}
		this.treeViewSubstation.EndUpdate();
		if (!this.chkFilterAllSubstations.Checked)
		{
			bool flag = false;
            foreach (var enumerator in treeViewSubstation.Nodes)
            {
                if (((TreeNode)enumerator).Nodes.Count > 0)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
			{
				this.chkFilterAllSubstations.Checked = true;
			}
		}
	}

	private void treeViewSubstation_BeforeExpand(object sender, TreeViewCancelEventArgs e)
	{
		if (e.Node.Nodes.Count > 0 && e.Node.Level > 0)
		{
			e.Node.Nodes.Clear();
			int level = e.Node.Level;
			if (level == 1)
			{
                DailyReportN.DataSet.DataSetN tges =   new DailyReportN.DataSet.DataSetN(); ;
                base.SelectSqlData(tges, tges.tSchm_ObjList, true, " where idParentAddl = " + e.Node.Tag.ToString() + " and typecodeid = 556 and deleted = 0");
				foreach (DataRow dataRow in tges.tSchm_ObjList)
				{
					TreeNode treeNode = e.Node.Nodes.Add(dataRow["Name"].ToString());
					treeNode.Tag = dataRow["id"];
					treeNode.Nodes.Add("");
				}
			}
		}
	}

	private void GetListChecked(TreeNode node1, List<int> list)
	{
		if (node1.Checked && node1.Tag != null && node1.Level > 1)
		{
			if (node1.Tag is int)
			{
				list.Add(Convert.ToInt32(node1.Tag));
			}
			if (node1.Tag is List<int>)
			{
				list.Add(((List<int>)node1.Tag)[0]);
			}
		}
		foreach (object obj in node1.Nodes)
		{
			TreeNode treeNode_ = (TreeNode)obj;
			this.GetListChecked(treeNode_, list);
		}
	}

	private void buttonOk_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.OK;
		this.DictionaryKey.Clear();
		if (this.GetCheckBoxes())
		{
			List<int> list = new List<int>();
			foreach (object obj in this.treeViewSubstation.Nodes)
			{
				TreeNode treeNode_ = (TreeNode)obj;
				this.GetListChecked(treeNode_, list);
			}
            foreach (int key in list)
            {
                if (!this.DictionaryKey.ContainsKey(key))
                {
                    this.DictionaryKey.Add(key, base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                    {
                            key.ToString()
                    }).ToString());
                }
            }
        }
		else if (this.treeViewSubstation.SelectedNode != null && this.treeViewSubstation.SelectedNode.Tag != null && this.treeViewSubstation.SelectedNode.Level > 1)
		{
			List<int> list2 = new List<int>();
			if (this.treeViewSubstation.SelectedNode.Tag is int)
			{
				list2.Add(Convert.ToInt32(this.treeViewSubstation.SelectedNode.Tag));
			}
			if (this.treeViewSubstation.SelectedNode.Tag is List<int>)
			{
				list2.Add(((List<int>)this.treeViewSubstation.SelectedNode.Tag)[0]);
			}
			foreach (int key2 in list2)
			{
				if (!this.DictionaryKey.ContainsKey(key2))
				{
					this.DictionaryKey.Add(key2, base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
					{
						key2.ToString()
					}).ToString());
				}
			}
		}
		base.Close();
	}

	private void tooBtnFind_Click(object sender, EventArgs e)
	{
		List<TreeNode> list_ = new List<TreeNode>();
		list_ = this.AddNodeInList(this.treeViewSubstation.Nodes, list_);
		TreeNode treeNode = this.SearchNode(list_, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, (FormSelectTrans.eSearchNode.First));
		if (treeNode != null)
		{
			this.treeViewSubstation.SelectedNode = treeNode;
			this.treeViewSubstation.SelectedNode.Expand();
		}
	}

	private void toolBtnFindNext_Click(object sender, EventArgs e)
	{
		List<TreeNode> list_ = new List<TreeNode>();
		list_ = this.AddNodeInList(this.treeViewSubstation.Nodes, list_);
		TreeNode treeNode = this.SearchNode(list_, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, (FormSelectTrans.eSearchNode.Next));
		if (treeNode != null)
		{
			this.treeViewSubstation.SelectedNode = treeNode;
			this.treeViewSubstation.SelectedNode.Expand();
		}
	}

	private void toolBtnFindPrev_Click(object sender, EventArgs e)
	{
		List<TreeNode> list_ = new List<TreeNode>();
		list_ = this.AddNodeInList(this.treeViewSubstation.Nodes, list_);
		TreeNode treeNode = this.SearchNode(list_, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, (FormSelectTrans.eSearchNode.Prev));
		if (treeNode != null)
		{
			this.treeViewSubstation.SelectedNode = treeNode;
			this.treeViewSubstation.SelectedNode.Expand();
		}
	}

	private void toolTxtFind_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Keys modifiers = e.Modifiers;
			if (modifiers == Keys.None)
			{
				this.toolBtnFindNext_Click(sender, e);
				return;
			}
			if (modifiers != Keys.Shift)
			{
				return;
			}
			this.toolBtnFindPrev_Click(sender, e);
		}
	}

	private List<TreeNode> AddNodeInList(TreeNodeCollection treeNodeCollection, List<TreeNode> list)
	{
		foreach (object obj in treeNodeCollection)
		{
			TreeNode treeNode = (TreeNode)obj;
			list.Add(treeNode);
			list = this.AddNodeInList(treeNode.Nodes, list);
		}
		return list;
	}

	private TreeNode SearchNode(List<TreeNode> nodeList, TreeNode selNode, string txt, FormSelectTrans.eSearchNode searchNode)
	{
		bool flag = searchNode == (FormSelectTrans.eSearchNode.First);
		if (searchNode == (FormSelectTrans.eSearchNode.Prev))
		{
			nodeList.Reverse();
		}
		foreach (TreeNode treeNode in nodeList)
		{
			if (flag && treeNode.Text.ToUpper().Contains(txt.ToUpper()))
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


	private void chkFilterAllSubstations_CheckedChanged(object sender, EventArgs e)
	{
		this.LoadTree();
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		base.Close();
	}


	private enum eSearchNode
	{
        First = 0,
        Next = 1,
        Prev = 2
}
}
