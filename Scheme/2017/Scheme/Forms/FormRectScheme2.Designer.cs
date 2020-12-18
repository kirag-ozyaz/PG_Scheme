using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataSql;
using FormLbr;
using Scheme.Properties;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Layers;

namespace Scheme.Forms
{
	public class FormRectScheme2 : FormBase
	{
		public FormRectScheme2()
		{
			Class63.AGd1PxHzk5wxP();
			base..ctor();
			this.method_0();
			if (this.canvasControl_0.Layers.Count<ICanvasLayer>() <= 0)
			{
				DrawingLayer drawingLayer = new DrawingLayer("defaultLayer", "Default Layer", Color.White, 0f);
				drawingLayer.Parent = this.canvasControl_0;
				this.canvasControl_0.AddLayer(drawingLayer);
			}
			this.Text = "Схема 2-ой уровень";
			this.toolStripComboBox_0.SelectedIndex = 0;
		}

		public FormRectScheme2(RectangleTool r, SQLSettings sqlSettings)
		{
			Class63.AGd1PxHzk5wxP();
			base..ctor();
			this.method_0();
			this.SqlSettings = sqlSettings;
			this.canvasControl_0.SqlSettings = this.SqlSettings;
			this.canvasControl_0.UseObjectFromDB = true;
			this.rectangleTool_0 = r;
			switch (this.rectangleTool_0.TypeRectnagleTool)
			{
			case eTypeRectangleTool.PP:
				this.Text = "Схема: ПП-" + this.rectangleTool_0.Text;
				break;
			case eTypeRectangleTool.CP:
				this.Text = "Схема: ЦП-" + this.rectangleTool_0.Text;
				break;
			case eTypeRectangleTool.RP:
				this.Text = "Схема: РП-" + this.rectangleTool_0.Text;
				break;
			case eTypeRectangleTool.TP:
				this.Text = "Схема: ТП-" + this.rectangleTool_0.Text;
				break;
			}
			this.toolStripComboBox_0.SelectedIndex = 0;
		}

		private void FormRectScheme2_Load(object sender, EventArgs e)
		{
			this.canvasControl_0.LoadScheme(this.rectangleTool_0);
			this.canvasControl_0.Settings.LoadSchemeFromBase(this.canvasControl_0.SqlSettings, eTypeCanvas.SchemeSecond);
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			this.canvasControl_0.CommandPan();
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			this.canvasControl_0.CommandEscape();
		}

		private void toolStripButton_3_Click(object sender, EventArgs e)
		{
			this.canvasControl_0.undoRedoManager.Undo();
		}

		private void toolStripButton_4_Click(object sender, EventArgs e)
		{
			this.canvasControl_0.undoRedoManager.Undo();
		}

		private void toolStripComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.toolStripComboBox_0.SelectedIndex == 0)
			{
				this.canvasControl_0.Mode = eCanvasEditingMode.ReadOnly;
				this.toolStrip_1.Visible = false;
				this.canvasControl_0.Focus();
				return;
			}
			this.canvasControl_0.Mode = eCanvasEditingMode.Edit;
			this.toolStrip_1.Visible = true;
			this.canvasControl_0.Focus();
		}

		private void toolStripButton_5_Click(object sender, EventArgs e)
		{
			this.canvasControl_0.CommandDrawTool("Shina");
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			FormRectScheme2.GbBYR6ulpl2KuWID03k(this, disposing);
		}

		private void method_0()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormRectScheme2));
			this.canvasControl_0 = new CanvasControl();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_2 = new ToolStripButton();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_3 = new ToolStripButton();
			this.toolStripButton_4 = new ToolStripButton();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.toolStripLabel_0 = new ToolStripLabel();
			this.toolStripComboBox_0 = new ToolStripComboBox();
			this.toolStrip_1 = new ToolStrip();
			this.toolStripButton_5 = new ToolStripButton();
			this.toolStrip_0.SuspendLayout();
			this.toolStrip_1.SuspendLayout();
			base.SuspendLayout();
			this.canvasControl_0.ActiveLayer = null;
			this.canvasControl_0.AllowDrop = true;
			this.canvasControl_0.CurrentMetric = eMetric.sm;
			this.canvasControl_0.Cursor = Cursors.Arrow;
			this.canvasControl_0.DeltaPoint = (PointF)componentResourceManager.GetObject("canvasRect.DeltaPoint");
			this.canvasControl_0.Dock = DockStyle.Fill;
			this.canvasControl_0.Endpoint = null;
			this.canvasControl_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.canvasControl_0.Location = new Point(24, 25);
			this.canvasControl_0.Monopoly = true;
			this.canvasControl_0.Name = "canvasRect";
			this.canvasControl_0.Mode = eCanvasEditingMode.ReadOnly;
			this.canvasControl_0.SchemeName = "schema1";
			this.canvasControl_0.Size = new Size(719, 418);
			this.canvasControl_0.SqlSettings = null;
			this.canvasControl_0.StatusStripVisible = true;
			this.canvasControl_0.TabIndex = 0;
			this.canvasControl_0.TypeCanvas = eTypeCanvas.SchemeSecond;
			this.canvasControl_0.UseObjectFromDB = false;
			this.canvasControl_0.VisibleCanvasSchemeMap = false;
			this.canvasControl_0.VisibleSaveProgressBar = false;
			this.canvasControl_0.WorkerCounter = 0;
			this.canvasControl_0.Zoom = 1f;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_2,
				this.toolStripButton_0,
				this.toolStripSeparator_0,
				this.toolStripButton_1,
				this.toolStripButton_3,
				this.toolStripButton_4,
				this.toolStripSeparator_1,
				this.toolStripLabel_0,
				this.toolStripComboBox_0
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStripMain";
			this.toolStrip_0.Size = new Size(743, 25);
			this.toolStrip_0.TabIndex = 0;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources.smethod_11();
			this.toolStripButton_2.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_2.Name = "toolBtnPanCanvas";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Движение подложки";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.smethod_12();
			this.toolStripButton_0.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_0.Name = "toolBtnSelectCanvas";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Курсор";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripSeparator_0.Name = "toolStripSeparator1";
			this.toolStripSeparator_0.Size = new Size(6, 25);
			this.toolStripButton_1.Alignment = ToolStripItemAlignment.Right;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.toolStripButton_1.Image = (Image)componentResourceManager.GetObject("toolBtnLoadOldBase.Image");
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "toolBtnLoadOldBase";
			this.toolStripButton_1.Size = new Size(80, 22);
			this.toolStripButton_1.Text = "LoadOldBase";
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = (Image)componentResourceManager.GetObject("undoToolStripButton.Image");
			this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_3.Name = "undoToolStripButton";
			this.toolStripButton_3.Size = new Size(23, 22);
			this.toolStripButton_3.Text = "Отменить";
			this.toolStripButton_3.Click += this.toolStripButton_3_Click;
			this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_4.Image = (Image)componentResourceManager.GetObject("redoToolStripButton.Image");
			this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_4.Name = "redoToolStripButton";
			this.toolStripButton_4.Size = new Size(23, 22);
			this.toolStripButton_4.Text = "Вернуть";
			this.toolStripButton_4.Click += this.toolStripButton_4_Click;
			this.toolStripSeparator_1.Name = "toolStripSeparator3";
			this.toolStripSeparator_1.Size = new Size(6, 25);
			this.toolStripLabel_0.Name = "toolStripLabel1";
			this.toolStripLabel_0.Size = new Size(45, 22);
			this.toolStripLabel_0.Text = "Режим";
			this.toolStripComboBox_0.CausesValidation = false;
			this.toolStripComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.toolStripComboBox_0.FlatStyle = FlatStyle.Standard;
			this.toolStripComboBox_0.Items.AddRange(new object[]
			{
				"Просмотр",
				"Редактирование"
			});
			this.toolStripComboBox_0.Name = "toolStripComboBoxRezim";
			this.toolStripComboBox_0.Size = new Size(121, 25);
			this.toolStripComboBox_0.SelectedIndexChanged += this.toolStripComboBox_0_SelectedIndexChanged;
			this.toolStrip_1.Dock = DockStyle.Left;
			this.toolStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_5
			});
			this.toolStrip_1.Location = new Point(0, 25);
			this.toolStrip_1.Name = "toolStripTools";
			this.toolStrip_1.Size = new Size(24, 418);
			this.toolStrip_1.TabIndex = 2;
			this.toolStrip_1.Text = "toolStrip1";
			this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_5.Image = Resources.smethod_16();
			this.toolStripButton_5.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_5.Name = "toolBtnShina";
			this.toolStripButton_5.Size = new Size(21, 20);
			this.toolStripButton_5.Text = "Шина";
			this.toolStripButton_5.Click += this.toolStripButton_5_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(743, 443);
			base.Controls.Add(this.canvasControl_0);
			base.Controls.Add(this.toolStrip_1);
			base.Controls.Add(this.toolStrip_0);
			base.Name = "FormRectScheme2";
			this.Text = "FormRectScheme";
			base.Load += this.FormRectScheme2_Load;
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.toolStrip_1.ResumeLayout(false);
			this.toolStrip_1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		internal static void GbBYR6ulpl2KuWID03k(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private RectangleTool rectangleTool_0;

		private IContainer icontainer_0;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripButton toolStripButton_1;

		private CanvasControl canvasControl_0;

		private ToolStripButton toolStripButton_2;

		private ToolStrip toolStrip_1;

		private ToolStripButton toolStripButton_3;

		private ToolStripButton toolStripButton_4;

		private ToolStripSeparator toolStripSeparator_1;

		private ToolStripLabel toolStripLabel_0;

		private ToolStripComboBox toolStripComboBox_0;

		private ToolStripButton toolStripButton_5;
	}
}
