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
using FormLbr;
using SchemeCtrl2.Properties;

internal partial class Form6 : FormBase
{
	[CompilerGenerated]
	internal Class82 method_0()
	{
		return this.class82_0;
	}

	[CompilerGenerated]
	private void method_1(Class82 class82_2)
	{
		this.class82_0 = class82_2;
	}

	[CompilerGenerated]
	internal Class82 method_2()
	{
		return this.class82_1;
	}

	[CompilerGenerated]
	private void method_3(Class82 class82_2)
	{
		this.class82_1 = class82_2;
	}

	internal bool OmgdvEytJc()
	{
		return this.bool_0;
	}

	internal void method_4(bool bool_1)
	{
		this.bool_0 = bool_1;
		this.splitContainer_0.Panel2Collapsed = !this.bool_0;
	}

	internal Form6(List<int> list_3 = null)
	{
		
		this.bool_0 = true;
		this.list_1 = new List<Form6.Class81>();
		this.list_2 = new List<Form6.Class81>();
		
		this.method_8();
		this.list_0 = list_3;
	}

	private void Form6_Load(object sender, EventArgs e)
	{
		this.method_5();
	}

	private void method_5()
	{
		DataTable dataTable = new DataTable("tR_Classifier");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("socrName", typeof(string));
		base.SelectSqlData(dataTable, true, " where ParentKey = ';SCM;Line;' and isGRoup = 0 and deleted = 0 order by name", null, false, 0);
		foreach (object obj in dataTable.Rows)
		{
			DataRow dataRow = (DataRow)obj;
			if (this.list_0 != null && this.list_0.Contains(Convert.ToInt32(dataRow["id"])))
			{
				TreeNode treeNode = new TreeNode(dataRow["SocrNAme"].ToString());
				treeNode.Tag = dataRow["id"];
				this.treeView_0.Nodes.Add(treeNode);
				TreeNode treeNode2 = new TreeNode("0,23-0,4 кВ");
				treeNode.Nodes.Add(treeNode2);
				this.list_1.Add(new Form6.Class81(treeNode2, Convert.ToInt32(dataRow["id"]), (Form6.Enum5)0, false));
				TreeNode treeNode3 = new TreeNode("6-10 кВ");
				treeNode.Nodes.Add(treeNode3);
				this.list_1.Add(new Form6.Class81(treeNode3, Convert.ToInt32(dataRow["id"]), (Form6.Enum5)1, false));
			}
		}
		base.SelectSqlData(dataTable, true, " where ParentKey = ';SCM;PS;' and isGRoup = 0 and deleted = 0 order by name", null, false, 0);
		foreach (object obj2 in dataTable.Rows)
		{
			DataRow dataRow2 = (DataRow)obj2;
			if (this.list_0 != null && this.list_0.Contains(Convert.ToInt32(dataRow2["id"])))
			{
				TreeNode treeNode4 = new TreeNode(dataRow2["SocrNAme"].ToString());
				treeNode4.Tag = dataRow2["id"];
				this.treeView_0.Nodes.Add(treeNode4);
				this.list_2.Add(new Form6.Class81(treeNode4, Convert.ToInt32(dataRow2["id"]), (Form6.Enum5)1, false));
			}
		}
		foreach (Form6.Class81 parameter in this.list_1)
		{
			new Thread(new ParameterizedThreadStart(this.Vljdsiquhd)).Start(parameter);
		}
		foreach (Form6.Class81 parameter2 in this.list_2)
		{
			new Thread(new ParameterizedThreadStart(this.method_6)).Start(parameter2);
		}
	}

	private void Form6_Shown(object sender, EventArgs e)
	{
		for (;;)
		{
			Application.DoEvents();
			bool flag = true;
			List<Form6.Class81>.Enumerator enumerator = this.list_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.bool_0)
					{
						flag = false;
						break;
					}
				}
				goto IL_75;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				IL_42:
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.bool_0)
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
			IL_75:
			enumerator = this.list_2.GetEnumerator();
			goto IL_42;
		}
		Control control = this.label_0;
		this.progressBar_0.Visible = false;
		control.Visible = false;
	}

	private void Vljdsiquhd(object object_0)
	{
		if (!(object_0 is Form6.Class81))
		{
			return;
		}
		Form6.Class81 @class = (Form6.Class81)object_0;
		DataTable dataTable = new DataTable("VP_CAbleLine");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("text", typeof(string));
		base.SelectSqlData(dataTable, true, string.Format("where typeCodeid = {0} and voltage in ({1}) order by text", @class.int_0, (@class.enum5_0 == (Form6.Enum5)0) ? "0.23, 0.4" : "6, 10"), null, false, 0);
		foreach (object obj in dataTable.Rows)
		{
			DataRow dataRow = (DataRow)obj;
			TreeNode treeNode = new TreeNode(dataRow["TExt"].ToString());
			treeNode.Tag = dataRow["id"];
			this.method_7(this.treeView_0, @class.treeNode_0, treeNode);
		}
		Form6.Class81 obj2 = @class;
		lock (obj2)
		{
			@class.bool_0 = true;
		}
	}

	private void method_6(object object_0)
	{
		if (!(object_0 is Form6.Class81))
		{
			return;
		}
		Form6.Class81 @class = (Form6.Class81)object_0;
		DataTable dataTable = new DataTable("vschm_ObjList");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("name", typeof(string));
		dataTable.Columns.Add("typeCodeSocr", typeof(string));
		base.SelectSqlData(dataTable, true, string.Format("where typeCodeid = {0} and deleted = 0 order by name", @class.int_0), null, false, 0);
		foreach (object obj in dataTable.Rows)
		{
			DataRow dataRow = (DataRow)obj;
			TreeNode treeNode = new TreeNode(dataRow["TypeCodeSocr"].ToString() + "-" + dataRow["Name"].ToString());
			treeNode.Tag = dataRow["id"];
			this.method_7(this.treeView_0, @class.treeNode_0, treeNode);
		}
		Form6.Class81 obj2 = @class;
		lock (obj2)
		{
			@class.bool_0 = true;
		}
	}

	private void method_7(TreeView treeView_1, TreeNode treeNode_0, TreeNode treeNode_1)
	{
		if (treeView_1 == null)
		{
			return;
		}
		if (treeView_1.IsDisposed)
		{
			return;
		}
		if (treeView_1.Disposing)
		{
			return;
		}
		if (!treeView_1.IsHandleCreated)
		{
			return;
		}
		try
		{
			if (!treeView_1.InvokeRequired)
			{
				if (treeNode_0 == null)
				{
					treeView_1.Nodes.Add(treeNode_1);
				}
				else
				{
					treeNode_0.Nodes.Add(treeNode_1);
				}
			}
			else
			{
				treeView_1.Invoke(new Form6.Delegate35(this.method_7), new object[]
				{
					treeView_1,
					treeNode_0,
					treeNode_1
				});
			}
		}
		catch
		{
		}
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		this.treeView_0.smethod_0(this.toolStripTextBox_0.Text, (Class83.Enum7)0);
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		this.treeView_0.smethod_0(this.toolStripTextBox_0.Text, (Class83.Enum7)2);
	}

	private void toolStripButton_2_Click(object sender, EventArgs e)
	{
		this.treeView_0.smethod_0(this.toolStripTextBox_0.Text, (Class83.Enum7)1);
	}

	private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			if (e.Modifiers == Keys.Shift)
			{
				this.treeView_0.smethod_0(this.toolStripTextBox_0.Text, (Class83.Enum7)2);
			}
			if (e.Modifiers == Keys.None)
			{
				this.treeView_0.smethod_0(this.toolStripTextBox_0.Text, (Class83.Enum7)1);
			}
		}
	}

	private void treeView_0_AfterSelect(object sender, TreeViewEventArgs e)
	{
		if (e.Node.Level > 1 && e.Node.Tag != null)
		{
			int num = Convert.ToInt32(e.Node.Tag);
			DataTable dataTable = new DataTable("tP_CabSection");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("number", typeof(int));
			this.bindingSource_0.DataSource = dataTable;
			base.SelectSqlData(dataTable, true, "where idObjList = " + num.ToString() + " order by number", null, false, 0);
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void Form6_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (base.DialogResult == DialogResult.OK)
		{
			List<int> list = new List<int>();
			foreach (object obj in Enum.GetValues(typeof(TypeLine)))
			{
				TypeLine item = (TypeLine)obj;
				list.Add((int)item);
			}
			if (this.treeView_0.SelectedNode == null || this.treeView_0.SelectedNode.Level < 1 || (this.treeView_0.SelectedNode.Level == 1 && list.Contains(Convert.ToInt32(this.treeView_0.SelectedNode.Parent.Tag))))
			{
				MessageBox.Show("Не выбран объект", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				e.Cancel = true;
				return;
			}
			if (this.treeView_0.SelectedNode.Level == 2 && this.bool_0)
			{
				if (this.dataGridViewExcelFilter_0.CurrentRow == null)
				{
					if (MessageBox.Show("Не выбран участок КЛ/ВЛ. Продолжить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					{
						e.Cancel = true;
						return;
					}
				}
				else
				{
					this.method_3(new Class82(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value.ToString(), Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value)));
				}
			}
			this.method_1(new Class82(this.treeView_0.SelectedNode.Text, Convert.ToInt32(this.treeView_0.SelectedNode.Tag)));
		}
	}

	private void method_8()
	{
		this.icontainer_0 = new Container();
		this.splitContainer_0 = new SplitContainer();
		this.treeView_0 = new TreeView();
		this.toolStrip_0 = new ToolStrip();
		this.toolStripButton_0 = new ToolStripButton();
		this.toolStripTextBox_0 = new ToolStripTextBox();
		this.toolStripButton_1 = new ToolStripButton();
		this.toolStripButton_2 = new ToolStripButton();
		this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
		this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.progressBar_0 = new ProgressBar();
		this.label_0 = new Label();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.splitContainer_0.Panel1.SuspendLayout();
		this.splitContainer_0.Panel2.SuspendLayout();
		this.splitContainer_0.SuspendLayout();
		this.toolStrip_0.SuspendLayout();
		((ISupportInitialize)this.dataGridViewExcelFilter_0).BeginInit();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		base.SuspendLayout();
		this.splitContainer_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.splitContainer_0.Location = new Point(0, 0);
		this.splitContainer_0.Name = "splitContainer1";
		this.splitContainer_0.Panel1.Controls.Add(this.treeView_0);
		this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_0);
		this.splitContainer_0.Panel2.Controls.Add(this.dataGridViewExcelFilter_0);
		this.splitContainer_0.Size = new Size(693, 522);
		this.splitContainer_0.SplitterDistance = 335;
		this.splitContainer_0.TabIndex = 0;
		this.treeView_0.Dock = DockStyle.Fill;
		this.treeView_0.HideSelection = false;
		this.treeView_0.Location = new Point(0, 25);
		this.treeView_0.Name = "treeViewLine";
		this.treeView_0.Size = new Size(335, 497);
		this.treeView_0.TabIndex = 1;
		this.treeView_0.AfterSelect += this.treeView_0_AfterSelect;
		this.toolStrip_0.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_0,
			this.toolStripTextBox_0,
			this.toolStripButton_1,
			this.toolStripButton_2
		});
		this.toolStrip_0.Location = new Point(0, 0);
		this.toolStrip_0.Name = "toolStrip1";
		this.toolStrip_0.Size = new Size(335, 25);
		this.toolStrip_0.TabIndex = 0;
		this.toolStrip_0.Text = "toolStrip1";
		this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_0.Image = Resources.Find;
		this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_0.Name = "toolBtnFind";
		this.toolStripButton_0.Size = new Size(23, 22);
		this.toolStripButton_0.Text = "Поиск";
		this.toolStripButton_0.Click += this.toolStripButton_0_Click;
		this.toolStripTextBox_0.Name = "txtFind";
		this.toolStripTextBox_0.Size = new Size(100, 25);
		this.toolStripTextBox_0.ToolTipText = "Строка поиска";
		this.toolStripTextBox_0.KeyDown += this.toolStripTextBox_0_KeyDown;
		this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_1.Image = Resources.FindPrev;
		this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_1.Name = "toolBTnFindPrev";
		this.toolStripButton_1.Size = new Size(23, 22);
		this.toolStripButton_1.Text = "Поиск назад";
		this.toolStripButton_1.Click += this.toolStripButton_1_Click;
		this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_2.Image = Resources.FindNext;
		this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_2.Name = "toolBtnFindNext";
		this.toolStripButton_2.Size = new Size(23, 22);
		this.toolStripButton_2.Text = "Поиск вперед";
		this.toolStripButton_2.Click += this.toolStripButton_2_Click;
		this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_0,
			this.dataGridViewTextBoxColumn_1
		});
		this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
		this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
		this.dataGridViewExcelFilter_0.Name = "dgvCabSection";
		this.dataGridViewExcelFilter_0.ReadOnly = true;
		this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewExcelFilter_0.Size = new Size(354, 522);
		this.dataGridViewExcelFilter_0.TabIndex = 0;
		this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_0.DataPropertyName = "Number";
		this.dataGridViewTextBoxColumn_0.HeaderText = "Участок";
		this.dataGridViewTextBoxColumn_0.Name = "columnNameCabSrction";
		this.dataGridViewTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewTextBoxColumn_1.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_1.HeaderText = "Id";
		this.dataGridViewTextBoxColumn_1.Name = "columnId";
		this.dataGridViewTextBoxColumn_1.ReadOnly = true;
		this.dataGridViewTextBoxColumn_1.Visible = false;
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.button_0.DialogResult = DialogResult.OK;
		this.button_0.Location = new Point(12, 531);
		this.button_0.Name = "buttonOK";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 1;
		this.button_0.Text = "ОК";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.button_0_Click;
		this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_1.DialogResult = DialogResult.Cancel;
		this.button_1.Location = new Point(606, 531);
		this.button_1.Name = "buttonCancel";
		this.button_1.Size = new Size(75, 23);
		this.button_1.TabIndex = 2;
		this.button_1.Text = "Отмена";
		this.button_1.UseVisualStyleBackColor = true;
		this.button_1.Click += this.button_1_Click;
		this.progressBar_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.progressBar_0.Location = new Point(264, 531);
		this.progressBar_0.Name = "progressBarLoad";
		this.progressBar_0.Size = new Size(336, 23);
		this.progressBar_0.Style = ProgressBarStyle.Marquee;
		this.progressBar_0.TabIndex = 3;
		this.label_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(105, 536);
		this.label_0.Name = "labelLoad";
		this.label_0.Size = new Size(153, 13);
		this.label_0.TabIndex = 4;
		this.label_0.Text = "Загрузка дерева объектов...";
		base.AcceptButton = this.button_0;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = this.button_1;
		base.ClientSize = new Size(693, 566);
		base.Controls.Add(this.label_0);
		base.Controls.Add(this.progressBar_0);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.button_0);
		base.Controls.Add(this.splitContainer_0);
		base.Name = "FormSelectLine";
		this.Text = "Выбор объекта схемы";
		base.FormClosing += this.Form6_FormClosing;
		base.Load += this.Form6_Load;
		base.Shown += this.Form6_Shown;
		this.splitContainer_0.Panel1.ResumeLayout(false);
		this.splitContainer_0.Panel1.PerformLayout();
		this.splitContainer_0.Panel2.ResumeLayout(false);
		this.splitContainer_0.ResumeLayout(false);
		this.toolStrip_0.ResumeLayout(false);
		this.toolStrip_0.PerformLayout();
		((ISupportInitialize)this.dataGridViewExcelFilter_0).EndInit();
		((ISupportInitialize)this.bindingSource_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private List<int> list_0;

	private bool bool_0;

	[CompilerGenerated]
	private Class82 class82_0;

	[CompilerGenerated]
	private Class82 class82_1;

	private List<Form6.Class81> list_1;

	private List<Form6.Class81> list_2;

	private SplitContainer splitContainer_0;

	private TreeView treeView_0;

	private ToolStrip toolStrip_0;

	private Button button_0;

	private Button button_1;

	private ToolStripButton toolStripButton_0;

	private ToolStripTextBox toolStripTextBox_0;

	private ToolStripButton toolStripButton_1;

	private ToolStripButton toolStripButton_2;

	private ProgressBar progressBar_0;

	private Label label_0;

	private DataGridViewExcelFilter dataGridViewExcelFilter_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private BindingSource bindingSource_0;

	private delegate void Delegate35(TreeView tree, TreeNode parentNode, TreeNode nodeToAdd);

	private enum Enum5
	{

	}

	private class Class81
	{
		internal Class81(TreeNode treeNode_1, int int_1, Form6.Enum5 enum5_1 = (Form6.Enum5)1, bool bool_1 = false)
		{
			
			
			this.treeNode_0 = treeNode_1;
			this.int_0 = int_1;
			this.enum5_0 = enum5_1;
			this.bool_0 = bool_1;
		}

		internal TreeNode treeNode_0;

		internal int int_0;

		internal Form6.Enum5 enum5_0;

		internal bool bool_0;
	}
}
