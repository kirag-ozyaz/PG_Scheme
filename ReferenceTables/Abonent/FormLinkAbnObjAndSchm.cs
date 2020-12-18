using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Documents.Properties;
using FormLbr;

namespace Documents.Forms.Scheme
{
	public partial class FormLinkAbnObjAndSchm : FormBase
	{
		public Dictionary<int, string> LinkObjects
		{
			get
			{
				return this.dictionary_0;
			}
			set
			{
				this.dictionary_0 = value;
			}
		}

		public FormLinkAbnObjAndSchm()
		{
			Class611.H9nE6ZDzTF9kb();
			this.dictionary_0 = new Dictionary<int, string>();
			
			this.method_4();
		}

		private void FormLinkAbnObjAndSchm_Load(object sender, EventArgs e)
		{
			this.method_0();
			this.listBox_0.Items.Clear();
			foreach (int num in this.dictionary_0.Keys)
			{
				this.listBox_0.Items.Add(new FormLinkAbnObjAndSchm.Struct3(num, this.dictionary_0[num]));
			}
		}

		private void method_0()
		{
			Class255 @class = new Class255();
			base.SelectSqlData(@class, @class.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name");
			this.treeView_0.BeginUpdate();
			this.treeView_0.Nodes.Clear();
			foreach (object obj in @class.tR_Classifier.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				TreeNode treeNode = this.treeView_0.Nodes.Add(dataRow["SocrName"].ToString());
				treeNode.Tag = dataRow["id"];
				base.SelectSqlData(@class, @class.vSchm_ObjList, true, " where typeCodeId = " + dataRow["id"].ToString() + " and deleted = 0 order by name");
				foreach (DataRow dataRow2 in @class.vSchm_ObjList)
				{
					TreeNode treeNode2 = treeNode.Nodes.Add(dataRow2["typeCodeSocr"].ToString() + "-" + dataRow2["Name"].ToString());
					treeNode2.Tag = dataRow2["id"];
					treeNode2.Nodes.Add("");
				}
			}
			this.treeView_0.EndUpdate();
		}

		private void treeView_0_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node.Nodes.Count > 0 && e.Node.Level > 0)
			{
				e.Node.Nodes.Clear();
				int i = e.Node.Level;
				Class255 @class;
				if (i != 1)
				{
					if (i != 2)
					{
						return;
					}
					@class = new Class255();
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
					base.SelectSqlData(@class, @class.vSchm_TreeCellLine, true, " where ParentLink in (" + text + ")");
					using (IEnumerator<Class255.Class458> enumerator2 = @class.vSchm_TreeCellLine.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							DataRow dataRow = enumerator2.Current;
							e.Node.Nodes.Add(dataRow["FullName"].ToString()).Tag = dataRow["id"];
						}
						return;
					}
				}
				@class = new Class255();
				base.SelectSqlData(@class, @class.tR_Classifier, true, " where ParentKey like ';SCM;BUS;%' and deleted = 0 and isgroup = 0 ");
				string text2 = "";
				foreach (object obj2 in @class.tR_Classifier.Rows)
				{
					DataRow dataRow2 = (DataRow)obj2;
					text2 = text2 + dataRow2["id"].ToString() + ",";
				}
				text2 = text2.Remove(text2.Length - 1);
				base.SelectSqlData(@class, @class.vSchm_ObjList, true, string.Concat(new string[]
				{
					" where idParent = ",
					e.Node.Tag.ToString(),
					" and typecodeId in (",
					text2,
					") and deleted = 0"
				}));
				if (!this.checkBox_0.Checked)
				{
					using (IEnumerator<Class255.Class457> enumerator4 = @class.vSchm_ObjList.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							DataRow dataRow3 = enumerator4.Current;
							TreeNode treeNode = e.Node.Nodes.Add(dataRow3["TypeCodeSocr"].ToString() + " - " + dataRow3["Name"].ToString());
							treeNode.Tag = dataRow3["id"];
							treeNode.Nodes.Add("");
						}
						return;
					}
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
				for (i = 0; i < array2.Length; i++)
				{
					DataRow r = array2[i];
					DataRow[] array3 = @class.vSchm_ObjList.Select("id = " + r["id"].ToString());
					TreeNode treeNode2 = e.Node.Nodes.Add(array3[0]["TypeCodeSocr"].ToString() + " - " + array3[0]["Name"].ToString());
					IEnumerable<DataRow> enumerable = from objR in source
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
					DataRow[] array4 = @class.vSchm_ObjList.Select("id = " + dataRow5["id"].ToString());
					TreeNode treeNode3 = e.Node.Nodes.Add(array4[0]["TypeCodeSocr"].ToString() + " - " + array4[0]["Name"].ToString());
					treeNode3.Tag = Convert.ToInt32(dataRow5["id"]);
					treeNode3.Nodes.Add("");
				}
			}
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			List<int> list = new List<int>();
			foreach (object obj in this.treeView_0.Nodes)
			{
				TreeNode treeNode_ = (TreeNode)obj;
				this.method_1(treeNode_, list);
			}
			foreach (int key in list)
			{
				if (!this.dictionary_0.ContainsKey(key))
				{
					this.dictionary_0.Add(key, base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
					{
						key.ToString()
					}).ToString());
				}
			}
			this.listBox_0.Items.Clear();
			foreach (int num in this.dictionary_0.Keys)
			{
				this.listBox_0.Items.Add(new FormLinkAbnObjAndSchm.Struct3(num, this.dictionary_0[num]));
			}
		}

		private void method_1(TreeNode treeNode_0, List<int> list_0)
		{
			if (treeNode_0.Checked && treeNode_0.Tag != null && treeNode_0.Level > 0)
			{
				if (treeNode_0.Tag is int)
				{
					list_0.Add(Convert.ToInt32(treeNode_0.Tag));
				}
				if (treeNode_0.Tag is List<int>)
				{
					list_0.Add(((List<int>)treeNode_0.Tag)[0]);
				}
			}
			foreach (object obj in treeNode_0.Nodes)
			{
				TreeNode treeNode_ = (TreeNode)obj;
				this.method_1(treeNode_, list_0);
			}
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.listBox_0.SelectedItems)
			{
				this.dictionary_0.Remove(((FormLinkAbnObjAndSchm.Struct3)obj).int_0);
			}
			this.listBox_0.Items.Clear();
			foreach (int num in this.dictionary_0.Keys)
			{
				this.listBox_0.Items.Add(new FormLinkAbnObjAndSchm.Struct3(num, this.dictionary_0[num]));
			}
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_2(this.treeView_0.Nodes, list_);
			TreeNode treeNode = this.method_3(list_, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, (FormLinkAbnObjAndSchm.Enum9)0);
			if (treeNode != null)
			{
				this.treeView_0.SelectedNode = treeNode;
				this.treeView_0.SelectedNode.Expand();
			}
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_2(this.treeView_0.Nodes, list_);
			TreeNode treeNode = this.method_3(list_, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, (FormLinkAbnObjAndSchm.Enum9)1);
			if (treeNode != null)
			{
				this.treeView_0.SelectedNode = treeNode;
				this.treeView_0.SelectedNode.Expand();
			}
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			List<TreeNode> list_ = new List<TreeNode>();
			list_ = this.method_2(this.treeView_0.Nodes, list_);
			TreeNode treeNode = this.method_3(list_, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, (FormLinkAbnObjAndSchm.Enum9)2);
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
					this.toolStripButton_1_Click(sender, e);
					return;
				}
				if (modifiers != Keys.Shift)
				{
					return;
				}
				this.toolStripButton_2_Click(sender, e);
			}
		}

		private List<TreeNode> method_2(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_0)
		{
			foreach (object obj in treeNodeCollection_0)
			{
				TreeNode treeNode = (TreeNode)obj;
				list_0.Add(treeNode);
				list_0 = this.method_2(treeNode.Nodes, list_0);
			}
			return list_0;
		}

		private TreeNode method_3(List<TreeNode> list_0, TreeNode treeNode_0, string string_0, FormLinkAbnObjAndSchm.Enum9 enum9_0)
		{
			bool flag = enum9_0 == (FormLinkAbnObjAndSchm.Enum9)0;
			if (enum9_0 == (FormLinkAbnObjAndSchm.Enum9)2)
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

		private void checkBox_0_CheckedChanged(object sender, EventArgs e)
		{
			this.method_0();
		}

		private void method_4()
		{
			this.treeView_0 = new TreeView();
			this.treeView_1 = new TreeView();
			this.listBox_0 = new ListBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.button_2 = new Button();
			this.tMpoJgtvWu9 = new Button();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripTextBox_0 = new ToolStripTextBox();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.checkBox_0 = new CheckBox();
			this.toolStrip_0.SuspendLayout();
			base.SuspendLayout();
			this.treeView_0.CheckBoxes = true;
			this.treeView_0.HideSelection = false;
			this.treeView_0.Location = new Point(2, 28);
			this.treeView_0.Name = "treeViewSubstation";
			this.treeView_0.Size = new Size(210, 404);
			this.treeView_0.TabIndex = 0;
			this.treeView_0.BeforeExpand += this.treeView_0_BeforeExpand;
			this.treeView_1.CheckBoxes = true;
			this.treeView_1.Location = new Point(2, 258);
			this.treeView_1.Name = "treeViewSubs";
			this.treeView_1.Size = new Size(210, 174);
			this.treeView_1.TabIndex = 1;
			this.listBox_0.FormattingEnabled = true;
			this.listBox_0.Location = new Point(277, 25);
			this.listBox_0.Name = "listBoxObjects";
			this.listBox_0.SelectionMode = SelectionMode.MultiExtended;
			this.listBox_0.Size = new Size(232, 407);
			this.listBox_0.Sorted = true;
			this.listBox_0.TabIndex = 2;
			this.button_0.Location = new Point(218, 180);
			this.button_0.Name = "buttonAdd";
			this.button_0.Size = new Size(53, 23);
			this.button_0.TabIndex = 3;
			this.button_0.Text = ">>>";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Location = new Point(218, 279);
			this.button_1.Name = "buttonDel";
			this.button_1.Size = new Size(53, 23);
			this.button_1.TabIndex = 4;
			this.button_1.Text = "<<<";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.button_2.DialogResult = DialogResult.OK;
			this.button_2.Location = new Point(3, 464);
			this.button_2.Name = "buttonOk";
			this.button_2.Size = new Size(75, 23);
			this.button_2.TabIndex = 5;
			this.button_2.Text = "OK";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.tMpoJgtvWu9.DialogResult = DialogResult.Cancel;
			this.tMpoJgtvWu9.Location = new Point(434, 464);
			this.tMpoJgtvWu9.Name = "buttonCancel";
			this.tMpoJgtvWu9.Size = new Size(75, 23);
			this.tMpoJgtvWu9.TabIndex = 6;
			this.tMpoJgtvWu9.Text = "Отмена";
			this.tMpoJgtvWu9.UseVisualStyleBackColor = true;
			this.toolStrip_0.Dock = DockStyle.None;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripTextBox_0,
				this.toolStripButton_1,
				this.toolStripButton_2
			});
			this.toolStrip_0.Location = new Point(3, 0);
			this.toolStrip_0.Name = "toolStrip1";
			this.toolStrip_0.Size = new Size(183, 25);
			this.toolStrip_0.TabIndex = 7;
			this.toolStrip_0.Text = "toolStripTreeSubstations";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.Find;
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "tooBtnFind";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "toolStripButton1";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripTextBox_0.Name = "toolTxtFind";
			this.toolStripTextBox_0.Size = new Size(100, 25);
			this.toolStripTextBox_0.KeyDown += this.toolStripTextBox_0_KeyDown;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.FindNext;
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "toolBtnFindNext";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "toolStripButton1";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources.FindPrev;
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "toolBtnFindPrev";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "toolStripButton2";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 242);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(115, 13);
			this.label_0.TabIndex = 8;
			this.label_0.Text = "Объекты подстанции";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(274, 12);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(124, 13);
			this.label_1.TabIndex = 9;
			this.label_1.Text = "Привязанные объекты";
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Checked = true;
			this.checkBox_0.CheckState = CheckState.Checked;
			this.checkBox_0.Location = new Point(3, 441);
			this.checkBox_0.Name = "checkBoxUseBusParent";
			this.checkBox_0.Size = new Size(109, 17);
			this.checkBox_0.TabIndex = 10;
			this.checkBox_0.Text = "Основные шины";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_0.CheckedChanged += this.checkBox_0_CheckedChanged;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.tMpoJgtvWu9;
			base.ClientSize = new Size(521, 502);
			base.Controls.Add(this.checkBox_0);
			base.Controls.Add(this.treeView_0);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.toolStrip_0);
			base.Controls.Add(this.tMpoJgtvWu9);
			base.Controls.Add(this.button_2);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.listBox_0);
			base.Controls.Add(this.treeView_1);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Name = "FormLinkAbnObjAndSchm";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Привязка объекта к схеме";
			base.Load += this.FormLinkAbnObjAndSchm_Load;
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private Dictionary<int, string> dictionary_0;

		private TreeView treeView_0;

		private TreeView treeView_1;

		private ListBox listBox_0;

		private Button button_0;

		private Button button_1;

		private Button button_2;

		private Button tMpoJgtvWu9;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripTextBox toolStripTextBox_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripButton toolStripButton_2;

		private Label label_0;

		private Label label_1;

		private CheckBox checkBox_0;

		private struct Struct3
		{
			public Struct3(int int_1, string string_1)
			{
				Class611.H9nE6ZDzTF9kb();
				this.string_0 = string_1;
				this.int_0 = int_1;
			}

			public override string ToString()
			{
				return this.string_0;
			}

			public string string_0;

			public int int_0;
		}

		private enum Enum9
		{

		}
	}
}
