using System;
using System.Collections;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataSql;
//using Documents.Properties;
using FormLbr;
/// <summary>
/// Привязка объекта к схеме
/// </summary>
internal partial class FormSelectSchmObj : FormBase
{
    #region переменные
    ///  public Dictionary<int, string> Dictionary_0 { get => dictionary_0; set => dictionary_0 = value; }
    private Dictionary<int, string> DictionaryKey;
    internal Dictionary<int, string> GetDictionaryKey()
	{
		return this.DictionaryKey;
	}
	internal void SetDictionaryKey(Dictionary<int, string> key)
	{
		this.DictionaryKey = key;
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
    internal FormSelectSchmObj()
	{
		////
		this.DictionaryKey = new Dictionary<int, string>();
		
		this.InitializeComponent();
	}

	private void FormSelectSchmObj_Load(object sender, EventArgs e)
	{
		this.LoadTree();
	}

	private void LoadTree()
	{
        //Class255 tges = new Class255();
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
            DailyReportN.DataSet.DataSetN tges;
            if (level != 1)
			{
				if (level != 2)
				{
					return;
				}
                tges = new DailyReportN.DataSet.DataSetN();
                string text = "";
				if (e.Node.Tag is int)
				{
					text = e.Node.Tag.ToString();
				}
				if (e.Node.Tag is List<int>)
				{
					foreach (int num in ((List<int>)e.Node.Tag))
					{
						if (string.IsNullOrEmpty(text))
						{
							text = num.ToString();
						}
						else
						{
							text = text + "," + num.ToString();
						}
					}
				}
				base.SelectSqlData(tges, tges.vSchm_TreeCellLine, true, " where ParentLink in (" + text + ")");

                foreach (DataRow row in tges.vSchm_TreeCellLine)
                {
                    e.Node.Nodes.Add(row["FullName"].ToString()).Tag = row["id"];
                }
                return;
            }
            tges = new DailyReportN.DataSet.DataSetN();
            base.SelectSqlData(tges, tges.tR_Classifier, true, " where ParentKey like ';SCM;BUS;%' and deleted = 0 and isgroup = 0 ");
			string text2 = "";
			foreach (object obj2 in tges.tR_Classifier.Rows)
			{
				DataRow dataRow2 = (DataRow)obj2;
				text2 = text2 + dataRow2["id"].ToString() + ",";
			}
			text2 = text2.Remove(text2.Length - 1);
			base.SelectSqlData(tges, tges.vSchm_ObjList, true, string.Concat(new string[]
			{
				" where idParent = ",
				e.Node.Tag.ToString(),
				" and typecodeId in (",
				text2,
				") and deleted = 0"
			}));
			if (!this.checkBoxUseBusParent.Checked)
			{
                foreach (DataRow row2 in tges.vSchm_ObjList)
                {
                    TreeNode node1 = e.Node.Nodes.Add(row2["TypeCodeSocr"].ToString() + " - " + row2["Name"].ToString());
                    node1.Tag = row2["id"];
                    node1.Nodes.Add("");
                }
                return;
            }
			DataTable dataTable = base.SelectSqlData("tSchm_ObjList", true, string.Concat(new string[]
			{
				" where idParent = ",
				e.Node.Tag.ToString(),
				" and typecodeId in (",
				text2,
				") and deleted = 0"
			}));
			DataRow[] array = dataTable.Select("Tag is null");
			DataRow[] source = dataTable.Select("Tag is not null");
			DataRow[] array2 = array;
			for (level = 0; level < array2.Length; level++)
			{
				DataRow r = array2[level];
				DataRow[] array3 = tges.vSchm_ObjList.Select("id = " + r["id"].ToString());
				TreeNode treeNode2 = e.Node.Nodes.Add(array3[0]["TypeCodeSocr"].ToString() + " - " + array3[0]["Name"].ToString());
				var enumerable = from objR in source
				                                    where objR["Tag"] != DBNull.Value && Convert.ToInt32(objR["Tag"]) == Convert.ToInt32(r["id"])
				                                    select objR;
				treeNode2.Tag = Convert.ToInt32(r["id"]);
				foreach (DataRow dataRow4 in enumerable)
				{
					if (treeNode2.Tag is int)
					{
						treeNode2.Tag = new List<int>
						{
							Convert.ToInt32(treeNode2.Tag),
							Convert.ToInt32(dataRow4["id"])
						};
					}
					else if (treeNode2.Tag is List<int>)
					{
						List<int> list = (List<int>)treeNode2.Tag;
						list.Add(Convert.ToInt32(dataRow4["id"]));
						treeNode2.Tag = list;
					}
					dataRow4["Tag"] = DBNull.Value;
				}
				treeNode2.Nodes.Add("");
			}
			foreach (DataRow dataRow5 in from obj in source
			                where obj["Tag"] != DBNull.Value
			                select obj)
			{
				DataRow[] array4 = tges.vSchm_ObjList.Select("id = " + dataRow5["id"].ToString());
				TreeNode treeNode3 = e.Node.Nodes.Add(array4[0]["TypeCodeSocr"].ToString() + " - " + array4[0]["Name"].ToString());
				treeNode3.Tag = Convert.ToInt32(dataRow5["id"]);
				treeNode3.Nodes.Add("");
			}
		}
	}

	private void GetListChecked(TreeNode node1, List<int> list)
	{
		if (node1.Checked && node1.Tag != null && node1.Level > 0)
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
		foreach (var obj in node1.Nodes)
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
			foreach (TreeNode node in this.treeViewSubstation.Nodes)
			{
				this.GetListChecked(node, list);
			}
            foreach (int key in list)
            {
                if (!this.DictionaryKey.ContainsKey(key))
                {
                    //string[] textArray1 = new string[] { key.ToString() };
                    //this.dictionary_0.Add(key, base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1).ToString());
                    this.DictionaryKey.Add(key, base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                    {
                            key.ToString()
                    }).ToString());
                }
            }
		}
		else if (this.treeViewSubstation.SelectedNode != null && this.treeViewSubstation.SelectedNode.Tag != null && this.treeViewSubstation.SelectedNode.Level > 0)
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
		TreeNode treeNode = this.SearchNode(list_, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, eSearchNode.First);
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
		TreeNode treeNode = this.SearchNode(list_, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, eSearchNode.Next);
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
		TreeNode treeNode = this.SearchNode(list_, this.treeViewSubstation.SelectedNode, this.toolTxtFind.Text, eSearchNode.Prev);
		if (treeNode != null)
		{
			this.treeViewSubstation.SelectedNode = treeNode;
			this.treeViewSubstation.SelectedNode.Expand();
		}
	}

	private void toolTxtFind_KeyDown(object sender, KeyEventArgs e)
	{
        if (e.KeyCode == Keys.Enter)//Return
        {
            switch (e.Modifiers)
            {
                case Keys.None:
                    this.toolBtnFindNext_Click(sender, e);
                    break;

                case Keys.Shift:
                    this.toolBtnFindPrev_Click(sender, e);
                    break;
            }
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

	private TreeNode SearchNode(List<TreeNode> nodeList, TreeNode selNode, string txt, FormSelectSchmObj.eSearchNode searchNode)
	{
		bool flag = searchNode == (FormSelectSchmObj.eSearchNode.First);
		if (searchNode == (FormSelectSchmObj.eSearchNode.Prev))
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

    private void checkBoxUseBusParent_CheckedChanged(object sender, EventArgs e)
    {
        this.LoadTree();
    }

    private void chkFilterAllSubstations_CheckedChanged(object sender, EventArgs e)
	{
		this.LoadTree();
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		base.Close();
	}




    //private struct Struct2
    //{
    //	public Struct2(int int_1, string string_1)
    //	{
    //		////
    //		this.string_0 = string_1;
    //		this.int_0 = int_1;
    //	}

    //	public override string ToString()
    //	{
    //		return this.string_0;
    //	}

    //	public string string_0;

    //	public int int_0;
    //}

    /// <summary>
    /// поиск
    /// </summary>
    private enum eSearchNode
    {
        First = 0,
        Next = 1,
        Prev = 2
    }
}
