using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using Scheme.Properties;
using SchemeModel;

namespace Scheme.Forms.Reports
{
	public partial class FormLinkAbnOff : FormBase
	{
		public FormLinkAbnOff()
		{
			
			
			this.dataTable_0 = new DataTable("vL_SchmAbnFull");
			this.dataTable_0.Columns.Add("StreetName", typeof(string));
			this.dataTable_0.Columns.Add("house", typeof(string));
			this.dataTable_0.Columns.Add("subname", typeof(string));
			this.dataTable_0.Columns.Add("busname", typeof(string));
			this.dataTable_0.Columns.Add("cellname", typeof(string));
			this.uWtAoYhBe0();
			this.bindingSource_1.DataSource = this.dataTable_0;
			foreach (object obj in this.dataGridViewExcelFilter_1.Columns)
			{
				((DataGridViewFilterTextBoxColumn)obj).FilteringEnabled = true;
			}
		}

		private void FormLinkAbnOff_Load(object sender, EventArgs e)
		{
			this.method_0();
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
			this.dataGridViewExcelFilter_2.DataSource = null;
			this.backgroundWorker_0.RunWorkerAsync();
		}

		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			ElectricModel electricModel = new ElectricModel();
			electricModel.SqlSettings = this.SqlSettings;
			electricModel.LoadSchema(false);
			IEnumerable<ElectricObject> enumerable = from obj in electricModel.Objects
			where (obj is ElectricBus && ((ElectricBus)obj).Amperage == null) || (obj is ElectricLine && ((ElectricLine)obj).IsCell() && (((ElectricLine)obj).AmperageCount == 0 || ((ElectricLine)obj).IsRelationOff()))
			select obj;
			string text = "";
			foreach (ElectricObject electricObject in enumerable)
			{
				if (string.IsNullOrEmpty(text))
				{
					text = electricObject.Id.ToString();
				}
				else
				{
					text = text + "," + electricObject.Id.ToString();
				}
			}
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					DbDataAdapter dbDataAdapter = new SqlDataAdapter("select streetname, house, subname, busname, cellname, count(*) as CountAbn from vl_SchmAbnFull where abnActive = 1 and ObjActive = 1 and typeabn in (206,253) and idSchmObj in (" + text + ")group by streetname, house, subname, busname, cellname order by subname, busname, cellname, streetname, house ", sqlConnection);
					this.dataTable_0.Clear();
					dbDataAdapter.Fill(this.dataTable_0);
					DbDataAdapter dbDataAdapter2 = new SqlDataAdapter("select idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj, id, streetname, house, categoryname, tarifname, powerset, powerfact, contact, idschmObj, cellid, cellname, busid, busname, subid, subname from vl_SchmAbnFull where abnActive = 1 and objActive = 1 and idSchmObj in (" + text + ") and typeAbn in (207,231,230) group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj, id, streetname, house, categoryname, tarifname, powerset, powerfact, contact, idschmObj, cellid, cellname, busid, busname, subid, subname  order by subname, busname, cellname, nameAbn, nameObj", sqlConnection);
					this.class19_0.vL_SchmAbnFull.Clear();
					dbDataAdapter2.Fill(this.class19_0.vL_SchmAbnFull);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
				}
			}
		}

		private void FormLinkAbnOff_Resize(object sender, EventArgs e)
		{
			this.panel_0.Left = base.Width / 2 - this.progressBarEndLess_0.Width / 2;
			this.panel_0.Top = base.Height / 2 - this.progressBarEndLess_0.Height / 2;
		}

		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
			this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
			this.splitContainer_0.Enabled = true;
			this.toolStrip_0.Enabled = true;
			this.panel_0.Visible = false;
			this.progressBarEndLess_0.AutoProgress = false;
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
		}

		private void uWtAoYhBe0()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormLinkAbnOff));
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
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.class19_0 = new Class19();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.splitContainer_0 = new SplitContainer();
			this.splitContainer_1 = new SplitContainer();
			this.dataGridViewExcelFilter_1 = new DataGridViewExcelFilter();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.dataGridViewExcelFilter_2 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
			this.bindingSource_2 = new BindingSource(this.icontainer_0);
			this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
			this.treeDataGridView_1.BeginInit();
			this.treeDataGridView_0.BeginInit();
			this.panel_0.SuspendLayout();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.class19_0).BeginInit();
			this.dataGridViewExcelFilter_0.BeginInit();
			this.toolStrip_0.SuspendLayout();
			this.splitContainer_0.Panel1.SuspendLayout();
			this.splitContainer_0.Panel2.SuspendLayout();
			this.splitContainer_0.SuspendLayout();
			this.splitContainer_1.Panel1.SuspendLayout();
			this.splitContainer_1.Panel2.SuspendLayout();
			this.splitContainer_1.SuspendLayout();
			this.dataGridViewExcelFilter_1.BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			this.dataGridViewExcelFilter_2.BeginInit();
			((ISupportInitialize)this.bindingSource_2).BeginInit();
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
			this.progressBarEndLess_0.ProgressStyle = 1;
			this.progressBarEndLess_0.ProgressType = 1;
			this.progressBarEndLess_0.Size = new Size(431, 35);
			this.progressBarEndLess_0.TabIndex = 5;
			this.bindingSource_0.DataMember = "vL_SchmAbnFull";
			this.bindingSource_0.DataSource = this.class19_0;
			this.bindingSource_0.CurrentChanged += this.bindingSource_0_CurrentChanged;
			this.class19_0.DataSetName = "DataSetScheme";
			this.class19_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewFilterTextBoxColumn_0,
				this.dataGridViewFilterTextBoxColumn_1,
				this.dataGridViewFilterTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewFilterTextBoxColumn_3,
				this.dataGridViewFilterTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewCheckBoxColumn_0,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewFilterTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_9,
				this.dataGridViewTextBoxColumn_10,
				this.dataGridViewFilterTextBoxColumn_6,
				this.dataGridViewFilterTextBoxColumn_7,
				this.dataGridViewFilterTextBoxColumn_8,
				this.dataGridViewFilterTextBoxColumn_9,
				this.dataGridViewFilterTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_11,
				this.dataGridViewTextBoxColumn_12,
				this.dataGridViewTextBoxColumn_13,
				this.dataGridViewTextBoxColumn_14,
				this.dataGridViewTextBoxColumn_15
			});
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_0.Name = "dgvListLegal";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			this.dataGridViewExcelFilter_0.Size = new Size(975, 232);
			this.dataGridViewExcelFilter_0.TabIndex = 8;
			this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "subname";
			this.dataGridViewFilterTextBoxColumn_0.HeaderText = "ПС";
			this.dataGridViewFilterTextBoxColumn_0.Name = "subnameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_0.Width = 65;
			this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "busname";
			this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Шина";
			this.dataGridViewFilterTextBoxColumn_1.Name = "busnameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_1.Width = 55;
			this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "CellName";
			this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Ячейка";
			this.dataGridViewFilterTextBoxColumn_2.Name = "cellNameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_2.Width = 55;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "idAbn";
			this.dataGridViewTextBoxColumn_4.HeaderText = "idAbn";
			this.dataGridViewTextBoxColumn_4.Name = "idAbnDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "codeAbonent";
			this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Код";
			this.dataGridViewFilterTextBoxColumn_3.Name = "codeAbonentDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_3.Width = 70;
			this.dataGridViewFilterTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "nameAbn";
			this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Абонент";
			this.dataGridViewFilterTextBoxColumn_4.Name = "nameAbnDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "typeAbn";
			this.dataGridViewTextBoxColumn_5.HeaderText = "typeAbn";
			this.dataGridViewTextBoxColumn_5.Name = "typeAbnDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewCheckBoxColumn_0.DataPropertyName = "aBnActive";
			this.dataGridViewCheckBoxColumn_0.HeaderText = "aBnActive";
			this.dataGridViewCheckBoxColumn_0.Name = "aBnActiveDataGridViewCheckBoxColumn";
			this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "idAbnObj";
			this.dataGridViewTextBoxColumn_6.HeaderText = "idAbnObj";
			this.dataGridViewTextBoxColumn_6.Name = "idAbnObjDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewFilterTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "nameObj";
			this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Объект";
			this.dataGridViewFilterTextBoxColumn_5.Name = "nameObjDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_7.HeaderText = "id";
			this.dataGridViewTextBoxColumn_7.Name = "idDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "streetname";
			this.dataGridViewTextBoxColumn_8.HeaderText = "streetname";
			this.dataGridViewTextBoxColumn_8.Name = "streetnameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "house";
			this.dataGridViewTextBoxColumn_9.HeaderText = "house";
			this.dataGridViewTextBoxColumn_9.Name = "houseDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "objActive";
			this.dataGridViewTextBoxColumn_10.HeaderText = "objActive";
			this.dataGridViewTextBoxColumn_10.Name = "objActiveDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.Visible = false;
			this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "CategoryName";
			this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Кат";
			this.dataGridViewFilterTextBoxColumn_6.Name = "categoryNameDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_6.Width = 40;
			this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "TarifName";
			this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Тар";
			this.dataGridViewFilterTextBoxColumn_7.Name = "tarifNameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_7.Width = 40;
			this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "PowerSet";
			this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Уст мощность";
			this.dataGridViewFilterTextBoxColumn_8.Name = "powerSetDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "PowerFact";
			this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Факт мощность";
			this.dataGridViewFilterTextBoxColumn_9.Name = "powerFactDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_9.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "contact";
			this.dataGridViewFilterTextBoxColumn_10.FillWeight = 70f;
			this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Телефоны";
			this.dataGridViewFilterTextBoxColumn_10.Name = "contactDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_10.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "idSchmObj";
			this.dataGridViewTextBoxColumn_11.HeaderText = "idSchmObj";
			this.dataGridViewTextBoxColumn_11.Name = "idSchmObjDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "cellId";
			this.dataGridViewTextBoxColumn_12.HeaderText = "cellId";
			this.dataGridViewTextBoxColumn_12.Name = "cellIdDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "busid";
			this.dataGridViewTextBoxColumn_13.HeaderText = "busid";
			this.dataGridViewTextBoxColumn_13.Name = "busidDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.Visible = false;
			this.dataGridViewTextBoxColumn_14.DataPropertyName = "subid";
			this.dataGridViewTextBoxColumn_14.HeaderText = "subid";
			this.dataGridViewTextBoxColumn_14.Name = "subidDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewTextBoxColumn_14.Visible = false;
			this.dataGridViewTextBoxColumn_15.DataPropertyName = "schmObjName";
			this.dataGridViewTextBoxColumn_15.HeaderText = "schmObjName";
			this.dataGridViewTextBoxColumn_15.Name = "schmObjNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_15.Visible = false;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0
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
			this.splitContainer_0.Dock = DockStyle.Fill;
			this.splitContainer_0.Location = new Point(0, 25);
			this.splitContainer_0.Name = "splitContainer1";
			this.splitContainer_0.Orientation = Orientation.Horizontal;
			this.splitContainer_0.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
			this.splitContainer_0.Panel2.Controls.Add(this.splitContainer_1);
			this.splitContainer_0.Size = new Size(975, 468);
			this.splitContainer_0.SplitterDistance = 232;
			this.splitContainer_0.TabIndex = 10;
			this.splitContainer_1.Dock = DockStyle.Fill;
			this.splitContainer_1.Location = new Point(0, 0);
			this.splitContainer_1.Name = "splitContainer2";
			this.splitContainer_1.Panel1.Controls.Add(this.dataGridViewExcelFilter_1);
			this.splitContainer_1.Panel2.Controls.Add(this.dataGridViewExcelFilter_2);
			this.splitContainer_1.Size = new Size(975, 232);
			this.splitContainer_1.SplitterDistance = 478;
			this.splitContainer_1.TabIndex = 0;
			this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewFilterTextBoxColumn_11,
				this.dataGridViewFilterTextBoxColumn_12,
				this.dataGridViewFilterTextBoxColumn_13,
				this.dataGridViewFilterTextBoxColumn_14,
				this.dataGridViewFilterTextBoxColumn_15,
				this.dataGridViewFilterTextBoxColumn_16
			});
			this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
			this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_1.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_1.Name = "dgvListPrv";
			this.dataGridViewExcelFilter_1.ReadOnly = true;
			this.dataGridViewExcelFilter_1.Size = new Size(478, 232);
			this.dataGridViewExcelFilter_1.TabIndex = 1;
			this.dataGridViewExcelFilter_2.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_2.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_2.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_2.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_2.BackgroundColor = Color.White;
			this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_2.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_16,
				this.dataGridViewTextBoxColumn_17,
				this.dataGridViewTextBoxColumn_18,
				this.dataGridViewTextBoxColumn_19,
				this.dataGridViewTextBoxColumn_20,
				this.dataGridViewTextBoxColumn_21,
				this.dataGridViewTextBoxColumn_22,
				this.dataGridViewTextBoxColumn_23,
				this.dataGridViewTextBoxColumn_24,
				this.dataGridViewTextBoxColumn_25
			});
			this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
			this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_2.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_2.MultiSelect = false;
			this.dataGridViewExcelFilter_2.Name = "dgvListLegalContact";
			this.dataGridViewExcelFilter_2.ReadOnly = true;
			this.dataGridViewExcelFilter_2.RowHeadersWidth = 21;
			this.dataGridViewExcelFilter_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_2.Size = new Size(493, 232);
			this.dataGridViewExcelFilter_2.TabIndex = 5;
			this.dataGridViewTextBoxColumn_16.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_16.HeaderText = "id";
			this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewTextBoxColumn_16.Visible = false;
			this.dataGridViewTextBoxColumn_17.DataPropertyName = "idAbn";
			this.dataGridViewTextBoxColumn_17.HeaderText = "idAbn";
			this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewTextBoxColumn_17.Visible = false;
			this.dataGridViewTextBoxColumn_18.DataPropertyName = "Post";
			this.dataGridViewTextBoxColumn_18.HeaderText = "Должность";
			this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_18.ReadOnly = true;
			this.dataGridViewTextBoxColumn_19.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_19.DataPropertyName = "F";
			this.dataGridViewTextBoxColumn_19.HeaderText = "Фамилия";
			this.dataGridViewTextBoxColumn_19.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn_19.ReadOnly = true;
			this.dataGridViewTextBoxColumn_20.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_20.DataPropertyName = "I";
			this.dataGridViewTextBoxColumn_20.HeaderText = "Имя";
			this.dataGridViewTextBoxColumn_20.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_20.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn_20.ReadOnly = true;
			this.dataGridViewTextBoxColumn_21.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_21.DataPropertyName = "O";
			this.dataGridViewTextBoxColumn_21.HeaderText = "Отчество";
			this.dataGridViewTextBoxColumn_21.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_21.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn_21.ReadOnly = true;
			this.dataGridViewTextBoxColumn_22.DataPropertyName = "Phone";
			this.dataGridViewTextBoxColumn_22.HeaderText = "Телефон";
			this.dataGridViewTextBoxColumn_22.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn_22.ReadOnly = true;
			this.dataGridViewTextBoxColumn_23.DataPropertyName = "DateChange";
			this.dataGridViewTextBoxColumn_23.HeaderText = "DateChange";
			this.dataGridViewTextBoxColumn_23.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn_23.ReadOnly = true;
			this.dataGridViewTextBoxColumn_23.Visible = false;
			this.dataGridViewTextBoxColumn_24.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_24.HeaderText = "Коментарий";
			this.dataGridViewTextBoxColumn_24.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn_24.ReadOnly = true;
			this.dataGridViewTextBoxColumn_24.Width = 120;
			this.dataGridViewTextBoxColumn_25.DataPropertyName = "email";
			this.dataGridViewTextBoxColumn_25.HeaderText = "e`mail";
			this.dataGridViewTextBoxColumn_25.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn_25.ReadOnly = true;
			this.bindingSource_2.DataMember = "tAbnContact";
			this.bindingSource_2.DataSource = this.class19_0;
			this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "subname";
			this.dataGridViewFilterTextBoxColumn_11.FilteringEnabled = false;
			this.dataGridViewFilterTextBoxColumn_11.HeaderText = "ПС";
			this.dataGridViewFilterTextBoxColumn_11.Name = "dataGridViewFilterTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_11.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "busname";
			this.dataGridViewFilterTextBoxColumn_12.FilteringEnabled = false;
			this.dataGridViewFilterTextBoxColumn_12.HeaderText = "Шина";
			this.dataGridViewFilterTextBoxColumn_12.Name = "Column7";
			this.dataGridViewFilterTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_12.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "cellname";
			this.dataGridViewFilterTextBoxColumn_13.FilteringEnabled = false;
			this.dataGridViewFilterTextBoxColumn_13.HeaderText = "Ячейка";
			this.dataGridViewFilterTextBoxColumn_13.Name = "Column8";
			this.dataGridViewFilterTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_13.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "streetname";
			this.dataGridViewFilterTextBoxColumn_14.FilteringEnabled = false;
			this.dataGridViewFilterTextBoxColumn_14.HeaderText = "Улица";
			this.dataGridViewFilterTextBoxColumn_14.Name = "Column9";
			this.dataGridViewFilterTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_14.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "house";
			this.dataGridViewFilterTextBoxColumn_15.FilteringEnabled = false;
			this.dataGridViewFilterTextBoxColumn_15.HeaderText = "Дом";
			this.dataGridViewFilterTextBoxColumn_15.Name = "Column10";
			this.dataGridViewFilterTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_15.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "countAbn";
			this.dataGridViewFilterTextBoxColumn_16.FilteringEnabled = false;
			this.dataGridViewFilterTextBoxColumn_16.HeaderText = "Кол-во аб-ов";
			this.dataGridViewFilterTextBoxColumn_16.Name = "Column11";
			this.dataGridViewFilterTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_16.Resizable = DataGridViewTriState.True;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(975, 493);
			base.Controls.Add(this.panel_0);
			base.Controls.Add(this.splitContainer_0);
			base.Controls.Add(this.toolStrip_0);
			this.MinimumSize = new Size(821, 319);
			base.Name = "FormLinkAbnOff";
			this.Text = "Отключенные абоненты";
			base.Load += this.FormLinkAbnOff_Load;
			base.Resize += this.FormLinkAbnOff_Resize;
			this.treeDataGridView_1.EndInit();
			this.treeDataGridView_0.EndInit();
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.class19_0).EndInit();
			this.dataGridViewExcelFilter_0.EndInit();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.splitContainer_0.Panel1.ResumeLayout(false);
			this.splitContainer_0.Panel2.ResumeLayout(false);
			this.splitContainer_0.ResumeLayout(false);
			this.splitContainer_1.Panel1.ResumeLayout(false);
			this.splitContainer_1.Panel2.ResumeLayout(false);
			this.splitContainer_1.ResumeLayout(false);
			this.dataGridViewExcelFilter_1.EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			this.dataGridViewExcelFilter_2.EndInit();
			((ISupportInitialize)this.bindingSource_2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		internal static void t9h9JTpTPTOxsYbxPxZ(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private DataTable dataTable_0;

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

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private ToolStrip toolStrip_0;

		private SplitContainer splitContainer_0;

		private SplitContainer splitContainer_1;

		private DataGridViewExcelFilter dataGridViewExcelFilter_1;

		private BindingSource bindingSource_1;

		private BindingSource bindingSource_2;

		private DataGridViewExcelFilter dataGridViewExcelFilter_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

		private ToolStripButton toolStripButton_0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_11;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_12;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_13;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_14;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_15;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_16;
	}
}
