using Measurement.DataSets;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Documents.Measurement
{
    partial class FormMeasurement
    {
        private IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        //private void InitializeComponent()
        //{
        //    ComponentResourceManager resources = new ComponentResourceManager(typeof(FormMeasurement));
        //    DataGridViewCellStyle style = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style2 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style3 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style4 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style5 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style6 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style7 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style8 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style9 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style10 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style11 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style12 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style13 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style14 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style15 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style16 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style17 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style18 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style19 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style20 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style21 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style22 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style23 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style24 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style25 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style26 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style27 = new DataGridViewCellStyle();
        //    DataGridViewCellStyle style28 = new DataGridViewCellStyle();
        //    this.tableLayoutPanel_0 = new TableLayoutPanel();
        //    this.treeView_0 = new TreeView();
        //    this.toolStrip_0 = new ToolStrip();
        //    this.toolStripTextBox_0 = new ToolStripTextBox();
        //    this.toolStripButton_0 = new ToolStripButton();
        //    this.toolStripButton_1 = new ToolStripButton();
        //    this.toolStripSeparator_0 = new ToolStripSeparator();
        //    this.toolStripButton_2 = new ToolStripButton();
        //    this.tableLayoutPanel_1 = new TableLayoutPanel();
        //    this.toolStrip_1 = new ToolStrip();
        //    this.toolStripButton_3 = new ToolStripButton();
        //    this.toolStripButton_4 = new ToolStripButton();
        //    this.toolStripButton_5 = new ToolStripButton();
        //    this.toolStripSeparator_1 = new ToolStripSeparator();
        //    this.toolStripButton_6 = new ToolStripButton();
        //    this.toolStripSeparator_3 = new ToolStripSeparator();
        //    this.toolStripButton_7 = new ToolStripButton();
        //    this.toolStripSeparator_4 = new ToolStripSeparator();
        //    this.toolStripSplitButton_1 = new ToolStripSplitButton();
        //    this.toolStripMenuItem_4 = new ToolStripMenuItem();
        //    this.toolStripMenuItem_5 = new ToolStripMenuItem();
        //    this.toolStripSeparator_2 = new ToolStripSeparator();
        //    this.toolStripLabel_0 = new ToolStripLabel();
        //    this.toolStripComboBox_0 = new ToolStripComboBox();
        //    this.toolStripSplitButton_0 = new ToolStripSplitButton();
        //    this.toolStripMenuItem_0 = new ToolStripMenuItem();
        //    this.toolStripMenuItem_1 = new ToolStripMenuItem();
        //    this.toolStripMenuItem_2 = new ToolStripMenuItem();
        //    this.toolStripMenuItem_3 = new ToolStripMenuItem();
        //    this.toolStripMenuItem_6 = new ToolStripMenuItem();
        //    this.toolStripMenuItem_7 = new ToolStripMenuItem();
        //    this.toolStripButton_8 = new ToolStripButton();
        //    this.toolStripButton_9 = new ToolStripButton();
        //    this.button_0 = new Button();
        //    this.tableLayoutPanel_3 = new TableLayoutPanel();
        //    this.comboBox_0 = new ComboBox();
        //    this.bsBusesTransfs = new BindingSource();
        //    this.dsJournal = new DataSetGES();
        //    this.label_0 = new Label();
        //    this.tabControl_0 = new TabControl();
        //    this.tabPage_0 = new TabPage();
        //    this.label_1 = new Label();
        //    this.label_2 = new Label();
        //    this.label_3 = new Label();
        //    this.label_4 = new Label();
        //    this.label_5 = new Label();
        //    this.label_6 = new Label();
        //    this.textBox_0 = new TextBox();
        //    this.textBox_1 = new TextBox();
        //    this.tbKNTn = new TextBox();
        //    this.tbKNTd = new TextBox();
        //    this.tbIsrn = new TextBox();
        //    this.tbIsrd = new TextBox();
        //    this.tabPage_1 = new TabPage();
        //    this.dataGridView_0 = new DataGridView();
        //    this.dataGridViewTextBoxColumn_145 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_146 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_147 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_148 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_149 = new DataGridViewTextBoxColumn();
        //    this.bindingSource_8 = new BindingSource();
        //    this.panel_0 = new Panel();
        //    this.label_7 = new Label();
        //    this.label_8 = new Label();
        //    this.label_9 = new Label();
        //    this.label_10 = new Label();
        //    this.label_11 = new Label();
        //    this.panel_1 = new Panel();
        //    this.textBox_6 = new TextBox();
        //    this.bindingSource_0 = new BindingSource();
        //    this.textBox_7 = new TextBox();
        //    this.label_12 = new Label();
        //    this.label_13 = new Label();
        //    this.panel_2 = new Panel();
        //    this.comboBox_1 = new ComboBox();
        //    this.bindingSource_1 = new BindingSource();
        //    this.bindingSource_12 = new BindingSource();
        //    this.panel_3 = new Panel();
        //    this.tbTransAmperage = new TextBox();
        //    this.panel_4 = new Panel();
        //    this.textBox_9 = new TextBox();
        //    this.panel_5 = new Panel();
        //    this.textBox_10 = new TextBox();
        //    this.dataGridView_1 = new DataGridView();
        //    this.dataGridViewTextBoxColumn_135 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_136 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_137 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_138 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_139 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_140 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_141 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_142 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_143 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_144 = new DataGridViewTextBoxColumn();
        //    this.panel_6 = new Panel();
        //    this.panel_7 = new Panel();
        //    this.label_14 = new Label();
        //    this.panel_8 = new Panel();
        //    this.panel_9 = new Panel();
        //    this.label_15 = new Label();
        //    this.label_16 = new Label();
        //    this.label_17 = new Label();
        //    this.panel_10 = new Panel();
        //    this.textBox_11 = new TextBox();
        //    this.textBox_12 = new TextBox();
        //    this.textBox_13 = new TextBox();
        //    this.textBox_14 = new TextBox();
        //    this.textBox_15 = new TextBox();
        //    this.textBox_16 = new TextBox();
        //    this.panel_11 = new Panel();
        //    this.label_18 = new Label();
        //    this.label_19 = new Label();
        //    this.label_20 = new Label();
        //    this.panel_12 = new Panel();
        //    this.textBox_17 = new TextBox();
        //    this.textBox_18 = new TextBox();
        //    this.textBox_19 = new TextBox();
        //    this.textBox_20 = new TextBox();
        //    this.textBox_21 = new TextBox();
        //    this.textBox_22 = new TextBox();
        //    this.panel_13 = new Panel();
        //    this.label_21 = new Label();
        //    this.label_22 = new Label();
        //    this.dataGridView_2 = new DataGridView();
        //    this.dataGridViewCheckBoxColumn_3 = new DataGridViewCheckBoxColumn();
        //    this.dataGridViewTextBoxColumn_112 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_113 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_114 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_115 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_116 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_117 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_118 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_119 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_120 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_121 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_122 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_123 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_124 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_125 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_126 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_127 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_128 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_129 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_130 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_131 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_132 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_133 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_134 = new DataGridViewTextBoxColumn();
        //    this.bindingSource_7 = new BindingSource();
        //    this.dataGridView_3 = new DataGridView();
        //    this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
        //    this.bindingSource_10 = new BindingSource();
        //    this.dataGridViewComboBoxColumn_1 = new DataGridViewComboBoxColumn();
        //    this.bindingSource_19 = new BindingSource();
        //    this.dataGridViewCheckBoxColumn_4 = new DataGridViewCheckBoxColumn();
        //    this.dataGridViewTextBoxColumn_150 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_151 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_152 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_153 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_154 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_155 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_156 = new DataGridViewTextBoxColumn();
        //    this.bindingSource_9 = new BindingSource();
        //    this.tableLayoutPanel_4 = new TableLayoutPanel();
        //    this.panel_14 = new Panel();
        //    this.label_24 = new Label();
        //    this.label_25 = new Label();
        //    this.label_26 = new Label();
        //    this.label_27 = new Label();
        //    this.panel_15 = new Panel();
        //    this.textBox_23 = new TextBox();
        //    this.textBox_24 = new TextBox();
        //    this.label_28 = new Label();
        //    this.label_29 = new Label();
        //    this.panel_16 = new Panel();
        //    this.textBox_25 = new TextBox();
        //    this.panel_17 = new Panel();
        //    this.textBox_26 = new TextBox();
        //    this.panel_18 = new Panel();
        //    this.textBox_27 = new TextBox();
        //    this.panel_19 = new Panel();
        //    this.panel_20 = new Panel();
        //    this.label_31 = new Label();
        //    this.panel_21 = new Panel();
        //    this.label_32 = new Label();
        //    this.panel_22 = new Panel();
        //    this.label_33 = new Label();
        //    this.panel_23 = new Panel();
        //    this.textBox_28 = new TextBox();
        //    this.bindingSource_11 = new BindingSource();
        //    this.panel_24 = new Panel();
        //    this.textBox_29 = new TextBox();
        //    this.label_34 = new Label();
        //    this.panel_25 = new Panel();
        //    this.textBox_30 = new TextBox();
        //    this.dataGridView_4 = new DataGridView();
        //    this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
        //    this.dataGridView_5 = new DataGridView();
        //    this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
        //    this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
        //    this.bindingSource_16 = new BindingSource();
        //    this.label_23 = new Label();
        //    this.comboBox_2 = new ComboBox();
        //    this.label_30 = new Label();
        //    this.bindingSource_15 = new BindingSource();
        //    this.tableLayoutPanel_2 = new TableLayoutPanel();
        //    this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
        //    this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
        //    this.bindingSource_3 = new BindingSource();
        //    this.bindingSource_4 = new BindingSource();
        //    this.bindingSource_5 = new BindingSource();
        //    this.bindingSource_6 = new BindingSource();
        //    this.bindingSource_2 = new BindingSource();
        //    this.bindingSource_13 = new BindingSource();
        //    this.bindingSource_14 = new BindingSource();
        //    this.dataGridViewTextBoxColumn_53 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_54 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_55 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_56 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_57 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_58 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_59 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_60 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_61 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_62 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_63 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_64 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_65 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_66 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_67 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_68 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_69 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_70 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_71 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_72 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_73 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_74 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_75 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_76 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_77 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_78 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_79 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_80 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_81 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_82 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_83 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_84 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_85 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_86 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_87 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_88 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_89 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_90 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_91 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_92 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_93 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_94 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_95 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_96 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_97 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_98 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_99 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_100 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_101 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_102 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_103 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_104 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_105 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_106 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_107 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_108 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_109 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_110 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_111 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
        //    this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
        //    this.bindingSource_18 = new BindingSource();
        //    this.tableLayoutPanel_0.SuspendLayout();
        //    this.toolStrip_0.SuspendLayout();
        //    this.tableLayoutPanel_1.SuspendLayout();
        //    this.toolStrip_1.SuspendLayout();
        //    this.tableLayoutPanel_3.SuspendLayout();
        //    ((ISupportInitialize)this.bsBusesTransfs).BeginInit();
        //    this.dsJournal.BeginInit();
        //    this.tabControl_0.SuspendLayout();
        //    this.tabPage_0.SuspendLayout();
        //    this.tabPage_1.SuspendLayout();
        //    ((ISupportInitialize)this.dataGridView_0).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_8).BeginInit();
        //    this.panel_0.SuspendLayout();
        //    this.panel_1.SuspendLayout();
        //    ((ISupportInitialize)this.bindingSource_0).BeginInit();
        //    this.panel_2.SuspendLayout();
        //    ((ISupportInitialize)this.bindingSource_1).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_12).BeginInit();
        //    this.panel_3.SuspendLayout();
        //    this.panel_4.SuspendLayout();
        //    this.panel_5.SuspendLayout();
        //    ((ISupportInitialize)this.dataGridView_1).BeginInit();
        //    this.panel_6.SuspendLayout();
        //    this.panel_7.SuspendLayout();
        //    this.panel_9.SuspendLayout();
        //    this.panel_10.SuspendLayout();
        //    this.panel_11.SuspendLayout();
        //    this.panel_12.SuspendLayout();
        //    this.panel_13.SuspendLayout();
        //    ((ISupportInitialize)this.dataGridView_2).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_7).BeginInit();
        //    ((ISupportInitialize)this.dataGridView_3).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_10).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_19).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_9).BeginInit();
        //    this.tableLayoutPanel_4.SuspendLayout();
        //    this.panel_14.SuspendLayout();
        //    this.panel_15.SuspendLayout();
        //    this.panel_16.SuspendLayout();
        //    this.panel_17.SuspendLayout();
        //    this.panel_18.SuspendLayout();
        //    this.panel_19.SuspendLayout();
        //    this.panel_20.SuspendLayout();
        //    this.panel_21.SuspendLayout();
        //    this.panel_22.SuspendLayout();
        //    this.panel_23.SuspendLayout();
        //    ((ISupportInitialize)this.bindingSource_11).BeginInit();
        //    this.panel_24.SuspendLayout();
        //    this.panel_25.SuspendLayout();
        //    ((ISupportInitialize)this.dataGridView_4).BeginInit();
        //    ((ISupportInitialize)this.dataGridView_5).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_16).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_15).BeginInit();
        //    this.tableLayoutPanel_2.SuspendLayout();
        //    ((ISupportInitialize)this.bindingSource_3).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_4).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_5).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_6).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_2).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_13).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_14).BeginInit();
        //    ((ISupportInitialize)this.bindingSource_18).BeginInit();
        //    base.SuspendLayout();
        //    this.tableLayoutPanel_0.ColumnCount = 1;
        //    this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
        //    this.tableLayoutPanel_0.Controls.Add(this.treeView_0, 0, 1);
        //    this.tableLayoutPanel_0.Controls.Add(this.toolStrip_0, 0, 0);
        //    this.tableLayoutPanel_0.Dock = DockStyle.Fill;
        //    this.tableLayoutPanel_0.Location = new Point(3, 3);
        //    this.tableLayoutPanel_0.Name = "tlpTreeView";
        //    this.tableLayoutPanel_0.RowCount = 2;
        //    this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
        //    this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
        //    this.tableLayoutPanel_0.Size = new Size(0xce, 0x22c);
        //    this.tableLayoutPanel_0.TabIndex = 0;
        //    this.treeView_0.Dock = DockStyle.Fill;
        //    this.treeView_0.HideSelection = false;
        //    this.treeView_0.Location = new Point(3, 0x1c);
        //    this.treeView_0.MinimumSize = new Size(200, 4);
        //    this.treeView_0.Name = "trvObject";
        //    this.treeView_0.Size = new Size(200, 0x20d);
        //    this.treeView_0.TabIndex = 6;
        //    this.treeView_0.BeforeExpand += new TreeViewCancelEventHandler(this.treeView_0_BeforeExpand);
        //    this.treeView_0.AfterSelect += new TreeViewEventHandler(this.treeView_0_AfterSelect);
        //    ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripTextBox_0, this.toolStripButton_0, this.toolStripButton_1, this.toolStripSeparator_0, this.toolStripButton_2 };
        //    this.toolStrip_0.Items.AddRange(toolStripItems);
        //    this.toolStrip_0.Location = new Point(0, 0);
        //    this.toolStrip_0.Name = "tsTree";
        //    this.toolStrip_0.Size = new Size(0xce, 0x19);
        //    this.toolStrip_0.TabIndex = 5;
        //    this.toolStrip_0.Text = "Панель инструментов дерва данных";
        //    this.toolStripTextBox_0.Name = "tstbFindObj";
        //    this.toolStripTextBox_0.Size = new Size(100, 0x19);
        //    this.toolStripTextBox_0.KeyPress += new KeyPressEventHandler(this.toolStripTextBox_0_KeyPress);
        //    this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //    this.toolStripButton_0.Image = (Image)resources.GetObject("tsbFindObj.Image");
        //    this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButton_0.Name = "tsbFindObj";
        //    this.toolStripButton_0.Size = new Size(0x17, 0x16);
        //    this.toolStripButton_0.Text = "Найти";
        //    this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
        //    this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //    this.toolStripButton_1.Image = (Image)resources.GetObject("tsbFindNextObj.Image");
        //    this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButton_1.Name = "tsbFindNextObj";
        //    this.toolStripButton_1.Size = new Size(0x17, 0x16);
        //    this.toolStripButton_1.Text = "Найти далее";
        //    this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
        //    this.toolStripSeparator_0.Name = "toolStripSeparator10";
        //    this.toolStripSeparator_0.Size = new Size(6, 0x19);
        //    this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //    this.toolStripButton_2.Image = (Image)resources.GetObject("tsbSortTree.Image");
        //    this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButton_2.Name = "tsbSortTree";
        //    this.toolStripButton_2.Size = new Size(0x17, 0x16);
        //    this.toolStripButton_2.Text = "Сортировка";
        //    this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
        //    this.tableLayoutPanel_1.ColumnCount = 3;
        //    this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 4f));
        //    this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
        //    this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 4f));
        //    this.tableLayoutPanel_1.Controls.Add(this.toolStrip_1, 0, 0);
        //    this.tableLayoutPanel_1.Controls.Add(this.button_0, 1, 4);
        //    this.tableLayoutPanel_1.Controls.Add(this.tableLayoutPanel_3, 1, 2);
        //    this.tableLayoutPanel_1.Controls.Add(this.dataGridView_3, 1, 1);
        //    this.tableLayoutPanel_1.Controls.Add(this.tableLayoutPanel_4, 1, 3);
        //    this.tableLayoutPanel_1.Dock = DockStyle.Fill;
        //    this.tableLayoutPanel_1.Location = new Point(0xd7, 3);
        //    this.tableLayoutPanel_1.Name = "tlpGeneral";
        //    this.tableLayoutPanel_1.RowCount = 5;
        //    this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
        //    this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97f));
        //    this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
        //    this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
        //    this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37f));
        //    this.tableLayoutPanel_1.Size = new Size(0x330, 0x22c);
        //    this.tableLayoutPanel_1.TabIndex = 0;
        //    this.tableLayoutPanel_1.SetColumnSpan(this.toolStrip_1, 3);
        //    ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripButton_3, this.toolStripButton_4, this.toolStripButton_5, this.toolStripSeparator_1, this.toolStripButton_6, this.toolStripSeparator_3, this.toolStripButton_7, this.toolStripSeparator_4, this.toolStripSplitButton_1, this.toolStripSeparator_2, this.toolStripLabel_0, this.toolStripComboBox_0, this.toolStripSplitButton_0, this.toolStripButton_8, this.toolStripButton_9 };
        //    this.toolStrip_1.Items.AddRange(itemArray2);
        //    this.toolStrip_1.Location = new Point(0, 0);
        //    this.toolStrip_1.Name = "tsGeneral";
        //    this.toolStrip_1.Size = new Size(0x330, 0x19);
        //    this.toolStrip_1.TabIndex = 1;
        //    this.toolStrip_1.Text = "toolStrip1";
        //    this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //    this.toolStripButton_3.Image = (Image)resources.GetObject("tssbMeasAdd.Image");
        //    this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButton_3.Name = "tssbMeasAdd";
        //    this.toolStripButton_3.Size = new Size(0x17, 0x16);
        //    this.toolStripButton_3.Text = "Добавить";
        //    this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
        //    this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //    this.toolStripButton_4.Image = (Image)resources.GetObject("tsbMeasEdit.Image");
        //    this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButton_4.Name = "tsbMeasEdit";
        //    this.toolStripButton_4.Size = new Size(0x17, 0x16);
        //    this.toolStripButton_4.Text = "Редактировать";
        //    this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
        //    this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //    this.toolStripButton_5.Image = (Image)resources.GetObject("tsbMeasDelete.Image");
        //    this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButton_5.Name = "tsbMeasDelete";
        //    this.toolStripButton_5.Size = new Size(0x17, 0x16);
        //    this.toolStripButton_5.Text = "Удалить";
        //    this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
        //    this.toolStripSeparator_1.Name = "toolStripSeparator2";
        //    this.toolStripSeparator_1.Size = new Size(6, 0x19);
        //    this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //    this.toolStripButton_6.Image = (Image)resources.GetObject("tsbMeasRefresh.Image");
        //    this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButton_6.Name = "tsbMeasRefresh";
        //    this.toolStripButton_6.Size = new Size(0x17, 0x16);
        //    this.toolStripButton_6.Text = "Обновить";
        //    this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
        //    this.toolStripSeparator_3.Name = "toolStripSeparator3";
        //    this.toolStripSeparator_3.Size = new Size(6, 0x19);
        //    this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //    this.toolStripButton_7.Image = (Image)resources.GetObject("tsbPrint.Image");
        //    this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButton_7.Name = "tsbPrint";
        //    this.toolStripButton_7.Size = new Size(0x17, 0x16);
        //    this.toolStripButton_7.Text = "Печать листка замеров";
        //    this.toolStripButton_7.Click += new EventHandler(this.tsbPrint_Click);
        //    this.toolStripSeparator_4.Name = "tssPrint";
        //    this.toolStripSeparator_4.Size = new Size(6, 0x19);
        //    this.toolStripSplitButton_1.DisplayStyle = ToolStripItemDisplayStyle.Text;
        //    ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripMenuItem_4, this.toolStripMenuItem_5 };
        //    this.toolStripSplitButton_1.DropDownItems.AddRange(itemArray3);
        //    this.toolStripSplitButton_1.Image = (Image)resources.GetObject("tssbMeasType.Image");
        //    this.toolStripSplitButton_1.ImageTransparentColor = Color.Magenta;
        //    this.toolStripSplitButton_1.Name = "tssbMeasType";
        //    this.toolStripSplitButton_1.Size = new Size(0x3a, 0x16);
        //    this.toolStripSplitButton_1.Text = "Замер";
        //    this.toolStripMenuItem_4.CheckOnClick = true;
        //    this.toolStripMenuItem_4.Name = "tsmiMeasLow";
        //    this.toolStripMenuItem_4.Size = new Size(0x71, 0x16);
        //    this.toolStripMenuItem_4.Text = "0,4 кВ";
        //    this.toolStripMenuItem_4.CheckedChanged += new EventHandler(this.toolStripMenuItem_5_CheckedChanged);
        //    this.toolStripMenuItem_5.CheckOnClick = true;
        //    this.toolStripMenuItem_5.Name = "tsmiMeasHigh";
        //    this.toolStripMenuItem_5.Size = new Size(0x71, 0x16);
        //    this.toolStripMenuItem_5.Text = "6-10 кВ";
        //    this.toolStripMenuItem_5.CheckedChanged += new EventHandler(this.toolStripMenuItem_5_CheckedChanged);
        //    this.toolStripSeparator_2.Name = "toolStripSeparator1";
        //    this.toolStripSeparator_2.Size = new Size(6, 0x19);
        //    this.toolStripLabel_0.Name = "toolStripLabel1";
        //    this.toolStripLabel_0.Size = new Size(0x37, 0x16);
        //    this.toolStripLabel_0.Text = "Период: ";
        //    this.toolStripComboBox_0.Name = "tscbMeasYear";
        //    this.toolStripComboBox_0.Size = new Size(80, 0x19);
        //    this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //    ToolStripItem[] itemArray4 = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2, this.toolStripMenuItem_3, this.toolStripMenuItem_6, this.toolStripMenuItem_7 };
        //    this.toolStripSplitButton_0.DropDownItems.AddRange(itemArray4);
        //    this.toolStripSplitButton_0.Image = (Image)resources.GetObject("tssbReports.Image");
        //    this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
        //    this.toolStripSplitButton_0.Name = "tssbReports";
        //    this.toolStripSplitButton_0.Size = new Size(0x20, 0x16);
        //    this.toolStripSplitButton_0.Text = "Отчеты";
        //    this.toolStripMenuItem_0.Name = "tsmiExcessLoad";
        //    this.toolStripMenuItem_0.Size = new Size(0xfe, 0x16);
        //    this.toolStripMenuItem_0.Text = "Превышение нагрузки";
        //    this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
        //    this.toolStripMenuItem_1.Name = "tsmiCoefficientLoading";
        //    this.toolStripMenuItem_1.Size = new Size(0xfe, 0x16);
        //    this.toolStripMenuItem_1.Text = "Коэффициент загрузки";
        //    this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
        //    this.toolStripMenuItem_2.Name = "tsmiCoefficientIrregularity";
        //    this.toolStripMenuItem_2.Size = new Size(0xfe, 0x16);
        //    this.toolStripMenuItem_2.Text = "Коэффициент неравномерности";
        //    this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripMenuItem_2_Click);
        //    this.toolStripMenuItem_3.Name = "tsmiTransfByCP";
        //    this.toolStripMenuItem_3.Size = new Size(0xfe, 0x16);
        //    this.toolStripMenuItem_3.Text = "Трансформаторы по ЦП";
        //    this.toolStripMenuItem_3.Visible = false;
        //    this.toolStripMenuItem_6.Name = "объемСвободнойМощностиToolStripMenuItem";
        //    this.toolStripMenuItem_6.Size = new Size(0xfe, 0x16);
        //    this.toolStripMenuItem_6.Text = "Объем свободной мощности";
        //    this.toolStripMenuItem_6.Click += new EventHandler(this.toolStripMenuItem_6_Click);
        //    this.toolStripMenuItem_7.Name = "toolStripMenuItemMeasExist";
        //    this.toolStripMenuItem_7.Size = new Size(0xfe, 0x16);
        //    this.toolStripMenuItem_7.Text = "Наличие замеров";
        //    this.toolStripMenuItem_7.Click += new EventHandler(this.toolStripMenuItem_7_Click);
        //    this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Text;
        //    this.toolStripButton_8.Image = (Image)resources.GetObject("toolStripButton1.Image");
        //    this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButton_8.Name = "toolStripButton1";
        //    this.toolStripButton_8.Size = new Size(0x48, 0x16);
        //    this.toolStripButton_8.Text = "insert idBus";
        //    this.toolStripButton_8.Visible = false;
        //    this.toolStripButton_8.Click += new EventHandler(this.btnFAQ_Click);
        //    this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Text;
        //    this.toolStripButton_9.Image = (Image)resources.GetObject("btnFAQ.Image");
        //    this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
        //    this.toolStripButton_9.Name = "btnFAQ";
        //    this.toolStripButton_9.Size = new Size(60, 0x16);
        //    this.toolStripButton_9.Text = "Помощь";
        //    this.toolStripButton_9.Click += new EventHandler(this.btnFAQ_Click);
        //    this.button_0.Dock = DockStyle.Right;
        //    this.button_0.Location = new Point(0x2cd, 0x20c);
        //    this.button_0.Margin = new Padding(10, 6, 15, 6);
        //    this.button_0.Name = "btnCancel";
        //    this.button_0.Size = new Size(80, 0x1a);
        //    this.button_0.TabIndex = 5;
        //    this.button_0.Text = "Закрыть";
        //    this.button_0.UseVisualStyleBackColor = true;
        //    this.button_0.Click += new EventHandler(this.button_0_Click);
        //    this.tableLayoutPanel_3.ColumnCount = 3;
        //    this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 158f));
        //    this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 267f));
        //    this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
        //    this.tableLayoutPanel_3.Controls.Add(this.comboBox_0, 1, 0);
        //    this.tableLayoutPanel_3.Controls.Add(this.label_0, 0, 0);
        //    this.tableLayoutPanel_3.Controls.Add(this.tabControl_0, 0, 4);
        //    this.tableLayoutPanel_3.Controls.Add(this.panel_0, 0, 1);
        //    this.tableLayoutPanel_3.Controls.Add(this.dataGridView_1, 0, 3);
        //    this.tableLayoutPanel_3.Controls.Add(this.panel_6, 2, 1);
        //    this.tableLayoutPanel_3.Controls.Add(this.dataGridView_2, 0, 2);
        //    this.tableLayoutPanel_3.Dock = DockStyle.Fill;
        //    this.tableLayoutPanel_3.Location = new Point(7, 0x7d);
        //    this.tableLayoutPanel_3.Name = "tlpMeasurementLow";
        //    this.tableLayoutPanel_3.RowCount = 5;
        //    this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 21f));
        //    this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 108f));
        //    this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
        //    this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 31f));
        //    this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Absolute, 120f));
        //    this.tableLayoutPanel_3.Size = new Size(0x322, 0xc0);
        //    this.tableLayoutPanel_3.TabIndex = 0;
        //    this.comboBox_0.DataSource = this.bsBusesTransfs;
        //    this.comboBox_0.DisplayMember = "Name";
        //    this.comboBox_0.Dock = DockStyle.Left;
        //    this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
        //    this.comboBox_0.FormattingEnabled = true;
        //    this.comboBox_0.Location = new Point(0xa1, 0);
        //    this.comboBox_0.Margin = new Padding(3, 0, 3, 3);
        //    this.comboBox_0.Name = "cbBusesTransfLV";
        //    this.comboBox_0.Size = new Size(110, 0x15);
        //    this.comboBox_0.TabIndex = 1;
        //    this.comboBox_0.ValueMember = "idBus";
        //    this.bsBusesTransfs.DataMember = "vJ_BusesTransfs";
        //    this.bsBusesTransfs.DataSource = this.dsJournal;
        //    this.dsJournal.DataSetName = "DataSetGES";
        //    this.dsJournal.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        //    this.label_0.BorderStyle = BorderStyle.FixedSingle;
        //    this.label_0.Dock = DockStyle.Fill;
        //    this.label_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    this.label_0.Location = new Point(3, 0);
        //    this.label_0.Name = "labelTrans";
        //    this.label_0.Size = new Size(0x98, 0x15);
        //    this.label_0.TabIndex = 10;
        //    this.label_0.Text = "Секция шин №";
        //    this.label_0.TextAlign = ContentAlignment.MiddleCenter;
        //    this.tableLayoutPanel_3.SetColumnSpan(this.tabControl_0, 3);
        //    this.tabControl_0.Controls.Add(this.tabPage_0);
        //    this.tabControl_0.Controls.Add(this.tabPage_1);
        //    this.tabControl_0.Dock = DockStyle.Fill;
        //    this.tabControl_0.Location = new Point(3, 0x4b);
        //    this.tabControl_0.Name = "tcMeasurement";
        //    this.tabControl_0.SelectedIndex = 0;
        //    this.tabControl_0.Size = new Size(0x31c, 0x72);
        //    this.tabControl_0.TabIndex = 14;
        //    this.tabControl_0.SelectedIndexChanged += new EventHandler(this.tabControl_0_SelectedIndexChanged);
        //    this.tabPage_0.Controls.Add(this.label_1);
        //    this.tabPage_0.Controls.Add(this.label_2);
        //    this.tabPage_0.Controls.Add(this.label_3);
        //    this.tabPage_0.Controls.Add(this.label_4);
        //    this.tabPage_0.Controls.Add(this.label_5);
        //    this.tabPage_0.Controls.Add(this.label_6);
        //    this.tabPage_0.Controls.Add(this.textBox_0);
        //    this.tabPage_0.Controls.Add(this.textBox_1);
        //    this.tabPage_0.Controls.Add(this.tbKNTn);
        //    this.tabPage_0.Controls.Add(this.tbKNTd);
        //    this.tabPage_0.Controls.Add(this.tbIsrn);
        //    this.tabPage_0.Controls.Add(this.tbIsrd);
        //    this.tabPage_0.Location = new Point(4, 0x16);
        //    this.tabPage_0.Name = "tpRatio";
        //    this.tabPage_0.Padding = new Padding(3);
        //    this.tabPage_0.Size = new Size(0x314, 0x58);
        //    this.tabPage_0.TabIndex = 1;
        //    this.tabPage_0.Text = "Коэффициент";
        //    this.tabPage_0.UseVisualStyleBackColor = true;
        //    this.label_1.AutoSize = true;
        //    this.label_1.Location = new Point(0x1c7, 0x35);
        //    this.label_1.Name = "label6";
        //    this.label_1.Size = new Size(0xed, 13);
        //    this.label_1.TabIndex = 11;
        //    this.label_1.Text = "Коэффициент неравномерности Кл.фаз Кз %";
        //    this.label_2.AutoSize = true;
        //    this.label_2.Location = new Point(0x1c7, 0x1b);
        //    this.label_2.Name = "label5";
        //    this.label_2.Size = new Size(0xed, 13);
        //    this.label_2.TabIndex = 10;
        //    this.label_2.Text = "Коэффициент неравномерности Кл.фаз Кз %";
        //    this.label_3.AutoSize = true;
        //    this.label_3.Location = new Point(0x85, 0x35);
        //    this.label_3.Name = "label4";
        //    this.label_3.Size = new Size(0xf2, 13);
        //    this.label_3.TabIndex = 9;
        //    this.label_3.Text = "Коэффициент нагрузки трансформатора Кз %";
        //    this.label_4.AutoSize = true;
        //    this.label_4.Location = new Point(0x85, 0x1b);
        //    this.label_4.Name = "label3";
        //    this.label_4.Size = new Size(0xf2, 13);
        //    this.label_4.TabIndex = 8;
        //    this.label_4.Text = "Коэффициент нагрузки трансформатора Кз %";
        //    this.label_5.AutoSize = true;
        //    this.label_5.Location = new Point(6, 0x35);
        //    this.label_5.Name = "label2";
        //    this.label_5.Size = new Size(0x3a, 13);
        //    this.label_5.TabIndex = 7;
        //    this.label_5.Text = "Вечер  Iср";
        //    this.label_6.AutoSize = true;
        //    this.label_6.Location = new Point(6, 0x1b);
        //    this.label_6.Name = "label1";
        //    this.label_6.Size = new Size(0x3a, 13);
        //    this.label_6.TabIndex = 6;
        //    this.label_6.Text = "День   Iср";
        //    this.textBox_0.BackColor = Color.White;
        //    this.textBox_0.Location = new Point(0x2c3, 50);
        //    this.textBox_0.Name = "tbKNKFn";
        //    this.textBox_0.ReadOnly = true;
        //    this.textBox_0.Size = new Size(0x24, 20);
        //    this.textBox_0.TabIndex = 5;
        //    this.textBox_1.BackColor = Color.White;
        //    this.textBox_1.Location = new Point(0x2c3, 0x18);
        //    this.textBox_1.Name = "tbKNKFd";
        //    this.textBox_1.ReadOnly = true;
        //    this.textBox_1.Size = new Size(0x24, 20);
        //    this.textBox_1.TabIndex = 4;
        //    this.tbKNTn.BackColor = Color.White;
        //    this.tbKNTn.Location = new Point(0x18a, 50);
        //    this.tbKNTn.Name = "tbKNTn";
        //    this.tbKNTn.ReadOnly = true;
        //    this.tbKNTn.Size = new Size(0x24, 20);
        //    this.tbKNTn.TabIndex = 3;
        //    this.tbKNTd.BackColor = Color.White;
        //    this.tbKNTd.Location = new Point(0x18a, 0x18);
        //    this.tbKNTd.Name = "tbKNTd";
        //    this.tbKNTd.ReadOnly = true;
        //    this.tbKNTd.Size = new Size(0x24, 20);
        //    this.tbKNTd.TabIndex = 2;
        //    this.tbIsrn.BackColor = Color.White;
        //    this.tbIsrn.Location = new Point(0x4c, 50);
        //    this.tbIsrn.Name = "tbIsrn";
        //    this.tbIsrn.ReadOnly = true;
        //    this.tbIsrn.Size = new Size(0x24, 20);
        //    this.tbIsrn.TabIndex = 1;
        //    this.tbIsrd.BackColor = Color.White;
        //    this.tbIsrd.Location = new Point(0x4c, 0x18);
        //    this.tbIsrd.Name = "tbIsrd";
        //    this.tbIsrd.ReadOnly = true;
        //    this.tbIsrd.Size = new Size(0x24, 20);
        //    this.tbIsrd.TabIndex = 0;
        //    this.tabPage_1.Controls.Add(this.dataGridView_0);
        //    this.tabPage_1.Location = new Point(4, 0x16);
        //    this.tabPage_1.Name = "tpAddress";
        //    this.tabPage_1.Padding = new Padding(3);
        //    this.tabPage_1.Size = new Size(0x314, 0x58);
        //    this.tabPage_1.TabIndex = 0;
        //    this.tabPage_1.Text = "Адреса";
        //    this.tabPage_1.UseVisualStyleBackColor = true;
        //    this.dataGridView_0.AllowUserToAddRows = false;
        //    this.dataGridView_0.AllowUserToDeleteRows = false;
        //    this.dataGridView_0.AllowUserToOrderColumns = true;
        //    this.dataGridView_0.AllowUserToResizeRows = false;
        //    this.dataGridView_0.AutoGenerateColumns = false;
        //    this.dataGridView_0.BackgroundColor = Color.White;
        //    style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    style.BackColor = SystemColors.Control;
        //    style.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style.ForeColor = SystemColors.WindowText;
        //    style.SelectionBackColor = SystemColors.Highlight;
        //    style.SelectionForeColor = SystemColors.HighlightText;
        //    style.WrapMode = DataGridViewTriState.True;
        //    this.dataGridView_0.ColumnHeadersDefaultCellStyle = style;
        //    this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //    DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_145, this.dataGridViewTextBoxColumn_146, this.dataGridViewTextBoxColumn_147, this.dataGridViewTextBoxColumn_148, this.dataGridViewTextBoxColumn_149 };
        //    this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
        //    this.dataGridView_0.DataSource = this.bindingSource_8;
        //    style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    style2.BackColor = Color.White;
        //    style2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style2.ForeColor = SystemColors.ControlText;
        //    style2.SelectionBackColor = SystemColors.Highlight;
        //    style2.SelectionForeColor = SystemColors.HighlightText;
        //    style2.WrapMode = DataGridViewTriState.False;
        //    this.dataGridView_0.DefaultCellStyle = style2;
        //    this.dataGridView_0.Dock = DockStyle.Fill;
        //    this.dataGridView_0.Location = new Point(3, 3);
        //    this.dataGridView_0.MultiSelect = false;
        //    this.dataGridView_0.Name = "dgvAbnObj";
        //    this.dataGridView_0.ReadOnly = true;
        //    style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    style3.BackColor = SystemColors.Control;
        //    style3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style3.ForeColor = SystemColors.WindowText;
        //    style3.SelectionBackColor = SystemColors.Highlight;
        //    style3.SelectionForeColor = SystemColors.HighlightText;
        //    style3.WrapMode = DataGridViewTriState.True;
        //    this.dataGridView_0.RowHeadersDefaultCellStyle = style3;
        //    this.dataGridView_0.RowHeadersVisible = false;
        //    this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    this.dataGridView_0.Size = new Size(0x30e, 0x52);
        //    this.dataGridView_0.TabIndex = 12;
        //    this.dataGridViewTextBoxColumn_145.DataPropertyName = "idSchmObj";
        //    this.dataGridViewTextBoxColumn_145.HeaderText = "idSchmObj";
        //    this.dataGridViewTextBoxColumn_145.Name = "idSchmObjDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_145.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_145.Visible = false;
        //    this.dataGridViewTextBoxColumn_146.DataPropertyName = "Street";
        //    this.dataGridViewTextBoxColumn_146.HeaderText = "Улица";
        //    this.dataGridViewTextBoxColumn_146.Name = "streetDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_146.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_146.Width = 180;
        //    this.dataGridViewTextBoxColumn_147.DataPropertyName = "House";
        //    this.dataGridViewTextBoxColumn_147.HeaderText = "Дом";
        //    this.dataGridViewTextBoxColumn_147.Name = "houseDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_147.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_147.Width = 50;
        //    this.dataGridViewTextBoxColumn_148.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    this.dataGridViewTextBoxColumn_148.DataPropertyName = "Name";
        //    this.dataGridViewTextBoxColumn_148.HeaderText = "Наименование";
        //    this.dataGridViewTextBoxColumn_148.Name = "nameDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_148.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_149.DataPropertyName = "codeAbonent";
        //    this.dataGridViewTextBoxColumn_149.HeaderText = "Номер договора";
        //    this.dataGridViewTextBoxColumn_149.Name = "codeAbonent";
        //    this.dataGridViewTextBoxColumn_149.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_149.Width = 120;
        //    this.bindingSource_8.DataMember = "vJ_MeasAbnObj";
        //    this.bindingSource_8.DataSource = this.dsJournal;
        //    this.bindingSource_8.Sort = "";
        //    this.tableLayoutPanel_3.SetColumnSpan(this.panel_0, 2);
        //    this.panel_0.Controls.Add(this.label_7);
        //    this.panel_0.Controls.Add(this.label_8);
        //    this.panel_0.Controls.Add(this.label_9);
        //    this.panel_0.Controls.Add(this.label_10);
        //    this.panel_0.Controls.Add(this.label_11);
        //    this.panel_0.Controls.Add(this.panel_1);
        //    this.panel_0.Controls.Add(this.panel_2);
        //    this.panel_0.Controls.Add(this.panel_3);
        //    this.panel_0.Controls.Add(this.panel_4);
        //    this.panel_0.Controls.Add(this.panel_5);
        //    this.panel_0.Location = new Point(3, 0x18);
        //    this.panel_0.Name = "pnlTransfReference";
        //    this.panel_0.Size = new Size(0x1a3, 0x66);
        //    this.panel_0.TabIndex = 8;
        //    this.label_7.BorderStyle = BorderStyle.FixedSingle;
        //    this.label_7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    this.label_7.Location = new Point(0, 0);
        //    this.label_7.Name = "label8";
        //    this.label_7.Size = new Size(0x7c, 0x33);
        //    this.label_7.TabIndex = 0;
        //    this.label_7.Text = "Трансформатор";
        //    this.label_7.TextAlign = ContentAlignment.MiddleCenter;
        //    this.label_8.BorderStyle = BorderStyle.FixedSingle;
        //    this.label_8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    this.label_8.Location = new Point(0x7b, 0);
        //    this.label_8.Name = "label9";
        //    this.label_8.Size = new Size(0x4b, 0x33);
        //    this.label_8.TabIndex = 0;
        //    this.label_8.Text = "Мощность кВт";
        //    this.label_8.TextAlign = ContentAlignment.MiddleCenter;
        //    this.label_9.BorderStyle = BorderStyle.FixedSingle;
        //    this.label_9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    this.label_9.Location = new Point(0xc5, 0);
        //    this.label_9.Name = "label10";
        //    this.label_9.Size = new Size(0x33, 0x33);
        //    this.label_9.TabIndex = 0;
        //    this.label_9.Text = "Uвн\r\n(раб)";
        //    this.label_9.TextAlign = ContentAlignment.MiddleCenter;
        //    this.label_10.BorderStyle = BorderStyle.FixedSingle;
        //    this.label_10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    this.label_10.Location = new Point(0xf7, 0);
        //    this.label_10.Name = "label11";
        //    this.label_10.Size = new Size(0x2f, 0x33);
        //    this.label_10.TabIndex = 0;
        //    this.label_10.Text = "Iном\r\nА";
        //    this.label_10.TextAlign = ContentAlignment.MiddleCenter;
        //    this.label_11.BorderStyle = BorderStyle.FixedSingle;
        //    this.label_11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    this.label_11.Location = new Point(0x124, 0);
        //    this.label_11.Name = "label12";
        //    this.label_11.Size = new Size(0x7f, 0x33);
        //    this.label_11.TabIndex = 0;
        //    this.label_11.Text = "Положение\r\nпереключателя\r\nнапряжения";
        //    this.label_11.TextAlign = ContentAlignment.MiddleCenter;
        //    this.panel_1.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_1.Controls.Add(this.textBox_6);
        //    this.panel_1.Controls.Add(this.textBox_7);
        //    this.panel_1.Controls.Add(this.label_12);
        //    this.panel_1.Controls.Add(this.label_13);
        //    this.panel_1.Location = new Point(0, 50);
        //    this.panel_1.Name = "panelTransType";
        //    this.panel_1.Size = new Size(0x7c, 0x34);
        //    this.panel_1.TabIndex = 5;
        //    this.textBox_6.BackColor = Color.White;
        //    this.textBox_6.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Type", true));
        //    this.textBox_6.Location = new Point(0x24, 2);
        //    this.textBox_6.Name = "tbTransType";
        //    this.textBox_6.ReadOnly = true;
        //    this.textBox_6.Size = new Size(0x4f, 20);
        //    this.textBox_6.TabIndex = 2;
        //    this.bindingSource_0.DataMember = "fn_J_MeasTransfPassport";
        //    this.bindingSource_0.DataSource = this.dsJournal;
        //    this.textBox_7.BackColor = Color.White;
        //    this.textBox_7.DataBindings.Add(new Binding("Text", this.bindingSource_0, "InvNumber", true));
        //    this.textBox_7.Location = new Point(0x24, 0x1c);
        //    this.textBox_7.Name = "tbTransNumber";
        //    this.textBox_7.ReadOnly = true;
        //    this.textBox_7.Size = new Size(0x4f, 20);
        //    this.textBox_7.TabIndex = 2;
        //    this.label_12.AutoSize = true;
        //    this.label_12.Location = new Point(4, 5);
        //    this.label_12.Name = "label18";
        //    this.label_12.Size = new Size(0x1a, 13);
        //    this.label_12.TabIndex = 4;
        //    this.label_12.Text = "Тип";
        //    this.label_13.AutoSize = true;
        //    this.label_13.Location = new Point(8, 0x1f);
        //    this.label_13.Name = "label19";
        //    this.label_13.Size = new Size(0x12, 13);
        //    this.label_13.TabIndex = 4;
        //    this.label_13.Text = "№";
        //    this.panel_2.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_2.Controls.Add(this.comboBox_1);
        //    this.panel_2.Location = new Point(0x125, 50);
        //    this.panel_2.Name = "panel8";
        //    this.panel_2.Size = new Size(0x7e, 0x34);
        //    this.panel_2.TabIndex = 5;
        //    this.comboBox_1.BackColor = Color.White;
        //    this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_1, "idSwitchPosition", true));
        //    this.comboBox_1.DataSource = this.bindingSource_12;
        //    this.comboBox_1.DisplayMember = "Name";
        //    this.comboBox_1.DropDownStyle = ComboBoxStyle.Simple;
        //    this.comboBox_1.FormattingEnabled = true;
        //    this.comboBox_1.Location = new Point(2, 15);
        //    this.comboBox_1.Name = "cbSwitchPosition";
        //    this.comboBox_1.Size = new Size(120, 0x15);
        //    this.comboBox_1.TabIndex = 3;
        //    this.comboBox_1.ValueMember = "id";
        //    this.bindingSource_1.DataMember = "tJ_MeasVoltageTransf";
        //    this.bindingSource_1.DataSource = this.dsJournal;
        //    this.bindingSource_12.DataMember = "tR_Classifier";
        //    this.bindingSource_12.DataSource = this.dsJournal;
        //    this.bindingSource_12.Filter = "ParentKey = ';Measurement;Switch;'";
        //    this.panel_3.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_3.Controls.Add(this.tbTransAmperage);
        //    this.panel_3.Location = new Point(0xf7, 50);
        //    this.panel_3.Name = "panel7";
        //    this.panel_3.Size = new Size(0x2f, 0x34);
        //    this.panel_3.TabIndex = 5;
        //    this.tbTransAmperage.BackColor = Color.White;
        //    this.tbTransAmperage.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Inom", true));
        //    this.tbTransAmperage.Location = new Point(2, 15);
        //    this.tbTransAmperage.Name = "tbTransAmperage";
        //    this.tbTransAmperage.ReadOnly = true;
        //    this.tbTransAmperage.Size = new Size(40, 20);
        //    this.tbTransAmperage.TabIndex = 2;
        //    this.panel_4.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_4.Controls.Add(this.textBox_9);
        //    this.panel_4.Location = new Point(0x7b, 50);
        //    this.panel_4.Name = "panel5";
        //    this.panel_4.Size = new Size(0x4b, 0x34);
        //    this.panel_4.TabIndex = 5;
        //    this.textBox_9.BackColor = Color.White;
        //    this.textBox_9.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Power", true));
        //    this.textBox_9.Location = new Point(3, 15);
        //    this.textBox_9.Name = "tbTransPower";
        //    this.textBox_9.ReadOnly = true;
        //    this.textBox_9.Size = new Size(0x43, 20);
        //    this.textBox_9.TabIndex = 2;
        //    this.panel_5.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_5.Controls.Add(this.textBox_10);
        //    this.panel_5.Location = new Point(0xc5, 50);
        //    this.panel_5.Name = "panel6";
        //    this.panel_5.Size = new Size(0x33, 0x34);
        //    this.panel_5.TabIndex = 5;
        //    this.textBox_10.BackColor = Color.White;
        //    this.textBox_10.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Unom", true));
        //    this.textBox_10.Location = new Point(2, 15);
        //    this.textBox_10.Name = "tbTransVoltage";
        //    this.textBox_10.ReadOnly = true;
        //    this.textBox_10.Size = new Size(0x2c, 20);
        //    this.textBox_10.TabIndex = 2;
        //    this.dataGridView_1.AllowUserToResizeRows = false;
        //    this.dataGridView_1.BackgroundColor = Color.White;
        //    style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    style4.BackColor = SystemColors.Control;
        //    style4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style4.ForeColor = SystemColors.WindowText;
        //    style4.SelectionBackColor = SystemColors.Highlight;
        //    style4.SelectionForeColor = SystemColors.HighlightText;
        //    style4.WrapMode = DataGridViewTriState.True;
        //    this.dataGridView_1.ColumnHeadersDefaultCellStyle = style4;
        //    this.dataGridView_1.ColumnHeadersVisible = false;
        //    DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_135, this.dataGridViewTextBoxColumn_136, this.dataGridViewTextBoxColumn_137, this.dataGridViewTextBoxColumn_138, this.dataGridViewTextBoxColumn_139, this.dataGridViewTextBoxColumn_140, this.dataGridViewTextBoxColumn_141, this.dataGridViewTextBoxColumn_142, this.dataGridViewTextBoxColumn_143, this.dataGridViewTextBoxColumn_144 };
        //    this.dataGridView_1.Columns.AddRange(columnArray2);
        //    this.tableLayoutPanel_3.SetColumnSpan(this.dataGridView_1, 3);
        //    style5.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    style5.BackColor = Color.White;
        //    style5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style5.ForeColor = Color.Black;
        //    style5.SelectionBackColor = Color.White;
        //    style5.SelectionForeColor = Color.Black;
        //    style5.WrapMode = DataGridViewTriState.False;
        //    this.dataGridView_1.DefaultCellStyle = style5;
        //    this.dataGridView_1.Dock = DockStyle.Fill;
        //    this.dataGridView_1.Location = new Point(3, 0x2c);
        //    this.dataGridView_1.Margin = new Padding(3, 3, 7, 3);
        //    this.dataGridView_1.MultiSelect = false;
        //    this.dataGridView_1.Name = "dgvSumCable";
        //    this.dataGridView_1.ReadOnly = true;
        //    style6.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    style6.BackColor = SystemColors.Control;
        //    style6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style6.ForeColor = SystemColors.WindowText;
        //    style6.SelectionBackColor = SystemColors.Highlight;
        //    style6.SelectionForeColor = SystemColors.HighlightText;
        //    style6.WrapMode = DataGridViewTriState.True;
        //    this.dataGridView_1.RowHeadersDefaultCellStyle = style6;
        //    this.dataGridView_1.RowHeadersVisible = false;
        //    this.dataGridView_1.ScrollBars = ScrollBars.None;
        //    this.dataGridView_1.Size = new Size(0x318, 0x19);
        //    this.dataGridView_1.TabIndex = 15;
        //    this.dataGridViewTextBoxColumn_135.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_135.HeaderText = "SumName";
        //    this.dataGridViewTextBoxColumn_135.Name = "SumName";
        //    this.dataGridViewTextBoxColumn_135.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_135.Width = 660;
        //    this.dataGridViewTextBoxColumn_136.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_136.HeaderText = "ad";
        //    this.dataGridViewTextBoxColumn_136.Name = "ad";
        //    this.dataGridViewTextBoxColumn_136.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_136.Width = 40;
        //    this.dataGridViewTextBoxColumn_137.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_137.HeaderText = "an";
        //    this.dataGridViewTextBoxColumn_137.Name = "an";
        //    this.dataGridViewTextBoxColumn_137.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_137.Width = 40;
        //    this.dataGridViewTextBoxColumn_138.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_138.HeaderText = "bd";
        //    this.dataGridViewTextBoxColumn_138.Name = "bd";
        //    this.dataGridViewTextBoxColumn_138.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_138.Width = 40;
        //    this.dataGridViewTextBoxColumn_139.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_139.HeaderText = "bn";
        //    this.dataGridViewTextBoxColumn_139.Name = "bn";
        //    this.dataGridViewTextBoxColumn_139.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_139.Width = 40;
        //    this.dataGridViewTextBoxColumn_140.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_140.HeaderText = "cd";
        //    this.dataGridViewTextBoxColumn_140.Name = "cd";
        //    this.dataGridViewTextBoxColumn_140.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_140.Width = 40;
        //    this.dataGridViewTextBoxColumn_141.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_141.HeaderText = "cn";
        //    this.dataGridViewTextBoxColumn_141.Name = "cn";
        //    this.dataGridViewTextBoxColumn_141.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_141.Width = 40;
        //    this.dataGridViewTextBoxColumn_142.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_142.HeaderText = "od";
        //    this.dataGridViewTextBoxColumn_142.Name = "od";
        //    this.dataGridViewTextBoxColumn_142.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_142.Width = 40;
        //    this.dataGridViewTextBoxColumn_143.HeaderText = "on";
        //    this.dataGridViewTextBoxColumn_143.Name = "on";
        //    this.dataGridViewTextBoxColumn_143.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_143.Width = 40;
        //    this.dataGridViewTextBoxColumn_144.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    this.dataGridViewTextBoxColumn_144.HeaderText = "Comment";
        //    this.dataGridViewTextBoxColumn_144.MinimumWidth = 80;
        //    this.dataGridViewTextBoxColumn_144.Name = "Column1";
        //    this.dataGridViewTextBoxColumn_144.ReadOnly = true;
        //    this.panel_6.Controls.Add(this.panel_7);
        //    this.panel_6.Controls.Add(this.panel_8);
        //    this.panel_6.Controls.Add(this.panel_9);
        //    this.panel_6.Controls.Add(this.panel_10);
        //    this.panel_6.Controls.Add(this.panel_11);
        //    this.panel_6.Controls.Add(this.panel_12);
        //    this.panel_6.Controls.Add(this.panel_13);
        //    this.panel_6.Dock = DockStyle.Fill;
        //    this.panel_6.Location = new Point(0x1ac, 0x18);
        //    this.panel_6.Name = "panel4";
        //    this.panel_6.Size = new Size(0x173, 0x66);
        //    this.panel_6.TabIndex = 9;
        //    this.panel_7.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_7.Controls.Add(this.label_14);
        //    this.panel_7.Location = new Point(0x3d, 0);
        //    this.panel_7.Name = "panel11";
        //    this.panel_7.Size = new Size(0xb9, 0x1a);
        //    this.panel_7.TabIndex = 5;
        //    this.label_14.AutoSize = true;
        //    this.label_14.Location = new Point(0x31, 6);
        //    this.label_14.Name = "label15";
        //    this.label_14.Size = new Size(0x54, 13);
        //    this.label_14.TabIndex = 4;
        //    this.label_14.Text = "Напряжение, В";
        //    this.panel_8.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_8.Location = new Point(11, 0);
        //    this.panel_8.Name = "panel3";
        //    this.panel_8.Size = new Size(0x33, 0x33);
        //    this.panel_8.TabIndex = 5;
        //    this.panel_9.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_9.Controls.Add(this.label_15);
        //    this.panel_9.Controls.Add(this.label_16);
        //    this.panel_9.Controls.Add(this.label_17);
        //    this.panel_9.Location = new Point(0x99, 0x19);
        //    this.panel_9.Name = "panel10";
        //    this.panel_9.Size = new Size(0x5d, 0x1a);
        //    this.panel_9.TabIndex = 5;
        //    this.label_15.AutoSize = true;
        //    this.label_15.Location = new Point(0x3a, 3);
        //    this.label_15.Name = "label23";
        //    this.label_15.Size = new Size(30, 13);
        //    this.label_15.TabIndex = 4;
        //    this.label_15.Text = "Uc-o";
        //    this.label_16.AutoSize = true;
        //    this.label_16.Location = new Point(2, 3);
        //    this.label_16.Name = "label21";
        //    this.label_16.Size = new Size(30, 13);
        //    this.label_16.TabIndex = 4;
        //    this.label_16.Text = "Ua-o";
        //    this.label_17.AutoSize = true;
        //    this.label_17.Location = new Point(30, 3);
        //    this.label_17.Name = "label22";
        //    this.label_17.Size = new Size(30, 13);
        //    this.label_17.TabIndex = 4;
        //    this.label_17.Text = "Ub-o";
        //    this.panel_10.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_10.Controls.Add(this.textBox_11);
        //    this.panel_10.Controls.Add(this.textBox_12);
        //    this.panel_10.Controls.Add(this.textBox_13);
        //    this.panel_10.Controls.Add(this.textBox_14);
        //    this.panel_10.Controls.Add(this.textBox_15);
        //    this.panel_10.Controls.Add(this.textBox_16);
        //    this.panel_10.Location = new Point(0x3d, 50);
        //    this.panel_10.Name = "panelTB1";
        //    this.panel_10.Size = new Size(0x5d, 0x33);
        //    this.panel_10.TabIndex = 5;
        //    this.textBox_11.BackColor = Color.White;
        //    this.textBox_11.DataBindings.Add(new Binding("Text", this.bindingSource_1, "Ucan", true));
        //    this.textBox_11.Location = new Point(60, 0x19);
        //    this.textBox_11.Name = "mtbUcan";
        //    this.textBox_11.ReadOnly = true;
        //    this.textBox_11.Size = new Size(0x1a, 20);
        //    this.textBox_11.TabIndex = 6;
        //    this.textBox_11.KeyPress += new KeyPressEventHandler(this.textBox_22_KeyPress);
        //    this.textBox_12.BackColor = Color.White;
        //    this.textBox_12.DataBindings.Add(new Binding("Text", this.bindingSource_1, "Ubcn", true));
        //    this.textBox_12.Location = new Point(0x20, 0x19);
        //    this.textBox_12.Name = "mtbUbcn";
        //    this.textBox_12.ReadOnly = true;
        //    this.textBox_12.Size = new Size(0x1a, 20);
        //    this.textBox_12.TabIndex = 6;
        //    this.textBox_12.KeyPress += new KeyPressEventHandler(this.textBox_22_KeyPress);
        //    this.textBox_13.BackColor = Color.White;
        //    this.textBox_13.DataBindings.Add(new Binding("Text", this.bindingSource_1, "Uabn", true));
        //    this.textBox_13.Location = new Point(4, 0x19);
        //    this.textBox_13.Name = "mtbUabn";
        //    this.textBox_13.ReadOnly = true;
        //    this.textBox_13.Size = new Size(0x1a, 20);
        //    this.textBox_13.TabIndex = 6;
        //    this.textBox_13.KeyPress += new KeyPressEventHandler(this.textBox_22_KeyPress);
        //    this.textBox_14.BackColor = Color.White;
        //    this.textBox_14.DataBindings.Add(new Binding("Text", this.bindingSource_1, "Ucad", true));
        //    this.textBox_14.Location = new Point(60, 3);
        //    this.textBox_14.Name = "mtbUcad";
        //    this.textBox_14.ReadOnly = true;
        //    this.textBox_14.Size = new Size(0x1a, 20);
        //    this.textBox_14.TabIndex = 6;
        //    this.textBox_14.KeyPress += new KeyPressEventHandler(this.textBox_22_KeyPress);
        //    this.textBox_15.BackColor = Color.White;
        //    this.textBox_15.DataBindings.Add(new Binding("Text", this.bindingSource_1, "Ubcd", true));
        //    this.textBox_15.Location = new Point(0x20, 3);
        //    this.textBox_15.Name = "mtbUbcd";
        //    this.textBox_15.ReadOnly = true;
        //    this.textBox_15.Size = new Size(0x1a, 20);
        //    this.textBox_15.TabIndex = 6;
        //    this.textBox_15.KeyPress += new KeyPressEventHandler(this.textBox_22_KeyPress);
        //    this.textBox_16.BackColor = Color.White;
        //    this.textBox_16.DataBindings.Add(new Binding("Text", this.bindingSource_1, "Uabd", true));
        //    this.textBox_16.Location = new Point(4, 3);
        //    this.textBox_16.Name = "mtbUabd";
        //    this.textBox_16.ReadOnly = true;
        //    this.textBox_16.Size = new Size(0x1a, 20);
        //    this.textBox_16.TabIndex = 6;
        //    this.textBox_16.KeyPress += new KeyPressEventHandler(this.textBox_22_KeyPress);
        //    this.panel_11.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_11.Controls.Add(this.label_18);
        //    this.panel_11.Controls.Add(this.label_19);
        //    this.panel_11.Controls.Add(this.label_20);
        //    this.panel_11.Location = new Point(0x3d, 0x19);
        //    this.panel_11.Name = "panel9";
        //    this.panel_11.Size = new Size(0x5d, 0x1a);
        //    this.panel_11.TabIndex = 5;
        //    this.label_18.AutoSize = true;
        //    this.label_18.Location = new Point(60, 3);
        //    this.label_18.Name = "label20";
        //    this.label_18.Size = new Size(0x1b, 13);
        //    this.label_18.TabIndex = 4;
        //    this.label_18.Text = "Uca";
        //    this.label_19.AutoSize = true;
        //    this.label_19.Location = new Point(0x20, 3);
        //    this.label_19.Name = "label17";
        //    this.label_19.Size = new Size(0x1b, 13);
        //    this.label_19.TabIndex = 4;
        //    this.label_19.Text = "Ubc";
        //    this.label_20.AutoSize = true;
        //    this.label_20.Location = new Point(4, 3);
        //    this.label_20.Name = "label16";
        //    this.label_20.Size = new Size(0x1b, 13);
        //    this.label_20.TabIndex = 4;
        //    this.label_20.Text = "Uab";
        //    this.panel_12.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_12.Controls.Add(this.textBox_17);
        //    this.panel_12.Controls.Add(this.textBox_18);
        //    this.panel_12.Controls.Add(this.textBox_19);
        //    this.panel_12.Controls.Add(this.textBox_20);
        //    this.panel_12.Controls.Add(this.textBox_21);
        //    this.panel_12.Controls.Add(this.textBox_22);
        //    this.panel_12.Location = new Point(0x99, 50);
        //    this.panel_12.Name = "panelTB2";
        //    this.panel_12.Size = new Size(0x5d, 0x33);
        //    this.panel_12.TabIndex = 5;
        //    this.textBox_17.BackColor = Color.White;
        //    this.textBox_17.DataBindings.Add(new Binding("Text", this.bindingSource_1, "Ucon", true));
        //    this.textBox_17.Location = new Point(60, 0x19);
        //    this.textBox_17.Name = "mtbUcon";
        //    this.textBox_17.ReadOnly = true;
        //    this.textBox_17.Size = new Size(0x1a, 20);
        //    this.textBox_17.TabIndex = 6;
        //    this.textBox_17.KeyPress += new KeyPressEventHandler(this.textBox_22_KeyPress);
        //    this.textBox_18.BackColor = Color.White;
        //    this.textBox_18.DataBindings.Add(new Binding("Text", this.bindingSource_1, "Ubon", true));
        //    this.textBox_18.Location = new Point(0x20, 0x19);
        //    this.textBox_18.Name = "mtnUbon";
        //    this.textBox_18.ReadOnly = true;
        //    this.textBox_18.Size = new Size(0x1a, 20);
        //    this.textBox_18.TabIndex = 6;
        //    this.textBox_18.KeyPress += new KeyPressEventHandler(this.textBox_22_KeyPress);
        //    this.textBox_19.BackColor = Color.White;
        //    this.textBox_19.DataBindings.Add(new Binding("Text", this.bindingSource_1, "Uaon", true));
        //    this.textBox_19.Location = new Point(4, 0x19);
        //    this.textBox_19.Name = "mmtbUaon";
        //    this.textBox_19.ReadOnly = true;
        //    this.textBox_19.Size = new Size(0x1a, 20);
        //    this.textBox_19.TabIndex = 6;
        //    this.textBox_19.KeyPress += new KeyPressEventHandler(this.textBox_22_KeyPress);
        //    this.textBox_20.BackColor = Color.White;
        //    this.textBox_20.DataBindings.Add(new Binding("Text", this.bindingSource_1, "Ucod", true));
        //    this.textBox_20.Location = new Point(60, 3);
        //    this.textBox_20.Name = "mtbUcod";
        //    this.textBox_20.ReadOnly = true;
        //    this.textBox_20.Size = new Size(0x1a, 20);
        //    this.textBox_20.TabIndex = 6;
        //    this.textBox_20.KeyPress += new KeyPressEventHandler(this.textBox_22_KeyPress);
        //    this.textBox_21.BackColor = Color.White;
        //    this.textBox_21.DataBindings.Add(new Binding("Text", this.bindingSource_1, "Ubod", true));
        //    this.textBox_21.Location = new Point(0x20, 3);
        //    this.textBox_21.Name = "mtbUbod";
        //    this.textBox_21.ReadOnly = true;
        //    this.textBox_21.Size = new Size(0x1a, 20);
        //    this.textBox_21.TabIndex = 6;
        //    this.textBox_21.KeyPress += new KeyPressEventHandler(this.textBox_22_KeyPress);
        //    this.textBox_22.BackColor = Color.White;
        //    this.textBox_22.DataBindings.Add(new Binding("Text", this.bindingSource_1, "Uaod", true));
        //    this.textBox_22.Location = new Point(4, 3);
        //    this.textBox_22.Name = "mtbUaod";
        //    this.textBox_22.ReadOnly = true;
        //    this.textBox_22.Size = new Size(0x1a, 20);
        //    this.textBox_22.TabIndex = 6;
        //    this.textBox_22.KeyPress += new KeyPressEventHandler(this.textBox_22_KeyPress);
        //    this.panel_13.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_13.Controls.Add(this.label_21);
        //    this.panel_13.Controls.Add(this.label_22);
        //    this.panel_13.Location = new Point(11, 50);
        //    this.panel_13.Name = "panel2";
        //    this.panel_13.Size = new Size(0x33, 0x33);
        //    this.panel_13.TabIndex = 5;
        //    this.label_21.AutoSize = true;
        //    this.label_21.Location = new Point(3, 0x1c);
        //    this.label_21.Name = "label14";
        //    this.label_21.Size = new Size(0x25, 13);
        //    this.label_21.TabIndex = 4;
        //    this.label_21.Text = "Вечер";
        //    this.label_22.AutoSize = true;
        //    this.label_22.Location = new Point(3, 6);
        //    this.label_22.Name = "label13";
        //    this.label_22.Size = new Size(0x22, 13);
        //    this.label_22.TabIndex = 4;
        //    this.label_22.Text = "День";
        //    this.dataGridView_2.AllowUserToAddRows = false;
        //    this.dataGridView_2.AllowUserToDeleteRows = false;
        //    this.dataGridView_2.AllowUserToOrderColumns = true;
        //    this.dataGridView_2.AllowUserToResizeRows = false;
        //    this.dataGridView_2.AutoGenerateColumns = false;
        //    this.dataGridView_2.BackgroundColor = Color.White;
        //    style7.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    style7.BackColor = SystemColors.Control;
        //    style7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style7.ForeColor = SystemColors.WindowText;
        //    style7.SelectionBackColor = SystemColors.Highlight;
        //    style7.SelectionForeColor = SystemColors.HighlightText;
        //    style7.WrapMode = DataGridViewTriState.True;
        //    this.dataGridView_2.ColumnHeadersDefaultCellStyle = style7;
        //    this.dataGridView_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //    DataGridViewColumn[] columnArray3 = new DataGridViewColumn[] {
        //        this.dataGridViewCheckBoxColumn_3, this.dataGridViewTextBoxColumn_112, this.dataGridViewTextBoxColumn_113, this.dataGridViewTextBoxColumn_114, this.dataGridViewTextBoxColumn_115, this.dataGridViewTextBoxColumn_116, this.dataGridViewTextBoxColumn_117, this.dataGridViewTextBoxColumn_118, this.dataGridViewTextBoxColumn_119, this.dataGridViewTextBoxColumn_120, this.dataGridViewTextBoxColumn_121, this.dataGridViewTextBoxColumn_122, this.dataGridViewTextBoxColumn_123, this.dataGridViewTextBoxColumn_124, this.dataGridViewTextBoxColumn_125, this.dataGridViewTextBoxColumn_126,
        //        this.dataGridViewTextBoxColumn_127, this.dataGridViewTextBoxColumn_128, this.dataGridViewTextBoxColumn_129, this.dataGridViewTextBoxColumn_130, this.dataGridViewTextBoxColumn_131, this.dataGridViewTextBoxColumn_132, this.dataGridViewTextBoxColumn_133, this.dataGridViewTextBoxColumn_134
        //    };
        //    this.dataGridView_2.Columns.AddRange(columnArray3);
        //    this.tableLayoutPanel_3.SetColumnSpan(this.dataGridView_2, 3);
        //    this.dataGridView_2.DataSource = this.bindingSource_7;
        //    style8.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    style8.BackColor = Color.White;
        //    style8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style8.ForeColor = SystemColors.ControlText;
        //    style8.SelectionBackColor = SystemColors.Highlight;
        //    style8.SelectionForeColor = SystemColors.HighlightText;
        //    style8.WrapMode = DataGridViewTriState.False;
        //    this.dataGridView_2.DefaultCellStyle = style8;
        //    this.dataGridView_2.Dock = DockStyle.Fill;
        //    this.dataGridView_2.Location = new Point(3, 0x84);
        //    this.dataGridView_2.Margin = new Padding(3, 3, 7, 3);
        //    this.dataGridView_2.MultiSelect = false;
        //    this.dataGridView_2.Name = "dgvMeasCable";
        //    this.dataGridView_2.ReadOnly = true;
        //    style9.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    style9.BackColor = SystemColors.Control;
        //    style9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style9.ForeColor = SystemColors.WindowText;
        //    style9.SelectionBackColor = SystemColors.Highlight;
        //    style9.SelectionForeColor = SystemColors.HighlightText;
        //    style9.WrapMode = DataGridViewTriState.True;
        //    this.dataGridView_2.RowHeadersDefaultCellStyle = style9;
        //    this.dataGridView_2.RowHeadersVisible = false;
        //    this.dataGridView_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    this.dataGridView_2.Size = new Size(0x318, 1);
        //    this.dataGridView_2.TabIndex = 11;
        //    this.dataGridView_2.ColumnWidthChanged += new DataGridViewColumnEventHandler(this.dataGridView_2_ColumnWidthChanged);
        //    this.dataGridView_2.Scroll += new ScrollEventHandler(this.dataGridView_2_Scroll);
        //    this.dataGridViewCheckBoxColumn_3.DataPropertyName = "Deleted";
        //    this.dataGridViewCheckBoxColumn_3.HeaderText = "Deleted";
        //    this.dataGridViewCheckBoxColumn_3.Name = "deletedDataGridViewCheckBoxColumn";
        //    this.dataGridViewCheckBoxColumn_3.ReadOnly = true;
        //    this.dataGridViewCheckBoxColumn_3.Visible = false;
        //    this.dataGridViewTextBoxColumn_112.DataPropertyName = "NameCell";
        //    this.dataGridViewTextBoxColumn_112.HeaderText = "№ руб.";
        //    this.dataGridViewTextBoxColumn_112.Name = "NameCell";
        //    this.dataGridViewTextBoxColumn_112.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_112.Width = 30;
        //    this.dataGridViewTextBoxColumn_113.DataPropertyName = "id";
        //    this.dataGridViewTextBoxColumn_113.HeaderText = "id";
        //    this.dataGridViewTextBoxColumn_113.Name = "idDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_113.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_113.Visible = false;
        //    this.dataGridViewTextBoxColumn_114.DataPropertyName = "idMeasurement";
        //    this.dataGridViewTextBoxColumn_114.HeaderText = "idMeasurement";
        //    this.dataGridViewTextBoxColumn_114.Name = "idMeasurement";
        //    this.dataGridViewTextBoxColumn_114.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_114.Visible = false;
        //    this.dataGridViewTextBoxColumn_115.DataPropertyName = "idCell";
        //    this.dataGridViewTextBoxColumn_115.HeaderText = "idCell";
        //    this.dataGridViewTextBoxColumn_115.Name = "idCellDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_115.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_115.Resizable = DataGridViewTriState.True;
        //    this.dataGridViewTextBoxColumn_115.Visible = false;
        //    this.dataGridViewTextBoxColumn_115.Width = 30;
        //    this.dataGridViewTextBoxColumn_116.DataPropertyName = "OldCell";
        //    this.dataGridViewTextBoxColumn_116.HeaderText = "№ Ст.р";
        //    this.dataGridViewTextBoxColumn_116.Name = "OldCell";
        //    this.dataGridViewTextBoxColumn_116.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_116.Width = 30;
        //    this.dataGridViewTextBoxColumn_117.DataPropertyName = "NameCable";
        //    this.dataGridViewTextBoxColumn_117.HeaderText = "Кабель";
        //    this.dataGridViewTextBoxColumn_117.Name = "NameCable";
        //    this.dataGridViewTextBoxColumn_117.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_118.DataPropertyName = "Address";
        //    this.dataGridViewTextBoxColumn_118.HeaderText = "Адрес объекта";
        //    this.dataGridViewTextBoxColumn_118.Name = "Address";
        //    this.dataGridViewTextBoxColumn_118.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_118.Width = 150;
        //    this.dataGridViewTextBoxColumn_119.DataPropertyName = "Company";
        //    this.dataGridViewTextBoxColumn_119.HeaderText = "Наименование объекта";
        //    this.dataGridViewTextBoxColumn_119.Name = "Company";
        //    this.dataGridViewTextBoxColumn_119.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_119.Width = 150;
        //    this.dataGridViewTextBoxColumn_120.DataPropertyName = "idSchmAbn";
        //    this.dataGridViewTextBoxColumn_120.HeaderText = "idSchmAbn";
        //    this.dataGridViewTextBoxColumn_120.Name = "idSchmAbnDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_120.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_120.Visible = false;
        //    this.dataGridViewTextBoxColumn_121.DataPropertyName = "Makeup";
        //    this.dataGridViewTextBoxColumn_121.HeaderText = "Марка кабеля";
        //    this.dataGridViewTextBoxColumn_121.Name = "makeupDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_121.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_121.Resizable = DataGridViewTriState.True;
        //    this.dataGridViewTextBoxColumn_121.Width = 60;
        //    this.dataGridViewTextBoxColumn_122.DataPropertyName = "Voltage";
        //    this.dataGridViewTextBoxColumn_122.HeaderText = "Напр.";
        //    this.dataGridViewTextBoxColumn_122.Name = "voltageDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_122.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_122.Resizable = DataGridViewTriState.True;
        //    this.dataGridViewTextBoxColumn_122.Visible = false;
        //    this.dataGridViewTextBoxColumn_122.Width = 70;
        //    this.dataGridViewTextBoxColumn_123.DataPropertyName = "Wires";
        //    this.dataGridViewTextBoxColumn_123.HeaderText = "Кол-во жил";
        //    this.dataGridViewTextBoxColumn_123.Name = "wiresDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_123.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_123.Width = 40;
        //    this.dataGridViewTextBoxColumn_124.DataPropertyName = "CrossSection";
        //    this.dataGridViewTextBoxColumn_124.HeaderText = "Сечение";
        //    this.dataGridViewTextBoxColumn_124.Name = "crossSectionDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_124.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_124.Resizable = DataGridViewTriState.True;
        //    this.dataGridViewTextBoxColumn_124.Width = 50;
        //    this.dataGridViewTextBoxColumn_125.DataPropertyName = "PermisAmperage";
        //    style10.Format = "N0";
        //    this.dataGridViewTextBoxColumn_125.DefaultCellStyle = style10;
        //    this.dataGridViewTextBoxColumn_125.HeaderText = "Допуст. нагр., А";
        //    this.dataGridViewTextBoxColumn_125.Name = "PermisAmperage";
        //    this.dataGridViewTextBoxColumn_125.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_125.Width = 50;
        //    this.dataGridViewTextBoxColumn_126.DataPropertyName = "Iad";
        //    style11.Format = "N0";
        //    style11.NullValue = null;
        //    this.dataGridViewTextBoxColumn_126.DefaultCellStyle = style11;
        //    this.dataGridViewTextBoxColumn_126.HeaderText = "А дн.";
        //    this.dataGridViewTextBoxColumn_126.Name = "Iad";
        //    this.dataGridViewTextBoxColumn_126.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_126.Width = 40;
        //    this.dataGridViewTextBoxColumn_127.DataPropertyName = "Ian";
        //    style12.Format = "N0";
        //    this.dataGridViewTextBoxColumn_127.DefaultCellStyle = style12;
        //    this.dataGridViewTextBoxColumn_127.HeaderText = "А вч.";
        //    this.dataGridViewTextBoxColumn_127.Name = "Ian";
        //    this.dataGridViewTextBoxColumn_127.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_127.Width = 40;
        //    this.dataGridViewTextBoxColumn_128.DataPropertyName = "Ibd";
        //    this.dataGridViewTextBoxColumn_128.HeaderText = "В дн.";
        //    this.dataGridViewTextBoxColumn_128.Name = "Ibd";
        //    this.dataGridViewTextBoxColumn_128.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_128.Width = 40;
        //    this.dataGridViewTextBoxColumn_129.DataPropertyName = "Ibn";
        //    this.dataGridViewTextBoxColumn_129.HeaderText = "В вч.";
        //    this.dataGridViewTextBoxColumn_129.Name = "Ibn";
        //    this.dataGridViewTextBoxColumn_129.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_129.Width = 40;
        //    this.dataGridViewTextBoxColumn_130.DataPropertyName = "Icd";
        //    this.dataGridViewTextBoxColumn_130.HeaderText = "С дн.";
        //    this.dataGridViewTextBoxColumn_130.Name = "Icd";
        //    this.dataGridViewTextBoxColumn_130.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_130.Width = 40;
        //    this.dataGridViewTextBoxColumn_131.DataPropertyName = "Icn";
        //    this.dataGridViewTextBoxColumn_131.HeaderText = "С вч.";
        //    this.dataGridViewTextBoxColumn_131.Name = "Icn";
        //    this.dataGridViewTextBoxColumn_131.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_131.Width = 40;
        //    this.dataGridViewTextBoxColumn_132.DataPropertyName = "Iod";
        //    this.dataGridViewTextBoxColumn_132.HeaderText = "0 дн.";
        //    this.dataGridViewTextBoxColumn_132.Name = "Iod";
        //    this.dataGridViewTextBoxColumn_132.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_132.Width = 40;
        //    this.dataGridViewTextBoxColumn_133.DataPropertyName = "Ion";
        //    this.dataGridViewTextBoxColumn_133.HeaderText = "0 вч.";
        //    this.dataGridViewTextBoxColumn_133.Name = "Ion";
        //    this.dataGridViewTextBoxColumn_133.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_133.Width = 40;
        //    this.dataGridViewTextBoxColumn_134.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    this.dataGridViewTextBoxColumn_134.DataPropertyName = "Comment";
        //    this.dataGridViewTextBoxColumn_134.HeaderText = "Комментарий";
        //    this.dataGridViewTextBoxColumn_134.MinimumWidth = 80;
        //    this.dataGridViewTextBoxColumn_134.Name = "commentDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_134.ReadOnly = true;
        //    this.bindingSource_7.DataMember = "vJ_MeasCable";
        //    this.bindingSource_7.DataSource = this.dsJournal;
        //    this.dataGridView_3.AllowUserToAddRows = false;
        //    this.dataGridView_3.AllowUserToDeleteRows = false;
        //    this.dataGridView_3.AllowUserToResizeRows = false;
        //    this.dataGridView_3.AutoGenerateColumns = false;
        //    this.dataGridView_3.BackgroundColor = Color.White;
        //    style13.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    style13.BackColor = SystemColors.Control;
        //    style13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style13.ForeColor = SystemColors.WindowText;
        //    style13.SelectionBackColor = SystemColors.Highlight;
        //    style13.SelectionForeColor = SystemColors.HighlightText;
        //    style13.WrapMode = DataGridViewTriState.True;
        //    this.dataGridView_3.ColumnHeadersDefaultCellStyle = style13;
        //    this.dataGridView_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //    DataGridViewColumn[] columnArray4 = new DataGridViewColumn[] { this.dataGridViewComboBoxColumn_0, this.dataGridViewComboBoxColumn_1, this.dataGridViewCheckBoxColumn_4, this.dataGridViewTextBoxColumn_150, this.dataGridViewTextBoxColumn_151, this.dataGridViewTextBoxColumn_152, this.dataGridViewTextBoxColumn_153, this.dataGridViewTextBoxColumn_154, this.dataGridViewTextBoxColumn_155, this.dataGridViewTextBoxColumn_156 };
        //    this.dataGridView_3.Columns.AddRange(columnArray4);
        //    this.dataGridView_3.DataSource = this.bindingSource_9;
        //    style14.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    style14.BackColor = Color.White;
        //    style14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style14.ForeColor = SystemColors.ControlText;
        //    style14.SelectionBackColor = SystemColors.Highlight;
        //    style14.SelectionForeColor = SystemColors.HighlightText;
        //    style14.WrapMode = DataGridViewTriState.False;
        //    this.dataGridView_3.DefaultCellStyle = style14;
        //    this.dataGridView_3.Dock = DockStyle.Fill;
        //    this.dataGridView_3.Location = new Point(7, 0x1c);
        //    this.dataGridView_3.Margin = new Padding(3, 3, 7, 3);
        //    this.dataGridView_3.MultiSelect = false;
        //    this.dataGridView_3.Name = "dgvMeasurement";
        //    this.dataGridView_3.ReadOnly = true;
        //    style15.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    style15.BackColor = SystemColors.Control;
        //    style15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style15.ForeColor = SystemColors.WindowText;
        //    style15.SelectionBackColor = SystemColors.Highlight;
        //    style15.SelectionForeColor = SystemColors.HighlightText;
        //    style15.WrapMode = DataGridViewTriState.True;
        //    this.dataGridView_3.RowHeadersDefaultCellStyle = style15;
        //    this.dataGridView_3.RowHeadersVisible = false;
        //    this.dataGridView_3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    this.dataGridView_3.Size = new Size(0x31e, 0x5b);
        //    this.dataGridView_3.TabIndex = 13;
        //    this.dataGridView_3.DataError += new DataGridViewDataErrorEventHandler(this.dataGridView_3_DataError);
        //    this.dataGridViewComboBoxColumn_0.DataPropertyName = "idWorker";
        //    this.dataGridViewComboBoxColumn_0.DataSource = this.bindingSource_10;
        //    this.dataGridViewComboBoxColumn_0.DisplayMember = "FIO";
        //    this.dataGridViewComboBoxColumn_0.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
        //    this.dataGridViewComboBoxColumn_0.HeaderText = "Электромонтер";
        //    this.dataGridViewComboBoxColumn_0.MinimumWidth = 70;
        //    this.dataGridViewComboBoxColumn_0.Name = "idWorkerDataGridViewTextBoxColumn";
        //    this.dataGridViewComboBoxColumn_0.ReadOnly = true;
        //    this.dataGridViewComboBoxColumn_0.Resizable = DataGridViewTriState.True;
        //    this.dataGridViewComboBoxColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
        //    this.dataGridViewComboBoxColumn_0.ValueMember = "Id";
        //    this.dataGridViewComboBoxColumn_0.Width = 150;
        //    this.bindingSource_10.DataMember = "vP_Worker";
        //    this.bindingSource_10.DataSource = this.dsJournal;
        //    this.bindingSource_10.Filter = "ParentKey = '' OR ParentKey = ';GroupWorker;Meas;'";
        //    this.bindingSource_10.Sort = "FIO";
        //    this.idWorkerCheck.DataPropertyName = "idWorkerCheck";
        //    this.idWorkerCheck.DataSource = this.bindingSource_19;
        //    this.idWorkerCheck.DisplayMember = "FIO";
        //    this.idWorkerCheck.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
        //    this.idWorkerCheck.HeaderText = "Диспетчер";
        //    this.idWorkerCheck.Name = "idWorkerCheck";
        //    this.idWorkerCheck.ReadOnly = true;
        //    this.idWorkerCheck.Resizable = DataGridViewTriState.True;
        //    this.idWorkerCheck.SortMode = DataGridViewColumnSortMode.Automatic;
        //    this.idWorkerCheck.ValueMember = "Id";
        //    this.bindingSource_19.DataMember = "vP_Worker";
        //    this.bindingSource_19.DataSource = this.dsJournal;
        //    this.bindingSource_19.Filter = "ParentKey = '' OR ParentKey = ';GroupWorker;MeasDispatchers;'";
        //    this.bindingSource_19.Sort = "FIO";
        //    this.dataGridViewCheckBoxColumn_4.DataPropertyName = "Deleted";
        //    this.dataGridViewCheckBoxColumn_4.HeaderText = "Deleted";
        //    this.dataGridViewCheckBoxColumn_4.Name = "deletedDataGridViewCheckBoxColumn1";
        //    this.dataGridViewCheckBoxColumn_4.ReadOnly = true;
        //    this.dataGridViewCheckBoxColumn_4.Visible = false;
        //    this.dataGridViewTextBoxColumn_150.DataPropertyName = "id";
        //    this.dataGridViewTextBoxColumn_150.HeaderText = "id";
        //    this.dataGridViewTextBoxColumn_150.Name = "idDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_150.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_150.Visible = false;
        //    this.dataGridViewTextBoxColumn_151.DataPropertyName = "idObjList";
        //    this.dataGridViewTextBoxColumn_151.HeaderText = "idObjList";
        //    this.dataGridViewTextBoxColumn_151.Name = "idObjListDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_151.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_151.Visible = false;
        //    this.dataGridViewTextBoxColumn_152.DataPropertyName = "DateD";
        //    this.dataGridViewTextBoxColumn_152.HeaderText = "Дата замера дн.";
        //    this.dataGridViewTextBoxColumn_152.MinimumWidth = 70;
        //    this.dataGridViewTextBoxColumn_152.Name = "dateDDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_152.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_153.DataPropertyName = "TemperatureD";
        //    style16.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    this.dataGridViewTextBoxColumn_153.DefaultCellStyle = style16;
        //    this.dataGridViewTextBoxColumn_153.HeaderText = "Температура дн.";
        //    this.dataGridViewTextBoxColumn_153.MinimumWidth = 70;
        //    this.dataGridViewTextBoxColumn_153.Name = "temperatureDDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_153.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_154.DataPropertyName = "DateN";
        //    this.dataGridViewTextBoxColumn_154.HeaderText = "Дата замера вч.";
        //    this.dataGridViewTextBoxColumn_154.MinimumWidth = 70;
        //    this.dataGridViewTextBoxColumn_154.Name = "dateNDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_154.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_155.DataPropertyName = "TemperatureN";
        //    style17.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    this.dataGridViewTextBoxColumn_155.DefaultCellStyle = style17;
        //    this.dataGridViewTextBoxColumn_155.HeaderText = "Температура вч.";
        //    this.dataGridViewTextBoxColumn_155.MinimumWidth = 70;
        //    this.dataGridViewTextBoxColumn_155.Name = "temperatureNDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_155.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_156.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    this.dataGridViewTextBoxColumn_156.DataPropertyName = "Comment";
        //    this.dataGridViewTextBoxColumn_156.HeaderText = "Дополнительно";
        //    this.dataGridViewTextBoxColumn_156.MinimumWidth = 100;
        //    this.dataGridViewTextBoxColumn_156.Name = "Comment";
        //    this.dataGridViewTextBoxColumn_156.ReadOnly = true;
        //    this.bindingSource_9.DataMember = "tJ_Measurement";
        //    this.bindingSource_9.DataSource = this.dsJournal;
        //    this.bindingSource_9.CurrentChanged += new EventHandler(this.bindingSource_9_CurrentChanged);
        //    this.tableLayoutPanel_4.ColumnCount = 3;
        //    this.tableLayoutPanel_4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 158f));
        //    this.tableLayoutPanel_4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 143f));
        //    this.tableLayoutPanel_4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
        //    this.tableLayoutPanel_4.Controls.Add(this.panel_14, 0, 1);
        //    this.tableLayoutPanel_4.Controls.Add(this.panel_19, 2, 1);
        //    this.tableLayoutPanel_4.Controls.Add(this.dataGridView_4, 0, 3);
        //    this.tableLayoutPanel_4.Controls.Add(this.dataGridView_5, 0, 2);
        //    this.tableLayoutPanel_4.Controls.Add(this.label_23, 0, 0);
        //    this.tableLayoutPanel_4.Controls.Add(this.comboBox_2, 1, 0);
        //    this.tableLayoutPanel_4.Controls.Add(this.label_30, 2, 0);
        //    this.tableLayoutPanel_4.Dock = DockStyle.Fill;
        //    this.tableLayoutPanel_4.Location = new Point(7, 0x143);
        //    this.tableLayoutPanel_4.Name = "tlpMeasurementHigh";
        //    this.tableLayoutPanel_4.RowCount = 4;
        //    this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 21f));
        //    this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 108f));
        //    this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
        //    this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 28f));
        //    this.tableLayoutPanel_4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
        //    this.tableLayoutPanel_4.Size = new Size(0x322, 0xc0);
        //    this.tableLayoutPanel_4.TabIndex = 0x11;
        //    this.tableLayoutPanel_4.SetColumnSpan(this.panel_14, 2);
        //    this.panel_14.Controls.Add(this.label_24);
        //    this.panel_14.Controls.Add(this.label_25);
        //    this.panel_14.Controls.Add(this.label_26);
        //    this.panel_14.Controls.Add(this.label_27);
        //    this.panel_14.Controls.Add(this.panel_15);
        //    this.panel_14.Controls.Add(this.panel_16);
        //    this.panel_14.Controls.Add(this.panel_17);
        //    this.panel_14.Controls.Add(this.panel_18);
        //    this.panel_14.Dock = DockStyle.Fill;
        //    this.panel_14.Location = new Point(3, 0x18);
        //    this.panel_14.Name = "pnlTransfReferenceCell";
        //    this.panel_14.Size = new Size(0x127, 0x66);
        //    this.panel_14.TabIndex = 20;
        //    this.label_24.BorderStyle = BorderStyle.FixedSingle;
        //    this.label_24.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    this.label_24.Location = new Point(0, 0);
        //    this.label_24.Name = "label29";
        //    this.label_24.Size = new Size(0x7c, 0x33);
        //    this.label_24.TabIndex = 0;
        //    this.label_24.Text = "Трансформатор";
        //    this.label_24.TextAlign = ContentAlignment.MiddleCenter;
        //    this.label_25.BorderStyle = BorderStyle.FixedSingle;
        //    this.label_25.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    this.label_25.Location = new Point(0x7b, 0);
        //    this.label_25.Name = "label30";
        //    this.label_25.Size = new Size(0x4b, 0x33);
        //    this.label_25.TabIndex = 0;
        //    this.label_25.Text = "Мощность кВт";
        //    this.label_25.TextAlign = ContentAlignment.MiddleCenter;
        //    this.label_26.BorderStyle = BorderStyle.FixedSingle;
        //    this.label_26.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    this.label_26.Location = new Point(0xc5, 0);
        //    this.label_26.Name = "label31";
        //    this.label_26.Size = new Size(0x33, 0x33);
        //    this.label_26.TabIndex = 0;
        //    this.label_26.Text = "Uвн\r\n(раб)";
        //    this.label_26.TextAlign = ContentAlignment.MiddleCenter;
        //    this.label_27.BorderStyle = BorderStyle.FixedSingle;
        //    this.label_27.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    this.label_27.Location = new Point(0xf7, 0);
        //    this.label_27.Name = "label32";
        //    this.label_27.Size = new Size(0x2f, 0x33);
        //    this.label_27.TabIndex = 0;
        //    this.label_27.Text = "Iном\r\nА";
        //    this.label_27.TextAlign = ContentAlignment.MiddleCenter;
        //    this.panel_15.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_15.Controls.Add(this.textBox_23);
        //    this.panel_15.Controls.Add(this.textBox_24);
        //    this.panel_15.Controls.Add(this.label_28);
        //    this.panel_15.Controls.Add(this.label_29);
        //    this.panel_15.Location = new Point(0, 50);
        //    this.panel_15.Name = "panel16";
        //    this.panel_15.Size = new Size(0x7c, 0x34);
        //    this.panel_15.TabIndex = 5;
        //    this.textBox_23.BackColor = Color.White;
        //    this.textBox_23.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Type", true));
        //    this.textBox_23.Location = new Point(0x24, 2);
        //    this.textBox_23.Name = "textBox5";
        //    this.textBox_23.ReadOnly = true;
        //    this.textBox_23.Size = new Size(0x4f, 20);
        //    this.textBox_23.TabIndex = 2;
        //    this.textBox_24.BackColor = Color.White;
        //    this.textBox_24.DataBindings.Add(new Binding("Text", this.bindingSource_0, "InvNumber", true));
        //    this.textBox_24.Location = new Point(0x24, 0x1c);
        //    this.textBox_24.Name = "textBox6";
        //    this.textBox_24.ReadOnly = true;
        //    this.textBox_24.Size = new Size(0x4f, 20);
        //    this.textBox_24.TabIndex = 2;
        //    this.label_28.AutoSize = true;
        //    this.label_28.Location = new Point(4, 5);
        //    this.label_28.Name = "label34";
        //    this.label_28.Size = new Size(0x1a, 13);
        //    this.label_28.TabIndex = 4;
        //    this.label_28.Text = "Тип";
        //    this.label_29.AutoSize = true;
        //    this.label_29.Location = new Point(8, 0x1f);
        //    this.label_29.Name = "label35";
        //    this.label_29.Size = new Size(0x12, 13);
        //    this.label_29.TabIndex = 4;
        //    this.label_29.Text = "№";
        //    this.panel_16.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_16.Controls.Add(this.textBox_25);
        //    this.panel_16.Location = new Point(0xf7, 50);
        //    this.panel_16.Name = "panel18";
        //    this.panel_16.Size = new Size(0x2f, 0x34);
        //    this.panel_16.TabIndex = 5;
        //    this.textBox_25.BackColor = Color.White;
        //    this.textBox_25.DataBindings.Add(new Binding("Text", this.bindingSource_0, "InomHV", true));
        //    this.textBox_25.Location = new Point(2, 15);
        //    this.textBox_25.Name = "textBox7";
        //    this.textBox_25.ReadOnly = true;
        //    this.textBox_25.Size = new Size(40, 20);
        //    this.textBox_25.TabIndex = 2;
        //    this.panel_17.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_17.Controls.Add(this.textBox_26);
        //    this.panel_17.Location = new Point(0x7b, 50);
        //    this.panel_17.Name = "panel19";
        //    this.panel_17.Size = new Size(0x4b, 0x34);
        //    this.panel_17.TabIndex = 5;
        //    this.textBox_26.BackColor = Color.White;
        //    this.textBox_26.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Power", true));
        //    this.textBox_26.Location = new Point(3, 15);
        //    this.textBox_26.Name = "textBox8";
        //    this.textBox_26.ReadOnly = true;
        //    this.textBox_26.Size = new Size(0x43, 20);
        //    this.textBox_26.TabIndex = 2;
        //    this.panel_18.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_18.Controls.Add(this.textBox_27);
        //    this.panel_18.Location = new Point(0xc5, 50);
        //    this.panel_18.Name = "panel20";
        //    this.panel_18.Size = new Size(0x33, 0x34);
        //    this.panel_18.TabIndex = 5;
        //    this.textBox_27.BackColor = Color.White;
        //    this.textBox_27.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Unom", true));
        //    this.textBox_27.Location = new Point(2, 15);
        //    this.textBox_27.Name = "textBox9";
        //    this.textBox_27.ReadOnly = true;
        //    this.textBox_27.Size = new Size(0x2c, 20);
        //    this.textBox_27.TabIndex = 2;
        //    this.panel_19.Controls.Add(this.panel_20);
        //    this.panel_19.Controls.Add(this.panel_21);
        //    this.panel_19.Controls.Add(this.panel_22);
        //    this.panel_19.Controls.Add(this.panel_23);
        //    this.panel_19.Controls.Add(this.panel_24);
        //    this.panel_19.Controls.Add(this.label_34);
        //    this.panel_19.Controls.Add(this.panel_25);
        //    this.panel_19.Dock = DockStyle.Fill;
        //    this.panel_19.Location = new Point(0x130, 0x18);
        //    this.panel_19.Name = "pnlAmperageTransf";
        //    this.panel_19.Size = new Size(0x1ef, 0x66);
        //    this.panel_19.TabIndex = 0x11;
        //    this.panel_20.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_20.Controls.Add(this.label_31);
        //    this.panel_20.Location = new Point(0xd3, 0);
        //    this.panel_20.Name = "panel21";
        //    this.panel_20.Size = new Size(0x45, 0x33);
        //    this.panel_20.TabIndex = 0x10;
        //    this.label_31.Dock = DockStyle.Fill;
        //    this.label_31.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    this.label_31.Location = new Point(0, 0);
        //    this.label_31.Name = "label25";
        //    this.label_31.Size = new Size(0x43, 0x31);
        //    this.label_31.TabIndex = 2;
        //    this.label_31.Text = "B";
        //    this.label_31.TextAlign = ContentAlignment.MiddleCenter;
        //    this.panel_21.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_21.Controls.Add(this.label_32);
        //    this.panel_21.Location = new Point(0x117, 0);
        //    this.panel_21.Name = "panel17";
        //    this.panel_21.Size = new Size(0x48, 0x33);
        //    this.panel_21.TabIndex = 15;
        //    this.label_32.Dock = DockStyle.Fill;
        //    this.label_32.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    this.label_32.Location = new Point(0, 0);
        //    this.label_32.Name = "label26";
        //    this.label_32.Size = new Size(70, 0x31);
        //    this.label_32.TabIndex = 2;
        //    this.label_32.Text = "C";
        //    this.label_32.TextAlign = ContentAlignment.MiddleCenter;
        //    this.panel_22.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_22.Controls.Add(this.label_33);
        //    this.panel_22.Location = new Point(140, 0);
        //    this.panel_22.Name = "panel1";
        //    this.panel_22.Size = new Size(0x48, 0x33);
        //    this.panel_22.TabIndex = 14;
        //    this.label_33.Dock = DockStyle.Fill;
        //    this.label_33.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    this.label_33.Location = new Point(0, 0);
        //    this.label_33.Name = "label24";
        //    this.label_33.Size = new Size(70, 0x31);
        //    this.label_33.TabIndex = 1;
        //    this.label_33.Text = "A";
        //    this.label_33.TextAlign = ContentAlignment.MiddleCenter;
        //    this.panel_23.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_23.Controls.Add(this.textBox_28);
        //    this.panel_23.Location = new Point(0x117, 50);
        //    this.panel_23.Name = "panel13";
        //    this.panel_23.Size = new Size(0x48, 0x34);
        //    this.panel_23.TabIndex = 12;
        //    this.textBox_28.BackColor = Color.White;
        //    this.textBox_28.DataBindings.Add(new Binding("Text", this.bindingSource_11, "Ic", true));
        //    this.textBox_28.Location = new Point(3, 0x10);
        //    this.textBox_28.Name = "textBox3";
        //    this.textBox_28.ReadOnly = true;
        //    this.textBox_28.Size = new Size(0x3f, 20);
        //    this.textBox_28.TabIndex = 2;
        //    this.bindingSource_11.DataMember = "tJ_MeasAmperageTransf";
        //    this.bindingSource_11.DataSource = this.dsJournal;
        //    this.panel_24.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_24.Controls.Add(this.textBox_29);
        //    this.panel_24.Location = new Point(0xd3, 50);
        //    this.panel_24.Name = "panel12";
        //    this.panel_24.Size = new Size(0x45, 0x34);
        //    this.panel_24.TabIndex = 11;
        //    this.textBox_29.BackColor = Color.White;
        //    this.textBox_29.DataBindings.Add(new Binding("Text", this.bindingSource_11, "Ib", true));
        //    this.textBox_29.Location = new Point(3, 0x10);
        //    this.textBox_29.Name = "textBox1";
        //    this.textBox_29.ReadOnly = true;
        //    this.textBox_29.Size = new Size(0x3d, 20);
        //    this.textBox_29.TabIndex = 2;
        //    this.label_34.BorderStyle = BorderStyle.FixedSingle;
        //    this.label_34.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    this.label_34.Location = new Point(0, 0);
        //    this.label_34.Name = "label7";
        //    this.label_34.Size = new Size(0x8d, 0x66);
        //    this.label_34.TabIndex = 10;
        //    this.label_34.Text = "Ток нагрузки";
        //    this.label_34.TextAlign = ContentAlignment.MiddleCenter;
        //    this.panel_25.BorderStyle = BorderStyle.FixedSingle;
        //    this.panel_25.Controls.Add(this.textBox_30);
        //    this.panel_25.Location = new Point(140, 50);
        //    this.panel_25.Name = "panel14";
        //    this.panel_25.Size = new Size(0x48, 0x34);
        //    this.panel_25.TabIndex = 6;
        //    this.textBox_30.BackColor = Color.White;
        //    this.textBox_30.DataBindings.Add(new Binding("Text", this.bindingSource_11, "Ia", true));
        //    this.textBox_30.Location = new Point(3, 0x10);
        //    this.textBox_30.Name = "tbIa";
        //    this.textBox_30.ReadOnly = true;
        //    this.textBox_30.Size = new Size(0x40, 20);
        //    this.textBox_30.TabIndex = 2;
        //    this.dataGridView_4.AllowUserToResizeRows = false;
        //    this.dataGridView_4.BackgroundColor = Color.White;
        //    style18.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    style18.BackColor = SystemColors.Control;
        //    style18.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style18.ForeColor = SystemColors.WindowText;
        //    style18.SelectionBackColor = SystemColors.Highlight;
        //    style18.SelectionForeColor = SystemColors.HighlightText;
        //    style18.WrapMode = DataGridViewTriState.True;
        //    this.dataGridView_4.ColumnHeadersDefaultCellStyle = style18;
        //    this.dataGridView_4.ColumnHeadersVisible = false;
        //    DataGridViewColumn[] columnArray5 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_32, this.dataGridViewTextBoxColumn_33, this.dataGridViewTextBoxColumn_34, this.dataGridViewTextBoxColumn_35, this.dataGridViewTextBoxColumn_36, this.dataGridViewTextBoxColumn_37, this.dataGridViewTextBoxColumn_38, this.dataGridViewTextBoxColumn_39 };
        //    this.dataGridView_4.Columns.AddRange(columnArray5);
        //    this.tableLayoutPanel_4.SetColumnSpan(this.dataGridView_4, 3);
        //    style19.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    style19.BackColor = Color.White;
        //    style19.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style19.ForeColor = Color.Black;
        //    style19.SelectionBackColor = Color.White;
        //    style19.SelectionForeColor = Color.Black;
        //    style19.WrapMode = DataGridViewTriState.False;
        //    this.dataGridView_4.DefaultCellStyle = style19;
        //    this.dataGridView_4.Dock = DockStyle.Fill;
        //    this.dataGridView_4.Location = new Point(3, 0xa7);
        //    this.dataGridView_4.Margin = new Padding(3, 3, 7, 3);
        //    this.dataGridView_4.MultiSelect = false;
        //    this.dataGridView_4.Name = "dgvSumCell";
        //    this.dataGridView_4.ReadOnly = true;
        //    style20.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    style20.BackColor = SystemColors.Control;
        //    style20.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style20.ForeColor = SystemColors.WindowText;
        //    style20.SelectionBackColor = SystemColors.Highlight;
        //    style20.SelectionForeColor = SystemColors.HighlightText;
        //    style20.WrapMode = DataGridViewTriState.True;
        //    this.dataGridView_4.RowHeadersDefaultCellStyle = style20;
        //    this.dataGridView_4.RowHeadersVisible = false;
        //    this.dataGridView_4.ScrollBars = ScrollBars.None;
        //    this.dataGridView_4.Size = new Size(0x318, 0x16);
        //    this.dataGridView_4.TabIndex = 0x10;
        //    this.dataGridViewTextBoxColumn_32.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_32.DataPropertyName = "Address";
        //    this.dataGridViewTextBoxColumn_32.HeaderText = "SumName";
        //    this.dataGridViewTextBoxColumn_32.Name = "dataGridViewTextBoxColumn23";
        //    this.dataGridViewTextBoxColumn_32.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_32.Width = 110;
        //    this.dataGridViewTextBoxColumn_33.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_33.DataPropertyName = "Company";
        //    this.dataGridViewTextBoxColumn_33.HeaderText = "ad";
        //    this.dataGridViewTextBoxColumn_33.Name = "dataGridViewTextBoxColumn24";
        //    this.dataGridViewTextBoxColumn_33.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_33.Width = 60;
        //    this.dataGridViewTextBoxColumn_34.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_34.DataPropertyName = "idSchmAbn";
        //    this.dataGridViewTextBoxColumn_34.HeaderText = "an";
        //    this.dataGridViewTextBoxColumn_34.Name = "dataGridViewTextBoxColumn25";
        //    this.dataGridViewTextBoxColumn_34.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_34.Visible = false;
        //    this.dataGridViewTextBoxColumn_34.Width = 60;
        //    this.dataGridViewTextBoxColumn_35.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_35.DataPropertyName = "Makeup";
        //    this.dataGridViewTextBoxColumn_35.HeaderText = "bd";
        //    this.dataGridViewTextBoxColumn_35.Name = "dataGridViewTextBoxColumn26";
        //    this.dataGridViewTextBoxColumn_35.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_35.Resizable = DataGridViewTriState.True;
        //    this.dataGridViewTextBoxColumn_35.Width = 60;
        //    this.dataGridViewTextBoxColumn_36.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_36.DataPropertyName = "Voltage";
        //    this.dataGridViewTextBoxColumn_36.HeaderText = "bn";
        //    this.dataGridViewTextBoxColumn_36.Name = "dataGridViewTextBoxColumn27";
        //    this.dataGridViewTextBoxColumn_36.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_36.Resizable = DataGridViewTriState.True;
        //    this.dataGridViewTextBoxColumn_36.Visible = false;
        //    this.dataGridViewTextBoxColumn_36.Width = 60;
        //    this.dataGridViewTextBoxColumn_37.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_37.DataPropertyName = "Wires";
        //    this.dataGridViewTextBoxColumn_37.HeaderText = "cd";
        //    this.dataGridViewTextBoxColumn_37.Name = "dataGridViewTextBoxColumn28";
        //    this.dataGridViewTextBoxColumn_37.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_37.Width = 60;
        //    this.dataGridViewTextBoxColumn_38.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_38.DataPropertyName = "CrossSection";
        //    this.dataGridViewTextBoxColumn_38.HeaderText = "cn";
        //    this.dataGridViewTextBoxColumn_38.Name = "dataGridViewTextBoxColumn29";
        //    this.dataGridViewTextBoxColumn_38.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_38.Resizable = DataGridViewTriState.True;
        //    this.dataGridViewTextBoxColumn_38.Width = 60;
        //    this.dataGridViewTextBoxColumn_39.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    this.dataGridViewTextBoxColumn_39.DataPropertyName = "Ian";
        //    style21.Format = "N0";
        //    this.dataGridViewTextBoxColumn_39.DefaultCellStyle = style21;
        //    this.dataGridViewTextBoxColumn_39.HeaderText = "Comment";
        //    this.dataGridViewTextBoxColumn_39.MinimumWidth = 80;
        //    this.dataGridViewTextBoxColumn_39.Name = "dataGridViewTextBoxColumn32";
        //    this.dataGridViewTextBoxColumn_39.ReadOnly = true;
        //    this.dataGridView_5.AllowUserToAddRows = false;
        //    this.dataGridView_5.AllowUserToDeleteRows = false;
        //    this.dataGridView_5.AllowUserToOrderColumns = true;
        //    this.dataGridView_5.AllowUserToResizeRows = false;
        //    this.dataGridView_5.AutoGenerateColumns = false;
        //    this.dataGridView_5.BackgroundColor = Color.White;
        //    style22.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    style22.BackColor = SystemColors.Control;
        //    style22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style22.ForeColor = SystemColors.WindowText;
        //    style22.SelectionBackColor = SystemColors.Highlight;
        //    style22.SelectionForeColor = SystemColors.HighlightText;
        //    style22.WrapMode = DataGridViewTriState.True;
        //    this.dataGridView_5.ColumnHeadersDefaultCellStyle = style22;
        //    this.dataGridView_5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //    DataGridViewColumn[] columnArray6 = new DataGridViewColumn[] { this.dataGridViewCheckBoxColumn_2, this.dataGridViewTextBoxColumn_40, this.dataGridViewTextBoxColumn_41, this.dataGridViewTextBoxColumn_42, this.dataGridViewTextBoxColumn_43, this.dataGridViewTextBoxColumn_44, this.dataGridViewTextBoxColumn_45, this.dataGridViewTextBoxColumn_46, this.dataGridViewTextBoxColumn_47, this.dataGridViewTextBoxColumn_48, this.dataGridViewTextBoxColumn_49, this.dataGridViewTextBoxColumn_50, this.dataGridViewTextBoxColumn_51, this.dataGridViewTextBoxColumn_52 };
        //    this.dataGridView_5.Columns.AddRange(columnArray6);
        //    this.tableLayoutPanel_4.SetColumnSpan(this.dataGridView_5, 3);
        //    this.dataGridView_5.DataSource = this.bindingSource_16;
        //    style23.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    style23.BackColor = Color.White;
        //    style23.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style23.ForeColor = SystemColors.ControlText;
        //    style23.SelectionBackColor = SystemColors.Highlight;
        //    style23.SelectionForeColor = SystemColors.HighlightText;
        //    style23.WrapMode = DataGridViewTriState.False;
        //    this.dataGridView_5.DefaultCellStyle = style23;
        //    this.dataGridView_5.Dock = DockStyle.Fill;
        //    this.dataGridView_5.Location = new Point(3, 0x84);
        //    this.dataGridView_5.Margin = new Padding(3, 3, 7, 3);
        //    this.dataGridView_5.MultiSelect = false;
        //    this.dataGridView_5.Name = "dgvMeasCell";
        //    this.dataGridView_5.ReadOnly = true;
        //    style24.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //    style24.BackColor = SystemColors.Control;
        //    style24.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    style24.ForeColor = SystemColors.WindowText;
        //    style24.SelectionBackColor = SystemColors.Highlight;
        //    style24.SelectionForeColor = SystemColors.HighlightText;
        //    style24.WrapMode = DataGridViewTriState.True;
        //    this.dataGridView_5.RowHeadersDefaultCellStyle = style24;
        //    this.dataGridView_5.RowHeadersVisible = false;
        //    this.dataGridView_5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    this.dataGridView_5.Size = new Size(0x318, 0x1d);
        //    this.dataGridView_5.TabIndex = 12;
        //    this.dataGridView_5.ColumnWidthChanged += new DataGridViewColumnEventHandler(this.dataGridView_5_ColumnWidthChanged);
        //    this.dataGridView_5.Scroll += new ScrollEventHandler(this.dataGridView_5_Scroll);
        //    this.dataGridViewCheckBoxColumn_2.DataPropertyName = "Deleted";
        //    this.dataGridViewCheckBoxColumn_2.HeaderText = "Deleted";
        //    this.dataGridViewCheckBoxColumn_2.Name = "deletedDataGridViewCheckBoxColumn4";
        //    this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
        //    this.dataGridViewCheckBoxColumn_2.Visible = false;
        //    this.dataGridViewTextBoxColumn_40.DataPropertyName = "id";
        //    this.dataGridViewTextBoxColumn_40.HeaderText = "id";
        //    this.dataGridViewTextBoxColumn_40.Name = "idDataGridViewTextBoxColumn4";
        //    this.dataGridViewTextBoxColumn_40.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_40.Visible = false;
        //    this.dataGridViewTextBoxColumn_41.DataPropertyName = "idMeasurement";
        //    this.dataGridViewTextBoxColumn_41.HeaderText = "idMeasurement";
        //    this.dataGridViewTextBoxColumn_41.Name = "idMeasurementDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_41.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_41.Visible = false;
        //    this.dataGridViewTextBoxColumn_42.DataPropertyName = "idBus";
        //    this.dataGridViewTextBoxColumn_42.HeaderText = "idBus";
        //    this.dataGridViewTextBoxColumn_42.Name = "idBus";
        //    this.dataGridViewTextBoxColumn_42.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_42.Visible = false;
        //    this.dataGridViewTextBoxColumn_43.DataPropertyName = "NameBus";
        //    this.dataGridViewTextBoxColumn_43.HeaderText = "NameBus";
        //    this.dataGridViewTextBoxColumn_43.Name = "nameBusDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_43.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_43.Visible = false;
        //    this.dataGridViewTextBoxColumn_44.DataPropertyName = "NameCell";
        //    this.dataGridViewTextBoxColumn_44.HeaderText = "№ руб.";
        //    this.dataGridViewTextBoxColumn_44.Name = "nameCellDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_44.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_44.Width = 30;
        //    this.dataGridViewTextBoxColumn_45.DataPropertyName = "PermissAmperage";
        //    this.dataGridViewTextBoxColumn_45.HeaderText = "Допуст. нагр., А";
        //    this.dataGridViewTextBoxColumn_45.Name = "permissAmperageDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_45.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_45.Width = 80;
        //    this.dataGridViewTextBoxColumn_46.DataPropertyName = "Iad";
        //    this.dataGridViewTextBoxColumn_46.HeaderText = "А дн.";
        //    this.dataGridViewTextBoxColumn_46.Name = "iadDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_46.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_46.Width = 60;
        //    this.dataGridViewTextBoxColumn_47.DataPropertyName = "Ian";
        //    this.dataGridViewTextBoxColumn_47.HeaderText = "А вч.";
        //    this.dataGridViewTextBoxColumn_47.Name = "ianDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_47.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_47.Width = 60;
        //    this.dataGridViewTextBoxColumn_48.DataPropertyName = "Ibd";
        //    this.dataGridViewTextBoxColumn_48.HeaderText = "В дн.";
        //    this.dataGridViewTextBoxColumn_48.Name = "ibdDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_48.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_48.Width = 60;
        //    this.dataGridViewTextBoxColumn_49.DataPropertyName = "Ibn";
        //    this.dataGridViewTextBoxColumn_49.HeaderText = "В вч.";
        //    this.dataGridViewTextBoxColumn_49.Name = "ibnDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_49.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_49.Width = 60;
        //    this.dataGridViewTextBoxColumn_50.DataPropertyName = "Icd";
        //    this.dataGridViewTextBoxColumn_50.HeaderText = "С дн.";
        //    this.dataGridViewTextBoxColumn_50.Name = "icdDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_50.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_50.Width = 60;
        //    this.dataGridViewTextBoxColumn_51.DataPropertyName = "Icn";
        //    this.dataGridViewTextBoxColumn_51.HeaderText = "С вч.";
        //    this.dataGridViewTextBoxColumn_51.Name = "icnDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_51.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_51.Width = 60;
        //    this.dataGridViewTextBoxColumn_52.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    this.dataGridViewTextBoxColumn_52.DataPropertyName = "Comment";
        //    this.dataGridViewTextBoxColumn_52.HeaderText = "Комментарий";
        //    this.dataGridViewTextBoxColumn_52.Name = "commentDataGridViewTextBoxColumn3";
        //    this.dataGridViewTextBoxColumn_52.ReadOnly = true;
        //    this.bindingSource_16.DataMember = "vJ_MeasCell";
        //    this.bindingSource_16.DataSource = this.dsJournal;
        //    this.label_23.AutoSize = true;
        //    this.label_23.BorderStyle = BorderStyle.FixedSingle;
        //    this.label_23.Dock = DockStyle.Fill;
        //    this.label_23.Location = new Point(3, 0);
        //    this.label_23.Name = "label28";
        //    this.label_23.Size = new Size(0x98, 0x15);
        //    this.label_23.TabIndex = 0x12;
        //    this.label_23.Text = "Секция шин №";
        //    this.label_23.TextAlign = ContentAlignment.MiddleCenter;
        //    this.comboBox_2.DataSource = this.bsBusesTransfs;
        //    this.comboBox_2.DisplayMember = "Name";
        //    this.comboBox_2.Dock = DockStyle.Left;
        //    this.comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
        //    this.comboBox_2.FormattingEnabled = true;
        //    this.comboBox_2.Location = new Point(0x9e, 0);
        //    this.comboBox_2.Margin = new Padding(0);
        //    this.comboBox_2.Name = "cbBusesMV";
        //    this.comboBox_2.Size = new Size(0x67, 0x15);
        //    this.comboBox_2.TabIndex = 0x13;
        //    this.comboBox_2.ValueMember = "idBus";
        //    this.label_30.AutoSize = true;
        //    this.label_30.Dock = DockStyle.Left;
        //    this.label_30.Location = new Point(0x130, 0);
        //    this.label_30.Name = "lbTransfName";
        //    this.label_30.Size = new Size(0x6a, 0x15);
        //    this.label_30.TabIndex = 0x15;
        //    this.label_30.Text = "Трансформатор № ";
        //    this.label_30.TextAlign = ContentAlignment.MiddleLeft;
        //    this.bindingSource_15.DataMember = "vJ_Transfs";
        //    this.bindingSource_15.DataSource = this.dsJournal;
        //    this.bindingSource_15.Sort = "Name";
        //    this.bindingSource_15.CurrentChanged += new EventHandler(this.bindingSource_15_CurrentChanged);
        //    this.tableLayoutPanel_2.ColumnCount = 2;
        //    this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 212f));
        //    this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
        //    this.tableLayoutPanel_2.Controls.Add(this.tableLayoutPanel_1, 1, 0);
        //    this.tableLayoutPanel_2.Controls.Add(this.tableLayoutPanel_0, 0, 0);
        //    this.tableLayoutPanel_2.Dock = DockStyle.Fill;
        //    this.tableLayoutPanel_2.Location = new Point(0, 0);
        //    this.tableLayoutPanel_2.Name = "tableLayoutPanel1";
        //    this.tableLayoutPanel_2.RowCount = 1;
        //    this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
        //    this.tableLayoutPanel_2.Size = new Size(0x40a, 0x232);
        //    this.tableLayoutPanel_2.TabIndex = 3;
        //    this.dataGridViewCheckBoxColumn_0.DataPropertyName = "Deleted";
        //    this.dataGridViewCheckBoxColumn_0.HeaderText = "Deleted";
        //    this.dataGridViewCheckBoxColumn_0.Name = "deletedDataGridViewCheckBoxColumn2";
        //    this.dataGridViewCheckBoxColumn_1.DataPropertyName = "Deleted";
        //    this.dataGridViewCheckBoxColumn_1.HeaderText = "Deleted";
        //    this.dataGridViewCheckBoxColumn_1.Name = "deletedDataGridViewCheckBoxColumn3";
        //    this.bindingSource_3.DataMember = "fn_J_GetCellLVByTransf";
        //    this.bindingSource_3.DataSource = this.dsJournal;
        //    this.bindingSource_3.Sort = "Name";
        //    this.bindingSource_4.DataMember = "tR_CableMakeup";
        //    this.bindingSource_4.DataSource = this.dsJournal;
        //    this.bindingSource_4.Filter = "";
        //    this.bindingSource_5.DataMember = "tR_CableVoltage";
        //    this.bindingSource_5.DataSource = this.dsJournal;
        //    this.bindingSource_5.Filter = "";
        //    this.bindingSource_6.DataMember = "tR_CrossSection";
        //    this.bindingSource_6.DataSource = this.dsJournal;
        //    this.bindingSource_6.Filter = "";
        //    this.bindingSource_2.DataMember = "tP_ValueLists";
        //    this.bindingSource_2.DataSource = this.dsJournal;
        //    this.bindingSource_2.Sort = "Name";
        //    this.bindingSource_13.DataMember = "tR_Classifier";
        //    this.bindingSource_13.DataSource = this.dsJournal;
        //    this.bindingSource_13.Filter = "ParentKey = ';Measurement;Type;'";
        //    this.bindingSource_14.DataMember = "vJ_GetMeasYears";
        //    this.bindingSource_14.DataSource = this.dsJournal;
        //    this.bindingSource_14.Sort = "Year DESC";
        //    this.bindingSource_14.CurrentChanged += new EventHandler(this.bindingSource_14_CurrentChanged);
        //    this.dataGridViewTextBoxColumn_53.DataPropertyName = "idSchmObj";
        //    this.dataGridViewTextBoxColumn_53.HeaderText = "idSchmObj";
        //    this.dataGridViewTextBoxColumn_53.Name = "dataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_53.Visible = false;
        //    this.dataGridViewTextBoxColumn_54.DataPropertyName = "Region";
        //    this.dataGridViewTextBoxColumn_54.HeaderText = "Район";
        //    this.dataGridViewTextBoxColumn_54.Name = "dataGridViewTextBoxColumn2";
        //    this.dataGridViewTextBoxColumn_54.Width = 120;
        //    this.dataGridViewTextBoxColumn_55.DataPropertyName = "Street";
        //    this.dataGridViewTextBoxColumn_55.HeaderText = "Улица";
        //    this.dataGridViewTextBoxColumn_55.Name = "dataGridViewTextBoxColumn3";
        //    this.dataGridViewTextBoxColumn_55.Width = 180;
        //    this.dataGridViewTextBoxColumn_56.DataPropertyName = "House";
        //    this.dataGridViewTextBoxColumn_56.HeaderText = "Дом";
        //    this.dataGridViewTextBoxColumn_56.Name = "dataGridViewTextBoxColumn4";
        //    this.dataGridViewTextBoxColumn_56.Width = 50;
        //    this.dataGridViewTextBoxColumn_57.DataPropertyName = "HousePrefix";
        //    this.dataGridViewTextBoxColumn_57.HeaderText = "Доп.";
        //    this.dataGridViewTextBoxColumn_57.Name = "dataGridViewTextBoxColumn5";
        //    this.dataGridViewTextBoxColumn_57.Width = 50;
        //    this.dataGridViewTextBoxColumn_58.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    this.dataGridViewTextBoxColumn_58.DataPropertyName = "Name";
        //    this.dataGridViewTextBoxColumn_58.HeaderText = "Наименование";
        //    this.dataGridViewTextBoxColumn_58.Name = "dataGridViewTextBoxColumn6";
        //    this.dataGridViewTextBoxColumn_59.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_59.HeaderText = "SumName";
        //    this.dataGridViewTextBoxColumn_59.Name = "dataGridViewTextBoxColumn7";
        //    this.dataGridViewTextBoxColumn_59.Width = 360;
        //    this.dataGridViewTextBoxColumn_60.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_60.HeaderText = "ad";
        //    this.dataGridViewTextBoxColumn_60.Name = "dataGridViewTextBoxColumn8";
        //    this.dataGridViewTextBoxColumn_60.Width = 40;
        //    this.dataGridViewTextBoxColumn_61.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_61.HeaderText = "an";
        //    this.dataGridViewTextBoxColumn_61.Name = "dataGridViewTextBoxColumn9";
        //    this.dataGridViewTextBoxColumn_61.Width = 40;
        //    this.dataGridViewTextBoxColumn_62.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_62.HeaderText = "bd";
        //    this.dataGridViewTextBoxColumn_62.Name = "dataGridViewTextBoxColumn10";
        //    this.dataGridViewTextBoxColumn_62.Width = 40;
        //    this.dataGridViewTextBoxColumn_63.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_63.HeaderText = "bn";
        //    this.dataGridViewTextBoxColumn_63.Name = "dataGridViewTextBoxColumn11";
        //    this.dataGridViewTextBoxColumn_63.Width = 40;
        //    this.dataGridViewTextBoxColumn_64.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_64.HeaderText = "cd";
        //    this.dataGridViewTextBoxColumn_64.Name = "dataGridViewTextBoxColumn12";
        //    this.dataGridViewTextBoxColumn_64.Width = 40;
        //    this.dataGridViewTextBoxColumn_65.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_65.HeaderText = "cn";
        //    this.dataGridViewTextBoxColumn_65.Name = "dataGridViewTextBoxColumn13";
        //    this.dataGridViewTextBoxColumn_65.Width = 40;
        //    this.dataGridViewTextBoxColumn_66.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_66.HeaderText = "od";
        //    this.dataGridViewTextBoxColumn_66.Name = "dataGridViewTextBoxColumn14";
        //    this.dataGridViewTextBoxColumn_66.Width = 40;
        //    this.dataGridViewTextBoxColumn_67.HeaderText = "on";
        //    this.dataGridViewTextBoxColumn_67.Name = "dataGridViewTextBoxColumn15";
        //    this.dataGridViewTextBoxColumn_67.Width = 40;
        //    this.dataGridViewTextBoxColumn_68.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    this.dataGridViewTextBoxColumn_68.HeaderText = "Comment";
        //    this.dataGridViewTextBoxColumn_68.MinimumWidth = 80;
        //    this.dataGridViewTextBoxColumn_68.Name = "dataGridViewTextBoxColumn16";
        //    this.dataGridViewTextBoxColumn_69.DataPropertyName = "NameCell";
        //    this.dataGridViewTextBoxColumn_69.HeaderText = "№ руб.";
        //    this.dataGridViewTextBoxColumn_69.Name = "dataGridViewTextBoxColumn17";
        //    this.dataGridViewTextBoxColumn_69.Width = 30;
        //    this.dataGridViewTextBoxColumn_70.DataPropertyName = "id";
        //    this.dataGridViewTextBoxColumn_70.HeaderText = "id";
        //    this.dataGridViewTextBoxColumn_70.Name = "dataGridViewTextBoxColumn18";
        //    this.dataGridViewTextBoxColumn_70.Visible = false;
        //    this.dataGridViewTextBoxColumn_71.DataPropertyName = "idMeasurement";
        //    this.dataGridViewTextBoxColumn_71.HeaderText = "idMeasurement";
        //    this.dataGridViewTextBoxColumn_71.Name = "dataGridViewTextBoxColumn19";
        //    this.dataGridViewTextBoxColumn_71.Visible = false;
        //    this.dataGridViewTextBoxColumn_72.DataPropertyName = "idTransf";
        //    this.dataGridViewTextBoxColumn_72.HeaderText = "idTransf";
        //    this.dataGridViewTextBoxColumn_72.Name = "dataGridViewTextBoxColumn20";
        //    this.dataGridViewTextBoxColumn_72.Visible = false;
        //    this.dataGridViewTextBoxColumn_73.DataPropertyName = "idCell";
        //    this.dataGridViewTextBoxColumn_73.HeaderText = "idCell";
        //    this.dataGridViewTextBoxColumn_73.Name = "dataGridViewTextBoxColumn21";
        //    this.dataGridViewTextBoxColumn_73.Resizable = DataGridViewTriState.True;
        //    this.dataGridViewTextBoxColumn_73.Visible = false;
        //    this.dataGridViewTextBoxColumn_73.Width = 30;
        //    this.dataGridViewTextBoxColumn_74.DataPropertyName = "OldCell";
        //    this.dataGridViewTextBoxColumn_74.HeaderText = "№ Ст.р";
        //    this.dataGridViewTextBoxColumn_74.Name = "dataGridViewTextBoxColumn22";
        //    this.dataGridViewTextBoxColumn_74.Width = 30;
        //    this.dataGridViewTextBoxColumn_75.DataPropertyName = "PermisAmperage";
        //    style25.Format = "N0";
        //    this.dataGridViewTextBoxColumn_75.DefaultCellStyle = style25;
        //    this.dataGridViewTextBoxColumn_75.HeaderText = "Допуст. нагр., А";
        //    this.dataGridViewTextBoxColumn_75.Name = "dataGridViewTextBoxColumn30";
        //    this.dataGridViewTextBoxColumn_75.Width = 50;
        //    this.dataGridViewTextBoxColumn_76.DataPropertyName = "Iad";
        //    style26.Format = "N0";
        //    style26.NullValue = null;
        //    this.dataGridViewTextBoxColumn_76.DefaultCellStyle = style26;
        //    this.dataGridViewTextBoxColumn_76.HeaderText = "А дн.";
        //    this.dataGridViewTextBoxColumn_76.Name = "dataGridViewTextBoxColumn31";
        //    this.dataGridViewTextBoxColumn_76.Width = 40;
        //    this.dataGridViewTextBoxColumn_77.DataPropertyName = "Ibd";
        //    this.dataGridViewTextBoxColumn_77.HeaderText = "В дн.";
        //    this.dataGridViewTextBoxColumn_77.Name = "dataGridViewTextBoxColumn33";
        //    this.dataGridViewTextBoxColumn_77.Width = 40;
        //    this.dataGridViewTextBoxColumn_78.DataPropertyName = "Ibn";
        //    this.dataGridViewTextBoxColumn_78.HeaderText = "В вч.";
        //    this.dataGridViewTextBoxColumn_78.Name = "dataGridViewTextBoxColumn34";
        //    this.dataGridViewTextBoxColumn_78.Width = 40;
        //    this.dataGridViewTextBoxColumn_79.DataPropertyName = "Icd";
        //    this.dataGridViewTextBoxColumn_79.HeaderText = "С дн.";
        //    this.dataGridViewTextBoxColumn_79.Name = "dataGridViewTextBoxColumn35";
        //    this.dataGridViewTextBoxColumn_79.Width = 40;
        //    this.dataGridViewTextBoxColumn_80.DataPropertyName = "Icn";
        //    this.dataGridViewTextBoxColumn_80.HeaderText = "С вч.";
        //    this.dataGridViewTextBoxColumn_80.Name = "dataGridViewTextBoxColumn36";
        //    this.dataGridViewTextBoxColumn_80.Width = 40;
        //    this.dataGridViewTextBoxColumn_81.DataPropertyName = "Iod";
        //    this.dataGridViewTextBoxColumn_81.HeaderText = "0 дн.";
        //    this.dataGridViewTextBoxColumn_81.Name = "dataGridViewTextBoxColumn37";
        //    this.dataGridViewTextBoxColumn_81.Width = 40;
        //    this.dataGridViewTextBoxColumn_82.DataPropertyName = "Ion";
        //    this.dataGridViewTextBoxColumn_82.HeaderText = "0 вч.";
        //    this.dataGridViewTextBoxColumn_82.Name = "dataGridViewTextBoxColumn38";
        //    this.dataGridViewTextBoxColumn_82.Width = 40;
        //    this.dataGridViewTextBoxColumn_83.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    this.dataGridViewTextBoxColumn_83.DataPropertyName = "Comment";
        //    this.dataGridViewTextBoxColumn_83.HeaderText = "Комментарий";
        //    this.dataGridViewTextBoxColumn_83.MinimumWidth = 80;
        //    this.dataGridViewTextBoxColumn_83.Name = "dataGridViewTextBoxColumn39";
        //    this.dataGridViewTextBoxColumn_84.DataPropertyName = "id";
        //    this.dataGridViewTextBoxColumn_84.HeaderText = "id";
        //    this.dataGridViewTextBoxColumn_84.Name = "dataGridViewTextBoxColumn40";
        //    this.dataGridViewTextBoxColumn_84.Visible = false;
        //    this.dataGridViewTextBoxColumn_85.DataPropertyName = "idObjList";
        //    this.dataGridViewTextBoxColumn_85.HeaderText = "idObjList";
        //    this.dataGridViewTextBoxColumn_85.Name = "dataGridViewTextBoxColumn41";
        //    this.dataGridViewTextBoxColumn_85.Visible = false;
        //    this.dataGridViewTextBoxColumn_86.DataPropertyName = "DateD";
        //    this.dataGridViewTextBoxColumn_86.HeaderText = "Дата замера дн.";
        //    this.dataGridViewTextBoxColumn_86.MinimumWidth = 70;
        //    this.dataGridViewTextBoxColumn_86.Name = "dataGridViewTextBoxColumn42";
        //    this.dataGridViewTextBoxColumn_87.DataPropertyName = "TemperatureD";
        //    style27.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    this.dataGridViewTextBoxColumn_87.DefaultCellStyle = style27;
        //    this.dataGridViewTextBoxColumn_87.HeaderText = "Температура дн.";
        //    this.dataGridViewTextBoxColumn_87.MinimumWidth = 70;
        //    this.dataGridViewTextBoxColumn_87.Name = "dataGridViewTextBoxColumn43";
        //    this.dataGridViewTextBoxColumn_88.DataPropertyName = "DateN";
        //    this.dataGridViewTextBoxColumn_88.HeaderText = "Дата замера вч.";
        //    this.dataGridViewTextBoxColumn_88.MinimumWidth = 70;
        //    this.dataGridViewTextBoxColumn_88.Name = "dataGridViewTextBoxColumn44";
        //    this.dataGridViewTextBoxColumn_89.DataPropertyName = "TemperatureN";
        //    style28.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    this.dataGridViewTextBoxColumn_89.DefaultCellStyle = style28;
        //    this.dataGridViewTextBoxColumn_89.HeaderText = "Температура вч.";
        //    this.dataGridViewTextBoxColumn_89.MinimumWidth = 70;
        //    this.dataGridViewTextBoxColumn_89.Name = "dataGridViewTextBoxColumn45";
        //    this.dataGridViewTextBoxColumn_90.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    this.dataGridViewTextBoxColumn_90.DataPropertyName = "Comment";
        //    this.dataGridViewTextBoxColumn_90.HeaderText = "Дополнительно";
        //    this.dataGridViewTextBoxColumn_90.MinimumWidth = 100;
        //    this.dataGridViewTextBoxColumn_90.Name = "dataGridViewTextBoxColumn46";
        //    this.dataGridViewTextBoxColumn_91.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_91.HeaderText = "SumName";
        //    this.dataGridViewTextBoxColumn_91.Name = "dataGridViewTextBoxColumn47";
        //    this.dataGridViewTextBoxColumn_91.Width = 110;
        //    this.dataGridViewTextBoxColumn_92.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_92.HeaderText = "ad";
        //    this.dataGridViewTextBoxColumn_92.Name = "dataGridViewTextBoxColumn48";
        //    this.dataGridViewTextBoxColumn_92.Width = 60;
        //    this.dataGridViewTextBoxColumn_93.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_93.HeaderText = "an";
        //    this.dataGridViewTextBoxColumn_93.Name = "dataGridViewTextBoxColumn49";
        //    this.dataGridViewTextBoxColumn_93.Width = 60;
        //    this.dataGridViewTextBoxColumn_94.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_94.HeaderText = "bd";
        //    this.dataGridViewTextBoxColumn_94.Name = "dataGridViewTextBoxColumn50";
        //    this.dataGridViewTextBoxColumn_94.Width = 60;
        //    this.dataGridViewTextBoxColumn_95.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_95.HeaderText = "bn";
        //    this.dataGridViewTextBoxColumn_95.Name = "dataGridViewTextBoxColumn51";
        //    this.dataGridViewTextBoxColumn_95.Width = 60;
        //    this.dataGridViewTextBoxColumn_96.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_96.HeaderText = "cd";
        //    this.dataGridViewTextBoxColumn_96.Name = "dataGridViewTextBoxColumn52";
        //    this.dataGridViewTextBoxColumn_96.Width = 60;
        //    this.dataGridViewTextBoxColumn_97.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //    this.dataGridViewTextBoxColumn_97.HeaderText = "cn";
        //    this.dataGridViewTextBoxColumn_97.Name = "dataGridViewTextBoxColumn53";
        //    this.dataGridViewTextBoxColumn_97.Width = 60;
        //    this.dataGridViewTextBoxColumn_98.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    this.dataGridViewTextBoxColumn_98.HeaderText = "Comment";
        //    this.dataGridViewTextBoxColumn_98.MinimumWidth = 80;
        //    this.dataGridViewTextBoxColumn_98.Name = "dataGridViewTextBoxColumn54";
        //    this.dataGridViewTextBoxColumn_99.DataPropertyName = "id";
        //    this.dataGridViewTextBoxColumn_99.HeaderText = "id";
        //    this.dataGridViewTextBoxColumn_99.Name = "dataGridViewTextBoxColumn55";
        //    this.dataGridViewTextBoxColumn_99.Visible = false;
        //    this.dataGridViewTextBoxColumn_100.DataPropertyName = "idMeasurement";
        //    this.dataGridViewTextBoxColumn_100.HeaderText = "idMeasurement";
        //    this.dataGridViewTextBoxColumn_100.Name = "dataGridViewTextBoxColumn56";
        //    this.dataGridViewTextBoxColumn_100.Visible = false;
        //    this.dataGridViewTextBoxColumn_101.DataPropertyName = "idBus";
        //    this.dataGridViewTextBoxColumn_101.HeaderText = "idBus";
        //    this.dataGridViewTextBoxColumn_101.Name = "dataGridViewTextBoxColumn57";
        //    this.dataGridViewTextBoxColumn_101.Visible = false;
        //    this.dataGridViewTextBoxColumn_102.DataPropertyName = "NameBus";
        //    this.dataGridViewTextBoxColumn_102.HeaderText = "NameBus";
        //    this.dataGridViewTextBoxColumn_102.Name = "dataGridViewTextBoxColumn58";
        //    this.dataGridViewTextBoxColumn_102.Visible = false;
        //    this.dataGridViewTextBoxColumn_103.DataPropertyName = "NameCell";
        //    this.dataGridViewTextBoxColumn_103.HeaderText = "№ руб.";
        //    this.dataGridViewTextBoxColumn_103.Name = "dataGridViewTextBoxColumn59";
        //    this.dataGridViewTextBoxColumn_103.Width = 30;
        //    this.dataGridViewTextBoxColumn_104.DataPropertyName = "PermissAmperage";
        //    this.dataGridViewTextBoxColumn_104.HeaderText = "Допуст. нагр., А";
        //    this.dataGridViewTextBoxColumn_104.Name = "dataGridViewTextBoxColumn60";
        //    this.dataGridViewTextBoxColumn_104.Width = 80;
        //    this.dataGridViewTextBoxColumn_105.DataPropertyName = "Iad";
        //    this.dataGridViewTextBoxColumn_105.HeaderText = "А дн.";
        //    this.dataGridViewTextBoxColumn_105.Name = "dataGridViewTextBoxColumn61";
        //    this.dataGridViewTextBoxColumn_105.Width = 60;
        //    this.dataGridViewTextBoxColumn_106.DataPropertyName = "Ian";
        //    this.dataGridViewTextBoxColumn_106.HeaderText = "А вч.";
        //    this.dataGridViewTextBoxColumn_106.Name = "dataGridViewTextBoxColumn62";
        //    this.dataGridViewTextBoxColumn_106.Width = 60;
        //    this.dataGridViewTextBoxColumn_107.DataPropertyName = "Ibd";
        //    this.dataGridViewTextBoxColumn_107.HeaderText = "В дн.";
        //    this.dataGridViewTextBoxColumn_107.Name = "dataGridViewTextBoxColumn63";
        //    this.dataGridViewTextBoxColumn_107.Width = 60;
        //    this.dataGridViewTextBoxColumn_108.DataPropertyName = "Ibn";
        //    this.dataGridViewTextBoxColumn_108.HeaderText = "В вч.";
        //    this.dataGridViewTextBoxColumn_108.Name = "dataGridViewTextBoxColumn64";
        //    this.dataGridViewTextBoxColumn_108.Width = 60;
        //    this.dataGridViewTextBoxColumn_109.DataPropertyName = "Icd";
        //    this.dataGridViewTextBoxColumn_109.HeaderText = "С дн.";
        //    this.dataGridViewTextBoxColumn_109.Name = "dataGridViewTextBoxColumn65";
        //    this.dataGridViewTextBoxColumn_109.Width = 60;
        //    this.dataGridViewTextBoxColumn_110.DataPropertyName = "Icn";
        //    this.dataGridViewTextBoxColumn_110.HeaderText = "С вч.";
        //    this.dataGridViewTextBoxColumn_110.Name = "dataGridViewTextBoxColumn66";
        //    this.dataGridViewTextBoxColumn_110.Width = 60;
        //    this.dataGridViewTextBoxColumn_111.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //    this.dataGridViewTextBoxColumn_111.DataPropertyName = "Comment";
        //    this.dataGridViewTextBoxColumn_111.HeaderText = "Комментарий";
        //    this.dataGridViewTextBoxColumn_111.Name = "dataGridViewTextBoxColumn67";
        //    this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
        //    this.dataGridViewTextBoxColumn_0.HeaderText = "id";
        //    this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn2";
        //    this.dataGridViewTextBoxColumn_0.ReadOnly = true;
        //    this.dataGridViewTextBoxColumn_1.DataPropertyName = "idObjList";
        //    this.dataGridViewTextBoxColumn_1.HeaderText = "idObjList";
        //    this.dataGridViewTextBoxColumn_1.Name = "idObjListDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_2.DataPropertyName = "TypeDoc";
        //    this.dataGridViewTextBoxColumn_2.HeaderText = "TypeDoc";
        //    this.dataGridViewTextBoxColumn_2.Name = "typeDocDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_3.DataPropertyName = "Year";
        //    this.dataGridViewTextBoxColumn_3.HeaderText = "Year";
        //    this.dataGridViewTextBoxColumn_3.Name = "yearDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_4.DataPropertyName = "DateD";
        //    this.dataGridViewTextBoxColumn_4.HeaderText = "DateD";
        //    this.dataGridViewTextBoxColumn_4.Name = "dateDDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_5.DataPropertyName = "TemperatureD";
        //    this.dataGridViewTextBoxColumn_5.HeaderText = "TemperatureD";
        //    this.dataGridViewTextBoxColumn_5.Name = "temperatureDDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_6.DataPropertyName = "DateN";
        //    this.dataGridViewTextBoxColumn_6.HeaderText = "DateN";
        //    this.dataGridViewTextBoxColumn_6.Name = "dateNDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_7.DataPropertyName = "TemperatureN";
        //    this.dataGridViewTextBoxColumn_7.HeaderText = "TemperatureN";
        //    this.dataGridViewTextBoxColumn_7.Name = "temperatureNDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_8.DataPropertyName = "idWorker";
        //    this.dataGridViewTextBoxColumn_8.HeaderText = "idWorker";
        //    this.dataGridViewTextBoxColumn_8.Name = "idWorkerDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_9.DataPropertyName = "Comment";
        //    this.dataGridViewTextBoxColumn_9.HeaderText = "Comment";
        //    this.dataGridViewTextBoxColumn_9.Name = "commentDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_10.DataPropertyName = "id";
        //    this.dataGridViewTextBoxColumn_10.HeaderText = "id";
        //    this.dataGridViewTextBoxColumn_10.Name = "idDataGridViewTextBoxColumn3";
        //    this.dataGridViewTextBoxColumn_11.DataPropertyName = "idMeasurement";
        //    this.dataGridViewTextBoxColumn_11.HeaderText = "idMeasurement";
        //    this.dataGridViewTextBoxColumn_11.Name = "idMeasurementDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_12.DataPropertyName = "idTransf";
        //    this.dataGridViewTextBoxColumn_12.HeaderText = "idTransf";
        //    this.dataGridViewTextBoxColumn_12.Name = "idTransfDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_13.DataPropertyName = "idCell";
        //    this.dataGridViewTextBoxColumn_13.HeaderText = "idCell";
        //    this.dataGridViewTextBoxColumn_13.Name = "idCellDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_14.DataPropertyName = "NameCell";
        //    this.dataGridViewTextBoxColumn_14.HeaderText = "NameCell";
        //    this.dataGridViewTextBoxColumn_14.Name = "nameCellDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_15.DataPropertyName = "OldCell";
        //    this.dataGridViewTextBoxColumn_15.HeaderText = "OldCell";
        //    this.dataGridViewTextBoxColumn_15.Name = "oldCellDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_16.DataPropertyName = "idCable";
        //    this.dataGridViewTextBoxColumn_16.HeaderText = "idCable";
        //    this.dataGridViewTextBoxColumn_16.Name = "idCableDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_17.DataPropertyName = "idSchmAbn";
        //    this.dataGridViewTextBoxColumn_17.HeaderText = "idSchmAbn";
        //    this.dataGridViewTextBoxColumn_17.Name = "idSchmAbnDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_18.DataPropertyName = "Makeup";
        //    this.dataGridViewTextBoxColumn_18.HeaderText = "Makeup";
        //    this.dataGridViewTextBoxColumn_18.Name = "makeupDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_19.DataPropertyName = "Voltage";
        //    this.dataGridViewTextBoxColumn_19.HeaderText = "Voltage";
        //    this.dataGridViewTextBoxColumn_19.Name = "voltageDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_20.DataPropertyName = "Wires";
        //    this.dataGridViewTextBoxColumn_20.HeaderText = "Wires";
        //    this.dataGridViewTextBoxColumn_20.Name = "wiresDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_21.DataPropertyName = "CrossSection";
        //    this.dataGridViewTextBoxColumn_21.HeaderText = "CrossSection";
        //    this.dataGridViewTextBoxColumn_21.Name = "crossSectionDataGridViewTextBoxColumn1";
        //    this.dataGridViewTextBoxColumn_22.DataPropertyName = "PermisAmperage";
        //    this.dataGridViewTextBoxColumn_22.HeaderText = "PermisAmperage";
        //    this.dataGridViewTextBoxColumn_22.Name = "permisAmperageDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_23.DataPropertyName = "Iad";
        //    this.dataGridViewTextBoxColumn_23.HeaderText = "Iad";
        //    this.dataGridViewTextBoxColumn_23.Name = "iadDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_24.DataPropertyName = "Ian";
        //    this.dataGridViewTextBoxColumn_24.HeaderText = "Ian";
        //    this.dataGridViewTextBoxColumn_24.Name = "ianDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_25.DataPropertyName = "Ibd";
        //    this.dataGridViewTextBoxColumn_25.HeaderText = "Ibd";
        //    this.dataGridViewTextBoxColumn_25.Name = "ibdDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_26.DataPropertyName = "Ibn";
        //    this.dataGridViewTextBoxColumn_26.HeaderText = "Ibn";
        //    this.dataGridViewTextBoxColumn_26.Name = "ibnDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_27.DataPropertyName = "Icd";
        //    this.dataGridViewTextBoxColumn_27.HeaderText = "Icd";
        //    this.dataGridViewTextBoxColumn_27.Name = "icdDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_28.DataPropertyName = "Icn";
        //    this.dataGridViewTextBoxColumn_28.HeaderText = "Icn";
        //    this.dataGridViewTextBoxColumn_28.Name = "icnDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_29.DataPropertyName = "Iod";
        //    this.dataGridViewTextBoxColumn_29.HeaderText = "Iod";
        //    this.dataGridViewTextBoxColumn_29.Name = "iodDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_30.DataPropertyName = "Ion";
        //    this.dataGridViewTextBoxColumn_30.HeaderText = "Ion";
        //    this.dataGridViewTextBoxColumn_30.Name = "ionDataGridViewTextBoxColumn";
        //    this.dataGridViewTextBoxColumn_31.DataPropertyName = "Comment";
        //    this.dataGridViewTextBoxColumn_31.HeaderText = "Comment";
        //    this.dataGridViewTextBoxColumn_31.Name = "commentDataGridViewTextBoxColumn2";
        //    this.bindingSource_18.DataMember = "vJ_BusesTransfSchema";
        //    this.bindingSource_18.DataSource = this.dsJournal;
        //    base.AutoScaleDimensions = new SizeF(6f, 13f);
        //    base.AutoScaleMode = AutoScaleMode.Font;
        //    base.ClientSize = new Size(0x40a, 0x232);
        //    base.Controls.Add(this.tableLayoutPanel_2);
        //    this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //    base.Icon = (Icon)resources.GetObject("$this.Icon");
        //    base.Name = "FormMeasurement";
        //    base.StartPosition = FormStartPosition.CenterScreen;
        //    this.Text = "Листок замеров";
        //    base.Load += new EventHandler(this.FormMeasurement_Load);
        //    base.Shown += new EventHandler(this.FormMeasurement_Shown);
        //    this.tableLayoutPanel_0.ResumeLayout(false);
        //    this.tableLayoutPanel_0.PerformLayout();
        //    this.toolStrip_0.ResumeLayout(false);
        //    this.toolStrip_0.PerformLayout();
        //    this.tableLayoutPanel_1.ResumeLayout(false);
        //    this.tableLayoutPanel_1.PerformLayout();
        //    this.toolStrip_1.ResumeLayout(false);
        //    this.toolStrip_1.PerformLayout();
        //    this.tableLayoutPanel_3.ResumeLayout(false);
        //    ((ISupportInitialize)this.bsBusesTransfs).EndInit();
        //    this.dsJournal.EndInit();
        //    this.tabControl_0.ResumeLayout(false);
        //    this.tabPage_0.ResumeLayout(false);
        //    this.tabPage_0.PerformLayout();
        //    this.tabPage_1.ResumeLayout(false);
        //    ((ISupportInitialize)this.dataGridView_0).EndInit();
        //    ((ISupportInitialize)this.bindingSource_8).EndInit();
        //    this.panel_0.ResumeLayout(false);
        //    this.panel_1.ResumeLayout(false);
        //    this.panel_1.PerformLayout();
        //    ((ISupportInitialize)this.bindingSource_0).EndInit();
        //    this.panel_2.ResumeLayout(false);
        //    ((ISupportInitialize)this.bindingSource_1).EndInit();
        //    ((ISupportInitialize)this.bindingSource_12).EndInit();
        //    this.panel_3.ResumeLayout(false);
        //    this.panel_3.PerformLayout();
        //    this.panel_4.ResumeLayout(false);
        //    this.panel_4.PerformLayout();
        //    this.panel_5.ResumeLayout(false);
        //    this.panel_5.PerformLayout();
        //    ((ISupportInitialize)this.dataGridView_1).EndInit();
        //    this.panel_6.ResumeLayout(false);
        //    this.panel_7.ResumeLayout(false);
        //    this.panel_7.PerformLayout();
        //    this.panel_9.ResumeLayout(false);
        //    this.panel_9.PerformLayout();
        //    this.panel_10.ResumeLayout(false);
        //    this.panel_10.PerformLayout();
        //    this.panel_11.ResumeLayout(false);
        //    this.panel_11.PerformLayout();
        //    this.panel_12.ResumeLayout(false);
        //    this.panel_12.PerformLayout();
        //    this.panel_13.ResumeLayout(false);
        //    this.panel_13.PerformLayout();
        //    ((ISupportInitialize)this.dataGridView_2).EndInit();
        //    ((ISupportInitialize)this.bindingSource_7).EndInit();
        //    ((ISupportInitialize)this.dataGridView_3).EndInit();
        //    ((ISupportInitialize)this.bindingSource_10).EndInit();
        //    ((ISupportInitialize)this.bindingSource_19).EndInit();
        //    ((ISupportInitialize)this.bindingSource_9).EndInit();
        //    this.tableLayoutPanel_4.ResumeLayout(false);
        //    this.tableLayoutPanel_4.PerformLayout();
        //    this.panel_14.ResumeLayout(false);
        //    this.panel_15.ResumeLayout(false);
        //    this.panel_15.PerformLayout();
        //    this.panel_16.ResumeLayout(false);
        //    this.panel_16.PerformLayout();
        //    this.panel_17.ResumeLayout(false);
        //    this.panel_17.PerformLayout();
        //    this.panel_18.ResumeLayout(false);
        //    this.panel_18.PerformLayout();
        //    this.panel_19.ResumeLayout(false);
        //    this.panel_20.ResumeLayout(false);
        //    this.panel_21.ResumeLayout(false);
        //    this.panel_22.ResumeLayout(false);
        //    this.panel_23.ResumeLayout(false);
        //    this.panel_23.PerformLayout();
        //    ((ISupportInitialize)this.bindingSource_11).EndInit();
        //    this.panel_24.ResumeLayout(false);
        //    this.panel_24.PerformLayout();
        //    this.panel_25.ResumeLayout(false);
        //    this.panel_25.PerformLayout();
        //    ((ISupportInitialize)this.dataGridView_4).EndInit();
        //    ((ISupportInitialize)this.dataGridView_5).EndInit();
        //    ((ISupportInitialize)this.bindingSource_16).EndInit();
        //    ((ISupportInitialize)this.bindingSource_15).EndInit();
        //    this.tableLayoutPanel_2.ResumeLayout(false);
        //    ((ISupportInitialize)this.bindingSource_3).EndInit();
        //    ((ISupportInitialize)this.bindingSource_4).EndInit();
        //    ((ISupportInitialize)this.bindingSource_5).EndInit();
        //    ((ISupportInitialize)this.bindingSource_6).EndInit();
        //    ((ISupportInitialize)this.bindingSource_2).EndInit();
        //    ((ISupportInitialize)this.bindingSource_13).EndInit();
        //    ((ISupportInitialize)this.bindingSource_14).EndInit();
        //    ((ISupportInitialize)this.bindingSource_18).EndInit();
        //    base.ResumeLayout(false);
        //}
        //private DataSetGES dsJournal;
        //private Button button_0;
        //private ComboBox comboBox_0;
        //private ComboBox comboBox_1;
        //private ComboBox comboBox_2;
        //private DataGridView dataGridView_0;
        //private DataGridView dataGridView_1;
        //private DataGridView dataGridView_2;
        //private DataGridView dataGridView_3;
        //private DataGridView dataGridView_4;
        //private DataGridView dataGridView_5;
        //private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        //private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;
        //private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;
        //private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3;
        //private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_4;
        //private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
        //private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_100;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_101;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_102;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_103;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_104;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_105;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_106;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_107;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_108;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_109;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_110;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_111;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_112;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_113;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_114;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_115;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_116;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_117;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_118;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_119;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_120;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_121;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_122;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_123;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_124;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_125;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_126;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_127;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_128;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_129;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_130;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_131;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_132;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_133;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_134;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_135;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_136;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_137;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_138;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_139;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_140;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_141;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_142;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_143;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_144;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_145;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_146;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_147;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_148;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_149;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_150;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_151;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_152;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_153;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_154;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_155;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_156;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_64;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_65;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_66;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_67;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_68;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_69;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_70;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_71;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_72;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_73;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_74;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_75;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_76;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_77;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_78;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_79;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_80;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_81;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_82;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_83;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_84;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_85;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_86;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_87;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_88;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_89;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_90;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_91;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_92;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_93;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_94;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_95;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_96;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_97;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_98;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_99;

        //private BindingSource bindingSource_0;
        //private BindingSource bindingSource_1;
        //private BindingSource bindingSource_10;
        //private BindingSource bindingSource_11;
        //private BindingSource bindingSource_12;
        //private BindingSource bindingSource_13;
        //private BindingSource bindingSource_14;
        //private BindingSource bindingSource_15;
        //private BindingSource bindingSource_16;
        //private BindingSource bsBusesTransfs;
        //private BindingSource bindingSource_18;
        //private BindingSource bindingSource_19;
        //private BindingSource bindingSource_2;
        //private BindingSource bindingSource_3;
        //private BindingSource bindingSource_4;
        //private BindingSource bindingSource_5;
        //private BindingSource bindingSource_6;
        //private BindingSource bindingSource_7;
        //private BindingSource bindingSource_8;
        //private BindingSource bindingSource_9;
        //private Label label_0;
        //private Label label_1;
        //private Label label_10;
        //private Label label_11;
        //private Label label_12;
        //private Label label_13;
        //private Label label_14;
        //private Label label_15;
        //private Label label_16;
        //private Label label_17;
        //private Label label_18;
        //private Label label_19;
        //private Label label_2;
        //private Label label_20;
        //private Label label_21;
        //private Label label_22;
        //private Label label_23;
        //private Label label_24;
        //private Label label_25;
        //private Label label_26;
        //private Label label_27;
        //private Label label_28;
        //private Label label_29;
        //private Label label_3;
        //private Label label_30;
        //private Label label_31;
        //private Label label_32;
        //private Label label_33;
        //private Label label_34;
        //private Label label_4;
        //private Label label_5;
        //private Label label_6;
        //private Label label_7;
        //private Label label_8;
        //private Label label_9;
        //private Panel panel_0;
        //private Panel panel_1;
        //private Panel panel_10;
        //private Panel panel_11;
        //private Panel panel_12;
        //private Panel panel_13;
        //private Panel panel_14;
        //private Panel panel_15;
        //private Panel panel_16;
        //private Panel panel_17;
        //private Panel panel_18;
        //private Panel panel_19;
        //private Panel panel_2;
        //private Panel panel_20;
        //private Panel panel_21;
        //private Panel panel_22;
        //private Panel panel_23;
        //private Panel panel_24;
        //private Panel panel_25;
        //private Panel panel_3;
        //private Panel panel_4;
        //private Panel panel_5;
        //private Panel panel_6;
        //private Panel panel_7;
        //private Panel panel_8;
        //private Panel panel_9;
        //private TabControl tabControl_0;
        //private TableLayoutPanel tableLayoutPanel_0;
        //private TableLayoutPanel tableLayoutPanel_1;
        //private TableLayoutPanel tableLayoutPanel_2;
        //private TableLayoutPanel tableLayoutPanel_3;
        //private TableLayoutPanel tableLayoutPanel_4;
        //private TabPage tabPage_0;
        //private TabPage tabPage_1;
        //private TextBox textBox_0;
        //private TextBox textBox_1;
        //private TextBox textBox_10;
        //private TextBox textBox_11;
        //private TextBox textBox_12;
        //private TextBox textBox_13;
        //private TextBox textBox_14;
        //private TextBox textBox_15;
        //private TextBox textBox_16;
        //private TextBox textBox_17;
        //private TextBox textBox_18;
        //private TextBox textBox_19;
        //private TextBox tbKNTn;
        //private TextBox textBox_20;
        //private TextBox textBox_21;
        //private TextBox textBox_22;
        //private TextBox textBox_23;
        //private TextBox textBox_24;
        //private TextBox textBox_25;
        //private TextBox textBox_26;
        //private TextBox textBox_27;
        //private TextBox textBox_28;
        //private TextBox textBox_29;
        //private TextBox tbKNTd;
        //private TextBox textBox_30;
        //private TextBox tbIsrn;
        //private TextBox tbIsrd;
        //private TextBox textBox_6;
        //private TextBox textBox_7;
        //private TextBox tbTransAmperage;
        //private TextBox textBox_9;
        //private ToolStrip toolStrip_0;
        //private ToolStrip toolStrip_1;
        //private ToolStripButton toolStripButton_0;
        //private ToolStripButton toolStripButton_1;
        //private ToolStripButton toolStripButton_2;
        //private ToolStripButton toolStripButton_3;
        //private ToolStripButton toolStripButton_4;
        //private ToolStripButton toolStripButton_5;
        //private ToolStripButton toolStripButton_6;
        //private ToolStripButton toolStripButton_7;
        //private ToolStripButton toolStripButton_8;
        //private ToolStripButton toolStripButton_9;
        //private ToolStripComboBox toolStripComboBox_0;
        //private ToolStripLabel toolStripLabel_0;
        //private ToolStripMenuItem toolStripMenuItem_0;
        //private ToolStripMenuItem toolStripMenuItem_1;
        //private ToolStripMenuItem toolStripMenuItem_2;
        //private ToolStripMenuItem toolStripMenuItem_3;
        //private ToolStripMenuItem toolStripMenuItem_4;
        //private ToolStripMenuItem toolStripMenuItem_5;
        //private ToolStripMenuItem toolStripMenuItem_6;
        //private ToolStripMenuItem toolStripMenuItem_7;
        //private ToolStripSeparator toolStripSeparator_0;
        //private ToolStripSeparator toolStripSeparator_1;
        //private ToolStripSeparator toolStripSeparator_2;
        //private ToolStripSeparator toolStripSeparator_3;
        //private ToolStripSeparator toolStripSeparator_4;
        //private ToolStripSplitButton toolStripSplitButton_0;
        //private ToolStripSplitButton toolStripSplitButton_1;
        //private ToolStripTextBox toolStripTextBox_0;
        //private TreeView treeView_0;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeasurement));
            this.tableLayoutPanel_0 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.toolStrip_0 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox_0 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton_0 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_0 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_2 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel_1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip_1 = new System.Windows.Forms.ToolStrip();
            this.tssbMeasAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbMeasEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbMeasDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_4 = new System.Windows.Forms.ToolStripSeparator();
            this.tssbMeasType = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiMeasLow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMeasHigh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_0 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxtoolStripComboBoxMeasYear = new System.Windows.Forms.ToolStripComboBox();
            this.tssbReports = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiExcessLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCoefficientLoading = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCoefficientIrregularity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTransfByCP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVolumeFreeEnergy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMeasExist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton_8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonhelp = new System.Windows.Forms.ToolStripButton();
            this.button_0 = new System.Windows.Forms.Button();
            this.tlpMeasurementLow = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxBusesTransfs = new System.Windows.Forms.ComboBox();
            this.bsBusesTransfs = new System.Windows.Forms.BindingSource(this.components);
            this.dsJournal = new DataSetMeasurementN();
            this.labelTrans = new System.Windows.Forms.Label();
            this.tcMeasurement = new System.Windows.Forms.TabControl();
            this.tpRatio = new System.Windows.Forms.TabPage();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.label_6 = new System.Windows.Forms.Label();
            this.tbKNKFn = new System.Windows.Forms.TextBox();
            this.tbKNKFd = new System.Windows.Forms.TextBox();
            this.tbKNTn = new System.Windows.Forms.TextBox();
            this.tbKNTd = new System.Windows.Forms.TextBox();
            this.tbIsrn = new System.Windows.Forms.TextBox();
            this.tbIsrd = new System.Windows.Forms.TextBox();
            this.tpAddress = new System.Windows.Forms.TabPage();
            this.dgvAbnObj = new System.Windows.Forms.DataGridView();
            this.idSchmObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMeasAbnObj = new System.Windows.Forms.BindingSource(this.components);
            this.panel_0 = new System.Windows.Forms.Panel();
            this.label_7 = new System.Windows.Forms.Label();
            this.label_8 = new System.Windows.Forms.Label();
            this.label_9 = new System.Windows.Forms.Label();
            this.label_10 = new System.Windows.Forms.Label();
            this.label_11 = new System.Windows.Forms.Label();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.textBox_6 = new System.Windows.Forms.TextBox();
            this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_7 = new System.Windows.Forms.TextBox();
            this.label_12 = new System.Windows.Forms.Label();
            this.label_13 = new System.Windows.Forms.Label();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.cbSwitchPosition = new System.Windows.Forms.ComboBox();
            this.bindingSource_1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_12 = new System.Windows.Forms.BindingSource(this.components);
            this.panel_3 = new System.Windows.Forms.Panel();
            this.tbTransAmperage = new System.Windows.Forms.TextBox();
            this.panel_4 = new System.Windows.Forms.Panel();
            this.textBox_9 = new System.Windows.Forms.TextBox();
            this.panel_5 = new System.Windows.Forms.Panel();
            this.textBox_10 = new System.Windows.Forms.TextBox();
            this.dgvSumCable = new System.Windows.Forms.DataGridView();
            this.SumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.an = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.od = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_6 = new System.Windows.Forms.Panel();
            this.panel_7 = new System.Windows.Forms.Panel();
            this.label_14 = new System.Windows.Forms.Label();
            this.panel_8 = new System.Windows.Forms.Panel();
            this.panel_9 = new System.Windows.Forms.Panel();
            this.label_15 = new System.Windows.Forms.Label();
            this.label_16 = new System.Windows.Forms.Label();
            this.label_17 = new System.Windows.Forms.Label();
            this.panel_10 = new System.Windows.Forms.Panel();
            this.textBox_11 = new System.Windows.Forms.TextBox();
            this.textBox_12 = new System.Windows.Forms.TextBox();
            this.textBox_13 = new System.Windows.Forms.TextBox();
            this.textBox_14 = new System.Windows.Forms.TextBox();
            this.textBox_15 = new System.Windows.Forms.TextBox();
            this.textBox_16 = new System.Windows.Forms.TextBox();
            this.panel_11 = new System.Windows.Forms.Panel();
            this.label_18 = new System.Windows.Forms.Label();
            this.label_19 = new System.Windows.Forms.Label();
            this.label_20 = new System.Windows.Forms.Label();
            this.panel_12 = new System.Windows.Forms.Panel();
            this.textBox_17 = new System.Windows.Forms.TextBox();
            this.textBox_18 = new System.Windows.Forms.TextBox();
            this.textBox_19 = new System.Windows.Forms.TextBox();
            this.textBox_20 = new System.Windows.Forms.TextBox();
            this.textBox_21 = new System.Windows.Forms.TextBox();
            this.textBox_22 = new System.Windows.Forms.TextBox();
            this.panel_13 = new System.Windows.Forms.Panel();
            this.label_21 = new System.Windows.Forms.Label();
            this.label_22 = new System.Windows.Forms.Label();
            this.dgvMeasCable = new System.Windows.Forms.DataGridView();
            this.Deleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NameCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OldCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSchmAbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Makeup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voltage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrossSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermisAmperage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ibd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ibn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMeasCable = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMeasurement = new System.Windows.Forms.DataGridView();
            this.idWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsWorker = new System.Windows.Forms.BindingSource(this.components);
            this.idWorkerCheck = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsDispatcher = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObjListDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOldMeasurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsMeasurement = new System.Windows.Forms.BindingSource(this.components);
            this.tlpMeasurementHigh = new System.Windows.Forms.TableLayoutPanel();
            this.panel_14 = new System.Windows.Forms.Panel();
            this.label_24 = new System.Windows.Forms.Label();
            this.label_25 = new System.Windows.Forms.Label();
            this.label_26 = new System.Windows.Forms.Label();
            this.label_27 = new System.Windows.Forms.Label();
            this.panel_15 = new System.Windows.Forms.Panel();
            this.textBox_23 = new System.Windows.Forms.TextBox();
            this.textBox_24 = new System.Windows.Forms.TextBox();
            this.label_28 = new System.Windows.Forms.Label();
            this.label_29 = new System.Windows.Forms.Label();
            this.panel_16 = new System.Windows.Forms.Panel();
            this.textBox_25 = new System.Windows.Forms.TextBox();
            this.panel_17 = new System.Windows.Forms.Panel();
            this.textBox_26 = new System.Windows.Forms.TextBox();
            this.panel_18 = new System.Windows.Forms.Panel();
            this.textBox_27 = new System.Windows.Forms.TextBox();
            this.panel_19 = new System.Windows.Forms.Panel();
            this.panel_20 = new System.Windows.Forms.Panel();
            this.label_31 = new System.Windows.Forms.Label();
            this.panel_21 = new System.Windows.Forms.Panel();
            this.label_32 = new System.Windows.Forms.Label();
            this.panel_22 = new System.Windows.Forms.Panel();
            this.label_33 = new System.Windows.Forms.Label();
            this.panel_23 = new System.Windows.Forms.Panel();
            this.textBox_28 = new System.Windows.Forms.TextBox();
            this.bsMeasAmperageTransf = new System.Windows.Forms.BindingSource(this.components);
            this.panel_24 = new System.Windows.Forms.Panel();
            this.textBox_29 = new System.Windows.Forms.TextBox();
            this.label_34 = new System.Windows.Forms.Label();
            this.panel_25 = new System.Windows.Forms.Panel();
            this.textBox_30 = new System.Windows.Forms.TextBox();
            this.dgvSumCell = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMeasCell = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMeasurementDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTransfDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCellDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisAmperageDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iadDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ianDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibnDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icnDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iodDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsMeasCell = new System.Windows.Forms.BindingSource(this.components);
            this.label_23 = new System.Windows.Forms.Label();
            this.comboBox_2 = new System.Windows.Forms.ComboBox();
            this.lbTransfName = new System.Windows.Forms.Label();
            this.idBus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTransf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTransf = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel_2 = new System.Windows.Forms.TableLayoutPanel();
            this.deletedDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deletedDataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsCellByTransf = new System.Windows.Forms.BindingSource(this.components);
            this.bsCableMakeup = new System.Windows.Forms.BindingSource(this.components);
            this.bsVoltage = new System.Windows.Forms.BindingSource(this.components);
            this.bsCrossSection = new System.Windows.Forms.BindingSource(this.components);
            this.bsValueLists = new System.Windows.Forms.BindingSource(this.components);
            this.bsTypeDoc = new System.Windows.Forms.BindingSource(this.components);
            this.bsMeasYear = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObjListDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMeasurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTransfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCellDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldCellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCableDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSchmAbnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeupDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wiresDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crossSectionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisAmperageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_18 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel_0.SuspendLayout();
            this.toolStrip_0.SuspendLayout();
            this.tableLayoutPanel_1.SuspendLayout();
            this.toolStrip_1.SuspendLayout();
            this.tlpMeasurementLow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBusesTransfs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJournal)).BeginInit();
            this.tcMeasurement.SuspendLayout();
            this.tpRatio.SuspendLayout();
            this.tpAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbnObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasAbnObj)).BeginInit();
            this.panel_0.SuspendLayout();
            this.panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_0)).BeginInit();
            this.panel_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_12)).BeginInit();
            this.panel_3.SuspendLayout();
            this.panel_4.SuspendLayout();
            this.panel_5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumCable)).BeginInit();
            this.panel_6.SuspendLayout();
            this.panel_7.SuspendLayout();
            this.panel_9.SuspendLayout();
            this.panel_10.SuspendLayout();
            this.panel_11.SuspendLayout();
            this.panel_12.SuspendLayout();
            this.panel_13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasCable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasCable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDispatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurement)).BeginInit();
            this.tlpMeasurementHigh.SuspendLayout();
            this.panel_14.SuspendLayout();
            this.panel_15.SuspendLayout();
            this.panel_16.SuspendLayout();
            this.panel_17.SuspendLayout();
            this.panel_18.SuspendLayout();
            this.panel_19.SuspendLayout();
            this.panel_20.SuspendLayout();
            this.panel_21.SuspendLayout();
            this.panel_22.SuspendLayout();
            this.panel_23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasAmperageTransf)).BeginInit();
            this.panel_24.SuspendLayout();
            this.panel_25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransf)).BeginInit();
            this.tableLayoutPanel_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCellByTransf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCableMakeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCrossSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsValueLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypeDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_18)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_0
            // 
            this.tableLayoutPanel_0.ColumnCount = 1;
            this.tableLayoutPanel_0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_0.Controls.Add(this.treeView, 0, 1);
            this.tableLayoutPanel_0.Controls.Add(this.toolStrip_0, 0, 0);
            this.tableLayoutPanel_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_0.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_0.Name = "tableLayoutPanel_0";
            this.tableLayoutPanel_0.RowCount = 2;
            this.tableLayoutPanel_0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_0.Size = new System.Drawing.Size(206, 556);
            this.tableLayoutPanel_0.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.HideSelection = false;
            this.treeView.Location = new System.Drawing.Point(3, 28);
            this.treeView.MinimumSize = new System.Drawing.Size(200, 4);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(200, 525);
            this.treeView.TabIndex = 6;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeExpand);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // toolStrip_0
            // 
            this.toolStrip_0.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_0,
            this.toolStripButton_0,
            this.toolStripButton_1,
            this.toolStripSeparator_0,
            this.toolStripButton_2});
            this.toolStrip_0.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_0.Name = "toolStrip_0";
            this.toolStrip_0.Size = new System.Drawing.Size(206, 25);
            this.toolStrip_0.TabIndex = 5;
            this.toolStrip_0.Text = "Панель инструментов дерева данных";
            // 
            // toolStripTextBox_0
            // 
            this.toolStripTextBox_0.Name = "toolStripTextBox_0";
            this.toolStripTextBox_0.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox_KeyPress);
            // 
            // toolStripButton_0
            // 
            this.toolStripButton_0.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = global::Measurement.Properties.Resources.FindObj;
            this.toolStripButton_0.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_0.Name = "toolStripButton_0";
            this.toolStripButton_0.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_0.Text = "Найти";
            this.toolStripButton_0.Click += new System.EventHandler(this.toolStripButton_0_Click);
            // 
            // toolStripButton_1
            // 
            this.toolStripButton_1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = global::Measurement.Properties.Resources.FindNextObj;
            this.toolStripButton_1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_1.Name = "toolStripButton_1";
            this.toolStripButton_1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_1.Text = "Найти далее";
            this.toolStripButton_1.Click += new System.EventHandler(this.toolStripButton_1_Click);
            // 
            // toolStripSeparator_0
            // 
            this.toolStripSeparator_0.Name = "toolStripSeparator_0";
            this.toolStripSeparator_0.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_2
            // 
            this.toolStripButton_2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = global::Measurement.Properties.Resources.Sort;
            this.toolStripButton_2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_2.Name = "toolStripButton_2";
            this.toolStripButton_2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_2.Text = "Сортировка";
            this.toolStripButton_2.Click += new System.EventHandler(this.tsbSortTree_Click);
            // 
            // tableLayoutPanel_1
            // 
            this.tableLayoutPanel_1.ColumnCount = 3;
            this.tableLayoutPanel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel_1.Controls.Add(this.toolStrip_1, 0, 0);
            this.tableLayoutPanel_1.Controls.Add(this.button_0, 1, 4);
            this.tableLayoutPanel_1.Controls.Add(this.tlpMeasurementLow, 1, 2);
            this.tableLayoutPanel_1.Controls.Add(this.dgvMeasurement, 1, 1);
            this.tableLayoutPanel_1.Controls.Add(this.tlpMeasurementHigh, 1, 3);
            this.tableLayoutPanel_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_1.Location = new System.Drawing.Point(215, 3);
            this.tableLayoutPanel_1.Name = "tableLayoutPanel_1";
            this.tableLayoutPanel_1.RowCount = 5;
            this.tableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel_1.Size = new System.Drawing.Size(816, 556);
            this.tableLayoutPanel_1.TabIndex = 0;
            // 
            // toolStrip_1
            // 
            this.tableLayoutPanel_1.SetColumnSpan(this.toolStrip_1, 3);
            this.toolStrip_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbMeasAdd,
            this.tsbMeasEdit,
            this.tsbMeasDelete,
            this.toolStripSeparator_1,
            this.toolStripButton_6,
            this.toolStripSeparator_3,
            this.tsbPrint,
            this.toolStripSeparator_4,
            this.tssbMeasType,
            this.toolStripSeparator_2,
            this.toolStripLabel_0,
            this.toolStripComboBoxtoolStripComboBoxMeasYear,
            this.tssbReports,
            this.toolStripButton_8,
            this.toolStripButtonhelp});
            this.toolStrip_1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_1.Name = "toolStrip_1";
            this.toolStrip_1.Size = new System.Drawing.Size(816, 25);
            this.toolStrip_1.TabIndex = 1;
            this.toolStrip_1.Text = "toolStrip1";
            // 
            // tssbMeasAdd
            // 
            this.tssbMeasAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbMeasAdd.Image = global::Measurement.Properties.Resources.Add;
            this.tssbMeasAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbMeasAdd.Name = "tssbMeasAdd";
            this.tssbMeasAdd.Size = new System.Drawing.Size(23, 22);
            this.tssbMeasAdd.Text = "Добавить";
            this.tssbMeasAdd.Click += new System.EventHandler(this.tsbMeasAdd_Click);
            // 
            // tsbMeasEdit
            // 
            this.tsbMeasEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMeasEdit.Image = global::Measurement.Properties.Resources.Edit;
            this.tsbMeasEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMeasEdit.Name = "tsbMeasEdit";
            this.tsbMeasEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbMeasEdit.Text = "Редактировать";
            this.tsbMeasEdit.Click += new System.EventHandler(this.tsbMeasEdit_Click);
            // 
            // tsbMeasDelete
            // 
            this.tsbMeasDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMeasDelete.Image = global::Measurement.Properties.Resources.Delete;
            this.tsbMeasDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMeasDelete.Name = "tsbMeasDelete";
            this.tsbMeasDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbMeasDelete.Text = "Удалить";
            this.tsbMeasDelete.Click += new System.EventHandler(this.tsbMeasDelete_Click);
            // 
            // toolStripSeparator_1
            // 
            this.toolStripSeparator_1.Name = "toolStripSeparator_1";
            this.toolStripSeparator_1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_6
            // 
            this.toolStripButton_6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_6.Image = global::Measurement.Properties.Resources.Refresh;
            this.toolStripButton_6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_6.Name = "toolStripButton_6";
            this.toolStripButton_6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_6.Text = "Обновить";
            this.toolStripButton_6.Click += new System.EventHandler(this.tsbMeasRefresh_Click);
            // 
            // toolStripSeparator_3
            // 
            this.toolStripSeparator_3.Name = "toolStripSeparator_3";
            this.toolStripSeparator_3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Image = global::Measurement.Properties.Resources.Print;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(23, 22);
            this.tsbPrint.Text = "Печать листка замеров";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // toolStripSeparator_4
            // 
            this.toolStripSeparator_4.Name = "toolStripSeparator_4";
            this.toolStripSeparator_4.Size = new System.Drawing.Size(6, 25);
            // 
            // tssbMeasType
            // 
            this.tssbMeasType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssbMeasType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMeasLow,
            this.tsmiMeasHigh});
            this.tssbMeasType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbMeasType.Name = "tssbMeasType";
            this.tssbMeasType.Size = new System.Drawing.Size(58, 22);
            this.tssbMeasType.Text = "Замер";
            // 
            // tsmiMeasLow
            // 
            this.tsmiMeasLow.CheckOnClick = true;
            this.tsmiMeasLow.Name = "tsmiMeasLow";
            this.tsmiMeasLow.Size = new System.Drawing.Size(113, 22);
            this.tsmiMeasLow.Text = "0,4 кВ";
            this.tsmiMeasLow.CheckedChanged += new System.EventHandler(this.tsmiMeas_CheckedChanged);
            // 
            // tsmiMeasHigh
            // 
            this.tsmiMeasHigh.CheckOnClick = true;
            this.tsmiMeasHigh.Name = "tsmiMeasHigh";
            this.tsmiMeasHigh.Size = new System.Drawing.Size(113, 22);
            this.tsmiMeasHigh.Text = "6-10 кВ";
            this.tsmiMeasHigh.CheckedChanged += new System.EventHandler(this.tsmiMeas_CheckedChanged);
            // 
            // toolStripSeparator_2
            // 
            this.toolStripSeparator_2.Name = "toolStripSeparator_2";
            this.toolStripSeparator_2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_0
            // 
            this.toolStripLabel_0.Name = "toolStripLabel_0";
            this.toolStripLabel_0.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel_0.Text = "Период: ";
            // 
            // toolStripComboBoxtoolStripComboBoxMeasYear
            // 
            this.toolStripComboBoxtoolStripComboBoxMeasYear.Name = "toolStripComboBoxtoolStripComboBoxMeasYear";
            this.toolStripComboBoxtoolStripComboBoxMeasYear.Size = new System.Drawing.Size(80, 25);
            // 
            // tssbReports
            // 
            this.tssbReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExcessLoad,
            this.tsmiCoefficientLoading,
            this.tsmiCoefficientIrregularity,
            this.tsmiTransfByCP,
            this.toolStripMenuItemVolumeFreeEnergy,
            this.toolStripMenuItemMeasExist});
            this.tssbReports.Image = global::Measurement.Properties.Resources.Report;
            this.tssbReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbReports.Name = "tssbReports";
            this.tssbReports.Size = new System.Drawing.Size(32, 22);
            this.tssbReports.Text = "Отчеты";
            // 
            // tsmiExcessLoad
            // 
            this.tsmiExcessLoad.Name = "tsmiExcessLoad";
            this.tsmiExcessLoad.Size = new System.Drawing.Size(254, 22);
            this.tsmiExcessLoad.Text = "Превышение нагрузки";
            this.tsmiExcessLoad.Click += new System.EventHandler(this.tsmiExcessLoad_Click);
            // 
            // tsmiCoefficientLoading
            // 
            this.tsmiCoefficientLoading.Name = "tsmiCoefficientLoading";
            this.tsmiCoefficientLoading.Size = new System.Drawing.Size(254, 22);
            this.tsmiCoefficientLoading.Text = "Коэффициент загрузки";
            this.tsmiCoefficientLoading.Click += new System.EventHandler(this.tsmiCoefficientLoading_Click);
            // 
            // tsmiCoefficientIrregularity
            // 
            this.tsmiCoefficientIrregularity.Name = "tsmiCoefficientIrregularity";
            this.tsmiCoefficientIrregularity.Size = new System.Drawing.Size(254, 22);
            this.tsmiCoefficientIrregularity.Text = "Коэффициент неравномерности";
            this.tsmiCoefficientIrregularity.Click += new System.EventHandler(this.tsmiCoefficientIrregularity_Click);
            // 
            // tsmiTransfByCP
            // 
            this.tsmiTransfByCP.Name = "tsmiTransfByCP";
            this.tsmiTransfByCP.Size = new System.Drawing.Size(254, 22);
            this.tsmiTransfByCP.Text = "Трансформаторы по ЦП";
            this.tsmiTransfByCP.Visible = false;
            // 
            // toolStripMenuItemVolumeFreeEnergy
            // 
            this.toolStripMenuItemVolumeFreeEnergy.Name = "toolStripMenuItemVolumeFreeEnergy";
            this.toolStripMenuItemVolumeFreeEnergy.Size = new System.Drawing.Size(254, 22);
            this.toolStripMenuItemVolumeFreeEnergy.Text = "Объем свободной мощности";
            this.toolStripMenuItemVolumeFreeEnergy.Click += new System.EventHandler(this.toolStripMenuItemVolumeFreeEnergy_Click);
            // 
            // toolStripMenuItemMeasExist
            // 
            this.toolStripMenuItemMeasExist.Name = "toolStripMenuItemMeasExist";
            this.toolStripMenuItemMeasExist.Size = new System.Drawing.Size(254, 22);
            this.toolStripMenuItemMeasExist.Text = "Наличие замеров";
            this.toolStripMenuItemMeasExist.Click += new System.EventHandler(this.toolStripMenuItemMeasExist_Click);
            // 
            // toolStripButton_8
            // 
            this.toolStripButton_8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_8.Name = "toolStripButton_8";
            this.toolStripButton_8.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton_8.Text = "insert idBus";
            this.toolStripButton_8.Visible = false;
            this.toolStripButton_8.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // toolStripButtonhelp
            // 
            this.toolStripButtonhelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonhelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonhelp.Name = "toolStripButtonhelp";
            this.toolStripButtonhelp.Size = new System.Drawing.Size(60, 22);
            this.toolStripButtonhelp.Text = "Помощь";
            this.toolStripButtonhelp.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // button_0
            // 
            this.button_0.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_0.Location = new System.Drawing.Point(717, 524);
            this.button_0.Margin = new System.Windows.Forms.Padding(10, 6, 15, 6);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(80, 26);
            this.button_0.TabIndex = 5;
            this.button_0.Text = "Закрыть";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tlpMeasurementLow
            // 
            this.tlpMeasurementLow.ColumnCount = 3;
            this.tlpMeasurementLow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tlpMeasurementLow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tlpMeasurementLow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMeasurementLow.Controls.Add(this.comboBoxBusesTransfs, 1, 0);
            this.tlpMeasurementLow.Controls.Add(this.labelTrans, 0, 0);
            this.tlpMeasurementLow.Controls.Add(this.tcMeasurement, 0, 4);
            this.tlpMeasurementLow.Controls.Add(this.panel_0, 0, 1);
            this.tlpMeasurementLow.Controls.Add(this.dgvSumCable, 0, 3);
            this.tlpMeasurementLow.Controls.Add(this.panel_6, 2, 1);
            this.tlpMeasurementLow.Controls.Add(this.dgvMeasCable, 0, 2);
            this.tlpMeasurementLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMeasurementLow.Location = new System.Drawing.Point(7, 125);
            this.tlpMeasurementLow.Name = "tlpMeasurementLow";
            this.tlpMeasurementLow.RowCount = 5;
            this.tlpMeasurementLow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpMeasurementLow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tlpMeasurementLow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMeasurementLow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpMeasurementLow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpMeasurementLow.Size = new System.Drawing.Size(802, 192);
            this.tlpMeasurementLow.TabIndex = 0;
            // 
            // comboBoxBusesTransfs
            // 
            this.comboBoxBusesTransfs.DataSource = this.bsBusesTransfs;
            this.comboBoxBusesTransfs.DisplayMember = "Name";
            this.comboBoxBusesTransfs.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxBusesTransfs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBusesTransfs.FormattingEnabled = true;
            this.comboBoxBusesTransfs.Location = new System.Drawing.Point(161, 0);
            this.comboBoxBusesTransfs.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.comboBoxBusesTransfs.Name = "comboBoxBusesTransfs";
            this.comboBoxBusesTransfs.Size = new System.Drawing.Size(110, 21);
            this.comboBoxBusesTransfs.TabIndex = 1;
            this.comboBoxBusesTransfs.ValueMember = "idBus";
            // 
            // bsBusesTransfs
            // 
            this.bsBusesTransfs.DataMember = "vJ_BusesTransfs";
            this.bsBusesTransfs.DataSource = this.dsJournal;
            // 
            // dsJournal
            // 
            this.dsJournal.DataSetName = "DataSetMeasurementN";
            this.dsJournal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelTrans
            // 
            this.labelTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrans.Location = new System.Drawing.Point(3, 0);
            this.labelTrans.Name = "labelTrans";
            this.labelTrans.Size = new System.Drawing.Size(152, 21);
            this.labelTrans.TabIndex = 10;
            this.labelTrans.Text = "Секция шин №";
            this.labelTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcMeasurement
            // 
            this.tlpMeasurementLow.SetColumnSpan(this.tcMeasurement, 3);
            this.tcMeasurement.Controls.Add(this.tpRatio);
            this.tcMeasurement.Controls.Add(this.tpAddress);
            this.tcMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMeasurement.Location = new System.Drawing.Point(3, 75);
            this.tcMeasurement.Name = "tcMeasurement";
            this.tcMeasurement.SelectedIndex = 0;
            this.tcMeasurement.Size = new System.Drawing.Size(796, 114);
            this.tcMeasurement.TabIndex = 14;
            this.tcMeasurement.SelectedIndexChanged += new System.EventHandler(this.tcMeasurement_SelectedIndexChanged);
            // 
            // tpRatio
            // 
            this.tpRatio.Controls.Add(this.label_1);
            this.tpRatio.Controls.Add(this.label_2);
            this.tpRatio.Controls.Add(this.label_3);
            this.tpRatio.Controls.Add(this.label_4);
            this.tpRatio.Controls.Add(this.label_5);
            this.tpRatio.Controls.Add(this.label_6);
            this.tpRatio.Controls.Add(this.tbKNKFn);
            this.tpRatio.Controls.Add(this.tbKNKFd);
            this.tpRatio.Controls.Add(this.tbKNTn);
            this.tpRatio.Controls.Add(this.tbKNTd);
            this.tpRatio.Controls.Add(this.tbIsrn);
            this.tpRatio.Controls.Add(this.tbIsrd);
            this.tpRatio.Location = new System.Drawing.Point(4, 22);
            this.tpRatio.Name = "tpRatio";
            this.tpRatio.Padding = new System.Windows.Forms.Padding(3);
            this.tpRatio.Size = new System.Drawing.Size(788, 88);
            this.tpRatio.TabIndex = 1;
            this.tpRatio.Text = "Коэффициент";
            this.tpRatio.UseVisualStyleBackColor = true;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(455, 53);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(237, 13);
            this.label_1.TabIndex = 11;
            this.label_1.Text = "Коэффициент неравномерности Кл.фаз Кз %";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Location = new System.Drawing.Point(455, 27);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(237, 13);
            this.label_2.TabIndex = 10;
            this.label_2.Text = "Коэффициент неравномерности Кл.фаз Кз %";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Location = new System.Drawing.Point(133, 53);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(242, 13);
            this.label_3.TabIndex = 9;
            this.label_3.Text = "Коэффициент нагрузки трансформатора Кз %";
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Location = new System.Drawing.Point(133, 27);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(242, 13);
            this.label_4.TabIndex = 8;
            this.label_4.Text = "Коэффициент нагрузки трансформатора Кз %";
            // 
            // label_5
            // 
            this.label_5.AutoSize = true;
            this.label_5.Location = new System.Drawing.Point(6, 53);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(58, 13);
            this.label_5.TabIndex = 7;
            this.label_5.Text = "Вечер  Iср";
            // 
            // label_6
            // 
            this.label_6.AutoSize = true;
            this.label_6.Location = new System.Drawing.Point(6, 27);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(58, 13);
            this.label_6.TabIndex = 6;
            this.label_6.Text = "День   Iср";
            // 
            // tbKNKFn
            // 
            this.tbKNKFn.BackColor = System.Drawing.Color.White;
            this.tbKNKFn.Location = new System.Drawing.Point(707, 50);
            this.tbKNKFn.Name = "tbKNKFn";
            this.tbKNKFn.ReadOnly = true;
            this.tbKNKFn.Size = new System.Drawing.Size(36, 20);
            this.tbKNKFn.TabIndex = 5;
            // 
            // tbKNKFd
            // 
            this.tbKNKFd.BackColor = System.Drawing.Color.White;
            this.tbKNKFd.Location = new System.Drawing.Point(707, 24);
            this.tbKNKFd.Name = "tbKNKFd";
            this.tbKNKFd.ReadOnly = true;
            this.tbKNKFd.Size = new System.Drawing.Size(36, 20);
            this.tbKNKFd.TabIndex = 4;
            // 
            // tbKNTn
            // 
            this.tbKNTn.BackColor = System.Drawing.Color.White;
            this.tbKNTn.Location = new System.Drawing.Point(394, 50);
            this.tbKNTn.Name = "tbKNTn";
            this.tbKNTn.ReadOnly = true;
            this.tbKNTn.Size = new System.Drawing.Size(36, 20);
            this.tbKNTn.TabIndex = 3;
            // 
            // tbKNTd
            // 
            this.tbKNTd.BackColor = System.Drawing.Color.White;
            this.tbKNTd.Location = new System.Drawing.Point(394, 24);
            this.tbKNTd.Name = "tbKNTd";
            this.tbKNTd.ReadOnly = true;
            this.tbKNTd.Size = new System.Drawing.Size(36, 20);
            this.tbKNTd.TabIndex = 2;
            // 
            // tbIsrn
            // 
            this.tbIsrn.BackColor = System.Drawing.Color.White;
            this.tbIsrn.Location = new System.Drawing.Point(76, 50);
            this.tbIsrn.Name = "tbIsrn";
            this.tbIsrn.ReadOnly = true;
            this.tbIsrn.Size = new System.Drawing.Size(36, 20);
            this.tbIsrn.TabIndex = 1;
            // 
            // tbIsrd
            // 
            this.tbIsrd.BackColor = System.Drawing.Color.White;
            this.tbIsrd.Location = new System.Drawing.Point(76, 24);
            this.tbIsrd.Name = "tbIsrd";
            this.tbIsrd.ReadOnly = true;
            this.tbIsrd.Size = new System.Drawing.Size(36, 20);
            this.tbIsrd.TabIndex = 0;
            // 
            // tpAddress
            // 
            this.tpAddress.Controls.Add(this.dgvAbnObj);
            this.tpAddress.Location = new System.Drawing.Point(4, 22);
            this.tpAddress.Name = "tpAddress";
            this.tpAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddress.Size = new System.Drawing.Size(788, 88);
            this.tpAddress.TabIndex = 0;
            this.tpAddress.Text = "Адреса";
            this.tpAddress.UseVisualStyleBackColor = true;
            // 
            // dgvAbnObj
            // 
            this.dgvAbnObj.AllowUserToAddRows = false;
            this.dgvAbnObj.AllowUserToDeleteRows = false;
            this.dgvAbnObj.AllowUserToOrderColumns = true;
            this.dgvAbnObj.AllowUserToResizeRows = false;
            this.dgvAbnObj.AutoGenerateColumns = false;
            this.dgvAbnObj.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbnObj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAbnObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbnObj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSchmObjDataGridViewTextBoxColumn,
            this.typeDocDataGridViewTextBoxColumn2,
            this.streetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.idsDataGridViewTextBoxColumn});
            this.dgvAbnObj.DataSource = this.bsMeasAbnObj;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbnObj.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAbnObj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbnObj.Location = new System.Drawing.Point(3, 3);
            this.dgvAbnObj.MultiSelect = false;
            this.dgvAbnObj.Name = "dgvAbnObj";
            this.dgvAbnObj.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbnObj.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAbnObj.RowHeadersVisible = false;
            this.dgvAbnObj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbnObj.Size = new System.Drawing.Size(782, 82);
            this.dgvAbnObj.TabIndex = 12;
            // 
            // idSchmObjDataGridViewTextBoxColumn
            // 
            this.idSchmObjDataGridViewTextBoxColumn.DataPropertyName = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn.HeaderText = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn.Name = "idSchmObjDataGridViewTextBoxColumn";
            this.idSchmObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSchmObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDocDataGridViewTextBoxColumn2
            // 
            this.typeDocDataGridViewTextBoxColumn2.DataPropertyName = "TypeDoc";
            this.typeDocDataGridViewTextBoxColumn2.HeaderText = "TypeDoc";
            this.typeDocDataGridViewTextBoxColumn2.Name = "typeDocDataGridViewTextBoxColumn2";
            this.typeDocDataGridViewTextBoxColumn2.ReadOnly = true;
            this.typeDocDataGridViewTextBoxColumn2.Visible = false;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetDataGridViewTextBoxColumn.Width = 180;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.ReadOnly = true;
            this.houseDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "codeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 120;
            // 
            // idsDataGridViewTextBoxColumn
            // 
            this.idsDataGridViewTextBoxColumn.DataPropertyName = "ids";
            this.idsDataGridViewTextBoxColumn.HeaderText = "ids";
            this.idsDataGridViewTextBoxColumn.Name = "idsDataGridViewTextBoxColumn";
            this.idsDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsMeasAbnObj
            // 
            this.bsMeasAbnObj.DataMember = "vJ_MeasAbnObj";
            this.bsMeasAbnObj.DataSource = this.dsJournal;
            this.bsMeasAbnObj.Sort = "";
            // 
            // panel_0
            // 
            this.tlpMeasurementLow.SetColumnSpan(this.panel_0, 2);
            this.panel_0.Controls.Add(this.label_7);
            this.panel_0.Controls.Add(this.label_8);
            this.panel_0.Controls.Add(this.label_9);
            this.panel_0.Controls.Add(this.label_10);
            this.panel_0.Controls.Add(this.label_11);
            this.panel_0.Controls.Add(this.panel_1);
            this.panel_0.Controls.Add(this.panel_2);
            this.panel_0.Controls.Add(this.panel_3);
            this.panel_0.Controls.Add(this.panel_4);
            this.panel_0.Controls.Add(this.panel_5);
            this.panel_0.Location = new System.Drawing.Point(3, 24);
            this.panel_0.Name = "panel_0";
            this.panel_0.Size = new System.Drawing.Size(419, 102);
            this.panel_0.TabIndex = 8;
            // 
            // label_7
            // 
            this.label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_7.Location = new System.Drawing.Point(0, 0);
            this.label_7.Name = "label_7";
            this.label_7.Size = new System.Drawing.Size(124, 51);
            this.label_7.TabIndex = 0;
            this.label_7.Text = "Трансформатор";
            this.label_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_8
            // 
            this.label_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_8.Location = new System.Drawing.Point(123, 0);
            this.label_8.Name = "label_8";
            this.label_8.Size = new System.Drawing.Size(75, 51);
            this.label_8.TabIndex = 0;
            this.label_8.Text = "Мощность кВт";
            this.label_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_9
            // 
            this.label_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_9.Location = new System.Drawing.Point(197, 0);
            this.label_9.Name = "label_9";
            this.label_9.Size = new System.Drawing.Size(51, 51);
            this.label_9.TabIndex = 0;
            this.label_9.Text = "Uвн\r\n(раб)";
            this.label_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_10
            // 
            this.label_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_10.Location = new System.Drawing.Point(247, 0);
            this.label_10.Name = "label_10";
            this.label_10.Size = new System.Drawing.Size(47, 51);
            this.label_10.TabIndex = 0;
            this.label_10.Text = "Iном\r\nА";
            this.label_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_11
            // 
            this.label_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_11.Location = new System.Drawing.Point(292, 0);
            this.label_11.Name = "label_11";
            this.label_11.Size = new System.Drawing.Size(127, 51);
            this.label_11.TabIndex = 0;
            this.label_11.Text = "Положение\r\nпереключателя\r\nнапряжения";
            this.label_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_1
            // 
            this.panel_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_1.Controls.Add(this.textBox_6);
            this.panel_1.Controls.Add(this.textBox_7);
            this.panel_1.Controls.Add(this.label_12);
            this.panel_1.Controls.Add(this.label_13);
            this.panel_1.Location = new System.Drawing.Point(0, 50);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(124, 52);
            this.panel_1.TabIndex = 5;
            // 
            // textBox_6
            // 
            this.textBox_6.BackColor = System.Drawing.Color.White;
            this.textBox_6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_0, "Type", true));
            this.textBox_6.Location = new System.Drawing.Point(36, 2);
            this.textBox_6.Name = "textBox_6";
            this.textBox_6.ReadOnly = true;
            this.textBox_6.Size = new System.Drawing.Size(79, 20);
            this.textBox_6.TabIndex = 2;
            // 
            // bindingSource_0
            // 
            this.bindingSource_0.DataMember = "fn_J_MeasTransfPassport";
            this.bindingSource_0.DataSource = this.dsJournal;
            // 
            // textBox_7
            // 
            this.textBox_7.BackColor = System.Drawing.Color.White;
            this.textBox_7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_0, "InvNumber", true));
            this.textBox_7.Location = new System.Drawing.Point(36, 28);
            this.textBox_7.Name = "textBox_7";
            this.textBox_7.ReadOnly = true;
            this.textBox_7.Size = new System.Drawing.Size(79, 20);
            this.textBox_7.TabIndex = 2;
            // 
            // label_12
            // 
            this.label_12.AutoSize = true;
            this.label_12.Location = new System.Drawing.Point(4, 5);
            this.label_12.Name = "label_12";
            this.label_12.Size = new System.Drawing.Size(26, 13);
            this.label_12.TabIndex = 4;
            this.label_12.Text = "Тип";
            // 
            // label_13
            // 
            this.label_13.AutoSize = true;
            this.label_13.Location = new System.Drawing.Point(8, 31);
            this.label_13.Name = "label_13";
            this.label_13.Size = new System.Drawing.Size(18, 13);
            this.label_13.TabIndex = 4;
            this.label_13.Text = "№";
            // 
            // panel_2
            // 
            this.panel_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_2.Controls.Add(this.cbSwitchPosition);
            this.panel_2.Location = new System.Drawing.Point(293, 50);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(126, 52);
            this.panel_2.TabIndex = 5;
            // 
            // cbSwitchPosition
            // 
            this.cbSwitchPosition.BackColor = System.Drawing.Color.White;
            this.cbSwitchPosition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource_1, "idSwitchPosition", true));
            this.cbSwitchPosition.DataSource = this.bindingSource_12;
            this.cbSwitchPosition.DisplayMember = "Name";
            this.cbSwitchPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbSwitchPosition.FormattingEnabled = true;
            this.cbSwitchPosition.Location = new System.Drawing.Point(2, 15);
            this.cbSwitchPosition.Name = "cbSwitchPosition";
            this.cbSwitchPosition.Size = new System.Drawing.Size(120, 21);
            this.cbSwitchPosition.TabIndex = 3;
            this.cbSwitchPosition.ValueMember = "id";
            // 
            // bindingSource_1
            // 
            this.bindingSource_1.DataMember = "tJ_MeasVoltageTransf";
            this.bindingSource_1.DataSource = this.dsJournal;
            // 
            // bindingSource_12
            // 
            this.bindingSource_12.DataMember = "tR_Classifier";
            this.bindingSource_12.DataSource = this.dsJournal;
            this.bindingSource_12.Filter = "ParentKey = \';Measurement;Switch;\'";
            // 
            // panel_3
            // 
            this.panel_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_3.Controls.Add(this.tbTransAmperage);
            this.panel_3.Location = new System.Drawing.Point(247, 50);
            this.panel_3.Name = "panel_3";
            this.panel_3.Size = new System.Drawing.Size(47, 52);
            this.panel_3.TabIndex = 5;
            // 
            // tbTransAmperage
            // 
            this.tbTransAmperage.BackColor = System.Drawing.Color.White;
            this.tbTransAmperage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_0, "Inom", true));
            this.tbTransAmperage.Location = new System.Drawing.Point(2, 15);
            this.tbTransAmperage.Name = "tbTransAmperage";
            this.tbTransAmperage.ReadOnly = true;
            this.tbTransAmperage.Size = new System.Drawing.Size(40, 20);
            this.tbTransAmperage.TabIndex = 2;
            // 
            // panel_4
            // 
            this.panel_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_4.Controls.Add(this.textBox_9);
            this.panel_4.Location = new System.Drawing.Point(123, 50);
            this.panel_4.Name = "panel_4";
            this.panel_4.Size = new System.Drawing.Size(75, 52);
            this.panel_4.TabIndex = 5;
            // 
            // textBox_9
            // 
            this.textBox_9.BackColor = System.Drawing.Color.White;
            this.textBox_9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_0, "Power", true));
            this.textBox_9.Location = new System.Drawing.Point(3, 15);
            this.textBox_9.Name = "textBox_9";
            this.textBox_9.ReadOnly = true;
            this.textBox_9.Size = new System.Drawing.Size(67, 20);
            this.textBox_9.TabIndex = 2;
            // 
            // panel_5
            // 
            this.panel_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_5.Controls.Add(this.textBox_10);
            this.panel_5.Location = new System.Drawing.Point(197, 50);
            this.panel_5.Name = "panel_5";
            this.panel_5.Size = new System.Drawing.Size(51, 52);
            this.panel_5.TabIndex = 5;
            // 
            // textBox_10
            // 
            this.textBox_10.BackColor = System.Drawing.Color.White;
            this.textBox_10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_0, "Unom", true));
            this.textBox_10.Location = new System.Drawing.Point(2, 15);
            this.textBox_10.Name = "textBox_10";
            this.textBox_10.ReadOnly = true;
            this.textBox_10.Size = new System.Drawing.Size(44, 20);
            this.textBox_10.TabIndex = 2;
            // 
            // dgvSumCable
            // 
            this.dgvSumCable.AllowUserToResizeRows = false;
            this.dgvSumCable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSumCable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSumCable.ColumnHeadersVisible = false;
            this.dgvSumCable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SumName,
            this.ad,
            this.an,
            this.bd,
            this.bn,
            this.cd,
            this.cn,
            this.od,
            this.on,
            this.Column1});
            this.tlpMeasurementLow.SetColumnSpan(this.dgvSumCable, 3);
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSumCable.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSumCable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSumCable.Location = new System.Drawing.Point(3, 44);
            this.dgvSumCable.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.dgvSumCable.MultiSelect = false;
            this.dgvSumCable.Name = "dgvSumCable";
            this.dgvSumCable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSumCable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSumCable.RowHeadersVisible = false;
            this.dgvSumCable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSumCable.Size = new System.Drawing.Size(792, 25);
            this.dgvSumCable.TabIndex = 15;
            // 
            // SumName
            // 
            this.SumName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SumName.HeaderText = "SumName";
            this.SumName.Name = "SumName";
            this.SumName.ReadOnly = true;
            this.SumName.Width = 660;
            // 
            // ad
            // 
            this.ad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ad.HeaderText = "ad";
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            this.ad.Width = 40;
            // 
            // an
            // 
            this.an.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.an.HeaderText = "an";
            this.an.Name = "an";
            this.an.ReadOnly = true;
            this.an.Width = 40;
            // 
            // bd
            // 
            this.bd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bd.HeaderText = "bd";
            this.bd.Name = "bd";
            this.bd.ReadOnly = true;
            this.bd.Width = 40;
            // 
            // bn
            // 
            this.bn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bn.HeaderText = "bn";
            this.bn.Name = "bn";
            this.bn.ReadOnly = true;
            this.bn.Width = 40;
            // 
            // cd
            // 
            this.cd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cd.HeaderText = "cd";
            this.cd.Name = "cd";
            this.cd.ReadOnly = true;
            this.cd.Width = 40;
            // 
            // cn
            // 
            this.cn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cn.HeaderText = "cn";
            this.cn.Name = "cn";
            this.cn.ReadOnly = true;
            this.cn.Width = 40;
            // 
            // od
            // 
            this.od.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.od.HeaderText = "od";
            this.od.Name = "od";
            this.od.ReadOnly = true;
            this.od.Width = 40;
            // 
            // on
            // 
            this.on.HeaderText = "on";
            this.on.Name = "on";
            this.on.ReadOnly = true;
            this.on.Width = 40;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Comment";
            this.Column1.MinimumWidth = 80;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // panel_6
            // 
            this.panel_6.Controls.Add(this.panel_7);
            this.panel_6.Controls.Add(this.panel_8);
            this.panel_6.Controls.Add(this.panel_9);
            this.panel_6.Controls.Add(this.panel_10);
            this.panel_6.Controls.Add(this.panel_11);
            this.panel_6.Controls.Add(this.panel_12);
            this.panel_6.Controls.Add(this.panel_13);
            this.panel_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_6.Location = new System.Drawing.Point(428, 24);
            this.panel_6.Name = "panel_6";
            this.panel_6.Size = new System.Drawing.Size(371, 102);
            this.panel_6.TabIndex = 9;
            // 
            // panel_7
            // 
            this.panel_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_7.Controls.Add(this.label_14);
            this.panel_7.Location = new System.Drawing.Point(61, 0);
            this.panel_7.Name = "panel_7";
            this.panel_7.Size = new System.Drawing.Size(185, 26);
            this.panel_7.TabIndex = 5;
            // 
            // label_14
            // 
            this.label_14.AutoSize = true;
            this.label_14.Location = new System.Drawing.Point(49, 6);
            this.label_14.Name = "label_14";
            this.label_14.Size = new System.Drawing.Size(84, 13);
            this.label_14.TabIndex = 4;
            this.label_14.Text = "Напряжение, В";
            // 
            // panel_8
            // 
            this.panel_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_8.Location = new System.Drawing.Point(11, 0);
            this.panel_8.Name = "panel_8";
            this.panel_8.Size = new System.Drawing.Size(51, 51);
            this.panel_8.TabIndex = 5;
            // 
            // panel_9
            // 
            this.panel_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_9.Controls.Add(this.label_15);
            this.panel_9.Controls.Add(this.label_16);
            this.panel_9.Controls.Add(this.label_17);
            this.panel_9.Location = new System.Drawing.Point(153, 25);
            this.panel_9.Name = "panel_9";
            this.panel_9.Size = new System.Drawing.Size(93, 26);
            this.panel_9.TabIndex = 5;
            // 
            // label_15
            // 
            this.label_15.AutoSize = true;
            this.label_15.Location = new System.Drawing.Point(58, 3);
            this.label_15.Name = "label_15";
            this.label_15.Size = new System.Drawing.Size(30, 13);
            this.label_15.TabIndex = 4;
            this.label_15.Text = "Uc-o";
            // 
            // label_16
            // 
            this.label_16.AutoSize = true;
            this.label_16.Location = new System.Drawing.Point(2, 3);
            this.label_16.Name = "label_16";
            this.label_16.Size = new System.Drawing.Size(30, 13);
            this.label_16.TabIndex = 4;
            this.label_16.Text = "Ua-o";
            // 
            // label_17
            // 
            this.label_17.AutoSize = true;
            this.label_17.Location = new System.Drawing.Point(30, 3);
            this.label_17.Name = "label_17";
            this.label_17.Size = new System.Drawing.Size(30, 13);
            this.label_17.TabIndex = 4;
            this.label_17.Text = "Ub-o";
            // 
            // panel_10
            // 
            this.panel_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_10.Controls.Add(this.textBox_11);
            this.panel_10.Controls.Add(this.textBox_12);
            this.panel_10.Controls.Add(this.textBox_13);
            this.panel_10.Controls.Add(this.textBox_14);
            this.panel_10.Controls.Add(this.textBox_15);
            this.panel_10.Controls.Add(this.textBox_16);
            this.panel_10.Location = new System.Drawing.Point(61, 50);
            this.panel_10.Name = "panel_10";
            this.panel_10.Size = new System.Drawing.Size(93, 51);
            this.panel_10.TabIndex = 5;
            // 
            // textBox_11
            // 
            this.textBox_11.BackColor = System.Drawing.Color.White;
            this.textBox_11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_1, "Ucan", true));
            this.textBox_11.Location = new System.Drawing.Point(60, 25);
            this.textBox_11.Name = "textBox_11";
            this.textBox_11.ReadOnly = true;
            this.textBox_11.Size = new System.Drawing.Size(26, 20);
            this.textBox_11.TabIndex = 6;
            this.textBox_11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texBoxCheck_KeyPress);
            // 
            // textBox_12
            // 
            this.textBox_12.BackColor = System.Drawing.Color.White;
            this.textBox_12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_1, "Ubcn", true));
            this.textBox_12.Location = new System.Drawing.Point(32, 25);
            this.textBox_12.Name = "textBox_12";
            this.textBox_12.ReadOnly = true;
            this.textBox_12.Size = new System.Drawing.Size(26, 20);
            this.textBox_12.TabIndex = 6;
            this.textBox_12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texBoxCheck_KeyPress);
            // 
            // textBox_13
            // 
            this.textBox_13.BackColor = System.Drawing.Color.White;
            this.textBox_13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_1, "Uabn", true));
            this.textBox_13.Location = new System.Drawing.Point(4, 25);
            this.textBox_13.Name = "textBox_13";
            this.textBox_13.ReadOnly = true;
            this.textBox_13.Size = new System.Drawing.Size(26, 20);
            this.textBox_13.TabIndex = 6;
            this.textBox_13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texBoxCheck_KeyPress);
            // 
            // textBox_14
            // 
            this.textBox_14.BackColor = System.Drawing.Color.White;
            this.textBox_14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_1, "Ucad", true));
            this.textBox_14.Location = new System.Drawing.Point(60, 3);
            this.textBox_14.Name = "textBox_14";
            this.textBox_14.ReadOnly = true;
            this.textBox_14.Size = new System.Drawing.Size(26, 20);
            this.textBox_14.TabIndex = 6;
            this.textBox_14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texBoxCheck_KeyPress);
            // 
            // textBox_15
            // 
            this.textBox_15.BackColor = System.Drawing.Color.White;
            this.textBox_15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_1, "Ubcd", true));
            this.textBox_15.Location = new System.Drawing.Point(32, 3);
            this.textBox_15.Name = "textBox_15";
            this.textBox_15.ReadOnly = true;
            this.textBox_15.Size = new System.Drawing.Size(26, 20);
            this.textBox_15.TabIndex = 6;
            this.textBox_15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texBoxCheck_KeyPress);
            // 
            // textBox_16
            // 
            this.textBox_16.BackColor = System.Drawing.Color.White;
            this.textBox_16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_1, "Uabd", true));
            this.textBox_16.Location = new System.Drawing.Point(4, 3);
            this.textBox_16.Name = "textBox_16";
            this.textBox_16.ReadOnly = true;
            this.textBox_16.Size = new System.Drawing.Size(26, 20);
            this.textBox_16.TabIndex = 6;
            this.textBox_16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texBoxCheck_KeyPress);
            // 
            // panel_11
            // 
            this.panel_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_11.Controls.Add(this.label_18);
            this.panel_11.Controls.Add(this.label_19);
            this.panel_11.Controls.Add(this.label_20);
            this.panel_11.Location = new System.Drawing.Point(61, 25);
            this.panel_11.Name = "panel_11";
            this.panel_11.Size = new System.Drawing.Size(93, 26);
            this.panel_11.TabIndex = 5;
            // 
            // label_18
            // 
            this.label_18.AutoSize = true;
            this.label_18.Location = new System.Drawing.Point(60, 3);
            this.label_18.Name = "label_18";
            this.label_18.Size = new System.Drawing.Size(27, 13);
            this.label_18.TabIndex = 4;
            this.label_18.Text = "Uca";
            // 
            // label_19
            // 
            this.label_19.AutoSize = true;
            this.label_19.Location = new System.Drawing.Point(32, 3);
            this.label_19.Name = "label_19";
            this.label_19.Size = new System.Drawing.Size(27, 13);
            this.label_19.TabIndex = 4;
            this.label_19.Text = "Ubc";
            // 
            // label_20
            // 
            this.label_20.AutoSize = true;
            this.label_20.Location = new System.Drawing.Point(4, 3);
            this.label_20.Name = "label_20";
            this.label_20.Size = new System.Drawing.Size(27, 13);
            this.label_20.TabIndex = 4;
            this.label_20.Text = "Uab";
            // 
            // panel_12
            // 
            this.panel_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_12.Controls.Add(this.textBox_17);
            this.panel_12.Controls.Add(this.textBox_18);
            this.panel_12.Controls.Add(this.textBox_19);
            this.panel_12.Controls.Add(this.textBox_20);
            this.panel_12.Controls.Add(this.textBox_21);
            this.panel_12.Controls.Add(this.textBox_22);
            this.panel_12.Location = new System.Drawing.Point(153, 50);
            this.panel_12.Name = "panel_12";
            this.panel_12.Size = new System.Drawing.Size(93, 51);
            this.panel_12.TabIndex = 5;
            // 
            // textBox_17
            // 
            this.textBox_17.BackColor = System.Drawing.Color.White;
            this.textBox_17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_1, "Ucon", true));
            this.textBox_17.Location = new System.Drawing.Point(60, 25);
            this.textBox_17.Name = "textBox_17";
            this.textBox_17.ReadOnly = true;
            this.textBox_17.Size = new System.Drawing.Size(26, 20);
            this.textBox_17.TabIndex = 6;
            this.textBox_17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texBoxCheck_KeyPress);
            // 
            // textBox_18
            // 
            this.textBox_18.BackColor = System.Drawing.Color.White;
            this.textBox_18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_1, "Ubon", true));
            this.textBox_18.Location = new System.Drawing.Point(32, 25);
            this.textBox_18.Name = "textBox_18";
            this.textBox_18.ReadOnly = true;
            this.textBox_18.Size = new System.Drawing.Size(26, 20);
            this.textBox_18.TabIndex = 6;
            this.textBox_18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texBoxCheck_KeyPress);
            // 
            // textBox_19
            // 
            this.textBox_19.BackColor = System.Drawing.Color.White;
            this.textBox_19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_1, "Uaon", true));
            this.textBox_19.Location = new System.Drawing.Point(4, 25);
            this.textBox_19.Name = "textBox_19";
            this.textBox_19.ReadOnly = true;
            this.textBox_19.Size = new System.Drawing.Size(26, 20);
            this.textBox_19.TabIndex = 6;
            this.textBox_19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texBoxCheck_KeyPress);
            // 
            // textBox_20
            // 
            this.textBox_20.BackColor = System.Drawing.Color.White;
            this.textBox_20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_1, "Ucod", true));
            this.textBox_20.Location = new System.Drawing.Point(60, 3);
            this.textBox_20.Name = "textBox_20";
            this.textBox_20.ReadOnly = true;
            this.textBox_20.Size = new System.Drawing.Size(26, 20);
            this.textBox_20.TabIndex = 6;
            this.textBox_20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texBoxCheck_KeyPress);
            // 
            // textBox_21
            // 
            this.textBox_21.BackColor = System.Drawing.Color.White;
            this.textBox_21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_1, "Ubod", true));
            this.textBox_21.Location = new System.Drawing.Point(32, 3);
            this.textBox_21.Name = "textBox_21";
            this.textBox_21.ReadOnly = true;
            this.textBox_21.Size = new System.Drawing.Size(26, 20);
            this.textBox_21.TabIndex = 6;
            this.textBox_21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texBoxCheck_KeyPress);
            // 
            // textBox_22
            // 
            this.textBox_22.BackColor = System.Drawing.Color.White;
            this.textBox_22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_1, "Uaod", true));
            this.textBox_22.Location = new System.Drawing.Point(4, 3);
            this.textBox_22.Name = "textBox_22";
            this.textBox_22.ReadOnly = true;
            this.textBox_22.Size = new System.Drawing.Size(26, 20);
            this.textBox_22.TabIndex = 6;
            this.textBox_22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texBoxCheck_KeyPress);
            // 
            // panel_13
            // 
            this.panel_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_13.Controls.Add(this.label_21);
            this.panel_13.Controls.Add(this.label_22);
            this.panel_13.Location = new System.Drawing.Point(11, 50);
            this.panel_13.Name = "panel_13";
            this.panel_13.Size = new System.Drawing.Size(51, 51);
            this.panel_13.TabIndex = 5;
            // 
            // label_21
            // 
            this.label_21.AutoSize = true;
            this.label_21.Location = new System.Drawing.Point(3, 28);
            this.label_21.Name = "label_21";
            this.label_21.Size = new System.Drawing.Size(37, 13);
            this.label_21.TabIndex = 4;
            this.label_21.Text = "Вечер";
            // 
            // label_22
            // 
            this.label_22.AutoSize = true;
            this.label_22.Location = new System.Drawing.Point(3, 6);
            this.label_22.Name = "label_22";
            this.label_22.Size = new System.Drawing.Size(34, 13);
            this.label_22.TabIndex = 4;
            this.label_22.Text = "День";
            // 
            // dgvMeasCable
            // 
            this.dgvMeasCable.AllowUserToAddRows = false;
            this.dgvMeasCable.AllowUserToDeleteRows = false;
            this.dgvMeasCable.AllowUserToOrderColumns = true;
            this.dgvMeasCable.AllowUserToResizeRows = false;
            this.dgvMeasCable.AutoGenerateColumns = false;
            this.dgvMeasCable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeasCable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMeasCable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasCable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deleted,
            this.NameCell,
            this.idDataGridViewTextBoxColumn,
            this.idMeasurement,
            this.idCell,
            this.OldCell,
            this.NameCable,
            this.Address,
            this.Company,
            this.idSchmAbn,
            this.Makeup,
            this.Voltage,
            this.Wires,
            this.CrossSection,
            this.PermisAmperage,
            this.Iad,
            this.Ian,
            this.Ibd,
            this.Ibn,
            this.Icd,
            this.Icn,
            this.Iod,
            this.Ion,
            this.Comment});
            this.tlpMeasurementLow.SetColumnSpan(this.dgvMeasCable, 3);
            this.dgvMeasCable.DataSource = this.bsMeasCable;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMeasCable.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvMeasCable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeasCable.Location = new System.Drawing.Point(3, 132);
            this.dgvMeasCable.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.dgvMeasCable.MultiSelect = false;
            this.dgvMeasCable.Name = "dgvMeasCable";
            this.dgvMeasCable.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeasCable.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvMeasCable.RowHeadersVisible = false;
            this.dgvMeasCable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeasCable.Size = new System.Drawing.Size(792, 1);
            this.dgvMeasCable.TabIndex = 11;
            this.dgvMeasCable.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvMeasCable_ColumnWidthChanged);
            this.dgvMeasCable.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvMeasCable_Scroll);
            // 
            // Deleted
            // 
            this.Deleted.DataPropertyName = "Deleted";
            this.Deleted.HeaderText = "Deleted";
            this.Deleted.Name = "Deleted";
            this.Deleted.ReadOnly = true;
            this.Deleted.Visible = false;
            // 
            // NameCell
            // 
            this.NameCell.DataPropertyName = "NameCell";
            this.NameCell.HeaderText = "№ руб.";
            this.NameCell.Name = "NameCell";
            this.NameCell.ReadOnly = true;
            this.NameCell.Width = 30;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idMeasurement
            // 
            this.idMeasurement.DataPropertyName = "idMeasurement";
            this.idMeasurement.HeaderText = "idMeasurement";
            this.idMeasurement.Name = "idMeasurement";
            this.idMeasurement.ReadOnly = true;
            this.idMeasurement.Visible = false;
            // 
            // idCell
            // 
            this.idCell.DataPropertyName = "idCell";
            this.idCell.HeaderText = "idCell";
            this.idCell.Name = "idCell";
            this.idCell.ReadOnly = true;
            this.idCell.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCell.Visible = false;
            this.idCell.Width = 30;
            // 
            // OldCell
            // 
            this.OldCell.DataPropertyName = "OldCell";
            this.OldCell.HeaderText = "№ Ст.р";
            this.OldCell.Name = "OldCell";
            this.OldCell.ReadOnly = true;
            this.OldCell.Width = 30;
            // 
            // NameCable
            // 
            this.NameCable.DataPropertyName = "NameCable";
            this.NameCable.HeaderText = "Кабель";
            this.NameCable.Name = "NameCable";
            this.NameCable.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Адрес объекта";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Наименование объекта";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Width = 150;
            // 
            // idSchmAbn
            // 
            this.idSchmAbn.DataPropertyName = "idSchmAbn";
            this.idSchmAbn.HeaderText = "idSchmAbn";
            this.idSchmAbn.Name = "idSchmAbn";
            this.idSchmAbn.ReadOnly = true;
            this.idSchmAbn.Visible = false;
            // 
            // Makeup
            // 
            this.Makeup.DataPropertyName = "Makeup";
            this.Makeup.HeaderText = "Марка кабеля";
            this.Makeup.Name = "Makeup";
            this.Makeup.ReadOnly = true;
            this.Makeup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Makeup.Width = 60;
            // 
            // Voltage
            // 
            this.Voltage.DataPropertyName = "Voltage";
            this.Voltage.HeaderText = "Напр.";
            this.Voltage.Name = "Voltage";
            this.Voltage.ReadOnly = true;
            this.Voltage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Voltage.Visible = false;
            this.Voltage.Width = 70;
            // 
            // Wires
            // 
            this.Wires.DataPropertyName = "Wires";
            this.Wires.HeaderText = "Кол-во жил";
            this.Wires.Name = "Wires";
            this.Wires.ReadOnly = true;
            this.Wires.Width = 40;
            // 
            // CrossSection
            // 
            this.CrossSection.DataPropertyName = "CrossSection";
            this.CrossSection.HeaderText = "Сечение";
            this.CrossSection.Name = "CrossSection";
            this.CrossSection.ReadOnly = true;
            this.CrossSection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CrossSection.Width = 50;
            // 
            // PermisAmperage
            // 
            this.PermisAmperage.DataPropertyName = "PermisAmperage";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PermisAmperage.DefaultCellStyle = dataGridViewCellStyle8;
            this.PermisAmperage.HeaderText = "Допуст. нагр., А";
            this.PermisAmperage.Name = "PermisAmperage";
            this.PermisAmperage.ReadOnly = true;
            this.PermisAmperage.Width = 50;
            // 
            // Iad
            // 
            this.Iad.DataPropertyName = "Iad";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Iad.DefaultCellStyle = dataGridViewCellStyle9;
            this.Iad.HeaderText = "А дн.";
            this.Iad.Name = "Iad";
            this.Iad.ReadOnly = true;
            this.Iad.Width = 40;
            // 
            // Ian
            // 
            this.Ian.DataPropertyName = "Ian";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Ian.DefaultCellStyle = dataGridViewCellStyle10;
            this.Ian.HeaderText = "А вч.";
            this.Ian.Name = "Ian";
            this.Ian.ReadOnly = true;
            this.Ian.Width = 40;
            // 
            // Ibd
            // 
            this.Ibd.DataPropertyName = "Ibd";
            this.Ibd.HeaderText = "В дн.";
            this.Ibd.Name = "Ibd";
            this.Ibd.ReadOnly = true;
            this.Ibd.Width = 40;
            // 
            // Ibn
            // 
            this.Ibn.DataPropertyName = "Ibn";
            this.Ibn.HeaderText = "В вч.";
            this.Ibn.Name = "Ibn";
            this.Ibn.ReadOnly = true;
            this.Ibn.Width = 40;
            // 
            // Icd
            // 
            this.Icd.DataPropertyName = "Icd";
            this.Icd.HeaderText = "С дн.";
            this.Icd.Name = "Icd";
            this.Icd.ReadOnly = true;
            this.Icd.Width = 40;
            // 
            // Icn
            // 
            this.Icn.DataPropertyName = "Icn";
            this.Icn.HeaderText = "С вч.";
            this.Icn.Name = "Icn";
            this.Icn.ReadOnly = true;
            this.Icn.Width = 40;
            // 
            // Iod
            // 
            this.Iod.DataPropertyName = "Iod";
            this.Iod.HeaderText = "0 дн.";
            this.Iod.Name = "Iod";
            this.Iod.ReadOnly = true;
            this.Iod.Width = 40;
            // 
            // Ion
            // 
            this.Ion.DataPropertyName = "Ion";
            this.Ion.HeaderText = "0 вч.";
            this.Ion.Name = "Ion";
            this.Ion.ReadOnly = true;
            this.Ion.Width = 40;
            // 
            // Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Комментарий";
            this.Comment.MinimumWidth = 80;
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // bsMeasCable
            // 
            this.bsMeasCable.DataMember = "vJ_MeasCable";
            this.bsMeasCable.DataSource = this.dsJournal;
            // 
            // dgvMeasurement
            // 
            this.dgvMeasurement.AllowUserToAddRows = false;
            this.dgvMeasurement.AllowUserToDeleteRows = false;
            this.dgvMeasurement.AllowUserToResizeRows = false;
            this.dgvMeasurement.AutoGenerateColumns = false;
            this.dgvMeasurement.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeasurement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvMeasurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasurement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWorkerDataGridViewTextBoxColumn,
            this.idWorkerCheck,
            this.idDataGridViewTextBoxColumn1,
            this.idObjListDataGridViewTextBoxColumn,
            this.typeDocDataGridViewTextBoxColumn1,
            this.yearDataGridViewTextBoxColumn1,
            this.dateDDataGridViewTextBoxColumn,
            this.temperatureDDataGridViewTextBoxColumn,
            this.dateNDataGridViewTextBoxColumn,
            this.temperatureNDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn3,
            this.idOldMeasurementDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn1});
            this.dgvMeasurement.DataSource = this.bsMeasurement;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMeasurement.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeasurement.Location = new System.Drawing.Point(7, 28);
            this.dgvMeasurement.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.dgvMeasurement.MultiSelect = false;
            this.dgvMeasurement.Name = "dgvMeasurement";
            this.dgvMeasurement.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeasurement.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvMeasurement.RowHeadersVisible = false;
            this.dgvMeasurement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeasurement.Size = new System.Drawing.Size(798, 91);
            this.dgvMeasurement.TabIndex = 13;
            this.dgvMeasurement.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMeasurement_DataError);
            // 
            // idWorkerDataGridViewTextBoxColumn
            // 
            this.idWorkerDataGridViewTextBoxColumn.DataPropertyName = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn.DataSource = this.bsWorker;
            this.idWorkerDataGridViewTextBoxColumn.DisplayMember = "FIO";
            this.idWorkerDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idWorkerDataGridViewTextBoxColumn.HeaderText = "Электромонтер";
            this.idWorkerDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.idWorkerDataGridViewTextBoxColumn.Name = "idWorkerDataGridViewTextBoxColumn";
            this.idWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idWorkerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idWorkerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idWorkerDataGridViewTextBoxColumn.ValueMember = "Id";
            this.idWorkerDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsWorker
            // 
            this.bsWorker.DataMember = "vP_Worker";
            this.bsWorker.DataSource = this.dsJournal;
            this.bsWorker.Filter = "ParentKey = \'\' OR ParentKey = \';GroupWorker;Meas;\'";
            this.bsWorker.Sort = "FIO";
            // 
            // idWorkerCheck
            // 
            this.idWorkerCheck.DataPropertyName = "idWorkerCheck";
            this.idWorkerCheck.DataSource = this.bsDispatcher;
            this.idWorkerCheck.DisplayMember = "FIO";
            this.idWorkerCheck.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idWorkerCheck.HeaderText = "Диспетчер";
            this.idWorkerCheck.Name = "idWorkerCheck";
            this.idWorkerCheck.ReadOnly = true;
            this.idWorkerCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idWorkerCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idWorkerCheck.ValueMember = "Id";
            // 
            // bsDispatcher
            // 
            this.bsDispatcher.DataMember = "vP_Worker";
            this.bsDispatcher.DataSource = this.dsJournal;
            this.bsDispatcher.Filter = "ParentKey = \'\' OR ParentKey = \';GroupWorker;MeasDispatchers;\'";
            this.bsDispatcher.Sort = "FIO";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idObjListDataGridViewTextBoxColumn
            // 
            this.idObjListDataGridViewTextBoxColumn.DataPropertyName = "idObjList";
            this.idObjListDataGridViewTextBoxColumn.HeaderText = "idObjList";
            this.idObjListDataGridViewTextBoxColumn.Name = "idObjListDataGridViewTextBoxColumn";
            this.idObjListDataGridViewTextBoxColumn.ReadOnly = true;
            this.idObjListDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDocDataGridViewTextBoxColumn1
            // 
            this.typeDocDataGridViewTextBoxColumn1.DataPropertyName = "TypeDoc";
            this.typeDocDataGridViewTextBoxColumn1.HeaderText = "TypeDoc";
            this.typeDocDataGridViewTextBoxColumn1.Name = "typeDocDataGridViewTextBoxColumn1";
            this.typeDocDataGridViewTextBoxColumn1.ReadOnly = true;
            this.typeDocDataGridViewTextBoxColumn1.Visible = false;
            // 
            // yearDataGridViewTextBoxColumn1
            // 
            this.yearDataGridViewTextBoxColumn1.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn1.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn1.Name = "yearDataGridViewTextBoxColumn1";
            this.yearDataGridViewTextBoxColumn1.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dateDDataGridViewTextBoxColumn
            // 
            this.dateDDataGridViewTextBoxColumn.DataPropertyName = "DateD";
            this.dateDDataGridViewTextBoxColumn.HeaderText = "Дата замера дн.";
            this.dateDDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.dateDDataGridViewTextBoxColumn.Name = "dateDDataGridViewTextBoxColumn";
            this.dateDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temperatureDDataGridViewTextBoxColumn
            // 
            this.temperatureDDataGridViewTextBoxColumn.DataPropertyName = "TemperatureD";
            this.temperatureDDataGridViewTextBoxColumn.HeaderText = "Температура дн.";
            this.temperatureDDataGridViewTextBoxColumn.Name = "temperatureDDataGridViewTextBoxColumn";
            this.temperatureDDataGridViewTextBoxColumn.ReadOnly = true;
            this.temperatureDDataGridViewTextBoxColumn.Width = 70;
            // 
            // dateNDataGridViewTextBoxColumn
            // 
            this.dateNDataGridViewTextBoxColumn.DataPropertyName = "DateN";
            this.dateNDataGridViewTextBoxColumn.HeaderText = "Дата замера вч.";
            this.dateNDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.dateNDataGridViewTextBoxColumn.Name = "dateNDataGridViewTextBoxColumn";
            this.dateNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temperatureNDataGridViewTextBoxColumn
            // 
            this.temperatureNDataGridViewTextBoxColumn.DataPropertyName = "TemperatureN";
            this.temperatureNDataGridViewTextBoxColumn.HeaderText = "Температура вч.";
            this.temperatureNDataGridViewTextBoxColumn.Name = "temperatureNDataGridViewTextBoxColumn";
            this.temperatureNDataGridViewTextBoxColumn.ReadOnly = true;
            this.temperatureNDataGridViewTextBoxColumn.Width = 70;
            // 
            // commentDataGridViewTextBoxColumn3
            // 
            this.commentDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDataGridViewTextBoxColumn3.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn3.HeaderText = "Дополнительно";
            this.commentDataGridViewTextBoxColumn3.MinimumWidth = 100;
            this.commentDataGridViewTextBoxColumn3.Name = "commentDataGridViewTextBoxColumn3";
            this.commentDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // idOldMeasurementDataGridViewTextBoxColumn
            // 
            this.idOldMeasurementDataGridViewTextBoxColumn.DataPropertyName = "idOldMeasurement";
            this.idOldMeasurementDataGridViewTextBoxColumn.HeaderText = "idOldMeasurement";
            this.idOldMeasurementDataGridViewTextBoxColumn.Name = "idOldMeasurementDataGridViewTextBoxColumn";
            this.idOldMeasurementDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOldMeasurementDataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedDataGridViewCheckBoxColumn1
            // 
            this.deletedDataGridViewCheckBoxColumn1.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn1.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn1.Name = "deletedDataGridViewCheckBoxColumn1";
            this.deletedDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.deletedDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // bsMeasurement
            // 
            this.bsMeasurement.DataMember = "tJ_Measurement";
            this.bsMeasurement.DataSource = this.dsJournal;
            this.bsMeasurement.CurrentChanged += new System.EventHandler(this.bsMeasurement_CurrentChanged);
            // 
            // tlpMeasurementHigh
            // 
            this.tlpMeasurementHigh.ColumnCount = 3;
            this.tlpMeasurementHigh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tlpMeasurementHigh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tlpMeasurementHigh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMeasurementHigh.Controls.Add(this.panel_14, 0, 1);
            this.tlpMeasurementHigh.Controls.Add(this.panel_19, 2, 1);
            this.tlpMeasurementHigh.Controls.Add(this.dgvSumCell, 0, 3);
            this.tlpMeasurementHigh.Controls.Add(this.dgvMeasCell, 0, 2);
            this.tlpMeasurementHigh.Controls.Add(this.label_23, 0, 0);
            this.tlpMeasurementHigh.Controls.Add(this.comboBox_2, 1, 0);
            this.tlpMeasurementHigh.Controls.Add(this.lbTransfName, 2, 0);
            this.tlpMeasurementHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMeasurementHigh.Location = new System.Drawing.Point(7, 323);
            this.tlpMeasurementHigh.Name = "tlpMeasurementHigh";
            this.tlpMeasurementHigh.RowCount = 4;
            this.tlpMeasurementHigh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpMeasurementHigh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tlpMeasurementHigh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMeasurementHigh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpMeasurementHigh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMeasurementHigh.Size = new System.Drawing.Size(802, 192);
            this.tlpMeasurementHigh.TabIndex = 17;
            // 
            // panel_14
            // 
            this.tlpMeasurementHigh.SetColumnSpan(this.panel_14, 2);
            this.panel_14.Controls.Add(this.label_24);
            this.panel_14.Controls.Add(this.label_25);
            this.panel_14.Controls.Add(this.label_26);
            this.panel_14.Controls.Add(this.label_27);
            this.panel_14.Controls.Add(this.panel_15);
            this.panel_14.Controls.Add(this.panel_16);
            this.panel_14.Controls.Add(this.panel_17);
            this.panel_14.Controls.Add(this.panel_18);
            this.panel_14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_14.Location = new System.Drawing.Point(3, 24);
            this.panel_14.Name = "panel_14";
            this.panel_14.Size = new System.Drawing.Size(295, 102);
            this.panel_14.TabIndex = 20;
            // 
            // label_24
            // 
            this.label_24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_24.Location = new System.Drawing.Point(0, 0);
            this.label_24.Name = "label_24";
            this.label_24.Size = new System.Drawing.Size(124, 51);
            this.label_24.TabIndex = 0;
            this.label_24.Text = "Трансформатор";
            this.label_24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_25
            // 
            this.label_25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_25.Location = new System.Drawing.Point(123, 0);
            this.label_25.Name = "label_25";
            this.label_25.Size = new System.Drawing.Size(75, 51);
            this.label_25.TabIndex = 0;
            this.label_25.Text = "Мощность кВт";
            this.label_25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_26
            // 
            this.label_26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_26.Location = new System.Drawing.Point(197, 0);
            this.label_26.Name = "label_26";
            this.label_26.Size = new System.Drawing.Size(51, 51);
            this.label_26.TabIndex = 0;
            this.label_26.Text = "Uвн\r\n(раб)";
            this.label_26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_27
            // 
            this.label_27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_27.Location = new System.Drawing.Point(247, 0);
            this.label_27.Name = "label_27";
            this.label_27.Size = new System.Drawing.Size(47, 51);
            this.label_27.TabIndex = 0;
            this.label_27.Text = "Iном\r\nА";
            this.label_27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_15
            // 
            this.panel_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_15.Controls.Add(this.textBox_23);
            this.panel_15.Controls.Add(this.textBox_24);
            this.panel_15.Controls.Add(this.label_28);
            this.panel_15.Controls.Add(this.label_29);
            this.panel_15.Location = new System.Drawing.Point(0, 50);
            this.panel_15.Name = "panel_15";
            this.panel_15.Size = new System.Drawing.Size(124, 52);
            this.panel_15.TabIndex = 5;
            // 
            // textBox_23
            // 
            this.textBox_23.BackColor = System.Drawing.Color.White;
            this.textBox_23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_0, "Type", true));
            this.textBox_23.Location = new System.Drawing.Point(36, 2);
            this.textBox_23.Name = "textBox_23";
            this.textBox_23.ReadOnly = true;
            this.textBox_23.Size = new System.Drawing.Size(79, 20);
            this.textBox_23.TabIndex = 2;
            // 
            // textBox_24
            // 
            this.textBox_24.BackColor = System.Drawing.Color.White;
            this.textBox_24.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_0, "InvNumber", true));
            this.textBox_24.Location = new System.Drawing.Point(36, 28);
            this.textBox_24.Name = "textBox_24";
            this.textBox_24.ReadOnly = true;
            this.textBox_24.Size = new System.Drawing.Size(79, 20);
            this.textBox_24.TabIndex = 2;
            // 
            // label_28
            // 
            this.label_28.AutoSize = true;
            this.label_28.Location = new System.Drawing.Point(4, 5);
            this.label_28.Name = "label_28";
            this.label_28.Size = new System.Drawing.Size(26, 13);
            this.label_28.TabIndex = 4;
            this.label_28.Text = "Тип";
            // 
            // label_29
            // 
            this.label_29.AutoSize = true;
            this.label_29.Location = new System.Drawing.Point(8, 31);
            this.label_29.Name = "label_29";
            this.label_29.Size = new System.Drawing.Size(18, 13);
            this.label_29.TabIndex = 4;
            this.label_29.Text = "№";
            // 
            // panel_16
            // 
            this.panel_16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_16.Controls.Add(this.textBox_25);
            this.panel_16.Location = new System.Drawing.Point(247, 50);
            this.panel_16.Name = "panel_16";
            this.panel_16.Size = new System.Drawing.Size(47, 52);
            this.panel_16.TabIndex = 5;
            // 
            // textBox_25
            // 
            this.textBox_25.BackColor = System.Drawing.Color.White;
            this.textBox_25.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_0, "InomHV", true));
            this.textBox_25.Location = new System.Drawing.Point(2, 15);
            this.textBox_25.Name = "textBox_25";
            this.textBox_25.ReadOnly = true;
            this.textBox_25.Size = new System.Drawing.Size(40, 20);
            this.textBox_25.TabIndex = 2;
            // 
            // panel_17
            // 
            this.panel_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_17.Controls.Add(this.textBox_26);
            this.panel_17.Location = new System.Drawing.Point(123, 50);
            this.panel_17.Name = "panel_17";
            this.panel_17.Size = new System.Drawing.Size(75, 52);
            this.panel_17.TabIndex = 5;
            // 
            // textBox_26
            // 
            this.textBox_26.BackColor = System.Drawing.Color.White;
            this.textBox_26.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_0, "Power", true));
            this.textBox_26.Location = new System.Drawing.Point(3, 15);
            this.textBox_26.Name = "textBox_26";
            this.textBox_26.ReadOnly = true;
            this.textBox_26.Size = new System.Drawing.Size(67, 20);
            this.textBox_26.TabIndex = 2;
            // 
            // panel_18
            // 
            this.panel_18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_18.Controls.Add(this.textBox_27);
            this.panel_18.Location = new System.Drawing.Point(197, 50);
            this.panel_18.Name = "panel_18";
            this.panel_18.Size = new System.Drawing.Size(51, 52);
            this.panel_18.TabIndex = 5;
            // 
            // textBox_27
            // 
            this.textBox_27.BackColor = System.Drawing.Color.White;
            this.textBox_27.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_0, "Unom", true));
            this.textBox_27.Location = new System.Drawing.Point(2, 15);
            this.textBox_27.Name = "textBox_27";
            this.textBox_27.ReadOnly = true;
            this.textBox_27.Size = new System.Drawing.Size(44, 20);
            this.textBox_27.TabIndex = 2;
            // 
            // panel_19
            // 
            this.panel_19.Controls.Add(this.panel_20);
            this.panel_19.Controls.Add(this.panel_21);
            this.panel_19.Controls.Add(this.panel_22);
            this.panel_19.Controls.Add(this.panel_23);
            this.panel_19.Controls.Add(this.panel_24);
            this.panel_19.Controls.Add(this.label_34);
            this.panel_19.Controls.Add(this.panel_25);
            this.panel_19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_19.Location = new System.Drawing.Point(304, 24);
            this.panel_19.Name = "panel_19";
            this.panel_19.Size = new System.Drawing.Size(495, 102);
            this.panel_19.TabIndex = 17;
            // 
            // panel_20
            // 
            this.panel_20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_20.Controls.Add(this.label_31);
            this.panel_20.Location = new System.Drawing.Point(211, 0);
            this.panel_20.Name = "panel_20";
            this.panel_20.Size = new System.Drawing.Size(69, 51);
            this.panel_20.TabIndex = 16;
            // 
            // label_31
            // 
            this.label_31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_31.Location = new System.Drawing.Point(0, 0);
            this.label_31.Name = "label_31";
            this.label_31.Size = new System.Drawing.Size(67, 49);
            this.label_31.TabIndex = 2;
            this.label_31.Text = "B";
            this.label_31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_21
            // 
            this.panel_21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_21.Controls.Add(this.label_32);
            this.panel_21.Location = new System.Drawing.Point(279, 0);
            this.panel_21.Name = "panel_21";
            this.panel_21.Size = new System.Drawing.Size(72, 51);
            this.panel_21.TabIndex = 15;
            // 
            // label_32
            // 
            this.label_32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_32.Location = new System.Drawing.Point(0, 0);
            this.label_32.Name = "label_32";
            this.label_32.Size = new System.Drawing.Size(70, 49);
            this.label_32.TabIndex = 2;
            this.label_32.Text = "C";
            this.label_32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_22
            // 
            this.panel_22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_22.Controls.Add(this.label_33);
            this.panel_22.Location = new System.Drawing.Point(140, 0);
            this.panel_22.Name = "panel_22";
            this.panel_22.Size = new System.Drawing.Size(72, 51);
            this.panel_22.TabIndex = 14;
            // 
            // label_33
            // 
            this.label_33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_33.Location = new System.Drawing.Point(0, 0);
            this.label_33.Name = "label_33";
            this.label_33.Size = new System.Drawing.Size(70, 49);
            this.label_33.TabIndex = 1;
            this.label_33.Text = "A";
            this.label_33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_23
            // 
            this.panel_23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_23.Controls.Add(this.textBox_28);
            this.panel_23.Location = new System.Drawing.Point(279, 50);
            this.panel_23.Name = "panel_23";
            this.panel_23.Size = new System.Drawing.Size(72, 52);
            this.panel_23.TabIndex = 12;
            // 
            // textBox_28
            // 
            this.textBox_28.BackColor = System.Drawing.Color.White;
            this.textBox_28.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasAmperageTransf, "Ic", true));
            this.textBox_28.Location = new System.Drawing.Point(3, 16);
            this.textBox_28.Name = "textBox_28";
            this.textBox_28.ReadOnly = true;
            this.textBox_28.Size = new System.Drawing.Size(63, 20);
            this.textBox_28.TabIndex = 2;
            // 
            // bsMeasAmperageTransf
            // 
            this.bsMeasAmperageTransf.DataMember = "tJ_MeasAmperageTransf";
            this.bsMeasAmperageTransf.DataSource = this.dsJournal;
            // 
            // panel_24
            // 
            this.panel_24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_24.Controls.Add(this.textBox_29);
            this.panel_24.Location = new System.Drawing.Point(211, 50);
            this.panel_24.Name = "panel_24";
            this.panel_24.Size = new System.Drawing.Size(69, 52);
            this.panel_24.TabIndex = 11;
            // 
            // textBox_29
            // 
            this.textBox_29.BackColor = System.Drawing.Color.White;
            this.textBox_29.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasAmperageTransf, "Ib", true));
            this.textBox_29.Location = new System.Drawing.Point(3, 16);
            this.textBox_29.Name = "textBox_29";
            this.textBox_29.ReadOnly = true;
            this.textBox_29.Size = new System.Drawing.Size(61, 20);
            this.textBox_29.TabIndex = 2;
            // 
            // label_34
            // 
            this.label_34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_34.Location = new System.Drawing.Point(0, 0);
            this.label_34.Name = "label_34";
            this.label_34.Size = new System.Drawing.Size(141, 102);
            this.label_34.TabIndex = 10;
            this.label_34.Text = "Ток нагрузки";
            this.label_34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_25
            // 
            this.panel_25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_25.Controls.Add(this.textBox_30);
            this.panel_25.Location = new System.Drawing.Point(140, 50);
            this.panel_25.Name = "panel_25";
            this.panel_25.Size = new System.Drawing.Size(72, 52);
            this.panel_25.TabIndex = 6;
            // 
            // textBox_30
            // 
            this.textBox_30.BackColor = System.Drawing.Color.White;
            this.textBox_30.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasAmperageTransf, "Ia", true));
            this.textBox_30.Location = new System.Drawing.Point(3, 16);
            this.textBox_30.Name = "textBox_30";
            this.textBox_30.ReadOnly = true;
            this.textBox_30.Size = new System.Drawing.Size(64, 20);
            this.textBox_30.TabIndex = 2;
            // 
            // dgvSumCell
            // 
            this.dgvSumCell.AllowUserToResizeRows = false;
            this.dgvSumCell.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSumCell.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvSumCell.ColumnHeadersVisible = false;
            this.dgvSumCell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn32});
            this.tlpMeasurementHigh.SetColumnSpan(this.dgvSumCell, 3);
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSumCell.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvSumCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSumCell.Location = new System.Drawing.Point(3, 167);
            this.dgvSumCell.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.dgvSumCell.MultiSelect = false;
            this.dgvSumCell.Name = "dgvSumCell";
            this.dgvSumCell.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSumCell.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvSumCell.RowHeadersVisible = false;
            this.dgvSumCell.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSumCell.Size = new System.Drawing.Size(792, 22);
            this.dgvSumCell.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn23.HeaderText = "SumName";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 110;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn24.HeaderText = "ad";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 60;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn25.DataPropertyName = "idSchmAbn";
            this.dataGridViewTextBoxColumn25.HeaderText = "an";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Visible = false;
            this.dataGridViewTextBoxColumn25.Width = 60;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Makeup";
            this.dataGridViewTextBoxColumn26.HeaderText = "bd";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn26.Width = 60;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Voltage";
            this.dataGridViewTextBoxColumn27.HeaderText = "bn";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn27.Visible = false;
            this.dataGridViewTextBoxColumn27.Width = 60;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Wires";
            this.dataGridViewTextBoxColumn28.HeaderText = "cd";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Width = 60;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn29.DataPropertyName = "CrossSection";
            this.dataGridViewTextBoxColumn29.HeaderText = "cn";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn29.Width = 60;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Ian";
            dataGridViewCellStyle17.Format = "N0";
            this.dataGridViewTextBoxColumn32.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn32.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn32.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dgvMeasCell
            // 
            this.dgvMeasCell.AllowUserToAddRows = false;
            this.dgvMeasCell.AllowUserToDeleteRows = false;
            this.dgvMeasCell.AllowUserToOrderColumns = true;
            this.dgvMeasCell.AllowUserToResizeRows = false;
            this.dgvMeasCell.AutoGenerateColumns = false;
            this.dgvMeasCell.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeasCell.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvMeasCell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasCell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn4,
            this.idMeasurementDataGridViewTextBoxColumn2,
            this.idBusDataGridViewTextBoxColumn1,
            this.idTransfDataGridViewTextBoxColumn2,
            this.nameBusDataGridViewTextBoxColumn,
            this.nameCellDataGridViewTextBoxColumn2,
            this.permisAmperageDataGridViewTextBoxColumn2,
            this.iadDataGridViewTextBoxColumn2,
            this.ianDataGridViewTextBoxColumn2,
            this.ibdDataGridViewTextBoxColumn2,
            this.ibnDataGridViewTextBoxColumn2,
            this.icdDataGridViewTextBoxColumn2,
            this.icnDataGridViewTextBoxColumn2,
            this.iodDataGridViewTextBoxColumn2,
            this.ionDataGridViewTextBoxColumn2,
            this.commentDataGridViewTextBoxColumn4,
            this.deletedDataGridViewCheckBoxColumn4});
            this.tlpMeasurementHigh.SetColumnSpan(this.dgvMeasCell, 3);
            this.dgvMeasCell.DataSource = this.bsMeasCell;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMeasCell.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvMeasCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeasCell.Location = new System.Drawing.Point(3, 132);
            this.dgvMeasCell.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.dgvMeasCell.MultiSelect = false;
            this.dgvMeasCell.Name = "dgvMeasCell";
            this.dgvMeasCell.ReadOnly = true;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeasCell.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvMeasCell.RowHeadersVisible = false;
            this.dgvMeasCell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeasCell.Size = new System.Drawing.Size(792, 29);
            this.dgvMeasCell.TabIndex = 12;
            this.dgvMeasCell.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView_5_ColumnWidthChanged);
            this.dgvMeasCell.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView_5_Scroll);
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "id";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            this.idDataGridViewTextBoxColumn4.Visible = false;
            // 
            // idMeasurementDataGridViewTextBoxColumn2
            // 
            this.idMeasurementDataGridViewTextBoxColumn2.DataPropertyName = "idMeasurement";
            this.idMeasurementDataGridViewTextBoxColumn2.HeaderText = "idMeasurement";
            this.idMeasurementDataGridViewTextBoxColumn2.Name = "idMeasurementDataGridViewTextBoxColumn2";
            this.idMeasurementDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idMeasurementDataGridViewTextBoxColumn2.Visible = false;
            // 
            // idBusDataGridViewTextBoxColumn1
            // 
            this.idBusDataGridViewTextBoxColumn1.DataPropertyName = "idBus";
            this.idBusDataGridViewTextBoxColumn1.HeaderText = "idBus";
            this.idBusDataGridViewTextBoxColumn1.Name = "idBusDataGridViewTextBoxColumn1";
            this.idBusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idBusDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idTransfDataGridViewTextBoxColumn2
            // 
            this.idTransfDataGridViewTextBoxColumn2.DataPropertyName = "idTransf";
            this.idTransfDataGridViewTextBoxColumn2.HeaderText = "idTransf";
            this.idTransfDataGridViewTextBoxColumn2.Name = "idTransfDataGridViewTextBoxColumn2";
            this.idTransfDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idTransfDataGridViewTextBoxColumn2.Visible = false;
            // 
            // nameBusDataGridViewTextBoxColumn
            // 
            this.nameBusDataGridViewTextBoxColumn.DataPropertyName = "NameBus";
            this.nameBusDataGridViewTextBoxColumn.HeaderText = "NameBus";
            this.nameBusDataGridViewTextBoxColumn.Name = "nameBusDataGridViewTextBoxColumn";
            this.nameBusDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameBusDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameCellDataGridViewTextBoxColumn2
            // 
            this.nameCellDataGridViewTextBoxColumn2.DataPropertyName = "NameCell";
            this.nameCellDataGridViewTextBoxColumn2.HeaderText = "№ руб.";
            this.nameCellDataGridViewTextBoxColumn2.Name = "nameCellDataGridViewTextBoxColumn2";
            this.nameCellDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nameCellDataGridViewTextBoxColumn2.Width = 30;
            // 
            // permisAmperageDataGridViewTextBoxColumn2
            // 
            this.permisAmperageDataGridViewTextBoxColumn2.DataPropertyName = "PermisAmperage";
            this.permisAmperageDataGridViewTextBoxColumn2.HeaderText = "Допуст. нагр., А";
            this.permisAmperageDataGridViewTextBoxColumn2.Name = "permisAmperageDataGridViewTextBoxColumn2";
            this.permisAmperageDataGridViewTextBoxColumn2.ReadOnly = true;
            this.permisAmperageDataGridViewTextBoxColumn2.Width = 80;
            // 
            // iadDataGridViewTextBoxColumn2
            // 
            this.iadDataGridViewTextBoxColumn2.DataPropertyName = "Iad";
            this.iadDataGridViewTextBoxColumn2.HeaderText = "А дн.";
            this.iadDataGridViewTextBoxColumn2.Name = "iadDataGridViewTextBoxColumn2";
            this.iadDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iadDataGridViewTextBoxColumn2.Width = 60;
            // 
            // ianDataGridViewTextBoxColumn2
            // 
            this.ianDataGridViewTextBoxColumn2.DataPropertyName = "Ian";
            this.ianDataGridViewTextBoxColumn2.HeaderText = "А вч.";
            this.ianDataGridViewTextBoxColumn2.Name = "ianDataGridViewTextBoxColumn2";
            this.ianDataGridViewTextBoxColumn2.ReadOnly = true;
            this.ianDataGridViewTextBoxColumn2.Width = 60;
            // 
            // ibdDataGridViewTextBoxColumn2
            // 
            this.ibdDataGridViewTextBoxColumn2.DataPropertyName = "Ibd";
            this.ibdDataGridViewTextBoxColumn2.HeaderText = "В дн.";
            this.ibdDataGridViewTextBoxColumn2.Name = "ibdDataGridViewTextBoxColumn2";
            this.ibdDataGridViewTextBoxColumn2.ReadOnly = true;
            this.ibdDataGridViewTextBoxColumn2.Width = 60;
            // 
            // ibnDataGridViewTextBoxColumn2
            // 
            this.ibnDataGridViewTextBoxColumn2.DataPropertyName = "Ibn";
            this.ibnDataGridViewTextBoxColumn2.HeaderText = "В вч.";
            this.ibnDataGridViewTextBoxColumn2.Name = "ibnDataGridViewTextBoxColumn2";
            this.ibnDataGridViewTextBoxColumn2.ReadOnly = true;
            this.ibnDataGridViewTextBoxColumn2.Width = 60;
            // 
            // icdDataGridViewTextBoxColumn2
            // 
            this.icdDataGridViewTextBoxColumn2.DataPropertyName = "Icd";
            this.icdDataGridViewTextBoxColumn2.HeaderText = "С дн.";
            this.icdDataGridViewTextBoxColumn2.Name = "icdDataGridViewTextBoxColumn2";
            this.icdDataGridViewTextBoxColumn2.ReadOnly = true;
            this.icdDataGridViewTextBoxColumn2.Width = 60;
            // 
            // icnDataGridViewTextBoxColumn2
            // 
            this.icnDataGridViewTextBoxColumn2.DataPropertyName = "Icn";
            this.icnDataGridViewTextBoxColumn2.HeaderText = "С вч.";
            this.icnDataGridViewTextBoxColumn2.Name = "icnDataGridViewTextBoxColumn2";
            this.icnDataGridViewTextBoxColumn2.ReadOnly = true;
            this.icnDataGridViewTextBoxColumn2.Width = 60;
            // 
            // iodDataGridViewTextBoxColumn2
            // 
            this.iodDataGridViewTextBoxColumn2.DataPropertyName = "Iod";
            this.iodDataGridViewTextBoxColumn2.HeaderText = "Iod";
            this.iodDataGridViewTextBoxColumn2.Name = "iodDataGridViewTextBoxColumn2";
            this.iodDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iodDataGridViewTextBoxColumn2.Visible = false;
            // 
            // ionDataGridViewTextBoxColumn2
            // 
            this.ionDataGridViewTextBoxColumn2.DataPropertyName = "Ion";
            this.ionDataGridViewTextBoxColumn2.HeaderText = "Ion";
            this.ionDataGridViewTextBoxColumn2.Name = "ionDataGridViewTextBoxColumn2";
            this.ionDataGridViewTextBoxColumn2.ReadOnly = true;
            this.ionDataGridViewTextBoxColumn2.Visible = false;
            // 
            // commentDataGridViewTextBoxColumn4
            // 
            this.commentDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDataGridViewTextBoxColumn4.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn4.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn4.Name = "commentDataGridViewTextBoxColumn4";
            this.commentDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // deletedDataGridViewCheckBoxColumn4
            // 
            this.deletedDataGridViewCheckBoxColumn4.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn4.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn4.Name = "deletedDataGridViewCheckBoxColumn4";
            this.deletedDataGridViewCheckBoxColumn4.ReadOnly = true;
            this.deletedDataGridViewCheckBoxColumn4.Visible = false;
            // 
            // bsMeasCell
            // 
            this.bsMeasCell.DataMember = "vJ_MeasCell";
            this.bsMeasCell.DataSource = this.dsJournal;
            // 
            // label_23
            // 
            this.label_23.AutoSize = true;
            this.label_23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_23.Location = new System.Drawing.Point(3, 0);
            this.label_23.Name = "label_23";
            this.label_23.Size = new System.Drawing.Size(152, 21);
            this.label_23.TabIndex = 18;
            this.label_23.Text = "Секция шин №";
            this.label_23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_2
            // 
            this.comboBox_2.DataSource = this.bsBusesTransfs;
            this.comboBox_2.DisplayMember = "Name";
            this.comboBox_2.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_2.FormattingEnabled = true;
            this.comboBox_2.Location = new System.Drawing.Point(158, 0);
            this.comboBox_2.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_2.Name = "comboBox_2";
            this.comboBox_2.Size = new System.Drawing.Size(103, 21);
            this.comboBox_2.TabIndex = 19;
            this.comboBox_2.ValueMember = "idBus";
            // 
            // lbTransfName
            // 
            this.lbTransfName.AutoSize = true;
            this.lbTransfName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTransfName.Location = new System.Drawing.Point(304, 0);
            this.lbTransfName.Name = "lbTransfName";
            this.lbTransfName.Size = new System.Drawing.Size(106, 21);
            this.lbTransfName.TabIndex = 21;
            this.lbTransfName.Text = "Трансформатор № ";
            this.lbTransfName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idBus
            // 
            this.idBus.DataPropertyName = "idBus";
            this.idBus.HeaderText = "idBus";
            this.idBus.Name = "idBus";
            this.idBus.ReadOnly = true;
            // 
            // idTransf
            // 
            this.idTransf.DataPropertyName = "idTransf";
            this.idTransf.HeaderText = "idTransf";
            this.idTransf.Name = "idTransf";
            this.idTransf.ReadOnly = true;
            // 
            // idCable
            // 
            this.idCable.DataPropertyName = "idCable";
            this.idCable.HeaderText = "idCable";
            this.idCable.Name = "idCable";
            this.idCable.ReadOnly = true;
            // 
            // tableLayoutPanel_2
            // 
            this.tableLayoutPanel_2.ColumnCount = 2;
            this.tableLayoutPanel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_2.Controls.Add(this.tableLayoutPanel_1, 1, 0);
            this.tableLayoutPanel_2.Controls.Add(this.tableLayoutPanel_0, 0, 0);
            this.tableLayoutPanel_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_2.Name = "tableLayoutPanel_2";
            this.tableLayoutPanel_2.RowCount = 1;
            this.tableLayoutPanel_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_2.Size = new System.Drawing.Size(1034, 562);
            this.tableLayoutPanel_2.TabIndex = 3;
            // 
            // deletedDataGridViewCheckBoxColumn2
            // 
            this.deletedDataGridViewCheckBoxColumn2.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn2.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn2.Name = "deletedDataGridViewCheckBoxColumn2";
            // 
            // deletedDataGridViewCheckBoxColumn3
            // 
            this.deletedDataGridViewCheckBoxColumn3.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn3.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn3.Name = "deletedDataGridViewCheckBoxColumn3";
            // 
            // bsCellByTransf
            // 
            this.bsCellByTransf.DataMember = "fn_J_GetCellLVByTransf";
            this.bsCellByTransf.DataSource = this.dsJournal;
            // 
            // bsCableMakeup
            // 
            this.bsCableMakeup.DataMember = "tR_CableMakeup";
            this.bsCableMakeup.DataSource = this.dsJournal;
            this.bsCableMakeup.Filter = "";
            // 
            // bsVoltage
            // 
            this.bsVoltage.DataMember = "tR_CableVoltage";
            this.bsVoltage.DataSource = this.dsJournal;
            this.bsVoltage.Filter = "";
            // 
            // bsCrossSection
            // 
            this.bsCrossSection.DataMember = "tR_CrossSection";
            this.bsCrossSection.DataSource = this.dsJournal;
            this.bsCrossSection.Filter = "";
            // 
            // bsValueLists
            // 
            this.bsValueLists.DataMember = "tP_ValueLists";
            this.bsValueLists.DataSource = this.dsJournal;
            // 
            // bsTypeDoc
            // 
            this.bsTypeDoc.DataMember = "tR_Classifier";
            this.bsTypeDoc.DataSource = this.dsJournal;
            this.bsTypeDoc.Filter = "ParentKey = \';Measurement;Type;\'";
            // 
            // bsMeasYear
            // 
            this.bsMeasYear.DataMember = "vJ_GetMeasYears";
            this.bsMeasYear.DataSource = this.dsJournal;
            this.bsMeasYear.Sort = "Year DESC";
            this.bsMeasYear.CurrentChanged += new System.EventHandler(this.bsMeasYear_CurrentChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idSchmObj";
            this.dataGridViewTextBoxColumn1.HeaderText = "idSchmObj";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn2.HeaderText = "Район";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn3.HeaderText = "Улица";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "House";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дом";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HousePrefix";
            this.dataGridViewTextBoxColumn5.HeaderText = "Доп.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.HeaderText = "SumName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 360;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.HeaderText = "ad";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 40;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.HeaderText = "an";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 40;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn10.HeaderText = "bd";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 40;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn11.HeaderText = "bn";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 40;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn12.HeaderText = "cd";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 40;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn13.HeaderText = "cn";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 40;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn14.HeaderText = "od";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 40;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "on";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 40;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "NameCell";
            this.dataGridViewTextBoxColumn17.HeaderText = "№ руб.";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 30;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn18.HeaderText = "id";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "idMeasurement";
            this.dataGridViewTextBoxColumn19.HeaderText = "idMeasurement";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "idTransf";
            this.dataGridViewTextBoxColumn20.HeaderText = "idTransf";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "idCell";
            this.dataGridViewTextBoxColumn21.HeaderText = "idCell";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn21.Visible = false;
            this.dataGridViewTextBoxColumn21.Width = 30;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "OldCell";
            this.dataGridViewTextBoxColumn22.HeaderText = "№ Ст.р";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 30;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "PermisAmperage";
            dataGridViewCellStyle23.Format = "N0";
            this.dataGridViewTextBoxColumn30.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn30.HeaderText = "Допуст. нагр., А";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 50;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Iad";
            dataGridViewCellStyle24.Format = "N0";
            dataGridViewCellStyle24.NullValue = null;
            this.dataGridViewTextBoxColumn31.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn31.HeaderText = "А дн.";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 40;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Ibd";
            this.dataGridViewTextBoxColumn33.HeaderText = "В дн.";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Width = 40;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Ibn";
            this.dataGridViewTextBoxColumn34.HeaderText = "В вч.";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Width = 40;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Icd";
            this.dataGridViewTextBoxColumn35.HeaderText = "С дн.";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.Width = 40;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Icn";
            this.dataGridViewTextBoxColumn36.HeaderText = "С вч.";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.Width = 40;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Iod";
            this.dataGridViewTextBoxColumn37.HeaderText = "0 дн.";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.Width = 40;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Ion";
            this.dataGridViewTextBoxColumn38.HeaderText = "0 вч.";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.Width = 40;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn39.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn39.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn40.HeaderText = "id";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.Visible = false;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "idObjList";
            this.dataGridViewTextBoxColumn41.HeaderText = "idObjList";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.Visible = false;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "DateD";
            this.dataGridViewTextBoxColumn42.HeaderText = "Дата замера дн.";
            this.dataGridViewTextBoxColumn42.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "TemperatureD";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn43.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn43.HeaderText = "Температура дн.";
            this.dataGridViewTextBoxColumn43.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "DateN";
            this.dataGridViewTextBoxColumn44.HeaderText = "Дата замера вч.";
            this.dataGridViewTextBoxColumn44.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "TemperatureN";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn45.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewTextBoxColumn45.HeaderText = "Температура вч.";
            this.dataGridViewTextBoxColumn45.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn46.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn46.HeaderText = "Дополнительно";
            this.dataGridViewTextBoxColumn46.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn47.HeaderText = "SumName";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.Width = 110;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn48.HeaderText = "ad";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.Width = 60;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn49.HeaderText = "an";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.Width = 60;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn50.HeaderText = "bd";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.Width = 60;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn51.HeaderText = "bn";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.Width = 60;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn52.HeaderText = "cd";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.Width = 60;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn53.HeaderText = "cn";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.Width = 60;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn54.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn54.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn55.HeaderText = "id";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.Visible = false;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "idMeasurement";
            this.dataGridViewTextBoxColumn56.HeaderText = "idMeasurement";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.Visible = false;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "idBus";
            this.dataGridViewTextBoxColumn57.HeaderText = "idBus";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.Visible = false;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "NameBus";
            this.dataGridViewTextBoxColumn58.HeaderText = "NameBus";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.Visible = false;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "NameCell";
            this.dataGridViewTextBoxColumn59.HeaderText = "№ руб.";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.Width = 30;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "PermissAmperage";
            this.dataGridViewTextBoxColumn60.HeaderText = "Допуст. нагр., А";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.Width = 80;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "Iad";
            this.dataGridViewTextBoxColumn61.HeaderText = "А дн.";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.Width = 60;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "Ian";
            this.dataGridViewTextBoxColumn62.HeaderText = "А вч.";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.Width = 60;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "Ibd";
            this.dataGridViewTextBoxColumn63.HeaderText = "В дн.";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.Width = 60;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "Ibn";
            this.dataGridViewTextBoxColumn64.HeaderText = "В вч.";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.Width = 60;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "Icd";
            this.dataGridViewTextBoxColumn65.HeaderText = "С дн.";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.Width = 60;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.DataPropertyName = "Icn";
            this.dataGridViewTextBoxColumn66.HeaderText = "С вч.";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn66.Width = 60;
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn67.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn67.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // idObjListDataGridViewTextBoxColumn1
            // 
            this.idObjListDataGridViewTextBoxColumn1.DataPropertyName = "idObjList";
            this.idObjListDataGridViewTextBoxColumn1.HeaderText = "idObjList";
            this.idObjListDataGridViewTextBoxColumn1.Name = "idObjListDataGridViewTextBoxColumn1";
            // 
            // typeDocDataGridViewTextBoxColumn
            // 
            this.typeDocDataGridViewTextBoxColumn.DataPropertyName = "TypeDoc";
            this.typeDocDataGridViewTextBoxColumn.HeaderText = "TypeDoc";
            this.typeDocDataGridViewTextBoxColumn.Name = "typeDocDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // dateDDataGridViewTextBoxColumn1
            // 
            this.dateDDataGridViewTextBoxColumn1.DataPropertyName = "DateD";
            this.dateDDataGridViewTextBoxColumn1.HeaderText = "DateD";
            this.dateDDataGridViewTextBoxColumn1.Name = "dateDDataGridViewTextBoxColumn1";
            // 
            // temperatureDDataGridViewTextBoxColumn1
            // 
            this.temperatureDDataGridViewTextBoxColumn1.DataPropertyName = "TemperatureD";
            this.temperatureDDataGridViewTextBoxColumn1.HeaderText = "TemperatureD";
            this.temperatureDDataGridViewTextBoxColumn1.Name = "temperatureDDataGridViewTextBoxColumn1";
            // 
            // dateNDataGridViewTextBoxColumn1
            // 
            this.dateNDataGridViewTextBoxColumn1.DataPropertyName = "DateN";
            this.dateNDataGridViewTextBoxColumn1.HeaderText = "DateN";
            this.dateNDataGridViewTextBoxColumn1.Name = "dateNDataGridViewTextBoxColumn1";
            // 
            // temperatureNDataGridViewTextBoxColumn1
            // 
            this.temperatureNDataGridViewTextBoxColumn1.DataPropertyName = "TemperatureN";
            this.temperatureNDataGridViewTextBoxColumn1.HeaderText = "TemperatureN";
            this.temperatureNDataGridViewTextBoxColumn1.Name = "temperatureNDataGridViewTextBoxColumn1";
            // 
            // idWorkerDataGridViewTextBoxColumn1
            // 
            this.idWorkerDataGridViewTextBoxColumn1.DataPropertyName = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn1.HeaderText = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn1.Name = "idWorkerDataGridViewTextBoxColumn1";
            // 
            // commentDataGridViewTextBoxColumn1
            // 
            this.commentDataGridViewTextBoxColumn1.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn1.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            // 
            // idMeasurementDataGridViewTextBoxColumn
            // 
            this.idMeasurementDataGridViewTextBoxColumn.DataPropertyName = "idMeasurement";
            this.idMeasurementDataGridViewTextBoxColumn.HeaderText = "idMeasurement";
            this.idMeasurementDataGridViewTextBoxColumn.Name = "idMeasurementDataGridViewTextBoxColumn";
            // 
            // idTransfDataGridViewTextBoxColumn
            // 
            this.idTransfDataGridViewTextBoxColumn.DataPropertyName = "idTransf";
            this.idTransfDataGridViewTextBoxColumn.HeaderText = "idTransf";
            this.idTransfDataGridViewTextBoxColumn.Name = "idTransfDataGridViewTextBoxColumn";
            // 
            // idCellDataGridViewTextBoxColumn1
            // 
            this.idCellDataGridViewTextBoxColumn1.DataPropertyName = "idCell";
            this.idCellDataGridViewTextBoxColumn1.HeaderText = "idCell";
            this.idCellDataGridViewTextBoxColumn1.Name = "idCellDataGridViewTextBoxColumn1";
            // 
            // nameCellDataGridViewTextBoxColumn
            // 
            this.nameCellDataGridViewTextBoxColumn.DataPropertyName = "NameCell";
            this.nameCellDataGridViewTextBoxColumn.HeaderText = "NameCell";
            this.nameCellDataGridViewTextBoxColumn.Name = "nameCellDataGridViewTextBoxColumn";
            // 
            // oldCellDataGridViewTextBoxColumn
            // 
            this.oldCellDataGridViewTextBoxColumn.DataPropertyName = "OldCell";
            this.oldCellDataGridViewTextBoxColumn.HeaderText = "OldCell";
            this.oldCellDataGridViewTextBoxColumn.Name = "oldCellDataGridViewTextBoxColumn";
            // 
            // idCableDataGridViewTextBoxColumn1
            // 
            this.idCableDataGridViewTextBoxColumn1.DataPropertyName = "idCable";
            this.idCableDataGridViewTextBoxColumn1.HeaderText = "idCable";
            this.idCableDataGridViewTextBoxColumn1.Name = "idCableDataGridViewTextBoxColumn1";
            // 
            // idSchmAbnDataGridViewTextBoxColumn1
            // 
            this.idSchmAbnDataGridViewTextBoxColumn1.DataPropertyName = "idSchmAbn";
            this.idSchmAbnDataGridViewTextBoxColumn1.HeaderText = "idSchmAbn";
            this.idSchmAbnDataGridViewTextBoxColumn1.Name = "idSchmAbnDataGridViewTextBoxColumn1";
            // 
            // makeupDataGridViewTextBoxColumn1
            // 
            this.makeupDataGridViewTextBoxColumn1.DataPropertyName = "Makeup";
            this.makeupDataGridViewTextBoxColumn1.HeaderText = "Makeup";
            this.makeupDataGridViewTextBoxColumn1.Name = "makeupDataGridViewTextBoxColumn1";
            // 
            // voltageDataGridViewTextBoxColumn1
            // 
            this.voltageDataGridViewTextBoxColumn1.DataPropertyName = "Voltage";
            this.voltageDataGridViewTextBoxColumn1.HeaderText = "Voltage";
            this.voltageDataGridViewTextBoxColumn1.Name = "voltageDataGridViewTextBoxColumn1";
            // 
            // wiresDataGridViewTextBoxColumn1
            // 
            this.wiresDataGridViewTextBoxColumn1.DataPropertyName = "Wires";
            this.wiresDataGridViewTextBoxColumn1.HeaderText = "Wires";
            this.wiresDataGridViewTextBoxColumn1.Name = "wiresDataGridViewTextBoxColumn1";
            // 
            // crossSectionDataGridViewTextBoxColumn1
            // 
            this.crossSectionDataGridViewTextBoxColumn1.DataPropertyName = "CrossSection";
            this.crossSectionDataGridViewTextBoxColumn1.HeaderText = "CrossSection";
            this.crossSectionDataGridViewTextBoxColumn1.Name = "crossSectionDataGridViewTextBoxColumn1";
            // 
            // permisAmperageDataGridViewTextBoxColumn
            // 
            this.permisAmperageDataGridViewTextBoxColumn.DataPropertyName = "PermisAmperage";
            this.permisAmperageDataGridViewTextBoxColumn.HeaderText = "PermisAmperage";
            this.permisAmperageDataGridViewTextBoxColumn.Name = "permisAmperageDataGridViewTextBoxColumn";
            // 
            // iadDataGridViewTextBoxColumn
            // 
            this.iadDataGridViewTextBoxColumn.DataPropertyName = "Iad";
            this.iadDataGridViewTextBoxColumn.HeaderText = "Iad";
            this.iadDataGridViewTextBoxColumn.Name = "iadDataGridViewTextBoxColumn";
            // 
            // ianDataGridViewTextBoxColumn
            // 
            this.ianDataGridViewTextBoxColumn.DataPropertyName = "Ian";
            this.ianDataGridViewTextBoxColumn.HeaderText = "Ian";
            this.ianDataGridViewTextBoxColumn.Name = "ianDataGridViewTextBoxColumn";
            // 
            // ibdDataGridViewTextBoxColumn
            // 
            this.ibdDataGridViewTextBoxColumn.DataPropertyName = "Ibd";
            this.ibdDataGridViewTextBoxColumn.HeaderText = "Ibd";
            this.ibdDataGridViewTextBoxColumn.Name = "ibdDataGridViewTextBoxColumn";
            // 
            // ibnDataGridViewTextBoxColumn
            // 
            this.ibnDataGridViewTextBoxColumn.DataPropertyName = "Ibn";
            this.ibnDataGridViewTextBoxColumn.HeaderText = "Ibn";
            this.ibnDataGridViewTextBoxColumn.Name = "ibnDataGridViewTextBoxColumn";
            // 
            // icdDataGridViewTextBoxColumn
            // 
            this.icdDataGridViewTextBoxColumn.DataPropertyName = "Icd";
            this.icdDataGridViewTextBoxColumn.HeaderText = "Icd";
            this.icdDataGridViewTextBoxColumn.Name = "icdDataGridViewTextBoxColumn";
            // 
            // icnDataGridViewTextBoxColumn
            // 
            this.icnDataGridViewTextBoxColumn.DataPropertyName = "Icn";
            this.icnDataGridViewTextBoxColumn.HeaderText = "Icn";
            this.icnDataGridViewTextBoxColumn.Name = "icnDataGridViewTextBoxColumn";
            // 
            // iodDataGridViewTextBoxColumn
            // 
            this.iodDataGridViewTextBoxColumn.DataPropertyName = "Iod";
            this.iodDataGridViewTextBoxColumn.HeaderText = "Iod";
            this.iodDataGridViewTextBoxColumn.Name = "iodDataGridViewTextBoxColumn";
            // 
            // ionDataGridViewTextBoxColumn
            // 
            this.ionDataGridViewTextBoxColumn.DataPropertyName = "Ion";
            this.ionDataGridViewTextBoxColumn.HeaderText = "Ion";
            this.ionDataGridViewTextBoxColumn.Name = "ionDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn2
            // 
            this.commentDataGridViewTextBoxColumn2.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn2.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn2.Name = "commentDataGridViewTextBoxColumn2";
            // 
            // bindingSource_18
            // 
            this.bindingSource_18.DataMember = "vJ_BusesTransfSchema";
            this.bindingSource_18.DataSource = this.dsJournal;
            // 
            // FormMeasurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 562);
            this.Controls.Add(this.tableLayoutPanel_2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMeasurement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Листок замеров (N)";
            this.Load += new System.EventHandler(this.FormMeasurement_Load);
            this.Shown += new System.EventHandler(this.FormMeasurement_Shown);
            this.tableLayoutPanel_0.ResumeLayout(false);
            this.tableLayoutPanel_0.PerformLayout();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            this.tableLayoutPanel_1.ResumeLayout(false);
            this.tableLayoutPanel_1.PerformLayout();
            this.toolStrip_1.ResumeLayout(false);
            this.toolStrip_1.PerformLayout();
            this.tlpMeasurementLow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsBusesTransfs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJournal)).EndInit();
            this.tcMeasurement.ResumeLayout(false);
            this.tpRatio.ResumeLayout(false);
            this.tpRatio.PerformLayout();
            this.tpAddress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbnObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasAbnObj)).EndInit();
            this.panel_0.ResumeLayout(false);
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_0)).EndInit();
            this.panel_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_12)).EndInit();
            this.panel_3.ResumeLayout(false);
            this.panel_3.PerformLayout();
            this.panel_4.ResumeLayout(false);
            this.panel_4.PerformLayout();
            this.panel_5.ResumeLayout(false);
            this.panel_5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumCable)).EndInit();
            this.panel_6.ResumeLayout(false);
            this.panel_7.ResumeLayout(false);
            this.panel_7.PerformLayout();
            this.panel_9.ResumeLayout(false);
            this.panel_9.PerformLayout();
            this.panel_10.ResumeLayout(false);
            this.panel_10.PerformLayout();
            this.panel_11.ResumeLayout(false);
            this.panel_11.PerformLayout();
            this.panel_12.ResumeLayout(false);
            this.panel_12.PerformLayout();
            this.panel_13.ResumeLayout(false);
            this.panel_13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasCable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasCable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDispatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasurement)).EndInit();
            this.tlpMeasurementHigh.ResumeLayout(false);
            this.tlpMeasurementHigh.PerformLayout();
            this.panel_14.ResumeLayout(false);
            this.panel_15.ResumeLayout(false);
            this.panel_15.PerformLayout();
            this.panel_16.ResumeLayout(false);
            this.panel_16.PerformLayout();
            this.panel_17.ResumeLayout(false);
            this.panel_17.PerformLayout();
            this.panel_18.ResumeLayout(false);
            this.panel_18.PerformLayout();
            this.panel_19.ResumeLayout(false);
            this.panel_20.ResumeLayout(false);
            this.panel_21.ResumeLayout(false);
            this.panel_22.ResumeLayout(false);
            this.panel_23.ResumeLayout(false);
            this.panel_23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasAmperageTransf)).EndInit();
            this.panel_24.ResumeLayout(false);
            this.panel_24.PerformLayout();
            this.panel_25.ResumeLayout(false);
            this.panel_25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransf)).EndInit();
            this.tableLayoutPanel_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsCellByTransf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCableMakeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCrossSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsValueLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypeDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_18)).EndInit();
            this.ResumeLayout(false);

        }
        private DataSetMeasurementN dsJournal;
        //private DataSets.DataSetGES dsJournal;
        private Button button_0;
        private ComboBox comboBoxBusesTransfs;
        private ComboBox cbSwitchPosition;
        private ComboBox comboBox_2;
        private DataGridView dgvAbnObj;
        private DataGridView dgvSumCable;
        private DataGridView dgvMeasCable;
        private DataGridView dgvMeasurement;
        private DataGridView dgvSumCell;
        private DataGridView dgvMeasCell;
        //private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        //private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;
        //private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;
        //private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3;
        //private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_4;
        //private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_100;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_101;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_102;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_103;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_104;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_105;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_106;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_107;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_108;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_109;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_110;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_111;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_112;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_113;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_114;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_115;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_116;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_117;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_118;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_119;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_120;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_121;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_122;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_123;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_124;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_125;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_126;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_127;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_128;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_129;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_130;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_131;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_132;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_133;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_134;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_135;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_136;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_137;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_138;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_139;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_140;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_141;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_142;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_143;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_144;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_145;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_146;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_147;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_148;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_149;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_150;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_151;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_152;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_153;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_156;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_64;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_65;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_66;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_67;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_68;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_69;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_70;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_71;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_72;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_73;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_74;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_75;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_76;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_77;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_78;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_79;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_80;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_81;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_82;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_83;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_84;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_85;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_86;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_87;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_88;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_89;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_90;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_91;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_92;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_93;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_94;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_95;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_96;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_97;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_98;
        //private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_99;

        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bsWorker;
        private BindingSource bsMeasAmperageTransf;
        private BindingSource bindingSource_12;
        private BindingSource bsTypeDoc;
        private BindingSource bsMeasYear;
        private BindingSource bsTransf;
        private BindingSource bsMeasCell;
        private BindingSource bsBusesTransfs;
        private BindingSource bindingSource_18;
        private BindingSource bsDispatcher;
        private BindingSource bsValueLists;
        private BindingSource bsCellByTransf;
        private BindingSource bsCableMakeup;
        private BindingSource bsVoltage;
        private BindingSource bsCrossSection;
        private BindingSource bsMeasCable;
        private BindingSource bsMeasAbnObj;
        private BindingSource bsMeasurement;
        private Label labelTrans;
        private Label label_1;
        private Label label_10;
        private Label label_11;
        private Label label_12;
        private Label label_13;
        private Label label_14;
        private Label label_15;
        private Label label_16;
        private Label label_17;
        private Label label_18;
        private Label label_19;
        private Label label_2;
        private Label label_20;
        private Label label_21;
        private Label label_22;
        private Label label_23;
        private Label label_24;
        private Label label_25;
        private Label label_26;
        private Label label_27;
        private Label label_28;
        private Label label_29;
        private Label label_3;
        private Label lbTransfName;
        private Label label_31;
        private Label label_32;
        private Label label_33;
        private Label label_34;
        private Label label_4;
        private Label label_5;
        private Label label_6;
        private Label label_7;
        private Label label_8;
        private Label label_9;
        private Panel panel_0;
        private Panel panel_1;
        private Panel panel_10;
        private Panel panel_11;
        private Panel panel_12;
        private Panel panel_13;
        private Panel panel_14;
        private Panel panel_15;
        private Panel panel_16;
        private Panel panel_17;
        private Panel panel_18;
        private Panel panel_19;
        private Panel panel_2;
        private Panel panel_20;
        private Panel panel_21;
        private Panel panel_22;
        private Panel panel_23;
        private Panel panel_24;
        private Panel panel_25;
        private Panel panel_3;
        private Panel panel_4;
        private Panel panel_5;
        private Panel panel_6;
        private Panel panel_7;
        private Panel panel_8;
        private Panel panel_9;
        private TabControl tcMeasurement;
        private TableLayoutPanel tableLayoutPanel_0;
        private TableLayoutPanel tableLayoutPanel_1;
        private TableLayoutPanel tableLayoutPanel_2;
        private TableLayoutPanel tlpMeasurementLow;
        private TableLayoutPanel tlpMeasurementHigh;
        private TabPage tpRatio;
        private TabPage tpAddress;
        private TextBox tbKNKFn;
        private TextBox tbKNKFd;
        private TextBox textBox_10;
        private TextBox textBox_11;
        private TextBox textBox_12;
        private TextBox textBox_13;
        private TextBox textBox_14;
        private TextBox textBox_15;
        private TextBox textBox_16;
        private TextBox textBox_17;
        private TextBox textBox_18;
        private TextBox textBox_19;
        private TextBox tbKNTn;
        private TextBox textBox_20;
        private TextBox textBox_21;
        private TextBox textBox_22;
        private TextBox textBox_23;
        private TextBox textBox_24;
        private TextBox textBox_25;
        private TextBox textBox_26;
        private TextBox textBox_27;
        private TextBox textBox_28;
        private TextBox textBox_29;
        private TextBox tbKNTd;
        private TextBox textBox_30;
        private TextBox tbIsrn;
        private TextBox tbIsrd;
        private TextBox textBox_6;
        private TextBox textBox_7;
        private TextBox tbTransAmperage;
        private TextBox textBox_9;
        private ToolStrip toolStrip_0;
        private ToolStrip toolStrip_1;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton tssbMeasAdd;
        private ToolStripButton tsbMeasEdit;
        private ToolStripButton tsbMeasDelete;
        private ToolStripButton toolStripButton_6;
        private ToolStripButton tsbPrint;
        private ToolStripButton toolStripButton_8;
        private ToolStripButton toolStripButtonhelp;
        private ToolStripComboBox toolStripComboBoxtoolStripComboBoxMeasYear;
        private ToolStripLabel toolStripLabel_0;
        private ToolStripMenuItem tsmiExcessLoad;
        private ToolStripMenuItem tsmiCoefficientLoading;
        private ToolStripMenuItem tsmiCoefficientIrregularity;
        private ToolStripMenuItem tsmiTransfByCP;
        private ToolStripMenuItem tsmiMeasLow;
        private ToolStripMenuItem tsmiMeasHigh;
        private ToolStripMenuItem toolStripMenuItemVolumeFreeEnergy;
        private ToolStripMenuItem toolStripMenuItemMeasExist;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;
        private ToolStripSeparator toolStripSeparator_3;
        private ToolStripSeparator toolStripSeparator_4;
        private ToolStripSplitButton tssbReports;
        private ToolStripSplitButton tssbMeasType;
        private ToolStripTextBox toolStripTextBox_0;
        private TreeView treeView;



        private DataGridViewTextBoxColumn SumName;
        private DataGridViewTextBoxColumn ad;
        private DataGridViewTextBoxColumn an;
        private DataGridViewTextBoxColumn bd;
        private DataGridViewTextBoxColumn bn;
        private DataGridViewTextBoxColumn cd;
        private DataGridViewTextBoxColumn cn;
        private DataGridViewTextBoxColumn od;
        private DataGridViewTextBoxColumn on;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn2;
        private DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn idObjListDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn typeDocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn temperatureDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateNDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn temperatureNDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn idMeasurementDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTransfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCellDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameCellDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oldCellDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCableDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idSchmAbnDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn makeupDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn voltageDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn wiresDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn crossSectionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn permisAmperageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ianDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ibdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ibnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn icdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn icnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idMeasurement;
        private DataGridViewTextBoxColumn idBus;
        private DataGridViewTextBoxColumn idTransf;
        private DataGridViewTextBoxColumn idCell;
        private DataGridViewTextBoxColumn OldCell;
        private DataGridViewTextBoxColumn NameCell;
        private DataGridViewTextBoxColumn NameCable;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn idCable;
        private DataGridViewTextBoxColumn idSchmAbn;
        private DataGridViewTextBoxColumn Makeup;
        private DataGridViewTextBoxColumn Voltage;
        private DataGridViewTextBoxColumn Wires;
        private DataGridViewTextBoxColumn CrossSection;
        private DataGridViewTextBoxColumn PermisAmperage;
        private DataGridViewTextBoxColumn Iad;
        private DataGridViewTextBoxColumn Ian;
        private DataGridViewTextBoxColumn Ibd;
        private DataGridViewTextBoxColumn Ibn;
        private DataGridViewTextBoxColumn Icd;
        private DataGridViewTextBoxColumn Icn;
        private DataGridViewTextBoxColumn Iod;
        private DataGridViewTextBoxColumn Ion;
        private DataGridViewTextBoxColumn Comment;
        private DataGridViewCheckBoxColumn Deleted;
        private DataGridViewComboBoxColumn idWorkerDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idWorkerCheck;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idObjListDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDocDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn temperatureDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn temperatureNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn idOldMeasurementDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn idSchmObjDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDocDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn idMeasurementDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn idBusDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idTransfDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nameBusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameCellDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn permisAmperageDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn iadDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ianDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ibdDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ibnDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn icdDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn icnDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn iodDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ionDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn4;
        private DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn4;
    }
    //
}
