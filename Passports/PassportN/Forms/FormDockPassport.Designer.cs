using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Constants;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using DocPPR.Forms;
using DocPPR.Forms.Report;
using FormLbr.Classes;
using Passport.Classes;
using Passport.Controls;
using Passport.Forms.AirLine.Documents;
using Passport.Forms.AirLine.Report;
using Passport.Forms.Cable;
using Passport.Forms.Cable.Report;
using Passport.Forms.Documents;
using Passport.Forms.Substation;
using Passport.Forms.Transf;
using Passport.Properties;
using Reference.Forms;
using WinFormsUI.Docking;

namespace Passport.Forms
{
	public class FormDockPassport : DockContentBase
	{
		public FormDockPassport()
		{
			Class330.Mus9JxKz1CNxy();
			this.string_0 = "";
			this.int_0 = -1;
			this.list_0 = new List<string>();
			this.list_1 = new List<int>();
			this.dataGridView_0 = new DataGridView();
			this.columnStyle_0 = new ColumnStyle(SizeType.Absolute, 0f);
			this.eGmhhajZsf = new ColumnStyle(SizeType.Absolute, 0f);
			this.columnStyle_1 = new ColumnStyle(SizeType.Absolute, 0f);
			this.bool_2 = true;
			this.typeObjListGroup_0 = TypeObjListGroup.None;
			base..ctor();
			this.method_209();
			this.tabPage_1.Parent = null;
			this.list_2 = this.method_27(this.tabControl_0);
			this.method_1();
		}

		public FormDockPassport(SQLSettings settings, TypeObjListGroup group)
		{
			Class330.Mus9JxKz1CNxy();
			this.string_0 = "";
			this.int_0 = -1;
			this.list_0 = new List<string>();
			this.list_1 = new List<int>();
			this.dataGridView_0 = new DataGridView();
			this.columnStyle_0 = new ColumnStyle(SizeType.Absolute, 0f);
			this.eGmhhajZsf = new ColumnStyle(SizeType.Absolute, 0f);
			this.columnStyle_1 = new ColumnStyle(SizeType.Absolute, 0f);
			this.bool_2 = true;
			this.typeObjListGroup_0 = TypeObjListGroup.None;
			base..ctor();
			try
			{
				this.method_209();
				this.SqlSettings = settings;
				this.eissettings_0 = this.method_3();
				this.fillTree_0 = FormDockPassport.FillTree.All;
				this.objList_0 = new ObjList(this.SqlSettings);
				this.objList_0.ObjListChanged += this.method_19;
				this.method_5(this.treeView_0, group, this.sort_0);
				this.class107_0.EnforceConstraints = false;
				this.tabPage_1.Parent = null;
				this.tabControl_0.TabPages.Remove(this.tabPage_12);
				this.list_2 = this.method_27(this.tabControl_0);
				this.dataGridViewPassport_0.DragDropComplite = true;
				this.tabPage_2.Parent = null;
				this.tabPage_23.Parent = null;
				this.Cjurjlhywj.Parent = null;
				this.tabPage_27.Parent = null;
				this.method_122(true);
				this.method_1();
				this.toolStripButton_144.Tag = ObjList.GetGroupParentKey(group);
				this.method_0();
				this.method_145(group);
			}
			catch (Exception)
			{
			}
		}

		private void FormDockPassport_Load(object sender, EventArgs e)
		{
			this.method_2();
			base.FormClosed += this.FormDockPassport_FormClosed;
		}

		private void FormDockPassport_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		public FormDockPassport(SQLSettings settings, int idSchmObjList)
		{
			Class330.Mus9JxKz1CNxy();
			this.string_0 = "";
			this.int_0 = -1;
			this.list_0 = new List<string>();
			this.list_1 = new List<int>();
			this.dataGridView_0 = new DataGridView();
			this.columnStyle_0 = new ColumnStyle(SizeType.Absolute, 0f);
			this.eGmhhajZsf = new ColumnStyle(SizeType.Absolute, 0f);
			this.columnStyle_1 = new ColumnStyle(SizeType.Absolute, 0f);
			this.bool_2 = true;
			this.typeObjListGroup_0 = TypeObjListGroup.None;
			base..ctor();
			this.method_209();
			this.SqlSettings = settings;
			this.eissettings_0 = this.method_3();
			this.fillTree_0 = FormDockPassport.FillTree.One;
			this.int_0 = idSchmObjList;
			this.objList_0 = new ObjList(this.SqlSettings);
			this.objList_0.ObjListChanged += this.method_19;
			this.objList_0.Id = idSchmObjList;
			this.method_4(this.treeView_0, idSchmObjList);
			this.class107_0.EnforceConstraints = false;
			this.tabPage_1.Parent = null;
			this.tabControl_0.TabPages.Remove(this.tabPage_12);
			this.list_2 = this.method_27(this.tabControl_0);
			this.tabPage_2.Parent = null;
			this.tabPage_23.Parent = null;
			this.Cjurjlhywj.Parent = null;
			this.tabPage_27.Parent = null;
			this.method_122(true);
			this.method_1();
			this.method_0();
		}

		private void method_0()
		{
			if (this.treeView_0.SelectedNode != null)
			{
				this.toolStripButton_137.Enabled = (this.toolStripDropDownButton_0.Enabled = (this.toolStripButton_139.Enabled = (this.toolStripButton_138.Enabled = (this.toolStripButton_140.Enabled = (this.treeView_0.SelectedNode.Tag.ToString() != "0")))));
			}
			this.toolStripButton_144.Text = ((this.objList_0.GroupType == TypeObjListGroup.Substations) ? "Количество выключателей" : ((this.objList_0.Type == TypeObjList.LineCable) ? "Отключение кабельных линий" : ""));
			this.toolStripButton_144.Visible = (this.objList_0.GroupType == TypeObjListGroup.Substations || this.objList_0.Type == TypeObjList.LineCable);
			ToolStripItem toolStripItem = this.toolStripButton_145;
			bool visible;
			if (this.objList_0.Type != TypeObjList.LineCable && this.objList_0.Type != TypeObjList.LineAir)
			{
				if (this.objList_0.Type != TypeObjList.LineProtectedAir)
				{
					visible = false;
					goto IL_114;
				}
			}
			visible = (this.objList_0.IdPassport > -1);
			IL_114:
			toolStripItem.Visible = visible;
			ToolStripItem toolStripItem2 = this.toolStripButton_146;
			bool visible2;
			if (this.objList_0.Type != TypeObjList.LineCable && this.objList_0.Type != TypeObjList.LineAir)
			{
				if (this.objList_0.Type != TypeObjList.LineProtectedAir)
				{
					visible2 = false;
					goto IL_15C;
				}
			}
			visible2 = (this.objList_0.IdPassport == -1);
			IL_15C:
			toolStripItem2.Visible = visible2;
			this.toolStripButton_150.Visible = (this.objList_0.Type == TypeObjList.SwitchTransf || this.objList_0.Type == TypeObjList.LineCable || this.objList_0.Type == TypeObjList.LineAir || this.objList_0.Type == TypeObjList.LineProtectedAir);
			this.toolStripSeparator_91.Visible = (this.toolStripDropDownButton_0.Visible = (this.objList_0.Type == TypeObjList.LineCable || this.objList_0.Type == TypeObjList.LineAir || this.objList_0.Type == TypeObjList.LineProtectedAir || this.objList_0.GroupType == TypeObjListGroup.Substations));
			this.toolStripMenuItem_57.Visible = (this.objList_0.Type == TypeObjList.LineCable);
			this.toolStripMenuItem_62.Visible = (this.objList_0.Type == TypeObjList.LineAir || this.objList_0.Type == TypeObjList.LineProtectedAir);
			this.toolStripButton_147.Visible = (this.objList_0.Type == TypeObjList.LineCable);
		}

		private void method_1()
		{
			this.toolStripControlHost_0 = new ToolStripControlHost(this.dateTimePicker_1);
			this.toolStripControlHost_0.Name = "dtTSCabOperationDate";
			this.toolStripControlHost_1 = new ToolStripControlHost(this.comboBox_0);
			this.toolStripControlHost_1.Name = "dtTSCabOperationReason";
		}

		private void method_2()
		{
			try
			{
				Assembly.Load("DocPPR");
				this.bool_4 = true;
			}
			catch (Exception)
			{
			}
		}

		private EISSettings method_3()
		{
			AppConfig appConfig = new AppConfig();
			this.eissettings_0 = appConfig.OpenAppConfig();
			if (this.eissettings_0.FrmPassportSettings == null)
			{
				FormPassportSettings formPassportSettings = new FormPassportSettings();
				formPassportSettings.CompressValue = 30;
				this.eissettings_0.FrmPassportSettings = formPassportSettings;
				appConfig.SaveAppConfig(this.eissettings_0);
			}
			return this.eissettings_0;
		}

		private void method_4(TreeView treeView_1, int int_3)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.vP_ObjListHierarchicalData, true, "where id = " + int_3.ToString());
			treeView_1.BeginUpdate();
			treeView_1.Nodes.Clear();
			TreeNodeData treeNodeData;
			if (this.class107_0.vP_ObjListHierarchicalData.Rows.Count == 0)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.vP_GetObjListData, true, "where id = " + int_3.ToString());
				if (this.class107_0.vP_GetObjListData.Rows.Count == 0)
				{
					return;
				}
				DataRow dataRow = this.class107_0.vP_GetObjListData.First<Class107.Class280>();
				treeNodeData = new TreeNodeData((int)dataRow["id"], (dataRow["IdParent"] != DBNull.Value) ? ((int)dataRow["IdParent"]) : -1, (int)dataRow["TypeCodeId"], dataRow["Name"].ToString(), dataRow["SocrName"].ToString() + "-" + dataRow["Name"].ToString(), 0);
			}
			else
			{
				DataRow dataRow2 = this.class107_0.vP_ObjListHierarchicalData.First<Class107.Class278>();
				treeNodeData = new TreeNodeData((int)dataRow2["id"], (dataRow2["IdParent"] != DBNull.Value) ? ((int)dataRow2["IdParent"]) : -1, (int)dataRow2["TypeCodeId"], dataRow2["Name"].ToString(), dataRow2["Text"].ToString(), 0);
			}
			TreeNode treeNode = new TreeNode(treeNodeData.Text);
			treeNode.Name = treeNodeData.Name;
			treeNode.Tag = treeNodeData.Id;
			treeNode.ImageIndex = this.method_11(treeNodeData.TypeCodeId);
			treeNode.Nodes.Add("None");
			treeView_1.Nodes.Add(treeNode);
			treeNode.Expand();
			treeView_1.EndUpdate();
			if (this.treeView_0.Nodes.Count > 0)
			{
				this.treeView_0.SelectedNode = this.treeView_0.Nodes[0];
			}
		}

		private void method_5(TreeView treeView_1, TypeObjListGroup typeObjListGroup_1, FormDockPassport.Sort sort_1)
		{
			try
			{
				this.typeObjListGroup_0 = typeObjListGroup_1;
				string text = string.Join(",", (from i in ObjList.GetGroupValue(typeObjListGroup_1)
				select i.ToString()).ToArray<string>());
				string groupParentKey = ObjList.GetGroupParentKey(typeObjListGroup_1);
				List<TreeNodeData> list = new List<TreeNodeData>();
				string text2 = (sort_1 == FormDockPassport.Sort.Asc) ? " ASC" : " DESC";
				string text3;
				if (text.Length != 0)
				{
					text3 = string.Format("WHERE ParentKey LIKE '{0}%' AND Value IN ({1}) order by Name {2}", groupParentKey, text, text2);
				}
				else
				{
					text3 = string.Format("WHERE ParentKey LIKE '{0}%' order by Name {1}", groupParentKey, text2);
				}
				treeView_1.BeginUpdate();
				treeView_1.Nodes.Clear();
				if (typeObjListGroup_1 == TypeObjListGroup.Substations || typeObjListGroup_1 == TypeObjListGroup.AirLines)
				{
					this.method_8(treeView_1, typeObjListGroup_1);
				}
				try
				{
					if (typeObjListGroup_1 != TypeObjListGroup.CableLines)
					{
						if (typeObjListGroup_1 != TypeObjListGroup.AirLines)
						{
							base.SelectSqlData(this.class107_0.vP_ObjListHierarchicalData, true, text3, null, true, 0);
							list = (from rows in this.class107_0.vP_ObjListHierarchicalData
							select new TreeNodeData(rows.Field("Id"), rows.Field("TypeCodeId"), rows.Field("Name"), rows.Field("Text"), -1m, -1)).ToList<TreeNodeData>();
							goto IL_15D;
						}
					}
					if (typeObjListGroup_1 == TypeObjListGroup.CableLines)
					{
						this.method_6();
					}
					else
					{
						this.wXeIupBpAw();
					}
					list = (from rows in base.SelectSqlData("vP_CableLine", true, text3).AsEnumerable()
					select new TreeNodeData(rows.Field("Id"), rows.Field("TypeCodeId"), rows.Field("Name"), rows.Field("Text"), (rows["Voltage"] == DBNull.Value) ? 10m : rows.Field("Voltage"), (rows["IdParentAddl"] != DBNull.Value) ? ((int)rows["IdParentAddl"]) : -1)).ToList<TreeNodeData>();
					IL_15D:;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				foreach (TreeNodeData treeNodeData in list)
				{
					TreeNode treeNode = new TreeNode(treeNodeData.Text);
					treeNode.Name = treeNodeData.Name;
					treeNode.Tag = treeNodeData.Id;
					treeNode.Nodes.Add("None");
					switch (typeObjListGroup_1)
					{
					case TypeObjListGroup.Substations:
						this.treeView_0.Nodes[treeNodeData.TypeCodeId.ToString()].Nodes.Add(treeNode);
						continue;
					case TypeObjListGroup.CableLines:
						if (treeNodeData.IdParentAddl != -1)
						{
							this.treeNode_2.Nodes.Add(treeNode);
							continue;
						}
						if (!(treeNodeData.Voltage == 10m) && !(treeNodeData.Voltage == 6m))
						{
							this.treeView_0.Nodes["NodeNN"].Nodes.Add(treeNode);
							continue;
						}
						this.treeView_0.Nodes["NodeSN"].Nodes.Add(treeNode);
						continue;
					case TypeObjListGroup.AirLines:
						this.method_7(treeNodeData, treeNode);
						continue;
					}
					treeView_1.Nodes.Add(treeNode);
				}
				treeView_1.EndUpdate();
			}
			catch (Exception)
			{
			}
		}

		private void method_6()
		{
			this.treeNode_0 = new TreeNode("0,4 кВ");
			this.treeNode_0.Name = "NodeNN";
			this.treeNode_0.Tag = 229;
			this.treeView_0.Nodes.Add(this.treeNode_0);
			this.treeNode_1 = new TreeNode("6-10 кВ");
			this.treeNode_1.Tag = 228;
			this.treeNode_1.Name = "NodeSN";
			this.treeView_0.Nodes.Add(this.treeNode_1);
			this.treeNode_2 = new TreeNode("Кабельная перемычка");
			this.treeNode_2.Tag = 0;
			this.treeView_0.Nodes.Add(this.treeNode_2);
		}

		private void method_7(TreeNodeData treeNodeData_0, TreeNode treeNode_3)
		{
			if (!(treeNodeData_0.Voltage == 10m) && !(treeNodeData_0.Voltage == 6m))
			{
				this.treeView_0.Nodes[treeNodeData_0.TypeCodeId.ToString()].Nodes["NodeNN"].Nodes.Add(treeNode_3);
				return;
			}
			this.treeView_0.Nodes[treeNodeData_0.TypeCodeId.ToString()].Nodes["NodeSN"].Nodes.Add(treeNode_3);
		}

		private void wXeIupBpAw()
		{
			foreach (object obj in this.treeView_0.Nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				this.treeNode_0 = new TreeNode("0,4 кВ");
				this.treeNode_0.Name = "NodeNN";
				this.treeNode_0.Tag = 229;
				this.treeNode_0.Expand();
				treeNode.Nodes.Add(this.treeNode_0);
				this.treeNode_1 = new TreeNode("6-10 кВ");
				this.treeNode_1.Tag = 228;
				this.treeNode_1.Expand();
				this.treeNode_1.Name = "NodeSN";
				treeNode.Nodes.Add(this.treeNode_1);
			}
		}

		private void method_8(TreeView treeView_1, TypeObjListGroup typeObjListGroup_1)
		{
			string arg = string.Join(",", (from i in ObjList.GetGroupValue(typeObjListGroup_1)
			select i.ToString()).ToArray<string>());
			foreach (object obj in base.SelectSqlData("tR_Classifier", true, string.Format("WHERE Parentkey = '{0}' AND Value IN ({1}) AND isGroup = ((0)) AND Deleted = ((0))", ObjList.GetGroupParentKey(typeObjListGroup_1), arg)).Rows)
			{
				DataRow dataRow = (DataRow)obj;
				TreeNode treeNode = new TreeNode(dataRow["SocrName"].ToString());
				treeNode.Tag = (int)dataRow["id"];
				treeNode.Name = dataRow["id"].ToString();
				treeView_1.Nodes.Add(treeNode);
			}
		}

		private void method_9(TreeNode treeNode_3)
		{
			int num = 0;
			if (!int.TryParse(treeNode_3.Tag.ToString(), out num))
			{
				treeNode_3.Nodes.Clear();
				return;
			}
			base.SelectSqlData(this.class107_0, this.class107_0.vP_ObjListHierarchicalData, true, string.Format("where idParent = {0} order by Name", num.ToString()));
			if (this.class107_0.vP_ObjListHierarchicalData.Rows.Count == 0)
			{
				treeNode_3.Nodes.Clear();
				return;
			}
			treeNode_3.TreeView.BeginUpdate();
			treeNode_3.Nodes.Clear();
			foreach (Class107.Class278 @class in this.class107_0.vP_ObjListHierarchicalData)
			{
				TreeNode treeNode = new TreeNode();
				treeNode.Text = @class.Text;
				treeNode.Name = @class.Name;
				treeNode.Tag = @class.Id;
				treeNode.Nodes.Add("None");
				treeNode_3.Nodes.Add(treeNode);
			}
			treeNode_3.TreeView.EndUpdate();
		}

		private List<string> method_10(TreeNode treeNode_3, List<string> list_4)
		{
			if (treeNode_3.Parent.Parent == null)
			{
				list_4.Add(treeNode_3.Tag.ToString());
				return list_4;
			}
			list_4.Add(treeNode_3.Tag.ToString());
			return this.method_10(treeNode_3.Parent, list_4);
		}

		private int method_11(int int_3)
		{
			int result = 0;
			if (int_3 > 95)
			{
				switch (int_3)
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
					if (int_3 != 584)
					{
						if (int_3 != 612)
						{
							return result;
						}
						return this.imageList_0.Images.IndexOfKey("Clutch");
					}
					break;
				}
				return this.imageList_0.Images.IndexOfKey("Cell");
			}
			if (int_3 != 79)
			{
				if (int_3 == 84)
				{
					goto IL_16B;
				}
				if (int_3 != 95)
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

		private void method_12(FormDockPassport.Sort sort_1)
		{
			FormDockPassport.FillTree fillTree = this.fillTree_0;
			if (fillTree == FormDockPassport.FillTree.One)
			{
				this.method_4(this.treeView_0, this.int_0);
				return;
			}
			if (fillTree != FormDockPassport.FillTree.All)
			{
				return;
			}
			this.method_5(this.treeView_0, this.typeObjListGroup_0, this.sort_0);
		}

		private void toolStripButton_4_Click(object sender, EventArgs e)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_13(this.treeView_0.Nodes, list_);
			TreeNode treeNode = this.method_15(list_, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text);
			if (treeNode != null)
			{
				this.treeView_0.Focus();
				this.treeView_0.SelectedNode = treeNode;
				this.treeView_0.SelectedNode.Expand();
			}
		}

		private void EgvhzrfdWJ_Click(object sender, EventArgs e)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_13(this.treeView_0.Nodes, list_);
			TreeNode treeNode = this.method_16(list_, this.toolStripTextBox_0.Text);
			if (treeNode != null)
			{
				this.treeView_0.Focus();
				this.treeView_0.SelectedNode = treeNode;
				this.treeView_0.SelectedNode.Expand();
			}
		}

		private List<TreeNode> method_13(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_4)
		{
			foreach (object obj in treeNodeCollection_0)
			{
				TreeNode treeNode = (TreeNode)obj;
				list_4.Add(treeNode);
				list_4 = this.method_13(treeNode.Nodes, list_4);
			}
			return list_4;
		}

		private List<TreeNode> method_14(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_4)
		{
			foreach (object obj in treeNodeCollection_0)
			{
				TreeNode treeNode = (TreeNode)obj;
				if (treeNode.IsExpanded)
				{
					list_4.Add(treeNode);
				}
				list_4 = this.method_14(treeNode.Nodes, list_4);
			}
			return list_4;
		}

		private TreeNode method_15(List<TreeNode> list_4, TreeNode treeNode_3, string string_1)
		{
			bool flag = false;
			foreach (TreeNode treeNode in list_4)
			{
				if (flag && treeNode.Name.ToUpper().Contains(string_1.ToUpper()))
				{
					return treeNode;
				}
				if (treeNode == treeNode_3)
				{
					flag = true;
				}
			}
			return null;
		}

		private TreeNode method_16(List<TreeNode> list_4, string string_1)
		{
			foreach (TreeNode treeNode in list_4)
			{
				if (treeNode.Name.ToUpper().Contains(string_1.ToUpper()))
				{
					return treeNode;
				}
			}
			return null;
		}

		private TreeNode method_17(List<TreeNode> list_4, int int_3)
		{
			foreach (TreeNode treeNode in list_4)
			{
				if ((int)treeNode.Tag == int_3)
				{
					return treeNode;
				}
			}
			return null;
		}

		private bool method_18(TreeNode treeNode_3)
		{
			return treeNode_3.Nodes[0].Text == "None";
		}

		private void toolStripTextBox_0_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				List<TreeNode> list_ = new List<TreeNode>();
				list_ = this.method_13(this.treeView_0.Nodes, list_);
				TreeNode treeNode = this.method_16(list_, this.toolStripTextBox_0.Text);
				if (treeNode != null)
				{
					this.treeView_0.SelectedNode = treeNode;
					this.treeView_0.SelectedNode.Expand();
				}
			}
		}

		private void toolStripButton_60_Click(object sender, EventArgs e)
		{
			this.toolStripButton_60.Image = ((this.sort_0 == FormDockPassport.Sort.Asc) ? Resources.smethod_53() : Resources.smethod_52());
			this.sort_0 = ((this.sort_0 == FormDockPassport.Sort.Asc) ? FormDockPassport.Sort.Desc : FormDockPassport.Sort.Asc);
			List<TreeNode> list = new List<TreeNode>();
			this.method_14(this.treeView_0.Nodes, list);
			this.method_12(this.sort_0);
			List<TreeNode> list2 = new List<TreeNode>();
			this.method_13(this.treeView_0.Nodes, list2);
			using (List<TreeNode>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					TreeNode node = enumerator.Current;
					IEnumerable<TreeNode> source = from n in list2
					where n.Text == node.Text || (n.Tag == node.Tag && n.Text == node.Text)
					select n;
					if (source.Count<TreeNode>() > 0)
					{
						source.First<TreeNode>().Expand();
					}
				}
			}
		}

		private void treeView_0_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.objList_0.Id = (int)e.Node.Tag;
		}

		private void method_19(object sender, ObjListEventArgs e)
		{
			ObjList objList = (ObjList)sender;
			if (this.fillTree_0 == FormDockPassport.FillTree.One)
			{
				this.bool_3 = true;
			}
			else
			{
				this.bool_3 = (this.string_0 != this.objList_0.ParentKey);
			}
			this.method_29(objList.ParentKey == ";SCM;PS;" || objList.ParentKey == ";SCM;Line;" || objList.ParentKey == ";SCM;INLINE_OBJ;SWITCH;");
			this.method_0();
			this.method_20(objList);
		}

		private void method_20(ObjList objList_1)
		{
			this.method_119(objList_1.Id, objList_1.ParentKey, objList_1.FullName, objList_1.Type);
			this.method_35(objList_1.Id);
		}

		private void treeView_0_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if ((int)e.Node.Tag != 0 && e.Node.Nodes.Count > 0 && this.method_18(e.Node))
			{
				this.method_9(e.Node);
			}
		}

		private void treeView_0_BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				this.string_0 = this.objList_0.ParentKey;
			}
		}

		private void treeView_0_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.objList_0.Id = (int)this.treeView_0.HitTest(e.Location).Node.Tag;
				this.treeView_0.SelectedNode = this.treeView_0.HitTest(e.Location).Node;
				this.toolStripButton_148.Visible = (this.toolStripButton_149.Visible = (this.objList_0.ParentKey != ""));
			}
		}

		private void toolStripButton_137_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode == null || this.objList_0.ParentKey == string.Empty)
			{
				return;
			}
			if (this.objList_0.IdPassport != -1 && MessageBox.Show("У данного объекта уже имеется активный паспорт.\r\nПри сохранении нового паспорта действующий паспорт будет деактивирован.\r\nПродолжить?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
			{
				return;
			}
			if (new FormAddEditValuePassportChars(this.SqlSettings, 0, this.objList_0.Id, -1).ShowDialog() == DialogResult.OK)
			{
				this.objList_0.Id = (int)this.treeView_0.SelectedNode.Tag;
				this.method_20(this.objList_0);
				Class318.smethod_2(this.SqlSettings, this.int_2, 0);
			}
		}

		private void toolStripButton_138_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode == null || this.objList_0.ParentKey == string.Empty)
			{
				return;
			}
			if (this.dataGridViewPassport_0.RowCount == 0)
			{
				new FormAddEditValuePassportChars(this.SqlSettings, 0, this.objList_0.Id, -1).ShowDialog();
				this.method_20(this.objList_0);
				Class318.smethod_2(this.SqlSettings, this.int_2, 0);
				return;
			}
			new FormAddEditValuePassportChars(this.SqlSettings, 1, this.objList_0.Id, this.objList_0.IdPassport).ShowDialog();
			this.method_20(this.objList_0);
			Class318.smethod_2(this.SqlSettings, this.int_2, 1);
		}

		private void toolStripButton_139_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null && this.objList_0.IdPassport != -1)
			{
				if (MessageBox.Show("Вы действительно хотите удалить паспорт?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
				{
					return;
				}
				base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where idObjList = {0} and isActive = 1", this.objList_0.Id), null, true, 0);
				this.class107_0.tP_Passport.Rows[0]["Deleted"] = true;
				this.class107_0.tP_Passport.Rows[0]["IsActive"] = false;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_Passport);
				this.method_20(this.objList_0);
				Class318.smethod_2(this.SqlSettings, this.int_2, 2);
			}
		}

		private void toolStripButton_141_Click(object sender, EventArgs e)
		{
			this.method_12(this.sort_0);
			if (this.treeView_0.SelectedNode != null)
			{
				this.method_20(this.objList_0);
			}
		}

		private void toolStripButton_140_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				new Class5(this.SqlSettings, this.objList_0.Id)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_142_Click(object sender, EventArgs e)
		{
			if (this.tableLayoutPanel_0.ColumnStyles[0].Width == 0f)
			{
				this.tableLayoutPanel_0.ColumnStyles[0].SizeType = SizeType.Percent;
				this.tableLayoutPanel_0.ColumnStyles[0].Width = 34.05612f;
				return;
			}
			this.tableLayoutPanel_0.ColumnStyles[0].SizeType = SizeType.Percent;
			this.tableLayoutPanel_0.ColumnStyles[0].Width = 0f;
		}

		private void toolStripButton_143_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null && this.objList_0.Id > 0)
			{
				this.bool_0 = !this.bool_0;
				if (this.bool_0)
				{
					this.toolStripButton_143.Image = Resources.smethod_57();
					this.toolStripButton_143.Text = (this.toolStripButton_143.ToolTipText = "Собрать характеристики в одну вкладку");
					this.method_23(this.objList_0.Id);
					return;
				}
				this.toolStripButton_143.Image = Resources.smethod_56();
				this.toolStripButton_143.Text = (this.toolStripButton_143.ToolTipText = "Разделить характеристики по вкладкам");
				this.method_24();
				this.method_25(this.objList_0.Id);
			}
		}

		private void toolStripButton_144_Click(object sender, EventArgs e)
		{
			if (this.toolStripButton_144.Tag.ToString() == ";SCM;PS;")
			{
				new FormPassportCountSwitch(this.SqlSettings)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
			if (this.toolStripButton_144.Tag.ToString() == ";SCM;Line;")
			{
				new FormReportOffKL
				{
					MdiParent = base.MdiParent,
					SqlSettings = this.SqlSettings
				}.Show();
			}
		}

		private void toolStripButton_144_VisibleChanged(object sender, EventArgs e)
		{
			this.toolStripSeparator_95.Visible = this.toolStripButton_144.Visible;
		}

		private void toolStripButton_145_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				SchmObj.UnbindPassport(this.SqlSettings, this.objList_0.Id);
				this.method_20(this.objList_0);
				Class318.smethod_2(this.SqlSettings, this.int_2, 10);
			}
		}

		private void toolStripButton_146_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null && new FormUnbindCablePassport(this.SqlSettings, this.objList_0.Id).ShowDialog() == DialogResult.OK)
			{
				this.method_20(this.objList_0);
				Class318.smethod_2(this.SqlSettings, this.int_2, 9);
			}
		}

		private void pIwCtYoiRy(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				FormLoadOldCablePassport formLoadOldCablePassport = new FormLoadOldCablePassport(this.SqlSettings, this.objList_0.Id);
				formLoadOldCablePassport.MdiParent = base.MdiParent;
				formLoadOldCablePassport.FormClosing += this.method_206;
				formLoadOldCablePassport.Show();
			}
		}

		private void toolStripDropDownButton_0_Click(object sender, EventArgs e)
		{
		}

		private void toolStripMenuItem_56_Click(object sender, EventArgs e)
		{
			this.method_21();
		}

		private void toolStripMenuItem_62_Click(object sender, EventArgs e)
		{
			if (this.objList_0.Type == TypeObjList.LineAir || this.objList_0.Type == TypeObjList.LineProtectedAir)
			{
				new FormPylonsReport(this.objList_0.Id)
				{
					SqlSettings = this.SqlSettings,
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void method_21()
		{
			if (this.objList_0.ParentKey == ";SCM;Line;" || this.objList_0.ParentKey == ";SCM;PS;")
			{
				if (this.objList_0.Type == TypeObjList.LineCable)
				{
					Form6 form = new Form6(this.objList_0.Id);
					form.SqlSettings = this.SqlSettings;
					form.Format = FormatReport.A3;
					form.MdiParent = base.MdiParent;
					form.method_0(this.method_22(this.objList_0.Id));
					form.Show();
					return;
				}
				if (this.objList_0.Type != TypeObjList.LineAir)
				{
					if (this.objList_0.Type != TypeObjList.LineProtectedAir)
					{
						if (this.objList_0.GroupType == TypeObjListGroup.Substations)
						{
							new Form6(this.objList_0.Id)
							{
								Format = FormatReport.A4,
								SqlSettings = this.SqlSettings,
								MdiParent = base.MdiParent
							}.Show();
							return;
						}
						return;
					}
				}
				new FormAirLinePassport
				{
					SqlSettings = this.SqlSettings,
					Voltage = this.method_22(this.objList_0.Id),
					IdObjList = this.objList_0.Id,
					MdiParent = base.MdiParent
				}.Show();
				return;
			}
		}

		private TensionType method_22(int int_3)
		{
			object obj = new SqlDataCommand(this.SqlSettings).CallSQLScalarFunction("[dbo].[fn_P_GetMaxCableVoltage]", new string[]
			{
				int_3.ToString()
			});
			if (obj == DBNull.Value)
			{
				if (this.objList_0.ParentKey == ";SCM;Line;")
				{
					return (TensionType)this.treeView_0.SelectedNode.Parent.Tag;
				}
				return 226;
			}
			else
			{
				if (Convert.ToDecimal(obj) > 10m)
				{
					return 227;
				}
				if (Convert.ToDecimal(obj) <= 4m)
				{
					return 229;
				}
				return 228;
			}
		}

		private void toolStripButton_148_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				this.OnGoToSchema(new GoToSchemaEventArgs(this.objList_0.Id));
			}
		}

		private void toolStripButton_149_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null && !(this.objList_0.ParentKey == string.Empty))
			{
				if (new FormTransfRename(this.SqlSettings, this.objList_0.Id).ShowDialog() == DialogResult.OK)
				{
					this.method_20(this.objList_0);
					Class318.smethod_2(this.SqlSettings, this.int_2, 1);
				}
				return;
			}
			MessageBox.Show("Выберите объект для переименования.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		private void method_23(int int_3)
		{
			base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where isActive = 1 and Deleted = 0 and idObjList = {0}", int_3), null, true, 0);
			if (this.class107_0.tP_Passport.Rows.Count > 0)
			{
				List<TabPage> list = new List<TabPage>();
				int num = (int)this.class107_0.tP_Passport.Rows[0]["id"];
				List<Class107.Class224> list2 = this.method_26(num);
				for (int i = 0; i < list2.Count; i++)
				{
					if (i > 0)
					{
						list.Add(new TabPage(list2[i].Name));
						DataGridViewPassport dataGridViewPassport = new DataGridViewPassport();
						dataGridViewPassport.Name = "dgv" + list2[i].Name;
						dataGridViewPassport.Dock = DockStyle.Fill;
						dataGridViewPassport.AddRowViewingParameters(this.SqlSettings, num, list2[i].id, list2[i].ParentKey);
						list[i - 1].Controls.Add(dataGridViewPassport);
					}
				}
				this.method_24();
				this.dataGridViewPassport_0.AddRowViewingParameters(this.SqlSettings, num, list2[0].id, list2[0].ParentKey);
				for (int j = 1; j < list.Count + 1; j++)
				{
					this.tabControl_0.TabPages.Insert(j, list[j - 1]);
				}
				return;
			}
			this.method_24();
		}

		private void method_24()
		{
			if (this.tabControl_0.TabPages.Count > this.list_2.Count)
			{
				this.dataGridViewPassport_0.Rows.Clear();
				if (this.list_2.Count < this.tabControl_0.TabPages.Count)
				{
					for (int i = this.tabControl_0.TabPages.Count - 1; i >= 0; i--)
					{
						if (this.list_2.IndexOf(this.tabControl_0.TabPages[i].Name) == -1)
						{
							this.tabControl_0.TabPages[i].Dispose();
						}
					}
				}
			}
		}

		private void method_25(int int_3)
		{
			base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where isActive = 1 and Deleted = 0 and idObjList = {0}", int_3), null, true, 0);
			if (this.class107_0.tP_Passport.Rows.Count > 0)
			{
				this.dateTimePicker_0.Value = DateTime.Parse(this.class107_0.tP_Passport.Rows[0]["Date"].ToString());
				this.dataGridViewPassport_0.AddRowViewingParameters(this.SqlSettings, (int)this.class107_0.tP_Passport.Rows[0]["id"]);
				return;
			}
			this.dataGridViewPassport_0.Rows.Clear();
			this.dateTimePicker_0.Value = DateTime.Now;
		}

		internal List<Class107.Class224> method_26(int int_3)
		{
			new List<Class107.Class224>();
			string text = base.CallSQLScalarFunction("dbo.fn_GetCharListKeyByPassport", new string[]
			{
				int_3.ToString()
			}).ToString();
			base.SelectSqlDataTableOther(this.class107_0, this.class107_0.tP_GroupList, "tP_CharList", true, string.Concat(new string[]
			{
				"where ParentKey like '",
				text,
				"%' and ParentKey not like '",
				text,
				"' and isGroup = 1 and Deleted = 0"
			}));
			return this.class107_0.tP_GroupList.ToList<Class107.Class224>();
		}

		private List<string> method_27(TabControl tabControl_7)
		{
			List<string> list = new List<string>();
			foreach (object obj in tabControl_7.TabPages)
			{
				TabPage tabPage = (TabPage)obj;
				list.Add(tabPage.Name);
			}
			return list;
		}

		private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null && (int)this.treeView_0.SelectedNode.Tag != 0)
			{
				this.method_20(this.objList_0);
			}
			this.toolStripButton_143.Enabled = (this.tabControl_0.SelectedTab == this.tabPage_0);
		}

		private void label_2_Click(object sender, EventArgs e)
		{
			this.bool_2 = !this.bool_2;
			this.method_29(this.objList_0.ParentKey == ";SCM;PS;" || this.objList_0.ParentKey == ";SCM;Line;" || this.objList_0.ParentKey == ";SCM;INLINE_OBJ;SWITCH;");
			this.method_30();
			if (this.bool_2 && this.treeView_0.SelectedNode != null)
			{
				this.method_35(this.objList_0.Id);
			}
		}

		private bool method_28()
		{
			return this.tableLayoutPanel_2.RowStyles[3].Height != 0f;
		}

		private void method_29(bool value)
		{
			if (value && this.bool_2)
			{
				this.tableLayoutPanel_2.RowStyles[3].Height = 36.72169f;
				this.label_2.Cursor = Cursors.PanSouth;
				this.method_30();
				return;
			}
			this.tableLayoutPanel_2.RowStyles[3].Height = 0f;
			this.label_2.Cursor = Cursors.PanNorth;
		}

		private void method_30()
		{
			this.tabControl_2.SelectedIndexChanged -= this.tabControl_2_SelectedIndexChanged;
			if (this.bool_3)
			{
				if (this.objList_0.GroupType == TypeObjListGroup.Substations)
				{
					this.VisibleTabRange(this.tabControl_2, this.method_31());
				}
				if (this.objList_0.Type == TypeObjList.LineCable)
				{
					this.VisibleTabRange(this.tabControl_2, this.method_32());
				}
				if (this.objList_0.Type == TypeObjList.SwitchTransf)
				{
					this.VisibleTabRange(this.tabControl_2, this.method_34());
				}
				if (this.objList_0.Type == TypeObjList.LineAir || this.objList_0.Type == TypeObjList.LineProtectedAir)
				{
					this.VisibleTabRange(this.tabControl_2, this.method_33());
				}
			}
			this.tabControl_2.SelectedIndexChanged += this.tabControl_2_SelectedIndexChanged;
		}

		public void VisibleTabRange(TabControl control, IEnumerable<TabPage> page)
		{
			foreach (object obj in control.TabPages)
			{
				((TabPage)obj).Parent = null;
			}
			foreach (TabPage tabPage in page)
			{
				if (tabPage.Parent == null)
				{
					tabPage.Parent = control;
				}
			}
		}

		private List<TabPage> method_31()
		{
			return new List<TabPage>
			{
				this.tabPage_6,
				this.tabPage_7,
				this.tabPage_8,
				this.tabPage_15,
				this.tabPage_18,
				this.tabPage_19,
				this.tabPage_21
			};
		}

		private List<TabPage> method_32()
		{
			return new List<TabPage>
			{
				this.tabPage_7,
				this.tabPage_9,
				this.tabPage_10,
				this.pjuAjnsoym,
				this.tabPage_13,
				this.tabPage_30
			};
		}

		private List<TabPage> method_33()
		{
			return new List<TabPage>
			{
				this.tabPage_7,
				this.tabPage_31,
				this.tabPage_32,
				this.tabPage_33,
				this.tabPage_30,
				this.tabPage_34
			};
		}

		private List<TabPage> method_34()
		{
			return new List<TabPage>
			{
				this.tabPage_11,
				this.tabPage_6,
				this.tabPage_15
			};
		}

		private void method_35(int int_3)
		{
			if (!this.method_28())
			{
				return;
			}
			string parentKey = this.objList_0.ParentKey;
			if (!(parentKey == ";SCM;PS;"))
			{
				if (!(parentKey == ";SCM;Line;"))
				{
					if (!(parentKey == ";SCM;INLINE_OBJ;SWITCH;"))
					{
						return;
					}
					if (this.tabControl_2.SelectedTab == this.tabPage_6)
					{
						this.dataGridView_2.DataSource = PassportData.GetRepairData(this.SqlSettings, int_3);
					}
					if (this.tabControl_2.SelectedTab == this.tabPage_11)
					{
						this.dataGridView_8.DataSource = Class322.smethod_0(this.SqlSettings, this.objList_0.Id);
					}
					if (this.tabControl_2.SelectedTab == this.tabPage_15)
					{
						this.method_166();
					}
					if (this.tabControl_2.SelectedTab == this.tabPage_18)
					{
						this.method_168();
					}
				}
				else
				{
					if (this.tabControl_2.SelectedTab == this.tabPage_7)
					{
						TypeObjListGroup typeObjListGroup = this.typeObjListGroup_0;
						if (typeObjListGroup == TypeObjListGroup.AirLines)
						{
							this.method_141(int_3);
						}
						else
						{
							this.dataGridView_3.DataSource = PassportData.GetBalanceData(this.SqlSettings, int_3);
						}
					}
					if (this.tabControl_2.SelectedTab == this.tabPage_9)
					{
						base.SelectSqlData(this.class107_0, this.class107_0.vP_CabTesting, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", int_3));
						this.dataGridView_5.DataSource = this.bindingSource_0;
					}
					if (this.tabControl_2.SelectedTab == this.tabPage_10)
					{
						this.method_36();
						base.SelectSqlData(this.class107_0, this.class107_0.vP_CabOperation, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0)) order by Convert(datetime, dateDecommissioning, 104) desc", int_3));
						this.dataGridView_6.DataSource = this.bindingSource_1;
						this.method_151();
					}
					if (this.tabControl_2.SelectedTab == this.pjuAjnsoym)
					{
						base.SelectSqlData(this.jtnAdxtlvN, this.jtnAdxtlvN.tP_CabProtocol, true, "WHERE idObjList = " + int_3.ToString() + " AND Deleted = ((0))");
						this.bindingSource_3.DataSource = this.jtnAdxtlvN.tP_CabProtocol;
					}
					if (this.tabControl_2.SelectedTab == this.tabPage_13)
					{
						this.method_158(this.objList_0.Id);
					}
					if (this.tabControl_2.SelectedTab == this.tabPage_24)
					{
						this.method_114(this.objList_0.Id);
					}
					if (this.tabControl_2.SelectedTab == this.tabPage_30)
					{
						this.method_178(new int?(int_3));
					}
					if (this.tabControl_2.SelectedTab == this.tabPage_31)
					{
						this.method_184(this.objList_0.Id);
					}
					if (this.tabControl_2.SelectedTab == this.tabPage_32)
					{
						this.method_190(this.objList_0.Id);
					}
					if (this.tabControl_2.SelectedTab == this.tabPage_33)
					{
						this.method_196(this.objList_0.Id);
					}
					if (this.tabControl_2.SelectedTab == this.tabPage_34)
					{
						this.method_202(this.objList_0.Id);
						return;
					}
				}
			}
			else
			{
				if (this.tabControl_2.SelectedTab == this.tabPage_7)
				{
					this.dataGridView_3.DataSource = PassportData.GetBalanceData(this.SqlSettings, int_3);
				}
				if (this.tabControl_2.SelectedTab == this.tabPage_6)
				{
					this.dataGridView_2.DataSource = PassportData.GetRepairData(this.SqlSettings, int_3);
				}
				if (this.tabControl_2.SelectedTab == this.tabPage_8)
				{
					this.dataGridView_4.DataSource = PassportData.GetBuildRepairData(this.SqlSettings, int_3);
				}
				if (this.tabControl_2.SelectedTab == this.tabPage_15)
				{
					this.method_166();
				}
				if (this.tabControl_2.SelectedTab == this.tabPage_18)
				{
					this.method_168();
				}
				if (this.tabControl_2.SelectedTab == this.tabPage_19)
				{
					this.method_171();
				}
				if (this.tabControl_2.SelectedTab == this.tabPage_21)
				{
					this.method_161();
				}
				if (this.tabControl_2.SelectedTab == this.tabPage_24)
				{
					this.method_114(this.objList_0.Id);
					return;
				}
			}
		}

		private void method_36()
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_ValueLists, true, "WHERE ParentKey = ';Cable;Addl;OperReason;' AND Deleted = ((0))");
			this.comboBox_0.DataSource = this.bindingSource_2;
			this.comboBox_0.ValueMember = "Id";
			this.comboBox_0.DisplayMember = "Name";
		}

		private void method_37(int int_3, DataGridView dataGridView_17, PictureBox pictureBox_0)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_Image, true, string.Format("where idPasspDoc = {0} and Deleted = 0", int_3));
			dataGridView_17.DataSource = this.class107_0.tP_Image;
			if (dataGridView_17.RowCount > 0 && dataGridView_17.SelectedRows != null)
			{
				dataGridView_17.Rows[0].Selected = true;
				pictureBox_0.Image = new Bitmap((Image)dataGridView_17.Rows[0].Cells["Image"].Value);
			}
		}

		private void method_38(string string_1, int int_3, DataGridView dataGridView_17, PictureBox pictureBox_0)
		{
			Bitmap bitmap = new Bitmap(ImageCompress.GetCompressImage(ImageCompress.LoadBitmap(string_1), (long)this.eissettings_0.FrmPassportSettings.CompressValue));
			Class107.Class273 @class = this.class107_0.tP_Image.method_5();
			@class.idPasspDoc = int_3;
			@class.DateIn = DateTime.Now;
			@class.FileName = string_1.Substring(string_1.LastIndexOf("\\") + 2);
			@class.Image = ImageCompress.GetBytes(bitmap);
			@class.isActive = true;
			@class.Deleted = false;
			this.class107_0.tP_Image.method_0(@class);
			base.InsertSqlData(this.class107_0, this.class107_0.tP_Image);
			dataGridView_17.DataSource = this.class107_0.tP_Image;
			pictureBox_0.Image = bitmap;
			pictureBox_0.SizeMode = PictureBoxSizeMode.Zoom;
		}

		private void method_39()
		{
			base.InsertSqlData(this.class107_0, this.class107_0.tP_Image);
		}

		private void method_40(int int_3)
		{
			base.SelectSqlData(this.class107_0.tP_Image, true, string.Format("where id = {0}", int_3), null, true, 0);
			this.class107_0.tP_Image.Rows[0]["Deleted"] = true;
			base.UpdateSqlData(this.class107_0, this.class107_0.tP_Image);
		}

		private void toolStripButton_68_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_9.SelectedRows != null && this.objList_0.IdPassport != -1)
			{
				this.method_40((int)this.dataGridView_9.CurrentRow.Cells["idImage"].Value);
			}
		}

		private void toolStripButton_67_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null && this.objList_0.IdPassport != -1)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Все файлы(*.*)|*.*";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string fileName = openFileDialog.FileName;
					this.method_41(fileName);
				}
			}
		}

		private void method_41(string string_1)
		{
			System.IO.FileInfo fileInfo = new System.IO.FileInfo(string_1);
			DataRow dataRow = this.class107_0.tP_Image.NewRow();
			dataRow["idPasspDoc"] = this.objList_0.Id;
			dataRow["DateIn"] = DateTime.Now;
			dataRow["DateCreate"] = File.GetCreationTime(string_1);
			dataRow["FileName"] = fileInfo.Name;
			dataRow["Icon"] = ImageCompress.GetBytes(ImageCompress.GetIcon(string_1).ToBitmap());
			dataRow["Image"] = File.ReadAllBytes(string_1);
			dataRow["isActive"] = true;
			dataRow["Deleted"] = false;
			this.class107_0.tP_Image.Rows.Add(dataRow);
		}

		private void toolStripButton_69_Click(object sender, EventArgs e)
		{
		}

		private void method_42(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.dataGridView_9.Rows[e.RowIndex].Height = this.dataGridView_9.Columns["Image"].Width / 3 * 4;
			this.dataGridView_9.Rows[e.RowIndex].Cells["links"].Value = "Просмотр";
		}

		private void dataGridView_9_Click(object sender, EventArgs e)
		{
		}

		private void toolStripButton_70_Click(object sender, EventArgs e)
		{
		}

		private void sjguzMevbg_Click(object sender, EventArgs e)
		{
			int idObj = 0;
			if (this.dgvTrans.SelectedRows != null && this.dgvTrans.RowCount > 0 && int.TryParse(this.dgvTrans.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_130.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, 0, idObj, -1).ShowDialog() == DialogResult.OK)
			{
				this.method_45();
			}
		}

		private void toolStripButton_19_Click(object sender, EventArgs e)
		{
			this.method_43();
		}

		private void jbgCihdRyu(object sender, DataGridViewCellEventArgs e)
		{
			this.method_43();
		}

		private void method_43()
		{
			int idObj = 0;
			int num = 0;
			if (this.dgvTrans.SelectedRows != null && this.dgvTrans.RowCount > 0 && int.TryParse(this.dgvTrans.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_128.Name].Value.ToString(), out num) && int.TryParse(this.dgvTrans.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_130.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, (num == -1) ? 0 : 1, idObj, num).ShowDialog() == DialogResult.OK)
			{
				this.method_45();
			}
		}

		private void toolStripButton_20_Click(object sender, EventArgs e)
		{
			int num = 0;
			if (this.dgvTrans.SelectedRows != null && this.dgvTrans.RowCount > 0 && int.TryParse(this.dgvTrans.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_128.Name].Value.ToString(), out num) && MessageBox.Show("Вы действительно хотите удалить паспорт?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && num > 0)
			{
				base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where id = {0}", num), null, true, 0);
				this.class107_0.tP_Passport.Rows[0]["Deleted"] = true;
				this.class107_0.tP_Passport.Rows[0]["IsActive"] = false;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_Passport);
				this.method_45();
			}
		}

		private void toolStripButton_21_Click(object sender, EventArgs e)
		{
			if (this.dgvTrans.SelectedRows != null && this.dgvTrans.RowCount > 0)
			{
				new Class5(this.SqlSettings, (int)this.dgvTrans.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_130.Name].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_98_Click(object sender, EventArgs e)
		{
			FormTrasformer formTrasformer = new FormTrasformer();
			formTrasformer.FormClosed += this.method_44;
			formTrasformer.MdiParent = base.MdiParent;
			formTrasformer.SqlSettings = this.SqlSettings;
			formTrasformer.ViewButtons = true;
			formTrasformer.Show();
		}

		private void method_44(object sender, FormClosedEventArgs e)
		{
			FormTrasformer formTrasformer = (FormTrasformer)sender;
			if (formTrasformer.DialogResult == DialogResult.OK)
			{
				this.method_208(formTrasformer.Id);
				this.method_45();
			}
		}

		private void toolStripButton_22_Click(object sender, EventArgs e)
		{
			this.method_45();
		}

		private void method_45()
		{
			if (this.treeView_0.SelectedNode != null)
			{
				this.method_62(this.objList_0.Id);
			}
		}

		private void toolStripButton_93_Click(object sender, EventArgs e)
		{
			int idObj = 0;
			if (this.dgvTransV.SelectedRows != null && this.dgvTransV.RowCount > 0 && int.TryParse(this.dgvTransV.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_122.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, 0, idObj, -1).ShowDialog() == DialogResult.OK)
			{
				this.method_47();
			}
		}

		private void toolStripButton_94_Click(object sender, EventArgs e)
		{
			this.method_46();
		}

		private void dgvTransV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_46();
		}

		private void method_46()
		{
			int idObj = 0;
			int num = 0;
			if (this.dgvTransV.SelectedRows != null && this.dgvTransV.RowCount > 0 && int.TryParse(this.dgvTransV.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_120.Name].Value.ToString(), out num) && int.TryParse(this.dgvTransV.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_122.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, (num == -1) ? 0 : 1, idObj, num).ShowDialog() == DialogResult.OK)
			{
				this.method_47();
			}
		}

		private void toolStripButton_95_Click(object sender, EventArgs e)
		{
			int num = 0;
			if (this.dgvTransV.SelectedRows != null && this.dgvTransV.RowCount > 0 && int.TryParse(this.dgvTransV.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_120.Name].Value.ToString(), out num) && MessageBox.Show("Вы действительно хотите удалить паспорт?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && num > 0)
			{
				base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where id = {0}", num), null, true, 0);
				this.class107_0.tP_Passport.Rows[0]["Deleted"] = true;
				this.class107_0.tP_Passport.Rows[0]["IsActive"] = false;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_Passport);
				this.method_47();
			}
		}

		private void toolStripButton_96_Click(object sender, EventArgs e)
		{
			if (this.dgvTransV.SelectedRows != null && this.dgvTransV.RowCount > 0)
			{
				new Class5(this.SqlSettings, (int)this.dgvTransV.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_122.Name].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_97_Click(object sender, EventArgs e)
		{
			this.method_47();
		}

		private void tabControl_4_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.tabControl_4.SelectedTab == this.tabPage_16)
			{
				this.method_45();
			}
			if (this.tabControl_4.SelectedTab == this.tabPage_17)
			{
				this.method_47();
			}
			if (this.tabControl_4.SelectedTab == this.tabPage_20)
			{
				this.method_49();
			}
		}

		private void method_47()
		{
			if (this.treeView_0.SelectedNode != null)
			{
				this.method_61(this.objList_0.Id);
			}
		}

		private void toolStripButton_114_Click(object sender, EventArgs e)
		{
			int idObj = 0;
			if (this.dgvTransI.SelectedRows != null && this.dgvTransI.RowCount > 0 && int.TryParse(this.dgvTransI.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_126.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, 0, idObj, -1).ShowDialog() == DialogResult.OK)
			{
				this.method_49();
			}
		}

		private void toolStripButton_115_Click(object sender, EventArgs e)
		{
			this.method_48();
		}

		private void dgvTransI_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_48();
		}

		private void method_48()
		{
			int idObj = 0;
			int num = 0;
			if (this.dgvTransI.SelectedRows != null && this.dgvTransI.RowCount > 0 && int.TryParse(this.dgvTransI.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_124.Name].Value.ToString(), out num) && int.TryParse(this.dgvTransI.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_126.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, (num == -1) ? 0 : 1, idObj, num).ShowDialog() == DialogResult.OK)
			{
				this.method_49();
			}
		}

		private void toolStripButton_116_Click(object sender, EventArgs e)
		{
			int num = 0;
			if (this.dgvTransI.SelectedRows != null && this.dgvTransI.RowCount > 0 && int.TryParse(this.dgvTransI.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_124.Name].Value.ToString(), out num) && MessageBox.Show("Вы действительно хотите удалить паспорт?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && num > 0)
			{
				base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where id = {0}", num), null, true, 0);
				this.class107_0.tP_Passport.Rows[0]["Deleted"] = true;
				this.class107_0.tP_Passport.Rows[0]["IsActive"] = false;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_Passport);
				this.method_49();
			}
		}

		private void toolStripButton_117_Click(object sender, EventArgs e)
		{
			if (this.dgvTransI.SelectedRows != null && this.dgvTransI.RowCount > 0)
			{
				new Class5(this.SqlSettings, (int)this.dgvTransI.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_126.Name].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_118_Click(object sender, EventArgs e)
		{
			this.method_49();
		}

		private void method_49()
		{
			if (this.treeView_0.SelectedNode != null)
			{
				this.method_64(this.objList_0.Id);
			}
		}

		private void toolStripButton_14_Click(object sender, EventArgs e)
		{
			int idObj = 0;
			if (this.dgvSwitchgears.SelectedRows != null && this.dgvSwitchgears.RowCount > 0 && int.TryParse(this.dgvSwitchgears.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_133.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, 0, idObj, -1).ShowDialog() == DialogResult.OK)
			{
				this.method_51();
			}
		}

		private void toolStripButton_15_Click(object sender, EventArgs e)
		{
			this.method_50();
		}

		private void dgvSwitchgears_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_50();
		}

		private void method_50()
		{
			int idObj = 0;
			int num = 0;
			if (this.dgvSwitchgears.SelectedRows != null && this.dgvSwitchgears.RowCount > 0 && int.TryParse(this.dgvSwitchgears.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_132.Name].Value.ToString(), out num) && int.TryParse(this.dgvSwitchgears.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_133.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, (num == -1) ? 0 : 1, idObj, num).ShowDialog() == DialogResult.OK)
			{
				this.method_51();
			}
		}

		private void toolStripButton_16_Click(object sender, EventArgs e)
		{
			int num = 0;
			if (this.dgvSwitchgears.SelectedRows != null && this.dgvSwitchgears.RowCount > 0 && int.TryParse(this.dgvSwitchgears.SelectedRows[0].Cells["idSwitchgear"].Value.ToString(), out num) && MessageBox.Show("Вы действительно хотите удалить паспорт?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && num > 0)
			{
				base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where id = {0}", num), null, true, 0);
				this.class107_0.tP_Passport.Rows[0]["Deleted"] = true;
				this.class107_0.tP_Passport.Rows[0]["IsActive"] = false;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_Passport);
				this.method_51();
			}
		}

		private void toolStripButton_17_Click(object sender, EventArgs e)
		{
			if (this.dgvSwitchgears.SelectedRows != null && this.dgvSwitchgears.RowCount > 0)
			{
				new Class5(this.SqlSettings, (int)this.dgvSwitchgears.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_133.Name].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_18_Click(object sender, EventArgs e)
		{
			this.method_51();
		}

		private void method_51()
		{
			if (this.treeView_0.SelectedNode != null)
			{
				this.method_66(this.objList_0.Id);
			}
		}

		private void toolStripButton_5_Click(object sender, EventArgs e)
		{
			int idObj = 0;
			if (this.dgvBuses.SelectedRows != null && this.dgvBuses.RowCount > 0 && int.TryParse(this.dgvBuses.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_138.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, 0, idObj, -1).ShowDialog() == DialogResult.OK)
			{
				this.method_53();
			}
		}

		private void toolStripButton_6_Click(object sender, EventArgs e)
		{
			this.method_52();
		}

		private void dgvBuses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_52();
		}

		private void method_52()
		{
			int idObj = 0;
			int num = 0;
			if (this.dgvBuses.SelectedRows != null && this.dgvBuses.RowCount > 0 && int.TryParse(this.dgvBuses.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_135.Name].Value.ToString(), out num) && int.TryParse(this.dgvBuses.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_138.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, (num == -1) ? 0 : 1, idObj, num).ShowDialog() == DialogResult.OK)
			{
				this.method_53();
			}
		}

		private void toolStripButton_7_Click(object sender, EventArgs e)
		{
			int num = 0;
			if (this.dgvBuses.SelectedRows != null && this.dgvBuses.RowCount > 0 && int.TryParse(this.dgvBuses.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_135.Name].Value.ToString(), out num) && MessageBox.Show("Вы действительно хотите удалить паспорт?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && num > 0)
			{
				base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where id = {0} and isActive = 1", num), null, true, 0);
				this.class107_0.tP_Passport.Rows[0]["Deleted"] = true;
				this.class107_0.tP_Passport.Rows[0]["IsActive"] = false;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_Passport);
				this.method_53();
			}
		}

		private void toolStripButton_8_Click(object sender, EventArgs e)
		{
			if (this.dgvBuses.SelectedRows != null && this.dgvBuses.RowCount > 0)
			{
				new Class5(this.SqlSettings, (int)this.dgvBuses.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_138.Name].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_9_Click(object sender, EventArgs e)
		{
			this.method_53();
		}

		private void method_53()
		{
			BackgroundWorkerParams backgroundWorkerParams = default(BackgroundWorkerParams);
			if (this.dgvSwitchgears.CurrentRow != null && this.dgvSwitchgears.SelectedRows.Count > 0 && int.TryParse(this.dgvSwitchgears.CurrentRow.Cells[this.dataGridViewTextBoxColumn_133.Name].Value.ToString(), out backgroundWorkerParams.ParentId))
			{
				this.method_67(backgroundWorkerParams.ParentId);
			}
		}

		private void toolStripButton_10_Click(object sender, EventArgs e)
		{
			int idObj = 0;
			if (this.dgvCells.SelectedRows != null && this.dgvCells.RowCount > 0 && int.TryParse(this.dgvCells.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_142.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, 0, idObj, -1).ShowDialog() == DialogResult.OK)
			{
				this.method_55();
			}
		}

		private void toolStripButton_11_Click(object sender, EventArgs e)
		{
			this.method_54();
		}

		private void dgvCells_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_54();
		}

		private void method_54()
		{
			int idObj = 0;
			int num = 0;
			if (this.dgvCells.SelectedRows != null && this.dgvCells.RowCount > 0 && int.TryParse(this.dgvCells.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_139.Name].Value.ToString(), out num) && int.TryParse(this.dgvCells.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_142.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, (num == -1) ? 0 : 1, idObj, num).ShowDialog() == DialogResult.OK)
			{
				this.method_55();
			}
		}

		private void toolStripButton_12_Click(object sender, EventArgs e)
		{
			int num = 0;
			if (this.dgvCells.SelectedRows != null && this.dgvCells.RowCount > 0 && int.TryParse(this.dgvCells.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_139.Name].Value.ToString(), out num) && MessageBox.Show("Вы действительно хотите удалить паспорт?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && num > 0)
			{
				base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where id = {0}", num), null, true, 0);
				this.class107_0.tP_Passport.Rows[0]["Deleted"] = true;
				this.class107_0.tP_Passport.Rows[0]["IsActive"] = false;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_Passport);
				this.method_55();
			}
		}

		private void toolStripButton_13_Click(object sender, EventArgs e)
		{
			if (this.dgvCells.SelectedRows != null && this.dgvCells.RowCount > 0)
			{
				new Class5(this.SqlSettings, (int)this.dgvCells.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_142.Name].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void Arvudbkpvh_Click(object sender, EventArgs e)
		{
			this.method_55();
		}

		private void method_55()
		{
			BackgroundWorkerParams backgroundWorkerParams = default(BackgroundWorkerParams);
			if (this.dgvSwitchgears.CurrentRow != null && int.TryParse(this.dgvSwitchgears.CurrentRow.Cells[this.dataGridViewTextBoxColumn_133.Name].Value.ToString(), out backgroundWorkerParams.Id))
			{
				this.method_68(backgroundWorkerParams.Id);
			}
		}

		private void toolStripButton_23_Click(object sender, EventArgs e)
		{
			int idObj = 0;
			if (this.dgvSwitchgears.CurrentRow != null && this.dgvSwitches.RowCount > 0 && int.TryParse(this.dgvSwitches.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_145.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, 0, idObj, -1).ShowDialog() == DialogResult.OK)
			{
				this.method_57();
			}
		}

		private void toolStripButton_24_Click(object sender, EventArgs e)
		{
			this.method_56();
		}

		private void dgvSwitches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_56();
		}

		private void method_56()
		{
			int idObj = 0;
			int num = 0;
			if (this.dgvSwitches.SelectedRows != null && this.dgvSwitches.RowCount > 0 && int.TryParse(this.dgvSwitches.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_143.Name].Value.ToString(), out num) && int.TryParse(this.dgvSwitches.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_145.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, (num == -1) ? 0 : 1, idObj, num).ShowDialog() == DialogResult.OK)
			{
				this.method_57();
			}
		}

		private void toolStripButton_25_Click(object sender, EventArgs e)
		{
			int num = 0;
			if (this.dgvSwitches.SelectedRows != null && this.dgvSwitches.RowCount > 0 && int.TryParse(this.dgvSwitches.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_143.Name].Value.ToString(), out num) && MessageBox.Show("Вы действительно хотите удалить паспорт?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && num > 0)
			{
				base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where id = {0}", num), null, true, 0);
				this.class107_0.tP_Passport.Rows[0]["Deleted"] = true;
				this.class107_0.tP_Passport.Rows[0]["IsActive"] = false;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_Passport);
				this.method_57();
			}
		}

		private void toolStripButton_26_Click(object sender, EventArgs e)
		{
			if (this.dgvSwitches.SelectedRows != null && this.dgvSwitches.SelectedRows.Count > 0)
			{
				new Class5(this.SqlSettings, (int)this.dgvSwitches.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_145.Name].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_27_Click(object sender, EventArgs e)
		{
			this.method_57();
		}

		private void method_57()
		{
			BackgroundWorkerParams backgroundWorkerParams = default(BackgroundWorkerParams);
			if (this.dgvSwitchgears.CurrentRow != null && int.TryParse(this.dgvSwitchgears.CurrentRow.Cells[this.dataGridViewTextBoxColumn_133.Name].Value.ToString(), out backgroundWorkerParams.Id))
			{
				this.method_69(backgroundWorkerParams.Id);
			}
		}

		private void dgvSwitches_SelectionChanged(object sender, EventArgs e)
		{
		}

		private void toolStripButton_123_Click(object sender, EventArgs e)
		{
			int idObj = 0;
			if (this.dataGridViewExcelFilter_6.CurrentRow != null && this.dataGridViewExcelFilter_6.RowCount > 0 && int.TryParse(this.dataGridViewExcelFilter_6.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_111.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, 0, idObj, -1).ShowDialog() == DialogResult.OK)
			{
				this.method_59();
			}
		}

		private void toolStripButton_124_Click(object sender, EventArgs e)
		{
			this.method_58();
		}

		private void dataGridViewExcelFilter_6_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_58();
		}

		private void method_58()
		{
			int idObj = 0;
			int num = 0;
			if (this.dataGridViewExcelFilter_6.SelectedRows != null && this.dataGridViewExcelFilter_6.RowCount > 0 && int.TryParse(this.dataGridViewExcelFilter_6.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_109.Name].Value.ToString(), out num) && int.TryParse(this.dataGridViewExcelFilter_6.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_111.Name].Value.ToString(), out idObj) && new FormAddEditValuePassportChars(this.SqlSettings, (num == -1) ? 0 : 1, idObj, num).ShowDialog() == DialogResult.OK)
			{
				this.method_59();
			}
		}

		private void toolStripButton_125_Click(object sender, EventArgs e)
		{
			int num = 0;
			if (this.dataGridViewExcelFilter_6.SelectedRows != null && this.dataGridViewExcelFilter_6.RowCount > 0 && int.TryParse(this.dataGridViewExcelFilter_6.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_109.Name].Value.ToString(), out num) && MessageBox.Show("Вы действительно хотите удалить паспорт?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK && num > 0)
			{
				base.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where id = {0}", num), null, true, 0);
				this.class107_0.tP_Passport.Rows[0]["Deleted"] = true;
				this.class107_0.tP_Passport.Rows[0]["IsActive"] = false;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_Passport);
				this.method_59();
			}
		}

		private void toolStripButton_126_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_6.SelectedRows != null && this.dataGridViewExcelFilter_6.SelectedRows.Count > 0)
			{
				new Class5(this.SqlSettings, (int)this.dataGridViewExcelFilter_6.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_111.Name].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_127_Click(object sender, EventArgs e)
		{
			this.method_59();
		}

		private void method_59()
		{
			BackgroundWorkerParams backgroundWorkerParams = default(BackgroundWorkerParams);
			if (this.dgvSwitchgears.CurrentRow != null && int.TryParse(this.dgvSwitchgears.CurrentRow.Cells[this.dataGridViewTextBoxColumn_133.Name].Value.ToString(), out backgroundWorkerParams.Id))
			{
				this.method_70(backgroundWorkerParams.Id);
			}
		}

		private void method_60(DataGridView dataGridView_17, string string_1, string[] string_2)
		{
			base.SelectSqlData(this.class107_0.vPassportShowEquipmentData, true, string_1, null, false, 0);
			DataTable inversedDataTable = PivotTable.GetInversedDataTable(this.class107_0.vPassportShowEquipmentData, this.class107_0.vPassportShowEquipmentData.DataColumn_6, this.class107_0.vPassportShowEquipmentData.DataColumn_0, this.class107_0.vPassportShowEquipmentData.idObjListColumn, this.class107_0.vPassportShowEquipmentData.DataColumn_1, this.class107_0.vPassportShowEquipmentData.DataColumn_7, "", false);
			dataGridView_17.DataSource = inversedDataTable;
			foreach (object obj in dataGridView_17.Columns)
			{
				DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
				if (dataGridViewColumn.HeaderText == "Наименование")
				{
					dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					dataGridViewColumn.MinimumWidth = 90;
					break;
				}
				foreach (string b in string_2)
				{
					if (dataGridViewColumn.Name == b)
					{
						dataGridViewColumn.Visible = false;
						break;
					}
				}
			}
		}

		private void backgroundWorker_6_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorkerParams param = (BackgroundWorkerParams)e.Argument;
			if (this.dgvTrans.InvokeRequired)
			{
				Dispatcher.Invoke(this, delegate()
				{
					this.method_61(param.ParentId);
				});
				return;
			}
			this.method_61(param.ParentId);
		}

		private void method_61(int int_3)
		{
			string text = this.method_65(int_3);
			string text2 = string.Format("WHERE ol.TypeCodeId = {0} and ol.deleted = '0'\r\n", 603);
			if (string.IsNullOrEmpty(text))
			{
				text2 = text2 + "AND ol.idParentAddl = " + int_3.ToString();
			}
			else
			{
				text2 += string.Format("and (ol.idParentAddl = '{0}' or ol.idParent in ({1}))", int_3, text);
			}
			this.dgvTransV.DataSource = PassportData.GetEquipmentData(this.SqlSettings, 603, text2, false);
		}

		private void backgroundWorker_2_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorkerParams param = (BackgroundWorkerParams)e.Argument;
			if (this.dgvTrans.InvokeRequired)
			{
				Dispatcher.Invoke(this, delegate()
				{
					this.method_62(param.ParentId);
				});
				return;
			}
			this.method_62(param.ParentId);
		}

		private void method_62(int int_3)
		{
			string text = this.method_65(int_3);
			string text2 = string.Format("WHERE ol.TypeCodeId = {0} AND ol.deleted = '0'\r\n", 556);
			if (string.IsNullOrEmpty(text))
			{
				text2 = text2 + "AND ol.idParentAddl = " + int_3.ToString();
			}
			else
			{
				text2 += string.Format("and (ol.idParentAddl = '{0}' or ol.idParent in ({1}))", int_3, text);
			}
			this.dgvTrans.DataSource = PassportData.GetEquipmentData(this.SqlSettings, 556, text2, false);
		}

		private void method_63(object sender, DoWorkEventArgs e)
		{
			BackgroundWorkerParams param = (BackgroundWorkerParams)e.Argument;
			if (this.dgvTrans.InvokeRequired)
			{
				Dispatcher.Invoke(this, delegate()
				{
					this.method_64(param.ParentId);
				});
				return;
			}
			this.method_64(param.ParentId);
		}

		private void method_64(int int_3)
		{
			string text = this.method_65(int_3);
			string text2 = string.Format("WHERE ol.TypeCodeId = {0} AND ol.deleted = '0'\r\n", 976);
			if (string.IsNullOrEmpty(text))
			{
				text2 = text2 + "AND ol.idParentAddl = " + int_3.ToString();
			}
			else
			{
				text2 += string.Format("and (ol.idParentAddl = '{0}' or ol.idParent in ({1}))", int_3, text);
			}
			this.dgvTransI.DataSource = PassportData.GetEquipmentData(this.SqlSettings, 976, text2, false);
		}

		private string method_65(int int_3)
		{
			string result;
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					result = Convert.ToString(new SqlCommand("select stuff((select ', ' + cast(r.id as nvarchar(max))\r\nfrom tSchm_Relation as r left join\r\ntSchm_ObjList as ol on r.Edge = ol.Id left join\r\ntR_Classifier as c_ol on c_ol.Id = ol.TypeCodeId\r\nand c_ol.Deleted = '0' and c_ol.IsGroup = '0' and c_ol.ParentKey like ';SCM;Cell;%'\r\nwhere ol.IdParent = " + int_3.ToString() + " and ol.Deleted = '0'\r\nfor xml path('')), 1, 1, '') as idList", sqlConnection)
					{
						CommandType = CommandType.Text
					}.ExecuteScalar());
				}
				catch
				{
					result = string.Empty;
				}
				finally
				{
					sqlConnection.Close();
				}
			}
			return result;
		}

		private void LstNnlIwat_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorkerParams param = (BackgroundWorkerParams)e.Argument;
			if (this.dgvSwitchgears.InvokeRequired)
			{
				Dispatcher.Invoke(this, delegate()
				{
					this.method_66(param.ParentId);
				});
				return;
			}
			this.method_66(param.ParentId);
		}

		private void method_66(int int_3)
		{
			string where = string.Format("WHERE ol.idParent = {0} AND c_ol.ParentKey = ';SCM;SwGear;' AND ol.Deleted = ((0))", int_3);
			this.dgvSwitchgears.DataSource = PassportData.GetEquipmentData(this.SqlSettings, 761, where, false);
		}

		private void backgroundWorker_3_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorkerParams param = (BackgroundWorkerParams)e.Argument;
			if (this.dgvBuses.InvokeRequired)
			{
				Dispatcher.Invoke(this, delegate()
				{
					this.method_67(param.ParentId);
				});
				return;
			}
			this.method_67(param.ParentId);
		}

		private void method_67(int int_3)
		{
			string where = string.Format("WHERE ol.idParentAddl = {0} AND c_ol.ParentKey LIKE ';SCM;BUS;%' AND ol.Deleted = ((0))", int_3);
			this.dgvBuses.DataSource = PassportData.GetEquipmentData(this.SqlSettings, 540, where, true);
		}

		private void backgroundWorker_4_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorkerParams param = (BackgroundWorkerParams)e.Argument;
			if (this.dgvCells.InvokeRequired)
			{
				Dispatcher.Invoke(this, delegate()
				{
					this.method_68(param.ParentId);
				});
				return;
			}
			this.method_68(param.ParentId);
		}

		private void method_68(int int_3)
		{
			string where = string.Format("LEFT JOIN dbo.vP_BusCells AS sw ON ol.id = sw.Id WHERE sw.idSwitchGear = {0}", int_3);
			this.dgvCells.DataSource = PassportData.GetEquipmentData(this.SqlSettings, 678, ", ParentFullName AS Шина", ", sw.ParentName, sw.ParentFullName", where, "ORDER BY ParentName, ParentFullName", true);
		}

		private void backgroundWorker_5_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorkerParams param = (BackgroundWorkerParams)e.Argument;
			if (this.dgvSwitches.InvokeRequired)
			{
				Dispatcher.Invoke(this, delegate()
				{
					this.method_69(param.ParentId);
				});
				return;
			}
			this.method_69(param.ParentId);
		}

		private void method_69(int int_3)
		{
			string where = string.Format("LEFT JOIN dbo.vP_CellSwitches AS sw ON ol.id = sw.Id WHERE sw.busIdParentAddl = {0}", int_3);
			this.dgvSwitches.DataSource = PassportData.GetEquipmentData(this.SqlSettings, 552, ", ParentFullName AS Ячейка", ", sw.ParentName, sw.ParentFullName", where, "ORDER BY ParentName, ParentFullName", true);
		}

		private void backgroundWorker_8_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorkerParams param = (BackgroundWorkerParams)e.Argument;
			if (this.dataGridViewExcelFilter_6.InvokeRequired)
			{
				Dispatcher.Invoke(this, delegate()
				{
					this.method_70(param.ParentId);
				});
				return;
			}
			this.method_70(param.ParentId);
		}

		private void method_70(int int_3)
		{
			string where = string.Format("LEFT JOIN dbo.vP_CellProtector AS sw ON ol.id = sw.Id WHERE sw.busIdParentAddl = {0}", int_3);
			this.dataGridViewExcelFilter_6.DataSource = PassportData.GetEquipmentData(this.SqlSettings, Convert.ToInt32(903), ", ParentFullName AS Ячейка", ", sw.ParentName, sw.ParentFullName", where, "ORDER BY ParentName, ParentFullName", true);
		}

		private void toolStripButton_45_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				if (!Clutch.FindEndClutches(this.SqlSettings, this.objList_0.Id) && MessageBox.Show("Отсутствует необходимое количество концевых муфт.\r\nЖелаете продолжить и добавить концевую муфту?", "Концевые муфты", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
				{
					return;
				}
				Form3 form = new Form3(this.SqlSettings, this.objList_0.Id, 0);
				if (form.ShowDialog() == DialogResult.OK)
				{
					this.method_72(form.Id);
				}
			}
		}

		private void toolStripButton_46_Click(object sender, EventArgs e)
		{
			this.method_71();
		}

		private void toolStripMenuItem_50_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			DataGridView dataGridView = null;
			if (toolStripMenuItem.Tag == null)
			{
				return;
			}
			int num = Convert.ToInt32(toolStripMenuItem.Tag);
			string arg = string.Empty;
			switch (num)
			{
			case 1:
				arg = "муфту";
				dataGridView = this.dataGridViewExcelFilter_7;
				break;
			case 2:
				arg = "паспорт муфты";
				dataGridView = this.dataGridViewExcelFilter_7;
				break;
			case 3:
				arg = "концевую разделку";
				dataGridView = this.dataGridViewExcelFilter_2;
				break;
			case 4:
				arg = "пасспорт концевой разделки";
				dataGridView = this.dataGridViewExcelFilter_2;
				break;
			}
			if (dataGridView == null)
			{
				return;
			}
			if (this.dataGridViewExcelFilter_7.SelectedRows != null && dataGridView.SelectedRows.Count > 0 && MessageBox.Show(string.Format("Вы действительно хотите удалить {0}?", arg), "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				switch (num)
				{
				case 1:
				case 3:
					Clutch.Delete(this.SqlSettings, (int)dataGridView.SelectedRows[0].Cells["IdObjList"].Value);
					break;
				case 2:
				case 4:
					Clutch.DeletePassport(this.SqlSettings, (int)dataGridView.SelectedRows[0].Cells["Id"].Value);
					break;
				}
				switch (num)
				{
				case 1:
				case 2:
					this.method_73();
					return;
				case 3:
				case 4:
					this.method_81();
					break;
				default:
					return;
				}
			}
		}

		private void toolStripButton_47_Click(object sender, EventArgs e)
		{
			this.method_73();
		}

		private void toolStripButton_86_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_7.SelectedRows != null && this.dataGridViewExcelFilter_7.SelectedRows.Count > 0)
			{
				new Class5(this.SqlSettings, (int)this.dataGridViewExcelFilter_7.SelectedRows[0].Cells["IdObjList"].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_106_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_7.CurrentRow != null && new FormTransfRename(this.SqlSettings, (int)this.dataGridViewExcelFilter_7.SelectedRows[0].Cells["IdObjList"].Value).ShowDialog() == DialogResult.OK)
			{
				this.method_77();
				this.method_73();
			}
		}

		private void method_71()
		{
			if (this.dataGridViewExcelFilter_7.SelectedRows != null && this.dataGridViewExcelFilter_7.SelectedRows.Count > 0)
			{
				Form3 form = new Form3(this.SqlSettings, (int)this.dataGridViewExcelFilter_7.SelectedRows[0].Cells["IdObjList"].Value, 1);
				form.method_3(TypeClutch.Connective);
				if (form.ShowDialog() == DialogResult.OK)
				{
					this.method_73();
				}
			}
		}

		public void ChangeTabPageClutches(TypeClutch value)
		{
			if (value == TypeClutch.Connective)
			{
				this.tabControl_3.SelectedTab = this.dykcUlJvZe;
				return;
			}
			if (value != TypeClutch.End)
			{
				return;
			}
			this.tabControl_3.SelectedTab = this.tabPage_14;
		}

		private void method_72(int int_3)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				while (this.backgroundWorker_1.IsBusy)
				{
				}
				BackgroundWorkerParams backgroundWorkerParams = default(BackgroundWorkerParams);
				backgroundWorkerParams.ParentId = this.objList_0.Id;
				backgroundWorkerParams.Id = int_3;
				this.backgroundWorker_1.RunWorkerAsync(backgroundWorkerParams);
			}
		}

		private void method_73()
		{
			if (this.treeView_0.SelectedNode != null)
			{
				int int_ = (this.dataGridViewExcelFilter_7.SelectedRows == null || this.dataGridViewExcelFilter_7.SelectedRows.Count <= 0) ? -1 : ((int)this.dataGridViewExcelFilter_7.SelectedRows[0].Cells["IdObjList"].Value);
				this.method_72(int_);
			}
		}

		private void dataGridViewExcelFilter_7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_71();
		}

		private void backgroundWorker_1_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorkerParams param = (BackgroundWorkerParams)e.Argument;
			if (this.dataGridViewExcelFilter_7.InvokeRequired)
			{
				this.dataGridViewExcelFilter_7.Invoke(new MethodInvoker(delegate()
				{
					this.method_74(e, param);
				}));
				return;
			}
			this.method_74(e, param);
		}

		private void method_74(DoWorkEventArgs doWorkEventArgs_0, BackgroundWorkerParams backgroundWorkerParams_0)
		{
			DataTable data = Clutch.GetData(this.SqlSettings, backgroundWorkerParams_0.ParentId, TypeObjList.ClutchConnecting, false);
			if (!doWorkEventArgs_0.Cancel)
			{
				this.dataGridViewExcelFilter_7.DataSource = data;
				if (this.dataGridViewExcelFilter_7.ColumnCount != 0)
				{
					if (this.dataGridViewExcelFilter_7.Columns.Contains("Id"))
					{
						this.dataGridViewExcelFilter_7.Columns["Id"].Visible = false;
					}
					if (this.dataGridViewExcelFilter_7.Columns.Contains("IdEquipment"))
					{
						this.dataGridViewExcelFilter_7.Columns["IdEquipment"].Visible = false;
					}
					if (this.dataGridViewExcelFilter_7.Columns.Contains("IdObjList"))
					{
						this.dataGridViewExcelFilter_7.Columns["IdObjList"].Visible = false;
					}
					if (this.dataGridViewExcelFilter_7.Columns.Contains("Name"))
					{
						this.dataGridViewExcelFilter_7.Columns["Name"].HeaderText = "Наименование";
					}
				}
				if (backgroundWorkerParams_0.Id != -1)
				{
					this.method_83(this.dataGridViewExcelFilter_7, "IdObjList", backgroundWorkerParams_0.Id);
				}
			}
		}

		private void dataGridViewExcelFilter_7_SelectionChanged(object sender, EventArgs e)
		{
		}

		private void tabControl_3_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.tabControl_3.SelectedTab == this.dykcUlJvZe)
			{
				this.method_73();
			}
			if (this.tabControl_3.SelectedTab == this.tabPage_14)
			{
				this.method_81();
			}
		}

		private void dataGridViewExcelFilter_7_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
		{
			if (e.ColumnIndex == -1 && e.RowIndex == -1)
			{
				this.dataGridViewExcelFilter_7.ContextMenuStrip = null;
				return;
			}
			this.dataGridViewExcelFilter_7.ContextMenuStrip = this.contextMenuStrip_4;
		}

		private void toolStripButton_41_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				FormAddEditCabSections formAddEditCabSections = new FormAddEditCabSections(this.SqlSettings, this.objList_0.Id);
				if (formAddEditCabSections.ShowDialog() == DialogResult.OK)
				{
					this.method_76(formAddEditCabSections.IdCabSection);
					this.method_73();
				}
			}
		}

		private void toolStripButton_42_Click(object sender, EventArgs e)
		{
			this.method_75();
		}

		private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_75();
		}

		private void method_75()
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0 && new FormAddEditCabSections(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["SectionId"].Value, this.objList_0.Id, 1).ShowDialog() == DialogResult.OK)
			{
				this.method_77();
				this.method_73();
			}
		}

		private void toolStripMenuItem_32_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				FormAddClutchInCabSection formAddClutchInCabSection = new FormAddClutchInCabSection(this.SqlSettings, this.objList_0.Id, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["SectionId"].Value, true);
				if (formAddClutchInCabSection.ShowDialog() == DialogResult.OK)
				{
					this.method_76(formAddClutchInCabSection.IdCabSection);
					this.method_73();
				}
			}
		}

		private void toolStripMenuItem_33_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				FormAddSectionInCabSection formAddSectionInCabSection = new FormAddSectionInCabSection(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["SectionId"].Value, this.objList_0.Id);
				if (formAddSectionInCabSection.ShowDialog() == DialogResult.OK)
				{
					this.method_76(formAddSectionInCabSection.IdCabSection);
					this.method_73();
				}
			}
		}

		private void toolStripButton_43_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				Class317.smethod_10(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["SectionId"].Value);
				this.method_77();
			}
		}

		private void toolStripButton_44_Click(object sender, EventArgs e)
		{
			this.method_77();
		}

		private void toolStripMenuItem_57_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				new Form5
				{
					SqlSettings = this.SqlSettings,
					IdObjList = this.objList_0.Id,
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_85_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.SelectedRows != null && this.dataGridViewExcelFilter_0.SelectedRows.Count > 0)
			{
				new Class5(this.SqlSettings, (int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["SectionId"].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void method_76(int int_3)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				while (this.backgroundWorker_0.IsBusy)
				{
				}
				BackgroundWorkerParams backgroundWorkerParams = default(BackgroundWorkerParams);
				backgroundWorkerParams.ParentId = this.objList_0.Id;
				backgroundWorkerParams.Id = int_3;
				this.backgroundWorker_0.RunWorkerAsync(backgroundWorkerParams);
			}
		}

		private void method_77()
		{
			if (this.treeView_0.SelectedNode != null)
			{
				int int_ = (this.dataGridViewExcelFilter_0.SelectedRows == null || this.dataGridViewExcelFilter_0.SelectedRows.Count <= 0) ? -1 : ((int)this.dataGridViewExcelFilter_0.SelectedRows[0].Cells["SectionId"].Value);
				this.method_76(int_);
			}
		}

		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorkerParams param = (BackgroundWorkerParams)e.Argument;
			if (this.dataGridViewExcelFilter_0.InvokeRequired)
			{
				Dispatcher.Invoke(this, delegate()
				{
					this.method_78(e, param);
				});
				return;
			}
			this.method_78(e, param);
		}

		private void method_78(DoWorkEventArgs doWorkEventArgs_0, BackgroundWorkerParams backgroundWorkerParams_0)
		{
			DataTable dataSource = Class317.smethod_0(this.SqlSettings, backgroundWorkerParams_0.ParentId);
			if (!doWorkEventArgs_0.Cancel)
			{
				this.dataGridViewExcelFilter_0.DataSource = dataSource;
				if (backgroundWorkerParams_0.Id != -1)
				{
					this.method_83(this.dataGridViewExcelFilter_0, "SectionId", backgroundWorkerParams_0.Id);
				}
				decimal d = 0m;
				foreach (object obj in ((IEnumerable)this.dataGridViewExcelFilter_0.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					decimal d2 = 0m;
					if (decimal.TryParse(dataGridViewRow.Cells["SectionLength"].Value.ToString(), out d2))
					{
						d += d2;
					}
				}
				this.toolStripLabel_5.Text = d.ToString() + " м.";
			}
		}

		private void dataGridViewExcelFilter_0_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex == -1)
			{
				this.dataGridViewExcelFilter_0.ContextMenuStrip = null;
				return;
			}
			this.dataGridViewExcelFilter_0.ContextMenuStrip = this.contextMenuStrip_5;
		}

		private void toolStripButton_81_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_2.Rows.Count < 2 && this.objList_0 != null)
			{
				Form3 form = new Form3(this.SqlSettings, this.objList_0.Id, 0);
				form.method_3(TypeClutch.End);
				if (form != null && form.ShowDialog() == DialogResult.OK)
				{
					this.method_80(form.Id);
				}
			}
		}

		private void toolStripButton_82_Click(object sender, EventArgs e)
		{
			this.method_79();
		}

		private void toolStripButton_83_Click(object sender, EventArgs e)
		{
			this.method_81();
		}

		private void method_79()
		{
			if (this.dataGridViewExcelFilter_2.SelectedRows != null && this.dataGridViewExcelFilter_2.SelectedRows.Count > 0 && new FormAddEditValuePassportChars(this.SqlSettings, 1, (int)this.dataGridViewExcelFilter_2.SelectedRows[0].Cells["IdObjList"].Value, (int)this.dataGridViewExcelFilter_2.SelectedRows[0].Cells["Id"].Value).ShowDialog() == DialogResult.OK)
			{
				this.method_81();
			}
		}

		private void method_80(int int_3)
		{
			if (this.objList_0 != null)
			{
				this.dataGridViewExcelFilter_2.DataSource = Clutch.GetData(this.SqlSettings, this.objList_0.Id, TypeObjList.ClutchEnd, false);
				if (this.dataGridViewExcelFilter_2.ColumnCount != 0)
				{
					if (this.dataGridViewExcelFilter_2.Columns.Contains("Id"))
					{
						this.dataGridViewExcelFilter_2.Columns["Id"].Visible = false;
					}
					if (this.dataGridViewExcelFilter_2.Columns.Contains("IdEquipment"))
					{
						this.dataGridViewExcelFilter_2.Columns["IdEquipment"].Visible = false;
					}
					if (this.dataGridViewExcelFilter_2.Columns.Contains("IdObjList"))
					{
						this.dataGridViewExcelFilter_2.Columns["IdObjList"].Visible = false;
					}
					if (this.dataGridViewExcelFilter_2.Columns.Contains("Name"))
					{
						this.dataGridViewExcelFilter_2.Columns["Name"].HeaderText = "Наименование";
					}
				}
				this.method_82(this.dataGridViewExcelFilter_2, "IdObjList", int_3, -1);
			}
		}

		private void method_81()
		{
			if (this.dataGridViewExcelFilter_2.SelectedRows != null && this.dataGridViewExcelFilter_2.SelectedRows.Count > 0)
			{
				int int_ = (int)this.dataGridViewExcelFilter_2.SelectedRows[0].Cells["Id"].Value;
				this.method_80(int_);
				return;
			}
			this.dataGridViewExcelFilter_2.DataSource = Clutch.GetData(this.SqlSettings, this.objList_0.Id, TypeObjList.ClutchEnd, false);
			if (this.dataGridViewExcelFilter_2.ColumnCount != 0)
			{
				if (this.dataGridViewExcelFilter_2.Columns.Contains("Id"))
				{
					this.dataGridViewExcelFilter_2.Columns["Id"].Visible = false;
				}
				if (this.dataGridViewExcelFilter_2.Columns.Contains("IdEquipment"))
				{
					this.dataGridViewExcelFilter_2.Columns["IdEquipment"].Visible = false;
				}
				if (this.dataGridViewExcelFilter_2.Columns.Contains("IdObjList"))
				{
					this.dataGridViewExcelFilter_2.Columns["IdObjList"].Visible = false;
				}
				if (this.dataGridViewExcelFilter_2.Columns.Contains("Name"))
				{
					this.dataGridViewExcelFilter_2.Columns["Name"].HeaderText = "Наименование";
				}
			}
		}

		private void dataGridViewExcelFilter_2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_79();
		}

		private void method_82(DataGridView dataGridView_17, string string_1, int int_3, int int_4)
		{
			foreach (object obj in ((IEnumerable)dataGridView_17.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if ((int)dataGridViewRow.Cells[string_1].Value == int_3)
				{
					dataGridView_17.FirstDisplayedScrollingRowIndex = ((int_4 == -1) ? dataGridViewRow.Index : int_4);
					dataGridViewRow.Selected = true;
					break;
				}
			}
		}

		private void dataGridViewExcelFilter_2_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex == -1)
			{
				this.dataGridViewExcelFilter_2.ContextMenuStrip = null;
				return;
			}
			this.dataGridViewExcelFilter_2.ContextMenuStrip = this.contextMenuStrip_10;
		}

		private void toolStripButton_88_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_2.SelectedRows != null && this.dataGridViewExcelFilter_2.SelectedRows.Count > 0)
			{
				new Class5(this.SqlSettings, (int)this.dataGridViewExcelFilter_2.SelectedRows[0].Cells["IdObjList"].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void method_83(DataGridView dataGridView_17, string string_1, int int_3)
		{
			foreach (object obj in ((IEnumerable)dataGridView_17.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if ((int)dataGridViewRow.Cells[string_1].Value == int_3)
				{
					dataGridView_17.FirstDisplayedScrollingRowIndex = dataGridViewRow.Index;
					dataGridViewRow.Selected = true;
					break;
				}
			}
		}

		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
		}

		private void toolStripButton_107_Click(object sender, EventArgs e)
		{
			this.method_88(-1);
		}

		private void toolStripButton_108_Click(object sender, EventArgs e)
		{
			this.method_89();
		}

		private void toolStripMenuItem_53_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_9.SelectedRows != null && this.dataGridViewExcelFilter_9.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tSchm_ObjList, true, "WHERE id = " + this.dataGridViewExcelFilter_9.SelectedRows[0].Cells["idObjListColumn"].Value.ToString());
				if (this.class107_0.tSchm_ObjList.Rows.Count > 0)
				{
					this.class107_0.tSchm_ObjList.Rows[0]["Deleted"] = true;
					base.UpdateSqlData(this.class107_0, this.class107_0.tSchm_ObjList);
					this.method_85(this.objList_0.Id);
				}
			}
		}

		private void toolStripButton_110_Click(object sender, EventArgs e)
		{
			this.method_85(this.objList_0.Id);
		}

		private void method_84(int int_3, int int_4)
		{
			this.method_85(int_3);
			foreach (object obj in ((IEnumerable)this.dataGridViewExcelFilter_8.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if ((int)dataGridViewRow.Cells["idObjListPole"].Value == int_4)
				{
					dataGridViewRow.Selected = true;
					this.dataGridViewExcelFilter_8.FirstDisplayedScrollingRowIndex = dataGridViewRow.Index;
				}
			}
		}

		private void method_85(int int_3)
		{
			string text = this.method_86(int_3);
			if (string.IsNullOrEmpty(text))
			{
				text = "''";
			}
			int typeCodeId = ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;INLINE_OBJ;OTHER_OBJ;", 2m);
			int typeCodeId2 = ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;INLINE_OBJ;OTHER_OBJ;", 1m);
			int typeCodeId3 = ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;INLINE_OBJ;SWITCH;", 8m);
			int typeCodeId4 = ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;INLINE_OBJ;SWITCH;", 14m);
			DataTable dataTable = new DataTable();
			DataTable dataTable_ = new DataTable();
			dataTable = PassportData.GetEquipmentData(this.SqlSettings, typeCodeId, ",typeCode, Pylon ", ",c_ol.Name as typeCode, pole.Name as Pylon ", string.Format("left join tSchm_ObjList as pole on pole.id = ol.idParentAddl\r\nWHERE ol.idParentAddl in ({0}) AND ol.TypeCodeId = {1}", text, typeCodeId), "", false);
			dataTable_ = PassportData.GetEquipmentData(this.SqlSettings, typeCodeId2, ",typeCode, Pylon ", ",c_ol.Name as typeCode, pole.Name as Pylon ", string.Format("left join tSchm_ObjList as pole on pole.id = ol.idParentAddl\r\nWHERE ol.idParentAddl in ({0}) AND ol.TypeCodeId = {1}", text, typeCodeId2), "", false);
			this.method_87(dataTable, dataTable_);
			dataTable_ = PassportData.GetEquipmentData(this.SqlSettings, typeCodeId3, ",typeCode, Pylon ", ",c_ol.Name as typeCode, pole.Name as Pylon ", string.Format("left join tSchm_ObjList as pole on pole.id = ol.idParentAddl\r\nWHERE ol.idParentAddl in ({0}) AND ol.TypeCodeId = {1}", text, typeCodeId3), "", false);
			this.method_87(dataTable, dataTable_);
			dataTable_ = PassportData.GetEquipmentData(this.SqlSettings, typeCodeId4, ",typeCode, Pylon ", ",c_ol.Name as typeCode, pole.Name as Pylon ", string.Format("left join tSchm_ObjList as pole on pole.id = ol.idParentAddl\r\nWHERE ol.idParentAddl in ({0}) AND ol.TypeCodeId = {1}", text, typeCodeId4), "", false);
			this.method_87(dataTable, dataTable_);
			this.dataGridViewExcelFilter_9.DataSource = dataTable;
		}

		private string method_86(int int_3)
		{
			string text = string.Format("select stuff((select ',' + cast(id as nvarchar(max))\r\nfrom tSchm_ObjList\r\nwhere id in (select idClutchFirst as idPole\r\n            from tP_CabSection\r\n            where Deleted = '0' and idObjList = '{0}'\r\n            union\r\n            select idClutchSecond as idPole\r\n            from tP_CabSection\r\n            where Deleted = '0' and idObjList = '{0}') or\r\n(IdParent = '{0}' and Deleted = '0'\r\nand TypeCodeId in (select id from tR_Classifier \r\n                    where ParentKey = ';SCM;Pole;' and Deleted = '0' and IsGroup = '0'))\r\nfor xml path('')),1,1,'') as idObjLst", int_3);
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			if (dataTable.Rows.Count > 0)
			{
				return Convert.ToString(dataTable.Rows[0]["idObjLst"]);
			}
			return string.Empty;
		}

		private void method_87(DataTable dataTable_1, DataTable dataTable_2)
		{
			foreach (object obj in dataTable_2.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj;
				if (!dataTable_1.Columns.Contains(dataColumn.ColumnName))
				{
					dataTable_1.Columns.Add(new DataColumn(dataColumn.ColumnName, dataColumn.DataType));
				}
			}
			foreach (object obj2 in dataTable_2.Rows)
			{
				DataRow dataRow = (DataRow)obj2;
				DataRow dataRow2 = dataTable_1.NewRow();
				foreach (object obj3 in dataTable_2.Columns)
				{
					DataColumn dataColumn2 = (DataColumn)obj3;
					dataRow2[dataColumn2.ColumnName] = dataRow[dataColumn2.ColumnName];
				}
				dataTable_1.Rows.Add(dataRow2);
			}
		}

		private void method_88(int int_3 = -1)
		{
			if (this.objList_0 == null)
			{
				return;
			}
			Form9 form = new Form9(this.objList_0.Id, -1, int_3);
			form.SqlSettings = this.SqlSettings;
			form.method_1(0);
			form.MdiParent = base.MdiParent;
			form.FormClosed += this.method_90;
			form.Show();
		}

		private void method_89()
		{
			if (this.dataGridViewExcelFilter_9.SelectedRows != null && this.dataGridViewExcelFilter_9.SelectedRows.Count > 0)
			{
				int int_ = (int)this.dataGridViewExcelFilter_9.SelectedRows[0].Cells["idObjListColumn"].Value;
				Form9 form = new Form9(this.objList_0.Id, int_, -1);
				form.SqlSettings = this.SqlSettings;
				form.method_1(1);
				form.FormClosed += this.method_90;
				form.MdiParent = base.MdiParent;
				form.Show();
			}
		}

		private void method_90(object sender, FormClosedEventArgs e)
		{
			if (((Form9)sender).DialogResult == DialogResult.OK)
			{
				this.method_85(this.objList_0.Id);
				this.method_97(this.objList_0.Id);
			}
		}

		private void dataGridViewExcelFilter_9_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_89();
		}

		private void dataGridViewExcelFilter_9_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex == -1)
			{
				this.dataGridViewExcelFilter_9.ContextMenuStrip = null;
				return;
			}
			this.dataGridViewExcelFilter_9.ContextMenuStrip = this.contextMenuStrip_13;
		}

		private void method_91(object sender, EventArgs e)
		{
			this.method_88(-1);
		}

		private void method_92(object sender, EventArgs e)
		{
			this.method_89();
		}

		private void method_93(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_9.SelectedRows != null && this.dataGridViewExcelFilter_9.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tSchm_ObjList, true, "WHERE id = " + this.dataGridViewExcelFilter_9.SelectedRows[0].Cells["idObjListColumn"].Value.ToString());
				if (this.class107_0.tSchm_ObjList.Rows.Count > 0)
				{
					this.class107_0.tSchm_ObjList.Rows[0]["Deleted"] = true;
					base.UpdateSqlData(this.class107_0, this.class107_0.tSchm_ObjList);
					this.method_85(this.objList_0.Id);
				}
			}
		}

		private void method_94(object sender, EventArgs e)
		{
			this.method_85(this.objList_0.Id);
		}

		private void toolStripButton_75_Click(object sender, EventArgs e)
		{
			if (this.objList_0 != null)
			{
				Form13 form = new Form13();
				form.SqlSettings = this.SqlSettings;
				form.method_3(this.objList_0.Id);
				form.method_7(0);
				form.FormClosed += this.method_95;
				form.MdiParent = base.MdiParent;
				form.Show();
			}
		}

		private void toolStripButton_76_Click(object sender, EventArgs e)
		{
			this.method_98();
		}

		private void toolStripButton_77_Click(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable("tP_CabSection");
			base.SelectSqlData(dataTable, true, string.Format("where ([idClutchFirst] = '{0}' or [idClutchSecond] = '{0}') and deleted = '0'", (int)this.dataGridViewExcelFilter_8.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_181.Name].Value), null, false, 0);
			if (dataTable.Rows.Count > 0)
			{
				string text = string.Empty;
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					text = text + "," + dataRow["idObjList"].ToString();
				}
				text = text.Remove(0, 1);
				DataTable dataTable2 = new DataTable("vSchm_ObjList");
				base.SelectSqlData(dataTable2, true, string.Format("where id in ({0})", text), null, false, 0);
				string text2 = string.Empty;
				foreach (object obj2 in dataTable2.Rows)
				{
					DataRow dataRow2 = (DataRow)obj2;
					text2 = string.Concat(new string[]
					{
						text2,
						", ",
						dataRow2["typeCodeSocr"].ToString(),
						"-",
						dataRow2["Name"].ToString()
					});
				}
				text2 = text2.Remove(0, 2);
				MessageBox.Show("Невозможно удалить опору, так как она привязана к пролету на линиях: " + text2, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (this.dataGridViewExcelFilter_8.SelectedRows != null && this.dataGridViewExcelFilter_8.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tSchm_ObjList, true, "WHERE id = " + this.dataGridViewExcelFilter_8.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_181.Name].Value.ToString());
				if (this.class107_0.tSchm_ObjList.Rows.Count > 0)
				{
					this.class107_0.tSchm_ObjList.Rows[0]["Deleted"] = true;
					base.UpdateSqlData(this.class107_0, this.class107_0.tSchm_ObjList);
					this.method_97(this.objList_0.Id);
				}
			}
		}

		private void toolStripButton_128_Click(object sender, EventArgs e)
		{
			this.method_99();
		}

		private void GoscVscjdc_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_8.SelectedRows != null && this.dataGridViewExcelFilter_8.SelectedRows.Count > 0)
			{
				this.method_96(this.objList_0.Id, (int)this.dataGridViewExcelFilter_8.SelectedRows[0].Cells["idObjListPole"].Value);
				return;
			}
			this.method_97(this.objList_0.Id);
		}

		private void toolStripButton_84_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_8.SelectedRows != null && this.dataGridViewExcelFilter_8.SelectedRows.Count > 0)
			{
				new Class5(this.SqlSettings, (int)this.dataGridViewExcelFilter_8.SelectedRows[0].Cells["idObjListPole"].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void dataGridViewExcelFilter_8_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				return;
			}
			this.method_98();
		}

		private void dataGridViewExcelFilter_8_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				this.dataGridViewExcelFilter_8.ContextMenuStrip = null;
				return;
			}
			this.dataGridViewExcelFilter_8.ContextMenuStrip = this.contextMenuStrip_8;
		}

		private void method_95(object sender, FormClosedEventArgs e)
		{
			Form13 form = (Form13)sender;
			if (form.DialogResult == DialogResult.OK)
			{
				this.method_96(this.objList_0.Id, form.method_0());
				if (form.method_4() != -1)
				{
					this.method_107(this.objList_0.Id, form.method_4());
				}
			}
		}

		private void method_96(int int_3, int int_4)
		{
			this.method_97(this.objList_0.Id);
			foreach (object obj in ((IEnumerable)this.dataGridViewExcelFilter_8.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if ((int)dataGridViewRow.Cells["idObjListPole"].Value == int_4)
				{
					dataGridViewRow.Selected = true;
					this.dataGridViewExcelFilter_8.FirstDisplayedScrollingRowIndex = dataGridViewRow.Index;
				}
			}
		}

		private void method_97(int int_3)
		{
			string where = string.Format("LEFT JOIN tP_CabSection as cs on ol.id = cs.idClutchSecond and cs.idObjList = '{0}'\r\nleft join tR_Cable as cab on cab.id = cs.idEquipment\r\nwhere (ol.idParent = '{0}' and ol.deleted = '0'\r\nand ol.typeCodeId in (select id From tR_Classifier where ParentKey = ';SCM;Pole;'\r\nand deleted = '0' and isGroup = '0'))\r\nor (ol.deleted = '0' and ol.id in (select idClutchFirst as idPylon\r\nfrom tP_CabSection where idObjList = '{0}' and deleted = '0' union\r\nselect idClutchSecond as idPylon from tP_CabSection\r\nwhere idObjList = '{0}' and deleted = '0'))", int_3);
			string selectAddl = ", typeName, SpanLength as [Длина пролета], SpanCable as [Кабель пролета], EquipmentList as [Список обор-я]";
			string selectPivotAddl = ", c_ol.Name as typeName, cs.[Length] as SpanLength,cast(cab.CableMakeup as nvarchar(max)) + ' ' + \r\ncast(cab.Wires as nvarchar(max)) + 'X' + \r\ncast(cab.CrossSection as nvarchar(max)) as SpanCable,STUFF((select ', ' + Name from tSchm_ObjList as equip\r\n" + string.Format("where equip.idParentAddl = ol.id and equip.IdParent = '{0}'\r\n", int_3) + "for xml path('')),1,2,'') as EquipmentList";
			DataTable dataTable = new DataTable();
			dataTable = PassportData.GetEquipmentData(this.SqlSettings, ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;Pole;", 1m), selectAddl, selectPivotAddl, where, "order by Name", false);
			string text = "select cb.idPole, COUNT(Distinct cb.id) as CountBranch, COUNT(br.idObj) as CountObjBranch\r\nfrom tP_CabBranches as cb join\r\ntP_BranchObjRelation as br on br.idCabBranch = cb.id\r\n" + string.Format("where cb.idPole in (select [idclutchFirst] as pylon from tP_CabSection where idObjList = '{0}' and deleted = '0'\r\nunion select [idclutchsecond] as pylon from tP_CabSection where idObjList = '{0}' and Deleted = '0')\r\n", int_3) + "group by cb.idPole";
			DataTable dataTable2 = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			dataTable.Columns.Add("countBranch", typeof(int));
			dataTable.Columns.Add("countObjBranch", typeof(int));
			foreach (object obj in dataTable2.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				DataView dataView = new DataView(dataTable);
				dataView.RowFilter = "idObjList = " + dataRow["idPole"].ToString();
				dataView[0]["countBranch"] = dataRow["countBranch"];
				dataView[0]["countObjBranch"] = dataRow["countObjBranch"];
			}
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dataTable;
			bindingSource.Sort = "Name";
			this.dataGridViewExcelFilter_8.DataSource = bindingSource;
		}

		private void method_98()
		{
			if (this.dataGridViewExcelFilter_8.SelectedRows != null && this.dataGridViewExcelFilter_8.SelectedRows.Count > 0)
			{
				Form13 form = new Form13();
				form.SqlSettings = this.SqlSettings;
				form.method_3(this.objList_0.Id);
				form.method_1((int)this.dataGridViewExcelFilter_8.SelectedRows[0].Cells["idObjListPole"].Value);
				form.method_7(1);
				form.FormClosed += this.method_95;
				form.MdiParent = base.MdiParent;
				form.Show();
			}
		}

		private void method_99()
		{
			if (this.dataGridViewExcelFilter_8.SelectedRows == null && this.dataGridViewExcelFilter_8.SelectedRows.Count == 0)
			{
				return;
			}
			Form13 form = new Form13();
			form.SqlSettings = this.SqlSettings;
			form.method_3(this.objList_0.Id);
			form.method_1((int)this.dataGridViewExcelFilter_8.SelectedRows[0].Cells["idObjListPole"].Value);
			form.method_7(11);
			form.FormClosed += this.method_95;
			form.MdiParent = base.MdiParent;
			form.Show();
		}

		private void method_100(DataTable dataTable_1)
		{
			DataView defaultView = dataTable_1.DefaultView;
			dataTable_1.Compute("len(name)", "max(len(name))");
			defaultView.RowFilter = "len(Name) = max()";
		}

		private void toolStripMenuItem_51_Click(object sender, EventArgs e)
		{
			if (this.objList_0 == null)
			{
				return;
			}
			int int_ = -1;
			if (this.dataGridViewExcelFilter_8.SelectedRows != null && this.dataGridViewExcelFilter_8.SelectedRows.Count > 0)
			{
				int_ = (int)this.dataGridViewExcelFilter_8.SelectedRows[0].Cells["idObjListPole"].Value;
			}
			this.method_88(int_);
		}

		private void dataGridViewExcelFilter_8_SelectionChanged(object sender, EventArgs e)
		{
		}

		private void toolStripButton_156_Click(object sender, EventArgs e)
		{
			this.method_101(this.objList_0.Id);
		}

		private void method_101(int int_3)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			string text = string.Format("SELECT sp.[id]\r\n      ,sp.[idObjList]\r\n      ,ol.Name\r\n      ,sp.[idPoleFirst]\r\n      ,sp.[idPoleSecond]\r\n      ,sp.[NamePoleFirst]\r\n      ,sp.[NamePoleSecond]\r\n      ,sp.[CableMakeup]\r\n      ,sp.[Voltage]\r\n  FROM [vP_Spans] as sp \r\n  inner join tSchm_ObjList as ol on sp.idObjList = ol.id\r\n  where idPoleFirst in(select [idclutchFirst] as pylon from tP_CabSection where idObjList = {0}\r\n union select [idclutchsecond] as pylon from tP_CabSection where idObjList = {0}) and idPoleSecond in(select [idclutchFirst] as pylon from tP_CabSection where idObjList = {0}\r\n union select [idclutchsecond] as pylon from tP_CabSection where idObjList = {0}) and sp.Deleted=0 and ol.Deleted=0 and idObjList <> {0}", int_3);
			DataTable dataTable = sqlDataCommand.SelectSqlData(text);
			DataTable dtJointSuspension = new DataSetReportAirLinePassport().dtJointSuspension;
			List<int> list = new List<int>();
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				if (!list.Contains((int)dataRow["id"]))
				{
					list.Add((int)dataRow["id"]);
					DataRow dataRow2 = this.method_102(dataRow, dataTable, new List<int>());
					if (dataRow2 != dataRow)
					{
						if (list.Contains((int)dataRow2["id"]))
						{
							continue;
						}
						list.Add((int)dataRow2["id"]);
					}
					DataRow dataRow3 = this.method_103(dataRow, dataTable, new List<int>());
					list.Add((int)dataRow3["id"]);
					DataSetReportAirLinePassport.dtJointSuspensionRow dtJointSuspensionRow = (DataSetReportAirLinePassport.dtJointSuspensionRow)dtJointSuspension.NewRow();
					dtJointSuspensionRow.Name = dataRow2["Name"].ToString();
					if (!dataRow2.IsNull("Voltage"))
					{
						dtJointSuspensionRow.String_0 = dataRow2["Voltage"].ToString();
					}
					dtJointSuspensionRow.PoleNum = string.Format("{0} - {1}", dataRow2["NamePoleFirst"].ToString(), dataRow3["NamePoleSecond"].ToString());
					if (!dataRow2.IsNull("CableMakeup"))
					{
						dtJointSuspensionRow.String_1 = dataRow2["CableMakeup"].ToString();
					}
					dtJointSuspension.Rows.Add(dtJointSuspensionRow);
				}
			}
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dtJointSuspension;
			this.dataGridView_14.DataSource = bindingSource;
		}

		private DataRow method_102(DataRow dataRow_0, DataTable dataTable_1, List<int> list_4)
		{
			int num = (int)dataRow_0["idPoleFirst"];
			DataRow dataRow = dataRow_0;
			if (list_4.Contains((int)dataRow["id"]))
			{
				return dataRow;
			}
			list_4.Add((int)dataRow["id"]);
			DataRow[] array = dataTable_1.Select(string.Format("idPoleSecond = {0} and idObjList={1}", num, (int)dataRow_0["idObjList"]));
			if (array.Length == 1)
			{
				dataRow = this.method_102(array[0], dataTable_1, list_4);
			}
			else if (array.Length > 1)
			{
				dataRow = this.method_102(array[0], dataTable_1, list_4);
			}
			return dataRow;
		}

		private DataRow method_103(DataRow dataRow_0, DataTable dataTable_1, List<int> list_4)
		{
			int num = (int)dataRow_0["idPoleSecond"];
			DataRow dataRow = dataRow_0;
			if (list_4.Contains((int)dataRow["id"]))
			{
				return dataRow;
			}
			list_4.Add((int)dataRow["id"]);
			DataRow[] array = dataTable_1.Select(string.Format("idPoleFirst = {0} and idObjList={1}", num, (int)dataRow_0["idObjList"]));
			if (array.Length == 1)
			{
				dataRow = this.method_103(array[0], dataTable_1, list_4);
			}
			else if (array.Length > 1)
			{
				dataRow = this.method_103(array[0], dataTable_1, list_4);
			}
			return dataRow;
		}

		private void OlEcIrCmwq_Click(object sender, EventArgs e)
		{
			if (this.objList_0 != null)
			{
				Form12 form = new Form12(this.SqlSettings, -1, this.objList_0.Id, 0);
				form.MdiParent = base.MdiParent;
				form.FormClosed += this.method_111;
				form.Show();
			}
		}

		private void toolStripButton_78_Click(object sender, EventArgs e)
		{
			this.method_104();
		}

		private void VlMgyFgckb_Click(object sender, EventArgs e)
		{
			this.method_105();
		}

		private void toolStripButton_87_Click(object sender, EventArgs e)
		{
			if (this.treeDataGridView_0.CurrentNode != null)
			{
				new Class5(this.SqlSettings, (int)this.treeDataGridView_0.CurrentNode.Cells[this.treeGridColumn_0.Name].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_79_Click(object sender, EventArgs e)
		{
			if (this.treeDataGridView_0.CurrentNode != null && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tP_CabSection, true, "WHERE id = " + this.treeDataGridView_0.CurrentNode.Cells[0].Value.ToString());
				if (this.class107_0.tP_CabSection.Rows.Count > 0)
				{
					this.class107_0.tP_CabSection.Rows[0]["Deleted"] = true;
					base.UpdateSqlData(this.class107_0, this.class107_0.tP_CabSection);
					this.method_106(this.objList_0.Id);
				}
			}
		}

		private void toolStripButton_80_Click(object sender, EventArgs e)
		{
			if (this.treeDataGridView_0.CurrentNode != null && this.treeDataGridView_0.CurrentNode.Cells[0].Value is int)
			{
				this.method_107(this.objList_0.Id, (int)this.treeDataGridView_0.CurrentNode.Cells[0].Value);
				return;
			}
			this.method_106(this.objList_0.Id);
		}

		private void toolStripMenuItem_60_Click(object sender, EventArgs e)
		{
			if (this.treeDataGridView_0.CurrentNode != null)
			{
				if (this.treeDataGridView_0.CurrentNode.Cells[this.treeGridColumn_0.Name].Value != DBNull.Value)
				{
					Form13 form = new Form13(-1, this.objList_0.Id);
					form.method_5(Convert.ToInt32(this.treeDataGridView_0.CurrentNode.Cells[this.treeGridColumn_0.Name].Value));
					form.method_7(0);
					form.SqlSettings = this.SqlSettings;
					form.MdiParent = base.MdiParent;
					form.FormClosed += this.method_95;
					form.Show();
					return;
				}
			}
		}

		private void KdufyFstaY(object sender, EventArgs e)
		{
			if (this.treeDataGridView_0.CurrentNode != null)
			{
				if (this.treeDataGridView_0.CurrentNode.Cells[this.treeGridColumn_0.Name].Value != DBNull.Value)
				{
					Form13 form = new Form13(-1, this.objList_0.Id);
					form.method_5(Convert.ToInt32(this.treeDataGridView_0.CurrentNode.Cells[this.treeGridColumn_0.Name].Value));
					form.method_7(1);
					form.SqlSettings = this.SqlSettings;
					form.MdiParent = base.MdiParent;
					form.FormClosed += this.method_95;
					form.Show();
					return;
				}
			}
		}

		private void method_104()
		{
			if (this.treeDataGridView_0.CurrentNode != null && this.treeDataGridView_0.CurrentNode.Cells[this.treeGridColumn_0.Name].Value != DBNull.Value)
			{
				Form12 form = new Form12(this.SqlSettings, (int)this.treeDataGridView_0.CurrentNode.Cells[this.treeGridColumn_0.Name].Value, this.objList_0.Id, 1);
				form.MdiParent = base.MdiParent;
				form.FormClosed += this.method_111;
				form.Show();
			}
		}

		private void method_105()
		{
			if (this.treeDataGridView_0.CurrentNode != null)
			{
				if (this.treeDataGridView_0.CurrentNode.Cells[this.treeGridColumn_0.Name].Value != DBNull.Value)
				{
					Form12 form = new Form12(this.SqlSettings, (int)this.treeDataGridView_0.CurrentNode.Cells[this.treeGridColumn_0.Name].Value, this.objList_0.Id, 11);
					form.MdiParent = base.MdiParent;
					form.FormClosed += this.method_111;
					form.Show();
					return;
				}
			}
		}

		private void method_106(int int_3)
		{
			this.treeDataGridView_0.Nodes.Clear();
			this.list_3 = new List<int>();
			base.SelectSqlData(this.class107_0, this.class107_0.vP_Spans, true, string.Format("WHERE Deleted = ((0)) AND idObjList = {0} ORDER BY Number ASC", this.objList_0.Id));
			if (this.class107_0.vP_Spans.Rows.Count > 0)
			{
				bool flag = false;
				bool flag2 = false;
				for (;;)
				{
					Class107.Class277 @class = null;
					if (flag && !flag2)
					{
						this.treeDataGridView_0.Nodes.Add(new object[]
						{
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value,
							DBNull.Value
						});
						flag2 = true;
					}
					using (IEnumerator enumerator = this.class107_0.vP_Spans.Rows.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							Class107.Class277 class2 = (Class107.Class277)obj;
							if (!this.list_3.Contains(class2.id))
							{
								@class = class2;
								break;
							}
						}
						goto IL_286;
					}
					IL_DA:
					TreeDataGridViewNode treeDataGridViewNode = this.treeDataGridView_0.Nodes.Add(new object[]
					{
						@class.id,
						@class["idObjList"],
						@class["idPoleFirst"],
						@class["idPoleSecond"],
						@class["Number"],
						@class["NamePoleFirst"],
						@class["NamePoleSecond"],
						@class["CableMakeup"],
						@class["Voltage"],
						@class["Wires"],
						@class["CrossSection"],
						@class["Length"],
						@class.YearCommissioning.ToShortDateString()
					});
					treeDataGridViewNode.Expand();
					this.list_3.Add(@class.id);
					this.method_110(treeDataGridViewNode, this.class107_0.vP_Spans);
					flag = true;
					continue;
					IL_286:
					if (@class == null)
					{
						break;
					}
					goto IL_DA;
				}
				this.list_3.Clear();
			}
			decimal d = 0m;
			foreach (object obj2 in ((IEnumerable)this.treeDataGridView_0.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
				decimal d2 = 0m;
				if (decimal.TryParse(dataGridViewRow.Cells["lengthSpan"].Value.ToString(), out d2))
				{
					d += d2;
				}
			}
			this.toolStripLabel_7.Text = d.ToString() + " м.";
		}

		private void method_107(int int_3, int int_4)
		{
			this.method_106(int_3);
			List<TreeDataGridViewNode> list_ = new List<TreeDataGridViewNode>();
			list_ = this.method_108(this.treeDataGridView_0.Nodes, list_);
			TreeDataGridViewNode treeDataGridViewNode = this.method_109(list_, int_4);
			if (treeDataGridViewNode != null)
			{
				treeDataGridViewNode.Selected = true;
			}
		}

		private List<TreeDataGridViewNode> method_108(TreeDataGridViewNodeCollection treeDataGridViewNodeCollection_0, List<TreeDataGridViewNode> list_4)
		{
			foreach (TreeDataGridViewNode treeDataGridViewNode in treeDataGridViewNodeCollection_0)
			{
				list_4.Add(treeDataGridViewNode);
				list_4 = this.method_108(treeDataGridViewNode.Nodes, list_4);
			}
			return list_4;
		}

		private TreeDataGridViewNode method_109(List<TreeDataGridViewNode> list_4, int int_3)
		{
			foreach (TreeDataGridViewNode treeDataGridViewNode in list_4)
			{
				if (treeDataGridViewNode.Cells[0].Value is int && (int)treeDataGridViewNode.Cells[0].Value == int_3)
				{
					return treeDataGridViewNode;
				}
			}
			return null;
		}

		private void method_110(TreeDataGridViewNode treeDataGridViewNode_0, Class107.Class184 class184_0)
		{
			if (treeDataGridViewNode_0.Cells[3].Value != null)
			{
				IEnumerable<Class107.Class277> enumerable = from Class107.Class277 rowRoot in this.class107_0.vP_Spans.Rows
				where rowRoot.idPoleFirst == (int)treeDataGridViewNode_0.Cells[3].Value
				select rowRoot;
				bool flag = true;
				foreach (Class107.Class277 @class in enumerable)
				{
					if (!this.list_3.Contains(@class.id))
					{
						this.list_3.Add(@class.id);
						TreeDataGridViewNode treeDataGridViewNode;
						if (flag)
						{
							treeDataGridViewNode = treeDataGridViewNode_0.Parent.Nodes.Add(new object[]
							{
								@class.id,
								@class.idObjList,
								@class["idPoleFirst"],
								@class["idPoleSecond"],
								@class["Number"],
								@class["NamePoleFirst"],
								@class["NamePoleSecond"],
								@class["CableMakeup"],
								@class["Voltage"],
								@class["Wires"],
								@class["CrossSection"],
								@class["Length"],
								(!@class.IsNull("YearCommissioning")) ? @class.YearCommissioning.ToShortDateString() : ""
							});
							flag = false;
						}
						else
						{
							treeDataGridViewNode = treeDataGridViewNode_0.Nodes.Add(new object[]
							{
								@class.id,
								@class.idObjList,
								@class["idPoleFirst"],
								@class["idPoleSecond"],
								@class["Number"],
								@class["NamePoleFirst"],
								@class["NamePoleSecond"],
								@class["CableMakeup"],
								@class["Voltage"],
								@class["Wires"],
								@class["CrossSection"],
								@class["Length"],
								(!@class.IsNull("YearCommissioning")) ? @class.YearCommissioning.ToShortDateString() : ""
							});
						}
						treeDataGridViewNode.Expand();
						this.method_110(treeDataGridViewNode, this.class107_0.vP_Spans);
					}
				}
			}
		}

		private void treeDataGridView_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_104();
		}

		private void treeDataGridView_0_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
			if (e.RowIndex < 0 || e.ColumnIndex < 0)
			{
				return;
			}
			if (e.ColumnIndex == 4)
			{
				e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
				return;
			}
			e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
		}

		private void method_111(object sender, FormClosedEventArgs e)
		{
			if (((Form12)sender).DialogResult == DialogResult.OK)
			{
				if (this.treeDataGridView_0.CurrentNode != null && this.treeDataGridView_0.CurrentNode.Cells[0].Value is int)
				{
					this.method_107(this.objList_0.Id, (int)this.treeDataGridView_0.CurrentNode.Cells[0].Value);
					return;
				}
				this.method_106(this.objList_0.Id);
			}
		}

		private void toolStripButton_133_Click(object sender, EventArgs e)
		{
			this.DvwfiXqvOf();
		}

		private void toolStripButton_134_Click(object sender, EventArgs e)
		{
			if (this.bindingSource_12 != null && this.bindingSource_12.Current != null)
			{
				this.method_112();
				return;
			}
		}

		private void toolStripButton_135_Click(object sender, EventArgs e)
		{
			if (this.bindingSource_12 != null && this.bindingSource_12.Current != null)
			{
				this.method_113();
				return;
			}
		}

		private void toolStripButton_136_Click(object sender, EventArgs e)
		{
			this.method_114(this.objList_0.Id);
		}

		private void toolStripButton_155_Click(object sender, EventArgs e)
		{
			new FormReportJournalDocPPR
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent,
				StartPosition = FormStartPosition.CenterParent
			}.Show();
		}

		private void DvwfiXqvOf()
		{
			if (!this.bool_4)
			{
				return;
			}
			int num = -1;
			if (this.tabControl_5.SelectedTab == this.tabPage_25)
			{
				num = this.method_116(";DocPPR;DocType;", 1m);
			}
			else if (this.tabControl_5.SelectedTab == this.tabPage_26)
			{
				num = this.method_116(";DocPPR;DocType;", 2m);
			}
			FormDocPPRAddEdit formDocPPRAddEdit = new FormDocPPRAddEdit(-1, this.objList_0.Id, num);
			formDocPPRAddEdit.SqlSettings = this.SqlSettings;
			formDocPPRAddEdit.MdiParent = base.MdiParent;
			formDocPPRAddEdit.CreateState = 0;
			formDocPPRAddEdit.Show();
			formDocPPRAddEdit.FormClosed -= new FormClosedEventHandler(this.method_117);
			formDocPPRAddEdit.FormClosed += new FormClosedEventHandler(this.method_117);
		}

		private void method_112()
		{
			if (!this.bool_4)
			{
				return;
			}
			int num = -1;
			if (this.tabControl_5.SelectedTab == this.tabPage_25)
			{
				num = this.method_116(";DocPPR;DocType;", 1m);
			}
			else if (this.tabControl_5.SelectedTab == this.tabPage_26)
			{
				num = this.method_116(";DocPPR;DocType;", 2m);
			}
			FormDocPPRAddEdit formDocPPRAddEdit = new FormDocPPRAddEdit(Convert.ToInt32(((DataRowView)this.bindingSource_12.Current).Row["id"]), Convert.ToInt32(this.objList_0.Id), num);
			formDocPPRAddEdit.SqlSettings = this.SqlSettings;
			formDocPPRAddEdit.MdiParent = base.MdiParent;
			formDocPPRAddEdit.CreateState = 1;
			formDocPPRAddEdit.Show();
			formDocPPRAddEdit.FormClosed -= new FormClosedEventHandler(this.method_117);
			formDocPPRAddEdit.FormClosed += new FormClosedEventHandler(this.method_117);
		}

		private void method_113()
		{
			if (!this.bool_4)
			{
				return;
			}
			if (MessageBox.Show("Вы действительно хотите удалить выбранный документ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
			{
				return;
			}
			((DataRowView)this.bindingSource_12.Current).Row["deleted"] = true;
			base.UpdateSqlDataOnlyChange(this.dataTable_0);
			this.method_114(this.objList_0.Id);
		}

		private void method_114(int int_3)
		{
			if (!this.bool_4)
			{
				return;
			}
			this.dataTable_0.Clear();
			int num = -1;
			if (this.tabControl_5.SelectedTab == this.tabPage_25)
			{
				num = this.method_116(";DocPPR;DocType;", 1m);
			}
			else if (this.tabControl_5.SelectedTab == this.tabPage_26)
			{
				num = this.method_116(";DocPPR;DocType;", 2m);
			}
			string text = string.Format("where deleted = '0' and docType = '{0}' and idSchmObj = '{1}'", num, int_3);
			base.SelectSqlData(this.dataTable_0, true, text, null, false, 0);
		}

		private void method_115(int int_3, int int_4)
		{
			if (!this.bool_4)
			{
				return;
			}
			this.method_114(int_3);
			if (this.tabControl_5.SelectedTab == this.tabPage_25)
			{
				using (IEnumerator enumerator = ((IEnumerable)this.dataGridView_11.Rows).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (Convert.ToInt32(dataGridViewRow.Cells[this.dataGridViewTextBoxColumn_158.Name].Value) == int_4)
						{
							dataGridViewRow.Selected = true;
							this.dataGridView_11.FirstDisplayedScrollingRowIndex = dataGridViewRow.Index;
						}
					}
					return;
				}
			}
			if (this.tabControl_5.SelectedTab == this.tabPage_26)
			{
				foreach (object obj2 in ((IEnumerable)this.dataGridView_12.Rows))
				{
					DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
					if (Convert.ToInt32(dataGridViewRow2.Cells[this.dataGridViewTextBoxColumn_164.Name].Value) == int_4)
					{
						dataGridViewRow2.Selected = true;
						this.dataGridView_12.FirstDisplayedScrollingRowIndex = dataGridViewRow2.Index;
					}
				}
			}
		}

		private int method_116(string string_1, decimal decimal_0)
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			base.SelectSqlData(dataTable, true, string.Format("where ParentKey = '{0}' and value = '{1}' and deleted = '0'", string_1, decimal_0), null, false, 0);
			if (dataTable.Rows.Count == 0)
			{
				return -1;
			}
			return Convert.ToInt32(dataTable.Rows[0]["id"]);
		}

		private void dataGridView_12_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.bindingSource_12 != null && this.bindingSource_12.Current != null)
			{
				this.method_112();
				return;
			}
		}

		private void tabControl_5_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_114(this.objList_0.Id);
		}

		private void method_117(object sender, EventArgs e)
		{
			FormDocPPRAddEdit formDocPPRAddEdit = (FormDocPPRAddEdit)sender;
			if (formDocPPRAddEdit.DialogResult == DialogResult.OK)
			{
				this.method_115(this.objList_0.Id, formDocPPRAddEdit.IdDoc);
			}
		}

		private void toolStripButton_151_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Multiselect = true;
				Class14.Class56 @class = new Class14.Class56();
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					for (int i = 0; i < openFileDialog.FileNames.Length; i++)
					{
						DataRow dataRow = @class.NewRow();
						dataRow["idObj"] = this.objList_0.Id;
						dataRow["Document"] = File.ReadAllBytes(openFileDialog.FileNames[i]);
						dataRow["FileName"] = Path.GetFileName(openFileDialog.FileNames[i]);
						dataRow["DateIn"] = DateTime.Now;
						@class.Rows.Add(dataRow);
						dataRow = this.jtnAdxtlvN.tSchm_ObjFile.NewRow();
						dataRow["idObj"] = this.objList_0.Id;
						dataRow["FileName"] = Path.GetFileName(openFileDialog.FileNames[i]);
						dataRow["DateIn"] = DateTime.Now;
						this.jtnAdxtlvN.tSchm_ObjFile.Rows.Add(dataRow);
					}
				}
				base.InsertSqlData(@class);
				@class.Clear();
				this.dataGridView_13.CellValueChanged -= this.dataGridView_13_CellValueChanged;
				base.SelectSqlData(this.jtnAdxtlvN, this.jtnAdxtlvN.tSchm_ObjFile, true, " where idObj = " + this.objList_0.Id.ToString());
				this.dataGridView_13.CellValueChanged += this.dataGridView_13_CellValueChanged;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void toolStripButton_152_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_13.CurrentRow != null)
			{
				int num = Convert.ToInt32(this.dataGridView_13.CurrentRow.Cells[this.dataGridViewTextBoxColumn_223.Name].Value);
				this.dataGridView_13.Rows.Remove(this.dataGridView_13.CurrentRow);
				Class14.Class56 @class = new Class14.Class56();
				base.DeleteSqlDataById(@class, num);
				return;
			}
			MessageBox.Show("Не выбрано ни одного файла");
		}

		private void toolStripButton_153_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_13.CurrentRow == null)
			{
				return;
			}
			int num = Convert.ToInt32(this.dataGridView_13.CurrentRow.Cells[this.dataGridViewTextBoxColumn_223.Name].Value);
			DataTable dataTable = new DataTable("tSchm_ObjFile");
			base.SelectSqlData(dataTable, true, " where id = " + num.ToString(), null, false, 0);
			if (dataTable.Rows.Count > 0)
			{
				byte[] array = (byte[])dataTable.Rows[0]["Document"];
				string text = Path.GetTempFileName();
				text = Path.ChangeExtension(text, Path.GetExtension(dataTable.Rows[0]["FileName"].ToString()));
				FileStream fileStream = File.Create(text);
				fileStream.Write(array, 0, array.Length);
				fileStream.Close();
				new Process
				{
					StartInfo = 
					{
						FileName = text,
						UseShellExecute = true
					}
				}.Start();
			}
		}

		private void toolStripButton_154_Click(object sender, EventArgs e)
		{
			try
			{
				int num = Convert.ToInt32(this.dataGridView_13.CurrentRow.Cells[this.dataGridViewTextBoxColumn_223.Name].Value);
				DataTable dataTable = new DataTable("tSchm_ObjFile");
				base.SelectSqlData(dataTable, true, " where id = " + num.ToString(), null, false, 0);
				if (dataTable.Rows.Count > 0)
				{
					string text = this.dataGridView_13.CurrentRow.Cells[this.YowoatyOoV.Name].Value.ToString();
					string extension = Path.GetExtension(text);
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.Filter = "(*" + extension + ")|*" + extension;
					saveFileDialog.FileName = text;
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						byte[] array = (byte[])dataTable.Rows[0]["Document"];
						FileStream fileStream = File.Create(saveFileDialog.FileName);
						fileStream.Write(array, 0, array.Length);
						fileStream.Close();
						MessageBox.Show("Файл успешно сохранен", "Сохранение");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void method_118(int int_3)
		{
			this.dataGridView_13.CellValueChanged -= this.dataGridView_13_CellValueChanged;
			base.SelectSqlData(this.jtnAdxtlvN, this.jtnAdxtlvN.tSchm_ObjFile, true, " where idObj = " + int_3.ToString());
			this.dataGridView_13.CellValueChanged += this.dataGridView_13_CellValueChanged;
		}

		private void dataGridView_13_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
		}

		private void dataGridView_13_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			foreach (object obj in ((IEnumerable)this.dataGridView_13.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if (!dataGridViewRow.IsNewRow && this.dataGridView_13[this.YowoatyOoV.Name, dataGridViewRow.Index].Value != null)
				{
					Icon icon = Passport.Classes.FileInfo.IconOfFile(this.dataGridView_13[this.YowoatyOoV.Name, e.RowIndex].Value.ToString());
					dataGridViewRow.Cells[this.dataGridViewImageColumn_1.Index].Value = icon.ToBitmap();
				}
			}
		}

		private void dataGridView_13_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == this.dataGridView_13.Columns[this.YowoatyOoV.Name].Index)
			{
				this.toolStripButton_153_Click(sender, e);
			}
		}

		private void dataGridView_13_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == this.dataGridView_13.Columns[this.dataGridViewTextBoxColumn_226.Name].Index)
			{
				foreach (object obj in this.jtnAdxtlvN.tSchm_ObjFile.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
					{
						dataRow.EndEdit();
					}
				}
				base.UpdateSqlData(this.jtnAdxtlvN, this.jtnAdxtlvN.tSchm_ObjFile);
				this.jtnAdxtlvN.tSchm_ObjFile.AcceptChanges();
			}
		}

		private void method_119(int int_3, string string_1, string string_2, TypeObjList typeObjList_0)
		{
			if (!(string_1 == ";SCM;PS;"))
			{
				if (!(string_1 == ";SCM;Line;"))
				{
					this.VisibleTab(this.tabControl_0, this.tabPage_2, false);
					this.VisibleTab(this.tabControl_0, this.tabPage_23, false);
					this.VisibleTab(this.tabControl_0, this.Cjurjlhywj, false);
					this.VisibleTab(this.tabControl_0, this.tabPage_27, false);
				}
				else
				{
					this.label_3.Text = "Марка кабеля:";
					if (typeObjList_0 == TypeObjList.LineCable)
					{
						this.label_1.Text = SchmObj.GetMinCabSectionString(this.SqlSettings, int_3);
						this.VisibleTab(this.tabControl_0, this.tabPage_23, true);
						this.VisibleTab(this.tabControl_0, this.tabPage_27, true);
						this.VisibleTab(this.tabControl_0, this.tabPage_24, false);
					}
					if (typeObjList_0 == TypeObjList.LineAir || typeObjList_0 == TypeObjList.LineProtectedAir)
					{
						this.label_1.Text = SchmObj.GetMinAirLineSpanString(this.SqlSettings, int_3);
						this.VisibleTab(this.tabControl_0, this.Cjurjlhywj, true);
						this.VisibleTab(this.tabControl_0, this.tabPage_27, true);
						this.VisibleTab(this.tabControl_0, this.tabPage_24, false);
					}
				}
			}
			else
			{
				this.VisibleTab(this.tabControl_0, this.tabPage_2, true);
				this.VisibleTab(this.tabControl_0, this.tabPage_27, true);
				this.VisibleTab(this.tabControl_0, this.tabPage_24, false);
			}
			this.Text = "Паспорт " + string_2;
			try
			{
				if (this.tabControl_0.SelectedTab == this.tabPage_0)
				{
					if (this.bool_0)
					{
						this.method_23(int_3);
					}
					else
					{
						this.method_25(int_3);
					}
				}
				if (this.tabControl_0.SelectedTab == this.tabPage_2)
				{
					if (this.tabControl_4.SelectedTab == this.tabPage_16)
					{
						this.method_45();
					}
					if (this.tabControl_4.SelectedTab == this.tabPage_17)
					{
						this.method_47();
					}
					if (this.tabControl_4.SelectedTab == this.tabPage_20)
					{
						this.method_49();
					}
					this.method_51();
				}
				if (this.tabControl_0.SelectedTab == this.tabPage_23)
				{
					this.method_77();
					if (this.tabControl_3.SelectedTab == this.dykcUlJvZe)
					{
						this.method_73();
					}
					if (this.tabControl_3.SelectedTab == this.tabPage_14)
					{
						this.method_81();
					}
				}
				if (this.tabControl_0.SelectedTab == this.Cjurjlhywj)
				{
					this.method_97(this.objList_0.Id);
					this.method_101(this.objList_0.Id);
					this.method_106(this.objList_0.Id);
					this.method_85(this.objList_0.Id);
				}
				TabPage selectedTab = this.tabControl_0.SelectedTab;
				TabPage selectedTab2 = this.tabControl_0.SelectedTab;
				if (this.tabControl_0.SelectedTab == this.tabPage_27)
				{
					this.method_118(this.objList_0.Id);
				}
			}
			catch (Exception)
			{
			}
		}

		private decimal method_120(int int_3)
		{
			SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
			decimal result;
			try
			{
				string cmdText = string.Format("SELECT c.Value FROM tSchm_ObjList AS ol JOIN tR_Classifier AS c ON ol.TypeCodeId = c.id WHERE ol.id = {0}", int_3.ToString());
				sqlConnection.Open();
				SqlCommand selectCommand = new SqlCommand(cmdText, sqlConnection);
				DataTable dataTable = new DataTable();
				new SqlDataAdapter(selectCommand).Fill(dataTable);
				if (dataTable.Rows.Count > 0)
				{
					result = (decimal)dataTable.Rows[0]["Value"];
				}
				else
				{
					result = -1m;
				}
			}
			catch (Exception)
			{
				result = -1m;
			}
			finally
			{
				if (sqlConnection.State == ConnectionState.Open)
				{
					sqlConnection.Close();
				}
			}
			return result;
		}

		public void VisibleTab(TabControl control, TabPage page, bool value)
		{
			if (value)
			{
				if (page.Parent == null)
				{
					page.Parent = control;
					return;
				}
			}
			else if (page.Parent == control)
			{
				page.Parent = null;
			}
		}

		private void OmaFmRnUue(object sender, EventArgs e)
		{
			this.method_121(this.tabControl_1.SelectedTab);
		}

		private void method_121(TabPage tabPage_35)
		{
			string name = tabPage_35.Name;
			if (name == "tpBuses")
			{
				this.method_53();
				return;
			}
			if (name == "tpCells")
			{
				this.method_55();
				return;
			}
			if (name == "tpSwitch")
			{
				this.method_57();
				return;
			}
			if (!(name == "tpProtector"))
			{
				return;
			}
			this.method_59();
		}

		private void method_122(bool bool_5)
		{
			this.toolStripSeparator_5.Visible = bool_5;
			this.toolStripButton_21.Visible = bool_5;
			this.bJkuSvjuUb.Visible = bool_5;
			this.toolStripButton_17.Visible = bool_5;
			this.toolStripSeparator_0.Visible = bool_5;
			this.toolStripButton_8.Visible = bool_5;
			this.toolStripSeparator_2.Visible = bool_5;
			this.toolStripButton_13.Visible = bool_5;
			this.toolStripSeparator_7.Visible = bool_5;
			this.toolStripButton_26.Visible = bool_5;
		}

		private void FormDockPassport_Shown(object sender, EventArgs e)
		{
			this.int_2 = Class318.smethod_0(this.SqlSettings, this.Text);
			this.method_29(false);
			this.toolStripButton_64.Visible = (this.toolStripButton_40.Visible = (this.SqlSettings.ServerDB.ToUpper() == "ULGES-SQL2"));
		}

		private void FormDockPassport_FormClosing(object sender, FormClosingEventArgs e)
		{
			Class318.smethod_1(this.SqlSettings, this.int_2);
		}

		private void toolStripButton_61_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null && new FormTransfMove
			{
				SqlSettings = this.SqlSettings,
				IdObjList = this.objList_0.Id,
				AllowUserToAddMoveTransf = true
			}.ShowDialog() == DialogResult.OK)
			{
				this.method_124(this.objList_0.Id);
			}
		}

		private void toolStripButton_65_Click(object sender, EventArgs e)
		{
			this.method_125();
		}

		private void toolStripButton_62_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_8.SelectedRows != null && this.dataGridView_8.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tSchm_Move, true, string.Format("where id = {0}", (int)this.dataGridView_8.SelectedRows[0].Cells["IdMove"].Value));
				this.class107_0.tSchm_Move.Rows[0]["Deleted"] = true;
				base.UpdateSqlData(this.class107_0, this.class107_0.tSchm_Move);
				this.method_124(this.objList_0.Id);
			}
		}

		private void toolStripButton_63_Click(object sender, EventArgs e)
		{
			this.method_123(this.objList_0.Id, (int)this.dataGridView_8.SelectedRows[0].Cells["IdMove"].Value);
		}

		private void toolStripButton_64_Click(object sender, EventArgs e)
		{
		}

		private void method_123(int int_3, int int_4)
		{
			this.toolStripSeparator_43.Visible = (this.toolStripButton_64.Visible = (";SCM;INLINE_OBJ;SWITCH;" == base.CallSQLScalarFunction("dbo.fn_P_GetTypeObject", new string[]
			{
				int_3.ToString()
			}).ToString() && this.SqlSettings.ServerDB.ToUpper() == "ULGES-SQL2"));
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = (this.dataGridView_8.DataSource = Class322.smethod_0(this.SqlSettings, int_3));
			bindingSource.Position = bindingSource.Find("Id", int_4);
			this.dataGridView_8.DataSource = bindingSource;
		}

		private void method_124(int int_3)
		{
			if (this.dataGridView_8.SelectedRows != null && this.dataGridView_8.SelectedRows.Count > 0)
			{
				int int_4 = (int)this.dataGridView_8.SelectedRows[0].Cells["idMove"].Value;
				this.method_123(int_3, int_4);
				return;
			}
			this.dataGridView_8.DataSource = Class322.smethod_0(this.SqlSettings, int_3);
		}

		private void method_125()
		{
			if (this.dataGridView_8.SelectedRows != null && this.dataGridView_8.SelectedRows.Count > 0 && new FormEditTransfMove(this.SqlSettings, (int)this.dataGridView_8.SelectedRows[0].Cells["IdMove"].Value).ShowDialog() == DialogResult.OK)
			{
				this.method_123(this.objList_0.Id, (int)this.dataGridView_8.SelectedRows[0].Cells["IdMove"].Value);
			}
		}

		private void dataGridView_8_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_125();
		}

		private void toolStripButton_28_Click(object sender, EventArgs e)
		{
			this.method_126();
		}

		private void toolStripButton_29_Click(object sender, EventArgs e)
		{
			this.method_127();
		}

		private void toolStripButton_30_Click(object sender, EventArgs e)
		{
			this.method_128();
		}

		private void ISDFONQRUF(object sender, EventArgs e)
		{
			this.method_129();
		}

		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			this.method_126();
		}

		private void toolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			this.method_127();
		}

		private void toolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			this.method_128();
		}

		private void toolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			this.method_129();
		}

		private void method_126()
		{
			if (this.treeView_0.SelectedNode != null)
			{
				FormRegistrAddEditRepair formRegistrAddEditRepair = new FormRegistrAddEditRepair(this.SqlSettings, this.objList_0.Id, 0);
				if (formRegistrAddEditRepair.ShowDialog() == DialogResult.OK)
				{
					this.method_131(this.objList_0.Id, formRegistrAddEditRepair.Id);
				}
			}
		}

		private void method_127()
		{
			if (this.treeView_0.SelectedNode != null && this.dataGridView_2.SelectedRows.Count > 0)
			{
				FormRegistrAddEditRepair formRegistrAddEditRepair = new FormRegistrAddEditRepair(this.SqlSettings, (int)this.dataGridView_2.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_147.Name].Value, 1);
				if (formRegistrAddEditRepair.ShowDialog() == DialogResult.OK)
				{
					this.method_131(this.objList_0.Id, formRegistrAddEditRepair.Id);
				}
			}
		}

		private void method_128()
		{
			if (this.dataGridView_2.SelectedRows != null && this.dataGridView_2.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить строку?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tP_DocList, true, string.Format("WHERE Id = {0}", (int)this.dataGridView_2.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_147.Name].Value));
				((Class107.Class248)this.class107_0.tP_DocList.Rows[0]).Deleted = true;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_DocList);
				this.method_130(this.objList_0.Id);
			}
		}

		private void method_129()
		{
			if (this.treeView_0.SelectedNode != null)
			{
				if (this.dataGridView_2.SelectedRows != null && this.dataGridView_2.SelectedRows.Count > 0)
				{
					int int_ = (int)this.dataGridView_2.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_147.Name].Value;
					this.method_131(this.objList_0.Id, int_);
					return;
				}
				this.method_130(this.objList_0.Id);
			}
		}

		private void method_130(int int_3)
		{
			this.dataGridView_3.DataSource = PassportData.GetBalanceData(this.SqlSettings, int_3);
		}

		private void method_131(int int_3, int int_4)
		{
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = PassportData.GetRepairData(this.SqlSettings, int_3);
			bindingSource.Position = bindingSource.Find("Id", int_4);
			this.dataGridView_2.DataSource = bindingSource;
		}

		private void dataGridView_2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_127();
		}

		private void toolStripButton_32_Click(object sender, EventArgs e)
		{
			this.method_132();
		}

		private void toolStripMenuItem_71_Click(object sender, EventArgs e)
		{
			if (this.typeObjListGroup_0 == TypeObjListGroup.AirLines)
			{
				this.method_139();
				return;
			}
			this.method_133();
		}

		private void toolStripMenuItem_72_Click(object sender, EventArgs e)
		{
			this.method_134();
		}

		private void toolStripButton_35_Click(object sender, EventArgs e)
		{
			this.method_135();
		}

		private void toolStripMenuItem_5_Click(object sender, EventArgs e)
		{
			this.method_132();
		}

		private void toolStripMenuItem_6_Click(object sender, EventArgs e)
		{
			this.method_133();
		}

		private void toolStripMenuItem_7_Click(object sender, EventArgs e)
		{
			this.method_134();
		}

		private void toolStripMenuItem_8_Click(object sender, EventArgs e)
		{
			this.method_135();
		}

		private void method_132()
		{
			if (this.treeView_0.SelectedNode != null)
			{
				FormRegistrAddEditBalance formRegistrAddEditBalance = new FormRegistrAddEditBalance(this.SqlSettings, this.objList_0.Id, 0);
				if (formRegistrAddEditBalance.ShowDialog() == DialogResult.OK)
				{
					this.method_137(this.objList_0.Id, formRegistrAddEditBalance.Id);
				}
			}
		}

		private void method_133()
		{
			if (this.dataGridView_3.SelectedRows != null && this.dataGridView_3.SelectedRows.Count > 0)
			{
				FormRegistrAddEditBalance formRegistrAddEditBalance = new FormRegistrAddEditBalance(this.SqlSettings, (int)this.dataGridView_3.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_187.Name].Value, 1);
				if (formRegistrAddEditBalance.ShowDialog() == DialogResult.OK)
				{
					this.method_137(this.objList_0.Id, formRegistrAddEditBalance.Id);
				}
			}
		}

		private void method_134()
		{
			TypeObjListGroup typeObjListGroup = this.typeObjListGroup_0;
			if (typeObjListGroup == TypeObjListGroup.AirLines)
			{
				this.method_140();
				return;
			}
			if (this.dataGridView_3.SelectedRows != null && this.dataGridView_3.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tP_DocList, true, string.Format("WHERE Id = {0}", (int)this.dataGridView_3.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_187.Name].Value));
				((Class107.Class248)this.class107_0.tP_DocList.Rows[0]).Deleted = true;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_DocList);
				this.method_136(this.objList_0.Id);
			}
		}

		private void method_135()
		{
			if (this.treeView_0.SelectedNode != null)
			{
				if (this.dataGridView_3.SelectedRows != null && this.dataGridView_3.SelectedRows.Count > 0)
				{
					int int_ = (int)this.dataGridView_3.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_187.Name].Value;
					TypeObjListGroup typeObjListGroup = this.typeObjListGroup_0;
					if (typeObjListGroup == TypeObjListGroup.AirLines)
					{
						this.method_142(this.objList_0.Id, int_);
						return;
					}
					this.method_137(this.objList_0.Id, int_);
					return;
				}
				else
				{
					TypeObjListGroup typeObjListGroup = this.typeObjListGroup_0;
					if (typeObjListGroup == TypeObjListGroup.AirLines)
					{
						this.method_141(this.objList_0.Id);
						return;
					}
					this.method_136(this.objList_0.Id);
				}
			}
		}

		private void method_136(int int_3)
		{
			this.dataGridView_3.DataSource = PassportData.GetBalanceData(this.SqlSettings, int_3);
		}

		private void method_137(int int_3, int int_4)
		{
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = PassportData.GetBalanceData(this.SqlSettings, int_3);
			bindingSource.Position = bindingSource.Find("Id", int_4);
			this.dataGridView_3.DataSource = bindingSource;
		}

		private void tabControl_1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_121(this.tabControl_1.SelectedTab);
		}

		private void dataGridView_3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.typeObjListGroup_0 == TypeObjListGroup.AirLines)
			{
				this.method_139();
				return;
			}
			this.method_133();
		}

		private void toolStripMenuItem_69_Click(object sender, EventArgs e)
		{
			this.method_138(1m);
		}

		private void toolStripMenuItem_70_Click(object sender, EventArgs e)
		{
			int num = this.method_116(";TypeDoc;tPassport;PS;", 1m);
			BindingSource bindingSource = (BindingSource)this.dataGridView_3.DataSource;
			if (bindingSource != null && bindingSource.Find("typeDoc", num) >= 0)
			{
				this.method_138(7m);
				return;
			}
			MessageBox.Show("Невозможно создать документ 'Модернизация/реконструкция', поскольку нет ни одного документа 'Принятие на баланс'");
		}

		private void method_138(decimal decimal_0)
		{
			if (this.objList_0.Type == TypeObjList.LineAir || this.objList_0.Type == TypeObjList.LineProtectedAir)
			{
				Form14 form = new Form14(this.objList_0.Id, -1, decimal_0);
				form.method_1(0);
				form.SqlSettings = this.SqlSettings;
				form.MdiParent = base.MdiParent;
				form.Show();
				form.FormClosed -= new FormClosedEventHandler(this.method_144);
				form.FormClosed += new FormClosedEventHandler(this.method_144);
			}
		}

		private void method_139()
		{
			if (this.dataGridView_3.SelectedRows != null && this.dataGridView_3.SelectedRows.Count != 0)
			{
				int int_ = Convert.ToInt32(this.dataGridView_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_187.Name].Value);
				int int_2 = Convert.ToInt32(this.dataGridView_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_192.Name].Value);
				decimal num = this.method_143(int_2);
				Form14 form = new Form14(this.objList_0.Id, int_, num);
				if (num == 7m)
				{
					form.method_1(7);
				}
				else
				{
					BindingSource bindingSource = (BindingSource)this.dataGridView_3.DataSource;
					bindingSource.Filter = string.Format("idSector = '{0}' and id <> '{1}'", ((DataRowView)bindingSource.Current).Row["idSector"], ((DataRowView)bindingSource.Current).Row["id"]);
					if (bindingSource.Count > 0)
					{
						form.method_1(7);
					}
					else
					{
						form.method_1(1);
					}
					bindingSource.Filter = string.Empty;
				}
				form.SqlSettings = this.SqlSettings;
				form.MdiParent = base.MdiParent;
				form.Show();
				form.FormClosed -= new FormClosedEventHandler(this.method_144);
				form.FormClosed += new FormClosedEventHandler(this.method_144);
				return;
			}
		}

		private void method_140()
		{
			if (this.dataGridView_3.SelectedRows == null && this.dataGridView_3.SelectedRows.Count == 0)
			{
				return;
			}
			int int_ = Convert.ToInt32(this.dataGridView_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_192.Index].Value);
			decimal d = this.method_143(int_);
			string text = string.Empty;
			if (d == 1m)
			{
				text = "При удалении документа 'Принятие на баланс', также будут удалены связанные с ним документы 'Модернизация/реконструкция'.\r\nПродолжить?";
			}
			else if (d == 7m)
			{
				text = "Вы действительно хотите удалить выбранный документ?";
			}
			if (MessageBox.Show(text, "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
			{
				return;
			}
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			if (!sqlDataCommand.UpdateSqlData(new DataTable("tP_DocList"), "set deleted = '1'", string.Format("where (id = '{0}' or ParentId = '{0}') and deleted = '0'", this.dataGridView_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_187.Index].Value)))
			{
				return;
			}
			if (d == 1m)
			{
				sqlDataCommand.UpdateSqlData(new DataTable("tSchm_ObjList"), "set deleted = '1'", string.Format("where id = '{0}'", this.dataGridView_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_189.Index].Value));
			}
			this.method_141(this.objList_0.Id);
		}

		private void method_141(int int_3)
		{
			string text = string.Format("where deleted = '0' and idObjList = '{0}' order by dateDoc desc", int_3);
			base.SelectSqlData(this.jtnAdxtlvN.vP_BalanceAirLine, true, text, null, false, 0);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = this.jtnAdxtlvN.vP_BalanceAirLine;
			this.dataGridView_3.AutoGenerateColumns = false;
			this.dataGridView_3.DataSource = bindingSource;
		}

		private void method_142(int int_3, int int_4)
		{
			this.method_141(int_3);
			BindingSource bindingSource = (BindingSource)this.dataGridView_3.DataSource;
			if (bindingSource != null)
			{
				bindingSource.Position = bindingSource.Find("id", int_4);
			}
		}

		private decimal method_143(int int_3)
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Name", typeof(string));
			dataTable.Columns.Add("Value", typeof(decimal));
			base.SelectSqlData(dataTable, true, string.Format("where id = '{0}'", int_3), null, false, 0);
			if (dataTable.Rows.Count > 0)
			{
				return Convert.ToDecimal(dataTable.Rows[0]["Value"]);
			}
			return -1m;
		}

		private void method_144(object sender, EventArgs e)
		{
			Form14 form = (Form14)sender;
			if (form.DialogResult == DialogResult.OK)
			{
				StateFormCreate stateFormCreate = form.method_0();
				if (stateFormCreate != null && stateFormCreate != 1)
				{
					if (stateFormCreate != 7)
					{
						this.method_141(this.objList_0.Id);
						return;
					}
				}
				this.method_142(this.objList_0.Id, form.method_2());
				return;
			}
		}

		private void method_145(TypeObjListGroup typeObjListGroup_1)
		{
			this.toolStripDropDownButton_2.Visible = false;
			if (typeObjListGroup_1 == TypeObjListGroup.AirLines)
			{
				ToolStripItem toolStripItem = this.toolStripButton_32;
				this.toolStripButton_32.Enabled = false;
				toolStripItem.Visible = false;
				ToolStripItem toolStripItem2 = this.toolStripDropDownButton_2;
				this.toolStripDropDownButton_2.Enabled = true;
				toolStripItem2.Visible = true;
				this.dataGridViewTextBoxColumn_195.Visible = false;
				this.dataGridViewTextBoxColumn_196.Visible = false;
				this.dataGridViewTextBoxColumn_197.Visible = true;
				this.dataGridViewTextBoxColumn_198.Visible = true;
				this.dataGridViewTextBoxColumn_199.Visible = true;
				this.dataGridViewTextBoxColumn_200.Visible = true;
				this.dataGridViewTextBoxColumn_201.Visible = true;
				this.dataGridView_3.ContextMenuStrip = this.contextMenuStrip_15;
				return;
			}
			ToolStripItem toolStripItem3 = this.toolStripButton_32;
			this.toolStripButton_32.Enabled = true;
			toolStripItem3.Visible = true;
			ToolStripItem toolStripItem4 = this.toolStripDropDownButton_2;
			this.toolStripDropDownButton_2.Enabled = false;
			toolStripItem4.Visible = false;
			this.dataGridViewTextBoxColumn_195.Visible = true;
			this.dataGridViewTextBoxColumn_196.Visible = true;
			this.dataGridViewTextBoxColumn_197.Visible = false;
			this.dataGridViewTextBoxColumn_198.Visible = false;
			this.dataGridViewTextBoxColumn_199.Visible = false;
			this.dataGridViewTextBoxColumn_200.Visible = false;
			this.dataGridViewTextBoxColumn_201.Visible = false;
			this.dataGridView_3.ContextMenuStrip = this.contextMenuStrip_2;
		}

		private void toolStripButton_36_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				this.vGcpaJaSpn(this.objList_0.Id);
			}
		}

		private void toolStripButton_37_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_4.SelectedRows != null && this.dataGridView_4.SelectedRows.Count > 0)
			{
				this.method_146(this.objList_0.Id, (int)this.dataGridView_4.SelectedRows[0].Cells["IdBuildRepair"].Value);
			}
		}

		private void toolStripButton_38_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_4.SelectedRows != null && this.dataGridView_4.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.method_147(this.objList_0.Id, (int)this.dataGridView_4.SelectedRows[0].Cells["IdBuildRepair"].Value);
			}
		}

		private void toolStripButton_39_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				if (this.dataGridView_4.SelectedRows != null && this.dataGridView_4.SelectedRows.Count > 0)
				{
					int int_ = (int)this.dataGridView_4.SelectedRows[0].Cells["idBuildRepair"].Value;
					this.method_149(this.objList_0.Id, int_);
					return;
				}
				this.method_148(this.objList_0.Id);
			}
		}

		private void toolStripMenuItem_9_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				this.vGcpaJaSpn(this.objList_0.Id);
			}
		}

		private void toolStripMenuItem_10_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_4.SelectedRows != null && this.dataGridView_4.SelectedRows.Count > 0)
			{
				this.method_146(this.objList_0.Id, (int)this.dataGridView_4.SelectedRows[0].Cells["IdBuildRepair"].Value);
			}
		}

		private void toolStripMenuItem_11_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_4.SelectedRows != null && this.dataGridView_4.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.method_147(this.objList_0.Id, (int)this.dataGridView_4.SelectedRows[0].Cells["IdBuildRepair"].Value);
			}
		}

		private void toolStripMenuItem_12_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				if (this.dataGridView_4.SelectedRows != null && this.dataGridView_4.SelectedRows.Count > 0)
				{
					int int_ = (int)this.dataGridView_4.SelectedRows[0].Cells["idBuildRepair"].Value;
					this.method_149(this.objList_0.Id, int_);
					return;
				}
				this.method_148(this.objList_0.Id);
			}
		}

		private void vGcpaJaSpn(int int_3)
		{
			FormAddEditBuildRepair formAddEditBuildRepair = new FormAddEditBuildRepair(this.SqlSettings, int_3, 0);
			if (formAddEditBuildRepair.ShowDialog() == DialogResult.OK)
			{
				this.method_149(int_3, formAddEditBuildRepair.Id);
			}
		}

		private void method_146(int int_3, int int_4)
		{
			FormAddEditBuildRepair formAddEditBuildRepair = new FormAddEditBuildRepair(this.SqlSettings, int_4, 1);
			if (formAddEditBuildRepair.ShowDialog() == DialogResult.OK)
			{
				this.method_149(int_3, formAddEditBuildRepair.Id);
			}
		}

		private void method_147(int int_3, int int_4)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_BuildSubsRepair, true, "WHERE id = " + int_4.ToString());
			if (this.class107_0.tP_BuildSubsRepair.Rows.Count > 0)
			{
				((Class107.Class254)this.class107_0.tP_BuildSubsRepair.Rows[0]).Deleted = true;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_BuildSubsRepair);
				this.method_148(int_3);
			}
		}

		private void method_148(int int_3)
		{
			this.dataGridView_4.DataSource = PassportData.GetBuildRepairData(this.SqlSettings, int_3);
		}

		private void method_149(int int_3, int int_4)
		{
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = PassportData.GetBuildRepairData(this.SqlSettings, int_3);
			bindingSource.Position = bindingSource.Find("Id", int_4);
			this.dataGridView_4.DataSource = bindingSource;
		}

		private void tabControl_2_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_35(this.objList_0.Id);
		}

		private void dataGridView_4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridView_4.SelectedRows != null && this.dataGridView_4.SelectedRows.Count > 0)
			{
				this.method_146(this.objList_0.Id, (int)this.dataGridView_4.SelectedRows[0].Cells["IdBuildRepair"].Value);
			}
		}

		private void toolStripButton_48_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				FormAddEditCableTesting formAddEditCableTesting = new FormAddEditCableTesting(this.SqlSettings, this.objList_0.Id, 0);
				if (formAddEditCableTesting.ShowDialog() == DialogResult.OK)
				{
					base.SelectSqlData(this.class107_0, this.class107_0.vP_CabTesting, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", this.objList_0.Id));
					this.bindingSource_0.Position = this.bindingSource_0.Find("id", formAddEditCableTesting.IdCabtesting);
				}
			}
		}

		private void toolStripButton_49_Click(object sender, EventArgs e)
		{
			this.method_150();
		}

		private void toolStripButton_50_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_5.SelectedRows != null && this.dataGridView_5.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tP_CabTesting, true, string.Format("WHERE id = {0} AND Deleted = ((0))", (int)this.dataGridView_5.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_5.Name].Value));
				this.class107_0.tP_CabTesting.Rows[0]["Deleted"] = true;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_CabTesting);
				base.SelectSqlData(this.class107_0, this.class107_0.vP_CabTesting, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", this.objList_0.Id));
			}
		}

		private void toolStripButton_51_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_5.SelectedRows != null && this.dataGridView_5.SelectedRows.Count > 0)
			{
				int num = (int)this.dataGridView_5.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_5.Name].Value;
				base.SelectSqlData(this.class107_0, this.class107_0.vP_CabTesting, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", this.objList_0.Id));
				this.bindingSource_0.Position = this.bindingSource_0.Find("id", num);
				return;
			}
			base.SelectSqlData(this.class107_0, this.class107_0.vP_CabTesting, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", this.objList_0.Id));
		}

		private void method_150()
		{
			if (this.dataGridView_5.SelectedRows != null && this.dataGridView_5.SelectedRows.Count > 0)
			{
				FormAddEditCableTesting formAddEditCableTesting = new FormAddEditCableTesting(this.SqlSettings, (int)this.dataGridView_5.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_5.Name].Value, 1);
				if (formAddEditCableTesting.ShowDialog() == DialogResult.OK)
				{
					base.SelectSqlData(this.class107_0, this.class107_0.vP_CabTesting, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", this.objList_0.Id));
					this.bindingSource_0.Position = this.bindingSource_0.Find("id", formAddEditCableTesting.IdCabtesting);
				}
			}
		}

		private void dataGridView_5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_150();
		}

		private void toolStripButton_112_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null && (this.class107_0.vP_CabOperation.Rows.Count == 0 || this.class107_0.vP_CabOperation.Rows[0]["dateCommissioning"] != DBNull.Value))
			{
				FormAddEditCableOperation formAddEditCableOperation = new FormAddEditCableOperation(this.SqlSettings, 0, this.objList_0.Id);
				if (formAddEditCableOperation.ShowDialog() == DialogResult.OK)
				{
					base.SelectSqlData(this.class107_0.vP_CabOperation, true, string.Format("where idObjList = {0} and deleted = 0  order by Convert(datetime, dateDecommissioning, 104) desc", this.objList_0.Id), null, false, 0);
					this.bindingSource_1.Position = this.bindingSource_1.Find("Id", formAddEditCableOperation.Id);
					this.method_152((int)this.dataGridView_6.SelectedRows[0].Cells["idCabOperation"].Value);
					this.toolStripButton_52.Enabled = true;
				}
			}
		}

		private void toolStripButton_113_Click(object sender, EventArgs e)
		{
			this.method_153();
		}

		private void toolStripButton_52_Click(object sender, EventArgs e)
		{
			this.toolStripButton_52.Enabled = false;
			int num = -1;
			if (this.bool_1)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tP_CabOperation, true, "WHERE id = " + this.dataGridView_6.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_170.Name].Value.ToString());
				this.class107_0.tP_CabOperation.Rows[0]["DateCommissioning"] = this.dateTimePicker_1.Value;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_CabOperation);
			}
			else if (this.treeView_0.SelectedNode != null && this.comboBox_0.SelectedValue != null && (int)this.comboBox_0.SelectedValue != -1)
			{
				Class107.Class260 @class = this.class107_0.tP_CabOperation.method_5();
				@class.idObjList = this.objList_0.Id;
				@class.DateDecommissioning = this.dateTimePicker_1.Value;
				@class.Reason = (int)this.comboBox_0.SelectedValue;
				@class.Deleted = false;
				this.class107_0.tP_CabOperation.method_0(@class);
				num = base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_CabOperation);
			}
			base.SelectSqlData(this.class107_0, this.class107_0.vP_CabOperation, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", this.objList_0.Id));
			this.bindingSource_1.Position = this.bindingSource_1.Find("Id", num);
			this.method_152((int)this.dataGridView_6.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_170.Name].Value);
			this.toolStripButton_52.Enabled = true;
		}

		private void toolStripButton_53_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				if (this.dataGridView_6.SelectedRows != null && this.dataGridView_6.SelectedRows.Count > 0)
				{
					base.SelectSqlData(this.class107_0, this.class107_0.vP_CabOperation, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))  order by Convert(datetime, dateDecommissioning, 104) desc", this.objList_0.Id));
					this.bindingSource_1.Position = this.bindingSource_1.Find("Id", (int)this.dataGridView_6.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_170.Name].Value);
					this.method_152((int)this.dataGridView_6.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_170.Name].Value);
					return;
				}
				base.SelectSqlData(this.class107_0, this.class107_0.vP_CabOperation, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))  order by Convert(datetime, dateDecommissioning, 104) desc", this.objList_0.Id));
				this.method_151();
			}
		}

		private void toolStripButton_54_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_6.SelectedRows != null && this.dataGridView_6.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tP_CabOperation, true, string.Format("WHERE id = {0} AND Deleted = ((0))", (int)this.dataGridView_6.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_170.Name].Value));
				this.class107_0.tP_CabOperation.Rows[0]["Deleted"] = true;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_CabOperation);
				base.SelectSqlData(this.class107_0, this.class107_0.vP_CabOperation, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", this.objList_0.Id));
				this.method_151();
			}
		}

		private void method_151()
		{
			if (this.class107_0.vP_CabOperation.Rows.Count == 0)
			{
				this.bool_1 = false;
				this.comboBox_0.Enabled = true;
				this.toolStripButton_52.Text = "Вывести";
				return;
			}
			this.dateTimePicker_1.Value = DateTime.Now;
			this.int_1 = (int)base.CallSQLScalarFunction("dbo.fn_GetIsAcceptCabOperation", new string[]
			{
				this.treeView_0.SelectedNode.Tag.ToString()
			});
			this.method_152(this.int_1);
		}

		private void method_152(int int_3)
		{
			this.bool_1 = (this.class107_0.vP_CabOperation.Select("id = " + int_3).First<DataRow>()["DateCommissioning"] == DBNull.Value);
			if (this.bool_1)
			{
				this.toolStripButton_52.Text = "Ввести";
				this.comboBox_0.Enabled = false;
				this.bool_1 = true;
				return;
			}
			this.toolStripButton_52.Text = "Вывести";
			this.comboBox_0.Enabled = true;
			this.bool_1 = false;
		}

		private void method_153()
		{
			if (this.treeView_0.SelectedNode != null && this.class107_0.vP_CabOperation.Rows.Count != 0 && this.class107_0.vP_CabOperation.Rows[0]["dateCommissioning"] == DBNull.Value)
			{
				FormAddEditCableOperation formAddEditCableOperation = new FormAddEditCableOperation(this.SqlSettings, 1, this.objList_0.Id);
				if (formAddEditCableOperation.ShowDialog() == DialogResult.OK)
				{
					base.SelectSqlData(this.class107_0.vP_CabOperation, true, string.Format("where idObjList = {0} and deleted = 0  order by Convert(datetime, dateDecommissioning, 104) desc", this.objList_0.Id), null, false, 0);
					this.bindingSource_1.Position = this.bindingSource_1.Find("Id", formAddEditCableOperation.Id);
					this.method_152((int)this.dataGridView_6.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_170.Name].Value);
					this.toolStripButton_52.Enabled = true;
				}
			}
		}

		private void dataGridView_6_SelectionChanged(object sender, EventArgs e)
		{
			if (this.dataGridView_6.SelectedRows != null && this.dataGridView_6.SelectedRows.Count > 0)
			{
				this.method_152((int)this.dataGridView_6.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_170.Name].Value);
			}
		}

		private void dataGridView_6_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_153();
		}

		private void vXopjPwjcu(object sender, EventArgs e)
		{
			if (this.dataGridView_7.SelectedRows != null && this.dataGridView_7.SelectedRows.Count > 0)
			{
				new Form4(this.SqlSettings, (int)this.dataGridView_7.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_12.Name].Value)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_56_Click(object sender, EventArgs e)
		{
			FormSurveyProtocolCable formSurveyProtocolCable = new FormSurveyProtocolCable(this.SqlSettings, -1, this.objList_0.Id, this.treeView_0.SelectedNode.Text, 0);
			formSurveyProtocolCable.MdiParent = base.MdiParent;
			formSurveyProtocolCable.FormClosed += this.method_155;
			formSurveyProtocolCable.Show();
		}

		private void toolStripButton_57_Click(object sender, EventArgs e)
		{
			this.method_156();
		}

		private void toolStripButton_58_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_7.SelectedRows != null && this.dataGridView_7.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.jtnAdxtlvN, this.jtnAdxtlvN.tP_CabProtocol, true, string.Format("WHERE id = {0} AND Deleted = ((0))", (int)this.dataGridView_7.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_12.Name].Value));
				this.jtnAdxtlvN.tP_CabProtocol.Rows[0]["Deleted"] = true;
				base.UpdateSqlData(this.jtnAdxtlvN, this.jtnAdxtlvN.tP_CabProtocol);
				base.SelectSqlData(this.jtnAdxtlvN, this.jtnAdxtlvN.tP_CabProtocol, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", this.objList_0.Id));
			}
		}

		private void toolStripButton_66_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_7.SelectedRows != null && this.dataGridView_7.SelectedRows.Count > 0)
			{
				new FormSurveyProtocolCable(this.SqlSettings, (int)this.dataGridView_7.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_12.Name].Value, this.objList_0.Id, this.treeView_0.SelectedNode.Text, 7)
				{
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripButton_59_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_7.SelectedRows != null && this.dataGridView_7.SelectedRows.Count > 0)
			{
				int num = (int)this.dataGridView_7.SelectedRows[0].Cells["idCabProtocol"].Value;
				base.SelectSqlData(this.jtnAdxtlvN, this.jtnAdxtlvN.tP_CabProtocol, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", this.objList_0.Id));
				this.bindingSource_3.Position = this.bindingSource_3.Find("id", num);
				return;
			}
			base.SelectSqlData(this.jtnAdxtlvN, this.jtnAdxtlvN.tP_CabProtocol, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", this.objList_0.Id));
		}

		private void method_154(int int_3, int int_4)
		{
			base.SelectSqlData(this.jtnAdxtlvN, this.jtnAdxtlvN.tP_CabProtocol, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", int_3));
			this.bindingSource_3.Position = this.bindingSource_3.Find("id", int_4);
		}

		private void method_155(object sender, FormClosedEventArgs e)
		{
			FormSurveyProtocolCable formSurveyProtocolCable = (FormSurveyProtocolCable)sender;
			if (formSurveyProtocolCable.DialogResult == DialogResult.OK)
			{
				this.method_154(this.objList_0.Id, formSurveyProtocolCable.IdProtocol);
			}
		}

		private void method_156()
		{
			if (this.dataGridView_7.SelectedRows != null && this.dataGridView_7.SelectedRows.Count > 0)
			{
				FormSurveyProtocolCable formSurveyProtocolCable = new FormSurveyProtocolCable(this.SqlSettings, (int)this.dataGridView_7.SelectedRows[0].Cells[this.dataGridViewTextBoxColumn_12.Name].Value, this.objList_0.Id, this.treeView_0.SelectedNode.Text, 1);
				formSurveyProtocolCable.MdiParent = base.MdiParent;
				formSurveyProtocolCable.FormClosed += this.method_155;
				formSurveyProtocolCable.Show();
			}
		}

		private void dataGridView_7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_156();
		}

		private void toolStripButton_71_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				FormAddEditCabPerambulation formAddEditCabPerambulation = new FormAddEditCabPerambulation(this.SqlSettings, this.objList_0.Id, 0);
				formAddEditCabPerambulation.FormClosed += this.method_157;
				formAddEditCabPerambulation.MdiParent = base.MdiParent;
				formAddEditCabPerambulation.Show();
			}
		}

		private void toolStripButton_72_Click(object sender, EventArgs e)
		{
			this.method_160();
		}

		private void toolStripButton_73_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.dataGridViewExcelFilter_1.SelectedRows[0].Cells["deletedPeram"].Value = true;
				this.bindingSource_5.EndEdit();
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_CabPerambulation);
				this.method_158(this.objList_0.Id);
			}
		}

		private void toolStripButton_74_Click(object sender, EventArgs e)
		{
			if (this.treeView_0.SelectedNode != null)
			{
				if (this.dataGridViewExcelFilter_1.SelectedRows != null && this.dataGridViewExcelFilter_1.SelectedRows.Count > 0)
				{
					this.method_159(this.objList_0.Id, (int)this.dataGridViewExcelFilter_1.SelectedRows[0].Cells["idPeram"].Value);
					return;
				}
				this.method_158(this.objList_0.Id);
			}
		}

		private void dataGridViewExcelFilter_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_160();
		}

		private void method_157(object sender, FormClosedEventArgs e)
		{
			FormAddEditCabPerambulation formAddEditCabPerambulation = (FormAddEditCabPerambulation)sender;
			if (formAddEditCabPerambulation.DialogResult == DialogResult.OK)
			{
				this.method_159(this.objList_0.Id, formAddEditCabPerambulation.Id);
			}
		}

		private void method_158(int int_3)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_CabPerambulation, true, string.Format("WHERE idObjList = {0} AND Deleted = ((0))", int_3));
			this.bindingSource_5.ResetBindings(false);
		}

		private void method_159(int int_3, int int_4)
		{
			this.method_158(int_3);
			this.bindingSource_5.Position = this.bindingSource_5.Find("id", int_4);
		}

		private void method_160()
		{
			if (this.dataGridViewExcelFilter_1.SelectedRows != null && this.dataGridViewExcelFilter_1.SelectedRows.Count > 0)
			{
				FormAddEditCabPerambulation formAddEditCabPerambulation = new FormAddEditCabPerambulation();
				formAddEditCabPerambulation.SqlSettings = this.SqlSettings;
				formAddEditCabPerambulation.Id = (int)this.dataGridViewExcelFilter_1.SelectedRows[0].Cells["idPeram"].Value;
				formAddEditCabPerambulation.IdObjList = this.objList_0.Id;
				formAddEditCabPerambulation.StateCreate = 1;
				formAddEditCabPerambulation.FormClosed += this.method_157;
				formAddEditCabPerambulation.MdiParent = base.MdiParent;
				formAddEditCabPerambulation.Show();
			}
		}

		private void toolStripButton_119_Click(object sender, EventArgs e)
		{
			FormSubstTestAddEdit formSubstTestAddEdit = new FormSubstTestAddEdit();
			formSubstTestAddEdit.SqlSettings = this.SqlSettings;
			formSubstTestAddEdit.MdiParent = base.MdiParent;
			formSubstTestAddEdit.CreateState = 0;
			formSubstTestAddEdit.IdObjList = this.objList_0.Id;
			formSubstTestAddEdit.Show();
			formSubstTestAddEdit.FormClosed -= this.method_164;
			formSubstTestAddEdit.FormClosed += this.method_164;
		}

		private void toolStripButton_120_Click(object sender, EventArgs e)
		{
			this.method_163();
		}

		private void toolStripButton_121_Click(object sender, EventArgs e)
		{
			if (this.bindingSource_11.Current == null)
			{
				return;
			}
			if (MessageBox.Show("Вы действительно хотите удалить выбранный документ испытания подстанции?", "?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
			{
				return;
			}
			int num = Convert.ToInt32(((DataRowView)this.bindingSource_11.Current)["id"]);
			DataView defaultView = this.class14_2.tP_DocList.DefaultView;
			defaultView.RowFilter = "id = " + num;
			defaultView[0]["deleted"] = true;
			defaultView[0]["isActive"] = false;
			defaultView[0].EndEdit();
			base.UpdateSqlDataOnlyChange(this.class14_2.tP_DocList);
			this.method_161();
		}

		private void toolStripButton_122_Click(object sender, EventArgs e)
		{
			this.method_161();
		}

		private void method_161()
		{
			string text = string.Format("where idObjList = '{0}' and deleted = '0' and typeDoc = '{1}'", this.objList_0.Id, this.method_162());
			base.SelectSqlData(this.class14_2.tP_DocList, true, text, null, false, 0);
			this.bindingSource_11.ResetBindings(false);
		}

		private int method_162()
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			base.SelectSqlData(dataTable, true, "where ParentKey = ';TypeDoc;tPassport;PS;' and Value = '6' and deleted = '0'", null, false, 0);
			if (dataTable.Rows.Count > 0)
			{
				return Convert.ToInt32(dataTable.Rows[0]["id"]);
			}
			return -1;
		}

		private void method_163()
		{
			if (this.bindingSource_11.Current == null)
			{
				return;
			}
			FormSubstTestAddEdit formSubstTestAddEdit = new FormSubstTestAddEdit(Convert.ToInt32(((DataRowView)this.bindingSource_11.Current)["id"]));
			formSubstTestAddEdit.SqlSettings = this.SqlSettings;
			formSubstTestAddEdit.MdiParent = base.MdiParent;
			formSubstTestAddEdit.CreateState = 1;
			formSubstTestAddEdit.IdObjList = this.objList_0.Id;
			formSubstTestAddEdit.Show();
			formSubstTestAddEdit.FormClosed -= this.method_164;
			formSubstTestAddEdit.FormClosed += this.method_164;
		}

		private void method_164(object sender, FormClosedEventArgs e)
		{
			if ((sender as FormSubstTestAddEdit).DialogResult == DialogResult.OK)
			{
				this.method_161();
			}
		}

		private void dataGridView_10_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_163();
		}

		private void toolStripButton_89_Click(object sender, EventArgs e)
		{
			if (this.objList_0 != null)
			{
				int num = (this.objList_0.GroupType == TypeObjListGroup.Substations) ? this.objList_0.Id : ((this.objList_0.GroupType == TypeObjListGroup.Switches) ? this.objList_0.IdParent : -1);
				int int_ = (this.objList_0.GroupType == TypeObjListGroup.Switches) ? this.objList_0.Id : -1;
				Form15 form = new Form15(this.SqlSettings, num, int_);
				form.MdiParent = base.MdiParent;
				form.FormClosed += this.method_165;
				form.Show();
				return;
			}
			MessageBox.Show("Внимание.", "Выберите подстанцию или трансформатор в дереве объектов", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void toolStripButton_90_Click(object sender, EventArgs e)
		{
			this.method_167();
		}

		private void toolStripButton_91_Click(object sender, EventArgs e)
		{
			if (this.bindingSource_8.Current != null && MessageBox.Show("Вы действительно хотите удалить запись", "Удаление.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tP_EESConnectPower, true, "where id = " + ((DataRowView)this.bindingSource_8.Current)["Id"].ToString());
				this.class107_0.tP_EESConnectPower.First<Class107.Class282>().Deleted = true;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_EESConnectPower);
				this.method_166();
			}
		}

		private void wudpxmqjwe(object sender, EventArgs e)
		{
			if (this.bindingSource_8.Current != null)
			{
				this.method_166();
				return;
			}
			this.JtUpwsnSse((int)((DataRowView)this.bindingSource_8.Current)["Id"]);
		}

		private void method_165(object sender, FormClosedEventArgs e)
		{
			Form15 form = (Form15)sender;
			if (form.DialogResult == DialogResult.OK)
			{
				this.JtUpwsnSse(form.method_0());
			}
		}

		private void dataGridViewExcelFilter_3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_167();
		}

		private void method_166()
		{
			string text = ((this.objList_0.GroupType == TypeObjListGroup.Substations) ? ("where idSubstation = " + this.objList_0.Id.ToString()) : ((this.objList_0.GroupType == TypeObjListGroup.Switches) ? ("where idSubstation = " + this.objList_0.IdParent.ToString() + " AND idTransf = " + this.objList_0.Id.ToString()) : "")) + " AND Deleted = ((0)) Order By NameTransf";
			base.SelectSqlData(this.class107_0, this.class107_0.vP_TehConnect, true, text);
		}

		private void JtUpwsnSse(int int_3)
		{
			this.method_166();
			this.bindingSource_8.Position = this.bindingSource_8.Find("Id", int_3);
		}

		private void method_167()
		{
			if (this.bindingSource_8.Current != null)
			{
				Form15 form = new Form15(this.SqlSettings, (int)((DataRowView)this.bindingSource_8.Current)["Id"]);
				form.MdiParent = base.MdiParent;
				form.FormClosed += this.method_165;
				form.Show();
			}
		}

		private void toolStripButton_99_Click(object sender, EventArgs e)
		{
			if (this.objList_0 != null)
			{
				FormPlanRenovationsAddEdit formPlanRenovationsAddEdit = new FormPlanRenovationsAddEdit((this.objList_0.GroupType == TypeObjListGroup.Substations) ? this.objList_0.Id : ((this.objList_0.GroupType == TypeObjListGroup.Switches) ? this.objList_0.IdParent : -1), null);
				formPlanRenovationsAddEdit.SqlSettings = this.SqlSettings;
				formPlanRenovationsAddEdit.MdiParent = base.MdiParent;
				formPlanRenovationsAddEdit.FormClosed += this.method_170;
				formPlanRenovationsAddEdit.Show();
				return;
			}
			MessageBox.Show("Внимание.", "Выберите подстанцию в дереве объектов", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void toolStripButton_100_Click(object sender, EventArgs e)
		{
			this.method_169();
		}

		private void toolStripButton_101_Click(object sender, EventArgs e)
		{
			if (this.bindingSource_9.Current != null && MessageBox.Show("Вы действительно хотите удалить строку?", "Удаление.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Class14.Class19 @class = new Class14.Class19();
				base.SelectSqlData(@class, true, string.Format("WHERE Id = {0}", (int)((DataRowView)this.bindingSource_9.Current)["Id"]), null, false, 0);
				if (@class.Rows.Count > 0)
				{
					@class.Rows[0]["Deleted"] = true;
					@class.Rows[0].EndEdit();
					base.UpdateSqlData(@class);
					this.method_168();
				}
			}
		}

		private void pRdPcudXaZ_Click(object sender, EventArgs e)
		{
			this.method_168();
		}

		private void method_168()
		{
			string text = ((this.objList_0.GroupType == TypeObjListGroup.Substations) ? ("where idObjList = " + this.objList_0.Id.ToString()) : ((this.objList_0.GroupType == TypeObjListGroup.Switches) ? ("where idObjList = " + this.objList_0.IdParent.ToString()) : "")) + " and typeDoc = 1353 AND Deleted = ((0)) and isActive = 1 Order By dateDoc desc";
			base.SelectSqlData(this.class14_0.tP_DocList, true, text, null, false, 0);
		}

		private void method_169()
		{
			if (this.bindingSource_9.Current != null)
			{
				FormPlanRenovationsAddEdit formPlanRenovationsAddEdit = new FormPlanRenovationsAddEdit((this.objList_0.GroupType == TypeObjListGroup.Substations) ? this.objList_0.Id : ((this.objList_0.GroupType == TypeObjListGroup.Switches) ? this.objList_0.IdParent : -1), new int?((int)((DataRowView)this.bindingSource_9.Current)["Id"]));
				formPlanRenovationsAddEdit.SqlSettings = this.SqlSettings;
				formPlanRenovationsAddEdit.MdiParent = base.MdiParent;
				formPlanRenovationsAddEdit.FormClosed += this.method_170;
				formPlanRenovationsAddEdit.Show();
			}
		}

		private void method_170(object sender, FormClosedEventArgs e)
		{
			this.method_168();
		}

		private void romYqlDtZh(object sender, DataGridViewCellEventArgs e)
		{
			this.method_169();
		}

		private void toolStripButton_102_Click(object sender, EventArgs e)
		{
			if (this.objList_0 != null)
			{
				Form2 form = new Form2((this.objList_0.GroupType == TypeObjListGroup.Substations) ? this.objList_0.Id : ((this.objList_0.GroupType == TypeObjListGroup.Switches) ? this.objList_0.IdParent : -1), null);
				form.SqlSettings = this.SqlSettings;
				form.MdiParent = base.MdiParent;
				form.FormClosed += this.method_173;
				form.Show();
				return;
			}
			MessageBox.Show("Внимание.", "Выберите подстанцию в дереве объектов", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void toolStripButton_103_Click(object sender, EventArgs e)
		{
			this.method_172();
		}

		private void toolStripButton_104_Click(object sender, EventArgs e)
		{
			if (this.bindingSource_10.Current != null && MessageBox.Show("Вы действительно хотите удалить выбранный документ?", "Удаление.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Class14.Class19 @class = new Class14.Class19();
				base.SelectSqlData(@class, true, string.Format("WHERE Id = {0}", (int)((DataRowView)this.bindingSource_10.Current)["Id"]), null, false, 0);
				if (@class.Rows.Count > 0)
				{
					@class.Rows[0]["Deleted"] = true;
					@class.Rows[0].EndEdit();
					base.UpdateSqlData(@class);
					this.method_171();
				}
			}
		}

		private void toolStripButton_105_Click(object sender, EventArgs e)
		{
			this.method_171();
		}

		private void method_171()
		{
			if (this.objList_0.GroupType != TypeObjListGroup.Substations && this.objList_0.GroupType != TypeObjListGroup.Switches)
			{
				this.class14_1.tP_DocList.Clear();
				return;
			}
			string text = ((this.objList_0.GroupType == TypeObjListGroup.Substations) ? ("where idObjList = " + this.objList_0.Id.ToString()) : ((this.objList_0.GroupType == TypeObjListGroup.Switches) ? ("where idObjList = " + this.objList_0.IdParent.ToString()) : "")) + " and typeDoc = 1374 AND Deleted = ((0)) and isActive = 1 Order By dateDoc desc";
			base.SelectSqlData(this.class14_1.tP_DocList, true, text, null, false, 0);
		}

		private void method_172()
		{
			if (this.bindingSource_10.Current != null)
			{
				Form2 form = new Form2((this.objList_0.GroupType == TypeObjListGroup.Substations) ? this.objList_0.Id : ((this.objList_0.GroupType == TypeObjListGroup.Switches) ? this.objList_0.IdParent : -1), new int?((int)((DataRowView)this.bindingSource_10.Current)["Id"]));
				form.SqlSettings = this.SqlSettings;
				form.MdiParent = base.MdiParent;
				form.FormClosed += this.method_173;
				form.Show();
			}
		}

		private void method_173(object sender, FormClosedEventArgs e)
		{
			this.method_171();
		}

		private void dataGridViewExcelFilter_5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_172();
		}

		private void toolStripButton_157_Click(object sender, EventArgs e)
		{
			this.method_174(new int?(this.objList_0.Id));
		}

		private void toolStripButton_158_Click(object sender, EventArgs e)
		{
			this.method_175(new int?(this.objList_0.Id));
		}

		private void toolStripButton_159_Click(object sender, EventArgs e)
		{
			this.method_176(new int?(this.objList_0.Id));
		}

		private void toolStripButton_160_Click(object sender, EventArgs e)
		{
			this.method_177(new int?(this.objList_0.Id));
		}

		private void toolStripButton_161_Click(object sender, EventArgs e)
		{
			this.method_178(new int?(this.objList_0.Id));
		}

		private void method_174(int? nullable_0)
		{
			if (nullable_0 == null)
			{
				return;
			}
			Form8 form = new Form8(Convert.ToInt32(nullable_0), -1);
			form.SqlSettings = this.SqlSettings;
			form.MdiParent = base.MdiParent;
			form.method_1(0);
			form.Show();
			form.FormClosed -= this.method_180;
			form.FormClosed += this.method_180;
		}

		private void method_175(int? nullable_0)
		{
			if (nullable_0 == null)
			{
				return;
			}
			if (this.bindingSource_14 != null && this.bindingSource_14.Current != null)
			{
				int int_ = Convert.ToInt32(((DataRowView)this.bindingSource_14.Current).Row["id"]);
				Form8 form = new Form8(Convert.ToInt32(nullable_0), int_);
				form.SqlSettings = this.SqlSettings;
				form.MdiParent = base.MdiParent;
				form.method_1(1);
				form.Show();
				form.FormClosed -= this.method_180;
				form.FormClosed += this.method_180;
				return;
			}
		}

		private void method_176(int? nullable_0)
		{
			if (nullable_0 == null)
			{
				return;
			}
			if (this.bindingSource_14 != null && this.bindingSource_14.Current != null)
			{
				int int_ = Convert.ToInt32(((DataRowView)this.bindingSource_14.Current).Row["id"]);
				Form8 form = new Form8(Convert.ToInt32(nullable_0), int_);
				form.SqlSettings = this.SqlSettings;
				form.MdiParent = base.MdiParent;
				form.method_1(11);
				form.Show();
				form.FormClosed -= this.method_180;
				form.FormClosed += this.method_180;
				return;
			}
		}

		private void method_177(int? nullable_0)
		{
			if (nullable_0 == null)
			{
				return;
			}
			if (this.bindingSource_14 == null || this.bindingSource_14.Current == null)
			{
				return;
			}
			if (MessageBox.Show("Вы действительно хотите удалить выделенную запись?", "?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
			{
				return;
			}
			int num = Convert.ToInt32(((DataRowView)this.bindingSource_14.Current).Row["id"]);
			if (new SqlDataCommand(this.SqlSettings).UpdateSqlData(new DataTable("tP_ObjAddress"), "set deleted = '1'", string.Format("where id = '{0}'", num)))
			{
				this.method_178(nullable_0);
			}
		}

		private void method_178(int? nullable_0)
		{
			if (nullable_0 == null)
			{
				return;
			}
			base.SelectSqlData(this.class107_0.vP_ObjAddress, true, string.Format("where idObjList = '{0}' and deleted = '0'", nullable_0), null, false, 0);
		}

		private void method_179(int? nullable_0, int int_3)
		{
			if (nullable_0 == null)
			{
				return;
			}
			this.method_178(nullable_0);
			BindingSource bindingSource = (BindingSource)this.dataGridView_15.DataSource;
			if (bindingSource != null)
			{
				bindingSource.Position = bindingSource.Find("id", int_3);
			}
		}

		private void method_180(object sender, FormClosedEventArgs e)
		{
			Form8 form = (Form8)sender;
			if (form.DialogResult == DialogResult.OK)
			{
				this.method_179(new int?(this.objList_0.Id), form.method_2());
			}
		}

		private void dataGridView_15_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int id = this.objList_0.Id;
			if (this.bindingSource_14 != null && this.bindingSource_14.Current != null)
			{
				this.method_175(new int?(this.objList_0.Id));
				return;
			}
		}

		private void toolStripButton_162_Click(object sender, EventArgs e)
		{
			this.method_181();
		}

		private void toolStripButton_163_Click(object sender, EventArgs e)
		{
			this.method_182();
		}

		private void toolStripButton_164_Click(object sender, EventArgs e)
		{
			this.method_183();
		}

		private void toolStripButton_165_Click(object sender, EventArgs e)
		{
			this.method_184(this.objList_0.Id);
		}

		private void toolStripButton_178_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_10.RowCount != 0 && this.dataGridViewExcelFilter_10.CurrentRow != null)
			{
				int idDoc = Convert.ToInt32(this.dataGridViewExcelFilter_10.CurrentRow.Cells[this.dataGridViewTextBoxColumn_227.Index].Value);
				int idTypeDoc = Convert.ToInt32(this.dataGridViewExcelFilter_10.CurrentRow.Cells[this.dataGridViewTextBoxColumn_229.Index].Value);
				new FormReportAirLineDocs(this.objList_0.Id, idDoc)
				{
					SqlSettings = this.SqlSettings,
					MdiParent = base.MdiParent,
					StartPosition = FormStartPosition.CenterScreen,
					IdTypeDoc = idTypeDoc
				}.Show();
				return;
			}
		}

		private void method_181()
		{
			int idDocType = this.method_116(";TypeDoc;tPassport;AirLine;", 1m);
			FormAirLineRepairAddEdit formAirLineRepairAddEdit = new FormAirLineRepairAddEdit(this.objList_0.Id, -1, idDocType);
			formAirLineRepairAddEdit.SqlSettings = this.SqlSettings;
			formAirLineRepairAddEdit.MdiParent = base.MdiParent;
			formAirLineRepairAddEdit.CreateState = 0;
			formAirLineRepairAddEdit.Show();
			formAirLineRepairAddEdit.FormClosed -= this.method_186;
			formAirLineRepairAddEdit.FormClosed += this.method_186;
		}

		private void method_182()
		{
			if (this.dataGridViewExcelFilter_10.RowCount != 0 && this.dataGridViewExcelFilter_10.CurrentRow != null)
			{
				int idDocType = Convert.ToInt32(this.dataGridViewExcelFilter_10.CurrentRow.Cells[this.dataGridViewTextBoxColumn_229.Index].Value);
				int idDoc = Convert.ToInt32(this.dataGridViewExcelFilter_10.CurrentRow.Cells[this.dataGridViewTextBoxColumn_227.Index].Value);
				FormAirLineRepairAddEdit formAirLineRepairAddEdit = new FormAirLineRepairAddEdit(this.objList_0.Id, idDoc, idDocType);
				formAirLineRepairAddEdit.SqlSettings = this.SqlSettings;
				formAirLineRepairAddEdit.MdiParent = base.MdiParent;
				formAirLineRepairAddEdit.CreateState = 1;
				formAirLineRepairAddEdit.Show();
				formAirLineRepairAddEdit.FormClosed -= this.method_186;
				formAirLineRepairAddEdit.FormClosed += this.method_186;
				return;
			}
		}

		private void method_183()
		{
			if (this.dataGridViewExcelFilter_10.RowCount == 0 || this.dataGridViewExcelFilter_10.CurrentRow == null)
			{
				return;
			}
			int int_ = Convert.ToInt32(this.dataGridViewExcelFilter_10.CurrentRow.Cells[this.dataGridViewTextBoxColumn_227.Index].Value);
			if (!this.method_205(int_))
			{
				return;
			}
			this.method_184(this.objList_0.Id);
		}

		private void method_184(int int_3)
		{
			string text = string.Format("select d.*, c_r.Name as Reason\r\nfrom (select doc.id, doc.ParentId, doc.idObjList, doc.NumberDoc, \r\n    doc.DateDoc, doc.TypeDoc, doc.Comment,\r\n    col.value('(./cmbReason)[1]', 'int') as idReason,\r\n    col.value('(./txtFrom)[1]', 'nvarchar(max)') as [From],\r\n    col.value('(./txtTo)[1]', 'nvarchar(max)') as [To],\r\n    col.value('(./txtDateStartUp)[1]', 'nvarchar(max)') as dateStartUp\r\n    from tP_DocList as doc\r\n    cross apply DataXml.nodes('/AddlData') x(col)\r\n    where idObjList = '{0}') as d\r\nleft join tR_Classifier as c_r on c_r.Id = idReason\r\ninner join tR_Classifier as c_d on c_d.Id = d.TypeDoc\r\nand c_d.ParentKey = ';TypeDoc;tPassport;AirLine;' and c_d.Value = '1'", int_3);
			DataTable dataSource = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			this.dataGridViewExcelFilter_10.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_10.DataSource = dataSource;
		}

		private void method_185(int int_3, int int_4)
		{
			this.method_184(int_3);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = this.dataGridViewExcelFilter_10.DataSource;
			bindingSource.Position = bindingSource.Find("id", int_4);
			this.dataGridViewExcelFilter_10.DataSource = bindingSource;
		}

		private void method_186(object sender, FormClosedEventArgs e)
		{
			FormAirLineRepairAddEdit formAirLineRepairAddEdit = (FormAirLineRepairAddEdit)sender;
			if (formAirLineRepairAddEdit.DialogResult == DialogResult.OK)
			{
				this.method_185(this.objList_0.Id, formAirLineRepairAddEdit.IdDoc);
			}
		}

		private void dataGridViewExcelFilter_10_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_182();
		}

		private void dataGridViewExcelFilter_10_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				this.dataGridViewExcelFilter_10.ContextMenuStrip = null;
				return;
			}
			this.dataGridViewExcelFilter_10.ContextMenuStrip = this.NawojBnvmy;
		}

		private void toolStripButton_166_Click(object sender, EventArgs e)
		{
			this.method_187();
		}

		private void toolStripButton_167_Click(object sender, EventArgs e)
		{
			this.method_188();
		}

		private void toolStripButton_168_Click(object sender, EventArgs e)
		{
			this.method_189();
		}

		private void toolStripButton_169_Click(object sender, EventArgs e)
		{
			this.method_190(this.objList_0.Id);
		}

		private void toolStripButton_179_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_11.RowCount != 0 && this.dataGridViewExcelFilter_11.CurrentRow != null)
			{
				int idDoc = Convert.ToInt32(this.dataGridViewExcelFilter_11.CurrentRow.Cells[this.ensobXmnxq.Index].Value);
				int idTypeDoc = Convert.ToInt32(this.dataGridViewExcelFilter_11.CurrentRow.Cells[this.dataGridViewTextBoxColumn_240.Index].Value);
				new FormReportAirLineDocs(this.objList_0.Id, idDoc)
				{
					SqlSettings = this.SqlSettings,
					MdiParent = base.MdiParent,
					StartPosition = FormStartPosition.CenterScreen,
					IdTypeDoc = idTypeDoc
				}.Show();
				return;
			}
		}

		private void method_187()
		{
			int idDocType = this.method_116(";TypeDoc;tPassport;AirLine;", 2m);
			FormAirLineRepairAddEdit formAirLineRepairAddEdit = new FormAirLineRepairAddEdit(this.objList_0.Id, -1, idDocType);
			formAirLineRepairAddEdit.SqlSettings = this.SqlSettings;
			formAirLineRepairAddEdit.MdiParent = base.MdiParent;
			formAirLineRepairAddEdit.CreateState = 0;
			formAirLineRepairAddEdit.Show();
			formAirLineRepairAddEdit.FormClosed -= this.method_192;
			formAirLineRepairAddEdit.FormClosed += this.method_192;
		}

		private void method_188()
		{
			if (this.dataGridViewExcelFilter_11.RowCount != 0 && this.dataGridViewExcelFilter_11.CurrentRow != null)
			{
				int idDocType = Convert.ToInt32(this.dataGridViewExcelFilter_11.CurrentRow.Cells[this.dataGridViewTextBoxColumn_240.Index].Value);
				int idDoc = Convert.ToInt32(this.dataGridViewExcelFilter_11.CurrentRow.Cells[this.ensobXmnxq.Index].Value);
				FormAirLineRepairAddEdit formAirLineRepairAddEdit = new FormAirLineRepairAddEdit(this.objList_0.Id, idDoc, idDocType);
				formAirLineRepairAddEdit.SqlSettings = this.SqlSettings;
				formAirLineRepairAddEdit.MdiParent = base.MdiParent;
				formAirLineRepairAddEdit.CreateState = 1;
				formAirLineRepairAddEdit.Show();
				formAirLineRepairAddEdit.FormClosed -= this.method_192;
				formAirLineRepairAddEdit.FormClosed += this.method_192;
				return;
			}
		}

		private void method_189()
		{
			if (this.dataGridViewExcelFilter_11.RowCount == 0 || this.dataGridViewExcelFilter_11.CurrentRow == null)
			{
				return;
			}
			int int_ = Convert.ToInt32(this.dataGridViewExcelFilter_11.CurrentRow.Cells[this.ensobXmnxq.Index].Value);
			if (!this.method_205(int_))
			{
				return;
			}
			this.method_190(this.objList_0.Id);
		}

		private void method_190(int int_3)
		{
			string text = string.Format("select d.*, c_r.Name as Reason\r\nfrom (select doc.id, doc.ParentId, doc.idObjList, doc.NumberDoc, \r\n    doc.DateDoc, doc.TypeDoc, doc.Comment,\r\n    col.value('(./cmbReason)[1]', 'int') as idReason,\r\n    col.value('(./txtFrom)[1]', 'nvarchar(max)') as [From],\r\n    col.value('(./txtTo)[1]', 'nvarchar(max)') as [To],\r\n    col.value('(./txtDateStartUp)[1]', 'nvarchar(max)') as dateStartUp\r\n    from tP_DocList as doc\r\n    cross apply DataXml.nodes('/AddlData') x(col)\r\n    where idObjList = '{0}') as d\r\nleft join tR_Classifier as c_r on c_r.Id = idReason\r\ninner join tR_Classifier as c_d on c_d.Id = d.TypeDoc\r\nand c_d.ParentKey = ';TypeDoc;tPassport;AirLine;' and c_d.Value = '2'", int_3);
			DataTable dataSource = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			this.dataGridViewExcelFilter_11.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_11.DataSource = dataSource;
		}

		private void method_191(int int_3, int int_4)
		{
			this.method_190(int_3);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = this.dataGridViewExcelFilter_11.DataSource;
			bindingSource.Position = bindingSource.Find("id", int_4);
			this.dataGridViewExcelFilter_11.DataSource = bindingSource;
		}

		private void method_192(object sender, FormClosedEventArgs e)
		{
			FormAirLineRepairAddEdit formAirLineRepairAddEdit = (FormAirLineRepairAddEdit)sender;
			if (formAirLineRepairAddEdit.DialogResult == DialogResult.OK)
			{
				this.method_191(this.objList_0.Id, formAirLineRepairAddEdit.IdDoc);
			}
		}

		private void dataGridViewExcelFilter_11_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_188();
		}

		private void dataGridViewExcelFilter_11_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				this.dataGridViewExcelFilter_11.ContextMenuStrip = null;
				return;
			}
			this.dataGridViewExcelFilter_11.ContextMenuStrip = this.contextMenuStrip_17;
		}

		private void toolStripButton_173_Click(object sender, EventArgs e)
		{
			this.method_193();
		}

		private void toolStripButton_170_Click(object sender, EventArgs e)
		{
			this.method_194();
		}

		private void toolStripButton_171_Click(object sender, EventArgs e)
		{
			this.method_195();
		}

		private void toolStripButton_172_Click(object sender, EventArgs e)
		{
			this.method_196(this.objList_0.Id);
		}

		private void toolStripButton_181_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_12.RowCount != 0 && this.dataGridViewExcelFilter_12.CurrentRow != null)
			{
				int idDoc = Convert.ToInt32(this.dataGridViewExcelFilter_12.CurrentRow.Cells[this.dataGridViewTextBoxColumn_247.Index].Value);
				int idTypeDoc = Convert.ToInt32(this.dataGridViewExcelFilter_12.CurrentRow.Cells[this.dataGridViewTextBoxColumn_249.Index].Value);
				new FormReportAirLineDocs(this.objList_0.Id, idDoc)
				{
					SqlSettings = this.SqlSettings,
					MdiParent = base.MdiParent,
					StartPosition = FormStartPosition.CenterScreen,
					IdTypeDoc = idTypeDoc
				}.Show();
				return;
			}
		}

		private void method_193()
		{
			int idDocType = this.method_116(";TypeDoc;tPassport;AirLine;", 4m);
			FormPylonEquipRepairAddEdit formPylonEquipRepairAddEdit = new FormPylonEquipRepairAddEdit(this.objList_0.Id, -1, idDocType);
			formPylonEquipRepairAddEdit.SqlSettings = this.SqlSettings;
			formPylonEquipRepairAddEdit.MdiParent = base.MdiParent;
			formPylonEquipRepairAddEdit.CreateState = 0;
			formPylonEquipRepairAddEdit.Show();
			formPylonEquipRepairAddEdit.FormClosed -= this.method_198;
			formPylonEquipRepairAddEdit.FormClosed += this.method_198;
		}

		private void method_194()
		{
			if (this.dataGridViewExcelFilter_12.RowCount != 0 && this.dataGridViewExcelFilter_12.CurrentRow != null)
			{
				int idDocType = Convert.ToInt32(this.dataGridViewExcelFilter_12.CurrentRow.Cells[this.dataGridViewTextBoxColumn_249.Index].Value);
				int idDoc = Convert.ToInt32(this.dataGridViewExcelFilter_12.CurrentRow.Cells[this.dataGridViewTextBoxColumn_247.Index].Value);
				FormPylonEquipRepairAddEdit formPylonEquipRepairAddEdit = new FormPylonEquipRepairAddEdit(this.objList_0.Id, idDoc, idDocType);
				formPylonEquipRepairAddEdit.SqlSettings = this.SqlSettings;
				formPylonEquipRepairAddEdit.MdiParent = base.MdiParent;
				formPylonEquipRepairAddEdit.CreateState = 1;
				formPylonEquipRepairAddEdit.Show();
				formPylonEquipRepairAddEdit.FormClosed -= this.method_198;
				formPylonEquipRepairAddEdit.FormClosed += this.method_198;
				return;
			}
		}

		private void method_195()
		{
			if (this.dataGridViewExcelFilter_12.RowCount == 0 || this.dataGridViewExcelFilter_12.CurrentRow == null)
			{
				return;
			}
			int int_ = Convert.ToInt32(this.dataGridViewExcelFilter_12.CurrentRow.Cells[this.dataGridViewTextBoxColumn_247.Index].Value);
			if (!this.method_205(int_))
			{
				return;
			}
			this.method_196(this.objList_0.Id);
		}

		private void method_196(int int_3)
		{
			string text = string.Format("select d.*, c_r.Name as Reason, c_w.Name as typeWorkName, \r\nol_p.Name as Pylon, ol_eq.Name as Equipment\r\nfrom (select doc.id, doc.ParentId, doc.idObjList, doc.NumberDoc, \r\n    doc.DateDoc, doc.TypeDoc, doc.Comment,\r\n    col.value('(./cmbTypeWork)[1]', 'int') as idTypeWork,\r\n    col.value('(./cmbReason)[1]', 'int') as idReason,\r\n    col.value('(./cmbPylon)[1]', 'nvarchar(max)') as idPylon,\r\n    col.value('(./cmbEquipment)[1]', 'nvarchar(max)') as idEquipment\r\n    from tP_DocList as doc\r\n    cross apply DataXml.nodes('/AddlData') x(col)\r\n    where idObjList = '{0}') as d\r\nleft join tR_Classifier as c_r on c_r.Id = idReason\r\nleft join tR_Classifier as c_w on c_w.Id = idTypeWork\r\nleft join tSchm_ObjList as ol_p on ol_p.Id = idPylon\r\nleft join tSchm_ObjList as ol_eq on ol_eq.Id = idEquipment\r\ninner join tR_Classifier as c_d on c_d.Id = d.TypeDoc\r\nand c_d.ParentKey = ';TypeDoc;tPassport;AirLine;' and c_d.Value = '4'", int_3);
			DataTable dataSource = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			this.dataGridViewExcelFilter_12.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_12.DataSource = dataSource;
		}

		private void method_197(int int_3, int int_4)
		{
			this.method_196(int_3);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = this.dataGridViewExcelFilter_12.DataSource;
			bindingSource.Position = bindingSource.Find("id", int_4);
			this.dataGridViewExcelFilter_12.DataSource = bindingSource;
		}

		private void method_198(object sender, FormClosedEventArgs e)
		{
			FormPylonEquipRepairAddEdit formPylonEquipRepairAddEdit = (FormPylonEquipRepairAddEdit)sender;
			if (formPylonEquipRepairAddEdit.DialogResult == DialogResult.OK)
			{
				this.method_197(this.objList_0.Id, formPylonEquipRepairAddEdit.IdDoc);
			}
		}

		private void dataGridViewExcelFilter_12_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_194();
		}

		private void dataGridViewExcelFilter_12_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				this.dataGridViewExcelFilter_12.ContextMenuStrip = null;
				return;
			}
			this.dataGridViewExcelFilter_12.ContextMenuStrip = this.contextMenuStrip_16;
		}

		private void toolStripMenuItem_85_Click(object sender, EventArgs e)
		{
			this.method_199();
		}

		private void toolStripMenuItem_86_Click(object sender, EventArgs e)
		{
			this.method_200();
		}

		private void toolStripMenuItem_87_Click(object sender, EventArgs e)
		{
			this.method_201();
		}

		private void toolStripMenuItem_88_Click(object sender, EventArgs e)
		{
			this.method_202(this.objList_0.Id);
		}

		private void contextMenuStrip_18_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_16.RowCount != 0 && this.dataGridView_16.CurrentRow != null)
			{
				int idDoc = Convert.ToInt32(this.dataGridView_16.CurrentRow.Cells[this.dataGridViewTextBoxColumn_261.Index].Value);
				int idTypeDoc = Convert.ToInt32(this.dataGridView_16.CurrentRow.Cells[this.dataGridViewTextBoxColumn_263.Index].Value);
				new FormReportAirLineDocs(this.objList_0.Id, idDoc)
				{
					SqlSettings = this.SqlSettings,
					MdiParent = base.MdiParent,
					StartPosition = FormStartPosition.CenterScreen,
					IdTypeDoc = idTypeDoc
				}.Show();
				return;
			}
		}

		private void method_199()
		{
			FormAirLineInspectionAddEdit formAirLineInspectionAddEdit = new FormAirLineInspectionAddEdit(this.objList_0.Id, -1);
			formAirLineInspectionAddEdit.SqlSettings = this.SqlSettings;
			formAirLineInspectionAddEdit.MdiParent = base.MdiParent;
			formAirLineInspectionAddEdit.StartPosition = FormStartPosition.CenterParent;
			formAirLineInspectionAddEdit.CreateState = 0;
			formAirLineInspectionAddEdit.Show();
			formAirLineInspectionAddEdit.FormClosed -= this.method_204;
			formAirLineInspectionAddEdit.FormClosed += this.method_204;
		}

		private void method_200()
		{
			if (this.dataGridView_16.RowCount != 0 && this.dataGridView_16.CurrentRow != null)
			{
				int idDoc = Convert.ToInt32(this.dataGridView_16.CurrentRow.Cells[this.dataGridViewTextBoxColumn_261.Index].Value);
				FormAirLineInspectionAddEdit formAirLineInspectionAddEdit = new FormAirLineInspectionAddEdit(this.objList_0.Id, idDoc);
				formAirLineInspectionAddEdit.SqlSettings = this.SqlSettings;
				formAirLineInspectionAddEdit.MdiParent = base.MdiParent;
				formAirLineInspectionAddEdit.StartPosition = FormStartPosition.CenterParent;
				formAirLineInspectionAddEdit.CreateState = 1;
				formAirLineInspectionAddEdit.Show();
				formAirLineInspectionAddEdit.FormClosed -= this.method_204;
				formAirLineInspectionAddEdit.FormClosed += this.method_204;
				return;
			}
		}

		private void method_201()
		{
			if (this.dataGridView_16.RowCount == 0 || this.dataGridView_16.SelectedRows.Count == 0)
			{
				return;
			}
			if (MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
			{
				return;
			}
			int num = Convert.ToInt32(this.dataGridView_16.CurrentRow.Cells[this.dataGridViewTextBoxColumn_261.Index].Value);
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			string text = string.Format("where id = '{0}'", num);
			if (sqlDataCommand.UpdateSqlData(new DataTable("tP_DocList"), "set deleted = '1', isActive = '0'", text))
			{
				this.method_202(this.objList_0.Id);
			}
		}

		private void method_202(int int_3)
		{
			int num = this.method_116(";TypeDoc;tPassport;AirLine;", 5m);
			string text = string.Format("select doc.id, doc.idObjList, doc.typeDoc, doc.numberDoc, doc.dateDoc\r\nfrom tP_DocList as doc\r\nwhere doc.idObjList = '{0}' and doc.typeDoc = '{1}' and doc.deleted = '0'", this.objList_0.Id, num);
			DataTable dataSource = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dataSource;
			this.dataGridView_16.AutoGenerateColumns = false;
			this.dataGridView_16.DataSource = bindingSource;
		}

		private void method_203(int int_3, int int_4)
		{
			this.method_202(int_3);
			BindingSource bindingSource = (BindingSource)this.dataGridView_16.DataSource;
			if (bindingSource != null)
			{
				bindingSource.Position = bindingSource.Find("id", int_4);
			}
		}

		private void method_204(object sender, FormClosedEventArgs e)
		{
			FormAirLineInspectionAddEdit formAirLineInspectionAddEdit = (FormAirLineInspectionAddEdit)sender;
			if (formAirLineInspectionAddEdit.DialogResult == DialogResult.OK)
			{
				this.method_203(this.objList_0.Id, formAirLineInspectionAddEdit.IdDoc);
			}
			formAirLineInspectionAddEdit.Dispose();
		}

		private void dataGridView_16_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_200();
		}

		private void dataGridView_16_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				if (e.ColumnIndex != -1)
				{
					this.dataGridView_16.ContextMenuStrip = this.contextMenuStrip_18;
					return;
				}
			}
			this.dataGridView_16.ContextMenuStrip = null;
		}

		private bool method_205(int int_3)
		{
			if (MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
			{
				return false;
			}
			string text = string.Format("where id = '{0}'", int_3);
			return new SqlDataCommand(this.SqlSettings).UpdateSqlData(new DataTable("tP_DocList"), "set deleted = '1', isActive = '0'", text);
		}

		private void method_206(object sender, FormClosingEventArgs e)
		{
			this.method_77();
			this.method_73();
		}

		private void toolStripButton_150_Click(object sender, EventArgs e)
		{
			if (this.objList_0 != null && (this.objList_0.Type == TypeObjList.LineCable || this.objList_0.Type == TypeObjList.SwitchTransf || this.objList_0.Type == TypeObjList.LineAir || this.objList_0.Type == TypeObjList.LineProtectedAir))
			{
				FormCable formCable = new FormCable();
				formCable.FormClosed += this.method_207;
				formCable.MdiParent = base.MdiParent;
				formCable.SqlSettings = this.SqlSettings;
				formCable.ViewButtons = true;
				formCable.Show();
			}
		}

		private void method_207(object sender, FormClosedEventArgs e)
		{
			FormCable formCable = (FormCable)sender;
			if (formCable.DialogResult == DialogResult.OK)
			{
				this.method_208(formCable.Id);
				this.dataGridViewPassport_0.UpdateData();
			}
		}

		private void method_208(int int_3)
		{
			if (this.objList_0.IdPassport != -1)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tP_Passport, true, "WHERE id = " + this.objList_0.IdPassport.ToString());
				this.class107_0.tP_Passport.First<Class107.Class257>().idEquipment = int_3;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_Passport);
				return;
			}
			Class107.Class257 @class = this.class107_0.tP_Passport.method_5();
			@class.idEquipment = int_3;
			@class.idObjList = this.objList_0.Id;
			@class.Number = 0;
			@class.Date = DateTime.Now;
			@class.DateIn = DateTime.Now;
			@class.isActive = true;
			@class.Deleted = false;
			this.class107_0.tP_Passport.method_0(@class);
			base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_Passport);
			this.objList_0.Id = this.objList_0.Id;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_209()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormDockPassport));
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle49 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle50 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle51 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle52 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle53 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle54 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle55 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle56 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle57 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle58 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle59 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle60 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle61 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle62 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle63 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle64 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle65 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle66 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle67 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle68 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle69 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle70 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle71 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle72 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle73 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle74 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle75 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle76 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle77 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle78 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle79 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle80 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle81 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle82 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle83 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle84 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle85 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle86 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle87 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle88 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle89 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle90 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle91 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle92 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle93 = new DataGridViewCellStyle();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.splitContainer_0 = new SplitContainer();
			this.tableLayoutPanel_1 = new TableLayoutPanel();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripTextBox_0 = new ToolStripTextBox();
			this.EgvhzrfdWJ = new ToolStripButton();
			this.toolStripButton_4 = new ToolStripButton();
			this.toolStripSeparator_40 = new ToolStripSeparator();
			this.toolStripButton_60 = new ToolStripButton();
			this.panel_0 = new Panel();
			this.treeView_0 = new TreeView();
			this.tabControl_0 = new TabControl();
			this.tabPage_0 = new TabPage();
			this.tableLayoutPanel_2 = new TableLayoutPanel();
			this.ehAutNuOxy = new TableLayoutPanel();
			this.label_0 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.label_1 = new Label();
			this.label_3 = new Label();
			this.label_2 = new Label();
			this.tabControl_2 = new TabControl();
			this.tabPage_6 = new TabPage();
			this.tableLayoutPanel_5 = new TableLayoutPanel();
			this.dataGridView_2 = new DataGridView();
			this.dataGridViewTextBoxColumn_147 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_148 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_149 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_150 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_151 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_152 = new DataGridViewTextBoxColumn();
			this.xhAdvgBiFT = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_153 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_154 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_155 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_156 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_157 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_1 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripMenuItem_2 = new ToolStripMenuItem();
			this.toolStripSeparator_13 = new ToolStripSeparator();
			this.toolStripMenuItem_3 = new ToolStripMenuItem();
			this.toolStripSeparator_14 = new ToolStripSeparator();
			this.toolStripMenuItem_4 = new ToolStripMenuItem();
			this.toolStrip_8 = new ToolStrip();
			this.toolStripButton_28 = new ToolStripButton();
			this.toolStripButton_29 = new ToolStripButton();
			this.toolStripSeparator_9 = new ToolStripSeparator();
			this.toolStripButton_30 = new ToolStripButton();
			this.toolStripSeparator_10 = new ToolStripSeparator();
			this.toolStripButton_31 = new ToolStripButton();
			this.tabPage_7 = new TabPage();
			this.tableLayoutPanel_6 = new TableLayoutPanel();
			this.dataGridView_3 = new DataGridView();
			this.dataGridViewTextBoxColumn_187 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_188 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_189 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_190 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_191 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_192 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_193 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_194 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_195 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_196 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_197 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_198 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_199 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_200 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_201 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_202 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_203 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_2 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_5 = new ToolStripMenuItem();
			this.toolStripMenuItem_6 = new ToolStripMenuItem();
			this.toolStripSeparator_15 = new ToolStripSeparator();
			this.toolStripMenuItem_7 = new ToolStripMenuItem();
			this.toolStripSeparator_16 = new ToolStripSeparator();
			this.toolStripMenuItem_8 = new ToolStripMenuItem();
			this.toolStrip_9 = new ToolStrip();
			this.toolStripButton_32 = new ToolStripButton();
			this.toolStripDropDownButton_2 = new ToolStripDropDownButton();
			this.toolStripMenuItem_63 = new ToolStripMenuItem();
			this.toolStripMenuItem_64 = new ToolStripMenuItem();
			this.toolStripButton_33 = new ToolStripButton();
			this.toolStripSeparator_11 = new ToolStripSeparator();
			this.toolStripButton_34 = new ToolStripButton();
			this.toolStripSeparator_12 = new ToolStripSeparator();
			this.toolStripButton_35 = new ToolStripButton();
			this.tabPage_8 = new TabPage();
			this.tableLayoutPanel_7 = new TableLayoutPanel();
			this.dataGridView_4 = new DataGridView();
			this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_3 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_9 = new ToolStripMenuItem();
			this.toolStripMenuItem_10 = new ToolStripMenuItem();
			this.toolStripSeparator_19 = new ToolStripSeparator();
			this.toolStripMenuItem_11 = new ToolStripMenuItem();
			this.toolStripSeparator_20 = new ToolStripSeparator();
			this.toolStripMenuItem_12 = new ToolStripMenuItem();
			this.toolStrip_10 = new ToolStrip();
			this.toolStripButton_36 = new ToolStripButton();
			this.toolStripButton_37 = new ToolStripButton();
			this.toolStripSeparator_17 = new ToolStripSeparator();
			this.toolStripButton_38 = new ToolStripButton();
			this.toolStripSeparator_18 = new ToolStripSeparator();
			this.toolStripButton_39 = new ToolStripButton();
			this.toolStripButton_40 = new ToolStripButton();
			this.tabPage_9 = new TabPage();
			this.tableLayoutPanel_9 = new TableLayoutPanel();
			this.dataGridView_5 = new DataGridView();
			this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_6 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_24 = new ToolStripMenuItem();
			this.toolStripMenuItem_25 = new ToolStripMenuItem();
			this.toolStripSeparator_31 = new ToolStripSeparator();
			this.toolStripMenuItem_26 = new ToolStripMenuItem();
			this.toolStripSeparator_32 = new ToolStripSeparator();
			this.toolStripMenuItem_27 = new ToolStripMenuItem();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.class107_0 = new Class107();
			this.ErxDoVobWm = new ToolStrip();
			this.toolStripButton_48 = new ToolStripButton();
			this.toolStripButton_49 = new ToolStripButton();
			this.toolStripSeparator_29 = new ToolStripSeparator();
			this.toolStripButton_50 = new ToolStripButton();
			this.toolStripSeparator_30 = new ToolStripSeparator();
			this.toolStripButton_51 = new ToolStripButton();
			this.tabPage_10 = new TabPage();
			this.tableLayoutPanel_10 = new TableLayoutPanel();
			this.dataGridView_6 = new DataGridView();
			this.dataGridViewCheckBoxColumn_10 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_170 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_171 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_172 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_173 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_174 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_175 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_176 = new DataGridViewTextBoxColumn();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.toolStrip_13 = new ToolStrip();
			this.toolStripSeparator_33 = new ToolStripSeparator();
			this.toolStripButton_52 = new ToolStripButton();
			this.toolStripSeparator_35 = new ToolStripSeparator();
			this.toolStripButton_112 = new ToolStripButton();
			this.toolStripButton_113 = new ToolStripButton();
			this.toolStripButton_54 = new ToolStripButton();
			this.toolStripSeparator_34 = new ToolStripSeparator();
			this.toolStripButton_53 = new ToolStripButton();
			this.pjuAjnsoym = new TabPage();
			this.tableLayoutPanel_11 = new TableLayoutPanel();
			this.dataGridView_7 = new DataGridView();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_7 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_28 = new ToolStripMenuItem();
			this.toolStripMenuItem_29 = new ToolStripMenuItem();
			this.toolStripSeparator_37 = new ToolStripSeparator();
			this.toolStripMenuItem_34 = new ToolStripMenuItem();
			this.toolStripMenuItem_35 = new ToolStripMenuItem();
			this.toolStripSeparator_36 = new ToolStripSeparator();
			this.toolStripMenuItem_30 = new ToolStripMenuItem();
			this.toolStripSeparator_45 = new ToolStripSeparator();
			this.toolStripMenuItem_31 = new ToolStripMenuItem();
			this.bindingSource_3 = new BindingSource(this.icontainer_0);
			this.jtnAdxtlvN = new Class14();
			this.toolStrip_14 = new ToolStrip();
			this.toolStripButton_56 = new ToolStripButton();
			this.toolStripButton_57 = new ToolStripButton();
			this.toolStripSeparator_38 = new ToolStripSeparator();
			this.toolStripButton_58 = new ToolStripButton();
			this.toolStripSeparator_44 = new ToolStripSeparator();
			this.toolStripButton_66 = new ToolStripButton();
			this.toolStripButton_55 = new ToolStripButton();
			this.toolStripSeparator_39 = new ToolStripSeparator();
			this.toolStripButton_59 = new ToolStripButton();
			this.tabPage_11 = new TabPage();
			this.tableLayoutPanel_12 = new TableLayoutPanel();
			this.toolStrip_15 = new ToolStrip();
			this.toolStripButton_61 = new ToolStripButton();
			this.toolStripButton_65 = new ToolStripButton();
			this.toolStripSeparator_41 = new ToolStripSeparator();
			this.toolStripButton_62 = new ToolStripButton();
			this.toolStripSeparator_42 = new ToolStripSeparator();
			this.toolStripButton_63 = new ToolStripButton();
			this.toolStripSeparator_43 = new ToolStripSeparator();
			this.toolStripButton_64 = new ToolStripButton();
			this.dataGridView_8 = new DataGridView();
			this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
			this.tabPage_13 = new TabPage();
			this.toolStrip_17 = new ToolStrip();
			this.toolStripButton_71 = new ToolStripButton();
			this.toolStripButton_72 = new ToolStripButton();
			this.toolStripSeparator_47 = new ToolStripSeparator();
			this.toolStripButton_73 = new ToolStripButton();
			this.toolStripSeparator_48 = new ToolStripSeparator();
			this.toolStripButton_74 = new ToolStripButton();
			this.tableLayoutPanel_14 = new TableLayoutPanel();
			this.dataGridViewExcelFilter_1 = new DataGridViewExcelFilter();
			this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_53 = new DataGridViewTextBoxColumn();
			this.bindingSource_5 = new BindingSource(this.icontainer_0);
			this.tabPage_15 = new TabPage();
			this.toolStrip_21 = new ToolStrip();
			this.toolStripButton_89 = new ToolStripButton();
			this.toolStripButton_90 = new ToolStripButton();
			this.toolStripSeparator_66 = new ToolStripSeparator();
			this.toolStripButton_91 = new ToolStripButton();
			this.toolStripSeparator_67 = new ToolStripSeparator();
			this.toolStripButton_92 = new ToolStripButton();
			this.tableLayoutPanel_16 = new TableLayoutPanel();
			this.dataGridViewExcelFilter_3 = new DataGridViewExcelFilter();
			this.dataGridViewCheckBoxColumn_3 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_54 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_55 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_56 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_57 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_58 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_59 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_60 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_61 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_62 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_63 = new DataGridViewTextBoxColumn();
			this.bindingSource_8 = new BindingSource(this.icontainer_0);
			this.tabPage_18 = new TabPage();
			this.dataGridViewExcelFilter_4 = new DataGridViewExcelFilter();
			this.dataGridViewCheckBoxColumn_4 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_5 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_95 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_96 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_97 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_98 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_99 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_100 = new DataGridViewTextBoxColumn();
			this.bindingSource_9 = new BindingSource(this.icontainer_0);
			this.class14_0 = new Class14();
			this.toolStrip_23 = new ToolStrip();
			this.toolStripButton_99 = new ToolStripButton();
			this.toolStripButton_100 = new ToolStripButton();
			this.toolStripSeparator_71 = new ToolStripSeparator();
			this.toolStripButton_101 = new ToolStripButton();
			this.toolStripSeparator_72 = new ToolStripSeparator();
			this.pRdPcudXaZ = new ToolStripButton();
			this.tabPage_19 = new TabPage();
			this.dataGridViewExcelFilter_5 = new DataGridViewExcelFilter();
			this.dataGridViewCheckBoxColumn_12 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_13 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_217 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_218 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_219 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_220 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_221 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_222 = new DataGridViewTextBoxColumn();
			this.lrkgwoojrG = new DataGridViewTextBoxColumn();
			this.bindingSource_10 = new BindingSource(this.icontainer_0);
			this.class14_1 = new Class14();
			this.toolStrip_24 = new ToolStrip();
			this.toolStripButton_102 = new ToolStripButton();
			this.toolStripButton_103 = new ToolStripButton();
			this.toolStripSeparator_73 = new ToolStripSeparator();
			this.toolStripButton_104 = new ToolStripButton();
			this.toolStripSeparator_74 = new ToolStripSeparator();
			this.toolStripButton_105 = new ToolStripButton();
			this.tabPage_21 = new TabPage();
			this.dataGridView_10 = new DataGridView();
			this.dataGridViewCheckBoxColumn_6 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_7 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_101 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_102 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_103 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_104 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_105 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_106 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_107 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_108 = new DataGridViewTextBoxColumn();
			this.bindingSource_11 = new BindingSource(this.icontainer_0);
			this.class14_2 = new Class14();
			this.toolStrip_27 = new ToolStrip();
			this.toolStripButton_119 = new ToolStripButton();
			this.toolStripButton_120 = new ToolStripButton();
			this.toolStripSeparator_83 = new ToolStripSeparator();
			this.toolStripButton_121 = new ToolStripButton();
			this.toolStripSeparator_84 = new ToolStripSeparator();
			this.toolStripButton_122 = new ToolStripButton();
			this.tabPage_30 = new TabPage();
			this.dataGridView_15 = new DataGridView();
			this.dataGridViewCheckBoxColumn_11 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_204 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_205 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_206 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_207 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_208 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_209 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_210 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_211 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_212 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_213 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_214 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_215 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_216 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_14 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_65 = new ToolStripMenuItem();
			this.toolStripMenuItem_66 = new ToolStripMenuItem();
			this.toolStripMenuItem_67 = new ToolStripMenuItem();
			this.toolStripMenuItem_68 = new ToolStripMenuItem();
			this.bindingSource_14 = new BindingSource(this.icontainer_0);
			this.toolStrip_34 = new ToolStrip();
			this.toolStripButton_157 = new ToolStripButton();
			this.toolStripButton_158 = new ToolStripButton();
			this.toolStripButton_159 = new ToolStripButton();
			this.toolStripButton_160 = new ToolStripButton();
			this.toolStripSeparator_99 = new ToolStripSeparator();
			this.toolStripButton_161 = new ToolStripButton();
			this.tabPage_31 = new TabPage();
			this.dataGridViewExcelFilter_10 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_227 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_228 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_229 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_230 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_231 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_232 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_233 = new DataGridViewTextBoxColumn();
			this.ikuogYtqqM = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_234 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_235 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_236 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_237 = new DataGridViewTextBoxColumn();
			this.NawojBnvmy = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_73 = new ToolStripMenuItem();
			this.toolStripMenuItem_74 = new ToolStripMenuItem();
			this.toolStripMenuItem_75 = new ToolStripMenuItem();
			this.toolStripMenuItem_76 = new ToolStripMenuItem();
			this.toolStripSeparator_103 = new ToolStripSeparator();
			this.toolStripMenuItem_89 = new ToolStripMenuItem();
			this.toolStrip_35 = new ToolStrip();
			this.toolStripButton_162 = new ToolStripButton();
			this.toolStripButton_163 = new ToolStripButton();
			this.toolStripButton_164 = new ToolStripButton();
			this.toolStripButton_165 = new ToolStripButton();
			this.toolStripSeparator_100 = new ToolStripSeparator();
			this.toolStripButton_178 = new ToolStripButton();
			this.tabPage_32 = new TabPage();
			this.dataGridViewExcelFilter_11 = new DataGridViewExcelFilter();
			this.ensobXmnxq = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_238 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_239 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_240 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_241 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_242 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_243 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_244 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_245 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_246 = new DataGridViewTextBoxColumn();
			this.mTiRmHbeJe = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_17 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_81 = new ToolStripMenuItem();
			this.toolStripMenuItem_82 = new ToolStripMenuItem();
			this.toolStripMenuItem_83 = new ToolStripMenuItem();
			this.toolStripMenuItem_84 = new ToolStripMenuItem();
			this.toolStripSeparator_104 = new ToolStripSeparator();
			this.toolStripMenuItem_90 = new ToolStripMenuItem();
			this.toolStrip_36 = new ToolStrip();
			this.toolStripButton_166 = new ToolStripButton();
			this.toolStripButton_167 = new ToolStripButton();
			this.toolStripButton_168 = new ToolStripButton();
			this.toolStripButton_169 = new ToolStripButton();
			this.toolStripSeparator_101 = new ToolStripSeparator();
			this.toolStripButton_179 = new ToolStripButton();
			this.tabPage_33 = new TabPage();
			this.dataGridViewExcelFilter_12 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_247 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_248 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_249 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_250 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_251 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_252 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_253 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_254 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_255 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_256 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_257 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_258 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_259 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_260 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_16 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_77 = new ToolStripMenuItem();
			this.toolStripMenuItem_78 = new ToolStripMenuItem();
			this.toolStripMenuItem_79 = new ToolStripMenuItem();
			this.toolStripMenuItem_80 = new ToolStripMenuItem();
			this.toolStripSeparator_105 = new ToolStripSeparator();
			this.toolStripMenuItem_91 = new ToolStripMenuItem();
			this.toolStrip_37 = new ToolStrip();
			this.toolStripButton_173 = new ToolStripButton();
			this.toolStripButton_170 = new ToolStripButton();
			this.toolStripButton_171 = new ToolStripButton();
			this.toolStripButton_172 = new ToolStripButton();
			this.toolStripSeparator_106 = new ToolStripSeparator();
			this.toolStripButton_181 = new ToolStripButton();
			this.tabPage_34 = new TabPage();
			this.dataGridView_16 = new DataGridView();
			this.dataGridViewTextBoxColumn_261 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_262 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_263 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_264 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_265 = new DataGridViewTextBoxColumn();
			this.toolStrip_38 = new ToolStrip();
			this.toolStripButton_174 = new ToolStripButton();
			this.toolStripButton_175 = new ToolStripButton();
			this.toolStripButton_176 = new ToolStripButton();
			this.toolStripButton_177 = new ToolStripButton();
			this.toolStripSeparator_102 = new ToolStripSeparator();
			this.toolStripButton_180 = new ToolStripButton();
			this.dataGridViewPassport_0 = new DataGridViewPassport();
			this.dataGridViewTextBoxColumn_266 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_267 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_268 = new DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn_14 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_269 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_270 = new DataGridViewTextBoxColumn();
			this.tabPage_2 = new TabPage();
			this.splitContainer_4 = new SplitContainer();
			this.tabControl_4 = new TabControl();
			this.tabPage_16 = new TabPage();
			this.bjlukJmkdL = new TableLayoutPanel();
			this.toolStrip_6 = new ToolStrip();
			this.sjguzMevbg = new ToolStripButton();
			this.toolStripButton_19 = new ToolStripButton();
			this.toolStripButton_20 = new ToolStripButton();
			this.toolStripSeparator_5 = new ToolStripSeparator();
			this.toolStripButton_21 = new ToolStripButton();
			this.toolStripSeparator_6 = new ToolStripSeparator();
			this.toolStripButton_22 = new ToolStripButton();
			this.toolStripLabel_3 = new ToolStripLabel();
			this.toolStripSeparator_70 = new ToolStripSeparator();
			this.toolStripButton_98 = new ToolStripButton();
			this.dgvTrans = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_128 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_129 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_130 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_131 = new DataGridViewTextBoxColumn();
			this.tabPage_17 = new TabPage();
			this.tableLayoutPanel_17 = new TableLayoutPanel();
			this.toolStrip_22 = new ToolStrip();
			this.toolStripButton_93 = new ToolStripButton();
			this.toolStripButton_94 = new ToolStripButton();
			this.toolStripButton_95 = new ToolStripButton();
			this.toolStripSeparator_68 = new ToolStripSeparator();
			this.toolStripButton_96 = new ToolStripButton();
			this.toolStripSeparator_69 = new ToolStripSeparator();
			this.toolStripButton_97 = new ToolStripButton();
			this.toolStripLabel_6 = new ToolStripLabel();
			this.dgvTransV = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_120 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_121 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_122 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_123 = new DataGridViewTextBoxColumn();
			this.tabPage_20 = new TabPage();
			this.tableLayoutPanel_18 = new TableLayoutPanel();
			this.toolStrip_26 = new ToolStrip();
			this.toolStripButton_114 = new ToolStripButton();
			this.toolStripButton_115 = new ToolStripButton();
			this.toolStripButton_116 = new ToolStripButton();
			this.toolStripSeparator_81 = new ToolStripSeparator();
			this.toolStripButton_117 = new ToolStripButton();
			this.toolStripSeparator_82 = new ToolStripSeparator();
			this.toolStripButton_118 = new ToolStripButton();
			this.dgvTransI = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_124 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_125 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_126 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_127 = new DataGridViewTextBoxColumn();
			this.splitContainer_5 = new SplitContainer();
			this.dgvSwitchgears = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_132 = new DataGridViewTextBoxColumn();
			this.iyFdnnqUdb = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_133 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_134 = new DataGridViewTextBoxColumn();
			this.toolStrip_5 = new ToolStrip();
			this.toolStripButton_14 = new ToolStripButton();
			this.toolStripButton_15 = new ToolStripButton();
			this.toolStripButton_16 = new ToolStripButton();
			this.bJkuSvjuUb = new ToolStripSeparator();
			this.toolStripButton_17 = new ToolStripButton();
			this.toolStripSeparator_4 = new ToolStripSeparator();
			this.toolStripButton_18 = new ToolStripButton();
			this.toolStripLabel_2 = new ToolStripLabel();
			this.tabControl_1 = new TabControl();
			this.tabPage_3 = new TabPage();
			this.tableLayoutPanel_3 = new TableLayoutPanel();
			this.toolStrip_3 = new ToolStrip();
			this.toolStripButton_5 = new ToolStripButton();
			this.toolStripButton_6 = new ToolStripButton();
			this.toolStripButton_7 = new ToolStripButton();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripButton_8 = new ToolStripButton();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.toolStripButton_9 = new ToolStripButton();
			this.toolStripLabel_0 = new ToolStripLabel();
			this.dgvBuses = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_135 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_136 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_137 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_138 = new DataGridViewTextBoxColumn();
			this.tabPage_4 = new TabPage();
			this.JeSuDrbQyn = new TableLayoutPanel();
			this.toolStrip_4 = new ToolStrip();
			this.toolStripButton_10 = new ToolStripButton();
			this.toolStripButton_11 = new ToolStripButton();
			this.toolStripButton_12 = new ToolStripButton();
			this.toolStripSeparator_2 = new ToolStripSeparator();
			this.toolStripButton_13 = new ToolStripButton();
			this.toolStripSeparator_3 = new ToolStripSeparator();
			this.Arvudbkpvh = new ToolStripButton();
			this.toolStripLabel_1 = new ToolStripLabel();
			this.dgvCells = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_139 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_140 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_141 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_142 = new DataGridViewTextBoxColumn();
			this.tabPage_5 = new TabPage();
			this.tableLayoutPanel_4 = new TableLayoutPanel();
			this.toolStrip_7 = new ToolStrip();
			this.toolStripButton_23 = new ToolStripButton();
			this.toolStripButton_24 = new ToolStripButton();
			this.toolStripButton_25 = new ToolStripButton();
			this.toolStripSeparator_7 = new ToolStripSeparator();
			this.toolStripButton_26 = new ToolStripButton();
			this.toolStripSeparator_8 = new ToolStripSeparator();
			this.toolStripButton_27 = new ToolStripButton();
			this.toolStripLabel_4 = new ToolStripLabel();
			this.dgvSwitches = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_143 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_144 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_145 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_146 = new DataGridViewTextBoxColumn();
			this.tabPage_22 = new TabPage();
			this.dataGridViewExcelFilter_6 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_109 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_110 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_111 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_112 = new DataGridViewTextBoxColumn();
			this.toolStrip_28 = new ToolStrip();
			this.toolStripButton_123 = new ToolStripButton();
			this.toolStripButton_124 = new ToolStripButton();
			this.toolStripButton_125 = new ToolStripButton();
			this.toolStripSeparator_85 = new ToolStripSeparator();
			this.toolStripButton_126 = new ToolStripButton();
			this.toolStripSeparator_86 = new ToolStripSeparator();
			this.toolStripButton_127 = new ToolStripButton();
			this.tabPage_23 = new TabPage();
			this.splitContainer_1 = new SplitContainer();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_74 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_75 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_76 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_77 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_78 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_79 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_80 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_81 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_82 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_83 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_84 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_85 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_86 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_87 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_88 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_89 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_90 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_91 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_92 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_5 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_20 = new ToolStripMenuItem();
			this.toolStripMenuItem_21 = new ToolStripMenuItem();
			this.toolStripSeparator_27 = new ToolStripSeparator();
			this.toolStripMenuItem_22 = new ToolStripMenuItem();
			this.toolStripSeparator_28 = new ToolStripSeparator();
			this.toolStripMenuItem_23 = new ToolStripMenuItem();
			this.toolStrip_11 = new ToolStrip();
			this.toolStripButton_41 = new ToolStripButton();
			this.toolStripButton_42 = new ToolStripButton();
			this.toolStripSplitButton_1 = new ToolStripSplitButton();
			this.toolStripMenuItem_32 = new ToolStripMenuItem();
			this.toolStripMenuItem_33 = new ToolStripMenuItem();
			this.toolStripSeparator_21 = new ToolStripSeparator();
			this.toolStripButton_43 = new ToolStripButton();
			this.toolStripSeparator_22 = new ToolStripSeparator();
			this.toolStripButton_44 = new ToolStripButton();
			this.toolStripSeparator_46 = new ToolStripSeparator();
			this.toolStripButton_85 = new ToolStripButton();
			this.toolStripSeparator_62 = new ToolStripSeparator();
			this.toolStripLabel_5 = new ToolStripLabel();
			this.tabControl_3 = new TabControl();
			this.dykcUlJvZe = new TabPage();
			this.tableLayoutPanel_8 = new TableLayoutPanel();
			this.dataGridViewExcelFilter_7 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_93 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_4 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_13 = new ToolStripMenuItem();
			this.toolStripMenuItem_14 = new ToolStripMenuItem();
			this.toolStripMenuItem_18 = new ToolStripMenuItem();
			this.toolStripMenuItem_19 = new ToolStripMenuItem();
			this.toolStripMenuItem_15 = new ToolStripMenuItem();
			this.toolStripMenuItem_48 = new ToolStripMenuItem();
			this.toolStripSeparator_25 = new ToolStripSeparator();
			this.toolStripMenuItem_16 = new ToolStripMenuItem();
			this.toolStripSeparator_26 = new ToolStripSeparator();
			this.toolStripMenuItem_17 = new ToolStripMenuItem();
			this.toolStrip_12 = new ToolStrip();
			this.toolStripButton_45 = new ToolStripButton();
			this.toolStripButton_46 = new ToolStripButton();
			this.toolStripSeparator_23 = new ToolStripSeparator();
			this.toolStripSplitButton_2 = new ToolStripSplitButton();
			this.toolStripMenuItem_47 = new ToolStripMenuItem();
			this.HsaPpImClL = new ToolStripMenuItem();
			this.toolStripSeparator_24 = new ToolStripSeparator();
			this.toolStripButton_47 = new ToolStripButton();
			this.toolStripSeparator_63 = new ToolStripSeparator();
			this.toolStripButton_86 = new ToolStripButton();
			this.toolStripSeparator_75 = new ToolStripSeparator();
			this.toolStripButton_106 = new ToolStripButton();
			this.tabPage_14 = new TabPage();
			this.tableLayoutPanel_15 = new TableLayoutPanel();
			this.dataGridViewExcelFilter_2 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_94 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_10 = new ContextMenuStrip(this.icontainer_0);
			this.leJimFhKcN = new ToolStripMenuItem();
			this.toolStripMenuItem_43 = new ToolStripMenuItem();
			this.toolStripSeparator_59 = new ToolStripSeparator();
			this.toolStripMenuItem_44 = new ToolStripMenuItem();
			this.toolStrip_20 = new ToolStrip();
			this.toolStripButton_81 = new ToolStripButton();
			this.toolStripButton_82 = new ToolStripButton();
			this.toolStripSeparator_57 = new ToolStripSeparator();
			this.toolStripSplitButton_3 = new ToolStripSplitButton();
			this.toolStripMenuItem_49 = new ToolStripMenuItem();
			this.toolStripMenuItem_50 = new ToolStripMenuItem();
			this.toolStripSeparator_58 = new ToolStripSeparator();
			this.toolStripButton_83 = new ToolStripButton();
			this.toolStripSeparator_65 = new ToolStripSeparator();
			this.toolStripButton_88 = new ToolStripButton();
			this.Cjurjlhywj = new TabPage();
			this.splitContainer_2 = new SplitContainer();
			this.treeDataGridView_0 = new TreeDataGridView();
			this.treeGridColumn_0 = new TreeGridColumn();
			this.treeGridColumn_1 = new TreeGridColumn();
			this.treeGridColumn_2 = new TreeGridColumn();
			this.treeGridColumn_3 = new TreeGridColumn();
			this.treeGridColumn_4 = new TreeGridColumn();
			this.dataGridViewTextBoxColumn_64 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_65 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_66 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_67 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_68 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_69 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_70 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_71 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_72 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_73 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_9 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_39 = new ToolStripMenuItem();
			this.toolStripMenuItem_40 = new ToolStripMenuItem();
			this.toolStripMenuItem_59 = new ToolStripMenuItem();
			this.toolStripSeparator_55 = new ToolStripSeparator();
			this.toolStripMenuItem_41 = new ToolStripMenuItem();
			this.toolStripSeparator_56 = new ToolStripSeparator();
			this.toolStripMenuItem_42 = new ToolStripMenuItem();
			this.toolStrip_19 = new ToolStrip();
			this.OlEcIrCmwq = new ToolStripButton();
			this.toolStripButton_78 = new ToolStripButton();
			this.VlMgyFgckb = new ToolStripButton();
			this.toolStripDropDownButton_1 = new ToolStripDropDownButton();
			this.toolStripMenuItem_60 = new ToolStripMenuItem();
			this.toolStripMenuItem_61 = new ToolStripMenuItem();
			this.toolStripSeparator_51 = new ToolStripSeparator();
			this.toolStripButton_79 = new ToolStripButton();
			this.toolStripSeparator_52 = new ToolStripSeparator();
			this.toolStripButton_80 = new ToolStripButton();
			this.toolStripSeparator_64 = new ToolStripSeparator();
			this.toolStripButton_87 = new ToolStripButton();
			this.toolStripSeparator_87 = new ToolStripSeparator();
			this.toolStripLabel_7 = new ToolStripLabel();
			this.splitContainer_3 = new SplitContainer();
			this.tabControl_6 = new TabControl();
			this.tabPage_28 = new TabPage();
			this.dataGridViewExcelFilter_8 = new DataGridViewExcelFilter();
			this.luZgbmDwv7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_181 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_182 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_183 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_184 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_185 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_186 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_8 = new ContextMenuStrip(this.icontainer_0);
			this.odScMgvaDL = new ToolStripMenuItem();
			this.toolStripMenuItem_36 = new ToolStripMenuItem();
			this.toolStripMenuItem_58 = new ToolStripMenuItem();
			this.toolStripSeparator_53 = new ToolStripSeparator();
			this.toolStripMenuItem_55 = new ToolStripMenuItem();
			this.toolStripSeparator_80 = new ToolStripSeparator();
			this.toolStripMenuItem_37 = new ToolStripMenuItem();
			this.toolStripSeparator_54 = new ToolStripSeparator();
			this.toolStripMenuItem_38 = new ToolStripMenuItem();
			this.toolStrip_18 = new ToolStrip();
			this.toolStripButton_75 = new ToolStripButton();
			this.toolStripButton_76 = new ToolStripButton();
			this.toolStripButton_128 = new ToolStripButton();
			this.toolStripSeparator_49 = new ToolStripSeparator();
			this.toolStripButton_77 = new ToolStripButton();
			this.toolStripSeparator_50 = new ToolStripSeparator();
			this.GoscVscjdc = new ToolStripButton();
			this.toolStripSeparator_61 = new ToolStripSeparator();
			this.toolStripButton_84 = new ToolStripButton();
			this.tabPage_29 = new TabPage();
			this.dataGridView_14 = new DataGridView();
			this.dataGridViewTextBoxColumn_177 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_178 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_179 = new DataGridViewTextBoxColumn();
			this.obfgdCvgpL = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_180 = new DataGridViewTextBoxColumn();
			this.toolStrip_33 = new ToolStrip();
			this.toolStripButton_156 = new ToolStripButton();
			this.dataGridViewExcelFilter_9 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_113 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_114 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_115 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_116 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_117 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_118 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_119 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_13 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_51 = new ToolStripMenuItem();
			this.toolStripMenuItem_52 = new ToolStripMenuItem();
			this.toolStripMenuItem_53 = new ToolStripMenuItem();
			this.toolStripSeparator_79 = new ToolStripSeparator();
			this.toolStripMenuItem_54 = new ToolStripMenuItem();
			this.toolStrip_25 = new ToolStrip();
			this.toolStripButton_107 = new ToolStripButton();
			this.toolStripButton_108 = new ToolStripButton();
			this.toolStripSeparator_76 = new ToolStripSeparator();
			this.toolStripButton_109 = new ToolStripButton();
			this.toolStripSeparator_77 = new ToolStripSeparator();
			this.toolStripButton_110 = new ToolStripButton();
			this.toolStripSeparator_78 = new ToolStripSeparator();
			this.toolStripButton_111 = new ToolStripButton();
			this.tabPage_1 = new TabPage();
			this.dataGridView_1 = new DataGridView();
			this.toolStrip_1 = new ToolStrip();
			this.toolStripSplitButton_0 = new ToolStripSplitButton();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.fdPuJwPsYx = new ToolStripButton();
			this.toolStripButton_3 = new ToolStripButton();
			this.tabPage_12 = new TabPage();
			this.tableLayoutPanel_13 = new TableLayoutPanel();
			this.dataGridView_9 = new DataGridView();
			this.dataGridViewImageColumn_0 = new DataGridViewImageColumn();
			this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
			this.yvucnefnbB = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
			this.bindingSource_4 = new BindingSource(this.icontainer_0);
			this.toolStrip_16 = new ToolStrip();
			this.toolStripButton_67 = new ToolStripButton();
			this.toolStripButton_68 = new ToolStripButton();
			this.toolStripButton_70 = new ToolStripButton();
			this.toolStripButton_69 = new ToolStripButton();
			this.tabPage_24 = new TabPage();
			this.tabControl_5 = new TabControl();
			this.tabPage_25 = new TabPage();
			this.dataGridView_11 = new DataGridView();
			this.dataGridViewCheckBoxColumn_8 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_158 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_159 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_160 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_161 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_162 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_163 = new DataGridViewTextBoxColumn();
			this.bindingSource_12 = new BindingSource(this.icontainer_0);
			this.dataSet_0 = new DataSet();
			this.dataTable_0 = new DataTable();
			this.dataColumn_0 = new DataColumn();
			this.dataColumn_1 = new DataColumn();
			this.dataColumn_2 = new DataColumn();
			this.SuUdfiJawF = new DataColumn();
			this.dataColumn_3 = new DataColumn();
			this.dataColumn_4 = new DataColumn();
			this.IeBdYdknAT = new DataColumn();
			this.toolStrip_29 = new ToolStrip();
			this.toolStripButton_129 = new ToolStripButton();
			this.toolStripButton_130 = new ToolStripButton();
			this.toolStripButton_131 = new ToolStripButton();
			this.toolStripSeparator_88 = new ToolStripSeparator();
			this.toolStripButton_132 = new ToolStripButton();
			this.toolStripSeparator_98 = new ToolStripSeparator();
			this.toolStripButton_155 = new ToolStripButton();
			this.tabPage_26 = new TabPage();
			this.dataGridView_12 = new DataGridView();
			this.dataGridViewCheckBoxColumn_9 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_164 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_165 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_166 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_167 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_168 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_169 = new DataGridViewTextBoxColumn();
			this.toolStrip_30 = new ToolStrip();
			this.toolStripButton_133 = new ToolStripButton();
			this.toolStripButton_134 = new ToolStripButton();
			this.toolStripButton_135 = new ToolStripButton();
			this.toolStripSeparator_89 = new ToolStripSeparator();
			this.toolStripButton_136 = new ToolStripButton();
			this.tabPage_27 = new TabPage();
			this.dataGridView_13 = new DataGridView();
			this.YowoatyOoV = new DataGridViewLinkColumn();
			this.dataGridViewTextBoxColumn_223 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_224 = new DataGridViewTextBoxColumn();
			this.dataGridViewImageColumn_1 = new DataGridViewImageColumn();
			this.dataGridViewTextBoxColumn_225 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_226 = new DataGridViewTextBoxColumn();
			this.bindingSource_13 = new BindingSource(this.icontainer_0);
			this.toolStrip_32 = new ToolStrip();
			this.toolStripButton_151 = new ToolStripButton();
			this.toolStripButton_153 = new ToolStripButton();
			this.toolStripButton_152 = new ToolStripButton();
			this.toolStripButton_154 = new ToolStripButton();
			this.imageList_0 = new ImageList(this.icontainer_0);
			this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
			this.toolStrip_2 = new ToolStrip();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.dateTimePicker_1 = new DateTimePicker();
			this.comboBox_0 = new ComboBox();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.backgroundWorker_1 = new BackgroundWorker();
			this.backgroundWorker_2 = new BackgroundWorker();
			this.LstNnlIwat = new BackgroundWorker();
			this.backgroundWorker_3 = new BackgroundWorker();
			this.backgroundWorker_4 = new BackgroundWorker();
			this.backgroundWorker_5 = new BackgroundWorker();
			this.contextMenuStrip_11 = new ContextMenuStrip(this.icontainer_0);
			this.contextMenuStrip_12 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_45 = new ToolStripMenuItem();
			this.toolStripSeparator_60 = new ToolStripSeparator();
			this.toolStripMenuItem_46 = new ToolStripMenuItem();
			this.backgroundWorker_6 = new BackgroundWorker();
			this.backgroundWorker_7 = new BackgroundWorker();
			this.backgroundWorker_8 = new BackgroundWorker();
			this.bindingSource_7 = new BindingSource(this.icontainer_0);
			this.toolStripButton_137 = new ToolStripButton();
			this.toolStripButton_138 = new ToolStripButton();
			this.toolStripButton_139 = new ToolStripButton();
			this.toolStripSeparator_90 = new ToolStripSeparator();
			this.toolStripButton_140 = new ToolStripButton();
			this.toolStripSeparator_91 = new ToolStripSeparator();
			this.toolStripDropDownButton_0 = new ToolStripDropDownButton();
			this.toolStripMenuItem_56 = new ToolStripMenuItem();
			this.toolStripMenuItem_57 = new ToolStripMenuItem();
			this.toolStripMenuItem_62 = new ToolStripMenuItem();
			this.toolStripSeparator_92 = new ToolStripSeparator();
			this.toolStripButton_141 = new ToolStripButton();
			this.toolStripSeparator_93 = new ToolStripSeparator();
			this.toolStripButton_142 = new ToolStripButton();
			this.toolStripSeparator_94 = new ToolStripSeparator();
			this.toolStripButton_143 = new ToolStripButton();
			this.toolStripSeparator_95 = new ToolStripSeparator();
			this.toolStripButton_144 = new ToolStripButton();
			this.toolStripSeparator_96 = new ToolStripSeparator();
			this.toolStripButton_145 = new ToolStripButton();
			this.toolStripButton_146 = new ToolStripButton();
			this.toolStripButton_147 = new ToolStripButton();
			this.toolStripButton_148 = new ToolStripButton();
			this.toolStripSeparator_97 = new ToolStripSeparator();
			this.toolStripButton_149 = new ToolStripButton();
			this.toolStripButton_150 = new ToolStripButton();
			this.toolStrip_31 = new ToolStrip();
			this.class295_0 = new Class295();
			this.bindingSource_2 = new BindingSource(this.icontainer_0);
			this.bindingSource_6 = new BindingSource(this.icontainer_0);
			this.contextMenuStrip_15 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_69 = new ToolStripMenuItem();
			this.toolStripMenuItem_70 = new ToolStripMenuItem();
			this.toolStripMenuItem_71 = new ToolStripMenuItem();
			this.toolStripMenuItem_72 = new ToolStripMenuItem();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_18 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_85 = new ToolStripMenuItem();
			this.toolStripMenuItem_86 = new ToolStripMenuItem();
			this.toolStripMenuItem_87 = new ToolStripMenuItem();
			this.toolStripMenuItem_88 = new ToolStripMenuItem();
			this.toolStripSeparator_107 = new ToolStripSeparator();
			this.toolStripMenuItem_92 = new ToolStripMenuItem();
			this.tableLayoutPanel_0.SuspendLayout();
			this.splitContainer_0.Panel1.SuspendLayout();
			this.splitContainer_0.Panel2.SuspendLayout();
			this.splitContainer_0.SuspendLayout();
			this.tableLayoutPanel_1.SuspendLayout();
			this.toolStrip_0.SuspendLayout();
			this.panel_0.SuspendLayout();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.tableLayoutPanel_2.SuspendLayout();
			this.ehAutNuOxy.SuspendLayout();
			this.tabControl_2.SuspendLayout();
			this.tabPage_6.SuspendLayout();
			this.tableLayoutPanel_5.SuspendLayout();
			((ISupportInitialize)this.dataGridView_2).BeginInit();
			this.contextMenuStrip_1.SuspendLayout();
			this.toolStrip_8.SuspendLayout();
			this.tabPage_7.SuspendLayout();
			this.tableLayoutPanel_6.SuspendLayout();
			((ISupportInitialize)this.dataGridView_3).BeginInit();
			this.contextMenuStrip_2.SuspendLayout();
			this.toolStrip_9.SuspendLayout();
			this.tabPage_8.SuspendLayout();
			this.tableLayoutPanel_7.SuspendLayout();
			((ISupportInitialize)this.dataGridView_4).BeginInit();
			this.contextMenuStrip_3.SuspendLayout();
			this.toolStrip_10.SuspendLayout();
			this.tabPage_9.SuspendLayout();
			this.tableLayoutPanel_9.SuspendLayout();
			((ISupportInitialize)this.dataGridView_5).BeginInit();
			this.contextMenuStrip_6.SuspendLayout();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.class107_0).BeginInit();
			this.ErxDoVobWm.SuspendLayout();
			this.tabPage_10.SuspendLayout();
			this.tableLayoutPanel_10.SuspendLayout();
			((ISupportInitialize)this.dataGridView_6).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			this.toolStrip_13.SuspendLayout();
			this.pjuAjnsoym.SuspendLayout();
			this.tableLayoutPanel_11.SuspendLayout();
			((ISupportInitialize)this.dataGridView_7).BeginInit();
			this.contextMenuStrip_7.SuspendLayout();
			((ISupportInitialize)this.bindingSource_3).BeginInit();
			((ISupportInitialize)this.jtnAdxtlvN).BeginInit();
			this.toolStrip_14.SuspendLayout();
			this.tabPage_11.SuspendLayout();
			this.tableLayoutPanel_12.SuspendLayout();
			this.toolStrip_15.SuspendLayout();
			((ISupportInitialize)this.dataGridView_8).BeginInit();
			this.tabPage_13.SuspendLayout();
			this.toolStrip_17.SuspendLayout();
			this.tableLayoutPanel_14.SuspendLayout();
			this.dataGridViewExcelFilter_1.BeginInit();
			((ISupportInitialize)this.bindingSource_5).BeginInit();
			this.tabPage_15.SuspendLayout();
			this.toolStrip_21.SuspendLayout();
			this.tableLayoutPanel_16.SuspendLayout();
			this.dataGridViewExcelFilter_3.BeginInit();
			((ISupportInitialize)this.bindingSource_8).BeginInit();
			this.tabPage_18.SuspendLayout();
			this.dataGridViewExcelFilter_4.BeginInit();
			((ISupportInitialize)this.bindingSource_9).BeginInit();
			((ISupportInitialize)this.class14_0).BeginInit();
			this.toolStrip_23.SuspendLayout();
			this.tabPage_19.SuspendLayout();
			this.dataGridViewExcelFilter_5.BeginInit();
			((ISupportInitialize)this.bindingSource_10).BeginInit();
			((ISupportInitialize)this.class14_1).BeginInit();
			this.toolStrip_24.SuspendLayout();
			this.tabPage_21.SuspendLayout();
			((ISupportInitialize)this.dataGridView_10).BeginInit();
			((ISupportInitialize)this.bindingSource_11).BeginInit();
			((ISupportInitialize)this.class14_2).BeginInit();
			this.toolStrip_27.SuspendLayout();
			this.tabPage_30.SuspendLayout();
			((ISupportInitialize)this.dataGridView_15).BeginInit();
			this.contextMenuStrip_14.SuspendLayout();
			((ISupportInitialize)this.bindingSource_14).BeginInit();
			this.toolStrip_34.SuspendLayout();
			this.tabPage_31.SuspendLayout();
			this.dataGridViewExcelFilter_10.BeginInit();
			this.NawojBnvmy.SuspendLayout();
			this.toolStrip_35.SuspendLayout();
			this.tabPage_32.SuspendLayout();
			this.dataGridViewExcelFilter_11.BeginInit();
			this.contextMenuStrip_17.SuspendLayout();
			this.toolStrip_36.SuspendLayout();
			this.tabPage_33.SuspendLayout();
			this.dataGridViewExcelFilter_12.BeginInit();
			this.contextMenuStrip_16.SuspendLayout();
			this.toolStrip_37.SuspendLayout();
			this.tabPage_34.SuspendLayout();
			((ISupportInitialize)this.dataGridView_16).BeginInit();
			this.toolStrip_38.SuspendLayout();
			((ISupportInitialize)this.dataGridViewPassport_0).BeginInit();
			this.tabPage_2.SuspendLayout();
			this.splitContainer_4.Panel1.SuspendLayout();
			this.splitContainer_4.Panel2.SuspendLayout();
			this.splitContainer_4.SuspendLayout();
			this.tabControl_4.SuspendLayout();
			this.tabPage_16.SuspendLayout();
			this.bjlukJmkdL.SuspendLayout();
			this.toolStrip_6.SuspendLayout();
			this.dgvTrans.BeginInit();
			this.tabPage_17.SuspendLayout();
			this.tableLayoutPanel_17.SuspendLayout();
			this.toolStrip_22.SuspendLayout();
			this.dgvTransV.BeginInit();
			this.tabPage_20.SuspendLayout();
			this.tableLayoutPanel_18.SuspendLayout();
			this.toolStrip_26.SuspendLayout();
			this.dgvTransI.BeginInit();
			this.splitContainer_5.Panel1.SuspendLayout();
			this.splitContainer_5.Panel2.SuspendLayout();
			this.splitContainer_5.SuspendLayout();
			this.dgvSwitchgears.BeginInit();
			this.toolStrip_5.SuspendLayout();
			this.tabControl_1.SuspendLayout();
			this.tabPage_3.SuspendLayout();
			this.tableLayoutPanel_3.SuspendLayout();
			this.toolStrip_3.SuspendLayout();
			this.dgvBuses.BeginInit();
			this.tabPage_4.SuspendLayout();
			this.JeSuDrbQyn.SuspendLayout();
			this.toolStrip_4.SuspendLayout();
			this.dgvCells.BeginInit();
			this.tabPage_5.SuspendLayout();
			this.tableLayoutPanel_4.SuspendLayout();
			this.toolStrip_7.SuspendLayout();
			this.dgvSwitches.BeginInit();
			this.tabPage_22.SuspendLayout();
			this.dataGridViewExcelFilter_6.BeginInit();
			this.toolStrip_28.SuspendLayout();
			this.tabPage_23.SuspendLayout();
			this.splitContainer_1.Panel1.SuspendLayout();
			this.splitContainer_1.Panel2.SuspendLayout();
			this.splitContainer_1.SuspendLayout();
			this.dataGridViewExcelFilter_0.BeginInit();
			this.contextMenuStrip_5.SuspendLayout();
			this.toolStrip_11.SuspendLayout();
			this.tabControl_3.SuspendLayout();
			this.dykcUlJvZe.SuspendLayout();
			this.tableLayoutPanel_8.SuspendLayout();
			this.dataGridViewExcelFilter_7.BeginInit();
			this.contextMenuStrip_4.SuspendLayout();
			this.toolStrip_12.SuspendLayout();
			this.tabPage_14.SuspendLayout();
			this.tableLayoutPanel_15.SuspendLayout();
			this.dataGridViewExcelFilter_2.BeginInit();
			this.contextMenuStrip_10.SuspendLayout();
			this.toolStrip_20.SuspendLayout();
			this.Cjurjlhywj.SuspendLayout();
			this.splitContainer_2.Panel1.SuspendLayout();
			this.splitContainer_2.Panel2.SuspendLayout();
			this.splitContainer_2.SuspendLayout();
			this.treeDataGridView_0.BeginInit();
			this.contextMenuStrip_9.SuspendLayout();
			this.toolStrip_19.SuspendLayout();
			this.splitContainer_3.Panel1.SuspendLayout();
			this.splitContainer_3.Panel2.SuspendLayout();
			this.splitContainer_3.SuspendLayout();
			this.tabControl_6.SuspendLayout();
			this.tabPage_28.SuspendLayout();
			this.dataGridViewExcelFilter_8.BeginInit();
			this.contextMenuStrip_8.SuspendLayout();
			this.toolStrip_18.SuspendLayout();
			this.tabPage_29.SuspendLayout();
			((ISupportInitialize)this.dataGridView_14).BeginInit();
			this.toolStrip_33.SuspendLayout();
			this.dataGridViewExcelFilter_9.BeginInit();
			this.contextMenuStrip_13.SuspendLayout();
			this.toolStrip_25.SuspendLayout();
			this.tabPage_1.SuspendLayout();
			((ISupportInitialize)this.dataGridView_1).BeginInit();
			this.toolStrip_1.SuspendLayout();
			this.tabPage_12.SuspendLayout();
			this.tableLayoutPanel_13.SuspendLayout();
			((ISupportInitialize)this.dataGridView_9).BeginInit();
			((ISupportInitialize)this.bindingSource_4).BeginInit();
			this.toolStrip_16.SuspendLayout();
			this.tabPage_24.SuspendLayout();
			this.tabControl_5.SuspendLayout();
			this.tabPage_25.SuspendLayout();
			((ISupportInitialize)this.dataGridView_11).BeginInit();
			((ISupportInitialize)this.bindingSource_12).BeginInit();
			((ISupportInitialize)this.dataSet_0).BeginInit();
			((ISupportInitialize)this.dataTable_0).BeginInit();
			this.toolStrip_29.SuspendLayout();
			this.tabPage_26.SuspendLayout();
			((ISupportInitialize)this.dataGridView_12).BeginInit();
			this.toolStrip_30.SuspendLayout();
			this.tabPage_27.SuspendLayout();
			((ISupportInitialize)this.dataGridView_13).BeginInit();
			((ISupportInitialize)this.bindingSource_13).BeginInit();
			this.toolStrip_32.SuspendLayout();
			this.contextMenuStrip_12.SuspendLayout();
			((ISupportInitialize)this.bindingSource_7).BeginInit();
			this.toolStrip_31.SuspendLayout();
			((ISupportInitialize)this.bindingSource_2).BeginInit();
			((ISupportInitialize)this.bindingSource_6).BeginInit();
			this.contextMenuStrip_15.SuspendLayout();
			this.contextMenuStrip_18.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 205f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_0.Controls.Add(this.splitContainer_0, 0, 1);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tlpPassport";
			this.tableLayoutPanel_0.RowCount = 3;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));
			this.tableLayoutPanel_0.Size = new Size(785, 562);
			this.tableLayoutPanel_0.TabIndex = 5;
			this.tableLayoutPanel_0.SetColumnSpan(this.splitContainer_0, 2);
			this.splitContainer_0.Dock = DockStyle.Fill;
			this.splitContainer_0.Location = new Point(3, 28);
			this.splitContainer_0.Name = "scGeneral";
			this.splitContainer_0.Panel1.Controls.Add(this.tableLayoutPanel_1);
			this.splitContainer_0.Panel2.Controls.Add(this.tabControl_0);
			this.splitContainer_0.Size = new Size(779, 499);
			this.splitContainer_0.SplitterDistance = 258;
			this.splitContainer_0.TabIndex = 7;
			this.tableLayoutPanel_1.ColumnCount = 1;
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.Controls.Add(this.toolStrip_0, 0, 0);
			this.tableLayoutPanel_1.Controls.Add(this.panel_0, 0, 1);
			this.tableLayoutPanel_1.Dock = DockStyle.Fill;
			this.tableLayoutPanel_1.Location = new Point(0, 0);
			this.tableLayoutPanel_1.Name = "tlpTree";
			this.tableLayoutPanel_1.RowCount = 2;
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_1.Size = new Size(258, 499);
			this.tableLayoutPanel_1.TabIndex = 2;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripTextBox_0,
				this.EgvhzrfdWJ,
				this.toolStripButton_4,
				this.toolStripSeparator_40,
				this.toolStripButton_60
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "tsTree";
			this.toolStrip_0.Size = new Size(258, 25);
			this.toolStrip_0.TabIndex = 2;
			this.toolStrip_0.Text = "Панель инструментов дерва данных";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = (Image)componentResourceManager.GetObject("tsbShowDeletedObject.Image");
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "tsbShowDeletedObject";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Отобразить удаленные объекты";
			this.toolStripButton_0.Visible = false;
			this.toolStripTextBox_0.Name = "tstbFindObj";
			this.toolStripTextBox_0.Size = new Size(100, 25);
			this.toolStripTextBox_0.KeyPress += this.toolStripTextBox_0_KeyPress;
			this.EgvhzrfdWJ.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.EgvhzrfdWJ.Image = (Image)componentResourceManager.GetObject("tsbFindObj.Image");
			this.EgvhzrfdWJ.ImageTransparentColor = Color.Magenta;
			this.EgvhzrfdWJ.Name = "tsbFindObj";
			this.EgvhzrfdWJ.Size = new Size(23, 22);
			this.EgvhzrfdWJ.Text = "Найти";
			this.EgvhzrfdWJ.Click += this.EgvhzrfdWJ_Click;
			this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_4.Image = (Image)componentResourceManager.GetObject("tsbFindNextObj.Image");
			this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_4.Name = "tsbFindNextObj";
			this.toolStripButton_4.Size = new Size(23, 22);
			this.toolStripButton_4.Text = "Найти далее";
			this.toolStripButton_4.Click += this.toolStripButton_4_Click;
			this.toolStripSeparator_40.Name = "toolStripSeparator10";
			this.toolStripSeparator_40.Size = new Size(6, 25);
			this.toolStripButton_60.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_60.Image = Resources.smethod_52();
			this.toolStripButton_60.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_60.Name = "tsbSortTree";
			this.toolStripButton_60.Size = new Size(23, 22);
			this.toolStripButton_60.Text = "Сортировка";
			this.toolStripButton_60.TextImageRelation = TextImageRelation.Overlay;
			this.toolStripButton_60.Click += this.toolStripButton_60_Click;
			this.panel_0.Controls.Add(this.treeView_0);
			this.panel_0.Dock = DockStyle.Fill;
			this.panel_0.Location = new Point(3, 29);
			this.panel_0.Name = "panel1";
			this.panel_0.Size = new Size(252, 467);
			this.panel_0.TabIndex = 3;
			this.treeView_0.Dock = DockStyle.Fill;
			this.treeView_0.FullRowSelect = true;
			this.treeView_0.HideSelection = false;
			this.treeView_0.ImageKey = "Element.png";
			this.treeView_0.Location = new Point(0, 0);
			this.treeView_0.Name = "trvSchmObj";
			this.treeView_0.SelectedImageKey = "Element.png";
			this.treeView_0.Size = new Size(252, 467);
			this.treeView_0.TabIndex = 2;
			this.treeView_0.BeforeExpand += this.treeView_0_BeforeExpand;
			this.treeView_0.BeforeSelect += this.treeView_0_BeforeSelect;
			this.treeView_0.AfterSelect += this.treeView_0_AfterSelect;
			this.treeView_0.MouseClick += this.treeView_0_MouseClick;
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_2);
			this.tabControl_0.Controls.Add(this.tabPage_23);
			this.tabControl_0.Controls.Add(this.Cjurjlhywj);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Controls.Add(this.tabPage_12);
			this.tabControl_0.Controls.Add(this.tabPage_27);
			this.tabControl_0.Dock = DockStyle.Fill;
			this.tabControl_0.Location = new Point(0, 0);
			this.tabControl_0.Name = "tcPassport";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(517, 499);
			this.tabControl_0.TabIndex = 1;
			this.tabControl_0.SelectedIndexChanged += this.tabControl_0_SelectedIndexChanged;
			this.tabPage_0.Controls.Add(this.tableLayoutPanel_2);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tpGeneral";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(509, 473);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Общие";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_2.ColumnCount = 1;
			this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_2.Controls.Add(this.ehAutNuOxy, 0, 0);
			this.tableLayoutPanel_2.Controls.Add(this.label_2, 0, 2);
			this.tableLayoutPanel_2.Controls.Add(this.tabControl_2, 0, 3);
			this.tableLayoutPanel_2.Controls.Add(this.dataGridViewPassport_0, 0, 1);
			this.tableLayoutPanel_2.Dock = DockStyle.Fill;
			this.tableLayoutPanel_2.Location = new Point(3, 3);
			this.tableLayoutPanel_2.Name = "tlpGeneralTab";
			this.tableLayoutPanel_2.RowCount = 4;
			this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));
			this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Percent, 63.2783f));
			this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8f));
			this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Percent, 36.72169f));
			this.tableLayoutPanel_2.Size = new Size(503, 467);
			this.tableLayoutPanel_2.TabIndex = 0;
			this.ehAutNuOxy.ColumnCount = 4;
			this.ehAutNuOxy.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.04001f));
			this.ehAutNuOxy.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.33455f));
			this.ehAutNuOxy.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.51493f));
			this.ehAutNuOxy.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.11051f));
			this.ehAutNuOxy.Controls.Add(this.label_0, 2, 0);
			this.ehAutNuOxy.Controls.Add(this.dateTimePicker_0, 3, 0);
			this.ehAutNuOxy.Controls.Add(this.label_1, 1, 0);
			this.ehAutNuOxy.Controls.Add(this.label_3, 0, 0);
			this.ehAutNuOxy.Dock = DockStyle.Fill;
			this.ehAutNuOxy.Location = new Point(3, 3);
			this.ehAutNuOxy.Name = "tlpDate";
			this.ehAutNuOxy.RowCount = 1;
			this.ehAutNuOxy.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.ehAutNuOxy.Size = new Size(497, 26);
			this.ehAutNuOxy.TabIndex = 4;
			this.label_0.AutoSize = true;
			this.label_0.Dock = DockStyle.Fill;
			this.label_0.Location = new Point(287, 0);
			this.label_0.Name = "lbDatePassport";
			this.label_0.Size = new Size(51, 26);
			this.label_0.TabIndex = 3;
			this.label_0.Text = "Дата";
			this.label_0.TextAlign = ContentAlignment.MiddleRight;
			this.dateTimePicker_0.Dock = DockStyle.Fill;
			this.dateTimePicker_0.Location = new Point(344, 3);
			this.dateTimePicker_0.Name = "dtpDate";
			this.dateTimePicker_0.Size = new Size(150, 20);
			this.dateTimePicker_0.TabIndex = 4;
			this.label_1.AutoSize = true;
			this.label_1.Dock = DockStyle.Fill;
			this.label_1.Location = new Point(109, 0);
			this.label_1.Margin = new Padding(10, 0, 3, 0);
			this.label_1.Name = "lbDopValue";
			this.label_1.Size = new Size(172, 26);
			this.label_1.TabIndex = 6;
			this.label_1.Text = " ";
			this.label_1.TextAlign = ContentAlignment.MiddleLeft;
			this.label_3.AutoSize = true;
			this.label_3.Dock = DockStyle.Fill;
			this.label_3.Location = new Point(3, 0);
			this.label_3.Name = "lbDopHeader";
			this.label_3.Size = new Size(93, 26);
			this.label_3.TabIndex = 7;
			this.label_3.TextAlign = ContentAlignment.MiddleRight;
			this.label_2.AutoSize = true;
			this.label_2.Cursor = Cursors.PanNorth;
			this.label_2.Dock = DockStyle.Fill;
			this.label_2.Location = new Point(3, 302);
			this.label_2.Name = "lbViewTrans";
			this.label_2.Size = new Size(497, 8);
			this.label_2.TabIndex = 7;
			this.label_2.Text = "* * *";
			this.label_2.TextAlign = ContentAlignment.TopCenter;
			this.label_2.Click += this.label_2_Click;
			this.tabControl_2.Controls.Add(this.tabPage_6);
			this.tabControl_2.Controls.Add(this.tabPage_7);
			this.tabControl_2.Controls.Add(this.tabPage_8);
			this.tabControl_2.Controls.Add(this.tabPage_9);
			this.tabControl_2.Controls.Add(this.tabPage_10);
			this.tabControl_2.Controls.Add(this.pjuAjnsoym);
			this.tabControl_2.Controls.Add(this.tabPage_11);
			this.tabControl_2.Controls.Add(this.tabPage_13);
			this.tabControl_2.Controls.Add(this.tabPage_15);
			this.tabControl_2.Controls.Add(this.tabPage_18);
			this.tabControl_2.Controls.Add(this.tabPage_19);
			this.tabControl_2.Controls.Add(this.tabPage_21);
			this.tabControl_2.Controls.Add(this.tabPage_24);
			this.tabControl_2.Controls.Add(this.tabPage_30);
			this.tabControl_2.Controls.Add(this.tabPage_31);
			this.tabControl_2.Controls.Add(this.tabPage_32);
			this.tabControl_2.Controls.Add(this.tabPage_33);
			this.tabControl_2.Controls.Add(this.tabPage_34);
			this.tabControl_2.Dock = DockStyle.Fill;
			this.tabControl_2.Location = new Point(3, 313);
			this.tabControl_2.Name = "tcPassportAddl";
			this.tabControl_2.SelectedIndex = 0;
			this.tabControl_2.Size = new Size(497, 151);
			this.tabControl_2.TabIndex = 9;
			this.tabControl_2.SelectedIndexChanged += this.tabControl_2_SelectedIndexChanged;
			this.tabPage_6.Controls.Add(this.tableLayoutPanel_5);
			this.tabPage_6.Location = new Point(4, 22);
			this.tabPage_6.Name = "tpRepair";
			this.tabPage_6.Padding = new Padding(3);
			this.tabPage_6.Size = new Size(489, 125);
			this.tabPage_6.TabIndex = 2;
			this.tabPage_6.Text = "Ремонт";
			this.tabPage_6.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_5.ColumnCount = 1;
			this.tableLayoutPanel_5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_5.Controls.Add(this.dataGridView_2, 0, 1);
			this.tableLayoutPanel_5.Controls.Add(this.toolStrip_8, 0, 0);
			this.tableLayoutPanel_5.Dock = DockStyle.Fill;
			this.tableLayoutPanel_5.Location = new Point(3, 3);
			this.tableLayoutPanel_5.Name = "tlpRepair";
			this.tableLayoutPanel_5.RowCount = 2;
			this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_5.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_5.Size = new Size(483, 119);
			this.tableLayoutPanel_5.TabIndex = 0;
			this.dataGridView_2.AllowUserToAddRows = false;
			this.dataGridView_2.AllowUserToDeleteRows = false;
			this.dataGridView_2.AllowUserToResizeRows = false;
			this.dataGridView_2.BackgroundColor = Color.White;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridView_2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_2.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_147,
				this.dataGridViewTextBoxColumn_148,
				this.dataGridViewTextBoxColumn_149,
				this.dataGridViewTextBoxColumn_150,
				this.dataGridViewTextBoxColumn_151,
				this.dataGridViewTextBoxColumn_152,
				this.xhAdvgBiFT,
				this.dataGridViewTextBoxColumn_153,
				this.dataGridViewTextBoxColumn_154,
				this.dataGridViewTextBoxColumn_155,
				this.dataGridViewTextBoxColumn_156,
				this.dataGridViewTextBoxColumn_157
			});
			this.dataGridView_2.ContextMenuStrip = this.contextMenuStrip_1;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle2.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.dataGridView_2.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_2.Dock = DockStyle.Fill;
			this.dataGridView_2.Location = new Point(3, 28);
			this.dataGridView_2.MultiSelect = false;
			this.dataGridView_2.Name = "dgvRepair";
			this.dataGridView_2.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dataGridView_2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_2.RowHeadersVisible = false;
			this.dataGridView_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_2.Size = new Size(477, 88);
			this.dataGridView_2.TabIndex = 1;
			this.dataGridView_2.CellDoubleClick += this.dataGridView_2_CellDoubleClick;
			this.dataGridViewTextBoxColumn_147.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_147.HeaderText = "idRepair";
			this.dataGridViewTextBoxColumn_147.Name = "idDgvRepair";
			this.dataGridViewTextBoxColumn_147.ReadOnly = true;
			this.dataGridViewTextBoxColumn_147.Visible = false;
			this.dataGridViewTextBoxColumn_148.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_148.HeaderText = "ParentIdRepair";
			this.dataGridViewTextBoxColumn_148.Name = "ParentIdDgvRepair";
			this.dataGridViewTextBoxColumn_148.ReadOnly = true;
			this.dataGridViewTextBoxColumn_148.Visible = false;
			this.dataGridViewTextBoxColumn_149.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_149.HeaderText = "idObjListRepair";
			this.dataGridViewTextBoxColumn_149.Name = "idObjListDgvRepair";
			this.dataGridViewTextBoxColumn_149.ReadOnly = true;
			this.dataGridViewTextBoxColumn_149.Visible = false;
			this.dataGridViewTextBoxColumn_150.DataPropertyName = "DateDoc";
			this.dataGridViewTextBoxColumn_150.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_150.Name = "DateDocDgvRepair";
			this.dataGridViewTextBoxColumn_150.ReadOnly = true;
			this.dataGridViewTextBoxColumn_150.Width = 130;
			this.dataGridViewTextBoxColumn_151.DataPropertyName = "NumberDoc";
			this.dataGridViewTextBoxColumn_151.HeaderText = "NumberDocRepair";
			this.dataGridViewTextBoxColumn_151.Name = "NumberDocDgvRepair";
			this.dataGridViewTextBoxColumn_151.ReadOnly = true;
			this.dataGridViewTextBoxColumn_151.Visible = false;
			this.dataGridViewTextBoxColumn_151.Width = 150;
			this.dataGridViewTextBoxColumn_152.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_152.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_152.HeaderText = "Работа";
			this.dataGridViewTextBoxColumn_152.Name = "CommentDgvRepair";
			this.dataGridViewTextBoxColumn_152.ReadOnly = true;
			this.xhAdvgBiFT.DataPropertyName = "Comment2";
			this.xhAdvgBiFT.HeaderText = "Comment2Repair";
			this.xhAdvgBiFT.Name = "Comment2DgvRepair";
			this.xhAdvgBiFT.ReadOnly = true;
			this.xhAdvgBiFT.Visible = false;
			this.dataGridViewTextBoxColumn_153.DataPropertyName = "TypeDoc";
			this.dataGridViewTextBoxColumn_153.HeaderText = "TypeDocRepair";
			this.dataGridViewTextBoxColumn_153.Name = "TypeDocDgvRepair";
			this.dataGridViewTextBoxColumn_153.ReadOnly = true;
			this.dataGridViewTextBoxColumn_153.Visible = false;
			this.dataGridViewTextBoxColumn_154.DataPropertyName = "isActive";
			this.dataGridViewTextBoxColumn_154.HeaderText = "isActiveRepair";
			this.dataGridViewTextBoxColumn_154.Name = "isActiveDgvRepair";
			this.dataGridViewTextBoxColumn_154.ReadOnly = true;
			this.dataGridViewTextBoxColumn_154.Visible = false;
			this.dataGridViewTextBoxColumn_155.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_155.HeaderText = "DeletedRepair";
			this.dataGridViewTextBoxColumn_155.Name = "DeletedDgvRepair";
			this.dataGridViewTextBoxColumn_155.ReadOnly = true;
			this.dataGridViewTextBoxColumn_155.Visible = false;
			this.dataGridViewTextBoxColumn_156.DataPropertyName = "dataXml";
			this.dataGridViewTextBoxColumn_156.HeaderText = "dataXml";
			this.dataGridViewTextBoxColumn_156.Name = "dataXmlDgvRepair";
			this.dataGridViewTextBoxColumn_156.ReadOnly = true;
			this.dataGridViewTextBoxColumn_156.Visible = false;
			this.dataGridViewTextBoxColumn_157.DataPropertyName = "idSector";
			this.dataGridViewTextBoxColumn_157.HeaderText = "idSector";
			this.dataGridViewTextBoxColumn_157.Name = "idSectorDgvRepair";
			this.dataGridViewTextBoxColumn_157.ReadOnly = true;
			this.dataGridViewTextBoxColumn_157.Visible = false;
			this.contextMenuStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_1,
				this.toolStripMenuItem_2,
				this.toolStripSeparator_13,
				this.toolStripMenuItem_3,
				this.toolStripSeparator_14,
				this.toolStripMenuItem_4
			});
			this.contextMenuStrip_1.Name = "cmsMoveTransf";
			this.contextMenuStrip_1.Size = new Size(155, 104);
			this.toolStripMenuItem_1.Image = Resources.smethod_24();
			this.toolStripMenuItem_1.Name = "tsmiAddRepair";
			this.toolStripMenuItem_1.Size = new Size(154, 22);
			this.toolStripMenuItem_1.Text = "Добавить";
			this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
			this.toolStripMenuItem_2.Image = Resources.smethod_26();
			this.toolStripMenuItem_2.Name = "tsmiEditDoc";
			this.toolStripMenuItem_2.Size = new Size(154, 22);
			this.toolStripMenuItem_2.Text = "Редактировать";
			this.toolStripMenuItem_2.Click += this.toolStripMenuItem_2_Click;
			this.toolStripSeparator_13.Name = "toolStripSeparator7";
			this.toolStripSeparator_13.Size = new Size(151, 6);
			this.toolStripMenuItem_3.Image = Resources.smethod_25();
			this.toolStripMenuItem_3.Name = "tsmiDeleteDoc";
			this.toolStripMenuItem_3.Size = new Size(154, 22);
			this.toolStripMenuItem_3.Text = "Удалить";
			this.toolStripMenuItem_3.Click += this.toolStripMenuItem_3_Click;
			this.toolStripSeparator_14.Name = "tssiRefreshRepair";
			this.toolStripSeparator_14.Size = new Size(151, 6);
			this.toolStripMenuItem_4.Image = Resources.smethod_45();
			this.toolStripMenuItem_4.Name = "tsmiRefreshRepair";
			this.toolStripMenuItem_4.Size = new Size(154, 22);
			this.toolStripMenuItem_4.Text = "Обновить";
			this.toolStripMenuItem_4.Click += this.toolStripMenuItem_4_Click;
			this.toolStrip_8.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_28,
				this.toolStripButton_29,
				this.toolStripSeparator_9,
				this.toolStripButton_30,
				this.toolStripSeparator_10,
				this.toolStripButton_31
			});
			this.toolStrip_8.Location = new Point(0, 0);
			this.toolStrip_8.Name = "tsRepair";
			this.toolStrip_8.Size = new Size(483, 25);
			this.toolStrip_8.TabIndex = 0;
			this.toolStrip_8.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_28.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_28.Image = Resources.smethod_24();
			this.toolStripButton_28.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_28.Name = "tssbAddRepair";
			this.toolStripButton_28.Size = new Size(23, 22);
			this.toolStripButton_28.Text = "Добавить";
			this.toolStripButton_28.Click += this.toolStripButton_28_Click;
			this.toolStripButton_29.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_29.Image = Resources.smethod_26();
			this.toolStripButton_29.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_29.Name = "tsbEditRepair";
			this.toolStripButton_29.Size = new Size(23, 22);
			this.toolStripButton_29.Text = "Редактировать";
			this.toolStripButton_29.Click += this.toolStripButton_29_Click;
			this.toolStripSeparator_9.Name = "toolStripSeparator5";
			this.toolStripSeparator_9.Size = new Size(6, 25);
			this.toolStripButton_30.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_30.Image = Resources.smethod_25();
			this.toolStripButton_30.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_30.Name = "tsbDeleteRepair";
			this.toolStripButton_30.Size = new Size(23, 22);
			this.toolStripButton_30.Text = "Удалить";
			this.toolStripButton_30.Click += this.toolStripButton_30_Click;
			this.toolStripSeparator_10.Name = "tssRefreshRepair";
			this.toolStripSeparator_10.Size = new Size(6, 25);
			this.toolStripButton_31.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_31.Image = Resources.smethod_45();
			this.toolStripButton_31.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_31.Name = "tspRefreshRepair";
			this.toolStripButton_31.Size = new Size(23, 22);
			this.toolStripButton_31.Text = "Обновить";
			this.toolStripButton_31.Click += this.ISDFONQRUF;
			this.tabPage_7.Controls.Add(this.tableLayoutPanel_6);
			this.tabPage_7.Location = new Point(4, 22);
			this.tabPage_7.Name = "tpBalance";
			this.tabPage_7.Padding = new Padding(3);
			this.tabPage_7.Size = new Size(489, 125);
			this.tabPage_7.TabIndex = 5;
			this.tabPage_7.Text = "Принятие на баланс";
			this.tabPage_7.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_6.ColumnCount = 1;
			this.tableLayoutPanel_6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_6.Controls.Add(this.dataGridView_3, 0, 1);
			this.tableLayoutPanel_6.Controls.Add(this.toolStrip_9, 0, 0);
			this.tableLayoutPanel_6.Dock = DockStyle.Fill;
			this.tableLayoutPanel_6.Location = new Point(3, 3);
			this.tableLayoutPanel_6.Name = "tlpBalance";
			this.tableLayoutPanel_6.RowCount = 2;
			this.tableLayoutPanel_6.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_6.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_6.Size = new Size(483, 119);
			this.tableLayoutPanel_6.TabIndex = 1;
			this.dataGridView_3.AllowUserToAddRows = false;
			this.dataGridView_3.AllowUserToDeleteRows = false;
			this.dataGridView_3.AllowUserToResizeRows = false;
			this.dataGridView_3.BackgroundColor = Color.White;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = SystemColors.Control;
			dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.dataGridView_3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView_3.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_187,
				this.dataGridViewTextBoxColumn_188,
				this.dataGridViewTextBoxColumn_189,
				this.dataGridViewTextBoxColumn_190,
				this.dataGridViewTextBoxColumn_191,
				this.dataGridViewTextBoxColumn_192,
				this.dataGridViewTextBoxColumn_193,
				this.dataGridViewTextBoxColumn_194,
				this.dataGridViewTextBoxColumn_195,
				this.dataGridViewTextBoxColumn_196,
				this.dataGridViewTextBoxColumn_197,
				this.dataGridViewTextBoxColumn_198,
				this.dataGridViewTextBoxColumn_199,
				this.dataGridViewTextBoxColumn_200,
				this.dataGridViewTextBoxColumn_201,
				this.dataGridViewTextBoxColumn_202,
				this.dataGridViewTextBoxColumn_203
			});
			this.dataGridView_3.ContextMenuStrip = this.contextMenuStrip_2;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = SystemColors.Window;
			dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle5.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
			this.dataGridView_3.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView_3.Dock = DockStyle.Fill;
			this.dataGridView_3.Location = new Point(3, 28);
			this.dataGridView_3.MultiSelect = false;
			this.dataGridView_3.Name = "dgvBalance";
			this.dataGridView_3.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = SystemColors.Control;
			dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			this.dataGridView_3.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView_3.RowHeadersVisible = false;
			this.dataGridView_3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_3.Size = new Size(477, 88);
			this.dataGridView_3.TabIndex = 1;
			this.dataGridView_3.CellDoubleClick += this.dataGridView_3_CellDoubleClick;
			this.dataGridViewTextBoxColumn_187.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_187.HeaderText = "idBalance";
			this.dataGridViewTextBoxColumn_187.Name = "idBalance";
			this.dataGridViewTextBoxColumn_187.ReadOnly = true;
			this.dataGridViewTextBoxColumn_187.Visible = false;
			this.dataGridViewTextBoxColumn_188.DataPropertyName = "idAbn";
			this.dataGridViewTextBoxColumn_188.HeaderText = "idAbn";
			this.dataGridViewTextBoxColumn_188.Name = "idAbnDgvBalance";
			this.dataGridViewTextBoxColumn_188.ReadOnly = true;
			this.dataGridViewTextBoxColumn_188.Visible = false;
			this.dataGridViewTextBoxColumn_189.DataPropertyName = "idSector";
			this.dataGridViewTextBoxColumn_189.HeaderText = "idSector";
			this.dataGridViewTextBoxColumn_189.Name = "idSectorDgvBalance";
			this.dataGridViewTextBoxColumn_189.ReadOnly = true;
			this.dataGridViewTextBoxColumn_189.Visible = false;
			this.dataGridViewTextBoxColumn_190.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_190.HeaderText = "ParentIdBalance";
			this.dataGridViewTextBoxColumn_190.Name = "ParentIdBalance";
			this.dataGridViewTextBoxColumn_190.ReadOnly = true;
			this.dataGridViewTextBoxColumn_190.Visible = false;
			this.dataGridViewTextBoxColumn_191.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_191.HeaderText = "idObjListBalance";
			this.dataGridViewTextBoxColumn_191.Name = "idObjListBalance";
			this.dataGridViewTextBoxColumn_191.ReadOnly = true;
			this.dataGridViewTextBoxColumn_191.Visible = false;
			this.dataGridViewTextBoxColumn_192.DataPropertyName = "TypeDoc";
			this.dataGridViewTextBoxColumn_192.HeaderText = "idTypeDoc";
			this.dataGridViewTextBoxColumn_192.Name = "TypeDocBalance";
			this.dataGridViewTextBoxColumn_192.ReadOnly = true;
			this.dataGridViewTextBoxColumn_192.Visible = false;
			this.dataGridViewTextBoxColumn_193.DataPropertyName = "DateDoc";
			this.dataGridViewTextBoxColumn_193.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_193.Name = "DateDocBalance";
			this.dataGridViewTextBoxColumn_193.ReadOnly = true;
			this.dataGridViewTextBoxColumn_194.DataPropertyName = "NumberDoc";
			this.dataGridViewTextBoxColumn_194.HeaderText = "Номер приказа";
			this.dataGridViewTextBoxColumn_194.Name = "NumberDocBalance";
			this.dataGridViewTextBoxColumn_194.ReadOnly = true;
			this.dataGridViewTextBoxColumn_195.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_195.HeaderText = "От кого";
			this.dataGridViewTextBoxColumn_195.Name = "CommentBalance";
			this.dataGridViewTextBoxColumn_195.ReadOnly = true;
			this.dataGridViewTextBoxColumn_196.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_196.DataPropertyName = "Comment2";
			this.dataGridViewTextBoxColumn_196.HeaderText = "Примечание";
			this.dataGridViewTextBoxColumn_196.Name = "Comment2Balance";
			this.dataGridViewTextBoxColumn_196.ReadOnly = true;
			this.dataGridViewTextBoxColumn_197.DataPropertyName = "typeDocName";
			this.dataGridViewTextBoxColumn_197.HeaderText = "Тип документа";
			this.dataGridViewTextBoxColumn_197.Name = "typeDocNameDgvBalance";
			this.dataGridViewTextBoxColumn_197.ReadOnly = true;
			this.dataGridViewTextBoxColumn_197.Visible = false;
			this.dataGridViewTextBoxColumn_198.DataPropertyName = "sector";
			this.dataGridViewTextBoxColumn_198.HeaderText = "Участок";
			this.dataGridViewTextBoxColumn_198.Name = "sectorDgvBalance";
			this.dataGridViewTextBoxColumn_198.ReadOnly = true;
			this.dataGridViewTextBoxColumn_198.Visible = false;
			this.dataGridViewTextBoxColumn_199.DataPropertyName = "abnName";
			this.dataGridViewTextBoxColumn_199.HeaderText = "От кого";
			this.dataGridViewTextBoxColumn_199.Name = "abnNameDgvBalance";
			this.dataGridViewTextBoxColumn_199.ReadOnly = true;
			this.dataGridViewTextBoxColumn_199.Visible = false;
			this.dataGridViewTextBoxColumn_200.DataPropertyName = "comment";
			this.dataGridViewTextBoxColumn_200.HeaderText = "Примечание";
			this.dataGridViewTextBoxColumn_200.Name = "commentDgvBalance";
			this.dataGridViewTextBoxColumn_200.ReadOnly = true;
			this.dataGridViewTextBoxColumn_200.Visible = false;
			this.dataGridViewTextBoxColumn_201.DataPropertyName = "pylons";
			this.dataGridViewTextBoxColumn_201.HeaderText = "Опоры";
			this.dataGridViewTextBoxColumn_201.Name = "PylonsDgvBalance";
			this.dataGridViewTextBoxColumn_201.ReadOnly = true;
			this.dataGridViewTextBoxColumn_201.Visible = false;
			this.dataGridViewTextBoxColumn_201.Width = 160;
			this.dataGridViewTextBoxColumn_202.DataPropertyName = "isActive";
			this.dataGridViewTextBoxColumn_202.HeaderText = "isActiveBalance";
			this.dataGridViewTextBoxColumn_202.Name = "isActiveBalance";
			this.dataGridViewTextBoxColumn_202.ReadOnly = true;
			this.dataGridViewTextBoxColumn_202.Visible = false;
			this.dataGridViewTextBoxColumn_203.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_203.HeaderText = "DeletedBalance";
			this.dataGridViewTextBoxColumn_203.Name = "DeletedBalance";
			this.dataGridViewTextBoxColumn_203.ReadOnly = true;
			this.dataGridViewTextBoxColumn_203.Visible = false;
			this.contextMenuStrip_2.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_5,
				this.toolStripMenuItem_6,
				this.toolStripSeparator_15,
				this.toolStripMenuItem_7,
				this.toolStripSeparator_16,
				this.toolStripMenuItem_8
			});
			this.contextMenuStrip_2.Name = "cmsBalance";
			this.contextMenuStrip_2.Size = new Size(155, 104);
			this.toolStripMenuItem_5.Image = Resources.smethod_24();
			this.toolStripMenuItem_5.Name = "tsmiAddBalance";
			this.toolStripMenuItem_5.Size = new Size(154, 22);
			this.toolStripMenuItem_5.Text = "Добавить";
			this.toolStripMenuItem_5.Click += this.toolStripMenuItem_5_Click;
			this.toolStripMenuItem_6.Image = Resources.smethod_26();
			this.toolStripMenuItem_6.Name = "tsmiEditBalance";
			this.toolStripMenuItem_6.Size = new Size(154, 22);
			this.toolStripMenuItem_6.Text = "Редактировать";
			this.toolStripMenuItem_6.Click += this.toolStripMenuItem_6_Click;
			this.toolStripSeparator_15.Name = "tssiDeleteBalance";
			this.toolStripSeparator_15.Size = new Size(151, 6);
			this.toolStripMenuItem_7.Image = Resources.smethod_25();
			this.toolStripMenuItem_7.Name = "tsmiDeleteBalance";
			this.toolStripMenuItem_7.Size = new Size(154, 22);
			this.toolStripMenuItem_7.Text = "Удалить";
			this.toolStripMenuItem_7.Click += this.toolStripMenuItem_7_Click;
			this.toolStripSeparator_16.Name = "tssiRefreshBalance";
			this.toolStripSeparator_16.Size = new Size(151, 6);
			this.toolStripMenuItem_8.Image = Resources.smethod_45();
			this.toolStripMenuItem_8.Name = "tsmiRefreshBalance";
			this.toolStripMenuItem_8.Size = new Size(154, 22);
			this.toolStripMenuItem_8.Text = "Обновить";
			this.toolStripMenuItem_8.Click += this.toolStripMenuItem_8_Click;
			this.toolStrip_9.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_32,
				this.toolStripDropDownButton_2,
				this.toolStripButton_33,
				this.toolStripSeparator_11,
				this.toolStripButton_34,
				this.toolStripSeparator_12,
				this.toolStripButton_35
			});
			this.toolStrip_9.Location = new Point(0, 0);
			this.toolStrip_9.Name = "tsBalance";
			this.toolStrip_9.Size = new Size(483, 25);
			this.toolStrip_9.TabIndex = 0;
			this.toolStrip_9.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_32.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_32.Image = Resources.smethod_24();
			this.toolStripButton_32.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_32.Name = "tsbAddBalance";
			this.toolStripButton_32.Size = new Size(23, 22);
			this.toolStripButton_32.Text = "Добавить";
			this.toolStripButton_32.Click += this.toolStripButton_32_Click;
			this.toolStripDropDownButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton_2.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_63,
				this.toolStripMenuItem_64
			});
			this.toolStripDropDownButton_2.Image = Resources.smethod_24();
			this.toolStripDropDownButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripDropDownButton_2.Name = "tsddAddBalanceDoc";
			this.toolStripDropDownButton_2.Size = new Size(29, 22);
			this.toolStripDropDownButton_2.Text = "Добавить документ";
			this.toolStripMenuItem_63.Name = "tsmiAddBalanceDoc";
			this.toolStripMenuItem_63.Size = new Size(244, 22);
			this.toolStripMenuItem_63.Text = "Принятие на баланс";
			this.toolStripMenuItem_63.Click += this.toolStripMenuItem_69_Click;
			this.toolStripMenuItem_64.Name = "tsmiAddUpgradeDoc";
			this.toolStripMenuItem_64.Size = new Size(244, 22);
			this.toolStripMenuItem_64.Text = "Модернизация/реконструкция";
			this.toolStripMenuItem_64.Click += this.toolStripMenuItem_70_Click;
			this.toolStripButton_33.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_33.Image = Resources.smethod_26();
			this.toolStripButton_33.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_33.Name = "tsbEditBalance";
			this.toolStripButton_33.Size = new Size(23, 22);
			this.toolStripButton_33.Text = "Редактировать";
			this.toolStripButton_33.Click += this.toolStripMenuItem_71_Click;
			this.toolStripSeparator_11.Name = "tssDeleteBalance";
			this.toolStripSeparator_11.Size = new Size(6, 25);
			this.toolStripButton_34.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_34.Image = Resources.smethod_25();
			this.toolStripButton_34.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_34.Name = "tsbDeleteBalance";
			this.toolStripButton_34.Size = new Size(23, 22);
			this.toolStripButton_34.Text = "Удалить";
			this.toolStripButton_34.Click += this.toolStripMenuItem_72_Click;
			this.toolStripSeparator_12.Name = "tssRefreshBalance";
			this.toolStripSeparator_12.Size = new Size(6, 25);
			this.toolStripButton_35.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_35.Image = Resources.smethod_45();
			this.toolStripButton_35.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_35.Name = "tsbRefreshBalance";
			this.toolStripButton_35.Size = new Size(23, 22);
			this.toolStripButton_35.Text = "Обновить";
			this.toolStripButton_35.Click += this.toolStripButton_35_Click;
			this.tabPage_8.Controls.Add(this.tableLayoutPanel_7);
			this.tabPage_8.Location = new Point(4, 22);
			this.tabPage_8.Name = "tpBuildRepair";
			this.tabPage_8.Padding = new Padding(3);
			this.tabPage_8.Size = new Size(489, 125);
			this.tabPage_8.TabIndex = 6;
			this.tabPage_8.Text = "Ремонт строительной части";
			this.tabPage_8.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_7.ColumnCount = 1;
			this.tableLayoutPanel_7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_7.Controls.Add(this.dataGridView_4, 0, 1);
			this.tableLayoutPanel_7.Controls.Add(this.toolStrip_10, 0, 0);
			this.tableLayoutPanel_7.Dock = DockStyle.Fill;
			this.tableLayoutPanel_7.Location = new Point(3, 3);
			this.tableLayoutPanel_7.Name = "tlpBuildRepair";
			this.tableLayoutPanel_7.RowCount = 2;
			this.tableLayoutPanel_7.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_7.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_7.Size = new Size(483, 119);
			this.tableLayoutPanel_7.TabIndex = 0;
			this.dataGridView_4.AllowUserToAddRows = false;
			this.dataGridView_4.AllowUserToDeleteRows = false;
			this.dataGridView_4.AllowUserToResizeRows = false;
			this.dataGridView_4.BackgroundColor = Color.White;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = SystemColors.Control;
			dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			this.dataGridView_4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridView_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_4.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_30,
				this.dataGridViewTextBoxColumn_31,
				this.dataGridViewTextBoxColumn_32,
				this.dataGridViewTextBoxColumn_33,
				this.dataGridViewTextBoxColumn_34,
				this.dataGridViewTextBoxColumn_35,
				this.dataGridViewTextBoxColumn_36,
				this.dataGridViewTextBoxColumn_37,
				this.dataGridViewTextBoxColumn_38,
				this.dataGridViewTextBoxColumn_39,
				this.dataGridViewTextBoxColumn_40,
				this.dataGridViewTextBoxColumn_41,
				this.dataGridViewTextBoxColumn_42,
				this.dataGridViewTextBoxColumn_43
			});
			this.dataGridView_4.ContextMenuStrip = this.contextMenuStrip_3;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = SystemColors.Window;
			dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle8.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
			this.dataGridView_4.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridView_4.Dock = DockStyle.Fill;
			this.dataGridView_4.Location = new Point(3, 28);
			this.dataGridView_4.MultiSelect = false;
			this.dataGridView_4.Name = "dgvBuildRepair";
			this.dataGridView_4.ReadOnly = true;
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = SystemColors.Control;
			dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			this.dataGridView_4.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridView_4.RowHeadersVisible = false;
			this.dataGridView_4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_4.Size = new Size(477, 88);
			this.dataGridView_4.TabIndex = 1;
			this.dataGridView_4.CellDoubleClick += this.dataGridView_4_CellDoubleClick;
			this.dataGridViewTextBoxColumn_30.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_30.HeaderText = "idBuildRepair";
			this.dataGridViewTextBoxColumn_30.Name = "idBuildRepair";
			this.dataGridViewTextBoxColumn_30.ReadOnly = true;
			this.dataGridViewTextBoxColumn_30.Visible = false;
			this.dataGridViewTextBoxColumn_31.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_31.HeaderText = "idObjListBuildRepair";
			this.dataGridViewTextBoxColumn_31.Name = "idObjListBuildRepair";
			this.dataGridViewTextBoxColumn_31.ReadOnly = true;
			this.dataGridViewTextBoxColumn_31.Visible = false;
			this.dataGridViewTextBoxColumn_32.DataPropertyName = "DateFactRepair";
			this.dataGridViewTextBoxColumn_32.HeaderText = "Дата ремонта (факт.)";
			this.dataGridViewTextBoxColumn_32.Name = "dateFactRepairBuildRepair";
			this.dataGridViewTextBoxColumn_32.ReadOnly = true;
			this.dataGridViewTextBoxColumn_32.Width = 140;
			this.dataGridViewTextBoxColumn_33.DataPropertyName = "DateFactRepairComm";
			this.dataGridViewTextBoxColumn_33.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_33.Name = "DateFactRepairComm";
			this.dataGridViewTextBoxColumn_33.ReadOnly = true;
			this.dataGridViewTextBoxColumn_34.DataPropertyName = "DatePlanRepair";
			this.dataGridViewTextBoxColumn_34.HeaderText = "Дата ремонта (план.)";
			this.dataGridViewTextBoxColumn_34.Name = "datePlanRepairBuildRepair";
			this.dataGridViewTextBoxColumn_34.ReadOnly = true;
			this.dataGridViewTextBoxColumn_34.Width = 140;
			this.dataGridViewTextBoxColumn_35.DataPropertyName = "DatePlanRepairComm";
			this.dataGridViewTextBoxColumn_35.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_35.Name = "DatePlanRepairComm";
			this.dataGridViewTextBoxColumn_35.ReadOnly = true;
			this.dataGridViewTextBoxColumn_36.DataPropertyName = "DateHousetopRepair";
			this.dataGridViewTextBoxColumn_36.HeaderText = "Дата ремонта крыши";
			this.dataGridViewTextBoxColumn_36.Name = "dateHousetopRepairBuildRepair";
			this.dataGridViewTextBoxColumn_36.ReadOnly = true;
			this.dataGridViewTextBoxColumn_36.Width = 140;
			this.dataGridViewTextBoxColumn_37.DataPropertyName = "DateHousetopRepairComm";
			this.dataGridViewTextBoxColumn_37.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_37.Name = "DateHousetopRepairComm";
			this.dataGridViewTextBoxColumn_37.ReadOnly = true;
			this.dataGridViewTextBoxColumn_38.DataPropertyName = "DoorType";
			this.dataGridViewTextBoxColumn_38.HeaderText = "Тип двери";
			this.dataGridViewTextBoxColumn_38.Name = "DoorType";
			this.dataGridViewTextBoxColumn_38.ReadOnly = true;
			this.dataGridViewTextBoxColumn_39.DataPropertyName = "DoorRepair";
			this.dataGridViewTextBoxColumn_39.HeaderText = "Ремонт двери";
			this.dataGridViewTextBoxColumn_39.Name = "DoorRepair";
			this.dataGridViewTextBoxColumn_39.ReadOnly = true;
			this.dataGridViewTextBoxColumn_40.DataPropertyName = "OtmostRepair";
			this.dataGridViewTextBoxColumn_40.HeaderText = "Ремонт отмоста";
			this.dataGridViewTextBoxColumn_40.Name = "OtmostRepair";
			this.dataGridViewTextBoxColumn_40.ReadOnly = true;
			this.dataGridViewTextBoxColumn_41.DataPropertyName = "Company";
			this.dataGridViewTextBoxColumn_41.HeaderText = "Организация - подрядчик";
			this.dataGridViewTextBoxColumn_41.Name = "Company";
			this.dataGridViewTextBoxColumn_41.ReadOnly = true;
			this.dataGridViewTextBoxColumn_42.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_42.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_42.Name = "BuildSubsRepairRepairComm";
			this.dataGridViewTextBoxColumn_42.ReadOnly = true;
			this.dataGridViewTextBoxColumn_43.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_43.HeaderText = "deletedBuildRepair";
			this.dataGridViewTextBoxColumn_43.Name = "deletedBuildRepair";
			this.dataGridViewTextBoxColumn_43.ReadOnly = true;
			this.dataGridViewTextBoxColumn_43.Visible = false;
			this.contextMenuStrip_3.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_9,
				this.toolStripMenuItem_10,
				this.toolStripSeparator_19,
				this.toolStripMenuItem_11,
				this.toolStripSeparator_20,
				this.toolStripMenuItem_12
			});
			this.contextMenuStrip_3.Name = "cmsBuildRepair";
			this.contextMenuStrip_3.Size = new Size(155, 104);
			this.toolStripMenuItem_9.Image = Resources.smethod_24();
			this.toolStripMenuItem_9.Name = "tsmiAddBuildRepair";
			this.toolStripMenuItem_9.Size = new Size(154, 22);
			this.toolStripMenuItem_9.Text = "Добавить";
			this.toolStripMenuItem_9.Click += this.toolStripMenuItem_9_Click;
			this.toolStripMenuItem_10.Image = Resources.smethod_26();
			this.toolStripMenuItem_10.Name = "tsmiEditBuildRepair";
			this.toolStripMenuItem_10.Size = new Size(154, 22);
			this.toolStripMenuItem_10.Text = "Редактировать";
			this.toolStripMenuItem_10.Click += this.toolStripMenuItem_10_Click;
			this.toolStripSeparator_19.Name = "tssDeleteBuildRepair";
			this.toolStripSeparator_19.Size = new Size(151, 6);
			this.toolStripMenuItem_11.Image = Resources.smethod_25();
			this.toolStripMenuItem_11.Name = "tsmiDeleteBuildRepair";
			this.toolStripMenuItem_11.Size = new Size(154, 22);
			this.toolStripMenuItem_11.Text = "Удалить";
			this.toolStripMenuItem_11.Click += this.toolStripMenuItem_11_Click;
			this.toolStripSeparator_20.Name = "tssiRefreshBuildRepair";
			this.toolStripSeparator_20.Size = new Size(151, 6);
			this.toolStripMenuItem_12.Image = Resources.smethod_45();
			this.toolStripMenuItem_12.Name = "tsmiRefreshBuildRepair";
			this.toolStripMenuItem_12.Size = new Size(154, 22);
			this.toolStripMenuItem_12.Text = "Обновить";
			this.toolStripMenuItem_12.Click += this.toolStripMenuItem_12_Click;
			this.toolStrip_10.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_36,
				this.toolStripButton_37,
				this.toolStripSeparator_17,
				this.toolStripButton_38,
				this.toolStripSeparator_18,
				this.toolStripButton_39,
				this.toolStripButton_40
			});
			this.toolStrip_10.Location = new Point(0, 0);
			this.toolStrip_10.Name = "tsBuildRepair";
			this.toolStrip_10.Size = new Size(483, 25);
			this.toolStrip_10.TabIndex = 0;
			this.toolStrip_10.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_36.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_36.Image = Resources.smethod_24();
			this.toolStripButton_36.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_36.Name = "tsbAddBuildRepair";
			this.toolStripButton_36.Size = new Size(23, 22);
			this.toolStripButton_36.Text = "Добавить";
			this.toolStripButton_36.Click += this.toolStripButton_36_Click;
			this.toolStripButton_37.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_37.Image = Resources.smethod_26();
			this.toolStripButton_37.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_37.Name = "tsbEditBuildRepair";
			this.toolStripButton_37.Size = new Size(23, 22);
			this.toolStripButton_37.Text = "Редактировать";
			this.toolStripButton_37.Click += this.toolStripButton_37_Click;
			this.toolStripSeparator_17.Name = "tssDeletedBuildRepair";
			this.toolStripSeparator_17.Size = new Size(6, 25);
			this.toolStripButton_38.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_38.Image = Resources.smethod_25();
			this.toolStripButton_38.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_38.Name = "tsbDeleteBuildRepair";
			this.toolStripButton_38.Size = new Size(23, 22);
			this.toolStripButton_38.Text = "Удалить";
			this.toolStripButton_38.Click += this.toolStripButton_38_Click;
			this.toolStripSeparator_18.Name = "tssRefreshBuildRepair";
			this.toolStripSeparator_18.Size = new Size(6, 25);
			this.toolStripButton_39.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_39.Image = Resources.smethod_45();
			this.toolStripButton_39.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_39.Name = "tsbRefreshBuildRepair";
			this.toolStripButton_39.Size = new Size(23, 22);
			this.toolStripButton_39.Text = "Обновить";
			this.toolStripButton_39.Click += this.toolStripButton_39_Click;
			this.toolStripButton_40.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripButton_40.Image = (Image)componentResourceManager.GetObject("tsbLoadOldBuildRepair.Image");
			this.toolStripButton_40.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_40.Name = "tsbLoadOldBuildRepair";
			this.toolStripButton_40.Size = new Size(151, 22);
			this.toolStripButton_40.Text = "Загрузить из старой базы";
			this.toolStripButton_40.Visible = false;
			this.tabPage_9.Controls.Add(this.tableLayoutPanel_9);
			this.tabPage_9.Location = new Point(4, 22);
			this.tabPage_9.Name = "tpCableTesting";
			this.tabPage_9.Padding = new Padding(3);
			this.tabPage_9.Size = new Size(489, 125);
			this.tabPage_9.TabIndex = 7;
			this.tabPage_9.Text = "Испытание кабеля";
			this.tabPage_9.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_9.ColumnCount = 1;
			this.tableLayoutPanel_9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_9.Controls.Add(this.dataGridView_5, 0, 1);
			this.tableLayoutPanel_9.Controls.Add(this.ErxDoVobWm, 0, 0);
			this.tableLayoutPanel_9.Dock = DockStyle.Fill;
			this.tableLayoutPanel_9.Location = new Point(3, 3);
			this.tableLayoutPanel_9.Name = "tlpCableTesting";
			this.tableLayoutPanel_9.RowCount = 2;
			this.tableLayoutPanel_9.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_9.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_9.Size = new Size(483, 119);
			this.tableLayoutPanel_9.TabIndex = 0;
			this.dataGridView_5.AllowUserToAddRows = false;
			this.dataGridView_5.AllowUserToDeleteRows = false;
			this.dataGridView_5.AllowUserToResizeRows = false;
			this.dataGridView_5.AutoGenerateColumns = false;
			this.dataGridView_5.BackgroundColor = Color.White;
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = SystemColors.Control;
			dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
			this.dataGridView_5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridView_5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_5.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_1,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_9,
				this.dataGridViewTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_11
			});
			this.dataGridView_5.ContextMenuStrip = this.contextMenuStrip_6;
			this.dataGridView_5.DataSource = this.bindingSource_0;
			dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = SystemColors.Window;
			dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle11.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
			this.dataGridView_5.DefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridView_5.Dock = DockStyle.Fill;
			this.dataGridView_5.Location = new Point(3, 28);
			this.dataGridView_5.MultiSelect = false;
			this.dataGridView_5.Name = "dgvCableTesting";
			this.dataGridView_5.ReadOnly = true;
			dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = SystemColors.Control;
			dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
			this.dataGridView_5.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridView_5.RowHeadersVisible = false;
			this.dataGridView_5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_5.Size = new Size(477, 88);
			this.dataGridView_5.TabIndex = 1;
			this.dataGridView_5.CellDoubleClick += this.dataGridView_5_CellDoubleClick;
			this.dataGridViewCheckBoxColumn_1.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_1.HeaderText = "DeletedCabTesting";
			this.dataGridViewCheckBoxColumn_1.Name = "deletedCabTesting";
			this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_5.HeaderText = "idCabTesting";
			this.dataGridViewTextBoxColumn_5.Name = "idCabTesting";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_6.HeaderText = "idObjListCabTesting";
			this.dataGridViewTextBoxColumn_6.Name = "idObjListCabTesting";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn_7.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_7.Name = "dateCabTesting";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_8.HeaderText = "Причина";
			this.dataGridViewTextBoxColumn_8.Name = "NameCabTesting";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "Voltage";
			this.dataGridViewTextBoxColumn_9.HeaderText = "Напряжение";
			this.dataGridViewTextBoxColumn_9.Name = "VoltageCabTesting";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "Duration";
			this.dataGridViewTextBoxColumn_10.HeaderText = "Продолжительность";
			this.dataGridViewTextBoxColumn_10.Name = "durationCabTesting";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.Width = 140;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "Conclusion";
			this.dataGridViewTextBoxColumn_11.HeaderText = "Заключение";
			this.dataGridViewTextBoxColumn_11.Name = "conclusionCabTesting";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.contextMenuStrip_6.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_24,
				this.toolStripMenuItem_25,
				this.toolStripSeparator_31,
				this.toolStripMenuItem_26,
				this.toolStripSeparator_32,
				this.toolStripMenuItem_27
			});
			this.contextMenuStrip_6.Name = "cmsCabTesting";
			this.contextMenuStrip_6.Size = new Size(155, 104);
			this.toolStripMenuItem_24.Image = Resources.smethod_24();
			this.toolStripMenuItem_24.Name = "tsmiCabTestingAdd";
			this.toolStripMenuItem_24.Size = new Size(154, 22);
			this.toolStripMenuItem_24.Text = "Добавить";
			this.toolStripMenuItem_24.Click += this.toolStripButton_48_Click;
			this.toolStripMenuItem_25.Image = Resources.smethod_26();
			this.toolStripMenuItem_25.Name = "tsmiCabTestingEdit";
			this.toolStripMenuItem_25.Size = new Size(154, 22);
			this.toolStripMenuItem_25.Text = "Редактировать";
			this.toolStripMenuItem_25.Click += this.toolStripButton_49_Click;
			this.toolStripSeparator_31.Name = "tssCabTestingDelete";
			this.toolStripSeparator_31.Size = new Size(151, 6);
			this.toolStripMenuItem_26.Image = Resources.smethod_25();
			this.toolStripMenuItem_26.Name = "tsmiCabTestingDelete";
			this.toolStripMenuItem_26.Size = new Size(154, 22);
			this.toolStripMenuItem_26.Text = "Удалить";
			this.toolStripMenuItem_26.Click += this.toolStripButton_50_Click;
			this.toolStripSeparator_32.Name = "tssCabTestingRefresh";
			this.toolStripSeparator_32.Size = new Size(151, 6);
			this.toolStripMenuItem_27.Image = Resources.smethod_45();
			this.toolStripMenuItem_27.Name = "tsmiCabTestingRefresh";
			this.toolStripMenuItem_27.Size = new Size(154, 22);
			this.toolStripMenuItem_27.Text = "Обновить";
			this.toolStripMenuItem_27.Click += this.toolStripButton_51_Click;
			this.bindingSource_0.DataMember = "vP_CabTesting";
			this.bindingSource_0.DataSource = this.class107_0;
			this.bindingSource_0.Sort = "Date";
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.ErxDoVobWm.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_48,
				this.toolStripButton_49,
				this.toolStripSeparator_29,
				this.toolStripButton_50,
				this.toolStripSeparator_30,
				this.toolStripButton_51
			});
			this.ErxDoVobWm.Location = new Point(0, 0);
			this.ErxDoVobWm.Name = "tsCableTesting";
			this.ErxDoVobWm.Size = new Size(483, 25);
			this.ErxDoVobWm.TabIndex = 0;
			this.ErxDoVobWm.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_48.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_48.Image = Resources.smethod_24();
			this.toolStripButton_48.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_48.Name = "tsbCableTestAdd";
			this.toolStripButton_48.Size = new Size(23, 22);
			this.toolStripButton_48.Text = "Добавить";
			this.toolStripButton_48.Click += this.toolStripButton_48_Click;
			this.toolStripButton_49.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_49.Image = Resources.smethod_26();
			this.toolStripButton_49.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_49.Name = "tsbCableTestEdit";
			this.toolStripButton_49.Size = new Size(23, 22);
			this.toolStripButton_49.Text = "Редактировать";
			this.toolStripButton_49.Click += this.toolStripButton_49_Click;
			this.toolStripSeparator_29.Name = "toolStripSeparator6";
			this.toolStripSeparator_29.Size = new Size(6, 25);
			this.toolStripButton_50.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_50.Image = Resources.smethod_25();
			this.toolStripButton_50.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_50.Name = "tsbCableTestDelete";
			this.toolStripButton_50.Size = new Size(23, 22);
			this.toolStripButton_50.Text = "Удалить";
			this.toolStripButton_50.Click += this.toolStripButton_50_Click;
			this.toolStripSeparator_30.Name = "toolStripSeparator8";
			this.toolStripSeparator_30.Size = new Size(6, 25);
			this.toolStripButton_51.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_51.Image = Resources.smethod_45();
			this.toolStripButton_51.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_51.Name = "tsbCableTestRefresh";
			this.toolStripButton_51.Size = new Size(23, 22);
			this.toolStripButton_51.Text = "Обновить";
			this.toolStripButton_51.Click += this.toolStripButton_51_Click;
			this.tabPage_10.Controls.Add(this.tableLayoutPanel_10);
			this.tabPage_10.Location = new Point(4, 22);
			this.tabPage_10.Name = "tpCableOperation";
			this.tabPage_10.Padding = new Padding(3);
			this.tabPage_10.Size = new Size(489, 125);
			this.tabPage_10.TabIndex = 8;
			this.tabPage_10.Text = "Эксплуатация";
			this.tabPage_10.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_10.ColumnCount = 1;
			this.tableLayoutPanel_10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_10.Controls.Add(this.dataGridView_6, 0, 1);
			this.tableLayoutPanel_10.Controls.Add(this.toolStrip_13, 0, 0);
			this.tableLayoutPanel_10.Dock = DockStyle.Fill;
			this.tableLayoutPanel_10.Location = new Point(3, 3);
			this.tableLayoutPanel_10.Name = "tlpCableOperation";
			this.tableLayoutPanel_10.RowCount = 2;
			this.tableLayoutPanel_10.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_10.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_10.Size = new Size(483, 119);
			this.tableLayoutPanel_10.TabIndex = 0;
			this.dataGridView_6.AllowUserToAddRows = false;
			this.dataGridView_6.AllowUserToDeleteRows = false;
			this.dataGridView_6.AllowUserToResizeRows = false;
			this.dataGridView_6.AutoGenerateColumns = false;
			this.dataGridView_6.BackgroundColor = Color.White;
			dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.BackColor = SystemColors.Control;
			dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
			this.dataGridView_6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
			this.dataGridView_6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_6.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_10,
				this.dataGridViewTextBoxColumn_170,
				this.dataGridViewTextBoxColumn_171,
				this.dataGridViewTextBoxColumn_172,
				this.dataGridViewTextBoxColumn_173,
				this.dataGridViewTextBoxColumn_174,
				this.dataGridViewTextBoxColumn_175,
				this.dataGridViewTextBoxColumn_176
			});
			this.dataGridView_6.DataSource = this.bindingSource_1;
			dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = SystemColors.Window;
			dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle14.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle14.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
			this.dataGridView_6.DefaultCellStyle = dataGridViewCellStyle14;
			this.dataGridView_6.Dock = DockStyle.Fill;
			this.dataGridView_6.Location = new Point(3, 28);
			this.dataGridView_6.MultiSelect = false;
			this.dataGridView_6.Name = "dgvCableOperation";
			this.dataGridView_6.ReadOnly = true;
			dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle15.BackColor = SystemColors.Control;
			dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
			this.dataGridView_6.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
			this.dataGridView_6.RowHeadersVisible = false;
			this.dataGridView_6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_6.Size = new Size(477, 88);
			this.dataGridView_6.TabIndex = 1;
			this.dataGridView_6.CellDoubleClick += this.dataGridView_6_CellDoubleClick;
			this.dataGridView_6.SelectionChanged += this.dataGridView_6_SelectionChanged;
			this.dataGridViewCheckBoxColumn_10.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_10.HeaderText = "DeletedCabOperation";
			this.dataGridViewCheckBoxColumn_10.Name = "deletedCabOperation";
			this.dataGridViewCheckBoxColumn_10.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_10.Visible = false;
			this.dataGridViewTextBoxColumn_170.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_170.HeaderText = "idCabOperation";
			this.dataGridViewTextBoxColumn_170.Name = "idCabOperation";
			this.dataGridViewTextBoxColumn_170.ReadOnly = true;
			this.dataGridViewTextBoxColumn_170.Visible = false;
			this.dataGridViewTextBoxColumn_171.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_171.HeaderText = "idObjListCabOperation";
			this.dataGridViewTextBoxColumn_171.Name = "idObjListCabOperation";
			this.dataGridViewTextBoxColumn_171.ReadOnly = true;
			this.dataGridViewTextBoxColumn_171.Visible = false;
			this.dataGridViewTextBoxColumn_172.DataPropertyName = "DateDecommissioning";
			this.dataGridViewTextBoxColumn_172.HeaderText = "Дата вывода";
			this.dataGridViewTextBoxColumn_172.Name = "dateDecommissioningCabOperation";
			this.dataGridViewTextBoxColumn_172.ReadOnly = true;
			this.dataGridViewTextBoxColumn_173.DataPropertyName = "DateCommissioning";
			this.dataGridViewTextBoxColumn_173.HeaderText = "Дата ввода";
			this.dataGridViewTextBoxColumn_173.Name = "dateCommissioningCabOperation";
			this.dataGridViewTextBoxColumn_173.ReadOnly = true;
			this.dataGridViewTextBoxColumn_174.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_174.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_174.HeaderText = "Причина";
			this.dataGridViewTextBoxColumn_174.Name = "NameCabOperation";
			this.dataGridViewTextBoxColumn_174.ReadOnly = true;
			this.dataGridViewTextBoxColumn_175.DataPropertyName = "nameDamage";
			this.dataGridViewTextBoxColumn_175.HeaderText = "Дефект";
			this.dataGridViewTextBoxColumn_175.Name = "nameDamageDgvCabOperation";
			this.dataGridViewTextBoxColumn_175.ReadOnly = true;
			this.dataGridViewTextBoxColumn_176.DataPropertyName = "damageApply";
			this.dataGridViewTextBoxColumn_176.HeaderText = "Дата исп-ия дефекта";
			this.dataGridViewTextBoxColumn_176.Name = "damageApplyDgvCabOperation";
			this.dataGridViewTextBoxColumn_176.ReadOnly = true;
			this.bindingSource_1.DataMember = "vP_CabOperation";
			this.bindingSource_1.DataSource = this.class107_0;
			this.toolStrip_13.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripSeparator_33,
				this.toolStripButton_52,
				this.toolStripSeparator_35,
				this.toolStripButton_112,
				this.toolStripButton_113,
				this.toolStripButton_54,
				this.toolStripSeparator_34,
				this.toolStripButton_53
			});
			this.toolStrip_13.Location = new Point(0, 0);
			this.toolStrip_13.Name = "tsCableOperation";
			this.toolStrip_13.Size = new Size(483, 25);
			this.toolStrip_13.TabIndex = 2;
			this.toolStripSeparator_33.Name = "tssCabOperationAccept";
			this.toolStripSeparator_33.Size = new Size(6, 25);
			this.toolStripSeparator_33.Visible = false;
			this.toolStripButton_52.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripButton_52.Image = (Image)componentResourceManager.GetObject("tsbCabOperationAccept.Image");
			this.toolStripButton_52.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_52.Name = "tsbCabOperationAccept";
			this.toolStripButton_52.Size = new Size(57, 22);
			this.toolStripButton_52.Text = "Вывести";
			this.toolStripButton_52.TextImageRelation = TextImageRelation.ImageAboveText;
			this.toolStripButton_52.Visible = false;
			this.toolStripButton_52.Click += this.toolStripButton_52_Click;
			this.toolStripSeparator_35.Name = "tssCabOperationDelete";
			this.toolStripSeparator_35.Size = new Size(6, 25);
			this.toolStripSeparator_35.Visible = false;
			this.toolStripButton_112.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_112.Image = Resources.smethod_24();
			this.toolStripButton_112.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_112.Name = "toolBtnAddCabOperation";
			this.toolStripButton_112.Size = new Size(23, 22);
			this.toolStripButton_112.Text = "Вывести";
			this.toolStripButton_112.Click += this.toolStripButton_112_Click;
			this.toolStripButton_113.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_113.Image = Resources.smethod_26();
			this.toolStripButton_113.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_113.Name = "toolBtnEditCabOperation";
			this.toolStripButton_113.Size = new Size(23, 22);
			this.toolStripButton_113.Text = "Ввести";
			this.toolStripButton_113.Click += this.toolStripButton_113_Click;
			this.toolStripButton_54.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_54.Image = Resources.smethod_25();
			this.toolStripButton_54.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_54.Name = "tsbcabOperationDelete";
			this.toolStripButton_54.Size = new Size(23, 22);
			this.toolStripButton_54.Text = "Удалить";
			this.toolStripButton_54.Click += this.toolStripButton_54_Click;
			this.toolStripSeparator_34.Name = "tssCabOperationRefresh";
			this.toolStripSeparator_34.Size = new Size(6, 25);
			this.toolStripButton_53.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_53.Image = Resources.smethod_45();
			this.toolStripButton_53.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_53.Name = "tsbCabOperationRefresh";
			this.toolStripButton_53.Size = new Size(23, 22);
			this.toolStripButton_53.Text = "Обновление";
			this.toolStripButton_53.Click += this.toolStripButton_53_Click;
			this.pjuAjnsoym.Controls.Add(this.tableLayoutPanel_11);
			this.pjuAjnsoym.Location = new Point(4, 22);
			this.pjuAjnsoym.Name = "tpCabProtocol";
			this.pjuAjnsoym.Padding = new Padding(3);
			this.pjuAjnsoym.Size = new Size(489, 125);
			this.pjuAjnsoym.TabIndex = 9;
			this.pjuAjnsoym.Text = "Протокол";
			this.pjuAjnsoym.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_11.ColumnCount = 1;
			this.tableLayoutPanel_11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_11.Controls.Add(this.dataGridView_7, 0, 1);
			this.tableLayoutPanel_11.Controls.Add(this.toolStrip_14, 0, 0);
			this.tableLayoutPanel_11.Dock = DockStyle.Fill;
			this.tableLayoutPanel_11.Location = new Point(3, 3);
			this.tableLayoutPanel_11.Name = "tlpProtocol";
			this.tableLayoutPanel_11.RowCount = 2;
			this.tableLayoutPanel_11.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_11.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_11.Size = new Size(483, 119);
			this.tableLayoutPanel_11.TabIndex = 0;
			this.dataGridView_7.AllowUserToAddRows = false;
			this.dataGridView_7.AllowUserToDeleteRows = false;
			this.dataGridView_7.AllowUserToResizeRows = false;
			this.dataGridView_7.AutoGenerateColumns = false;
			this.dataGridView_7.BackgroundColor = Color.White;
			dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle16.BackColor = SystemColors.Control;
			dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
			this.dataGridView_7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.dataGridView_7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_7.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_12,
				this.dataGridViewTextBoxColumn_13,
				this.dataGridViewTextBoxColumn_14,
				this.dataGridViewTextBoxColumn_15,
				this.dataGridViewTextBoxColumn_16,
				this.dataGridViewTextBoxColumn_17,
				this.dataGridViewTextBoxColumn_18,
				this.dataGridViewTextBoxColumn_19,
				this.dataGridViewTextBoxColumn_20,
				this.dataGridViewTextBoxColumn_21,
				this.dataGridViewTextBoxColumn_22
			});
			this.dataGridView_7.ContextMenuStrip = this.contextMenuStrip_7;
			this.dataGridView_7.DataSource = this.bindingSource_3;
			dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = SystemColors.Window;
			dataGridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle17.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle17.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
			this.dataGridView_7.DefaultCellStyle = dataGridViewCellStyle17;
			this.dataGridView_7.Dock = DockStyle.Fill;
			this.dataGridView_7.Location = new Point(3, 28);
			this.dataGridView_7.MultiSelect = false;
			this.dataGridView_7.Name = "dgvCabProtocol";
			this.dataGridView_7.ReadOnly = true;
			dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle18.BackColor = SystemColors.Control;
			dataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
			this.dataGridView_7.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
			this.dataGridView_7.RowHeadersVisible = false;
			this.dataGridView_7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_7.Size = new Size(477, 88);
			this.dataGridView_7.TabIndex = 1;
			this.dataGridView_7.CellDoubleClick += this.dataGridView_7_CellDoubleClick;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_12.HeaderText = "idCabProtocol";
			this.dataGridViewTextBoxColumn_12.Name = "idCabProtocol";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_13.HeaderText = "idObjListCabProtocol";
			this.dataGridViewTextBoxColumn_13.Name = "idObjListCabProtocol";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.Visible = false;
			this.dataGridViewTextBoxColumn_14.DataPropertyName = "ProtocolN";
			this.dataGridViewTextBoxColumn_14.HeaderText = "№ ";
			this.dataGridViewTextBoxColumn_14.Name = "ProtocolNCabProtocol";
			this.dataGridViewTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewTextBoxColumn_14.Width = 50;
			this.dataGridViewTextBoxColumn_15.DataPropertyName = "ProtocolTip";
			this.dataGridViewTextBoxColumn_15.HeaderText = "Тип";
			this.dataGridViewTextBoxColumn_15.Name = "ProtocolTipCabProtocol";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_16.DataPropertyName = "PovregTip";
			this.dataGridViewTextBoxColumn_16.HeaderText = "Повреждение";
			this.dataGridViewTextBoxColumn_16.Name = "PovregTip";
			this.dataGridViewTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewTextBoxColumn_17.DataPropertyName = "PovregVid";
			this.dataGridViewTextBoxColumn_17.HeaderText = "Вид повреждения";
			this.dataGridViewTextBoxColumn_17.Name = "PovregVid";
			this.dataGridViewTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewTextBoxColumn_18.DataPropertyName = "PovregData";
			this.dataGridViewTextBoxColumn_18.HeaderText = "Дата поврежд.";
			this.dataGridViewTextBoxColumn_18.Name = "PovregData";
			this.dataGridViewTextBoxColumn_18.ReadOnly = true;
			this.dataGridViewTextBoxColumn_18.Width = 70;
			this.dataGridViewTextBoxColumn_19.DataPropertyName = "RemontData";
			this.dataGridViewTextBoxColumn_19.HeaderText = "Дата ремонта";
			this.dataGridViewTextBoxColumn_19.Name = "RemontData";
			this.dataGridViewTextBoxColumn_19.ReadOnly = true;
			this.dataGridViewTextBoxColumn_19.Width = 70;
			this.dataGridViewTextBoxColumn_20.DataPropertyName = "NaimKL";
			this.dataGridViewTextBoxColumn_20.HeaderText = "Наименование кабеля";
			this.dataGridViewTextBoxColumn_20.Name = "NaimKL";
			this.dataGridViewTextBoxColumn_20.ReadOnly = true;
			this.dataGridViewTextBoxColumn_21.DataPropertyName = "UchN";
			this.dataGridViewTextBoxColumn_21.HeaderText = "№ участка";
			this.dataGridViewTextBoxColumn_21.Name = "UchN";
			this.dataGridViewTextBoxColumn_21.ReadOnly = true;
			this.dataGridViewTextBoxColumn_22.DataPropertyName = "MuftaN";
			this.dataGridViewTextBoxColumn_22.HeaderText = "№ муфты";
			this.dataGridViewTextBoxColumn_22.Name = "MuftaN";
			this.dataGridViewTextBoxColumn_22.ReadOnly = true;
			this.contextMenuStrip_7.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_28,
				this.toolStripMenuItem_29,
				this.toolStripSeparator_37,
				this.toolStripMenuItem_34,
				this.toolStripMenuItem_35,
				this.toolStripSeparator_36,
				this.toolStripMenuItem_30,
				this.toolStripSeparator_45,
				this.toolStripMenuItem_31
			});
			this.contextMenuStrip_7.Name = "cmsBuildRepair";
			this.contextMenuStrip_7.Size = new Size(155, 154);
			this.toolStripMenuItem_28.Image = Resources.smethod_24();
			this.toolStripMenuItem_28.Name = "tsmiCabProtocolAdd";
			this.toolStripMenuItem_28.Size = new Size(154, 22);
			this.toolStripMenuItem_28.Text = "Добавить";
			this.toolStripMenuItem_28.Click += this.toolStripButton_56_Click;
			this.toolStripMenuItem_29.Image = Resources.smethod_26();
			this.toolStripMenuItem_29.Name = "tsmiCabProtocolEdit";
			this.toolStripMenuItem_29.Size = new Size(154, 22);
			this.toolStripMenuItem_29.Text = "Редактировать";
			this.toolStripMenuItem_29.Click += this.toolStripButton_57_Click;
			this.toolStripSeparator_37.Name = "tssiCabProtocolRefresh";
			this.toolStripSeparator_37.Size = new Size(151, 6);
			this.toolStripMenuItem_34.Image = Resources.smethod_49();
			this.toolStripMenuItem_34.Name = "tsmiCabProtocolView";
			this.toolStripMenuItem_34.Size = new Size(154, 22);
			this.toolStripMenuItem_34.Text = "Просмотр";
			this.toolStripMenuItem_34.Click += this.toolStripButton_66_Click;
			this.toolStripMenuItem_35.Image = Resources.smethod_44();
			this.toolStripMenuItem_35.Name = "tsmiCabProtocolPrint";
			this.toolStripMenuItem_35.Size = new Size(154, 22);
			this.toolStripMenuItem_35.Text = "Печать";
			this.toolStripMenuItem_35.Click += this.vXopjPwjcu;
			this.toolStripSeparator_36.Name = "tssiCabProtocolDelete";
			this.toolStripSeparator_36.Size = new Size(151, 6);
			this.toolStripMenuItem_30.Image = Resources.smethod_25();
			this.toolStripMenuItem_30.Name = "tsmiCabProtocolDelete";
			this.toolStripMenuItem_30.Size = new Size(154, 22);
			this.toolStripMenuItem_30.Text = "Удалить";
			this.toolStripMenuItem_30.Click += this.toolStripButton_58_Click;
			this.toolStripSeparator_45.Name = "toolStripSeparator13";
			this.toolStripSeparator_45.Size = new Size(151, 6);
			this.toolStripMenuItem_31.Image = Resources.smethod_45();
			this.toolStripMenuItem_31.Name = "tsmiCabProtocolRefresh";
			this.toolStripMenuItem_31.Size = new Size(154, 22);
			this.toolStripMenuItem_31.Text = "Обновить";
			this.toolStripMenuItem_31.Click += this.toolStripButton_59_Click;
			this.bindingSource_3.DataMember = "vP_CabProtocol";
			this.bindingSource_3.DataSource = this.jtnAdxtlvN;
			this.jtnAdxtlvN.DataSetName = "dsDocuments";
			this.jtnAdxtlvN.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.toolStrip_14.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_56,
				this.toolStripButton_57,
				this.toolStripSeparator_38,
				this.toolStripButton_58,
				this.toolStripSeparator_44,
				this.toolStripButton_66,
				this.toolStripButton_55,
				this.toolStripSeparator_39,
				this.toolStripButton_59
			});
			this.toolStrip_14.Location = new Point(0, 0);
			this.toolStrip_14.Name = "tsProtocol";
			this.toolStrip_14.Size = new Size(483, 25);
			this.toolStrip_14.TabIndex = 0;
			this.toolStrip_14.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_56.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_56.Image = Resources.smethod_24();
			this.toolStripButton_56.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_56.Name = "tsbCabProtocolAdd";
			this.toolStripButton_56.Size = new Size(23, 22);
			this.toolStripButton_56.Text = "Добавить";
			this.toolStripButton_56.Click += this.toolStripButton_56_Click;
			this.toolStripButton_57.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_57.Image = Resources.smethod_26();
			this.toolStripButton_57.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_57.Name = "tsbCabProtocolEdit";
			this.toolStripButton_57.Size = new Size(23, 22);
			this.toolStripButton_57.Text = "Редактировать";
			this.toolStripButton_57.Click += this.toolStripButton_57_Click;
			this.toolStripSeparator_38.Name = "tssCabProtocolDelete";
			this.toolStripSeparator_38.Size = new Size(6, 25);
			this.toolStripButton_58.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_58.Image = Resources.smethod_25();
			this.toolStripButton_58.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_58.Name = "tsbCabProtocolDelete";
			this.toolStripButton_58.Size = new Size(23, 22);
			this.toolStripButton_58.Text = "Удалить";
			this.toolStripButton_58.Click += this.toolStripButton_58_Click;
			this.toolStripSeparator_44.Name = "tssCabProtocolView";
			this.toolStripSeparator_44.Size = new Size(6, 25);
			this.toolStripButton_66.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_66.Image = Resources.smethod_49();
			this.toolStripButton_66.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_66.Name = "tsbCabProtocolView";
			this.toolStripButton_66.Size = new Size(23, 22);
			this.toolStripButton_66.Text = "Просмотреть";
			this.toolStripButton_66.Click += this.toolStripButton_66_Click;
			this.toolStripButton_55.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_55.Image = Resources.smethod_44();
			this.toolStripButton_55.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_55.Name = "tsbCabProtocolShow";
			this.toolStripButton_55.Size = new Size(23, 22);
			this.toolStripButton_55.Text = "Печать";
			this.toolStripButton_55.Click += this.vXopjPwjcu;
			this.toolStripSeparator_39.Name = "tssCabProtocolRefresh";
			this.toolStripSeparator_39.Size = new Size(6, 25);
			this.toolStripButton_59.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_59.Image = Resources.smethod_45();
			this.toolStripButton_59.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_59.Name = "tsbCabProtocolRefresh";
			this.toolStripButton_59.Size = new Size(23, 22);
			this.toolStripButton_59.Text = "Обновить";
			this.toolStripButton_59.Click += this.toolStripButton_59_Click;
			this.tabPage_11.Controls.Add(this.tableLayoutPanel_12);
			this.tabPage_11.Location = new Point(4, 22);
			this.tabPage_11.Name = "tpMove";
			this.tabPage_11.Padding = new Padding(3);
			this.tabPage_11.Size = new Size(489, 125);
			this.tabPage_11.TabIndex = 10;
			this.tabPage_11.Text = "Перемещение";
			this.tabPage_11.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_12.ColumnCount = 1;
			this.tableLayoutPanel_12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_12.Controls.Add(this.toolStrip_15, 0, 0);
			this.tableLayoutPanel_12.Controls.Add(this.dataGridView_8, 0, 1);
			this.tableLayoutPanel_12.Dock = DockStyle.Fill;
			this.tableLayoutPanel_12.Location = new Point(3, 3);
			this.tableLayoutPanel_12.Name = "tlpMove";
			this.tableLayoutPanel_12.RowCount = 2;
			this.tableLayoutPanel_12.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_12.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_12.Size = new Size(483, 119);
			this.tableLayoutPanel_12.TabIndex = 0;
			this.toolStrip_15.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_61,
				this.toolStripButton_65,
				this.toolStripSeparator_41,
				this.toolStripButton_62,
				this.toolStripSeparator_42,
				this.toolStripButton_63,
				this.toolStripSeparator_43,
				this.toolStripButton_64
			});
			this.toolStrip_15.Location = new Point(0, 0);
			this.toolStrip_15.Name = "tsMove";
			this.toolStrip_15.Size = new Size(483, 25);
			this.toolStrip_15.TabIndex = 0;
			this.toolStrip_15.Text = "toolStrip3";
			this.toolStripButton_61.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_61.Image = Resources.smethod_24();
			this.toolStripButton_61.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_61.Name = "tsbAddMove";
			this.toolStripButton_61.Size = new Size(23, 22);
			this.toolStripButton_61.Text = "Добавить перемещение";
			this.toolStripButton_61.Click += this.toolStripButton_61_Click;
			this.toolStripButton_65.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_65.Image = Resources.smethod_26();
			this.toolStripButton_65.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_65.Name = "tsbEditMove";
			this.toolStripButton_65.Size = new Size(23, 22);
			this.toolStripButton_65.Text = "Редактировать перемещение";
			this.toolStripButton_65.Click += this.toolStripButton_65_Click;
			this.toolStripSeparator_41.Name = "tssDeleteMove";
			this.toolStripSeparator_41.Size = new Size(6, 25);
			this.toolStripButton_62.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_62.Image = Resources.smethod_25();
			this.toolStripButton_62.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_62.Name = "tsbDeleteMove";
			this.toolStripButton_62.Size = new Size(23, 22);
			this.toolStripButton_62.Text = "Удалить перемещение";
			this.toolStripButton_62.Click += this.toolStripButton_62_Click;
			this.toolStripSeparator_42.Name = "tssRefreshMove";
			this.toolStripSeparator_42.Size = new Size(6, 25);
			this.toolStripButton_63.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_63.Image = Resources.smethod_45();
			this.toolStripButton_63.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_63.Name = "tsbRefreshMove";
			this.toolStripButton_63.Size = new Size(23, 22);
			this.toolStripButton_63.Text = "Обновить";
			this.toolStripButton_63.Click += this.toolStripButton_63_Click;
			this.toolStripSeparator_43.Name = "tssLoadOld";
			this.toolStripSeparator_43.Size = new Size(6, 25);
			this.toolStripButton_64.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripButton_64.Image = (Image)componentResourceManager.GetObject("tsbLoadOld.Image");
			this.toolStripButton_64.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_64.Name = "tsbLoadOld";
			this.toolStripButton_64.Size = new Size(151, 22);
			this.toolStripButton_64.Text = "Загрузить из старой базы";
			this.toolStripButton_64.Visible = false;
			this.toolStripButton_64.Click += this.toolStripButton_64_Click;
			this.dataGridView_8.AllowUserToAddRows = false;
			this.dataGridView_8.AllowUserToDeleteRows = false;
			this.dataGridView_8.AllowUserToOrderColumns = true;
			this.dataGridView_8.AllowUserToResizeRows = false;
			this.dataGridView_8.BackgroundColor = Color.White;
			dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle19.BackColor = SystemColors.Control;
			dataGridViewCellStyle19.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
			this.dataGridView_8.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
			this.dataGridView_8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_8.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_23,
				this.dataGridViewTextBoxColumn_24,
				this.dataGridViewTextBoxColumn_25,
				this.dataGridViewTextBoxColumn_26,
				this.dataGridViewTextBoxColumn_27,
				this.dataGridViewTextBoxColumn_28,
				this.dataGridViewTextBoxColumn_29
			});
			dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = SystemColors.Window;
			dataGridViewCellStyle20.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle20.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle20.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle20.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
			this.dataGridView_8.DefaultCellStyle = dataGridViewCellStyle20;
			this.dataGridView_8.Dock = DockStyle.Fill;
			this.dataGridView_8.Location = new Point(3, 28);
			this.dataGridView_8.MultiSelect = false;
			this.dataGridView_8.Name = "dgvMoveTrans";
			this.dataGridView_8.ReadOnly = true;
			dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle21.BackColor = SystemColors.Control;
			dataGridViewCellStyle21.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle21.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
			this.dataGridView_8.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
			this.dataGridView_8.RowHeadersVisible = false;
			this.dataGridView_8.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_8.Size = new Size(477, 88);
			this.dataGridView_8.TabIndex = 3;
			this.dataGridView_8.CellDoubleClick += this.dataGridView_8_CellDoubleClick;
			this.dataGridViewTextBoxColumn_23.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_23.HeaderText = "idMove";
			this.dataGridViewTextBoxColumn_23.Name = "idMove";
			this.dataGridViewTextBoxColumn_23.ReadOnly = true;
			this.dataGridViewTextBoxColumn_23.Visible = false;
			this.dataGridViewTextBoxColumn_24.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_24.HeaderText = "idObjList";
			this.dataGridViewTextBoxColumn_24.Name = "idObjList";
			this.dataGridViewTextBoxColumn_24.ReadOnly = true;
			this.dataGridViewTextBoxColumn_24.Visible = false;
			this.dataGridViewTextBoxColumn_25.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_25.HeaderText = "Deleted";
			this.dataGridViewTextBoxColumn_25.Name = "Deleted";
			this.dataGridViewTextBoxColumn_25.ReadOnly = true;
			this.dataGridViewTextBoxColumn_25.Visible = false;
			this.dataGridViewTextBoxColumn_26.DataPropertyName = "Data";
			this.dataGridViewTextBoxColumn_26.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_26.Name = "DateMove";
			this.dataGridViewTextBoxColumn_26.ReadOnly = true;
			this.dataGridViewTextBoxColumn_27.DataPropertyName = "Action";
			this.dataGridViewTextBoxColumn_27.HeaderText = "Действие";
			this.dataGridViewTextBoxColumn_27.Name = "Action";
			this.dataGridViewTextBoxColumn_27.ReadOnly = true;
			this.dataGridViewTextBoxColumn_27.Width = 110;
			this.dataGridViewTextBoxColumn_28.DataPropertyName = "Direction";
			this.dataGridViewTextBoxColumn_28.HeaderText = "Направление";
			this.dataGridViewTextBoxColumn_28.Name = "Direction";
			this.dataGridViewTextBoxColumn_28.ReadOnly = true;
			this.dataGridViewTextBoxColumn_28.Width = 120;
			this.dataGridViewTextBoxColumn_29.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_29.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_29.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_29.Name = "Comment";
			this.dataGridViewTextBoxColumn_29.ReadOnly = true;
			this.tabPage_13.Controls.Add(this.toolStrip_17);
			this.tabPage_13.Controls.Add(this.tableLayoutPanel_14);
			this.tabPage_13.Location = new Point(4, 22);
			this.tabPage_13.Name = "tpPerambulation";
			this.tabPage_13.Padding = new Padding(3);
			this.tabPage_13.Size = new Size(489, 125);
			this.tabPage_13.TabIndex = 11;
			this.tabPage_13.Text = "Обход трассы";
			this.tabPage_13.UseVisualStyleBackColor = true;
			this.toolStrip_17.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_71,
				this.toolStripButton_72,
				this.toolStripSeparator_47,
				this.toolStripButton_73,
				this.toolStripSeparator_48,
				this.toolStripButton_74
			});
			this.toolStrip_17.Location = new Point(3, 3);
			this.toolStrip_17.Name = "tsPerambulation";
			this.toolStrip_17.Size = new Size(483, 25);
			this.toolStrip_17.TabIndex = 1;
			this.toolStrip_17.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_71.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_71.Image = Resources.smethod_24();
			this.toolStripButton_71.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_71.Name = "tsbAddPeram";
			this.toolStripButton_71.Size = new Size(23, 22);
			this.toolStripButton_71.Text = "Добавить";
			this.toolStripButton_71.Click += this.toolStripButton_71_Click;
			this.toolStripButton_72.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_72.Image = Resources.smethod_26();
			this.toolStripButton_72.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_72.Name = "tsbEditPeram";
			this.toolStripButton_72.Size = new Size(23, 22);
			this.toolStripButton_72.Text = "Редактировать";
			this.toolStripButton_72.Click += this.toolStripButton_72_Click;
			this.toolStripSeparator_47.Name = "tssDeletePeram";
			this.toolStripSeparator_47.Size = new Size(6, 25);
			this.toolStripButton_73.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_73.Image = Resources.smethod_25();
			this.toolStripButton_73.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_73.Name = "tsbDeletePeram";
			this.toolStripButton_73.Size = new Size(23, 22);
			this.toolStripButton_73.Text = "Удалить";
			this.toolStripButton_73.Click += this.toolStripButton_73_Click;
			this.toolStripSeparator_48.Name = "tssRefreshPeram";
			this.toolStripSeparator_48.Size = new Size(6, 25);
			this.toolStripButton_74.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_74.Image = Resources.smethod_45();
			this.toolStripButton_74.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_74.Name = "tsbRefreshPeram";
			this.toolStripButton_74.Size = new Size(23, 22);
			this.toolStripButton_74.Text = "Обновить";
			this.toolStripButton_74.Click += this.toolStripButton_74_Click;
			this.tableLayoutPanel_14.ColumnCount = 1;
			this.tableLayoutPanel_14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_14.Controls.Add(this.dataGridViewExcelFilter_1, 0, 1);
			this.tableLayoutPanel_14.Dock = DockStyle.Fill;
			this.tableLayoutPanel_14.Location = new Point(3, 3);
			this.tableLayoutPanel_14.Name = "tlpPerambulation";
			this.tableLayoutPanel_14.RowCount = 2;
			this.tableLayoutPanel_14.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
			this.tableLayoutPanel_14.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_14.Size = new Size(483, 119);
			this.tableLayoutPanel_14.TabIndex = 0;
			this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_1.BackgroundColor = Color.White;
			dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle22.BackColor = SystemColors.Control;
			dataGridViewCellStyle22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle22.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
			this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_2,
				this.dataGridViewTextBoxColumn_48,
				this.dataGridViewTextBoxColumn_49,
				this.dataGridViewTextBoxColumn_50,
				this.dataGridViewTextBoxColumn_51,
				this.dataGridViewTextBoxColumn_52,
				this.dataGridViewTextBoxColumn_53
			});
			this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_5;
			dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle23.BackColor = SystemColors.Window;
			dataGridViewCellStyle23.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle23.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle23.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle23.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_1.DefaultCellStyle = dataGridViewCellStyle23;
			this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_1.Location = new Point(3, 25);
			this.dataGridViewExcelFilter_1.MultiSelect = false;
			this.dataGridViewExcelFilter_1.Name = "dgvPerambulation";
			this.dataGridViewExcelFilter_1.ReadOnly = true;
			this.dataGridViewExcelFilter_1.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_1.Size = new Size(477, 91);
			this.dataGridViewExcelFilter_1.TabIndex = 0;
			this.dataGridViewExcelFilter_1.CellDoubleClick += this.dataGridViewExcelFilter_1_CellDoubleClick;
			this.dataGridViewCheckBoxColumn_2.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_2.HeaderText = "DeletedPeram";
			this.dataGridViewCheckBoxColumn_2.Name = "deletedPeram";
			this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_48.DataPropertyName = "id";
			dataGridViewCellStyle24.Format = "D";
			dataGridViewCellStyle24.NullValue = null;
			this.dataGridViewTextBoxColumn_48.DefaultCellStyle = dataGridViewCellStyle24;
			this.dataGridViewTextBoxColumn_48.HeaderText = "idPeram";
			this.dataGridViewTextBoxColumn_48.Name = "idPeram";
			this.dataGridViewTextBoxColumn_48.ReadOnly = true;
			this.dataGridViewTextBoxColumn_48.Visible = false;
			this.dataGridViewTextBoxColumn_49.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_49.HeaderText = "idObjListPeram";
			this.dataGridViewTextBoxColumn_49.Name = "idObjListPeram";
			this.dataGridViewTextBoxColumn_49.ReadOnly = true;
			this.dataGridViewTextBoxColumn_49.Visible = false;
			this.dataGridViewTextBoxColumn_50.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn_50.HeaderText = "Дата обхода";
			this.dataGridViewTextBoxColumn_50.Name = "datePeram";
			this.dataGridViewTextBoxColumn_50.ReadOnly = true;
			this.dataGridViewTextBoxColumn_51.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_51.DataPropertyName = "Defect";
			this.dataGridViewTextBoxColumn_51.HeaderText = "Обнаружение неисправности";
			this.dataGridViewTextBoxColumn_51.Name = "defectPeram";
			this.dataGridViewTextBoxColumn_51.ReadOnly = true;
			this.dataGridViewTextBoxColumn_52.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_52.DataPropertyName = "Repair";
			this.dataGridViewTextBoxColumn_52.HeaderText = "Меры, принятые по устранению неисправности";
			this.dataGridViewTextBoxColumn_52.Name = "repairPeram";
			this.dataGridViewTextBoxColumn_52.ReadOnly = true;
			this.dataGridViewTextBoxColumn_53.DataPropertyName = "DateIn";
			this.dataGridViewTextBoxColumn_53.HeaderText = "DateInPeram";
			this.dataGridViewTextBoxColumn_53.Name = "dateInPeram";
			this.dataGridViewTextBoxColumn_53.ReadOnly = true;
			this.dataGridViewTextBoxColumn_53.Visible = false;
			this.bindingSource_5.DataMember = "tP_CabPerambulation";
			this.bindingSource_5.DataSource = this.class107_0;
			this.tabPage_15.Controls.Add(this.toolStrip_21);
			this.tabPage_15.Controls.Add(this.tableLayoutPanel_16);
			this.tabPage_15.Location = new Point(4, 22);
			this.tabPage_15.Name = "tpTehConnect";
			this.tabPage_15.Padding = new Padding(3);
			this.tabPage_15.Size = new Size(489, 125);
			this.tabPage_15.TabIndex = 12;
			this.tabPage_15.Text = "Тех. присоединение";
			this.tabPage_15.UseVisualStyleBackColor = true;
			this.toolStrip_21.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_89,
				this.toolStripButton_90,
				this.toolStripSeparator_66,
				this.toolStripButton_91,
				this.toolStripSeparator_67,
				this.toolStripButton_92
			});
			this.toolStrip_21.Location = new Point(3, 3);
			this.toolStrip_21.Name = "tsTehConnect";
			this.toolStrip_21.Size = new Size(483, 25);
			this.toolStrip_21.TabIndex = 1;
			this.toolStrip_21.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_89.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_89.Image = Resources.smethod_24();
			this.toolStripButton_89.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_89.Name = "tsbTehConnectAdd";
			this.toolStripButton_89.Size = new Size(23, 22);
			this.toolStripButton_89.Text = "Добавить";
			this.toolStripButton_89.Click += this.toolStripButton_89_Click;
			this.toolStripButton_90.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_90.Image = Resources.smethod_26();
			this.toolStripButton_90.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_90.Name = "tsbTehConnectEdit";
			this.toolStripButton_90.Size = new Size(23, 22);
			this.toolStripButton_90.Text = "Редактировать";
			this.toolStripButton_90.Click += this.toolStripButton_90_Click;
			this.toolStripSeparator_66.Name = "toolStripSeparator22";
			this.toolStripSeparator_66.Size = new Size(6, 25);
			this.toolStripButton_91.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_91.Image = Resources.smethod_25();
			this.toolStripButton_91.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_91.Name = "tsbTehConnectDelete";
			this.toolStripButton_91.Size = new Size(23, 22);
			this.toolStripButton_91.Text = "Удалить";
			this.toolStripButton_91.Click += this.toolStripButton_91_Click;
			this.toolStripSeparator_67.Name = "toolStripSeparator23";
			this.toolStripSeparator_67.Size = new Size(6, 25);
			this.toolStripButton_92.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_92.Image = Resources.smethod_45();
			this.toolStripButton_92.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_92.Name = "tsbTehConnectRefresh";
			this.toolStripButton_92.Size = new Size(23, 22);
			this.toolStripButton_92.Text = "Обновить";
			this.toolStripButton_92.Click += this.wudpxmqjwe;
			this.tableLayoutPanel_16.ColumnCount = 1;
			this.tableLayoutPanel_16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_16.Controls.Add(this.dataGridViewExcelFilter_3, 0, 1);
			this.tableLayoutPanel_16.Dock = DockStyle.Fill;
			this.tableLayoutPanel_16.Location = new Point(3, 3);
			this.tableLayoutPanel_16.Name = "tlpTehConnect";
			this.tableLayoutPanel_16.RowCount = 2;
			this.tableLayoutPanel_16.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
			this.tableLayoutPanel_16.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_16.Size = new Size(483, 119);
			this.tableLayoutPanel_16.TabIndex = 0;
			this.dataGridViewExcelFilter_3.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_3.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_3.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_3.BackgroundColor = Color.White;
			dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle25.BackColor = SystemColors.Control;
			dataGridViewCellStyle25.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle25.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle25.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle25.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
			this.dataGridViewExcelFilter_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_3.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_3,
				this.dataGridViewTextBoxColumn_54,
				this.dataGridViewTextBoxColumn_55,
				this.dataGridViewTextBoxColumn_56,
				this.dataGridViewTextBoxColumn_57,
				this.dataGridViewTextBoxColumn_58,
				this.dataGridViewTextBoxColumn_59,
				this.dataGridViewTextBoxColumn_60,
				this.dataGridViewTextBoxColumn_61,
				this.dataGridViewTextBoxColumn_62,
				this.dataGridViewTextBoxColumn_63
			});
			this.dataGridViewExcelFilter_3.DataSource = this.bindingSource_8;
			dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle26.BackColor = SystemColors.Window;
			dataGridViewCellStyle26.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle26.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle26.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle26.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle26.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_3.DefaultCellStyle = dataGridViewCellStyle26;
			this.dataGridViewExcelFilter_3.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_3.Location = new Point(3, 25);
			this.dataGridViewExcelFilter_3.MultiSelect = false;
			this.dataGridViewExcelFilter_3.Name = "dgvTehConnect";
			this.dataGridViewExcelFilter_3.ReadOnly = true;
			this.dataGridViewExcelFilter_3.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_3.Size = new Size(477, 91);
			this.dataGridViewExcelFilter_3.TabIndex = 0;
			this.dataGridViewExcelFilter_3.CellContentClick += this.dataGridViewExcelFilter_3_CellDoubleClick;
			this.dataGridViewExcelFilter_3.CellDoubleClick += this.dataGridViewExcelFilter_3_CellDoubleClick;
			this.dataGridViewCheckBoxColumn_3.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_3.HeaderText = "Deleted";
			this.dataGridViewCheckBoxColumn_3.Name = "deletedDataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn_3.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_3.Visible = false;
			this.dataGridViewTextBoxColumn_54.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_54.HeaderText = "id";
			this.dataGridViewTextBoxColumn_54.Name = "idDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_54.ReadOnly = true;
			this.dataGridViewTextBoxColumn_54.Visible = false;
			this.dataGridViewTextBoxColumn_55.DataPropertyName = "idSubstation";
			this.dataGridViewTextBoxColumn_55.HeaderText = "idSubstation";
			this.dataGridViewTextBoxColumn_55.Name = "idSubstationDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_55.ReadOnly = true;
			this.dataGridViewTextBoxColumn_55.Visible = false;
			this.dataGridViewTextBoxColumn_56.DataPropertyName = "NameSubstation";
			this.dataGridViewTextBoxColumn_56.HeaderText = "Подстанция";
			this.dataGridViewTextBoxColumn_56.Name = "nameSubstationDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_56.ReadOnly = true;
			this.dataGridViewTextBoxColumn_57.DataPropertyName = "idTransf";
			this.dataGridViewTextBoxColumn_57.HeaderText = "idTransf";
			this.dataGridViewTextBoxColumn_57.Name = "idTransfDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_57.ReadOnly = true;
			this.dataGridViewTextBoxColumn_57.Visible = false;
			this.dataGridViewTextBoxColumn_58.DataPropertyName = "NameTransf";
			this.dataGridViewTextBoxColumn_58.HeaderText = "Трансформатор";
			this.dataGridViewTextBoxColumn_58.Name = "nameTransfDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_58.ReadOnly = true;
			this.dataGridViewTextBoxColumn_59.DataPropertyName = "Dogovor";
			this.dataGridViewTextBoxColumn_59.HeaderText = "Номер договора";
			this.dataGridViewTextBoxColumn_59.Name = "dogovorDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_59.ReadOnly = true;
			this.dataGridViewTextBoxColumn_60.DataPropertyName = "dateBegin";
			this.dataGridViewTextBoxColumn_60.HeaderText = "Дата закл. договора";
			this.dataGridViewTextBoxColumn_60.Name = "dateBeginDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_60.ReadOnly = true;
			this.dataGridViewTextBoxColumn_61.DataPropertyName = "dateEnd";
			this.dataGridViewTextBoxColumn_61.HeaderText = "Дата окон. договора";
			this.dataGridViewTextBoxColumn_61.Name = "dateEndDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_61.ReadOnly = true;
			this.dataGridViewTextBoxColumn_62.DataPropertyName = "Company";
			this.dataGridViewTextBoxColumn_62.HeaderText = "Наименование потребителя";
			this.dataGridViewTextBoxColumn_62.Name = "companyDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_62.ReadOnly = true;
			this.dataGridViewTextBoxColumn_63.DataPropertyName = "MaxPower";
			this.dataGridViewTextBoxColumn_63.HeaderText = "Максимальная мощность, кВА";
			this.dataGridViewTextBoxColumn_63.Name = "maxPowerDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_63.ReadOnly = true;
			this.dataGridViewTextBoxColumn_63.Width = 110;
			this.bindingSource_8.DataMember = "vP_TehConnect";
			this.bindingSource_8.DataSource = this.class107_0;
			this.tabPage_18.Controls.Add(this.dataGridViewExcelFilter_4);
			this.tabPage_18.Controls.Add(this.toolStrip_23);
			this.tabPage_18.Location = new Point(4, 22);
			this.tabPage_18.Name = "tpPlanRenovations";
			this.tabPage_18.Padding = new Padding(3);
			this.tabPage_18.Size = new Size(489, 125);
			this.tabPage_18.TabIndex = 13;
			this.tabPage_18.Text = "План ремонтных работ";
			this.tabPage_18.UseVisualStyleBackColor = true;
			this.dataGridViewExcelFilter_4.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_4.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_4.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_4.BackgroundColor = Color.White;
			dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle27.BackColor = SystemColors.Control;
			dataGridViewCellStyle27.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle27.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle27.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle27.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle27.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
			this.dataGridViewExcelFilter_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_4.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_4,
				this.dataGridViewCheckBoxColumn_5,
				this.dataGridViewTextBoxColumn_95,
				this.dataGridViewTextBoxColumn_96,
				this.dataGridViewTextBoxColumn_97,
				this.dataGridViewTextBoxColumn_98,
				this.dataGridViewTextBoxColumn_99,
				this.dataGridViewTextBoxColumn_100
			});
			this.dataGridViewExcelFilter_4.DataSource = this.bindingSource_9;
			dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle28.BackColor = SystemColors.Window;
			dataGridViewCellStyle28.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle28.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle28.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle28.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle28.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_4.DefaultCellStyle = dataGridViewCellStyle28;
			this.dataGridViewExcelFilter_4.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_4.Location = new Point(3, 28);
			this.dataGridViewExcelFilter_4.MultiSelect = false;
			this.dataGridViewExcelFilter_4.Name = "dgvPlanBalance";
			this.dataGridViewExcelFilter_4.ReadOnly = true;
			this.dataGridViewExcelFilter_4.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_4.Size = new Size(483, 94);
			this.dataGridViewExcelFilter_4.TabIndex = 3;
			this.dataGridViewExcelFilter_4.CellDoubleClick += this.romYqlDtZh;
			this.dataGridViewCheckBoxColumn_4.DataPropertyName = "isActive";
			this.dataGridViewCheckBoxColumn_4.HeaderText = "isActive";
			this.dataGridViewCheckBoxColumn_4.Name = "isActiveDataGridViewCheckBoxColumn";
			this.dataGridViewCheckBoxColumn_4.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_4.Visible = false;
			this.dataGridViewCheckBoxColumn_5.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_5.HeaderText = "Deleted";
			this.dataGridViewCheckBoxColumn_5.Name = "deletedDataGridViewCheckBoxColumn2";
			this.dataGridViewCheckBoxColumn_5.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_95.DataPropertyName = "NumberDoc";
			this.dataGridViewTextBoxColumn_95.HeaderText = "№ документа";
			this.dataGridViewTextBoxColumn_95.Name = "numberDocDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_95.ReadOnly = true;
			this.dataGridViewTextBoxColumn_95.Width = 150;
			this.dataGridViewTextBoxColumn_96.DataPropertyName = "DateDoc";
			this.dataGridViewTextBoxColumn_96.HeaderText = "Дата документа";
			this.dataGridViewTextBoxColumn_96.Name = "dateDocDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_96.ReadOnly = true;
			this.dataGridViewTextBoxColumn_96.Width = 150;
			this.dataGridViewTextBoxColumn_97.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_97.HeaderText = "id";
			this.dataGridViewTextBoxColumn_97.Name = "idDataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_97.ReadOnly = true;
			this.dataGridViewTextBoxColumn_97.Visible = false;
			this.dataGridViewTextBoxColumn_98.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_98.HeaderText = "ParentId";
			this.dataGridViewTextBoxColumn_98.Name = "parentIdDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_98.ReadOnly = true;
			this.dataGridViewTextBoxColumn_98.Visible = false;
			this.dataGridViewTextBoxColumn_99.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_99.HeaderText = "idObjList";
			this.dataGridViewTextBoxColumn_99.Name = "idObjListDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_99.ReadOnly = true;
			this.dataGridViewTextBoxColumn_99.Visible = false;
			this.dataGridViewTextBoxColumn_100.DataPropertyName = "TypeDoc";
			this.dataGridViewTextBoxColumn_100.HeaderText = "TypeDoc";
			this.dataGridViewTextBoxColumn_100.Name = "typeDocDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_100.ReadOnly = true;
			this.dataGridViewTextBoxColumn_100.Visible = false;
			this.bindingSource_9.DataMember = "tP_DocList";
			this.bindingSource_9.DataSource = this.class14_0;
			this.class14_0.DataSetName = "dsDocuments";
			this.class14_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.toolStrip_23.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_99,
				this.toolStripButton_100,
				this.toolStripSeparator_71,
				this.toolStripButton_101,
				this.toolStripSeparator_72,
				this.pRdPcudXaZ
			});
			this.toolStrip_23.Location = new Point(3, 3);
			this.toolStrip_23.Name = "toolStripPlanRenovations";
			this.toolStrip_23.Size = new Size(483, 25);
			this.toolStrip_23.TabIndex = 2;
			this.toolStrip_23.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_99.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_99.Image = Resources.smethod_24();
			this.toolStripButton_99.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_99.Name = "toolBtnAddPlanRenovation";
			this.toolStripButton_99.Size = new Size(23, 22);
			this.toolStripButton_99.Text = "Добавить";
			this.toolStripButton_99.Click += this.toolStripButton_99_Click;
			this.toolStripButton_100.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_100.Image = Resources.smethod_26();
			this.toolStripButton_100.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_100.Name = "toolBtnEditPlanRenovation";
			this.toolStripButton_100.Size = new Size(23, 22);
			this.toolStripButton_100.Text = "Редактировать";
			this.toolStripButton_100.Click += this.toolStripButton_100_Click;
			this.toolStripSeparator_71.Name = "toolStripSeparator27";
			this.toolStripSeparator_71.Size = new Size(6, 25);
			this.toolStripButton_101.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_101.Image = Resources.smethod_25();
			this.toolStripButton_101.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_101.Name = "toolBtnDelPlanRenovation";
			this.toolStripButton_101.Size = new Size(23, 22);
			this.toolStripButton_101.Text = "Удалить";
			this.toolStripButton_101.Click += this.toolStripButton_101_Click;
			this.toolStripSeparator_72.Name = "toolStripSeparator28";
			this.toolStripSeparator_72.Size = new Size(6, 25);
			this.pRdPcudXaZ.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.pRdPcudXaZ.Image = Resources.smethod_45();
			this.pRdPcudXaZ.ImageTransparentColor = Color.Magenta;
			this.pRdPcudXaZ.Name = "toolBtnRefreshPlanRenovation";
			this.pRdPcudXaZ.Size = new Size(23, 22);
			this.pRdPcudXaZ.Text = "Обновить";
			this.pRdPcudXaZ.Click += this.pRdPcudXaZ_Click;
			this.tabPage_19.Controls.Add(this.dataGridViewExcelFilter_5);
			this.tabPage_19.Controls.Add(this.toolStrip_24);
			this.tabPage_19.Location = new Point(4, 22);
			this.tabPage_19.Name = "tpInspectSubstation";
			this.tabPage_19.Padding = new Padding(3);
			this.tabPage_19.Size = new Size(489, 125);
			this.tabPage_19.TabIndex = 14;
			this.tabPage_19.Text = "Осмотр подстанции";
			this.tabPage_19.UseVisualStyleBackColor = true;
			this.dataGridViewExcelFilter_5.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_5.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_5.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_5.BackgroundColor = Color.White;
			dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle29.BackColor = SystemColors.Control;
			dataGridViewCellStyle29.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle29.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle29.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
			this.dataGridViewExcelFilter_5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_5.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_12,
				this.dataGridViewCheckBoxColumn_13,
				this.dataGridViewTextBoxColumn_217,
				this.dataGridViewTextBoxColumn_218,
				this.dataGridViewTextBoxColumn_219,
				this.dataGridViewTextBoxColumn_220,
				this.dataGridViewTextBoxColumn_221,
				this.dataGridViewTextBoxColumn_222,
				this.lrkgwoojrG
			});
			this.dataGridViewExcelFilter_5.DataSource = this.bindingSource_10;
			dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle30.BackColor = SystemColors.Window;
			dataGridViewCellStyle30.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle30.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle30.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle30.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle30.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_5.DefaultCellStyle = dataGridViewCellStyle30;
			this.dataGridViewExcelFilter_5.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_5.Location = new Point(3, 28);
			this.dataGridViewExcelFilter_5.MultiSelect = false;
			this.dataGridViewExcelFilter_5.Name = "dgvDocInspectSubstation";
			this.dataGridViewExcelFilter_5.ReadOnly = true;
			this.dataGridViewExcelFilter_5.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_5.Size = new Size(483, 94);
			this.dataGridViewExcelFilter_5.TabIndex = 4;
			this.dataGridViewExcelFilter_5.CellDoubleClick += this.dataGridViewExcelFilter_5_CellDoubleClick;
			this.dataGridViewCheckBoxColumn_12.DataPropertyName = "isActive";
			this.dataGridViewCheckBoxColumn_12.HeaderText = "isActive";
			this.dataGridViewCheckBoxColumn_12.Name = "dataGridViewCheckBoxColumn163";
			this.dataGridViewCheckBoxColumn_12.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_12.Visible = false;
			this.dataGridViewCheckBoxColumn_13.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_13.HeaderText = "Deleted";
			this.dataGridViewCheckBoxColumn_13.Name = "dataGridViewCheckBoxColumn164";
			this.dataGridViewCheckBoxColumn_13.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_13.Visible = false;
			this.dataGridViewTextBoxColumn_217.DataPropertyName = "NumberDoc";
			this.dataGridViewTextBoxColumn_217.HeaderText = "№ документа";
			this.dataGridViewTextBoxColumn_217.Name = "dataGridViewTextBoxColumn814";
			this.dataGridViewTextBoxColumn_217.ReadOnly = true;
			this.dataGridViewTextBoxColumn_217.Width = 150;
			this.dataGridViewTextBoxColumn_218.DataPropertyName = "DateDoc";
			this.dataGridViewTextBoxColumn_218.HeaderText = "Дата документа";
			this.dataGridViewTextBoxColumn_218.Name = "dataGridViewTextBoxColumn815";
			this.dataGridViewTextBoxColumn_218.ReadOnly = true;
			this.dataGridViewTextBoxColumn_218.Width = 150;
			this.dataGridViewTextBoxColumn_219.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_219.HeaderText = "id";
			this.dataGridViewTextBoxColumn_219.Name = "dataGridViewTextBoxColumn816";
			this.dataGridViewTextBoxColumn_219.ReadOnly = true;
			this.dataGridViewTextBoxColumn_219.Visible = false;
			this.dataGridViewTextBoxColumn_220.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_220.HeaderText = "ParentId";
			this.dataGridViewTextBoxColumn_220.Name = "dataGridViewTextBoxColumn817";
			this.dataGridViewTextBoxColumn_220.ReadOnly = true;
			this.dataGridViewTextBoxColumn_220.Visible = false;
			this.dataGridViewTextBoxColumn_221.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_221.HeaderText = "idObjList";
			this.dataGridViewTextBoxColumn_221.Name = "dataGridViewTextBoxColumn818";
			this.dataGridViewTextBoxColumn_221.ReadOnly = true;
			this.dataGridViewTextBoxColumn_221.Visible = false;
			this.dataGridViewTextBoxColumn_222.DataPropertyName = "TypeDoc";
			this.dataGridViewTextBoxColumn_222.HeaderText = "TypeDoc";
			this.dataGridViewTextBoxColumn_222.Name = "dataGridViewTextBoxColumn819";
			this.dataGridViewTextBoxColumn_222.ReadOnly = true;
			this.dataGridViewTextBoxColumn_222.Visible = false;
			this.lrkgwoojrG.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.lrkgwoojrG.DataPropertyName = "Comment";
			this.lrkgwoojrG.HeaderText = "Комментарий";
			this.lrkgwoojrG.Name = "CommentDgvInspectColumn";
			this.lrkgwoojrG.ReadOnly = true;
			this.bindingSource_10.DataMember = "tP_DocList";
			this.bindingSource_10.DataSource = this.class14_1;
			this.class14_1.DataSetName = "dsDocuments";
			this.class14_1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.toolStrip_24.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_102,
				this.toolStripButton_103,
				this.toolStripSeparator_73,
				this.toolStripButton_104,
				this.toolStripSeparator_74,
				this.toolStripButton_105
			});
			this.toolStrip_24.Location = new Point(3, 3);
			this.toolStrip_24.Name = "toolStripInspectSubstation";
			this.toolStrip_24.Size = new Size(483, 25);
			this.toolStrip_24.TabIndex = 3;
			this.toolStrip_24.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_102.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_102.Image = Resources.smethod_24();
			this.toolStripButton_102.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_102.Name = "toolBtnAddInpectSubstation";
			this.toolStripButton_102.Size = new Size(23, 22);
			this.toolStripButton_102.Text = "Добавить";
			this.toolStripButton_102.Click += this.toolStripButton_102_Click;
			this.toolStripButton_103.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_103.Image = Resources.smethod_26();
			this.toolStripButton_103.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_103.Name = "toolBtnEditInspectSubstation";
			this.toolStripButton_103.Size = new Size(23, 22);
			this.toolStripButton_103.Text = "Редактировать";
			this.toolStripButton_103.Click += this.toolStripButton_103_Click;
			this.toolStripSeparator_73.Name = "toolStripSeparator29";
			this.toolStripSeparator_73.Size = new Size(6, 25);
			this.toolStripButton_104.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_104.Image = Resources.smethod_25();
			this.toolStripButton_104.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_104.Name = "toolBtnDelInspectSubstation";
			this.toolStripButton_104.Size = new Size(23, 22);
			this.toolStripButton_104.Text = "Удалить";
			this.toolStripButton_104.Click += this.toolStripButton_104_Click;
			this.toolStripSeparator_74.Name = "toolStripSeparator30";
			this.toolStripSeparator_74.Size = new Size(6, 25);
			this.toolStripButton_105.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_105.Image = Resources.smethod_45();
			this.toolStripButton_105.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_105.Name = "toolBtnRefreshInspectSubstation";
			this.toolStripButton_105.Size = new Size(23, 22);
			this.toolStripButton_105.Text = "Обновить";
			this.toolStripButton_105.Click += this.toolStripButton_105_Click;
			this.tabPage_21.Controls.Add(this.dataGridView_10);
			this.tabPage_21.Controls.Add(this.toolStrip_27);
			this.tabPage_21.Location = new Point(4, 22);
			this.tabPage_21.Name = "tpSubstTest";
			this.tabPage_21.Padding = new Padding(3);
			this.tabPage_21.Size = new Size(489, 125);
			this.tabPage_21.TabIndex = 15;
			this.tabPage_21.Text = "Испытание подстанции";
			this.tabPage_21.UseVisualStyleBackColor = true;
			this.dataGridView_10.AllowUserToAddRows = false;
			this.dataGridView_10.AllowUserToDeleteRows = false;
			this.dataGridView_10.AllowUserToResizeRows = false;
			this.dataGridView_10.AutoGenerateColumns = false;
			this.dataGridView_10.BackgroundColor = Color.White;
			dataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle31.BackColor = SystemColors.Control;
			dataGridViewCellStyle31.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle31.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle31.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle31.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle31.WrapMode = DataGridViewTriState.False;
			this.dataGridView_10.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
			this.dataGridView_10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_10.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_6,
				this.dataGridViewCheckBoxColumn_7,
				this.dataGridViewTextBoxColumn_101,
				this.dataGridViewTextBoxColumn_102,
				this.dataGridViewTextBoxColumn_103,
				this.dataGridViewTextBoxColumn_104,
				this.dataGridViewTextBoxColumn_105,
				this.dataGridViewTextBoxColumn_106,
				this.dataGridViewTextBoxColumn_107,
				this.dataGridViewTextBoxColumn_108
			});
			this.dataGridView_10.DataSource = this.bindingSource_11;
			dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle32.BackColor = SystemColors.Window;
			dataGridViewCellStyle32.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle32.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle32.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle32.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle32.WrapMode = DataGridViewTriState.False;
			this.dataGridView_10.DefaultCellStyle = dataGridViewCellStyle32;
			this.dataGridView_10.Dock = DockStyle.Fill;
			this.dataGridView_10.Location = new Point(3, 28);
			this.dataGridView_10.Name = "dgvSubstTest";
			this.dataGridView_10.ReadOnly = true;
			this.dataGridView_10.RowHeadersVisible = false;
			this.dataGridView_10.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_10.Size = new Size(483, 94);
			this.dataGridView_10.TabIndex = 1;
			this.dataGridView_10.CellDoubleClick += this.dataGridView_10_CellDoubleClick;
			this.dataGridViewCheckBoxColumn_6.DataPropertyName = "isActive";
			this.dataGridViewCheckBoxColumn_6.HeaderText = "isActive";
			this.dataGridViewCheckBoxColumn_6.Name = "isActiveDgvSubstTest";
			this.dataGridViewCheckBoxColumn_6.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_6.Visible = false;
			this.dataGridViewCheckBoxColumn_7.DataPropertyName = "Deleted";
			this.dataGridViewCheckBoxColumn_7.HeaderText = "Deleted";
			this.dataGridViewCheckBoxColumn_7.Name = "deletedDgvSubstTest";
			this.dataGridViewCheckBoxColumn_7.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_101.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_101.HeaderText = "id";
			this.dataGridViewTextBoxColumn_101.Name = "idDgvSubstTest";
			this.dataGridViewTextBoxColumn_101.ReadOnly = true;
			this.dataGridViewTextBoxColumn_101.Visible = false;
			this.dataGridViewTextBoxColumn_102.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_102.HeaderText = "ParentId";
			this.dataGridViewTextBoxColumn_102.Name = "parentIdDgvSubstTest";
			this.dataGridViewTextBoxColumn_102.ReadOnly = true;
			this.dataGridViewTextBoxColumn_102.Visible = false;
			this.dataGridViewTextBoxColumn_103.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_103.HeaderText = "idObjList";
			this.dataGridViewTextBoxColumn_103.Name = "idObjListDgvSubstTest";
			this.dataGridViewTextBoxColumn_103.ReadOnly = true;
			this.dataGridViewTextBoxColumn_103.Visible = false;
			this.dataGridViewTextBoxColumn_104.DataPropertyName = "NumberDoc";
			this.dataGridViewTextBoxColumn_104.HeaderText = "№ документа";
			this.dataGridViewTextBoxColumn_104.MinimumWidth = 30;
			this.dataGridViewTextBoxColumn_104.Name = "numberDocDgvSubstTest";
			this.dataGridViewTextBoxColumn_104.ReadOnly = true;
			this.dataGridViewTextBoxColumn_104.Width = 130;
			this.dataGridViewTextBoxColumn_105.DataPropertyName = "DateDoc";
			this.dataGridViewTextBoxColumn_105.HeaderText = "Дата документа";
			this.dataGridViewTextBoxColumn_105.MinimumWidth = 30;
			this.dataGridViewTextBoxColumn_105.Name = "dateDocDgvSubstTest";
			this.dataGridViewTextBoxColumn_105.ReadOnly = true;
			this.dataGridViewTextBoxColumn_105.Width = 120;
			this.dataGridViewTextBoxColumn_106.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_106.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_106.HeaderText = "Описание";
			this.dataGridViewTextBoxColumn_106.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_106.Name = "commentDgvSubstTest";
			this.dataGridViewTextBoxColumn_106.ReadOnly = true;
			this.dataGridViewTextBoxColumn_107.DataPropertyName = "TypeDoc";
			this.dataGridViewTextBoxColumn_107.HeaderText = "TypeDoc";
			this.dataGridViewTextBoxColumn_107.Name = "typeDocDgvSubstTest";
			this.dataGridViewTextBoxColumn_107.ReadOnly = true;
			this.dataGridViewTextBoxColumn_107.Visible = false;
			this.dataGridViewTextBoxColumn_108.DataPropertyName = "DataXml";
			this.dataGridViewTextBoxColumn_108.HeaderText = "DataXml";
			this.dataGridViewTextBoxColumn_108.Name = "dataXmlDgvSubstTest";
			this.dataGridViewTextBoxColumn_108.ReadOnly = true;
			this.dataGridViewTextBoxColumn_108.Visible = false;
			this.bindingSource_11.DataMember = "tP_DocList";
			this.bindingSource_11.DataSource = this.class14_2;
			this.class14_2.DataSetName = "dsDocuments";
			this.class14_2.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.toolStrip_27.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_119,
				this.toolStripButton_120,
				this.toolStripSeparator_83,
				this.toolStripButton_121,
				this.toolStripSeparator_84,
				this.toolStripButton_122
			});
			this.toolStrip_27.Location = new Point(3, 3);
			this.toolStrip_27.Name = "tsSubstTest";
			this.toolStrip_27.Size = new Size(483, 25);
			this.toolStrip_27.TabIndex = 0;
			this.toolStrip_27.Text = "Панель инструментов вкладки \"Испытания\"";
			this.toolStripButton_119.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_119.Image = Resources.smethod_24();
			this.toolStripButton_119.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_119.Name = "tsBtnAddSubstTest";
			this.toolStripButton_119.Size = new Size(23, 22);
			this.toolStripButton_119.Text = "Добавить испытание";
			this.toolStripButton_119.Click += this.toolStripButton_119_Click;
			this.toolStripButton_120.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_120.Image = Resources.smethod_26();
			this.toolStripButton_120.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_120.Name = "tsBtnEditSubstTest";
			this.toolStripButton_120.Size = new Size(23, 22);
			this.toolStripButton_120.Text = "Редактировать испытание";
			this.toolStripButton_120.Click += this.toolStripButton_120_Click;
			this.toolStripSeparator_83.Name = "toolStripSeparator36";
			this.toolStripSeparator_83.Size = new Size(6, 25);
			this.toolStripButton_121.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_121.Image = Resources.smethod_25();
			this.toolStripButton_121.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_121.Name = "tsBtnDelSubstTest";
			this.toolStripButton_121.Size = new Size(23, 22);
			this.toolStripButton_121.Text = "Удалить испытание";
			this.toolStripButton_121.Click += this.toolStripButton_121_Click;
			this.toolStripSeparator_84.Name = "toolStripSeparator37";
			this.toolStripSeparator_84.Size = new Size(6, 25);
			this.toolStripButton_122.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_122.Image = Resources.smethod_45();
			this.toolStripButton_122.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_122.Name = "tsBtnRefreshSubstTest";
			this.toolStripButton_122.Size = new Size(23, 22);
			this.toolStripButton_122.Text = "Обновить список испытаний";
			this.toolStripButton_122.Click += this.toolStripButton_122_Click;
			this.tabPage_30.Controls.Add(this.dataGridView_15);
			this.tabPage_30.Controls.Add(this.toolStrip_34);
			this.tabPage_30.Location = new Point(4, 22);
			this.tabPage_30.Name = "tpAddress";
			this.tabPage_30.Size = new Size(489, 125);
			this.tabPage_30.TabIndex = 16;
			this.tabPage_30.Text = "Адрес";
			this.tabPage_30.UseVisualStyleBackColor = true;
			this.dataGridView_15.AllowUserToAddRows = false;
			this.dataGridView_15.AllowUserToDeleteRows = false;
			this.dataGridView_15.AutoGenerateColumns = false;
			this.dataGridView_15.BackgroundColor = SystemColors.Window;
			this.dataGridView_15.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_11,
				this.dataGridViewTextBoxColumn_204,
				this.dataGridViewTextBoxColumn_205,
				this.dataGridViewTextBoxColumn_206,
				this.dataGridViewTextBoxColumn_207,
				this.dataGridViewTextBoxColumn_208,
				this.dataGridViewTextBoxColumn_209,
				this.dataGridViewTextBoxColumn_210,
				this.dataGridViewTextBoxColumn_211,
				this.dataGridViewTextBoxColumn_212,
				this.dataGridViewTextBoxColumn_213,
				this.dataGridViewTextBoxColumn_214,
				this.dataGridViewTextBoxColumn_215,
				this.dataGridViewTextBoxColumn_216
			});
			this.dataGridView_15.ContextMenuStrip = this.contextMenuStrip_14;
			this.dataGridView_15.DataSource = this.bindingSource_14;
			dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle33.BackColor = SystemColors.Window;
			dataGridViewCellStyle33.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle33.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle33.SelectionBackColor = SystemColors.HighlightText;
			dataGridViewCellStyle33.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle33.WrapMode = DataGridViewTriState.False;
			this.dataGridView_15.DefaultCellStyle = dataGridViewCellStyle33;
			this.dataGridView_15.Dock = DockStyle.Fill;
			this.dataGridView_15.Location = new Point(0, 25);
			this.dataGridView_15.Name = "dgvAddress";
			this.dataGridView_15.ReadOnly = true;
			dataGridViewCellStyle34.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle34.BackColor = SystemColors.Control;
			dataGridViewCellStyle34.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle34.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle34.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle34.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle34.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle34.WrapMode = DataGridViewTriState.True;
			this.dataGridView_15.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
			this.dataGridView_15.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridView_15.Size = new Size(489, 100);
			this.dataGridView_15.TabIndex = 1;
			this.dataGridView_15.CellDoubleClick += this.dataGridView_15_CellDoubleClick;
			this.dataGridViewCheckBoxColumn_11.DataPropertyName = "deleted";
			this.dataGridViewCheckBoxColumn_11.HeaderText = "deleted";
			this.dataGridViewCheckBoxColumn_11.Name = "deletedDgvAddress";
			this.dataGridViewCheckBoxColumn_11.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_11.Visible = false;
			this.dataGridViewTextBoxColumn_204.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_204.HeaderText = "id";
			this.dataGridViewTextBoxColumn_204.Name = "idDgvAddress";
			this.dataGridViewTextBoxColumn_204.ReadOnly = true;
			this.dataGridViewTextBoxColumn_204.Visible = false;
			this.dataGridViewTextBoxColumn_205.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_205.HeaderText = "idObjList";
			this.dataGridViewTextBoxColumn_205.Name = "idObjListDgvAddress";
			this.dataGridViewTextBoxColumn_205.ReadOnly = true;
			this.dataGridViewTextBoxColumn_205.Visible = false;
			this.dataGridViewTextBoxColumn_206.DataPropertyName = "idRegion";
			this.dataGridViewTextBoxColumn_206.HeaderText = "idRegion";
			this.dataGridViewTextBoxColumn_206.Name = "idRegionDgvAddress";
			this.dataGridViewTextBoxColumn_206.ReadOnly = true;
			this.dataGridViewTextBoxColumn_206.Visible = false;
			this.dataGridViewTextBoxColumn_207.DataPropertyName = "idLocality";
			this.dataGridViewTextBoxColumn_207.HeaderText = "idLocality";
			this.dataGridViewTextBoxColumn_207.Name = "idLocalityDgvAddress";
			this.dataGridViewTextBoxColumn_207.ReadOnly = true;
			this.dataGridViewTextBoxColumn_207.Visible = false;
			this.dataGridViewTextBoxColumn_208.DataPropertyName = "idTown";
			this.dataGridViewTextBoxColumn_208.HeaderText = "idTown";
			this.dataGridViewTextBoxColumn_208.Name = "idTownDgvAddress";
			this.dataGridViewTextBoxColumn_208.ReadOnly = true;
			this.dataGridViewTextBoxColumn_208.Visible = false;
			this.dataGridViewTextBoxColumn_209.DataPropertyName = "idStreet";
			this.dataGridViewTextBoxColumn_209.HeaderText = "idStreet";
			this.dataGridViewTextBoxColumn_209.Name = "idStreetDgvAddress";
			this.dataGridViewTextBoxColumn_209.ReadOnly = true;
			this.dataGridViewTextBoxColumn_209.Visible = false;
			this.dataGridViewTextBoxColumn_210.DataPropertyName = "RegionName";
			this.dataGridViewTextBoxColumn_210.HeaderText = "Регион";
			this.dataGridViewTextBoxColumn_210.Name = "regionNameDgvAddress";
			this.dataGridViewTextBoxColumn_210.ReadOnly = true;
			this.dataGridViewTextBoxColumn_211.DataPropertyName = "LocalityName";
			this.dataGridViewTextBoxColumn_211.HeaderText = "Район";
			this.dataGridViewTextBoxColumn_211.Name = "localityNameDgvAddress";
			this.dataGridViewTextBoxColumn_211.ReadOnly = true;
			this.dataGridViewTextBoxColumn_212.DataPropertyName = "TownName";
			this.dataGridViewTextBoxColumn_212.HeaderText = "Населенный пункт";
			this.dataGridViewTextBoxColumn_212.Name = "townNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_212.ReadOnly = true;
			this.dataGridViewTextBoxColumn_213.DataPropertyName = "StreetName";
			this.dataGridViewTextBoxColumn_213.HeaderText = "Улица";
			this.dataGridViewTextBoxColumn_213.Name = "streetNameDgvAddress";
			this.dataGridViewTextBoxColumn_213.ReadOnly = true;
			this.dataGridViewTextBoxColumn_214.DataPropertyName = "houseNumber";
			this.dataGridViewTextBoxColumn_214.HeaderText = "№ дома";
			this.dataGridViewTextBoxColumn_214.Name = "houseNumberDgvAddress";
			this.dataGridViewTextBoxColumn_214.ReadOnly = true;
			this.dataGridViewTextBoxColumn_214.Width = 60;
			this.dataGridViewTextBoxColumn_215.DataPropertyName = "comment";
			this.dataGridViewTextBoxColumn_215.HeaderText = "Примечание";
			this.dataGridViewTextBoxColumn_215.Name = "commentDgvAddress";
			this.dataGridViewTextBoxColumn_215.ReadOnly = true;
			this.dataGridViewTextBoxColumn_215.Width = 150;
			this.dataGridViewTextBoxColumn_216.DataPropertyName = "FullAddress";
			this.dataGridViewTextBoxColumn_216.HeaderText = "FullAddress";
			this.dataGridViewTextBoxColumn_216.Name = "fullAddressDgvAddress";
			this.dataGridViewTextBoxColumn_216.ReadOnly = true;
			this.dataGridViewTextBoxColumn_216.Visible = false;
			this.contextMenuStrip_14.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_65,
				this.toolStripMenuItem_66,
				this.toolStripMenuItem_67,
				this.toolStripMenuItem_68
			});
			this.contextMenuStrip_14.Name = "cmsObjAddress";
			this.contextMenuStrip_14.Size = new Size(189, 92);
			this.toolStripMenuItem_65.Image = Resources.smethod_24();
			this.toolStripMenuItem_65.Name = "tsmiAddObjAddress";
			this.toolStripMenuItem_65.Size = new Size(188, 22);
			this.toolStripMenuItem_65.Text = "Добавить адрес";
			this.toolStripMenuItem_65.Click += this.toolStripButton_157_Click;
			this.toolStripMenuItem_66.Image = Resources.smethod_26();
			this.toolStripMenuItem_66.Name = "tsmiEditAddress";
			this.toolStripMenuItem_66.Size = new Size(188, 22);
			this.toolStripMenuItem_66.Text = "Редактировать адрес";
			this.toolStripMenuItem_66.Click += this.toolStripButton_158_Click;
			this.toolStripMenuItem_67.Image = Resources.smethod_17();
			this.toolStripMenuItem_67.Name = "tsmiCopyAddress";
			this.toolStripMenuItem_67.Size = new Size(188, 22);
			this.toolStripMenuItem_67.Text = "Копировать адрес";
			this.toolStripMenuItem_67.Click += this.toolStripButton_159_Click;
			this.toolStripMenuItem_68.Image = Resources.smethod_25();
			this.toolStripMenuItem_68.Name = "tsmiDelAddress";
			this.toolStripMenuItem_68.Size = new Size(188, 22);
			this.toolStripMenuItem_68.Text = "Удалить адрес";
			this.toolStripMenuItem_68.Click += this.toolStripButton_160_Click;
			this.bindingSource_14.DataMember = "vP_ObjAddress";
			this.bindingSource_14.DataSource = this.class107_0;
			this.toolStrip_34.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_34.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_157,
				this.toolStripButton_158,
				this.toolStripButton_159,
				this.toolStripButton_160,
				this.toolStripSeparator_99,
				this.toolStripButton_161
			});
			this.toolStrip_34.Location = new Point(0, 0);
			this.toolStrip_34.Name = "tsAddress";
			this.toolStrip_34.Size = new Size(489, 25);
			this.toolStrip_34.TabIndex = 0;
			this.toolStrip_34.Text = "toolStrip1";
			this.toolStripButton_157.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_157.Image = Resources.smethod_24();
			this.toolStripButton_157.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_157.Name = "tsBtnAddAddress";
			this.toolStripButton_157.Size = new Size(23, 22);
			this.toolStripButton_157.Text = "Добавить адрес";
			this.toolStripButton_157.Click += this.toolStripButton_157_Click;
			this.toolStripButton_158.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_158.Image = Resources.smethod_26();
			this.toolStripButton_158.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_158.Name = "tsBtnEditAddress";
			this.toolStripButton_158.Size = new Size(23, 22);
			this.toolStripButton_158.Text = "Редактировать адрес";
			this.toolStripButton_158.Click += this.toolStripButton_158_Click;
			this.toolStripButton_159.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_159.Image = Resources.smethod_17();
			this.toolStripButton_159.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_159.Name = "tsBtnCopyAddress";
			this.toolStripButton_159.Size = new Size(23, 22);
			this.toolStripButton_159.Text = "Копировать адрес";
			this.toolStripButton_159.Click += this.toolStripButton_159_Click;
			this.toolStripButton_160.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_160.Image = Resources.smethod_25();
			this.toolStripButton_160.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_160.Name = "tsBtnDelAddress";
			this.toolStripButton_160.Size = new Size(23, 22);
			this.toolStripButton_160.Text = "Удалить адрес";
			this.toolStripButton_160.Click += this.toolStripButton_160_Click;
			this.toolStripSeparator_99.Name = "toolStripSeparator44";
			this.toolStripSeparator_99.Size = new Size(6, 25);
			this.toolStripButton_161.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_161.Image = Resources.smethod_45();
			this.toolStripButton_161.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_161.Name = "tsBtnRefreshObjAddress";
			this.toolStripButton_161.Size = new Size(23, 22);
			this.toolStripButton_161.Text = "Обновить список адресов";
			this.toolStripButton_161.Click += this.toolStripButton_161_Click;
			this.tabPage_31.Controls.Add(this.dataGridViewExcelFilter_10);
			this.tabPage_31.Controls.Add(this.toolStrip_35);
			this.tabPage_31.Location = new Point(4, 22);
			this.tabPage_31.Name = "tpAirLineRepair";
			this.tabPage_31.Size = new Size(489, 125);
			this.tabPage_31.TabIndex = 17;
			this.tabPage_31.Text = "Ремонт ВЛ";
			this.tabPage_31.UseVisualStyleBackColor = true;
			this.dataGridViewExcelFilter_10.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_10.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_10.AllowUserToOrderColumns = true;
			this.dataGridViewExcelFilter_10.BackgroundColor = SystemColors.Window;
			this.dataGridViewExcelFilter_10.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_227,
				this.dataGridViewTextBoxColumn_228,
				this.dataGridViewTextBoxColumn_229,
				this.dataGridViewTextBoxColumn_230,
				this.dataGridViewTextBoxColumn_231,
				this.dataGridViewTextBoxColumn_232,
				this.dataGridViewTextBoxColumn_233,
				this.ikuogYtqqM,
				this.dataGridViewTextBoxColumn_234,
				this.dataGridViewTextBoxColumn_235,
				this.dataGridViewTextBoxColumn_236,
				this.dataGridViewTextBoxColumn_237
			});
			this.dataGridViewExcelFilter_10.ContextMenuStrip = this.NawojBnvmy;
			dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle35.BackColor = SystemColors.Window;
			dataGridViewCellStyle35.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle35.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle35.SelectionBackColor = SystemColors.HighlightText;
			dataGridViewCellStyle35.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle35.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_10.DefaultCellStyle = dataGridViewCellStyle35;
			this.dataGridViewExcelFilter_10.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_10.Location = new Point(0, 25);
			this.dataGridViewExcelFilter_10.MultiSelect = false;
			this.dataGridViewExcelFilter_10.Name = "dgvAirLineRepair";
			this.dataGridViewExcelFilter_10.ReadOnly = true;
			this.dataGridViewExcelFilter_10.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridViewExcelFilter_10.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_10.Size = new Size(489, 100);
			this.dataGridViewExcelFilter_10.TabIndex = 1;
			this.dataGridViewExcelFilter_10.CellContextMenuStripNeeded += this.dataGridViewExcelFilter_10_CellContextMenuStripNeeded;
			this.dataGridViewExcelFilter_10.CellDoubleClick += this.dataGridViewExcelFilter_10_CellDoubleClick;
			this.dataGridViewTextBoxColumn_227.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_227.HeaderText = "id";
			this.dataGridViewTextBoxColumn_227.Name = "idDgvAirLineRepair";
			this.dataGridViewTextBoxColumn_227.ReadOnly = true;
			this.dataGridViewTextBoxColumn_227.Visible = false;
			this.dataGridViewTextBoxColumn_228.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_228.HeaderText = "ParentId";
			this.dataGridViewTextBoxColumn_228.Name = "ParentIdDgvAirLineRepair";
			this.dataGridViewTextBoxColumn_228.ReadOnly = true;
			this.dataGridViewTextBoxColumn_228.Visible = false;
			this.dataGridViewTextBoxColumn_229.DataPropertyName = "typeDoc";
			this.dataGridViewTextBoxColumn_229.HeaderText = "typeDoc";
			this.dataGridViewTextBoxColumn_229.Name = "typeDocDgvAirLineRepair";
			this.dataGridViewTextBoxColumn_229.ReadOnly = true;
			this.dataGridViewTextBoxColumn_229.Visible = false;
			this.dataGridViewTextBoxColumn_230.DataPropertyName = "idReason";
			this.dataGridViewTextBoxColumn_230.HeaderText = "idReason";
			this.dataGridViewTextBoxColumn_230.Name = "idReasonDgvAirLineRepair";
			this.dataGridViewTextBoxColumn_230.ReadOnly = true;
			this.dataGridViewTextBoxColumn_230.Visible = false;
			this.dataGridViewTextBoxColumn_231.DataPropertyName = "numberDoc";
			this.dataGridViewTextBoxColumn_231.HeaderText = "Номер документа";
			this.dataGridViewTextBoxColumn_231.Name = "numberDocDgvAirLineRepair";
			this.dataGridViewTextBoxColumn_231.ReadOnly = true;
			this.dataGridViewTextBoxColumn_232.DataPropertyName = "dateDoc";
			this.dataGridViewTextBoxColumn_232.HeaderText = "Дата документа";
			this.dataGridViewTextBoxColumn_232.Name = "dateDocDgvAirLineRepair";
			this.dataGridViewTextBoxColumn_232.ReadOnly = true;
			this.dataGridViewTextBoxColumn_233.DataPropertyName = "reason";
			this.dataGridViewTextBoxColumn_233.HeaderText = "Причина";
			this.dataGridViewTextBoxColumn_233.Name = "reasonDgvAirLineRepair";
			this.dataGridViewTextBoxColumn_233.ReadOnly = true;
			this.dataGridViewTextBoxColumn_233.Visible = false;
			this.ikuogYtqqM.DataPropertyName = "typeDocName";
			this.ikuogYtqqM.HeaderText = "Тип документа";
			this.ikuogYtqqM.Name = "typeDocNameDgvAirLineRepair";
			this.ikuogYtqqM.ReadOnly = true;
			this.ikuogYtqqM.Visible = false;
			this.dataGridViewTextBoxColumn_234.DataPropertyName = "From";
			this.dataGridViewTextBoxColumn_234.HeaderText = "От";
			this.dataGridViewTextBoxColumn_234.Name = "FromDgvAirLineRepair";
			this.dataGridViewTextBoxColumn_234.ReadOnly = true;
			this.dataGridViewTextBoxColumn_235.DataPropertyName = "To";
			this.dataGridViewTextBoxColumn_235.HeaderText = "До";
			this.dataGridViewTextBoxColumn_235.Name = "ToDgvAirLineRepair";
			this.dataGridViewTextBoxColumn_235.ReadOnly = true;
			this.dataGridViewTextBoxColumn_236.DataPropertyName = "dateStartUp";
			this.dataGridViewTextBoxColumn_236.HeaderText = "Дата ввода в экспл.";
			this.dataGridViewTextBoxColumn_236.Name = "dateStartUpDgvAirLineRepair";
			this.dataGridViewTextBoxColumn_236.ReadOnly = true;
			this.dataGridViewTextBoxColumn_236.Visible = false;
			this.dataGridViewTextBoxColumn_237.DataPropertyName = "comment";
			this.dataGridViewTextBoxColumn_237.HeaderText = "Примечание";
			this.dataGridViewTextBoxColumn_237.Name = "commentDgvAirLineRepair";
			this.dataGridViewTextBoxColumn_237.ReadOnly = true;
			this.NawojBnvmy.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_73,
				this.toolStripMenuItem_74,
				this.toolStripMenuItem_75,
				this.toolStripMenuItem_76,
				this.toolStripSeparator_103,
				this.toolStripMenuItem_89
			});
			this.NawojBnvmy.Name = "cmsAirLineRepair";
			this.NawojBnvmy.Size = new Size(155, 120);
			this.toolStripMenuItem_73.Image = Resources.smethod_24();
			this.toolStripMenuItem_73.Name = "cmsmiAddAirLineRepair";
			this.toolStripMenuItem_73.Size = new Size(154, 22);
			this.toolStripMenuItem_73.Text = "Добавить";
			this.toolStripMenuItem_73.Click += this.toolStripButton_162_Click;
			this.toolStripMenuItem_74.Image = Resources.smethod_26();
			this.toolStripMenuItem_74.Name = "cmsmiEditAirLineRepair";
			this.toolStripMenuItem_74.Size = new Size(154, 22);
			this.toolStripMenuItem_74.Text = "Редактировать";
			this.toolStripMenuItem_74.Click += this.toolStripButton_163_Click;
			this.toolStripMenuItem_75.Image = Resources.smethod_25();
			this.toolStripMenuItem_75.Name = "cmsmiDelAirLineRepair";
			this.toolStripMenuItem_75.Size = new Size(154, 22);
			this.toolStripMenuItem_75.Text = "Удалить";
			this.toolStripMenuItem_75.Click += this.toolStripButton_164_Click;
			this.toolStripMenuItem_76.Image = Resources.smethod_45();
			this.toolStripMenuItem_76.Name = "cmsmiRefreshAirLineRepair";
			this.toolStripMenuItem_76.Size = new Size(154, 22);
			this.toolStripMenuItem_76.Text = "Обновить";
			this.toolStripMenuItem_76.Click += this.toolStripButton_165_Click;
			this.toolStripSeparator_103.Name = "toolStripSeparator50";
			this.toolStripSeparator_103.Size = new Size(151, 6);
			this.toolStripMenuItem_89.Image = Resources.smethod_44();
			this.toolStripMenuItem_89.Name = "tsmiPrintAirLineRepair";
			this.toolStripMenuItem_89.Size = new Size(154, 22);
			this.toolStripMenuItem_89.Text = "Отчет";
			this.toolStripMenuItem_89.Click += this.toolStripButton_178_Click;
			this.toolStrip_35.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_35.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_162,
				this.toolStripButton_163,
				this.toolStripButton_164,
				this.toolStripButton_165,
				this.toolStripSeparator_100,
				this.toolStripButton_178
			});
			this.toolStrip_35.Location = new Point(0, 0);
			this.toolStrip_35.Name = "tsAirLineRepair";
			this.toolStrip_35.Size = new Size(489, 25);
			this.toolStrip_35.TabIndex = 0;
			this.toolStrip_35.Text = "toolStrip1";
			this.toolStripButton_162.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_162.Image = Resources.smethod_24();
			this.toolStripButton_162.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_162.Name = "tsBtnAddAirLineRepair";
			this.toolStripButton_162.Size = new Size(23, 22);
			this.toolStripButton_162.Text = "Добавить";
			this.toolStripButton_162.Click += this.toolStripButton_162_Click;
			this.toolStripButton_163.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_163.Image = Resources.smethod_26();
			this.toolStripButton_163.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_163.Name = "tsBtnEditAirLineRepair";
			this.toolStripButton_163.Size = new Size(23, 22);
			this.toolStripButton_163.Text = "Редактировать";
			this.toolStripButton_163.Click += this.toolStripButton_163_Click;
			this.toolStripButton_164.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_164.Image = Resources.smethod_25();
			this.toolStripButton_164.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_164.Name = "tsBtnDelAirLineRepair";
			this.toolStripButton_164.Size = new Size(23, 22);
			this.toolStripButton_164.Text = "Удалить";
			this.toolStripButton_164.Click += this.toolStripButton_164_Click;
			this.toolStripButton_165.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_165.Image = Resources.smethod_45();
			this.toolStripButton_165.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_165.Name = "tsBtnRefreshAirLineRepair";
			this.toolStripButton_165.Size = new Size(23, 22);
			this.toolStripButton_165.Text = "Обновить";
			this.toolStripButton_165.Click += this.toolStripButton_165_Click;
			this.toolStripSeparator_100.Name = "toolStripSeparator45";
			this.toolStripSeparator_100.Size = new Size(6, 25);
			this.toolStripButton_178.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_178.Image = Resources.smethod_44();
			this.toolStripButton_178.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_178.Name = "tsBtnPrintAirLineRepair";
			this.toolStripButton_178.Size = new Size(23, 22);
			this.toolStripButton_178.Text = "Отчет";
			this.toolStripButton_178.Click += this.toolStripButton_178_Click;
			this.tabPage_32.Controls.Add(this.dataGridViewExcelFilter_11);
			this.tabPage_32.Controls.Add(this.toolStrip_36);
			this.tabPage_32.Location = new Point(4, 22);
			this.tabPage_32.Name = "tpAirLineStartUp";
			this.tabPage_32.Size = new Size(489, 125);
			this.tabPage_32.TabIndex = 18;
			this.tabPage_32.Text = "Эксплуатация ВЛ";
			this.tabPage_32.UseVisualStyleBackColor = true;
			this.dataGridViewExcelFilter_11.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_11.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_11.AllowUserToOrderColumns = true;
			this.dataGridViewExcelFilter_11.BackgroundColor = SystemColors.Window;
			this.dataGridViewExcelFilter_11.Columns.AddRange(new DataGridViewColumn[]
			{
				this.ensobXmnxq,
				this.dataGridViewTextBoxColumn_238,
				this.dataGridViewTextBoxColumn_239,
				this.dataGridViewTextBoxColumn_240,
				this.dataGridViewTextBoxColumn_241,
				this.dataGridViewTextBoxColumn_242,
				this.dataGridViewTextBoxColumn_243,
				this.dataGridViewTextBoxColumn_244,
				this.dataGridViewTextBoxColumn_245,
				this.dataGridViewTextBoxColumn_246,
				this.mTiRmHbeJe
			});
			this.dataGridViewExcelFilter_11.ContextMenuStrip = this.contextMenuStrip_17;
			dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle36.BackColor = SystemColors.Window;
			dataGridViewCellStyle36.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle36.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle36.SelectionBackColor = SystemColors.HighlightText;
			dataGridViewCellStyle36.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle36.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_11.DefaultCellStyle = dataGridViewCellStyle36;
			this.dataGridViewExcelFilter_11.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_11.Location = new Point(0, 25);
			this.dataGridViewExcelFilter_11.MultiSelect = false;
			this.dataGridViewExcelFilter_11.Name = "dgvAirLineStartUp";
			this.dataGridViewExcelFilter_11.ReadOnly = true;
			this.dataGridViewExcelFilter_11.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridViewExcelFilter_11.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_11.Size = new Size(489, 100);
			this.dataGridViewExcelFilter_11.TabIndex = 1;
			this.dataGridViewExcelFilter_11.CellContextMenuStripNeeded += this.dataGridViewExcelFilter_11_CellContextMenuStripNeeded;
			this.dataGridViewExcelFilter_11.CellDoubleClick += this.dataGridViewExcelFilter_11_CellDoubleClick;
			this.ensobXmnxq.DataPropertyName = "id";
			this.ensobXmnxq.HeaderText = "id";
			this.ensobXmnxq.Name = "idDgvAirLineStartUp";
			this.ensobXmnxq.ReadOnly = true;
			this.ensobXmnxq.Visible = false;
			this.dataGridViewTextBoxColumn_238.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_238.HeaderText = "ParentId";
			this.dataGridViewTextBoxColumn_238.Name = "ParentIdDgvAirLineStartUp";
			this.dataGridViewTextBoxColumn_238.ReadOnly = true;
			this.dataGridViewTextBoxColumn_238.Visible = false;
			this.dataGridViewTextBoxColumn_239.DataPropertyName = "idReason";
			this.dataGridViewTextBoxColumn_239.HeaderText = "idReason";
			this.dataGridViewTextBoxColumn_239.Name = "idReasonDgvAirLineStartUp";
			this.dataGridViewTextBoxColumn_239.ReadOnly = true;
			this.dataGridViewTextBoxColumn_239.Visible = false;
			this.dataGridViewTextBoxColumn_240.DataPropertyName = "typeDoc";
			this.dataGridViewTextBoxColumn_240.HeaderText = "typeDoc";
			this.dataGridViewTextBoxColumn_240.Name = "typeDocDgvAirLineStartUp";
			this.dataGridViewTextBoxColumn_240.ReadOnly = true;
			this.dataGridViewTextBoxColumn_240.Visible = false;
			this.dataGridViewTextBoxColumn_241.DataPropertyName = "numberDoc";
			this.dataGridViewTextBoxColumn_241.HeaderText = "Номер документа";
			this.dataGridViewTextBoxColumn_241.Name = "numberDocDgvAirLineStartUp";
			this.dataGridViewTextBoxColumn_241.ReadOnly = true;
			this.dataGridViewTextBoxColumn_242.DataPropertyName = "dateDoc";
			this.dataGridViewTextBoxColumn_242.HeaderText = "Дата документа";
			this.dataGridViewTextBoxColumn_242.Name = "dateDocDgvAirLineStartUp";
			this.dataGridViewTextBoxColumn_242.ReadOnly = true;
			this.dataGridViewTextBoxColumn_243.DataPropertyName = "reason";
			this.dataGridViewTextBoxColumn_243.HeaderText = "Причина";
			this.dataGridViewTextBoxColumn_243.Name = "reasonDgvAirLineStartUp";
			this.dataGridViewTextBoxColumn_243.ReadOnly = true;
			this.dataGridViewTextBoxColumn_244.DataPropertyName = "From";
			this.dataGridViewTextBoxColumn_244.HeaderText = "От";
			this.dataGridViewTextBoxColumn_244.Name = "FromDgvAirLineStartUp";
			this.dataGridViewTextBoxColumn_244.ReadOnly = true;
			this.dataGridViewTextBoxColumn_245.DataPropertyName = "To";
			this.dataGridViewTextBoxColumn_245.HeaderText = "До";
			this.dataGridViewTextBoxColumn_245.Name = "ToDgvAirLineStartUp";
			this.dataGridViewTextBoxColumn_245.ReadOnly = true;
			this.dataGridViewTextBoxColumn_246.DataPropertyName = "dateStartUp";
			this.dataGridViewTextBoxColumn_246.HeaderText = "Дата ввода в экспл.";
			this.dataGridViewTextBoxColumn_246.Name = "dateStartUpDgvAirLineStartUp";
			this.dataGridViewTextBoxColumn_246.ReadOnly = true;
			this.mTiRmHbeJe.DataPropertyName = "comment";
			this.mTiRmHbeJe.HeaderText = "Примечание";
			this.mTiRmHbeJe.Name = "commentDgvAirLineStartUp";
			this.mTiRmHbeJe.ReadOnly = true;
			this.contextMenuStrip_17.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_81,
				this.toolStripMenuItem_82,
				this.toolStripMenuItem_83,
				this.toolStripMenuItem_84,
				this.toolStripSeparator_104,
				this.toolStripMenuItem_90
			});
			this.contextMenuStrip_17.Name = "cmsAirLineStartUp";
			this.contextMenuStrip_17.Size = new Size(155, 120);
			this.toolStripMenuItem_81.Image = Resources.smethod_24();
			this.toolStripMenuItem_81.Name = "cmsmiAddAirLineStartUp";
			this.toolStripMenuItem_81.Size = new Size(154, 22);
			this.toolStripMenuItem_81.Text = "Добавить";
			this.toolStripMenuItem_81.Click += this.toolStripButton_166_Click;
			this.toolStripMenuItem_82.Image = Resources.smethod_26();
			this.toolStripMenuItem_82.Name = "smcmiEditAirLineStartUp";
			this.toolStripMenuItem_82.Size = new Size(154, 22);
			this.toolStripMenuItem_82.Text = "Редактировать";
			this.toolStripMenuItem_82.Click += this.toolStripButton_167_Click;
			this.toolStripMenuItem_83.Image = Resources.smethod_25();
			this.toolStripMenuItem_83.Name = "cmsmiDelAirLineStartUp";
			this.toolStripMenuItem_83.Size = new Size(154, 22);
			this.toolStripMenuItem_83.Text = "Удалить";
			this.toolStripMenuItem_83.Click += this.toolStripButton_168_Click;
			this.toolStripMenuItem_84.Image = Resources.smethod_45();
			this.toolStripMenuItem_84.Name = "cmsmiRefreshAirLineStartUp";
			this.toolStripMenuItem_84.Size = new Size(154, 22);
			this.toolStripMenuItem_84.Text = "Обновить";
			this.toolStripMenuItem_84.Click += this.toolStripButton_169_Click;
			this.toolStripSeparator_104.Name = "toolStripSeparator49";
			this.toolStripSeparator_104.Size = new Size(151, 6);
			this.toolStripMenuItem_90.Image = Resources.smethod_44();
			this.toolStripMenuItem_90.Name = "tsmiPrintAirLineStartUp";
			this.toolStripMenuItem_90.Size = new Size(154, 22);
			this.toolStripMenuItem_90.Text = "Отчет";
			this.toolStripMenuItem_90.Click += this.toolStripButton_179_Click;
			this.toolStrip_36.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_36.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_166,
				this.toolStripButton_167,
				this.toolStripButton_168,
				this.toolStripButton_169,
				this.toolStripSeparator_101,
				this.toolStripButton_179
			});
			this.toolStrip_36.Location = new Point(0, 0);
			this.toolStrip_36.Name = "tsAirLineStartUp";
			this.toolStrip_36.Size = new Size(489, 25);
			this.toolStrip_36.TabIndex = 0;
			this.toolStrip_36.Text = "toolStrip1";
			this.toolStripButton_166.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_166.Image = Resources.smethod_24();
			this.toolStripButton_166.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_166.Name = "tsBtnAddAirLineStartUp";
			this.toolStripButton_166.Size = new Size(23, 22);
			this.toolStripButton_166.Text = "Добавить";
			this.toolStripButton_166.Click += this.toolStripButton_166_Click;
			this.toolStripButton_167.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_167.Image = Resources.smethod_26();
			this.toolStripButton_167.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_167.Name = "tsBtnEditAirLineStartUp";
			this.toolStripButton_167.Size = new Size(23, 22);
			this.toolStripButton_167.Text = "Редактировать";
			this.toolStripButton_167.Click += this.toolStripButton_167_Click;
			this.toolStripButton_168.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_168.Image = Resources.smethod_25();
			this.toolStripButton_168.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_168.Name = "tsBtnDelAirLineStartUp";
			this.toolStripButton_168.Size = new Size(23, 22);
			this.toolStripButton_168.Text = "Удалить";
			this.toolStripButton_168.Click += this.toolStripButton_168_Click;
			this.toolStripButton_169.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_169.Image = Resources.smethod_45();
			this.toolStripButton_169.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_169.Name = "tsBtnRefreshAirLineStartUp";
			this.toolStripButton_169.Size = new Size(23, 22);
			this.toolStripButton_169.Text = "Обновить";
			this.toolStripButton_169.Click += this.toolStripButton_169_Click;
			this.toolStripSeparator_101.Name = "toolStripSeparator46";
			this.toolStripSeparator_101.Size = new Size(6, 25);
			this.toolStripButton_179.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_179.Image = Resources.smethod_44();
			this.toolStripButton_179.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_179.Name = "tsBtnPrintAirLineStartUp";
			this.toolStripButton_179.Size = new Size(23, 22);
			this.toolStripButton_179.Text = "Отчет";
			this.toolStripButton_179.Click += this.toolStripButton_179_Click;
			this.tabPage_33.Controls.Add(this.dataGridViewExcelFilter_12);
			this.tabPage_33.Controls.Add(this.toolStrip_37);
			this.tabPage_33.Location = new Point(4, 22);
			this.tabPage_33.Name = "tpPylonEquipRepair";
			this.tabPage_33.Size = new Size(489, 125);
			this.tabPage_33.TabIndex = 19;
			this.tabPage_33.Text = "Эксплуатация обор-я";
			this.tabPage_33.UseVisualStyleBackColor = true;
			this.dataGridViewExcelFilter_12.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_12.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_12.AllowUserToOrderColumns = true;
			this.dataGridViewExcelFilter_12.BackgroundColor = SystemColors.Window;
			this.dataGridViewExcelFilter_12.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_247,
				this.dataGridViewTextBoxColumn_248,
				this.dataGridViewTextBoxColumn_249,
				this.dataGridViewTextBoxColumn_250,
				this.dataGridViewTextBoxColumn_251,
				this.dataGridViewTextBoxColumn_252,
				this.dataGridViewTextBoxColumn_253,
				this.dataGridViewTextBoxColumn_254,
				this.dataGridViewTextBoxColumn_255,
				this.dataGridViewTextBoxColumn_256,
				this.dataGridViewTextBoxColumn_257,
				this.dataGridViewTextBoxColumn_258,
				this.dataGridViewTextBoxColumn_259,
				this.dataGridViewTextBoxColumn_260
			});
			this.dataGridViewExcelFilter_12.ContextMenuStrip = this.contextMenuStrip_16;
			dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle37.BackColor = SystemColors.Window;
			dataGridViewCellStyle37.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle37.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle37.SelectionBackColor = SystemColors.HighlightText;
			dataGridViewCellStyle37.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle37.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_12.DefaultCellStyle = dataGridViewCellStyle37;
			this.dataGridViewExcelFilter_12.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_12.Location = new Point(0, 25);
			this.dataGridViewExcelFilter_12.MultiSelect = false;
			this.dataGridViewExcelFilter_12.Name = "dgvPylonEquipRepair";
			this.dataGridViewExcelFilter_12.ReadOnly = true;
			this.dataGridViewExcelFilter_12.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridViewExcelFilter_12.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_12.Size = new Size(489, 100);
			this.dataGridViewExcelFilter_12.TabIndex = 1;
			this.dataGridViewExcelFilter_12.CellContextMenuStripNeeded += this.dataGridViewExcelFilter_12_CellContextMenuStripNeeded;
			this.dataGridViewExcelFilter_12.CellDoubleClick += this.dataGridViewExcelFilter_12_CellDoubleClick;
			this.dataGridViewTextBoxColumn_247.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_247.HeaderText = "id";
			this.dataGridViewTextBoxColumn_247.Name = "idDgvPylonEquipRepair";
			this.dataGridViewTextBoxColumn_247.ReadOnly = true;
			this.dataGridViewTextBoxColumn_247.Visible = false;
			this.dataGridViewTextBoxColumn_248.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_248.HeaderText = "ParentId";
			this.dataGridViewTextBoxColumn_248.Name = "ParentIdDgvPylonEquipRepair";
			this.dataGridViewTextBoxColumn_248.ReadOnly = true;
			this.dataGridViewTextBoxColumn_248.Visible = false;
			this.dataGridViewTextBoxColumn_249.DataPropertyName = "typeDoc";
			this.dataGridViewTextBoxColumn_249.HeaderText = "typeDoc";
			this.dataGridViewTextBoxColumn_249.Name = "typeDocDgvPylonEquipRepair";
			this.dataGridViewTextBoxColumn_249.ReadOnly = true;
			this.dataGridViewTextBoxColumn_249.Visible = false;
			this.dataGridViewTextBoxColumn_250.DataPropertyName = "idTypeWork";
			this.dataGridViewTextBoxColumn_250.HeaderText = "idTypeWork";
			this.dataGridViewTextBoxColumn_250.Name = "idTypeWorkDgvPylonEquipRepair";
			this.dataGridViewTextBoxColumn_250.ReadOnly = true;
			this.dataGridViewTextBoxColumn_250.Visible = false;
			this.dataGridViewTextBoxColumn_251.DataPropertyName = "idReason";
			this.dataGridViewTextBoxColumn_251.HeaderText = "idReason";
			this.dataGridViewTextBoxColumn_251.Name = "idReasonDgvPylonEquipRepair";
			this.dataGridViewTextBoxColumn_251.ReadOnly = true;
			this.dataGridViewTextBoxColumn_251.Visible = false;
			this.dataGridViewTextBoxColumn_252.DataPropertyName = "idPylon";
			this.dataGridViewTextBoxColumn_252.HeaderText = "idPylon";
			this.dataGridViewTextBoxColumn_252.Name = "idPylonDgvPylonEquipRepair";
			this.dataGridViewTextBoxColumn_252.ReadOnly = true;
			this.dataGridViewTextBoxColumn_252.Visible = false;
			this.dataGridViewTextBoxColumn_253.DataPropertyName = "idEquipment";
			this.dataGridViewTextBoxColumn_253.HeaderText = "idEquipment";
			this.dataGridViewTextBoxColumn_253.Name = "idEquipmentDgvPylonEquipRepair";
			this.dataGridViewTextBoxColumn_253.ReadOnly = true;
			this.dataGridViewTextBoxColumn_253.Visible = false;
			this.dataGridViewTextBoxColumn_254.DataPropertyName = "numberDoc";
			this.dataGridViewTextBoxColumn_254.HeaderText = "Номер документа";
			this.dataGridViewTextBoxColumn_254.Name = "numberDocDgvPylonEquipRepair";
			this.dataGridViewTextBoxColumn_254.ReadOnly = true;
			this.dataGridViewTextBoxColumn_255.DataPropertyName = "dateDoc";
			this.dataGridViewTextBoxColumn_255.HeaderText = "Дата документа";
			this.dataGridViewTextBoxColumn_255.Name = "dateDocDgvPylonEquipRepair";
			this.dataGridViewTextBoxColumn_255.ReadOnly = true;
			this.dataGridViewTextBoxColumn_256.DataPropertyName = "typeWork";
			this.dataGridViewTextBoxColumn_256.HeaderText = "Вид работ";
			this.dataGridViewTextBoxColumn_256.Name = "typeWorkDgvPylonEquipRepair";
			this.dataGridViewTextBoxColumn_256.ReadOnly = true;
			this.dataGridViewTextBoxColumn_257.DataPropertyName = "reason";
			this.dataGridViewTextBoxColumn_257.HeaderText = "Причина";
			this.dataGridViewTextBoxColumn_257.Name = "reasonDgvPylonEquipRepair";
			this.dataGridViewTextBoxColumn_257.ReadOnly = true;
			this.dataGridViewTextBoxColumn_258.DataPropertyName = "pylon";
			this.dataGridViewTextBoxColumn_258.HeaderText = "Опора";
			this.dataGridViewTextBoxColumn_258.Name = "pylonDgvPylonEquipRepair";
			this.dataGridViewTextBoxColumn_258.ReadOnly = true;
			this.dataGridViewTextBoxColumn_259.DataPropertyName = "equipment";
			this.dataGridViewTextBoxColumn_259.HeaderText = "Обор-е опоры";
			this.dataGridViewTextBoxColumn_259.Name = "equipmentDgvPylonEquipRepair";
			this.dataGridViewTextBoxColumn_259.ReadOnly = true;
			this.dataGridViewTextBoxColumn_260.DataPropertyName = "comment";
			this.dataGridViewTextBoxColumn_260.HeaderText = "Примечание";
			this.dataGridViewTextBoxColumn_260.Name = "commentDgvPylonEquipRepair";
			this.dataGridViewTextBoxColumn_260.ReadOnly = true;
			this.contextMenuStrip_16.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_77,
				this.toolStripMenuItem_78,
				this.toolStripMenuItem_79,
				this.toolStripMenuItem_80,
				this.toolStripSeparator_105,
				this.toolStripMenuItem_91
			});
			this.contextMenuStrip_16.Name = "cmsPylonEquipRepair";
			this.contextMenuStrip_16.Size = new Size(155, 120);
			this.toolStripMenuItem_77.Image = Resources.smethod_24();
			this.toolStripMenuItem_77.Name = "cmsAddPylonEquipRepair";
			this.toolStripMenuItem_77.Size = new Size(154, 22);
			this.toolStripMenuItem_77.Text = "Эксплуатация";
			this.toolStripMenuItem_77.Click += this.toolStripButton_173_Click;
			this.toolStripMenuItem_78.Image = Resources.smethod_26();
			this.toolStripMenuItem_78.Name = "cmsmiEditPylonEquipRepair";
			this.toolStripMenuItem_78.Size = new Size(154, 22);
			this.toolStripMenuItem_78.Text = "Редактировать";
			this.toolStripMenuItem_78.Click += this.toolStripButton_170_Click;
			this.toolStripMenuItem_79.Image = Resources.smethod_25();
			this.toolStripMenuItem_79.Name = "cmsmiDelPylonEquipRepair";
			this.toolStripMenuItem_79.Size = new Size(154, 22);
			this.toolStripMenuItem_79.Text = "Удалить";
			this.toolStripMenuItem_79.Click += this.toolStripButton_171_Click;
			this.toolStripMenuItem_80.Image = Resources.smethod_45();
			this.toolStripMenuItem_80.Name = "cmsmiRefreshPylonEquipRepair";
			this.toolStripMenuItem_80.Size = new Size(154, 22);
			this.toolStripMenuItem_80.Text = "Обновить";
			this.toolStripMenuItem_80.Click += this.toolStripButton_172_Click;
			this.toolStripSeparator_105.Name = "toolStripSeparator52";
			this.toolStripSeparator_105.Size = new Size(151, 6);
			this.toolStripMenuItem_91.Image = Resources.smethod_44();
			this.toolStripMenuItem_91.Name = "tsmiPrintPylonEquipExpl";
			this.toolStripMenuItem_91.Size = new Size(154, 22);
			this.toolStripMenuItem_91.Text = "Отчет";
			this.toolStripMenuItem_91.Click += this.toolStripButton_181_Click;
			this.toolStrip_37.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_37.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_173,
				this.toolStripButton_170,
				this.toolStripButton_171,
				this.toolStripButton_172,
				this.toolStripSeparator_106,
				this.toolStripButton_181
			});
			this.toolStrip_37.Location = new Point(0, 0);
			this.toolStrip_37.Name = "tsPylonEquipRepair";
			this.toolStrip_37.Size = new Size(489, 25);
			this.toolStrip_37.TabIndex = 0;
			this.toolStrip_37.Text = "toolStrip1";
			this.toolStripButton_173.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_173.ForeColor = SystemColors.ControlText;
			this.toolStripButton_173.Image = Resources.smethod_24();
			this.toolStripButton_173.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_173.Name = "tsBtnAddPylonRepair";
			this.toolStripButton_173.Size = new Size(23, 22);
			this.toolStripButton_173.Text = "Добавить";
			this.toolStripButton_173.Click += this.toolStripButton_173_Click;
			this.toolStripButton_170.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_170.Image = Resources.smethod_26();
			this.toolStripButton_170.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_170.Name = "tsBtnEditPylonEquipRepair";
			this.toolStripButton_170.Size = new Size(23, 22);
			this.toolStripButton_170.Text = "Редактировать";
			this.toolStripButton_170.Click += this.toolStripButton_170_Click;
			this.toolStripButton_171.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_171.Image = Resources.smethod_25();
			this.toolStripButton_171.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_171.Name = "tsmiDelPylonEquipRepair";
			this.toolStripButton_171.Size = new Size(23, 22);
			this.toolStripButton_171.Text = "Удалить";
			this.toolStripButton_171.Click += this.toolStripButton_171_Click;
			this.toolStripButton_172.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_172.Image = Resources.smethod_45();
			this.toolStripButton_172.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_172.Name = "tsmiRefreshPylonEquipRepair";
			this.toolStripButton_172.Size = new Size(23, 22);
			this.toolStripButton_172.Text = "Обновить";
			this.toolStripButton_172.Click += this.toolStripButton_172_Click;
			this.toolStripSeparator_106.Name = "toolStripSeparator51";
			this.toolStripSeparator_106.Size = new Size(6, 25);
			this.toolStripButton_181.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_181.Image = Resources.smethod_44();
			this.toolStripButton_181.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_181.Name = "tsBtnPrintPylonEquipExpl";
			this.toolStripButton_181.Size = new Size(23, 22);
			this.toolStripButton_181.Text = "Отчет";
			this.toolStripButton_181.Click += this.toolStripButton_181_Click;
			this.tabPage_34.Controls.Add(this.dataGridView_16);
			this.tabPage_34.Controls.Add(this.toolStrip_38);
			this.tabPage_34.Location = new Point(4, 22);
			this.tabPage_34.Name = "tpInspectAirLine";
			this.tabPage_34.Size = new Size(489, 125);
			this.tabPage_34.TabIndex = 20;
			this.tabPage_34.Text = "Осмотр ВЛ";
			this.tabPage_34.UseVisualStyleBackColor = true;
			this.dataGridView_16.AllowUserToAddRows = false;
			this.dataGridView_16.AllowUserToDeleteRows = false;
			this.dataGridView_16.BackgroundColor = SystemColors.Window;
			this.dataGridView_16.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_261,
				this.dataGridViewTextBoxColumn_262,
				this.dataGridViewTextBoxColumn_263,
				this.dataGridViewTextBoxColumn_264,
				this.dataGridViewTextBoxColumn_265
			});
			dataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle38.BackColor = SystemColors.Window;
			dataGridViewCellStyle38.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle38.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle38.SelectionBackColor = SystemColors.HighlightText;
			dataGridViewCellStyle38.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle38.WrapMode = DataGridViewTriState.False;
			this.dataGridView_16.DefaultCellStyle = dataGridViewCellStyle38;
			this.dataGridView_16.Dock = DockStyle.Fill;
			this.dataGridView_16.Location = new Point(0, 25);
			this.dataGridView_16.MultiSelect = false;
			this.dataGridView_16.Name = "dgvInspectAirLine";
			this.dataGridView_16.ReadOnly = true;
			this.dataGridView_16.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridView_16.Size = new Size(489, 100);
			this.dataGridView_16.TabIndex = 1;
			this.dataGridView_16.CellContextMenuStripNeeded += this.dataGridView_16_CellContextMenuStripNeeded;
			this.dataGridView_16.CellDoubleClick += this.dataGridView_16_CellDoubleClick;
			this.dataGridViewTextBoxColumn_261.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_261.HeaderText = "id";
			this.dataGridViewTextBoxColumn_261.Name = "idDgvInspectAirLine";
			this.dataGridViewTextBoxColumn_261.ReadOnly = true;
			this.dataGridViewTextBoxColumn_261.Visible = false;
			this.dataGridViewTextBoxColumn_262.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_262.HeaderText = "idObjList";
			this.dataGridViewTextBoxColumn_262.Name = "idObjListDgvInspectAirLine";
			this.dataGridViewTextBoxColumn_262.ReadOnly = true;
			this.dataGridViewTextBoxColumn_262.Visible = false;
			this.dataGridViewTextBoxColumn_263.DataPropertyName = "typeDoc";
			this.dataGridViewTextBoxColumn_263.HeaderText = "typeDoc";
			this.dataGridViewTextBoxColumn_263.Name = "typeDocDgvInspectAirLine";
			this.dataGridViewTextBoxColumn_263.ReadOnly = true;
			this.dataGridViewTextBoxColumn_263.Visible = false;
			this.dataGridViewTextBoxColumn_264.DataPropertyName = "numberDoc";
			this.dataGridViewTextBoxColumn_264.HeaderText = "Номер документа";
			this.dataGridViewTextBoxColumn_264.Name = "NumberDocDgvInspectAirLine";
			this.dataGridViewTextBoxColumn_264.ReadOnly = true;
			this.dataGridViewTextBoxColumn_265.DataPropertyName = "dateDoc";
			this.dataGridViewTextBoxColumn_265.HeaderText = "Дата документа";
			this.dataGridViewTextBoxColumn_265.Name = "dateDocDgvInspectAirLine";
			this.dataGridViewTextBoxColumn_265.ReadOnly = true;
			this.toolStrip_38.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_38.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_174,
				this.toolStripButton_175,
				this.toolStripButton_176,
				this.toolStripButton_177,
				this.toolStripSeparator_102,
				this.toolStripButton_180
			});
			this.toolStrip_38.Location = new Point(0, 0);
			this.toolStrip_38.Name = "tsInspectAirLine";
			this.toolStrip_38.Size = new Size(489, 25);
			this.toolStrip_38.TabIndex = 0;
			this.toolStrip_38.Text = "toolStrip1";
			this.toolStripButton_174.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_174.Image = Resources.smethod_24();
			this.toolStripButton_174.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_174.Name = "tsBtnAddInspectAirLine";
			this.toolStripButton_174.Size = new Size(23, 22);
			this.toolStripButton_174.Text = "Добавить";
			this.toolStripButton_174.Click += this.toolStripMenuItem_85_Click;
			this.toolStripButton_175.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_175.Image = Resources.smethod_26();
			this.toolStripButton_175.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_175.Name = "tsBtnEditInspectAirLine";
			this.toolStripButton_175.Size = new Size(23, 22);
			this.toolStripButton_175.Text = "Редактировать";
			this.toolStripButton_175.Click += this.toolStripMenuItem_86_Click;
			this.toolStripButton_176.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_176.Image = Resources.smethod_25();
			this.toolStripButton_176.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_176.Name = "tsBtnDelInspectAirLine";
			this.toolStripButton_176.Size = new Size(23, 22);
			this.toolStripButton_176.Text = "Удалить";
			this.toolStripButton_176.Click += this.toolStripMenuItem_87_Click;
			this.toolStripButton_177.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_177.Image = Resources.smethod_45();
			this.toolStripButton_177.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_177.Name = "tsBtnRefreshInspectAirLine";
			this.toolStripButton_177.Size = new Size(23, 22);
			this.toolStripButton_177.Text = "Обновить";
			this.toolStripButton_177.Click += this.toolStripMenuItem_88_Click;
			this.toolStripSeparator_102.Name = "toolStripSeparator47";
			this.toolStripSeparator_102.Size = new Size(6, 25);
			this.toolStripButton_180.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_180.Image = Resources.smethod_44();
			this.toolStripButton_180.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_180.Name = "tsBtnPrintInspectAirLine";
			this.toolStripButton_180.Size = new Size(23, 22);
			this.toolStripButton_180.Text = "Отчет";
			this.toolStripButton_180.Click += this.contextMenuStrip_18_Click;
			this.dataGridViewPassport_0.AllowUserToAddRows = false;
			this.dataGridViewPassport_0.AllowUserToDeleteRows = false;
			this.dataGridViewPassport_0.AllowUserToResizeRows = false;
			this.dataGridViewPassport_0.BackgroundColor = Color.White;
			dataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle39.BackColor = SystemColors.Control;
			dataGridViewCellStyle39.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle39.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle39.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle39.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle39.WrapMode = DataGridViewTriState.True;
			this.dataGridViewPassport_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle39;
			this.dataGridViewPassport_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle40.BackColor = Color.White;
			dataGridViewCellStyle40.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle40.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle40.SelectionBackColor = Color.White;
			dataGridViewCellStyle40.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle40.WrapMode = DataGridViewTriState.False;
			this.dataGridViewPassport_0.DefaultCellStyle = dataGridViewCellStyle40;
			this.dataGridViewPassport_0.Dock = DockStyle.Fill;
			this.dataGridViewPassport_0.DragDropComplite = false;
			this.dataGridViewPassport_0.EditMode = DataGridViewEditMode.EditOnEnter;
			this.dataGridViewPassport_0.Location = new Point(3, 35);
			this.dataGridViewPassport_0.MultiSelect = false;
			this.dataGridViewPassport_0.Name = "DataGridViewPassport1";
			this.dataGridViewPassport_0.RowHeadersVisible = false;
			this.dataGridViewPassport_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewPassport_0.Size = new Size(497, 264);
			this.dataGridViewPassport_0.TabIndex = 10;
			this.dataGridViewTextBoxColumn_266.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_266.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_266.ReadOnly = true;
			this.dataGridViewTextBoxColumn_266.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_266.Visible = false;
			this.dataGridViewTextBoxColumn_267.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_267.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn_267.ReadOnly = true;
			this.dataGridViewTextBoxColumn_267.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_267.Visible = false;
			this.dataGridViewTextBoxColumn_268.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_268.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn_268.ReadOnly = true;
			this.dataGridViewTextBoxColumn_268.Visible = false;
			this.dataGridViewCheckBoxColumn_14.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_14.Name = "dataGridViewCheckBoxColumn2";
			this.dataGridViewCheckBoxColumn_14.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_14.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_14.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_14.Visible = false;
			this.dataGridViewTextBoxColumn_269.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_269.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_269.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_269.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn_269.ReadOnly = true;
			this.dataGridViewTextBoxColumn_269.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_269.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_269.Width = 5;
			this.dataGridViewTextBoxColumn_270.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_270.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_270.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn_270.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_270.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.tabPage_2.Controls.Add(this.splitContainer_4);
			this.tabPage_2.Location = new Point(4, 22);
			this.tabPage_2.Name = "tpEquipment";
			this.tabPage_2.Padding = new Padding(3);
			this.tabPage_2.Size = new Size(509, 473);
			this.tabPage_2.TabIndex = 2;
			this.tabPage_2.Text = "Оборудование";
			this.tabPage_2.UseVisualStyleBackColor = true;
			this.splitContainer_4.Dock = DockStyle.Fill;
			this.splitContainer_4.Location = new Point(3, 3);
			this.splitContainer_4.Name = "scSubstation1";
			this.splitContainer_4.Orientation = Orientation.Horizontal;
			this.splitContainer_4.Panel1.Controls.Add(this.tabControl_4);
			this.splitContainer_4.Panel2.Controls.Add(this.splitContainer_5);
			this.splitContainer_4.Size = new Size(503, 467);
			this.splitContainer_4.SplitterDistance = 170;
			this.splitContainer_4.TabIndex = 1;
			this.tabControl_4.Controls.Add(this.tabPage_16);
			this.tabControl_4.Controls.Add(this.tabPage_17);
			this.tabControl_4.Controls.Add(this.tabPage_20);
			this.tabControl_4.Dock = DockStyle.Fill;
			this.tabControl_4.Location = new Point(0, 0);
			this.tabControl_4.Name = "tcTransf";
			this.tabControl_4.SelectedIndex = 0;
			this.tabControl_4.Size = new Size(503, 170);
			this.tabControl_4.TabIndex = 11;
			this.tabControl_4.SelectedIndexChanged += this.tabControl_4_SelectedIndexChanged;
			this.tabPage_16.Controls.Add(this.bjlukJmkdL);
			this.tabPage_16.Location = new Point(4, 22);
			this.tabPage_16.Name = "tpTransf";
			this.tabPage_16.Padding = new Padding(3);
			this.tabPage_16.Size = new Size(495, 144);
			this.tabPage_16.TabIndex = 0;
			this.tabPage_16.Text = "Трансформаторы";
			this.tabPage_16.UseVisualStyleBackColor = true;
			this.bjlukJmkdL.ColumnCount = 1;
			this.bjlukJmkdL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.bjlukJmkdL.Controls.Add(this.toolStrip_6, 0, 0);
			this.bjlukJmkdL.Controls.Add(this.dgvTrans, 0, 1);
			this.bjlukJmkdL.Dock = DockStyle.Fill;
			this.bjlukJmkdL.Location = new Point(3, 3);
			this.bjlukJmkdL.Name = "tlpTrans";
			this.bjlukJmkdL.RowCount = 2;
			this.bjlukJmkdL.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
			this.bjlukJmkdL.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.bjlukJmkdL.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.bjlukJmkdL.Size = new Size(489, 138);
			this.bjlukJmkdL.TabIndex = 5;
			this.toolStrip_6.BackColor = Color.White;
			this.toolStrip_6.Items.AddRange(new ToolStripItem[]
			{
				this.sjguzMevbg,
				this.toolStripButton_19,
				this.toolStripButton_20,
				this.toolStripSeparator_5,
				this.toolStripButton_21,
				this.toolStripSeparator_6,
				this.toolStripButton_22,
				this.toolStripLabel_3,
				this.toolStripSeparator_70,
				this.toolStripButton_98
			});
			this.toolStrip_6.Location = new Point(0, 0);
			this.toolStrip_6.Name = "tsTrans";
			this.toolStrip_6.Size = new Size(489, 24);
			this.toolStrip_6.TabIndex = 8;
			this.toolStrip_6.Text = "Панель инструментов трансформатора";
			this.sjguzMevbg.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.sjguzMevbg.Image = (Image)componentResourceManager.GetObject("tsbTransAdd.Image");
			this.sjguzMevbg.ImageTransparentColor = Color.Transparent;
			this.sjguzMevbg.Name = "tsbTransAdd";
			this.sjguzMevbg.Size = new Size(23, 21);
			this.sjguzMevbg.Text = "Добавить паспорт";
			this.sjguzMevbg.Click += this.sjguzMevbg_Click;
			this.toolStripButton_19.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_19.Image = (Image)componentResourceManager.GetObject("tsbTransEdit.Image");
			this.toolStripButton_19.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_19.Name = "tsbTransEdit";
			this.toolStripButton_19.Size = new Size(23, 21);
			this.toolStripButton_19.Text = "Изменить паспорт";
			this.toolStripButton_19.Click += this.toolStripButton_19_Click;
			this.toolStripButton_20.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_20.Image = (Image)componentResourceManager.GetObject("tsbTransDelete.Image");
			this.toolStripButton_20.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_20.Name = "tsbTransDelete";
			this.toolStripButton_20.Size = new Size(23, 21);
			this.toolStripButton_20.Text = "Удалить паспорт";
			this.toolStripButton_20.Click += this.toolStripButton_20_Click;
			this.toolStripSeparator_5.Name = "tssTransHistory";
			this.toolStripSeparator_5.Size = new Size(6, 24);
			this.toolStripButton_21.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_21.Image = (Image)componentResourceManager.GetObject("tsbTransHistory.Image");
			this.toolStripButton_21.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_21.Name = "tsbTransHistory";
			this.toolStripButton_21.Size = new Size(23, 21);
			this.toolStripButton_21.Text = "История паспортов объекта";
			this.toolStripButton_21.Click += this.toolStripButton_21_Click;
			this.toolStripSeparator_6.Name = "tssTransRefresh";
			this.toolStripSeparator_6.Size = new Size(6, 24);
			this.toolStripButton_22.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_22.Image = (Image)componentResourceManager.GetObject("tsbTransRefresh.Image");
			this.toolStripButton_22.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_22.Name = "tsbTransRefresh";
			this.toolStripButton_22.Size = new Size(23, 21);
			this.toolStripButton_22.Text = "Обновление данных";
			this.toolStripButton_22.Click += this.toolStripButton_22_Click;
			this.toolStripLabel_3.Alignment = ToolStripItemAlignment.Right;
			this.toolStripLabel_3.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripLabel_3.Name = "tslTransText";
			this.toolStripLabel_3.Size = new Size(10, 21);
			this.toolStripLabel_3.Text = " ";
			this.toolStripSeparator_70.Name = "toolStripSeparator26";
			this.toolStripSeparator_70.Size = new Size(6, 24);
			this.toolStripButton_98.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_98.Image = Resources.smethod_54();
			this.toolStripButton_98.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_98.Name = "tsbTransfBindReference";
			this.toolStripButton_98.Size = new Size(23, 21);
			this.toolStripButton_98.Text = "Привязать справочник";
			this.toolStripButton_98.Click += this.toolStripButton_98_Click;
			this.dgvTrans.AllowUserToAddRows = false;
			this.dgvTrans.AllowUserToDeleteRows = false;
			this.dgvTrans.AllowUserToResizeRows = false;
			this.dgvTrans.BackgroundColor = Color.White;
			dataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle41.BackColor = SystemColors.Control;
			dataGridViewCellStyle41.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle41.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle41.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle41.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle41.WrapMode = DataGridViewTriState.True;
			this.dgvTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
			this.dgvTrans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTrans.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_128,
				this.dataGridViewTextBoxColumn_129,
				this.dataGridViewTextBoxColumn_130,
				this.dataGridViewTextBoxColumn_131
			});
			dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle42.BackColor = Color.White;
			dataGridViewCellStyle42.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle42.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle42.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle42.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle42.WrapMode = DataGridViewTriState.True;
			this.dgvTrans.DefaultCellStyle = dataGridViewCellStyle42;
			this.dgvTrans.Dock = DockStyle.Fill;
			this.dgvTrans.Location = new Point(3, 27);
			this.dgvTrans.MultiSelect = false;
			this.dgvTrans.Name = "dgvTrans";
			this.dgvTrans.ReadOnly = true;
			dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle43.BackColor = SystemColors.Control;
			dataGridViewCellStyle43.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle43.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle43.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle43.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle43.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle43.WrapMode = DataGridViewTriState.True;
			this.dgvTrans.RowHeadersDefaultCellStyle = dataGridViewCellStyle43;
			this.dgvTrans.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvTrans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dgvTrans.Size = new Size(483, 108);
			this.dgvTrans.TabIndex = 9;
			this.dgvTrans.CellDoubleClick += this.jbgCihdRyu;
			this.dataGridViewTextBoxColumn_128.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_128.HeaderText = "idTrans";
			this.dataGridViewTextBoxColumn_128.Name = "idDgvTrans";
			this.dataGridViewTextBoxColumn_128.ReadOnly = true;
			this.dataGridViewTextBoxColumn_128.Visible = false;
			this.dataGridViewTextBoxColumn_129.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_129.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_129.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_129.MinimumWidth = 100;
			this.dataGridViewTextBoxColumn_129.Name = "NameDgvTrans";
			this.dataGridViewTextBoxColumn_129.ReadOnly = true;
			this.dataGridViewTextBoxColumn_130.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_130.HeaderText = "idObjListTrans";
			this.dataGridViewTextBoxColumn_130.Name = "idObjListDgvTrans";
			this.dataGridViewTextBoxColumn_130.ReadOnly = true;
			this.dataGridViewTextBoxColumn_130.Visible = false;
			this.dataGridViewTextBoxColumn_131.DataPropertyName = "idEquipment";
			this.dataGridViewTextBoxColumn_131.HeaderText = "idEquipment";
			this.dataGridViewTextBoxColumn_131.Name = "idEquipmentDgvTrans";
			this.dataGridViewTextBoxColumn_131.ReadOnly = true;
			this.dataGridViewTextBoxColumn_131.Visible = false;
			this.tabPage_17.Controls.Add(this.tableLayoutPanel_17);
			this.tabPage_17.Location = new Point(4, 22);
			this.tabPage_17.Name = "tpTransfVoltage";
			this.tabPage_17.Padding = new Padding(3);
			this.tabPage_17.Size = new Size(495, 144);
			this.tabPage_17.TabIndex = 1;
			this.tabPage_17.Text = "Трансформаторы напряжения";
			this.tabPage_17.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_17.ColumnCount = 1;
			this.tableLayoutPanel_17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_17.Controls.Add(this.toolStrip_22, 0, 0);
			this.tableLayoutPanel_17.Controls.Add(this.dgvTransV, 0, 1);
			this.tableLayoutPanel_17.Dock = DockStyle.Fill;
			this.tableLayoutPanel_17.Location = new Point(3, 3);
			this.tableLayoutPanel_17.Name = "tlpTransfVoltage";
			this.tableLayoutPanel_17.RowCount = 2;
			this.tableLayoutPanel_17.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
			this.tableLayoutPanel_17.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_17.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_17.Size = new Size(489, 138);
			this.tableLayoutPanel_17.TabIndex = 6;
			this.toolStrip_22.BackColor = Color.White;
			this.toolStrip_22.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_93,
				this.toolStripButton_94,
				this.toolStripButton_95,
				this.toolStripSeparator_68,
				this.toolStripButton_96,
				this.toolStripSeparator_69,
				this.toolStripButton_97,
				this.toolStripLabel_6
			});
			this.toolStrip_22.Location = new Point(0, 0);
			this.toolStrip_22.Name = "tsTransfVoltage";
			this.toolStrip_22.Size = new Size(489, 24);
			this.toolStrip_22.TabIndex = 8;
			this.toolStrip_22.Text = "Панель инструментов трансформатора";
			this.toolStripButton_93.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_93.Image = (Image)componentResourceManager.GetObject("tlpTransfVoltageAdd.Image");
			this.toolStripButton_93.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_93.Name = "tlpTransfVoltageAdd";
			this.toolStripButton_93.Size = new Size(23, 21);
			this.toolStripButton_93.Text = "Добавить паспорт";
			this.toolStripButton_93.Click += this.toolStripButton_93_Click;
			this.toolStripButton_94.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_94.Image = (Image)componentResourceManager.GetObject("tlpTransfVoltageEdit.Image");
			this.toolStripButton_94.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_94.Name = "tlpTransfVoltageEdit";
			this.toolStripButton_94.Size = new Size(23, 21);
			this.toolStripButton_94.Text = "Изменить паспорт";
			this.toolStripButton_94.Click += this.toolStripButton_94_Click;
			this.toolStripButton_95.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_95.Image = (Image)componentResourceManager.GetObject("tlpTransfVoltageDelete.Image");
			this.toolStripButton_95.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_95.Name = "tlpTransfVoltageDelete";
			this.toolStripButton_95.Size = new Size(23, 21);
			this.toolStripButton_95.Text = "Удалить паспорт";
			this.toolStripButton_95.Click += this.toolStripButton_95_Click;
			this.toolStripSeparator_68.Name = "toolStripSeparator24";
			this.toolStripSeparator_68.Size = new Size(6, 24);
			this.toolStripButton_96.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_96.Image = (Image)componentResourceManager.GetObject("tlpTransfVoltageHistory.Image");
			this.toolStripButton_96.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_96.Name = "tlpTransfVoltageHistory";
			this.toolStripButton_96.Size = new Size(23, 21);
			this.toolStripButton_96.Text = "История паспортов объекта";
			this.toolStripButton_96.Click += this.toolStripButton_96_Click;
			this.toolStripSeparator_69.Name = "toolStripSeparator25";
			this.toolStripSeparator_69.Size = new Size(6, 24);
			this.toolStripButton_97.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_97.Image = (Image)componentResourceManager.GetObject("tlpTransfVoltageRefresh.Image");
			this.toolStripButton_97.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_97.Name = "tlpTransfVoltageRefresh";
			this.toolStripButton_97.Size = new Size(23, 21);
			this.toolStripButton_97.Text = "Обновление данных";
			this.toolStripButton_97.Click += this.toolStripButton_97_Click;
			this.toolStripLabel_6.Alignment = ToolStripItemAlignment.Right;
			this.toolStripLabel_6.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripLabel_6.Name = "toolStripLabel3";
			this.toolStripLabel_6.Size = new Size(10, 21);
			this.toolStripLabel_6.Text = " ";
			this.dgvTransV.AllowUserToAddRows = false;
			this.dgvTransV.AllowUserToDeleteRows = false;
			this.dgvTransV.AllowUserToResizeRows = false;
			this.dgvTransV.BackgroundColor = Color.White;
			dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle44.BackColor = SystemColors.Control;
			dataGridViewCellStyle44.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle44.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle44.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle44.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle44.WrapMode = DataGridViewTriState.True;
			this.dgvTransV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle44;
			this.dgvTransV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTransV.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_120,
				this.dataGridViewTextBoxColumn_121,
				this.dataGridViewTextBoxColumn_122,
				this.dataGridViewTextBoxColumn_123
			});
			dataGridViewCellStyle45.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle45.BackColor = Color.White;
			dataGridViewCellStyle45.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle45.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle45.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle45.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle45.WrapMode = DataGridViewTriState.True;
			this.dgvTransV.DefaultCellStyle = dataGridViewCellStyle45;
			this.dgvTransV.Dock = DockStyle.Fill;
			this.dgvTransV.Location = new Point(3, 27);
			this.dgvTransV.MultiSelect = false;
			this.dgvTransV.Name = "dgvTransV";
			this.dgvTransV.ReadOnly = true;
			dataGridViewCellStyle46.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle46.BackColor = SystemColors.Control;
			dataGridViewCellStyle46.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle46.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle46.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle46.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle46.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle46.WrapMode = DataGridViewTriState.True;
			this.dgvTransV.RowHeadersDefaultCellStyle = dataGridViewCellStyle46;
			this.dgvTransV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvTransV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dgvTransV.Size = new Size(483, 108);
			this.dgvTransV.TabIndex = 9;
			this.dgvTransV.CellDoubleClick += this.dgvTransV_CellDoubleClick;
			this.dataGridViewTextBoxColumn_120.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_120.HeaderText = "idTrans";
			this.dataGridViewTextBoxColumn_120.Name = "idDgvTransV";
			this.dataGridViewTextBoxColumn_120.ReadOnly = true;
			this.dataGridViewTextBoxColumn_120.Visible = false;
			this.dataGridViewTextBoxColumn_121.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_121.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_121.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_121.MinimumWidth = 100;
			this.dataGridViewTextBoxColumn_121.Name = "nameDgvTransV";
			this.dataGridViewTextBoxColumn_121.ReadOnly = true;
			this.dataGridViewTextBoxColumn_122.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_122.HeaderText = "idObjListTrans";
			this.dataGridViewTextBoxColumn_122.Name = "idObjListDgvTransV";
			this.dataGridViewTextBoxColumn_122.ReadOnly = true;
			this.dataGridViewTextBoxColumn_122.Visible = false;
			this.dataGridViewTextBoxColumn_123.DataPropertyName = "IdEquipment";
			this.dataGridViewTextBoxColumn_123.HeaderText = "IdEquipment";
			this.dataGridViewTextBoxColumn_123.Name = "IdEquipmentDgvTransV";
			this.dataGridViewTextBoxColumn_123.ReadOnly = true;
			this.dataGridViewTextBoxColumn_123.Visible = false;
			this.tabPage_20.Controls.Add(this.tableLayoutPanel_18);
			this.tabPage_20.Location = new Point(4, 22);
			this.tabPage_20.Name = "tpTransfAmperage";
			this.tabPage_20.Padding = new Padding(3);
			this.tabPage_20.Size = new Size(495, 144);
			this.tabPage_20.TabIndex = 2;
			this.tabPage_20.Text = "Трансформаторы тока";
			this.tabPage_20.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_18.ColumnCount = 1;
			this.tableLayoutPanel_18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_18.Controls.Add(this.toolStrip_26, 0, 0);
			this.tableLayoutPanel_18.Controls.Add(this.dgvTransI, 0, 1);
			this.tableLayoutPanel_18.Dock = DockStyle.Fill;
			this.tableLayoutPanel_18.Location = new Point(3, 3);
			this.tableLayoutPanel_18.Name = "tlpTransfAmperage";
			this.tableLayoutPanel_18.RowCount = 2;
			this.tableLayoutPanel_18.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
			this.tableLayoutPanel_18.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_18.Size = new Size(489, 138);
			this.tableLayoutPanel_18.TabIndex = 0;
			this.toolStrip_26.BackColor = Color.White;
			this.toolStrip_26.Dock = DockStyle.Fill;
			this.toolStrip_26.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_114,
				this.toolStripButton_115,
				this.toolStripButton_116,
				this.toolStripSeparator_81,
				this.toolStripButton_117,
				this.toolStripSeparator_82,
				this.toolStripButton_118
			});
			this.toolStrip_26.Location = new Point(0, 0);
			this.toolStrip_26.Name = "tsTransfAmperage";
			this.toolStrip_26.Size = new Size(489, 24);
			this.toolStrip_26.TabIndex = 1;
			this.toolStrip_26.Text = "Панель инструментов трансформаторов тока";
			this.toolStripButton_114.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_114.Image = Resources.smethod_24();
			this.toolStripButton_114.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_114.Name = "tsbTransIAdd";
			this.toolStripButton_114.Size = new Size(23, 21);
			this.toolStripButton_114.Text = "Добавить паспорт ТТ";
			this.toolStripButton_114.Click += this.toolStripButton_114_Click;
			this.toolStripButton_115.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_115.Image = Resources.smethod_26();
			this.toolStripButton_115.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_115.Name = "tsbTransIEdit";
			this.toolStripButton_115.Size = new Size(23, 21);
			this.toolStripButton_115.Text = "Редактировать паспорт ТТ";
			this.toolStripButton_115.Click += this.toolStripButton_115_Click;
			this.toolStripButton_116.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_116.Image = Resources.smethod_25();
			this.toolStripButton_116.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_116.Name = "tsbTransIDel";
			this.toolStripButton_116.Size = new Size(23, 21);
			this.toolStripButton_116.Text = "Удалить паспорт ТТ";
			this.toolStripButton_116.Click += this.toolStripButton_116_Click;
			this.toolStripSeparator_81.Name = "toolStripSeparator34";
			this.toolStripSeparator_81.Size = new Size(6, 24);
			this.toolStripButton_117.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_117.Image = Resources.smethod_36();
			this.toolStripButton_117.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_117.Name = "tsbTransIHistory";
			this.toolStripButton_117.Size = new Size(23, 21);
			this.toolStripButton_117.Text = "История паспортов ТТ";
			this.toolStripButton_117.Click += this.toolStripButton_117_Click;
			this.toolStripSeparator_82.Name = "toolStripSeparator35";
			this.toolStripSeparator_82.Size = new Size(6, 24);
			this.toolStripButton_118.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_118.Image = Resources.smethod_45();
			this.toolStripButton_118.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_118.Name = "tsbTransIRefresh";
			this.toolStripButton_118.Size = new Size(23, 21);
			this.toolStripButton_118.Text = "Обновить список ТТ";
			this.toolStripButton_118.Click += this.toolStripButton_118_Click;
			this.dgvTransI.AllowUserToAddRows = false;
			this.dgvTransI.AllowUserToDeleteRows = false;
			this.dgvTransI.AllowUserToResizeRows = false;
			this.dgvTransI.BackgroundColor = Color.White;
			this.dgvTransI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTransI.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_124,
				this.dataGridViewTextBoxColumn_125,
				this.dataGridViewTextBoxColumn_126,
				this.dataGridViewTextBoxColumn_127
			});
			dataGridViewCellStyle47.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle47.BackColor = SystemColors.Window;
			dataGridViewCellStyle47.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle47.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle47.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle47.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle47.WrapMode = DataGridViewTriState.True;
			this.dgvTransI.DefaultCellStyle = dataGridViewCellStyle47;
			this.dgvTransI.Dock = DockStyle.Fill;
			this.dgvTransI.Location = new Point(3, 27);
			this.dgvTransI.MultiSelect = false;
			this.dgvTransI.Name = "dgvTransI";
			this.dgvTransI.ReadOnly = true;
			dataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle48.BackColor = SystemColors.Control;
			dataGridViewCellStyle48.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle48.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle48.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle48.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle48.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle48.WrapMode = DataGridViewTriState.True;
			this.dgvTransI.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
			this.dgvTransI.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvTransI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dgvTransI.Size = new Size(483, 108);
			this.dgvTransI.TabIndex = 0;
			this.dgvTransI.CellDoubleClick += this.dgvTransI_CellDoubleClick;
			this.dataGridViewTextBoxColumn_124.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_124.HeaderText = "idTrans";
			this.dataGridViewTextBoxColumn_124.Name = "idDgvTransI";
			this.dataGridViewTextBoxColumn_124.ReadOnly = true;
			this.dataGridViewTextBoxColumn_124.Visible = false;
			this.dataGridViewTextBoxColumn_125.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_125.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_125.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_125.MinimumWidth = 80;
			this.dataGridViewTextBoxColumn_125.Name = "NameDgvTransI";
			this.dataGridViewTextBoxColumn_125.ReadOnly = true;
			this.dataGridViewTextBoxColumn_126.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_126.HeaderText = "idObjListTransI";
			this.dataGridViewTextBoxColumn_126.Name = "idObjListDgvTransI";
			this.dataGridViewTextBoxColumn_126.ReadOnly = true;
			this.dataGridViewTextBoxColumn_126.Visible = false;
			this.dataGridViewTextBoxColumn_127.DataPropertyName = "IdEquipment";
			this.dataGridViewTextBoxColumn_127.HeaderText = "idEquipment";
			this.dataGridViewTextBoxColumn_127.Name = "idEquipmentDgvTransI";
			this.dataGridViewTextBoxColumn_127.ReadOnly = true;
			this.dataGridViewTextBoxColumn_127.Visible = false;
			this.splitContainer_5.Dock = DockStyle.Fill;
			this.splitContainer_5.Location = new Point(0, 0);
			this.splitContainer_5.Name = "scSubstation2";
			this.splitContainer_5.Orientation = Orientation.Horizontal;
			this.splitContainer_5.Panel1.Controls.Add(this.dgvSwitchgears);
			this.splitContainer_5.Panel1.Controls.Add(this.toolStrip_5);
			this.splitContainer_5.Panel2.Controls.Add(this.tabControl_1);
			this.splitContainer_5.Size = new Size(503, 293);
			this.splitContainer_5.SplitterDistance = 100;
			this.splitContainer_5.TabIndex = 0;
			this.dgvSwitchgears.AllowUserToAddRows = false;
			this.dgvSwitchgears.AllowUserToDeleteRows = false;
			this.dgvSwitchgears.AllowUserToResizeRows = false;
			this.dgvSwitchgears.BackgroundColor = Color.White;
			dataGridViewCellStyle49.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle49.BackColor = SystemColors.Control;
			dataGridViewCellStyle49.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle49.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle49.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle49.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle49.WrapMode = DataGridViewTriState.True;
			this.dgvSwitchgears.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
			this.dgvSwitchgears.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSwitchgears.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_132,
				this.iyFdnnqUdb,
				this.dataGridViewTextBoxColumn_133,
				this.dataGridViewTextBoxColumn_134
			});
			dataGridViewCellStyle50.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle50.BackColor = Color.White;
			dataGridViewCellStyle50.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle50.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle50.SelectionBackColor = Color.White;
			dataGridViewCellStyle50.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle50.WrapMode = DataGridViewTriState.True;
			this.dgvSwitchgears.DefaultCellStyle = dataGridViewCellStyle50;
			this.dgvSwitchgears.Dock = DockStyle.Fill;
			this.dgvSwitchgears.Location = new Point(0, 25);
			this.dgvSwitchgears.MultiSelect = false;
			this.dgvSwitchgears.Name = "dgvSwitchgears";
			this.dgvSwitchgears.ReadOnly = true;
			dataGridViewCellStyle51.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle51.BackColor = SystemColors.Control;
			dataGridViewCellStyle51.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle51.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle51.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle51.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle51.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle51.WrapMode = DataGridViewTriState.True;
			this.dgvSwitchgears.RowHeadersDefaultCellStyle = dataGridViewCellStyle51;
			this.dgvSwitchgears.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvSwitchgears.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dgvSwitchgears.Size = new Size(503, 75);
			this.dgvSwitchgears.TabIndex = 9;
			this.dgvSwitchgears.CellDoubleClick += this.dgvSwitchgears_CellDoubleClick;
			this.dgvSwitchgears.SelectionChanged += this.OmaFmRnUue;
			this.dataGridViewTextBoxColumn_132.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_132.HeaderText = "idSwitchgear";
			this.dataGridViewTextBoxColumn_132.Name = "idDgvSwitchGear";
			this.dataGridViewTextBoxColumn_132.ReadOnly = true;
			this.dataGridViewTextBoxColumn_132.Visible = false;
			this.iyFdnnqUdb.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.iyFdnnqUdb.DataPropertyName = "Name";
			this.iyFdnnqUdb.HeaderText = "Наименование";
			this.iyFdnnqUdb.Name = "NameDgvSwitchGear";
			this.iyFdnnqUdb.ReadOnly = true;
			this.dataGridViewTextBoxColumn_133.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_133.HeaderText = "idObjListSwitchgear";
			this.dataGridViewTextBoxColumn_133.Name = "idObjListDgvSwitchGear";
			this.dataGridViewTextBoxColumn_133.ReadOnly = true;
			this.dataGridViewTextBoxColumn_133.Visible = false;
			this.dataGridViewTextBoxColumn_134.DataPropertyName = "IdEquipment";
			this.dataGridViewTextBoxColumn_134.HeaderText = "IdEquipment";
			this.dataGridViewTextBoxColumn_134.Name = "IdEquipmentDgvSwitchGear";
			this.dataGridViewTextBoxColumn_134.ReadOnly = true;
			this.dataGridViewTextBoxColumn_134.Visible = false;
			this.toolStrip_5.BackColor = Color.White;
			this.toolStrip_5.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_14,
				this.toolStripButton_15,
				this.toolStripButton_16,
				this.bJkuSvjuUb,
				this.toolStripButton_17,
				this.toolStripSeparator_4,
				this.toolStripButton_18,
				this.toolStripLabel_2
			});
			this.toolStrip_5.Location = new Point(0, 0);
			this.toolStrip_5.Name = "tsSwitchgears";
			this.toolStrip_5.Size = new Size(503, 25);
			this.toolStrip_5.TabIndex = 8;
			this.toolStrip_5.Text = "toolStrip1";
			this.toolStripButton_14.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_14.Image = (Image)componentResourceManager.GetObject("tsbSwitchgearsAdd.Image");
			this.toolStripButton_14.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_14.Name = "tsbSwitchgearsAdd";
			this.toolStripButton_14.Size = new Size(23, 22);
			this.toolStripButton_14.Text = "Добавить паспорт РУ";
			this.toolStripButton_14.Click += this.toolStripButton_14_Click;
			this.toolStripButton_15.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_15.Image = (Image)componentResourceManager.GetObject("tsbSwitchgearsEdit.Image");
			this.toolStripButton_15.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_15.Name = "tsbSwitchgearsEdit";
			this.toolStripButton_15.Size = new Size(23, 22);
			this.toolStripButton_15.Text = "Изменить паспорт РУ";
			this.toolStripButton_15.Click += this.toolStripButton_15_Click;
			this.toolStripButton_16.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_16.Image = (Image)componentResourceManager.GetObject("tsbSwitchgearsDelete.Image");
			this.toolStripButton_16.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_16.Name = "tsbSwitchgearsDelete";
			this.toolStripButton_16.Size = new Size(23, 22);
			this.toolStripButton_16.Text = "Удалить паспорт РУ";
			this.toolStripButton_16.Click += this.toolStripButton_16_Click;
			this.bJkuSvjuUb.Name = "tssSwitchgearsHistory";
			this.bJkuSvjuUb.Size = new Size(6, 25);
			this.toolStripButton_17.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_17.Image = (Image)componentResourceManager.GetObject("tsbSwitchgearsHistory.Image");
			this.toolStripButton_17.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_17.Name = "tsbSwitchgearsHistory";
			this.toolStripButton_17.Size = new Size(23, 22);
			this.toolStripButton_17.Text = "История паспортов объекта";
			this.toolStripButton_17.Click += this.toolStripButton_17_Click;
			this.toolStripSeparator_4.Name = "tssSwitchgearsRefresh";
			this.toolStripSeparator_4.Size = new Size(6, 25);
			this.toolStripButton_18.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_18.Image = (Image)componentResourceManager.GetObject("tsbSwitchgearsRefresh.Image");
			this.toolStripButton_18.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_18.Name = "tsbSwitchgearsRefresh";
			this.toolStripButton_18.Size = new Size(23, 22);
			this.toolStripButton_18.Text = "Обновление данных";
			this.toolStripButton_18.Click += this.toolStripButton_18_Click;
			this.toolStripLabel_2.Alignment = ToolStripItemAlignment.Right;
			this.toolStripLabel_2.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripLabel_2.Name = "tslSwitchgearsText";
			this.toolStripLabel_2.Size = new Size(10, 22);
			this.toolStripLabel_2.Text = " ";
			this.tabControl_1.Controls.Add(this.tabPage_3);
			this.tabControl_1.Controls.Add(this.tabPage_4);
			this.tabControl_1.Controls.Add(this.tabPage_5);
			this.tabControl_1.Controls.Add(this.tabPage_22);
			this.tabControl_1.Dock = DockStyle.Fill;
			this.tabControl_1.Location = new Point(0, 0);
			this.tabControl_1.Name = "tcSwitchgearEquipments";
			this.tabControl_1.SelectedIndex = 0;
			this.tabControl_1.Size = new Size(503, 189);
			this.tabControl_1.TabIndex = 7;
			this.tabControl_1.SelectedIndexChanged += this.tabControl_1_SelectedIndexChanged;
			this.tabPage_3.Controls.Add(this.tableLayoutPanel_3);
			this.tabPage_3.Location = new Point(4, 22);
			this.tabPage_3.Name = "tpBuses";
			this.tabPage_3.Padding = new Padding(3);
			this.tabPage_3.Size = new Size(495, 163);
			this.tabPage_3.TabIndex = 0;
			this.tabPage_3.Text = "Шины";
			this.tabPage_3.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_3.ColumnCount = 1;
			this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_3.Controls.Add(this.toolStrip_3, 0, 0);
			this.tableLayoutPanel_3.Controls.Add(this.dgvBuses, 0, 1);
			this.tableLayoutPanel_3.Dock = DockStyle.Fill;
			this.tableLayoutPanel_3.Location = new Point(3, 3);
			this.tableLayoutPanel_3.Name = "tlpBuses";
			this.tableLayoutPanel_3.RowCount = 2;
			this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
			this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_3.Size = new Size(489, 157);
			this.tableLayoutPanel_3.TabIndex = 4;
			this.toolStrip_3.BackColor = Color.White;
			this.toolStrip_3.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_5,
				this.toolStripButton_6,
				this.toolStripButton_7,
				this.toolStripSeparator_0,
				this.toolStripButton_8,
				this.toolStripSeparator_1,
				this.toolStripButton_9,
				this.toolStripLabel_0
			});
			this.toolStrip_3.Location = new Point(0, 0);
			this.toolStrip_3.Name = "tsBuses";
			this.toolStrip_3.Size = new Size(489, 24);
			this.toolStrip_3.TabIndex = 8;
			this.toolStrip_3.Text = "Панель инструментов шин";
			this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_5.Image = (Image)componentResourceManager.GetObject("tsbBusesAdd.Image");
			this.toolStripButton_5.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_5.Name = "tsbBusesAdd";
			this.toolStripButton_5.Size = new Size(23, 21);
			this.toolStripButton_5.Text = "Добавить паспорт";
			this.toolStripButton_5.Click += this.toolStripButton_5_Click;
			this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_6.Image = (Image)componentResourceManager.GetObject("tsbBusesEdit.Image");
			this.toolStripButton_6.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_6.Name = "tsbBusesEdit";
			this.toolStripButton_6.Size = new Size(23, 21);
			this.toolStripButton_6.Text = "Изменить паспорт";
			this.toolStripButton_6.Click += this.toolStripButton_6_Click;
			this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_7.Image = (Image)componentResourceManager.GetObject("tsbBusesDelete.Image");
			this.toolStripButton_7.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_7.Name = "tsbBusesDelete";
			this.toolStripButton_7.Size = new Size(23, 21);
			this.toolStripButton_7.Text = "Удалить паспорт";
			this.toolStripButton_7.Click += this.toolStripButton_7_Click;
			this.toolStripSeparator_0.Name = "tssBusesHistory";
			this.toolStripSeparator_0.Size = new Size(6, 24);
			this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_8.Image = (Image)componentResourceManager.GetObject("tsbBusesHistory.Image");
			this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_8.Name = "tsbBusesHistory";
			this.toolStripButton_8.Size = new Size(23, 21);
			this.toolStripButton_8.Text = "История паспортов объекта";
			this.toolStripButton_8.Click += this.toolStripButton_8_Click;
			this.toolStripSeparator_1.Name = "tssBusesRefresh";
			this.toolStripSeparator_1.Size = new Size(6, 24);
			this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_9.Image = (Image)componentResourceManager.GetObject("tsbBusesRefresh.Image");
			this.toolStripButton_9.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_9.Name = "tsbBusesRefresh";
			this.toolStripButton_9.Size = new Size(23, 21);
			this.toolStripButton_9.Text = "Обновление данных";
			this.toolStripButton_9.Click += this.toolStripButton_9_Click;
			this.toolStripLabel_0.Alignment = ToolStripItemAlignment.Right;
			this.toolStripLabel_0.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripLabel_0.Name = "tslBasesText";
			this.toolStripLabel_0.Size = new Size(10, 21);
			this.toolStripLabel_0.Text = " ";
			this.dgvBuses.AllowUserToAddRows = false;
			this.dgvBuses.AllowUserToDeleteRows = false;
			this.dgvBuses.AllowUserToResizeRows = false;
			this.dgvBuses.BackgroundColor = Color.White;
			dataGridViewCellStyle52.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle52.BackColor = SystemColors.Control;
			dataGridViewCellStyle52.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle52.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle52.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle52.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle52.WrapMode = DataGridViewTriState.True;
			this.dgvBuses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle52;
			this.dgvBuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBuses.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_135,
				this.dataGridViewTextBoxColumn_136,
				this.dataGridViewTextBoxColumn_137,
				this.dataGridViewTextBoxColumn_138
			});
			dataGridViewCellStyle53.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle53.BackColor = Color.White;
			dataGridViewCellStyle53.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle53.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle53.SelectionBackColor = Color.White;
			dataGridViewCellStyle53.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle53.WrapMode = DataGridViewTriState.False;
			this.dgvBuses.DefaultCellStyle = dataGridViewCellStyle53;
			this.dgvBuses.Dock = DockStyle.Fill;
			this.dgvBuses.Location = new Point(3, 27);
			this.dgvBuses.MultiSelect = false;
			this.dgvBuses.Name = "dgvBuses";
			this.dgvBuses.ReadOnly = true;
			dataGridViewCellStyle54.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle54.BackColor = SystemColors.Control;
			dataGridViewCellStyle54.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle54.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle54.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle54.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle54.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle54.WrapMode = DataGridViewTriState.True;
			this.dgvBuses.RowHeadersDefaultCellStyle = dataGridViewCellStyle54;
			this.dgvBuses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvBuses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dgvBuses.Size = new Size(483, 127);
			this.dgvBuses.TabIndex = 9;
			this.dgvBuses.CellDoubleClick += this.dgvBuses_CellDoubleClick;
			this.dataGridViewTextBoxColumn_135.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_135.HeaderText = "idBuses";
			this.dataGridViewTextBoxColumn_135.Name = "idDgvBuses";
			this.dataGridViewTextBoxColumn_135.ReadOnly = true;
			this.dataGridViewTextBoxColumn_135.Visible = false;
			this.dataGridViewTextBoxColumn_136.DataPropertyName = "IdEquipment";
			this.dataGridViewTextBoxColumn_136.HeaderText = "IdEquipment";
			this.dataGridViewTextBoxColumn_136.Name = "IdEquipmentDgvBuses";
			this.dataGridViewTextBoxColumn_136.ReadOnly = true;
			this.dataGridViewTextBoxColumn_136.Visible = false;
			this.dataGridViewTextBoxColumn_137.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_137.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_137.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_137.Name = "NameDgvBuses";
			this.dataGridViewTextBoxColumn_137.ReadOnly = true;
			this.dataGridViewTextBoxColumn_138.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_138.HeaderText = "idObjListBuses";
			this.dataGridViewTextBoxColumn_138.Name = "idObjListDgvBuses";
			this.dataGridViewTextBoxColumn_138.ReadOnly = true;
			this.dataGridViewTextBoxColumn_138.Visible = false;
			this.tabPage_4.Controls.Add(this.JeSuDrbQyn);
			this.tabPage_4.Location = new Point(4, 22);
			this.tabPage_4.Name = "tpCells";
			this.tabPage_4.Padding = new Padding(3);
			this.tabPage_4.Size = new Size(495, 163);
			this.tabPage_4.TabIndex = 1;
			this.tabPage_4.Text = "Ячейки";
			this.tabPage_4.UseVisualStyleBackColor = true;
			this.JeSuDrbQyn.ColumnCount = 1;
			this.JeSuDrbQyn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.JeSuDrbQyn.Controls.Add(this.toolStrip_4, 0, 0);
			this.JeSuDrbQyn.Controls.Add(this.dgvCells, 0, 1);
			this.JeSuDrbQyn.Dock = DockStyle.Fill;
			this.JeSuDrbQyn.Location = new Point(3, 3);
			this.JeSuDrbQyn.Name = "tlpCells";
			this.JeSuDrbQyn.RowCount = 2;
			this.JeSuDrbQyn.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
			this.JeSuDrbQyn.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.JeSuDrbQyn.Size = new Size(489, 157);
			this.JeSuDrbQyn.TabIndex = 4;
			this.toolStrip_4.BackColor = Color.White;
			this.toolStrip_4.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_10,
				this.toolStripButton_11,
				this.toolStripButton_12,
				this.toolStripSeparator_2,
				this.toolStripButton_13,
				this.toolStripSeparator_3,
				this.Arvudbkpvh,
				this.toolStripLabel_1
			});
			this.toolStrip_4.Location = new Point(0, 0);
			this.toolStrip_4.Name = "tsCells";
			this.toolStrip_4.Size = new Size(489, 24);
			this.toolStrip_4.TabIndex = 8;
			this.toolStrip_4.Text = "Панель инструментов ячеек";
			this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_10.Image = (Image)componentResourceManager.GetObject("tsbCellsAdd.Image");
			this.toolStripButton_10.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_10.Name = "tsbCellsAdd";
			this.toolStripButton_10.Size = new Size(23, 21);
			this.toolStripButton_10.Text = "Добавить паспорт";
			this.toolStripButton_10.Click += this.toolStripButton_10_Click;
			this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_11.Image = (Image)componentResourceManager.GetObject("tsbCellsEdit.Image");
			this.toolStripButton_11.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_11.Name = "tsbCellsEdit";
			this.toolStripButton_11.Size = new Size(23, 21);
			this.toolStripButton_11.Text = "Изменить паспорт";
			this.toolStripButton_11.Click += this.toolStripButton_11_Click;
			this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_12.Image = (Image)componentResourceManager.GetObject("tsbCellsDelete.Image");
			this.toolStripButton_12.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_12.Name = "tsbCellsDelete";
			this.toolStripButton_12.Size = new Size(23, 21);
			this.toolStripButton_12.Text = "Удалить паспорт";
			this.toolStripButton_12.Click += this.toolStripButton_12_Click;
			this.toolStripSeparator_2.Name = "tssCellsHistory";
			this.toolStripSeparator_2.Size = new Size(6, 24);
			this.toolStripButton_13.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_13.Image = (Image)componentResourceManager.GetObject("tsbCellsHistory.Image");
			this.toolStripButton_13.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_13.Name = "tsbCellsHistory";
			this.toolStripButton_13.Size = new Size(23, 21);
			this.toolStripButton_13.Text = "История паспортов объекта";
			this.toolStripButton_13.Click += this.toolStripButton_13_Click;
			this.toolStripSeparator_3.Name = "tssCellsRefresh";
			this.toolStripSeparator_3.Size = new Size(6, 24);
			this.Arvudbkpvh.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.Arvudbkpvh.Image = (Image)componentResourceManager.GetObject("tsbCellsRefresh.Image");
			this.Arvudbkpvh.ImageTransparentColor = Color.Transparent;
			this.Arvudbkpvh.Name = "tsbCellsRefresh";
			this.Arvudbkpvh.Size = new Size(23, 21);
			this.Arvudbkpvh.Text = "Обновление данных";
			this.Arvudbkpvh.Click += this.Arvudbkpvh_Click;
			this.toolStripLabel_1.Alignment = ToolStripItemAlignment.Right;
			this.toolStripLabel_1.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripLabel_1.Name = "toolStripLabel1";
			this.toolStripLabel_1.Size = new Size(10, 21);
			this.toolStripLabel_1.Text = " ";
			this.dgvCells.AllowUserToAddRows = false;
			this.dgvCells.AllowUserToDeleteRows = false;
			this.dgvCells.AllowUserToResizeRows = false;
			this.dgvCells.BackgroundColor = Color.White;
			dataGridViewCellStyle55.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle55.BackColor = SystemColors.Control;
			dataGridViewCellStyle55.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle55.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle55.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle55.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle55.WrapMode = DataGridViewTriState.True;
			this.dgvCells.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle55;
			this.dgvCells.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCells.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_139,
				this.dataGridViewTextBoxColumn_140,
				this.dataGridViewTextBoxColumn_141,
				this.dataGridViewTextBoxColumn_142
			});
			dataGridViewCellStyle56.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle56.BackColor = Color.White;
			dataGridViewCellStyle56.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle56.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle56.SelectionBackColor = Color.White;
			dataGridViewCellStyle56.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle56.WrapMode = DataGridViewTriState.False;
			this.dgvCells.DefaultCellStyle = dataGridViewCellStyle56;
			this.dgvCells.Dock = DockStyle.Fill;
			this.dgvCells.Location = new Point(3, 27);
			this.dgvCells.MultiSelect = false;
			this.dgvCells.Name = "dgvCells";
			this.dgvCells.ReadOnly = true;
			dataGridViewCellStyle57.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle57.BackColor = SystemColors.Control;
			dataGridViewCellStyle57.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle57.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle57.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle57.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle57.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle57.WrapMode = DataGridViewTriState.True;
			this.dgvCells.RowHeadersDefaultCellStyle = dataGridViewCellStyle57;
			this.dgvCells.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvCells.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dgvCells.Size = new Size(483, 127);
			this.dgvCells.TabIndex = 9;
			this.dgvCells.CellDoubleClick += this.dgvCells_CellDoubleClick;
			this.dataGridViewTextBoxColumn_139.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_139.HeaderText = "idCells";
			this.dataGridViewTextBoxColumn_139.Name = "idDgvCells";
			this.dataGridViewTextBoxColumn_139.ReadOnly = true;
			this.dataGridViewTextBoxColumn_139.Visible = false;
			this.dataGridViewTextBoxColumn_140.DataPropertyName = "IdEquipment";
			this.dataGridViewTextBoxColumn_140.HeaderText = "IdEquipment";
			this.dataGridViewTextBoxColumn_140.Name = "IdEquipmentDgvCells";
			this.dataGridViewTextBoxColumn_140.ReadOnly = true;
			this.dataGridViewTextBoxColumn_140.Visible = false;
			this.dataGridViewTextBoxColumn_141.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_141.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_141.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_141.Name = "NameDgvCells";
			this.dataGridViewTextBoxColumn_141.ReadOnly = true;
			this.dataGridViewTextBoxColumn_142.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_142.HeaderText = "idObjListCells";
			this.dataGridViewTextBoxColumn_142.Name = "idObjListDgvCells";
			this.dataGridViewTextBoxColumn_142.ReadOnly = true;
			this.dataGridViewTextBoxColumn_142.Visible = false;
			this.tabPage_5.Controls.Add(this.tableLayoutPanel_4);
			this.tabPage_5.Location = new Point(4, 22);
			this.tabPage_5.Name = "tpSwitch";
			this.tabPage_5.Padding = new Padding(3);
			this.tabPage_5.Size = new Size(495, 163);
			this.tabPage_5.TabIndex = 2;
			this.tabPage_5.Text = "Коммутационные устройства";
			this.tabPage_5.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_4.ColumnCount = 1;
			this.tableLayoutPanel_4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_4.Controls.Add(this.toolStrip_7, 0, 0);
			this.tableLayoutPanel_4.Controls.Add(this.dgvSwitches, 0, 1);
			this.tableLayoutPanel_4.Dock = DockStyle.Fill;
			this.tableLayoutPanel_4.Location = new Point(3, 3);
			this.tableLayoutPanel_4.Name = "tlpSwitches";
			this.tableLayoutPanel_4.RowCount = 2;
			this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
			this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_4.Size = new Size(489, 157);
			this.tableLayoutPanel_4.TabIndex = 4;
			this.toolStrip_7.BackColor = Color.White;
			this.toolStrip_7.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_23,
				this.toolStripButton_24,
				this.toolStripButton_25,
				this.toolStripSeparator_7,
				this.toolStripButton_26,
				this.toolStripSeparator_8,
				this.toolStripButton_27,
				this.toolStripLabel_4
			});
			this.toolStrip_7.Location = new Point(0, 0);
			this.toolStrip_7.Name = "tsSwitches";
			this.toolStrip_7.Size = new Size(489, 24);
			this.toolStrip_7.TabIndex = 8;
			this.toolStrip_7.Text = "Панель инструментов выключателей";
			this.toolStripButton_23.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_23.Image = (Image)componentResourceManager.GetObject("tsbSwitchAdd.Image");
			this.toolStripButton_23.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_23.Name = "tsbSwitchAdd";
			this.toolStripButton_23.Size = new Size(23, 21);
			this.toolStripButton_23.Text = "Добавить паспорт";
			this.toolStripButton_23.Click += this.toolStripButton_23_Click;
			this.toolStripButton_24.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_24.Image = (Image)componentResourceManager.GetObject("tsbSwitchEdit.Image");
			this.toolStripButton_24.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_24.Name = "tsbSwitchEdit";
			this.toolStripButton_24.Size = new Size(23, 21);
			this.toolStripButton_24.Text = "Изменить паспорт";
			this.toolStripButton_24.Click += this.toolStripButton_24_Click;
			this.toolStripButton_25.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_25.Image = (Image)componentResourceManager.GetObject("tsbSwitchDelete.Image");
			this.toolStripButton_25.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_25.Name = "tsbSwitchDelete";
			this.toolStripButton_25.Size = new Size(23, 21);
			this.toolStripButton_25.Text = "Удалить паспорт";
			this.toolStripButton_25.Click += this.toolStripButton_25_Click;
			this.toolStripSeparator_7.Name = "tssSwitchHistory";
			this.toolStripSeparator_7.Size = new Size(6, 24);
			this.toolStripButton_26.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_26.Image = (Image)componentResourceManager.GetObject("tsbSwitchHistory.Image");
			this.toolStripButton_26.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_26.Name = "tsbSwitchHistory";
			this.toolStripButton_26.Size = new Size(23, 21);
			this.toolStripButton_26.Text = "История паспортов объекта";
			this.toolStripButton_26.Click += this.toolStripButton_26_Click;
			this.toolStripSeparator_8.Name = "tssSwitchRefresh";
			this.toolStripSeparator_8.Size = new Size(6, 24);
			this.toolStripButton_27.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_27.Image = (Image)componentResourceManager.GetObject("tsbSwitchRefresh.Image");
			this.toolStripButton_27.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_27.Name = "tsbSwitchRefresh";
			this.toolStripButton_27.Size = new Size(23, 21);
			this.toolStripButton_27.Text = "Обновление данных";
			this.toolStripButton_27.Click += this.toolStripButton_27_Click;
			this.toolStripLabel_4.Alignment = ToolStripItemAlignment.Right;
			this.toolStripLabel_4.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripLabel_4.Name = "toolStripLabel2";
			this.toolStripLabel_4.Size = new Size(10, 21);
			this.toolStripLabel_4.Text = " ";
			this.dgvSwitches.AllowUserToAddRows = false;
			this.dgvSwitches.AllowUserToDeleteRows = false;
			this.dgvSwitches.AllowUserToResizeRows = false;
			this.dgvSwitches.BackgroundColor = Color.White;
			dataGridViewCellStyle58.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle58.BackColor = SystemColors.Control;
			dataGridViewCellStyle58.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle58.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle58.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle58.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle58.WrapMode = DataGridViewTriState.True;
			this.dgvSwitches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
			this.dgvSwitches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSwitches.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_143,
				this.dataGridViewTextBoxColumn_144,
				this.dataGridViewTextBoxColumn_145,
				this.dataGridViewTextBoxColumn_146
			});
			dataGridViewCellStyle59.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle59.BackColor = Color.White;
			dataGridViewCellStyle59.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle59.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle59.SelectionBackColor = Color.White;
			dataGridViewCellStyle59.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle59.WrapMode = DataGridViewTriState.False;
			this.dgvSwitches.DefaultCellStyle = dataGridViewCellStyle59;
			this.dgvSwitches.Dock = DockStyle.Fill;
			this.dgvSwitches.Location = new Point(3, 27);
			this.dgvSwitches.MultiSelect = false;
			this.dgvSwitches.Name = "dgvSwitches";
			this.dgvSwitches.ReadOnly = true;
			dataGridViewCellStyle60.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle60.BackColor = SystemColors.Control;
			dataGridViewCellStyle60.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle60.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle60.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle60.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle60.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle60.WrapMode = DataGridViewTriState.True;
			this.dgvSwitches.RowHeadersDefaultCellStyle = dataGridViewCellStyle60;
			this.dgvSwitches.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvSwitches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dgvSwitches.Size = new Size(483, 127);
			this.dgvSwitches.TabIndex = 9;
			this.dgvSwitches.CellDoubleClick += this.dgvSwitches_CellDoubleClick;
			this.dgvSwitches.SelectionChanged += this.dgvSwitches_SelectionChanged;
			this.dataGridViewTextBoxColumn_143.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_143.HeaderText = "idSwitch";
			this.dataGridViewTextBoxColumn_143.Name = "idDgvSwitch";
			this.dataGridViewTextBoxColumn_143.ReadOnly = true;
			this.dataGridViewTextBoxColumn_143.Visible = false;
			this.dataGridViewTextBoxColumn_144.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_144.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_144.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_144.MinimumWidth = 80;
			this.dataGridViewTextBoxColumn_144.Name = "NameDgvSwitch";
			this.dataGridViewTextBoxColumn_144.ReadOnly = true;
			this.dataGridViewTextBoxColumn_145.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_145.HeaderText = "idObjListSwitch";
			this.dataGridViewTextBoxColumn_145.Name = "idObjListDgvSwitch";
			this.dataGridViewTextBoxColumn_145.ReadOnly = true;
			this.dataGridViewTextBoxColumn_145.Visible = false;
			this.dataGridViewTextBoxColumn_146.DataPropertyName = "IdEquipment";
			this.dataGridViewTextBoxColumn_146.HeaderText = "IdEquipment";
			this.dataGridViewTextBoxColumn_146.Name = "IdEquipmentDgvSwitch";
			this.dataGridViewTextBoxColumn_146.ReadOnly = true;
			this.dataGridViewTextBoxColumn_146.Visible = false;
			this.tabPage_22.Controls.Add(this.dataGridViewExcelFilter_6);
			this.tabPage_22.Controls.Add(this.toolStrip_28);
			this.tabPage_22.Location = new Point(4, 22);
			this.tabPage_22.Name = "tpProtector";
			this.tabPage_22.Padding = new Padding(3);
			this.tabPage_22.Size = new Size(495, 163);
			this.tabPage_22.TabIndex = 3;
			this.tabPage_22.Text = "Устройства защиты";
			this.tabPage_22.UseVisualStyleBackColor = true;
			this.dataGridViewExcelFilter_6.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_6.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_6.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_6.BackgroundColor = Color.White;
			dataGridViewCellStyle61.Alignment = DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle61.BackColor = SystemColors.Control;
			dataGridViewCellStyle61.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle61.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle61.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle61.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle61.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle61;
			this.dataGridViewExcelFilter_6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_6.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_109,
				this.dataGridViewTextBoxColumn_110,
				this.dataGridViewTextBoxColumn_111,
				this.dataGridViewTextBoxColumn_112
			});
			dataGridViewCellStyle62.Alignment = DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle62.BackColor = SystemColors.Window;
			dataGridViewCellStyle62.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle62.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle62.SelectionBackColor = Color.White;
			dataGridViewCellStyle62.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle62.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_6.DefaultCellStyle = dataGridViewCellStyle62;
			this.dataGridViewExcelFilter_6.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_6.Location = new Point(3, 28);
			this.dataGridViewExcelFilter_6.MultiSelect = false;
			this.dataGridViewExcelFilter_6.Name = "dgvProtector";
			this.dataGridViewExcelFilter_6.ReadOnly = true;
			dataGridViewCellStyle63.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle63.BackColor = SystemColors.Control;
			dataGridViewCellStyle63.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle63.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle63.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle63.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle63.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle63.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_6.RowHeadersDefaultCellStyle = dataGridViewCellStyle63;
			this.dataGridViewExcelFilter_6.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridViewExcelFilter_6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_6.Size = new Size(489, 132);
			this.dataGridViewExcelFilter_6.TabIndex = 1;
			this.dataGridViewExcelFilter_6.CellDoubleClick += this.dataGridViewExcelFilter_6_CellDoubleClick;
			this.dataGridViewTextBoxColumn_109.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_109.HeaderText = "idProtector";
			this.dataGridViewTextBoxColumn_109.Name = "idDgvProtector";
			this.dataGridViewTextBoxColumn_109.ReadOnly = true;
			this.dataGridViewTextBoxColumn_109.Visible = false;
			this.dataGridViewTextBoxColumn_110.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_110.DataPropertyName = "name";
			this.dataGridViewTextBoxColumn_110.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_110.MinimumWidth = 80;
			this.dataGridViewTextBoxColumn_110.Name = "nameDgvProtector";
			this.dataGridViewTextBoxColumn_110.ReadOnly = true;
			this.dataGridViewTextBoxColumn_111.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_111.HeaderText = "idObjListProtector";
			this.dataGridViewTextBoxColumn_111.Name = "idObjListDgvProtector";
			this.dataGridViewTextBoxColumn_111.ReadOnly = true;
			this.dataGridViewTextBoxColumn_111.Visible = false;
			this.dataGridViewTextBoxColumn_112.DataPropertyName = "idEquipment";
			this.dataGridViewTextBoxColumn_112.HeaderText = "idEquipment";
			this.dataGridViewTextBoxColumn_112.Name = "idEquipmentDgvProtector";
			this.dataGridViewTextBoxColumn_112.ReadOnly = true;
			this.dataGridViewTextBoxColumn_112.Visible = false;
			this.toolStrip_28.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_123,
				this.toolStripButton_124,
				this.toolStripButton_125,
				this.toolStripSeparator_85,
				this.toolStripButton_126,
				this.toolStripSeparator_86,
				this.toolStripButton_127
			});
			this.toolStrip_28.Location = new Point(3, 3);
			this.toolStrip_28.Name = "tsProtectors";
			this.toolStrip_28.Size = new Size(489, 25);
			this.toolStrip_28.TabIndex = 0;
			this.toolStrip_28.Text = "Панель инструментов устройств защиты";
			this.toolStripButton_123.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_123.Image = Resources.smethod_24();
			this.toolStripButton_123.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_123.Name = "tsBtnAddProtectorPass";
			this.toolStripButton_123.Size = new Size(23, 22);
			this.toolStripButton_123.Text = "Добавить паспорт УЗ";
			this.toolStripButton_123.Click += this.toolStripButton_123_Click;
			this.toolStripButton_124.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_124.Image = Resources.smethod_26();
			this.toolStripButton_124.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_124.Name = "tsBtnEditProtectorPass";
			this.toolStripButton_124.Size = new Size(23, 22);
			this.toolStripButton_124.Text = "Редактировать паспорт УЗ";
			this.toolStripButton_124.Click += this.toolStripButton_124_Click;
			this.toolStripButton_125.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_125.Image = Resources.smethod_25();
			this.toolStripButton_125.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_125.Name = "tsBtnDelProtectorPass";
			this.toolStripButton_125.Size = new Size(23, 22);
			this.toolStripButton_125.Text = "Удалить паспорт УЗ";
			this.toolStripButton_125.Click += this.toolStripButton_125_Click;
			this.toolStripSeparator_85.Name = "toolStripSeparator38";
			this.toolStripSeparator_85.Size = new Size(6, 25);
			this.toolStripButton_126.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_126.Image = Resources.smethod_36();
			this.toolStripButton_126.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_126.Name = "tsBtnHistoryProtectorPass";
			this.toolStripButton_126.Size = new Size(23, 22);
			this.toolStripButton_126.Text = "История паспортов УЗ";
			this.toolStripButton_126.Click += this.toolStripButton_126_Click;
			this.toolStripSeparator_86.Name = "toolStripSeparator39";
			this.toolStripSeparator_86.Size = new Size(6, 25);
			this.toolStripButton_127.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_127.Image = Resources.smethod_45();
			this.toolStripButton_127.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_127.Name = "tsBtnRefreshProtector";
			this.toolStripButton_127.Size = new Size(23, 22);
			this.toolStripButton_127.Text = "Обновить список УЗ";
			this.toolStripButton_127.Click += this.toolStripButton_127_Click;
			this.tabPage_23.Controls.Add(this.splitContainer_1);
			this.tabPage_23.Location = new Point(4, 22);
			this.tabPage_23.Name = "tpLine";
			this.tabPage_23.Size = new Size(509, 473);
			this.tabPage_23.TabIndex = 4;
			this.tabPage_23.Text = "Участки кабеля и муфты";
			this.tabPage_23.UseVisualStyleBackColor = true;
			this.splitContainer_1.Dock = DockStyle.Fill;
			this.splitContainer_1.Location = new Point(0, 0);
			this.splitContainer_1.Name = "scLine";
			this.splitContainer_1.Orientation = Orientation.Horizontal;
			this.splitContainer_1.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
			this.splitContainer_1.Panel1.Controls.Add(this.toolStrip_11);
			this.splitContainer_1.Panel2.Controls.Add(this.tabControl_3);
			this.splitContainer_1.Size = new Size(509, 473);
			this.splitContainer_1.SplitterDistance = 235;
			this.splitContainer_1.TabIndex = 0;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_0.BackgroundColor = Color.White;
			dataGridViewCellStyle64.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle64.BackColor = SystemColors.Control;
			dataGridViewCellStyle64.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle64.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle64.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle64.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle64.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle64;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_74,
				this.dataGridViewTextBoxColumn_75,
				this.dataGridViewTextBoxColumn_76,
				this.dataGridViewTextBoxColumn_77,
				this.dataGridViewTextBoxColumn_78,
				this.dataGridViewTextBoxColumn_79,
				this.dataGridViewTextBoxColumn_80,
				this.dataGridViewTextBoxColumn_81,
				this.dataGridViewTextBoxColumn_82,
				this.dataGridViewTextBoxColumn_83,
				this.dataGridViewTextBoxColumn_84,
				this.dataGridViewTextBoxColumn_85,
				this.dataGridViewTextBoxColumn_86,
				this.dataGridViewTextBoxColumn_87,
				this.dataGridViewTextBoxColumn_88,
				this.dataGridViewTextBoxColumn_89,
				this.dataGridViewTextBoxColumn_90,
				this.dataGridViewTextBoxColumn_91,
				this.dataGridViewTextBoxColumn_92
			});
			this.dataGridViewExcelFilter_0.ContextMenuStrip = this.contextMenuStrip_5;
			dataGridViewCellStyle65.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle65.BackColor = SystemColors.Window;
			dataGridViewCellStyle65.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle65.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle65.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle65.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle65.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_0.DefaultCellStyle = dataGridViewCellStyle65;
			this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_0.Location = new Point(0, 25);
			this.dataGridViewExcelFilter_0.MultiSelect = false;
			this.dataGridViewExcelFilter_0.Name = "dgvCabSections";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			dataGridViewCellStyle66.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle66.BackColor = SystemColors.Control;
			dataGridViewCellStyle66.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle66.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle66.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle66.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle66.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle66.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle66;
			this.dataGridViewExcelFilter_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_0.Size = new Size(509, 210);
			this.dataGridViewExcelFilter_0.TabIndex = 1;
			this.dataGridViewExcelFilter_0.CellContextMenuStripNeeded += this.dataGridViewExcelFilter_0_CellContextMenuStripNeeded;
			this.dataGridViewExcelFilter_0.CellDoubleClick += this.dataGridViewExcelFilter_0_CellDoubleClick;
			this.dataGridViewTextBoxColumn_74.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_74.HeaderText = "SectionId";
			this.dataGridViewTextBoxColumn_74.Name = "SectionId";
			this.dataGridViewTextBoxColumn_74.ReadOnly = true;
			this.dataGridViewTextBoxColumn_74.Visible = false;
			this.dataGridViewTextBoxColumn_75.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_75.HeaderText = "SectionIdObjList";
			this.dataGridViewTextBoxColumn_75.Name = "SectionIdObjList";
			this.dataGridViewTextBoxColumn_75.ReadOnly = true;
			this.dataGridViewTextBoxColumn_75.Visible = false;
			this.dataGridViewTextBoxColumn_76.DataPropertyName = "idPassport";
			this.dataGridViewTextBoxColumn_76.HeaderText = "SectionIdPassport";
			this.dataGridViewTextBoxColumn_76.Name = "SectionIdPassport";
			this.dataGridViewTextBoxColumn_76.ReadOnly = true;
			this.dataGridViewTextBoxColumn_76.Visible = false;
			this.dataGridViewTextBoxColumn_77.DataPropertyName = "idEquipment";
			this.dataGridViewTextBoxColumn_77.HeaderText = "idEquipment";
			this.dataGridViewTextBoxColumn_77.Name = "SectionIdEquipment";
			this.dataGridViewTextBoxColumn_77.ReadOnly = true;
			this.dataGridViewTextBoxColumn_77.Visible = false;
			this.dataGridViewTextBoxColumn_78.DataPropertyName = "Number";
			this.dataGridViewTextBoxColumn_78.HeaderText = "Номер участка";
			this.dataGridViewTextBoxColumn_78.Name = "SectionNumber";
			this.dataGridViewTextBoxColumn_78.ReadOnly = true;
			this.dataGridViewTextBoxColumn_78.Width = 60;
			this.dataGridViewTextBoxColumn_79.DataPropertyName = "ClutchFirst";
			this.dataGridViewTextBoxColumn_79.HeaderText = "Муфта";
			this.dataGridViewTextBoxColumn_79.Name = "SectionClutchFirst";
			this.dataGridViewTextBoxColumn_79.ReadOnly = true;
			this.dataGridViewTextBoxColumn_79.Width = 60;
			this.dataGridViewTextBoxColumn_80.DataPropertyName = "ClutchSecond";
			this.dataGridViewTextBoxColumn_80.HeaderText = "Муфта";
			this.dataGridViewTextBoxColumn_80.Name = "SectionClutchSecond";
			this.dataGridViewTextBoxColumn_80.ReadOnly = true;
			this.dataGridViewTextBoxColumn_80.Width = 60;
			this.dataGridViewTextBoxColumn_81.DataPropertyName = "makeup";
			this.dataGridViewTextBoxColumn_81.HeaderText = "Марка кабеля";
			this.dataGridViewTextBoxColumn_81.Name = "SectionMakeup";
			this.dataGridViewTextBoxColumn_81.ReadOnly = true;
			this.dataGridViewTextBoxColumn_82.DataPropertyName = "voltage";
			this.dataGridViewTextBoxColumn_82.HeaderText = "Рабочее напряжение";
			this.dataGridViewTextBoxColumn_82.Name = "SectionVoltage";
			this.dataGridViewTextBoxColumn_82.ReadOnly = true;
			this.dataGridViewTextBoxColumn_82.Width = 70;
			this.dataGridViewTextBoxColumn_83.DataPropertyName = "wires";
			this.dataGridViewTextBoxColumn_83.HeaderText = "Количество жил";
			this.dataGridViewTextBoxColumn_83.Name = "SectionWires";
			this.dataGridViewTextBoxColumn_83.ReadOnly = true;
			this.dataGridViewTextBoxColumn_83.Width = 70;
			this.dataGridViewTextBoxColumn_84.DataPropertyName = "crossSection";
			this.dataGridViewTextBoxColumn_84.HeaderText = "Сечение жил";
			this.dataGridViewTextBoxColumn_84.Name = "SectionCrossSection";
			this.dataGridViewTextBoxColumn_84.ReadOnly = true;
			this.dataGridViewTextBoxColumn_84.Width = 60;
			this.dataGridViewTextBoxColumn_85.DataPropertyName = "length";
			this.dataGridViewTextBoxColumn_85.HeaderText = "Длина";
			this.dataGridViewTextBoxColumn_85.Name = "SectionLength";
			this.dataGridViewTextBoxColumn_85.ReadOnly = true;
			this.dataGridViewTextBoxColumn_85.Width = 60;
			this.dataGridViewTextBoxColumn_86.DataPropertyName = "CONDITIONS";
			this.dataGridViewTextBoxColumn_86.HeaderText = "Условия прокладки";
			this.dataGridViewTextBoxColumn_86.Name = "SectionConditions";
			this.dataGridViewTextBoxColumn_86.ReadOnly = true;
			this.dataGridViewTextBoxColumn_87.DataPropertyName = "Count";
			this.dataGridViewTextBoxColumn_87.HeaderText = "Количество";
			this.dataGridViewTextBoxColumn_87.Name = "SectionCount";
			this.dataGridViewTextBoxColumn_87.ReadOnly = true;
			this.dataGridViewTextBoxColumn_87.Width = 70;
			this.dataGridViewTextBoxColumn_88.DataPropertyName = "yearLaying";
			this.dataGridViewTextBoxColumn_88.HeaderText = "Год прокладки";
			this.dataGridViewTextBoxColumn_88.Name = "SectionYearLaying";
			this.dataGridViewTextBoxColumn_88.ReadOnly = true;
			this.dataGridViewTextBoxColumn_88.Width = 80;
			this.dataGridViewTextBoxColumn_89.DataPropertyName = "yearCommissioning";
			this.dataGridViewTextBoxColumn_89.HeaderText = "Год ввода в эксплуатацию";
			this.dataGridViewTextBoxColumn_89.Name = "SectionYearCommisioning";
			this.dataGridViewTextBoxColumn_89.ReadOnly = true;
			this.dataGridViewTextBoxColumn_89.Width = 90;
			this.dataGridViewTextBoxColumn_90.DataPropertyName = "yearRenovation";
			this.dataGridViewTextBoxColumn_90.HeaderText = "Год реконструкции";
			this.dataGridViewTextBoxColumn_90.Name = "SectionRenovation";
			this.dataGridViewTextBoxColumn_90.ReadOnly = true;
			this.dataGridViewTextBoxColumn_90.Width = 90;
			this.dataGridViewTextBoxColumn_91.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_91.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_91.Name = "SectionComment";
			this.dataGridViewTextBoxColumn_91.ReadOnly = true;
			this.dataGridViewTextBoxColumn_92.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_92.HeaderText = "SectionDeleted";
			this.dataGridViewTextBoxColumn_92.Name = "SectionDeleted";
			this.dataGridViewTextBoxColumn_92.ReadOnly = true;
			this.dataGridViewTextBoxColumn_92.Visible = false;
			this.contextMenuStrip_5.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_20,
				this.toolStripMenuItem_21,
				this.toolStripSeparator_27,
				this.toolStripMenuItem_22,
				this.toolStripSeparator_28,
				this.toolStripMenuItem_23
			});
			this.contextMenuStrip_5.Name = "cmsBuildRepair";
			this.contextMenuStrip_5.Size = new Size(155, 104);
			this.toolStripMenuItem_20.Image = Resources.smethod_24();
			this.toolStripMenuItem_20.Name = "tsmiAddSection";
			this.toolStripMenuItem_20.Size = new Size(154, 22);
			this.toolStripMenuItem_20.Text = "Добавить";
			this.toolStripMenuItem_20.Click += this.toolStripButton_41_Click;
			this.toolStripMenuItem_21.Image = Resources.smethod_26();
			this.toolStripMenuItem_21.Name = "tsmiEditSection";
			this.toolStripMenuItem_21.Size = new Size(154, 22);
			this.toolStripMenuItem_21.Text = "Редактировать";
			this.toolStripMenuItem_21.Click += this.toolStripButton_42_Click;
			this.toolStripSeparator_27.Name = "toolStripSeparator3";
			this.toolStripSeparator_27.Size = new Size(151, 6);
			this.toolStripMenuItem_22.Image = Resources.smethod_25();
			this.toolStripMenuItem_22.Name = "tsmiDeleteSection";
			this.toolStripMenuItem_22.Size = new Size(154, 22);
			this.toolStripMenuItem_22.Text = "Удалить";
			this.toolStripMenuItem_22.Click += this.toolStripButton_43_Click;
			this.toolStripSeparator_28.Name = "toolStripSeparator4";
			this.toolStripSeparator_28.Size = new Size(151, 6);
			this.toolStripMenuItem_23.Image = Resources.smethod_45();
			this.toolStripMenuItem_23.Name = "tsmiRefreshSection";
			this.toolStripMenuItem_23.Size = new Size(154, 22);
			this.toolStripMenuItem_23.Text = "Обновить";
			this.toolStripMenuItem_23.Click += this.toolStripButton_44_Click;
			this.toolStrip_11.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_41,
				this.toolStripButton_42,
				this.toolStripSplitButton_1,
				this.toolStripSeparator_21,
				this.toolStripButton_43,
				this.toolStripSeparator_22,
				this.toolStripButton_44,
				this.toolStripSeparator_46,
				this.toolStripButton_85,
				this.toolStripSeparator_62,
				this.toolStripLabel_5
			});
			this.toolStrip_11.Location = new Point(0, 0);
			this.toolStrip_11.Name = "tsCabSection";
			this.toolStrip_11.Size = new Size(509, 25);
			this.toolStrip_11.TabIndex = 0;
			this.toolStrip_11.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_41.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_41.Image = Resources.smethod_24();
			this.toolStripButton_41.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_41.Name = "tsbAddSection";
			this.toolStripButton_41.Size = new Size(23, 22);
			this.toolStripButton_41.Text = "Добавить";
			this.toolStripButton_41.Click += this.toolStripButton_41_Click;
			this.toolStripButton_42.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_42.Image = Resources.smethod_26();
			this.toolStripButton_42.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_42.Name = "tsbEditSection";
			this.toolStripButton_42.Size = new Size(23, 22);
			this.toolStripButton_42.Text = "Редактировать";
			this.toolStripButton_42.Click += this.toolStripButton_42_Click;
			this.toolStripSplitButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton_1.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_32,
				this.toolStripMenuItem_33
			});
			this.toolStripSplitButton_1.Image = Resources.smethod_12();
			this.toolStripSplitButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripSplitButton_1.Name = "tsbSplitCabSection";
			this.toolStripSplitButton_1.Size = new Size(32, 22);
			this.toolStripSplitButton_1.Text = "Разделить";
			this.toolStripMenuItem_32.Name = "tsmiSptitSectionWithClutch";
			this.toolStripMenuItem_32.Size = new Size(184, 22);
			this.toolStripMenuItem_32.Text = "Разделить муфтой";
			this.toolStripMenuItem_32.ToolTipText = "Разделить муфтой";
			this.toolStripMenuItem_32.Click += this.toolStripMenuItem_32_Click;
			this.toolStripMenuItem_33.Name = "tsmiSptitSectionWithSection";
			this.toolStripMenuItem_33.Size = new Size(184, 22);
			this.toolStripMenuItem_33.Text = "Разделить участком";
			this.toolStripMenuItem_33.ToolTipText = "Разделить участком";
			this.toolStripMenuItem_33.Click += this.toolStripMenuItem_33_Click;
			this.toolStripSeparator_21.Name = "tssDeleteSection";
			this.toolStripSeparator_21.Size = new Size(6, 25);
			this.toolStripButton_43.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_43.Image = Resources.smethod_25();
			this.toolStripButton_43.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_43.Name = "tsbDeleteSection";
			this.toolStripButton_43.Size = new Size(23, 22);
			this.toolStripButton_43.Text = "Удалить";
			this.toolStripButton_43.Click += this.toolStripButton_43_Click;
			this.toolStripSeparator_22.Name = "tssRefreshSector";
			this.toolStripSeparator_22.Size = new Size(6, 25);
			this.toolStripButton_44.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_44.Image = Resources.smethod_45();
			this.toolStripButton_44.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_44.Name = "tsbRefreshSection";
			this.toolStripButton_44.Size = new Size(23, 22);
			this.toolStripButton_44.Text = "Обновить";
			this.toolStripButton_44.Click += this.toolStripButton_44_Click;
			this.toolStripSeparator_46.Name = "tssCabSectionLength";
			this.toolStripSeparator_46.Size = new Size(6, 25);
			this.toolStripButton_85.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_85.Image = (Image)componentResourceManager.GetObject("tsbCabSectionHistory.Image");
			this.toolStripButton_85.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_85.Name = "tsbCabSectionHistory";
			this.toolStripButton_85.Size = new Size(23, 22);
			this.toolStripButton_85.Text = "История паспортов объекта";
			this.toolStripButton_85.Click += this.toolStripButton_85_Click;
			this.toolStripSeparator_62.Name = "toolStripSeparator14";
			this.toolStripSeparator_62.Size = new Size(6, 25);
			this.toolStripLabel_5.Name = "tslCabSectionLength";
			this.toolStripLabel_5.Size = new Size(28, 22);
			this.toolStripLabel_5.Text = "0 м.";
			this.tabControl_3.Controls.Add(this.dykcUlJvZe);
			this.tabControl_3.Controls.Add(this.tabPage_14);
			this.tabControl_3.Dock = DockStyle.Fill;
			this.tabControl_3.Location = new Point(0, 0);
			this.tabControl_3.Name = "tcClutch";
			this.tabControl_3.SelectedIndex = 0;
			this.tabControl_3.Size = new Size(509, 234);
			this.tabControl_3.TabIndex = 10;
			this.tabControl_3.SelectedIndexChanged += this.tabControl_3_SelectedIndexChanged;
			this.dykcUlJvZe.Controls.Add(this.tableLayoutPanel_8);
			this.dykcUlJvZe.Location = new Point(4, 22);
			this.dykcUlJvZe.Name = "tpClutchConnection";
			this.dykcUlJvZe.Padding = new Padding(3);
			this.dykcUlJvZe.Size = new Size(501, 208);
			this.dykcUlJvZe.TabIndex = 0;
			this.dykcUlJvZe.Text = "Муфты";
			this.dykcUlJvZe.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_8.ColumnCount = 1;
			this.tableLayoutPanel_8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_8.Controls.Add(this.dataGridViewExcelFilter_7, 0, 1);
			this.tableLayoutPanel_8.Controls.Add(this.toolStrip_12, 0, 0);
			this.tableLayoutPanel_8.Dock = DockStyle.Fill;
			this.tableLayoutPanel_8.Location = new Point(3, 3);
			this.tableLayoutPanel_8.Name = "tlpClutchConnection";
			this.tableLayoutPanel_8.RowCount = 2;
			this.tableLayoutPanel_8.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_8.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_8.Size = new Size(495, 202);
			this.tableLayoutPanel_8.TabIndex = 7;
			this.dataGridViewExcelFilter_7.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_7.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_7.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_7.BackgroundColor = Color.White;
			dataGridViewCellStyle67.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle67.BackColor = SystemColors.Control;
			dataGridViewCellStyle67.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle67.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle67.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle67.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle67.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle67;
			this.dataGridViewExcelFilter_7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_7.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_93
			});
			this.dataGridViewExcelFilter_7.ContextMenuStrip = this.contextMenuStrip_4;
			dataGridViewCellStyle68.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle68.BackColor = SystemColors.Window;
			dataGridViewCellStyle68.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle68.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle68.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle68.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle68.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_7.DefaultCellStyle = dataGridViewCellStyle68;
			this.dataGridViewExcelFilter_7.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_7.Location = new Point(3, 28);
			this.dataGridViewExcelFilter_7.MultiSelect = false;
			this.dataGridViewExcelFilter_7.Name = "dgvClutchConection";
			this.dataGridViewExcelFilter_7.ReadOnly = true;
			dataGridViewCellStyle69.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle69.BackColor = SystemColors.Control;
			dataGridViewCellStyle69.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle69.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle69.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle69.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle69.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle69.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_7.RowHeadersDefaultCellStyle = dataGridViewCellStyle69;
			this.dataGridViewExcelFilter_7.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridViewExcelFilter_7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_7.Size = new Size(489, 171);
			this.dataGridViewExcelFilter_7.TabIndex = 1;
			this.dataGridViewExcelFilter_7.CellContextMenuStripNeeded += this.dataGridViewExcelFilter_7_CellContextMenuStripNeeded;
			this.dataGridViewExcelFilter_7.CellDoubleClick += this.dataGridViewExcelFilter_7_CellDoubleClick;
			this.dataGridViewExcelFilter_7.SelectionChanged += this.dataGridViewExcelFilter_7_SelectionChanged;
			this.dataGridViewTextBoxColumn_93.DataPropertyName = "IdEquipment";
			this.dataGridViewTextBoxColumn_93.HeaderText = "IdEquipment";
			this.dataGridViewTextBoxColumn_93.Name = "ClutchConnectionIdEquipment";
			this.dataGridViewTextBoxColumn_93.ReadOnly = true;
			this.dataGridViewTextBoxColumn_93.Visible = false;
			this.contextMenuStrip_4.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_13,
				this.toolStripMenuItem_14,
				this.toolStripMenuItem_15,
				this.toolStripMenuItem_48,
				this.toolStripSeparator_25,
				this.toolStripMenuItem_16,
				this.toolStripSeparator_26,
				this.toolStripMenuItem_17
			});
			this.contextMenuStrip_4.Name = "contextMenuStrip1";
			this.contextMenuStrip_4.Size = new Size(203, 148);
			this.toolStripMenuItem_13.Image = Resources.smethod_24();
			this.toolStripMenuItem_13.Name = "tsmiAddClutch";
			this.toolStripMenuItem_13.Size = new Size(202, 22);
			this.toolStripMenuItem_13.Text = "Добавить";
			this.toolStripMenuItem_13.Click += this.toolStripButton_45_Click;
			this.toolStripMenuItem_14.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_18,
				this.toolStripMenuItem_19
			});
			this.toolStripMenuItem_14.Image = Resources.smethod_24();
			this.toolStripMenuItem_14.Name = "добавитьВиртуальнуюToolStripMenuItem";
			this.toolStripMenuItem_14.Size = new Size(202, 22);
			this.toolStripMenuItem_14.Text = "Добавить виртуальную";
			this.toolStripMenuItem_18.Name = "tsmiAddVirtFirst";
			this.toolStripMenuItem_18.Size = new Size(134, 22);
			this.toolStripMenuItem_18.Text = "Начальная";
			this.toolStripMenuItem_19.Name = "tsmiAddVirtLast";
			this.toolStripMenuItem_19.Size = new Size(134, 22);
			this.toolStripMenuItem_19.Text = "Конечная";
			this.toolStripMenuItem_15.Image = Resources.smethod_26();
			this.toolStripMenuItem_15.Name = "tsmiEditClutch";
			this.toolStripMenuItem_15.Size = new Size(202, 22);
			this.toolStripMenuItem_15.Text = "Редактировать";
			this.toolStripMenuItem_15.Click += this.toolStripButton_46_Click;
			this.toolStripMenuItem_48.Image = Resources.smethod_46();
			this.toolStripMenuItem_48.Name = "tsmiRenameClutch";
			this.toolStripMenuItem_48.Size = new Size(202, 22);
			this.toolStripMenuItem_48.Text = "Переименовать";
			this.toolStripMenuItem_48.Click += this.toolStripButton_106_Click;
			this.toolStripSeparator_25.Name = "toolStripSeparator2";
			this.toolStripSeparator_25.Size = new Size(199, 6);
			this.toolStripMenuItem_16.Image = Resources.smethod_25();
			this.toolStripMenuItem_16.Name = "tsmiDeleteClutch";
			this.toolStripMenuItem_16.Size = new Size(202, 22);
			this.toolStripMenuItem_16.Text = "Удалить";
			this.toolStripSeparator_26.Name = "toolStripSeparator1";
			this.toolStripSeparator_26.Size = new Size(199, 6);
			this.toolStripMenuItem_17.Image = Resources.smethod_45();
			this.toolStripMenuItem_17.Name = "tsmiRefreshClutch";
			this.toolStripMenuItem_17.Size = new Size(202, 22);
			this.toolStripMenuItem_17.Text = "Обновить";
			this.toolStripMenuItem_17.Click += this.toolStripButton_47_Click;
			this.toolStrip_12.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_45,
				this.toolStripButton_46,
				this.toolStripSeparator_23,
				this.toolStripSplitButton_2,
				this.toolStripSeparator_24,
				this.toolStripButton_47,
				this.toolStripSeparator_63,
				this.toolStripButton_86,
				this.toolStripSeparator_75,
				this.toolStripButton_106
			});
			this.toolStrip_12.Location = new Point(0, 0);
			this.toolStrip_12.Name = "tsClutchConnection";
			this.toolStrip_12.Size = new Size(495, 25);
			this.toolStrip_12.TabIndex = 0;
			this.toolStrip_12.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_45.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_45.Image = Resources.smethod_24();
			this.toolStripButton_45.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_45.Name = "tsbClutchConnectionAdd";
			this.toolStripButton_45.Size = new Size(23, 22);
			this.toolStripButton_45.Text = "Добавить";
			this.toolStripButton_45.Click += this.toolStripButton_45_Click;
			this.toolStripButton_46.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_46.Image = Resources.smethod_26();
			this.toolStripButton_46.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_46.Name = "tsbClutchConnectionEdit";
			this.toolStripButton_46.Size = new Size(23, 22);
			this.toolStripButton_46.Text = "Редактировать";
			this.toolStripButton_46.Click += this.toolStripButton_46_Click;
			this.toolStripSeparator_23.Name = "toolStripSeparator11";
			this.toolStripSeparator_23.Size = new Size(6, 25);
			this.toolStripSplitButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton_2.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_47,
				this.HsaPpImClL
			});
			this.toolStripSplitButton_2.Image = Resources.smethod_25();
			this.toolStripSplitButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripSplitButton_2.Name = "toolStripSplitButton1";
			this.toolStripSplitButton_2.Size = new Size(32, 22);
			this.toolStripSplitButton_2.Text = "Удалить";
			this.toolStripMenuItem_47.Name = "удалитьМуфтуToolStripMenuItem";
			this.toolStripMenuItem_47.Size = new Size(166, 22);
			this.toolStripMenuItem_47.Tag = "1";
			this.toolStripMenuItem_47.Text = "Удалить муфту";
			this.toolStripMenuItem_47.Click += this.toolStripMenuItem_50_Click;
			this.HsaPpImClL.Name = "удалитьПаспортToolStripMenuItem";
			this.HsaPpImClL.Size = new Size(166, 22);
			this.HsaPpImClL.Tag = "2";
			this.HsaPpImClL.Text = "Удалить паспорт";
			this.HsaPpImClL.Click += this.toolStripMenuItem_50_Click;
			this.toolStripSeparator_24.Name = "toolStripSeparator12";
			this.toolStripSeparator_24.Size = new Size(6, 25);
			this.toolStripButton_47.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_47.Image = Resources.smethod_45();
			this.toolStripButton_47.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_47.Name = "tsbClutchConnectionRefresh";
			this.toolStripButton_47.Size = new Size(23, 22);
			this.toolStripButton_47.Text = "Обновить";
			this.toolStripButton_47.Click += this.toolStripButton_47_Click;
			this.toolStripSeparator_63.Name = "toolStripSeparator15";
			this.toolStripSeparator_63.Size = new Size(6, 25);
			this.toolStripButton_86.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_86.Image = (Image)componentResourceManager.GetObject("tsbClutchConnectionHistory.Image");
			this.toolStripButton_86.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_86.Name = "tsbClutchConnectionHistory";
			this.toolStripButton_86.Size = new Size(23, 22);
			this.toolStripButton_86.Text = "История паспортов объекта";
			this.toolStripButton_86.Click += this.toolStripButton_86_Click;
			this.toolStripSeparator_75.Name = "toolStripSeparator31";
			this.toolStripSeparator_75.Size = new Size(6, 25);
			this.toolStripButton_106.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_106.Image = Resources.smethod_46();
			this.toolStripButton_106.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_106.Name = "tsbClutchConnectionRename";
			this.toolStripButton_106.Size = new Size(23, 22);
			this.toolStripButton_106.Text = "Переименовать";
			this.toolStripButton_106.Click += this.toolStripButton_106_Click;
			this.tabPage_14.Controls.Add(this.tableLayoutPanel_15);
			this.tabPage_14.Location = new Point(4, 22);
			this.tabPage_14.Name = "tpClutchEnd";
			this.tabPage_14.Padding = new Padding(3);
			this.tabPage_14.Size = new Size(501, 208);
			this.tabPage_14.TabIndex = 1;
			this.tabPage_14.Text = "Концевые разделки";
			this.tabPage_14.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_15.ColumnCount = 1;
			this.tableLayoutPanel_15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_15.Controls.Add(this.dataGridViewExcelFilter_2, 0, 1);
			this.tableLayoutPanel_15.Controls.Add(this.toolStrip_20, 0, 0);
			this.tableLayoutPanel_15.Dock = DockStyle.Fill;
			this.tableLayoutPanel_15.Location = new Point(3, 3);
			this.tableLayoutPanel_15.Name = "tlpClutchEnd";
			this.tableLayoutPanel_15.RowCount = 2;
			this.tableLayoutPanel_15.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_15.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_15.Size = new Size(495, 202);
			this.tableLayoutPanel_15.TabIndex = 1;
			this.dataGridViewExcelFilter_2.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_2.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_2.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_2.BackgroundColor = Color.White;
			dataGridViewCellStyle70.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle70.BackColor = SystemColors.Control;
			dataGridViewCellStyle70.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle70.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle70.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle70.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle70.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle70;
			this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_2.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_94
			});
			this.dataGridViewExcelFilter_2.ContextMenuStrip = this.contextMenuStrip_10;
			dataGridViewCellStyle71.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle71.BackColor = SystemColors.Window;
			dataGridViewCellStyle71.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle71.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle71.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle71.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle71.WrapMode = DataGridViewTriState.False;
			this.dataGridViewExcelFilter_2.DefaultCellStyle = dataGridViewCellStyle71;
			this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_2.Location = new Point(3, 28);
			this.dataGridViewExcelFilter_2.MultiSelect = false;
			this.dataGridViewExcelFilter_2.Name = "dgvClutchEnd";
			this.dataGridViewExcelFilter_2.ReadOnly = true;
			dataGridViewCellStyle72.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle72.BackColor = SystemColors.Control;
			dataGridViewCellStyle72.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle72.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle72.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle72.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle72.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle72.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_2.RowHeadersDefaultCellStyle = dataGridViewCellStyle72;
			this.dataGridViewExcelFilter_2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridViewExcelFilter_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_2.Size = new Size(489, 171);
			this.dataGridViewExcelFilter_2.TabIndex = 1;
			this.dataGridViewExcelFilter_2.CellContextMenuStripNeeded += this.dataGridViewExcelFilter_2_CellContextMenuStripNeeded;
			this.dataGridViewExcelFilter_2.CellDoubleClick += this.dataGridViewExcelFilter_2_CellDoubleClick;
			this.dataGridViewTextBoxColumn_94.DataPropertyName = "idEquipment";
			this.dataGridViewTextBoxColumn_94.HeaderText = "IdEquipment";
			this.dataGridViewTextBoxColumn_94.Name = "ClutchEndIdEquipment";
			this.dataGridViewTextBoxColumn_94.ReadOnly = true;
			this.dataGridViewTextBoxColumn_94.Visible = false;
			this.contextMenuStrip_10.Items.AddRange(new ToolStripItem[]
			{
				this.leJimFhKcN,
				this.toolStripMenuItem_43,
				this.toolStripSeparator_59,
				this.toolStripMenuItem_44
			});
			this.contextMenuStrip_10.Name = "cmsBuildRepair";
			this.contextMenuStrip_10.Size = new Size(155, 76);
			this.leJimFhKcN.Image = Resources.smethod_24();
			this.leJimFhKcN.Name = "tsmiClutchEndAdd";
			this.leJimFhKcN.Size = new Size(154, 22);
			this.leJimFhKcN.Text = "Добавить";
			this.toolStripMenuItem_43.Image = Resources.smethod_26();
			this.toolStripMenuItem_43.Name = "tsmiClutchEndEdit";
			this.toolStripMenuItem_43.Size = new Size(154, 22);
			this.toolStripMenuItem_43.Text = "Редактировать";
			this.toolStripSeparator_59.Name = "toolStripSeparator19";
			this.toolStripSeparator_59.Size = new Size(151, 6);
			this.toolStripMenuItem_44.Image = Resources.smethod_45();
			this.toolStripMenuItem_44.Name = "tsmiClutchEndRefresh";
			this.toolStripMenuItem_44.Size = new Size(154, 22);
			this.toolStripMenuItem_44.Text = "Обновить";
			this.toolStrip_20.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_81,
				this.toolStripButton_82,
				this.toolStripSeparator_57,
				this.toolStripSplitButton_3,
				this.toolStripSeparator_58,
				this.toolStripButton_83,
				this.toolStripSeparator_65,
				this.toolStripButton_88
			});
			this.toolStrip_20.Location = new Point(0, 0);
			this.toolStrip_20.Name = "tsClutchEnd";
			this.toolStrip_20.Size = new Size(495, 25);
			this.toolStrip_20.TabIndex = 0;
			this.toolStrip_20.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_81.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_81.Image = Resources.smethod_24();
			this.toolStripButton_81.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_81.Name = "tsbClutchEndAdd";
			this.toolStripButton_81.Size = new Size(23, 22);
			this.toolStripButton_81.Text = "Добавить";
			this.toolStripButton_81.Click += this.toolStripButton_81_Click;
			this.toolStripButton_82.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_82.Image = Resources.smethod_26();
			this.toolStripButton_82.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_82.Name = "tsbClutchEndEdit";
			this.toolStripButton_82.Size = new Size(23, 22);
			this.toolStripButton_82.Text = "Редактировать";
			this.toolStripButton_82.Click += this.toolStripButton_82_Click;
			this.toolStripSeparator_57.Name = "toolStripSeparator16";
			this.toolStripSeparator_57.Size = new Size(6, 25);
			this.toolStripSeparator_57.Visible = false;
			this.toolStripSplitButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton_3.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_49,
				this.toolStripMenuItem_50
			});
			this.toolStripSplitButton_3.Image = Resources.smethod_25();
			this.toolStripSplitButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripSplitButton_3.Name = "tssbClutchEndDelete";
			this.toolStripSplitButton_3.Size = new Size(32, 22);
			this.toolStripSplitButton_3.Text = "Удаление концевой разделки";
			this.toolStripMenuItem_49.Name = "tsmiCluchEndDelete";
			this.toolStripMenuItem_49.Size = new Size(281, 22);
			this.toolStripMenuItem_49.Tag = "3";
			this.toolStripMenuItem_49.Text = "Удалить концевую разделку";
			this.toolStripMenuItem_49.Click += this.toolStripMenuItem_50_Click;
			this.toolStripMenuItem_50.Name = "tsmiCluchEndPassportDelete";
			this.toolStripMenuItem_50.Size = new Size(281, 22);
			this.toolStripMenuItem_50.Tag = "4";
			this.toolStripMenuItem_50.Text = "Удалить пасспорт концевой разделки";
			this.toolStripMenuItem_50.Click += this.toolStripMenuItem_50_Click;
			this.toolStripSeparator_58.Name = "toolStripSeparator17";
			this.toolStripSeparator_58.Size = new Size(6, 25);
			this.toolStripButton_83.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_83.Image = Resources.smethod_45();
			this.toolStripButton_83.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_83.Name = "tsbClutchEndRefresh";
			this.toolStripButton_83.Size = new Size(23, 22);
			this.toolStripButton_83.Text = "Обновить";
			this.toolStripButton_83.Click += this.toolStripButton_83_Click;
			this.toolStripSeparator_65.Name = "toolStripSeparator20";
			this.toolStripSeparator_65.Size = new Size(6, 25);
			this.toolStripButton_88.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_88.Image = (Image)componentResourceManager.GetObject("tsbClutchEndHistory.Image");
			this.toolStripButton_88.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_88.Name = "tsbClutchEndHistory";
			this.toolStripButton_88.Size = new Size(23, 22);
			this.toolStripButton_88.Text = "История паспортов объекта";
			this.toolStripButton_88.Click += this.toolStripButton_88_Click;
			this.Cjurjlhywj.Controls.Add(this.splitContainer_2);
			this.Cjurjlhywj.Location = new Point(4, 22);
			this.Cjurjlhywj.Name = "tpAirLine";
			this.Cjurjlhywj.Size = new Size(509, 473);
			this.Cjurjlhywj.TabIndex = 5;
			this.Cjurjlhywj.Text = "Пролеты и опоры";
			this.Cjurjlhywj.UseVisualStyleBackColor = true;
			this.splitContainer_2.Dock = DockStyle.Fill;
			this.splitContainer_2.Location = new Point(0, 0);
			this.splitContainer_2.Name = "scAirLine1";
			this.splitContainer_2.Orientation = Orientation.Horizontal;
			this.splitContainer_2.Panel1.Controls.Add(this.treeDataGridView_0);
			this.splitContainer_2.Panel1.Controls.Add(this.toolStrip_19);
			this.splitContainer_2.Panel2.Controls.Add(this.splitContainer_3);
			this.splitContainer_2.Size = new Size(509, 473);
			this.splitContainer_2.SplitterDistance = 185;
			this.splitContainer_2.TabIndex = 0;
			this.treeDataGridView_0.AllowUserToAddRows = false;
			this.treeDataGridView_0.AllowUserToDeleteRows = false;
			this.treeDataGridView_0.AllowUserToResizeRows = false;
			this.treeDataGridView_0.BackgroundColor = Color.White;
			dataGridViewCellStyle73.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle73.BackColor = SystemColors.Control;
			dataGridViewCellStyle73.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle73.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle73.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle73.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle73.WrapMode = DataGridViewTriState.True;
			this.treeDataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle73;
			this.treeDataGridView_0.ColumnHeadersHeight = 34;
			this.treeDataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.treeGridColumn_0,
				this.treeGridColumn_1,
				this.treeGridColumn_2,
				this.treeGridColumn_3,
				this.treeGridColumn_4,
				this.dataGridViewTextBoxColumn_64,
				this.dataGridViewTextBoxColumn_65,
				this.dataGridViewTextBoxColumn_66,
				this.dataGridViewTextBoxColumn_67,
				this.dataGridViewTextBoxColumn_68,
				this.dataGridViewTextBoxColumn_69,
				this.dataGridViewTextBoxColumn_70,
				this.dataGridViewTextBoxColumn_71,
				this.dataGridViewTextBoxColumn_72,
				this.dataGridViewTextBoxColumn_73
			});
			this.treeDataGridView_0.ContextMenuStrip = this.contextMenuStrip_9;
			dataGridViewCellStyle74.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle74.BackColor = SystemColors.Window;
			dataGridViewCellStyle74.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle74.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle74.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle74.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle74.WrapMode = DataGridViewTriState.True;
			this.treeDataGridView_0.DefaultCellStyle = dataGridViewCellStyle74;
			this.treeDataGridView_0.Dock = DockStyle.Fill;
			this.treeDataGridView_0.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.treeDataGridView_0.ImageList = null;
			this.treeDataGridView_0.Location = new Point(0, 25);
			this.treeDataGridView_0.MultiSelect = false;
			this.treeDataGridView_0.Name = "trvDgvSpan";
			this.treeDataGridView_0.RowHeadersVisible = false;
			this.treeDataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.treeDataGridView_0.Size = new Size(509, 160);
			this.treeDataGridView_0.TabIndex = 1;
			this.treeDataGridView_0.CellDoubleClick += this.treeDataGridView_0_CellDoubleClick;
			this.treeDataGridView_0.CellPainting += this.treeDataGridView_0_CellPainting;
			this.treeGridColumn_0.DataPropertyName = "id";
			this.treeGridColumn_0.DefaultNodeImage = null;
			this.treeGridColumn_0.HeaderText = "idSpan";
			this.treeGridColumn_0.Name = "idSpan";
			this.treeGridColumn_0.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.treeGridColumn_0.Visible = false;
			this.treeGridColumn_1.DataPropertyName = "idObjList";
			this.treeGridColumn_1.DefaultNodeImage = null;
			this.treeGridColumn_1.HeaderText = "idObjListSpan";
			this.treeGridColumn_1.Name = "idObjListSpan";
			this.treeGridColumn_1.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.treeGridColumn_1.Visible = false;
			this.treeGridColumn_2.DataPropertyName = "idPoleFirst";
			this.treeGridColumn_2.DefaultNodeImage = null;
			this.treeGridColumn_2.HeaderText = "idPoleFirstSpan";
			this.treeGridColumn_2.Name = "idPoleFirstSpan";
			this.treeGridColumn_2.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.treeGridColumn_2.Visible = false;
			this.treeGridColumn_3.DataPropertyName = "idPoleSecond";
			this.treeGridColumn_3.DefaultNodeImage = null;
			this.treeGridColumn_3.HeaderText = "idPoleSecondSpan";
			this.treeGridColumn_3.Name = "idPoleSecondSpan";
			this.treeGridColumn_3.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.treeGridColumn_3.Visible = false;
			this.treeGridColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.treeGridColumn_4.DataPropertyName = "Number";
			this.treeGridColumn_4.DefaultNodeImage = null;
			this.treeGridColumn_4.HeaderText = "Номер пролета";
			this.treeGridColumn_4.Name = "NumberSpan";
			this.treeGridColumn_4.Resizable = DataGridViewTriState.True;
			this.treeGridColumn_4.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.treeGridColumn_4.Width = 82;
			this.dataGridViewTextBoxColumn_64.DataPropertyName = "NamePoleFirst";
			this.dataGridViewTextBoxColumn_64.HeaderText = "Опора";
			this.dataGridViewTextBoxColumn_64.Name = "NamePoleFirstSpan";
			this.dataGridViewTextBoxColumn_64.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_64.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_64.Width = 60;
			this.dataGridViewTextBoxColumn_65.DataPropertyName = "NamePoleSecond";
			this.dataGridViewTextBoxColumn_65.HeaderText = "Опора";
			this.dataGridViewTextBoxColumn_65.Name = "NamePoleSecondSpan";
			this.dataGridViewTextBoxColumn_65.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_65.Width = 60;
			this.dataGridViewTextBoxColumn_66.DataPropertyName = "CableMakeup";
			this.dataGridViewTextBoxColumn_66.HeaderText = "Марка провода";
			this.dataGridViewTextBoxColumn_66.Name = "CableMakeupSpan";
			this.dataGridViewTextBoxColumn_66.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_66.Width = 90;
			this.dataGridViewTextBoxColumn_67.DataPropertyName = "Voltage";
			this.dataGridViewTextBoxColumn_67.HeaderText = "Рабочее напряжение";
			this.dataGridViewTextBoxColumn_67.Name = "VoltageSpan";
			this.dataGridViewTextBoxColumn_67.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_67.Width = 70;
			this.dataGridViewTextBoxColumn_68.DataPropertyName = "Wires";
			this.dataGridViewTextBoxColumn_68.HeaderText = "Количество жил";
			this.dataGridViewTextBoxColumn_68.Name = "WiresSpan";
			this.dataGridViewTextBoxColumn_68.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_68.Width = 70;
			this.dataGridViewTextBoxColumn_69.DataPropertyName = "CrossSection";
			this.dataGridViewTextBoxColumn_69.HeaderText = "Сечение жил";
			this.dataGridViewTextBoxColumn_69.Name = "CrossSectionSpan";
			this.dataGridViewTextBoxColumn_69.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_69.Width = 60;
			this.dataGridViewTextBoxColumn_70.DataPropertyName = "Length";
			this.dataGridViewTextBoxColumn_70.HeaderText = "Длина";
			this.dataGridViewTextBoxColumn_70.Name = "LengthSpan";
			this.dataGridViewTextBoxColumn_70.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_70.Width = 60;
			this.dataGridViewTextBoxColumn_71.DataPropertyName = "YearCommissioning";
			this.dataGridViewTextBoxColumn_71.HeaderText = "Год ввода в эксплуатацию";
			this.dataGridViewTextBoxColumn_71.Name = "YearCommissioningSpan";
			this.dataGridViewTextBoxColumn_71.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_72.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_72.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_72.Name = "CommentSpan";
			this.dataGridViewTextBoxColumn_72.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_72.Visible = false;
			this.dataGridViewTextBoxColumn_73.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_73.HeaderText = "DeletedSpan";
			this.dataGridViewTextBoxColumn_73.Name = "DeletedSpan";
			this.dataGridViewTextBoxColumn_73.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_73.Visible = false;
			this.contextMenuStrip_9.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_39,
				this.toolStripMenuItem_40,
				this.toolStripMenuItem_59,
				this.toolStripSeparator_55,
				this.toolStripMenuItem_41,
				this.toolStripSeparator_56,
				this.toolStripMenuItem_42
			});
			this.contextMenuStrip_9.Name = "cmsBuildRepair";
			this.contextMenuStrip_9.Size = new Size(155, 126);
			this.toolStripMenuItem_39.Image = Resources.smethod_24();
			this.toolStripMenuItem_39.Name = "tsmiAirLineSpanAdd";
			this.toolStripMenuItem_39.Size = new Size(154, 22);
			this.toolStripMenuItem_39.Text = "Добавить";
			this.toolStripMenuItem_39.Click += this.OlEcIrCmwq_Click;
			this.toolStripMenuItem_40.Image = Resources.smethod_26();
			this.toolStripMenuItem_40.Name = "tsmiAirLineSpanEdit";
			this.toolStripMenuItem_40.Size = new Size(154, 22);
			this.toolStripMenuItem_40.Text = "Редактировать";
			this.toolStripMenuItem_40.Click += this.toolStripButton_78_Click;
			this.toolStripMenuItem_59.Image = Resources.smethod_17();
			this.toolStripMenuItem_59.Name = "tsmiCopyLineSpan";
			this.toolStripMenuItem_59.Size = new Size(154, 22);
			this.toolStripMenuItem_59.Text = "Копировать";
			this.toolStripMenuItem_59.Click += this.VlMgyFgckb_Click;
			this.toolStripSeparator_55.Name = "tssAirLineSpanDelete";
			this.toolStripSeparator_55.Size = new Size(151, 6);
			this.toolStripMenuItem_41.Image = Resources.smethod_25();
			this.toolStripMenuItem_41.Name = "tsmiAirLineSpanDelete";
			this.toolStripMenuItem_41.Size = new Size(154, 22);
			this.toolStripMenuItem_41.Text = "Удалить";
			this.toolStripMenuItem_41.Click += this.toolStripButton_79_Click;
			this.toolStripSeparator_56.Name = "tssAirLineSpanRefresh";
			this.toolStripSeparator_56.Size = new Size(151, 6);
			this.toolStripMenuItem_42.Image = Resources.smethod_45();
			this.toolStripMenuItem_42.Name = "tsmiAirLineSpanRefresh";
			this.toolStripMenuItem_42.Size = new Size(154, 22);
			this.toolStripMenuItem_42.Text = "Обновить";
			this.toolStripMenuItem_42.Click += this.toolStripButton_80_Click;
			this.toolStrip_19.Items.AddRange(new ToolStripItem[]
			{
				this.OlEcIrCmwq,
				this.toolStripButton_78,
				this.VlMgyFgckb,
				this.toolStripDropDownButton_1,
				this.toolStripSeparator_51,
				this.toolStripButton_79,
				this.toolStripSeparator_52,
				this.toolStripButton_80,
				this.toolStripSeparator_64,
				this.toolStripButton_87,
				this.toolStripSeparator_87,
				this.toolStripLabel_7
			});
			this.toolStrip_19.Location = new Point(0, 0);
			this.toolStrip_19.Name = "tsLineSpan";
			this.toolStrip_19.Size = new Size(509, 25);
			this.toolStrip_19.TabIndex = 0;
			this.toolStrip_19.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.OlEcIrCmwq.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.OlEcIrCmwq.Image = Resources.smethod_24();
			this.OlEcIrCmwq.ImageTransparentColor = Color.Magenta;
			this.OlEcIrCmwq.Name = "tsbAddLineSpan";
			this.OlEcIrCmwq.Size = new Size(23, 22);
			this.OlEcIrCmwq.Text = "Добавить пролет";
			this.OlEcIrCmwq.Click += this.OlEcIrCmwq_Click;
			this.toolStripButton_78.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_78.Image = Resources.smethod_26();
			this.toolStripButton_78.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_78.Name = "tsbEditLineSpan";
			this.toolStripButton_78.Size = new Size(23, 22);
			this.toolStripButton_78.Text = "Редактировать пролет";
			this.toolStripButton_78.Click += this.toolStripButton_78_Click;
			this.VlMgyFgckb.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.VlMgyFgckb.Image = Resources.smethod_17();
			this.VlMgyFgckb.ImageTransparentColor = Color.Magenta;
			this.VlMgyFgckb.Name = "tsBtnCopyLineSpan";
			this.VlMgyFgckb.Size = new Size(23, 22);
			this.VlMgyFgckb.Text = "Копировать пролет";
			this.VlMgyFgckb.Click += this.VlMgyFgckb_Click;
			this.toolStripDropDownButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton_1.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_60,
				this.toolStripMenuItem_61
			});
			this.toolStripDropDownButton_1.Image = Resources.smethod_1();
			this.toolStripDropDownButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripDropDownButton_1.Name = "tsddAddPylonInSpan";
			this.toolStripDropDownButton_1.Size = new Size(29, 22);
			this.toolStripDropDownButton_1.Text = "Добавить опору в пролет";
			this.toolStripMenuItem_60.Name = "tsmiAddPylonInSpan";
			this.toolStripMenuItem_60.Size = new Size(163, 22);
			this.toolStripMenuItem_60.Text = "Добавить опору";
			this.toolStripMenuItem_60.Click += this.toolStripMenuItem_60_Click;
			this.toolStripMenuItem_61.Name = "tsmiInsPylonInSpan";
			this.toolStripMenuItem_61.Size = new Size(163, 22);
			this.toolStripMenuItem_61.Text = "Вставить опору";
			this.toolStripMenuItem_61.Click += this.KdufyFstaY;
			this.toolStripSeparator_51.Name = "tssDeleteLineSpan";
			this.toolStripSeparator_51.Size = new Size(6, 25);
			this.toolStripButton_79.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_79.Image = Resources.smethod_25();
			this.toolStripButton_79.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_79.Name = "tsbDeleteLineSpan";
			this.toolStripButton_79.Size = new Size(23, 22);
			this.toolStripButton_79.Text = "Удалить";
			this.toolStripButton_79.Click += this.toolStripButton_79_Click;
			this.toolStripSeparator_52.Name = "tssRefreshLineSpan";
			this.toolStripSeparator_52.Size = new Size(6, 25);
			this.toolStripButton_80.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_80.Image = Resources.smethod_45();
			this.toolStripButton_80.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_80.Name = "tsbRefreshLineSpan";
			this.toolStripButton_80.Size = new Size(23, 22);
			this.toolStripButton_80.Text = "Обновить";
			this.toolStripButton_80.Click += this.toolStripButton_80_Click;
			this.toolStripSeparator_64.Name = "toolStripSeparator21";
			this.toolStripSeparator_64.Size = new Size(6, 25);
			this.toolStripButton_87.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_87.Image = (Image)componentResourceManager.GetObject("tsbLineSpanHistory.Image");
			this.toolStripButton_87.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_87.Name = "tsbLineSpanHistory";
			this.toolStripButton_87.Size = new Size(23, 22);
			this.toolStripButton_87.Text = "История паспортов объекта";
			this.toolStripButton_87.Click += this.toolStripButton_87_Click;
			this.toolStripSeparator_87.Name = "toolStripSeparator40";
			this.toolStripSeparator_87.Size = new Size(6, 25);
			this.toolStripLabel_7.Name = "tsLblAirLineSpanLength";
			this.toolStripLabel_7.Size = new Size(28, 22);
			this.toolStripLabel_7.Text = "0 м.";
			this.splitContainer_3.Dock = DockStyle.Fill;
			this.splitContainer_3.Location = new Point(0, 0);
			this.splitContainer_3.Name = "scAirLine2";
			this.splitContainer_3.Orientation = Orientation.Horizontal;
			this.splitContainer_3.Panel1.Controls.Add(this.tabControl_6);
			this.splitContainer_3.Panel2.Controls.Add(this.dataGridViewExcelFilter_9);
			this.splitContainer_3.Panel2.Controls.Add(this.toolStrip_25);
			this.splitContainer_3.Size = new Size(509, 284);
			this.splitContainer_3.SplitterDistance = 160;
			this.splitContainer_3.TabIndex = 0;
			this.tabControl_6.Controls.Add(this.tabPage_28);
			this.tabControl_6.Controls.Add(this.tabPage_29);
			this.tabControl_6.Dock = DockStyle.Fill;
			this.tabControl_6.Location = new Point(0, 0);
			this.tabControl_6.Multiline = true;
			this.tabControl_6.Name = "tabControl1";
			this.tabControl_6.SelectedIndex = 0;
			this.tabControl_6.Size = new Size(509, 160);
			this.tabControl_6.TabIndex = 2;
			this.tabPage_28.Controls.Add(this.dataGridViewExcelFilter_8);
			this.tabPage_28.Controls.Add(this.toolStrip_18);
			this.tabPage_28.Location = new Point(4, 22);
			this.tabPage_28.Name = "tpPylones";
			this.tabPage_28.Padding = new Padding(3);
			this.tabPage_28.Size = new Size(501, 134);
			this.tabPage_28.TabIndex = 0;
			this.tabPage_28.Text = "Опоры";
			this.tabPage_28.UseVisualStyleBackColor = true;
			this.dataGridViewExcelFilter_8.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_8.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_8.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_8.BackgroundColor = Color.White;
			dataGridViewCellStyle75.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle75.BackColor = SystemColors.Control;
			dataGridViewCellStyle75.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle75.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle75.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle75.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle75.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_8.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle75;
			this.dataGridViewExcelFilter_8.Columns.AddRange(new DataGridViewColumn[]
			{
				this.luZgbmDwv7,
				this.dataGridViewTextBoxColumn_181,
				this.dataGridViewTextBoxColumn_182,
				this.dataGridViewTextBoxColumn_183,
				this.dataGridViewTextBoxColumn_184,
				this.dataGridViewTextBoxColumn_185,
				this.dataGridViewTextBoxColumn_186
			});
			this.dataGridViewExcelFilter_8.ContextMenuStrip = this.contextMenuStrip_8;
			dataGridViewCellStyle76.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle76.BackColor = SystemColors.Window;
			dataGridViewCellStyle76.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle76.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle76.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle76.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle76.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_8.DefaultCellStyle = dataGridViewCellStyle76;
			this.dataGridViewExcelFilter_8.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_8.Location = new Point(3, 28);
			this.dataGridViewExcelFilter_8.MultiSelect = false;
			this.dataGridViewExcelFilter_8.Name = "dgvLinePole";
			this.dataGridViewExcelFilter_8.ReadOnly = true;
			dataGridViewCellStyle77.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle77.BackColor = SystemColors.Control;
			dataGridViewCellStyle77.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle77.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle77.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle77.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle77.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle77.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_8.RowHeadersDefaultCellStyle = dataGridViewCellStyle77;
			this.dataGridViewExcelFilter_8.RowHeadersWidth = 25;
			this.dataGridViewExcelFilter_8.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_8.Size = new Size(495, 103);
			this.dataGridViewExcelFilter_8.TabIndex = 1;
			this.dataGridViewExcelFilter_8.CellContextMenuStripNeeded += this.dataGridViewExcelFilter_8_CellContextMenuStripNeeded;
			this.dataGridViewExcelFilter_8.CellDoubleClick += this.dataGridViewExcelFilter_8_CellDoubleClick;
			this.dataGridViewExcelFilter_8.SelectionChanged += this.dataGridViewExcelFilter_8_SelectionChanged;
			this.luZgbmDwv7.DataPropertyName = "id";
			this.luZgbmDwv7.HeaderText = "idPole";
			this.luZgbmDwv7.Name = "idPole";
			this.luZgbmDwv7.ReadOnly = true;
			this.luZgbmDwv7.Visible = false;
			this.dataGridViewTextBoxColumn_181.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_181.HeaderText = "idObjListPole";
			this.dataGridViewTextBoxColumn_181.Name = "idObjListPole";
			this.dataGridViewTextBoxColumn_181.ReadOnly = true;
			this.dataGridViewTextBoxColumn_181.Visible = false;
			this.dataGridViewTextBoxColumn_182.DataPropertyName = "IdEquipment";
			this.dataGridViewTextBoxColumn_182.HeaderText = "IdEquipment";
			this.dataGridViewTextBoxColumn_182.Name = "IdEquipmentPole";
			this.dataGridViewTextBoxColumn_182.ReadOnly = true;
			this.dataGridViewTextBoxColumn_182.Visible = false;
			this.dataGridViewTextBoxColumn_183.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_183.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_183.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_183.MinimumWidth = 100;
			this.dataGridViewTextBoxColumn_183.Name = "NamePole";
			this.dataGridViewTextBoxColumn_183.ReadOnly = true;
			this.dataGridViewTextBoxColumn_184.DataPropertyName = "typeName";
			this.dataGridViewTextBoxColumn_184.HeaderText = "Тип опоры";
			this.dataGridViewTextBoxColumn_184.Name = "typeName";
			this.dataGridViewTextBoxColumn_184.ReadOnly = true;
			this.dataGridViewTextBoxColumn_184.Width = 150;
			this.dataGridViewTextBoxColumn_185.DataPropertyName = "countBranch";
			this.dataGridViewTextBoxColumn_185.HeaderText = "Кол-во отводов";
			this.dataGridViewTextBoxColumn_185.Name = "countBranchDgvLinePole";
			this.dataGridViewTextBoxColumn_185.ReadOnly = true;
			this.dataGridViewTextBoxColumn_186.DataPropertyName = "countObjBranch";
			this.dataGridViewTextBoxColumn_186.HeaderText = "Кол-во объектов на отводах";
			this.dataGridViewTextBoxColumn_186.Name = "countObjBranchDgvLinePole";
			this.dataGridViewTextBoxColumn_186.ReadOnly = true;
			this.contextMenuStrip_8.Items.AddRange(new ToolStripItem[]
			{
				this.odScMgvaDL,
				this.toolStripMenuItem_36,
				this.toolStripMenuItem_58,
				this.toolStripSeparator_53,
				this.toolStripMenuItem_55,
				this.toolStripSeparator_80,
				this.toolStripMenuItem_37,
				this.toolStripSeparator_54,
				this.toolStripMenuItem_38
			});
			this.contextMenuStrip_8.Name = "cmsBuildRepair";
			this.contextMenuStrip_8.Size = new Size(169, 154);
			this.odScMgvaDL.Image = Resources.smethod_24();
			this.odScMgvaDL.Name = "tsmiAirLinePoleAdd";
			this.odScMgvaDL.Size = new Size(168, 22);
			this.odScMgvaDL.Text = "Добавить";
			this.odScMgvaDL.Click += this.toolStripButton_75_Click;
			this.toolStripMenuItem_36.Image = Resources.smethod_26();
			this.toolStripMenuItem_36.Name = "tsmiAirLinePoleEdit";
			this.toolStripMenuItem_36.Size = new Size(168, 22);
			this.toolStripMenuItem_36.Text = "Редактировать";
			this.toolStripMenuItem_36.Click += this.toolStripButton_76_Click;
			this.toolStripMenuItem_58.Image = Resources.smethod_17();
			this.toolStripMenuItem_58.Name = "tsmiCopyAirLinePole";
			this.toolStripMenuItem_58.Size = new Size(168, 22);
			this.toolStripMenuItem_58.Text = "Копировать";
			this.toolStripMenuItem_58.Click += this.toolStripButton_128_Click;
			this.toolStripSeparator_53.Name = "tssAirLinePoleDelete";
			this.toolStripSeparator_53.Size = new Size(165, 6);
			this.toolStripMenuItem_55.Image = Resources.smethod_1();
			this.toolStripMenuItem_55.Name = "tsBtnAddPylonEquip";
			this.toolStripMenuItem_55.Size = new Size(168, 22);
			this.toolStripMenuItem_55.Text = "Добавить обор-е";
			this.toolStripMenuItem_55.Click += this.toolStripMenuItem_51_Click;
			this.toolStripSeparator_80.Name = "toolStripSeparator33";
			this.toolStripSeparator_80.Size = new Size(165, 6);
			this.toolStripMenuItem_37.Image = Resources.smethod_25();
			this.toolStripMenuItem_37.Name = "tsmiAirLinePoleDelete";
			this.toolStripMenuItem_37.Size = new Size(168, 22);
			this.toolStripMenuItem_37.Text = "Удалить";
			this.toolStripMenuItem_37.Click += this.toolStripButton_77_Click;
			this.toolStripSeparator_54.Name = "tssAirLinePoleRefresh";
			this.toolStripSeparator_54.Size = new Size(165, 6);
			this.toolStripMenuItem_38.Image = Resources.smethod_45();
			this.toolStripMenuItem_38.Name = "tsmiAirLinePoleRefresh";
			this.toolStripMenuItem_38.Size = new Size(168, 22);
			this.toolStripMenuItem_38.Text = "Обновить";
			this.toolStripMenuItem_38.Click += this.GoscVscjdc_Click;
			this.toolStrip_18.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_75,
				this.toolStripButton_76,
				this.toolStripButton_128,
				this.toolStripSeparator_49,
				this.toolStripButton_77,
				this.toolStripSeparator_50,
				this.GoscVscjdc,
				this.toolStripSeparator_61,
				this.toolStripButton_84
			});
			this.toolStrip_18.Location = new Point(3, 3);
			this.toolStrip_18.Name = "tsLinePole";
			this.toolStrip_18.Size = new Size(495, 25);
			this.toolStrip_18.TabIndex = 0;
			this.toolStrip_18.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_75.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_75.Image = Resources.smethod_24();
			this.toolStripButton_75.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_75.Name = "tsbAddLinePole";
			this.toolStripButton_75.Size = new Size(23, 22);
			this.toolStripButton_75.Text = "Добавить опору";
			this.toolStripButton_75.Click += this.toolStripButton_75_Click;
			this.toolStripButton_76.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_76.Image = Resources.smethod_26();
			this.toolStripButton_76.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_76.Name = "tsbEditLinePole";
			this.toolStripButton_76.Size = new Size(23, 22);
			this.toolStripButton_76.Text = "Редактировать опору";
			this.toolStripButton_76.Click += this.toolStripButton_76_Click;
			this.toolStripButton_128.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_128.Image = Resources.smethod_17();
			this.toolStripButton_128.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_128.Name = "tsBtnCopyLinePole";
			this.toolStripButton_128.Size = new Size(23, 22);
			this.toolStripButton_128.Text = "Копировать опору";
			this.toolStripButton_128.Click += this.toolStripButton_128_Click;
			this.toolStripSeparator_49.Name = "tssDeleteLinePole";
			this.toolStripSeparator_49.Size = new Size(6, 25);
			this.toolStripButton_77.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_77.Image = Resources.smethod_25();
			this.toolStripButton_77.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_77.Name = "tsbDeleteLinePole";
			this.toolStripButton_77.Size = new Size(23, 22);
			this.toolStripButton_77.Text = "Удалить опору";
			this.toolStripButton_77.Click += this.toolStripButton_77_Click;
			this.toolStripSeparator_50.Name = "tssRefreshLinePole";
			this.toolStripSeparator_50.Size = new Size(6, 25);
			this.GoscVscjdc.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.GoscVscjdc.Image = Resources.smethod_45();
			this.GoscVscjdc.ImageTransparentColor = Color.Magenta;
			this.GoscVscjdc.Name = "tsbRefreshLinePole";
			this.GoscVscjdc.Size = new Size(23, 22);
			this.GoscVscjdc.Text = "Обновить список опор";
			this.GoscVscjdc.Click += this.GoscVscjdc_Click;
			this.toolStripSeparator_61.Name = "toolStripSeparator18";
			this.toolStripSeparator_61.Size = new Size(6, 25);
			this.toolStripButton_84.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_84.Image = (Image)componentResourceManager.GetObject("toolStripButton2.Image");
			this.toolStripButton_84.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_84.Name = "toolStripButton2";
			this.toolStripButton_84.Size = new Size(23, 22);
			this.toolStripButton_84.Text = "История паспортов опоры";
			this.toolStripButton_84.Click += this.toolStripButton_84_Click;
			this.tabPage_29.Controls.Add(this.dataGridView_14);
			this.tabPage_29.Controls.Add(this.toolStrip_33);
			this.tabPage_29.Location = new Point(4, 22);
			this.tabPage_29.Name = "tpJointSuspension";
			this.tabPage_29.Padding = new Padding(3);
			this.tabPage_29.Size = new Size(501, 134);
			this.tabPage_29.TabIndex = 1;
			this.tabPage_29.Text = "Совместная подвеска";
			this.tabPage_29.UseVisualStyleBackColor = true;
			this.dataGridView_14.AllowUserToAddRows = false;
			this.dataGridView_14.AllowUserToDeleteRows = false;
			this.dataGridView_14.BackgroundColor = SystemColors.Window;
			dataGridViewCellStyle78.Alignment = DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle78.BackColor = SystemColors.Control;
			dataGridViewCellStyle78.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle78.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle78.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle78.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle78.WrapMode = DataGridViewTriState.True;
			this.dataGridView_14.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle78;
			this.dataGridView_14.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_177,
				this.dataGridViewTextBoxColumn_178,
				this.dataGridViewTextBoxColumn_179,
				this.obfgdCvgpL,
				this.dataGridViewTextBoxColumn_180
			});
			dataGridViewCellStyle79.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle79.BackColor = SystemColors.Window;
			dataGridViewCellStyle79.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle79.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle79.SelectionBackColor = SystemColors.HighlightText;
			dataGridViewCellStyle79.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle79.WrapMode = DataGridViewTriState.False;
			this.dataGridView_14.DefaultCellStyle = dataGridViewCellStyle79;
			this.dataGridView_14.Dock = DockStyle.Fill;
			this.dataGridView_14.Location = new Point(3, 28);
			this.dataGridView_14.Name = "dgvJointSuspension";
			this.dataGridView_14.ReadOnly = true;
			this.dataGridView_14.RowHeadersVisible = false;
			this.dataGridView_14.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_14.Size = new Size(495, 103);
			this.dataGridView_14.TabIndex = 1;
			this.dataGridViewTextBoxColumn_177.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewTextBoxColumn_177.DataPropertyName = "name";
			this.dataGridViewTextBoxColumn_177.HeaderText = "Назначение сторонней линии";
			this.dataGridViewTextBoxColumn_177.Name = "nameDgvJointSuspension";
			this.dataGridViewTextBoxColumn_177.ReadOnly = true;
			this.dataGridViewTextBoxColumn_178.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewTextBoxColumn_178.DataPropertyName = "напряжение";
			this.dataGridViewTextBoxColumn_178.HeaderText = "Напряжение сторонней линии";
			this.dataGridViewTextBoxColumn_178.Name = "напряжениеDgvJointSuspension";
			this.dataGridViewTextBoxColumn_178.ReadOnly = true;
			this.dataGridViewTextBoxColumn_179.DataPropertyName = "poleNum";
			this.dataGridViewTextBoxColumn_179.HeaderText = "№ опор";
			this.dataGridViewTextBoxColumn_179.Name = "poleNumDgvJointSuspension";
			this.dataGridViewTextBoxColumn_179.ReadOnly = true;
			this.obfgdCvgpL.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.obfgdCvgpL.DataPropertyName = "маркаКабеля";
			this.obfgdCvgpL.HeaderText = "Марка кабеля сторонней линии";
			this.obfgdCvgpL.Name = "маркаКабеляDgvJointSuspension";
			this.obfgdCvgpL.ReadOnly = true;
			this.dataGridViewTextBoxColumn_180.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewTextBoxColumn_180.DataPropertyName = "wireDistance";
			this.dataGridViewTextBoxColumn_180.HeaderText = "Расстоняние между проводами ВЛ и сторонней линией";
			this.dataGridViewTextBoxColumn_180.Name = "wireDistanceDgvJointSuspension";
			this.dataGridViewTextBoxColumn_180.ReadOnly = true;
			this.dataGridViewTextBoxColumn_180.Width = 120;
			this.toolStrip_33.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_156
			});
			this.toolStrip_33.Location = new Point(3, 3);
			this.toolStrip_33.Name = "tsJointSuspension";
			this.toolStrip_33.Size = new Size(495, 25);
			this.toolStrip_33.TabIndex = 0;
			this.toolStrip_33.Text = "toolStrip1";
			this.toolStripButton_156.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_156.Image = Resources.smethod_45();
			this.toolStripButton_156.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_156.Name = "tsBtnRefreshJointSuspension";
			this.toolStripButton_156.Size = new Size(23, 22);
			this.toolStripButton_156.Text = "Обновить";
			this.toolStripButton_156.Click += this.toolStripButton_156_Click;
			this.dataGridViewExcelFilter_9.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_9.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_9.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_9.BackgroundColor = Color.White;
			dataGridViewCellStyle80.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle80.BackColor = SystemColors.Control;
			dataGridViewCellStyle80.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle80.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle80.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle80.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle80.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_9.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle80;
			this.dataGridViewExcelFilter_9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_9.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_113,
				this.dataGridViewTextBoxColumn_114,
				this.dataGridViewTextBoxColumn_115,
				this.dataGridViewTextBoxColumn_116,
				this.dataGridViewTextBoxColumn_117,
				this.dataGridViewTextBoxColumn_118,
				this.dataGridViewTextBoxColumn_119
			});
			this.dataGridViewExcelFilter_9.ContextMenuStrip = this.contextMenuStrip_13;
			dataGridViewCellStyle81.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle81.BackColor = SystemColors.Window;
			dataGridViewCellStyle81.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle81.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle81.SelectionBackColor = SystemColors.Window;
			dataGridViewCellStyle81.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle81.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_9.DefaultCellStyle = dataGridViewCellStyle81;
			this.dataGridViewExcelFilter_9.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_9.Location = new Point(0, 25);
			this.dataGridViewExcelFilter_9.MultiSelect = false;
			this.dataGridViewExcelFilter_9.Name = "dgvPylonEquipment";
			this.dataGridViewExcelFilter_9.ReadOnly = true;
			dataGridViewCellStyle82.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle82.BackColor = SystemColors.Control;
			dataGridViewCellStyle82.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle82.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle82.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle82.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle82.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle82.WrapMode = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_9.RowHeadersDefaultCellStyle = dataGridViewCellStyle82;
			this.dataGridViewExcelFilter_9.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridViewExcelFilter_9.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_9.Size = new Size(509, 95);
			this.dataGridViewExcelFilter_9.TabIndex = 2;
			this.dataGridViewExcelFilter_9.CellContextMenuStripNeeded += this.dataGridViewExcelFilter_9_CellContextMenuStripNeeded;
			this.dataGridViewExcelFilter_9.CellDoubleClick += this.dataGridViewExcelFilter_9_CellDoubleClick;
			this.dataGridViewTextBoxColumn_113.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_113.HeaderText = "idObjList";
			this.dataGridViewTextBoxColumn_113.Name = "idObjListColumn";
			this.dataGridViewTextBoxColumn_113.ReadOnly = true;
			this.dataGridViewTextBoxColumn_113.Visible = false;
			this.dataGridViewTextBoxColumn_114.DataPropertyName = "idObjListEquipment";
			this.dataGridViewTextBoxColumn_114.HeaderText = "idObjListPole";
			this.dataGridViewTextBoxColumn_114.Name = "dataGridViewTextBoxColumn876";
			this.dataGridViewTextBoxColumn_114.ReadOnly = true;
			this.dataGridViewTextBoxColumn_114.Visible = false;
			this.dataGridViewTextBoxColumn_115.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_115.HeaderText = "idPylonEquipment";
			this.dataGridViewTextBoxColumn_115.Name = "dgvtbcIdPylonEquipment";
			this.dataGridViewTextBoxColumn_115.ReadOnly = true;
			this.dataGridViewTextBoxColumn_115.Visible = false;
			this.dataGridViewTextBoxColumn_116.DataPropertyName = "idEquipment";
			this.dataGridViewTextBoxColumn_116.HeaderText = "idEquipment";
			this.dataGridViewTextBoxColumn_116.Name = "idEquipmentColumn";
			this.dataGridViewTextBoxColumn_116.ReadOnly = true;
			this.dataGridViewTextBoxColumn_116.Visible = false;
			this.dataGridViewTextBoxColumn_117.DataPropertyName = "pylon";
			this.dataGridViewTextBoxColumn_117.HeaderText = "Опора";
			this.dataGridViewTextBoxColumn_117.Name = "pylonColumn";
			this.dataGridViewTextBoxColumn_117.ReadOnly = true;
			this.dataGridViewTextBoxColumn_118.DataPropertyName = "typeCode";
			this.dataGridViewTextBoxColumn_118.HeaderText = "Оборудование";
			this.dataGridViewTextBoxColumn_118.MinimumWidth = 150;
			this.dataGridViewTextBoxColumn_118.Name = "typecodePyloneEquipment";
			this.dataGridViewTextBoxColumn_118.ReadOnly = true;
			this.dataGridViewTextBoxColumn_118.Width = 150;
			this.dataGridViewTextBoxColumn_119.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_119.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_119.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_119.MinimumWidth = 100;
			this.dataGridViewTextBoxColumn_119.Name = "namePylonEquipment";
			this.dataGridViewTextBoxColumn_119.ReadOnly = true;
			this.contextMenuStrip_13.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_51,
				this.toolStripMenuItem_52,
				this.toolStripMenuItem_53,
				this.toolStripSeparator_79,
				this.toolStripMenuItem_54
			});
			this.contextMenuStrip_13.Name = "cmsPylonEquipment";
			this.contextMenuStrip_13.Size = new Size(155, 98);
			this.toolStripMenuItem_51.Image = Resources.smethod_24();
			this.toolStripMenuItem_51.Name = "tlStripAddPylonEquipment";
			this.toolStripMenuItem_51.Size = new Size(154, 22);
			this.toolStripMenuItem_51.Text = "Добавить";
			this.toolStripMenuItem_51.Click += this.toolStripMenuItem_51_Click;
			this.toolStripMenuItem_52.Image = Resources.smethod_26();
			this.toolStripMenuItem_52.Name = "tlStripEditPylonEquipment";
			this.toolStripMenuItem_52.Size = new Size(154, 22);
			this.toolStripMenuItem_52.Text = "Редактировать";
			this.toolStripMenuItem_52.Click += this.toolStripButton_108_Click;
			this.toolStripMenuItem_53.Image = Resources.smethod_25();
			this.toolStripMenuItem_53.Name = "tlStripDelPylonEquipment";
			this.toolStripMenuItem_53.Size = new Size(154, 22);
			this.toolStripMenuItem_53.Text = "Удалить";
			this.toolStripMenuItem_53.Click += this.toolStripMenuItem_53_Click;
			this.toolStripSeparator_79.Name = "toolStripSeparator32";
			this.toolStripSeparator_79.Size = new Size(151, 6);
			this.toolStripMenuItem_54.Image = Resources.smethod_45();
			this.toolStripMenuItem_54.Name = "tlStripRefreshPylonEquipment";
			this.toolStripMenuItem_54.Size = new Size(154, 22);
			this.toolStripMenuItem_54.Text = "Обновить";
			this.toolStripMenuItem_54.Click += this.toolStripButton_110_Click;
			this.toolStrip_25.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_107,
				this.toolStripButton_108,
				this.toolStripSeparator_76,
				this.toolStripButton_109,
				this.toolStripSeparator_77,
				this.toolStripButton_110,
				this.toolStripSeparator_78,
				this.toolStripButton_111
			});
			this.toolStrip_25.Location = new Point(0, 0);
			this.toolStrip_25.Name = "tsPylonEquipment";
			this.toolStrip_25.Size = new Size(509, 25);
			this.toolStrip_25.TabIndex = 1;
			this.toolStrip_25.Text = "Панель инструментов вкладки \"Ремонт\"";
			this.toolStripButton_107.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_107.Image = Resources.smethod_24();
			this.toolStripButton_107.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_107.Name = "tsbAddPylonEquipment";
			this.toolStripButton_107.Size = new Size(23, 22);
			this.toolStripButton_107.Text = "Добавить оборудование";
			this.toolStripButton_107.Click += this.toolStripButton_107_Click;
			this.toolStripButton_108.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_108.Image = Resources.smethod_26();
			this.toolStripButton_108.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_108.Name = "tsbEditPylonEquipment";
			this.toolStripButton_108.Size = new Size(23, 22);
			this.toolStripButton_108.Text = "Редактировать оборудование";
			this.toolStripButton_108.Click += this.toolStripButton_108_Click;
			this.toolStripSeparator_76.Name = "tssPylonEquipment1";
			this.toolStripSeparator_76.Size = new Size(6, 25);
			this.toolStripButton_109.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_109.Image = Resources.smethod_25();
			this.toolStripButton_109.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_109.Name = "tsbDelPylonEquipment";
			this.toolStripButton_109.Size = new Size(23, 22);
			this.toolStripButton_109.Text = "Удалить";
			this.toolStripButton_109.Click += this.toolStripButton_110_Click;
			this.toolStripSeparator_77.Name = "tssPylonEquipment2";
			this.toolStripSeparator_77.Size = new Size(6, 25);
			this.toolStripButton_110.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_110.Image = Resources.smethod_45();
			this.toolStripButton_110.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_110.Name = "tsbRefreshPylonEquipment";
			this.toolStripButton_110.Size = new Size(23, 22);
			this.toolStripButton_110.Text = "Обновить";
			this.toolStripButton_110.Click += this.toolStripButton_110_Click;
			this.toolStripSeparator_78.Name = "tssPylonEquipment3";
			this.toolStripSeparator_78.Size = new Size(6, 25);
			this.toolStripButton_111.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_111.Enabled = false;
			this.toolStripButton_111.Image = (Image)componentResourceManager.GetObject("toolStripButton6.Image");
			this.toolStripButton_111.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_111.Name = "toolStripButton6";
			this.toolStripButton_111.Size = new Size(23, 22);
			this.toolStripButton_111.Text = "toolStripButton1";
			this.toolStripButton_111.Visible = false;
			this.tabPage_1.Controls.Add(this.dataGridView_1);
			this.tabPage_1.Controls.Add(this.toolStrip_1);
			this.tabPage_1.Location = new Point(4, 22);
			this.tabPage_1.Name = "tpDocuments";
			this.tabPage_1.Padding = new Padding(3);
			this.tabPage_1.Size = new Size(509, 473);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "Документы";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.dataGridView_1.BackgroundColor = Color.White;
			dataGridViewCellStyle83.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle83.BackColor = SystemColors.Control;
			dataGridViewCellStyle83.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle83.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle83.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle83.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle83.WrapMode = DataGridViewTriState.True;
			this.dataGridView_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle83;
			this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle84.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle84.BackColor = SystemColors.Window;
			dataGridViewCellStyle84.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle84.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle84.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle84.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle84.WrapMode = DataGridViewTriState.False;
			this.dataGridView_1.DefaultCellStyle = dataGridViewCellStyle84;
			this.dataGridView_1.Dock = DockStyle.Fill;
			this.dataGridView_1.GridColor = Color.White;
			this.dataGridView_1.Location = new Point(3, 3);
			this.dataGridView_1.Name = "dgvDocuments";
			this.dataGridView_1.Size = new Size(503, 442);
			this.dataGridView_1.TabIndex = 3;
			this.toolStrip_1.Dock = DockStyle.Bottom;
			this.toolStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripSplitButton_0,
				this.toolStripButton_1,
				this.toolStripButton_2,
				this.fdPuJwPsYx,
				this.toolStripButton_3
			});
			this.toolStrip_1.Location = new Point(3, 445);
			this.toolStrip_1.Name = "ObjDoctoolStrip";
			this.toolStrip_1.Size = new Size(503, 25);
			this.toolStrip_1.TabIndex = 2;
			this.toolStrip_1.Text = "Документы объекта";
			this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0
			});
			this.toolStripSplitButton_0.Image = (Image)componentResourceManager.GetObject("tssbPasspDocAdd.Image");
			this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripSplitButton_0.Name = "tssbPasspDocAdd";
			this.toolStripSplitButton_0.Size = new Size(32, 22);
			this.toolStripSplitButton_0.Text = "Добавление";
			this.toolStripSplitButton_0.TextImageRelation = TextImageRelation.TextAboveImage;
			this.toolStripMenuItem_0.Name = "протоколИспытанияИзоляцииСиловыхКабелейToolStripMenuItem";
			this.toolStripMenuItem_0.Size = new Size(346, 22);
			this.toolStripMenuItem_0.Text = "Протокол испытания изоляции силовых кабелей";
			this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = (Image)componentResourceManager.GetObject("tsbPasspDocEdit.Image");
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "tsbPasspDocEdit";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Редактирование";
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = (Image)componentResourceManager.GetObject("tsbPasspDocDel.Image");
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "tsbPasspDocDel";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Удалить";
			this.fdPuJwPsYx.Alignment = ToolStripItemAlignment.Right;
			this.fdPuJwPsYx.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.fdPuJwPsYx.Image = (Image)componentResourceManager.GetObject("tsbPasspDocPrint.Image");
			this.fdPuJwPsYx.ImageTransparentColor = Color.Magenta;
			this.fdPuJwPsYx.Name = "tsbPasspDocPrint";
			this.fdPuJwPsYx.Size = new Size(23, 22);
			this.fdPuJwPsYx.Text = "Печать";
			this.toolStripButton_3.Alignment = ToolStripItemAlignment.Right;
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = (Image)componentResourceManager.GetObject("tsbPasspDocInfo.Image");
			this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_3.Name = "tsbPasspDocInfo";
			this.toolStripButton_3.Size = new Size(23, 22);
			this.toolStripButton_3.Text = "Информация";
			this.tabPage_12.Controls.Add(this.tableLayoutPanel_13);
			this.tabPage_12.Controls.Add(this.toolStrip_16);
			this.tabPage_12.Location = new Point(4, 22);
			this.tabPage_12.Name = "tpImage";
			this.tabPage_12.Padding = new Padding(3);
			this.tabPage_12.Size = new Size(509, 473);
			this.tabPage_12.TabIndex = 3;
			this.tabPage_12.Text = "Изображение";
			this.tabPage_12.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_13.ColumnCount = 2;
			this.tableLayoutPanel_13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.41036f));
			this.tableLayoutPanel_13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.58964f));
			this.tableLayoutPanel_13.Controls.Add(this.dataGridView_9, 0, 0);
			this.tableLayoutPanel_13.Dock = DockStyle.Fill;
			this.tableLayoutPanel_13.Location = new Point(3, 3);
			this.tableLayoutPanel_13.Name = "tableLayoutPanel4";
			this.tableLayoutPanel_13.RowCount = 2;
			this.tableLayoutPanel_13.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_13.RowStyles.Add(new RowStyle(SizeType.Absolute, 245f));
			this.tableLayoutPanel_13.Size = new Size(503, 467);
			this.tableLayoutPanel_13.TabIndex = 5;
			this.dataGridView_9.AllowUserToAddRows = false;
			this.dataGridView_9.AllowUserToDeleteRows = false;
			this.dataGridView_9.AutoGenerateColumns = false;
			this.dataGridView_9.BackgroundColor = Color.White;
			this.dataGridView_9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_9.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewImageColumn_0,
				this.dataGridViewLinkColumn_0,
				this.yvucnefnbB,
				this.dataGridViewTextBoxColumn_44,
				this.dataGridViewTextBoxColumn_45,
				this.dataGridViewTextBoxColumn_46,
				this.dataGridViewTextBoxColumn_47
			});
			this.tableLayoutPanel_13.SetColumnSpan(this.dataGridView_9, 2);
			this.dataGridView_9.DataSource = this.bindingSource_4;
			this.dataGridView_9.Dock = DockStyle.Fill;
			this.dataGridView_9.GridColor = Color.White;
			this.dataGridView_9.Location = new Point(3, 3);
			this.dataGridView_9.Name = "dgvImage";
			this.dataGridView_9.ReadOnly = true;
			this.dataGridView_9.RowHeadersVisible = false;
			this.tableLayoutPanel_13.SetRowSpan(this.dataGridView_9, 2);
			this.dataGridView_9.Size = new Size(497, 461);
			this.dataGridView_9.TabIndex = 1;
			this.dataGridView_9.Click += this.dataGridView_9_Click;
			this.dataGridViewImageColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumn_0.DataPropertyName = "Icon";
			this.dataGridViewImageColumn_0.HeaderText = "Иконка";
			this.dataGridViewImageColumn_0.Name = "iconDataGridViewImageColumn";
			this.dataGridViewImageColumn_0.ReadOnly = true;
			this.dataGridViewImageColumn_0.Width = 51;
			this.dataGridViewLinkColumn_0.DataPropertyName = "id";
			this.dataGridViewLinkColumn_0.HeaderText = "";
			this.dataGridViewLinkColumn_0.Name = "links";
			this.dataGridViewLinkColumn_0.ReadOnly = true;
			this.dataGridViewLinkColumn_0.Resizable = DataGridViewTriState.True;
			this.yvucnefnbB.DataPropertyName = "Deleted";
			this.yvucnefnbB.HeaderText = "Deleted";
			this.yvucnefnbB.Name = "deletedDataGridViewCheckBoxColumn";
			this.yvucnefnbB.ReadOnly = true;
			this.yvucnefnbB.Visible = false;
			this.dataGridViewTextBoxColumn_44.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_44.HeaderText = "id";
			this.dataGridViewTextBoxColumn_44.Name = "idDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_44.ReadOnly = true;
			this.dataGridViewTextBoxColumn_44.Visible = false;
			this.dataGridViewTextBoxColumn_45.DataPropertyName = "idPasspDoc";
			this.dataGridViewTextBoxColumn_45.HeaderText = "idPasspDoc";
			this.dataGridViewTextBoxColumn_45.Name = "idPasspDocDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_45.ReadOnly = true;
			this.dataGridViewTextBoxColumn_45.Visible = false;
			this.dataGridViewTextBoxColumn_46.DataPropertyName = "DateIn";
			this.dataGridViewTextBoxColumn_46.HeaderText = "DateIn";
			this.dataGridViewTextBoxColumn_46.Name = "dateInDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_46.ReadOnly = true;
			this.dataGridViewTextBoxColumn_46.Visible = false;
			this.dataGridViewTextBoxColumn_47.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_47.DataPropertyName = "FileName";
			this.dataGridViewTextBoxColumn_47.HeaderText = "Наименование файла";
			this.dataGridViewTextBoxColumn_47.Name = "fileNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_47.ReadOnly = true;
			this.bindingSource_4.DataMember = "tP_Image";
			this.bindingSource_4.DataSource = this.class107_0;
			this.toolStrip_16.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_67,
				this.toolStripButton_68,
				this.toolStripButton_70,
				this.toolStripButton_69
			});
			this.toolStrip_16.Location = new Point(3, 3);
			this.toolStrip_16.Name = "tsImage";
			this.toolStrip_16.Size = new Size(502, 25);
			this.toolStrip_16.TabIndex = 4;
			this.toolStrip_16.Text = "toolStrip1";
			this.toolStrip_16.Visible = false;
			this.toolStripButton_67.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_67.Image = Resources.smethod_24();
			this.toolStripButton_67.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_67.Name = "tsbFileAdd";
			this.toolStripButton_67.Size = new Size(23, 22);
			this.toolStripButton_67.Text = "Добавить изображение";
			this.toolStripButton_67.Click += this.toolStripButton_67_Click;
			this.toolStripButton_68.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_68.Image = Resources.smethod_25();
			this.toolStripButton_68.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_68.Name = "tsbFileDelete";
			this.toolStripButton_68.Size = new Size(23, 22);
			this.toolStripButton_68.Text = "Удалить";
			this.toolStripButton_68.Click += this.toolStripButton_68_Click;
			this.toolStripButton_70.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_70.Image = Resources.smethod_49();
			this.toolStripButton_70.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_70.Name = "tsbShow";
			this.toolStripButton_70.Size = new Size(23, 22);
			this.toolStripButton_70.Text = "toolStripButton1";
			this.toolStripButton_70.Click += this.toolStripButton_70_Click;
			this.toolStripButton_69.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_69.Image = Resources.smethod_22();
			this.toolStripButton_69.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_69.Name = "tsbImageSettings";
			this.toolStripButton_69.Size = new Size(23, 22);
			this.toolStripButton_69.Text = "Настройки сжатия изображения";
			this.toolStripButton_69.Visible = false;
			this.toolStripButton_69.Click += this.toolStripButton_69_Click;
			this.tabPage_24.Controls.Add(this.tabControl_5);
			this.tabPage_24.Location = new Point(4, 22);
			this.tabPage_24.Name = "tpPPR";
			this.tabPage_24.Size = new Size(509, 473);
			this.tabPage_24.TabIndex = 6;
			this.tabPage_24.Text = "ППР";
			this.tabPage_24.UseVisualStyleBackColor = true;
			this.tabControl_5.Controls.Add(this.tabPage_25);
			this.tabControl_5.Controls.Add(this.tabPage_26);
			this.tabControl_5.Dock = DockStyle.Fill;
			this.tabControl_5.Location = new Point(0, 0);
			this.tabControl_5.Name = "tcPPR";
			this.tabControl_5.SelectedIndex = 0;
			this.tabControl_5.Size = new Size(509, 473);
			this.tabControl_5.TabIndex = 0;
			this.tabControl_5.SelectedIndexChanged += this.tabControl_5_SelectedIndexChanged;
			this.tabPage_25.Controls.Add(this.dataGridView_11);
			this.tabPage_25.Controls.Add(this.toolStrip_29);
			this.tabPage_25.Location = new Point(4, 22);
			this.tabPage_25.Name = "tpPlanPPR";
			this.tabPage_25.Padding = new Padding(3);
			this.tabPage_25.Size = new Size(501, 447);
			this.tabPage_25.TabIndex = 0;
			this.tabPage_25.Text = "Плановые работы";
			this.tabPage_25.UseVisualStyleBackColor = true;
			this.dataGridView_11.AllowUserToAddRows = false;
			this.dataGridView_11.AllowUserToDeleteRows = false;
			this.dataGridView_11.AutoGenerateColumns = false;
			this.dataGridView_11.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dataGridView_11.BackgroundColor = SystemColors.Window;
			dataGridViewCellStyle85.Alignment = DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle85.BackColor = SystemColors.Control;
			dataGridViewCellStyle85.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle85.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle85.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle85.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle85.WrapMode = DataGridViewTriState.True;
			this.dataGridView_11.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle85;
			this.dataGridView_11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_11.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_8,
				this.dataGridViewTextBoxColumn_158,
				this.dataGridViewTextBoxColumn_159,
				this.dataGridViewTextBoxColumn_160,
				this.dataGridViewTextBoxColumn_161,
				this.dataGridViewTextBoxColumn_162,
				this.dataGridViewTextBoxColumn_163
			});
			this.dataGridView_11.DataSource = this.bindingSource_12;
			dataGridViewCellStyle86.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle86.BackColor = SystemColors.Window;
			dataGridViewCellStyle86.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle86.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle86.SelectionBackColor = SystemColors.HighlightText;
			dataGridViewCellStyle86.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle86.WrapMode = DataGridViewTriState.False;
			this.dataGridView_11.DefaultCellStyle = dataGridViewCellStyle86;
			this.dataGridView_11.Dock = DockStyle.Fill;
			this.dataGridView_11.Location = new Point(3, 28);
			this.dataGridView_11.MultiSelect = false;
			this.dataGridView_11.Name = "dgvPlanPPR";
			this.dataGridView_11.ReadOnly = true;
			dataGridViewCellStyle87.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle87.BackColor = SystemColors.Control;
			dataGridViewCellStyle87.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle87.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle87.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle87.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle87.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle87.WrapMode = DataGridViewTriState.True;
			this.dataGridView_11.RowHeadersDefaultCellStyle = dataGridViewCellStyle87;
			this.dataGridView_11.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridView_11.SelectionMode = DataGridViewSelectionMode.CellSelect;
			this.dataGridView_11.Size = new Size(495, 416);
			this.dataGridView_11.TabIndex = 1;
			this.dataGridView_11.CellDoubleClick += this.dataGridView_12_CellDoubleClick;
			this.dataGridViewCheckBoxColumn_8.DataPropertyName = "deleted";
			this.dataGridViewCheckBoxColumn_8.HeaderText = "deleted";
			this.dataGridViewCheckBoxColumn_8.Name = "deletedDgvPlanPPR";
			this.dataGridViewCheckBoxColumn_8.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_8.Visible = false;
			this.dataGridViewCheckBoxColumn_8.Width = 48;
			this.dataGridViewTextBoxColumn_158.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_158.HeaderText = "id";
			this.dataGridViewTextBoxColumn_158.Name = "idDgvPlanPPR";
			this.dataGridViewTextBoxColumn_158.ReadOnly = true;
			this.dataGridViewTextBoxColumn_158.Visible = false;
			this.dataGridViewTextBoxColumn_158.Width = 40;
			this.dataGridViewTextBoxColumn_159.DataPropertyName = "docNumber";
			this.dataGridViewTextBoxColumn_159.HeaderText = "Номер документа";
			this.dataGridViewTextBoxColumn_159.Name = "docNumberDgvPlanPPR";
			this.dataGridViewTextBoxColumn_159.ReadOnly = true;
			this.dataGridViewTextBoxColumn_159.Width = 113;
			this.dataGridViewTextBoxColumn_160.DataPropertyName = "dateDoc";
			this.dataGridViewTextBoxColumn_160.HeaderText = "Дата документа";
			this.dataGridViewTextBoxColumn_160.Name = "dateDocDgvPlanPPR";
			this.dataGridViewTextBoxColumn_160.ReadOnly = true;
			this.dataGridViewTextBoxColumn_160.Width = 105;
			this.dataGridViewTextBoxColumn_161.DataPropertyName = "idSchmObj";
			this.dataGridViewTextBoxColumn_161.HeaderText = "idSchmObj";
			this.dataGridViewTextBoxColumn_161.Name = "idSchmObjDgvPlanPPR";
			this.dataGridViewTextBoxColumn_161.ReadOnly = true;
			this.dataGridViewTextBoxColumn_161.Visible = false;
			this.dataGridViewTextBoxColumn_161.Width = 83;
			this.dataGridViewTextBoxColumn_162.DataPropertyName = "dateWork";
			this.dataGridViewTextBoxColumn_162.HeaderText = "Дата работ";
			this.dataGridViewTextBoxColumn_162.Name = "dateWorkDgvPlanPPR";
			this.dataGridViewTextBoxColumn_162.ReadOnly = true;
			this.dataGridViewTextBoxColumn_162.Width = 83;
			this.dataGridViewTextBoxColumn_163.DataPropertyName = "docType";
			this.dataGridViewTextBoxColumn_163.HeaderText = "docType";
			this.dataGridViewTextBoxColumn_163.Name = "docTypeDgvPlanPPR";
			this.dataGridViewTextBoxColumn_163.ReadOnly = true;
			this.dataGridViewTextBoxColumn_163.Visible = false;
			this.dataGridViewTextBoxColumn_163.Width = 74;
			this.bindingSource_12.DataMember = "tDocPPR";
			this.bindingSource_12.DataSource = this.dataSet_0;
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
				this.SuUdfiJawF,
				this.dataColumn_3,
				this.dataColumn_4,
				this.IeBdYdknAT
			});
			this.dataTable_0.TableName = "tDocPPR";
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.AutoIncrementSeed = -1L;
			this.dataColumn_0.AutoIncrementStep = -1L;
			this.dataColumn_0.ColumnName = "id";
			this.dataColumn_0.DataType = typeof(int);
			this.dataColumn_0.ReadOnly = true;
			this.dataColumn_1.ColumnName = "docNumber";
			this.dataColumn_1.DataType = typeof(int);
			this.dataColumn_2.ColumnName = "dateDoc";
			this.dataColumn_2.DataType = typeof(DateTime);
			this.SuUdfiJawF.ColumnName = "idSchmObj";
			this.SuUdfiJawF.DataType = typeof(int);
			this.dataColumn_3.ColumnName = "dateWork";
			this.dataColumn_3.DataType = typeof(DateTime);
			this.dataColumn_4.ColumnName = "docType";
			this.dataColumn_4.DataType = typeof(int);
			this.IeBdYdknAT.ColumnName = "deleted";
			this.IeBdYdknAT.DataType = typeof(bool);
			this.toolStrip_29.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_29.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_129,
				this.toolStripButton_130,
				this.toolStripButton_131,
				this.toolStripSeparator_88,
				this.toolStripButton_132,
				this.toolStripSeparator_98,
				this.toolStripButton_155
			});
			this.toolStrip_29.Location = new Point(3, 3);
			this.toolStrip_29.Name = "tsPlanPPR";
			this.toolStrip_29.Size = new Size(495, 25);
			this.toolStrip_29.TabIndex = 0;
			this.toolStripButton_129.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_129.Image = Resources.smethod_24();
			this.toolStripButton_129.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_129.Name = "tsBtnAddPlanPPR";
			this.toolStripButton_129.Size = new Size(23, 22);
			this.toolStripButton_129.Text = "Добавить документ";
			this.toolStripButton_129.Click += this.toolStripButton_133_Click;
			this.toolStripButton_130.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_130.Image = Resources.smethod_26();
			this.toolStripButton_130.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_130.Name = "tsBtnEditPlanPPR";
			this.toolStripButton_130.Size = new Size(23, 22);
			this.toolStripButton_130.Text = "Редактировать документ";
			this.toolStripButton_130.Click += this.toolStripButton_134_Click;
			this.toolStripButton_131.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_131.Image = Resources.smethod_25();
			this.toolStripButton_131.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_131.Name = "tsBtnDelPlanPPR";
			this.toolStripButton_131.Size = new Size(23, 22);
			this.toolStripButton_131.Text = "Удалить документ";
			this.toolStripButton_131.Click += this.toolStripButton_135_Click;
			this.toolStripSeparator_88.Name = "toolStripSeparator41";
			this.toolStripSeparator_88.Size = new Size(6, 25);
			this.toolStripButton_132.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_132.Image = Resources.smethod_45();
			this.toolStripButton_132.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_132.Name = "tsBtnRafreshPlanPPR";
			this.toolStripButton_132.Size = new Size(23, 22);
			this.toolStripButton_132.Text = "Обновить таблицу";
			this.toolStripButton_132.Click += this.toolStripButton_136_Click;
			this.toolStripSeparator_98.Name = "toolStripSeparator43";
			this.toolStripSeparator_98.Size = new Size(6, 25);
			this.toolStripSeparator_98.Visible = false;
			this.toolStripButton_155.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_155.Image = Resources.smethod_48();
			this.toolStripButton_155.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_155.Name = "tsBtnReportDocPPR";
			this.toolStripButton_155.Size = new Size(23, 22);
			this.toolStripButton_155.Text = "Отчет ППР";
			this.toolStripButton_155.Visible = false;
			this.toolStripButton_155.Click += this.toolStripButton_155_Click;
			this.tabPage_26.Controls.Add(this.dataGridView_12);
			this.tabPage_26.Controls.Add(this.toolStrip_30);
			this.tabPage_26.Location = new Point(4, 22);
			this.tabPage_26.Name = "tpFactPPR";
			this.tabPage_26.Padding = new Padding(3);
			this.tabPage_26.Size = new Size(501, 447);
			this.tabPage_26.TabIndex = 1;
			this.tabPage_26.Text = "Выполненные работы";
			this.tabPage_26.UseVisualStyleBackColor = true;
			this.dataGridView_12.AllowUserToAddRows = false;
			this.dataGridView_12.AllowUserToDeleteRows = false;
			this.dataGridView_12.AutoGenerateColumns = false;
			this.dataGridView_12.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dataGridView_12.BackgroundColor = SystemColors.Window;
			dataGridViewCellStyle88.Alignment = DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle88.BackColor = SystemColors.Control;
			dataGridViewCellStyle88.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle88.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle88.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle88.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle88.WrapMode = DataGridViewTriState.True;
			this.dataGridView_12.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle88;
			this.dataGridView_12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_12.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_9,
				this.dataGridViewTextBoxColumn_164,
				this.dataGridViewTextBoxColumn_165,
				this.dataGridViewTextBoxColumn_166,
				this.dataGridViewTextBoxColumn_167,
				this.dataGridViewTextBoxColumn_168,
				this.dataGridViewTextBoxColumn_169
			});
			this.dataGridView_12.DataSource = this.bindingSource_12;
			dataGridViewCellStyle89.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle89.BackColor = SystemColors.Window;
			dataGridViewCellStyle89.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle89.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle89.SelectionBackColor = SystemColors.HighlightText;
			dataGridViewCellStyle89.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle89.WrapMode = DataGridViewTriState.False;
			this.dataGridView_12.DefaultCellStyle = dataGridViewCellStyle89;
			this.dataGridView_12.Dock = DockStyle.Fill;
			this.dataGridView_12.Location = new Point(3, 28);
			this.dataGridView_12.MultiSelect = false;
			this.dataGridView_12.Name = "dgvFactPPR";
			this.dataGridView_12.ReadOnly = true;
			dataGridViewCellStyle90.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle90.BackColor = SystemColors.Control;
			dataGridViewCellStyle90.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle90.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle90.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle90.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle90.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle90.WrapMode = DataGridViewTriState.True;
			this.dataGridView_12.RowHeadersDefaultCellStyle = dataGridViewCellStyle90;
			this.dataGridView_12.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridView_12.SelectionMode = DataGridViewSelectionMode.CellSelect;
			this.dataGridView_12.Size = new Size(495, 416);
			this.dataGridView_12.TabIndex = 1;
			this.dataGridView_12.CellDoubleClick += this.dataGridView_12_CellDoubleClick;
			this.dataGridViewCheckBoxColumn_9.DataPropertyName = "deleted";
			this.dataGridViewCheckBoxColumn_9.HeaderText = "deleted";
			this.dataGridViewCheckBoxColumn_9.Name = "deletedDgvFactPPR";
			this.dataGridViewCheckBoxColumn_9.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_9.Visible = false;
			this.dataGridViewCheckBoxColumn_9.Width = 48;
			this.dataGridViewTextBoxColumn_164.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_164.HeaderText = "id";
			this.dataGridViewTextBoxColumn_164.Name = "idDgvFactPPR";
			this.dataGridViewTextBoxColumn_164.ReadOnly = true;
			this.dataGridViewTextBoxColumn_164.Visible = false;
			this.dataGridViewTextBoxColumn_164.Width = 40;
			this.dataGridViewTextBoxColumn_165.DataPropertyName = "docNumber";
			this.dataGridViewTextBoxColumn_165.HeaderText = "Номер документа";
			this.dataGridViewTextBoxColumn_165.Name = "docNumberDgvFactPPR";
			this.dataGridViewTextBoxColumn_165.ReadOnly = true;
			this.dataGridViewTextBoxColumn_165.Width = 113;
			this.dataGridViewTextBoxColumn_166.DataPropertyName = "dateDoc";
			this.dataGridViewTextBoxColumn_166.HeaderText = "Дата документа";
			this.dataGridViewTextBoxColumn_166.Name = "dateDocDgvFactPPR";
			this.dataGridViewTextBoxColumn_166.ReadOnly = true;
			this.dataGridViewTextBoxColumn_166.Width = 105;
			this.dataGridViewTextBoxColumn_167.DataPropertyName = "idSchmObj";
			this.dataGridViewTextBoxColumn_167.HeaderText = "idSchmObj";
			this.dataGridViewTextBoxColumn_167.Name = "idSchmObjDgvFactPPR";
			this.dataGridViewTextBoxColumn_167.ReadOnly = true;
			this.dataGridViewTextBoxColumn_167.Visible = false;
			this.dataGridViewTextBoxColumn_167.Width = 83;
			this.dataGridViewTextBoxColumn_168.DataPropertyName = "dateWork";
			this.dataGridViewTextBoxColumn_168.HeaderText = "Дата работ";
			this.dataGridViewTextBoxColumn_168.Name = "dateWorkDgvFactPPR";
			this.dataGridViewTextBoxColumn_168.ReadOnly = true;
			this.dataGridViewTextBoxColumn_168.Width = 83;
			this.dataGridViewTextBoxColumn_169.DataPropertyName = "docType";
			this.dataGridViewTextBoxColumn_169.HeaderText = "docType";
			this.dataGridViewTextBoxColumn_169.Name = "docTypeDgvFactPPR";
			this.dataGridViewTextBoxColumn_169.ReadOnly = true;
			this.dataGridViewTextBoxColumn_169.Visible = false;
			this.dataGridViewTextBoxColumn_169.Width = 74;
			this.toolStrip_30.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_30.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_133,
				this.toolStripButton_134,
				this.toolStripButton_135,
				this.toolStripSeparator_89,
				this.toolStripButton_136
			});
			this.toolStrip_30.Location = new Point(3, 3);
			this.toolStrip_30.Name = "tsFactPPR";
			this.toolStrip_30.Size = new Size(495, 25);
			this.toolStrip_30.TabIndex = 0;
			this.toolStrip_30.Text = "toolStrip1";
			this.toolStripButton_133.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_133.Image = Resources.smethod_24();
			this.toolStripButton_133.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_133.Name = "tsBtnAddFactPPR";
			this.toolStripButton_133.Size = new Size(23, 22);
			this.toolStripButton_133.Text = "Добавит документ";
			this.toolStripButton_133.Click += this.toolStripButton_133_Click;
			this.toolStripButton_134.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_134.Image = Resources.smethod_26();
			this.toolStripButton_134.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_134.Name = "tsBtnEditFactPPR";
			this.toolStripButton_134.Size = new Size(23, 22);
			this.toolStripButton_134.Text = "Редактировать документ";
			this.toolStripButton_134.Click += this.toolStripButton_134_Click;
			this.toolStripButton_135.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_135.Image = Resources.smethod_25();
			this.toolStripButton_135.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_135.Name = "tsBtnDelFactPPR";
			this.toolStripButton_135.Size = new Size(23, 22);
			this.toolStripButton_135.Text = "Удалить документ";
			this.toolStripButton_135.Click += this.toolStripButton_135_Click;
			this.toolStripSeparator_89.Name = "toolStripSeparator42";
			this.toolStripSeparator_89.Size = new Size(6, 25);
			this.toolStripButton_136.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_136.Image = Resources.smethod_45();
			this.toolStripButton_136.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_136.Name = "tsBtnRefreshFactPPR";
			this.toolStripButton_136.Size = new Size(23, 22);
			this.toolStripButton_136.Text = "Обновть таблицу";
			this.toolStripButton_136.Click += this.toolStripButton_136_Click;
			this.tabPage_27.Controls.Add(this.dataGridView_13);
			this.tabPage_27.Controls.Add(this.toolStrip_32);
			this.tabPage_27.Location = new Point(4, 22);
			this.tabPage_27.Name = "tpFile";
			this.tabPage_27.Size = new Size(509, 473);
			this.tabPage_27.TabIndex = 7;
			this.tabPage_27.Text = "Файлы";
			this.tabPage_27.UseVisualStyleBackColor = true;
			this.dataGridView_13.AllowUserToAddRows = false;
			this.dataGridView_13.AllowUserToDeleteRows = false;
			this.dataGridView_13.AllowUserToOrderColumns = true;
			this.dataGridView_13.AutoGenerateColumns = false;
			this.dataGridView_13.BackgroundColor = SystemColors.Window;
			dataGridViewCellStyle91.Alignment = DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle91.BackColor = SystemColors.Control;
			dataGridViewCellStyle91.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle91.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle91.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle91.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle91.WrapMode = DataGridViewTriState.True;
			this.dataGridView_13.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle91;
			this.dataGridView_13.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_13.Columns.AddRange(new DataGridViewColumn[]
			{
				this.YowoatyOoV,
				this.dataGridViewTextBoxColumn_223,
				this.dataGridViewTextBoxColumn_224,
				this.dataGridViewImageColumn_1,
				this.dataGridViewTextBoxColumn_225,
				this.dataGridViewTextBoxColumn_226
			});
			this.dataGridView_13.DataSource = this.bindingSource_13;
			dataGridViewCellStyle92.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle92.BackColor = SystemColors.Window;
			dataGridViewCellStyle92.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle92.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle92.SelectionBackColor = SystemColors.HighlightText;
			dataGridViewCellStyle92.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle92.WrapMode = DataGridViewTriState.False;
			this.dataGridView_13.DefaultCellStyle = dataGridViewCellStyle92;
			this.dataGridView_13.Dock = DockStyle.Fill;
			this.dataGridView_13.Location = new Point(0, 25);
			this.dataGridView_13.MultiSelect = false;
			this.dataGridView_13.Name = "dgvFile";
			dataGridViewCellStyle93.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle93.BackColor = SystemColors.Control;
			dataGridViewCellStyle93.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle93.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle93.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle93.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle93.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle93.WrapMode = DataGridViewTriState.True;
			this.dataGridView_13.RowHeadersDefaultCellStyle = dataGridViewCellStyle93;
			this.dataGridView_13.RowHeadersVisible = false;
			this.dataGridView_13.SelectionMode = DataGridViewSelectionMode.CellSelect;
			this.dataGridView_13.Size = new Size(509, 448);
			this.dataGridView_13.TabIndex = 1;
			this.dataGridView_13.CellContentClick += this.dataGridView_13_CellContentClick;
			this.dataGridView_13.CellValueNeeded += this.dataGridView_13_CellValueNeeded;
			this.dataGridView_13.RowsAdded += this.dataGridView_13_RowsAdded;
			this.YowoatyOoV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.YowoatyOoV.DataPropertyName = "FileName";
			this.YowoatyOoV.FillWeight = 25f;
			this.YowoatyOoV.HeaderText = "Имя файла";
			this.YowoatyOoV.Name = "fileNameDgvFile";
			this.YowoatyOoV.ReadOnly = true;
			this.YowoatyOoV.Resizable = DataGridViewTriState.True;
			this.YowoatyOoV.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn_223.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_223.HeaderText = "id";
			this.dataGridViewTextBoxColumn_223.Name = "idDgvFile";
			this.dataGridViewTextBoxColumn_223.ReadOnly = true;
			this.dataGridViewTextBoxColumn_223.Visible = false;
			this.dataGridViewTextBoxColumn_224.DataPropertyName = "idObj";
			this.dataGridViewTextBoxColumn_224.HeaderText = "idObj";
			this.dataGridViewTextBoxColumn_224.Name = "idObjDgvFile";
			this.dataGridViewTextBoxColumn_224.Visible = false;
			this.dataGridViewImageColumn_1.HeaderText = "";
			this.dataGridViewImageColumn_1.ImageLayout = DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn_1.Name = "ColumnImageDgvFile";
			this.dataGridViewImageColumn_1.ReadOnly = true;
			this.dataGridViewImageColumn_1.Resizable = DataGridViewTriState.False;
			this.dataGridViewImageColumn_1.Width = 20;
			this.dataGridViewTextBoxColumn_225.DataPropertyName = "dateIn";
			this.dataGridViewTextBoxColumn_225.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_225.Name = "dateInDgvFile";
			this.dataGridViewTextBoxColumn_225.ReadOnly = true;
			this.dataGridViewTextBoxColumn_225.Visible = false;
			this.dataGridViewTextBoxColumn_225.Width = 90;
			this.dataGridViewTextBoxColumn_226.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_226.DataPropertyName = "comment";
			this.dataGridViewTextBoxColumn_226.FillWeight = 75f;
			this.dataGridViewTextBoxColumn_226.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_226.Name = "commentDgvFile";
			this.bindingSource_13.DataMember = "tSchm_ObjFile";
			this.bindingSource_13.DataSource = this.jtnAdxtlvN;
			this.toolStrip_32.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_32.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_151,
				this.toolStripButton_153,
				this.toolStripButton_152,
				this.toolStripButton_154
			});
			this.toolStrip_32.Location = new Point(0, 0);
			this.toolStrip_32.Name = "tsFile";
			this.toolStrip_32.Size = new Size(509, 25);
			this.toolStrip_32.TabIndex = 0;
			this.toolStrip_32.Text = "toolStrip1";
			this.toolStripButton_151.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_151.Image = Resources.smethod_24();
			this.toolStripButton_151.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_151.Name = "tsBtnAddFile";
			this.toolStripButton_151.Size = new Size(23, 22);
			this.toolStripButton_151.Text = "Добавить файл";
			this.toolStripButton_151.Click += this.toolStripButton_151_Click;
			this.toolStripButton_153.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_153.Image = Resources.smethod_28();
			this.toolStripButton_153.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_153.Name = "tsBtnViewFile";
			this.toolStripButton_153.Size = new Size(23, 22);
			this.toolStripButton_153.Text = "Открыть файл";
			this.toolStripButton_153.Click += this.toolStripButton_153_Click;
			this.toolStripButton_152.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_152.Image = Resources.smethod_25();
			this.toolStripButton_152.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_152.Name = "tsBtnDelFile";
			this.toolStripButton_152.Size = new Size(23, 22);
			this.toolStripButton_152.Text = "Удалить файл";
			this.toolStripButton_152.Click += this.toolStripButton_152_Click;
			this.toolStripButton_154.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_154.Image = Resources.smethod_29();
			this.toolStripButton_154.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_154.Name = "tsBtnSaveFileAs";
			this.toolStripButton_154.Size = new Size(23, 22);
			this.toolStripButton_154.Text = "Сохранить как...";
			this.toolStripButton_154.Click += this.toolStripButton_154_Click;
			this.imageList_0.ColorDepth = ColorDepth.Depth8Bit;
			this.imageList_0.ImageSize = new Size(16, 16);
			this.imageList_0.TransparentColor = Color.Transparent;
			this.contextMenuStrip_0.Name = "cmEquipment";
			this.contextMenuStrip_0.Size = new Size(61, 4);
			this.toolStrip_2.AutoSize = false;
			this.toolStrip_2.CanOverflow = false;
			this.toolStrip_2.Dock = DockStyle.None;
			this.toolStrip_2.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_2.Location = new Point(87, 3);
			this.toolStrip_2.Name = "miniToolStrip";
			this.toolStrip_2.Size = new Size(498, 25);
			this.toolStrip_2.TabIndex = 2;
			this.dataGridViewCheckBoxColumn_0.HeaderText = "IsGroupChar";
			this.dataGridViewCheckBoxColumn_0.Name = "IsGroupChar";
			this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_0.Visible = false;
			this.dateTimePicker_1.Location = new Point(208, 533);
			this.dateTimePicker_1.Name = "dtpCabOperationDate";
			this.dateTimePicker_1.Size = new Size(139, 20);
			this.dateTimePicker_1.TabIndex = 7;
			this.comboBox_0.Location = new Point(0, 0);
			this.comboBox_0.Name = "cbCabOperationReason";
			this.comboBox_0.Size = new Size(121, 21);
			this.comboBox_0.TabIndex = 0;
			this.backgroundWorker_0.WorkerSupportsCancellation = true;
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_1.WorkerSupportsCancellation = true;
			this.backgroundWorker_1.DoWork += this.backgroundWorker_1_DoWork;
			this.backgroundWorker_2.WorkerSupportsCancellation = true;
			this.backgroundWorker_2.DoWork += this.backgroundWorker_2_DoWork;
			this.LstNnlIwat.WorkerSupportsCancellation = true;
			this.LstNnlIwat.DoWork += this.LstNnlIwat_DoWork;
			this.backgroundWorker_3.WorkerSupportsCancellation = true;
			this.backgroundWorker_3.DoWork += this.backgroundWorker_3_DoWork;
			this.backgroundWorker_4.WorkerSupportsCancellation = true;
			this.backgroundWorker_4.DoWork += this.backgroundWorker_4_DoWork;
			this.backgroundWorker_5.WorkerSupportsCancellation = true;
			this.backgroundWorker_5.DoWork += this.backgroundWorker_5_DoWork;
			this.contextMenuStrip_11.Name = "cmsTree";
			this.contextMenuStrip_11.Size = new Size(61, 4);
			this.contextMenuStrip_12.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_45,
				this.toolStripSeparator_60,
				this.toolStripMenuItem_46
			});
			this.contextMenuStrip_12.Name = "cmsGeneral";
			this.contextMenuStrip_12.Size = new Size(172, 54);
			this.contextMenuStrip_12.Text = "Контекстное меню";
			this.toolStripMenuItem_45.Image = Resources.smethod_46();
			this.toolStripMenuItem_45.Name = "tsmiObjRename";
			this.toolStripMenuItem_45.Size = new Size(171, 22);
			this.toolStripMenuItem_45.Text = "Переименовать";
			this.toolStripMenuItem_45.Click += this.toolStripButton_149_Click;
			this.toolStripSeparator_60.Name = "tssMove";
			this.toolStripSeparator_60.Size = new Size(168, 6);
			this.toolStripMenuItem_46.Image = Resources.smethod_38();
			this.toolStripMenuItem_46.Name = "tsmiMapGo";
			this.toolStripMenuItem_46.Size = new Size(171, 22);
			this.toolStripMenuItem_46.Text = "Переход на схему";
			this.toolStripMenuItem_46.Click += this.toolStripButton_148_Click;
			this.backgroundWorker_6.WorkerSupportsCancellation = true;
			this.backgroundWorker_6.DoWork += this.backgroundWorker_6_DoWork;
			this.backgroundWorker_8.DoWork += this.backgroundWorker_8_DoWork;
			this.toolStripButton_137.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_137.Image = (Image)componentResourceManager.GetObject("tsbAddPassport.Image");
			this.toolStripButton_137.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_137.Name = "tsbAddPassport";
			this.toolStripButton_137.Size = new Size(23, 22);
			this.toolStripButton_137.Text = "Добавить паспорт";
			this.toolStripButton_137.Click += this.toolStripButton_137_Click;
			this.toolStripButton_138.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_138.Image = (Image)componentResourceManager.GetObject("tsbEditPassport.Image");
			this.toolStripButton_138.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_138.Name = "tsbEditPassport";
			this.toolStripButton_138.Size = new Size(23, 22);
			this.toolStripButton_138.Text = "Изменить паспорт";
			this.toolStripButton_138.Click += this.toolStripButton_138_Click;
			this.toolStripButton_139.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_139.Image = (Image)componentResourceManager.GetObject("tsbPassportDelete.Image");
			this.toolStripButton_139.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_139.Name = "tsbPassportDelete";
			this.toolStripButton_139.Size = new Size(23, 22);
			this.toolStripButton_139.Text = "Удалить паспорт";
			this.toolStripButton_139.Click += this.toolStripButton_139_Click;
			this.toolStripSeparator_90.Name = "tssPassportHistory";
			this.toolStripSeparator_90.Size = new Size(6, 25);
			this.toolStripButton_140.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_140.Image = (Image)componentResourceManager.GetObject("tsbPassportHistory.Image");
			this.toolStripButton_140.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_140.Name = "tsbPassportHistory";
			this.toolStripButton_140.Size = new Size(23, 22);
			this.toolStripButton_140.Text = "История паспортов объекта";
			this.toolStripButton_140.Click += this.toolStripButton_140_Click;
			this.toolStripSeparator_91.Name = "tssPassportPrint";
			this.toolStripSeparator_91.Size = new Size(6, 25);
			this.toolStripDropDownButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_56,
				this.toolStripMenuItem_57,
				this.toolStripMenuItem_62
			});
			this.toolStripDropDownButton_0.Image = Resources.smethod_44();
			this.toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripDropDownButton_0.Name = "tsbPassportPrint";
			this.toolStripDropDownButton_0.Size = new Size(29, 22);
			this.toolStripDropDownButton_0.Text = "Вывод на печать";
			this.toolStripDropDownButton_0.Click += this.toolStripDropDownButton_0_Click;
			this.toolStripMenuItem_56.Name = "tsmiPassportPrint";
			this.toolStripMenuItem_56.Size = new Size(218, 22);
			this.toolStripMenuItem_56.Text = "Паспорт";
			this.toolStripMenuItem_56.Click += this.toolStripMenuItem_56_Click;
			this.toolStripMenuItem_57.Name = "tsmiCabSectionPrint";
			this.toolStripMenuItem_57.Size = new Size(218, 22);
			this.toolStripMenuItem_57.Text = "Участки кабельной линии";
			this.toolStripMenuItem_57.Click += this.toolStripMenuItem_57_Click;
			this.toolStripMenuItem_62.Name = "tsmiPylonsReport";
			this.toolStripMenuItem_62.Size = new Size(218, 22);
			this.toolStripMenuItem_62.Text = "Поопорная ведомость";
			this.toolStripMenuItem_62.Click += this.toolStripMenuItem_62_Click;
			this.toolStripSeparator_92.Name = "tssPassportRefresh";
			this.toolStripSeparator_92.Size = new Size(6, 25);
			this.toolStripButton_141.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_141.Image = (Image)componentResourceManager.GetObject("tsbPassportRefresh.Image");
			this.toolStripButton_141.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_141.Name = "tsbPassportRefresh";
			this.toolStripButton_141.Size = new Size(23, 22);
			this.toolStripButton_141.Text = "Обновление данных";
			this.toolStripButton_141.Click += this.toolStripButton_141_Click;
			this.toolStripSeparator_93.Name = "tssHideToolTree";
			this.toolStripSeparator_93.Size = new Size(6, 25);
			this.toolStripButton_142.Checked = true;
			this.toolStripButton_142.CheckOnClick = true;
			this.toolStripButton_142.CheckState = CheckState.Checked;
			this.toolStripButton_142.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_142.Image = (Image)componentResourceManager.GetObject("tsbHideToolTree.Image");
			this.toolStripButton_142.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_142.Name = "tsbHideToolTree";
			this.toolStripButton_142.Size = new Size(23, 22);
			this.toolStripButton_142.Text = "Скрыть панель дерева";
			this.toolStripButton_142.Click += this.toolStripButton_142_Click;
			this.toolStripSeparator_94.Name = "tssSplitTabs";
			this.toolStripSeparator_94.Size = new Size(6, 25);
			this.toolStripButton_143.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_143.Image = (Image)componentResourceManager.GetObject("tsbSplitTabs.Image");
			this.toolStripButton_143.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_143.Name = "tsbSplitTabs";
			this.toolStripButton_143.Size = new Size(23, 22);
			this.toolStripButton_143.Text = "Разделить характеристики по вкладкам";
			this.toolStripButton_143.Click += this.toolStripButton_143_Click;
			this.toolStripSeparator_95.Name = "tssSwitchCount";
			this.toolStripSeparator_95.Size = new Size(6, 25);
			this.toolStripButton_144.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_144.Image = Resources.smethod_55();
			this.toolStripButton_144.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_144.Name = "tsbSwitchCount";
			this.toolStripButton_144.Size = new Size(23, 22);
			this.toolStripButton_144.Text = "Количество выключателей";
			this.toolStripButton_144.Click += this.toolStripButton_144_Click;
			this.toolStripButton_144.VisibleChanged += this.toolStripButton_144_VisibleChanged;
			this.toolStripSeparator_96.Name = "tssUnbindPassport";
			this.toolStripSeparator_96.Size = new Size(6, 25);
			this.toolStripButton_145.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_145.Image = Resources.smethod_15();
			this.toolStripButton_145.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_145.Name = "tsbUnbindPassport";
			this.toolStripButton_145.Size = new Size(23, 22);
			this.toolStripButton_145.Text = "Отвязать паспорт";
			this.toolStripButton_145.ToolTipText = "Отвязать паспорт";
			this.toolStripButton_145.Visible = false;
			this.toolStripButton_145.Click += this.toolStripButton_145_Click;
			this.toolStripButton_146.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_146.Image = Resources.smethod_14();
			this.toolStripButton_146.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_146.Name = "tsbBindPassport";
			this.toolStripButton_146.Size = new Size(23, 22);
			this.toolStripButton_146.Text = "Привязать паспорт";
			this.toolStripButton_146.Visible = false;
			this.toolStripButton_146.Click += this.toolStripButton_146_Click;
			this.toolStripButton_147.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_147.Image = Resources.smethod_4();
			this.toolStripButton_147.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_147.Name = "tsbLoadOldPassportCable";
			this.toolStripButton_147.Size = new Size(23, 22);
			this.toolStripButton_147.Text = "Загрузить из старой БД";
			this.toolStripButton_147.Click += this.pIwCtYoiRy;
			this.toolStripButton_148.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_148.Image = Resources.smethod_38();
			this.toolStripButton_148.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_148.Name = "tsbMapGo";
			this.toolStripButton_148.Size = new Size(23, 22);
			this.toolStripButton_148.Text = "Переход на схему";
			this.toolStripButton_148.Click += this.toolStripButton_148_Click;
			this.toolStripSeparator_97.Name = "toolStripSeparator9";
			this.toolStripSeparator_97.Size = new Size(6, 25);
			this.toolStripButton_149.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_149.Image = Resources.smethod_46();
			this.toolStripButton_149.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_149.Name = "tsbObjRename";
			this.toolStripButton_149.Size = new Size(23, 22);
			this.toolStripButton_149.Text = "Переименовать";
			this.toolStripButton_149.Click += this.toolStripButton_149_Click;
			this.toolStripButton_150.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_150.Image = Resources.smethod_54();
			this.toolStripButton_150.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_150.Name = "tsbBindReference";
			this.toolStripButton_150.Size = new Size(23, 22);
			this.toolStripButton_150.Text = "Привязать справочник материалов";
			this.toolStripButton_150.Click += this.toolStripButton_150_Click;
			this.toolStrip_31.BackColor = SystemColors.Control;
			this.toolStrip_31.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_137,
				this.toolStripButton_138,
				this.toolStripButton_139,
				this.toolStripSeparator_90,
				this.toolStripButton_140,
				this.toolStripSeparator_91,
				this.toolStripDropDownButton_0,
				this.toolStripSeparator_92,
				this.toolStripButton_141,
				this.toolStripSeparator_93,
				this.toolStripButton_142,
				this.toolStripSeparator_94,
				this.toolStripButton_143,
				this.toolStripSeparator_95,
				this.toolStripButton_144,
				this.toolStripSeparator_96,
				this.toolStripButton_145,
				this.toolStripButton_146,
				this.toolStripButton_147,
				this.toolStripButton_148,
				this.toolStripSeparator_97,
				this.toolStripButton_149,
				this.toolStripButton_150
			});
			this.toolStrip_31.Location = new Point(0, 0);
			this.toolStrip_31.Name = "tsMain";
			this.toolStrip_31.Size = new Size(785, 25);
			this.toolStrip_31.TabIndex = 6;
			this.toolStrip_31.Text = "Панель инструментов паспорта";
			this.class295_0.Boolean_0 = true;
			this.bindingSource_2.DataMember = "tP_ValueLists";
			this.bindingSource_2.DataSource = this.class107_0;
			this.bindingSource_2.Sort = "Name";
			this.bindingSource_6.DataMember = "tP_CabSection";
			this.bindingSource_6.DataSource = this.class107_0;
			this.contextMenuStrip_15.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_69,
				this.toolStripMenuItem_70,
				this.toolStripMenuItem_71,
				this.toolStripMenuItem_72
			});
			this.contextMenuStrip_15.Name = "cmsAirLineBalance";
			this.contextMenuStrip_15.Size = new Size(245, 92);
			this.toolStripMenuItem_69.Image = Resources.smethod_24();
			this.toolStripMenuItem_69.Name = "tsmiAddAirLineBalance";
			this.toolStripMenuItem_69.Size = new Size(244, 22);
			this.toolStripMenuItem_69.Text = "Принятие на баланс";
			this.toolStripMenuItem_69.Click += this.toolStripMenuItem_69_Click;
			this.toolStripMenuItem_70.Image = Resources.smethod_24();
			this.toolStripMenuItem_70.Name = "tsmiAddAirLineUpgrade";
			this.toolStripMenuItem_70.Size = new Size(244, 22);
			this.toolStripMenuItem_70.Text = "Модернизация/реконструкция";
			this.toolStripMenuItem_70.Click += this.toolStripMenuItem_70_Click;
			this.toolStripMenuItem_71.Image = Resources.smethod_26();
			this.toolStripMenuItem_71.Name = "tsmiEditAirLineBalance";
			this.toolStripMenuItem_71.Size = new Size(244, 22);
			this.toolStripMenuItem_71.Text = "Редактировать";
			this.toolStripMenuItem_71.Click += this.toolStripMenuItem_71_Click;
			this.toolStripMenuItem_72.Image = Resources.smethod_25();
			this.toolStripMenuItem_72.Name = "tsmiDelAirLineBalance";
			this.toolStripMenuItem_72.Size = new Size(244, 22);
			this.toolStripMenuItem_72.Text = "Удалить";
			this.toolStripMenuItem_72.Click += this.toolStripMenuItem_72_Click;
			this.dataGridViewTextBoxColumn_0.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_0.Name = "idChar";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_1.Name = "ParentIdChar";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_1.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_2.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_2.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_2.Name = "TabIndexChar";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_2.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_3.HeaderText = "NameChar";
			this.dataGridViewTextBoxColumn_3.Name = "NameChar";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_3.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_3.Visible = false;
			this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_4.FillWeight = 33f;
			this.dataGridViewTextBoxColumn_4.HeaderText = "ValueChar";
			this.dataGridViewTextBoxColumn_4.Name = "ValueChar";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_4.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.contextMenuStrip_18.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_85,
				this.toolStripMenuItem_86,
				this.toolStripMenuItem_87,
				this.toolStripMenuItem_88,
				this.toolStripSeparator_107,
				this.toolStripMenuItem_92
			});
			this.contextMenuStrip_18.Name = "cmsInspectAirLine";
			this.contextMenuStrip_18.Size = new Size(155, 120);
			this.contextMenuStrip_18.Click += this.contextMenuStrip_18_Click;
			this.toolStripMenuItem_85.Image = Resources.smethod_24();
			this.toolStripMenuItem_85.Name = "tsmiAddInspectAirLine";
			this.toolStripMenuItem_85.Size = new Size(154, 22);
			this.toolStripMenuItem_85.Text = "Добавить";
			this.toolStripMenuItem_85.Click += this.toolStripMenuItem_85_Click;
			this.toolStripMenuItem_86.Image = Resources.smethod_26();
			this.toolStripMenuItem_86.Name = "tsmiEditInspectAirLine";
			this.toolStripMenuItem_86.Size = new Size(154, 22);
			this.toolStripMenuItem_86.Text = "Редактировать";
			this.toolStripMenuItem_86.Click += this.toolStripMenuItem_86_Click;
			this.toolStripMenuItem_87.Image = Resources.smethod_25();
			this.toolStripMenuItem_87.Name = "tsmiDelInspectAirLine";
			this.toolStripMenuItem_87.Size = new Size(154, 22);
			this.toolStripMenuItem_87.Text = "Удалить";
			this.toolStripMenuItem_87.Click += this.toolStripMenuItem_87_Click;
			this.toolStripMenuItem_88.Image = Resources.smethod_45();
			this.toolStripMenuItem_88.Name = "tsmiRefreshInspectAirLine";
			this.toolStripMenuItem_88.Size = new Size(154, 22);
			this.toolStripMenuItem_88.Text = "Обновить";
			this.toolStripMenuItem_88.Click += this.toolStripMenuItem_88_Click;
			this.toolStripSeparator_107.Name = "toolStripSeparator48";
			this.toolStripSeparator_107.Size = new Size(151, 6);
			this.toolStripMenuItem_92.Image = Resources.smethod_44();
			this.toolStripMenuItem_92.Name = "tsmiPrintInspectAirLine";
			this.toolStripMenuItem_92.Size = new Size(154, 22);
			this.toolStripMenuItem_92.Text = "Отчет";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(785, 562);
			base.Controls.Add(this.toolStrip_31);
			base.Controls.Add(this.tableLayoutPanel_0);
			this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			base.Name = "FormDockPassport";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Паспорт ";
			base.FormClosing += this.FormDockPassport_FormClosing;
			base.Load += this.FormDockPassport_Load;
			base.Shown += this.FormDockPassport_Shown;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.splitContainer_0.Panel1.ResumeLayout(false);
			this.splitContainer_0.Panel2.ResumeLayout(false);
			this.splitContainer_0.ResumeLayout(false);
			this.tableLayoutPanel_1.ResumeLayout(false);
			this.tableLayoutPanel_1.PerformLayout();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.panel_0.ResumeLayout(false);
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.tableLayoutPanel_2.ResumeLayout(false);
			this.tableLayoutPanel_2.PerformLayout();
			this.ehAutNuOxy.ResumeLayout(false);
			this.ehAutNuOxy.PerformLayout();
			this.tabControl_2.ResumeLayout(false);
			this.tabPage_6.ResumeLayout(false);
			this.tableLayoutPanel_5.ResumeLayout(false);
			this.tableLayoutPanel_5.PerformLayout();
			((ISupportInitialize)this.dataGridView_2).EndInit();
			this.contextMenuStrip_1.ResumeLayout(false);
			this.toolStrip_8.ResumeLayout(false);
			this.toolStrip_8.PerformLayout();
			this.tabPage_7.ResumeLayout(false);
			this.tableLayoutPanel_6.ResumeLayout(false);
			this.tableLayoutPanel_6.PerformLayout();
			((ISupportInitialize)this.dataGridView_3).EndInit();
			this.contextMenuStrip_2.ResumeLayout(false);
			this.toolStrip_9.ResumeLayout(false);
			this.toolStrip_9.PerformLayout();
			this.tabPage_8.ResumeLayout(false);
			this.tableLayoutPanel_7.ResumeLayout(false);
			this.tableLayoutPanel_7.PerformLayout();
			((ISupportInitialize)this.dataGridView_4).EndInit();
			this.contextMenuStrip_3.ResumeLayout(false);
			this.toolStrip_10.ResumeLayout(false);
			this.toolStrip_10.PerformLayout();
			this.tabPage_9.ResumeLayout(false);
			this.tableLayoutPanel_9.ResumeLayout(false);
			this.tableLayoutPanel_9.PerformLayout();
			((ISupportInitialize)this.dataGridView_5).EndInit();
			this.contextMenuStrip_6.ResumeLayout(false);
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.class107_0).EndInit();
			this.ErxDoVobWm.ResumeLayout(false);
			this.ErxDoVobWm.PerformLayout();
			this.tabPage_10.ResumeLayout(false);
			this.tableLayoutPanel_10.ResumeLayout(false);
			this.tableLayoutPanel_10.PerformLayout();
			((ISupportInitialize)this.dataGridView_6).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			this.toolStrip_13.ResumeLayout(false);
			this.toolStrip_13.PerformLayout();
			this.pjuAjnsoym.ResumeLayout(false);
			this.tableLayoutPanel_11.ResumeLayout(false);
			this.tableLayoutPanel_11.PerformLayout();
			((ISupportInitialize)this.dataGridView_7).EndInit();
			this.contextMenuStrip_7.ResumeLayout(false);
			((ISupportInitialize)this.bindingSource_3).EndInit();
			((ISupportInitialize)this.jtnAdxtlvN).EndInit();
			this.toolStrip_14.ResumeLayout(false);
			this.toolStrip_14.PerformLayout();
			this.tabPage_11.ResumeLayout(false);
			this.tableLayoutPanel_12.ResumeLayout(false);
			this.tableLayoutPanel_12.PerformLayout();
			this.toolStrip_15.ResumeLayout(false);
			this.toolStrip_15.PerformLayout();
			((ISupportInitialize)this.dataGridView_8).EndInit();
			this.tabPage_13.ResumeLayout(false);
			this.tabPage_13.PerformLayout();
			this.toolStrip_17.ResumeLayout(false);
			this.toolStrip_17.PerformLayout();
			this.tableLayoutPanel_14.ResumeLayout(false);
			this.dataGridViewExcelFilter_1.EndInit();
			((ISupportInitialize)this.bindingSource_5).EndInit();
			this.tabPage_15.ResumeLayout(false);
			this.tabPage_15.PerformLayout();
			this.toolStrip_21.ResumeLayout(false);
			this.toolStrip_21.PerformLayout();
			this.tableLayoutPanel_16.ResumeLayout(false);
			this.dataGridViewExcelFilter_3.EndInit();
			((ISupportInitialize)this.bindingSource_8).EndInit();
			this.tabPage_18.ResumeLayout(false);
			this.tabPage_18.PerformLayout();
			this.dataGridViewExcelFilter_4.EndInit();
			((ISupportInitialize)this.bindingSource_9).EndInit();
			((ISupportInitialize)this.class14_0).EndInit();
			this.toolStrip_23.ResumeLayout(false);
			this.toolStrip_23.PerformLayout();
			this.tabPage_19.ResumeLayout(false);
			this.tabPage_19.PerformLayout();
			this.dataGridViewExcelFilter_5.EndInit();
			((ISupportInitialize)this.bindingSource_10).EndInit();
			((ISupportInitialize)this.class14_1).EndInit();
			this.toolStrip_24.ResumeLayout(false);
			this.toolStrip_24.PerformLayout();
			this.tabPage_21.ResumeLayout(false);
			this.tabPage_21.PerformLayout();
			((ISupportInitialize)this.dataGridView_10).EndInit();
			((ISupportInitialize)this.bindingSource_11).EndInit();
			((ISupportInitialize)this.class14_2).EndInit();
			this.toolStrip_27.ResumeLayout(false);
			this.toolStrip_27.PerformLayout();
			this.tabPage_30.ResumeLayout(false);
			this.tabPage_30.PerformLayout();
			((ISupportInitialize)this.dataGridView_15).EndInit();
			this.contextMenuStrip_14.ResumeLayout(false);
			((ISupportInitialize)this.bindingSource_14).EndInit();
			this.toolStrip_34.ResumeLayout(false);
			this.toolStrip_34.PerformLayout();
			this.tabPage_31.ResumeLayout(false);
			this.tabPage_31.PerformLayout();
			this.dataGridViewExcelFilter_10.EndInit();
			this.NawojBnvmy.ResumeLayout(false);
			this.toolStrip_35.ResumeLayout(false);
			this.toolStrip_35.PerformLayout();
			this.tabPage_32.ResumeLayout(false);
			this.tabPage_32.PerformLayout();
			this.dataGridViewExcelFilter_11.EndInit();
			this.contextMenuStrip_17.ResumeLayout(false);
			this.toolStrip_36.ResumeLayout(false);
			this.toolStrip_36.PerformLayout();
			this.tabPage_33.ResumeLayout(false);
			this.tabPage_33.PerformLayout();
			this.dataGridViewExcelFilter_12.EndInit();
			this.contextMenuStrip_16.ResumeLayout(false);
			this.toolStrip_37.ResumeLayout(false);
			this.toolStrip_37.PerformLayout();
			this.tabPage_34.ResumeLayout(false);
			this.tabPage_34.PerformLayout();
			((ISupportInitialize)this.dataGridView_16).EndInit();
			this.toolStrip_38.ResumeLayout(false);
			this.toolStrip_38.PerformLayout();
			((ISupportInitialize)this.dataGridViewPassport_0).EndInit();
			this.tabPage_2.ResumeLayout(false);
			this.splitContainer_4.Panel1.ResumeLayout(false);
			this.splitContainer_4.Panel2.ResumeLayout(false);
			this.splitContainer_4.ResumeLayout(false);
			this.tabControl_4.ResumeLayout(false);
			this.tabPage_16.ResumeLayout(false);
			this.bjlukJmkdL.ResumeLayout(false);
			this.bjlukJmkdL.PerformLayout();
			this.toolStrip_6.ResumeLayout(false);
			this.toolStrip_6.PerformLayout();
			this.dgvTrans.EndInit();
			this.tabPage_17.ResumeLayout(false);
			this.tableLayoutPanel_17.ResumeLayout(false);
			this.tableLayoutPanel_17.PerformLayout();
			this.toolStrip_22.ResumeLayout(false);
			this.toolStrip_22.PerformLayout();
			this.dgvTransV.EndInit();
			this.tabPage_20.ResumeLayout(false);
			this.tableLayoutPanel_18.ResumeLayout(false);
			this.tableLayoutPanel_18.PerformLayout();
			this.toolStrip_26.ResumeLayout(false);
			this.toolStrip_26.PerformLayout();
			this.dgvTransI.EndInit();
			this.splitContainer_5.Panel1.ResumeLayout(false);
			this.splitContainer_5.Panel1.PerformLayout();
			this.splitContainer_5.Panel2.ResumeLayout(false);
			this.splitContainer_5.ResumeLayout(false);
			this.dgvSwitchgears.EndInit();
			this.toolStrip_5.ResumeLayout(false);
			this.toolStrip_5.PerformLayout();
			this.tabControl_1.ResumeLayout(false);
			this.tabPage_3.ResumeLayout(false);
			this.tableLayoutPanel_3.ResumeLayout(false);
			this.tableLayoutPanel_3.PerformLayout();
			this.toolStrip_3.ResumeLayout(false);
			this.toolStrip_3.PerformLayout();
			this.dgvBuses.EndInit();
			this.tabPage_4.ResumeLayout(false);
			this.JeSuDrbQyn.ResumeLayout(false);
			this.JeSuDrbQyn.PerformLayout();
			this.toolStrip_4.ResumeLayout(false);
			this.toolStrip_4.PerformLayout();
			this.dgvCells.EndInit();
			this.tabPage_5.ResumeLayout(false);
			this.tableLayoutPanel_4.ResumeLayout(false);
			this.tableLayoutPanel_4.PerformLayout();
			this.toolStrip_7.ResumeLayout(false);
			this.toolStrip_7.PerformLayout();
			this.dgvSwitches.EndInit();
			this.tabPage_22.ResumeLayout(false);
			this.tabPage_22.PerformLayout();
			this.dataGridViewExcelFilter_6.EndInit();
			this.toolStrip_28.ResumeLayout(false);
			this.toolStrip_28.PerformLayout();
			this.tabPage_23.ResumeLayout(false);
			this.splitContainer_1.Panel1.ResumeLayout(false);
			this.splitContainer_1.Panel1.PerformLayout();
			this.splitContainer_1.Panel2.ResumeLayout(false);
			this.splitContainer_1.ResumeLayout(false);
			this.dataGridViewExcelFilter_0.EndInit();
			this.contextMenuStrip_5.ResumeLayout(false);
			this.toolStrip_11.ResumeLayout(false);
			this.toolStrip_11.PerformLayout();
			this.tabControl_3.ResumeLayout(false);
			this.dykcUlJvZe.ResumeLayout(false);
			this.tableLayoutPanel_8.ResumeLayout(false);
			this.tableLayoutPanel_8.PerformLayout();
			this.dataGridViewExcelFilter_7.EndInit();
			this.contextMenuStrip_4.ResumeLayout(false);
			this.toolStrip_12.ResumeLayout(false);
			this.toolStrip_12.PerformLayout();
			this.tabPage_14.ResumeLayout(false);
			this.tableLayoutPanel_15.ResumeLayout(false);
			this.tableLayoutPanel_15.PerformLayout();
			this.dataGridViewExcelFilter_2.EndInit();
			this.contextMenuStrip_10.ResumeLayout(false);
			this.toolStrip_20.ResumeLayout(false);
			this.toolStrip_20.PerformLayout();
			this.Cjurjlhywj.ResumeLayout(false);
			this.splitContainer_2.Panel1.ResumeLayout(false);
			this.splitContainer_2.Panel1.PerformLayout();
			this.splitContainer_2.Panel2.ResumeLayout(false);
			this.splitContainer_2.ResumeLayout(false);
			this.treeDataGridView_0.EndInit();
			this.contextMenuStrip_9.ResumeLayout(false);
			this.toolStrip_19.ResumeLayout(false);
			this.toolStrip_19.PerformLayout();
			this.splitContainer_3.Panel1.ResumeLayout(false);
			this.splitContainer_3.Panel2.ResumeLayout(false);
			this.splitContainer_3.Panel2.PerformLayout();
			this.splitContainer_3.ResumeLayout(false);
			this.tabControl_6.ResumeLayout(false);
			this.tabPage_28.ResumeLayout(false);
			this.tabPage_28.PerformLayout();
			this.dataGridViewExcelFilter_8.EndInit();
			this.contextMenuStrip_8.ResumeLayout(false);
			this.toolStrip_18.ResumeLayout(false);
			this.toolStrip_18.PerformLayout();
			this.tabPage_29.ResumeLayout(false);
			this.tabPage_29.PerformLayout();
			((ISupportInitialize)this.dataGridView_14).EndInit();
			this.toolStrip_33.ResumeLayout(false);
			this.toolStrip_33.PerformLayout();
			this.dataGridViewExcelFilter_9.EndInit();
			this.contextMenuStrip_13.ResumeLayout(false);
			this.toolStrip_25.ResumeLayout(false);
			this.toolStrip_25.PerformLayout();
			this.tabPage_1.ResumeLayout(false);
			this.tabPage_1.PerformLayout();
			((ISupportInitialize)this.dataGridView_1).EndInit();
			this.toolStrip_1.ResumeLayout(false);
			this.toolStrip_1.PerformLayout();
			this.tabPage_12.ResumeLayout(false);
			this.tabPage_12.PerformLayout();
			this.tableLayoutPanel_13.ResumeLayout(false);
			((ISupportInitialize)this.dataGridView_9).EndInit();
			((ISupportInitialize)this.bindingSource_4).EndInit();
			this.toolStrip_16.ResumeLayout(false);
			this.toolStrip_16.PerformLayout();
			this.tabPage_24.ResumeLayout(false);
			this.tabControl_5.ResumeLayout(false);
			this.tabPage_25.ResumeLayout(false);
			this.tabPage_25.PerformLayout();
			((ISupportInitialize)this.dataGridView_11).EndInit();
			((ISupportInitialize)this.bindingSource_12).EndInit();
			((ISupportInitialize)this.dataSet_0).EndInit();
			((ISupportInitialize)this.dataTable_0).EndInit();
			this.toolStrip_29.ResumeLayout(false);
			this.toolStrip_29.PerformLayout();
			this.tabPage_26.ResumeLayout(false);
			this.tabPage_26.PerformLayout();
			((ISupportInitialize)this.dataGridView_12).EndInit();
			this.toolStrip_30.ResumeLayout(false);
			this.toolStrip_30.PerformLayout();
			this.tabPage_27.ResumeLayout(false);
			this.tabPage_27.PerformLayout();
			((ISupportInitialize)this.dataGridView_13).EndInit();
			((ISupportInitialize)this.bindingSource_13).EndInit();
			this.toolStrip_32.ResumeLayout(false);
			this.toolStrip_32.PerformLayout();
			this.contextMenuStrip_12.ResumeLayout(false);
			((ISupportInitialize)this.bindingSource_7).EndInit();
			this.toolStrip_31.ResumeLayout(false);
			this.toolStrip_31.PerformLayout();
			((ISupportInitialize)this.bindingSource_2).EndInit();
			((ISupportInitialize)this.bindingSource_6).EndInit();
			this.contextMenuStrip_15.ResumeLayout(false);
			this.contextMenuStrip_18.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private string string_0;

		private EISSettings eissettings_0;

		private int int_0;

		private List<string> list_0;

		private List<int> list_1;

		private DataGridView dataGridView_0;

		private bool bool_0;

		private ColumnStyle columnStyle_0;

		private ColumnStyle eGmhhajZsf;

		private ColumnStyle columnStyle_1;

		private ToolStripControlHost toolStripControlHost_0;

		private ToolStripControlHost toolStripControlHost_1;

		private bool bool_1;

		private int int_1;

		private FormDockPassport.FillTree fillTree_0;

		private FormDockPassport.Sort sort_0;

		private List<string> list_2;

		private int int_2;

		private bool bool_2;

		private bool bool_3;

		private ObjList objList_0;

		private TreeNode treeNode_0;

		private TreeNode treeNode_1;

		private TreeNode treeNode_2;

		private List<int> list_3;

		private TypeObjListGroup typeObjListGroup_0;

		private bool bool_4;

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private TableLayoutPanel tableLayoutPanel_1;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripTextBox toolStripTextBox_0;

		private ToolStripButton EgvhzrfdWJ;

		private Panel panel_0;

		private TreeView treeView_0;

		private Class107 class107_0;

		private ImageList imageList_0;

		private Class295 class295_0;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private TableLayoutPanel tableLayoutPanel_2;

		private TableLayoutPanel ehAutNuOxy;

		private Label label_0;

		private DateTimePicker dateTimePicker_0;

		private Label label_1;

		private Label label_2;

		private TabPage tabPage_1;

		private DataGridView dataGridView_1;

		private ToolStrip toolStrip_1;

		private ToolStripSplitButton toolStripSplitButton_0;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripButton toolStripButton_2;

		private ToolStripButton fdPuJwPsYx;

		private ToolStripButton toolStripButton_3;

		private ToolStrip toolStrip_2;

		private ToolStripButton toolStripButton_4;

		private TabPage tabPage_2;

		private ContextMenuStrip contextMenuStrip_0;

		private TabControl tabControl_1;

		private TabPage tabPage_3;

		private TableLayoutPanel tableLayoutPanel_3;

		private ToolStrip toolStrip_3;

		private ToolStripButton toolStripButton_5;

		private ToolStripButton toolStripButton_6;

		private ToolStripButton toolStripButton_7;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripButton toolStripButton_8;

		private ToolStripSeparator toolStripSeparator_1;

		private ToolStripButton toolStripButton_9;

		private ToolStripLabel toolStripLabel_0;

		public DataGridViewExcelFilter dgvBuses;

		private TabPage tabPage_4;

		private TableLayoutPanel JeSuDrbQyn;

		private ToolStrip toolStrip_4;

		private ToolStripButton toolStripButton_10;

		private ToolStripButton toolStripButton_11;

		private ToolStripButton toolStripButton_12;

		private ToolStripSeparator toolStripSeparator_2;

		private ToolStripButton toolStripButton_13;

		private ToolStripSeparator toolStripSeparator_3;

		private ToolStripButton Arvudbkpvh;

		private ToolStripLabel toolStripLabel_1;

		public DataGridViewExcelFilter dgvCells;

		private TabPage tabPage_5;

		private ToolStrip toolStrip_5;

		private ToolStripButton toolStripButton_14;

		private ToolStripButton toolStripButton_15;

		private ToolStripButton toolStripButton_16;

		private ToolStripSeparator bJkuSvjuUb;

		private ToolStripButton toolStripButton_17;

		private ToolStripSeparator toolStripSeparator_4;

		private ToolStripButton toolStripButton_18;

		private ToolStripLabel toolStripLabel_2;

		private TableLayoutPanel bjlukJmkdL;

		private ToolStrip toolStrip_6;

		private ToolStripButton sjguzMevbg;

		private ToolStripButton toolStripButton_19;

		private ToolStripButton toolStripButton_20;

		private ToolStripSeparator toolStripSeparator_5;

		private ToolStripButton toolStripButton_21;

		private ToolStripSeparator toolStripSeparator_6;

		private ToolStripButton toolStripButton_22;

		private ToolStripLabel toolStripLabel_3;

		private TableLayoutPanel tableLayoutPanel_4;

		private ToolStrip toolStrip_7;

		private ToolStripButton toolStripButton_23;

		private ToolStripButton toolStripButton_24;

		private ToolStripButton toolStripButton_25;

		private ToolStripSeparator toolStripSeparator_7;

		private ToolStripButton toolStripButton_26;

		private ToolStripSeparator toolStripSeparator_8;

		private ToolStripButton toolStripButton_27;

		private ToolStripLabel toolStripLabel_4;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private TabControl tabControl_2;

		private TabPage tabPage_6;

		private TableLayoutPanel tableLayoutPanel_5;

		private DataGridView dataGridView_2;

		private ToolStrip toolStrip_8;

		private ToolStripButton toolStripButton_28;

		private ToolStripButton toolStripButton_29;

		private ToolStripSeparator toolStripSeparator_9;

		private ToolStripButton toolStripButton_30;

		private ToolStripSeparator toolStripSeparator_10;

		private ToolStripButton toolStripButton_31;

		private TabPage tabPage_7;

		private TableLayoutPanel tableLayoutPanel_6;

		private DataGridView dataGridView_3;

		private ToolStrip toolStrip_9;

		private ToolStripButton toolStripButton_32;

		private ToolStripButton toolStripButton_33;

		private ToolStripSeparator toolStripSeparator_11;

		private ToolStripButton toolStripButton_34;

		private ToolStripSeparator toolStripSeparator_12;

		private ToolStripButton toolStripButton_35;

		private ContextMenuStrip contextMenuStrip_1;

		private ToolStripMenuItem toolStripMenuItem_1;

		private ToolStripMenuItem toolStripMenuItem_2;

		private ToolStripSeparator toolStripSeparator_13;

		private ToolStripMenuItem toolStripMenuItem_3;

		private ToolStripSeparator toolStripSeparator_14;

		private ToolStripMenuItem toolStripMenuItem_4;

		private ContextMenuStrip contextMenuStrip_2;

		private ToolStripMenuItem toolStripMenuItem_5;

		private ToolStripMenuItem toolStripMenuItem_6;

		private ToolStripSeparator toolStripSeparator_15;

		private ToolStripMenuItem toolStripMenuItem_7;

		private ToolStripSeparator toolStripSeparator_16;

		private ToolStripMenuItem toolStripMenuItem_8;

		private TabPage tabPage_8;

		private TableLayoutPanel tableLayoutPanel_7;

		private DataGridView dataGridView_4;

		private ToolStrip toolStrip_10;

		private ToolStripButton toolStripButton_36;

		private ToolStripButton toolStripButton_37;

		private ToolStripSeparator toolStripSeparator_17;

		private ToolStripButton toolStripButton_38;

		private ToolStripSeparator toolStripSeparator_18;

		private ToolStripButton toolStripButton_39;

		private ToolStripButton toolStripButton_40;

		private ContextMenuStrip contextMenuStrip_3;

		private ToolStripMenuItem toolStripMenuItem_9;

		private ToolStripMenuItem toolStripMenuItem_10;

		private ToolStripSeparator toolStripSeparator_19;

		private ToolStripMenuItem toolStripMenuItem_11;

		private ToolStripSeparator toolStripSeparator_20;

		private ToolStripMenuItem toolStripMenuItem_12;

		private SplitContainer splitContainer_0;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private ToolStrip toolStrip_11;

		private ToolStripButton toolStripButton_41;

		private ToolStripButton toolStripButton_42;

		private ToolStripSeparator toolStripSeparator_21;

		private ToolStripButton toolStripButton_43;

		private ToolStripSeparator toolStripSeparator_22;

		private ToolStripButton toolStripButton_44;

		private TableLayoutPanel tableLayoutPanel_8;

		private ToolStrip toolStrip_12;

		private ToolStripButton toolStripButton_45;

		private ToolStripButton toolStripButton_46;

		private ToolStripSeparator toolStripSeparator_23;

		private ToolStripSeparator toolStripSeparator_24;

		private ToolStripButton toolStripButton_47;

		private ContextMenuStrip contextMenuStrip_4;

		private ToolStripMenuItem toolStripMenuItem_13;

		private ToolStripMenuItem toolStripMenuItem_14;

		private ToolStripMenuItem toolStripMenuItem_15;

		private ToolStripSeparator toolStripSeparator_25;

		private ToolStripMenuItem toolStripMenuItem_16;

		private ToolStripSeparator toolStripSeparator_26;

		private ToolStripMenuItem toolStripMenuItem_17;

		private ToolStripMenuItem toolStripMenuItem_18;

		private ToolStripMenuItem toolStripMenuItem_19;

		private ContextMenuStrip contextMenuStrip_5;

		private ToolStripMenuItem toolStripMenuItem_20;

		private ToolStripMenuItem toolStripMenuItem_21;

		private ToolStripSeparator toolStripSeparator_27;

		private ToolStripMenuItem toolStripMenuItem_22;

		private ToolStripSeparator toolStripSeparator_28;

		private ToolStripMenuItem toolStripMenuItem_23;

		private TabPage tabPage_9;

		private TableLayoutPanel tableLayoutPanel_9;

		private DataGridView dataGridView_5;

		private ToolStrip ErxDoVobWm;

		private ToolStripButton toolStripButton_48;

		private ToolStripButton toolStripButton_49;

		private ToolStripSeparator toolStripSeparator_29;

		private ToolStripButton toolStripButton_50;

		private ToolStripSeparator toolStripSeparator_30;

		private ToolStripButton toolStripButton_51;

		private TabPage tabPage_10;

		private TableLayoutPanel tableLayoutPanel_10;

		private DataGridView dataGridView_6;

		private BindingSource bindingSource_0;

		private BindingSource bindingSource_1;

		private ToolStrip toolStrip_13;

		private ToolStripButton toolStripButton_52;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		private ContextMenuStrip contextMenuStrip_6;

		private ToolStripMenuItem toolStripMenuItem_24;

		private ToolStripMenuItem toolStripMenuItem_25;

		private ToolStripSeparator toolStripSeparator_31;

		private ToolStripMenuItem toolStripMenuItem_26;

		private ToolStripSeparator toolStripSeparator_32;

		private ToolStripMenuItem toolStripMenuItem_27;

		private ToolStripSeparator toolStripSeparator_33;

		private ToolStripSeparator toolStripSeparator_34;

		private ToolStripButton toolStripButton_53;

		private ToolStripSeparator toolStripSeparator_35;

		private ToolStripButton toolStripButton_54;

		private BindingSource bindingSource_2;

		private DateTimePicker dateTimePicker_1;

		private ComboBox comboBox_0;

		private TabPage pjuAjnsoym;

		private TableLayoutPanel tableLayoutPanel_11;

		private DataGridView dataGridView_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

		private ContextMenuStrip contextMenuStrip_7;

		private ToolStripMenuItem toolStripMenuItem_28;

		private ToolStripMenuItem toolStripMenuItem_29;

		private ToolStripSeparator toolStripSeparator_36;

		private ToolStripMenuItem toolStripMenuItem_30;

		private ToolStripSeparator toolStripSeparator_37;

		private ToolStripMenuItem toolStripMenuItem_31;

		private BindingSource bindingSource_3;

		private Class14 jtnAdxtlvN;

		private ToolStrip toolStrip_14;

		private ToolStripButton toolStripButton_55;

		private ToolStripButton toolStripButton_56;

		private ToolStripButton toolStripButton_57;

		private ToolStripSeparator toolStripSeparator_38;

		private ToolStripButton toolStripButton_58;

		private ToolStripSeparator toolStripSeparator_39;

		private ToolStripButton toolStripButton_59;

		private ToolStripSplitButton toolStripSplitButton_1;

		private ToolStripMenuItem toolStripMenuItem_32;

		private ToolStripMenuItem toolStripMenuItem_33;

		private BackgroundWorker backgroundWorker_0;

		private BackgroundWorker backgroundWorker_1;

		private BackgroundWorker backgroundWorker_2;

		private BackgroundWorker LstNnlIwat;

		private BackgroundWorker backgroundWorker_3;

		private BackgroundWorker backgroundWorker_4;

		private BackgroundWorker backgroundWorker_5;

		private DataGridViewPassport dataGridViewPassport_0;

		private Label label_3;

		private ToolStripSeparator toolStripSeparator_40;

		private ToolStripButton toolStripButton_60;

		private TabPage tabPage_11;

		private TableLayoutPanel tableLayoutPanel_12;

		private ToolStrip toolStrip_15;

		private ToolStripButton toolStripButton_61;

		private ToolStripSeparator toolStripSeparator_41;

		private ToolStripButton toolStripButton_62;

		private ToolStripSeparator toolStripSeparator_42;

		private ToolStripButton toolStripButton_63;

		private ToolStripSeparator toolStripSeparator_43;

		private ToolStripButton toolStripButton_64;

		private DataGridView dataGridView_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;

		private ToolStripButton toolStripButton_65;

		private ToolStripSeparator toolStripSeparator_44;

		private ToolStripButton toolStripButton_66;

		private ToolStripMenuItem toolStripMenuItem_34;

		private ToolStripMenuItem toolStripMenuItem_35;

		private ToolStripSeparator toolStripSeparator_45;

		private ToolStripSeparator toolStripSeparator_46;

		private ToolStripLabel toolStripLabel_5;

		private TabPage tabPage_12;

		private TableLayoutPanel tableLayoutPanel_13;

		private DataGridView dataGridView_9;

		private ToolStrip toolStrip_16;

		private ToolStripButton toolStripButton_67;

		private ToolStripButton toolStripButton_68;

		private ToolStripButton toolStripButton_69;

		private BindingSource bindingSource_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;

		private DataGridViewImageColumn dataGridViewImageColumn_0;

		private DataGridViewLinkColumn dataGridViewLinkColumn_0;

		private DataGridViewCheckBoxColumn yvucnefnbB;

		private ToolStripButton toolStripButton_70;

		private TabPage tabPage_13;

		private TableLayoutPanel tableLayoutPanel_14;

		private ToolStrip toolStrip_17;

		private ToolStripButton toolStripButton_71;

		private ToolStripButton toolStripButton_72;

		private ToolStripSeparator toolStripSeparator_47;

		private ToolStripButton toolStripButton_73;

		private ToolStripSeparator toolStripSeparator_48;

		private ToolStripButton toolStripButton_74;

		private DataGridViewExcelFilter dataGridViewExcelFilter_1;

		private BindingSource bindingSource_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;

		private ToolStrip toolStrip_18;

		private ToolStripButton toolStripButton_75;

		private ToolStripButton toolStripButton_76;

		private ToolStripSeparator toolStripSeparator_49;

		private ToolStripButton toolStripButton_77;

		private ToolStripSeparator toolStripSeparator_50;

		private ToolStripButton GoscVscjdc;

		private ToolStrip toolStrip_19;

		private ToolStripButton OlEcIrCmwq;

		private ToolStripButton toolStripButton_78;

		private ToolStripSeparator toolStripSeparator_51;

		private ToolStripButton toolStripButton_79;

		private ToolStripSeparator toolStripSeparator_52;

		private ToolStripButton toolStripButton_80;

		private BindingSource bindingSource_6;

		private BindingSource bindingSource_7;

		private TreeDataGridView treeDataGridView_0;

		private ContextMenuStrip contextMenuStrip_8;

		private ToolStripMenuItem odScMgvaDL;

		private ToolStripMenuItem toolStripMenuItem_36;

		private ToolStripSeparator toolStripSeparator_53;

		private ToolStripMenuItem toolStripMenuItem_37;

		private ToolStripSeparator toolStripSeparator_54;

		private ToolStripMenuItem toolStripMenuItem_38;

		private ContextMenuStrip contextMenuStrip_9;

		private ToolStripMenuItem toolStripMenuItem_39;

		private ToolStripMenuItem toolStripMenuItem_40;

		private ToolStripSeparator toolStripSeparator_55;

		private ToolStripMenuItem toolStripMenuItem_41;

		private ToolStripSeparator toolStripSeparator_56;

		private ToolStripMenuItem toolStripMenuItem_42;

		private TabControl tabControl_3;

		private TabPage dykcUlJvZe;

		private TabPage tabPage_14;

		private TableLayoutPanel tableLayoutPanel_15;

		private DataGridViewExcelFilter dataGridViewExcelFilter_2;

		private ToolStrip toolStrip_20;

		private ToolStripButton toolStripButton_81;

		private ToolStripButton toolStripButton_82;

		private ToolStripSeparator toolStripSeparator_57;

		private ToolStripSeparator toolStripSeparator_58;

		private ToolStripButton toolStripButton_83;

		private ContextMenuStrip contextMenuStrip_10;

		private ToolStripMenuItem leJimFhKcN;

		private ToolStripMenuItem toolStripMenuItem_43;

		private ToolStripSeparator toolStripSeparator_59;

		private ToolStripMenuItem toolStripMenuItem_44;

		private ContextMenuStrip contextMenuStrip_11;

		private ContextMenuStrip contextMenuStrip_12;

		private ToolStripMenuItem toolStripMenuItem_45;

		private ToolStripSeparator toolStripSeparator_60;

		private ToolStripMenuItem toolStripMenuItem_46;

		private ToolStripSeparator toolStripSeparator_61;

		private ToolStripButton toolStripButton_84;

		private ToolStripButton toolStripButton_85;

		private ToolStripSeparator toolStripSeparator_62;

		private ToolStripSeparator toolStripSeparator_63;

		private ToolStripButton toolStripButton_86;

		private ToolStripSeparator toolStripSeparator_64;

		private ToolStripButton toolStripButton_87;

		private ToolStripSeparator toolStripSeparator_65;

		private ToolStripButton toolStripButton_88;

		private TabPage tabPage_15;

		private ToolStrip toolStrip_21;

		private ToolStripButton toolStripButton_89;

		private ToolStripButton toolStripButton_90;

		private ToolStripSeparator toolStripSeparator_66;

		private ToolStripButton toolStripButton_91;

		private ToolStripSeparator toolStripSeparator_67;

		private ToolStripButton toolStripButton_92;

		private TableLayoutPanel tableLayoutPanel_16;

		private DataGridViewExcelFilter dataGridViewExcelFilter_3;

		private BindingSource bindingSource_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3;

		private TabControl tabControl_4;

		private TabPage tabPage_16;

		private TabPage tabPage_17;

		private TableLayoutPanel tableLayoutPanel_17;

		private ToolStrip toolStrip_22;

		private ToolStripButton toolStripButton_93;

		private ToolStripButton toolStripButton_94;

		private ToolStripButton toolStripButton_95;

		private ToolStripSeparator toolStripSeparator_68;

		private ToolStripButton toolStripButton_96;

		private ToolStripSeparator toolStripSeparator_69;

		private ToolStripButton toolStripButton_97;

		private ToolStripLabel toolStripLabel_6;

		public DataGridViewExcelFilter dgvTransV;

		private BackgroundWorker backgroundWorker_6;

		private ToolStripSeparator toolStripSeparator_70;

		private ToolStripButton toolStripButton_98;

		private TreeGridColumn treeGridColumn_0;

		private TreeGridColumn treeGridColumn_1;

		private TreeGridColumn treeGridColumn_2;

		private TreeGridColumn treeGridColumn_3;

		private TreeGridColumn treeGridColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_64;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_65;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_66;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_67;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_68;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_69;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_70;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_71;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_72;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_73;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_74;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_75;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_76;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_77;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_78;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_79;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_80;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_81;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_82;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_83;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_84;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_85;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_86;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_87;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_88;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_89;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_90;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_91;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_92;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_93;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_94;

		private ToolStripSplitButton toolStripSplitButton_2;

		private ToolStripMenuItem toolStripMenuItem_47;

		private ToolStripMenuItem HsaPpImClL;

		private TabPage tabPage_18;

		private ToolStrip toolStrip_23;

		private ToolStripButton toolStripButton_99;

		private ToolStripButton toolStripButton_100;

		private ToolStripSeparator toolStripSeparator_71;

		private ToolStripButton toolStripButton_101;

		private ToolStripSeparator toolStripSeparator_72;

		private ToolStripButton pRdPcudXaZ;

		private DataGridViewExcelFilter dataGridViewExcelFilter_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_95;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_96;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_97;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_98;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_99;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_100;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_4;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_5;

		private BindingSource bindingSource_9;

		private Class14 class14_0;

		private TabPage tabPage_19;

		private ToolStrip toolStrip_24;

		private ToolStripButton toolStripButton_102;

		private ToolStripButton toolStripButton_103;

		private ToolStripSeparator toolStripSeparator_73;

		private ToolStripButton toolStripButton_104;

		private ToolStripSeparator toolStripSeparator_74;

		private ToolStripButton toolStripButton_105;

		private DataGridViewExcelFilter dataGridViewExcelFilter_5;

		private BindingSource bindingSource_10;

		private Class14 class14_1;

		private ToolStripSeparator toolStripSeparator_75;

		private ToolStripButton toolStripButton_106;

		private ToolStripMenuItem toolStripMenuItem_48;

		private ToolStrip toolStrip_25;

		private ToolStripButton toolStripButton_107;

		private ToolStripButton toolStripButton_108;

		private ToolStripSeparator toolStripSeparator_76;

		private ToolStripButton toolStripButton_109;

		private ToolStripSeparator toolStripSeparator_77;

		private ToolStripButton toolStripButton_110;

		private ToolStripSeparator toolStripSeparator_78;

		private ToolStripButton toolStripButton_111;

		private ToolStripButton toolStripButton_112;

		private ToolStripButton toolStripButton_113;

		private ToolStripSplitButton toolStripSplitButton_3;

		private ToolStripMenuItem toolStripMenuItem_49;

		private ToolStripMenuItem toolStripMenuItem_50;

		private ContextMenuStrip contextMenuStrip_13;

		private ToolStripMenuItem toolStripMenuItem_51;

		private ToolStripMenuItem toolStripMenuItem_52;

		private ToolStripMenuItem toolStripMenuItem_53;

		private ToolStripSeparator toolStripSeparator_79;

		private ToolStripMenuItem toolStripMenuItem_54;

		private ToolStripMenuItem toolStripMenuItem_55;

		private ToolStripSeparator toolStripSeparator_80;

		private TabPage tabPage_20;

		private TableLayoutPanel tableLayoutPanel_18;

		private ToolStrip toolStrip_26;

		private ToolStripButton toolStripButton_114;

		private ToolStripButton toolStripButton_115;

		private ToolStripButton toolStripButton_116;

		private ToolStripSeparator toolStripSeparator_81;

		private ToolStripButton toolStripButton_117;

		private ToolStripSeparator toolStripSeparator_82;

		private ToolStripButton toolStripButton_118;

		private BackgroundWorker backgroundWorker_7;

		public DataGridViewExcelFilter dgvTransI;

		private TabPage tabPage_21;

		private DataGridView dataGridView_10;

		private ToolStrip toolStrip_27;

		private ToolStripButton toolStripButton_119;

		private ToolStripButton toolStripButton_120;

		private ToolStripSeparator toolStripSeparator_83;

		private ToolStripButton toolStripButton_121;

		private ToolStripSeparator toolStripSeparator_84;

		private ToolStripButton toolStripButton_122;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_101;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_102;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_103;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_104;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_105;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_106;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_107;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_6;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_108;

		private BindingSource bindingSource_11;

		private Class14 class14_2;

		private TabPage tabPage_22;

		private ToolStrip toolStrip_28;

		private ToolStripButton toolStripButton_123;

		private ToolStripButton toolStripButton_124;

		private ToolStripButton toolStripButton_125;

		private ToolStripSeparator toolStripSeparator_85;

		private ToolStripButton toolStripButton_126;

		private ToolStripSeparator toolStripSeparator_86;

		private ToolStripButton toolStripButton_127;

		private DataGridViewExcelFilter dataGridViewExcelFilter_6;

		private BackgroundWorker backgroundWorker_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_109;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_110;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_111;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_112;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_113;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_114;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_115;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_116;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_117;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_118;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_119;

		private ToolStripSeparator toolStripSeparator_87;

		private ToolStripLabel toolStripLabel_7;

		private ToolStripButton toolStripButton_128;

		private TabPage tabPage_23;

		private SplitContainer splitContainer_1;

		private TabPage Cjurjlhywj;

		private SplitContainer splitContainer_2;

		private SplitContainer splitContainer_3;

		private SplitContainer splitContainer_4;

		private SplitContainer splitContainer_5;

		private TabPage tabPage_24;

		private TabControl tabControl_5;

		private TabPage tabPage_25;

		private TabPage tabPage_26;

		private DataGridView dataGridView_11;

		private ToolStrip toolStrip_29;

		private ToolStripButton toolStripButton_129;

		private ToolStripButton toolStripButton_130;

		private ToolStripButton toolStripButton_131;

		private ToolStripSeparator toolStripSeparator_88;

		private ToolStripButton toolStripButton_132;

		private DataGridView dataGridView_12;

		private ToolStrip toolStrip_30;

		private ToolStripButton toolStripButton_133;

		private ToolStripButton toolStripButton_134;

		private ToolStripButton toolStripButton_135;

		private ToolStripSeparator toolStripSeparator_89;

		private ToolStripButton toolStripButton_136;

		private BindingSource bindingSource_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_120;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_121;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_122;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_123;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_124;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_125;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_126;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_127;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_128;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_129;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_130;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_131;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_132;

		private DataGridViewTextBoxColumn iyFdnnqUdb;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_133;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_134;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_135;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_136;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_137;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_138;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_139;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_140;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_141;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_142;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_143;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_144;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_145;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_146;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_147;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_148;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_149;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_150;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_151;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_152;

		private DataGridViewTextBoxColumn xhAdvgBiFT;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_153;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_154;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_155;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_156;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_157;

		private DataSet dataSet_0;

		private DataTable dataTable_0;

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn SuUdfiJawF;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private DataColumn IeBdYdknAT;

		private ToolStripButton toolStripButton_137;

		private ToolStripButton toolStripButton_138;

		private ToolStripButton toolStripButton_139;

		private ToolStripSeparator toolStripSeparator_90;

		private ToolStripButton toolStripButton_140;

		private ToolStripSeparator toolStripSeparator_91;

		private ToolStripDropDownButton toolStripDropDownButton_0;

		private ToolStripMenuItem toolStripMenuItem_56;

		private ToolStripMenuItem toolStripMenuItem_57;

		private ToolStripSeparator toolStripSeparator_92;

		private ToolStripButton toolStripButton_141;

		private ToolStripSeparator toolStripSeparator_93;

		private ToolStripButton toolStripButton_142;

		private ToolStripSeparator toolStripSeparator_94;

		private ToolStripButton toolStripButton_143;

		private ToolStripSeparator toolStripSeparator_95;

		private ToolStripButton toolStripButton_144;

		private ToolStripSeparator toolStripSeparator_96;

		private ToolStripButton toolStripButton_145;

		private ToolStripButton toolStripButton_146;

		private ToolStripButton toolStripButton_147;

		private ToolStripButton toolStripButton_148;

		private ToolStripSeparator toolStripSeparator_97;

		private ToolStripButton toolStripButton_149;

		private ToolStripButton toolStripButton_150;

		private ToolStrip toolStrip_31;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_158;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_159;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_160;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_161;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_162;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_163;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_164;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_165;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_166;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_167;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_168;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_169;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_9;

		private ToolStripMenuItem toolStripMenuItem_58;

		private TabPage tabPage_27;

		private DataGridView dataGridView_13;

		private ToolStrip toolStrip_32;

		private ToolStripButton toolStripButton_151;

		private ToolStripButton toolStripButton_152;

		private ToolStripButton toolStripButton_153;

		private ToolStripButton toolStripButton_154;

		private BindingSource bindingSource_13;

		public DataGridViewExcelFilter dgvTrans;

		public DataGridViewExcelFilter dgvSwitchgears;

		public DataGridViewExcelFilter dgvSwitches;

		private DataGridViewExcelFilter dataGridViewExcelFilter_7;

		private DataGridViewExcelFilter dataGridViewExcelFilter_8;

		private DataGridViewExcelFilter dataGridViewExcelFilter_9;

		private ToolStripMenuItem toolStripMenuItem_59;

		private ToolStripButton VlMgyFgckb;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_170;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_171;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_172;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_173;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_174;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_175;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_176;

		private ToolStripSeparator toolStripSeparator_98;

		private ToolStripButton toolStripButton_155;

		private TabControl tabControl_6;

		private TabPage tabPage_28;

		private TabPage tabPage_29;

		private DataGridView dataGridView_14;

		private ToolStrip toolStrip_33;

		private ToolStripButton toolStripButton_156;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_177;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_178;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_179;

		private DataGridViewTextBoxColumn obfgdCvgpL;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_180;

		private ToolStripDropDownButton toolStripDropDownButton_1;

		private ToolStripMenuItem toolStripMenuItem_60;

		private ToolStripMenuItem toolStripMenuItem_61;

		private ToolStripMenuItem toolStripMenuItem_62;

		private DataGridViewTextBoxColumn luZgbmDwv7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_181;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_182;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_183;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_184;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_185;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_186;

		private DataGridViewTextBoxColumn lrkgwoojrG;

		private ToolStripDropDownButton toolStripDropDownButton_2;

		private ToolStripMenuItem toolStripMenuItem_63;

		private ToolStripMenuItem toolStripMenuItem_64;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_187;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_188;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_189;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_190;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_191;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_192;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_193;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_194;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_195;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_196;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_197;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_198;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_199;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_200;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_201;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_202;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_203;

		private TabPage tabPage_30;

		private DataGridView dataGridView_15;

		private ToolStrip toolStrip_34;

		private ToolStripButton toolStripButton_157;

		private ToolStripButton toolStripButton_158;

		private ToolStripButton toolStripButton_159;

		private ToolStripButton toolStripButton_160;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_204;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_205;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_206;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_207;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_208;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_209;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_210;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_211;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_212;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_213;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_214;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_215;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_216;

		private BindingSource bindingSource_14;

		private ContextMenuStrip contextMenuStrip_14;

		private ToolStripMenuItem toolStripMenuItem_65;

		private ToolStripMenuItem toolStripMenuItem_66;

		private ToolStripMenuItem toolStripMenuItem_67;

		private ToolStripMenuItem toolStripMenuItem_68;

		private ToolStripSeparator toolStripSeparator_99;

		private ToolStripButton toolStripButton_161;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_217;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_218;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_219;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_220;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_221;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_222;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_12;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_13;

		private ContextMenuStrip contextMenuStrip_15;

		private ToolStripMenuItem toolStripMenuItem_69;

		private ToolStripMenuItem toolStripMenuItem_70;

		private ToolStripMenuItem toolStripMenuItem_71;

		private ToolStripMenuItem toolStripMenuItem_72;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_223;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_224;

		private DataGridViewImageColumn dataGridViewImageColumn_1;

		private DataGridViewLinkColumn YowoatyOoV;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_225;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_226;

		private TabPage tabPage_31;

		private ToolStrip toolStrip_35;

		private TabPage tabPage_32;

		private TabPage tabPage_33;

		private DataGridViewExcelFilter dataGridViewExcelFilter_10;

		private ToolStripButton toolStripButton_162;

		private ToolStripButton toolStripButton_163;

		private ToolStripButton toolStripButton_164;

		private ToolStripButton toolStripButton_165;

		private DataGridViewExcelFilter dataGridViewExcelFilter_11;

		private ToolStrip toolStrip_36;

		private ToolStripButton toolStripButton_166;

		private ToolStripButton toolStripButton_167;

		private ToolStripButton toolStripButton_168;

		private ToolStripButton toolStripButton_169;

		private DataGridViewExcelFilter dataGridViewExcelFilter_12;

		private ToolStrip toolStrip_37;

		private ToolStripButton toolStripButton_170;

		private ToolStripButton toolStripButton_171;

		private ToolStripButton toolStripButton_172;

		private ContextMenuStrip NawojBnvmy;

		private ToolStripMenuItem toolStripMenuItem_73;

		private ToolStripMenuItem toolStripMenuItem_74;

		private ToolStripMenuItem toolStripMenuItem_75;

		private ToolStripMenuItem toolStripMenuItem_76;

		private ContextMenuStrip contextMenuStrip_16;

		private ToolStripMenuItem toolStripMenuItem_77;

		private ToolStripMenuItem toolStripMenuItem_78;

		private ToolStripMenuItem toolStripMenuItem_79;

		private ToolStripMenuItem toolStripMenuItem_80;

		private ContextMenuStrip contextMenuStrip_17;

		private ToolStripMenuItem toolStripMenuItem_81;

		private ToolStripMenuItem toolStripMenuItem_82;

		private ToolStripMenuItem toolStripMenuItem_83;

		private ToolStripMenuItem toolStripMenuItem_84;

		private ToolStripButton toolStripButton_173;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_227;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_228;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_229;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_230;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_231;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_232;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_233;

		private DataGridViewTextBoxColumn ikuogYtqqM;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_234;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_235;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_236;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_237;

		private DataGridViewTextBoxColumn ensobXmnxq;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_238;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_239;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_240;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_241;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_242;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_243;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_244;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_245;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_246;

		private DataGridViewTextBoxColumn mTiRmHbeJe;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_247;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_248;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_249;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_250;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_251;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_252;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_253;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_254;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_255;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_256;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_257;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_258;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_259;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_260;

		private TabPage tabPage_34;

		private DataGridView dataGridView_16;

		private ToolStrip toolStrip_38;

		private ToolStripButton toolStripButton_174;

		private ToolStripButton toolStripButton_175;

		private ToolStripButton toolStripButton_176;

		private ToolStripButton toolStripButton_177;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_261;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_262;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_263;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_264;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_265;

		private ContextMenuStrip contextMenuStrip_18;

		private ToolStripMenuItem toolStripMenuItem_85;

		private ToolStripMenuItem toolStripMenuItem_86;

		private ToolStripMenuItem toolStripMenuItem_87;

		private ToolStripMenuItem toolStripMenuItem_88;

		private ToolStripSeparator toolStripSeparator_100;

		private ToolStripButton toolStripButton_178;

		private ToolStripSeparator toolStripSeparator_101;

		private ToolStripButton toolStripButton_179;

		private ToolStripSeparator toolStripSeparator_102;

		private ToolStripButton toolStripButton_180;

		private ToolStripSeparator toolStripSeparator_103;

		private ToolStripMenuItem toolStripMenuItem_89;

		private ToolStripSeparator toolStripSeparator_104;

		private ToolStripMenuItem toolStripMenuItem_90;

		private ToolStripSeparator toolStripSeparator_105;

		private ToolStripMenuItem toolStripMenuItem_91;

		private ToolStripSeparator toolStripSeparator_106;

		private ToolStripButton toolStripButton_181;

		private ToolStripSeparator toolStripSeparator_107;

		private ToolStripMenuItem toolStripMenuItem_92;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_266;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_267;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_268;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_269;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_270;

		private enum Enum0
		{

		}

		public enum FillTree
		{
			One,
			All
		}

		public enum Sort
		{
			Asc,
			Desc
		}

		private enum Enum1
		{

		}
	}
}
