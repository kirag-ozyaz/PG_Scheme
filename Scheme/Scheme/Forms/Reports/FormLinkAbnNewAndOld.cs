using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using Scheme.Properties;
using SchemeModel;
using SchemeModel.Calculations;

namespace Scheme.Forms.Reports
{
	public partial class FormLinkAbnNewAndOld : FormBase
	{
		public FormLinkAbnNewAndOld()
		{
			
			this.bool_0 = true;
			this.bool_1 = true;
			
			this.dataTable_0 = new DataTable("vL_SchmAbnFull");
			this.method_4();
			this.dateTimePicker_0 = new DateTimePicker();
			this.dateTimePicker_0.Width = 120;
			this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
			this.dateTimePicker_0.CustomFormat = "MMMM yyyy";
			this.dateTimePicker_0.Value = DateTime.Now.AddMonths(-1);
			this.dateTimePicker_0.ValueChanged += this.dateTimePicker_0_ValueChanged;
			int num = 0;
			using (IEnumerator enumerator = this.toolStrip_0.Items.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if ((ToolStripItem)enumerator.Current == this.toolStripLabel_1)
					{
						break;
					}
					num++;
				}
			}
			this.toolStrip_0.Items.Insert(num + 1, new ToolStripControlHost(this.dateTimePicker_0));
			this.bindingSource_0.DataSource = this.dataTable_0;
		}

		private void FormLinkAbnNewAndOld_Load(object sender, EventArgs e)
		{
			this.toolStripComboBox_0.SelectedIndex = 1;
			this.method_0();
			this.method_1();
			this.toolStripComboBox_0.SelectedIndexChanged += this.toolStripComboBox_0_SelectedIndexChanged;
		}

		private void method_0()
		{
			this.panel_0.Visible = true;
			this.progressBarEndLess_0.AutoProgress = true;
			this.panel_0.Left = base.Width / 2 - this.panel_0.Width / 2;
			this.panel_0.Top = base.Height / 2 - this.panel_0.Height / 2;
			this.splitContainer_0.Enabled = false;
			this.toolStrip_0.Enabled = false;
			this.dataGridViewExcelFilter_0.DataSource = null;
			this.dataGridViewExcelFilter_1.DataSource = null;
			this.bool_0 = false;
			this.backgroundWorker_0.RunWorkerAsync();
		}

		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
			{
				try
				{
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Class7.smethod_2("Forms.Reports.ReportLinkAbnNewAndOld.sql"), sqlConnection);
					sqlDataAdapter.SelectCommand.CommandTimeout = 0;
					this.dataTable_0.Clear();
					sqlDataAdapter.Fill(this.dataTable_0);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
				}
			}
		}

		private void FormLinkAbnNewAndOld_Resize(object sender, EventArgs e)
		{
			this.panel_0.Left = base.Width / 2 - this.progressBarEndLess_0.Width / 2;
			this.panel_0.Top = base.Height / 2 - this.progressBarEndLess_0.Height / 2;
		}

		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.bool_0 = true;
			if (this.bool_1 && this.bool_0)
			{
				this.method_3();
			}
		}

		private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
		{
			if (this.bindingSource_0.Current != null)
			{
				int num = Convert.ToInt32(((DataRowView)this.bindingSource_0.Current).Row["idAbn"]);
				base.SelectSqlData(this.class19_0, this.class19_0.tAbnContact, true, "where [idAbn] = " + num);
				return;
			}
			this.class19_0.tAbnContact.Clear();
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			this.method_0();
			this.method_1();
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			if (this.tabControl_0.SelectedTab == this.tabPage_1)
			{
				this.dataGridViewExcelFilter_2.ExportToExcel();
			}
			if (this.tabControl_0.SelectedTab == this.tabPage_0)
			{
				this.dataGridViewExcelFilter_0.CopyToExcel(true);
			}
		}

		private void toolStripComboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void dateTimePicker_0_ValueChanged(object sender, EventArgs e)
		{
		}

		private void method_1()
		{
			this.panel_0.Visible = true;
			this.progressBarEndLess_0.AutoProgress = true;
			this.panel_0.Left = base.Width / 2 - this.panel_0.Width / 2;
			this.panel_0.Top = base.Height / 2 - this.panel_0.Height / 2;
			this.splitContainer_0.Enabled = false;
			this.toolStrip_0.Enabled = false;
			this.dataGridViewExcelFilter_2.DataSource = null;
			this.bool_1 = false;
			bool flag = true;
			if (this.toolStripComboBox_0.SelectedIndex == 0)
			{
				flag = false;
			}
			this.backgroundWorker_1.RunWorkerAsync(new FormLinkAbnNewAndOld.Class5(flag, this.dateTimePicker_0.Value));
		}

		private void backgroundWorker_1_DoWork(object sender, DoWorkEventArgs e)
		{
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand(Class7.smethod_2("Forms.Reports.ReportLinkAbnWithCP.sql"), sqlConnection);
					sqlCommand.Parameters.Add("dt", SqlDbType.DateTime).Value = ((FormLinkAbnNewAndOld.Class5)e.Argument).dateTime_0;
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					sqlDataAdapter.SelectCommand.CommandTimeout = 0;
					this.dataTable_1.Clear();
					sqlDataAdapter.Fill(this.dataTable_1);
					ElectricModel electricModel = new ElectricModel();
					electricModel.SqlSettings = this.SqlSettings;
					electricModel.LoadSchema(((FormLinkAbnNewAndOld.Class5)e.Argument).bool_0);
					Thread thread = new Thread(new ParameterizedThreadStart(this.method_2));
					thread.Start(new FormLinkAbnNewAndOld.Class6(0, this.dataTable_1.Rows.Count / 2, electricModel));
					Thread thread2 = new Thread(new ParameterizedThreadStart(this.method_2));
					thread2.Start(new FormLinkAbnNewAndOld.Class6(this.dataTable_1.Rows.Count / 2 + 1, this.dataTable_1.Rows.Count, electricModel));
					thread.Join();
					thread2.Join();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
				}
			}
		}

		private void backgroundWorker_1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.bool_1 = true;
			if (this.bool_1 && this.bool_0)
			{
				this.method_3();
			}
		}

		private void method_2(object object_0)
		{
			FormLinkAbnNewAndOld.Class6 @class = (FormLinkAbnNewAndOld.Class6)object_0;
			for (int i = @class.int_0; i < @class.int_1; i++)
			{
				DataRow dataRow = this.dataTable_1.Rows[i];
				if (dataRow["idSchmObj"] != DBNull.Value)
				{
					ElectricObject electricObjectById = @class.electricModel_0.GetElectricObjectById(Convert.ToInt32(dataRow["idSchmObj"]));
					if (electricObjectById != null && (!(electricObjectById is ElectricBus) || ((ElectricBus)electricObjectById).Amperage != null) && (!(electricObjectById is ElectricLine) || ((ElectricLine)electricObjectById).AmperageCount != 0))
					{
						TreeNodeObj treeNodeObj = @class.electricModel_0.PoweringReportForDrawObject(Convert.ToInt32(dataRow["idSchmObj"]), false);
						if (treeNodeObj != null)
						{
							string value = "";
							string value2 = "";
							string value3 = "";
							string value4 = "";
							string value5 = "";
							string value6 = "";
							int num = 1;
							foreach (TreeNodeObj treeNodeObj2 in treeNodeObj.LeafsList)
							{
								if (treeNodeObj2.Tag != null && treeNodeObj2.Tag is ElectricObject)
								{
									if (treeNodeObj2.Parent != null && treeNodeObj2.Parent.Tag != null && treeNodeObj2.Parent.Tag is ElectricObject)
									{
										value5 = ((ElectricObject)treeNodeObj2.Parent.Tag).ToString();
										value6 = ((ElectricObject)treeNodeObj2.Parent.Tag).Id.ToString();
									}
									value = ((ElectricObject)treeNodeObj2.Tag).ToString();
									value2 = ((ElectricObject)treeNodeObj2.Tag).Id.ToString();
									if (((ElectricObject)treeNodeObj2.Tag).Parent != null)
									{
										value3 = ((ElectricObject)treeNodeObj2.Tag).Parent.ToString();
										value4 = ((ElectricObject)treeNodeObj2.Tag).Parent.Id.ToString();
									}
								}
								DataTable obj = this.dataTable_1;
								lock (obj)
								{
									if (num == 1)
									{
										dataRow["busCPName"] = value;
										dataRow["busCPId"] = value2;
										dataRow["subCPName"] = value3;
										dataRow["subCpId"] = value4;
										dataRow["cellCPName"] = value5;
										dataRow["cellCpId"] = value6;
									}
									else
									{
										DataRow dataRow2 = this.dataTable_1.NewRow();
										dataRow2.ItemArray = (dataRow.ItemArray.Clone() as object[]);
										dataRow2["busCPName"] = value;
										dataRow2["busCPId"] = value2;
										dataRow2["subCPName"] = value3;
										dataRow2["subCpId"] = value4;
										dataRow2["cellCPName"] = value5;
										dataRow2["cellCpId"] = value6;
										this.dataTable_1.Rows.Add(dataRow2);
									}
								}
								num++;
							}
						}
					}
				}
			}
		}

		private void method_3()
		{
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
			this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
			this.splitContainer_0.Enabled = true;
			this.toolStrip_0.Enabled = true;
			this.panel_0.Visible = false;
			this.progressBarEndLess_0.AutoProgress = false;
		}

		private void dataGridViewExcelFilter_2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			this.dataGridViewExcelFilter_2.AutoResizeRow(e.RowIndex);
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			this.method_1();
		}

		private void method_4()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormLinkAbnNewAndOld));
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.treeDataGridView_1 = new TreeDataGridView();
			this.treeGridColumn_3 = new TreeGridColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.treeDataGridView_0 = new TreeDataGridView();
			this.treeGridColumn_0 = new TreeGridColumn();
			this.treeGridColumn_1 = new TreeGridColumn();
			this.treeGridColumn_2 = new TreeGridColumn();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.panel_0 = new Panel();
			this.label_0 = new Label();
			this.progressBarEndLess_0 = new ProgressBarEndLess();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripLabel_0 = new ToolStripLabel();
			this.toolStripComboBox_0 = new ToolStripComboBox();
			this.toolStripLabel_1 = new ToolStripLabel();
			this.toolStripButton_2 = new ToolStripButton();
			this.splitContainer_0 = new SplitContainer();
			this.dataGridViewExcelFilter_1 = new DataGridViewExcelFilter();
			this.tabControl_0 = new TabControl();
			this.tabPage_1 = new TabPage();
			this.dataGridViewExcelFilter_2 = new DataGridViewExcelFilter();
			this.bindingSource_2 = new BindingSource(this.icontainer_0);
			this.dataSet_0 = new DataSet();
			this.dataTable_1 = new DataTable();
			this.dataColumn_0 = new DataColumn();
			this.dataColumn_1 = new DataColumn();
			this.dataColumn_2 = new DataColumn();
			this.dataColumn_3 = new DataColumn();
			this.dataColumn_4 = new DataColumn();
			this.dataColumn_5 = new DataColumn();
			this.dataColumn_6 = new DataColumn();
			this.dataColumn_7 = new DataColumn();
			this.dataColumn_8 = new DataColumn();
			this.dataColumn_9 = new DataColumn();
			this.dataColumn_10 = new DataColumn();
			this.dataColumn_11 = new DataColumn();
			this.dataColumn_12 = new DataColumn();
			this.dataColumn_13 = new DataColumn();
			this.dataColumn_14 = new DataColumn();
			this.dataColumn_15 = new DataColumn();
			this.dataColumn_16 = new DataColumn();
			this.dataColumn_17 = new DataColumn();
			this.dataColumn_18 = new DataColumn();
			this.dataColumn_19 = new DataColumn();
			this.dataColumn_20 = new DataColumn();
			this.dataColumn_21 = new DataColumn();
			this.dataColumn_22 = new DataColumn();
			this.dataColumn_23 = new DataColumn();
			this.dataColumn_24 = new DataColumn();
			this.dataColumn_25 = new DataColumn();
			this.dataColumn_26 = new DataColumn();
			this.dataColumn_27 = new DataColumn();
			this.dataColumn_28 = new DataColumn();
			this.dataColumn_29 = new DataColumn();
			this.dataColumn_30 = new DataColumn();
			this.dataColumn_31 = new DataColumn();
			this.dataColumn_32 = new DataColumn();
			this.dataColumn_33 = new DataColumn();
			this.dataColumn_34 = new DataColumn();
			this.dataColumn_35 = new DataColumn();
			this.dataColumn_36 = new DataColumn();
			this.dataColumn_37 = new DataColumn();
			this.dataColumn_38 = new DataColumn();
			this.tabPage_0 = new TabPage();
			this.backgroundWorker_1 = new BackgroundWorker();
			this.dataColumn_39 = new DataColumn();
			this.dataColumn_40 = new DataColumn();
			this.dataColumn_41 = new DataColumn();
			this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.class19_0 = new Class19();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_17 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_18 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_19 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_20 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_21 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_22 = new DataGridViewFilterTextBoxColumn();
			this.YdxAmuqGc0 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_23 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_24 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_25 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_26 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_27 = new DataGridViewFilterTextBoxColumn();
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
			this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
			((ISupportInitialize)this.treeDataGridView_1).BeginInit();
			((ISupportInitialize)this.treeDataGridView_0).BeginInit();
			this.panel_0.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_0).BeginInit();
			this.toolStrip_0.SuspendLayout();
			this.splitContainer_0.Panel1.SuspendLayout();
			this.splitContainer_0.Panel2.SuspendLayout();
			this.splitContainer_0.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_1).BeginInit();
			this.tabControl_0.SuspendLayout();
			this.tabPage_1.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_2).BeginInit();
			((ISupportInitialize)this.bindingSource_2).BeginInit();
			((ISupportInitialize)this.dataSet_0).BeginInit();
			((ISupportInitialize)this.dataTable_1).BeginInit();
			this.tabPage_0.SuspendLayout();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.class19_0).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			base.SuspendLayout();
			this.treeDataGridView_1.AllowUserToAddRows = false;
			this.treeDataGridView_1.AllowUserToDeleteRows = false;
			this.treeDataGridView_1.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.treeDataGridView_1.ImageList = null;
			this.treeDataGridView_1.Location = new Point(0, 0);
			this.treeDataGridView_1.Name = "treeDataGridView2";
			this.treeDataGridView_1.Size = new Size(240, 150);
			this.treeDataGridView_1.TabIndex = 0;
			this.treeGridColumn_3.DefaultNodeImage = null;
			this.treeGridColumn_3.Name = "treeGridColumn1";
			this.dataGridViewTextBoxColumn_1.HeaderText = "Column2";
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_1.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_2.HeaderText = "Column3";
			this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_2.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_3.HeaderText = "Column4";
			this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_3.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.treeDataGridView_0.AllowUserToAddRows = false;
			this.treeDataGridView_0.AllowUserToDeleteRows = false;
			this.treeDataGridView_0.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.treeDataGridView_0.ImageList = null;
			this.treeDataGridView_0.Location = new Point(0, 0);
			this.treeDataGridView_0.Name = "treeDataGridView1";
			this.treeDataGridView_0.Size = new Size(240, 150);
			this.treeDataGridView_0.TabIndex = 0;
			this.treeGridColumn_0.DefaultNodeImage = null;
			this.treeGridColumn_0.HeaderText = "Column1";
			this.treeGridColumn_0.Name = "Column1";
			this.treeGridColumn_0.Resizable = DataGridViewTriState.True;
			this.treeGridColumn_0.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.treeGridColumn_1.DefaultNodeImage = null;
			this.treeGridColumn_1.HeaderText = "Column2";
			this.treeGridColumn_1.Name = "Column2";
			this.treeGridColumn_1.Resizable = DataGridViewTriState.True;
			this.treeGridColumn_1.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.treeGridColumn_2.DefaultNodeImage = null;
			this.treeGridColumn_2.HeaderText = "Column3";
			this.treeGridColumn_2.Name = "Column3";
			this.treeGridColumn_2.Resizable = DataGridViewTriState.True;
			this.treeGridColumn_2.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_0.HeaderText = "Column4";
			this.dataGridViewTextBoxColumn_0.Name = "Column4";
			this.dataGridViewTextBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_0.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
			this.panel_0.BackColor = SystemColors.Control;
			this.panel_0.Controls.Add(this.label_0);
			this.panel_0.Controls.Add(this.progressBarEndLess_0);
			this.panel_0.Location = new Point(272, 209);
			this.panel_0.Name = "panelProgress";
			this.panel_0.Size = new Size(431, 74);
			this.panel_0.TabIndex = 7;
			this.panel_0.Visible = false;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(111, 12);
			this.label_0.Name = "label3";
			this.label_0.Size = new Size(194, 13);
			this.label_0.TabIndex = 6;
			this.label_0.Text = "Подождите... Идет загрузка из базы";
			this.progressBarEndLess_0.AutoProgressSpeed = 130;
			this.progressBarEndLess_0.Dock = DockStyle.Bottom;
			this.progressBarEndLess_0.Location = new Point(0, 39);
			this.progressBarEndLess_0.Name = "progressBarEndLess";
			this.progressBarEndLess_0.NormalImage = (Image)componentResourceManager.GetObject("progressBarEndLess.NormalImage");
			this.progressBarEndLess_0.PointImage = (Image)componentResourceManager.GetObject("progressBarEndLess.PointImage");
			this.progressBarEndLess_0.Position = 0;
			this.progressBarEndLess_0.ProgressStyle = ProgressBarEndLess.ProgressBarEndLessStyleConstants.LeftAndRight;
			this.progressBarEndLess_0.ProgressType = ProgressBarEndLess.ProgressBarEndLessTypeConstants.GraphicType;
			this.progressBarEndLess_0.Size = new Size(431, 35);
			this.progressBarEndLess_0.TabIndex = 5;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewFilterTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_14,
				this.dataGridViewFilterTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_15,
				this.dataGridViewFilterTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_16,
				this.dataGridViewFilterTextBoxColumn_3,
				this.dataGridViewFilterTextBoxColumn_4,
				this.dataGridViewFilterTextBoxColumn_5,
				this.dataGridViewFilterTextBoxColumn_6,
				this.dataGridViewFilterTextBoxColumn_7,
				this.dataGridViewFilterTextBoxColumn_8,
				this.dataGridViewFilterTextBoxColumn_9,
				this.dataGridViewTextBoxColumn_17,
				this.dataGridViewTextBoxColumn_18,
				this.dataGridViewTextBoxColumn_19,
				this.dataGridViewTextBoxColumn_20,
				this.dataGridViewTextBoxColumn_21
			});
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_0.Name = "dgvListLegal";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			this.dataGridViewExcelFilter_0.Size = new Size(961, 216);
			this.dataGridViewExcelFilter_0.TabIndex = 8;
			this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "GosTP";
			this.dataGridViewFilterTextBoxColumn_8.HeaderText = "ПС (Госсектор)";
			this.dataGridViewFilterTextBoxColumn_8.Name = "TPConnectDgvColumn";
			this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "razrTP";
			this.dataGridViewFilterTextBoxColumn_9.HeaderText = "ТП (Разреш)";
			this.dataGridViewFilterTextBoxColumn_9.Name = "tPrazrDgvColumn";
			this.dataGridViewFilterTextBoxColumn_9.ReadOnly = true;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripSeparator_0,
				this.toolStripLabel_0,
				this.toolStripComboBox_0,
				this.toolStripLabel_1,
				this.toolStripButton_2
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStrip";
			this.toolStrip_0.Size = new Size(975, 25);
			this.toolStrip_0.TabIndex = 9;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.smethod_51();
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "toolBtnRefresh";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Обновить";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.smethod_40();
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "toolBtnExportExcel";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "toolStripButton1";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStripSeparator_0.Name = "toolStripSeparator1";
			this.toolStripSeparator_0.Size = new Size(6, 25);
			this.toolStripLabel_0.Name = "toolLabelTypeSchema";
			this.toolStripLabel_0.Size = new Size(41, 22);
			this.toolStripLabel_0.Text = "Схема";
			this.toolStripComboBox_0.Items.AddRange(new object[]
			{
				"Оперативная схема",
				"По точкам токоразделов"
			});
			this.toolStripComboBox_0.Name = "toolCmbTypeSchema";
			this.toolStripComboBox_0.Size = new Size(121, 25);
			this.toolStripLabel_1.Name = "toolLabelPeriodKWT";
			this.toolStripLabel_1.Size = new Size(119, 22);
			this.toolStripLabel_1.Text = "Период начислений";
			this.toolStripButton_2.Image = Resources.Play;
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "toolBtnLoad";
			this.toolStripButton_2.Size = new Size(111, 22);
			this.toolStripButton_2.Text = "Сформировать";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.splitContainer_0.Dock = DockStyle.Fill;
			this.splitContainer_0.Location = new Point(3, 3);
			this.splitContainer_0.Name = "splitContainer1";
			this.splitContainer_0.Orientation = Orientation.Horizontal;
			this.splitContainer_0.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
			this.splitContainer_0.Panel2.Controls.Add(this.dataGridViewExcelFilter_1);
			this.splitContainer_0.Size = new Size(961, 436);
			this.splitContainer_0.SplitterDistance = 216;
			this.splitContainer_0.TabIndex = 10;
			this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_1.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_1.BackgroundColor = Color.White;
			this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_9,
				this.dataGridViewTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_11,
				this.dataGridViewTextBoxColumn_12,
				this.dataGridViewTextBoxColumn_13
			});
			this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
			this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_1.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_1.MultiSelect = false;
			this.dataGridViewExcelFilter_1.Name = "dgvListLegalContact";
			this.dataGridViewExcelFilter_1.ReadOnly = true;
			this.dataGridViewExcelFilter_1.RowHeadersWidth = 21;
			this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_1.Size = new Size(961, 216);
			this.dataGridViewExcelFilter_1.TabIndex = 5;
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Dock = DockStyle.Fill;
			this.tabControl_0.Location = new Point(0, 25);
			this.tabControl_0.Name = "tabControl1";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(975, 468);
			this.tabControl_0.TabIndex = 11;
			this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_2);
			this.tabPage_1.Location = new Point(4, 22);
			this.tabPage_1.Name = "tabPageAbnWithCP";
			this.tabPage_1.Size = new Size(967, 442);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "Привязка к питающим центрам";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.dataGridViewExcelFilter_2.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_2.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_2.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_2.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewFilterTextBoxColumn_10,
				this.dataGridViewFilterTextBoxColumn_11,
				this.dataGridViewFilterTextBoxColumn_12,
				this.dataGridViewFilterTextBoxColumn_13,
				this.dataGridViewFilterTextBoxColumn_14,
				this.dataGridViewFilterTextBoxColumn_15,
				this.dataGridViewFilterTextBoxColumn_16,
				this.dataGridViewFilterTextBoxColumn_17,
				this.dataGridViewTextBoxColumn_22,
				this.dataGridViewTextBoxColumn_23,
				this.dataGridViewFilterTextBoxColumn_18,
				this.dataGridViewTextBoxColumn_24,
				this.dataGridViewFilterTextBoxColumn_19,
				this.dataGridViewFilterTextBoxColumn_20,
				this.dataGridViewFilterTextBoxColumn_21,
				this.dataGridViewTextBoxColumn_25,
				this.dataGridViewTextBoxColumn_26,
				this.dataGridViewFilterTextBoxColumn_22,
				this.YdxAmuqGc0,
				this.dataGridViewFilterTextBoxColumn_23,
				this.dataGridViewTextBoxColumn_27,
				this.dataGridViewFilterTextBoxColumn_24,
				this.dataGridViewTextBoxColumn_28,
				this.dataGridViewTextBoxColumn_29,
				this.dataGridViewTextBoxColumn_30,
				this.dataGridViewTextBoxColumn_31,
				this.dataGridViewFilterTextBoxColumn_25,
				this.dataGridViewTextBoxColumn_32,
				this.dataGridViewFilterTextBoxColumn_26,
				this.dataGridViewFilterTextBoxColumn_27,
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
				this.dataGridViewTextBoxColumn_43,
				this.dataGridViewTextBoxColumn_44
			});
			this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
			this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_2.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_2.Name = "dgvReportCP";
			this.dataGridViewExcelFilter_2.ReadOnly = true;
			this.dataGridViewExcelFilter_2.Size = new Size(967, 442);
			this.dataGridViewExcelFilter_2.TabIndex = 0;
			this.dataGridViewExcelFilter_2.RowPostPaint += this.dataGridViewExcelFilter_2_RowPostPaint;
			this.bindingSource_2.DataMember = "dtReportCP";
			this.bindingSource_2.DataSource = this.dataSet_0;
			this.dataSet_0.DataSetName = "NewDataSet";
			this.dataSet_0.Tables.AddRange(new DataTable[]
			{
				this.dataTable_1
			});
			this.dataTable_1.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1,
				this.dataColumn_2,
				this.dataColumn_3,
				this.dataColumn_4,
				this.dataColumn_5,
				this.dataColumn_6,
				this.dataColumn_7,
				this.dataColumn_8,
				this.dataColumn_9,
				this.dataColumn_10,
				this.dataColumn_11,
				this.dataColumn_12,
				this.dataColumn_13,
				this.dataColumn_14,
				this.dataColumn_15,
				this.dataColumn_16,
				this.dataColumn_17,
				this.dataColumn_18,
				this.dataColumn_19,
				this.dataColumn_20,
				this.dataColumn_21,
				this.dataColumn_22,
				this.dataColumn_23,
				this.dataColumn_24,
				this.dataColumn_25,
				this.dataColumn_26,
				this.dataColumn_27,
				this.dataColumn_28,
				this.dataColumn_29,
				this.dataColumn_30,
				this.dataColumn_31,
				this.dataColumn_32,
				this.dataColumn_33,
				this.dataColumn_34,
				this.dataColumn_35,
				this.dataColumn_36,
				this.dataColumn_37,
				this.dataColumn_38,
				this.dataColumn_39,
				this.dataColumn_40,
				this.dataColumn_41
			});
			this.dataTable_1.TableName = "dtReportCP";
			this.dataColumn_0.ColumnName = "idAbn";
			this.dataColumn_0.DataType = typeof(int);
			this.dataColumn_1.ColumnName = "codeAbonent";
			this.dataColumn_1.DataType = typeof(int);
			this.dataColumn_2.ColumnName = "nameAbn";
			this.dataColumn_3.ColumnName = "typeAbn";
			this.dataColumn_3.DataType = typeof(int);
			this.dataColumn_4.ColumnName = "typeAbnName";
			this.dataColumn_5.ColumnName = "idAbnObj";
			this.dataColumn_5.DataType = typeof(int);
			this.dataColumn_6.ColumnName = "nameObj";
			this.dataColumn_7.ColumnName = "address";
			this.dataColumn_8.ColumnName = "kladrObjId";
			this.dataColumn_8.DataType = typeof(int);
			this.dataColumn_9.ColumnName = "KladrObjName";
			this.dataColumn_10.ColumnName = "category";
			this.dataColumn_10.DataType = typeof(int);
			this.dataColumn_11.ColumnName = "categoryName";
			this.dataColumn_12.ColumnName = "idTariff";
			this.dataColumn_12.DataType = typeof(int);
			this.dataColumn_13.ColumnName = "tariffName";
			this.dataColumn_14.ColumnName = "powerSet";
			this.dataColumn_14.DataType = typeof(decimal);
			this.dataColumn_15.ColumnName = "powerFact";
			this.dataColumn_15.DataType = typeof(decimal);
			this.dataColumn_16.ColumnName = "Consumer";
			this.dataColumn_16.DataType = typeof(int);
			this.dataColumn_17.ColumnName = "consumerName";
			this.dataColumn_18.ColumnName = "contact";
			this.dataColumn_19.ColumnName = "abnNet";
			this.dataColumn_20.ColumnName = "abnServicing";
			this.dataColumn_21.ColumnName = "idSchmObj";
			this.dataColumn_21.DataType = typeof(int);
			this.dataColumn_22.ColumnName = "idDoc";
			this.dataColumn_22.DataType = typeof(int);
			this.dataColumn_23.ColumnName = "TypeDoc";
			this.dataColumn_23.DataType = typeof(int);
			this.dataColumn_24.ColumnName = "TypeDocName";
			this.dataColumn_25.ColumnName = "cellId";
			this.dataColumn_25.DataType = typeof(int);
			this.dataColumn_26.ColumnName = "cellName";
			this.dataColumn_27.ColumnName = "busId";
			this.dataColumn_27.DataType = typeof(int);
			this.dataColumn_28.ColumnName = "busName";
			this.dataColumn_29.ColumnName = "subId";
			this.dataColumn_29.DataType = typeof(int);
			this.dataColumn_30.ColumnName = "subName";
			this.dataColumn_31.ColumnName = "schmObjName";
			this.dataColumn_32.ColumnName = "cellCPId";
			this.dataColumn_33.ColumnName = "cellCPName";
			this.dataColumn_34.ColumnName = "busCPId";
			this.dataColumn_35.ColumnName = "busCPName";
			this.dataColumn_36.ColumnName = "subCPId";
			this.dataColumn_37.ColumnName = "subCPName";
			this.dataColumn_38.ColumnName = "SumKWT";
			this.dataColumn_38.DataType = typeof(int);
			this.tabPage_0.Controls.Add(this.splitContainer_0);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tabPageLegal";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(967, 442);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Юридические лица";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.backgroundWorker_1.DoWork += this.backgroundWorker_1_DoWork;
			this.backgroundWorker_1.RunWorkerCompleted += this.backgroundWorker_1_RunWorkerCompleted;
			this.dataColumn_39.ColumnName = "docAbn";
			this.dataColumn_40.ColumnName = "legalAddress";
			this.dataColumn_41.ColumnName = "postAddress";
			this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "codeAbonent";
			this.dataGridViewFilterTextBoxColumn_0.HeaderText = "№ договора";
			this.dataGridViewFilterTextBoxColumn_0.Name = "codeAbonentDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_0.Width = 70;
			this.dataGridViewTextBoxColumn_14.DataPropertyName = "idAbn";
			this.dataGridViewTextBoxColumn_14.HeaderText = "idAbn";
			this.dataGridViewTextBoxColumn_14.Name = "idAbnDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewTextBoxColumn_14.Visible = false;
			this.dataGridViewFilterTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "nameAbn";
			this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Абонент";
			this.dataGridViewFilterTextBoxColumn_1.Name = "nameAbnDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_15.DataPropertyName = "typeAbn";
			this.dataGridViewTextBoxColumn_15.HeaderText = "typeAbn";
			this.dataGridViewTextBoxColumn_15.Name = "typeAbnDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_15.Visible = false;
			this.dataGridViewFilterTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "nameObj";
			this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Объект";
			this.dataGridViewFilterTextBoxColumn_2.Name = "nameObjDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_16.DataPropertyName = "idAbnObj";
			this.dataGridViewTextBoxColumn_16.HeaderText = "idAbnObj";
			this.dataGridViewTextBoxColumn_16.Name = "idAbnObjDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewTextBoxColumn_16.Visible = false;
			this.dataGridViewFilterTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "streetname";
			this.dataGridViewFilterTextBoxColumn_3.FillWeight = 70f;
			this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Улица";
			this.dataGridViewFilterTextBoxColumn_3.Name = "streetnameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "house";
			this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Дом";
			this.dataGridViewFilterTextBoxColumn_4.Name = "houseDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "subname";
			this.dataGridViewFilterTextBoxColumn_5.HeaderText = "ПС";
			this.dataGridViewFilterTextBoxColumn_5.Name = "subnameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_5.Width = 65;
			this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "busname";
			this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Шина";
			this.dataGridViewFilterTextBoxColumn_6.Name = "busnameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_6.Visible = false;
			this.dataGridViewFilterTextBoxColumn_6.Width = 55;
			this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "CellName";
			this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Ячейка";
			this.dataGridViewFilterTextBoxColumn_7.Name = "cellNameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_7.Visible = false;
			this.dataGridViewFilterTextBoxColumn_7.Width = 55;
			this.dataGridViewTextBoxColumn_17.DataPropertyName = "idSchmObj";
			this.dataGridViewTextBoxColumn_17.HeaderText = "idSchmObj";
			this.dataGridViewTextBoxColumn_17.Name = "idSchmObjDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewTextBoxColumn_17.Visible = false;
			this.dataGridViewTextBoxColumn_18.DataPropertyName = "cellId";
			this.dataGridViewTextBoxColumn_18.HeaderText = "cellId";
			this.dataGridViewTextBoxColumn_18.Name = "cellIdDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_18.ReadOnly = true;
			this.dataGridViewTextBoxColumn_18.Visible = false;
			this.dataGridViewTextBoxColumn_19.DataPropertyName = "busid";
			this.dataGridViewTextBoxColumn_19.HeaderText = "busid";
			this.dataGridViewTextBoxColumn_19.Name = "busidDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_19.ReadOnly = true;
			this.dataGridViewTextBoxColumn_19.Visible = false;
			this.dataGridViewTextBoxColumn_20.DataPropertyName = "subid";
			this.dataGridViewTextBoxColumn_20.HeaderText = "subid";
			this.dataGridViewTextBoxColumn_20.Name = "subidDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_20.ReadOnly = true;
			this.dataGridViewTextBoxColumn_20.Visible = false;
			this.dataGridViewTextBoxColumn_21.DataPropertyName = "schmObjName";
			this.dataGridViewTextBoxColumn_21.HeaderText = "schmObjName";
			this.dataGridViewTextBoxColumn_21.Name = "schmObjNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_21.ReadOnly = true;
			this.dataGridViewTextBoxColumn_21.Visible = false;
			this.bindingSource_0.DataMember = "vL_SchmAbnFull";
			this.bindingSource_0.DataSource = this.class19_0;
			this.bindingSource_0.CurrentChanged += this.bindingSource_0_CurrentChanged;
			this.class19_0.DataSetName = "DataSetScheme";
			this.class19_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_4.HeaderText = "id";
			this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "idAbn";
			this.dataGridViewTextBoxColumn_5.HeaderText = "idAbn";
			this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "Post";
			this.dataGridViewTextBoxColumn_6.HeaderText = "Должность";
			this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "F";
			this.dataGridViewTextBoxColumn_7.HeaderText = "Фамилия";
			this.dataGridViewTextBoxColumn_7.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "I";
			this.dataGridViewTextBoxColumn_8.HeaderText = "Имя";
			this.dataGridViewTextBoxColumn_8.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "O";
			this.dataGridViewTextBoxColumn_9.HeaderText = "Отчество";
			this.dataGridViewTextBoxColumn_9.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "Phone";
			this.dataGridViewTextBoxColumn_10.HeaderText = "Телефон";
			this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "DateChange";
			this.dataGridViewTextBoxColumn_11.HeaderText = "DateChange";
			this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_12.HeaderText = "Коментарий";
			this.dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Width = 120;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "email";
			this.dataGridViewTextBoxColumn_13.HeaderText = "e`mail";
			this.dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.bindingSource_1.DataMember = "tAbnContact";
			this.bindingSource_1.DataSource = this.class19_0;
			this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "subCPName";
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_10.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewFilterTextBoxColumn_10.HeaderText = "ЦП";
			this.dataGridViewFilterTextBoxColumn_10.Name = "subCPNameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_10.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "cellCPName";
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_11.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Ячейка ЦП";
			this.dataGridViewFilterTextBoxColumn_11.Name = "cellCPNameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_11.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_11.Width = 70;
			this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "subName";
			this.dataGridViewFilterTextBoxColumn_12.HeaderText = "ПС";
			this.dataGridViewFilterTextBoxColumn_12.Name = "subNameDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_12.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_12.Width = 90;
			this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "busName";
			this.dataGridViewFilterTextBoxColumn_13.HeaderText = "Шина";
			this.dataGridViewFilterTextBoxColumn_13.Name = "busNameDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_13.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_13.Width = 80;
			this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "cellName";
			this.dataGridViewFilterTextBoxColumn_14.HeaderText = "Ячейка";
			this.dataGridViewFilterTextBoxColumn_14.Name = "cellNameDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_14.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_14.Width = 80;
			this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "codeAbonent";
			this.dataGridViewFilterTextBoxColumn_15.HeaderText = "№ договора";
			this.dataGridViewFilterTextBoxColumn_15.Name = "codeAbonentDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_15.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_15.Visible = false;
			this.dataGridViewFilterTextBoxColumn_15.Width = 90;
			this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "docAbn";
			this.dataGridViewFilterTextBoxColumn_16.HeaderText = "№ договора";
			this.dataGridViewFilterTextBoxColumn_16.Name = "docAbn";
			this.dataGridViewFilterTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_16.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_17.DataPropertyName = "nameAbn";
			this.dataGridViewFilterTextBoxColumn_17.HeaderText = "Абонент";
			this.dataGridViewFilterTextBoxColumn_17.Name = "nameAbnDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_17.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_22.DataPropertyName = "idAbn";
			this.dataGridViewTextBoxColumn_22.HeaderText = "idAbn";
			this.dataGridViewTextBoxColumn_22.Name = "idAbnDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_22.ReadOnly = true;
			this.dataGridViewTextBoxColumn_22.Visible = false;
			this.dataGridViewTextBoxColumn_23.DataPropertyName = "typeAbn";
			this.dataGridViewTextBoxColumn_23.HeaderText = "typeAbn";
			this.dataGridViewTextBoxColumn_23.Name = "typeAbnDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_23.ReadOnly = true;
			this.dataGridViewTextBoxColumn_23.Visible = false;
			this.dataGridViewFilterTextBoxColumn_18.DataPropertyName = "typeAbnName";
			this.dataGridViewFilterTextBoxColumn_18.HeaderText = "Тип";
			this.dataGridViewFilterTextBoxColumn_18.Name = "typeAbnNameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_18.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_18.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_24.DataPropertyName = "idAbnObj";
			this.dataGridViewTextBoxColumn_24.HeaderText = "idAbnObj";
			this.dataGridViewTextBoxColumn_24.Name = "idAbnObjDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_24.ReadOnly = true;
			this.dataGridViewTextBoxColumn_24.Visible = false;
			this.dataGridViewFilterTextBoxColumn_19.DataPropertyName = "legalAddress";
			this.dataGridViewFilterTextBoxColumn_19.HeaderText = "Юридический адрес";
			this.dataGridViewFilterTextBoxColumn_19.Name = "legalAddress";
			this.dataGridViewFilterTextBoxColumn_19.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_19.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_20.DataPropertyName = "postAddress";
			this.dataGridViewFilterTextBoxColumn_20.HeaderText = "Почтовый адрес";
			this.dataGridViewFilterTextBoxColumn_20.Name = "postAddress";
			this.dataGridViewFilterTextBoxColumn_20.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_20.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_21.DataPropertyName = "nameObj";
			this.dataGridViewFilterTextBoxColumn_21.HeaderText = "Объект";
			this.dataGridViewFilterTextBoxColumn_21.Name = "nameObjDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_21.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_21.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_25.DataPropertyName = "address";
			this.dataGridViewTextBoxColumn_25.HeaderText = "Адрес объекта";
			this.dataGridViewTextBoxColumn_25.Name = "addressDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_25.ReadOnly = true;
			this.dataGridViewTextBoxColumn_26.DataPropertyName = "kladrObjId";
			this.dataGridViewTextBoxColumn_26.HeaderText = "kladrObjId";
			this.dataGridViewTextBoxColumn_26.Name = "kladrObjIdDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_26.ReadOnly = true;
			this.dataGridViewTextBoxColumn_26.Visible = false;
			this.dataGridViewFilterTextBoxColumn_22.DataPropertyName = "KladrObjName";
			this.dataGridViewFilterTextBoxColumn_22.HeaderText = "Город";
			this.dataGridViewFilterTextBoxColumn_22.Name = "kladrObjNameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_22.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_22.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_22.Visible = false;
			this.YdxAmuqGc0.DataPropertyName = "category";
			this.YdxAmuqGc0.HeaderText = "category";
			this.YdxAmuqGc0.Name = "categoryDataGridViewTextBoxColumn";
			this.YdxAmuqGc0.ReadOnly = true;
			this.YdxAmuqGc0.Visible = false;
			this.dataGridViewFilterTextBoxColumn_23.DataPropertyName = "categoryName";
			this.dataGridViewFilterTextBoxColumn_23.HeaderText = "Кат";
			this.dataGridViewFilterTextBoxColumn_23.Name = "categoryNameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_23.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_23.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_23.Width = 50;
			this.dataGridViewTextBoxColumn_27.DataPropertyName = "idTariff";
			this.dataGridViewTextBoxColumn_27.HeaderText = "idTariff";
			this.dataGridViewTextBoxColumn_27.Name = "idTariffDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_27.ReadOnly = true;
			this.dataGridViewTextBoxColumn_27.Visible = false;
			this.dataGridViewFilterTextBoxColumn_24.DataPropertyName = "tariffName";
			this.dataGridViewFilterTextBoxColumn_24.HeaderText = "Тариф";
			this.dataGridViewFilterTextBoxColumn_24.Name = "tariffNameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_24.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_24.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_24.Width = 70;
			this.dataGridViewTextBoxColumn_28.DataPropertyName = "powerSet";
			this.dataGridViewTextBoxColumn_28.HeaderText = "Уст мощность";
			this.dataGridViewTextBoxColumn_28.Name = "powerSetDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_28.ReadOnly = true;
			this.dataGridViewTextBoxColumn_29.DataPropertyName = "powerFact";
			this.dataGridViewTextBoxColumn_29.HeaderText = "Факт мощность";
			this.dataGridViewTextBoxColumn_29.Name = "powerFactDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_29.ReadOnly = true;
			this.dataGridViewTextBoxColumn_30.DataPropertyName = "Consumer";
			this.dataGridViewTextBoxColumn_30.HeaderText = "Consumer";
			this.dataGridViewTextBoxColumn_30.Name = "consumerDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_30.ReadOnly = true;
			this.dataGridViewTextBoxColumn_30.Visible = false;
			this.dataGridViewTextBoxColumn_31.DataPropertyName = "SumKWT";
			this.dataGridViewTextBoxColumn_31.HeaderText = "Потребление";
			this.dataGridViewTextBoxColumn_31.Name = "sumKWTDgvColumn";
			this.dataGridViewTextBoxColumn_31.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_25.DataPropertyName = "consumerName";
			this.dataGridViewFilterTextBoxColumn_25.HeaderText = "Состав группы";
			this.dataGridViewFilterTextBoxColumn_25.Name = "consumerNameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_25.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_25.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_32.DataPropertyName = "contact";
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_32.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn_32.HeaderText = "Телефоны";
			this.dataGridViewTextBoxColumn_32.Name = "contactDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_32.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_26.DataPropertyName = "abnNet";
			this.dataGridViewFilterTextBoxColumn_26.HeaderText = "Сетевая орг-ция";
			this.dataGridViewFilterTextBoxColumn_26.Name = "abnNetDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_26.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_26.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_27.DataPropertyName = "abnServicing";
			this.dataGridViewFilterTextBoxColumn_27.HeaderText = "Обсл-ая орг-ция";
			this.dataGridViewFilterTextBoxColumn_27.Name = "abnServicingDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_27.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_27.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_33.DataPropertyName = "idSchmObj";
			this.dataGridViewTextBoxColumn_33.HeaderText = "idSchmObj";
			this.dataGridViewTextBoxColumn_33.Name = "idSchmObjDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_33.ReadOnly = true;
			this.dataGridViewTextBoxColumn_33.Visible = false;
			this.dataGridViewTextBoxColumn_34.DataPropertyName = "idDoc";
			this.dataGridViewTextBoxColumn_34.HeaderText = "idDoc";
			this.dataGridViewTextBoxColumn_34.Name = "idDocDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_34.ReadOnly = true;
			this.dataGridViewTextBoxColumn_34.Visible = false;
			this.dataGridViewTextBoxColumn_35.DataPropertyName = "TypeDoc";
			this.dataGridViewTextBoxColumn_35.HeaderText = "TypeDoc";
			this.dataGridViewTextBoxColumn_35.Name = "typeDocDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_35.ReadOnly = true;
			this.dataGridViewTextBoxColumn_35.Visible = false;
			this.dataGridViewTextBoxColumn_36.DataPropertyName = "TypeDocName";
			this.dataGridViewTextBoxColumn_36.HeaderText = "TypeDocName";
			this.dataGridViewTextBoxColumn_36.Name = "typeDocNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_36.ReadOnly = true;
			this.dataGridViewTextBoxColumn_36.Visible = false;
			this.dataGridViewTextBoxColumn_37.DataPropertyName = "cellId";
			this.dataGridViewTextBoxColumn_37.HeaderText = "cellId";
			this.dataGridViewTextBoxColumn_37.Name = "cellIdDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_37.ReadOnly = true;
			this.dataGridViewTextBoxColumn_37.Visible = false;
			this.dataGridViewTextBoxColumn_38.DataPropertyName = "busId";
			this.dataGridViewTextBoxColumn_38.HeaderText = "busId";
			this.dataGridViewTextBoxColumn_38.Name = "busIdDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_38.ReadOnly = true;
			this.dataGridViewTextBoxColumn_38.Visible = false;
			this.dataGridViewTextBoxColumn_39.DataPropertyName = "subId";
			this.dataGridViewTextBoxColumn_39.HeaderText = "subId";
			this.dataGridViewTextBoxColumn_39.Name = "subIdDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_39.ReadOnly = true;
			this.dataGridViewTextBoxColumn_39.Visible = false;
			this.dataGridViewTextBoxColumn_40.DataPropertyName = "schmObjName";
			this.dataGridViewTextBoxColumn_40.HeaderText = "schmObjName";
			this.dataGridViewTextBoxColumn_40.Name = "schmObjNameDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_40.ReadOnly = true;
			this.dataGridViewTextBoxColumn_40.Visible = false;
			this.dataGridViewTextBoxColumn_41.DataPropertyName = "cellCPId";
			this.dataGridViewTextBoxColumn_41.HeaderText = "cellCPId";
			this.dataGridViewTextBoxColumn_41.Name = "cellCPIdDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_41.ReadOnly = true;
			this.dataGridViewTextBoxColumn_41.Visible = false;
			this.dataGridViewTextBoxColumn_42.DataPropertyName = "busCPId";
			this.dataGridViewTextBoxColumn_42.HeaderText = "busCPId";
			this.dataGridViewTextBoxColumn_42.Name = "busCPIdDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_42.ReadOnly = true;
			this.dataGridViewTextBoxColumn_42.Visible = false;
			this.dataGridViewTextBoxColumn_43.DataPropertyName = "busCPName";
			this.dataGridViewTextBoxColumn_43.HeaderText = "busCPName";
			this.dataGridViewTextBoxColumn_43.Name = "busCPNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_43.ReadOnly = true;
			this.dataGridViewTextBoxColumn_43.Visible = false;
			this.dataGridViewTextBoxColumn_44.DataPropertyName = "subCPId";
			this.dataGridViewTextBoxColumn_44.HeaderText = "subCPId";
			this.dataGridViewTextBoxColumn_44.Name = "subCPIdDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_44.ReadOnly = true;
			this.dataGridViewTextBoxColumn_44.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(975, 493);
			base.Controls.Add(this.panel_0);
			base.Controls.Add(this.tabControl_0);
			base.Controls.Add(this.toolStrip_0);
			this.MinimumSize = new Size(821, 319);
			base.Name = "FormLinkAbnNewAndOld";
			this.Text = "\"Привязанные\" абоненты";
			base.Load += this.FormLinkAbnNewAndOld_Load;
			base.Resize += this.FormLinkAbnNewAndOld_Resize;
			((ISupportInitialize)this.treeDataGridView_1).EndInit();
			((ISupportInitialize)this.treeDataGridView_0).EndInit();
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_0).EndInit();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.splitContainer_0.Panel1.ResumeLayout(false);
			this.splitContainer_0.Panel2.ResumeLayout(false);
			this.splitContainer_0.ResumeLayout(false);
			((ISupportInitialize)this.dataGridViewExcelFilter_1).EndInit();
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_1.ResumeLayout(false);
			((ISupportInitialize)this.dataGridViewExcelFilter_2).EndInit();
			((ISupportInitialize)this.bindingSource_2).EndInit();
			((ISupportInitialize)this.dataSet_0).EndInit();
			((ISupportInitialize)this.dataTable_1).EndInit();
			this.tabPage_0.ResumeLayout(false);
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.class19_0).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		internal static void UP3Ms9RfLu4H360Kqtl(Form form_0, bool bool_2)
		{
			form_0.Dispose(bool_2);
		}

		private DataTable dataTable_0;

		private bool bool_0;

		private bool bool_1;

		private DateTimePicker dateTimePicker_0;

		private TreeDataGridView treeDataGridView_0;

		private TreeGridColumn treeGridColumn_0;

		private TreeGridColumn treeGridColumn_1;

		private TreeGridColumn treeGridColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private TreeDataGridView treeDataGridView_1;

		private TreeGridColumn treeGridColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private BackgroundWorker backgroundWorker_0;

		private Panel panel_0;

		private Label label_0;

		private ProgressBarEndLess progressBarEndLess_0;

		private BindingSource bindingSource_0;

		private Class19 class19_0;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private ToolStrip toolStrip_0;

		private SplitContainer splitContainer_0;

		private BindingSource bindingSource_1;

		private DataGridViewExcelFilter dataGridViewExcelFilter_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private ToolStripButton toolStripButton_0;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

		private TabPage tabPage_1;

		private BackgroundWorker backgroundWorker_1;

		private DataSet dataSet_0;

		private DataTable dataTable_1;

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private DataColumn dataColumn_5;

		private DataColumn dataColumn_6;

		private DataColumn dataColumn_7;

		private DataColumn dataColumn_8;

		private DataColumn dataColumn_9;

		private DataColumn dataColumn_10;

		private DataColumn dataColumn_11;

		private DataColumn dataColumn_12;

		private DataColumn dataColumn_13;

		private DataColumn dataColumn_14;

		private DataColumn dataColumn_15;

		private DataColumn dataColumn_16;

		private DataColumn dataColumn_17;

		private DataColumn dataColumn_18;

		private DataColumn dataColumn_19;

		private DataColumn dataColumn_20;

		private DataColumn dataColumn_21;

		private DataColumn dataColumn_22;

		private DataColumn dataColumn_23;

		private DataColumn dataColumn_24;

		private DataColumn dataColumn_25;

		private DataColumn dataColumn_26;

		private DataColumn dataColumn_27;

		private DataColumn dataColumn_28;

		private DataColumn dataColumn_29;

		private DataColumn dataColumn_30;

		private DataColumn dataColumn_31;

		private DataGridViewExcelFilter dataGridViewExcelFilter_2;

		private BindingSource bindingSource_2;

		private DataColumn dataColumn_32;

		private DataColumn dataColumn_33;

		private DataColumn dataColumn_34;

		private DataColumn dataColumn_35;

		private DataColumn dataColumn_36;

		private DataColumn dataColumn_37;

		private ToolStripButton toolStripButton_1;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripLabel toolStripLabel_0;

		private ToolStripComboBox toolStripComboBox_0;

		private ToolStripLabel toolStripLabel_1;

		private DataColumn dataColumn_38;

		private ToolStripButton toolStripButton_2;

		private DataColumn dataColumn_39;

		private DataColumn dataColumn_40;

		private DataColumn dataColumn_41;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_11;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_12;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_13;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_14;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_15;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_16;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_17;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_18;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_19;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_20;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_21;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_22;

		private DataGridViewTextBoxColumn YdxAmuqGc0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_23;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_24;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_25;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_26;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_27;

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

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;

		private class Class5
		{
			internal Class5(bool bool_1, DateTime dateTime_1)
			{
				
				
				this.bool_0 = bool_1;
				this.dateTime_0 = dateTime_1;
			}

			internal bool bool_0;

			internal DateTime dateTime_0;
		}

		private class Class6
		{
			internal Class6(int int_2, int int_3, ElectricModel electricModel_1)
			{
				
				
				this.int_0 = int_2;
				this.int_1 = int_3;
				this.electricModel_0 = electricModel_1;
			}

			internal int int_0;

			internal int int_1;

			internal ElectricModel electricModel_0;
		}
	}
}
