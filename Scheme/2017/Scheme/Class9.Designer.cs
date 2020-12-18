using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using Scheme.Classes;
using Scheme.Properties;
using SchemeCtrl2.Canvas;
using WinFormsUI.Docking;

internal class Class9 : DockContent
{
	[CompilerGenerated]
	internal void method_0(DataGridViewCellEventHandler dataGridViewCellEventHandler_1)
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
	internal void method_1(DataGridViewCellEventHandler dataGridViewCellEventHandler_1)
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

	internal DataGridViewSelectedRowCollection method_2()
	{
		return this.class10_0.SelectedRows;
	}

	internal Class9()
	{
		Class63.AGd1PxHzk5wxP();
		this.class10_0 = new Class10();
		this.class10_1 = new Class10();
		base..ctor();
		this.method_7();
		this.tabPage_0.Controls.Add(this.class10_0);
		this.class10_0.Dock = DockStyle.Fill;
		this.class10_0.method_1(this.imageList_0);
		this.class10_0.CellClick += this.class10_1_CellClick;
		this.method_0(new DataGridViewCellEventHandler(this.method_4));
		this.tabPage_1.Controls.Add(this.class10_1);
		this.class10_1.Dock = DockStyle.Fill;
		this.class10_1.method_1(this.imageList_0);
		this.class10_1.CellClick += this.class10_1_CellClick;
		GeneralFormSettings.smethod_2(new EventHandler(this.method_3));
	}

	private void method_3(object sender, EventArgs e)
	{
		this.Font = new Font(this.Font.Name, GeneralFormSettings.FontSize);
	}

	private void class10_1_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		this.dataGridViewCellEventHandler_0(sender, e);
	}

	private void method_4(object sender, DataGridViewCellEventArgs e)
	{
	}

	internal void method_5()
	{
		foreach (object obj in ((IEnumerable)this.class10_1.Rows))
		{
			DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
			if (dataGridViewRow.Tag != null)
			{
				dataGridViewRow.Tag = null;
			}
		}
		foreach (object obj2 in ((IEnumerable)this.class10_0.Rows))
		{
			DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
			if (dataGridViewRow2.Tag != null)
			{
				dataGridViewRow2.Tag = null;
			}
		}
		this.class10_1.method_4();
		this.class10_0.method_4();
	}

	internal void method_6(string string_0, int int_0, object object_0)
	{
		switch (int_0)
		{
		case 0:
		case 1:
		case 2:
			this.class10_0.method_2(string_0, int_0, object_0);
			return;
		case 3:
		case 4:
			break;
		case 5:
		{
			CanvasMessageEventArgs canvasMessageEventArgs = (CanvasMessageEventArgs)object_0;
			this.toolStripLabel_1.Text = string_0;
			this.class19_0.vSchm_LogDispatcher.Clear();
			foreach (object obj in canvasMessageEventArgs.LogDispatcher.Rows)
			{
				DataRow row = (DataRow)obj;
				this.class19_0.vSchm_LogDispatcher.ImportRow(row);
			}
			break;
		}
		default:
			return;
		}
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		this.dataGridViewExcelFilter_0.CopyToExcel(true);
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		this.dataGridViewExcelFilter_0.PrintDataGridView();
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(bool_0);
	}

	private void method_7()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Class9));
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		this.imageList_0 = new ImageList(this.icontainer_0);
		this.tabControl_0 = new TabControl();
		this.tabPage_0 = new TabPage();
		this.tabPage_1 = new TabPage();
		this.tabPage_2 = new TabPage();
		this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
		this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.class19_0 = new Class19();
		this.toolStrip_0 = new ToolStrip();
		this.toolStripButton_0 = new ToolStripButton();
		this.toolStripButton_1 = new ToolStripButton();
		this.toolStripLabel_0 = new ToolStripLabel();
		this.toolStripLabel_1 = new ToolStripLabel();
		this.tabControl_0.SuspendLayout();
		this.tabPage_2.SuspendLayout();
		this.dataGridViewExcelFilter_0.BeginInit();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		((ISupportInitialize)this.class19_0).BeginInit();
		this.toolStrip_0.SuspendLayout();
		base.SuspendLayout();
		this.imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("canvasMessageImageList.ImageStream");
		this.imageList_0.TransparentColor = Color.Transparent;
		this.imageList_0.Images.SetKeyName(0, "symbol_error.png");
		this.imageList_0.Images.SetKeyName(1, "symbol_exclamation.png");
		this.imageList_0.Images.SetKeyName(2, "symbol_information.png");
		this.tabControl_0.Controls.Add(this.tabPage_0);
		this.tabControl_0.Controls.Add(this.tabPage_1);
		this.tabControl_0.Controls.Add(this.tabPage_2);
		this.tabControl_0.Dock = DockStyle.Fill;
		this.tabControl_0.Location = new Point(0, 0);
		this.tabControl_0.Name = "messageTabControl";
		this.tabControl_0.SelectedIndex = 0;
		this.tabControl_0.Size = new Size(467, 299);
		this.tabControl_0.TabIndex = 0;
		this.tabPage_0.Location = new Point(4, 22);
		this.tabPage_0.Name = "messagePage";
		this.tabPage_0.Padding = new Padding(3);
		this.tabPage_0.Size = new Size(459, 273);
		this.tabPage_0.TabIndex = 0;
		this.tabPage_0.Text = "Сообщения";
		this.tabPage_0.UseVisualStyleBackColor = true;
		this.tabPage_1.Location = new Point(4, 22);
		this.tabPage_1.Name = "errorPage";
		this.tabPage_1.Padding = new Padding(3);
		this.tabPage_1.Size = new Size(459, 273);
		this.tabPage_1.TabIndex = 1;
		this.tabPage_1.Text = "Ошибки";
		this.tabPage_1.UseVisualStyleBackColor = true;
		this.tabPage_2.Controls.Add(this.dataGridViewExcelFilter_0);
		this.tabPage_2.Controls.Add(this.toolStrip_0);
		this.tabPage_2.Location = new Point(4, 22);
		this.tabPage_2.Name = "tabPageLogDispatcher";
		this.tabPage_2.Padding = new Padding(3);
		this.tabPage_2.Size = new Size(459, 273);
		this.tabPage_2.TabIndex = 2;
		this.tabPage_2.Text = "Отчет диспетчера";
		this.tabPage_2.UseVisualStyleBackColor = true;
		this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
		this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToVisibleColumns = false;
		this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_0,
			this.dataGridViewTextBoxColumn_1,
			this.dataGridViewTextBoxColumn_2,
			this.dataGridViewTextBoxColumn_3,
			this.dataGridViewTextBoxColumn_4,
			this.dataGridViewTextBoxColumn_5,
			this.dataGridViewTextBoxColumn_6,
			this.dataGridViewTextBoxColumn_7
		});
		this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
		this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
		this.dataGridViewExcelFilter_0.Location = new Point(3, 28);
		this.dataGridViewExcelFilter_0.Name = "dgvLogDispatcher";
		this.dataGridViewExcelFilter_0.ReadOnly = true;
		this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
		this.dataGridViewExcelFilter_0.Size = new Size(453, 242);
		this.dataGridViewExcelFilter_0.TabIndex = 0;
		this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_0.HeaderText = "id";
		this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewTextBoxColumn_0.Visible = false;
		this.dataGridViewTextBoxColumn_1.DataPropertyName = "idUser";
		this.dataGridViewTextBoxColumn_1.HeaderText = "idUser";
		this.dataGridViewTextBoxColumn_1.Name = "idUserDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_1.ReadOnly = true;
		this.dataGridViewTextBoxColumn_1.Visible = false;
		this.dataGridViewTextBoxColumn_2.DataPropertyName = "username";
		this.dataGridViewTextBoxColumn_2.HeaderText = "Диспетчер";
		this.dataGridViewTextBoxColumn_2.Name = "usernameDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_2.ReadOnly = true;
		this.dataGridViewTextBoxColumn_3.DataPropertyName = "DateLog";
		dataGridViewCellStyle.Format = "G";
		dataGridViewCellStyle.NullValue = null;
		this.dataGridViewTextBoxColumn_3.DefaultCellStyle = dataGridViewCellStyle;
		this.dataGridViewTextBoxColumn_3.HeaderText = "Дата";
		this.dataGridViewTextBoxColumn_3.Name = "dateLogDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_3.ReadOnly = true;
		this.dataGridViewTextBoxColumn_4.DataPropertyName = "idObj";
		this.dataGridViewTextBoxColumn_4.HeaderText = "idObj";
		this.dataGridViewTextBoxColumn_4.Name = "idObjDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_4.ReadOnly = true;
		this.dataGridViewTextBoxColumn_4.Visible = false;
		this.dataGridViewTextBoxColumn_5.DataPropertyName = "NameObj";
		this.dataGridViewTextBoxColumn_5.HeaderText = "Объект";
		this.dataGridViewTextBoxColumn_5.Name = "nameObjDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_5.ReadOnly = true;
		this.dataGridViewTextBoxColumn_6.DataPropertyName = "Action";
		this.dataGridViewTextBoxColumn_6.HeaderText = "Действие";
		this.dataGridViewTextBoxColumn_6.Name = "actionDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_6.ReadOnly = true;
		this.dataGridViewTextBoxColumn_7.DataPropertyName = "Comment";
		this.dataGridViewTextBoxColumn_7.HeaderText = "Comment";
		this.dataGridViewTextBoxColumn_7.Name = "commentDataGridViewTextBoxColumn";
		this.dataGridViewTextBoxColumn_7.ReadOnly = true;
		this.dataGridViewTextBoxColumn_7.Visible = false;
		this.bindingSource_0.DataMember = "vSchm_LogDispatcher";
		this.bindingSource_0.DataSource = this.class19_0;
		this.class19_0.DataSetName = "DataSetScheme";
		this.class19_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
		this.toolStrip_0.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_1,
			this.toolStripButton_0,
			this.toolStripLabel_0,
			this.toolStripLabel_1
		});
		this.toolStrip_0.Location = new Point(3, 3);
		this.toolStrip_0.Name = "toolStripLogDispatcher";
		this.toolStrip_0.Size = new Size(453, 25);
		this.toolStrip_0.TabIndex = 2;
		this.toolStrip_0.Text = "toolStripLogDispatcher";
		this.toolStripButton_0.Alignment = ToolStripItemAlignment.Right;
		this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_0.Image = Resources.smethod_40();
		this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_0.Name = "toolBtnLogDispExportExcel";
		this.toolStripButton_0.Size = new Size(23, 22);
		this.toolStripButton_0.Text = "Экспорт в Excel";
		this.toolStripButton_0.Click += this.toolStripButton_0_Click;
		this.toolStripButton_1.Alignment = ToolStripItemAlignment.Right;
		this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_1.Image = Resources.smethod_46();
		this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_1.Name = "toolBtnLogDispPrint";
		this.toolStripButton_1.Size = new Size(23, 22);
		this.toolStripButton_1.Text = "Печать";
		this.toolStripButton_1.Click += this.toolStripButton_1_Click;
		this.toolStripLabel_0.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.toolStripLabel_0.Name = "toolStripLabel1";
		this.toolStripLabel_0.Size = new Size(53, 22);
		this.toolStripLabel_0.Text = "Объект:";
		this.toolStripLabel_1.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.toolStripLabel_1.Name = "labelObjLogDispatcher";
		this.toolStripLabel_1.Size = new Size(0, 22);
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(467, 299);
		base.Controls.Add(this.tabControl_0);
		base.DockAreas = 16;
		this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Name = "FormDockCanvasMessage";
		this.Text = "Панель сообщений";
		this.tabControl_0.ResumeLayout(false);
		this.tabPage_2.ResumeLayout(false);
		this.tabPage_2.PerformLayout();
		this.dataGridViewExcelFilter_0.EndInit();
		((ISupportInitialize)this.bindingSource_0).EndInit();
		((ISupportInitialize)this.class19_0).EndInit();
		this.toolStrip_0.ResumeLayout(false);
		this.toolStrip_0.PerformLayout();
		base.ResumeLayout(false);
	}

	private Class10 class10_0;

	private Class10 class10_1;

	[CompilerGenerated]
	private DataGridViewCellEventHandler dataGridViewCellEventHandler_0;

	private IContainer icontainer_0;

	private ImageList imageList_0;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private TabPage tabPage_1;

	private TabPage tabPage_2;

	private DataGridViewExcelFilter dataGridViewExcelFilter_0;

	private Class19 class19_0;

	private BindingSource bindingSource_0;

	private ToolStrip toolStrip_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

	private ToolStripButton toolStripButton_0;

	private ToolStripButton toolStripButton_1;

	private ToolStripLabel toolStripLabel_0;

	private ToolStripLabel toolStripLabel_1;
}
