using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Constants;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using Legal.Forms;
using Prv.Forms.Abonent;
using Scheme.Properties;
using SchemeCtrl2.Canvas;

namespace Scheme.Forms.LinkCellPoint
{
	public class FormLinkCellPoint : FormBase
	{
		public FormLinkCellPoint()
		{
			Class63.AGd1PxHzk5wxP();
			this.string_0 = "";
			this.string_1 = "";
			this.string_2 = "";
			this.yoOqbSmYoi = "";
			base..ctor();
			this.method_7();
			this.method_0();
		}

		public FormLinkCellPoint(List<int> listSubstation)
		{
			Class63.AGd1PxHzk5wxP();
			this.string_0 = "";
			this.string_1 = "";
			this.string_2 = "";
			this.yoOqbSmYoi = "";
			base..ctor();
			this.method_7();
			this.method_0();
			this.list_0 = listSubstation;
			foreach (int num in listSubstation)
			{
				this.yoOqbSmYoi = this.yoOqbSmYoi + num.ToString() + ",";
			}
			if (this.yoOqbSmYoi != "")
			{
				this.yoOqbSmYoi = this.yoOqbSmYoi.Remove(this.yoOqbSmYoi.Length - 1);
			}
		}

		private void method_0()
		{
			foreach (object obj in Enum.GetValues(typeof(SchmTypeSubstation)))
			{
				SchmTypeSubstation schmTypeSubstation = (SchmTypeSubstation)obj;
				this.string_0 = this.string_0 + Convert.ToInt32(schmTypeSubstation).ToString() + ",";
			}
			foreach (object obj2 in Enum.GetValues(typeof(SchmTypeCell)))
			{
				SchmTypeCell schmTypeCell = (SchmTypeCell)obj2;
				this.string_1 = this.string_1 + Convert.ToInt32(schmTypeCell).ToString() + ",";
			}
			this.string_2 = this.string_0 + this.string_1;
			if (!string.IsNullOrEmpty(this.string_2))
			{
				this.string_2 = this.string_2.Remove(this.string_2.Length - 1);
			}
		}

		private void FormLinkCellPoint_Load(object sender, EventArgs e)
		{
			if (this.list_0 == null)
			{
				base.SelectSqlData(this.class19_0, this.class19_0.vSchm_ObjList, true, " where typeCodeId in (" + this.string_2 + ") order by typeCode, name");
			}
			else if (this.yoOqbSmYoi != "")
			{
				base.SelectSqlData(this.class19_0, this.class19_0.vSchm_ObjList, true, string.Concat(new string[]
				{
					" where (id in (",
					this.yoOqbSmYoi,
					") or idParent in (",
					this.yoOqbSmYoi,
					")) and typeCodeId in (",
					this.string_2,
					") order by typeCode, name"
				}));
			}
			base.SelectSqlData(this.class19_0, this.class19_0.tL_CellPointReg, true);
			this.method_1();
		}

		private void method_1()
		{
			TreeNode treeNode = new TreeNode("Все");
			this.treeView_0.Nodes.Add(treeNode);
			TreeNode treeNode2 = new TreeNode("ТП");
			treeNode2.Tag = 538;
			treeNode.Nodes.Add(treeNode2);
			TreeNode treeNode3 = new TreeNode("ЦП");
			treeNode3.Tag = 536;
			treeNode.Nodes.Add(treeNode3);
			TreeNode treeNode4 = new TreeNode("РП");
			treeNode4.Tag = 537;
			treeNode.Nodes.Add(treeNode4);
			TreeNode treeNode5 = new TreeNode("ПП");
			treeNode5.Tag = 535;
			treeNode.Nodes.Add(treeNode5);
			foreach (DataRow dataRow in this.class19_0.vSchm_ObjList.Select(" typeCodeId  in (" + this.string_0 + ")", " typeCode, name"))
			{
				TreeNode treeNode6 = new TreeNode(dataRow["Name"].ToString());
				treeNode6.Tag = dataRow["id"];
				switch (Convert.ToInt32(dataRow["typeCodeId"]))
				{
				case 535:
					treeNode6.Text = "ПП-" + treeNode6.Text;
					treeNode5.Nodes.Add(treeNode6);
					break;
				case 536:
					treeNode6.Text = "ЦП-" + treeNode6.Text;
					treeNode3.Nodes.Add(treeNode6);
					break;
				case 537:
					treeNode6.Text = "РП-" + treeNode6.Text;
					treeNode4.Nodes.Add(treeNode6);
					break;
				case 538:
					treeNode6.Text = "ТП-" + treeNode6.Text;
					treeNode2.Nodes.Add(treeNode6);
					break;
				}
				foreach (DataRow dataRow2 in this.class19_0.vSchm_ObjList.Select(" idParent = " + Convert.ToInt32(dataRow["id"])))
				{
					TreeNode treeNode7 = new TreeNode(dataRow2["NameTypeSocr"].ToString());
					treeNode7.Tag = dataRow2["id"];
					treeNode6.Nodes.Add(treeNode7);
				}
			}
			treeNode.Expand();
			this.treeView_0.SelectedNode = treeNode;
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			this.method_5(this.treeView_0, this.toolStripTextBox_0.Text, (FormLinkCellPoint.Enum1)0);
		}

		private void EpeqNqiisT(object sender, EventArgs e)
		{
			this.method_5(this.treeView_0, this.toolStripTextBox_0.Text, (FormLinkCellPoint.Enum1)2);
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			this.method_5(this.treeView_0, this.toolStripTextBox_0.Text, (FormLinkCellPoint.Enum1)1);
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
				this.EpeqNqiisT(sender, e);
			}
		}

		private void treeView_0_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node.IsSelected)
			{
				switch (e.Node.Level)
				{
				case 0:
					if (this.list_0 == null)
					{
						base.SelectSqlData(this.class19_0, this.class19_0.vL_CellPointAbn, true);
					}
					else if (this.yoOqbSmYoi != "")
					{
						base.SelectSqlData(this.class19_0, this.class19_0.vL_CellPointAbn, true, " where idSchmObj in (select id from tSChm_ObjList where idParent in (" + this.yoOqbSmYoi + "))");
					}
					break;
				case 1:
					if (this.list_0 == null)
					{
						base.SelectSqlData(this.class19_0, this.class19_0.vL_CellPointAbn, true, " where idSchmObj in (select id from tSChm_ObjList where idParent in (select id from tSChm_ObjList where typeCodeId = " + e.Node.Tag.ToString() + "))");
					}
					else if (this.yoOqbSmYoi != "")
					{
						base.SelectSqlData(this.class19_0, this.class19_0.vL_CellPointAbn, true, string.Concat(new string[]
						{
							" where idSchmObj in (select id from tSChm_ObjList where idParent in (",
							this.yoOqbSmYoi,
							"))  and idSchmObj in (select id from tSChm_ObjList where idParent in (select id from tSChm_ObjList where typeCodeId = ",
							e.Node.Tag.ToString(),
							"))"
						}));
					}
					break;
				case 2:
					base.SelectSqlData(this.class19_0, this.class19_0.vL_CellPointAbn, true, " where idSchmObj in (select id from tSChm_ObjList where idParent in (select id from tSChm_ObjList where id = " + e.Node.Tag.ToString() + "))");
					break;
				case 3:
					base.SelectSqlData(this.class19_0, this.class19_0.vL_CellPointAbn, true, " where idSchmObj = " + e.Node.Tag.ToString());
					break;
				}
				this.method_2();
			}
			if (this.class19_0.vL_CellPointAbn.Rows.Count == 0)
			{
				this.bindingSource_1.Filter = " idLink = -1";
			}
		}

		private void method_2()
		{
			this.treeView_1.Nodes.Clear();
			TreeNode treeNode = new TreeNode("Все адреса");
			this.treeView_1.Nodes.Add(treeNode);
			var enumerable = from row in this.class19_0.vL_CellPointAbn.AsEnumerable<Class19.Class45>()
			group row by new
			{
				idMap = row.Field("idMap"),
				street = row.Field("street"),
				streetName = row.Field("streetName"),
				house = row.Field("house")
			} into grp
			orderby grp.Key.streetName, grp.Key.house
			select new
			{
				Key = grp.Key,
				IdMap = grp.Key.idMap,
				StreetName = grp.Key.streetName,
				Street = grp.Key.street,
				House = grp.Key.house
			};
			string a = "";
			TreeNode treeNode2 = null;
			foreach (var <>f__AnonymousType in enumerable)
			{
				if (a == "" || a != <>f__AnonymousType.StreetName)
				{
					treeNode2 = new TreeNode(<>f__AnonymousType.StreetName.ToString());
					treeNode2.Tag = <>f__AnonymousType.Street;
					treeNode.Nodes.Add(treeNode2);
				}
				TreeNode treeNode3 = new TreeNode("д. " + <>f__AnonymousType.House.ToString());
				treeNode3.Tag = <>f__AnonymousType.IdMap;
				treeNode2.Nodes.Add(treeNode3);
				a = <>f__AnonymousType.StreetName;
			}
			treeNode.Expand();
			this.treeView_1.SelectedNode = treeNode;
		}

		private void treeView_1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node.IsSelected)
			{
				this.method_6();
			}
		}

		private void toolStripButton_6_Click(object sender, EventArgs e)
		{
			this.method_5(this.treeView_1, this.toolStripTextBox_1.Text, (FormLinkCellPoint.Enum1)0);
		}

		private void toolStripButton_7_Click(object sender, EventArgs e)
		{
			this.method_5(this.treeView_1, this.toolStripTextBox_1.Text, (FormLinkCellPoint.Enum1)2);
		}

		private void toolStripButton_8_Click(object sender, EventArgs e)
		{
			this.method_5(this.treeView_1, this.toolStripTextBox_1.Text, (FormLinkCellPoint.Enum1)1);
		}

		private void toolStripTextBox_1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				Keys modifiers = e.Modifiers;
				if (modifiers == Keys.None)
				{
					this.toolStripButton_8_Click(sender, e);
					return;
				}
				if (modifiers != Keys.Shift)
				{
					return;
				}
				this.toolStripButton_7_Click(sender, e);
			}
		}

		private List<TreeNode> method_3(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_1)
		{
			foreach (object obj in treeNodeCollection_0)
			{
				TreeNode treeNode = (TreeNode)obj;
				list_1.Add(treeNode);
				list_1 = this.method_3(treeNode.Nodes, list_1);
			}
			return list_1;
		}

		private TreeNode method_4(List<TreeNode> list_1, TreeNode treeNode_0, string string_3, FormLinkCellPoint.Enum1 enum1_0)
		{
			bool flag = enum1_0 == (FormLinkCellPoint.Enum1)0;
			if (enum1_0 == (FormLinkCellPoint.Enum1)2)
			{
				list_1.Reverse();
			}
			foreach (TreeNode treeNode in list_1)
			{
				if (flag && treeNode.Text.ToUpper().Contains(string_3.ToUpper()))
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

		private void method_5(TreeView treeView_2, string string_3, FormLinkCellPoint.Enum1 enum1_0)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_3(treeView_2.Nodes, list_);
			TreeNode treeNode = this.method_4(list_, treeView_2.SelectedNode, string_3, enum1_0);
			if (treeNode != null)
			{
				treeView_2.SelectedNode = treeNode;
				treeView_2.SelectedNode.Expand();
			}
		}

		private void djcuuNowSx_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if ((int)this.djcuuNowSx["typeAbnDgvColumn", e.RowIndex].Value != 206)
				{
					if ((int)this.djcuuNowSx["typeAbnDgvColumn", e.RowIndex].Value != 253)
					{
						e.CellStyle.BackColor = Color.LightGray;
						goto IL_7E;
					}
				}
				e.CellStyle.BackColor = Color.White;
				IL_7E:
				if (this.djcuuNowSx["activeAbnDgvColumn", e.RowIndex].Value == DBNull.Value)
				{
					if (this.djcuuNowSx.Columns[e.ColumnIndex].Name == "codeAbnDgvColumn")
					{
						e.CellStyle.BackColor = Color.Red;
					}
				}
				else if (!(bool)this.djcuuNowSx["activeAbnDgvColumn", e.RowIndex].Value)
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);
				}
				if (!(bool)this.djcuuNowSx["OnSchmObjDgvColumn", e.RowIndex].Value && this.djcuuNowSx.Columns[e.ColumnIndex].Name == "SchmObjNameDgvColumn")
				{
					e.CellStyle.ForeColor = Color.OrangeRed;
				}
				if (!(bool)this.djcuuNowSx["OnPointDgvColumn", e.RowIndex].Value && this.djcuuNowSx.Columns[e.ColumnIndex].Name != "SchmObjNameDgvColumn")
				{
					e.CellStyle.ForeColor = Color.OrangeRed;
				}
			}
		}

		private void djcuuNowSx_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				this.bindingSource_1.Filter = " idLink = " + this.djcuuNowSx["idDgvColumn", e.RowIndex].Value.ToString();
			}
		}

		private void djcuuNowSx_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
			{
				if (this.djcuuNowSx.SelectedRows.Count > 1)
				{
					this.toolStripMenuItem_0.Visible = false;
				}
				else
				{
					this.toolStripMenuItem_0.Visible = true;
				}
				this.VwPqkvgtEt.Show(Cursor.Position);
			}
		}

		private void toolStripButton_3_Click(object sender, EventArgs e)
		{
			int idSubstation = -1;
			int idCell = -1;
			if (this.treeView_0.SelectedNode.Level == 2)
			{
				idSubstation = Convert.ToInt32(this.treeView_0.SelectedNode.Tag);
			}
			if (this.treeView_0.SelectedNode.Level == 3)
			{
				idSubstation = Convert.ToInt32(this.treeView_0.SelectedNode.Parent.Tag);
				idCell = Convert.ToInt32(this.treeView_0.SelectedNode.Tag);
			}
			new FormLinkCellPointAdd(idSubstation, idCell)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
			this.HbiqDlAckJ(sender, e);
		}

		private void toolStripButton_4_Click(object sender, EventArgs e)
		{
			if (this.djcuuNowSx.SelectedRows.Count > 0 && MessageBox.Show("Вы уверены, что хотите удалить выделенные привязки?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				foreach (object obj in this.djcuuNowSx.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					if (base.DeleteSqlDataById(this.class19_0.tL_CellPoint, Convert.ToInt32(dataGridViewRow.Cells["idDgvColumn"].Value)))
					{
						this.djcuuNowSx.Rows.Remove(dataGridViewRow);
					}
				}
			}
		}

		private void HbiqDlAckJ(object sender, EventArgs e)
		{
			TreeViewEventArgs e2 = new TreeViewEventArgs(this.treeView_0.SelectedNode);
			this.treeView_0_AfterSelect(this.treeView_0, e2);
		}

		private void method_6()
		{
			this.bindingSource_0.Filter = "";
			if (this.treeView_1.SelectedNode != null)
			{
				switch (this.treeView_1.SelectedNode.Level)
				{
				case 0:
					this.bindingSource_0.Filter = "";
					break;
				case 1:
					this.bindingSource_0.Filter = "street = " + this.treeView_1.SelectedNode.Tag.ToString();
					break;
				case 2:
					this.bindingSource_0.Filter = "idMap = " + this.treeView_1.SelectedNode.Tag.ToString();
					break;
				}
			}
			if (!this.toolStripMenuItem_5.Checked)
			{
				this.bindingSource_0.Filter = ((this.bindingSource_0.Filter == "") ? " ActiveAbn = 1 " : (this.bindingSource_0.Filter + " and ActiveAbn = 1 "));
			}
			if (!this.toolStripMenuItem_6.Checked)
			{
				string text = string.Concat(new string[]
				{
					" (typeAbn <>  ",
					206.ToString(),
					" and typeAbn <> + ",
					253.ToString(),
					") "
				});
				this.bindingSource_0.Filter = ((this.bindingSource_0.Filter == "") ? text : (this.bindingSource_0.Filter + " and " + text));
			}
			if (!this.toolStripMenuItem_7.Checked)
			{
				string text2 = " (typeAbn not in ( 207,231,230)) ";
				this.bindingSource_0.Filter = ((this.bindingSource_0.Filter == "") ? text2 : (this.bindingSource_0.Filter + " and " + text2));
			}
		}

		private void toolStripMenuItem_5_Click(object sender, EventArgs e)
		{
			this.method_6();
		}

		private void toolStripMenuItem_6_Click(object sender, EventArgs e)
		{
			this.method_6();
		}

		private void toolStripMenuItem_7_Click(object sender, EventArgs e)
		{
			this.method_6();
		}

		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			if (this.djcuuNowSx.SelectedRows.Count > 0)
			{
				int activeObj = Convert.ToInt32(this.djcuuNowSx.SelectedRows[0].Cells["idSchmObjDgvColumn"].Value);
				new FormGeneralScheme2(eTypeCanvas.SchemeSecond, activeObj)
				{
					SqlSettings = this.SqlSettings,
					MdiParent = base.MdiParent
				}.Show();
			}
		}

		private void toolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			if (this.djcuuNowSx.SelectedRows.Count > 0)
			{
				int num = Convert.ToInt32(this.djcuuNowSx.SelectedRows[0].Cells["typeAbnDgvColumn"].Value);
				if (num == 206 || num == 253)
				{
					new FormAbonent(Convert.ToInt32(this.djcuuNowSx.SelectedRows[0].Cells["codeAbnDgvColumn"].Value), num)
					{
						SqlSettings = this.SqlSettings,
						MdiParent = base.MdiParent
					}.Show();
				}
				if (num == 207 || num == 614 || num == 231 || num == 230)
				{
					new FormAbn
					{
						SqlSettings = this.SqlSettings,
						MdiParent = base.MdiParent
					}.Show();
				}
			}
		}

		private void toolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			this.toolStripButton_4_Click(sender, e);
		}

		private void toolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			if (this.djcuuNowSx.SelectedRows.Count > 0)
			{
				List<int> list = new List<int>();
				foreach (object obj in this.djcuuNowSx.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					list.Add(Convert.ToInt32(dataGridViewRow.Cells["idDgvColumn"].Value));
				}
				if (new FormLinkOnOffAbn(list)
				{
					SqlSettings = this.SqlSettings
				}.ShowDialog() == DialogResult.OK)
				{
					TreeViewEventArgs e2 = new TreeViewEventArgs(this.treeView_0.SelectedNode);
					this.treeView_0_AfterSelect(this.treeView_0, e2);
					base.SelectSqlData(this.class19_0, this.class19_0.tL_CellPointReg, true);
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

		private void method_7()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.class19_0 = new Class19();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.VwPqkvgtEt = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripMenuItem_2 = new ToolStripMenuItem();
			this.toolStripMenuItem_4 = new ToolStripMenuItem();
			this.toolStripMenuItem_3 = new ToolStripMenuItem();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.OfoqiaJxAa = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
			this.tabPage_0 = new TabPage();
			this.splitContainer_0 = new SplitContainer();
			this.treeView_0 = new TreeView();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripTextBox_0 = new ToolStripTextBox();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.splitContainer_1 = new SplitContainer();
			this.splitContainer_2 = new SplitContainer();
			this.djcuuNowSx = new DataGridViewExcelFilter();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
			this.OwTuWoMsuj = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
			this.toolStrip_1 = new ToolStrip();
			this.toolStripButton_3 = new ToolStripButton();
			this.toolStripButton_4 = new ToolStripButton();
			this.toolStripButton_5 = new ToolStripButton();
			this.toolStripSplitButton_0 = new ToolStripSplitButton();
			this.toolStripMenuItem_5 = new ToolStripMenuItem();
			this.toolStripMenuItem_6 = new ToolStripMenuItem();
			this.toolStripMenuItem_7 = new ToolStripMenuItem();
			this.label_0 = new Label();
			this.treeView_1 = new TreeView();
			this.toolStrip_2 = new ToolStrip();
			this.toolStripButton_6 = new ToolStripButton();
			this.toolStripTextBox_1 = new ToolStripTextBox();
			this.toolStripButton_7 = new ToolStripButton();
			this.toolStripButton_8 = new ToolStripButton();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewCheckBoxColumn_3 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_4 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
			this.label_1 = new Label();
			this.toolStrip_3 = new ToolStrip();
			this.tabControl_0 = new TabControl();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.class19_0).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			this.VwPqkvgtEt.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.splitContainer_0.Panel1.SuspendLayout();
			this.splitContainer_0.Panel2.SuspendLayout();
			this.splitContainer_0.SuspendLayout();
			this.toolStrip_0.SuspendLayout();
			this.splitContainer_1.Panel1.SuspendLayout();
			this.splitContainer_1.Panel2.SuspendLayout();
			this.splitContainer_1.SuspendLayout();
			this.splitContainer_2.Panel1.SuspendLayout();
			this.splitContainer_2.Panel2.SuspendLayout();
			this.splitContainer_2.SuspendLayout();
			this.djcuuNowSx.BeginInit();
			this.toolStrip_1.SuspendLayout();
			this.toolStrip_2.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			this.tabControl_0.SuspendLayout();
			base.SuspendLayout();
			this.bindingSource_0.DataMember = "vL_CellPointAbn";
			this.bindingSource_0.DataSource = this.class19_0;
			this.class19_0.DataSetName = "DataSetScheme";
			this.class19_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.bindingSource_1.DataMember = "tL_CellPointReg";
			this.bindingSource_1.DataSource = this.class19_0;
			this.bindingSource_1.Sort = "DateChange desc";
			this.VwPqkvgtEt.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_4,
				this.toolStripMenuItem_3
			});
			this.VwPqkvgtEt.Name = "contextMenuSchmAbn";
			this.VwPqkvgtEt.Size = new Size(173, 70);
			this.toolStripMenuItem_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_1,
				this.toolStripMenuItem_2
			});
			this.toolStripMenuItem_0.Name = "toolMenuDgvSchmAbnOpen";
			this.toolStripMenuItem_0.Size = new Size(172, 22);
			this.toolStripMenuItem_0.Text = "Открыть";
			this.toolStripMenuItem_1.Name = "toolMenuDgvSchmAbnOpenCell";
			this.toolStripMenuItem_1.Size = new Size(228, 22);
			this.toolStripMenuItem_1.Text = "Открыть ячейку на схеме";
			this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
			this.toolStripMenuItem_2.Name = "toolMenuDgvSchmAbnOpenAbn";
			this.toolStripMenuItem_2.Size = new Size(228, 22);
			this.toolStripMenuItem_2.Text = "Открыть карточку абонента";
			this.toolStripMenuItem_2.Click += this.toolStripMenuItem_2_Click;
			this.toolStripMenuItem_4.Name = "toolMenuDgvSchmAbnDelLink";
			this.toolStripMenuItem_4.Size = new Size(172, 22);
			this.toolStripMenuItem_4.Text = "Удалить привязки";
			this.toolStripMenuItem_4.Click += this.toolStripMenuItem_4_Click;
			this.toolStripMenuItem_3.Name = "toolMenuOnOffAbn";
			this.toolStripMenuItem_3.Size = new Size(172, 22);
			this.toolStripMenuItem_3.Text = "Вкл/откл";
			this.toolStripMenuItem_3.Click += this.toolStripMenuItem_3_Click;
			this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "SchmObjName";
			this.dataGridViewTextBoxColumn_0.FillWeight = 15f;
			this.dataGridViewTextBoxColumn_0.HeaderText = "Ячейка";
			this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "CodeAbonent";
			this.dataGridViewTextBoxColumn_1.FillWeight = 10f;
			this.dataGridViewTextBoxColumn_1.HeaderText = "Код";
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_2.FillWeight = 25f;
			this.dataGridViewTextBoxColumn_2.HeaderText = "Абонент";
			this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "streetName";
			this.dataGridViewTextBoxColumn_3.FillWeight = 25f;
			this.dataGridViewTextBoxColumn_3.HeaderText = "Улица";
			this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "house";
			this.dataGridViewTextBoxColumn_4.FillWeight = 8f;
			this.dataGridViewTextBoxColumn_4.HeaderText = "Дом";
			this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "objName";
			this.dataGridViewTextBoxColumn_5.FillWeight = 25f;
			this.dataGridViewTextBoxColumn_5.HeaderText = "Объект";
			this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "pName";
			this.dataGridViewTextBoxColumn_6.FillWeight = 7f;
			this.dataGridViewTextBoxColumn_6.HeaderText = "Т.У.";
			this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_7.HeaderText = "id";
			this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "idSchmObj";
			this.dataGridViewTextBoxColumn_8.HeaderText = "idSchmObj";
			this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "idPoint";
			this.dataGridViewTextBoxColumn_9.HeaderText = "idPoint";
			this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "idAbnObj";
			this.dataGridViewTextBoxColumn_10.HeaderText = "idAbnObj";
			this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.Visible = false;
			this.OfoqiaJxAa.DataPropertyName = "DateBegin";
			this.OfoqiaJxAa.HeaderText = "DateBegin";
			this.OfoqiaJxAa.Name = "dataGridViewTextBoxColumn12";
			this.OfoqiaJxAa.ReadOnly = true;
			this.OfoqiaJxAa.Visible = false;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "DateEnd";
			this.dataGridViewTextBoxColumn_11.HeaderText = "DateEnd";
			this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "idABn";
			this.dataGridViewTextBoxColumn_12.HeaderText = "idABn";
			this.dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "TypeAbn";
			this.dataGridViewTextBoxColumn_13.HeaderText = "TypeAbn";
			this.dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn15";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.Visible = false;
			this.dataGridViewTextBoxColumn_14.DataPropertyName = "idMap";
			this.dataGridViewTextBoxColumn_14.HeaderText = "idMap";
			this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn16";
			this.dataGridViewTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewTextBoxColumn_14.Visible = false;
			this.dataGridViewTextBoxColumn_15.DataPropertyName = "Street";
			this.dataGridViewTextBoxColumn_15.HeaderText = "Street";
			this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn17";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_15.Visible = false;
			this.dataGridViewTextBoxColumn_16.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_16.HeaderText = "id";
			this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn18";
			this.dataGridViewTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewTextBoxColumn_16.Visible = false;
			this.dataGridViewTextBoxColumn_17.DataPropertyName = "idLink";
			this.dataGridViewTextBoxColumn_17.HeaderText = "idLink";
			this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn19";
			this.dataGridViewTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewTextBoxColumn_17.Visible = false;
			this.dataGridViewTextBoxColumn_18.DataPropertyName = "DateChange";
			this.dataGridViewTextBoxColumn_18.HeaderText = "Дата изменения";
			this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn20";
			this.dataGridViewTextBoxColumn_18.ReadOnly = true;
			this.dataGridViewTextBoxColumn_18.Width = 150;
			this.dataGridViewTextBoxColumn_19.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_19.HeaderText = "Comment";
			this.dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn21";
			this.dataGridViewTextBoxColumn_19.ReadOnly = true;
			this.dataGridViewTextBoxColumn_19.Visible = false;
			this.tabPage_0.Controls.Add(this.splitContainer_0);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tabPageSchm";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(849, 480);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Объекты схемы";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.splitContainer_0.Dock = DockStyle.Fill;
			this.splitContainer_0.FixedPanel = FixedPanel.Panel1;
			this.splitContainer_0.Location = new Point(3, 3);
			this.splitContainer_0.Name = "splitContainerSchm";
			this.splitContainer_0.Panel1.Controls.Add(this.treeView_0);
			this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_0);
			this.splitContainer_0.Panel2.Controls.Add(this.splitContainer_1);
			this.splitContainer_0.Size = new Size(843, 474);
			this.splitContainer_0.SplitterDistance = 151;
			this.splitContainer_0.TabIndex = 1;
			this.treeView_0.Dock = DockStyle.Fill;
			this.treeView_0.HideSelection = false;
			this.treeView_0.Location = new Point(0, 25);
			this.treeView_0.Name = "treeViewSchm";
			this.treeView_0.Size = new Size(151, 449);
			this.treeView_0.TabIndex = 0;
			this.treeView_0.AfterSelect += this.treeView_0_AfterSelect;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripTextBox_0,
				this.toolStripButton_1,
				this.toolStripButton_2
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStripSchmObj";
			this.toolStrip_0.Size = new Size(151, 25);
			this.toolStrip_0.TabIndex = 1;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.smethod_28();
			this.toolStripButton_0.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_0.Name = "toolBtnFind";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Поиск сначала";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripTextBox_0.Name = "toolTextBoxFind";
			this.toolStripTextBox_0.Size = new Size(70, 25);
			this.toolStripTextBox_0.ToolTipText = "Текст для поиск";
			this.toolStripTextBox_0.KeyDown += this.toolStripTextBox_0_KeyDown;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.smethod_30();
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "toolBtnFindPrev";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Поиск назад";
			this.toolStripButton_1.Click += this.EpeqNqiisT;
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources.smethod_29();
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "toolBtnFindNext";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Поиск вперед";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.splitContainer_1.Dock = DockStyle.Fill;
			this.splitContainer_1.Location = new Point(0, 0);
			this.splitContainer_1.Name = "splitContainer1";
			this.splitContainer_1.Orientation = Orientation.Horizontal;
			this.splitContainer_1.Panel1.Controls.Add(this.splitContainer_2);
			this.splitContainer_1.Panel2.Controls.Add(this.dataGridView_0);
			this.splitContainer_1.Panel2.Controls.Add(this.label_1);
			this.splitContainer_1.Size = new Size(688, 474);
			this.splitContainer_1.SplitterDistance = 337;
			this.splitContainer_1.TabIndex = 4;
			this.splitContainer_2.Dock = DockStyle.Fill;
			this.splitContainer_2.FixedPanel = FixedPanel.Panel2;
			this.splitContainer_2.Location = new Point(0, 0);
			this.splitContainer_2.Name = "splitContainerSchmAbn";
			this.splitContainer_2.Panel1.Controls.Add(this.djcuuNowSx);
			this.splitContainer_2.Panel1.Controls.Add(this.toolStrip_1);
			this.splitContainer_2.Panel1.Controls.Add(this.label_0);
			this.splitContainer_2.Panel2.Controls.Add(this.treeView_1);
			this.splitContainer_2.Panel2.Controls.Add(this.toolStrip_2);
			this.splitContainer_2.Size = new Size(688, 337);
			this.splitContainer_2.SplitterDistance = 527;
			this.splitContainer_2.TabIndex = 3;
			this.djcuuNowSx.AllowUserToAddRows = false;
			this.djcuuNowSx.AllowUserToDeleteRows = false;
			this.djcuuNowSx.AutoGenerateColumns = false;
			this.djcuuNowSx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.djcuuNowSx.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_0,
				this.dataGridViewCheckBoxColumn_1,
				this.dataGridViewCheckBoxColumn_2,
				this.dataGridViewTextBoxColumn_20,
				this.dataGridViewTextBoxColumn_21,
				this.dataGridViewTextBoxColumn_22,
				this.dataGridViewTextBoxColumn_23,
				this.dataGridViewTextBoxColumn_24,
				this.dataGridViewTextBoxColumn_25,
				this.dataGridViewTextBoxColumn_26,
				this.dataGridViewTextBoxColumn_27,
				this.dataGridViewTextBoxColumn_28,
				this.dataGridViewTextBoxColumn_29,
				this.dataGridViewTextBoxColumn_30,
				this.dataGridViewTextBoxColumn_31,
				this.dataGridViewTextBoxColumn_32,
				this.dataGridViewTextBoxColumn_33,
				this.OwTuWoMsuj,
				this.dataGridViewTextBoxColumn_34,
				this.dataGridViewTextBoxColumn_35
			});
			this.djcuuNowSx.DataSource = this.bindingSource_0;
			this.djcuuNowSx.Dock = DockStyle.Fill;
			this.djcuuNowSx.Location = new Point(0, 38);
			this.djcuuNowSx.Name = "dgvSchmAbn";
			this.djcuuNowSx.ReadOnly = true;
			this.djcuuNowSx.RowHeadersWidth = 21;
			this.djcuuNowSx.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.djcuuNowSx.Size = new Size(527, 299);
			this.djcuuNowSx.TabIndex = 1;
			this.djcuuNowSx.VirtualMode = true;
			this.djcuuNowSx.CellFormatting += this.djcuuNowSx_CellFormatting;
			this.djcuuNowSx.CellMouseClick += this.djcuuNowSx_CellMouseClick;
			this.djcuuNowSx.RowEnter += this.djcuuNowSx_RowEnter;
			this.dataGridViewCheckBoxColumn_0.DataPropertyName = "OnSchmObj";
			this.dataGridViewCheckBoxColumn_0.HeaderText = "OnSchmObj";
			this.dataGridViewCheckBoxColumn_0.Name = "OnSchmObjDgvColumn";
			this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.Visible = false;
			this.dataGridViewCheckBoxColumn_1.DataPropertyName = "OnPoint";
			this.dataGridViewCheckBoxColumn_1.HeaderText = "OnPoint";
			this.dataGridViewCheckBoxColumn_1.Name = "OnPointDgvColumn";
			this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_1.Visible = false;
			this.dataGridViewCheckBoxColumn_2.DataPropertyName = "ActiveAbn";
			this.dataGridViewCheckBoxColumn_2.HeaderText = "ActiveAbn";
			this.dataGridViewCheckBoxColumn_2.Name = "activeAbnDgvColumn";
			this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_20.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_20.DataPropertyName = "SchmObjName";
			this.dataGridViewTextBoxColumn_20.FillWeight = 15f;
			this.dataGridViewTextBoxColumn_20.HeaderText = "Ячейка";
			this.dataGridViewTextBoxColumn_20.Name = "SchmObjNameDgvColumn";
			this.dataGridViewTextBoxColumn_20.ReadOnly = true;
			this.dataGridViewTextBoxColumn_21.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_21.DataPropertyName = "CodeAbonent";
			this.dataGridViewTextBoxColumn_21.FillWeight = 10f;
			this.dataGridViewTextBoxColumn_21.HeaderText = "Код";
			this.dataGridViewTextBoxColumn_21.Name = "codeAbnDgvColumn";
			this.dataGridViewTextBoxColumn_21.ReadOnly = true;
			this.dataGridViewTextBoxColumn_22.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_22.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_22.FillWeight = 25f;
			this.dataGridViewTextBoxColumn_22.HeaderText = "Абонент";
			this.dataGridViewTextBoxColumn_22.Name = "nameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_22.ReadOnly = true;
			this.dataGridViewTextBoxColumn_23.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_23.DataPropertyName = "streetName";
			this.dataGridViewTextBoxColumn_23.FillWeight = 25f;
			this.dataGridViewTextBoxColumn_23.HeaderText = "Улица";
			this.dataGridViewTextBoxColumn_23.Name = "streetNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_23.ReadOnly = true;
			this.dataGridViewTextBoxColumn_24.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_24.DataPropertyName = "house";
			this.dataGridViewTextBoxColumn_24.FillWeight = 8f;
			this.dataGridViewTextBoxColumn_24.HeaderText = "Дом";
			this.dataGridViewTextBoxColumn_24.Name = "houseDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_24.ReadOnly = true;
			this.dataGridViewTextBoxColumn_25.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_25.DataPropertyName = "objName";
			this.dataGridViewTextBoxColumn_25.FillWeight = 25f;
			this.dataGridViewTextBoxColumn_25.HeaderText = "Объект";
			this.dataGridViewTextBoxColumn_25.Name = "objNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_25.ReadOnly = true;
			this.dataGridViewTextBoxColumn_26.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_26.DataPropertyName = "pName";
			this.dataGridViewTextBoxColumn_26.FillWeight = 7f;
			this.dataGridViewTextBoxColumn_26.HeaderText = "Т.У.";
			this.dataGridViewTextBoxColumn_26.Name = "pNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_26.ReadOnly = true;
			this.dataGridViewTextBoxColumn_27.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_27.HeaderText = "id";
			this.dataGridViewTextBoxColumn_27.Name = "idDgvColumn";
			this.dataGridViewTextBoxColumn_27.ReadOnly = true;
			this.dataGridViewTextBoxColumn_27.Visible = false;
			this.dataGridViewTextBoxColumn_28.DataPropertyName = "idSchmObj";
			this.dataGridViewTextBoxColumn_28.HeaderText = "idSchmObj";
			this.dataGridViewTextBoxColumn_28.Name = "idSchmObjDgvColumn";
			this.dataGridViewTextBoxColumn_28.ReadOnly = true;
			this.dataGridViewTextBoxColumn_28.Visible = false;
			this.dataGridViewTextBoxColumn_29.DataPropertyName = "idPoint";
			this.dataGridViewTextBoxColumn_29.HeaderText = "idPoint";
			this.dataGridViewTextBoxColumn_29.Name = "idPointDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_29.ReadOnly = true;
			this.dataGridViewTextBoxColumn_29.Visible = false;
			this.dataGridViewTextBoxColumn_30.DataPropertyName = "idAbnObj";
			this.dataGridViewTextBoxColumn_30.HeaderText = "idAbnObj";
			this.dataGridViewTextBoxColumn_30.Name = "idAbnObjDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_30.ReadOnly = true;
			this.dataGridViewTextBoxColumn_30.Visible = false;
			this.dataGridViewTextBoxColumn_31.DataPropertyName = "DateBegin";
			this.dataGridViewTextBoxColumn_31.HeaderText = "DateBegin";
			this.dataGridViewTextBoxColumn_31.Name = "dateBeginDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_31.ReadOnly = true;
			this.dataGridViewTextBoxColumn_31.Visible = false;
			this.dataGridViewTextBoxColumn_32.DataPropertyName = "DateEnd";
			this.dataGridViewTextBoxColumn_32.HeaderText = "DateEnd";
			this.dataGridViewTextBoxColumn_32.Name = "dateEndDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_32.ReadOnly = true;
			this.dataGridViewTextBoxColumn_32.Visible = false;
			this.dataGridViewTextBoxColumn_33.DataPropertyName = "idABn";
			this.dataGridViewTextBoxColumn_33.HeaderText = "idABn";
			this.dataGridViewTextBoxColumn_33.Name = "idABnDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_33.ReadOnly = true;
			this.dataGridViewTextBoxColumn_33.Visible = false;
			this.OwTuWoMsuj.DataPropertyName = "TypeAbn";
			this.OwTuWoMsuj.HeaderText = "TypeAbn";
			this.OwTuWoMsuj.Name = "typeAbnDgvColumn";
			this.OwTuWoMsuj.ReadOnly = true;
			this.OwTuWoMsuj.Visible = false;
			this.dataGridViewTextBoxColumn_34.DataPropertyName = "idMap";
			this.dataGridViewTextBoxColumn_34.HeaderText = "idMap";
			this.dataGridViewTextBoxColumn_34.Name = "idMapDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_34.ReadOnly = true;
			this.dataGridViewTextBoxColumn_34.Visible = false;
			this.dataGridViewTextBoxColumn_35.DataPropertyName = "Street";
			this.dataGridViewTextBoxColumn_35.HeaderText = "Street";
			this.dataGridViewTextBoxColumn_35.Name = "streetDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_35.ReadOnly = true;
			this.dataGridViewTextBoxColumn_35.Visible = false;
			this.toolStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_3,
				this.toolStripButton_4,
				this.toolStripButton_5,
				this.toolStripSplitButton_0
			});
			this.toolStrip_1.Location = new Point(0, 13);
			this.toolStrip_1.Name = "toolStripDgvSchmAbn";
			this.toolStrip_1.Size = new Size(527, 25);
			this.toolStrip_1.TabIndex = 2;
			this.toolStrip_1.Text = "toolStrip1";
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = Resources.smethod_19();
			this.toolStripButton_3.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_3.Name = "toolBtnAddLink";
			this.toolStripButton_3.Size = new Size(23, 22);
			this.toolStripButton_3.Text = "Добавить привязку";
			this.toolStripButton_3.Click += this.toolStripButton_3_Click;
			this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_4.Image = Resources.smethod_20();
			this.toolStripButton_4.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_4.Name = "toolBtnDelLink";
			this.toolStripButton_4.Size = new Size(23, 22);
			this.toolStripButton_4.Text = "Удалить выделенные привязки";
			this.toolStripButton_4.Click += this.toolStripButton_4_Click;
			this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_5.Image = Resources.smethod_51();
			this.toolStripButton_5.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_5.Name = "toolBtnRefresh";
			this.toolStripButton_5.Size = new Size(23, 22);
			this.toolStripButton_5.Text = "Обновить";
			this.toolStripButton_5.Click += this.HbiqDlAckJ;
			this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_5,
				this.toolStripMenuItem_6,
				this.toolStripMenuItem_7
			});
			this.toolStripSplitButton_0.Image = Resources.smethod_25();
			this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripSplitButton_0.Name = "toolBtnFilterDgvSchmAbn";
			this.toolStripSplitButton_0.Size = new Size(32, 22);
			this.toolStripSplitButton_0.Text = "Фильтр";
			this.toolStripMenuItem_5.CheckOnClick = true;
			this.toolStripMenuItem_5.Image = Resources.smethod_7();
			this.toolStripMenuItem_5.Name = "toolMenuShowNotActiveAbn";
			this.toolStripMenuItem_5.Size = new Size(191, 22);
			this.toolStripMenuItem_5.Text = "Показать неактивных";
			this.toolStripMenuItem_5.Click += this.toolStripMenuItem_5_Click;
			this.toolStripMenuItem_6.Checked = true;
			this.toolStripMenuItem_6.CheckOnClick = true;
			this.toolStripMenuItem_6.CheckState = CheckState.Checked;
			this.toolStripMenuItem_6.Name = "toolMenuShowFL";
			this.toolStripMenuItem_6.Size = new Size(191, 22);
			this.toolStripMenuItem_6.Text = "Физические лица";
			this.toolStripMenuItem_6.Click += this.toolStripMenuItem_6_Click;
			this.toolStripMenuItem_7.Checked = true;
			this.toolStripMenuItem_7.CheckOnClick = true;
			this.toolStripMenuItem_7.CheckState = CheckState.Checked;
			this.toolStripMenuItem_7.Name = "toolMenuShowUL";
			this.toolStripMenuItem_7.Size = new Size(191, 22);
			this.toolStripMenuItem_7.Text = "Юридические лица";
			this.toolStripMenuItem_7.Click += this.toolStripMenuItem_7_Click;
			this.label_0.AutoSize = true;
			this.label_0.Dock = DockStyle.Top;
			this.label_0.Location = new Point(0, 0);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(129, 13);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "Привязанные абоненты";
			this.treeView_1.Dock = DockStyle.Fill;
			this.treeView_1.HideSelection = false;
			this.treeView_1.Location = new Point(0, 25);
			this.treeView_1.Name = "treeViewSchmHouse";
			this.treeView_1.Size = new Size(157, 312);
			this.treeView_1.TabIndex = 2;
			this.treeView_1.AfterSelect += this.treeView_1_AfterSelect;
			this.toolStrip_2.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_6,
				this.toolStripTextBox_1,
				this.toolStripButton_7,
				this.toolStripButton_8
			});
			this.toolStrip_2.Location = new Point(0, 0);
			this.toolStrip_2.Name = "toolStripSchmHouse";
			this.toolStrip_2.Size = new Size(157, 25);
			this.toolStrip_2.TabIndex = 3;
			this.toolStrip_2.Text = "toolStrip1";
			this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_6.Image = Resources.smethod_28();
			this.toolStripButton_6.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_6.Name = "toolBtnFindHouse";
			this.toolStripButton_6.Size = new Size(23, 22);
			this.toolStripButton_6.Text = "Поиск сначала";
			this.toolStripButton_6.Click += this.toolStripButton_6_Click;
			this.toolStripTextBox_1.Name = "txtBoxFindHouse";
			this.toolStripTextBox_1.Size = new Size(70, 25);
			this.toolStripTextBox_1.ToolTipText = "Текст для поиск";
			this.toolStripTextBox_1.KeyDown += this.toolStripTextBox_1_KeyDown;
			this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_7.Image = Resources.smethod_30();
			this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_7.Name = "toolBtnFindPrevHouse";
			this.toolStripButton_7.Size = new Size(23, 22);
			this.toolStripButton_7.Text = "Поиск назад";
			this.toolStripButton_7.Click += this.toolStripButton_7_Click;
			this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_8.Image = Resources.smethod_29();
			this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_8.Name = "toolBtnFindnextHouse";
			this.toolStripButton_8.Size = new Size(23, 22);
			this.toolStripButton_8.Text = "Поиск вперед";
			this.toolStripButton_8.Click += this.toolStripButton_8_Click;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			dataGridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
			this.dataGridView_0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.AutoGenerateColumns = false;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Control;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_3,
				this.dataGridViewCheckBoxColumn_4,
				this.dataGridViewTextBoxColumn_36,
				this.dataGridViewTextBoxColumn_37,
				this.dataGridViewTextBoxColumn_38,
				this.dataGridViewTextBoxColumn_39
			});
			this.dataGridView_0.DataSource = this.bindingSource_1;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Window;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.Location = new Point(0, 13);
			this.dataGridView_0.Name = "dgvCellPointReg";
			this.dataGridView_0.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = SystemColors.Control;
			dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView_0.Size = new Size(688, 120);
			this.dataGridView_0.TabIndex = 1;
			this.dataGridViewCheckBoxColumn_3.DataPropertyName = "OnSchmObj";
			this.dataGridViewCheckBoxColumn_3.HeaderText = "Вкл ячейка";
			this.dataGridViewCheckBoxColumn_3.Name = "onSchmObjDataGridViewCheckBoxColumn";
			this.dataGridViewCheckBoxColumn_3.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_4.DataPropertyName = "OnPoint";
			this.dataGridViewCheckBoxColumn_4.HeaderText = "Вкл точка учета";
			this.dataGridViewCheckBoxColumn_4.Name = "onPointDataGridViewCheckBoxColumn";
			this.dataGridViewCheckBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_36.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_36.HeaderText = "id";
			this.dataGridViewTextBoxColumn_36.Name = "idDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_36.ReadOnly = true;
			this.dataGridViewTextBoxColumn_36.Visible = false;
			this.dataGridViewTextBoxColumn_37.DataPropertyName = "idLink";
			this.dataGridViewTextBoxColumn_37.HeaderText = "idLink";
			this.dataGridViewTextBoxColumn_37.Name = "idLinkDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_37.ReadOnly = true;
			this.dataGridViewTextBoxColumn_37.Visible = false;
			this.dataGridViewTextBoxColumn_38.DataPropertyName = "DateChange";
			this.dataGridViewTextBoxColumn_38.HeaderText = "Дата изменения";
			this.dataGridViewTextBoxColumn_38.Name = "dateChangeDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_38.ReadOnly = true;
			this.dataGridViewTextBoxColumn_38.Width = 150;
			this.dataGridViewTextBoxColumn_39.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_39.HeaderText = "Comment";
			this.dataGridViewTextBoxColumn_39.Name = "commentDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_39.ReadOnly = true;
			this.dataGridViewTextBoxColumn_39.Visible = false;
			this.label_1.AutoSize = true;
			this.label_1.Dock = DockStyle.Top;
			this.label_1.Location = new Point(0, 0);
			this.label_1.Name = "labelCellPointReg";
			this.label_1.Size = new Size(120, 13);
			this.label_1.TabIndex = 0;
			this.label_1.Text = "История подключений";
			this.toolStrip_3.AutoSize = false;
			this.toolStrip_3.CanOverflow = false;
			this.toolStrip_3.Dock = DockStyle.None;
			this.toolStrip_3.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_3.Location = new Point(1, 25);
			this.toolStrip_3.Name = "miniToolStrip";
			this.toolStrip_3.Size = new Size(157, 25);
			this.toolStrip_3.TabIndex = 3;
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Dock = DockStyle.Fill;
			this.tabControl_0.Location = new Point(0, 0);
			this.tabControl_0.Name = "tabControl1";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(857, 506);
			this.tabControl_0.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(857, 506);
			base.Controls.Add(this.tabControl_0);
			base.Name = "FormLinkCellPoint";
			this.Text = "Привязка потребителей к схеме";
			base.Load += this.FormLinkCellPoint_Load;
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.class19_0).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			this.VwPqkvgtEt.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.splitContainer_0.Panel1.ResumeLayout(false);
			this.splitContainer_0.Panel1.PerformLayout();
			this.splitContainer_0.Panel2.ResumeLayout(false);
			this.splitContainer_0.ResumeLayout(false);
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.splitContainer_1.Panel1.ResumeLayout(false);
			this.splitContainer_1.Panel2.ResumeLayout(false);
			this.splitContainer_1.Panel2.PerformLayout();
			this.splitContainer_1.ResumeLayout(false);
			this.splitContainer_2.Panel1.ResumeLayout(false);
			this.splitContainer_2.Panel1.PerformLayout();
			this.splitContainer_2.Panel2.ResumeLayout(false);
			this.splitContainer_2.Panel2.PerformLayout();
			this.splitContainer_2.ResumeLayout(false);
			this.djcuuNowSx.EndInit();
			this.toolStrip_1.ResumeLayout(false);
			this.toolStrip_1.PerformLayout();
			this.toolStrip_2.ResumeLayout(false);
			this.toolStrip_2.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			this.tabControl_0.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private string string_0;

		private string string_1;

		private string string_2;

		private string yoOqbSmYoi;

		private List<int> list_0;

		private IContainer icontainer_0;

		private Class19 class19_0;

		private BindingSource bindingSource_0;

		private BindingSource bindingSource_1;

		private ContextMenuStrip VwPqkvgtEt;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripMenuItem toolStripMenuItem_1;

		private ToolStripMenuItem toolStripMenuItem_2;

		private ToolStripMenuItem toolStripMenuItem_3;

		private ToolStripMenuItem toolStripMenuItem_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn OfoqiaJxAa;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		private TabPage tabPage_0;

		private SplitContainer splitContainer_0;

		private TreeView treeView_0;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripTextBox toolStripTextBox_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripButton toolStripButton_2;

		private SplitContainer splitContainer_1;

		private SplitContainer splitContainer_2;

		private DataGridViewExcelFilter djcuuNowSx;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

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

		private DataGridViewTextBoxColumn OwTuWoMsuj;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;

		private ToolStrip toolStrip_1;

		private ToolStripButton toolStripButton_3;

		private ToolStripButton toolStripButton_4;

		private ToolStripButton toolStripButton_5;

		private ToolStripSplitButton toolStripSplitButton_0;

		private ToolStripMenuItem toolStripMenuItem_5;

		private ToolStripMenuItem toolStripMenuItem_6;

		private ToolStripMenuItem toolStripMenuItem_7;

		private Label label_0;

		private TreeView treeView_1;

		private ToolStrip toolStrip_2;

		private ToolStripButton toolStripButton_6;

		private ToolStripTextBox toolStripTextBox_1;

		private ToolStripButton toolStripButton_7;

		private ToolStripButton toolStripButton_8;

		private DataGridView dataGridView_0;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;

		private Label label_1;

		private ToolStrip toolStrip_3;

		private TabControl tabControl_0;

		private enum Enum1
		{

		}
	}
}
