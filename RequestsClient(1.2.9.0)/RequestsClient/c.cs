using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;
using RequestsClient.DataSets;
using RequestsClient.Properties;

// Token: 0x02000006 RID: 6
internal partial class c : FormBase
{
	// Token: 0x06000012 RID: 18 RVA: 0x000021CF File Offset: 0x000003CF
	internal Dictionary<int, string> c()
	{
		return this.a;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000021D7 File Offset: 0x000003D7
	internal void a(Dictionary<int, string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000021E0 File Offset: 0x000003E0
	internal short d()
	{
		return this.b;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000021E8 File Offset: 0x000003E8
	internal void a(short A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000021F1 File Offset: 0x000003F1
	internal DateTime e()
	{
		return this.w.Value;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000021FE File Offset: 0x000003FE
	internal void a(DateTime A_0)
	{
		this.w.Value = A_0;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0000220C File Offset: 0x0000040C
	internal DateTime f()
	{
		return this.u.Value;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002219 File Offset: 0x00000419
	internal void b(DateTime A_0)
	{
		this.u.Value = A_0;
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600001A RID: 26 RVA: 0x00002227 File Offset: 0x00000427
	// (set) Token: 0x0600001B RID: 27 RVA: 0x00002234 File Offset: 0x00000434
	internal string Duration
	{
		get
		{
			return this.s.Text;
		}
		set
		{
			this.s.Text = value;
		}
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002242 File Offset: 0x00000442
	internal c()
	{
		this.a();
	}

	// Token: 0x0600001D RID: 29 RVA: 0x0000225C File Offset: 0x0000045C
	private void g(object A_0, EventArgs A_1)
	{
		this.b();
		this.f.Items.Clear();
		foreach (int num in this.a.Keys)
		{
			this.f.Items.Add(new c.a(num, this.a[num]));
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000022EC File Offset: 0x000004EC
	private void b()
	{
		DataSetGES dataSetGES = new DataSetGES();
		base.SelectSqlData(dataSetGES, dataSetGES.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name");
		this.d.BeginUpdate();
		foreach (object obj in dataSetGES.tR_Classifier.Rows)
		{
			DataRow dataRow = (DataRow)obj;
			TreeNode treeNode = this.d.Nodes.Add(dataRow["SocrName"].ToString());
			treeNode.Tag = dataRow["id"];
			base.SelectSqlData(dataSetGES, dataSetGES.vSchm_ObjList, true, " where typeCodeId = " + dataRow["id"].ToString() + " and deleted = 0 order by name");
			foreach (DataRow dataRow2 in dataSetGES.vSchm_ObjList)
			{
				TreeNode treeNode2 = treeNode.Nodes.Add(dataRow2["typeCodeSocr"].ToString() + "-" + dataRow2["Name"].ToString());
				treeNode2.Tag = dataRow2["id"];
				treeNode2.Nodes.Add("");
			}
		}
		this.d.EndUpdate();
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002488 File Offset: 0x00000688
	private void a(object A_0, TreeViewEventArgs A_1)
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x0000248C File Offset: 0x0000068C
	private void a(object A_0, TreeViewCancelEventArgs A_1)
	{
		if (A_1.Node.Nodes.Count > 0 && A_1.Node.Level > 0)
		{
			A_1.Node.Nodes.Clear();
			DataSetGES dataSetGES;
			switch (A_1.Node.Level)
			{
			case 1:
			{
				dataSetGES = new DataSetGES();
				base.SelectSqlData(dataSetGES, dataSetGES.tR_Classifier, true, " where ParentKey like ';SCM;BUS;%' and deleted = 0 and isgroup = 0 ");
				string text = "";
				foreach (object obj in dataSetGES.tR_Classifier.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					text = text + dataRow["id"].ToString() + ",";
				}
				text = text.Remove(text.Length - 1);
				base.SelectSqlData(dataSetGES, dataSetGES.vSchm_ObjList, true, string.Concat(new string[]
				{
					" where idParent = ",
					A_1.Node.Tag.ToString(),
					" and typecodeId in (",
					text,
					") and deleted = 0"
				}));
				using (IEnumerator<DataSetGES.p> enumerator2 = dataSetGES.vSchm_ObjList.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = enumerator2.Current;
						TreeNode treeNode = A_1.Node.Nodes.Add(dataRow2["TypeCodeSocr"].ToString() + " - " + dataRow2["Name"].ToString());
						treeNode.Tag = dataRow2["id"];
						treeNode.Nodes.Add("");
					}
					return;
				}
				break;
			}
			case 2:
				break;
			case 3:
				goto IL_25F;
			default:
				return;
			}
			dataSetGES = new DataSetGES();
			base.SelectSqlData(dataSetGES, dataSetGES.vSchm_TreeCellLine, true, " where ParentLink = " + A_1.Node.Tag.ToString());
			using (IEnumerator<DataSetGES.q> enumerator3 = dataSetGES.vSchm_TreeCellLine.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					DataRow dataRow3 = enumerator3.Current;
					TreeNode treeNode2 = A_1.Node.Nodes.Add(dataRow3["FullName"].ToString());
					treeNode2.Tag = dataRow3["id"];
					treeNode2.Nodes.Add("");
				}
				return;
			}
			IL_25F:
			dataSetGES = new DataSetGES();
			base.SelectSqlData(dataSetGES, dataSetGES.tSchm_Relation, true, " where Edge = " + A_1.Node.Tag.ToString());
			if (dataSetGES.tSchm_Relation.Rows.Count > 0)
			{
				string text = "";
				foreach (DataRow dataRow4 in dataSetGES.tSchm_Relation)
				{
					text = text + dataRow4["id"].ToString() + ",";
				}
				text = text.Remove(text.Length - 1);
				base.SelectSqlData(dataSetGES, dataSetGES.vSchm_ObjList, true, " where idparent in (" + text + ") and deleted = 0");
				foreach (DataRow dataRow5 in dataSetGES.vSchm_ObjList)
				{
					A_1.Node.Nodes.Add(dataRow5["TypeCodeSocr"].ToString() + " - " + dataRow5["Name"].ToString()).Tag = dataRow5["id"];
				}
			}
			dataSetGES = new DataSetGES();
			base.SelectSqlData(dataSetGES, dataSetGES.vSchm_TreeCellLine, true, " where ParentLink = " + A_1.Node.Tag.ToString());
			foreach (DataRow dataRow6 in dataSetGES.vSchm_TreeCellLine)
			{
				A_1.Node.Nodes.Add(dataRow6["FullName"].ToString()).Tag = dataRow6["id"];
			}
		}
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002918 File Offset: 0x00000B18
	private void c(TreeNode A_0)
	{
		DataSetGES dataSetGES = new DataSetGES();
		base.SelectSqlData(dataSetGES, dataSetGES.vSchm_TreeCellLine, true, " where ParentLink = " + A_0.Tag.ToString());
		foreach (DataRow dataRow in dataSetGES.vSchm_TreeCellLine)
		{
			TreeNode treeNode = A_0.Nodes.Add(dataRow["FullName"].ToString());
			treeNode.Tag = dataRow["id"];
			this.b(treeNode);
			this.a(treeNode);
		}
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000029C4 File Offset: 0x00000BC4
	private void b(TreeNode A_0)
	{
		DataSetGES dataSetGES = new DataSetGES();
		base.SelectSqlData(dataSetGES, dataSetGES.tSchm_Relation, true, " where Edge = " + A_0.Tag.ToString());
		if (dataSetGES.tSchm_Relation.Rows.Count > 0)
		{
			string text = "";
			foreach (DataRow dataRow in dataSetGES.tSchm_Relation)
			{
				text = text + dataRow["id"].ToString() + ",";
			}
			text = text.Remove(text.Length - 1);
			base.SelectSqlData(dataSetGES, dataSetGES.vSchm_ObjList, true, " where idparent in (" + text + ") and deleted = 0");
			foreach (DataRow dataRow2 in dataSetGES.vSchm_ObjList)
			{
				A_0.Nodes.Add(dataRow2["TypeCodeSocr"].ToString() + " - " + dataRow2["Name"].ToString()).Tag = dataRow2["id"];
			}
		}
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002B20 File Offset: 0x00000D20
	private void a(TreeNode A_0)
	{
		DataSetGES dataSetGES = new DataSetGES();
		base.SelectSqlData(dataSetGES, dataSetGES.vSchm_TreeCellLine, true, " where ParentLink = " + A_0.Tag.ToString());
		foreach (DataRow dataRow in dataSetGES.vSchm_TreeCellLine)
		{
			A_0.Nodes.Add(dataRow["FullName"].ToString()).Tag = dataRow["id"];
		}
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002BBC File Offset: 0x00000DBC
	private void f(object A_0, EventArgs A_1)
	{
		List<int> list = new List<int>();
		foreach (object obj in this.d.Nodes)
		{
			TreeNode a_ = (TreeNode)obj;
			this.a(a_, list);
		}
		foreach (int key in list)
		{
			if (!this.a.ContainsKey(key))
			{
				this.a.Add(key, base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
				{
					key.ToString()
				}).ToString());
			}
		}
		this.f.Items.Clear();
		foreach (int num in this.a.Keys)
		{
			this.f.Items.Add(new c.a(num, this.a[num]));
		}
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002D14 File Offset: 0x00000F14
	private void a(TreeNode A_0, List<int> A_1)
	{
		if (A_0.Checked && A_0.Tag != null && A_0.Level > 0)
		{
			A_1.Add(Convert.ToInt32(A_0.Tag));
		}
		foreach (object obj in A_0.Nodes)
		{
			TreeNode a_ = (TreeNode)obj;
			this.a(a_, A_1);
		}
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002D98 File Offset: 0x00000F98
	private void e(object A_0, EventArgs A_1)
	{
		foreach (object obj in this.f.SelectedItems)
		{
			this.a.Remove(((c.a)obj).b);
		}
		this.f.Items.Clear();
		foreach (int num in this.a.Keys)
		{
			this.f.Items.Add(new c.a(num, this.a[num]));
		}
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002E7C File Offset: 0x0000107C
	private void d(object A_0, EventArgs A_1)
	{
		base.DialogResult = DialogResult.OK;
		base.Close();
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002E8C File Offset: 0x0000108C
	private void c(object A_0, EventArgs A_1)
	{
		List<TreeNode> list = new List<TreeNode>();
		list = this.a(this.d.Nodes, list);
		TreeNode treeNode = this.a(list, this.d.SelectedNode, this.m.Text, global::c.b.a);
		if (treeNode != null)
		{
			this.d.SelectedNode = treeNode;
			this.d.SelectedNode.Expand();
		}
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002EF0 File Offset: 0x000010F0
	private void b(object A_0, EventArgs A_1)
	{
		List<TreeNode> list = new List<TreeNode>();
		list = this.a(this.d.Nodes, list);
		TreeNode treeNode = this.a(list, this.d.SelectedNode, this.m.Text, global::c.b.b);
		if (treeNode != null)
		{
			this.d.SelectedNode = treeNode;
			this.d.SelectedNode.Expand();
		}
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002F54 File Offset: 0x00001154
	private void a(object A_0, EventArgs A_1)
	{
		List<TreeNode> list = new List<TreeNode>();
		list = this.a(this.d.Nodes, list);
		TreeNode treeNode = this.a(list, this.d.SelectedNode, this.m.Text, global::c.b.c);
		if (treeNode != null)
		{
			this.d.SelectedNode = treeNode;
			this.d.SelectedNode.Expand();
		}
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002FB8 File Offset: 0x000011B8
	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Return)
		{
			Keys modifiers = A_1.Modifiers;
			if (modifiers == Keys.None)
			{
				this.b(A_0, A_1);
				return;
			}
			if (modifiers != Keys.Shift)
			{
				return;
			}
			this.a(A_0, A_1);
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002FF4 File Offset: 0x000011F4
	private List<TreeNode> a(TreeNodeCollection A_0, List<TreeNode> A_1)
	{
		foreach (object obj in A_0)
		{
			TreeNode treeNode = (TreeNode)obj;
			A_1.Add(treeNode);
			A_1 = this.a(treeNode.Nodes, A_1);
		}
		return A_1;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00003058 File Offset: 0x00001258
	private TreeNode a(List<TreeNode> A_0, TreeNode A_1, string A_2, c.b A_3)
	{
		bool flag = A_3 == global::c.b.a;
		if (A_3 == global::c.b.c)
		{
			A_0.Reverse();
		}
		foreach (TreeNode treeNode in A_0)
		{
			if (flag && treeNode.Text.ToUpper().Contains(A_2.ToUpper()))
			{
				return treeNode;
			}
			if (treeNode == A_1)
			{
				flag = true;
			}
		}
		return null;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x000030FC File Offset: 0x000012FC
	private void a()
	{
		this.d = new TreeView();
		this.e = new TreeView();
		this.f = new ListBox();
		this.g = new Button();
		this.h = new Button();
		this.i = new Button();
		this.j = new Button();
		this.k = new ToolStrip();
		this.l = new ToolStripButton();
		this.m = new ToolStripTextBox();
		this.n = new ToolStripButton();
		this.o = new ToolStripButton();
		this.p = new Label();
		this.q = new Label();
		this.r = new GroupBox();
		this.x = new Label();
		this.w = new DateTimePicker();
		this.u = new DateTimePicker();
		this.v = new Label();
		this.t = new Label();
		this.s = new TextBox();
		this.k.SuspendLayout();
		this.r.SuspendLayout();
		base.SuspendLayout();
		this.d.CheckBoxes = true;
		this.d.HideSelection = false;
		this.d.Location = new Point(2, 28);
		this.d.Name = "treeViewSubstation";
		this.d.Size = new Size(210, 430);
		this.d.TabIndex = 0;
		this.d.BeforeExpand += this.a;
		this.d.AfterSelect += this.a;
		this.e.CheckBoxes = true;
		this.e.Location = new Point(2, 258);
		this.e.Name = "treeViewSubs";
		this.e.Size = new Size(210, 200);
		this.e.TabIndex = 1;
		this.f.FormattingEnabled = true;
		this.f.Location = new Point(277, 25);
		this.f.Name = "listBoxObjects";
		this.f.SelectionMode = SelectionMode.MultiExtended;
		this.f.Size = new Size(232, 277);
		this.f.Sorted = true;
		this.f.TabIndex = 2;
		this.g.Location = new Point(218, 28);
		this.g.Name = "buttonAdd";
		this.g.Size = new Size(53, 23);
		this.g.TabIndex = 3;
		this.g.Text = ">>>";
		this.g.UseVisualStyleBackColor = true;
		this.g.Click += this.f;
		this.h.Location = new Point(218, 57);
		this.h.Name = "buttonDel";
		this.h.Size = new Size(53, 23);
		this.h.TabIndex = 4;
		this.h.Text = "<<<";
		this.h.UseVisualStyleBackColor = true;
		this.h.Click += this.e;
		this.i.DialogResult = DialogResult.OK;
		this.i.Location = new Point(3, 464);
		this.i.Name = "buttonOk";
		this.i.Size = new Size(75, 23);
		this.i.TabIndex = 5;
		this.i.Text = "OK";
		this.i.UseVisualStyleBackColor = true;
		this.i.Click += this.d;
		this.j.DialogResult = DialogResult.Cancel;
		this.j.Location = new Point(434, 464);
		this.j.Name = "buttonCancel";
		this.j.Size = new Size(75, 23);
		this.j.TabIndex = 6;
		this.j.Text = "Отмена";
		this.j.UseVisualStyleBackColor = true;
		this.k.Dock = DockStyle.None;
		this.k.Items.AddRange(new ToolStripItem[]
		{
			this.l,
			this.m,
			this.n,
			this.o
		});
		this.k.Location = new Point(3, 0);
		this.k.Name = "toolStrip1";
		this.k.Size = new Size(183, 25);
		this.k.TabIndex = 7;
		this.k.Text = "toolStripTreeSubstations";
		this.l.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.l.Image = Resources.Find;
		this.l.ImageTransparentColor = Color.Magenta;
		this.l.Name = "tooBtnFind";
		this.l.Size = new Size(23, 22);
		this.l.Text = "toolStripButton1";
		this.l.Click += this.c;
		this.m.Name = "toolTxtFind";
		this.m.Size = new Size(100, 25);
		this.m.KeyDown += this.a;
		this.n.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.n.Image = Resources.FindNext;
		this.n.ImageTransparentColor = Color.Magenta;
		this.n.Name = "toolBtnFindNext";
		this.n.Size = new Size(23, 22);
		this.n.Text = "toolStripButton1";
		this.n.Click += this.b;
		this.o.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.o.Image = Resources.FindPrev;
		this.o.ImageTransparentColor = Color.Magenta;
		this.o.Name = "toolBtnFindPrev";
		this.o.Size = new Size(23, 22);
		this.o.Text = "toolStripButton2";
		this.o.Click += this.a;
		this.p.AutoSize = true;
		this.p.Location = new Point(12, 242);
		this.p.Name = "label1";
		this.p.Size = new Size(115, 13);
		this.p.TabIndex = 8;
		this.p.Text = "Объекты подстанции";
		this.q.AutoSize = true;
		this.q.Location = new Point(274, 12);
		this.q.Name = "label2";
		this.q.Size = new Size(124, 13);
		this.q.TabIndex = 9;
		this.q.Text = "Привязанные объекты";
		this.r.Controls.Add(this.s);
		this.r.Controls.Add(this.t);
		this.r.Controls.Add(this.u);
		this.r.Controls.Add(this.v);
		this.r.Controls.Add(this.w);
		this.r.Controls.Add(this.x);
		this.r.Location = new Point(277, 308);
		this.r.Name = "groupBoxDuration";
		this.r.Size = new Size(232, 150);
		this.r.TabIndex = 10;
		this.r.TabStop = false;
		this.r.Text = "Период";
		this.x.AutoSize = true;
		this.x.Location = new Point(6, 16);
		this.x.Name = "label3";
		this.x.Size = new Size(71, 13);
		this.x.TabIndex = 0;
		this.x.Text = "Дата начала";
		this.w.CustomFormat = "dd.MM.yyyy HH:mm";
		this.w.Format = DateTimePickerFormat.Custom;
		this.w.Location = new Point(9, 32);
		this.w.Name = "dateTimePickerDateBeg";
		this.w.Size = new Size(217, 20);
		this.w.TabIndex = 1;
		this.u.CustomFormat = "dd.MM.yyyy HH:mm";
		this.u.Format = DateTimePickerFormat.Custom;
		this.u.Location = new Point(9, 71);
		this.u.Name = "dateTimePickerDateEnd";
		this.u.Size = new Size(217, 20);
		this.u.TabIndex = 3;
		this.v.AutoSize = true;
		this.v.Location = new Point(6, 55);
		this.v.Name = "label4";
		this.v.Size = new Size(71, 13);
		this.v.TabIndex = 2;
		this.v.Text = "Дата начала";
		this.t.AutoSize = true;
		this.t.Location = new Point(6, 94);
		this.t.Name = "label5";
		this.t.Size = new Size(80, 13);
		this.t.TabIndex = 4;
		this.t.Text = "Длительность";
		this.s.Location = new Point(9, 110);
		this.s.Name = "textBoxDuration";
		this.s.Size = new Size(217, 20);
		this.s.TabIndex = 5;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = this.j;
		base.ClientSize = new Size(521, 495);
		base.Controls.Add(this.r);
		base.Controls.Add(this.d);
		base.Controls.Add(this.q);
		base.Controls.Add(this.p);
		base.Controls.Add(this.k);
		base.Controls.Add(this.j);
		base.Controls.Add(this.i);
		base.Controls.Add(this.h);
		base.Controls.Add(this.g);
		base.Controls.Add(this.f);
		base.Controls.Add(this.e);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Name = "FormLinkRequestAndSchm";
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Привязка заявок к схеме";
		base.Load += this.g;
		this.k.ResumeLayout(false);
		this.k.PerformLayout();
		this.r.ResumeLayout(false);
		this.r.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x0400000B RID: 11
	private Dictionary<int, string> a = new Dictionary<int, string>();

	// Token: 0x0400000C RID: 12
	private short b;

	// Token: 0x0400000E RID: 14
	private TreeView d;

	// Token: 0x0400000F RID: 15
	private TreeView e;

	// Token: 0x04000010 RID: 16
	private ListBox f;

	// Token: 0x04000011 RID: 17
	private Button g;

	// Token: 0x04000012 RID: 18
	private Button h;

	// Token: 0x04000013 RID: 19
	private Button i;

	// Token: 0x04000014 RID: 20
	private Button j;

	// Token: 0x04000015 RID: 21
	private ToolStrip k;

	// Token: 0x04000016 RID: 22
	private ToolStripButton l;

	// Token: 0x04000017 RID: 23
	private ToolStripTextBox m;

	// Token: 0x04000018 RID: 24
	private ToolStripButton n;

	// Token: 0x04000019 RID: 25
	private ToolStripButton o;

	// Token: 0x0400001A RID: 26
	private Label p;

	// Token: 0x0400001B RID: 27
	private Label q;

	// Token: 0x0400001C RID: 28
	private GroupBox r;

	// Token: 0x0400001D RID: 29
	private TextBox s;

	// Token: 0x0400001E RID: 30
	private Label t;

	// Token: 0x0400001F RID: 31
	private DateTimePicker u;

	// Token: 0x04000020 RID: 32
	private Label v;

	// Token: 0x04000021 RID: 33
	private DateTimePicker w;

	// Token: 0x04000022 RID: 34
	private Label x;

	// Token: 0x02000007 RID: 7
	private struct a
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00003CD5 File Offset: 0x00001ED5
		public a(int A_0, string A_1)
		{
			this.a = A_1;
			this.b = A_0;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003CE5 File Offset: 0x00001EE5
		public override string ToString()
		{
			return this.a;
		}

		// Token: 0x04000023 RID: 35
		public string a;

		// Token: 0x04000024 RID: 36
		public int b;
	}

	// Token: 0x02000008 RID: 8
	private enum b
	{
		// Token: 0x04000026 RID: 38
		a,
		// Token: 0x04000027 RID: 39
		b,
		// Token: 0x04000028 RID: 40
		c
	}
}
