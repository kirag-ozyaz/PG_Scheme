using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using Scheme.Classes;
using Scheme.Properties;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Layers;
using SchemeModel.Calculations;
using WeifenLuo.WinFormsUI.Docking;
//using WinFormsUI.Docking;

internal class Class18 : DockContent
{
	[CompilerGenerated]
	internal void method_0(TreeViewEventHandler treeViewEventHandler_1)
	{
		TreeViewEventHandler treeViewEventHandler = this.treeViewEventHandler_0;
		TreeViewEventHandler treeViewEventHandler2;
		do
		{
			treeViewEventHandler2 = treeViewEventHandler;
			TreeViewEventHandler value = (TreeViewEventHandler)Delegate.Combine(treeViewEventHandler2, treeViewEventHandler_1);
			treeViewEventHandler = Interlocked.CompareExchange<TreeViewEventHandler>(ref this.treeViewEventHandler_0, value, treeViewEventHandler2);
		}
		while (treeViewEventHandler != treeViewEventHandler2);
	}

	[CompilerGenerated]
	internal void method_1(TreeViewEventHandler treeViewEventHandler_1)
	{
		TreeViewEventHandler treeViewEventHandler = this.treeViewEventHandler_0;
		TreeViewEventHandler treeViewEventHandler2;
		do
		{
			treeViewEventHandler2 = treeViewEventHandler;
			TreeViewEventHandler value = (TreeViewEventHandler)Delegate.Remove(treeViewEventHandler2, treeViewEventHandler_1);
			treeViewEventHandler = Interlocked.CompareExchange<TreeViewEventHandler>(ref this.treeViewEventHandler_0, value, treeViewEventHandler2);
		}
		while (treeViewEventHandler != treeViewEventHandler2);
	}

	internal Class18()
	{
		
		
		this.method_17();
		GeneralFormSettings.SizeIconChanged(new EventHandler(this.method_7));
		GeneralFormSettings.FontSizeChanged(new EventHandler(this.method_6));
	}

	internal DrawObjectBase method_2()
	{
		return this.drawObjectBase_0;
	}

	internal void SelectedObject(DrawObjectBase drawObjectBase_1)
	{
		this.drawObjectBase_0 = drawObjectBase_1;
		this.method_4();
	}

	private void method_4()
	{
		this.treeView_2.Nodes.Clear();
		this.treeView_1.Nodes.Clear();
		if (this.drawObjectBase_0 == null)
		{
			return;
		}
		CanvasControl parent = this.drawObjectBase_0.Layer.Parent;
        TreeNodeObj treeNodeObj = parent.PoweringReportForDrawObject(this.drawObjectBase_0, false);
        TreeNodeObj treeNodeObj2 = parent.PoweringReportForDrawObject(this.drawObjectBase_0, true);
		TreeNode treeNode = this.treeView_1.Nodes.Add(((DrawObjectBase)treeNodeObj.Tag).GetFullName());
		treeNode.Tag = treeNodeObj.Tag;
		TreeNodeObj treeNodeObj3 = treeNodeObj;
		while (!treeNodeObj3.IsLeaf)
		{
			treeNodeObj3 = treeNodeObj3.Nodes.First<TreeNodeObj>();
			if (treeNodeObj3.Tag is ShinaTool)
			{
				treeNode = treeNode.Nodes.Add(((DrawObjectBase)treeNodeObj3.Tag).GetFullName());
				treeNode.Tag = treeNodeObj3.Tag;
			}
		}
		treeNode = this.treeView_2.Nodes.Add(((DrawObjectBase)treeNodeObj2.Tag).GetFullName());
		treeNode.Tag = treeNodeObj2.Tag;
		this.method_5(treeNodeObj2, treeNode);
		this.treeView_2.ExpandAll();
		this.treeView_1.ExpandAll();
	}

	private void method_5(TreeNodeObj treeNodeObj_0, TreeNode treeNode_0)
	{
		if (treeNodeObj_0.IsLeaf)
		{
			return;
		}
		foreach (TreeNodeObj treeNodeObj in treeNodeObj_0.Nodes)
		{
			if (treeNodeObj.Tag is ShinaTool)
			{
				treeNode_0 = treeNode_0.Nodes.Add(((DrawObjectBase)treeNodeObj.Tag).GetFullName());
				treeNode_0.Tag = treeNodeObj.Tag;
			}
			this.method_5(treeNodeObj, treeNode_0);
		}
	}

	private void treeView_2_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
	{
		if (this.drawObjectBase_0 != null && e.Node.Tag != null)
		{
			((DrawObjectBase)e.Node.Tag).Layer.Parent.SetObjectsInCenterScreen((DrawObjectBase)e.Node.Tag, false, CanvasControl.SetObjectsInCenterScreenOptions.none);
			return;
		}
	}

	private void treeView_2_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
	{
		e.Cancel = true;
	}

	private void method_6(object sender, EventArgs e)
	{
		this.Font = new Font(this.Font.Name, GeneralFormSettings.FontSize);
		this.toolStripTextBox_0.Font = new Font(this.Font.Name, GeneralFormSettings.FontSize);
	}

	private void method_7(object sender, EventArgs e)
	{
		this.toolStrip_0.ImageScalingSize = GeneralFormSettings.SizeIcon;
		this.toolStrip_0.Scale(new SizeF(2f, 2f));
	}

	private int method_8(int int_0)
	{
		int result = 0;
		if (int_0 > 95)
		{
			switch (int_0)
			{
			case 535:
			case 536:
			case 537:
			case 538:
				goto IL_D8;
			case 539:
			case 542:
			case 543:
			case 544:
			case 549:
			case 555:
			case 557:
			case 560:
			case 561:
			case 562:
				return result;
			case 540:
			case 541:
			case 563:
			case 564:
				goto IL_16B;
			case 545:
			case 546:
			case 548:
				return this.imageList_0.Images.IndexOfKey("Cable");
			case 547:
				return this.imageList_0.Images.IndexOfKey("AirWay");
			case 550:
			case 551:
				break;
			case 552:
			case 553:
			case 554:
			case 558:
			case 559:
				goto IL_153;
			case 556:
				return this.imageList_0.Images.IndexOfKey("Transformer");
			default:
				if (int_0 != 584)
				{
					if (int_0 != 612)
					{
						return result;
					}
					return this.imageList_0.Images.IndexOfKey("Clutch");
				}
				break;
			}
			return this.imageList_0.Images.IndexOfKey("Clutch");
		}
		if (int_0 != 79)
		{
			if (int_0 == 84)
			{
				goto IL_16B;
			}
			if (int_0 != 95)
			{
				return result;
			}
			goto IL_153;
		}
		IL_D8:
		return this.imageList_0.Images.IndexOfKey("Substation");
		IL_153:
		return this.imageList_0.Images.IndexOfKey("Switch");
		IL_16B:
		result = this.imageList_0.Images.IndexOfKey("Bus");
		return result;
	}

	internal List<TreeNode> method_9()
	{
		List<TreeNode> list = new List<TreeNode>();
		foreach (object obj in this.treeView_0.Nodes)
		{
			TreeNode item = (TreeNode)obj;
			list.Add(item);
		}
		return list;
	}

	internal void method_10(CanvasControl canvasControl_0)
	{
		this.treeView_0.Nodes.Clear();
		TreeNode treeNode = new TreeNode("ЦП");
		treeNode.Tag = eTypeRectangleTool.CP;
		this.treeView_0.Nodes.Add(treeNode);
		TreeNode treeNode2 = new TreeNode("РП");
		treeNode2.Tag = eTypeRectangleTool.RP;
		this.treeView_0.Nodes.Add(treeNode2);
		TreeNode treeNode3 = new TreeNode("ТП");
		treeNode3.Tag = eTypeRectangleTool.TP;
		this.treeView_0.Nodes.Add(treeNode3);
		TreeNode treeNode4 = new TreeNode("ПП");
		treeNode4.Tag = eTypeRectangleTool.PP;
		this.treeView_0.Nodes.Add(treeNode4);
		TreeNode treeNode5 = new TreeNode("СП");
		treeNode5.Tag = eTypeRectangleTool.SP;
		this.treeView_0.Nodes.Add(treeNode5);
		TreeNode treeNode6 = new TreeNode("ППНО");
		treeNode6.Tag = eTypeRectangleTool.PPNO;
		this.treeView_0.Nodes.Add(treeNode6);
		using (IEnumerator<DrawObjectBase> enumerator = (from objRects in canvasControl_0.Layers.First<ICanvasLayer>().Objects
		where objRects.GetType() == typeof(RectangleTool)
		orderby objRects.Text
		select objRects).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				DrawObjectBase obj = enumerator.Current;
				string str = ((RectangleTool)obj).IsSubscriber ? " АБ" : "";
				TreeNode treeNode7 = new TreeNode(obj.ToString() + str);
				treeNode7.Tag = obj;
				treeNode7.ImageIndex = this.method_8((int)((RectangleTool)obj).TypeRectnagleTool);
				treeNode7.SelectedImageIndex = this.method_8((int)((RectangleTool)obj).TypeRectnagleTool);
				eTypeRectangleTool typeRectnagleTool = ((RectangleTool)obj).TypeRectnagleTool;
				switch (typeRectnagleTool)
				{
				case eTypeRectangleTool.PP:
					treeNode4.Nodes.Add(treeNode7);
					break;
				case eTypeRectangleTool.CP:
					treeNode.Nodes.Add(treeNode7);
					break;
				case eTypeRectangleTool.RP:
					treeNode2.Nodes.Add(treeNode7);
					break;
				case eTypeRectangleTool.TP:
					treeNode3.Nodes.Add(treeNode7);
					break;
				default:
					if (typeRectnagleTool != eTypeRectangleTool.SP)
					{
						if (typeRectnagleTool == eTypeRectangleTool.PPNO)
						{
							treeNode6.Nodes.Add(treeNode7);
						}
					}
					else
					{
						treeNode5.Nodes.Add(treeNode7);
					}
					break;
				}
				foreach (DrawObjectBase drawObjectBase in from objShins in canvasControl_0.Layers.First<ICanvasLayer>().Objects
				where objShins.Parent == obj && objShins.GetType() == typeof(ShinaTool)
				orderby objShins.Text
				select objShins)
				{
					TreeNode treeNode8 = new TreeNode(drawObjectBase.ToString());
					treeNode8.Tag = drawObjectBase;
					treeNode7.Nodes.Add(treeNode8);
					treeNode8.ImageIndex = this.method_8((int)((ShinaTool)drawObjectBase).TypeShinaTool);
					treeNode8.SelectedImageIndex = this.method_8((int)((ShinaTool)drawObjectBase).TypeShinaTool);
					foreach (DrawObjectBase drawObjectBase2 in ((ShinaTool)drawObjectBase).ChildObjects)
					{
						if (drawObjectBase2.GetType() == typeof(PointShinaTool) && ((PointShinaTool)drawObjectBase2).BranchesCount > 0 && !(((PointShinaTool)drawObjectBase2)[0].Parent is SplitterShinaTool))
						{
							TreeNode treeNode9 = new TreeNode(((PointShinaTool)drawObjectBase2)[0].Parent.Text);
							treeNode9.Tag = ((PointShinaTool)drawObjectBase2)[0].Parent;
							treeNode9.ImageIndex = this.method_8((int)((LineCellTool)((PointShinaTool)drawObjectBase2).Branches.First<Branch>().Parent).Type);
							treeNode9.SelectedImageIndex = this.method_8((int)((LineCellTool)((PointShinaTool)drawObjectBase2).Branches.First<Branch>().Parent).Type);
							treeNode8.Nodes.Add(treeNode9);
						}
					}
				}
			}
		}
		if (canvasControl_0 != null && canvasControl_0.TypeCanvas == eTypeCanvas.SchemeMain)
		{
			DataTable dataTable = new SqlDataCommand(canvasControl_0.SqlSettings).SelectSqlData("vSchm_ObjListXml", true, string.Concat(new string[]
			{
				" where typeCodeId in (",
				1034.ToString(),
				", ",
				1275.ToString(),
				") and TypeSchema = ",
				2.ToString(),
				" and deleted = 0 and not tag is null order by name"
			}), null);
			using (IEnumerator enumerator4 = dataTable.Rows.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					DataRow r = (DataRow)enumerator4.Current;
					if (r.RowState != DataRowState.Deleted && canvasControl_0.FindObjectById(Convert.ToInt32(r["Id"])) == null)
					{
						EnumerableRowCollection<DataRow> enumerableRowCollection = from row in dataTable.AsEnumerable()
						where row.RowState != DataRowState.Deleted && Convert.ToInt32(row["id"]) == Convert.ToInt32(r["id"]) && row != r
						select row;
						DrawObjectBase drawObjectBase3 = canvasControl_0.FindObjectById(Convert.ToInt32(r["Tag"]));
						List<DrawObjectBase> list = new List<DrawObjectBase>();
						if (drawObjectBase3 != null)
						{
							list.Add(drawObjectBase3);
						}
						try
						{
							if (enumerableRowCollection != null && enumerableRowCollection.Count<DataRow>() > 0)
							{
								foreach (DataRow dataRow in enumerableRowCollection)
								{
									drawObjectBase3 = canvasControl_0.FindObjectById(Convert.ToInt32(dataRow["Tag"]));
									if (drawObjectBase3 != null)
									{
										list.Add(drawObjectBase3);
									}
									dataRow.Delete();
								}
							}
							goto IL_743;
						}
						catch
						{
							goto IL_743;
						}
						goto IL_680;
						IL_743:
						if ((int)r["typeCodeId"] == 1034)
						{
							goto IL_680;
						}
						if ((int)r["typeCodeId"] != 1275)
						{
							continue;
						}
						TreeNode treeNode10 = new TreeNode("ППНО-" + r["Name"].ToString());
						treeNode6.Nodes.Add(treeNode10);
						IL_70E:
						treeNode10.Tag = list;
						if (list.Count > 0)
						{
							treeNode10.ForeColor = Color.Green;
							continue;
						}
						treeNode10.ForeColor = Color.Red;
						continue;
						IL_680:
						treeNode10 = new TreeNode("СП-" + r["Name"].ToString());
						treeNode5.Nodes.Add(treeNode10);
						goto IL_70E;
					}
				}
			}
		}
		for (int i = 0; i < this.treeView_0.Nodes.Count; i++)
		{
			if (this.treeView_0.Nodes[i].Nodes.Count <= 0)
			{
				this.treeView_0.Nodes.RemoveAt(i);
				i--;
			}
		}
		if (this.treeView_2.Nodes.Count > 0)
		{
			this.treeView_0.SelectedNode = this.treeView_0.Nodes[0];
		}
	}

	internal void method_11(List<TreeNode> list_0)
	{
		this.treeView_0.Nodes.Clear();
		foreach (TreeNode node in list_0)
		{
			this.treeView_0.Nodes.Add(node);
		}
	}

	private void treeView_0_AfterSelect(object sender, TreeViewEventArgs e)
	{
		if (this.treeViewEventHandler_0 != null)
		{
			this.treeViewEventHandler_0(sender, e);
		}
	}

	private void treeView_0_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			TreeViewEventArgs e2 = new TreeViewEventArgs(e.Node);
			if (this.treeViewEventHandler_0 != null)
			{
				this.treeViewEventHandler_0(sender, e2);
			}
		}
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		List<TreeNode> list_ = new List<TreeNode>();
		list_ = this.method_12(this.treeView_0.Nodes, list_);
		TreeNode treeNode = this.method_13(list_, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, (Class18.Enum2)0);
		if (treeNode != null)
		{
			this.treeView_0.SelectedNode = null;
			this.treeView_0.SelectedNode = treeNode;
			this.treeView_0.SelectedNode.Expand();
		}
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		List<TreeNode> list_ = new List<TreeNode>();
		list_ = this.method_12(this.treeView_0.Nodes, list_);
		TreeNode treeNode = this.method_13(list_, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, (Class18.Enum2)2);
		if (treeNode != null)
		{
			this.treeView_0.SelectedNode = treeNode;
			this.treeView_0.SelectedNode.Expand();
		}
	}

	private void toolStripButton_2_Click(object sender, EventArgs e)
	{
		List<TreeNode> list_ = new List<TreeNode>();
		list_ = this.method_12(this.treeView_0.Nodes, list_);
		TreeNode treeNode = this.method_13(list_, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, (Class18.Enum2)1);
		if (treeNode != null)
		{
			this.treeView_0.SelectedNode = treeNode;
			this.treeView_0.SelectedNode.Expand();
		}
	}

	private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Keys modifiers = e.Modifiers;
			if (modifiers == Keys.None)
			{
				this.toolStripButton_2_Click(sender, e);
				return;
			}
			if (modifiers != Keys.Shift)
			{
				return;
			}
			this.toolStripButton_1_Click(sender, e);
		}
	}

	private List<TreeNode> method_12(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_0)
	{
		foreach (object obj in treeNodeCollection_0)
		{
			TreeNode treeNode = (TreeNode)obj;
			list_0.Add(treeNode);
			list_0 = this.method_12(treeNode.Nodes, list_0);
		}
		return list_0;
	}

	private TreeNode method_13(List<TreeNode> list_0, TreeNode treeNode_0, string string_0, Class18.Enum2 enum2_0)
	{
		bool flag = enum2_0 == (Class18.Enum2)0;
		if (enum2_0 == (Class18.Enum2)2)
		{
			list_0.Reverse();
		}
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

	[CompilerGenerated]
	internal void method_14(Delegate4 delegate4_1)
	{
		Delegate4 @delegate = this.delegate4_0;
		Delegate4 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate4 value = (Delegate4)Delegate.Combine(delegate2, delegate4_1);
			@delegate = Interlocked.CompareExchange<Delegate4>(ref this.delegate4_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	[CompilerGenerated]
	internal void method_15(Delegate4 delegate4_1)
	{
		Delegate4 @delegate = this.delegate4_0;
		Delegate4 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate4 value = (Delegate4)Delegate.Remove(delegate2, delegate4_1);
			@delegate = Interlocked.CompareExchange<Delegate4>(ref this.delegate4_0, value, delegate2);
		}
		while (@delegate != delegate2);
	}

	private void BsWdXuffwj_Click(object sender, EventArgs e)
	{
		EventArgs0 eventArgs = new EventArgs0(new List<DrawObjectBase>());
		if (this.delegate4_0 != null)
		{
			this.delegate4_0(sender, eventArgs);
		}
		this.dataTable_0.Clear();
		foreach (DrawObjectBase drawObjectBase in eventArgs.method_0())
		{
			DataRow dataRow = this.dataTable_0.NewRow();
			dataRow["name"] = drawObjectBase.Text;
			List<string> destinations = ((LineTool)drawObjectBase).GetDestinations();
			if (destinations.Count > 0)
			{
				dataRow["Source"] = destinations[0];
			}
			if (destinations.Count > 1)
			{
				dataRow["Destination"] = destinations[1];
			}
			dataRow["id"] = drawObjectBase.IdBase;
			this.dataTable_0.Rows.Add(dataRow);
		}
		this.dataGridViewExcelFilter_0.Tag = base.DockPanel.ActiveDocument;
	}

	private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && this.dataGridViewExcelFilter_0.Tag != null && this.dataGridViewExcelFilter_0.Tag is DockContentBase && ((DockContentBase)this.dataGridViewExcelFilter_0.Tag).Parent != null)
		{
			((DockContentBase)this.dataGridViewExcelFilter_0.Tag).Activate();
			if (((DockContentBase)base.DockPanel.ActiveDocument).Controls.Count > 0 && ((DockContentBase)base.DockPanel.ActiveDocument).Controls[0] is CanvasControl)
			{
				CanvasControl canvasControl = (CanvasControl)((DockContentBase)base.DockPanel.ActiveDocument).Controls[0];
				DrawObjectBase drawObject = canvasControl.FindObjectById(Convert.ToInt32(this.dataGridViewExcelFilter_0.Rows[e.RowIndex].Cells[this.dataGridViewTextBoxColumn_0.Name].Value));
				canvasControl.SetObjectsInCenterScreen(drawObject, false, CanvasControl.SetObjectsInCenterScreenOptions.select);
			}
		}
	}

	private void toolStripButton_5_Click(object sender, EventArgs e)
	{
		if (this.dataGridViewExcelFilter_0.Tag != null && this.dataGridViewExcelFilter_0.Tag is DockContentBase && ((DockContentBase)this.dataGridViewExcelFilter_0.Tag).Parent != null)
		{
			((DockContentBase)this.dataGridViewExcelFilter_0.Tag).Activate();
			if (((DockContentBase)base.DockPanel.ActiveDocument).Controls.Count > 0 && ((DockContentBase)base.DockPanel.ActiveDocument).Controls[0] is CanvasControl)
			{
				CanvasControl canvasControl = (CanvasControl)((DockContentBase)base.DockPanel.ActiveDocument).Controls[0];
				List<DrawObjectBase> list = new List<DrawObjectBase>();
				foreach (object obj in ((IEnumerable)this.dataGridViewExcelFilter_0.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					list.Add(canvasControl.FindObjectById(Convert.ToInt32(dataGridViewRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value)));
				}
				canvasControl.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
			}
		}
	}

	private void toolStripButton_3_Click(object sender, EventArgs e)
	{
		this.dataGridViewExcelFilter_0.CopyToExcel(true);
	}

	private void toolStripButton_4_Click(object sender, EventArgs e)
	{
		this.dataGridViewExcelFilter_0.PrintDataGridView();
	}

	private void toolStripButton_6_Click(object sender, EventArgs e)
	{
		this.method_16();
	}

	private void method_16()
	{
		this.TnidTcuAqj.Clear();
		if (((DockContentBase)base.DockPanel.ActiveDocument).Controls.Count > 0 && ((DockContentBase)base.DockPanel.ActiveDocument).Controls[0] is CanvasControl)
		{
			CanvasControl canvasControl = (CanvasControl)((DockContentBase)base.DockPanel.ActiveDocument).Controls[0];
			List<LineTool> list = new List<LineTool>();
			list.AddRange(from obj in canvasControl.ActiveLayer.Objects
			where obj.GetType() == typeof(LineTool) && obj.Text != ((LineTool)obj).GenerateNameForCabelLine() && obj.Text.Substring(0, obj.Text.Length - 1) != ((LineTool)obj).GenerateNameForCabelLine() + " №"
			select (LineTool)obj);
			foreach (LineTool lineTool in list)
			{
				this.TnidTcuAqj.Rows.Add(new object[]
				{
					lineTool.IdBase,
					lineTool.Text,
					lineTool.GenerateNameForCabelLine()
				});
			}
			this.dataGridViewExcelFilter_1.Tag = base.DockPanel.ActiveDocument;
		}
	}

	private void toolStripButton_7_Click(object sender, EventArgs e)
	{
		if (this.dataGridViewExcelFilter_1.SelectedRows.Count == 0)
		{
			return;
		}
		if (this.dataGridViewExcelFilter_1.Tag != null && this.dataGridViewExcelFilter_1.Tag is DockContentBase && ((DockContentBase)this.dataGridViewExcelFilter_1.Tag).Parent != null)
		{
			((DockContentBase)this.dataGridViewExcelFilter_1.Tag).Activate();
			if (((DockContentBase)base.DockPanel.ActiveDocument).Controls.Count > 0 && ((DockContentBase)base.DockPanel.ActiveDocument).Controls[0] is CanvasControl)
			{
				CanvasControl canvasControl = (CanvasControl)((DockContentBase)base.DockPanel.ActiveDocument).Controls[0];
				foreach (object obj2 in this.dataGridViewExcelFilter_1.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
					DrawObjectBase drawObjectBase = canvasControl.FindObjectById(Convert.ToInt32(dataGridViewRow.Cells[this.dataGridViewFilterTextBoxColumn_8.Name].Value));
					string s = dataGridViewRow.Cells[this.dataGridViewFilterTextBoxColumn_7.Name].Value.ToString();
					List<LineTool> list = new List<LineTool>();
					list.AddRange(from obj in canvasControl.ActiveLayer.Objects
					where obj.GetType() == typeof(LineTool) && (obj.Text == s || obj.Text.Substring(0, obj.Text.Length - 1) == s + " №")
					select (LineTool)obj);
					if (list.Count > 0)
					{
						int num = 1;
						s += " №";
						foreach (LineTool lineTool in list)
						{
							if (lineTool.Text.Substring(lineTool.Text.Length - 2, 1) == "№" || lineTool.Text.Substring(lineTool.Text.Length - 3, 2) == "№ ")
							{
								int num2 = 0;
								try
								{
									num2 = Convert.ToInt32(lineTool.Text.Substring(lineTool.Text.Length - 1));
								}
								catch
								{
									continue;
								}
								if (num2 > num)
								{
									num = num2;
								}
							}
						}
						s += num.ToString();
					}
					drawObjectBase.Text = s;
					drawObjectBase.SaveToSql(false, false);
					this.dataGridViewExcelFilter_1.Rows.Remove(dataGridViewRow);
				}
			}
		}
	}

	private void dataGridViewExcelFilter_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0 && this.dataGridViewExcelFilter_1.Tag != null && this.dataGridViewExcelFilter_1.Tag is DockContentBase && ((DockContentBase)this.dataGridViewExcelFilter_1.Tag).Parent != null)
		{
			((DockContentBase)this.dataGridViewExcelFilter_1.Tag).Activate();
			if (((DockContentBase)base.DockPanel.ActiveDocument).Controls.Count > 0 && ((DockContentBase)base.DockPanel.ActiveDocument).Controls[0] is CanvasControl)
			{
				CanvasControl canvasControl = (CanvasControl)((DockContentBase)base.DockPanel.ActiveDocument).Controls[0];
				DrawObjectBase drawObject = canvasControl.FindObjectById(Convert.ToInt32(this.dataGridViewExcelFilter_1.Rows[e.RowIndex].Cells[this.dataGridViewFilterTextBoxColumn_8.Name].Value));
				canvasControl.SetObjectsInCenterScreen(drawObject, false, CanvasControl.SetObjectsInCenterScreenOptions.select);
			}
		}
	}

	private void toolStripButton_8_Click(object sender, EventArgs e)
	{
		this.dataGridViewExcelFilter_1.SearchGrid(1, this.toolStripTextBox_1.Text);
	}

	private void toolStripTextBox_1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			if (e.Modifiers == Keys.None)
			{
				this.dataGridViewExcelFilter_1.SearchGrid(2, this.toolStripTextBox_1.Text);
			}
			if (e.Modifiers == Keys.Shift)
			{
				this.dataGridViewExcelFilter_1.SearchGrid(3, this.toolStripTextBox_1.Text);
			}
		}
	}

	private void toolStripButton_9_Click(object sender, EventArgs e)
	{
		this.dataGridViewExcelFilter_1.SearchGrid(3, this.toolStripTextBox_1.Text);
	}

	private void toolStripButton_10_Click(object sender, EventArgs e)
	{
		this.dataGridViewExcelFilter_1.SearchGrid(2, this.toolStripTextBox_1.Text);
	}

	protected override void Dispose(bool bool_0)
	{
		GeneralFormSettings.smethod_1(new EventHandler(this.method_7));
		GeneralFormSettings.smethod_3(new EventHandler(this.method_6));
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(bool_0);
	}

	private void method_17()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Class18));
		this.toolStrip_0 = new ToolStrip();
		this.toolStripButton_0 = new ToolStripButton();
		this.toolStripTextBox_0 = new ToolStripTextBox();
		this.toolStripButton_1 = new ToolStripButton();
		this.toolStripButton_2 = new ToolStripButton();
		this.treeView_0 = new TreeView();
		this.imageList_0 = new ImageList(this.icontainer_0);
		this.tabControl_0 = new TabControl();
		this.tabPage_0 = new TabPage();
		this.tabPage_3 = new TabPage();
		this.treeView_1 = new TreeView();
		this.tabPage_4 = new TabPage();
		this.treeView_2 = new TreeView();
		this.tabPage_1 = new TabPage();
		this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
		this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.dataSet_0 = new DataSet();
		this.dataTable_0 = new DataTable();
		this.dataColumn_0 = new DataColumn();
		this.dataColumn_1 = new DataColumn();
		this.dataColumn_2 = new DataColumn();
		this.dataColumn_3 = new DataColumn();
		this.toolStrip_1 = new ToolStrip();
		this.BsWdXuffwj = new ToolStripButton();
		this.toolStripButton_5 = new ToolStripButton();
		this.toolStripSeparator_0 = new ToolStripSeparator();
		this.toolStripButton_3 = new ToolStripButton();
		this.toolStripButton_4 = new ToolStripButton();
		this.tabPage_2 = new TabPage();
		this.dataGridViewExcelFilter_1 = new DataGridViewExcelFilter();
		this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
		this.bindingSource_1 = new BindingSource(this.icontainer_0);
		this.dataSet_1 = new DataSet();
		this.TnidTcuAqj = new DataTable();
		this.dataColumn_4 = new DataColumn();
		this.dataColumn_5 = new DataColumn();
		this.dataColumn_6 = new DataColumn();
		this.toolStrip_2 = new ToolStrip();
		this.toolStripButton_6 = new ToolStripButton();
		this.toolStripButton_7 = new ToolStripButton();
		this.toolStripSeparator_1 = new ToolStripSeparator();
		this.toolStripButton_8 = new ToolStripButton();
		this.toolStripTextBox_1 = new ToolStripTextBox();
		this.toolStripButton_9 = new ToolStripButton();
		this.toolStripButton_10 = new ToolStripButton();
		this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		this.toolStrip_0.SuspendLayout();
		this.tabControl_0.SuspendLayout();
		this.tabPage_0.SuspendLayout();
		this.tabPage_3.SuspendLayout();
		this.tabPage_4.SuspendLayout();
		this.tabPage_1.SuspendLayout();
		this.dataGridViewExcelFilter_0.BeginInit();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		((ISupportInitialize)this.dataSet_0).BeginInit();
		((ISupportInitialize)this.dataTable_0).BeginInit();
		this.toolStrip_1.SuspendLayout();
		this.tabPage_2.SuspendLayout();
		this.dataGridViewExcelFilter_1.BeginInit();
		((ISupportInitialize)this.bindingSource_1).BeginInit();
		((ISupportInitialize)this.dataSet_1).BeginInit();
		((ISupportInitialize)this.TnidTcuAqj).BeginInit();
		this.toolStrip_2.SuspendLayout();
		base.SuspendLayout();
		this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
		this.toolStrip_0.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_0,
			this.toolStripTextBox_0,
			this.toolStripButton_1,
			this.toolStripButton_2
		});
		this.toolStrip_0.Location = new Point(3, 3);
		this.toolStrip_0.Name = "toolStrip";
		this.toolStrip_0.Size = new Size(451, 25);
		this.toolStrip_0.TabIndex = 0;
		this.toolStrip_0.Text = "toolStrip1";
		this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_0.Image = Resources.smethod_28();
		this.toolStripButton_0.ImageTransparentColor = Color.Transparent;
		this.toolStripButton_0.Name = "toolBtnFind";
		this.toolStripButton_0.Size = new Size(23, 22);
		this.toolStripButton_0.Text = "Поиск сначала";
		this.toolStripButton_0.Click += this.toolStripButton_0_Click;
		this.toolStripTextBox_0.Name = "toolTextBoxFind";
		this.toolStripTextBox_0.Size = new Size(80, 25);
		this.toolStripTextBox_0.ToolTipText = "Текст для поиск";
		this.toolStripTextBox_0.KeyDown += this.toolStripTextBox_0_KeyDown;
		this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_1.Image = Resources.smethod_30();
		this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_1.Name = "toolBtnFindPrev";
		this.toolStripButton_1.Size = new Size(23, 22);
		this.toolStripButton_1.Text = "Поиск назад";
		this.toolStripButton_1.Click += this.toolStripButton_1_Click;
		this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_2.Image = Resources.smethod_29();
		this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_2.Name = "toolBtnFindNext";
		this.toolStripButton_2.Size = new Size(23, 22);
		this.toolStripButton_2.Text = "Поиск вперед";
		this.toolStripButton_2.Click += this.toolStripButton_2_Click;
		this.treeView_0.Dock = DockStyle.Fill;
		this.treeView_0.HideSelection = false;
		this.treeView_0.Location = new Point(3, 28);
		this.treeView_0.Name = "treeViewObjects";
		this.treeView_0.Size = new Size(451, 347);
		this.treeView_0.TabIndex = 1;
		this.treeView_0.AfterSelect += this.treeView_0_AfterSelect;
		this.treeView_0.NodeMouseClick += this.treeView_0_NodeMouseClick;
		this.imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListTreeView.ImageStream");
		this.imageList_0.TransparentColor = Color.Transparent;
		this.imageList_0.Images.SetKeyName(0, "Substation");
		this.imageList_0.Images.SetKeyName(1, "Switch");
		this.imageList_0.Images.SetKeyName(2, "Bus");
		this.imageList_0.Images.SetKeyName(3, "Transformer");
		this.imageList_0.Images.SetKeyName(4, "Cable");
		this.imageList_0.Images.SetKeyName(5, "Clutch");
		this.imageList_0.Images.SetKeyName(6, "AirWay");
		this.tabControl_0.Controls.Add(this.tabPage_0);
		this.tabControl_0.Controls.Add(this.tabPage_3);
		this.tabControl_0.Controls.Add(this.tabPage_4);
		this.tabControl_0.Controls.Add(this.tabPage_1);
		this.tabControl_0.Controls.Add(this.tabPage_2);
		this.tabControl_0.Dock = DockStyle.Fill;
		this.tabControl_0.Location = new Point(0, 0);
		this.tabControl_0.Name = "tabControl";
		this.tabControl_0.SelectedIndex = 0;
		this.tabControl_0.Size = new Size(465, 404);
		this.tabControl_0.TabIndex = 2;
		this.tabPage_0.Controls.Add(this.treeView_0);
		this.tabPage_0.Controls.Add(this.toolStrip_0);
		this.tabPage_0.Location = new Point(4, 22);
		this.tabPage_0.Name = "tabPageTreeObjects";
		this.tabPage_0.Padding = new Padding(3);
		this.tabPage_0.Size = new Size(457, 378);
		this.tabPage_0.TabIndex = 0;
		this.tabPage_0.Text = "Дерево объектов";
		this.tabPage_0.UseVisualStyleBackColor = true;
		this.tabPage_3.Controls.Add(this.treeView_1);
		this.tabPage_3.Location = new Point(4, 22);
		this.tabPage_3.Name = "tabPagePowering";
		this.tabPage_3.Padding = new Padding(3);
		this.tabPage_3.Size = new Size(457, 378);
		this.tabPage_3.TabIndex = 3;
		this.tabPage_3.Text = "Запитка";
		this.tabPage_3.UseVisualStyleBackColor = true;
		this.treeView_1.Dock = DockStyle.Fill;
		this.treeView_1.Indent = 10;
		this.treeView_1.Location = new Point(3, 3);
		this.treeView_1.Name = "treeViewPowering";
		this.treeView_1.ShowPlusMinus = false;
		this.treeView_1.Size = new Size(451, 372);
		this.treeView_1.TabIndex = 0;
		this.treeView_1.BeforeCollapse += this.treeView_2_BeforeCollapse;
		this.treeView_1.NodeMouseDoubleClick += this.treeView_2_NodeMouseDoubleClick;
		this.tabPage_4.Controls.Add(this.treeView_2);
		this.tabPage_4.Location = new Point(4, 22);
		this.tabPage_4.Name = "tabPageEnergise";
		this.tabPage_4.Padding = new Padding(3);
		this.tabPage_4.Size = new Size(457, 378);
		this.tabPage_4.TabIndex = 4;
		this.tabPage_4.Text = "Просчёт схемы";
		this.tabPage_4.UseVisualStyleBackColor = true;
		this.treeView_2.Dock = DockStyle.Fill;
		this.treeView_2.Location = new Point(3, 3);
		this.treeView_2.Name = "treeViewEnergise";
		this.treeView_2.ShowPlusMinus = false;
		this.treeView_2.Size = new Size(451, 372);
		this.treeView_2.TabIndex = 1;
		this.treeView_2.BeforeCollapse += this.treeView_2_BeforeCollapse;
		this.treeView_2.NodeMouseDoubleClick += this.treeView_2_NodeMouseDoubleClick;
		this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_0);
		this.tabPage_1.Controls.Add(this.toolStrip_1);
		this.tabPage_1.Location = new Point(4, 22);
		this.tabPage_1.Name = "tabPageKLNoPassport";
		this.tabPage_1.Padding = new Padding(3);
		this.tabPage_1.Size = new Size(457, 378);
		this.tabPage_1.TabIndex = 1;
		this.tabPage_1.Text = "КЛ без паспорта";
		this.tabPage_1.UseVisualStyleBackColor = true;
		this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
		this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToVisibleColumns = false;
		this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewFilterTextBoxColumn_0,
			this.dataGridViewFilterTextBoxColumn_1,
			this.dataGridViewFilterTextBoxColumn_2,
			this.dataGridViewTextBoxColumn_0
		});
		this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
		this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
		this.dataGridViewExcelFilter_0.Location = new Point(3, 28);
		this.dataGridViewExcelFilter_0.Name = "dgvKLNoPassport";
		this.dataGridViewExcelFilter_0.ReadOnly = true;
		this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
		this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewExcelFilter_0.Size = new Size(451, 347);
		this.dataGridViewExcelFilter_0.TabIndex = 1;
		this.dataGridViewExcelFilter_0.CellDoubleClick += this.dataGridViewExcelFilter_0_CellDoubleClick;
		this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "Name";
		this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Имя";
		this.dataGridViewFilterTextBoxColumn_0.Name = "nameDataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_0.Width = 140;
		this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "Source";
		this.dataGridViewFilterTextBoxColumn_1.HeaderText = "ТП1";
		this.dataGridViewFilterTextBoxColumn_1.Name = "sourceDataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "Destination";
		this.dataGridViewFilterTextBoxColumn_2.HeaderText = "ТП2";
		this.dataGridViewFilterTextBoxColumn_2.Name = "destinationDataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_0.HeaderText = "id";
		this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewTextBoxColumn_0.Visible = false;
		this.bindingSource_0.DataMember = "KLNoPassport";
		this.bindingSource_0.DataSource = this.dataSet_0;
		this.dataSet_0.DataSetName = "NewDataSet";
		this.dataSet_0.Tables.AddRange(new DataTable[]
		{
			this.dataTable_0
		});
		this.dataTable_0.Columns.AddRange(new DataColumn[]
		{
			this.dataColumn_0,
			this.dataColumn_1,
			this.dataColumn_2,
			this.dataColumn_3
		});
		this.dataTable_0.TableName = "KLNoPassport";
		this.dataColumn_0.ColumnName = "Name";
		this.dataColumn_1.ColumnName = "Source";
		this.dataColumn_2.ColumnName = "Destination";
		this.dataColumn_3.ColumnName = "id";
		this.dataColumn_3.DataType = typeof(int);
		this.toolStrip_1.Items.AddRange(new ToolStripItem[]
		{
			this.BsWdXuffwj,
			this.toolStripButton_5,
			this.toolStripSeparator_0,
			this.toolStripButton_3,
			this.toolStripButton_4
		});
		this.toolStrip_1.Location = new Point(3, 3);
		this.toolStrip_1.Name = "toolStripKL";
		this.toolStrip_1.Size = new Size(451, 25);
		this.toolStrip_1.TabIndex = 0;
		this.toolStrip_1.Text = "toolStrip1";
		this.BsWdXuffwj.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.BsWdXuffwj.Image = Resources.smethod_36();
		this.BsWdXuffwj.ImageTransparentColor = Color.Magenta;
		this.BsWdXuffwj.Name = "toolBtnGetKLNoPassport";
		this.BsWdXuffwj.Size = new Size(23, 22);
		this.BsWdXuffwj.Text = "Заполнить таблицу";
		this.BsWdXuffwj.Click += this.BsWdXuffwj_Click;
		this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_5.Image = Resources.smethod_8();
		this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_5.Name = "toolBtnSelectAll";
		this.toolStripButton_5.Size = new Size(23, 22);
		this.toolStripButton_5.Text = "Выделить все";
		this.toolStripButton_5.Click += this.toolStripButton_5_Click;
		this.toolStripSeparator_0.Name = "toolStripSeparator1";
		this.toolStripSeparator_0.Size = new Size(6, 25);
		this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_3.Image = Resources.smethod_40();
		this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_3.Name = "toolBtnKLToExcel";
		this.toolStripButton_3.Size = new Size(23, 22);
		this.toolStripButton_3.Text = "Экпорт в Excel";
		this.toolStripButton_3.Click += this.toolStripButton_3_Click;
		this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_4.Image = Resources.smethod_46();
		this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_4.Name = "toolBtnKLPrint";
		this.toolStripButton_4.Size = new Size(23, 22);
		this.toolStripButton_4.Text = "Печать";
		this.toolStripButton_4.Click += this.toolStripButton_4_Click;
		this.tabPage_2.Controls.Add(this.dataGridViewExcelFilter_1);
		this.tabPage_2.Controls.Add(this.toolStrip_2);
		this.tabPage_2.Location = new Point(4, 22);
		this.tabPage_2.Name = "tabPageKLBadName";
		this.tabPage_2.Padding = new Padding(3);
		this.tabPage_2.Size = new Size(457, 378);
		this.tabPage_2.TabIndex = 2;
		this.tabPage_2.Text = "КЛ с некорректными именами";
		this.tabPage_2.UseVisualStyleBackColor = true;
		this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_1.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewFilterTextBoxColumn_6,
			this.dataGridViewFilterTextBoxColumn_7,
			this.dataGridViewFilterTextBoxColumn_8
		});
		this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
		this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
		this.dataGridViewExcelFilter_1.Location = new Point(3, 28);
		this.dataGridViewExcelFilter_1.Name = "dgvBadName";
		this.dataGridViewExcelFilter_1.ReadOnly = true;
		this.dataGridViewExcelFilter_1.RowHeadersWidth = 21;
		this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewExcelFilter_1.Size = new Size(451, 347);
		this.dataGridViewExcelFilter_1.TabIndex = 3;
		this.dataGridViewExcelFilter_1.CellDoubleClick += this.dataGridViewExcelFilter_1_CellDoubleClick;
		this.dataGridViewFilterTextBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "BadName";
		this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Текущее имя";
		this.dataGridViewFilterTextBoxColumn_6.Name = "badNameDataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "CorrectlyName";
		this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Сгенерированное имя";
		this.dataGridViewFilterTextBoxColumn_7.Name = "correctlyNameDataGridViewTextBoxColumn";
		this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_8.AllowUserVisibleColumn = false;
		this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "Id";
		this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Id";
		this.dataGridViewFilterTextBoxColumn_8.Name = "idKLBadNameDgvColumn";
		this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_8.Visible = false;
		this.bindingSource_1.DataMember = "dtKLBadName";
		this.bindingSource_1.DataSource = this.dataSet_1;
		this.dataSet_1.DataSetName = "NewDataSet";
		this.dataSet_1.Tables.AddRange(new DataTable[]
		{
			this.TnidTcuAqj
		});
		this.TnidTcuAqj.Columns.AddRange(new DataColumn[]
		{
			this.dataColumn_4,
			this.dataColumn_5,
			this.dataColumn_6
		});
		this.TnidTcuAqj.TableName = "dtKLBadName";
		this.dataColumn_4.ColumnName = "Id";
		this.dataColumn_4.DataType = typeof(int);
		this.dataColumn_5.ColumnName = "BadName";
		this.dataColumn_6.ColumnName = "CorrectlyName";
		this.toolStrip_2.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_6,
			this.toolStripButton_7,
			this.toolStripSeparator_1,
			this.toolStripButton_8,
			this.toolStripTextBox_1,
			this.toolStripButton_9,
			this.toolStripButton_10
		});
		this.toolStrip_2.Location = new Point(3, 3);
		this.toolStrip_2.Name = "toolStripKLBadName";
		this.toolStrip_2.Size = new Size(451, 25);
		this.toolStrip_2.TabIndex = 0;
		this.toolStrip_2.Text = "toolStrip1";
		this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_6.Image = Resources.smethod_51();
		this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_6.Name = "toolBtnGetKLNoCorrectlyName";
		this.toolStripButton_6.Size = new Size(23, 22);
		this.toolStripButton_6.Text = "Обновить список";
		this.toolStripButton_6.Click += this.toolStripButton_6_Click;
		this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_7.Image = Resources.smethod_8();
		this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_7.Name = "toolBtnRenameKLName";
		this.toolStripButton_7.Size = new Size(23, 22);
		this.toolStripButton_7.Text = "Применить исправление имени выделеных объектов";
		this.toolStripButton_7.Click += this.toolStripButton_7_Click;
		this.toolStripSeparator_1.Name = "toolStripSeparator2";
		this.toolStripSeparator_1.Size = new Size(6, 25);
		this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_8.Image = Resources.smethod_28();
		this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_8.Name = "toolBtnFindKLBadName";
		this.toolStripButton_8.Size = new Size(23, 22);
		this.toolStripButton_8.Text = "Поиск";
		this.toolStripButton_8.Click += this.toolStripButton_8_Click;
		this.toolStripTextBox_1.Name = "toolFindTextKLBadName";
		this.toolStripTextBox_1.Size = new Size(100, 25);
		this.toolStripTextBox_1.ToolTipText = "Текст для поиска";
		this.toolStripTextBox_1.KeyDown += this.toolStripTextBox_1_KeyDown;
		this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_9.Image = Resources.smethod_30();
		this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_9.Name = "toolFindPrevKLBadName";
		this.toolStripButton_9.Size = new Size(23, 22);
		this.toolStripButton_9.Text = "Поиск назад";
		this.toolStripButton_9.Click += this.toolStripButton_9_Click;
		this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_10.Image = Resources.smethod_29();
		this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_10.Name = "toolFindNextKLBadName";
		this.toolStripButton_10.Size = new Size(23, 22);
		this.toolStripButton_10.Text = "Поиск вперед";
		this.toolStripButton_10.Click += this.toolStripButton_10_Click;
		this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "Name";
		this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Имя";
		this.dataGridViewFilterTextBoxColumn_3.Name = "dataGridViewFilterTextBoxColumn1";
		this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_3.Width = 140;
		this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "Source";
		this.dataGridViewFilterTextBoxColumn_4.HeaderText = "ТП1";
		this.dataGridViewFilterTextBoxColumn_4.Name = "dataGridViewFilterTextBoxColumn2";
		this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
		this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "Destination";
		this.dataGridViewFilterTextBoxColumn_5.HeaderText = "ТП2";
		this.dataGridViewFilterTextBoxColumn_5.Name = "dataGridViewFilterTextBoxColumn3";
		this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_1.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_1.HeaderText = "id";
		this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_1.Visible = false;
		base.AutoHidePortion = 0.15;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(465, 404);
		base.Controls.Add(this.tabControl_0);
		base.DockAreas = 23;
		this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Name = "TreeViewPanelObjects";
		this.Text = "Дерево объектов";
		this.toolStrip_0.ResumeLayout(false);
		this.toolStrip_0.PerformLayout();
		this.tabControl_0.ResumeLayout(false);
		this.tabPage_0.ResumeLayout(false);
		this.tabPage_0.PerformLayout();
		this.tabPage_3.ResumeLayout(false);
		this.tabPage_4.ResumeLayout(false);
		this.tabPage_1.ResumeLayout(false);
		this.tabPage_1.PerformLayout();
		this.dataGridViewExcelFilter_0.EndInit();
		((ISupportInitialize)this.bindingSource_0).EndInit();
		((ISupportInitialize)this.dataSet_0).EndInit();
		((ISupportInitialize)this.dataTable_0).EndInit();
		this.toolStrip_1.ResumeLayout(false);
		this.toolStrip_1.PerformLayout();
		this.tabPage_2.ResumeLayout(false);
		this.tabPage_2.PerformLayout();
		this.dataGridViewExcelFilter_1.EndInit();
		((ISupportInitialize)this.bindingSource_1).EndInit();
		((ISupportInitialize)this.dataSet_1).EndInit();
		((ISupportInitialize)this.TnidTcuAqj).EndInit();
		this.toolStrip_2.ResumeLayout(false);
		this.toolStrip_2.PerformLayout();
		base.ResumeLayout(false);
	}

	private DrawObjectBase drawObjectBase_0;

	[CompilerGenerated]
	private TreeViewEventHandler treeViewEventHandler_0;

	[CompilerGenerated]
	private Delegate4 delegate4_0;

	private IContainer icontainer_0;

	private ToolStrip toolStrip_0;

	private ToolStripTextBox toolStripTextBox_0;

	private TreeView treeView_0;

	private ImageList imageList_0;

	private ToolStripButton toolStripButton_0;

	private ToolStripButton toolStripButton_1;

	private ToolStripButton toolStripButton_2;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private TabPage tabPage_1;

	private ToolStrip toolStrip_1;

	private ToolStripButton BsWdXuffwj;

	private DataSet dataSet_0;

	private DataTable dataTable_0;

	private DataColumn dataColumn_0;

	private DataColumn dataColumn_1;

	private DataColumn dataColumn_2;

	private DataColumn dataColumn_3;

	private DataGridViewExcelFilter dataGridViewExcelFilter_0;

	private BindingSource bindingSource_0;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private ToolStripSeparator toolStripSeparator_0;

	private ToolStripButton toolStripButton_3;

	private ToolStripButton toolStripButton_4;

	private ToolStripButton toolStripButton_5;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private TabPage tabPage_2;

	private ToolStrip toolStrip_2;

	private ToolStripButton toolStripButton_6;

	private ToolStripButton toolStripButton_7;

	private TabPage tabPage_3;

	private TabPage tabPage_4;

	private TreeView treeView_1;

	private TreeView treeView_2;

	private DataSet dataSet_1;

	private DataGridViewExcelFilter dataGridViewExcelFilter_1;

	private BindingSource bindingSource_1;

	private DataTable TnidTcuAqj;

	private DataColumn dataColumn_4;

	private DataColumn dataColumn_5;

	private DataColumn dataColumn_6;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;

	private ToolStripSeparator toolStripSeparator_1;

	private ToolStripButton toolStripButton_8;

	private ToolStripTextBox toolStripTextBox_1;

	private ToolStripButton toolStripButton_9;

	private ToolStripButton toolStripButton_10;

	private enum Enum2
	{

	}
}
