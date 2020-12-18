using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ControlsLbr;
using Scheme.Properties;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using Telemetry;
using WinFormsUI.Docking;
namespace Scheme.Forms
{
    public partial class FormGeneralScheme2 : FormLbr.FormBase
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


        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormGeneralScheme2));
            DockPanelSkin dockPanelSkin = new DockPanelSkin();
            AutoHideStripSkin autoHideStripSkin = new AutoHideStripSkin();
            DockPanelGradient dockPanelGradient = new DockPanelGradient();
            TabGradient tabGradient = new TabGradient();
            DockPaneStripSkin dockPaneStripSkin = new DockPaneStripSkin();
            DockPaneStripGradient dockPaneStripGradient = new DockPaneStripGradient();
            TabGradient tabGradient2 = new TabGradient();
            DockPanelGradient dockPanelGradient2 = new DockPanelGradient();
            TabGradient tabGradient3 = new TabGradient();
            DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient = new DockPaneStripToolWindowGradient();
            TabGradient tabGradient4 = new TabGradient();
            TabGradient tabGradient5 = new TabGradient();
            DockPanelGradient dockPanelGradient3 = new DockPanelGradient();
            TabGradient tabGradient6 = new TabGradient();
            TabGradient tabGradient7 = new TabGradient();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripButton_6 = new ToolStripButton();
            this.toolStripButton_7 = new ToolStripButton();
            this.toolStripButton_10 = new ToolStripButton();
            this.toolStripButton_8 = new ToolStripButton();
            this.toolStripButton_9 = new ToolStripButton();
            this.toolStripButton_5 = new ToolStripButton();
            this.backgroundWorker_0 = new BackgroundWorker();
            this.toolStripTools = new ToolStrip();
            this.toolStripButton_12 = new ToolStripButton();
            this.toolStripButton_11 = new ToolStripButton();
            this.toolStripButton_41 = new ToolStripButton();
            this.toolStripSeparator_6 = new ToolStripSeparator();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripButton_36 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_33 = new ToolStripButton();
            this.toolStripButton_34 = new ToolStripButton();
            this.toolStripSeparator_13 = new ToolStripSeparator();
            this.toolStripButton_38 = new ToolStripButton();
            this.toolStripButton_39 = new ToolStripButton();
            this.toolStripSeparator_14 = new ToolStripSeparator();
            this.toolStripButton_40 = new ToolStripButton();
            this.toolStripButton_52 = new ToolStripButton();
            this.toolStripComboBox_2 = new ToolStripComboBox();
            this.toolStripButton_44 = new ToolStripButton();
            this.toolStripButton_42 = new ToolStripButton();
            this.toolStripButton_43 = new ToolStripButton();
            this.toolStripButton_50 = new ToolStripButton();
            this.contextMenuStrip_0 = new ContextMenuStrip(this.components);
            this.toolStripMenuItem_5 = new ToolStripMenuItem();
            this.pYnMneGkhg = new ToolStripMenuItem();
            this.toolStripMenuItem_6 = new ToolStripMenuItem();
            this.toolStripMenuItem_41 = new ToolStripMenuItem();
            this.toolStripMenuItem_49 = new ToolStripMenuItem();
            this.toolStripMenuItem_42 = new ToolStripMenuItem();
            this.toolStripMenuItem_50 = new ToolStripMenuItem();
            this.toolStripSeparator_16 = new ToolStripSeparator();
            this.toolStripMenuItem_48 = new ToolStripMenuItem();
            this.toolStripMenuItem_43 = new ToolStripMenuItem();
            this.toolStripMenuItem_44 = new ToolStripMenuItem();
            this.toolStripSeparator_17 = new ToolStripSeparator();
            this.toolStripMenuItem_45 = new ToolStripMenuItem();
            this.toolStripMenuItem_46 = new ToolStripMenuItem();
            this.toolStripMenuItem_47 = new ToolStripMenuItem();
            this.toolStripSeparator_18 = new ToolStripSeparator();
            this.toolStripMenuItem_51 = new ToolStripMenuItem();
            this.IlbLiynpEJ = new ToolStripMenuItem();
            this.toolStripSeparator_5 = new ToolStripSeparator();
            this.toolStripMenuItem_10 = new ToolStripMenuItem();
            this.toolStripMenuItem_11 = new ToolStripMenuItem();
            this.toolStripMenuItem_12 = new ToolStripMenuItem();
            this.toolStripMenuItem_17 = new ToolStripMenuItem();
            this.toolStripMenuItem_18 = new ToolStripMenuItem();
            this.toolStripMenuItem_35 = new ToolStripMenuItem();
            this.toolStripMenuItem_22 = new ToolStripMenuItem();
            this.toolStripMenuItem_40 = new ToolStripMenuItem();
            this.toolStripSeparator_3 = new ToolStripSeparator();
            this.toolStripMenuItem_0 = new ToolStripMenuItem();
            this.toolStripMenuItem_13 = new ToolStripMenuItem();
            this.toolStripMenuItem_14 = new ToolStripMenuItem();
            this.toolStripMenuItem_1 = new ToolStripMenuItem();
            this.toolStripMenuItem_15 = new ToolStripMenuItem();
            this.toolStripMenuItem_16 = new ToolStripMenuItem();
            this.toolStripMenuItem_25 = new ToolStripMenuItem();
            this.toolStripMenuItem_36 = new ToolStripMenuItem();
            this.toolStripMenuItem_37 = new ToolStripMenuItem();
            this.toolStripMenuItem_38 = new ToolStripMenuItem();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripMenuItem_7 = new ToolStripMenuItem();
            this.toolStripMenuItem_8 = new ToolStripMenuItem();
            this.toolStripMenuItem_9 = new ToolStripMenuItem();
            this.toolStripSeparator_4 = new ToolStripSeparator();
            this.toolStripMenuItem_23 = new ToolStripMenuItem();
            this.toolStripMenuItem_24 = new ToolStripMenuItem();
            this.toolStripMenuItem_2 = new ToolStripMenuItem();
            this.toolStripMenuItem_27 = new ToolStripMenuItem();
            this.toolStripMenuItem_28 = new ToolStripMenuItem();
            this.toolStripMenuItem_29 = new ToolStripMenuItem();
            this.toolStripMenuItem_30 = new ToolStripMenuItem();
            this.toolStripMenuItem_31 = new ToolStripMenuItem();
            this.toolStripMenuItem_32 = new ToolStripMenuItem();
            this.toolStripMenuItem_33 = new ToolStripMenuItem();
            this.toolStripMenuItem_34 = new ToolStripMenuItem();
            this.toolStripMenuItem_3 = new ToolStripMenuItem();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripMenuItem_39 = new ToolStripMenuItem();
            this.toolStripMenuItem_4 = new ToolStripMenuItem();
            this.backgroundWorker_1 = new BackgroundWorker();
            this.panel_0 = new Panel();
            this.label_0 = new Label();
            this.progressBarEndLess_0 = new ProgressBarEndLess();
            this.toolStrip_2 = new ToolStrip();
            this.toolStripButton_13 = new ToolStripButton();
            this.toolStripButton_14 = new ToolStripButton();
            this.toolStripButton_15 = new ToolStripButton();
            this.toolStripSeparator_7 = new ToolStripSeparator();
            this.toolStripButton_45 = new ToolStripButton();
            this.toolStripButton_19 = new ToolStripButton();
            this.toolStripButton_53 = new ToolStripButton();
            this.toolStripSeparator_11 = new ToolStripSeparator();
            this.toolStripLabel_0 = new ToolStripLabel();
            this.toolStripComboBox_1 = new ToolStripComboBox();
            this.toolStripComboBox_0 = new ToolStripComboBox();
            this.toolStripSplitButton_0 = new ToolStripSplitButton();
            this.toolStripMenuItem_19 = new ToolStripMenuItem();
            this.toolStripMenuItem_20 = new ToolStripMenuItem();
            this.toolStripMenuItem_21 = new ToolStripMenuItem();
            this.toolStripMenuItem_26 = new ToolStripMenuItem();
            this.toolStripProgressBar_0 = new ToolStripProgressBar();
            this.toolStripLabel_1 = new ToolStripLabel();
            this.toolStripButton_49 = new ToolStripButton();
            this.toolStripButton_51 = new ToolStripButton();
            this.toolStrip_3 = new ToolStrip();
            this.toolStripButton_16 = new ToolStripButton();
            this.toolStripButton_17 = new ToolStripButton();
            this.toolStripButton_18 = new ToolStripButton();
            this.toolStripButton_37 = new ToolStripButton();
            this.toolStrip_4 = new ToolStrip();
            this.toolStripButton_20 = new ToolStripButton();
            this.toolStripSeparator_8 = new ToolStripSeparator();
            this.toolStripButton_21 = new ToolStripButton();
            this.toolStripButton_22 = new ToolStripButton();
            this.toolStripButton_23 = new ToolStripButton();
            this.toolStripButton_24 = new ToolStripButton();
            this.toolStripButton_25 = new ToolStripButton();
            this.toolStrip_5 = new ToolStrip();
            this.toolStripButton_26 = new ToolStripButton();
            this.toolStripButton_27 = new ToolStripButton();
            this.toolStripSeparator_12 = new ToolStripSeparator();
            this.toolStripButton_35 = new ToolStripButton();
            this.toolStripSeparator_9 = new ToolStripSeparator();
            this.toolStripButton_28 = new ToolStripButton();
            this.toolStripSeparator_10 = new ToolStripSeparator();
            this.toolStripButton_29 = new ToolStripButton();
            this.toolStripButton_30 = new ToolStripButton();
            this.toolStripButton_31 = new ToolStripButton();
            this.toolStripButton_32 = new ToolStripButton();
            this.toolStripSeparator_15 = new ToolStripSeparator();
            this.toolStripButton_46 = new ToolStripButton();
            this.toolStripTextBox_0 = new ToolStripTextBox();
            this.toolStripButton_47 = new ToolStripButton();
            this.toolStripButton_48 = new ToolStripButton();
            this.mniLotCpLE = new ToolStripSeparator();
            this.toolStripButton_54 = new ToolStripButton();
            this.toolStripContainer_0 = new ToolStripContainer();
            this.dockPanel1 = new DockPanel();
            this.toolStrip_6 = new ToolStrip();
            this.dataGridViewImageColumn_18 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_17 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_16 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_15 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_14 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_13 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_12 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_11 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_10 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_9 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_7 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_6 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_3 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_2 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_1 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_0 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_4 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_5 = new DataGridViewImageColumn();
            this.dataGridViewImageColumn_8 = new DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.QynLzkVuoQ = new ToolStripButton();
            this.toolStrip_0.SuspendLayout();
            this.toolStripTools.SuspendLayout();
            this.contextMenuStrip_0.SuspendLayout();
            this.panel_0.SuspendLayout();
            this.toolStrip_2.SuspendLayout();
            this.toolStrip_3.SuspendLayout();
            this.toolStrip_4.SuspendLayout();
            this.toolStrip_5.SuspendLayout();
            this.toolStripContainer_0.ContentPanel.SuspendLayout();
            this.toolStripContainer_0.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer_0.SuspendLayout();
            this.toolStrip_6.SuspendLayout();
            base.SuspendLayout();
            this.toolStrip_0.Dock = DockStyle.None;
            this.toolStrip_0.Items.AddRange(new ToolStripItem[]
            {
                this.toolStripButton_4,
                this.toolStripButton_6,
                this.toolStripButton_7,
                this.toolStripButton_10,
                this.toolStripButton_8,
                this.toolStripButton_9
            });
            this.toolStrip_0.Location = new Point(115, 75);
            this.toolStrip_0.Name = "toolStripWindows";
            this.toolStrip_0.Size = new Size(104, 25);
            this.toolStrip_0.TabIndex = 1;
            this.toolStrip_0.Text = "Доп. окна";
            this.toolStripButton_4.Checked = true;
            this.toolStripButton_4.CheckOnClick = true;
            this.toolStripButton_4.CheckState = CheckState.Checked;
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.smethod_66();
            this.toolStripButton_4.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_4.Name = "toolBtnTreeObjects";
            this.toolStripButton_4.Size = new Size(23, 22);
            this.toolStripButton_4.Text = "Дерево объектов";
            this.toolStripButton_4.Click += this.toolStripButton_4_Click;
            this.toolStripButton_6.Checked = true;
            this.toolStripButton_6.CheckOnClick = true;
            this.toolStripButton_6.CheckState = CheckState.Checked;
            this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = Resources.Message;
            this.toolStripButton_6.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_6.Name = "toolBtnMessage";
            this.toolStripButton_6.Size = new Size(23, 22);
            this.toolStripButton_6.Text = "Панель сообщений";
            this.toolStripButton_6.Click += this.toolStripButton_6_Click;
            this.toolStripButton_7.Checked = true;
            this.toolStripButton_7.CheckOnClick = true;
            this.toolStripButton_7.CheckState = CheckState.Checked;
            this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_7.Image = Resources.smethod_2();
            this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_7.Name = "toolBtnPowering";
            this.toolStripButton_7.Size = new Size(23, 22);
            this.toolStripButton_7.Text = "Проверка \"второго\" уровня";
            this.toolStripButton_7.Click += this.toolStripButton_7_Click;
            this.toolStripButton_10.Checked = true;
            this.toolStripButton_10.CheckOnClick = true;
            this.toolStripButton_10.CheckState = CheckState.Checked;
            this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_10.Image = Resources.odqpIseRpC();
            this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_10.Name = "toolBtnStates";
            this.toolStripButton_10.Size = new Size(23, 22);
            this.toolStripButton_10.Text = "Статусы объектов";
            this.toolStripButton_10.Click += this.toolStripButton_10_Click;
            this.toolStripButton_8.CheckOnClick = true;
            this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_8.Image = (Image)resources.GetObject("toolBtnSrvStart.Image");
            this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_8.Name = "toolBtnSrvStart";
            this.toolStripButton_8.Size = new Size(23, 22);
            this.toolStripButton_8.Text = "StartServer";
            this.toolStripButton_8.Visible = false;
            this.toolStripButton_9.CheckOnClick = true;
            this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_9.Image = (Image)resources.GetObject("toolBtnSrvJoin.Image");
            this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_9.Name = "toolBtnSrvJoin";
            this.toolStripButton_9.Size = new Size(23, 22);
            this.toolStripButton_9.Text = "Join";
            this.toolStripButton_9.Visible = false;
            this.toolStripButton_9.Click += this.toolStripButton_9_Click;
            this.toolStripButton_5.Checked = true;
            this.toolStripButton_5.CheckOnClick = true;
            this.toolStripButton_5.CheckState = CheckState.Checked;
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = Resources.smethod_63();
            this.toolStripButton_5.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_5.Name = "toolBtnTelemetry";
            this.toolStripButton_5.Size = new Size(23, 22);
            this.toolStripButton_5.Text = "Телеметрия";
            this.toolStripButton_5.Click += this.toolStripButton_5_Click;
            this.backgroundWorker_0.WorkerReportsProgress = true;
            this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
            this.backgroundWorker_0.ProgressChanged += this.backgroundWorker_0_ProgressChanged;
            this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
            this.toolStripTools.Dock = DockStyle.None;
            this.toolStripTools.Items.AddRange(new ToolStripItem[]
            {
                this.toolStripButton_12,
                this.toolStripButton_11,
                this.toolStripButton_41,
                this.toolStripSeparator_6,
                this.toolStripButton_0,
                this.toolStripButton_1,
                this.toolStripButton_2,
                this.toolStripButton_36,
                this.toolStripSeparator_0,
                this.toolStripButton_3,
                this.toolStripButton_33,
                this.toolStripButton_34,
                this.toolStripSeparator_13,
                this.toolStripButton_38,
                this.toolStripButton_39,
                this.toolStripSeparator_14,
                this.toolStripButton_40,
                this.toolStripButton_52,
                this.toolStripComboBox_2,
                this.toolStripButton_44,
                this.toolStripButton_42,
                this.toolStripButton_43
            });
            this.toolStripTools.Location = new Point(107, 25);
            this.toolStripTools.Name = "toolStripTools";
            this.toolStripTools.Size = new Size(483, 25);
            this.toolStripTools.TabIndex = 3;
            this.toolStripTools.Text = "Инструменты";
            this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_12.Image = Resources.smethod_12();
            this.toolStripButton_12.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_12.Name = "toolBtnEscCanvas";
            this.toolStripButton_12.Size = new Size(23, 22);
            this.toolStripButton_12.Text = "Курсор";
            this.toolStripButton_12.Click += this.toolStripButton_12_Click;
            this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_11.Image = Resources.smethod_11();
            this.toolStripButton_11.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_11.Name = "toolBtnPanCanvas";
            this.toolStripButton_11.Size = new Size(23, 22);
            this.toolStripButton_11.Text = "Движение подложки";
            this.toolStripButton_11.Click += this.toolStripButton_11_Click;
            this.toolStripButton_41.CheckOnClick = true;
            this.toolStripButton_41.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_41.Image = Resources.smethod_33();
            this.toolStripButton_41.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_41.Name = "toolStripButtonSelectionFrame";
            this.toolStripButton_41.Size = new Size(23, 22);
            this.toolStripButton_41.Text = "Рамка";
            this.toolStripButton_41.Click += this.toolStripButton_41_Click;
            this.toolStripSeparator_6.Name = "toolStripSeparator1";
            this.toolStripSeparator_6.Size = new Size(6, 25);
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.smethod_15();
            this.toolStripButton_0.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_0.Name = "toolBtnRectangle";
            this.toolStripButton_0.Size = new Size(23, 22);
            this.toolStripButton_0.Text = "ТП,РП,ЦП,ПП";
            this.toolStripButton_0.Click += this.toolStripButton_0_Click;
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.smethod_16();
            this.toolStripButton_1.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_1.Name = "toolBtnShina";
            this.toolStripButton_1.Size = new Size(23, 22);
            this.toolStripButton_1.Text = "Шина";
            this.toolStripButton_1.Click += this.toolStripButton_1_Click;
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.smethod_9();
            this.toolStripButton_2.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_2.Name = "toolBtnPolyLine";
            this.toolStripButton_2.Size = new Size(23, 22);
            this.toolStripButton_2.Text = "Кабель";
            this.toolStripButton_2.Click += this.toolStripButton_2_Click;
            this.toolStripButton_36.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_36.Image = Resources.smethod_64();
            this.toolStripButton_36.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_36.Name = "toolBtnTextTool";
            this.toolStripButton_36.Size = new Size(23, 22);
            this.toolStripButton_36.Text = "Текст";
            this.toolStripButton_36.Click += this.toolStripButton_36_Click;
            this.toolStripSeparator_0.Name = "toolStripSeparatorTools";
            this.toolStripSeparator_0.Size = new Size(6, 25);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.smethod_17();
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "tooBtnPatternTP";
            this.toolStripButton_3.Size = new Size(23, 22);
            this.toolStripButton_3.Text = "Шаблон ТП";
            this.toolStripButton_3.Click += this.toolStripButton_3_Click;
            this.toolStripButton_33.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_33.Enabled = false;
            this.toolStripButton_33.Image = (Image)resources.GetObject("undoToolStripButton.Image");
            this.toolStripButton_33.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_33.Name = "undoToolStripButton";
            this.toolStripButton_33.Size = new Size(23, 22);
            this.toolStripButton_33.Text = "Отменить";
            this.toolStripButton_33.Click += this.toolStripButton_33_Click;
            this.toolStripButton_34.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_34.Enabled = false;
            this.toolStripButton_34.Image = (Image)resources.GetObject("redoToolStripButton.Image");
            this.toolStripButton_34.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_34.Name = "redoToolStripButton";
            this.toolStripButton_34.Size = new Size(23, 22);
            this.toolStripButton_34.Text = "Возвратить";
            this.toolStripButton_34.Click += this.toolStripButton_34_Click;
            this.toolStripSeparator_13.Name = "toolStripSeparatorGroup";
            this.toolStripSeparator_13.Size = new Size(6, 25);
            this.toolStripButton_38.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_38.Image = Resources.smethod_57();
            this.toolStripButton_38.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_38.Name = "toolBtnGroup";
            this.toolStripButton_38.Size = new Size(23, 22);
            this.toolStripButton_38.Text = "Сгруппировать";
            this.toolStripButton_38.Click += this.toolStripButton_38_Click;
            this.toolStripButton_39.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_39.Image = Resources.smethod_58();
            this.toolStripButton_39.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_39.Name = "toolBtnUngroup";
            this.toolStripButton_39.Size = new Size(23, 22);
            this.toolStripButton_39.Text = "Разгруппировать";
            this.toolStripButton_39.Click += this.toolStripButton_39_Click;
            this.toolStripSeparator_14.Name = "toolStripSeparator8";
            this.toolStripSeparator_14.Size = new Size(6, 25);
            this.toolStripButton_40.Checked = true;
            this.toolStripButton_40.CheckOnClick = true;
            this.toolStripButton_40.CheckState = CheckState.Checked;
            this.toolStripButton_40.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_40.Image = Resources.smethod_60();
            this.toolStripButton_40.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_40.Name = "toolStripLineInformation";
            this.toolStripButton_40.Size = new Size(23, 22);
            this.toolStripButton_40.Text = "Информация на линиях";
            this.toolStripButton_40.Click += this.toolStripButton_40_Click;
            this.toolStripButton_52.Checked = true;
            this.toolStripButton_52.CheckOnClick = true;
            this.toolStripButton_52.CheckState = CheckState.Checked;
            this.toolStripButton_52.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_52.Image = Resources.measurement;
            this.toolStripButton_52.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_52.Name = "toolStripButtonMeasurementLabel";
            this.toolStripButton_52.Size = new Size(23, 22);
            this.toolStripButton_52.Text = "Метки замеров";
            this.toolStripButton_52.CheckedChanged += this.toolStripButton_52_CheckedChanged;
            this.toolStripComboBox_2.AutoSize = false;
            this.toolStripComboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.toolStripComboBox_2.FlatStyle = FlatStyle.System;
            this.toolStripComboBox_2.Name = "toolStripComboBoxMeasurementDate";
            this.toolStripComboBox_2.Size = new Size(100, 23);
            this.toolStripComboBox_2.ToolTipText = "Выберите год замеров";
            this.toolStripComboBox_2.SelectedIndexChanged += this.toolStripComboBox_2_SelectedIndexChanged;
            this.toolStripButton_44.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_44.Image = Resources.smethod_36();
            this.toolStripButton_44.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_44.Name = "toolStripButtonLineNoPassport";
            this.toolStripButton_44.Size = new Size(23, 22);
            this.toolStripButton_44.Text = "Кабельные линии без паспорта";
            this.toolStripButton_44.Click += this.toolStripButton_44_Click;
            this.toolStripButton_42.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_42.Image = (Image)resources.GetObject("toolStripButtonDoneSecondLevel.Image");
            this.toolStripButton_42.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_42.Name = "toolStripButtonDoneSecondLevel";
            this.toolStripButton_42.Size = new Size(23, 22);
            this.toolStripButton_42.Text = "Схема заполнена";
            this.toolStripButton_42.Visible = false;
            this.toolStripButton_42.Click += this.toolStripButton_42_Click;
            this.toolStripButton_43.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_43.Image = (Image)resources.GetObject("toolStripButtonCheckSecondLevel.Image");
            this.toolStripButton_43.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_43.Name = "toolStripButtonCheckSecondLevel";
            this.toolStripButton_43.Size = new Size(23, 22);
            this.toolStripButton_43.Text = "Схема проверена";
            this.toolStripButton_43.Visible = false;
            this.toolStripButton_43.Click += this.toolStripButton_43_Click;
            this.toolStripButton_50.Checked = true;
            this.toolStripButton_50.CheckOnClick = true;
            this.toolStripButton_50.CheckState = CheckState.Checked;
            this.toolStripButton_50.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_50.Image = Resources.smethod_4();
            this.toolStripButton_50.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_50.Name = "toolStripButtonTelemetryLabel";
            this.toolStripButton_50.Size = new Size(23, 22);
            this.toolStripButton_50.Text = "Метки телеметрии";
            this.toolStripButton_50.CheckedChanged += this.toolStripButton_50_CheckedChanged;
            this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem_5,
                this.pYnMneGkhg,
                this.toolStripMenuItem_6,
                this.toolStripMenuItem_41,
                this.toolStripSeparator_5,
                this.toolStripMenuItem_10,
                this.toolStripMenuItem_40,
                this.toolStripSeparator_3,
                this.toolStripMenuItem_0,
                this.toolStripMenuItem_1,
                this.toolStripMenuItem_25,
                this.toolStripMenuItem_36,
                this.toolStripSeparator_1,
                this.toolStripMenuItem_7,
                this.toolStripSeparator_4,
                this.toolStripMenuItem_23,
                this.toolStripMenuItem_24,
                this.toolStripMenuItem_2,
                this.toolStripMenuItem_27,
                this.toolStripMenuItem_3,
                this.toolStripSeparator_2,
                this.toolStripMenuItem_39,
                this.toolStripMenuItem_4
            });
            this.contextMenuStrip_0.Name = "contextMenuRectnagle";
            this.contextMenuStrip_0.Size = new Size(233, 430);
            this.contextMenuStrip_0.Opening += this.contextMenuStrip_0_Opening;
            this.toolStripMenuItem_5.Name = "toolMenuItemRectOpen";
            this.toolStripMenuItem_5.Size = new Size(232, 22);
            this.toolStripMenuItem_5.Text = "Раскрыть";
            this.toolStripMenuItem_5.Click += this.toolStripMenuItem_5_Click;
            this.pYnMneGkhg.Name = "toolMenuItemRectPassport";
            this.pYnMneGkhg.Size = new Size(232, 22);
            this.pYnMneGkhg.Text = "Паспорт";
            this.pYnMneGkhg.Click += this.pYnMneGkhg_Click;
            this.toolStripMenuItem_6.Name = "toolMenuItemRectAbonents";
            this.toolStripMenuItem_6.Size = new Size(232, 22);
            this.toolStripMenuItem_6.Text = "Абоненты";
            this.toolStripMenuItem_6.Visible = false;
            this.toolStripMenuItem_6.Click += this.toolStripMenuItem_6_Click;
            this.toolStripMenuItem_41.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem_49,
                this.toolStripMenuItem_42,
                this.toolStripMenuItem_50,
                this.toolStripSeparator_16,
                this.toolStripMenuItem_48,
                this.IlbLiynpEJ
            });
            this.toolStripMenuItem_41.Name = "toolMenuItemRectDocuments";
            this.toolStripMenuItem_41.Size = new Size(232, 22);
            this.toolStripMenuItem_41.Text = "Документы";
            this.toolStripMenuItem_49.Image = Resources.smethod_35();
            this.toolStripMenuItem_49.Name = "toolMenuItemRectJournalOrder";
            this.toolStripMenuItem_49.Size = new Size(281, 22);
            this.toolStripMenuItem_49.Text = "Наряды";
            this.toolStripMenuItem_49.Click += this.toolStripMenuItem_49_Click;
            this.toolStripMenuItem_42.Image = Resources.measurement;
            this.toolStripMenuItem_42.Name = "toolMenuItemRectMeasurement";
            this.toolStripMenuItem_42.Size = new Size(281, 22);
            this.toolStripMenuItem_42.Text = "Замеры";
            this.toolStripMenuItem_42.Click += this.toolStripMenuItem_42_Click;
            this.toolStripMenuItem_50.Image = Resources.smethod_53();
            this.toolStripMenuItem_50.Name = "toolMenuItemRectRelayProtectAutomation";
            this.toolStripMenuItem_50.Size = new Size(281, 22);
            this.toolStripMenuItem_50.Text = "Уставки РЗА";
            this.toolStripMenuItem_50.Click += this.toolStripMenuItem_50_Click;
            this.toolStripSeparator_16.Name = "toolStripSeparator12";
            this.toolStripSeparator_16.Size = new Size(278, 6);
            this.toolStripMenuItem_48.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem_43,
                this.toolStripMenuItem_44,
                this.toolStripSeparator_17,
                this.toolStripMenuItem_45,
                this.toolStripMenuItem_46,
                this.toolStripMenuItem_47,
                this.toolStripSeparator_18,
                this.toolStripMenuItem_51
            });
            this.toolStripMenuItem_48.Name = "toolMenuItemRectTechConnect";
            this.toolStripMenuItem_48.Size = new Size(281, 22);
            this.toolStripMenuItem_48.Text = "Технологическое присоединение";
            this.toolStripMenuItem_43.Image = Resources.smethod_5();
            this.toolStripMenuItem_43.Name = "toolMenuItemRectTU";
            this.toolStripMenuItem_43.Size = new Size(354, 22);
            this.toolStripMenuItem_43.Text = "Технические условия";
            this.toolStripMenuItem_43.Click += this.toolStripMenuItem_43_Click;
            this.toolStripMenuItem_44.Image = Resources.smethod_10();
            this.toolStripMenuItem_44.Name = "toolMenuItemRectContractTP";
            this.toolStripMenuItem_44.Size = new Size(354, 22);
            this.toolStripMenuItem_44.Text = "Договора на ТП";
            this.toolStripMenuItem_44.Click += this.toolStripMenuItem_44_Click;
            this.toolStripSeparator_17.Name = "toolStripSeparator9";
            this.toolStripSeparator_17.Size = new Size(351, 6);
            this.toolStripMenuItem_45.Name = "toolMenuItemRectActElectricalInspection";
            this.toolStripMenuItem_45.Size = new Size(354, 22);
            this.toolStripMenuItem_45.Tag = "1238";
            this.toolStripMenuItem_45.Text = "Акты осмотра электроустановок";
            this.toolStripMenuItem_45.Click += this.toolStripMenuItem_47_Click;
            this.toolStripMenuItem_46.Name = "toolMenuItemRectActPerformingTU";
            this.toolStripMenuItem_46.Size = new Size(354, 22);
            this.toolStripMenuItem_46.Tag = "1239";
            this.toolStripMenuItem_46.Text = "Акты выполнения технических условий";
            this.toolStripMenuItem_46.Click += this.toolStripMenuItem_47_Click;
            this.toolStripMenuItem_47.Name = "toolMenuItemRectActTC";
            this.toolStripMenuItem_47.Size = new Size(354, 22);
            this.toolStripMenuItem_47.Tag = "1240";
            this.toolStripMenuItem_47.Text = "Акты о технологическом присоединении";
            this.toolStripMenuItem_47.Click += this.toolStripMenuItem_47_Click;
            this.toolStripSeparator_18.Name = "toolStripSeparator15";
            this.toolStripSeparator_18.Size = new Size(351, 6);
            this.toolStripMenuItem_51.Name = "toolMenuItemRectActRBP";
            this.toolStripMenuItem_51.Size = new Size(354, 22);
            this.toolStripMenuItem_51.Text = "Акты разграничения барансовой принадлежности";
            this.toolStripMenuItem_51.Click += this.toolStripMenuItem_51_Click;
            this.IlbLiynpEJ.Name = "toolMenuItemRectDamage";
            this.IlbLiynpEJ.Size = new Size(281, 22);
            this.IlbLiynpEJ.Text = "Журнал технологических нарушений";
            this.IlbLiynpEJ.Click += this.IlbLiynpEJ_Click;
            this.toolStripSeparator_5.Name = "toolStripSeparator11";
            this.toolStripSeparator_5.Size = new Size(229, 6);
            this.toolStripMenuItem_10.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem_11,
                this.toolStripMenuItem_12,
                this.toolStripMenuItem_17,
                this.toolStripMenuItem_18,
                this.toolStripMenuItem_35,
                this.toolStripMenuItem_22
            });
            this.toolStripMenuItem_10.Name = "toolMenuItemRectSetLabel";
            this.toolStripMenuItem_10.Size = new Size(232, 22);
            this.toolStripMenuItem_10.Text = "Информация";
            this.toolStripMenuItem_11.CheckOnClick = true;
            this.toolStripMenuItem_11.Name = "toolMenuItemRectSetAVR";
            this.toolStripMenuItem_11.Size = new Size(263, 22);
            this.toolStripMenuItem_11.Text = "АВР";
            this.toolStripMenuItem_11.Click += this.toolStripMenuItem_22_Click;
            this.toolStripMenuItem_12.CheckOnClick = true;
            this.toolStripMenuItem_12.Name = "toolMenuItemRectSetLock";
            this.toolStripMenuItem_12.Size = new Size(263, 22);
            this.toolStripMenuItem_12.Text = "Спец замок";
            this.toolStripMenuItem_12.Click += this.toolStripMenuItem_22_Click;
            this.toolStripMenuItem_17.CheckOnClick = true;
            this.toolStripMenuItem_17.Name = "toolMenuItemRectSetTM";
            this.toolStripMenuItem_17.Size = new Size(263, 22);
            this.toolStripMenuItem_17.Text = "Телемеханика";
            this.toolStripMenuItem_17.Click += this.toolStripMenuItem_22_Click;
            this.toolStripMenuItem_18.CheckOnClick = true;
            this.toolStripMenuItem_18.Name = "toolMenuItemRectSetTMProtect";
            this.toolStripMenuItem_18.Size = new Size(263, 22);
            this.toolStripMenuItem_18.Text = "Телемеханика-охрана";
            this.toolStripMenuItem_18.Click += this.toolStripMenuItem_22_Click;
            this.toolStripMenuItem_35.CheckOnClick = true;
            this.toolStripMenuItem_35.Name = "toolMenuItemRectSetVideo";
            this.toolStripMenuItem_35.Size = new Size(263, 22);
            this.toolStripMenuItem_35.Text = "Видеонаблюдение";
            this.toolStripMenuItem_35.Click += this.toolStripMenuItem_22_Click;
            this.toolStripMenuItem_22.Name = "toolMenuItemRectSetResopsibleAbn";
            this.toolStripMenuItem_22.Size = new Size(263, 22);
            this.toolStripMenuItem_22.Text = "Добавить ответсвенного абонента";
            this.toolStripMenuItem_22.Click += this.toolStripMenuItem_22_Click;
            this.toolStripMenuItem_40.Name = "toolStripMenuItemAddTelemetryLabel";
            this.toolStripMenuItem_40.Size = new Size(232, 22);
            this.toolStripMenuItem_40.Text = "Вывести данные телеметрии";
            this.toolStripMenuItem_40.Click += this.toolStripMenuItem_40_Click;
            this.toolStripSeparator_3.Name = "toolStripSeparatorSetLabel";
            this.toolStripSeparator_3.Size = new Size(229, 6);
            this.toolStripMenuItem_0.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem_13,
                this.toolStripMenuItem_14
            });
            this.toolStripMenuItem_0.Name = "toolMenuItemRectPowerSource";
            this.toolStripMenuItem_0.Size = new Size(232, 22);
            this.toolStripMenuItem_0.Text = "Просчитать запитку";
            this.toolStripMenuItem_13.Name = "toolStripMenuItem1";
            this.toolStripMenuItem_13.Size = new Size(186, 22);
            this.toolStripMenuItem_13.Tag = "1";
            this.toolStripMenuItem_13.Text = "Выделить";
            this.toolStripMenuItem_13.Click += this.toolStripMenuItem_14_Click;
            this.toolStripMenuItem_14.Name = "toolStripMenuItem2";
            this.toolStripMenuItem_14.Size = new Size(186, 22);
            this.toolStripMenuItem_14.Tag = "2";
            this.toolStripMenuItem_14.Text = "Выделить миганием";
            this.toolStripMenuItem_14.Click += this.toolStripMenuItem_14_Click;
            this.toolStripMenuItem_1.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem_15,
                this.toolStripMenuItem_16
            });
            this.toolStripMenuItem_1.Name = "toolMenuItemRectRecipientsPower";
            this.toolStripMenuItem_1.Size = new Size(232, 22);
            this.toolStripMenuItem_1.Text = "Просчитать схему";
            this.toolStripMenuItem_15.Name = "toolStripMenuItem3";
            this.toolStripMenuItem_15.Size = new Size(186, 22);
            this.toolStripMenuItem_15.Tag = "1";
            this.toolStripMenuItem_15.Text = "Выделить";
            this.toolStripMenuItem_15.Click += this.toolStripMenuItem_16_Click;
            this.toolStripMenuItem_16.Name = "toolStripMenuItem4";
            this.toolStripMenuItem_16.Size = new Size(186, 22);
            this.toolStripMenuItem_16.Tag = "2";
            this.toolStripMenuItem_16.Text = "Выделить миганием";
            this.toolStripMenuItem_16.Click += this.toolStripMenuItem_16_Click;
            this.toolStripMenuItem_25.Name = "toolStripMenuItemAdjacentSubstation";
            this.toolStripMenuItem_25.Size = new Size(232, 22);
            this.toolStripMenuItem_25.Text = "Смежные подстанции";
            this.toolStripMenuItem_25.Click += this.toolStripMenuItem_25_Click;
            this.toolStripMenuItem_36.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem_37,
                this.toolStripMenuItem_38
            });
            this.toolStripMenuItem_36.Name = "toolStripMenuItemRectGetOldAbn";
            this.toolStripMenuItem_36.Size = new Size(232, 22);
            this.toolStripMenuItem_36.Text = "Абоненты";
            this.toolStripMenuItem_37.Name = "toolStripMenuItemRectOldAbnCurrentRect";
            this.toolStripMenuItem_37.Size = new Size(191, 22);
            this.toolStripMenuItem_37.Text = "Текущей подстанции";
            this.toolStripMenuItem_37.Click += this.toolStripMenuItem_38_Click;
            this.toolStripMenuItem_38.Name = "toolStripMenuItemRectOldAbnNextRect";
            this.toolStripMenuItem_38.Size = new Size(191, 22);
            this.toolStripMenuItem_38.Tag = "1";
            this.toolStripMenuItem_38.Text = "По цепочке";
            this.toolStripMenuItem_38.Click += this.toolStripMenuItem_38_Click;
            this.toolStripSeparator_1.Name = "toolStripSeparator10";
            this.toolStripSeparator_1.Size = new Size(229, 6);
            this.toolStripMenuItem_7.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem_8,
                this.toolStripMenuItem_9
            });
            this.toolStripMenuItem_7.Name = "toolMenuItemRectFilter";
            this.toolStripMenuItem_7.Size = new Size(232, 22);
            this.toolStripMenuItem_7.Text = "Фильтр";
            this.toolStripMenuItem_8.Name = "toolMenuItemRectFilterAdd";
            this.toolStripMenuItem_8.Size = new Size(183, 22);
            this.toolStripMenuItem_8.Text = "Добавить в фильтр";
            this.toolStripMenuItem_8.Click += this.toolStripMenuItem_8_Click;
            this.toolStripMenuItem_9.Name = "toolMenuItemRectFilterDel";
            this.toolStripMenuItem_9.Size = new Size(183, 22);
            this.toolStripMenuItem_9.Text = "Удалить из фильтра";
            this.toolStripMenuItem_9.Click += this.toolStripMenuItem_9_Click;
            this.toolStripSeparator_4.Name = "toolStripSeparator13";
            this.toolStripSeparator_4.Size = new Size(229, 6);
            this.toolStripMenuItem_23.Name = "toolMenuItemRectCopy";
            this.toolStripMenuItem_23.Size = new Size(232, 22);
            this.toolStripMenuItem_23.Text = "Копировать";
            this.toolStripMenuItem_23.Click += this.toolStripMenuItem_23_Click;
            this.toolStripMenuItem_24.Name = "toolMenuItemRectPaste";
            this.toolStripMenuItem_24.Size = new Size(232, 22);
            this.toolStripMenuItem_24.Text = "Вставить";
            this.toolStripMenuItem_24.Click += this.toolStripMenuItem_24_Click;
            this.toolStripMenuItem_2.Name = "toolMenuItemRectDel";
            this.toolStripMenuItem_2.Size = new Size(232, 22);
            this.toolStripMenuItem_2.Text = "Удалить";
            this.toolStripMenuItem_2.Click += this.toolStripMenuItem_2_Click;
            this.toolStripMenuItem_27.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem_28,
                this.toolStripMenuItem_31
            });
            this.toolStripMenuItem_27.Name = "toolStripMenuItemRectanglePosition";
            this.toolStripMenuItem_27.Size = new Size(232, 22);
            this.toolStripMenuItem_27.Text = "Положение";
            this.toolStripMenuItem_28.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem_29,
                this.toolStripMenuItem_30
            });
            this.toolStripMenuItem_28.Name = "toolStripMenuItemReflect";
            this.toolStripMenuItem_28.Size = new Size(133, 22);
            this.toolStripMenuItem_28.Text = "Отразить";
            this.toolStripMenuItem_29.Name = "toolStripMenuItemVReflect";
            this.toolStripMenuItem_29.Size = new Size(163, 22);
            this.toolStripMenuItem_29.Tag = "V";
            this.toolStripMenuItem_29.Text = "По вертикали";
            this.toolStripMenuItem_29.Click += this.toolStripMenuItem_30_Click;
            this.toolStripMenuItem_30.Name = "toolStripMenuItemHReflect";
            this.toolStripMenuItem_30.Size = new Size(163, 22);
            this.toolStripMenuItem_30.Tag = "H";
            this.toolStripMenuItem_30.Text = "По горизонтали";
            this.toolStripMenuItem_30.Click += this.toolStripMenuItem_30_Click;
            this.toolStripMenuItem_31.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem_32,
                this.toolStripMenuItem_33,
                this.toolStripMenuItem_34
            });
            this.toolStripMenuItem_31.Name = "toolStripMenuItemRotateRectangle";
            this.toolStripMenuItem_31.Size = new Size(133, 22);
            this.toolStripMenuItem_31.Text = "Повернуть";
            this.toolStripMenuItem_32.Name = "toolStripMenuItemRotate90";
            this.toolStripMenuItem_32.Size = new Size(144, 22);
            this.toolStripMenuItem_32.Tag = "90";
            this.toolStripMenuItem_32.Text = "90 градусов";
            this.toolStripMenuItem_32.Click += this.toolStripMenuItem_34_Click;
            this.toolStripMenuItem_33.Name = "toolStripMenuItemRotate180";
            this.toolStripMenuItem_33.Size = new Size(144, 22);
            this.toolStripMenuItem_33.Tag = "180";
            this.toolStripMenuItem_33.Text = "180 градусов";
            this.toolStripMenuItem_33.Click += this.toolStripMenuItem_34_Click;
            this.toolStripMenuItem_34.Name = "toolStripMenuItemRotate270";
            this.toolStripMenuItem_34.Size = new Size(144, 22);
            this.toolStripMenuItem_34.Tag = "270";
            this.toolStripMenuItem_34.Text = "270 градусов";
            this.toolStripMenuItem_34.Click += this.toolStripMenuItem_34_Click;
            this.toolStripMenuItem_3.Name = "toolMenuItemRectAlign";
            this.toolStripMenuItem_3.Size = new Size(232, 22);
            this.toolStripMenuItem_3.Text = "Выровнять объекты";
            this.toolStripMenuItem_3.Click += this.toolStripMenuItem_3_Click;
            this.toolStripSeparator_2.Name = "toolStripSeparatorEditRectangle";
            this.toolStripSeparator_2.Size = new Size(229, 6);
            this.toolStripMenuItem_39.Name = "toolMenuItemRectFile";
            this.toolStripMenuItem_39.Size = new Size(232, 22);
            this.toolStripMenuItem_39.Text = "Файлы";
            this.toolStripMenuItem_39.Click += this.toolStripMenuItem_39_Click;
            this.toolStripMenuItem_4.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            this.toolStripMenuItem_4.Name = "toolMenuItemRectProperty";
            this.toolStripMenuItem_4.Size = new Size(232, 22);
            this.toolStripMenuItem_4.Text = "Свойства объекта";
            this.toolStripMenuItem_4.Click += this.toolStripMenuItem_4_Click;
            this.backgroundWorker_1.WorkerReportsProgress = true;
            this.backgroundWorker_1.DoWork += this.backgroundWorker_1_DoWork;
            this.backgroundWorker_1.RunWorkerCompleted += this.backgroundWorker_1_RunWorkerCompleted;
            this.panel_0.BackColor = SystemColors.Control;
            this.panel_0.Controls.Add(this.label_0);
            this.panel_0.Controls.Add(this.progressBarEndLess_0);
            this.panel_0.Location = new Point(262, 205);
            this.panel_0.Name = "panelProgress";
            this.panel_0.Size = new Size(431, 74);
            this.panel_0.TabIndex = 5;
            this.panel_0.Visible = false;
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
            this.progressBarEndLess_0.NormalImage = (Image)resources.GetObject("progressBarEndLess.NormalImage");
            this.progressBarEndLess_0.PointImage = (Image)resources.GetObject("progressBarEndLess.PointImage");
            this.progressBarEndLess_0.Position = 0;
            this.progressBarEndLess_0.ProgressStyle = ProgressBarEndLess.ProgressBarEndLessStyleConstants.LeftAndRight;
            this.progressBarEndLess_0.ProgressType = ProgressBarEndLess.ProgressBarEndLessTypeConstants.GraphicType;
            this.progressBarEndLess_0.Size = new Size(431, 35);
            this.progressBarEndLess_0.TabIndex = 5;
            this.toolStrip_2.Dock = DockStyle.None;
            this.toolStrip_2.Items.AddRange(new ToolStripItem[]
            {
                this.toolStripButton_13,
                this.toolStripButton_14,
                this.toolStripButton_15,
                this.toolStripSeparator_7,
                this.toolStripButton_45,
                this.toolStripButton_19,
                this.toolStripButton_53,
                this.toolStripSeparator_11,
                this.toolStripLabel_0,
                this.toolStripComboBox_1,
                this.toolStripComboBox_0,
                this.toolStripSplitButton_0,
                this.toolStripProgressBar_0,
                this.toolStripLabel_1,
                this.toolStripButton_49
            });
            this.toolStrip_2.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip_2.Location = new Point(393, 50);
            this.toolStrip_2.Name = "toolStripSave";
            this.toolStrip_2.Size = new Size(330, 25);
            this.toolStrip_2.TabIndex = 6;
            this.toolStrip_2.Text = "Сохранение";
            this.toolStripButton_13.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_13.Image = Resources.smethod_54();
            this.toolStripButton_13.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_13.Name = "toolBtnSave";
            this.toolStripButton_13.Size = new Size(23, 22);
            this.toolStripButton_13.Text = "Сохранить";
            this.toolStripButton_13.Click += this.toolStripButton_13_Click;
            this.toolStripButton_14.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_14.Image = Resources.smethod_51();
            this.toolStripButton_14.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_14.Name = "toolBtnRefresh";
            this.toolStripButton_14.Size = new Size(23, 22);
            this.toolStripButton_14.Text = "Обновить";
            this.toolStripButton_14.Click += this.toolStripButton_14_Click;
            this.toolStripButton_15.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_15.Image = Resources.smethod_22();
            this.toolStripButton_15.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_15.Name = "toolStripButtonExport";
            this.toolStripButton_15.Size = new Size(23, 22);
            this.toolStripButton_15.Text = "Экспорт в AutoCAD";
            this.toolStripButton_15.Click += this.toolStripButton_15_Click;
            this.toolStripSeparator_7.Name = "toolStripSeparator7";
            this.toolStripSeparator_7.Size = new Size(6, 25);
            this.toolStripButton_45.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_45.Image = Resources.smethod_55();
            this.toolStripButton_45.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_45.Name = "toolBtnSetting2";
            this.toolStripButton_45.Size = new Size(23, 22);
            this.toolStripButton_45.Text = "Настройки";
            this.toolStripButton_45.Visible = false;
            this.toolStripButton_45.Click += this.toolStripButton_19_Click;
            this.toolStripButton_19.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_19.Image = Resources.smethod_55();
            this.toolStripButton_19.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_19.Name = "toolBtnSetting";
            this.toolStripButton_19.Size = new Size(23, 22);
            this.toolStripButton_19.Text = "Настройки";
            this.toolStripButton_19.Click += this.toolStripButton_19_Click;
            this.toolStripButton_53.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_53.Image = Resources.Ercloud;
            this.toolStripButton_53.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_53.Name = "toolBtnErcloud";
            this.toolStripButton_53.Size = new Size(23, 22);
            this.toolStripButton_53.Text = "Настройки Ercloud";
            this.toolStripButton_53.Click += this.toolStripButton_53_Click;
            this.toolStripSeparator_11.Name = "toolStripSeparator5";
            this.toolStripSeparator_11.Size = new Size(6, 25);
            this.toolStripLabel_0.Name = "toolStripLabel2";
            this.toolStripLabel_0.Size = new Size(45, 22);
            this.toolStripLabel_0.Text = "Режим";
            this.toolStripComboBox_1.AutoSize = false;
            this.toolStripComboBox_1.CausesValidation = false;
            this.toolStripComboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.toolStripComboBox_1.FlatStyle = FlatStyle.System;
            this.toolStripComboBox_1.Items.AddRange(new object[]
            {
                "Просмотр",
                "Диспетчер",
                "Редактирование"
            });
            this.toolStripComboBox_1.Name = "toolStripComboBoxRezim2";
            this.toolStripComboBox_1.Size = new Size(121, 23);
            this.toolStripComboBox_1.Visible = false;
            this.toolStripComboBox_1.SelectedIndexChanged += this.toolStripComboBox_0_SelectedIndexChanged;
            this.toolStripComboBox_0.AutoSize = false;
            this.toolStripComboBox_0.CausesValidation = false;
            this.toolStripComboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
            this.toolStripComboBox_0.FlatStyle = FlatStyle.System;
            this.toolStripComboBox_0.Items.AddRange(new object[]
            {
                "Просмотр",
                "Диспетчер",
                "Редактирование"
            });
            this.toolStripComboBox_0.Name = "toolStripComboBoxRezim";
            this.toolStripComboBox_0.Size = new Size(121, 23);
            this.toolStripComboBox_0.SelectedIndexChanged += this.toolStripComboBox_0_SelectedIndexChanged;
            this.toolStripSplitButton_0.Alignment = ToolStripItemAlignment.Right;
            this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton_0.DropDownItems.AddRange(new ToolStripItem[]
            {
                this.toolStripMenuItem_19,
                this.toolStripMenuItem_20,
                this.toolStripMenuItem_21,
                this.toolStripMenuItem_26
            });
            this.toolStripSplitButton_0.Image = (Image)resources.GetObject("toolSplitBtnLoadOld.Image");
            this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripSplitButton_0.Name = "toolSplitBtnLoadOld";
            this.toolStripSplitButton_0.Size = new Size(68, 22);
            this.toolStripSplitButton_0.Text = "LoadOld";
            this.toolStripSplitButton_0.Visible = false;
            this.toolStripMenuItem_19.Name = "toolMenuLoadPB";
            this.toolStripMenuItem_19.Size = new Size(162, 22);
            this.toolStripMenuItem_19.Text = "Правый берег";
            this.toolStripMenuItem_19.Visible = false;
            this.toolStripMenuItem_19.Click += this.toolStripMenuItem_19_Click;
            this.toolStripMenuItem_20.Name = "toolMenuLoadLB";
            this.toolStripMenuItem_20.Size = new Size(162, 22);
            this.toolStripMenuItem_20.Text = "Левый берег";
            this.toolStripMenuItem_20.Visible = false;
            this.toolStripMenuItem_20.Click += this.toolStripMenuItem_20_Click;
            this.toolStripMenuItem_21.Name = "toolMenuLoadPrig";
            this.toolStripMenuItem_21.Size = new Size(162, 22);
            this.toolStripMenuItem_21.Text = "Пригород";
            this.toolStripMenuItem_21.Visible = false;
            this.toolStripMenuItem_21.Click += this.toolStripMenuItem_21_Click;
            this.toolStripMenuItem_26.Name = "toolMenuLoadSEcondSchema";
            this.toolStripMenuItem_26.Size = new Size(162, 22);
            this.toolStripMenuItem_26.Text = "Второй уровень";
            this.toolStripMenuItem_26.Click += this.toolStripMenuItem_26_Click;
            this.toolStripProgressBar_0.Alignment = ToolStripItemAlignment.Right;
            this.toolStripProgressBar_0.Name = "toolStripProgressBar1";
            this.toolStripProgressBar_0.Size = new Size(100, 22);
            this.toolStripProgressBar_0.Visible = false;
            this.toolStripLabel_1.Alignment = ToolStripItemAlignment.Right;
            this.toolStripLabel_1.Name = "workerCounterLabel";
            this.toolStripLabel_1.Size = new Size(13, 22);
            this.toolStripLabel_1.Text = "0";
            this.toolStripLabel_1.Visible = false;
            this.toolStripButton_49.CheckOnClick = true;
            this.toolStripButton_49.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_49.Image = (Image)resources.GetObject("toolStripButtonTraining.Image");
            this.toolStripButton_49.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_49.Name = "toolStripButtonTraining";
            this.toolStripButton_49.Size = new Size(23, 22);
            this.toolStripButton_49.Text = "Режим песочницы";
            this.toolStripButton_49.Click += this.toolStripButton_49_Click;
            this.toolStripButton_51.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_51.Image = Resources.smethod_67();
            this.toolStripButton_51.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_51.Name = "toolBtnTelemetryRefresh";
            this.toolStripButton_51.Size = new Size(23, 22);
            this.toolStripButton_51.Text = "Обновить показания телеметрии";
            this.toolStripButton_51.Click += this.toolStripButton_51_Click;
            this.toolStrip_3.Dock = DockStyle.None;
            this.toolStrip_3.Items.AddRange(new ToolStripItem[]
            {
                this.toolStripButton_16,
                this.toolStripButton_17,
                this.toolStripButton_18,
                this.toolStripButton_37
            });
            this.toolStrip_3.Location = new Point(3, 25);
            this.toolStrip_3.Name = "toolStripPrint";
            this.toolStrip_3.Size = new Size(104, 25);
            this.toolStrip_3.TabIndex = 7;
            this.toolStrip_3.Text = "Печать";
            this.toolStripButton_16.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_16.Image = Resources.smethod_42();
            this.toolStripButton_16.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_16.Name = "toolBtnPageSetup";
            this.toolStripButton_16.Size = new Size(23, 22);
            this.toolStripButton_16.Text = "Настройка страницы";
            this.toolStripButton_16.Click += this.toolStripButton_16_Click;
            this.toolStripButton_17.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_17.Image = Resources.smethod_49();
            this.toolStripButton_17.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_17.Name = "toolBtnPrintPreview";
            this.toolStripButton_17.Size = new Size(23, 22);
            this.toolStripButton_17.Text = "Предварительный просмотр";
            this.toolStripButton_17.Click += this.toolStripButton_17_Click;
            this.toolStripButton_18.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_18.Image = Resources.smethod_45();
            this.toolStripButton_18.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_18.Name = "toolBtnPrint";
            this.toolStripButton_18.Size = new Size(23, 22);
            this.toolStripButton_18.Text = "Печать";
            this.toolStripButton_18.Click += this.toolStripButton_18_Click;
            this.toolStripButton_37.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_37.Image = Resources.smethod_46();
            this.toolStripButton_37.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_37.Name = "toolStripButtonPrint";
            this.toolStripButton_37.Size = new Size(23, 22);
            this.toolStripButton_37.Text = "Печать";
            this.toolStripButton_37.Click += this.toolStripButton_37_Click;
            this.toolStrip_4.Dock = DockStyle.None;
            this.toolStrip_4.Items.AddRange(new ToolStripItem[]
            {
                this.toolStripButton_20,
                this.toolStripSeparator_8,
                this.toolStripButton_21,
                this.toolStripButton_22,
                this.toolStripButton_23,
                this.toolStripButton_24,
                this.toolStripButton_25
            });
            this.toolStrip_4.Location = new Point(3, 0);
            this.toolStrip_4.Name = "toolStripZoom";
            this.toolStrip_4.Size = new Size(156, 25);
            this.toolStrip_4.TabIndex = 9;
            this.toolStrip_4.Text = "Масштаб";
            this.toolStripButton_20.CheckOnClick = true;
            this.toolStripButton_20.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_20.Image = Resources.smethod_38();
            this.toolStripButton_20.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_20.Name = "toolStripButtonShowMap";
            this.toolStripButton_20.Size = new Size(23, 22);
            this.toolStripButton_20.Text = "Показать карту схемы";
            this.toolStripButton_20.Click += this.toolStripButton_20_Click;
            this.toolStripSeparator_8.Name = "toolStripSeparator4";
            this.toolStripSeparator_8.Size = new Size(6, 25);
            this.toolStripButton_21.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_21.Image = Resources.smethod_70();
            this.toolStripButton_21.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_21.Name = "toolBtnZoomWindow";
            this.toolStripButton_21.Size = new Size(23, 22);
            this.toolStripButton_21.Text = "Подогнать под рамку";
            this.toolStripButton_21.Click += this.toolStripButton_21_Click;
            this.toolStripButton_22.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_22.Image = Resources.smethod_0();
            this.toolStripButton_22.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_22.Name = "toolBtnZoomIn";
            this.toolStripButton_22.Size = new Size(23, 22);
            this.toolStripButton_22.Text = "Увеличить масштаб";
            this.toolStripButton_22.Click += this.toolStripButton_22_Click;
            this.toolStripButton_23.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_23.Image = Resources.smethod_1();
            this.toolStripButton_23.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_23.Name = "toolBtnZoomOut";
            this.toolStripButton_23.Size = new Size(23, 22);
            this.toolStripButton_23.Text = "Уменьшить масштаб";
            this.toolStripButton_23.Click += this.toolStripButton_23_Click;
            this.toolStripButton_24.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_24.Image = Resources.smethod_68();
            this.toolStripButton_24.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_24.Name = "toolBtnZoomInSymbol";
            this.toolStripButton_24.Size = new Size(23, 22);
            this.toolStripButton_24.Text = "Увеличить шрифт";
            this.toolStripButton_24.Click += this.toolStripButton_24_Click;
            this.toolStripButton_25.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_25.Image = Resources.smethod_69();
            this.toolStripButton_25.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_25.Name = "toolBtnZoomOutSymbol";
            this.toolStripButton_25.Size = new Size(23, 22);
            this.toolStripButton_25.Text = "Уменьшить шрифт";
            this.toolStripButton_25.Click += this.toolStripButton_25_Click;
            this.toolStrip_5.Dock = DockStyle.None;
            this.toolStrip_5.Items.AddRange(new ToolStripItem[]
            {
                this.toolStripButton_26,
                this.toolStripButton_27,
                this.toolStripSeparator_12,
                this.toolStripButton_35,
                this.toolStripSeparator_9,
                this.toolStripButton_28,
                this.toolStripSeparator_10,
                this.toolStripButton_29,
                this.toolStripButton_30,
                this.toolStripButton_31,
                this.toolStripButton_32,
                this.toolStripSeparator_15,
                this.toolStripButton_46,
                this.toolStripTextBox_0,
                this.toolStripButton_47,
                this.toolStripButton_48,
                this.mniLotCpLE,
                this.toolStripButton_54
            });
            this.toolStrip_5.Location = new Point(3, 50);
            this.toolStrip_5.Name = "toolStripFilter";
            this.toolStrip_5.Size = new Size(390, 25);
            this.toolStrip_5.TabIndex = 10;
            this.toolStrip_5.Text = "Фильтр";
            this.toolStripButton_26.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_26.Image = Resources.smethod_23();
            this.toolStripButton_26.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_26.Name = "toolStripButtonFilter";
            this.toolStripButton_26.Size = new Size(23, 22);
            this.toolStripButton_26.Text = "Фильтр";
            this.toolStripButton_26.Click += this.toolStripButton_26_Click;
            this.toolStripButton_27.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_27.Image = Resources.smethod_24();
            this.toolStripButton_27.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_27.Name = "toolStripButtonFilterDel";
            this.toolStripButton_27.Size = new Size(23, 22);
            this.toolStripButton_27.Text = "Убрать фильтр";
            this.toolStripButton_27.Click += this.toolStripButton_27_Click;
            this.toolStripSeparator_12.Name = "toolStripSeparator6";
            this.toolStripSeparator_12.Size = new Size(6, 25);
            this.toolStripButton_35.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_35.Image = Resources.smethod_61();
            this.toolStripButton_35.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_35.Name = "toolStripButton1";
            this.toolStripButton_35.Size = new Size(23, 22);
            this.toolStripButton_35.Text = "Показать в отдельной вкладке";
            this.toolStripButton_35.Click += this.toolStripButton_35_Click;
            this.toolStripSeparator_9.Name = "toolStripSeparator2";
            this.toolStripSeparator_9.Size = new Size(6, 25);
            this.toolStripButton_28.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_28.Enabled = false;
            this.toolStripButton_28.Image = Resources.smethod_32();
            this.toolStripButton_28.ImageTransparentColor = Color.Transparent;
            this.toolStripButton_28.Name = "toolStripButtonNoFlashing";
            this.toolStripButton_28.Size = new Size(23, 22);
            this.toolStripButton_28.Text = "Отменить мерцание";
            this.toolStripButton_28.Click += this.uhjImiftgM;
            this.toolStripSeparator_10.Name = "toolStripSeparatorBookmark";
            this.toolStripSeparator_10.Size = new Size(6, 25);
            this.toolStripButton_29.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_29.Image = (Image)resources.GetObject("toolStripButtonPrevBookmark.Image");
            this.toolStripButton_29.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_29.Name = "toolStripButtonPrevBookmark";
            this.toolStripButton_29.Size = new Size(23, 22);
            this.toolStripButton_29.Text = "Предыдущая метка";
            this.toolStripButton_29.Click += this.toolStripButton_29_Click;
            this.toolStripButton_30.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_30.Image = (Image)resources.GetObject("toolStripButtonCurrentBookmark.Image");
            this.toolStripButton_30.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_30.Name = "toolStripButtonCurrentBookmark";
            this.toolStripButton_30.Size = new Size(23, 22);
            this.toolStripButton_30.Text = "Текущая метка";
            this.toolStripButton_30.Click += this.toolStripButton_30_Click;
            this.toolStripButton_31.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_31.Image = (Image)resources.GetObject("toolStripButtonNextBookmark.Image");
            this.toolStripButton_31.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_31.Name = "toolStripButtonNextBookmark";
            this.toolStripButton_31.Size = new Size(23, 22);
            this.toolStripButton_31.Text = "Cледующая метка";
            this.toolStripButton_31.Click += this.toolStripButton_31_Click;
            this.toolStripButton_32.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_32.Image = (Image)resources.GetObject("toolStripButtonRemoveAllBookmarks.Image");
            this.toolStripButton_32.ImageTransparentColor = Color.Red;
            this.toolStripButton_32.Name = "toolStripButtonRemoveAllBookmarks";
            this.toolStripButton_32.Size = new Size(23, 22);
            this.toolStripButton_32.Text = "Удалить все метки";
            this.toolStripButton_32.Click += this.toolStripButton_32_Click;
            this.toolStripSeparator_15.Name = "toolStripSeparator3";
            this.toolStripSeparator_15.Size = new Size(6, 25);
            this.toolStripButton_46.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_46.Image = Resources.smethod_28();
            this.toolStripButton_46.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_46.Name = "toolStripButtonFind";
            this.toolStripButton_46.Size = new Size(23, 22);
            this.toolStripButton_46.Text = "Поиск";
            this.toolStripButton_46.Click += this.toolStripButton_46_Click;
            this.toolStripTextBox_0.Name = "toolStripTextBoxFind";
            this.toolStripTextBox_0.Size = new Size(70, 25);
            this.toolStripTextBox_0.ToolTipText = "Текст для поиска";
            this.toolStripTextBox_0.KeyDown += this.toolStripTextBox_0_KeyDown;
            this.toolStripTextBox_0.TextChanged += this.toolStripTextBox_0_TextChanged;
            this.toolStripButton_47.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_47.Image = Resources.smethod_30();
            this.toolStripButton_47.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_47.Name = "toolStripButtonFindPrev";
            this.toolStripButton_47.Size = new Size(23, 22);
            this.toolStripButton_47.Text = "Поиск назад";
            this.toolStripButton_47.Click += this.toolStripButton_47_Click;
            this.toolStripButton_48.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_48.Image = Resources.smethod_29();
            this.toolStripButton_48.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_48.Name = "toolStripButtonFindNext";
            this.toolStripButton_48.Size = new Size(23, 22);
            this.toolStripButton_48.Text = "Поиск вперед";
            this.toolStripButton_48.Click += this.toolStripButton_48_Click;
            this.mniLotCpLE.Name = "toolStripSeparator14";
            this.mniLotCpLE.Size = new Size(6, 25);
            this.toolStripButton_54.BackColor = Color.Bisque;
            this.toolStripButton_54.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_54.Image = Resources.smethod_6();
            this.toolStripButton_54.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_54.Name = "toolBtnJournalAbonent";
            this.toolStripButton_54.Size = new Size(23, 22);
            this.toolStripButton_54.Text = "Журнал абонентов";
            this.toolStripButton_54.Click += this.toolStripButton_54_Click;
            this.toolStripContainer_0.ContentPanel.Controls.Add(this.panel_0);
            this.toolStripContainer_0.ContentPanel.Controls.Add(this.dockPanel1);
            this.toolStripContainer_0.ContentPanel.Size = new Size(973, 435);
            this.toolStripContainer_0.Dock = DockStyle.Fill;
            this.toolStripContainer_0.Location = new Point(0, 0);
            this.toolStripContainer_0.Name = "toolStripContainer1";
            this.toolStripContainer_0.Size = new Size(973, 535);
            this.toolStripContainer_0.TabIndex = 11;
            this.toolStripContainer_0.Text = "toolStripContainer1";
            this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStrip_4);
            this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStrip_3);
            this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStripTools);
            this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStrip_2);
            this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStrip_0);
            this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStrip_5);
            this.toolStripContainer_0.TopToolStripPanel.Controls.Add(this.toolStrip_6);
            this.dockPanel1.ActiveAutoHideContent = null;
            this.dockPanel1.Dock = DockStyle.Fill;
            this.dockPanel1.DockBackColor = SystemColors.Control;
            this.dockPanel1.DocumentStyle = DocumentStyle.DockingWindow; // 1
            this.dockPanel1.Location = new Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new Size(973, 435);
            dockPanelGradient.EndColor = SystemColors.ControlLight;
            dockPanelGradient.StartColor = SystemColors.ControlLight;
            autoHideStripSkin.DockStripGradient = dockPanelGradient;
            tabGradient.EndColor = SystemColors.Control;
            tabGradient.StartColor = SystemColors.Control;
            tabGradient.TextColor = SystemColors.ControlDarkDark;
            autoHideStripSkin.TabGradient = tabGradient;
            dockPanelSkin.AutoHideStripSkin = autoHideStripSkin;
            tabGradient2.EndColor = SystemColors.ControlLightLight;
            tabGradient2.StartColor = SystemColors.ControlLightLight;
            tabGradient2.TextColor = SystemColors.ControlText;
            dockPaneStripGradient.ActiveTabGradient = tabGradient2;
            dockPanelGradient2.EndColor = SystemColors.Control;
            dockPanelGradient2.StartColor = SystemColors.Control;
            dockPaneStripGradient.DockStripGradient = dockPanelGradient2;
            tabGradient3.EndColor = SystemColors.ControlLight;
            tabGradient3.StartColor = SystemColors.ControlLight;
            tabGradient3.TextColor = SystemColors.ControlText;
            dockPaneStripGradient.InactiveTabGradient = tabGradient3;
            dockPaneStripSkin.DocumentGradient = dockPaneStripGradient;
            tabGradient4.EndColor = SystemColors.ActiveCaption;
            tabGradient4.LinearGradientMode = LinearGradientMode.Vertical;
            tabGradient4.StartColor = SystemColors.GradientActiveCaption;
            tabGradient4.TextColor = SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient.ActiveCaptionGradient = tabGradient4;
            tabGradient5.EndColor = SystemColors.Control;
            tabGradient5.StartColor = SystemColors.Control;
            tabGradient5.TextColor = SystemColors.ControlText;
            dockPaneStripToolWindowGradient.ActiveTabGradient = tabGradient5;
            dockPanelGradient3.EndColor = SystemColors.ControlLight;
            dockPanelGradient3.StartColor = SystemColors.ControlLight;
            dockPaneStripToolWindowGradient.DockStripGradient = dockPanelGradient3;
            tabGradient6.EndColor = SystemColors.GradientInactiveCaption;
            tabGradient6.LinearGradientMode = LinearGradientMode.Vertical;
            tabGradient6.StartColor = SystemColors.GradientInactiveCaption;
            tabGradient6.TextColor = SystemColors.ControlText;
            dockPaneStripToolWindowGradient.InactiveCaptionGradient = tabGradient6;
            tabGradient7.EndColor = Color.Transparent;
            tabGradient7.StartColor = Color.Transparent;
            tabGradient7.TextColor = SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient.InactiveTabGradient = tabGradient7;
            dockPaneStripSkin.ToolWindowGradient = dockPaneStripToolWindowGradient;
            dockPanelSkin.DockPaneStripSkin = dockPaneStripSkin;
            this.dockPanel1.Skin = dockPanelSkin;
            this.dockPanel1.TabIndex = 0;
            this.dockPanel1.Resize += this.dockPanel_0_Resize;
            this.toolStrip_6.Dock = DockStyle.None;
            this.toolStrip_6.Items.AddRange(new ToolStripItem[]
            {
                this.toolStripButton_5,
                this.toolStripButton_50,
                this.toolStripButton_51
            });
            this.toolStrip_6.Location = new Point(3, 75);
            this.toolStrip_6.Name = "toolStripTelemetry";
            this.toolStrip_6.Size = new Size(112, 25);
            this.toolStrip_6.TabIndex = 11;
            this.toolStrip_6.Visible = false;
            this.dataGridViewImageColumn_18.Name = "dataGridViewImageColumn24";
            this.dataGridViewImageColumn_18.ReadOnly = true;
            this.dataGridViewImageColumn_18.Width = 20;
            this.dataGridViewImageColumn_17.Name = "dataGridViewImageColumn23";
            this.dataGridViewImageColumn_17.ReadOnly = true;
            this.dataGridViewImageColumn_17.Width = 20;
            this.dataGridViewImageColumn_16.Name = "dataGridViewImageColumn22";
            this.dataGridViewImageColumn_16.ReadOnly = true;
            this.dataGridViewImageColumn_16.Width = 20;
            this.dataGridViewImageColumn_15.Name = "dataGridViewImageColumn21";
            this.dataGridViewImageColumn_15.ReadOnly = true;
            this.dataGridViewImageColumn_15.Width = 20;
            this.dataGridViewImageColumn_14.Name = "dataGridViewImageColumn20";
            this.dataGridViewImageColumn_14.ReadOnly = true;
            this.dataGridViewImageColumn_14.Width = 20;
            this.dataGridViewImageColumn_13.Name = "dataGridViewImageColumn19";
            this.dataGridViewImageColumn_13.ReadOnly = true;
            this.dataGridViewImageColumn_13.Width = 20;
            this.dataGridViewImageColumn_12.Name = "dataGridViewImageColumn18";
            this.dataGridViewImageColumn_12.ReadOnly = true;
            this.dataGridViewImageColumn_12.Width = 20;
            this.dataGridViewImageColumn_11.Name = "dataGridViewImageColumn17";
            this.dataGridViewImageColumn_11.ReadOnly = true;
            this.dataGridViewImageColumn_11.Width = 20;
            this.dataGridViewImageColumn_10.Name = "dataGridViewImageColumn16";
            this.dataGridViewImageColumn_10.ReadOnly = true;
            this.dataGridViewImageColumn_10.Width = 20;
            this.dataGridViewImageColumn_9.Name = "dataGridViewImageColumn15";
            this.dataGridViewImageColumn_9.ReadOnly = true;
            this.dataGridViewImageColumn_9.Width = 20;
            this.dataGridViewImageColumn_7.Name = "dataGridViewImageColumn13";
            this.dataGridViewImageColumn_7.ReadOnly = true;
            this.dataGridViewImageColumn_7.Width = 20;
            this.dataGridViewImageColumn_6.Name = "dataGridViewImageColumn12";
            this.dataGridViewImageColumn_6.ReadOnly = true;
            this.dataGridViewImageColumn_6.Width = 20;
            this.dataGridViewImageColumn_3.Name = "dataGridViewImageColumn9";
            this.dataGridViewImageColumn_3.ReadOnly = true;
            this.dataGridViewImageColumn_3.Width = 20;
            this.dataGridViewImageColumn_2.Name = "dataGridViewImageColumn8";
            this.dataGridViewImageColumn_2.ReadOnly = true;
            this.dataGridViewImageColumn_2.Width = 20;
            this.dataGridViewImageColumn_1.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn_1.ReadOnly = true;
            this.dataGridViewImageColumn_1.Width = 20;
            this.dataGridViewImageColumn_0.Frozen = true;
            this.dataGridViewImageColumn_0.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn_0.ReadOnly = true;
            this.dataGridViewImageColumn_0.Width = 20;
            this.dataGridViewImageColumn_4.Name = "dataGridViewImageColumn10";
            this.dataGridViewImageColumn_4.ReadOnly = true;
            this.dataGridViewImageColumn_4.Width = 20;
            this.dataGridViewImageColumn_5.Name = "dataGridViewImageColumn11";
            this.dataGridViewImageColumn_5.ReadOnly = true;
            this.dataGridViewImageColumn_5.Width = 20;
            this.dataGridViewImageColumn_8.Name = "dataGridViewImageColumn14";
            this.dataGridViewImageColumn_8.ReadOnly = true;
            this.dataGridViewImageColumn_8.Width = 20;
            this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn_18.ReadOnly = true;
            this.dataGridViewTextBoxColumn_18.Width = 50;
            this.dataGridViewTextBoxColumn_19.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn_19.ReadOnly = true;
            this.dataGridViewTextBoxColumn_17.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn_17.ReadOnly = true;
            this.dataGridViewTextBoxColumn_16.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn_16.ReadOnly = true;
            this.dataGridViewTextBoxColumn_15.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn_15.ReadOnly = true;
            this.dataGridViewTextBoxColumn_14.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn_14.ReadOnly = true;
            this.dataGridViewTextBoxColumn_13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewTextBoxColumn_12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewTextBoxColumn_11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewTextBoxColumn_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewTextBoxColumn_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewTextBoxColumn_8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewTextBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewTextBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.QynLzkVuoQ.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.QynLzkVuoQ.Image = (Image)resources.GetObject("toolStripButton2.Image");
            this.QynLzkVuoQ.ImageTransparentColor = Color.Magenta;
            this.QynLzkVuoQ.Name = "toolStripButton2";
            this.QynLzkVuoQ.Size = new Size(23, 22);
            this.QynLzkVuoQ.Text = "toolStripButton2";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(973, 535);
            base.Controls.Add(this.toolStripContainer_0);
            this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            base.Icon = (Icon)resources.GetObject("$this.Icon");
            base.KeyPreview = true;
            base.Name = "FormGeneralScheme2";
            this.Text = "Схема";
            base.WindowState = FormWindowState.Maximized;
            base.FormClosing += this.FormGeneralScheme2_FormClosing;
            base.Load += this.FormGeneralScheme2_Load;
            base.KeyDown += this.FormGeneralScheme2_KeyDown;
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.toolStripTools.ResumeLayout(false);
            this.toolStripTools.PerformLayout();
            this.contextMenuStrip_0.ResumeLayout(false);
            this.panel_0.ResumeLayout(false);
            this.panel_0.PerformLayout();
            this.toolStrip_2.ResumeLayout(false);
            this.toolStrip_2.PerformLayout();
            this.toolStrip_3.ResumeLayout(false);
            this.toolStrip_3.PerformLayout();
            this.toolStrip_4.ResumeLayout(false);
            this.toolStrip_4.PerformLayout();
            this.toolStrip_5.ResumeLayout(false);
            this.toolStrip_5.PerformLayout();
            this.toolStripContainer_0.ContentPanel.ResumeLayout(false);
            this.toolStripContainer_0.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer_0.TopToolStripPanel.PerformLayout();
            this.toolStripContainer_0.ResumeLayout(false);
            this.toolStripContainer_0.PerformLayout();
            this.toolStrip_6.ResumeLayout(false);
            this.toolStrip_6.PerformLayout();
            base.ResumeLayout(false);
        }

        #endregion



        private ToolStrip toolStrip_0;
        private BackgroundWorker backgroundWorker_0;
        private ToolStrip toolStripTools;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private DataGridViewImageColumn dataGridViewImageColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripButton toolStripButton_3;
        private DataGridViewImageColumn dataGridViewImageColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewImageColumn dataGridViewImageColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewImageColumn dataGridViewImageColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewImageColumn dataGridViewImageColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewImageColumn dataGridViewImageColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewImageColumn dataGridViewImageColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewImageColumn dataGridViewImageColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewImageColumn dataGridViewImageColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewImageColumn dataGridViewImageColumn_9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private DataGridViewImageColumn dataGridViewImageColumn_10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;
        private DataGridViewImageColumn dataGridViewImageColumn_11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
        private DataGridViewImageColumn dataGridViewImageColumn_12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;
        private DataGridViewImageColumn dataGridViewImageColumn_13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;
        private DataGridViewImageColumn dataGridViewImageColumn_14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;
        private DataGridViewImageColumn dataGridViewImageColumn_15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;
        private DataGridViewImageColumn dataGridViewImageColumn_16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;
        private DataGridViewImageColumn dataGridViewImageColumn_17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;
        private DataGridViewImageColumn dataGridViewImageColumn_18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;
        private DockPanel dockPanel1;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripButton toolStripButton_6;
        private ToolStripButton toolStripButton_7;
        private ToolStripButton toolStripButton_8;
        private ToolStripButton toolStripButton_9;
        private ToolStripButton toolStripButton_10;
        private ContextMenuStrip contextMenuStrip_0;
        private ToolStripMenuItem toolStripMenuItem_0;
        private ToolStripMenuItem toolStripMenuItem_1;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripMenuItem toolStripMenuItem_2;
        private ToolStripMenuItem toolStripMenuItem_3;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripMenuItem toolStripMenuItem_4;
        private ToolStripMenuItem toolStripMenuItem_5;
        private ToolStripMenuItem pYnMneGkhg;
        private ToolStripMenuItem toolStripMenuItem_6;
        private ToolStripSeparator toolStripSeparator_3;
        private ToolStripMenuItem toolStripMenuItem_7;
        private ToolStripSeparator toolStripSeparator_4;
        private ToolStripMenuItem toolStripMenuItem_8;
        private ToolStripMenuItem toolStripMenuItem_9;
        private BackgroundWorker backgroundWorker_1;
        private Panel panel_0;
        private Label label_0;
        private ProgressBarEndLess progressBarEndLess_0;
        private ToolStripSeparator toolStripSeparator_5;
        private ToolStripMenuItem toolStripMenuItem_10;
        private ToolStripMenuItem toolStripMenuItem_11;
        private ToolStripMenuItem toolStripMenuItem_12;
        private ToolStripMenuItem toolStripMenuItem_13;
        private ToolStripMenuItem toolStripMenuItem_14;
        private ToolStripMenuItem toolStripMenuItem_15;
        private ToolStripMenuItem toolStripMenuItem_16;
        private ToolStripMenuItem toolStripMenuItem_17;
        private ToolStripMenuItem toolStripMenuItem_18;
        private ToolStripButton toolStripButton_11;
        private ToolStripButton toolStripButton_12;
        private ToolStripSeparator toolStripSeparator_6;
        private ToolStrip toolStrip_2;
        private ToolStripButton toolStripButton_13;
        private ToolStripButton toolStripButton_14;
        private ToolStripButton toolStripButton_15;
        private ToolStrip toolStrip_3;
        private ToolStripButton toolStripButton_16;
        private ToolStripButton toolStripButton_17;
        private ToolStripButton toolStripButton_18;
        private ToolStripSeparator toolStripSeparator_7;
        private ToolStripButton toolStripButton_19;
        private ToolStrip toolStrip_4;
        private ToolStripButton toolStripButton_20;
        private ToolStripSeparator toolStripSeparator_8;
        private ToolStripButton toolStripButton_21;
        private ToolStripButton toolStripButton_22;
        private ToolStripButton toolStripButton_23;
        private ToolStripButton toolStripButton_24;
        private ToolStripButton toolStripButton_25;
        private ToolStrip toolStrip_5;
        private ToolStripButton toolStripButton_26;
        private ToolStripButton toolStripButton_27;
        private ToolStripSeparator toolStripSeparator_9;
        private ToolStripButton toolStripButton_28;
        private ToolStripSeparator toolStripSeparator_10;
        private ToolStripButton toolStripButton_29;
        private ToolStripButton toolStripButton_30;
        private ToolStripButton toolStripButton_31;
        private ToolStripButton toolStripButton_32;
        private ToolStripSeparator toolStripSeparator_11;
        private ToolStripLabel toolStripLabel_0;
        private ToolStripComboBox toolStripComboBox_0;
        private ToolStripSplitButton toolStripSplitButton_0;
        private ToolStripMenuItem toolStripMenuItem_19;
        private ToolStripMenuItem toolStripMenuItem_20;
        private ToolStripMenuItem toolStripMenuItem_21;
        private ToolStripProgressBar toolStripProgressBar_0;
        private ToolStripLabel toolStripLabel_1;
        private ToolStripMenuItem toolStripMenuItem_22;
        private ToolStripContainer toolStripContainer_0;
        private ToolStripMenuItem toolStripMenuItem_23;
        private ToolStripMenuItem toolStripMenuItem_24;
        private ToolStripButton toolStripButton_33;
        private ToolStripButton toolStripButton_34;
        private ToolStripMenuItem toolStripMenuItem_25;
        private ToolStripMenuItem toolStripMenuItem_26;
        private ToolStripButton toolStripButton_35;
        private ToolStripSeparator toolStripSeparator_12;
        private ToolStripMenuItem toolStripMenuItem_27;
        private ToolStripMenuItem toolStripMenuItem_28;
        private ToolStripMenuItem toolStripMenuItem_29;
        private ToolStripMenuItem toolStripMenuItem_30;
        private ToolStripMenuItem toolStripMenuItem_31;
        private ToolStripMenuItem toolStripMenuItem_32;
        private ToolStripMenuItem toolStripMenuItem_33;
        private ToolStripMenuItem toolStripMenuItem_34;
        private ToolStripButton toolStripButton_36;
        private ToolStripButton toolStripButton_37;
        private ToolStripMenuItem toolStripMenuItem_35;
        private ToolStripSeparator toolStripSeparator_13;
        private ToolStripButton toolStripButton_38;
        private ToolStripButton toolStripButton_39;
        private ToolStripSeparator toolStripSeparator_14;
        private ToolStripButton toolStripButton_40;
        private ToolStripButton toolStripButton_41;
        private ToolStripButton toolStripButton_42;
        private ToolStripButton toolStripButton_43;
        private ToolStripComboBox toolStripComboBox_1;
        private ToolStripButton toolStripButton_44;
        private ToolStripButton toolStripButton_45;
        private ToolStripMenuItem toolStripMenuItem_36;
        private ToolStripMenuItem toolStripMenuItem_37;
        private ToolStripMenuItem toolStripMenuItem_38;
        private ToolStripSeparator toolStripSeparator_15;
        private ToolStripTextBox toolStripTextBox_0;
        private ToolStripButton toolStripButton_46;
        private ToolStripButton toolStripButton_47;
        private ToolStripButton toolStripButton_48;
        private ToolStripMenuItem toolStripMenuItem_39;
        private ToolStripButton toolStripButton_49;
        private ToolStripMenuItem toolStripMenuItem_40;
        private ToolStripButton toolStripButton_50;
        private ToolStripButton toolStripButton_51;
        private ToolStripButton toolStripButton_52;
        private ToolStripButton toolStripButton_53;
        private ToolStripMenuItem toolStripMenuItem_41;
        private ToolStripMenuItem toolStripMenuItem_42;
        private ToolStripMenuItem toolStripMenuItem_43;
        private ToolStripMenuItem toolStripMenuItem_44;
        private ToolStripSeparator toolStripSeparator_16;
        private ToolStripSeparator toolStripSeparator_17;
        private ToolStripMenuItem toolStripMenuItem_45;
        private ToolStripMenuItem toolStripMenuItem_46;
        private ToolStripMenuItem toolStripMenuItem_47;
        private ToolStripComboBox toolStripComboBox_2;
        private ToolStripSeparator mniLotCpLE;
        private ToolStripButton toolStripButton_54;
        private ToolStripMenuItem toolStripMenuItem_48;
        private ToolStripMenuItem toolStripMenuItem_49;
        private ToolStripMenuItem toolStripMenuItem_50;
        private ToolStripSeparator toolStripSeparator_18;
        private ToolStripMenuItem toolStripMenuItem_51;
        private ToolStripMenuItem IlbLiynpEJ;
        private ToolStrip toolStrip_6;
        private ToolStripButton QynLzkVuoQ;
    }
}