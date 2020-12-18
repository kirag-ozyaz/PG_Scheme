using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using Legal.Forms;
using Microsoft.Office.Interop.Excel;
using SchemeCtrl2.Data;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.ElectricModel;
using SchemeCtrl2.Properties;
using WeifenLuo.WinFormsUI.Docking;

namespace SchemeCtrl2.Canvas.Forms
{
	public class FormAbnFromOldSchema : DockContentBase
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_0()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormAbnFromOldSchema));
			this.button_0 = new Button();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dataSetScheme_0 = new DataSetScheme();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
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
			this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
			this.dataGridViewExcelFilter_1 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.label_0 = new Label();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.dataSet_0 = new DataSet();
			this.dataTable_0 = new DataTable();
			this.dataColumn_0 = new DataColumn();
			this.dataColumn_1 = new DataColumn();
			this.dataColumn_2 = new DataColumn();
			this.dataColumn_3 = new DataColumn();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.tabControl_0 = new TabControl();
			this.tabPage_1 = new TabPage();
			this.tabControlVertical_0 = new TabControlVertical();
			this.tabPage_2 = new TabPage();
			this.splitContainer_0 = new SplitContainer();
			this.dataGridViewExcelFilter_2 = new DataGridViewExcelFilter();
			this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_53 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_54 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_55 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_56 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_57 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_58 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_59 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_17 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_18 = new DataGridViewFilterTextBoxColumn();
			this.bindingSource_2 = new BindingSource(this.icontainer_0);
			this.splitContainer_1 = new SplitContainer();
			this.dataGridViewExcelFilter_3 = new DataGridViewExcelFilter();
			this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewExcelFilter_4 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
			this.tabPage_3 = new TabPage();
			this.splitContainer_3 = new SplitContainer();
			this.treeDataGridView_0 = new TreeDataGridView();
			this.treeGridColumn_0 = new TreeGridColumn();
			this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
			this.treeDataGridView_1 = new TreeDataGridView();
			this.tabPage_0 = new TabPage();
			this.splitContainer_2 = new SplitContainer();
			this.label_1 = new Label();
			this.panel_0 = new Panel();
			this.label_2 = new Label();
			this.progressBarEndLess_0 = new ProgressBarEndLess();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.bindingSource_3 = new BindingSource(this.icontainer_0);
			this.treeGridColumn_1 = new TreeGridColumn();
			this.dataGridViewTextBoxColumn_60 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_61 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_62 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_63 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_64 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_65 = new DataGridViewTextBoxColumn();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dataSetScheme_0).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			((ISupportInitialize)this.dataGridViewExcelFilter_0).BeginInit();
			((ISupportInitialize)this.dataGridViewExcelFilter_1).BeginInit();
			this.toolStrip_0.SuspendLayout();
			((ISupportInitialize)this.dataSet_0).BeginInit();
			((ISupportInitialize)this.dataTable_0).BeginInit();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			this.tabControl_0.SuspendLayout();
			this.tabPage_1.SuspendLayout();
			this.tabControlVertical_0.SuspendLayout();
			this.tabPage_2.SuspendLayout();
			this.splitContainer_0.Panel1.SuspendLayout();
			this.splitContainer_0.Panel2.SuspendLayout();
			this.splitContainer_0.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_2).BeginInit();
			((ISupportInitialize)this.bindingSource_2).BeginInit();
			this.splitContainer_1.Panel1.SuspendLayout();
			this.splitContainer_1.Panel2.SuspendLayout();
			this.splitContainer_1.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_3).BeginInit();
			((ISupportInitialize)this.dataGridViewExcelFilter_4).BeginInit();
			this.tabPage_3.SuspendLayout();
			this.splitContainer_3.Panel1.SuspendLayout();
			this.splitContainer_3.Panel2.SuspendLayout();
			this.splitContainer_3.SuspendLayout();
			((ISupportInitialize)this.treeDataGridView_0).BeginInit();
			((ISupportInitialize)this.treeDataGridView_1).BeginInit();
			this.tabPage_0.SuspendLayout();
			this.splitContainer_2.Panel1.SuspendLayout();
			this.splitContainer_2.Panel2.SuspendLayout();
			this.splitContainer_2.SuspendLayout();
			this.panel_0.SuspendLayout();
			((ISupportInitialize)this.bindingSource_3).BeginInit();
			base.SuspendLayout();
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Location = new Point(866, 494);
			this.button_0.Name = "buttonOK";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.bindingSource_0.DataMember = "v_AbnObjRazresh";
			this.bindingSource_0.DataSource = this.dataSetScheme_0;
			this.dataSetScheme_0.DataSetName = "DataSetScheme";
			this.dataSetScheme_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.bindingSource_1.DataMember = "tAbnContact";
			this.bindingSource_1.DataSource = this.dataSetScheme_0;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_0.BackgroundColor = Color.White;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
			{
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
				this.dataGridViewTextBoxColumn_44,
				this.dataGridViewTextBoxColumn_45,
				this.dataGridViewTextBoxColumn_46,
				this.dataGridViewTextBoxColumn_47
			});
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_0.MultiSelect = false;
			this.dataGridViewExcelFilter_0.Name = "dgvAbn";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			this.dataGridViewExcelFilter_0.RowHeadersWidth = 21;
			this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_0.Size = new Size(931, 199);
			this.dataGridViewExcelFilter_0.TabIndex = 3;
			this.dataGridViewExcelFilter_0.CellDoubleClick += this.dataGridViewExcelFilter_0_CellDoubleClick;
			this.dataGridViewExcelFilter_0.CellFormatting += this.dataGridViewExcelFilter_0_CellFormatting;
			this.dataGridViewTextBoxColumn_33.DataPropertyName = "idAbn";
			this.dataGridViewTextBoxColumn_33.HeaderText = "idAbn";
			this.dataGridViewTextBoxColumn_33.Name = "idAbnDgvColumn";
			this.dataGridViewTextBoxColumn_33.ReadOnly = true;
			this.dataGridViewTextBoxColumn_33.Visible = false;
			this.dataGridViewTextBoxColumn_34.DataPropertyName = "codeAbonent";
			this.dataGridViewTextBoxColumn_34.HeaderText = "№ договора";
			this.dataGridViewTextBoxColumn_34.Name = "codeAbonentDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_34.ReadOnly = true;
			this.dataGridViewTextBoxColumn_34.Width = 40;
			this.dataGridViewTextBoxColumn_35.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_35.DataPropertyName = "nameAbn";
			this.dataGridViewTextBoxColumn_35.HeaderText = "Абонент";
			this.dataGridViewTextBoxColumn_35.MinimumWidth = 100;
			this.dataGridViewTextBoxColumn_35.Name = "nameAbnDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_35.ReadOnly = true;
			this.dataGridViewTextBoxColumn_36.DataPropertyName = "idObj";
			this.dataGridViewTextBoxColumn_36.HeaderText = "idObj";
			this.dataGridViewTextBoxColumn_36.Name = "idObjDgvColumn";
			this.dataGridViewTextBoxColumn_36.ReadOnly = true;
			this.dataGridViewTextBoxColumn_36.Visible = false;
			this.dataGridViewTextBoxColumn_37.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_37.DataPropertyName = "nameObj";
			this.dataGridViewTextBoxColumn_37.HeaderText = "Объект";
			this.dataGridViewTextBoxColumn_37.MinimumWidth = 100;
			this.dataGridViewTextBoxColumn_37.Name = "nameObjDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_37.ReadOnly = true;
			this.dataGridViewTextBoxColumn_38.DataPropertyName = "categoryName";
			this.dataGridViewTextBoxColumn_38.HeaderText = "Кат.";
			this.dataGridViewTextBoxColumn_38.Name = "categoryNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_38.ReadOnly = true;
			this.dataGridViewTextBoxColumn_38.Width = 30;
			this.dataGridViewTextBoxColumn_39.DataPropertyName = "tariffName";
			this.dataGridViewTextBoxColumn_39.HeaderText = "Тар.";
			this.dataGridViewTextBoxColumn_39.Name = "tariffNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_39.ReadOnly = true;
			this.dataGridViewTextBoxColumn_39.Width = 45;
			this.dataGridViewTextBoxColumn_40.DataPropertyName = "Razresh";
			this.dataGridViewTextBoxColumn_40.HeaderText = "Разрешение";
			this.dataGridViewTextBoxColumn_40.Name = "razreshDgvColumn";
			this.dataGridViewTextBoxColumn_40.ReadOnly = true;
			this.dataGridViewTextBoxColumn_41.DataPropertyName = "tpName";
			this.dataGridViewTextBoxColumn_41.HeaderText = "ПС";
			this.dataGridViewTextBoxColumn_41.Name = "tpNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_41.ReadOnly = true;
			this.dataGridViewTextBoxColumn_41.Width = 70;
			this.dataGridViewTextBoxColumn_42.DataPropertyName = "busHigh";
			this.dataGridViewTextBoxColumn_42.HeaderText = "СШ 6/10";
			this.dataGridViewTextBoxColumn_42.Name = "busHighDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_42.ReadOnly = true;
			this.dataGridViewTextBoxColumn_42.Width = 40;
			this.dataGridViewTextBoxColumn_43.DataPropertyName = "busLow";
			this.dataGridViewTextBoxColumn_43.HeaderText = "СШ 0,4";
			this.dataGridViewTextBoxColumn_43.Name = "busLowDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_43.ReadOnly = true;
			this.dataGridViewTextBoxColumn_43.Width = 40;
			this.dataGridViewTextBoxColumn_44.DataPropertyName = "rubilnik";
			this.dataGridViewTextBoxColumn_44.HeaderText = "Руб.";
			this.dataGridViewTextBoxColumn_44.Name = "rubilnikDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_44.ReadOnly = true;
			this.dataGridViewTextBoxColumn_44.Width = 30;
			this.dataGridViewTextBoxColumn_45.DataPropertyName = "Power";
			this.dataGridViewTextBoxColumn_45.HeaderText = "кВт";
			this.dataGridViewTextBoxColumn_45.Name = "powerDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_45.ReadOnly = true;
			this.dataGridViewTextBoxColumn_45.Width = 30;
			this.dataGridViewTextBoxColumn_46.DataPropertyName = "id_razr";
			this.dataGridViewTextBoxColumn_46.HeaderText = "id_razr";
			this.dataGridViewTextBoxColumn_46.Name = "idrazrDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_46.ReadOnly = true;
			this.dataGridViewTextBoxColumn_46.Visible = false;
			this.dataGridViewTextBoxColumn_47.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_47.DataPropertyName = "Contact";
			this.dataGridViewTextBoxColumn_47.FillWeight = 50f;
			this.dataGridViewTextBoxColumn_47.HeaderText = "Контактные телефоны";
			this.dataGridViewTextBoxColumn_47.MinimumWidth = 100;
			this.dataGridViewTextBoxColumn_47.Name = "contactDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_47.ReadOnly = true;
			this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_1.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_1.BackgroundColor = Color.White;
			this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_9
			});
			this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
			this.dataGridViewExcelFilter_1.Location = new Point(0, 218);
			this.dataGridViewExcelFilter_1.MultiSelect = false;
			this.dataGridViewExcelFilter_1.Name = "dataGridViewExcelFilter2";
			this.dataGridViewExcelFilter_1.ReadOnly = true;
			this.dataGridViewExcelFilter_1.RowHeadersWidth = 21;
			this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_1.Size = new Size(931, 73);
			this.dataGridViewExcelFilter_1.TabIndex = 3;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "id";
			this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "idAbn";
			this.dataGridViewTextBoxColumn_1.HeaderText = "idAbn";
			this.dataGridViewTextBoxColumn_1.Name = "idAbnDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "Post";
			this.dataGridViewTextBoxColumn_2.HeaderText = "Должность";
			this.dataGridViewTextBoxColumn_2.Name = "postDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "F";
			this.dataGridViewTextBoxColumn_3.HeaderText = "Фамилия";
			this.dataGridViewTextBoxColumn_3.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_3.Name = "fDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "I";
			this.dataGridViewTextBoxColumn_4.HeaderText = "Имя";
			this.dataGridViewTextBoxColumn_4.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_4.Name = "iDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "O";
			this.dataGridViewTextBoxColumn_5.HeaderText = "Отчество";
			this.dataGridViewTextBoxColumn_5.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_5.Name = "oDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "Phone";
			this.dataGridViewTextBoxColumn_6.HeaderText = "Телефон";
			this.dataGridViewTextBoxColumn_6.Name = "phoneDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "DateChange";
			this.dataGridViewTextBoxColumn_7.HeaderText = "DateChange";
			this.dataGridViewTextBoxColumn_7.Name = "dateChangeDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_8.HeaderText = "Коментарий";
			this.dataGridViewTextBoxColumn_8.Name = "commentDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Width = 120;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "email";
			this.dataGridViewTextBoxColumn_9.HeaderText = "e`mail";
			this.dataGridViewTextBoxColumn_9.Name = "emailDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.label_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(0, 202);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(59, 13);
			this.label_0.TabIndex = 4;
			this.label_0.Text = "Контакты:";
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStrip1";
			this.toolStrip_0.Size = new Size(945, 25);
			this.toolStrip_0.TabIndex = 5;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.microsoftoffice2007excel_7581;
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "toolBtnExportToExcel";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Экспорт в Excel";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.dataSet_0.DataSetName = "NewDataSet";
			this.dataSet_0.Tables.AddRange(new DataTable[]
			{
				this.dataTable_0
			});
			this.dataTable_0.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1,
				this.dataColumn_2,
				this.dataColumn_3
			});
			this.dataTable_0.TableName = "ABN_NASELENIE";
			this.dataColumn_0.ColumnName = "Street";
			this.dataColumn_1.ColumnName = "House";
			this.dataColumn_2.ColumnName = "num_abonent";
			this.dataColumn_2.DataType = typeof(int);
			this.dataColumn_3.ColumnName = "group";
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.dataGridView_0.AutoGenerateColumns = false;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_11,
				this.dataGridViewTextBoxColumn_12,
				this.dataGridViewTextBoxColumn_13
			});
			this.dataGridView_0.DataMember = "ABN_NASELENIE";
			this.dataGridView_0.DataSource = this.dataSet_0;
			this.dataGridView_0.Location = new Point(0, 27);
			this.dataGridView_0.Name = "dgvPrv";
			this.dataGridView_0.ReadOnly = true;
			this.dataGridView_0.Size = new Size(931, 103);
			this.dataGridView_0.TabIndex = 6;
			this.dataGridViewTextBoxColumn_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "Street";
			this.dataGridViewTextBoxColumn_10.HeaderText = "Улица";
			this.dataGridViewTextBoxColumn_10.Name = "streetDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "House";
			this.dataGridViewTextBoxColumn_11.HeaderText = "Дом";
			this.dataGridViewTextBoxColumn_11.Name = "houseDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "num_abonent";
			this.dataGridViewTextBoxColumn_12.HeaderText = "Кол-во аб";
			this.dataGridViewTextBoxColumn_12.Name = "numabonentDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "group";
			this.dataGridViewTextBoxColumn_13.HeaderText = "ПС";
			this.dataGridViewTextBoxColumn_13.Name = "groupDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.tabControl_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Location = new Point(0, 28);
			this.tabControl_0.Name = "tabControl";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(945, 460);
			this.tabControl_0.TabIndex = 7;
			this.tabPage_1.Controls.Add(this.tabControlVertical_0);
			this.tabPage_1.Location = new Point(4, 22);
			this.tabPage_1.Name = "tabPageNew";
			this.tabPage_1.Padding = new Padding(3);
			this.tabPage_1.Size = new Size(937, 434);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "Новая привязка";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.tabControlVertical_0.Alignment = TabAlignment.Right;
			this.tabControlVertical_0.Controls.Add(this.tabPage_2);
			this.tabControlVertical_0.Controls.Add(this.tabPage_3);
			this.tabControlVertical_0.Dock = DockStyle.Fill;
			this.tabControlVertical_0.Location = new Point(3, 3);
			this.tabControlVertical_0.Multiline = true;
			this.tabControlVertical_0.Name = "tabControlNewSchmAbn";
			this.tabControlVertical_0.SelectedIndex = 0;
			this.tabControlVertical_0.Size = new Size(931, 428);
			this.tabControlVertical_0.TabIndex = 2;
			this.tabControlVertical_0.Resize += this.tabControlVertical_0_Resize;
			this.tabPage_2.Controls.Add(this.splitContainer_0);
			this.tabPage_2.Location = new Point(4, 4);
			this.tabPage_2.Name = "tabPageList";
			this.tabPage_2.Padding = new Padding(3);
			this.tabPage_2.Size = new Size(904, 420);
			this.tabPage_2.TabIndex = 0;
			this.tabPage_2.Text = "Список";
			this.tabPage_2.UseVisualStyleBackColor = true;
			this.splitContainer_0.Dock = DockStyle.Fill;
			this.splitContainer_0.Location = new Point(3, 3);
			this.splitContainer_0.Name = "splitContainerList";
			this.splitContainer_0.Orientation = Orientation.Horizontal;
			this.splitContainer_0.Panel1.Controls.Add(this.dataGridViewExcelFilter_2);
			this.splitContainer_0.Panel2.Controls.Add(this.splitContainer_1);
			this.splitContainer_0.Size = new Size(898, 414);
			this.splitContainer_0.SplitterDistance = 207;
			this.splitContainer_0.TabIndex = 7;
			this.dataGridViewExcelFilter_2.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_2.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_2.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_2.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewFilterTextBoxColumn_6,
				this.dataGridViewFilterTextBoxColumn_7,
				this.dataGridViewFilterTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_48,
				this.dataGridViewFilterTextBoxColumn_9,
				this.dataGridViewFilterTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_49,
				this.dataGridViewCheckBoxColumn_0,
				this.dataGridViewTextBoxColumn_50,
				this.dataGridViewFilterTextBoxColumn_11,
				this.dataGridViewTextBoxColumn_51,
				this.dataGridViewTextBoxColumn_52,
				this.dataGridViewTextBoxColumn_53,
				this.dataGridViewTextBoxColumn_54,
				this.dataGridViewFilterTextBoxColumn_12,
				this.dataGridViewFilterTextBoxColumn_13,
				this.dataGridViewFilterTextBoxColumn_14,
				this.dataGridViewFilterTextBoxColumn_15,
				this.dataGridViewFilterTextBoxColumn_16,
				this.dataGridViewTextBoxColumn_55,
				this.dataGridViewTextBoxColumn_56,
				this.dataGridViewTextBoxColumn_57,
				this.dataGridViewTextBoxColumn_58,
				this.dataGridViewTextBoxColumn_59,
				this.dataGridViewFilterTextBoxColumn_17,
				this.dataGridViewFilterTextBoxColumn_18
			});
			this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
			this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_2.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_2.Name = "dgvListLegal";
			this.dataGridViewExcelFilter_2.ReadOnly = true;
			this.dataGridViewExcelFilter_2.Size = new Size(898, 207);
			this.dataGridViewExcelFilter_2.TabIndex = 0;
			this.dataGridViewExcelFilter_2.Tag = "Юридические лица";
			this.dataGridViewExcelFilter_2.CellDoubleClick += this.dataGridViewExcelFilter_2_CellDoubleClick;
			this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "subname";
			this.dataGridViewFilterTextBoxColumn_6.HeaderText = "ПС";
			this.dataGridViewFilterTextBoxColumn_6.Name = "subnameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_6.Width = 65;
			this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "busname";
			this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Шина";
			this.dataGridViewFilterTextBoxColumn_7.Name = "busnameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_7.Width = 55;
			this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "CellName";
			this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Ячейка";
			this.dataGridViewFilterTextBoxColumn_8.Name = "cellNameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_8.Width = 55;
			this.dataGridViewTextBoxColumn_48.DataPropertyName = "idAbn";
			this.dataGridViewTextBoxColumn_48.HeaderText = "idAbn";
			this.dataGridViewTextBoxColumn_48.Name = "idAbnListLegalDgvColumn";
			this.dataGridViewTextBoxColumn_48.ReadOnly = true;
			this.dataGridViewTextBoxColumn_48.Visible = false;
			this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "codeAbonent";
			this.dataGridViewFilterTextBoxColumn_9.HeaderText = "№ договора";
			this.dataGridViewFilterTextBoxColumn_9.Name = "codeAbnListlegalDgvColumn";
			this.dataGridViewFilterTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_9.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_9.Width = 70;
			this.dataGridViewFilterTextBoxColumn_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "nameAbn";
			this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Абонент";
			this.dataGridViewFilterTextBoxColumn_10.Name = "nameAbnDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_10.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_49.DataPropertyName = "typeAbn";
			this.dataGridViewTextBoxColumn_49.HeaderText = "typeAbn";
			this.dataGridViewTextBoxColumn_49.Name = "typeAbnDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_49.ReadOnly = true;
			this.dataGridViewTextBoxColumn_49.Visible = false;
			this.dataGridViewCheckBoxColumn_0.DataPropertyName = "aBnActive";
			this.dataGridViewCheckBoxColumn_0.HeaderText = "aBnActive";
			this.dataGridViewCheckBoxColumn_0.Name = "aBnActiveDataGridViewCheckBoxColumn";
			this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_50.DataPropertyName = "idAbnObj";
			this.dataGridViewTextBoxColumn_50.HeaderText = "idAbnObj";
			this.dataGridViewTextBoxColumn_50.Name = "idAbnObjListLegalDvColumn";
			this.dataGridViewTextBoxColumn_50.ReadOnly = true;
			this.dataGridViewTextBoxColumn_50.Visible = false;
			this.dataGridViewFilterTextBoxColumn_11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "nameObj";
			this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Объект";
			this.dataGridViewFilterTextBoxColumn_11.Name = "nameObjDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_11.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_51.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_51.HeaderText = "id";
			this.dataGridViewTextBoxColumn_51.Name = "idDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_51.ReadOnly = true;
			this.dataGridViewTextBoxColumn_51.Visible = false;
			this.dataGridViewTextBoxColumn_52.DataPropertyName = "streetname";
			this.dataGridViewTextBoxColumn_52.HeaderText = "streetname";
			this.dataGridViewTextBoxColumn_52.Name = "streetnameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_52.ReadOnly = true;
			this.dataGridViewTextBoxColumn_52.Visible = false;
			this.dataGridViewTextBoxColumn_53.DataPropertyName = "house";
			this.dataGridViewTextBoxColumn_53.HeaderText = "house";
			this.dataGridViewTextBoxColumn_53.Name = "houseDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_53.ReadOnly = true;
			this.dataGridViewTextBoxColumn_53.Visible = false;
			this.dataGridViewTextBoxColumn_54.DataPropertyName = "objActive";
			this.dataGridViewTextBoxColumn_54.HeaderText = "objActive";
			this.dataGridViewTextBoxColumn_54.Name = "objActiveDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_54.ReadOnly = true;
			this.dataGridViewTextBoxColumn_54.Visible = false;
			this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "CategoryName";
			this.dataGridViewFilterTextBoxColumn_12.HeaderText = "Кат";
			this.dataGridViewFilterTextBoxColumn_12.Name = "categoryNameDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_12.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_12.Width = 40;
			this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "TarifName";
			this.dataGridViewFilterTextBoxColumn_13.HeaderText = "Тар";
			this.dataGridViewFilterTextBoxColumn_13.Name = "tarifNameDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_13.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_13.Width = 40;
			this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "PowerSet";
			this.dataGridViewFilterTextBoxColumn_14.HeaderText = "Уст мощность";
			this.dataGridViewFilterTextBoxColumn_14.Name = "powerSetDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_14.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "PowerFact";
			this.dataGridViewFilterTextBoxColumn_15.HeaderText = "Факт мощность";
			this.dataGridViewFilterTextBoxColumn_15.Name = "powerFactDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_15.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_16.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "contact";
			this.dataGridViewFilterTextBoxColumn_16.FillWeight = 70f;
			this.dataGridViewFilterTextBoxColumn_16.HeaderText = "Телефоны";
			this.dataGridViewFilterTextBoxColumn_16.Name = "contactDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_16.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_55.DataPropertyName = "idSchmObj";
			this.dataGridViewTextBoxColumn_55.HeaderText = "idSchmObj";
			this.dataGridViewTextBoxColumn_55.Name = "idSchmObjDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_55.ReadOnly = true;
			this.dataGridViewTextBoxColumn_55.Visible = false;
			this.dataGridViewTextBoxColumn_56.DataPropertyName = "cellId";
			this.dataGridViewTextBoxColumn_56.HeaderText = "cellId";
			this.dataGridViewTextBoxColumn_56.Name = "cellIdDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_56.ReadOnly = true;
			this.dataGridViewTextBoxColumn_56.Visible = false;
			this.dataGridViewTextBoxColumn_57.DataPropertyName = "busid";
			this.dataGridViewTextBoxColumn_57.HeaderText = "busid";
			this.dataGridViewTextBoxColumn_57.Name = "busidDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_57.ReadOnly = true;
			this.dataGridViewTextBoxColumn_57.Visible = false;
			this.dataGridViewTextBoxColumn_58.DataPropertyName = "subid";
			this.dataGridViewTextBoxColumn_58.HeaderText = "subid";
			this.dataGridViewTextBoxColumn_58.Name = "subidDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_58.ReadOnly = true;
			this.dataGridViewTextBoxColumn_58.Visible = false;
			this.dataGridViewTextBoxColumn_59.DataPropertyName = "schmObjName";
			this.dataGridViewTextBoxColumn_59.HeaderText = "schmObjName";
			this.dataGridViewTextBoxColumn_59.Name = "schmObjNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_59.ReadOnly = true;
			this.dataGridViewTextBoxColumn_59.Visible = false;
			this.dataGridViewFilterTextBoxColumn_17.DataPropertyName = "AbnNet";
			this.dataGridViewFilterTextBoxColumn_17.HeaderText = "Сетевая орг-ция";
			this.dataGridViewFilterTextBoxColumn_17.Name = "abnNetdgvColumn";
			this.dataGridViewFilterTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_18.DataPropertyName = "abnServicing";
			this.dataGridViewFilterTextBoxColumn_18.HeaderText = "Обслуж-ая орг-ция";
			this.dataGridViewFilterTextBoxColumn_18.Name = "abnServicingdgvColumn";
			this.dataGridViewFilterTextBoxColumn_18.ReadOnly = true;
			this.bindingSource_2.DataMember = "vL_SchmAbnFull";
			this.bindingSource_2.DataSource = this.dataSetScheme_0;
			this.bindingSource_2.CurrentChanged += this.bindingSource_2_CurrentChanged;
			this.splitContainer_1.Dock = DockStyle.Fill;
			this.splitContainer_1.Location = new Point(0, 0);
			this.splitContainer_1.Name = "splitContainer1";
			this.splitContainer_1.Panel1.Controls.Add(this.dataGridViewExcelFilter_3);
			this.splitContainer_1.Panel2.Controls.Add(this.dataGridViewExcelFilter_4);
			this.splitContainer_1.Size = new Size(898, 203);
			this.splitContainer_1.SplitterDistance = 453;
			this.splitContainer_1.TabIndex = 0;
			this.dataGridViewExcelFilter_3.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_3.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_3.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewFilterTextBoxColumn_0,
				this.dataGridViewFilterTextBoxColumn_1,
				this.dataGridViewFilterTextBoxColumn_2,
				this.dataGridViewFilterTextBoxColumn_3,
				this.dataGridViewFilterTextBoxColumn_4,
				this.dataGridViewFilterTextBoxColumn_5
			});
			this.dataGridViewExcelFilter_3.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_3.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_3.Name = "dgvListPrv";
			this.dataGridViewExcelFilter_3.ReadOnly = true;
			this.dataGridViewExcelFilter_3.Size = new Size(453, 203);
			this.dataGridViewExcelFilter_3.TabIndex = 0;
			this.dataGridViewExcelFilter_3.Tag = "Физические лица";
			this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "subName";
			this.dataGridViewFilterTextBoxColumn_0.HeaderText = "ПС";
			this.dataGridViewFilterTextBoxColumn_0.Name = "Column1";
			this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "busname";
			this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Шина";
			this.dataGridViewFilterTextBoxColumn_1.Name = "Column7";
			this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "cellname";
			this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Ячейка";
			this.dataGridViewFilterTextBoxColumn_2.Name = "Column8";
			this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "streetname";
			this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Улица";
			this.dataGridViewFilterTextBoxColumn_3.Name = "Column9";
			this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "house";
			this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Дом";
			this.dataGridViewFilterTextBoxColumn_4.Name = "Column10";
			this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "countAbn";
			this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Кол-во аб-ов";
			this.dataGridViewFilterTextBoxColumn_5.Name = "Column11";
			this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
			this.dataGridViewExcelFilter_4.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_4.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_4.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_4.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_4.BackgroundColor = Color.White;
			this.dataGridViewExcelFilter_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_4.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_14,
				this.dataGridViewTextBoxColumn_15,
				this.dataGridViewTextBoxColumn_16,
				this.dataGridViewTextBoxColumn_17,
				this.dataGridViewTextBoxColumn_18,
				this.dataGridViewTextBoxColumn_19,
				this.dataGridViewTextBoxColumn_20,
				this.dataGridViewTextBoxColumn_21,
				this.dataGridViewTextBoxColumn_22,
				this.dataGridViewTextBoxColumn_23
			});
			this.dataGridViewExcelFilter_4.DataSource = this.bindingSource_1;
			this.dataGridViewExcelFilter_4.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_4.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_4.MultiSelect = false;
			this.dataGridViewExcelFilter_4.Name = "dgvListLegalContact";
			this.dataGridViewExcelFilter_4.ReadOnly = true;
			this.dataGridViewExcelFilter_4.RowHeadersWidth = 21;
			this.dataGridViewExcelFilter_4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_4.Size = new Size(441, 203);
			this.dataGridViewExcelFilter_4.TabIndex = 4;
			this.dataGridViewTextBoxColumn_14.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_14.HeaderText = "id";
			this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewTextBoxColumn_14.Visible = false;
			this.dataGridViewTextBoxColumn_15.DataPropertyName = "idAbn";
			this.dataGridViewTextBoxColumn_15.HeaderText = "idAbn";
			this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_15.Visible = false;
			this.dataGridViewTextBoxColumn_16.DataPropertyName = "Post";
			this.dataGridViewTextBoxColumn_16.HeaderText = "Должность";
			this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewTextBoxColumn_17.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_17.DataPropertyName = "F";
			this.dataGridViewTextBoxColumn_17.HeaderText = "Фамилия";
			this.dataGridViewTextBoxColumn_17.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewTextBoxColumn_18.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_18.DataPropertyName = "I";
			this.dataGridViewTextBoxColumn_18.HeaderText = "Имя";
			this.dataGridViewTextBoxColumn_18.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_18.ReadOnly = true;
			this.dataGridViewTextBoxColumn_19.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_19.DataPropertyName = "O";
			this.dataGridViewTextBoxColumn_19.HeaderText = "Отчество";
			this.dataGridViewTextBoxColumn_19.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_19.ReadOnly = true;
			this.dataGridViewTextBoxColumn_20.DataPropertyName = "Phone";
			this.dataGridViewTextBoxColumn_20.HeaderText = "Телефон";
			this.dataGridViewTextBoxColumn_20.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn_20.ReadOnly = true;
			this.dataGridViewTextBoxColumn_21.DataPropertyName = "DateChange";
			this.dataGridViewTextBoxColumn_21.HeaderText = "DateChange";
			this.dataGridViewTextBoxColumn_21.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn_21.ReadOnly = true;
			this.dataGridViewTextBoxColumn_21.Visible = false;
			this.dataGridViewTextBoxColumn_22.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_22.HeaderText = "Коментарий";
			this.dataGridViewTextBoxColumn_22.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn_22.ReadOnly = true;
			this.dataGridViewTextBoxColumn_22.Width = 120;
			this.dataGridViewTextBoxColumn_23.DataPropertyName = "email";
			this.dataGridViewTextBoxColumn_23.HeaderText = "e`mail";
			this.dataGridViewTextBoxColumn_23.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn_23.ReadOnly = true;
			this.tabPage_3.Controls.Add(this.splitContainer_3);
			this.tabPage_3.Location = new Point(4, 4);
			this.tabPage_3.Name = "tabPageGroup";
			this.tabPage_3.Padding = new Padding(3);
			this.tabPage_3.Size = new Size(904, 420);
			this.tabPage_3.TabIndex = 1;
			this.tabPage_3.Text = "Группировка";
			this.tabPage_3.UseVisualStyleBackColor = true;
			this.splitContainer_3.Dock = DockStyle.Fill;
			this.splitContainer_3.Location = new Point(3, 3);
			this.splitContainer_3.Name = "splitContainer3";
			this.splitContainer_3.Orientation = Orientation.Horizontal;
			this.splitContainer_3.Panel1.Controls.Add(this.treeDataGridView_0);
			this.splitContainer_3.Panel2.Controls.Add(this.treeDataGridView_1);
			this.splitContainer_3.Size = new Size(898, 414);
			this.splitContainer_3.SplitterDistance = 207;
			this.splitContainer_3.TabIndex = 2;
			this.treeDataGridView_0.AllowUserToAddRows = false;
			this.treeDataGridView_0.AllowUserToDeleteRows = false;
			this.treeDataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.treeGridColumn_0,
				this.dataGridViewTextBoxColumn_24,
				this.dataGridViewTextBoxColumn_25,
				this.dataGridViewTextBoxColumn_26,
				this.dataGridViewTextBoxColumn_27,
				this.dataGridViewTextBoxColumn_28,
				this.dataGridViewTextBoxColumn_29,
				this.dataGridViewTextBoxColumn_30,
				this.dataGridViewTextBoxColumn_31,
				this.dataGridViewTextBoxColumn_32
			});
			this.treeDataGridView_0.Dock = DockStyle.Fill;
			this.treeDataGridView_0.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.treeDataGridView_0.ImageList = null;
			this.treeDataGridView_0.Location = new Point(0, 0);
			this.treeDataGridView_0.Name = "dgvTRee";
			this.treeDataGridView_0.Size = new Size(898, 207);
			this.treeDataGridView_0.TabIndex = 1;
			this.treeGridColumn_0.DefaultNodeImage = null;
			this.treeGridColumn_0.HeaderText = "Подстанция\\шина";
			this.treeGridColumn_0.Name = "columnDgvSubstation";
			this.treeGridColumn_0.Resizable = DataGridViewTriState.True;
			this.treeGridColumn_0.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_24.HeaderText = "Ячейка";
			this.dataGridViewTextBoxColumn_24.Name = "Column3";
			this.dataGridViewTextBoxColumn_24.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_24.Width = 55;
			this.dataGridViewTextBoxColumn_25.HeaderText = "Код";
			this.dataGridViewTextBoxColumn_25.Name = "Column2";
			this.dataGridViewTextBoxColumn_25.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_25.Width = 55;
			this.dataGridViewTextBoxColumn_26.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_26.HeaderText = "Абонент";
			this.dataGridViewTextBoxColumn_26.Name = "Column4";
			this.dataGridViewTextBoxColumn_26.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_27.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_27.HeaderText = "Объект";
			this.dataGridViewTextBoxColumn_27.Name = "Column5";
			this.dataGridViewTextBoxColumn_27.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_28.HeaderText = "Кат";
			this.dataGridViewTextBoxColumn_28.Name = "Column6";
			this.dataGridViewTextBoxColumn_28.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_28.Width = 60;
			this.dataGridViewTextBoxColumn_29.HeaderText = "Тар";
			this.dataGridViewTextBoxColumn_29.Name = "Column12";
			this.dataGridViewTextBoxColumn_29.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_29.Width = 50;
			this.dataGridViewTextBoxColumn_30.HeaderText = "Уст мощность";
			this.dataGridViewTextBoxColumn_30.Name = "Column13";
			this.dataGridViewTextBoxColumn_30.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_31.HeaderText = "Факт мощность";
			this.dataGridViewTextBoxColumn_31.Name = "Column14";
			this.dataGridViewTextBoxColumn_31.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_32.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_32.FillWeight = 70f;
			this.dataGridViewTextBoxColumn_32.HeaderText = "Телефоны";
			this.dataGridViewTextBoxColumn_32.Name = "Column15";
			this.dataGridViewTextBoxColumn_32.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.treeDataGridView_1.AllowUserToAddRows = false;
			this.treeDataGridView_1.AllowUserToDeleteRows = false;
			this.treeDataGridView_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.treeGridColumn_1,
				this.dataGridViewTextBoxColumn_60,
				this.dataGridViewTextBoxColumn_61,
				this.dataGridViewTextBoxColumn_62,
				this.dataGridViewTextBoxColumn_63,
				this.dataGridViewTextBoxColumn_64,
				this.dataGridViewTextBoxColumn_65
			});
			this.treeDataGridView_1.Dock = DockStyle.Fill;
			this.treeDataGridView_1.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.treeDataGridView_1.ImageList = null;
			this.treeDataGridView_1.Location = new Point(0, 0);
			this.treeDataGridView_1.Name = "dgvTreePrv";
			this.treeDataGridView_1.Size = new Size(898, 203);
			this.treeDataGridView_1.TabIndex = 2;
			this.tabPage_0.Controls.Add(this.splitContainer_2);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tabPageOld";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(937, 434);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Старая база";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.splitContainer_2.Dock = DockStyle.Fill;
			this.splitContainer_2.FixedPanel = FixedPanel.Panel2;
			this.splitContainer_2.Location = new Point(3, 3);
			this.splitContainer_2.Name = "splitContainer2";
			this.splitContainer_2.Orientation = Orientation.Horizontal;
			this.splitContainer_2.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
			this.splitContainer_2.Panel1.Controls.Add(this.label_0);
			this.splitContainer_2.Panel1.Controls.Add(this.dataGridViewExcelFilter_1);
			this.splitContainer_2.Panel2.Controls.Add(this.label_1);
			this.splitContainer_2.Panel2.Controls.Add(this.dataGridView_0);
			this.splitContainer_2.Size = new Size(931, 428);
			this.splitContainer_2.SplitterDistance = 294;
			this.splitContainer_2.TabIndex = 8;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(5, 11);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(36, 13);
			this.label_1.TabIndex = 7;
			this.label_1.Text = "Дома";
			this.panel_0.BackColor = SystemColors.Control;
			this.panel_0.Controls.Add(this.label_2);
			this.panel_0.Controls.Add(this.progressBarEndLess_0);
			this.panel_0.Location = new Point(280, 128);
			this.panel_0.Name = "panelProgress";
			this.panel_0.Size = new Size(431, 74);
			this.panel_0.TabIndex = 6;
			this.panel_0.Visible = false;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(125, 11);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(194, 13);
			this.label_2.TabIndex = 6;
			this.label_2.Text = "Подождите... Идет загрузка из базы";
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
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
			this.treeGridColumn_1.DefaultNodeImage = null;
			this.treeGridColumn_1.HeaderText = "Подстанция\\шина";
			this.treeGridColumn_1.Name = "Column16";
			this.treeGridColumn_1.Resizable = DataGridViewTriState.True;
			this.treeGridColumn_1.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_60.HeaderText = "Ячейка";
			this.dataGridViewTextBoxColumn_60.Name = "Column17";
			this.dataGridViewTextBoxColumn_60.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_61.HeaderText = "Код";
			this.dataGridViewTextBoxColumn_61.Name = "Column18";
			this.dataGridViewTextBoxColumn_61.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_62.HeaderText = "Абонент";
			this.dataGridViewTextBoxColumn_62.Name = "Column19";
			this.dataGridViewTextBoxColumn_62.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_63.HeaderText = "Улица";
			this.dataGridViewTextBoxColumn_63.Name = "Column20";
			this.dataGridViewTextBoxColumn_63.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_64.HeaderText = "Дом";
			this.dataGridViewTextBoxColumn_64.Name = "Column21";
			this.dataGridViewTextBoxColumn_64.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_65.HeaderText = "Квартира";
			this.dataGridViewTextBoxColumn_65.Name = "Column22";
			this.dataGridViewTextBoxColumn_65.SortMode = DataGridViewColumnSortMode.NotSortable;
			base.AcceptButton = this.button_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(945, 529);
			base.Controls.Add(this.panel_0);
			base.Controls.Add(this.tabControl_0);
			base.Controls.Add(this.toolStrip_0);
			base.Controls.Add(this.button_0);
			this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.MinimumSize = new Size(774, 424);
			base.Name = "FormAbnFromOldSchema";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Абоненты ";
			base.DockStateChanged += this.FormAbnFromOldSchema_DockStateChanged;
			base.Load += this.FormAbnFromOldSchema_Load;
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dataSetScheme_0).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			((ISupportInitialize)this.dataGridViewExcelFilter_0).EndInit();
			((ISupportInitialize)this.dataGridViewExcelFilter_1).EndInit();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			((ISupportInitialize)this.dataSet_0).EndInit();
			((ISupportInitialize)this.dataTable_0).EndInit();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_1.ResumeLayout(false);
			this.tabControlVertical_0.ResumeLayout(false);
			this.tabPage_2.ResumeLayout(false);
			this.splitContainer_0.Panel1.ResumeLayout(false);
			this.splitContainer_0.Panel2.ResumeLayout(false);
			this.splitContainer_0.ResumeLayout(false);
			((ISupportInitialize)this.dataGridViewExcelFilter_2).EndInit();
			((ISupportInitialize)this.bindingSource_2).EndInit();
			this.splitContainer_1.Panel1.ResumeLayout(false);
			this.splitContainer_1.Panel2.ResumeLayout(false);
			this.splitContainer_1.ResumeLayout(false);
			((ISupportInitialize)this.dataGridViewExcelFilter_3).EndInit();
			((ISupportInitialize)this.dataGridViewExcelFilter_4).EndInit();
			this.tabPage_3.ResumeLayout(false);
			this.splitContainer_3.Panel1.ResumeLayout(false);
			this.splitContainer_3.Panel2.ResumeLayout(false);
			this.splitContainer_3.ResumeLayout(false);
			((ISupportInitialize)this.treeDataGridView_0).EndInit();
			((ISupportInitialize)this.treeDataGridView_1).EndInit();
			this.tabPage_0.ResumeLayout(false);
			this.splitContainer_2.Panel1.ResumeLayout(false);
			this.splitContainer_2.Panel1.PerformLayout();
			this.splitContainer_2.Panel2.ResumeLayout(false);
			this.splitContainer_2.Panel2.PerformLayout();
			this.splitContainer_2.ResumeLayout(false);
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			((ISupportInitialize)this.bindingSource_3).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public FormAbnFromOldSchema()
		{
			this.method_0();
			this.bindingSource_0.CurrentChanged += this.bindingSource_0_CurrentChanged;
		}

		public FormAbnFromOldSchema(DrawObjectBase drawObjectBase_0, bool nextObj, SQLSettings sqlSettings)
		{
			this.method_0();
			this.int_0 = drawObjectBase_0.IdBase;
			this.bool_0 = nextObj;
			this.SqlSettings = sqlSettings;
			if (nextObj)
			{
				List<DrawObjectBase> list = new List<DrawObjectBase>();
				if (drawObjectBase_0 is RectangleTool)
				{
					list = ((RectangleTool)drawObjectBase_0).GetRecipientsPower();
				}
				if (drawObjectBase_0 is ShinaTool)
				{
					list = ((ShinaTool)drawObjectBase_0).GetRecipientsPower();
				}
				if (drawObjectBase_0 is LineTool)
				{
					list = ((LineTool)drawObjectBase_0).GetRecipientsPower();
				}
				IEnumerable<DrawObjectBase> source = list;
				if (FormAbnFromOldSchema.func_0 == null)
				{
					FormAbnFromOldSchema.func_0 = new Func<DrawObjectBase, bool>(FormAbnFromOldSchema.smethod_0);
				}
				foreach (DrawObjectBase drawObjectBase in source.Where(FormAbnFromOldSchema.func_0))
				{
					if (!this.list_0.Contains((RectangleTool)drawObjectBase.Parent))
					{
						this.list_0.Add((RectangleTool)drawObjectBase.Parent);
					}
				}
				if (this.list_0.Count > 0)
				{
					this.Text = this.Text + this.list_0[0].ToString() + " и далее...";
				}
			}
			else
			{
				if (drawObjectBase_0 is RectangleTool)
				{
					this.list_0.Add((RectangleTool)drawObjectBase_0);
				}
				else if (drawObjectBase_0.Parent != null && drawObjectBase_0.Parent is RectangleTool)
				{
					this.list_0.Add((RectangleTool)drawObjectBase_0.Parent);
				}
				if (this.list_0.Count > 0)
				{
					this.Text += this.list_0[0].ToString();
				}
			}
			this.bindingSource_0.Sort = "codeAbonent";
			this.bindingSource_0.CurrentChanged += this.bindingSource_0_CurrentChanged;
		}

		private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
		{
			DataSetScheme.Class67 @class = (DataSetScheme.Class67)((DataRowView)this.bindingSource_0.Current).Row;
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tAbnContact, true, "where [idAbn] = " + @class.method_0());
		}

		private void FormAbnFromOldSchema_Load(object sender, EventArgs e)
		{
			this.method_2();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			string text = string.Empty;
			foreach (RectangleTool rectangleTool in this.list_0)
			{
				if (text != string.Empty)
				{
					text += ", ";
				}
				string text2 = text;
				text = string.Concat(new string[]
				{
					text2,
					"'",
					rectangleTool.Text,
					"', '",
					rectangleTool.ToString(),
					"'"
				});
			}
			if (text != string.Empty)
			{
				sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.v_AbnObjRazresh, true, "where [tpname] in (" + text + ") group by idabn, codeAbonent, nameAbn, idObj, nameObj, categoryName, tariffname, razresh, tpname, bushigh, buslow, rubilnik,power, id_razr, contact ");
				this.bindingSource_0.Position = 0;
				try
				{
					SQLSettings sqlSett = new SQLSettings("ulges-sql", "Scheme_NL", "WINDOWS", "", "");
					SqlDataCommand sqlDataCommand2 = new SqlDataCommand(sqlSett);
					sqlDataCommand2.SelectSqlData(this.dataSet_0, this.dataTable_0, false, "where [group] in (" + text + ") order by street, inthouse");
				}
				catch
				{
				}
			}
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			if (this.tabControl_0.SelectedTab == this.tabPage_0)
			{
				this.dataGridViewExcelFilter_0.CopyToExcel(true);
			}
			if (this.tabControl_0.SelectedTab == this.tabPage_1)
			{
				this.method_1(new DataGridView[]
				{
					this.dataGridViewExcelFilter_3,
					this.dataGridViewExcelFilter_2
				});
			}
		}

		private void method_1(params DataGridView[] dataGridView_1)
		{
			_Application application = new ApplicationClass();
			_Workbook workbook = application.Workbooks.Add(Type.Missing);
			for (int i = 0; i < dataGridView_1.Length; i++)
			{
				DataGridView dataGridView = dataGridView_1[i];
				application.Visible = false;
				_Worksheet worksheet;
				if (i == workbook.Worksheets.Count - 1)
				{
					worksheet = (Worksheet)workbook.Worksheets.get__Default(i + 1);
				}
				else
				{
					worksheet = (Worksheet)workbook.Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				}
				if (dataGridView.Tag != null)
				{
					worksheet.Name = dataGridView.Tag.ToString();
				}
				else
				{
					worksheet.Name = "Exported from gridview";
				}
				int num = 0;
				for (int j = 0; j < dataGridView.Columns.Count; j++)
				{
					if (dataGridView.Columns[j].Visible)
					{
						int num2 = dataGridView.Columns[j].DisplayIndex + 1 - num;
						worksheet.Cells.set__Default(1, num2, dataGridView.Columns[j].HeaderText);
						((Range)worksheet.Cells.get__Default(1, num2)).Font.Bold = true;
					}
					else
					{
						num++;
					}
				}
				for (int k = 0; k < dataGridView.Rows.Count; k++)
				{
					num = 0;
					for (int l = 0; l < dataGridView.Columns.Count; l++)
					{
						if (dataGridView.Columns[l].Visible)
						{
							int num3 = dataGridView.Columns[l].DisplayIndex + 1 - num;
							worksheet.Cells.set__Default(k + 2, num3, dataGridView.Rows[k].Cells[l].Value.ToString());
							((Range)worksheet.Cells.get__Default(k + 2, num3)).WrapText = true;
						}
						else
						{
							num++;
						}
					}
				}
			}
			application.Visible = true;
		}

		private void FormAbnFromOldSchema_DockStateChanged(object sender, EventArgs e)
		{
			if (base.DockState == 1)
			{
				base.FloatPane.FindForm().FormBorderStyle = FormBorderStyle.Sizable;
			}
		}

		private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				int num = Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_34.Name, e.RowIndex].Value);
				int num2 = Convert.ToInt32(this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_36.Name, e.RowIndex].Value);
				new FormAbn(num, num2)
				{
					SqlSettings = this.SqlSettings,
					MdiParent = base.DockPanel.FindForm().MdiParent
				}.Show();
			}
		}

		private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if (this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_40.Name, e.RowIndex].Value != null)
				{
					if (this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_40.Name, e.RowIndex].Value != DBNull.Value)
					{
						e.CellStyle.ForeColor = Color.OrangeRed;
						return;
					}
				}
				e.CellStyle.ForeColor = Color.Green;
				return;
			}
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void method_2()
		{
			this.tabControlVertical_0.Enabled = false;
			this.panel_0.Visible = true;
			this.progressBarEndLess_0.AutoProgress = true;
			this.panel_0.Left = this.tabControlVertical_0.Width / 2 - this.progressBarEndLess_0.Width / 2;
			this.panel_0.Top = this.tabControlVertical_0.Height / 2 - this.progressBarEndLess_0.Height / 2;
			this.dataGridViewExcelFilter_2.DataSource = null;
			this.dataGridViewExcelFilter_3.DataSource = null;
			this.dataGridViewExcelFilter_4.DataSource = null;
			this.dataTable_1 = new DataTable("vL_SchmAbnFull");
			this.dataTable_1.Columns.Add("StreetName", typeof(string));
			this.dataTable_1.Columns.Add("house", typeof(string));
			this.dataTable_1.Columns.Add("subname", typeof(string));
			this.dataTable_1.Columns.Add("busname", typeof(string));
			this.dataTable_1.Columns.Add("cellname", typeof(string));
			this.dataTable_1.Columns.Add("countAbn", typeof(int));
			this.dataTable_2 = new DataTable("vL_SchmAbnFull");
			this.dataTable_2.Columns.Add("subname", typeof(string));
			this.dataTable_2.Columns.Add("busname", typeof(string));
			this.dataTable_2.Columns.Add("cellname", typeof(string));
			this.dataTable_2.Columns.Add("StreetName", typeof(string));
			this.dataTable_2.Columns.Add("house", typeof(string));
			this.bindingSource_3.DataSource = this.dataTable_1;
			this.backgroundWorker_0.RunWorkerAsync();
		}

		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			ElectricModel electricModel = new ElectricModel();
			electricModel.SqlSettings = this.SqlSettings;
			electricModel.LoadSchema();
			IEnumerable<ElectricObject> source = electricModel.Objects.Where(new Func<ElectricObject, bool>(this.method_3));
			if (source.Count<ElectricObject>() > 0)
			{
				Func<ElectricObject, bool> func = null;
				Func<ElectricObject, bool> func2 = null;
				FormAbnFromOldSchema.Class0 @class = new FormAbnFromOldSchema.Class0();
				@class.electricObject_0 = source.First<ElectricObject>();
				@class.electricObject_1 = null;
				if (!this.bool_0)
				{
					if (@class.electricObject_0 is ElectricSubstation)
					{
						@class.electricObject_1 = @class.electricObject_0;
					}
					if (@class.electricObject_0 is ElectricBus || (@class.electricObject_0 is ElectricLine && ((ElectricLine)@class.electricObject_0).IsCell()))
					{
						@class.electricObject_1 = @class.electricObject_0.Parent;
					}
				}
				List<ElectricObject> list = electricModel.PoweringReportForDrawObject(source.First<ElectricObject>(), true, true);
				string text = "";
				IEnumerable<ElectricObject> enumerable;
				if (this.bool_0)
				{
					enumerable = list;
				}
				else if (@class.electricObject_1 == null)
				{
					IEnumerable<ElectricObject> source2 = list;
					if (func == null)
					{
						func = new Func<ElectricObject, bool>(@class.method_0);
					}
					enumerable = source2.Where(func);
				}
				else
				{
					IEnumerable<ElectricObject> source3 = list;
					if (func2 == null)
					{
						func2 = new Func<ElectricObject, bool>(@class.method_1);
					}
					enumerable = source3.Where(func2);
				}
				if (enumerable != null)
				{
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
							string selectCommandText = "select streetname, house, subname, busname, cellname, count(*) as CountAbn from vl_SchmAbnFull where abnActive = 1 and ObjActive = 1 and typeabn in (206,253) and idSchmObj in (" + text + ")group by streetname, house, subname, busname, cellname order by subname, busname, cellname, streetname, house ";
							SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommandText, sqlConnection);
							sqlDataAdapter.Fill(this.dataTable_1);
							string selectCommandText2 = "select subname, busname, cellname, streetname, house, codeAbonent, nameAbn, nameObj from vl_SchmAbnFull where abnActive = 1 and ObjActive = 1 and typeabn in (206,253) and idSchmObj in (" + text + ")order by subname, busname, cellname, streetname, house ";
							sqlDataAdapter = new SqlDataAdapter(selectCommandText2, sqlConnection);
							sqlDataAdapter.Fill(this.dataTable_2);
							string selectCommandText3 = "select idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj, id, streetname, house, categoryname, tarifname, powerset, powerfact, contact, idschmObj, cellid, cellname, busid, busname, subid, subname, abnnet from vl_SchmAbnFull where abnActive = 1 and objActive = 1 and idSchmObj in (" + text + ") and typeAbn in (207,231,230) group by idAbn, codeAbonent, nameAbn, typeAbn, idAbnObj, nameObj, id, streetname, house, categoryname, tarifname, powerset, powerfact, contact, idschmObj, cellid, cellname, busid, busname, subid, subname, abnnet  order by subname, busname, cellname, nameAbn, nameObj";
							sqlDataAdapter = new SqlDataAdapter(selectCommandText3, sqlConnection);
							sqlDataAdapter.Fill(this.dataSetScheme_0.vL_SchmAbnFull);
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, ex.Source);
						}
					}
				}
			}
		}

		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			string b = "";
			TreeDataGridViewNode treeDataGridViewNode = null;
			foreach (DataRow dataRow in this.dataSetScheme_0.vL_SchmAbnFull)
			{
				if (dataRow["subName"].ToString() != b)
				{
					b = dataRow["subname"].ToString();
					treeDataGridViewNode = this.treeDataGridView_0.Nodes.Add(new object[]
					{
						dataRow["subname"]
					});
					treeDataGridViewNode.Expand();
				}
				treeDataGridViewNode.Nodes.Add(new object[]
				{
					dataRow["busname"],
					dataRow["cellname"],
					dataRow["codeAbonent"],
					dataRow["nameAbn"],
					dataRow["nameObj"],
					dataRow["categoryname"],
					dataRow["tarifname"],
					dataRow["powerset"],
					dataRow["powerfact"],
					dataRow["contact"]
				});
			}
			foreach (object obj in this.dataTable_2.Rows)
			{
				DataRow dataRow2 = (DataRow)obj;
				if (dataRow2["subName"].ToString() != b)
				{
					b = dataRow2["subname"].ToString();
					treeDataGridViewNode = this.treeDataGridView_1.Nodes.Add(new object[]
					{
						dataRow2["subname"]
					});
					treeDataGridViewNode.Expand();
				}
				treeDataGridViewNode.Nodes.Add(new object[]
				{
					dataRow2["busname"],
					dataRow2["cellname"],
					dataRow2["CodeAbonent"],
					dataRow2["nameAbn"],
					dataRow2["Streetname"],
					dataRow2["house"],
					dataRow2["nameObj"]
				});
			}
			this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
			this.dataGridViewExcelFilter_3.DataSource = this.bindingSource_3;
			this.dataGridViewExcelFilter_4.DataSource = this.tAbnContactDataTable_0;
			this.tabControlVertical_0.Enabled = true;
			this.panel_0.Visible = false;
			this.progressBarEndLess_0.AutoProgress = false;
		}

		private void tabControlVertical_0_Resize(object sender, EventArgs e)
		{
			this.panel_0.Left = this.tabControlVertical_0.Width / 2 - this.progressBarEndLess_0.Width / 2;
			this.panel_0.Top = this.tabControlVertical_0.Height / 2 - this.progressBarEndLess_0.Height / 2;
		}

		private void bindingSource_2_CurrentChanged(object sender, EventArgs e)
		{
			if (this.bindingSource_2.Current != null)
			{
				int num = Convert.ToInt32(((DataRowView)this.bindingSource_2.Current).Row["idAbn"]);
				base.SelectSqlData(this.tAbnContactDataTable_0, true, "where [idAbn] = " + num, false);
				return;
			}
			this.tAbnContactDataTable_0.Clear();
		}

		private void dataGridViewExcelFilter_2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				int num = Convert.ToInt32(this.dataGridViewExcelFilter_2[this.dataGridViewFilterTextBoxColumn_9.Name, e.RowIndex].Value);
				int num2 = Convert.ToInt32(this.dataGridViewExcelFilter_2[this.dataGridViewTextBoxColumn_50.Name, e.RowIndex].Value);
				new FormAbn(num, num2)
				{
					SqlSettings = this.SqlSettings,
					MdiParent = base.DockPanel.FindForm().MdiParent
				}.Show();
			}
		}

		[CompilerGenerated]
		private static bool smethod_0(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(ShinaTool) && drawObjectBase_0.Parent != null;
		}

		[CompilerGenerated]
		private bool method_3(ElectricObject electricObject_0)
		{
			return electricObject_0.Id == this.int_0;
		}

		private IContainer icontainer_0;

		private Button button_0;

		private BindingSource bindingSource_0;

		private DataSetScheme dataSetScheme_0;

		private BindingSource bindingSource_1;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private DataGridViewExcelFilter dataGridViewExcelFilter_1;

		private Label label_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private DataSet dataSet_0;

		private DataTable dataTable_0;

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataGridView dataGridView_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private Label label_1;

		private TabPage tabPage_1;

		private DataGridViewExcelFilter dataGridViewExcelFilter_2;

		private BindingSource bindingSource_2;

		private BackgroundWorker backgroundWorker_0;

		private TreeDataGridView treeDataGridView_0;

		private TabControlVertical tabControlVertical_0;

		private TabPage tabPage_2;

		private TabPage tabPage_3;

		private Panel panel_0;

		private Label label_2;

		private ProgressBarEndLess progressBarEndLess_0;

		private SplitContainer splitContainer_0;

		private SplitContainer splitContainer_1;

		private DataGridViewExcelFilter dataGridViewExcelFilter_3;

		private BindingSource bindingSource_3;

		private DataGridViewExcelFilter dataGridViewExcelFilter_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

		private TreeGridColumn treeGridColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;

		private SplitContainer splitContainer_2;

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

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_12;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_13;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_14;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_15;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_17;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_18;

		private SplitContainer splitContainer_3;

		private TreeDataGridView treeDataGridView_1;

		private TreeGridColumn treeGridColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_64;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_65;

		private List<RectangleTool> list_0 = new List<RectangleTool>();

		private int int_0 = -1;

		private bool bool_0;

		private DataSetScheme.tAbnContactDataTable tAbnContactDataTable_0 = new DataSetScheme.tAbnContactDataTable();

		private DataTable dataTable_1;

		private DataTable dataTable_2;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_0;

		[CompilerGenerated]
		private sealed class Class0
		{
			public bool method_0(ElectricObject electricObject_2)
			{
				return electricObject_2 == this.electricObject_0;
			}

			public bool method_1(ElectricObject electricObject_2)
			{
				return electricObject_2 == this.electricObject_0 || electricObject_2 == this.electricObject_1 || electricObject_2.Parent == this.electricObject_1;
			}

			public ElectricObject electricObject_0;

			public ElectricObject electricObject_1;
		}
	}
}
