using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Constants.Scheme;
using ControlsLbr.DataGridViewExcelFilter;
//using Documents.Properties;
using FormLbr;
/// <summary>
/// Выбор объекта схемы
/// FormSelectLine
/// </summary>
internal partial class FormSelectLine : FormBase
{
    private List<int> listTypeObj;
    private List<FormSelectLine.StructTreeObjectLine> list_Line;
    private List<FormSelectLine.StructTreeObjectLine> list_PS;

    /// <summary>
    /// Кабельная или воздушная линия
    /// </summary>
    private StructObjectLine ObjectLine;
	internal StructObjectLine GetObjectLine()
	{
		return this.ObjectLine;
	}
	private void SetObjectLine(StructObjectLine obj)
	{
		this.ObjectLine = obj;
	}
    /// <summary>
    /// участок или секция КЛ, ВЛ, КВЛ
    /// </summary>
    private StructObjectLine ObjectLineSection1;
	internal StructObjectLine GetObjectLineSection()
	{
		return this.ObjectLineSection1;
	}
	private void SetObjecSectiontLine(StructObjectLine obj)
	{
		this.ObjectLineSection1 = obj;
	}
    /// <summary>
    ////видимость второй панели для секций кабеля
    /// </summary>
    private bool flgVisiblePanelCabSection;
    internal bool GetVisiblePanel()
	{
		return this.flgVisiblePanelCabSection;
	}
	internal void SetVisiblePanel(bool flag)
	{
		this.flgVisiblePanelCabSection = flag;
		this.splitContainer1.Panel2Collapsed = !this.flgVisiblePanelCabSection;
	}

	internal FormSelectLine(List<int> typeObj = null)
	{
		////
		this.flgVisiblePanelCabSection = true;
		this.list_Line = new List<FormSelectLine.StructTreeObjectLine>();
		this.list_PS = new List<FormSelectLine.StructTreeObjectLine>();
		
		this.InitializeComponent();
		this.listTypeObj = typeObj;
	}

	private void FormSelectLine_Load(object sender, EventArgs e)
	{
		this.LoadTree();
	}

	private void LoadTree()
	{
		DataTable dataTable = new DataTable("tR_Classifier");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("socrName", typeof(string));

        base.SelectSqlData(dataTable, true, " where ParentKey = ';SCM;Line;' and isGRoup = 0 and deleted = 0 order by name", null, false, 0);
        foreach (DataRow dataRow in dataTable.Rows)
		{
			if (this.listTypeObj != null && this.listTypeObj.Contains(Convert.ToInt32(dataRow["id"])))
			{
				TreeNode treeNode = new TreeNode(dataRow["SocrNAme"].ToString());
				treeNode.Tag = dataRow["id"];
				this.treeViewLine.Nodes.Add(treeNode);

                TreeNode treeNode2 = new TreeNode("0,23-0,4 кВ");
				treeNode.Nodes.Add(treeNode2);
				this.list_Line.Add(new FormSelectLine.StructTreeObjectLine(treeNode2, Convert.ToInt32(dataRow["id"]), (FormSelectLine.eVoltageLevel.LV), false));

                TreeNode treeNode3 = new TreeNode("6-10 кВ");
				treeNode.Nodes.Add(treeNode3);
				this.list_Line.Add(new FormSelectLine.StructTreeObjectLine(treeNode3, Convert.ToInt32(dataRow["id"]), (FormSelectLine.eVoltageLevel.HV), false));
			}
		}

        base.SelectSqlData(dataTable, true, " where ParentKey = ';SCM;PS;' and isGRoup = 0 and deleted = 0 order by name", null, false, 0);
		foreach (DataRow dataRow2 in dataTable.Rows)
		{
			if (this.listTypeObj != null && this.listTypeObj.Contains(Convert.ToInt32(dataRow2["id"])))
			{
				TreeNode treeNode4 = new TreeNode(dataRow2["SocrNAme"].ToString());
				treeNode4.Tag = dataRow2["id"];
				this.treeViewLine.Nodes.Add(treeNode4);
				this.list_PS.Add(new FormSelectLine.StructTreeObjectLine(treeNode4, Convert.ToInt32(dataRow2["id"]), (FormSelectLine.eVoltageLevel.HV), false));
			}
		}

		foreach (FormSelectLine.StructTreeObjectLine parameter in this.list_Line)
		{
			new Thread(new ParameterizedThreadStart(this.FillListLines)).Start(parameter);
		}
		foreach (FormSelectLine.StructTreeObjectLine parameter2 in this.list_PS)
		{
			new Thread(new ParameterizedThreadStart(this.FillListObj)).Start(parameter2);
		}
	}

	private void FormSelectLine_Shown(object sender, EventArgs e)
	{
        //for (;;)
        //{
        //	Application.DoEvents();
        //	bool flag = true;
        //	List<FormSelectLine.Class118>.Enumerator enumerator = this.list_Line.GetEnumerator();
        //	try
        //	{
        //		while (enumerator.MoveNext())
        //		{
        //			if (!enumerator.Current.bool_0)
        //			{
        //				flag = false;
        //				break;
        //			}
        //		}
        //		goto IL_75;
        //	}
        //	finally
        //	{
        //		((IDisposable)enumerator).Dispose();
        //	}
        //	try
        //	{
        //		IL_42:
        //		while (enumerator.MoveNext())
        //		{
        //			if (!enumerator.Current.bool_0)
        //			{
        //				flag = false;
        //				break;
        //			}
        //		}
        //	}
        //	finally
        //	{
        //		((IDisposable)enumerator).Dispose();
        //	}
        //	if (flag)
        //	{
        //		break;
        //	}
        //	continue;
        //	IL_75:
        //	enumerator = this.list_PS.GetEnumerator();
        //	goto IL_42;
        //}
        //Control control = this.labelLoad;
        //this.progressBarLoad.Visible = false;
        //control.Visible = false;


        for (; ; )
        {
            Application.DoEvents();
            bool flag = true;
            List<FormSelectLine.StructTreeObjectLine>.Enumerator enumerator = this.list_Line.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    if (!enumerator.Current.Checking)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            finally
            {
                ((IDisposable)enumerator).Dispose();
            }

            enumerator = this.list_PS.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    if (!enumerator.Current.Checking)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            finally
            {
                ((IDisposable)enumerator).Dispose();
            }
            if (flag)
            {
                break;
            }
            continue;
        }

        Control control = this.labelLoad;
        this.progressBarLoad.Visible = false;
        control.Visible = false;
    }

	private void FillListLines(object obj)
	{
		if (!(obj is FormSelectLine.StructTreeObjectLine))
		{
			return;
		}
		FormSelectLine.StructTreeObjectLine cable = (FormSelectLine.StructTreeObjectLine)obj;
		DataTable dataTable = new DataTable("VP_CAbleLine");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("text", typeof(string));

        base.SelectSqlData(dataTable, true, string.Format("where typeCodeid = {0} and voltage in ({1}) order by text", cable.Id, (cable.eVoltageLevel == (FormSelectLine.eVoltageLevel.LV)) ? "0.23, 0.4" : "6, 10"), null, false, 0);

        foreach (DataRow dataRow in dataTable.Rows)
		{
			TreeNode treeNode = new TreeNode(dataRow["TExt"].ToString());
			treeNode.Tag = dataRow["id"];
			this.AddTreeNode(this.treeViewLine, cable.Node, treeNode);
		}
		FormSelectLine.StructTreeObjectLine obj2 = cable;
		lock (obj2)
		{
			cable.Checking = true;
		}
	}

	private void FillListObj(object obj)
	{
		if (!(obj is FormSelectLine.StructTreeObjectLine))
		{
			return;
		}
		FormSelectLine.StructTreeObjectLine @class = (FormSelectLine.StructTreeObjectLine)obj;
		DataTable dataTable = new DataTable("vschm_ObjList");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("name", typeof(string));
		dataTable.Columns.Add("typeCodeSocr", typeof(string));

        base.SelectSqlData(dataTable, true, string.Format("where typeCodeid = {0} and deleted = 0 order by name", @class.Id), null, false, 0);
		foreach (DataRow dataRow in dataTable.Rows)
		{
			TreeNode treeNode = new TreeNode(dataRow["TypeCodeSocr"].ToString() + "-" + dataRow["Name"].ToString());
			treeNode.Tag = dataRow["id"];
			this.AddTreeNode(this.treeViewLine, @class.Node, treeNode);
		}
		FormSelectLine.StructTreeObjectLine obj2 = @class;
		lock (obj2)
		{
			@class.Checking = true;
		}
	}

	private void AddTreeNode(TreeView treeView, TreeNode treeNode_0, TreeNode treeNode_1)
	{
		if (treeView == null)
		{
			return;
		}
		if (treeView.IsDisposed)
		{
			return;
		}
		if (treeView.Disposing)
		{
			return;
		}
		if (!treeView.IsHandleCreated)
		{
			return;
		}
		try
		{
			if (!treeView.InvokeRequired)
			{
				if (treeNode_0 == null)
				{
					treeView.Nodes.Add(treeNode_1);
				}
				else
				{
					treeNode_0.Nodes.Add(treeNode_1);
				}
			}
			else
			{
				treeView.Invoke(new FormSelectLine.Delegate53(this.AddTreeNode), new object[]
				{
					treeView,
					treeNode_0,
					treeNode_1
				});
			}
		}
		catch
		{
		}
	}

	private void toolBtnFind_Click(object sender, EventArgs e)
	{
		this.treeViewLine.Find(this.txtFind.Text, (FindElementTreeNode.eSearchNode.First));
	}

	private void toolBTnFindPrev_Click(object sender, EventArgs e)
	{
		this.treeViewLine.Find(this.txtFind.Text, (FindElementTreeNode.eSearchNode.Prev));
	}

	private void toolBtnFindNext_Click(object sender, EventArgs e)
	{
		this.treeViewLine.Find(this.txtFind.Text, (FindElementTreeNode.eSearchNode.Next));
	}

	private void txtFind_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			if (e.Modifiers == Keys.Shift)
			{
				this.treeViewLine.Find(this.txtFind.Text, (FindElementTreeNode.eSearchNode.Prev));
			}
			if (e.Modifiers == Keys.None)
			{
				this.treeViewLine.Find(this.txtFind.Text, (FindElementTreeNode.eSearchNode.Next));
			}
		}
	}

	private void treeViewLine_AfterSelect(object sender, TreeViewEventArgs e)
	{
		if (e.Node.Level > 1 && e.Node.Tag != null)
		{
			int num = Convert.ToInt32(e.Node.Tag);
			DataTable dataTable = new DataTable("tP_CabSection");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("number", typeof(int));
			this.bindingSource1.DataSource = dataTable;
			base.SelectSqlData(dataTable, true, "where idObjList = " + num.ToString() + " order by number", null, false, 0);
			this.dgvCabSection.DataSource = this.bindingSource1;
		}
	}

	private void buttonCancel_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void FormSelectLine_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (base.DialogResult == DialogResult.OK)
		{
			List<int> listTypeLine = new List<int>();
			foreach (TypeLine item in Enum.GetValues(typeof(TypeLine)))
			{
				listTypeLine.Add((int)item);
			}
			if (this.treeViewLine.SelectedNode == null || this.treeViewLine.SelectedNode.Level < 1 || (this.treeViewLine.SelectedNode.Level == 1 && listTypeLine.Contains(Convert.ToInt32(this.treeViewLine.SelectedNode.Parent.Tag))))
			{
				MessageBox.Show("Не выбран объект", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				e.Cancel = true;
				return;
			}
			if (this.treeViewLine.SelectedNode.Level == 2 && this.flgVisiblePanelCabSection)
			{
				if (this.dgvCabSection.CurrentRow == null)
				{
					if (MessageBox.Show("Не выбран участок КЛ/ВЛ. Продолжить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					{
						e.Cancel = true;
						return;
					}
				}
				else
				{
					this.SetObjecSectiontLine(new StructObjectLine(this.dgvCabSection.CurrentRow.Cells[this.columnNameCabSection.Name].Value.ToString(), Convert.ToInt32(this.dgvCabSection.CurrentRow.Cells[this.columnId.Name].Value)));
				}
			}
			this.SetObjectLine(new StructObjectLine(this.treeViewLine.SelectedNode.Text, Convert.ToInt32(this.treeViewLine.SelectedNode.Tag)));
		}
	}





    private delegate void Delegate53(TreeView tree, TreeNode parentNode, TreeNode nodeToAdd);
    /// <summary>
    /// Уровень напряжения
    /// </summary>
	private enum eVoltageLevel
	{
        /// <summary>
        /// "0,23-0,4 кВ"
        /// </summary>
        LV = 0,
        /// <summary>
        /// "6-10 кВ"
        /// </summary>
        HV = 1
    }

    /// <summary>
    /// структура дерева объектов линий (кабельных)
    /// </summary>
	private class StructTreeObjectLine
	{
		internal StructTreeObjectLine(TreeNode treeNode, int id, FormSelectLine.eVoltageLevel levelVoltage = (FormSelectLine.eVoltageLevel.HV), bool flag = false)
		{
			this.Node = treeNode;
			this.Id = id;
			this.eVoltageLevel = levelVoltage;
			this.Checking = flag;
		}

		internal TreeNode Node;

		internal int Id;

		internal FormSelectLine.eVoltageLevel eVoltageLevel;

		internal bool Checking;
	}
}
