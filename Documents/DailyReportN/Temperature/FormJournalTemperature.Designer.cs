using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DailyReportN.Temperature
{
	public partial class FormJournalTemperature : FormLbr.FormBase
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            ComponentResourceManager resource = new ComponentResourceManager(typeof(FormJournalTemperature));

            ChartArea ChartArea1 = new ChartArea();
            ChartArea chartArea2 = new ChartArea();
            Legend legend = new Legend();
            Series seriesNight = new Series();
            Series seriesDay = new Series();
            Series seriesSpeed = new Series();

            this.toolStrip = new ToolStrip();
            this.toolBtnAdd = new ToolStripButton();
            this.toolBtnEdit = new ToolStripButton();
            this.toolBtnDel = new ToolStripButton();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.toolBtnRefresh = new ToolStripButton();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolBtnFind = new ToolStripButton();
            this.txtFind = new ToolStripTextBox();
            this.toolBtnFindPrev = new ToolStripButton();
            this.toolBtnFindNext = new ToolStripButton();
            this.dgv = new DataGridViewExcelFilter();
            this.toolBtnLoadOldBase = new ToolStripButton();
            this.bsTemperature = new BindingSource(this.components);
            this.dsDamage = new DailyReportN.DataSet.dsDamage();
            this.dateTempDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nightColumn = new DataGridViewFilterTextBoxColumn();
            this.nightDownDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.nightUpDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.dayColumn = new DataGridViewFilterTextBoxColumn();
            this.dayDownDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.dayUpDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.tempAverageDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.windDgvColumn = new DataGridViewFilterComboBoxColumn();
            this.speedColumn = new DataGridViewFilterTextBoxColumn();
            this.speedDownDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.speedUpDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.dateOwnerDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.idOwnerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.chartAbnObjPayment = new Chart();
            this.tabControlVertical1 = new TabControlVertical();
            this.tabPage1 = new TabPage();
            this.tabPage2 = new TabPage();
            this.toolStrip.SuspendLayout();
            ((ISupportInitialize)this.dgv).BeginInit();
            ((ISupportInitialize)this.bsTemperature).BeginInit();
            ((ISupportInitialize)this.dsDamage).BeginInit();
            ((ISupportInitialize)this.chartAbnObjPayment).BeginInit();
            this.tabControlVertical1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            base.SuspendLayout();
            this.toolStrip.Items.AddRange(new ToolStripItem[]
            {
                this.toolBtnAdd,
                this.toolBtnEdit,
                this.toolBtnDel,
                this.toolStripSeparator1,
                this.toolBtnRefresh,
                this.toolStripSeparator2,
                this.toolBtnFind,
                this.txtFind,
                this.toolBtnFindPrev,
                this.toolBtnFindNext,
                this.toolBtnLoadOldBase
            });
            this.toolStrip.Location = new Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new Size(1327, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            this.toolBtnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnAdd.Image = global::DailyReportN.Properties.Resources.ElementAdd;
            this.toolBtnAdd.ImageTransparentColor = Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new Size(23, 22);
            this.toolBtnAdd.Text = "toolStripButton1";
            this.toolBtnAdd.Click +=new System.EventHandler (this.toolBtnAdd_Click);

            this.toolBtnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnEdit.Image = global::DailyReportN.Properties.Resources.ElementEdit;
            this.toolBtnEdit.ImageTransparentColor = Color.Magenta;
            this.toolBtnEdit.Name = "toolBtnEdit";
            this.toolBtnEdit.Size = new Size(23, 22);
            this.toolBtnEdit.Text = "toolStripButton2";
            this.toolBtnEdit.Click +=new System.EventHandler( this.toolBtnEdit_Click);
            this.toolBtnDel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnDel.Image = global::DailyReportN.Properties.Resources.ElementDel;
            this.toolBtnDel.ImageTransparentColor = Color.Magenta;
            this.toolBtnDel.Name = "toolBtnDel";
            this.toolBtnDel.Size = new Size(23, 22);
            this.toolBtnDel.Text = "toolStripButton3";
            this.toolBtnDel.Click +=new System.EventHandler( this.toolBtnDel_Click);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(6, 25);
            this.toolBtnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnRefresh.Image = global::DailyReportN.Properties.Resources.refresh_16;
            this.toolBtnRefresh.ImageTransparentColor = Color.Magenta;
            this.toolBtnRefresh.Name = "toolBtnRefresh";
            this.toolBtnRefresh.Size = new Size(23, 22);
            this.toolBtnRefresh.Text = "toolStripButton4";
            this.toolBtnRefresh.Click += new System.EventHandler(this.toolBtnRefresh_Click);
            
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(6, 25);
            this.toolBtnFind.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFind.Image = global::DailyReportN.Properties.Resources.Find;
            this.toolBtnFind.ImageTransparentColor = Color.Magenta;
            this.toolBtnFind.Name = "toolBtnFind";
            this.toolBtnFind.Size = new Size(23, 22);
            this.toolBtnFind.Text = "toolStripButton5";
            this.toolBtnFind.Click +=new System.EventHandler (this.toolBtnFind_Click);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new Size(100, 25);
            this.txtFind.KeyDown += new KeyEventHandler(this.txtFind_KeyDown);

            this.toolBtnFindPrev.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrev.Image = global::DailyReportN.Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new Size(23, 22);
            this.toolBtnFindPrev.Text = "toolStripButton6";
            this.toolBtnFindPrev.Click +=new System.EventHandler (this.toolBtnFindPrev_Click);
            this.toolBtnFindNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNext.Image = global::DailyReportN.Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new Size(23, 22);
            this.toolBtnFindNext.Text = "toolStripButton7";
            this.toolBtnFindNext.Click +=new System.EventHandler( this.toolBtnFindNext_Click);
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new DataGridViewColumn[]
            {
                this.dateTempDataGridViewTextBoxColumn,
                this.idDataGridViewTextBoxColumn,
                this.nightColumn,
                this.nightDownDataGridViewTextBoxColumn,
                this.nightUpDataGridViewTextBoxColumn,
                this.dayColumn,
                this.dayDownDataGridViewTextBoxColumn,
                this.dayUpDataGridViewTextBoxColumn,
                this.tempAverageDataGridViewTextBoxColumn,
                this.windDgvColumn,
                this.speedColumn,
                this.speedDownDataGridViewTextBoxColumn,
                this.speedUpDataGridViewTextBoxColumn,
                this.commentDataGridViewTextBoxColumn,
                this.dateOwnerDataGridViewTextBoxColumn,
                this.idOwnerDataGridViewTextBoxColumn,
                this.ownerDataGridViewTextBoxColumn
            });
            this.dgv.DataSource = this.bsTemperature;
            this.dgv.Dock = DockStyle.Fill;
            this.dgv.Location = new Point(3, 3);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new Size(1294, 470);
            this.dgv.TabIndex = 1;
            this.dgv.CellDoubleClick +=new DataGridViewCellEventHandler( this.dgv_CellDoubleClick);
            this.dgv.CellFormatting +=new DataGridViewCellFormattingEventHandler (this.dgv_CellFormatting);
            this.toolBtnLoadOldBase.DisplayStyle = ToolStripItemDisplayStyle.Image;
           // this.toolBtnLoadOldBase.Image = (Image)global::DailyReportN.Properties.Resources.Load;
            this.toolBtnLoadOldBase.ImageTransparentColor = Color.Magenta;
            this.toolBtnLoadOldBase.Name = "toolBtnLoadOldBase";
            this.toolBtnLoadOldBase.Size = new Size(23, 22);
            this.toolBtnLoadOldBase.Text = "Загрузка из старой базы";
            this.toolBtnLoadOldBase.Click +=new System.EventHandler (this.toolBtnLoadOldBase_Click);
            this.bsTemperature.DataMember = "tJ_Temperature";
            this.bsTemperature.DataSource = this.dsDamage;
            this.dsDamage.DataSetName = "dsDamage";
            this.dsDamage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.dateTempDataGridViewTextBoxColumn.DataPropertyName = "DateTemp";
            this.dateTempDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateTempDataGridViewTextBoxColumn.Name = "dateTempDataGridViewTextBoxColumn";
            this.dateTempDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTempDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.nightColumn.DataPropertyName = "Night";
            this.nightColumn.HeaderText = "t Ночью";
            this.nightColumn.Name = "nightColumn";
            this.nightColumn.ReadOnly = true;
            this.nightColumn.Resizable = DataGridViewTriState.True;
            this.nightDownDataGridViewTextBoxColumn.DataPropertyName = "NightDown";
            this.nightDownDataGridViewTextBoxColumn.HeaderText = "t Ночь От";
            this.nightDownDataGridViewTextBoxColumn.Name = "nightDownDataGridViewTextBoxColumn";
            this.nightDownDataGridViewTextBoxColumn.ReadOnly = true;
            this.nightDownDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.nightDownDataGridViewTextBoxColumn.Visible = false;
            this.nightUpDataGridViewTextBoxColumn.DataPropertyName = "NightUp";
            this.nightUpDataGridViewTextBoxColumn.HeaderText = "t Ночь До";
            this.nightUpDataGridViewTextBoxColumn.Name = "nightUpDataGridViewTextBoxColumn";
            this.nightUpDataGridViewTextBoxColumn.ReadOnly = true;
            this.nightUpDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.nightUpDataGridViewTextBoxColumn.Visible = false;
            this.dayColumn.DataPropertyName = "Day";
            this.dayColumn.HeaderText = "t Днем";
            this.dayColumn.Name = "dayColumn";
            this.dayColumn.ReadOnly = true;
            this.dayDownDataGridViewTextBoxColumn.DataPropertyName = "DayDown";
            this.dayDownDataGridViewTextBoxColumn.HeaderText = "t День От";
            this.dayDownDataGridViewTextBoxColumn.Name = "dayDownDataGridViewTextBoxColumn";
            this.dayDownDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayDownDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.dayDownDataGridViewTextBoxColumn.Visible = false;
            this.dayUpDataGridViewTextBoxColumn.DataPropertyName = "DayUp";
            this.dayUpDataGridViewTextBoxColumn.HeaderText = "t День До";
            this.dayUpDataGridViewTextBoxColumn.Name = "dayUpDataGridViewTextBoxColumn";
            this.dayUpDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayUpDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.dayUpDataGridViewTextBoxColumn.Visible = false;
            this.tempAverageDataGridViewTextBoxColumn.DataPropertyName = "TempAverage";
            this.tempAverageDataGridViewTextBoxColumn.HeaderText = "t Средняя";
            this.tempAverageDataGridViewTextBoxColumn.Name = "tempAverageDataGridViewTextBoxColumn";
            this.tempAverageDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempAverageDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.windDgvColumn.DataPropertyName = "Wind";
            this.windDgvColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.windDgvColumn.HeaderText = "Ветер";
            this.windDgvColumn.Name = "windDgvColumn";
            this.windDgvColumn.ReadOnly = true;
            this.windDgvColumn.Resizable = DataGridViewTriState.True;
            this.speedColumn.DataPropertyName = "Speed";
            this.speedColumn.HeaderText = "Скорость ";
            this.speedColumn.Name = "speedColumn";
            this.speedColumn.ReadOnly = true;
            this.speedDownDataGridViewTextBoxColumn.DataPropertyName = "SpeedDown";
            this.speedDownDataGridViewTextBoxColumn.HeaderText = "Скорость От";
            this.speedDownDataGridViewTextBoxColumn.Name = "speedDownDataGridViewTextBoxColumn";
            this.speedDownDataGridViewTextBoxColumn.ReadOnly = true;
            this.speedDownDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.speedDownDataGridViewTextBoxColumn.Visible = false;
            this.speedUpDataGridViewTextBoxColumn.DataPropertyName = "SpeedUp";
            this.speedUpDataGridViewTextBoxColumn.HeaderText = "Скорость До";
            this.speedUpDataGridViewTextBoxColumn.Name = "speedUpDataGridViewTextBoxColumn";
            this.speedUpDataGridViewTextBoxColumn.ReadOnly = true;
            this.speedUpDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.speedUpDataGridViewTextBoxColumn.Visible = false;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.dateOwnerDataGridViewTextBoxColumn.DataPropertyName = "DateOwner";
            this.dateOwnerDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.dateOwnerDataGridViewTextBoxColumn.Name = "dateOwnerDataGridViewTextBoxColumn";
            this.dateOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOwnerDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.idOwnerDataGridViewTextBoxColumn.DataPropertyName = "idOwner";
            this.idOwnerDataGridViewTextBoxColumn.HeaderText = "idOwner";
            this.idOwnerDataGridViewTextBoxColumn.Name = "idOwnerDataGridViewTextBoxColumn";
            this.idOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOwnerDataGridViewTextBoxColumn.Visible = false;
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            ChartArea1.AxisX.LabelStyle.Format = "MM.yyyy";
            ChartArea1.AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Months;
            ChartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chartAbnObjPayment.ChartAreas.Add(ChartArea1);
            this.chartAbnObjPayment.ChartAreas.Add(chartArea2);
            this.chartAbnObjPayment.DataSource = this.bsTemperature;
            this.chartAbnObjPayment.Dock = DockStyle.Fill;
            legend.Name = "Legend1";
            this.chartAbnObjPayment.Legends.Add(legend);
            this.chartAbnObjPayment.Location = new Point(3, 3);
            this.chartAbnObjPayment.Name = "chartAbnObjPayment";
            this.chartAbnObjPayment.Palette = ChartColorPalette.Bright;

            seriesNight.BorderWidth = 2;
            seriesNight.ChartArea = "ChartArea1";
            seriesNight.ChartType = SeriesChartType.Line;
            seriesNight.Legend = "Legend1";
            seriesNight.LegendText = "t Ночью";
            seriesNight.Name = "Night";
            seriesNight.ToolTip = "#VALX \\n#VAL ℃";
            seriesNight.XValueMember = "DateTemp";
            seriesNight.YValueMembers = "NightDown, NightUp, DayDown, DayUp";
            seriesNight.YValuesPerPoint = 4;

            seriesDay.BorderWidth = 2;
            seriesDay.ChartArea = "ChartArea1";
            seriesDay.ChartType = SeriesChartType.Line;
            seriesDay.Legend = "Legend1";
            seriesDay.LegendText = "t Днем";
            seriesDay.Name = "Day";
            seriesDay.ToolTip = "#VALX\\n#VAL℃";
            seriesDay.XValueMember = "DateTemp";
            seriesDay.XValueType = ChartValueType.Date;
            seriesDay.YValueMembers = "DayDown, DayUp";
            seriesDay.YValuesPerPoint = 2;

            seriesSpeed.BorderWidth = 2;
            seriesSpeed.ChartArea = "ChartArea2";
            seriesSpeed.ChartType = SeriesChartType.Line;
            seriesSpeed.Label = " ";
            seriesSpeed.LabelToolTip = "#VAL";
            seriesSpeed.Legend = "Legend1";
            seriesSpeed.LegendText = "Скорость ветра";
            seriesSpeed.Name = "Speed";
            seriesSpeed.ToolTip = "#VALX\\n#VALм/с";
            seriesSpeed.XValueMember = "DateTemp";
            seriesSpeed.XValueType = ChartValueType.Date;
            seriesSpeed.YValueMembers = "SpeedDown, SpeedUp";
            seriesSpeed.YValuesPerPoint = 2;
            seriesSpeed.YValueType = ChartValueType.Int32;

            this.chartAbnObjPayment.Series.Add(seriesNight);
            this.chartAbnObjPayment.Series.Add(seriesDay);
            this.chartAbnObjPayment.Series.Add(seriesSpeed);
            this.chartAbnObjPayment.Size = new Size(1294, 470);
            this.chartAbnObjPayment.TabIndex = 7;
            this.chartAbnObjPayment.Text = "chart1";
            this.tabControlVertical1.Alignment = TabAlignment.Right;
            this.tabControlVertical1.Controls.Add(this.tabPage1);
            this.tabControlVertical1.Controls.Add(this.tabPage2);
            this.tabControlVertical1.Dock = DockStyle.Fill;
            this.tabControlVertical1.Location = new Point(0, 25);
            this.tabControlVertical1.Multiline = true;
            this.tabControlVertical1.Name = "tabControlVertical1";
            this.tabControlVertical1.SelectedIndex = 0;
            this.tabControlVertical1.Size = new Size(1327, 484);
            this.tabControlVertical1.TabIndex = 8;
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Location = new Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new Padding(3);
            this.tabPage1.Size = new Size(1300, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage2.Controls.Add(this.chartAbnObjPayment);
            this.tabPage2.Location = new Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new Padding(3);
            this.tabPage2.Size = new Size(1300, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "График";
            this.tabPage2.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(1327, 509);
            base.Controls.Add(this.tabControlVertical1);
            base.Controls.Add(this.toolStrip);
            base.Icon = (Icon)global::DailyReportN.Properties.Resources.pogoda2;
            base.Name = "FormJournalTemperature";
            this.Text = "Архив погоды (N2)";
            base.Load +=new System.EventHandler( this.FormJournalTemperature_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((ISupportInitialize)this.dgv).EndInit();
            ((ISupportInitialize)this.bsTemperature).EndInit();
            ((ISupportInitialize)this.dsDamage).EndInit();
            ((ISupportInitialize)this.chartAbnObjPayment).EndInit();
            this.tabControlVertical1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }



        private ToolStrip toolStrip;

        private ToolStripButton toolBtnAdd;

        private ToolStripButton toolBtnEdit;

        private ToolStripButton toolBtnDel;

        private ToolStripSeparator toolStripSeparator1;

        private ToolStripButton toolBtnRefresh;

        private ToolStripSeparator toolStripSeparator2;

        private ToolStripButton toolBtnFind;

        private ToolStripTextBox txtFind;

        private ToolStripButton toolBtnFindPrev;

        private ToolStripButton toolBtnFindNext;

        private DataGridViewExcelFilter dgv;

        private BindingSource bsTemperature;

        private DailyReportN.DataSet.dsDamage dsDamage;

        private ToolStripButton toolBtnLoadOldBase;

        private DataGridViewFilterTextBoxColumn dateTempDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn nightColumn;

        private DataGridViewFilterTextBoxColumn nightDownDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn nightUpDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn dayColumn;

        private DataGridViewFilterTextBoxColumn dayDownDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn dayUpDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn tempAverageDataGridViewTextBoxColumn;

        private DataGridViewFilterComboBoxColumn windDgvColumn;

        private DataGridViewFilterTextBoxColumn speedColumn;

        private DataGridViewFilterTextBoxColumn speedDownDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn speedUpDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn commentDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn dateOwnerDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idOwnerDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn ownerDataGridViewTextBoxColumn;

        private Chart chartAbnObjPayment;

        private TabControlVertical tabControlVertical1;

        private TabPage tabPage1;

        private TabPage tabPage2;
    }
}
