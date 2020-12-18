using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using FormLbr;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeModel.Calculations;

namespace Scheme.Forms.Reports
{
	public partial class FormPoweringReport : FormBase
	{
		public FormPoweringReport()
		{
			
			this.treeNodeObj_0 = new TreeNodeObj();
			
			this.method_5();
			this.canvasControl_0.TypeCanvas = eTypeCanvas.SchemeMain;
			this.canvasControl_0.SimulationMode = eSimulationMode.Online;
			this.class19_0 = new Class19();
		}

		public FormPoweringReport(SQLSettings sqlSettings)
		{
			
			this.treeNodeObj_0 = new TreeNodeObj();
			
			this.method_5();
			this.SqlSettings = sqlSettings;
			this.canvasControl_0.SqlSettings = this.SqlSettings;
			this.canvasControl_0.TypeCanvas = eTypeCanvas.SchemeMain;
			this.canvasControl_0.SimulationMode = eSimulationMode.Online;
			this.class19_0 = new Class19();
		}

		public override SQLSettings SqlSettings
		{
			get
			{
				return base.SqlSettings;
			}
			set
			{
				base.SqlSettings = value;
				this.canvasControl_0.SqlSettings = this.SqlSettings;
			}
		}

		private void method_0(bool bool_1)
		{
			this.panel_3.Enabled = true;
			this.panel_4.Enabled = true;
			this.panel_2.Left = base.ClientSize.Width / 2 - this.progressBarEndLess_0.Width / 2;
			this.panel_2.Top = base.ClientSize.Height / 2 - this.progressBarEndLess_0.Height / 2;
			this.panel_2.Visible = true;
			this.progressBarEndLess_0.AutoProgress = true;
			this.backgroundWorker_0.RunWorkerAsync(bool_1);
		}

		private List<int> method_1()
		{
			List<int> list = new List<int>();
			foreach (object obj in this.treeView_0.Nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				foreach (object obj2 in treeNode.Nodes)
				{
					TreeNode treeNode2 = (TreeNode)obj2;
					if (treeNode.Checked || treeNode2.Checked)
					{
						list.Add((int)treeNode2.Tag);
					}
				}
			}
			return list;
		}

		private void method_2()
		{
			if (!this.bool_0)
			{
				this.method_0(false);
				return;
			}
			if (this.radioButton_5.Checked)
			{
				this.canvasControl_0.SimulationMode = eSimulationMode.Online;
			}
			else if (this.radioButton_4.Checked)
			{
				this.canvasControl_0.SimulationMode = eSimulationMode.Normal;
			}
			this.treeNodeObj_0.Clear();
			List<int> tpIdList = this.method_1();
			IEnumerable<DrawObjectBase> objects = this.canvasControl_0.ActiveLayer.Objects;
			Func<DrawObjectBase, bool> <>9__0;
			Func<DrawObjectBase, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((DrawObjectBase obj) => obj.GetType() == typeof(RectangleTool) && tpIdList.Contains(obj.IdBase)));
			}
			foreach (DrawObjectBase obj2 in objects.Where(predicate))
			{
				try
				{
					this.treeNodeObj_0.AddNode(this.canvasControl_0.PoweringReportForDrawObject(obj2, this.radioButton_1.Checked));
				}
				catch
				{
				}
			}
			List<DataRow> list_ = null;
			this.method_3(list_, this.treeNodeObj_0, null);
			this.dataGridViewExcelFilter_0.DataSource = this.dataTable_0;
		}

		private void method_3(List<DataRow> list_0, TreeNodeObj treeNodeObj_1, DataRow dataRow_0)
		{
			if (list_0 == null && treeNodeObj_1.Level == 0)
			{
				list_0 = new List<DataRow>();
				this.dataTable_0 = new DataTable();
				if (this.radioButton_3.Checked)
				{
					int num = 0;
					foreach (TreeNodeObj treeNodeObj in treeNodeObj_1.LeafsList)
					{
						if (treeNodeObj.Level > num)
						{
							num = treeNodeObj.Level;
						}
					}
					for (int i = 1; i <= num; i++)
					{
						this.dataTable_0.Columns.Add(i.ToString(), typeof(string));
					}
				}
				else
				{
					this.dataTable_0.Columns.Add("tp1", typeof(string));
					this.dataTable_0.Columns.Add("tp2", typeof(string));
				}
				dataRow_0 = this.dataTable_0.NewRow();
			}
			if (treeNodeObj_1.Tag != null)
			{
				if (this.radioButton_3.Checked)
				{
					DataRow dataRow = this.dataTable_0.NewRow();
					object[] itemArray = dataRow_0.ItemArray;
					for (int j = 0; j < itemArray.Length; j++)
					{
						dataRow[j] = itemArray[j];
					}
					dataRow_0 = dataRow;
					string value = string.Empty;
					if (((DrawObjectBase)treeNodeObj_1.Tag).Parent != null)
					{
						value = ((DrawObjectBase)treeNodeObj_1.Tag).Parent.ToString() + ":" + ((DrawObjectBase)treeNodeObj_1.Tag).ToString();
					}
					else
					{
						value = ((DrawObjectBase)treeNodeObj_1.Tag).ToString();
					}
					dataRow_0[treeNodeObj_1.Level - 1] = value;
					if (treeNodeObj_1.Tag.GetType() != typeof(LineTool))
					{
						this.dataTable_0.Rows.Add(dataRow_0);
						list_0.Add(dataRow_0);
						dataRow = this.dataTable_0.NewRow();
						itemArray = dataRow_0.ItemArray;
						for (int k = 0; k < itemArray.Length; k++)
						{
							dataRow[k] = itemArray[k];
						}
						dataRow_0 = dataRow;
					}
				}
				else if (treeNodeObj_1.Tag.GetType() == typeof(LineCellTool))
				{
					if (((DrawObjectBase)treeNodeObj_1.Parent.Tag).GetType() == typeof(LineTool) && ((LineTool)treeNodeObj_1.Parent.Tag).ParRectangle() == null)
					{
						if (list_0.Contains(dataRow_0))
						{
							DataRow dataRow2 = this.dataTable_0.NewRow();
							dataRow2["tp1"] = dataRow_0["tp1"];
							dataRow_0 = dataRow2;
						}
						dataRow_0["tp2"] = ((DrawObjectBase)treeNodeObj_1.Tag).Parent.ToString() + ":" + ((DrawObjectBase)treeNodeObj_1.Tag).ToString();
						this.dataTable_0.Rows.Add(dataRow_0);
						list_0.Add(dataRow_0);
						dataRow_0 = this.dataTable_0.NewRow();
					}
					if (((DrawObjectBase)treeNodeObj_1.Parent.Tag).GetType() == typeof(ShinaTool))
					{
						bool flag = false;
						foreach (TreeNodeObj treeNodeObj2 in treeNodeObj_1.Nodes)
						{
							if (treeNodeObj2.Tag.GetType() == typeof(LineTool) && ((LineTool)treeNodeObj2.Tag).ParRectangle() == null)
							{
								flag = true;
								break;
							}
						}
						if (flag)
						{
							if (list_0.Contains(dataRow_0))
							{
								dataRow_0 = this.dataTable_0.NewRow();
							}
							dataRow_0["tp1"] = ((DrawObjectBase)treeNodeObj_1.Tag).Parent.ToString() + ":" + ((DrawObjectBase)treeNodeObj_1.Tag).ToString();
						}
					}
				}
			}
			if (!treeNodeObj_1.IsLeaf)
			{
				foreach (TreeNodeObj treeNodeObj_2 in treeNodeObj_1.Nodes)
				{
					this.method_3(list_0, treeNodeObj_2, dataRow_0);
				}
			}
		}

		private bool method_4(DataTable dataTable_1, DataRow dataRow_0)
		{
			using (IEnumerator enumerator = dataTable_1.Rows.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if ((DataRow)enumerator.Current == dataRow_0)
					{
						return true;
					}
				}
			}
			return false;
		}

		private void dataGridViewExcelFilter_0_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			this.method_2();
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			this.dataGridViewExcelFilter_0.CopyToExcel(true);
		}

		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			this.canvasControl_0.LoadScheme();
		}

		private void backgroundWorker_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
		}

		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.bool_0 = true;
			this.panel_3.Enabled = true;
			this.panel_4.Enabled = true;
			this.panel_2.Visible = false;
			this.progressBarEndLess_0.AutoProgress = false;
			this.method_2();
		}

		private void FormPoweringReport_Load(object sender, EventArgs e)
		{
			this.treeView_0.Nodes.Clear();
			foreach (object obj in Enum.GetValues(typeof(eTypeRectangleTool)))
			{
				eTypeRectangleTool eTypeRectangleTool = (eTypeRectangleTool)obj;
				string text = string.Empty;
				switch (eTypeRectangleTool)
				{
				case eTypeRectangleTool.PP:
					text = "ПП";
					break;
				case eTypeRectangleTool.CP:
					text = "ЦП";
					break;
				case eTypeRectangleTool.RP:
					text = "РП";
					break;
				case eTypeRectangleTool.TP:
					text = "ТП";
					break;
				default:
					if (eTypeRectangleTool != eTypeRectangleTool.SP)
					{
						if (eTypeRectangleTool == eTypeRectangleTool.PPNO)
						{
							text = "ППНО";
						}
					}
					else
					{
						text = "СП";
					}
					break;
				}
				TreeNode treeNode = new TreeNode(text);
				treeNode.Tag = eTypeRectangleTool;
				this.treeView_0.Nodes.Add(treeNode);
				base.SelectSqlData(this.class19_0, this.class19_0.vSchm_ObjList, true, "where TypeCodeId = " + (int)eTypeRectangleTool);
				foreach (object obj2 in this.class19_0.vSchm_ObjList.Rows)
				{
					DataRow dataRow = (DataRow)obj2;
					TreeNode treeNode2 = new TreeNode(dataRow["name"].ToString());
					treeNode2.Tag = dataRow["id"];
					treeNode.Nodes.Add(treeNode2);
				}
			}
		}

		private void method_5()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormPoweringReport));
			this.treeView_0 = new TreeView();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.panel_0 = new Panel();
			this.panel_5 = new Panel();
			this.radioButton_4 = new RadioButton();
			this.radioButton_5 = new RadioButton();
			this.panel_1 = new Panel();
			this.radioButton_2 = new RadioButton();
			this.radioButton_3 = new RadioButton();
			this.UiRruksdlZ = new Panel();
			this.radioButton_0 = new RadioButton();
			this.radioButton_1 = new RadioButton();
			this.button_1 = new Button();
			this.button_0 = new Button();
			this.panel_2 = new Panel();
			this.label_0 = new Label();
			this.progressBarEndLess_0 = new ProgressBarEndLess();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.panel_3 = new Panel();
			this.panel_4 = new Panel();
			this.canvasControl_0 = new CanvasControl();
			this.dataGridViewExcelFilter_0.BeginInit();
			this.panel_0.SuspendLayout();
			this.panel_5.SuspendLayout();
			this.panel_1.SuspendLayout();
			this.UiRruksdlZ.SuspendLayout();
			this.panel_2.SuspendLayout();
			this.panel_3.SuspendLayout();
			this.panel_4.SuspendLayout();
			base.SuspendLayout();
			this.treeView_0.CheckBoxes = true;
			this.treeView_0.Dock = DockStyle.Fill;
			this.treeView_0.Location = new Point(0, 0);
			this.treeView_0.Name = "treeViewRectNodes";
			this.treeView_0.Size = new Size(200, 390);
			this.treeView_0.TabIndex = 0;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_0.BackgroundColor = Color.White;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_0.Location = new Point(0, 59);
			this.dataGridViewExcelFilter_0.Name = "dGVEFReport";
			this.dataGridViewExcelFilter_0.Size = new Size(511, 331);
			this.dataGridViewExcelFilter_0.TabIndex = 1;
			this.dataGridViewExcelFilter_0.CellContentClick += this.dataGridViewExcelFilter_0_CellContentClick;
			this.panel_0.Controls.Add(this.panel_5);
			this.panel_0.Controls.Add(this.panel_1);
			this.panel_0.Controls.Add(this.UiRruksdlZ);
			this.panel_0.Controls.Add(this.button_1);
			this.panel_0.Controls.Add(this.button_0);
			this.panel_0.Dock = DockStyle.Top;
			this.panel_0.Location = new Point(0, 0);
			this.panel_0.Name = "panelControls";
			this.panel_0.Size = new Size(511, 59);
			this.panel_0.TabIndex = 0;
			this.panel_5.Controls.Add(this.radioButton_4);
			this.panel_5.Controls.Add(this.radioButton_5);
			this.panel_5.Dock = DockStyle.Left;
			this.panel_5.Location = new Point(266, 0);
			this.panel_5.Name = "panel1";
			this.panel_5.Size = new Size(133, 59);
			this.panel_5.TabIndex = 5;
			this.radioButton_4.AutoSize = true;
			this.radioButton_4.Location = new Point(6, 35);
			this.radioButton_4.Name = "rBNormalSchema";
			this.radioButton_4.Size = new Size(123, 17);
			this.radioButton_4.TabIndex = 0;
			this.radioButton_4.Text = "Нормальная схема";
			this.radioButton_4.UseVisualStyleBackColor = true;
			this.radioButton_5.AutoSize = true;
			this.radioButton_5.Checked = true;
			this.radioButton_5.Location = new Point(6, 6);
			this.radioButton_5.Name = "rBOnlineSchema";
			this.radioButton_5.Size = new Size(126, 17);
			this.radioButton_5.TabIndex = 0;
			this.radioButton_5.TabStop = true;
			this.radioButton_5.Text = "Оперативная схема";
			this.radioButton_5.UseVisualStyleBackColor = true;
			this.panel_1.Controls.Add(this.radioButton_2);
			this.panel_1.Controls.Add(this.radioButton_3);
			this.panel_1.Dock = DockStyle.Left;
			this.panel_1.Location = new Point(133, 0);
			this.panel_1.Name = "panel3";
			this.panel_1.Size = new Size(133, 59);
			this.panel_1.TabIndex = 3;
			this.radioButton_2.AutoSize = true;
			this.radioButton_2.Location = new Point(6, 35);
			this.radioButton_2.Name = "rBSimplification";
			this.radioButton_2.Size = new Size(122, 17);
			this.radioButton_2.TabIndex = 0;
			this.radioButton_2.Text = "Упрощенный отчёт";
			this.radioButton_2.UseVisualStyleBackColor = true;
			this.radioButton_3.AutoSize = true;
			this.radioButton_3.Checked = true;
			this.radioButton_3.Location = new Point(6, 6);
			this.radioButton_3.Name = "rBFullTree";
			this.radioButton_3.Size = new Size(102, 17);
			this.radioButton_3.TabIndex = 0;
			this.radioButton_3.TabStop = true;
			this.radioButton_3.Text = "Полное дерево";
			this.radioButton_3.UseVisualStyleBackColor = true;
			this.UiRruksdlZ.Controls.Add(this.radioButton_0);
			this.UiRruksdlZ.Controls.Add(this.radioButton_1);
			this.UiRruksdlZ.Dock = DockStyle.Left;
			this.UiRruksdlZ.Location = new Point(0, 0);
			this.UiRruksdlZ.Name = "panel2";
			this.UiRruksdlZ.Size = new Size(133, 59);
			this.UiRruksdlZ.TabIndex = 2;
			this.radioButton_0.AutoSize = true;
			this.radioButton_0.Location = new Point(6, 35);
			this.radioButton_0.Name = "rBReverseDirection";
			this.radioButton_0.Size = new Size(59, 17);
			this.radioButton_0.TabIndex = 0;
			this.radioButton_0.Text = "ТП-ЦП";
			this.radioButton_0.UseVisualStyleBackColor = true;
			this.radioButton_1.AutoSize = true;
			this.radioButton_1.Checked = true;
			this.radioButton_1.Location = new Point(6, 6);
			this.radioButton_1.Name = "rBForwardDirection";
			this.radioButton_1.Size = new Size(59, 17);
			this.radioButton_1.TabIndex = 0;
			this.radioButton_1.TabStop = true;
			this.radioButton_1.Text = "ЦП-ТП";
			this.radioButton_1.UseVisualStyleBackColor = true;
			this.button_1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.button_1.Location = new Point(398, 29);
			this.button_1.Name = "button1";
			this.button_1.Size = new Size(113, 29);
			this.button_1.TabIndex = 4;
			this.button_1.Text = "Копировать в Excel";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.button_0.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.button_0.Location = new Point(398, 0);
			this.button_0.Name = "buttonRun";
			this.button_0.Size = new Size(113, 29);
			this.button_0.TabIndex = 4;
			this.button_0.Text = "Сформировать";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.panel_2.BackColor = SystemColors.Control;
			this.panel_2.Controls.Add(this.label_0);
			this.panel_2.Controls.Add(this.progressBarEndLess_0);
			this.panel_2.Location = new Point(147, 157);
			this.panel_2.Name = "panelProgress";
			this.panel_2.Size = new Size(431, 74);
			this.panel_2.TabIndex = 6;
			this.panel_2.Visible = false;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(111, 12);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(230, 13);
			this.label_0.TabIndex = 6;
			this.label_0.Text = "Подождите... Идет загрузка схемы из базы";
			this.progressBarEndLess_0.AutoProgressSpeed = 130;
			this.progressBarEndLess_0.Dock = DockStyle.Bottom;
			this.progressBarEndLess_0.Location = new Point(0, 39);
			this.progressBarEndLess_0.Name = "progressBarEndLess";
			this.progressBarEndLess_0.NormalImage = (Image)componentResourceManager.GetObject("progressBarEndLess.NormalImage");
			this.progressBarEndLess_0.PointImage = (Image)componentResourceManager.GetObject("progressBarEndLess.PointImage");
			this.progressBarEndLess_0.Position = 0;
			this.progressBarEndLess_0.ProgressStyle = 1;
			this.progressBarEndLess_0.ProgressType = 1;
			this.progressBarEndLess_0.Size = new Size(431, 35);
			this.progressBarEndLess_0.TabIndex = 5;
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.ProgressChanged += this.backgroundWorker_0_ProgressChanged;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
			this.panel_3.Controls.Add(this.treeView_0);
			this.panel_3.Dock = DockStyle.Left;
			this.panel_3.Location = new Point(0, 0);
			this.panel_3.Name = "panelTreeObj";
			this.panel_3.Size = new Size(200, 390);
			this.panel_3.TabIndex = 2;
			this.panel_4.Controls.Add(this.dataGridViewExcelFilter_0);
			this.panel_4.Controls.Add(this.panel_0);
			this.panel_4.Dock = DockStyle.Fill;
			this.panel_4.Location = new Point(200, 0);
			this.panel_4.Name = "panelGeneral";
			this.panel_4.Size = new Size(511, 390);
			this.panel_4.TabIndex = 0;
			this.canvasControl_0.ActiveLayer = null;
			this.canvasControl_0.AllowDrop = true;
			this.canvasControl_0.Connected = false;
			this.canvasControl_0.CurrentMetric = eMetric.sm;
			this.canvasControl_0.Cursor = Cursors.Arrow;
			this.canvasControl_0.DeltaPoint = (PointF)componentResourceManager.GetObject("canvasControl1.DeltaPoint");
			this.canvasControl_0.Endpoint = null;
			this.canvasControl_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.canvasControl_0.Graphics = null;
			this.canvasControl_0.IdRect = 0;
			this.canvasControl_0.LineInformationVisible = false;
			this.canvasControl_0.Location = new Point(0, 0);
			this.canvasControl_0.MaxMode = eCanvasEditingMode.Edit;
			this.canvasControl_0.Mode = eCanvasEditingMode.ReadOnly;
			this.canvasControl_0.Monopoly = true;
			this.canvasControl_0.Name = "canvasControl1";
			this.canvasControl_0.SchemeName = "schema1";
			this.canvasControl_0.SimulationMode = eSimulationMode.Online;
			this.canvasControl_0.Size = new Size(514, 309);
			this.canvasControl_0.SqlSettings = null;
			this.canvasControl_0.StatusStripVisible = true;
			this.canvasControl_0.TabIndex = 1;
			this.canvasControl_0.TypeCanvas = eTypeCanvas.SchemeMain;
			this.canvasControl_0.UseObjectFromDB = false;
			this.canvasControl_0.Visible = false;
			this.canvasControl_0.VisibleCanvasSchemeMap = false;
			this.canvasControl_0.VisibleSaveProgressBar = false;
			this.canvasControl_0.WorkerCounter = 0;
			this.canvasControl_0.WorkerPrint = null;
			this.canvasControl_0.Zoom = 1f;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(711, 390);
			base.Controls.Add(this.panel_2);
			base.Controls.Add(this.panel_4);
			base.Controls.Add(this.panel_3);
			base.Controls.Add(this.canvasControl_0);
			this.MinimumSize = new Size(727, 428);
			base.Name = "FormPoweringReport";
			this.Text = "Отчёт по запитке";
			base.Load += this.FormPoweringReport_Load;
			this.dataGridViewExcelFilter_0.EndInit();
			this.panel_0.ResumeLayout(false);
			this.panel_5.ResumeLayout(false);
			this.panel_5.PerformLayout();
			this.panel_1.ResumeLayout(false);
			this.panel_1.PerformLayout();
			this.UiRruksdlZ.ResumeLayout(false);
			this.UiRruksdlZ.PerformLayout();
			this.panel_2.ResumeLayout(false);
			this.panel_2.PerformLayout();
			this.panel_3.ResumeLayout(false);
			this.panel_4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private bool bool_0;

		private TreeNodeObj treeNodeObj_0;

		private Class19 class19_0;

		private DataTable dataTable_0;

		private TreeView treeView_0;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private Panel panel_0;

		private Button button_0;

		private Panel panel_1;

		private Panel UiRruksdlZ;

		private RadioButton radioButton_0;

		private RadioButton radioButton_1;

		private CanvasControl canvasControl_0;

		private Panel panel_2;

		private Label label_0;

		private ProgressBarEndLess progressBarEndLess_0;

		private BackgroundWorker backgroundWorker_0;

		private RadioButton radioButton_2;

		private RadioButton radioButton_3;

		private Button button_1;

		private Panel panel_3;

		private Panel panel_4;

		private Panel panel_5;

		private RadioButton radioButton_4;

		private RadioButton radioButton_5;
	}
}
