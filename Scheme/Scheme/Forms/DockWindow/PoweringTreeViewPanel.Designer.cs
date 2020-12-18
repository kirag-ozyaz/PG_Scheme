using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using Scheme.Classes;
using Scheme.Properties;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using WinFormsUI.Docking;

internal class PoweringTreeViewPanel : DockContent
{
	internal PoweringTreeViewPanel()
	{
		
		
		this.method_12();
		GeneralFormSettings.SizeIconChanged(new EventHandler(this.method_1));
		GeneralFormSettings.FontSizeChanged(new EventHandler(this.method_0));
	}

	private void method_0(object sender, EventArgs e)
	{
		this.Font = new Font(this.Font.Name, GeneralFormSettings.FontSize);
	}

	private void method_1(object sender, EventArgs e)
	{
		this.toolStrip_0.ImageScalingSize = GeneralFormSettings.SizeIcon;
		this.toolStrip_0.Scale(new SizeF(2f, 2f));
	}

	internal DrawObjectBase method_2()
	{
		return this.drawObjectBase_0;
	}

	internal void VtnUlqUaJQ(DrawObjectBase drawObjectBase_1)
	{
		this.dataGridView_0.Rows.Clear();
		if (drawObjectBase_1 == null)
		{
			this.drawObjectBase_0 = drawObjectBase_1;
			this.Text = "Сеть";
			this.treeView_0.Nodes.Clear();
			this.treeView_1.Nodes.Clear();
			return;
		}
		if (drawObjectBase_1.GetType() == typeof(RectangleTool) || drawObjectBase_1.GetType() == typeof(ShinaTool))
		{
			this.drawObjectBase_0 = drawObjectBase_1;
			if (drawObjectBase_1.GetType() == typeof(RectangleTool))
			{
				this.Text = this.drawObjectBase_0.ToString();
			}
			else
			{
				this.Text = this.drawObjectBase_0.Parent + " - " + this.drawObjectBase_0.ToString();
			}
			this.method_3();
		}
	}

	private void method_3()
	{
		this.treeView_0.Nodes.Clear();
		this.treeView_1.Nodes.Clear();
	}

	private TreeNode method_4(TreeView treeView_2, DrawObjectBase drawObjectBase_1)
	{
		DrawObjectBase drawObjectBase;
		if (drawObjectBase_1.GetType() == typeof(Branch))
		{
			drawObjectBase = drawObjectBase_1.Parent;
		}
		else
		{
			drawObjectBase = drawObjectBase_1;
		}
		TreeNode treeNode = treeView_2.Nodes.Add(drawObjectBase.Text);
		treeNode.Tag = drawObjectBase;
		Type type = drawObjectBase.GetType();
		if (type == typeof(RectangleTool))
		{
			treeNode.ImageIndex = 0;
			treeNode.SelectedImageIndex = 0;
		}
		else if (type == typeof(ShinaTool))
		{
			treeNode.ImageIndex = 2;
			treeNode.SelectedImageIndex = 2;
		}
		else if (type == typeof(LineCellTool))
		{
			treeNode.ImageIndex = 1;
			treeNode.SelectedImageIndex = 1;
		}
		else if (type == typeof(LineTool))
		{
			treeNode.ImageIndex = 4;
			treeNode.SelectedImageIndex = 4;
		}
		return treeNode;
	}

	private TreeNode method_5(TreeNode treeNode_1, DrawObjectBase drawObjectBase_1)
	{
		DrawObjectBase drawObjectBase;
		if (drawObjectBase_1.GetType() == typeof(Branch))
		{
			drawObjectBase = drawObjectBase_1.Parent;
		}
		else
		{
			drawObjectBase = drawObjectBase_1;
		}
		if (drawObjectBase != treeNode_1.Tag)
		{
			TreeNode treeNode = treeNode_1.Nodes.Add(drawObjectBase.Text);
			treeNode.Tag = drawObjectBase;
			Type type = treeNode.Tag.GetType();
			if (type == typeof(RectangleTool))
			{
				treeNode.ImageIndex = 0;
				treeNode.SelectedImageIndex = 0;
			}
			else if (type == typeof(ShinaTool))
			{
				treeNode.ImageIndex = 2;
				treeNode.SelectedImageIndex = 2;
			}
			else if (type == typeof(LineCellTool))
			{
				treeNode.ImageIndex = 1;
				treeNode.SelectedImageIndex = 1;
			}
			else if (type == typeof(LineTool))
			{
				treeNode.ImageIndex = 4;
				treeNode.SelectedImageIndex = 4;
			}
			return treeNode;
		}
		return null;
	}

	private List<DrawObjectBase> xTjUdIqvoK(ShinaTool shinaTool_0)
	{
		if (shinaTool_0.Amperage != null)
		{
			return shinaTool_0.Amperage.GetPowerSource();
		}
		return null;
	}

	private void method_6(Amperage amperage_0, TreeNode treeNode_1)
	{
		TreeNode treeNode_2 = this.method_5(treeNode_1, amperage_0.Conductor);
		foreach (Amperage amperage_ in amperage_0.NextAmperages)
		{
			this.method_6(amperage_, treeNode_2);
		}
	}

	private void treeView_1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
	{
		this.treeNode_0 = e.Node;
		if (e.Button == MouseButtons.Right && e.Node != null)
		{
			CanvasControl canvasControl = (CanvasControl)((DockContentBase)base.DockPanel.ActiveDocument).Controls[0];
			if (canvasControl != null)
			{
				if (canvasControl.TypeCanvas == eTypeCanvas.SchemeMain)
				{
					ContextMenuStrip contextMenuStrip = canvasControl.GetContextMenuByObject((DrawObjectBase)e.Node.Tag);
					if (contextMenuStrip == null)
					{
						contextMenuStrip = new ContextMenuStrip();
						contextMenuStrip.Tag = e.Node.Tag;
					}
					ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
					toolStripMenuItem.Text = "Показать";
					toolStripMenuItem.Click += this.method_7;
					contextMenuStrip.Items.Add(toolStripMenuItem);
					contextMenuStrip.Show(Cursor.Position);
					return;
				}
			}
			return;
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		if (((ToolStripMenuItem)sender).Owner.Tag != null)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			list.Add((DrawObjectBase)((ToolStripMenuItem)sender).Owner.Tag);
			((CanvasControl)((DockContent)base.DockPanel.ActiveDocument).Controls[0]).SetObjectsInCenterScreen(list, false, CanvasControl.SetObjectsInCenterScreenOptions.none);
		}
	}

	private void treeView_1_AfterSelect(object sender, TreeViewEventArgs e)
	{
		this.dataGridView_0.Rows.Clear();
		if (((DrawObjectBase)e.Node.Tag).Parent != null)
		{
			int index = this.dataGridView_0.Rows.Add(new string[]
			{
				"Родительский обьект",
				((DrawObjectBase)e.Node.Tag).Parent.ToString()
			});
			this.dataGridView_0.Rows[index].Tag = ((DrawObjectBase)e.Node.Tag).Parent;
		}
	}

	private void treeView_0_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
	{
	}

	private void dataGridView_0_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (e.Button == MouseButtons.Right && this.dataGridView_0.Rows[e.RowIndex] != null)
		{
			CanvasControl canvasControl = (CanvasControl)((DockContentBase)base.DockPanel.ActiveDocument).Controls[0];
			if (canvasControl != null)
			{
				if (canvasControl.TypeCanvas == eTypeCanvas.SchemeMain)
				{
					ContextMenuStrip contextMenuStrip = canvasControl.GetContextMenuByObject((DrawObjectBase)this.dataGridView_0.Rows[e.RowIndex].Tag);
					if (contextMenuStrip == null)
					{
						contextMenuStrip = new ContextMenuStrip();
					}
					ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
					toolStripMenuItem.Text = "Показать";
					toolStripMenuItem.Click += this.method_7;
					contextMenuStrip.Items.Add(toolStripMenuItem);
					contextMenuStrip.Show(Cursor.Position);
					return;
				}
			}
			return;
		}
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		List<DrawObjectBase> list = new List<DrawObjectBase>();
		if (this.tabControl_0.SelectedTab.Name == "calcSchemePage")
		{
			foreach (object obj in ((TreeView)this.tabControl_0.SelectedTab.Controls[0]).Nodes)
			{
				TreeNode treeNode_ = (TreeNode)obj;
				this.method_8(treeNode_, list);
			}
			((CanvasControl)((DockContent)base.DockPanel.ActiveDocument).Controls[0]).SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
		}
	}

	private void method_8(TreeNode treeNode_1, List<DrawObjectBase> list_0)
	{
		list_0.Add((DrawObjectBase)treeNode_1.Tag);
		foreach (object obj in treeNode_1.Nodes)
		{
			TreeNode treeNode_2 = (TreeNode)obj;
			this.method_8(treeNode_2, list_0);
		}
	}

	private void Class17_Load(object sender, EventArgs e)
	{
		this.method_11();
	}

	[CompilerGenerated]
	public SQLSettings method_9()
	{
		return this.sqlsettings_0;
	}

	[CompilerGenerated]
	public void method_10(SQLSettings sqlsettings_1)
	{
		this.sqlsettings_0 = sqlsettings_1;
	}

	internal void method_11()
	{
		if (this.method_9() == null)
		{
			return;
		}
		new SqlDataCommand(this.method_9()).SelectSqlData(this.class19_0.vSchm_CheckSecondLevel, false, "  ORDER BY DateFilling DESC", null, false, 0);
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		this.method_11();
	}

	private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		CanvasControl canvasControl = (CanvasControl)((DockContentBase)base.DockPanel.ActiveDocument).Controls[0];
		if (canvasControl.TypeCanvas != eTypeCanvas.SchemeMain)
		{
			return;
		}
		DrawObjectBase drawObject = canvasControl.FindObjectById(Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_4.Name, e.RowIndex].Value));
		canvasControl.SetObjectsInCenterScreen(drawObject, false, CanvasControl.SetObjectsInCenterScreenOptions.select);
	}

	protected override void Dispose(bool bool_0)
	{
		GeneralFormSettings.smethod_1(new EventHandler(this.method_1));
		GeneralFormSettings.smethod_3(new EventHandler(this.method_0));
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		PoweringTreeViewPanel.pmuJtuk7HFPKRVH5lTf(this, bool_0);
	}

	private void method_12()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PoweringTreeViewPanel));
		this.toolStrip_0 = new ToolStrip();
		this.toolStripButton_0 = new ToolStripButton();
		this.toolStripButton_1 = new ToolStripButton();
		this.treeView_0 = new TreeView();
		this.imageList_0 = new ImageList(this.icontainer_0);
		this.dataGridView_0 = new DataGridView();
		this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		this.tabControl_0 = new TabControl();
		this.tabPage_0 = new TabPage();
		this.tabPage_1 = new TabPage();
		this.treeView_1 = new TreeView();
		this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
		this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.class19_0 = new Class19();
		this.toolStrip_0.SuspendLayout();
		((ISupportInitialize)this.dataGridView_0).BeginInit();
		this.tabControl_0.SuspendLayout();
		this.tabPage_0.SuspendLayout();
		this.tabPage_1.SuspendLayout();
		((ISupportInitialize)this.dataGridViewExcelFilter_0).BeginInit();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		((ISupportInitialize)this.class19_0).BeginInit();
		base.SuspendLayout();
		this.toolStrip_0.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_0,
			this.toolStripButton_1
		});
		this.toolStrip_0.LayoutStyle = ToolStripLayoutStyle.Flow;
		this.toolStrip_0.Location = new Point(0, 0);
		this.toolStrip_0.Name = "toolStrip";
		this.toolStrip_0.Size = new Size(743, 23);
		this.toolStrip_0.TabIndex = 0;
		this.toolStrip_0.Text = "toolStrip1";
		this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_0.Image = Resources.smethod_39();
		this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_0.Name = "toolStripButton1";
		this.toolStripButton_0.Size = new Size(23, 20);
		this.toolStripButton_0.Text = "Показать";
		this.toolStripButton_0.Visible = false;
		this.toolStripButton_0.Click += this.toolStripButton_0_Click;
		this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_1.Image = Resources.smethod_51();
		this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_1.Name = "toolStripButtonRefresh";
		this.toolStripButton_1.Size = new Size(23, 20);
		this.toolStripButton_1.Text = "Обновить";
		this.toolStripButton_1.Click += this.toolStripButton_1_Click;
		this.treeView_0.Dock = DockStyle.Fill;
		this.treeView_0.ImageIndex = 0;
		this.treeView_0.ImageList = this.imageList_0;
		this.treeView_0.Location = new Point(3, 3);
		this.treeView_0.Name = "poweringTreeView";
		this.treeView_0.SelectedImageIndex = 0;
		this.treeView_0.Size = new Size(729, 357);
		this.treeView_0.TabIndex = 1;
		this.treeView_0.AfterSelect += this.treeView_1_AfterSelect;
		this.treeView_0.NodeMouseClick += this.treeView_1_NodeMouseClick;
		this.treeView_0.NodeMouseDoubleClick += this.treeView_0_NodeMouseDoubleClick;
		this.imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListTreeView.ImageStream");
		this.imageList_0.TransparentColor = Color.Transparent;
		this.imageList_0.Images.SetKeyName(0, "Substation");
		this.imageList_0.Images.SetKeyName(1, "Switch");
		this.imageList_0.Images.SetKeyName(2, "Bus");
		this.imageList_0.Images.SetKeyName(3, "Transformer");
		this.imageList_0.Images.SetKeyName(4, "Cable");
		this.imageList_0.Images.SetKeyName(5, "Clutch");
		this.imageList_0.Images.SetKeyName(6, "AirWay");
		this.dataGridView_0.AllowUserToAddRows = false;
		this.dataGridView_0.AllowUserToDeleteRows = false;
		this.dataGridView_0.BackgroundColor = SystemColors.Window;
		this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_0.ColumnHeadersVisible = false;
		this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_1,
			this.dataGridViewTextBoxColumn_2
		});
		this.dataGridView_0.Location = new Point(0, 297);
		this.dataGridView_0.MultiSelect = false;
		this.dataGridView_0.Name = "propertyGridView";
		this.dataGridView_0.ReadOnly = true;
		this.dataGridView_0.RowHeadersVisible = false;
		this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridView_0.Size = new Size(259, 75);
		this.dataGridView_0.TabIndex = 2;
		this.dataGridView_0.CellMouseClick += this.dataGridView_0_CellMouseClick;
		this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_1.HeaderText = "какие-то свойства";
		this.dataGridViewTextBoxColumn_1.Name = "nameProperty";
		this.dataGridViewTextBoxColumn_1.ReadOnly = true;
		this.dataGridViewTextBoxColumn_2.HeaderText = "Column2";
		this.dataGridViewTextBoxColumn_2.Name = "value";
		this.dataGridViewTextBoxColumn_2.ReadOnly = true;
		this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_0.HeaderText = "какие-то свойства";
		this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
		this.tabControl_0.Controls.Add(this.tabPage_0);
		this.tabControl_0.Controls.Add(this.tabPage_1);
		this.tabControl_0.Dock = DockStyle.Fill;
		this.tabControl_0.Location = new Point(0, 23);
		this.tabControl_0.Name = "tabControl1";
		this.tabControl_0.SelectedIndex = 0;
		this.tabControl_0.Size = new Size(743, 389);
		this.tabControl_0.TabIndex = 3;
		this.tabPage_0.Controls.Add(this.treeView_0);
		this.tabPage_0.Location = new Point(4, 22);
		this.tabPage_0.Name = "poweringPage";
		this.tabPage_0.Padding = new Padding(3);
		this.tabPage_0.Size = new Size(735, 363);
		this.tabPage_0.TabIndex = 0;
		this.tabPage_0.Text = "Запитка";
		this.tabPage_0.UseVisualStyleBackColor = true;
		this.tabPage_1.Controls.Add(this.treeView_1);
		this.tabPage_1.Location = new Point(4, 22);
		this.tabPage_1.Name = "calcSchemePage";
		this.tabPage_1.Padding = new Padding(3);
		this.tabPage_1.Size = new Size(735, 363);
		this.tabPage_1.TabIndex = 1;
		this.tabPage_1.Text = "Просчёт схемы";
		this.tabPage_1.UseVisualStyleBackColor = true;
		this.treeView_1.Dock = DockStyle.Fill;
		this.treeView_1.ImageIndex = 0;
		this.treeView_1.ImageList = this.imageList_0;
		this.treeView_1.Location = new Point(3, 3);
		this.treeView_1.Name = "powerOutTreeView";
		this.treeView_1.SelectedImageIndex = 0;
		this.treeView_1.Size = new Size(245, 242);
		this.treeView_1.TabIndex = 2;
		this.treeView_1.AfterSelect += this.treeView_1_AfterSelect;
		this.treeView_1.NodeMouseClick += this.treeView_1_NodeMouseClick;
		this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_0.BackgroundColor = Color.White;
		this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_3,
			this.dataGridViewTextBoxColumn_4,
			this.dataGridViewTextBoxColumn_5,
			this.dataGridViewTextBoxColumn_6,
			this.dataGridViewTextBoxColumn_7,
			this.dataGridViewTextBoxColumn_8
		});
		this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
		this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
		this.dataGridViewExcelFilter_0.Location = new Point(0, 23);
		this.dataGridViewExcelFilter_0.Name = "dataGridView1";
		this.dataGridViewExcelFilter_0.ReadOnly = true;
		this.dataGridViewExcelFilter_0.RowHeadersWidth = 20;
		this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewExcelFilter_0.Size = new Size(743, 389);
		this.dataGridViewExcelFilter_0.TabIndex = 4;
		this.dataGridViewExcelFilter_0.CellDoubleClick += this.dataGridViewExcelFilter_0_CellDoubleClick;
		this.dataGridViewTextBoxColumn_3.DataPropertyName = "ObjectName";
		this.dataGridViewTextBoxColumn_3.HeaderText = "Имя Объекта";
		this.dataGridViewTextBoxColumn_3.Name = "objectNameDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_3.ReadOnly = true;
		this.dataGridViewTextBoxColumn_4.DataPropertyName = "idObj";
		this.dataGridViewTextBoxColumn_4.HeaderText = "idObj";
		this.dataGridViewTextBoxColumn_4.Name = "idObjColumn";
		this.dataGridViewTextBoxColumn_4.ReadOnly = true;
		this.dataGridViewTextBoxColumn_4.Visible = false;
		this.dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_5.DataPropertyName = "UserFilled";
		this.dataGridViewTextBoxColumn_5.HeaderText = "Кто заполнил";
		this.dataGridViewTextBoxColumn_5.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn_5.Name = "userFilledDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_5.ReadOnly = true;
		this.dataGridViewTextBoxColumn_6.DataPropertyName = "DateFilling";
		this.dataGridViewTextBoxColumn_6.HeaderText = "Дата заполнение";
		this.dataGridViewTextBoxColumn_6.Name = "dateFillingDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_6.ReadOnly = true;
		this.dataGridViewTextBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_7.DataPropertyName = "UserChecked";
		this.dataGridViewTextBoxColumn_7.HeaderText = "Кто проверил";
		this.dataGridViewTextBoxColumn_7.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn_7.Name = "userCheckedDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_7.ReadOnly = true;
		this.dataGridViewTextBoxColumn_8.DataPropertyName = "CheckDate";
		this.dataGridViewTextBoxColumn_8.HeaderText = "Дата проверки";
		this.dataGridViewTextBoxColumn_8.Name = "checkDateDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_8.ReadOnly = true;
		this.bindingSource_0.DataMember = "vSchm_CheckSecondLevel";
		this.bindingSource_0.DataSource = this.class19_0;
		this.class19_0.DataSetName = "DataSetScheme";
		this.class19_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		base.AutoHidePortion = 0.15;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(743, 412);
		base.Controls.Add(this.dataGridViewExcelFilter_0);
		base.Controls.Add(this.tabControl_0);
		base.Controls.Add(this.dataGridView_0);
		base.Controls.Add(this.toolStrip_0);
		base.DockAreas = 30;
		this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Name = "PoweringTreeViewPanel";
		base.ShowHint = 9;
		this.Text = "Проверка \"второго\" уровня";
		base.Load += this.Class17_Load;
		this.toolStrip_0.ResumeLayout(false);
		this.toolStrip_0.PerformLayout();
		((ISupportInitialize)this.dataGridView_0).EndInit();
		this.tabControl_0.ResumeLayout(false);
		this.tabPage_0.ResumeLayout(false);
		this.tabPage_1.ResumeLayout(false);
		((ISupportInitialize)this.dataGridViewExcelFilter_0).EndInit();
		((ISupportInitialize)this.bindingSource_0).EndInit();
		((ISupportInitialize)this.class19_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	internal static void pmuJtuk7HFPKRVH5lTf(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private DrawObjectBase drawObjectBase_0;

	private TreeNode treeNode_0;

	[CompilerGenerated]
	private SQLSettings sqlsettings_0;

	private IContainer icontainer_0;

	private ToolStrip toolStrip_0;

	private ToolStripButton toolStripButton_0;

	private TreeView treeView_0;

	private DataGridView dataGridView_0;

	private ImageList imageList_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private TabPage tabPage_1;

	private TreeView treeView_1;

	private DataGridViewExcelFilter dataGridViewExcelFilter_0;

	private ToolStripButton toolStripButton_1;

	private Class19 class19_0;

	private BindingSource bindingSource_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
}
