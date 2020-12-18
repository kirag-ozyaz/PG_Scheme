using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Scheme.Classes;
using SchemeCtrl2.DrawTool;
using WinFormsUI.Docking;

internal class Class12 : DockContent
{
	internal DataGridViewSelectedRowCollection method_0()
	{
		if (this.tabControl_0.SelectedTab.Controls[0].GetType() == typeof(DataGridView))
		{
			return ((DataGridView)this.tabControl_0.SelectedTab.Controls[0]).SelectedRows;
		}
		return null;
	}

	[CompilerGenerated]
	internal void method_1(DataGridViewCellEventHandler dataGridViewCellEventHandler_1)
	{
		DataGridViewCellEventHandler dataGridViewCellEventHandler = this.dataGridViewCellEventHandler_0;
		DataGridViewCellEventHandler dataGridViewCellEventHandler2;
		do
		{
			dataGridViewCellEventHandler2 = dataGridViewCellEventHandler;
			DataGridViewCellEventHandler value = (DataGridViewCellEventHandler)Delegate.Combine(dataGridViewCellEventHandler2, dataGridViewCellEventHandler_1);
			dataGridViewCellEventHandler = Interlocked.CompareExchange<DataGridViewCellEventHandler>(ref this.dataGridViewCellEventHandler_0, value, dataGridViewCellEventHandler2);
		}
		while (dataGridViewCellEventHandler != dataGridViewCellEventHandler2);
	}

	[CompilerGenerated]
	internal void method_2(DataGridViewCellEventHandler dataGridViewCellEventHandler_1)
	{
		DataGridViewCellEventHandler dataGridViewCellEventHandler = this.dataGridViewCellEventHandler_0;
		DataGridViewCellEventHandler dataGridViewCellEventHandler2;
		do
		{
			dataGridViewCellEventHandler2 = dataGridViewCellEventHandler;
			DataGridViewCellEventHandler value = (DataGridViewCellEventHandler)Delegate.Remove(dataGridViewCellEventHandler2, dataGridViewCellEventHandler_1);
			dataGridViewCellEventHandler = Interlocked.CompareExchange<DataGridViewCellEventHandler>(ref this.dataGridViewCellEventHandler_0, value, dataGridViewCellEventHandler2);
		}
		while (dataGridViewCellEventHandler != dataGridViewCellEventHandler2);
	}

	internal Class12()
	{
		Class63.AGd1PxHzk5wxP();
		this.dictionary_0 = new Dictionary<LineToolState, Class12.Struct1>();
		this.dictionary_1 = new Dictionary<ObjectOnLine, DataGridViewRow>();
		base..ctor();
		this.method_11();
		this.method_1(new DataGridViewCellEventHandler(this.method_5));
		GeneralFormSettings.smethod_2(new EventHandler(this.method_4));
	}

	internal void method_3()
	{
		foreach (LineToolState key in this.dictionary_0.Keys)
		{
			Class12.Struct1 @struct = this.dictionary_0[key];
			@struct.dataGridViewRow_0.Tag = null;
			@struct.dataGridView_0.Rows.Remove(@struct.dataGridViewRow_0);
		}
		foreach (ObjectOnLine key2 in this.dictionary_1.Keys)
		{
			DataGridViewRow dataGridViewRow = this.dictionary_1[key2];
			dataGridViewRow.Tag = null;
			dataGridViewRow.DataGridView.Rows.Remove(dataGridViewRow);
		}
		this.dictionary_0.Clear();
		this.dictionary_1.Clear();
	}

	private void method_4(object sender, EventArgs e)
	{
		this.Font = new Font(this.Font.Name, GeneralFormSettings.FontSize);
	}

	private void method_5(object sender, DataGridViewCellEventArgs e)
	{
	}

	internal void method_6(LineToolState lineToolState_0)
	{
		DataGridViewRow dataGridViewRow = new DataGridViewRow();
		DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
		if (this.dictionary_0.ContainsKey(lineToolState_0))
		{
			return;
		}
		dataGridViewRow.Cells.AddRange(new DataGridViewCell[]
		{
			dataGridViewTextBoxCell
		});
		if (lineToolState_0.Mapping != null && lineToolState_0.Mapping.Parent != null && lineToolState_0.Mapping.Parent.Parent != null)
		{
			LineTool lineTool = (LineTool)lineToolState_0.Mapping.Parent.Parent;
			if (lineTool.Parent != null)
			{
				dataGridViewTextBoxCell.Value = lineTool.Parent.ToString() + ": " + lineTool.ToString();
			}
			else
			{
				dataGridViewTextBoxCell.Value = lineTool.ToString() + ": ";
				bool flag = false;
				foreach (PointTool pointTool in lineTool.Ends)
				{
					foreach (Branch branch in pointTool.Branches)
					{
						if (branch.Parent != lineTool && branch.Parent.GetType() == typeof(LineCellTool))
						{
							if (flag)
							{
								DataGridViewTextBoxCell dataGridViewTextBoxCell2 = dataGridViewTextBoxCell;
								dataGridViewTextBoxCell2.Value += " - ";
							}
							DataGridViewTextBoxCell dataGridViewTextBoxCell3 = dataGridViewTextBoxCell;
							dataGridViewTextBoxCell3.Value = string.Concat(new object[]
							{
								dataGridViewTextBoxCell3.Value,
								branch.Parent.Parent.ToString(),
								"\\",
								branch.Parent.ToString()
							});
							flag = true;
						}
					}
				}
			}
			dataGridViewRow.Tag = lineToolState_0.Mapping;
		}
		DataGridView dataGridView = null;
		switch (lineToolState_0.state)
		{
		case States.grounded:
			dataGridView = this.dataGridView_2;
			break;
		case States.off:
			dataGridView = this.dataGridView_0;
			break;
		case States.break_down:
			dataGridView = this.dataGridView_3;
			break;
		case States.not_phased:
			dataGridView = this.dataGridView_1;
			break;
		case States.Arrow:
			dataGridView = this.dataGridView_6;
			break;
		}
		if (dataGridView != null && dataGridViewRow != null)
		{
			this.method_7(dataGridView, dataGridViewRow);
			this.dictionary_0.Add(lineToolState_0, new Class12.Struct1(dataGridViewRow, dataGridView));
		}
	}

	private void method_7(DataGridView dataGridView_7, DataGridViewRow dataGridViewRow_0)
	{
		if (dataGridView_7.InvokeRequired)
		{
			try
			{
				Class12.Delegate3 method = new Class12.Delegate3(this.method_7);
				dataGridView_7.Invoke(method, new object[]
				{
					dataGridView_7,
					dataGridViewRow_0
				});
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		dataGridView_7.Rows.Add(dataGridViewRow_0);
	}

	internal void method_8(LineToolState lineToolState_0)
	{
		if (this.dictionary_0.ContainsKey(lineToolState_0))
		{
			Class12.Struct1 @struct = this.dictionary_0[lineToolState_0];
			this.dictionary_0.Remove(lineToolState_0);
			@struct.dataGridView_0.Rows.Remove(@struct.dataGridViewRow_0);
		}
	}

	internal void method_9(ObjectOnLine objectOnLine_0)
	{
		if (this.dictionary_1.ContainsKey(objectOnLine_0))
		{
			return;
		}
		DataGridViewRow dataGridViewRow = new DataGridViewRow();
		DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
		dataGridViewRow.Cells.AddRange(new DataGridViewCell[]
		{
			dataGridViewTextBoxCell
		});
		LineTool lineTool = (LineTool)objectOnLine_0.Parent.Parent;
		if (lineTool.Parent != null)
		{
			dataGridViewTextBoxCell.Value = lineTool.Parent.ToString() + ": " + lineTool.ToString();
		}
		else
		{
			dataGridViewTextBoxCell.Value = lineTool.ToString() + ": ";
			bool flag = false;
			foreach (PointTool pointTool in lineTool.Ends)
			{
				foreach (Branch branch in pointTool.Branches)
				{
					if (branch.Parent != lineTool && branch.Parent.GetType() == typeof(LineCellTool))
					{
						if (flag)
						{
							DataGridViewTextBoxCell dataGridViewTextBoxCell2 = dataGridViewTextBoxCell;
							dataGridViewTextBoxCell2.Value += " - ";
						}
						DataGridViewTextBoxCell dataGridViewTextBoxCell3 = dataGridViewTextBoxCell;
						dataGridViewTextBoxCell3.Value = string.Concat(new object[]
						{
							dataGridViewTextBoxCell3.Value,
							branch.Parent.Parent.ToString(),
							"\\",
							branch.Parent.ToString()
						});
						flag = true;
					}
				}
			}
		}
		dataGridViewRow.Tag = objectOnLine_0;
		this.dictionary_1.Add(objectOnLine_0, dataGridViewRow);
		if (objectOnLine_0.IsNormalSection)
		{
			this.method_7(this.dataGridView_5, dataGridViewRow);
			return;
		}
		this.method_7(this.dataGridView_4, dataGridViewRow);
	}

	internal void method_10(ObjectOnLine objectOnLine_0)
	{
		if (this.dictionary_1.ContainsKey(objectOnLine_0))
		{
			DataGridViewRow dataGridViewRow = this.dictionary_1[objectOnLine_0];
			this.dictionary_1.Remove(objectOnLine_0);
			if (objectOnLine_0.IsNormalSection)
			{
				this.dataGridView_5.Rows.Remove(dataGridViewRow);
				return;
			}
			this.dataGridView_4.Rows.Remove(dataGridViewRow);
		}
	}

	private void dataGridView_6_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		this.dataGridViewCellEventHandler_0(sender, e);
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		Class8 @class = null;
		if (this.tabControl_0.SelectedTab.Name == "onNormalSection")
		{
			@class = new Class8((from obj in this.dictionary_1.Keys
			where obj.IsNormalSection && obj.On
			select obj).ToList<ObjectOnLine>());
		}
		else if (this.tabControl_0.SelectedTab.Name == "offSwitches")
		{
			@class = new Class8((from obj in this.dictionary_1.Keys
			where !obj.IsNormalSection && !obj.On && !obj.MappingState
			select obj).ToList<ObjectOnLine>());
		}
		if (@class != null)
		{
			@class.ShowDialog();
		}
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Class12.F4mSKnGBANoGjS3b9Pj(this, bool_0);
	}

	private void method_11()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Class12));
		this.dataGridView_0 = new DataGridView();
		this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		this.tabControl_0 = new TabControl();
		this.tabPage_0 = new TabPage();
		this.tabPage_1 = new TabPage();
		this.dataGridView_3 = new DataGridView();
		this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		this.tabPage_2 = new TabPage();
		this.dataGridView_2 = new DataGridView();
		this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		this.tabPage_3 = new TabPage();
		this.dataGridView_1 = new DataGridView();
		this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		this.tabPage_4 = new TabPage();
		this.dataGridView_4 = new DataGridView();
		this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		this.toolStrip_1 = new ToolStrip();
		this.toolStripButton_1 = new ToolStripButton();
		this.tabPage_5 = new TabPage();
		this.dataGridView_5 = new DataGridView();
		this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		this.toolStrip_0 = new ToolStrip();
		this.toolStripButton_0 = new ToolStripButton();
		this.tabPage_6 = new TabPage();
		this.dataGridView_6 = new DataGridView();
		this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		((ISupportInitialize)this.dataGridView_0).BeginInit();
		this.tabControl_0.SuspendLayout();
		this.tabPage_0.SuspendLayout();
		this.tabPage_1.SuspendLayout();
		((ISupportInitialize)this.dataGridView_3).BeginInit();
		this.tabPage_2.SuspendLayout();
		((ISupportInitialize)this.dataGridView_2).BeginInit();
		this.tabPage_3.SuspendLayout();
		((ISupportInitialize)this.dataGridView_1).BeginInit();
		this.tabPage_4.SuspendLayout();
		((ISupportInitialize)this.dataGridView_4).BeginInit();
		this.toolStrip_1.SuspendLayout();
		this.tabPage_5.SuspendLayout();
		((ISupportInitialize)this.dataGridView_5).BeginInit();
		this.toolStrip_0.SuspendLayout();
		this.tabPage_6.SuspendLayout();
		((ISupportInitialize)this.dataGridView_6).BeginInit();
		base.SuspendLayout();
		this.dataGridView_0.AllowUserToAddRows = false;
		this.dataGridView_0.AllowUserToDeleteRows = false;
		this.dataGridView_0.AllowUserToResizeColumns = false;
		this.dataGridView_0.AllowUserToResizeRows = false;
		this.dataGridView_0.BackgroundColor = Color.White;
		this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_0
		});
		this.dataGridView_0.Dock = DockStyle.Fill;
		this.dataGridView_0.Location = new Point(3, 3);
		this.dataGridView_0.MultiSelect = false;
		this.dataGridView_0.Name = "offStateDataGridView";
		this.dataGridView_0.ReadOnly = true;
		this.dataGridView_0.RowHeadersVisible = false;
		this.dataGridView_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridView_0.Size = new Size(403, 277);
		this.dataGridView_0.TabIndex = 0;
		this.dataGridView_0.CellClick += this.dataGridView_6_CellClick;
		this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_0.HeaderText = "Объект";
		this.dataGridViewTextBoxColumn_0.Name = "objOff";
		this.dataGridViewTextBoxColumn_0.ReadOnly = true;
		this.tabControl_0.Controls.Add(this.tabPage_0);
		this.tabControl_0.Controls.Add(this.tabPage_1);
		this.tabControl_0.Controls.Add(this.tabPage_2);
		this.tabControl_0.Controls.Add(this.tabPage_3);
		this.tabControl_0.Controls.Add(this.tabPage_6);
		this.tabControl_0.Controls.Add(this.tabPage_4);
		this.tabControl_0.Controls.Add(this.tabPage_5);
		this.tabControl_0.Dock = DockStyle.Fill;
		this.tabControl_0.Location = new Point(0, 0);
		this.tabControl_0.Name = "tabControl1";
		this.tabControl_0.SelectedIndex = 0;
		this.tabControl_0.Size = new Size(417, 309);
		this.tabControl_0.TabIndex = 1;
		this.tabPage_0.Controls.Add(this.dataGridView_0);
		this.tabPage_0.Location = new Point(4, 22);
		this.tabPage_0.Name = "offStatePage";
		this.tabPage_0.Padding = new Padding(3);
		this.tabPage_0.Size = new Size(409, 283);
		this.tabPage_0.TabIndex = 0;
		this.tabPage_0.Text = "Отсоединено";
		this.tabPage_0.UseVisualStyleBackColor = true;
		this.tabPage_1.Controls.Add(this.dataGridView_3);
		this.tabPage_1.Location = new Point(4, 22);
		this.tabPage_1.Name = "breakdownStatePage";
		this.tabPage_1.Padding = new Padding(3);
		this.tabPage_1.Size = new Size(774, 283);
		this.tabPage_1.TabIndex = 1;
		this.tabPage_1.Text = "Повреждено";
		this.tabPage_1.UseVisualStyleBackColor = true;
		this.dataGridView_3.AllowUserToAddRows = false;
		this.dataGridView_3.AllowUserToDeleteRows = false;
		this.dataGridView_3.AllowUserToResizeColumns = false;
		this.dataGridView_3.AllowUserToResizeRows = false;
		this.dataGridView_3.BackgroundColor = Color.White;
		this.dataGridView_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_3.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_3
		});
		this.dataGridView_3.Dock = DockStyle.Fill;
		this.dataGridView_3.Location = new Point(3, 3);
		this.dataGridView_3.MultiSelect = false;
		this.dataGridView_3.Name = "breakdownStateDataGridView";
		this.dataGridView_3.ReadOnly = true;
		this.dataGridView_3.RowHeadersVisible = false;
		this.dataGridView_3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		this.dataGridView_3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridView_3.Size = new Size(768, 277);
		this.dataGridView_3.TabIndex = 1;
		this.dataGridView_3.CellClick += this.dataGridView_6_CellClick;
		this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_3.HeaderText = "Объект";
		this.dataGridViewTextBoxColumn_3.Name = "objNotphased";
		this.dataGridViewTextBoxColumn_3.ReadOnly = true;
		this.tabPage_2.Controls.Add(this.dataGridView_2);
		this.tabPage_2.Location = new Point(4, 22);
		this.tabPage_2.Name = "groundedPage";
		this.tabPage_2.Padding = new Padding(3);
		this.tabPage_2.Size = new Size(774, 283);
		this.tabPage_2.TabIndex = 2;
		this.tabPage_2.Text = "Заземлено";
		this.tabPage_2.UseVisualStyleBackColor = true;
		this.dataGridView_2.AllowUserToAddRows = false;
		this.dataGridView_2.AllowUserToDeleteRows = false;
		this.dataGridView_2.AllowUserToResizeColumns = false;
		this.dataGridView_2.AllowUserToResizeRows = false;
		this.dataGridView_2.BackgroundColor = Color.White;
		this.dataGridView_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_2.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_2
		});
		this.dataGridView_2.Dock = DockStyle.Fill;
		this.dataGridView_2.Location = new Point(3, 3);
		this.dataGridView_2.MultiSelect = false;
		this.dataGridView_2.Name = "groundedStateDataGridView";
		this.dataGridView_2.ReadOnly = true;
		this.dataGridView_2.RowHeadersVisible = false;
		this.dataGridView_2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		this.dataGridView_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridView_2.Size = new Size(768, 277);
		this.dataGridView_2.TabIndex = 1;
		this.dataGridView_2.CellClick += this.dataGridView_6_CellClick;
		this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_2.HeaderText = "Объект";
		this.dataGridViewTextBoxColumn_2.Name = "objGrounded";
		this.dataGridViewTextBoxColumn_2.ReadOnly = true;
		this.tabPage_3.Controls.Add(this.dataGridView_1);
		this.tabPage_3.Location = new Point(4, 22);
		this.tabPage_3.Name = "notphasedPage";
		this.tabPage_3.Padding = new Padding(3);
		this.tabPage_3.Size = new Size(409, 283);
		this.tabPage_3.TabIndex = 3;
		this.tabPage_3.Text = "Не сфазировано";
		this.tabPage_3.UseVisualStyleBackColor = true;
		this.dataGridView_1.AllowUserToAddRows = false;
		this.dataGridView_1.AllowUserToDeleteRows = false;
		this.dataGridView_1.AllowUserToResizeColumns = false;
		this.dataGridView_1.AllowUserToResizeRows = false;
		this.dataGridView_1.BackgroundColor = Color.White;
		this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_1.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_1
		});
		this.dataGridView_1.Dock = DockStyle.Fill;
		this.dataGridView_1.Location = new Point(3, 3);
		this.dataGridView_1.MultiSelect = false;
		this.dataGridView_1.Name = "notPhasedStateDataGridView";
		this.dataGridView_1.ReadOnly = true;
		this.dataGridView_1.RowHeadersVisible = false;
		this.dataGridView_1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		this.dataGridView_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridView_1.Size = new Size(403, 277);
		this.dataGridView_1.TabIndex = 1;
		this.dataGridView_1.CellClick += this.dataGridView_6_CellClick;
		this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_1.HeaderText = "Объект";
		this.dataGridViewTextBoxColumn_1.Name = "objBreakdown";
		this.dataGridViewTextBoxColumn_1.ReadOnly = true;
		this.tabPage_4.Controls.Add(this.dataGridView_4);
		this.tabPage_4.Controls.Add(this.toolStrip_1);
		this.tabPage_4.Location = new Point(4, 22);
		this.tabPage_4.Name = "offSwitches";
		this.tabPage_4.Padding = new Padding(3);
		this.tabPage_4.Size = new Size(774, 283);
		this.tabPage_4.TabIndex = 4;
		this.tabPage_4.Text = "Отключенные выключатели";
		this.tabPage_4.UseVisualStyleBackColor = true;
		this.dataGridView_4.AllowUserToAddRows = false;
		this.dataGridView_4.AllowUserToDeleteRows = false;
		this.dataGridView_4.AllowUserToResizeColumns = false;
		this.dataGridView_4.AllowUserToResizeRows = false;
		this.dataGridView_4.BackgroundColor = Color.White;
		this.dataGridView_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_4.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_4
		});
		this.dataGridView_4.Dock = DockStyle.Fill;
		this.dataGridView_4.Location = new Point(3, 28);
		this.dataGridView_4.MultiSelect = false;
		this.dataGridView_4.Name = "offObjectOnLineDataGridView";
		this.dataGridView_4.ReadOnly = true;
		this.dataGridView_4.RowHeadersVisible = false;
		this.dataGridView_4.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		this.dataGridView_4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridView_4.Size = new Size(768, 252);
		this.dataGridView_4.TabIndex = 2;
		this.dataGridView_4.CellClick += this.dataGridView_6_CellClick;
		this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_4.HeaderText = "Объект";
		this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_4.ReadOnly = true;
		this.toolStrip_1.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_1
		});
		this.toolStrip_1.Location = new Point(3, 3);
		this.toolStrip_1.Name = "toolStrip2";
		this.toolStrip_1.Size = new Size(768, 25);
		this.toolStrip_1.TabIndex = 5;
		this.toolStrip_1.Text = "toolStrip2";
		this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_1.Image = (Image)componentResourceManager.GetObject("toolStripButton2.Image");
		this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_1.Name = "toolStripButton2";
		this.toolStripButton_1.Size = new Size(23, 22);
		this.toolStripButton_1.Text = "Отчёт";
		this.toolStripButton_1.Click += this.toolStripButton_0_Click;
		this.tabPage_5.Controls.Add(this.dataGridView_5);
		this.tabPage_5.Controls.Add(this.toolStrip_0);
		this.tabPage_5.Location = new Point(4, 22);
		this.tabPage_5.Name = "onNormalSection";
		this.tabPage_5.Padding = new Padding(3);
		this.tabPage_5.Size = new Size(774, 283);
		this.tabPage_5.TabIndex = 5;
		this.tabPage_5.Text = "Включенные нормальные разрезы";
		this.tabPage_5.UseVisualStyleBackColor = true;
		this.dataGridView_5.AllowUserToAddRows = false;
		this.dataGridView_5.AllowUserToDeleteRows = false;
		this.dataGridView_5.AllowUserToResizeColumns = false;
		this.dataGridView_5.AllowUserToResizeRows = false;
		this.dataGridView_5.BackgroundColor = Color.White;
		this.dataGridView_5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_5.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_5
		});
		this.dataGridView_5.Dock = DockStyle.Fill;
		this.dataGridView_5.Location = new Point(3, 28);
		this.dataGridView_5.MultiSelect = false;
		this.dataGridView_5.Name = "onNormalSectionDataGridView";
		this.dataGridView_5.ReadOnly = true;
		this.dataGridView_5.RowHeadersVisible = false;
		this.dataGridView_5.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		this.dataGridView_5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridView_5.Size = new Size(768, 252);
		this.dataGridView_5.TabIndex = 3;
		this.dataGridView_5.CellClick += this.dataGridView_6_CellClick;
		this.dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_5.HeaderText = "Объект";
		this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn2";
		this.dataGridViewTextBoxColumn_5.ReadOnly = true;
		this.toolStrip_0.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_0
		});
		this.toolStrip_0.Location = new Point(3, 3);
		this.toolStrip_0.Name = "toolStrip1";
		this.toolStrip_0.Size = new Size(768, 25);
		this.toolStrip_0.TabIndex = 4;
		this.toolStrip_0.Text = "toolStrip1";
		this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_0.Image = (Image)componentResourceManager.GetObject("toolStripButton1.Image");
		this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_0.Name = "toolStripButton1";
		this.toolStripButton_0.Size = new Size(23, 22);
		this.toolStripButton_0.Text = "Отчёт";
		this.toolStripButton_0.Click += this.toolStripButton_0_Click;
		this.tabPage_6.Controls.Add(this.dataGridView_6);
		this.tabPage_6.Location = new Point(4, 22);
		this.tabPage_6.Name = "arrowToolPage";
		this.tabPage_6.Padding = new Padding(3);
		this.tabPage_6.Size = new Size(409, 283);
		this.tabPage_6.TabIndex = 6;
		this.tabPage_6.Text = "Перенос нагрузки";
		this.tabPage_6.UseVisualStyleBackColor = true;
		this.dataGridView_6.AllowUserToAddRows = false;
		this.dataGridView_6.AllowUserToDeleteRows = false;
		this.dataGridView_6.AllowUserToResizeColumns = false;
		this.dataGridView_6.AllowUserToResizeRows = false;
		this.dataGridView_6.BackgroundColor = Color.White;
		this.dataGridView_6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_6.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_6
		});
		this.dataGridView_6.Dock = DockStyle.Fill;
		this.dataGridView_6.Location = new Point(3, 3);
		this.dataGridView_6.MultiSelect = false;
		this.dataGridView_6.Name = "arrowStateDataGridView";
		this.dataGridView_6.ReadOnly = true;
		this.dataGridView_6.RowHeadersVisible = false;
		this.dataGridView_6.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		this.dataGridView_6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridView_6.Size = new Size(403, 277);
		this.dataGridView_6.TabIndex = 2;
		this.dataGridView_6.CellClick += this.dataGridView_6_CellClick;
		this.dataGridViewTextBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_6.HeaderText = "Объект";
		this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn3";
		this.dataGridViewTextBoxColumn_6.ReadOnly = true;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(417, 309);
		base.Controls.Add(this.tabControl_0);
		base.DockAreas = 30;
		this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Name = "FormDockStates";
		this.Text = "Статусы объектов";
		((ISupportInitialize)this.dataGridView_0).EndInit();
		this.tabControl_0.ResumeLayout(false);
		this.tabPage_0.ResumeLayout(false);
		this.tabPage_1.ResumeLayout(false);
		((ISupportInitialize)this.dataGridView_3).EndInit();
		this.tabPage_2.ResumeLayout(false);
		((ISupportInitialize)this.dataGridView_2).EndInit();
		this.tabPage_3.ResumeLayout(false);
		((ISupportInitialize)this.dataGridView_1).EndInit();
		this.tabPage_4.ResumeLayout(false);
		this.tabPage_4.PerformLayout();
		((ISupportInitialize)this.dataGridView_4).EndInit();
		this.toolStrip_1.ResumeLayout(false);
		this.toolStrip_1.PerformLayout();
		this.tabPage_5.ResumeLayout(false);
		this.tabPage_5.PerformLayout();
		((ISupportInitialize)this.dataGridView_5).EndInit();
		this.toolStrip_0.ResumeLayout(false);
		this.toolStrip_0.PerformLayout();
		this.tabPage_6.ResumeLayout(false);
		((ISupportInitialize)this.dataGridView_6).EndInit();
		base.ResumeLayout(false);
	}

	internal static void F4mSKnGBANoGjS3b9Pj(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private Dictionary<LineToolState, Class12.Struct1> dictionary_0;

	private Dictionary<ObjectOnLine, DataGridViewRow> dictionary_1;

	[CompilerGenerated]
	private DataGridViewCellEventHandler dataGridViewCellEventHandler_0;

	private IContainer icontainer_0;

	private DataGridView dataGridView_0;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private TabPage tabPage_1;

	private DataGridView dataGridView_1;

	private TabPage tabPage_2;

	private DataGridView dataGridView_2;

	private TabPage tabPage_3;

	private DataGridView dataGridView_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private TabPage tabPage_4;

	private DataGridView dataGridView_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private TabPage tabPage_5;

	private DataGridView dataGridView_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private ToolStrip toolStrip_0;

	private ToolStripButton toolStripButton_0;

	private ToolStrip toolStrip_1;

	private ToolStripButton toolStripButton_1;

	private TabPage tabPage_6;

	private DataGridView dataGridView_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private delegate void Delegate3(DataGridView dgv, DataGridViewRow r);

	private struct Struct1
	{
		public Struct1(DataGridViewRow dataGridViewRow_1, DataGridView dataGridView_1)
		{
			Class63.AGd1PxHzk5wxP();
			this.dataGridViewRow_0 = dataGridViewRow_1;
			this.dataGridView_0 = dataGridView_1;
		}

		public DataGridViewRow dataGridViewRow_0;

		public DataGridView dataGridView_0;
	}
}
